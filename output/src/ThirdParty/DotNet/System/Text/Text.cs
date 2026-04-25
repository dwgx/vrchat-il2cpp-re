// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text
// Classes: 38
// Methods: 621

namespace ThirdParty.DotNet.System.Text
{
    public class ASCIIEncoding : Encoding
    {
        public ASCIIEncodingSealed IsSingleByte;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83CCAC0
        public void SetDefaultFallbacks(){} // RVA: 0x7FFAC83CCAE0
        public void GetByteCount(){} // RVA: 0x7FFAC83CDE50 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFAC83CE1F0 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFAC83CE790 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFAC83CE930 | overloaded x3
        public void GetString(){} // RVA: 0x7FFAC83CDC70
        public void GetMaxByteCount(){} // RVA: 0x7FFAC83CECC0
        public void GetMaxCharCount(){} // RVA: 0x7FFAC83CEE00
        public void get_IsSingleByte(){} // RVA: 0x7FFAC3006850
        public void GetDecoder(){} // RVA: 0x7FFAC83CEF40
        public void GetEncoder(){} // RVA: 0x7FFAC83CEFA0
        public void .cctor(){} // RVA: 0x7FFAC83CF000
    }

    public class Decoder : Object
    {
        public System.Text.DecoderFallback Fallback; // 0x10
        public System.Text.DecoderFallbackBuffer FallbackBuffer; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Fallback(){} // RVA: 0x7FFAC2F3C380
        public void get_FallbackBuffer(){} // RVA: 0x7FFAC83CF180
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x7FFAC4860B40
        public void Reset(){} // RVA: 0x7FFAC83CF2B0
        public void GetCharCount(){} // RVA: 0x7FFAC83CF3C0 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFAC83CF7D0 | overloaded x4
        public void Convert(){} // RVA: 0x7FFAC83CFD00 | overloaded x2
    }

    public class DecoderExceptionFallback : DecoderFallback
    {
        public object MaxCharCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAC83D0760
        public void get_MaxCharCount(){} // RVA: 0x7FFAC34F9180
        public void Equals(){} // RVA: 0x7FFAC83D07A0
        public void GetHashCode(){} // RVA: 0x7FFAC83D0800
    }

    public class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
    {
        public object Remaining;

        // ── Methods ──
        public void Fallback(){} // RVA: 0x7FFAC83D0810
        public void GetNextChar(){} // RVA: 0x7FFAC34F9180
        public void get_Remaining(){} // RVA: 0x7FFAC34F9180
        public void Throw(){} // RVA: 0x7FFAC83D0820
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DecoderFallback : Object
    {
        public System.Text.DecoderFallback ReplacementFallback;
        public System.Text.DecoderFallback ExceptionFallback; // 0x8

        // ── Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x7FFAC83D0B40
        public void get_ExceptionFallback(){} // RVA: 0x7FFAC83D0C10
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAC2C58E90
        public void get_MaxCharCount(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DecoderFallbackBuffer : Object
    {
        public byte* Remaining; // 0x10
        public char* charEnd; // 0x18

        // ── Methods ──
        public void Fallback(){} // RVA: 0x7FFAC2C5C920
        public void GetNextChar(){} // RVA: 0x7FFAC2C58DC0
        public void get_Remaining(){} // RVA: 0x7FFAC2C59960
        public void Reset(){} // RVA: 0x7FFAC83D0CA0
        public void InternalReset(){} // RVA: 0x7FFAC83D0CE0
        public void InternalInitialize(){} // RVA: 0x7FFAC83D0D00
        public void InternalFallback(){} // RVA: 0x7FFAC83D0F60 | overloaded x2
        public void ThrowLastBytesRecursive(){} // RVA: 0x7FFAC83D11A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DecoderFallbackException : ArgumentException
    {
        public byte[] _bytesUnknown; // 0x98
        public int _index; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83D0B20 | overloaded x3
    }

    public class DecoderNLS : Decoder
    {
        public System.Text.Encoding MustFlush; // 0x20
        public bool HasState; // 0x28
        public bool _throwOnOverflow; // 0x29
        public int _bytesUsed; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83D13B0
        public void Reset(){} // RVA: 0x7FFAC83D1490
        public void GetCharCount(){} // RVA: 0x7FFAC83D16D0 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFAC83D1B20 | overloaded x3
        public void Convert(){} // RVA: 0x7FFAC83D2000 | overloaded x2
        public void get_MustFlush(){} // RVA: 0x7FFAC30F6BA0
        public void get_HasState(){} // RVA: 0x7FFAC2F21320
        public void ClearMustFlush(){} // RVA: 0x7FFAC494FE90
    }

    public class DecoderReplacementFallback : DecoderFallback
    {
        public string DefaultString; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83D2570 | overloaded x3
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC83D2330
        public void get_DefaultString(){} // RVA: 0x7FFAC2F3C380
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAC83D2710
        public void get_MaxCharCount(){} // RVA: 0x7FFAC83D27B0
        public void Equals(){} // RVA: 0x7FFAC83D27D0
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
    }

    public class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
    {
        public string Remaining; // 0x20
        public int _fallbackCount; // 0x28
        public int _fallbackIndex; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83D2880
        public void Fallback(){} // RVA: 0x7FFAC83D28F0
        public void GetNextChar(){} // RVA: 0x7FFAC83D2940
        public void get_Remaining(){} // RVA: 0x7FFAC83D29A0
        public void Reset(){} // RVA: 0x7FFAC83D29B0
        public void InternalFallback(){} // RVA: 0x7FFAC83D29D0
    }

    public class Encoder : Object
    {
        public System.Text.EncoderFallback Fallback; // 0x10
        public System.Text.EncoderFallbackBuffer FallbackBuffer; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Fallback(){} // RVA: 0x7FFAC2F3C380
        public void get_FallbackBuffer(){} // RVA: 0x7FFAC83D29F0
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x7FFAC4860B40
        public void Reset(){} // RVA: 0x7FFAC83D2B20
        public void GetByteCount(){} // RVA: 0x7FFAC83D2C10 | overloaded x2
        public void GetBytes(){} // RVA: 0x7FFAC83D2DC0 | overloaded x2
        public void Convert(){} // RVA: 0x7FFAC83D3400 | overloaded x2
    }

    public class EncoderExceptionFallback : EncoderFallback
    {
        public object MaxCharCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAC83D4070
        public void get_MaxCharCount(){} // RVA: 0x7FFAC34F9180
        public void Equals(){} // RVA: 0x7FFAC83D40B0
        public void GetHashCode(){} // RVA: 0x7FFAC83D4110
    }

    public class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
    {
        public object Remaining;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Fallback(){} // RVA: 0x7FFAC83D41F0 | overloaded x2
        public void GetNextChar(){} // RVA: 0x7FFAC34F9180
        public void MovePrevious(){} // RVA: 0x7FFAC2F21320
        public void get_Remaining(){} // RVA: 0x7FFAC34F9180
    }

    public class EncoderFallback : Object
    {
        public System.Text.EncoderFallback ReplacementFallback;
        public System.Text.EncoderFallback ExceptionFallback; // 0x8

        // ── Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x7FFAC83D4790
        public void get_ExceptionFallback(){} // RVA: 0x7FFAC83D4860
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAC2C58E90
        public void get_MaxCharCount(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EncoderFallbackBuffer : Object
    {
        public char* Remaining; // 0x10
        public char* charEnd; // 0x18
        public System.Text.EncoderNLS encoder; // 0x20
        public bool setEncoder; // 0x28
        public bool bUsedEncoder; // 0x29
        public bool bFallingBack; // 0x2A
        public int iRecursionCount; // 0x2C

        // ── Methods ──
        public void Fallback(){} // overloaded x2
        public void GetNextChar(){} // RVA: 0x7FFAC2C58DC0
        public void MovePrevious(){} // RVA: 0x7FFAC2C59D00
        public void get_Remaining(){} // RVA: 0x7FFAC2C59960
        public void Reset(){} // RVA: 0x7FFAC83D48F0
        public void InternalReset(){} // RVA: 0x7FFAC83D4930
        public void InternalInitialize(){} // RVA: 0x7FFAC83D4950
        public void InternalGetNextChar(){} // RVA: 0x7FFAC83D49C0
        public void InternalFallback(){} // RVA: 0x7FFAC83D4A00
        public void ThrowLastCharRecursive(){} // RVA: 0x7FFAC83D4BD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EncoderFallbackException : ArgumentException
    {
        public char _charUnknown; // 0x98
        public char _charUnknownHigh; // 0x9A
        public char _charUnknownLow; // 0x9C
        public int _index; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83D0B20 | overloaded x4
    }

    public class EncoderNLS : Encoder
    {
        public char Encoding; // 0x20
        public System.Text.Encoding MustFlush; // 0x28
        public bool HasState; // 0x30
        public bool _throwOnOverflow; // 0x31
        public int _charsUsed; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83D4C70
        public void Reset(){} // RVA: 0x7FFAC83D4D50
        public void GetByteCount(){} // RVA: 0x7FFAC83D4F70 | overloaded x2
        public void GetBytes(){} // RVA: 0x7FFAC83D5380 | overloaded x2
        public void Convert(){} // RVA: 0x7FFAC83D5860 | overloaded x2
        public void get_Encoding(){} // RVA: 0x7FFAC2F4F130
        public void get_MustFlush(){} // RVA: 0x7FFAC2F47450
        public void get_HasState(){} // RVA: 0x7FFAC83D5A40
        public void ClearMustFlush(){} // RVA: 0x7FFAC4269BB0
    }

    public class EncoderReplacementFallback : EncoderFallback
    {
        public string DefaultString; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83D5DE0 | overloaded x3
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC83D5BA0
        public void get_DefaultString(){} // RVA: 0x7FFAC2F3C380
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAC83D5F80
        public void get_MaxCharCount(){} // RVA: 0x7FFAC83D27B0
        public void Equals(){} // RVA: 0x7FFAC83D6040
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
    }

    public class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
    {
        public string Remaining; // 0x30
        public int _fallbackCount; // 0x38
        public int _fallbackIndex; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83D60F0
        public void Fallback(){} // RVA: 0x7FFAC83D62E0 | overloaded x2
        public void GetNextChar(){} // RVA: 0x7FFAC83D6540
        public void MovePrevious(){} // RVA: 0x7FFAC83D65A0
        public void get_Remaining(){} // RVA: 0x7FFAC83D65C0
        public void Reset(){} // RVA: 0x7FFAC83D65D0
    }

    public class Encoding : Object
    {
        public System.Text.Encoding InternalSyncObject;
        public System.Text.Encoding Preamble; // 0x8
        public System.Text.Encoding BodyName; // 0x10
        public System.Text.Encoding EncodingName; // 0x18
        public System.Text.Encoding HeaderName; // 0x20
        public System.Text.Encoding WebName; // 0x28
        public System.Text.Encoding IsSingleByte; // 0x30
        public System.Text.Encoding EncoderFallback; // 0x38
        public System.Collections.Generic.Dictionary`2<int,System.Text.Encoding> DecoderFallback; // 0x40
        public int IsReadOnly;
        public int ASCII;
        public int Latin1;
        public int CodePage;
        public int Default;
        public int Unicode;
        public int BigEndianUnicode;
        public int UTF7;
        public int UTF8;
        public int UTF32;
        public int CodePageBigEndian;
        public int CodePageWindows1252;
        public int CodePageMacGB2312;
        public int CodePageGB2312;
        public int CodePageMacKorean;
        public int CodePageDLLKorean;
        public int ISO2022JP;
        public int ISO2022JPESC;
        public int ISO2022JPSISO;
        public int ISOKorean;
        public int ISOSimplifiedCN;
        public int EUCJP;
        public int ChineseHZ;
        public int DuplicateEUCCN;
        public int EUCCN;
        public int EUCKR;
        public int CodePageASCII;
        public int ISO_8859_1;
        public int ISCIIAssemese;
        public int ISCIIBengali;
        public int ISCIIDevanagari;
        public int ISCIIGujarathi;
        public int ISCIIKannada;
        public int ISCIIMalayalam;
        public int ISCIIOriya;
        public int ISCIIPanjabi;
        public int ISCIITamil;
        public int ISCIITelugu;
        public int GB18030;
        public int ISO_8859_8I;
        public int ISO_8859_8_Visual;
        public int ENC50229;
        public int CodePageUTF7;
        public int CodePageUTF8;
        public int CodePageUTF32;
        public int CodePageUTF32BE;
        public int m_codePage; // 0x10
        public System.Globalization.CodePageDataItem dataItem; // 0x18
        public bool m_deserializedFromEverett; // 0x20
        public bool m_isReadOnly; // 0x21
        public System.Text.EncoderFallback encoderFallback; // 0x28
        public System.Text.DecoderFallback decoderFallback; // 0x30
        public object s_InternalSyncObject; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83F00C0 | overloaded x2
        public void SetDefaultFallbacks(){} // RVA: 0x7FFAC83F0140
        public void OnDeserializing(){} // RVA: 0x7FFAC83F0300 | overloaded x2
        public void OnDeserialized(){} // RVA: 0x7FFAC83F03B0 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFAC515CC20
        public void DeserializeEncoding(){} // RVA: 0x7FFAC83F0440
        public void SerializeEncoding(){} // RVA: 0x7FFAC83F0900
        public void Convert(){} // RVA: 0x7FFAC83F0BD0 | overloaded x2
        public void get_InternalSyncObject(){} // RVA: 0x7FFAC83F0D30
        public void GetEncoding(){} // RVA: 0x7FFAC83F1C60 | overloaded x3
        public void GetPreamble(){} // RVA: 0x7FFAC83F1DC0
        public void get_Preamble(){} // RVA: 0x7FFAC83F1E20
        public void GetDataItem(){} // RVA: 0x7FFAC83F1ED0
        public void get_BodyName(){} // RVA: 0x7FFAC83F2040
        public void get_EncodingName(){} // RVA: 0x7FFAC83F2180
        public void get_HeaderName(){} // RVA: 0x7FFAC83F2300
        public void get_WebName(){} // RVA: 0x7FFAC83F2440
        public void get_IsSingleByte(){} // RVA: 0x7FFAC2F21320
        public void get_EncoderFallback(){} // RVA: 0x7FFAC2F4F130
        public void set_EncoderFallback(){} // RVA: 0x7FFAC83F2580
        public void get_DecoderFallback(){} // RVA: 0x7FFAC31D95E0
        public void set_DecoderFallback(){} // RVA: 0x7FFAC83F26A0
        public void Clone(){} // RVA: 0x7FFAC83F27C0
        public void get_IsReadOnly(){} // RVA: 0x7FFAC322AD20
        public void get_ASCII(){} // RVA: 0x7FFAC83F2850
        public void get_Latin1(){} // RVA: 0x7FFAC83F2970
        public void GetByteCount(){} // RVA: 0x7FFAC83F4C60 | overloaded x7
        public void GetBytes(){} // RVA: 0x7FFAC83F4E50 | overloaded x9
        public void GetCharCount(){} // RVA: 0x7FFAC83F4BB0 | overloaded x5
        public void GetChars(){} // RVA: 0x7FFAC83F3A40 | overloaded x5
        public void GetString(){} // RVA: 0x7FFAC83F4070 | overloaded x4
        public void get_CodePage(){} // RVA: 0x7FFAC2F6E5C0
        public void IsAlwaysNormalized(){} // RVA: 0x7FFAC2F21320 | overloaded x2
        public void GetDecoder(){} // RVA: 0x7FFAC83F3D00
        public void CreateDefaultEncoding(){} // RVA: 0x7FFAC83F3DA0
        public void setReadOnly(){} // RVA: 0x7FFAC376A610
        public void get_Default(){} // RVA: 0x7FFAC83F3E00
        public void GetEncoder(){} // RVA: 0x7FFAC83F3F20
        public void GetMaxByteCount(){} // RVA: 0x7FFAC2C600D0
        public void GetMaxCharCount(){} // RVA: 0x7FFAC2C600D0
        public void get_Unicode(){} // RVA: 0x7FFAC83F40A0
        public void get_BigEndianUnicode(){} // RVA: 0x7FFAC83F41C0
        public void get_UTF7(){} // RVA: 0x7FFAC83F42E0
        public void get_UTF8(){} // RVA: 0x7FFAC83F4410
        public void get_UTF32(){} // RVA: 0x7FFAC83F4530
        public void Equals(){} // RVA: 0x7FFAC83F4640
        public void GetHashCode(){} // RVA: 0x7FFAC83F4740
        public void GetBestFitUnicodeToBytesData(){} // RVA: 0x7FFAC83F47B0
        public void GetBestFitBytesToUnicodeData(){} // RVA: 0x7FFAC83F4810
        public void ThrowBytesOverflow(){} // RVA: 0x7FFAC83F4980 | overloaded x2
        public void ThrowCharsOverflow(){} // RVA: 0x7FFAC83F4B20 | overloaded x2
    }

    public class EncodingHelper : Object
    {
        public System.Text.Encoding UTF8Unmarked;
        public object lockobj; // 0x8
        public System.Reflection.Assembly i18nAssembly; // 0x10
        public bool i18nDisabled; // 0x18

        // ── Methods ──
        public void get_UTF8Unmarked(){} // RVA: 0x7FFAC83F94E0
        public void InternalCodePage(){} // RVA: 0x7FFAC83F97E0
        public void GetDefaultEncoding(){} // RVA: 0x7FFAC83F97F0
        public void InvokeI18N(){} // RVA: 0x7FFAC83F9900
        public void .cctor(){} // RVA: 0x7FFAC83F9F60
    }

    public class EncodingNLS : Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83D65F0
        public void GetByteCount(){} // RVA: 0x7FFAC83D6850 | overloaded x3
        public void GetBytes(){} // RVA: 0x7FFAC83D6ED0 | overloaded x3
        public void GetCharCount(){} // RVA: 0x7FFAC83D71C0 | overloaded x2
        public void GetChars(){} // RVA: 0x7FFAC83D7590 | overloaded x2
        public void GetString(){} // RVA: 0x7FFAC83D76C0
        public void GetDecoder(){} // RVA: 0x7FFAC83D78A0
        public void GetEncoder(){} // RVA: 0x7FFAC83D7900
    }

    public class EncodingProvider : Object
    {
        public object s_InternalSyncObject;
        public System.Text.EncodingProvider[] s_providers; // 0x8

        // ── Methods ──
        public void GetEncoding(){} // RVA: 0x7FFAC83D7960 | overloaded x3
        public void GetEncodingFromProvider(){} // RVA: 0x7FFAC83D7C80 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAC83D7DA0
    }

    public class InternalDecoderBestFitFallback : DecoderFallback
    {
        public System.Text.Encoding MaxCharCount; // 0x10
        public char[] _arrayBestFit; // 0x18
        public char _cReplacement; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83CFF70
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAC83CFFD0
        public void get_MaxCharCount(){} // RVA: 0x7FFAC3013AF0
        public void Equals(){} // RVA: 0x7FFAC83D0030
        public void GetHashCode(){} // RVA: 0x7FFAC83D00F0
    }

    public class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
    {
        public char InternalSyncObject; // 0x20
        public int Remaining; // 0x24
        public int _iSize; // 0x28
        public System.Text.InternalDecoderBestFitFallback _oFallback; // 0x30
        public object s_InternalSyncObject;

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFAC83D0120
        public void .ctor(){} // RVA: 0x7FFAC83D01F0
        public void Fallback(){} // RVA: 0x7FFAC83D0510
        public void GetNextChar(){} // RVA: 0x7FFAC83D0560
        public void get_Remaining(){} // RVA: 0x7FFAC83D0590
        public void Reset(){} // RVA: 0x7FFAC83D05A0
        public void InternalFallback(){} // RVA: 0x7FFAC3013AF0
        public void TryBestFit(){} // RVA: 0x7FFAC83D05B0
    }

    public class InternalEncoderBestFitFallback : EncoderFallback
    {
        public System.Text.Encoding MaxCharCount; // 0x10
        public char[] _arrayBestFit; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAC83D3670
        public void get_MaxCharCount(){} // RVA: 0x7FFAC3013AF0
        public void Equals(){} // RVA: 0x7FFAC83D36D0
        public void GetHashCode(){} // RVA: 0x7FFAC83D00F0
    }

    public class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
    {
        public char InternalSyncObject; // 0x30
        public System.Text.InternalEncoderBestFitFallback Remaining; // 0x38
        public int _iCount; // 0x40
        public int _iSize; // 0x44
        public object s_InternalSyncObject;

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFAC83D37C0
        public void .ctor(){} // RVA: 0x7FFAC83D3890
        public void Fallback(){} // RVA: 0x7FFAC83D3CC0 | overloaded x2
        public void GetNextChar(){} // RVA: 0x7FFAC83D3EE0
        public void MovePrevious(){} // RVA: 0x7FFAC83D3F10
        public void get_Remaining(){} // RVA: 0x7FFAC83D3F30
        public void Reset(){} // RVA: 0x7FFAC83D3F40
        public void TryBestFit(){} // RVA: 0x7FFAC83D3F60
    }

    public class Latin1Encoding : EncodingNLS
    {
        public System.Text.Latin1Encoding IsSingleByte;
        public char[] arrayCharBestFit; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83D7E70 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC83D7EE0
        public void GetByteCount(){} // RVA: 0x7FFAC83D8110
        public void GetBytes(){} // RVA: 0x7FFAC83D83C0
        public void GetCharCount(){} // RVA: 0x7FFAC49B48A0
        public void GetChars(){} // RVA: 0x7FFAC83D88D0
        public void GetMaxByteCount(){} // RVA: 0x7FFAC83D89B0
        public void GetMaxCharCount(){} // RVA: 0x7FFAC83D8AF0
        public void get_IsSingleByte(){} // RVA: 0x7FFAC3006850
        public void IsAlwaysNormalized(){} // RVA: 0x7FFAC83D8C30
        public void GetBestFitUnicodeToBytesData(){} // RVA: 0x7FFAC83D8C40
        public void .cctor(){} // RVA: 0x7FFAC83D8CA0
    }

    public class Normalization : Object
    {
        public byte* props;
        public int* mappedChars; // 0x8
        public short* charMapIndex; // 0x10
        public short* helperIndex; // 0x18
        public ushort* mapIdxToComposite; // 0x20
        public byte* combiningClass; // 0x28
        public object forLock; // 0x30
        public bool isReady; // 0x38

        // ── Methods ──
        public void PropValue(){} // RVA: 0x7FFAC83F6AA0
        public void CharMapIdx(){} // RVA: 0x7FFAC83F6B90
        public void GetCombiningClass(){} // RVA: 0x7FFAC83F6C80
        public void GetPrimaryCompositeFromMapIndex(){} // RVA: 0x7FFAC83F6D40
        public void GetPrimaryCompositeHelperIndex(){} // RVA: 0x7FFAC83F6E00
        public void Compose(){} // RVA: 0x7FFAC83F6EC0
        public void Combine(){} // RVA: 0x7FFAC83F7230 | overloaded x2
        public void CombineHangul(){} // RVA: 0x7FFAC83F7460
        public void Fetch(){} // RVA: 0x7FFAC83F76A0
        public void TryComposeWithPreviousStarter(){} // RVA: 0x7FFAC83F76F0
        public void TryCompose(){} // RVA: 0x7FFAC83F7AE0
        public void Decompose(){} // RVA: 0x7FFAC83F7CF0 | overloaded x2
        public void ReorderCanonical(){} // RVA: 0x7FFAC83F7E70
        public void DecomposeChar(){} // RVA: 0x7FFAC83F8130
        public void QuickCheck(){} // RVA: 0x7FFAC83F8450
        public void GetCanonicalHangul(){} // RVA: 0x7FFAC83F8590
        public void GetCanonical(){} // RVA: 0x7FFAC83F86C0
        public void IsNormalized(){} // RVA: 0x7FFAC83F8B30 | overloaded x2
        public void Normalize(){} // RVA: 0x7FFAC83F90F0 | overloaded x2
        public void load_normalization_resource(){} // RVA: 0x7FFAC83F9200
        public void .cctor(){} // RVA: 0x7FFAC83F9250
    }

    public class Rune : ValueType
    {
        public uint IsAscii; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC336D8B0 | overloaded x3
        public void get_IsAscii(){} // RVA: 0x7FFAC8A83690
        public void get_IsBmp(){} // RVA: 0x7FFAC8A836A0
        public void op_Equality(){} // RVA: 0x7FFAC530E660
        public void IsControl(){} // RVA: 0x7FFAC8A836B0
        public void get_ReplacementChar(){} // RVA: 0x7FFAC8A836C0
        public void get_Utf16SequenceLength(){} // RVA: 0x7FFAC8A836D0
        public void get_Value(){} // RVA: 0x7FFAC4420210
        public void DecodeFromUtf16(){} // RVA: 0x7FFAC8FCBB40
        public void DecodeFromUtf8(){} // RVA: 0x7FFAC8FCBC70
        public void Equals(){} // RVA: 0x7FFAC4BF7E90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void TryCreate(){} // RVA: 0x7FFAC8A83A80 | overloaded x2
        public void TryEncodeToUtf16(){} // RVA: 0x7FFAC8FCBE50
        public void TryEncodeToUtf8(){} // RVA: 0x7FFAC8FCBF40
        public void UnsafeCreate(){} // RVA: 0x7FFAC4BE6C10
    }

    public class StringBuilder : Object
    {
        public char[] Capacity; // 0x10
        public System.Text.StringBuilder MaxCapacity; // 0x18
        public int Length; // 0x20
        public int Chars; // 0x24
        public int RemainingCurrentChunk; // 0x28
        public int DefaultCapacity;
        public string CapacityField;
        public string MaxCapacityField;
        public string StringValueField;
        public string ThreadIDField;
        public int MaxChunkSize;
        public int IndexLimit;
        public int WidthLimit;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83E0E70 | overloaded x9
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC83D98A0
        public void get_Capacity(){} // RVA: 0x7FFAC83D99F0
        public void set_Capacity(){} // RVA: 0x7FFAC83D9A10
        public void get_MaxCapacity(){} // RVA: 0x7FFAC32EC4C0
        public void EnsureCapacity(){} // RVA: 0x7FFAC83D9BE0
        public void ToString(){} // RVA: 0x7FFAC83D9E20 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC83DA050
        public void get_Length(){} // RVA: 0x7FFAC83DA070
        public void set_Length(){} // RVA: 0x7FFAC83DA080
        public void get_Chars(){} // RVA: 0x7FFAC83DA330
        public void set_Chars(){} // RVA: 0x7FFAC83DA400
        public void Append(){} // RVA: 0x7FFAC83DF530 | overloaded x23
        public void AppendHelper(){} // RVA: 0x7FFAC83DA9A0
        public void AppendCore(){} // RVA: 0x7FFAC83DADB0
        public void AppendLine(){} // RVA: 0x7FFAC83DB020 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAC83DB260 | overloaded x2
        public void Insert(){} // RVA: 0x7FFAC83DF6E0 | overloaded x19
        public void Remove(){} // RVA: 0x7FFAC83E0F90 | overloaded x2
        public void AppendSpanFormattable(){} // RVA: 0x7FFAC2E8DC40
        public void AppendJoin(){} // RVA: 0x7FFAC83DD370 | overloaded x5
        public void AppendJoinCore(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void AppendFormat(){} // RVA: 0x7FFAC83DE110 | overloaded x8
        public void FormatError(){} // RVA: 0x7FFAC83DE1F0
        public void AppendFormatHelper(){} // RVA: 0x7FFAC83DE240
        public void Replace(){} // RVA: 0x7FFAC83DF330 | overloaded x4
        public void Equals(){} // RVA: 0x7FFAC83DED20
        public void ReplaceAllInChunk(){} // RVA: 0x7FFAC83DFD70
        public void StartsWith(){} // RVA: 0x7FFAC83DFF60
        public void ReplaceInPlaceAtChunk(){} // RVA: 0x7FFAC83E0050
        public void ThreadSafeCopy(){} // RVA: 0x7FFAC83E02C0 | overloaded x2
        public void FindChunkForIndex(){} // RVA: 0x7FFAC83E0470
        public void get_RemainingCurrentChunk(){} // RVA: 0x7FFAC83E04B0
        public void Next(){} // RVA: 0x7FFAC83E0540
        public void ExpandByABlock(){} // RVA: 0x7FFAC83E0590
        public void MakeRoom(){} // RVA: 0x7FFAC83E0930
    }

    public class StringBuilderCache : Object
    {
        public System.Text.StringBuilder t_cachedInstance; // 0xFFFF

        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFAC83E12F0
        public void Release(){} // RVA: 0x7FFAC83E13E0
        public void GetStringAndRelease(){} // RVA: 0x7FFAC83E1490
    }

    public class UTF32Encoding : Encoding
    {
        public System.Text.UTF32Encoding Preamble;
        public System.Text.UTF32Encoding s_bigEndianDefault; // 0x8
        public byte[] s_bigEndianPreamble; // 0x10
        public byte[] s_littleEndianPreamble; // 0x18
        public bool _emitUTF32ByteOrderMark; // 0x38
        public bool _isThrowException; // 0x39
        public bool _bigEndian; // 0x3A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83E1560 | overloaded x3
        public void SetDefaultFallbacks(){} // RVA: 0x7FFAC83E15D0
        public void GetByteCount(){} // RVA: 0x7FFAC83E2AA0 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFAC83E2E60 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFAC83E3420 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFAC83E3770 | overloaded x3
        public void GetString(){} // RVA: 0x7FFAC83E28C0
        public void GetSurrogate(){} // RVA: 0x7FFAC83E3D10
        public void GetHighSurrogate(){} // RVA: 0x7FFAC83E3D30
        public void GetLowSurrogate(){} // RVA: 0x7FFAC83E3D50
        public void GetDecoder(){} // RVA: 0x7FFAC83E3D70
        public void GetEncoder(){} // RVA: 0x7FFAC83E3DD0
        public void GetMaxByteCount(){} // RVA: 0x7FFAC83E3E30
        public void GetMaxCharCount(){} // RVA: 0x7FFAC83E3F70
        public void GetPreamble(){} // RVA: 0x7FFAC83E4050
        public void get_Preamble(){} // RVA: 0x7FFAC83E4110
        public void Equals(){} // RVA: 0x7FFAC83E4300
        public void GetHashCode(){} // RVA: 0x7FFAC83E43D0
        public void .cctor(){} // RVA: 0x7FFAC83E4480
    }

    public class UTF7Encoding : Encoding
    {
        public System.Text.UTF7Encoding s_default;
        public byte[] _base64Bytes; // 0x38
        public sbyte[] _base64Values; // 0x40
        public bool[] _directEncode; // 0x48
        public bool _allowOptionals; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83E4860 | overloaded x2
        public void MakeTables(){} // RVA: 0x7FFAC83E48B0
        public void SetDefaultFallbacks(){} // RVA: 0x7FFAC83E4C60
        public void Equals(){} // RVA: 0x7FFAC83E4DB0
        public void GetHashCode(){} // RVA: 0x7FFAC83E4EB0
        public void GetByteCount(){} // RVA: 0x7FFAC83E61D0 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFAC83E6210 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFAC83E66D0 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFAC83E6710 | overloaded x3
        public void GetString(){} // RVA: 0x7FFAC83E5FF0
        public void GetDecoder(){} // RVA: 0x7FFAC83E6990
        public void GetEncoder(){} // RVA: 0x7FFAC83E69F0
        public void GetMaxByteCount(){} // RVA: 0x7FFAC83E6A50
        public void GetMaxCharCount(){} // RVA: 0x7FFAC83E6B40
        public void .cctor(){} // RVA: 0x7FFAC83E6BD0
    }

    public class UTF8Encoding : Encoding
    {
        public UTF8EncodingSealed Preamble;
        public byte[] s_preamble; // 0x8
        public bool _emitUTF8Identifier; // 0x38
        public bool _isThrowException; // 0x39

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83E6F90 | overloaded x3
        public void SetDefaultFallbacks(){} // RVA: 0x7FFAC83E7000
        public void GetByteCount(){} // RVA: 0x7FFAC83E84D0 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFAC83E8C00 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFAC83E9490 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFAC83E9970 | overloaded x3
        public void GetString(){} // RVA: 0x7FFAC83E82F0
        public void PtrDiff(){} // RVA: 0x7FFAC83E8BE0 | overloaded x2
        public void InRange(){} // RVA: 0x7FFAC83E8BF0
        public void FallbackInvalidByteSequence(){} // RVA: 0x7FFAC83EA2B0 | overloaded x2
        public void GetBytesUnknown(){} // RVA: 0x7FFAC83EA300
        public void GetDecoder(){} // RVA: 0x7FFAC83EA570
        public void GetEncoder(){} // RVA: 0x7FFAC83EA5D0
        public void GetMaxByteCount(){} // RVA: 0x7FFAC83EA630
        public void GetMaxCharCount(){} // RVA: 0x7FFAC83EA770
        public void GetPreamble(){} // RVA: 0x7FFAC83EA8B0
        public void get_Preamble(){} // RVA: 0x7FFAC83EA950
        public void Equals(){} // RVA: 0x7FFAC83EAB10
        public void GetHashCode(){} // RVA: 0x7FFAC83EAC10
        public void .cctor(){} // RVA: 0x7FFAC83EAC80
    }

    public class UnicodeEncoding : Encoding
    {
        public System.Text.UnicodeEncoding Preamble;
        public System.Text.UnicodeEncoding s_littleEndianDefault; // 0x8
        public byte[] s_bigEndianPreamble; // 0x10
        public byte[] s_littleEndianPreamble; // 0x18
        public bool isThrowException; // 0x38
        public bool bigEndian; // 0x39
        public bool byteOrderMark; // 0x3A
        public ulong highLowPatternMask; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83EB0E0 | overloaded x3
        public void SetDefaultFallbacks(){} // RVA: 0x7FFAC83EB160
        public void GetByteCount(){} // RVA: 0x7FFAC83EC630 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFAC83ECDD0 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFAC83ED760 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFAC83EE000 | overloaded x3
        public void GetString(){} // RVA: 0x7FFAC83EC450
        public void GetEncoder(){} // RVA: 0x7FFAC83EEAF0
        public void GetDecoder(){} // RVA: 0x7FFAC83EEB50
        public void GetPreamble(){} // RVA: 0x7FFAC83EEBB0
        public void get_Preamble(){} // RVA: 0x7FFAC83EEC70
        public void GetMaxByteCount(){} // RVA: 0x7FFAC83EEE60
        public void GetMaxCharCount(){} // RVA: 0x7FFAC83EEFA0
        public void Equals(){} // RVA: 0x7FFAC83EF0F0
        public void GetHashCode(){} // RVA: 0x7FFAC83EF230
        public void .cctor(){} // RVA: 0x7FFAC83EF2D0
    }

    public class UnicodeUtility : Object
    {
        // ── Methods ──
        public void GetUtf16SequenceLength(){} // RVA: 0x7FFAC8A835D0
        public void GetUtf16SurrogatesFromSupplementaryPlaneScalar(){} // RVA: 0x7FFAC8A835E0
        public void IsAsciiCodePoint(){} // RVA: 0x7FFAC8A83610
        public void IsBmpCodePoint(){} // RVA: 0x7FFAC8A83620
        public void IsInRangeInclusive(){} // RVA: 0x7FFAC83E8BF0
        public void IsSurrogateCodePoint(){} // RVA: 0x7FFAC8A83630
        public void IsValidUnicodeScalar(){} // RVA: 0x7FFAC8A83640
    }

    public class ValueStringBuilder : ValueType
    {
        public char[] Length; // 0x10
        public System.Span`1<char> Capacity; // 0x18
        public int Item; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC833CDB0 | overloaded x2
        public void get_Length(){} // RVA: 0x7FFAC3157800
        public void set_Length(){} // RVA: 0x7FFAC392CD10
        public void get_Capacity(){} // RVA: 0x7FFAC833CEF0
        public void EnsureCapacity(){} // RVA: 0x7FFAC833CF30
        public void GetPinnableReference(){} // RVA: 0x7FFAC833CFC0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAC833D060
        public void ToString(){} // RVA: 0x7FFAC833D080
        public void get_RawChars(){} // RVA: 0x7FFAC4A927D0
        public void AsSpan(){} // RVA: 0x7FFAC833D400 | overloaded x4
        public void TryCopyTo(){} // RVA: 0x7FFAC833D4E0
        public void Insert(){} // RVA: 0x7FFAC833D870 | overloaded x2
        public void Append(){} // RVA: 0x7FFAC833DFA0 | overloaded x5
        public void AppendSlow(){} // RVA: 0x7FFAC833DC40
        public void AppendSpan(){} // RVA: 0x7FFAC833E0C0
        public void GrowAndAppend(){} // RVA: 0x7FFAC833E1A0
        public void Grow(){} // RVA: 0x7FFAC833E1E0
        public void Dispose(){} // RVA: 0x7FFAC833E4D0
    }

}