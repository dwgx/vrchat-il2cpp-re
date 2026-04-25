// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
// Classes: 4
// Methods: 23

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
{
    public class FaceLandmarker : BaseVisionTaskApi
    {
        public PacketsCallback _packetCallback; // 0x20
        public Mediapipe.NormalizedRect _normalizedRect; // 0x28
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Vision.FaceGeometry.Proto.FaceGeometry> _faceGeometriesForRead; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83003D0
        public void CreateFromOptions(){} // RVA: 0x7FFAC8300560
        public void DetectAsync(){} // RVA: 0x7FFAC8300F70
        public void BuildPacketsCallback(){} // RVA: 0x7FFAC83010F0
        public void GetFaceGeometryList(){} // RVA: 0x7FFAC8301300
        public void TryBuildFaceLandmarkerResult(){} // RVA: 0x7FFAC8301670
    }

    public class FaceLandmarkerOptions : Object
    {
        public Mediapipe.Tasks.Core.BaseOptions baseOptions; // 0x10
        public 0x6B215EC0 runningMode; // 0x18
        public int numFaces; // 0x1C
        public float minFaceDetectionConfidence; // 0x20
        public float minFacePresenceConfidence; // 0x24
        public float minTrackingConfidence; // 0x28
        public bool outputFaceBlendshapes; // 0x2C
        public bool outputFaceTransformationMatrixes; // 0x2D
        public ResultCallback resultCallback; // 0x30

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFAC2F3C380
        public void get_runningMode(){} // RVA: 0x7FFAC3157800
        public void get_numFaces(){} // RVA: 0x7FFAC44357F0
        public void get_minFaceDetectionConfidence(){} // RVA: 0x7FFAC2F4A080
        public void get_minFacePresenceConfidence(){} // RVA: 0x7FFAC308EF50
        public void get_minTrackingConfidence(){} // RVA: 0x7FFAC3000210
        public void get_outputFaceBlendshapes(){} // RVA: 0x7FFAC3000230
        public void get_outputFaceTransformationMatrixes(){} // RVA: 0x7FFAC392CE00
        public void get_resultCallback(){} // RVA: 0x7FFAC31D95E0
        public void .ctor(){} // RVA: 0x7FFAC8301FE0
        public void ToProto(){} // RVA: 0x7FFAC83020F0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFAC8302310
    }

    public class FaceLandmarkerResult : ValueType
    {
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Components.Containers.NormalizedLandmarks> faceLandmarks; // 0x10
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Components.Containers.Classifications> faceBlendshapes; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.Matrix4x4> facialTransformationMatrixes; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC446FCC0
        public void Alloc(){} // RVA: 0x7FFAC8302400
        public void CloneTo(){} // RVA: 0x7FFAC8302550
        public void ToString(){} // RVA: 0x7FFAC83028D0
    }

    public class MatrixDataExtension : Object
    {
        // ── Methods ──
        public void ToMatrix4x4(){} // RVA: 0x7FFAC8302A60
    }

}