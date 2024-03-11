using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * The contents of an [`OnionMessage`] as read from the wire.
 * 
 * [`OnionMessage`]: crate::ln::msgs::OnionMessage
 */
public class ParsedOnionMessageContents : CommonBase {
	protected ParsedOnionMessageContents(object _dummy, long ptr) : base(ptr) { }
	~ParsedOnionMessageContents() {
		if (ptr != 0) { Bindings.ParsedOnionMessageContentsFree(ptr); }
	}

	internal static ParsedOnionMessageContents constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKParsedOnionMessageContentsTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new ParsedOnionMessageContents_Offers(ptr);
			case 1: return new ParsedOnionMessageContents_Custom(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A ParsedOnionMessageContents of type Offers */
	public class ParsedOnionMessageContents_Offers : ParsedOnionMessageContents {
		public OffersMessage offers;
		internal ParsedOnionMessageContents_Offers(long ptr) : base(null, ptr) {
			long offers = Bindings.LDKParsedOnionMessageContentsOffersGetOffers(ptr);
			org.ldk.structs.OffersMessage offers_hu_conv = org.ldk.structs.OffersMessage.constr_from_ptr(offers);
			if (offers_hu_conv != null) { offers_hu_conv.ptrs_to.AddLast(this); };
			this.offers = offers_hu_conv;
		}
	}
	/** A ParsedOnionMessageContents of type Custom */
	public class ParsedOnionMessageContents_Custom : ParsedOnionMessageContents {
		public OnionMessageContents custom;
		internal ParsedOnionMessageContents_Custom(long ptr) : base(null, ptr) {
			long custom = Bindings.LDKParsedOnionMessageContentsCustomGetCustom(ptr);
			OnionMessageContents ret_hu_conv = new OnionMessageContents(null, custom);
			if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
			this.custom = ret_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = Bindings.ParsedOnionMessageContentsClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ParsedOnionMessageContents
	 */
	public ParsedOnionMessageContents clone() {
		long ret = Bindings.ParsedOnionMessageContentsClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ParsedOnionMessageContents ret_hu_conv = org.ldk.structs.ParsedOnionMessageContents.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Offers-variant ParsedOnionMessageContents
	 */
	public static ParsedOnionMessageContents offers(org.ldk.structs.OffersMessage a) {
		long ret = Bindings.ParsedOnionMessageContentsOffers(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ParsedOnionMessageContents ret_hu_conv = org.ldk.structs.ParsedOnionMessageContents.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(a); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Custom-variant ParsedOnionMessageContents
	 */
	public static ParsedOnionMessageContents custom(org.ldk.structs.OnionMessageContents a) {
		long ret = Bindings.ParsedOnionMessageContentsCustom(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ParsedOnionMessageContents ret_hu_conv = org.ldk.structs.ParsedOnionMessageContents.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(a); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new OnionMessageContents which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned OnionMessageContents must be freed before this_arg is
	 */
	public OnionMessageContents as_OnionMessageContents() {
		long ret = Bindings.ParsedOnionMessageContentsAsOnionMessageContents(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		OnionMessageContents ret_hu_conv = new OnionMessageContents(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the ParsedOnionMessageContents object into a byte array which can be read by ParsedOnionMessageContents_read
	 */
	public byte[] write() {
		long ret = Bindings.ParsedOnionMessageContentsWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

}
} } }
