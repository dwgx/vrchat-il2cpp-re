// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker.Proto
// Classes: 6
// Methods: 83

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker.Proto
{
    public class FaceBlendshapesGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceBlendshapesGraphOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Mediapipe.Tasks.Core.Proto.BaseOptions baseOptions_; // 0x18
        public object field_3; // 0x2BA

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866AD460
        public void get_Descriptor(){} // RVA: 0x7FFE866AD4C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866AD580
        public void .ctor(){} // RVA: 0x7FFE866AD670 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866AD810
        public void get_BaseOptions(){} // RVA: 0x7FFE810FE7C0
        public void set_BaseOptions(){} // RVA: 0x7FFE81161E80
        public void Equals(){} // RVA: 0x7FFE86663200 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866632A0
        public void ToString(){} // RVA: 0x7FFE866ADAE0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866ADB30
        public void CalculateSize(){} // RVA: 0x7FFE866ADB90
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866ADDC0
        public void .cctor(){} // RVA: 0x7FFE866ADE80
    }

    public class FaceBlendshapesGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866ACB60
        public void .cctor(){} // RVA: 0x7FFE866ACBC0
    }

    public class FaceLandmarkerGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceLandmarkerGraphOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions baseOptions_; // 0x20
        public Mediapipe.Tasks.Vision.FaceDetector.Proto.FaceDetectorGraphOptions faceDetectorGraphOptions_; // 0x28
        public Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceLandmarksDetectorGraphOptions faceLandmarksDetectorGraphOptions_; // 0x30
        public float MinTrackingConfidenceDefaultValue; // 0x8
        public float minTrackingConfidence_; // 0x38
        public Mediapipe.Tasks.Vision.FaceGeometry.Proto.FaceGeometryGraphOptions faceGeometryGraphOptions_; // 0x40

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866AEFA0
        public void get_Descriptor(){} // RVA: 0x7FFE866AF000
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866AF0C0
        public void .ctor(){} // RVA: 0x7FFE866AF1B0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866AF5F0
        public void get_BaseOptions(){} // RVA: 0x7FFE811290C0
        public void set_BaseOptions(){} // RVA: 0x7FFE811290D0
        public void get_FaceDetectorGraphOptions(){} // RVA: 0x7FFE81129130
        public void set_FaceDetectorGraphOptions(){} // RVA: 0x7FFE810FCE90
        public void get_FaceLandmarksDetectorGraphOptions(){} // RVA: 0x7FFE8144E200
        public void set_FaceLandmarksDetectorGraphOptions(){} // RVA: 0x7FFE81129890
        public void get_MinTrackingConfidence(){} // RVA: 0x7FFE866AF650
        public void set_MinTrackingConfidence(){} // RVA: 0x7FFE8669D580
        public void get_HasMinTrackingConfidence(){} // RVA: 0x7FFE8659D0B0
        public void ClearMinTrackingConfidence(){} // RVA: 0x7FFE8659D0C0
        public void get_FaceGeometryGraphOptions(){} // RVA: 0x7FFE81178740
        public void set_FaceGeometryGraphOptions(){} // RVA: 0x7FFE81123200
        public void Equals(){} // RVA: 0x7FFE866AF720 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866AF900
        public void ToString(){} // RVA: 0x7FFE866AFA50
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866AFAA0
        public void CalculateSize(){} // RVA: 0x7FFE866AFB90
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866B0080
        public void .cctor(){} // RVA: 0x7FFE866B0240
    }

    public class FaceLandmarkerGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866AE290
        public void .cctor(){} // RVA: 0x7FFE866AE2F0
    }

    public class FaceLandmarksDetectorGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceLandmarksDetectorGraphOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions baseOptions_; // 0x20
        public float MinDetectionConfidenceDefaultValue; // 0x8
        public float minDetectionConfidence_; // 0x28
        public bool SmoothLandmarksDefaultValue; // 0xC
        public bool smoothLandmarks_; // 0x2C
        public Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceBlendshapesGraphOptions faceBlendshapesGraphOptions_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866B1160
        public void get_Descriptor(){} // RVA: 0x7FFE866B11C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866B1280
        public void .ctor(){} // RVA: 0x7FFE866B1370 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866B1560
        public void get_BaseOptions(){} // RVA: 0x7FFE811290C0
        public void set_BaseOptions(){} // RVA: 0x7FFE811290D0
        public void get_MinDetectionConfidence(){} // RVA: 0x7FFE866B15C0
        public void set_MinDetectionConfidence(){} // RVA: 0x7FFE8669F330
        public void get_HasMinDetectionConfidence(){} // RVA: 0x7FFE8659D0B0
        public void ClearMinDetectionConfidence(){} // RVA: 0x7FFE8659D0C0
        public void get_SmoothLandmarks(){} // RVA: 0x7FFE866B1630
        public void set_SmoothLandmarks(){} // RVA: 0x7FFE8669F3B0
        public void get_HasSmoothLandmarks(){} // RVA: 0x7FFE8659D150
        public void ClearSmoothLandmarks(){} // RVA: 0x7FFE8659D160
        public void get_FaceBlendshapesGraphOptions(){} // RVA: 0x7FFE8144E200
        public void set_FaceBlendshapesGraphOptions(){} // RVA: 0x7FFE81129890
        public void Equals(){} // RVA: 0x7FFE866B1700 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866B1880
        public void ToString(){} // RVA: 0x7FFE866B19C0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866B1A10
        public void CalculateSize(){} // RVA: 0x7FFE866B1AE0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866B1F80
        public void .cctor(){} // RVA: 0x7FFE866B20D0
    }

    public class FaceLandmarksDetectorGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866B0670
        public void .cctor(){} // RVA: 0x7FFE866B06D0
    }

}