// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine.Utility
// Classes: 12
// Methods: 75

namespace ThirdParty.Cinemachine.Cinemachine.Utility
{
    public class CinemachineDebug : Object
    {
        // ── Methods ──
        public void ReleaseScreenPos(){} // RVA: 0x7FFD4FC977E0
        public void GetScreenPos(){} // RVA: 0x7FFD4FC97890
        public void SBFromPool(){} // RVA: 0x7FFD4FC97DD0
        public void ReturnToPool(){} // RVA: 0x7FFD4FC97F00
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Damper : Object
    {
        // ── Methods ──
        public void DecayConstant(){} // RVA: 0x7FFD4FC98FA0
        public void DecayedRemainder(){} // RVA: 0x7FFD4FC98FD0
        public void Damp(){} // RVA: 0x7FFD4FC99280 | overloaded x3
    }

    public class GaussianWindow1D_CameraRotation : GaussianWindow1d`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC98990
        public void Compute(){} // RVA: 0x7FFD4FC98AB0
    }

    public class GaussianWindow1D_Quaternion : GaussianWindow1d`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC982E0
        public void Compute(){} // RVA: 0x7FFD4FC98400
    }

    public class GaussianWindow1D_Vector3 : GaussianWindow1d`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC98070
        public void Compute(){} // RVA: 0x7FFD4FC98190
    }

    public class GaussianWindow1d`1 : Object
    {
        public object Sigma;
        public object KernelSize;
        public object BufferLength;

        // ── Methods ──
        public void get_Sigma(){} // RVA: 0x7FFD4E08D880
        public void set_Sigma(){} // RVA: 0x7FFD4E09E480
        public void get_KernelSize(){} // RVA: 0x7FFD4E079960
        public void GenerateKernel(){}
        public void Compute(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){}
        public void Reset(){} // RVA: 0x7FFD4E090980
        public void IsEmpty(){} // RVA: 0x7FFD4E079D00
        public void AddValue(){} // RVA: 0x7FFD4E2ADC40
        public void Filter(){} // RVA: 0x7FFD4E2ADC40
        public void Value(){} // RVA: 0x7FFD4E2ADC40
        public void get_BufferLength(){} // RVA: 0x7FFD4E079960
        public void SetBufferValue(){} // RVA: 0x7FFD4E2ADC40
        public void GetBufferValue(){} // RVA: 0x7FFD4E2ADC40
    }

    public class HeadingTracker : Object
    {
        public object FilterSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC99480
        public void get_FilterSize(){} // RVA: 0x7FFD4E930620
        public void ClearHistory(){} // RVA: 0x7FFD4FC995F0
        public void Decay(){} // RVA: 0x7FFD4FC99650
        public void Add(){} // RVA: 0x7FFD4FC996A0
        public void PopBottom(){} // RVA: 0x7FFD4FC998C0
        public void DecayHistory(){} // RVA: 0x7FFD4FC99A80
        public void GetReliableHeading(){} // RVA: 0x7FFD4FC99BD0
    }

    public class PositionPredictor : Object
    {
        // ── Methods ──
        public void IsEmpty(){} // RVA: 0x7FFD4FC98C50
        public void ApplyTransformDelta(){} // RVA: 0x7FFD4FC98C60
        public void Reset(){} // RVA: 0x7FFD4FC98CA0
        public void AddPosition(){} // RVA: 0x7FFD4FC98D40
        public void PredictPositionDelta(){} // RVA: 0x7FFD4FC98F10
        public void PredictPosition(){} // RVA: 0x7FFD4FC98F50
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SplineHelpers : Object
    {
        // ── Methods ──
        public void Bezier3(){} // RVA: 0x7FFD4FC99D60
        public void BezierTangent3(){} // RVA: 0x7FFD4FC99EF0
        public void BezierTangentWeights3(){} // RVA: 0x7FFD4FC9A180
        public void Bezier1(){} // RVA: 0x7FFD4FC9A370
        public void BezierTangent1(){} // RVA: 0x7FFD4FC9A410
        public void ComputeSmoothControlPoints(){} // RVA: 0x7FFD4FC9A4F0
        public void ComputeSmoothControlPointsLooped(){} // RVA: 0x7FFD4FC9AE10
    }

    public class UnityQuaternionExtensions : Object
    {
        // ── Methods ──
        public void SlerpWithReferenceUp(){} // RVA: 0x7FFD4FC9C720
        public void Normalized(){} // RVA: 0x7FFD4FC9D140
        public void GetCameraRotationToTarget(){} // RVA: 0x7FFD4FC9D260
        public void ApplyCameraRotation(){} // RVA: 0x7FFD4FC9DD50
    }

    public class UnityRectExtensions : Object
    {
        // ── Methods ──
        public void Inflated(){} // RVA: 0x7FFD4FC9E0F0
    }

    public class UnityVectorExtensions : Object
    {
        // ── Methods ──
        public void IsNaN(){} // RVA: 0x7FFD4FC9B140 | overloaded x2
        public void ClosestPointOnSegment(){} // RVA: 0x7FFD4FC9B260 | overloaded x2
        public void ProjectOntoPlane(){} // RVA: 0x7FFD4FC9B310
        public void SquareNormalize(){} // RVA: 0x7FFD4FC9B3A0
        public void FindIntersection(){} // RVA: 0x7FFD4FC9B440
        public void Cross(){} // RVA: 0x7FFD4FC9B830
        public void Abs(){} // RVA: 0x7FFD4FC9B890 | overloaded x2
        public void IsUniform(){} // RVA: 0x7FFD4FC9B940 | overloaded x2
        public void AlmostZero(){} // RVA: 0x7FFD4FC9BA00
        public void ConservativeSetPositionAndRotation(){} // RVA: 0x7FFD4FC9BA40
        public void Angle(){} // RVA: 0x7FFD4FC9BCB0
        public void SignedAngle(){} // RVA: 0x7FFD4FC9BD90
        public void SafeFromToRotation(){} // RVA: 0x7FFD4FC9C060
        public void SlerpWithReferenceUp(){} // RVA: 0x7FFD4FC9C3A0
    }

}