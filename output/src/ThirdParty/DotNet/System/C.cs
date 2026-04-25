// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 19
// Methods: 480

namespace ThirdParty.DotNet.System
{
    public class CLSCompliantAttribute : Attribute
    {
        public bool _compliant; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
    }

    public class CannotUnloadAppDomainException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class Char : ValueType
    {
        public char m_value; // 0x10
        public char MaxValue;
        public char MinValue;
        public byte[] s_categoryForLatin1;
        public int UNICODE_PLANE00_END;
        public int UNICODE_PLANE01_START;
        public int UNICODE_PLANE16_END;
        public int HIGH_SURROGATE_START;
        public int LOW_SURROGATE_END;

        // ── Methods ──
        public void IsLatin1(){} // RVA: 0x7FFAC850EDE0
        public void IsAscii(){} // RVA: 0x7FFAC850EDF0
        public void GetLatin1UnicodeCategory(){} // RVA: 0x7FFAC850EE00
        public void GetHashCode(){} // RVA: 0x7FFAC850EE80
        public void Equals(){} // RVA: 0x7FFAC850EF20 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC850F000 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC83C7730 | overloaded x3
        public void Parse(){} // RVA: 0x7FFAC850F0F0
        public void TryParse(){} // RVA: 0x7FFAC850F1A0
        public void IsDigit(){} // RVA: 0x7FFAC8510480 | overloaded x2
        public void CheckLetter(){} // RVA: 0x7FFAC850F240
        public void IsLetter(){} // RVA: 0x7FFAC8510640 | overloaded x2
        public void IsWhiteSpaceLatin1(){} // RVA: 0x7FFAC850F330
        public void IsWhiteSpace(){} // RVA: 0x7FFAC85119F0 | overloaded x2
        public void IsUpper(){} // RVA: 0x7FFAC85117F0 | overloaded x2
        public void IsLower(){} // RVA: 0x7FFAC8510A60 | overloaded x2
        public void CheckPunctuation(){} // RVA: 0x7FFAC850F590
        public void IsPunctuation(){} // RVA: 0x7FFAC8510F70 | overloaded x2
        public void CheckLetterOrDigit(){} // RVA: 0x7FFAC850F650
        public void IsLetterOrDigit(){} // RVA: 0x7FFAC8510870 | overloaded x2
        public void ToUpper(){} // RVA: 0x7FFAC850F7B0 | overloaded x2
        public void ToUpperInvariant(){} // RVA: 0x7FFAC850F880
        public void ToLower(){} // RVA: 0x7FFAC850F9F0 | overloaded x2
        public void ToLowerInvariant(){} // RVA: 0x7FFAC850FAC0
        public void GetTypeCode(){} // RVA: 0x7FFAC36C3910
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFAC850FB90
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFAC4AC85D0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFAC850FC20
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFAC850FCB0
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFAC850FD40
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFAC850FDD0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFAC850FE20
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFAC850FE70
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFAC850FEC0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFAC850FF10
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFAC850FF60
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFAC850FFF0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFAC8510080
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFAC8510110
        public void System.IConvertible.ToType(){} // RVA: 0x7FFAC85101A0
        public void IsControl(){} // RVA: 0x7FFAC85102D0 | overloaded x2
        public void CheckNumber(){} // RVA: 0x7FFAC8510C60
        public void IsNumber(){} // RVA: 0x7FFAC8510D50 | overloaded x2
        public void CheckSeparator(){} // RVA: 0x7FFAC8511140
        public void IsSeparatorLatin1(){} // RVA: 0x7FFAC8511150
        public void IsSeparator(){} // RVA: 0x7FFAC8511220 | overloaded x2
        public void IsSurrogate(){} // RVA: 0x7FFAC8511430 | overloaded x2
        public void CheckSymbol(){} // RVA: 0x7FFAC8511560
        public void IsSymbol(){} // RVA: 0x7FFAC8511620 | overloaded x2
        public void GetUnicodeCategory(){} // RVA: 0x7FFAC8511C60 | overloaded x2
        public void GetNumericValue(){} // RVA: 0x7FFAC8511DE0 | overloaded x2
        public void IsHighSurrogate(){} // RVA: 0x7FFAC8511FC0 | overloaded x2
        public void IsLowSurrogate(){} // RVA: 0x7FFAC8512120 | overloaded x2
        public void IsSurrogatePair(){} // RVA: 0x7FFAC85123F0 | overloaded x2
        public void ConvertFromUtf32(){} // RVA: 0x7FFAC8512420
        public void ConvertToUtf32(){} // RVA: 0x7FFAC85126B0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC85129C0
    }

    public class CharEnumerator : Object
    {
        public string System.Collections.IEnumerator.Current; // 0x10
        public int Current; // 0x18
        public char _currentElement; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8512DD0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8512B10
        public void MoveNext(){} // RVA: 0x7FFAC8512B20
        public void Dispose(){} // RVA: 0x7FFAC8512B80
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC8512BF0
        public void get_Current(){} // RVA: 0x7FFAC8512CF0
        public void Reset(){} // RVA: 0x7FFAC8512DC0
    }

    public class Comparison`1 : MulticastDelegate
    {
    }

    public class CompatibilitySwitches : Object
    {
        public bool IsAppEarlierThanWindowsPhone8;
    }

    public class Console : Object
    {
        public System.IO.TextWriter Error;
        public System.IO.TextWriter Out; // 0x8
        public System.IO.TextReader InputEncoding; // 0x10
        public bool OutputEncoding; // 0x18
        public System.Text.Encoding inputEncoding; // 0x20
        public System.Text.Encoding outputEncoding; // 0x28
        public System.ConsoleCancelEventHandler cancel_event; // 0x30

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8697880
        public void SetupStreams(){} // RVA: 0x7FFAC8697AE0
        public void get_Error(){} // RVA: 0x7FFAC8698000
        public void get_Out(){} // RVA: 0x7FFAC8698060
        public void Open(){} // RVA: 0x7FFAC86980C0
        public void OpenStandardError(){} // RVA: 0x7FFAC86981C0
        public void OpenStandardInput(){} // RVA: 0x7FFAC8698260
        public void OpenStandardOutput(){} // RVA: 0x7FFAC8698300
        public void SetError(){} // RVA: 0x7FFAC86983A0
        public void SetOut(){} // RVA: 0x7FFAC86984D0
        public void WriteLine(){} // RVA: 0x7FFAC8698700 | overloaded x3
        public void get_InputEncoding(){} // RVA: 0x7FFAC8698790
        public void get_OutputEncoding(){} // RVA: 0x7FFAC86987F0
        public void ReadKey(){} // RVA: 0x7FFAC86989D0 | overloaded x2
        public void DoConsoleCancelEvent(){} // RVA: 0x7FFAC8698B20
    }

    public class ConsoleCancelEventArgs : EventArgs
    {
        public 0x6B0C2258 Cancel; // 0x10
        public bool <Cancel>k__BackingField; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC865D340 | overloaded x2
        public void get_Cancel(){} // RVA: 0x7FFAC3070BD0
    }

    public class ConsoleCancelEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class ConsoleDriver : Object
    {
        public System.IConsoleDriver IsConsole;
        public bool is_console; // 0x8
        public bool called_isatty; // 0x9

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8699120
        public void CreateNullConsoleDriver(){} // RVA: 0x7FFAC8699270
        public void CreateWindowsConsoleDriver(){} // RVA: 0x7FFAC86992B0
        public void CreateTermInfoDriver(){} // RVA: 0x7FFAC86993C0
        public void ReadKey(){} // RVA: 0x7FFAC8699420
        public void get_IsConsole(){} // RVA: 0x7FFAC8699540
        public void Isatty(){} // RVA: 0x7FFAC86996B0
        public void InternalKeyAvailable(){} // RVA: 0x7FFAC34F9180
        public void TtySetup(){} // RVA: 0x7FFAC8699780
        public void SetEcho(){} // RVA: 0x7FFAC2F21320
    }

    public class ConsoleKeyInfo : ValueType
    {
        public char KeyChar; // 0x10
        public 0x6B0C2150 Key; // 0x14
        public 0x6B0C2200 _mods; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC865D370
        public void get_KeyChar(){} // RVA: 0x7FFAC4AC85D0
        public void get_Key(){} // RVA: 0x7FFAC44202A0
        public void Equals(){} // RVA: 0x7FFAC865D4D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC865D4F0
    }

    public class ConsoleScreenBufferInfo : ValueType
    {
        public System.Coord Size; // 0x10
        public System.Coord CursorPosition; // 0x14
        public short Attribute; // 0x18
        public System.SmallRect Window; // 0x1A
        public System.Coord MaxWindowSize; // 0x22
    }

    public class ContextBoundObject : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ContextStaticAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Convert : Object
    {
        public sbyte[] s_decodingMap;
        public System.Type[] ConvertTypes; // 0x8
        public System.Type EnumType; // 0x10
        public char[] base64Table; // 0x18
        public object DBNull; // 0x20

        // ── Methods ──
        public void TryDecodeFromUtf16(){} // RVA: 0x7FFAC8512E00
        public void Decode(){} // RVA: 0x7FFAC8513170
        public void WriteThreeLowOrderBytes(){} // RVA: 0x7FFAC85131D0
        public void GetTypeCode(){} // RVA: 0x7FFAC85131F0
        public void ChangeType(){} // RVA: 0x7FFAC8514370 | overloaded x3
        public void DefaultToType(){} // RVA: 0x7FFAC85137E0
        public void ThrowCharOverflowException(){} // RVA: 0x7FFAC8514CC0
        public void ThrowByteOverflowException(){} // RVA: 0x7FFAC8514D10
        public void ThrowSByteOverflowException(){} // RVA: 0x7FFAC8514D60
        public void ThrowInt16OverflowException(){} // RVA: 0x7FFAC8514DB0
        public void ThrowUInt16OverflowException(){} // RVA: 0x7FFAC8514E00
        public void ThrowInt32OverflowException(){} // RVA: 0x7FFAC8514E50
        public void ThrowUInt32OverflowException(){} // RVA: 0x7FFAC8514EA0
        public void ThrowInt64OverflowException(){} // RVA: 0x7FFAC8514EF0
        public void ThrowUInt64OverflowException(){} // RVA: 0x7FFAC8514F40
        public void ToBoolean(){} // RVA: 0x7FFAC8515340 | overloaded x18
        public void ToChar(){} // RVA: 0x7FFAC8515A20 | overloaded x18
        public void ToSByte(){} // RVA: 0x7FFAC851C170 | overloaded x19
        public void ToByte(){} // RVA: 0x7FFAC851C050 | overloaded x19
        public void ToInt16(){} // RVA: 0x7FFAC851C2C0 | overloaded x19
        public void ToUInt16(){} // RVA: 0x7FFAC851C400 | overloaded x19
        public void ToInt32(){} // RVA: 0x7FFAC851C530 | overloaded x19
        public void ToUInt32(){} // RVA: 0x7FFAC851C620 | overloaded x19
        public void ToInt64(){} // RVA: 0x7FFAC851C710 | overloaded x19
        public void ToUInt64(){} // RVA: 0x7FFAC851C800 | overloaded x19
        public void ToSingle(){} // RVA: 0x7FFAC8519840 | overloaded x18
        public void ToDouble(){} // RVA: 0x7FFAC8519CF0 | overloaded x18
        public void ToDecimal(){} // RVA: 0x7FFAC851A900 | overloaded x18
        public void ToDateTime(){} // RVA: 0x7FFAC851B140 | overloaded x18
        public void ToString(){} // RVA: 0x7FFAC851CAA0 | overloaded x36
        public void ToBase64String(){} // RVA: 0x7FFAC851CFD0 | overloaded x5
        public void ToBase64CharArray(){} // RVA: 0x7FFAC851D220 | overloaded x2
        public void ConvertToBase64Array(){} // RVA: 0x7FFAC851D670
        public void ToBase64_CalculateAndValidateOutputLength(){} // RVA: 0x7FFAC851D9D0
        public void FromBase64String(){} // RVA: 0x7FFAC851DAC0
        public void TryFromBase64Chars(){} // RVA: 0x7FFAC851DB70
        public void CopyToTempBufferWithoutWhiteSpace(){} // RVA: 0x7FFAC851E1E0
        public void IsSpace(){} // RVA: 0x7FFAC851E310
        public void FromBase64CharArray(){} // RVA: 0x7FFAC851E340
        public void FromBase64CharPtr(){} // RVA: 0x7FFAC851E570
        public void FromBase64_ComputeResultLength(){} // RVA: 0x7FFAC851E7D0
        public void .cctor(){} // RVA: 0x7FFAC851E890
    }

    public class Converter`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Coord : ValueType
    {
        public short X; // 0x10
        public short Y; // 0x12
    }

    public class CultureAwareComparer : StringComparer
    {
        public 0x6B0DB010 ValidCompareMaskOffFlags;
        public System.Globalization.CompareInfo _compareInfo; // 0x10
        public 0x6B0DB010 _options; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC864D940 | overloaded x3
        public void Compare(){} // RVA: 0x7FFAC864DC40
        public void Equals(){} // RVA: 0x7FFAC864DD80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC864DE20 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFAC864DE60
    }

    public class CurrentSystemTimeZone : TimeZone
    {
        public long m_ticksOffset; // 0x10
        public string m_standardName; // 0x18
        public string m_daylightName; // 0x20
        public System.Collections.Hashtable m_CachedDaylightChanges; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8604960
        public void GetDaylightChanges(){} // RVA: 0x7FFAC8604BC0
        public void CreateDaylightChanges(){} // RVA: 0x7FFAC8604CB0
        public void GetUtcOffset(){} // RVA: 0x7FFAC8604FF0
        public void GetCachedDaylightChanges(){} // RVA: 0x7FFAC8605190
    }

}