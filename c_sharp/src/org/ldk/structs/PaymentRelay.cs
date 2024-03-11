using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Parameters for relaying over a given [`BlindedHop`].
 * 
 * [`BlindedHop`]: crate::blinded_path::BlindedHop
 */
public class PaymentRelay : CommonBase {
	internal PaymentRelay(object _dummy, long ptr) : base(ptr) { }
	~PaymentRelay() {
		if (ptr != 0) { Bindings.PaymentRelayFree(ptr); }
	}

	/**
	 * Number of blocks subtracted from an incoming HTLC's `cltv_expiry` for this [`BlindedHop`].
	 */
	public short get_cltv_expiry_delta() {
		short ret = Bindings.PaymentRelayGetCltvExpiryDelta(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Number of blocks subtracted from an incoming HTLC's `cltv_expiry` for this [`BlindedHop`].
	 */
	public void set_cltv_expiry_delta(short val) {
		Bindings.PaymentRelaySetCltvExpiryDelta(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Liquidity fee charged (in millionths of the amount transferred) for relaying a payment over
	 * this [`BlindedHop`], (i.e., 10,000 is 1%).
	 */
	public int get_fee_proportional_millionths() {
		int ret = Bindings.PaymentRelayGetFeeProportionalMillionths(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Liquidity fee charged (in millionths of the amount transferred) for relaying a payment over
	 * this [`BlindedHop`], (i.e., 10,000 is 1%).
	 */
	public void set_fee_proportional_millionths(int val) {
		Bindings.PaymentRelaySetFeeProportionalMillionths(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Base fee charged (in millisatoshi) for relaying a payment over this [`BlindedHop`].
	 */
	public int get_fee_base_msat() {
		int ret = Bindings.PaymentRelayGetFeeBaseMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Base fee charged (in millisatoshi) for relaying a payment over this [`BlindedHop`].
	 */
	public void set_fee_base_msat(int val) {
		Bindings.PaymentRelaySetFeeBaseMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new PaymentRelay given each field
	 */
	public static PaymentRelay of(short cltv_expiry_delta_arg, int fee_proportional_millionths_arg, int fee_base_msat_arg) {
		long ret = Bindings.PaymentRelayNew(cltv_expiry_delta_arg, fee_proportional_millionths_arg, fee_base_msat_arg);
		GC.KeepAlive(cltv_expiry_delta_arg);
		GC.KeepAlive(fee_proportional_millionths_arg);
		GC.KeepAlive(fee_base_msat_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentRelay ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentRelay(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.PaymentRelayClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the PaymentRelay
	 */
	public PaymentRelay clone() {
		long ret = Bindings.PaymentRelayClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentRelay ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentRelay(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the PaymentRelay object into a byte array which can be read by PaymentRelay_read
	 */
	public byte[] write() {
		long ret = Bindings.PaymentRelayWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a PaymentRelay from a byte array, created by PaymentRelay_write
	 */
	public static Result_PaymentRelayDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.PaymentRelayRead(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PaymentRelayDecodeErrorZ ret_hu_conv = Result_PaymentRelayDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
