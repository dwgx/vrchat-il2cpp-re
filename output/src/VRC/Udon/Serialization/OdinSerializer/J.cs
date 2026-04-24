// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 4
// Methods: 108

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class JsonConfig : Object
    {
        public string ID_SIG;
        public string TYPE_SIG;
        public string REGULAR_ARRAY_LENGTH_SIG;
        public string PRIMITIVE_ARRAY_LENGTH_SIG;
        public string REGULAR_ARRAY_CONTENT_SIG;
        public string PRIMITIVE_ARRAY_CONTENT_SIG;
        public string INTERNAL_REF_SIG;
        public string EXTERNAL_INDEX_REF_SIG;
        public string EXTERNAL_GUID_REF_SIG;
        public string EXTERNAL_STRING_REF_SIG_OLD;
        public string EXTERNAL_STRING_REF_SIG_FIXED;
    }

    public class JsonDataReader : BaseDataReader
    {
        public otRelativeToRoot Stream; // 0x30
        public aphy<LinePlane> peekedEntryType; // 0x38
        public string peekedEntryName; // 0x40
        public string peekedEntryContent; // 0x48
        public URA.DateTime<int,?> seenTypes; // 0x50
        public URA.DateTime<?,formation> primitiveArrayReaders; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD553ED720 | overloaded x2
        public void get_Stream(){} // RVA: 0x7FFD4E36F130
        public void set_Stream(){} // RVA: 0x7FFD553EE5A0
        public void Dispose(){} // RVA: 0x7FFD553EE790
        public void PeekEntry(){} // RVA: 0x7FFD553E43C0 | overloaded x2
        public void EnterNode(){} // RVA: 0x7FFD553EE930
        public void ExitNode(){} // RVA: 0x7FFD553EEFE0
        public void EnterArray(){} // RVA: 0x7FFD553EF1B0
        public void ExitArray(){} // RVA: 0x7FFD553EF4B0
        public void ReadPrimitiveArray(){} // RVA: 0x7FFD4E079F60
        public void ReadBoolean(){} // RVA: 0x7FFD553EF630
        public void ReadInternalReference(){} // RVA: 0x7FFD553EF760
        public void ReadExternalReference(){} // RVA: 0x7FFD553EFC80 | overloaded x3
        public void ReadChar(){} // RVA: 0x7FFD553EFF20
        public void ReadString(){} // RVA: 0x7FFD553F0040
        public void ReadGuid(){} // RVA: 0x7FFD553F0200
        public void ReadSByte(){} // RVA: 0x7FFD553F04C0
        public void ReadInt16(){} // RVA: 0x7FFD553F0570
        public void ReadInt32(){} // RVA: 0x7FFD553F0630
        public void ReadInt64(){} // RVA: 0x7FFD553F06F0
        public void ReadByte(){} // RVA: 0x7FFD553F08E0
        public void ReadUInt16(){} // RVA: 0x7FFD553F0990
        public void ReadUInt32(){} // RVA: 0x7FFD553F0A50
        public void ReadUInt64(){} // RVA: 0x7FFD553F0B10
        public void ReadDecimal(){} // RVA: 0x7FFD553F0D00
        public void ReadSingle(){} // RVA: 0x7FFD553F0F80
        public void ReadDouble(){} // RVA: 0x7FFD553F11D0
        public void ReadNull(){} // RVA: 0x7FFD553F1420
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFD553F1520
        public void GetDataDump(){} // RVA: 0x7FFD553F1680
        public void ReadToNextEntry(){} // RVA: 0x7FFD553F18E0
        public void MarkEntryConsumed(){} // RVA: 0x7FFD553F1910
        public void ReadAnyIntReference(){} // RVA: 0x7FFD553F1980
        public void <.ctor>b__7_0(){} // RVA: 0x7FFD553F1B80
        public void <.ctor>b__7_1(){} // RVA: 0x7FFD553F1BB0
        public void <.ctor>b__7_2(){} // RVA: 0x7FFD553F1BE0
        public void <.ctor>b__7_3(){} // RVA: 0x7FFD553F1C10
        public void <.ctor>b__7_4(){} // RVA: 0x7FFD553F1C40
        public void <.ctor>b__7_5(){} // RVA: 0x7FFD553F1C70
        public void <.ctor>b__7_6(){} // RVA: 0x7FFD553F1CA0
        public void <.ctor>b__7_7(){} // RVA: 0x7FFD553F1CD0
        public void <.ctor>b__7_8(){} // RVA: 0x7FFD553F1D00
        public void <.ctor>b__7_9(){} // RVA: 0x7FFD553F1D30
        public void <.ctor>b__7_10(){} // RVA: 0x7FFD553F1D70
        public void <.ctor>b__7_11(){} // RVA: 0x7FFD553F1DA0
        public void <.ctor>b__7_12(){} // RVA: 0x7FFD553F1DD0
        public void <.ctor>b__7_13(){} // RVA: 0x7FFD553F1E00
    }

    public class JsonDataWriter : BaseDataWriter
    {
        public uint[] ByteToHexCharLookup;
        public string NEW_LINE; // 0x8
        public bool justStarted; // 0x30
        public bool forceNoSeparatorNextLine; // 0x31
        public URA.DateTime<?,formation> primitiveTypeWriters; // 0x38
        public URA.DateTime<?,int> seenTypes; // 0x40
        public byte[] buffer; // 0x48
        public int bufferIndex; // 0x50
        public bool FormatAsReadable; // 0x54
        public bool EnableTypeOptimization; // 0x55

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD553F1E60 | overloaded x2
        public void MarkJustStarted(){} // RVA: 0x7FFD4F689BA0
        public void FlushToStream(){} // RVA: 0x7FFD553F2CE0
        public void BeginReferenceNode(){} // RVA: 0x7FFD553F2D80
        public void BeginStructNode(){} // RVA: 0x7FFD553F2E80
        public void EndNode(){} // RVA: 0x7FFD553F2F40
        public void BeginArrayNode(){} // RVA: 0x7FFD553F2FF0
        public void EndArrayNode(){} // RVA: 0x7FFD553F30A0
        public void WritePrimitiveArray(){} // RVA: 0x7FFD4E090A40
        public void WriteBoolean(){} // RVA: 0x7FFD553F3100
        public void WriteByte(){} // RVA: 0x7FFD553F3190
        public void WriteChar(){} // RVA: 0x7FFD553F31B0
        public void WriteDecimal(){} // RVA: 0x7FFD553F32E0
        public void WriteDouble(){} // RVA: 0x7FFD553F33F0
        public void WriteInt32(){} // RVA: 0x7FFD553F3530
        public void WriteInt64(){} // RVA: 0x7FFD553F3550
        public void WriteNull(){} // RVA: 0x7FFD553F36E0
        public void WriteInternalReference(){} // RVA: 0x7FFD553F3730
        public void WriteSByte(){} // RVA: 0x7FFD553F38E0
        public void WriteInt16(){} // RVA: 0x7FFD553F3900
        public void WriteSingle(){} // RVA: 0x7FFD553F3920
        public void WriteString(){} // RVA: 0x7FFD553F3A60
        public void WriteGuid(){} // RVA: 0x7FFD553F3D00
        public void WriteUInt32(){} // RVA: 0x7FFD553F3DE0
        public void WriteUInt64(){} // RVA: 0x7FFD553F3E00
        public void WriteExternalReference(){} // RVA: 0x7FFD553F4250 | overloaded x3
        public void WriteUInt16(){} // RVA: 0x7FFD553F4410
        public void Dispose(){} // RVA: 0x7FFD4E341310
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFD553F4430
        public void GetDataDump(){} // RVA: 0x7FFD553F4490
        public void WriteEntry(){} // RVA: 0x7FFD553F4940 | overloaded x2
        public void WriteTypeEntry(){} // RVA: 0x7FFD553F4BC0
        public void StartNewLine(){} // RVA: 0x7FFD553F4E60
        public void EnsureBufferSpace(){} // RVA: 0x7FFD553F5080
        public void Buffer_WriteString_WithEscape(){} // RVA: 0x7FFD553F5120
        public void CreateByteToHexLookup(){} // RVA: 0x7FFD553F56E0
        public void .cctor(){} // RVA: 0x7FFD553F58D0
    }

    public class JsonTextReader : Object
    {
        public URA.DateTime<char,aphy<LinePlane>> Context;
        public URA.DateTime<char,char> UnescapeDictionary; // 0x8
        public Inherited.ht_to_left reader; // 0x10
        public int bufferIndex; // 0x18
        public char[] buffer; // 0x20
        public aphy<char> lastReadChar; // 0x28
        public aphy<char> peekedChar; // 0x2C
        public URA.ge<char> emergencyPlayback; // 0x30
        public rASCIIFast <Context>k__BackingField; // 0x38

        // ── Methods ──
        public void get_Context(){} // RVA: 0x7FFD4E5F0140
        public void set_Context(){} // RVA: 0x7FFD4E5F0C20
        public void .ctor(){} // RVA: 0x7FFD553F65E0
        public void Reset(){} // RVA: 0x7FFD553F6830
        public void Dispose(){} // RVA: 0x7FFD4E341310
        public void ReadToNextEntry(){} // RVA: 0x7FFD553F6880
        public void ParseEntryFromBuffer(){} // RVA: 0x7FFD553F7600
        public void IsHex(){} // RVA: 0x7FFD553F83A0
        public void ParseSingleChar(){} // RVA: 0x7FFD553F83D0
        public void ParseHexChar(){} // RVA: 0x7FFD553F8410
        public void ReadCharIntoBuffer(){} // RVA: 0x7FFD553F8690
        public void GuessPrimitiveType(){} // RVA: 0x7FFD553F87E0
        public void PeekChar(){} // RVA: 0x7FFD553F8B60
        public void SkipChar(){} // RVA: 0x7FFD553F8C50
        public void ConsumeChar(){} // RVA: 0x7FFD553F8D00
        public void .cctor(){} // RVA: 0x7FFD553F8DD0
    }

}