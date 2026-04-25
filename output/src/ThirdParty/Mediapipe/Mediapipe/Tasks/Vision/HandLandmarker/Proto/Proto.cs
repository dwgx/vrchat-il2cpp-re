// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker.Proto
// Classes: 4
// Methods: 54

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker.Proto
{
    public class HandLandmarkerGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.HandLandmarker.Proto.HandLandmarkerGraphOptions> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions BaseOptions; // 0x20
        public Mediapipe.Tasks.Vision.HandDetector.Proto.HandDetectorGraphOptions HandDetectorGraphOptions; // 0x28
        public Mediapipe.Tasks.Vision.HandLandmarker.Proto.HandLandmarksDetectorGraphOptions HandLandmarksDetectorGraphOptions; // 0x30
        public float MinTrackingConfidence; // 0x8
        public float HasMinTrackingConfidence; // 0x38

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82FB7A0
        public void get_Descriptor(){} // RVA: 0x7FFAC82FB800
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82FB8C0
        public void .ctor(){} // RVA: 0x7FFAC82FB9B0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82FBC00
        public void get_BaseOptions(){} // RVA: 0x7FFAC2F4F0C0
        public void set_BaseOptions(){} // RVA: 0x7FFAC2F4F0D0
        public void get_HandDetectorGraphOptions(){} // RVA: 0x7FFAC2F4F130
        public void set_HandDetectorGraphOptions(){} // RVA: 0x7FFAC2F22E90
        public void get_HandLandmarksDetectorGraphOptions(){} // RVA: 0x7FFAC31D95E0
        public void set_HandLandmarksDetectorGraphOptions(){} // RVA: 0x7FFAC2F4F890
        public void get_MinTrackingConfidence(){} // RVA: 0x7FFAC82FBC60
        public void set_MinTrackingConfidence(){} // RVA: 0x7FFAC82F3C80
        public void get_HasMinTrackingConfidence(){} // RVA: 0x7FFAC81F3770
        public void ClearMinTrackingConfidence(){} // RVA: 0x7FFAC81F3780
        public void Equals(){} // RVA: 0x7FFAC82FBD30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82FBEE0
        public void ToString(){} // RVA: 0x7FFAC82FC010
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82FC060
        public void CalculateSize(){} // RVA: 0x7FFAC82FC130
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82FC6A0
        public void .cctor(){} // RVA: 0x7FFAC82FC810
    }

    public class HandLandmarkerGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82FABC0
        public void .cctor(){} // RVA: 0x7FFAC82FAC20
    }

    public class HandLandmarksDetectorGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.HandLandmarker.Proto.HandLandmarksDetectorGraphOptions> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions BaseOptions; // 0x20
        public float MinDetectionConfidence; // 0x8
        public float HasMinDetectionConfidence; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82FD5B0
        public void get_Descriptor(){} // RVA: 0x7FFAC82FD610
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82FD6D0
        public void .ctor(){} // RVA: 0x7FFAC82FD7C0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82FD950
        public void get_BaseOptions(){} // RVA: 0x7FFAC2F4F0C0
        public void set_BaseOptions(){} // RVA: 0x7FFAC2F4F0D0
        public void get_MinDetectionConfidence(){} // RVA: 0x7FFAC82FDB20
        public void set_MinDetectionConfidence(){} // RVA: 0x7FFAC82F5A30
        public void get_HasMinDetectionConfidence(){} // RVA: 0x7FFAC81F3770
        public void ClearMinDetectionConfidence(){} // RVA: 0x7FFAC81F3780
        public void Equals(){} // RVA: 0x7FFAC82FDD00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82FDE30
        public void ToString(){} // RVA: 0x7FFAC82FDF20
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82FDF70
        public void CalculateSize(){} // RVA: 0x7FFAC82FDFF0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82FE240
        public void .cctor(){} // RVA: 0x7FFAC82FE320
    }

    public class HandLandmarksDetectorGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82FCC40
        public void .cctor(){} // RVA: 0x7FFAC82FCCA0
    }

}