// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine.Utility
// Classes: 12
// Methods: 75

namespace ThirdParty.Cinemachine.Cinemachine.Utility
{
    public class CinemachineDebug : Object
    {
        // ── Methods ──
        public void ReleaseScreenPos(){} // RVA: 0x7FFE82ADFB60
        public void GetScreenPos(){} // RVA: 0x7FFE82ADFC10
        public void SBFromPool(){} // RVA: 0x7FFE82AE0150
        public void ReturnToPool(){} // RVA: 0x7FFE82AE0280
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Damper : Object
    {
        // ── Methods ──
        public void DecayConstant(){} // RVA: 0x7FFE82AE1320
        public void DecayedRemainder(){} // RVA: 0x7FFE82AE1350
        public void Damp(){} // RVA: 0x7FFE82AE1600 | overloaded x3
    }

    public class GaussianWindow1D_CameraRotation : GaussianWindow1d`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AE0D10
        public void Compute(){} // RVA: 0x7FFE82AE0E30
    }

    public class GaussianWindow1D_Quaternion : GaussianWindow1d`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AE0660
        public void Compute(){} // RVA: 0x7FFE82AE0780
    }

    public class GaussianWindow1D_Vector3 : GaussianWindow1d`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AE03F0
        public void Compute(){} // RVA: 0x7FFE82AE0510
    }

    public class GaussianWindow1d`1 : Object
    {
        public T[] mData;
        public float[] mKernel;
        public int mCurrentPos;

        // ── Methods ──
        public void get_Sigma(){} // RVA: 0x7FFE80E42E10
        public void set_Sigma(){} // RVA: 0x7FFE80E53B80
        public void get_KernelSize(){} // RVA: 0x7FFE80E2EDB0
        public void GenerateKernel(){}
        public void Compute(){} // RVA: 0x7FFE810A1420
        public void .ctor(){}
        public void Reset(){} // RVA: 0x7FFE80E45FE0
        public void IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void AddValue(){} // RVA: 0x7FFE810A1420
        public void Filter(){} // RVA: 0x7FFE810A1420
        public void Value(){} // RVA: 0x7FFE810A1420
        public void get_BufferLength(){} // RVA: 0x7FFE80E2EDB0
        public void SetBufferValue(){} // RVA: 0x7FFE810A1420
        public void GetBufferValue(){} // RVA: 0x7FFE810A1420
    }

    public class HeadingTracker : Object
    {
        public Item[] mHistory; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AE1800
        public void get_FilterSize(){} // RVA: 0x7FFE81CCB610
        public void ClearHistory(){} // RVA: 0x7FFE82AE1970
        public void Decay(){} // RVA: 0x7FFE82AE19D0
        public void Add(){} // RVA: 0x7FFE82AE1A20
        public void PopBottom(){} // RVA: 0x7FFE82AE1C40
        public void DecayHistory(){} // RVA: 0x7FFE82AE1E00
        public void GetReliableHeading(){} // RVA: 0x7FFE82AE1F50
    }

    public class PositionPredictor : Object
    {
        // ── Methods ──
        public void IsEmpty(){} // RVA: 0x7FFE82AE0FD0
        public void ApplyTransformDelta(){} // RVA: 0x7FFE82AE0FE0
        public void Reset(){} // RVA: 0x7FFE82AE1020
        public void AddPosition(){} // RVA: 0x7FFE82AE10C0
        public void PredictPositionDelta(){} // RVA: 0x7FFE82AE1290
        public void PredictPosition(){} // RVA: 0x7FFE82AE12D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SplineHelpers : Object
    {
        // ── Methods ──
        public void Bezier3(){} // RVA: 0x7FFE82AE20E0
        public void BezierTangent3(){} // RVA: 0x7FFE82AE2270
        public void BezierTangentWeights3(){} // RVA: 0x7FFE82AE2500
        public void Bezier1(){} // RVA: 0x7FFE82AE26F0
        public void BezierTangent1(){} // RVA: 0x7FFE82AE2790
        public void ComputeSmoothControlPoints(){} // RVA: 0x7FFE82AE2870
        public void ComputeSmoothControlPointsLooped(){} // RVA: 0x7FFE82AE3190
    }

    public class UnityQuaternionExtensions : Object
    {
        // ── Methods ──
        public void SlerpWithReferenceUp(){} // RVA: 0x7FFE82AE4AA0
        public void Normalized(){} // RVA: 0x7FFE82AE54C0
        public void GetCameraRotationToTarget(){} // RVA: 0x7FFE82AE55E0
        public void ApplyCameraRotation(){} // RVA: 0x7FFE82AE60D0
    }

    public class UnityRectExtensions : Object
    {
        // ── Methods ──
        public void Inflated(){} // RVA: 0x7FFE82AE6470
    }

    public class UnityVectorExtensions : Object
    {
        // ── Methods ──
        public void IsNaN(){} // RVA: 0x7FFE82AE34C0 | overloaded x2
        public void ClosestPointOnSegment(){} // RVA: 0x7FFE82AE35E0 | overloaded x2
        public void ProjectOntoPlane(){} // RVA: 0x7FFE82AE3690
        public void SquareNormalize(){} // RVA: 0x7FFE82AE3720
        public void FindIntersection(){} // RVA: 0x7FFE82AE37C0
        public void Cross(){} // RVA: 0x7FFE82AE3BB0
        public void Abs(){} // RVA: 0x7FFE82AE3C10 | overloaded x2
        public void IsUniform(){} // RVA: 0x7FFE82AE3CC0 | overloaded x2
        public void AlmostZero(){} // RVA: 0x7FFE82AE3D80
        public void ConservativeSetPositionAndRotation(){} // RVA: 0x7FFE82AE3DC0
        public void Angle(){} // RVA: 0x7FFE82AE4030
        public void SignedAngle(){} // RVA: 0x7FFE82AE4110
        public void SafeFromToRotation(){} // RVA: 0x7FFE82AE43E0
        public void SlerpWithReferenceUp(){} // RVA: 0x7FFE82AE4720
    }

}