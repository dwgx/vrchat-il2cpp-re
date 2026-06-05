// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 2
// Methods: 35

namespace ThirdParty.Google.Google.Protobuf
{
    public class CodedInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF84CFFB0 | overloaded x3
        public void set_DiscardUnknownFields(){} // RVA: 0x7FFAF84D0170
        public void set_ExtensionRegistry(){} // RVA: 0x7FFAF345A5F0
        public void get_InternalBuffer(){} // RVA: 0x7FFAF2D907C0
        public void get_InternalInputStream(){} // RVA: 0x7FFAF2DBB0C0
        public void get_InternalState(){} // RVA: 0x7FFAF84D0180
        public void Dispose(){} // RVA: 0x7FFAF84D0190
        public void CheckReadEndOfStreamTag(){} // RVA: 0x7FFAF84D01D0
        public void ReadRawMessage(){} // RVA: 0x7FFAF84D0240
    }

    public class CodedOutputStream
    {
        // ── Methods ──
        public void ComputeUInt64Size(){} // RVA: 0x7FFAF84D0350
        public void ComputeInt64Size(){} // RVA: 0x7FFAF84D03A0
        public void ComputeInt32Size(){} // RVA: 0x7FFAF84D03F0
        public void ComputeFixed64Size(){} // RVA: 0x7FFAF3513AE0
        public void ComputeFixed32Size(){} // RVA: 0x7FFAF352E130
        public void ComputeStringSize(){} // RVA: 0x7FFAF84D0490
        public void ComputeMessageSize(){} // RVA: 0x7FFAF84D0540
        public void ComputeBytesSize(){} // RVA: 0x7FFAF84D05D0
        public void ComputeUInt32Size(){} // RVA: 0x7FFAF84D0690
        public void ComputeEnumSize(){} // RVA: 0x7FFAF84D0720
        public void ComputeLengthSize(){} // RVA: 0x7FFAF84D0770
        public void ComputeRawVarint32Size(){} // RVA: 0x7FFAF84D0800
        public void ComputeRawVarint64Size(){} // RVA: 0x7FFAF84D0840
        public void ComputeTagSize(){} // RVA: 0x7FFAF84D08E0
        public void .ctor(){} // RVA: 0x7FFAF84D09B0 | overloaded x2
        public void WriteRawMessage(){} // RVA: 0x7FFAF84D0BE0
        public void Dispose(){} // RVA: 0x7FFAF84D0DA0
        public void Flush(){} // RVA: 0x7FFAF84D0EA0
        public void CheckNoSpaceLeft(){} // RVA: 0x7FFAF84D0F70
        public void get_InternalBuffer(){} // RVA: 0x7FFAF2D907C0
        public void get_InternalOutputStream(){} // RVA: 0x7FFAF2F476A0
        public void get_InternalState(){} // RVA: 0x7FFAF84D0F80
        public void .cctor(){} // RVA: 0x7FFAF84D0F90
    }

}