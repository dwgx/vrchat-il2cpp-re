// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 3
// Methods: 16

namespace ThirdParty.DotNet.System.Xml
{
    public class CachingEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FA1190
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class CharEntityEncoderFallback : EncoderFallback
    {
        public System.Xml.CharEntityEncoderFallbackBuffer MaxCharCount; // 0x10
        public int[] StartOffset; // 0x18
        public int endMarkPos; // 0x20
        public int curMarkPos; // 0x24
        public int startOffset; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAC9094BB0
        public void get_MaxCharCount(){} // RVA: 0x7FFAC530B5A0
        public void set_StartOffset(){} // RVA: 0x7FFAC369A6E0
        public void Reset(){} // RVA: 0x7FFAC9094D50
        public void CanReplaceAt(){} // RVA: 0x7FFAC9094DC0
    }

    public class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer
    {
        public System.Xml.CharEntityEncoderFallback Remaining; // 0x30
        public string charEntity; // 0x38
        public int charEntityIndex; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9094E20
        public void Fallback(){} // RVA: 0x7FFAC9095220 | overloaded x2
        public void GetNextChar(){} // RVA: 0x7FFAC90955E0
        public void MovePrevious(){} // RVA: 0x7FFAC9095650
        public void get_Remaining(){} // RVA: 0x7FFAC9095670
        public void Reset(){} // RVA: 0x7FFAC90956A0
        public void SurrogateCharToUtf32(){} // RVA: 0x7FFAC90956B0
    }

}