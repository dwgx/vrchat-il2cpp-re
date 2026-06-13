// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandDetector.Proto
// Classes: 2
// Methods: 29

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandDetector.Proto
{
    public class HandDetectorGraphOptions
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
        public void get_Parser(){} // RVA: 0x5B67B90
        public void get_Descriptor(){} // RVA: 0x5B67BF0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B67CB0
        public void .ctor(){} // RVA: 0x5B67DA0 | overloaded x2
        public void Clone(){} // RVA: 0x5B67F30
        public void get_BaseOptions(){} // RVA: 0x30B0C0
        public void set_BaseOptions(){} // RVA: 0x30B0D0
        public void get_MinDetectionConfidence(){} // RVA: 0x5B68100
        public void set_MinDetectionConfidence(){} // RVA: 0x5B5E500
        public void get_HasMinDetectionConfidence(){} // RVA: 0x5A5C3B0
        public void ClearMinDetectionConfidence(){} // RVA: 0x5A5C3C0
        public void get_NumHands(){} // RVA: 0x5B68170
        public void set_NumHands(){} // RVA: 0x5A5F5C0
        public void get_HasNumHands(){} // RVA: 0x5A5C450
        public void ClearNumHands(){} // RVA: 0x5A5C460
        public void Equals(){} // RVA: 0x5B68370 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B684C0
        public void ToString(){} // RVA: 0x5B685C0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B68610
        public void CalculateSize(){} // RVA: 0x5B686C0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B68960
        public void .cctor(){} // RVA: 0x5B68A60
    }

    public class HandDetectorGraphOptionsReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B67220
        public void .cctor(){} // RVA: 0x5B67280
    }

}