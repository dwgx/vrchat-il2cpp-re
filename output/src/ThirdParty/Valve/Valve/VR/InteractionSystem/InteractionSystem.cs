// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.InteractionSystem
// Classes: 77
// Methods: 699

namespace ThirdParty.Valve.Valve.VR.InteractionSystem
{
    public class AfterTimer_Component : MonoBehaviour
    {
        public object callback;
        public object triggerTime;
        public object timerActive;
        public object triggerOnEarlyDestroy;

        // ── Methods ──
        public void Init(){} // RVA: 0x6FCAA90
        public void Wait(){} // RVA: 0x6FCAB10
        public void OnDestroy(){} // RVA: 0x6FCABB0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class AllowTeleportWhileAttachedToHand : MonoBehaviour
    {
        public object teleportAllowed;
        public object overrideHoverLock;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F6C020
    }

    public class ArcheryTarget : MonoBehaviour
    {
        public object onTakeDamage;
        public object onceOnly;
        public object targetCenter;
        public object baseTransform;
        public object fallenDownTransform;
        public object fallTime;
        public object targetRadius;
        public object targetEnabled;

        // ── Methods ──
        public void ApplyDamage(){} // RVA: 0x6FD4250
        public void FireExposure(){} // RVA: 0x6FD4250
        public void OnDamageTaken(){} // RVA: 0x6FD4260
        public void FallDown(){} // RVA: 0x6FD4340
        public void .ctor(){} // RVA: 0x6FD43E0
    }

    public class Arrow : MonoBehaviour
    {
        public object glintParticle;
        public object arrowHeadRB;
        public object shaftRB;
        public object targetPhysMaterial;
        public object prevPosition;
        public object prevRotation;
        public object prevVelocity;
        public object prevHeadPosition;
        public object fireReleaseSound;
        public object airReleaseSound;
        public object hitTargetSound;
        public object hitGroundSound;
        public object inFlight;
        public object released;
        public object hasSpreadFire;
        public object travelledFrames;
        public object scaleParentObject;
        public object initialMass;
        public object initialDrag;
        public object initialAngularDrag;
        public object initialInterpolation;
        public object initialCollisionDetection;
        public object initialUseGravity;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FD48E0
        public void Start(){} // RVA: 0x6FD4D10
        public void FixedUpdate(){} // RVA: 0x6FD4DE0
        public void StartRelease(){} // RVA: 0x6FD50F0
        public void ArrowReleased(){} // RVA: 0x6FD5340
        public void SetCollisionMode(){} // RVA: 0x6FD5D30
        public void OnCollisionEnter(){} // RVA: 0x6FD5EA0
        public void StickInTarget(){} // RVA: 0x6FD6EF0
        public void OnDestroy(){} // RVA: 0x6FD7ED0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class ArrowHand : MonoBehaviour
    {
        public object hand;
        public object bow;
        public object currentArrow;
        public object arrowPrefab;
        public object arrowNockTransform;
        public object nockDistance;
        public object lerpCompleteDistance;
        public object rotationLerpThreshold;
        public object positionLerpThreshold;
        public object allowArrowSpawn;
        public object nocked;
        public object nockedWithType;
        public object inNockRange;
        public object arrowLerpComplete;
        public object arrowSpawnSound;
        public object allowTeleport;
        public object maxArrowCount;
        public object arrowList;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FD81B0
        public void OnAttachedToHand(){} // RVA: 0x6FD8310
        public void InstantiateArrow(){} // RVA: 0x6FD8370
        public void HandAttachedUpdate(){} // RVA: 0x6FD8750
        public void OnDetachedFromHand(){} // RVA: 0x6FD98F0
        public void FireArrow(){} // RVA: 0x6FD9990
        public void EnableArrowSpawn(){} // RVA: 0xCFEDE0
        public void ArrowReleaseHaptics(){} // RVA: 0x6FDA2C0
        public void OnHandFocusLost(){} // RVA: 0xD2E040
        public void OnHandFocusAcquired(){} // RVA: 0x198BA60
        public void FindBow(){} // RVA: 0x6FDA360
        public void .ctor(){} // RVA: 0x6FDA400
    }

    public class ArrowheadRotation : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x6FDA6B0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class Balloon : MonoBehaviour
    {
        public object hand;
        public object popPrefab;
        public object maxVelocity;
        public object lifetime;
        public object burstOnLifetimeEnd;
        public object lifetimeEndParticlePrefab;
        public object lifetimeEndSound;
        public object destructTime;
        public object releaseTime;
        public object collisionSound;
        public object lastSoundTime;
        public object soundDelay;
        public object balloonRigidbody;
        public object bParticlesSpawned;
        public object s_flLastDeathSound;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FDA760
        public void Update(){} // RVA: 0x6FDA920
        public void SpawnParticles(){} // RVA: 0x6FDAA40
        public void FixedUpdate(){} // RVA: 0x6FDAEC0
        public void ApplyDamage(){} // RVA: 0x6FDB100
        public void OnCollisionEnter(){} // RVA: 0x6FDB1B0
        public void SetColor(){} // RVA: 0x6FDB8A0
        public void BalloonColorToRGB(){} // RVA: 0x6FDB940
        public void .ctor(){} // RVA: 0x6FDBB50
    }

    public class BalloonColliders : MonoBehaviour
    {
        public object colliders;
        public object colliderLocalPositions;
        public object colliderLocalRotations;
        public object rb;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FDBBB0
        public void OnEnable(){} // RVA: 0x6FDC210
        public void OnDisable(){} // RVA: 0x6FDCC10
        public void OnDestroy(){} // RVA: 0x6FDCDD0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class BalloonHapticBump : MonoBehaviour
    {
        public object physParent;

        // ── Methods ──
        public void OnCollisionEnter(){} // RVA: 0x6FDCEE0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class BalloonSpawner : MonoBehaviour
    {
        public object minSpawnTime;
        public object maxSpawnTime;
        public object nextSpawnTime;
        public object balloonPrefab;
        public object autoSpawn;
        public object spawnAtStartup;
        public object playSounds;
        public object inflateSound;
        public object stretchSound;
        public object sendSpawnMessageToParent;
        public object scale;
        public object spawnDirectionTransform;
        public object spawnForce;
        public object attachBalloon;
        public object color;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FDD110
        public void Update(){} // RVA: 0x6FDD230
        public void SpawnBalloon(){} // RVA: 0x6FDD390
        public void SpawnBalloonFromEvent(){} // RVA: 0x6FDDC00
        public void .ctor(){} // RVA: 0x6FDDC10
    }

    public class BodyCollider : MonoBehaviour
    {
        public object head;
        public object capsuleCollider;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6F92150
        public void FixedUpdate(){} // RVA: 0x6F921E0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class ChaperoneInfo : MonoBehaviour
    {
        public object _initialized;
        public object _playAreaSizeX;
        public object _playAreaSizeZ;
        public object _roomscale;
        public object Initialized;
        public object _instance;

        // ── Methods ──
        public void get_initialized(){} // RVA: 0xC38360
        public void set_initialized(){} // RVA: 0xC38370
        public void get_playAreaSizeX(){} // RVA: 0xCBAD90
        public void set_playAreaSizeX(){} // RVA: 0xCBADA0
        public void get_playAreaSizeZ(){} // RVA: 0xC27360
        public void set_playAreaSizeZ(){} // RVA: 0xC27370
        public void get_roomscale(){} // RVA: 0xC27380
        public void set_roomscale(){} // RVA: 0xC27390
        public void InitializedAction(){} // RVA: 0x6FE2DA0
        public void get_instance(){} // RVA: 0x6FE2E40
        public void Start(){} // RVA: 0x6FE3160
        public void .ctor(){} // RVA: 0xB43D60
        public void .cctor(){} // RVA: 0x6FE3200
    }

    public class CircularDrive : MonoBehaviour
    {
        public object axisOfRotation;
        public object childCollider;
        public object linearMapping;
        public object hoverLock;
        public object limited;
        public object frozenDistanceMinMaxThreshold;
        public object onFrozenDistanceThreshold;
        public object minAngle;
        public object freezeOnMin;
        public object onMinAngle;
        public object maxAngle;
        public object freezeOnMax;
        public object onMaxAngle;
        public object forceStart;
        public object startAngle;
        public object rotateGameObject;
        public object debugPath;
        public object dbgPathLimit;
        public object debugText;
        public object outAngle;
        public object start;
        public object worldPlaneNormal;
        public object localPlaneNormal;
        public object lastHandProjected;
        public object red;
        public object green;
        public object dbgHandObjects;
        public object dbgProjObjects;
        public object dbgObjectsParent;
        public object dbgObjectCount;
        public object dbgObjectIndex;
        public object driving;
        public object minMaxAngularThreshold;
        public object frozen;
        public object frozenAngle;
        public object frozenHandWorldPos;
        public object frozenSqDistanceMinMaxThreshold;
        public object handHoverLocked;
        public object interactable;
        public object grabbedWithType;

        // ── Methods ──
        public void Freeze(){} // RVA: 0x6F92580
        public void UnFreeze(){} // RVA: 0x6F926A0
        public void Awake(){} // RVA: 0x6F926C0
        public void Start(){} // RVA: 0x6F92760
        public void OnDisable(){} // RVA: 0x6F930E0
        public void HapticPulses(){} // RVA: 0x6F93250
        public void OnHandHoverBegin(){} // RVA: 0x6F93310
        public void OnHandHoverEnd(){} // RVA: 0x6F93330
        public void HandHoverUpdate(){} // RVA: 0x6F934B0
        public void ComputeToTransformProjected(){} // RVA: 0x6F93780
        public void DrawDebugPath(){} // RVA: 0x6F93BF0
        public void UpdateLinearMapping(){} // RVA: 0x6F949B0
        public void UpdateGameObject(){} // RVA: 0x6F94A40
        public void UpdateDebugText(){} // RVA: 0x6F94CE0
        public void UpdateAll(){} // RVA: 0x6F94E90
        public void ComputeAngle(){} // RVA: 0x6F94F30
        public void .ctor(){} // RVA: 0x6F95460
    }

    public class ComplexThrowable : MonoBehaviour
    {
        public object attachForce;
        public object attachForceDamper;
        public object attachMode;
        public object attachmentFlags;
        public object holdingHands;
        public object holdingBodies;
        public object holdingPoints;
        public object rigidBodies;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6F95800
        public void Update(){} // RVA: 0x6F95880
        public void OnHandHoverBegin(){} // RVA: 0x6F95A40
        public void OnHandHoverEnd(){} // RVA: 0x6F95B20
        public void HandHoverUpdate(){} // RVA: 0x6F95C00
        public void PhysicsAttach(){} // RVA: 0x6F95C50
        public void PhysicsDetach(){} // RVA: 0x6F96B20
        public void FixedUpdate(){} // RVA: 0x6F96E20
        public void .ctor(){} // RVA: 0x6F975E0
    }

    public class ControllerButtonHints : MonoBehaviour
    {
        public object controllerMaterial;
        public object urpControllerMaterial;
        public object flashColor;
        public object textHintPrefab;
        public object hapticFlash;
        public object autoSetWithControllerRangeOfMotion;
        public object debugHints;
        public object renderModel;
        public object player;
        public object renderers;
        public object flashingRenderers;
        public object startTime;
        public object tickCount;
        public object actionHintInfos;
        public object textHintParent;
        public object colorID;
        public object _initialized;
        public object centerPosition;
        public object renderModelLoadedAction;
        public object inputSource;
        public object componentTransformMap;

        // ── Methods ──
        public void get_usingMaterial(){} // RVA: 0xB700F0
        public void get_initialized(){} // RVA: 0x6D98D80
        public void set_initialized(){} // RVA: 0x6D98D90
        public void Awake(){} // RVA: 0x6FCBF00
        public void Start(){} // RVA: 0x6FCC010
        public void HintDebugLog(){} // RVA: 0x6FCC080
        public void OnEnable(){} // RVA: 0x6FCC110
        public void OnDisable(){} // RVA: 0x6FCC140
        public void OnParentHandInputFocusLost(){} // RVA: 0x6FCC180
        public void SetInputSource(){} // RVA: 0x6FCC1A0
        public void OnHandInitialized(){} // RVA: 0x6FCC290
        public void OnRenderModelLoaded(){} // RVA: 0x6FCC710
        public void DoInitialize(){} // RVA: 0x6FCCA20
        public void CreateAndAddButtonInfo(){} // RVA: 0x6FCCB20
        public void ComputeTextEndTransforms(){} // RVA: 0x6FCEC10
        public void ShowButtonHint(){} // RVA: 0x6FD2210
        public void HideAllButtonHints(){} // RVA: 0x6FD23F0
        public void HideButtonHint(){} // RVA: 0x6FD2300
        public void IsButtonHintActive(){} // RVA: 0x6FD24D0
        public void TestButtonHints(){} // RVA: 0x6FD0840
        public void TestTextHints(){} // RVA: 0x6FD08E0
        public void Update(){} // RVA: 0x6FD0980
        public void UpdateTextHint(){} // RVA: 0x6FD0FB0
        public void Clear(){} // RVA: 0x6FD1820
        public void ShowText(){} // RVA: 0x6FD18B0
        public void HideText(){} // RVA: 0x6FD1BC0
        public void HideAllText(){} // RVA: 0x6FD1D00
        public void GetActiveHintText(){} // RVA: 0x6FD2B40
        public void GetControllerButtonHints(){} // RVA: 0x6FD2080
        public void ShowTextHint(){} // RVA: 0x6FD25C0
        public void HideTextHint(){} // RVA: 0x6FD2790
        public void HideAllTextHints(){} // RVA: 0x6FD2A60
        public void .ctor(){} // RVA: 0x6FD2D10
    }

    public class ControllerHoverHighlight : MonoBehaviour
    {
        public object highLightMaterial;
        public object fireHapticsOnHightlight;
        public object hand;
        public object renderModel;
        public object renderModelLoadedAction;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6F97890
        public void OnHandInitialized(){} // RVA: 0x6F97920
        public void RenderModel_onControllerLoaded(){} // RVA: 0x6F98020
        public void OnParentHandHoverBegin(){} // RVA: 0x6F98060
        public void OnParentHandHoverEnd(){} // RVA: 0x6F98260
        public void OnParentHandInputFocusAcquired(){} // RVA: 0x6F98270
        public void OnParentHandInputFocusLost(){} // RVA: 0x6F98260
        public void ShowHighlight(){} // RVA: 0x6F98530
        public void HideHighlight(){} // RVA: 0x6F986A0
        public void .ctor(){} // RVA: 0xB79A60
    }

    public class DebugUI : MonoBehaviour
    {
        public object player;
        public object _instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x6F988C0
        public void Start(){} // RVA: 0x6F98A50
        public void OnGUI(){} // RVA: 0x6F98AC0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class DestroyOnDetachedFromHand : MonoBehaviour
    {
        // ── Methods ──
        public void OnDetachedFromHand(){} // RVA: 0x6F98B70
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class DestroyOnParticleSystemDeath : MonoBehaviour
    {
        public object particles;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6F98C10
        public void CheckParticleSystem(){} // RVA: 0x6F98CD0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class DestroyOnTriggerEnter : MonoBehaviour
    {
        public object tagFilter;
        public object useTag;

        // ── Methods ──
        public void Start(){} // RVA: 0x6F98D90
        public void OnTriggerEnter(){} // RVA: 0x6F98DB0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class DistanceHaptics : MonoBehaviour
    {
        public object firstTransform;
        public object secondTransform;
        public object distanceIntensityCurve;
        public object pulseIntervalCurve;

        // ── Methods ──
        public void Start(){} // RVA: 0x6F98F10
        public void .ctor(){} // RVA: 0x6F98FB0
    }

    public class DontDestroyOnLoad : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6F995C0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class EnumFlags : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF48510
    }

    public class Equippable : MonoBehaviour
    {
        public object antiFlip;
        public object defaultHand;
        public object initialScale;
        public object interactable;

        // ── Methods ──
        public void get_attachedHandType(){} // RVA: 0x6F99610
        public void Start(){} // RVA: 0x6F99720
        public void Update(){} // RVA: 0x6F99880
        public void .ctor(){} // RVA: 0x6F99D70
    }

    public class ExplosionWobble : MonoBehaviour
    {
        // ── Methods ──
        public void ExplosionEvent(){} // RVA: 0x6FDDC80
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class FallbackCameraController : MonoBehaviour
    {
        public object speed;
        public object shiftSpeed;
        public object showInstructions;
        public object startEulerAngles;
        public object startMousePosition;
        public object realTime;

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x6F99DC0
        public void Update(){} // RVA: 0x6F99E20
        public void OnGUI(){} // RVA: 0x6F9A760
        public void .ctor(){} // RVA: 0x6F9A7E0
    }

    public class FireSource : MonoBehaviour
    {
        public object fireParticlePrefab;
        public object startActive;
        public object fireObject;
        public object customParticles;
        public object isBurning;
        public object burnTime;
        public object ignitionDelay;
        public object ignitionTime;
        public object hand;
        public object ignitionSound;
        public object canSpreadFromThisSource;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FDDE20
        public void Update(){} // RVA: 0x6FDDE30
        public void OnTriggerEnter(){} // RVA: 0x6FDDFC0
        public void FireExposure(){} // RVA: 0x6FDE040
        public void StartBurning(){} // RVA: 0x6FDE290
        public void .ctor(){} // RVA: 0x19D4620
    }

    public class Hand : MonoBehaviour
    {
        public object defaultAttachmentFlags;
        public object otherHand;
        public object handType;
        public object trackedObject;
        public object grabPinchAction;
        public object grabGripAction;
        public object hapticAction;
        public object uiInteractAction;
        public object useHoverSphere;
        public object hoverSphereTransform;
        public object hoverSphereRadius;
        public object hoverLayerMask;
        public object hoverUpdateInterval;
        public object useControllerHoverComponent;
        public object controllerHoverComponent;
        public object controllerHoverRadius;
        public object useFingerJointHover;
        public object fingerJointHover;
        public object fingerJointHoverRadius;
        public object objectAttachmentPoint;
        public object noSteamVRFallbackCamera;
        public object noSteamVRFallbackMaxDistanceNoItem;
        public object noSteamVRFallbackMaxDistanceWithItem;
        public object noSteamVRFallbackInteractorDistance;
        public object renderModelPrefab;
        public object renderModels;
        public object mainRenderModel;
        public object hoverhighlightRenderModel;
        public object showDebugText;
        public object spewDebugText;
        public object showDebugInteractables;
        public object attachedObjects;
        public object _hoverLocked;
        public object _hoveringInteractable;
        public object debugText;
        public object prevOverlappingColliders;
        public object ColliderArraySize;
        public object overlappingColliders;
        public object playerInstance;
        public object applicationLostFocusObject;
        public object inputFocusAction;
        public object MaxVelocityChange;
        public object VelocityMagic;
        public object AngularVelocityMagic;
        public object MaxAngularVelocityChange;

        // ── Methods ──
        public void get_AttachedObjects(){} // RVA: 0x6F9A840
        public void get_hoverLocked(){} // RVA: 0xC77E50
        public void set_hoverLocked(){} // RVA: 0xC77E60
        public void get_isActive(){} // RVA: 0x6F9A910
        public void get_isPoseValid(){} // RVA: 0x6F9AA50
        public void get_hoveringInteractable(){} // RVA: 0xBC5BA0
        public void set_hoveringInteractable(){} // RVA: 0x6F9AAA0
        public void get_currentAttachedObject(){} // RVA: 0x6F9B050
        public void get_currentAttachedObjectInfo(){} // RVA: 0x6F9B110
        public void get_currentAttachedTeleportManager(){} // RVA: 0x6F9B370
        public void get_skeleton(){} // RVA: 0x6F9B410
        public void ShowController(){} // RVA: 0x6F9B500
        public void HideController(){} // RVA: 0x6F9B6B0
        public void ShowSkeleton(){} // RVA: 0x6F9B860
        public void HideSkeleton(){} // RVA: 0x6F9BA10
        public void HasSkeleton(){} // RVA: 0x6F9BBC0
        public void Show(){} // RVA: 0x6F9BD60
        public void Hide(){} // RVA: 0x6F9BD70
        public void SetVisibility(){} // RVA: 0x6F9BD80
        public void SetSkeletonRangeOfMotion(){} // RVA: 0x6F9BE80
        public void SetTemporarySkeletonRangeOfMotion(){} // RVA: 0x6F9BF70
        public void ResetTemporarySkeletonRangeOfMotion(){} // RVA: 0x6F9C1A0
        public void SetAnimationState(){} // RVA: 0x6F9C280
        public void StopAnimation(){} // RVA: 0x6F9C490
        public void AttachObject(){} // RVA: 0x6F9C690
        public void ObjectIsAttached(){} // RVA: 0x6F9EC60
        public void ForceHoverUnlock(){} // RVA: 0x112C690
        public void DetachObject(){} // RVA: 0x6F9EE60
        public void GetTrackedObjectVelocity(){} // RVA: 0x6FA0550
        public void GetTrackedObjectAngularVelocity(){} // RVA: 0x6FA0A10
        public void GetEstimatedPeakVelocities(){} // RVA: 0x6FA0ED0
        public void CleanUpAttachedObjectStack(){} // RVA: 0x6FA10C0
        public void Awake(){} // RVA: 0x6FA1240
        public void OnDestroy(){} // RVA: 0x6FA19A0
        public void OnTransformUpdated(){} // RVA: 0x487D930
        public void Start(){} // RVA: 0x6FA1B80
        public void UpdateHovering(){} // RVA: 0x6FA1C20
        public void CheckHoveringForTransform(){} // RVA: 0x6FA2190
        public void UpdateNoSteamVRFallback(){} // RVA: 0x6FA2E60
        public void UpdateDebugText(){} // RVA: 0x6FA3690
        public void OnEnable(){} // RVA: 0x6FA41E0
        public void OnDisable(){} // RVA: 0x6FA4370
        public void Update(){} // RVA: 0x6FA4450
        public void IsStillHovering(){} // RVA: 0x6FA4640
        public void HandFollowUpdate(){} // RVA: 0x6FA4780
        public void FixedUpdate(){} // RVA: 0x6FA5D00
        public void UpdateAttachedVelocity(){} // RVA: 0x6FA67C0
        public void ResetAttachedTransform(){} // RVA: 0x6FA6C20
        public void TargetItemPosition(){} // RVA: 0x6FA6E90
        public void TargetItemRotation(){} // RVA: 0x6FA7520
        public void GetUpdatedAttachedVelocities(){} // RVA: 0x6FA7FE0
        public void OnInputFocus(){} // RVA: 0x6FA87F0
        public void OnDrawGizmos(){} // RVA: 0x6FA8910
        public void HandDebugLog(){} // RVA: 0x6FA8F40
        public void HoverLock(){} // RVA: 0x6FA9000
        public void HoverUnlock(){} // RVA: 0x6FA90B0
        public void TriggerHapticPulse(){} // RVA: 0x6FA92A0
        public void ShowGrabHint(){} // RVA: 0x6FA93F0
        public void HideGrabHint(){} // RVA: 0x6FA93E0
        public void GetGrabStarting(){} // RVA: 0x6FA9420
        public void GetGrabEnding(){} // RVA: 0x6FA9820
        public void IsGrabEnding(){} // RVA: 0x6FA9AF0
        public void IsGrabbingWithType(){} // RVA: 0x6FA9D90
        public void IsGrabbingWithOppositeType(){} // RVA: 0x6FA9F20
        public void GetBestGrabbingType(){} // RVA: 0x6FAA0C0
        public void InitController(){} // RVA: 0x6FAA290
        public void SetRenderModel(){} // RVA: 0x6FAB330
        public void SetHoverRenderModel(){} // RVA: 0x6FAB4A0
        public void GetDeviceIndex(){} // RVA: 0x6FAB550
        public void .ctor(){} // RVA: 0x6FAB5A0
    }

    public class HandCollider : MonoBehaviour
    {
        public object rigidbody;
        public object hand;
        public object collisionMask;
        public object colliders;
        public object fingerColliders;
        public object physicMaterial_lowfriction;
        public object physicMaterial_highfriction;
        public object scale;
        public object center;
        public object targetPosition;
        public object targetRotation;
        public object MaxVelocityChange;
        public object VelocityMagic;
        public object AngularVelocityMagic;
        public object MaxAngularVelocityChange;
        public object collidersInRadius;
        public object minCollisionEnergy;
        public object maxCollisionEnergy;
        public object minCollisionHapticsTime;
        public object lastCollisionHapticsTime;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FAC1B0
        public void Start(){} // RVA: 0x6FAC260
        public void SetPhysicMaterial(){} // RVA: 0x6FAC800
        public void SetCollisionDetectionEnabled(){} // RVA: 0x6FAC9D0
        public void MoveTo(){} // RVA: 0x6FAC9F0
        public void TeleportTo(){} // RVA: 0x6FACA10
        public void Reset(){} // RVA: 0x6FACD30
        public void SetCenterPoint(){} // RVA: 0x6FACD70
        public void ExecuteFixedUpdate(){} // RVA: 0x6FACD80
        public void GetTargetVelocities(){} // RVA: 0x6FAD470
        public void OnCollisionEnter(){} // RVA: 0x6FADA20
        public void .ctor(){} // RVA: 0x6FADD10
    }

    public class HandEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6FAC170
    }

    public class HandPhysics : MonoBehaviour
    {
        public object handColliderPrefab;
        public object handCollider;
        public object clearanceCheckMask;
        public object hand;
        public object handResetDistance;
        public object collisionReenableClearanceRadius;
        public object initialized;
        public object collisionsEnabled;
        public object wristToRoot;
        public object rootToArmature;
        public object wristToArmature;
        public object targetPosition;
        public object targetRotation;
        public object wristBone;
        public object rootBone;
        public object clearanceBuffer;
        public object wrist;
        public object thumbBone;
        public object indexBone;
        public object middleBone;
        public object ringBone;
        public object pinkyBone;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FAE0A0
        public void FixedUpdate(){} // RVA: 0x6FAE6B0
        public void UpdateCenterPoint(){} // RVA: 0x6FAE940
        public void UpdatePositions(){} // RVA: 0x6FAEC70
        public void UpdateFingertips(){} // RVA: 0x6FAFEA0
        public void UpdateHand(){} // RVA: 0x6FB03B0
        public void ProcessPos(){} // RVA: 0x6FB09C0
        public void ProcessRot(){} // RVA: 0x6FB0B40
        public void .ctor(){} // RVA: 0x6FB0C00
    }

    public class Hand[] : Array
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

    public class HapticRack : MonoBehaviour
    {
        public object linearMapping;
        public object teethCount;
        public object minimumPulseDuration;
        public object maximumPulseDuration;
        public object onPulse;
        public object hand;
        public object previousToothIndex;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FB0D60
        public void OnHandHoverBegin(){} // RVA: 0xB6A8C0
        public void OnHandHoverEnd(){} // RVA: 0x64D9B70
        public void Update(){} // RVA: 0x6FB0EA0
        public void Pulse(){} // RVA: 0x6FB1020
        public void .ctor(){} // RVA: 0x6FB1160
    }

    public class HideOnHandFocusLost : MonoBehaviour
    {
        // ── Methods ──
        public void OnHandFocusLost(){} // RVA: 0xD2E040
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class HoverButton : MonoBehaviour
    {
        public object movingPart;
        public object localMoveDistance;
        public object engageAtPercent;
        public object disengageAtPercent;
        public object onButtonDown;
        public object onButtonUp;
        public object onButtonIsPressed;
        public object engaged;
        public object buttonDown;
        public object buttonUp;
        public object startPosition;
        public object endPosition;
        public object handEnteredPosition;
        public object hovering;
        public object lastHoveredHand;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FB11C0
        public void HandHoverUpdate(){} // RVA: 0x6FB1420
        public void LateUpdate(){} // RVA: 0x6FB1B60
        public void InvokeEvents(){} // RVA: 0x6FB1CD0
        public void .ctor(){} // RVA: 0x6FB1DB0
    }

    public class IgnoreHovering : MonoBehaviour
    {
        public object onlyIgnoreHand;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class IgnoreTeleportTrace : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class InputModule : BaseInputModule
    {
        public object submitObject;
        public object _instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x6FB1E20
        public void ShouldActivateModule(){} // RVA: 0x6FB1FB0
        public void HoverBegin(){} // RVA: 0x6FB20A0
        public void HoverEnd(){} // RVA: 0x6FB21A0
        public void Submit(){} // RVA: 0xC0FFD0
        public void Process(){} // RVA: 0x6FB22C0
        public void .ctor(){} // RVA: 0x6FB2490
    }

    public class Interactable : MonoBehaviour
    {
        public object activateActionSetOnAttach;
        public object hideHandOnAttach;
        public object hideSkeletonOnAttach;
        public object hideControllerOnAttach;
        public object handAnimationOnPickup;
        public object setRangeOfMotionOnPickup;
        public object onAttachedToHand;
        public object onDetachedFromHand;
        public object useHandObjectAttachmentPoint;
        public object attachEaseIn;
        public object snapAttachEaseInCurve;
        public object snapAttachEaseInTime;
        public object snapAttachEaseInCompleted;
        public object skeletonPoser;
        public object handFollowTransform;
        public object highlightOnHover;
        public object highlightRenderers;
        public object existingRenderers;
        public object highlightHolder;
        public object highlightSkinnedRenderers;
        public object existingSkinnedRenderers;
        public object highlightMat;
        public object hideHighlight;
        public object hoverPriority;
        public object attachedToHand;
        public object hoveringHands;
        public object _isDestroying;
        public object _isHovering;
        public object _wasHovering;
        public object blendToPoseTime;
        public object releasePoseBlendTime;

        // ── Methods ──
        public void add_onAttachedToHand(){} // RVA: 0x6FB24A0
        public void remove_onAttachedToHand(){} // RVA: 0x6FB2590
        public void add_onDetachedFromHand(){} // RVA: 0x6FB2680
        public void remove_onDetachedFromHand(){} // RVA: 0x6FB2770
        public void get_hoveringHand(){} // RVA: 0x6FB2860
        public void get_isDestroying(){} // RVA: 0x20119F0
        public void set_isDestroying(){} // RVA: 0x2013510
        public void get_isHovering(){} // RVA: 0x2558540
        public void set_isHovering(){} // RVA: 0x421A230
        public void get_wasHovering(){} // RVA: 0x6FB28F0
        public void set_wasHovering(){} // RVA: 0x6FB2900
        public void Awake(){} // RVA: 0x6FB2910
        public void Start(){} // RVA: 0x6FB29A0
        public void ShouldIgnoreHighlight(){} // RVA: 0x6FB2DA0
        public void ShouldIgnore(){} // RVA: 0x6FB2DE0
        public void CreateHighlightRenderers(){} // RVA: 0x6FB2F80
        public void UpdateHighlightRenderers(){} // RVA: 0x6FB3950
        public void OnHandHoverBegin(){} // RVA: 0x6FB45D0
        public void OnHandHoverEnd(){} // RVA: 0x6FB4680
        public void Update(){} // RVA: 0x6FB4800
        public void OnAttachedToHand(){} // RVA: 0x6FB4930
        public void OnDetachedFromHand(){} // RVA: 0x6FB4CF0
        public void OnDestroy(){} // RVA: 0x6FB5220
        public void OnDisable(){} // RVA: 0x6FB5450
        public void .ctor(){} // RVA: 0x6FB5640
    }

    public class InteractableDebug : MonoBehaviour
    {
        public object attachedToHand;
        public object simulateReleasesForXSecondsAroundRelease;
        public object simulateReleasesEveryXSeconds;
        public object setPositionsForSimulations;
        public object selfRenderers;
        public object colliders;
        public object lastColor;
        public object throwable;
        public object onlyColorOnChange;
        public object rigidbody;
        public object isSimulation;

        // ── Methods ──
        public void get_isThrowable(){} // RVA: 0x6FB5860
        public void Awake(){} // RVA: 0x6FB5930
        public void OnAttachedToHand(){} // RVA: 0x6FB5B30
        public void HandAttachedUpdate(){} // RVA: 0x6FB5BB0
        public void OnDetachedFromHand(){} // RVA: 0x6FB5D20
        public void GetColliders(){} // RVA: 0xBC1B30
        public void IgnoreObject(){} // RVA: 0x6FB62E0
        public void SetIsSimulation(){} // RVA: 0x5A44CB0
        public void CreateSimulation(){} // RVA: 0x6FB6400
        public void CreateMarker(){} // RVA: 0x6FB67C0
        public void ColorSelf(){} // RVA: 0x6FB6E20
        public void ColorThing(){} // RVA: 0x6FB6E50
        public void .ctor(){} // RVA: 0x6FB6F90
    }

    public class InteractableHoverEvents : MonoBehaviour
    {
        public object onHandHoverBegin;
        public object onHandHoverEnd;
        public object onAttachedToHand;
        public object onDetachedFromHand;

        // ── Methods ──
        public void OnHandHoverBegin(){} // RVA: 0x6FB6FE0
        public void OnHandHoverEnd(){} // RVA: 0x6FB7000
        public void OnAttachedToHand(){} // RVA: 0x6FB7020
        public void OnDetachedFromHand(){} // RVA: 0x6FB7040
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class ItemPackage : MonoBehaviour
    {
        public object name;
        public object packageType;
        public object itemPrefab;
        public object otherHandItemPrefab;
        public object previewPrefab;
        public object fadedPreviewPrefab;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class ItemPackageReference : MonoBehaviour
    {
        public object itemPackage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class ItemPackageSpawner : MonoBehaviour
    {
        public object _itemPackage;
        public object useItemPackagePreview;
        public object useFadedPreview;
        public object previewObject;
        public object requireGrabActionToTake;
        public object requireReleaseActionToReturn;
        public object showTriggerHint;
        public object attachmentFlags;
        public object takeBackItem;
        public object acceptDifferentItems;
        public object spawnedItem;
        public object itemIsSpawned;
        public object pickupEvent;
        public object dropEvent;
        public object justPickedUpItem;

        // ── Methods ──
        public void get_itemPackage(){} // RVA: 0xB700F0
        public void set_itemPackage(){} // RVA: 0x6FB7060
        public void CreatePreviewObject(){} // RVA: 0x6FB7070
        public void Start(){} // RVA: 0x6FB7660
        public void VerifyItemPackage(){} // RVA: 0x6FB7660
        public void ItemPackageNotValid(){} // RVA: 0x6FB77F0
        public void ClearPreview(){} // RVA: 0x6FB7930
        public void Update(){} // RVA: 0x6FB7C20
        public void OnHandHoverBegin(){} // RVA: 0x6FB7D20
        public void TakeBackItem(){} // RVA: 0x6FB7F00
        public void GetAttachedItemPackage(){} // RVA: 0x6FB7F60
        public void HandHoverUpdate(){} // RVA: 0x6FB8120
        public void OnHandHoverEnd(){} // RVA: 0x6FB8320
        public void RemoveMatchingItemsFromHandStack(){} // RVA: 0x6FB8370
        public void RemoveMatchingItemTypesFromHand(){} // RVA: 0x6FB87A0
        public void SpawnAndAttachObject(){} // RVA: 0x6FB8A10
        public void .ctor(){} // RVA: 0x6FB9020
    }

    public class LinearAnimation : MonoBehaviour
    {
        public object linearMapping;
        public object animation;
        public object animState;
        public object animLength;
        public object lastValue;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FB9070
        public void Update(){} // RVA: 0x6FB9510
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class LinearAnimator : MonoBehaviour
    {
        public object linearMapping;
        public object animator;
        public object currentLinearMapping;
        public object framesUnchanged;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FB95D0
        public void Update(){} // RVA: 0x6FB9850
        public void .ctor(){} // RVA: 0x6FB98F0
    }

    public class LinearAudioPitch : MonoBehaviour
    {
        public object linearMapping;
        public object pitchCurve;
        public object minPitch;
        public object maxPitch;
        public object applyContinuously;
        public object audioSource;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FB9940
        public void Update(){} // RVA: 0x6FB9B90
        public void Apply(){} // RVA: 0x6FB9C80
        public void .ctor(){} // RVA: 0x20B1660
    }

    public class LinearBlendshape : MonoBehaviour
    {
        public object linearMapping;
        public object skinnedMesh;
        public object lastValue;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FB9D70
        public void Update(){} // RVA: 0x6FB9FC0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class LinearDisplacement : MonoBehaviour
    {
        public object displacement;
        public object linearMapping;
        public object initialPosition;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FBA050
        public void Update(){} // RVA: 0x6FBA250
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class LinearDrive : MonoBehaviour
    {
        public object startPosition;
        public object endPosition;
        public object linearMapping;
        public object repositionGameObject;
        public object maintainMomemntum;
        public object momemtumDampenRate;
        public object attachmentFlags;
        public object initialMappingOffset;
        public object numMappingChangeSamples;
        public object mappingChangeSamples;
        public object prevMapping;
        public object mappingChangeRate;
        public object sampleCount;
        public object interactable;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FBA430
        public void Start(){} // RVA: 0x6FBA550
        public void HandHoverUpdate(){} // RVA: 0x6FBA7E0
        public void HandAttachedUpdate(){} // RVA: 0x6FBA960
        public void OnDetachedFromHand(){} // RVA: 0x6FBA9E0
        public void CalculateMappingChangeRate(){} // RVA: 0x6FBA9E0
        public void UpdateLinearMapping(){} // RVA: 0x6FBAA60
        public void CalculateLinearMapping(){} // RVA: 0x6FBADF0
        public void Update(){} // RVA: 0x6FBB1D0
        public void .ctor(){} // RVA: 0x6FBB5B0
    }

    public class LinearMapping : MonoBehaviour
    {
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class Longbow : MonoBehaviour
    {
        public object currentHandGuess;
        public object timeOfPossibleHandSwitch;
        public object timeBeforeConfirmingHandSwitch;
        public object possibleHandSwitch;
        public object pivotTransform;
        public object handleTransform;
        public object hand;
        public object arrowHand;
        public object nockTransform;
        public object nockRestTransform;
        public object autoSpawnArrowHand;
        public object arrowHandItemPackage;
        public object arrowHandPrefab;
        public object nocked;
        public object pulled;
        public object minPull;
        public object maxPull;
        public object nockDistanceTravelled;
        public object hapticDistanceThreshold;
        public object lastTickDistance;
        public object bowPullPulseStrengthLow;
        public object bowPullPulseStrengthHigh;
        public object bowLeftVector;
        public object arrowMinVelocity;
        public object arrowMaxVelocity;
        public object arrowVelocity;
        public object minStrainTickTime;
        public object maxStrainTickTime;
        public object nextStrainTick;
        public object lerpBackToZeroRotation;
        public object lerpStartTime;
        public object lerpDuration;
        public object lerpStartRotation;
        public object nockLerpStartTime;
        public object nockLerpStartRotation;
        public object drawOffset;
        public object bowDrawLinearMapping;
        public object lateUpdatePos;
        public object lateUpdateRot;
        public object drawSound;
        public object drawTension;
        public object arrowSlideSound;
        public object releaseSound;
        public object nockSound;
        public object newPosesAppliedAction;

        // ── Methods ──
        public void OnAttachedToHand(){} // RVA: 0xB6A8C0
        public void HandAttachedUpdate(){} // RVA: 0x6FDE740
        public void ArrowReleased(){} // RVA: 0x6FDFA60
        public void ResetDrawAnim(){} // RVA: 0x6FDFBE0
        public void GetArrowVelocity(){} // RVA: 0xE35F50
        public void StartRotationLerp(){} // RVA: 0x6FDFC80
        public void StartNock(){} // RVA: 0x6FDFDB0
        public void EvaluateHandedness(){} // RVA: 0x6FDFF80
        public void DoHandednessCheck(){} // RVA: 0x6FE00D0
        public void ArrowInPosition(){} // RVA: 0x6FE0230
        public void ReleaseNock(){} // RVA: 0x6FE0320
        public void ShutDown(){} // RVA: 0x6FE03A0
        public void OnHandFocusLost(){} // RVA: 0xD2E040
        public void OnHandFocusAcquired(){} // RVA: 0x6FE0770
        public void OnDetachedFromHand(){} // RVA: 0x6FE0800
        public void OnDestroy(){} // RVA: 0x6FE08A0
        public void .ctor(){} // RVA: 0x6FE08B0
    }

    public class ModalThrowable : Throwable
    {
        public object gripOffset;
        public object pinchOffset;

        // ── Methods ──
        public void HandHoverUpdate(){} // RVA: 0x6FBB610
        public void HandAttachedUpdate(){} // RVA: 0x6FBB6D0
        public void .ctor(){} // RVA: 0x6FBB900
    }

    public class PlaySound : MonoBehaviour
    {
        public object waveFile;
        public object stopOnPlay;
        public object disableOnEnd;
        public object looping;
        public object stopOnEnd;
        public object playOnAwakeWithDelay;
        public object useRandomVolume;
        public object volMin;
        public object volMax;
        public object useRandomPitch;
        public object pitchMin;
        public object pitchMax;
        public object useRetriggerTime;
        public object timeInitial;
        public object timeMin;
        public object timeMax;
        public object useRandomSilence;
        public object percentToNotPlay;
        public object delayOffsetTime;
        public object audioSource;
        public object clip;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FBE650
        public void Play(){} // RVA: 0x6FBE8B0
        public void PlayWithDelay(){} // RVA: 0x6FBEB50
        public void PlayOneShotSound(){} // RVA: 0x6FBEBD0
        public void PlayLooping(){} // RVA: 0x6FBED40
        public void Disable(){} // RVA: 0xD2E040
        public void Stop(){} // RVA: 0x6FBEE90
        public void SetAudioSource(){} // RVA: 0x6FBEF30
        public void .ctor(){} // RVA: 0x6FBF130
    }

    public class Player : MonoBehaviour
    {
        public object trackingOriginTransform;
        public object hmdTransforms;
        public object hands;
        public object headCollider;
        public object rigSteamVR;
        public object rig2DFallback;
        public object audioListener;
        public object headsetOnHead;
        public object allowToggleTo2D;
        public object _instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x6FBB9F0
        public void get_handCount(){} // RVA: 0x6FBBB80
        public void GetHand(){} // RVA: 0x6FBBD60
        public void get_leftHand(){} // RVA: 0x6FBBEB0
        public void get_rightHand(){} // RVA: 0x6FBC020
        public void get_scale(){} // RVA: 0x6FBC190
        public void get_hmdTransform(){} // RVA: 0x6FBC250
        public void get_eyeHeight(){} // RVA: 0x6FBC3A0
        public void get_feetPositionGuess(){} // RVA: 0x6FBC710
        public void get_bodyDirectionGuess(){} // RVA: 0x6FBCB50
        public void Awake(){} // RVA: 0x6FBCD90
        public void Start(){} // RVA: 0x6FBD000
        public void Update(){} // RVA: 0x6FBD0A0
        public void OnDrawGizmos(){} // RVA: 0x6FBD270
        public void Draw2DDebug(){} // RVA: 0x6FBDC90
        public void ActivateRig(){} // RVA: 0x6FBDE90
        public void PlayerShotSelf(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x6FBE320
    }

    public class RenderModel : MonoBehaviour
    {
        public object handPrefab;
        public object handInstance;
        public object handRenderers;
        public object displayHandByDefault;
        public object handSkeleton;
        public object handAnimator;
        public object animatorParameterStateName;
        public object handAnimatorStateId;
        public object controllerPrefab;
        public object controllerInstance;
        public object controllerRenderers;
        public object controllerRenderModel;
        public object displayControllerByDefault;
        public object delayedSetMaterial;
        public object onControllerLoaded;
        public object renderModelLoadedAction;
        public object inputSource;

        // ── Methods ──
        public void add_onControllerLoaded(){} // RVA: 0x6FBF1A0
        public void remove_onControllerLoaded(){} // RVA: 0x6FBF2A0
        public void Awake(){} // RVA: 0x6FBF3A0
        public void InitializeHand(){} // RVA: 0x6FBF4A0
        public void InitializeController(){} // RVA: 0x6FBFDF0
        public void DestroyHand(){} // RVA: 0x6FC0360
        public void OnSkeletonActiveChange(){} // RVA: 0x6FC0740
        public void OnEnable(){} // RVA: 0x6FC0760
        public void OnDisable(){} // RVA: 0x6FC0790
        public void OnDestroy(){} // RVA: 0xBFA210
        public void GetSkeleton(){} // RVA: 0xBC1B30
        public void SetInputSource(){} // RVA: 0x6FC07C0
        public void OnHandInitialized(){} // RVA: 0x6FC08B0
        public void MatchHandToTransform(){} // RVA: 0x6FC08F0
        public void SetHandPosition(){} // RVA: 0x6FC0CB0
        public void SetHandRotation(){} // RVA: 0x6FC0E40
        public void GetHandPosition(){} // RVA: 0x6FC0FC0
        public void GetHandRotation(){} // RVA: 0x6FC11A0
        public void OnRenderModelLoaded(){} // RVA: 0x6FC1370
        public void SetVisibility(){} // RVA: 0x6FC1610
        public void Show(){} // RVA: 0x6FC1690
        public void Hide(){} // RVA: 0x6FC16E0
        public void SetMaterial(){} // RVA: 0x6FC1710
        public void SetControllerMaterial(){} // RVA: 0x6FC17B0
        public void SetHandMaterial(){} // RVA: 0x6FC18B0
        public void SetControllerVisibility(){} // RVA: 0x6FC1940
        public void SetHandVisibility(){} // RVA: 0x6FC1A70
        public void IsHandVisibile(){} // RVA: 0x6FC1BA0
        public void IsControllerVisibile(){} // RVA: 0x6FC1CD0
        public void GetBone(){} // RVA: 0x6FC1E00
        public void GetBonePosition(){} // RVA: 0x6FC1F10
        public void GetControllerPosition(){} // RVA: 0x6FC2070
        public void GetBoneRotation(){} // RVA: 0x6FC22F0
        public void SetSkeletonRangeOfMotion(){} // RVA: 0x6FC2450
        public void get_GetSkeletonRangeOfMotion(){} // RVA: 0x6FC26A0
        public void SetTemporarySkeletonRangeOfMotion(){} // RVA: 0x6FC2790
        public void ResetTemporarySkeletonRangeOfMotion(){} // RVA: 0x6FC28F0
        public void SetAnimationState(){} // RVA: 0x6FC2B10
        public void StopAnimation(){} // RVA: 0x6FC2C40
        public void CheckAnimatorInit(){} // RVA: 0x6FC2D60
        public void .ctor(){} // RVA: 0x6FC3120
    }

    public class RenderModel[] : Array
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

    public class SeeThru : MonoBehaviour
    {
        public object seeThruMaterial;
        public object seeThru;
        public object interactable;
        public object sourceRenderer;
        public object destRenderer;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FC31F0
        public void OnEnable(){} // RVA: 0x6FC42B0
        public void OnDisable(){} // RVA: 0x6FC4540
        public void AttachedToHand(){} // RVA: 0x6FC47D0
        public void DetachedFromHand(){} // RVA: 0x13A58F0
        public void Update(){} // RVA: 0x6FC4800
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SleepOnAwake : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6FC4EE0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SnapTurn : MonoBehaviour
    {
        public object snapAngle;
        public object showTurnAnimation;
        public object snapTurnSource;
        public object rotateSound;
        public object rotateRightFX;
        public object rotateLeftFX;
        public object snapLeftAction;
        public object snapRightAction;
        public object fadeScreen;
        public object fadeTime;
        public object screenFadeColor;
        public object distanceFromFace;
        public object additionalOffset;
        public object teleportLastActiveTime;
        public object canRotate;
        public object canTurnEverySeconds;
        public object rotateCoroutine;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FE0D20
        public void AllOff(){} // RVA: 0x6FE0D30
        public void Update(){} // RVA: 0x6FE0EC0
        public void RotatePlayer(){} // RVA: 0x6FE1660
        public void DoRotatePlayer(){} // RVA: 0x6FE17B0
        public void ShowRotateFX(){} // RVA: 0x6FE1870
        public void UpdateOrientation(){} // RVA: 0x6FE1970
        public void .ctor(){} // RVA: 0x6FE2110
    }

    public class SoundBowClick : MonoBehaviour
    {
        public object bowClick;
        public object pitchTensionCurve;
        public object minPitch;
        public object maxPitch;
        public object thisAudioSource;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FE0BC0
        public void PlayBowTensionClicks(){} // RVA: 0x6FE0C50
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SoundDeparent : MonoBehaviour
    {
        public object destroyAfterPlayOnce;
        public object thisAudioSource;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FC4FD0
        public void Start(){} // RVA: 0x6FC5060
        public void .ctor(){} // RVA: 0xB9C2F0
    }

    public class SoundPlayOneshot : MonoBehaviour
    {
        public object waveFiles;
        public object thisAudioSource;
        public object volMin;
        public object volMax;
        public object pitchMin;
        public object pitchMax;
        public object playOnAwake;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FC5140
        public void Play(){} // RVA: 0x6FC51E0
        public void Pause(){} // RVA: 0x6FC53B0
        public void UnPause(){} // RVA: 0x6FC5490
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SpawnAndAttachAfterControllerIsTracking : MonoBehaviour
    {
        public object hand;
        public object itemPrefab;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FC5570
        public void Update(){} // RVA: 0x6FC5600
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SpawnAndAttachToHand : MonoBehaviour
    {
        public object hand;
        public object prefab;

        // ── Methods ──
        public void SpawnAndAttach(){} // RVA: 0x6FC5960
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class Teleport : MonoBehaviour
    {
        public object teleportAction;
        public object traceLayerMask;
        public object floorFixupTraceLayerMask;
        public object floorFixupMaximumTraceDistance;
        public object areaVisibleMaterial;
        public object areaLockedMaterial;
        public object areaHighlightedMaterial;
        public object pointVisibleMaterial;
        public object pointLockedMaterial;
        public object pointHighlightedMaterial;
        public object destinationReticleTransform;
        public object invalidReticleTransform;
        public object playAreaPreviewCorner;
        public object playAreaPreviewSide;
        public object pointerValidColor;
        public object pointerInvalidColor;
        public object pointerLockedColor;
        public object showPlayAreaMarker;
        public object teleportFadeTime;
        public object meshFadeTime;
        public object arcDistance;
        public object onActivateObjectTransform;
        public object onDeactivateObjectTransform;
        public object activateObjectTime;
        public object deactivateObjectTime;
        public object pointerAudioSource;
        public object loopingAudioSource;
        public object headAudioSource;
        public object reticleAudioSource;
        public object teleportSound;
        public object pointerStartSound;
        public object pointerLoopSound;
        public object pointerStopSound;
        public object goodHighlightSound;
        public object badHighlightSound;
        public object debugFloor;
        public object showOffsetReticle;
        public object offsetReticleTransform;
        public object floorDebugSphere;
        public object floorDebugLine;
        public object pointerLineRenderer;
        public object teleportPointerObject;
        public object pointerStartTransform;
        public object pointerHand;
        public object player;
        public object teleportArc;
        public object visible;
        public object teleportMarkers;
        public object pointedAtTeleportMarker;
        public object teleportingToMarker;
        public object pointedAtPosition;
        public object prevPointedAtPosition;
        public object teleporting;
        public object currentFadeTime;
        public object meshAlphaPercent;
        public object pointerShowStartTime;
        public object pointerHideStartTime;
        public object meshFading;
        public object fullTintAlpha;
        public object invalidReticleMinScale;
        public object invalidReticleMaxScale;
        public object invalidReticleMinScaleDistance;
        public object invalidReticleMaxScaleDistance;
        public object invalidReticleScale;
        public object invalidReticleTargetRotation;
        public object playAreaPreviewTransform;
        public object playAreaPreviewCorners;
        public object playAreaPreviewSides;
        public object loopingAudioMaxVolume;
        public object hintCoroutine;
        public object originalHoverLockState;
        public object originalHoveringInteractable;
        public object allowTeleportWhileAttached;
        public object startingFeetOffset;
        public object movedFeetFarEnough;
        public object chaperoneInfoInitializedAction;
        public object ChangeScene;
        public object Player;
        public object PlayerPre;
        public object _instance;

        // ── Methods ──
        public void ChangeSceneAction(){} // RVA: 0x6FE3770
        public void PlayerAction(){} // RVA: 0x6FE3820
        public void PlayerPreAction(){} // RVA: 0x6FE38E0
        public void get_instance(){} // RVA: 0x6FE39A0
        public void Awake(){} // RVA: 0x6FE3B70
        public void Start(){} // RVA: 0x6FE40E0
        public void OnEnable(){} // RVA: 0x6FE4510
        public void OnDisable(){} // RVA: 0x6FE4550
        public void CheckForSpawnPoint(){} // RVA: 0x6FE4590
        public void HideTeleportPointer(){} // RVA: 0x6FE4730
        public void Update(){} // RVA: 0x6FE4810
        public void UpdatePointer(){} // RVA: 0x6FE54B0
        public void FixedUpdate(){} // RVA: 0x6FE6FB0
        public void OnChaperoneInfoInitialized(){} // RVA: 0x6FE7B00
        public void HidePointer(){} // RVA: 0x6FE9700
        public void ShowPointer(){} // RVA: 0x6FEA440
        public void UpdateTeleportColors(){} // RVA: 0x6FEB720
        public void PlayAudioClip(){} // RVA: 0x6FEB850
        public void PlayPointerHaptic(){} // RVA: 0x6FEB890
        public void TryTeleportPlayer(){} // RVA: 0x6FEBA50
        public void InitiateTeleportFade(){} // RVA: 0x6FEBB80
        public void TeleportPlayer(){} // RVA: 0x6FEBF70
        public void HighlightSelected(){} // RVA: 0x6FECDA0
        public void ShowTeleportHint(){} // RVA: 0x6FED370
        public void CancelTeleportHint(){} // RVA: 0x6FED490
        public void TeleportHintCoroutine(){} // RVA: 0x6FED5A0
        public void IsEligibleForTeleport(){} // RVA: 0x6FED640
        public void ShouldOverrideHoverLock(){} // RVA: 0x6FEDA00
        public void WasTeleportButtonReleased(){} // RVA: 0x6FEDB00
        public void IsTeleportButtonDown(){} // RVA: 0x6FEDC70
        public void WasTeleportButtonPressed(){} // RVA: 0x6FEDDE0
        public void GetPointerStartTransform(){} // RVA: 0x6FEDF50
        public void .ctor(){} // RVA: 0x6FEE060
        public void .cctor(){} // RVA: 0x6FEE2A0
    }

    public class TeleportArc : MonoBehaviour
    {
        public object segmentCount;
        public object thickness;
        public object arcDuration;
        public object segmentBreak;
        public object arcSpeed;
        public object material;
        public object traceLayerMask;
        public object lineRenderers;
        public object arcTimeOffset;
        public object prevThickness;
        public object prevSegmentCount;
        public object showArc;
        public object startPos;
        public object projectileVelocity;
        public object useGravity;
        public object arcObjectsTransfrom;
        public object arcInvalid;
        public object scale;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FEE860
        public void Update(){} // RVA: 0x6FEE8C0
        public void CreateLineRendererObjects(){} // RVA: 0x6FEE9D0
        public void SetArcData(){} // RVA: 0x6FEF400
        public void Show(){} // RVA: 0x6FEF4A0
        public void Hide(){} // RVA: 0x6FEF4C0
        public void DrawArc(){} // RVA: 0x6FEF500
        public void DrawArcSegment(){} // RVA: 0x6FEF920
        public void SetColor(){} // RVA: 0x6FEFB60
        public void FindProjectileCollision(){} // RVA: 0x6FEFD20
        public void GetArcPositionAtTime(){} // RVA: 0x6FF0070
        public void HideLineSegments(){} // RVA: 0x6FF0240
        public void .ctor(){} // RVA: 0x6FF0370
    }

    public class TeleportArea : TeleportMarkerBase
    {
        public object _meshBounds;
        public object areaMesh;
        public object tintColorId;
        public object visibleTintColor;
        public object highlightedTintColor;
        public object lockedTintColor;
        public object highlighted;

        // ── Methods ──
        public void get_meshBounds(){} // RVA: 0x28D53F0
        public void set_meshBounds(){} // RVA: 0x28D5410
        public void Awake(){} // RVA: 0x6FF03F0
        public void Start(){} // RVA: 0x6FF04B0
        public void ShouldActivate(){} // RVA: 0xC2E4C0
        public void ShouldMovePlayer(){} // RVA: 0xC2E4C0
        public void Highlight(){} // RVA: 0x6FF0590
        public void SetAlpha(){} // RVA: 0x6FF0660
        public void UpdateVisuals(){} // RVA: 0x6FF07B0
        public void UpdateVisualsInEditor(){} // RVA: 0x6FF0870
        public void CalculateBounds(){} // RVA: 0x6FF0A60
        public void GetTintColor(){} // RVA: 0x6FF0CB0
        public void .ctor(){} // RVA: 0x6FF0CE0
    }

    public class TeleportMarkerBase : MonoBehaviour
    {
        public object locked;
        public object markerActive;

        // ── Methods ──
        public void get_showReticle(){} // RVA: 0xC2E4C0
        public void SetLocked(){} // RVA: 0x6FF0D40
        public void TeleportPlayer(){} // RVA: 0xB43310
        public void UpdateVisuals(){} // RVA: 0x894290
        public void Highlight(){} // RVA: 0x894750
        public void SetAlpha(){} // RVA: 0x8A2920
        public void ShouldActivate(){} // RVA: 0x87D350
        public void ShouldMovePlayer(){} // RVA: 0x87D280
        public void .ctor(){} // RVA: 0x6FF0D60
    }

    public class TeleportMarkerBase[] : Array
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

    public class TeleportPoint : TeleportMarkerBase
    {
        public object teleportType;
        public object title;
        public object switchToScene;
        public object titleVisibleColor;
        public object titleHighlightedColor;
        public object titleLockedColor;
        public object playerSpawnPoint;
        public object gotReleventComponents;
        public object markerMesh;
        public object switchSceneIcon;
        public object moveLocationIcon;
        public object lockedIcon;
        public object pointIcon;
        public object lookAtJointTransform;
        public object animation;
        public object titleText;
        public object player;
        public object lookAtPosition;
        public object tintColorID;
        public object tintColor;
        public object titleColor;
        public object fullTitleAlpha;
        public object switchSceneAnimation;
        public object moveLocationAnimation;
        public object lockedAnimation;

        // ── Methods ──
        public void get_showReticle(){} // RVA: 0xB43320
        public void Awake(){} // RVA: 0x6FF0DB0
        public void Start(){} // RVA: 0x6FF0F00
        public void Update(){} // RVA: 0x6FF0F70
        public void ShouldActivate(){} // RVA: 0x6FF1270
        public void ShouldMovePlayer(){} // RVA: 0xC2E4C0
        public void Highlight(){} // RVA: 0x6FF1410
        public void UpdateVisuals(){} // RVA: 0x6FF1570
        public void SetAlpha(){} // RVA: 0x6FF17C0
        public void SetMeshMaterials(){} // RVA: 0x6FF1C10
        public void TeleportToScene(){} // RVA: 0x6FF1CE0
        public void GetRelevantComponents(){} // RVA: 0x6FF1DD0
        public void ReleaseRelevantComponents(){} // RVA: 0x6FF23F0
        public void UpdateVisualsInEditor(){} // RVA: 0x6FF2600
        public void .ctor(){} // RVA: 0x6FF29D0
    }

    public class TeleportURPHelper : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class Throwable : MonoBehaviour
    {
        public object attachmentFlags;
        public object attachmentOffset;
        public object catchingSpeedThreshold;
        public object releaseVelocityStyle;
        public object releaseVelocityTimeOffset;
        public object scaleReleaseVelocity;
        public object scaleReleaseVelocityThreshold;
        public object scaleReleaseVelocityCurve;
        public object restoreOriginalParent;
        public object velocityEstimator;
        public object attached;
        public object attachTime;
        public object attachPosition;
        public object attachRotation;
        public object attachEaseInTransform;
        public object onPickUp;
        public object onDetachFromHand;
        public object onHeldUpdate;
        public object hadInterpolation;
        public object rigidbody;
        public object interactable;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FC5B20
        public void OnHandHoverBegin(){} // RVA: 0x6FC5D70
        public void OnHandHoverEnd(){} // RVA: 0x6FC5F30
        public void HandHoverUpdate(){} // RVA: 0x6FC5F60
        public void OnAttachedToHand(){} // RVA: 0x6FC5FE0
        public void OnDetachedFromHand(){} // RVA: 0x6FC6430
        public void GetReleaseVelocities(){} // RVA: 0x6FC6630
        public void HandAttachedUpdate(){} // RVA: 0x6FC6E80
        public void LateDetach(){} // RVA: 0x6FC6F20
        public void OnHandFocusAcquired(){} // RVA: 0x6FC7020
        public void OnHandFocusLost(){} // RVA: 0x6FC7130
        public void .ctor(){} // RVA: 0x6FBB900
    }

    public class UIElement : MonoBehaviour
    {
        public object onHandClick;
        public object currentHand;

        // ── Methods ──
        public void Awake(){} // RVA: 0x6FC7370
        public void OnHandHoverBegin(){} // RVA: 0x6FC74C0
        public void OnHandHoverEnd(){} // RVA: 0x6FC7730
        public void HandHoverUpdate(){} // RVA: 0x6FC79C0
        public void OnButtonClick(){} // RVA: 0x6FC7BA0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class Unparent : MonoBehaviour
    {
        public object oldParent;

        // ── Methods ──
        public void Start(){} // RVA: 0x6FC7BF0
        public void Update(){} // RVA: 0x6FC7D40
        public void GetOldParent(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class Util : Object
    {
        public object FeetToMeters;
        public object FeetToCentimeters;
        public object InchesToMeters;
        public object InchesToCentimeters;
        public object MetersToFeet;
        public object MetersToInches;
        public object CentimetersToFeet;
        public object CentimetersToInches;
        public object KilometersToMiles;
        public object MilesToKilometers;

        // ── Methods ──
        public void RemapNumber(){} // RVA: 0x6FC7E70
        public void RemapNumberClamped(){} // RVA: 0x6FC7E90
        public void Approach(){} // RVA: 0x6FC7F00
        public void BezierInterpolate3(){} // RVA: 0x6FC7F30
        public void BezierInterpolate4(){} // RVA: 0x6FC80C0
        public void Vector3FromString(){} // RVA: 0x6FC8370
        public void Vector2FromString(){} // RVA: 0x6FC8490
        public void Normalize(){} // RVA: 0x6FC8580
        public void Vector2AsVector3(){} // RVA: 0xBAB3C0
        public void Vector3AsVector2(){} // RVA: 0xBAB3A0
        public void AngleOf(){} // RVA: 0x6FC8590
        public void YawOf(){} // RVA: 0x6FC85F0
        public void Swap(){} // RVA: 0x8945C0
        public void Shuffle(){} // RVA: 0x894350
        public void RandomWithLookback(){} // RVA: 0x6FC8640
        public void FindChild(){} // RVA: 0x6FC8830
        public void IsNullOrEmpty(){} // RVA: 0x87D390
        public void IsValidIndex(){} // RVA: 0x87FA40
        public void FindOrAdd(){} // RVA: 0xA94080
        public void FindAndRemove(){} // RVA: 0x87C630
        public void FindOrAddComponent(){} // RVA: 0xA94080
        public void FastRemove(){} // RVA: 0x89AB50
        public void ReplaceGameObject(){} // RVA: 0xA94080
        public void SwitchLayerRecursively(){} // RVA: 0x6FC8AF0
        public void DrawCross(){} // RVA: 0x6FC8D30
        public void ResetTransform(){} // RVA: 0x6FC9380
        public void ClosestPointOnLine(){} // RVA: 0x6FC95D0
        public void AfterTimer(){} // RVA: 0x6FC9890
        public void SendPhysicsMessage(){} // RVA: 0x6FC9BB0
        public void IgnoreCollisions(){} // RVA: 0x6FC9DF0
        public void WrapCoroutine(){} // RVA: 0x6FC9FB0
        public void ColorWithAlpha(){} // RVA: 0x1302F00
        public void Quit(){} // RVA: 0x6FCA0B0
        public void FloatToDecimal(){} // RVA: 0x6FCA0E0
        public void Median(){} // RVA: 0xA94080
        public void ForEach(){} // RVA: 0x8945C0
        public void FixupNewlines(){} // RVA: 0x6FCA200
        public void PathLength(){} // RVA: 0x6FCA2C0
        public void HasCommandLineArgument(){} // RVA: 0x6FCA4F0
        public void GetCommandLineArgValue(){} // RVA: 0x6FCA680
        public void SetActive(){} // RVA: 0x6FCA770
        public void CombinePaths(){} // RVA: 0x6FCA850
    }

    public class VelocityEstimator : MonoBehaviour
    {
        public object velocityAverageFrames;
        public object angularVelocityAverageFrames;
        public object estimateOnAwake;
        public object routine;
        public object sampleCount;
        public object velocitySamples;
        public object angularVelocitySamples;

        // ── Methods ──
        public void BeginEstimatingVelocity(){} // RVA: 0x6FCADD0
        public void FinishEstimatingVelocity(){} // RVA: 0x6FCAEF0
        public void GetVelocityEstimate(){} // RVA: 0x6FCAF70
        public void GetAngularVelocityEstimate(){} // RVA: 0x6FCB0A0
        public void GetAccelerationEstimate(){} // RVA: 0x6FCB1D0
        public void Awake(){} // RVA: 0x6FCB3A0
        public void EstimateVelocityCoroutine(){} // RVA: 0x6FCB4C0
        public void .ctor(){} // RVA: 0x6FCB560
    }

}