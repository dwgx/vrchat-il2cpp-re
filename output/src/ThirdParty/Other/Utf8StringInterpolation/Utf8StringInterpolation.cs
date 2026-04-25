// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Utf8StringInterpolation
// Classes: 2
// Methods: 70

namespace ThirdParty.Other.Utf8StringInterpolation
{
    public class Shims : Object
    {
        // ── Methods ──
        public void TryFormat(){} // RVA: 0x7FFD550C3AB0 | overloaded x4
    }

    public class Utf8StringWriter`1 : ValueType
    {
        public byte[] NewLineUtf8Bytes;
        public System.Span`1<byte> destination; // 0x10
        public int allocatedDestinationSize; // 0x20
        public System.Buffers.ArrayBufferWriter`1<byte> bufferWriter; // 0x28
        public int currentWritten; // 0x30
        public System.IFormatProvider formatProvider; // 0x38
        public bool calculateStringJustSize; // 0x40

        // ── Methods ──
        public void AppendFormatted(){} // RVA: 0x7FFD4E0986D0 | overloaded x36
        public void AppendFormattedAlignment(){} // RVA: 0x7FFD4E2ADC40 | overloaded x17
        public void GetBufferWriter(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void AppendLiteral(){} // RVA: 0x7FFD4E090A40
        public void AppendWhitespace(){} // RVA: 0x7FFD4E090ED0
        public void AppendUtf8(){}
        public void AppendString(){}
        public void AppendFormattedCore(){} // RVA: 0x7FFD4E2ADC40
        public void TryGrow(){} // RVA: 0x7FFD4E090ED0
        public void GrowCore(){} // RVA: 0x7FFD4E090ED0
        public void ClearState(){} // RVA: 0x7FFD4E090980
        public void GetStringByteCount(){}
        public void Flush(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

}