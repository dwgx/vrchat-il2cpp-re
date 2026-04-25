// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
// Classes: 3
// Methods: 22

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceLandmarker
{
    public class FaceLandmarker : BaseVisionTaskApi
    {
        public 0x66577BA0 _packetCallback; // 0x20
        public 0x66573000 _normalizedRect; // 0x28
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Vision.FaceGeometry.Proto.FaceGeometry> _faceGeometriesForRead; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537203D0
        public void CreateFromOptions(){} // RVA: 0x7FFD53720560
        public void DetectAsync(){} // RVA: 0x7FFD53720F70
        public void BuildPacketsCallback(){} // RVA: 0x7FFD537210F0
        public void GetFaceGeometryList(){} // RVA: 0x7FFD53721300
        public void TryBuildFaceLandmarkerResult(){} // RVA: 0x7FFD53721670
    }

    public class FaceLandmarkerOptions : Object
    {
        public Mediapipe.Tasks.Core.BaseOptions baseOptions; // 0x10
        public 0x66575EC0 runningMode; // 0x18
        public int numFaces; // 0x1C
        public float minFaceDetectionConfidence; // 0x20
        public float minFacePresenceConfidence; // 0x24
        public float minTrackingConfidence; // 0x28
        public bool outputFaceBlendshapes; // 0x2C
        public bool outputFaceTransformationMatrixes; // 0x2D
        public 0x66576B78 resultCallback; // 0x30

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFD4E35C380
        public void get_runningMode(){} // RVA: 0x7FFD4E577800
        public void get_numFaces(){} // RVA: 0x7FFD4F8557F0
        public void get_minFaceDetectionConfidence(){} // RVA: 0x7FFD4E36A080
        public void get_minFacePresenceConfidence(){} // RVA: 0x7FFD4E4AEF50
        public void get_minTrackingConfidence(){} // RVA: 0x7FFD4E420210
        public void get_outputFaceBlendshapes(){} // RVA: 0x7FFD4E420230
        public void get_outputFaceTransformationMatrixes(){} // RVA: 0x7FFD4ED4CE00
        public void get_resultCallback(){} // RVA: 0x7FFD4E5F95E0
        public void .ctor(){} // RVA: 0x7FFD53721FE0
        public void ToProto(){} // RVA: 0x7FFD537220F0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFD53722310
    }

    public class FaceLandmarkerResult : ValueType
    {
        public System.Collections.Generic.List`1<0x66578438> faceLandmarks; // 0x10
        public System.Collections.Generic.List`1<0x66578178> faceBlendshapes; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.Matrix4x4> facialTransformationMatrixes; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F88FCC0
        public void Alloc(){} // RVA: 0x7FFD53722400
        public void CloneTo(){} // RVA: 0x7FFD53722550
        public void ToString(){} // RVA: 0x7FFD537228D0
    }

}