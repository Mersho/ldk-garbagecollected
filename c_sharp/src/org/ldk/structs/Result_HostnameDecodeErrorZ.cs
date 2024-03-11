using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_HostnameDecodeErrorZ : CommonBase {
	Result_HostnameDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_HostnameDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultHostnameDecodeErrorZFree(ptr); }
	}

	internal static Result_HostnameDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultHostnameDecodeErrorZIsOk(ptr)) {
			return new Result_HostnameDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_HostnameDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_HostnameDecodeErrorZ_OK : Result_HostnameDecodeErrorZ {
		public readonly Hostname res;
		internal Result_HostnameDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultHostnameDecodeErrorZGetOk(ptr);
			org.ldk.structs.Hostname res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.Hostname(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_HostnameDecodeErrorZ_Err : Result_HostnameDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_HostnameDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultHostnameDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_HostnameDecodeErrorZ in the success state.
	 */
	public static Result_HostnameDecodeErrorZ ok(org.ldk.structs.Hostname o) {
		long ret = Bindings.CResultHostnameDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HostnameDecodeErrorZ ret_hu_conv = Result_HostnameDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_HostnameDecodeErrorZ in the error state.
	 */
	public static Result_HostnameDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultHostnameDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HostnameDecodeErrorZ ret_hu_conv = Result_HostnameDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultHostnameDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultHostnameDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_HostnameDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_HostnameDecodeErrorZ clone() {
		long ret = Bindings.CResultHostnameDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HostnameDecodeErrorZ ret_hu_conv = Result_HostnameDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
