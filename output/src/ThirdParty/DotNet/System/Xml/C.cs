// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 3
// Methods: 15

namespace ThirdParty.DotNet.System.Xml
{
    public class CachingEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class CharEntityEncoderFallback : EncoderFallback
    {
        public object fallbackBuffer;
        public object textContentMarks;
        public object endMarkPos;
        public object curMarkPos;
        public object startOffset;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CreateFallbackBuffer(){} // RVA: 0x73629F0
        public void get_MaxCharCount(){} // RVA: 0x2AFB6E0
        public void set_StartOffset(){} // RVA: 0x13233D0
        public void Reset(){} // RVA: 0x7362B60
        public void CanReplaceAt(){} // RVA: 0x7362BD0
    }

    public class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer
    {
        public object parent;
        public object charEntity;
        public object charEntityIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7362C30
        public void Fallback(){} // RVA: 0x7362FF0
        public void GetNextChar(){} // RVA: 0x7363390
        public void MovePrevious(){} // RVA: 0x7363400
        public void get_Remaining(){} // RVA: 0x7363420
        public void Reset(){} // RVA: 0x7363450
        public void SurrogateCharToUtf32(){} // RVA: 0x7363460
    }

}