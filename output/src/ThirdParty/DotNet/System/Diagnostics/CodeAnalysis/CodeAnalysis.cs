// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics.CodeAnalysis
// Classes: 21
// Methods: 51

namespace ThirdParty.DotNet.System.Diagnostics.CodeAnalysis
{
    public class AllowNullAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ConstantExpectedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DisallowNullAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DoesNotReturnAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DoesNotReturnIfAttribute : Attribute
    {
        public bool ParameterValue; // 0x10

        // ── Methods ──
        public void get_ParameterValue(){} // RVA: 0x7FFAC2FEB5E0
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
    }

    public class DynamicDependencyAttribute : Attribute
    {
        public string MemberSignature; // 0x10
        public 0x6B1A1F88 MemberTypes; // 0x18
        public System.Type Type; // 0x20
        public string TypeName; // 0x28
        public string AssemblyName; // 0x30
        public string Condition; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BF0510 | overloaded x5
        public void get_MemberSignature(){} // RVA: 0x7FFAC2F3C380
        public void get_MemberTypes(){} // RVA: 0x7FFAC3157800
        public void get_Type(){} // RVA: 0x7FFAC2F4F0C0
        public void get_TypeName(){} // RVA: 0x7FFAC2F4F130
        public void get_AssemblyName(){} // RVA: 0x7FFAC31D95E0
        public void get_Condition(){} // RVA: 0x7FFAC31D0140
        public void set_Condition(){} // RVA: 0x7FFAC31D0C20
    }

    public class DynamicallyAccessedMembersAttribute : Attribute
    {
        public 0x6B22D518 <MemberTypes>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class ExcludeFromCodeCoverageAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MaybeNullAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MaybeNullWhenAttribute : Attribute
    {
        public bool ReturnValue; // 0x10

        // ── Methods ──
        public void get_ReturnValue(){} // RVA: 0x7FFAC2FEB5E0
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
    }

    public class MemberNotNullAttribute : Attribute
    {
        public string[] Members; // 0x10

        // ── Methods ──
        public void get_Members(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
    }

    public class MemberNotNullWhenAttribute : Attribute
    {
        public bool ReturnValue; // 0x10
        public string[] Members; // 0x18

        // ── Methods ──
        public void get_ReturnValue(){} // RVA: 0x7FFAC2FEB5E0
        public void get_Members(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC833CCF0 | overloaded x2
    }

    public class NotNullAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NotNullIfNotNullAttribute : Attribute
    {
        public string ParameterName; // 0x10

        // ── Methods ──
        public void get_ParameterName(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class NotNullWhenAttribute : Attribute
    {
        public bool ReturnValue; // 0x10

        // ── Methods ──
        public void get_ReturnValue(){} // RVA: 0x7FFAC2FEB5E0
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
    }

    public class RequiresDynamicCodeAttribute : Attribute
    {
        public string Message; // 0x10
        public string Url; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Message(){} // RVA: 0x7FFAC2F3C380
        public void get_Url(){} // RVA: 0x7FFAC2F247C0
        public void set_Url(){} // RVA: 0x7FFAC2F87E80
    }

    public class RequiresUnreferencedCodeAttribute : Attribute
    {
        public string Message; // 0x10
        public string Url; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Message(){} // RVA: 0x7FFAC2F3C380
        public void get_Url(){} // RVA: 0x7FFAC2F247C0
        public void set_Url(){} // RVA: 0x7FFAC2F87E80
    }

    public class SetsRequiredMembersAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StringSyntaxAttribute : Attribute
    {
        public string Syntax; // 0x10
        public object[] Arguments; // 0x18
        public string CompositeFormat;
        public string DateOnlyFormat;
        public string DateTimeFormat;
        public string EnumFormat;
        public string GuidFormat;
        public string Json;
        public string NumericFormat;
        public string Regex;
        public string TimeOnlyFormat;
        public string TimeSpanFormat;
        public string Uri;
        public string Xml;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_Syntax(){} // RVA: 0x7FFAC2F3C380
        public void get_Arguments(){} // RVA: 0x7FFAC2F247C0
    }

    public class UnconditionalSuppressMessageAttribute : Attribute
    {
        public string Justification; // 0x10
        public string <CheckId>k__BackingField; // 0x18
        public string <Justification>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void set_Justification(){} // RVA: 0x7FFAC2F4F0D0
    }

    public class UnscopedRefAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}