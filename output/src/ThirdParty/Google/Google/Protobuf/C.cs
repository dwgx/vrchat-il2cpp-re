// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 2
// Methods: 35

namespace ThirdParty.Google.Google.Protobuf
{
    public class CodedInputStream
    {
        public bool leaveOpen; // 0x10
        public byte[] buffer; // 0x18
        public System.IO.Stream input; // 0x20
        public Google.Protobuf.ParserInternalState state; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A1FFB0 | overloaded x3
        public void set_DiscardUnknownFields(){} // RVA: 0x5A20170
        public void set_ExtensionRegistry(){} // RVA: 0x9AA5F0
        public void get_InternalBuffer(){} // RVA: 0x2E07C0
        public void get_InternalInputStream(){} // RVA: 0x30B0C0
        public void get_InternalState(){} // RVA: 0x5A20180
        public void Dispose(){} // RVA: 0x5A20190
        public void CheckReadEndOfStreamTag(){} // RVA: 0x5A201D0
        public void ReadRawMessage(){} // RVA: 0x5A20240
    }

    public class CodedOutputStream
    {
        public int DefaultBufferSize;
        public bool leaveOpen; // 0x10
        public byte[] buffer; // 0x18

        // ── Methods ──
        public void ComputeUInt64Size(){} // RVA: 0x5A20350
        public void ComputeInt64Size(){} // RVA: 0x5A203A0
        public void ComputeInt32Size(){} // RVA: 0x5A203F0
        public void ComputeFixed64Size(){} // RVA: 0xA63AE0
        public void ComputeFixed32Size(){} // RVA: 0xA7E130
        public void ComputeStringSize(){} // RVA: 0x5A20490
        public void ComputeMessageSize(){} // RVA: 0x5A20540
        public void ComputeBytesSize(){} // RVA: 0x5A205D0
        public void ComputeUInt32Size(){} // RVA: 0x5A20690
        public void ComputeEnumSize(){} // RVA: 0x5A20720
        public void ComputeLengthSize(){} // RVA: 0x5A20770
        public void ComputeRawVarint32Size(){} // RVA: 0x5A20800
        public void ComputeRawVarint64Size(){} // RVA: 0x5A20840
        public void ComputeTagSize(){} // RVA: 0x5A208E0
        public void .ctor(){} // RVA: 0x5A209B0 | overloaded x2
        public void WriteRawMessage(){} // RVA: 0x5A20BE0
        public void Dispose(){} // RVA: 0x5A20DA0
        public void Flush(){} // RVA: 0x5A20EA0
        public void CheckNoSpaceLeft(){} // RVA: 0x5A20F70
        public void get_InternalBuffer(){} // RVA: 0x2E07C0
        public void get_InternalOutputStream(){} // RVA: 0x4976A0
        public void get_InternalState(){} // RVA: 0x5A20F80
        public void .cctor(){} // RVA: 0x5A20F90
    }

}