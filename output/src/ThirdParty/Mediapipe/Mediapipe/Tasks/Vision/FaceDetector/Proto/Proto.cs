// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector.Proto
// Classes: 2
// Methods: 33

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector.Proto
{
    public class FaceDetectorGraphOptions
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Tasks.Vision.FaceDetector.Proto.FaceDetectorGraphOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public Mediapipe.Tasks.Core.Proto.BaseOptions baseOptions_; // 0x20
        public float MinDetectionConfidenceDefaultValue; // 0x8
        public float minDetectionConfidence_; // 0x28
        public float MinSuppressionThresholdDefaultValue; // 0xC
        public float minSuppressionThreshold_; // 0x2C
        public int NumFacesDefaultValue; // 0x10
        public int numFaces_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B7A020
        public void get_Descriptor(){} // RVA: 0x5B7A080
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B7A140
        public void .ctor(){} // RVA: 0x5B5FE10 | overloaded x2
        public void Clone(){} // RVA: 0x5B7A230
        public void get_BaseOptions(){} // RVA: 0x30B0C0
        public void set_BaseOptions(){} // RVA: 0x30B0D0
        public void get_MinDetectionConfidence(){} // RVA: 0x5B7A400
        public void set_MinDetectionConfidence(){} // RVA: 0x5B5E500
        public void get_HasMinDetectionConfidence(){} // RVA: 0x5A5C3B0
        public void ClearMinDetectionConfidence(){} // RVA: 0x5A5C3C0
        public void get_MinSuppressionThreshold(){} // RVA: 0x5B7A470
        public void set_MinSuppressionThreshold(){} // RVA: 0x5B60250
        public void get_HasMinSuppressionThreshold(){} // RVA: 0x5A5C450
        public void ClearMinSuppressionThreshold(){} // RVA: 0x5A5C460
        public void get_NumFaces(){} // RVA: 0x5B7A4E0
        public void set_NumFaces(){} // RVA: 0x5A5F640
        public void get_HasNumFaces(){} // RVA: 0x5A5F650
        public void ClearNumFaces(){} // RVA: 0x5A5F660
        public void Equals(){} // RVA: 0x5B7A5B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B7A760
        public void ToString(){} // RVA: 0x5B7A8B0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B7A900
        public void CalculateSize(){} // RVA: 0x5B7A9E0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B7ACA0
        public void .cctor(){} // RVA: 0x5B7ADD0
    }

    public class FaceDetectorGraphOptionsReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B79660
        public void .cctor(){} // RVA: 0x5B796C0
    }

}