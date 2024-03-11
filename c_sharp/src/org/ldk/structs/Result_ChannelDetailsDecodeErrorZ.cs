using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_ChannelDetailsDecodeErrorZ : CommonBase {
	Result_ChannelDetailsDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_ChannelDetailsDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultChannelDetailsDecodeErrorZFree(ptr); }
	}

	internal static Result_ChannelDetailsDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultChannelDetailsDecodeErrorZIsOk(ptr)) {
			return new Result_ChannelDetailsDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_ChannelDetailsDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_ChannelDetailsDecodeErrorZ_OK : Result_ChannelDetailsDecodeErrorZ {
		public readonly ChannelDetails res;
		internal Result_ChannelDetailsDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultChannelDetailsDecodeErrorZGetOk(ptr);
			org.ldk.structs.ChannelDetails res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.ChannelDetails(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_ChannelDetailsDecodeErrorZ_Err : Result_ChannelDetailsDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_ChannelDetailsDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultChannelDetailsDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_ChannelDetailsDecodeErrorZ in the success state.
	 */
	public static Result_ChannelDetailsDecodeErrorZ ok(org.ldk.structs.ChannelDetails o) {
		long ret = Bindings.CResultChannelDetailsDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelDetailsDecodeErrorZ ret_hu_conv = Result_ChannelDetailsDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_ChannelDetailsDecodeErrorZ in the error state.
	 */
	public static Result_ChannelDetailsDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultChannelDetailsDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelDetailsDecodeErrorZ ret_hu_conv = Result_ChannelDetailsDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultChannelDetailsDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultChannelDetailsDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_ChannelDetailsDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_ChannelDetailsDecodeErrorZ clone() {
		long ret = Bindings.CResultChannelDetailsDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelDetailsDecodeErrorZ ret_hu_conv = Result_ChannelDetailsDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
