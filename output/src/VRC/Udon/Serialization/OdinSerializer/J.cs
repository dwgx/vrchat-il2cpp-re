// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 3
// Methods: 100

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class JsonDataReader : BaseDataReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF622AB0
        public void get_Stream(){} // RVA: 0x7A8105330
        public void set_Stream(){} // RVA: 0x7AF623930
        public void Dispose(){} // RVA: 0x7AF623B20
        public void PeekEntry(){} // RVA: 0x7AF619700
        public void EnterNode(){} // RVA: 0x7AF623CC0
        public void ExitNode(){} // RVA: 0x7AF624380
        public void EnterArray(){} // RVA: 0x7AF624560
        public void ExitArray(){} // RVA: 0x7AF624860
        public void ReadPrimitiveArray(){} // RVA: 0x7A7E019D0
        public void ReadBoolean(){} // RVA: 0x7AF6249F0
        public void ReadInternalReference(){} // RVA: 0x7AF624B20
        public void ReadExternalReference(){} // RVA: 0x7AF625040
        public void ReadChar(){} // RVA: 0x7AF6252E0
        public void ReadString(){} // RVA: 0x7AF625400
        public void ReadGuid(){} // RVA: 0x7AF6255C0
        public void ReadSByte(){} // RVA: 0x7AF625880
        public void ReadInt16(){} // RVA: 0x7AF625930
        public void ReadInt32(){} // RVA: 0x7AF6259F0
        public void ReadInt64(){} // RVA: 0x7AF625AB0
        public void ReadByte(){} // RVA: 0x7AF625CA0
        public void ReadUInt16(){} // RVA: 0x7AF625D50
        public void ReadUInt32(){} // RVA: 0x7AF625E10
        public void ReadUInt64(){} // RVA: 0x7AF625ED0
        public void ReadDecimal(){} // RVA: 0x7AF6260C0
        public void ReadSingle(){} // RVA: 0x7AF626340
        public void ReadDouble(){} // RVA: 0x7AF626590
        public void ReadNull(){} // RVA: 0x7AF6267E0
        public void PrepareNewSerializationSession(){} // RVA: 0x7AF6268E0
        public void GetDataDump(){} // RVA: 0x7AF626A40
        public void ReadToNextEntry(){} // RVA: 0x7AF626CA0
        public void MarkEntryConsumed(){} // RVA: 0x7AF626CD0
        public void ReadAnyIntReference(){} // RVA: 0x7AF626D40
        public void <.ctor>b__7_0(){} // RVA: 0x7AF626F40
        public void <.ctor>b__7_1(){} // RVA: 0x7AF626F70
        public void <.ctor>b__7_2(){} // RVA: 0x7AF626FA0
        public void <.ctor>b__7_3(){} // RVA: 0x7AF626FD0
        public void <.ctor>b__7_4(){} // RVA: 0x7AF627000
        public void <.ctor>b__7_5(){} // RVA: 0x7AF627030
        public void <.ctor>b__7_6(){} // RVA: 0x7AF627060
        public void <.ctor>b__7_7(){} // RVA: 0x7AF627090
        public void <.ctor>b__7_8(){} // RVA: 0x7AF6270C0
        public void <.ctor>b__7_9(){} // RVA: 0x7AF6270F0
        public void <.ctor>b__7_10(){} // RVA: 0x7AF627130
        public void <.ctor>b__7_11(){} // RVA: 0x7AF627160
        public void <.ctor>b__7_12(){} // RVA: 0x7AF627190
        public void <.ctor>b__7_13(){} // RVA: 0x7AF6271C0
    }

    public class JsonDataWriter : BaseDataWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF627220
        public void MarkJustStarted(){} // RVA: 0x7A9570550
        public void FlushToStream(){} // RVA: 0x7AF6280A0
        public void BeginReferenceNode(){} // RVA: 0x7AF628140
        public void BeginStructNode(){} // RVA: 0x7AF628240
        public void EndNode(){} // RVA: 0x7AF628300
        public void BeginArrayNode(){} // RVA: 0x7AF6283B0
        public void EndArrayNode(){} // RVA: 0x7AF628460
        public void WritePrimitiveArray(){} // RVA: 0x7A7E18800
        public void WriteBoolean(){} // RVA: 0x7AF6284C0
        public void WriteByte(){} // RVA: 0x7AF628550
        public void WriteChar(){} // RVA: 0x7AF628570
        public void WriteDecimal(){} // RVA: 0x7AF628690
        public void WriteDouble(){} // RVA: 0x7AF6287A0
        public void WriteInt32(){} // RVA: 0x7AF6288E0
        public void WriteInt64(){} // RVA: 0x7AF628900
        public void WriteNull(){} // RVA: 0x7AF628A90
        public void WriteInternalReference(){} // RVA: 0x7AF628AE0
        public void WriteSByte(){} // RVA: 0x7AF628C90
        public void WriteInt16(){} // RVA: 0x7AF628CB0
        public void WriteSingle(){} // RVA: 0x7AF628CD0
        public void WriteString(){} // RVA: 0x7AF628E10
        public void WriteGuid(){} // RVA: 0x7AF6290C0
        public void WriteUInt32(){} // RVA: 0x7AF6291A0
        public void WriteUInt64(){} // RVA: 0x7AF6291C0
        public void WriteExternalReference(){} // RVA: 0x7AF629610
        public void WriteUInt16(){} // RVA: 0x7AF6297D0
        public void Dispose(){} // RVA: 0x7A80D7310
        public void PrepareNewSerializationSession(){} // RVA: 0x7AF6297F0
        public void GetDataDump(){} // RVA: 0x7AF629850
        public void WriteEntry(){} // RVA: 0x7AF629D10
        public void WriteTypeEntry(){} // RVA: 0x7AF629FA0
        public void StartNewLine(){} // RVA: 0x7AF62A240
        public void EnsureBufferSpace(){} // RVA: 0x7AF62A460
        public void Buffer_WriteString_WithEscape(){} // RVA: 0x7AF62A500
        public void CreateByteToHexLookup(){} // RVA: 0x7AF62AAD0
        public void .cctor(){} // RVA: 0x7AF62ACC0
    }

    public class JsonTextReader : Object
    {
        // ── Methods ──
        public void get_Context(){} // RVA: 0x7A8292C30
        public void set_Context(){} // RVA: 0x7A8296DE0
        public void .ctor(){} // RVA: 0x7AF62B9E0
        public void Reset(){} // RVA: 0x7AF62BC40
        public void Dispose(){} // RVA: 0x7A80D7310
        public void ReadToNextEntry(){} // RVA: 0x7AF62BC90
        public void ParseEntryFromBuffer(){} // RVA: 0x7AF62C9D0
        public void IsHex(){} // RVA: 0x7AF62D770
        public void ParseSingleChar(){} // RVA: 0x7AF62D7A0
        public void ParseHexChar(){} // RVA: 0x7AF62D7E0
        public void ReadCharIntoBuffer(){} // RVA: 0x7AF62DB00
        public void GuessPrimitiveType(){} // RVA: 0x7AF62DC50
        public void PeekChar(){} // RVA: 0x7AF62DFD0
        public void SkipChar(){} // RVA: 0x7AF62E0C0
        public void ConsumeChar(){} // RVA: 0x7AF62E170
        public void .cctor(){} // RVA: 0x7AF62E240
    }

}