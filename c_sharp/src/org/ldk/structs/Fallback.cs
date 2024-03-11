using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Fallback address in case no LN payment is possible
 */
public class Fallback : CommonBase {
	protected Fallback(object _dummy, long ptr) : base(ptr) { }
	~Fallback() {
		if (ptr != 0) { Bindings.FallbackFree(ptr); }
	}

	internal static Fallback constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKFallbackTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new Fallback_SegWitProgram(ptr);
			case 1: return new Fallback_PubKeyHash(ptr);
			case 2: return new Fallback_ScriptHash(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Fallback of type SegWitProgram */
	public class Fallback_SegWitProgram : Fallback {
		public WitnessVersion version;
		public byte[] program;
		internal Fallback_SegWitProgram(long ptr) : base(null, ptr) {
			byte version = Bindings.LDKFallbackSegWitProgramGetVersion(ptr);
			WitnessVersion version_conv = new WitnessVersion(version);
			this.version = version_conv;
			long program = Bindings.LDKFallbackSegWitProgramGetProgram(ptr);
			byte[] program_conv = InternalUtils.decodeUint8Array(program);
			this.program = program_conv;
		}
	}
	/** A Fallback of type PubKeyHash */
	public class Fallback_PubKeyHash : Fallback {
		public byte[] pub_key_hash;
		internal Fallback_PubKeyHash(long ptr) : base(null, ptr) {
			long pub_key_hash = Bindings.LDKFallbackPubKeyHashGetPubKeyHash(ptr);
			byte[] pub_key_hash_conv = InternalUtils.decodeUint8Array(pub_key_hash);
			this.pub_key_hash = pub_key_hash_conv;
		}
	}
	/** A Fallback of type ScriptHash */
	public class Fallback_ScriptHash : Fallback {
		public byte[] script_hash;
		internal Fallback_ScriptHash(long ptr) : base(null, ptr) {
			long script_hash = Bindings.LDKFallbackScriptHashGetScriptHash(ptr);
			byte[] script_hash_conv = InternalUtils.decodeUint8Array(script_hash);
			this.script_hash = script_hash_conv;
		}
	}
	internal long clone_ptr() {
		long ret = Bindings.FallbackClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the Fallback
	 */
	public Fallback clone() {
		long ret = Bindings.FallbackClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Fallback ret_hu_conv = org.ldk.structs.Fallback.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SegWitProgram-variant Fallback
	 */
	public static Fallback seg_wit_program(org.ldk.util.WitnessVersion version, byte[] program) {
		long ret = Bindings.FallbackSegWitProgram(version.getVal(), InternalUtils.encodeUint8Array(program));
		GC.KeepAlive(version);
		GC.KeepAlive(program);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Fallback ret_hu_conv = org.ldk.structs.Fallback.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PubKeyHash-variant Fallback
	 */
	public static Fallback pub_key_hash(byte[] a) {
		long ret = Bindings.FallbackPubKeyHash(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(a, 20)));
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Fallback ret_hu_conv = org.ldk.structs.Fallback.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ScriptHash-variant Fallback
	 */
	public static Fallback script_hash(byte[] a) {
		long ret = Bindings.FallbackScriptHash(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(a, 20)));
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Fallback ret_hu_conv = org.ldk.structs.Fallback.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the Fallback.
	 */
	public long hash() {
		long ret = Bindings.FallbackHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two Fallbacks contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.Fallback b) {
		bool ret = Bindings.FallbackEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is Fallback)) return false;
		return this.eq((Fallback)o);
	}
}
} } }
