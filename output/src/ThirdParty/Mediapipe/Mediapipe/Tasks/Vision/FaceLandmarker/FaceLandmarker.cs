// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
// Classes: 4
// Methods: 23

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
{
    public class FaceLandmarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8618EA0
        public void CreateFromOptions(){} // RVA: 0x7FFAF8619030
        public void DetectAsync(){} // RVA: 0x7FFAF8619A40
        public void BuildPacketsCallback(){} // RVA: 0x7FFAF8619BC0
        public void GetFaceGeometryList(){} // RVA: 0x7FFAF8619DD0
        public void TryBuildFaceLandmarkerResult(){} // RVA: 0x7FFAF861A140
    }

    public class FaceLandmarkerOptions
    {
        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFAF2DA8380
        public void get_runningMode(){} // RVA: 0x7FFAF306ED50
        public void get_numFaces(){} // RVA: 0x7FFAF442C3B0
        public void get_minFaceDetectionConfidence(){} // RVA: 0x7FFAF2DB6080
        public void get_minFacePresenceConfidence(){} // RVA: 0x7FFAF2EFAF50
        public void get_minTrackingConfidence(){} // RVA: 0x7FFAF2E6C210
        public void get_outputFaceBlendshapes(){} // RVA: 0x7FFAF2E6C230
        public void get_outputFaceTransformationMatrixes(){} // RVA: 0x7FFAF2FADE20
        public void get_resultCallback(){} // RVA: 0x7FFAF30E74D0
        public void .ctor(){} // RVA: 0x7FFAF861AAB0
        public void ToProto(){} // RVA: 0x7FFAF861ABC0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFAF861ADE0
    }

    public class FaceLandmarkerResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4488110
        public void Alloc(){} // RVA: 0x7FFAF861AED0
        public void CloneTo(){} // RVA: 0x7FFAF861B020
        public void ToString(){} // RVA: 0x7FFAF861B3A0
    }

    public class MatrixDataExtension
    {
        // ── Methods ──
        public void ToMatrix4x4(){} // RVA: 0x7FFAF861B530
    }

}