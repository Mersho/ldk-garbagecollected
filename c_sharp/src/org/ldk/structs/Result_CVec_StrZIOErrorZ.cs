using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_CVec_StrZIOErrorZ : CommonBase {
	Result_CVec_StrZIOErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_CVec_StrZIOErrorZ() {
		if (ptr != 0) { Bindings.CResultCVecStrZIOErrorZFree(ptr); }
	}

	internal static Result_CVec_StrZIOErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultCVecStrZIOErrorZIsOk(ptr)) {
			return new Result_CVec_StrZIOErrorZ_OK(null, ptr);
		} else {
			return new Result_CVec_StrZIOErrorZ_Err(null, ptr);
		}
	}
	public class Result_CVec_StrZIOErrorZ_OK : Result_CVec_StrZIOErrorZ {
		public readonly string[] res;
		internal Result_CVec_StrZIOErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultCVecStrZIOErrorZGetOk(ptr);
			int res_conv_8_len = InternalUtils.getArrayLength(res);
			string[] res_conv_8_arr = new string[res_conv_8_len];
			for (int i = 0; i < res_conv_8_len; i++) {
				long res_conv_8 = InternalUtils.getU32ArrayElem(res, i);
				string res_conv_8_conv = InternalUtils.decodeString(res_conv_8);
				res_conv_8_arr[i] = res_conv_8_conv;
			}
			Bindings.FreeBuffer(res);
			this.res = res_conv_8_arr;
		}
	}

	public class Result_CVec_StrZIOErrorZ_Err : Result_CVec_StrZIOErrorZ {
		public readonly IOError err;
		internal Result_CVec_StrZIOErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = Bindings.CResultCVecStrZIOErrorZGetErr(ptr);
		}
	}

	/**
	 * Creates a new CResult_CVec_StrZIOErrorZ in the success state.
	 */
	public static Result_CVec_StrZIOErrorZ ok(string[] o) {
		long ret = Bindings.CResultCVecStrZIOErrorZOk(InternalUtils.encodeUint64Array(InternalUtils.mapArray(o, o_conv_8 => InternalUtils.encodeString(o_conv_8))));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_StrZIOErrorZ ret_hu_conv = Result_CVec_StrZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_CVec_StrZIOErrorZ in the error state.
	 */
	public static Result_CVec_StrZIOErrorZ err(IOError e) {
		long ret = Bindings.CResultCVecStrZIOErrorZErr(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_StrZIOErrorZ ret_hu_conv = Result_CVec_StrZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultCVecStrZIOErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultCVecStrZIOErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_CVec_StrZIOErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_CVec_StrZIOErrorZ clone() {
		long ret = Bindings.CResultCVecStrZIOErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_StrZIOErrorZ ret_hu_conv = Result_CVec_StrZIOErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
