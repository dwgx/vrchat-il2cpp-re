// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Bindings
// Classes: 18
// Methods: 53

namespace ThirdParty.Unity.UnityEngine.Bindings
{
    public class FreeFunctionAttribute : NativeMethodAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99EE6C0 | overloaded x3
    }

    public class IgnoreAttribute : Attribute
    {
        public bool DoesNotContributeToSize; // 0x10

        // ── Methods ──
        public void set_DoesNotContributeToSize(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NativeAsStructAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NativeConditionalAttribute : Attribute
    {
        public string Condition; // 0x10
        public string StubReturnStatement; // 0x18
        public bool Enabled; // 0x20

        // ── Methods ──
        public void set_Condition(){} // RVA: 0x7FFAC2F22E30
        public void set_StubReturnStatement(){} // RVA: 0x7FFAC2F87E80
        public void set_Enabled(){} // RVA: 0x7FFAC300F9E0
        public void .ctor(){} // RVA: 0x7FFAC99EDEA0 | overloaded x2
    }

    public class NativeHeaderAttribute : Attribute
    {
        public string Header; // 0x10

        // ── Methods ──
        public void set_Header(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC99EDF50 | overloaded x2
    }

    public class NativeMethodAttribute : Attribute
    {
        public string Name; // 0x10
        public bool IsThreadSafe; // 0x18
        public bool IsFreeFunction; // 0x19
        public bool ThrowsException; // 0x1A
        public bool HasExplicitThis; // 0x1B

        // ── Methods ──
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void set_IsThreadSafe(){} // RVA: 0x7FFAC2F3C4F0
        public void set_IsFreeFunction(){} // RVA: 0x7FFAC3515120
        public void set_ThrowsException(){} // RVA: 0x7FFAC45F9AE0
        public void set_HasExplicitThis(){} // RVA: 0x7FFAC45FACF0
        public void .ctor(){} // RVA: 0x7FFAC99EE3D0 | overloaded x4
    }

    public class NativeNameAttribute : Attribute
    {
        public string Name; // 0x10

        // ── Methods ──
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC99EE0C0
    }

    public class NativePropertyAttribute : NativeMethodAttribute
    {
        public 0x6B2DA4A0 TargetType; // 0x20

        // ── Methods ──
        public void set_TargetType(){} // RVA: 0x7FFAC35DB7A0
        public void .ctor(){} // RVA: 0x7FFAC99EE460 | overloaded x4
    }

    public class NativeThrowsAttribute : Attribute
    {
        public bool ThrowsException; // 0x10

        // ── Methods ──
        public void set_ThrowsException(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC322C870
    }

    public class NativeTypeAttribute : Attribute
    {
        public string Header; // 0x10
        public string IntermediateScriptingStructName; // 0x18
        public 0x6B2DA550 CodegenOptions; // 0x20

        // ── Methods ──
        public void set_Header(){} // RVA: 0x7FFAC2F22E30
        public void set_IntermediateScriptingStructName(){} // RVA: 0x7FFAC2F87E80
        public void set_CodegenOptions(){} // RVA: 0x7FFAC35DB7A0
        public void .ctor(){} // RVA: 0x7FFAC99EE630 | overloaded x4
    }

    public class NativeWritableSelfAttribute : Attribute
    {
        public bool WritableSelf; // 0x10

        // ── Methods ──
        public void set_WritableSelf(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC322C870
    }

    public class NotNullAttribute : Attribute
    {
        public string Exception; // 0x10

        // ── Methods ──
        public void set_Exception(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class PreventReadOnlyInstanceModificationAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SpanAttribute : Attribute
    {
        public bool <IsReadOnly>k__BackingField; // 0x10
        public string <SizeParameter>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC66EC370
    }

    public class StaticAccessorAttribute : Attribute
    {
        public string Name; // 0x10
        public 0x6B2DA7B8 Type; // 0x18

        // ── Methods ──
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void set_Type(){} // RVA: 0x7FFAC392CD10
        public void .ctor(){} // RVA: 0x7FFAC488C310 | overloaded x2
    }

    public class ThreadSafeAttribute : NativeMethodAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC30802A0
    }

    public class UnmarshalledAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class VisibleToOtherModulesAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x2
    }

}