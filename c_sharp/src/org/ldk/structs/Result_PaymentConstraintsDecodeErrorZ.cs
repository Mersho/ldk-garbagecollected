using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_PaymentConstraintsDecodeErrorZ : CommonBase {
	Result_PaymentConstraintsDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_PaymentConstraintsDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultPaymentConstraintsDecodeErrorZFree(ptr); }
	}

	internal static Result_PaymentConstraintsDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultPaymentConstraintsDecodeErrorZIsOk(ptr)) {
			return new Result_PaymentConstraintsDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_PaymentConstraintsDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_PaymentConstraintsDecodeErrorZ_OK : Result_PaymentConstraintsDecodeErrorZ {
		public readonly PaymentConstraints res;
		internal Result_PaymentConstraintsDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultPaymentConstraintsDecodeErrorZGetOk(ptr);
			org.ldk.structs.PaymentConstraints res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.PaymentConstraints(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_PaymentConstraintsDecodeErrorZ_Err : Result_PaymentConstraintsDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_PaymentConstraintsDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultPaymentConstraintsDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_PaymentConstraintsDecodeErrorZ in the success state.
	 */
	public static Result_PaymentConstraintsDecodeErrorZ ok(org.ldk.structs.PaymentConstraints o) {
		long ret = Bindings.CResultPaymentConstraintsDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PaymentConstraintsDecodeErrorZ ret_hu_conv = Result_PaymentConstraintsDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_PaymentConstraintsDecodeErrorZ in the error state.
	 */
	public static Result_PaymentConstraintsDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultPaymentConstraintsDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PaymentConstraintsDecodeErrorZ ret_hu_conv = Result_PaymentConstraintsDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultPaymentConstraintsDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultPaymentConstraintsDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_PaymentConstraintsDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_PaymentConstraintsDecodeErrorZ clone() {
		long ret = Bindings.CResultPaymentConstraintsDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PaymentConstraintsDecodeErrorZ ret_hu_conv = Result_PaymentConstraintsDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
