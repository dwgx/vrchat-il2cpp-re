// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Burst.Intrinsics
// Classes: 13
// Methods: 25

namespace ThirdParty.Other.Unity.Burst.Intrinsics
{
    public class BurstTargetCpuAttribute : Attribute
    {
    }

    public class Common : Object
    {
        // ── Methods ──
        public void umul128(){} // RVA: 0x7FFE878B5330
    }

    public class DoGetCSRTrampoline_0000012A$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFE878B64B0
        public void GetFunctionPointer(){} // RVA: 0x7FFE878B65F0
        public void Constructor(){} // RVA: 0x7FFE878B6760
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE878B6760
        public void Invoke(){} // RVA: 0x7FFE878B6820
    }

    public class DoGetCSRTrampoline_0000012A$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83871300
        public void Invoke(){} // RVA: 0x7FFE81159A50
    }

    public class DoSetCSRTrampoline_00000129$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFE878B5F50
        public void GetFunctionPointer(){} // RVA: 0x7FFE878B6090
        public void Constructor(){} // RVA: 0x7FFE878B6200
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE878B6200
        public void Invoke(){} // RVA: 0x7FFE878B62C0
    }

    public class DoSetCSRTrampoline_00000129$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811EC370
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class V128DebugView : Object
    {
    }

    public class V256DebugView : Object
    {
    }

    public class V64DebugView : Object
    {
    }

    public class X86 : Object
    {
        // ── Methods ──
        public void BurstIntrinsicSetCSRFromManaged(){} // RVA: 0x7FFE810FB310
        public void BurstIntrinsicGetCSRFromManaged(){} // RVA: 0x7FFE813240E0
        public void DoSetCSRTrampoline(){} // RVA: 0x7FFE878B53C0
        public void DoGetCSRTrampoline(){} // RVA: 0x7FFE878B55E0
        public void DoSetCSRTrampoline$BurstManaged(){} // RVA: 0x7FFE81D95990
        public void DoGetCSRTrampoline$BurstManaged(){} // RVA: 0x7FFE84A912C0
    }

    public class v128 : ValueType
    {
    }

    public class v256 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BE9D90 | overloaded x2
    }

    public class v64 : ValueType
    {
    }

}