using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_u32TxOutZ : CommonBase {
	internal TwoTuple_u32TxOutZ(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_u32TxOutZ() {
		if (ptr != 0) { Bindings.C2TupleU32TxoutzFree(ptr); }
	}

	/**
	 * 
	 */
	public int get_a() {
		int ret = Bindings.C2TupleU32TxoutzGetA(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * 
	 */
	public TxOut get_b() {
		long ret = Bindings.C2TupleU32TxoutzGetB(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TxOut ret_conv = new TxOut(null, ret);
		return ret_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.C2TupleU32TxoutzClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_u32TxOutZ clone() {
		long ret = Bindings.C2TupleU32TxoutzClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_u32TxOutZ ret_hu_conv = new TwoTuple_u32TxOutZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_u32TxOutZ from the contained elements.
	 */
	public static TwoTuple_u32TxOutZ of(int a, org.ldk.structs.TxOut b) {
		long ret = Bindings.C2TupleU32TxoutzNew(a, b.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_u32TxOutZ ret_hu_conv = new TwoTuple_u32TxOutZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
