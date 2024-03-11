using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_RevokeAndACKDecodeErrorZ : CommonBase {
	Result_RevokeAndACKDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_RevokeAndACKDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultRevokeAndACKDecodeErrorZFree(ptr); }
	}

	internal static Result_RevokeAndACKDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultRevokeAndACKDecodeErrorZIsOk(ptr)) {
			return new Result_RevokeAndACKDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_RevokeAndACKDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_RevokeAndACKDecodeErrorZ_OK : Result_RevokeAndACKDecodeErrorZ {
		public readonly RevokeAndACK res;
		internal Result_RevokeAndACKDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultRevokeAndACKDecodeErrorZGetOk(ptr);
			org.ldk.structs.RevokeAndACK res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.RevokeAndACK(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_RevokeAndACKDecodeErrorZ_Err : Result_RevokeAndACKDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_RevokeAndACKDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultRevokeAndACKDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_RevokeAndACKDecodeErrorZ in the success state.
	 */
	public static Result_RevokeAndACKDecodeErrorZ ok(org.ldk.structs.RevokeAndACK o) {
		long ret = Bindings.CResultRevokeAndACKDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RevokeAndACKDecodeErrorZ ret_hu_conv = Result_RevokeAndACKDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_RevokeAndACKDecodeErrorZ in the error state.
	 */
	public static Result_RevokeAndACKDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultRevokeAndACKDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RevokeAndACKDecodeErrorZ ret_hu_conv = Result_RevokeAndACKDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultRevokeAndACKDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultRevokeAndACKDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_RevokeAndACKDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_RevokeAndACKDecodeErrorZ clone() {
		long ret = Bindings.CResultRevokeAndACKDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RevokeAndACKDecodeErrorZ ret_hu_conv = Result_RevokeAndACKDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
