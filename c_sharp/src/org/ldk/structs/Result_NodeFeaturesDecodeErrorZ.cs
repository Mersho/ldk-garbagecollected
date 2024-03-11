using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_NodeFeaturesDecodeErrorZ : CommonBase {
	Result_NodeFeaturesDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_NodeFeaturesDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultNodeFeaturesDecodeErrorZFree(ptr); }
	}

	internal static Result_NodeFeaturesDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultNodeFeaturesDecodeErrorZIsOk(ptr)) {
			return new Result_NodeFeaturesDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_NodeFeaturesDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_NodeFeaturesDecodeErrorZ_OK : Result_NodeFeaturesDecodeErrorZ {
		public readonly NodeFeatures res;
		internal Result_NodeFeaturesDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultNodeFeaturesDecodeErrorZGetOk(ptr);
			org.ldk.structs.NodeFeatures res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.NodeFeatures(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_NodeFeaturesDecodeErrorZ_Err : Result_NodeFeaturesDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_NodeFeaturesDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultNodeFeaturesDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_NodeFeaturesDecodeErrorZ in the success state.
	 */
	public static Result_NodeFeaturesDecodeErrorZ ok(org.ldk.structs.NodeFeatures o) {
		long ret = Bindings.CResultNodeFeaturesDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NodeFeaturesDecodeErrorZ ret_hu_conv = Result_NodeFeaturesDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_NodeFeaturesDecodeErrorZ in the error state.
	 */
	public static Result_NodeFeaturesDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultNodeFeaturesDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NodeFeaturesDecodeErrorZ ret_hu_conv = Result_NodeFeaturesDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultNodeFeaturesDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultNodeFeaturesDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_NodeFeaturesDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_NodeFeaturesDecodeErrorZ clone() {
		long ret = Bindings.CResultNodeFeaturesDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NodeFeaturesDecodeErrorZ ret_hu_conv = Result_NodeFeaturesDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
