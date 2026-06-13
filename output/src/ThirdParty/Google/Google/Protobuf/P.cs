// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 5
// Methods: 70

namespace ThirdParty.Google.Google.Protobuf
{
    public class ParseContext
    {
        public System.ReadOnlySpan`1<byte> CodedInputStream; // 0x10
        public Google.Protobuf.ParserInternalState DiscardUnknownFields; // 0x20

        // ── Methods ──
        public void Initialize(){} // RVA: 0x5A2DC00 | overloaded x5
        public void get_LastTag(){} // RVA: 0x10E5CF0
        public void get_DiscardUnknownFields(){} // RVA: 0x3BCCE0
        public void set_DiscardUnknownFields(){} // RVA: 0x3BCCF0
        public void get_ExtensionRegistry(){} // RVA: 0x31C010
        public void set_ExtensionRegistry(){} // RVA: 0x463060
        public void ReadTag(){} // RVA: 0x5A2DD20
        public void ReadDouble(){} // RVA: 0x5A2DD30
        public void ReadFloat(){} // RVA: 0x5A2DD40
        public void ReadUInt64(){} // RVA: 0x5A2DD50
        public void ReadInt64(){} // RVA: 0x5A2DD50
        public void ReadInt32(){} // RVA: 0x5A2DD60
        public void ReadFixed64(){} // RVA: 0x5A2DD70
        public void ReadFixed32(){} // RVA: 0x5A2DD80
        public void ReadBool(){} // RVA: 0x5A2DD90
        public void ReadString(){} // RVA: 0x5A2DDB0
        public void ReadMessage(){} // RVA: 0x5A2DDF0
        public void ReadBytes(){} // RVA: 0x5A2DE50
        public void ReadUInt32(){} // RVA: 0x5A2DD60
        public void ReadEnum(){} // RVA: 0x5A2DD60
        public void ReadLength(){} // RVA: 0x5A2DD60
        public void CopyStateTo(){} // RVA: 0x5A2DE60
        public void LoadStateFrom(){} // RVA: 0x5A2DF20
    }

    public class ParserInternalState
    {
        public int bufferPos; // 0x10
        public int bufferSize; // 0x14
        public int bufferSizeAfterLimit; // 0x18

        // ── Methods ──
        public void get_CodedInputStream(){} // RVA: 0x3A5500
        public void get_DiscardUnknownFields(){} // RVA: 0x1120170
        public void set_DiscardUnknownFields(){} // RVA: 0x5A2DFE0
        public void get_ExtensionRegistry(){} // RVA: 0x4C7C50
        public void set_ExtensionRegistry(){} // RVA: 0x4C34F0
    }

    public class ParsingPrimitives
    {
        // ── Methods ──
        public void ParseLength(){} // RVA: 0x5A2DFF0
        public void ParseTag(){} // RVA: 0x5A2E000
        public void MaybeConsumeTag(){} // RVA: 0x5A2E120
        public void PeekTag(){} // RVA: 0x5A2E180
        public void ParseRawVarint64(){} // RVA: 0x5A2E1C0
        public void ParseRawVarint64SlowPath(){} // RVA: 0x5A2E340
        public void ParseRawVarint32(){} // RVA: 0x5A2E420
        public void ParseRawVarint32SlowPath(){} // RVA: 0x5A2E5F0
        public void ParseRawLittleEndian32(){} // RVA: 0x5A2E790
        public void ParseRawLittleEndian32SlowPath(){} // RVA: 0x5A2E870
        public void ParseRawLittleEndian64(){} // RVA: 0x5A2E9C0
        public void ParseRawLittleEndian64SlowPath(){} // RVA: 0x5A2EAA0
        public void ParseDouble(){} // RVA: 0x5A2ED40
        public void ParseFloat(){} // RVA: 0x5A2EE00
        public void ParseFloatSlow(){} // RVA: 0x5A2EEC0
        public void ReadRawBytes(){} // RVA: 0x5A2EFC0
        public void ReadRawBytesSlow(){} // RVA: 0x5A2F1B0
        public void SkipRawBytes(){} // RVA: 0x5A2F830
        public void ReadString(){} // RVA: 0x5A2F940
        public void ReadBytes(){} // RVA: 0x5A2F980
        public void ReadRawString(){} // RVA: 0x5A2FA00
        public void ReadStringSlow(){} // RVA: 0x5A2FB90
        public void ValidateCurrentLimit(){} // RVA: 0x5A30090
        public void ReadRawByte(){} // RVA: 0x5A30100
        public void IsDataAvailable(){} // RVA: 0x5A30170
        public void IsDataAvailableInSource(){} // RVA: 0x5A30190
        public void ReadRawBytesIntoSpan(){} // RVA: 0x5A30250
    }

    public class ParsingPrimitivesMessages
    {
        // ── Methods ──
        public void SkipLastField(){} // RVA: 0x5A30460
        public void SkipGroup(){} // RVA: 0x5A30620
        public void ReadMessage(){} // RVA: 0x5A307D0
        public void ReadMapEntry(){} // RVA: 0x283FA0
        public void ReadGroup(){} // RVA: 0x5A30930
        public void ReadRawMessage(){} // RVA: 0x5A30A40
        public void CheckReadEndOfStreamTag(){} // RVA: 0x5A30BE0
        public void CheckLastTagWas(){} // RVA: 0x5A30C20
        public void .cctor(){} // RVA: 0x5A30C60
    }

    public class ProtoPreconditions
    {
        // ── Methods ──
        public void CheckNotNull(){} // RVA: 0x283FA0
        public void CheckNotNullUnconstrained(){} // RVA: 0x283FA0
    }

}