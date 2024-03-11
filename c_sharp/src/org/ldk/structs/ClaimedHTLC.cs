using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Information about an HTLC that is part of a payment that can be claimed.
 */
public class ClaimedHTLC : CommonBase {
	internal ClaimedHTLC(object _dummy, long ptr) : base(ptr) { }
	~ClaimedHTLC() {
		if (ptr != 0) { Bindings.ClaimedHTLCFree(ptr); }
	}

	/**
	 * The `channel_id` of the channel over which the HTLC was received.
	 */
	public byte[] get_channel_id() {
		long ret = Bindings.ClaimedHTLCGetChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The `channel_id` of the channel over which the HTLC was received.
	 */
	public void set_channel_id(byte[] val) {
		Bindings.ClaimedHTLCSetChannelId(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The `user_channel_id` of the channel over which the HTLC was received. This is the value
	 * passed in to [`ChannelManager::create_channel`] for outbound channels, or to
	 * [`ChannelManager::accept_inbound_channel`] for inbound channels if
	 * [`UserConfig::manually_accept_inbound_channels`] config flag is set to true. Otherwise
	 * `user_channel_id` will be randomized for an inbound channel.
	 * 
	 * This field will be zero for a payment that was serialized prior to LDK version 0.0.117. (This
	 * should only happen in the case that a payment was claimable prior to LDK version 0.0.117, but
	 * was not actually claimed until after upgrading.)
	 * 
	 * [`ChannelManager::create_channel`]: crate::ln::channelmanager::ChannelManager::create_channel
	 * [`ChannelManager::accept_inbound_channel`]: crate::ln::channelmanager::ChannelManager::accept_inbound_channel
	 * [`UserConfig::manually_accept_inbound_channels`]: crate::util::config::UserConfig::manually_accept_inbound_channels
	 */
	public UInt128 get_user_channel_id() {
		long ret = Bindings.ClaimedHTLCGetUserChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.util.UInt128 ret_conv = new org.ldk.util.UInt128(ret);
		return ret_conv;
	}

	/**
	 * The `user_channel_id` of the channel over which the HTLC was received. This is the value
	 * passed in to [`ChannelManager::create_channel`] for outbound channels, or to
	 * [`ChannelManager::accept_inbound_channel`] for inbound channels if
	 * [`UserConfig::manually_accept_inbound_channels`] config flag is set to true. Otherwise
	 * `user_channel_id` will be randomized for an inbound channel.
	 * 
	 * This field will be zero for a payment that was serialized prior to LDK version 0.0.117. (This
	 * should only happen in the case that a payment was claimable prior to LDK version 0.0.117, but
	 * was not actually claimed until after upgrading.)
	 * 
	 * [`ChannelManager::create_channel`]: crate::ln::channelmanager::ChannelManager::create_channel
	 * [`ChannelManager::accept_inbound_channel`]: crate::ln::channelmanager::ChannelManager::accept_inbound_channel
	 * [`UserConfig::manually_accept_inbound_channels`]: crate::util::config::UserConfig::manually_accept_inbound_channels
	 */
	public void set_user_channel_id(org.ldk.util.UInt128 val) {
		Bindings.ClaimedHTLCSetUserChannelId(this.ptr, InternalUtils.encodeUint8Array(val.getLEBytes()));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The block height at which this HTLC expires.
	 */
	public int get_cltv_expiry() {
		int ret = Bindings.ClaimedHTLCGetCltvExpiry(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The block height at which this HTLC expires.
	 */
	public void set_cltv_expiry(int val) {
		Bindings.ClaimedHTLCSetCltvExpiry(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The amount (in msats) of this part of an MPP.
	 */
	public long get_value_msat() {
		long ret = Bindings.ClaimedHTLCGetValueMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The amount (in msats) of this part of an MPP.
	 */
	public void set_value_msat(long val) {
		Bindings.ClaimedHTLCSetValueMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The extra fee our counterparty skimmed off the top of this HTLC, if any.
	 * 
	 * This value will always be 0 for [`ClaimedHTLC`]s serialized with LDK versions prior to
	 * 0.0.119.
	 */
	public long get_counterparty_skimmed_fee_msat() {
		long ret = Bindings.ClaimedHTLCGetCounterpartySkimmedFeeMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The extra fee our counterparty skimmed off the top of this HTLC, if any.
	 * 
	 * This value will always be 0 for [`ClaimedHTLC`]s serialized with LDK versions prior to
	 * 0.0.119.
	 */
	public void set_counterparty_skimmed_fee_msat(long val) {
		Bindings.ClaimedHTLCSetCounterpartySkimmedFeeMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new ClaimedHTLC given each field
	 */
	public static ClaimedHTLC of(byte[] channel_id_arg, org.ldk.util.UInt128 user_channel_id_arg, int cltv_expiry_arg, long value_msat_arg, long counterparty_skimmed_fee_msat_arg) {
		long ret = Bindings.ClaimedHTLCNew(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(channel_id_arg, 32)), InternalUtils.encodeUint8Array(user_channel_id_arg.getLEBytes()), cltv_expiry_arg, value_msat_arg, counterparty_skimmed_fee_msat_arg);
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(user_channel_id_arg);
		GC.KeepAlive(cltv_expiry_arg);
		GC.KeepAlive(value_msat_arg);
		GC.KeepAlive(counterparty_skimmed_fee_msat_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClaimedHTLC ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ClaimedHTLC(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.ClaimedHTLCClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ClaimedHTLC
	 */
	public ClaimedHTLC clone() {
		long ret = Bindings.ClaimedHTLCClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClaimedHTLC ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ClaimedHTLC(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two ClaimedHTLCs contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.ClaimedHTLC b) {
		bool ret = Bindings.ClaimedHTLCEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ClaimedHTLC)) return false;
		return this.eq((ClaimedHTLC)o);
	}
	/**
	 * Serialize the ClaimedHTLC object into a byte array which can be read by ClaimedHTLC_read
	 */
	public byte[] write() {
		long ret = Bindings.ClaimedHTLCWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a ClaimedHTLC from a byte array, created by ClaimedHTLC_write
	 */
	public static Result_ClaimedHTLCDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.ClaimedHTLCRead(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ClaimedHTLCDecodeErrorZ ret_hu_conv = Result_ClaimedHTLCDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
