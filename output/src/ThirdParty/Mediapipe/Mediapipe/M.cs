// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 8
// Methods: 76

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class MatrixData
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.MatrixData> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public int RowsDefaultValue; // 0x8
        public int rows_; // 0x1C
        public int ColsDefaultValue; // 0xC
        public int cols_; // 0x20
        public Google.Protobuf.FieldCodec`1<float> _repeated_packedData_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<float> packedData_; // 0x28
        public 0x6592EEF8 LayoutDefaultValue; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B1D6F0
        public void get_Descriptor(){} // RVA: 0x5B1D750
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B1D810
        public void .ctor(){} // RVA: 0x5B1D9C0 | overloaded x2
        public void Clone(){} // RVA: 0x5B1DB70
        public void get_Rows(){} // RVA: 0x5B1DD50
        public void set_Rows(){} // RVA: 0x5A5C3A0
        public void get_HasRows(){} // RVA: 0x5A5C3B0
        public void ClearRows(){} // RVA: 0x5A5C3C0
        public void get_Cols(){} // RVA: 0x5B1DDC0
        public void set_Cols(){} // RVA: 0x5A5C440
        public void get_HasCols(){} // RVA: 0x5A5C450
        public void ClearCols(){} // RVA: 0x5A5C460
        public void get_PackedData(){} // RVA: 0x30B130
        public void get_Layout(){} // RVA: 0x5B1DE30
        public void set_Layout(){} // RVA: 0x5A5F640
        public void get_HasLayout(){} // RVA: 0x5A5F650
        public void ClearLayout(){} // RVA: 0x5A5F660
        public void Equals(){} // RVA: 0x5B1E000 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B1E130
        public void ToString(){} // RVA: 0x5B1E1D0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B1E220
        public void CalculateSize(){} // RVA: 0x5B1E350
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B1E670
        public void .cctor(){} // RVA: 0x5B1E7E0
    }

    public class MatrixDataReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B1D000
        public void .cctor(){} // RVA: 0x5B1D060
    }

    public class MediaPipeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AD3510
    }

    public class MediaPipeOptions
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.MediaPipeOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Mediapipe.MediaPipeOptions> _extensions; // 0x18

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x2E07C0
        public void get_Parser(){} // RVA: 0x5B21DA0
        public void get_Descriptor(){} // RVA: 0x5B21E00
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B21EC0
        public void .ctor(){} // RVA: 0x5B21FB0 | overloaded x2
        public void Clone(){} // RVA: 0x5B22130
        public void Equals(){} // RVA: 0x5B223D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B22470
        public void ToString(){} // RVA: 0x5B224E0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B22530
        public void CalculateSize(){} // RVA: 0x5B225A0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B22740
        public void GetExtension(){} // RVA: 0xCE10 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0xCE10
        public void SetExtension(){} // RVA: 0x283FA0
        public void HasExtension(){} // RVA: 0xDE40
        public void ClearExtension(){} // RVA: 0x24B10 | overloaded x2
        public void .cctor(){} // RVA: 0x5B227F0
    }

    public class MediaPipePluginException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AD3570
    }

    public class MediapipeOptionsReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B21910
        public void .cctor(){} // RVA: 0x5B21970
    }

    public class MpResourceHandle
    {
        public UIntPtr _ptr; // 0x18

        // ── Methods ──
        public void get_ptr(){} // RVA: 0x2E07C0
        public void set_ptr(){} // RVA: 0x5AD35D0
        public void .ctor(){} // RVA: 0x3DDB3A0 | overloaded x2
        public void get_mpPtr(){} // RVA: 0x5AD3660
        public void ReleaseMpResource(){} // RVA: 0x5AD36F0
        public void OwnsResource(){} // RVA: 0x5AD3740
        public void DisposeUnmanaged(){} // RVA: 0x5AD3760
        public void ReleaseMpPtr(){} // RVA: 0x5AD37B0
        public void DeleteMpPtr(){} // RVA: 0x24A50
        public void MarshalStringFromNative(){} // RVA: 0x5AD38F0 | overloaded x2
        public void AssertStatusOk(){} // RVA: 0x5AD39A0
        public void IsResourcePresent(){} // RVA: 0x5AD3AC0
    }

    public class MpReturnCodeExtension
    {
        // ── Methods ──
        public void Assert(){} // RVA: 0x5ADC550
    }

}