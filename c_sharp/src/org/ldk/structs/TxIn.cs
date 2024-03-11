using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class TxIn : CommonBase {
	/** The witness in this input, in serialized form */
	public readonly byte[] witness;
	/** The script_sig in this input */
	public readonly byte[] script_sig;
	/** The transaction output's sequence number */
	public readonly int sequence;
	/** The txid this input is spending */
	public readonly byte[] previous_txid;
	/** The output index within the spent transaction of the output this input is spending */
	public readonly int previous_vout;

	internal TxIn(object _dummy, long ptr) : base(ptr) {
		this.witness = InternalUtils.decodeUint8Array(Bindings.TxInGetWitness(ptr));
		this.script_sig = InternalUtils.decodeUint8Array(Bindings.TxInGetScriptSig(ptr));
		this.sequence = Bindings.TxInGetSequence(ptr);
		this.previous_txid = InternalUtils.decodeUint8Array(Bindings.TxInGetPreviousTxid(ptr));
		this.previous_vout = Bindings.TxInGetPreviousVout(ptr);
	}
	public TxIn(byte[] witness, byte[] script_sig, int sequence, byte[] previous_txid, int previous_vout)
	: this(null, Bindings.TxInNew(InternalUtils.encodeUint8Array(witness), InternalUtils.encodeUint8Array(script_sig), sequence, InternalUtils.encodeUint8Array(previous_txid), previous_vout)) {}

	~TxIn() {
		if (ptr != 0) { Bindings.TxInFree(ptr); }
	}
}} } }
