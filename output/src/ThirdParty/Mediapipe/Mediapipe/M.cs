// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 8
// Methods: 76

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class MatrixData : Object
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
        public 0x6660C604 LayoutDefaultValue; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8665E520
        public void get_Descriptor(){} // RVA: 0x7FFE8665E580
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8665E640
        public void .ctor(){} // RVA: 0x7FFE8665E7F0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8665E9A0
        public void get_Rows(){} // RVA: 0x7FFE8665EB80
        public void set_Rows(){} // RVA: 0x7FFE8659D0A0
        public void get_HasRows(){} // RVA: 0x7FFE8659D0B0
        public void ClearRows(){} // RVA: 0x7FFE8659D0C0
        public void get_Cols(){} // RVA: 0x7FFE8665EBF0
        public void set_Cols(){} // RVA: 0x7FFE8659D140
        public void get_HasCols(){} // RVA: 0x7FFE8659D150
        public void ClearCols(){} // RVA: 0x7FFE8659D160
        public void get_PackedData(){} // RVA: 0x7FFE81129130
        public void get_Layout(){} // RVA: 0x7FFE8665EC60
        public void set_Layout(){} // RVA: 0x7FFE865A0340
        public void get_HasLayout(){} // RVA: 0x7FFE865A0350
        public void ClearLayout(){} // RVA: 0x7FFE865A0360
        public void Equals(){} // RVA: 0x7FFE8665EE30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8665EF60
        public void ToString(){} // RVA: 0x7FFE8665F000
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8665F050
        public void CalculateSize(){} // RVA: 0x7FFE8665F180
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8665F4A0
        public void .cctor(){} // RVA: 0x7FFE8665F610
    }

    public class MatrixDataReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE8665DE30
        public void .cctor(){} // RVA: 0x7FFE8665DE90
    }

    public class MediaPipeException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86614340
    }

    public class MediaPipeOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.MediaPipeOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.ExtensionSet`1<Mediapipe.MediaPipeOptions> _extensions; // 0x18
        public object field_3; // 0x1D0

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFE810FE7C0
        public void get_Parser(){} // RVA: 0x7FFE86662BD0
        public void get_Descriptor(){} // RVA: 0x7FFE86662C30
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86662CF0
        public void .ctor(){} // RVA: 0x7FFE86662DE0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86662F60
        public void Equals(){} // RVA: 0x7FFE86663200 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866632A0
        public void ToString(){} // RVA: 0x7FFE86663310
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86663360
        public void CalculateSize(){} // RVA: 0x7FFE866633D0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86663570
        public void GetExtension(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFE80E2E390
        public void SetExtension(){} // RVA: 0x7FFE810A1420
        public void HasExtension(){} // RVA: 0x7FFE80E2F3B0
        public void ClearExtension(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE86663620
    }

    public class MediaPipePluginException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866143A0
    }

    public class MediapipeOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE86662740
        public void .cctor(){} // RVA: 0x7FFE866627A0
    }

    public class MpResourceHandle : DisposableObject
    {
        public UIntPtr _ptr; // 0x18
        public uint DefaultAlignmentBoundary;

        // ── Methods ──
        public void get_ptr(){} // RVA: 0x7FFE810FE7C0
        public void set_ptr(){} // RVA: 0x7FFE86614400
        public void .ctor(){} // RVA: 0x7FFE84A4B910 | overloaded x2
        public void get_mpPtr(){} // RVA: 0x7FFE86614490
        public void ReleaseMpResource(){} // RVA: 0x7FFE86614520
        public void OwnsResource(){} // RVA: 0x7FFE86614570
        public void DisposeUnmanaged(){} // RVA: 0x7FFE86614590
        public void ReleaseMpPtr(){} // RVA: 0x7FFE866145E0
        public void DeleteMpPtr(){} // RVA: 0x7FFE80E45FE0
        public void MarshalStringFromNative(){} // RVA: 0x7FFE86614720 | overloaded x2
        public void AssertStatusOk(){} // RVA: 0x7FFE866147D0
        public void IsResourcePresent(){} // RVA: 0x7FFE866148F0
    }

    public class MpReturnCodeExtension : Object
    {
        // ── Methods ──
        public void Assert(){} // RVA: 0x7FFE8661D380
    }

}