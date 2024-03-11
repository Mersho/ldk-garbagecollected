using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_ErrorMessageDecodeErrorZ : CommonBase {
	Result_ErrorMessageDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_ErrorMessageDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultErrorMessageDecodeErrorZFree(ptr); }
	}

	internal static Result_ErrorMessageDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultErrorMessageDecodeErrorZIsOk(ptr)) {
			return new Result_ErrorMessageDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_ErrorMessageDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_ErrorMessageDecodeErrorZ_OK : Result_ErrorMessageDecodeErrorZ {
		public readonly ErrorMessage res;
		internal Result_ErrorMessageDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultErrorMessageDecodeErrorZGetOk(ptr);
			org.ldk.structs.ErrorMessage res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.ErrorMessage(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_ErrorMessageDecodeErrorZ_Err : Result_ErrorMessageDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_ErrorMessageDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultErrorMessageDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_ErrorMessageDecodeErrorZ in the success state.
	 */
	public static Result_ErrorMessageDecodeErrorZ ok(org.ldk.structs.ErrorMessage o) {
		long ret = Bindings.CResultErrorMessageDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ErrorMessageDecodeErrorZ ret_hu_conv = Result_ErrorMessageDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_ErrorMessageDecodeErrorZ in the error state.
	 */
	public static Result_ErrorMessageDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultErrorMessageDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ErrorMessageDecodeErrorZ ret_hu_conv = Result_ErrorMessageDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultErrorMessageDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultErrorMessageDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_ErrorMessageDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_ErrorMessageDecodeErrorZ clone() {
		long ret = Bindings.CResultErrorMessageDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ErrorMessageDecodeErrorZ ret_hu_conv = Result_ErrorMessageDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
