// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 77
// Methods: 391

namespace ThirdParty.DotNet.System
{
    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x58EB0D0
        public void Invoke(){} // RVA: 0x33ABE50
    }

    public class Comparison`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x58EB710
        public void Invoke(){} // RVA: 0x33AB7B0
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class Comparison`1
    {
    }

    public class CompatibilitySwitches
    {
    }

    public class Console
    {
        public System.IO.TextWriter IsConsole;
        public System.IO.TextWriter stderr; // 0x8
        public System.IO.TextReader stdin; // 0x10
        public bool IsRunningOnAndroid; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x5F00220
        public void SetupStreams(){} // RVA: 0x5F00480
        public void get_Error(){} // RVA: 0x5F009A0
        public void get_Out(){} // RVA: 0x5F00A00
        public void Open(){} // RVA: 0x5F00A60
        public void OpenStandardError(){} // RVA: 0x5F00B60
        public void OpenStandardInput(){} // RVA: 0x5F00C00
        public void OpenStandardOutput(){} // RVA: 0x5F00CA0
        public void SetError(){} // RVA: 0x5F00D40
        public void SetOut(){} // RVA: 0x5F00E70
        public void WriteLine(){} // RVA: 0x5F010A0 | overloaded x3
        public void get_InputEncoding(){} // RVA: 0x5F01130
        public void get_OutputEncoding(){} // RVA: 0x5F01190
        public void ReadKey(){} // RVA: 0x5F01370 | overloaded x2
        public void DoConsoleCancelEvent(){} // RVA: 0x5F014C0
    }

    public class ConsoleCancelEventArgs
    {
        public 0x657DD1D8 _type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5EC5C90 | overloaded x2
        public void get_Cancel(){} // RVA: 0x42CBD0
    }

    public class ConsoleCancelEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class ConsoleDriver
    {
        public System.IConsoleDriver driver;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x5F01AC0
        public void CreateNullConsoleDriver(){} // RVA: 0x5F01C10
        public void CreateWindowsConsoleDriver(){} // RVA: 0x5F01C50
        public void CreateTermInfoDriver(){} // RVA: 0x5F01D60
        public void ReadKey(){} // RVA: 0x5F01DC0
        public void get_IsConsole(){} // RVA: 0x5F01EE0
        public void Isatty(){} // RVA: 0x5F02050
        public void InternalKeyAvailable(){} // RVA: 0x519240
        public void TtySetup(){} // RVA: 0x5F02120
        public void SetEcho(){} // RVA: 0x2DD320
    }

    public class ConsoleKeyInfo
    {
        public char _keyChar; // 0x10
        public 0x657DD0D0 _key; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5EC5CC0
        public void get_KeyChar(){} // RVA: 0x1FA63F0
        public void get_Key(){} // RVA: 0x19689E0
        public void Equals(){} // RVA: 0x5EC5E20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5EC5E40
    }

    public class ConsoleScreenBufferInfo
    {
    }

    public class ContextBoundObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ContextStaticAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Convert
    {
        // ── Methods ──
        public void TryDecodeFromUtf16(){} // RVA: 0x5D7B770
        public void Decode(){} // RVA: 0x5D7BAE0
        public void WriteThreeLowOrderBytes(){} // RVA: 0x5D7BB40
        public void GetTypeCode(){} // RVA: 0x5D7BB60
        public void ChangeType(){} // RVA: 0x5D7CCE0 | overloaded x3
        public void DefaultToType(){} // RVA: 0x5D7C150
        public void ThrowCharOverflowException(){} // RVA: 0x5D7D630
        public void ThrowByteOverflowException(){} // RVA: 0x5D7D680
        public void ThrowSByteOverflowException(){} // RVA: 0x5D7D6D0
        public void ThrowInt16OverflowException(){} // RVA: 0x5D7D720
        public void ThrowUInt16OverflowException(){} // RVA: 0x5D7D770
        public void ThrowInt32OverflowException(){} // RVA: 0x5D7D7C0
        public void ThrowUInt32OverflowException(){} // RVA: 0x5D7D810
        public void ThrowInt64OverflowException(){} // RVA: 0x5D7D860
        public void ThrowUInt64OverflowException(){} // RVA: 0x5D7D8B0
        public void ToBoolean(){} // RVA: 0x5D7DCB0 | overloaded x18
        public void ToChar(){} // RVA: 0x5D7E390 | overloaded x18
        public void ToSByte(){} // RVA: 0x5D84AE0 | overloaded x19
        public void ToByte(){} // RVA: 0x5D849C0 | overloaded x19
        public void ToInt16(){} // RVA: 0x5D84C30 | overloaded x19
        public void ToUInt16(){} // RVA: 0x5D84D70 | overloaded x19
        public void ToInt32(){} // RVA: 0x5D84EA0 | overloaded x19
        public void ToUInt32(){} // RVA: 0x5D84F90 | overloaded x19
        public void ToInt64(){} // RVA: 0x5D85080 | overloaded x19
        public void ToUInt64(){} // RVA: 0x5D85170 | overloaded x19
        public void ToSingle(){} // RVA: 0x5D821B0 | overloaded x18
        public void ToDouble(){} // RVA: 0x5D82660 | overloaded x18
        public void ToDecimal(){} // RVA: 0x5D83270 | overloaded x18
        public void ToDateTime(){} // RVA: 0x5D83AB0 | overloaded x18
        public void ToString(){} // RVA: 0x5D85410 | overloaded x36
        public void ToBase64String(){} // RVA: 0x5D85940 | overloaded x5
        public void ToBase64CharArray(){} // RVA: 0x5D85B90 | overloaded x2
        public void ConvertToBase64Array(){} // RVA: 0x5D85FE0
        public void ToBase64_CalculateAndValidateOutputLength(){} // RVA: 0x5D86340
        public void FromBase64String(){} // RVA: 0x5D86430
        public void TryFromBase64Chars(){} // RVA: 0x5D864E0
        public void CopyToTempBufferWithoutWhiteSpace(){} // RVA: 0x5D86B50
        public void IsSpace(){} // RVA: 0x5D86C80
        public void FromBase64CharArray(){} // RVA: 0x5D86CB0
        public void FromBase64CharPtr(){} // RVA: 0x5D86EE0
        public void FromBase64_ComputeResultLength(){} // RVA: 0x5D87140
        public void .cctor(){} // RVA: 0x5D87200
    }

    public class Converter`2
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x283FA0
    }

    public class Coord
    {
    }

    public class CultureAwareComparer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5EB6290 | overloaded x3
        public void Compare(){} // RVA: 0x5EB6590
        public void Equals(){} // RVA: 0x5EB66D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5EB6770 | overloaded x2
        public void GetObjectData(){} // RVA: 0x5EB67B0
    }

    public class CurrentSystemTimeZone
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E6D2F0
        public void GetDaylightChanges(){} // RVA: 0x5E6D550
        public void CreateDaylightChanges(){} // RVA: 0x5E6D640
        public void GetUtcOffset(){} // RVA: 0x5E6D980
        public void GetCachedDaylightChanges(){} // RVA: 0x5E6DB20
    }

}