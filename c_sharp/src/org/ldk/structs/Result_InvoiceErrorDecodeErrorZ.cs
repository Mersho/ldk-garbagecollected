using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_InvoiceErrorDecodeErrorZ : CommonBase {
	Result_InvoiceErrorDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_InvoiceErrorDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultInvoiceErrorDecodeErrorZFree(ptr); }
	}

	internal static Result_InvoiceErrorDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultInvoiceErrorDecodeErrorZIsOk(ptr)) {
			return new Result_InvoiceErrorDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_InvoiceErrorDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_InvoiceErrorDecodeErrorZ_OK : Result_InvoiceErrorDecodeErrorZ {
		public readonly InvoiceError res;
		internal Result_InvoiceErrorDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultInvoiceErrorDecodeErrorZGetOk(ptr);
			org.ldk.structs.InvoiceError res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.InvoiceError(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_InvoiceErrorDecodeErrorZ_Err : Result_InvoiceErrorDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_InvoiceErrorDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultInvoiceErrorDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_InvoiceErrorDecodeErrorZ in the success state.
	 */
	public static Result_InvoiceErrorDecodeErrorZ ok(org.ldk.structs.InvoiceError o) {
		long ret = Bindings.CResultInvoiceErrorDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InvoiceErrorDecodeErrorZ ret_hu_conv = Result_InvoiceErrorDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_InvoiceErrorDecodeErrorZ in the error state.
	 */
	public static Result_InvoiceErrorDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultInvoiceErrorDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InvoiceErrorDecodeErrorZ ret_hu_conv = Result_InvoiceErrorDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultInvoiceErrorDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultInvoiceErrorDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_InvoiceErrorDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_InvoiceErrorDecodeErrorZ clone() {
		long ret = Bindings.CResultInvoiceErrorDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InvoiceErrorDecodeErrorZ ret_hu_conv = Result_InvoiceErrorDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
