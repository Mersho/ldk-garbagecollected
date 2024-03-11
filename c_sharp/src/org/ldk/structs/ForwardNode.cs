using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An intermediate node, its outbound channel, and relay parameters.
 */
public class ForwardNode : CommonBase {
	internal ForwardNode(object _dummy, long ptr) : base(ptr) { }
	~ForwardNode() {
		if (ptr != 0) { Bindings.ForwardNodeFree(ptr); }
	}

	/**
	 * The TLVs for this node's [`BlindedHop`], where the fee parameters contained within are also
	 * used for [`BlindedPayInfo`] construction.
	 */
	public ForwardTlvs get_tlvs() {
		long ret = Bindings.ForwardNodeGetTlvs(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ForwardTlvs ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ForwardTlvs(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The TLVs for this node's [`BlindedHop`], where the fee parameters contained within are also
	 * used for [`BlindedPayInfo`] construction.
	 */
	public void set_tlvs(org.ldk.structs.ForwardTlvs val) {
		Bindings.ForwardNodeSetTlvs(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * This node's pubkey.
	 */
	public byte[] get_node_id() {
		long ret = Bindings.ForwardNodeGetNodeId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * This node's pubkey.
	 */
	public void set_node_id(byte[] val) {
		Bindings.ForwardNodeSetNodeId(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum value, in msat, that may be accepted by this node.
	 */
	public long get_htlc_maximum_msat() {
		long ret = Bindings.ForwardNodeGetHtlcMaximumMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum value, in msat, that may be accepted by this node.
	 */
	public void set_htlc_maximum_msat(long val) {
		Bindings.ForwardNodeSetHtlcMaximumMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new ForwardNode given each field
	 */
	public static ForwardNode of(org.ldk.structs.ForwardTlvs tlvs_arg, byte[] node_id_arg, long htlc_maximum_msat_arg) {
		long ret = Bindings.ForwardNodeNew(tlvs_arg == null ? 0 : tlvs_arg.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(node_id_arg, 33)), htlc_maximum_msat_arg);
		GC.KeepAlive(tlvs_arg);
		GC.KeepAlive(node_id_arg);
		GC.KeepAlive(htlc_maximum_msat_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ForwardNode ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ForwardNode(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(tlvs_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.ForwardNodeClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ForwardNode
	 */
	public ForwardNode clone() {
		long ret = Bindings.ForwardNodeClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ForwardNode ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ForwardNode(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
