using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_PublicKeyTypeZ : CommonBase {
	internal TwoTuple_PublicKeyTypeZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_PublicKeyTypeZ() {
		if (ptr != 0) { Bindings.C2TuplePublicKeyTypeZFree(ptr); }
	}

	/**
	 * 
	 */
	public byte[] get_a() {
		long ret = Bindings.C2TuplePublicKeyTypeZGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * 
	 */
	public Type get_b() {
		long ret = Bindings.C2TuplePublicKeyTypeZGetB(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Type ret_hu_conv = new Type(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.C2TuplePublicKeyTypeZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_PublicKeyTypeZ clone() {
		long ret = Bindings.C2TuplePublicKeyTypeZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_PublicKeyTypeZ ret_hu_conv = new TwoTuple_PublicKeyTypeZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_PublicKeyTypeZ from the contained elements.
	 */
	public static TwoTuple_PublicKeyTypeZ of(byte[] a, org.ldk.structs.Type b) {
		long ret = Bindings.C2TuplePublicKeyTypeZNew(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(a, 33)), b.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_PublicKeyTypeZ ret_hu_conv = new TwoTuple_PublicKeyTypeZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(b); };
		return ret_hu_conv;
	}

}
} } }
