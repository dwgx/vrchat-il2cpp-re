// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine.Utility
// Classes: 15
// Methods: 111

namespace ThirdParty.Cinemachine.Cinemachine.Utility
{
    public class CinemachineDebug : Object
    {
        public object mClients;
        public object OnGUIHandlers;
        public object mAvailableStringBuilders;

        // ── Methods ──
        public void ReleaseScreenPos(){} // RVA: 0x2600410
        public void GetScreenPos(){} // RVA: 0x26004C0
        public void SBFromPool(){} // RVA: 0x26009F0
        public void ReturnToPool(){} // RVA: 0x2600B20
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Damper : Object
    {
        public object Epsilon;
        public object kNegligibleResidual;
        public object kLogNegligibleResidual;

        // ── Methods ──
        public void DecayConstant(){} // RVA: 0x2601C80
        public void DecayedRemainder(){} // RVA: 0x2601CB0
        public void Damp(){} // RVA: 0x2601F60
    }

    public class GaussianWindow1D_CameraRotation : GaussianWindow1d`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2601610
        public void Compute(){} // RVA: 0x2601730
    }

    public class GaussianWindow1D_Quaternion : GaussianWindow1d`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2600F30
        public void Compute(){} // RVA: 0x2601050
    }

    public class GaussianWindow1D_Vector3 : GaussianWindow1d`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2600C90
        public void Compute(){} // RVA: 0x2600DB0
    }

    public class GaussianWindow1d`1 : Object
    {
        public object mData;
        public object mKernel;
        public object mCurrentPos;
        public object _sigma;

        // ── Methods ──
        public void get_Sigma(){} // RVA: 0x890F90
        public void set_Sigma(){} // RVA: 0x8A23A0
        public void get_KernelSize(){} // RVA: 0x87C130
        public void GenerateKernel(){} // RVA: 0x8A2500
        public void Compute(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x8A2500
        public void Reset(){} // RVA: 0x894290
        public void IsEmpty(){} // RVA: 0x87D280
        public void AddValue(){} // RVA: 0xA94080
        public void Filter(){} // RVA: 0xA94080
        public void Value(){} // RVA: 0xA94080
        public void get_BufferLength(){} // RVA: 0x87C130
        public void SetBufferValue(){} // RVA: 0xA94080
        public void GetBufferValue(){} // RVA: 0xA94080
    }

    public class GaussianWindow1d`1 : Object
    {
        public object mData;
        public object mKernel;
        public object mCurrentPos;
        public object _sigma;

        // ── Methods ──
        public void get_Sigma(){} // RVA: 0xCBAD90
        public void set_Sigma(){} // RVA: 0xCBADA0
        public void get_KernelSize(){} // RVA: 0x3E42680
        public void GenerateKernel(){} // RVA: 0x3E432E0
        public void Compute(){} // RVA: 0x87BF40
        public void .ctor(){} // RVA: 0x3E435A0
        public void Reset(){} // RVA: 0x3928BD0
        public void IsEmpty(){} // RVA: 0x3E42A30
        public void AddValue(){} // RVA: 0x3E43670
        public void Filter(){} // RVA: 0x3E43750
        public void Value(){} // RVA: 0x3E438A0
        public void get_BufferLength(){} // RVA: 0x17F0080
        public void SetBufferValue(){} // RVA: 0x3E438E0
        public void GetBufferValue(){} // RVA: 0x3E43920
    }

    public class GaussianWindow1d`1 : Object
    {
        public object mData;
        public object mKernel;
        public object mCurrentPos;
        public object _sigma;

        // ── Methods ──
        public void get_Sigma(){} // RVA: 0xCBAD90
        public void set_Sigma(){} // RVA: 0xCBADA0
        public void get_KernelSize(){} // RVA: 0x3E42680
        public void GenerateKernel(){} // RVA: 0x3E426A0
        public void Compute(){} // RVA: 0x87BF40
        public void .ctor(){} // RVA: 0x3E42960
        public void Reset(){} // RVA: 0x3928BD0
        public void IsEmpty(){} // RVA: 0x3E42A30
        public void AddValue(){} // RVA: 0x3E42A40
        public void Filter(){} // RVA: 0x3E42B10
        public void Value(){} // RVA: 0x3E42C30
        public void get_BufferLength(){} // RVA: 0x17F0080
        public void SetBufferValue(){} // RVA: 0x3E42C70
        public void GetBufferValue(){} // RVA: 0x2556F40
    }

    public class GaussianWindow1d`1 : Object
    {
        public object mData;
        public object mKernel;
        public object mCurrentPos;
        public object _sigma;

        // ── Methods ──
        public void get_Sigma(){} // RVA: 0xCBAD90
        public void set_Sigma(){} // RVA: 0xCBADA0
        public void get_KernelSize(){} // RVA: 0x3E42680
        public void GenerateKernel(){} // RVA: 0x3E42CB0
        public void Compute(){} // RVA: 0x87C160
        public void .ctor(){} // RVA: 0x3E42F70
        public void Reset(){} // RVA: 0x3928BD0
        public void IsEmpty(){} // RVA: 0x3E42A30
        public void AddValue(){} // RVA: 0x3E43040
        public void Filter(){} // RVA: 0x3E43120
        public void Value(){} // RVA: 0x3E43230
        public void get_BufferLength(){} // RVA: 0x17F0080
        public void SetBufferValue(){} // RVA: 0x3E43250
        public void GetBufferValue(){} // RVA: 0x3E432A0
    }

    public class HeadingTracker : Object
    {
        public object mHistory;
        public object mTop;
        public object mBottom;
        public object mCount;
        public object mHeadingSum;
        public object mWeightSum;
        public object mWeightTime;
        public object mLastGoodHeading;
        public object mDecayExponent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2602160
        public void get_FilterSize(){} // RVA: 0x17F0080
        public void ClearHistory(){} // RVA: 0x26022D0
        public void Decay(){} // RVA: 0x2602330
        public void Add(){} // RVA: 0x2602380
        public void PopBottom(){} // RVA: 0x26025A0
        public void DecayHistory(){} // RVA: 0x2602770
        public void GetReliableHeading(){} // RVA: 0x26028C0
    }

    public class PositionPredictor : Object
    {
        public object m_Velocity;
        public object m_SmoothDampVelocity;
        public object m_Pos;
        public object m_HavePos;
        public object Smoothing;

        // ── Methods ──
        public void IsEmpty(){} // RVA: 0x2601940
        public void ApplyTransformDelta(){} // RVA: 0x2601950
        public void Reset(){} // RVA: 0x2601990
        public void AddPosition(){} // RVA: 0x2601A30
        public void PredictPositionDelta(){} // RVA: 0x2601BF0
        public void PredictPosition(){} // RVA: 0x2601C30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SplineHelpers : Object
    {
        // ── Methods ──
        public void Bezier3(){} // RVA: 0x2602A50
        public void BezierTangent3(){} // RVA: 0x2602BE0
        public void BezierTangentWeights3(){} // RVA: 0x2602F10
        public void Bezier1(){} // RVA: 0x2603110
        public void BezierTangent1(){} // RVA: 0x26031B0
        public void ComputeSmoothControlPoints(){} // RVA: 0x2603290
        public void ComputeSmoothControlPointsLooped(){} // RVA: 0x2603C70
    }

    public class UnityQuaternionExtensions : Object
    {
        // ── Methods ──
        public void SlerpWithReferenceUp(){} // RVA: 0x2605690
        public void Normalized(){} // RVA: 0x2606090
        public void GetCameraRotationToTarget(){} // RVA: 0x26061B0
        public void ApplyCameraRotation(){} // RVA: 0x2606C80
    }

    public class UnityRectExtensions : Object
    {
        // ── Methods ──
        public void Inflated(){} // RVA: 0x2607020
    }

    public class UnityVectorExtensions : Object
    {
        public object Epsilon;

        // ── Methods ──
        public void IsNaN(){} // RVA: 0x2603FF0
        public void ClosestPointOnSegment(){} // RVA: 0x2604110
        public void ProjectOntoPlane(){} // RVA: 0x26041B0
        public void SquareNormalize(){} // RVA: 0x2604240
        public void FindIntersection(){} // RVA: 0x26042E0
        public void Cross(){} // RVA: 0x26046D0
        public void Abs(){} // RVA: 0x2604730
        public void IsUniform(){} // RVA: 0x26047E0
        public void AlmostZero(){} // RVA: 0x26048A0
        public void ConservativeSetPositionAndRotation(){} // RVA: 0x26048E0
        public void Angle(){} // RVA: 0x2604C00
        public void SignedAngle(){} // RVA: 0x2604CE0
        public void SafeFromToRotation(){} // RVA: 0x2604FD0
        public void SlerpWithReferenceUp(){} // RVA: 0x2605310
    }

}