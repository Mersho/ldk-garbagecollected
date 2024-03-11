using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a u64 or not
 */
public class Option_u64Z : CommonBase {
	protected Option_u64Z(object _dummy, long ptr) : base(ptr) { }
	~Option_u64Z() {
		if (ptr != 0) { Bindings.COptionU64ZFree(ptr); }
	}

	internal static Option_u64Z constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKCOptionU64ZTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new Option_u64Z_Some(ptr);
			case 1: return new Option_u64Z_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_u64Z of type Some */
	public class Option_u64Z_Some : Option_u64Z {
		public long some;
		internal Option_u64Z_Some(long ptr) : base(null, ptr) {
			this.some = Bindings.LDKCOptionU64ZSomeGetSome(ptr);
		}
	}
	/** A Option_u64Z of type None */
	public class Option_u64Z_None : Option_u64Z {
		internal Option_u64Z_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_u64Z containing a u64
	 */
	public static Option_u64Z some(long o) {
		long ret = Bindings.COptionU64ZSome(o);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_u64Z containing nothing
	 */
	public static Option_u64Z none() {
		long ret = Bindings.COptionU64ZNone();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.COptionU64ZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_u64Z which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_u64Z clone() {
		long ret = Bindings.COptionU64ZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
