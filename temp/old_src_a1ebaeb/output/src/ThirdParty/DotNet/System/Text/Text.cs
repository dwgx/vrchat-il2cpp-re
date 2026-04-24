// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text
// Classes: 19
// Methods: 409

namespace ThirdParty.DotNet.System.Text
{
    public class Decoder : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_Fallback(){} // RVA: 0x7ffaa894d380
        public void get_FallbackBuffer(){} // RVA: 0x7ffaaddf0330
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x7ffaaa268a50
        public void Reset(){} // RVA: 0x7ffaaddf0460
        public void Convert(){} // RVA: 0x7ffaaddf0eb0
        public void Convert(){} // RVA: 0x7ffaaddf0eb0
        // ── Binary Analysis Named ──
        public void GetCharCount(){} // RVA: 0x7ffaaddf0570
        public void GetCharCount(){} // RVA: 0x7ffaaddf0570
        public void GetCharCount(){} // RVA: 0x7ffaaddf0570
        public void GetChars(){} // RVA: 0x7ffaaddf0980
        public void GetChars(){} // RVA: 0x7ffaaddf0980
        public void GetChars(){} // RVA: 0x7ffaaddf0980
        public void GetChars(){} // RVA: 0x7ffaaddf0980
    }

    public class DecoderExceptionFallback : DecoderFallback
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void CreateFallbackBuffer(){} // RVA: 0x7ffaaddf1910
        public void get_MaxCharCount(){} // RVA: 0x7ffaa8f22da0
        public void Equals(){} // RVA: 0x7ffaaddf1950
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaddf19b0
    }

    public class DecoderFallback : Object
    {
        // ── Original Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x7ffaaddf1cf0
        public void get_ExceptionFallback(){} // RVA: 0x7ffaaddf1dc0
        public void CreateFallbackBuffer(){} // RVA: 0x7ffaa86491d0
        public void get_MaxCharCount(){} // RVA: 0x7ffaa8649ca0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class DecoderFallbackBuffer : Object
    {
        // ── Original Methods ──
        public void Fallback(){} // RVA: 0x7ffaa864cc60
        public void get_Remaining(){} // RVA: 0x7ffaa8649ca0
        public void Reset(){} // RVA: 0x7ffaaddf1e50
        public void InternalReset(){} // RVA: 0x7ffaaddf1e90
        public void InternalInitialize(){} // RVA: 0x7ffaaddf1eb0
        public void InternalFallback(){} // RVA: 0x7ffaaddf2110
        public void InternalFallback(){} // RVA: 0x7ffaaddf2110
        public void ThrowLastBytesRecursive(){} // RVA: 0x7ffaaddf2350
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetNextChar(){} // RVA: 0x7ffaa8649100
    }

    public class DecoderNLS : Decoder
    {
        public object _throwOnOverflow; // 0x33E35830

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaddf2560
        public void Reset(){} // RVA: 0x7ffaaddf2640
        public void Convert(){} // RVA: 0x7ffaaddf31b0
        public void Convert(){} // RVA: 0x7ffaaddf31b0
        public void get_MustFlush(){} // RVA: 0x7ffaa8b0edb0
        public void get_HasState(){} // RVA: 0x7ffaa8932320
        public void ClearMustFlush(){} // RVA: 0x7ffaa9a28a10
        // ── Binary Analysis Named ──
        public void GetCharCount(){} // RVA: 0x7ffaaddf2880
        public void GetCharCount(){} // RVA: 0x7ffaaddf2880
        public void GetCharCount(){} // RVA: 0x7ffaaddf2880
        public void GetChars(){} // RVA: 0x7ffaaddf2cd0
        public void GetChars(){} // RVA: 0x7ffaaddf2cd0
        public void GetChars(){} // RVA: 0x7ffaaddf2cd0
    }

    public class DecoderReplacementFallback : DecoderFallback
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaddf3720
        public void .ctor(){} // RVA: 0x7ffaaddf3720
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7ffaaddf34e0
        public void .ctor(){} // RVA: 0x7ffaaddf3720
        public void get_DefaultString(){} // RVA: 0x7ffaa894d380
        public void CreateFallbackBuffer(){} // RVA: 0x7ffaaddf38c0
        public void get_MaxCharCount(){} // RVA: 0x7ffaaddf3960
        public void Equals(){} // RVA: 0x7ffaaddf3980
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa900a960
    }

    public class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
    {
        public object _fallbackIndex; // 0x368E1480
        public object Remaining; // 0x1700026D

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaddf3a30
        public void Fallback(){} // RVA: 0x7ffaaddf3aa0
        public void get_Remaining(){} // RVA: 0x7ffaaddf3b50
        public void Reset(){} // RVA: 0x7ffaaddf3b60
        public void InternalFallback(){} // RVA: 0x7ffaaddf3b80
        // ── Binary Analysis Named ──
        public void GetNextChar(){} // RVA: 0x7ffaaddf3af0
    }

    public class Encoder : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_Fallback(){} // RVA: 0x7ffaa894d380
        public void get_FallbackBuffer(){} // RVA: 0x7ffaaddf3ba0
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x7ffaaa268a50
        public void Reset(){} // RVA: 0x7ffaaddf3cd0
        public void Convert(){} // RVA: 0x7ffaaddf45b0
        public void Convert(){} // RVA: 0x7ffaaddf45b0
        // ── Binary Analysis Named ──
        public void GetByteCount(){} // RVA: 0x7ffaaddf3dc0
        public void GetByteCount(){} // RVA: 0x7ffaaddf3dc0
        public void GetBytes(){} // RVA: 0x7ffaaddf3f70
        public void GetBytes(){} // RVA: 0x7ffaaddf3f70
    }

    public class EncoderExceptionFallback : EncoderFallback
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void CreateFallbackBuffer(){} // RVA: 0x7ffaaddf5220
        public void get_MaxCharCount(){} // RVA: 0x7ffaa8f22da0
        public void Equals(){} // RVA: 0x7ffaaddf5260
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaddf52c0
    }

    public class EncoderFallback : Object
    {
        // ── Original Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x7ffaaddf5940
        public void get_ExceptionFallback(){} // RVA: 0x7ffaaddf5a10
        public void CreateFallbackBuffer(){} // RVA: 0x7ffaa86491d0
        public void get_MaxCharCount(){} // RVA: 0x7ffaa8649ca0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class EncoderNLS : Encoder
    {
        public object _mustFlush; // 0x33E35400

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaddf5e20
        public void Reset(){} // RVA: 0x7ffaaddf5f00
        public void Convert(){} // RVA: 0x7ffaaddf6a10
        public void Convert(){} // RVA: 0x7ffaaddf6a10
        public void get_Encoding(){} // RVA: 0x7ffaa8960130
        public void get_MustFlush(){} // RVA: 0x7ffaa8958450
        public void get_HasState(){} // RVA: 0x7ffaaddf6bf0
        public void ClearMustFlush(){} // RVA: 0x7ffaa9c8b620
        // ── Binary Analysis Named ──
        public void GetByteCount(){} // RVA: 0x7ffaaddf6120
        public void GetByteCount(){} // RVA: 0x7ffaaddf6120
        public void GetBytes(){} // RVA: 0x7ffaaddf6530
        public void GetBytes(){} // RVA: 0x7ffaaddf6530
    }

    public class EncoderReplacementFallback : EncoderFallback
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaddf6f90
        public void .ctor(){} // RVA: 0x7ffaaddf6f90
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7ffaaddf6d50
        public void .ctor(){} // RVA: 0x7ffaaddf6f90
        public void get_DefaultString(){} // RVA: 0x7ffaa894d380
        public void CreateFallbackBuffer(){} // RVA: 0x7ffaaddf7130
        public void get_MaxCharCount(){} // RVA: 0x7ffaaddf3960
        public void Equals(){} // RVA: 0x7ffaaddf71f0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa900a960
    }

    public class Encoding : Object
    {
        public object bigEndianUnicode; // 0x33E0F8E0
        public object utf32Encoding; // 0x33E0F8E0
        public object encodings; // 0x33E0F8E0
        public object MIMECONTF_SAVABLE_MAILNEWS; // 0x33E0F8E0
        public object CodePageNoOEM; // 0x33E0F8E0
        public object CodePageNoSymbol; // 0x33E0F8E0
        public object CodePageWindows1252; // 0x33E0F8E0
        public object CodePageMacKorean; // 0x33E0F8E0
        public object ISO2022JPESC; // 0x33E0F8E0
        public object ISOSimplifiedCN; // 0x33E0F8E0
        public object DuplicateEUCCN; // 0x33E0F8E0
        public object CodePageASCII; // 0x33E0F8E0
        public object ISCIIBengali; // 0x33E0F8E0
        public object ISCIIKannada; // 0x33E0F8E0
        public object ISCIIPanjabi; // 0x33E0F8E0
        public object GB18030; // 0x33E0F8E0
        public object ENC50229; // 0x33E0F8E0
        public object CodePageUTF32; // 0x33E0F8E0
        public object dataItem; // 0x33E0F8E0
        public object encoderFallback; // 0x33E0F8E0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaade11270
        public void .ctor(){} // RVA: 0x7ffaade11270
        public void OnDeserializing(){} // RVA: 0x7ffaade114b0
        public void OnDeserialized(){} // RVA: 0x7ffaade11560
        public void OnDeserializing(){} // RVA: 0x7ffaade114b0
        public void OnDeserialized(){} // RVA: 0x7ffaade11560
        public void OnSerializing(){} // RVA: 0x7ffaaab5e3e0
        public void DeserializeEncoding(){} // RVA: 0x7ffaade115f0
        public void SerializeEncoding(){} // RVA: 0x7ffaade11ab0
        public void Convert(){} // RVA: 0x7ffaade11d80
        public void Convert(){} // RVA: 0x7ffaade11d80
        public void get_InternalSyncObject(){} // RVA: 0x7ffaade11ee0
        public void get_Preamble(){} // RVA: 0x7ffaade12fd0
        public void get_BodyName(){} // RVA: 0x7ffaade131f0
        public void get_EncodingName(){} // RVA: 0x7ffaade13330
        public void get_HeaderName(){} // RVA: 0x7ffaade134b0
        public void get_WebName(){} // RVA: 0x7ffaade135f0
        public void get_IsSingleByte(){} // RVA: 0x7ffaa8932320
        public void get_EncoderFallback(){} // RVA: 0x7ffaa8960130
        public void set_EncoderFallback(){} // RVA: 0x7ffaade13730
        public void get_DecoderFallback(){} // RVA: 0x7ffaa8bfcc80
        public void set_DecoderFallback(){} // RVA: 0x7ffaade13850
        public void Clone(){} // RVA: 0x7ffaade13970
        public void get_IsReadOnly(){} // RVA: 0x7ffaa8c56a20
        public void get_ASCII(){} // RVA: 0x7ffaade13a00
        public void get_Latin1(){} // RVA: 0x7ffaade13b20
        public void get_CodePage(){} // RVA: 0x7ffaa897f5c0
        public void IsAlwaysNormalized(){} // RVA: 0x7ffaa8932320
        public void IsAlwaysNormalized(){} // RVA: 0x7ffaa8932320
        public void CreateDefaultEncoding(){} // RVA: 0x7ffaade14f50
        public void setReadOnly(){} // RVA: 0x7ffaa91942c0
        public void get_Default(){} // RVA: 0x7ffaade14fb0
        public void get_Unicode(){} // RVA: 0x7ffaade15250
        public void get_BigEndianUnicode(){} // RVA: 0x7ffaade15370
        public void get_UTF7(){} // RVA: 0x7ffaade15490
        public void get_UTF8(){} // RVA: 0x7ffaade155c0
        public void get_UTF32(){} // RVA: 0x7ffaade156e0
        public void Equals(){} // RVA: 0x7ffaade157f0
        public void ThrowBytesOverflow(){} // RVA: 0x7ffaade15b30
        public void ThrowBytesOverflow(){} // RVA: 0x7ffaade15b30
        public void ThrowCharsOverflow(){} // RVA: 0x7ffaade15cd0
        public void ThrowCharsOverflow(){} // RVA: 0x7ffaade15cd0
        // ── Binary Analysis Named ──
        public void SetDefaultFallbacks(){} // RVA: 0x7ffaade112f0
        public void GetEncoding(){} // RVA: 0x7ffaade12e10
        public void GetEncoding(){} // RVA: 0x7ffaade12e10
        public void GetEncoding(){} // RVA: 0x7ffaade12e10
        public void GetPreamble(){} // RVA: 0x7ffaade12f70
        public void GetDataItem(){} // RVA: 0x7ffaade13080
        public void GetByteCount(){} // RVA: 0x7ffaade15e10
        public void GetByteCount(){} // RVA: 0x7ffaade15e10
        public void GetByteCount(){} // RVA: 0x7ffaade15e10
        public void GetByteCount(){} // RVA: 0x7ffaade15e10
        public void GetByteCount(){} // RVA: 0x7ffaade15e10
        public void GetByteCount(){} // RVA: 0x7ffaade15e10
        public void GetBytes(){} // RVA: 0x7ffaade16000
        public void GetBytes(){} // RVA: 0x7ffaade16000
        public void GetBytes(){} // RVA: 0x7ffaade16000
        public void GetBytes(){} // RVA: 0x7ffaade16000
        public void GetBytes(){} // RVA: 0x7ffaade16000
        public void GetBytes(){} // RVA: 0x7ffaade16000
        public void GetBytes(){} // RVA: 0x7ffaade16000
        public void GetCharCount(){} // RVA: 0x7ffaade15d60
        public void GetCharCount(){} // RVA: 0x7ffaade15d60
        public void GetCharCount(){} // RVA: 0x7ffaade15d60
        public void GetCharCount(){} // RVA: 0x7ffaade15d60
        public void GetChars(){} // RVA: 0x7ffaade14bf0
        public void GetChars(){} // RVA: 0x7ffaade14bf0
        public void GetChars(){} // RVA: 0x7ffaade14bf0
        public void GetChars(){} // RVA: 0x7ffaade14bf0
        public void GetChars(){} // RVA: 0x7ffaade14bf0
        public void GetString(){} // RVA: 0x7ffaade15220
        public void GetString(){} // RVA: 0x7ffaade15220
        public void GetDecoder(){} // RVA: 0x7ffaade14eb0
        public void GetEncoder(){} // RVA: 0x7ffaade150d0
        public void GetMaxByteCount(){} // RVA: 0x7ffaa8650410
        public void GetMaxCharCount(){} // RVA: 0x7ffaa8650410
        public void GetString(){} // RVA: 0x7ffaade15220
        public void GetString(){} // RVA: 0x7ffaade15220
        public void GetHashCode(){} // RVA: 0x7ffaade158f0
        public void GetBestFitUnicodeToBytesData(){} // RVA: 0x7ffaade15960
        public void GetBestFitBytesToUnicodeData(){} // RVA: 0x7ffaade159c0
        public void GetCharCount(){} // RVA: 0x7ffaade15d60
        public void GetByteCount(){} // RVA: 0x7ffaade15e10
        public void GetBytes(){} // RVA: 0x7ffaade16000
        public void GetBytes(){} // RVA: 0x7ffaade16000
    }

    public class Rune : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8d92880
        public void .ctor(){} // RVA: 0x7ffaa8d92880
        public void .ctor(){} // RVA: 0x7ffaa8d92880
        public void get_IsAscii(){} // RVA: 0x7ffaae4a48b0
        public void get_IsBmp(){} // RVA: 0x7ffaae4a48c0
        public void op_Equality(){} // RVA: 0x7ffaaad105c0
        public void IsControl(){} // RVA: 0x7ffaae4a48d0
        public void get_ReplacementChar(){} // RVA: 0x7ffaae4a48e0
        public void get_Utf16SequenceLength(){} // RVA: 0x7ffaae4a48f0
        public void get_Value(){} // RVA: 0x7ffaa9e47550
        public void DecodeFromUtf16(){} // RVA: 0x7ffaae9edb10
        public void DecodeFromUtf8(){} // RVA: 0x7ffaae9edc40
        public void Equals(){} // RVA: 0x7ffaaa5f9340
        public void Equals(){} // RVA: 0x7ffaaa5f9340
        public void TryCreate(){} // RVA: 0x7ffaae4a4ca0
        public void TryCreate(){} // RVA: 0x7ffaae4a4ca0
        public void TryEncodeToUtf16(){} // RVA: 0x7ffaae9ede20
        public void TryEncodeToUtf8(){} // RVA: 0x7ffaae9edf10
        public void UnsafeCreate(){} // RVA: 0x7ffaaa5e80c0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa9e47550
    }

    public class StringBuilder : Object
    {
        public object m_ChunkLength; // 0x30317740
        public object DefaultCapacity; // 0x30317740
        public object StringValueField; // 0x30317740
        public object IndexLimit; // 0x30317740

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaade02020
        public void .ctor(){} // RVA: 0x7ffaade02020
        public void .ctor(){} // RVA: 0x7ffaade02020
        public void .ctor(){} // RVA: 0x7ffaade02020
        public void .ctor(){} // RVA: 0x7ffaade02020
        public void .ctor(){} // RVA: 0x7ffaade02020
        public void .ctor(){} // RVA: 0x7ffaade02020
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7ffaaddfaa50
        public void get_Capacity(){} // RVA: 0x7ffaaddfaba0
        public void set_Capacity(){} // RVA: 0x7ffaaddfabc0
        public void get_MaxCapacity(){} // RVA: 0x7ffaa8d14570
        public void EnsureCapacity(){} // RVA: 0x7ffaaddfad90
        public void ToString(){} // RVA: 0x7ffaaddfafd0
        public void ToString(){} // RVA: 0x7ffaaddfafd0
        public void Clear(){} // RVA: 0x7ffaaddfb200
        public void get_Length(){} // RVA: 0x7ffaaddfb220
        public void set_Length(){} // RVA: 0x7ffaaddfb230
        public void get_Chars(){} // RVA: 0x7ffaaddfb4e0
        public void set_Chars(){} // RVA: 0x7ffaaddfb5b0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void AppendHelper(){} // RVA: 0x7ffaaddfbb50
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void AppendCore(){} // RVA: 0x7ffaaddfbf60
        public void AppendLine(){} // RVA: 0x7ffaaddfc1d0
        public void AppendLine(){} // RVA: 0x7ffaaddfc1d0
        public void CopyTo(){} // RVA: 0x7ffaaddfc410
        public void CopyTo(){} // RVA: 0x7ffaaddfc410
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Remove(){} // RVA: 0x7ffaade02140
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void AppendSpanFormattable(){} // RVA: 0x7ffaa887e5c0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void AppendJoin(){} // RVA: 0x7ffaaddfe520
        public void AppendJoin(){} // RVA: 0x7ffaaddfe520
        public void AppendJoin(){} // RVA: 0x7ffaaddfe520
        public void AppendJoin(){} // RVA: 0x7ffaaddfe520
        public void AppendJoin(){} // RVA: 0x7ffaaddfe520
        public void AppendJoinCore(){} // RVA: 0x7ffaa887e5c0
        public void AppendJoinCore(){} // RVA: 0x7ffaa887e5c0
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void Insert(){} // RVA: 0x7ffaade00890
        public void AppendFormat(){} // RVA: 0x7ffaaddff2c0
        public void AppendFormat(){} // RVA: 0x7ffaaddff2c0
        public void AppendFormat(){} // RVA: 0x7ffaaddff2c0
        public void AppendFormat(){} // RVA: 0x7ffaaddff2c0
        public void AppendFormat(){} // RVA: 0x7ffaaddff2c0
        public void AppendFormat(){} // RVA: 0x7ffaaddff2c0
        public void AppendFormat(){} // RVA: 0x7ffaaddff2c0
        public void AppendFormat(){} // RVA: 0x7ffaaddff2c0
        public void FormatError(){} // RVA: 0x7ffaaddff3a0
        public void AppendFormatHelper(){} // RVA: 0x7ffaaddff3f0
        public void Replace(){} // RVA: 0x7ffaade004e0
        public void Equals(){} // RVA: 0x7ffaaddffed0
        public void Replace(){} // RVA: 0x7ffaade004e0
        public void Replace(){} // RVA: 0x7ffaade004e0
        public void Replace(){} // RVA: 0x7ffaade004e0
        public void Append(){} // RVA: 0x7ffaade006e0
        public void Insert(){} // RVA: 0x7ffaade00890
        public void ReplaceAllInChunk(){} // RVA: 0x7ffaade00f20
        public void StartsWith(){} // RVA: 0x7ffaade01110
        public void ReplaceInPlaceAtChunk(){} // RVA: 0x7ffaade01200
        public void ThreadSafeCopy(){} // RVA: 0x7ffaade01470
        public void ThreadSafeCopy(){} // RVA: 0x7ffaade01470
        public void FindChunkForIndex(){} // RVA: 0x7ffaade01620
        public void get_RemainingCurrentChunk(){} // RVA: 0x7ffaade01660
        public void Next(){} // RVA: 0x7ffaade016f0
        public void ExpandByABlock(){} // RVA: 0x7ffaade01740
        public void .ctor(){} // RVA: 0x7ffaade02020
        public void MakeRoom(){} // RVA: 0x7ffaade01ae0
        public void .ctor(){} // RVA: 0x7ffaade02020
        public void Remove(){} // RVA: 0x7ffaade02140
    }

    public class StringBuilderCache : Object
    {
        // ── Original Methods ──
        public void Acquire(){} // RVA: 0x7ffaade024a0
        public void Release(){} // RVA: 0x7ffaade02590
        // ── Binary Analysis Named ──
        public void GetStringAndRelease(){} // RVA: 0x7ffaade02640
    }

    public class UTF32Encoding : Encoding
    {
        public object s_bigEndianPreamble; // 0x35DF0D20
        public object _isThrowException; // 0x35DF0D20

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaade02710
        public void .ctor(){} // RVA: 0x7ffaade02710
        public void .ctor(){} // RVA: 0x7ffaade02710
        public void get_Preamble(){} // RVA: 0x7ffaade052c0
        public void Equals(){} // RVA: 0x7ffaade054b0
        public void .cctor(){} // RVA: 0x7ffaade05630
        // ── Binary Analysis Named ──
        public void SetDefaultFallbacks(){} // RVA: 0x7ffaade02780
        public void GetByteCount(){} // RVA: 0x7ffaade03c50
        public void GetByteCount(){} // RVA: 0x7ffaade03c50
        public void GetByteCount(){} // RVA: 0x7ffaade03c50
        public void GetBytes(){} // RVA: 0x7ffaade04010
        public void GetBytes(){} // RVA: 0x7ffaade04010
        public void GetBytes(){} // RVA: 0x7ffaade04010
        public void GetCharCount(){} // RVA: 0x7ffaade045d0
        public void GetCharCount(){} // RVA: 0x7ffaade045d0
        public void GetChars(){} // RVA: 0x7ffaade04920
        public void GetChars(){} // RVA: 0x7ffaade04920
        public void GetString(){} // RVA: 0x7ffaade03a70
        public void GetByteCount(){} // RVA: 0x7ffaade03c50
        public void GetBytes(){} // RVA: 0x7ffaade04010
        public void GetCharCount(){} // RVA: 0x7ffaade045d0
        public void GetChars(){} // RVA: 0x7ffaade04920
        public void GetSurrogate(){} // RVA: 0x7ffaade04ec0
        public void GetHighSurrogate(){} // RVA: 0x7ffaade04ee0
        public void GetLowSurrogate(){} // RVA: 0x7ffaade04f00
        public void GetDecoder(){} // RVA: 0x7ffaade04f20
        public void GetEncoder(){} // RVA: 0x7ffaade04f80
        public void GetMaxByteCount(){} // RVA: 0x7ffaade04fe0
        public void GetMaxCharCount(){} // RVA: 0x7ffaade05120
        public void GetPreamble(){} // RVA: 0x7ffaade05200
        public void GetHashCode(){} // RVA: 0x7ffaade05580
    }

    public class UTF8Encoding : Encoding
    {
        public object _emitUTF8Identifier; // 0x33E34980

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaade08140
        public void .ctor(){} // RVA: 0x7ffaade08140
        public void .ctor(){} // RVA: 0x7ffaade08140
        public void PtrDiff(){} // RVA: 0x7ffaade09d90
        public void PtrDiff(){} // RVA: 0x7ffaade09d90
        public void InRange(){} // RVA: 0x7ffaade09da0
        public void FallbackInvalidByteSequence(){} // RVA: 0x7ffaade0b460
        public void FallbackInvalidByteSequence(){} // RVA: 0x7ffaade0b460
        public void get_Preamble(){} // RVA: 0x7ffaade0bb00
        public void Equals(){} // RVA: 0x7ffaade0bcc0
        public void .cctor(){} // RVA: 0x7ffaade0be30
        // ── Binary Analysis Named ──
        public void SetDefaultFallbacks(){} // RVA: 0x7ffaade081b0
        public void GetByteCount(){} // RVA: 0x7ffaade09680
        public void GetByteCount(){} // RVA: 0x7ffaade09680
        public void GetByteCount(){} // RVA: 0x7ffaade09680
        public void GetBytes(){} // RVA: 0x7ffaade09db0
        public void GetBytes(){} // RVA: 0x7ffaade09db0
        public void GetBytes(){} // RVA: 0x7ffaade09db0
        public void GetCharCount(){} // RVA: 0x7ffaade0a640
        public void GetCharCount(){} // RVA: 0x7ffaade0a640
        public void GetChars(){} // RVA: 0x7ffaade0ab20
        public void GetChars(){} // RVA: 0x7ffaade0ab20
        public void GetString(){} // RVA: 0x7ffaade094a0
        public void GetByteCount(){} // RVA: 0x7ffaade09680
        public void GetBytes(){} // RVA: 0x7ffaade09db0
        public void GetCharCount(){} // RVA: 0x7ffaade0a640
        public void GetChars(){} // RVA: 0x7ffaade0ab20
        public void GetBytesUnknown(){} // RVA: 0x7ffaade0b4b0
        public void GetDecoder(){} // RVA: 0x7ffaade0b720
        public void GetEncoder(){} // RVA: 0x7ffaade0b780
        public void GetMaxByteCount(){} // RVA: 0x7ffaade0b7e0
        public void GetMaxCharCount(){} // RVA: 0x7ffaade0b920
        public void GetPreamble(){} // RVA: 0x7ffaade0ba60
        public void GetHashCode(){} // RVA: 0x7ffaade0bdc0
    }

    public class UnicodeEncoding : Encoding
    {
        public object s_bigEndianPreamble; // 0x35DF1390
        public object bigEndian; // 0x35DF1390

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaade0c290
        public void .ctor(){} // RVA: 0x7ffaade0c290
        public void .ctor(){} // RVA: 0x7ffaade0c290
        public void get_Preamble(){} // RVA: 0x7ffaade0fe20
        public void Equals(){} // RVA: 0x7ffaade102a0
        public void .cctor(){} // RVA: 0x7ffaade10480
        // ── Binary Analysis Named ──
        public void SetDefaultFallbacks(){} // RVA: 0x7ffaade0c310
        public void GetByteCount(){} // RVA: 0x7ffaade0d7e0
        public void GetByteCount(){} // RVA: 0x7ffaade0d7e0
        public void GetByteCount(){} // RVA: 0x7ffaade0d7e0
        public void GetBytes(){} // RVA: 0x7ffaade0df80
        public void GetBytes(){} // RVA: 0x7ffaade0df80
        public void GetBytes(){} // RVA: 0x7ffaade0df80
        public void GetCharCount(){} // RVA: 0x7ffaade0e910
        public void GetCharCount(){} // RVA: 0x7ffaade0e910
        public void GetChars(){} // RVA: 0x7ffaade0f1b0
        public void GetChars(){} // RVA: 0x7ffaade0f1b0
        public void GetString(){} // RVA: 0x7ffaade0d600
        public void GetByteCount(){} // RVA: 0x7ffaade0d7e0
        public void GetBytes(){} // RVA: 0x7ffaade0df80
        public void GetCharCount(){} // RVA: 0x7ffaade0e910
        public void GetChars(){} // RVA: 0x7ffaade0f1b0
        public void GetEncoder(){} // RVA: 0x7ffaade0fca0
        public void GetDecoder(){} // RVA: 0x7ffaade0fd00
        public void GetPreamble(){} // RVA: 0x7ffaade0fd60
        public void GetMaxByteCount(){} // RVA: 0x7ffaade10010
        public void GetMaxCharCount(){} // RVA: 0x7ffaade10150
        public void GetHashCode(){} // RVA: 0x7ffaade103e0
    }

}