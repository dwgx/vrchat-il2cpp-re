// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker.Proto
// Classes: 4
// Methods: 58

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker.Proto
{
    public class PoseLandmarkerGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.PoseLandmarker.Proto.PoseLandmarkerGraphOptions> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions BaseOptions; // 0x20
        public Mediapipe.Tasks.Vision.PoseDetector.Proto.PoseDetectorGraphOptions PoseDetectorGraphOptions; // 0x28
        public Mediapipe.Tasks.Vision.PoseLandmarker.Proto.PoseLandmarksDetectorGraphOptions PoseLandmarksDetectorGraphOptions; // 0x30
        public float MinTrackingConfidence; // 0x8
        public float HasMinTrackingConfidence; // 0x38

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82F3750
        public void get_Descriptor(){} // RVA: 0x7FFAC82F37B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82F3870
        public void .ctor(){} // RVA: 0x7FFAC82F3960 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82F3BB0
        public void get_BaseOptions(){} // RVA: 0x7FFAC2F4F0C0
        public void set_BaseOptions(){} // RVA: 0x7FFAC2F4F0D0
        public void get_PoseDetectorGraphOptions(){} // RVA: 0x7FFAC2F4F130
        public void set_PoseDetectorGraphOptions(){} // RVA: 0x7FFAC2F22E90
        public void get_PoseLandmarksDetectorGraphOptions(){} // RVA: 0x7FFAC31D95E0
        public void set_PoseLandmarksDetectorGraphOptions(){} // RVA: 0x7FFAC2F4F890
        public void get_MinTrackingConfidence(){} // RVA: 0x7FFAC82F3C10
        public void set_MinTrackingConfidence(){} // RVA: 0x7FFAC82F3C80
        public void get_HasMinTrackingConfidence(){} // RVA: 0x7FFAC81F3770
        public void ClearMinTrackingConfidence(){} // RVA: 0x7FFAC81F3780
        public void Equals(){} // RVA: 0x7FFAC82F3CF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82F3EA0
        public void ToString(){} // RVA: 0x7FFAC82F3FD0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82F4020
        public void CalculateSize(){} // RVA: 0x7FFAC82F40F0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82F4510
        public void .cctor(){} // RVA: 0x7FFAC82F4680
    }

    public class PoseLandmarkerGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82F2B70
        public void .cctor(){} // RVA: 0x7FFAC82F2BD0
    }

    public class PoseLandmarksDetectorGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.PoseLandmarker.Proto.PoseLandmarksDetectorGraphOptions> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions BaseOptions; // 0x20
        public float MinDetectionConfidence; // 0x8
        public float HasMinDetectionConfidence; // 0x28
        public bool SmoothLandmarks; // 0xC
        public bool HasSmoothLandmarks; // 0x2C

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82F5450
        public void get_Descriptor(){} // RVA: 0x7FFAC82F54B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82F5570
        public void .ctor(){} // RVA: 0x7FFAC82F5660 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82F57F0
        public void get_BaseOptions(){} // RVA: 0x7FFAC2F4F0C0
        public void set_BaseOptions(){} // RVA: 0x7FFAC2F4F0D0
        public void get_MinDetectionConfidence(){} // RVA: 0x7FFAC82F59C0
        public void set_MinDetectionConfidence(){} // RVA: 0x7FFAC82F5A30
        public void get_HasMinDetectionConfidence(){} // RVA: 0x7FFAC81F3770
        public void ClearMinDetectionConfidence(){} // RVA: 0x7FFAC81F3780
        public void get_SmoothLandmarks(){} // RVA: 0x7FFAC82F5A40
        public void set_SmoothLandmarks(){} // RVA: 0x7FFAC82F5AB0
        public void get_HasSmoothLandmarks(){} // RVA: 0x7FFAC81F3810
        public void ClearSmoothLandmarks(){} // RVA: 0x7FFAC81F3820
        public void Equals(){} // RVA: 0x7FFAC82F5C50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82F5DA0
        public void ToString(){} // RVA: 0x7FFAC82F5EC0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82F5F10
        public void CalculateSize(){} // RVA: 0x7FFAC82F5FC0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82F6230
        public void .cctor(){} // RVA: 0x7FFAC82F6330
    }

    public class PoseLandmarksDetectorGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82F4AB0
        public void .cctor(){} // RVA: 0x7FFAC82F4B10
    }

}