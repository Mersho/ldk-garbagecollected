using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * The parameters required to derive a channel signer via [`SignerProvider`].
 */
public class ChannelDerivationParameters : CommonBase {
	internal ChannelDerivationParameters(object _dummy, long ptr) : base(ptr) { }
	~ChannelDerivationParameters() {
		if (ptr != 0) { Bindings.ChannelDerivationParametersFree(ptr); }
	}

	/**
	 * The value in satoshis of the channel we're attempting to spend the anchor output of.
	 */
	public long get_value_satoshis() {
		long ret = Bindings.ChannelDerivationParametersGetValueSatoshis(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The value in satoshis of the channel we're attempting to spend the anchor output of.
	 */
	public void set_value_satoshis(long val) {
		Bindings.ChannelDerivationParametersSetValueSatoshis(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The unique identifier to re-derive the signer for the associated channel.
	 */
	public byte[] get_keys_id() {
		long ret = Bindings.ChannelDerivationParametersGetKeysId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The unique identifier to re-derive the signer for the associated channel.
	 */
	public void set_keys_id(byte[] val) {
		Bindings.ChannelDerivationParametersSetKeysId(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The necessary channel parameters that need to be provided to the re-derived signer through
	 * [`ChannelSigner::provide_channel_parameters`].
	 */
	public ChannelTransactionParameters get_transaction_parameters() {
		long ret = Bindings.ChannelDerivationParametersGetTransactionParameters(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The necessary channel parameters that need to be provided to the re-derived signer through
	 * [`ChannelSigner::provide_channel_parameters`].
	 */
	public void set_transaction_parameters(org.ldk.structs.ChannelTransactionParameters val) {
		Bindings.ChannelDerivationParametersSetTransactionParameters(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Constructs a new ChannelDerivationParameters given each field
	 */
	public static ChannelDerivationParameters of(long value_satoshis_arg, byte[] keys_id_arg, org.ldk.structs.ChannelTransactionParameters transaction_parameters_arg) {
		long ret = Bindings.ChannelDerivationParametersNew(value_satoshis_arg, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(keys_id_arg, 32)), transaction_parameters_arg == null ? 0 : transaction_parameters_arg.ptr);
		GC.KeepAlive(value_satoshis_arg);
		GC.KeepAlive(keys_id_arg);
		GC.KeepAlive(transaction_parameters_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelDerivationParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelDerivationParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(transaction_parameters_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.ChannelDerivationParametersClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelDerivationParameters
	 */
	public ChannelDerivationParameters clone() {
		long ret = Bindings.ChannelDerivationParametersClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelDerivationParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelDerivationParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two ChannelDerivationParameterss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.ChannelDerivationParameters b) {
		bool ret = Bindings.ChannelDerivationParametersEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ChannelDerivationParameters)) return false;
		return this.eq((ChannelDerivationParameters)o);
	}
	/**
	 * Serialize the ChannelDerivationParameters object into a byte array which can be read by ChannelDerivationParameters_read
	 */
	public byte[] write() {
		long ret = Bindings.ChannelDerivationParametersWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a ChannelDerivationParameters from a byte array, created by ChannelDerivationParameters_write
	 */
	public static Result_ChannelDerivationParametersDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.ChannelDerivationParametersRead(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelDerivationParametersDecodeErrorZ ret_hu_conv = Result_ChannelDerivationParametersDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
