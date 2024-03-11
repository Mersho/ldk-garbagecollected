using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a u16 or not
 */
public class Option_u16Z : CommonBase {
	protected Option_u16Z(object _dummy, long ptr) : base(ptr) { }
	~Option_u16Z() {
		if (ptr != 0) { Bindings.COptionU16ZFree(ptr); }
	}

	internal static Option_u16Z constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKCOptionU16ZTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new Option_u16Z_Some(ptr);
			case 1: return new Option_u16Z_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_u16Z of type Some */
	public class Option_u16Z_Some : Option_u16Z {
		public short some;
		internal Option_u16Z_Some(long ptr) : base(null, ptr) {
			this.some = Bindings.LDKCOptionU16ZSomeGetSome(ptr);
		}
	}
	/** A Option_u16Z of type None */
	public class Option_u16Z_None : Option_u16Z {
		internal Option_u16Z_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_u16Z containing a u16
	 */
	public static Option_u16Z some(short o) {
		long ret = Bindings.COptionU16ZSome(o);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u16Z ret_hu_conv = org.ldk.structs.Option_u16Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_u16Z containing nothing
	 */
	public static Option_u16Z none() {
		long ret = Bindings.COptionU16ZNone();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u16Z ret_hu_conv = org.ldk.structs.Option_u16Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.COptionU16ZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_u16Z which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_u16Z clone() {
		long ret = Bindings.COptionU16ZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u16Z ret_hu_conv = org.ldk.structs.Option_u16Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
