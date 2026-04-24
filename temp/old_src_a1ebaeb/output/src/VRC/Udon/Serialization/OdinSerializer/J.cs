// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 4
// Methods: 108

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class JsonConfig : Object
    {
        public object REGULAR_ARRAY_LENGTH_SIG; // 0x33877280
        public object PRIMITIVE_ARRAY_CONTENT_SIG; // 0x33877280
        public object EXTERNAL_GUID_REF_SIG; // 0x33877280
        public object peekedEntryName; // 0x317E2860
    }

    public class JsonDataReader : BaseDataReader
    {
        public object peekedEntryName; // 0x317E2860
        public object primitiveArrayReaders; // 0x317E2860
        public object Stream; // 0x17000021

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf9f0140
        public void .ctor(){} // RVA: 0x7ffaaf9f0140
        public void get_Stream(){} // RVA: 0x7ffaa8960130
        public void set_Stream(){} // RVA: 0x7ffaaf9f0fc0
        public void Dispose(){} // RVA: 0x7ffaaf9f11b0
        public void PeekEntry(){} // RVA: 0x7ffaaf9e6de0
        public void EnterNode(){} // RVA: 0x7ffaaf9f1350
        public void ExitNode(){} // RVA: 0x7ffaaf9f1a00
        public void EnterArray(){} // RVA: 0x7ffaaf9f1bd0
        public void ExitArray(){} // RVA: 0x7ffaaf9f1ed0
        public void ReadPrimitiveArray(){} // RVA: 0x7ffaa864a2a0
        public void ReadBoolean(){} // RVA: 0x7ffaaf9f2050
        public void ReadInternalReference(){} // RVA: 0x7ffaaf9f2180
        public void ReadExternalReference(){} // RVA: 0x7ffaaf9f26a0
        public void ReadExternalReference(){} // RVA: 0x7ffaaf9f26a0
        public void ReadExternalReference(){} // RVA: 0x7ffaaf9f26a0
        public void ReadChar(){} // RVA: 0x7ffaaf9f2940
        public void ReadString(){} // RVA: 0x7ffaaf9f2a60
        public void ReadGuid(){} // RVA: 0x7ffaaf9f2c20
        public void ReadSByte(){} // RVA: 0x7ffaaf9f2ee0
        public void ReadInt16(){} // RVA: 0x7ffaaf9f2f90
        public void ReadInt32(){} // RVA: 0x7ffaaf9f3050
        public void ReadInt64(){} // RVA: 0x7ffaaf9f3110
        public void ReadByte(){} // RVA: 0x7ffaaf9f3300
        public void ReadUInt16(){} // RVA: 0x7ffaaf9f33b0
        public void ReadUInt32(){} // RVA: 0x7ffaaf9f3470
        public void ReadUInt64(){} // RVA: 0x7ffaaf9f3530
        public void ReadDecimal(){} // RVA: 0x7ffaaf9f3720
        public void ReadSingle(){} // RVA: 0x7ffaaf9f39a0
        public void ReadDouble(){} // RVA: 0x7ffaaf9f3bf0
        public void ReadNull(){} // RVA: 0x7ffaaf9f3e40
        public void PrepareNewSerializationSession(){} // RVA: 0x7ffaaf9f3f40
        public void PeekEntry(){} // RVA: 0x7ffaaf9e6de0
        public void ReadToNextEntry(){} // RVA: 0x7ffaaf9f4300
        public void MarkEntryConsumed(){} // RVA: 0x7ffaaf9f4330
        public void ReadAnyIntReference(){} // RVA: 0x7ffaaf9f43a0
        public void <.ctor>b__7_0(){} // RVA: 0x7ffaaf9f45a0
        public void <.ctor>b__7_1(){} // RVA: 0x7ffaaf9f45d0
        public void <.ctor>b__7_2(){} // RVA: 0x7ffaaf9f4600
        public void <.ctor>b__7_3(){} // RVA: 0x7ffaaf9f4630
        public void <.ctor>b__7_4(){} // RVA: 0x7ffaaf9f4660
        public void <.ctor>b__7_5(){} // RVA: 0x7ffaaf9f4690
        public void <.ctor>b__7_6(){} // RVA: 0x7ffaaf9f46c0
        public void <.ctor>b__7_7(){} // RVA: 0x7ffaaf9f46f0
        public void <.ctor>b__7_8(){} // RVA: 0x7ffaaf9f4720
        public void <.ctor>b__7_9(){} // RVA: 0x7ffaaf9f4750
        public void <.ctor>b__7_10(){} // RVA: 0x7ffaaf9f4790
        public void <.ctor>b__7_11(){} // RVA: 0x7ffaaf9f47c0
        public void <.ctor>b__7_12(){} // RVA: 0x7ffaaf9f47f0
        public void <.ctor>b__7_13(){} // RVA: 0x7ffaaf9f4820
        // ── Binary Analysis Named ──
        public void GetDataDump(){} // RVA: 0x7ffaaf9f40a0
    }

    public class JsonDataWriter : BaseDataWriter
    {
        public object justStarted; // 0x317E2EB0
        public object seenTypes; // 0x317E2EB0
        public object FormatAsReadable; // 0x317E2EB0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf9f4880
        public void .ctor(){} // RVA: 0x7ffaaf9f4880
        public void MarkJustStarted(){} // RVA: 0x7ffaa9c8b610
        public void FlushToStream(){} // RVA: 0x7ffaaf9f5700
        public void EndNode(){} // RVA: 0x7ffaaf9f5960
        public void EndArrayNode(){} // RVA: 0x7ffaaf9f5ac0
        public void WritePrimitiveArray(){} // RVA: 0x7ffaa8660d80
        public void WriteBoolean(){} // RVA: 0x7ffaaf9f5b20
        public void WriteByte(){} // RVA: 0x7ffaaf9f5bb0
        public void WriteChar(){} // RVA: 0x7ffaaf9f5bd0
        public void WriteDecimal(){} // RVA: 0x7ffaaf9f5d00
        public void WriteDouble(){} // RVA: 0x7ffaaf9f5e10
        public void WriteInt32(){} // RVA: 0x7ffaaf9f5f50
        public void WriteInt64(){} // RVA: 0x7ffaaf9f5f70
        public void WriteNull(){} // RVA: 0x7ffaaf9f6100
        public void WriteInternalReference(){} // RVA: 0x7ffaaf9f6150
        public void WriteSByte(){} // RVA: 0x7ffaaf9f6300
        public void WriteInt16(){} // RVA: 0x7ffaaf9f6320
        public void WriteSingle(){} // RVA: 0x7ffaaf9f6340
        public void WriteString(){} // RVA: 0x7ffaaf9f6480
        public void WriteGuid(){} // RVA: 0x7ffaaf9f6720
        public void WriteUInt32(){} // RVA: 0x7ffaaf9f6800
        public void WriteUInt64(){} // RVA: 0x7ffaaf9f6820
        public void WriteExternalReference(){} // RVA: 0x7ffaaf9f6c70
        public void WriteExternalReference(){} // RVA: 0x7ffaaf9f6c70
        public void WriteExternalReference(){} // RVA: 0x7ffaaf9f6c70
        public void WriteUInt16(){} // RVA: 0x7ffaaf9f6e30
        public void Dispose(){} // RVA: 0x7ffaa8932310
        public void PrepareNewSerializationSession(){} // RVA: 0x7ffaaf9f6e50
        public void WriteEntry(){} // RVA: 0x7ffaaf9f7360
        public void WriteEntry(){} // RVA: 0x7ffaaf9f7360
        public void WriteTypeEntry(){} // RVA: 0x7ffaaf9f75e0
        public void StartNewLine(){} // RVA: 0x7ffaaf9f7880
        public void EnsureBufferSpace(){} // RVA: 0x7ffaaf9f7aa0
        public void Buffer_WriteString_WithEscape(){} // RVA: 0x7ffaaf9f7b40
        public void CreateByteToHexLookup(){} // RVA: 0x7ffaaf9f8100
        public void .cctor(){} // RVA: 0x7ffaaf9f82f0
        // ── Binary Analysis Named ──
        public void BeginReferenceNode(){} // RVA: 0x7ffaaf9f57a0
        public void BeginStructNode(){} // RVA: 0x7ffaaf9f58a0
        public void BeginArrayNode(){} // RVA: 0x7ffaaf9f5a10
        public void GetDataDump(){} // RVA: 0x7ffaaf9f6eb0
    }

    public class JsonTextReader : Object
    {
        public object reader; // 0x33A163D0
        public object lastReadChar; // 0x33A163D0
        public object _context; // 0x33A163D0, was: <Context>k__BackingField

        // ── Original Methods ──
        public void get_Context(){} // RVA: 0x7ffaa8bf45b0
        public void set_Context(){} // RVA: 0x7ffaa8bf45c0
        public void .ctor(){} // RVA: 0x7ffaaf9f9000
        public void Reset(){} // RVA: 0x7ffaaf9f9250
        public void Dispose(){} // RVA: 0x7ffaa8932310
        public void ReadToNextEntry(){} // RVA: 0x7ffaaf9f92a0
        public void ParseEntryFromBuffer(){} // RVA: 0x7ffaaf9fa020
        public void IsHex(){} // RVA: 0x7ffaaf9fadc0
        public void ParseSingleChar(){} // RVA: 0x7ffaaf9fadf0
        public void ParseHexChar(){} // RVA: 0x7ffaaf9fae30
        public void ReadCharIntoBuffer(){} // RVA: 0x7ffaaf9fb0b0
        public void GuessPrimitiveType(){} // RVA: 0x7ffaaf9fb200
        public void PeekChar(){} // RVA: 0x7ffaaf9fb580
        public void SkipChar(){} // RVA: 0x7ffaaf9fb670
        public void ConsumeChar(){} // RVA: 0x7ffaaf9fb720
        public void .cctor(){} // RVA: 0x7ffaaf9fb7f0
    }

}