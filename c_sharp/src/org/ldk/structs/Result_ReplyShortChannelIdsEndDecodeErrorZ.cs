using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_ReplyShortChannelIdsEndDecodeErrorZ : CommonBase {
	Result_ReplyShortChannelIdsEndDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_ReplyShortChannelIdsEndDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultReplyShortChannelIdsEndDecodeErrorZFree(ptr); }
	}

	internal static Result_ReplyShortChannelIdsEndDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultReplyShortChannelIdsEndDecodeErrorZIsOk(ptr)) {
			return new Result_ReplyShortChannelIdsEndDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_ReplyShortChannelIdsEndDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_ReplyShortChannelIdsEndDecodeErrorZ_OK : Result_ReplyShortChannelIdsEndDecodeErrorZ {
		public readonly ReplyShortChannelIdsEnd res;
		internal Result_ReplyShortChannelIdsEndDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultReplyShortChannelIdsEndDecodeErrorZGetOk(ptr);
			org.ldk.structs.ReplyShortChannelIdsEnd res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.ReplyShortChannelIdsEnd(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_ReplyShortChannelIdsEndDecodeErrorZ_Err : Result_ReplyShortChannelIdsEndDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_ReplyShortChannelIdsEndDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultReplyShortChannelIdsEndDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_ReplyShortChannelIdsEndDecodeErrorZ in the success state.
	 */
	public static Result_ReplyShortChannelIdsEndDecodeErrorZ ok(org.ldk.structs.ReplyShortChannelIdsEnd o) {
		long ret = Bindings.CResultReplyShortChannelIdsEndDecodeErrorZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ReplyShortChannelIdsEndDecodeErrorZ ret_hu_conv = Result_ReplyShortChannelIdsEndDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_ReplyShortChannelIdsEndDecodeErrorZ in the error state.
	 */
	public static Result_ReplyShortChannelIdsEndDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultReplyShortChannelIdsEndDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ReplyShortChannelIdsEndDecodeErrorZ ret_hu_conv = Result_ReplyShortChannelIdsEndDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultReplyShortChannelIdsEndDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultReplyShortChannelIdsEndDecodeErrorZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_ReplyShortChannelIdsEndDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_ReplyShortChannelIdsEndDecodeErrorZ clone() {
		long ret = Bindings.CResultReplyShortChannelIdsEndDecodeErrorZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ReplyShortChannelIdsEndDecodeErrorZ ret_hu_conv = Result_ReplyShortChannelIdsEndDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
