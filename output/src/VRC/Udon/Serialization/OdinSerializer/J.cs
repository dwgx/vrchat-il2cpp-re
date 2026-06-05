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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA2F3550 | overloaded x2
        public void get_Stream(){} // RVA: 0x7FFAF2DBB130
        public void set_Stream(){} // RVA: 0x7FFAFA2F43D0
        public void Dispose(){} // RVA: 0x7FFAFA2F45C0
        public void PeekEntry(){} // RVA: 0x7FFAFA2EA1F0 | overloaded x2
        public void EnterNode(){} // RVA: 0x7FFAFA2F4760
        public void ExitNode(){} // RVA: 0x7FFAFA2F4E10
        public void EnterArray(){} // RVA: 0x7FFAFA2F4FE0
        public void ExitArray(){} // RVA: 0x7FFAFA2F52E0
        public void ReadPrimitiveArray(){} // RVA: 0x7FFAF2ABDE40
        public void ReadBoolean(){} // RVA: 0x7FFAFA2F5460
        public void ReadInternalReference(){} // RVA: 0x7FFAFA2F5590
        public void ReadExternalReference(){} // RVA: 0x7FFAFA2F5AB0 | overloaded x3
        public void ReadChar(){} // RVA: 0x7FFAFA2F5D50
        public void ReadString(){} // RVA: 0x7FFAFA2F5E70
        public void ReadGuid(){} // RVA: 0x7FFAFA2F6030
        public void ReadSByte(){} // RVA: 0x7FFAFA2F62F0
        public void ReadInt16(){} // RVA: 0x7FFAFA2F63A0
        public void ReadInt32(){} // RVA: 0x7FFAFA2F6460
        public void ReadInt64(){} // RVA: 0x7FFAFA2F6520
        public void ReadByte(){} // RVA: 0x7FFAFA2F6710
        public void ReadUInt16(){} // RVA: 0x7FFAFA2F67C0
        public void ReadUInt32(){} // RVA: 0x7FFAFA2F6880
        public void ReadUInt64(){} // RVA: 0x7FFAFA2F6940
        public void ReadDecimal(){} // RVA: 0x7FFAFA2F6B30
        public void ReadSingle(){} // RVA: 0x7FFAFA2F6DB0
        public void ReadDouble(){} // RVA: 0x7FFAFA2F7000
        public void ReadNull(){} // RVA: 0x7FFAFA2F7250
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAFA2F7350
        public void GetDataDump(){} // RVA: 0x7FFAFA2F74B0
        public void ReadToNextEntry(){} // RVA: 0x7FFAFA2F7710
        public void MarkEntryConsumed(){} // RVA: 0x7FFAFA2F7740
        public void ReadAnyIntReference(){} // RVA: 0x7FFAFA2F77B0
        public void <.ctor>b__7_0(){} // RVA: 0x7FFAFA2F79B0
        public void <.ctor>b__7_1(){} // RVA: 0x7FFAFA2F79E0
        public void <.ctor>b__7_2(){} // RVA: 0x7FFAFA2F7A10
        public void <.ctor>b__7_3(){} // RVA: 0x7FFAFA2F7A40
        public void <.ctor>b__7_4(){} // RVA: 0x7FFAFA2F7A70
        public void <.ctor>b__7_5(){} // RVA: 0x7FFAFA2F7AA0
        public void <.ctor>b__7_6(){} // RVA: 0x7FFAFA2F7AD0
        public void <.ctor>b__7_7(){} // RVA: 0x7FFAFA2F7B00
        public void <.ctor>b__7_8(){} // RVA: 0x7FFAFA2F7B30
        public void <.ctor>b__7_9(){} // RVA: 0x7FFAFA2F7B60
        public void <.ctor>b__7_10(){} // RVA: 0x7FFAFA2F7BA0
        public void <.ctor>b__7_11(){} // RVA: 0x7FFAFA2F7BD0
        public void <.ctor>b__7_12(){} // RVA: 0x7FFAFA2F7C00
        public void <.ctor>b__7_13(){} // RVA: 0x7FFAFA2F7C30
    }

    public class JsonDataWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA2F7C90 | overloaded x2
        public void MarkJustStarted(){} // RVA: 0x7FFAF4265330
        public void FlushToStream(){} // RVA: 0x7FFAFA2F8B10
        public void BeginReferenceNode(){} // RVA: 0x7FFAFA2F8BB0
        public void BeginStructNode(){} // RVA: 0x7FFAFA2F8CB0
        public void EndNode(){} // RVA: 0x7FFAFA2F8D70
        public void BeginArrayNode(){} // RVA: 0x7FFAFA2F8E20
        public void EndArrayNode(){} // RVA: 0x7FFAFA2F8ED0
        public void WritePrimitiveArray(){} // RVA: 0x7FFAF2AD4B10
        public void WriteBoolean(){} // RVA: 0x7FFAFA2F8F30
        public void WriteByte(){} // RVA: 0x7FFAFA2F8FC0
        public void WriteChar(){} // RVA: 0x7FFAFA2F8FE0
        public void WriteDecimal(){} // RVA: 0x7FFAFA2F9110
        public void WriteDouble(){} // RVA: 0x7FFAFA2F9220
        public void WriteInt32(){} // RVA: 0x7FFAFA2F9360
        public void WriteInt64(){} // RVA: 0x7FFAFA2F9380
        public void WriteNull(){} // RVA: 0x7FFAFA2F9510
        public void WriteInternalReference(){} // RVA: 0x7FFAFA2F9560
        public void WriteSByte(){} // RVA: 0x7FFAFA2F9710
        public void WriteInt16(){} // RVA: 0x7FFAFA2F9730
        public void WriteSingle(){} // RVA: 0x7FFAFA2F9750
        public void WriteString(){} // RVA: 0x7FFAFA2F9890
        public void WriteGuid(){} // RVA: 0x7FFAFA2F9B30
        public void WriteUInt32(){} // RVA: 0x7FFAFA2F9C10
        public void WriteUInt64(){} // RVA: 0x7FFAFA2F9C30
        public void WriteExternalReference(){} // RVA: 0x7FFAFA2FA080 | overloaded x3
        public void WriteUInt16(){} // RVA: 0x7FFAFA2FA240
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAFA2FA260
        public void GetDataDump(){} // RVA: 0x7FFAFA2FA2C0
        public void WriteEntry(){} // RVA: 0x7FFAFA2FA770 | overloaded x2
        public void WriteTypeEntry(){} // RVA: 0x7FFAFA2FA9F0
        public void StartNewLine(){} // RVA: 0x7FFAFA2FAC90
        public void EnsureBufferSpace(){} // RVA: 0x7FFAFA2FAEB0
        public void Buffer_WriteString_WithEscape(){} // RVA: 0x7FFAFA2FAF50
        public void CreateByteToHexLookup(){} // RVA: 0x7FFAFA2FB510
        public void .cctor(){} // RVA: 0x7FFAFA2FB700
    }

    public class JsonTextReader
    {
        // ── Methods ──
        public void get_Context(){} // RVA: 0x7FFAF2F476A0
        public void set_Context(){} // RVA: 0x7FFAF2F4B830
        public void .ctor(){} // RVA: 0x7FFAFA2FC410
        public void Reset(){} // RVA: 0x7FFAFA2FC660
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
        public void ReadToNextEntry(){} // RVA: 0x7FFAFA2FC6B0
        public void ParseEntryFromBuffer(){} // RVA: 0x7FFAFA2FD430
        public void IsHex(){} // RVA: 0x7FFAFA2FE1D0
        public void ParseSingleChar(){} // RVA: 0x7FFAFA2FE200
        public void ParseHexChar(){} // RVA: 0x7FFAFA2FE240
        public void ReadCharIntoBuffer(){} // RVA: 0x7FFAFA2FE4C0
        public void GuessPrimitiveType(){} // RVA: 0x7FFAFA2FE610
        public void PeekChar(){} // RVA: 0x7FFAFA2FE990
        public void SkipChar(){} // RVA: 0x7FFAFA2FEA80
        public void ConsumeChar(){} // RVA: 0x7FFAFA2FEB30
        public void .cctor(){} // RVA: 0x7FFAFA2FEC00
    }

}