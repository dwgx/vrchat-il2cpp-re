// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion
// Classes: 22
// Methods: 214

namespace ThirdParty.Other.RootMotion
{
    public class AvatarUtility : Object
    {
        // ── Methods ──
        public void GetPostRotation(){} // RVA: 0x7FFD4E380AF0
        public void GetIKGoalTQ(){} // RVA: 0x7FFD4E380E10
        public void HumanIDFromAvatarIKGoal(){} // RVA: 0x7FFD4E381990
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class AxisTools : Object
    {
        // ── Methods ──
        public void ToVector3(){} // RVA: 0x7FFD4E388B70
        public void ToAxis(){} // RVA: 0x7FFD4E388C60
        public void GetAxisToPoint(){} // RVA: 0x7FFD4E388CB0
        public void GetAxisToDirection(){} // RVA: 0x7FFD4E388E20
        public void GetAxisVectorToPoint(){} // RVA: 0x7FFD4E389000
        public void GetAxisVectorToDirection(){} // RVA: 0x7FFD4E389250 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Baker : MonoBehaviour
    {
        public object isBaking;
        public object bakingProgress;
        public object clipLength;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void get_isBaking(){} // RVA: 0x7FFD4E36A020
        public void set_isBaking(){} // RVA: 0x7FFD4E36A030
        public void get_bakingProgress(){} // RVA: 0x7FFD4E36A040
        public void set_bakingProgress(){} // RVA: 0x7FFD4E36A050
        public void GetCharacterRoot(){} // RVA: 0x7FFD4E078E90
        public void OnStartBaking(){} // RVA: 0x7FFD4E090980
        public void OnSetLoopFrame(){} // RVA: 0x7FFD4E09E480
        public void OnSetCurves(){} // RVA: 0x7FFD4E090A40
        public void OnSetKeyframes(){}
        public void get_clipLength(){} // RVA: 0x7FFD4E36A0E0
        public void set_clipLength(){} // RVA: 0x7FFD4E36A0F0
        public void BakeClip(){} // RVA: 0x7FFD4E341310
        public void StartBaking(){} // RVA: 0x7FFD4E341310
        public void StopBaking(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E37F890
    }

    public class BakerUtilities : Object
    {
        // ── Methods ──
        public void ReduceKeyframes(){} // RVA: 0x7FFD4E3819D0
        public void GetReducedKeyframes(){} // RVA: 0x7FFD4E381A50
        public void SetLoopFrame(){} // RVA: 0x7FFD4E381E30
        public void SetTangentMode(){} // RVA: 0x7FFD4E341310
        public void EnsureQuaternionContinuity(){} // RVA: 0x7FFD4E381FF0
    }

    public class BipedLimbOrientations : Object
    {
        public object UMA;
        public object MaxBiped;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E389A50
        public void get_UMA(){} // RVA: 0x7FFD4E389BA0
        public void get_MaxBiped(){} // RVA: 0x7FFD4E38A010
    }

    public class BipedNaming : Object
    {
        // ── Methods ──
        public void GetBonesOfType(){} // RVA: 0x7FFD4E38A4C0
        public void GetBonesOfSide(){} // RVA: 0x7FFD4E38A6C0
        public void GetBonesOfTypeAndSide(){} // RVA: 0x7FFD4E38A8C0
        public void GetFirstBoneOfTypeAndSide(){} // RVA: 0x7FFD4E38A940
        public void GetNamingMatch(){} // RVA: 0x7FFD4E38A9E0
        public void GetBoneType(){} // RVA: 0x7FFD4E38ABD0
        public void GetBoneSide(){} // RVA: 0x7FFD4E38AD20
        public void GetBone(){} // RVA: 0x7FFD4E38ADB0
        public void isLeft(){} // RVA: 0x7FFD4E38AE40
        public void isRight(){} // RVA: 0x7FFD4E38B0F0
        public void isSpine(){} // RVA: 0x7FFD4E38B3A0
        public void isHead(){} // RVA: 0x7FFD4E38B570
        public void isArm(){} // RVA: 0x7FFD4E38B740
        public void isLeg(){} // RVA: 0x7FFD4E38B910
        public void isTail(){} // RVA: 0x7FFD4E38BAE0
        public void isEye(){} // RVA: 0x7FFD4E38BCB0
        public void isTypeExclude(){} // RVA: 0x7FFD4E38BE80
        public void matchesNaming(){} // RVA: 0x7FFD4E38BFD0
        public void excludesNaming(){} // RVA: 0x7FFD4E38C0E0
        public void matchesLastLetter(){} // RVA: 0x7FFD4E38C160
        public void LastLetterIs(){} // RVA: 0x7FFD4E38C260
        public void firstLetter(){} // RVA: 0x7FFD4E38C2D0
        public void lastLetter(){} // RVA: 0x7FFD4E38C330
        public void .cctor(){} // RVA: 0x7FFD4E38C3A0
    }

    public class BipedReferences : Object
    {
        public object isFilled;
        public object isEmpty;

        // ── Methods ──
        public void get_isFilled(){} // RVA: 0x7FFD4E38E6C0
        public void get_isEmpty(){} // RVA: 0x7FFD4E38EFC0
        public void IsEmpty(){} // RVA: 0x7FFD4E38EFE0
        public void Contains(){} // RVA: 0x7FFD4E38F8F0
        public void AutoDetectReferences(){} // RVA: 0x7FFD4E390670
        public void DetectReferencesByNaming(){} // RVA: 0x7FFD4E3909E0
        public void AssignHumanoidReferences(){} // RVA: 0x7FFD4E391850
        public void SetupError(){} // RVA: 0x7FFD4E3922F0
        public void SetupWarning(){} // RVA: 0x7FFD4E392470
        public void IsNeckBone(){} // RVA: 0x7FFD4E392560
        public void AddBoneToEyes(){} // RVA: 0x7FFD4E3927D0
        public void AddBoneToSpine(){} // RVA: 0x7FFD4E3929B0
        public void DetectLimb(){} // RVA: 0x7FFD4E392DE0
        public void AddBoneToHierarchy(){} // RVA: 0x7FFD4E3930B0
        public void LimbError(){} // RVA: 0x7FFD4E393200
        public void LimbWarning(){} // RVA: 0x7FFD4E393B00
        public void SpineError(){} // RVA: 0x7FFD4E393F00
        public void SpineWarning(){} // RVA: 0x7FFD4E341320
        public void EyesError(){} // RVA: 0x7FFD4E3944C0
        public void EyesWarning(){} // RVA: 0x7FFD4E341320
        public void RootHeightWarning(){} // RVA: 0x7FFD4E394790
        public void FacingAxisWarning(){} // RVA: 0x7FFD4E394BC0
        public void GetVerticalOffset(){} // RVA: 0x7FFD4E395030
        public void .ctor(){} // RVA: 0x7FFD4E395190
    }

    public class Comments : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class DemoGUIMessage : MonoBehaviour
    {
        // ── Methods ──
        public void OnGUI(){} // RVA: 0x7FFD4E3952C0
        public void .ctor(){} // RVA: 0x7FFD4E395450
    }

    public class GenericBaker : Baker
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E37FB30
        public void GetCharacterRoot(){} // RVA: 0x7FFD4E380010
        public void OnStartBaking(){} // RVA: 0x7FFD4E380020
        public void OnSetLoopFrame(){} // RVA: 0x7FFD4E3801D0
        public void OnSetCurves(){} // RVA: 0x7FFD4E3805E0
        public void OnSetKeyframes(){} // RVA: 0x7FFD4E380670
        public void IsIgnored(){} // RVA: 0x7FFD4E380700
        public void BakePosition(){} // RVA: 0x7FFD4E380890
        public void .ctor(){} // RVA: 0x7FFD4E380A20
    }

    public class Hierarchy : Object
    {
        // ── Methods ──
        public void HierarchyIsValid(){} // RVA: 0x7FFD4E3954A0
        public void ContainsDuplicate(){} // RVA: 0x7FFD4E395520
        public void IsAncestor(){} // RVA: 0x7FFD4E3956D0
        public void ContainsChild(){} // RVA: 0x7FFD4E395A00
        public void AddAncestors(){} // RVA: 0x7FFD4E395C90
        public void GetAncestor(){} // RVA: 0x7FFD4E396220
        public void GetFirstCommonAncestor(){} // RVA: 0x7FFD4E396800 | overloaded x2
        public void GetFirstCommonAncestorRecursive(){} // RVA: 0x7FFD4E396A10
        public void IsCommonAncestor(){} // RVA: 0x7FFD4E396CC0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class HumanoidBaker : Baker
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E386E90
        public void OnDestroy(){} // RVA: 0x7FFD4E387A20
        public void GetCharacterRoot(){} // RVA: 0x7FFD4E387A40
        public void OnStartBaking(){} // RVA: 0x7FFD4E387AA0
        public void OnSetLoopFrame(){} // RVA: 0x7FFD4E387BD0
        public void OnSetCurves(){} // RVA: 0x7FFD4E387EF0
        public void OnSetKeyframes(){} // RVA: 0x7FFD4E3881B0
        public void UpdateHumanPose(){} // RVA: 0x7FFD4E388960
        public void .ctor(){} // RVA: 0x7FFD4E388A50
    }

    public class InspectorComment : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E397160 | overloaded x2
    }

    public class Interp : Object
    {
        // ── Methods ──
        public void Float(){} // RVA: 0x7FFD4E3972B0
        public void V3(){} // RVA: 0x7FFD4E3978D0
        public void LerpValue(){} // RVA: 0x7FFD4E397980
        public void None(){} // RVA: 0x7FFD4E397AA0
        public void InOutCubic(){} // RVA: 0x7FFD4E397AB0
        public void InOutQuintic(){} // RVA: 0x7FFD4E397AE0
        public void InQuintic(){} // RVA: 0x7FFD4E397B30
        public void InQuartic(){} // RVA: 0x7FFD4E397B50
        public void InCubic(){} // RVA: 0x7FFD4E397B70
        public void InQuadratic(){} // RVA: 0x7FFD4E397B90
        public void OutQuintic(){} // RVA: 0x7FFD4E397BA0
        public void OutQuartic(){} // RVA: 0x7FFD4E397C10
        public void OutCubic(){} // RVA: 0x7FFD4E397C70
        public void OutInCubic(){} // RVA: 0x7FFD4E397CB0
        public void OutInQuartic(){} // RVA: 0x7FFD4E397CF0
        public void BackInCubic(){} // RVA: 0x7FFD4E397D30
        public void BackInQuartic(){} // RVA: 0x7FFD4E397D60
        public void OutBackCubic(){} // RVA: 0x7FFD4E397DA0
        public void OutBackQuartic(){} // RVA: 0x7FFD4E397DE0
        public void OutElasticSmall(){} // RVA: 0x7FFD4E397E30
        public void OutElasticBig(){} // RVA: 0x7FFD4E397EB0
        public void InElasticSmall(){} // RVA: 0x7FFD4E397F30
        public void InElasticBig(){} // RVA: 0x7FFD4E397F90
        public void InSine(){} // RVA: 0x7FFD4E397FF0
        public void OutSine(){} // RVA: 0x7FFD4E398040
        public void InOutSine(){} // RVA: 0x7FFD4E398080
        public void InElastic(){} // RVA: 0x7FFD4E3980E0
        public void OutElastic(){} // RVA: 0x7FFD4E3981B0
        public void InBack(){} // RVA: 0x7FFD4E398270
        public void OutBack(){} // RVA: 0x7FFD4E3982A0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class LargeHeader : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E398430 | overloaded x2
    }

    public class LayerMaskExtensions : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x7FFD4E398580
        public void Create(){} // RVA: 0x7FFD4E3985A0 | overloaded x2
        public void NamesToMask(){} // RVA: 0x7FFD4E3985F0
        public void LayerNumbersToMask(){} // RVA: 0x7FFD4E3985A0
        public void Inverse(){} // RVA: 0x7FFD4E3986A0
        public void AddToMask(){} // RVA: 0x7FFD4E3986B0
        public void RemoveFromMask(){} // RVA: 0x7FFD4E398770
        public void MaskToNames(){} // RVA: 0x7FFD4E398830
        public void MaskToNumbers(){} // RVA: 0x7FFD4E398930
        public void MaskToString(){} // RVA: 0x7FFD4E398A60 | overloaded x2
    }

    public class QuaTools : Object
    {
        // ── Methods ──
        public void Lerp(){} // RVA: 0x7FFD4E398C20
        public void Slerp(){} // RVA: 0x7FFD4E398CE0
        public void LinearBlend(){} // RVA: 0x7FFD4E398DA0
        public void SphericalBlend(){} // RVA: 0x7FFD4E398EE0
        public void FromToAroundAxis(){} // RVA: 0x7FFD4E399020
        public void RotationToLocalSpace(){} // RVA: 0x7FFD4E399240
        public void FromToRotation(){} // RVA: 0x7FFD4E3994A0
        public void GetAxis(){} // RVA: 0x7FFD4E399720
        public void ClampRotation(){} // RVA: 0x7FFD4E3999E0
        public void ClampAngle(){} // RVA: 0x7FFD4E399CB0
        public void MatchRotation(){} // RVA: 0x7FFD4E399E10
        public void ToBiPolar(){} // RVA: 0x7FFD4E39A2E0 | overloaded x2
    }

    public class Singleton`1 : MonoBehaviour
    {
        public object instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFD4E2ADC40
        public void Awake(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class SolverManager : MonoBehaviour
    {
        public object animatePhysics;
        public object isAnimated;

        // ── Methods ──
        public void Disable(){} // RVA: 0x7FFD4E39A330
        public void InitiateSolver(){} // RVA: 0x7FFD4E341310
        public void UpdateSolver(){} // RVA: 0x7FFD4E341310
        public void FixTransforms(){} // RVA: 0x7FFD4E341310
        public void OnDisable(){} // RVA: 0x7FFD4E39A430
        public void Start(){} // RVA: 0x7FFD4E39A4D0
        public void get_animatePhysics(){} // RVA: 0x7FFD4E39A4E0
        public void Initiate(){} // RVA: 0x7FFD4E39A700
        public void Update(){} // RVA: 0x7FFD4E39A780
        public void FindAnimatorRecursive(){} // RVA: 0x7FFD4E39A880
        public void get_isAnimated(){} // RVA: 0x7FFD4E39AC50
        public void FixedUpdate(){} // RVA: 0x7FFD4E39ADD0
        public void LateUpdate(){} // RVA: 0x7FFD4E39AE20
        public void UpdateSolverExternal(){} // RVA: 0x7FFD4E39AF30
        public void .ctor(){} // RVA: 0x7FFD4E39B060
    }

    public class TriggerEventBroadcaster : MonoBehaviour
    {
        // ── Methods ──
        public void OnTriggerEnter(){} // RVA: 0x7FFD4E39B0B0
        public void OnTriggerStay(){} // RVA: 0x7FFD4E39B1D0
        public void OnTriggerExit(){} // RVA: 0x7FFD4E39B2F0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class V3Tools : Object
    {
        // ── Methods ──
        public void Lerp(){} // RVA: 0x7FFD4E39B410
        public void Slerp(){} // RVA: 0x7FFD4E39B4E0
        public void ExtractVertical(){} // RVA: 0x7FFD4E39B5D0
        public void ExtractHorizontal(){} // RVA: 0x7FFD4E39B790
        public void ClampDirection(){} // RVA: 0x7FFD4E39BD50 | overloaded x3
        public void LineToPlane(){} // RVA: 0x7FFD4E39BFD0
        public void PointToPlane(){} // RVA: 0x7FFD4E39C150
        public void TransformPointUnscaled(){} // RVA: 0x7FFD4E39C370
        public void InverseTransformPointUnscaled(){} // RVA: 0x7FFD4E39C650
    }

    public class Warning : Object
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7FFD4E39CA70 | overloaded x2
    }

}