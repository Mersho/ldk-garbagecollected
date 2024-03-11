using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ : CommonBase {
	internal ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ(object _dummy, long ptr) : base(ptr) { }
	~ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ() {
		if (ptr != 0) { Bindings.C3TupleThirtyTwoBytesRecipientOnionFieldsRouteParametersZFree(ptr); }
	}

	/**
	 * 
	 */
	public byte[] get_a() {
		long ret = Bindings.C3TupleThirtyTwoBytesRecipientOnionFieldsRouteParametersZGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * 
	 */
	public RecipientOnionFields get_b() {
		long ret = Bindings.C3TupleThirtyTwoBytesRecipientOnionFieldsRouteParametersZGetB(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RecipientOnionFields ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RecipientOnionFields(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public RouteParameters get_c() {
		long ret = Bindings.C3TupleThirtyTwoBytesRecipientOnionFieldsRouteParametersZGetC(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RouteParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RouteParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.C3TupleThirtyTwoBytesRecipientOnionFieldsRouteParametersZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ clone() {
		long ret = Bindings.C3TupleThirtyTwoBytesRecipientOnionFieldsRouteParametersZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ ret_hu_conv = new ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C3Tuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ from the contained elements.
	 */
	public static ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ of(byte[] a, org.ldk.structs.RecipientOnionFields b, org.ldk.structs.RouteParameters c) {
		long ret = Bindings.C3TupleThirtyTwoBytesRecipientOnionFieldsRouteParametersZNew(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(a, 32)), b == null ? 0 : b.ptr, c == null ? 0 : c.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		GC.KeepAlive(c);
		if (ret >= 0 && ret <= 4096) { return null; }
		ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ ret_hu_conv = new ThreeTuple_ThirtyTwoBytesRecipientOnionFieldsRouteParametersZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(b); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(c); };
		return ret_hu_conv;
	}

}
} } }
