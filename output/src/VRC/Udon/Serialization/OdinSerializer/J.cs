// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 3
// Methods: 100

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class JsonDataReader : BaseDataReader
    {
        public object reader;
        public object peekedEntryType;
        public object peekedEntryName;
        public object peekedEntryContent;
        public object seenTypes;
        public object primitiveArrayReaders;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8481240
        public void get_Stream(){} // RVA: 0xB70160
        public void set_Stream(){} // RVA: 0x8481E30
        public void Dispose(){} // RVA: 0x8482020
        public void PeekEntry(){} // RVA: 0x8478530
        public void EnterNode(){} // RVA: 0x84821C0
        public void ExitNode(){} // RVA: 0x8482880
        public void EnterArray(){} // RVA: 0x8482A60
        public void ExitArray(){} // RVA: 0x8482D60
        public void ReadPrimitiveArray(){} // RVA: 0x87D350
        public void ReadBoolean(){} // RVA: 0x8482EF0
        public void ReadInternalReference(){} // RVA: 0x8483020
        public void ReadExternalReference(){} // RVA: 0x8483540
        public void ReadChar(){} // RVA: 0x84837E0
        public void ReadString(){} // RVA: 0x8483900
        public void ReadGuid(){} // RVA: 0x8483AC0
        public void ReadSByte(){} // RVA: 0x8483D80
        public void ReadInt16(){} // RVA: 0x8483E30
        public void ReadInt32(){} // RVA: 0x8483EF0
        public void ReadInt64(){} // RVA: 0x8483FB0
        public void ReadByte(){} // RVA: 0x84841A0
        public void ReadUInt16(){} // RVA: 0x8484250
        public void ReadUInt32(){} // RVA: 0x8484310
        public void ReadUInt64(){} // RVA: 0x84843D0
        public void ReadDecimal(){} // RVA: 0x84845C0
        public void ReadSingle(){} // RVA: 0x8484840
        public void ReadDouble(){} // RVA: 0x8484A90
        public void ReadNull(){} // RVA: 0x8484CE0
        public void PrepareNewSerializationSession(){} // RVA: 0x8484DE0
        public void GetDataDump(){} // RVA: 0x8484F40
        public void ReadToNextEntry(){} // RVA: 0x84851A0
        public void MarkEntryConsumed(){} // RVA: 0x84851D0
        public void ReadAnyIntReference(){} // RVA: 0x8485240
        public void <.ctor>b__7_0(){} // RVA: 0x8485440
        public void <.ctor>b__7_1(){} // RVA: 0x8485470
        public void <.ctor>b__7_2(){} // RVA: 0x84854A0
        public void <.ctor>b__7_3(){} // RVA: 0x84854D0
        public void <.ctor>b__7_4(){} // RVA: 0x8485500
        public void <.ctor>b__7_5(){} // RVA: 0x8485530
        public void <.ctor>b__7_6(){} // RVA: 0x8485560
        public void <.ctor>b__7_7(){} // RVA: 0x8485590
        public void <.ctor>b__7_8(){} // RVA: 0x84855C0
        public void <.ctor>b__7_9(){} // RVA: 0x84855F0
        public void <.ctor>b__7_10(){} // RVA: 0x8485630
        public void <.ctor>b__7_11(){} // RVA: 0x8485660
        public void <.ctor>b__7_12(){} // RVA: 0x8485690
        public void <.ctor>b__7_13(){} // RVA: 0x84856C0
    }

    public class JsonDataWriter : BaseDataWriter
    {
        public object ByteToHexCharLookup;
        public object NEW_LINE;
        public object justStarted;
        public object forceNoSeparatorNextLine;
        public object primitiveTypeWriters;
        public object seenTypes;
        public object buffer;
        public object bufferIndex;
        public object FormatAsReadable;
        public object EnableTypeOptimization;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8485720
        public void MarkJustStarted(){} // RVA: 0x21B8CE0
        public void FlushToStream(){} // RVA: 0x8486310
        public void BeginReferenceNode(){} // RVA: 0x84863B0
        public void BeginStructNode(){} // RVA: 0x84864A0
        public void EndNode(){} // RVA: 0x8486550
        public void BeginArrayNode(){} // RVA: 0x8486600
        public void EndArrayNode(){} // RVA: 0x84866B0
        public void WritePrimitiveArray(){} // RVA: 0x894320
        public void WriteBoolean(){} // RVA: 0x8486710
        public void WriteByte(){} // RVA: 0x84867A0
        public void WriteChar(){} // RVA: 0x84867C0
        public void WriteDecimal(){} // RVA: 0x84868B0
        public void WriteDouble(){} // RVA: 0x84869C0
        public void WriteInt32(){} // RVA: 0x8486B00
        public void WriteInt64(){} // RVA: 0x8486B20
        public void WriteNull(){} // RVA: 0x8486CB0
        public void WriteInternalReference(){} // RVA: 0x8486D00
        public void WriteSByte(){} // RVA: 0x8486EB0
        public void WriteInt16(){} // RVA: 0x8486ED0
        public void WriteSingle(){} // RVA: 0x8486EF0
        public void WriteString(){} // RVA: 0x8487030
        public void WriteGuid(){} // RVA: 0x84872E0
        public void WriteUInt32(){} // RVA: 0x84873C0
        public void WriteUInt64(){} // RVA: 0x84873E0
        public void WriteExternalReference(){} // RVA: 0x8487830
        public void WriteUInt16(){} // RVA: 0x84879F0
        public void Dispose(){} // RVA: 0xB43310
        public void PrepareNewSerializationSession(){} // RVA: 0x8487A10
        public void GetDataDump(){} // RVA: 0x8487A70
        public void WriteEntry(){} // RVA: 0x8487F30
        public void WriteTypeEntry(){} // RVA: 0x84881C0
        public void StartNewLine(){} // RVA: 0x8488460
        public void EnsureBufferSpace(){} // RVA: 0x8488680
        public void Buffer_WriteString_WithEscape(){} // RVA: 0x8488720
        public void CreateByteToHexLookup(){} // RVA: 0x8488CF0
        public void .cctor(){} // RVA: 0x8488EE0
    }

    public class JsonTextReader : Object
    {
        public object EntryDelineators;
        public object UnescapeDictionary;
        public object reader;
        public object bufferIndex;
        public object buffer;
        public object lastReadChar;
        public object peekedChar;
        public object emergencyPlayback;
        public object _context;

        // ── Methods ──
        public void get_Context(){} // RVA: 0xD05CA0
        public void set_Context(){} // RVA: 0xD09D70
        public void .ctor(){} // RVA: 0x8489BC0
        public void Reset(){} // RVA: 0x8489E20
        public void Dispose(){} // RVA: 0xB43310
        public void ReadToNextEntry(){} // RVA: 0x8489E70
        public void ParseEntryFromBuffer(){} // RVA: 0x848AB20
        public void IsHex(){} // RVA: 0x848B8C0
        public void ParseSingleChar(){} // RVA: 0x848B8F0
        public void ParseHexChar(){} // RVA: 0x848B930
        public void ReadCharIntoBuffer(){} // RVA: 0x848BBC0
        public void GuessPrimitiveType(){} // RVA: 0x848BD10
        public void PeekChar(){} // RVA: 0x848C090
        public void SkipChar(){} // RVA: 0x848C180
        public void ConsumeChar(){} // RVA: 0x848C230
        public void .cctor(){} // RVA: 0x848C300
    }

}