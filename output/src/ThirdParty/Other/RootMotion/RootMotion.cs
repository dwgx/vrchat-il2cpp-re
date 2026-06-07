// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion
// Classes: 26
// Methods: 240

namespace ThirdParty.Other.RootMotion
{
    public class AvatarUtility
    {
        // ── Methods ──
        public void GetPostRotation(){} // RVA: 0x31CAF0
        public void GetIKGoalTQ(){} // RVA: 0x31CE10
        public void HumanIDFromAvatarIKGoal(){} // RVA: 0x31D990
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class AxisTools
    {
        // ── Methods ──
        public void ToVector3(){} // RVA: 0x324B70
        public void ToAxis(){} // RVA: 0x324C60
        public void GetAxisToPoint(){} // RVA: 0x324CB0
        public void GetAxisToDirection(){} // RVA: 0x324E20
        public void GetAxisVectorToPoint(){} // RVA: 0x325000
        public void GetAxisVectorToDirection(){} // RVA: 0x325250 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Baker
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void get_isBaking(){} // RVA: 0x306020
        public void set_isBaking(){} // RVA: 0x306030
        public void get_bakingProgress(){} // RVA: 0x306040
        public void set_bakingProgress(){} // RVA: 0x306050
        public void GetCharacterRoot(){} // RVA: 0xCD60
        public void OnStartBaking(){} // RVA: 0x24A50
        public void OnSetLoopFrame(){} // RVA: 0x325B0
        public void OnSetCurves(){} // RVA: 0x24B10
        public void OnSetKeyframes(){}
        public void get_clipLength(){} // RVA: 0x3060E0
        public void set_clipLength(){} // RVA: 0x3060F0
        public void BakeClip(){} // RVA: 0x2DD310
        public void StartBaking(){} // RVA: 0x2DD310
        public void StopBaking(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x31B890
    }

    public class BakerHumanoidQT
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x31E5C0 | overloaded x2
        public void Reset(){} // RVA: 0x31E990
        public void SetIKKeyframes(){} // RVA: 0x31EEB0
        public void SetKeyframes(){} // RVA: 0x31F1A0
        public void MoveLastKeyframes(){} // RVA: 0x31F2A0
        public void SetLoopFrame(){} // RVA: 0x31F340
        public void MoveLastKeyframe(){} // RVA: 0x31F3D0
        public void MultiplyLength(){} // RVA: 0x31F4B0
        public void SetCurves(){} // RVA: 0x31F5B0
    }

    public class BakerMuscle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x31FE20
        public void MuscleNameToPropertyName(){} // RVA: 0x31FF00
        public void MultiplyLength(){} // RVA: 0x31F4B0
        public void SetCurves(){} // RVA: 0x3210A0
        public void Reset(){} // RVA: 0x321330
        public void SetKeyframe(){} // RVA: 0x321410
        public void SetLoopFrame(){} // RVA: 0x321450
    }

    public class BakerTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x321460
        public void SetRelativeSpace(){} // RVA: 0x321590
        public void SetCurves(){} // RVA: 0x3215B0
        public void AddRootMotionCurves(){} // RVA: 0x321A30
        public void Reset(){} // RVA: 0x321E60
        public void ReduceKeyframes(){} // RVA: 0x322340
        public void SetKeyframes(){} // RVA: 0x322680
        public void AddLoopFrame(){} // RVA: 0x322B00
    }

    public class BakerUtilities
    {
        // ── Methods ──
        public void ReduceKeyframes(){} // RVA: 0x31D9D0
        public void GetReducedKeyframes(){} // RVA: 0x31DA50
        public void SetLoopFrame(){} // RVA: 0x31DE30
        public void SetTangentMode(){} // RVA: 0x2DD310
        public void EnsureQuaternionContinuity(){} // RVA: 0x31DFF0
    }

    public class BipedLimbOrientations
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x325A50
        public void get_UMA(){} // RVA: 0x325BA0
        public void get_MaxBiped(){} // RVA: 0x326010
    }

    public class BipedNaming
    {
        // ── Methods ──
        public void GetBonesOfType(){} // RVA: 0x3264C0
        public void GetBonesOfSide(){} // RVA: 0x3266C0
        public void GetBonesOfTypeAndSide(){} // RVA: 0x3268C0
        public void GetFirstBoneOfTypeAndSide(){} // RVA: 0x326940
        public void GetNamingMatch(){} // RVA: 0x3269E0
        public void GetBoneType(){} // RVA: 0x326BD0
        public void GetBoneSide(){} // RVA: 0x326D20
        public void GetBone(){} // RVA: 0x326DB0
        public void isLeft(){} // RVA: 0x326E40
        public void isRight(){} // RVA: 0x3270F0
        public void isSpine(){} // RVA: 0x3273A0
        public void isHead(){} // RVA: 0x327570
        public void isArm(){} // RVA: 0x327740
        public void isLeg(){} // RVA: 0x327910
        public void isTail(){} // RVA: 0x327AE0
        public void isEye(){} // RVA: 0x327CB0
        public void isTypeExclude(){} // RVA: 0x327E80
        public void matchesNaming(){} // RVA: 0x327FD0
        public void excludesNaming(){} // RVA: 0x3280E0
        public void matchesLastLetter(){} // RVA: 0x328160
        public void LastLetterIs(){} // RVA: 0x328260
        public void firstLetter(){} // RVA: 0x3282D0
        public void lastLetter(){} // RVA: 0x328330
        public void .cctor(){} // RVA: 0x3283A0
    }

    public class BipedReferences
    {
        // ── Methods ──
        public void get_isFilled(){} // RVA: 0x32A6C0
        public void get_isEmpty(){} // RVA: 0x32AFC0
        public void IsEmpty(){} // RVA: 0x32AFE0
        public void Contains(){} // RVA: 0x32B8F0
        public void AutoDetectReferences(){} // RVA: 0x32C670
        public void DetectReferencesByNaming(){} // RVA: 0x32C9E0
        public void AssignHumanoidReferences(){} // RVA: 0x32D850
        public void SetupError(){} // RVA: 0x32E2F0
        public void SetupWarning(){} // RVA: 0x32E470
        public void IsNeckBone(){} // RVA: 0x32E560
        public void AddBoneToEyes(){} // RVA: 0x32E7D0
        public void AddBoneToSpine(){} // RVA: 0x32E9B0
        public void DetectLimb(){} // RVA: 0x32EDE0
        public void AddBoneToHierarchy(){} // RVA: 0x32F0B0
        public void LimbError(){} // RVA: 0x32F200
        public void LimbWarning(){} // RVA: 0x32FB00
        public void SpineError(){} // RVA: 0x32FF00
        public void SpineWarning(){} // RVA: 0x2DD320
        public void EyesError(){} // RVA: 0x3304C0
        public void EyesWarning(){} // RVA: 0x2DD320
        public void RootHeightWarning(){} // RVA: 0x330790
        public void FacingAxisWarning(){} // RVA: 0x330BC0
        public void GetVerticalOffset(){} // RVA: 0x331030
        public void .ctor(){} // RVA: 0x331190
    }

    public class Comments
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class DemoGUIMessage
    {
        // ── Methods ──
        public void OnGUI(){} // RVA: 0x3312C0
        public void .ctor(){} // RVA: 0x331450
    }

    public class GenericBaker
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x31BB30
        public void GetCharacterRoot(){} // RVA: 0x31C010
        public void OnStartBaking(){} // RVA: 0x31C020
        public void OnSetLoopFrame(){} // RVA: 0x31C1D0
        public void OnSetCurves(){} // RVA: 0x31C5E0
        public void OnSetKeyframes(){} // RVA: 0x31C670
        public void IsIgnored(){} // RVA: 0x31C700
        public void BakePosition(){} // RVA: 0x31C890
        public void .ctor(){} // RVA: 0x31CA20
    }

    public class Hierarchy
    {
        // ── Methods ──
        public void HierarchyIsValid(){} // RVA: 0x3314A0
        public void ContainsDuplicate(){} // RVA: 0x331520
        public void IsAncestor(){} // RVA: 0x3316D0
        public void ContainsChild(){} // RVA: 0x331A00
        public void AddAncestors(){} // RVA: 0x331C90
        public void GetAncestor(){} // RVA: 0x332220
        public void GetFirstCommonAncestor(){} // RVA: 0x332800 | overloaded x2
        public void GetFirstCommonAncestorRecursive(){} // RVA: 0x332A10
        public void IsCommonAncestor(){} // RVA: 0x332CC0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class HumanoidBaker
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x322E90
        public void OnDestroy(){} // RVA: 0x323A20
        public void GetCharacterRoot(){} // RVA: 0x323A40
        public void OnStartBaking(){} // RVA: 0x323AA0
        public void OnSetLoopFrame(){} // RVA: 0x323BD0
        public void OnSetCurves(){} // RVA: 0x323EF0
        public void OnSetKeyframes(){} // RVA: 0x3241B0
        public void UpdateHumanPose(){} // RVA: 0x324960
        public void .ctor(){} // RVA: 0x324A50
    }

    public class InspectorComment
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x333160 | overloaded x2
    }

    public class Interp
    {
        // ── Methods ──
        public void Float(){} // RVA: 0x3332B0
        public void V3(){} // RVA: 0x3338D0
        public void LerpValue(){} // RVA: 0x333980
        public void None(){} // RVA: 0x333AA0
        public void InOutCubic(){} // RVA: 0x333AB0
        public void InOutQuintic(){} // RVA: 0x333AE0
        public void InQuintic(){} // RVA: 0x333B30
        public void InQuartic(){} // RVA: 0x333B50
        public void InCubic(){} // RVA: 0x333B70
        public void InQuadratic(){} // RVA: 0x333B90
        public void OutQuintic(){} // RVA: 0x333BA0
        public void OutQuartic(){} // RVA: 0x333C10
        public void OutCubic(){} // RVA: 0x333C70
        public void OutInCubic(){} // RVA: 0x333CB0
        public void OutInQuartic(){} // RVA: 0x333CF0
        public void BackInCubic(){} // RVA: 0x333D30
        public void BackInQuartic(){} // RVA: 0x333D60
        public void OutBackCubic(){} // RVA: 0x333DA0
        public void OutBackQuartic(){} // RVA: 0x333DE0
        public void OutElasticSmall(){} // RVA: 0x333E30
        public void OutElasticBig(){} // RVA: 0x333EB0
        public void InElasticSmall(){} // RVA: 0x333F30
        public void InElasticBig(){} // RVA: 0x333F90
        public void InSine(){} // RVA: 0x333FF0
        public void OutSine(){} // RVA: 0x334040
        public void InOutSine(){} // RVA: 0x334080
        public void InElastic(){} // RVA: 0x3340E0
        public void OutElastic(){} // RVA: 0x3341B0
        public void InBack(){} // RVA: 0x334270
        public void OutBack(){} // RVA: 0x3342A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LargeHeader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x334430 | overloaded x2
    }

    public class LayerMaskExtensions
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x334580
        public void Create(){} // RVA: 0x3345A0 | overloaded x2
        public void NamesToMask(){} // RVA: 0x3345F0
        public void LayerNumbersToMask(){} // RVA: 0x3345A0
        public void Inverse(){} // RVA: 0x3346A0
        public void AddToMask(){} // RVA: 0x3346B0
        public void RemoveFromMask(){} // RVA: 0x334770
        public void MaskToNames(){} // RVA: 0x334830
        public void MaskToNumbers(){} // RVA: 0x334930
        public void MaskToString(){} // RVA: 0x334A60 | overloaded x2
    }

    public class QuaTools
    {
        // ── Methods ──
        public void Lerp(){} // RVA: 0x334C20
        public void Slerp(){} // RVA: 0x334CE0
        public void LinearBlend(){} // RVA: 0x334DA0
        public void SphericalBlend(){} // RVA: 0x334EE0
        public void FromToAroundAxis(){} // RVA: 0x335020
        public void RotationToLocalSpace(){} // RVA: 0x335240
        public void FromToRotation(){} // RVA: 0x3354A0
        public void GetAxis(){} // RVA: 0x335720
        public void ClampRotation(){} // RVA: 0x3359E0
        public void ClampAngle(){} // RVA: 0x335CB0
        public void MatchRotation(){} // RVA: 0x335E10
        public void ToBiPolar(){} // RVA: 0x3362E0 | overloaded x2
    }

    public class Singleton`1
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x283FA0
        public void Awake(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x24A50
    }

    public class SolverManager
    {
        // ── Methods ──
        public void Disable(){} // RVA: 0x336330
        public void InitiateSolver(){} // RVA: 0x2DD310
        public void UpdateSolver(){} // RVA: 0x2DD310
        public void FixTransforms(){} // RVA: 0x2DD310
        public void OnDisable(){} // RVA: 0x336430
        public void Start(){} // RVA: 0x3364D0
        public void get_animatePhysics(){} // RVA: 0x3364E0
        public void Initiate(){} // RVA: 0x336700
        public void Update(){} // RVA: 0x336780
        public void FindAnimatorRecursive(){} // RVA: 0x336880
        public void get_isAnimated(){} // RVA: 0x336C50
        public void FixedUpdate(){} // RVA: 0x336DD0
        public void LateUpdate(){} // RVA: 0x336E20
        public void UpdateSolverExternal(){} // RVA: 0x336F30
        public void .ctor(){} // RVA: 0x337060
    }

    public class TQ
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x31CAD0
    }

    public class TriggerEventBroadcaster
    {
        // ── Methods ──
        public void OnTriggerEnter(){} // RVA: 0x3370B0
        public void OnTriggerStay(){} // RVA: 0x3371D0
        public void OnTriggerExit(){} // RVA: 0x3372F0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class V3Tools
    {
        // ── Methods ──
        public void Lerp(){} // RVA: 0x337410
        public void Slerp(){} // RVA: 0x3374E0
        public void ExtractVertical(){} // RVA: 0x3375D0
        public void ExtractHorizontal(){} // RVA: 0x337790
        public void ClampDirection(){} // RVA: 0x337D50 | overloaded x3
        public void LineToPlane(){} // RVA: 0x337FD0
        public void PointToPlane(){} // RVA: 0x338150
        public void TransformPointUnscaled(){} // RVA: 0x338370
        public void InverseTransformPointUnscaled(){} // RVA: 0x338650
    }

    public class Warning
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x338A70 | overloaded x2
    }

}