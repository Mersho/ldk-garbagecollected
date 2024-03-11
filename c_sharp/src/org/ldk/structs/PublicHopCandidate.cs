using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A [`CandidateRouteHop::PublicHop`] entry.
 */
public class PublicHopCandidate : CommonBase {
	internal PublicHopCandidate(object _dummy, long ptr) : base(ptr) { }
	~PublicHopCandidate() {
		if (ptr != 0) { Bindings.PublicHopCandidateFree(ptr); }
	}

	/**
	 * The short channel ID of the channel, i.e. the identifier by which we refer to this
	 * channel.
	 */
	public long get_short_channel_id() {
		long ret = Bindings.PublicHopCandidateGetShortChannelId(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The short channel ID of the channel, i.e. the identifier by which we refer to this
	 * channel.
	 */
	public void set_short_channel_id(long val) {
		Bindings.PublicHopCandidateSetShortChannelId(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	internal long clone_ptr() {
		long ret = Bindings.PublicHopCandidateClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the PublicHopCandidate
	 */
	public PublicHopCandidate clone() {
		long ret = Bindings.PublicHopCandidateClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PublicHopCandidate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PublicHopCandidate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
