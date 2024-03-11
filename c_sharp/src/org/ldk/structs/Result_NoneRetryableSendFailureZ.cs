using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_NoneRetryableSendFailureZ : CommonBase {
	Result_NoneRetryableSendFailureZ(object _dummy, long ptr) : base(ptr) { }
	~Result_NoneRetryableSendFailureZ() {
		if (ptr != 0) { Bindings.CResultNoneRetryableSendFailureZFree(ptr); }
	}

	internal static Result_NoneRetryableSendFailureZ constr_from_ptr(long ptr) {
		if (Bindings.CResultNoneRetryableSendFailureZIsOk(ptr)) {
			return new Result_NoneRetryableSendFailureZ_OK(null, ptr);
		} else {
			return new Result_NoneRetryableSendFailureZ_Err(null, ptr);
		}
	}
	public class Result_NoneRetryableSendFailureZ_OK : Result_NoneRetryableSendFailureZ {
		internal Result_NoneRetryableSendFailureZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	public class Result_NoneRetryableSendFailureZ_Err : Result_NoneRetryableSendFailureZ {
		public readonly RetryableSendFailure err;
		internal Result_NoneRetryableSendFailureZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = Bindings.CResultNoneRetryableSendFailureZGetErr(ptr);
		}
	}

	/**
	 * Creates a new CResult_NoneRetryableSendFailureZ in the success state.
	 */
	public static Result_NoneRetryableSendFailureZ ok() {
		long ret = Bindings.CResultNoneRetryableSendFailureZOk();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneRetryableSendFailureZ ret_hu_conv = Result_NoneRetryableSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_NoneRetryableSendFailureZ in the error state.
	 */
	public static Result_NoneRetryableSendFailureZ err(RetryableSendFailure e) {
		long ret = Bindings.CResultNoneRetryableSendFailureZErr(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneRetryableSendFailureZ ret_hu_conv = Result_NoneRetryableSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultNoneRetryableSendFailureZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultNoneRetryableSendFailureZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_NoneRetryableSendFailureZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_NoneRetryableSendFailureZ clone() {
		long ret = Bindings.CResultNoneRetryableSendFailureZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneRetryableSendFailureZ ret_hu_conv = Result_NoneRetryableSendFailureZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
