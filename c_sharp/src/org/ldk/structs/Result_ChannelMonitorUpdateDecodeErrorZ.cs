using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_ChannelMonitorUpdateDecodeErrorZ : CommonBase {
	Result_ChannelMonitorUpdateDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_ChannelMonitorUpdateDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultChannelMonitorUpdateDecodeErrorZFree(ptr); }
	}

	internal static Result_ChannelMonitorUpdateDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultChannelMonitorUpdateDecodeErrorZIsOk(ptr)) {
			return new Result_ChannelMonitorUpdateDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_ChannelMonitorUpdateDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_ChannelMonitorUpdateDecodeErrorZ_OK : Result_ChannelMonitorUpdateDecodeErrorZ {
		public readonly ChannelMonitorUpdate res;
		internal Result_ChannelMonitorUpdateDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultChannelMonitorUpdateDecodeErrorZGetOk(ptr);
			org.ldk.structs.ChannelMonitorUpdate res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.ChannelMonitorUpdate(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_ChannelMonitorUpdateDecodeErrorZ_Err : Result_ChannelMonitorUpdateDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_ChannelMonitorUpdateDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultChannelMonitorUpdateDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_ChannelMonitorUpdateDecodeErrorZ in the success state.
	 */
	public static Result_ChannelMonitorUpdateDecodeErrorZ ok(org.ldk.structs.ChannelMonitorUpdate o) {
		long ret = Bindings.CResultChannelMonitorUpdateDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelMonitorUpdateDecodeErrorZ ret_hu_conv = Result_ChannelMonitorUpdateDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_ChannelMonitorUpdateDecodeErrorZ in the error state.
	 */
	public static Result_ChannelMonitorUpdateDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultChannelMonitorUpdateDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelMonitorUpdateDecodeErrorZ ret_hu_conv = Result_ChannelMonitorUpdateDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultChannelMonitorUpdateDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultChannelMonitorUpdateDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_ChannelMonitorUpdateDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_ChannelMonitorUpdateDecodeErrorZ clone() {
		long ret = Bindings.CResultChannelMonitorUpdateDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelMonitorUpdateDecodeErrorZ ret_hu_conv = Result_ChannelMonitorUpdateDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
