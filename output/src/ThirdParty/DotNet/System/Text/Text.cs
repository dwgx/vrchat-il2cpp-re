// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text
// Classes: 38
// Methods: 621

namespace ThirdParty.DotNet.System.Text
{
    public class ASCIIEncoding : Encoding
    {
        public ASCIIEncodingSealed s_default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867763C0
        public void SetDefaultFallbacks(){} // RVA: 0x7FFE867763E0
        public void GetByteCount(){} // RVA: 0x7FFE86777750 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFE86777AF0 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFE86778090 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFE86778230 | overloaded x3
        public void GetString(){} // RVA: 0x7FFE86777570
        public void GetMaxByteCount(){} // RVA: 0x7FFE867785C0
        public void GetMaxCharCount(){} // RVA: 0x7FFE86778700
        public void get_IsSingleByte(){} // RVA: 0x7FFE811E0850
        public void GetDecoder(){} // RVA: 0x7FFE86778840
        public void GetEncoder(){} // RVA: 0x7FFE867788A0
        public void .cctor(){} // RVA: 0x7FFE86778900
    }

    public class Decoder : Object
    {
        public System.Text.DecoderFallback _fallback; // 0x10
        public System.Text.DecoderFallbackBuffer _fallbackBuffer; // 0x18
        public object field_2; // 0x25D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Fallback(){} // RVA: 0x7FFE81116380
        public void get_FallbackBuffer(){} // RVA: 0x7FFE86778A80
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x7FFE82AC8EE0
        public void Reset(){} // RVA: 0x7FFE86778BB0
        public void GetCharCount(){} // RVA: 0x7FFE86778CC0 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFE867790D0 | overloaded x4
        public void Convert(){} // RVA: 0x7FFE86779600 | overloaded x2
    }

    public class DecoderExceptionFallback : DecoderFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CreateFallbackBuffer(){} // RVA: 0x7FFE8677A060
        public void get_MaxCharCount(){} // RVA: 0x7FFE813240E0
        public void Equals(){} // RVA: 0x7FFE8677A0A0
        public void GetHashCode(){} // RVA: 0x7FFE8677A100
    }

    public class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
    {
        // ── Methods ──
        public void Fallback(){} // RVA: 0x7FFE8677A110
        public void GetNextChar(){} // RVA: 0x7FFE813240E0
        public void get_Remaining(){} // RVA: 0x7FFE813240E0
        public void Throw(){} // RVA: 0x7FFE8677A120
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DecoderFallback : Object
    {
        public System.Text.DecoderFallback s_replacementFallback;
        public System.Text.DecoderFallback s_exceptionFallback; // 0x8
        public object field_2; // 0x265

        // ── Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x7FFE8677A440
        public void get_ExceptionFallback(){} // RVA: 0x7FFE8677A510
        public void CreateFallbackBuffer(){} // RVA: 0x7FFE80E2E2E0
        public void get_MaxCharCount(){} // RVA: 0x7FFE80E2EDB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DecoderFallbackBuffer : Object
    {
        public byte* byteStart; // 0x10

        // ── Methods ──
        public void Fallback(){} // RVA: 0x7FFE80E31D70
        public void GetNextChar(){} // RVA: 0x7FFE80E2E210
        public void get_Remaining(){} // RVA: 0x7FFE80E2EDB0
        public void Reset(){} // RVA: 0x7FFE8677A5A0
        public void InternalReset(){} // RVA: 0x7FFE8677A5E0
        public void InternalInitialize(){} // RVA: 0x7FFE8677A600
        public void InternalFallback(){} // RVA: 0x7FFE8677A860 | overloaded x2
        public void ThrowLastBytesRecursive(){} // RVA: 0x7FFE8677AAA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DecoderFallbackException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8677A420 | overloaded x3
    }

    public class DecoderNLS : Decoder
    {
        public System.Text.Encoding _encoding; // 0x20
        public bool _mustFlush; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8677ACB0
        public void Reset(){} // RVA: 0x7FFE8677AD90
        public void GetCharCount(){} // RVA: 0x7FFE8677AFD0 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFE8677B420 | overloaded x3
        public void Convert(){} // RVA: 0x7FFE8677B900 | overloaded x2
        public void get_MustFlush(){} // RVA: 0x7FFE815F1380
        public void get_HasState(){} // RVA: 0x7FFE810FB320
        public void ClearMustFlush(){} // RVA: 0x7FFE82BBB9A0
    }

    public class DecoderReplacementFallback : DecoderFallback
    {
        public string _strDefault; // 0x10
        public object field_1; // 0x26B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8677BE70 | overloaded x3
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE8677BC30
        public void get_DefaultString(){} // RVA: 0x7FFE81116380
        public void CreateFallbackBuffer(){} // RVA: 0x7FFE8677C010
        public void get_MaxCharCount(){} // RVA: 0x7FFE8677C0B0
        public void Equals(){} // RVA: 0x7FFE8677C0D0
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
    }

    public class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
    {
        public string _strDefault; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8677C180
        public void Fallback(){} // RVA: 0x7FFE8677C1F0
        public void GetNextChar(){} // RVA: 0x7FFE8677C240
        public void get_Remaining(){} // RVA: 0x7FFE8677C2A0
        public void Reset(){} // RVA: 0x7FFE8677C2B0
        public void InternalFallback(){} // RVA: 0x7FFE8677C2D0
    }

    public class Encoder : Object
    {
        public System.Text.EncoderFallback _fallback; // 0x10
        public System.Text.EncoderFallbackBuffer _fallbackBuffer; // 0x18
        public object field_2; // 0x26E

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Fallback(){} // RVA: 0x7FFE81116380
        public void get_FallbackBuffer(){} // RVA: 0x7FFE8677C2F0
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x7FFE82AC8EE0
        public void Reset(){} // RVA: 0x7FFE8677C420
        public void GetByteCount(){} // RVA: 0x7FFE8677C510 | overloaded x2
        public void GetBytes(){} // RVA: 0x7FFE8677C6C0 | overloaded x2
        public void Convert(){} // RVA: 0x7FFE8677CD00 | overloaded x2
    }

    public class EncoderExceptionFallback : EncoderFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CreateFallbackBuffer(){} // RVA: 0x7FFE8677D970
        public void get_MaxCharCount(){} // RVA: 0x7FFE813240E0
        public void Equals(){} // RVA: 0x7FFE8677D9B0
        public void GetHashCode(){} // RVA: 0x7FFE8677DA10
    }

    public class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Fallback(){} // RVA: 0x7FFE8677DAF0 | overloaded x2
        public void GetNextChar(){} // RVA: 0x7FFE813240E0
        public void MovePrevious(){} // RVA: 0x7FFE810FB320
        public void get_Remaining(){} // RVA: 0x7FFE813240E0
    }

    public class EncoderFallback : Object
    {
        public System.Text.EncoderFallback s_replacementFallback;
        public System.Text.EncoderFallback s_exceptionFallback; // 0x8
        public object field_2; // 0x276

        // ── Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x7FFE8677E090
        public void get_ExceptionFallback(){} // RVA: 0x7FFE8677E160
        public void CreateFallbackBuffer(){} // RVA: 0x7FFE80E2E2E0
        public void get_MaxCharCount(){} // RVA: 0x7FFE80E2EDB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EncoderFallbackBuffer : Object
    {
        public char* charStart; // 0x10

        // ── Methods ──
        public void Fallback(){} // overloaded x2
        public void GetNextChar(){} // RVA: 0x7FFE80E2E210
        public void MovePrevious(){} // RVA: 0x7FFE80E2F150
        public void get_Remaining(){} // RVA: 0x7FFE80E2EDB0
        public void Reset(){} // RVA: 0x7FFE8677E1F0
        public void InternalReset(){} // RVA: 0x7FFE8677E230
        public void InternalInitialize(){} // RVA: 0x7FFE8677E250
        public void InternalGetNextChar(){} // RVA: 0x7FFE8677E2C0
        public void InternalFallback(){} // RVA: 0x7FFE8677E300
        public void ThrowLastCharRecursive(){} // RVA: 0x7FFE8677E4D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EncoderFallbackException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8677A420 | overloaded x4
    }

    public class EncoderNLS : Encoder
    {
        public char _charLeftOver; // 0x20
        public System.Text.Encoding _encoding; // 0x28
        public bool _mustFlush; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8677E570
        public void Reset(){} // RVA: 0x7FFE8677E650
        public void GetByteCount(){} // RVA: 0x7FFE8677E870 | overloaded x2
        public void GetBytes(){} // RVA: 0x7FFE8677EC80 | overloaded x2
        public void Convert(){} // RVA: 0x7FFE8677F160 | overloaded x2
        public void get_Encoding(){} // RVA: 0x7FFE81129130
        public void get_MustFlush(){} // RVA: 0x7FFE81121450
        public void get_HasState(){} // RVA: 0x7FFE8677F340
        public void ClearMustFlush(){} // RVA: 0x7FFE8143BA90
    }

    public class EncoderReplacementFallback : EncoderFallback
    {
        public string _strDefault; // 0x10
        public object field_1; // 0x27D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8677F6E0 | overloaded x3
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE8677F4A0
        public void get_DefaultString(){} // RVA: 0x7FFE81116380
        public void CreateFallbackBuffer(){} // RVA: 0x7FFE8677F880
        public void get_MaxCharCount(){} // RVA: 0x7FFE8677C0B0
        public void Equals(){} // RVA: 0x7FFE8677F940
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
    }

    public class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
    {
        public string _strDefault; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8677F9F0
        public void Fallback(){} // RVA: 0x7FFE8677FBE0 | overloaded x2
        public void GetNextChar(){} // RVA: 0x7FFE8677FE40
        public void MovePrevious(){} // RVA: 0x7FFE8677FEA0
        public void get_Remaining(){} // RVA: 0x7FFE8677FEC0
        public void Reset(){} // RVA: 0x7FFE8677FED0
    }

    public class Encoding : Object
    {
        public System.Text.Encoding defaultEncoding;
        public System.Text.Encoding unicodeEncoding; // 0x8
        public System.Text.Encoding bigEndianUnicode; // 0x10
        public System.Text.Encoding utf7Encoding; // 0x18
        public System.Text.Encoding utf8Encoding; // 0x20
        public System.Text.Encoding utf32Encoding; // 0x28
        public System.Text.Encoding asciiEncoding; // 0x30
        public System.Text.Encoding latin1Encoding; // 0x38
        public System.Collections.Generic.Dictionary`2<int,System.Text.Encoding> encodings; // 0x40
        public int MIMECONTF_MAILNEWS;
        public int MIMECONTF_BROWSER;
        public int MIMECONTF_SAVABLE_MAILNEWS;
        public int MIMECONTF_SAVABLE_BROWSER;
        public int CodePageDefault;
        public int CodePageNoOEM;
        public int CodePageNoMac;
        public int CodePageNoThread;
        public int CodePageNoSymbol;
        public int CodePageUnicode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867999C0 | overloaded x2
        public void SetDefaultFallbacks(){} // RVA: 0x7FFE86799A40
        public void OnDeserializing(){} // RVA: 0x7FFE86799C00 | overloaded x2
        public void OnDeserialized(){} // RVA: 0x7FFE86799CB0 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFE8340D8D0
        public void DeserializeEncoding(){} // RVA: 0x7FFE86799D40
        public void SerializeEncoding(){} // RVA: 0x7FFE8679A200
        public void Convert(){} // RVA: 0x7FFE8679A4D0 | overloaded x2
        public void get_InternalSyncObject(){} // RVA: 0x7FFE8679A630
        public void GetEncoding(){} // RVA: 0x7FFE8679B560 | overloaded x3
        public void GetPreamble(){} // RVA: 0x7FFE8679B6C0
        public void get_Preamble(){} // RVA: 0x7FFE8679B720
        public void GetDataItem(){} // RVA: 0x7FFE8679B7D0
        public void get_BodyName(){} // RVA: 0x7FFE8679B940
        public void get_EncodingName(){} // RVA: 0x7FFE8679BA80
        public void get_HeaderName(){} // RVA: 0x7FFE8679BC00
        public void get_WebName(){} // RVA: 0x7FFE8679BD40
        public void get_IsSingleByte(){} // RVA: 0x7FFE810FB320
        public void get_EncoderFallback(){} // RVA: 0x7FFE81129130
        public void set_EncoderFallback(){} // RVA: 0x7FFE8679BE80
        public void get_DecoderFallback(){} // RVA: 0x7FFE8144E200
        public void set_DecoderFallback(){} // RVA: 0x7FFE8679BFA0
        public void Clone(){} // RVA: 0x7FFE8679C0C0
        public void get_IsReadOnly(){} // RVA: 0x7FFE814B5BF0
        public void get_ASCII(){} // RVA: 0x7FFE8679C150
        public void get_Latin1(){} // RVA: 0x7FFE8679C270
        public void GetByteCount(){} // RVA: 0x7FFE8679E560 | overloaded x7
        public void GetBytes(){} // RVA: 0x7FFE8679E750 | overloaded x9
        public void GetCharCount(){} // RVA: 0x7FFE8679E4B0 | overloaded x5
        public void GetChars(){} // RVA: 0x7FFE8679D340 | overloaded x5
        public void GetString(){} // RVA: 0x7FFE8679D970 | overloaded x4
        public void get_CodePage(){} // RVA: 0x7FFE811485C0
        public void IsAlwaysNormalized(){} // RVA: 0x7FFE810FB320 | overloaded x2
        public void GetDecoder(){} // RVA: 0x7FFE8679D600
        public void CreateDefaultEncoding(){} // RVA: 0x7FFE8679D6A0
        public void setReadOnly(){} // RVA: 0x7FFE818933B0
        public void get_Default(){} // RVA: 0x7FFE8679D700
        public void GetEncoder(){} // RVA: 0x7FFE8679D820
        public void GetMaxByteCount(){} // RVA: 0x7FFE80E35520
        public void GetMaxCharCount(){} // RVA: 0x7FFE80E35520
        public void get_Unicode(){} // RVA: 0x7FFE8679D9A0
        public void get_BigEndianUnicode(){} // RVA: 0x7FFE8679DAC0
        public void get_UTF7(){} // RVA: 0x7FFE8679DBE0
        public void get_UTF8(){} // RVA: 0x7FFE8679DD10
        public void get_UTF32(){} // RVA: 0x7FFE8679DE30
        public void Equals(){} // RVA: 0x7FFE8679DF40
        public void GetHashCode(){} // RVA: 0x7FFE8679E040
        public void GetBestFitUnicodeToBytesData(){} // RVA: 0x7FFE8679E0B0
        public void GetBestFitBytesToUnicodeData(){} // RVA: 0x7FFE8679E110
        public void ThrowBytesOverflow(){} // RVA: 0x7FFE8679E280 | overloaded x2
        public void ThrowCharsOverflow(){} // RVA: 0x7FFE8679E420 | overloaded x2
    }

    public class EncodingHelper : Object
    {
        public System.Text.Encoding utf8EncodingWithoutMarkers;

        // ── Methods ──
        public void get_UTF8Unmarked(){} // RVA: 0x7FFE867A2DE0
        public void InternalCodePage(){} // RVA: 0x7FFE867A30E0
        public void GetDefaultEncoding(){} // RVA: 0x7FFE867A30F0
        public void InvokeI18N(){} // RVA: 0x7FFE867A3200
        public void .cctor(){} // RVA: 0x7FFE867A38A0
    }

    public class EncodingNLS : Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8677FEF0
        public void GetByteCount(){} // RVA: 0x7FFE86780150 | overloaded x3
        public void GetBytes(){} // RVA: 0x7FFE867807D0 | overloaded x3
        public void GetCharCount(){} // RVA: 0x7FFE86780AC0 | overloaded x2
        public void GetChars(){} // RVA: 0x7FFE86780E90 | overloaded x2
        public void GetString(){} // RVA: 0x7FFE86780FC0
        public void GetDecoder(){} // RVA: 0x7FFE867811A0
        public void GetEncoder(){} // RVA: 0x7FFE86781200
    }

    public class EncodingProvider : Object
    {
        // ── Methods ──
        public void GetEncoding(){} // RVA: 0x7FFE86781260 | overloaded x3
        public void GetEncodingFromProvider(){} // RVA: 0x7FFE86781580 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFE867816A0
    }

    public class InternalDecoderBestFitFallback : DecoderFallback
    {
        public System.Text.Encoding _encoding; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86779870
        public void CreateFallbackBuffer(){} // RVA: 0x7FFE867798D0
        public void get_MaxCharCount(){} // RVA: 0x7FFE811EDAF0
        public void Equals(){} // RVA: 0x7FFE86779930
        public void GetHashCode(){} // RVA: 0x7FFE867799F0
    }

    public class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
    {
        public char _cBestFit; // 0x20
        public int _iCount; // 0x24

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFE86779A20
        public void .ctor(){} // RVA: 0x7FFE86779AF0
        public void Fallback(){} // RVA: 0x7FFE86779E10
        public void GetNextChar(){} // RVA: 0x7FFE86779E60
        public void get_Remaining(){} // RVA: 0x7FFE86779E90
        public void Reset(){} // RVA: 0x7FFE86779EA0
        public void InternalFallback(){} // RVA: 0x7FFE811EDAF0
        public void TryBestFit(){} // RVA: 0x7FFE86779EB0
    }

    public class InternalEncoderBestFitFallback : EncoderFallback
    {
        public System.Text.Encoding _encoding; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void CreateFallbackBuffer(){} // RVA: 0x7FFE8677CF70
        public void get_MaxCharCount(){} // RVA: 0x7FFE811EDAF0
        public void Equals(){} // RVA: 0x7FFE8677CFD0
        public void GetHashCode(){} // RVA: 0x7FFE867799F0
    }

    public class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
    {
        public char _cBestFit; // 0x30
        public System.Text.InternalEncoderBestFitFallback _oFallback; // 0x38

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFE8677D0C0
        public void .ctor(){} // RVA: 0x7FFE8677D190
        public void Fallback(){} // RVA: 0x7FFE8677D5C0 | overloaded x2
        public void GetNextChar(){} // RVA: 0x7FFE8677D7E0
        public void MovePrevious(){} // RVA: 0x7FFE8677D810
        public void get_Remaining(){} // RVA: 0x7FFE8677D830
        public void Reset(){} // RVA: 0x7FFE8677D840
        public void TryBestFit(){} // RVA: 0x7FFE8677D860
    }

    public class Latin1Encoding : EncodingNLS
    {
        public System.Text.Latin1Encoding s_default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86781770 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE867817E0
        public void GetByteCount(){} // RVA: 0x7FFE86781A10
        public void GetBytes(){} // RVA: 0x7FFE86781CC0
        public void GetCharCount(){} // RVA: 0x7FFE82C203A0
        public void GetChars(){} // RVA: 0x7FFE867821D0
        public void GetMaxByteCount(){} // RVA: 0x7FFE867822B0
        public void GetMaxCharCount(){} // RVA: 0x7FFE867823F0
        public void get_IsSingleByte(){} // RVA: 0x7FFE811E0850
        public void IsAlwaysNormalized(){} // RVA: 0x7FFE86782530
        public void GetBestFitUnicodeToBytesData(){} // RVA: 0x7FFE86782540
        public void .cctor(){} // RVA: 0x7FFE867825A0
    }

    public class Normalization : Object
    {
        // ── Methods ──
        public void PropValue(){} // RVA: 0x7FFE867A03A0
        public void CharMapIdx(){} // RVA: 0x7FFE867A0490
        public void GetCombiningClass(){} // RVA: 0x7FFE867A0580
        public void GetPrimaryCompositeFromMapIndex(){} // RVA: 0x7FFE867A0640
        public void GetPrimaryCompositeHelperIndex(){} // RVA: 0x7FFE867A0700
        public void Compose(){} // RVA: 0x7FFE867A07C0
        public void Combine(){} // RVA: 0x7FFE867A0B30 | overloaded x2
        public void CombineHangul(){} // RVA: 0x7FFE867A0D60
        public void Fetch(){} // RVA: 0x7FFE867A0FA0
        public void TryComposeWithPreviousStarter(){} // RVA: 0x7FFE867A0FF0
        public void TryCompose(){} // RVA: 0x7FFE867A13E0
        public void Decompose(){} // RVA: 0x7FFE867A15F0 | overloaded x2
        public void ReorderCanonical(){} // RVA: 0x7FFE867A1770
        public void DecomposeChar(){} // RVA: 0x7FFE867A1A30
        public void QuickCheck(){} // RVA: 0x7FFE867A1D50
        public void GetCanonicalHangul(){} // RVA: 0x7FFE867A1E90
        public void GetCanonical(){} // RVA: 0x7FFE867A1FC0
        public void IsNormalized(){} // RVA: 0x7FFE867A2430 | overloaded x2
        public void Normalize(){} // RVA: 0x7FFE867A29F0 | overloaded x2
        public void load_normalization_resource(){} // RVA: 0x7FFE867A2B00
        public void .cctor(){} // RVA: 0x7FFE867A2B50
    }

    public class Rune : ValueType
    {
        public uint _value; // 0x10
        public object field_1; // 0x3
        public object field_2; // 0x4
        public object field_3; // 0x5
        public object field_4; // 0x6

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE815BF990 | overloaded x3
        public void get_IsAscii(){} // RVA: 0x7FFE86E2CD20
        public void get_IsBmp(){} // RVA: 0x7FFE86E2CD30
        public void op_Equality(){} // RVA: 0x7FFE835C4F30
        public void IsControl(){} // RVA: 0x7FFE86E2CD40
        public void get_ReplacementChar(){} // RVA: 0x7FFE86E2CD50
        public void get_Utf16SequenceLength(){} // RVA: 0x7FFE86E2CD60
        public void get_Value(){} // RVA: 0x7FFE826F4220
        public void DecodeFromUtf16(){} // RVA: 0x7FFE87374300
        public void DecodeFromUtf8(){} // RVA: 0x7FFE87374430
        public void Equals(){} // RVA: 0x7FFE82E64890 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void TryCreate(){} // RVA: 0x7FFE86E2D110 | overloaded x2
        public void TryEncodeToUtf16(){} // RVA: 0x7FFE87374610
        public void TryEncodeToUtf8(){} // RVA: 0x7FFE87374700
        public void UnsafeCreate(){} // RVA: 0x7FFE82E53610
    }

    public class StringBuilder : Object
    {
        public char[] m_ChunkChars; // 0x10
        public System.Text.StringBuilder m_ChunkPrevious; // 0x18
        public int m_ChunkLength; // 0x20
        public int m_ChunkOffset; // 0x24
        public int m_MaxCapacity; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8678A770 | overloaded x9
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE867831A0
        public void get_Capacity(){} // RVA: 0x7FFE867832F0
        public void set_Capacity(){} // RVA: 0x7FFE86783310
        public void get_MaxCapacity(){} // RVA: 0x7FFE81549710
        public void EnsureCapacity(){} // RVA: 0x7FFE867834E0
        public void ToString(){} // RVA: 0x7FFE86783720 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE86783950
        public void get_Length(){} // RVA: 0x7FFE86783970
        public void set_Length(){} // RVA: 0x7FFE86783980
        public void get_Chars(){} // RVA: 0x7FFE86783C30
        public void set_Chars(){} // RVA: 0x7FFE86783D00
        public void Append(){} // RVA: 0x7FFE86788E30 | overloaded x23
        public void AppendHelper(){} // RVA: 0x7FFE867842A0
        public void AppendCore(){} // RVA: 0x7FFE867846B0
        public void AppendLine(){} // RVA: 0x7FFE86784920 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFE86784B60 | overloaded x2
        public void Insert(){} // RVA: 0x7FFE86788FE0 | overloaded x19
        public void Remove(){} // RVA: 0x7FFE8678A890 | overloaded x2
        public void AppendSpanFormattable(){} // RVA: 0x7FFE810A1420
        public void AppendJoin(){} // RVA: 0x7FFE86786C70 | overloaded x5
        public void AppendJoinCore(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void AppendFormat(){} // RVA: 0x7FFE86787A10 | overloaded x8
        public void FormatError(){} // RVA: 0x7FFE86787AF0
        public void AppendFormatHelper(){} // RVA: 0x7FFE86787B40
        public void Replace(){} // RVA: 0x7FFE86788C30 | overloaded x4
        public void Equals(){} // RVA: 0x7FFE86788620
        public void ReplaceAllInChunk(){} // RVA: 0x7FFE86789670
        public void StartsWith(){} // RVA: 0x7FFE86789860
        public void ReplaceInPlaceAtChunk(){} // RVA: 0x7FFE86789950
        public void ThreadSafeCopy(){} // RVA: 0x7FFE86789BC0 | overloaded x2
        public void FindChunkForIndex(){} // RVA: 0x7FFE86789D70
        public void get_RemainingCurrentChunk(){} // RVA: 0x7FFE86789DB0
        public void Next(){} // RVA: 0x7FFE86789E40
        public void ExpandByABlock(){} // RVA: 0x7FFE86789E90
        public void MakeRoom(){} // RVA: 0x7FFE8678A230
    }

    public class StringBuilderCache : Object
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFE8678ABF0
        public void Release(){} // RVA: 0x7FFE8678ACE0
        public void GetStringAndRelease(){} // RVA: 0x7FFE8678AD90
    }

    public class UTF32Encoding : Encoding
    {
        public System.Text.UTF32Encoding s_default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8678AE60 | overloaded x3
        public void SetDefaultFallbacks(){} // RVA: 0x7FFE8678AED0
        public void GetByteCount(){} // RVA: 0x7FFE8678C3A0 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFE8678C760 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFE8678CD20 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFE8678D070 | overloaded x3
        public void GetString(){} // RVA: 0x7FFE8678C1C0
        public void GetSurrogate(){} // RVA: 0x7FFE8678D610
        public void GetHighSurrogate(){} // RVA: 0x7FFE8678D630
        public void GetLowSurrogate(){} // RVA: 0x7FFE8678D650
        public void GetDecoder(){} // RVA: 0x7FFE8678D670
        public void GetEncoder(){} // RVA: 0x7FFE8678D6D0
        public void GetMaxByteCount(){} // RVA: 0x7FFE8678D730
        public void GetMaxCharCount(){} // RVA: 0x7FFE8678D870
        public void GetPreamble(){} // RVA: 0x7FFE8678D950
        public void get_Preamble(){} // RVA: 0x7FFE8678DA10
        public void Equals(){} // RVA: 0x7FFE8678DC00
        public void GetHashCode(){} // RVA: 0x7FFE8678DCD0
        public void .cctor(){} // RVA: 0x7FFE8678DD80
    }

    public class UTF7Encoding : Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8678E160 | overloaded x2
        public void MakeTables(){} // RVA: 0x7FFE8678E1B0
        public void SetDefaultFallbacks(){} // RVA: 0x7FFE8678E560
        public void Equals(){} // RVA: 0x7FFE8678E6B0
        public void GetHashCode(){} // RVA: 0x7FFE8678E7B0
        public void GetByteCount(){} // RVA: 0x7FFE8678FAD0 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFE8678FB10 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFE8678FFD0 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFE86790010 | overloaded x3
        public void GetString(){} // RVA: 0x7FFE8678F8F0
        public void GetDecoder(){} // RVA: 0x7FFE86790290
        public void GetEncoder(){} // RVA: 0x7FFE867902F0
        public void GetMaxByteCount(){} // RVA: 0x7FFE86790350
        public void GetMaxCharCount(){} // RVA: 0x7FFE86790440
        public void .cctor(){} // RVA: 0x7FFE867904D0
    }

    public class UTF8Encoding : Encoding
    {
        public UTF8EncodingSealed s_default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86790890 | overloaded x3
        public void SetDefaultFallbacks(){} // RVA: 0x7FFE86790900
        public void GetByteCount(){} // RVA: 0x7FFE86791DD0 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFE86792500 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFE86792D90 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFE86793270 | overloaded x3
        public void GetString(){} // RVA: 0x7FFE86791BF0
        public void PtrDiff(){} // RVA: 0x7FFE867924E0 | overloaded x2
        public void InRange(){} // RVA: 0x7FFE867924F0
        public void FallbackInvalidByteSequence(){} // RVA: 0x7FFE86793BB0 | overloaded x2
        public void GetBytesUnknown(){} // RVA: 0x7FFE86793C00
        public void GetDecoder(){} // RVA: 0x7FFE86793E70
        public void GetEncoder(){} // RVA: 0x7FFE86793ED0
        public void GetMaxByteCount(){} // RVA: 0x7FFE86793F30
        public void GetMaxCharCount(){} // RVA: 0x7FFE86794070
        public void GetPreamble(){} // RVA: 0x7FFE867941B0
        public void get_Preamble(){} // RVA: 0x7FFE86794250
        public void Equals(){} // RVA: 0x7FFE86794410
        public void GetHashCode(){} // RVA: 0x7FFE86794510
        public void .cctor(){} // RVA: 0x7FFE86794580
    }

    public class UnicodeEncoding : Encoding
    {
        public System.Text.UnicodeEncoding s_bigEndianDefault;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867949E0 | overloaded x3
        public void SetDefaultFallbacks(){} // RVA: 0x7FFE86794A60
        public void GetByteCount(){} // RVA: 0x7FFE86795F30 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFE867966D0 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFE86797060 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFE86797900 | overloaded x3
        public void GetString(){} // RVA: 0x7FFE86795D50
        public void GetEncoder(){} // RVA: 0x7FFE867983F0
        public void GetDecoder(){} // RVA: 0x7FFE86798450
        public void GetPreamble(){} // RVA: 0x7FFE867984B0
        public void get_Preamble(){} // RVA: 0x7FFE86798570
        public void GetMaxByteCount(){} // RVA: 0x7FFE86798760
        public void GetMaxCharCount(){} // RVA: 0x7FFE867988A0
        public void Equals(){} // RVA: 0x7FFE867989F0
        public void GetHashCode(){} // RVA: 0x7FFE86798B30
        public void .cctor(){} // RVA: 0x7FFE86798BD0
    }

    public class UnicodeUtility : Object
    {
        // ── Methods ──
        public void GetUtf16SequenceLength(){} // RVA: 0x7FFE86E2CC60
        public void GetUtf16SurrogatesFromSupplementaryPlaneScalar(){} // RVA: 0x7FFE86E2CC70
        public void IsAsciiCodePoint(){} // RVA: 0x7FFE86E2CCA0
        public void IsBmpCodePoint(){} // RVA: 0x7FFE86E2CCB0
        public void IsInRangeInclusive(){} // RVA: 0x7FFE867924F0
        public void IsSurrogateCodePoint(){} // RVA: 0x7FFE86E2CCC0
        public void IsValidUnicodeScalar(){} // RVA: 0x7FFE86E2CCD0
    }

    public class ValueStringBuilder : ValueType
    {
        public char[] _arrayToReturnToPool; // 0x10
        public System.Span`1<char> _chars; // 0x18
        public int _pos; // 0x28
        public object field_3; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866E66B0 | overloaded x2
        public void get_Length(){} // RVA: 0x7FFE813DB630
        public void set_Length(){} // RVA: 0x7FFE8144DF00
        public void get_Capacity(){} // RVA: 0x7FFE866E67F0
        public void EnsureCapacity(){} // RVA: 0x7FFE866E6830
        public void GetPinnableReference(){} // RVA: 0x7FFE866E68C0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFE866E6960
        public void ToString(){} // RVA: 0x7FFE866E6980
        public void get_RawChars(){} // RVA: 0x7FFE82CF9F60
        public void AsSpan(){} // RVA: 0x7FFE866E6D00 | overloaded x4
        public void TryCopyTo(){} // RVA: 0x7FFE866E6DE0
        public void Insert(){} // RVA: 0x7FFE866E7170 | overloaded x2
        public void Append(){} // RVA: 0x7FFE866E78A0 | overloaded x5
        public void AppendSlow(){} // RVA: 0x7FFE866E7540
        public void AppendSpan(){} // RVA: 0x7FFE866E79C0
        public void GrowAndAppend(){} // RVA: 0x7FFE866E7AA0
        public void Grow(){} // RVA: 0x7FFE866E7AE0
        public void Dispose(){} // RVA: 0x7FFE866E7DD0
    }

}