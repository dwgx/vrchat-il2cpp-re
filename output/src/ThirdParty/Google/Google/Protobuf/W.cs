// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf
// Classes: 6
// Methods: 68

namespace ThirdParty.Google.Google.Protobuf
{
    public class WireFormat
    {
        // ── Methods ──
        public void GetTagWireType(){} // RVA: 0x5A34FE0
        public void GetTagFieldNumber(){} // RVA: 0x5A34FF0
        public void MakeTag(){} // RVA: 0x5A35000
    }

    public class WriteBufferHelper
    {
        public System.Buffers.IBufferWriter`1<byte> bufferWriter; // 0x10

        // ── Methods ──
        public void get_CodedOutputStream(){} // RVA: 0x19689C0
        public void Initialize(){} // RVA: 0x5A35010
        public void InitializeNonRefreshable(){} // RVA: 0x5A350C0
        public void CheckNoSpaceLeft(){} // RVA: 0x5A35170
        public void GetSpaceLeft(){} // RVA: 0x5A351E0
        public void RefreshBuffer(){} // RVA: 0x5A35260
        public void Flush(){} // RVA: 0x5A353A0
    }

    public class WriteContext
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x5A354D0 | overloaded x2
        public void WriteDouble(){} // RVA: 0x5A35530
        public void WriteFloat(){} // RVA: 0x5A355E0
        public void WriteUInt64(){} // RVA: 0x5A35730
        public void WriteInt64(){} // RVA: 0x5A357E0
        public void WriteInt32(){} // RVA: 0x5A35890
        public void WriteFixed64(){} // RVA: 0x5A35900
        public void WriteFixed32(){} // RVA: 0x5A359B0
        public void WriteBool(){} // RVA: 0x5A35B50
        public void WriteString(){} // RVA: 0x5A35C00
        public void WriteMessage(){} // RVA: 0x5A35C70
        public void WriteBytes(){} // RVA: 0x5A35D30
        public void WriteUInt32(){} // RVA: 0x5A35E70
        public void WriteEnum(){} // RVA: 0x5A35F20
        public void WriteLength(){} // RVA: 0x5A35FD0
        public void WriteTag(){} // RVA: 0x5A36100 | overloaded x2
        public void WriteRawTag(){} // RVA: 0x5A36260 | overloaded x2
        public void CheckNoSpaceLeft(){} // RVA: 0x5A36370
        public void CopyStateTo(){} // RVA: 0x5A36380
        public void LoadStateFrom(){} // RVA: 0x5A363F0
    }

    public class WriterInternalState
    {
        public int limit; // 0x10

        // ── Methods ──
        public void get_CodedOutputStream(){} // RVA: 0x2F8380
    }

    public class WritingPrimitives
    {
        // ── Methods ──
        public void WriteDouble(){} // RVA: 0x5A36460
        public void WriteFloat(){} // RVA: 0x5A364D0
        public void WriteFloatSlowPath(){} // RVA: 0x5A365F0
        public void WriteUInt64(){} // RVA: 0x5A36710
        public void WriteInt64(){} // RVA: 0x5A36780
        public void WriteInt32(){} // RVA: 0x5A367F0
        public void WriteFixed64(){} // RVA: 0x5A36890
        public void WriteFixed32(){} // RVA: 0x5A36900
        public void WriteBool(){} // RVA: 0x5A36A70
        public void WriteString(){} // RVA: 0x5A36AE0
        public void WriteAsciiStringToBuffer(){} // RVA: 0x5A36D90
        public void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(){} // RVA: 0x5A36F20
        public void WriteStringToBuffer(){} // RVA: 0x5A36F40
        public void WriteBytes(){} // RVA: 0x5A370A0
        public void WriteUInt32(){} // RVA: 0x5A371B0
        public void WriteEnum(){} // RVA: 0x5A37220
        public void WriteLength(){} // RVA: 0x5A37290
        public void WriteRawVarint32(){} // RVA: 0x5A37300
        public void WriteRawVarint64(){} // RVA: 0x5A374B0
        public void WriteRawLittleEndian32(){} // RVA: 0x5A37660
        public void WriteRawLittleEndian32SlowPath(){} // RVA: 0x5A37790
        public void WriteRawLittleEndian64(){} // RVA: 0x5A37840
        public void WriteRawLittleEndian64SlowPath(){} // RVA: 0x5A37970
        public void WriteRawByte(){} // RVA: 0x5A37A80
        public void WriteRawBytes(){} // RVA: 0x5A37BC0 | overloaded x2
        public void WriteTag(){} // RVA: 0x5A37F80 | overloaded x2
        public void WriteRawTag(){} // RVA: 0x5A38060 | overloaded x2
        public void WriteRawTagSlowPath(){} // RVA: 0x5A38140
        public void .cctor(){} // RVA: 0x5A381D0
    }

    public class WritingPrimitivesMessages
    {
        // ── Methods ──
        public void WriteMessage(){} // RVA: 0x5A38270
        public void WriteRawMessage(){} // RVA: 0x5A38330
    }

}