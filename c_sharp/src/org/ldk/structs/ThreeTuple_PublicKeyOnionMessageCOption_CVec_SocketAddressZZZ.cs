using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A Tuple
 */
public class ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ : CommonBase {
	internal ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ(object _dummy, long ptr) : base(ptr) { }
	~ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ() {
		if (ptr != 0) { Bindings.C3TuplePublicKeyOnionMessageCOptionCVecSocketAddressZZZFree(ptr); }
	}

	/**
	 * 
	 */
	public byte[] get_a() {
		long ret = Bindings.C3TuplePublicKeyOnionMessageCOptionCVecSocketAddressZZZGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * 
	 */
	public OnionMessage get_b() {
		long ret = Bindings.C3TuplePublicKeyOnionMessageCOptionCVecSocketAddressZZZGetB(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OnionMessage ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OnionMessage(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * 
	 */
	public Option_CVec_SocketAddressZZ get_c() {
		long ret = Bindings.C3TuplePublicKeyOnionMessageCOptionCVecSocketAddressZZZGetC(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_CVec_SocketAddressZZ ret_hu_conv = org.ldk.structs.Option_CVec_SocketAddressZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.C3TuplePublicKeyOnionMessageCOptionCVecSocketAddressZZZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new tuple which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ clone() {
		long ret = Bindings.C3TuplePublicKeyOnionMessageCOptionCVecSocketAddressZZZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ ret_hu_conv = new ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new C3Tuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ from the contained elements.
	 */
	public static ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ of(byte[] a, org.ldk.structs.OnionMessage b, org.ldk.structs.Option_CVec_SocketAddressZZ c) {
		long ret = Bindings.C3TuplePublicKeyOnionMessageCOptionCVecSocketAddressZZZNew(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(a, 33)), b == null ? 0 : b.ptr, c.ptr);
		GC.KeepAlive(a);
		GC.KeepAlive(b);
		GC.KeepAlive(c);
		if (ret >= 0 && ret <= 4096) { return null; }
		ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ ret_hu_conv = new ThreeTuple_PublicKeyOnionMessageCOption_CVec_SocketAddressZZZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(b); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(c); };
		return ret_hu_conv;
	}

}
} } }
