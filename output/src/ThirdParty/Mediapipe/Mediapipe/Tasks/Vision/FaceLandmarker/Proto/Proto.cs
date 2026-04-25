// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker.Proto
// Classes: 6
// Methods: 83

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker.Proto
{
    public class FaceBlendshapesGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceBlendshapesGraphOptions> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Mediapipe.Tasks.Core.Proto.BaseOptions pb::Google.Protobuf.IMessage.Descriptor; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC8303B60
        public void get_Descriptor(){} // RVA: 0x7FFAC8303BC0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8303C80
        public void .ctor(){} // RVA: 0x7FFAC8303D70 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8303F10
        public void get_BaseOptions(){} // RVA: 0x7FFAC2F247C0
        public void set_BaseOptions(){} // RVA: 0x7FFAC2F87E80
        public void Equals(){} // RVA: 0x7FFAC82B98E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82B9980
        public void ToString(){} // RVA: 0x7FFAC83041E0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8304230
        public void CalculateSize(){} // RVA: 0x7FFAC8304290
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC83044C0
        public void .cctor(){} // RVA: 0x7FFAC8304580
    }

    public class FaceBlendshapesGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC8303260
        public void .cctor(){} // RVA: 0x7FFAC83032C0
    }

    public class FaceLandmarkerGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceLandmarkerGraphOptions> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions BaseOptions; // 0x20
        public Mediapipe.Tasks.Vision.FaceDetector.Proto.FaceDetectorGraphOptions FaceDetectorGraphOptions; // 0x28
        public Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceLandmarksDetectorGraphOptions FaceLandmarksDetectorGraphOptions; // 0x30
        public float MinTrackingConfidence; // 0x8
        public float HasMinTrackingConfidence; // 0x38
        public Mediapipe.Tasks.Vision.FaceGeometry.Proto.FaceGeometryGraphOptions FaceGeometryGraphOptions; // 0x40

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC83056A0
        public void get_Descriptor(){} // RVA: 0x7FFAC8305700
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC83057C0
        public void .ctor(){} // RVA: 0x7FFAC83058B0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8305CF0
        public void get_BaseOptions(){} // RVA: 0x7FFAC2F4F0C0
        public void set_BaseOptions(){} // RVA: 0x7FFAC2F4F0D0
        public void get_FaceDetectorGraphOptions(){} // RVA: 0x7FFAC2F4F130
        public void set_FaceDetectorGraphOptions(){} // RVA: 0x7FFAC2F22E90
        public void get_FaceLandmarksDetectorGraphOptions(){} // RVA: 0x7FFAC31D95E0
        public void set_FaceLandmarksDetectorGraphOptions(){} // RVA: 0x7FFAC2F4F890
        public void get_MinTrackingConfidence(){} // RVA: 0x7FFAC8305D50
        public void set_MinTrackingConfidence(){} // RVA: 0x7FFAC82F3C80
        public void get_HasMinTrackingConfidence(){} // RVA: 0x7FFAC81F3770
        public void ClearMinTrackingConfidence(){} // RVA: 0x7FFAC81F3780
        public void get_FaceGeometryGraphOptions(){} // RVA: 0x7FFAC2F9E740
        public void set_FaceGeometryGraphOptions(){} // RVA: 0x7FFAC2F49200
        public void Equals(){} // RVA: 0x7FFAC8305E20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8306000
        public void ToString(){} // RVA: 0x7FFAC8306150
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC83061A0
        public void CalculateSize(){} // RVA: 0x7FFAC8306290
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8306780
        public void .cctor(){} // RVA: 0x7FFAC8306940
    }

    public class FaceLandmarkerGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC8304990
        public void .cctor(){} // RVA: 0x7FFAC83049F0
    }

    public class FaceLandmarksDetectorGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceLandmarksDetectorGraphOptions> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions BaseOptions; // 0x20
        public float MinDetectionConfidence; // 0x8
        public float HasMinDetectionConfidence; // 0x28
        public bool SmoothLandmarks; // 0xC
        public bool HasSmoothLandmarks; // 0x2C
        public Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceBlendshapesGraphOptions FaceBlendshapesGraphOptions; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC8307860
        public void get_Descriptor(){} // RVA: 0x7FFAC83078C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8307980
        public void .ctor(){} // RVA: 0x7FFAC8307A70 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8307C60
        public void get_BaseOptions(){} // RVA: 0x7FFAC2F4F0C0
        public void set_BaseOptions(){} // RVA: 0x7FFAC2F4F0D0
        public void get_MinDetectionConfidence(){} // RVA: 0x7FFAC8307CC0
        public void set_MinDetectionConfidence(){} // RVA: 0x7FFAC82F5A30
        public void get_HasMinDetectionConfidence(){} // RVA: 0x7FFAC81F3770
        public void ClearMinDetectionConfidence(){} // RVA: 0x7FFAC81F3780
        public void get_SmoothLandmarks(){} // RVA: 0x7FFAC8307D30
        public void set_SmoothLandmarks(){} // RVA: 0x7FFAC82F5AB0
        public void get_HasSmoothLandmarks(){} // RVA: 0x7FFAC81F3810
        public void ClearSmoothLandmarks(){} // RVA: 0x7FFAC81F3820
        public void get_FaceBlendshapesGraphOptions(){} // RVA: 0x7FFAC31D95E0
        public void set_FaceBlendshapesGraphOptions(){} // RVA: 0x7FFAC2F4F890
        public void Equals(){} // RVA: 0x7FFAC8307E00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8307F80
        public void ToString(){} // RVA: 0x7FFAC83080C0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8308110
        public void CalculateSize(){} // RVA: 0x7FFAC83081E0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8308680
        public void .cctor(){} // RVA: 0x7FFAC83087D0
    }

    public class FaceLandmarksDetectorGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC8306D70
        public void .cctor(){} // RVA: 0x7FFAC8306DD0
    }

}