
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of OnionMessageContents */
public interface IOnionMessageContents {
	/**Returns the TLV type identifying the message contents. MUST be >= 64.
	 */
	long tlv_type();
	/**Serialize the object into a byte array
	 */
	byte[] write();
	/**Return a human-readable "debug" string describing this object
	 */
	string debug_str();
}

/**
 * The contents of an onion message.
 */
public class OnionMessageContents : CommonBase {
	internal Bindings.LDKOnionMessageContents bindings_instance;
	internal long instance_idx;

	internal OnionMessageContents(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~OnionMessageContents() {
		if (ptr != 0) { Bindings.OnionMessageContentsFree(ptr); }
	}

	private class LDKOnionMessageContentsHolder { internal OnionMessageContents held; }
	private class LDKOnionMessageContentsImpl : Bindings.LDKOnionMessageContents {
		internal LDKOnionMessageContentsImpl(IOnionMessageContents arg, LDKOnionMessageContentsHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private IOnionMessageContents arg;
		private LDKOnionMessageContentsHolder impl_holder;
		public long TlvType() {
			long ret = arg.tlv_type();
				GC.KeepAlive(arg);
			return ret;
		}
		public long Write() {
			byte[] ret = arg.write();
				GC.KeepAlive(arg);
			long result = InternalUtils.encodeUint8Array(ret);
			return result;
		}
		public long DebugStr() {
			string ret = arg.debug_str();
				GC.KeepAlive(arg);
			long result = InternalUtils.encodeString(ret);
			return result;
		}
	}

	/** Creates a new instance of OnionMessageContents from a given implementation */
	public static OnionMessageContents new_impl(IOnionMessageContents arg) {
		LDKOnionMessageContentsHolder impl_holder = new LDKOnionMessageContentsHolder();
		LDKOnionMessageContentsImpl impl = new LDKOnionMessageContentsImpl(arg, impl_holder);
		long[] ptr_idx = Bindings.LDKOnionMessageContentsNew(impl);

		impl_holder.held = new OnionMessageContents(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		return impl_holder.held;
	}

	/**
	 * Returns the TLV type identifying the message contents. MUST be >= 64.
	 */
	public long tlv_type() {
		long ret = Bindings.OnionMessageContentsTlvType(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Serialize the object into a byte array
	 */
	public byte[] write() {
		long ret = Bindings.OnionMessageContentsWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Return a human-readable "debug" string describing this object
	 */
	public string debug_str() {
		long ret = Bindings.OnionMessageContentsDebugStr(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.decodeString(ret);
		return ret_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.OnionMessageContentsClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of a OnionMessageContents
	 */
	public OnionMessageContents clone() {
		long ret = Bindings.OnionMessageContentsClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		OnionMessageContents ret_hu_conv = new OnionMessageContents(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
