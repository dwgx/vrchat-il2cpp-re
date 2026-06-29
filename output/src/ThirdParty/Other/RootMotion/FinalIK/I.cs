// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 38
// Methods: 600

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class IK : SolverManager
    {
        // ── Methods ──
        public void GetIKSolver(){} // RVA: 0x87C0A0
        public void UpdateSolver(){} // RVA: 0xC17290
        public void InitiateSolver(){} // RVA: 0xC17330
        public void FixTransforms(){} // RVA: 0xC173B0
        public void OpenUserManual(){} // RVA: 0x894290
        public void OpenScriptReference(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0xB9C2F0
    }

    public class IKConstraintBend : Object
    {
        public object bone1;
        public object bone2;
        public object bone3;
        public object bendGoal;
        public object direction;
        public object rotationOffset;
        public object weight;
        public object defaultLocalDirection;
        public object defaultChildDirection;
        public object clampF;
        public object chainIndex1;
        public object nodeIndex1;
        public object chainIndex2;
        public object nodeIndex2;
        public object chainIndex3;
        public object nodeIndex3;
        public object _initiated;
        public object limbOrientationsSet;

        // ── Methods ──
        public void IsValid(){} // RVA: 0xC27AF0
        public void get_initiated(){} // RVA: 0xC27EB0
        public void set_initiated(){} // RVA: 0xC27EC0
        public void .ctor(){} // RVA: 0xC27F30
        public void SetBones(){} // RVA: 0xC27FD0
        public void Initiate(){} // RVA: 0xC280D0
        public void SetLimbOrientation(){} // RVA: 0xC28C80
        public void LimitBend(){} // RVA: 0xC28F30
        public void GetDir(){} // RVA: 0xC29EC0
        public void OrthoToLimb(){} // RVA: 0xC2AC20
        public void OrthoToBone1(){} // RVA: 0xC2AD90
    }

    public class IKEffector : Object
    {
        public object bone;
        public object target;
        public object positionWeight;
        public object rotationWeight;
        public object position;
        public object rotation;
        public object positionOffset;
        public object _isEndEffector;
        public object effectChildNodes;
        public object maintainRelativePositionWeight;
        public object childBones;
        public object planeBone1;
        public object planeBone2;
        public object planeBone3;
        public object planeRotationOffset;
        public object posW;
        public object rotW;
        public object localPositions;
        public object usePlaneNodes;
        public object animatedPlaneRotation;
        public object animatedPosition;
        public object firstUpdate;
        public object chainIndex;
        public object nodeIndex;
        public object plane1ChainIndex;
        public object plane1NodeIndex;
        public object plane2ChainIndex;
        public object plane2NodeIndex;
        public object plane3ChainIndex;
        public object plane3NodeIndex;
        public object childChainIndexes;
        public object childNodeIndexes;

        // ── Methods ──
        public void GetNode(){} // RVA: 0xC2AF00
        public void get_isEndEffector(){} // RVA: 0xC00EC0
        public void set_isEndEffector(){} // RVA: 0xC00ED0
        public void PinToBone(){} // RVA: 0xC2AF60
        public void .ctor(){} // RVA: 0xC2B460
        public void IsValid(){} // RVA: 0xC2B860
        public void Initiate(){} // RVA: 0xC2BE80
        public void ResetOffset(){} // RVA: 0xC2C500
        public void SetToTarget(){} // RVA: 0xC2C6F0
        public void OnPreSolve(){} // RVA: 0xC2C920
        public void OnPostWrite(){} // RVA: 0xC2D540
        public void GetPlaneRotation(){} // RVA: 0xC2D590
        public void Update(){} // RVA: 0xC2D910
        public void GetPosition(){} // RVA: 0xC2DDA0
    }

    public class IKEffector[] : Array
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

    public class IKExecutionOrder : MonoBehaviour
    {
        public object IKComponents;
        public object animator;
        public object fixedFrame;

        // ── Methods ──
        public void get_animatePhysics(){} // RVA: 0xC17420
        public void Start(){} // RVA: 0xC17520
        public void Update(){} // RVA: 0xC176F0
        public void FixedUpdate(){} // RVA: 0xC17720
        public void LateUpdate(){} // RVA: 0xC17750
        public void FixTransforms(){} // RVA: 0xC178E0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class IKMapping : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0xC2E4C0
        public void Initiate(){} // RVA: 0xB43310
        public void BoneIsValid(){} // RVA: 0xC2E4D0
        public void SolveFABRIKJoint(){} // RVA: 0xC26420
        public void .ctor(){} // RVA: 0xB43310
    }

    public class IKMappingBone : IKMapping
    {
        public object bone;
        public object maintainRotationWeight;
        public object boneMap;

        // ── Methods ──
        public void IsValid(){} // RVA: 0xC327B0
        public void .ctor(){} // RVA: 0xC329B0
        public void StoreDefaultLocalState(){} // RVA: 0xC32AE0
        public void FixTransforms(){} // RVA: 0xC32B00
        public void Initiate(){} // RVA: 0xC32B30
        public void ReadPose(){} // RVA: 0xC32C90
        public void WritePose(){} // RVA: 0xC32CB0
    }

    public class IKMappingBone[] : Array
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

    public class IKMappingLimb : IKMapping
    {
        public object parentBone;
        public object bone1;
        public object bone2;
        public object bone3;
        public object maintainRotationWeight;
        public object weight;
        public object updatePlaneRotations;
        public object boneMapParent;
        public object boneMap1;
        public object boneMap2;
        public object boneMap3;

        // ── Methods ──
        public void IsValid(){} // RVA: 0xC32CE0
        public void GetBoneMap(){} // RVA: 0xC32D80
        public void SetLimbOrientation(){} // RVA: 0xC32EC0
        public void .ctor(){} // RVA: 0xC33E40
        public void SetBones(){} // RVA: 0xC340D0
        public void StoreDefaultLocalState(){} // RVA: 0xC34220
        public void FixTransforms(){} // RVA: 0xC34330
        public void Initiate(){} // RVA: 0xC34450
        public void ReadPose(){} // RVA: 0xC34AC0
        public void WritePose(){} // RVA: 0xC34B40
    }

    public class IKMappingLimb[] : Array
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

    public class IKMappingSpine : IKMapping
    {
        public object spineBones;
        public object leftUpperArmBone;
        public object rightUpperArmBone;
        public object leftThighBone;
        public object rightThighBone;
        public object iterations;
        public object twistWeight;
        public object rootNodeIndex;
        public object spine;
        public object leftUpperArm;
        public object rightUpperArm;
        public object leftThigh;
        public object rightThigh;
        public object useFABRIK;

        // ── Methods ──
        public void IsValid(){} // RVA: 0xC34D80
        public void .ctor(){} // RVA: 0xC35820
        public void SetBones(){} // RVA: 0xC35B30
        public void StoreDefaultLocalState(){} // RVA: 0xC35CE0
        public void FixTransforms(){} // RVA: 0xC35ED0
        public void Initiate(){} // RVA: 0xC35F60
        public void UseFABRIK(){} // RVA: 0xC36CF0
        public void ReadPose(){} // RVA: 0xC36D20
        public void WritePose(){} // RVA: 0xC37240
        public void ForwardReach(){} // RVA: 0xC377E0
        public void BackwardReach(){} // RVA: 0xC37A30
        public void MapToSolverPositions(){} // RVA: 0xC37C60
    }

    public class IKSolver : Object
    {
        public object IKPosition;
        public object IKPositionWeight;
        public object _initiated;
        public object OnPreInitiate;
        public object OnPostInitiate;
        public object OnPreUpdate;
        public object OnPostUpdate;
        public object firstInitiation;
        public object root;

        // ── Methods ──
        public void IsValid(){} // RVA: 0x87D350
        public void Initiate(){} // RVA: 0xC380D0
        public void Update(){} // RVA: 0xC382B0
        public void GetIKPosition(){} // RVA: 0xB60220
        public void SetIKPosition(){} // RVA: 0xB60240
        public void GetIKPositionWeight(){} // RVA: 0xC152D0
        public void SetIKPositionWeight(){} // RVA: 0xC38330
        public void GetRoot(){} // RVA: 0xBE58B0
        public void get_initiated(){} // RVA: 0xC38360
        public void set_initiated(){} // RVA: 0xC38370
        public void GetPoints(){} // RVA: 0x87C0A0
        public void GetPoint(){} // RVA: 0x87C540
        public void FixTransforms(){} // RVA: 0x894290
        public void StoreDefaultLocalState(){} // RVA: 0x894290
        public void OnInitiate(){} // RVA: 0x894290
        public void OnUpdate(){} // RVA: 0x894290
        public void LogWarning(){} // RVA: 0xC38380
        public void ContainsDuplicateBone(){} // RVA: 0xC38430
        public void HierarchyIsValid(){} // RVA: 0xC38630
        public void PreSolveBones(){} // RVA: 0xC386D0
        public void .ctor(){} // RVA: 0xC38BA0
    }

    public class IKSolverAim : IKSolverHeuristic
    {
        public object transform;
        public object axis;
        public object poleAxis;
        public object polePosition;
        public object poleWeight;
        public object poleTarget;
        public object clampWeight;
        public object clampSmoothing;
        public object OnPreIteration;
        public object step;
        public object clampedIKPosition;
        public object transformLimit;
        public object lastTransform;

        // ── Methods ──
        public void GetAngle(){} // RVA: 0xC3B400
        public void get_transformAxis(){} // RVA: 0xC3B550
        public void get_transformPoleAxis(){} // RVA: 0xC3B810
        public void OnInitiate(){} // RVA: 0xC3BAD0
        public void OnUpdate(){} // RVA: 0xC3C030
        public void get_minBones(){} // RVA: 0xC3CCE0
        public void Solve(){} // RVA: 0xC3CCF0
        public void GetClampedIKPosition(){} // RVA: 0xC3CE50
        public void RotateToTarget(){} // RVA: 0xC3D4F0
        public void get_localDirection(){} // RVA: 0xC3E610
        public void .ctor(){} // RVA: 0xC3E760
    }

    public class IKSolverArm : IKSolver
    {
        public object IKRotationWeight;
        public object IKRotation;
        public object chest;
        public object shoulder;
        public object upperArm;
        public object forearm;
        public object hand;
        public object isLeft;
        public object arm;
        public object positions;
        public object rotations;

        // ── Methods ──
        public void IsValid(){} // RVA: 0xC3E820
        public void SetChain(){} // RVA: 0xC3EF10
        public void GetPoints(){} // RVA: 0xC3F130
        public void GetPoint(){} // RVA: 0xC3F2E0
        public void StoreDefaultLocalState(){} // RVA: 0xC3F830
        public void FixTransforms(){} // RVA: 0xC3F890
        public void OnInitiate(){} // RVA: 0xC3F900
        public void OnUpdate(){} // RVA: 0xC3FAA0
        public void Solve(){} // RVA: 0xC3FB40
        public void Read(){} // RVA: 0xC3FBD0
        public void Write(){} // RVA: 0xC406C0
        public void .ctor(){} // RVA: 0xC40BD0
    }

    public class IKSolverCCD : IKSolverHeuristic
    {
        public object OnPreIteration;

        // ── Methods ──
        public void FadeOutBoneWeights(){} // RVA: 0xC41100
        public void OnInitiate(){} // RVA: 0xC411B0
        public void OnUpdate(){} // RVA: 0xC41350
        public void Solve(){} // RVA: 0xC418C0
        public void .ctor(){} // RVA: 0xC425E0
    }

    public class IKSolverFABRIK : IKSolverHeuristic
    {
        public object OnPreIteration;
        public object limitedBones;
        public object solverLocalPositions;

        // ── Methods ──
        public void SolveForward(){} // RVA: 0xC425F0
        public void SolveBackward(){} // RVA: 0xC426A0
        public void GetIKPosition(){} // RVA: 0xC427A0
        public void OnInitiate(){} // RVA: 0xC42940
        public void OnUpdate(){} // RVA: 0xC431C0
        public void get_boneLengthCanBeZero(){} // RVA: 0xB43320
        public void SolveJoint(){} // RVA: 0xC43760
        public void OnPreSolve(){} // RVA: 0xC438B0
        public void OnPostSolve(){} // RVA: 0xC43F00
        public void Solve(){} // RVA: 0xC43F50
        public void ForwardReach(){} // RVA: 0xC440A0
        public void SolverMove(){} // RVA: 0xC44410
        public void SolverRotate(){} // RVA: 0xC444C0
        public void SolverRotateChildren(){} // RVA: 0xC446C0
        public void SolverMoveChildrenAroundPoint(){} // RVA: 0xC448A0
        public void GetParentSolverRotation(){} // RVA: 0xC44B80
        public void GetParentSolverPosition(){} // RVA: 0xC44DE0
        public void GetLimitedRotation(){} // RVA: 0xC45060
        public void LimitForward(){} // RVA: 0xC45420
        public void BackwardReach(){} // RVA: 0xC45B60
        public void BackwardReachUnlimited(){} // RVA: 0xC45BA0
        public void BackwardReachLimited(){} // RVA: 0xC45E00
        public void MapToSolverPositions(){} // RVA: 0xC46B30
        public void MapToSolverPositionsLimited(){} // RVA: 0xC46D50
        public void .ctor(){} // RVA: 0xC46F80
    }

    public class IKSolverFABRIKRoot : IKSolver
    {
        public object iterations;
        public object rootPin;
        public object chains;
        public object zeroWeightApplied;
        public object isRoot;
        public object rootDefaultPosition;

        // ── Methods ──
        public void IsValid(){} // RVA: 0xC470A0
        public void StoreDefaultLocalState(){} // RVA: 0xC47AB0
        public void FixTransforms(){} // RVA: 0xC47C00
        public void OnInitiate(){} // RVA: 0xC47D50
        public void IsRoot(){} // RVA: 0xC47F60
        public void OnUpdate(){} // RVA: 0xC47FF0
        public void GetPoints(){} // RVA: 0xC482F0
        public void GetPoint(){} // RVA: 0xC483B0
        public void AddPointsToArray(){} // RVA: 0xC48470
        public void GetCentroid(){} // RVA: 0xC48650
        public void .ctor(){} // RVA: 0xC48A90
    }

    public class IKSolverFullBody : IKSolver
    {
        public object iterations;
        public object chain;
        public object effectors;
        public object spineMapping;
        public object boneMappings;
        public object limbMappings;
        public object FABRIKPass;
        public object OnPreRead;
        public object OnPreSolve;
        public object OnPreIteration;
        public object OnPostIteration;
        public object OnPreBend;
        public object OnPostSolve;
        public object OnStoreDefaultLocalState;
        public object OnFixTransforms;

        // ── Methods ──
        public void GetEffector(){} // RVA: 0xC48B30
        public void GetChain(){} // RVA: 0xC48CE0
        public void GetChainIndex(){} // RVA: 0xC48D30
        public void GetNode(){} // RVA: 0xC48F20
        public void GetChainAndNodeIndexes(){} // RVA: 0xC48F70
        public void GetPoints(){} // RVA: 0xC49160
        public void GetPoint(){} // RVA: 0xC49330
        public void IsValid(){} // RVA: 0xC49550
        public void StoreDefaultLocalState(){} // RVA: 0xC49860
        public void FixTransforms(){} // RVA: 0xC49AA0
        public void OnInitiate(){} // RVA: 0xC49D80
        public void OnUpdate(){} // RVA: 0xC49F30
        public void ReadPose(){} // RVA: 0xC4A180
        public void Solve(){} // RVA: 0xC4A520
        public void ApplyBendConstraints(){} // RVA: 0xC4A890
        public void WritePose(){} // RVA: 0xC4A8D0
        public void .ctor(){} // RVA: 0xC4AA20
    }

    public class IKSolverFullBodyBiped : IKSolverFullBody
    {
        public object rootNode;
        public object spineStiffness;
        public object pullBodyVertical;
        public object pullBodyHorizontal;
        public object _pullBodyOffset;
        public object offset;

        // ── Methods ──
        public void get_bodyEffector(){} // RVA: 0xC4ACC0
        public void get_leftShoulderEffector(){} // RVA: 0xC4ACF0
        public void get_rightShoulderEffector(){} // RVA: 0xC4AD20
        public void get_leftThighEffector(){} // RVA: 0xC4AD50
        public void get_rightThighEffector(){} // RVA: 0xC4AD80
        public void get_leftHandEffector(){} // RVA: 0xC4ADB0
        public void get_rightHandEffector(){} // RVA: 0xC4ADE0
        public void get_leftFootEffector(){} // RVA: 0xC4AE10
        public void get_rightFootEffector(){} // RVA: 0xC4AE40
        public void get_leftArmChain(){} // RVA: 0xC4AE70
        public void get_rightArmChain(){} // RVA: 0xC4AEA0
        public void get_leftLegChain(){} // RVA: 0xC4AED0
        public void get_rightLegChain(){} // RVA: 0xC4AF00
        public void get_leftArmMapping(){} // RVA: 0xC4AF30
        public void get_rightArmMapping(){} // RVA: 0xC4AF60
        public void get_leftLegMapping(){} // RVA: 0xC4AF90
        public void get_rightLegMapping(){} // RVA: 0xC4AFC0
        public void get_headMapping(){} // RVA: 0xC4AFF0
        public void SetChainWeights(){} // RVA: 0xC4B020
        public void SetEffectorWeights(){} // RVA: 0xC4B090
        public void GetChain(){} // RVA: 0xC4B1E0
        public void GetEffector(){} // RVA: 0xC4B2D0
        public void GetEndEffector(){} // RVA: 0xC4B430
        public void GetLimbMapping(){} // RVA: 0xC4B560
        public void GetSpineMapping(){} // RVA: 0xC10050
        public void GetHeadMapping(){} // RVA: 0xC4AFF0
        public void GetBendConstraint(){} // RVA: 0xC4B650
        public void IsValid(){} // RVA: 0xC4B6E0
        public void SetToReferences(){} // RVA: 0xC4B9F0
        public void DetectRootNodeBone(){} // RVA: 0xC4DAA0
        public void SetLimbOrientations(){} // RVA: 0xC4E2B0
        public void get_pullBodyOffset(){} // RVA: 0xBAE560
        public void set_pullBodyOffset(){} // RVA: 0xBAE580
        public void SetLimbOrientation(){} // RVA: 0xC4E320
        public void GetLeftClavicle(){} // RVA: 0xC4E5B0
        public void GetRightClavicle(){} // RVA: 0xC4E6D0
        public void Contains(){} // RVA: 0xC4E7F0
        public void ReadPose(){} // RVA: 0xC4E960
        public void PullBody(){} // RVA: 0xC4EC50
        public void GetBodyOffset(){} // RVA: 0xC4EE30
        public void GetHandBodyPull(){} // RVA: 0xC4F110
        public void ApplyBendConstraints(){} // RVA: 0xC4F3A0
        public void WritePose(){} // RVA: 0xC4F860
        public void .ctor(){} // RVA: 0xC4FB40
    }

    public class IKSolverHeuristic : IKSolver
    {
        public object target;
        public object tolerance;
        public object maxIterations;
        public object useRotationLimits;
        public object XY;
        public object bones;
        public object lastLocalDirection;
        public object chainLength;

        // ── Methods ──
        public void SetChain(){} // RVA: 0xC4FB60
        public void AddBone(){} // RVA: 0xC4FD60
        public void StoreDefaultLocalState(){} // RVA: 0xC4FF40
        public void FixTransforms(){} // RVA: 0xC50130
        public void IsValid(){} // RVA: 0xC501C0
        public void GetPoints(){} // RVA: 0xC10050
        public void GetPoint(){} // RVA: 0xC508D0
        public void get_minBones(){} // RVA: 0xC50A80
        public void get_boneLengthCanBeZero(){} // RVA: 0xC2E4C0
        public void get_allowCommonParent(){} // RVA: 0xB43320
        public void OnInitiate(){} // RVA: 0xB43310
        public void OnUpdate(){} // RVA: 0xB43310
        public void InitiateBones(){} // RVA: 0xC50A90
        public void get_localDirection(){} // RVA: 0xC51170
        public void get_positionOffset(){} // RVA: 0xC51440
        public void GetSingularityOffset(){} // RVA: 0xC514B0
        public void SingularityDetected(){} // RVA: 0xC51A30
        public void .ctor(){} // RVA: 0xC51E50
    }

    public class IKSolverLeg : IKSolver
    {
        public object IKRotationWeight;
        public object IKRotation;
        public object pelvis;
        public object thigh;
        public object calf;
        public object foot;
        public object toe;
        public object leg;
        public object heelOffset;
        public object positions;
        public object rotations;

        // ── Methods ──
        public void IsValid(){} // RVA: 0xC51F00
        public void SetChain(){} // RVA: 0xC3EF10
        public void GetPoints(){} // RVA: 0xC525F0
        public void GetPoint(){} // RVA: 0xC527A0
        public void StoreDefaultLocalState(){} // RVA: 0xC3F830
        public void FixTransforms(){} // RVA: 0xC3F890
        public void OnInitiate(){} // RVA: 0xC52CF0
        public void OnUpdate(){} // RVA: 0xC52E90
        public void Solve(){} // RVA: 0xC52F90
        public void Read(){} // RVA: 0xC53080
        public void Write(){} // RVA: 0xC53B70
        public void .ctor(){} // RVA: 0xC54080
    }

    public class IKSolverLimb : IKSolverTrigonometric
    {
        public object goal;
        public object bendModifier;
        public object maintainRotationWeight;
        public object bendModifierWeight;
        public object bendGoal;
        public object maintainBendFor1Frame;
        public object maintainRotationFor1Frame;
        public object defaultRootRotation;
        public object parentDefaultRotation;
        public object bone3RotationBeforeSolve;
        public object maintainRotation;
        public object bone3DefaultRotation;
        public object _bendNormal;
        public object animationNormal;
        public object axisDirectionsLeft;
        public object axisDirectionsRight;

        // ── Methods ──
        public void MaintainRotation(){} // RVA: 0xC545B0
        public void MaintainBend(){} // RVA: 0xC546A0
        public void OnInitiateVirtual(){} // RVA: 0xC546F0
        public void OnUpdateVirtual(){} // RVA: 0xC550A0
        public void OnPostSolveVirtual(){} // RVA: 0xC55250
        public void .ctor(){} // RVA: 0xC555B0
        public void get_axisDirections(){} // RVA: 0xC556E0
        public void StoreAxisDirections(){} // RVA: 0xC55700
        public void GetModifiedBendNormal(){} // RVA: 0xC55D50
    }

    public class IKSolverLimb[] : Array
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

    public class IKSolverLookAt : IKSolver
    {
        public object target;
        public object spine;
        public object head;
        public object eyes;
        public object bodyWeight;
        public object headWeight;
        public object eyesWeight;
        public object clampWeight;
        public object clampWeightHead;
        public object clampWeightEyes;
        public object clampSmoothing;
        public object spineWeightCurve;
        public object spineTargetOffset;
        public object spineForwards;
        public object headForwards;
        public object eyeForward;

        // ── Methods ──
        public void SetLookAtWeight(){} // RVA: 0xC576D0
        public void StoreDefaultLocalState(){} // RVA: 0xC577B0
        public void FixTransforms(){} // RVA: 0xC57990
        public void IsValid(){} // RVA: 0xC57B80
        public void GetPoints(){} // RVA: 0xC58100
        public void GetPoint(){} // RVA: 0xC58550
        public void SetChain(){} // RVA: 0xC588F0
        public void OnInitiate(){} // RVA: 0xC589F0
        public void OnUpdate(){} // RVA: 0xC59110
        public void get_spineIsValid(){} // RVA: 0xC592F0
        public void get_spineIsEmpty(){} // RVA: 0xC59450
        public void SolveSpine(){} // RVA: 0xC59470
        public void get_headIsValid(){} // RVA: 0xC597D0
        public void get_headIsEmpty(){} // RVA: 0xC597E0
        public void SolveHead(){} // RVA: 0xC598C0
        public void get_eyesIsValid(){} // RVA: 0xC59DA0
        public void get_eyesIsEmpty(){} // RVA: 0xC59F00
        public void SolveEyes(){} // RVA: 0xC59F20
        public void GetForwards(){} // RVA: 0xC5A6F0
        public void SetBones(){} // RVA: 0xC5AB00
        public void .ctor(){} // RVA: 0xC5AD40
    }

    public class IKSolverTrigonometric : IKSolver
    {
        public object target;
        public object IKRotationWeight;
        public object IKRotation;
        public object bendNormal;
        public object bone1;
        public object bone2;
        public object bone3;
        public object weightIKPosition;
        public object directHierarchy;

        // ── Methods ──
        public void SetBendGoalPosition(){} // RVA: 0xC5BC80
        public void SetBendPlaneToCurrent(){} // RVA: 0xC5C040
        public void SetIKRotation(){} // RVA: 0xC5C450
        public void SetIKRotationWeight(){} // RVA: 0xC5C460
        public void GetIKRotation(){} // RVA: 0xC5C490
        public void GetIKRotationWeight(){} // RVA: 0xC5C4A0
        public void GetPoints(){} // RVA: 0xC5C4B0
        public void GetPoint(){} // RVA: 0xC5C5E0
        public void StoreDefaultLocalState(){} // RVA: 0xC5C930
        public void FixTransforms(){} // RVA: 0xC5C980
        public void IsValid(){} // RVA: 0xC5C9E0
        public void SetChain(){} // RVA: 0xC5D080
        public void Solve(){} // RVA: 0xC5D1E0
        public void GetDirectionToBendPoint(){} // RVA: 0xC5E1F0
        public void OnInitiate(){} // RVA: 0xC5E5D0
        public void IsDirectHierarchy(){} // RVA: 0xC5E860
        public void InitiateBones(){} // RVA: 0xC5EAD0
        public void OnUpdate(){} // RVA: 0xC5ED00
        public void OnInitiateVirtual(){} // RVA: 0xB43310
        public void OnUpdateVirtual(){} // RVA: 0xB43310
        public void OnPostSolveVirtual(){} // RVA: 0xB43310
        public void GetBendDirection(){} // RVA: 0xC60090
        public void .ctor(){} // RVA: 0xC60630
    }

    public class IKSolverVR : IKSolver
    {
        public object solverTransforms;
        public object hasChest;
        public object hasNeck;
        public object hasShoulders;
        public object hasToes;
        public object hasLegs;
        public object hasUpperChest;
        public object readPositions;
        public object readRotations;
        public object solvedPositions;
        public object solvedRotations;
        public object defaultLocalRotations;
        public object defaultLocalPositions;
        public object rootV;
        public object rootVelocity;
        public object bodyOffset;
        public object supportLegIndex;
        public object lastLOD;
        public object LOD;
        public object plantFeet;
        public object _rootBone;
        public object spine;
        public object leftArm;
        public object rightArm;
        public object leftLeg;
        public object rightLeg;
        public object locomotion;
        public object legs;
        public object arms;
        public object headPosition;
        public object headDeltaPosition;
        public object raycastOriginPelvis;
        public object lastOffset;
        public object debugPos1;
        public object debugPos2;
        public object debugPos3;
        public object debugPos4;
        public object vrcLateSolve;

        // ── Methods ──
        public void SetToReferences(){} // RVA: 0xC61250
        public void GuessHandOrientations(){} // RVA: 0xC619E0
        public void DefaultAnimationCurves(){} // RVA: 0xC61E40
        public void AddPositionOffset(){} // RVA: 0xC62080
        public void AddRotationOffset(){} // RVA: 0xC623D0
        public void AddPlatformMotion(){} // RVA: 0xC627B0
        public void Reset(){} // RVA: 0xC62BF0
        public void StoreDefaultLocalState(){} // RVA: 0xC62F10
        public void FixTransforms(){} // RVA: 0xC63110
        public void GetPoints(){} // RVA: 0xC634B0
        public void GetPoint(){} // RVA: 0xC63510
        public void IsValid(){} // RVA: 0xC63570
        public void GetNormal(){} // RVA: 0xC63920
        public void GuessWristToPalmAxis(){} // RVA: 0xC63EA0
        public void GuessPalmToThumbAxis(){} // RVA: 0xC64320
        public void GetSineKeyframes(){} // RVA: 0xC64F70
        public void UpdateSolverTransforms(){} // RVA: 0xC65000
        public void OnInitiate(){} // RVA: 0xC651F0
        public void OnUpdate(){} // RVA: 0xC65250
        public void WriteTransforms(){} // RVA: 0xC65BA0
        public void Read(){} // RVA: 0xC666B0
        public void Solve(){} // RVA: 0xC67210
        public void GetPosition(){} // RVA: 0xC68E20
        public void GetRotation(){} // RVA: 0xC68E70
        public void get_rootBone(){} // RVA: 0xC68EB0
        public void set_rootBone(){} // RVA: 0xC68EC0
        public void VrcRead(){} // RVA: 0xC651F0
        public void VrcWrite(){} // RVA: 0xC68F20
        public void VrcWriteTransforms(){} // RVA: 0xC68F30
        public void VrcSyncIk(){} // RVA: 0xC68F40
        public void VrcLateSolve(){} // RVA: 0xC68F60
        public void Write(){} // RVA: 0xC68FC0
        public void GetPelvisOffset(){} // RVA: 0xC69160
        public void .ctor(){} // RVA: 0xC69C70
    }

    public class IKSolver[] : Array
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

    public class IK[] : Array
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

    public class Inertia : OffsetModifier
    {
        public object bodies;
        public object limits;

        // ── Methods ──
        public void ResetBodies(){} // RVA: 0xCBDB80
        public void OnModifyOffset(){} // RVA: 0xCBDC30
        public void .ctor(){} // RVA: 0xB4B830
    }

    public class InteractionEffector : Object
    {
        public object _effectorType;
        public object _isPaused;
        public object _interactionObject;
        public object poser;
        public object effector;
        public object timer;
        public object length;
        public object weight;
        public object fadeInSpeed;
        public object defaultPositionWeight;
        public object defaultRotationWeight;
        public object defaultPull;
        public object defaultReach;
        public object defaultPush;
        public object defaultPushParent;
        public object defaultBendGoalWeight;
        public object resetTimer;
        public object positionWeightUsed;
        public object rotationWeightUsed;
        public object pullUsed;
        public object reachUsed;
        public object pushUsed;
        public object pushParentUsed;
        public object bendGoalWeightUsed;
        public object pickedUp;
        public object defaults;
        public object pickUpOnPostFBBIK;
        public object pickUpPosition;
        public object pausePositionRelative;
        public object pickUpRotation;
        public object pauseRotationRelative;
        public object interactionTarget;
        public object target;
        public object triggered;
        public object interactionSystem;
        public object started;

        // ── Methods ──
        public void get_effectorType(){} // RVA: 0xB8F8F0
        public void set_effectorType(){} // RVA: 0xB460A0
        public void get_isPaused(){} // RVA: 0xC9C250
        public void set_isPaused(){} // RVA: 0xC9C260
        public void get_interactionObject(){} // RVA: 0xB465B0
        public void set_interactionObject(){} // RVA: 0xBA9BA0
        public void get_inInteraction(){} // RVA: 0xC9C270
        public void .ctor(){} // RVA: 0xC9C340
        public void Initiate(){} // RVA: 0xC9C410
        public void StoreDefaults(){} // RVA: 0xC9C5D0
        public void ResetToDefaults(){} // RVA: 0xC9C7C0
        public void Pause(){} // RVA: 0xC9CC80
        public void Resume(){} // RVA: 0xC9D060
        public void Start(){} // RVA: 0xC9D0C0
        public void Update(){} // RVA: 0xC9DC00
        public void get_progress(){} // RVA: 0xC9E9B0
        public void TriggerUntriggeredEvents(){} // RVA: 0xC9E9F0
        public void PickUp(){} // RVA: 0xC9ED00
        public void Stop(){} // RVA: 0xC9F0D0
        public void OnPostFBBIK(){} // RVA: 0xC9F500
    }

    public class InteractionEffector[] : Array
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

    public class InteractionLookAt : Object
    {
        public object ik;
        public object lerpSpeed;
        public object weightSpeed;
        public object isPaused;
        public object lookAtTarget;
        public object stopLookTime;
        public object weight;
        public object firstFBBIKSolve;

        // ── Methods ──
        public void Look(){} // RVA: 0xC9FC30
        public void OnFixTransforms(){} // RVA: 0xC9FED0
        public void Update(){} // RVA: 0xC9FFD0
        public void SolveSpine(){} // RVA: 0xCA0460
        public void SolveHead(){} // RVA: 0xCA05F0
        public void .ctor(){} // RVA: 0xCA0730
    }

    public class InteractionObject : MonoBehaviour
    {
        public object otherLookAtTarget;
        public object otherTargetsRoot;
        public object positionOffsetSpace;
        public object weightCurves;
        public object multipliers;
        public object events;
        public object _length;
        public object _lastUsedInteractionSystem;
        public object targets;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void OpenTutorial1(){} // RVA: 0xB43310
        public void OpenTutorial2(){} // RVA: 0xB43310
        public void OpenTutorial3(){} // RVA: 0xB43310
        public void OpenTutorial4(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void get_length(){} // RVA: 0xBAB430
        public void set_length(){} // RVA: 0xBAB440
        public void get_lastUsedInteractionSystem(){} // RVA: 0xC0FFC0
        public void set_lastUsedInteractionSystem(){} // RVA: 0xC0FFD0
        public void Initiate(){} // RVA: 0xCA0740
        public void get_lookAtTarget(){} // RVA: 0xCA0A00
        public void GetTarget(){} // RVA: 0xCA2150
        public void CurveUsed(){} // RVA: 0xCA0D30
        public void GetTargets(){} // RVA: 0xBE2C60
        public void OnStartInteraction(){} // RVA: 0xC0FFD0
        public void Apply(){} // RVA: 0xCA1A40
        public void GetValue(){} // RVA: 0xCA15E0
        public void get_targetsRoot(){} // RVA: 0xCA1940
        public void Start(){} // RVA: 0xCA1A30
        public void GetWeightCurveIndex(){} // RVA: 0xCA21D0
        public void GetMultiplierIndex(){} // RVA: 0xCA2230
        public void .ctor(){} // RVA: 0xCA2290
    }

    public class InteractionSystem : MonoBehaviour
    {
        public object targetTag;
        public object fadeInTime;
        public object speed;
        public object resetToDefaultsSpeed;
        public object characterCollider;
        public object FPSCamera;
        public object camRaycastLayers;
        public object camRaycastDistance;
        public object _triggersInRange;
        public object inContact;
        public object bestRangeIndexes;
        public object OnInteractionStart;
        public object OnInteractionPause;
        public object OnInteractionPickUp;
        public object OnInteractionResume;
        public object OnInteractionStop;
        public object OnInteractionEvent;
        public object raycastHit;
        public object fullBody;
        public object lookAt;
        public object interactionEffectors;
        public object initiated;
        public object lastCollider;
        public object c;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void OpenTutorial1(){} // RVA: 0xB43310
        public void OpenTutorial2(){} // RVA: 0xB43310
        public void OpenTutorial3(){} // RVA: 0xB43310
        public void OpenTutorial4(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void get_inInteraction(){} // RVA: 0xCA2BF0
        public void IsInInteraction(){} // RVA: 0xCA2CC0
        public void IsPaused(){} // RVA: 0xCA2E60
        public void IsInSync(){} // RVA: 0xCA2F30
        public void StartInteraction(){} // RVA: 0xCA3080
        public void PauseInteraction(){} // RVA: 0xCA3200
        public void ResumeInteraction(){} // RVA: 0xCA3290
        public void StopInteraction(){} // RVA: 0xCA3320
        public void PauseAll(){} // RVA: 0xCA33B0
        public void ResumeAll(){} // RVA: 0xCA3450
        public void StopAll(){} // RVA: 0xCA3540
        public void GetInteractionObject(){} // RVA: 0xCA35D0
        public void GetProgress(){} // RVA: 0xCA3660
        public void GetMinActiveProgress(){} // RVA: 0xCA36F0
        public void TriggerInteraction(){} // RVA: 0xCA3CC0
        public void GetClosestInteractionRange(){} // RVA: 0xCA40A0
        public void GetClosestInteractionObjectInRange(){} // RVA: 0xCA4190
        public void GetClosestInteractionTargetInRange(){} // RVA: 0xCA41E0
        public void GetClosestInteractionObjectsInRange(){} // RVA: 0xCA4250
        public void GetClosestInteractionTargetsInRange(){} // RVA: 0xCA43F0
        public void TriggerEffectorsReady(){} // RVA: 0xCA45B0
        public void GetTriggerRange(){} // RVA: 0xCA4990
        public void GetClosestTriggerIndex(){} // RVA: 0xCA4AD0
        public void get_ik(){} // RVA: 0xCA4D80
        public void set_ik(){} // RVA: 0xCA4D90
        public void get_triggersInRange(){} // RVA: 0xBE58B0
        public void set_triggersInRange(){} // RVA: 0xCA4DF0
        public void Start(){} // RVA: 0xCA4E50
        public void InteractionPause(){} // RVA: 0xCA5910
        public void InteractionResume(){} // RVA: 0xCA5930
        public void InteractionStop(){} // RVA: 0xCA5930
        public void LookAtInteraction(){} // RVA: 0xCA5950
        public void OnTriggerEnter(){} // RVA: 0xCA5AB0
        public void OnTriggerExit(){} // RVA: 0xCA5CE0
        public void ContactIsInRange(){} // RVA: 0xCA5EB0
        public void OnDrawGizmosSelected(){} // RVA: 0xCA6110
        public void Update(){} // RVA: 0xCA63D0
        public void Raycasting(){} // RVA: 0xCA6760
        public void UpdateTriggerEventBroadcasting(){} // RVA: 0xCA69A0
        public void UpdateEffectors(){} // RVA: 0xCA7120
        public void OnPreFBBIK(){} // RVA: 0xCA73A0
        public void OnPostFBBIK(){} // RVA: 0xCA7610
        public void OnFixTransforms(){} // RVA: 0xCA7890
        public void OnDestroy(){} // RVA: 0xCA79A0
        public void IsValid(){} // RVA: 0xCA8190
        public void TriggerIndexIsValid(){} // RVA: 0xCA82F0
        public void .ctor(){} // RVA: 0xCA84A0
    }

    public class InteractionTarget : MonoBehaviour
    {
        public object effectorType;
        public object multipliers;
        public object interactionSpeedMlp;
        public object pivot;
        public object twistAxis;
        public object twistWeight;
        public object swingWeight;
        public object rotateOnce;
        public object defaultLocalRotation;
        public object lastPivot;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void OpenTutorial1(){} // RVA: 0xB43310
        public void OpenTutorial2(){} // RVA: 0xB43310
        public void OpenTutorial3(){} // RVA: 0xB43310
        public void OpenTutorial4(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void GetValue(){} // RVA: 0xCA8E10
        public void ResetRotation(){} // RVA: 0xCA8E90
        public void RotateTo(){} // RVA: 0xCA8FF0
        public void .ctor(){} // RVA: 0xCAA070
    }

    public class InteractionTarget[] : Array
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

    public class InteractionTrigger : MonoBehaviour
    {
        public object ranges;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void OpenTutorial4(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void Start(){} // RVA: 0xB43310
        public void GetBestRangeIndex(){} // RVA: 0xCAA110
        public void .ctor(){} // RVA: 0xCAA470
    }

    public class InteractionTrigger[] : Array
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

}