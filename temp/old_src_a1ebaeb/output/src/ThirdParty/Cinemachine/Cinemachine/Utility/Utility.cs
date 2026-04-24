// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine.Utility
// Classes: 15
// Methods: 117

namespace ThirdParty.Cinemachine.Cinemachine.Utility
{
    public class CinemachineDebug : Object
    {
        public object mAvailableStringBuilders; // 0x3341DF60

        // ── Original Methods ──
        public void ReleaseScreenPos(){} // RVA: 0x7ffaaa27f6f0
        public void SBFromPool(){} // RVA: 0x7ffaaa27fce0
        public void ReturnToPool(){} // RVA: 0x7ffaaa27fe10
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetScreenPos(){} // RVA: 0x7ffaaa27f7a0
    }

    public class Damper : Object
    {
        public object kLogNegligibleResidual; // 0x34B5CB50

        // ── Original Methods ──
        public void DecayConstant(){} // RVA: 0x7ffaaa280eb0
        public void DecayedRemainder(){} // RVA: 0x7ffaaa280ee0
        public void Damp(){} // RVA: 0x7ffaaa281190
        public void Damp(){} // RVA: 0x7ffaaa281190
        public void Damp(){} // RVA: 0x7ffaaa281190
    }

    public class GaussianWindow1D_CameraRotation : GaussianWindow1d`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa2808a0
        public void Compute(){} // RVA: 0x7ffaaa2809c0
    }

    public class GaussianWindow1D_Quaternion : GaussianWindow1d`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa2801f0
        public void Compute(){} // RVA: 0x7ffaaa280310
    }

    public class GaussianWindow1D_Vector3 : GaussianWindow1d`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa27ff80
        public void Compute(){} // RVA: 0x7ffaaa2800a0
    }

    public class GaussianWindow1d`1 : Object
    {
        public object mCurrentPos; // 0x30FF4460

        // ── Original Methods ──
        public void get_Sigma(){} // RVA: 0x7ffaa865dbc0
        public void set_Sigma(){} // RVA: 0x7ffaa866e7c0
        public void get_KernelSize(){} // RVA: 0x7ffaa8649ca0
        public void GenerateKernel(){}
        public void Compute(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){}
        public void Reset(){} // RVA: 0x7ffaa8660cc0
        public void IsEmpty(){} // RVA: 0x7ffaa864a040
        public void AddValue(){} // RVA: 0x7ffaa887e5c0
        public void Filter(){} // RVA: 0x7ffaa887e5c0
        public void Value(){} // RVA: 0x7ffaa887e5c0
        public void get_BufferLength(){} // RVA: 0x7ffaa8649ca0
        // ── Binary Analysis Named ──
        public void SetBufferValue(){} // RVA: 0x7ffaa887e5c0
        public void GetBufferValue(){} // RVA: 0x7ffaa887e5c0
    }

    public class GaussianWindow1d`1 : Object
    {
        public object mCurrentPos; // 0x34B2CEE8
        public object Sigma; // 0x170000F8

        // ── Original Methods ──
        public void get_Sigma(){} // RVA: 0x7ffaa8a9ff50
        public void set_Sigma(){} // RVA: 0x7ffaa8a9ff60
        public void get_KernelSize(){} // RVA: 0x7ffaab6f2b10
        public void GenerateKernel(){} // RVA: 0x7ffaab6f36b0
        public void Compute(){} // RVA: 0x7ffaa8649f30
        public void .ctor(){} // RVA: 0x7ffaab6f3910
        public void Reset(){} // RVA: 0x7ffaab27fc10
        public void IsEmpty(){} // RVA: 0x7ffaab6f2e60
        public void AddValue(){} // RVA: 0x7ffaab6f39e0
        public void Filter(){} // RVA: 0x7ffaab6f3ac0
        public void Value(){} // RVA: 0x7ffaab6f3c10
        public void get_BufferLength(){} // RVA: 0x7ffaa8f3de30
        // ── Binary Analysis Named ──
        public void SetBufferValue(){} // RVA: 0x7ffaab6f3c50
        public void GetBufferValue(){} // RVA: 0x7ffaab6f3c90
    }

    public class GaussianWindow1d`1 : Object
    {
        public object mCurrentPos; // 0x34B2D070
        public object Sigma; // 0x170000F8

        // ── Original Methods ──
        public void get_Sigma(){} // RVA: 0x7ffaa8a9ff50
        public void set_Sigma(){} // RVA: 0x7ffaa8a9ff60
        public void get_KernelSize(){} // RVA: 0x7ffaab6f2b10
        public void GenerateKernel(){} // RVA: 0x7ffaab6f2b30
        public void Compute(){} // RVA: 0x7ffaa8649f30
        public void .ctor(){} // RVA: 0x7ffaab6f2d90
        public void Reset(){} // RVA: 0x7ffaab27fc10
        public void IsEmpty(){} // RVA: 0x7ffaab6f2e60
        public void AddValue(){} // RVA: 0x7ffaab6f2e70
        public void Filter(){} // RVA: 0x7ffaab6f2f40
        public void Value(){} // RVA: 0x7ffaab6f3060
        public void get_BufferLength(){} // RVA: 0x7ffaa8f3de30
        // ── Binary Analysis Named ──
        public void SetBufferValue(){} // RVA: 0x7ffaab6f30a0
        public void GetBufferValue(){} // RVA: 0x7ffaaa1d9a90
    }

    public class GaussianWindow1d`1 : Object
    {
        public object mCurrentPos; // 0x34B2D1F8
        public object Sigma; // 0x170000F8

        // ── Original Methods ──
        public void get_Sigma(){} // RVA: 0x7ffaa8a9ff50
        public void set_Sigma(){} // RVA: 0x7ffaa8a9ff60
        public void get_KernelSize(){} // RVA: 0x7ffaab6f2b10
        public void GenerateKernel(){} // RVA: 0x7ffaab6f30e0
        public void Compute(){}
        public void .ctor(){} // RVA: 0x7ffaab6f3340
        public void Reset(){} // RVA: 0x7ffaab27fc10
        public void IsEmpty(){} // RVA: 0x7ffaab6f2e60
        public void AddValue(){} // RVA: 0x7ffaab6f3410
        public void Filter(){} // RVA: 0x7ffaab6f34f0
        public void Value(){} // RVA: 0x7ffaab6f3600
        public void get_BufferLength(){} // RVA: 0x7ffaa8f3de30
        // ── Binary Analysis Named ──
        public void SetBufferValue(){} // RVA: 0x7ffaab6f3620
        public void GetBufferValue(){} // RVA: 0x7ffaab6f3670
    }

    public class HeadingTracker : Object
    {
        public object mBottom; // 0x34B5CE50
        public object mWeightSum; // 0x34B5CE50
        public object mDecayExponent; // 0x34B5CE50
        public object FilterSize; // 0x170000FB

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa281390
        public void get_FilterSize(){} // RVA: 0x7ffaa8f3de30
        public void ClearHistory(){} // RVA: 0x7ffaaa281500
        public void Decay(){} // RVA: 0x7ffaaa281560
        public void Add(){} // RVA: 0x7ffaaa2815b0
        public void PopBottom(){} // RVA: 0x7ffaaa2817d0
        public void DecayHistory(){} // RVA: 0x7ffaaa281990
        // ── Binary Analysis Named ──
        public void GetReliableHeading(){} // RVA: 0x7ffaaa281ae0
    }

    public class PositionPredictor : Object
    {
        public object m_Pos; // 0x33814C90
        public object DecayConstant; // 0xB41EDE30

        // ── Original Methods ──
        public void IsEmpty(){} // RVA: 0x7ffaaa280b60
        public void ApplyTransformDelta(){} // RVA: 0x7ffaaa280b70
        public void Reset(){} // RVA: 0x7ffaaa280bb0
        public void AddPosition(){} // RVA: 0x7ffaaa280c50
        public void PredictPositionDelta(){} // RVA: 0x7ffaaa280e20
        public void PredictPosition(){} // RVA: 0x7ffaaa280e60
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SplineHelpers : Object
    {
        // ── Original Methods ──
        public void Bezier3(){} // RVA: 0x7ffaaa281c70
        public void BezierTangent3(){} // RVA: 0x7ffaaa281e00
        public void BezierTangentWeights3(){} // RVA: 0x7ffaaa282090
        public void Bezier1(){} // RVA: 0x7ffaaa282280
        public void BezierTangent1(){} // RVA: 0x7ffaaa282320
        public void ComputeSmoothControlPoints(){} // RVA: 0x7ffaaa282400
        public void ComputeSmoothControlPointsLooped(){} // RVA: 0x7ffaaa282d20
    }

    public class UnityQuaternionExtensions : Object
    {
        // ── Original Methods ──
        public void SlerpWithReferenceUp(){} // RVA: 0x7ffaaa284630
        public void Normalized(){} // RVA: 0x7ffaaa285050
        public void ApplyCameraRotation(){} // RVA: 0x7ffaaa285c60
        // ── Binary Analysis Named ──
        public void GetCameraRotationToTarget(){} // RVA: 0x7ffaaa285170
    }

    public class UnityRectExtensions : Object
    {
        // ── Original Methods ──
        public void Inflated(){} // RVA: 0x7ffaaa286000
    }

    public class UnityVectorExtensions : Object
    {
        // ── Original Methods ──
        public void IsNaN(){} // RVA: 0x7ffaaa283050
        public void IsNaN(){} // RVA: 0x7ffaaa283050
        public void ClosestPointOnSegment(){} // RVA: 0x7ffaaa283170
        public void ClosestPointOnSegment(){} // RVA: 0x7ffaaa283170
        public void ProjectOntoPlane(){} // RVA: 0x7ffaaa283220
        public void SquareNormalize(){} // RVA: 0x7ffaaa2832b0
        public void FindIntersection(){} // RVA: 0x7ffaaa283350
        public void Cross(){} // RVA: 0x7ffaaa283740
        public void Abs(){} // RVA: 0x7ffaaa2837a0
        public void Abs(){} // RVA: 0x7ffaaa2837a0
        public void IsUniform(){} // RVA: 0x7ffaaa283850
        public void IsUniform(){} // RVA: 0x7ffaaa283850
        public void AlmostZero(){} // RVA: 0x7ffaaa283910
        public void ConservativeSetPositionAndRotation(){} // RVA: 0x7ffaaa283950
        public void Angle(){} // RVA: 0x7ffaaa283bc0
        public void SignedAngle(){} // RVA: 0x7ffaaa283ca0
        public void SafeFromToRotation(){} // RVA: 0x7ffaaa283f70
        public void SlerpWithReferenceUp(){} // RVA: 0x7ffaaa2842b0
    }

}