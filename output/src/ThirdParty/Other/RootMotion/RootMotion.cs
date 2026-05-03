// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion
// Classes: 26
// Methods: 240

namespace ThirdParty.Other.RootMotion
{
    public class AvatarUtility : Object
    {
        // ── Methods ──
        public void GetPostRotation(){} // RVA: 0x7FFE8113AAF0
        public void GetIKGoalTQ(){} // RVA: 0x7FFE8113AE10
        public void HumanIDFromAvatarIKGoal(){} // RVA: 0x7FFE8113B990
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AxisTools : Object
    {
        // ── Methods ──
        public void ToVector3(){} // RVA: 0x7FFE81142B70
        public void ToAxis(){} // RVA: 0x7FFE81142C60
        public void GetAxisToPoint(){} // RVA: 0x7FFE81142CB0
        public void GetAxisToDirection(){} // RVA: 0x7FFE81142E20
        public void GetAxisVectorToPoint(){} // RVA: 0x7FFE81143000
        public void GetAxisVectorToDirection(){} // RVA: 0x7FFE81143250 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Baker : MonoBehaviour
    {
        public int frameRate; // 0x20
        public float keyReductionError; // 0x24
        public 0x665B5F74 mode; // 0x28

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void get_isBaking(){} // RVA: 0x7FFE81124020
        public void set_isBaking(){} // RVA: 0x7FFE81124030
        public void get_bakingProgress(){} // RVA: 0x7FFE81124040
        public void set_bakingProgress(){} // RVA: 0x7FFE81124050
        public void GetCharacterRoot(){} // RVA: 0x7FFE80E2E2E0
        public void OnStartBaking(){} // RVA: 0x7FFE80E45FE0
        public void OnSetLoopFrame(){} // RVA: 0x7FFE80E53B80
        public void OnSetCurves(){} // RVA: 0x7FFE80E460A0
        public void OnSetKeyframes(){}
        public void get_clipLength(){} // RVA: 0x7FFE811240E0
        public void set_clipLength(){} // RVA: 0x7FFE811240F0
        public void BakeClip(){} // RVA: 0x7FFE810FB310
        public void StartBaking(){} // RVA: 0x7FFE810FB310
        public void StopBaking(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE81139890
    }

    public class BakerHumanoidQT : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8113C5C0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFE8113C990
        public void SetIKKeyframes(){} // RVA: 0x7FFE8113CEB0
        public void SetKeyframes(){} // RVA: 0x7FFE8113D1A0
        public void MoveLastKeyframes(){} // RVA: 0x7FFE8113D2A0
        public void SetLoopFrame(){} // RVA: 0x7FFE8113D340
        public void MoveLastKeyframe(){} // RVA: 0x7FFE8113D3D0
        public void MultiplyLength(){} // RVA: 0x7FFE8113D4B0
        public void SetCurves(){} // RVA: 0x7FFE8113D5B0
    }

    public class BakerMuscle : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8113DE20
        public void MuscleNameToPropertyName(){} // RVA: 0x7FFE8113DF00
        public void MultiplyLength(){} // RVA: 0x7FFE8113D4B0
        public void SetCurves(){} // RVA: 0x7FFE8113F0A0
        public void Reset(){} // RVA: 0x7FFE8113F330
        public void SetKeyframe(){} // RVA: 0x7FFE8113F410
        public void SetLoopFrame(){} // RVA: 0x7FFE8113F450
    }

    public class BakerTransform : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8113F460
        public void SetRelativeSpace(){} // RVA: 0x7FFE8113F590
        public void SetCurves(){} // RVA: 0x7FFE8113F5B0
        public void AddRootMotionCurves(){} // RVA: 0x7FFE8113FA30
        public void Reset(){} // RVA: 0x7FFE8113FE60
        public void ReduceKeyframes(){} // RVA: 0x7FFE81140340
        public void SetKeyframes(){} // RVA: 0x7FFE81140680
        public void AddLoopFrame(){} // RVA: 0x7FFE81140B00
    }

    public class BakerUtilities : Object
    {
        // ── Methods ──
        public void ReduceKeyframes(){} // RVA: 0x7FFE8113B9D0
        public void GetReducedKeyframes(){} // RVA: 0x7FFE8113BA50
        public void SetLoopFrame(){} // RVA: 0x7FFE8113BE30
        public void SetTangentMode(){} // RVA: 0x7FFE810FB310
        public void EnsureQuaternionContinuity(){} // RVA: 0x7FFE8113BFF0
    }

    public class BipedLimbOrientations : Object
    {
        public LimbOrientation leftArm; // 0x10
        public LimbOrientation rightArm; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81143A50
        public void get_UMA(){} // RVA: 0x7FFE81143BA0
        public void get_MaxBiped(){} // RVA: 0x7FFE81144010
    }

    public class BipedNaming : Object
    {
        // ── Methods ──
        public void GetBonesOfType(){} // RVA: 0x7FFE811444C0
        public void GetBonesOfSide(){} // RVA: 0x7FFE811446C0
        public void GetBonesOfTypeAndSide(){} // RVA: 0x7FFE811448C0
        public void GetFirstBoneOfTypeAndSide(){} // RVA: 0x7FFE81144940
        public void GetNamingMatch(){} // RVA: 0x7FFE811449E0
        public void GetBoneType(){} // RVA: 0x7FFE81144BD0
        public void GetBoneSide(){} // RVA: 0x7FFE81144D20
        public void GetBone(){} // RVA: 0x7FFE81144DB0
        public void isLeft(){} // RVA: 0x7FFE81144E40
        public void isRight(){} // RVA: 0x7FFE811450F0
        public void isSpine(){} // RVA: 0x7FFE811453A0
        public void isHead(){} // RVA: 0x7FFE81145570
        public void isArm(){} // RVA: 0x7FFE81145740
        public void isLeg(){} // RVA: 0x7FFE81145910
        public void isTail(){} // RVA: 0x7FFE81145AE0
        public void isEye(){} // RVA: 0x7FFE81145CB0
        public void isTypeExclude(){} // RVA: 0x7FFE81145E80
        public void matchesNaming(){} // RVA: 0x7FFE81145FD0
        public void excludesNaming(){} // RVA: 0x7FFE811460E0
        public void matchesLastLetter(){} // RVA: 0x7FFE81146160
        public void LastLetterIs(){} // RVA: 0x7FFE81146260
        public void firstLetter(){} // RVA: 0x7FFE811462D0
        public void lastLetter(){} // RVA: 0x7FFE81146330
        public void .cctor(){} // RVA: 0x7FFE811463A0
    }

    public class BipedReferences : Object
    {
        public UnityEngine.Transform root; // 0x10
        public UnityEngine.Transform pelvis; // 0x18

        // ── Methods ──
        public void get_isFilled(){} // RVA: 0x7FFE811486C0
        public void get_isEmpty(){} // RVA: 0x7FFE81148FC0
        public void IsEmpty(){} // RVA: 0x7FFE81148FE0
        public void Contains(){} // RVA: 0x7FFE811498F0
        public void AutoDetectReferences(){} // RVA: 0x7FFE8114A670
        public void DetectReferencesByNaming(){} // RVA: 0x7FFE8114A9E0
        public void AssignHumanoidReferences(){} // RVA: 0x7FFE8114B850
        public void SetupError(){} // RVA: 0x7FFE8114C2F0
        public void SetupWarning(){} // RVA: 0x7FFE8114C470
        public void IsNeckBone(){} // RVA: 0x7FFE8114C560
        public void AddBoneToEyes(){} // RVA: 0x7FFE8114C7D0
        public void AddBoneToSpine(){} // RVA: 0x7FFE8114C9B0
        public void DetectLimb(){} // RVA: 0x7FFE8114CDE0
        public void AddBoneToHierarchy(){} // RVA: 0x7FFE8114D0B0
        public void LimbError(){} // RVA: 0x7FFE8114D200
        public void LimbWarning(){} // RVA: 0x7FFE8114DB00
        public void SpineError(){} // RVA: 0x7FFE8114DF00
        public void SpineWarning(){} // RVA: 0x7FFE810FB320
        public void EyesError(){} // RVA: 0x7FFE8114E4C0
        public void EyesWarning(){} // RVA: 0x7FFE810FB320
        public void RootHeightWarning(){} // RVA: 0x7FFE8114E790
        public void FacingAxisWarning(){} // RVA: 0x7FFE8114EBC0
        public void GetVerticalOffset(){} // RVA: 0x7FFE8114F030
        public void .ctor(){} // RVA: 0x7FFE8114F190
    }

    public class Comments : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class DemoGUIMessage : MonoBehaviour
    {
        // ── Methods ──
        public void OnGUI(){} // RVA: 0x7FFE8114F2C0
        public void .ctor(){} // RVA: 0x7FFE8114F450
    }

    public class GenericBaker : Baker
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE81139B30
        public void GetCharacterRoot(){} // RVA: 0x7FFE8113A010
        public void OnStartBaking(){} // RVA: 0x7FFE8113A020
        public void OnSetLoopFrame(){} // RVA: 0x7FFE8113A1D0
        public void OnSetCurves(){} // RVA: 0x7FFE8113A5E0
        public void OnSetKeyframes(){} // RVA: 0x7FFE8113A670
        public void IsIgnored(){} // RVA: 0x7FFE8113A700
        public void BakePosition(){} // RVA: 0x7FFE8113A890
        public void .ctor(){} // RVA: 0x7FFE8113AA20
    }

    public class Hierarchy : Object
    {
        // ── Methods ──
        public void HierarchyIsValid(){} // RVA: 0x7FFE8114F4A0
        public void ContainsDuplicate(){} // RVA: 0x7FFE8114F520
        public void IsAncestor(){} // RVA: 0x7FFE8114F6D0
        public void ContainsChild(){} // RVA: 0x7FFE8114FA00
        public void AddAncestors(){} // RVA: 0x7FFE8114FC90
        public void GetAncestor(){} // RVA: 0x7FFE81150220
        public void GetFirstCommonAncestor(){} // RVA: 0x7FFE81150800 | overloaded x2
        public void GetFirstCommonAncestorRecursive(){} // RVA: 0x7FFE81150A10
        public void IsCommonAncestor(){} // RVA: 0x7FFE81150CC0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class HumanoidBaker : Baker
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE81140E90
        public void OnDestroy(){} // RVA: 0x7FFE81141A20
        public void GetCharacterRoot(){} // RVA: 0x7FFE81141A40
        public void OnStartBaking(){} // RVA: 0x7FFE81141AA0
        public void OnSetLoopFrame(){} // RVA: 0x7FFE81141BD0
        public void OnSetCurves(){} // RVA: 0x7FFE81141EF0
        public void OnSetKeyframes(){} // RVA: 0x7FFE811421B0
        public void UpdateHumanPose(){} // RVA: 0x7FFE81142960
        public void .ctor(){} // RVA: 0x7FFE81142A50
    }

    public class InspectorComment : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81151160 | overloaded x2
    }

    public class Interp : Object
    {
        // ── Methods ──
        public void Float(){} // RVA: 0x7FFE811512B0
        public void V3(){} // RVA: 0x7FFE811518D0
        public void LerpValue(){} // RVA: 0x7FFE81151980
        public void None(){} // RVA: 0x7FFE81151AA0
        public void InOutCubic(){} // RVA: 0x7FFE81151AB0
        public void InOutQuintic(){} // RVA: 0x7FFE81151AE0
        public void InQuintic(){} // RVA: 0x7FFE81151B30
        public void InQuartic(){} // RVA: 0x7FFE81151B50
        public void InCubic(){} // RVA: 0x7FFE81151B70
        public void InQuadratic(){} // RVA: 0x7FFE81151B90
        public void OutQuintic(){} // RVA: 0x7FFE81151BA0
        public void OutQuartic(){} // RVA: 0x7FFE81151C10
        public void OutCubic(){} // RVA: 0x7FFE81151C70
        public void OutInCubic(){} // RVA: 0x7FFE81151CB0
        public void OutInQuartic(){} // RVA: 0x7FFE81151CF0
        public void BackInCubic(){} // RVA: 0x7FFE81151D30
        public void BackInQuartic(){} // RVA: 0x7FFE81151D60
        public void OutBackCubic(){} // RVA: 0x7FFE81151DA0
        public void OutBackQuartic(){} // RVA: 0x7FFE81151DE0
        public void OutElasticSmall(){} // RVA: 0x7FFE81151E30
        public void OutElasticBig(){} // RVA: 0x7FFE81151EB0
        public void InElasticSmall(){} // RVA: 0x7FFE81151F30
        public void InElasticBig(){} // RVA: 0x7FFE81151F90
        public void InSine(){} // RVA: 0x7FFE81151FF0
        public void OutSine(){} // RVA: 0x7FFE81152040
        public void InOutSine(){} // RVA: 0x7FFE81152080
        public void InElastic(){} // RVA: 0x7FFE811520E0
        public void OutElastic(){} // RVA: 0x7FFE811521B0
        public void InBack(){} // RVA: 0x7FFE81152270
        public void OutBack(){} // RVA: 0x7FFE811522A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class LargeHeader : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81152430 | overloaded x2
    }

    public class LayerMaskExtensions : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x7FFE81152580
        public void Create(){} // RVA: 0x7FFE811525A0 | overloaded x2
        public void NamesToMask(){} // RVA: 0x7FFE811525F0
        public void LayerNumbersToMask(){} // RVA: 0x7FFE811525A0
        public void Inverse(){} // RVA: 0x7FFE811526A0
        public void AddToMask(){} // RVA: 0x7FFE811526B0
        public void RemoveFromMask(){} // RVA: 0x7FFE81152770
        public void MaskToNames(){} // RVA: 0x7FFE81152830
        public void MaskToNumbers(){} // RVA: 0x7FFE81152930
        public void MaskToString(){} // RVA: 0x7FFE81152A60 | overloaded x2
    }

    public class QuaTools : Object
    {
        // ── Methods ──
        public void Lerp(){} // RVA: 0x7FFE81152C20
        public void Slerp(){} // RVA: 0x7FFE81152CE0
        public void LinearBlend(){} // RVA: 0x7FFE81152DA0
        public void SphericalBlend(){} // RVA: 0x7FFE81152EE0
        public void FromToAroundAxis(){} // RVA: 0x7FFE81153020
        public void RotationToLocalSpace(){} // RVA: 0x7FFE81153240
        public void FromToRotation(){} // RVA: 0x7FFE811534A0
        public void GetAxis(){} // RVA: 0x7FFE81153720
        public void ClampRotation(){} // RVA: 0x7FFE811539E0
        public void ClampAngle(){} // RVA: 0x7FFE81153CB0
        public void MatchRotation(){} // RVA: 0x7FFE81153E10
        public void ToBiPolar(){} // RVA: 0x7FFE811542E0 | overloaded x2
    }

    public class Singleton`1 : MonoBehaviour
    {
        public T sInstance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFE810A1420
        public void Awake(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class SolverManager : MonoBehaviour
    {
        public System.Func`1<object> StatPerfBegin;
        public System.Action`3<string,string,object> StatPerfEnd; // 0x8

        // ── Methods ──
        public void Disable(){} // RVA: 0x7FFE81154330
        public void InitiateSolver(){} // RVA: 0x7FFE810FB310
        public void UpdateSolver(){} // RVA: 0x7FFE810FB310
        public void FixTransforms(){} // RVA: 0x7FFE810FB310
        public void OnDisable(){} // RVA: 0x7FFE81154430
        public void Start(){} // RVA: 0x7FFE811544D0
        public void get_animatePhysics(){} // RVA: 0x7FFE811544E0
        public void Initiate(){} // RVA: 0x7FFE81154700
        public void Update(){} // RVA: 0x7FFE81154780
        public void FindAnimatorRecursive(){} // RVA: 0x7FFE81154880
        public void get_isAnimated(){} // RVA: 0x7FFE81154C50
        public void FixedUpdate(){} // RVA: 0x7FFE81154DD0
        public void LateUpdate(){} // RVA: 0x7FFE81154E20
        public void UpdateSolverExternal(){} // RVA: 0x7FFE81154F30
        public void .ctor(){} // RVA: 0x7FFE81155060
    }

    public class TQ : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8113AAD0
    }

    public class TriggerEventBroadcaster : MonoBehaviour
    {
        // ── Methods ──
        public void OnTriggerEnter(){} // RVA: 0x7FFE811550B0
        public void OnTriggerStay(){} // RVA: 0x7FFE811551D0
        public void OnTriggerExit(){} // RVA: 0x7FFE811552F0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class V3Tools : Object
    {
        // ── Methods ──
        public void Lerp(){} // RVA: 0x7FFE81155410
        public void Slerp(){} // RVA: 0x7FFE811554E0
        public void ExtractVertical(){} // RVA: 0x7FFE811555D0
        public void ExtractHorizontal(){} // RVA: 0x7FFE81155790
        public void ClampDirection(){} // RVA: 0x7FFE81155D50 | overloaded x3
        public void LineToPlane(){} // RVA: 0x7FFE81155FD0
        public void PointToPlane(){} // RVA: 0x7FFE81156150
        public void TransformPointUnscaled(){} // RVA: 0x7FFE81156370
        public void InverseTransformPointUnscaled(){} // RVA: 0x7FFE81156650
    }

    public class Warning : Object
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7FFE81156A70 | overloaded x2
    }

}