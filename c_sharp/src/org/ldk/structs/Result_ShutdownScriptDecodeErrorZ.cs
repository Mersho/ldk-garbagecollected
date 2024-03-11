using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_ShutdownScriptDecodeErrorZ : CommonBase {
	Result_ShutdownScriptDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_ShutdownScriptDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultShutdownScriptDecodeErrorZFree(ptr); }
	}

	internal static Result_ShutdownScriptDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultShutdownScriptDecodeErrorZIsOk(ptr)) {
			return new Result_ShutdownScriptDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_ShutdownScriptDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_ShutdownScriptDecodeErrorZ_OK : Result_ShutdownScriptDecodeErrorZ {
		public readonly ShutdownScript res;
		internal Result_ShutdownScriptDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultShutdownScriptDecodeErrorZGetOk(ptr);
			org.ldk.structs.ShutdownScript res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.ShutdownScript(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_ShutdownScriptDecodeErrorZ_Err : Result_ShutdownScriptDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_ShutdownScriptDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultShutdownScriptDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_ShutdownScriptDecodeErrorZ in the success state.
	 */
	public static Result_ShutdownScriptDecodeErrorZ ok(org.ldk.structs.ShutdownScript o) {
		long ret = Bindings.CResultShutdownScriptDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ShutdownScriptDecodeErrorZ ret_hu_conv = Result_ShutdownScriptDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_ShutdownScriptDecodeErrorZ in the error state.
	 */
	public static Result_ShutdownScriptDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultShutdownScriptDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ShutdownScriptDecodeErrorZ ret_hu_conv = Result_ShutdownScriptDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultShutdownScriptDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultShutdownScriptDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_ShutdownScriptDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_ShutdownScriptDecodeErrorZ clone() {
		long ret = Bindings.CResultShutdownScriptDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ShutdownScriptDecodeErrorZ ret_hu_conv = Result_ShutdownScriptDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
