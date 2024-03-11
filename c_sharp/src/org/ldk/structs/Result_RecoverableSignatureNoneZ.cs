using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_RecoverableSignatureNoneZ : CommonBase {
	Result_RecoverableSignatureNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_RecoverableSignatureNoneZ() {
		if (ptr != 0) { Bindings.CResultRecoverableSignatureNoneZFree(ptr); }
	}

	internal static Result_RecoverableSignatureNoneZ constr_from_ptr(long ptr) {
		if (Bindings.CResultRecoverableSignatureNoneZIsOk(ptr)) {
			return new Result_RecoverableSignatureNoneZ_OK(null, ptr);
		} else {
			return new Result_RecoverableSignatureNoneZ_Err(null, ptr);
		}
	}
	public class Result_RecoverableSignatureNoneZ_OK : Result_RecoverableSignatureNoneZ {
		public readonly byte[] res;
		internal Result_RecoverableSignatureNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultRecoverableSignatureNoneZGetOk(ptr);
			byte[] res_conv = InternalUtils.decodeUint8Array(res);
			this.res = res_conv;
		}
	}

	public class Result_RecoverableSignatureNoneZ_Err : Result_RecoverableSignatureNoneZ {
		internal Result_RecoverableSignatureNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_RecoverableSignatureNoneZ in the success state.
	 */
	public static Result_RecoverableSignatureNoneZ ok(byte[] o) {
		long ret = Bindings.CResultRecoverableSignatureNoneZOk(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(o, 68)));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RecoverableSignatureNoneZ ret_hu_conv = Result_RecoverableSignatureNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_RecoverableSignatureNoneZ in the error state.
	 */
	public static Result_RecoverableSignatureNoneZ err() {
		long ret = Bindings.CResultRecoverableSignatureNoneZErr();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RecoverableSignatureNoneZ ret_hu_conv = Result_RecoverableSignatureNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultRecoverableSignatureNoneZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultRecoverableSignatureNoneZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_RecoverableSignatureNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_RecoverableSignatureNoneZ clone() {
		long ret = Bindings.CResultRecoverableSignatureNoneZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RecoverableSignatureNoneZ ret_hu_conv = Result_RecoverableSignatureNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
