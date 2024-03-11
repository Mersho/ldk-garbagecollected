using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_TxAbortDecodeErrorZ : CommonBase {
	Result_TxAbortDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_TxAbortDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultTxAbortDecodeErrorZFree(ptr); }
	}

	internal static Result_TxAbortDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultTxAbortDecodeErrorZIsOk(ptr)) {
			return new Result_TxAbortDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_TxAbortDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_TxAbortDecodeErrorZ_OK : Result_TxAbortDecodeErrorZ {
		public readonly TxAbort res;
		internal Result_TxAbortDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultTxAbortDecodeErrorZGetOk(ptr);
			org.ldk.structs.TxAbort res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.TxAbort(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_TxAbortDecodeErrorZ_Err : Result_TxAbortDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_TxAbortDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultTxAbortDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_TxAbortDecodeErrorZ in the success state.
	 */
	public static Result_TxAbortDecodeErrorZ ok(org.ldk.structs.TxAbort o) {
		long ret = Bindings.CResultTxAbortDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxAbortDecodeErrorZ ret_hu_conv = Result_TxAbortDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_TxAbortDecodeErrorZ in the error state.
	 */
	public static Result_TxAbortDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultTxAbortDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxAbortDecodeErrorZ ret_hu_conv = Result_TxAbortDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultTxAbortDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultTxAbortDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_TxAbortDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_TxAbortDecodeErrorZ clone() {
		long ret = Bindings.CResultTxAbortDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxAbortDecodeErrorZ ret_hu_conv = Result_TxAbortDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
