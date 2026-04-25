// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceGeometry.Proto
// Classes: 6
// Methods: 73

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceGeometry.Proto
{
    public class FaceGeometry : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceGeometry.Proto.FaceGeometry> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Mediapipe.Tasks.Vision.FaceGeometry.Proto.Mesh3d pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Mediapipe.MatrixData Mesh; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC830A9C0
        public void get_Descriptor(){} // RVA: 0x7FFAC830AA20
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC830AAE0
        public void .ctor(){} // RVA: 0x7FFAC830ABD0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC830ADE0
        public void get_Mesh(){} // RVA: 0x7FFAC2F247C0
        public void set_Mesh(){} // RVA: 0x7FFAC2F87E80
        public void get_PoseTransformMatrix(){} // RVA: 0x7FFAC2F4F0C0
        public void set_PoseTransformMatrix(){} // RVA: 0x7FFAC2F4F0D0
        public void Equals(){} // RVA: 0x7FFAC830AF70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC830B050
        public void ToString(){} // RVA: 0x7FFAC830B0E0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC830B130
        public void CalculateSize(){} // RVA: 0x7FFAC830B1B0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC830B4F0
        public void .cctor(){} // RVA: 0x7FFAC830B620
    }

    public class FaceGeometryGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceGeometry.Proto.FaceGeometryGraphOptions> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Mediapipe.Tasks.Vision.FaceGeometry.FaceGeometryPipelineCalculatorOptions pb::Google.Protobuf.IMessage.Descriptor; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC830C120
        public void get_Descriptor(){} // RVA: 0x7FFAC830C180
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC830C240
        public void .ctor(){} // RVA: 0x7FFAC830C330 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC830C4B0
        public void get_GeometryPipelineOptions(){} // RVA: 0x7FFAC2F247C0
        public void set_GeometryPipelineOptions(){} // RVA: 0x7FFAC2F87E80
        public void Equals(){} // RVA: 0x7FFAC82B98E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82B9980
        public void ToString(){} // RVA: 0x7FFAC830C740
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8304230
        public void CalculateSize(){} // RVA: 0x7FFAC830C790
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC830CB00
        public void .cctor(){} // RVA: 0x7FFAC830CBC0
    }

    public class FaceGeometryGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC830B870
        public void .cctor(){} // RVA: 0x7FFAC830B8D0
    }

    public class FaceGeometryReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC830A270
        public void .cctor(){} // RVA: 0x7FFAC830A2D0
    }

    public class Mesh3DReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC830CFD0
        public void .cctor(){} // RVA: 0x7FFAC830D030
    }

    public class Mesh3d : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceGeometry.Proto.Mesh3d> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public 0x6B217518 VertexType; // 0x8
        public 0x6B217518 HasVertexType; // 0x1C
        public 0x6B217570 PrimitiveType; // 0xC
        public 0x6B217570 HasPrimitiveType; // 0x20
        public Google.Protobuf.FieldCodec`1<float> VertexBuffer; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<float> IndexBuffer; // 0x28
        public Google.Protobuf.FieldCodec`1<uint> _repeated_indexBuffer_codec; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<uint> indexBuffer_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC830D800
        public void get_Descriptor(){} // RVA: 0x7FFAC830D860
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC830D920
        public void .ctor(){} // RVA: 0x7FFAC830DB70 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC830DDA0
        public void get_VertexType(){} // RVA: 0x7FFAC830DE00
        public void set_VertexType(){} // RVA: 0x7FFAC81F3760
        public void get_HasVertexType(){} // RVA: 0x7FFAC81F3770
        public void ClearVertexType(){} // RVA: 0x7FFAC81F3780
        public void get_PrimitiveType(){} // RVA: 0x7FFAC830DE70
        public void set_PrimitiveType(){} // RVA: 0x7FFAC81F3800
        public void get_HasPrimitiveType(){} // RVA: 0x7FFAC81F3810
        public void ClearPrimitiveType(){} // RVA: 0x7FFAC81F3820
        public void get_VertexBuffer(){} // RVA: 0x7FFAC2F4F130
        public void get_IndexBuffer(){} // RVA: 0x7FFAC31D95E0
        public void Equals(){} // RVA: 0x7FFAC830E050 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC830E190
        public void ToString(){} // RVA: 0x7FFAC830E250
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC830E2A0
        public void CalculateSize(){} // RVA: 0x7FFAC830E500
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC830E880
        public void .cctor(){} // RVA: 0x7FFAC830EA40
    }

}