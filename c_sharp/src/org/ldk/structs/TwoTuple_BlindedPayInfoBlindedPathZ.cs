using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_BlindedPayInfoBlindedPathZ : CommonBase {
	internal TwoTuple_BlindedPayInfoBlindedPathZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_BlindedPayInfoBlindedPathZ() {
		if (ptr != 0) { Bindings.C2TupleBlindedPayInfoBlindedPathZFree(ptr); }
	}

	/**
	 * 
	 */
	public BlindedPayInfo get_a() {
		long ret = Bindings.C2TupleBlindedPayInfoBlindedPathZGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BlindedPayInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BlindedPayInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public BlindedPath get_b() {
		long ret = Bindings.C2TupleBlindedPayInfoBlindedPathZGetB(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BlindedPath ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BlindedPath(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.C2TupleBlindedPayInfoBlindedPathZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_BlindedPayInfoBlindedPathZ clone() {
		long ret = Bindings.C2TupleBlindedPayInfoBlindedPathZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_BlindedPayInfoBlindedPathZ ret_hu_conv = new TwoTuple_BlindedPayInfoBlindedPathZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_BlindedPayInfoBlindedPathZ from the contained elements.
	 */
	public static TwoTuple_BlindedPayInfoBlindedPathZ of(org.ldk.structs.BlindedPayInfo a, org.ldk.structs.BlindedPath b) {
		long ret = Bindings.C2TupleBlindedPayInfoBlindedPathZNew(a == null ? 0 : a.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_BlindedPayInfoBlindedPathZ ret_hu_conv = new TwoTuple_BlindedPayInfoBlindedPathZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(a); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(b); };
		return ret_hu_conv;
	}

}
} } }
