// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics.CodeAnalysis
// Classes: 21
// Methods: 57

namespace ThirdParty.DotNet.System.Diagnostics.CodeAnalysis
{
    public class AllowNullAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ConstantExpectedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DisallowNullAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DoesNotReturnAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DoesNotReturnIfAttribute : Attribute
    {
        public bool _parameterValue; // 0x10

        // ── Methods ──
        public void get_ParameterValue(){} // RVA: 0x7FFE811C55E0
        public void .ctor(){} // RVA: 0x7FFE811C55F0
    }

    public class DynamicDependencyAttribute : Attribute
    {
        public string _memberSignature; // 0x10
        public B _memberTypes; // 0x18
        public System.Type _type; // 0x20
        public string _typeName; // 0x28
        public string _assemblyName; // 0x30
        public string _condition; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F99B70 | overloaded x5
        public void get_MemberSignature(){} // RVA: 0x7FFE81116380
        public void get_MemberTypes(){} // RVA: 0x7FFE813DB630
        public void get_Type(){} // RVA: 0x7FFE811290C0
        public void get_TypeName(){} // RVA: 0x7FFE81129130
        public void get_AssemblyName(){} // RVA: 0x7FFE8144E200
        public void get_Condition(){} // RVA: 0x7FFE8143BA80
        public void set_Condition(){} // RVA: 0x7FFE81437330
    }

    public class DynamicallyAccessedMembersAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class ExcludeFromCodeCoverageAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MaybeNullAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MaybeNullWhenAttribute : Attribute
    {
        public bool _returnValue; // 0x10

        // ── Methods ──
        public void get_ReturnValue(){} // RVA: 0x7FFE811C55E0
        public void .ctor(){} // RVA: 0x7FFE811C55F0
    }

    public class MemberNotNullAttribute : Attribute
    {
        public string[] _members; // 0x10

        // ── Methods ──
        public void get_Members(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
    }

    public class MemberNotNullWhenAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866F6A90
    }

    public class NotNullAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NotNullIfNotNullAttribute : Attribute
    {
        public string _parameterName; // 0x10

        // ── Methods ──
        public void get_ParameterName(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class NotNullWhenAttribute : Attribute
    {
        public bool _returnValue; // 0x10

        // ── Methods ──
        public void get_ReturnValue(){} // RVA: 0x7FFE811C55E0
        public void .ctor(){} // RVA: 0x7FFE811C55F0
    }

    public class RequiresDynamicCodeAttribute : Attribute
    {
        public string _message; // 0x10
        public string _url; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Message(){} // RVA: 0x7FFE81116380
        public void get_Url(){} // RVA: 0x7FFE810FE7C0
        public void set_Url(){} // RVA: 0x7FFE81161E80
    }

    public class RequiresUnreferencedCodeAttribute : Attribute
    {
        public string _message; // 0x10
        public string _url; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Message(){} // RVA: 0x7FFE81116380
        public void get_Url(){} // RVA: 0x7FFE810FE7C0
        public void set_Url(){} // RVA: 0x7FFE81161E80
    }

    public class SetsRequiredMembersAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class StringSyntaxAttribute : Attribute
    {
        public string _syntax; // 0x10
        public object[] _arguments; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_Syntax(){} // RVA: 0x7FFE81116380
        public void get_Arguments(){} // RVA: 0x7FFE810FE7C0
    }

    public class UnconditionalSuppressMessageAttribute : Attribute
    {
        public string _category; // 0x10
        public string _checkId; // 0x18
        public string _scope; // 0x20
        public string _target; // 0x28
        public string _messageId; // 0x30
        public string _justification; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_Category(){} // RVA: 0x7FFE81116380
        public void get_CheckId(){} // RVA: 0x7FFE810FE7C0
        public void get_Scope(){} // RVA: 0x7FFE811290C0
        public void set_Scope(){} // RVA: 0x7FFE811290D0
        public void get_Target(){} // RVA: 0x7FFE81129130
        public void set_Target(){} // RVA: 0x7FFE810FCE90
        public void get_MessageId(){} // RVA: 0x7FFE8144E200
        public void set_MessageId(){} // RVA: 0x7FFE81129890
        public void get_Justification(){} // RVA: 0x7FFE8143BA80
        public void set_Justification(){} // RVA: 0x7FFE81437330
    }

    public class UnscopedRefAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}