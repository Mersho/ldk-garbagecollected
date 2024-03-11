using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class BigEndianScalar : CommonBase {
	/** The bytes of the scalar value, in big endian */
	public readonly byte[] scalar_bytes;

    internal BigEndianScalar(object _dummy, long ptr) : base(ptr) {
		this.scalar_bytes = InternalUtils.decodeUint8Array(Bindings.BigEndianScalarGetBytes(ptr));
	}
    public BigEndianScalar(byte[] scalar_bytes) : base(Bindings.BigEndianScalarNew(InternalUtils.encodeUint8Array(scalar_bytes))) {
		this.scalar_bytes = InternalUtils.decodeUint8Array(Bindings.BigEndianScalarGetBytes(ptr));
	}

	~BigEndianScalar() {
		if (ptr != 0) { Bindings.BigEndianScalarFree(ptr); }
	}
}} } }
