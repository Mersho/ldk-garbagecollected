using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Information about an HTLC as it appears in a commitment transaction
 */
public class HTLCOutputInCommitment : CommonBase {
	internal HTLCOutputInCommitment(object _dummy, long ptr) : base(ptr) { }
	~HTLCOutputInCommitment() {
		if (ptr != 0) { Bindings.HTLCOutputInCommitmentFree(ptr); }
	}

	/**
	 * Whether the HTLC was \"offered\" (ie outbound in relation to this commitment transaction).
	 * Note that this is not the same as whether it is ountbound *from us*. To determine that you
	 * need to compare this value to whether the commitment transaction in question is that of
	 * the counterparty or our own.
	 */
	public bool get_offered() {
		bool ret = Bindings.HTLCOutputInCommitmentGetOffered(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Whether the HTLC was \"offered\" (ie outbound in relation to this commitment transaction).
	 * Note that this is not the same as whether it is ountbound *from us*. To determine that you
	 * need to compare this value to whether the commitment transaction in question is that of
	 * the counterparty or our own.
	 */
	public void set_offered(bool val) {
		Bindings.HTLCOutputInCommitmentSetOffered(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The value, in msat, of the HTLC. The value as it appears in the commitment transaction is
	 * this divided by 1000.
	 */
	public long get_amount_msat() {
		long ret = Bindings.HTLCOutputInCommitmentGetAmountMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The value, in msat, of the HTLC. The value as it appears in the commitment transaction is
	 * this divided by 1000.
	 */
	public void set_amount_msat(long val) {
		Bindings.HTLCOutputInCommitmentSetAmountMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The CLTV lock-time at which this HTLC expires.
	 */
	public int get_cltv_expiry() {
		int ret = Bindings.HTLCOutputInCommitmentGetCltvExpiry(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The CLTV lock-time at which this HTLC expires.
	 */
	public void set_cltv_expiry(int val) {
		Bindings.HTLCOutputInCommitmentSetCltvExpiry(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The hash of the preimage which unlocks this HTLC.
	 */
	public byte[] get_payment_hash() {
		long ret = Bindings.HTLCOutputInCommitmentGetPaymentHash(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The hash of the preimage which unlocks this HTLC.
	 */
	public void set_payment_hash(byte[] val) {
		Bindings.HTLCOutputInCommitmentSetPaymentHash(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The position within the commitment transactions' outputs. This may be None if the value is
	 * below the dust limit (in which case no output appears in the commitment transaction and the
	 * value is spent to additional transaction fees).
	 */
	public Option_u32Z get_transaction_output_index() {
		long ret = Bindings.HTLCOutputInCommitmentGetTransactionOutputIndex(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u32Z ret_hu_conv = org.ldk.structs.Option_u32Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The position within the commitment transactions' outputs. This may be None if the value is
	 * below the dust limit (in which case no output appears in the commitment transaction and the
	 * value is spent to additional transaction fees).
	 */
	public void set_transaction_output_index(org.ldk.structs.Option_u32Z val) {
		Bindings.HTLCOutputInCommitmentSetTransactionOutputIndex(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Constructs a new HTLCOutputInCommitment given each field
	 */
	public static HTLCOutputInCommitment of(bool offered_arg, long amount_msat_arg, int cltv_expiry_arg, byte[] payment_hash_arg, org.ldk.structs.Option_u32Z transaction_output_index_arg) {
		long ret = Bindings.HTLCOutputInCommitmentNew(offered_arg, amount_msat_arg, cltv_expiry_arg, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_hash_arg, 32)), transaction_output_index_arg.ptr);
		GC.KeepAlive(offered_arg);
		GC.KeepAlive(amount_msat_arg);
		GC.KeepAlive(cltv_expiry_arg);
		GC.KeepAlive(payment_hash_arg);
		GC.KeepAlive(transaction_output_index_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCOutputInCommitment ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HTLCOutputInCommitment(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(transaction_output_index_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.HTLCOutputInCommitmentClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the HTLCOutputInCommitment
	 */
	public HTLCOutputInCommitment clone() {
		long ret = Bindings.HTLCOutputInCommitmentClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCOutputInCommitment ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HTLCOutputInCommitment(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two HTLCOutputInCommitments contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.HTLCOutputInCommitment b) {
		bool ret = Bindings.HTLCOutputInCommitmentEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is HTLCOutputInCommitment)) return false;
		return this.eq((HTLCOutputInCommitment)o);
	}
	/**
	 * Serialize the HTLCOutputInCommitment object into a byte array which can be read by HTLCOutputInCommitment_read
	 */
	public byte[] write() {
		long ret = Bindings.HTLCOutputInCommitmentWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a HTLCOutputInCommitment from a byte array, created by HTLCOutputInCommitment_write
	 */
	public static Result_HTLCOutputInCommitmentDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.HTLCOutputInCommitmentRead(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_HTLCOutputInCommitmentDecodeErrorZ ret_hu_conv = Result_HTLCOutputInCommitmentDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
