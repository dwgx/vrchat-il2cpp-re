// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 5
// Methods: 70

namespace ThirdParty.Google.Google.Protobuf
{
    public class ParseContext
    {
        public object CodedInputStream;
        public object DiscardUnknownFields;
        public object ExtensionRegistry;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAF84DDC00 | overloaded x5
        public void get_LastTag(){} // RVA: 0x7FFAF3B95CF0
        public void get_DiscardUnknownFields(){} // RVA: 0x7FFAF2E6CCE0
        public void set_DiscardUnknownFields(){} // RVA: 0x7FFAF2E6CCF0
        public void get_ExtensionRegistry(){} // RVA: 0x7FFAF2DCC010
        public void set_ExtensionRegistry(){} // RVA: 0x7FFAF2F13060
        public void ReadTag(){} // RVA: 0x7FFAF84DDD20
        public void ReadDouble(){} // RVA: 0x7FFAF84DDD30
        public void ReadFloat(){} // RVA: 0x7FFAF84DDD40
        public void ReadUInt64(){} // RVA: 0x7FFAF84DDD50
        public void ReadInt64(){} // RVA: 0x7FFAF84DDD50
        public void ReadInt32(){} // RVA: 0x7FFAF84DDD60
        public void ReadFixed64(){} // RVA: 0x7FFAF84DDD70
        public void ReadFixed32(){} // RVA: 0x7FFAF84DDD80
        public void ReadBool(){} // RVA: 0x7FFAF84DDD90
        public void ReadString(){} // RVA: 0x7FFAF84DDDB0
        public void ReadMessage(){} // RVA: 0x7FFAF84DDDF0
        public void ReadBytes(){} // RVA: 0x7FFAF84DDE50
        public void ReadUInt32(){} // RVA: 0x7FFAF84DDD60
        public void ReadEnum(){} // RVA: 0x7FFAF84DDD60
        public void ReadLength(){} // RVA: 0x7FFAF84DDD60
        public void CopyStateTo(){} // RVA: 0x7FFAF84DDE60
        public void LoadStateFrom(){} // RVA: 0x7FFAF84DDF20
    }

    public class ParserInternalState
    {
        // ── Methods ──
        public void get_CodedInputStream(){} // RVA: 0x7FFAF2E55500
        public void get_DiscardUnknownFields(){} // RVA: 0x7FFAF3BD0170
        public void set_DiscardUnknownFields(){} // RVA: 0x7FFAF84DDFE0
        public void get_ExtensionRegistry(){} // RVA: 0x7FFAF2F77C50
        public void set_ExtensionRegistry(){} // RVA: 0x7FFAF2F734F0
    }

    public class ParsingPrimitives
    {
        // ── Methods ──
        public void ParseLength(){} // RVA: 0x7FFAF84DDFF0
        public void ParseTag(){} // RVA: 0x7FFAF84DE000
        public void MaybeConsumeTag(){} // RVA: 0x7FFAF84DE120
        public void PeekTag(){} // RVA: 0x7FFAF84DE180
        public void ParseRawVarint64(){} // RVA: 0x7FFAF84DE1C0
        public void ParseRawVarint64SlowPath(){} // RVA: 0x7FFAF84DE340
        public void ParseRawVarint32(){} // RVA: 0x7FFAF84DE420
        public void ParseRawVarint32SlowPath(){} // RVA: 0x7FFAF84DE5F0
        public void ParseRawLittleEndian32(){} // RVA: 0x7FFAF84DE790
        public void ParseRawLittleEndian32SlowPath(){} // RVA: 0x7FFAF84DE870
        public void ParseRawLittleEndian64(){} // RVA: 0x7FFAF84DE9C0
        public void ParseRawLittleEndian64SlowPath(){} // RVA: 0x7FFAF84DEAA0
        public void ParseDouble(){} // RVA: 0x7FFAF84DED40
        public void ParseFloat(){} // RVA: 0x7FFAF84DEE00
        public void ParseFloatSlow(){} // RVA: 0x7FFAF84DEEC0
        public void ReadRawBytes(){} // RVA: 0x7FFAF84DEFC0
        public void ReadRawBytesSlow(){} // RVA: 0x7FFAF84DF1B0
        public void SkipRawBytes(){} // RVA: 0x7FFAF84DF830
        public void ReadString(){} // RVA: 0x7FFAF84DF940
        public void ReadBytes(){} // RVA: 0x7FFAF84DF980
        public void ReadRawString(){} // RVA: 0x7FFAF84DFA00
        public void ReadStringSlow(){} // RVA: 0x7FFAF84DFB90
        public void ValidateCurrentLimit(){} // RVA: 0x7FFAF84E0090
        public void ReadRawByte(){} // RVA: 0x7FFAF84E0100
        public void IsDataAvailable(){} // RVA: 0x7FFAF84E0170
        public void IsDataAvailableInSource(){} // RVA: 0x7FFAF84E0190
        public void ReadRawBytesIntoSpan(){} // RVA: 0x7FFAF84E0250
    }

    public class ParsingPrimitivesMessages
    {
        // ── Methods ──
        public void SkipLastField(){} // RVA: 0x7FFAF84E0460
        public void SkipGroup(){} // RVA: 0x7FFAF84E0620
        public void ReadMessage(){} // RVA: 0x7FFAF84E07D0
        public void ReadMapEntry(){} // RVA: 0x7FFAF2D33FA0
        public void ReadGroup(){} // RVA: 0x7FFAF84E0930
        public void ReadRawMessage(){} // RVA: 0x7FFAF84E0A40
        public void CheckReadEndOfStreamTag(){} // RVA: 0x7FFAF84E0BE0
        public void CheckLastTagWas(){} // RVA: 0x7FFAF84E0C20
        public void .cctor(){} // RVA: 0x7FFAF84E0C60
    }

    public class ProtoPreconditions
    {
        // ── Methods ──
        public void CheckNotNull(){} // RVA: 0x7FFAF2D33FA0
        public void CheckNotNullUnconstrained(){} // RVA: 0x7FFAF2D33FA0
    }

}