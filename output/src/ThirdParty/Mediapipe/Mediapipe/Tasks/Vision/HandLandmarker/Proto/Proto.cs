// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker.Proto
// Classes: 4
// Methods: 48

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker.Proto
{
    public class HandLandmarkerGraphOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object baseOptions_;
        public object handDetectorGraphOptions_;
        public object handLandmarksDetectorGraphOptions_;
        public object MinTrackingConfidenceDefaultValue;
        public object minTrackingConfidence_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x65DE2F0
        public void get_Descriptor(){} // RVA: 0x65DE350
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x65DE410
        public void .ctor(){} // RVA: 0x65DE500
        public void Clone(){} // RVA: 0x65DE770
        public void get_BaseOptions(){} // RVA: 0xB700F0
        public void set_BaseOptions(){} // RVA: 0xB70100
        public void get_HandDetectorGraphOptions(){} // RVA: 0xB70160
        public void set_HandDetectorGraphOptions(){} // RVA: 0xB44DC0
        public void get_HandLandmarksDetectorGraphOptions(){} // RVA: 0xD33E60
        public void set_HandLandmarksDetectorGraphOptions(){} // RVA: 0xB708C0
        public void get_MinTrackingConfidence(){} // RVA: 0x65DE7D0
        public void set_MinTrackingConfidence(){} // RVA: 0x65D6890
        public void get_HasMinTrackingConfidence(){} // RVA: 0x64D65D0
        public void ClearMinTrackingConfidence(){} // RVA: 0x64D65E0
        public void Equals(){} // RVA: 0x65DE8A0
        public void GetHashCode(){} // RVA: 0x65DEA50
        public void ToString(){} // RVA: 0x65DEB80
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x65DEBD0
        public void CalculateSize(){} // RVA: 0x65DECA0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x65DF210
        public void .cctor(){} // RVA: 0x65DF380
    }

    public class HandLandmarkerGraphOptionsReflection : Object
    {
        public object descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x65DD740
        public void .cctor(){} // RVA: 0x65DD7A0
    }

    public class HandLandmarksDetectorGraphOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object baseOptions_;
        public object MinDetectionConfidenceDefaultValue;
        public object minDetectionConfidence_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x65E00F0
        public void get_Descriptor(){} // RVA: 0x65E0150
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x65E0210
        public void .ctor(){} // RVA: 0x65E0300
        public void Clone(){} // RVA: 0x65E04B0
        public void get_BaseOptions(){} // RVA: 0xB700F0
        public void set_BaseOptions(){} // RVA: 0xB70100
        public void get_MinDetectionConfidence(){} // RVA: 0x65E0690
        public void set_MinDetectionConfidence(){} // RVA: 0x65D8640
        public void get_HasMinDetectionConfidence(){} // RVA: 0x64D65D0
        public void ClearMinDetectionConfidence(){} // RVA: 0x64D65E0
        public void Equals(){} // RVA: 0x65E0870
        public void GetHashCode(){} // RVA: 0x65E09A0
        public void ToString(){} // RVA: 0x65E0A90
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x65E0AE0
        public void CalculateSize(){} // RVA: 0x65E0B60
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x65E0DB0
        public void .cctor(){} // RVA: 0x65E0E90
    }

    public class HandLandmarksDetectorGraphOptionsReflection : Object
    {
        public object descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x65DF7B0
        public void .cctor(){} // RVA: 0x65DF810
    }

}