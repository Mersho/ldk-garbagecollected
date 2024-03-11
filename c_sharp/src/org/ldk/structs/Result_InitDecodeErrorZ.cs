using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_InitDecodeErrorZ : CommonBase {
	Result_InitDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_InitDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultInitDecodeErrorZFree(ptr); }
	}

	internal static Result_InitDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultInitDecodeErrorZIsOk(ptr)) {
			return new Result_InitDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_InitDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_InitDecodeErrorZ_OK : Result_InitDecodeErrorZ {
		public readonly Init res;
		internal Result_InitDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultInitDecodeErrorZGetOk(ptr);
			org.ldk.structs.Init res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.Init(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_InitDecodeErrorZ_Err : Result_InitDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_InitDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultInitDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_InitDecodeErrorZ in the success state.
	 */
	public static Result_InitDecodeErrorZ ok(org.ldk.structs.Init o) {
		long ret = Bindings.CResultInitDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InitDecodeErrorZ ret_hu_conv = Result_InitDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_InitDecodeErrorZ in the error state.
	 */
	public static Result_InitDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultInitDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InitDecodeErrorZ ret_hu_conv = Result_InitDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultInitDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultInitDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_InitDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_InitDecodeErrorZ clone() {
		long ret = Bindings.CResultInitDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InitDecodeErrorZ ret_hu_conv = Result_InitDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
