// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 12
// Methods: 48

namespace ThirdParty.DotNet.System
{
    public class ParamArrayAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ParameterizedStrings : Object
    {
        // ── Methods ──
        public void Evaluate(){} // RVA: 0x7FFE86A532A0
        public void EvaluateInternal(){} // RVA: 0x7FFE86A534C0
        public void AsBool(){} // RVA: 0x7FFE868BE980
        public void AsInt(){} // RVA: 0x7FFE868C0500
        public void StringFromAsciiBytes(){} // RVA: 0x7FFE86A542B0
        public void snprintf(){} // RVA: 0x7FFE86A54490 | overloaded x2
        public void FormatPrintF(){} // RVA: 0x7FFE86A54560
        public void GetDynamicOrStaticVariables(){} // RVA: 0x7FFE86A54820
    }

    public class ParamsArray : ValueType
    {
        public object[] s_oneArgArray;
        public object[] s_twoArgArray; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869EEED0 | overloaded x4
        public void get_Length(){} // RVA: 0x7FFE84023030
        public void get_Item(){} // RVA: 0x7FFE869EF0A0
        public void GetAtSlow(){} // RVA: 0x7FFE869EF150
        public void .cctor(){} // RVA: 0x7FFE869EF1A0
    }

    public class ParseNumbers : Object
    {
        // ── Methods ──
        public void StringToLong(){} // RVA: 0x7FFE869EF390 | overloaded x2
        public void StringToInt(){} // RVA: 0x7FFE869EF8E0 | overloaded x2
        public void IntToString(){} // RVA: 0x7FFE869EFEA0
        public void LongToString(){} // RVA: 0x7FFE869F0240
        public void EatWhiteSpace(){} // RVA: 0x7FFE869F0690
        public void GrabLongs(){} // RVA: 0x7FFE869F0760
        public void GrabInts(){} // RVA: 0x7FFE869F0930
        public void ThrowOverflowInt32Exception(){} // RVA: 0x7FFE869F0B20
        public void ThrowOverflowInt64Exception(){} // RVA: 0x7FFE869F0B70
        public void ThrowOverflowUInt32Exception(){} // RVA: 0x7FFE869F0BC0
        public void ThrowOverflowUInt64Exception(){} // RVA: 0x7FFE869F0C10
        public void IsDigit(){} // RVA: 0x7FFE869F0C60
    }

    public class ParsingInfo : ValueType
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE869D37A0
    }

    public class PasteArguments : Object
    {
        // ── Methods ──
        public void AppendArgument(){} // RVA: 0x7FFE87730A40
        public void ContainsNoWhitespaceOrQuotes(){} // RVA: 0x7FFE87730CB0
    }

    public class Pinnable`1 : Object
    {
    }

    public class PlatformNotSupportedException : NotSupportedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class PointerSpec : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Resolve(){} // RVA: 0x7FFE86A56850
        public void Append(){} // RVA: 0x7FFE86A568A0
        public void ToString(){} // RVA: 0x7FFE86A568D0
    }

    public class Predicate`1 : MulticastDelegate
    {
    }

    public class ProgressStatics : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE869F0D30
    }

    public class Progress`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void OnReport(){} // RVA: 0x7FFE810A1420
        public void System.IProgress<T>.Report(){} // RVA: 0x7FFE810A1420
        public void InvokeHandlers(){} // RVA: 0x7FFE80E460A0
    }

}