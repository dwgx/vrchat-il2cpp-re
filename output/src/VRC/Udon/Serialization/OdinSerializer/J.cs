// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 4
// Methods: 108

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class JsonConfig
    {
    }

    public class JsonDataReader
    {
        public VRC.Udon.Serialization.OdinSerializer.JsonTextReader reader; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7843550 | overloaded x2
        public void get_Stream(){} // RVA: 0x30B130
        public void set_Stream(){} // RVA: 0x78443D0
        public void Dispose(){} // RVA: 0x78445C0
        public void PeekEntry(){} // RVA: 0x783A1F0 | overloaded x2
        public void EnterNode(){} // RVA: 0x7844760
        public void ExitNode(){} // RVA: 0x7844E10
        public void EnterArray(){} // RVA: 0x7844FE0
        public void ExitArray(){} // RVA: 0x78452E0
        public void ReadPrimitiveArray(){} // RVA: 0xDE40
        public void ReadBoolean(){} // RVA: 0x7845460
        public void ReadInternalReference(){} // RVA: 0x7845590
        public void ReadExternalReference(){} // RVA: 0x7845AB0 | overloaded x3
        public void ReadChar(){} // RVA: 0x7845D50
        public void ReadString(){} // RVA: 0x7845E70
        public void ReadGuid(){} // RVA: 0x7846030
        public void ReadSByte(){} // RVA: 0x78462F0
        public void ReadInt16(){} // RVA: 0x78463A0
        public void ReadInt32(){} // RVA: 0x7846460
        public void ReadInt64(){} // RVA: 0x7846520
        public void ReadByte(){} // RVA: 0x7846710
        public void ReadUInt16(){} // RVA: 0x78467C0
        public void ReadUInt32(){} // RVA: 0x7846880
        public void ReadUInt64(){} // RVA: 0x7846940
        public void ReadDecimal(){} // RVA: 0x7846B30
        public void ReadSingle(){} // RVA: 0x7846DB0
        public void ReadDouble(){} // RVA: 0x7847000
        public void ReadNull(){} // RVA: 0x7847250
        public void PrepareNewSerializationSession(){} // RVA: 0x7847350
        public void GetDataDump(){} // RVA: 0x78474B0
        public void ReadToNextEntry(){} // RVA: 0x7847710
        public void MarkEntryConsumed(){} // RVA: 0x7847740
        public void ReadAnyIntReference(){} // RVA: 0x78477B0
        public void <.ctor>b__7_0(){} // RVA: 0x78479B0
        public void <.ctor>b__7_1(){} // RVA: 0x78479E0
        public void <.ctor>b__7_2(){} // RVA: 0x7847A10
        public void <.ctor>b__7_3(){} // RVA: 0x7847A40
        public void <.ctor>b__7_4(){} // RVA: 0x7847A70
        public void <.ctor>b__7_5(){} // RVA: 0x7847AA0
        public void <.ctor>b__7_6(){} // RVA: 0x7847AD0
        public void <.ctor>b__7_7(){} // RVA: 0x7847B00
        public void <.ctor>b__7_8(){} // RVA: 0x7847B30
        public void <.ctor>b__7_9(){} // RVA: 0x7847B60
        public void <.ctor>b__7_10(){} // RVA: 0x7847BA0
        public void <.ctor>b__7_11(){} // RVA: 0x7847BD0
        public void <.ctor>b__7_12(){} // RVA: 0x7847C00
        public void <.ctor>b__7_13(){} // RVA: 0x7847C30
    }

    public class JsonDataWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7847C90 | overloaded x2
        public void MarkJustStarted(){} // RVA: 0x17B5330
        public void FlushToStream(){} // RVA: 0x7848B10
        public void BeginReferenceNode(){} // RVA: 0x7848BB0
        public void BeginStructNode(){} // RVA: 0x7848CB0
        public void EndNode(){} // RVA: 0x7848D70
        public void BeginArrayNode(){} // RVA: 0x7848E20
        public void EndArrayNode(){} // RVA: 0x7848ED0
        public void WritePrimitiveArray(){} // RVA: 0x24B10
        public void WriteBoolean(){} // RVA: 0x7848F30
        public void WriteByte(){} // RVA: 0x7848FC0
        public void WriteChar(){} // RVA: 0x7848FE0
        public void WriteDecimal(){} // RVA: 0x7849110
        public void WriteDouble(){} // RVA: 0x7849220
        public void WriteInt32(){} // RVA: 0x7849360
        public void WriteInt64(){} // RVA: 0x7849380
        public void WriteNull(){} // RVA: 0x7849510
        public void WriteInternalReference(){} // RVA: 0x7849560
        public void WriteSByte(){} // RVA: 0x7849710
        public void WriteInt16(){} // RVA: 0x7849730
        public void WriteSingle(){} // RVA: 0x7849750
        public void WriteString(){} // RVA: 0x7849890
        public void WriteGuid(){} // RVA: 0x7849B30
        public void WriteUInt32(){} // RVA: 0x7849C10
        public void WriteUInt64(){} // RVA: 0x7849C30
        public void WriteExternalReference(){} // RVA: 0x784A080 | overloaded x3
        public void WriteUInt16(){} // RVA: 0x784A240
        public void Dispose(){} // RVA: 0x2DD310
        public void PrepareNewSerializationSession(){} // RVA: 0x784A260
        public void GetDataDump(){} // RVA: 0x784A2C0
        public void WriteEntry(){} // RVA: 0x784A770 | overloaded x2
        public void WriteTypeEntry(){} // RVA: 0x784A9F0
        public void StartNewLine(){} // RVA: 0x784AC90
        public void EnsureBufferSpace(){} // RVA: 0x784AEB0
        public void Buffer_WriteString_WithEscape(){} // RVA: 0x784AF50
        public void CreateByteToHexLookup(){} // RVA: 0x784B510
        public void .cctor(){} // RVA: 0x784B700
    }

    public class JsonTextReader
    {
        public System.Collections.Generic.Dictionary`2<char,System.Nullable`1<0x6593FF90>> EntryDelineators;

        // ── Methods ──
        public void get_Context(){} // RVA: 0x4976A0
        public void set_Context(){} // RVA: 0x49B830
        public void .ctor(){} // RVA: 0x784C410
        public void Reset(){} // RVA: 0x784C660
        public void Dispose(){} // RVA: 0x2DD310
        public void ReadToNextEntry(){} // RVA: 0x784C6B0
        public void ParseEntryFromBuffer(){} // RVA: 0x784D430
        public void IsHex(){} // RVA: 0x784E1D0
        public void ParseSingleChar(){} // RVA: 0x784E200
        public void ParseHexChar(){} // RVA: 0x784E240
        public void ReadCharIntoBuffer(){} // RVA: 0x784E4C0
        public void GuessPrimitiveType(){} // RVA: 0x784E610
        public void PeekChar(){} // RVA: 0x784E990
        public void SkipChar(){} // RVA: 0x784EA80
        public void ConsumeChar(){} // RVA: 0x784EB30
        public void .cctor(){} // RVA: 0x784EC00
    }

}