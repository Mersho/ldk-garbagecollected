using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_ProbabilisticScorerDecodeErrorZ : CommonBase {
	Result_ProbabilisticScorerDecodeErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_ProbabilisticScorerDecodeErrorZ() {
		if (ptr != 0) { Bindings.CResultProbabilisticScorerDecodeErrorZFree(ptr); }
	}

	internal static Result_ProbabilisticScorerDecodeErrorZ constr_from_ptr(long ptr) {
		if (Bindings.CResultProbabilisticScorerDecodeErrorZIsOk(ptr)) {
			return new Result_ProbabilisticScorerDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_ProbabilisticScorerDecodeErrorZ_Err(null, ptr);
		}
	}
	public class Result_ProbabilisticScorerDecodeErrorZ_OK : Result_ProbabilisticScorerDecodeErrorZ {
		public readonly ProbabilisticScorer res;
		internal Result_ProbabilisticScorerDecodeErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
			long res = Bindings.CResultProbabilisticScorerDecodeErrorZGetOk(ptr);
			org.ldk.structs.ProbabilisticScorer res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.ProbabilisticScorer(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.AddLast(this); };
			this.res = res_hu_conv;
		}
	}

	public class Result_ProbabilisticScorerDecodeErrorZ_Err : Result_ProbabilisticScorerDecodeErrorZ {
		public readonly DecodeError err;
		internal Result_ProbabilisticScorerDecodeErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = Bindings.CResultProbabilisticScorerDecodeErrorZGetErr(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_ProbabilisticScorerDecodeErrorZ in the success state.
	 */
	public static Result_ProbabilisticScorerDecodeErrorZ ok(ProbabilisticScoringDecayParameters o_decay_params, NetworkGraph o_network_graph, Logger o_logger) {
		long ret = Bindings.CResultProbabilisticScorerDecodeErrorZOk(Bindings.ProbabilisticScorerNew(o_decay_params == null ? 0 : o_decay_params.ptr, o_network_graph == null ? 0 : o_network_graph.ptr, o_logger.ptr));
		GC.KeepAlive(o_decay_params);
		GC.KeepAlive(o_network_graph);
		GC.KeepAlive(o_logger);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ProbabilisticScorerDecodeErrorZ ret_hu_conv = Result_ProbabilisticScorerDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o_decay_params); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o_network_graph); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o_logger); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_ProbabilisticScorerDecodeErrorZ in the error state.
	 */
	public static Result_ProbabilisticScorerDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = Bindings.CResultProbabilisticScorerDecodeErrorZErr(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ProbabilisticScorerDecodeErrorZ ret_hu_conv = Result_ProbabilisticScorerDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = Bindings.CResultProbabilisticScorerDecodeErrorZIsOk(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

}
} } }
