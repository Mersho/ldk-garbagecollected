using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::lightning::ln::wire::Type or not
 */
public class Option_TypeZ : CommonBase {
	protected Option_TypeZ(object _dummy, long ptr) : base(ptr) { }
	~Option_TypeZ() {
		if (ptr != 0) { Bindings.COptionTypeZFree(ptr); }
	}

	internal static Option_TypeZ constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKCOptionTypeZTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new Option_TypeZ_Some(ptr);
			case 1: return new Option_TypeZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_TypeZ of type Some */
	public class Option_TypeZ_Some : Option_TypeZ {
		public Type some;
		internal Option_TypeZ_Some(long ptr) : base(null, ptr) {
			long some = Bindings.LDKCOptionTypeZSomeGetSome(ptr);
			Type ret_hu_conv = new Type(null, some);
			if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
			this.some = ret_hu_conv;
		}
	}
	/** A Option_TypeZ of type None */
	public class Option_TypeZ_None : Option_TypeZ {
		internal Option_TypeZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_TypeZ containing a crate::lightning::ln::wire::Type
	 */
	public static Option_TypeZ some(org.ldk.structs.Type o) {
		long ret = Bindings.COptionTypeZSome(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_TypeZ ret_hu_conv = org.ldk.structs.Option_TypeZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(o); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_TypeZ containing nothing
	 */
	public static Option_TypeZ none() {
		long ret = Bindings.COptionTypeZNone();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_TypeZ ret_hu_conv = org.ldk.structs.Option_TypeZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.COptionTypeZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_TypeZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_TypeZ clone() {
		long ret = Bindings.COptionTypeZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_TypeZ ret_hu_conv = org.ldk.structs.Option_TypeZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
