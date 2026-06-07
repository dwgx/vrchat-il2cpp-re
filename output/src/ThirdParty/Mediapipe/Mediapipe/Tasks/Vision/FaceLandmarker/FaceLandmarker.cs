// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
// Classes: 4
// Methods: 23

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
{
    public class FaceLandmarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5B68EA0
        public void CreateFromOptions(){} // RVA: 0x5B69030
        public void DetectAsync(){} // RVA: 0x5B69A40
        public void BuildPacketsCallback(){} // RVA: 0x5B69BC0
        public void GetFaceGeometryList(){} // RVA: 0x5B69DD0
        public void TryBuildFaceLandmarkerResult(){} // RVA: 0x5B6A140
    }

    public class FaceLandmarkerOptions
    {
        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x2F8380
        public void get_runningMode(){} // RVA: 0x5BED50
        public void get_numFaces(){} // RVA: 0x197C3B0
        public void get_minFaceDetectionConfidence(){} // RVA: 0x306080
        public void get_minFacePresenceConfidence(){} // RVA: 0x44AF50
        public void get_minTrackingConfidence(){} // RVA: 0x3BC210
        public void get_outputFaceBlendshapes(){} // RVA: 0x3BC230
        public void get_outputFaceTransformationMatrixes(){} // RVA: 0x4FDE20
        public void get_resultCallback(){} // RVA: 0x6374D0
        public void .ctor(){} // RVA: 0x5B6AAB0
        public void ToProto(){} // RVA: 0x5B6ABC0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x5B6ADE0
    }

    public class FaceLandmarkerResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x19D8110
        public void Alloc(){} // RVA: 0x5B6AED0
        public void CloneTo(){} // RVA: 0x5B6B020
        public void ToString(){} // RVA: 0x5B6B3A0
    }

    public class MatrixDataExtension
    {
        // ── Methods ──
        public void ToMatrix4x4(){} // RVA: 0x5B6B530
    }

}