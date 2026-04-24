// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 7
// Methods: 431

namespace ThirdParty.DotNet.System
{
    public class CLSCompliantAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E40B5F0
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
        public void IsLatin1(){} // RVA: 0x7FFD5392EDE0
        public void IsAscii(){} // RVA: 0x7FFD5392EDF0
        public void GetLatin1UnicodeCategory(){} // RVA: 0x7FFD5392EE00
        public void GetHashCode(){} // RVA: 0x7FFD5392EE80
        public void Equals(){} // RVA: 0x7FFD5392EF20 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFD5392F000 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD537E7730 | overloaded x3
        public void Parse(){} // RVA: 0x7FFD5392F0F0
        public void TryParse(){} // RVA: 0x7FFD5392F1A0
        public void IsDigit(){} // RVA: 0x7FFD53930480 | overloaded x2
        public void CheckLetter(){} // RVA: 0x7FFD5392F240
        public void IsLetter(){} // RVA: 0x7FFD53930640 | overloaded x2
        public void IsWhiteSpaceLatin1(){} // RVA: 0x7FFD5392F330
        public void IsWhiteSpace(){} // RVA: 0x7FFD539319F0 | overloaded x2
        public void IsUpper(){} // RVA: 0x7FFD539317F0 | overloaded x2
        public void IsLower(){} // RVA: 0x7FFD53930A60 | overloaded x2
        public void CheckPunctuation(){} // RVA: 0x7FFD5392F590
        public void IsPunctuation(){} // RVA: 0x7FFD53930F70 | overloaded x2
        public void CheckLetterOrDigit(){} // RVA: 0x7FFD5392F650
        public void IsLetterOrDigit(){} // RVA: 0x7FFD53930870 | overloaded x2
        public void ToUpper(){} // RVA: 0x7FFD5392F7B0 | overloaded x2
        public void ToUpperInvariant(){} // RVA: 0x7FFD5392F880
        public void ToLower(){} // RVA: 0x7FFD5392F9F0 | overloaded x2
        public void ToLowerInvariant(){} // RVA: 0x7FFD5392FAC0
        public void GetTypeCode(){} // RVA: 0x7FFD4EAE3910
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFD5392FB90
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFD4FEE85D0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFD5392FC20
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFD5392FCB0
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFD5392FD40
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFD5392FDD0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFD5392FE20
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFD5392FE70
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFD5392FEC0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFD5392FF10
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFD5392FF60
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFD5392FFF0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFD53930080
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFD53930110
        public void System.IConvertible.ToType(){} // RVA: 0x7FFD539301A0
        public void IsControl(){} // RVA: 0x7FFD539302D0 | overloaded x2
        public void CheckNumber(){} // RVA: 0x7FFD53930C60
        public void IsNumber(){} // RVA: 0x7FFD53930D50 | overloaded x2
        public void CheckSeparator(){} // RVA: 0x7FFD53931140
        public void IsSeparatorLatin1(){} // RVA: 0x7FFD53931150
        public void IsSeparator(){} // RVA: 0x7FFD53931220 | overloaded x2
        public void IsSurrogate(){} // RVA: 0x7FFD53931430 | overloaded x2
        public void CheckSymbol(){} // RVA: 0x7FFD53931560
        public void IsSymbol(){} // RVA: 0x7FFD53931620 | overloaded x2
        public void GetUnicodeCategory(){} // RVA: 0x7FFD53931C60 | overloaded x2
        public void GetNumericValue(){} // RVA: 0x7FFD53931DE0 | overloaded x2
        public void IsHighSurrogate(){} // RVA: 0x7FFD53931FC0 | overloaded x2
        public void IsLowSurrogate(){} // RVA: 0x7FFD53932120 | overloaded x2
        public void IsSurrogatePair(){} // RVA: 0x7FFD539323F0 | overloaded x2
        public void ConvertFromUtf32(){} // RVA: 0x7FFD53932420
        public void ConvertToUtf32(){} // RVA: 0x7FFD539326B0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD539329C0
    }

    public class CharEnumerator : Object
    {
        public object System.Collections.IEnumerator.Current;
        public object Current;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53932DD0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD53932B10
        public void MoveNext(){} // RVA: 0x7FFD53932B20
        public void Dispose(){} // RVA: 0x7FFD53932B80
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD53932BF0
        public void get_Current(){} // RVA: 0x7FFD53932CF0
        public void Reset(){} // RVA: 0x7FFD53932DC0
    }

    public class Comparison`1 : MulticastDelegate
    {
    }

    public class Convert : Object
    {
        // ── Methods ──
        public void TryDecodeFromUtf16(){} // RVA: 0x7FFD53932E00
        public void Decode(){} // RVA: 0x7FFD53933170
        public void WriteThreeLowOrderBytes(){} // RVA: 0x7FFD539331D0
        public void GetTypeCode(){} // RVA: 0x7FFD539331F0
        public void ChangeType(){} // RVA: 0x7FFD53934370 | overloaded x3
        public void DefaultToType(){} // RVA: 0x7FFD539337E0
        public void ThrowCharOverflowException(){} // RVA: 0x7FFD53934CC0
        public void ThrowByteOverflowException(){} // RVA: 0x7FFD53934D10
        public void ThrowSByteOverflowException(){} // RVA: 0x7FFD53934D60
        public void ThrowInt16OverflowException(){} // RVA: 0x7FFD53934DB0
        public void ThrowUInt16OverflowException(){} // RVA: 0x7FFD53934E00
        public void ThrowInt32OverflowException(){} // RVA: 0x7FFD53934E50
        public void ThrowUInt32OverflowException(){} // RVA: 0x7FFD53934EA0
        public void ThrowInt64OverflowException(){} // RVA: 0x7FFD53934EF0
        public void ThrowUInt64OverflowException(){} // RVA: 0x7FFD53934F40
        public void ToBoolean(){} // RVA: 0x7FFD53935340 | overloaded x18
        public void ToChar(){} // RVA: 0x7FFD53935A20 | overloaded x18
        public void ToSByte(){} // RVA: 0x7FFD5393C170 | overloaded x19
        public void ToByte(){} // RVA: 0x7FFD5393C050 | overloaded x19
        public void ToInt16(){} // RVA: 0x7FFD5393C2C0 | overloaded x19
        public void ToUInt16(){} // RVA: 0x7FFD5393C400 | overloaded x19
        public void ToInt32(){} // RVA: 0x7FFD5393C530 | overloaded x19
        public void ToUInt32(){} // RVA: 0x7FFD5393C620 | overloaded x19
        public void ToInt64(){} // RVA: 0x7FFD5393C710 | overloaded x19
        public void ToUInt64(){} // RVA: 0x7FFD5393C800 | overloaded x19
        public void ToSingle(){} // RVA: 0x7FFD53939840 | overloaded x18
        public void ToDouble(){} // RVA: 0x7FFD53939CF0 | overloaded x18
        public void ToDecimal(){} // RVA: 0x7FFD5393A900 | overloaded x18
        public void ToDateTime(){} // RVA: 0x7FFD5393B140 | overloaded x18
        public void ToString(){} // RVA: 0x7FFD5393CAA0 | overloaded x36
        public void ToBase64String(){} // RVA: 0x7FFD5393CFD0 | overloaded x5
        public void ToBase64CharArray(){} // RVA: 0x7FFD5393D220 | overloaded x2
        public void ConvertToBase64Array(){} // RVA: 0x7FFD5393D670
        public void ToBase64_CalculateAndValidateOutputLength(){} // RVA: 0x7FFD5393D9D0
        public void FromBase64String(){} // RVA: 0x7FFD5393DAC0
        public void TryFromBase64Chars(){} // RVA: 0x7FFD5393DB70
        public void CopyToTempBufferWithoutWhiteSpace(){} // RVA: 0x7FFD5393E1E0
        public void IsSpace(){} // RVA: 0x7FFD5393E310
        public void FromBase64CharArray(){} // RVA: 0x7FFD5393E340
        public void FromBase64CharPtr(){} // RVA: 0x7FFD5393E570
        public void FromBase64_ComputeResultLength(){} // RVA: 0x7FFD5393E7D0
        public void .cctor(){} // RVA: 0x7FFD5393E890
    }

    public class Converter`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class CultureAwareComparer : StringComparer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53A6D940 | overloaded x3
        public void Compare(){} // RVA: 0x7FFD53A6DC40
        public void Equals(){} // RVA: 0x7FFD53A6DD80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53A6DE20 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFD53A6DE60
    }

}