using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_SpliceLockedDecodeErrorZ : CommonBase {
	Result_SpliceLockedDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_SpliceLockedDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultSpliceLockedDecodeErrorZFree(ptr); }
	}

	internal static Result_SpliceLockedDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultSpliceLockedDecodeErrorZIsOk(ptr)) {
			return new Result_SpliceLockedDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_SpliceLockedDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_SpliceLockedDecodeErrorZ_OK : Result_SpliceLockedDecodeErrorZ {
		public readonly SpliceLocked res;
		internal Result_SpliceLockedDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultSpliceLockedDecodeErrorZGetOk(ptr);
			org.ldk.structs.SpliceLocked res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.SpliceLocked(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_SpliceLockedDecodeErrorZ_Err : Result_SpliceLockedDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_SpliceLockedDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultSpliceLockedDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_SpliceLockedDecodeErrorZ in the success state.
	 */
	public static Result_SpliceLockedDecodeErrorZ ok(org.ldk.structs.SpliceLocked o) {
		long ret = Bindings.CResultSpliceLockedDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SpliceLockedDecodeErrorZ ret_hu_conv = Result_SpliceLockedDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_SpliceLockedDecodeErrorZ in the error state.
	 */
	public static Result_SpliceLockedDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultSpliceLockedDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SpliceLockedDecodeErrorZ ret_hu_conv = Result_SpliceLockedDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultSpliceLockedDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultSpliceLockedDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_SpliceLockedDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_SpliceLockedDecodeErrorZ clone() {
		long ret = Bindings.CResultSpliceLockedDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SpliceLockedDecodeErrorZ ret_hu_conv = Result_SpliceLockedDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
