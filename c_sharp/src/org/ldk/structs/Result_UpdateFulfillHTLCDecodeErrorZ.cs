using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_UpdateFulfillHTLCDecodeErrorZ : CommonBase {
	Result_UpdateFulfillHTLCDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_UpdateFulfillHTLCDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultUpdateFulfillHTLCDecodeErrorZFree(ptr); }
	}

	internal static Result_UpdateFulfillHTLCDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultUpdateFulfillHTLCDecodeErrorZIsOk(ptr)) {
			return new Result_UpdateFulfillHTLCDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_UpdateFulfillHTLCDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_UpdateFulfillHTLCDecodeErrorZ_OK : Result_UpdateFulfillHTLCDecodeErrorZ {
		public readonly UpdateFulfillHTLC res;
		internal Result_UpdateFulfillHTLCDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultUpdateFulfillHTLCDecodeErrorZGetOk(ptr);
			org.ldk.structs.UpdateFulfillHTLC res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.UpdateFulfillHTLC(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_UpdateFulfillHTLCDecodeErrorZ_Err : Result_UpdateFulfillHTLCDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_UpdateFulfillHTLCDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultUpdateFulfillHTLCDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_UpdateFulfillHTLCDecodeErrorZ in the success state.
	 */
	public static Result_UpdateFulfillHTLCDecodeErrorZ ok(org.ldk.structs.UpdateFulfillHTLC o) {
		long ret = Bindings.CResultUpdateFulfillHTLCDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UpdateFulfillHTLCDecodeErrorZ ret_hu_conv = Result_UpdateFulfillHTLCDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_UpdateFulfillHTLCDecodeErrorZ in the error state.
	 */
	public static Result_UpdateFulfillHTLCDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultUpdateFulfillHTLCDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UpdateFulfillHTLCDecodeErrorZ ret_hu_conv = Result_UpdateFulfillHTLCDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultUpdateFulfillHTLCDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultUpdateFulfillHTLCDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_UpdateFulfillHTLCDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_UpdateFulfillHTLCDecodeErrorZ clone() {
		long ret = Bindings.CResultUpdateFulfillHTLCDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UpdateFulfillHTLCDecodeErrorZ ret_hu_conv = Result_UpdateFulfillHTLCDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
