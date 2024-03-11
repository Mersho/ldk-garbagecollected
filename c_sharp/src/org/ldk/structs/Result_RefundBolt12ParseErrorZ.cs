using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_RefundBolt12ParseErrorZ : CommonBase {
	Result_RefundBolt12ParseErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_RefundBolt12ParseErrorZ() {
		if (ptr != 0) { Bindings.CResultRefundBolt12ParseErrorZFree(ptr); }
	}

	internal static Result_RefundBolt12ParseErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultRefundBolt12ParseErrorZIsOk(ptr)) {
			return new Result_RefundBolt12ParseErrorZ_OK(null, ptr);
		} else {
			return new Result_RefundBolt12ParseErrorZ_Err(null, ptr);
		}
	}
	public class Result_RefundBolt12ParseErrorZ_OK : Result_RefundBolt12ParseErrorZ {
		public readonly Refund res;
		internal Result_RefundBolt12ParseErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultRefundBolt12ParseErrorZGetOk(ptr);
			org.ldk.structs.Refund res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.Refund(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_RefundBolt12ParseErrorZ_Err : Result_RefundBolt12ParseErrorZ {
		public readonly Bolt12ParseError err;
		internal Result_RefundBolt12ParseErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultRefundBolt12ParseErrorZGetErr(ptr);
			org.ldk.structs.Bolt12ParseError err_hu_conv = null; if (err < 0 || err > 4096) { err_hu_conv = new org.ldk.structs.Bolt12ParseError(null, err); }
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_RefundBolt12ParseErrorZ in the success state.
	 */
	public static Result_RefundBolt12ParseErrorZ ok(org.ldk.structs.Refund o) {
		long ret = Bindings.CResultRefundBolt12ParseErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RefundBolt12ParseErrorZ ret_hu_conv = Result_RefundBolt12ParseErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_RefundBolt12ParseErrorZ in the error state.
	 */
	public static Result_RefundBolt12ParseErrorZ err(org.ldk.structs.Bolt12ParseError e) {
		long ret = Bindings.CResultRefundBolt12ParseErrorZErr(e == null ? 0 : e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RefundBolt12ParseErrorZ ret_hu_conv = Result_RefundBolt12ParseErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultRefundBolt12ParseErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultRefundBolt12ParseErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_RefundBolt12ParseErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_RefundBolt12ParseErrorZ clone() {
		long ret = Bindings.CResultRefundBolt12ParseErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RefundBolt12ParseErrorZ ret_hu_conv = Result_RefundBolt12ParseErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
