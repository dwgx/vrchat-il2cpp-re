// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Utf8StringInterpolation
// Classes: 4
// Methods: 76

namespace ThirdParty.Other.Utf8StringInterpolation
{
    public class Shims : Object
    {
        // ── Methods ──
        public void TryFormat(){} // RVA: 0x7FFE8804C300 | overloaded x4
    }

    public class Utf8String : Object
    {
        // ── Methods ──
        public void CreateWriter(){} // RVA: 0x7FFE8804C7D0
    }

    public class Utf8StringBuffer : ValueType
    {
        public System.Buffers.ArrayBufferWriter`1<byte> innerBuffer; // 0x10
        public object field_1; // 0x1

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
        public void get_WrittenCount(){} // RVA: 0x7FFE8804CB70
        public void get_WrittenSpan(){} // RVA: 0x7FFE8804CBC0
        public void ToString(){} // RVA: 0x7FFE8804CC20
        public void Dispose(){} // RVA: 0x7FFE8804CCA0
    }

    public class Utf8StringWriter`1 : ValueType
    {
        // ── Methods ──
        public void AppendFormatted(){} // RVA: 0x7FFE80E4DDD0 | overloaded x36
        public void AppendFormattedAlignment(){} // RVA: 0x7FFE810A1420 | overloaded x17
        public void GetBufferWriter(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void AppendLiteral(){} // RVA: 0x7FFE80E460A0
        public void AppendWhitespace(){} // RVA: 0x7FFE80E46530
        public void AppendUtf8(){}
        public void AppendString(){}
        public void AppendFormattedCore(){} // RVA: 0x7FFE810A1420
        public void TryGrow(){} // RVA: 0x7FFE80E46530
        public void GrowCore(){} // RVA: 0x7FFE80E46530
        public void ClearState(){} // RVA: 0x7FFE80E45FE0
        public void GetStringByteCount(){}
        public void Flush(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

}