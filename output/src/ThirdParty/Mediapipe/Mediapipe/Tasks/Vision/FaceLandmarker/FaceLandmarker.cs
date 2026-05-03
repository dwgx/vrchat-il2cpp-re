// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
// Classes: 4
// Methods: 23

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
{
    public class FaceLandmarker : BaseVisionTaskApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866A9CD0
        public void CreateFromOptions(){} // RVA: 0x7FFE866A9E60
        public void DetectAsync(){} // RVA: 0x7FFE866AA870
        public void BuildPacketsCallback(){} // RVA: 0x7FFE866AA9F0
        public void GetFaceGeometryList(){} // RVA: 0x7FFE866AAC00
        public void TryBuildFaceLandmarkerResult(){} // RVA: 0x7FFE866AAF70
    }

    public class FaceLandmarkerOptions : Object
    {
        public Mediapipe.Tasks.Core.BaseOptions _baseOptions; // 0x10
        public 0x6660F784 _runningMode; // 0x18
        public int _numFaces; // 0x1C
        public float _minFaceDetectionConfidence; // 0x20
        public float _minFacePresenceConfidence; // 0x24
        public float _minTrackingConfidence; // 0x28
        public bool _outputFaceBlendshapes; // 0x2C
        public bool _outputFaceTransformationMatrixes; // 0x2D
        public ResultCallback _resultCallback; // 0x30

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFE81116380
        public void get_runningMode(){} // RVA: 0x7FFE813DB630
        public void get_numFaces(){} // RVA: 0x7FFE82707EE0
        public void get_minFaceDetectionConfidence(){} // RVA: 0x7FFE81124080
        public void get_minFacePresenceConfidence(){} // RVA: 0x7FFE81268F50
        public void get_minTrackingConfidence(){} // RVA: 0x7FFE811DA210
        public void get_outputFaceBlendshapes(){} // RVA: 0x7FFE811DA230
        public void get_outputFaceTransformationMatrixes(){} // RVA: 0x7FFE8130C7C0
        public void get_resultCallback(){} // RVA: 0x7FFE8144E200
        public void .ctor(){} // RVA: 0x7FFE866AB8E0
        public void ToProto(){} // RVA: 0x7FFE866AB9F0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFE866ABC10
    }

    public class FaceLandmarkerResult : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82760A10
        public void Alloc(){} // RVA: 0x7FFE866ABD00
        public void CloneTo(){} // RVA: 0x7FFE866ABE50
        public void ToString(){} // RVA: 0x7FFE866AC1D0
    }

    public class MatrixDataExtension : Object
    {
        // ── Methods ──
        public void ToMatrix4x4(){} // RVA: 0x7FFE866AC360
    }

}