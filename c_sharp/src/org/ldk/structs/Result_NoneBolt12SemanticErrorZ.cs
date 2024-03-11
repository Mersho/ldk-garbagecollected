using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_NoneBolt12SemanticErrorZ : CommonBase {
	Result_NoneBolt12SemanticErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_NoneBolt12SemanticErrorZ() {
		if (ptr != 0) { Bindings.CResultNoneBolt12SemanticErrorZFree(ptr); }
	}

	internal static Result_NoneBolt12SemanticErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultNoneBolt12SemanticErrorZIsOk(ptr)) {
			return new Result_NoneBolt12SemanticErrorZ_OK(null, ptr);
		} else {
			return new Result_NoneBolt12SemanticErrorZ_Err(null, ptr);
		}
	}
	public class Result_NoneBolt12SemanticErrorZ_OK : Result_NoneBolt12SemanticErrorZ {
		internal Result_NoneBolt12SemanticErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	public class Result_NoneBolt12SemanticErrorZ_Err : Result_NoneBolt12SemanticErrorZ {
		public readonly Bolt12SemanticError err;
		internal Result_NoneBolt12SemanticErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = Bindings.CResultNoneBolt12SemanticErrorZGetErr(ptr);
		}
	}

	/**
	 * Creates a new CResult_NoneBolt12SemanticErrorZ in the success state.
	 */
	public static Result_NoneBolt12SemanticErrorZ ok() {
		long ret = Bindings.CResultNoneBolt12SemanticErrorZOk();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12SemanticErrorZ ret_hu_conv = Result_NoneBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_NoneBolt12SemanticErrorZ in the error state.
	 */
	public static Result_NoneBolt12SemanticErrorZ err(Bolt12SemanticError e) {
		long ret = Bindings.CResultNoneBolt12SemanticErrorZErr(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12SemanticErrorZ ret_hu_conv = Result_NoneBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultNoneBolt12SemanticErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultNoneBolt12SemanticErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_NoneBolt12SemanticErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_NoneBolt12SemanticErrorZ clone() {
		long ret = Bindings.CResultNoneBolt12SemanticErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneBolt12SemanticErrorZ ret_hu_conv = Result_NoneBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
