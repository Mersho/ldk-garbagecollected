using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_SpliceAckDecodeErrorZ : CommonBase {
	Result_SpliceAckDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_SpliceAckDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultSpliceAckDecodeErrorZFree(ptr); }
	}

	internal static Result_SpliceAckDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultSpliceAckDecodeErrorZIsOk(ptr)) {
			return new Result_SpliceAckDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_SpliceAckDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_SpliceAckDecodeErrorZ_OK : Result_SpliceAckDecodeErrorZ {
		public readonly SpliceAck res;
		internal Result_SpliceAckDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultSpliceAckDecodeErrorZGetOk(ptr);
			org.ldk.structs.SpliceAck res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.SpliceAck(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_SpliceAckDecodeErrorZ_Err : Result_SpliceAckDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_SpliceAckDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultSpliceAckDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_SpliceAckDecodeErrorZ in the success state.
	 */
	public static Result_SpliceAckDecodeErrorZ ok(org.ldk.structs.SpliceAck o) {
		long ret = Bindings.CResultSpliceAckDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SpliceAckDecodeErrorZ ret_hu_conv = Result_SpliceAckDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_SpliceAckDecodeErrorZ in the error state.
	 */
	public static Result_SpliceAckDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultSpliceAckDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SpliceAckDecodeErrorZ ret_hu_conv = Result_SpliceAckDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultSpliceAckDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultSpliceAckDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_SpliceAckDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_SpliceAckDecodeErrorZ clone() {
		long ret = Bindings.CResultSpliceAckDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SpliceAckDecodeErrorZ ret_hu_conv = Result_SpliceAckDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
