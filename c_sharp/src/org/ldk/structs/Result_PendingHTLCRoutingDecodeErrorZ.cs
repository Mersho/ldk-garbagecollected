using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_PendingHTLCRoutingDecodeErrorZ : CommonBase {
	Result_PendingHTLCRoutingDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_PendingHTLCRoutingDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultPendingHTLCRoutingDecodeErrorZFree(ptr); }
	}

	internal static Result_PendingHTLCRoutingDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultPendingHTLCRoutingDecodeErrorZIsOk(ptr)) {
			return new Result_PendingHTLCRoutingDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_PendingHTLCRoutingDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_PendingHTLCRoutingDecodeErrorZ_OK : Result_PendingHTLCRoutingDecodeErrorZ {
		public readonly PendingHTLCRouting res;
		internal Result_PendingHTLCRoutingDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultPendingHTLCRoutingDecodeErrorZGetOk(ptr);
			org.ldk.structs.PendingHTLCRouting res_hu_conv = org.ldk.structs.PendingHTLCRouting.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_PendingHTLCRoutingDecodeErrorZ_Err : Result_PendingHTLCRoutingDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_PendingHTLCRoutingDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultPendingHTLCRoutingDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_PendingHTLCRoutingDecodeErrorZ in the success state.
	 */
	public static Result_PendingHTLCRoutingDecodeErrorZ ok(org.ldk.structs.PendingHTLCRouting o) {
		long ret = Bindings.CResultPendingHTLCRoutingDecodeErrorZOk(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PendingHTLCRoutingDecodeErrorZ ret_hu_conv = Result_PendingHTLCRoutingDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_PendingHTLCRoutingDecodeErrorZ in the error state.
	 */
	public static Result_PendingHTLCRoutingDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultPendingHTLCRoutingDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PendingHTLCRoutingDecodeErrorZ ret_hu_conv = Result_PendingHTLCRoutingDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultPendingHTLCRoutingDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultPendingHTLCRoutingDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_PendingHTLCRoutingDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_PendingHTLCRoutingDecodeErrorZ clone() {
		long ret = Bindings.CResultPendingHTLCRoutingDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PendingHTLCRoutingDecodeErrorZ ret_hu_conv = Result_PendingHTLCRoutingDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
