using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * The result of a [`UtxoLookup::get_utxo`] call. A call may resolve either synchronously,
 * returning the `Sync` variant, or asynchronously, returning an [`UtxoFuture`] in the `Async`
 * variant.
 */
public class UtxoResult : CommonBase {
	protected UtxoResult(object _dummy, long ptr) : base(ptr) { }
	~UtxoResult() {
		if (ptr != 0) { Bindings.UtxoResultFree(ptr); }
	}

	internal static UtxoResult constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKUtxoResultTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new UtxoResult_Sync(ptr);
			case 1: return new UtxoResult_Async(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A UtxoResult of type Sync */
	public class UtxoResult_Sync : UtxoResult {
		public Result_TxOutUtxoLookupErrorZ sync;
		internal UtxoResult_Sync(long ptr) : base(null, ptr) {
			long sync = Bindings.LDKUtxoResultSyncGetSync(ptr);
			Result_TxOutUtxoLookupErrorZ sync_hu_conv = Result_TxOutUtxoLookupErrorZ.constr_from_ptr(sync);
			this.sync = sync_hu_conv;
		}
	}
	/** A UtxoResult of type Async */
	public class UtxoResult_Async : UtxoResult {
		public UtxoFuture async;
		internal UtxoResult_Async(long ptr) : base(null, ptr) {
			long async = Bindings.LDKUtxoResultAsyncGetAsync(ptr);
			org.ldk.structs.UtxoFuture async_hu_conv = null; if (async < 0 || async > 4096) { async_hu_conv = new org.ldk.structs.UtxoFuture(null, async); }
			if (async_hu_conv != null) { async_hu_conv.ptrs_to.AddLast(this); };
			this.async = async_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = Bindings.UtxoResultClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the UtxoResult
	 */
	public UtxoResult clone() {
		long ret = Bindings.UtxoResultClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UtxoResult ret_hu_conv = org.ldk.structs.UtxoResult.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Sync-variant UtxoResult
	 */
	public static UtxoResult sync(org.ldk.structs.Result_TxOutUtxoLookupErrorZ a) {
		long ret = Bindings.UtxoResultSync(a != null ? a.ptr : 0);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UtxoResult ret_hu_conv = org.ldk.structs.UtxoResult.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Async-variant UtxoResult
	 */
	public static UtxoResult async(org.ldk.structs.UtxoFuture a) {
		long ret = Bindings.UtxoResultAsync(a == null ? 0 : a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UtxoResult ret_hu_conv = org.ldk.structs.UtxoResult.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(a); };
		return ret_hu_conv;
	}

}
} } }
