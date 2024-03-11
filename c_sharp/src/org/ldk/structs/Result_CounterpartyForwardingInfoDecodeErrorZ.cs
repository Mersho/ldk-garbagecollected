using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_CounterpartyForwardingInfoDecodeErrorZ : CommonBase {
	Result_CounterpartyForwardingInfoDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_CounterpartyForwardingInfoDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultCounterpartyForwardingInfoDecodeErrorZFree(ptr); }
	}

	internal static Result_CounterpartyForwardingInfoDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultCounterpartyForwardingInfoDecodeErrorZIsOk(ptr)) {
			return new Result_CounterpartyForwardingInfoDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_CounterpartyForwardingInfoDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_CounterpartyForwardingInfoDecodeErrorZ_OK : Result_CounterpartyForwardingInfoDecodeErrorZ {
		public readonly CounterpartyForwardingInfo res;
		internal Result_CounterpartyForwardingInfoDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultCounterpartyForwardingInfoDecodeErrorZGetOk(ptr);
			org.ldk.structs.CounterpartyForwardingInfo res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.CounterpartyForwardingInfo(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_CounterpartyForwardingInfoDecodeErrorZ_Err : Result_CounterpartyForwardingInfoDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_CounterpartyForwardingInfoDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultCounterpartyForwardingInfoDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_CounterpartyForwardingInfoDecodeErrorZ in the success state.
	 */
	public static Result_CounterpartyForwardingInfoDecodeErrorZ ok(org.ldk.structs.CounterpartyForwardingInfo o) {
		long ret = Bindings.CResultCounterpartyForwardingInfoDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CounterpartyForwardingInfoDecodeErrorZ ret_hu_conv = Result_CounterpartyForwardingInfoDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_CounterpartyForwardingInfoDecodeErrorZ in the error state.
	 */
	public static Result_CounterpartyForwardingInfoDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultCounterpartyForwardingInfoDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CounterpartyForwardingInfoDecodeErrorZ ret_hu_conv = Result_CounterpartyForwardingInfoDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultCounterpartyForwardingInfoDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultCounterpartyForwardingInfoDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_CounterpartyForwardingInfoDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_CounterpartyForwardingInfoDecodeErrorZ clone() {
		long ret = Bindings.CResultCounterpartyForwardingInfoDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CounterpartyForwardingInfoDecodeErrorZ ret_hu_conv = Result_CounterpartyForwardingInfoDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
