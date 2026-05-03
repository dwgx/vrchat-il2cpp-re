// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector.Proto
// Classes: 2
// Methods: 33

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector.Proto
{
    public class FaceDetectorGraphOptions : Object
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
        public void get_Parser(){} // RVA: 0x7FFE866BAE50
        public void get_Descriptor(){} // RVA: 0x7FFE866BAEB0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866BAF70
        public void .ctor(){} // RVA: 0x7FFE866A0C40 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866BB060
        public void get_BaseOptions(){} // RVA: 0x7FFE811290C0
        public void set_BaseOptions(){} // RVA: 0x7FFE811290D0
        public void get_MinDetectionConfidence(){} // RVA: 0x7FFE866BB230
        public void set_MinDetectionConfidence(){} // RVA: 0x7FFE8669F330
        public void get_HasMinDetectionConfidence(){} // RVA: 0x7FFE8659D0B0
        public void ClearMinDetectionConfidence(){} // RVA: 0x7FFE8659D0C0
        public void get_MinSuppressionThreshold(){} // RVA: 0x7FFE866BB2A0
        public void set_MinSuppressionThreshold(){} // RVA: 0x7FFE866A1080
        public void get_HasMinSuppressionThreshold(){} // RVA: 0x7FFE8659D150
        public void ClearMinSuppressionThreshold(){} // RVA: 0x7FFE8659D160
        public void get_NumFaces(){} // RVA: 0x7FFE866BB310
        public void set_NumFaces(){} // RVA: 0x7FFE865A0340
        public void get_HasNumFaces(){} // RVA: 0x7FFE865A0350
        public void ClearNumFaces(){} // RVA: 0x7FFE865A0360
        public void Equals(){} // RVA: 0x7FFE866BB3E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866BB590
        public void ToString(){} // RVA: 0x7FFE866BB6E0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866BB730
        public void CalculateSize(){} // RVA: 0x7FFE866BB810
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866BBAD0
        public void .cctor(){} // RVA: 0x7FFE866BBC00
    }

    public class FaceDetectorGraphOptionsReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866BA490
        public void .cctor(){} // RVA: 0x7FFE866BA4F0
    }

}