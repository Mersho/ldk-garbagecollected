using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_ChannelTransactionParametersDecodeErrorZ : CommonBase {
	Result_ChannelTransactionParametersDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_ChannelTransactionParametersDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultChannelTransactionParametersDecodeErrorZFree(ptr); }
	}

	internal static Result_ChannelTransactionParametersDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultChannelTransactionParametersDecodeErrorZIsOk(ptr)) {
			return new Result_ChannelTransactionParametersDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_ChannelTransactionParametersDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_ChannelTransactionParametersDecodeErrorZ_OK : Result_ChannelTransactionParametersDecodeErrorZ {
		public readonly ChannelTransactionParameters res;
		internal Result_ChannelTransactionParametersDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultChannelTransactionParametersDecodeErrorZGetOk(ptr);
			org.ldk.structs.ChannelTransactionParameters res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.ChannelTransactionParameters(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_ChannelTransactionParametersDecodeErrorZ_Err : Result_ChannelTransactionParametersDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_ChannelTransactionParametersDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultChannelTransactionParametersDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_ChannelTransactionParametersDecodeErrorZ in the success state.
	 */
	public static Result_ChannelTransactionParametersDecodeErrorZ ok(org.ldk.structs.ChannelTransactionParameters o) {
		long ret = Bindings.CResultChannelTransactionParametersDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelTransactionParametersDecodeErrorZ ret_hu_conv = Result_ChannelTransactionParametersDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_ChannelTransactionParametersDecodeErrorZ in the error state.
	 */
	public static Result_ChannelTransactionParametersDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultChannelTransactionParametersDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelTransactionParametersDecodeErrorZ ret_hu_conv = Result_ChannelTransactionParametersDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultChannelTransactionParametersDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultChannelTransactionParametersDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_ChannelTransactionParametersDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_ChannelTransactionParametersDecodeErrorZ clone() {
		long ret = Bindings.CResultChannelTransactionParametersDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelTransactionParametersDecodeErrorZ ret_hu_conv = Result_ChannelTransactionParametersDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
