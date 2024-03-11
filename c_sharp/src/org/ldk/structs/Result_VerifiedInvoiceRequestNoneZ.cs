using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_VerifiedInvoiceRequestNoneZ : CommonBase {
	Result_VerifiedInvoiceRequestNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_VerifiedInvoiceRequestNoneZ() {
		if (ptr != 0) { Bindings.CResultVerifiedInvoiceRequestNoneZFree(ptr); }
	}

	internal static Result_VerifiedInvoiceRequestNoneZ constr_from_ptr(long ptr) {
		if (Bindings.CResultVerifiedInvoiceRequestNoneZIsOk(ptr)) {
			return new Result_VerifiedInvoiceRequestNoneZ_OK(null, ptr);
		} else {
			return new Result_VerifiedInvoiceRequestNoneZ_Err(null, ptr);
		}
	}
	public class Result_VerifiedInvoiceRequestNoneZ_OK : Result_VerifiedInvoiceRequestNoneZ {
		public readonly VerifiedInvoiceRequest res;
		internal Result_VerifiedInvoiceRequestNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultVerifiedInvoiceRequestNoneZGetOk(ptr);
			org.ldk.structs.VerifiedInvoiceRequest res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.VerifiedInvoiceRequest(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_VerifiedInvoiceRequestNoneZ_Err : Result_VerifiedInvoiceRequestNoneZ {
		internal Result_VerifiedInvoiceRequestNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_VerifiedInvoiceRequestNoneZ in the success state.
	 */
	public static Result_VerifiedInvoiceRequestNoneZ ok(org.ldk.structs.VerifiedInvoiceRequest o) {
		long ret = Bindings.CResultVerifiedInvoiceRequestNoneZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_VerifiedInvoiceRequestNoneZ ret_hu_conv = Result_VerifiedInvoiceRequestNoneZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_VerifiedInvoiceRequestNoneZ in the error state.
	 */
	public static Result_VerifiedInvoiceRequestNoneZ err() {
		long ret = Bindings.CResultVerifiedInvoiceRequestNoneZErr();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_VerifiedInvoiceRequestNoneZ ret_hu_conv = Result_VerifiedInvoiceRequestNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultVerifiedInvoiceRequestNoneZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultVerifiedInvoiceRequestNoneZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_VerifiedInvoiceRequestNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_VerifiedInvoiceRequestNoneZ clone() {
		long ret = Bindings.CResultVerifiedInvoiceRequestNoneZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_VerifiedInvoiceRequestNoneZ ret_hu_conv = Result_VerifiedInvoiceRequestNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
