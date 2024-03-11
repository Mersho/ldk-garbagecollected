
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of WriteableEcdsaChannelSigner */
public interface IWriteableEcdsaChannelSigner {
	/**Serialize the object into a byte array
	 */
	byte[] write();
}

/**
 * A writeable signer.
 * 
 * There will always be two instances of a signer per channel, one occupied by the
 * [`ChannelManager`] and another by the channel's [`ChannelMonitor`].
 * 
 * [`ChannelManager`]: crate::ln::channelmanager::ChannelManager
 * [`ChannelMonitor`]: crate::chain::channelmonitor::ChannelMonitor
 */
public class WriteableEcdsaChannelSigner : CommonBase {
	internal Bindings.LDKWriteableEcdsaChannelSigner bindings_instance;
	internal long instance_idx;

	internal WriteableEcdsaChannelSigner(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~WriteableEcdsaChannelSigner() {
		if (ptr != 0) { Bindings.WriteableEcdsaChannelSignerFree(ptr); }
	}

	private class LDKWriteableEcdsaChannelSignerHolder { internal WriteableEcdsaChannelSigner held; }
	private class LDKWriteableEcdsaChannelSignerImpl : Bindings.LDKWriteableEcdsaChannelSigner {
		internal LDKWriteableEcdsaChannelSignerImpl(IWriteableEcdsaChannelSigner arg, LDKWriteableEcdsaChannelSignerHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private IWriteableEcdsaChannelSigner arg;
		private LDKWriteableEcdsaChannelSignerHolder impl_holder;
		public long Write() {
			byte[] ret = arg.write();
				GC.KeepAlive(arg);
			long result = InternalUtils.encodeUint8Array(ret);
			return result;
		}
	}

	/** Creates a new instance of WriteableEcdsaChannelSigner from a given implementation */
	public static WriteableEcdsaChannelSigner new_impl(IWriteableEcdsaChannelSigner arg, IEcdsaChannelSigner ecdsaChannelSigner_impl, IChannelSigner channelSigner_impl, ChannelPublicKeys pubkeys) {
		LDKWriteableEcdsaChannelSignerHolder impl_holder = new LDKWriteableEcdsaChannelSignerHolder();
		LDKWriteableEcdsaChannelSignerImpl impl = new LDKWriteableEcdsaChannelSignerImpl(arg, impl_holder);
		EcdsaChannelSigner ecdsaChannelSigner = EcdsaChannelSigner.new_impl(ecdsaChannelSigner_impl, channelSigner_impl, pubkeys);
		ChannelSigner channelSigner = ChannelSigner.new_impl(channelSigner_impl, pubkeys);
		long[] ptr_idx = Bindings.LDKWriteableEcdsaChannelSignerNew(impl, ecdsaChannelSigner.instance_idx, channelSigner.instance_idx, pubkeys == null ? 0 : pubkeys.clone_ptr());

		impl_holder.held = new WriteableEcdsaChannelSigner(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		impl_holder.held.ptrs_to.AddLast(ecdsaChannelSigner);
		impl_holder.held.ptrs_to.AddLast(channelSigner);
		return impl_holder.held;
	}

	/**
	 * Serialize the object into a byte array
	 */
	public byte[] write() {
		long ret = Bindings.WriteableEcdsaChannelSignerWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.WriteableEcdsaChannelSignerClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of a WriteableEcdsaChannelSigner
	 */
	public WriteableEcdsaChannelSigner clone() {
		long ret = Bindings.WriteableEcdsaChannelSignerClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		WriteableEcdsaChannelSigner ret_hu_conv = new WriteableEcdsaChannelSigner(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
