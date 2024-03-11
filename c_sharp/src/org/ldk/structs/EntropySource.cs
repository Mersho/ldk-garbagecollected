
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of EntropySource */
public interface IEntropySource {
	/**Gets a unique, cryptographically-secure, random 32-byte value. This method must return a
	 * different value each time it is called.
	 */
	byte[] get_secure_random_bytes();
}

/**
 * A trait that describes a source of entropy.
 */
public class EntropySource : CommonBase {
	internal Bindings.LDKEntropySource bindings_instance;
	internal long instance_idx;

	internal EntropySource(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~EntropySource() {
		if (ptr != 0) { Bindings.EntropySourceFree(ptr); }
	}

	private class LDKEntropySourceHolder { internal EntropySource held; }
	private class LDKEntropySourceImpl : Bindings.LDKEntropySource {
		internal LDKEntropySourceImpl(IEntropySource arg, LDKEntropySourceHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private IEntropySource arg;
		private LDKEntropySourceHolder impl_holder;
		public long GetSecureRandomBytes() {
			byte[] ret = arg.get_secure_random_bytes();
				GC.KeepAlive(arg);
			long result = InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(ret, 32));
			return result;
		}
	}

	/** Creates a new instance of EntropySource from a given implementation */
	public static EntropySource new_impl(IEntropySource arg) {
		LDKEntropySourceHolder impl_holder = new LDKEntropySourceHolder();
		LDKEntropySourceImpl impl = new LDKEntropySourceImpl(arg, impl_holder);
		long[] ptr_idx = Bindings.LDKEntropySourceNew(impl);

		impl_holder.held = new EntropySource(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		return impl_holder.held;
	}

	/**
	 * Gets a unique, cryptographically-secure, random 32-byte value. This method must return a
	 * different value each time it is called.
	 */
	public byte[] get_secure_random_bytes() {
		long ret = Bindings.EntropySourceGetSecureRandomBytes(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

}
} } }
