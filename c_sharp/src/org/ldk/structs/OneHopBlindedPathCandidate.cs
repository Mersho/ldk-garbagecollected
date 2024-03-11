using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A [`CandidateRouteHop::OneHopBlinded`] entry.
 */
public class OneHopBlindedPathCandidate : CommonBase {
	internal OneHopBlindedPathCandidate(object _dummy, long ptr) : base(ptr) { }
	~OneHopBlindedPathCandidate() {
		if (ptr != 0) { Bindings.OneHopBlindedPathCandidateFree(ptr); }
	}

	internal long clone_ptr() {
		long ret = Bindings.OneHopBlindedPathCandidateClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the OneHopBlindedPathCandidate
	 */
	public OneHopBlindedPathCandidate clone() {
		long ret = Bindings.OneHopBlindedPathCandidateClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OneHopBlindedPathCandidate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OneHopBlindedPathCandidate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
