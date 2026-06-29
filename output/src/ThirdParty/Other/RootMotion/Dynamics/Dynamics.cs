// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.Dynamics
// Classes: 36
// Methods: 616

namespace ThirdParty.Other.RootMotion.Dynamics
{
    public class AnimationBlocker : MonoBehaviour
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0xB9F2D0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class BehaviourBase : MonoBehaviour
    {
        public object puppetMaster;
        public object OnPreActivate;
        public object OnPreInitiate;
        public object OnPreFixedUpdate;
        public object OnPreUpdate;
        public object OnPreLateUpdate;
        public object OnPreDeactivate;
        public object OnPreFixTransforms;
        public object OnPreRead;
        public object OnPreWrite;
        public object OnPreMuscleHit;
        public object OnPreMuscleCollision;
        public object OnPreMuscleCollisionExit;
        public object OnHierarchyChanged;
        public object OnPostActivate;
        public object OnPostInitiate;
        public object OnPostFixedUpdate;
        public object OnPostUpdate;
        public object OnPostLateUpdate;
        public object OnPostDeactivate;
        public object OnPostDrawGizmos;
        public object OnPostFixTransforms;
        public object OnPostRead;
        public object OnPostWrite;
        public object OnPostMuscleHit;
        public object OnPostMuscleCollision;
        public object OnPostMuscleCollisionExit;
        public object deactivated;
        public object _forceActive;
        public object initiated;

        // ── Methods ──
        public void OnReactivate(){} // RVA: 0x894290
        public void Resurrect(){} // RVA: 0xB43310
        public void Freeze(){} // RVA: 0xB43310
        public void Unfreeze(){} // RVA: 0xB43310
        public void KillStart(){} // RVA: 0xB43310
        public void KillEnd(){} // RVA: 0xB43310
        public void OnTeleport(){} // RVA: 0xB43310
        public void OnMuscleDisconnected(){} // RVA: 0xB43310
        public void OnMuscleReconnected(){} // RVA: 0xB43310
        public void OnMuscleAdded(){} // RVA: 0xB9F4A0
        public void OnMuscleRemoved(){} // RVA: 0xB9F4A0
        public void OnActivate(){} // RVA: 0xB43310
        public void OnDeactivate(){} // RVA: 0xB43310
        public void OnInitiate(){} // RVA: 0xB43310
        public void OnFixedUpdate(){} // RVA: 0xB43310
        public void OnUpdate(){} // RVA: 0xB43310
        public void OnLateUpdate(){} // RVA: 0xB43310
        public void OnDrawGizmosBehaviour(){} // RVA: 0xB43310
        public void OnFixTransformsBehaviour(){} // RVA: 0xB43310
        public void OnReadBehaviour(){} // RVA: 0xB43310
        public void OnWriteBehaviour(){} // RVA: 0xB43310
        public void OnMuscleHitBehaviour(){} // RVA: 0xB43310
        public void OnMuscleCollisionBehaviour(){} // RVA: 0xB43310
        public void OnMuscleCollisionExitBehaviour(){} // RVA: 0xB43310
        public void get_forceActive(){} // RVA: 0xB9F4D0
        public void set_forceActive(){} // RVA: 0xB9F4E0
        public void Initiate(){} // RVA: 0xB9F4F0
        public void OnFixTransforms(){} // RVA: 0xB9F560
        public void OnRead(){} // RVA: 0xB9F5E0
        public void OnWrite(){} // RVA: 0xB9F660
        public void OnMuscleHit(){} // RVA: 0xB9F6E0
        public void OnMuscleCollision(){} // RVA: 0xB9F7A0
        public void OnMuscleCollisionExit(){} // RVA: 0xB9F860
        public void OnEnable(){} // RVA: 0xB9F930
        public void Activate(){} // RVA: 0xB9F950
        public void OnDisable(){} // RVA: 0xB9FBA0
        public void FixedUpdateB(){} // RVA: 0xB9FC10
        public void UpdateB(){} // RVA: 0xB9FCE0
        public void LateUpdateB(){} // RVA: 0xB9FDB0
        public void OnDrawGizmos(){} // RVA: 0xB9FE80
        public void RotateTargetToRootMuscle(){} // RVA: 0xB9FED0
        public void TranslateTargetToRootMuscle(){} // RVA: 0xBA04E0
        public void RemovePropMuscles(){} // RVA: 0xBA0970
        public void GroundTarget(){} // RVA: 0xBA0AE0
        public void ContainsRemovablePropMuscle(){} // RVA: 0xBA0F60
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class BehaviourBase[] : Array
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

    public class BehaviourFall : BehaviourBase
    {
        public object stateName;
        public object transitionDuration;
        public object layer;
        public object fixedTime;
        public object raycastLayers;
        public object blendParameter;
        public object writheHeight;
        public object writheYVelocity;
        public object blendSpeed;
        public object blendMappingSpeed;
        public object canEnd;
        public object minTime;
        public object maxEndVelocity;
        public object onEnd;
        public object timer;
        public object endTriggered;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void OnActivate(){} // RVA: 0xBA1D80
        public void OnDeactivate(){} // RVA: 0xBA1EB0
        public void OnReactivate(){} // RVA: 0xBA1EC0
        public void SmoothActivate(){} // RVA: 0xBA1EE0
        public void OnFixedUpdate(){} // RVA: 0xBA1F80
        public void OnLateUpdate(){} // RVA: 0xBA22F0
        public void Resurrect(){} // RVA: 0xBA2660
        public void GetBlendTarget(){} // RVA: 0xBA26C0
        public void GetGroundHeight(){} // RVA: 0xBA28F0
        public void OnMuscleReconnected(){} // RVA: 0xBA2BB0
        public void .ctor(){} // RVA: 0xBA2BF0
    }

    public class BehaviourPuppet : BehaviourBase
    {
        public object masterProps;
        public object groundLayers;
        public object collisionLayers;
        public object collisionThreshold;
        public object collisionResistance;
        public object collisionResistanceMultipliers;
        public object maxCollisions;
        public object regainPinSpeed;
        public object boostFalloff;
        public object defaults;
        public object groupOverrides;
        public object knockOutDistance;
        public object unpinnedMuscleWeightMlp;
        public object maxRigidbodyVelocity;
        public object pinWeightThreshold;
        public object unpinnedMuscleKnockout;
        public object dropProps;
        public object canGetUp;
        public object getUpDelay;
        public object blendToAnimationTime;
        public object maxGetUpVelocity;
        public object minGetUpDuration;
        public object getUpCollisionResistanceMlp;
        public object getUpRegainPinSpeedMlp;
        public object getUpKnockOutDistanceMlp;
        public object getUpOffsetProne;
        public object getUpOffsetSupine;
        public object onGetUpProne;
        public object onGetUpSupine;
        public object onLoseBalance;
        public object onLoseBalanceFromPuppet;
        public object onLoseBalanceFromGetUp;
        public object onRegainBalance;
        public object OnCollision;
        public object OnCollisionImpulse;
        public object _state;
        public object canMoveTarget;
        public object unpinnedTimer;
        public object getUpTimer;
        public object hipsForward;
        public object hipsUp;
        public object getupAnimationBlendWeight;
        public object getupAnimationBlendWeightV;
        public object getUpTargetFixed;
        public object lastNormalMode;
        public object collisions;
        public object eventsEnabled;
        public object lastKnockOutDistance;
        public object knockOutDistanceSqr;
        public object getupDisabled;
        public object hasCollidedSinceGetUp;
        public object hasBoosted;
        public object broadcaster;
        public object getUpPosition;
        public object dropPropFlag;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void get_state(){} // RVA: 0xBA31A0
        public void set_state(){} // RVA: 0xBA31B0
        public void OnReactivate(){} // RVA: 0xBA31C0
        public void Reset(){} // RVA: 0xBA3330
        public void OnTeleport(){} // RVA: 0xBA3390
        public void OnInitiate(){} // RVA: 0xBA35F0
        public void OnActivate(){} // RVA: 0xBA41C0
        public void KillStart(){} // RVA: 0xBA4290
        public void KillEnd(){} // RVA: 0xBA4340
        public void Resurrect(){} // RVA: 0xBA4350
        public void OnDeactivate(){} // RVA: 0xBA43E0
        public void OnFixedUpdate(){} // RVA: 0xBA43F0
        public void OnLateUpdate(){} // RVA: 0xBA4E70
        public void SetKinematic(){} // RVA: 0xBA50E0
        public void OnReadBehaviour(){} // RVA: 0xBA51C0
        public void BlendMuscleMapping(){} // RVA: 0xBA57E0
        public void OnMuscleAdded(){} // RVA: 0xBA59E0
        public void OnMuscleRemoved(){} // RVA: 0xBA5A40
        public void MoveTarget(){} // RVA: 0xBA5A90
        public void RotateTarget(){} // RVA: 0xBA5B70
        public void GroundTarget(){} // RVA: 0xBA5C40
        public void OnDrawGizmosSelected(){} // RVA: 0xBA5C60
        public void Boost(){} // RVA: 0xBA6080
        public void BoostImmunity(){} // RVA: 0xBA63A0
        public void BoostImpulseMlp(){} // RVA: 0xBA6620
        public void Unpin(){} // RVA: 0xBA6760
        public void OnMuscleHitBehaviour(){} // RVA: 0xBA67E0
        public void OnMuscleCollisionBehaviour(){} // RVA: 0xBA69B0
        public void GetImpulse(){} // RVA: 0xBA7090
        public void UnPin(){} // RVA: 0xBA7330
        public void UnPinMuscle(){} // RVA: 0xBA74A0
        public void Activate(){} // RVA: 0xBA77B0
        public void IsProne(){} // RVA: 0xBA7840
        public void GetFalloff(){} // RVA: 0xBA7C20
        public void InGroup(){} // RVA: 0xBA7DD0
        public void GetProps(){} // RVA: 0xBA7EA0
        public void SetState(){} // RVA: 0xBA7FA0
        public void SetColliders(){} // RVA: 0xBA91D0
        public void OnMuscleDisconnected(){} // RVA: 0xBA94C0
        public void OnMuscleReconnected(){} // RVA: 0xBA94D0
        public void .ctor(){} // RVA: 0xBA9580
    }

    public class BehaviourTemplate : BehaviourBase
    {
        public object centerOfMass;
        public object groundLayers;
        public object onLoseBalance;
        public object loseBalanceAngle;

        // ── Methods ──
        public void OnInitiate(){} // RVA: 0xBA9A30
        public void OnActivate(){} // RVA: 0xB43310
        public void OnReactivate(){} // RVA: 0xB43310
        public void OnDeactivate(){} // RVA: 0xB43310
        public void OnFixedUpdate(){} // RVA: 0xBA9A60
        public void OnLateUpdate(){} // RVA: 0xB43310
        public void OnMuscleHitBehaviour(){} // RVA: 0xBA9AB0
        public void OnMuscleCollisionBehaviour(){} // RVA: 0xBA9AB0
        public void .ctor(){} // RVA: 0xBA9B50
    }

    public class BipedRagdollCreator : RagdollCreator
    {
        public object canBuild;
        public object references;
        public object options;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void OpenTutorial(){} // RVA: 0xB43310
        public void AutodetectOptions(){} // RVA: 0xBE8820
        public void Create(){} // RVA: 0xBE8D70
        public void CreateColliders(){} // RVA: 0xBE8FE0
        public void CreateHandCollider(){} // RVA: 0xBEB140
        public void CreateFootCollider(){} // RVA: 0xBEBAA0
        public void GetChildCentroid(){} // RVA: 0xBEC8E0
        public void MassDistribution(){} // RVA: 0xBECC90
        public void CreateJoints(){} // RVA: 0xBED580
        public void CreateLimbJoints(){} // RVA: 0xBEE880
        public void ClearBipedRagdoll(){} // RVA: 0xBEFBF0
        public void IsClear(){} // RVA: 0xBEFC50
        public void GetUpperArmToHeadCentroid(){} // RVA: 0xBEFDB0
        public void GetUpperArmCentroid(){} // RVA: 0xBEFF60
        public void .ctor(){} // RVA: 0xBF0130
    }

    public class BipedRagdollReferences : ValueType
    {
        public object root;
        public object hips;
        public object spine;
        public object chest;
        public object head;
        public object leftUpperLeg;
        public object leftLowerLeg;
        public object leftFoot;
        public object rightUpperLeg;
        public object rightLowerLeg;
        public object rightFoot;
        public object leftUpperArm;
        public object leftLowerArm;
        public object leftHand;
        public object rightUpperArm;
        public object rightLowerArm;
        public object rightHand;

        // ── Methods ──
        public void IsValid(){} // RVA: 0x4E60
        public void IsChildRecursive(){} // RVA: 0x4E70
        public void IsEmpty(){} // RVA: 0x4E80
        public void Contains(){} // RVA: 0x4E90
        public void GetRagdollTransforms(){} // RVA: 0x4EA0
        public void FromAvatar(){} // RVA: 0xBF2BF0
        public void FromBipedReferences(){} // RVA: 0xBF3340
    }

    public class Booster : Object
    {
        public object fullBody;
        public object muscles;
        public object groups;
        public object immunity;
        public object impulseMlp;
        public object boostParents;
        public object boostChildren;
        public object delay;

        // ── Methods ──
        public void Boost(){} // RVA: 0xBADCE0
        public void .ctor(){} // RVA: 0xBAE120
    }

    public class JointBreakBroadcaster : MonoBehaviour
    {
        public object puppetMaster;
        public object muscleIndex;

        // ── Methods ──
        public void OnJointBreak(){} // RVA: 0xBAE240
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class JointConverter : Object
    {
        // ── Methods ──
        public void ToConfigurable(){} // RVA: 0xBF3920
        public void HingeToConfigurable(){} // RVA: 0xBF3C70
        public void FixedToConfigurable(){} // RVA: 0xBF4850
        public void SpringToConfigurable(){} // RVA: 0xBF4D20
        public void CharacterToConfigurable(){} // RVA: 0xBF5350
        public void ConvertJoint(){} // RVA: 0xBF6070
        public void ConvertToHighSoftJointLimit(){} // RVA: 0xBF66C0
        public void ConvertToLowSoftJointLimit(){} // RVA: 0xBF66F0
        public void ConvertToSoftJointLimitSpring(){} // RVA: 0xBF6710
        public void CopyLimit(){} // RVA: 0xBF6740
        public void CopyLimitSpring(){} // RVA: 0xBF6760
    }

    public class Muscle : Object
    {
        public object name;
        public object joint;
        public object target;
        public object props;
        public object state;
        public object parentIndexes;
        public object childIndexes;
        public object childFlags;
        public object kinshipDegrees;
        public object broadcaster;
        public object jointBreakBroadcaster;
        public object positionOffset;
        public object _transform;
        public object _rigidbody;
        public object _connectedBodyTarget;
        public object _targetAnimatedPosition;
        public object _targetAnimatedWorldRotation;
        public object _targetVelocity;
        public object _additionalRigidbody;
        public object additionalPin;
        public object additionalPinTarget;
        public object additionalPinWeight;
        public object mappedVelocity;
        public object mappedAngularVelocity;
        public object isPropMuscle;
        public object index;
        public object _targetRotationRelative;
        public object _rebuildConnectedBody;
        public object _rebuildTargetParent;
        public object _defaultTargetPosRelToMuscle;
        public object _defaultTargetRotRelToMuscle;
        public object _defaultMuscleRotRelToTarget;
        public object rebuildParent;
        public object rebuildPosition;
        public object rebuildRotation;
        public object rebuildTargetPosition;
        public object rebuildTargetRotation;
        public object rebuildAngularXMotion;
        public object rebuildAngularYMotion;
        public object rebuildAngularZMotion;
        public object targetMappedPosition;
        public object targetMappedRotation;
        public object targetSampledPosition;
        public object targetSampledRotation;
        public object slerpDrive;
        public object lastJointDriveRotationWeight;
        public object lastRotationDamper;
        public object defaultPosition;
        public object defaultTargetLocalPosition;
        public object lastMappedPosition;
        public object defaultLocalRotation;
        public object localRotationConvert;
        public object toParentSpace;
        public object toJointSpaceInverse;
        public object toJointSpaceDefault;
        public object targetAnimatedRotation;
        public object defaultRotation;
        public object rotationRelativeToTarget;
        public object defaultTargetLocalRotation;
        public object lastMappedRotation;
        public object targetParent;
        public object connectedBodyTransform;
        public object angularXMotionDefault;
        public object angularYMotionDefault;
        public object angularZMotionDefault;
        public object directTargetParent;
        public object initiated;
        public object _colliders;
        public object lastReadTime;
        public object lastWriteTime;
        public object disabledColliders;
        public object targetChildren;
        public object additionalTargetVelocity;
        public object targetAnimatedCenterOfMass;
        public object additionalPinTargetAnimatedCenterOfMass;
        public object defaultTargetRotRelToMuscleInverse;

        // ── Methods ──
        public void get_transform(){} // RVA: 0xBAE340
        public void set_transform(){} // RVA: 0xBAE350
        public void get_rigidbody(){} // RVA: 0xBAE3B0
        public void set_rigidbody(){} // RVA: 0xBAE3C0
        public void get_connectedBodyTarget(){} // RVA: 0xBAE420
        public void set_connectedBodyTarget(){} // RVA: 0xBAE430
        public void get_targetAnimatedPosition(){} // RVA: 0xBAE490
        public void set_targetAnimatedPosition(){} // RVA: 0xBAE4B0
        public void get_targetAnimatedWorldRotation(){} // RVA: 0xBAE4D0
        public void set_targetAnimatedWorldRotation(){} // RVA: 0xBAE4E0
        public void get_colliders(){} // RVA: 0xBAE4F0
        public void set_colliders(){} // RVA: 0xBAE500
        public void get_targetVelocity(){} // RVA: 0xBAE560
        public void set_targetVelocity(){} // RVA: 0xBAE580
        public void get_additionalRigidbody(){} // RVA: 0xBAE5A0
        public void set_additionalRigidbody(){} // RVA: 0xBAE5B0
        public void get_targetRotationRelative(){} // RVA: 0xBAE610
        public void set_targetRotationRelative(){} // RVA: 0xBAE620
        public void IsValid(){} // RVA: 0xBAE630
        public void get_rebuildConnectedBody(){} // RVA: 0xBAE8F0
        public void set_rebuildConnectedBody(){} // RVA: 0xBAE900
        public void get_rebuildTargetParent(){} // RVA: 0xBAE960
        public void set_rebuildTargetParent(){} // RVA: 0xBAE970
        public void get_defaultTargetPosRelToMuscle(){} // RVA: 0xBAE9D0
        public void set_defaultTargetPosRelToMuscle(){} // RVA: 0xBAE9F0
        public void get_defaultTargetRotRelToMuscle(){} // RVA: 0xBAEA10
        public void set_defaultTargetRotRelToMuscle(){} // RVA: 0xBAEA20
        public void get_defaultMuscleRotRelToTarget(){} // RVA: 0xBAEA30
        public void set_defaultMuscleRotRelToTarget(){} // RVA: 0xBAEA40
        public void Rebuild(){} // RVA: 0xBAEA50
        public void Initiate(){} // RVA: 0xBAEE30
        public void InitiateAdditionalPin(){} // RVA: 0xBB1350
        public void UpdateColliders(){} // RVA: 0xBB16E0
        public void DisableColliders(){} // RVA: 0xBB1AA0
        public void EnableColliders(){} // RVA: 0xBB1CE0
        public void AddColliders(){} // RVA: 0xBB1DB0
        public void AddCompoundColliders(){} // RVA: 0xBB2140
        public void IgnoreInternalCollisions(){} // RVA: 0xBB2350
        public void ResetInternalCollisions(){} // RVA: 0xBB2630
        public void ForceIgnore(){} // RVA: 0xBB2950
        public void IgnoreAngularLimits(){} // RVA: 0xBB2D50
        public void FixTargetTransforms(){} // RVA: 0xBB2DF0
        public void Reset(){} // RVA: 0xBB2F60
        public void MoveToTarget(){} // RVA: 0xBB3650
        public void SetKinematic(){} // RVA: 0xBB3F50
        public void Read(){} // RVA: 0xBB4090
        public void ClearVelocities(){} // RVA: 0xBB49A0
        public void UpdateAnchor(){} // RVA: 0xBB5000
        public void Update(){} // RVA: 0xBB5750
        public void StoreTargetMappedPosition(){} // RVA: 0xBB5AA0
        public void StoreTargetMappedRotation(){} // RVA: 0xBB5B80
        public void Map(){} // RVA: 0xBB5C50
        public void ResetTargetLocalPosition(){} // RVA: 0xBB6AE0
        public void CalculateMappedVelocity(){} // RVA: 0xBB6BA0
        public void MapDisconnected(){} // RVA: 0xBB70A0
        public void Pin(){} // RVA: 0xBB7F30
        public void MuscleRotation(){} // RVA: 0xBB81E0
        public void SetMuscleRotation(){} // RVA: 0xBB8510
        public void get_localRotation(){} // RVA: 0xBB8800
        public void get_parentRotation(){} // RVA: 0xBB8AB0
        public void get_targetParentRotation(){} // RVA: 0xBB8DF0
        public void get_targetLocalRotation(){} // RVA: 0xBB8FB0
        public void LocalToJointSpace(){} // RVA: 0xBB9350
        public void InverseTransformPointUnscaled(){} // RVA: 0xBB9610
        public void .ctor(){} // RVA: 0xBB9880
    }

    public class MuscleCollision : ValueType
    {
        public object muscleIndex;
        public object collision;
        public object isStay;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4AA0
    }

    public class MuscleCollisionBroadcaster : MonoBehaviour
    {
        public object puppetMaster;
        public object muscleIndex;
        public object onMuscleHit;
        public object onMuscleCollision;
        public object onMuscleCollisionExit;
        public object otherBroadcaster;

        // ── Methods ──
        public void Hit(){} // RVA: 0xBBAC40
        public void OnCollisionEnter(){} // RVA: 0xBBAF20
        public void OnCollisionStay(){} // RVA: 0xBBB490
        public void OnCollisionExit(){} // RVA: 0xBBB970
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class MuscleDisconnectMode[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class MuscleHit : ValueType
    {
        public object muscleIndex;
        public object unPin;
        public object force;
        public object position;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B00
    }

    public class Muscle[] : Array
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

    public class PhysXTools : Object
    {
        // ── Methods ──
        public void Predict(){} // RVA: 0xBBC550
        public void GetCenterOfMass(){} // RVA: 0xBBCDE0
        public void GetCenterOfMassVelocity(){} // RVA: 0xBBD0E0
        public void DivByInertia(){} // RVA: 0xBBD3E0
        public void ScaleByInertia(){} // RVA: 0xBBD780
        public void GetFromToAcceleration(){} // RVA: 0xBBDB20
        public void GetAngularAcceleration(){} // RVA: 0xBBDD30
        public void AddFromToTorque(){} // RVA: 0xBBEAF0
        public void AddFromToForce(){} // RVA: 0xBBEFC0
        public void GetLinearAcceleration(){} // RVA: 0xBBF450
        public void ToJointSpace(){} // RVA: 0xBBF510
        public void CalculateInertiaTensorCuboid(){} // RVA: 0xBBF830
        public void Div(){} // RVA: 0xBBF880
    }

    public class PressureSensor : MonoBehaviour
    {
        public object visualize;
        public object layers;
        public object _center;
        public object _inContact;
        public object _bottom;
        public object _r;
        public object fixedFrame;
        public object P;
        public object count;

        // ── Methods ──
        public void get_center(){} // RVA: 0xBBF8C0
        public void set_center(){} // RVA: 0xBBF8E0
        public void get_inContact(){} // RVA: 0xB78D60
        public void set_inContact(){} // RVA: 0xB7CBE0
        public void get_bottom(){} // RVA: 0xBA9C60
        public void set_bottom(){} // RVA: 0xBA9C80
        public void get_r(){} // RVA: 0xBBF8F0
        public void set_r(){} // RVA: 0xBBF900
        public void Awake(){} // RVA: 0xBBF960
        public void OnCollisionEnter(){} // RVA: 0xBBFAC0
        public void OnCollisionStay(){} // RVA: 0xBBFAC0
        public void OnCollisionExit(){} // RVA: 0xBBFAD0
        public void FixedUpdate(){} // RVA: 0xBBFAE0
        public void LateUpdate(){} // RVA: 0xBBFBE0
        public void ProcessCollision(){} // RVA: 0xBBFC30
        public void OnDrawGizmos(){} // RVA: 0xBBFE50
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class Prop : MonoBehaviour
    {
        public object propType;
        public object muscle;
        public object muscleProps;
        public object forceLayers;
        public object additionalPin;
        public object additionalPinTarget;
        public object additionalPinWeight;
        public object pickedUpMaterial;
        public object droppedMaterial;
        public object _propRoot;
        public object _initiated;
        public object xMotion;
        public object yMotion;
        public object zMotion;
        public object angularXMotion;
        public object angularYMotion;
        public object angularZMotion;
        public object colliders;

        // ── Methods ──
        public void get_isPickedUp(){} // RVA: 0xBBFEC0
        public void get_propRoot(){} // RVA: 0xBBFF90
        public void set_propRoot(){} // RVA: 0xBBFFA0
        public void PickUp(){} // RVA: 0xBC0000
        public void Drop(){} // RVA: 0xBC0350
        public void StartPickedUp(){} // RVA: 0xBBFFA0
        public void get_initiated(){} // RVA: 0xBC03E0
        public void set_initiated(){} // RVA: 0xBC03F0
        public void OnPickUp(){} // RVA: 0xB43310
        public void OnDrop(){} // RVA: 0xB43310
        public void OnStart(){} // RVA: 0xB43310
        public void Start(){} // RVA: 0xBC0400
        public void ReleaseJoint(){} // RVA: 0xBC0B20
        public void SetMaterial(){} // RVA: 0xBC10C0
        public void OnDrawGizmos(){} // RVA: 0xBC12B0
        public void .ctor(){} // RVA: 0xBC18E0
    }

    public class PropMuscle : MonoBehaviour
    {
        public object puppetMaster;
        public object currentProp;
        public object additionalPinOffset;
        public object _activeProp;
        public object OnPickUpProp;
        public object OnDropProp;
        public object _muscle;
        public object lastProp;
        public object targetDefaultLocalPos;
        public object lastAdditionalPinOffset;

        // ── Methods ──
        public void get_muscle(){} // RVA: 0xBC1A40
        public void get_activeProp(){} // RVA: 0xBC1B30
        public void set_activeProp(){} // RVA: 0xB6A8C0
        public void AddAdditionalPin(){} // RVA: 0xBC1B40
        public void RemoveAdditionalPin(){} // RVA: 0xBC2530
        public void OnInitiate(){} // RVA: 0xBC2880
        public void TakeOver(){} // RVA: 0xBC2A40
        public void OnUpdate(){} // RVA: 0xBC2B90
        public void OnDrawGizmosSelected(){} // RVA: 0xBC3B70
        public void .ctor(){} // RVA: 0xBC44A0
    }

    public class PropMuscle[] : Array
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

    public class PropRoot : MonoBehaviour
    {
        public object puppetMaster;
        public object connectTo;
        public object currentProp;
        public object lastProp;
        public object fixedUpdateCalled;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void DropImmediate(){} // RVA: 0xBC46A0
        public void Awake(){} // RVA: 0xBC4870
        public void Update(){} // RVA: 0xBC4A00
        public void FixedUpdate(){} // RVA: 0xBC4CB0
        public void AttachProp(){} // RVA: 0xBC51B0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class PropTemplate : Prop
    {
        // ── Methods ──
        public void OnStart(){} // RVA: 0xB43310
        public void OnPickUp(){} // RVA: 0xB43310
        public void OnDrop(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xBC18E0
    }

    public class PuppetMaster : MonoBehaviour
    {
        public object humanoidConfig;
        public object targetRoot;
        public object state;
        public object stateSettings;
        public object mode;
        public object blendTime;
        public object fixTargetTransforms;
        public object solverIterationCount;
        public object visualizeTargetPose;
        public object mappingWeight;
        public object pinWeight;
        public object muscleWeight;
        public object muscleSpring;
        public object muscleDamper;
        public object pinPow;
        public object pinDistanceFalloff;
        public object angularPinning;
        public object updateJointAnchors;
        public object supportTranslationAnimation;
        public object angularLimits;
        public object internalCollisions;
        public object muscles;
        public object propMuscles;
        public object OnPostInitiate;
        public object OnRead;
        public object OnWrite;
        public object OnPostLateUpdate;
        public object OnFixTransforms;
        public object OnHierarchyChanged;
        public object OnMuscleRemoved;
        public object OnMuscleDisconnected;
        public object OnMuscleReconnected;
        public object _targetAnimator;
        public object _targetAnimation;
        public object _behaviours;
        public object _initiated;
        public object solvers;
        public object manualInternalCollisionControl;
        public object manualAngularLimitControl;
        public object mapDisconnectedMuscles;
        public object internalCollisionsEnabled;
        public object angularLimitsEnabled;
        public object fixedFrame;
        public object lastSolverIterationCount;
        public object isLegacy;
        public object animatorDisabled;
        public object awakeFailed;
        public object interpolated;
        public object freezeFlag;
        public object hasBeenDisabled;
        public object hierarchyIsFlat;
        public object teleport;
        public object teleportPosition;
        public object teleportRotation;
        public object teleportMoveToTarget;
        public object rebuildFlag;
        public object onPostRebuildFlag;
        public object disconnectMuscleFlags;
        public object muscleDisconnectModes;
        public object disconnectDeactivateFlags;
        public object reconnectMuscleFlags;
        public object defaultMuscles;
        public object rebuildPelvisPos;
        public object rebuildPelvisRot;
        public object readInFixedUpdate;
        public object _isSwitchingMode;
        public object activeMode;
        public object lastMode;
        public object mappingBlend;
        public object _isKilling;
        public object OnFreeze;
        public object OnUnfreeze;
        public object OnDeath;
        public object OnResurrection;
        public object activeState;
        public object lastState;
        public object angularLimitsEnabledOnKill;
        public object internalCollisionsEnabledOnKill;
        public object animationDisabledbyStates;
        public object storeTargetMappedState;
        public object targetMappedStateStored;
        public object targetMappedStateSampled;
        public object sampleTargetMappedState;
        public object hasProp;

        // ── Methods ──
        public void OpenUserManualSetup(){} // RVA: 0xB43310
        public void OpenUserManualComponent(){} // RVA: 0xB43310
        public void OpenUserManualPerformance(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void OpenSetupTutorial(){} // RVA: 0xB43310
        public void OpenComponentTutorial(){} // RVA: 0xB43310
        public void ResetStateSettings(){} // RVA: 0xBC5770
        public void get_targetAnimator(){} // RVA: 0xBC57A0
        public void set_targetAnimator(){} // RVA: 0xBC5AD0
        public void get_targetAnimation(){} // RVA: 0xBC5B30
        public void set_targetAnimation(){} // RVA: 0xBC5B40
        public void get_behaviours(){} // RVA: 0xBC5BA0
        public void set_behaviours(){} // RVA: 0xBC5BB0
        public void get_isActive(){} // RVA: 0xBC5C10
        public void get_initiated(){} // RVA: 0xBC5D20
        public void set_initiated(){} // RVA: 0xBC5D30
        public void get_updateMode(){} // RVA: 0xBC5D40
        public void get_controlsAnimator(){} // RVA: 0xBC5F20
        public void get_isBlending(){} // RVA: 0xBC6000
        public void Teleport(){} // RVA: 0xBC6020
        public void SetInternalCollisionsManual(){} // RVA: 0xBC6060
        public void SetAngularLimitsManual(){} // RVA: 0xBC61B0
        public void get_autoSimulate(){} // RVA: 0xBC6250
        public void OnDisable(){} // RVA: 0xBC62E0
        public void OnEnable(){} // RVA: 0xBC6480
        public void Awake(){} // RVA: 0xBC70F0
        public void Start(){} // RVA: 0xBC7130
        public void FindTargetRootRecursive(){} // RVA: 0xBC71F0
        public void Initiate(){} // RVA: 0xBC7590
        public void ActivateBehaviour(){} // RVA: 0xBC85C0
        public void OnDestroy(){} // RVA: 0xBC8850
        public void IsInterpolated(){} // RVA: 0xBC8980
        public void OnRebuild(){} // RVA: 0xBC8AB0
        public void OnPreSimulate(){} // RVA: 0xBC8E80
        public void OnPostSimulate(){} // RVA: 0xBC97B0
        public void FixedUpdate(){} // RVA: 0xBC9D30
        public void Update(){} // RVA: 0xBCA6A0
        public void LateUpdate(){} // RVA: 0xBCA880
        public void OnLateUpdate(){} // RVA: 0xBCABD0
        public void MoveToTarget(){} // RVA: 0xBCB070
        public void Read(){} // RVA: 0xBCB260
        public void FixTargetTransforms(){} // RVA: 0xBCC7E0
        public void get_targetUpdateMode(){} // RVA: 0xBCC9F0
        public void VisualizeTargetPose(){} // RVA: 0xBCCBB0
        public void VisualizeHierarchy(){} // RVA: 0xBCCC20
        public void FlagInternalCollisionsForUpdate(){} // RVA: 0xBCD0B0
        public void UpdateInternalCollisions(){} // RVA: 0xBCD280
        public void IgnoreInternalCollisions(){} // RVA: 0xBCD420
        public void ResetInternalCollisions(){} // RVA: 0xBCD5A0
        public void FlagAngularLimitsForUpdate(){} // RVA: 0xBCD640
        public void UpdateAngularLimits(){} // RVA: 0xBCD660
        public void AddPropMuscle(){} // RVA: 0xBCD720
        public void IsDisconnecting(){} // RVA: 0xBCE390
        public void IsReconnecting(){} // RVA: 0xBCE3D0
        public void DisconnectMuscleRecursive(){} // RVA: 0xBCE410
        public void ReconnectMuscleRecursive(){} // RVA: 0xBCE550
        public void AddMuscle(){} // RVA: 0xBCE860
        public void Rebuild(){} // RVA: 0xBCFC40
        public void RemoveMuscleRecursive(){} // RVA: 0xBCFC50
        public void ReplaceMuscle(){} // RVA: 0xBD19C0
        public void SetMuscles(){} // RVA: 0xBD1A50
        public void DisableMuscleRecursive(){} // RVA: 0xBD1AE0
        public void EnableMuscleRecursive(){} // RVA: 0xBD1B70
        public void FlattenHierarchy(){} // RVA: 0xBD1C00
        public void TreeHierarchy(){} // RVA: 0xBD1D70
        public void FixMusclePositions(){} // RVA: 0xBD1FC0
        public void FixMusclePositionsAndRotations(){} // RVA: 0xBD2270
        public void HierarchyIsFlat(){} // RVA: 0xBD2600
        public void GetHighestDisconnectedParentIndex(){} // RVA: 0xBD27C0
        public void ProcessDisconnects(){} // RVA: 0xBD2890
        public void ProcessReconnects(){} // RVA: 0xBD29E0
        public void OnDisconnectMuscleRecursive(){} // RVA: 0xBD2AC0
        public void DisconnectMuscle(){} // RVA: 0xBD30B0
        public void OnReconnectMuscleRecursive(){} // RVA: 0xBD3A00
        public void ReconnectMuscle(){} // RVA: 0xBD3BF0
        public void AddIndexesRecursive(){} // RVA: 0xBD4330
        public void DisconnectJoint(){} // RVA: 0xBD44E0
        public void KillJoint(){} // RVA: 0xBD48C0
        public void SwitchToActiveMode(){} // RVA: 0xBD4A20
        public void SwitchToKinematicMode(){} // RVA: 0xBD4A30
        public void SwitchToDisabledMode(){} // RVA: 0xBD4A40
        public void get_isSwitchingMode(){} // RVA: 0xBD4A50
        public void set_isSwitchingMode(){} // RVA: 0xBD4A60
        public void DisableImmediately(){} // RVA: 0xBD4A70
        public void SwitchModes(){} // RVA: 0xBD4C50
        public void DisabledToKinematic(){} // RVA: 0xBD50A0
        public void DisabledToActive(){} // RVA: 0xBD5220
        public void KinematicToDisabled(){} // RVA: 0xBD52C0
        public void KinematicToActive(){} // RVA: 0xBD5370
        public void ActiveToDisabled(){} // RVA: 0xBD5410
        public void ActiveToKinematic(){} // RVA: 0xBD54B0
        public void SetMuscleWeights(){} // RVA: 0xBD5B90
        public void SetMuscleWeightsRecursive(){} // RVA: 0xBD5B00
        public void GetMuscle(){} // RVA: 0xBD5E30
        public void ContainsJoint(){} // RVA: 0xBD5E80
        public void GetMuscleIndex(){} // RVA: 0xBD6970
        public void SetUp(){} // RVA: 0xBD6E00
        public void SetUpTo(){} // RVA: 0xBD7060
        public void RemoveRagdollComponents(){} // RVA: 0xBD8840
        public void SetUpMuscles(){} // RVA: 0xBD9100
        public void FindGroup(){} // RVA: 0xBD9CD0
        public void RemoveUnnecessaryBones(){} // RVA: 0xBDAAA0
        public void IsClothCollider(){} // RVA: 0xBDB0A0
        public void get_isSwitchingState(){} // RVA: 0xBDB760
        public void get_isKilling(){} // RVA: 0xBDB770
        public void set_isKilling(){} // RVA: 0xBDB780
        public void get_isAlive(){} // RVA: 0xBDB790
        public void get_isFrozen(){} // RVA: 0xBDB7A0
        public void Kill(){} // RVA: 0xBDB7C0
        public void Freeze(){} // RVA: 0xBDB7F0
        public void Resurrect(){} // RVA: 0xBDB810
        public void SwitchStates(){} // RVA: 0xBDB820
        public void AliveToDead(){} // RVA: 0xBDBB30
        public void OnFreezeFlag(){} // RVA: 0xBDBBE0
        public void DeadToAlive(){} // RVA: 0xBDC500
        public void SetAnimationEnabled(){} // RVA: 0xBDC640
        public void DeadToFrozen(){} // RVA: 0xBDC800
        public void FrozenToAlive(){} // RVA: 0xBDC810
        public void FrozenToDead(){} // RVA: 0xBDCC40
        public void ActivateRagdoll(){} // RVA: 0xBDCD40
        public void CanFreeze(){} // RVA: 0xBDD190
        public void SampleTargetMappedState(){} // RVA: 0xBDD2E0
        public void FixTargetToSampledState(){} // RVA: 0xBDD3E0
        public void StoreTargetMappedState(){} // RVA: 0xBDD990
        public void UpdateHierarchies(){} // RVA: 0xBDDA80
        public void HasProp(){} // RVA: 0xBDE0A0
        public void UpdateBroadcasterMuscleIndexes(){} // RVA: 0xBDE110
        public void AssignParentAndChildIndexes(){} // RVA: 0xBDE380
        public void AddToParentsRecursive(){} // RVA: 0xBDE8C0
        public void AddToChildrenRecursive(){} // RVA: 0xBDEB00
        public void AssignKinshipDegrees(){} // RVA: 0xBDEE60
        public void AssignKinshipsDownRecursive(){} // RVA: 0xBDF000
        public void AssignKinshipsUpRecursive(){} // RVA: 0xBDF240
        public void GetMuscleIndexLowLevel(){} // RVA: 0xBDF6C0
        public void IsValid(){} // RVA: 0xBDF870
        public void CheckMassVariation(){} // RVA: 0xBE0620
        public void CheckIfInitiated(){} // RVA: 0xBE0A90
        public void .ctor(){} // RVA: 0xBE0B10
    }

    public class PuppetMasterHumanoidConfig : ScriptableObject
    {
        public object state;
        public object stateSettings;
        public object mode;
        public object blendTime;
        public object fixTargetTransforms;
        public object solverIterationCount;
        public object visualizeTargetPose;
        public object mappingWeight;
        public object pinWeight;
        public object muscleWeight;
        public object muscleSpring;
        public object muscleDamper;
        public object pinPow;
        public object pinDistanceFalloff;
        public object angularPinning;
        public object updateJointAnchors;
        public object supportTranslationAnimation;
        public object angularLimits;
        public object internalCollisions;
        public object muscles;

        // ── Methods ──
        public void ApplyTo(){} // RVA: 0xBE23A0
        public void GetMuscle(){} // RVA: 0xBE2830
        public void .ctor(){} // RVA: 0xBE2A30
    }

    public class PuppetMasterProp : MonoBehaviour
    {
        public object meshRoot;
        public object muscleProps;
        public object forceLayers;
        public object mass;
        public object propType;
        public object pickedUpMaterial;
        public object additionalPinOffsetAdd;
        public object additionalPinWeight;
        public object additionalPinMass;
        public object _isPickedUp;
        public object _propMuscle;
        public object defaultLayer;
        public object defaultParent;
        public object colliders;
        public object droppedMaterials;
        public object r;
        public object _mass;
        public object _drag;
        public object _angularDrag;
        public object _useGravity;
        public object _isKinematic;
        public object _interpolation;
        public object _collisionDetectionMode;
        public object _constraints;
        public object emptyColliders;

        // ── Methods ──
        public void get_isPickedUp(){} // RVA: 0xBE2B30
        public void set_isPickedUp(){} // RVA: 0xBE2B40
        public void GetRigidbody(){} // RVA: 0xBE2B50
        public void OnPickUp(){} // RVA: 0xB43310
        public void OnDrop(){} // RVA: 0xB43310
        public void get_propMuscle(){} // RVA: 0xBE2C60
        public void set_propMuscle(){} // RVA: 0xBE2C70
        public void PickUp(){} // RVA: 0xBE2CD0
        public void Drop(){} // RVA: 0xBE3770
        public void Awake(){} // RVA: 0xBE43B0
        public void Start(){} // RVA: 0xBE4780
        public void Update(){} // RVA: 0xBE4B30
        public void RemoveRigidbody(){} // RVA: 0xBE4D10
        public void ReattachRigidbody(){} // RVA: 0xBE4F40
        public void OnDrawGizmosSelected(){} // RVA: 0xBE5180
        public void .ctor(){} // RVA: 0xBE5690
    }

    public class PuppetMasterSettings : Singleton`1
    {
        public object kinematicCollidersUpdateLimit;
        public object freeUpdateLimit;
        public object fixedUpdateLimit;
        public object collisionStayMessages;
        public object collisionExitMessages;
        public object activePuppetCollisionThresholdMlp;
        public object _currentlyActivePuppets;
        public object _currentlyKinematicPuppets;
        public object _currentlyDisabledPuppets;
        public object _puppets;

        // ── Methods ──
        public void get_currentlyActivePuppets(){} // RVA: 0xBE5850
        public void set_currentlyActivePuppets(){} // RVA: 0xBE5860
        public void get_currentlyKinematicPuppets(){} // RVA: 0xBE5870
        public void set_currentlyKinematicPuppets(){} // RVA: 0xBE5880
        public void get_currentlyDisabledPuppets(){} // RVA: 0xBE5890
        public void set_currentlyDisabledPuppets(){} // RVA: 0xBE58A0
        public void get_puppets(){} // RVA: 0xBE58B0
        public void Register(){} // RVA: 0xBE58C0
        public void Unregister(){} // RVA: 0xBE59D0
        public void UpdateMoveToTarget(){} // RVA: 0xBE5A30
        public void UpdateFree(){} // RVA: 0xBE5A60
        public void UpdateFixed(){} // RVA: 0xBE5A90
        public void Update(){} // RVA: 0xBE5AC0
        public void FixedUpdate(){} // RVA: 0xBE5CF0
        public void .ctor(){} // RVA: 0xBE5D60
    }

    public class PuppetMasterTools : Object
    {
        // ── Methods ──
        public void PositionRagdoll(){} // RVA: 0xBE6190
        public void RealignRagdoll(){} // RVA: 0xBE7030
        public void DirectionIntToVector3(){} // RVA: 0xB89E50
        public void DirectionVector3ToInt(){} // RVA: 0xBE8460
    }

    public class PuppetMaster[] : Array
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

    public class RagdollCreator : MonoBehaviour
    {
        // ── Methods ──
        public void ClearAll(){} // RVA: 0xBF6780
        public void ClearTransform(){} // RVA: 0xBF6AF0
        public void CreateCollider(){} // RVA: 0xBF7850
        public void GetScaleF(){} // RVA: 0xBF7F80
        public void Abs(){} // RVA: 0xBF8050
        public void Vector3Abs(){} // RVA: 0xBF80A0
        public void DirectionIntToVector3(){} // RVA: 0xB89E50
        public void DirectionToVector3(){} // RVA: 0xB89E50
        public void DirectionVector3ToInt(){} // RVA: 0xBE8460
        public void GetLocalOrthoDirection(){} // RVA: 0xBF80D0
        public void GetConnectedBody(){} // RVA: 0xBF85F0
        public void CreateJoint(){} // RVA: 0xBF8920
        public void ToSoftJointLimit(){} // RVA: 0xBF9C20
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class RagdollEditor : MonoBehaviour
    {
        public object selectedRigidbody;
        public object selectedCollider;
        public object symmetry;
        public object mode;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void OpenTutorial(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xBF9D60
    }

    public class SubBehaviourBalancer : SubBehaviourBase
    {
        public object _joint;
        public object _dir;
        public object _dirVel;
        public object _cop;
        public object _com;
        public object _comV;
        public object settings;
        public object rigidbodies;
        public object copPoints;
        public object pressureSensor;
        public object Ibody;
        public object I;
        public object toJointSpace;

        // ── Methods ──
        public void get_joint(){} // RVA: 0xB465B0
        public void set_joint(){} // RVA: 0xBA9BA0
        public void get_dir(){} // RVA: 0xBA9C00
        public void set_dir(){} // RVA: 0xBA9C20
        public void get_dirVel(){} // RVA: 0xBA9C30
        public void set_dirVel(){} // RVA: 0xBA9C50
        public void get_cop(){} // RVA: 0xBA9C60
        public void set_cop(){} // RVA: 0xBA9C80
        public void get_com(){} // RVA: 0xBA9C90
        public void set_com(){} // RVA: 0xBA9CB0
        public void get_comV(){} // RVA: 0xBA9CC0
        public void set_comV(){} // RVA: 0xBA9CE0
        public void Initiate(){} // RVA: 0xBA9CF0
        public void Solve(){} // RVA: 0xBAA0B0
        public void .ctor(){} // RVA: 0xBAB220
    }

    public class SubBehaviourBase : Object
    {
        public object behaviour;

        // ── Methods ──
        public void XZ(){} // RVA: 0xBAB3A0
        public void XYZ(){} // RVA: 0xBAB3C0
        public void Flatten(){} // RVA: 0xBAB3F0
        public void SetY(){} // RVA: 0xBAB410
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SubBehaviourCOM : SubBehaviourBase
    {
        public object mode;
        public object velocityDamper;
        public object velocityLerpSpeed;
        public object velocityMax;
        public object centerOfPressureSpeed;
        public object offset;
        public object _position;
        public object _direction;
        public object _angle;
        public object _velocity;
        public object _centerOfPressure;
        public object _rotation;
        public object _inverseRotation;
        public object _isGrounded;
        public object _lastGroundedTime;
        public object groundContacts;
        public object groundContactPoints;
        public object groundLayers;

        // ── Methods ──
        public void get_position(){} // RVA: 0xBA9C60
        public void set_position(){} // RVA: 0xBA9C80
        public void get_direction(){} // RVA: 0xBA9C90
        public void set_direction(){} // RVA: 0xBA9CB0
        public void get_angle(){} // RVA: 0xBAB430
        public void set_angle(){} // RVA: 0xBAB440
        public void get_velocity(){} // RVA: 0xBAB450
        public void set_velocity(){} // RVA: 0xBAB470
        public void get_centerOfPressure(){} // RVA: 0xBAB480
        public void set_centerOfPressure(){} // RVA: 0xBAB4A0
        public void get_rotation(){} // RVA: 0xBAB4B0
        public void set_rotation(){} // RVA: 0xBAB4C0
        public void get_inverseRotation(){} // RVA: 0xBAB4D0
        public void set_inverseRotation(){} // RVA: 0xBAB4E0
        public void get_isGrounded(){} // RVA: 0xBAB4F0
        public void set_isGrounded(){} // RVA: 0xBAB500
        public void get_lastGroundedTime(){} // RVA: 0xBAB510
        public void set_lastGroundedTime(){} // RVA: 0xBAB520
        public void Initiate(){} // RVA: 0xBAB530
        public void OnHierarchyChanged(){} // RVA: 0xBABCF0
        public void OnPreMuscleCollision(){} // RVA: 0xBABDA0
        public void OnPreMuscleCollisionExit(){} // RVA: 0xBAC090
        public void OnPreActivate(){} // RVA: 0xBAC220
        public void OnPreLateUpdate(){} // RVA: 0xBAC360
        public void OnPreDeactivate(){} // RVA: 0xBACC40
        public void GetCollisionCOP(){} // RVA: 0xBACC90
        public void IsGrounded(){} // RVA: 0xBACDF0
        public void GetCenterOfMass(){} // RVA: 0xBACE50
        public void GetCenterOfMassVelocity(){} // RVA: 0xBAD190
        public void GetMomentum(){} // RVA: 0xBAD670
        public void GetCenterOfPressure(){} // RVA: 0xBAD950
        public void GetFeetCentroid(){} // RVA: 0xBADAB0
        public void .ctor(){} // RVA: 0xBADCC0
    }

    public class Weight : Object
    {
        public object mode;
        public object floatValue;
        public object curve;
        public object tooltip;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xBE8680
        public void GetValue(){} // RVA: 0xBE8780
    }

}