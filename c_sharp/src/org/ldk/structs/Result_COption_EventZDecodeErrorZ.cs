using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_COption_EventZDecodeErrorZ : CommonBase {
	Result_COption_EventZDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_COption_EventZDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultCOptionEventZDecodeErrorZFree(ptr); }
	}

	internal static Result_COption_EventZDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultCOptionEventZDecodeErrorZIsOk(ptr)) {
			return new Result_COption_EventZDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_COption_EventZDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_COption_EventZDecodeErrorZ_OK : Result_COption_EventZDecodeErrorZ {
		public readonly Option_EventZ res;
		internal Result_COption_EventZDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultCOptionEventZDecodeErrorZGetOk(ptr);
			org.ldk.structs.Option_EventZ res_hu_conv = org.ldk.structs.Option_EventZ.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_COption_EventZDecodeErrorZ_Err : Result_COption_EventZDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_COption_EventZDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultCOptionEventZDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_COption_EventZDecodeErrorZ in the success state.
	 */
	public static Result_COption_EventZDecodeErrorZ ok(org.ldk.structs.Option_EventZ o) {
		long ret = Bindings.CResultCOptionEventZDecodeErrorZOk(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_COption_EventZDecodeErrorZ ret_hu_conv = Result_COption_EventZDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_COption_EventZDecodeErrorZ in the error state.
	 */
	public static Result_COption_EventZDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultCOptionEventZDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_COption_EventZDecodeErrorZ ret_hu_conv = Result_COption_EventZDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultCOptionEventZDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultCOptionEventZDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_COption_EventZDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_COption_EventZDecodeErrorZ clone() {
		long ret = Bindings.CResultCOptionEventZDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_COption_EventZDecodeErrorZ ret_hu_conv = Result_COption_EventZDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
