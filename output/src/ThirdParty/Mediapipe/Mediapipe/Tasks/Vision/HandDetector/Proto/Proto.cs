// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandDetector.Proto
// Classes: 2
// Methods: 29

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandDetector.Proto
{
    public class HandDetectorGraphOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.HandDetector.Proto.HandDetectorGraphOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions baseOptions_; // 0x20
        public float MinDetectionConfidenceDefaultValue; // 0x8
        public float minDetectionConfidence_; // 0x28
        public int NumHandsDefaultValue; // 0xC
        public int numHands_; // 0x2C

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866A89C0
        public void get_Descriptor(){} // RVA: 0x7FFE866A8A20
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866A8AE0
        public void .ctor(){} // RVA: 0x7FFE866A8BD0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866A8D60
        public void get_BaseOptions(){} // RVA: 0x7FFE811290C0
        public void set_BaseOptions(){} // RVA: 0x7FFE811290D0
        public void get_MinDetectionConfidence(){} // RVA: 0x7FFE866A8F30
        public void set_MinDetectionConfidence(){} // RVA: 0x7FFE8669F330
        public void get_HasMinDetectionConfidence(){} // RVA: 0x7FFE8659D0B0
        public void ClearMinDetectionConfidence(){} // RVA: 0x7FFE8659D0C0
        public void get_NumHands(){} // RVA: 0x7FFE866A8FA0
        public void set_NumHands(){} // RVA: 0x7FFE865A02C0
        public void get_HasNumHands(){} // RVA: 0x7FFE8659D150
        public void ClearNumHands(){} // RVA: 0x7FFE8659D160
        public void Equals(){} // RVA: 0x7FFE866A91A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866A92F0
        public void ToString(){} // RVA: 0x7FFE866A93F0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866A9440
        public void CalculateSize(){} // RVA: 0x7FFE866A94F0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866A9790
        public void .cctor(){} // RVA: 0x7FFE866A9890
    }

    public class HandDetectorGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866A8050
        public void .cctor(){} // RVA: 0x7FFE866A80B0
    }

}