// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text
// Classes: 44
// Methods: 463

namespace ThirdParty.DotNet.System.Text
{
    public class ASCIIEncoding : Encoding
    {
        public object s_default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66AD9B0
        public void SetDefaultFallbacks(){} // RVA: 0x66AD9D0
        public void GetByteCount(){} // RVA: 0x66AED10
        public void GetBytes(){} // RVA: 0x66AF0B0
        public void GetCharCount(){} // RVA: 0x66AF670
        public void GetChars(){} // RVA: 0x66AF810
        public void GetString(){} // RVA: 0x66AEB60
        public void GetMaxByteCount(){} // RVA: 0x66AFBA0
        public void GetMaxCharCount(){} // RVA: 0x66AFCE0
        public void get_IsSingleByte(){} // RVA: 0xC2E4C0
        public void GetDecoder(){} // RVA: 0x66AFE20
        public void GetEncoder(){} // RVA: 0x66AFE80
        public void .cctor(){} // RVA: 0x66AFEE0
    }

    public class Decoder : Object
    {
        public object _fallback;
        public object _fallbackBuffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Fallback(){} // RVA: 0xB5DBF0
        public void get_FallbackBuffer(){} // RVA: 0x66B0060
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x25E9250
        public void Reset(){} // RVA: 0x66B0190
        public void GetCharCount(){} // RVA: 0x66B02A0
        public void GetChars(){} // RVA: 0x66B06D0
        public void Convert(){} // RVA: 0x66B0C00
    }

    public class DecoderExceptionFallback : DecoderFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CreateFallbackBuffer(){} // RVA: 0x66B1640
        public void get_MaxCharCount(){} // RVA: 0xDAC980
        public void Equals(){} // RVA: 0x66B1680
        public void GetHashCode(){} // RVA: 0x66B16E0
    }

    public class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
    {
        // ── Methods ──
        public void Fallback(){} // RVA: 0x66B16F0
        public void GetNextChar(){} // RVA: 0xDAC980
        public void get_Remaining(){} // RVA: 0xDAC980
        public void Throw(){} // RVA: 0x66B1700
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DecoderFallback : Object
    {
        public object s_replacementFallback;
        public object s_exceptionFallback;

        // ── Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x66B1A10
        public void get_ExceptionFallback(){} // RVA: 0x66B1AE0
        public void CreateFallbackBuffer(){} // RVA: 0x87C0A0
        public void get_MaxCharCount(){} // RVA: 0x87C130
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DecoderFallbackBuffer : Object
    {
        public object byteStart;
        public object charEnd;

        // ── Methods ──
        public void Fallback(){} // RVA: 0x87FE70
        public void GetNextChar(){} // RVA: 0x87C100
        public void get_Remaining(){} // RVA: 0x87C130
        public void Reset(){} // RVA: 0x66B1B70
        public void InternalReset(){} // RVA: 0x66B1BB0
        public void InternalInitialize(){} // RVA: 0x66B1BD0
        public void InternalFallback(){} // RVA: 0x66B1E20
        public void ThrowLastBytesRecursive(){} // RVA: 0x66B2030
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DecoderFallbackException : ArgumentException
    {
        public object _bytesUnknown;
        public object _index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66B19F0
    }

    public class DecoderNLS : Decoder
    {
        public object _encoding;
        public object _mustFlush;
        public object _throwOnOverflow;
        public object _bytesUsed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66B2240
        public void Reset(){} // RVA: 0x66B2320
        public void GetCharCount(){} // RVA: 0x66B2560
        public void GetChars(){} // RVA: 0x66B29B0
        public void Convert(){} // RVA: 0x66B2E90
        public void get_MustFlush(){} // RVA: 0xF73960
        public void get_HasState(){} // RVA: 0xB43320
        public void ClearMustFlush(){} // RVA: 0x1D9AEF0
    }

    public class DecoderReplacementFallback : DecoderFallback
    {
        public object _strDefault;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66B3400
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x66B31C0
        public void get_DefaultString(){} // RVA: 0xB5DBF0
        public void CreateFallbackBuffer(){} // RVA: 0x66B3580
        public void get_MaxCharCount(){} // RVA: 0x66B3620
        public void Equals(){} // RVA: 0x66B3640
        public void GetHashCode(){} // RVA: 0x1269730
    }

    public class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
    {
        public object _strDefault;
        public object _fallbackCount;
        public object _fallbackIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66B36F0
        public void Fallback(){} // RVA: 0x66B3760
        public void GetNextChar(){} // RVA: 0x66B37B0
        public void get_Remaining(){} // RVA: 0x66B3810
        public void Reset(){} // RVA: 0x66B3820
        public void InternalFallback(){} // RVA: 0x66B3840
    }

    public class Encoder : Object
    {
        public object _fallback;
        public object _fallbackBuffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Fallback(){} // RVA: 0xB5DBF0
        public void get_FallbackBuffer(){} // RVA: 0x66B3860
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x25E9250
        public void Reset(){} // RVA: 0x66B3990
        public void GetByteCount(){} // RVA: 0x66B3A80
        public void GetBytes(){} // RVA: 0x66B3C20
        public void Convert(){} // RVA: 0x66B4270
    }

    public class EncoderExceptionFallback : EncoderFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CreateFallbackBuffer(){} // RVA: 0x66B4E70
        public void get_MaxCharCount(){} // RVA: 0xDAC980
        public void Equals(){} // RVA: 0x66B4EB0
        public void GetHashCode(){} // RVA: 0x66B4F10
    }

    public class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Fallback(){} // RVA: 0x66B4FE0
        public void GetNextChar(){} // RVA: 0xDAC980
        public void MovePrevious(){} // RVA: 0xB43320
        public void get_Remaining(){} // RVA: 0xDAC980
    }

    public class EncoderFallback : Object
    {
        public object s_replacementFallback;
        public object s_exceptionFallback;

        // ── Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x66B54F0
        public void get_ExceptionFallback(){} // RVA: 0x66B55C0
        public void CreateFallbackBuffer(){} // RVA: 0x87C0A0
        public void get_MaxCharCount(){} // RVA: 0x87C130
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EncoderFallbackBuffer : Object
    {
        public object charStart;
        public object charEnd;
        public object encoder;
        public object setEncoder;
        public object bUsedEncoder;
        public object bFallingBack;
        public object iRecursionCount;

        // ── Methods ──
        public void Fallback(){} // RVA: 0x8817F0
        public void GetNextChar(){} // RVA: 0x87C100
        public void MovePrevious(){} // RVA: 0x87D280
        public void get_Remaining(){} // RVA: 0x87C130
        public void Reset(){} // RVA: 0x66B5650
        public void InternalReset(){} // RVA: 0x66B5690
        public void InternalInitialize(){} // RVA: 0x66B56B0
        public void InternalGetNextChar(){} // RVA: 0x66B5720
        public void InternalFallback(){} // RVA: 0x66B5760
        public void ThrowLastCharRecursive(){} // RVA: 0x66B5910
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EncoderFallbackException : ArgumentException
    {
        public object _charUnknown;
        public object _charUnknownHigh;
        public object _charUnknownLow;
        public object _index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66B19F0
    }

    public class EncoderNLS : Encoder
    {
        public object _charLeftOver;
        public object _encoding;
        public object _mustFlush;
        public object _throwOnOverflow;
        public object _charsUsed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66B59A0
        public void Reset(){} // RVA: 0x66B5A80
        public void GetByteCount(){} // RVA: 0x66B5CA0
        public void GetBytes(){} // RVA: 0x66B60B0
        public void Convert(){} // RVA: 0x66B6590
        public void get_Encoding(){} // RVA: 0xB70160
        public void get_MustFlush(){} // RVA: 0xB68DF0
        public void get_HasState(){} // RVA: 0x66B6770
        public void ClearMustFlush(){} // RVA: 0xEAFB80
    }

    public class EncoderReplacementFallback : EncoderFallback
    {
        public object _strDefault;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66B6B10
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x66B68D0
        public void get_DefaultString(){} // RVA: 0xB5DBF0
        public void CreateFallbackBuffer(){} // RVA: 0x66B6C90
        public void get_MaxCharCount(){} // RVA: 0x66B3620
        public void Equals(){} // RVA: 0x66B6D50
        public void GetHashCode(){} // RVA: 0x1269730
    }

    public class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
    {
        public object _strDefault;
        public object _fallbackCount;
        public object _fallbackIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66B6E00
        public void Fallback(){} // RVA: 0x66B6FD0
        public void GetNextChar(){} // RVA: 0x66B71F0
        public void MovePrevious(){} // RVA: 0x66B7250
        public void get_Remaining(){} // RVA: 0x66B7270
        public void Reset(){} // RVA: 0x66B7280
    }

    public class Encoding : Object
    {
        public object defaultEncoding;
        public object unicodeEncoding;
        public object bigEndianUnicode;
        public object utf7Encoding;
        public object utf8Encoding;
        public object utf32Encoding;
        public object asciiEncoding;
        public object latin1Encoding;
        public object encodings;
        public object m_codePage;
        public object dataItem;
        public object m_deserializedFromEverett;
        public object m_isReadOnly;
        public object encoderFallback;
        public object decoderFallback;
        public object s_InternalSyncObject;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66D0C00
        public void SetDefaultFallbacks(){} // RVA: 0x66D0C80
        public void OnDeserializing(){} // RVA: 0x66D0E40
        public void OnDeserialized(){} // RVA: 0x66D0EF0
        public void OnSerializing(){} // RVA: 0x30FBB60
        public void DeserializeEncoding(){} // RVA: 0x66D0F80
        public void SerializeEncoding(){} // RVA: 0x66D14A0
        public void Convert(){} // RVA: 0x66D1B00
        public void get_InternalSyncObject(){} // RVA: 0x66D1C60
        public void GetEncoding(){} // RVA: 0x66D2B30
        public void GetPreamble(){} // RVA: 0x66D2CB0
        public void get_Preamble(){} // RVA: 0x66D2D10
        public void GetDataItem(){} // RVA: 0x66D2DC0
        public void get_BodyName(){} // RVA: 0x66D2F30
        public void get_EncodingName(){} // RVA: 0x66D3070
        public void get_HeaderName(){} // RVA: 0x66D31F0
        public void get_WebName(){} // RVA: 0x66D3330
        public void get_IsSingleByte(){} // RVA: 0xB43320
        public void get_EncoderFallback(){} // RVA: 0xB70160
        public void set_EncoderFallback(){} // RVA: 0x66D3470
        public void get_DecoderFallback(){} // RVA: 0xD33E60
        public void set_DecoderFallback(){} // RVA: 0x66D3590
        public void Clone(){} // RVA: 0x66D36B0
        public void get_IsReadOnly(){} // RVA: 0xF45EE0
        public void get_ASCII(){} // RVA: 0x66D3730
        public void get_Latin1(){} // RVA: 0x66D3850
        public void GetByteCount(){} // RVA: 0x66D5B50
        public void GetBytes(){} // RVA: 0x66D5D40
        public void GetCharCount(){} // RVA: 0x66D5AA0
        public void GetChars(){} // RVA: 0x66D4960
        public void GetString(){} // RVA: 0x66D4F90
        public void get_CodePage(){} // RVA: 0xB8F8F0
        public void IsAlwaysNormalized(){} // RVA: 0xB43320
        public void GetDecoder(){} // RVA: 0x66D4C20
        public void CreateDefaultEncoding(){} // RVA: 0x66D4CC0
        public void setReadOnly(){} // RVA: 0x1AD91E0
        public void get_Default(){} // RVA: 0x66D4D20
        public void GetEncoder(){} // RVA: 0x66D4E40
        public void GetMaxByteCount(){} // RVA: 0x881C20
        public void GetMaxCharCount(){} // RVA: 0x881C20
        public void get_Unicode(){} // RVA: 0x66D4FC0
        public void get_BigEndianUnicode(){} // RVA: 0x66D50E0
        public void get_UTF7(){} // RVA: 0x66D5200
        public void get_UTF8(){} // RVA: 0x66D5330
        public void get_UTF32(){} // RVA: 0x66D5450
        public void Equals(){} // RVA: 0x66D5560
        public void GetHashCode(){} // RVA: 0x66D5630
        public void GetBestFitUnicodeToBytesData(){} // RVA: 0x66D56A0
        public void GetBestFitBytesToUnicodeData(){} // RVA: 0x66D5700
        public void ThrowBytesOverflow(){} // RVA: 0x66D5870
        public void ThrowCharsOverflow(){} // RVA: 0x66D5A10
    }

    public class EncodingHelper : Object
    {
        public object utf8EncodingWithoutMarkers;
        public object lockobj;
        public object i18nAssembly;
        public object i18nDisabled;

        // ── Methods ──
        public void get_UTF8Unmarked(){} // RVA: 0x66DA6D0
        public void InternalCodePage(){} // RVA: 0x66DA9A0
        public void GetDefaultEncoding(){} // RVA: 0x66DA9B0
        public void InvokeI18N(){} // RVA: 0x66DAAC0
        public void .cctor(){} // RVA: 0x66DB0F0
    }

    public class EncodingNLS : Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66B72A0
        public void GetByteCount(){} // RVA: 0x66B7500
        public void GetBytes(){} // RVA: 0x66B7B80
        public void GetCharCount(){} // RVA: 0x66B7E70
        public void GetChars(){} // RVA: 0x66B8240
        public void GetString(){} // RVA: 0x66B8370
        public void GetDecoder(){} // RVA: 0x66B8520
        public void GetEncoder(){} // RVA: 0x66B8580
    }

    public class EncodingProvider : Object
    {
        public object s_InternalSyncObject;
        public object s_providers;

        // ── Methods ──
        public void GetEncoding(){} // RVA: 0x66B85E0
        public void GetEncodingFromProvider(){} // RVA: 0x66B8920
        public void .cctor(){} // RVA: 0x66B8A40
    }

    public class InternalDecoderBestFitFallback : DecoderFallback
    {
        public object _encoding;
        public object _arrayBestFit;
        public object _cReplacement;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66B0E60
        public void CreateFallbackBuffer(){} // RVA: 0x66B0EC0
        public void get_MaxCharCount(){} // RVA: 0xC3CCE0
        public void Equals(){} // RVA: 0x66B0F20
        public void GetHashCode(){} // RVA: 0x66B0FE0
    }

    public class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
    {
        public object _cBestFit;
        public object _iCount;
        public object _iSize;
        public object _oFallback;
        public object s_InternalSyncObject;

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x66B1010
        public void .ctor(){} // RVA: 0x66B10E0
        public void Fallback(){} // RVA: 0x66B13F0
        public void GetNextChar(){} // RVA: 0x66B1440
        public void get_Remaining(){} // RVA: 0x66B1470
        public void Reset(){} // RVA: 0x66B1480
        public void InternalFallback(){} // RVA: 0xC3CCE0
        public void TryBestFit(){} // RVA: 0x66B1490
    }

    public class InternalEncoderBestFitFallback : EncoderFallback
    {
        public object _encoding;
        public object _arrayBestFit;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void CreateFallbackBuffer(){} // RVA: 0x66B44D0
        public void get_MaxCharCount(){} // RVA: 0xC3CCE0
        public void Equals(){} // RVA: 0x66B4530
        public void GetHashCode(){} // RVA: 0x66B0FE0
    }

    public class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
    {
        public object _cBestFit;
        public object _oFallback;
        public object _iCount;
        public object _iSize;
        public object s_InternalSyncObject;

        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x66B45F0
        public void .ctor(){} // RVA: 0x66B46C0
        public void Fallback(){} // RVA: 0x66B4B00
        public void GetNextChar(){} // RVA: 0x66B4CE0
        public void MovePrevious(){} // RVA: 0x66B4D10
        public void get_Remaining(){} // RVA: 0x66B4D30
        public void Reset(){} // RVA: 0x66B4D40
        public void TryBestFit(){} // RVA: 0x66B4D60
    }

    public class Latin1Encoding : EncodingNLS
    {
        public object s_default;
        public object arrayCharBestFit;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66B8B10
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x66B8B80
        public void GetByteCount(){} // RVA: 0x66B8C70
        public void GetBytes(){} // RVA: 0x66B8F20
        public void GetCharCount(){} // RVA: 0x27181F0
        public void GetChars(){} // RVA: 0x66B9450
        public void GetMaxByteCount(){} // RVA: 0x66B9530
        public void GetMaxCharCount(){} // RVA: 0x66B9670
        public void get_IsSingleByte(){} // RVA: 0xC2E4C0
        public void IsAlwaysNormalized(){} // RVA: 0x66B97B0
        public void GetBestFitUnicodeToBytesData(){} // RVA: 0x66B97C0
        public void .cctor(){} // RVA: 0x66B9820
    }

    public class Normalization : Object
    {
        public object props;
        public object mappedChars;
        public object charMapIndex;
        public object helperIndex;
        public object mapIdxToComposite;
        public object combiningClass;
        public object forLock;
        public object isReady;

        // ── Methods ──
        public void PropValue(){} // RVA: 0x66D7DD0
        public void CharMapIdx(){} // RVA: 0x66D7EC0
        public void GetCombiningClass(){} // RVA: 0x66D7FB0
        public void GetPrimaryCompositeFromMapIndex(){} // RVA: 0x66D8070
        public void GetPrimaryCompositeHelperIndex(){} // RVA: 0x66D8130
        public void Compose(){} // RVA: 0x66D81F0
        public void Combine(){} // RVA: 0x66D8560
        public void CombineHangul(){} // RVA: 0x66D8790
        public void Fetch(){} // RVA: 0x66D89D0
        public void TryComposeWithPreviousStarter(){} // RVA: 0x66D8A20
        public void TryCompose(){} // RVA: 0x66D8E10
        public void Decompose(){} // RVA: 0x66D9020
        public void ReorderCanonical(){} // RVA: 0x66D91A0
        public void DecomposeChar(){} // RVA: 0x66D9460
        public void QuickCheck(){} // RVA: 0x66D9780
        public void GetCanonicalHangul(){} // RVA: 0x66D98C0
        public void GetCanonical(){} // RVA: 0x66D99E0
        public void IsNormalized(){} // RVA: 0x66D9E50
        public void Normalize(){} // RVA: 0x66DA310
        public void load_normalization_resource(){} // RVA: 0x66DA420
        public void .cctor(){} // RVA: 0x66DA470
    }

    public class Rune : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
        public void get_IsAscii(){} // RVA: 0x8ECBB0
        public void get_IsBmp(){} // RVA: 0x8ECBC0
        public void op_Equality(){} // RVA: 0x2AFE580
        public void IsControl(){} // RVA: 0x6D590D0
        public void get_ReplacementChar(){} // RVA: 0x6D590E0
        public void get_Utf16SequenceLength(){} // RVA: 0x8ECBD0
        public void get_Value(){} // RVA: 0x77E60
        public void DecodeFromUtf16(){} // RVA: 0x6D59100
        public void DecodeFromUtf8(){} // RVA: 0x6D59260
        public void Equals(){} // RVA: 0x14FC80
        public void GetHashCode(){} // RVA: 0x77E60
        public void TryCreate(){} // RVA: 0x6D59490
        public void TryEncodeToUtf16(){} // RVA: 0x8ECC70
        public void TryEncodeToUtf8(){} // RVA: 0x8ECCA0
        public void UnsafeCreate(){} // RVA: 0x294E720
    }

    public class Rune : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
        public void get_IsAscii(){} // RVA: 0x8ECBB0
        public void get_IsBmp(){} // RVA: 0x8ECBC0
        public void op_Equality(){} // RVA: 0x2AFE580
        public void IsControl(){} // RVA: 0x6D590D0
        public void get_ReplacementChar(){} // RVA: 0x6D590E0
        public void get_Utf16SequenceLength(){} // RVA: 0x8ECBD0
        public void get_Value(){} // RVA: 0x77E60
        public void DecodeFromUtf16(){} // RVA: 0x729AC80
        public void DecodeFromUtf8(){} // RVA: 0x729ADB0
        public void Equals(){} // RVA: 0x14FC80
        public void GetHashCode(){} // RVA: 0x77E60
        public void TryCreate(){} // RVA: 0x6D59490
        public void TryEncodeToUtf16(){} // RVA: 0x90C630
        public void TryEncodeToUtf8(){} // RVA: 0x90C650
        public void UnsafeCreate(){} // RVA: 0x294E720
    }

    public class StringBuilder : Object
    {
        public object m_ChunkChars;
        public object m_ChunkPrevious;
        public object m_ChunkLength;
        public object m_ChunkOffset;
        public object m_MaxCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66C1C00
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x66BA470
        public void get_Capacity(){} // RVA: 0x66BA780
        public void set_Capacity(){} // RVA: 0x66BA7A0
        public void get_MaxCapacity(){} // RVA: 0x1065D50
        public void EnsureCapacity(){} // RVA: 0x66BA970
        public void ToString(){} // RVA: 0x66BAB90
        public void Clear(){} // RVA: 0x66BADD0
        public void get_Length(){} // RVA: 0x66BADF0
        public void set_Length(){} // RVA: 0x66BAE00
        public void get_Chars(){} // RVA: 0x66BB0B0
        public void set_Chars(){} // RVA: 0x66BB180
        public void Append(){} // RVA: 0x66C0260
        public void AppendHelper(){} // RVA: 0x66BB730
        public void AppendCore(){} // RVA: 0x66BBB40
        public void AppendLine(){} // RVA: 0x66BBDB0
        public void CopyTo(){} // RVA: 0x66BBFF0
        public void Insert(){} // RVA: 0x66C0410
        public void Remove(){} // RVA: 0x66C1D20
        public void AppendSpanFormattable(){} // RVA: 0x29CF000
        public void AppendJoin(){} // RVA: 0x66BE0A0
        public void AppendJoinCore(){} // RVA: 0xA94080
        public void AppendFormat(){} // RVA: 0x66BEE20
        public void FormatError(){} // RVA: 0x66BEF00
        public void AppendFormatHelper(){} // RVA: 0x66BEF50
        public void Replace(){} // RVA: 0x66C0060
        public void Equals(){} // RVA: 0x66BFA50
        public void ReplaceAllInChunk(){} // RVA: 0x66C0AD0
        public void StartsWith(){} // RVA: 0x66C0CD0
        public void ReplaceInPlaceAtChunk(){} // RVA: 0x66C0DC0
        public void ThreadSafeCopy(){} // RVA: 0x66C1030
        public void FindChunkForIndex(){} // RVA: 0x66C11E0
        public void get_RemainingCurrentChunk(){} // RVA: 0x66C1220
        public void Next(){} // RVA: 0x66C12B0
        public void ExpandByABlock(){} // RVA: 0x66C1300
        public void MakeRoom(){} // RVA: 0x66C16A0
    }

    public class StringBuilderCache : Object
    {
        public object t_cachedInstance;

        // ── Methods ──
        public void Acquire(){} // RVA: 0x66C2090
        public void Release(){} // RVA: 0x66C2180
        public void GetStringAndRelease(){} // RVA: 0x66C2230
    }

    public class StringBuilderCache : Object
    {
        public object t_cachedInstance;

        // ── Methods ──
        public void Acquire(){} // RVA: 0x73768B0
        public void Release(){} // RVA: 0x73769A0
        public void GetStringAndRelease(){} // RVA: 0x7376A50
    }

    public class StringBuilder[] : Array
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

    public class UTF32Encoding : Encoding
    {
        public object s_default;
        public object s_bigEndianDefault;
        public object s_bigEndianPreamble;
        public object s_littleEndianPreamble;
        public object _emitUTF32ByteOrderMark;
        public object _isThrowException;
        public object _bigEndian;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66C2300
        public void SetDefaultFallbacks(){} // RVA: 0x66C2370
        public void GetByteCount(){} // RVA: 0x66C3810
        public void GetBytes(){} // RVA: 0x66C3BC0
        public void GetCharCount(){} // RVA: 0x66C4180
        public void GetChars(){} // RVA: 0x66C44D0
        public void GetString(){} // RVA: 0x66C3660
        public void GetSurrogate(){} // RVA: 0x66C49E0
        public void GetHighSurrogate(){} // RVA: 0x66C4A00
        public void GetLowSurrogate(){} // RVA: 0x66C4A20
        public void GetDecoder(){} // RVA: 0x66C4A40
        public void GetEncoder(){} // RVA: 0x66C4AA0
        public void GetMaxByteCount(){} // RVA: 0x66C4B00
        public void GetMaxCharCount(){} // RVA: 0x66C4C40
        public void GetPreamble(){} // RVA: 0x66C4D20
        public void get_Preamble(){} // RVA: 0x66C4DE0
        public void Equals(){} // RVA: 0x66C4F90
        public void GetHashCode(){} // RVA: 0x66C5060
        public void .cctor(){} // RVA: 0x66C5110
    }

    public class UTF7Encoding : Encoding
    {
        public object s_default;
        public object _base64Bytes;
        public object _base64Values;
        public object _directEncode;
        public object _allowOptionals;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66C5500
        public void MakeTables(){} // RVA: 0x66C5550
        public void SetDefaultFallbacks(){} // RVA: 0x66C5900
        public void Equals(){} // RVA: 0x66C5A40
        public void GetHashCode(){} // RVA: 0x66C5B10
        public void GetByteCount(){} // RVA: 0x66C6E00
        public void GetBytes(){} // RVA: 0x66C6E40
        public void GetCharCount(){} // RVA: 0x66C7300
        public void GetChars(){} // RVA: 0x66C7340
        public void GetString(){} // RVA: 0x66C6C50
        public void GetDecoder(){} // RVA: 0x66C75D0
        public void GetEncoder(){} // RVA: 0x66C7630
        public void GetMaxByteCount(){} // RVA: 0x66C7690
        public void GetMaxCharCount(){} // RVA: 0x66C7780
        public void .cctor(){} // RVA: 0x66C7810
    }

    public class UTF8Encoding : Encoding
    {
        public object s_default;
        public object s_preamble;
        public object _emitUTF8Identifier;
        public object _isThrowException;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66C7BD0
        public void SetDefaultFallbacks(){} // RVA: 0x66C7C40
        public void GetByteCount(){} // RVA: 0x66C90E0
        public void GetBytes(){} // RVA: 0x66C9810
        public void GetCharCount(){} // RVA: 0x66CA0B0
        public void GetChars(){} // RVA: 0x66CA580
        public void GetString(){} // RVA: 0x66C8F30
        public void PtrDiff(){} // RVA: 0x66C97F0
        public void InRange(){} // RVA: 0x66C9800
        public void FallbackInvalidByteSequence(){} // RVA: 0x66CAEC0
        public void GetBytesUnknown(){} // RVA: 0x66CAF10
        public void GetDecoder(){} // RVA: 0x66CB180
        public void GetEncoder(){} // RVA: 0x66CB1E0
        public void GetMaxByteCount(){} // RVA: 0x66CB240
        public void GetMaxCharCount(){} // RVA: 0x66CB380
        public void GetPreamble(){} // RVA: 0x66CB4C0
        public void get_Preamble(){} // RVA: 0x66CB560
        public void Equals(){} // RVA: 0x66CB6F0
        public void GetHashCode(){} // RVA: 0x66CB7C0
        public void .cctor(){} // RVA: 0x66CB830
    }

    public class UnicodeEncoding : Encoding
    {
        public object s_bigEndianDefault;
        public object s_littleEndianDefault;
        public object s_bigEndianPreamble;
        public object s_littleEndianPreamble;
        public object isThrowException;
        public object bigEndian;
        public object byteOrderMark;
        public object highLowPatternMask;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66CBC80
        public void SetDefaultFallbacks(){} // RVA: 0x66CBD00
        public void GetByteCount(){} // RVA: 0x66CD1A0
        public void GetBytes(){} // RVA: 0x66CD930
        public void GetCharCount(){} // RVA: 0x66CE2D0
        public void GetChars(){} // RVA: 0x66CEB60
        public void GetString(){} // RVA: 0x66CCFF0
        public void GetEncoder(){} // RVA: 0x66CF690
        public void GetDecoder(){} // RVA: 0x66CF6F0
        public void GetPreamble(){} // RVA: 0x66CF750
        public void get_Preamble(){} // RVA: 0x66CF810
        public void GetMaxByteCount(){} // RVA: 0x66CF9C0
        public void GetMaxCharCount(){} // RVA: 0x66CFB00
        public void Equals(){} // RVA: 0x66CFC50
        public void GetHashCode(){} // RVA: 0x66CFD70
        public void .cctor(){} // RVA: 0x66CFE10
    }

    public class UnicodeUtility : Object
    {
        // ── Methods ──
        public void GetUtf16SequenceLength(){} // RVA: 0x6D58FF0
        public void GetUtf16SurrogatesFromSupplementaryPlaneScalar(){} // RVA: 0x6D59000
        public void IsAsciiCodePoint(){} // RVA: 0x6D59030
        public void IsBmpCodePoint(){} // RVA: 0x6D59040
        public void IsInRangeInclusive(){} // RVA: 0x66C9800
        public void IsSurrogateCodePoint(){} // RVA: 0x6D59050
        public void IsValidUnicodeScalar(){} // RVA: 0x6D59060
    }

    public class UnicodeUtility : Object
    {
        // ── Methods ──
        public void GetUtf16SequenceLength(){} // RVA: 0x6D58FF0
        public void GetUtf16SurrogatesFromSupplementaryPlaneScalar(){} // RVA: 0x6D59000
        public void IsAsciiCodePoint(){} // RVA: 0x6D59030
        public void IsBmpCodePoint(){} // RVA: 0x6D59040
        public void IsInRangeInclusive(){} // RVA: 0x66C9800
        public void IsSurrogateCodePoint(){} // RVA: 0x6D59050
        public void IsValidUnicodeScalar(){} // RVA: 0x6D59060
    }

    public class ValueStringBuilder : ValueType
    {
        public object _arrayToReturnToPool;
        public object _chars;
        public object _pos;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8A9490
        public void get_Length(){} // RVA: 0x8E1F0
        public void set_Length(){} // RVA: 0x9E810
        public void get_Capacity(){} // RVA: 0x8A95E0
        public void EnsureCapacity(){} // RVA: 0x8A9620
        public void GetPinnableReference(){} // RVA: 0x8A96C0
        public void get_Item(){} // RVA: 0x8A9760
        public void ToString(){} // RVA: 0x8A9780
        public void get_RawChars(){} // RVA: 0xCB720
        public void AsSpan(){} // RVA: 0x8A9A50
        public void TryCopyTo(){} // RVA: 0x8A9B30
        public void Insert(){} // RVA: 0x8A9C90
        public void Append(){} // RVA: 0x8A9F10
        public void AppendSlow(){} // RVA: 0x8A9D40
        public void AppendSpan(){} // RVA: 0x8A9F30
        public void GrowAndAppend(){} // RVA: 0x8AA010
        public void Grow(){} // RVA: 0x8AA020
        public void Dispose(){} // RVA: 0x8AA030
    }

    public class ValueStringBuilder : ValueType
    {
        public object _arrayToReturnToPool;
        public object _chars;
        public object _pos;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66D0160
        public void get_Length(){} // RVA: 0xE62D00
        public void get_Item(){} // RVA: 0x661E970
        public void ToString(){} // RVA: 0x66D0170
        public void TryCopyTo(){} // RVA: 0x66D0250
        public void Append(){} // RVA: 0x66D0740
        public void AppendSlow(){} // RVA: 0x66D04C0
        public void AppendSpan(){} // RVA: 0x66D0820
        public void GrowAndAppend(){} // RVA: 0x66D0900
        public void Grow(){} // RVA: 0x66D0940
        public void Dispose(){} // RVA: 0x66D0B40
    }

    public class ValueStringBuilder : ValueType
    {
        public object _arrayToReturnToPool;
        public object _chars;
        public object _pos;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66D0160
        public void get_Length(){} // RVA: 0xE62D00
        public void ToString(){} // RVA: 0x7299640
        public void TryCopyTo(){} // RVA: 0x7299720
        public void Insert(){} // RVA: 0x7299870
        public void Append(){} // RVA: 0x7299E50
        public void AppendSlow(){} // RVA: 0x7299BD0
        public void AppendSpan(){} // RVA: 0x7299F30
        public void GrowAndAppend(){} // RVA: 0x729A010
        public void Grow(){} // RVA: 0x729A050
        public void Dispose(){} // RVA: 0x729A250
    }

}