using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_InitFeaturesDecodeErrorZ : CommonBase {
	Result_InitFeaturesDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_InitFeaturesDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultInitFeaturesDecodeErrorZFree(ptr); }
	}

	internal static Result_InitFeaturesDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultInitFeaturesDecodeErrorZIsOk(ptr)) {
			return new Result_InitFeaturesDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_InitFeaturesDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_InitFeaturesDecodeErrorZ_OK : Result_InitFeaturesDecodeErrorZ {
		public readonly InitFeatures res;
		internal Result_InitFeaturesDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultInitFeaturesDecodeErrorZGetOk(ptr);
			org.ldk.structs.InitFeatures res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.InitFeatures(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_InitFeaturesDecodeErrorZ_Err : Result_InitFeaturesDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_InitFeaturesDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultInitFeaturesDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_InitFeaturesDecodeErrorZ in the success state.
	 */
	public static Result_InitFeaturesDecodeErrorZ ok(org.ldk.structs.InitFeatures o) {
		long ret = Bindings.CResultInitFeaturesDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InitFeaturesDecodeErrorZ ret_hu_conv = Result_InitFeaturesDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_InitFeaturesDecodeErrorZ in the error state.
	 */
	public static Result_InitFeaturesDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultInitFeaturesDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InitFeaturesDecodeErrorZ ret_hu_conv = Result_InitFeaturesDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultInitFeaturesDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultInitFeaturesDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_InitFeaturesDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_InitFeaturesDecodeErrorZ clone() {
		long ret = Bindings.CResultInitFeaturesDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InitFeaturesDecodeErrorZ ret_hu_conv = Result_InitFeaturesDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
