// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 3
// Methods: 16

namespace ThirdParty.DotNet.System.Xml
{
    public class CachingEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8117B190
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class CharEntityEncoderFallback : EncoderFallback
    {
        public System.Xml.CharEntityEncoderFallbackBuffer fallbackBuffer; // 0x10
        public int[] textContentMarks; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CreateFallbackBuffer(){} // RVA: 0x7FFE8743D360
        public void get_MaxCharCount(){} // RVA: 0x7FFE835C1DE0
        public void set_StartOffset(){} // RVA: 0x7FFE817E4800
        public void Reset(){} // RVA: 0x7FFE8743D500
        public void CanReplaceAt(){} // RVA: 0x7FFE8743D570
    }

    public class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer
    {
        public System.Xml.CharEntityEncoderFallback parent; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8743D5D0
        public void Fallback(){} // RVA: 0x7FFE8743D9D0 | overloaded x2
        public void GetNextChar(){} // RVA: 0x7FFE8743DD90
        public void MovePrevious(){} // RVA: 0x7FFE8743DE00
        public void get_Remaining(){} // RVA: 0x7FFE8743DE20
        public void Reset(){} // RVA: 0x7FFE8743DE50
        public void SurrogateCharToUtf32(){} // RVA: 0x7FFE8743DE60
    }

}