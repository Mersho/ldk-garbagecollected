using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_AcceptChannelV2DecodeErrorZ : CommonBase {
	Result_AcceptChannelV2DecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_AcceptChannelV2DecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultAcceptChannelV2DecodeErrorZFree(ptr); }
	}

	internal static Result_AcceptChannelV2DecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultAcceptChannelV2DecodeErrorZIsOk(ptr)) {
			return new Result_AcceptChannelV2DecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_AcceptChannelV2DecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_AcceptChannelV2DecodeErrorZ_OK : Result_AcceptChannelV2DecodeErrorZ {
		public readonly AcceptChannelV2 res;
		internal Result_AcceptChannelV2DecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultAcceptChannelV2DecodeErrorZGetOk(ptr);
			org.ldk.structs.AcceptChannelV2 res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.AcceptChannelV2(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_AcceptChannelV2DecodeErrorZ_Err : Result_AcceptChannelV2DecodeErrorZ {
		public readonly DecodeError err;
		internal Result_AcceptChannelV2DecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultAcceptChannelV2DecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_AcceptChannelV2DecodeErrorZ in the success state.
	 */
	public static Result_AcceptChannelV2DecodeErrorZ ok(org.ldk.structs.AcceptChannelV2 o) {
		long ret = Bindings.CResultAcceptChannelV2DecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AcceptChannelV2DecodeErrorZ ret_hu_conv = Result_AcceptChannelV2DecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_AcceptChannelV2DecodeErrorZ in the error state.
	 */
	public static Result_AcceptChannelV2DecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultAcceptChannelV2DecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AcceptChannelV2DecodeErrorZ ret_hu_conv = Result_AcceptChannelV2DecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultAcceptChannelV2DecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultAcceptChannelV2DecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_AcceptChannelV2DecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_AcceptChannelV2DecodeErrorZ clone() {
		long ret = Bindings.CResultAcceptChannelV2DecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_AcceptChannelV2DecodeErrorZ ret_hu_conv = Result_AcceptChannelV2DecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
