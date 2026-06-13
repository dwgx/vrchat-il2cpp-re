// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker.Proto
// Classes: 4
// Methods: 54

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker.Proto
{
    public class HandLandmarkerGraphOptions
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.HandLandmarker.Proto.HandLandmarkerGraphOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions baseOptions_; // 0x20
        public Mediapipe.Tasks.Vision.HandDetector.Proto.HandDetectorGraphOptions handDetectorGraphOptions_; // 0x28
        public Mediapipe.Tasks.Vision.HandLandmarker.Proto.HandLandmarksDetectorGraphOptions handLandmarksDetectorGraphOptions_; // 0x30
        public float MinTrackingConfidenceDefaultValue; // 0x8
        public float minTrackingConfidence_; // 0x38

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B64270
        public void get_Descriptor(){} // RVA: 0x5B642D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B64390
        public void .ctor(){} // RVA: 0x5B64480 | overloaded x2
        public void Clone(){} // RVA: 0x5B646D0
        public void get_BaseOptions(){} // RVA: 0x30B0C0
        public void set_BaseOptions(){} // RVA: 0x30B0D0
        public void get_HandDetectorGraphOptions(){} // RVA: 0x30B130
        public void set_HandDetectorGraphOptions(){} // RVA: 0x2DEE90
        public void get_HandLandmarksDetectorGraphOptions(){} // RVA: 0x6374D0
        public void set_HandLandmarksDetectorGraphOptions(){} // RVA: 0x30B890
        public void get_MinTrackingConfidence(){} // RVA: 0x5B64730
        public void set_MinTrackingConfidence(){} // RVA: 0x5B5C750
        public void get_HasMinTrackingConfidence(){} // RVA: 0x5A5C3B0
        public void ClearMinTrackingConfidence(){} // RVA: 0x5A5C3C0
        public void Equals(){} // RVA: 0x5B64800 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B649B0
        public void ToString(){} // RVA: 0x5B64AE0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B64B30
        public void CalculateSize(){} // RVA: 0x5B64C00
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B65170
        public void .cctor(){} // RVA: 0x5B652E0
    }

    public class HandLandmarkerGraphOptionsReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B63690
        public void .cctor(){} // RVA: 0x5B636F0
    }

    public class HandLandmarksDetectorGraphOptions
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.HandLandmarker.Proto.HandLandmarksDetectorGraphOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions baseOptions_; // 0x20
        public float MinDetectionConfidenceDefaultValue; // 0x8
        public float minDetectionConfidence_; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B66080
        public void get_Descriptor(){} // RVA: 0x5B660E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B661A0
        public void .ctor(){} // RVA: 0x5B66290 | overloaded x2
        public void Clone(){} // RVA: 0x5B66420
        public void get_BaseOptions(){} // RVA: 0x30B0C0
        public void set_BaseOptions(){} // RVA: 0x30B0D0
        public void get_MinDetectionConfidence(){} // RVA: 0x5B665F0
        public void set_MinDetectionConfidence(){} // RVA: 0x5B5E500
        public void get_HasMinDetectionConfidence(){} // RVA: 0x5A5C3B0
        public void ClearMinDetectionConfidence(){} // RVA: 0x5A5C3C0
        public void Equals(){} // RVA: 0x5B667D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B66900
        public void ToString(){} // RVA: 0x5B669F0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B66A40
        public void CalculateSize(){} // RVA: 0x5B66AC0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B66D10
        public void .cctor(){} // RVA: 0x5B66DF0
    }

    public class HandLandmarksDetectorGraphOptionsReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B65710
        public void .cctor(){} // RVA: 0x5B65770
    }

}