using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ : CommonBase {
	Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ() {
		if (ptr != 0) { Bindings.CResultC2TupleECDSASignatureCVecECDSASignatureZZNoneZFree(ptr); }
	}

	internal static Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ constr_from_ptr(long ptr) {
		if (Bindings.CResultC2TupleECDSASignatureCVecECDSASignatureZZNoneZIsOk(ptr)) {
			return new Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ_OK(null, ptr);
		} else {
			return new Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ_Err(null, ptr);
		}
	}
	public class Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ_OK : Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ {
		public readonly TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ res;
		internal Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultC2TupleECDSASignatureCVecECDSASignatureZZNoneZGetOk(ptr);
			TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ res_hu_conv = new TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ(null, res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ_Err : Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ {
		internal Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ in the success state.
	 */
	public static Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ ok(org.ldk.structs.TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ o) {
		long ret = Bindings.CResultC2TupleECDSASignatureCVecECDSASignatureZZNoneZOk(o != null ? o.ptr : 0);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ ret_hu_conv = Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ in the error state.
	 */
	public static Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ err() {
		long ret = Bindings.CResultC2TupleECDSASignatureCVecECDSASignatureZZNoneZErr();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ ret_hu_conv = Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultC2TupleECDSASignatureCVecECDSASignatureZZNoneZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultC2TupleECDSASignatureCVecECDSASignatureZZNoneZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ clone() {
		long ret = Bindings.CResultC2TupleECDSASignatureCVecECDSASignatureZZNoneZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ ret_hu_conv = Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
