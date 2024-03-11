using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::c_types::derived::C2Tuple__u1632_u1632Z or not
 */
public class Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ : CommonBase {
	protected Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ(object _dummy, long ptr) : base(ptr) { }
	~Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ() {
		if (ptr != 0) { Bindings.COptionC2TupleThirtyTwoU16sThirtyTwoU16sZZFree(ptr); }
	}

	internal static Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKCOptionC2TupleThirtyTwoU16sThirtyTwoU16sZZTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ_Some(ptr);
			case 1: return new Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ of type Some */
	public class Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ_Some : Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ {
		public TwoTuple__u1632_u1632Z some;
		internal Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ_Some(long ptr) : base(null, ptr) {
			long some = Bindings.LDKCOptionC2TupleThirtyTwoU16sThirtyTwoU16sZZSomeGetSome(ptr);
			TwoTuple__u1632_u1632Z some_hu_conv = new TwoTuple__u1632_u1632Z(null, some);
			if (some_hu_conv != null) { some_hu_conv.ptrs_to.AddLast(this); };
			this.some = some_hu_conv;
		}
	}
	/** A Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ of type None */
	public class Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ_None : Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ {
		internal Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ containing a crate::c_types::derived::C2Tuple__u1632_u1632Z
	 */
	public static Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ some(org.ldk.structs.TwoTuple__u1632_u1632Z o) {
		long ret = Bindings.COptionC2TupleThirtyTwoU16sThirtyTwoU16sZZSome(o != null ? o.ptr : 0);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ ret_hu_conv = org.ldk.structs.Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ containing nothing
	 */
	public static Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ none() {
		long ret = Bindings.COptionC2TupleThirtyTwoU16sThirtyTwoU16sZZNone();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ ret_hu_conv = org.ldk.structs.Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
