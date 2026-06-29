// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
// Classes: 4
// Methods: 23

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
{
    public class FaceLandmarker : BaseVisionTaskApi
    {
        public object _packetCallback;
        public object _normalizedRect;
        public object _faceGeometriesForRead;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65E2F40
        public void CreateFromOptions(){} // RVA: 0x65E30D0
        public void DetectAsync(){} // RVA: 0x65E3A20
        public void BuildPacketsCallback(){} // RVA: 0x65E3BA0
        public void GetFaceGeometryList(){} // RVA: 0x65E3DB0
        public void TryBuildFaceLandmarkerResult(){} // RVA: 0x65E4120
    }

    public class FaceLandmarkerOptions : Object
    {
        public object _baseOptions;
        public object _runningMode;
        public object _numFaces;
        public object _minFaceDetectionConfidence;
        public object _minFacePresenceConfidence;
        public object _minTrackingConfidence;
        public object _outputFaceBlendshapes;
        public object _outputFaceTransformationMatrixes;
        public object _resultCallback;

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0xB5DBF0
        public void get_runningMode(){} // RVA: 0xE62D00
        public void get_numFaces(){} // RVA: 0x2244FB0
        public void get_minFaceDetectionConfidence(){} // RVA: 0xB6B200
        public void get_minFacePresenceConfidence(){} // RVA: 0xCBAD90
        public void get_minTrackingConfidence(){} // RVA: 0xC27360
        public void get_outputFaceBlendshapes(){} // RVA: 0xC27380
        public void get_outputFaceTransformationMatrixes(){} // RVA: 0xD96880
        public void get_resultCallback(){} // RVA: 0xD33E60
        public void .ctor(){} // RVA: 0x65E4AA0
        public void ToProto(){} // RVA: 0x65E4BB0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x65E4DD0
    }

    public class FaceLandmarkerResult : ValueType
    {
        public object faceLandmarks;
        public object faceBlendshapes;
        public object facialTransformationMatrixes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x79C50
        public void Alloc(){} // RVA: 0x65E4EC0
        public void CloneTo(){} // RVA: 0x8A6F00
        public void ToString(){} // RVA: 0x8A6F10
    }

    public class MatrixDataExtension : Object
    {
        // ── Methods ──
        public void ToMatrix4x4(){} // RVA: 0x65E5520
    }

}