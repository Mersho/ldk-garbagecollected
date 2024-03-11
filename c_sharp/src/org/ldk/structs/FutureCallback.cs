
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of FutureCallback */
public interface IFutureCallback {
	/**The method which is called.
	 */
	void call();
}

/**
 * A callback which is called when a [`Future`] completes.
 * 
 * Note that this MUST NOT call back into LDK directly, it must instead schedule actions to be
 * taken later. Rust users should use the [`std::future::Future`] implementation for [`Future`]
 * instead.
 * 
 * Note that the [`std::future::Future`] implementation may only work for runtimes which schedule
 * futures when they receive a wake, rather than immediately executing them.
 */
public class FutureCallback : CommonBase {
	internal Bindings.LDKFutureCallback bindings_instance;
	internal long instance_idx;

	internal FutureCallback(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~FutureCallback() {
		if (ptr != 0) { Bindings.FutureCallbackFree(ptr); }
	}

	private class LDKFutureCallbackHolder { internal FutureCallback held; }
	private class LDKFutureCallbackImpl : Bindings.LDKFutureCallback {
		internal LDKFutureCallbackImpl(IFutureCallback arg, LDKFutureCallbackHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private IFutureCallback arg;
		private LDKFutureCallbackHolder impl_holder;
		public void Call() {
			arg.call();
				GC.KeepAlive(arg);
		}
	}

	/** Creates a new instance of FutureCallback from a given implementation */
	public static FutureCallback new_impl(IFutureCallback arg) {
		LDKFutureCallbackHolder impl_holder = new LDKFutureCallbackHolder();
		LDKFutureCallbackImpl impl = new LDKFutureCallbackImpl(arg, impl_holder);
		long[] ptr_idx = Bindings.LDKFutureCallbackNew(impl);

		impl_holder.held = new FutureCallback(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		return impl_holder.held;
	}

	/**
	 * The method which is called.
	 */
	public void call() {
		Bindings.FutureCallbackCall(this.ptr);
		GC.KeepAlive(this);
	}

}
} } }
