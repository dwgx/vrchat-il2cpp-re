// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 6
// Methods: 68

namespace ThirdParty.Google.Google.Protobuf
{
    public class WireFormat
    {
        // ── Methods ──
        public void GetTagWireType(){} // RVA: 0x7FFAF84E4FE0
        public void GetTagFieldNumber(){} // RVA: 0x7FFAF84E4FF0
        public void MakeTag(){} // RVA: 0x7FFAF84E5000
    }

    public class WriteBufferHelper
    {
        // ── Methods ──
        public void get_CodedOutputStream(){} // RVA: 0x7FFAF44189C0
        public void Initialize(){} // RVA: 0x7FFAF84E5010
        public void InitializeNonRefreshable(){} // RVA: 0x7FFAF84E50C0
        public void CheckNoSpaceLeft(){} // RVA: 0x7FFAF84E5170
        public void GetSpaceLeft(){} // RVA: 0x7FFAF84E51E0
        public void RefreshBuffer(){} // RVA: 0x7FFAF84E5260
        public void Flush(){} // RVA: 0x7FFAF84E53A0
    }

    public class WriteContext
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAF84E54D0 | overloaded x2
        public void WriteDouble(){} // RVA: 0x7FFAF84E5530
        public void WriteFloat(){} // RVA: 0x7FFAF84E55E0
        public void WriteUInt64(){} // RVA: 0x7FFAF84E5730
        public void WriteInt64(){} // RVA: 0x7FFAF84E57E0
        public void WriteInt32(){} // RVA: 0x7FFAF84E5890
        public void WriteFixed64(){} // RVA: 0x7FFAF84E5900
        public void WriteFixed32(){} // RVA: 0x7FFAF84E59B0
        public void WriteBool(){} // RVA: 0x7FFAF84E5B50
        public void WriteString(){} // RVA: 0x7FFAF84E5C00
        public void WriteMessage(){} // RVA: 0x7FFAF84E5C70
        public void WriteBytes(){} // RVA: 0x7FFAF84E5D30
        public void WriteUInt32(){} // RVA: 0x7FFAF84E5E70
        public void WriteEnum(){} // RVA: 0x7FFAF84E5F20
        public void WriteLength(){} // RVA: 0x7FFAF84E5FD0
        public void WriteTag(){} // RVA: 0x7FFAF84E6100 | overloaded x2
        public void WriteRawTag(){} // RVA: 0x7FFAF84E6260 | overloaded x2
        public void CheckNoSpaceLeft(){} // RVA: 0x7FFAF84E6370
        public void CopyStateTo(){} // RVA: 0x7FFAF84E6380
        public void LoadStateFrom(){} // RVA: 0x7FFAF84E63F0
    }

    public class WriterInternalState
    {
        // ── Methods ──
        public void get_CodedOutputStream(){} // RVA: 0x7FFAF2DA8380
    }

    public class WritingPrimitives
    {
        // ── Methods ──
        public void WriteDouble(){} // RVA: 0x7FFAF84E6460
        public void WriteFloat(){} // RVA: 0x7FFAF84E64D0
        public void WriteFloatSlowPath(){} // RVA: 0x7FFAF84E65F0
        public void WriteUInt64(){} // RVA: 0x7FFAF84E6710
        public void WriteInt64(){} // RVA: 0x7FFAF84E6780
        public void WriteInt32(){} // RVA: 0x7FFAF84E67F0
        public void WriteFixed64(){} // RVA: 0x7FFAF84E6890
        public void WriteFixed32(){} // RVA: 0x7FFAF84E6900
        public void WriteBool(){} // RVA: 0x7FFAF84E6A70
        public void WriteString(){} // RVA: 0x7FFAF84E6AE0
        public void WriteAsciiStringToBuffer(){} // RVA: 0x7FFAF84E6D90
        public void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(){} // RVA: 0x7FFAF84E6F20
        public void WriteStringToBuffer(){} // RVA: 0x7FFAF84E6F40
        public void WriteBytes(){} // RVA: 0x7FFAF84E70A0
        public void WriteUInt32(){} // RVA: 0x7FFAF84E71B0
        public void WriteEnum(){} // RVA: 0x7FFAF84E7220
        public void WriteLength(){} // RVA: 0x7FFAF84E7290
        public void WriteRawVarint32(){} // RVA: 0x7FFAF84E7300
        public void WriteRawVarint64(){} // RVA: 0x7FFAF84E74B0
        public void WriteRawLittleEndian32(){} // RVA: 0x7FFAF84E7660
        public void WriteRawLittleEndian32SlowPath(){} // RVA: 0x7FFAF84E7790
        public void WriteRawLittleEndian64(){} // RVA: 0x7FFAF84E7840
        public void WriteRawLittleEndian64SlowPath(){} // RVA: 0x7FFAF84E7970
        public void WriteRawByte(){} // RVA: 0x7FFAF84E7A80
        public void WriteRawBytes(){} // RVA: 0x7FFAF84E7BC0 | overloaded x2
        public void WriteTag(){} // RVA: 0x7FFAF84E7F80 | overloaded x2
        public void WriteRawTag(){} // RVA: 0x7FFAF84E8060 | overloaded x2
        public void WriteRawTagSlowPath(){} // RVA: 0x7FFAF84E8140
        public void .cctor(){} // RVA: 0x7FFAF84E81D0
    }

    public class WritingPrimitivesMessages
    {
        // ── Methods ──
        public void WriteMessage(){} // RVA: 0x7FFAF84E8270
        public void WriteRawMessage(){} // RVA: 0x7FFAF84E8330
    }

}