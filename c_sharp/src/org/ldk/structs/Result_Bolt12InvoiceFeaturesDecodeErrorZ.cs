using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_Bolt12InvoiceFeaturesDecodeErrorZ : CommonBase {
	Result_Bolt12InvoiceFeaturesDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_Bolt12InvoiceFeaturesDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultBolt12InvoiceFeaturesDecodeErrorZFree(ptr); }
	}

	internal static Result_Bolt12InvoiceFeaturesDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultBolt12InvoiceFeaturesDecodeErrorZIsOk(ptr)) {
			return new Result_Bolt12InvoiceFeaturesDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_Bolt12InvoiceFeaturesDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_Bolt12InvoiceFeaturesDecodeErrorZ_OK : Result_Bolt12InvoiceFeaturesDecodeErrorZ {
		public readonly Bolt12InvoiceFeatures res;
		internal Result_Bolt12InvoiceFeaturesDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultBolt12InvoiceFeaturesDecodeErrorZGetOk(ptr);
			org.ldk.structs.Bolt12InvoiceFeatures res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.Bolt12InvoiceFeatures(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_Bolt12InvoiceFeaturesDecodeErrorZ_Err : Result_Bolt12InvoiceFeaturesDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_Bolt12InvoiceFeaturesDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultBolt12InvoiceFeaturesDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_Bolt12InvoiceFeaturesDecodeErrorZ in the success state.
	 */
	public static Result_Bolt12InvoiceFeaturesDecodeErrorZ ok(org.ldk.structs.Bolt12InvoiceFeatures o) {
		long ret = Bindings.CResultBolt12InvoiceFeaturesDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_Bolt12InvoiceFeaturesDecodeErrorZ ret_hu_conv = Result_Bolt12InvoiceFeaturesDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_Bolt12InvoiceFeaturesDecodeErrorZ in the error state.
	 */
	public static Result_Bolt12InvoiceFeaturesDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultBolt12InvoiceFeaturesDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_Bolt12InvoiceFeaturesDecodeErrorZ ret_hu_conv = Result_Bolt12InvoiceFeaturesDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultBolt12InvoiceFeaturesDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultBolt12InvoiceFeaturesDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_Bolt12InvoiceFeaturesDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_Bolt12InvoiceFeaturesDecodeErrorZ clone() {
		long ret = Bindings.CResultBolt12InvoiceFeaturesDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_Bolt12InvoiceFeaturesDecodeErrorZ ret_hu_conv = Result_Bolt12InvoiceFeaturesDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
