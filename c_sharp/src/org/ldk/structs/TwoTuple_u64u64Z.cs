using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple_u64u64Z : CommonBase {
	internal TwoTuple_u64u64Z(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple_u64u64Z() {
		if (ptr != 0) { Bindings.C2TupleU64U64ZFree(ptr); }
	}

	/**
	 * 
	 */
	public long get_a() {
		long ret = Bindings.C2TupleU64U64ZGetA(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * 
	 */
	public long get_b() {
		long ret = Bindings.C2TupleU64U64ZGetB(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.C2TupleU64U64ZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple_u64u64Z clone() {
		long ret = Bindings.C2TupleU64U64ZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_u64u64Z ret_hu_conv = new TwoTuple_u64u64Z(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple_u64u64Z from the contained elements.
	 */
	public static TwoTuple_u64u64Z of(long a, long b) {
		long ret = Bindings.C2TupleU64U64ZNew(a, b);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_u64u64Z ret_hu_conv = new TwoTuple_u64u64Z(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
