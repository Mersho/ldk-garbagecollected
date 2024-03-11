using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_CoinSelectionNoneZ : CommonBase {
	Result_CoinSelectionNoneZ(object _dummy, long ptr) : base(ptr) { }
	~Result_CoinSelectionNoneZ() {
		if (ptr != 0) { Bindings.CResultCoinSelectionNoneZFree(ptr); }
	}

	internal static Result_CoinSelectionNoneZ constr_from_ptr(long ptr) {
		if (Bindings.CResultCoinSelectionNoneZIsOk(ptr)) {
			return new Result_CoinSelectionNoneZ_OK(null, ptr);
		} else {
			return new Result_CoinSelectionNoneZ_Err(null, ptr);
		}
	}
	public class Result_CoinSelectionNoneZ_OK : Result_CoinSelectionNoneZ {
		public readonly CoinSelection res;
		internal Result_CoinSelectionNoneZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultCoinSelectionNoneZGetOk(ptr);
			org.ldk.structs.CoinSelection res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.CoinSelection(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_CoinSelectionNoneZ_Err : Result_CoinSelectionNoneZ {
		internal Result_CoinSelectionNoneZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	/**
	 * Creates a new CResult_CoinSelectionNoneZ in the success state.
	 */
	public static Result_CoinSelectionNoneZ ok(org.ldk.structs.CoinSelection o) {
		long ret = Bindings.CResultCoinSelectionNoneZOk(o == null ? 0 : o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CoinSelectionNoneZ ret_hu_conv = Result_CoinSelectionNoneZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_CoinSelectionNoneZ in the error state.
	 */
	public static Result_CoinSelectionNoneZ err() {
		long ret = Bindings.CResultCoinSelectionNoneZErr();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CoinSelectionNoneZ ret_hu_conv = Result_CoinSelectionNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultCoinSelectionNoneZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = Bindings.CResultCoinSelectionNoneZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_CoinSelectionNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_CoinSelectionNoneZ clone() {
		long ret = Bindings.CResultCoinSelectionNoneZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CoinSelectionNoneZ ret_hu_conv = Result_CoinSelectionNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
