// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 3
// Methods: 15

namespace ThirdParty.DotNet.System.Xml
{
    public class CachingEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81577F0
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class CharEntityEncoderFallback : EncoderFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void CreateFallbackBuffer(){} // RVA: 0x7AE6ECB70
        public void get_MaxCharCount(){} // RVA: 0x7A9F22B10
        public void set_StartOffset(){} // RVA: 0x7A8810F60
        public void Reset(){} // RVA: 0x7AE6ECD10
        public void CanReplaceAt(){} // RVA: 0x7AE6ECD80
    }

    public class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6ECDE0
        public void Fallback(){} // RVA: 0x7AE6ED1F0
        public void GetNextChar(){} // RVA: 0x7AE6ED5B0
        public void MovePrevious(){} // RVA: 0x7AE6ED620
        public void get_Remaining(){} // RVA: 0x7AE6ED640
        public void Reset(){} // RVA: 0x7AE6ED670
        public void SurrogateCharToUtf32(){} // RVA: 0x7AE6ED680
    }

}