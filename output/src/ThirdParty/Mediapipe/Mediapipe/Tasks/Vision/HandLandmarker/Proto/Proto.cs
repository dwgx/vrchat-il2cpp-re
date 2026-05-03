// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker.Proto
// Classes: 4
// Methods: 54

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker.Proto
{
    public class HandLandmarkerGraphOptions : Object
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
        public void get_Parser(){} // RVA: 0x7FFE866A50A0
        public void get_Descriptor(){} // RVA: 0x7FFE866A5100
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866A51C0
        public void .ctor(){} // RVA: 0x7FFE866A52B0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866A5500
        public void get_BaseOptions(){} // RVA: 0x7FFE811290C0
        public void set_BaseOptions(){} // RVA: 0x7FFE811290D0
        public void get_HandDetectorGraphOptions(){} // RVA: 0x7FFE81129130
        public void set_HandDetectorGraphOptions(){} // RVA: 0x7FFE810FCE90
        public void get_HandLandmarksDetectorGraphOptions(){} // RVA: 0x7FFE8144E200
        public void set_HandLandmarksDetectorGraphOptions(){} // RVA: 0x7FFE81129890
        public void get_MinTrackingConfidence(){} // RVA: 0x7FFE866A5560
        public void set_MinTrackingConfidence(){} // RVA: 0x7FFE8669D580
        public void get_HasMinTrackingConfidence(){} // RVA: 0x7FFE8659D0B0
        public void ClearMinTrackingConfidence(){} // RVA: 0x7FFE8659D0C0
        public void Equals(){} // RVA: 0x7FFE866A5630 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866A57E0
        public void ToString(){} // RVA: 0x7FFE866A5910
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866A5960
        public void CalculateSize(){} // RVA: 0x7FFE866A5A30
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866A5FA0
        public void .cctor(){} // RVA: 0x7FFE866A6110
    }

    public class HandLandmarkerGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866A44C0
        public void .cctor(){} // RVA: 0x7FFE866A4520
    }

    public class HandLandmarksDetectorGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.HandLandmarker.Proto.HandLandmarksDetectorGraphOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions baseOptions_; // 0x20
        public float MinDetectionConfidenceDefaultValue; // 0x8
        public float minDetectionConfidence_; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866A6EB0
        public void get_Descriptor(){} // RVA: 0x7FFE866A6F10
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866A6FD0
        public void .ctor(){} // RVA: 0x7FFE866A70C0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866A7250
        public void get_BaseOptions(){} // RVA: 0x7FFE811290C0
        public void set_BaseOptions(){} // RVA: 0x7FFE811290D0
        public void get_MinDetectionConfidence(){} // RVA: 0x7FFE866A7420
        public void set_MinDetectionConfidence(){} // RVA: 0x7FFE8669F330
        public void get_HasMinDetectionConfidence(){} // RVA: 0x7FFE8659D0B0
        public void ClearMinDetectionConfidence(){} // RVA: 0x7FFE8659D0C0
        public void Equals(){} // RVA: 0x7FFE866A7600 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866A7730
        public void ToString(){} // RVA: 0x7FFE866A7820
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866A7870
        public void CalculateSize(){} // RVA: 0x7FFE866A78F0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866A7B40
        public void .cctor(){} // RVA: 0x7FFE866A7C20
    }

    public class HandLandmarksDetectorGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866A6540
        public void .cctor(){} // RVA: 0x7FFE866A65A0
    }

}