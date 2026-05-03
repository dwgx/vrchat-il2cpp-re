// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.Dynamics
// Classes: 31
// Methods: 572

namespace ThirdParty.Other.RootMotion.Dynamics
{
    public class AnimationBlocker : MonoBehaviour
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x7FFE81157D90
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class BehaviourBase : MonoBehaviour
    {
        public RootMotion.Dynamics.PuppetMaster puppetMaster; // 0x20

        // ── Methods ──
        public void OnReactivate(){} // RVA: 0x7FFE80E45FE0
        public void Resurrect(){} // RVA: 0x7FFE810FB310
        public void Freeze(){} // RVA: 0x7FFE810FB310
        public void Unfreeze(){} // RVA: 0x7FFE810FB310
        public void KillStart(){} // RVA: 0x7FFE810FB310
        public void KillEnd(){} // RVA: 0x7FFE810FB310
        public void OnTeleport(){} // RVA: 0x7FFE810FB310
        public void OnMuscleDisconnected(){} // RVA: 0x7FFE810FB310
        public void OnMuscleReconnected(){} // RVA: 0x7FFE810FB310
        public void OnMuscleAdded(){} // RVA: 0x7FFE81157F60
        public void OnMuscleRemoved(){} // RVA: 0x7FFE81157F60
        public void OnActivate(){} // RVA: 0x7FFE810FB310
        public void OnDeactivate(){} // RVA: 0x7FFE810FB310
        public void OnInitiate(){} // RVA: 0x7FFE810FB310
        public void OnFixedUpdate(){} // RVA: 0x7FFE810FB310
        public void OnUpdate(){} // RVA: 0x7FFE810FB310
        public void OnLateUpdate(){} // RVA: 0x7FFE810FB310
        public void OnDrawGizmosBehaviour(){} // RVA: 0x7FFE810FB310
        public void OnFixTransformsBehaviour(){} // RVA: 0x7FFE810FB310
        public void OnReadBehaviour(){} // RVA: 0x7FFE810FB310
        public void OnWriteBehaviour(){} // RVA: 0x7FFE810FB310
        public void OnMuscleHitBehaviour(){} // RVA: 0x7FFE810FB310
        public void OnMuscleCollisionBehaviour(){} // RVA: 0x7FFE810FB310
        public void OnMuscleCollisionExitBehaviour(){} // RVA: 0x7FFE810FB310
        public void get_forceActive(){} // RVA: 0x7FFE81157F90
        public void set_forceActive(){} // RVA: 0x7FFE81157FA0
        public void Initiate(){} // RVA: 0x7FFE81157FB0
        public void OnFixTransforms(){} // RVA: 0x7FFE81158020
        public void OnRead(){} // RVA: 0x7FFE811580E0
        public void OnWrite(){} // RVA: 0x7FFE811581A0
        public void OnMuscleHit(){} // RVA: 0x7FFE81158260
        public void OnMuscleCollision(){} // RVA: 0x7FFE81158320
        public void OnMuscleCollisionExit(){} // RVA: 0x7FFE811583E0
        public void OnEnable(){} // RVA: 0x7FFE811584B0
        public void Activate(){} // RVA: 0x7FFE811584D0
        public void OnDisable(){} // RVA: 0x7FFE811586D0
        public void FixedUpdateB(){} // RVA: 0x7FFE81158740
        public void UpdateB(){} // RVA: 0x7FFE81158850
        public void LateUpdateB(){} // RVA: 0x7FFE81158960
        public void OnDrawGizmos(){} // RVA: 0x7FFE81158A70
        public void RotateTargetToRootMuscle(){} // RVA: 0x7FFE81158AC0
        public void TranslateTargetToRootMuscle(){} // RVA: 0x7FFE81159030
        public void RemovePropMuscles(){} // RVA: 0x7FFE81159390
        public void GroundTarget(){} // RVA: 0x7FFE811594D0
        public void ContainsRemovablePropMuscle(){} // RVA: 0x7FFE81159910
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class BehaviourFall : BehaviourBase
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void OnActivate(){} // RVA: 0x7FFE8115A7C0
        public void OnDeactivate(){} // RVA: 0x7FFE8115A8B0
        public void OnReactivate(){} // RVA: 0x7FFE8115A8C0
        public void SmoothActivate(){} // RVA: 0x7FFE8115A8E0
        public void OnFixedUpdate(){} // RVA: 0x7FFE8115A980
        public void OnLateUpdate(){} // RVA: 0x7FFE8115AD30
        public void Resurrect(){} // RVA: 0x7FFE8115AFB0
        public void GetBlendTarget(){} // RVA: 0x7FFE8115B010
        public void GetGroundHeight(){} // RVA: 0x7FFE8115B1F0
        public void OnMuscleReconnected(){} // RVA: 0x7FFE8115B470
        public void .ctor(){} // RVA: 0x7FFE8115B4B0
    }

    public class BehaviourPuppet : BehaviourBase
    {
        public MasterProps masterProps; // 0x100

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void get_state(){} // RVA: 0x7FFE8115B9C0
        public void set_state(){} // RVA: 0x7FFE8115B9D0
        public void OnReactivate(){} // RVA: 0x7FFE8115B9E0
        public void Reset(){} // RVA: 0x7FFE8115BB00
        public void OnTeleport(){} // RVA: 0x7FFE8115BB60
        public void OnInitiate(){} // RVA: 0x7FFE8115BDA0
        public void OnActivate(){} // RVA: 0x7FFE8115C7D0
        public void KillStart(){} // RVA: 0x7FFE8115C880
        public void KillEnd(){} // RVA: 0x7FFE8115C930
        public void Resurrect(){} // RVA: 0x7FFE8115C940
        public void OnDeactivate(){} // RVA: 0x7FFE8115C9D0
        public void OnFixedUpdate(){} // RVA: 0x7FFE8115C9E0
        public void OnLateUpdate(){} // RVA: 0x7FFE8115D3F0
        public void SetKinematic(){} // RVA: 0x7FFE8115D650
        public void OnReadBehaviour(){} // RVA: 0x7FFE8115D720
        public void BlendMuscleMapping(){} // RVA: 0x7FFE8115DD80
        public void OnMuscleAdded(){} // RVA: 0x7FFE8115DF80
        public void OnMuscleRemoved(){} // RVA: 0x7FFE8115DFE0
        public void MoveTarget(){} // RVA: 0x7FFE8115E030
        public void RotateTarget(){} // RVA: 0x7FFE8115E0C0
        public void GroundTarget(){} // RVA: 0x7FFE8115E150
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE8115E170
        public void Boost(){} // RVA: 0x7FFE8115E5B0 | overloaded x3
        public void BoostImmunity(){} // RVA: 0x7FFE8115E8B0 | overloaded x3
        public void BoostImpulseMlp(){} // RVA: 0x7FFE8115EB20 | overloaded x3
        public void Unpin(){} // RVA: 0x7FFE8115EC60
        public void OnMuscleHitBehaviour(){} // RVA: 0x7FFE8115ECE0
        public void OnMuscleCollisionBehaviour(){} // RVA: 0x7FFE8115EE80
        public void GetImpulse(){} // RVA: 0x7FFE8115F550
        public void UnPin(){} // RVA: 0x7FFE8115F7C0
        public void UnPinMuscle(){} // RVA: 0x7FFE8115F930
        public void Activate(){} // RVA: 0x7FFE8115FC10
        public void IsProne(){} // RVA: 0x7FFE8115FCA0
        public void GetFalloff(){} // RVA: 0x7FFE81160060 | overloaded x2
        public void InGroup(){} // RVA: 0x7FFE811601F0
        public void GetProps(){} // RVA: 0x7FFE811602B0
        public void SetState(){} // RVA: 0x7FFE811603B0
        public void SetColliders(){} // RVA: 0x7FFE81161510 | overloaded x2
        public void OnMuscleDisconnected(){} // RVA: 0x7FFE811617E0
        public void OnMuscleReconnected(){} // RVA: 0x7FFE811617F0
        public void .ctor(){} // RVA: 0x7FFE811618A0
    }

    public class BehaviourTemplate : BehaviourBase
    {
        // ── Methods ──
        public void OnInitiate(){} // RVA: 0x7FFE81161D60
        public void OnActivate(){} // RVA: 0x7FFE810FB310
        public void OnReactivate(){} // RVA: 0x7FFE810FB310
        public void OnDeactivate(){} // RVA: 0x7FFE810FB310
        public void OnFixedUpdate(){} // RVA: 0x7FFE81161D90
        public void OnLateUpdate(){} // RVA: 0x7FFE810FB310
        public void OnMuscleHitBehaviour(){} // RVA: 0x7FFE81161DE0
        public void OnMuscleCollisionBehaviour(){} // RVA: 0x7FFE81161DE0
        public void .ctor(){} // RVA: 0x7FFE81161E30
    }

    public class BipedRagdollCreator : RagdollCreator
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void OpenTutorial(){} // RVA: 0x7FFE810FB310
        public void AutodetectOptions(){} // RVA: 0x7FFE8119F2F0
        public void Create(){} // RVA: 0x7FFE8119F810
        public void CreateColliders(){} // RVA: 0x7FFE8119FA90
        public void CreateHandCollider(){} // RVA: 0x7FFE811A1EB0
        public void CreateFootCollider(){} // RVA: 0x7FFE811A25D0
        public void GetChildCentroid(){} // RVA: 0x7FFE811A3100
        public void MassDistribution(){} // RVA: 0x7FFE811A33A0
        public void CreateJoints(){} // RVA: 0x7FFE811A3EA0
        public void CreateLimbJoints(){} // RVA: 0x7FFE811A5100
        public void ClearBipedRagdoll(){} // RVA: 0x7FFE811A6200
        public void IsClear(){} // RVA: 0x7FFE811A6260
        public void GetUpperArmToHeadCentroid(){} // RVA: 0x7FFE811A63C0
        public void GetUpperArmCentroid(){} // RVA: 0x7FFE811A6520
        public void .ctor(){} // RVA: 0x7FFE811A6660
    }

    public class BipedRagdollReferences : ValueType
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE811A6760
        public void IsChildRecursive(){} // RVA: 0x7FFE811A7540
        public void IsEmpty(){} // RVA: 0x7FFE811A77F0
        public void Contains(){} // RVA: 0x7FFE811A8090
        public void GetRagdollTransforms(){} // RVA: 0x7FFE811A8CF0
        public void FromAvatar(){} // RVA: 0x7FFE811A9170
        public void FromBipedReferences(){} // RVA: 0x7FFE811A98C0
    }

    public class Booster : Object
    {
        // ── Methods ──
        public void Boost(){} // RVA: 0x7FFE81165A70
        public void .ctor(){} // RVA: 0x7FFE81165E70
    }

    public class JointBreakBroadcaster : MonoBehaviour
    {
        // ── Methods ──
        public void OnJointBreak(){} // RVA: 0x7FFE81165F90
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class JointConverter : Object
    {
        // ── Methods ──
        public void ToConfigurable(){} // RVA: 0x7FFE811A9EA0
        public void HingeToConfigurable(){} // RVA: 0x7FFE811AA270
        public void FixedToConfigurable(){} // RVA: 0x7FFE811AAAA0
        public void SpringToConfigurable(){} // RVA: 0x7FFE811AADD0
        public void CharacterToConfigurable(){} // RVA: 0x7FFE811AB220
        public void ConvertJoint(){} // RVA: 0x7FFE811ABBF0
        public void ConvertToHighSoftJointLimit(){} // RVA: 0x7FFE811AC180
        public void ConvertToLowSoftJointLimit(){} // RVA: 0x7FFE811AC1B0
        public void ConvertToSoftJointLimitSpring(){} // RVA: 0x7FFE811AC1D0
        public void CopyLimit(){} // RVA: 0x7FFE811AC200
        public void CopyLimitSpring(){} // RVA: 0x7FFE811AC220
    }

    public class Muscle : Object
    {
        public string name; // 0x10
        public UnityEngine.ConfigurableJoint joint; // 0x18
        public UnityEngine.Transform target; // 0x20
        public Props props; // 0x28
        public State state; // 0x30
        public int[] parentIndexes; // 0x70
        public int[] childIndexes; // 0x78
        public bool[] childFlags; // 0x80
        public int[] kinshipDegrees; // 0x88
        public RootMotion.Dynamics.MuscleCollisionBroadcaster broadcaster; // 0x90
        public RootMotion.Dynamics.JointBreakBroadcaster jointBreakBroadcaster; // 0x98
        public UnityEngine.Vector3 positionOffset; // 0xA0
        public UnityEngine.Transform _transform; // 0xB0
        public UnityEngine.Rigidbody _rigidbody; // 0xB8
        public UnityEngine.Transform _connectedBodyTarget; // 0xC0
        public UnityEngine.Vector3 _targetAnimatedPosition; // 0xC8
        public UnityEngine.Quaternion _targetAnimatedWorldRotation; // 0xD4
        public UnityEngine.Vector3 _targetVelocity; // 0xE4

        // ── Methods ──
        public void get_transform(){} // RVA: 0x7FFE81166040
        public void set_transform(){} // RVA: 0x7FFE81166050
        public void get_rigidbody(){} // RVA: 0x7FFE811660B0
        public void set_rigidbody(){} // RVA: 0x7FFE811660C0
        public void get_connectedBodyTarget(){} // RVA: 0x7FFE81166120
        public void set_connectedBodyTarget(){} // RVA: 0x7FFE81166130
        public void get_targetAnimatedPosition(){} // RVA: 0x7FFE81166190
        public void set_targetAnimatedPosition(){} // RVA: 0x7FFE811661B0
        public void get_targetAnimatedWorldRotation(){} // RVA: 0x7FFE811661D0
        public void set_targetAnimatedWorldRotation(){} // RVA: 0x7FFE811661E0
        public void get_colliders(){} // RVA: 0x7FFE811661F0
        public void set_colliders(){} // RVA: 0x7FFE81166200
        public void get_targetVelocity(){} // RVA: 0x7FFE81166260
        public void set_targetVelocity(){} // RVA: 0x7FFE81166280
        public void get_additionalRigidbody(){} // RVA: 0x7FFE811662A0
        public void set_additionalRigidbody(){} // RVA: 0x7FFE811662B0
        public void get_targetRotationRelative(){} // RVA: 0x7FFE81166310
        public void set_targetRotationRelative(){} // RVA: 0x7FFE81166320
        public void IsValid(){} // RVA: 0x7FFE81166330
        public void get_rebuildConnectedBody(){} // RVA: 0x7FFE811665F0
        public void set_rebuildConnectedBody(){} // RVA: 0x7FFE81166600
        public void get_rebuildTargetParent(){} // RVA: 0x7FFE81166660
        public void set_rebuildTargetParent(){} // RVA: 0x7FFE81166670
        public void get_defaultTargetPosRelToMuscle(){} // RVA: 0x7FFE811666D0
        public void set_defaultTargetPosRelToMuscle(){} // RVA: 0x7FFE811666F0
        public void get_defaultTargetRotRelToMuscle(){} // RVA: 0x7FFE81166710
        public void set_defaultTargetRotRelToMuscle(){} // RVA: 0x7FFE81166720
        public void get_defaultMuscleRotRelToTarget(){} // RVA: 0x7FFE81166730
        public void set_defaultMuscleRotRelToTarget(){} // RVA: 0x7FFE81166740
        public void Rebuild(){} // RVA: 0x7FFE81166750
        public void Initiate(){} // RVA: 0x7FFE81166BC0
        public void InitiateAdditionalPin(){} // RVA: 0x7FFE81169810
        public void UpdateColliders(){} // RVA: 0x7FFE81169B50
        public void DisableColliders(){} // RVA: 0x7FFE81169E80
        public void EnableColliders(){} // RVA: 0x7FFE8116A030
        public void AddColliders(){} // RVA: 0x7FFE8116A0E0
        public void AddCompoundColliders(){} // RVA: 0x7FFE8116A3C0
        public void IgnoreInternalCollisions(){} // RVA: 0x7FFE8116A5B0
        public void ResetInternalCollisions(){} // RVA: 0x7FFE8116A880
        public void ForceIgnore(){} // RVA: 0x7FFE8116AB90
        public void IgnoreAngularLimits(){} // RVA: 0x7FFE8116AF60
        public void FixTargetTransforms(){} // RVA: 0x7FFE8116B0D0
        public void Reset(){} // RVA: 0x7FFE8116B1C0
        public void MoveToTarget(){} // RVA: 0x7FFE8116B7D0
        public void SetKinematic(){} // RVA: 0x7FFE8116BEA0
        public void Read(){} // RVA: 0x7FFE8116C090
        public void ClearVelocities(){} // RVA: 0x7FFE8116C8F0
        public void UpdateAnchor(){} // RVA: 0x7FFE8116CDF0
        public void Update(){} // RVA: 0x7FFE8116D440
        public void StoreTargetMappedPosition(){} // RVA: 0x7FFE8116D710
        public void StoreTargetMappedRotation(){} // RVA: 0x7FFE8116D7A0
        public void Map(){} // RVA: 0x7FFE8116D820
        public void ResetTargetLocalPosition(){} // RVA: 0x7FFE8116E440
        public void CalculateMappedVelocity(){} // RVA: 0x7FFE8116E4C0
        public void MapDisconnected(){} // RVA: 0x7FFE8116E8D0
        public void Pin(){} // RVA: 0x7FFE8116F4E0 | overloaded x2
        public void MuscleRotation(){} // RVA: 0x7FFE8116F6F0
        public void SetMuscleRotation(){} // RVA: 0x7FFE8116F9D0
        public void get_localRotation(){} // RVA: 0x7FFE8116FC70
        public void get_parentRotation(){} // RVA: 0x7FFE8116FEE0
        public void get_targetParentRotation(){} // RVA: 0x7FFE811702A0
        public void get_targetLocalRotation(){} // RVA: 0x7FFE81170420
        public void LocalToJointSpace(){} // RVA: 0x7FFE81170770
        public void InverseTransformPointUnscaled(){} // RVA: 0x7FFE81170A30
        public void .ctor(){} // RVA: 0x7FFE81170CB0
    }

    public class MuscleCollision : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81171EF0
    }

    public class MuscleCollisionBroadcaster : MonoBehaviour
    {
        // ── Methods ──
        public void Hit(){} // RVA: 0x7FFE81171F80
        public void OnCollisionEnter(){} // RVA: 0x7FFE81172210
        public void OnCollisionStay(){} // RVA: 0x7FFE81172840
        public void OnCollisionExit(){} // RVA: 0x7FFE81172CD0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class MuscleHit : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81171F50
    }

    public class PhysXTools : Object
    {
        // ── Methods ──
        public void Predict(){} // RVA: 0x7FFE81173720 | overloaded x3
        public void GetCenterOfMass(){} // RVA: 0x7FFE81173F50 | overloaded x2
        public void GetCenterOfMassVelocity(){} // RVA: 0x7FFE811741F0
        public void DivByInertia(){} // RVA: 0x7FFE81174490
        public void ScaleByInertia(){} // RVA: 0x7FFE81174850
        public void GetFromToAcceleration(){} // RVA: 0x7FFE81174C10
        public void GetAngularAcceleration(){} // RVA: 0x7FFE81174E20
        public void AddFromToTorque(){} // RVA: 0x7FFE81175BA0 | overloaded x2
        public void AddFromToForce(){} // RVA: 0x7FFE81176030
        public void GetLinearAcceleration(){} // RVA: 0x7FFE81176350
        public void ToJointSpace(){} // RVA: 0x7FFE81176410
        public void CalculateInertiaTensorCuboid(){} // RVA: 0x7FFE81176670
        public void Div(){} // RVA: 0x7FFE811766C0
    }

    public class PressureSensor : MonoBehaviour
    {
        public bool visualize; // 0x20
        public UnityEngine.LayerMask layers; // 0x24
        public UnityEngine.Vector3 _center; // 0x28
        public bool _inContact; // 0x34

        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFE81176700
        public void set_center(){} // RVA: 0x7FFE81176720
        public void get_inContact(){} // RVA: 0x7FFE81131C20
        public void set_inContact(){} // RVA: 0x7FFE81135AC0
        public void get_bottom(){} // RVA: 0x7FFE81161F40
        public void set_bottom(){} // RVA: 0x7FFE81161F60
        public void get_r(){} // RVA: 0x7FFE81176730
        public void set_r(){} // RVA: 0x7FFE81176740
        public void Awake(){} // RVA: 0x7FFE811767A0
        public void OnCollisionEnter(){} // RVA: 0x7FFE811768F0
        public void OnCollisionStay(){} // RVA: 0x7FFE811768F0
        public void OnCollisionExit(){} // RVA: 0x7FFE81176900
        public void FixedUpdate(){} // RVA: 0x7FFE81176910
        public void LateUpdate(){} // RVA: 0x7FFE811769D0
        public void ProcessCollision(){} // RVA: 0x7FFE81176A20
        public void OnDrawGizmos(){} // RVA: 0x7FFE81176C10
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Prop : MonoBehaviour
    {
        public int propType; // 0x20
        public UnityEngine.ConfigurableJoint muscle; // 0x28
        public Props muscleProps; // 0x30

        // ── Methods ──
        public void get_isPickedUp(){} // RVA: 0x7FFE81176C80
        public void get_propRoot(){} // RVA: 0x7FFE81176D50
        public void set_propRoot(){} // RVA: 0x7FFE81176D60
        public void PickUp(){} // RVA: 0x7FFE81176DC0
        public void Drop(){} // RVA: 0x7FFE81177290
        public void StartPickedUp(){} // RVA: 0x7FFE81176D60
        public void get_initiated(){} // RVA: 0x7FFE81177320
        public void set_initiated(){} // RVA: 0x7FFE81177330
        public void OnPickUp(){} // RVA: 0x7FFE810FB310
        public void OnDrop(){} // RVA: 0x7FFE810FB310
        public void OnStart(){} // RVA: 0x7FFE810FB310
        public void Start(){} // RVA: 0x7FFE81177340
        public void ReleaseJoint(){} // RVA: 0x7FFE811779A0
        public void SetMaterial(){} // RVA: 0x7FFE81177D40
        public void OnDrawGizmos(){} // RVA: 0x7FFE81177EB0
        public void .ctor(){} // RVA: 0x7FFE811784F0
    }

    public class PropMuscle : MonoBehaviour
    {
        public RootMotion.Dynamics.PuppetMaster puppetMaster; // 0x20
        public RootMotion.Dynamics.PuppetMasterProp currentProp; // 0x28

        // ── Methods ──
        public void get_muscle(){} // RVA: 0x7FFE81178650
        public void get_activeProp(){} // RVA: 0x7FFE81178740
        public void set_activeProp(){} // RVA: 0x7FFE81123200
        public void AddAdditionalPin(){} // RVA: 0x7FFE81178750
        public void RemoveAdditionalPin(){} // RVA: 0x7FFE81179310
        public void OnInitiate(){} // RVA: 0x7FFE811796A0
        public void TakeOver(){} // RVA: 0x7FFE81179860
        public void OnUpdate(){} // RVA: 0x7FFE811799B0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE8117A8A0
        public void .ctor(){} // RVA: 0x7FFE8117B100
    }

    public class PropRoot : MonoBehaviour
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void DropImmediate(){} // RVA: 0x7FFE8117B310
        public void Awake(){} // RVA: 0x7FFE8117B4E0
        public void Update(){} // RVA: 0x7FFE8117B6A0
        public void FixedUpdate(){} // RVA: 0x7FFE8117B950
        public void AttachProp(){} // RVA: 0x7FFE8117BE50
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class PropTemplate : Prop
    {
        // ── Methods ──
        public void OnStart(){} // RVA: 0x7FFE810FB310
        public void OnPickUp(){} // RVA: 0x7FFE810FB310
        public void OnDrop(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE811784F0
    }

    public class PuppetMaster : MonoBehaviour
    {
        public RootMotion.Dynamics.PuppetMasterHumanoidConfig humanoidConfig; // 0x20
        public UnityEngine.Transform targetRoot; // 0x28
        public dFixup.ÎÍÎÍÏÍÎ state; // 0x30
        public StateSettings stateSettings; // 0x34
        public 0x665B79EC mode; // 0x48
        public float blendTime; // 0x4C
        public bool fixTargetTransforms; // 0x50
        public int solverIterationCount; // 0x54
        public bool visualizeTargetPose; // 0x58
        public float mappingWeight; // 0x5C
        public float pinWeight; // 0x60
        public float muscleWeight; // 0x64
        public float muscleSpring; // 0x68
        public float muscleDamper; // 0x6C
        public float pinPow; // 0x70

        // ── Methods ──
        public void OpenUserManualSetup(){} // RVA: 0x7FFE810FB310
        public void OpenUserManualComponent(){} // RVA: 0x7FFE810FB310
        public void OpenUserManualPerformance(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void OpenSetupTutorial(){} // RVA: 0x7FFE810FB310
        public void OpenComponentTutorial(){} // RVA: 0x7FFE810FB310
        public void ResetStateSettings(){} // RVA: 0x7FFE8117C4C0
        public void get_targetAnimator(){} // RVA: 0x7FFE8117C4F0
        public void set_targetAnimator(){} // RVA: 0x7FFE8117C8A0
        public void get_targetAnimation(){} // RVA: 0x7FFE8117C900
        public void set_targetAnimation(){} // RVA: 0x7FFE8117C910
        public void get_behaviours(){} // RVA: 0x7FFE8117C970
        public void set_behaviours(){} // RVA: 0x7FFE8117C980
        public void get_isActive(){} // RVA: 0x7FFE8117C9E0
        public void get_initiated(){} // RVA: 0x7FFE8117CAD0
        public void set_initiated(){} // RVA: 0x7FFE8117CAE0
        public void get_updateMode(){} // RVA: 0x7FFE8117CAF0
        public void get_controlsAnimator(){} // RVA: 0x7FFE8117CB30
        public void get_isBlending(){} // RVA: 0x7FFE8117CBE0
        public void Teleport(){} // RVA: 0x7FFE8117CC00
        public void SetInternalCollisionsManual(){} // RVA: 0x7FFE8117CC40
        public void SetAngularLimitsManual(){} // RVA: 0x7FFE8117CD60
        public void get_autoSimulate(){} // RVA: 0x7FFE8117CE00
        public void OnDisable(){} // RVA: 0x7FFE8117CE90
        public void OnEnable(){} // RVA: 0x7FFE8117D020
        public void Awake(){} // RVA: 0x7FFE8117D9E0
        public void Start(){} // RVA: 0x7FFE8117DA20
        public void FindTargetRootRecursive(){} // RVA: 0x7FFE8117DB00
        public void Initiate(){} // RVA: 0x7FFE8117DFB0
        public void ActivateBehaviour(){} // RVA: 0x7FFE8117EF70
        public void OnDestroy(){} // RVA: 0x7FFE8117F190
        public void IsInterpolated(){} // RVA: 0x7FFE8117F2C0
        public void OnRebuild(){} // RVA: 0x7FFE8117F3A0
        public void OnPreSimulate(){} // RVA: 0x7FFE8117F6E0
        public void OnPostSimulate(){} // RVA: 0x7FFE8117FEB0
        public void FixedUpdate(){} // RVA: 0x7FFE81180330
        public void Update(){} // RVA: 0x7FFE81180C60
        public void LateUpdate(){} // RVA: 0x7FFE81180DF0
        public void OnLateUpdate(){} // RVA: 0x7FFE811810C0
        public void MoveToTarget(){} // RVA: 0x7FFE81181460
        public void Read(){} // RVA: 0x7FFE81181650
        public void FixTargetTransforms(){} // RVA: 0x7FFE81182EE0
        public void get_targetUpdateMode(){} // RVA: 0x7FFE81183120
        public void VisualizeTargetPose(){} // RVA: 0x7FFE81183360
        public void VisualizeHierarchy(){} // RVA: 0x7FFE811833D0
        public void FlagInternalCollisionsForUpdate(){} // RVA: 0x7FFE81183710
        public void UpdateInternalCollisions(){} // RVA: 0x7FFE811838A0 | overloaded x2
        public void IgnoreInternalCollisions(){} // RVA: 0x7FFE81183A00 | overloaded x2
        public void ResetInternalCollisions(){} // RVA: 0x7FFE81183B40 | overloaded x2
        public void FlagAngularLimitsForUpdate(){} // RVA: 0x7FFE81183BD0
        public void UpdateAngularLimits(){} // RVA: 0x7FFE81183BF0
        public void AddPropMuscle(){} // RVA: 0x7FFE81183CA0
        public void IsDisconnecting(){} // RVA: 0x7FFE81184810
        public void IsReconnecting(){} // RVA: 0x7FFE81184850
        public void DisconnectMuscleRecursive(){} // RVA: 0x7FFE81184890
        public void ReconnectMuscleRecursive(){} // RVA: 0x7FFE81184A10
        public void AddMuscle(){} // RVA: 0x7FFE81184D40
        public void Rebuild(){} // RVA: 0x7FFE811861B0
        public void RemoveMuscleRecursive(){} // RVA: 0x7FFE811861C0
        public void ReplaceMuscle(){} // RVA: 0x7FFE81187B70
        public void SetMuscles(){} // RVA: 0x7FFE81187C30
        public void DisableMuscleRecursive(){} // RVA: 0x7FFE81187CF0
        public void EnableMuscleRecursive(){} // RVA: 0x7FFE81187DB0
        public void FlattenHierarchy(){} // RVA: 0x7FFE81187E70
        public void TreeHierarchy(){} // RVA: 0x7FFE81187FE0
        public void FixMusclePositions(){} // RVA: 0x7FFE81188220
        public void FixMusclePositionsAndRotations(){} // RVA: 0x7FFE811884D0
        public void HierarchyIsFlat(){} // RVA: 0x7FFE81188870
        public void GetHighestDisconnectedParentIndex(){} // RVA: 0x7FFE81188AE0
        public void ProcessDisconnects(){} // RVA: 0x7FFE81188B70
        public void ProcessReconnects(){} // RVA: 0x7FFE81188CB0
        public void OnDisconnectMuscleRecursive(){} // RVA: 0x7FFE81188D80
        public void DisconnectMuscle(){} // RVA: 0x7FFE811892A0
        public void OnReconnectMuscleRecursive(){} // RVA: 0x7FFE8118A350
        public void ReconnectMuscle(){} // RVA: 0x7FFE8118A510
        public void AddIndexesRecursive(){} // RVA: 0x7FFE8118AF40
        public void DisconnectJoint(){} // RVA: 0x7FFE8118B0E0
        public void KillJoint(){} // RVA: 0x7FFE8118B3C0
        public void SwitchToActiveMode(){} // RVA: 0x7FFE8118B4E0
        public void SwitchToKinematicMode(){} // RVA: 0x7FFE8118B4F0
        public void SwitchToDisabledMode(){} // RVA: 0x7FFE8118B500
        public void get_isSwitchingMode(){} // RVA: 0x7FFE8118B510
        public void set_isSwitchingMode(){} // RVA: 0x7FFE8118B520
        public void DisableImmediately(){} // RVA: 0x7FFE8118B530
        public void SwitchModes(){} // RVA: 0x7FFE8118B660
        public void DisabledToKinematic(){} // RVA: 0x7FFE8118BBD0
        public void DisabledToActive(){} // RVA: 0x7FFE8118BD40
        public void KinematicToDisabled(){} // RVA: 0x7FFE8118BDE0
        public void KinematicToActive(){} // RVA: 0x7FFE8118BE80
        public void ActiveToDisabled(){} // RVA: 0x7FFE8118BF20
        public void ActiveToKinematic(){} // RVA: 0x7FFE8118BFC0
        public void SetMuscleWeights(){} // RVA: 0x7FFE8118C650 | overloaded x4
        public void SetMuscleWeightsRecursive(){} // RVA: 0x7FFE8118C5C0 | overloaded x3
        public void GetMuscle(){} // RVA: 0x7FFE8118C930 | overloaded x3
        public void ContainsJoint(){} // RVA: 0x7FFE8118C980
        public void GetMuscleIndex(){} // RVA: 0x7FFE8118D530 | overloaded x4
        public void SetUp(){} // RVA: 0x7FFE8118DA70 | overloaded x2
        public void SetUpTo(){} // RVA: 0x7FFE8118DD10
        public void RemoveRagdollComponents(){} // RVA: 0x7FFE8118F580
        public void SetUpMuscles(){} // RVA: 0x7FFE8118FDD0
        public void FindGroup(){} // RVA: 0x7FFE81190A60
        public void RemoveUnnecessaryBones(){} // RVA: 0x7FFE811917F0
        public void IsClothCollider(){} // RVA: 0x7FFE81191E00
        public void get_isSwitchingState(){} // RVA: 0x7FFE811924A0
        public void get_isKilling(){} // RVA: 0x7FFE811924B0
        public void set_isKilling(){} // RVA: 0x7FFE811924C0
        public void get_isAlive(){} // RVA: 0x7FFE811924D0
        public void get_isFrozen(){} // RVA: 0x7FFE811924E0
        public void Kill(){} // RVA: 0x7FFE81192500 | overloaded x2
        public void Freeze(){} // RVA: 0x7FFE81192530 | overloaded x2
        public void Resurrect(){} // RVA: 0x7FFE81192550
        public void SwitchStates(){} // RVA: 0x7FFE81192560
        public void AliveToDead(){} // RVA: 0x7FFE81192860
        public void OnFreezeFlag(){} // RVA: 0x7FFE81192910
        public void DeadToAlive(){} // RVA: 0x7FFE81192FD0
        public void SetAnimationEnabled(){} // RVA: 0x7FFE81193100
        public void DeadToFrozen(){} // RVA: 0x7FFE81193330
        public void FrozenToAlive(){} // RVA: 0x7FFE81193340
        public void FrozenToDead(){} // RVA: 0x7FFE811936F0
        public void ActivateRagdoll(){} // RVA: 0x7FFE811937E0
        public void CanFreeze(){} // RVA: 0x7FFE81193B30
        public void SampleTargetMappedState(){} // RVA: 0x7FFE81193C40
        public void FixTargetToSampledState(){} // RVA: 0x7FFE81193D40
        public void StoreTargetMappedState(){} // RVA: 0x7FFE81194270
        public void UpdateHierarchies(){} // RVA: 0x7FFE81194350
        public void HasProp(){} // RVA: 0x7FFE81194970
        public void UpdateBroadcasterMuscleIndexes(){} // RVA: 0x7FFE811949D0
        public void AssignParentAndChildIndexes(){} // RVA: 0x7FFE81194C40
        public void AddToParentsRecursive(){} // RVA: 0x7FFE811951B0
        public void AddToChildrenRecursive(){} // RVA: 0x7FFE81195420
        public void AssignKinshipDegrees(){} // RVA: 0x7FFE81195760
        public void AssignKinshipsDownRecursive(){} // RVA: 0x7FFE81195900
        public void AssignKinshipsUpRecursive(){} // RVA: 0x7FFE81195B20
        public void GetMuscleIndexLowLevel(){} // RVA: 0x7FFE81195F00
        public void IsValid(){} // RVA: 0x7FFE811960A0
        public void CheckMassVariation(){} // RVA: 0x7FFE81196EE0
        public void CheckIfInitiated(){} // RVA: 0x7FFE811972B0
        public void .ctor(){} // RVA: 0x7FFE81197330
    }

    public class PuppetMasterHumanoidConfig : ScriptableObject
    {
        // ── Methods ──
        public void ApplyTo(){} // RVA: 0x7FFE81198A00
        public void GetMuscle(){} // RVA: 0x7FFE81198F30
        public void .ctor(){} // RVA: 0x7FFE81199140
    }

    public class PuppetMasterProp : MonoBehaviour
    {
        public UnityEngine.Transform meshRoot; // 0x20
        public Props muscleProps; // 0x28

        // ── Methods ──
        public void get_isPickedUp(){} // RVA: 0x7FFE81199240
        public void set_isPickedUp(){} // RVA: 0x7FFE81199250
        public void GetRigidbody(){} // RVA: 0x7FFE81199260
        public void OnPickUp(){} // RVA: 0x7FFE810FB310
        public void OnDrop(){} // RVA: 0x7FFE810FB310
        public void get_propMuscle(){} // RVA: 0x7FFE81199370
        public void set_propMuscle(){} // RVA: 0x7FFE81199380
        public void PickUp(){} // RVA: 0x7FFE811993E0
        public void Drop(){} // RVA: 0x7FFE81199D20
        public void Awake(){} // RVA: 0x7FFE8119A810
        public void Start(){} // RVA: 0x7FFE8119AC00
        public void Update(){} // RVA: 0x7FFE8119B0D0
        public void RemoveRigidbody(){} // RVA: 0x7FFE8119B2B0
        public void ReattachRigidbody(){} // RVA: 0x7FFE8119B690
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE8119BA60
        public void .ctor(){} // RVA: 0x7FFE8119BEC0
    }

    public class PuppetMasterSettings : Singleton`1
    {
        public PuppetUpdateLimit kinematicCollidersUpdateLimit; // 0x20
        public PuppetUpdateLimit freeUpdateLimit; // 0x28
        public PuppetUpdateLimit fixedUpdateLimit; // 0x30
        public bool collisionStayMessages; // 0x38

        // ── Methods ──
        public void get_currentlyActivePuppets(){} // RVA: 0x7FFE8119C080
        public void set_currentlyActivePuppets(){} // RVA: 0x7FFE8119C090
        public void get_currentlyKinematicPuppets(){} // RVA: 0x7FFE8119C0A0
        public void set_currentlyKinematicPuppets(){} // RVA: 0x7FFE8119C0B0
        public void get_currentlyDisabledPuppets(){} // RVA: 0x7FFE8119C0C0
        public void set_currentlyDisabledPuppets(){} // RVA: 0x7FFE8119C0D0
        public void get_puppets(){} // RVA: 0x7FFE8119C0E0
        public void Register(){} // RVA: 0x7FFE8119C0F0
        public void Unregister(){} // RVA: 0x7FFE8119C200
        public void UpdateMoveToTarget(){} // RVA: 0x7FFE8119C260
        public void UpdateFree(){} // RVA: 0x7FFE8119C290
        public void UpdateFixed(){} // RVA: 0x7FFE8119C2C0
        public void Update(){} // RVA: 0x7FFE8119C2F0
        public void FixedUpdate(){} // RVA: 0x7FFE8119C530
        public void .ctor(){} // RVA: 0x7FFE8119C590
    }

    public class PuppetMasterTools : Object
    {
        // ── Methods ──
        public void PositionRagdoll(){} // RVA: 0x7FFE8119C9C0
        public void RealignRagdoll(){} // RVA: 0x7FFE8119D8B0
        public void DirectionIntToVector3(){} // RVA: 0x7FFE81142B70
        public void DirectionVector3ToInt(){} // RVA: 0x7FFE8119EFA0
    }

    public class RagdollCreator : MonoBehaviour
    {
        // ── Methods ──
        public void ClearAll(){} // RVA: 0x7FFE811AC240
        public void ClearTransform(){} // RVA: 0x7FFE811AC5F0
        public void CreateCollider(){} // RVA: 0x7FFE811AD280 | overloaded x2
        public void GetScaleF(){} // RVA: 0x7FFE811AD940
        public void Abs(){} // RVA: 0x7FFE811AD9D0
        public void Vector3Abs(){} // RVA: 0x7FFE811ADA20
        public void DirectionIntToVector3(){} // RVA: 0x7FFE81142B70
        public void DirectionToVector3(){} // RVA: 0x7FFE81142B70
        public void DirectionVector3ToInt(){} // RVA: 0x7FFE8119EFA0
        public void GetLocalOrthoDirection(){} // RVA: 0x7FFE811ADA50
        public void GetConnectedBody(){} // RVA: 0x7FFE811ADF30
        public void CreateJoint(){} // RVA: 0x7FFE811AE2F0
        public void ToSoftJointLimit(){} // RVA: 0x7FFE811AF5D0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class RagdollEditor : MonoBehaviour
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void OpenTutorial(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE811AF710
    }

    public class SubBehaviourBalancer : SubBehaviourBase
    {
        public UnityEngine.ConfigurableJoint _joint; // 0x18
        public UnityEngine.Vector3 _dir; // 0x20
        public UnityEngine.Vector3 _dirVel; // 0x2C
        public UnityEngine.Vector3 _cop; // 0x38
        public UnityEngine.Vector3 _com; // 0x44
        public UnityEngine.Vector3 _comV; // 0x50

        // ── Methods ──
        public void get_joint(){} // RVA: 0x7FFE810FE7C0
        public void set_joint(){} // RVA: 0x7FFE81161E80
        public void get_dir(){} // RVA: 0x7FFE81161EE0
        public void set_dir(){} // RVA: 0x7FFE81161F00
        public void get_dirVel(){} // RVA: 0x7FFE81161F10
        public void set_dirVel(){} // RVA: 0x7FFE81161F30
        public void get_cop(){} // RVA: 0x7FFE81161F40
        public void set_cop(){} // RVA: 0x7FFE81161F60
        public void get_com(){} // RVA: 0x7FFE81161F70
        public void set_com(){} // RVA: 0x7FFE81161F90
        public void get_comV(){} // RVA: 0x7FFE81161FA0
        public void set_comV(){} // RVA: 0x7FFE81161FC0
        public void Initiate(){} // RVA: 0x7FFE81161FD0
        public void Solve(){} // RVA: 0x7FFE811623A0
        public void .ctor(){} // RVA: 0x7FFE81163250
    }

    public class SubBehaviourBase : Object
    {
        // ── Methods ──
        public void XZ(){} // RVA: 0x7FFE811633D0
        public void XYZ(){} // RVA: 0x7FFE811633F0
        public void Flatten(){} // RVA: 0x7FFE81163420
        public void SetY(){} // RVA: 0x7FFE81163440
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SubBehaviourCOM : SubBehaviourBase
    {
        public 0x665B730C mode; // 0x18
        public float velocityDamper; // 0x1C
        public float velocityLerpSpeed; // 0x20
        public float velocityMax; // 0x24
        public float centerOfPressureSpeed; // 0x28
        public UnityEngine.Vector3 offset; // 0x2C
        public UnityEngine.Vector3 _position; // 0x38
        public UnityEngine.Vector3 _direction; // 0x44
        public float _angle; // 0x50

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFE81161F40
        public void set_position(){} // RVA: 0x7FFE81161F60
        public void get_direction(){} // RVA: 0x7FFE81161F70
        public void set_direction(){} // RVA: 0x7FFE81161F90
        public void get_angle(){} // RVA: 0x7FFE81163460
        public void set_angle(){} // RVA: 0x7FFE81163470
        public void get_velocity(){} // RVA: 0x7FFE81163480
        public void set_velocity(){} // RVA: 0x7FFE811634A0
        public void get_centerOfPressure(){} // RVA: 0x7FFE811634B0
        public void set_centerOfPressure(){} // RVA: 0x7FFE811634D0
        public void get_rotation(){} // RVA: 0x7FFE811634E0
        public void set_rotation(){} // RVA: 0x7FFE811634F0
        public void get_inverseRotation(){} // RVA: 0x7FFE81163500
        public void set_inverseRotation(){} // RVA: 0x7FFE81163510
        public void get_isGrounded(){} // RVA: 0x7FFE81163520
        public void set_isGrounded(){} // RVA: 0x7FFE81163530
        public void get_lastGroundedTime(){} // RVA: 0x7FFE81163540
        public void set_lastGroundedTime(){} // RVA: 0x7FFE81163550
        public void Initiate(){} // RVA: 0x7FFE81163560
        public void OnHierarchyChanged(){} // RVA: 0x7FFE81163D20
        public void OnPreMuscleCollision(){} // RVA: 0x7FFE81163DD0
        public void OnPreMuscleCollisionExit(){} // RVA: 0x7FFE81164090
        public void OnPreActivate(){} // RVA: 0x7FFE811641E0
        public void OnPreLateUpdate(){} // RVA: 0x7FFE81164320
        public void OnPreDeactivate(){} // RVA: 0x7FFE81164BE0
        public void GetCollisionCOP(){} // RVA: 0x7FFE81164C30
        public void IsGrounded(){} // RVA: 0x7FFE81164D90
        public void GetCenterOfMass(){} // RVA: 0x7FFE81164DF0
        public void GetCenterOfMassVelocity(){} // RVA: 0x7FFE81165080
        public void GetMomentum(){} // RVA: 0x7FFE81165420
        public void GetCenterOfPressure(){} // RVA: 0x7FFE811656A0
        public void GetFeetCentroid(){} // RVA: 0x7FFE81165800
        public void .ctor(){} // RVA: 0x7FFE81165A50
    }

    public class Weight : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8119F1C0 | overloaded x2
        public void GetValue(){} // RVA: 0x7FFE8119F2C0
    }

}