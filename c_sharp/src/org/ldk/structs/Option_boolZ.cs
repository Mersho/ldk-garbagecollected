using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a bool or not
 */
public class Option_boolZ : CommonBase {
	protected Option_boolZ(object _dummy, long ptr) : base(ptr) { }
	~Option_boolZ() {
		if (ptr != 0) { Bindings.COptionBoolzFree(ptr); }
	}

	internal static Option_boolZ constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKCOptionBoolzTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new Option_boolZ_Some(ptr);
			case 1: return new Option_boolZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_boolZ of type Some */
	public class Option_boolZ_Some : Option_boolZ {
		public bool some;
		internal Option_boolZ_Some(long ptr) : base(null, ptr) {
			this.some = Bindings.LDKCOptionBoolzSomeGetSome(ptr);
		}
	}
	/** A Option_boolZ of type None */
	public class Option_boolZ_None : Option_boolZ {
		internal Option_boolZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_boolZ containing a bool
	 */
	public static Option_boolZ some(bool o) {
		long ret = Bindings.COptionBoolzSome(o);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_boolZ ret_hu_conv = org.ldk.structs.Option_boolZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_boolZ containing nothing
	 */
	public static Option_boolZ none() {
		long ret = Bindings.COptionBoolzNone();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_boolZ ret_hu_conv = org.ldk.structs.Option_boolZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.COptionBoolzClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_boolZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_boolZ clone() {
		long ret = Bindings.COptionBoolzClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_boolZ ret_hu_conv = org.ldk.structs.Option_boolZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
