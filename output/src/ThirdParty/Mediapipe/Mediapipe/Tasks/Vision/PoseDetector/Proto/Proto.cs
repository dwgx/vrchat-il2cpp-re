// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseDetector.Proto
// Classes: 2
// Methods: 33

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseDetector.Proto
{
    public class PoseDetectorGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.PoseDetector.Proto.PoseDetectorGraphOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions baseOptions_; // 0x20
        public float MinDetectionConfidenceDefaultValue; // 0x8
        public float minDetectionConfidence_; // 0x28
        public float MinSuppressionThresholdDefaultValue; // 0xC
        public float minSuppressionThreshold_; // 0x2C
        public int NumPosesDefaultValue; // 0x10
        public int numPoses_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866A0A30
        public void get_Descriptor(){} // RVA: 0x7FFE866A0A90
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866A0B50
        public void .ctor(){} // RVA: 0x7FFE866A0C40 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866A0DD0
        public void get_BaseOptions(){} // RVA: 0x7FFE811290C0
        public void set_BaseOptions(){} // RVA: 0x7FFE811290D0
        public void get_MinDetectionConfidence(){} // RVA: 0x7FFE866A0FA0
        public void set_MinDetectionConfidence(){} // RVA: 0x7FFE8669F330
        public void get_HasMinDetectionConfidence(){} // RVA: 0x7FFE8659D0B0
        public void ClearMinDetectionConfidence(){} // RVA: 0x7FFE8659D0C0
        public void get_MinSuppressionThreshold(){} // RVA: 0x7FFE866A1010
        public void set_MinSuppressionThreshold(){} // RVA: 0x7FFE866A1080
        public void get_HasMinSuppressionThreshold(){} // RVA: 0x7FFE8659D150
        public void ClearMinSuppressionThreshold(){} // RVA: 0x7FFE8659D160
        public void get_NumPoses(){} // RVA: 0x7FFE866A1090
        public void set_NumPoses(){} // RVA: 0x7FFE865A0340
        public void get_HasNumPoses(){} // RVA: 0x7FFE865A0350
        public void ClearNumPoses(){} // RVA: 0x7FFE865A0360
        public void Equals(){} // RVA: 0x7FFE866A1160 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866A1310
        public void ToString(){} // RVA: 0x7FFE866A1460
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866A14B0
        public void CalculateSize(){} // RVA: 0x7FFE866A1590
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866A1850
        public void .cctor(){} // RVA: 0x7FFE866A1980
    }

    public class PoseDetectorGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866A0070
        public void .cctor(){} // RVA: 0x7FFE866A00D0
    }

}