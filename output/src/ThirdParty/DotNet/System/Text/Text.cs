// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text
// Classes: 43
// Methods: 679

namespace ThirdParty.DotNet.System.Text
{
    public class ASCIIEncoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86E5570
        public void SetDefaultFallbacks(){} // RVA: 0x7FFAF86E5590
        public void GetByteCount(){} // RVA: 0x7FFAF86E6900 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFAF86E6CA0 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFAF86E7240 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFAF86E73E0 | overloaded x3
        public void GetString(){} // RVA: 0x7FFAF86E6720
        public void GetMaxByteCount(){} // RVA: 0x7FFAF86E7770
        public void GetMaxCharCount(){} // RVA: 0x7FFAF86E78B0
        public void get_IsSingleByte(){} // RVA: 0x7FFAF2E72850
        public void GetDecoder(){} // RVA: 0x7FFAF86E79F0
        public void GetEncoder(){} // RVA: 0x7FFAF86E7A50
        public void .cctor(){} // RVA: 0x7FFAF86E7AB0
    }

    public class Decoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Fallback(){} // RVA: 0x7FFAF2DA8380
        public void get_FallbackBuffer(){} // RVA: 0x7FFAF86E7C30
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x7FFAF47EB060
        public void Reset(){} // RVA: 0x7FFAF86E7D60
        public void GetCharCount(){} // RVA: 0x7FFAF86E7E70 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFAF86E8280 | overloaded x4
        public void Convert(){} // RVA: 0x7FFAF86E87B0 | overloaded x2
    }

    public class DecoderExceptionFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAF86E9210
        public void get_MaxCharCount(){} // RVA: 0x7FFAF2FC9240
        public void Equals(){} // RVA: 0x7FFAF86E9250
        public void GetHashCode(){} // RVA: 0x7FFAF86E92B0
    }

    public class DecoderExceptionFallbackBuffer
    {
        // ── Methods ──
        public void Fallback(){} // RVA: 0x7FFAF86E92C0
        public void GetNextChar(){} // RVA: 0x7FFAF2FC9240
        public void get_Remaining(){} // RVA: 0x7FFAF2FC9240
        public void Throw(){} // RVA: 0x7FFAF86E92D0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DecoderFallback
    {
        // ── Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x7FFAF86E95F0
        public void get_ExceptionFallback(){} // RVA: 0x7FFAF86E96C0
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAF2ABCD60
        public void get_MaxCharCount(){} // RVA: 0x7FFAF2ABD840
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DecoderFallbackBuffer
    {
        // ── Methods ──
        public void Fallback(){} // RVA: 0x7FFAF2AC0840
        public void GetNextChar(){} // RVA: 0x7FFAF2ABCC90
        public void get_Remaining(){} // RVA: 0x7FFAF2ABD840
        public void Reset(){} // RVA: 0x7FFAF86E9750
        public void InternalReset(){} // RVA: 0x7FFAF86E9790
        public void InternalInitialize(){} // RVA: 0x7FFAF86E97B0
        public void InternalFallback(){} // RVA: 0x7FFAF86E9A10 | overloaded x2
        public void ThrowLastBytesRecursive(){} // RVA: 0x7FFAF86E9C50
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DecoderFallbackException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86E95D0 | overloaded x3
    }

    public class DecoderNLS
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86E9E60
        public void Reset(){} // RVA: 0x7FFAF86E9F40
        public void GetCharCount(){} // RVA: 0x7FFAF86EA180 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFAF86EA5D0 | overloaded x3
        public void Convert(){} // RVA: 0x7FFAF86EAAB0 | overloaded x2
        public void get_MustFlush(){} // RVA: 0x7FFAF3198A80
        public void get_HasState(){} // RVA: 0x7FFAF2D8D320
        public void ClearMustFlush(){} // RVA: 0x7FFAF48E2400
    }

    public class DecoderReplacementFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86EB020 | overloaded x3
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF86EADE0
        public void get_DefaultString(){} // RVA: 0x7FFAF2DA8380
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAF86EB1C0
        public void get_MaxCharCount(){} // RVA: 0x7FFAF86EB260
        public void Equals(){} // RVA: 0x7FFAF86EB280
        public void GetHashCode(){} // RVA: 0x7FFAF344E0E0
    }

    public class DecoderReplacementFallbackBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86EB330
        public void Fallback(){} // RVA: 0x7FFAF86EB3A0
        public void GetNextChar(){} // RVA: 0x7FFAF86EB3F0
        public void get_Remaining(){} // RVA: 0x7FFAF86EB450
        public void Reset(){} // RVA: 0x7FFAF86EB460
        public void InternalFallback(){} // RVA: 0x7FFAF86EB480
    }

    public class Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Fallback(){} // RVA: 0x7FFAF2DA8380
        public void get_FallbackBuffer(){} // RVA: 0x7FFAF86EB4A0
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x7FFAF47EB060
        public void Reset(){} // RVA: 0x7FFAF86EB5D0
        public void GetByteCount(){} // RVA: 0x7FFAF86EB6C0 | overloaded x2
        public void GetBytes(){} // RVA: 0x7FFAF86EB870 | overloaded x2
        public void Convert(){} // RVA: 0x7FFAF86EBEB0 | overloaded x2
    }

    public class EncoderExceptionFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAF86ECB20
        public void get_MaxCharCount(){} // RVA: 0x7FFAF2FC9240
        public void Equals(){} // RVA: 0x7FFAF86ECB60
        public void GetHashCode(){} // RVA: 0x7FFAF86ECBC0
    }

    public class EncoderExceptionFallbackBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Fallback(){} // RVA: 0x7FFAF86ECCA0 | overloaded x2
        public void GetNextChar(){} // RVA: 0x7FFAF2FC9240
        public void MovePrevious(){} // RVA: 0x7FFAF2D8D320
        public void get_Remaining(){} // RVA: 0x7FFAF2FC9240
    }

    public class EncoderFallback
    {
        // ── Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x7FFAF86ED240
        public void get_ExceptionFallback(){} // RVA: 0x7FFAF86ED310
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAF2ABCD60
        public void get_MaxCharCount(){} // RVA: 0x7FFAF2ABD840
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class EncoderFallbackBuffer
    {
        // ── Methods ──
        public void Fallback(){} // overloaded x2
        public void GetNextChar(){} // RVA: 0x7FFAF2ABCC90
        public void MovePrevious(){} // RVA: 0x7FFAF2ABDBE0
        public void get_Remaining(){} // RVA: 0x7FFAF2ABD840
        public void Reset(){} // RVA: 0x7FFAF86ED3A0
        public void InternalReset(){} // RVA: 0x7FFAF86ED3E0
        public void InternalInitialize(){} // RVA: 0x7FFAF86ED400
        public void InternalGetNextChar(){} // RVA: 0x7FFAF86ED470
        public void InternalFallback(){} // RVA: 0x7FFAF86ED4B0
        public void ThrowLastCharRecursive(){} // RVA: 0x7FFAF86ED680
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class EncoderFallbackException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86E95D0 | overloaded x4
    }

    public class EncoderNLS
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86ED720
        public void Reset(){} // RVA: 0x7FFAF86ED800
        public void GetByteCount(){} // RVA: 0x7FFAF86EDA20 | overloaded x2
        public void GetBytes(){} // RVA: 0x7FFAF86EDE30 | overloaded x2
        public void Convert(){} // RVA: 0x7FFAF86EE310 | overloaded x2
        public void get_Encoding(){} // RVA: 0x7FFAF2DBB130
        public void get_MustFlush(){} // RVA: 0x7FFAF2DB3450
        public void get_HasState(){} // RVA: 0x7FFAF86EE4F0
        public void ClearMustFlush(){} // RVA: 0x7FFAF30D05A0
    }

    public class EncoderReplacementFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86EE890 | overloaded x3
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF86EE650
        public void get_DefaultString(){} // RVA: 0x7FFAF2DA8380
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAF86EEA30
        public void get_MaxCharCount(){} // RVA: 0x7FFAF86EB260
        public void Equals(){} // RVA: 0x7FFAF86EEAF0
        public void GetHashCode(){} // RVA: 0x7FFAF344E0E0
    }

    public class EncoderReplacementFallbackBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86EEBA0
        public void Fallback(){} // RVA: 0x7FFAF86EED90 | overloaded x2
        public void GetNextChar(){} // RVA: 0x7FFAF86EEFF0
        public void MovePrevious(){} // RVA: 0x7FFAF86EF050
        public void get_Remaining(){} // RVA: 0x7FFAF86EF070
        public void Reset(){} // RVA: 0x7FFAF86EF080
    }

    public class Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8708B60 | overloaded x2
        public void SetDefaultFallbacks(){} // RVA: 0x7FFAF8708BE0
        public void OnDeserializing(){} // RVA: 0x7FFAF8708DA0 | overloaded x2
        public void OnDeserialized(){} // RVA: 0x7FFAF8708E50 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFAF515D280
        public void DeserializeEncoding(){} // RVA: 0x7FFAF8708EE0
        public void SerializeEncoding(){} // RVA: 0x7FFAF87093A0
        public void Convert(){} // RVA: 0x7FFAF8709670 | overloaded x2
        public void get_InternalSyncObject(){} // RVA: 0x7FFAF87097D0
        public void GetEncoding(){} // RVA: 0x7FFAF870A700 | overloaded x3
        public void GetPreamble(){} // RVA: 0x7FFAF870A860
        public void get_Preamble(){} // RVA: 0x7FFAF870A8C0
        public void GetDataItem(){} // RVA: 0x7FFAF870A970
        public void get_BodyName(){} // RVA: 0x7FFAF870AAE0
        public void get_EncodingName(){} // RVA: 0x7FFAF870AC20
        public void get_HeaderName(){} // RVA: 0x7FFAF870ADA0
        public void get_WebName(){} // RVA: 0x7FFAF870AEE0
        public void get_IsSingleByte(){} // RVA: 0x7FFAF2D8D320
        public void get_EncoderFallback(){} // RVA: 0x7FFAF2DBB130
        public void set_EncoderFallback(){} // RVA: 0x7FFAF870B020
        public void get_DecoderFallback(){} // RVA: 0x7FFAF30E74D0
        public void set_DecoderFallback(){} // RVA: 0x7FFAF870B140
        public void Clone(){} // RVA: 0x7FFAF870B260
        public void get_IsReadOnly(){} // RVA: 0x7FFAF316B3A0
        public void get_ASCII(){} // RVA: 0x7FFAF870B2F0
        public void get_Latin1(){} // RVA: 0x7FFAF870B410
        public void GetByteCount(){} // RVA: 0x7FFAF870D700 | overloaded x7
        public void GetBytes(){} // RVA: 0x7FFAF870D8F0 | overloaded x9
        public void GetCharCount(){} // RVA: 0x7FFAF870D650 | overloaded x5
        public void GetChars(){} // RVA: 0x7FFAF870C4E0 | overloaded x5
        public void GetString(){} // RVA: 0x7FFAF870CB10 | overloaded x4
        public void get_CodePage(){} // RVA: 0x7FFAF2DDA5C0
        public void IsAlwaysNormalized(){} // RVA: 0x7FFAF2D8D320 | overloaded x2
        public void GetDecoder(){} // RVA: 0x7FFAF870C7A0
        public void CreateDefaultEncoding(){} // RVA: 0x7FFAF870C840
        public void setReadOnly(){} // RVA: 0x7FFAF35D65D0
        public void get_Default(){} // RVA: 0x7FFAF870C8A0
        public void GetEncoder(){} // RVA: 0x7FFAF870C9C0
        public void GetMaxByteCount(){} // RVA: 0x7FFAF2AC3FB0
        public void GetMaxCharCount(){} // RVA: 0x7FFAF2AC3FB0
        public void get_Unicode(){} // RVA: 0x7FFAF870CB40
        public void get_BigEndianUnicode(){} // RVA: 0x7FFAF870CC60
        public void get_UTF7(){} // RVA: 0x7FFAF870CD80
        public void get_UTF8(){} // RVA: 0x7FFAF870CEB0
        public void get_UTF32(){} // RVA: 0x7FFAF870CFD0
        public void Equals(){} // RVA: 0x7FFAF870D0E0
        public void GetHashCode(){} // RVA: 0x7FFAF870D1E0
        public void GetBestFitUnicodeToBytesData(){} // RVA: 0x7FFAF870D250
        public void GetBestFitBytesToUnicodeData(){} // RVA: 0x7FFAF870D2B0
        public void ThrowBytesOverflow(){} // RVA: 0x7FFAF870D420 | overloaded x2
        public void ThrowCharsOverflow(){} // RVA: 0x7FFAF870D5C0 | overloaded x2
    }

    public class EncodingHelper
    {
        // ── Methods ──
        public void get_UTF8Unmarked(){} // RVA: 0x7FFAF8711F80
        public void InternalCodePage(){} // RVA: 0x7FFAF8712280
        public void GetDefaultEncoding(){} // RVA: 0x7FFAF8712290
        public void InvokeI18N(){} // RVA: 0x7FFAF87123A0
        public void .cctor(){} // RVA: 0x7FFAF8712A00
    }

    public class EncodingNLS
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86EF0A0
        public void GetByteCount(){} // RVA: 0x7FFAF86EF300 | overloaded x3
        public void GetBytes(){} // RVA: 0x7FFAF86EF980 | overloaded x3
        public void GetCharCount(){} // RVA: 0x7FFAF86EFC70 | overloaded x2
        public void GetChars(){} // RVA: 0x7FFAF86F0040 | overloaded x2
        public void GetString(){} // RVA: 0x7FFAF86F0170
        public void GetDecoder(){} // RVA: 0x7FFAF86F0350
        public void GetEncoder(){} // RVA: 0x7FFAF86F03B0
    }

    public class EncodingProvider
    {
        // ── Methods ──
        public void GetEncoding(){} // RVA: 0x7FFAF86F0410 | overloaded x3
        public void GetEncodingFromProvider(){} // RVA: 0x7FFAF86F0730 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAF86F0850
    }

    public class InternalDecoderBestFitFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86E8A20
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAF86E8A80
        public void get_MaxCharCount(){} // RVA: 0x7FFAF2E7FAF0
        public void Equals(){} // RVA: 0x7FFAF86E8AE0
        public void GetHashCode(){} // RVA: 0x7FFAF86E8BA0
    }

    public class InternalDecoderBestFitFallbackBuffer
    {
        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFAF86E8BD0
        public void .ctor(){} // RVA: 0x7FFAF86E8CA0
        public void Fallback(){} // RVA: 0x7FFAF86E8FC0
        public void GetNextChar(){} // RVA: 0x7FFAF86E9010
        public void get_Remaining(){} // RVA: 0x7FFAF86E9040
        public void Reset(){} // RVA: 0x7FFAF86E9050
        public void InternalFallback(){} // RVA: 0x7FFAF2E7FAF0
        public void TryBestFit(){} // RVA: 0x7FFAF86E9060
    }

    public class InternalEncoderBestFitFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void CreateFallbackBuffer(){} // RVA: 0x7FFAF86EC120
        public void get_MaxCharCount(){} // RVA: 0x7FFAF2E7FAF0
        public void Equals(){} // RVA: 0x7FFAF86EC180
        public void GetHashCode(){} // RVA: 0x7FFAF86E8BA0
    }

    public class InternalEncoderBestFitFallbackBuffer
    {
        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7FFAF86EC270
        public void .ctor(){} // RVA: 0x7FFAF86EC340
        public void Fallback(){} // RVA: 0x7FFAF86EC770 | overloaded x2
        public void GetNextChar(){} // RVA: 0x7FFAF86EC990
        public void MovePrevious(){} // RVA: 0x7FFAF86EC9C0
        public void get_Remaining(){} // RVA: 0x7FFAF86EC9E0
        public void Reset(){} // RVA: 0x7FFAF86EC9F0
        public void TryBestFit(){} // RVA: 0x7FFAF86ECA10
    }

    public class Latin1Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86F0920 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF86F0990
        public void GetByteCount(){} // RVA: 0x7FFAF86F0BC0
        public void GetBytes(){} // RVA: 0x7FFAF86F0E70
        public void GetCharCount(){} // RVA: 0x7FFAF4946C40
        public void GetChars(){} // RVA: 0x7FFAF86F1380
        public void GetMaxByteCount(){} // RVA: 0x7FFAF86F1460
        public void GetMaxCharCount(){} // RVA: 0x7FFAF86F15A0
        public void get_IsSingleByte(){} // RVA: 0x7FFAF2E72850
        public void IsAlwaysNormalized(){} // RVA: 0x7FFAF86F16E0
        public void GetBestFitUnicodeToBytesData(){} // RVA: 0x7FFAF86F16F0
        public void .cctor(){} // RVA: 0x7FFAF86F1750
    }

    public class Normalization
    {
        // ── Methods ──
        public void PropValue(){} // RVA: 0x7FFAF870F540
        public void CharMapIdx(){} // RVA: 0x7FFAF870F630
        public void GetCombiningClass(){} // RVA: 0x7FFAF870F720
        public void GetPrimaryCompositeFromMapIndex(){} // RVA: 0x7FFAF870F7E0
        public void GetPrimaryCompositeHelperIndex(){} // RVA: 0x7FFAF870F8A0
        public void Compose(){} // RVA: 0x7FFAF870F960
        public void Combine(){} // RVA: 0x7FFAF870FCD0 | overloaded x2
        public void CombineHangul(){} // RVA: 0x7FFAF870FF00
        public void Fetch(){} // RVA: 0x7FFAF8710140
        public void TryComposeWithPreviousStarter(){} // RVA: 0x7FFAF8710190
        public void TryCompose(){} // RVA: 0x7FFAF8710580
        public void Decompose(){} // RVA: 0x7FFAF8710790 | overloaded x2
        public void ReorderCanonical(){} // RVA: 0x7FFAF8710910
        public void DecomposeChar(){} // RVA: 0x7FFAF8710BD0
        public void QuickCheck(){} // RVA: 0x7FFAF8710EF0
        public void GetCanonicalHangul(){} // RVA: 0x7FFAF8711030
        public void GetCanonical(){} // RVA: 0x7FFAF8711160
        public void IsNormalized(){} // RVA: 0x7FFAF87115D0 | overloaded x2
        public void Normalize(){} // RVA: 0x7FFAF8711B90 | overloaded x2
        public void load_normalization_resource(){} // RVA: 0x7FFAF8711CA0
        public void .cctor(){} // RVA: 0x7FFAF8711CF0
    }

    public class Rune
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF32E3580 | overloaded x3
        public void get_IsAscii(){} // RVA: 0x7FFAF8D9C2F0
        public void get_IsBmp(){} // RVA: 0x7FFAF8D9C300
        public void op_Equality(){} // RVA: 0x7FFAF4BC0AC0
        public void IsControl(){} // RVA: 0x7FFAF8D9C310
        public void get_ReplacementChar(){} // RVA: 0x7FFAF8D9C320
        public void get_Utf16SequenceLength(){} // RVA: 0x7FFAF8D9C330
        public void get_Value(){} // RVA: 0x7FFAF44189B0
        public void DecodeFromUtf16(){} // RVA: 0x7FFAF92E5020
        public void DecodeFromUtf8(){} // RVA: 0x7FFAF92E5150
        public void Equals(){} // RVA: 0x7FFAF4B86490 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF44189B0
        public void TryCreate(){} // RVA: 0x7FFAF8D9C6E0 | overloaded x2
        public void TryEncodeToUtf16(){} // RVA: 0x7FFAF92E5330
        public void TryEncodeToUtf8(){} // RVA: 0x7FFAF92E5420
        public void UnsafeCreate(){} // RVA: 0x7FFAF4B75210
    }

    public class Rune
    {
        public object DefinedCharsBitmapSpan;
        public object `;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF32E3580 | overloaded x3
        public void get_IsAscii(){} // RVA: 0x7FFAF8D9C2F0
        public void get_IsBmp(){} // RVA: 0x7FFAF8D9C300
        public void op_Equality(){} // RVA: 0x7FFAF4BC0AC0
        public void IsControl(){} // RVA: 0x7FFAF8D9C310
        public void get_ReplacementChar(){} // RVA: 0x7FFAF8D9C320
        public void get_Utf16SequenceLength(){} // RVA: 0x7FFAF8D9C330
        public void get_Value(){} // RVA: 0x7FFAF44189B0
        public void DecodeFromUtf16(){} // RVA: 0x7FFAF8D9C340
        public void DecodeFromUtf8(){} // RVA: 0x7FFAF8D9C4B0
        public void Equals(){} // RVA: 0x7FFAF4B86490 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF44189B0
        public void TryCreate(){} // RVA: 0x7FFAF8D9C6E0 | overloaded x2
        public void TryEncodeToUtf16(){} // RVA: 0x7FFAF8D9C720
        public void TryEncodeToUtf8(){} // RVA: 0x7FFAF8D9C880
        public void UnsafeCreate(){} // RVA: 0x7FFAF4B75210
    }

    public class StringBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86F9920 | overloaded x9
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF86F2350
        public void get_Capacity(){} // RVA: 0x7FFAF86F24A0
        public void set_Capacity(){} // RVA: 0x7FFAF86F24C0
        public void get_MaxCapacity(){} // RVA: 0x7FFAF3241DC0
        public void EnsureCapacity(){} // RVA: 0x7FFAF86F2690
        public void ToString(){} // RVA: 0x7FFAF86F28D0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAF86F2B00
        public void get_Length(){} // RVA: 0x7FFAF86F2B20
        public void set_Length(){} // RVA: 0x7FFAF86F2B30
        public void get_Chars(){} // RVA: 0x7FFAF86F2DE0
        public void set_Chars(){} // RVA: 0x7FFAF86F2EB0
        public void Append(){} // RVA: 0x7FFAF86F7FE0 | overloaded x23
        public void AppendHelper(){} // RVA: 0x7FFAF86F3450
        public void AppendCore(){} // RVA: 0x7FFAF86F3860
        public void AppendLine(){} // RVA: 0x7FFAF86F3AD0 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF86F3D10 | overloaded x2
        public void Insert(){} // RVA: 0x7FFAF86F8190 | overloaded x19
        public void Remove(){} // RVA: 0x7FFAF86F9A40 | overloaded x2
        public void AppendSpanFormattable(){} // RVA: 0x7FFAF2D33FA0
        public void AppendJoin(){} // RVA: 0x7FFAF86F5E20 | overloaded x5
        public void AppendJoinCore(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void AppendFormat(){} // RVA: 0x7FFAF86F6BC0 | overloaded x8
        public void FormatError(){} // RVA: 0x7FFAF86F6CA0
        public void AppendFormatHelper(){} // RVA: 0x7FFAF86F6CF0
        public void Replace(){} // RVA: 0x7FFAF86F7DE0 | overloaded x4
        public void Equals(){} // RVA: 0x7FFAF86F77D0
        public void ReplaceAllInChunk(){} // RVA: 0x7FFAF86F8820
        public void StartsWith(){} // RVA: 0x7FFAF86F8A10
        public void ReplaceInPlaceAtChunk(){} // RVA: 0x7FFAF86F8B00
        public void ThreadSafeCopy(){} // RVA: 0x7FFAF86F8D70 | overloaded x2
        public void FindChunkForIndex(){} // RVA: 0x7FFAF86F8F20
        public void get_RemainingCurrentChunk(){} // RVA: 0x7FFAF86F8F60
        public void Next(){} // RVA: 0x7FFAF86F8FF0
        public void ExpandByABlock(){} // RVA: 0x7FFAF86F9040
        public void MakeRoom(){} // RVA: 0x7FFAF86F93E0
    }

    public class StringBuilderCache
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFAF86F9DA0
        public void Release(){} // RVA: 0x7FFAF86F9E90
        public void GetStringAndRelease(){} // RVA: 0x7FFAF86F9F40
    }

    public class StringBuilderCache
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFAF93C1720
        public void Release(){} // RVA: 0x7FFAF93C1810
        public void GetStringAndRelease(){} // RVA: 0x7FFAF93C18C0
    }

    public class UTF32Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86FA010 | overloaded x3
        public void SetDefaultFallbacks(){} // RVA: 0x7FFAF86FA080
        public void GetByteCount(){} // RVA: 0x7FFAF86FB550 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFAF86FB910 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFAF86FBED0 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFAF86FC220 | overloaded x3
        public void GetString(){} // RVA: 0x7FFAF86FB370
        public void GetSurrogate(){} // RVA: 0x7FFAF86FC7C0
        public void GetHighSurrogate(){} // RVA: 0x7FFAF86FC7E0
        public void GetLowSurrogate(){} // RVA: 0x7FFAF86FC800
        public void GetDecoder(){} // RVA: 0x7FFAF86FC820
        public void GetEncoder(){} // RVA: 0x7FFAF86FC880
        public void GetMaxByteCount(){} // RVA: 0x7FFAF86FC8E0
        public void GetMaxCharCount(){} // RVA: 0x7FFAF86FCA20
        public void GetPreamble(){} // RVA: 0x7FFAF86FCB00
        public void get_Preamble(){} // RVA: 0x7FFAF86FCBC0
        public void Equals(){} // RVA: 0x7FFAF86FCDB0
        public void GetHashCode(){} // RVA: 0x7FFAF86FCE80
        public void .cctor(){} // RVA: 0x7FFAF86FCF30
    }

    public class UTF7Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86FD310 | overloaded x2
        public void MakeTables(){} // RVA: 0x7FFAF86FD360
        public void SetDefaultFallbacks(){} // RVA: 0x7FFAF86FD710
        public void Equals(){} // RVA: 0x7FFAF86FD860
        public void GetHashCode(){} // RVA: 0x7FFAF86FD960
        public void GetByteCount(){} // RVA: 0x7FFAF86FEC80 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFAF86FECC0 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFAF86FF180 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFAF86FF1C0 | overloaded x3
        public void GetString(){} // RVA: 0x7FFAF86FEAA0
        public void GetDecoder(){} // RVA: 0x7FFAF86FF440
        public void GetEncoder(){} // RVA: 0x7FFAF86FF4A0
        public void GetMaxByteCount(){} // RVA: 0x7FFAF86FF500
        public void GetMaxCharCount(){} // RVA: 0x7FFAF86FF5F0
        public void .cctor(){} // RVA: 0x7FFAF86FF680
    }

    public class UTF8Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86FFA40 | overloaded x3
        public void SetDefaultFallbacks(){} // RVA: 0x7FFAF86FFAB0
        public void GetByteCount(){} // RVA: 0x7FFAF8700F80 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFAF87016B0 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFAF8701F40 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFAF8702420 | overloaded x3
        public void GetString(){} // RVA: 0x7FFAF8700DA0
        public void PtrDiff(){} // RVA: 0x7FFAF8701690 | overloaded x2
        public void InRange(){} // RVA: 0x7FFAF87016A0
        public void FallbackInvalidByteSequence(){} // RVA: 0x7FFAF8702D60 | overloaded x2
        public void GetBytesUnknown(){} // RVA: 0x7FFAF8702DB0
        public void GetDecoder(){} // RVA: 0x7FFAF8703020
        public void GetEncoder(){} // RVA: 0x7FFAF8703080
        public void GetMaxByteCount(){} // RVA: 0x7FFAF87030E0
        public void GetMaxCharCount(){} // RVA: 0x7FFAF8703220
        public void GetPreamble(){} // RVA: 0x7FFAF8703360
        public void get_Preamble(){} // RVA: 0x7FFAF8703400
        public void Equals(){} // RVA: 0x7FFAF87035C0
        public void GetHashCode(){} // RVA: 0x7FFAF87036C0
        public void .cctor(){} // RVA: 0x7FFAF8703730
    }

    public class UnicodeEncoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8703B80 | overloaded x3
        public void SetDefaultFallbacks(){} // RVA: 0x7FFAF8703C00
        public void GetByteCount(){} // RVA: 0x7FFAF87050D0 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFAF8705870 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFAF8706200 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFAF8706AA0 | overloaded x3
        public void GetString(){} // RVA: 0x7FFAF8704EF0
        public void GetEncoder(){} // RVA: 0x7FFAF8707590
        public void GetDecoder(){} // RVA: 0x7FFAF87075F0
        public void GetPreamble(){} // RVA: 0x7FFAF8707650
        public void get_Preamble(){} // RVA: 0x7FFAF8707710
        public void GetMaxByteCount(){} // RVA: 0x7FFAF8707900
        public void GetMaxCharCount(){} // RVA: 0x7FFAF8707A40
        public void Equals(){} // RVA: 0x7FFAF8707B90
        public void GetHashCode(){} // RVA: 0x7FFAF8707CD0
        public void .cctor(){} // RVA: 0x7FFAF8707D70
    }

    public class UnicodeUtility
    {
        // ── Methods ──
        public void GetUtf16SequenceLength(){} // RVA: 0x7FFAF8D9C230
        public void GetUtf16SurrogatesFromSupplementaryPlaneScalar(){} // RVA: 0x7FFAF8D9C240
        public void IsAsciiCodePoint(){} // RVA: 0x7FFAF8D9C270
        public void IsBmpCodePoint(){} // RVA: 0x7FFAF8D9C280
        public void IsInRangeInclusive(){} // RVA: 0x7FFAF87016A0
        public void IsSurrogateCodePoint(){} // RVA: 0x7FFAF8D9C290
        public void IsValidUnicodeScalar(){} // RVA: 0x7FFAF8D9C2A0
    }

    public class UnicodeUtility
    {
        // ── Methods ──
        public void GetUtf16SequenceLength(){} // RVA: 0x7FFAF8D9C230
        public void GetUtf16SurrogatesFromSupplementaryPlaneScalar(){} // RVA: 0x7FFAF8D9C240
        public void IsAsciiCodePoint(){} // RVA: 0x7FFAF8D9C270
        public void IsBmpCodePoint(){} // RVA: 0x7FFAF8D9C280
        public void IsInRangeInclusive(){} // RVA: 0x7FFAF87016A0
        public void IsSurrogateCodePoint(){} // RVA: 0x7FFAF8D9C290
        public void IsValidUnicodeScalar(){} // RVA: 0x7FFAF8D9C2A0
    }

    public class ValueStringBuilder
    {
        public object FullName;
        public object IncludeGenericParameters;
        public object IncludeGenericParameterNames;
        public object NestedTypeDelimiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8655860 | overloaded x2
        public void get_Length(){} // RVA: 0x7FFAF306ED50
        public void set_Length(){} // RVA: 0x7FFAF30E74E0
        public void get_Capacity(){} // RVA: 0x7FFAF86559A0
        public void EnsureCapacity(){} // RVA: 0x7FFAF86559E0
        public void GetPinnableReference(){} // RVA: 0x7FFAF8655A70 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAF8655B10
        public void ToString(){} // RVA: 0x7FFAF8655B30
        public void get_RawChars(){} // RVA: 0x7FFAF4A1F090
        public void AsSpan(){} // RVA: 0x7FFAF8655EB0 | overloaded x4
        public void TryCopyTo(){} // RVA: 0x7FFAF8655F90
        public void Insert(){} // RVA: 0x7FFAF8656320 | overloaded x2
        public void Append(){} // RVA: 0x7FFAF8656A50 | overloaded x5
        public void AppendSlow(){} // RVA: 0x7FFAF86566F0
        public void AppendSpan(){} // RVA: 0x7FFAF8656B70
        public void GrowAndAppend(){} // RVA: 0x7FFAF8656C50
        public void Grow(){} // RVA: 0x7FFAF8656C90
        public void Dispose(){} // RVA: 0x7FFAF8656F80
    }

    public class ValueStringBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87080C0
        public void get_Length(){} // RVA: 0x7FFAF306ED50
        public void get_Item(){} // RVA: 0x7FFAF8655B10
        public void ToString(){} // RVA: 0x7FFAF87080D0
        public void TryCopyTo(){} // RVA: 0x7FFAF87081B0
        public void Append(){} // RVA: 0x7FFAF87086A0 | overloaded x4
        public void AppendSlow(){} // RVA: 0x7FFAF8708420
        public void AppendSpan(){} // RVA: 0x7FFAF8708780
        public void GrowAndAppend(){} // RVA: 0x7FFAF8708860
        public void Grow(){} // RVA: 0x7FFAF87088A0
        public void Dispose(){} // RVA: 0x7FFAF8708AA0
    }

    public class ValueStringBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87080C0
        public void get_Length(){} // RVA: 0x7FFAF306ED50
        public void ToString(){} // RVA: 0x7FFAF92E3AE0
        public void TryCopyTo(){} // RVA: 0x7FFAF92E3BC0
        public void Insert(){} // RVA: 0x7FFAF92E3D10
        public void Append(){} // RVA: 0x7FFAF92E42F0 | overloaded x4
        public void AppendSlow(){} // RVA: 0x7FFAF92E4070
        public void AppendSpan(){} // RVA: 0x7FFAF92E43D0
        public void GrowAndAppend(){} // RVA: 0x7FFAF92E44B0
        public void Grow(){} // RVA: 0x7FFAF92E44F0
        public void Dispose(){} // RVA: 0x7FFAF92E46F0
    }

}