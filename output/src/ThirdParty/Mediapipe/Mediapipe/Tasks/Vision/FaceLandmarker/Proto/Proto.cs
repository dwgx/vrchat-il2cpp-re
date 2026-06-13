// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker.Proto
// Classes: 6
// Methods: 83

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker.Proto
{
    public class FaceBlendshapesGraphOptions
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceBlendshapesGraphOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Mediapipe.Tasks.Core.Proto.BaseOptions baseOptions_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B6C630
        public void get_Descriptor(){} // RVA: 0x5B6C690
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B6C750
        public void .ctor(){} // RVA: 0x5B6C840 | overloaded x2
        public void Clone(){} // RVA: 0x5B6C9E0
        public void get_BaseOptions(){} // RVA: 0x2E07C0
        public void set_BaseOptions(){} // RVA: 0x343E80
        public void Equals(){} // RVA: 0x5B223D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B22470
        public void ToString(){} // RVA: 0x5B6CCB0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B6CD00
        public void CalculateSize(){} // RVA: 0x5B6CD60
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B6CF90
        public void .cctor(){} // RVA: 0x5B6D050
    }

    public class FaceBlendshapesGraphOptionsReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B6BD30
        public void .cctor(){} // RVA: 0x5B6BD90
    }

    public class FaceLandmarkerGraphOptions
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
        public void get_Parser(){} // RVA: 0x5B6E170
        public void get_Descriptor(){} // RVA: 0x5B6E1D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B6E290
        public void .ctor(){} // RVA: 0x5B6E380 | overloaded x2
        public void Clone(){} // RVA: 0x5B6E7C0
        public void get_BaseOptions(){} // RVA: 0x30B0C0
        public void set_BaseOptions(){} // RVA: 0x30B0D0
        public void get_FaceDetectorGraphOptions(){} // RVA: 0x30B130
        public void set_FaceDetectorGraphOptions(){} // RVA: 0x2DEE90
        public void get_FaceLandmarksDetectorGraphOptions(){} // RVA: 0x6374D0
        public void set_FaceLandmarksDetectorGraphOptions(){} // RVA: 0x30B890
        public void get_MinTrackingConfidence(){} // RVA: 0x5B6E820
        public void set_MinTrackingConfidence(){} // RVA: 0x5B5C750
        public void get_HasMinTrackingConfidence(){} // RVA: 0x5A5C3B0
        public void ClearMinTrackingConfidence(){} // RVA: 0x5A5C3C0
        public void get_FaceGeometryGraphOptions(){} // RVA: 0x35A740
        public void set_FaceGeometryGraphOptions(){} // RVA: 0x305200
        public void Equals(){} // RVA: 0x5B6E8F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B6EAD0
        public void ToString(){} // RVA: 0x5B6EC20
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B6EC70
        public void CalculateSize(){} // RVA: 0x5B6ED60
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B6F250
        public void .cctor(){} // RVA: 0x5B6F410
    }

    public class FaceLandmarkerGraphOptionsReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B6D460
        public void .cctor(){} // RVA: 0x5B6D4C0
    }

    public class FaceLandmarksDetectorGraphOptions
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
        public void get_Parser(){} // RVA: 0x5B70330
        public void get_Descriptor(){} // RVA: 0x5B70390
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B70450
        public void .ctor(){} // RVA: 0x5B70540 | overloaded x2
        public void Clone(){} // RVA: 0x5B70730
        public void get_BaseOptions(){} // RVA: 0x30B0C0
        public void set_BaseOptions(){} // RVA: 0x30B0D0
        public void get_MinDetectionConfidence(){} // RVA: 0x5B70790
        public void set_MinDetectionConfidence(){} // RVA: 0x5B5E500
        public void get_HasMinDetectionConfidence(){} // RVA: 0x5A5C3B0
        public void ClearMinDetectionConfidence(){} // RVA: 0x5A5C3C0
        public void get_SmoothLandmarks(){} // RVA: 0x5B70800
        public void set_SmoothLandmarks(){} // RVA: 0x5B5E580
        public void get_HasSmoothLandmarks(){} // RVA: 0x5A5C450
        public void ClearSmoothLandmarks(){} // RVA: 0x5A5C460
        public void get_FaceBlendshapesGraphOptions(){} // RVA: 0x6374D0
        public void set_FaceBlendshapesGraphOptions(){} // RVA: 0x30B890
        public void Equals(){} // RVA: 0x5B708D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B70A50
        public void ToString(){} // RVA: 0x5B70B90
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B70BE0
        public void CalculateSize(){} // RVA: 0x5B70CB0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B71150
        public void .cctor(){} // RVA: 0x5B712A0
    }

    public class FaceLandmarksDetectorGraphOptionsReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B6F840
        public void .cctor(){} // RVA: 0x5B6F8A0
    }

}