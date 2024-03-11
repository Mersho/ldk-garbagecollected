using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_TxSignaturesDecodeErrorZ : CommonBase {
	Result_TxSignaturesDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_TxSignaturesDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultTxSignaturesDecodeErrorZFree(ptr); }
	}

	internal static Result_TxSignaturesDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultTxSignaturesDecodeErrorZIsOk(ptr)) {
			return new Result_TxSignaturesDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_TxSignaturesDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_TxSignaturesDecodeErrorZ_OK : Result_TxSignaturesDecodeErrorZ {
		public readonly TxSignatures res;
		internal Result_TxSignaturesDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultTxSignaturesDecodeErrorZGetOk(ptr);
			org.ldk.structs.TxSignatures res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.TxSignatures(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_TxSignaturesDecodeErrorZ_Err : Result_TxSignaturesDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_TxSignaturesDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultTxSignaturesDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_TxSignaturesDecodeErrorZ in the success state.
	 */
	public static Result_TxSignaturesDecodeErrorZ ok(org.ldk.structs.TxSignatures o) {
		long ret = Bindings.CResultTxSignaturesDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxSignaturesDecodeErrorZ ret_hu_conv = Result_TxSignaturesDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_TxSignaturesDecodeErrorZ in the error state.
	 */
	public static Result_TxSignaturesDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultTxSignaturesDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxSignaturesDecodeErrorZ ret_hu_conv = Result_TxSignaturesDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultTxSignaturesDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultTxSignaturesDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_TxSignaturesDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_TxSignaturesDecodeErrorZ clone() {
		long ret = Bindings.CResultTxSignaturesDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxSignaturesDecodeErrorZ ret_hu_conv = Result_TxSignaturesDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
