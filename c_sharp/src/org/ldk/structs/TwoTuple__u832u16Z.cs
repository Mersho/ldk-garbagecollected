using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class TwoTuple__u832u16Z : CommonBase {
	internal TwoTuple__u832u16Z(object _dummy, long ptr) : base(ptr) { }
	~TwoTuple__u832u16Z() {
		if (ptr != 0) { Bindings.C2TupleU832U16ZFree(ptr); }
	}

	/**
	 * 
	 */
	public byte[] get_a() {
		long ret = Bindings.C2TupleU832U16ZGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * 
	 */
	public short get_b() {
		short ret = Bindings.C2TupleU832U16ZGetB(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.C2TupleU832U16ZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public TwoTuple__u832u16Z clone() {
		long ret = Bindings.C2TupleU832U16ZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple__u832u16Z ret_hu_conv = new TwoTuple__u832u16Z(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C2Tuple__u832u16Z from the contained elements.
	 */
	public static TwoTuple__u832u16Z of(byte[] a, short b) {
		long ret = Bindings.C2TupleU832U16ZNew(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(a, 32)), b);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple__u832u16Z ret_hu_conv = new TwoTuple__u832u16Z(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
