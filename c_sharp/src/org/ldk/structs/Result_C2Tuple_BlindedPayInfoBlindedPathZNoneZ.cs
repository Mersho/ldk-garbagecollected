using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ : CommonBase {
	Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ() {
		if (ptr != 0) { Bindings.CResultC2TupleBlindedPayInfoBlindedPathZNoneZFree(ptr); }
	}

	internal static Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ constr_from_ptr(long ptr) {
		if (Bindings.CResultC2TupleBlindedPayInfoBlindedPathZNoneZIsOk(ptr)) {
			return new Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ_OK(null, ptr);
		} else {
			return new Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ_Err(null, ptr);
		}
	}
	public class Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ_OK : Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ {
		public readonly TwoTuple_BlindedPayInfoBlindedPathZ res;
		internal Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultC2TupleBlindedPayInfoBlindedPathZNoneZGetOk(ptr);
			TwoTuple_BlindedPayInfoBlindedPathZ res_hu_conv = new TwoTuple_BlindedPayInfoBlindedPathZ(null, res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ_Err : Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ {
		internal Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_C2Tuple_BlindedPayInfoBlindedPathZNoneZ in the success state.
	 */
	public static Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ ok(org.ldk.structs.TwoTuple_BlindedPayInfoBlindedPathZ o) {
		long ret = Bindings.CResultC2TupleBlindedPayInfoBlindedPathZNoneZOk(o != null ? o.ptr : 0);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ ret_hu_conv = Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_C2Tuple_BlindedPayInfoBlindedPathZNoneZ in the error state.
	 */
	public static Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ err() {
		long ret = Bindings.CResultC2TupleBlindedPayInfoBlindedPathZNoneZErr();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ ret_hu_conv = Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultC2TupleBlindedPayInfoBlindedPathZNoneZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultC2TupleBlindedPayInfoBlindedPathZNoneZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_C2Tuple_BlindedPayInfoBlindedPathZNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ clone() {
		long ret = Bindings.CResultC2TupleBlindedPayInfoBlindedPathZNoneZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ ret_hu_conv = Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
