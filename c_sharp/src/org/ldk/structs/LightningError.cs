using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An Err type for failure to process messages.
 */
public class LightningError : CommonBase {
	internal LightningError(object _dummy, long ptr) : base(ptr) { }
	~LightningError() {
		if (ptr != 0) { Bindings.LightningErrorFree(ptr); }
	}

	/**
	 * A human-readable message describing the error
	 */
	public string get_err() {
		long ret = Bindings.LightningErrorGetErr(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

	/**
	 * A human-readable message describing the error
	 */
	public void set_err(string val) {
		Bindings.LightningErrorSetErr(this.ptr, InternalUtils.encodeString(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The action which should be taken against the offending peer.
	 */
	public ErrorAction get_action() {
		long ret = Bindings.LightningErrorGetAction(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ErrorAction ret_hu_conv = org.ldk.structs.ErrorAction.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The action which should be taken against the offending peer.
	 */
	public void set_action(org.ldk.structs.ErrorAction val) {
		Bindings.LightningErrorSetAction(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Constructs a new LightningError given each field
	 */
	public static LightningError of(string err_arg, org.ldk.structs.ErrorAction action_arg) {
		long ret = Bindings.LightningErrorNew(InternalUtils.encodeString(err_arg), action_arg.ptr);
		GC.KeepAlive(err_arg);
		GC.KeepAlive(action_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LightningError ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LightningError(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(action_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.LightningErrorClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the LightningError
	 */
	public LightningError clone() {
		long ret = Bindings.LightningErrorClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.LightningError ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.LightningError(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
