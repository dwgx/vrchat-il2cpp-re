// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker.Proto
// Classes: 3
// Methods: 77

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker.Proto
{
    public class FaceBlendshapesGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceBlendshapesGraphOptions> Parser;
        public 0x6658E800 Descriptor; // 0x10
        public Mediapipe.Tasks.Core.Proto.BaseOptions pb::Google.Protobuf.IMessage.Descriptor; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFD53723B60
        public void get_Descriptor(){} // RVA: 0x7FFD53723BC0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD53723C80
        public void .ctor(){} // RVA: 0x7FFD53723D70 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD53723F10
        public void get_BaseOptions(){} // RVA: 0x7FFD4E3447C0
        public void set_BaseOptions(){} // RVA: 0x7FFD4E3A7E80
        public void Equals(){} // RVA: 0x7FFD536D98E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD536D9980
        public void ToString(){} // RVA: 0x7FFD537241E0
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD53724230
        public void CalculateSize(){} // RVA: 0x7FFD53724290
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD537244C0
        public void .cctor(){} // RVA: 0x7FFD53724580
    }

    public class FaceLandmarkerGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceLandmarkerGraphOptions> Parser;
        public 0x6658E800 Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions BaseOptions; // 0x20
        public Mediapipe.Tasks.Vision.FaceDetector.Proto.FaceDetectorGraphOptions FaceDetectorGraphOptions; // 0x28
        public Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceLandmarksDetectorGraphOptions FaceLandmarksDetectorGraphOptions; // 0x30
        public float MinTrackingConfidence; // 0x8
        public float HasMinTrackingConfidence; // 0x38
        public Mediapipe.Tasks.Vision.FaceGeometry.Proto.FaceGeometryGraphOptions FaceGeometryGraphOptions; // 0x40

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFD537256A0
        public void get_Descriptor(){} // RVA: 0x7FFD53725700
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD537257C0
        public void .ctor(){} // RVA: 0x7FFD537258B0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD53725CF0
        public void get_BaseOptions(){} // RVA: 0x7FFD4E36F0C0
        public void set_BaseOptions(){} // RVA: 0x7FFD4E36F0D0
        public void get_FaceDetectorGraphOptions(){} // RVA: 0x7FFD4E36F130
        public void set_FaceDetectorGraphOptions(){} // RVA: 0x7FFD4E342E90
        public void get_FaceLandmarksDetectorGraphOptions(){} // RVA: 0x7FFD4E5F95E0
        public void set_FaceLandmarksDetectorGraphOptions(){} // RVA: 0x7FFD4E36F890
        public void get_MinTrackingConfidence(){} // RVA: 0x7FFD53725D50
        public void set_MinTrackingConfidence(){} // RVA: 0x7FFD53713C80
        public void get_HasMinTrackingConfidence(){} // RVA: 0x7FFD53613770
        public void ClearMinTrackingConfidence(){} // RVA: 0x7FFD53613780
        public void get_FaceGeometryGraphOptions(){} // RVA: 0x7FFD4E3BE740
        public void set_FaceGeometryGraphOptions(){} // RVA: 0x7FFD4E369200
        public void Equals(){} // RVA: 0x7FFD53725E20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53726000
        public void ToString(){} // RVA: 0x7FFD53726150
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD537261A0
        public void CalculateSize(){} // RVA: 0x7FFD53726290
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD53726780
        public void .cctor(){} // RVA: 0x7FFD53726940
    }

    public class FaceLandmarksDetectorGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceLandmarksDetectorGraphOptions> Parser;
        public 0x6658E800 Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions BaseOptions; // 0x20
        public float MinDetectionConfidence; // 0x8
        public float HasMinDetectionConfidence; // 0x28
        public bool SmoothLandmarks; // 0xC
        public bool HasSmoothLandmarks; // 0x2C
        public Mediapipe.Tasks.Vision.FaceLandmarker.Proto.FaceBlendshapesGraphOptions FaceBlendshapesGraphOptions; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFD53727860
        public void get_Descriptor(){} // RVA: 0x7FFD537278C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD53727980
        public void .ctor(){} // RVA: 0x7FFD53727A70 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD53727C60
        public void get_BaseOptions(){} // RVA: 0x7FFD4E36F0C0
        public void set_BaseOptions(){} // RVA: 0x7FFD4E36F0D0
        public void get_MinDetectionConfidence(){} // RVA: 0x7FFD53727CC0
        public void set_MinDetectionConfidence(){} // RVA: 0x7FFD53715A30
        public void get_HasMinDetectionConfidence(){} // RVA: 0x7FFD53613770
        public void ClearMinDetectionConfidence(){} // RVA: 0x7FFD53613780
        public void get_SmoothLandmarks(){} // RVA: 0x7FFD53727D30
        public void set_SmoothLandmarks(){} // RVA: 0x7FFD53715AB0
        public void get_HasSmoothLandmarks(){} // RVA: 0x7FFD53613810
        public void ClearSmoothLandmarks(){} // RVA: 0x7FFD53613820
        public void get_FaceBlendshapesGraphOptions(){} // RVA: 0x7FFD4E5F95E0
        public void set_FaceBlendshapesGraphOptions(){} // RVA: 0x7FFD4E36F890
        public void Equals(){} // RVA: 0x7FFD53727E00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53727F80
        public void ToString(){} // RVA: 0x7FFD537280C0
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD53728110
        public void CalculateSize(){} // RVA: 0x7FFD537281E0
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD53728680
        public void .cctor(){} // RVA: 0x7FFD537287D0
    }

}