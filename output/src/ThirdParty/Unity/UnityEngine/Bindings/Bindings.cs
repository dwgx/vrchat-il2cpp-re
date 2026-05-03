// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Bindings
// Classes: 18
// Methods: 53

namespace ThirdParty.Unity.UnityEngine.Bindings
{
    public class FreeFunctionAttribute : NativeMethodAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D96F60 | overloaded x3
    }

    public class IgnoreAttribute : Attribute
    {
        public bool _doesNotContributeToSize; // 0x10

        // ── Methods ──
        public void set_DoesNotContributeToSize(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NativeAsStructAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NativeConditionalAttribute : Attribute
    {
        public string _condition; // 0x10
        public string _stubReturnStatement; // 0x18
        public bool _enabled; // 0x20

        // ── Methods ──
        public void set_Condition(){} // RVA: 0x7FFE810FCE30
        public void set_StubReturnStatement(){} // RVA: 0x7FFE81161E80
        public void set_Enabled(){} // RVA: 0x7FFE811E99E0
        public void .ctor(){} // RVA: 0x7FFE87D96740 | overloaded x2
    }

    public class NativeHeaderAttribute : Attribute
    {
        public string _header; // 0x10

        // ── Methods ──
        public void set_Header(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE87D967F0 | overloaded x2
    }

    public class NativeMethodAttribute : Attribute
    {
        public string _name; // 0x10
        public bool _isThreadSafe; // 0x18
        public bool _isFreeFunction; // 0x19
        public bool _throwsException; // 0x1A
        public bool _hasExplicitThis; // 0x1B

        // ── Methods ──
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void set_IsThreadSafe(){} // RVA: 0x7FFE811164F0
        public void set_IsFreeFunction(){} // RVA: 0x7FFE81CD0510
        public void set_ThrowsException(){} // RVA: 0x7FFE8292DD10
        public void set_HasExplicitThis(){} // RVA: 0x7FFE8292DD00
        public void .ctor(){} // RVA: 0x7FFE87D96C70 | overloaded x4
    }

    public class NativeNameAttribute : Attribute
    {
        public string _name; // 0x10

        // ── Methods ──
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE87D96960
    }

    public class NativePropertyAttribute : NativeMethodAttribute
    {
        public 0x666D496C _targetType; // 0x20

        // ── Methods ──
        public void set_TargetType(){} // RVA: 0x7FFE8170B670
        public void .ctor(){} // RVA: 0x7FFE87D96D00 | overloaded x4
    }

    public class NativeThrowsAttribute : Attribute
    {
        public bool _throwsException; // 0x10

        // ── Methods ──
        public void set_ThrowsException(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE814B8390
    }

    public class NativeTypeAttribute : Attribute
    {
        public string _header; // 0x10
        public string _intermediateScriptingStructName; // 0x18
        public 0x666D4A1C _codegenOptions; // 0x20

        // ── Methods ──
        public void set_Header(){} // RVA: 0x7FFE810FCE30
        public void set_IntermediateScriptingStructName(){} // RVA: 0x7FFE81161E80
        public void set_CodegenOptions(){} // RVA: 0x7FFE8170B670
        public void .ctor(){} // RVA: 0x7FFE87D96ED0 | overloaded x4
    }

    public class NativeWritableSelfAttribute : Attribute
    {
        public bool _writableSelf; // 0x10

        // ── Methods ──
        public void set_WritableSelf(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE814B8390
    }

    public class NotNullAttribute : Attribute
    {
        public string _exception; // 0x10

        // ── Methods ──
        public void set_Exception(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class PreventReadOnlyInstanceModificationAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SpanAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84A50FB0
    }

    public class StaticAccessorAttribute : Attribute
    {
        public string _name; // 0x10
        public 0x666D4C84 _type; // 0x18

        // ── Methods ──
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void set_Type(){} // RVA: 0x7FFE8144DF00
        public void .ctor(){} // RVA: 0x7FFE82AF3A20 | overloaded x2
    }

    public class ThreadSafeAttribute : NativeMethodAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8125A2A0
    }

    public class UnmarshalledAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class VisibleToOtherModulesAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x2
    }

}