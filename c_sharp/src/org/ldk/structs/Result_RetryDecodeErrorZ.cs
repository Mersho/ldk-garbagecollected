using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_RetryDecodeErrorZ : CommonBase {
	Result_RetryDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_RetryDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultRetryDecodeErrorZFree(ptr); }
	}

	internal static Result_RetryDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultRetryDecodeErrorZIsOk(ptr)) {
			return new Result_RetryDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_RetryDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_RetryDecodeErrorZ_OK : Result_RetryDecodeErrorZ {
		public readonly Retry res;
		internal Result_RetryDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultRetryDecodeErrorZGetOk(ptr);
			org.ldk.structs.Retry res_hu_conv = org.ldk.structs.Retry.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_RetryDecodeErrorZ_Err : Result_RetryDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_RetryDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultRetryDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_RetryDecodeErrorZ in the success state.
	 */
	public static Result_RetryDecodeErrorZ ok(org.ldk.structs.Retry o) {
		long ret = Bindings.CResultRetryDecodeErrorZOk(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RetryDecodeErrorZ ret_hu_conv = Result_RetryDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_RetryDecodeErrorZ in the error state.
	 */
	public static Result_RetryDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultRetryDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RetryDecodeErrorZ ret_hu_conv = Result_RetryDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultRetryDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultRetryDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_RetryDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_RetryDecodeErrorZ clone() {
		long ret = Bindings.CResultRetryDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RetryDecodeErrorZ ret_hu_conv = Result_RetryDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
