using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::c_types::U128 or not
 */
public class Option_U128Z : CommonBase {
	protected Option_U128Z(object _dummy, long ptr) : base(ptr) { }
	~Option_U128Z() {
		if (ptr != 0) { Bindings.COptionU128ZFree(ptr); }
	}

	internal static Option_U128Z constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKCOptionU128ZTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new Option_U128Z_Some(ptr);
			case 1: return new Option_U128Z_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_U128Z of type Some */
	public class Option_U128Z_Some : Option_U128Z {
		public UInt128 some;
		internal Option_U128Z_Some(long ptr) : base(null, ptr) {
			long some = Bindings.LDKCOptionU128ZSomeGetSome(ptr);
			org.ldk.util.UInt128 some_conv = new org.ldk.util.UInt128(some);
			this.some = some_conv;
		}
	}
	/** A Option_U128Z of type None */
	public class Option_U128Z_None : Option_U128Z {
		internal Option_U128Z_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_U128Z containing a crate::c_types::U128
	 */
	public static Option_U128Z some(org.ldk.util.UInt128 o) {
		long ret = Bindings.COptionU128ZSome(InternalUtils.encodeUint8Array(o.getLEBytes()));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_U128Z ret_hu_conv = org.ldk.structs.Option_U128Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_U128Z containing nothing
	 */
	public static Option_U128Z none() {
		long ret = Bindings.COptionU128ZNone();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_U128Z ret_hu_conv = org.ldk.structs.Option_U128Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.COptionU128ZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_U128Z which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_U128Z clone() {
		long ret = Bindings.COptionU128ZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_U128Z ret_hu_conv = org.ldk.structs.Option_U128Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
