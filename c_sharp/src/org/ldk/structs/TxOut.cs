using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class TxOut : CommonBase {
	/** The script_pubkey in this output */
	public readonly byte[] script_pubkey;
	/** The value, in satoshis, of this output */
	public readonly long value;

    internal TxOut(object _dummy, long ptr) : base(ptr) {
		this.script_pubkey = InternalUtils.decodeUint8Array(Bindings.TxOutGetScriptPubkey(ptr));
		this.value = Bindings.TxOutGetValue(ptr);
	}
    public TxOut(long value, byte[] script_pubkey) : this(null, Bindings.TxOutNew(InternalUtils.encodeUint8Array(script_pubkey), value)) {}

	~TxOut() {
		if (ptr != 0) { Bindings.TxOutFree(ptr); }
	}
}} } }
