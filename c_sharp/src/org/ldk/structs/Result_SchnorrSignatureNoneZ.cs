using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_SchnorrSignatureNoneZ : CommonBase {
	Result_SchnorrSignatureNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_SchnorrSignatureNoneZ() {
		if (ptr != 0) { Bindings.CResultSchnorrSignatureNoneZFree(ptr); }
	}

	internal static Result_SchnorrSignatureNoneZ constr_from_ptr(long ptr) {
		if (Bindings.CResultSchnorrSignatureNoneZIsOk(ptr)) {
			return new Result_SchnorrSignatureNoneZ_OK(null, ptr);
		} else {
			return new Result_SchnorrSignatureNoneZ_Err(null, ptr);
		}
	}
	public class Result_SchnorrSignatureNoneZ_OK : Result_SchnorrSignatureNoneZ {
		public readonly byte[] res;
		internal Result_SchnorrSignatureNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultSchnorrSignatureNoneZGetOk(ptr);
			byte[] res_conv = InternalUtils.decodeUint8Array(res);
			this.res = res_conv;
		}
	}

	public class Result_SchnorrSignatureNoneZ_Err : Result_SchnorrSignatureNoneZ {
		internal Result_SchnorrSignatureNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_SchnorrSignatureNoneZ in the success state.
	 */
	public static Result_SchnorrSignatureNoneZ ok(byte[] o) {
		long ret = Bindings.CResultSchnorrSignatureNoneZOk(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(o, 64)));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SchnorrSignatureNoneZ ret_hu_conv = Result_SchnorrSignatureNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_SchnorrSignatureNoneZ in the error state.
	 */
	public static Result_SchnorrSignatureNoneZ err() {
		long ret = Bindings.CResultSchnorrSignatureNoneZErr();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SchnorrSignatureNoneZ ret_hu_conv = Result_SchnorrSignatureNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultSchnorrSignatureNoneZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultSchnorrSignatureNoneZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_SchnorrSignatureNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_SchnorrSignatureNoneZ clone() {
		long ret = Bindings.CResultSchnorrSignatureNoneZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_SchnorrSignatureNoneZ ret_hu_conv = Result_SchnorrSignatureNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
