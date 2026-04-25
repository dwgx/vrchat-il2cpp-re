// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.Dynamics
// Classes: 31
// Methods: 572

namespace ThirdParty.Other.RootMotion.Dynamics
{
    public class AnimationBlocker : MonoBehaviour
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x7FFAC2F7DD90
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class BehaviourBase : MonoBehaviour
    {
        public RootMotion.Dynamics.PuppetMaster forceActive; // 0x20
        public BehaviourDelegate OnPreActivate; // 0x28
        public BehaviourDelegate OnPreInitiate; // 0x30
        public BehaviourDelegate OnPreFixedUpdate; // 0x38
        public BehaviourDelegate OnPreUpdate; // 0x40
        public BehaviourDelegate OnPreLateUpdate; // 0x48
        public BehaviourDelegate OnPreDeactivate; // 0x50
        public BehaviourDelegate OnPreFixTransforms; // 0x58
        public BehaviourDelegate OnPreRead; // 0x60
        public BehaviourDelegate OnPreWrite; // 0x68
        public HitDelegate OnPreMuscleHit; // 0x70
        public CollisionDelegate OnPreMuscleCollision; // 0x78
        public CollisionDelegate OnPreMuscleCollisionExit; // 0x80
        public BehaviourDelegate OnHierarchyChanged; // 0x88
        public BehaviourDelegate OnPostActivate; // 0x90
        public BehaviourDelegate OnPostInitiate; // 0x98
        public BehaviourDelegate OnPostFixedUpdate; // 0xA0
        public BehaviourDelegate OnPostUpdate; // 0xA8
        public BehaviourDelegate OnPostLateUpdate; // 0xB0
        public BehaviourDelegate OnPostDeactivate; // 0xB8
        public BehaviourDelegate OnPostDrawGizmos; // 0xC0
        public BehaviourDelegate OnPostFixTransforms; // 0xC8
        public BehaviourDelegate OnPostRead; // 0xD0
        public BehaviourDelegate OnPostWrite; // 0xD8
        public HitDelegate OnPostMuscleHit; // 0xE0
        public CollisionDelegate OnPostMuscleCollision; // 0xE8
        public CollisionDelegate OnPostMuscleCollisionExit; // 0xF0
        public bool deactivated; // 0xF8
        public bool <forceActive>k__BackingField; // 0xF9
        public bool initiated; // 0xFA

        // ── Methods ──
        public void OnReactivate(){} // RVA: 0x7FFAC2C70980
        public void Resurrect(){} // RVA: 0x7FFAC2F21310
        public void Freeze(){} // RVA: 0x7FFAC2F21310
        public void Unfreeze(){} // RVA: 0x7FFAC2F21310
        public void KillStart(){} // RVA: 0x7FFAC2F21310
        public void KillEnd(){} // RVA: 0x7FFAC2F21310
        public void OnTeleport(){} // RVA: 0x7FFAC2F21310
        public void OnMuscleDisconnected(){} // RVA: 0x7FFAC2F21310
        public void OnMuscleReconnected(){} // RVA: 0x7FFAC2F21310
        public void OnMuscleAdded(){} // RVA: 0x7FFAC2F7DF60
        public void OnMuscleRemoved(){} // RVA: 0x7FFAC2F7DF60
        public void OnActivate(){} // RVA: 0x7FFAC2F21310
        public void OnDeactivate(){} // RVA: 0x7FFAC2F21310
        public void OnInitiate(){} // RVA: 0x7FFAC2F21310
        public void OnFixedUpdate(){} // RVA: 0x7FFAC2F21310
        public void OnUpdate(){} // RVA: 0x7FFAC2F21310
        public void OnLateUpdate(){} // RVA: 0x7FFAC2F21310
        public void OnDrawGizmosBehaviour(){} // RVA: 0x7FFAC2F21310
        public void OnFixTransformsBehaviour(){} // RVA: 0x7FFAC2F21310
        public void OnReadBehaviour(){} // RVA: 0x7FFAC2F21310
        public void OnWriteBehaviour(){} // RVA: 0x7FFAC2F21310
        public void OnMuscleHitBehaviour(){} // RVA: 0x7FFAC2F21310
        public void OnMuscleCollisionBehaviour(){} // RVA: 0x7FFAC2F21310
        public void OnMuscleCollisionExitBehaviour(){} // RVA: 0x7FFAC2F21310
        public void get_forceActive(){} // RVA: 0x7FFAC2F7DF90
        public void set_forceActive(){} // RVA: 0x7FFAC2F7DFA0
        public void Initiate(){} // RVA: 0x7FFAC2F7DFB0
        public void OnFixTransforms(){} // RVA: 0x7FFAC2F7E020
        public void OnRead(){} // RVA: 0x7FFAC2F7E0E0
        public void OnWrite(){} // RVA: 0x7FFAC2F7E1A0
        public void OnMuscleHit(){} // RVA: 0x7FFAC2F7E260
        public void OnMuscleCollision(){} // RVA: 0x7FFAC2F7E320
        public void OnMuscleCollisionExit(){} // RVA: 0x7FFAC2F7E3E0
        public void OnEnable(){} // RVA: 0x7FFAC2F7E4B0
        public void Activate(){} // RVA: 0x7FFAC2F7E4D0
        public void OnDisable(){} // RVA: 0x7FFAC2F7E6D0
        public void FixedUpdateB(){} // RVA: 0x7FFAC2F7E740
        public void UpdateB(){} // RVA: 0x7FFAC2F7E850
        public void LateUpdateB(){} // RVA: 0x7FFAC2F7E960
        public void OnDrawGizmos(){} // RVA: 0x7FFAC2F7EA70
        public void RotateTargetToRootMuscle(){} // RVA: 0x7FFAC2F7EAC0
        public void TranslateTargetToRootMuscle(){} // RVA: 0x7FFAC2F7F030
        public void RemovePropMuscles(){} // RVA: 0x7FFAC2F7F390
        public void GroundTarget(){} // RVA: 0x7FFAC2F7F4D0
        public void ContainsRemovablePropMuscle(){} // RVA: 0x7FFAC2F7F910
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class BehaviourFall : BehaviourBase
    {
        public string stateName; // 0x100
        public float transitionDuration; // 0x108
        public int layer; // 0x10C
        public float fixedTime; // 0x110
        public UnityEngine.LayerMask raycastLayers; // 0x114
        public string blendParameter; // 0x118
        public float writheHeight; // 0x120
        public float writheYVelocity; // 0x124
        public float blendSpeed; // 0x128
        public float blendMappingSpeed; // 0x12C
        public bool canEnd; // 0x130
        public float minTime; // 0x134
        public float maxEndVelocity; // 0x138
        public PuppetEvent onEnd; // 0x140
        public float timer; // 0x158
        public bool endTriggered; // 0x15C

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void OnActivate(){} // RVA: 0x7FFAC2F807C0
        public void OnDeactivate(){} // RVA: 0x7FFAC2F808B0
        public void OnReactivate(){} // RVA: 0x7FFAC2F808C0
        public void SmoothActivate(){} // RVA: 0x7FFAC2F808E0
        public void OnFixedUpdate(){} // RVA: 0x7FFAC2F80980
        public void OnLateUpdate(){} // RVA: 0x7FFAC2F80D30
        public void Resurrect(){} // RVA: 0x7FFAC2F80FB0
        public void GetBlendTarget(){} // RVA: 0x7FFAC2F81010
        public void GetGroundHeight(){} // RVA: 0x7FFAC2F811F0
        public void OnMuscleReconnected(){} // RVA: 0x7FFAC2F81470
        public void .ctor(){} // RVA: 0x7FFAC2F814B0
    }

    public class BehaviourPuppet : BehaviourBase
    {
        public MasterProps state; // 0x100
        public UnityEngine.LayerMask groundLayers; // 0x108
        public UnityEngine.LayerMask collisionLayers; // 0x10C
        public float collisionThreshold; // 0x110
        public RootMotion.Dynamics.Weight collisionResistance; // 0x118
        public CollisionResistanceMultiplier[] collisionResistanceMultipliers; // 0x120
        public int maxCollisions; // 0x128
        public float regainPinSpeed; // 0x12C
        public float boostFalloff; // 0x130
        public MuscleProps defaults; // 0x138
        public MusclePropsGroup[] groupOverrides; // 0x170
        public float knockOutDistance; // 0x178
        public float unpinnedMuscleWeightMlp; // 0x17C
        public float maxRigidbodyVelocity; // 0x180
        public float pinWeightThreshold; // 0x184
        public bool unpinnedMuscleKnockout; // 0x188
        public bool dropProps; // 0x189
        public bool canGetUp; // 0x18A
        public float getUpDelay; // 0x18C
        public float blendToAnimationTime; // 0x190
        public float maxGetUpVelocity; // 0x194
        public float minGetUpDuration; // 0x198
        public float getUpCollisionResistanceMlp; // 0x19C
        public float getUpRegainPinSpeedMlp; // 0x1A0
        public float getUpKnockOutDistanceMlp; // 0x1A4
        public UnityEngine.Vector3 getUpOffsetProne; // 0x1A8
        public UnityEngine.Vector3 getUpOffsetSupine; // 0x1B4
        public PuppetEvent onGetUpProne; // 0x1C0
        public PuppetEvent onGetUpSupine; // 0x1D8
        public PuppetEvent onLoseBalance; // 0x1F0
        public PuppetEvent onLoseBalanceFromPuppet; // 0x208
        public PuppetEvent onLoseBalanceFromGetUp; // 0x220
        public PuppetEvent onRegainBalance; // 0x238
        public CollisionDelegate OnCollision; // 0x250
        public CollisionImpulseDelegate OnCollisionImpulse; // 0x258
        public 0x6B1BD628 <state>k__BackingField; // 0x260
        public bool canMoveTarget; // 0x264
        public float unpinnedTimer; // 0x268
        public float getUpTimer; // 0x26C
        public UnityEngine.Vector3 hipsForward; // 0x270
        public UnityEngine.Vector3 hipsUp; // 0x27C
        public float getupAnimationBlendWeight; // 0x288
        public float getupAnimationBlendWeightV; // 0x28C
        public bool getUpTargetFixed; // 0x290
        public 0x6B1BD680 lastNormalMode; // 0x294
        public int collisions; // 0x298
        public bool eventsEnabled; // 0x29C
        public float lastKnockOutDistance; // 0x2A0
        public float knockOutDistanceSqr; // 0x2A4
        public bool getupDisabled; // 0x2A8
        public bool hasCollidedSinceGetUp; // 0x2A9
        public bool hasBoosted; // 0x2AA
        public RootMotion.Dynamics.MuscleCollisionBroadcaster broadcaster; // 0x2B0
        public UnityEngine.Vector3 getUpPosition; // 0x2B8
        public bool dropPropFlag; // 0x2C4

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void get_state(){} // RVA: 0x7FFAC2F819C0
        public void set_state(){} // RVA: 0x7FFAC2F819D0
        public void OnReactivate(){} // RVA: 0x7FFAC2F819E0
        public void Reset(){} // RVA: 0x7FFAC2F81B00
        public void OnTeleport(){} // RVA: 0x7FFAC2F81B60
        public void OnInitiate(){} // RVA: 0x7FFAC2F81DA0
        public void OnActivate(){} // RVA: 0x7FFAC2F827D0
        public void KillStart(){} // RVA: 0x7FFAC2F82880
        public void KillEnd(){} // RVA: 0x7FFAC2F82930
        public void Resurrect(){} // RVA: 0x7FFAC2F82940
        public void OnDeactivate(){} // RVA: 0x7FFAC2F829D0
        public void OnFixedUpdate(){} // RVA: 0x7FFAC2F829E0
        public void OnLateUpdate(){} // RVA: 0x7FFAC2F833F0
        public void SetKinematic(){} // RVA: 0x7FFAC2F83650
        public void OnReadBehaviour(){} // RVA: 0x7FFAC2F83720
        public void BlendMuscleMapping(){} // RVA: 0x7FFAC2F83D80
        public void OnMuscleAdded(){} // RVA: 0x7FFAC2F83F80
        public void OnMuscleRemoved(){} // RVA: 0x7FFAC2F83FE0
        public void MoveTarget(){} // RVA: 0x7FFAC2F84030
        public void RotateTarget(){} // RVA: 0x7FFAC2F840C0
        public void GroundTarget(){} // RVA: 0x7FFAC2F84150
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC2F84170
        public void Boost(){} // RVA: 0x7FFAC2F845B0 | overloaded x3
        public void BoostImmunity(){} // RVA: 0x7FFAC2F848B0 | overloaded x3
        public void BoostImpulseMlp(){} // RVA: 0x7FFAC2F84B20 | overloaded x3
        public void Unpin(){} // RVA: 0x7FFAC2F84C60
        public void OnMuscleHitBehaviour(){} // RVA: 0x7FFAC2F84CE0
        public void OnMuscleCollisionBehaviour(){} // RVA: 0x7FFAC2F84E80
        public void GetImpulse(){} // RVA: 0x7FFAC2F85550
        public void UnPin(){} // RVA: 0x7FFAC2F857C0
        public void UnPinMuscle(){} // RVA: 0x7FFAC2F85930
        public void Activate(){} // RVA: 0x7FFAC2F85C10
        public void IsProne(){} // RVA: 0x7FFAC2F85CA0
        public void GetFalloff(){} // RVA: 0x7FFAC2F86060 | overloaded x2
        public void InGroup(){} // RVA: 0x7FFAC2F861F0
        public void GetProps(){} // RVA: 0x7FFAC2F862B0
        public void SetState(){} // RVA: 0x7FFAC2F863B0
        public void SetColliders(){} // RVA: 0x7FFAC2F87510 | overloaded x2
        public void OnMuscleDisconnected(){} // RVA: 0x7FFAC2F877E0
        public void OnMuscleReconnected(){} // RVA: 0x7FFAC2F877F0
        public void .ctor(){} // RVA: 0x7FFAC2F878A0
    }

    public class BehaviourTemplate : BehaviourBase
    {
        public RootMotion.Dynamics.SubBehaviourCOM centerOfMass; // 0x100
        public UnityEngine.LayerMask groundLayers; // 0x108
        public PuppetEvent onLoseBalance; // 0x110
        public float loseBalanceAngle; // 0x128

        // ── Methods ──
        public void OnInitiate(){} // RVA: 0x7FFAC2F87D60
        public void OnActivate(){} // RVA: 0x7FFAC2F21310
        public void OnReactivate(){} // RVA: 0x7FFAC2F21310
        public void OnDeactivate(){} // RVA: 0x7FFAC2F21310
        public void OnFixedUpdate(){} // RVA: 0x7FFAC2F87D90
        public void OnLateUpdate(){} // RVA: 0x7FFAC2F21310
        public void OnMuscleHitBehaviour(){} // RVA: 0x7FFAC2F87DE0
        public void OnMuscleCollisionBehaviour(){} // RVA: 0x7FFAC2F87DE0
        public void .ctor(){} // RVA: 0x7FFAC2F87E30
    }

    public class BipedRagdollCreator : RagdollCreator
    {
        public bool canBuild; // 0x20
        public RootMotion.Dynamics.BipedRagdollReferences references; // 0x28
        public Options options; // 0xB0

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void OpenTutorial(){} // RVA: 0x7FFAC2F21310
        public void AutodetectOptions(){} // RVA: 0x7FFAC2FC52F0
        public void Create(){} // RVA: 0x7FFAC2FC5810
        public void CreateColliders(){} // RVA: 0x7FFAC2FC5A90
        public void CreateHandCollider(){} // RVA: 0x7FFAC2FC7EB0
        public void CreateFootCollider(){} // RVA: 0x7FFAC2FC85D0
        public void GetChildCentroid(){} // RVA: 0x7FFAC2FC9100
        public void MassDistribution(){} // RVA: 0x7FFAC2FC93A0
        public void CreateJoints(){} // RVA: 0x7FFAC2FC9EA0
        public void CreateLimbJoints(){} // RVA: 0x7FFAC2FCB100
        public void ClearBipedRagdoll(){} // RVA: 0x7FFAC2FCC200
        public void IsClear(){} // RVA: 0x7FFAC2FCC260
        public void GetUpperArmToHeadCentroid(){} // RVA: 0x7FFAC2FCC3C0
        public void GetUpperArmCentroid(){} // RVA: 0x7FFAC2FCC520
        public void .ctor(){} // RVA: 0x7FFAC2FCC660
    }

    public class BipedRagdollReferences : ValueType
    {
        public UnityEngine.Transform root; // 0x10
        public UnityEngine.Transform hips; // 0x18
        public UnityEngine.Transform spine; // 0x20
        public UnityEngine.Transform chest; // 0x28
        public UnityEngine.Transform head; // 0x30
        public UnityEngine.Transform leftUpperLeg; // 0x38
        public UnityEngine.Transform leftLowerLeg; // 0x40
        public UnityEngine.Transform leftFoot; // 0x48
        public UnityEngine.Transform rightUpperLeg; // 0x50
        public UnityEngine.Transform rightLowerLeg; // 0x58
        public UnityEngine.Transform rightFoot; // 0x60
        public UnityEngine.Transform leftUpperArm; // 0x68
        public UnityEngine.Transform leftLowerArm; // 0x70
        public UnityEngine.Transform leftHand; // 0x78
        public UnityEngine.Transform rightUpperArm; // 0x80
        public UnityEngine.Transform rightLowerArm; // 0x88
        public UnityEngine.Transform rightHand; // 0x90

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAC2FCC760
        public void IsChildRecursive(){} // RVA: 0x7FFAC2FCD540
        public void IsEmpty(){} // RVA: 0x7FFAC2FCD7F0
        public void Contains(){} // RVA: 0x7FFAC2FCE090
        public void GetRagdollTransforms(){} // RVA: 0x7FFAC2FCECF0
        public void FromAvatar(){} // RVA: 0x7FFAC2FCF170
        public void FromBipedReferences(){} // RVA: 0x7FFAC2FCF8C0
    }

    public class Booster : Object
    {
        public bool fullBody; // 0x10
        public UnityEngine.ConfigurableJoint[] muscles; // 0x18
        public 0x6B1BDBA8[] groups; // 0x20
        public float immunity; // 0x28
        public float impulseMlp; // 0x2C
        public float boostParents; // 0x30
        public float boostChildren; // 0x34
        public float delay; // 0x38

        // ── Methods ──
        public void Boost(){} // RVA: 0x7FFAC2F8BA70
        public void .ctor(){} // RVA: 0x7FFAC2F8BE70
    }

    public class JointBreakBroadcaster : MonoBehaviour
    {
        public RootMotion.Dynamics.PuppetMaster puppetMaster; // 0x20
        public int muscleIndex; // 0x28

        // ── Methods ──
        public void OnJointBreak(){} // RVA: 0x7FFAC2F8BF90
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class JointConverter : Object
    {
        // ── Methods ──
        public void ToConfigurable(){} // RVA: 0x7FFAC2FCFEA0
        public void HingeToConfigurable(){} // RVA: 0x7FFAC2FD0270
        public void FixedToConfigurable(){} // RVA: 0x7FFAC2FD0AA0
        public void SpringToConfigurable(){} // RVA: 0x7FFAC2FD0DD0
        public void CharacterToConfigurable(){} // RVA: 0x7FFAC2FD1220
        public void ConvertJoint(){} // RVA: 0x7FFAC2FD1BF0
        public void ConvertToHighSoftJointLimit(){} // RVA: 0x7FFAC2FD2180
        public void ConvertToLowSoftJointLimit(){} // RVA: 0x7FFAC2FD21B0
        public void ConvertToSoftJointLimitSpring(){} // RVA: 0x7FFAC2FD21D0
        public void CopyLimit(){} // RVA: 0x7FFAC2FD2200
        public void CopyLimitSpring(){} // RVA: 0x7FFAC2FD2220
    }

    public class Muscle : Object
    {
        public string transform; // 0x10
        public UnityEngine.ConfigurableJoint rigidbody; // 0x18
        public UnityEngine.Transform connectedBodyTarget; // 0x20
        public Props targetAnimatedPosition; // 0x28
        public State targetAnimatedWorldRotation; // 0x30
        public int[] colliders; // 0x70
        public int[] targetVelocity; // 0x78
        public bool[] additionalRigidbody; // 0x80
        public int[] targetRotationRelative; // 0x88
        public RootMotion.Dynamics.MuscleCollisionBroadcaster rebuildConnectedBody; // 0x90
        public RootMotion.Dynamics.JointBreakBroadcaster rebuildTargetParent; // 0x98
        public UnityEngine.Vector3 defaultTargetPosRelToMuscle; // 0xA0
        public UnityEngine.Transform defaultTargetRotRelToMuscle; // 0xB0
        public UnityEngine.Rigidbody defaultMuscleRotRelToTarget; // 0xB8
        public UnityEngine.Transform localRotation; // 0xC0
        public UnityEngine.Vector3 parentRotation; // 0xC8
        public UnityEngine.Quaternion targetParentRotation; // 0xD4
        public UnityEngine.Vector3 targetLocalRotation; // 0xE4
        public UnityEngine.Rigidbody <additionalRigidbody>k__BackingField; // 0xF0
        public UnityEngine.ConfigurableJoint additionalPin; // 0xF8
        public UnityEngine.Transform additionalPinTarget; // 0x100
        public float additionalPinWeight; // 0x108
        public UnityEngine.Vector3 mappedVelocity; // 0x10C
        public UnityEngine.Vector3 mappedAngularVelocity; // 0x118
        public bool isPropMuscle; // 0x124
        public int index; // 0x128
        public UnityEngine.Quaternion <targetRotationRelative>k__BackingField; // 0x12C
        public UnityEngine.Rigidbody <rebuildConnectedBody>k__BackingField; // 0x140
        public UnityEngine.Transform <rebuildTargetParent>k__BackingField; // 0x148
        public UnityEngine.Vector3 <defaultTargetPosRelToMuscle>k__BackingField; // 0x150
        public UnityEngine.Quaternion <defaultTargetRotRelToMuscle>k__BackingField; // 0x15C
        public UnityEngine.Quaternion <defaultMuscleRotRelToTarget>k__BackingField; // 0x16C
        public UnityEngine.Transform rebuildParent; // 0x180
        public UnityEngine.Vector3 rebuildPosition; // 0x188
        public UnityEngine.Quaternion rebuildRotation; // 0x194
        public UnityEngine.Vector3 rebuildTargetPosition; // 0x1A4
        public UnityEngine.Quaternion rebuildTargetRotation; // 0x1B0
        public 0x6B2A02C8 rebuildAngularXMotion; // 0x1C0
        public 0x6B2A02C8 rebuildAngularYMotion; // 0x1C4
        public 0x6B2A02C8 rebuildAngularZMotion; // 0x1C8
        public UnityEngine.Vector3 targetMappedPosition; // 0x1CC
        public UnityEngine.Quaternion targetMappedRotation; // 0x1D8
        public UnityEngine.Vector3 targetSampledPosition; // 0x1E8
        public UnityEngine.Quaternion targetSampledRotation; // 0x1F4
        public UnityEngine.JointDrive slerpDrive; // 0x204
        public float lastJointDriveRotationWeight; // 0x214
        public float lastRotationDamper; // 0x218
        public UnityEngine.Vector3 defaultPosition; // 0x21C
        public UnityEngine.Vector3 defaultTargetLocalPosition; // 0x228
        public UnityEngine.Vector3 lastMappedPosition; // 0x234
        public UnityEngine.Quaternion defaultLocalRotation; // 0x240
        public UnityEngine.Quaternion localRotationConvert; // 0x250
        public UnityEngine.Quaternion toParentSpace; // 0x260
        public UnityEngine.Quaternion toJointSpaceInverse; // 0x270
        public UnityEngine.Quaternion toJointSpaceDefault; // 0x280
        public UnityEngine.Quaternion targetAnimatedRotation; // 0x290
        public UnityEngine.Quaternion defaultRotation; // 0x2A0
        public UnityEngine.Quaternion rotationRelativeToTarget; // 0x2B0
        public UnityEngine.Quaternion defaultTargetLocalRotation; // 0x2C0
        public UnityEngine.Quaternion lastMappedRotation; // 0x2D0
        public UnityEngine.Transform targetParent; // 0x2E0
        public UnityEngine.Transform connectedBodyTransform; // 0x2E8
        public 0x6B2A02C8 angularXMotionDefault; // 0x2F0
        public 0x6B2A02C8 angularYMotionDefault; // 0x2F4
        public 0x6B2A02C8 angularZMotionDefault; // 0x2F8
        public bool directTargetParent; // 0x2FC
        public bool initiated; // 0x2FD
        public UnityEngine.Collider[] _colliders; // 0x300
        public float lastReadTime; // 0x308
        public float lastWriteTime; // 0x30C
        public bool[] disabledColliders; // 0x310
        public TargetChild[] targetChildren; // 0x318
        public UnityEngine.Vector3 additionalTargetVelocity; // 0x320
        public UnityEngine.Vector3 targetAnimatedCenterOfMass; // 0x32C
        public UnityEngine.Vector3 additionalPinTargetAnimatedCenterOfMass; // 0x338
        public UnityEngine.Quaternion defaultTargetRotRelToMuscleInverse; // 0x344

        // ── Methods ──
        public void get_transform(){} // RVA: 0x7FFAC2F8C040
        public void set_transform(){} // RVA: 0x7FFAC2F8C050
        public void get_rigidbody(){} // RVA: 0x7FFAC2F8C0B0
        public void set_rigidbody(){} // RVA: 0x7FFAC2F8C0C0
        public void get_connectedBodyTarget(){} // RVA: 0x7FFAC2F8C120
        public void set_connectedBodyTarget(){} // RVA: 0x7FFAC2F8C130
        public void get_targetAnimatedPosition(){} // RVA: 0x7FFAC2F8C190
        public void set_targetAnimatedPosition(){} // RVA: 0x7FFAC2F8C1B0
        public void get_targetAnimatedWorldRotation(){} // RVA: 0x7FFAC2F8C1D0
        public void set_targetAnimatedWorldRotation(){} // RVA: 0x7FFAC2F8C1E0
        public void get_colliders(){} // RVA: 0x7FFAC2F8C1F0
        public void set_colliders(){} // RVA: 0x7FFAC2F8C200
        public void get_targetVelocity(){} // RVA: 0x7FFAC2F8C260
        public void set_targetVelocity(){} // RVA: 0x7FFAC2F8C280
        public void get_additionalRigidbody(){} // RVA: 0x7FFAC2F8C2A0
        public void set_additionalRigidbody(){} // RVA: 0x7FFAC2F8C2B0
        public void get_targetRotationRelative(){} // RVA: 0x7FFAC2F8C310
        public void set_targetRotationRelative(){} // RVA: 0x7FFAC2F8C320
        public void IsValid(){} // RVA: 0x7FFAC2F8C330
        public void get_rebuildConnectedBody(){} // RVA: 0x7FFAC2F8C5F0
        public void set_rebuildConnectedBody(){} // RVA: 0x7FFAC2F8C600
        public void get_rebuildTargetParent(){} // RVA: 0x7FFAC2F8C660
        public void set_rebuildTargetParent(){} // RVA: 0x7FFAC2F8C670
        public void get_defaultTargetPosRelToMuscle(){} // RVA: 0x7FFAC2F8C6D0
        public void set_defaultTargetPosRelToMuscle(){} // RVA: 0x7FFAC2F8C6F0
        public void get_defaultTargetRotRelToMuscle(){} // RVA: 0x7FFAC2F8C710
        public void set_defaultTargetRotRelToMuscle(){} // RVA: 0x7FFAC2F8C720
        public void get_defaultMuscleRotRelToTarget(){} // RVA: 0x7FFAC2F8C730
        public void set_defaultMuscleRotRelToTarget(){} // RVA: 0x7FFAC2F8C740
        public void Rebuild(){} // RVA: 0x7FFAC2F8C750
        public void Initiate(){} // RVA: 0x7FFAC2F8CBC0
        public void InitiateAdditionalPin(){} // RVA: 0x7FFAC2F8F810
        public void UpdateColliders(){} // RVA: 0x7FFAC2F8FB50
        public void DisableColliders(){} // RVA: 0x7FFAC2F8FE80
        public void EnableColliders(){} // RVA: 0x7FFAC2F90030
        public void AddColliders(){} // RVA: 0x7FFAC2F900E0
        public void AddCompoundColliders(){} // RVA: 0x7FFAC2F903C0
        public void IgnoreInternalCollisions(){} // RVA: 0x7FFAC2F905B0
        public void ResetInternalCollisions(){} // RVA: 0x7FFAC2F90880
        public void ForceIgnore(){} // RVA: 0x7FFAC2F90B90
        public void IgnoreAngularLimits(){} // RVA: 0x7FFAC2F90F60
        public void FixTargetTransforms(){} // RVA: 0x7FFAC2F910D0
        public void Reset(){} // RVA: 0x7FFAC2F911C0
        public void MoveToTarget(){} // RVA: 0x7FFAC2F917D0
        public void SetKinematic(){} // RVA: 0x7FFAC2F91EA0
        public void Read(){} // RVA: 0x7FFAC2F92090
        public void ClearVelocities(){} // RVA: 0x7FFAC2F928F0
        public void UpdateAnchor(){} // RVA: 0x7FFAC2F92DF0
        public void Update(){} // RVA: 0x7FFAC2F93440
        public void StoreTargetMappedPosition(){} // RVA: 0x7FFAC2F93710
        public void StoreTargetMappedRotation(){} // RVA: 0x7FFAC2F937A0
        public void Map(){} // RVA: 0x7FFAC2F93820
        public void ResetTargetLocalPosition(){} // RVA: 0x7FFAC2F94440
        public void CalculateMappedVelocity(){} // RVA: 0x7FFAC2F944C0
        public void MapDisconnected(){} // RVA: 0x7FFAC2F948D0
        public void Pin(){} // RVA: 0x7FFAC2F954E0 | overloaded x2
        public void MuscleRotation(){} // RVA: 0x7FFAC2F956F0
        public void SetMuscleRotation(){} // RVA: 0x7FFAC2F959D0
        public void get_localRotation(){} // RVA: 0x7FFAC2F95C70
        public void get_parentRotation(){} // RVA: 0x7FFAC2F95EE0
        public void get_targetParentRotation(){} // RVA: 0x7FFAC2F962A0
        public void get_targetLocalRotation(){} // RVA: 0x7FFAC2F96420
        public void LocalToJointSpace(){} // RVA: 0x7FFAC2F96770
        public void InverseTransformPointUnscaled(){} // RVA: 0x7FFAC2F96A30
        public void .ctor(){} // RVA: 0x7FFAC2F96CB0
    }

    public class MuscleCollision : ValueType
    {
        public int muscleIndex; // 0x10
        public UnityEngine.Collision collision; // 0x18
        public bool isStay; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F97EF0
    }

    public class MuscleCollisionBroadcaster : MonoBehaviour
    {
        public RootMotion.Dynamics.PuppetMaster puppetMaster; // 0x20
        public int muscleIndex; // 0x28
        public string onMuscleHit;
        public string onMuscleCollision;
        public string onMuscleCollisionExit;
        public RootMotion.Dynamics.MuscleCollisionBroadcaster otherBroadcaster; // 0x30

        // ── Methods ──
        public void Hit(){} // RVA: 0x7FFAC2F97F80
        public void OnCollisionEnter(){} // RVA: 0x7FFAC2F98210
        public void OnCollisionStay(){} // RVA: 0x7FFAC2F98840
        public void OnCollisionExit(){} // RVA: 0x7FFAC2F98CD0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class MuscleHit : ValueType
    {
        public int muscleIndex; // 0x10
        public float unPin; // 0x14
        public UnityEngine.Vector3 force; // 0x18
        public UnityEngine.Vector3 position; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F97F50
    }

    public class PhysXTools : Object
    {
        // ── Methods ──
        public void Predict(){} // RVA: 0x7FFAC2F99720 | overloaded x3
        public void GetCenterOfMass(){} // RVA: 0x7FFAC2F99F50 | overloaded x2
        public void GetCenterOfMassVelocity(){} // RVA: 0x7FFAC2F9A1F0
        public void DivByInertia(){} // RVA: 0x7FFAC2F9A490
        public void ScaleByInertia(){} // RVA: 0x7FFAC2F9A850
        public void GetFromToAcceleration(){} // RVA: 0x7FFAC2F9AC10
        public void GetAngularAcceleration(){} // RVA: 0x7FFAC2F9AE20
        public void AddFromToTorque(){} // RVA: 0x7FFAC2F9BBA0 | overloaded x2
        public void AddFromToForce(){} // RVA: 0x7FFAC2F9C030
        public void GetLinearAcceleration(){} // RVA: 0x7FFAC2F9C350
        public void ToJointSpace(){} // RVA: 0x7FFAC2F9C410
        public void CalculateInertiaTensorCuboid(){} // RVA: 0x7FFAC2F9C670
        public void Div(){} // RVA: 0x7FFAC2F9C6C0
    }

    public class PressureSensor : MonoBehaviour
    {
        public bool center; // 0x20
        public UnityEngine.LayerMask inContact; // 0x24
        public UnityEngine.Vector3 bottom; // 0x28
        public bool r; // 0x34
        public UnityEngine.Vector3 <bottom>k__BackingField; // 0x38
        public UnityEngine.Rigidbody <r>k__BackingField; // 0x48
        public bool fixedFrame; // 0x50
        public UnityEngine.Vector3 P; // 0x54
        public int count; // 0x60

        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFAC2F9C700
        public void set_center(){} // RVA: 0x7FFAC2F9C720
        public void get_inContact(){} // RVA: 0x7FFAC2F57C20
        public void set_inContact(){} // RVA: 0x7FFAC2F5BAC0
        public void get_bottom(){} // RVA: 0x7FFAC2F87F40
        public void set_bottom(){} // RVA: 0x7FFAC2F87F60
        public void get_r(){} // RVA: 0x7FFAC2F9C730
        public void set_r(){} // RVA: 0x7FFAC2F9C740
        public void Awake(){} // RVA: 0x7FFAC2F9C7A0
        public void OnCollisionEnter(){} // RVA: 0x7FFAC2F9C8F0
        public void OnCollisionStay(){} // RVA: 0x7FFAC2F9C8F0
        public void OnCollisionExit(){} // RVA: 0x7FFAC2F9C900
        public void FixedUpdate(){} // RVA: 0x7FFAC2F9C910
        public void LateUpdate(){} // RVA: 0x7FFAC2F9C9D0
        public void ProcessCollision(){} // RVA: 0x7FFAC2F9CA20
        public void OnDrawGizmos(){} // RVA: 0x7FFAC2F9CC10
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Prop : MonoBehaviour
    {
        public int isPickedUp; // 0x20
        public UnityEngine.ConfigurableJoint propRoot; // 0x28
        public Props initiated; // 0x30
        public bool forceLayers; // 0x38
        public UnityEngine.ConfigurableJoint additionalPin; // 0x40
        public UnityEngine.Transform additionalPinTarget; // 0x48
        public float additionalPinWeight; // 0x50
        public UnityEngine.PhysicMaterial pickedUpMaterial; // 0x58
        public UnityEngine.PhysicMaterial droppedMaterial; // 0x60
        public RootMotion.Dynamics.PropRoot <propRoot>k__BackingField; // 0x68
        public bool <initiated>k__BackingField; // 0x70
        public 0x6B2A02C8 xMotion; // 0x74
        public 0x6B2A02C8 yMotion; // 0x78
        public 0x6B2A02C8 zMotion; // 0x7C
        public 0x6B2A02C8 angularXMotion; // 0x80
        public 0x6B2A02C8 angularYMotion; // 0x84
        public 0x6B2A02C8 angularZMotion; // 0x88
        public UnityEngine.Collider[] colliders; // 0x90

        // ── Methods ──
        public void get_isPickedUp(){} // RVA: 0x7FFAC2F9CC80
        public void get_propRoot(){} // RVA: 0x7FFAC2F9CD50
        public void set_propRoot(){} // RVA: 0x7FFAC2F9CD60
        public void PickUp(){} // RVA: 0x7FFAC2F9CDC0
        public void Drop(){} // RVA: 0x7FFAC2F9D290
        public void StartPickedUp(){} // RVA: 0x7FFAC2F9CD60
        public void get_initiated(){} // RVA: 0x7FFAC2F9D320
        public void set_initiated(){} // RVA: 0x7FFAC2F9D330
        public void OnPickUp(){} // RVA: 0x7FFAC2F21310
        public void OnDrop(){} // RVA: 0x7FFAC2F21310
        public void OnStart(){} // RVA: 0x7FFAC2F21310
        public void Start(){} // RVA: 0x7FFAC2F9D340
        public void ReleaseJoint(){} // RVA: 0x7FFAC2F9D9A0
        public void SetMaterial(){} // RVA: 0x7FFAC2F9DD40
        public void OnDrawGizmos(){} // RVA: 0x7FFAC2F9DEB0
        public void .ctor(){} // RVA: 0x7FFAC2F9E4F0
    }

    public class PropMuscle : MonoBehaviour
    {
        public RootMotion.Dynamics.PuppetMaster muscle; // 0x20
        public RootMotion.Dynamics.PuppetMasterProp activeProp; // 0x28
        public UnityEngine.Vector3 additionalPinOffset; // 0x30
        public RootMotion.Dynamics.PuppetMasterProp <activeProp>k__BackingField; // 0x40
        public PropDelegate OnPickUpProp; // 0x48
        public PropDelegate OnDropProp; // 0x50
        public RootMotion.Dynamics.Muscle _muscle; // 0x58
        public RootMotion.Dynamics.PuppetMasterProp lastProp; // 0x60
        public UnityEngine.Vector3 targetDefaultLocalPos; // 0x68
        public UnityEngine.Vector3 lastAdditionalPinOffset; // 0x74

        // ── Methods ──
        public void get_muscle(){} // RVA: 0x7FFAC2F9E650
        public void get_activeProp(){} // RVA: 0x7FFAC2F9E740
        public void set_activeProp(){} // RVA: 0x7FFAC2F49200
        public void AddAdditionalPin(){} // RVA: 0x7FFAC2F9E750
        public void RemoveAdditionalPin(){} // RVA: 0x7FFAC2F9F310
        public void OnInitiate(){} // RVA: 0x7FFAC2F9F6A0
        public void TakeOver(){} // RVA: 0x7FFAC2F9F860
        public void OnUpdate(){} // RVA: 0x7FFAC2F9F9B0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC2FA08A0
        public void .ctor(){} // RVA: 0x7FFAC2FA1100
    }

    public class PropRoot : MonoBehaviour
    {
        public RootMotion.Dynamics.PuppetMaster puppetMaster; // 0x20
        public UnityEngine.Rigidbody connectTo; // 0x28
        public RootMotion.Dynamics.Prop currentProp; // 0x30
        public RootMotion.Dynamics.Prop lastProp; // 0x38
        public bool fixedUpdateCalled; // 0x40

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void DropImmediate(){} // RVA: 0x7FFAC2FA1310
        public void Awake(){} // RVA: 0x7FFAC2FA14E0
        public void Update(){} // RVA: 0x7FFAC2FA16A0
        public void FixedUpdate(){} // RVA: 0x7FFAC2FA1950
        public void AttachProp(){} // RVA: 0x7FFAC2FA1E50
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class PropTemplate : Prop
    {
        // ── Methods ──
        public void OnStart(){} // RVA: 0x7FFAC2F21310
        public void OnPickUp(){} // RVA: 0x7FFAC2F21310
        public void OnDrop(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F9E4F0
    }

    public class PuppetMaster : MonoBehaviour
    {
        public RootMotion.Dynamics.PuppetMasterHumanoidConfig targetAnimator; // 0x20
        public UnityEngine.Transform targetAnimation; // 0x28
        public 0x6B1BE288 behaviours; // 0x30
        public StateSettings isActive; // 0x34
        public 0x6B1BE128 initiated; // 0x48
        public float updateMode; // 0x4C
        public bool controlsAnimator; // 0x50
        public int isBlending; // 0x54
        public bool autoSimulate; // 0x58
        public float targetUpdateMode; // 0x5C
        public float isSwitchingMode; // 0x60
        public float isSwitchingState; // 0x64
        public float isKilling; // 0x68
        public float isAlive; // 0x6C
        public float isFrozen; // 0x70
        public float pinDistanceFalloff; // 0x74
        public bool angularPinning; // 0x78
        public bool updateJointAnchors; // 0x79
        public bool supportTranslationAnimation; // 0x7A
        public bool angularLimits; // 0x7B
        public bool internalCollisions; // 0x7C
        public RootMotion.Dynamics.Muscle[] muscles; // 0x80
        public RootMotion.Dynamics.PropMuscle[] propMuscles; // 0x88
        public UpdateDelegate OnPostInitiate; // 0x90
        public UpdateDelegate OnRead; // 0x98
        public UpdateDelegate OnWrite; // 0xA0
        public UpdateDelegate OnPostLateUpdate; // 0xA8
        public UpdateDelegate OnFixTransforms; // 0xB0
        public UpdateDelegate OnHierarchyChanged; // 0xB8
        public MuscleDelegate OnMuscleRemoved; // 0xC0
        public MuscleDelegate OnMuscleDisconnected; // 0xC8
        public MuscleDelegate OnMuscleReconnected; // 0xD0
        public UnityEngine.Animator _targetAnimator; // 0xD8
        public UnityEngine.Animation <targetAnimation>k__BackingField; // 0xE0
        public RootMotion.Dynamics.BehaviourBase[] <behaviours>k__BackingField; // 0xE8
        public bool <initiated>k__BackingField; // 0xF0
        public System.Collections.Generic.List`1<RootMotion.SolverManager> solvers; // 0xF8
        public bool manualInternalCollisionControl; // 0x100
        public bool manualAngularLimitControl; // 0x101
        public bool mapDisconnectedMuscles; // 0x102
        public bool internalCollisionsEnabled; // 0x103
        public bool angularLimitsEnabled; // 0x104
        public bool fixedFrame; // 0x105
        public int lastSolverIterationCount; // 0x108
        public bool isLegacy; // 0x10C
        public bool animatorDisabled; // 0x10D
        public bool awakeFailed; // 0x10E
        public bool interpolated; // 0x10F
        public bool freezeFlag; // 0x110
        public bool hasBeenDisabled; // 0x111
        public bool hierarchyIsFlat; // 0x112
        public bool teleport; // 0x113
        public UnityEngine.Vector3 teleportPosition; // 0x114
        public UnityEngine.Quaternion teleportRotation; // 0x120
        public bool teleportMoveToTarget; // 0x130
        public bool rebuildFlag; // 0x131
        public bool onPostRebuildFlag; // 0x132
        public bool[] disconnectMuscleFlags; // 0x138
        public 0x6B1BE5A0[] muscleDisconnectModes; // 0x140
        public bool[] disconnectDeactivateFlags; // 0x148
        public bool[] reconnectMuscleFlags; // 0x150
        public RootMotion.Dynamics.Muscle[] defaultMuscles; // 0x158
        public UnityEngine.Vector3 rebuildPelvisPos; // 0x160
        public UnityEngine.Quaternion rebuildPelvisRot; // 0x16C
        public bool readInFixedUpdate; // 0x17C
        public bool <isSwitchingMode>k__BackingField; // 0x17D
        public 0x6B1BE128 activeMode; // 0x180
        public 0x6B1BE128 lastMode; // 0x184
        public float mappingBlend; // 0x188
        public bool <isKilling>k__BackingField; // 0x18C
        public UpdateDelegate OnFreeze; // 0x190
        public UpdateDelegate OnUnfreeze; // 0x198
        public UpdateDelegate OnDeath; // 0x1A0
        public UpdateDelegate OnResurrection; // 0x1A8
        public 0x6B1BE288 activeState; // 0x1B0
        public 0x6B1BE288 lastState; // 0x1B4
        public bool angularLimitsEnabledOnKill; // 0x1B8
        public bool internalCollisionsEnabledOnKill; // 0x1B9
        public bool animationDisabledbyStates; // 0x1BA
        public bool storeTargetMappedState; // 0x1BB
        public bool targetMappedStateStored; // 0x1BC
        public bool targetMappedStateSampled; // 0x1BD
        public bool sampleTargetMappedState; // 0x1BE
        public bool hasProp; // 0x1BF

        // ── Methods ──
        public void OpenUserManualSetup(){} // RVA: 0x7FFAC2F21310
        public void OpenUserManualComponent(){} // RVA: 0x7FFAC2F21310
        public void OpenUserManualPerformance(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void OpenSetupTutorial(){} // RVA: 0x7FFAC2F21310
        public void OpenComponentTutorial(){} // RVA: 0x7FFAC2F21310
        public void ResetStateSettings(){} // RVA: 0x7FFAC2FA24C0
        public void get_targetAnimator(){} // RVA: 0x7FFAC2FA24F0
        public void set_targetAnimator(){} // RVA: 0x7FFAC2FA28A0
        public void get_targetAnimation(){} // RVA: 0x7FFAC2FA2900
        public void set_targetAnimation(){} // RVA: 0x7FFAC2FA2910
        public void get_behaviours(){} // RVA: 0x7FFAC2FA2970
        public void set_behaviours(){} // RVA: 0x7FFAC2FA2980
        public void get_isActive(){} // RVA: 0x7FFAC2FA29E0
        public void get_initiated(){} // RVA: 0x7FFAC2FA2AD0
        public void set_initiated(){} // RVA: 0x7FFAC2FA2AE0
        public void get_updateMode(){} // RVA: 0x7FFAC2FA2AF0
        public void get_controlsAnimator(){} // RVA: 0x7FFAC2FA2B30
        public void get_isBlending(){} // RVA: 0x7FFAC2FA2BE0
        public void Teleport(){} // RVA: 0x7FFAC2FA2C00
        public void SetInternalCollisionsManual(){} // RVA: 0x7FFAC2FA2C40
        public void SetAngularLimitsManual(){} // RVA: 0x7FFAC2FA2D60
        public void get_autoSimulate(){} // RVA: 0x7FFAC2FA2E00
        public void OnDisable(){} // RVA: 0x7FFAC2FA2E90
        public void OnEnable(){} // RVA: 0x7FFAC2FA3020
        public void Awake(){} // RVA: 0x7FFAC2FA39E0
        public void Start(){} // RVA: 0x7FFAC2FA3A20
        public void FindTargetRootRecursive(){} // RVA: 0x7FFAC2FA3B00
        public void Initiate(){} // RVA: 0x7FFAC2FA3FB0
        public void ActivateBehaviour(){} // RVA: 0x7FFAC2FA4F70
        public void OnDestroy(){} // RVA: 0x7FFAC2FA5190
        public void IsInterpolated(){} // RVA: 0x7FFAC2FA52C0
        public void OnRebuild(){} // RVA: 0x7FFAC2FA53A0
        public void OnPreSimulate(){} // RVA: 0x7FFAC2FA56E0
        public void OnPostSimulate(){} // RVA: 0x7FFAC2FA5EB0
        public void FixedUpdate(){} // RVA: 0x7FFAC2FA6330
        public void Update(){} // RVA: 0x7FFAC2FA6C60
        public void LateUpdate(){} // RVA: 0x7FFAC2FA6DF0
        public void OnLateUpdate(){} // RVA: 0x7FFAC2FA70C0
        public void MoveToTarget(){} // RVA: 0x7FFAC2FA7460
        public void Read(){} // RVA: 0x7FFAC2FA7650
        public void FixTargetTransforms(){} // RVA: 0x7FFAC2FA8EE0
        public void get_targetUpdateMode(){} // RVA: 0x7FFAC2FA9120
        public void VisualizeTargetPose(){} // RVA: 0x7FFAC2FA9360
        public void VisualizeHierarchy(){} // RVA: 0x7FFAC2FA93D0
        public void FlagInternalCollisionsForUpdate(){} // RVA: 0x7FFAC2FA9710
        public void UpdateInternalCollisions(){} // RVA: 0x7FFAC2FA98A0 | overloaded x2
        public void IgnoreInternalCollisions(){} // RVA: 0x7FFAC2FA9A00 | overloaded x2
        public void ResetInternalCollisions(){} // RVA: 0x7FFAC2FA9B40 | overloaded x2
        public void FlagAngularLimitsForUpdate(){} // RVA: 0x7FFAC2FA9BD0
        public void UpdateAngularLimits(){} // RVA: 0x7FFAC2FA9BF0
        public void AddPropMuscle(){} // RVA: 0x7FFAC2FA9CA0
        public void IsDisconnecting(){} // RVA: 0x7FFAC2FAA810
        public void IsReconnecting(){} // RVA: 0x7FFAC2FAA850
        public void DisconnectMuscleRecursive(){} // RVA: 0x7FFAC2FAA890
        public void ReconnectMuscleRecursive(){} // RVA: 0x7FFAC2FAAA10
        public void AddMuscle(){} // RVA: 0x7FFAC2FAAD40
        public void Rebuild(){} // RVA: 0x7FFAC2FAC1B0
        public void RemoveMuscleRecursive(){} // RVA: 0x7FFAC2FAC1C0
        public void ReplaceMuscle(){} // RVA: 0x7FFAC2FADB70
        public void SetMuscles(){} // RVA: 0x7FFAC2FADC30
        public void DisableMuscleRecursive(){} // RVA: 0x7FFAC2FADCF0
        public void EnableMuscleRecursive(){} // RVA: 0x7FFAC2FADDB0
        public void FlattenHierarchy(){} // RVA: 0x7FFAC2FADE70
        public void TreeHierarchy(){} // RVA: 0x7FFAC2FADFE0
        public void FixMusclePositions(){} // RVA: 0x7FFAC2FAE220
        public void FixMusclePositionsAndRotations(){} // RVA: 0x7FFAC2FAE4D0
        public void HierarchyIsFlat(){} // RVA: 0x7FFAC2FAE870
        public void GetHighestDisconnectedParentIndex(){} // RVA: 0x7FFAC2FAEAE0
        public void ProcessDisconnects(){} // RVA: 0x7FFAC2FAEB70
        public void ProcessReconnects(){} // RVA: 0x7FFAC2FAECB0
        public void OnDisconnectMuscleRecursive(){} // RVA: 0x7FFAC2FAED80
        public void DisconnectMuscle(){} // RVA: 0x7FFAC2FAF2A0
        public void OnReconnectMuscleRecursive(){} // RVA: 0x7FFAC2FB0350
        public void ReconnectMuscle(){} // RVA: 0x7FFAC2FB0510
        public void AddIndexesRecursive(){} // RVA: 0x7FFAC2FB0F40
        public void DisconnectJoint(){} // RVA: 0x7FFAC2FB10E0
        public void KillJoint(){} // RVA: 0x7FFAC2FB13C0
        public void SwitchToActiveMode(){} // RVA: 0x7FFAC2FB14E0
        public void SwitchToKinematicMode(){} // RVA: 0x7FFAC2FB14F0
        public void SwitchToDisabledMode(){} // RVA: 0x7FFAC2FB1500
        public void get_isSwitchingMode(){} // RVA: 0x7FFAC2FB1510
        public void set_isSwitchingMode(){} // RVA: 0x7FFAC2FB1520
        public void DisableImmediately(){} // RVA: 0x7FFAC2FB1530
        public void SwitchModes(){} // RVA: 0x7FFAC2FB1660
        public void DisabledToKinematic(){} // RVA: 0x7FFAC2FB1BD0
        public void DisabledToActive(){} // RVA: 0x7FFAC2FB1D40
        public void KinematicToDisabled(){} // RVA: 0x7FFAC2FB1DE0
        public void KinematicToActive(){} // RVA: 0x7FFAC2FB1E80
        public void ActiveToDisabled(){} // RVA: 0x7FFAC2FB1F20
        public void ActiveToKinematic(){} // RVA: 0x7FFAC2FB1FC0
        public void SetMuscleWeights(){} // RVA: 0x7FFAC2FB2650 | overloaded x4
        public void SetMuscleWeightsRecursive(){} // RVA: 0x7FFAC2FB25C0 | overloaded x3
        public void GetMuscle(){} // RVA: 0x7FFAC2FB2930 | overloaded x3
        public void ContainsJoint(){} // RVA: 0x7FFAC2FB2980
        public void GetMuscleIndex(){} // RVA: 0x7FFAC2FB3530 | overloaded x4
        public void SetUp(){} // RVA: 0x7FFAC2FB3A70 | overloaded x2
        public void SetUpTo(){} // RVA: 0x7FFAC2FB3D10
        public void RemoveRagdollComponents(){} // RVA: 0x7FFAC2FB5580
        public void SetUpMuscles(){} // RVA: 0x7FFAC2FB5DD0
        public void FindGroup(){} // RVA: 0x7FFAC2FB6A60
        public void RemoveUnnecessaryBones(){} // RVA: 0x7FFAC2FB77F0
        public void IsClothCollider(){} // RVA: 0x7FFAC2FB7E00
        public void get_isSwitchingState(){} // RVA: 0x7FFAC2FB84A0
        public void get_isKilling(){} // RVA: 0x7FFAC2FB84B0
        public void set_isKilling(){} // RVA: 0x7FFAC2FB84C0
        public void get_isAlive(){} // RVA: 0x7FFAC2FB84D0
        public void get_isFrozen(){} // RVA: 0x7FFAC2FB84E0
        public void Kill(){} // RVA: 0x7FFAC2FB8500 | overloaded x2
        public void Freeze(){} // RVA: 0x7FFAC2FB8530 | overloaded x2
        public void Resurrect(){} // RVA: 0x7FFAC2FB8550
        public void SwitchStates(){} // RVA: 0x7FFAC2FB8560
        public void AliveToDead(){} // RVA: 0x7FFAC2FB8860
        public void OnFreezeFlag(){} // RVA: 0x7FFAC2FB8910
        public void DeadToAlive(){} // RVA: 0x7FFAC2FB8FD0
        public void SetAnimationEnabled(){} // RVA: 0x7FFAC2FB9100
        public void DeadToFrozen(){} // RVA: 0x7FFAC2FB9330
        public void FrozenToAlive(){} // RVA: 0x7FFAC2FB9340
        public void FrozenToDead(){} // RVA: 0x7FFAC2FB96F0
        public void ActivateRagdoll(){} // RVA: 0x7FFAC2FB97E0
        public void CanFreeze(){} // RVA: 0x7FFAC2FB9B30
        public void SampleTargetMappedState(){} // RVA: 0x7FFAC2FB9C40
        public void FixTargetToSampledState(){} // RVA: 0x7FFAC2FB9D40
        public void StoreTargetMappedState(){} // RVA: 0x7FFAC2FBA270
        public void UpdateHierarchies(){} // RVA: 0x7FFAC2FBA350
        public void HasProp(){} // RVA: 0x7FFAC2FBA970
        public void UpdateBroadcasterMuscleIndexes(){} // RVA: 0x7FFAC2FBA9D0
        public void AssignParentAndChildIndexes(){} // RVA: 0x7FFAC2FBAC40
        public void AddToParentsRecursive(){} // RVA: 0x7FFAC2FBB1B0
        public void AddToChildrenRecursive(){} // RVA: 0x7FFAC2FBB420
        public void AssignKinshipDegrees(){} // RVA: 0x7FFAC2FBB760
        public void AssignKinshipsDownRecursive(){} // RVA: 0x7FFAC2FBB900
        public void AssignKinshipsUpRecursive(){} // RVA: 0x7FFAC2FBBB20
        public void GetMuscleIndexLowLevel(){} // RVA: 0x7FFAC2FBBF00
        public void IsValid(){} // RVA: 0x7FFAC2FBC0A0
        public void CheckMassVariation(){} // RVA: 0x7FFAC2FBCEE0
        public void CheckIfInitiated(){} // RVA: 0x7FFAC2FBD2B0
        public void .ctor(){} // RVA: 0x7FFAC2FBD330
    }

    public class PuppetMasterHumanoidConfig : ScriptableObject
    {
        public 0x6B1BE288 state; // 0x18
        public StateSettings stateSettings; // 0x1C
        public 0x6B1BE128 mode; // 0x30
        public float blendTime; // 0x34
        public bool fixTargetTransforms; // 0x38
        public int solverIterationCount; // 0x3C
        public bool visualizeTargetPose; // 0x40
        public float mappingWeight; // 0x44
        public float pinWeight; // 0x48
        public float muscleWeight; // 0x4C
        public float muscleSpring; // 0x50
        public float muscleDamper; // 0x54
        public float pinPow; // 0x58
        public float pinDistanceFalloff; // 0x5C
        public bool angularPinning; // 0x60
        public bool updateJointAnchors; // 0x61
        public bool supportTranslationAnimation; // 0x62
        public bool angularLimits; // 0x63
        public bool internalCollisions; // 0x64
        public HumanoidMuscle[] muscles; // 0x68

        // ── Methods ──
        public void ApplyTo(){} // RVA: 0x7FFAC2FBEA00
        public void GetMuscle(){} // RVA: 0x7FFAC2FBEF30
        public void .ctor(){} // RVA: 0x7FFAC2FBF140
    }

    public class PuppetMasterProp : MonoBehaviour
    {
        public UnityEngine.Transform isPickedUp; // 0x20
        public Props propMuscle; // 0x28
        public bool forceLayers; // 0x30
        public float mass; // 0x34
        public int propType; // 0x38
        public UnityEngine.PhysicMaterial pickedUpMaterial; // 0x40
        public UnityEngine.Vector3 additionalPinOffsetAdd; // 0x48
        public float additionalPinWeight; // 0x54
        public float additionalPinMass; // 0x58
        public bool <isPickedUp>k__BackingField; // 0x5C
        public RootMotion.Dynamics.Muscle <propMuscle>k__BackingField; // 0x60
        public int defaultLayer; // 0x68
        public UnityEngine.Transform defaultParent; // 0x70
        public UnityEngine.Collider[] colliders; // 0x78
        public UnityEngine.PhysicMaterial[] droppedMaterials; // 0x80
        public UnityEngine.Rigidbody r; // 0x88
        public float _mass; // 0x90
        public float _drag; // 0x94
        public float _angularDrag; // 0x98
        public bool _useGravity; // 0x9C
        public bool _isKinematic; // 0x9D
        public 0x6B29FF58 _interpolation; // 0xA0
        public 0x6B2A0270 _collisionDetectionMode; // 0xA4
        public 0x6B29FC98 _constraints; // 0xA8
        public UnityEngine.Collider[] emptyColliders; // 0xB0

        // ── Methods ──
        public void get_isPickedUp(){} // RVA: 0x7FFAC2FBF240
        public void set_isPickedUp(){} // RVA: 0x7FFAC2FBF250
        public void GetRigidbody(){} // RVA: 0x7FFAC2FBF260
        public void OnPickUp(){} // RVA: 0x7FFAC2F21310
        public void OnDrop(){} // RVA: 0x7FFAC2F21310
        public void get_propMuscle(){} // RVA: 0x7FFAC2FBF370
        public void set_propMuscle(){} // RVA: 0x7FFAC2FBF380
        public void PickUp(){} // RVA: 0x7FFAC2FBF3E0
        public void Drop(){} // RVA: 0x7FFAC2FBFD20
        public void Awake(){} // RVA: 0x7FFAC2FC0810
        public void Start(){} // RVA: 0x7FFAC2FC0C00
        public void Update(){} // RVA: 0x7FFAC2FC10D0
        public void RemoveRigidbody(){} // RVA: 0x7FFAC2FC12B0
        public void ReattachRigidbody(){} // RVA: 0x7FFAC2FC1690
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC2FC1A60
        public void .ctor(){} // RVA: 0x7FFAC2FC1EC0
    }

    public class PuppetMasterSettings : Singleton`1
    {
        public PuppetUpdateLimit currentlyActivePuppets; // 0x20
        public PuppetUpdateLimit currentlyKinematicPuppets; // 0x28
        public PuppetUpdateLimit currentlyDisabledPuppets; // 0x30
        public bool puppets; // 0x38
        public bool collisionExitMessages; // 0x39
        public float activePuppetCollisionThresholdMlp; // 0x3C
        public int <currentlyActivePuppets>k__BackingField; // 0x40
        public int <currentlyKinematicPuppets>k__BackingField; // 0x44
        public int <currentlyDisabledPuppets>k__BackingField; // 0x48
        public System.Collections.Generic.List`1<RootMotion.Dynamics.PuppetMaster> _puppets; // 0x50

        // ── Methods ──
        public void get_currentlyActivePuppets(){} // RVA: 0x7FFAC2FC2080
        public void set_currentlyActivePuppets(){} // RVA: 0x7FFAC2FC2090
        public void get_currentlyKinematicPuppets(){} // RVA: 0x7FFAC2FC20A0
        public void set_currentlyKinematicPuppets(){} // RVA: 0x7FFAC2FC20B0
        public void get_currentlyDisabledPuppets(){} // RVA: 0x7FFAC2FC20C0
        public void set_currentlyDisabledPuppets(){} // RVA: 0x7FFAC2FC20D0
        public void get_puppets(){} // RVA: 0x7FFAC2FC20E0
        public void Register(){} // RVA: 0x7FFAC2FC20F0
        public void Unregister(){} // RVA: 0x7FFAC2FC2200
        public void UpdateMoveToTarget(){} // RVA: 0x7FFAC2FC2260
        public void UpdateFree(){} // RVA: 0x7FFAC2FC2290
        public void UpdateFixed(){} // RVA: 0x7FFAC2FC22C0
        public void Update(){} // RVA: 0x7FFAC2FC22F0
        public void FixedUpdate(){} // RVA: 0x7FFAC2FC2530
        public void .ctor(){} // RVA: 0x7FFAC2FC2590
    }

    public class PuppetMasterTools : Object
    {
        // ── Methods ──
        public void PositionRagdoll(){} // RVA: 0x7FFAC2FC29C0
        public void RealignRagdoll(){} // RVA: 0x7FFAC2FC38B0
        public void DirectionIntToVector3(){} // RVA: 0x7FFAC2F68B70
        public void DirectionVector3ToInt(){} // RVA: 0x7FFAC2FC4FA0
    }

    public class RagdollCreator : MonoBehaviour
    {
        // ── Methods ──
        public void ClearAll(){} // RVA: 0x7FFAC2FD2240
        public void ClearTransform(){} // RVA: 0x7FFAC2FD25F0
        public void CreateCollider(){} // RVA: 0x7FFAC2FD3280 | overloaded x2
        public void GetScaleF(){} // RVA: 0x7FFAC2FD3940
        public void Abs(){} // RVA: 0x7FFAC2FD39D0
        public void Vector3Abs(){} // RVA: 0x7FFAC2FD3A20
        public void DirectionIntToVector3(){} // RVA: 0x7FFAC2F68B70
        public void DirectionToVector3(){} // RVA: 0x7FFAC2F68B70
        public void DirectionVector3ToInt(){} // RVA: 0x7FFAC2FC4FA0
        public void GetLocalOrthoDirection(){} // RVA: 0x7FFAC2FD3A50
        public void GetConnectedBody(){} // RVA: 0x7FFAC2FD3F30
        public void CreateJoint(){} // RVA: 0x7FFAC2FD42F0
        public void ToSoftJointLimit(){} // RVA: 0x7FFAC2FD55D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class RagdollEditor : MonoBehaviour
    {
        public UnityEngine.Rigidbody selectedRigidbody; // 0x20
        public UnityEngine.Collider selectedCollider; // 0x28
        public bool symmetry; // 0x30
        public 0x6B1BEC28 mode; // 0x34

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void OpenTutorial(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2FD5710
    }

    public class SubBehaviourBalancer : SubBehaviourBase
    {
        public UnityEngine.ConfigurableJoint joint; // 0x18
        public UnityEngine.Vector3 dir; // 0x20
        public UnityEngine.Vector3 dirVel; // 0x2C
        public UnityEngine.Vector3 cop; // 0x38
        public UnityEngine.Vector3 com; // 0x44
        public UnityEngine.Vector3 comV; // 0x50
        public Settings settings; // 0x60
        public UnityEngine.Rigidbody[] rigidbodies; // 0x68
        public UnityEngine.Transform[] copPoints; // 0x70
        public RootMotion.Dynamics.PressureSensor pressureSensor; // 0x78
        public UnityEngine.Rigidbody Ibody; // 0x80
        public UnityEngine.Vector3 I; // 0x88
        public UnityEngine.Quaternion toJointSpace; // 0x94

        // ── Methods ──
        public void get_joint(){} // RVA: 0x7FFAC2F247C0
        public void set_joint(){} // RVA: 0x7FFAC2F87E80
        public void get_dir(){} // RVA: 0x7FFAC2F87EE0
        public void set_dir(){} // RVA: 0x7FFAC2F87F00
        public void get_dirVel(){} // RVA: 0x7FFAC2F87F10
        public void set_dirVel(){} // RVA: 0x7FFAC2F87F30
        public void get_cop(){} // RVA: 0x7FFAC2F87F40
        public void set_cop(){} // RVA: 0x7FFAC2F87F60
        public void get_com(){} // RVA: 0x7FFAC2F87F70
        public void set_com(){} // RVA: 0x7FFAC2F87F90
        public void get_comV(){} // RVA: 0x7FFAC2F87FA0
        public void set_comV(){} // RVA: 0x7FFAC2F87FC0
        public void Initiate(){} // RVA: 0x7FFAC2F87FD0
        public void Solve(){} // RVA: 0x7FFAC2F883A0
        public void .ctor(){} // RVA: 0x7FFAC2F89250
    }

    public class SubBehaviourBase : Object
    {
        public RootMotion.Dynamics.BehaviourBase behaviour; // 0x10

        // ── Methods ──
        public void XZ(){} // RVA: 0x7FFAC2F893D0
        public void XYZ(){} // RVA: 0x7FFAC2F893F0
        public void Flatten(){} // RVA: 0x7FFAC2F89420
        public void SetY(){} // RVA: 0x7FFAC2F89440
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SubBehaviourCOM : SubBehaviourBase
    {
        public 0x6B1BDA48 position; // 0x18
        public float direction; // 0x1C
        public float angle; // 0x20
        public float velocity; // 0x24
        public float centerOfPressure; // 0x28
        public UnityEngine.Vector3 rotation; // 0x2C
        public UnityEngine.Vector3 inverseRotation; // 0x38
        public UnityEngine.Vector3 isGrounded; // 0x44
        public float lastGroundedTime; // 0x50
        public UnityEngine.Vector3 <velocity>k__BackingField; // 0x54
        public UnityEngine.Vector3 <centerOfPressure>k__BackingField; // 0x60
        public UnityEngine.Quaternion <rotation>k__BackingField; // 0x6C
        public UnityEngine.Quaternion <inverseRotation>k__BackingField; // 0x7C
        public bool <isGrounded>k__BackingField; // 0x8C
        public float <lastGroundedTime>k__BackingField; // 0x90
        public bool[] groundContacts; // 0x98
        public UnityEngine.Vector3[] groundContactPoints; // 0xA0
        public UnityEngine.LayerMask groundLayers; // 0xA8

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFAC2F87F40
        public void set_position(){} // RVA: 0x7FFAC2F87F60
        public void get_direction(){} // RVA: 0x7FFAC2F87F70
        public void set_direction(){} // RVA: 0x7FFAC2F87F90
        public void get_angle(){} // RVA: 0x7FFAC2F89460
        public void set_angle(){} // RVA: 0x7FFAC2F89470
        public void get_velocity(){} // RVA: 0x7FFAC2F89480
        public void set_velocity(){} // RVA: 0x7FFAC2F894A0
        public void get_centerOfPressure(){} // RVA: 0x7FFAC2F894B0
        public void set_centerOfPressure(){} // RVA: 0x7FFAC2F894D0
        public void get_rotation(){} // RVA: 0x7FFAC2F894E0
        public void set_rotation(){} // RVA: 0x7FFAC2F894F0
        public void get_inverseRotation(){} // RVA: 0x7FFAC2F89500
        public void set_inverseRotation(){} // RVA: 0x7FFAC2F89510
        public void get_isGrounded(){} // RVA: 0x7FFAC2F89520
        public void set_isGrounded(){} // RVA: 0x7FFAC2F89530
        public void get_lastGroundedTime(){} // RVA: 0x7FFAC2F89540
        public void set_lastGroundedTime(){} // RVA: 0x7FFAC2F89550
        public void Initiate(){} // RVA: 0x7FFAC2F89560
        public void OnHierarchyChanged(){} // RVA: 0x7FFAC2F89D20
        public void OnPreMuscleCollision(){} // RVA: 0x7FFAC2F89DD0
        public void OnPreMuscleCollisionExit(){} // RVA: 0x7FFAC2F8A090
        public void OnPreActivate(){} // RVA: 0x7FFAC2F8A1E0
        public void OnPreLateUpdate(){} // RVA: 0x7FFAC2F8A320
        public void OnPreDeactivate(){} // RVA: 0x7FFAC2F8ABE0
        public void GetCollisionCOP(){} // RVA: 0x7FFAC2F8AC30
        public void IsGrounded(){} // RVA: 0x7FFAC2F8AD90
        public void GetCenterOfMass(){} // RVA: 0x7FFAC2F8ADF0
        public void GetCenterOfMassVelocity(){} // RVA: 0x7FFAC2F8B080
        public void GetMomentum(){} // RVA: 0x7FFAC2F8B420
        public void GetCenterOfPressure(){} // RVA: 0x7FFAC2F8B6A0
        public void GetFeetCentroid(){} // RVA: 0x7FFAC2F8B800
        public void .ctor(){} // RVA: 0x7FFAC2F8BA50
    }

    public class Weight : Object
    {
        public 0x6B1BE808 mode; // 0x10
        public float floatValue; // 0x14
        public UnityEngine.AnimationCurve curve; // 0x18
        public string tooltip; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FC51C0 | overloaded x2
        public void GetValue(){} // RVA: 0x7FFAC2FC52C0
    }

}