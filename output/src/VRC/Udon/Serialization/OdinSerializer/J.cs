// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 4
// Methods: 108

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class JsonConfig : Object
    {
    }

    public class JsonDataReader : BaseDataReader
    {
        public VRC.Udon.Serialization.OdinSerializer.JsonTextReader reader; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88380210 | overloaded x2
        public void get_Stream(){} // RVA: 0x7FFE81129130
        public void set_Stream(){} // RVA: 0x7FFE88381090
        public void Dispose(){} // RVA: 0x7FFE88381280
        public void PeekEntry(){} // RVA: 0x7FFE88376EB0 | overloaded x2
        public void EnterNode(){} // RVA: 0x7FFE88381420
        public void ExitNode(){} // RVA: 0x7FFE88381AD0
        public void EnterArray(){} // RVA: 0x7FFE88381CA0
        public void ExitArray(){} // RVA: 0x7FFE88381FA0
        public void ReadPrimitiveArray(){} // RVA: 0x7FFE80E2F3B0
        public void ReadBoolean(){} // RVA: 0x7FFE88382120
        public void ReadInternalReference(){} // RVA: 0x7FFE88382250
        public void ReadExternalReference(){} // RVA: 0x7FFE88382770 | overloaded x3
        public void ReadChar(){} // RVA: 0x7FFE88382A10
        public void ReadString(){} // RVA: 0x7FFE88382B30
        public void ReadGuid(){} // RVA: 0x7FFE88382CF0
        public void ReadSByte(){} // RVA: 0x7FFE88382FB0
        public void ReadInt16(){} // RVA: 0x7FFE88383060
        public void ReadInt32(){} // RVA: 0x7FFE88383120
        public void ReadInt64(){} // RVA: 0x7FFE883831E0
        public void ReadByte(){} // RVA: 0x7FFE883833D0
        public void ReadUInt16(){} // RVA: 0x7FFE88383480
        public void ReadUInt32(){} // RVA: 0x7FFE88383540
        public void ReadUInt64(){} // RVA: 0x7FFE88383600
        public void ReadDecimal(){} // RVA: 0x7FFE883837F0
        public void ReadSingle(){} // RVA: 0x7FFE88383A70
        public void ReadDouble(){} // RVA: 0x7FFE88383CC0
        public void ReadNull(){} // RVA: 0x7FFE88383F10
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFE88384010
        public void GetDataDump(){} // RVA: 0x7FFE88384170
        public void ReadToNextEntry(){} // RVA: 0x7FFE883843D0
        public void MarkEntryConsumed(){} // RVA: 0x7FFE88384400
        public void ReadAnyIntReference(){} // RVA: 0x7FFE88384470
        public void <.ctor>b__7_0(){} // RVA: 0x7FFE88384670
        public void <.ctor>b__7_1(){} // RVA: 0x7FFE883846A0
        public void <.ctor>b__7_2(){} // RVA: 0x7FFE883846D0
        public void <.ctor>b__7_3(){} // RVA: 0x7FFE88384700
        public void <.ctor>b__7_4(){} // RVA: 0x7FFE88384730
        public void <.ctor>b__7_5(){} // RVA: 0x7FFE88384760
        public void <.ctor>b__7_6(){} // RVA: 0x7FFE88384790
        public void <.ctor>b__7_7(){} // RVA: 0x7FFE883847C0
        public void <.ctor>b__7_8(){} // RVA: 0x7FFE883847F0
        public void <.ctor>b__7_9(){} // RVA: 0x7FFE88384820
        public void <.ctor>b__7_10(){} // RVA: 0x7FFE88384860
        public void <.ctor>b__7_11(){} // RVA: 0x7FFE88384890
        public void <.ctor>b__7_12(){} // RVA: 0x7FFE883848C0
        public void <.ctor>b__7_13(){} // RVA: 0x7FFE883848F0
    }

    public class JsonDataWriter : BaseDataWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88384950 | overloaded x2
        public void MarkJustStarted(){} // RVA: 0x7FFE825203D0
        public void FlushToStream(){} // RVA: 0x7FFE883857D0
        public void BeginReferenceNode(){} // RVA: 0x7FFE88385870
        public void BeginStructNode(){} // RVA: 0x7FFE88385970
        public void EndNode(){} // RVA: 0x7FFE88385A30
        public void BeginArrayNode(){} // RVA: 0x7FFE88385AE0
        public void EndArrayNode(){} // RVA: 0x7FFE88385B90
        public void WritePrimitiveArray(){} // RVA: 0x7FFE80E460A0
        public void WriteBoolean(){} // RVA: 0x7FFE88385BF0
        public void WriteByte(){} // RVA: 0x7FFE88385C80
        public void WriteChar(){} // RVA: 0x7FFE88385CA0
        public void WriteDecimal(){} // RVA: 0x7FFE88385DD0
        public void WriteDouble(){} // RVA: 0x7FFE88385EE0
        public void WriteInt32(){} // RVA: 0x7FFE88386020
        public void WriteInt64(){} // RVA: 0x7FFE88386040
        public void WriteNull(){} // RVA: 0x7FFE883861D0
        public void WriteInternalReference(){} // RVA: 0x7FFE88386220
        public void WriteSByte(){} // RVA: 0x7FFE883863D0
        public void WriteInt16(){} // RVA: 0x7FFE883863F0
        public void WriteSingle(){} // RVA: 0x7FFE88386410
        public void WriteString(){} // RVA: 0x7FFE88386550
        public void WriteGuid(){} // RVA: 0x7FFE883867F0
        public void WriteUInt32(){} // RVA: 0x7FFE883868D0
        public void WriteUInt64(){} // RVA: 0x7FFE883868F0
        public void WriteExternalReference(){} // RVA: 0x7FFE88386D40 | overloaded x3
        public void WriteUInt16(){} // RVA: 0x7FFE88386F00
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFE88386F20
        public void GetDataDump(){} // RVA: 0x7FFE88386F80
        public void WriteEntry(){} // RVA: 0x7FFE88387430 | overloaded x2
        public void WriteTypeEntry(){} // RVA: 0x7FFE883876B0
        public void StartNewLine(){} // RVA: 0x7FFE88387950
        public void EnsureBufferSpace(){} // RVA: 0x7FFE88387B70
        public void Buffer_WriteString_WithEscape(){} // RVA: 0x7FFE88387C10
        public void CreateByteToHexLookup(){} // RVA: 0x7FFE883881D0
        public void .cctor(){} // RVA: 0x7FFE883883C0
    }

    public class JsonTextReader : Object
    {
        public System.Collections.Generic.Dictionary`2<char,System.Nullable`1<0x6661D69C>> EntryDelineators;

        // ── Methods ──
        public void get_Context(){} // RVA: 0x7FFE8143BA80
        public void set_Context(){} // RVA: 0x7FFE81437330
        public void .ctor(){} // RVA: 0x7FFE883890D0
        public void Reset(){} // RVA: 0x7FFE88389320
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void ReadToNextEntry(){} // RVA: 0x7FFE88389370
        public void ParseEntryFromBuffer(){} // RVA: 0x7FFE8838A0F0
        public void IsHex(){} // RVA: 0x7FFE8838AE90
        public void ParseSingleChar(){} // RVA: 0x7FFE8838AEC0
        public void ParseHexChar(){} // RVA: 0x7FFE8838AF00
        public void ReadCharIntoBuffer(){} // RVA: 0x7FFE8838B180
        public void GuessPrimitiveType(){} // RVA: 0x7FFE8838B2D0
        public void PeekChar(){} // RVA: 0x7FFE8838B650
        public void SkipChar(){} // RVA: 0x7FFE8838B740
        public void ConsumeChar(){} // RVA: 0x7FFE8838B7F0
        public void .cctor(){} // RVA: 0x7FFE8838B8C0
    }

}