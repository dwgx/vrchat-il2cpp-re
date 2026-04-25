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
        public VRC.Udon.Serialization.OdinSerializer.JsonTextReader Stream; // 0x30
        public System.Nullable`1<0x6B223DD8> peekedEntryType; // 0x38
        public string peekedEntryName; // 0x40
        public string peekedEntryContent; // 0x48
        public System.Collections.Generic.Dictionary`2<int,System.Type> seenTypes; // 0x50
        public System.Collections.Generic.Dictionary`2<System.Type,System.Delegate> primitiveArrayReaders; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9FCD720 | overloaded x2
        public void get_Stream(){} // RVA: 0x7FFAC2F4F130
        public void set_Stream(){} // RVA: 0x7FFAC9FCE5A0
        public void Dispose(){} // RVA: 0x7FFAC9FCE790
        public void PeekEntry(){} // RVA: 0x7FFAC9FC43C0 | overloaded x2
        public void EnterNode(){} // RVA: 0x7FFAC9FCE930
        public void ExitNode(){} // RVA: 0x7FFAC9FCEFE0
        public void EnterArray(){} // RVA: 0x7FFAC9FCF1B0
        public void ExitArray(){} // RVA: 0x7FFAC9FCF4B0
        public void ReadPrimitiveArray(){} // RVA: 0x7FFAC2C59F60
        public void ReadBoolean(){} // RVA: 0x7FFAC9FCF630
        public void ReadInternalReference(){} // RVA: 0x7FFAC9FCF760
        public void ReadExternalReference(){} // RVA: 0x7FFAC9FCFC80 | overloaded x3
        public void ReadChar(){} // RVA: 0x7FFAC9FCFF20
        public void ReadString(){} // RVA: 0x7FFAC9FD0040
        public void ReadGuid(){} // RVA: 0x7FFAC9FD0200
        public void ReadSByte(){} // RVA: 0x7FFAC9FD04C0
        public void ReadInt16(){} // RVA: 0x7FFAC9FD0570
        public void ReadInt32(){} // RVA: 0x7FFAC9FD0630
        public void ReadInt64(){} // RVA: 0x7FFAC9FD06F0
        public void ReadByte(){} // RVA: 0x7FFAC9FD08E0
        public void ReadUInt16(){} // RVA: 0x7FFAC9FD0990
        public void ReadUInt32(){} // RVA: 0x7FFAC9FD0A50
        public void ReadUInt64(){} // RVA: 0x7FFAC9FD0B10
        public void ReadDecimal(){} // RVA: 0x7FFAC9FD0D00
        public void ReadSingle(){} // RVA: 0x7FFAC9FD0F80
        public void ReadDouble(){} // RVA: 0x7FFAC9FD11D0
        public void ReadNull(){} // RVA: 0x7FFAC9FD1420
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAC9FD1520
        public void GetDataDump(){} // RVA: 0x7FFAC9FD1680
        public void ReadToNextEntry(){} // RVA: 0x7FFAC9FD18E0
        public void MarkEntryConsumed(){} // RVA: 0x7FFAC9FD1910
        public void ReadAnyIntReference(){} // RVA: 0x7FFAC9FD1980
        public void <.ctor>b__7_0(){} // RVA: 0x7FFAC9FD1B80
        public void <.ctor>b__7_1(){} // RVA: 0x7FFAC9FD1BB0
        public void <.ctor>b__7_2(){} // RVA: 0x7FFAC9FD1BE0
        public void <.ctor>b__7_3(){} // RVA: 0x7FFAC9FD1C10
        public void <.ctor>b__7_4(){} // RVA: 0x7FFAC9FD1C40
        public void <.ctor>b__7_5(){} // RVA: 0x7FFAC9FD1C70
        public void <.ctor>b__7_6(){} // RVA: 0x7FFAC9FD1CA0
        public void <.ctor>b__7_7(){} // RVA: 0x7FFAC9FD1CD0
        public void <.ctor>b__7_8(){} // RVA: 0x7FFAC9FD1D00
        public void <.ctor>b__7_9(){} // RVA: 0x7FFAC9FD1D30
        public void <.ctor>b__7_10(){} // RVA: 0x7FFAC9FD1D70
        public void <.ctor>b__7_11(){} // RVA: 0x7FFAC9FD1DA0
        public void <.ctor>b__7_12(){} // RVA: 0x7FFAC9FD1DD0
        public void <.ctor>b__7_13(){} // RVA: 0x7FFAC9FD1E00
    }

    public class JsonDataWriter : BaseDataWriter
    {
        public uint[] ByteToHexCharLookup;
        public string NEW_LINE; // 0x8
        public bool justStarted; // 0x30
        public bool forceNoSeparatorNextLine; // 0x31
        public System.Collections.Generic.Dictionary`2<System.Type,System.Delegate> primitiveTypeWriters; // 0x38
        public System.Collections.Generic.Dictionary`2<System.Type,int> seenTypes; // 0x40
        public byte[] buffer; // 0x48
        public int bufferIndex; // 0x50
        public bool FormatAsReadable; // 0x54
        public bool EnableTypeOptimization; // 0x55

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9FD1E60 | overloaded x2
        public void MarkJustStarted(){} // RVA: 0x7FFAC4269BA0
        public void FlushToStream(){} // RVA: 0x7FFAC9FD2CE0
        public void BeginReferenceNode(){} // RVA: 0x7FFAC9FD2D80
        public void BeginStructNode(){} // RVA: 0x7FFAC9FD2E80
        public void EndNode(){} // RVA: 0x7FFAC9FD2F40
        public void BeginArrayNode(){} // RVA: 0x7FFAC9FD2FF0
        public void EndArrayNode(){} // RVA: 0x7FFAC9FD30A0
        public void WritePrimitiveArray(){} // RVA: 0x7FFAC2C70A40
        public void WriteBoolean(){} // RVA: 0x7FFAC9FD3100
        public void WriteByte(){} // RVA: 0x7FFAC9FD3190
        public void WriteChar(){} // RVA: 0x7FFAC9FD31B0
        public void WriteDecimal(){} // RVA: 0x7FFAC9FD32E0
        public void WriteDouble(){} // RVA: 0x7FFAC9FD33F0
        public void WriteInt32(){} // RVA: 0x7FFAC9FD3530
        public void WriteInt64(){} // RVA: 0x7FFAC9FD3550
        public void WriteNull(){} // RVA: 0x7FFAC9FD36E0
        public void WriteInternalReference(){} // RVA: 0x7FFAC9FD3730
        public void WriteSByte(){} // RVA: 0x7FFAC9FD38E0
        public void WriteInt16(){} // RVA: 0x7FFAC9FD3900
        public void WriteSingle(){} // RVA: 0x7FFAC9FD3920
        public void WriteString(){} // RVA: 0x7FFAC9FD3A60
        public void WriteGuid(){} // RVA: 0x7FFAC9FD3D00
        public void WriteUInt32(){} // RVA: 0x7FFAC9FD3DE0
        public void WriteUInt64(){} // RVA: 0x7FFAC9FD3E00
        public void WriteExternalReference(){} // RVA: 0x7FFAC9FD4250 | overloaded x3
        public void WriteUInt16(){} // RVA: 0x7FFAC9FD4410
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAC9FD4430
        public void GetDataDump(){} // RVA: 0x7FFAC9FD4490
        public void WriteEntry(){} // RVA: 0x7FFAC9FD4940 | overloaded x2
        public void WriteTypeEntry(){} // RVA: 0x7FFAC9FD4BC0
        public void StartNewLine(){} // RVA: 0x7FFAC9FD4E60
        public void EnsureBufferSpace(){} // RVA: 0x7FFAC9FD5080
        public void Buffer_WriteString_WithEscape(){} // RVA: 0x7FFAC9FD5120
        public void CreateByteToHexLookup(){} // RVA: 0x7FFAC9FD56E0
        public void .cctor(){} // RVA: 0x7FFAC9FD58D0
    }

    public class JsonTextReader : Object
    {
        public System.Collections.Generic.Dictionary`2<char,System.Nullable`1<0x6B223DD8>> Context;
        public System.Collections.Generic.Dictionary`2<char,char> UnescapeDictionary; // 0x8
        public System.IO.StreamReader reader; // 0x10
        public int bufferIndex; // 0x18
        public char[] buffer; // 0x20
        public System.Nullable`1<char> lastReadChar; // 0x28
        public System.Nullable`1<char> peekedChar; // 0x2C
        public System.Collections.Generic.Queue`1<char> emergencyPlayback; // 0x30
        public VRC.Udon.Serialization.OdinSerializer.DeserializationContext <Context>k__BackingField; // 0x38

        // ── Methods ──
        public void get_Context(){} // RVA: 0x7FFAC31D0140
        public void set_Context(){} // RVA: 0x7FFAC31D0C20
        public void .ctor(){} // RVA: 0x7FFAC9FD65E0
        public void Reset(){} // RVA: 0x7FFAC9FD6830
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void ReadToNextEntry(){} // RVA: 0x7FFAC9FD6880
        public void ParseEntryFromBuffer(){} // RVA: 0x7FFAC9FD7600
        public void IsHex(){} // RVA: 0x7FFAC9FD83A0
        public void ParseSingleChar(){} // RVA: 0x7FFAC9FD83D0
        public void ParseHexChar(){} // RVA: 0x7FFAC9FD8410
        public void ReadCharIntoBuffer(){} // RVA: 0x7FFAC9FD8690
        public void GuessPrimitiveType(){} // RVA: 0x7FFAC9FD87E0
        public void PeekChar(){} // RVA: 0x7FFAC9FD8B60
        public void SkipChar(){} // RVA: 0x7FFAC9FD8C50
        public void ConsumeChar(){} // RVA: 0x7FFAC9FD8D00
        public void .cctor(){} // RVA: 0x7FFAC9FD8DD0
    }

}