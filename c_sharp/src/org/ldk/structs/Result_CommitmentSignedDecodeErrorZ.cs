using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_CommitmentSignedDecodeErrorZ : CommonBase {
	Result_CommitmentSignedDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_CommitmentSignedDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultCommitmentSignedDecodeErrorZFree(ptr); }
	}

	internal static Result_CommitmentSignedDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultCommitmentSignedDecodeErrorZIsOk(ptr)) {
			return new Result_CommitmentSignedDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_CommitmentSignedDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_CommitmentSignedDecodeErrorZ_OK : Result_CommitmentSignedDecodeErrorZ {
		public readonly CommitmentSigned res;
		internal Result_CommitmentSignedDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultCommitmentSignedDecodeErrorZGetOk(ptr);
			org.ldk.structs.CommitmentSigned res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.CommitmentSigned(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_CommitmentSignedDecodeErrorZ_Err : Result_CommitmentSignedDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_CommitmentSignedDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultCommitmentSignedDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_CommitmentSignedDecodeErrorZ in the success state.
	 */
	public static Result_CommitmentSignedDecodeErrorZ ok(org.ldk.structs.CommitmentSigned o) {
		long ret = Bindings.CResultCommitmentSignedDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CommitmentSignedDecodeErrorZ ret_hu_conv = Result_CommitmentSignedDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_CommitmentSignedDecodeErrorZ in the error state.
	 */
	public static Result_CommitmentSignedDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultCommitmentSignedDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CommitmentSignedDecodeErrorZ ret_hu_conv = Result_CommitmentSignedDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultCommitmentSignedDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultCommitmentSignedDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_CommitmentSignedDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_CommitmentSignedDecodeErrorZ clone() {
		long ret = Bindings.CResultCommitmentSignedDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CommitmentSignedDecodeErrorZ ret_hu_conv = Result_CommitmentSignedDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
