// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker.Proto
// Classes: 4
// Methods: 58

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker.Proto
{
    public class PoseLandmarkerGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.PoseLandmarker.Proto.PoseLandmarkerGraphOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions baseOptions_; // 0x20
        public Mediapipe.Tasks.Vision.PoseDetector.Proto.PoseDetectorGraphOptions poseDetectorGraphOptions_; // 0x28
        public Mediapipe.Tasks.Vision.PoseLandmarker.Proto.PoseLandmarksDetectorGraphOptions poseLandmarksDetectorGraphOptions_; // 0x30
        public float MinTrackingConfidenceDefaultValue; // 0x8
        public float minTrackingConfidence_; // 0x38

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8669D050
        public void get_Descriptor(){} // RVA: 0x7FFE8669D0B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8669D170
        public void .ctor(){} // RVA: 0x7FFE8669D260 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8669D4B0
        public void get_BaseOptions(){} // RVA: 0x7FFE811290C0
        public void set_BaseOptions(){} // RVA: 0x7FFE811290D0
        public void get_PoseDetectorGraphOptions(){} // RVA: 0x7FFE81129130
        public void set_PoseDetectorGraphOptions(){} // RVA: 0x7FFE810FCE90
        public void get_PoseLandmarksDetectorGraphOptions(){} // RVA: 0x7FFE8144E200
        public void set_PoseLandmarksDetectorGraphOptions(){} // RVA: 0x7FFE81129890
        public void get_MinTrackingConfidence(){} // RVA: 0x7FFE8669D510
        public void set_MinTrackingConfidence(){} // RVA: 0x7FFE8669D580
        public void get_HasMinTrackingConfidence(){} // RVA: 0x7FFE8659D0B0
        public void ClearMinTrackingConfidence(){} // RVA: 0x7FFE8659D0C0
        public void Equals(){} // RVA: 0x7FFE8669D5F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8669D7A0
        public void ToString(){} // RVA: 0x7FFE8669D8D0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8669D920
        public void CalculateSize(){} // RVA: 0x7FFE8669D9F0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8669DE10
        public void .cctor(){} // RVA: 0x7FFE8669DF80
    }

    public class PoseLandmarkerGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE8669C470
        public void .cctor(){} // RVA: 0x7FFE8669C4D0
    }

    public class PoseLandmarksDetectorGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.PoseLandmarker.Proto.PoseLandmarksDetectorGraphOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions baseOptions_; // 0x20
        public float MinDetectionConfidenceDefaultValue; // 0x8
        public float minDetectionConfidence_; // 0x28
        public bool SmoothLandmarksDefaultValue; // 0xC
        public bool smoothLandmarks_; // 0x2C

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8669ED50
        public void get_Descriptor(){} // RVA: 0x7FFE8669EDB0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8669EE70
        public void .ctor(){} // RVA: 0x7FFE8669EF60 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8669F0F0
        public void get_BaseOptions(){} // RVA: 0x7FFE811290C0
        public void set_BaseOptions(){} // RVA: 0x7FFE811290D0
        public void get_MinDetectionConfidence(){} // RVA: 0x7FFE8669F2C0
        public void set_MinDetectionConfidence(){} // RVA: 0x7FFE8669F330
        public void get_HasMinDetectionConfidence(){} // RVA: 0x7FFE8659D0B0
        public void ClearMinDetectionConfidence(){} // RVA: 0x7FFE8659D0C0
        public void get_SmoothLandmarks(){} // RVA: 0x7FFE8669F340
        public void set_SmoothLandmarks(){} // RVA: 0x7FFE8669F3B0
        public void get_HasSmoothLandmarks(){} // RVA: 0x7FFE8659D150
        public void ClearSmoothLandmarks(){} // RVA: 0x7FFE8659D160
        public void Equals(){} // RVA: 0x7FFE8669F550 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8669F6A0
        public void ToString(){} // RVA: 0x7FFE8669F7C0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8669F810
        public void CalculateSize(){} // RVA: 0x7FFE8669F8C0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8669FB30
        public void .cctor(){} // RVA: 0x7FFE8669FC30
    }

    public class PoseLandmarksDetectorGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE8669E3B0
        public void .cctor(){} // RVA: 0x7FFE8669E410
    }

}