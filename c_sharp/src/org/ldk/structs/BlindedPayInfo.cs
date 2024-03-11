using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Information needed to route a payment across a [`BlindedPath`].
 */
public class BlindedPayInfo : CommonBase {
	internal BlindedPayInfo(object _dummy, long ptr) : base(ptr) { }
	~BlindedPayInfo() {
		if (ptr != 0) { Bindings.BlindedPayInfoFree(ptr); }
	}

	/**
	 * Base fee charged (in millisatoshi) for the entire blinded path.
	 */
	public int get_fee_base_msat() {
		int ret = Bindings.BlindedPayInfoGetFeeBaseMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Base fee charged (in millisatoshi) for the entire blinded path.
	 */
	public void set_fee_base_msat(int val) {
		Bindings.BlindedPayInfoSetFeeBaseMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Liquidity fee charged (in millionths of the amount transferred) for the entire blinded path
	 * (i.e., 10,000 is 1%).
	 */
	public int get_fee_proportional_millionths() {
		int ret = Bindings.BlindedPayInfoGetFeeProportionalMillionths(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Liquidity fee charged (in millionths of the amount transferred) for the entire blinded path
	 * (i.e., 10,000 is 1%).
	 */
	public void set_fee_proportional_millionths(int val) {
		Bindings.BlindedPayInfoSetFeeProportionalMillionths(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Number of blocks subtracted from an incoming HTLC's `cltv_expiry` for the entire blinded
	 * path.
	 */
	public short get_cltv_expiry_delta() {
		short ret = Bindings.BlindedPayInfoGetCltvExpiryDelta(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Number of blocks subtracted from an incoming HTLC's `cltv_expiry` for the entire blinded
	 * path.
	 */
	public void set_cltv_expiry_delta(short val) {
		Bindings.BlindedPayInfoSetCltvExpiryDelta(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The minimum HTLC value (in millisatoshi) that is acceptable to all channel peers on the
	 * blinded path from the introduction node to the recipient, accounting for any fees, i.e., as
	 * seen by the recipient.
	 */
	public long get_htlc_minimum_msat() {
		long ret = Bindings.BlindedPayInfoGetHtlcMinimumMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The minimum HTLC value (in millisatoshi) that is acceptable to all channel peers on the
	 * blinded path from the introduction node to the recipient, accounting for any fees, i.e., as
	 * seen by the recipient.
	 */
	public void set_htlc_minimum_msat(long val) {
		Bindings.BlindedPayInfoSetHtlcMinimumMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum HTLC value (in millisatoshi) that is acceptable to all channel peers on the
	 * blinded path from the introduction node to the recipient, accounting for any fees, i.e., as
	 * seen by the recipient.
	 */
	public long get_htlc_maximum_msat() {
		long ret = Bindings.BlindedPayInfoGetHtlcMaximumMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum HTLC value (in millisatoshi) that is acceptable to all channel peers on the
	 * blinded path from the introduction node to the recipient, accounting for any fees, i.e., as
	 * seen by the recipient.
	 */
	public void set_htlc_maximum_msat(long val) {
		Bindings.BlindedPayInfoSetHtlcMaximumMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Features set in `encrypted_data_tlv` for the `encrypted_recipient_data` TLV record in an
	 * onion payload.
	 */
	public BlindedHopFeatures get_features() {
		long ret = Bindings.BlindedPayInfoGetFeatures(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BlindedHopFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BlindedHopFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Features set in `encrypted_data_tlv` for the `encrypted_recipient_data` TLV record in an
	 * onion payload.
	 */
	public void set_features(org.ldk.structs.BlindedHopFeatures val) {
		Bindings.BlindedPayInfoSetFeatures(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Constructs a new BlindedPayInfo given each field
	 */
	public static BlindedPayInfo of(int fee_base_msat_arg, int fee_proportional_millionths_arg, short cltv_expiry_delta_arg, long htlc_minimum_msat_arg, long htlc_maximum_msat_arg, org.ldk.structs.BlindedHopFeatures features_arg) {
		long ret = Bindings.BlindedPayInfoNew(fee_base_msat_arg, fee_proportional_millionths_arg, cltv_expiry_delta_arg, htlc_minimum_msat_arg, htlc_maximum_msat_arg, features_arg == null ? 0 : features_arg.ptr);
		GC.KeepAlive(fee_base_msat_arg);
		GC.KeepAlive(fee_proportional_millionths_arg);
		GC.KeepAlive(cltv_expiry_delta_arg);
		GC.KeepAlive(htlc_minimum_msat_arg);
		GC.KeepAlive(htlc_maximum_msat_arg);
		GC.KeepAlive(features_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BlindedPayInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BlindedPayInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(features_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.BlindedPayInfoClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the BlindedPayInfo
	 */
	public BlindedPayInfo clone() {
		long ret = Bindings.BlindedPayInfoClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BlindedPayInfo ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BlindedPayInfo(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the BlindedPayInfo.
	 */
	public long hash() {
		long ret = Bindings.BlindedPayInfoHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two BlindedPayInfos contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.BlindedPayInfo b) {
		bool ret = Bindings.BlindedPayInfoEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is BlindedPayInfo)) return false;
		return this.eq((BlindedPayInfo)o);
	}
	/**
	 * Serialize the BlindedPayInfo object into a byte array which can be read by BlindedPayInfo_read
	 */
	public byte[] write() {
		long ret = Bindings.BlindedPayInfoWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a BlindedPayInfo from a byte array, created by BlindedPayInfo_write
	 */
	public static Result_BlindedPayInfoDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.BlindedPayInfoRead(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedPayInfoDecodeErrorZ ret_hu_conv = Result_BlindedPayInfoDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
