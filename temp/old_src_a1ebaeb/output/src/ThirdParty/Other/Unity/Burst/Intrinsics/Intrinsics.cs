// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Burst.Intrinsics
// Classes: 10
// Methods: 25

namespace ThirdParty.Other.Unity.Burst.Intrinsics
{
    public class Common : Object
    {
        // ── Original Methods ──
        public void umul128(){} // RVA: 0x7ffaaef2ebc0
    }

    public class DoGetCSRTrampoline_0000012A$BurstDirectCall : Object
    {
        // ── Original Methods ──
        public void Constructor(){} // RVA: 0x7ffaaef2fff0
        public void Initialize(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaef2fff0
        public void Invoke(){} // RVA: 0x7ffaaef300b0
        // ── Binary Analysis Named ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7ffaaef2fd40
        public void GetFunctionPointer(){} // RVA: 0x7ffaaef2fe80
    }

    public class DoGetCSRTrampoline_0000012A$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaaf72450
        public void Invoke(){} // RVA: 0x7ffaa8990a50
    }

    public class DoSetCSRTrampoline_00000129$BurstDirectCall : Object
    {
        // ── Original Methods ──
        public void Constructor(){} // RVA: 0x7ffaaef2fa90
        public void Initialize(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaef2fa90
        public void Invoke(){} // RVA: 0x7ffaaef2fb50
        // ── Binary Analysis Named ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7ffaaef2f7e0
        public void GetFunctionPointer(){} // RVA: 0x7ffaaef2f920
    }

    public class DoSetCSRTrampoline_00000129$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8a23370
        public void Invoke(){} // RVA: 0x7ffaa898dc60
    }

    public class V64DebugView : Object
    {
    }

    public class X86 : Object
    {
        // ── Original Methods ──
        public void BurstIntrinsicSetCSRFromManaged(){} // RVA: 0x7ffaa8932310
        public void BurstIntrinsicGetCSRFromManaged(){} // RVA: 0x7ffaa8f22da0
        // ── Binary Analysis Named ──
        public void DoSetCSRTrampoline(){} // RVA: 0x7ffaaef2ec50
        public void DoGetCSRTrampoline(){} // RVA: 0x7ffaaef2ee70
        public void DoSetCSRTrampoline$BurstManaged(){} // RVA: 0x7ffaa94a7020
        public void DoGetCSRTrampoline$BurstManaged(){} // RVA: 0x7ffaac13e3c0
    }

    public class v128 : ValueType
    {
        public object Byte2; // 0x33BECB80
        public object Byte5; // 0x33BECB80
        public object Byte8; // 0x33BECB80
        public object Byte11; // 0x33BECB80
        public object Byte14; // 0x33BECB80
        public object SByte1; // 0x33BECB80
        public object SByte4; // 0x33BECB80
        public object SByte7; // 0x33BECB80
        public object SByte10; // 0x33BECB80
        public object SByte13; // 0x33BECB80
        public object UShort0; // 0x33BECB80
        public object UShort3; // 0x33BECB80
        public object UShort6; // 0x33BECB80
        public object SShort1; // 0x33BECB80
        public object SShort4; // 0x33BECB80
        public object SShort7; // 0x33BECB80
        public object UInt2; // 0x33BECB80
        public object SInt1; // 0x33BECB80
        public object ULong0; // 0x33BECB80
        public object SLong1; // 0x33BECB80
        public object Float2; // 0x33BECB80
        public object Double1; // 0x33BECB80
        public object Byte0; // 0x3397CAB0
        public object Byte3; // 0x3397CAB0
        public object Byte6; // 0x3397CAB0
        public object SByte1; // 0x3397CAB0
        public object SByte4; // 0x3397CAB0
        public object SByte7; // 0x3397CAB0
        public object UShort2; // 0x3397CAB0
        public object SShort1; // 0x3397CAB0
        public object UInt0; // 0x3397CAB0
        public object SInt1; // 0x3397CAB0
        public object Float0; // 0x3397CAB0
    }

    public class v256 : ValueType
    {
        public object Byte2; // 0x33A6D720
        public object Byte5; // 0x33A6D720
        public object Byte8; // 0x33A6D720
        public object Byte11; // 0x33A6D720
        public object Byte14; // 0x33A6D720
        public object Byte17; // 0x33A6D720
        public object Byte20; // 0x33A6D720
        public object Byte23; // 0x33A6D720
        public object Byte26; // 0x33A6D720
        public object Byte29; // 0x33A6D720
        public object SByte0; // 0x33A6D720
        public object SByte3; // 0x33A6D720
        public object SByte6; // 0x33A6D720
        public object SByte9; // 0x33A6D720
        public object SByte12; // 0x33A6D720
        public object SByte15; // 0x33A6D720
        public object SByte18; // 0x33A6D720
        public object SByte21; // 0x33A6D720
        public object SByte24; // 0x33A6D720
        public object SByte27; // 0x33A6D720
        public object SByte30; // 0x33A6D720
        public object UShort1; // 0x33A6D720
        public object UShort4; // 0x33A6D720
        public object UShort7; // 0x33A6D720
        public object UShort10; // 0x33A6D720
        public object UShort13; // 0x33A6D720
        public object SShort0; // 0x33A6D720
        public object SShort3; // 0x33A6D720
        public object SShort6; // 0x33A6D720
        public object SShort9; // 0x33A6D720
        public object SShort12; // 0x33A6D720
        public object SShort15; // 0x33A6D720
        public object UInt2; // 0x33A6D720
        public object UInt5; // 0x33A6D720
        public object SInt0; // 0x33A6D720
        public object SInt3; // 0x33A6D720
        public object SInt6; // 0x33A6D720
        public object ULong1; // 0x33A6D720
        public object SLong0; // 0x33A6D720
        public object SLong3; // 0x33A6D720
        public object Float2; // 0x33A6D720
        public object Float5; // 0x33A6D720
        public object Double0; // 0x33A6D720
        public object Double3; // 0x33A6D720
        public object mm256_load_ps; // 0xB40E4240
        public object mm256_srli_epi64; // 0xB40E4240
        public object `Ǐf; // 0x3024EA20
        public object `Ǐf; // 0x3024EA20
        public object add_epi64; // 0xB40E42E0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa385d10
        public void .ctor(){} // RVA: 0x7ffaaa385d10
    }

    public class v64 : ValueType
    {
        public object Byte2; // 0x3397CAB0
        public object Byte5; // 0x3397CAB0
        public object SByte0; // 0x3397CAB0
        public object SByte3; // 0x3397CAB0
        public object SByte6; // 0x3397CAB0
        public object UShort1; // 0x3397CAB0
        public object SShort0; // 0x3397CAB0
        public object SShort3; // 0x3397CAB0
        public object SInt0; // 0x3397CAB0
        public object SLong0; // 0x3397CAB0
        public object Double0; // 0x3397CAB0
        public object .ctor; // 0xB3F6FFF0
    }

}