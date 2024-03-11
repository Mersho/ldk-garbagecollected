using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::c_types::TxOut or not
 */
public class Option_TxOutZ : CommonBase {
	protected Option_TxOutZ(object _dummy, long ptr) : base(ptr) { }
	~Option_TxOutZ() {
		if (ptr != 0) { Bindings.COptionTxOutZFree(ptr); }
	}

	internal static Option_TxOutZ constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKCOptionTxOutZTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new Option_TxOutZ_Some(ptr);
			case 1: return new Option_TxOutZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_TxOutZ of type Some */
	public class Option_TxOutZ_Some : Option_TxOutZ {
		public TxOut some;
		internal Option_TxOutZ_Some(long ptr) : base(null, ptr) {
			long some = Bindings.LDKCOptionTxOutZSomeGetSome(ptr);
			TxOut some_conv = new TxOut(null, some);
			this.some = some_conv;
		}
	}
	/** A Option_TxOutZ of type None */
	public class Option_TxOutZ_None : Option_TxOutZ {
		internal Option_TxOutZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_TxOutZ containing a crate::c_types::TxOut
	 */
	public static Option_TxOutZ some(org.ldk.structs.TxOut o) {
		long ret = Bindings.COptionTxOutZSome(o.ptr);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_TxOutZ ret_hu_conv = org.ldk.structs.Option_TxOutZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_TxOutZ containing nothing
	 */
	public static Option_TxOutZ none() {
		long ret = Bindings.COptionTxOutZNone();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_TxOutZ ret_hu_conv = org.ldk.structs.Option_TxOutZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.COptionTxOutZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_TxOutZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_TxOutZ clone() {
		long ret = Bindings.COptionTxOutZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_TxOutZ ret_hu_conv = org.ldk.structs.Option_TxOutZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
