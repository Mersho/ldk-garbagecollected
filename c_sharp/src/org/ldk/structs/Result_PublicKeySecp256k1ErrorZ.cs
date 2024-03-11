using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_PublicKeySecp256k1ErrorZ : CommonBase {
	Result_PublicKeySecp256k1ErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_PublicKeySecp256k1ErrorZ() {
		if (ptr != 0) { Bindings.CResultPublicKeySecp256k1ErrorZFree(ptr); }
	}

	internal static Result_PublicKeySecp256k1ErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultPublicKeySecp256k1ErrorZIsOk(ptr)) {
			return new Result_PublicKeySecp256k1ErrorZ_OK(null, ptr);
		} else {
			return new Result_PublicKeySecp256k1ErrorZ_Err(null, ptr);
		}
	}
	public class Result_PublicKeySecp256k1ErrorZ_OK : Result_PublicKeySecp256k1ErrorZ {
		public readonly byte[] res;
		internal Result_PublicKeySecp256k1ErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultPublicKeySecp256k1ErrorZGetOk(ptr);
			byte[] res_conv = InternalUtils.decodeUint8Array(res);
			this.res = res_conv;
		}
	}

	public class Result_PublicKeySecp256k1ErrorZ_Err : Result_PublicKeySecp256k1ErrorZ {
		public readonly Secp256k1Error err;
		internal Result_PublicKeySecp256k1ErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = Bindings.CResultPublicKeySecp256k1ErrorZGetErr(ptr);
		}
	}

	/**
	 * Creates a new CResult_PublicKeySecp256k1ErrorZ in the success state.
	 */
	public static Result_PublicKeySecp256k1ErrorZ ok(byte[] o) {
		long ret = Bindings.CResultPublicKeySecp256k1ErrorZOk(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(o, 33)));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PublicKeySecp256k1ErrorZ ret_hu_conv = Result_PublicKeySecp256k1ErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_PublicKeySecp256k1ErrorZ in the error state.
	 */
	public static Result_PublicKeySecp256k1ErrorZ err(Secp256k1Error e) {
		long ret = Bindings.CResultPublicKeySecp256k1ErrorZErr(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PublicKeySecp256k1ErrorZ ret_hu_conv = Result_PublicKeySecp256k1ErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultPublicKeySecp256k1ErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultPublicKeySecp256k1ErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_PublicKeySecp256k1ErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_PublicKeySecp256k1ErrorZ clone() {
		long ret = Bindings.CResultPublicKeySecp256k1ErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PublicKeySecp256k1ErrorZ ret_hu_conv = Result_PublicKeySecp256k1ErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
