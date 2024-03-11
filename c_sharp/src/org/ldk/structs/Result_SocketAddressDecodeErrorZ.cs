using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_SocketAddressDecodeErrorZ : CommonBase {
	Result_SocketAddressDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_SocketAddressDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultSocketAddressDecodeErrorZFree(ptr); }
	}

	internal static Result_SocketAddressDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultSocketAddressDecodeErrorZIsOk(ptr)) {
			return new Result_SocketAddressDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_SocketAddressDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_SocketAddressDecodeErrorZ_OK : Result_SocketAddressDecodeErrorZ {
		public readonly SocketAddress res;
		internal Result_SocketAddressDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultSocketAddressDecodeErrorZGetOk(ptr);
			org.ldk.structs.SocketAddress res_hu_conv = org.ldk.structs.SocketAddress.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_SocketAddressDecodeErrorZ_Err : Result_SocketAddressDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_SocketAddressDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultSocketAddressDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_SocketAddressDecodeErrorZ in the success state.
	 */
	public static Result_SocketAddressDecodeErrorZ ok(org.ldk.structs.SocketAddress o) {
		long ret = Bindings.CResultSocketAddressDecodeErrorZOk(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SocketAddressDecodeErrorZ ret_hu_conv = Result_SocketAddressDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_SocketAddressDecodeErrorZ in the error state.
	 */
	public static Result_SocketAddressDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultSocketAddressDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SocketAddressDecodeErrorZ ret_hu_conv = Result_SocketAddressDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultSocketAddressDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultSocketAddressDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_SocketAddressDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_SocketAddressDecodeErrorZ clone() {
		long ret = Bindings.CResultSocketAddressDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SocketAddressDecodeErrorZ ret_hu_conv = Result_SocketAddressDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
