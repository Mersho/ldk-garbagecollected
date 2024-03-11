using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_HtlcKeyDecodeErrorZ : CommonBase {
	Result_HtlcKeyDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_HtlcKeyDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultHtlcKeyDecodeErrorZFree(ptr); }
	}

	internal static Result_HtlcKeyDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultHtlcKeyDecodeErrorZIsOk(ptr)) {
			return new Result_HtlcKeyDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_HtlcKeyDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_HtlcKeyDecodeErrorZ_OK : Result_HtlcKeyDecodeErrorZ {
		public readonly HtlcKey res;
		internal Result_HtlcKeyDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultHtlcKeyDecodeErrorZGetOk(ptr);
			org.ldk.structs.HtlcKey res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.HtlcKey(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_HtlcKeyDecodeErrorZ_Err : Result_HtlcKeyDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_HtlcKeyDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultHtlcKeyDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_HtlcKeyDecodeErrorZ in the success state.
	 */
	public static Result_HtlcKeyDecodeErrorZ ok(org.ldk.structs.HtlcKey o) {
		long ret = Bindings.CResultHtlcKeyDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HtlcKeyDecodeErrorZ ret_hu_conv = Result_HtlcKeyDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_HtlcKeyDecodeErrorZ in the error state.
	 */
	public static Result_HtlcKeyDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultHtlcKeyDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HtlcKeyDecodeErrorZ ret_hu_conv = Result_HtlcKeyDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultHtlcKeyDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultHtlcKeyDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_HtlcKeyDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_HtlcKeyDecodeErrorZ clone() {
		long ret = Bindings.CResultHtlcKeyDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HtlcKeyDecodeErrorZ ret_hu_conv = Result_HtlcKeyDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
