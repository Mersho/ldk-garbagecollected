using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_SignedRawBolt11InvoiceBolt11ParseErrorZ : CommonBase {
	Result_SignedRawBolt11InvoiceBolt11ParseErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_SignedRawBolt11InvoiceBolt11ParseErrorZ() {
		if (ptr != 0) { Bindings.CResultSignedRawBolt11InvoiceBolt11ParseErrorZFree(ptr); }
	}

	internal static Result_SignedRawBolt11InvoiceBolt11ParseErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultSignedRawBolt11InvoiceBolt11ParseErrorZIsOk(ptr)) {
			return new Result_SignedRawBolt11InvoiceBolt11ParseErrorZ_OK(null, ptr);
		} else {
			return new Result_SignedRawBolt11InvoiceBolt11ParseErrorZ_Err(null, ptr);
		}
	}
	public class Result_SignedRawBolt11InvoiceBolt11ParseErrorZ_OK : Result_SignedRawBolt11InvoiceBolt11ParseErrorZ {
		public readonly SignedRawBolt11Invoice res;
		internal Result_SignedRawBolt11InvoiceBolt11ParseErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultSignedRawBolt11InvoiceBolt11ParseErrorZGetOk(ptr);
			org.ldk.structs.SignedRawBolt11Invoice res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.SignedRawBolt11Invoice(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_SignedRawBolt11InvoiceBolt11ParseErrorZ_Err : Result_SignedRawBolt11InvoiceBolt11ParseErrorZ {
		public readonly Bolt11ParseError err;
		internal Result_SignedRawBolt11InvoiceBolt11ParseErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultSignedRawBolt11InvoiceBolt11ParseErrorZGetErr(ptr);
			org.ldk.structs.Bolt11ParseError err_hu_conv = org.ldk.structs.Bolt11ParseError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_SignedRawBolt11InvoiceBolt11ParseErrorZ in the success state.
	 */
	public static Result_SignedRawBolt11InvoiceBolt11ParseErrorZ ok(org.ldk.structs.SignedRawBolt11Invoice o) {
		long ret = Bindings.CResultSignedRawBolt11InvoiceBolt11ParseErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SignedRawBolt11InvoiceBolt11ParseErrorZ ret_hu_conv = Result_SignedRawBolt11InvoiceBolt11ParseErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_SignedRawBolt11InvoiceBolt11ParseErrorZ in the error state.
	 */
	public static Result_SignedRawBolt11InvoiceBolt11ParseErrorZ err(org.ldk.structs.Bolt11ParseError e) {
		long ret = Bindings.CResultSignedRawBolt11InvoiceBolt11ParseErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SignedRawBolt11InvoiceBolt11ParseErrorZ ret_hu_conv = Result_SignedRawBolt11InvoiceBolt11ParseErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultSignedRawBolt11InvoiceBolt11ParseErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultSignedRawBolt11InvoiceBolt11ParseErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_SignedRawBolt11InvoiceBolt11ParseErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_SignedRawBolt11InvoiceBolt11ParseErrorZ clone() {
		long ret = Bindings.CResultSignedRawBolt11InvoiceBolt11ParseErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SignedRawBolt11InvoiceBolt11ParseErrorZ ret_hu_conv = Result_SignedRawBolt11InvoiceBolt11ParseErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
