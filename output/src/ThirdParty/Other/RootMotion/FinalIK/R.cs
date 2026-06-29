// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 7
// Methods: 84

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class RagdollUtility : MonoBehaviour
    {
        // ── Methods ──
        public void EnableRagdoll(){} // RVA: 0x7A8239480
        public void DisableRagdoll(){} // RVA: 0x7A82394E0
        public void Start(){} // RVA: 0x7A82395F0
        public void DisableRagdollSmooth(){} // RVA: 0x7A823A090
        public void Update(){} // RVA: 0x7A823A130
        public void FixedUpdate(){} // RVA: 0x7A823A470
        public void LateUpdate(){} // RVA: 0x7A823A4B0
        public void AfterLastIK(){} // RVA: 0x7A823A5F0
        public void AfterAnimation(){} // RVA: 0x7A823A640
        public void OnFinalPose(){} // RVA: 0x7A823A680
        public void RagdollEnabler(){} // RVA: 0x7A823A6C0
        public void get_isRagdoll(){} // RVA: 0x7A823AA50
        public void RecordVelocities(){} // RVA: 0x7A823AB40
        public void get_ikUsed(){} // RVA: 0x7A823AE30
        public void StoreLocalState(){} // RVA: 0x7A823B070
        public void FixTransforms(){} // RVA: 0x7A823B1D0
        public void OnDestroy(){} // RVA: 0x7A823B5B0
        public void .ctor(){} // RVA: 0x7A823B7C0
    }

    public class Recoil : OffsetModifier
    {
        // ── Methods ──
        public void get_isFinished(){} // RVA: 0x7A824DE90
        public void SetHandRotations(){} // RVA: 0x7A824DEF0
        public void Fire(){} // RVA: 0x7A824DF20
        public void OnModifyOffset(){} // RVA: 0x7A824E2A0
        public void AfterFBBIK(){} // RVA: 0x7A824F840
        public void AfterAimIK(){} // RVA: 0x7A824FB70
        public void get_primaryHandEffector(){} // RVA: 0x7A824FBC0
        public void get_secondaryHandEffector(){} // RVA: 0x7A824FC20
        public void get_primaryHand(){} // RVA: 0x7A824FC80
        public void get_secondaryHand(){} // RVA: 0x7A824FCF0
        public void OnDestroy(){} // RVA: 0x7A824FD60
        public void .ctor(){} // RVA: 0x7A82500D0
    }

    public class RotationLimit : MonoBehaviour
    {
        // ── Methods ──
        public void SetDefaultLocalRotation(){} // RVA: 0x7A823D0C0
        public void GetLimitedLocalRotation(){} // RVA: 0x7A823D0D0
        public void Apply(){} // RVA: 0x7A823D4A0
        public void Disable(){} // RVA: 0x7A823D650
        public void get_secondaryAxis(){} // RVA: 0x7A823D6F0
        public void get_crossAxis(){} // RVA: 0x7A823D710
        public void get_defaultLocalRotationOverride(){} // RVA: 0x7A823D790
        public void set_defaultLocalRotationOverride(){} // RVA: 0x7A823D7A0
        public void LimitRotation(){} // RVA: 0x7A7E00560
        public void Awake(){} // RVA: 0x7A823D7B0
        public void LateUpdate(){} // RVA: 0x7A823D970
        public void LogWarning(){} // RVA: 0x7A818D240
        public void Limit1DOF(){} // RVA: 0x7A823D980
        public void LimitTwist(){} // RVA: 0x7A823DCC0
        public void GetOrthogonalAngle(){} // RVA: 0x7A823E2C0
        public void .ctor(){} // RVA: 0x7A823E3A0
    }

    public class RotationLimitAngle : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void SupportGroup(){} // RVA: 0x7A80D7310
        public void ASThread(){} // RVA: 0x7A80D7310
        public void LimitRotation(){} // RVA: 0x7A823E430
        public void LimitSwing(){} // RVA: 0x7A823E4E0
        public void .ctor(){} // RVA: 0x7A823E960
    }

    public class RotationLimitHinge : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void SupportGroup(){} // RVA: 0x7A80D7310
        public void ASThread(){} // RVA: 0x7A80D7310
        public void LimitRotation(){} // RVA: 0x7A823E980
        public void LimitHinge(){} // RVA: 0x7A823E9D0
        public void .ctor(){} // RVA: 0x7A823EEC0
    }

    public class RotationLimitPolygonal : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void SupportGroup(){} // RVA: 0x7A80D7310
        public void ASThread(){} // RVA: 0x7A80D7310
        public void SetLimitPoints(){} // RVA: 0x7A823EF20
        public void LimitRotation(){} // RVA: 0x7A823EFE0
        public void Start(){} // RVA: 0x7A823F0C0
        public void ResetToDefault(){} // RVA: 0x7A823F2E0
        public void BuildReachCones(){} // RVA: 0x7A8240110
        public void SmoothPoints(){} // RVA: 0x7A8240900
        public void GetScalar(){} // RVA: 0x7A8240FA0
        public void PointToTangentPlane(){} // RVA: 0x7A8240FF0
        public void TangentPointToSphere(){} // RVA: 0x7A82410D0
        public void LimitSwing(){} // RVA: 0x7A82411F0
        public void GetReachCone(){} // RVA: 0x7A8241800
        public void .ctor(){} // RVA: 0x7A8241940
    }

    public class RotationLimitSpline : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void SupportGroup(){} // RVA: 0x7A80D7310
        public void ASThread(){} // RVA: 0x7A80D7310
        public void SetSpline(){} // RVA: 0x7A8242040
        public void LimitRotation(){} // RVA: 0x7A82420B0
        public void LimitSwing(){} // RVA: 0x7A8242160
        public void .ctor(){} // RVA: 0x7A8242780
    }

}