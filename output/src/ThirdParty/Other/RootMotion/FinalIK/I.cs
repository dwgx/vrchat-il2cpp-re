// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 38
// Methods: 617

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class IK : SolverManager
    {
        // ── Methods ──
        public void GetIKSolver(){} // RVA: 0x7A7E00680
        public void UpdateSolver(){} // RVA: 0x7A81A6F20
        public void InitiateSolver(){} // RVA: 0x7A81A6FC0
        public void FixTransforms(){} // RVA: 0x7A81A7070
        public void OpenUserManual(){} // RVA: 0x7A7E18770
        public void OpenScriptReference(){} // RVA: 0x7A7E18770
        public void .ctor(){} // RVA: 0x7A8131470
    }

    public class IKConstraintBend : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7A81B7770
        public void get_initiated(){} // RVA: 0x7A81B7B30
        public void set_initiated(){} // RVA: 0x7A81B7B40
        public void .ctor(){} // RVA: 0x7A81B7BB0
        public void SetBones(){} // RVA: 0x7A81B7C50
        public void Initiate(){} // RVA: 0x7A81B7D50
        public void SetLimbOrientation(){} // RVA: 0x7A81B87A0
        public void LimitBend(){} // RVA: 0x7A81B8A50
        public void GetDir(){} // RVA: 0x7A81B96C0
        public void OrthoToLimb(){} // RVA: 0x7A81BA300
        public void OrthoToBone1(){} // RVA: 0x7A81BA470
        public void bone1(){} // RVA: 0x7B3F54E38
    }

    public class IKEffector : Object
    {
        // ── Methods ──
        public void GetNode(){} // RVA: 0x7A81BA5E0
        public void get_isEndEffector(){} // RVA: 0x7A8192400
        public void set_isEndEffector(){} // RVA: 0x7A8192410
        public void PinToBone(){} // RVA: 0x7A81BA640
        public void .ctor(){} // RVA: 0x7A81BAAC0
        public void IsValid(){} // RVA: 0x7A81BAEC0
        public void Initiate(){} // RVA: 0x7A81BB4E0
        public void ResetOffset(){} // RVA: 0x7A81BBAF0
        public void SetToTarget(){} // RVA: 0x7A81BBCE0
        public void OnPreSolve(){} // RVA: 0x7A81BBE90
        public void OnPostWrite(){} // RVA: 0x7A81BC890
        public void GetPlaneRotation(){} // RVA: 0x7A81BC8E0
        public void Update(){} // RVA: 0x7A81BCC60
        public void GetPosition(){} // RVA: 0x7A81BD0C0
    }

    public class IKEffector[] : Array
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

    public class IKExecutionOrder : MonoBehaviour
    {
        // ── Methods ──
        public void get_animatePhysics(){} // RVA: 0x7A81A70E0
        public void Start(){} // RVA: 0x7A81A7210
        public void Update(){} // RVA: 0x7A81A73E0
        public void FixedUpdate(){} // RVA: 0x7A81A7410
        public void LateUpdate(){} // RVA: 0x7A81A7440
        public void FixTransforms(){} // RVA: 0x7A81A75D0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class IKMapping : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7A81BD750
        public void Initiate(){} // RVA: 0x7A80D7310
        public void BoneIsValid(){} // RVA: 0x7A81BD760
        public void SolveFABRIKJoint(){} // RVA: 0x7A81B6120
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class IKMappingBone : IKMapping
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7A81C0F10
        public void .ctor(){} // RVA: 0x7A81C1110
        public void StoreDefaultLocalState(){} // RVA: 0x7A81C1240
        public void FixTransforms(){} // RVA: 0x7A81C1260
        public void Initiate(){} // RVA: 0x7A81C12E0
        public void ReadPose(){} // RVA: 0x7A81C1440
        public void WritePose(){} // RVA: 0x7A81C1460
    }

    public class IKMappingBone[] : Array
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

    public class IKMappingLimb : IKMapping
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7A81C1490
        public void GetBoneMap(){} // RVA: 0x7A81C1530
        public void SetLimbOrientation(){} // RVA: 0x7A81C1670
        public void .ctor(){} // RVA: 0x7A81C2420
        public void SetBones(){} // RVA: 0x7A81C26B0
        public void StoreDefaultLocalState(){} // RVA: 0x7A81C2800
        public void FixTransforms(){} // RVA: 0x7A81C2910
        public void Initiate(){} // RVA: 0x7A81C2B50
        public void ReadPose(){} // RVA: 0x7A81C31C0
        public void WritePose(){} // RVA: 0x7A81C3240
    }

    public class IKMappingLimb[] : Array
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

    public class IKMappingSpine : IKMapping
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7A81C3480
        public void .ctor(){} // RVA: 0x7A81C3F20
        public void SetBones(){} // RVA: 0x7A81C4230
        public void StoreDefaultLocalState(){} // RVA: 0x7A81C43E0
        public void FixTransforms(){} // RVA: 0x7A81C4550
        public void Initiate(){} // RVA: 0x7A81C45E0
        public void UseFABRIK(){} // RVA: 0x7A81C5260
        public void ReadPose(){} // RVA: 0x7A81C5290
        public void WritePose(){} // RVA: 0x7A81C56D0
        public void ForwardReach(){} // RVA: 0x7A81C5BE0
        public void BackwardReach(){} // RVA: 0x7A81C5E30
        public void MapToSolverPositions(){} // RVA: 0x7A81C6060
        public void spineBones(){} // RVA: 0x7B3FA7CD8
    }

    public class IKSolver : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7A7E019D0
        public void Initiate(){} // RVA: 0x7A81C6630
        public void Update(){} // RVA: 0x7A81C6820
        public void GetIKPosition(){} // RVA: 0x7A80F4AC0
        public void SetIKPosition(){} // RVA: 0x7A80F4AE0
        public void GetIKPositionWeight(){} // RVA: 0x7A81A5180
        public void SetIKPositionWeight(){} // RVA: 0x7A81C68A0
        public void GetRoot(){} // RVA: 0x7A8178B90
        public void get_initiated(){} // RVA: 0x7A81C68D0
        public void set_initiated(){} // RVA: 0x7A81C68E0
        public void GetPoints(){} // RVA: 0x7A7E00680
        public void GetPoint(){} // RVA: 0x7A7E00B20
        public void FixTransforms(){} // RVA: 0x7A7E18770
        public void StoreDefaultLocalState(){} // RVA: 0x7A7E18770
        public void OnInitiate(){} // RVA: 0x7A7E18770
        public void OnUpdate(){} // RVA: 0x7A7E18770
        public void LogWarning(){} // RVA: 0x7A81C68F0
        public void ContainsDuplicateBone(){} // RVA: 0x7A81C69A0
        public void HierarchyIsValid(){} // RVA: 0x7A81C6BA0
        public void PreSolveBones(){} // RVA: 0x7A81C6C40
        public void .ctor(){} // RVA: 0x7A81C70A0
        public void IKPosition(){} // RVA: 0x7B2CA4400
    }

    public class IKSolverAim : IKSolverHeuristic
    {
        // ── Methods ──
        public void GetAngle(){} // RVA: 0x7A81C93A0
        public void get_transformAxis(){} // RVA: 0x7A81C94B0
        public void get_transformPoleAxis(){} // RVA: 0x7A81C9720
        public void OnInitiate(){} // RVA: 0x7A81C9990
        public void OnUpdate(){} // RVA: 0x7A81C9E60
        public void get_minBones(){} // RVA: 0x7A81CA9D0
        public void Solve(){} // RVA: 0x7A81CA9E0
        public void GetClampedIKPosition(){} // RVA: 0x7A81CAB40
        public void RotateToTarget(){} // RVA: 0x7A81CB0C0
        public void get_localDirection(){} // RVA: 0x7A81CBF60
        public void .ctor(){} // RVA: 0x7A81CC070
        public void transform(){} // RVA: 0x7B3F8DC58
    }

    public class IKSolverArm : IKSolver
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7A81CC130
        public void SetChain(){} // RVA: 0x7A81CC820
        public void GetPoints(){} // RVA: 0x7A81CCA40
        public void GetPoint(){} // RVA: 0x7A81CCBF0
        public void StoreDefaultLocalState(){} // RVA: 0x7A81CD140
        public void FixTransforms(){} // RVA: 0x7A81CD1A0
        public void OnInitiate(){} // RVA: 0x7A81CD210
        public void OnUpdate(){} // RVA: 0x7A81CD330
        public void Solve(){} // RVA: 0x7A81CD3D0
        public void Read(){} // RVA: 0x7A81CD460
        public void Write(){} // RVA: 0x7A81CDCA0
        public void .ctor(){} // RVA: 0x7A81CE040
        public void IKRotationWeight(){} // RVA: 0x7B41F0F98
    }

    public class IKSolverCCD : IKSolverHeuristic
    {
        // ── Methods ──
        public void FadeOutBoneWeights(){} // RVA: 0x7A81CE570
        public void OnInitiate(){} // RVA: 0x7A81CE620
        public void OnUpdate(){} // RVA: 0x7A81CE770
        public void Solve(){} // RVA: 0x7A81CEC70
        public void .ctor(){} // RVA: 0x7A81CFAF0
    }

    public class IKSolverFABRIK : IKSolverHeuristic
    {
        // ── Methods ──
        public void SolveForward(){} // RVA: 0x7A81CFB00
        public void SolveBackward(){} // RVA: 0x7A81CFBB0
        public void GetIKPosition(){} // RVA: 0x7A81CFCB0
        public void OnInitiate(){} // RVA: 0x7A81CFE10
        public void OnUpdate(){} // RVA: 0x7A81D05A0
        public void get_boneLengthCanBeZero(){} // RVA: 0x7A80D7320
        public void SolveJoint(){} // RVA: 0x7A81D0AC0
        public void OnPreSolve(){} // RVA: 0x7A81D0C10
        public void OnPostSolve(){} // RVA: 0x7A81D1330
        public void Solve(){} // RVA: 0x7A81D1380
        public void ForwardReach(){} // RVA: 0x7A81D1480
        public void SolverMove(){} // RVA: 0x7A81D17F0
        public void SolverRotate(){} // RVA: 0x7A81D18A0
        public void SolverRotateChildren(){} // RVA: 0x7A81D1AA0
        public void SolverMoveChildrenAroundPoint(){} // RVA: 0x7A81D1C80
        public void GetParentSolverRotation(){} // RVA: 0x7A81D1F60
        public void GetParentSolverPosition(){} // RVA: 0x7A81D2200
        public void GetLimitedRotation(){} // RVA: 0x7A81D24C0
        public void LimitForward(){} // RVA: 0x7A81D2880
        public void BackwardReach(){} // RVA: 0x7A81D2FC0
        public void BackwardReachUnlimited(){} // RVA: 0x7A81D3000
        public void BackwardReachLimited(){} // RVA: 0x7A81D3260
        public void MapToSolverPositions(){} // RVA: 0x7A81D3F90
        public void MapToSolverPositionsLimited(){} // RVA: 0x7A81D4170
        public void .ctor(){} // RVA: 0x7A81D4310
        public void OnPreIteration(){} // RVA: 0x7B3FA7CD8
    }

    public class IKSolverFABRIKRoot : IKSolver
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7A81D4430
        public void StoreDefaultLocalState(){} // RVA: 0x7A81D4E40
        public void FixTransforms(){} // RVA: 0x7A81D4F50
        public void OnInitiate(){} // RVA: 0x7A81D5070
        public void IsRoot(){} // RVA: 0x7A81D52B0
        public void OnUpdate(){} // RVA: 0x7A81D5340
        public void GetPoints(){} // RVA: 0x7A81D5610
        public void GetPoint(){} // RVA: 0x7A81D56D0
        public void AddPointsToArray(){} // RVA: 0x7A81D5790
        public void GetCentroid(){} // RVA: 0x7A81D5970
        public void .ctor(){} // RVA: 0x7A81D5D70
        public void iterations(){} // RVA: 0x7B2CA4430
    }

    public class IKSolverFullBody : IKSolver
    {
        // ── Methods ──
        public void GetEffector(){} // RVA: 0x7A81D5E10
        public void GetChain(){} // RVA: 0x7A81D5FC0
        public void GetChainIndex(){} // RVA: 0x7A81D6010
        public void GetNode(){} // RVA: 0x7A81D6200
        public void GetChainAndNodeIndexes(){} // RVA: 0x7A81D6250
        public void GetPoints(){} // RVA: 0x7A81D6440
        public void GetPoint(){} // RVA: 0x7A81D6610
        public void IsValid(){} // RVA: 0x7A81D6830
        public void StoreDefaultLocalState(){} // RVA: 0x7A81D6B40
        public void FixTransforms(){} // RVA: 0x7A81D6DD0
        public void OnInitiate(){} // RVA: 0x7A81D7010
        public void OnUpdate(){} // RVA: 0x7A81D71C0
        public void ReadPose(){} // RVA: 0x7A81D7410
        public void Solve(){} // RVA: 0x7A81D77B0
        public void ApplyBendConstraints(){} // RVA: 0x7A81D7B20
        public void WritePose(){} // RVA: 0x7A81D7B60
        public void .ctor(){} // RVA: 0x7A81D7CB0
        public void iterations(){} // RVA: 0x7B41F0F98
    }

    public class IKSolverFullBodyBiped : IKSolverFullBody
    {
        // ── Methods ──
        public void get_bodyEffector(){} // RVA: 0x7A81D7F50
        public void get_leftShoulderEffector(){} // RVA: 0x7A81D7F80
        public void get_rightShoulderEffector(){} // RVA: 0x7A81D7FB0
        public void get_leftThighEffector(){} // RVA: 0x7A81D7FE0
        public void get_rightThighEffector(){} // RVA: 0x7A81D8010
        public void get_leftHandEffector(){} // RVA: 0x7A81D8040
        public void get_rightHandEffector(){} // RVA: 0x7A81D8070
        public void get_leftFootEffector(){} // RVA: 0x7A81D80A0
        public void get_rightFootEffector(){} // RVA: 0x7A81D80D0
        public void get_leftArmChain(){} // RVA: 0x7A81D8100
        public void get_rightArmChain(){} // RVA: 0x7A81D8130
        public void get_leftLegChain(){} // RVA: 0x7A81D8160
        public void get_rightLegChain(){} // RVA: 0x7A81D8190
        public void get_leftArmMapping(){} // RVA: 0x7A81D81C0
        public void get_rightArmMapping(){} // RVA: 0x7A81D81F0
        public void get_leftLegMapping(){} // RVA: 0x7A81D8220
        public void get_rightLegMapping(){} // RVA: 0x7A81D8250
        public void get_headMapping(){} // RVA: 0x7A81D8280
        public void SetChainWeights(){} // RVA: 0x7A81D82B0
        public void SetEffectorWeights(){} // RVA: 0x7A81D8320
        public void GetChain(){} // RVA: 0x7A81D8470
        public void GetEffector(){} // RVA: 0x7A81D8560
        public void GetEndEffector(){} // RVA: 0x7A81D86C0
        public void GetLimbMapping(){} // RVA: 0x7A81D87F0
        public void GetSpineMapping(){} // RVA: 0x7A81A00E0
        public void GetHeadMapping(){} // RVA: 0x7A81D8280
        public void GetBendConstraint(){} // RVA: 0x7A81D88E0
        public void IsValid(){} // RVA: 0x7A81D8970
        public void SetToReferences(){} // RVA: 0x7A81D8C80
        public void DetectRootNodeBone(){} // RVA: 0x7A81DAD60
        public void SetLimbOrientations(){} // RVA: 0x7A81DB450
        public void get_pullBodyOffset(){} // RVA: 0x7A8142830
        public void set_pullBodyOffset(){} // RVA: 0x7A8142850
        public void SetLimbOrientation(){} // RVA: 0x7A81DB4C0
        public void GetLeftClavicle(){} // RVA: 0x7A81DB750
        public void GetRightClavicle(){} // RVA: 0x7A81DB900
        public void Contains(){} // RVA: 0x7A81DBAB0
        public void ReadPose(){} // RVA: 0x7A81DBC20
        public void PullBody(){} // RVA: 0x7A81DC090
        public void GetBodyOffset(){} // RVA: 0x7A81DC270
        public void GetHandBodyPull(){} // RVA: 0x7A81DC550
        public void ApplyBendConstraints(){} // RVA: 0x7A81DC790
        public void WritePose(){} // RVA: 0x7A81DCBF0
        public void .ctor(){} // RVA: 0x7A81DCE70
        public void rootNode(){} // RVA: 0x7B3F795F8
    }

    public class IKSolverHeuristic : IKSolver
    {
        // ── Methods ──
        public void SetChain(){} // RVA: 0x7A81DCE90
        public void AddBone(){} // RVA: 0x7A81DD090
        public void StoreDefaultLocalState(){} // RVA: 0x7A81DD270
        public void FixTransforms(){} // RVA: 0x7A81DD3E0
        public void IsValid(){} // RVA: 0x7A81DD470
        public void GetPoints(){} // RVA: 0x7A81A00E0
        public void GetPoint(){} // RVA: 0x7A81DDB10
        public void get_minBones(){} // RVA: 0x7A81DDCC0
        public void get_boneLengthCanBeZero(){} // RVA: 0x7A81BD750
        public void get_allowCommonParent(){} // RVA: 0x7A80D7320
        public void OnInitiate(){} // RVA: 0x7A80D7310
        public void OnUpdate(){} // RVA: 0x7A80D7310
        public void InitiateBones(){} // RVA: 0x7A81DDCD0
        public void get_localDirection(){} // RVA: 0x7A81DE560
        public void get_positionOffset(){} // RVA: 0x7A81DE770
        public void GetSingularityOffset(){} // RVA: 0x7A81DE7E0
        public void SingularityDetected(){} // RVA: 0x7A81DED60
        public void .ctor(){} // RVA: 0x7A81DF0D0
        public void target(){} // RVA: 0x7B3F86E08
    }

    public class IKSolverLeg : IKSolver
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7A81DF180
        public void SetChain(){} // RVA: 0x7A81CC820
        public void GetPoints(){} // RVA: 0x7A81DF870
        public void GetPoint(){} // RVA: 0x7A81DFA20
        public void StoreDefaultLocalState(){} // RVA: 0x7A81CD140
        public void FixTransforms(){} // RVA: 0x7A81CD1A0
        public void OnInitiate(){} // RVA: 0x7A81DFF70
        public void OnUpdate(){} // RVA: 0x7A81E0090
        public void Solve(){} // RVA: 0x7A81E0190
        public void Read(){} // RVA: 0x7A81E0280
        public void Write(){} // RVA: 0x7A81E0AB0
        public void .ctor(){} // RVA: 0x7A81E0E50
        public void IKRotationWeight(){} // RVA: 0x7B41F0F98
    }

    public class IKSolverLimb : IKSolverTrigonometric
    {
        // ── Methods ──
        public void MaintainRotation(){} // RVA: 0x7A81E1380
        public void MaintainBend(){} // RVA: 0x7A81E1420
        public void OnInitiateVirtual(){} // RVA: 0x7A81E1470
        public void OnUpdateVirtual(){} // RVA: 0x7A81E1CE0
        public void OnPostSolveVirtual(){} // RVA: 0x7A81E1E40
        public void .ctor(){} // RVA: 0x7A81E2120
        public void get_axisDirections(){} // RVA: 0x7A81E2250
        public void StoreAxisDirections(){} // RVA: 0x7A81E2270
        public void GetModifiedBendNormal(){} // RVA: 0x7A81E28C0
        public void goal(){} // RVA: 0x7B4218C28
    }

    public class IKSolverLimb[] : Array
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

    public class IKSolverLookAt : IKSolver
    {
        // ── Methods ──
        public void SetLookAtWeight(){} // RVA: 0x7A81E4300
        public void StoreDefaultLocalState(){} // RVA: 0x7A81E43E0
        public void FixTransforms(){} // RVA: 0x7A81E45C0
        public void IsValid(){} // RVA: 0x7A81E47B0
        public void GetPoints(){} // RVA: 0x7A81E4D30
        public void GetPoint(){} // RVA: 0x7A81E5180
        public void SetChain(){} // RVA: 0x7A81E5520
        public void OnInitiate(){} // RVA: 0x7A81E5620
        public void OnUpdate(){} // RVA: 0x7A81E5CC0
        public void get_spineIsValid(){} // RVA: 0x7A81E5E50
        public void get_spineIsEmpty(){} // RVA: 0x7A81E5FB0
        public void SolveSpine(){} // RVA: 0x7A81E5FD0
        public void get_headIsValid(){} // RVA: 0x7A81E6300
        public void get_headIsEmpty(){} // RVA: 0x7A81E6310
        public void SolveHead(){} // RVA: 0x7A81E63F0
        public void get_eyesIsValid(){} // RVA: 0x7A81E6890
        public void get_eyesIsEmpty(){} // RVA: 0x7A81E69F0
        public void SolveEyes(){} // RVA: 0x7A81E6A10
        public void GetForwards(){} // RVA: 0x7A81E7310
        public void SetBones(){} // RVA: 0x7A81E7710
        public void .ctor(){} // RVA: 0x7A81E7950
        public void target(){} // RVA: 0x7B2E4C360
    }

    public class IKSolverTrigonometric : IKSolver
    {
        // ── Methods ──
        public void SetBendGoalPosition(){} // RVA: 0x7A81E87B0
        public void SetBendPlaneToCurrent(){} // RVA: 0x7A81E8AF0
        public void SetIKRotation(){} // RVA: 0x7A81E8E10
        public void SetIKRotationWeight(){} // RVA: 0x7A81E8E20
        public void GetIKRotation(){} // RVA: 0x7A81E8E50
        public void GetIKRotationWeight(){} // RVA: 0x7A81E8E60
        public void GetPoints(){} // RVA: 0x7A81E8E70
        public void GetPoint(){} // RVA: 0x7A81E8FA0
        public void StoreDefaultLocalState(){} // RVA: 0x7A81E92F0
        public void FixTransforms(){} // RVA: 0x7A81E9340
        public void IsValid(){} // RVA: 0x7A81E93A0
        public void SetChain(){} // RVA: 0x7A81E9B30
        public void Solve(){} // RVA: 0x7A81E9C90
        public void GetDirectionToBendPoint(){} // RVA: 0x7A81EA940
        public void OnInitiate(){} // RVA: 0x7A81EAD20
        public void IsDirectHierarchy(){} // RVA: 0x7A81EB0A0
        public void InitiateBones(){} // RVA: 0x7A81EB390
        public void OnUpdate(){} // RVA: 0x7A81EB540
        public void OnInitiateVirtual(){} // RVA: 0x7A80D7310
        public void OnUpdateVirtual(){} // RVA: 0x7A80D7310
        public void OnPostSolveVirtual(){} // RVA: 0x7A80D7310
        public void GetBendDirection(){} // RVA: 0x7A81EC4B0
        public void .ctor(){} // RVA: 0x7A81ECA20
        public void target(){} // RVA: 0x7B3FA7CD8
    }

    public class IKSolverVR : IKSolver
    {
        // ── Methods ──
        public void SetToReferences(){} // RVA: 0x7A81ED550
        public void GuessHandOrientations(){} // RVA: 0x7A81EDCE0
        public void DefaultAnimationCurves(){} // RVA: 0x7A81EE140
        public void AddPositionOffset(){} // RVA: 0x7A81EE4F0
        public void AddRotationOffset(){} // RVA: 0x7A81EE840
        public void AddPlatformMotion(){} // RVA: 0x7A81EEC20
        public void Reset(){} // RVA: 0x7A81EF060
        public void StoreDefaultLocalState(){} // RVA: 0x7A81EF380
        public void FixTransforms(){} // RVA: 0x7A81EF630
        public void GetPoints(){} // RVA: 0x7A81EF950
        public void GetPoint(){} // RVA: 0x7A81EF9B0
        public void IsValid(){} // RVA: 0x7A81EFA10
        public void GetNormal(){} // RVA: 0x7A81EFDC0
        public void GuessWristToPalmAxis(){} // RVA: 0x7A81F0290
        public void GuessPalmToThumbAxis(){} // RVA: 0x7A81F0660
        public void GetSineKeyframes(){} // RVA: 0x7A81F0FB0
        public void UpdateSolverTransforms(){} // RVA: 0x7A81F1040
        public void OnInitiate(){} // RVA: 0x7A81F12E0
        public void OnUpdate(){} // RVA: 0x7A81F1340
        public void WriteTransforms(){} // RVA: 0x7A81F1D90
        public void Read(){} // RVA: 0x7A81F28F0
        public void Solve(){} // RVA: 0x7A81F3450
        public void GetPosition(){} // RVA: 0x7A81F5060
        public void GetRotation(){} // RVA: 0x7A81F50B0
        public void get_rootBone(){} // RVA: 0x7A81F50F0
        public void set_rootBone(){} // RVA: 0x7A81F5100
        public void VrcRead(){} // RVA: 0x7A81F12E0
        public void VrcWrite(){} // RVA: 0x7A81F5160
        public void VrcWriteTransforms(){} // RVA: 0x7A81F5170
        public void VrcSyncIk(){} // RVA: 0x7A81F5180
        public void VrcLateSolve(){} // RVA: 0x7A81F51A0
        public void Write(){} // RVA: 0x7A81F5200
        public void GetPelvisOffset(){} // RVA: 0x7A81F53A0
        public void .ctor(){} // RVA: 0x7A81F5E80
        public void solverTransforms(){} // RVA: 0x7B3FB4328
    }

    public class IKSolver[] : Array
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

    public class IK[] : Array
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

    public class Inertia : OffsetModifier
    {
        // ── Methods ──
        public void ResetBodies(){} // RVA: 0x7A8249010
        public void OnModifyOffset(){} // RVA: 0x7A82490C0
        public void .ctor(){} // RVA: 0x7A80DF8B0
    }

    public class InteractionEffector : Object
    {
        // ── Methods ──
        public void get_effectorType(){} // RVA: 0x7A8124910
        public void set_effectorType(){} // RVA: 0x7A80DA0C0
        public void get_isPaused(){} // RVA: 0x7A8227C00
        public void set_isPaused(){} // RVA: 0x7A8227C10
        public void get_interactionObject(){} // RVA: 0x7A80DA7B0
        public void set_interactionObject(){} // RVA: 0x7A813E420
        public void get_inInteraction(){} // RVA: 0x7A8227C20
        public void .ctor(){} // RVA: 0x7A8227CF0
        public void Initiate(){} // RVA: 0x7A8227DC0
        public void StoreDefaults(){} // RVA: 0x7A8227F80
        public void ResetToDefaults(){} // RVA: 0x7A8228170
        public void Pause(){} // RVA: 0x7A8228630
        public void Resume(){} // RVA: 0x7A8228990
        public void Start(){} // RVA: 0x7A82289F0
        public void Update(){} // RVA: 0x7A8229420
        public void get_progress(){} // RVA: 0x7A8229FF0
        public void TriggerUntriggeredEvents(){} // RVA: 0x7A822A030
        public void PickUp(){} // RVA: 0x7A822A340
        public void Stop(){} // RVA: 0x7A822A720
        public void OnPostFBBIK(){} // RVA: 0x7A822AB10
        public void <effectorType>k__BackingField(){} // RVA: 0x7B3F8D318
    }

    public class InteractionEffector[] : Array
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

    public class InteractionLookAt : Object
    {
        // ── Methods ──
        public void Look(){} // RVA: 0x7A822B100
        public void OnFixTransforms(){} // RVA: 0x7A822B360
        public void Update(){} // RVA: 0x7A822B460
        public void SolveSpine(){} // RVA: 0x7A822B8F0
        public void SolveHead(){} // RVA: 0x7A822BA80
        public void .ctor(){} // RVA: 0x7A822BBC0
        public void ik(){} // RVA: 0x7B41F0F98
    }

    public class InteractionObject : MonoBehaviour
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void OpenTutorial1(){} // RVA: 0x7A80D7310
        public void OpenTutorial2(){} // RVA: 0x7A80D7310
        public void OpenTutorial3(){} // RVA: 0x7A80D7310
        public void OpenTutorial4(){} // RVA: 0x7A80D7310
        public void SupportGroup(){} // RVA: 0x7A80D7310
        public void ASThread(){} // RVA: 0x7A80D7310
        public void get_length(){} // RVA: 0x7A813FA00
        public void set_length(){} // RVA: 0x7A813FA10
        public void get_lastUsedInteractionSystem(){} // RVA: 0x7A81A0050
        public void set_lastUsedInteractionSystem(){} // RVA: 0x7A81A0060
        public void Initiate(){} // RVA: 0x7A822BBD0
        public void get_lookAtTarget(){} // RVA: 0x7A822BE90
        public void GetTarget(){} // RVA: 0x7A822D7F0
        public void CurveUsed(){} // RVA: 0x7A822C1C0
        public void GetTargets(){} // RVA: 0x7A8175DF0
        public void OnStartInteraction(){} // RVA: 0x7A81A0060
        public void Apply(){} // RVA: 0x7A822CF40
        public void GetValue(){} // RVA: 0x7A822CAB0
        public void get_targetsRoot(){} // RVA: 0x7A822CE10
        public void Start(){} // RVA: 0x7A822CF30
        public void GetWeightCurveIndex(){} // RVA: 0x7A822D8A0
        public void GetMultiplierIndex(){} // RVA: 0x7A822D900
        public void .ctor(){} // RVA: 0x7A822D960
    }

    public class InteractionSystem : MonoBehaviour
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void OpenTutorial1(){} // RVA: 0x7A80D7310
        public void OpenTutorial2(){} // RVA: 0x7A80D7310
        public void OpenTutorial3(){} // RVA: 0x7A80D7310
        public void OpenTutorial4(){} // RVA: 0x7A80D7310
        public void SupportGroup(){} // RVA: 0x7A80D7310
        public void ASThread(){} // RVA: 0x7A80D7310
        public void get_inInteraction(){} // RVA: 0x7A822E390
        public void IsInInteraction(){} // RVA: 0x7A822E460
        public void IsPaused(){} // RVA: 0x7A822E600
        public void IsInSync(){} // RVA: 0x7A822E6D0
        public void StartInteraction(){} // RVA: 0x7A822E820
        public void PauseInteraction(){} // RVA: 0x7A822E9A0
        public void ResumeInteraction(){} // RVA: 0x7A822EA30
        public void StopInteraction(){} // RVA: 0x7A822EAC0
        public void PauseAll(){} // RVA: 0x7A822EB50
        public void ResumeAll(){} // RVA: 0x7A822EBF0
        public void StopAll(){} // RVA: 0x7A822ECE0
        public void GetInteractionObject(){} // RVA: 0x7A822ED70
        public void GetProgress(){} // RVA: 0x7A822EE00
        public void GetMinActiveProgress(){} // RVA: 0x7A822EE90
        public void TriggerInteraction(){} // RVA: 0x7A822F460
        public void GetClosestInteractionRange(){} // RVA: 0x7A822F830
        public void GetClosestInteractionObjectInRange(){} // RVA: 0x7A822F920
        public void GetClosestInteractionTargetInRange(){} // RVA: 0x7A822F970
        public void GetClosestInteractionObjectsInRange(){} // RVA: 0x7A822F9E0
        public void GetClosestInteractionTargetsInRange(){} // RVA: 0x7A822FB80
        public void TriggerEffectorsReady(){} // RVA: 0x7A822FD40
        public void GetTriggerRange(){} // RVA: 0x7A8230120
        public void GetClosestTriggerIndex(){} // RVA: 0x7A82302A0
        public void get_ik(){} // RVA: 0x7A82305B0
        public void set_ik(){} // RVA: 0x7A82305C0
        public void get_triggersInRange(){} // RVA: 0x7A8178B90
        public void set_triggersInRange(){} // RVA: 0x7A8230620
        public void Start(){} // RVA: 0x7A8230680
        public void InteractionPause(){} // RVA: 0x7A8231180
        public void InteractionResume(){} // RVA: 0x7A82311A0
        public void InteractionStop(){} // RVA: 0x7A82311A0
        public void LookAtInteraction(){} // RVA: 0x7A82311C0
        public void OnTriggerEnter(){} // RVA: 0x7A8231360
        public void OnTriggerExit(){} // RVA: 0x7A8231590
        public void ContactIsInRange(){} // RVA: 0x7A8231760
        public void OnDrawGizmosSelected(){} // RVA: 0x7A82319F0
        public void Update(){} // RVA: 0x7A8231CB0
        public void Raycasting(){} // RVA: 0x7A8232040
        public void UpdateTriggerEventBroadcasting(){} // RVA: 0x7A82322A0
        public void UpdateEffectors(){} // RVA: 0x7A8232A20
        public void OnPreFBBIK(){} // RVA: 0x7A8232C40
        public void OnPostFBBIK(){} // RVA: 0x7A8232EB0
        public void OnFixTransforms(){} // RVA: 0x7A8233130
        public void OnDestroy(){} // RVA: 0x7A8233240
        public void IsValid(){} // RVA: 0x7A8233A30
        public void TriggerIndexIsValid(){} // RVA: 0x7A8233BC0
        public void .ctor(){} // RVA: 0x7A8233DA0
    }

    public class InteractionTarget : MonoBehaviour
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void OpenTutorial1(){} // RVA: 0x7A80D7310
        public void OpenTutorial2(){} // RVA: 0x7A80D7310
        public void OpenTutorial3(){} // RVA: 0x7A80D7310
        public void OpenTutorial4(){} // RVA: 0x7A80D7310
        public void SupportGroup(){} // RVA: 0x7A80D7310
        public void ASThread(){} // RVA: 0x7A80D7310
        public void GetValue(){} // RVA: 0x7A8234710
        public void ResetRotation(){} // RVA: 0x7A8234790
        public void RotateTo(){} // RVA: 0x7A82348C0
        public void .ctor(){} // RVA: 0x7A82356D0
    }

    public class InteractionTarget[] : Array
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

    public class InteractionTrigger : MonoBehaviour
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void OpenTutorial4(){} // RVA: 0x7A80D7310
        public void SupportGroup(){} // RVA: 0x7A80D7310
        public void ASThread(){} // RVA: 0x7A80D7310
        public void Start(){} // RVA: 0x7A80D7310
        public void GetBestRangeIndex(){} // RVA: 0x7A8235770
        public void .ctor(){} // RVA: 0x7A8235AB0
    }

    public class InteractionTrigger[] : Array
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

}