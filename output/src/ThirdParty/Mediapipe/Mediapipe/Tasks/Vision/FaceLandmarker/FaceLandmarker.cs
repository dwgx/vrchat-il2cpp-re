// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
// Classes: 4
// Methods: 23

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
{
    public class FaceLandmarker : BaseVisionTaskApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD956B40
        public void CreateFromOptions(){} // RVA: 0x7AD956CD0
        public void DetectAsync(){} // RVA: 0x7AD9576E0
        public void BuildPacketsCallback(){} // RVA: 0x7AD957860
        public void GetFaceGeometryList(){} // RVA: 0x7AD957A70
        public void TryBuildFaceLandmarkerResult(){} // RVA: 0x7AD957DE0
    }

    public class FaceLandmarkerOptions : Object
    {
        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7A80F2570
        public void get_runningMode(){} // RVA: 0x7A83782A0
        public void get_numFaces(){} // RVA: 0x7A9739200
        public void get_minFaceDetectionConfidence(){} // RVA: 0x7A81002C0
        public void get_minFacePresenceConfidence(){} // RVA: 0x7A82461C0
        public void get_minTrackingConfidence(){} // RVA: 0x7A81B7060
        public void get_outputFaceBlendshapes(){} // RVA: 0x7A81B7080
        public void get_outputFaceTransformationMatrixes(){} // RVA: 0x7A8ABD450
        public void get_resultCallback(){} // RVA: 0x7A83F69F0
        public void .ctor(){} // RVA: 0x7AD958760
        public void ToProto(){} // RVA: 0x7AD958870
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7AD958A90
    }

    public class FaceLandmarkerResult : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7660880
        public void Alloc(){} // RVA: 0x7AD958B80
        public void CloneTo(){} // RVA: 0x7A7E2B240
        public void ToString(){} // RVA: 0x7A7E2B250
    }

    public class MatrixDataExtension : Object
    {
        // ── Methods ──
        public void ToMatrix4x4(){} // RVA: 0x7AD9591E0
    }

}