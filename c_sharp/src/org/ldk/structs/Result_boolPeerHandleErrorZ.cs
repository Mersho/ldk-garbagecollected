using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_boolPeerHandleErrorZ : CommonBase {
	Result_boolPeerHandleErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_boolPeerHandleErrorZ() {
		if (ptr != 0) { Bindings.CResultBoolpeerhandleerrorzFree(ptr); }
	}

	internal static Result_boolPeerHandleErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultBoolpeerhandleerrorzIsOk(ptr)) {
			return new Result_boolPeerHandleErrorZ_OK(null, ptr);
		} else {
			return new Result_boolPeerHandleErrorZ_Err(null, ptr);
		}
	}
	public class Result_boolPeerHandleErrorZ_OK : Result_boolPeerHandleErrorZ {
		public readonly bool res;
		internal Result_boolPeerHandleErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			this.res = Bindings.CResultBoolpeerhandleerrorzGetOk(ptr);
		}
	}

	public class Result_boolPeerHandleErrorZ_Err : Result_boolPeerHandleErrorZ {
		public readonly PeerHandleError err;
		internal Result_boolPeerHandleErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultBoolpeerhandleerrorzGetErr(ptr);
			org.ldk.structs.PeerHandleError err_hu_conv = null; if (err < 0 || err > 4096) { err_hu_conv = new org.ldk.structs.PeerHandleError(null, err); }
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_boolPeerHandleErrorZ in the success state.
	 */
	public static Result_boolPeerHandleErrorZ ok(bool o) {
		long ret = Bindings.CResultBoolpeerhandleerrorzOk(o);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_boolPeerHandleErrorZ ret_hu_conv = Result_boolPeerHandleErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_boolPeerHandleErrorZ in the error state.
	 */
	public static Result_boolPeerHandleErrorZ err(org.ldk.structs.PeerHandleError e) {
		long ret = Bindings.CResultBoolpeerhandleerrorzErr(e == null ? 0 : e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_boolPeerHandleErrorZ ret_hu_conv = Result_boolPeerHandleErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultBoolpeerhandleerrorzIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultBoolpeerhandleerrorzClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_boolPeerHandleErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_boolPeerHandleErrorZ clone() {
		long ret = Bindings.CResultBoolpeerhandleerrorzClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_boolPeerHandleErrorZ ret_hu_conv = Result_boolPeerHandleErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
