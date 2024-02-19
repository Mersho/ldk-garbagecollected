#!/bin/bash
usage() {
	echo "USAGE: path/to/ldk-c-bindings [wasm|\"JNI_CFLAGS\"] debug android_web"
	echo "For JNI_CFLAGS you probably want -I/usr/lib/jvm/java-11-openjdk-amd64/include/ -I/usr/lib/jvm/java-11-openjdk-amd64/include/linux/"
	echo "If JNI_CFLAGS is instead set to wasm, we build for wasm/TypeScript instead of Java"
	echo "debug should either be true, false, or leaks"
	echo "debug of leaks turns on leak tracking on an optimized release bianry"
	echo "android_web should either be true or false and indicates if we build for android (Java) or web (WASM)"
	echo "Note that web currently generates the same results as !web (ie Node.JS)"
	exit 1
}
[ "$1" = "" ] && usage
[ "$3" != "true" -a "$3" != "false" -a "$3" != "leaks" ] && usage
[ "$4" != "true" -a "$4" != "false" ] && usage

set -e
set -x

function is_gnu_sed(){
  sed --version >/dev/null 2>&1
}

if [ "$CC" = "" ]; then
	CC=clang
fi

TARGET_STRING="$LDK_TARGET"
if [ "$TARGET_STRING" = "" ]; then
	# We assume clang-style $CC --version here, but worst-case we just get an empty suffix
	TARGET_STRING="$($CC --version | grep Target | awk '{ print $2 }')"
fi

IS_MAC=false
[ "$($CC --version | grep apple-darwin)" != "" ] && IS_MAC=true
IS_APPLE_CLANG=false
[ "$($CC --version | grep "Apple clang version")" != "" ] && IS_APPLE_CLANG=true

case "$TARGET_STRING" in
	"x86_64-pc-linux"*)
		LDK_TARGET_SUFFIX="_Linux-amd64"
		LDK_JAR_TARGET=true
		;;
	"x86_64-apple-darwin"*)
		LDK_TARGET_SUFFIX="_MacOSX-x86_64"
		LDK_JAR_TARGET=true
		IS_MAC=true
		;;
	"aarch64-apple-darwin"*)
		LDK_TARGET_CPU="apple-a14"
		LDK_TARGET_SUFFIX="_MacOSX-aarch64"
		LDK_JAR_TARGET=true
		IS_MAC=true
		;;
	*)
		LDK_TARGET_SUFFIX="_${TARGET_STRING}"
esac
if [ "$LDK_TARGET_CPU" = "" ]; then
	LDK_TARGET_CPU="sandybridge"
fi

COMMON_COMPILE="$CC -std=c11 -Wall -Wextra -Wno-unused-parameter -Wno-ignored-qualifiers -Wno-unused-function -Wno-nullability-completeness -Wno-pointer-sign -Wdate-time -ffile-prefix-map=$(pwd)="
[ "$IS_MAC" = "true" -a "$2" != "wasm" ] && COMMON_COMPILE="$COMMON_COMPILE --target=$TARGET_STRING -mcpu=$LDK_TARGET_CPU"

DEBUG_ARG="$3"
if [ "$3" = "leaks" ]; then
	DEBUG_ARG="true"
fi

cp "$1/lightning-c-bindings/include/lightning.h" ./
if is_gnu_sed; then
	sed -i "s/TransactionOutputs/C2Tuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ/g" ./lightning.h
else
	# OSX sed is for some reason not compatible with GNU sed
	sed -i '' "s/TransactionOutputs/C2Tuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ/g" ./lightning.h
fi
echo "#define LDKCVec_C2Tuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZZ LDKCVec_TransactionOutputsZ" > header.c
echo "#define CVec_C2Tuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZZ_free CVec_TransactionOutputsZ_free" >> header.c


if [ "$LDK_GARBAGECOLLECTED_GIT_OVERRIDE" = "" ]; then
	export LDK_GARBAGECOLLECTED_GIT_OVERRIDE=$(git describe --tag --dirty)
fi
if [ "${LDK_GARBAGECOLLECTED_GIT_OVERRIDE:0:1}" != "v" ]; then
	echo "Version tag should start with a v" > /dev/stderr
	exit 1
fi


if [ "$2" = "c_sharp" ]; then
	echo "Creating C# bindings..."
	mkdir -p c_sharp/src/org/ldk/{enums,structs,impl}
	rm -f c_sharp/src/org/ldk/{enums,structs,impl}/*.cs
	./genbindings.py "./lightning.h" c_sharp/src/org/ldk/impl c_sharp/src/org/ldk c_sharp/ $DEBUG_ARG c_sharp $4 $TARGET_STRING
	rm -f c_sharp/bindings.c
	if [ "$3" = "true" ]; then
		echo "#define LDK_DEBUG_BUILD" > c_sharp/bindings.c
	elif [ "$3" = "leaks" ]; then
		# For leak checking we use release libldk which doesn't expose
		# __unmangle_inner_ptr, but the C code expects to be able to call it.
		echo "#define __unmangle_inner_ptr(a) (a)" > c_sharp/bindings.c
	fi
	cat header.c >> c_sharp/bindings.c
	cat header.c >> c_sharp/bindings.c
	cat c_sharp/bindings.c.body >> c_sharp/bindings.c

	IS_MAC=false
	[ "$($CC --version | grep apple-darwin)" != "" ] && IS_MAC=true
	IS_APPLE_CLANG=false
	[ "$($CC --version | grep "Apple clang version")" != "" ] && IS_APPLE_CLANG=true

	# Compiling C# bindings with Mono
	MONO_COMPILE="-out:csharpldk.dll -langversion:3 -t:library c_sharp/src/org/ldk/enums/*.cs c_sharp/src/org/ldk/impl/*.cs c_sharp/src/org/ldk/util/*.cs c_sharp/src/org/ldk/structs/*.cs"
	if [ "$3" = "true" ]; then
		mono-csc $MONO_COMPILE
	else
		mono-csc -o $MONO_COMPILE
	fi

	echo "Building C# bindings..."
	COMPILE="$COMMON_COMPILE -Isrc/main/jni -pthread -fPIC"
	LINK="-ldl -shared"
	[ "$IS_MAC" = "false" ] && LINK="$LINK -Wl,--no-undefined"
	[ "$IS_MAC" = "true" ] && COMPILE="$COMPILE -mmacosx-version-min=10.9"
	[ "$IS_MAC" = "true" -a "$IS_APPLE_CLANG" = "false" ] && LINK="$LINK -fuse-ld=lld"
	[ "$IS_MAC" = "true" -a "$IS_APPLE_CLANG" = "false" ] && echo "WARNING: Need at least upstream clang 13!"
	[ "$IS_MAC" = "false" -a "$3" != "false" ] && LINK="$LINK -Wl,-wrap,calloc -Wl,-wrap,realloc -Wl,-wrap,malloc -Wl,-wrap,free"

	exit 0 # Sadly compilation doesn't currently work
	if [ "$3" = "true" ]; then
		$COMPILE $LINK -o liblightningjni_debug$LDK_TARGET_SUFFIX.so -g -fsanitize=address -shared-libasan -rdynamic -I"$1"/lightning-c-bindings/include/ $2 c_sharp/bindings.c "$1"/lightning-c-bindings/target/$LDK_TARGET/debug/libldk.a -lm
	else
		$COMPILE -o bindings.o -c -flto -O3 -I"$1"/lightning-c-bindings/include/ $2 c_sharp/bindings.c
		$COMPILE $LINK -o liblightningjni_release$LDK_TARGET_SUFFIX.so -flto -O3 -Wl,--lto-O3 -Wl,-O3 -Wl,--version-script=c_sharp/libcode.version -I"$1"/lightning-c-bindings/include/ $2 bindings.o "$1"/lightning-c-bindings/target/$LDK_TARGET/release/libldk.a -lm
		[ "$IS_APPLE_CLANG" != "true" ] && llvm-strip liblightningjni_release$LDK_TARGET_SUFFIX.so
	fi
elif [ "$2" = "python" ]; then
	echo "Creating Python bindings..."
	mkdir -p python/src/{enums,structs,impl}
	rm -f python/src/{enums,structs,impl}/*.py
	./genbindings.py "./lightning.h" python/src/impl python/src python/ $DEBUG_ARG python $4 $TARGET_STRING
	rm -f python/bindings.c
	if [ "$3" = "true" ]; then
		echo "#define LDK_DEBUG_BUILD" > python/bindings.c
	elif [ "$3" = "leaks" ]; then
		# For leak checking we use release libldk which doesn't expose
		# __unmangle_inner_ptr, but the C code expects to be able to call it.
		echo "#define __unmangle_inner_ptr(a) (a)" > python/bindings.c
	fi
	echo "#define LDKCVec_C2Tuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZZ LDKCVec_TransactionOutputsZ" >> python/bindings.c
	echo "#define CVec_C2Tuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZZ_free CVec_TransactionOutputsZ_free" >> python/bindings.c
	cat python/bindings.c.body >> python/bindings.c

	IS_MAC=false
	[ "$($CC --version | grep apple-darwin)" != "" ] && IS_MAC=true
	IS_APPLE_CLANG=false
	[ "$($CC --version | grep "Apple clang version")" != "" ] && IS_APPLE_CLANG=true

	echo "Building Python bindings..."
	COMPILE="$COMMON_COMPILE -Isrc/main/jni -pthread -fPIC"
	LINK="-ldl -shared"
	[ "$IS_MAC" = "false" ] && LINK="$LINK -Wl,--no-undefined"
	[ "$IS_MAC" = "true" ] && COMPILE="$COMPILE -mmacosx-version-min=10.9"
	[ "$IS_MAC" = "true" -a "$IS_APPLE_CLANG" = "false" ] && LINK="$LINK -fuse-ld=lld"
	[ "$IS_MAC" = "true" -a "$IS_APPLE_CLANG" = "false" ] && echo "WARNING: Need at least upstream clang 13!"
	[ "$IS_MAC" = "false" -a "$3" != "false" ] && LINK="$LINK -Wl,-wrap,calloc -Wl,-wrap,realloc -Wl,-wrap,malloc -Wl,-wrap,free"

	exit 0 # Sadly compilation doesn't currently work
	if [ "$3" = "true" ]; then
		$COMPILE $LINK -o liblightningpython_debug$LDK_TARGET_SUFFIX.so -g -fsanitize=address -shared-libasan -rdynamic -I"$1"/lightning-c-bindings/include/ $2 c_sharp/bindings.c "$1"/lightning-c-bindings/target/$LDK_TARGET/debug/libldk.a -lm
	else
		$COMPILE -o bindings.o -c -flto -O3 -I"$1"/lightning-c-bindings/include/ $2 c_sharp/bindings.c
		$COMPILE $LINK -o liblightningpython_release$LDK_TARGET_SUFFIX.so -Wl,--version-script=python/libcode.version -flto -O3 -Wl,--lto-O3 -Wl,-O3 -I"$1"/lightning-c-bindings/include/ $2 bindings.o "$1"/lightning-c-bindings/target/$LDK_TARGET/release/libldk.a -lm
		[ "$IS_APPLE_CLANG" != "true" ] && llvm-strip liblightningpython_release$LDK_TARGET_SUFFIX.so
	fi
elif [ "$2" = "wasm" ]; then
	echo "Creating TS bindings..."
	mkdir -p ts/{enums,structs}
	rm -f ts/{enums,structs,}/*.{mjs,mts,mts.part}
	if [ "$4" = "false" ]; then
		./genbindings.py "./lightning.h" ts ts ts $DEBUG_ARG typescript node wasm
	else
		./genbindings.py "./lightning.h" ts ts ts $DEBUG_ARG typescript browser wasm
	fi
	rm -f ts/bindings.c
	sed -i 's/^  "version": .*/  "version": "'${LDK_GARBAGECOLLECTED_GIT_OVERRIDE:1:100}'",/g' ts/package.json
	sed -i 's/^  "version": .*/  "version": "'${LDK_GARBAGECOLLECTED_GIT_OVERRIDE:1:100}'",/g' node-net/package.json
	sed -i 's/^    "lightningdevkit": .*/    "lightningdevkit": "'${LDK_GARBAGECOLLECTED_GIT_OVERRIDE:1:100}'"/g' node-net/package.json
	if [ "$3" = "true" ]; then
		echo "#define LDK_DEBUG_BUILD" > ts/bindings.c
	elif [ "$3" = "leaks" ]; then
		# For leak checking we use release libldk which doesn't expose
		# __unmangle_inner_ptr, but the C code expects to be able to call it.
		echo "#define __unmangle_inner_ptr(a) (a)" > ts/bindings.c
	fi
	cat header.c >> ts/bindings.c
	cat ts/bindings.c.body >> ts/bindings.c

	echo "Building TS bindings..."
	COMPILE="$COMMON_COMPILE -flto -Wl,--no-entry -nostdlib --target=wasm32-wasi -Wl,-z -Wl,stack-size=$((8*1024*1024)) -Wl,--initial-memory=$((16*1024*1024)) -Wl,--max-memory=$((1024*1024*1024)) -Wl,--global-base=4096"
	# We only need malloc and assert/abort, but for now just use WASI for those:
	EXTRA_LINK=/usr/lib/wasm32-wasi/libc.a
	[ "$3" != "false" ] && COMPILE="$COMPILE -Wl,-wrap,calloc -Wl,-wrap,realloc -Wl,-wrap,reallocarray -Wl,-wrap,malloc -Wl,-wrap,aligned_alloc -Wl,-wrap,free"
	if [ "$3" = "true" ]; then
		WASM_FILE=liblightningjs_debug.wasm
		$COMPILE -o liblightningjs_debug.wasm -g -O1 -I"$1"/lightning-c-bindings/include/ ts/bindings.c "$1"/lightning-c-bindings/target/wasm32-wasi/debug/libldk.a $EXTRA_LINK
	else
		WASM_FILE=liblightningjs_release.wasm
		$COMPILE -o liblightningjs_release.wasm -s -Oz -I"$1"/lightning-c-bindings/include/ ts/bindings.c "$1"/lightning-c-bindings/target/wasm32-wasi/release/libldk.a $EXTRA_LINK
	fi

	if [ -x "$(which tsc)" ]; then
		cd ts
		for F in structs/*; do
			cat imports.mts.part | grep -v " $(basename -s .mts $F)[ ,]" | cat - $F > $F.tmp
			mv $F.tmp $F
		done
		rm imports.mts.part
		tsc --types node --typeRoots .
		cp ../$WASM_FILE liblightningjs.wasm
		cp ../README.md README.md
		cd ../node-net
		tsc --types node --typeRoots .
		echo Ready to publish!
		if [ -x "$(which node)" ]; then
			NODE_V="$(node --version)"
			if [ "${NODE_V:1:2}" -gt 14 ]; then
				cd ../ts
				node --stack_trace_limit=200 --trace-uncaught test/node.mjs
				cd ../node-net
				node --stack_trace_limit=200 --trace-uncaught test/test.mjs
			fi
		fi
	fi
else
	if is_gnu_sed; then
		sed -i "s/^    <version>.*<\/version>/    <version>${LDK_GARBAGECOLLECTED_GIT_OVERRIDE:1:100}<\/version>/g" pom.xml
	else
	  # OSX sed is for some reason not compatible with GNU sed
		sed -i '' "s/^    <version>.*<\/version>/    <version>${LDK_GARBAGECOLLECTED_GIT_OVERRIDE:1:100}<\/version>/g" pom.xml
	fi

	echo "Creating Java bindings..."
	mkdir -p src/main/java/org/ldk/{enums,structs}
	rm -f src/main/java/org/ldk/{enums,structs}/*.java
	rm -f src/main/jni/*.h
	if [ "$4" = "true" ]; then
		./genbindings.py "./lightning.h" src/main/java/org/ldk/impl src/main/java/org/ldk src/main/jni/ $DEBUG_ARG android $4 $TARGET_STRING
	else
		./genbindings.py "./lightning.h" src/main/java/org/ldk/impl src/main/java/org/ldk src/main/jni/ $DEBUG_ARG java $4 $TARGET_STRING
	fi
	rm -f src/main/jni/bindings.c
	if [ "$3" = "true" ]; then
		echo "#define LDK_DEBUG_BUILD" > src/main/jni/bindings.c
	elif [ "$3" = "leaks" ]; then
		# For leak checking we use release libldk which doesn't expose
		# __unmangle_inner_ptr, but the C code expects to be able to call it.
		echo "#define __unmangle_inner_ptr(a) (a)" > src/main/jni/bindings.c
	fi
	cat header.c >> src/main/jni/bindings.c
	cat header.c >> src/main/jni/bindings.c
	cat src/main/jni/bindings.c.body >> src/main/jni/bindings.c
	javac -h src/main/jni src/main/java/org/ldk/enums/*.java src/main/java/org/ldk/impl/*.java
	rm src/main/java/org/ldk/enums/*.class src/main/java/org/ldk/impl/bindings*.class

	echo "Building Java bindings..."
	COMPILE="$COMMON_COMPILE -Isrc/main/jni -pthread -fPIC"
	LINK="-ldl -shared"
	[ "$IS_MAC" = "false" ] && LINK="$LINK -Wl,--no-undefined"
	[ "$IS_MAC" = "true" ] && COMPILE="$COMPILE -mmacosx-version-min=10.9"
	[ "$IS_MAC" = "true" -a "$IS_APPLE_CLANG" = "false" ] && LINK="$LINK -fuse-ld=lld"
	[ "$IS_MAC" = "true" -a "$IS_APPLE_CLANG" = "false" ] && echo "WARNING: Need at least upstream clang 13!"
	[ "$IS_MAC" = "false" -a "$3" != "false" ] && LINK="$LINK -Wl,-wrap,calloc -Wl,-wrap,realloc -Wl,-wrap,malloc -Wl,-wrap,free"
	if [ "$3" = "true" ]; then
		$COMPILE $LINK -o liblightningjni_debug$LDK_TARGET_SUFFIX.so -g -fsanitize=address -shared-libasan -rdynamic -I"$1"/lightning-c-bindings/include/ $2 src/main/jni/bindings.c "$1"/lightning-c-bindings/target/$LDK_TARGET/debug/libldk.a -lm
	else
		[ "$IS_MAC" = "false" ] && LINK="$LINK -Wl,--no-undefined"
		LDK_LIB="$1"/lightning-c-bindings/target/$LDK_TARGET/release/libldk.a
		if [ "$IS_MAC" = "false" -a "$4" = "false" ]; then
			LINK="$LINK -Wl,--version-script=libcode.version -fuse-ld=lld"
			# __cxa_thread_atexit_impl is used to more effeciently cleanup per-thread local storage by rust libstd.
			# However, it is not available on glibc versions 2.17 or earlier, and rust libstd has a null-check and
			# fallback in case it is missing.
			# Because it is weak-linked on the rust side, we should be able to simply define it
			# explicitly, forcing rust to use the fallback. However, for some reason involving ancient
			# dark magic and haunted code segments, overriding the weak symbol only impacts sites which
			# *call* the symbol in question, not sites which *compare with* the symbol in question.
			# This means that the NULL check in rust's libstd will always think the function is
			# callable while the function which is called ends up being NULL (leading to a jmp to the
			# zero page and a quick SEGFAULT).
			# This issue persists not only with directly providing a symbol, but also ld.lld's -wrap
			# and --defsym arguments.
			# In smaller programs, it appears to be possible to work around this with -Bsymbolic and
			# -nostdlib, however when applied the full-sized JNI library here it no longer works.
			# After exhausting nearly every flag documented in lld, the only reliable method appears
			# to be editing the LDK binary. Luckily, LLVM's tooling makes this rather easy as we can
			# disassemble it into very readable code, edit it, and then reassemble it.
			# Note that if we do so we don't have to bother overriding the actual call, LLVM should
			# optimize it away, which also provides a good check that there isn't anything actually
			# relying on it elsewhere.
			[ ! -f "$1"/lightning-c-bindings/target/$LDK_TARGET/release/libldk.a ] && exit 1
			if [ "$(ar t "$1"/lightning-c-bindings/target/$LDK_TARGET/release/libldk.a | grep -v "\.o$" || echo)" != "" ]; then
				echo "Archive contained non-object files!"
				exit 1
			fi
			if [ "$(ar t "$1"/lightning-c-bindings/target/$LDK_TARGET/release/libldk.a | grep ldk.*-cgu.*.rcgu.o | wc -l)" != "1" ]; then
				echo "Archive contained more than one LDK object file"
				exit 1
			fi
			mkdir -p tmp
			rm -f tmp/*
			ar x --output=tmp "$1"/lightning-c-bindings/target/$LDK_TARGET/release/libldk.a
			pushd tmp
			llvm-dis ldk*-cgu.*.rcgu.o
			sed -i 's/br i1 icmp eq (i8\* @__cxa_thread_atexit_impl, i8\* null)/br i1 icmp eq (i8* null, i8* null)/g' ldk*-cgu.*.rcgu.o.ll
			llvm-as ldk*-cgu.*.rcgu.o.ll -o ./libldk.bc
			ar q libldk.a *.o
			popd
			LDK_LIB="tmp/libldk.bc tmp/libldk.a"
		fi
		$COMPILE -o bindings.o -c -O3 -I"$1"/lightning-c-bindings/include/ $2 src/main/jni/bindings.c
		$COMPILE $LINK -o liblightningjni_release$LDK_TARGET_SUFFIX.so -O3 -I"$1"/lightning-c-bindings/include/ $2 bindings.o $LDK_LIB -lm
		[ "$IS_APPLE_CLANG" != "true" ] && llvm-strip liblightningjni_release$LDK_TARGET_SUFFIX.so
		if [ "$IS_MAC" = "false" -a "$4" = "false" ]; then
			#GLIBC_SYMBS="$(objdump -T liblightningjni_release$LDK_TARGET_SUFFIX.so | grep GLIBC_ | grep -v "GLIBC_2\.2\." | grep -v "GLIBC_2\.3\(\.\| \)" | grep -v "GLIBC_2.\(14\|17\) " || echo)"
			#if [ "$GLIBC_SYMBS" != "" ]; then
			#	echo "Unexpected glibc version dependency! Some users need glibc 2.17 support, symbols for newer glibcs cannot be included."
			#	echo "$GLIBC_SYMBS"
			#	exit 1
			#fi
			#REALLOC_ARRAY_SYMBS="$(objdump -T liblightningjni_release$LDK_TARGET_SUFFIX.so | grep reallocarray || echo)"
			#if [ "$REALLOC_ARRAY_SYMBS" != "" ]; then
			#	echo "Unexpected reallocarray dependency!"
			#	exit 1
			#fi
		fi
		if [ "$LDK_JAR_TARGET" = "true" ]; then
			# Copy to JNI native directory for inclusion in JARs
			mkdir -p src/main/resources/
			cp liblightningjni_release$LDK_TARGET_SUFFIX.so src/main/resources/liblightningjni$LDK_TARGET_SUFFIX.nativelib
		fi
	fi
fi
