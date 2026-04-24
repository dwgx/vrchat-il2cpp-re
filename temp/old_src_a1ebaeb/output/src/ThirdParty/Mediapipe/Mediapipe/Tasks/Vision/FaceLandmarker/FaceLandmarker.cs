// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
// Classes: 3
// Methods: 22

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
{
    public class FaceLandmarker : BaseVisionTaskApi
    {
        public object _faceGeometriesForRead; // 0x3374C1B0
        public object _faceLandmarker; // 0x338752E0, was: ÏÏÏÌÍÍÌÎÎÌÎÍÏÏÎÌÎÌÍÏÏÍÎ

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd21580
        public void CreateFromOptions(){} // RVA: 0x7ffaadd21710
        public void DetectAsync(){} // RVA: 0x7ffaadd22120
        public void BuildPacketsCallback(){} // RVA: 0x7ffaadd222a0
        public void TryBuildFaceLandmarkerResult(){} // RVA: 0x7ffaadd22820
        // ── Binary Analysis Named ──
        public void GetFaceGeometryList(){} // RVA: 0x7ffaadd224b0
    }

    public class FaceLandmarkerOptions : Object
    {
        public object _numFaces; // 0x33CD29C0, was: <numFaces>k__BackingField
        public object _minTrackingConfidence; // 0x33CD29C0, was: <minTrackingConfidence>k__Back
        public object _resultCallback; // 0x33CD29C0, was: <resultCallback>k__BackingFiel
        public object baseOptions; // 0x170002B0
        public object runningMode; // 0x170002B1
        public object numFaces; // 0x170002B2

        // ── Original Methods ──
        public void get_baseOptions(){} // RVA: 0x7ffaa894d380
        public void get_runningMode(){} // RVA: 0x7ffaa8b945a0
        public void get_numFaces(){} // RVA: 0x7ffaa9e5ac10
        public void get_minFaceDetectionConfidence(){} // RVA: 0x7ffaa895b080
        public void get_minFacePresenceConfidence(){} // RVA: 0x7ffaa8a9ff50
        public void get_minTrackingConfidence(){} // RVA: 0x7ffaa8a11210
        public void get_outputFaceBlendshapes(){} // RVA: 0x7ffaa8a11230
        public void get_outputFaceTransformationMatrixes(){} // RVA: 0x7ffaa9357fe0
        public void get_resultCallback(){} // RVA: 0x7ffaa8bfcc80
        public void .ctor(){} // RVA: 0x7ffaadd23190
        public void ToProto(){} // RVA: 0x7ffaadd232a0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7ffaadd234c0
    }

    public class FaceLandmarkerResult : ValueType
    {
        public object facialTransformationMatrixes; // 0x337C7310

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9e95260
        public void Alloc(){} // RVA: 0x7ffaadd235b0
        public void CloneTo(){} // RVA: 0x7ffaadd23700
        public void ToString(){} // RVA: 0x7ffaadd23a80
    }

}