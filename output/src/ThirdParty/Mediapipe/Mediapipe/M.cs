// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 8
// Methods: 76

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class MatrixData : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.MatrixData> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int Rows; // 0x8
        public int HasRows; // 0x1C
        public int Cols; // 0xC
        public int HasCols; // 0x20
        public Google.Protobuf.FieldCodec`1<float> PackedData; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<float> Layout; // 0x28
        public 0x6B212D40 HasLayout; // 0x18
        public 0x6B212D40 layout_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82B4C00
        public void get_Descriptor(){} // RVA: 0x7FFAC82B4C60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82B4D20
        public void .ctor(){} // RVA: 0x7FFAC82B4ED0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82B5080
        public void get_Rows(){} // RVA: 0x7FFAC82B5260
        public void set_Rows(){} // RVA: 0x7FFAC81F3760
        public void get_HasRows(){} // RVA: 0x7FFAC81F3770
        public void ClearRows(){} // RVA: 0x7FFAC81F3780
        public void get_Cols(){} // RVA: 0x7FFAC82B52D0
        public void set_Cols(){} // RVA: 0x7FFAC81F3800
        public void get_HasCols(){} // RVA: 0x7FFAC81F3810
        public void ClearCols(){} // RVA: 0x7FFAC81F3820
        public void get_PackedData(){} // RVA: 0x7FFAC2F4F130
        public void get_Layout(){} // RVA: 0x7FFAC82B5340
        public void set_Layout(){} // RVA: 0x7FFAC81F6A00
        public void get_HasLayout(){} // RVA: 0x7FFAC81F6A10
        public void ClearLayout(){} // RVA: 0x7FFAC81F6A20
        public void Equals(){} // RVA: 0x7FFAC82B5510 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82B5640
        public void ToString(){} // RVA: 0x7FFAC82B56E0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82B5730
        public void CalculateSize(){} // RVA: 0x7FFAC82B5860
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82B5B80
        public void .cctor(){} // RVA: 0x7FFAC82B5CF0
    }

    public class MatrixDataReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82B4510
        public void .cctor(){} // RVA: 0x7FFAC82B4570
    }

    public class MediaPipeException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC826AA20
    }

    public class MediaPipeOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.MediaPipeOptions> _Extensions;
        public Google.Protobuf.UnknownFieldSet Parser; // 0x10
        public Google.Protobuf.ExtensionSet`1<Mediapipe.MediaPipeOptions> Descriptor; // 0x18

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFAC2F247C0
        public void get_Parser(){} // RVA: 0x7FFAC82B92B0
        public void get_Descriptor(){} // RVA: 0x7FFAC82B9310
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82B93D0
        public void .ctor(){} // RVA: 0x7FFAC82B94C0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82B9640
        public void Equals(){} // RVA: 0x7FFAC82B98E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82B9980
        public void ToString(){} // RVA: 0x7FFAC82B99F0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82B9A40
        public void CalculateSize(){} // RVA: 0x7FFAC82B9AB0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82B9C50
        public void GetExtension(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFAC2C58F40
        public void SetExtension(){} // RVA: 0x7FFAC2E8DC40
        public void HasExtension(){} // RVA: 0x7FFAC2C59F60
        public void ClearExtension(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC82B9D00
    }

    public class MediaPipePluginException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC826AA80
    }

    public class MediapipeOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82B8E20
        public void .cctor(){} // RVA: 0x7FFAC82B8E80
    }

    public class MpResourceHandle : DisposableObject
    {
        public UIntPtr ptr; // 0x18

        // ── Methods ──
        public void get_ptr(){} // RVA: 0x7FFAC2F247C0
        public void set_ptr(){} // RVA: 0x7FFAC826AAE0
        public void .ctor(){} // RVA: 0x7FFAC66E6D30 | overloaded x2
        public void get_mpPtr(){} // RVA: 0x7FFAC826AB70
        public void ReleaseMpResource(){} // RVA: 0x7FFAC826AC00
        public void OwnsResource(){} // RVA: 0x7FFAC826AC50
        public void DisposeUnmanaged(){} // RVA: 0x7FFAC826AC70
        public void ReleaseMpPtr(){} // RVA: 0x7FFAC826ACC0
        public void DeleteMpPtr(){} // RVA: 0x7FFAC2C70980
        public void MarshalStringFromNative(){} // RVA: 0x7FFAC826AE00 | overloaded x2
        public void AssertStatusOk(){} // RVA: 0x7FFAC826AEB0
        public void IsResourcePresent(){} // RVA: 0x7FFAC826AFD0
    }

    public class MpReturnCodeExtension : Object
    {
        // ── Methods ──
        public void Assert(){} // RVA: 0x7FFAC8273A60
    }

}