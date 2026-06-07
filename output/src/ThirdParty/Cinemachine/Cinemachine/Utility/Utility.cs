// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine.Utility
// Classes: 12
// Methods: 75

namespace ThirdParty.Cinemachine.Cinemachine.Utility
{
    public class CinemachineDebug
    {
        // ── Methods ──
        public void ReleaseScreenPos(){} // RVA: 0x1D51CE0
        public void GetScreenPos(){} // RVA: 0x1D51D90
        public void SBFromPool(){} // RVA: 0x1D522D0
        public void ReturnToPool(){} // RVA: 0x1D52400
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Damper
    {
        // ── Methods ──
        public void DecayConstant(){} // RVA: 0x1D534A0
        public void DecayedRemainder(){} // RVA: 0x1D534D0
        public void Damp(){} // RVA: 0x1D53780 | overloaded x3
    }

    public class GaussianWindow1D_CameraRotation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D52E90
        public void Compute(){} // RVA: 0x1D52FB0
    }

    public class GaussianWindow1D_Quaternion
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D527E0
        public void Compute(){} // RVA: 0x1D52900
    }

    public class GaussianWindow1D_Vector3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D52570
        public void Compute(){} // RVA: 0x1D52690
    }

    public class GaussianWindow1d`1
    {
        // ── Methods ──
        public void get_Sigma(){} // RVA: 0x21890
        public void set_Sigma(){} // RVA: 0x325B0
        public void get_KernelSize(){} // RVA: 0xD840
        public void GenerateKernel(){}
        public void Compute(){} // RVA: 0x283FA0
        public void .ctor(){}
        public void Reset(){} // RVA: 0x24A50
        public void IsEmpty(){} // RVA: 0xDBE0
        public void AddValue(){} // RVA: 0x283FA0
        public void Filter(){} // RVA: 0x283FA0
        public void Value(){} // RVA: 0x283FA0
        public void get_BufferLength(){} // RVA: 0xD840
        public void SetBufferValue(){} // RVA: 0x283FA0
        public void GetBufferValue(){} // RVA: 0x283FA0
    }

    public class HeadingTracker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D53980
        public void get_FilterSize(){} // RVA: 0xF3F910
        public void ClearHistory(){} // RVA: 0x1D53AF0
        public void Decay(){} // RVA: 0x1D53B50
        public void Add(){} // RVA: 0x1D53BA0
        public void PopBottom(){} // RVA: 0x1D53DC0
        public void DecayHistory(){} // RVA: 0x1D53F80
        public void GetReliableHeading(){} // RVA: 0x1D540D0
    }

    public class PositionPredictor
    {
        // ── Methods ──
        public void IsEmpty(){} // RVA: 0x1D53150
        public void ApplyTransformDelta(){} // RVA: 0x1D53160
        public void Reset(){} // RVA: 0x1D531A0
        public void AddPosition(){} // RVA: 0x1D53240
        public void PredictPositionDelta(){} // RVA: 0x1D53410
        public void PredictPosition(){} // RVA: 0x1D53450
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SplineHelpers
    {
        // ── Methods ──
        public void Bezier3(){} // RVA: 0x1D54260
        public void BezierTangent3(){} // RVA: 0x1D543F0
        public void BezierTangentWeights3(){} // RVA: 0x1D54680
        public void Bezier1(){} // RVA: 0x1D54870
        public void BezierTangent1(){} // RVA: 0x1D54910
        public void ComputeSmoothControlPoints(){} // RVA: 0x1D549F0
        public void ComputeSmoothControlPointsLooped(){} // RVA: 0x1D55310
    }

    public class UnityQuaternionExtensions
    {
        // ── Methods ──
        public void SlerpWithReferenceUp(){} // RVA: 0x1D56C20
        public void Normalized(){} // RVA: 0x1D57640
        public void GetCameraRotationToTarget(){} // RVA: 0x1D57760
        public void ApplyCameraRotation(){} // RVA: 0x1D58250
    }

    public class UnityRectExtensions
    {
        // ── Methods ──
        public void Inflated(){} // RVA: 0x1D585F0
    }

    public class UnityVectorExtensions
    {
        // ── Methods ──
        public void IsNaN(){} // RVA: 0x1D55640 | overloaded x2
        public void ClosestPointOnSegment(){} // RVA: 0x1D55760 | overloaded x2
        public void ProjectOntoPlane(){} // RVA: 0x1D55810
        public void SquareNormalize(){} // RVA: 0x1D558A0
        public void FindIntersection(){} // RVA: 0x1D55940
        public void Cross(){} // RVA: 0x1D55D30
        public void Abs(){} // RVA: 0x1D55D90 | overloaded x2
        public void IsUniform(){} // RVA: 0x1D55E40 | overloaded x2
        public void AlmostZero(){} // RVA: 0x1D55F00
        public void ConservativeSetPositionAndRotation(){} // RVA: 0x1D55F40
        public void Angle(){} // RVA: 0x1D561B0
        public void SignedAngle(){} // RVA: 0x1D56290
        public void SafeFromToRotation(){} // RVA: 0x1D56560
        public void SlerpWithReferenceUp(){} // RVA: 0x1D568A0
    }

}