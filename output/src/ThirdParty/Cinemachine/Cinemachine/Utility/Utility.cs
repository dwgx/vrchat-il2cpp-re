// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Cinemachine.Cinemachine.Utility
// Classes: 12
// Methods: 75

namespace ThirdParty.Cinemachine.Cinemachine.Utility
{
    public class CinemachineDebug : Object
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.Object> mClients;
        public OnGUIDelegate OnGUIHandlers; // 0x8
        public System.Collections.Generic.List`1<System.Text.StringBuilder> mAvailableStringBuilders; // 0x10

        // ── Methods ──
        public void ReleaseScreenPos(){} // RVA: 0x7FFAC48777E0
        public void GetScreenPos(){} // RVA: 0x7FFAC4877890
        public void SBFromPool(){} // RVA: 0x7FFAC4877DD0
        public void ReturnToPool(){} // RVA: 0x7FFAC4877F00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Damper : Object
    {
        public float Epsilon;
        public float kNegligibleResidual;
        public float kLogNegligibleResidual;

        // ── Methods ──
        public void DecayConstant(){} // RVA: 0x7FFAC4878FA0
        public void DecayedRemainder(){} // RVA: 0x7FFAC4878FD0
        public void Damp(){} // RVA: 0x7FFAC4879280 | overloaded x3
    }

    public class GaussianWindow1D_CameraRotation : GaussianWindow1d`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4878990
        public void Compute(){} // RVA: 0x7FFAC4878AB0
    }

    public class GaussianWindow1D_Quaternion : GaussianWindow1d`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC48782E0
        public void Compute(){} // RVA: 0x7FFAC4878400
    }

    public class GaussianWindow1D_Vector3 : GaussianWindow1d`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4878070
        public void Compute(){} // RVA: 0x7FFAC4878190
    }

    public class GaussianWindow1d`1 : Object
    {
        public T[] Sigma;
        public float[] KernelSize;
        public int BufferLength;
        public float <Sigma>k__BackingField;

        // ── Methods ──
        public void get_Sigma(){} // RVA: 0x7FFAC2C6D880
        public void set_Sigma(){} // RVA: 0x7FFAC2C7E480
        public void get_KernelSize(){} // RVA: 0x7FFAC2C59960
        public void GenerateKernel(){}
        public void Compute(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){}
        public void Reset(){} // RVA: 0x7FFAC2C70980
        public void IsEmpty(){} // RVA: 0x7FFAC2C59D00
        public void AddValue(){} // RVA: 0x7FFAC2E8DC40
        public void Filter(){} // RVA: 0x7FFAC2E8DC40
        public void Value(){} // RVA: 0x7FFAC2E8DC40
        public void get_BufferLength(){} // RVA: 0x7FFAC2C59960
        public void SetBufferValue(){} // RVA: 0x7FFAC2E8DC40
        public void GetBufferValue(){} // RVA: 0x7FFAC2E8DC40
    }

    public class HeadingTracker : Object
    {
        public Item[] FilterSize; // 0x10
        public int mTop; // 0x18
        public int mBottom; // 0x1C
        public int mCount; // 0x20
        public UnityEngine.Vector3 mHeadingSum; // 0x24
        public float mWeightSum; // 0x30
        public float mWeightTime; // 0x34
        public UnityEngine.Vector3 mLastGoodHeading; // 0x38
        public float mDecayExponent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4879480
        public void get_FilterSize(){} // RVA: 0x7FFAC3510620
        public void ClearHistory(){} // RVA: 0x7FFAC48795F0
        public void Decay(){} // RVA: 0x7FFAC4879650
        public void Add(){} // RVA: 0x7FFAC48796A0
        public void PopBottom(){} // RVA: 0x7FFAC48798C0
        public void DecayHistory(){} // RVA: 0x7FFAC4879A80
        public void GetReliableHeading(){} // RVA: 0x7FFAC4879BD0
    }

    public class PositionPredictor : Object
    {
        public UnityEngine.Vector3 m_Velocity; // 0x10
        public UnityEngine.Vector3 m_SmoothDampVelocity; // 0x1C
        public UnityEngine.Vector3 m_Pos; // 0x28
        public bool m_HavePos; // 0x34
        public float Smoothing; // 0x38

        // ── Methods ──
        public void IsEmpty(){} // RVA: 0x7FFAC4878C50
        public void ApplyTransformDelta(){} // RVA: 0x7FFAC4878C60
        public void Reset(){} // RVA: 0x7FFAC4878CA0
        public void AddPosition(){} // RVA: 0x7FFAC4878D40
        public void PredictPositionDelta(){} // RVA: 0x7FFAC4878F10
        public void PredictPosition(){} // RVA: 0x7FFAC4878F50
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SplineHelpers : Object
    {
        // ── Methods ──
        public void Bezier3(){} // RVA: 0x7FFAC4879D60
        public void BezierTangent3(){} // RVA: 0x7FFAC4879EF0
        public void BezierTangentWeights3(){} // RVA: 0x7FFAC487A180
        public void Bezier1(){} // RVA: 0x7FFAC487A370
        public void BezierTangent1(){} // RVA: 0x7FFAC487A410
        public void ComputeSmoothControlPoints(){} // RVA: 0x7FFAC487A4F0
        public void ComputeSmoothControlPointsLooped(){} // RVA: 0x7FFAC487AE10
    }

    public class UnityQuaternionExtensions : Object
    {
        // ── Methods ──
        public void SlerpWithReferenceUp(){} // RVA: 0x7FFAC487C720
        public void Normalized(){} // RVA: 0x7FFAC487D140
        public void GetCameraRotationToTarget(){} // RVA: 0x7FFAC487D260
        public void ApplyCameraRotation(){} // RVA: 0x7FFAC487DD50
    }

    public class UnityRectExtensions : Object
    {
        // ── Methods ──
        public void Inflated(){} // RVA: 0x7FFAC487E0F0
    }

    public class UnityVectorExtensions : Object
    {
        public float Epsilon;

        // ── Methods ──
        public void IsNaN(){} // RVA: 0x7FFAC487B140 | overloaded x2
        public void ClosestPointOnSegment(){} // RVA: 0x7FFAC487B260 | overloaded x2
        public void ProjectOntoPlane(){} // RVA: 0x7FFAC487B310
        public void SquareNormalize(){} // RVA: 0x7FFAC487B3A0
        public void FindIntersection(){} // RVA: 0x7FFAC487B440
        public void Cross(){} // RVA: 0x7FFAC487B830
        public void Abs(){} // RVA: 0x7FFAC487B890 | overloaded x2
        public void IsUniform(){} // RVA: 0x7FFAC487B940 | overloaded x2
        public void AlmostZero(){} // RVA: 0x7FFAC487BA00
        public void ConservativeSetPositionAndRotation(){} // RVA: 0x7FFAC487BA40
        public void Angle(){} // RVA: 0x7FFAC487BCB0
        public void SignedAngle(){} // RVA: 0x7FFAC487BD90
        public void SafeFromToRotation(){} // RVA: 0x7FFAC487C060
        public void SlerpWithReferenceUp(){} // RVA: 0x7FFAC487C3A0
    }

}