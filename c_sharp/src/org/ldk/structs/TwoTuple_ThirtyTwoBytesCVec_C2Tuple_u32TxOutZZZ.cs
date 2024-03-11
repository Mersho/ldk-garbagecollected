using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ : CommonBase {
	internal TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ() {
		if (ptr != 0) { Bindings.C2TupleThirtyTwoBytesCVecC2TupleU32TxoutzzzFree(ptr); }
	}

	/**
	 * 
	 */
	public byte[] get_a() {
		long ret = Bindings.C2TupleThirtyTwoBytesCVecC2TupleU32TxoutzzzGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * 
	 */
	public TwoTuple_u32TxOutZ[] get_b() {
		long ret = Bindings.C2TupleThirtyTwoBytesCVecC2TupleU32TxoutzzzGetB(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_20_len = InternalUtils.getArrayLength(ret);
		TwoTuple_u32TxOutZ[] ret_conv_20_arr = new TwoTuple_u32TxOutZ[ret_conv_20_len];
		for (int u = 0; u < ret_conv_20_len; u++) {
			long ret_conv_20 = InternalUtils.getU64ArrayElem(ret, u);
			TwoTuple_u32TxOutZ ret_conv_20_hu_conv = new TwoTuple_u32TxOutZ(null, ret_conv_20);
			if (ret_conv_20_hu_conv != null) { ret_conv_20_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_20_arr[u] = ret_conv_20_hu_conv;
		}
		Bindings.FreeBuffer(ret);
		return ret_conv_20_arr;
	}

	internal long clone_ptr() {
		long ret = Bindings.C2TupleThirtyTwoBytesCVecC2TupleU32TxoutzzzClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ clone() {
		long ret = Bindings.C2TupleThirtyTwoBytesCVecC2TupleU32TxoutzzzClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ ret_hu_conv = new TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ from the contained elements.
	 */
	public static TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ of(byte[] a, TwoTuple_u32TxOutZ[] b) {
		long ret = Bindings.C2TupleThirtyTwoBytesCVecC2TupleU32TxoutzzzNew(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(a, 32)), InternalUtils.encodeUint64Array(InternalUtils.mapArray(b, b_conv_20 => b_conv_20 != null ? b_conv_20.ptr : 0)));
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ ret_hu_conv = new TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
