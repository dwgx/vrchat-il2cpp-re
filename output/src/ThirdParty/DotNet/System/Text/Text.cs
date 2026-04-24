// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text
// Classes: 19
// Methods: 409

namespace ThirdParty.DotNet.System.Text
{
    public class Decoder : Object
    {
        public em.MarkAborted.ugView`1 Fallback; // 0x10
        public em.MarkAborted.FlowControl FallbackBuffer; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_Fallback(){} // RVA: 0x7FFD4E35C380
        public void get_FallbackBuffer(){} // RVA: 0x7FFD537EF180
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x7FFD4FC80B40
        public void Reset(){} // RVA: 0x7FFD537EF2B0
        public void GetCharCount(){} // RVA: 0x7FFD537EF3C0 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFD537EF7D0 | overloaded x4
        public void Convert(){} // RVA: 0x7FFD537EFD00 | overloaded x2
    }

    public class DecoderExceptionFallback : DecoderFallback
    {
        public object MaxCharCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void CreateFallbackBuffer(){} // RVA: 0x7FFD537F0760
        public void get_MaxCharCount(){} // RVA: 0x7FFD4E919180
        public void Equals(){} // RVA: 0x7FFD537F07A0
        public void GetHashCode(){} // RVA: 0x7FFD537F0800
    }

    public class DecoderFallback : Object
    {
        public em.MarkAborted.ugView`1 ReplacementFallback;
        public em.MarkAborted.ugView`1 ExceptionFallback; // 0x8

        // ── Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x7FFD537F0B40
        public void get_ExceptionFallback(){} // RVA: 0x7FFD537F0C10
        public void CreateFallbackBuffer(){} // RVA: 0x7FFD4E078E90
        public void get_MaxCharCount(){} // RVA: 0x7FFD4E079960
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class DecoderFallbackBuffer : Object
    {
        public object Remaining;

        // ── Methods ──
        public void Fallback(){} // RVA: 0x7FFD4E07C920
        public void GetNextChar(){} // RVA: 0x7FFD4E078DC0
        public void get_Remaining(){} // RVA: 0x7FFD4E079960
        public void Reset(){} // RVA: 0x7FFD537F0CA0
        public void InternalReset(){} // RVA: 0x7FFD537F0CE0
        public void InternalInitialize(){} // RVA: 0x7FFD537F0D00
        public void InternalFallback(){} // RVA: 0x7FFD537F0F60 | overloaded x2
        public void ThrowLastBytesRecursive(){} // RVA: 0x7FFD537F11A0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class DecoderNLS : Decoder
    {
        public em.MarkAborted.ION_4_7 MustFlush; // 0x20
        public bool HasState; // 0x28
        public bool _throwOnOverflow; // 0x29
        public int _bytesUsed; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537F13B0
        public void Reset(){} // RVA: 0x7FFD537F1490
        public void GetCharCount(){} // RVA: 0x7FFD537F16D0 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFD537F1B20 | overloaded x3
        public void Convert(){} // RVA: 0x7FFD537F2000 | overloaded x2
        public void get_MustFlush(){} // RVA: 0x7FFD4E516BA0
        public void get_HasState(){} // RVA: 0x7FFD4E341320
        public void ClearMustFlush(){} // RVA: 0x7FFD4FD6FE90
    }

    public class DecoderReplacementFallback : DecoderFallback
    {
        public string DefaultString; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537F2570 | overloaded x3
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD537F2330
        public void get_DefaultString(){} // RVA: 0x7FFD4E35C380
        public void CreateFallbackBuffer(){} // RVA: 0x7FFD537F2710
        public void get_MaxCharCount(){} // RVA: 0x7FFD537F27B0
        public void Equals(){} // RVA: 0x7FFD537F27D0
        public void GetHashCode(){} // RVA: 0x7FFD4E9FB750
    }

    public class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
    {
        public object Remaining;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537F2880
        public void Fallback(){} // RVA: 0x7FFD537F28F0
        public void GetNextChar(){} // RVA: 0x7FFD537F2940
        public void get_Remaining(){} // RVA: 0x7FFD537F29A0
        public void Reset(){} // RVA: 0x7FFD537F29B0
        public void InternalFallback(){} // RVA: 0x7FFD537F29D0
    }

    public class Encoder : Object
    {
        public em.MarkAborted.CreateMutableCopy Fallback; // 0x10
        public em.MarkAborted.y FallbackBuffer; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_Fallback(){} // RVA: 0x7FFD4E35C380
        public void get_FallbackBuffer(){} // RVA: 0x7FFD537F29F0
        public void get_InternalHasFallbackBuffer(){} // RVA: 0x7FFD4FC80B40
        public void Reset(){} // RVA: 0x7FFD537F2B20
        public void GetByteCount(){} // RVA: 0x7FFD537F2C10 | overloaded x2
        public void GetBytes(){} // RVA: 0x7FFD537F2DC0 | overloaded x2
        public void Convert(){} // RVA: 0x7FFD537F3400 | overloaded x2
    }

    public class EncoderExceptionFallback : EncoderFallback
    {
        public object MaxCharCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void CreateFallbackBuffer(){} // RVA: 0x7FFD537F4070
        public void get_MaxCharCount(){} // RVA: 0x7FFD4E919180
        public void Equals(){} // RVA: 0x7FFD537F40B0
        public void GetHashCode(){} // RVA: 0x7FFD537F4110
    }

    public class EncoderFallback : Object
    {
        public em.MarkAborted.CreateMutableCopy ReplacementFallback;
        public em.MarkAborted.CreateMutableCopy ExceptionFallback; // 0x8

        // ── Methods ──
        public void get_ReplacementFallback(){} // RVA: 0x7FFD537F4790
        public void get_ExceptionFallback(){} // RVA: 0x7FFD537F4860
        public void CreateFallbackBuffer(){} // RVA: 0x7FFD4E078E90
        public void get_MaxCharCount(){} // RVA: 0x7FFD4E079960
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class EncoderNLS : Encoder
    {
        public char Encoding; // 0x20
        public em.MarkAborted.ION_4_7 MustFlush; // 0x28
        public bool HasState; // 0x30
        public bool _throwOnOverflow; // 0x31
        public int _charsUsed; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537F4C70
        public void Reset(){} // RVA: 0x7FFD537F4D50
        public void GetByteCount(){} // RVA: 0x7FFD537F4F70 | overloaded x2
        public void GetBytes(){} // RVA: 0x7FFD537F5380 | overloaded x2
        public void Convert(){} // RVA: 0x7FFD537F5860 | overloaded x2
        public void get_Encoding(){} // RVA: 0x7FFD4E36F130
        public void get_MustFlush(){} // RVA: 0x7FFD4E367450
        public void get_HasState(){} // RVA: 0x7FFD537F5A40
        public void ClearMustFlush(){} // RVA: 0x7FFD4F689BB0
    }

    public class EncoderReplacementFallback : EncoderFallback
    {
        public string DefaultString; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537F5DE0 | overloaded x3
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD537F5BA0
        public void get_DefaultString(){} // RVA: 0x7FFD4E35C380
        public void CreateFallbackBuffer(){} // RVA: 0x7FFD537F5F80
        public void get_MaxCharCount(){} // RVA: 0x7FFD537F27B0
        public void Equals(){} // RVA: 0x7FFD537F6040
        public void GetHashCode(){} // RVA: 0x7FFD4E9FB750
    }

    public class Encoding : Object
    {
        public em.MarkAborted.ION_4_7 InternalSyncObject;
        public em.MarkAborted.ION_4_7 Preamble; // 0x8
        public em.MarkAborted.ION_4_7 BodyName; // 0x10
        public em.MarkAborted.ION_4_7 EncodingName; // 0x18
        public em.MarkAborted.ION_4_7 HeaderName; // 0x20
        public em.MarkAborted.ION_4_7 WebName; // 0x28
        public em.MarkAborted.ION_4_7 IsSingleByte; // 0x30
        public em.MarkAborted.ION_4_7 EncoderFallback; // 0x38
        public URA.DateTime<int,em.MarkAborted.ION_4_7> DecoderFallback; // 0x40
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
        public 0.S dataItem; // 0x18
        public bool m_deserializedFromEverett; // 0x20
        public bool m_isReadOnly; // 0x21
        public em.MarkAborted.CreateMutableCopy encoderFallback; // 0x28
        public em.MarkAborted.ugView`1 decoderFallback; // 0x30
        public object s_InternalSyncObject; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD538100C0 | overloaded x2
        public void SetDefaultFallbacks(){} // RVA: 0x7FFD53810140
        public void OnDeserializing(){} // RVA: 0x7FFD53810300 | overloaded x2
        public void OnDeserialized(){} // RVA: 0x7FFD538103B0 | overloaded x2
        public void OnSerializing(){} // RVA: 0x7FFD5057CC20
        public void DeserializeEncoding(){} // RVA: 0x7FFD53810440
        public void SerializeEncoding(){} // RVA: 0x7FFD53810900
        public void Convert(){} // RVA: 0x7FFD53810BD0 | overloaded x2
        public void get_InternalSyncObject(){} // RVA: 0x7FFD53810D30
        public void GetEncoding(){} // RVA: 0x7FFD53811C60 | overloaded x3
        public void GetPreamble(){} // RVA: 0x7FFD53811DC0
        public void get_Preamble(){} // RVA: 0x7FFD53811E20
        public void GetDataItem(){} // RVA: 0x7FFD53811ED0
        public void get_BodyName(){} // RVA: 0x7FFD53812040
        public void get_EncodingName(){} // RVA: 0x7FFD53812180
        public void get_HeaderName(){} // RVA: 0x7FFD53812300
        public void get_WebName(){} // RVA: 0x7FFD53812440
        public void get_IsSingleByte(){} // RVA: 0x7FFD4E341320
        public void get_EncoderFallback(){} // RVA: 0x7FFD4E36F130
        public void set_EncoderFallback(){} // RVA: 0x7FFD53812580
        public void get_DecoderFallback(){} // RVA: 0x7FFD4E5F95E0
        public void set_DecoderFallback(){} // RVA: 0x7FFD538126A0
        public void Clone(){} // RVA: 0x7FFD538127C0
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E64AD20
        public void get_ASCII(){} // RVA: 0x7FFD53812850
        public void get_Latin1(){} // RVA: 0x7FFD53812970
        public void GetByteCount(){} // RVA: 0x7FFD53814C60 | overloaded x7
        public void GetBytes(){} // RVA: 0x7FFD53814E50 | overloaded x9
        public void GetCharCount(){} // RVA: 0x7FFD53814BB0 | overloaded x5
        public void GetChars(){} // RVA: 0x7FFD53813A40 | overloaded x5
        public void GetString(){} // RVA: 0x7FFD53814070 | overloaded x4
        public void get_CodePage(){} // RVA: 0x7FFD4E38E5C0
        public void IsAlwaysNormalized(){} // RVA: 0x7FFD4E341320 | overloaded x2
        public void GetDecoder(){} // RVA: 0x7FFD53813D00
        public void CreateDefaultEncoding(){} // RVA: 0x7FFD53813DA0
        public void setReadOnly(){} // RVA: 0x7FFD4EB8A610
        public void get_Default(){} // RVA: 0x7FFD53813E00
        public void GetEncoder(){} // RVA: 0x7FFD53813F20
        public void GetMaxByteCount(){} // RVA: 0x7FFD4E0800D0
        public void GetMaxCharCount(){} // RVA: 0x7FFD4E0800D0
        public void get_Unicode(){} // RVA: 0x7FFD538140A0
        public void get_BigEndianUnicode(){} // RVA: 0x7FFD538141C0
        public void get_UTF7(){} // RVA: 0x7FFD538142E0
        public void get_UTF8(){} // RVA: 0x7FFD53814410
        public void get_UTF32(){} // RVA: 0x7FFD53814530
        public void Equals(){} // RVA: 0x7FFD53814640
        public void GetHashCode(){} // RVA: 0x7FFD53814740
        public void GetBestFitUnicodeToBytesData(){} // RVA: 0x7FFD538147B0
        public void GetBestFitBytesToUnicodeData(){} // RVA: 0x7FFD53814810
        public void ThrowBytesOverflow(){} // RVA: 0x7FFD53814980 | overloaded x2
        public void ThrowCharsOverflow(){} // RVA: 0x7FFD53814B20 | overloaded x2
    }

    public class Rune : ValueType
    {
        public object IsAscii;
        public object IsBmp;
        public object ReplacementChar;
        public object Utf16SequenceLength;
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E78D8B0 | overloaded x3
        public void get_IsAscii(){} // RVA: 0x7FFD53EA3690
        public void get_IsBmp(){} // RVA: 0x7FFD53EA36A0
        public void op_Equality(){} // RVA: 0x7FFD5072E660
        public void IsControl(){} // RVA: 0x7FFD53EA36B0
        public void get_ReplacementChar(){} // RVA: 0x7FFD53EA36C0
        public void get_Utf16SequenceLength(){} // RVA: 0x7FFD53EA36D0
        public void get_Value(){} // RVA: 0x7FFD4F840210
        public void DecodeFromUtf16(){} // RVA: 0x7FFD543EBB40
        public void DecodeFromUtf8(){} // RVA: 0x7FFD543EBC70
        public void Equals(){} // RVA: 0x7FFD50017E90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
        public void TryCreate(){} // RVA: 0x7FFD53EA3A80 | overloaded x2
        public void TryEncodeToUtf16(){} // RVA: 0x7FFD543EBE50
        public void TryEncodeToUtf8(){} // RVA: 0x7FFD543EBF40
        public void UnsafeCreate(){} // RVA: 0x7FFD50006C10
    }

    public class StringBuilder : Object
    {
        public char[] Capacity; // 0x10
        public em.MarkAborted.izeDefaultCase MaxCapacity; // 0x18
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
        public void .ctor(){} // RVA: 0x7FFD53800E70 | overloaded x9
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD537F98A0
        public void get_Capacity(){} // RVA: 0x7FFD537F99F0
        public void set_Capacity(){} // RVA: 0x7FFD537F9A10
        public void get_MaxCapacity(){} // RVA: 0x7FFD4E70C4C0
        public void EnsureCapacity(){} // RVA: 0x7FFD537F9BE0
        public void ToString(){} // RVA: 0x7FFD537F9E20 | overloaded x2
        public void Clear(){} // RVA: 0x7FFD537FA050
        public void get_Length(){} // RVA: 0x7FFD537FA070
        public void set_Length(){} // RVA: 0x7FFD537FA080
        public void get_Chars(){} // RVA: 0x7FFD537FA330
        public void set_Chars(){} // RVA: 0x7FFD537FA400
        public void Append(){} // RVA: 0x7FFD537FF530 | overloaded x23
        public void AppendHelper(){} // RVA: 0x7FFD537FA9A0
        public void AppendCore(){} // RVA: 0x7FFD537FADB0
        public void AppendLine(){} // RVA: 0x7FFD537FB020 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFD537FB260 | overloaded x2
        public void Insert(){} // RVA: 0x7FFD537FF6E0 | overloaded x19
        public void Remove(){} // RVA: 0x7FFD53800F90 | overloaded x2
        public void AppendSpanFormattable(){} // RVA: 0x7FFD4E2ADC40
        public void AppendJoin(){} // RVA: 0x7FFD537FD370 | overloaded x5
        public void AppendJoinCore(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void AppendFormat(){} // RVA: 0x7FFD537FE110 | overloaded x8
        public void FormatError(){} // RVA: 0x7FFD537FE1F0
        public void AppendFormatHelper(){} // RVA: 0x7FFD537FE240
        public void Replace(){} // RVA: 0x7FFD537FF330 | overloaded x4
        public void Equals(){} // RVA: 0x7FFD537FED20
        public void ReplaceAllInChunk(){} // RVA: 0x7FFD537FFD70
        public void StartsWith(){} // RVA: 0x7FFD537FFF60
        public void ReplaceInPlaceAtChunk(){} // RVA: 0x7FFD53800050
        public void ThreadSafeCopy(){} // RVA: 0x7FFD538002C0 | overloaded x2
        public void FindChunkForIndex(){} // RVA: 0x7FFD53800470
        public void get_RemainingCurrentChunk(){} // RVA: 0x7FFD538004B0
        public void Next(){} // RVA: 0x7FFD53800540
        public void ExpandByABlock(){} // RVA: 0x7FFD53800590
        public void MakeRoom(){} // RVA: 0x7FFD53800930
    }

    public class StringBuilderCache : Object
    {
        public em.MarkAborted.izeDefaultCase t_cachedInstance; // 0xFFFFFFFF

        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFD538012F0
        public void Release(){} // RVA: 0x7FFD538013E0
        public void GetStringAndRelease(){} // RVA: 0x7FFD53801490
    }

    public class UTF32Encoding : Encoding
    {
        public object Preamble;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53801560 | overloaded x3
        public void SetDefaultFallbacks(){} // RVA: 0x7FFD538015D0
        public void GetByteCount(){} // RVA: 0x7FFD53802AA0 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFD53802E60 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFD53803420 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFD53803770 | overloaded x3
        public void GetString(){} // RVA: 0x7FFD538028C0
        public void GetSurrogate(){} // RVA: 0x7FFD53803D10
        public void GetHighSurrogate(){} // RVA: 0x7FFD53803D30
        public void GetLowSurrogate(){} // RVA: 0x7FFD53803D50
        public void GetDecoder(){} // RVA: 0x7FFD53803D70
        public void GetEncoder(){} // RVA: 0x7FFD53803DD0
        public void GetMaxByteCount(){} // RVA: 0x7FFD53803E30
        public void GetMaxCharCount(){} // RVA: 0x7FFD53803F70
        public void GetPreamble(){} // RVA: 0x7FFD53804050
        public void get_Preamble(){} // RVA: 0x7FFD53804110
        public void Equals(){} // RVA: 0x7FFD53804300
        public void GetHashCode(){} // RVA: 0x7FFD538043D0
        public void .cctor(){} // RVA: 0x7FFD53804480
    }

    public class UTF8Encoding : Encoding
    {
        public entCultureNoAppX Preamble;
        public byte[] s_preamble; // 0x8
        public bool _emitUTF8Identifier; // 0x38
        public bool _isThrowException; // 0x39

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53806F90 | overloaded x3
        public void SetDefaultFallbacks(){} // RVA: 0x7FFD53807000
        public void GetByteCount(){} // RVA: 0x7FFD538084D0 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFD53808C00 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFD53809490 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFD53809970 | overloaded x3
        public void GetString(){} // RVA: 0x7FFD538082F0
        public void PtrDiff(){} // RVA: 0x7FFD53808BE0 | overloaded x2
        public void InRange(){} // RVA: 0x7FFD53808BF0
        public void FallbackInvalidByteSequence(){} // RVA: 0x7FFD5380A2B0 | overloaded x2
        public void GetBytesUnknown(){} // RVA: 0x7FFD5380A300
        public void GetDecoder(){} // RVA: 0x7FFD5380A570
        public void GetEncoder(){} // RVA: 0x7FFD5380A5D0
        public void GetMaxByteCount(){} // RVA: 0x7FFD5380A630
        public void GetMaxCharCount(){} // RVA: 0x7FFD5380A770
        public void GetPreamble(){} // RVA: 0x7FFD5380A8B0
        public void get_Preamble(){} // RVA: 0x7FFD5380A950
        public void Equals(){} // RVA: 0x7FFD5380AB10
        public void GetHashCode(){} // RVA: 0x7FFD5380AC10
        public void .cctor(){} // RVA: 0x7FFD5380AC80
    }

    public class UnicodeEncoding : Encoding
    {
        public object Preamble;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5380B0E0 | overloaded x3
        public void SetDefaultFallbacks(){} // RVA: 0x7FFD5380B160
        public void GetByteCount(){} // RVA: 0x7FFD5380C630 | overloaded x4
        public void GetBytes(){} // RVA: 0x7FFD5380CDD0 | overloaded x4
        public void GetCharCount(){} // RVA: 0x7FFD5380D760 | overloaded x3
        public void GetChars(){} // RVA: 0x7FFD5380E000 | overloaded x3
        public void GetString(){} // RVA: 0x7FFD5380C450
        public void GetEncoder(){} // RVA: 0x7FFD5380EAF0
        public void GetDecoder(){} // RVA: 0x7FFD5380EB50
        public void GetPreamble(){} // RVA: 0x7FFD5380EBB0
        public void get_Preamble(){} // RVA: 0x7FFD5380EC70
        public void GetMaxByteCount(){} // RVA: 0x7FFD5380EE60
        public void GetMaxCharCount(){} // RVA: 0x7FFD5380EFA0
        public void Equals(){} // RVA: 0x7FFD5380F0F0
        public void GetHashCode(){} // RVA: 0x7FFD5380F230
        public void .cctor(){} // RVA: 0x7FFD5380F2D0
    }

}