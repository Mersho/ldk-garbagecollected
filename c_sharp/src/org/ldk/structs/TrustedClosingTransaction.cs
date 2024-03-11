using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A wrapper on ClosingTransaction indicating that the built bitcoin
 * transaction is trusted.
 * 
 * See trust() and verify() functions on CommitmentTransaction.
 * 
 * This structure implements Deref.
 */
public class TrustedClosingTransaction : CommonBase {
	internal TrustedClosingTransaction(object _dummy, long ptr) : base(ptr) { }
	~TrustedClosingTransaction() {
		if (ptr != 0) { Bindings.TrustedClosingTransactionFree(ptr); }
	}

	/**
	 * The pre-built Bitcoin commitment transaction
	 */
	public byte[] built_transaction() {
		long ret = Bindings.TrustedClosingTransactionBuiltTransaction(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Get the SIGHASH_ALL sighash value of the transaction.
	 * 
	 * This can be used to verify a signature.
	 */
	public byte[] get_sighash_all(byte[] funding_redeemscript, long channel_value_satoshis) {
		long ret = Bindings.TrustedClosingTransactionGetSighashAll(this.ptr, InternalUtils.encodeUint8Array(funding_redeemscript), channel_value_satoshis);
		GC.KeepAlive(this);
		GC.KeepAlive(funding_redeemscript);
		GC.KeepAlive(channel_value_satoshis);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Sign a transaction, either because we are counter-signing the counterparty's transaction or
	 * because we are about to broadcast a holder transaction.
	 */
	public byte[] sign(byte[] funding_key, byte[] funding_redeemscript, long channel_value_satoshis) {
		long ret = Bindings.TrustedClosingTransactionSign(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(funding_key, 32)), InternalUtils.encodeUint8Array(funding_redeemscript), channel_value_satoshis);
		GC.KeepAlive(this);
		GC.KeepAlive(funding_key);
		GC.KeepAlive(funding_redeemscript);
		GC.KeepAlive(channel_value_satoshis);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

}
} } }
