using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_DescriptionCreationErrorZ : CommonBase {
	Result_DescriptionCreationErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_DescriptionCreationErrorZ() {
		if (ptr != 0) { Bindings.CResultDescriptionCreationErrorZFree(ptr); }
	}

	internal static Result_DescriptionCreationErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultDescriptionCreationErrorZIsOk(ptr)) {
			return new Result_DescriptionCreationErrorZ_OK(null, ptr);
		} else {
			return new Result_DescriptionCreationErrorZ_Err(null, ptr);
		}
	}
	public class Result_DescriptionCreationErrorZ_OK : Result_DescriptionCreationErrorZ {
		public readonly Description res;
		internal Result_DescriptionCreationErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultDescriptionCreationErrorZGetOk(ptr);
			org.ldk.structs.Description res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.Description(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_DescriptionCreationErrorZ_Err : Result_DescriptionCreationErrorZ {
		public readonly CreationError err;
		internal Result_DescriptionCreationErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = Bindings.CResultDescriptionCreationErrorZGetErr(ptr);
		}
	}

	/**
	 * Creates a new CResult_DescriptionCreationErrorZ in the success state.
	 */
	public static Result_DescriptionCreationErrorZ ok(org.ldk.structs.Description o) {
		long ret = Bindings.CResultDescriptionCreationErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DescriptionCreationErrorZ ret_hu_conv = Result_DescriptionCreationErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_DescriptionCreationErrorZ in the error state.
	 */
	public static Result_DescriptionCreationErrorZ err(CreationError e) {
		long ret = Bindings.CResultDescriptionCreationErrorZErr(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DescriptionCreationErrorZ ret_hu_conv = Result_DescriptionCreationErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultDescriptionCreationErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultDescriptionCreationErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_DescriptionCreationErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_DescriptionCreationErrorZ clone() {
		long ret = Bindings.CResultDescriptionCreationErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DescriptionCreationErrorZ ret_hu_conv = Result_DescriptionCreationErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
