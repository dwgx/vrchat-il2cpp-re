// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Utf8StringInterpolation
// Classes: 4
// Methods: 76

namespace ThirdParty.Other.Utf8StringInterpolation
{
    public class Shims
    {
        // ── Methods ──
        public void TryFormat(){} // RVA: 0x750C130 | overloaded x4
    }

    public class Utf8String
    {
        // ── Methods ──
        public void CreateWriter(){} // RVA: 0x750C600
    }

    public class Utf8StringBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x100A2F0
        public void get_WrittenCount(){} // RVA: 0x750C9A0
        public void get_WrittenSpan(){} // RVA: 0x750C9F0
        public void ToString(){} // RVA: 0x750CA50
        public void Dispose(){} // RVA: 0x750CAD0
    }

    public class Utf8StringWriter`1
    {
        // ── Methods ──
        public void AppendFormatted(){} // RVA: 0x2C800 | overloaded x36
        public void AppendFormattedAlignment(){} // RVA: 0x283FA0 | overloaded x17
        public void GetBufferWriter(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x283FA0
        public void AppendLiteral(){} // RVA: 0x24B10
        public void AppendWhitespace(){} // RVA: 0x24FA0
        public void AppendUtf8(){}
        public void AppendString(){}
        public void AppendFormattedCore(){} // RVA: 0x283FA0
        public void TryGrow(){} // RVA: 0x24FA0
        public void GrowCore(){} // RVA: 0x24FA0
        public void ClearState(){} // RVA: 0x24A50
        public void GetStringByteCount(){}
        public void Flush(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

}