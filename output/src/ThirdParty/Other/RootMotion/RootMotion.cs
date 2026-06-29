// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion
// Classes: 30
// Methods: 281

namespace ThirdParty.Other.RootMotion
{
    public class AvatarUtility : Object
    {
        // ── Methods ──
        public void GetPostRotation(){} // RVA: 0x7A8116F00
        public void GetIKGoalTQ(){} // RVA: 0x7A8117220
        public void HumanIDFromAvatarIKGoal(){} // RVA: 0x7A8117DB0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AxisTools : Object
    {
        // ── Methods ──
        public void ToVector3(){} // RVA: 0x7A811EF60
        public void ToAxis(){} // RVA: 0x7A811F050
        public void GetAxisToPoint(){} // RVA: 0x7A811F0A0
        public void GetAxisToDirection(){} // RVA: 0x7A811F210
        public void GetAxisVectorToPoint(){} // RVA: 0x7A811F3F0
        public void GetAxisVectorToDirection(){} // RVA: 0x7A811F640
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Baker : MonoBehaviour
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void SupportGroup(){} // RVA: 0x7A80D7310
        public void ASThread(){} // RVA: 0x7A80D7310
        public void get_isBaking(){} // RVA: 0x7A8100260
        public void set_isBaking(){} // RVA: 0x7A8100270
        public void get_bakingProgress(){} // RVA: 0x7A8100280
        public void set_bakingProgress(){} // RVA: 0x7A8100290
        public void GetCharacterRoot(){} // RVA: 0x7A7E00680
        public void OnStartBaking(){} // RVA: 0x7A7E18770
        public void OnSetLoopFrame(){} // RVA: 0x7A7E262C0
        public void OnSetCurves(){} // RVA: 0x7A7E18800
        public void OnSetKeyframes(){} // RVA: 0x7A7E26380
        public void get_clipLength(){} // RVA: 0x7A8100320
        public void set_clipLength(){} // RVA: 0x7A8100330
        public void BakeClip(){} // RVA: 0x7A80D7310
        public void StartBaking(){} // RVA: 0x7A80D7310
        public void StopBaking(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A8115C40
    }

    public class BakerHumanoidQT : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8118980
        public void Reset(){} // RVA: 0x7A8118D50
        public void SetIKKeyframes(){} // RVA: 0x7A8119270
        public void SetKeyframes(){} // RVA: 0x7A8119560
        public void MoveLastKeyframes(){} // RVA: 0x7A8119660
        public void SetLoopFrame(){} // RVA: 0x7A8119700
        public void MoveLastKeyframe(){} // RVA: 0x7A8119790
        public void MultiplyLength(){} // RVA: 0x7A8119870
        public void SetCurves(){} // RVA: 0x7A8119960
    }

    public class BakerMuscle : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A811A1D0
        public void MuscleNameToPropertyName(){} // RVA: 0x7A811A2B0
        public void MultiplyLength(){} // RVA: 0x7A8119870
        public void SetCurves(){} // RVA: 0x7A811B450
        public void Reset(){} // RVA: 0x7A811B6E0
        public void SetKeyframe(){} // RVA: 0x7A811B7C0
        public void SetLoopFrame(){} // RVA: 0x7A811B800
    }

    public class BakerMuscle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class BakerTransform : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A811B810
        public void SetRelativeSpace(){} // RVA: 0x7A811B940
        public void SetCurves(){} // RVA: 0x7A811B960
        public void AddRootMotionCurves(){} // RVA: 0x7A811BDE0
        public void Reset(){} // RVA: 0x7A811C210
        public void ReduceKeyframes(){} // RVA: 0x7A811C6F0
        public void SetKeyframes(){} // RVA: 0x7A811CA30
        public void AddLoopFrame(){} // RVA: 0x7A811CEB0
    }

    public class BakerTransform[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class BakerUtilities : Object
    {
        // ── Methods ──
        public void ReduceKeyframes(){} // RVA: 0x7A8117DF0
        public void GetReducedKeyframes(){} // RVA: 0x7A8117E70
        public void SetLoopFrame(){} // RVA: 0x7A8118200
        public void SetTangentMode(){} // RVA: 0x7A80D7310
        public void EnsureQuaternionContinuity(){} // RVA: 0x7A81183C0
    }

    public class BipedLimbOrientations : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A811FE30
        public void get_UMA(){} // RVA: 0x7A811FF80
        public void get_MaxBiped(){} // RVA: 0x7A81203F0
        public void leftArm(){} // RVA: 0x7B40DB358
    }

    public class BipedNaming : Object
    {
        // ── Methods ──
        public void GetBonesOfType(){} // RVA: 0x7A81208A0
        public void GetBonesOfSide(){} // RVA: 0x7A8120AC0
        public void GetBonesOfTypeAndSide(){} // RVA: 0x7A8120CE0
        public void GetFirstBoneOfTypeAndSide(){} // RVA: 0x7A8120D60
        public void GetNamingMatch(){} // RVA: 0x7A8120E00
        public void GetBoneType(){} // RVA: 0x7A8121020
        public void GetBoneSide(){} // RVA: 0x7A8121170
        public void GetBone(){} // RVA: 0x7A8121200
        public void isLeft(){} // RVA: 0x7A8121290
        public void isRight(){} // RVA: 0x7A8121540
        public void isSpine(){} // RVA: 0x7A81217F0
        public void isHead(){} // RVA: 0x7A81219C0
        public void isArm(){} // RVA: 0x7A8121B90
        public void isLeg(){} // RVA: 0x7A8121D60
        public void isTail(){} // RVA: 0x7A8121F30
        public void isEye(){} // RVA: 0x7A8122100
        public void isTypeExclude(){} // RVA: 0x7A81222D0
        public void matchesNaming(){} // RVA: 0x7A8122420
        public void excludesNaming(){} // RVA: 0x7A8122530
        public void matchesLastLetter(){} // RVA: 0x7A81225B0
        public void LastLetterIs(){} // RVA: 0x7A81226C0
        public void firstLetter(){} // RVA: 0x7A8122730
        public void lastLetter(){} // RVA: 0x7A8122790
        public void .cctor(){} // RVA: 0x7A8122800
    }

    public class BipedReferences : Object
    {
        // ── Methods ──
        public void get_isFilled(){} // RVA: 0x7A8124A20
        public void get_isEmpty(){} // RVA: 0x7A8125330
        public void IsEmpty(){} // RVA: 0x7A8125350
        public void Contains(){} // RVA: 0x7A8125C60
        public void AutoDetectReferences(){} // RVA: 0x7A81269F0
        public void DetectReferencesByNaming(){} // RVA: 0x7A8126D60
        public void AssignHumanoidReferences(){} // RVA: 0x7A8127BF0
        public void SetupError(){} // RVA: 0x7A8128690
        public void SetupWarning(){} // RVA: 0x7A8128810
        public void IsNeckBone(){} // RVA: 0x7A8128900
        public void AddBoneToEyes(){} // RVA: 0x7A8128B70
        public void AddBoneToSpine(){} // RVA: 0x7A8128D50
        public void DetectLimb(){} // RVA: 0x7A8129180
        public void AddBoneToHierarchy(){} // RVA: 0x7A8129450
        public void LimbError(){} // RVA: 0x7A81295A0
        public void LimbWarning(){} // RVA: 0x7A8129EA0
        public void SpineError(){} // RVA: 0x7A812A290
        public void SpineWarning(){} // RVA: 0x7A80D7320
        public void EyesError(){} // RVA: 0x7A812A850
        public void EyesWarning(){} // RVA: 0x7A80D7320
        public void RootHeightWarning(){} // RVA: 0x7A812AB20
        public void FacingAxisWarning(){} // RVA: 0x7A812AF50
        public void GetVerticalOffset(){} // RVA: 0x7A812B3C0
        public void .ctor(){} // RVA: 0x7A812B530
        public void root(){} // RVA: 0x7B3FA7CD8
    }

    public class Comments : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class DemoGUIMessage : MonoBehaviour
    {
        // ── Methods ──
        public void OnGUI(){} // RVA: 0x7A812B660
        public void .ctor(){} // RVA: 0x7A812B7F0
    }

    public class GenericBaker : Baker
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7A8115EE0
        public void GetCharacterRoot(){} // RVA: 0x7A81163D0
        public void OnStartBaking(){} // RVA: 0x7A81163E0
        public void OnSetLoopFrame(){} // RVA: 0x7A81165A0
        public void OnSetCurves(){} // RVA: 0x7A81169B0
        public void OnSetKeyframes(){} // RVA: 0x7A8116A50
        public void IsIgnored(){} // RVA: 0x7A8116AF0
        public void BakePosition(){} // RVA: 0x7A8116C90
        public void .ctor(){} // RVA: 0x7A8116E30
    }

    public class Hierarchy : Object
    {
        // ── Methods ──
        public void HierarchyIsValid(){} // RVA: 0x7A812B840
        public void ContainsDuplicate(){} // RVA: 0x7A812B8D0
        public void IsAncestor(){} // RVA: 0x7A812BAB0
        public void ContainsChild(){} // RVA: 0x7A812BDE0
        public void AddAncestors(){} // RVA: 0x7A812C070
        public void GetAncestor(){} // RVA: 0x7A812C610
        public void GetFirstCommonAncestor(){} // RVA: 0x7A812CBF0
        public void GetFirstCommonAncestorRecursive(){} // RVA: 0x7A812CDF0
        public void IsCommonAncestor(){} // RVA: 0x7A812D0A0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class HumanoidBaker : Baker
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7A811D240
        public void OnDestroy(){} // RVA: 0x7A811DDD0
        public void GetCharacterRoot(){} // RVA: 0x7A811DDF0
        public void OnStartBaking(){} // RVA: 0x7A811DE50
        public void OnSetLoopFrame(){} // RVA: 0x7A811DFA0
        public void OnSetCurves(){} // RVA: 0x7A811E2D0
        public void OnSetKeyframes(){} // RVA: 0x7A811E5A0
        public void UpdateHumanPose(){} // RVA: 0x7A811ED50
        public void .ctor(){} // RVA: 0x7A811EE40
    }

    public class InspectorComment : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A812D540
        public void name(){} // RVA: 0x7B3FB4428
    }

    public class Interp : Object
    {
        // ── Methods ──
        public void Float(){} // RVA: 0x7A812D690
        public void V3(){} // RVA: 0x7A812DCB0
        public void LerpValue(){} // RVA: 0x7A812DD70
        public void None(){} // RVA: 0x7A812DE90
        public void InOutCubic(){} // RVA: 0x7A812DEA0
        public void InOutQuintic(){} // RVA: 0x7A812DED0
        public void InQuintic(){} // RVA: 0x7A812DF20
        public void InQuartic(){} // RVA: 0x7A812DF40
        public void InCubic(){} // RVA: 0x7A812DF60
        public void InQuadratic(){} // RVA: 0x7A812DF80
        public void OutQuintic(){} // RVA: 0x7A812DF90
        public void OutQuartic(){} // RVA: 0x7A812E000
        public void OutCubic(){} // RVA: 0x7A812E060
        public void OutInCubic(){} // RVA: 0x7A812E0A0
        public void OutInQuartic(){} // RVA: 0x7A812E0E0
        public void BackInCubic(){} // RVA: 0x7A812E120
        public void BackInQuartic(){} // RVA: 0x7A812E150
        public void OutBackCubic(){} // RVA: 0x7A812E190
        public void OutBackQuartic(){} // RVA: 0x7A812E1D0
        public void OutElasticSmall(){} // RVA: 0x7A812E220
        public void OutElasticBig(){} // RVA: 0x7A812E2A0
        public void InElasticSmall(){} // RVA: 0x7A812E320
        public void InElasticBig(){} // RVA: 0x7A812E380
        public void InSine(){} // RVA: 0x7A812E3E0
        public void OutSine(){} // RVA: 0x7A812E430
        public void InOutSine(){} // RVA: 0x7A812E470
        public void InElastic(){} // RVA: 0x7A812E4D0
        public void OutElastic(){} // RVA: 0x7A812E5A0
        public void InBack(){} // RVA: 0x7A812E660
        public void OutBack(){} // RVA: 0x7A812E690
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LargeHeader : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A812E820
        public void name(){} // RVA: 0x7B3FB4428
    }

    public class LayerMaskExtensions : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x7A812E970
        public void Create(){} // RVA: 0x7A812E990
        public void NamesToMask(){} // RVA: 0x7A812E9E0
        public void LayerNumbersToMask(){} // RVA: 0x7A812E990
        public void Inverse(){} // RVA: 0x7A812EAA0
        public void AddToMask(){} // RVA: 0x7A812EAB0
        public void RemoveFromMask(){} // RVA: 0x7A812EB70
        public void MaskToNames(){} // RVA: 0x7A812EC30
        public void MaskToNumbers(){} // RVA: 0x7A812ED30
        public void MaskToString(){} // RVA: 0x7A812EE60
    }

    public class QuaTools : Object
    {
        // ── Methods ──
        public void Lerp(){} // RVA: 0x7A812F020
        public void Slerp(){} // RVA: 0x7A812F0E0
        public void LinearBlend(){} // RVA: 0x7A812F1A0
        public void SphericalBlend(){} // RVA: 0x7A812F2E0
        public void FromToAroundAxis(){} // RVA: 0x7A812F420
        public void RotationToLocalSpace(){} // RVA: 0x7A812F650
        public void FromToRotation(){} // RVA: 0x7A812F8B0
        public void GetAxis(){} // RVA: 0x7A812FB30
        public void ClampRotation(){} // RVA: 0x7A812FDF0
        public void ClampAngle(){} // RVA: 0x7A81300C0
        public void MatchRotation(){} // RVA: 0x7A8130220
        public void ToBiPolar(){} // RVA: 0x7A81306F0
    }

    public class Singleton`1 : MonoBehaviour
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x7A8051B10
        public void Awake(){} // RVA: 0x7A7E18770
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class Singleton`1 : MonoBehaviour
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x7ABE1F5D0
        public void Awake(){} // RVA: 0x7ABE1F620
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class SolverManager : MonoBehaviour
    {
        // ── Methods ──
        public void Disable(){} // RVA: 0x7A8130740
        public void InitiateSolver(){} // RVA: 0x7A80D7310
        public void UpdateSolver(){} // RVA: 0x7A80D7310
        public void FixTransforms(){} // RVA: 0x7A80D7310
        public void OnDisable(){} // RVA: 0x7A8130840
        public void Start(){} // RVA: 0x7A81308E0
        public void get_animatePhysics(){} // RVA: 0x7A81308F0
        public void Initiate(){} // RVA: 0x7A8130B10
        public void Update(){} // RVA: 0x7A8130B90
        public void FindAnimatorRecursive(){} // RVA: 0x7A8130C90
        public void get_isAnimated(){} // RVA: 0x7A8131060
        public void FixedUpdate(){} // RVA: 0x7A81311E0
        public void LateUpdate(){} // RVA: 0x7A8131230
        public void UpdateSolverExternal(){} // RVA: 0x7A8131340
        public void .ctor(){} // RVA: 0x7A8131470
    }

    public class SolverManager[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class TQ : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8116EE0
    }

    public class TriggerEventBroadcaster : MonoBehaviour
    {
        // ── Methods ──
        public void OnTriggerEnter(){} // RVA: 0x7A81314C0
        public void OnTriggerStay(){} // RVA: 0x7A81315E0
        public void OnTriggerExit(){} // RVA: 0x7A8131700
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class V3Tools : Object
    {
        // ── Methods ──
        public void Lerp(){} // RVA: 0x7A8131820
        public void Slerp(){} // RVA: 0x7A81318F0
        public void ExtractVertical(){} // RVA: 0x7A81319E0
        public void ExtractHorizontal(){} // RVA: 0x7A8131BA0
        public void ClampDirection(){} // RVA: 0x7A8132160
        public void LineToPlane(){} // RVA: 0x7A81323E0
        public void PointToPlane(){} // RVA: 0x7A8132570
        public void TransformPointUnscaled(){} // RVA: 0x7A81327A0
        public void InverseTransformPointUnscaled(){} // RVA: 0x7A8132A70
    }

    public class Warning : Object
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7A8132E90
    }

}