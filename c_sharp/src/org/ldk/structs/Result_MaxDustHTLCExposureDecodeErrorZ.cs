using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_MaxDustHTLCExposureDecodeErrorZ : CommonBase {
	Result_MaxDustHTLCExposureDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_MaxDustHTLCExposureDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultMaxDustHTLCExposureDecodeErrorZFree(ptr); }
	}

	internal static Result_MaxDustHTLCExposureDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultMaxDustHTLCExposureDecodeErrorZIsOk(ptr)) {
			return new Result_MaxDustHTLCExposureDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_MaxDustHTLCExposureDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_MaxDustHTLCExposureDecodeErrorZ_OK : Result_MaxDustHTLCExposureDecodeErrorZ {
		public readonly MaxDustHTLCExposure res;
		internal Result_MaxDustHTLCExposureDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultMaxDustHTLCExposureDecodeErrorZGetOk(ptr);
			org.ldk.structs.MaxDustHTLCExposure res_hu_conv = org.ldk.structs.MaxDustHTLCExposure.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_MaxDustHTLCExposureDecodeErrorZ_Err : Result_MaxDustHTLCExposureDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_MaxDustHTLCExposureDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultMaxDustHTLCExposureDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_MaxDustHTLCExposureDecodeErrorZ in the success state.
	 */
	public static Result_MaxDustHTLCExposureDecodeErrorZ ok(org.ldk.structs.MaxDustHTLCExposure o) {
		long ret = Bindings.CResultMaxDustHTLCExposureDecodeErrorZOk(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MaxDustHTLCExposureDecodeErrorZ ret_hu_conv = Result_MaxDustHTLCExposureDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_MaxDustHTLCExposureDecodeErrorZ in the error state.
	 */
	public static Result_MaxDustHTLCExposureDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultMaxDustHTLCExposureDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MaxDustHTLCExposureDecodeErrorZ ret_hu_conv = Result_MaxDustHTLCExposureDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultMaxDustHTLCExposureDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultMaxDustHTLCExposureDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_MaxDustHTLCExposureDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_MaxDustHTLCExposureDecodeErrorZ clone() {
		long ret = Bindings.CResultMaxDustHTLCExposureDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MaxDustHTLCExposureDecodeErrorZ ret_hu_conv = Result_MaxDustHTLCExposureDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
