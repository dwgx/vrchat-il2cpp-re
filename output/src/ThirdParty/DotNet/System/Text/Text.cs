// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text
// Classes: 38
// Methods: 621

namespace ThirdParty.DotNet.System.Text
{
    public class ASCIIEncoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C35570
        public void SetDefaultFallbacks(){} // RVA: 0x5C35590
        public void GetByteCount(){} // RVA: 0x5C36900 | overloaded x4
        public void GetBytes(){} // RVA: 0x5C36CA0 | overloaded x4
        public void GetCharCount(){} // RVA: 0x5C37240 | overloaded x3
        public void GetChars(){} // RVA: 0x5C373E0 | overloaded x3
        public void GetString(){} // RVA: 0x5C36720
        public void GetMaxByteCount(){} // RVA: 0x5C37770
        public void GetMaxCharCount(){} // RVA: 0x5C378B0
        public void get_IsSingleByte(){} // RVA: 0x3C2850
        public void GetDecoder(){} // RVA: 0x5C379F0
        public void GetEncoder(){} // RVA: 0x5C37A50
        public void .cctor(){} // RVA: 0x5C37AB0
    }

    public class Decoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Fallback(){} // RVA: 0x2F8380
        public void get_FallbackBuffer(){} // RVA: 0x5C37C30
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x1D3B060
        public void Reset(){} // RVA: 0x5C37D60
        public void GetCharCount(){} // RVA: 0x5C37E70 | overloaded x3
        public void GetChars(){} // RVA: 0x5C38280 | overloaded x4
        public void Convert(){} // RVA: 0x5C387B0 | overloaded x2
    }

    public class DecoderExceptionFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void CreateFallbackBuffer(){} // RVA: 0x5C39210
        public void get_MaxCharCount(){} // RVA: 0x519240
        public void Equals(){} // RVA: 0x5C39250
        public void GetHashCode(){} // RVA: 0x5C392B0
    }

    public class DecoderExceptionFallbackBuffer
    {
        // ── Methods ──
        public void Fallback(){} // RVA: 0x5C392C0
        public void GetNextChar(){} // RVA: 0x519240
        public void get_Remaining(){} // RVA: 0x519240
        public void Throw(){} // RVA: 0x5C392D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DecoderFallback
    {
        // ── Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x5C395F0
        public void get_ExceptionFallback(){} // RVA: 0x5C396C0
        public void CreateFallbackBuffer(){} // RVA: 0xCD60
        public void get_MaxCharCount(){} // RVA: 0xD840
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DecoderFallbackBuffer
    {
        // ── Methods ──
        public void Fallback(){} // RVA: 0x10840
        public void GetNextChar(){} // RVA: 0xCC90
        public void get_Remaining(){} // RVA: 0xD840
        public void Reset(){} // RVA: 0x5C39750
        public void InternalReset(){} // RVA: 0x5C39790
        public void InternalInitialize(){} // RVA: 0x5C397B0
        public void InternalFallback(){} // RVA: 0x5C39A10 | overloaded x2
        public void ThrowLastBytesRecursive(){} // RVA: 0x5C39C50
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DecoderFallbackException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C395D0 | overloaded x3
    }

    public class DecoderNLS
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C39E60
        public void Reset(){} // RVA: 0x5C39F40
        public void GetCharCount(){} // RVA: 0x5C3A180 | overloaded x3
        public void GetChars(){} // RVA: 0x5C3A5D0 | overloaded x3
        public void Convert(){} // RVA: 0x5C3AAB0 | overloaded x2
        public void get_MustFlush(){} // RVA: 0x6E8A80
        public void get_HasState(){} // RVA: 0x2DD320
        public void ClearMustFlush(){} // RVA: 0x1E32400
    }

    public class DecoderReplacementFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C3B020 | overloaded x3
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x5C3ADE0
        public void get_DefaultString(){} // RVA: 0x2F8380
        public void CreateFallbackBuffer(){} // RVA: 0x5C3B1C0
        public void get_MaxCharCount(){} // RVA: 0x5C3B260
        public void Equals(){} // RVA: 0x5C3B280
        public void GetHashCode(){} // RVA: 0x99E0E0
    }

    public class DecoderReplacementFallbackBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C3B330
        public void Fallback(){} // RVA: 0x5C3B3A0
        public void GetNextChar(){} // RVA: 0x5C3B3F0
        public void get_Remaining(){} // RVA: 0x5C3B450
        public void Reset(){} // RVA: 0x5C3B460
        public void InternalFallback(){} // RVA: 0x5C3B480
    }

    public class Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Fallback(){} // RVA: 0x2F8380
        public void get_FallbackBuffer(){} // RVA: 0x5C3B4A0
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x1D3B060
        public void Reset(){} // RVA: 0x5C3B5D0
        public void GetByteCount(){} // RVA: 0x5C3B6C0 | overloaded x2
        public void GetBytes(){} // RVA: 0x5C3B870 | overloaded x2
        public void Convert(){} // RVA: 0x5C3BEB0 | overloaded x2
    }

    public class EncoderExceptionFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void CreateFallbackBuffer(){} // RVA: 0x5C3CB20
        public void get_MaxCharCount(){} // RVA: 0x519240
        public void Equals(){} // RVA: 0x5C3CB60
        public void GetHashCode(){} // RVA: 0x5C3CBC0
    }

    public class EncoderExceptionFallbackBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Fallback(){} // RVA: 0x5C3CCA0 | overloaded x2
        public void GetNextChar(){} // RVA: 0x519240
        public void MovePrevious(){} // RVA: 0x2DD320
        public void get_Remaining(){} // RVA: 0x519240
    }

    public class EncoderFallback
    {
        // ── Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x5C3D240
        public void get_ExceptionFallback(){} // RVA: 0x5C3D310
        public void CreateFallbackBuffer(){} // RVA: 0xCD60
        public void get_MaxCharCount(){} // RVA: 0xD840
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class EncoderFallbackBuffer
    {
        // ── Methods ──
        public void Fallback(){} // overloaded x2
        public void GetNextChar(){} // RVA: 0xCC90
        public void MovePrevious(){} // RVA: 0xDBE0
        public void get_Remaining(){} // RVA: 0xD840
        public void Reset(){} // RVA: 0x5C3D3A0
        public void InternalReset(){} // RVA: 0x5C3D3E0
        public void InternalInitialize(){} // RVA: 0x5C3D400
        public void InternalGetNextChar(){} // RVA: 0x5C3D470
        public void InternalFallback(){} // RVA: 0x5C3D4B0
        public void ThrowLastCharRecursive(){} // RVA: 0x5C3D680
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class EncoderFallbackException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C395D0 | overloaded x4
    }

    public class EncoderNLS
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C3D720
        public void Reset(){} // RVA: 0x5C3D800
        public void GetByteCount(){} // RVA: 0x5C3DA20 | overloaded x2
        public void GetBytes(){} // RVA: 0x5C3DE30 | overloaded x2
        public void Convert(){} // RVA: 0x5C3E310 | overloaded x2
        public void get_Encoding(){} // RVA: 0x30B130
        public void get_MustFlush(){} // RVA: 0x303450
        public void get_HasState(){} // RVA: 0x5C3E4F0
        public void ClearMustFlush(){} // RVA: 0x6205A0
    }

    public class EncoderReplacementFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C3E890 | overloaded x3
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x5C3E650
        public void get_DefaultString(){} // RVA: 0x2F8380
        public void CreateFallbackBuffer(){} // RVA: 0x5C3EA30
        public void get_MaxCharCount(){} // RVA: 0x5C3B260
        public void Equals(){} // RVA: 0x5C3EAF0
        public void GetHashCode(){} // RVA: 0x99E0E0
    }

    public class EncoderReplacementFallbackBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C3EBA0
        public void Fallback(){} // RVA: 0x5C3ED90 | overloaded x2
        public void GetNextChar(){} // RVA: 0x5C3EFF0
        public void MovePrevious(){} // RVA: 0x5C3F050
        public void get_Remaining(){} // RVA: 0x5C3F070
        public void Reset(){} // RVA: 0x5C3F080
    }

    public class Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C58B60 | overloaded x2
        public void SetDefaultFallbacks(){} // RVA: 0x5C58BE0
        public void OnDeserializing(){} // RVA: 0x5C58DA0 | overloaded x2
        public void OnDeserialized(){} // RVA: 0x5C58E50 | overloaded x2
        public void OnSerializing(){} // RVA: 0x26AD280
        public void DeserializeEncoding(){} // RVA: 0x5C58EE0
        public void SerializeEncoding(){} // RVA: 0x5C593A0
        public void Convert(){} // RVA: 0x5C59670 | overloaded x2
        public void get_InternalSyncObject(){} // RVA: 0x5C597D0
        public void GetEncoding(){} // RVA: 0x5C5A700 | overloaded x3
        public void GetPreamble(){} // RVA: 0x5C5A860
        public void get_Preamble(){} // RVA: 0x5C5A8C0
        public void GetDataItem(){} // RVA: 0x5C5A970
        public void get_BodyName(){} // RVA: 0x5C5AAE0
        public void get_EncodingName(){} // RVA: 0x5C5AC20
        public void get_HeaderName(){} // RVA: 0x5C5ADA0
        public void get_WebName(){} // RVA: 0x5C5AEE0
        public void get_IsSingleByte(){} // RVA: 0x2DD320
        public void get_EncoderFallback(){} // RVA: 0x30B130
        public void set_EncoderFallback(){} // RVA: 0x5C5B020
        public void get_DecoderFallback(){} // RVA: 0x6374D0
        public void set_DecoderFallback(){} // RVA: 0x5C5B140
        public void Clone(){} // RVA: 0x5C5B260
        public void get_IsReadOnly(){} // RVA: 0x6BB3A0
        public void get_ASCII(){} // RVA: 0x5C5B2F0
        public void get_Latin1(){} // RVA: 0x5C5B410
        public void GetByteCount(){} // RVA: 0x5C5D700 | overloaded x7
        public void GetBytes(){} // RVA: 0x5C5D8F0 | overloaded x9
        public void GetCharCount(){} // RVA: 0x5C5D650 | overloaded x5
        public void GetChars(){} // RVA: 0x5C5C4E0 | overloaded x5
        public void GetString(){} // RVA: 0x5C5CB10 | overloaded x4
        public void get_CodePage(){} // RVA: 0x32A5C0
        public void IsAlwaysNormalized(){} // RVA: 0x2DD320 | overloaded x2
        public void GetDecoder(){} // RVA: 0x5C5C7A0
        public void CreateDefaultEncoding(){} // RVA: 0x5C5C840
        public void setReadOnly(){} // RVA: 0xB265D0
        public void get_Default(){} // RVA: 0x5C5C8A0
        public void GetEncoder(){} // RVA: 0x5C5C9C0
        public void GetMaxByteCount(){} // RVA: 0x13FB0
        public void GetMaxCharCount(){} // RVA: 0x13FB0
        public void get_Unicode(){} // RVA: 0x5C5CB40
        public void get_BigEndianUnicode(){} // RVA: 0x5C5CC60
        public void get_UTF7(){} // RVA: 0x5C5CD80
        public void get_UTF8(){} // RVA: 0x5C5CEB0
        public void get_UTF32(){} // RVA: 0x5C5CFD0
        public void Equals(){} // RVA: 0x5C5D0E0
        public void GetHashCode(){} // RVA: 0x5C5D1E0
        public void GetBestFitUnicodeToBytesData(){} // RVA: 0x5C5D250
        public void GetBestFitBytesToUnicodeData(){} // RVA: 0x5C5D2B0
        public void ThrowBytesOverflow(){} // RVA: 0x5C5D420 | overloaded x2
        public void ThrowCharsOverflow(){} // RVA: 0x5C5D5C0 | overloaded x2
    }

    public class EncodingHelper
    {
        // ── Methods ──
        public void get_UTF8Unmarked(){} // RVA: 0x5C61F80
        public void InternalCodePage(){} // RVA: 0x5C62280
        public void GetDefaultEncoding(){} // RVA: 0x5C62290
        public void InvokeI18N(){} // RVA: 0x5C623A0
        public void .cctor(){} // RVA: 0x5C62A00
    }

    public class EncodingNLS
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C3F0A0
        public void GetByteCount(){} // RVA: 0x5C3F300 | overloaded x3
        public void GetBytes(){} // RVA: 0x5C3F980 | overloaded x3
        public void GetCharCount(){} // RVA: 0x5C3FC70 | overloaded x2
        public void GetChars(){} // RVA: 0x5C40040 | overloaded x2
        public void GetString(){} // RVA: 0x5C40170
        public void GetDecoder(){} // RVA: 0x5C40350
        public void GetEncoder(){} // RVA: 0x5C403B0
    }

    public class EncodingProvider
    {
        // ── Methods ──
        public void GetEncoding(){} // RVA: 0x5C40410 | overloaded x3
        public void GetEncodingFromProvider(){} // RVA: 0x5C40730 | overloaded x3
        public void .cctor(){} // RVA: 0x5C40850
    }

    public class InternalDecoderBestFitFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C38A20
        public void CreateFallbackBuffer(){} // RVA: 0x5C38A80
        public void get_MaxCharCount(){} // RVA: 0x3CFAF0
        public void Equals(){} // RVA: 0x5C38AE0
        public void GetHashCode(){} // RVA: 0x5C38BA0
    }

    public class InternalDecoderBestFitFallbackBuffer
    {
        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x5C38BD0
        public void .ctor(){} // RVA: 0x5C38CA0
        public void Fallback(){} // RVA: 0x5C38FC0
        public void GetNextChar(){} // RVA: 0x5C39010
        public void get_Remaining(){} // RVA: 0x5C39040
        public void Reset(){} // RVA: 0x5C39050
        public void InternalFallback(){} // RVA: 0x3CFAF0
        public void TryBestFit(){} // RVA: 0x5C39060
    }

    public class InternalEncoderBestFitFallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void CreateFallbackBuffer(){} // RVA: 0x5C3C120
        public void get_MaxCharCount(){} // RVA: 0x3CFAF0
        public void Equals(){} // RVA: 0x5C3C180
        public void GetHashCode(){} // RVA: 0x5C38BA0
    }

    public class InternalEncoderBestFitFallbackBuffer
    {
        // ── Methods ──
        public void get_InternalSyncObject(){} // RVA: 0x5C3C270
        public void .ctor(){} // RVA: 0x5C3C340
        public void Fallback(){} // RVA: 0x5C3C770 | overloaded x2
        public void GetNextChar(){} // RVA: 0x5C3C990
        public void MovePrevious(){} // RVA: 0x5C3C9C0
        public void get_Remaining(){} // RVA: 0x5C3C9E0
        public void Reset(){} // RVA: 0x5C3C9F0
        public void TryBestFit(){} // RVA: 0x5C3CA10
    }

    public class Latin1Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C40920 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x5C40990
        public void GetByteCount(){} // RVA: 0x5C40BC0
        public void GetBytes(){} // RVA: 0x5C40E70
        public void GetCharCount(){} // RVA: 0x1E96C40
        public void GetChars(){} // RVA: 0x5C41380
        public void GetMaxByteCount(){} // RVA: 0x5C41460
        public void GetMaxCharCount(){} // RVA: 0x5C415A0
        public void get_IsSingleByte(){} // RVA: 0x3C2850
        public void IsAlwaysNormalized(){} // RVA: 0x5C416E0
        public void GetBestFitUnicodeToBytesData(){} // RVA: 0x5C416F0
        public void .cctor(){} // RVA: 0x5C41750
    }

    public class Normalization
    {
        // ── Methods ──
        public void PropValue(){} // RVA: 0x5C5F540
        public void CharMapIdx(){} // RVA: 0x5C5F630
        public void GetCombiningClass(){} // RVA: 0x5C5F720
        public void GetPrimaryCompositeFromMapIndex(){} // RVA: 0x5C5F7E0
        public void GetPrimaryCompositeHelperIndex(){} // RVA: 0x5C5F8A0
        public void Compose(){} // RVA: 0x5C5F960
        public void Combine(){} // RVA: 0x5C5FCD0 | overloaded x2
        public void CombineHangul(){} // RVA: 0x5C5FF00
        public void Fetch(){} // RVA: 0x5C60140
        public void TryComposeWithPreviousStarter(){} // RVA: 0x5C60190
        public void TryCompose(){} // RVA: 0x5C60580
        public void Decompose(){} // RVA: 0x5C60790 | overloaded x2
        public void ReorderCanonical(){} // RVA: 0x5C60910
        public void DecomposeChar(){} // RVA: 0x5C60BD0
        public void QuickCheck(){} // RVA: 0x5C60EF0
        public void GetCanonicalHangul(){} // RVA: 0x5C61030
        public void GetCanonical(){} // RVA: 0x5C61160
        public void IsNormalized(){} // RVA: 0x5C615D0 | overloaded x2
        public void Normalize(){} // RVA: 0x5C61B90 | overloaded x2
        public void load_normalization_resource(){} // RVA: 0x5C61CA0
        public void .cctor(){} // RVA: 0x5C61CF0
    }

    public class Rune
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x833580 | overloaded x3
        public void get_IsAscii(){} // RVA: 0x62EC2F0
        public void get_IsBmp(){} // RVA: 0x62EC300
        public void op_Equality(){} // RVA: 0x2110AC0
        public void IsControl(){} // RVA: 0x62EC310
        public void get_ReplacementChar(){} // RVA: 0x62EC320
        public void get_Utf16SequenceLength(){} // RVA: 0x62EC330
        public void get_Value(){} // RVA: 0x19689B0
        public void DecodeFromUtf16(){} // RVA: 0x6835020
        public void DecodeFromUtf8(){} // RVA: 0x6835150
        public void Equals(){} // RVA: 0x20D6490 | overloaded x2
        public void GetHashCode(){} // RVA: 0x19689B0
        public void TryCreate(){} // RVA: 0x62EC6E0 | overloaded x2
        public void TryEncodeToUtf16(){} // RVA: 0x6835330
        public void TryEncodeToUtf8(){} // RVA: 0x6835420
        public void UnsafeCreate(){} // RVA: 0x20C5210
    }

    public class StringBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C49920 | overloaded x9
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x5C42350
        public void get_Capacity(){} // RVA: 0x5C424A0
        public void set_Capacity(){} // RVA: 0x5C424C0
        public void get_MaxCapacity(){} // RVA: 0x791DC0
        public void EnsureCapacity(){} // RVA: 0x5C42690
        public void ToString(){} // RVA: 0x5C428D0 | overloaded x2
        public void Clear(){} // RVA: 0x5C42B00
        public void get_Length(){} // RVA: 0x5C42B20
        public void set_Length(){} // RVA: 0x5C42B30
        public void get_Chars(){} // RVA: 0x5C42DE0
        public void set_Chars(){} // RVA: 0x5C42EB0
        public void Append(){} // RVA: 0x5C47FE0 | overloaded x23
        public void AppendHelper(){} // RVA: 0x5C43450
        public void AppendCore(){} // RVA: 0x5C43860
        public void AppendLine(){} // RVA: 0x5C43AD0 | overloaded x2
        public void CopyTo(){} // RVA: 0x5C43D10 | overloaded x2
        public void Insert(){} // RVA: 0x5C48190 | overloaded x19
        public void Remove(){} // RVA: 0x5C49A40 | overloaded x2
        public void AppendSpanFormattable(){} // RVA: 0x283FA0
        public void AppendJoin(){} // RVA: 0x5C45E20 | overloaded x5
        public void AppendJoinCore(){} // RVA: 0x283FA0 | overloaded x2
        public void AppendFormat(){} // RVA: 0x5C46BC0 | overloaded x8
        public void FormatError(){} // RVA: 0x5C46CA0
        public void AppendFormatHelper(){} // RVA: 0x5C46CF0
        public void Replace(){} // RVA: 0x5C47DE0 | overloaded x4
        public void Equals(){} // RVA: 0x5C477D0
        public void ReplaceAllInChunk(){} // RVA: 0x5C48820
        public void StartsWith(){} // RVA: 0x5C48A10
        public void ReplaceInPlaceAtChunk(){} // RVA: 0x5C48B00
        public void ThreadSafeCopy(){} // RVA: 0x5C48D70 | overloaded x2
        public void FindChunkForIndex(){} // RVA: 0x5C48F20
        public void get_RemainingCurrentChunk(){} // RVA: 0x5C48F60
        public void Next(){} // RVA: 0x5C48FF0
        public void ExpandByABlock(){} // RVA: 0x5C49040
        public void MakeRoom(){} // RVA: 0x5C493E0
    }

    public class StringBuilderCache
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x5C49DA0
        public void Release(){} // RVA: 0x5C49E90
        public void GetStringAndRelease(){} // RVA: 0x5C49F40
    }

    public class UTF32Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C4A010 | overloaded x3
        public void SetDefaultFallbacks(){} // RVA: 0x5C4A080
        public void GetByteCount(){} // RVA: 0x5C4B550 | overloaded x4
        public void GetBytes(){} // RVA: 0x5C4B910 | overloaded x4
        public void GetCharCount(){} // RVA: 0x5C4BED0 | overloaded x3
        public void GetChars(){} // RVA: 0x5C4C220 | overloaded x3
        public void GetString(){} // RVA: 0x5C4B370
        public void GetSurrogate(){} // RVA: 0x5C4C7C0
        public void GetHighSurrogate(){} // RVA: 0x5C4C7E0
        public void GetLowSurrogate(){} // RVA: 0x5C4C800
        public void GetDecoder(){} // RVA: 0x5C4C820
        public void GetEncoder(){} // RVA: 0x5C4C880
        public void GetMaxByteCount(){} // RVA: 0x5C4C8E0
        public void GetMaxCharCount(){} // RVA: 0x5C4CA20
        public void GetPreamble(){} // RVA: 0x5C4CB00
        public void get_Preamble(){} // RVA: 0x5C4CBC0
        public void Equals(){} // RVA: 0x5C4CDB0
        public void GetHashCode(){} // RVA: 0x5C4CE80
        public void .cctor(){} // RVA: 0x5C4CF30
    }

    public class UTF7Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C4D310 | overloaded x2
        public void MakeTables(){} // RVA: 0x5C4D360
        public void SetDefaultFallbacks(){} // RVA: 0x5C4D710
        public void Equals(){} // RVA: 0x5C4D860
        public void GetHashCode(){} // RVA: 0x5C4D960
        public void GetByteCount(){} // RVA: 0x5C4EC80 | overloaded x4
        public void GetBytes(){} // RVA: 0x5C4ECC0 | overloaded x4
        public void GetCharCount(){} // RVA: 0x5C4F180 | overloaded x3
        public void GetChars(){} // RVA: 0x5C4F1C0 | overloaded x3
        public void GetString(){} // RVA: 0x5C4EAA0
        public void GetDecoder(){} // RVA: 0x5C4F440
        public void GetEncoder(){} // RVA: 0x5C4F4A0
        public void GetMaxByteCount(){} // RVA: 0x5C4F500
        public void GetMaxCharCount(){} // RVA: 0x5C4F5F0
        public void .cctor(){} // RVA: 0x5C4F680
    }

    public class UTF8Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C4FA40 | overloaded x3
        public void SetDefaultFallbacks(){} // RVA: 0x5C4FAB0
        public void GetByteCount(){} // RVA: 0x5C50F80 | overloaded x4
        public void GetBytes(){} // RVA: 0x5C516B0 | overloaded x4
        public void GetCharCount(){} // RVA: 0x5C51F40 | overloaded x3
        public void GetChars(){} // RVA: 0x5C52420 | overloaded x3
        public void GetString(){} // RVA: 0x5C50DA0
        public void PtrDiff(){} // RVA: 0x5C51690 | overloaded x2
        public void InRange(){} // RVA: 0x5C516A0
        public void FallbackInvalidByteSequence(){} // RVA: 0x5C52D60 | overloaded x2
        public void GetBytesUnknown(){} // RVA: 0x5C52DB0
        public void GetDecoder(){} // RVA: 0x5C53020
        public void GetEncoder(){} // RVA: 0x5C53080
        public void GetMaxByteCount(){} // RVA: 0x5C530E0
        public void GetMaxCharCount(){} // RVA: 0x5C53220
        public void GetPreamble(){} // RVA: 0x5C53360
        public void get_Preamble(){} // RVA: 0x5C53400
        public void Equals(){} // RVA: 0x5C535C0
        public void GetHashCode(){} // RVA: 0x5C536C0
        public void .cctor(){} // RVA: 0x5C53730
    }

    public class UnicodeEncoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C53B80 | overloaded x3
        public void SetDefaultFallbacks(){} // RVA: 0x5C53C00
        public void GetByteCount(){} // RVA: 0x5C550D0 | overloaded x4
        public void GetBytes(){} // RVA: 0x5C55870 | overloaded x4
        public void GetCharCount(){} // RVA: 0x5C56200 | overloaded x3
        public void GetChars(){} // RVA: 0x5C56AA0 | overloaded x3
        public void GetString(){} // RVA: 0x5C54EF0
        public void GetEncoder(){} // RVA: 0x5C57590
        public void GetDecoder(){} // RVA: 0x5C575F0
        public void GetPreamble(){} // RVA: 0x5C57650
        public void get_Preamble(){} // RVA: 0x5C57710
        public void GetMaxByteCount(){} // RVA: 0x5C57900
        public void GetMaxCharCount(){} // RVA: 0x5C57A40
        public void Equals(){} // RVA: 0x5C57B90
        public void GetHashCode(){} // RVA: 0x5C57CD0
        public void .cctor(){} // RVA: 0x5C57D70
    }

    public class UnicodeUtility
    {
        // ── Methods ──
        public void GetUtf16SequenceLength(){} // RVA: 0x62EC230
        public void GetUtf16SurrogatesFromSupplementaryPlaneScalar(){} // RVA: 0x62EC240
        public void IsAsciiCodePoint(){} // RVA: 0x62EC270
        public void IsBmpCodePoint(){} // RVA: 0x62EC280
        public void IsInRangeInclusive(){} // RVA: 0x5C516A0
        public void IsSurrogateCodePoint(){} // RVA: 0x62EC290
        public void IsValidUnicodeScalar(){} // RVA: 0x62EC2A0
    }

    public class ValueStringBuilder
    {
        public object FullName;
        public object IncludeGenericParameters;
        public object IncludeGenericParameterNames;
        public object NestedTypeDelimiter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BA5860 | overloaded x2
        public void get_Length(){} // RVA: 0x5BED50
        public void set_Length(){} // RVA: 0x6374E0
        public void get_Capacity(){} // RVA: 0x5BA59A0
        public void EnsureCapacity(){} // RVA: 0x5BA59E0
        public void GetPinnableReference(){} // RVA: 0x5BA5A70 | overloaded x2
        public void get_Item(){} // RVA: 0x5BA5B10
        public void ToString(){} // RVA: 0x5BA5B30
        public void get_RawChars(){} // RVA: 0x1F6F090
        public void AsSpan(){} // RVA: 0x5BA5EB0 | overloaded x4
        public void TryCopyTo(){} // RVA: 0x5BA5F90
        public void Insert(){} // RVA: 0x5BA6320 | overloaded x2
        public void Append(){} // RVA: 0x5BA6A50 | overloaded x5
        public void AppendSlow(){} // RVA: 0x5BA66F0
        public void AppendSpan(){} // RVA: 0x5BA6B70
        public void GrowAndAppend(){} // RVA: 0x5BA6C50
        public void Grow(){} // RVA: 0x5BA6C90
        public void Dispose(){} // RVA: 0x5BA6F80
    }

}