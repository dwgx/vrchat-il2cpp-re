// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 7
// Methods: 84

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class RagdollUtility : MonoBehaviour
    {
        // ── Methods ──
        public void EnableRagdoll(){} // RVA: 0xCADEC0
        public void DisableRagdoll(){} // RVA: 0xCADEF0
        public void Start(){} // RVA: 0xCADFC0
        public void DisableRagdollSmooth(){} // RVA: 0xCAE8B0
        public void Update(){} // RVA: 0xCAE950
        public void FixedUpdate(){} // RVA: 0xCAED30
        public void LateUpdate(){} // RVA: 0xCAED70
        public void AfterLastIK(){} // RVA: 0xCAEEB0
        public void AfterAnimation(){} // RVA: 0xCAEF00
        public void OnFinalPose(){} // RVA: 0xCAEF40
        public void RagdollEnabler(){} // RVA: 0xCAEF80
        public void get_isRagdoll(){} // RVA: 0xCAF410
        public void RecordVelocities(){} // RVA: 0xCAF510
        public void get_ikUsed(){} // RVA: 0xCAF8E0
        public void StoreLocalState(){} // RVA: 0xCAFB30
        public void FixTransforms(){} // RVA: 0xCAFD00
        public void OnDestroy(){} // RVA: 0xCAFD70
        public void .ctor(){} // RVA: 0xCAFF80
    }

    public class Recoil : OffsetModifier
    {
        // ── Methods ──
        public void get_isFinished(){} // RVA: 0xCC2BD0
        public void SetHandRotations(){} // RVA: 0xCC2C30
        public void Fire(){} // RVA: 0xCC2C60
        public void OnModifyOffset(){} // RVA: 0xCC2FB0
        public void AfterFBBIK(){} // RVA: 0xCC4380
        public void AfterAimIK(){} // RVA: 0xCC4760
        public void get_primaryHandEffector(){} // RVA: 0xCC47B0
        public void get_secondaryHandEffector(){} // RVA: 0xCC4810
        public void get_primaryHand(){} // RVA: 0xCC4870
        public void get_secondaryHand(){} // RVA: 0xCC48E0
        public void OnDestroy(){} // RVA: 0xCC4950
        public void .ctor(){} // RVA: 0xCC4CC0
    }

    public class RotationLimit : MonoBehaviour
    {
        // ── Methods ──
        public void SetDefaultLocalRotation(){} // RVA: 0xCB1D80
        public void GetLimitedLocalRotation(){} // RVA: 0xCB1D90
        public void Apply(){} // RVA: 0xCB2160
        public void Disable(){} // RVA: 0xCB2310
        public void get_secondaryAxis(){} // RVA: 0xCB2340
        public void get_crossAxis(){} // RVA: 0xCB2360
        public void get_defaultLocalRotationOverride(){} // RVA: 0xCB23E0
        public void set_defaultLocalRotationOverride(){} // RVA: 0xCB23F0
        public void LimitRotation(){} // RVA: 0x87BF80
        public void Awake(){} // RVA: 0xCB2400
        public void LateUpdate(){} // RVA: 0xCB25D0
        public void LogWarning(){} // RVA: 0xBFAD40
        public void Limit1DOF(){} // RVA: 0xCB25E0
        public void LimitTwist(){} // RVA: 0xCB2920
        public void GetOrthogonalAngle(){} // RVA: 0xCB2F20
        public void .ctor(){} // RVA: 0xCB3000
    }

    public class RotationLimitAngle : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void LimitRotation(){} // RVA: 0xCB3090
        public void LimitSwing(){} // RVA: 0xCB3140
        public void .ctor(){} // RVA: 0xCB35C0
    }

    public class RotationLimitHinge : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void LimitRotation(){} // RVA: 0xCB35E0
        public void LimitHinge(){} // RVA: 0xCB3630
        public void .ctor(){} // RVA: 0xCB3B20
    }

    public class RotationLimitPolygonal : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void SetLimitPoints(){} // RVA: 0xCB3B80
        public void LimitRotation(){} // RVA: 0xCB3C60
        public void Start(){} // RVA: 0xCB3D40
        public void ResetToDefault(){} // RVA: 0xCB3F70
        public void BuildReachCones(){} // RVA: 0xCB4DA0
        public void SmoothPoints(){} // RVA: 0xCB5590
        public void GetScalar(){} // RVA: 0xCB5C30
        public void PointToTangentPlane(){} // RVA: 0xCB5C80
        public void TangentPointToSphere(){} // RVA: 0xCB5D60
        public void LimitSwing(){} // RVA: 0xCB5E80
        public void GetReachCone(){} // RVA: 0xCB64B0
        public void .ctor(){} // RVA: 0xCB65F0
    }

    public class RotationLimitSpline : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void SetSpline(){} // RVA: 0xCB6CF0
        public void LimitRotation(){} // RVA: 0xCB6D10
        public void LimitSwing(){} // RVA: 0xCB6DC0
        public void .ctor(){} // RVA: 0xCB7440
    }

}