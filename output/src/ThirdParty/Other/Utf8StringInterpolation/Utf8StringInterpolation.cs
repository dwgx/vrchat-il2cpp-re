// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Utf8StringInterpolation
// Classes: 4
// Methods: 76

namespace ThirdParty.Other.Utf8StringInterpolation
{
    public class Shims : Object
    {
        // ── Methods ──
        public void TryFormat(){} // RVA: 0x7FFAC9CA3AB0 | overloaded x4
    }

    public class Utf8String : Object
    {
        // ── Methods ──
        public void CreateWriter(){} // RVA: 0x7FFAC9CA3F80
    }

    public class Utf8StringBuffer : ValueType
    {
        public System.Buffers.ArrayBufferWriter`1<byte> WrittenCount; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void get_WrittenCount(){} // RVA: 0x7FFAC9CA4320
        public void get_WrittenSpan(){} // RVA: 0x7FFAC9CA4370
        public void ToString(){} // RVA: 0x7FFAC9CA43D0
        public void Dispose(){} // RVA: 0x7FFAC9CA4450
    }

    public class Utf8StringWriter`1 : ValueType
    {
        public byte[] NewLineUtf8Bytes;
        public System.Span`1<byte> destination;
        public int allocatedDestinationSize;
        public T bufferWriter;
        public int currentWritten;
        public System.IFormatProvider formatProvider;
        public bool calculateStringJustSize;

        // ── Methods ──
        public void AppendFormatted(){} // RVA: 0x7FFAC2C786D0 | overloaded x36
        public void AppendFormattedAlignment(){} // RVA: 0x7FFAC2E8DC40 | overloaded x17
        public void GetBufferWriter(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void AppendLiteral(){} // RVA: 0x7FFAC2C70A40
        public void AppendWhitespace(){} // RVA: 0x7FFAC2C70ED0
        public void AppendUtf8(){}
        public void AppendString(){}
        public void AppendFormattedCore(){} // RVA: 0x7FFAC2E8DC40
        public void TryGrow(){} // RVA: 0x7FFAC2C70ED0
        public void GrowCore(){} // RVA: 0x7FFAC2C70ED0
        public void ClearState(){} // RVA: 0x7FFAC2C70980
        public void GetStringByteCount(){}
        public void Flush(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

}