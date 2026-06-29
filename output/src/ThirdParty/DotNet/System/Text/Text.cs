// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text
// Classes: 44
// Methods: 463

namespace ThirdParty.DotNet.System.Text
{
    public class ASCIIEncoding : Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA23590
        public void SetDefaultFallbacks(){} // RVA: 0x7ADA235B0
        public void GetByteCount(){} // RVA: 0x7ADA24920
        public void GetBytes(){} // RVA: 0x7ADA24CC0
        public void GetCharCount(){} // RVA: 0x7ADA25280
        public void GetChars(){} // RVA: 0x7ADA25420
        public void GetString(){} // RVA: 0x7ADA24740
        public void GetMaxByteCount(){} // RVA: 0x7ADA257B0
        public void GetMaxCharCount(){} // RVA: 0x7ADA258F0
        public void get_IsSingleByte(){} // RVA: 0x7A81BD750
        public void GetDecoder(){} // RVA: 0x7ADA25A30
        public void GetEncoder(){} // RVA: 0x7ADA25A90
        public void .cctor(){} // RVA: 0x7ADA25AF0
    }

    public class Decoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Fallback(){} // RVA: 0x7A80F2570
        public void get_FallbackBuffer(){} // RVA: 0x7ADA25C70
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x7A9B3D890
        public void Reset(){} // RVA: 0x7ADA25DA0
        public void GetCharCount(){} // RVA: 0x7ADA25EB0
        public void GetChars(){} // RVA: 0x7ADA262E0
        public void Convert(){} // RVA: 0x7ADA26810
    }

    public class DecoderExceptionFallback : DecoderFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void CreateFallbackBuffer(){} // RVA: 0x7ADA27250
        public void get_MaxCharCount(){} // RVA: 0x7A82D1450
        public void Equals(){} // RVA: 0x7ADA27290
        public void GetHashCode(){} // RVA: 0x7ADA272F0
    }

    public class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
    {
        // ── Methods ──
        public void Fallback(){} // RVA: 0x7ADA27300
        public void GetNextChar(){} // RVA: 0x7A82D1450
        public void get_Remaining(){} // RVA: 0x7A82D1450
        public void Throw(){} // RVA: 0x7ADA27310
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DecoderFallback : Object
    {
        // ── Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x7ADA27630
        public void get_ExceptionFallback(){} // RVA: 0x7ADA27700
        public void CreateFallbackBuffer(){} // RVA: 0x7A7E00680
        public void get_MaxCharCount(){} // RVA: 0x7A7E00710
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DecoderFallbackBuffer : Object
    {
        // ── Methods ──
        public void Fallback(){} // RVA: 0x7A7E039E0
        public void GetNextChar(){} // RVA: 0x7A7E006E0
        public void get_Remaining(){} // RVA: 0x7A7E00710
        public void Reset(){} // RVA: 0x7ADA27790
        public void InternalReset(){} // RVA: 0x7ADA277D0
        public void InternalInitialize(){} // RVA: 0x7ADA277F0
        public void InternalFallback(){} // RVA: 0x7ADA27A50
        public void ThrowLastBytesRecursive(){} // RVA: 0x7ADA27C90
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DecoderFallbackException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA27610
    }

    public class DecoderNLS : Decoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA27EA0
        public void Reset(){} // RVA: 0x7ADA27F80
        public void GetCharCount(){} // RVA: 0x7ADA281C0
        public void GetChars(){} // RVA: 0x7ADA28610
        public void Convert(){} // RVA: 0x7ADA28AF0
        public void get_MustFlush(){} // RVA: 0x7A84A5BD0
        public void get_HasState(){} // RVA: 0x7A80D7320
        public void ClearMustFlush(){} // RVA: 0x7A9C36C50
    }

    public class DecoderReplacementFallback : DecoderFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA29060
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7ADA28E20
        public void get_DefaultString(){} // RVA: 0x7A80F2570
        public void CreateFallbackBuffer(){} // RVA: 0x7ADA29200
        public void get_MaxCharCount(){} // RVA: 0x7ADA292A0
        public void Equals(){} // RVA: 0x7ADA292C0
        public void GetHashCode(){} // RVA: 0x7A8738190
    }

    public class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA29370
        public void Fallback(){} // RVA: 0x7ADA293E0
        public void GetNextChar(){} // RVA: 0x7ADA29430
        public void get_Remaining(){} // RVA: 0x7ADA29490
        public void Reset(){} // RVA: 0x7ADA294A0
        public void InternalFallback(){} // RVA: 0x7ADA294C0
    }

    public class Encoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Fallback(){} // RVA: 0x7A80F2570
        public void get_FallbackBuffer(){} // RVA: 0x7ADA294E0
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x7A9B3D890
        public void Reset(){} // RVA: 0x7ADA29610
        public void GetByteCount(){} // RVA: 0x7ADA29700
        public void GetBytes(){} // RVA: 0x7ADA298A0
        public void Convert(){} // RVA: 0x7ADA29EF0
    }

    public class EncoderExceptionFallback : EncoderFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void CreateFallbackBuffer(){} // RVA: 0x7ADA2AB30
        public void get_MaxCharCount(){} // RVA: 0x7A82D1450
        public void Equals(){} // RVA: 0x7ADA2AB70
        public void GetHashCode(){} // RVA: 0x7ADA2ABD0
    }

    public class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Fallback(){} // RVA: 0x7ADA2ACB0
        public void GetNextChar(){} // RVA: 0x7A82D1450
        public void MovePrevious(){} // RVA: 0x7A80D7320
        public void get_Remaining(){} // RVA: 0x7A82D1450
    }

    public class EncoderFallback : Object
    {
        // ── Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x7ADA2B250
        public void get_ExceptionFallback(){} // RVA: 0x7ADA2B320
        public void CreateFallbackBuffer(){} // RVA: 0x7A7E00680
        public void get_MaxCharCount(){} // RVA: 0x7A7E00710
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class EncoderFallbackBuffer : Object
    {
        // ── Methods ──
        public void Fallback(){} // RVA: 0x7A7E05E70
        public void GetNextChar(){} // RVA: 0x7A7E006E0
        public void MovePrevious(){} // RVA: 0x7A7E01900
        public void get_Remaining(){} // RVA: 0x7A7E00710
        public void Reset(){} // RVA: 0x7ADA2B3B0
        public void InternalReset(){} // RVA: 0x7ADA2B3F0
        public void InternalInitialize(){} // RVA: 0x7ADA2B410
        public void InternalGetNextChar(){} // RVA: 0x7ADA2B480
        public void InternalFallback(){} // RVA: 0x7ADA2B4C0
        public void ThrowLastCharRecursive(){} // RVA: 0x7ADA2B690
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class EncoderFallbackException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA27610
    }

    public class EncoderNLS : Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA2B730
        public void Reset(){} // RVA: 0x7ADA2B810
        public void GetByteCount(){} // RVA: 0x7ADA2BA30
        public void GetBytes(){} // RVA: 0x7ADA2BE40
        public void Convert(){} // RVA: 0x7ADA2C320
        public void get_Encoding(){} // RVA: 0x7A8105330
        public void get_MustFlush(){} // RVA: 0x7A80FD690
        public void get_HasState(){} // RVA: 0x7ADA2C500
        public void ClearMustFlush(){} // RVA: 0x7A84236E0
    }

    public class EncoderReplacementFallback : EncoderFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA2C8A0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7ADA2C660
        public void get_DefaultString(){} // RVA: 0x7A80F2570
        public void CreateFallbackBuffer(){} // RVA: 0x7ADA2CA40
        public void get_MaxCharCount(){} // RVA: 0x7ADA292A0
        public void Equals(){} // RVA: 0x7ADA2CB00
        public void GetHashCode(){} // RVA: 0x7A8738190
    }

    public class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA2CBB0
        public void Fallback(){} // RVA: 0x7ADA2CDA0
        public void GetNextChar(){} // RVA: 0x7ADA2D000
        public void MovePrevious(){} // RVA: 0x7ADA2D060
        public void get_Remaining(){} // RVA: 0x7ADA2D080
        public void Reset(){} // RVA: 0x7ADA2D090
    }

    public class Encoding : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA46C40
        public void SetDefaultFallbacks(){} // RVA: 0x7ADA46CC0
        public void OnDeserializing(){} // RVA: 0x7ADA46E80
        public void OnDeserialized(){} // RVA: 0x7ADA46F30
        public void OnSerializing(){} // RVA: 0x7AA4BE520
        public void DeserializeEncoding(){} // RVA: 0x7ADA46FC0
        public void SerializeEncoding(){} // RVA: 0x7ADA47490
        public void Convert(){} // RVA: 0x7ADA47760
        public void get_InternalSyncObject(){} // RVA: 0x7ADA478C0
        public void GetEncoding(){} // RVA: 0x7ADA487D0
        public void GetPreamble(){} // RVA: 0x7ADA48950
        public void get_Preamble(){} // RVA: 0x7ADA489B0
        public void GetDataItem(){} // RVA: 0x7ADA48A60
        public void get_BodyName(){} // RVA: 0x7ADA48BD0
        public void get_EncodingName(){} // RVA: 0x7ADA48D10
        public void get_HeaderName(){} // RVA: 0x7ADA48E90
        public void get_WebName(){} // RVA: 0x7ADA48FD0
        public void get_IsSingleByte(){} // RVA: 0x7A80D7320
        public void get_EncoderFallback(){} // RVA: 0x7A8105330
        public void set_EncoderFallback(){} // RVA: 0x7ADA49110
        public void get_DecoderFallback(){} // RVA: 0x7A83F69F0
        public void set_DecoderFallback(){} // RVA: 0x7ADA49230
        public void Clone(){} // RVA: 0x7ADA49350
        public void get_IsReadOnly(){} // RVA: 0x7A8477E00
        public void get_ASCII(){} // RVA: 0x7ADA493D0
        public void get_Latin1(){} // RVA: 0x7ADA494F0
        public void GetByteCount(){} // RVA: 0x7ADA4B7F0
        public void GetBytes(){} // RVA: 0x7ADA4B9E0
        public void GetCharCount(){} // RVA: 0x7ADA4B740
        public void GetChars(){} // RVA: 0x7ADA4A600
        public void GetString(){} // RVA: 0x7ADA4AC30
        public void get_CodePage(){} // RVA: 0x7A8124910
        public void IsAlwaysNormalized(){} // RVA: 0x7A80D7320
        public void GetDecoder(){} // RVA: 0x7ADA4A8C0
        public void CreateDefaultEncoding(){} // RVA: 0x7ADA4A960
        public void setReadOnly(){} // RVA: 0x7A88C2D40
        public void get_Default(){} // RVA: 0x7ADA4A9C0
        public void GetEncoder(){} // RVA: 0x7ADA4AAE0
        public void GetMaxByteCount(){} // RVA: 0x7A7E062A0
        public void GetMaxCharCount(){} // RVA: 0x7A7E062A0
        public void get_Unicode(){} // RVA: 0x7ADA4AC60
        public void get_BigEndianUnicode(){} // RVA: 0x7ADA4AD80
        public void get_UTF7(){} // RVA: 0x7ADA4AEA0
        public void get_UTF8(){} // RVA: 0x7ADA4AFD0
        public void get_UTF32(){} // RVA: 0x7ADA4B0F0
        public void Equals(){} // RVA: 0x7ADA4B200
        public void GetHashCode(){} // RVA: 0x7ADA4B2D0
        public void GetBestFitUnicodeToBytesData(){} // RVA: 0x7ADA4B340
        public void GetBestFitBytesToUnicodeData(){} // RVA: 0x7ADA4B3A0
        public void ThrowBytesOverflow(){} // RVA: 0x7ADA4B510
        public void ThrowCharsOverflow(){} // RVA: 0x7ADA4B6B0
    }

    public class EncodingHelper : Object
    {
        // ── Methods ──
        public void get_UTF8Unmarked(){} // RVA: 0x7ADA4FF30
        public void InternalCodePage(){} // RVA: 0x7ADA50200
        public void GetDefaultEncoding(){} // RVA: 0x7ADA50210
        public void InvokeI18N(){} // RVA: 0x7ADA50320
        public void .cctor(){} // RVA: 0x7ADA50960
    }

    public class EncodingNLS : Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA2D0B0
        public void GetByteCount(){} // RVA: 0x7ADA2D310
        public void GetBytes(){} // RVA: 0x7ADA2D990
        public void GetCharCount(){} // RVA: 0x7ADA2DC80
        public void GetChars(){} // RVA: 0x7ADA2E050
        public void GetString(){} // RVA: 0x7ADA2E180
        public void GetDecoder(){} // RVA: 0x7ADA2E360
        public void GetEncoder(){} // RVA: 0x7ADA2E3C0
    }

    public class EncodingProvider : Object
    {
        // ── Methods ──
        public void GetEncoding(){} // RVA: 0x7ADA2E420
        public void GetEncodingFromProvider(){} // RVA: 0x7ADA2E760
        public void .cctor(){} // RVA: 0x7ADA2E880
    }

    public class InternalDecoderBestFitFallback : DecoderFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA26A70
        public void CreateFallbackBuffer(){} // RVA: 0x7ADA26AD0
        public void get_MaxCharCount(){} // RVA: 0x7A81CA9D0
        public void Equals(){} // RVA: 0x7ADA26B30
        public void GetHashCode(){} // RVA: 0x7ADA26BF0
    }

    public class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
    {
        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7ADA26C20
        public void .ctor(){} // RVA: 0x7ADA26CF0
        public void Fallback(){} // RVA: 0x7ADA27000
        public void GetNextChar(){} // RVA: 0x7ADA27050
        public void get_Remaining(){} // RVA: 0x7ADA27080
        public void Reset(){} // RVA: 0x7ADA27090
        public void InternalFallback(){} // RVA: 0x7A81CA9D0
        public void TryBestFit(){} // RVA: 0x7ADA270A0
    }

    public class InternalEncoderBestFitFallback : EncoderFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void CreateFallbackBuffer(){} // RVA: 0x7ADA2A150
        public void get_MaxCharCount(){} // RVA: 0x7A81CA9D0
        public void Equals(){} // RVA: 0x7ADA2A1B0
        public void GetHashCode(){} // RVA: 0x7ADA26BF0
    }

    public class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
    {
        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x7ADA2A270
        public void .ctor(){} // RVA: 0x7ADA2A340
        public void Fallback(){} // RVA: 0x7ADA2A780
        public void GetNextChar(){} // RVA: 0x7ADA2A9A0
        public void MovePrevious(){} // RVA: 0x7ADA2A9D0
        public void get_Remaining(){} // RVA: 0x7ADA2A9F0
        public void Reset(){} // RVA: 0x7ADA2AA00
        public void TryBestFit(){} // RVA: 0x7ADA2AA20
    }

    public class Latin1Encoding : EncodingNLS
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA2E950
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7ADA2E9C0
        public void GetByteCount(){} // RVA: 0x7ADA2EBF0
        public void GetBytes(){} // RVA: 0x7ADA2EEA0
        public void GetCharCount(){} // RVA: 0x7A9C9B620
        public void GetChars(){} // RVA: 0x7ADA2F3D0
        public void GetMaxByteCount(){} // RVA: 0x7ADA2F4B0
        public void GetMaxCharCount(){} // RVA: 0x7ADA2F5F0
        public void get_IsSingleByte(){} // RVA: 0x7A81BD750
        public void IsAlwaysNormalized(){} // RVA: 0x7ADA2F730
        public void GetBestFitUnicodeToBytesData(){} // RVA: 0x7ADA2F740
        public void .cctor(){} // RVA: 0x7ADA2F7A0
    }

    public class Normalization : Object
    {
        // ── Methods ──
        public void PropValue(){} // RVA: 0x7ADA4D630
        public void CharMapIdx(){} // RVA: 0x7ADA4D720
        public void GetCombiningClass(){} // RVA: 0x7ADA4D810
        public void GetPrimaryCompositeFromMapIndex(){} // RVA: 0x7ADA4D8D0
        public void GetPrimaryCompositeHelperIndex(){} // RVA: 0x7ADA4D990
        public void Compose(){} // RVA: 0x7ADA4DA50
        public void Combine(){} // RVA: 0x7ADA4DDC0
        public void CombineHangul(){} // RVA: 0x7ADA4DFF0
        public void Fetch(){} // RVA: 0x7ADA4E230
        public void TryComposeWithPreviousStarter(){} // RVA: 0x7ADA4E280
        public void TryCompose(){} // RVA: 0x7ADA4E670
        public void Decompose(){} // RVA: 0x7ADA4E880
        public void ReorderCanonical(){} // RVA: 0x7ADA4EA00
        public void DecomposeChar(){} // RVA: 0x7ADA4ECC0
        public void QuickCheck(){} // RVA: 0x7ADA4EFE0
        public void GetCanonicalHangul(){} // RVA: 0x7ADA4F120
        public void GetCanonical(){} // RVA: 0x7ADA4F240
        public void IsNormalized(){} // RVA: 0x7ADA4F6B0
        public void Normalize(){} // RVA: 0x7ADA4FB70
        public void load_normalization_resource(){} // RVA: 0x7ADA4FC80
        public void .cctor(){} // RVA: 0x7ADA4FCD0
    }

    public class Rune : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
        public void get_IsAscii(){} // RVA: 0x7A7E6DCF0
        public void get_IsBmp(){} // RVA: 0x7A7E6DD00
        public void op_Equality(){} // RVA: 0x7A9F252F0
        public void IsControl(){} // RVA: 0x7AE0D80C0
        public void get_ReplacementChar(){} // RVA: 0x7AE0D80D0
        public void get_Utf16SequenceLength(){} // RVA: 0x7A7E6DD10
        public void get_Value(){} // RVA: 0x7A765F070
        public void DecodeFromUtf16(){} // RVA: 0x7AE0D80F0
        public void DecodeFromUtf8(){} // RVA: 0x7AE0D8270
        public void Equals(){} // RVA: 0x7A7729660
        public void GetHashCode(){} // RVA: 0x7A765F070
        public void TryCreate(){} // RVA: 0x7AE0D84A0
        public void TryEncodeToUtf16(){} // RVA: 0x7A7E6DDB0
        public void TryEncodeToUtf8(){} // RVA: 0x7A7E6DDE0
        public void UnsafeCreate(){} // RVA: 0x7A9ED9B50
    }

    public class Rune : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A76134D0
        public void get_IsAscii(){} // RVA: 0x7A7E6DCF0
        public void get_IsBmp(){} // RVA: 0x7A7E6DD00
        public void op_Equality(){} // RVA: 0x7A9F252F0
        public void IsControl(){} // RVA: 0x7AE0D80C0
        public void get_ReplacementChar(){} // RVA: 0x7AE0D80D0
        public void get_Utf16SequenceLength(){} // RVA: 0x7A7E6DD10
        public void get_Value(){} // RVA: 0x7A765F070
        public void DecodeFromUtf16(){} // RVA: 0x7AE623D80
        public void DecodeFromUtf8(){} // RVA: 0x7AE623EC0
        public void Equals(){} // RVA: 0x7A7729660
        public void GetHashCode(){} // RVA: 0x7A765F070
        public void TryCreate(){} // RVA: 0x7AE0D84A0
        public void TryEncodeToUtf16(){} // RVA: 0x7A7E8CA40
        public void TryEncodeToUtf8(){} // RVA: 0x7A7E8CA60
        public void UnsafeCreate(){} // RVA: 0x7A9ED9B50
    }

    public class StringBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA37A70
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7ADA30410
        public void get_Capacity(){} // RVA: 0x7ADA30560
        public void set_Capacity(){} // RVA: 0x7ADA30580
        public void get_MaxCapacity(){} // RVA: 0x7A854FDE0
        public void EnsureCapacity(){} // RVA: 0x7ADA30750
        public void ToString(){} // RVA: 0x7ADA30990
        public void Clear(){} // RVA: 0x7ADA30BD0
        public void get_Length(){} // RVA: 0x7ADA30BF0
        public void set_Length(){} // RVA: 0x7ADA30C00
        public void get_Chars(){} // RVA: 0x7ADA30EB0
        public void set_Chars(){} // RVA: 0x7ADA30F80
        public void Append(){} // RVA: 0x7ADA360D0
        public void AppendHelper(){} // RVA: 0x7ADA31530
        public void AppendCore(){} // RVA: 0x7ADA31940
        public void AppendLine(){} // RVA: 0x7ADA31BB0
        public void CopyTo(){} // RVA: 0x7ADA31DF0
        public void Insert(){} // RVA: 0x7ADA36280
        public void Remove(){} // RVA: 0x7ADA37B90
        public void AppendSpanFormattable(){} // RVA: 0x7AA5A3370
        public void AppendJoin(){} // RVA: 0x7ADA33EE0
        public void AppendJoinCore(){} // RVA: 0x7A8051B10
        public void AppendFormat(){} // RVA: 0x7ADA34C80
        public void FormatError(){} // RVA: 0x7ADA34D60
        public void AppendFormatHelper(){} // RVA: 0x7ADA34DB0
        public void Replace(){} // RVA: 0x7ADA35ED0
        public void Equals(){} // RVA: 0x7ADA358A0
        public void ReplaceAllInChunk(){} // RVA: 0x7ADA36940
        public void StartsWith(){} // RVA: 0x7ADA36B40
        public void ReplaceInPlaceAtChunk(){} // RVA: 0x7ADA36C30
        public void ThreadSafeCopy(){} // RVA: 0x7ADA36EA0
        public void FindChunkForIndex(){} // RVA: 0x7ADA37050
        public void get_RemainingCurrentChunk(){} // RVA: 0x7ADA37090
        public void Next(){} // RVA: 0x7ADA37120
        public void ExpandByABlock(){} // RVA: 0x7ADA37170
        public void MakeRoom(){} // RVA: 0x7ADA37510
    }

    public class StringBuilderCache : Object
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7ADA37F00
        public void Release(){} // RVA: 0x7ADA37FF0
        public void GetStringAndRelease(){} // RVA: 0x7ADA380A0
    }

    public class StringBuilderCache : Object
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7AE700A30
        public void Release(){} // RVA: 0x7AE700B20
        public void GetStringAndRelease(){} // RVA: 0x7AE700BD0
    }

    public class StringBuilder[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class UTF32Encoding : Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA38170
        public void SetDefaultFallbacks(){} // RVA: 0x7ADA381E0
        public void GetByteCount(){} // RVA: 0x7ADA396B0
        public void GetBytes(){} // RVA: 0x7ADA39A80
        public void GetCharCount(){} // RVA: 0x7ADA3A060
        public void GetChars(){} // RVA: 0x7ADA3A3B0
        public void GetString(){} // RVA: 0x7ADA394D0
        public void GetSurrogate(){} // RVA: 0x7ADA3A8C0
        public void GetHighSurrogate(){} // RVA: 0x7ADA3A8E0
        public void GetLowSurrogate(){} // RVA: 0x7ADA3A900
        public void GetDecoder(){} // RVA: 0x7ADA3A920
        public void GetEncoder(){} // RVA: 0x7ADA3A980
        public void GetMaxByteCount(){} // RVA: 0x7ADA3A9E0
        public void GetMaxCharCount(){} // RVA: 0x7ADA3AB20
        public void GetPreamble(){} // RVA: 0x7ADA3AC00
        public void get_Preamble(){} // RVA: 0x7ADA3ACC0
        public void Equals(){} // RVA: 0x7ADA3AEB0
        public void GetHashCode(){} // RVA: 0x7ADA3AF80
        public void .cctor(){} // RVA: 0x7ADA3B030
    }

    public class UTF7Encoding : Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA3B420
        public void MakeTables(){} // RVA: 0x7ADA3B470
        public void SetDefaultFallbacks(){} // RVA: 0x7ADA3B820
        public void Equals(){} // RVA: 0x7ADA3B970
        public void GetHashCode(){} // RVA: 0x7ADA3BA40
        public void GetByteCount(){} // RVA: 0x7ADA3CD60
        public void GetBytes(){} // RVA: 0x7ADA3CDA0
        public void GetCharCount(){} // RVA: 0x7ADA3D260
        public void GetChars(){} // RVA: 0x7ADA3D2A0
        public void GetString(){} // RVA: 0x7ADA3CB80
        public void GetDecoder(){} // RVA: 0x7ADA3D530
        public void GetEncoder(){} // RVA: 0x7ADA3D590
        public void GetMaxByteCount(){} // RVA: 0x7ADA3D5F0
        public void GetMaxCharCount(){} // RVA: 0x7ADA3D6E0
        public void .cctor(){} // RVA: 0x7ADA3D770
    }

    public class UTF8Encoding : Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA3DB30
        public void SetDefaultFallbacks(){} // RVA: 0x7ADA3DBA0
        public void GetByteCount(){} // RVA: 0x7ADA3F070
        public void GetBytes(){} // RVA: 0x7ADA3F7A0
        public void GetCharCount(){} // RVA: 0x7ADA40040
        public void GetChars(){} // RVA: 0x7ADA40510
        public void GetString(){} // RVA: 0x7ADA3EE90
        public void PtrDiff(){} // RVA: 0x7ADA3F780
        public void InRange(){} // RVA: 0x7ADA3F790
        public void FallbackInvalidByteSequence(){} // RVA: 0x7ADA40E50
        public void GetBytesUnknown(){} // RVA: 0x7ADA40EA0
        public void GetDecoder(){} // RVA: 0x7ADA41110
        public void GetEncoder(){} // RVA: 0x7ADA41170
        public void GetMaxByteCount(){} // RVA: 0x7ADA411D0
        public void GetMaxCharCount(){} // RVA: 0x7ADA41310
        public void GetPreamble(){} // RVA: 0x7ADA41450
        public void get_Preamble(){} // RVA: 0x7ADA414F0
        public void Equals(){} // RVA: 0x7ADA416B0
        public void GetHashCode(){} // RVA: 0x7ADA41780
        public void .cctor(){} // RVA: 0x7ADA417F0
    }

    public class UnicodeEncoding : Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA41C40
        public void SetDefaultFallbacks(){} // RVA: 0x7ADA41CC0
        public void GetByteCount(){} // RVA: 0x7ADA43190
        public void GetBytes(){} // RVA: 0x7ADA43930
        public void GetCharCount(){} // RVA: 0x7ADA442D0
        public void GetChars(){} // RVA: 0x7ADA44B60
        public void GetString(){} // RVA: 0x7ADA42FB0
        public void GetEncoder(){} // RVA: 0x7ADA45690
        public void GetDecoder(){} // RVA: 0x7ADA456F0
        public void GetPreamble(){} // RVA: 0x7ADA45750
        public void get_Preamble(){} // RVA: 0x7ADA45810
        public void GetMaxByteCount(){} // RVA: 0x7ADA45A00
        public void GetMaxCharCount(){} // RVA: 0x7ADA45B40
        public void Equals(){} // RVA: 0x7ADA45C90
        public void GetHashCode(){} // RVA: 0x7ADA45DB0
        public void .cctor(){} // RVA: 0x7ADA45E50
    }

    public class UnicodeUtility : Object
    {
        // ── Methods ──
        public void GetUtf16SequenceLength(){} // RVA: 0x7AE0D7FE0
        public void GetUtf16SurrogatesFromSupplementaryPlaneScalar(){} // RVA: 0x7AE0D7FF0
        public void IsAsciiCodePoint(){} // RVA: 0x7AE0D8020
        public void IsBmpCodePoint(){} // RVA: 0x7AE0D8030
        public void IsInRangeInclusive(){} // RVA: 0x7ADA3F790
        public void IsSurrogateCodePoint(){} // RVA: 0x7AE0D8040
        public void IsValidUnicodeScalar(){} // RVA: 0x7AE0D8050
    }

    public class UnicodeUtility : Object
    {
        // ── Methods ──
        public void GetUtf16SequenceLength(){} // RVA: 0x7AE0D7FE0
        public void GetUtf16SurrogatesFromSupplementaryPlaneScalar(){} // RVA: 0x7AE0D7FF0
        public void IsAsciiCodePoint(){} // RVA: 0x7AE0D8020
        public void IsBmpCodePoint(){} // RVA: 0x7AE0D8030
        public void IsInRangeInclusive(){} // RVA: 0x7ADA3F790
        public void IsSurrogateCodePoint(){} // RVA: 0x7AE0D8040
        public void IsValidUnicodeScalar(){} // RVA: 0x7AE0D8050
    }

    public class ValueStringBuilder : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E2CC90
        public void get_Length(){} // RVA: 0x7A768A430
        public void set_Length(){} // RVA: 0x7A768A440
        public void get_Capacity(){} // RVA: 0x7A7E2CDE0
        public void EnsureCapacity(){} // RVA: 0x7A7E2CE20
        public void GetPinnableReference(){} // RVA: 0x7A7E2CEC0
        public void get_Item(){} // RVA: 0x7A7E2CF60
        public void ToString(){} // RVA: 0x7A7E2CF80
        public void get_RawChars(){} // RVA: 0x7A76B2030
        public void AsSpan(){} // RVA: 0x7A7E2D250
        public void TryCopyTo(){} // RVA: 0x7A7E2D330
        public void Insert(){} // RVA: 0x7A7E2D490
        public void Append(){} // RVA: 0x7A7E2D710
        public void AppendSlow(){} // RVA: 0x7A7E2D540
        public void AppendSpan(){} // RVA: 0x7A7E2D730
        public void GrowAndAppend(){} // RVA: 0x7A7E2D810
        public void Grow(){} // RVA: 0x7A7E2D820
        public void Dispose(){} // RVA: 0x7A7E2D830
    }

    public class ValueStringBuilder : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA461A0
        public void get_Length(){} // RVA: 0x7A83782A0
        public void get_Item(){} // RVA: 0x7AD9935B0
        public void ToString(){} // RVA: 0x7ADA461B0
        public void TryCopyTo(){} // RVA: 0x7ADA46290
        public void Append(){} // RVA: 0x7ADA46780
        public void AppendSlow(){} // RVA: 0x7ADA46500
        public void AppendSpan(){} // RVA: 0x7ADA46860
        public void GrowAndAppend(){} // RVA: 0x7ADA46940
        public void Grow(){} // RVA: 0x7ADA46980
        public void Dispose(){} // RVA: 0x7ADA46B80
    }

    public class ValueStringBuilder : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA461A0
        public void get_Length(){} // RVA: 0x7A83782A0
        public void ToString(){} // RVA: 0x7AE622840
        public void TryCopyTo(){} // RVA: 0x7AE622920
        public void Insert(){} // RVA: 0x7AE622A70
        public void Append(){} // RVA: 0x7AE623050
        public void AppendSlow(){} // RVA: 0x7AE622DD0
        public void AppendSpan(){} // RVA: 0x7AE623130
        public void GrowAndAppend(){} // RVA: 0x7AE623210
        public void Grow(){} // RVA: 0x7AE623250
        public void Dispose(){} // RVA: 0x7AE623450
    }

}