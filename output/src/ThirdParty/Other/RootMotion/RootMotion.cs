// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion
// Classes: 27
// Methods: 243

namespace ThirdParty.Other.RootMotion
{
    public class AvatarUtility
    {
        // ── Methods ──
        public void GetPostRotation(){} // RVA: 0x7FFAF2DCCAF0
        public void GetIKGoalTQ(){} // RVA: 0x7FFAF2DCCE10
        public void HumanIDFromAvatarIKGoal(){} // RVA: 0x7FFAF2DCD990
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class AxisTools
    {
        // ── Methods ──
        public void ToVector3(){} // RVA: 0x7FFAF2DD4B70
        public void ToAxis(){} // RVA: 0x7FFAF2DD4C60
        public void GetAxisToPoint(){} // RVA: 0x7FFAF2DD4CB0
        public void GetAxisToDirection(){} // RVA: 0x7FFAF2DD4E20
        public void GetAxisVectorToPoint(){} // RVA: 0x7FFAF2DD5000
        public void GetAxisVectorToDirection(){} // RVA: 0x7FFAF2DD5250 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Baker
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAF2D8D310
        public void OpenScriptReference(){} // RVA: 0x7FFAF2D8D310
        public void SupportGroup(){} // RVA: 0x7FFAF2D8D310
        public void ASThread(){} // RVA: 0x7FFAF2D8D310
        public void get_isBaking(){} // RVA: 0x7FFAF2DB6020
        public void set_isBaking(){} // RVA: 0x7FFAF2DB6030
        public void get_bakingProgress(){} // RVA: 0x7FFAF2DB6040
        public void set_bakingProgress(){} // RVA: 0x7FFAF2DB6050
        public void GetCharacterRoot(){} // RVA: 0x7FFAF2ABCD60
        public void OnStartBaking(){} // RVA: 0x7FFAF2AD4A50
        public void OnSetLoopFrame(){} // RVA: 0x7FFAF2AE25B0
        public void OnSetCurves(){} // RVA: 0x7FFAF2AD4B10
        public void OnSetKeyframes(){}
        public void get_clipLength(){} // RVA: 0x7FFAF2DB60E0
        public void set_clipLength(){} // RVA: 0x7FFAF2DB60F0
        public void BakeClip(){} // RVA: 0x7FFAF2D8D310
        public void StartBaking(){} // RVA: 0x7FFAF2D8D310
        public void StopBaking(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2DCB890
    }

    public class BakerHumanoidQT
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DCE5C0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAF2DCE990
        public void SetIKKeyframes(){} // RVA: 0x7FFAF2DCEEB0
        public void SetKeyframes(){} // RVA: 0x7FFAF2DCF1A0
        public void MoveLastKeyframes(){} // RVA: 0x7FFAF2DCF2A0
        public void SetLoopFrame(){} // RVA: 0x7FFAF2DCF340
        public void MoveLastKeyframe(){} // RVA: 0x7FFAF2DCF3D0
        public void MultiplyLength(){} // RVA: 0x7FFAF2DCF4B0
        public void SetCurves(){} // RVA: 0x7FFAF2DCF5B0
    }

    public class BakerMuscle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DCFE20
        public void MuscleNameToPropertyName(){} // RVA: 0x7FFAF2DCFF00
        public void MultiplyLength(){} // RVA: 0x7FFAF2DCF4B0
        public void SetCurves(){} // RVA: 0x7FFAF2DD10A0
        public void Reset(){} // RVA: 0x7FFAF2DD1330
        public void SetKeyframe(){} // RVA: 0x7FFAF2DD1410
        public void SetLoopFrame(){} // RVA: 0x7FFAF2DD1450
    }

    public class BakerTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DD1460
        public void SetRelativeSpace(){} // RVA: 0x7FFAF2DD1590
        public void SetCurves(){} // RVA: 0x7FFAF2DD15B0
        public void AddRootMotionCurves(){} // RVA: 0x7FFAF2DD1A30
        public void Reset(){} // RVA: 0x7FFAF2DD1E60
        public void ReduceKeyframes(){} // RVA: 0x7FFAF2DD2340
        public void SetKeyframes(){} // RVA: 0x7FFAF2DD2680
        public void AddLoopFrame(){} // RVA: 0x7FFAF2DD2B00
    }

    public class BakerUtilities
    {
        // ── Methods ──
        public void ReduceKeyframes(){} // RVA: 0x7FFAF2DCD9D0
        public void GetReducedKeyframes(){} // RVA: 0x7FFAF2DCDA50
        public void SetLoopFrame(){} // RVA: 0x7FFAF2DCDE30
        public void SetTangentMode(){} // RVA: 0x7FFAF2D8D310
        public void EnsureQuaternionContinuity(){} // RVA: 0x7FFAF2DCDFF0
    }

    public class BipedLimbOrientations
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DD5A50
        public void get_UMA(){} // RVA: 0x7FFAF2DD5BA0
        public void get_MaxBiped(){} // RVA: 0x7FFAF2DD6010
    }

    public class BipedNaming
    {
        // ── Methods ──
        public void GetBonesOfType(){} // RVA: 0x7FFAF2DD64C0
        public void GetBonesOfSide(){} // RVA: 0x7FFAF2DD66C0
        public void GetBonesOfTypeAndSide(){} // RVA: 0x7FFAF2DD68C0
        public void GetFirstBoneOfTypeAndSide(){} // RVA: 0x7FFAF2DD6940
        public void GetNamingMatch(){} // RVA: 0x7FFAF2DD69E0
        public void GetBoneType(){} // RVA: 0x7FFAF2DD6BD0
        public void GetBoneSide(){} // RVA: 0x7FFAF2DD6D20
        public void GetBone(){} // RVA: 0x7FFAF2DD6DB0
        public void isLeft(){} // RVA: 0x7FFAF2DD6E40
        public void isRight(){} // RVA: 0x7FFAF2DD70F0
        public void isSpine(){} // RVA: 0x7FFAF2DD73A0
        public void isHead(){} // RVA: 0x7FFAF2DD7570
        public void isArm(){} // RVA: 0x7FFAF2DD7740
        public void isLeg(){} // RVA: 0x7FFAF2DD7910
        public void isTail(){} // RVA: 0x7FFAF2DD7AE0
        public void isEye(){} // RVA: 0x7FFAF2DD7CB0
        public void isTypeExclude(){} // RVA: 0x7FFAF2DD7E80
        public void matchesNaming(){} // RVA: 0x7FFAF2DD7FD0
        public void excludesNaming(){} // RVA: 0x7FFAF2DD80E0
        public void matchesLastLetter(){} // RVA: 0x7FFAF2DD8160
        public void LastLetterIs(){} // RVA: 0x7FFAF2DD8260
        public void firstLetter(){} // RVA: 0x7FFAF2DD82D0
        public void lastLetter(){} // RVA: 0x7FFAF2DD8330
        public void .cctor(){} // RVA: 0x7FFAF2DD83A0
    }

    public class BipedReferences
    {
        // ── Methods ──
        public void get_isFilled(){} // RVA: 0x7FFAF2DDA6C0
        public void get_isEmpty(){} // RVA: 0x7FFAF2DDAFC0
        public void IsEmpty(){} // RVA: 0x7FFAF2DDAFE0
        public void Contains(){} // RVA: 0x7FFAF2DDB8F0
        public void AutoDetectReferences(){} // RVA: 0x7FFAF2DDC670
        public void DetectReferencesByNaming(){} // RVA: 0x7FFAF2DDC9E0
        public void AssignHumanoidReferences(){} // RVA: 0x7FFAF2DDD850
        public void SetupError(){} // RVA: 0x7FFAF2DDE2F0
        public void SetupWarning(){} // RVA: 0x7FFAF2DDE470
        public void IsNeckBone(){} // RVA: 0x7FFAF2DDE560
        public void AddBoneToEyes(){} // RVA: 0x7FFAF2DDE7D0
        public void AddBoneToSpine(){} // RVA: 0x7FFAF2DDE9B0
        public void DetectLimb(){} // RVA: 0x7FFAF2DDEDE0
        public void AddBoneToHierarchy(){} // RVA: 0x7FFAF2DDF0B0
        public void LimbError(){} // RVA: 0x7FFAF2DDF200
        public void LimbWarning(){} // RVA: 0x7FFAF2DDFB00
        public void SpineError(){} // RVA: 0x7FFAF2DDFF00
        public void SpineWarning(){} // RVA: 0x7FFAF2D8D320
        public void EyesError(){} // RVA: 0x7FFAF2DE04C0
        public void EyesWarning(){} // RVA: 0x7FFAF2D8D320
        public void RootHeightWarning(){} // RVA: 0x7FFAF2DE0790
        public void FacingAxisWarning(){} // RVA: 0x7FFAF2DE0BC0
        public void GetVerticalOffset(){} // RVA: 0x7FFAF2DE1030
        public void .ctor(){} // RVA: 0x7FFAF2DE1190
    }

    public class Comments
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class DemoGUIMessage
    {
        // ── Methods ──
        public void OnGUI(){} // RVA: 0x7FFAF2DE12C0
        public void .ctor(){} // RVA: 0x7FFAF2DE1450
    }

    public class GenericBaker
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF2DCBB30
        public void GetCharacterRoot(){} // RVA: 0x7FFAF2DCC010
        public void OnStartBaking(){} // RVA: 0x7FFAF2DCC020
        public void OnSetLoopFrame(){} // RVA: 0x7FFAF2DCC1D0
        public void OnSetCurves(){} // RVA: 0x7FFAF2DCC5E0
        public void OnSetKeyframes(){} // RVA: 0x7FFAF2DCC670
        public void IsIgnored(){} // RVA: 0x7FFAF2DCC700
        public void BakePosition(){} // RVA: 0x7FFAF2DCC890
        public void .ctor(){} // RVA: 0x7FFAF2DCCA20
    }

    public class Hierarchy
    {
        // ── Methods ──
        public void HierarchyIsValid(){} // RVA: 0x7FFAF2DE14A0
        public void ContainsDuplicate(){} // RVA: 0x7FFAF2DE1520
        public void IsAncestor(){} // RVA: 0x7FFAF2DE16D0
        public void ContainsChild(){} // RVA: 0x7FFAF2DE1A00
        public void AddAncestors(){} // RVA: 0x7FFAF2DE1C90
        public void GetAncestor(){} // RVA: 0x7FFAF2DE2220
        public void GetFirstCommonAncestor(){} // RVA: 0x7FFAF2DE2800 | overloaded x2
        public void GetFirstCommonAncestorRecursive(){} // RVA: 0x7FFAF2DE2A10
        public void IsCommonAncestor(){} // RVA: 0x7FFAF2DE2CC0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class HumanoidBaker
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF2DD2E90
        public void OnDestroy(){} // RVA: 0x7FFAF2DD3A20
        public void GetCharacterRoot(){} // RVA: 0x7FFAF2DD3A40
        public void OnStartBaking(){} // RVA: 0x7FFAF2DD3AA0
        public void OnSetLoopFrame(){} // RVA: 0x7FFAF2DD3BD0
        public void OnSetCurves(){} // RVA: 0x7FFAF2DD3EF0
        public void OnSetKeyframes(){} // RVA: 0x7FFAF2DD41B0
        public void UpdateHumanPose(){} // RVA: 0x7FFAF2DD4960
        public void .ctor(){} // RVA: 0x7FFAF2DD4A50
    }

    public class InspectorComment
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DE3160 | overloaded x2
    }

    public class Interp
    {
        // ── Methods ──
        public void Float(){} // RVA: 0x7FFAF2DE32B0
        public void V3(){} // RVA: 0x7FFAF2DE38D0
        public void LerpValue(){} // RVA: 0x7FFAF2DE3980
        public void None(){} // RVA: 0x7FFAF2DE3AA0
        public void InOutCubic(){} // RVA: 0x7FFAF2DE3AB0
        public void InOutQuintic(){} // RVA: 0x7FFAF2DE3AE0
        public void InQuintic(){} // RVA: 0x7FFAF2DE3B30
        public void InQuartic(){} // RVA: 0x7FFAF2DE3B50
        public void InCubic(){} // RVA: 0x7FFAF2DE3B70
        public void InQuadratic(){} // RVA: 0x7FFAF2DE3B90
        public void OutQuintic(){} // RVA: 0x7FFAF2DE3BA0
        public void OutQuartic(){} // RVA: 0x7FFAF2DE3C10
        public void OutCubic(){} // RVA: 0x7FFAF2DE3C70
        public void OutInCubic(){} // RVA: 0x7FFAF2DE3CB0
        public void OutInQuartic(){} // RVA: 0x7FFAF2DE3CF0
        public void BackInCubic(){} // RVA: 0x7FFAF2DE3D30
        public void BackInQuartic(){} // RVA: 0x7FFAF2DE3D60
        public void OutBackCubic(){} // RVA: 0x7FFAF2DE3DA0
        public void OutBackQuartic(){} // RVA: 0x7FFAF2DE3DE0
        public void OutElasticSmall(){} // RVA: 0x7FFAF2DE3E30
        public void OutElasticBig(){} // RVA: 0x7FFAF2DE3EB0
        public void InElasticSmall(){} // RVA: 0x7FFAF2DE3F30
        public void InElasticBig(){} // RVA: 0x7FFAF2DE3F90
        public void InSine(){} // RVA: 0x7FFAF2DE3FF0
        public void OutSine(){} // RVA: 0x7FFAF2DE4040
        public void InOutSine(){} // RVA: 0x7FFAF2DE4080
        public void InElastic(){} // RVA: 0x7FFAF2DE40E0
        public void OutElastic(){} // RVA: 0x7FFAF2DE41B0
        public void InBack(){} // RVA: 0x7FFAF2DE4270
        public void OutBack(){} // RVA: 0x7FFAF2DE42A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class LargeHeader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DE4430 | overloaded x2
    }

    public class LayerMaskExtensions
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x7FFAF2DE4580
        public void Create(){} // RVA: 0x7FFAF2DE45A0 | overloaded x2
        public void NamesToMask(){} // RVA: 0x7FFAF2DE45F0
        public void LayerNumbersToMask(){} // RVA: 0x7FFAF2DE45A0
        public void Inverse(){} // RVA: 0x7FFAF2DE46A0
        public void AddToMask(){} // RVA: 0x7FFAF2DE46B0
        public void RemoveFromMask(){} // RVA: 0x7FFAF2DE4770
        public void MaskToNames(){} // RVA: 0x7FFAF2DE4830
        public void MaskToNumbers(){} // RVA: 0x7FFAF2DE4930
        public void MaskToString(){} // RVA: 0x7FFAF2DE4A60 | overloaded x2
    }

    public class QuaTools
    {
        // ── Methods ──
        public void Lerp(){} // RVA: 0x7FFAF2DE4C20
        public void Slerp(){} // RVA: 0x7FFAF2DE4CE0
        public void LinearBlend(){} // RVA: 0x7FFAF2DE4DA0
        public void SphericalBlend(){} // RVA: 0x7FFAF2DE4EE0
        public void FromToAroundAxis(){} // RVA: 0x7FFAF2DE5020
        public void RotationToLocalSpace(){} // RVA: 0x7FFAF2DE5240
        public void FromToRotation(){} // RVA: 0x7FFAF2DE54A0
        public void GetAxis(){} // RVA: 0x7FFAF2DE5720
        public void ClampRotation(){} // RVA: 0x7FFAF2DE59E0
        public void ClampAngle(){} // RVA: 0x7FFAF2DE5CB0
        public void MatchRotation(){} // RVA: 0x7FFAF2DE5E10
        public void ToBiPolar(){} // RVA: 0x7FFAF2DE62E0 | overloaded x2
    }

    public class Singleton`1
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAF2D33FA0
        public void Awake(){} // RVA: 0x7FFAF2AD4A50
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class Singleton`1
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAF6AD9B60
        public void Awake(){} // RVA: 0x7FFAF6AD9BB0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SolverManager
    {
        // ── Methods ──
        public void Disable(){} // RVA: 0x7FFAF2DE6330
        public void InitiateSolver(){} // RVA: 0x7FFAF2D8D310
        public void UpdateSolver(){} // RVA: 0x7FFAF2D8D310
        public void FixTransforms(){} // RVA: 0x7FFAF2D8D310
        public void OnDisable(){} // RVA: 0x7FFAF2DE6430
        public void Start(){} // RVA: 0x7FFAF2DE64D0
        public void get_animatePhysics(){} // RVA: 0x7FFAF2DE64E0
        public void Initiate(){} // RVA: 0x7FFAF2DE6700
        public void Update(){} // RVA: 0x7FFAF2DE6780
        public void FindAnimatorRecursive(){} // RVA: 0x7FFAF2DE6880
        public void get_isAnimated(){} // RVA: 0x7FFAF2DE6C50
        public void FixedUpdate(){} // RVA: 0x7FFAF2DE6DD0
        public void LateUpdate(){} // RVA: 0x7FFAF2DE6E20
        public void UpdateSolverExternal(){} // RVA: 0x7FFAF2DE6F30
        public void .ctor(){} // RVA: 0x7FFAF2DE7060
    }

    public class TQ
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DCCAD0
    }

    public class TriggerEventBroadcaster
    {
        // ── Methods ──
        public void OnTriggerEnter(){} // RVA: 0x7FFAF2DE70B0
        public void OnTriggerStay(){} // RVA: 0x7FFAF2DE71D0
        public void OnTriggerExit(){} // RVA: 0x7FFAF2DE72F0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class V3Tools
    {
        // ── Methods ──
        public void Lerp(){} // RVA: 0x7FFAF2DE7410
        public void Slerp(){} // RVA: 0x7FFAF2DE74E0
        public void ExtractVertical(){} // RVA: 0x7FFAF2DE75D0
        public void ExtractHorizontal(){} // RVA: 0x7FFAF2DE7790
        public void ClampDirection(){} // RVA: 0x7FFAF2DE7D50 | overloaded x3
        public void LineToPlane(){} // RVA: 0x7FFAF2DE7FD0
        public void PointToPlane(){} // RVA: 0x7FFAF2DE8150
        public void TransformPointUnscaled(){} // RVA: 0x7FFAF2DE8370
        public void InverseTransformPointUnscaled(){} // RVA: 0x7FFAF2DE8650
    }

    public class Warning
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7FFAF2DE8A70 | overloaded x2
    }

}