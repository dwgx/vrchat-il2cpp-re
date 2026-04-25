// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion
// Classes: 26
// Methods: 240

namespace ThirdParty.Other.RootMotion
{
    public class AvatarUtility : Object
    {
        // ── Methods ──
        public void GetPostRotation(){} // RVA: 0x7FFAC2F60AF0
        public void GetIKGoalTQ(){} // RVA: 0x7FFAC2F60E10
        public void HumanIDFromAvatarIKGoal(){} // RVA: 0x7FFAC2F61990
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AxisTools : Object
    {
        // ── Methods ──
        public void ToVector3(){} // RVA: 0x7FFAC2F68B70
        public void ToAxis(){} // RVA: 0x7FFAC2F68C60
        public void GetAxisToPoint(){} // RVA: 0x7FFAC2F68CB0
        public void GetAxisToDirection(){} // RVA: 0x7FFAC2F68E20
        public void GetAxisVectorToPoint(){} // RVA: 0x7FFAC2F69000
        public void GetAxisVectorToDirection(){} // RVA: 0x7FFAC2F69250 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Baker : MonoBehaviour
    {
        public int isBaking; // 0x20
        public float bakingProgress; // 0x24
        public 0x6B1BC6B0 clipLength; // 0x28
        public UnityEngine.AnimationClip[] animationClips; // 0x30
        public string[] animationStates; // 0x38
        public bool loop; // 0x40
        public string saveToFolder; // 0x48
        public string appendName; // 0x50
        public string saveName; // 0x58
        public bool <isBaking>k__BackingField; // 0x60
        public float <bakingProgress>k__BackingField; // 0x64
        public UnityEngine.Animator animator; // 0x68
        public UnityEngine.Playables.PlayableDirector director; // 0x70
        public float <clipLength>k__BackingField; // 0x78

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void get_isBaking(){} // RVA: 0x7FFAC2F4A020
        public void set_isBaking(){} // RVA: 0x7FFAC2F4A030
        public void get_bakingProgress(){} // RVA: 0x7FFAC2F4A040
        public void set_bakingProgress(){} // RVA: 0x7FFAC2F4A050
        public void GetCharacterRoot(){} // RVA: 0x7FFAC2C58E90
        public void OnStartBaking(){} // RVA: 0x7FFAC2C70980
        public void OnSetLoopFrame(){} // RVA: 0x7FFAC2C7E480
        public void OnSetCurves(){} // RVA: 0x7FFAC2C70A40
        public void OnSetKeyframes(){}
        public void get_clipLength(){} // RVA: 0x7FFAC2F4A0E0
        public void set_clipLength(){} // RVA: 0x7FFAC2F4A0F0
        public void BakeClip(){} // RVA: 0x7FFAC2F21310
        public void StartBaking(){} // RVA: 0x7FFAC2F21310
        public void StopBaking(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F5F890
    }

    public class BakerHumanoidQT : Object
    {
        public UnityEngine.Transform transform; // 0x10
        public string Qx; // 0x18
        public string Qy; // 0x20
        public string Qz; // 0x28
        public string Qw; // 0x30
        public string Tx; // 0x38
        public string Ty; // 0x40
        public string Tz; // 0x48
        public UnityEngine.AnimationCurve rotX; // 0x50
        public UnityEngine.AnimationCurve rotY; // 0x58
        public UnityEngine.AnimationCurve rotZ; // 0x60
        public UnityEngine.AnimationCurve rotW; // 0x68
        public UnityEngine.AnimationCurve posX; // 0x70
        public UnityEngine.AnimationCurve posY; // 0x78
        public UnityEngine.AnimationCurve posZ; // 0x80
        public 0x6B29C648 goal; // 0x88
        public UnityEngine.Quaternion lastQ; // 0x8C
        public bool lastQSet; // 0x9C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F625C0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAC2F62990
        public void SetIKKeyframes(){} // RVA: 0x7FFAC2F62EB0
        public void SetKeyframes(){} // RVA: 0x7FFAC2F631A0
        public void MoveLastKeyframes(){} // RVA: 0x7FFAC2F632A0
        public void SetLoopFrame(){} // RVA: 0x7FFAC2F63340
        public void MoveLastKeyframe(){} // RVA: 0x7FFAC2F633D0
        public void MultiplyLength(){} // RVA: 0x7FFAC2F634B0
        public void SetCurves(){} // RVA: 0x7FFAC2F635B0
    }

    public class BakerMuscle : Object
    {
        public UnityEngine.AnimationCurve curve; // 0x10
        public int muscleIndex; // 0x18
        public string propertyName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F63E20
        public void MuscleNameToPropertyName(){} // RVA: 0x7FFAC2F63F00
        public void MultiplyLength(){} // RVA: 0x7FFAC2F634B0
        public void SetCurves(){} // RVA: 0x7FFAC2F650A0
        public void Reset(){} // RVA: 0x7FFAC2F65330
        public void SetKeyframe(){} // RVA: 0x7FFAC2F65410
        public void SetLoopFrame(){} // RVA: 0x7FFAC2F65450
    }

    public class BakerTransform : Object
    {
        public UnityEngine.Transform transform; // 0x10
        public UnityEngine.AnimationCurve posX; // 0x18
        public UnityEngine.AnimationCurve posY; // 0x20
        public UnityEngine.AnimationCurve posZ; // 0x28
        public UnityEngine.AnimationCurve rotX; // 0x30
        public UnityEngine.AnimationCurve rotY; // 0x38
        public UnityEngine.AnimationCurve rotZ; // 0x40
        public UnityEngine.AnimationCurve rotW; // 0x48
        public string relativePath; // 0x50
        public bool recordPosition; // 0x58
        public UnityEngine.Vector3 relativePosition; // 0x5C
        public bool isRootNode; // 0x68
        public UnityEngine.Quaternion relativeRotation; // 0x6C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F65460
        public void SetRelativeSpace(){} // RVA: 0x7FFAC2F65590
        public void SetCurves(){} // RVA: 0x7FFAC2F655B0
        public void AddRootMotionCurves(){} // RVA: 0x7FFAC2F65A30
        public void Reset(){} // RVA: 0x7FFAC2F65E60
        public void ReduceKeyframes(){} // RVA: 0x7FFAC2F66340
        public void SetKeyframes(){} // RVA: 0x7FFAC2F66680
        public void AddLoopFrame(){} // RVA: 0x7FFAC2F66B00
    }

    public class BakerUtilities : Object
    {
        // ── Methods ──
        public void ReduceKeyframes(){} // RVA: 0x7FFAC2F619D0
        public void GetReducedKeyframes(){} // RVA: 0x7FFAC2F61A50
        public void SetLoopFrame(){} // RVA: 0x7FFAC2F61E30
        public void SetTangentMode(){} // RVA: 0x7FFAC2F21310
        public void EnsureQuaternionContinuity(){} // RVA: 0x7FFAC2F61FF0
    }

    public class BipedLimbOrientations : Object
    {
        public LimbOrientation UMA; // 0x10
        public LimbOrientation MaxBiped; // 0x18
        public LimbOrientation leftLeg; // 0x20
        public LimbOrientation rightLeg; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F69A50
        public void get_UMA(){} // RVA: 0x7FFAC2F69BA0
        public void get_MaxBiped(){} // RVA: 0x7FFAC2F6A010
    }

    public class BipedNaming : Object
    {
        public string[] typeLeft;
        public string[] typeRight; // 0x8
        public string[] typeSpine; // 0x10
        public string[] typeHead; // 0x18
        public string[] typeArm; // 0x20
        public string[] typeLeg; // 0x28
        public string[] typeTail; // 0x30
        public string[] typeEye; // 0x38
        public string[] typeExclude; // 0x40
        public string[] typeExcludeSpine; // 0x48
        public string[] typeExcludeHead; // 0x50
        public string[] typeExcludeArm; // 0x58
        public string[] typeExcludeLeg; // 0x60
        public string[] typeExcludeTail; // 0x68
        public string[] typeExcludeEye; // 0x70
        public string[] pelvis; // 0x78
        public string[] hand; // 0x80
        public string[] foot; // 0x88

        // ── Methods ──
        public void GetBonesOfType(){} // RVA: 0x7FFAC2F6A4C0
        public void GetBonesOfSide(){} // RVA: 0x7FFAC2F6A6C0
        public void GetBonesOfTypeAndSide(){} // RVA: 0x7FFAC2F6A8C0
        public void GetFirstBoneOfTypeAndSide(){} // RVA: 0x7FFAC2F6A940
        public void GetNamingMatch(){} // RVA: 0x7FFAC2F6A9E0
        public void GetBoneType(){} // RVA: 0x7FFAC2F6ABD0
        public void GetBoneSide(){} // RVA: 0x7FFAC2F6AD20
        public void GetBone(){} // RVA: 0x7FFAC2F6ADB0
        public void isLeft(){} // RVA: 0x7FFAC2F6AE40
        public void isRight(){} // RVA: 0x7FFAC2F6B0F0
        public void isSpine(){} // RVA: 0x7FFAC2F6B3A0
        public void isHead(){} // RVA: 0x7FFAC2F6B570
        public void isArm(){} // RVA: 0x7FFAC2F6B740
        public void isLeg(){} // RVA: 0x7FFAC2F6B910
        public void isTail(){} // RVA: 0x7FFAC2F6BAE0
        public void isEye(){} // RVA: 0x7FFAC2F6BCB0
        public void isTypeExclude(){} // RVA: 0x7FFAC2F6BE80
        public void matchesNaming(){} // RVA: 0x7FFAC2F6BFD0
        public void excludesNaming(){} // RVA: 0x7FFAC2F6C0E0
        public void matchesLastLetter(){} // RVA: 0x7FFAC2F6C160
        public void LastLetterIs(){} // RVA: 0x7FFAC2F6C260
        public void firstLetter(){} // RVA: 0x7FFAC2F6C2D0
        public void lastLetter(){} // RVA: 0x7FFAC2F6C330
        public void .cctor(){} // RVA: 0x7FFAC2F6C3A0
    }

    public class BipedReferences : Object
    {
        public UnityEngine.Transform isFilled; // 0x10
        public UnityEngine.Transform isEmpty; // 0x18
        public UnityEngine.Transform leftThigh; // 0x20
        public UnityEngine.Transform leftCalf; // 0x28
        public UnityEngine.Transform leftFoot; // 0x30
        public UnityEngine.Transform rightThigh; // 0x38
        public UnityEngine.Transform rightCalf; // 0x40
        public UnityEngine.Transform rightFoot; // 0x48
        public UnityEngine.Transform leftUpperArm; // 0x50
        public UnityEngine.Transform leftForearm; // 0x58
        public UnityEngine.Transform leftHand; // 0x60
        public UnityEngine.Transform rightUpperArm; // 0x68
        public UnityEngine.Transform rightForearm; // 0x70
        public UnityEngine.Transform rightHand; // 0x78
        public UnityEngine.Transform head; // 0x80
        public UnityEngine.Transform[] spine; // 0x88
        public UnityEngine.Transform[] eyes; // 0x90

        // ── Methods ──
        public void get_isFilled(){} // RVA: 0x7FFAC2F6E6C0
        public void get_isEmpty(){} // RVA: 0x7FFAC2F6EFC0
        public void IsEmpty(){} // RVA: 0x7FFAC2F6EFE0
        public void Contains(){} // RVA: 0x7FFAC2F6F8F0
        public void AutoDetectReferences(){} // RVA: 0x7FFAC2F70670
        public void DetectReferencesByNaming(){} // RVA: 0x7FFAC2F709E0
        public void AssignHumanoidReferences(){} // RVA: 0x7FFAC2F71850
        public void SetupError(){} // RVA: 0x7FFAC2F722F0
        public void SetupWarning(){} // RVA: 0x7FFAC2F72470
        public void IsNeckBone(){} // RVA: 0x7FFAC2F72560
        public void AddBoneToEyes(){} // RVA: 0x7FFAC2F727D0
        public void AddBoneToSpine(){} // RVA: 0x7FFAC2F729B0
        public void DetectLimb(){} // RVA: 0x7FFAC2F72DE0
        public void AddBoneToHierarchy(){} // RVA: 0x7FFAC2F730B0
        public void LimbError(){} // RVA: 0x7FFAC2F73200
        public void LimbWarning(){} // RVA: 0x7FFAC2F73B00
        public void SpineError(){} // RVA: 0x7FFAC2F73F00
        public void SpineWarning(){} // RVA: 0x7FFAC2F21320
        public void EyesError(){} // RVA: 0x7FFAC2F744C0
        public void EyesWarning(){} // RVA: 0x7FFAC2F21320
        public void RootHeightWarning(){} // RVA: 0x7FFAC2F74790
        public void FacingAxisWarning(){} // RVA: 0x7FFAC2F74BC0
        public void GetVerticalOffset(){} // RVA: 0x7FFAC2F75030
        public void .ctor(){} // RVA: 0x7FFAC2F75190
    }

    public class Comments : MonoBehaviour
    {
        public string text; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class DemoGUIMessage : MonoBehaviour
    {
        public string text; // 0x20
        public UnityEngine.Color color; // 0x28

        // ── Methods ──
        public void OnGUI(){} // RVA: 0x7FFAC2F752C0
        public void .ctor(){} // RVA: 0x7FFAC2F75450
    }

    public class GenericBaker : Baker
    {
        public bool markAsLegacy; // 0x80
        public UnityEngine.Transform root; // 0x88
        public UnityEngine.Transform rootNode; // 0x90
        public UnityEngine.Transform[] ignoreList; // 0x98
        public UnityEngine.Transform[] bakePositionList; // 0xA0
        public RootMotion.BakerTransform[] children; // 0xA8
        public RootMotion.BakerTransform rootChild; // 0xB0
        public int rootChildIndex; // 0xB8

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC2F5FB30
        public void GetCharacterRoot(){} // RVA: 0x7FFAC2F60010
        public void OnStartBaking(){} // RVA: 0x7FFAC2F60020
        public void OnSetLoopFrame(){} // RVA: 0x7FFAC2F601D0
        public void OnSetCurves(){} // RVA: 0x7FFAC2F605E0
        public void OnSetKeyframes(){} // RVA: 0x7FFAC2F60670
        public void IsIgnored(){} // RVA: 0x7FFAC2F60700
        public void BakePosition(){} // RVA: 0x7FFAC2F60890
        public void .ctor(){} // RVA: 0x7FFAC2F60A20
    }

    public class Hierarchy : Object
    {
        // ── Methods ──
        public void HierarchyIsValid(){} // RVA: 0x7FFAC2F754A0
        public void ContainsDuplicate(){} // RVA: 0x7FFAC2F75520
        public void IsAncestor(){} // RVA: 0x7FFAC2F756D0
        public void ContainsChild(){} // RVA: 0x7FFAC2F75A00
        public void AddAncestors(){} // RVA: 0x7FFAC2F75C90
        public void GetAncestor(){} // RVA: 0x7FFAC2F76220
        public void GetFirstCommonAncestor(){} // RVA: 0x7FFAC2F76800 | overloaded x2
        public void GetFirstCommonAncestorRecursive(){} // RVA: 0x7FFAC2F76A10
        public void IsCommonAncestor(){} // RVA: 0x7FFAC2F76CC0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HumanoidBaker : Baker
    {
        public bool bakeHandIK; // 0x80
        public float IKKeyReductionError; // 0x84
        public int muscleFrameRateDiv; // 0x88
        public RootMotion.BakerMuscle[] bakerMuscles; // 0x90
        public RootMotion.BakerHumanoidQT rootQT; // 0x98
        public RootMotion.BakerHumanoidQT leftFootQT; // 0xA0
        public RootMotion.BakerHumanoidQT rightFootQT; // 0xA8
        public RootMotion.BakerHumanoidQT leftHandQT; // 0xB0
        public RootMotion.BakerHumanoidQT rightHandQT; // 0xB8
        public float[] muscles; // 0xC0
        public UnityEngine.HumanPose pose; // 0xC8
        public UnityEngine.HumanPoseHandler handler; // 0xF0
        public UnityEngine.Vector3 bodyPosition; // 0xF8
        public UnityEngine.Quaternion bodyRotation; // 0x104
        public int mN; // 0x114
        public UnityEngine.Quaternion lastBodyRotation; // 0x118

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC2F66E90
        public void OnDestroy(){} // RVA: 0x7FFAC2F67A20
        public void GetCharacterRoot(){} // RVA: 0x7FFAC2F67A40
        public void OnStartBaking(){} // RVA: 0x7FFAC2F67AA0
        public void OnSetLoopFrame(){} // RVA: 0x7FFAC2F67BD0
        public void OnSetCurves(){} // RVA: 0x7FFAC2F67EF0
        public void OnSetKeyframes(){} // RVA: 0x7FFAC2F681B0
        public void UpdateHumanPose(){} // RVA: 0x7FFAC2F68960
        public void .ctor(){} // RVA: 0x7FFAC2F68A50
    }

    public class InspectorComment : PropertyAttribute
    {
        public string name; // 0x10
        public string color; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F77160 | overloaded x2
    }

    public class Interp : Object
    {
        // ── Methods ──
        public void Float(){} // RVA: 0x7FFAC2F772B0
        public void V3(){} // RVA: 0x7FFAC2F778D0
        public void LerpValue(){} // RVA: 0x7FFAC2F77980
        public void None(){} // RVA: 0x7FFAC2F77AA0
        public void InOutCubic(){} // RVA: 0x7FFAC2F77AB0
        public void InOutQuintic(){} // RVA: 0x7FFAC2F77AE0
        public void InQuintic(){} // RVA: 0x7FFAC2F77B30
        public void InQuartic(){} // RVA: 0x7FFAC2F77B50
        public void InCubic(){} // RVA: 0x7FFAC2F77B70
        public void InQuadratic(){} // RVA: 0x7FFAC2F77B90
        public void OutQuintic(){} // RVA: 0x7FFAC2F77BA0
        public void OutQuartic(){} // RVA: 0x7FFAC2F77C10
        public void OutCubic(){} // RVA: 0x7FFAC2F77C70
        public void OutInCubic(){} // RVA: 0x7FFAC2F77CB0
        public void OutInQuartic(){} // RVA: 0x7FFAC2F77CF0
        public void BackInCubic(){} // RVA: 0x7FFAC2F77D30
        public void BackInQuartic(){} // RVA: 0x7FFAC2F77D60
        public void OutBackCubic(){} // RVA: 0x7FFAC2F77DA0
        public void OutBackQuartic(){} // RVA: 0x7FFAC2F77DE0
        public void OutElasticSmall(){} // RVA: 0x7FFAC2F77E30
        public void OutElasticBig(){} // RVA: 0x7FFAC2F77EB0
        public void InElasticSmall(){} // RVA: 0x7FFAC2F77F30
        public void InElasticBig(){} // RVA: 0x7FFAC2F77F90
        public void InSine(){} // RVA: 0x7FFAC2F77FF0
        public void OutSine(){} // RVA: 0x7FFAC2F78040
        public void InOutSine(){} // RVA: 0x7FFAC2F78080
        public void InElastic(){} // RVA: 0x7FFAC2F780E0
        public void OutElastic(){} // RVA: 0x7FFAC2F781B0
        public void InBack(){} // RVA: 0x7FFAC2F78270
        public void OutBack(){} // RVA: 0x7FFAC2F782A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class LargeHeader : PropertyAttribute
    {
        public string name; // 0x10
        public string color; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F78430 | overloaded x2
    }

    public class LayerMaskExtensions : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x7FFAC2F78580
        public void Create(){} // RVA: 0x7FFAC2F785A0 | overloaded x2
        public void NamesToMask(){} // RVA: 0x7FFAC2F785F0
        public void LayerNumbersToMask(){} // RVA: 0x7FFAC2F785A0
        public void Inverse(){} // RVA: 0x7FFAC2F786A0
        public void AddToMask(){} // RVA: 0x7FFAC2F786B0
        public void RemoveFromMask(){} // RVA: 0x7FFAC2F78770
        public void MaskToNames(){} // RVA: 0x7FFAC2F78830
        public void MaskToNumbers(){} // RVA: 0x7FFAC2F78930
        public void MaskToString(){} // RVA: 0x7FFAC2F78A60 | overloaded x2
    }

    public class QuaTools : Object
    {
        // ── Methods ──
        public void Lerp(){} // RVA: 0x7FFAC2F78C20
        public void Slerp(){} // RVA: 0x7FFAC2F78CE0
        public void LinearBlend(){} // RVA: 0x7FFAC2F78DA0
        public void SphericalBlend(){} // RVA: 0x7FFAC2F78EE0
        public void FromToAroundAxis(){} // RVA: 0x7FFAC2F79020
        public void RotationToLocalSpace(){} // RVA: 0x7FFAC2F79240
        public void FromToRotation(){} // RVA: 0x7FFAC2F794A0
        public void GetAxis(){} // RVA: 0x7FFAC2F79720
        public void ClampRotation(){} // RVA: 0x7FFAC2F799E0
        public void ClampAngle(){} // RVA: 0x7FFAC2F79CB0
        public void MatchRotation(){} // RVA: 0x7FFAC2F79E10
        public void ToBiPolar(){} // RVA: 0x7FFAC2F7A2E0 | overloaded x2
    }

    public class Singleton`1 : MonoBehaviour
    {
        public T instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAC2E8DC40
        public void Awake(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class SolverManager : MonoBehaviour
    {
        public System.Func`1<object> animatePhysics;
        public System.Action`3<string,string,object> isAnimated; // 0x8
        public bool fixTransforms; // 0x20
        public UnityEngine.Animator animator; // 0x28
        public UnityEngine.Animation legacy; // 0x30
        public bool updateFrame; // 0x38
        public bool componentInitiated; // 0x39
        public bool skipSolverUpdate; // 0x3A

        // ── Methods ──
        public void Disable(){} // RVA: 0x7FFAC2F7A330
        public void InitiateSolver(){} // RVA: 0x7FFAC2F21310
        public void UpdateSolver(){} // RVA: 0x7FFAC2F21310
        public void FixTransforms(){} // RVA: 0x7FFAC2F21310
        public void OnDisable(){} // RVA: 0x7FFAC2F7A430
        public void Start(){} // RVA: 0x7FFAC2F7A4D0
        public void get_animatePhysics(){} // RVA: 0x7FFAC2F7A4E0
        public void Initiate(){} // RVA: 0x7FFAC2F7A700
        public void Update(){} // RVA: 0x7FFAC2F7A780
        public void FindAnimatorRecursive(){} // RVA: 0x7FFAC2F7A880
        public void get_isAnimated(){} // RVA: 0x7FFAC2F7AC50
        public void FixedUpdate(){} // RVA: 0x7FFAC2F7ADD0
        public void LateUpdate(){} // RVA: 0x7FFAC2F7AE20
        public void UpdateSolverExternal(){} // RVA: 0x7FFAC2F7AF30
        public void .ctor(){} // RVA: 0x7FFAC2F7B060
    }

    public class TQ : Object
    {
        public UnityEngine.Vector3 t; // 0x10
        public UnityEngine.Quaternion q; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F60AD0
    }

    public class TriggerEventBroadcaster : MonoBehaviour
    {
        public UnityEngine.GameObject target; // 0x20

        // ── Methods ──
        public void OnTriggerEnter(){} // RVA: 0x7FFAC2F7B0B0
        public void OnTriggerStay(){} // RVA: 0x7FFAC2F7B1D0
        public void OnTriggerExit(){} // RVA: 0x7FFAC2F7B2F0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class V3Tools : Object
    {
        // ── Methods ──
        public void Lerp(){} // RVA: 0x7FFAC2F7B410
        public void Slerp(){} // RVA: 0x7FFAC2F7B4E0
        public void ExtractVertical(){} // RVA: 0x7FFAC2F7B5D0
        public void ExtractHorizontal(){} // RVA: 0x7FFAC2F7B790
        public void ClampDirection(){} // RVA: 0x7FFAC2F7BD50 | overloaded x3
        public void LineToPlane(){} // RVA: 0x7FFAC2F7BFD0
        public void PointToPlane(){} // RVA: 0x7FFAC2F7C150
        public void TransformPointUnscaled(){} // RVA: 0x7FFAC2F7C370
        public void InverseTransformPointUnscaled(){} // RVA: 0x7FFAC2F7C650
    }

    public class Warning : Object
    {
        public bool logged;

        // ── Methods ──
        public void Log(){} // RVA: 0x7FFAC2F7CA70 | overloaded x2
    }

}