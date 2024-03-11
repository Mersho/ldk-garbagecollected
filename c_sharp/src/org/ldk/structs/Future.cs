using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A simple future which can complete once, and calls some callback(s) when it does so.
 * 
 * Clones can be made and all futures cloned from the same source will complete at the same time.
 */
public class Future : CommonBase {
	internal Future(object _dummy, long ptr) : base(ptr) { }
	~Future() {
		if (ptr != 0) { Bindings.FutureFree(ptr); }
	}

	internal long clone_ptr() {
		long ret = Bindings.FutureClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the Future
	 */
	public Future clone() {
		long ret = Bindings.FutureClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Future ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Future(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Registers a callback to be called upon completion of this future. If the future has already
	 * completed, the callback will be called immediately.
	 */
	public void register_callback_fn(org.ldk.structs.FutureCallback callback) {
		Bindings.FutureRegisterCallbackFn(this.ptr, callback.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(callback);
		if (this != null) { this.ptrs_to.AddLast(callback); };
	}

	/**
	 * Waits until this [`Future`] completes.
	 */
	public void wait() {
		Bindings.FutureWait(this.ptr);
		GC.KeepAlive(this);
		if (this != null) { this.ptrs_to.AddLast(this); };
	}

	/**
	 * Waits until this [`Future`] completes or the given amount of time has elapsed.
	 * 
	 * Returns true if the [`Future`] completed, false if the time elapsed.
	 */
	public bool wait_timeout(long max_wait) {
		bool ret = Bindings.FutureWaitTimeout(this.ptr, max_wait);
		GC.KeepAlive(this);
		GC.KeepAlive(max_wait);
		if (this != null) { this.ptrs_to.AddLast(this); };
		return ret;
	}

}
} } }
