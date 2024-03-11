using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_CVec_ECDSASignatureZNoneZ : CommonBase {
	Result_CVec_ECDSASignatureZNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_CVec_ECDSASignatureZNoneZ() {
		if (ptr != 0) { Bindings.CResultCVecECDSASignatureZNoneZFree(ptr); }
	}

	internal static Result_CVec_ECDSASignatureZNoneZ constr_from_ptr(long ptr) {
		if (Bindings.CResultCVecECDSASignatureZNoneZIsOk(ptr)) {
			return new Result_CVec_ECDSASignatureZNoneZ_OK(null, ptr);
		} else {
			return new Result_CVec_ECDSASignatureZNoneZ_Err(null, ptr);
		}
	}
	public class Result_CVec_ECDSASignatureZNoneZ_OK : Result_CVec_ECDSASignatureZNoneZ {
		public readonly byte[][] res;
		internal Result_CVec_ECDSASignatureZNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultCVecECDSASignatureZNoneZGetOk(ptr);
			int res_conv_8_len = InternalUtils.getArrayLength(res);
			byte[][] res_conv_8_arr = new byte[res_conv_8_len][];
			for (int i = 0; i < res_conv_8_len; i++) {
				long res_conv_8 = InternalUtils.getU64ArrayElem(res, i);
				byte[] res_conv_8_conv = InternalUtils.decodeUint8Array(res_conv_8);
				res_conv_8_arr[i] = res_conv_8_conv;
			}
			Bindings.FreeBuffer(res);
			this.res = res_conv_8_arr;
		}
	}

	public class Result_CVec_ECDSASignatureZNoneZ_Err : Result_CVec_ECDSASignatureZNoneZ {
		internal Result_CVec_ECDSASignatureZNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_CVec_ECDSASignatureZNoneZ in the success state.
	 */
	public static Result_CVec_ECDSASignatureZNoneZ ok(byte[][] o) {
		long ret = Bindings.CResultCVecECDSASignatureZNoneZOk(InternalUtils.encodeUint64Array(InternalUtils.mapArray(o, o_conv_8 => InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(o_conv_8, 64)))));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_ECDSASignatureZNoneZ ret_hu_conv = Result_CVec_ECDSASignatureZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_CVec_ECDSASignatureZNoneZ in the error state.
	 */
	public static Result_CVec_ECDSASignatureZNoneZ err() {
		long ret = Bindings.CResultCVecECDSASignatureZNoneZErr();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_ECDSASignatureZNoneZ ret_hu_conv = Result_CVec_ECDSASignatureZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultCVecECDSASignatureZNoneZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultCVecECDSASignatureZNoneZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_CVec_ECDSASignatureZNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_CVec_ECDSASignatureZNoneZ clone() {
		long ret = Bindings.CResultCVecECDSASignatureZNoneZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_ECDSASignatureZNoneZ ret_hu_conv = Result_CVec_ECDSASignatureZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
