// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 19
// Methods: 480

namespace ThirdParty.DotNet.System
{
    public class CLSCompliantAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
    }

    public class CannotUnloadAppDomainException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class Char : ValueType
    {
        // ── Methods ──
        public void IsLatin1(){} // RVA: 0x7FFE868B85E0
        public void IsAscii(){} // RVA: 0x7FFE868B85F0
        public void GetLatin1UnicodeCategory(){} // RVA: 0x7FFE868B8600
        public void GetHashCode(){} // RVA: 0x7FFE868B8680
        public void Equals(){} // RVA: 0x7FFE868B8720 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFE868B8800 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE86771030 | overloaded x3
        public void Parse(){} // RVA: 0x7FFE868B88F0
        public void TryParse(){} // RVA: 0x7FFE868B89A0
        public void IsDigit(){} // RVA: 0x7FFE868B9C80 | overloaded x2
        public void CheckLetter(){} // RVA: 0x7FFE868B8A40
        public void IsLetter(){} // RVA: 0x7FFE868B9E40 | overloaded x2
        public void IsWhiteSpaceLatin1(){} // RVA: 0x7FFE868B8B30
        public void IsWhiteSpace(){} // RVA: 0x7FFE868BB1F0 | overloaded x2
        public void IsUpper(){} // RVA: 0x7FFE868BAFF0 | overloaded x2
        public void IsLower(){} // RVA: 0x7FFE868BA260 | overloaded x2
        public void CheckPunctuation(){} // RVA: 0x7FFE868B8D90
        public void IsPunctuation(){} // RVA: 0x7FFE868BA770 | overloaded x2
        public void CheckLetterOrDigit(){} // RVA: 0x7FFE868B8E50
        public void IsLetterOrDigit(){} // RVA: 0x7FFE868BA070 | overloaded x2
        public void ToUpper(){} // RVA: 0x7FFE868B8FB0 | overloaded x2
        public void ToUpperInvariant(){} // RVA: 0x7FFE868B9080
        public void ToLower(){} // RVA: 0x7FFE868B91F0 | overloaded x2
        public void ToLowerInvariant(){} // RVA: 0x7FFE868B92C0
        public void GetTypeCode(){} // RVA: 0x7FFE8180E590
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFE868B9390
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFE82D33010
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFE868B9420
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFE868B94B0
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFE868B9540
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFE868B95D0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFE868B9620
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFE868B9670
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFE868B96C0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFE868B9710
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFE868B9760
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFE868B97F0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFE868B9880
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFE868B9910
        public void System.IConvertible.ToType(){} // RVA: 0x7FFE868B99A0
        public void IsControl(){} // RVA: 0x7FFE868B9AD0 | overloaded x2
        public void CheckNumber(){} // RVA: 0x7FFE868BA460
        public void IsNumber(){} // RVA: 0x7FFE868BA550 | overloaded x2
        public void CheckSeparator(){} // RVA: 0x7FFE868BA940
        public void IsSeparatorLatin1(){} // RVA: 0x7FFE868BA950
        public void IsSeparator(){} // RVA: 0x7FFE868BAA20 | overloaded x2
        public void IsSurrogate(){} // RVA: 0x7FFE868BAC30 | overloaded x2
        public void CheckSymbol(){} // RVA: 0x7FFE868BAD60
        public void IsSymbol(){} // RVA: 0x7FFE868BAE20 | overloaded x2
        public void GetUnicodeCategory(){} // RVA: 0x7FFE868BB460 | overloaded x2
        public void GetNumericValue(){} // RVA: 0x7FFE868BB5E0 | overloaded x2
        public void IsHighSurrogate(){} // RVA: 0x7FFE868BB7C0 | overloaded x2
        public void IsLowSurrogate(){} // RVA: 0x7FFE868BB920 | overloaded x2
        public void IsSurrogatePair(){} // RVA: 0x7FFE868BBBF0 | overloaded x2
        public void ConvertFromUtf32(){} // RVA: 0x7FFE868BBC20
        public void ConvertToUtf32(){} // RVA: 0x7FFE868BBEB0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE868BC1C0
    }

    public class CharEnumerator : Object
    {
        public string _str; // 0x10
        public int _index; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868BC5D0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE868BC310
        public void MoveNext(){} // RVA: 0x7FFE868BC320
        public void Dispose(){} // RVA: 0x7FFE868BC380
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE868BC3F0
        public void get_Current(){} // RVA: 0x7FFE868BC4F0
        public void Reset(){} // RVA: 0x7FFE868BC5C0
    }

    public class Comparison`1 : MulticastDelegate
    {
    }

    public class CompatibilitySwitches : Object
    {
    }

    public class Console : Object
    {
        public System.IO.TextWriter stdout;
        public System.IO.TextWriter stderr; // 0x8
        public System.IO.TextReader stdin; // 0x10
        public bool IsRunningOnAndroid; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86A41060
        public void SetupStreams(){} // RVA: 0x7FFE86A412C0
        public void get_Error(){} // RVA: 0x7FFE86A417E0
        public void get_Out(){} // RVA: 0x7FFE86A41840
        public void Open(){} // RVA: 0x7FFE86A418A0
        public void OpenStandardError(){} // RVA: 0x7FFE86A419A0
        public void OpenStandardInput(){} // RVA: 0x7FFE86A41A40
        public void OpenStandardOutput(){} // RVA: 0x7FFE86A41AE0
        public void SetError(){} // RVA: 0x7FFE86A41B80
        public void SetOut(){} // RVA: 0x7FFE86A41CB0
        public void WriteLine(){} // RVA: 0x7FFE86A41EE0 | overloaded x3
        public void get_InputEncoding(){} // RVA: 0x7FFE86A41F70
        public void get_OutputEncoding(){} // RVA: 0x7FFE86A41FD0
        public void ReadKey(){} // RVA: 0x7FFE86A421B0 | overloaded x2
        public void DoConsoleCancelEvent(){} // RVA: 0x7FFE86A42300
    }

    public class ConsoleCancelEventArgs : EventArgs
    {
        public 0x664BB17C _type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A06B30 | overloaded x2
        public void get_Cancel(){} // RVA: 0x7FFE8124ABD0
    }

    public class ConsoleCancelEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class ConsoleDriver : Object
    {
        public System.IConsoleDriver driver;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86A42900
        public void CreateNullConsoleDriver(){} // RVA: 0x7FFE86A42A50
        public void CreateWindowsConsoleDriver(){} // RVA: 0x7FFE86A42A90
        public void CreateTermInfoDriver(){} // RVA: 0x7FFE86A42BA0
        public void ReadKey(){} // RVA: 0x7FFE86A42C00
        public void get_IsConsole(){} // RVA: 0x7FFE86A42D20
        public void Isatty(){} // RVA: 0x7FFE86A42E90
        public void InternalKeyAvailable(){} // RVA: 0x7FFE813240E0
        public void TtySetup(){} // RVA: 0x7FFE86A42F60
        public void SetEcho(){} // RVA: 0x7FFE810FB320
    }

    public class ConsoleKeyInfo : ValueType
    {
        public char _keyChar; // 0x10
        public 0x664BB074 _key; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A06B60
        public void get_KeyChar(){} // RVA: 0x7FFE82D33010
        public void get_Key(){} // RVA: 0x7FFE826F42A0
        public void Equals(){} // RVA: 0x7FFE86A06CC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86A06CE0
    }

    public class ConsoleScreenBufferInfo : ValueType
    {
    }

    public class ContextBoundObject : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ContextStaticAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Convert : Object
    {
        // ── Methods ──
        public void TryDecodeFromUtf16(){} // RVA: 0x7FFE868BC600
        public void Decode(){} // RVA: 0x7FFE868BC970
        public void WriteThreeLowOrderBytes(){} // RVA: 0x7FFE868BC9D0
        public void GetTypeCode(){} // RVA: 0x7FFE868BC9F0
        public void ChangeType(){} // RVA: 0x7FFE868BDB70 | overloaded x3
        public void DefaultToType(){} // RVA: 0x7FFE868BCFE0
        public void ThrowCharOverflowException(){} // RVA: 0x7FFE868BE4C0
        public void ThrowByteOverflowException(){} // RVA: 0x7FFE868BE510
        public void ThrowSByteOverflowException(){} // RVA: 0x7FFE868BE560
        public void ThrowInt16OverflowException(){} // RVA: 0x7FFE868BE5B0
        public void ThrowUInt16OverflowException(){} // RVA: 0x7FFE868BE600
        public void ThrowInt32OverflowException(){} // RVA: 0x7FFE868BE650
        public void ThrowUInt32OverflowException(){} // RVA: 0x7FFE868BE6A0
        public void ThrowInt64OverflowException(){} // RVA: 0x7FFE868BE6F0
        public void ThrowUInt64OverflowException(){} // RVA: 0x7FFE868BE740
        public void ToBoolean(){} // RVA: 0x7FFE868BEB40 | overloaded x18
        public void ToChar(){} // RVA: 0x7FFE868BF220 | overloaded x18
        public void ToSByte(){} // RVA: 0x7FFE868C5970 | overloaded x19
        public void ToByte(){} // RVA: 0x7FFE868C5850 | overloaded x19
        public void ToInt16(){} // RVA: 0x7FFE868C5AC0 | overloaded x19
        public void ToUInt16(){} // RVA: 0x7FFE868C5C00 | overloaded x19
        public void ToInt32(){} // RVA: 0x7FFE868C5D30 | overloaded x19
        public void ToUInt32(){} // RVA: 0x7FFE868C5E20 | overloaded x19
        public void ToInt64(){} // RVA: 0x7FFE868C5F10 | overloaded x19
        public void ToUInt64(){} // RVA: 0x7FFE868C6000 | overloaded x19
        public void ToSingle(){} // RVA: 0x7FFE868C3040 | overloaded x18
        public void ToDouble(){} // RVA: 0x7FFE868C34F0 | overloaded x18
        public void ToDecimal(){} // RVA: 0x7FFE868C4100 | overloaded x18
        public void ToDateTime(){} // RVA: 0x7FFE868C4940 | overloaded x18
        public void ToString(){} // RVA: 0x7FFE868C62A0 | overloaded x36
        public void ToBase64String(){} // RVA: 0x7FFE868C67D0 | overloaded x5
        public void ToBase64CharArray(){} // RVA: 0x7FFE868C6A20 | overloaded x2
        public void ConvertToBase64Array(){} // RVA: 0x7FFE868C6E70
        public void ToBase64_CalculateAndValidateOutputLength(){} // RVA: 0x7FFE868C71D0
        public void FromBase64String(){} // RVA: 0x7FFE868C72C0
        public void TryFromBase64Chars(){} // RVA: 0x7FFE868C7370
        public void CopyToTempBufferWithoutWhiteSpace(){} // RVA: 0x7FFE868C79E0
        public void IsSpace(){} // RVA: 0x7FFE868C7B10
        public void FromBase64CharArray(){} // RVA: 0x7FFE868C7B40
        public void FromBase64CharPtr(){} // RVA: 0x7FFE868C7D70
        public void FromBase64_ComputeResultLength(){} // RVA: 0x7FFE868C7FD0
        public void .cctor(){} // RVA: 0x7FFE868C8090
    }

    public class Converter`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class Coord : ValueType
    {
    }

    public class CultureAwareComparer : StringComparer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869F7130 | overloaded x3
        public void Compare(){} // RVA: 0x7FFE869F7430
        public void Equals(){} // RVA: 0x7FFE869F7570 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE869F7610 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFE869F7650
    }

    public class CurrentSystemTimeZone : TimeZone
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869AE130
        public void GetDaylightChanges(){} // RVA: 0x7FFE869AE390
        public void CreateDaylightChanges(){} // RVA: 0x7FFE869AE480
        public void GetUtcOffset(){} // RVA: 0x7FFE869AE7C0
        public void GetCachedDaylightChanges(){} // RVA: 0x7FFE869AE960
    }

}