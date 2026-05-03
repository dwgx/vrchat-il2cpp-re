// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceGeometry.Proto
// Classes: 6
// Methods: 73

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceGeometry.Proto
{
    public class FaceGeometry : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceGeometry.Proto.FaceGeometry> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Mediapipe.Tasks.Vision.FaceGeometry.Proto.Mesh3d mesh_; // 0x18
        public Mediapipe.MatrixData poseTransformMatrix_; // 0x20
        public object field_4; // 0x8CD

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866B42C0
        public void get_Descriptor(){} // RVA: 0x7FFE866B4320
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866B43E0
        public void .ctor(){} // RVA: 0x7FFE866B44D0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866B46E0
        public void get_Mesh(){} // RVA: 0x7FFE810FE7C0
        public void set_Mesh(){} // RVA: 0x7FFE81161E80
        public void get_PoseTransformMatrix(){} // RVA: 0x7FFE811290C0
        public void set_PoseTransformMatrix(){} // RVA: 0x7FFE811290D0
        public void Equals(){} // RVA: 0x7FFE866B4870 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866B4950
        public void ToString(){} // RVA: 0x7FFE866B49E0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866B4A30
        public void CalculateSize(){} // RVA: 0x7FFE866B4AB0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866B4DF0
        public void .cctor(){} // RVA: 0x7FFE866B4F20
    }

    public class FaceGeometryGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceGeometry.Proto.FaceGeometryGraphOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Mediapipe.Tasks.Vision.FaceGeometry.FaceGeometryPipelineCalculatorOptions geometryPipelineOptions_; // 0x18
        public object field_3; // 0x2DE

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866B5A20
        public void get_Descriptor(){} // RVA: 0x7FFE866B5A80
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866B5B40
        public void .ctor(){} // RVA: 0x7FFE866B5C30 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866B5DB0
        public void get_GeometryPipelineOptions(){} // RVA: 0x7FFE810FE7C0
        public void set_GeometryPipelineOptions(){} // RVA: 0x7FFE81161E80
        public void Equals(){} // RVA: 0x7FFE86663200 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866632A0
        public void ToString(){} // RVA: 0x7FFE866B6040
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866ADB30
        public void CalculateSize(){} // RVA: 0x7FFE866B6090
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866B6400
        public void .cctor(){} // RVA: 0x7FFE866B64C0
    }

    public class FaceGeometryGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866B5170
        public void .cctor(){} // RVA: 0x7FFE866B51D0
    }

    public class FaceGeometryReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866B3B70
        public void .cctor(){} // RVA: 0x7FFE866B3BD0
    }

    public class Mesh3DReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866B68D0
        public void .cctor(){} // RVA: 0x7FFE866B6930
    }

    public class Mesh3d : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceGeometry.Proto.Mesh3d> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public 0x66610DDC VertexTypeDefaultValue; // 0x8
        public 0x66610DDC vertexType_; // 0x1C
        public 0x66610E34 PrimitiveTypeDefaultValue; // 0xC
        public 0x66610E34 primitiveType_; // 0x20
        public Google.Protobuf.FieldCodec`1<float> _repeated_vertexBuffer_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<float> vertexBuffer_; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866B7100
        public void get_Descriptor(){} // RVA: 0x7FFE866B7160
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866B7220
        public void .ctor(){} // RVA: 0x7FFE866B7470 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866B76A0
        public void get_VertexType(){} // RVA: 0x7FFE866B7700
        public void set_VertexType(){} // RVA: 0x7FFE8659D0A0
        public void get_HasVertexType(){} // RVA: 0x7FFE8659D0B0
        public void ClearVertexType(){} // RVA: 0x7FFE8659D0C0
        public void get_PrimitiveType(){} // RVA: 0x7FFE866B7770
        public void set_PrimitiveType(){} // RVA: 0x7FFE8659D140
        public void get_HasPrimitiveType(){} // RVA: 0x7FFE8659D150
        public void ClearPrimitiveType(){} // RVA: 0x7FFE8659D160
        public void get_VertexBuffer(){} // RVA: 0x7FFE81129130
        public void get_IndexBuffer(){} // RVA: 0x7FFE8144E200
        public void Equals(){} // RVA: 0x7FFE866B7950 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866B7A90
        public void ToString(){} // RVA: 0x7FFE866B7B50
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866B7BA0
        public void CalculateSize(){} // RVA: 0x7FFE866B7E00
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866B8180
        public void .cctor(){} // RVA: 0x7FFE866B8340
    }

}