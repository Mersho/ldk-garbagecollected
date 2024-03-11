
using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {



/** An implementation of Logger */
public interface ILogger {
	/**Logs the [`Record`].
	 */
	void log(Record record);
}

/**
 * A trait encapsulating the operations required of a logger.
 */
public class Logger : CommonBase {
	internal Bindings.LDKLogger bindings_instance;
	internal long instance_idx;

	internal Logger(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	~Logger() {
		if (ptr != 0) { Bindings.LoggerFree(ptr); }
	}

	private class LDKLoggerHolder { internal Logger held; }
	private class LDKLoggerImpl : Bindings.LDKLogger {
		internal LDKLoggerImpl(ILogger arg, LDKLoggerHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private ILogger arg;
		private LDKLoggerHolder impl_holder;
		public void Log(long _record) {
			org.ldk.structs.Record _record_hu_conv = null; if (_record < 0 || _record > 4096) { _record_hu_conv = new org.ldk.structs.Record(null, _record); }
			if (_record_hu_conv != null) { _record_hu_conv.ptrs_to.AddLast(this); };
			arg.log(_record_hu_conv);
				GC.KeepAlive(arg);
		}
	}

	/** Creates a new instance of Logger from a given implementation */
	public static Logger new_impl(ILogger arg) {
		LDKLoggerHolder impl_holder = new LDKLoggerHolder();
		LDKLoggerImpl impl = new LDKLoggerImpl(arg, impl_holder);
		long[] ptr_idx = Bindings.LDKLoggerNew(impl);

		impl_holder.held = new Logger(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = impl;
		return impl_holder.held;
	}

}
} } }
