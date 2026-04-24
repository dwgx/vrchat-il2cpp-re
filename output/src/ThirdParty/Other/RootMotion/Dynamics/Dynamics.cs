// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.Dynamics
// Classes: 29
// Methods: 570

namespace ThirdParty.Other.RootMotion.Dynamics
{
    public class AnimationBlocker : MonoBehaviour
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x7FFD4E39DD90
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class BehaviourBase : MonoBehaviour
    {
        public ce.layAudio forceActive; // 0x20
        public Range OnPreActivate; // 0x28
        public Range OnPreInitiate; // 0x30
        public Range OnPreFixedUpdate; // 0x38
        public Range OnPreUpdate; // 0x40
        public Range OnPreLateUpdate; // 0x48
        public Range OnPreDeactivate; // 0x50
        public Range OnPreFixTransforms; // 0x58
        public Range OnPreRead; // 0x60
        public Range OnPreWrite; // 0x68
        public ange OnPreMuscleHit; // 0x70
        public e OnPreMuscleCollision; // 0x78
        public e OnPreMuscleCollisionExit; // 0x80
        public Range OnHierarchyChanged; // 0x88
        public Range OnPostActivate; // 0x90
        public Range OnPostInitiate; // 0x98
        public Range OnPostFixedUpdate; // 0xA0
        public Range OnPostUpdate; // 0xA8
        public Range OnPostLateUpdate; // 0xB0
        public Range OnPostDeactivate; // 0xB8
        public Range OnPostDrawGizmos; // 0xC0
        public Range OnPostFixTransforms; // 0xC8
        public Range OnPostRead; // 0xD0
        public Range OnPostWrite; // 0xD8
        public ange OnPostMuscleHit; // 0xE0
        public e OnPostMuscleCollision; // 0xE8
        public e OnPostMuscleCollisionExit; // 0xF0
        public bool deactivated; // 0xF8
        public bool <forceActive>k__BackingField; // 0xF9
        public bool initiated; // 0xFA

        // ── Methods ──
        public void OnReactivate(){} // RVA: 0x7FFD4E090980
        public void Resurrect(){} // RVA: 0x7FFD4E341310
        public void Freeze(){} // RVA: 0x7FFD4E341310
        public void Unfreeze(){} // RVA: 0x7FFD4E341310
        public void KillStart(){} // RVA: 0x7FFD4E341310
        public void KillEnd(){} // RVA: 0x7FFD4E341310
        public void OnTeleport(){} // RVA: 0x7FFD4E341310
        public void OnMuscleDisconnected(){} // RVA: 0x7FFD4E341310
        public void OnMuscleReconnected(){} // RVA: 0x7FFD4E341310
        public void OnMuscleAdded(){} // RVA: 0x7FFD4E39DF60
        public void OnMuscleRemoved(){} // RVA: 0x7FFD4E39DF60
        public void OnActivate(){} // RVA: 0x7FFD4E341310
        public void OnDeactivate(){} // RVA: 0x7FFD4E341310
        public void OnInitiate(){} // RVA: 0x7FFD4E341310
        public void OnFixedUpdate(){} // RVA: 0x7FFD4E341310
        public void OnUpdate(){} // RVA: 0x7FFD4E341310
        public void OnLateUpdate(){} // RVA: 0x7FFD4E341310
        public void OnDrawGizmosBehaviour(){} // RVA: 0x7FFD4E341310
        public void OnFixTransformsBehaviour(){} // RVA: 0x7FFD4E341310
        public void OnReadBehaviour(){} // RVA: 0x7FFD4E341310
        public void OnWriteBehaviour(){} // RVA: 0x7FFD4E341310
        public void OnMuscleHitBehaviour(){} // RVA: 0x7FFD4E341310
        public void OnMuscleCollisionBehaviour(){} // RVA: 0x7FFD4E341310
        public void OnMuscleCollisionExitBehaviour(){} // RVA: 0x7FFD4E341310
        public void get_forceActive(){} // RVA: 0x7FFD4E39DF90
        public void set_forceActive(){} // RVA: 0x7FFD4E39DFA0
        public void Initiate(){} // RVA: 0x7FFD4E39DFB0
        public void OnFixTransforms(){} // RVA: 0x7FFD4E39E020
        public void OnRead(){} // RVA: 0x7FFD4E39E0E0
        public void OnWrite(){} // RVA: 0x7FFD4E39E1A0
        public void OnMuscleHit(){} // RVA: 0x7FFD4E39E260
        public void OnMuscleCollision(){} // RVA: 0x7FFD4E39E320
        public void OnMuscleCollisionExit(){} // RVA: 0x7FFD4E39E3E0
        public void OnEnable(){} // RVA: 0x7FFD4E39E4B0
        public void Activate(){} // RVA: 0x7FFD4E39E4D0
        public void OnDisable(){} // RVA: 0x7FFD4E39E6D0
        public void FixedUpdateB(){} // RVA: 0x7FFD4E39E740
        public void UpdateB(){} // RVA: 0x7FFD4E39E850
        public void LateUpdateB(){} // RVA: 0x7FFD4E39E960
        public void OnDrawGizmos(){} // RVA: 0x7FFD4E39EA70
        public void RotateTargetToRootMuscle(){} // RVA: 0x7FFD4E39EAC0
        public void TranslateTargetToRootMuscle(){} // RVA: 0x7FFD4E39F030
        public void RemovePropMuscles(){} // RVA: 0x7FFD4E39F390
        public void GroundTarget(){} // RVA: 0x7FFD4E39F4D0
        public void ContainsRemovablePropMuscle(){} // RVA: 0x7FFD4E39F910
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class BehaviourFall : BehaviourBase
    {
        public string stateName; // 0x100
        public float transitionDuration; // 0x108
        public int layer; // 0x10C
        public float fixedTime; // 0x110
        public object raycastLayers; // 0x114
        public string blendParameter; // 0x118
        public float writheHeight; // 0x120
        public float writheYVelocity; // 0x124
        public float blendSpeed; // 0x128
        public float blendMappingSpeed; // 0x12C
        public bool canEnd; // 0x130
        public float minTime; // 0x134
        public float maxEndVelocity; // 0x138
        public ntalRatio onEnd; // 0x140
        public float timer; // 0x158
        public bool endTriggered; // 0x15C

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void OnActivate(){} // RVA: 0x7FFD4E3A07C0
        public void OnDeactivate(){} // RVA: 0x7FFD4E3A08B0
        public void OnReactivate(){} // RVA: 0x7FFD4E3A08C0
        public void SmoothActivate(){} // RVA: 0x7FFD4E3A08E0
        public void OnFixedUpdate(){} // RVA: 0x7FFD4E3A0980
        public void OnLateUpdate(){} // RVA: 0x7FFD4E3A0D30
        public void Resurrect(){} // RVA: 0x7FFD4E3A0FB0
        public void GetBlendTarget(){} // RVA: 0x7FFD4E3A1010
        public void GetGroundHeight(){} // RVA: 0x7FFD4E3A11F0
        public void OnMuscleReconnected(){} // RVA: 0x7FFD4E3A1470
        public void .ctor(){} // RVA: 0x7FFD4E3A14B0
    }

    public class BehaviourPuppet : BehaviourBase
    {
        public aypointList state; // 0x100
        public object groundLayers; // 0x108
        public object collisionLayers; // 0x10C
        public float collisionThreshold; // 0x110
        public ce.peed collisionResistance; // 0x118
        public r[] collisionResistanceMultipliers; // 0x120
        public int maxCollisions; // 0x128
        public float regainPinSpeed; // 0x12C
        public float boostFalloff; // 0x130
        public object defaults; // 0x138
        public headForSpeedFactor[] groupOverrides; // 0x170
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
        public amut getUpOffsetProne; // 0x1A8
        public amut getUpOffsetSupine; // 0x1B4
        public ntalRatio onGetUpProne; // 0x1C0
        public ntalRatio onGetUpSupine; // 0x1D8
        public ntalRatio onLoseBalance; // 0x1F0
        public ntalRatio onLoseBalanceFromPuppet; // 0x208
        public ntalRatio onLoseBalanceFromGetUp; // 0x220
        public ntalRatio onRegainBalance; // 0x238
        public e OnCollision; // 0x250
        public reshold OnCollisionImpulse; // 0x258
        public object <state>k__BackingField; // 0x260
        public bool canMoveTarget; // 0x264
        public float unpinnedTimer; // 0x268
        public float getUpTimer; // 0x26C
        public amut hipsForward; // 0x270
        public amut hipsUp; // 0x27C
        public float getupAnimationBlendWeight; // 0x288
        public float getupAnimationBlendWeightV; // 0x28C
        public bool getUpTargetFixed; // 0x290
        public p0n lastNormalMode; // 0x294
        public int collisions; // 0x298
        public bool eventsEnabled; // 0x29C
        public float lastKnockOutDistance; // 0x2A0
        public float knockOutDistanceSqr; // 0x2A4
        public bool getupDisabled; // 0x2A8
        public bool hasCollidedSinceGetUp; // 0x2A9
        public bool hasBoosted; // 0x2AA
        public ce.get_BrakeInput broadcaster; // 0x2B0
        public amut getUpPosition; // 0x2B8
        public bool dropPropFlag; // 0x2C4

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void get_state(){} // RVA: 0x7FFD4E3A19C0
        public void set_state(){} // RVA: 0x7FFD4E3A19D0
        public void OnReactivate(){} // RVA: 0x7FFD4E3A19E0
        public void Reset(){} // RVA: 0x7FFD4E3A1B00
        public void OnTeleport(){} // RVA: 0x7FFD4E3A1B60
        public void OnInitiate(){} // RVA: 0x7FFD4E3A1DA0
        public void OnActivate(){} // RVA: 0x7FFD4E3A27D0
        public void KillStart(){} // RVA: 0x7FFD4E3A2880
        public void KillEnd(){} // RVA: 0x7FFD4E3A2930
        public void Resurrect(){} // RVA: 0x7FFD4E3A2940
        public void OnDeactivate(){} // RVA: 0x7FFD4E3A29D0
        public void OnFixedUpdate(){} // RVA: 0x7FFD4E3A29E0
        public void OnLateUpdate(){} // RVA: 0x7FFD4E3A33F0
        public void SetKinematic(){} // RVA: 0x7FFD4E3A3650
        public void OnReadBehaviour(){} // RVA: 0x7FFD4E3A3720
        public void BlendMuscleMapping(){} // RVA: 0x7FFD4E3A3D80
        public void OnMuscleAdded(){} // RVA: 0x7FFD4E3A3F80
        public void OnMuscleRemoved(){} // RVA: 0x7FFD4E3A3FE0
        public void MoveTarget(){} // RVA: 0x7FFD4E3A4030
        public void RotateTarget(){} // RVA: 0x7FFD4E3A40C0
        public void GroundTarget(){} // RVA: 0x7FFD4E3A4150
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD4E3A4170
        public void Boost(){} // RVA: 0x7FFD4E3A45B0 | overloaded x3
        public void BoostImmunity(){} // RVA: 0x7FFD4E3A48B0 | overloaded x3
        public void BoostImpulseMlp(){} // RVA: 0x7FFD4E3A4B20 | overloaded x3
        public void Unpin(){} // RVA: 0x7FFD4E3A4C60
        public void OnMuscleHitBehaviour(){} // RVA: 0x7FFD4E3A4CE0
        public void OnMuscleCollisionBehaviour(){} // RVA: 0x7FFD4E3A4E80
        public void GetImpulse(){} // RVA: 0x7FFD4E3A5550
        public void UnPin(){} // RVA: 0x7FFD4E3A57C0
        public void UnPinMuscle(){} // RVA: 0x7FFD4E3A5930
        public void Activate(){} // RVA: 0x7FFD4E3A5C10
        public void IsProne(){} // RVA: 0x7FFD4E3A5CA0
        public void GetFalloff(){} // RVA: 0x7FFD4E3A6060 | overloaded x2
        public void InGroup(){} // RVA: 0x7FFD4E3A61F0
        public void GetProps(){} // RVA: 0x7FFD4E3A62B0
        public void SetState(){} // RVA: 0x7FFD4E3A63B0
        public void SetColliders(){} // RVA: 0x7FFD4E3A7510 | overloaded x2
        public void OnMuscleDisconnected(){} // RVA: 0x7FFD4E3A77E0
        public void OnMuscleReconnected(){} // RVA: 0x7FFD4E3A77F0
        public void .ctor(){} // RVA: 0x7FFD4E3A78A0
    }

    public class BehaviourTemplate : BehaviourBase
    {
        public ce.ty centerOfMass; // 0x100
        public object groundLayers; // 0x108
        public ntalRatio onLoseBalance; // 0x110
        public float loseBalanceAngle; // 0x128

        // ── Methods ──
        public void OnInitiate(){} // RVA: 0x7FFD4E3A7D60
        public void OnActivate(){} // RVA: 0x7FFD4E341310
        public void OnReactivate(){} // RVA: 0x7FFD4E341310
        public void OnDeactivate(){} // RVA: 0x7FFD4E341310
        public void OnFixedUpdate(){} // RVA: 0x7FFD4E3A7D90
        public void OnLateUpdate(){} // RVA: 0x7FFD4E341310
        public void OnMuscleHitBehaviour(){} // RVA: 0x7FFD4E3A7DE0
        public void OnMuscleCollisionBehaviour(){} // RVA: 0x7FFD4E3A7DE0
        public void .ctor(){} // RVA: 0x7FFD4E3A7E30
    }

    public class BipedRagdollCreator : RagdollCreator
    {
        public bool canBuild; // 0x20
        public ce.dCameraRig references; // 0x28
        public ÌÍÎÏÎÏÎÌÍÌÎ options; // 0xB0

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void OpenTutorial(){} // RVA: 0x7FFD4E341310
        public void AutodetectOptions(){} // RVA: 0x7FFD4E3E52F0
        public void Create(){} // RVA: 0x7FFD4E3E5810
        public void CreateColliders(){} // RVA: 0x7FFD4E3E5A90
        public void CreateHandCollider(){} // RVA: 0x7FFD4E3E7EB0
        public void CreateFootCollider(){} // RVA: 0x7FFD4E3E85D0
        public void GetChildCentroid(){} // RVA: 0x7FFD4E3E9100
        public void MassDistribution(){} // RVA: 0x7FFD4E3E93A0
        public void CreateJoints(){} // RVA: 0x7FFD4E3E9EA0
        public void CreateLimbJoints(){} // RVA: 0x7FFD4E3EB100
        public void ClearBipedRagdoll(){} // RVA: 0x7FFD4E3EC200
        public void IsClear(){} // RVA: 0x7FFD4E3EC260
        public void GetUpperArmToHeadCentroid(){} // RVA: 0x7FFD4E3EC3C0
        public void GetUpperArmCentroid(){} // RVA: 0x7FFD4E3EC520
        public void .ctor(){} // RVA: 0x7FFD4E3EC660
    }

    public class BipedRagdollReferences : ValueType
    {
        public object root; // 0x10
        public object hips; // 0x18
        public object spine; // 0x20
        public object chest; // 0x28
        public object head; // 0x30
        public object leftUpperLeg; // 0x38
        public object leftLowerLeg; // 0x40
        public object leftFoot; // 0x48
        public object rightUpperLeg; // 0x50
        public object rightLowerLeg; // 0x58
        public object rightFoot; // 0x60
        public object leftUpperArm; // 0x68
        public object leftLowerArm; // 0x70
        public object leftHand; // 0x78
        public object rightUpperArm; // 0x80
        public object rightLowerArm; // 0x88
        public object rightHand; // 0x90

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD4E3EC760
        public void IsChildRecursive(){} // RVA: 0x7FFD4E3ED540
        public void IsEmpty(){} // RVA: 0x7FFD4E3ED7F0
        public void Contains(){} // RVA: 0x7FFD4E3EE090
        public void GetRagdollTransforms(){} // RVA: 0x7FFD4E3EECF0
        public void FromAvatar(){} // RVA: 0x7FFD4E3EF170
        public void FromBipedReferences(){} // RVA: 0x7FFD4E3EF8C0
    }

    public class Booster : Object
    {
        public bool fullBody; // 0x10
        public eam[] muscles; // 0x18
        public ?[] groups; // 0x20
        public float immunity; // 0x28
        public float impulseMlp; // 0x2C
        public float boostParents; // 0x30
        public float boostChildren; // 0x34
        public float delay; // 0x38

        // ── Methods ──
        public void Boost(){} // RVA: 0x7FFD4E3ABA70
        public void .ctor(){} // RVA: 0x7FFD4E3ABE70
    }

    public class JointBreakBroadcaster : MonoBehaviour
    {
        public ce.layAudio puppetMaster; // 0x20
        public int muscleIndex; // 0x28

        // ── Methods ──
        public void OnJointBreak(){} // RVA: 0x7FFD4E3ABF90
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class JointConverter : Object
    {
        // ── Methods ──
        public void ToConfigurable(){} // RVA: 0x7FFD4E3EFEA0
        public void HingeToConfigurable(){} // RVA: 0x7FFD4E3F0270
        public void FixedToConfigurable(){} // RVA: 0x7FFD4E3F0AA0
        public void SpringToConfigurable(){} // RVA: 0x7FFD4E3F0DD0
        public void CharacterToConfigurable(){} // RVA: 0x7FFD4E3F1220
        public void ConvertJoint(){} // RVA: 0x7FFD4E3F1BF0
        public void ConvertToHighSoftJointLimit(){} // RVA: 0x7FFD4E3F2180
        public void ConvertToLowSoftJointLimit(){} // RVA: 0x7FFD4E3F21B0
        public void ConvertToSoftJointLimitSpring(){} // RVA: 0x7FFD4E3F21D0
        public void CopyLimit(){} // RVA: 0x7FFD4E3F2200
        public void CopyLimitSpring(){} // RVA: 0x7FFD4E3F2220
    }

    public class Muscle : Object
    {
        public string transform; // 0x10
        public eam rigidbody; // 0x18
        public object connectedBodyTarget; // 0x20
        public ÌÍÌÌÎÎÌÏÏÍÎÌÎÎÍÌÏÏÎÏÌÍÏ targetAnimatedPosition; // 0x28
        public object targetAnimatedWorldRotation; // 0x30
        public int[] colliders; // 0x70
        public int[] targetVelocity; // 0x78
        public bool[] additionalRigidbody; // 0x80
        public int[] targetRotationRelative; // 0x88
        public ce.get_BrakeInput rebuildConnectedBody; // 0x90
        public ce.onFor rebuildTargetParent; // 0x98
        public amut defaultTargetPosRelToMuscle; // 0xA0
        public object defaultTargetRotRelToMuscle; // 0xB0
        public Touched defaultMuscleRotRelToTarget; // 0xB8
        public object localRotation; // 0xC0
        public amut parentRotation; // 0xC8
        public R_12x12 targetParentRotation; // 0xD4
        public amut targetLocalRotation; // 0xE4
        public Touched <additionalRigidbody>k__BackingField; // 0xF0
        public eam additionalPin; // 0xF8
        public object additionalPinTarget; // 0x100
        public float additionalPinWeight; // 0x108
        public amut mappedVelocity; // 0x10C
        public amut mappedAngularVelocity; // 0x118
        public bool isPropMuscle; // 0x124
        public int index; // 0x128
        public R_12x12 <targetRotationRelative>k__BackingField; // 0x12C
        public Touched <rebuildConnectedBody>k__BackingField; // 0x140
        public object <rebuildTargetParent>k__BackingField; // 0x148
        public amut <defaultTargetPosRelToMuscle>k__BackingField; // 0x150
        public R_12x12 <defaultTargetRotRelToMuscle>k__BackingField; // 0x15C
        public R_12x12 <defaultMuscleRotRelToTarget>k__BackingField; // 0x16C
        public object rebuildParent; // 0x180
        public amut rebuildPosition; // 0x188
        public R_12x12 rebuildRotation; // 0x194
        public amut rebuildTargetPosition; // 0x1A4
        public R_12x12 rebuildTargetRotation; // 0x1B0
        public ectMassCenter rebuildAngularXMotion; // 0x1C0
        public ectMassCenter rebuildAngularYMotion; // 0x1C4
        public ectMassCenter rebuildAngularZMotion; // 0x1C8
        public amut targetMappedPosition; // 0x1CC
        public R_12x12 targetMappedRotation; // 0x1D8
        public amut targetSampledPosition; // 0x1E8
        public R_12x12 targetSampledRotation; // 0x1F4
        public odyPositionInternal_Injected slerpDrive; // 0x204
        public float lastJointDriveRotationWeight; // 0x214
        public float lastRotationDamper; // 0x218
        public amut defaultPosition; // 0x21C
        public amut defaultTargetLocalPosition; // 0x228
        public amut lastMappedPosition; // 0x234
        public R_12x12 defaultLocalRotation; // 0x240
        public R_12x12 localRotationConvert; // 0x250
        public R_12x12 toParentSpace; // 0x260
        public R_12x12 toJointSpaceInverse; // 0x270
        public R_12x12 toJointSpaceDefault; // 0x280
        public R_12x12 targetAnimatedRotation; // 0x290
        public R_12x12 defaultRotation; // 0x2A0
        public R_12x12 rotationRelativeToTarget; // 0x2B0
        public R_12x12 defaultTargetLocalRotation; // 0x2C0
        public R_12x12 lastMappedRotation; // 0x2D0
        public object targetParent; // 0x2E0
        public object connectedBodyTransform; // 0x2E8
        public ectMassCenter angularXMotionDefault; // 0x2F0
        public ectMassCenter angularYMotionDefault; // 0x2F4
        public ectMassCenter angularZMotionDefault; // 0x2F8
        public bool directTargetParent; // 0x2FC
        public bool initiated; // 0x2FD
        public riteCharacterUnicode[] _colliders; // 0x300
        public float lastReadTime; // 0x308
        public float lastWriteTime; // 0x30C
        public bool[] disabledColliders; // 0x310
        public ourWheelDrive[] targetChildren; // 0x318
        public amut additionalTargetVelocity; // 0x320
        public amut targetAnimatedCenterOfMass; // 0x32C
        public amut additionalPinTargetAnimatedCenterOfMass; // 0x338
        public R_12x12 defaultTargetRotRelToMuscleInverse; // 0x344

        // ── Methods ──
        public void get_transform(){} // RVA: 0x7FFD4E3AC040
        public void set_transform(){} // RVA: 0x7FFD4E3AC050
        public void get_rigidbody(){} // RVA: 0x7FFD4E3AC0B0
        public void set_rigidbody(){} // RVA: 0x7FFD4E3AC0C0
        public void get_connectedBodyTarget(){} // RVA: 0x7FFD4E3AC120
        public void set_connectedBodyTarget(){} // RVA: 0x7FFD4E3AC130
        public void get_targetAnimatedPosition(){} // RVA: 0x7FFD4E3AC190
        public void set_targetAnimatedPosition(){} // RVA: 0x7FFD4E3AC1B0
        public void get_targetAnimatedWorldRotation(){} // RVA: 0x7FFD4E3AC1D0
        public void set_targetAnimatedWorldRotation(){} // RVA: 0x7FFD4E3AC1E0
        public void get_colliders(){} // RVA: 0x7FFD4E3AC1F0
        public void set_colliders(){} // RVA: 0x7FFD4E3AC200
        public void get_targetVelocity(){} // RVA: 0x7FFD4E3AC260
        public void set_targetVelocity(){} // RVA: 0x7FFD4E3AC280
        public void get_additionalRigidbody(){} // RVA: 0x7FFD4E3AC2A0
        public void set_additionalRigidbody(){} // RVA: 0x7FFD4E3AC2B0
        public void get_targetRotationRelative(){} // RVA: 0x7FFD4E3AC310
        public void set_targetRotationRelative(){} // RVA: 0x7FFD4E3AC320
        public void IsValid(){} // RVA: 0x7FFD4E3AC330
        public void get_rebuildConnectedBody(){} // RVA: 0x7FFD4E3AC5F0
        public void set_rebuildConnectedBody(){} // RVA: 0x7FFD4E3AC600
        public void get_rebuildTargetParent(){} // RVA: 0x7FFD4E3AC660
        public void set_rebuildTargetParent(){} // RVA: 0x7FFD4E3AC670
        public void get_defaultTargetPosRelToMuscle(){} // RVA: 0x7FFD4E3AC6D0
        public void set_defaultTargetPosRelToMuscle(){} // RVA: 0x7FFD4E3AC6F0
        public void get_defaultTargetRotRelToMuscle(){} // RVA: 0x7FFD4E3AC710
        public void set_defaultTargetRotRelToMuscle(){} // RVA: 0x7FFD4E3AC720
        public void get_defaultMuscleRotRelToTarget(){} // RVA: 0x7FFD4E3AC730
        public void set_defaultMuscleRotRelToTarget(){} // RVA: 0x7FFD4E3AC740
        public void Rebuild(){} // RVA: 0x7FFD4E3AC750
        public void Initiate(){} // RVA: 0x7FFD4E3ACBC0
        public void InitiateAdditionalPin(){} // RVA: 0x7FFD4E3AF810
        public void UpdateColliders(){} // RVA: 0x7FFD4E3AFB50
        public void DisableColliders(){} // RVA: 0x7FFD4E3AFE80
        public void EnableColliders(){} // RVA: 0x7FFD4E3B0030
        public void AddColliders(){} // RVA: 0x7FFD4E3B00E0
        public void AddCompoundColliders(){} // RVA: 0x7FFD4E3B03C0
        public void IgnoreInternalCollisions(){} // RVA: 0x7FFD4E3B05B0
        public void ResetInternalCollisions(){} // RVA: 0x7FFD4E3B0880
        public void ForceIgnore(){} // RVA: 0x7FFD4E3B0B90
        public void IgnoreAngularLimits(){} // RVA: 0x7FFD4E3B0F60
        public void FixTargetTransforms(){} // RVA: 0x7FFD4E3B10D0
        public void Reset(){} // RVA: 0x7FFD4E3B11C0
        public void MoveToTarget(){} // RVA: 0x7FFD4E3B17D0
        public void SetKinematic(){} // RVA: 0x7FFD4E3B1EA0
        public void Read(){} // RVA: 0x7FFD4E3B2090
        public void ClearVelocities(){} // RVA: 0x7FFD4E3B28F0
        public void UpdateAnchor(){} // RVA: 0x7FFD4E3B2DF0
        public void Update(){} // RVA: 0x7FFD4E3B3440
        public void StoreTargetMappedPosition(){} // RVA: 0x7FFD4E3B3710
        public void StoreTargetMappedRotation(){} // RVA: 0x7FFD4E3B37A0
        public void Map(){} // RVA: 0x7FFD4E3B3820
        public void ResetTargetLocalPosition(){} // RVA: 0x7FFD4E3B4440
        public void CalculateMappedVelocity(){} // RVA: 0x7FFD4E3B44C0
        public void MapDisconnected(){} // RVA: 0x7FFD4E3B48D0
        public void Pin(){} // RVA: 0x7FFD4E3B54E0 | overloaded x2
        public void MuscleRotation(){} // RVA: 0x7FFD4E3B56F0
        public void SetMuscleRotation(){} // RVA: 0x7FFD4E3B59D0
        public void get_localRotation(){} // RVA: 0x7FFD4E3B5C70
        public void get_parentRotation(){} // RVA: 0x7FFD4E3B5EE0
        public void get_targetParentRotation(){} // RVA: 0x7FFD4E3B62A0
        public void get_targetLocalRotation(){} // RVA: 0x7FFD4E3B6420
        public void LocalToJointSpace(){} // RVA: 0x7FFD4E3B6770
        public void InverseTransformPointUnscaled(){} // RVA: 0x7FFD4E3B6A30
        public void .ctor(){} // RVA: 0x7FFD4E3B6CB0
    }

    public class MuscleCollisionBroadcaster : MonoBehaviour
    {
        public ce.layAudio puppetMaster; // 0x20
        public int muscleIndex; // 0x28
        public string onMuscleHit;
        public string onMuscleCollision;
        public string onMuscleCollisionExit;
        public ce.get_BrakeInput otherBroadcaster; // 0x30

        // ── Methods ──
        public void Hit(){} // RVA: 0x7FFD4E3B7F80
        public void OnCollisionEnter(){} // RVA: 0x7FFD4E3B8210
        public void OnCollisionStay(){} // RVA: 0x7FFD4E3B8840
        public void OnCollisionExit(){} // RVA: 0x7FFD4E3B8CD0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class PhysXTools : Object
    {
        // ── Methods ──
        public void Predict(){} // RVA: 0x7FFD4E3B9720 | overloaded x3
        public void GetCenterOfMass(){} // RVA: 0x7FFD4E3B9F50 | overloaded x2
        public void GetCenterOfMassVelocity(){} // RVA: 0x7FFD4E3BA1F0
        public void DivByInertia(){} // RVA: 0x7FFD4E3BA490
        public void ScaleByInertia(){} // RVA: 0x7FFD4E3BA850
        public void GetFromToAcceleration(){} // RVA: 0x7FFD4E3BAC10
        public void GetAngularAcceleration(){} // RVA: 0x7FFD4E3BAE20
        public void AddFromToTorque(){} // RVA: 0x7FFD4E3BBBA0 | overloaded x2
        public void AddFromToForce(){} // RVA: 0x7FFD4E3BC030
        public void GetLinearAcceleration(){} // RVA: 0x7FFD4E3BC350
        public void ToJointSpace(){} // RVA: 0x7FFD4E3BC410
        public void CalculateInertiaTensorCuboid(){} // RVA: 0x7FFD4E3BC670
        public void Div(){} // RVA: 0x7FFD4E3BC6C0
    }

    public class PressureSensor : MonoBehaviour
    {
        public bool center; // 0x20
        public object inContact; // 0x24
        public amut bottom; // 0x28
        public bool r; // 0x34
        public amut <bottom>k__BackingField; // 0x38
        public Touched <r>k__BackingField; // 0x48
        public bool fixedFrame; // 0x50
        public amut P; // 0x54
        public int count; // 0x60

        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFD4E3BC700
        public void set_center(){} // RVA: 0x7FFD4E3BC720
        public void get_inContact(){} // RVA: 0x7FFD4E377C20
        public void set_inContact(){} // RVA: 0x7FFD4E37BAC0
        public void get_bottom(){} // RVA: 0x7FFD4E3A7F40
        public void set_bottom(){} // RVA: 0x7FFD4E3A7F60
        public void get_r(){} // RVA: 0x7FFD4E3BC730
        public void set_r(){} // RVA: 0x7FFD4E3BC740
        public void Awake(){} // RVA: 0x7FFD4E3BC7A0
        public void OnCollisionEnter(){} // RVA: 0x7FFD4E3BC8F0
        public void OnCollisionStay(){} // RVA: 0x7FFD4E3BC8F0
        public void OnCollisionExit(){} // RVA: 0x7FFD4E3BC900
        public void FixedUpdate(){} // RVA: 0x7FFD4E3BC910
        public void LateUpdate(){} // RVA: 0x7FFD4E3BC9D0
        public void ProcessCollision(){} // RVA: 0x7FFD4E3BCA20
        public void OnDrawGizmos(){} // RVA: 0x7FFD4E3BCC10
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Prop : MonoBehaviour
    {
        public int isPickedUp; // 0x20
        public eam propRoot; // 0x28
        public ÌÍÌÌÎÎÌÏÏÍÎÌÎÎÍÌÏÏÎÏÌÍÏ initiated; // 0x30
        public bool forceLayers; // 0x38
        public eam additionalPin; // 0x40
        public object additionalPinTarget; // 0x48
        public float additionalPinWeight; // 0x50
        public th pickedUpMaterial; // 0x58
        public th droppedMaterial; // 0x60
        public ce.get_skidding <propRoot>k__BackingField; // 0x68
        public bool <initiated>k__BackingField; // 0x70
        public ectMassCenter xMotion; // 0x74
        public ectMassCenter yMotion; // 0x78
        public ectMassCenter zMotion; // 0x7C
        public ectMassCenter angularXMotion; // 0x80
        public ectMassCenter angularYMotion; // 0x84
        public ectMassCenter angularZMotion; // 0x88
        public riteCharacterUnicode[] colliders; // 0x90

        // ── Methods ──
        public void get_isPickedUp(){} // RVA: 0x7FFD4E3BCC80
        public void get_propRoot(){} // RVA: 0x7FFD4E3BCD50
        public void set_propRoot(){} // RVA: 0x7FFD4E3BCD60
        public void PickUp(){} // RVA: 0x7FFD4E3BCDC0
        public void Drop(){} // RVA: 0x7FFD4E3BD290
        public void StartPickedUp(){} // RVA: 0x7FFD4E3BCD60
        public void get_initiated(){} // RVA: 0x7FFD4E3BD320
        public void set_initiated(){} // RVA: 0x7FFD4E3BD330
        public void OnPickUp(){} // RVA: 0x7FFD4E341310
        public void OnDrop(){} // RVA: 0x7FFD4E341310
        public void OnStart(){} // RVA: 0x7FFD4E341310
        public void Start(){} // RVA: 0x7FFD4E3BD340
        public void ReleaseJoint(){} // RVA: 0x7FFD4E3BD9A0
        public void SetMaterial(){} // RVA: 0x7FFD4E3BDD40
        public void OnDrawGizmos(){} // RVA: 0x7FFD4E3BDEB0
        public void .ctor(){} // RVA: 0x7FFD4E3BE4F0
    }

    public class PropMuscle : MonoBehaviour
    {
        public ce.layAudio muscle; // 0x20
        public ce.epInterval activeProp; // 0x28
        public amut additionalPinOffset; // 0x30
        public ce.epInterval <activeProp>k__BackingField; // 0x40
        public WheelEffects OnPickUpProp; // 0x48
        public WheelEffects OnDropProp; // 0x50
        public ce.projection _muscle; // 0x58
        public ce.epInterval lastProp; // 0x60
        public amut targetDefaultLocalPos; // 0x68
        public amut lastAdditionalPinOffset; // 0x74

        // ── Methods ──
        public void get_muscle(){} // RVA: 0x7FFD4E3BE650
        public void get_activeProp(){} // RVA: 0x7FFD4E3BE740
        public void set_activeProp(){} // RVA: 0x7FFD4E369200
        public void AddAdditionalPin(){} // RVA: 0x7FFD4E3BE750
        public void RemoveAdditionalPin(){} // RVA: 0x7FFD4E3BF310
        public void OnInitiate(){} // RVA: 0x7FFD4E3BF6A0
        public void TakeOver(){} // RVA: 0x7FFD4E3BF860
        public void OnUpdate(){} // RVA: 0x7FFD4E3BF9B0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD4E3C08A0
        public void .ctor(){} // RVA: 0x7FFD4E3C1100
    }

    public class PropRoot : MonoBehaviour
    {
        public ce.layAudio puppetMaster; // 0x20
        public Touched connectTo; // 0x28
        public ce.ÍÎÏÏÌÌÍÌÌÎÌÏÌÍÏÏÏÌ currentProp; // 0x30
        public ce.ÍÎÏÏÌÌÍÌÌÎÌÏÌÍÏÏÏÌ lastProp; // 0x38
        public bool fixedUpdateCalled; // 0x40

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void DropImmediate(){} // RVA: 0x7FFD4E3C1310
        public void Awake(){} // RVA: 0x7FFD4E3C14E0
        public void Update(){} // RVA: 0x7FFD4E3C16A0
        public void FixedUpdate(){} // RVA: 0x7FFD4E3C1950
        public void AttachProp(){} // RVA: 0x7FFD4E3C1E50
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class PropTemplate : Prop
    {
        // ── Methods ──
        public void OnStart(){} // RVA: 0x7FFD4E341310
        public void OnPickUp(){} // RVA: 0x7FFD4E341310
        public void OnDrop(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E3BE4F0
    }

    public class PuppetMaster : MonoBehaviour
    {
        public ce.Kick targetAnimator; // 0x20
        public object targetAnimation; // 0x28
        public object behaviours; // 0x30
        public hing isActive; // 0x34
        public object initiated; // 0x48
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
        public ce.projection[] muscles; // 0x80
        public ce.?[] propMuscles; // 0x88
        public object OnPostInitiate; // 0x90
        public object OnRead; // 0x98
        public object OnWrite; // 0xA0
        public object OnPostLateUpdate; // 0xA8
        public object OnFixTransforms; // 0xB0
        public object OnHierarchyChanged; // 0xB8
        public t OnMuscleRemoved; // 0xC0
        public t OnMuscleDisconnected; // 0xC8
        public t OnMuscleReconnected; // 0xD0
        public stfix _targetAnimator; // 0xD8
        public usInEvent>b__10_0 <targetAnimation>k__BackingField; // 0xE0
        public ce.cond[] <behaviours>k__BackingField; // 0xE8
        public bool <initiated>k__BackingField; // 0xF0
        public URA.woDigitYearMax<h_Null_ModelNumber_String.putActionsPerSecond> solvers; // 0xF8
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
        public amut teleportPosition; // 0x114
        public R_12x12 teleportRotation; // 0x120
        public bool teleportMoveToTarget; // 0x130
        public bool rebuildFlag; // 0x131
        public bool onPostRebuildFlag; // 0x132
        public bool[] disconnectMuscleFlags; // 0x138
        public ce.ok[] muscleDisconnectModes; // 0x140
        public bool[] disconnectDeactivateFlags; // 0x148
        public bool[] reconnectMuscleFlags; // 0x150
        public ce.projection[] defaultMuscles; // 0x158
        public amut rebuildPelvisPos; // 0x160
        public R_12x12 rebuildPelvisRot; // 0x16C
        public bool readInFixedUpdate; // 0x17C
        public bool <isSwitchingMode>k__BackingField; // 0x17D
        public object activeMode; // 0x180
        public object lastMode; // 0x184
        public float mappingBlend; // 0x188
        public bool <isKilling>k__BackingField; // 0x18C
        public object OnFreeze; // 0x190
        public object OnUnfreeze; // 0x198
        public object OnDeath; // 0x1A0
        public object OnResurrection; // 0x1A8
        public object activeState; // 0x1B0
        public object lastState; // 0x1B4
        public bool angularLimitsEnabledOnKill; // 0x1B8
        public bool internalCollisionsEnabledOnKill; // 0x1B9
        public bool animationDisabledbyStates; // 0x1BA
        public bool storeTargetMappedState; // 0x1BB
        public bool targetMappedStateStored; // 0x1BC
        public bool targetMappedStateSampled; // 0x1BD
        public bool sampleTargetMappedState; // 0x1BE
        public bool hasProp; // 0x1BF

        // ── Methods ──
        public void OpenUserManualSetup(){} // RVA: 0x7FFD4E341310
        public void OpenUserManualComponent(){} // RVA: 0x7FFD4E341310
        public void OpenUserManualPerformance(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void OpenSetupTutorial(){} // RVA: 0x7FFD4E341310
        public void OpenComponentTutorial(){} // RVA: 0x7FFD4E341310
        public void ResetStateSettings(){} // RVA: 0x7FFD4E3C24C0
        public void get_targetAnimator(){} // RVA: 0x7FFD4E3C24F0
        public void set_targetAnimator(){} // RVA: 0x7FFD4E3C28A0
        public void get_targetAnimation(){} // RVA: 0x7FFD4E3C2900
        public void set_targetAnimation(){} // RVA: 0x7FFD4E3C2910
        public void get_behaviours(){} // RVA: 0x7FFD4E3C2970
        public void set_behaviours(){} // RVA: 0x7FFD4E3C2980
        public void get_isActive(){} // RVA: 0x7FFD4E3C29E0
        public void get_initiated(){} // RVA: 0x7FFD4E3C2AD0
        public void set_initiated(){} // RVA: 0x7FFD4E3C2AE0
        public void get_updateMode(){} // RVA: 0x7FFD4E3C2AF0
        public void get_controlsAnimator(){} // RVA: 0x7FFD4E3C2B30
        public void get_isBlending(){} // RVA: 0x7FFD4E3C2BE0
        public void Teleport(){} // RVA: 0x7FFD4E3C2C00
        public void SetInternalCollisionsManual(){} // RVA: 0x7FFD4E3C2C40
        public void SetAngularLimitsManual(){} // RVA: 0x7FFD4E3C2D60
        public void get_autoSimulate(){} // RVA: 0x7FFD4E3C2E00
        public void OnDisable(){} // RVA: 0x7FFD4E3C2E90
        public void OnEnable(){} // RVA: 0x7FFD4E3C3020
        public void Awake(){} // RVA: 0x7FFD4E3C39E0
        public void Start(){} // RVA: 0x7FFD4E3C3A20
        public void FindTargetRootRecursive(){} // RVA: 0x7FFD4E3C3B00
        public void Initiate(){} // RVA: 0x7FFD4E3C3FB0
        public void ActivateBehaviour(){} // RVA: 0x7FFD4E3C4F70
        public void OnDestroy(){} // RVA: 0x7FFD4E3C5190
        public void IsInterpolated(){} // RVA: 0x7FFD4E3C52C0
        public void OnRebuild(){} // RVA: 0x7FFD4E3C53A0
        public void OnPreSimulate(){} // RVA: 0x7FFD4E3C56E0
        public void OnPostSimulate(){} // RVA: 0x7FFD4E3C5EB0
        public void FixedUpdate(){} // RVA: 0x7FFD4E3C6330
        public void Update(){} // RVA: 0x7FFD4E3C6C60
        public void LateUpdate(){} // RVA: 0x7FFD4E3C6DF0
        public void OnLateUpdate(){} // RVA: 0x7FFD4E3C70C0
        public void MoveToTarget(){} // RVA: 0x7FFD4E3C7460
        public void Read(){} // RVA: 0x7FFD4E3C7650
        public void FixTargetTransforms(){} // RVA: 0x7FFD4E3C8EE0
        public void get_targetUpdateMode(){} // RVA: 0x7FFD4E3C9120
        public void VisualizeTargetPose(){} // RVA: 0x7FFD4E3C9360
        public void VisualizeHierarchy(){} // RVA: 0x7FFD4E3C93D0
        public void FlagInternalCollisionsForUpdate(){} // RVA: 0x7FFD4E3C9710
        public void UpdateInternalCollisions(){} // RVA: 0x7FFD4E3C98A0 | overloaded x2
        public void IgnoreInternalCollisions(){} // RVA: 0x7FFD4E3C9A00 | overloaded x2
        public void ResetInternalCollisions(){} // RVA: 0x7FFD4E3C9B40 | overloaded x2
        public void FlagAngularLimitsForUpdate(){} // RVA: 0x7FFD4E3C9BD0
        public void UpdateAngularLimits(){} // RVA: 0x7FFD4E3C9BF0
        public void AddPropMuscle(){} // RVA: 0x7FFD4E3C9CA0
        public void IsDisconnecting(){} // RVA: 0x7FFD4E3CA810
        public void IsReconnecting(){} // RVA: 0x7FFD4E3CA850
        public void DisconnectMuscleRecursive(){} // RVA: 0x7FFD4E3CA890
        public void ReconnectMuscleRecursive(){} // RVA: 0x7FFD4E3CAA10
        public void AddMuscle(){} // RVA: 0x7FFD4E3CAD40
        public void Rebuild(){} // RVA: 0x7FFD4E3CC1B0
        public void RemoveMuscleRecursive(){} // RVA: 0x7FFD4E3CC1C0
        public void ReplaceMuscle(){} // RVA: 0x7FFD4E3CDB70
        public void SetMuscles(){} // RVA: 0x7FFD4E3CDC30
        public void DisableMuscleRecursive(){} // RVA: 0x7FFD4E3CDCF0
        public void EnableMuscleRecursive(){} // RVA: 0x7FFD4E3CDDB0
        public void FlattenHierarchy(){} // RVA: 0x7FFD4E3CDE70
        public void TreeHierarchy(){} // RVA: 0x7FFD4E3CDFE0
        public void FixMusclePositions(){} // RVA: 0x7FFD4E3CE220
        public void FixMusclePositionsAndRotations(){} // RVA: 0x7FFD4E3CE4D0
        public void HierarchyIsFlat(){} // RVA: 0x7FFD4E3CE870
        public void GetHighestDisconnectedParentIndex(){} // RVA: 0x7FFD4E3CEAE0
        public void ProcessDisconnects(){} // RVA: 0x7FFD4E3CEB70
        public void ProcessReconnects(){} // RVA: 0x7FFD4E3CECB0
        public void OnDisconnectMuscleRecursive(){} // RVA: 0x7FFD4E3CED80
        public void DisconnectMuscle(){} // RVA: 0x7FFD4E3CF2A0
        public void OnReconnectMuscleRecursive(){} // RVA: 0x7FFD4E3D0350
        public void ReconnectMuscle(){} // RVA: 0x7FFD4E3D0510
        public void AddIndexesRecursive(){} // RVA: 0x7FFD4E3D0F40
        public void DisconnectJoint(){} // RVA: 0x7FFD4E3D10E0
        public void KillJoint(){} // RVA: 0x7FFD4E3D13C0
        public void SwitchToActiveMode(){} // RVA: 0x7FFD4E3D14E0
        public void SwitchToKinematicMode(){} // RVA: 0x7FFD4E3D14F0
        public void SwitchToDisabledMode(){} // RVA: 0x7FFD4E3D1500
        public void get_isSwitchingMode(){} // RVA: 0x7FFD4E3D1510
        public void set_isSwitchingMode(){} // RVA: 0x7FFD4E3D1520
        public void DisableImmediately(){} // RVA: 0x7FFD4E3D1530
        public void SwitchModes(){} // RVA: 0x7FFD4E3D1660
        public void DisabledToKinematic(){} // RVA: 0x7FFD4E3D1BD0
        public void DisabledToActive(){} // RVA: 0x7FFD4E3D1D40
        public void KinematicToDisabled(){} // RVA: 0x7FFD4E3D1DE0
        public void KinematicToActive(){} // RVA: 0x7FFD4E3D1E80
        public void ActiveToDisabled(){} // RVA: 0x7FFD4E3D1F20
        public void ActiveToKinematic(){} // RVA: 0x7FFD4E3D1FC0
        public void SetMuscleWeights(){} // RVA: 0x7FFD4E3D2650 | overloaded x4
        public void SetMuscleWeightsRecursive(){} // RVA: 0x7FFD4E3D25C0 | overloaded x3
        public void GetMuscle(){} // RVA: 0x7FFD4E3D2930 | overloaded x3
        public void ContainsJoint(){} // RVA: 0x7FFD4E3D2980
        public void GetMuscleIndex(){} // RVA: 0x7FFD4E3D3530 | overloaded x4
        public void SetUp(){} // RVA: 0x7FFD4E3D3A70 | overloaded x2
        public void SetUpTo(){} // RVA: 0x7FFD4E3D3D10
        public void RemoveRagdollComponents(){} // RVA: 0x7FFD4E3D5580
        public void SetUpMuscles(){} // RVA: 0x7FFD4E3D5DD0
        public void FindGroup(){} // RVA: 0x7FFD4E3D6A60
        public void RemoveUnnecessaryBones(){} // RVA: 0x7FFD4E3D77F0
        public void IsClothCollider(){} // RVA: 0x7FFD4E3D7E00
        public void get_isSwitchingState(){} // RVA: 0x7FFD4E3D84A0
        public void get_isKilling(){} // RVA: 0x7FFD4E3D84B0
        public void set_isKilling(){} // RVA: 0x7FFD4E3D84C0
        public void get_isAlive(){} // RVA: 0x7FFD4E3D84D0
        public void get_isFrozen(){} // RVA: 0x7FFD4E3D84E0
        public void Kill(){} // RVA: 0x7FFD4E3D8500 | overloaded x2
        public void Freeze(){} // RVA: 0x7FFD4E3D8530 | overloaded x2
        public void Resurrect(){} // RVA: 0x7FFD4E3D8550
        public void SwitchStates(){} // RVA: 0x7FFD4E3D8560
        public void AliveToDead(){} // RVA: 0x7FFD4E3D8860
        public void OnFreezeFlag(){} // RVA: 0x7FFD4E3D8910
        public void DeadToAlive(){} // RVA: 0x7FFD4E3D8FD0
        public void SetAnimationEnabled(){} // RVA: 0x7FFD4E3D9100
        public void DeadToFrozen(){} // RVA: 0x7FFD4E3D9330
        public void FrozenToAlive(){} // RVA: 0x7FFD4E3D9340
        public void FrozenToDead(){} // RVA: 0x7FFD4E3D96F0
        public void ActivateRagdoll(){} // RVA: 0x7FFD4E3D97E0
        public void CanFreeze(){} // RVA: 0x7FFD4E3D9B30
        public void SampleTargetMappedState(){} // RVA: 0x7FFD4E3D9C40
        public void FixTargetToSampledState(){} // RVA: 0x7FFD4E3D9D40
        public void StoreTargetMappedState(){} // RVA: 0x7FFD4E3DA270
        public void UpdateHierarchies(){} // RVA: 0x7FFD4E3DA350
        public void HasProp(){} // RVA: 0x7FFD4E3DA970
        public void UpdateBroadcasterMuscleIndexes(){} // RVA: 0x7FFD4E3DA9D0
        public void AssignParentAndChildIndexes(){} // RVA: 0x7FFD4E3DAC40
        public void AddToParentsRecursive(){} // RVA: 0x7FFD4E3DB1B0
        public void AddToChildrenRecursive(){} // RVA: 0x7FFD4E3DB420
        public void AssignKinshipDegrees(){} // RVA: 0x7FFD4E3DB760
        public void AssignKinshipsDownRecursive(){} // RVA: 0x7FFD4E3DB900
        public void AssignKinshipsUpRecursive(){} // RVA: 0x7FFD4E3DBB20
        public void GetMuscleIndexLowLevel(){} // RVA: 0x7FFD4E3DBF00
        public void IsValid(){} // RVA: 0x7FFD4E3DC0A0
        public void CheckMassVariation(){} // RVA: 0x7FFD4E3DCEE0
        public void CheckIfInitiated(){} // RVA: 0x7FFD4E3DD2B0
        public void .ctor(){} // RVA: 0x7FFD4E3DD330
    }

    public class PuppetMasterHumanoidConfig : ScriptableObject
    {
        public object state; // 0x18
        public hing stateSettings; // 0x1C
        public object mode; // 0x30
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
        public ?[] muscles; // 0x68

        // ── Methods ──
        public void ApplyTo(){} // RVA: 0x7FFD4E3DEA00
        public void GetMuscle(){} // RVA: 0x7FFD4E3DEF30
        public void .ctor(){} // RVA: 0x7FFD4E3DF140
    }

    public class PuppetMasterProp : MonoBehaviour
    {
        public object isPickedUp; // 0x20
        public ÌÍÌÌÎÎÌÏÏÍÎÌÎÎÍÌÏÏÎÏÌÍÏ propMuscle; // 0x28
        public bool forceLayers; // 0x30
        public float mass; // 0x34
        public int propType; // 0x38
        public th pickedUpMaterial; // 0x40
        public amut additionalPinOffsetAdd; // 0x48
        public float additionalPinWeight; // 0x54
        public float additionalPinMass; // 0x58
        public bool <isPickedUp>k__BackingField; // 0x5C
        public ce.projection <propMuscle>k__BackingField; // 0x60
        public int defaultLayer; // 0x68
        public object defaultParent; // 0x70
        public riteCharacterUnicode[] colliders; // 0x78
        public th[] droppedMaterials; // 0x80
        public Touched r; // 0x88
        public float _mass; // 0x90
        public float _drag; // 0x94
        public float _angularDrag; // 0x98
        public bool _useGravity; // 0x9C
        public bool _isKinematic; // 0x9D
        public kAtPositionInternal_Injected _interpolation; // 0xA0
        public imeAnimatorController _collisionDetectionMode; // 0xA4
        public ffectMassCenter _constraints; // 0xA8
        public riteCharacterUnicode[] emptyColliders; // 0xB0

        // ── Methods ──
        public void get_isPickedUp(){} // RVA: 0x7FFD4E3DF240
        public void set_isPickedUp(){} // RVA: 0x7FFD4E3DF250
        public void GetRigidbody(){} // RVA: 0x7FFD4E3DF260
        public void OnPickUp(){} // RVA: 0x7FFD4E341310
        public void OnDrop(){} // RVA: 0x7FFD4E341310
        public void get_propMuscle(){} // RVA: 0x7FFD4E3DF370
        public void set_propMuscle(){} // RVA: 0x7FFD4E3DF380
        public void PickUp(){} // RVA: 0x7FFD4E3DF3E0
        public void Drop(){} // RVA: 0x7FFD4E3DFD20
        public void Awake(){} // RVA: 0x7FFD4E3E0810
        public void Start(){} // RVA: 0x7FFD4E3E0C00
        public void Update(){} // RVA: 0x7FFD4E3E10D0
        public void RemoveRigidbody(){} // RVA: 0x7FFD4E3E12B0
        public void ReattachRigidbody(){} // RVA: 0x7FFD4E3E1690
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD4E3E1A60
        public void .ctor(){} // RVA: 0x7FFD4E3E1EC0
    }

    public class PuppetMasterSettings : Singleton`1
    {
        public te currentlyActivePuppets; // 0x20
        public te currentlyKinematicPuppets; // 0x28
        public te currentlyDisabledPuppets; // 0x30
        public bool puppets; // 0x38
        public bool collisionExitMessages; // 0x39
        public float activePuppetCollisionThresholdMlp; // 0x3C
        public int <currentlyActivePuppets>k__BackingField; // 0x40
        public int <currentlyKinematicPuppets>k__BackingField; // 0x44
        public int <currentlyDisabledPuppets>k__BackingField; // 0x48
        public URA.woDigitYearMax<ce.layAudio> _puppets; // 0x50

        // ── Methods ──
        public void get_currentlyActivePuppets(){} // RVA: 0x7FFD4E3E2080
        public void set_currentlyActivePuppets(){} // RVA: 0x7FFD4E3E2090
        public void get_currentlyKinematicPuppets(){} // RVA: 0x7FFD4E3E20A0
        public void set_currentlyKinematicPuppets(){} // RVA: 0x7FFD4E3E20B0
        public void get_currentlyDisabledPuppets(){} // RVA: 0x7FFD4E3E20C0
        public void set_currentlyDisabledPuppets(){} // RVA: 0x7FFD4E3E20D0
        public void get_puppets(){} // RVA: 0x7FFD4E3E20E0
        public void Register(){} // RVA: 0x7FFD4E3E20F0
        public void Unregister(){} // RVA: 0x7FFD4E3E2200
        public void UpdateMoveToTarget(){} // RVA: 0x7FFD4E3E2260
        public void UpdateFree(){} // RVA: 0x7FFD4E3E2290
        public void UpdateFixed(){} // RVA: 0x7FFD4E3E22C0
        public void Update(){} // RVA: 0x7FFD4E3E22F0
        public void FixedUpdate(){} // RVA: 0x7FFD4E3E2530
        public void .ctor(){} // RVA: 0x7FFD4E3E2590
    }

    public class PuppetMasterTools : Object
    {
        // ── Methods ──
        public void PositionRagdoll(){} // RVA: 0x7FFD4E3E29C0
        public void RealignRagdoll(){} // RVA: 0x7FFD4E3E38B0
        public void DirectionIntToVector3(){} // RVA: 0x7FFD4E388B70
        public void DirectionVector3ToInt(){} // RVA: 0x7FFD4E3E4FA0
    }

    public class RagdollCreator : MonoBehaviour
    {
        // ── Methods ──
        public void ClearAll(){} // RVA: 0x7FFD4E3F2240
        public void ClearTransform(){} // RVA: 0x7FFD4E3F25F0
        public void CreateCollider(){} // RVA: 0x7FFD4E3F3280 | overloaded x2
        public void GetScaleF(){} // RVA: 0x7FFD4E3F3940
        public void Abs(){} // RVA: 0x7FFD4E3F39D0
        public void Vector3Abs(){} // RVA: 0x7FFD4E3F3A20
        public void DirectionIntToVector3(){} // RVA: 0x7FFD4E388B70
        public void DirectionToVector3(){} // RVA: 0x7FFD4E388B70
        public void DirectionVector3ToInt(){} // RVA: 0x7FFD4E3E4FA0
        public void GetLocalOrthoDirection(){} // RVA: 0x7FFD4E3F3A50
        public void GetConnectedBody(){} // RVA: 0x7FFD4E3F3F30
        public void CreateJoint(){} // RVA: 0x7FFD4E3F42F0
        public void ToSoftJointLimit(){} // RVA: 0x7FFD4E3F55D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class RagdollEditor : MonoBehaviour
    {
        public Touched selectedRigidbody; // 0x20
        public riteCharacterUnicode selectedCollider; // 0x28
        public bool symmetry; // 0x30
        public object mode; // 0x34

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void OpenTutorial(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E3F5710
    }

    public class SubBehaviourBalancer : SubBehaviourBase
    {
        public eam joint; // 0x18
        public amut dir; // 0x20
        public amut dirVel; // 0x2C
        public amut cop; // 0x38
        public amut com; // 0x44
        public amut comV; // 0x50
        public Ì settings; // 0x60
        public Touched[] rigidbodies; // 0x68
        public ?[] copPoints; // 0x70
        public ce.Event pressureSensor; // 0x78
        public Touched Ibody; // 0x80
        public amut I; // 0x88
        public R_12x12 toJointSpace; // 0x94

        // ── Methods ──
        public void get_joint(){} // RVA: 0x7FFD4E3447C0
        public void set_joint(){} // RVA: 0x7FFD4E3A7E80
        public void get_dir(){} // RVA: 0x7FFD4E3A7EE0
        public void set_dir(){} // RVA: 0x7FFD4E3A7F00
        public void get_dirVel(){} // RVA: 0x7FFD4E3A7F10
        public void set_dirVel(){} // RVA: 0x7FFD4E3A7F30
        public void get_cop(){} // RVA: 0x7FFD4E3A7F40
        public void set_cop(){} // RVA: 0x7FFD4E3A7F60
        public void get_com(){} // RVA: 0x7FFD4E3A7F70
        public void set_com(){} // RVA: 0x7FFD4E3A7F90
        public void get_comV(){} // RVA: 0x7FFD4E3A7FA0
        public void set_comV(){} // RVA: 0x7FFD4E3A7FC0
        public void Initiate(){} // RVA: 0x7FFD4E3A7FD0
        public void Solve(){} // RVA: 0x7FFD4E3A83A0
        public void .ctor(){} // RVA: 0x7FFD4E3A9250
    }

    public class SubBehaviourBase : Object
    {
        public ce.cond behaviour; // 0x10

        // ── Methods ──
        public void XZ(){} // RVA: 0x7FFD4E3A93D0
        public void XYZ(){} // RVA: 0x7FFD4E3A93F0
        public void Flatten(){} // RVA: 0x7FFD4E3A9420
        public void SetY(){} // RVA: 0x7FFD4E3A9440
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SubBehaviourCOM : SubBehaviourBase
    {
        public object position; // 0x18
        public float direction; // 0x1C
        public float angle; // 0x20
        public float velocity; // 0x24
        public float centerOfPressure; // 0x28
        public amut rotation; // 0x2C
        public amut inverseRotation; // 0x38
        public amut isGrounded; // 0x44
        public float lastGroundedTime; // 0x50
        public amut <velocity>k__BackingField; // 0x54
        public amut <centerOfPressure>k__BackingField; // 0x60
        public R_12x12 <rotation>k__BackingField; // 0x6C
        public R_12x12 <inverseRotation>k__BackingField; // 0x7C
        public bool <isGrounded>k__BackingField; // 0x8C
        public float <lastGroundedTime>k__BackingField; // 0x90
        public bool[] groundContacts; // 0x98
        public amut[] groundContactPoints; // 0xA0
        public object groundLayers; // 0xA8

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFD4E3A7F40
        public void set_position(){} // RVA: 0x7FFD4E3A7F60
        public void get_direction(){} // RVA: 0x7FFD4E3A7F70
        public void set_direction(){} // RVA: 0x7FFD4E3A7F90
        public void get_angle(){} // RVA: 0x7FFD4E3A9460
        public void set_angle(){} // RVA: 0x7FFD4E3A9470
        public void get_velocity(){} // RVA: 0x7FFD4E3A9480
        public void set_velocity(){} // RVA: 0x7FFD4E3A94A0
        public void get_centerOfPressure(){} // RVA: 0x7FFD4E3A94B0
        public void set_centerOfPressure(){} // RVA: 0x7FFD4E3A94D0
        public void get_rotation(){} // RVA: 0x7FFD4E3A94E0
        public void set_rotation(){} // RVA: 0x7FFD4E3A94F0
        public void get_inverseRotation(){} // RVA: 0x7FFD4E3A9500
        public void set_inverseRotation(){} // RVA: 0x7FFD4E3A9510
        public void get_isGrounded(){} // RVA: 0x7FFD4E3A9520
        public void set_isGrounded(){} // RVA: 0x7FFD4E3A9530
        public void get_lastGroundedTime(){} // RVA: 0x7FFD4E3A9540
        public void set_lastGroundedTime(){} // RVA: 0x7FFD4E3A9550
        public void Initiate(){} // RVA: 0x7FFD4E3A9560
        public void OnHierarchyChanged(){} // RVA: 0x7FFD4E3A9D20
        public void OnPreMuscleCollision(){} // RVA: 0x7FFD4E3A9DD0
        public void OnPreMuscleCollisionExit(){} // RVA: 0x7FFD4E3AA090
        public void OnPreActivate(){} // RVA: 0x7FFD4E3AA1E0
        public void OnPreLateUpdate(){} // RVA: 0x7FFD4E3AA320
        public void OnPreDeactivate(){} // RVA: 0x7FFD4E3AABE0
        public void GetCollisionCOP(){} // RVA: 0x7FFD4E3AAC30
        public void IsGrounded(){} // RVA: 0x7FFD4E3AAD90
        public void GetCenterOfMass(){} // RVA: 0x7FFD4E3AADF0
        public void GetCenterOfMassVelocity(){} // RVA: 0x7FFD4E3AB080
        public void GetMomentum(){} // RVA: 0x7FFD4E3AB420
        public void GetCenterOfPressure(){} // RVA: 0x7FFD4E3AB6A0
        public void GetFeetCentroid(){} // RVA: 0x7FFD4E3AB800
        public void .ctor(){} // RVA: 0x7FFD4E3ABA50
    }

    public class Weight : Object
    {
        public object mode; // 0x10
        public float floatValue; // 0x14
        public ÍÎÌÍÍÌÌÎÏÏ curve; // 0x18
        public string tooltip; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3E51C0 | overloaded x2
        public void GetValue(){} // RVA: 0x7FFD4E3E52C0
    }

}