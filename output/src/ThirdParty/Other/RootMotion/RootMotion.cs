// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion
// Classes: 30
// Methods: 277

namespace ThirdParty.Other.RootMotion
{
    public class AvatarUtility : Object
    {
        // ── Methods ──
        public void GetPostRotation(){} // RVA: 0xB81AD0
        public void GetIKGoalTQ(){} // RVA: 0xB81E00
        public void HumanIDFromAvatarIKGoal(){} // RVA: 0xB829A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AxisTools : Object
    {
        // ── Methods ──
        public void ToVector3(){} // RVA: 0xB89E50
        public void ToAxis(){} // RVA: 0xB89F40
        public void GetAxisToPoint(){} // RVA: 0xB89F90
        public void GetAxisToDirection(){} // RVA: 0xB8A100
        public void GetAxisVectorToPoint(){} // RVA: 0xB8A310
        public void GetAxisVectorToDirection(){} // RVA: 0xB8A620
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Baker : MonoBehaviour
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void get_isBaking(){} // RVA: 0xB6B1A0
        public void set_isBaking(){} // RVA: 0xB6B1B0
        public void get_bakingProgress(){} // RVA: 0xB6B1C0
        public void set_bakingProgress(){} // RVA: 0xB6B1D0
        public void GetCharacterRoot(){} // RVA: 0x87C0A0
        public void OnStartBaking(){} // RVA: 0x894290
        public void OnSetLoopFrame(){} // RVA: 0x8A23A0
        public void OnSetCurves(){} // RVA: 0x894320
        public void OnSetKeyframes(){} // RVA: 0x8A2460
        public void get_clipLength(){} // RVA: 0xB6B260
        public void set_clipLength(){} // RVA: 0xB6B270
        public void BakeClip(){} // RVA: 0xB43310
        public void StartBaking(){} // RVA: 0xB43310
        public void StopBaking(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB80C30
    }

    public class BakerHumanoidQT : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB83480
        public void Reset(){} // RVA: 0xB83850
        public void SetIKKeyframes(){} // RVA: 0xB83BF0
        public void SetKeyframes(){} // RVA: 0xB84190
        public void MoveLastKeyframes(){} // RVA: 0xB844E0
        public void SetLoopFrame(){} // RVA: 0xB84700
        public void MoveLastKeyframe(){} // RVA: 0xB84790
        public void MultiplyLength(){} // RVA: 0xB847F0
        public void SetCurves(){} // RVA: 0xB84940
    }

    public class BakerMuscle : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB84F00
        public void MuscleNameToPropertyName(){} // RVA: 0xB84FE0
        public void MultiplyLength(){} // RVA: 0xB847F0
        public void SetCurves(){} // RVA: 0xB86180
        public void Reset(){} // RVA: 0xB863E0
        public void SetKeyframe(){} // RVA: 0xB86490
        public void SetLoopFrame(){} // RVA: 0xB86540
    }

    public class BakerMuscle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class BakerTransform : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB86550
        public void SetRelativeSpace(){} // RVA: 0xB86630
        public void SetCurves(){} // RVA: 0xB86650
        public void AddRootMotionCurves(){} // RVA: 0xB86AF0
        public void Reset(){} // RVA: 0xB86F00
        public void ReduceKeyframes(){} // RVA: 0xB87260
        public void SetKeyframes(){} // RVA: 0xB873E0
        public void AddLoopFrame(){} // RVA: 0xB87B90
    }

    public class BakerTransform[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class BakerUtilities : Object
    {
        // ── Methods ──
        public void ReduceKeyframes(){} // RVA: 0xB829E0
        public void GetReducedKeyframes(){} // RVA: 0xB82A20
        public void SetLoopFrame(){} // RVA: 0xB82D80
        public void SetTangentMode(){} // RVA: 0xB43310
        public void EnsureQuaternionContinuity(){} // RVA: 0xB82EC0
    }

    public class BipedLimbOrientations : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB8AE10
        public void get_UMA(){} // RVA: 0xB8AF60
        public void get_MaxBiped(){} // RVA: 0xB8B3D0
    }

    public class BipedNaming : Object
    {
        // ── Methods ──
        public void GetBonesOfType(){} // RVA: 0xB8B880
        public void GetBonesOfSide(){} // RVA: 0xB8BAA0
        public void GetBonesOfTypeAndSide(){} // RVA: 0xB8BCC0
        public void GetFirstBoneOfTypeAndSide(){} // RVA: 0xB8BD40
        public void GetNamingMatch(){} // RVA: 0xB8BDE0
        public void GetBoneType(){} // RVA: 0xB8C000
        public void GetBoneSide(){} // RVA: 0xB8C150
        public void GetBone(){} // RVA: 0xB8C1E0
        public void isLeft(){} // RVA: 0xB8C270
        public void isRight(){} // RVA: 0xB8C4E0
        public void isSpine(){} // RVA: 0xB8C750
        public void isHead(){} // RVA: 0xB8C920
        public void isArm(){} // RVA: 0xB8CAF0
        public void isLeg(){} // RVA: 0xB8CCC0
        public void isTail(){} // RVA: 0xB8CE90
        public void isEye(){} // RVA: 0xB8D060
        public void isTypeExclude(){} // RVA: 0xB8D230
        public void matchesNaming(){} // RVA: 0xB8D380
        public void excludesNaming(){} // RVA: 0xB8D490
        public void matchesLastLetter(){} // RVA: 0xB8D510
        public void LastLetterIs(){} // RVA: 0xB8D620
        public void firstLetter(){} // RVA: 0xB8D690
        public void lastLetter(){} // RVA: 0xB8D770
        public void .cctor(){} // RVA: 0xB8D7E0
    }

    public class BipedReferences : Object
    {
        // ── Methods ──
        public void get_isFilled(){} // RVA: 0xB8FA00
        public void get_isEmpty(){} // RVA: 0xB90310
        public void IsEmpty(){} // RVA: 0xB90330
        public void Contains(){} // RVA: 0xB90C40
        public void AutoDetectReferences(){} // RVA: 0xB919D0
        public void DetectReferencesByNaming(){} // RVA: 0xB91D00
        public void AssignHumanoidReferences(){} // RVA: 0xB92B30
        public void SetupError(){} // RVA: 0xB935A0
        public void SetupWarning(){} // RVA: 0xB93720
        public void IsNeckBone(){} // RVA: 0xB93810
        public void AddBoneToEyes(){} // RVA: 0xB93A10
        public void AddBoneToSpine(){} // RVA: 0xB93BF0
        public void DetectLimb(){} // RVA: 0xB93FE0
        public void AddBoneToHierarchy(){} // RVA: 0xB942B0
        public void LimbError(){} // RVA: 0xB94400
        public void LimbWarning(){} // RVA: 0xB94C30
        public void SpineError(){} // RVA: 0xB95100
        public void SpineWarning(){} // RVA: 0xB43320
        public void EyesError(){} // RVA: 0xB955D0
        public void EyesWarning(){} // RVA: 0xB43320
        public void RootHeightWarning(){} // RVA: 0xB958A0
        public void FacingAxisWarning(){} // RVA: 0xB95E40
        public void GetVerticalOffset(){} // RVA: 0xB963B0
        public void .ctor(){} // RVA: 0xB96520
    }

    public class Comments : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class DemoGUIMessage : MonoBehaviour
    {
        // ── Methods ──
        public void OnGUI(){} // RVA: 0xB96650
        public void .ctor(){} // RVA: 0xB967E0
    }

    public class GenericBaker : Baker
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0xB80ED0
        public void GetCharacterRoot(){} // RVA: 0xB813B0
        public void OnStartBaking(){} // RVA: 0xB813C0
        public void OnSetLoopFrame(){} // RVA: 0xB814E0
        public void OnSetCurves(){} // RVA: 0xB81580
        public void OnSetKeyframes(){} // RVA: 0xB81620
        public void IsIgnored(){} // RVA: 0xB816C0
        public void BakePosition(){} // RVA: 0xB81860
        public void .ctor(){} // RVA: 0xB81A00
    }

    public class Hierarchy : Object
    {
        // ── Methods ──
        public void HierarchyIsValid(){} // RVA: 0xB96830
        public void ContainsDuplicate(){} // RVA: 0xB968C0
        public void IsAncestor(){} // RVA: 0xB96AA0
        public void ContainsChild(){} // RVA: 0xB96DA0
        public void AddAncestors(){} // RVA: 0xB97020
        public void GetAncestor(){} // RVA: 0xB975C0
        public void GetFirstCommonAncestor(){} // RVA: 0xB97AB0
        public void GetFirstCommonAncestorRecursive(){} // RVA: 0xB97CB0
        public void IsCommonAncestor(){} // RVA: 0xB97F60
        public void .ctor(){} // RVA: 0xB43310
    }

    public class HumanoidBaker : Baker
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0xB87FE0
        public void OnDestroy(){} // RVA: 0xB88BB0
        public void GetCharacterRoot(){} // RVA: 0xB88BD0
        public void OnStartBaking(){} // RVA: 0xB88BF0
        public void OnSetLoopFrame(){} // RVA: 0xB88D40
        public void OnSetCurves(){} // RVA: 0xB89000
        public void OnSetKeyframes(){} // RVA: 0xB89250
        public void UpdateHumanPose(){} // RVA: 0xB89C40
        public void .ctor(){} // RVA: 0xB89D30
    }

    public class InspectorComment : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB98400
    }

    public class Interp : Object
    {
        // ── Methods ──
        public void Float(){} // RVA: 0xB98550
        public void V3(){} // RVA: 0xB98B70
        public void LerpValue(){} // RVA: 0xB98C30
        public void None(){} // RVA: 0xB98D50
        public void InOutCubic(){} // RVA: 0xB98D60
        public void InOutQuintic(){} // RVA: 0xB98D90
        public void InQuintic(){} // RVA: 0xB98DE0
        public void InQuartic(){} // RVA: 0xB98E00
        public void InCubic(){} // RVA: 0xB98E20
        public void InQuadratic(){} // RVA: 0xB98E40
        public void OutQuintic(){} // RVA: 0xB98E50
        public void OutQuartic(){} // RVA: 0xB98EC0
        public void OutCubic(){} // RVA: 0xB98F20
        public void OutInCubic(){} // RVA: 0xB98F60
        public void OutInQuartic(){} // RVA: 0xB98FA0
        public void BackInCubic(){} // RVA: 0xB98FE0
        public void BackInQuartic(){} // RVA: 0xB99010
        public void OutBackCubic(){} // RVA: 0xB99050
        public void OutBackQuartic(){} // RVA: 0xB99090
        public void OutElasticSmall(){} // RVA: 0xB990E0
        public void OutElasticBig(){} // RVA: 0xB99160
        public void InElasticSmall(){} // RVA: 0xB991E0
        public void InElasticBig(){} // RVA: 0xB99240
        public void InSine(){} // RVA: 0xB992A0
        public void OutSine(){} // RVA: 0xB992F0
        public void InOutSine(){} // RVA: 0xB99330
        public void InElastic(){} // RVA: 0xB99390
        public void OutElastic(){} // RVA: 0xB99460
        public void InBack(){} // RVA: 0xB99520
        public void OutBack(){} // RVA: 0xB99550
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LargeHeader : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB996E0
    }

    public class LayerMaskExtensions : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0xB99830
        public void Create(){} // RVA: 0xB998B0
        public void NamesToMask(){} // RVA: 0xB99840
        public void LayerNumbersToMask(){} // RVA: 0xB998B0
        public void Inverse(){} // RVA: 0xB99900
        public void AddToMask(){} // RVA: 0xB99910
        public void RemoveFromMask(){} // RVA: 0xB99990
        public void MaskToNames(){} // RVA: 0xB99A10
        public void MaskToNumbers(){} // RVA: 0xB99B10
        public void MaskToString(){} // RVA: 0xB99DC0
    }

    public class QuaTools : Object
    {
        // ── Methods ──
        public void Lerp(){} // RVA: 0xB99F50
        public void Slerp(){} // RVA: 0xB9A010
        public void LinearBlend(){} // RVA: 0xB9A0D0
        public void SphericalBlend(){} // RVA: 0xB9A210
        public void FromToAroundAxis(){} // RVA: 0xB9A350
        public void RotationToLocalSpace(){} // RVA: 0xB9A580
        public void FromToRotation(){} // RVA: 0xB9A7E0
        public void GetAxis(){} // RVA: 0xB9AA60
        public void ClampRotation(){} // RVA: 0xB9AD20
        public void ClampAngle(){} // RVA: 0xB9AFF0
        public void MatchRotation(){} // RVA: 0xB9B150
        public void ToBiPolar(){} // RVA: 0xB9B620
    }

    public class Singleton`1 : MonoBehaviour
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0xA94080
        public void Awake(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0x894290
    }

    public class Singleton`1 : MonoBehaviour
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x4AD0FE0
        public void Awake(){} // RVA: 0x4AD1030
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SolverManager : MonoBehaviour
    {
        // ── Methods ──
        public void Disable(){} // RVA: 0xB9B670
        public void InitiateSolver(){} // RVA: 0xB43310
        public void UpdateSolver(){} // RVA: 0xB43310
        public void FixTransforms(){} // RVA: 0xB43310
        public void OnDisable(){} // RVA: 0xB9B700
        public void Start(){} // RVA: 0xB9B7D0
        public void get_animatePhysics(){} // RVA: 0xB9B820
        public void Initiate(){} // RVA: 0xB9B7D0
        public void Update(){} // RVA: 0xB9B9D0
        public void FindAnimatorRecursive(){} // RVA: 0xB9BAD0
        public void get_isAnimated(){} // RVA: 0xB9BEA0
        public void FixedUpdate(){} // RVA: 0xB9C020
        public void LateUpdate(){} // RVA: 0xB9C070
        public void UpdateSolverExternal(){} // RVA: 0xB9C180
        public void .ctor(){} // RVA: 0xB9C2F0
    }

    public class SolverManager[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TQ : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB81AB0
    }

    public class TriggerEventBroadcaster : MonoBehaviour
    {
        // ── Methods ──
        public void OnTriggerEnter(){} // RVA: 0xB9C340
        public void OnTriggerStay(){} // RVA: 0xB9C460
        public void OnTriggerExit(){} // RVA: 0xB9C580
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class V3Tools : Object
    {
        // ── Methods ──
        public void Lerp(){} // RVA: 0xB9C6A0
        public void Slerp(){} // RVA: 0xB9C770
        public void ExtractVertical(){} // RVA: 0xB9C860
        public void ExtractHorizontal(){} // RVA: 0xB9CA20
        public void ClampDirection(){} // RVA: 0xB9CFE0
        public void LineToPlane(){} // RVA: 0xB9D260
        public void PointToPlane(){} // RVA: 0xB9D3F0
        public void TransformPointUnscaled(){} // RVA: 0xB9D620
        public void InverseTransformPointUnscaled(){} // RVA: 0xB9D970
    }

    public class Warning : Object
    {
        // ── Methods ──
        public void Log(){} // RVA: 0xB9DE10
    }

}