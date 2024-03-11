using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_RecipientOnionFieldsDecodeErrorZ : CommonBase {
	Result_RecipientOnionFieldsDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_RecipientOnionFieldsDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultRecipientOnionFieldsDecodeErrorZFree(ptr); }
	}

	internal static Result_RecipientOnionFieldsDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultRecipientOnionFieldsDecodeErrorZIsOk(ptr)) {
			return new Result_RecipientOnionFieldsDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_RecipientOnionFieldsDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_RecipientOnionFieldsDecodeErrorZ_OK : Result_RecipientOnionFieldsDecodeErrorZ {
		public readonly RecipientOnionFields res;
		internal Result_RecipientOnionFieldsDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultRecipientOnionFieldsDecodeErrorZGetOk(ptr);
			org.ldk.structs.RecipientOnionFields res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.RecipientOnionFields(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_RecipientOnionFieldsDecodeErrorZ_Err : Result_RecipientOnionFieldsDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_RecipientOnionFieldsDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultRecipientOnionFieldsDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_RecipientOnionFieldsDecodeErrorZ in the success state.
	 */
	public static Result_RecipientOnionFieldsDecodeErrorZ ok(org.ldk.structs.RecipientOnionFields o) {
		long ret = Bindings.CResultRecipientOnionFieldsDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RecipientOnionFieldsDecodeErrorZ ret_hu_conv = Result_RecipientOnionFieldsDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_RecipientOnionFieldsDecodeErrorZ in the error state.
	 */
	public static Result_RecipientOnionFieldsDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultRecipientOnionFieldsDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RecipientOnionFieldsDecodeErrorZ ret_hu_conv = Result_RecipientOnionFieldsDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultRecipientOnionFieldsDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultRecipientOnionFieldsDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_RecipientOnionFieldsDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_RecipientOnionFieldsDecodeErrorZ clone() {
		long ret = Bindings.CResultRecipientOnionFieldsDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RecipientOnionFieldsDecodeErrorZ ret_hu_conv = Result_RecipientOnionFieldsDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
