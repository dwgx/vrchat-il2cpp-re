// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 12
// Methods: 48

namespace ThirdParty.DotNet.System
{
    public class ParamArrayAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ParameterizedStrings : Object
    {
        public LowLevelStack _cachedStack; // 0xFFFF

        // ── Methods ──
        public void Evaluate(){} // RVA: 0x7FFAC86A9AF0
        public void EvaluateInternal(){} // RVA: 0x7FFAC86A9D10
        public void AsBool(){} // RVA: 0x7FFAC8515180
        public void AsInt(){} // RVA: 0x7FFAC8516D00
        public void StringFromAsciiBytes(){} // RVA: 0x7FFAC86AAB00
        public void snprintf(){} // RVA: 0x7FFAC86AACE0 | overloaded x2
        public void FormatPrintF(){} // RVA: 0x7FFAC86AADB0
        public void GetDynamicOrStaticVariables(){} // RVA: 0x7FFAC86AB070
    }

    public class ParamsArray : ValueType
    {
        public object[] Length;
        public object[] Item; // 0x8
        public object[] s_threeArgArray; // 0x10
        public object _arg0; // 0x10
        public object _arg1; // 0x18
        public object _arg2; // 0x20
        public object[] _args; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86456E0 | overloaded x4
        public void get_Length(){} // RVA: 0x7FFAC5CC4BA0
        public void get_Item(){} // RVA: 0x7FFAC86458B0
        public void GetAtSlow(){} // RVA: 0x7FFAC8645960
        public void .cctor(){} // RVA: 0x7FFAC86459B0
    }

    public class ParseNumbers : Object
    {
        // ── Methods ──
        public void StringToLong(){} // RVA: 0x7FFAC8645BA0 | overloaded x2
        public void StringToInt(){} // RVA: 0x7FFAC86460F0 | overloaded x2
        public void IntToString(){} // RVA: 0x7FFAC86466B0
        public void LongToString(){} // RVA: 0x7FFAC8646A50
        public void EatWhiteSpace(){} // RVA: 0x7FFAC8646EA0
        public void GrabLongs(){} // RVA: 0x7FFAC8646F70
        public void GrabInts(){} // RVA: 0x7FFAC8647140
        public void ThrowOverflowInt32Exception(){} // RVA: 0x7FFAC8647330
        public void ThrowOverflowInt64Exception(){} // RVA: 0x7FFAC8647380
        public void ThrowOverflowUInt32Exception(){} // RVA: 0x7FFAC86473D0
        public void ThrowOverflowUInt64Exception(){} // RVA: 0x7FFAC8647420
        public void IsDigit(){} // RVA: 0x7FFAC8647470
    }

    public class ParsingInfo : ValueType
    {
        public System.Globalization.Calendar calendar; // 0x10
        public int dayOfWeek; // 0x18
        public 0x6B0BF0D8 timeMark; // 0x1C
        public bool fUseHour12; // 0x20
        public bool fUseTwoDigitYear; // 0x21
        public bool fAllowInnerWhite; // 0x22
        public bool fAllowTrailingWhite; // 0x23
        public bool fCustomNumberParser; // 0x24
        public MatchNumberDelegate parseNumberDelegate; // 0x28

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC8629FD0
    }

    public class PasteArguments : Object
    {
        // ── Methods ──
        public void AppendArgument(){} // RVA: 0x7FFAC9388310
        public void ContainsNoWhitespaceOrQuotes(){} // RVA: 0x7FFAC9388580
    }

    public class Pinnable`1 : Object
    {
        public T Data;
    }

    public class PlatformNotSupportedException : NotSupportedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class PointerSpec : Object
    {
        public int pointer_level; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void Resolve(){} // RVA: 0x7FFAC86AD0A0
        public void Append(){} // RVA: 0x7FFAC86AD0F0
        public void ToString(){} // RVA: 0x7FFAC86AD120
    }

    public class Predicate`1 : MulticastDelegate
    {
    }

    public class ProgressStatics : Object
    {
        public System.Threading.SynchronizationContext DefaultContext;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8647540
    }

    public class Progress`1 : Object
    {
        public System.Threading.SynchronizationContext _synchronizationContext;
        public System.Action`1<T> _handler;
        public System.Threading.SendOrPostCallback _invokeHandlers;
        public System.EventHandler`1<T> ProgressChanged;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void OnReport(){} // RVA: 0x7FFAC2E8DC40
        public void System.IProgress<T>.Report(){} // RVA: 0x7FFAC2E8DC40
        public void InvokeHandlers(){} // RVA: 0x7FFAC2C70A40
    }

}