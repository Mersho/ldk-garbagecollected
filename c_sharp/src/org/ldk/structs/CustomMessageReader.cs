
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of CustomMessageReader */
public interface ICustomMessageReader {
	/**Decodes a custom message to `CustomMessageType`. If the given message type is known to the
	 * implementation and the message could be decoded, must return `Ok(Some(message))`. If the
	 * message type is unknown to the implementation, must return `Ok(None)`. If a decoding error
	 * occur, must return `Err(DecodeError::X)` where `X` details the encountered error.
	 */
	Result_COption_TypeZDecodeErrorZ read(short message_type, byte[] buffer);
}

/**
 * Trait to be implemented by custom message (unrelated to the channel/gossip LN layers)
 * decoders.
 */
public class CustomMessageReader : CommonBase {
	internal Bindings.LDKCustomMessageReader bindings_instance;
	internal long instance_idx;

	internal CustomMessageReader(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~CustomMessageReader() {
		if (ptr != 0) { Bindings.CustomMessageReaderFree(ptr); }
	}

	private class LDKCustomMessageReaderHolder { internal CustomMessageReader held; }
	private class LDKCustomMessageReaderImpl : Bindings.LDKCustomMessageReader {
		internal LDKCustomMessageReaderImpl(ICustomMessageReader arg, LDKCustomMessageReaderHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private ICustomMessageReader arg;
		private LDKCustomMessageReaderHolder impl_holder;
		public long Read(short _message_type, long _buffer) {
			byte[] _buffer_conv = InternalUtils.decodeUint8Array(_buffer);
			Result_COption_TypeZDecodeErrorZ ret = arg.read(_message_type, _buffer_conv);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
	}

	/** Creates a new instance of CustomMessageReader from a given implementation */
	public static CustomMessageReader new_impl(ICustomMessageReader arg) {
		LDKCustomMessageReaderHolder impl_holder = new LDKCustomMessageReaderHolder();
		LDKCustomMessageReaderImpl impl = new LDKCustomMessageReaderImpl(arg, impl_holder);
		long[] ptr_idx = Bindings.LDKCustomMessageReaderNew(impl);

		impl_holder.held = new CustomMessageReader(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		return impl_holder.held;
	}

	/**
	 * Decodes a custom message to `CustomMessageType`. If the given message type is known to the
	 * implementation and the message could be decoded, must return `Ok(Some(message))`. If the
	 * message type is unknown to the implementation, must return `Ok(None)`. If a decoding error
	 * occur, must return `Err(DecodeError::X)` where `X` details the encountered error.
	 */
	public Result_COption_TypeZDecodeErrorZ read(short message_type, byte[] buffer) {
		long ret = Bindings.CustomMessageReaderRead(this.ptr, message_type, InternalUtils.encodeUint8Array(buffer));
		GC.KeepAlive(this);
		GC.KeepAlive(message_type);
		GC.KeepAlive(buffer);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_COption_TypeZDecodeErrorZ ret_hu_conv = Result_COption_TypeZDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
