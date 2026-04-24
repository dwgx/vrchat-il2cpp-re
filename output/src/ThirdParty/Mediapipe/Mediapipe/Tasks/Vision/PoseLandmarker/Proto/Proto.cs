// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker.Proto
// Classes: 2
// Methods: 54

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker.Proto
{
    public class PoseLandmarkerGraphOptions : Object
    {
        public gBox.itionBlend<rReflection.t_Threshold> Parser;
        public gBox.ra Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public nceFieldNumber.rdio BaseOptions; // 0x20
        public cketTimestampForAddedPacket.Recordio PoseDetectorGraphOptions; // 0x28
        public rReflection.nvalidUpperBound PoseLandmarksDetectorGraphOptions; // 0x30
        public float MinTrackingConfidence; // 0x8
        public float HasMinTrackingConfidence; // 0x38

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFD53713750
        public void get_Descriptor(){} // RVA: 0x7FFD537137B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD53713870
        public void .ctor(){} // RVA: 0x7FFD53713960 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD53713BB0
        public void get_BaseOptions(){} // RVA: 0x7FFD4E36F0C0
        public void set_BaseOptions(){} // RVA: 0x7FFD4E36F0D0
        public void get_PoseDetectorGraphOptions(){} // RVA: 0x7FFD4E36F130
        public void set_PoseDetectorGraphOptions(){} // RVA: 0x7FFD4E342E90
        public void get_PoseLandmarksDetectorGraphOptions(){} // RVA: 0x7FFD4E5F95E0
        public void set_PoseLandmarksDetectorGraphOptions(){} // RVA: 0x7FFD4E36F890
        public void get_MinTrackingConfidence(){} // RVA: 0x7FFD53713C10
        public void set_MinTrackingConfidence(){} // RVA: 0x7FFD53713C80
        public void get_HasMinTrackingConfidence(){} // RVA: 0x7FFD53613770
        public void ClearMinTrackingConfidence(){} // RVA: 0x7FFD53613780
        public void Equals(){} // RVA: 0x7FFD53713CF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53713EA0
        public void ToString(){} // RVA: 0x7FFD53713FD0
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD53714020
        public void CalculateSize(){} // RVA: 0x7FFD537140F0
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD53714510
        public void .cctor(){} // RVA: 0x7FFD53714680
    }

    public class PoseLandmarksDetectorGraphOptions : Object
    {
        public gBox.itionBlend<rReflection.nvalidUpperBound> Parser;
        public gBox.ra Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public nceFieldNumber.rdio BaseOptions; // 0x20
        public float MinDetectionConfidence; // 0x8
        public float HasMinDetectionConfidence; // 0x28
        public bool SmoothLandmarks; // 0xC
        public bool HasSmoothLandmarks; // 0x2C

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFD53715450
        public void get_Descriptor(){} // RVA: 0x7FFD537154B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD53715570
        public void .ctor(){} // RVA: 0x7FFD53715660 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD537157F0
        public void get_BaseOptions(){} // RVA: 0x7FFD4E36F0C0
        public void set_BaseOptions(){} // RVA: 0x7FFD4E36F0D0
        public void get_MinDetectionConfidence(){} // RVA: 0x7FFD537159C0
        public void set_MinDetectionConfidence(){} // RVA: 0x7FFD53715A30
        public void get_HasMinDetectionConfidence(){} // RVA: 0x7FFD53613770
        public void ClearMinDetectionConfidence(){} // RVA: 0x7FFD53613780
        public void get_SmoothLandmarks(){} // RVA: 0x7FFD53715A40
        public void set_SmoothLandmarks(){} // RVA: 0x7FFD53715AB0
        public void get_HasSmoothLandmarks(){} // RVA: 0x7FFD53613810
        public void ClearSmoothLandmarks(){} // RVA: 0x7FFD53613820
        public void Equals(){} // RVA: 0x7FFD53715C50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53715DA0
        public void ToString(){} // RVA: 0x7FFD53715EC0
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD53715F10
        public void CalculateSize(){} // RVA: 0x7FFD53715FC0
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD53716230
        public void .cctor(){} // RVA: 0x7FFD53716330
    }

}