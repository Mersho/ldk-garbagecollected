using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_BlindedFailureDecodeErrorZ : CommonBase {
	Result_BlindedFailureDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_BlindedFailureDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultBlindedFailureDecodeErrorZFree(ptr); }
	}

	internal static Result_BlindedFailureDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultBlindedFailureDecodeErrorZIsOk(ptr)) {
			return new Result_BlindedFailureDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_BlindedFailureDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_BlindedFailureDecodeErrorZ_OK : Result_BlindedFailureDecodeErrorZ {
		public readonly BlindedFailure res;
		internal Result_BlindedFailureDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			this.res = Bindings.CResultBlindedFailureDecodeErrorZGetOk(ptr);
		}
	}

	public class Result_BlindedFailureDecodeErrorZ_Err : Result_BlindedFailureDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_BlindedFailureDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultBlindedFailureDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_BlindedFailureDecodeErrorZ in the success state.
	 */
	public static Result_BlindedFailureDecodeErrorZ ok(BlindedFailure o) {
		long ret = Bindings.CResultBlindedFailureDecodeErrorZOk(o);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedFailureDecodeErrorZ ret_hu_conv = Result_BlindedFailureDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_BlindedFailureDecodeErrorZ in the error state.
	 */
	public static Result_BlindedFailureDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultBlindedFailureDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedFailureDecodeErrorZ ret_hu_conv = Result_BlindedFailureDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultBlindedFailureDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultBlindedFailureDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_BlindedFailureDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_BlindedFailureDecodeErrorZ clone() {
		long ret = Bindings.CResultBlindedFailureDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedFailureDecodeErrorZ ret_hu_conv = Result_BlindedFailureDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
