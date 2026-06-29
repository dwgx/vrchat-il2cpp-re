// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 57
// Methods: 265

namespace ThirdParty.DotNet.System
{
    public class CLSCompliantAttribute : Attribute
    {
        public object _compliant;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
    }

    public class CannotUnloadAppDomainException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class Char : ValueType
    {
        public object m_value;
        public object s_categoryForLatin1;

        // ── Methods ──
        public void IsLatin1(){} // RVA: 0x67F0A30
        public void IsAscii(){} // RVA: 0x67F0A40
        public void GetLatin1UnicodeCategory(){} // RVA: 0x67F0A50
        public void GetHashCode(){} // RVA: 0x8B1500
        public void Equals(){} // RVA: 0x8B1570
        public void CompareTo(){} // RVA: 0x8B1590
        public void ToString(){} // RVA: 0x67F0C20
        public void Parse(){} // RVA: 0x67F0C30
        public void TryParse(){} // RVA: 0x67F0CE0
        public void IsDigit(){} // RVA: 0x67F1F50
        public void CheckLetter(){} // RVA: 0x67F0D60
        public void IsLetter(){} // RVA: 0x67F20F0
        public void IsWhiteSpaceLatin1(){} // RVA: 0x67F0E30
        public void IsWhiteSpace(){} // RVA: 0x67F3350
        public void IsUpper(){} // RVA: 0x67F3170
        public void IsLower(){} // RVA: 0x67F24D0
        public void CheckPunctuation(){} // RVA: 0x67F1030
        public void IsPunctuation(){} // RVA: 0x67F2980
        public void CheckLetterOrDigit(){} // RVA: 0x67F1110
        public void IsLetterOrDigit(){} // RVA: 0x67F2300
        public void ToUpper(){} // RVA: 0x67F1290
        public void ToUpperInvariant(){} // RVA: 0x67F1360
        public void ToLower(){} // RVA: 0x67F14D0
        public void ToLowerInvariant(){} // RVA: 0x67F15A0
        public void GetTypeCode(){} // RVA: 0x178950
        public void System.IConvertible.ToBoolean(){} // RVA: 0x8B15D0
        public void System.IConvertible.ToChar(){} // RVA: 0xE3300
        public void System.IConvertible.ToSByte(){} // RVA: 0x8B15E0
        public void System.IConvertible.ToByte(){} // RVA: 0x8B1670
        public void System.IConvertible.ToInt16(){} // RVA: 0x8B1700
        public void System.IConvertible.ToUInt16(){} // RVA: 0x8B1790
        public void System.IConvertible.ToInt32(){} // RVA: 0x8B17E0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x8B1830
        public void System.IConvertible.ToInt64(){} // RVA: 0x8B1880
        public void System.IConvertible.ToUInt64(){} // RVA: 0x8B18D0
        public void System.IConvertible.ToSingle(){} // RVA: 0x8B1920
        public void System.IConvertible.ToDouble(){} // RVA: 0x8B1930
        public void System.IConvertible.ToDecimal(){} // RVA: 0x8B1940
        public void System.IConvertible.ToDateTime(){} // RVA: 0x8B1960
        public void System.IConvertible.ToType(){} // RVA: 0x8B1970
        public void IsControl(){} // RVA: 0x67F1DC0
        public void CheckNumber(){} // RVA: 0x67F26B0
        public void IsNumber(){} // RVA: 0x67F2780
        public void CheckSeparator(){} // RVA: 0x67F2B30
        public void IsSeparatorLatin1(){} // RVA: 0x67F2B40
        public void IsSeparator(){} // RVA: 0x67F2BF0
        public void IsSurrogate(){} // RVA: 0x67F2DE0
        public void CheckSymbol(){} // RVA: 0x67F2EE0
        public void IsSymbol(){} // RVA: 0x67F2FC0
        public void GetUnicodeCategory(){} // RVA: 0x67F35C0
        public void GetNumericValue(){} // RVA: 0x67F3720
        public void IsHighSurrogate(){} // RVA: 0x67F3900
        public void IsLowSurrogate(){} // RVA: 0x67F3A30
        public void IsSurrogatePair(){} // RVA: 0x67F3CA0
        public void ConvertFromUtf32(){} // RVA: 0x67F3CD0
        public void ConvertToUtf32(){} // RVA: 0x67F3FA0
        public void .cctor(){} // RVA: 0x67F42A0
    }

    public class CharEnumerator : Object
    {
        public object _str;
        public object _index;
        public object _currentElement;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67F4690
        public void Clone(){} // RVA: 0x67F43E0
        public void MoveNext(){} // RVA: 0x67F43F0
        public void Dispose(){} // RVA: 0x67F4460
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x67F44D0
        public void get_Current(){} // RVA: 0x67F45B0
        public void Reset(){} // RVA: 0x67F4680
    }

    public class Char[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAC620
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B590
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC7AB0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E578D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B590
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Char[][] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0xA94080
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64222A0
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64213B0
        public void Invoke(){} // RVA: 0x3E374F0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6422C10
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6421480
        public void Invoke(){} // RVA: 0x3E3C390
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6421480
        public void Invoke(){} // RVA: 0x3E3C390
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64213B0
        public void Invoke(){} // RVA: 0x3E374F0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64213B0
        public void Invoke(){} // RVA: 0x3E374F0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6421750
        public void Invoke(){} // RVA: 0x6421820
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64213B0
        public void Invoke(){} // RVA: 0x3E374F0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6421AC0
        public void Invoke(){} // RVA: 0x6421B90
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64213B0
        public void Invoke(){} // RVA: 0x3E374F0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Comparison`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3B100
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Console : Object
    {
        public object stdout;
        public object stderr;
        public object stdin;
        public object IsRunningOnAndroid;
        public object inputEncoding;
        public object outputEncoding;
        public object cancel_event;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x69779C0
        public void SetupStreams(){} // RVA: 0x6977C20
        public void get_Error(){} // RVA: 0x6978150
        public void get_Out(){} // RVA: 0x69781B0
        public void Open(){} // RVA: 0x6978210
        public void OpenStandardError(){} // RVA: 0x6978310
        public void OpenStandardInput(){} // RVA: 0x69783B0
        public void OpenStandardOutput(){} // RVA: 0x6978450
        public void SetError(){} // RVA: 0x69784F0
        public void SetOut(){} // RVA: 0x6978620
        public void WriteLine(){} // RVA: 0x6978850
        public void get_InputEncoding(){} // RVA: 0x69788E0
        public void get_OutputEncoding(){} // RVA: 0x6978940
        public void ReadKey(){} // RVA: 0x6978B20
        public void DoConsoleCancelEvent(){} // RVA: 0x6978C70
    }

    public class ConsoleCancelEventArgs : EventArgs
    {
        public object _type;
        public object _cancel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x693E4B0
        public void get_Cancel(){} // RVA: 0xC9C250
    }

    public class ConsoleCancelEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class ConsoleDriver : Object
    {
        public object driver;
        public object is_console;
        public object called_isatty;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6979270
        public void CreateNullConsoleDriver(){} // RVA: 0x69793C0
        public void CreateWindowsConsoleDriver(){} // RVA: 0x6979400
        public void CreateTermInfoDriver(){} // RVA: 0x6979520
        public void ReadKey(){} // RVA: 0x6979580
        public void get_IsConsole(){} // RVA: 0x69796A0
        public void Isatty(){} // RVA: 0x6979810
        public void InternalKeyAvailable(){} // RVA: 0xDAC980
        public void TtySetup(){} // RVA: 0x6979900
        public void SetEcho(){} // RVA: 0xB43320
    }

    public class ConsoleKeyInfo : ValueType
    {
        public object _keyChar;
        public object _key;
        public object _mods;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8BE120
        public void get_KeyChar(){} // RVA: 0xE3300
        public void get_Key(){} // RVA: 0x77E50
        public void Equals(){} // RVA: 0x8BE1F0
        public void GetHashCode(){} // RVA: 0x8BE230
    }

    public class ContextBoundObject : MarshalByRefObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ContextStaticAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Convert : Object
    {
        public object s_decodingMap;
        public object ConvertTypes;
        public object EnumType;
        public object base64Table;
        public object DBNull;

        // ── Methods ──
        public void TryDecodeFromUtf16(){} // RVA: 0x67F46C0
        public void Decode(){} // RVA: 0x67F4A50
        public void WriteThreeLowOrderBytes(){} // RVA: 0x67F4AB0
        public void GetTypeCode(){} // RVA: 0x67F4AD0
        public void ChangeType(){} // RVA: 0x67F5A90
        public void DefaultToType(){} // RVA: 0x67F4FF0
        public void ThrowCharOverflowException(){} // RVA: 0x67F6300
        public void ThrowByteOverflowException(){} // RVA: 0x67F6350
        public void ThrowSByteOverflowException(){} // RVA: 0x67F63A0
        public void ThrowInt16OverflowException(){} // RVA: 0x67F63F0
        public void ThrowUInt16OverflowException(){} // RVA: 0x67F6440
        public void ThrowInt32OverflowException(){} // RVA: 0x67F6490
        public void ThrowUInt32OverflowException(){} // RVA: 0x67F64E0
        public void ThrowInt64OverflowException(){} // RVA: 0x67F6530
        public void ThrowUInt64OverflowException(){} // RVA: 0x67F6580
        public void ToBoolean(){} // RVA: 0x67F68E0
        public void ToChar(){} // RVA: 0x67F6F60
        public void ToSByte(){} // RVA: 0x67FD3A0
        public void ToByte(){} // RVA: 0x67FD280
        public void ToInt16(){} // RVA: 0x67FD4F0
        public void ToUInt16(){} // RVA: 0x67FD630
        public void ToInt32(){} // RVA: 0x67FD760
        public void ToUInt32(){} // RVA: 0x67FD850
        public void ToInt64(){} // RVA: 0x67FD940
        public void ToUInt64(){} // RVA: 0x67FDA30
        public void ToSingle(){} // RVA: 0x67FAD80
        public void ToDouble(){} // RVA: 0x67FB210
        public void ToDecimal(){} // RVA: 0x67FBDF0
        public void ToDateTime(){} // RVA: 0x67FC4B0
        public void ToString(){} // RVA: 0x67FDCD0
        public void ToBase64String(){} // RVA: 0x67FE200
        public void ToBase64CharArray(){} // RVA: 0x67FE430
        public void ConvertToBase64Array(){} // RVA: 0x67FE870
        public void ToBase64_CalculateAndValidateOutputLength(){} // RVA: 0x67FEBD0
        public void FromBase64String(){} // RVA: 0x67FECC0
        public void TryFromBase64Chars(){} // RVA: 0x67FED70
        public void CopyToTempBufferWithoutWhiteSpace(){} // RVA: 0x67FF3F0
        public void IsSpace(){} // RVA: 0x67FF520
        public void FromBase64CharArray(){} // RVA: 0x67FF550
        public void FromBase64CharPtr(){} // RVA: 0x67FF780
        public void FromBase64_ComputeResultLength(){} // RVA: 0x67FF9E0
        public void .cctor(){} // RVA: 0x67FFAA0
    }

    public class Converter`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0xA94080
    }

    public class CultureAwareComparer : StringComparer
    {
        public object _compareInfo;
        public object _options;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x692F2A0
        public void Compare(){} // RVA: 0x692F570
        public void Equals(){} // RVA: 0x692F6B0
        public void GetHashCode(){} // RVA: 0x692F750
        public void GetObjectData(){} // RVA: 0x692F790
    }

    public class CurrentSystemTimeZone : TimeZone
    {
        public object m_ticksOffset;
        public object m_standardName;
        public object m_daylightName;
        public object m_CachedDaylightChanges;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x68E6640
        public void GetDaylightChanges(){} // RVA: 0x68E6860
        public void CreateDaylightChanges(){} // RVA: 0x68E6940
        public void GetUtcOffset(){} // RVA: 0x68E6C90
        public void GetCachedDaylightChanges(){} // RVA: 0x68E6E30
    }

}