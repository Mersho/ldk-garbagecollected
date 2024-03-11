using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_Bolt11InvoiceSignOrCreationErrorZ : CommonBase {
	Result_Bolt11InvoiceSignOrCreationErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_Bolt11InvoiceSignOrCreationErrorZ() {
		if (ptr != 0) { Bindings.CResultBolt11InvoiceSignOrCreationErrorZFree(ptr); }
	}

	internal static Result_Bolt11InvoiceSignOrCreationErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultBolt11InvoiceSignOrCreationErrorZIsOk(ptr)) {
			return new Result_Bolt11InvoiceSignOrCreationErrorZ_OK(null, ptr);
		} else {
			return new Result_Bolt11InvoiceSignOrCreationErrorZ_Err(null, ptr);
		}
	}
	public class Result_Bolt11InvoiceSignOrCreationErrorZ_OK : Result_Bolt11InvoiceSignOrCreationErrorZ {
		public readonly Bolt11Invoice res;
		internal Result_Bolt11InvoiceSignOrCreationErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultBolt11InvoiceSignOrCreationErrorZGetOk(ptr);
			org.ldk.structs.Bolt11Invoice res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.Bolt11Invoice(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_Bolt11InvoiceSignOrCreationErrorZ_Err : Result_Bolt11InvoiceSignOrCreationErrorZ {
		public readonly SignOrCreationError err;
		internal Result_Bolt11InvoiceSignOrCreationErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultBolt11InvoiceSignOrCreationErrorZGetErr(ptr);
			org.ldk.structs.SignOrCreationError err_hu_conv = org.ldk.structs.SignOrCreationError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_Bolt11InvoiceSignOrCreationErrorZ in the success state.
	 */
	public static Result_Bolt11InvoiceSignOrCreationErrorZ ok(org.ldk.structs.Bolt11Invoice o) {
		long ret = Bindings.CResultBolt11InvoiceSignOrCreationErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_Bolt11InvoiceSignOrCreationErrorZ ret_hu_conv = Result_Bolt11InvoiceSignOrCreationErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_Bolt11InvoiceSignOrCreationErrorZ in the error state.
	 */
	public static Result_Bolt11InvoiceSignOrCreationErrorZ err(org.ldk.structs.SignOrCreationError e) {
		long ret = Bindings.CResultBolt11InvoiceSignOrCreationErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_Bolt11InvoiceSignOrCreationErrorZ ret_hu_conv = Result_Bolt11InvoiceSignOrCreationErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultBolt11InvoiceSignOrCreationErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultBolt11InvoiceSignOrCreationErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_Bolt11InvoiceSignOrCreationErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_Bolt11InvoiceSignOrCreationErrorZ clone() {
		long ret = Bindings.CResultBolt11InvoiceSignOrCreationErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_Bolt11InvoiceSignOrCreationErrorZ ret_hu_conv = Result_Bolt11InvoiceSignOrCreationErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
