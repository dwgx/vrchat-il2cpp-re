// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion
// Classes: 23
// Methods: 217

namespace ThirdParty.Other.RootMotion
{
    public class AvatarUtility : Object
    {
        // ── Original Methods ──
        public void HumanIDFromAvatarIKGoal(){} // RVA: 0x7ffaa8972990
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetPostRotation(){} // RVA: 0x7ffaa8971af0
        public void GetIKGoalTQ(){} // RVA: 0x7ffaa8971e10
    }

    public class AxisTools : Object
    {
        // ── Original Methods ──
        public void ToVector3(){} // RVA: 0x7ffaa8979b70
        public void ToAxis(){} // RVA: 0x7ffaa8979c60
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetAxisToPoint(){} // RVA: 0x7ffaa8979cb0
        public void GetAxisToDirection(){} // RVA: 0x7ffaa8979e20
        public void GetAxisVectorToPoint(){} // RVA: 0x7ffaa897a000
        public void GetAxisVectorToDirection(){} // RVA: 0x7ffaa897a250
        public void GetAxisVectorToDirection(){} // RVA: 0x7ffaa897a250
    }

    public class Baker : MonoBehaviour
    {
        public object mode; // 0x33522080
        public object loop; // 0x33522080
        public object saveName; // 0x33522080
        public object animator; // 0x33522080

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void get_isBaking(){} // RVA: 0x7ffaa895b020
        public void set_isBaking(){} // RVA: 0x7ffaa895b030
        public void get_bakingProgress(){} // RVA: 0x7ffaa895b040
        public void set_bakingProgress(){} // RVA: 0x7ffaa895b050
        public void OnStartBaking(){} // RVA: 0x7ffaa8660cc0
        public void OnSetLoopFrame(){} // RVA: 0x7ffaa866e7c0
        public void OnSetCurves(){} // RVA: 0x7ffaa8660d80
        public void OnSetKeyframes(){}
        public void get_clipLength(){} // RVA: 0x7ffaa895b0e0
        public void set_clipLength(){} // RVA: 0x7ffaa895b0f0
        public void BakeClip(){} // RVA: 0x7ffaa8932310
        public void StartBaking(){} // RVA: 0x7ffaa8932310
        public void StopBaking(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8970890
        // ── Binary Analysis Named ──
        public void GetCharacterRoot(){} // RVA: 0x7ffaa86491d0
    }

    public class BakerUtilities : Object
    {
        // ── Original Methods ──
        public void ReduceKeyframes(){} // RVA: 0x7ffaa89729d0
        public void EnsureQuaternionContinuity(){} // RVA: 0x7ffaa8972ff0
        // ── Binary Analysis Named ──
        public void GetReducedKeyframes(){} // RVA: 0x7ffaa8972a50
        public void SetLoopFrame(){} // RVA: 0x7ffaa8972e30
        public void SetTangentMode(){} // RVA: 0x7ffaa8932310
    }

    public class BipedLimbOrientations : Object
    {
        public object leftLeg; // 0x334A7C90

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa897aa50
        public void get_UMA(){} // RVA: 0x7ffaa897aba0
        public void get_MaxBiped(){} // RVA: 0x7ffaa897b010
    }

    public class BipedNaming : Object
    {
        public object typeSpine; // 0x3399D6C0
        public object typeLeg; // 0x3399D6C0
        public object typeExclude; // 0x3399D6C0
        public object typeExcludeArm; // 0x3399D6C0
        public object typeExcludeEye; // 0x3399D6C0
        public object foot; // 0x3399D6C0

        // ── Original Methods ──
        public void isLeft(){} // RVA: 0x7ffaa897be40
        public void isRight(){} // RVA: 0x7ffaa897c0f0
        public void isSpine(){} // RVA: 0x7ffaa897c3a0
        public void isHead(){} // RVA: 0x7ffaa897c570
        public void isArm(){} // RVA: 0x7ffaa897c740
        public void isLeg(){} // RVA: 0x7ffaa897c910
        public void isTail(){} // RVA: 0x7ffaa897cae0
        public void isEye(){} // RVA: 0x7ffaa897ccb0
        public void isTypeExclude(){} // RVA: 0x7ffaa897ce80
        public void matchesNaming(){} // RVA: 0x7ffaa897cfd0
        public void excludesNaming(){} // RVA: 0x7ffaa897d0e0
        public void matchesLastLetter(){} // RVA: 0x7ffaa897d160
        public void LastLetterIs(){} // RVA: 0x7ffaa897d260
        public void firstLetter(){} // RVA: 0x7ffaa897d2d0
        public void lastLetter(){} // RVA: 0x7ffaa897d330
        public void .cctor(){} // RVA: 0x7ffaa897d3a0
        // ── Binary Analysis Named ──
        public void GetBonesOfType(){} // RVA: 0x7ffaa897b4c0
        public void GetBonesOfSide(){} // RVA: 0x7ffaa897b6c0
        public void GetBonesOfTypeAndSide(){} // RVA: 0x7ffaa897b8c0
        public void GetFirstBoneOfTypeAndSide(){} // RVA: 0x7ffaa897b940
        public void GetNamingMatch(){} // RVA: 0x7ffaa897b9e0
        public void GetBoneType(){} // RVA: 0x7ffaa897bbd0
        public void GetBoneSide(){} // RVA: 0x7ffaa897bd20
        public void GetBone(){} // RVA: 0x7ffaa897bdb0
    }

    public class BipedReferences : Object
    {
        public object leftThigh; // 0x333F6B10
        public object rightThigh; // 0x333F6B10
        public object leftUpperArm; // 0x333F6B10
        public object rightUpperArm; // 0x333F6B10
        public object head; // 0x333F6B10
        public object ; // 0x82009F60

        // ── Original Methods ──
        public void get_isFilled(){} // RVA: 0x7ffaa897f6c0
        public void get_isEmpty(){} // RVA: 0x7ffaa897ffc0
        public void IsEmpty(){} // RVA: 0x7ffaa897ffe0
        public void Contains(){} // RVA: 0x7ffaa89808f0
        public void AutoDetectReferences(){} // RVA: 0x7ffaa8981670
        public void DetectReferencesByNaming(){} // RVA: 0x7ffaa89819e0
        public void AssignHumanoidReferences(){} // RVA: 0x7ffaa8982850
        public void IsNeckBone(){} // RVA: 0x7ffaa8983560
        public void AddBoneToEyes(){} // RVA: 0x7ffaa89837d0
        public void AddBoneToSpine(){} // RVA: 0x7ffaa89839b0
        public void DetectLimb(){} // RVA: 0x7ffaa8983de0
        public void AddBoneToHierarchy(){} // RVA: 0x7ffaa89840b0
        public void LimbError(){} // RVA: 0x7ffaa8984200
        public void LimbWarning(){} // RVA: 0x7ffaa8984b00
        public void SpineError(){} // RVA: 0x7ffaa8984f00
        public void SpineWarning(){} // RVA: 0x7ffaa8932320
        public void EyesError(){} // RVA: 0x7ffaa89854c0
        public void EyesWarning(){} // RVA: 0x7ffaa8932320
        public void RootHeightWarning(){} // RVA: 0x7ffaa8985790
        public void FacingAxisWarning(){} // RVA: 0x7ffaa8985bc0
        public void .ctor(){} // RVA: 0x7ffaa8986190
        // ── Binary Analysis Named ──
        public void SetupError(){} // RVA: 0x7ffaa89832f0
        public void SetupWarning(){} // RVA: 0x7ffaa8983470
        public void GetVerticalOffset(){} // RVA: 0x7ffaa8986030
    }

    public class Comments : MonoBehaviour
    {
        public object Ԏ=g; // 0x1

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class DemoGUIMessage : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnGUI(){} // RVA: 0x7ffaa89862c0
        public void .ctor(){} // RVA: 0x7ffaa8986450
    }

    public class GenericBaker : Baker
    {
        public object rootNode; // 0x33521EB0
        public object children; // 0x33521EB0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa8970b30
        public void OnStartBaking(){} // RVA: 0x7ffaa8971020
        public void OnSetLoopFrame(){} // RVA: 0x7ffaa89711d0
        public void OnSetCurves(){} // RVA: 0x7ffaa89715e0
        public void OnSetKeyframes(){} // RVA: 0x7ffaa8971670
        public void IsIgnored(){} // RVA: 0x7ffaa8971700
        public void BakePosition(){} // RVA: 0x7ffaa8971890
        public void .ctor(){} // RVA: 0x7ffaa8971a20
        // ── Binary Analysis Named ──
        public void GetCharacterRoot(){} // RVA: 0x7ffaa8971010
    }

    public class Hierarchy : Object
    {
        // ── Original Methods ──
        public void HierarchyIsValid(){} // RVA: 0x7ffaa89864a0
        public void ContainsDuplicate(){} // RVA: 0x7ffaa8986520
        public void IsAncestor(){} // RVA: 0x7ffaa89866d0
        public void ContainsChild(){} // RVA: 0x7ffaa8986a00
        public void AddAncestors(){} // RVA: 0x7ffaa8986c90
        public void IsCommonAncestor(){} // RVA: 0x7ffaa8987cc0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetAncestor(){} // RVA: 0x7ffaa8987220
        public void GetFirstCommonAncestor(){} // RVA: 0x7ffaa8987800
        public void GetFirstCommonAncestor(){} // RVA: 0x7ffaa8987800
        public void GetFirstCommonAncestorRecursive(){} // RVA: 0x7ffaa8987a10
    }

    public class HumanoidBaker : Baker
    {
        public object muscleFrameRateDiv; // 0x33C7F6B0
        public object leftFootQT; // 0x33C7F6B0
        public object rightHandQT; // 0x33C7F6B0
        public object handler; // 0x33C7F6B0
        public object mN; // 0x33C7F6B0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa8977e90
        public void OnDestroy(){} // RVA: 0x7ffaa8978a20
        public void OnStartBaking(){} // RVA: 0x7ffaa8978aa0
        public void OnSetLoopFrame(){} // RVA: 0x7ffaa8978bd0
        public void OnSetCurves(){} // RVA: 0x7ffaa8978ef0
        public void OnSetKeyframes(){} // RVA: 0x7ffaa89791b0
        public void UpdateHumanPose(){} // RVA: 0x7ffaa8979960
        public void .ctor(){} // RVA: 0x7ffaa8979a50
        // ── Binary Analysis Named ──
        public void GetCharacterRoot(){} // RVA: 0x7ffaa8978a40
    }

    public class InspectorComment : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8988160
        public void .ctor(){} // RVA: 0x7ffaa8988160
    }

    public class Interp : Object
    {
        // ── Original Methods ──
        public void Float(){} // RVA: 0x7ffaa89882b0
        public void V3(){} // RVA: 0x7ffaa89888d0
        public void LerpValue(){} // RVA: 0x7ffaa8988980
        public void None(){} // RVA: 0x7ffaa8988aa0
        public void InOutCubic(){} // RVA: 0x7ffaa8988ab0
        public void InOutQuintic(){} // RVA: 0x7ffaa8988ae0
        public void InQuintic(){} // RVA: 0x7ffaa8988b30
        public void InQuartic(){} // RVA: 0x7ffaa8988b50
        public void InCubic(){} // RVA: 0x7ffaa8988b70
        public void InQuadratic(){} // RVA: 0x7ffaa8988b90
        public void OutQuintic(){} // RVA: 0x7ffaa8988ba0
        public void OutQuartic(){} // RVA: 0x7ffaa8988c10
        public void OutCubic(){} // RVA: 0x7ffaa8988c70
        public void OutInCubic(){} // RVA: 0x7ffaa8988cb0
        public void OutInQuartic(){} // RVA: 0x7ffaa8988cf0
        public void BackInCubic(){} // RVA: 0x7ffaa8988d30
        public void BackInQuartic(){} // RVA: 0x7ffaa8988d60
        public void OutBackCubic(){} // RVA: 0x7ffaa8988da0
        public void OutBackQuartic(){} // RVA: 0x7ffaa8988de0
        public void OutElasticSmall(){} // RVA: 0x7ffaa8988e30
        public void OutElasticBig(){} // RVA: 0x7ffaa8988eb0
        public void InElasticSmall(){} // RVA: 0x7ffaa8988f30
        public void InElasticBig(){} // RVA: 0x7ffaa8988f90
        public void InSine(){} // RVA: 0x7ffaa8988ff0
        public void OutSine(){} // RVA: 0x7ffaa8989040
        public void InOutSine(){} // RVA: 0x7ffaa8989080
        public void InElastic(){} // RVA: 0x7ffaa89890e0
        public void OutElastic(){} // RVA: 0x7ffaa89891b0
        public void InBack(){} // RVA: 0x7ffaa8989270
        public void OutBack(){} // RVA: 0x7ffaa89892a0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class LargeHeader : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8989430
        public void .ctor(){} // RVA: 0x7ffaa8989430
    }

    public class LayerMaskExtensions : Object
    {
        // ── Original Methods ──
        public void Contains(){} // RVA: 0x7ffaa8989580
        public void Create(){} // RVA: 0x7ffaa89895a0
        public void Create(){} // RVA: 0x7ffaa89895a0
        public void NamesToMask(){} // RVA: 0x7ffaa89895f0
        public void LayerNumbersToMask(){} // RVA: 0x7ffaa89895a0
        public void Inverse(){} // RVA: 0x7ffaa89896a0
        public void AddToMask(){} // RVA: 0x7ffaa89896b0
        public void RemoveFromMask(){} // RVA: 0x7ffaa8989770
        public void MaskToNames(){} // RVA: 0x7ffaa8989830
        public void MaskToNumbers(){} // RVA: 0x7ffaa8989930
        public void MaskToString(){} // RVA: 0x7ffaa8989a60
        public void MaskToString(){} // RVA: 0x7ffaa8989a60
    }

    public class QuaTools : Object
    {
        // ── Original Methods ──
        public void Lerp(){} // RVA: 0x7ffaa8989c20
        public void Slerp(){} // RVA: 0x7ffaa8989ce0
        public void LinearBlend(){} // RVA: 0x7ffaa8989da0
        public void SphericalBlend(){} // RVA: 0x7ffaa8989ee0
        public void FromToAroundAxis(){} // RVA: 0x7ffaa898a020
        public void RotationToLocalSpace(){} // RVA: 0x7ffaa898a240
        public void FromToRotation(){} // RVA: 0x7ffaa898a4a0
        public void ClampRotation(){} // RVA: 0x7ffaa898a9e0
        public void ClampAngle(){} // RVA: 0x7ffaa898acb0
        public void MatchRotation(){} // RVA: 0x7ffaa898ae10
        public void ToBiPolar(){} // RVA: 0x7ffaa898b2e0
        public void ToBiPolar(){} // RVA: 0x7ffaa898b2e0
        // ── Binary Analysis Named ──
        public void GetAxis(){} // RVA: 0x7ffaa898a720
    }

    public class Singleton`1 : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_instance(){} // RVA: 0x7ffaa887e5c0
        public void Awake(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class Singleton`1 : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_instance(){} // RVA: 0x7ffaac3422c0
        public void Awake(){} // RVA: 0x7ffaac342310
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SolverManager : MonoBehaviour
    {
        public object fixTransforms; // 0x33518030
        public object updateFrame; // 0x33518030

        // ── Original Methods ──
        public void Disable(){} // RVA: 0x7ffaa898b330
        public void InitiateSolver(){} // RVA: 0x7ffaa8932310
        public void UpdateSolver(){} // RVA: 0x7ffaa8932310
        public void FixTransforms(){} // RVA: 0x7ffaa8932310
        public void OnDisable(){} // RVA: 0x7ffaa898b430
        public void Start(){} // RVA: 0x7ffaa898b4d0
        public void get_animatePhysics(){} // RVA: 0x7ffaa898b4e0
        public void Initiate(){} // RVA: 0x7ffaa898b700
        public void Update(){} // RVA: 0x7ffaa898b780
        public void FindAnimatorRecursive(){} // RVA: 0x7ffaa898b880
        public void get_isAnimated(){} // RVA: 0x7ffaa898bc50
        public void FixedUpdate(){} // RVA: 0x7ffaa898bdd0
        public void LateUpdate(){} // RVA: 0x7ffaa898be20
        public void UpdateSolverExternal(){} // RVA: 0x7ffaa898bf30
        public void .ctor(){} // RVA: 0x7ffaa898c060
    }

    public class TriggerEventBroadcaster : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnTriggerEnter(){} // RVA: 0x7ffaa898c0b0
        public void OnTriggerStay(){} // RVA: 0x7ffaa898c1d0
        public void OnTriggerExit(){} // RVA: 0x7ffaa898c2f0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class V3Tools : Object
    {
        // ── Original Methods ──
        public void Lerp(){} // RVA: 0x7ffaa898c410
        public void Slerp(){} // RVA: 0x7ffaa898c4e0
        public void ExtractVertical(){} // RVA: 0x7ffaa898c5d0
        public void ExtractHorizontal(){} // RVA: 0x7ffaa898c790
        public void ClampDirection(){} // RVA: 0x7ffaa898cd50
        public void ClampDirection(){} // RVA: 0x7ffaa898cd50
        public void ClampDirection(){} // RVA: 0x7ffaa898cd50
        public void LineToPlane(){} // RVA: 0x7ffaa898cfd0
        public void PointToPlane(){} // RVA: 0x7ffaa898d150
        public void TransformPointUnscaled(){} // RVA: 0x7ffaa898d370
        public void InverseTransformPointUnscaled(){} // RVA: 0x7ffaa898d650
    }

    public class Warning : Object
    {
        // ── Original Methods ──
        public void Log(){} // RVA: 0x7ffaa898da70
        public void Log(){} // RVA: 0x7ffaa898da70
    }

}