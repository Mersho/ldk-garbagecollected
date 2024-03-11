using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_CounterpartyCommitmentSecretsDecodeErrorZ : CommonBase {
	Result_CounterpartyCommitmentSecretsDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_CounterpartyCommitmentSecretsDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultCounterpartyCommitmentSecretsDecodeErrorZFree(ptr); }
	}

	internal static Result_CounterpartyCommitmentSecretsDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultCounterpartyCommitmentSecretsDecodeErrorZIsOk(ptr)) {
			return new Result_CounterpartyCommitmentSecretsDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_CounterpartyCommitmentSecretsDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_CounterpartyCommitmentSecretsDecodeErrorZ_OK : Result_CounterpartyCommitmentSecretsDecodeErrorZ {
		public readonly CounterpartyCommitmentSecrets res;
		internal Result_CounterpartyCommitmentSecretsDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultCounterpartyCommitmentSecretsDecodeErrorZGetOk(ptr);
			org.ldk.structs.CounterpartyCommitmentSecrets res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.CounterpartyCommitmentSecrets(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_CounterpartyCommitmentSecretsDecodeErrorZ_Err : Result_CounterpartyCommitmentSecretsDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_CounterpartyCommitmentSecretsDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultCounterpartyCommitmentSecretsDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_CounterpartyCommitmentSecretsDecodeErrorZ in the success state.
	 */
	public static Result_CounterpartyCommitmentSecretsDecodeErrorZ ok(org.ldk.structs.CounterpartyCommitmentSecrets o) {
		long ret = Bindings.CResultCounterpartyCommitmentSecretsDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CounterpartyCommitmentSecretsDecodeErrorZ ret_hu_conv = Result_CounterpartyCommitmentSecretsDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_CounterpartyCommitmentSecretsDecodeErrorZ in the error state.
	 */
	public static Result_CounterpartyCommitmentSecretsDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultCounterpartyCommitmentSecretsDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CounterpartyCommitmentSecretsDecodeErrorZ ret_hu_conv = Result_CounterpartyCommitmentSecretsDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultCounterpartyCommitmentSecretsDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultCounterpartyCommitmentSecretsDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_CounterpartyCommitmentSecretsDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_CounterpartyCommitmentSecretsDecodeErrorZ clone() {
		long ret = Bindings.CResultCounterpartyCommitmentSecretsDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CounterpartyCommitmentSecretsDecodeErrorZ ret_hu_conv = Result_CounterpartyCommitmentSecretsDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
