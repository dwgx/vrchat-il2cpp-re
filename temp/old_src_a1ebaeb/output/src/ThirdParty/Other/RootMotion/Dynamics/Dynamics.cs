// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.Dynamics
// Classes: 29
// Methods: 570

namespace ThirdParty.Other.RootMotion.Dynamics
{
    public class AnimationBlocker : MonoBehaviour
    {
        // ── Original Methods ──
        public void LateUpdate(){} // RVA: 0x7ffaa898ed90
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class BehaviourBase : MonoBehaviour
    {
        public object OnPreInitiate; // 0x333499E0
        public object OnPreLateUpdate; // 0x333499E0
        public object OnPreRead; // 0x333499E0
        public object OnPreMuscleCollision; // 0x333499E0
        public object OnPostActivate; // 0x333499E0
        public object OnPostUpdate; // 0x333499E0
        public object OnPostDrawGizmos; // 0x333499E0
        public object OnPostWrite; // 0x333499E0
        public object OnPostMuscleCollisionExit; // 0x333499E0
        public object initiated; // 0x333499E0
        public object forceActive; // 0x17000058
        public object ћf; // 0x6739BD65
        public object `Ǐf; // 0x6739BD8E
        public object 8؏f; // 0x6739AE50

        // ── Original Methods ──
        public void OnReactivate(){} // RVA: 0x7ffaa8660cc0
        public void Resurrect(){} // RVA: 0x7ffaa8932310
        public void Freeze(){} // RVA: 0x7ffaa8932310
        public void Unfreeze(){} // RVA: 0x7ffaa8932310
        public void KillStart(){} // RVA: 0x7ffaa8932310
        public void KillEnd(){} // RVA: 0x7ffaa8932310
        public void OnTeleport(){} // RVA: 0x7ffaa8932310
        public void OnMuscleDisconnected(){} // RVA: 0x7ffaa8932310
        public void OnMuscleReconnected(){} // RVA: 0x7ffaa8932310
        public void OnMuscleAdded(){} // RVA: 0x7ffaa898ef60
        public void OnMuscleRemoved(){} // RVA: 0x7ffaa898ef60
        public void OnActivate(){} // RVA: 0x7ffaa8932310
        public void OnDeactivate(){} // RVA: 0x7ffaa8932310
        public void OnInitiate(){} // RVA: 0x7ffaa8932310
        public void OnFixedUpdate(){} // RVA: 0x7ffaa8932310
        public void OnUpdate(){} // RVA: 0x7ffaa8932310
        public void OnLateUpdate(){} // RVA: 0x7ffaa8932310
        public void OnDrawGizmosBehaviour(){} // RVA: 0x7ffaa8932310
        public void OnFixTransformsBehaviour(){} // RVA: 0x7ffaa8932310
        public void OnReadBehaviour(){} // RVA: 0x7ffaa8932310
        public void OnWriteBehaviour(){} // RVA: 0x7ffaa8932310
        public void OnMuscleHitBehaviour(){} // RVA: 0x7ffaa8932310
        public void OnMuscleCollisionBehaviour(){} // RVA: 0x7ffaa8932310
        public void OnMuscleCollisionExitBehaviour(){} // RVA: 0x7ffaa8932310
        public void get_forceActive(){} // RVA: 0x7ffaa898ef90
        public void set_forceActive(){} // RVA: 0x7ffaa898efa0
        public void Initiate(){} // RVA: 0x7ffaa898efb0
        public void OnFixTransforms(){} // RVA: 0x7ffaa898f020
        public void OnRead(){} // RVA: 0x7ffaa898f0e0
        public void OnWrite(){} // RVA: 0x7ffaa898f1a0
        public void OnMuscleHit(){} // RVA: 0x7ffaa898f260
        public void OnMuscleCollision(){} // RVA: 0x7ffaa898f320
        public void OnMuscleCollisionExit(){} // RVA: 0x7ffaa898f3e0
        public void OnEnable(){} // RVA: 0x7ffaa898f4b0
        public void Activate(){} // RVA: 0x7ffaa898f4d0
        public void OnDisable(){} // RVA: 0x7ffaa898f6d0
        public void FixedUpdateB(){} // RVA: 0x7ffaa898f740
        public void UpdateB(){} // RVA: 0x7ffaa898f850
        public void LateUpdateB(){} // RVA: 0x7ffaa898f960
        public void OnDrawGizmos(){} // RVA: 0x7ffaa898fa70
        public void RotateTargetToRootMuscle(){} // RVA: 0x7ffaa898fac0
        public void TranslateTargetToRootMuscle(){} // RVA: 0x7ffaa8990030
        public void RemovePropMuscles(){} // RVA: 0x7ffaa8990390
        public void GroundTarget(){} // RVA: 0x7ffaa89904d0
        public void ContainsRemovablePropMuscle(){} // RVA: 0x7ffaa8990910
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class BehaviourFall : BehaviourBase
    {
        public object layer; // 0x335E38F0
        public object blendParameter; // 0x335E38F0
        public object blendSpeed; // 0x335E38F0
        public object minTime; // 0x335E38F0
        public object timer; // 0x335E38F0
        public object ; // 0x84423AC0
        public object AnimatorEvent[];

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void OnActivate(){} // RVA: 0x7ffaa89917c0
        public void OnDeactivate(){} // RVA: 0x7ffaa89918b0
        public void OnReactivate(){} // RVA: 0x7ffaa89918c0
        public void SmoothActivate(){} // RVA: 0x7ffaa89918e0
        public void OnFixedUpdate(){} // RVA: 0x7ffaa8991980
        public void OnLateUpdate(){} // RVA: 0x7ffaa8991d30
        public void Resurrect(){} // RVA: 0x7ffaa8991fb0
        public void OnMuscleReconnected(){} // RVA: 0x7ffaa8992470
        public void .ctor(){} // RVA: 0x7ffaa89924b0
        // ── Binary Analysis Named ──
        public void GetBlendTarget(){} // RVA: 0x7ffaa8992010
        public void GetGroundHeight(){} // RVA: 0x7ffaa89921f0
    }

    public class BehaviourPuppet : BehaviourBase
    {
        public object collisionLayers; // 0x334D0030
        public object collisionResistanceMultipliers; // 0x334D0030
        public object boostFalloff; // 0x334D0030
        public object knockOutDistance; // 0x334D0030
        public object pinWeightThreshold; // 0x334D0030
        public object canGetUp; // 0x334D0030
        public object maxGetUpVelocity; // 0x334D0030
        public object getUpRegainPinSpeedMlp; // 0x334D0030
        public object getUpOffsetSupine; // 0x334D0030
        public object onLoseBalance; // 0x334D0030
        public object onRegainBalance; // 0x334D0030
        public object _state; // 0x334D0030, was: <state>k__BackingField
        public object getUpTimer; // 0x334D0030
        public object getupAnimationBlendWeight; // 0x334D0030
        public object lastNormalMode; // 0x334D0030
        public object lastKnockOutDistance; // 0x334D0030
        public object hasCollidedSinceGetUp; // 0x334D0030
        public object getUpPosition; // 0x334D0030
        public object .ctor; // 0xB3F6FFF0
        public object 8؏f; // 0x333CB220
        public object Curve; // 0x84430030

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void get_state(){} // RVA: 0x7ffaa89929c0
        public void set_state(){} // RVA: 0x7ffaa89929d0
        public void OnReactivate(){} // RVA: 0x7ffaa89929e0
        public void Reset(){} // RVA: 0x7ffaa8992b00
        public void OnTeleport(){} // RVA: 0x7ffaa8992b60
        public void OnInitiate(){} // RVA: 0x7ffaa8992da0
        public void OnActivate(){} // RVA: 0x7ffaa89937d0
        public void KillStart(){} // RVA: 0x7ffaa8993880
        public void KillEnd(){} // RVA: 0x7ffaa8993930
        public void Resurrect(){} // RVA: 0x7ffaa8993940
        public void OnDeactivate(){} // RVA: 0x7ffaa89939d0
        public void OnFixedUpdate(){} // RVA: 0x7ffaa89939e0
        public void OnLateUpdate(){} // RVA: 0x7ffaa89943f0
        public void OnReadBehaviour(){} // RVA: 0x7ffaa8994720
        public void BlendMuscleMapping(){} // RVA: 0x7ffaa8994d80
        public void OnMuscleAdded(){} // RVA: 0x7ffaa8994f80
        public void OnMuscleRemoved(){} // RVA: 0x7ffaa8994fe0
        public void MoveTarget(){} // RVA: 0x7ffaa8995030
        public void RotateTarget(){} // RVA: 0x7ffaa89950c0
        public void GroundTarget(){} // RVA: 0x7ffaa8995150
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaa8995170
        public void Boost(){} // RVA: 0x7ffaa89955b0
        public void Boost(){} // RVA: 0x7ffaa89955b0
        public void Boost(){} // RVA: 0x7ffaa89955b0
        public void BoostImmunity(){} // RVA: 0x7ffaa89958b0
        public void BoostImmunity(){} // RVA: 0x7ffaa89958b0
        public void BoostImmunity(){} // RVA: 0x7ffaa89958b0
        public void BoostImpulseMlp(){} // RVA: 0x7ffaa8995b20
        public void BoostImpulseMlp(){} // RVA: 0x7ffaa8995b20
        public void BoostImpulseMlp(){} // RVA: 0x7ffaa8995b20
        public void Unpin(){} // RVA: 0x7ffaa8995c60
        public void OnMuscleHitBehaviour(){} // RVA: 0x7ffaa8995ce0
        public void OnMuscleCollisionBehaviour(){} // RVA: 0x7ffaa8995e80
        public void UnPin(){} // RVA: 0x7ffaa89967c0
        public void UnPinMuscle(){} // RVA: 0x7ffaa8996930
        public void Activate(){} // RVA: 0x7ffaa8996c10
        public void IsProne(){} // RVA: 0x7ffaa8996ca0
        public void InGroup(){} // RVA: 0x7ffaa89971f0
        public void OnMuscleDisconnected(){} // RVA: 0x7ffaa89987e0
        public void OnMuscleReconnected(){} // RVA: 0x7ffaa89987f0
        public void .ctor(){} // RVA: 0x7ffaa89988a0
        // ── Binary Analysis Named ──
        public void SetKinematic(){} // RVA: 0x7ffaa8994650
        public void GetImpulse(){} // RVA: 0x7ffaa8996550
        public void GetFalloff(){} // RVA: 0x7ffaa8997060
        public void GetFalloff(){} // RVA: 0x7ffaa8997060
        public void GetProps(){} // RVA: 0x7ffaa89972b0
        public void SetState(){} // RVA: 0x7ffaa89973b0
        public void SetColliders(){} // RVA: 0x7ffaa8998510
        public void SetColliders(){} // RVA: 0x7ffaa8998510
    }

    public class BehaviourTemplate : BehaviourBase
    {
        public object onLoseBalance; // 0x338571E0

        // ── Original Methods ──
        public void OnInitiate(){} // RVA: 0x7ffaa8998d60
        public void OnActivate(){} // RVA: 0x7ffaa8932310
        public void OnReactivate(){} // RVA: 0x7ffaa8932310
        public void OnDeactivate(){} // RVA: 0x7ffaa8932310
        public void OnFixedUpdate(){} // RVA: 0x7ffaa8998d90
        public void OnLateUpdate(){} // RVA: 0x7ffaa8932310
        public void OnMuscleHitBehaviour(){} // RVA: 0x7ffaa8998de0
        public void OnMuscleCollisionBehaviour(){} // RVA: 0x7ffaa8998de0
        public void .ctor(){} // RVA: 0x7ffaa8998e30
    }

    public class BipedRagdollCreator : RagdollCreator
    {
        public object options; // 0x33588DE0

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void OpenTutorial(){} // RVA: 0x7ffaa8932310
        public void AutodetectOptions(){} // RVA: 0x7ffaa89d62f0
        public void Create(){} // RVA: 0x7ffaa89d6810
        public void CreateColliders(){} // RVA: 0x7ffaa89d6a90
        public void CreateHandCollider(){} // RVA: 0x7ffaa89d8eb0
        public void CreateFootCollider(){} // RVA: 0x7ffaa89d95d0
        public void MassDistribution(){} // RVA: 0x7ffaa89da3a0
        public void CreateJoints(){} // RVA: 0x7ffaa89daea0
        public void CreateLimbJoints(){} // RVA: 0x7ffaa89dc100
        public void ClearBipedRagdoll(){} // RVA: 0x7ffaa89dd200
        public void IsClear(){} // RVA: 0x7ffaa89dd260
        public void .ctor(){} // RVA: 0x7ffaa89dd660
        // ── Binary Analysis Named ──
        public void GetChildCentroid(){} // RVA: 0x7ffaa89da100
        public void GetUpperArmToHeadCentroid(){} // RVA: 0x7ffaa89dd3c0
        public void GetUpperArmCentroid(){} // RVA: 0x7ffaa89dd520
    }

    public class BipedRagdollReferences : ValueType
    {
        public object spine; // 0x339BED20
        public object leftUpperLeg; // 0x339BED20
        public object rightUpperLeg; // 0x339BED20
        public object leftUpperArm; // 0x339BED20
        public object rightUpperArm; // 0x339BED20

        // ── Original Methods ──
        public void IsValid(){} // RVA: 0x7ffaa89dd760
        public void IsChildRecursive(){} // RVA: 0x7ffaa89de540
        public void IsEmpty(){} // RVA: 0x7ffaa89de7f0
        public void Contains(){} // RVA: 0x7ffaa89df090
        public void FromAvatar(){} // RVA: 0x7ffaa89e0170
        public void FromBipedReferences(){} // RVA: 0x7ffaa89e08c0
        // ── Binary Analysis Named ──
        public void GetRagdollTransforms(){} // RVA: 0x7ffaa89dfcf0
    }

    public class Booster : Object
    {
        public object groups; // 0x333D2F70
        public object boostParents; // 0x333D2F70
        public object puppetMaster; // 0x339FD0C0

        // ── Original Methods ──
        public void Boost(){} // RVA: 0x7ffaa899ca70
        public void .ctor(){} // RVA: 0x7ffaa899ce70
    }

    public class JointBreakBroadcaster : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnJointBreak(){} // RVA: 0x7ffaa899cf90
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class JointConverter : Object
    {
        // ── Original Methods ──
        public void ToConfigurable(){} // RVA: 0x7ffaa89e0ea0
        public void HingeToConfigurable(){} // RVA: 0x7ffaa89e1270
        public void FixedToConfigurable(){} // RVA: 0x7ffaa89e1aa0
        public void SpringToConfigurable(){} // RVA: 0x7ffaa89e1dd0
        public void CharacterToConfigurable(){} // RVA: 0x7ffaa89e2220
        public void ConvertJoint(){} // RVA: 0x7ffaa89e2bf0
        public void ConvertToHighSoftJointLimit(){} // RVA: 0x7ffaa89e3180
        public void ConvertToLowSoftJointLimit(){} // RVA: 0x7ffaa89e31b0
        public void ConvertToSoftJointLimitSpring(){} // RVA: 0x7ffaa89e31d0
        public void CopyLimit(){} // RVA: 0x7ffaa89e3200
        public void CopyLimitSpring(){} // RVA: 0x7ffaa89e3220
    }

    public class Muscle : Object
    {
        public object target; // 0x335E35D0
        public object parentIndexes; // 0x335E35D0
        public object kinshipDegrees; // 0x335E35D0
        public object positionOffset; // 0x335E35D0
        public object _connectedBodyTarget; // 0x335E35D0, was: <connectedBodyTarget>k__Backin
        public object _targetVelocity; // 0x335E35D0, was: <targetVelocity>k__BackingFiel
        public object additionalPinTarget; // 0x335E35D0
        public object mappedAngularVelocity; // 0x335E35D0
        public object _targetRotationRelative; // 0x335E35D0, was: <targetRotationRelative>k__Bac
        public object _defaultTargetPosRelToMuscle; // 0x335E35D0, was: <defaultTargetPosRelToMuscle>k
        public object rebuildParent; // 0x335E35D0
        public object rebuildTargetPosition; // 0x335E35D0
        public object rebuildAngularYMotion; // 0x335E35D0
        public object targetMappedRotation; // 0x335E35D0
        public object slerpDrive; // 0x335E35D0
        public object defaultPosition; // 0x335E35D0
        public object defaultLocalRotation; // 0x335E35D0
        public object toJointSpaceInverse; // 0x335E35D0
        public object defaultRotation; // 0x335E35D0
        public object lastMappedRotation; // 0x335E35D0
        public object angularXMotionDefault; // 0x335E35D0
        public object directTargetParent; // 0x335E35D0
        public object lastReadTime; // 0x335E35D0
        public object targetChildren; // 0x335E35D0
        public object additionalPinTargetAnimatedCenterOfMass; // 0x335E35D0
        public object pinWeightMlp; // 0x84429630
        public object muscleDamperMlp; // 0x84429630
        public object impulseMlp; // 0x84429630
        public object isDisconnected; // 0x84429630
        public object m_PositionDamper; // 0x84440E40
        public object set_transform; // 0xB3F6FFF0

        // ── Original Methods ──
        public void get_transform(){} // RVA: 0x7ffaa899d040
        public void set_transform(){} // RVA: 0x7ffaa899d050
        public void get_rigidbody(){} // RVA: 0x7ffaa899d0b0
        public void set_rigidbody(){} // RVA: 0x7ffaa899d0c0
        public void get_connectedBodyTarget(){} // RVA: 0x7ffaa899d120
        public void set_connectedBodyTarget(){} // RVA: 0x7ffaa899d130
        public void get_targetAnimatedPosition(){} // RVA: 0x7ffaa899d190
        public void set_targetAnimatedPosition(){} // RVA: 0x7ffaa899d1b0
        public void get_targetAnimatedWorldRotation(){} // RVA: 0x7ffaa899d1d0
        public void set_targetAnimatedWorldRotation(){} // RVA: 0x7ffaa899d1e0
        public void get_colliders(){} // RVA: 0x7ffaa899d1f0
        public void set_colliders(){} // RVA: 0x7ffaa899d200
        public void get_targetVelocity(){} // RVA: 0x7ffaa899d260
        public void set_targetVelocity(){} // RVA: 0x7ffaa899d280
        public void get_additionalRigidbody(){} // RVA: 0x7ffaa899d2a0
        public void set_additionalRigidbody(){} // RVA: 0x7ffaa899d2b0
        public void get_targetRotationRelative(){} // RVA: 0x7ffaa899d310
        public void set_targetRotationRelative(){} // RVA: 0x7ffaa899d320
        public void IsValid(){} // RVA: 0x7ffaa899d330
        public void get_rebuildConnectedBody(){} // RVA: 0x7ffaa899d5f0
        public void set_rebuildConnectedBody(){} // RVA: 0x7ffaa899d600
        public void get_rebuildTargetParent(){} // RVA: 0x7ffaa899d660
        public void set_rebuildTargetParent(){} // RVA: 0x7ffaa899d670
        public void get_defaultTargetPosRelToMuscle(){} // RVA: 0x7ffaa899d6d0
        public void set_defaultTargetPosRelToMuscle(){} // RVA: 0x7ffaa899d6f0
        public void get_defaultTargetRotRelToMuscle(){} // RVA: 0x7ffaa899d710
        public void set_defaultTargetRotRelToMuscle(){} // RVA: 0x7ffaa899d720
        public void get_defaultMuscleRotRelToTarget(){} // RVA: 0x7ffaa899d730
        public void set_defaultMuscleRotRelToTarget(){} // RVA: 0x7ffaa899d740
        public void Rebuild(){} // RVA: 0x7ffaa899d750
        public void Initiate(){} // RVA: 0x7ffaa899dbc0
        public void InitiateAdditionalPin(){} // RVA: 0x7ffaa89a0810
        public void UpdateColliders(){} // RVA: 0x7ffaa89a0b50
        public void DisableColliders(){} // RVA: 0x7ffaa89a0e80
        public void EnableColliders(){} // RVA: 0x7ffaa89a1030
        public void AddColliders(){} // RVA: 0x7ffaa89a10e0
        public void AddCompoundColliders(){} // RVA: 0x7ffaa89a13c0
        public void IgnoreInternalCollisions(){} // RVA: 0x7ffaa89a15b0
        public void ResetInternalCollisions(){} // RVA: 0x7ffaa89a1880
        public void ForceIgnore(){} // RVA: 0x7ffaa89a1b90
        public void IgnoreAngularLimits(){} // RVA: 0x7ffaa89a1f60
        public void FixTargetTransforms(){} // RVA: 0x7ffaa89a20d0
        public void Reset(){} // RVA: 0x7ffaa89a21c0
        public void MoveToTarget(){} // RVA: 0x7ffaa89a27d0
        public void Read(){} // RVA: 0x7ffaa89a3090
        public void ClearVelocities(){} // RVA: 0x7ffaa89a38f0
        public void UpdateAnchor(){} // RVA: 0x7ffaa89a3df0
        public void Update(){} // RVA: 0x7ffaa89a4440
        public void StoreTargetMappedPosition(){} // RVA: 0x7ffaa89a4710
        public void StoreTargetMappedRotation(){} // RVA: 0x7ffaa89a47a0
        public void Map(){} // RVA: 0x7ffaa89a4820
        public void ResetTargetLocalPosition(){} // RVA: 0x7ffaa89a5440
        public void CalculateMappedVelocity(){} // RVA: 0x7ffaa89a54c0
        public void MapDisconnected(){} // RVA: 0x7ffaa89a58d0
        public void Pin(){} // RVA: 0x7ffaa89a64e0
        public void Pin(){} // RVA: 0x7ffaa89a64e0
        public void MuscleRotation(){} // RVA: 0x7ffaa89a66f0
        public void get_localRotation(){} // RVA: 0x7ffaa89a6c70
        public void get_parentRotation(){} // RVA: 0x7ffaa89a6ee0
        public void get_targetParentRotation(){} // RVA: 0x7ffaa89a72a0
        public void get_targetLocalRotation(){} // RVA: 0x7ffaa89a7420
        public void LocalToJointSpace(){} // RVA: 0x7ffaa89a7770
        public void InverseTransformPointUnscaled(){} // RVA: 0x7ffaa89a7a30
        public void .ctor(){} // RVA: 0x7ffaa89a7cb0
        // ── Binary Analysis Named ──
        public void SetKinematic(){} // RVA: 0x7ffaa89a2ea0
        public void SetMuscleRotation(){} // RVA: 0x7ffaa89a69d0
    }

    public class MuscleCollisionBroadcaster : MonoBehaviour
    {
        public object onMuscleHit; // 0x335F9490
        public object otherBroadcaster; // 0x335F9490
        public object onLoseBalance; // 0x338571E0

        // ── Original Methods ──
        public void Hit(){} // RVA: 0x7ffaa89a8f80
        public void OnCollisionEnter(){} // RVA: 0x7ffaa89a9210
        public void OnCollisionStay(){} // RVA: 0x7ffaa89a9840
        public void OnCollisionExit(){} // RVA: 0x7ffaa89a9cd0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class PhysXTools : Object
    {
        // ── Original Methods ──
        public void Predict(){} // RVA: 0x7ffaa89aa720
        public void Predict(){} // RVA: 0x7ffaa89aa720
        public void Predict(){} // RVA: 0x7ffaa89aa720
        public void DivByInertia(){} // RVA: 0x7ffaa89ab490
        public void ScaleByInertia(){} // RVA: 0x7ffaa89ab850
        public void AddFromToTorque(){} // RVA: 0x7ffaa89acba0
        public void AddFromToTorque(){} // RVA: 0x7ffaa89acba0
        public void AddFromToForce(){} // RVA: 0x7ffaa89ad030
        public void ToJointSpace(){} // RVA: 0x7ffaa89ad410
        public void CalculateInertiaTensorCuboid(){} // RVA: 0x7ffaa89ad670
        public void Div(){} // RVA: 0x7ffaa89ad6c0
        // ── Binary Analysis Named ──
        public void GetCenterOfMass(){} // RVA: 0x7ffaa89aaf50
        public void GetCenterOfMass(){} // RVA: 0x7ffaa89aaf50
        public void GetCenterOfMassVelocity(){} // RVA: 0x7ffaa89ab1f0
        public void GetFromToAcceleration(){} // RVA: 0x7ffaa89abc10
        public void GetAngularAcceleration(){} // RVA: 0x7ffaa89abe20
        public void GetLinearAcceleration(){} // RVA: 0x7ffaa89ad350
    }

    public class PressureSensor : MonoBehaviour
    {
        public object _center; // 0x33834ED0, was: <center>k__BackingField
        public object _r; // 0x33834ED0, was: <r>k__BackingField
        public object count; // 0x33834ED0
        public object center; // 0x1700007F
        public object inContact; // 0x17000080
        public object bottom; // 0x17000081

        // ── Original Methods ──
        public void get_center(){} // RVA: 0x7ffaa89ad700
        public void set_center(){} // RVA: 0x7ffaa89ad720
        public void get_inContact(){} // RVA: 0x7ffaa8968c20
        public void set_inContact(){} // RVA: 0x7ffaa896cac0
        public void get_bottom(){} // RVA: 0x7ffaa8998f40
        public void set_bottom(){} // RVA: 0x7ffaa8998f60
        public void get_r(){} // RVA: 0x7ffaa89ad730
        public void set_r(){} // RVA: 0x7ffaa89ad740
        public void Awake(){} // RVA: 0x7ffaa89ad7a0
        public void OnCollisionEnter(){} // RVA: 0x7ffaa89ad8f0
        public void OnCollisionStay(){} // RVA: 0x7ffaa89ad8f0
        public void OnCollisionExit(){} // RVA: 0x7ffaa89ad900
        public void FixedUpdate(){} // RVA: 0x7ffaa89ad910
        public void LateUpdate(){} // RVA: 0x7ffaa89ad9d0
        public void ProcessCollision(){} // RVA: 0x7ffaa89ada20
        public void OnDrawGizmos(){} // RVA: 0x7ffaa89adc10
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class Prop : MonoBehaviour
    {
        public object muscleProps; // 0x335A3250
        public object additionalPinTarget; // 0x335A3250
        public object droppedMaterial; // 0x335A3250
        public object xMotion; // 0x335A3250
        public object angularXMotion; // 0x335A3250
        public object colliders; // 0x335A3250
        public object isPickedUp; // 0x17000083
        public object propRoot; // 0x17000084
        public object initiated; // 0x17000085

        // ── Original Methods ──
        public void get_isPickedUp(){} // RVA: 0x7ffaa89adc80
        public void get_propRoot(){} // RVA: 0x7ffaa89add50
        public void set_propRoot(){} // RVA: 0x7ffaa89add60
        public void PickUp(){} // RVA: 0x7ffaa89addc0
        public void Drop(){} // RVA: 0x7ffaa89ae290
        public void StartPickedUp(){} // RVA: 0x7ffaa89add60
        public void get_initiated(){} // RVA: 0x7ffaa89ae320
        public void set_initiated(){} // RVA: 0x7ffaa89ae330
        public void OnPickUp(){} // RVA: 0x7ffaa8932310
        public void OnDrop(){} // RVA: 0x7ffaa8932310
        public void OnStart(){} // RVA: 0x7ffaa8932310
        public void Start(){} // RVA: 0x7ffaa89ae340
        public void ReleaseJoint(){} // RVA: 0x7ffaa89ae9a0
        public void OnDrawGizmos(){} // RVA: 0x7ffaa89aeeb0
        public void .ctor(){} // RVA: 0x7ffaa89af4f0
        // ── Binary Analysis Named ──
        public void SetMaterial(){} // RVA: 0x7ffaa89aed40
    }

    public class PropMuscle : MonoBehaviour
    {
        public object additionalPinOffset; // 0x333685C0
        public object OnDropProp; // 0x333685C0
        public object targetDefaultLocalPos; // 0x333685C0

        // ── Original Methods ──
        public void get_muscle(){} // RVA: 0x7ffaa89af650
        public void get_activeProp(){} // RVA: 0x7ffaa89af740
        public void set_activeProp(){} // RVA: 0x7ffaa895a200
        public void AddAdditionalPin(){} // RVA: 0x7ffaa89af750
        public void RemoveAdditionalPin(){} // RVA: 0x7ffaa89b0310
        public void OnInitiate(){} // RVA: 0x7ffaa89b06a0
        public void TakeOver(){} // RVA: 0x7ffaa89b0860
        public void OnUpdate(){} // RVA: 0x7ffaa89b09b0
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaa89b18a0
        public void .ctor(){} // RVA: 0x7ffaa89b2100
    }

    public class PropRoot : MonoBehaviour
    {
        public object currentProp; // 0x339165D0

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void DropImmediate(){} // RVA: 0x7ffaa89b2310
        public void Awake(){} // RVA: 0x7ffaa89b24e0
        public void Update(){} // RVA: 0x7ffaa89b26a0
        public void FixedUpdate(){} // RVA: 0x7ffaa89b2950
        public void AttachProp(){} // RVA: 0x7ffaa89b2e50
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class PropTemplate : Prop
    {
        // ── Original Methods ──
        public void OnStart(){} // RVA: 0x7ffaa8932310
        public void OnPickUp(){} // RVA: 0x7ffaa8932310
        public void OnDrop(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa89af4f0
    }

    public class PuppetMaster : MonoBehaviour
    {
        public object state; // 0x334ACD50
        public object blendTime; // 0x334ACD50
        public object visualizeTargetPose; // 0x334ACD50
        public object muscleWeight; // 0x334ACD50
        public object pinPow; // 0x334ACD50
        public object updateJointAnchors; // 0x334ACD50
        public object internalCollisions; // 0x334ACD50
        public object OnPostInitiate; // 0x334ACD50
        public object OnPostLateUpdate; // 0x334ACD50
        public object OnMuscleRemoved; // 0x334ACD50
        public object _targetAnimator; // 0x334ACD50
        public object _initiated; // 0x334ACD50, was: <initiated>k__BackingField
        public object manualAngularLimitControl; // 0x334ACD50
        public object angularLimitsEnabled; // 0x334ACD50
        public object isLegacy; // 0x334ACD50
        public object interpolated; // 0x334ACD50
        public object hierarchyIsFlat; // 0x334ACD50
        public object teleportRotation; // 0x334ACD50
        public object onPostRebuildFlag; // 0x334ACD50
        public object disconnectDeactivateFlags; // 0x334ACD50
        public object rebuildPelvisPos; // 0x334ACD50
        public object _isSwitchingMode; // 0x334ACD50, was: <isSwitchingMode>k__BackingFie
        public object mappingBlend; // 0x334ACD50
        public object OnUnfreeze; // 0x334ACD50
        public object activeState; // 0x334ACD50
        public object internalCollisionsEnabledOnKill; // 0x334ACD50
        public object targetMappedStateStored; // 0x334ACD50
        public object hasProp; // 0x334ACD50
        public object deadMuscleDamper; // 0x8442AB00
        public object enableAngularLimitsOnKill; // 0x8442AB00
        public object 8؏f; // 0xB3F7C790

        // ── Original Methods ──
        public void OpenUserManualSetup(){} // RVA: 0x7ffaa8932310
        public void OpenUserManualComponent(){} // RVA: 0x7ffaa8932310
        public void OpenUserManualPerformance(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void OpenSetupTutorial(){} // RVA: 0x7ffaa8932310
        public void OpenComponentTutorial(){} // RVA: 0x7ffaa8932310
        public void ResetStateSettings(){} // RVA: 0x7ffaa89b34c0
        public void get_targetAnimator(){} // RVA: 0x7ffaa89b34f0
        public void set_targetAnimator(){} // RVA: 0x7ffaa89b38a0
        public void get_targetAnimation(){} // RVA: 0x7ffaa89b3900
        public void set_targetAnimation(){} // RVA: 0x7ffaa89b3910
        public void get_behaviours(){} // RVA: 0x7ffaa89b3970
        public void set_behaviours(){} // RVA: 0x7ffaa89b3980
        public void get_isActive(){} // RVA: 0x7ffaa89b39e0
        public void get_initiated(){} // RVA: 0x7ffaa89b3ad0
        public void set_initiated(){} // RVA: 0x7ffaa89b3ae0
        public void get_updateMode(){} // RVA: 0x7ffaa89b3af0
        public void get_controlsAnimator(){} // RVA: 0x7ffaa89b3b30
        public void get_isBlending(){} // RVA: 0x7ffaa89b3be0
        public void Teleport(){} // RVA: 0x7ffaa89b3c00
        public void get_autoSimulate(){} // RVA: 0x7ffaa89b3e00
        public void OnDisable(){} // RVA: 0x7ffaa89b3e90
        public void OnEnable(){} // RVA: 0x7ffaa89b4020
        public void Awake(){} // RVA: 0x7ffaa89b49e0
        public void Start(){} // RVA: 0x7ffaa89b4a20
        public void FindTargetRootRecursive(){} // RVA: 0x7ffaa89b4b00
        public void Initiate(){} // RVA: 0x7ffaa89b4fb0
        public void ActivateBehaviour(){} // RVA: 0x7ffaa89b5f70
        public void OnDestroy(){} // RVA: 0x7ffaa89b6190
        public void IsInterpolated(){} // RVA: 0x7ffaa89b62c0
        public void OnRebuild(){} // RVA: 0x7ffaa89b63a0
        public void OnPreSimulate(){} // RVA: 0x7ffaa89b66e0
        public void OnPostSimulate(){} // RVA: 0x7ffaa89b6eb0
        public void FixedUpdate(){} // RVA: 0x7ffaa89b7330
        public void Update(){} // RVA: 0x7ffaa89b7c60
        public void LateUpdate(){} // RVA: 0x7ffaa89b7df0
        public void OnLateUpdate(){} // RVA: 0x7ffaa89b80c0
        public void MoveToTarget(){} // RVA: 0x7ffaa89b8460
        public void Read(){} // RVA: 0x7ffaa89b8650
        public void FixTargetTransforms(){} // RVA: 0x7ffaa89b9ee0
        public void get_targetUpdateMode(){} // RVA: 0x7ffaa89ba120
        public void VisualizeTargetPose(){} // RVA: 0x7ffaa89ba360
        public void VisualizeHierarchy(){} // RVA: 0x7ffaa89ba3d0
        public void FlagInternalCollisionsForUpdate(){} // RVA: 0x7ffaa89ba710
        public void UpdateInternalCollisions(){} // RVA: 0x7ffaa89ba8a0
        public void UpdateInternalCollisions(){} // RVA: 0x7ffaa89ba8a0
        public void IgnoreInternalCollisions(){} // RVA: 0x7ffaa89baa00
        public void IgnoreInternalCollisions(){} // RVA: 0x7ffaa89baa00
        public void ResetInternalCollisions(){} // RVA: 0x7ffaa89bab40
        public void ResetInternalCollisions(){} // RVA: 0x7ffaa89bab40
        public void FlagAngularLimitsForUpdate(){} // RVA: 0x7ffaa89babd0
        public void UpdateAngularLimits(){} // RVA: 0x7ffaa89babf0
        public void AddPropMuscle(){} // RVA: 0x7ffaa89baca0
        public void IsDisconnecting(){} // RVA: 0x7ffaa89bb810
        public void IsReconnecting(){} // RVA: 0x7ffaa89bb850
        public void DisconnectMuscleRecursive(){} // RVA: 0x7ffaa89bb890
        public void ReconnectMuscleRecursive(){} // RVA: 0x7ffaa89bba10
        public void AddMuscle(){} // RVA: 0x7ffaa89bbd40
        public void Rebuild(){} // RVA: 0x7ffaa89bd1b0
        public void RemoveMuscleRecursive(){} // RVA: 0x7ffaa89bd1c0
        public void ReplaceMuscle(){} // RVA: 0x7ffaa89beb70
        public void DisableMuscleRecursive(){} // RVA: 0x7ffaa89becf0
        public void EnableMuscleRecursive(){} // RVA: 0x7ffaa89bedb0
        public void FlattenHierarchy(){} // RVA: 0x7ffaa89bee70
        public void TreeHierarchy(){} // RVA: 0x7ffaa89befe0
        public void FixMusclePositions(){} // RVA: 0x7ffaa89bf220
        public void FixMusclePositionsAndRotations(){} // RVA: 0x7ffaa89bf4d0
        public void HierarchyIsFlat(){} // RVA: 0x7ffaa89bf870
        public void ProcessDisconnects(){} // RVA: 0x7ffaa89bfb70
        public void ProcessReconnects(){} // RVA: 0x7ffaa89bfcb0
        public void OnDisconnectMuscleRecursive(){} // RVA: 0x7ffaa89bfd80
        public void DisconnectMuscle(){} // RVA: 0x7ffaa89c02a0
        public void OnReconnectMuscleRecursive(){} // RVA: 0x7ffaa89c1350
        public void ReconnectMuscle(){} // RVA: 0x7ffaa89c1510
        public void AddIndexesRecursive(){} // RVA: 0x7ffaa89c1f40
        public void DisconnectJoint(){} // RVA: 0x7ffaa89c20e0
        public void KillJoint(){} // RVA: 0x7ffaa89c23c0
        public void SwitchToActiveMode(){} // RVA: 0x7ffaa89c24e0
        public void SwitchToKinematicMode(){} // RVA: 0x7ffaa89c24f0
        public void SwitchToDisabledMode(){} // RVA: 0x7ffaa89c2500
        public void get_isSwitchingMode(){} // RVA: 0x7ffaa89c2510
        public void set_isSwitchingMode(){} // RVA: 0x7ffaa89c2520
        public void DisableImmediately(){} // RVA: 0x7ffaa89c2530
        public void SwitchModes(){} // RVA: 0x7ffaa89c2660
        public void DisabledToKinematic(){} // RVA: 0x7ffaa89c2bd0
        public void DisabledToActive(){} // RVA: 0x7ffaa89c2d40
        public void KinematicToDisabled(){} // RVA: 0x7ffaa89c2de0
        public void KinematicToActive(){} // RVA: 0x7ffaa89c2e80
        public void ActiveToDisabled(){} // RVA: 0x7ffaa89c2f20
        public void ActiveToKinematic(){} // RVA: 0x7ffaa89c2fc0
        public void ContainsJoint(){} // RVA: 0x7ffaa89c3980
        public void RemoveRagdollComponents(){} // RVA: 0x7ffaa89c6580
        public void FindGroup(){} // RVA: 0x7ffaa89c7a60
        public void RemoveUnnecessaryBones(){} // RVA: 0x7ffaa89c87f0
        public void IsClothCollider(){} // RVA: 0x7ffaa89c8e00
        public void get_isSwitchingState(){} // RVA: 0x7ffaa89c94a0
        public void get_isKilling(){} // RVA: 0x7ffaa89c94b0
        public void set_isKilling(){} // RVA: 0x7ffaa89c94c0
        public void get_isAlive(){} // RVA: 0x7ffaa89c94d0
        public void get_isFrozen(){} // RVA: 0x7ffaa89c94e0
        public void Kill(){} // RVA: 0x7ffaa89c9500
        public void Kill(){} // RVA: 0x7ffaa89c9500
        public void Freeze(){} // RVA: 0x7ffaa89c9530
        public void Freeze(){} // RVA: 0x7ffaa89c9530
        public void Resurrect(){} // RVA: 0x7ffaa89c9550
        public void SwitchStates(){} // RVA: 0x7ffaa89c9560
        public void AliveToDead(){} // RVA: 0x7ffaa89c9860
        public void OnFreezeFlag(){} // RVA: 0x7ffaa89c9910
        public void DeadToAlive(){} // RVA: 0x7ffaa89c9fd0
        public void DeadToFrozen(){} // RVA: 0x7ffaa89ca330
        public void FrozenToAlive(){} // RVA: 0x7ffaa89ca340
        public void FrozenToDead(){} // RVA: 0x7ffaa89ca6f0
        public void ActivateRagdoll(){} // RVA: 0x7ffaa89ca7e0
        public void CanFreeze(){} // RVA: 0x7ffaa89cab30
        public void SampleTargetMappedState(){} // RVA: 0x7ffaa89cac40
        public void FixTargetToSampledState(){} // RVA: 0x7ffaa89cad40
        public void StoreTargetMappedState(){} // RVA: 0x7ffaa89cb270
        public void UpdateHierarchies(){} // RVA: 0x7ffaa89cb350
        public void HasProp(){} // RVA: 0x7ffaa89cb970
        public void UpdateBroadcasterMuscleIndexes(){} // RVA: 0x7ffaa89cb9d0
        public void AssignParentAndChildIndexes(){} // RVA: 0x7ffaa89cbc40
        public void AddToParentsRecursive(){} // RVA: 0x7ffaa89cc1b0
        public void AddToChildrenRecursive(){} // RVA: 0x7ffaa89cc420
        public void AssignKinshipDegrees(){} // RVA: 0x7ffaa89cc760
        public void AssignKinshipsDownRecursive(){} // RVA: 0x7ffaa89cc900
        public void AssignKinshipsUpRecursive(){} // RVA: 0x7ffaa89ccb20
        public void IsValid(){} // RVA: 0x7ffaa89cd0a0
        public void .ctor(){} // RVA: 0x7ffaa89ce330
        // ── Binary Analysis Named ──
        public void SetInternalCollisionsManual(){} // RVA: 0x7ffaa89b3c40
        public void SetAngularLimitsManual(){} // RVA: 0x7ffaa89b3d60
        public void SetMuscles(){} // RVA: 0x7ffaa89bec30
        public void GetHighestDisconnectedParentIndex(){} // RVA: 0x7ffaa89bfae0
        public void SetMuscleWeights(){} // RVA: 0x7ffaa89c3650
        public void SetMuscleWeights(){} // RVA: 0x7ffaa89c3650
        public void SetMuscleWeights(){} // RVA: 0x7ffaa89c3650
        public void SetMuscleWeightsRecursive(){} // RVA: 0x7ffaa89c35c0
        public void SetMuscleWeightsRecursive(){} // RVA: 0x7ffaa89c35c0
        public void SetMuscleWeightsRecursive(){} // RVA: 0x7ffaa89c35c0
        public void SetMuscleWeights(){} // RVA: 0x7ffaa89c3650
        public void GetMuscle(){} // RVA: 0x7ffaa89c3930
        public void GetMuscle(){} // RVA: 0x7ffaa89c3930
        public void GetMuscle(){} // RVA: 0x7ffaa89c3930
        public void GetMuscleIndex(){} // RVA: 0x7ffaa89c4530
        public void GetMuscleIndex(){} // RVA: 0x7ffaa89c4530
        public void GetMuscleIndex(){} // RVA: 0x7ffaa89c4530
        public void GetMuscleIndex(){} // RVA: 0x7ffaa89c4530
        public void SetUp(){} // RVA: 0x7ffaa89c4a70
        public void SetUp(){} // RVA: 0x7ffaa89c4a70
        public void SetUpTo(){} // RVA: 0x7ffaa89c4d10
        public void SetUpMuscles(){} // RVA: 0x7ffaa89c6dd0
        public void SetAnimationEnabled(){} // RVA: 0x7ffaa89ca100
        public void GetMuscleIndexLowLevel(){} // RVA: 0x7ffaa89ccf00
        public void CheckMassVariation(){} // RVA: 0x7ffaa89cdee0
        public void CheckIfInitiated(){} // RVA: 0x7ffaa89ce2b0
    }

    public class PuppetMasterHumanoidConfig : ScriptableObject
    {
        public object mode; // 0x33C87760
        public object solverIterationCount; // 0x33C87760
        public object pinWeight; // 0x33C87760
        public object muscleDamper; // 0x33C87760
        public object angularPinning; // 0x33C87760
        public object angularLimits; // 0x33C87760
        public object `Ǐf; // 0x66DE1A7C

        // ── Original Methods ──
        public void ApplyTo(){} // RVA: 0x7ffaa89cfa00
        public void .ctor(){} // RVA: 0x7ffaa89d0140
        // ── Binary Analysis Named ──
        public void GetMuscle(){} // RVA: 0x7ffaa89cff30
    }

    public class PuppetMasterProp : MonoBehaviour
    {
        public object forceLayers; // 0x3366D5F0
        public object pickedUpMaterial; // 0x3366D5F0
        public object additionalPinMass; // 0x3366D5F0
        public object defaultLayer; // 0x3366D5F0
        public object droppedMaterials; // 0x3366D5F0
        public object _drag; // 0x3366D5F0
        public object _isKinematic; // 0x3366D5F0
        public object _constraints; // 0x3366D5F0

        // ── Original Methods ──
        public void get_isPickedUp(){} // RVA: 0x7ffaa89d0240
        public void set_isPickedUp(){} // RVA: 0x7ffaa89d0250
        public void OnPickUp(){} // RVA: 0x7ffaa8932310
        public void OnDrop(){} // RVA: 0x7ffaa8932310
        public void get_propMuscle(){} // RVA: 0x7ffaa89d0370
        public void set_propMuscle(){} // RVA: 0x7ffaa89d0380
        public void PickUp(){} // RVA: 0x7ffaa89d03e0
        public void Drop(){} // RVA: 0x7ffaa89d0d20
        public void Awake(){} // RVA: 0x7ffaa89d1810
        public void Start(){} // RVA: 0x7ffaa89d1c00
        public void Update(){} // RVA: 0x7ffaa89d20d0
        public void RemoveRigidbody(){} // RVA: 0x7ffaa89d22b0
        public void ReattachRigidbody(){} // RVA: 0x7ffaa89d2690
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaa89d2a60
        public void .ctor(){} // RVA: 0x7ffaa89d2ec0
        // ── Binary Analysis Named ──
        public void GetRigidbody(){} // RVA: 0x7ffaa89d0260
    }

    public class PuppetMasterSettings : Singleton`1
    {
        public object fixedUpdateLimit; // 0x33BE4890
        public object activePuppetCollisionThresholdMlp; // 0x33BE4890
        public object _currentlyDisabledPuppets; // 0x33BE4890, was: <currentlyDisabledPuppets>k__B
        public object currentlyActivePuppets; // 0x170000A4
        public object currentlyKinematicPuppets; // 0x170000A5
        public object currentlyDisabledPuppets; // 0x170000A6

        // ── Original Methods ──
        public void get_currentlyActivePuppets(){} // RVA: 0x7ffaa89d3080
        public void set_currentlyActivePuppets(){} // RVA: 0x7ffaa89d3090
        public void get_currentlyKinematicPuppets(){} // RVA: 0x7ffaa89d30a0
        public void set_currentlyKinematicPuppets(){} // RVA: 0x7ffaa89d30b0
        public void get_currentlyDisabledPuppets(){} // RVA: 0x7ffaa89d30c0
        public void set_currentlyDisabledPuppets(){} // RVA: 0x7ffaa89d30d0
        public void get_puppets(){} // RVA: 0x7ffaa89d30e0
        public void Register(){} // RVA: 0x7ffaa89d30f0
        public void Unregister(){} // RVA: 0x7ffaa89d3200
        public void UpdateMoveToTarget(){} // RVA: 0x7ffaa89d3260
        public void UpdateFree(){} // RVA: 0x7ffaa89d3290
        public void UpdateFixed(){} // RVA: 0x7ffaa89d32c0
        public void Update(){} // RVA: 0x7ffaa89d32f0
        public void FixedUpdate(){} // RVA: 0x7ffaa89d3530
        public void .ctor(){} // RVA: 0x7ffaa89d3590
    }

    public class PuppetMasterTools : Object
    {
        // ── Original Methods ──
        public void PositionRagdoll(){} // RVA: 0x7ffaa89d39c0
        public void RealignRagdoll(){} // RVA: 0x7ffaa89d48b0
        public void DirectionIntToVector3(){} // RVA: 0x7ffaa8979b70
        public void DirectionVector3ToInt(){} // RVA: 0x7ffaa89d5fa0
    }

    public class RagdollCreator : MonoBehaviour
    {
        // ── Original Methods ──
        public void ClearAll(){} // RVA: 0x7ffaa89e3240
        public void ClearTransform(){} // RVA: 0x7ffaa89e35f0
        public void CreateCollider(){} // RVA: 0x7ffaa89e4280
        public void CreateCollider(){} // RVA: 0x7ffaa89e4280
        public void Abs(){} // RVA: 0x7ffaa89e49d0
        public void Vector3Abs(){} // RVA: 0x7ffaa89e4a20
        public void DirectionIntToVector3(){} // RVA: 0x7ffaa8979b70
        public void DirectionToVector3(){} // RVA: 0x7ffaa8979b70
        public void DirectionVector3ToInt(){} // RVA: 0x7ffaa89d5fa0
        public void CreateJoint(){} // RVA: 0x7ffaa89e52f0
        public void ToSoftJointLimit(){} // RVA: 0x7ffaa89e65d0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetScaleF(){} // RVA: 0x7ffaa89e4940
        public void GetLocalOrthoDirection(){} // RVA: 0x7ffaa89e4a50
        public void GetConnectedBody(){} // RVA: 0x7ffaa89e4f30
    }

    public class RagdollEditor : MonoBehaviour
    {
        public object symmetry; // 0x336CE5E0

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void OpenTutorial(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa89e6710
    }

    public class SubBehaviourBalancer : SubBehaviourBase
    {
        public object _dirVel; // 0x33816400, was: <dirVel>k__BackingField
        public object _comV; // 0x33816400, was: <comV>k__BackingField
        public object copPoints; // 0x33816400
        public object I; // 0x33816400

        // ── Original Methods ──
        public void get_joint(){} // RVA: 0x7ffaa89357c0
        public void set_joint(){} // RVA: 0x7ffaa8998e80
        public void get_dir(){} // RVA: 0x7ffaa8998ee0
        public void set_dir(){} // RVA: 0x7ffaa8998f00
        public void get_dirVel(){} // RVA: 0x7ffaa8998f10
        public void set_dirVel(){} // RVA: 0x7ffaa8998f30
        public void get_cop(){} // RVA: 0x7ffaa8998f40
        public void set_cop(){} // RVA: 0x7ffaa8998f60
        public void get_com(){} // RVA: 0x7ffaa8998f70
        public void set_com(){} // RVA: 0x7ffaa8998f90
        public void get_comV(){} // RVA: 0x7ffaa8998fa0
        public void set_comV(){} // RVA: 0x7ffaa8998fc0
        public void Initiate(){} // RVA: 0x7ffaa8998fd0
        public void Solve(){} // RVA: 0x7ffaa89993a0
        public void .ctor(){} // RVA: 0x7ffaa899a250
    }

    public class SubBehaviourBase : Object
    {
        // ── Original Methods ──
        public void XZ(){} // RVA: 0x7ffaa899a3d0
        public void XYZ(){} // RVA: 0x7ffaa899a3f0
        public void Flatten(){} // RVA: 0x7ffaa899a420
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetY(){} // RVA: 0x7ffaa899a440
    }

    public class SubBehaviourCOM : SubBehaviourBase
    {
        public object velocityLerpSpeed; // 0x333C97D0
        public object offset; // 0x333C97D0
        public object _angle; // 0x333C97D0, was: <angle>k__BackingField
        public object _rotation; // 0x333C97D0, was: <rotation>k__BackingField
        public object _lastGroundedTime; // 0x333C97D0, was: <lastGroundedTime>k__BackingFi
        public object groundLayers; // 0x333C97D0
        public object position; // 0x17000063
        public object direction; // 0x17000064
        public object angle; // 0x17000065
        public object velocity; // 0x17000066
        public object centerOfPressure; // 0x17000067
        public object rotation; // 0x17000068

        // ── Original Methods ──
        public void get_position(){} // RVA: 0x7ffaa8998f40
        public void set_position(){} // RVA: 0x7ffaa8998f60
        public void get_direction(){} // RVA: 0x7ffaa8998f70
        public void set_direction(){} // RVA: 0x7ffaa8998f90
        public void get_angle(){} // RVA: 0x7ffaa899a460
        public void set_angle(){} // RVA: 0x7ffaa899a470
        public void get_velocity(){} // RVA: 0x7ffaa899a480
        public void set_velocity(){} // RVA: 0x7ffaa899a4a0
        public void get_centerOfPressure(){} // RVA: 0x7ffaa899a4b0
        public void set_centerOfPressure(){} // RVA: 0x7ffaa899a4d0
        public void get_rotation(){} // RVA: 0x7ffaa899a4e0
        public void set_rotation(){} // RVA: 0x7ffaa899a4f0
        public void get_inverseRotation(){} // RVA: 0x7ffaa899a500
        public void set_inverseRotation(){} // RVA: 0x7ffaa899a510
        public void get_isGrounded(){} // RVA: 0x7ffaa899a520
        public void set_isGrounded(){} // RVA: 0x7ffaa899a530
        public void get_lastGroundedTime(){} // RVA: 0x7ffaa899a540
        public void set_lastGroundedTime(){} // RVA: 0x7ffaa899a550
        public void Initiate(){} // RVA: 0x7ffaa899a560
        public void OnHierarchyChanged(){} // RVA: 0x7ffaa899ad20
        public void OnPreMuscleCollision(){} // RVA: 0x7ffaa899add0
        public void OnPreMuscleCollisionExit(){} // RVA: 0x7ffaa899b090
        public void OnPreActivate(){} // RVA: 0x7ffaa899b1e0
        public void OnPreLateUpdate(){} // RVA: 0x7ffaa899b320
        public void OnPreDeactivate(){} // RVA: 0x7ffaa899bbe0
        public void IsGrounded(){} // RVA: 0x7ffaa899bd90
        public void .ctor(){} // RVA: 0x7ffaa899ca50
        // ── Binary Analysis Named ──
        public void GetCollisionCOP(){} // RVA: 0x7ffaa899bc30
        public void GetCenterOfMass(){} // RVA: 0x7ffaa899bdf0
        public void GetCenterOfMassVelocity(){} // RVA: 0x7ffaa899c080
        public void GetMomentum(){} // RVA: 0x7ffaa899c420
        public void GetCenterOfPressure(){} // RVA: 0x7ffaa899c6a0
        public void GetFeetCentroid(){} // RVA: 0x7ffaa899c800
    }

    public class Weight : Object
    {
        public object curve; // 0x333CB220

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89d61c0
        public void .ctor(){} // RVA: 0x7ffaa89d61c0
        // ── Binary Analysis Named ──
        public void GetValue(){} // RVA: 0x7ffaa89d62c0
    }

}