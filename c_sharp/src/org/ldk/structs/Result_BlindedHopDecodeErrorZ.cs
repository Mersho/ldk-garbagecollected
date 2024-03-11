using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_BlindedHopDecodeErrorZ : CommonBase {
	Result_BlindedHopDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_BlindedHopDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultBlindedHopDecodeErrorZFree(ptr); }
	}

	internal static Result_BlindedHopDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultBlindedHopDecodeErrorZIsOk(ptr)) {
			return new Result_BlindedHopDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_BlindedHopDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_BlindedHopDecodeErrorZ_OK : Result_BlindedHopDecodeErrorZ {
		public readonly BlindedHop res;
		internal Result_BlindedHopDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultBlindedHopDecodeErrorZGetOk(ptr);
			org.ldk.structs.BlindedHop res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.BlindedHop(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_BlindedHopDecodeErrorZ_Err : Result_BlindedHopDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_BlindedHopDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultBlindedHopDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_BlindedHopDecodeErrorZ in the success state.
	 */
	public static Result_BlindedHopDecodeErrorZ ok(org.ldk.structs.BlindedHop o) {
		long ret = Bindings.CResultBlindedHopDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedHopDecodeErrorZ ret_hu_conv = Result_BlindedHopDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_BlindedHopDecodeErrorZ in the error state.
	 */
	public static Result_BlindedHopDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultBlindedHopDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedHopDecodeErrorZ ret_hu_conv = Result_BlindedHopDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultBlindedHopDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultBlindedHopDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_BlindedHopDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_BlindedHopDecodeErrorZ clone() {
		long ret = Bindings.CResultBlindedHopDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedHopDecodeErrorZ ret_hu_conv = Result_BlindedHopDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
