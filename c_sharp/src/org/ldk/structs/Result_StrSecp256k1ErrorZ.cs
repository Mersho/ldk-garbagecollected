using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_StrSecp256k1ErrorZ : CommonBase {
	Result_StrSecp256k1ErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_StrSecp256k1ErrorZ() {
		if (ptr != 0) { Bindings.CResultStrSecp256k1ErrorZFree(ptr); }
	}

	internal static Result_StrSecp256k1ErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultStrSecp256k1ErrorZIsOk(ptr)) {
			return new Result_StrSecp256k1ErrorZ_OK(null, ptr);
		} else {
			return new Result_StrSecp256k1ErrorZ_Err(null, ptr);
		}
	}
	public class Result_StrSecp256k1ErrorZ_OK : Result_StrSecp256k1ErrorZ {
		public readonly string res;
		internal Result_StrSecp256k1ErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultStrSecp256k1ErrorZGetOk(ptr);
			string res_conv = InternalUtils.decodeString(res);
			this.res = res_conv;
		}
	}

	public class Result_StrSecp256k1ErrorZ_Err : Result_StrSecp256k1ErrorZ {
		public readonly Secp256k1Error err;
		internal Result_StrSecp256k1ErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			this.err = Bindings.CResultStrSecp256k1ErrorZGetErr(ptr);
		}
	}

	/**
	 * Creates a new CResult_StrSecp256k1ErrorZ in the success state.
	 */
	public static Result_StrSecp256k1ErrorZ ok(string o) {
		long ret = Bindings.CResultStrSecp256k1ErrorZOk(InternalUtils.encodeString(o));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_StrSecp256k1ErrorZ ret_hu_conv = Result_StrSecp256k1ErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_StrSecp256k1ErrorZ in the error state.
	 */
	public static Result_StrSecp256k1ErrorZ err(Secp256k1Error e) {
		long ret = Bindings.CResultStrSecp256k1ErrorZErr(e);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_StrSecp256k1ErrorZ ret_hu_conv = Result_StrSecp256k1ErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultStrSecp256k1ErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultStrSecp256k1ErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_StrSecp256k1ErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_StrSecp256k1ErrorZ clone() {
		long ret = Bindings.CResultStrSecp256k1ErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_StrSecp256k1ErrorZ ret_hu_conv = Result_StrSecp256k1ErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
