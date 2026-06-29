// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker.Proto
// Classes: 6
// Methods: 74

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker.Proto
{
    public class FaceBlendshapesGraphOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object baseOptions_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x65E65F0
        public void get_Descriptor(){} // RVA: 0x65E6650
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x65E6710
        public void .ctor(){} // RVA: 0x65E6800
        public void Clone(){} // RVA: 0x65E69B0
        public void get_BaseOptions(){} // RVA: 0xB465B0
        public void set_BaseOptions(){} // RVA: 0xBA9BA0
        public void Equals(){} // RVA: 0x659C2B0
        public void GetHashCode(){} // RVA: 0x659C350
        public void ToString(){} // RVA: 0x65E6C80
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x65E6CD0
        public void CalculateSize(){} // RVA: 0x65E6D30
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x65E6F60
        public void .cctor(){} // RVA: 0x65E7020
    }

    public class FaceBlendshapesGraphOptionsReflection : Object
    {
        public object descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x65E5D20
        public void .cctor(){} // RVA: 0x65E5D80
    }

    public class FaceLandmarkerGraphOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object baseOptions_;
        public object faceDetectorGraphOptions_;
        public object faceLandmarksDetectorGraphOptions_;
        public object MinTrackingConfidenceDefaultValue;
        public object minTrackingConfidence_;
        public object faceGeometryGraphOptions_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x65E8110
        public void get_Descriptor(){} // RVA: 0x65E8170
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x65E8230
        public void .ctor(){} // RVA: 0x65E8320
        public void Clone(){} // RVA: 0x65E8770
        public void get_BaseOptions(){} // RVA: 0xB700F0
        public void set_BaseOptions(){} // RVA: 0xB70100
        public void get_FaceDetectorGraphOptions(){} // RVA: 0xB70160
        public void set_FaceDetectorGraphOptions(){} // RVA: 0xB44DC0
        public void get_FaceLandmarksDetectorGraphOptions(){} // RVA: 0xD33E60
        public void set_FaceLandmarksDetectorGraphOptions(){} // RVA: 0xB708C0
        public void get_MinTrackingConfidence(){} // RVA: 0x65E87D0
        public void set_MinTrackingConfidence(){} // RVA: 0x65D6890
        public void get_HasMinTrackingConfidence(){} // RVA: 0x64D65D0
        public void ClearMinTrackingConfidence(){} // RVA: 0x64D65E0
        public void get_FaceGeometryGraphOptions(){} // RVA: 0xBC1B30
        public void set_FaceGeometryGraphOptions(){} // RVA: 0xB6A8C0
        public void Equals(){} // RVA: 0x65E88A0
        public void GetHashCode(){} // RVA: 0x65E8A80
        public void ToString(){} // RVA: 0x65E8BD0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x65E8C20
        public void CalculateSize(){} // RVA: 0x65E8D10
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x65E9200
        public void .cctor(){} // RVA: 0x65E93C0
    }

    public class FaceLandmarkerGraphOptionsReflection : Object
    {
        public object descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x65E7430
        public void .cctor(){} // RVA: 0x65E7490
    }

    public class FaceLandmarksDetectorGraphOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object baseOptions_;
        public object MinDetectionConfidenceDefaultValue;
        public object minDetectionConfidence_;
        public object SmoothLandmarksDefaultValue;
        public object smoothLandmarks_;
        public object faceBlendshapesGraphOptions_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x65EA2B0
        public void get_Descriptor(){} // RVA: 0x65EA310
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x65EA3D0
        public void .ctor(){} // RVA: 0x65EA4C0
        public void Clone(){} // RVA: 0x65EA6D0
        public void get_BaseOptions(){} // RVA: 0xB700F0
        public void set_BaseOptions(){} // RVA: 0xB70100
        public void get_MinDetectionConfidence(){} // RVA: 0x65EA730
        public void set_MinDetectionConfidence(){} // RVA: 0x65D8640
        public void get_HasMinDetectionConfidence(){} // RVA: 0x64D65D0
        public void ClearMinDetectionConfidence(){} // RVA: 0x64D65E0
        public void get_SmoothLandmarks(){} // RVA: 0x65EA7A0
        public void set_SmoothLandmarks(){} // RVA: 0x65D86C0
        public void get_HasSmoothLandmarks(){} // RVA: 0x64D6670
        public void ClearSmoothLandmarks(){} // RVA: 0x64D6680
        public void get_FaceBlendshapesGraphOptions(){} // RVA: 0xD33E60
        public void set_FaceBlendshapesGraphOptions(){} // RVA: 0xB708C0
        public void Equals(){} // RVA: 0x65EA870
        public void GetHashCode(){} // RVA: 0x65EA9F0
        public void ToString(){} // RVA: 0x65EAB20
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x65EAB70
        public void CalculateSize(){} // RVA: 0x65EAC40
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x65EB0E0
        public void .cctor(){} // RVA: 0x65EB230
    }

    public class FaceLandmarksDetectorGraphOptionsReflection : Object
    {
        public object descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x65E97F0
        public void .cctor(){} // RVA: 0x65E9850
    }

}