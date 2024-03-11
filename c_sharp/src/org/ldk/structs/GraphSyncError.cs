using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * All-encompassing standard error type that processing can return
 */
public class GraphSyncError : CommonBase {
	protected GraphSyncError(object _dummy, long ptr) : base(ptr) { }
	~GraphSyncError() {
		if (ptr != 0) { Bindings.GraphSyncErrorFree(ptr); }
	}

	internal static GraphSyncError constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKGraphSyncErrorTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new GraphSyncError_DecodeError(ptr);
			case 1: return new GraphSyncError_LightningError(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A GraphSyncError of type DecodeError */
	public class GraphSyncError_DecodeError : GraphSyncError {
		public DecodeError decode_error;
		internal GraphSyncError_DecodeError(long ptr) : base(null, ptr) {
			long decode_error = Bindings.LDKGraphSyncErrorDecodeErrorGetDecodeError(ptr);
			org.ldk.structs.DecodeError decode_error_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(decode_error);
			if (decode_error_hu_conv != null) { decode_error_hu_conv.ptrs_to.AddLast(this); };
			this.decode_error = decode_error_hu_conv;
		}
	}
	/** A GraphSyncError of type LightningError */
	public class GraphSyncError_LightningError : GraphSyncError {
		public LightningError lightning_error;
		internal GraphSyncError_LightningError(long ptr) : base(null, ptr) {
			long lightning_error = Bindings.LDKGraphSyncErrorLightningErrorGetLightningError(ptr);
			org.ldk.structs.LightningError lightning_error_hu_conv = null; if (lightning_error < 0 || lightning_error > 4096) { lightning_error_hu_conv = new org.ldk.structs.LightningError(null, lightning_error); }
			if (lightning_error_hu_conv != null) { lightning_error_hu_conv.ptrs_to.AddLast(this); };
			this.lightning_error = lightning_error_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = Bindings.GraphSyncErrorClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the GraphSyncError
	 */
	public GraphSyncError clone() {
		long ret = Bindings.GraphSyncErrorClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.GraphSyncError ret_hu_conv = org.ldk.structs.GraphSyncError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new DecodeError-variant GraphSyncError
	 */
	public static GraphSyncError decode_error(org.ldk.structs.DecodeError a) {
		long ret = Bindings.GraphSyncErrorDecodeError(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.GraphSyncError ret_hu_conv = org.ldk.structs.GraphSyncError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(a); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new LightningError-variant GraphSyncError
	 */
	public static GraphSyncError lightning_error(org.ldk.structs.LightningError a) {
		long ret = Bindings.GraphSyncErrorLightningError(a == null ? 0 : a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.GraphSyncError ret_hu_conv = org.ldk.structs.GraphSyncError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(a); };
		return ret_hu_conv;
	}

}
} } }
