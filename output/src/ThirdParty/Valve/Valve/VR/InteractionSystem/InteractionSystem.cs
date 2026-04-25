// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.InteractionSystem
// Classes: 75
// Methods: 667

namespace ThirdParty.Valve.Valve.VR.InteractionSystem
{
    public class AfterTimer_Component : MonoBehaviour
    {
        public System.Action callback; // 0x20
        public float triggerTime; // 0x28
        public bool timerActive; // 0x2C
        public bool triggerOnEarlyDestroy; // 0x2D

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC8CF45D0
        public void Wait(){} // RVA: 0x7FFAC8CF4650
        public void OnDestroy(){} // RVA: 0x7FFAC8CF46F0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class AllowTeleportWhileAttachedToHand : MonoBehaviour
    {
        public bool teleportAllowed; // 0x20
        public bool overrideHoverLock; // 0x21

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C96450
    }

    public class ArcheryTarget : MonoBehaviour
    {
        public UnityEngine.Events.UnityEvent onTakeDamage; // 0x20
        public bool onceOnly; // 0x28
        public UnityEngine.Transform targetCenter; // 0x30
        public UnityEngine.Transform baseTransform; // 0x38
        public UnityEngine.Transform fallenDownTransform; // 0x40
        public float fallTime; // 0x48
        public float targetRadius;
        public bool targetEnabled; // 0x4C

        // ── Methods ──
        public void ApplyDamage(){} // RVA: 0x7FFAC8CFDD20
        public void FireExposure(){} // RVA: 0x7FFAC8CFDD20
        public void OnDamageTaken(){} // RVA: 0x7FFAC8CFDD30
        public void FallDown(){} // RVA: 0x7FFAC8CFDE10
        public void .ctor(){} // RVA: 0x7FFAC8CFDEB0
    }

    public class Arrow : MonoBehaviour
    {
        public UnityEngine.ParticleSystem glintParticle; // 0x20
        public UnityEngine.Rigidbody arrowHeadRB; // 0x28
        public UnityEngine.Rigidbody shaftRB; // 0x30
        public UnityEngine.PhysicMaterial targetPhysMaterial; // 0x38
        public UnityEngine.Vector3 prevPosition; // 0x40
        public UnityEngine.Quaternion prevRotation; // 0x4C
        public UnityEngine.Vector3 prevVelocity; // 0x5C
        public UnityEngine.Vector3 prevHeadPosition; // 0x68
        public Valve.VR.InteractionSystem.SoundPlayOneshot fireReleaseSound; // 0x78
        public Valve.VR.InteractionSystem.SoundPlayOneshot airReleaseSound; // 0x80
        public Valve.VR.InteractionSystem.SoundPlayOneshot hitTargetSound; // 0x88
        public Valve.VR.InteractionSystem.PlaySound hitGroundSound; // 0x90
        public bool inFlight; // 0x98
        public bool released; // 0x99
        public bool hasSpreadFire; // 0x9A
        public int travelledFrames; // 0x9C
        public UnityEngine.GameObject scaleParentObject; // 0xA0
        public float initialMass; // 0xA8
        public float initialDrag; // 0xAC
        public float initialAngularDrag; // 0xB0
        public 0x6B29FF58 initialInterpolation; // 0xB4
        public 0x6B2A0270 initialCollisionDetection; // 0xB8
        public bool initialUseGravity; // 0xBC

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CFE2E0
        public void Start(){} // RVA: 0x7FFAC8CFE570
        public void FixedUpdate(){} // RVA: 0x7FFAC8CFE610
        public void StartRelease(){} // RVA: 0x7FFAC8CFE8F0
        public void ArrowReleased(){} // RVA: 0x7FFAC8CFED80
        public void SetCollisionMode(){} // RVA: 0x7FFAC8CFF8D0
        public void OnCollisionEnter(){} // RVA: 0x7FFAC8CFFA10
        public void StickInTarget(){} // RVA: 0x7FFAC8D00970
        public void OnDestroy(){} // RVA: 0x7FFAC8D01BA0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class ArrowHand : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.Hand hand; // 0x20
        public Valve.VR.InteractionSystem.Longbow bow; // 0x28
        public UnityEngine.GameObject currentArrow; // 0x30
        public UnityEngine.GameObject arrowPrefab; // 0x38
        public UnityEngine.Transform arrowNockTransform; // 0x40
        public float nockDistance; // 0x48
        public float lerpCompleteDistance; // 0x4C
        public float rotationLerpThreshold; // 0x50
        public float positionLerpThreshold; // 0x54
        public bool allowArrowSpawn; // 0x58
        public bool nocked; // 0x59
        public 0x6B20BBD0 nockedWithType; // 0x5C
        public bool inNockRange; // 0x60
        public bool arrowLerpComplete; // 0x61
        public Valve.VR.InteractionSystem.SoundPlayOneshot arrowSpawnSound; // 0x68
        public Valve.VR.InteractionSystem.AllowTeleportWhileAttachedToHand allowTeleport; // 0x70
        public int maxArrowCount; // 0x78
        public System.Collections.Generic.List`1<UnityEngine.GameObject> arrowList; // 0x80

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8D01E50
        public void OnAttachedToHand(){} // RVA: 0x7FFAC8D01FB0
        public void InstantiateArrow(){} // RVA: 0x7FFAC8D02010
        public void HandAttachedUpdate(){} // RVA: 0x7FFAC8D023F0
        public void OnDetachedFromHand(){} // RVA: 0x7FFAC8D034A0
        public void FireArrow(){} // RVA: 0x7FFAC8D03540
        public void EnableArrowSpawn(){} // RVA: 0x7FFAC30D2F70
        public void ArrowReleaseHaptics(){} // RVA: 0x7FFAC8D03FA0
        public void OnHandFocusLost(){} // RVA: 0x7FFAC3697F10
        public void OnHandFocusAcquired(){} // RVA: 0x7FFAC3B42350
        public void FindBow(){} // RVA: 0x7FFAC8D04040
        public void .ctor(){} // RVA: 0x7FFAC8D040E0
    }

    public class ArrowheadRotation : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D04390
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Balloon : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.Hand hand; // 0x20
        public UnityEngine.GameObject popPrefab; // 0x28
        public float maxVelocity; // 0x30
        public float lifetime; // 0x34
        public bool burstOnLifetimeEnd; // 0x38
        public UnityEngine.GameObject lifetimeEndParticlePrefab; // 0x40
        public Valve.VR.InteractionSystem.SoundPlayOneshot lifetimeEndSound; // 0x48
        public float destructTime; // 0x50
        public float releaseTime; // 0x54
        public Valve.VR.InteractionSystem.SoundPlayOneshot collisionSound; // 0x58
        public float lastSoundTime; // 0x60
        public float soundDelay; // 0x64
        public UnityEngine.Rigidbody balloonRigidbody; // 0x68
        public bool bParticlesSpawned; // 0x70
        public float s_flLastDeathSound;

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D04480
        public void Update(){} // RVA: 0x7FFAC8D04640
        public void SpawnParticles(){} // RVA: 0x7FFAC8D04750
        public void FixedUpdate(){} // RVA: 0x7FFAC8D04C00
        public void ApplyDamage(){} // RVA: 0x7FFAC8D04D90
        public void OnCollisionEnter(){} // RVA: 0x7FFAC8D04E40
        public void SetColor(){} // RVA: 0x7FFAC8D05490
        public void BalloonColorToRGB(){} // RVA: 0x7FFAC8D05570
        public void .ctor(){} // RVA: 0x7FFAC8D05780
    }

    public class BalloonColliders : MonoBehaviour
    {
        public UnityEngine.GameObject[] colliders; // 0x20
        public UnityEngine.Vector3[] colliderLocalPositions; // 0x28
        public UnityEngine.Quaternion[] colliderLocalRotations; // 0x30
        public UnityEngine.Rigidbody rb; // 0x38

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8D057E0
        public void OnEnable(){} // RVA: 0x7FFAC8D05D90
        public void OnDisable(){} // RVA: 0x7FFAC8D063E0
        public void OnDestroy(){} // RVA: 0x7FFAC8D065A0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class BalloonHapticBump : MonoBehaviour
    {
        public UnityEngine.GameObject physParent; // 0x20

        // ── Methods ──
        public void OnCollisionEnter(){} // RVA: 0x7FFAC8D066D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class BalloonSpawner : MonoBehaviour
    {
        public float minSpawnTime; // 0x20
        public float maxSpawnTime; // 0x24
        public float nextSpawnTime; // 0x28
        public UnityEngine.GameObject balloonPrefab; // 0x30
        public bool autoSpawn; // 0x38
        public bool spawnAtStartup; // 0x39
        public bool playSounds; // 0x3A
        public Valve.VR.InteractionSystem.SoundPlayOneshot inflateSound; // 0x40
        public Valve.VR.InteractionSystem.SoundPlayOneshot stretchSound; // 0x48
        public bool sendSpawnMessageToParent; // 0x50
        public float scale; // 0x54
        public UnityEngine.Transform spawnDirectionTransform; // 0x58
        public float spawnForce; // 0x60
        public bool attachBalloon; // 0x64
        public 0x6B20D2D8 color; // 0x68

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D06910
        public void Update(){} // RVA: 0x7FFAC8D06A30
        public void SpawnBalloon(){} // RVA: 0x7FFAC8D06B90
        public void SpawnBalloonFromEvent(){} // RVA: 0x7FFAC8D074F0
        public void .ctor(){} // RVA: 0x7FFAC8D07500
    }

    public class BodyCollider : MonoBehaviour
    {
        public UnityEngine.Transform head; // 0x20
        public UnityEngine.CapsuleCollider capsuleCollider; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CBB090
        public void FixedUpdate(){} // RVA: 0x7FFAC8CBB120
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class ChaperoneInfo : MonoBehaviour
    {
        public bool initialized; // 0x20
        public float playAreaSizeX; // 0x24
        public float playAreaSizeZ; // 0x28
        public bool roomscale; // 0x2C
        public Event instance;
        public Valve.VR.InteractionSystem.ChaperoneInfo _instance; // 0x8

        // ── Methods ──
        public void get_initialized(){} // RVA: 0x7FFAC300F9D0
        public void set_initialized(){} // RVA: 0x7FFAC300F9E0
        public void get_playAreaSizeX(){} // RVA: 0x7FFAC308EF50
        public void set_playAreaSizeX(){} // RVA: 0x7FFAC308EF60
        public void get_playAreaSizeZ(){} // RVA: 0x7FFAC3000210
        public void set_playAreaSizeZ(){} // RVA: 0x7FFAC3000220
        public void get_roomscale(){} // RVA: 0x7FFAC3000230
        public void set_roomscale(){} // RVA: 0x7FFAC3000240
        public void InitializedAction(){} // RVA: 0x7FFAC8D0C4F0
        public void get_instance(){} // RVA: 0x7FFAC8D0C590
        public void Start(){} // RVA: 0x7FFAC8D0C8E0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void .cctor(){} // RVA: 0x7FFAC8D0C980
    }

    public class CircularDrive : MonoBehaviour
    {
        public 0x6B20B4F0 axisOfRotation; // 0x20
        public UnityEngine.Collider childCollider; // 0x28
        public Valve.VR.InteractionSystem.LinearMapping linearMapping; // 0x30
        public bool hoverLock; // 0x38
        public bool limited; // 0x39
        public UnityEngine.Vector2 frozenDistanceMinMaxThreshold; // 0x3C
        public UnityEngine.Events.UnityEvent onFrozenDistanceThreshold; // 0x48
        public float minAngle; // 0x50
        public bool freezeOnMin; // 0x54
        public UnityEngine.Events.UnityEvent onMinAngle; // 0x58
        public float maxAngle; // 0x60
        public bool freezeOnMax; // 0x64
        public UnityEngine.Events.UnityEvent onMaxAngle; // 0x68
        public bool forceStart; // 0x70
        public float startAngle; // 0x74
        public bool rotateGameObject; // 0x78
        public bool debugPath; // 0x79
        public int dbgPathLimit; // 0x7C
        public UnityEngine.TextMesh debugText; // 0x80
        public float outAngle; // 0x88
        public UnityEngine.Quaternion start; // 0x8C
        public UnityEngine.Vector3 worldPlaneNormal; // 0x9C
        public UnityEngine.Vector3 localPlaneNormal; // 0xA8
        public UnityEngine.Vector3 lastHandProjected; // 0xB4
        public UnityEngine.Color red; // 0xC0
        public UnityEngine.Color green; // 0xD0
        public UnityEngine.GameObject[] dbgHandObjects; // 0xE0
        public UnityEngine.GameObject[] dbgProjObjects; // 0xE8
        public UnityEngine.GameObject dbgObjectsParent; // 0xF0
        public int dbgObjectCount; // 0xF8
        public int dbgObjectIndex; // 0xFC
        public bool driving; // 0x100
        public float minMaxAngularThreshold; // 0x104
        public bool frozen; // 0x108
        public float frozenAngle; // 0x10C
        public UnityEngine.Vector3 frozenHandWorldPos; // 0x110
        public UnityEngine.Vector2 frozenSqDistanceMinMaxThreshold; // 0x11C
        public Valve.VR.InteractionSystem.Hand handHoverLocked; // 0x128
        public Valve.VR.InteractionSystem.Interactable interactable; // 0x130
        public 0x6B20BBD0 grabbedWithType; // 0x138

        // ── Methods ──
        public void Freeze(){} // RVA: 0x7FFAC8CBB450
        public void UnFreeze(){} // RVA: 0x7FFAC8CBB520
        public void Awake(){} // RVA: 0x7FFAC8CBB540
        public void Start(){} // RVA: 0x7FFAC8CBB5E0
        public void OnDisable(){} // RVA: 0x7FFAC8CBC200
        public void HapticPulses(){} // RVA: 0x7FFAC8CBC370
        public void OnHandHoverBegin(){} // RVA: 0x7FFAC8CBC430
        public void OnHandHoverEnd(){} // RVA: 0x7FFAC8CBC450
        public void HandHoverUpdate(){} // RVA: 0x7FFAC8CBC5D0
        public void ComputeToTransformProjected(){} // RVA: 0x7FFAC8CBC8A0
        public void DrawDebugPath(){} // RVA: 0x7FFAC8CBCD10
        public void UpdateLinearMapping(){} // RVA: 0x7FFAC8CBDC50
        public void UpdateGameObject(){} // RVA: 0x7FFAC8CBDCE0
        public void UpdateDebugText(){} // RVA: 0x7FFAC8CBDFA0
        public void UpdateAll(){} // RVA: 0x7FFAC8CBE1A0
        public void ComputeAngle(){} // RVA: 0x7FFAC8CBE240
        public void .ctor(){} // RVA: 0x7FFAC8CBE730
    }

    public class ComplexThrowable : MonoBehaviour
    {
        public float attachForce; // 0x20
        public float attachForceDamper; // 0x24
        public 0x6B20B5F8 attachMode; // 0x28
        public 0x6B20BC28 attachmentFlags; // 0x2C
        public System.Collections.Generic.List`1<Valve.VR.InteractionSystem.Hand> holdingHands; // 0x30
        public System.Collections.Generic.List`1<UnityEngine.Rigidbody> holdingBodies; // 0x38
        public System.Collections.Generic.List`1<UnityEngine.Vector3> holdingPoints; // 0x40
        public System.Collections.Generic.List`1<UnityEngine.Rigidbody> rigidBodies; // 0x48

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CBEAD0
        public void Update(){} // RVA: 0x7FFAC8CBEB50
        public void OnHandHoverBegin(){} // RVA: 0x7FFAC8CBEC90
        public void OnHandHoverEnd(){} // RVA: 0x7FFAC8CBED70
        public void HandHoverUpdate(){} // RVA: 0x7FFAC8CBEE50
        public void PhysicsAttach(){} // RVA: 0x7FFAC8CBEEA0
        public void PhysicsDetach(){} // RVA: 0x7FFAC8CBF980
        public void FixedUpdate(){} // RVA: 0x7FFAC8CBFC90
        public void .ctor(){} // RVA: 0x7FFAC8CC0210
    }

    public class ControllerButtonHints : MonoBehaviour
    {
        public UnityEngine.Material usingMaterial; // 0x20
        public UnityEngine.Material initialized; // 0x28
        public UnityEngine.Color flashColor; // 0x30
        public UnityEngine.GameObject textHintPrefab; // 0x40
        public Valve.VR.SteamVR_Action_Vibration hapticFlash; // 0x48
        public bool autoSetWithControllerRangeOfMotion; // 0x50
        public bool debugHints; // 0x51
        public Valve.VR.SteamVR_RenderModel renderModel; // 0x58
        public Valve.VR.InteractionSystem.Player player; // 0x60
        public System.Collections.Generic.List`1<UnityEngine.MeshRenderer> renderers; // 0x68
        public System.Collections.Generic.List`1<UnityEngine.MeshRenderer> flashingRenderers; // 0x70
        public float startTime; // 0x78
        public float tickCount; // 0x7C
        public System.Collections.Generic.Dictionary`2<Valve.VR.ISteamVR_Action_In_Source,ActionHintInfo> actionHintInfos; // 0x80
        public UnityEngine.Transform textHintParent; // 0x88
        public int colorID; // 0x90
        public bool <initialized>k__BackingField; // 0x94
        public UnityEngine.Vector3 centerPosition; // 0x98
        public Action renderModelLoadedAction; // 0xA8
        public 0x6B209C88 inputSource; // 0xB0
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.Transform> componentTransformMap; // 0xB8

        // ── Methods ──
        public void get_usingMaterial(){} // RVA: 0x7FFAC2F4F0C0
        public void get_initialized(){} // RVA: 0x7FFAC8AC3770
        public void set_initialized(){} // RVA: 0x7FFAC8AC3780
        public void Awake(){} // RVA: 0x7FFAC8CF5A00
        public void Start(){} // RVA: 0x7FFAC8CF5B50
        public void HintDebugLog(){} // RVA: 0x7FFAC8CF5BC0
        public void OnEnable(){} // RVA: 0x7FFAC8CF5C50
        public void OnDisable(){} // RVA: 0x7FFAC8CF5C80
        public void OnParentHandInputFocusLost(){} // RVA: 0x7FFAC8CF5CC0
        public void SetInputSource(){} // RVA: 0x7FFAC8CF5CE0
        public void OnHandInitialized(){} // RVA: 0x7FFAC8CF5DD0
        public void OnRenderModelLoaded(){} // RVA: 0x7FFAC8CF6310
        public void DoInitialize(){} // RVA: 0x7FFAC8CF6630
        public void CreateAndAddButtonInfo(){} // RVA: 0x7FFAC8CF6730
        public void ComputeTextEndTransforms(){} // RVA: 0x7FFAC8CF88D0
        public void ShowButtonHint(){} // RVA: 0x7FFAC8CFBD10 | overloaded x2
        public void HideAllButtonHints(){} // RVA: 0x7FFAC8CFBEF0 | overloaded x2
        public void HideButtonHint(){} // RVA: 0x7FFAC8CFBE00 | overloaded x2
        public void IsButtonHintActive(){} // RVA: 0x7FFAC8CFBFD0 | overloaded x2
        public void TestButtonHints(){} // RVA: 0x7FFAC8CFA390
        public void TestTextHints(){} // RVA: 0x7FFAC8CFA430
        public void Update(){} // RVA: 0x7FFAC8CFA4D0
        public void UpdateTextHint(){} // RVA: 0x7FFAC8CFAB80
        public void Clear(){} // RVA: 0x7FFAC8CFB270
        public void ShowText(){} // RVA: 0x7FFAC8CFB300
        public void HideText(){} // RVA: 0x7FFAC8CFB6C0
        public void HideAllText(){} // RVA: 0x7FFAC8CFB850
        public void GetActiveHintText(){} // RVA: 0x7FFAC8CFC680 | overloaded x2
        public void GetControllerButtonHints(){} // RVA: 0x7FFAC8CFBB80
        public void ShowTextHint(){} // RVA: 0x7FFAC8CFC0C0
        public void HideTextHint(){} // RVA: 0x7FFAC8CFC290
        public void HideAllTextHints(){} // RVA: 0x7FFAC8CFC5A0
        public void .ctor(){} // RVA: 0x7FFAC8CFC870
    }

    public class ControllerHoverHighlight : MonoBehaviour
    {
        public UnityEngine.Material highLightMaterial; // 0x20
        public bool fireHapticsOnHightlight; // 0x28
        public Valve.VR.InteractionSystem.Hand hand; // 0x30
        public Valve.VR.InteractionSystem.RenderModel renderModel; // 0x38
        public Action renderModelLoadedAction; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CC04C0
        public void OnHandInitialized(){} // RVA: 0x7FFAC8CC0550
        public void RenderModel_onControllerLoaded(){} // RVA: 0x7FFAC8CC0CC0
        public void OnParentHandHoverBegin(){} // RVA: 0x7FFAC8CC0D00
        public void OnParentHandHoverEnd(){} // RVA: 0x7FFAC8CC0FB0
        public void OnParentHandInputFocusAcquired(){} // RVA: 0x7FFAC8CC0FC0
        public void OnParentHandInputFocusLost(){} // RVA: 0x7FFAC8CC0FB0
        public void ShowHighlight(){} // RVA: 0x7FFAC8CC1330
        public void HideHighlight(){} // RVA: 0x7FFAC8CC14A0
        public void .ctor(){} // RVA: 0x7FFAC2F58BB0
    }

    public class CustomEvents : Object
    {
    }

    public class DebugUI : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.Player instance; // 0x20
        public Valve.VR.InteractionSystem.DebugUI _instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAC8CC16C0
        public void Start(){} // RVA: 0x7FFAC8CC1850
        public void OnGUI(){} // RVA: 0x7FFAC8CC18C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class DestroyOnDetachedFromHand : MonoBehaviour
    {
        // ── Methods ──
        public void OnDetachedFromHand(){} // RVA: 0x7FFAC8CC1970
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class DestroyOnParticleSystemDeath : MonoBehaviour
    {
        public UnityEngine.ParticleSystem particles; // 0x20

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CC1A10
        public void CheckParticleSystem(){} // RVA: 0x7FFAC8CC1AD0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class DestroyOnTriggerEnter : MonoBehaviour
    {
        public string tagFilter; // 0x20
        public bool useTag; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8CC1BD0
        public void OnTriggerEnter(){} // RVA: 0x7FFAC8CC1BF0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class DistanceHaptics : MonoBehaviour
    {
        public UnityEngine.Transform firstTransform; // 0x20
        public UnityEngine.Transform secondTransform; // 0x28
        public UnityEngine.AnimationCurve distanceIntensityCurve; // 0x30
        public UnityEngine.AnimationCurve pulseIntervalCurve; // 0x38

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8CC1E90
        public void .ctor(){} // RVA: 0x7FFAC8CC1F30
    }

    public class DontDestroyOnLoad : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CC2460
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class EnumFlags : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Equippable : MonoBehaviour
    {
        public UnityEngine.Transform[] attachedHandType; // 0x20
        public 0x6B20BAC8 defaultHand; // 0x28
        public UnityEngine.Vector3 initialScale; // 0x2C
        public Valve.VR.InteractionSystem.Interactable interactable; // 0x38

        // ── Methods ──
        public void get_attachedHandType(){} // RVA: 0x7FFAC8CC24F0
        public void Start(){} // RVA: 0x7FFAC8CC2600
        public void Update(){} // RVA: 0x7FFAC8CC2750
        public void .ctor(){} // RVA: 0x7FFAC8CC2B10
    }

    public class ExplosionWobble : MonoBehaviour
    {
        // ── Methods ──
        public void ExplosionEvent(){} // RVA: 0x7FFAC8D07570
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class FallbackCameraController : MonoBehaviour
    {
        public float speed; // 0x20
        public float shiftSpeed; // 0x24
        public bool showInstructions; // 0x28
        public UnityEngine.Vector3 startEulerAngles; // 0x2C
        public UnityEngine.Vector3 startMousePosition; // 0x38
        public float realTime; // 0x44

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC8CC2B60
        public void Update(){} // RVA: 0x7FFAC8CC2BC0
        public void OnGUI(){} // RVA: 0x7FFAC8CC3590
        public void .ctor(){} // RVA: 0x7FFAC8CC3610
    }

    public class FireSource : MonoBehaviour
    {
        public UnityEngine.GameObject fireParticlePrefab; // 0x20
        public bool startActive; // 0x28
        public UnityEngine.GameObject fireObject; // 0x30
        public UnityEngine.ParticleSystem customParticles; // 0x38
        public bool isBurning; // 0x40
        public float burnTime; // 0x44
        public float ignitionDelay; // 0x48
        public float ignitionTime; // 0x4C
        public Valve.VR.InteractionSystem.Hand hand; // 0x50
        public UnityEngine.AudioSource ignitionSound; // 0x58
        public bool canSpreadFromThisSource; // 0x60

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D076E0
        public void Update(){} // RVA: 0x7FFAC8D076F0
        public void OnTriggerEnter(){} // RVA: 0x7FFAC8D07880
        public void FireExposure(){} // RVA: 0x7FFAC8D07930
        public void StartBurning(){} // RVA: 0x7FFAC8D07B80
        public void .ctor(){} // RVA: 0x7FFAC402DD00
    }

    public class Hand : MonoBehaviour
    {
        public 0x6B20BC28 AttachedObjects;
        public Valve.VR.InteractionSystem.Hand hoverLocked; // 0x20
        public 0x6B209C88 isActive; // 0x28
        public Valve.VR.SteamVR_Behaviour_Pose isPoseValid; // 0x30
        public Valve.VR.SteamVR_Action_Boolean hoveringInteractable; // 0x38
        public Valve.VR.SteamVR_Action_Boolean currentAttachedObject; // 0x40
        public Valve.VR.SteamVR_Action_Vibration currentAttachedObjectInfo; // 0x48
        public Valve.VR.SteamVR_Action_Boolean currentAttachedTeleportManager; // 0x50
        public bool skeleton; // 0x58
        public UnityEngine.Transform hoverSphereTransform; // 0x60
        public float hoverSphereRadius; // 0x68
        public UnityEngine.LayerMask hoverLayerMask; // 0x6C
        public float hoverUpdateInterval; // 0x70
        public bool useControllerHoverComponent; // 0x74
        public string controllerHoverComponent; // 0x78
        public float controllerHoverRadius; // 0x80
        public bool useFingerJointHover; // 0x84
        public 0x6B207AD8 fingerJointHover; // 0x88
        public float fingerJointHoverRadius; // 0x8C
        public UnityEngine.Transform objectAttachmentPoint; // 0x90
        public UnityEngine.Camera noSteamVRFallbackCamera; // 0x98
        public float noSteamVRFallbackMaxDistanceNoItem; // 0xA0
        public float noSteamVRFallbackMaxDistanceWithItem; // 0xA4
        public float noSteamVRFallbackInteractorDistance; // 0xA8
        public UnityEngine.GameObject renderModelPrefab; // 0xB0
        public System.Collections.Generic.List`1<Valve.VR.InteractionSystem.RenderModel> renderModels; // 0xB8
        public Valve.VR.InteractionSystem.RenderModel mainRenderModel; // 0xC0
        public Valve.VR.InteractionSystem.RenderModel hoverhighlightRenderModel; // 0xC8
        public bool showDebugText; // 0xD0
        public bool spewDebugText; // 0xD1
        public bool showDebugInteractables; // 0xD2
        public System.Collections.Generic.List`1<AttachedObject> attachedObjects; // 0xD8
        public bool <hoverLocked>k__BackingField; // 0xE0
        public Valve.VR.InteractionSystem.Interactable _hoveringInteractable; // 0xE8
        public UnityEngine.TextMesh debugText; // 0xF0
        public int prevOverlappingColliders; // 0xF8
        public int ColliderArraySize;
        public UnityEngine.Collider[] overlappingColliders; // 0x100
        public Valve.VR.InteractionSystem.Player playerInstance; // 0x108
        public UnityEngine.GameObject applicationLostFocusObject; // 0x110
        public Action inputFocusAction; // 0x118
        public float MaxVelocityChange;
        public float VelocityMagic;
        public float AngularVelocityMagic;
        public float MaxAngularVelocityChange;

        // ── Methods ──
        public void get_AttachedObjects(){} // RVA: 0x7FFAC8CC3670
        public void get_hoverLocked(){} // RVA: 0x7FFAC304CF80
        public void set_hoverLocked(){} // RVA: 0x7FFAC304CF90
        public void get_isActive(){} // RVA: 0x7FFAC8CC3740
        public void get_isPoseValid(){} // RVA: 0x7FFAC8CC3900
        public void get_hoveringInteractable(){} // RVA: 0x7FFAC2FA2970
        public void set_hoveringInteractable(){} // RVA: 0x7FFAC8CC3950
        public void get_currentAttachedObject(){} // RVA: 0x7FFAC8CC3EF0
        public void get_currentAttachedObjectInfo(){} // RVA: 0x7FFAC8CC3FA0
        public void get_currentAttachedTeleportManager(){} // RVA: 0x7FFAC8CC41F0
        public void get_skeleton(){} // RVA: 0x7FFAC8CC4290
        public void ShowController(){} // RVA: 0x7FFAC8CC4380
        public void HideController(){} // RVA: 0x7FFAC8CC4530
        public void ShowSkeleton(){} // RVA: 0x7FFAC8CC46E0
        public void HideSkeleton(){} // RVA: 0x7FFAC8CC4890
        public void HasSkeleton(){} // RVA: 0x7FFAC8CC4A40
        public void Show(){} // RVA: 0x7FFAC8CC4BD0
        public void Hide(){} // RVA: 0x7FFAC8CC4BE0
        public void SetVisibility(){} // RVA: 0x7FFAC8CC4BF0
        public void SetSkeletonRangeOfMotion(){} // RVA: 0x7FFAC8CC4CF0
        public void SetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFAC8CC4DD0
        public void ResetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFAC8CC5000
        public void SetAnimationState(){} // RVA: 0x7FFAC8CC51C0
        public void StopAnimation(){} // RVA: 0x7FFAC8CC53C0
        public void AttachObject(){} // RVA: 0x7FFAC8CC55C0
        public void ObjectIsAttached(){} // RVA: 0x7FFAC8CC87B0
        public void ForceHoverUnlock(){} // RVA: 0x7FFAC3399400
        public void DetachObject(){} // RVA: 0x7FFAC8CC89A0
        public void GetTrackedObjectVelocity(){} // RVA: 0x7FFAC8CCA100
        public void GetTrackedObjectAngularVelocity(){} // RVA: 0x7FFAC8CCA540
        public void GetEstimatedPeakVelocities(){} // RVA: 0x7FFAC8CCA980
        public void CleanUpAttachedObjectStack(){} // RVA: 0x7FFAC8CCAAF0
        public void Awake(){} // RVA: 0x7FFAC8CCAC70
        public void OnDestroy(){} // RVA: 0x7FFAC8CCB4F0
        public void OnTransformUpdated(){} // RVA: 0x7FFAC8AEC8C0
        public void Start(){} // RVA: 0x7FFAC8CCB6D0
        public void UpdateHovering(){} // RVA: 0x7FFAC8CCB770
        public void CheckHoveringForTransform(){} // RVA: 0x7FFAC8CCBD30
        public void UpdateNoSteamVRFallback(){} // RVA: 0x7FFAC8CCC990
        public void UpdateDebugText(){} // RVA: 0x7FFAC8CCD120
        public void OnEnable(){} // RVA: 0x7FFAC8CCDD20
        public void OnDisable(){} // RVA: 0x7FFAC8CCDEB0
        public void Update(){} // RVA: 0x7FFAC8CCDF30
        public void IsStillHovering(){} // RVA: 0x7FFAC8CCE120
        public void HandFollowUpdate(){} // RVA: 0x7FFAC8CCE260
        public void FixedUpdate(){} // RVA: 0x7FFAC8CCF970
        public void UpdateAttachedVelocity(){} // RVA: 0x7FFAC8CD02C0
        public void ResetAttachedTransform(){} // RVA: 0x7FFAC8CD0680
        public void TargetItemPosition(){} // RVA: 0x7FFAC8CD08F0
        public void TargetItemRotation(){} // RVA: 0x7FFAC8CD0D90
        public void GetUpdatedAttachedVelocities(){} // RVA: 0x7FFAC8CD1640
        public void OnInputFocus(){} // RVA: 0x7FFAC8CD1E10
        public void OnDrawGizmos(){} // RVA: 0x7FFAC8CD1FB0
        public void HandDebugLog(){} // RVA: 0x7FFAC8CD2690
        public void HoverLock(){} // RVA: 0x7FFAC8CD2750
        public void HoverUnlock(){} // RVA: 0x7FFAC8CD2800
        public void TriggerHapticPulse(){} // RVA: 0x7FFAC8CD29F0 | overloaded x2
        public void ShowGrabHint(){} // RVA: 0x7FFAC8CD2B40 | overloaded x2
        public void HideGrabHint(){} // RVA: 0x7FFAC8CD2B30
        public void GetGrabStarting(){} // RVA: 0x7FFAC8CD2B70
        public void GetGrabEnding(){} // RVA: 0x7FFAC8CD2F70
        public void IsGrabEnding(){} // RVA: 0x7FFAC8CD3240
        public void IsGrabbingWithType(){} // RVA: 0x7FFAC8CD34C0
        public void IsGrabbingWithOppositeType(){} // RVA: 0x7FFAC8CD3650
        public void GetBestGrabbingType(){} // RVA: 0x7FFAC8CD37F0 | overloaded x2
        public void InitController(){} // RVA: 0x7FFAC8CD39C0
        public void SetRenderModel(){} // RVA: 0x7FFAC8CD46A0
        public void SetHoverRenderModel(){} // RVA: 0x7FFAC8CD4810
        public void GetDeviceIndex(){} // RVA: 0x7FFAC8CD48C0
        public void .ctor(){} // RVA: 0x7FFAC8CD4910
    }

    public class HandCollider : MonoBehaviour
    {
        public UnityEngine.Rigidbody rigidbody; // 0x20
        public Valve.VR.InteractionSystem.HandPhysics hand; // 0x28
        public UnityEngine.LayerMask collisionMask; // 0x30
        public UnityEngine.Collider[] colliders; // 0x38
        public FingerColliders fingerColliders; // 0x40
        public UnityEngine.PhysicMaterial physicMaterial_lowfriction;
        public UnityEngine.PhysicMaterial physicMaterial_highfriction; // 0x8
        public float scale; // 0x48
        public UnityEngine.Vector3 center; // 0x4C
        public UnityEngine.Vector3 targetPosition; // 0x58
        public UnityEngine.Quaternion targetRotation; // 0x64
        public float MaxVelocityChange;
        public float VelocityMagic;
        public float AngularVelocityMagic;
        public float MaxAngularVelocityChange;
        public bool collidersInRadius; // 0x74
        public float minCollisionEnergy;
        public float maxCollisionEnergy;
        public float minCollisionHapticsTime;
        public float lastCollisionHapticsTime; // 0x78

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CD55E0
        public void Start(){} // RVA: 0x7FFAC8CD56C0
        public void SetPhysicMaterial(){} // RVA: 0x7FFAC8CD5EF0
        public void SetCollisionDetectionEnabled(){} // RVA: 0x7FFAC8CD6050
        public void MoveTo(){} // RVA: 0x7FFAC8CD60C0
        public void TeleportTo(){} // RVA: 0x7FFAC8CD60E0
        public void Reset(){} // RVA: 0x7FFAC8CD6390
        public void SetCenterPoint(){} // RVA: 0x7FFAC8CD63D0
        public void ExecuteFixedUpdate(){} // RVA: 0x7FFAC8CD63E0
        public void GetTargetVelocities(){} // RVA: 0x7FFAC8CD68F0
        public void OnCollisionEnter(){} // RVA: 0x7FFAC8CD6E20
        public void .ctor(){} // RVA: 0x7FFAC8CD7150
    }

    public class HandEvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8CD55A0
    }

    public class HandPhysics : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.HandCollider handColliderPrefab; // 0x20
        public Valve.VR.InteractionSystem.HandCollider handCollider; // 0x28
        public UnityEngine.LayerMask clearanceCheckMask; // 0x30
        public Valve.VR.InteractionSystem.Hand hand; // 0x38
        public float handResetDistance;
        public float collisionReenableClearanceRadius;
        public bool initialized; // 0x40
        public bool collisionsEnabled; // 0x41
        public UnityEngine.Matrix4x4 wristToRoot; // 0x44
        public UnityEngine.Matrix4x4 rootToArmature; // 0x84
        public UnityEngine.Matrix4x4 wristToArmature; // 0xC4
        public UnityEngine.Vector3 targetPosition; // 0x104
        public UnityEngine.Quaternion targetRotation; // 0x110
        public int wristBone;
        public int rootBone;
        public UnityEngine.Collider[] clearanceBuffer; // 0x120
        public UnityEngine.Transform wrist; // 0x128
        public int thumbBone;
        public int indexBone;
        public int middleBone;
        public int ringBone;
        public int pinkyBone;

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8CD74E0
        public void FixedUpdate(){} // RVA: 0x7FFAC8CD7BB0
        public void UpdateCenterPoint(){} // RVA: 0x7FFAC8CD7E30
        public void UpdatePositions(){} // RVA: 0x7FFAC8CD80F0
        public void UpdateFingertips(){} // RVA: 0x7FFAC8CD9220
        public void UpdateHand(){} // RVA: 0x7FFAC8CD96F0
        public void ProcessPos(){} // RVA: 0x7FFAC8CD9D00
        public void ProcessRot(){} // RVA: 0x7FFAC8CD9E80
        public void .ctor(){} // RVA: 0x7FFAC8CD9F40
    }

    public class HapticRack : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.LinearMapping linearMapping; // 0x20
        public int teethCount; // 0x28
        public int minimumPulseDuration; // 0x2C
        public int maximumPulseDuration; // 0x30
        public UnityEngine.Events.UnityEvent onPulse; // 0x38
        public Valve.VR.InteractionSystem.Hand hand; // 0x40
        public int previousToothIndex; // 0x48

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CDA0A0
        public void OnHandHoverBegin(){} // RVA: 0x7FFAC2F49200
        public void OnHandHoverEnd(){} // RVA: 0x7FFAC81F6D10
        public void Update(){} // RVA: 0x7FFAC8CDA1E0
        public void Pulse(){} // RVA: 0x7FFAC8CDA360
        public void .ctor(){} // RVA: 0x7FFAC8CDA4A0
    }

    public class HideOnHandFocusLost : MonoBehaviour
    {
        // ── Methods ──
        public void OnHandFocusLost(){} // RVA: 0x7FFAC3697F10
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class HoverButton : MonoBehaviour
    {
        public UnityEngine.Transform movingPart; // 0x20
        public UnityEngine.Vector3 localMoveDistance; // 0x28
        public float engageAtPercent; // 0x34
        public float disengageAtPercent; // 0x38
        public Valve.VR.InteractionSystem.HandEvent onButtonDown; // 0x40
        public Valve.VR.InteractionSystem.HandEvent onButtonUp; // 0x48
        public Valve.VR.InteractionSystem.HandEvent onButtonIsPressed; // 0x50
        public bool engaged; // 0x58
        public bool buttonDown; // 0x59
        public bool buttonUp; // 0x5A
        public UnityEngine.Vector3 startPosition; // 0x5C
        public UnityEngine.Vector3 endPosition; // 0x68
        public UnityEngine.Vector3 handEnteredPosition; // 0x74
        public bool hovering; // 0x80
        public Valve.VR.InteractionSystem.Hand lastHoveredHand; // 0x88

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8CDA500
        public void HandHoverUpdate(){} // RVA: 0x7FFAC8CDA7D0
        public void LateUpdate(){} // RVA: 0x7FFAC8CDAED0
        public void InvokeEvents(){} // RVA: 0x7FFAC8CDB000
        public void .ctor(){} // RVA: 0x7FFAC8CDB0E0
    }

    public class IgnoreHovering : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.Hand onlyIgnoreHand; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class IgnoreTeleportTrace : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class InputModule : BaseInputModule
    {
        public UnityEngine.GameObject instance; // 0x58
        public Valve.VR.InteractionSystem.InputModule _instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAC8CDB150
        public void ShouldActivateModule(){} // RVA: 0x7FFAC8CDB2E0
        public void HoverBegin(){} // RVA: 0x7FFAC8CDB3C0
        public void HoverEnd(){} // RVA: 0x7FFAC8CDB4C0
        public void Submit(){} // RVA: 0x7FFAC2FE9510
        public void Process(){} // RVA: 0x7FFAC8CDB5E0
        public void .ctor(){} // RVA: 0x7FFAC8CDB7B0
    }

    public class Interactable : MonoBehaviour
    {
        public Valve.VR.SteamVR_ActionSet hoveringHand; // 0x20
        public bool isDestroying; // 0x28
        public bool isHovering; // 0x29
        public bool wasHovering; // 0x2A
        public int handAnimationOnPickup; // 0x2C
        public 0x6B207A28 setRangeOfMotionOnPickup; // 0x30
        public OnAttachedToHandDelegate onAttachedToHand; // 0x38
        public OnDetachedFromHandDelegate onDetachedFromHand; // 0x40
        public bool useHandObjectAttachmentPoint; // 0x48
        public bool attachEaseIn; // 0x49
        public UnityEngine.AnimationCurve snapAttachEaseInCurve; // 0x50
        public float snapAttachEaseInTime; // 0x58
        public bool snapAttachEaseInCompleted; // 0x5C
        public Valve.VR.SteamVR_Skeleton_Poser skeletonPoser; // 0x60
        public bool handFollowTransform; // 0x68
        public bool highlightOnHover; // 0x69
        public UnityEngine.MeshRenderer[] highlightRenderers; // 0x70
        public UnityEngine.MeshRenderer[] existingRenderers; // 0x78
        public UnityEngine.GameObject highlightHolder; // 0x80
        public UnityEngine.SkinnedMeshRenderer[] highlightSkinnedRenderers; // 0x88
        public UnityEngine.SkinnedMeshRenderer[] existingSkinnedRenderers; // 0x90
        public UnityEngine.Material highlightMat;
        public UnityEngine.GameObject[] hideHighlight; // 0x98
        public int hoverPriority; // 0xA0
        public Valve.VR.InteractionSystem.Hand attachedToHand; // 0xA8
        public System.Collections.Generic.List`1<Valve.VR.InteractionSystem.Hand> hoveringHands; // 0xB0
        public bool <isDestroying>k__BackingField; // 0xB8
        public bool <isHovering>k__BackingField; // 0xB9
        public bool <wasHovering>k__BackingField; // 0xBA
        public float blendToPoseTime; // 0xBC
        public float releasePoseBlendTime; // 0xC0

        // ── Methods ──
        public void add_onAttachedToHand(){} // RVA: 0x7FFAC8CDB7C0
        public void remove_onAttachedToHand(){} // RVA: 0x7FFAC8CDB8B0
        public void add_onDetachedFromHand(){} // RVA: 0x7FFAC8CDB9A0
        public void remove_onDetachedFromHand(){} // RVA: 0x7FFAC8CDBA90
        public void get_hoveringHand(){} // RVA: 0x7FFAC8CDBB80
        public void get_isDestroying(){} // RVA: 0x7FFAC41F1470
        public void set_isDestroying(){} // RVA: 0x7FFAC41EEB20
        public void get_isHovering(){} // RVA: 0x7FFAC623E950
        public void set_isHovering(){} // RVA: 0x7FFAC623E960
        public void get_wasHovering(){} // RVA: 0x7FFAC8CDBC10
        public void set_wasHovering(){} // RVA: 0x7FFAC8CDBC20
        public void Awake(){} // RVA: 0x7FFAC8CDBC30
        public void Start(){} // RVA: 0x7FFAC8CDBCC0
        public void ShouldIgnoreHighlight(){} // RVA: 0x7FFAC8CDC0A0
        public void ShouldIgnore(){} // RVA: 0x7FFAC8CDC120
        public void CreateHighlightRenderers(){} // RVA: 0x7FFAC8CDC2B0
        public void UpdateHighlightRenderers(){} // RVA: 0x7FFAC8CDCC00
        public void OnHandHoverBegin(){} // RVA: 0x7FFAC8CDD8B0
        public void OnHandHoverEnd(){} // RVA: 0x7FFAC8CDD960
        public void Update(){} // RVA: 0x7FFAC8CDDAE0
        public void OnAttachedToHand(){} // RVA: 0x7FFAC8CDDC10
        public void OnDetachedFromHand(){} // RVA: 0x7FFAC8CDDFD0
        public void OnDestroy(){} // RVA: 0x7FFAC8CDE4F0
        public void OnDisable(){} // RVA: 0x7FFAC8CDE730
        public void .ctor(){} // RVA: 0x7FFAC8CDE8E0
    }

    public class InteractableDebug : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.Hand isThrowable; // 0x20
        public float simulateReleasesForXSecondsAroundRelease; // 0x28
        public float simulateReleasesEveryXSeconds; // 0x2C
        public bool setPositionsForSimulations; // 0x30
        public UnityEngine.Renderer[] selfRenderers; // 0x38
        public UnityEngine.Collider[] colliders; // 0x40
        public UnityEngine.Color lastColor; // 0x48
        public Valve.VR.InteractionSystem.Throwable throwable; // 0x58
        public bool onlyColorOnChange;
        public UnityEngine.Rigidbody rigidbody; // 0x60
        public bool isSimulation; // 0x68

        // ── Methods ──
        public void get_isThrowable(){} // RVA: 0x7FFAC8CDEB00
        public void Awake(){} // RVA: 0x7FFAC8CDEBD0
        public void OnAttachedToHand(){} // RVA: 0x7FFAC8CDEE00
        public void HandAttachedUpdate(){} // RVA: 0x7FFAC8CDEE80
        public void OnDetachedFromHand(){} // RVA: 0x7FFAC8CDEFE0
        public void GetColliders(){} // RVA: 0x7FFAC2F9E740
        public void IgnoreObject(){} // RVA: 0x7FFAC8CDF5B0
        public void SetIsSimulation(){} // RVA: 0x7FFAC8CDF6C0
        public void CreateSimulation(){} // RVA: 0x7FFAC8CDF6D0
        public void CreateMarker(){} // RVA: 0x7FFAC8CDFAC0 | overloaded x2
        public void ColorSelf(){} // RVA: 0x7FFAC8CE0270
        public void ColorThing(){} // RVA: 0x7FFAC8CE0340
        public void .ctor(){} // RVA: 0x7FFAC8CE0410
    }

    public class InteractableHoverEvents : MonoBehaviour
    {
        public UnityEngine.Events.UnityEvent onHandHoverBegin; // 0x20
        public UnityEngine.Events.UnityEvent onHandHoverEnd; // 0x28
        public UnityEngine.Events.UnityEvent onAttachedToHand; // 0x30
        public UnityEngine.Events.UnityEvent onDetachedFromHand; // 0x38

        // ── Methods ──
        public void OnHandHoverBegin(){} // RVA: 0x7FFAC8CE0460
        public void OnHandHoverEnd(){} // RVA: 0x7FFAC8CE0480
        public void OnAttachedToHand(){} // RVA: 0x7FFAC8CE04A0
        public void OnDetachedFromHand(){} // RVA: 0x7FFAC8CE04C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class ItemPackage : MonoBehaviour
    {
        public string name; // 0x20
        public 0x6B20C308 packageType; // 0x28
        public UnityEngine.GameObject itemPrefab; // 0x30
        public UnityEngine.GameObject otherHandItemPrefab; // 0x38
        public UnityEngine.GameObject previewPrefab; // 0x40
        public UnityEngine.GameObject fadedPreviewPrefab; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class ItemPackageReference : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.ItemPackage itemPackage; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class ItemPackageSpawner : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.ItemPackage itemPackage; // 0x20
        public bool useItemPackagePreview; // 0x28
        public bool useFadedPreview; // 0x29
        public UnityEngine.GameObject previewObject; // 0x30
        public bool requireGrabActionToTake; // 0x38
        public bool requireReleaseActionToReturn; // 0x39
        public bool showTriggerHint; // 0x3A
        public 0x6B20BC28 attachmentFlags; // 0x3C
        public bool takeBackItem; // 0x40
        public bool acceptDifferentItems; // 0x41
        public UnityEngine.GameObject spawnedItem; // 0x48
        public bool itemIsSpawned; // 0x50
        public UnityEngine.Events.UnityEvent pickupEvent; // 0x58
        public UnityEngine.Events.UnityEvent dropEvent; // 0x60
        public bool justPickedUpItem; // 0x68

        // ── Methods ──
        public void get_itemPackage(){} // RVA: 0x7FFAC2F4F0C0
        public void set_itemPackage(){} // RVA: 0x7FFAC8CE04E0
        public void CreatePreviewObject(){} // RVA: 0x7FFAC8CE04F0
        public void Start(){} // RVA: 0x7FFAC8CE0B00
        public void VerifyItemPackage(){} // RVA: 0x7FFAC8CE0B00
        public void ItemPackageNotValid(){} // RVA: 0x7FFAC8CE0C90
        public void ClearPreview(){} // RVA: 0x7FFAC8CE0E00
        public void Update(){} // RVA: 0x7FFAC8CE1150
        public void OnHandHoverBegin(){} // RVA: 0x7FFAC8CE1250
        public void TakeBackItem(){} // RVA: 0x7FFAC8CE1430
        public void GetAttachedItemPackage(){} // RVA: 0x7FFAC8CE1490
        public void HandHoverUpdate(){} // RVA: 0x7FFAC8CE1650
        public void OnHandHoverEnd(){} // RVA: 0x7FFAC8CE1850
        public void RemoveMatchingItemsFromHandStack(){} // RVA: 0x7FFAC8CE18A0
        public void RemoveMatchingItemTypesFromHand(){} // RVA: 0x7FFAC8CE1CD0
        public void SpawnAndAttachObject(){} // RVA: 0x7FFAC8CE1F40
        public void .ctor(){} // RVA: 0x7FFAC8CE2570
    }

    public class LinearAnimation : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.LinearMapping linearMapping; // 0x20
        public UnityEngine.Animation animation; // 0x28
        public UnityEngine.AnimationState animState; // 0x30
        public float animLength; // 0x38
        public float lastValue; // 0x3C

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CE25C0
        public void Update(){} // RVA: 0x7FFAC8CE2A70
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class LinearAnimator : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.LinearMapping linearMapping; // 0x20
        public UnityEngine.Animator animator; // 0x28
        public float currentLinearMapping; // 0x30
        public int framesUnchanged; // 0x34

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CE2AD0
        public void Update(){} // RVA: 0x7FFAC8CE2D80
        public void .ctor(){} // RVA: 0x7FFAC8CE2E60
    }

    public class LinearAudioPitch : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.LinearMapping linearMapping; // 0x20
        public UnityEngine.AnimationCurve pitchCurve; // 0x28
        public float minPitch; // 0x30
        public float maxPitch; // 0x34
        public bool applyContinuously; // 0x38
        public UnityEngine.AudioSource audioSource; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CE2EB0
        public void Update(){} // RVA: 0x7FFAC8CE3100
        public void Apply(){} // RVA: 0x7FFAC8CE3220
        public void .ctor(){} // RVA: 0x7FFAC42940A0
    }

    public class LinearBlendshape : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.LinearMapping linearMapping; // 0x20
        public UnityEngine.SkinnedMeshRenderer skinnedMesh; // 0x28
        public float lastValue; // 0x30

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CE3330
        public void Update(){} // RVA: 0x7FFAC8CE3580
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class LinearDisplacement : MonoBehaviour
    {
        public UnityEngine.Vector3 displacement; // 0x20
        public Valve.VR.InteractionSystem.LinearMapping linearMapping; // 0x30
        public UnityEngine.Vector3 initialPosition; // 0x38

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8CE3660
        public void Update(){} // RVA: 0x7FFAC8CE3850
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class LinearDrive : MonoBehaviour
    {
        public UnityEngine.Transform startPosition; // 0x20
        public UnityEngine.Transform endPosition; // 0x28
        public Valve.VR.InteractionSystem.LinearMapping linearMapping; // 0x30
        public bool repositionGameObject; // 0x38
        public bool maintainMomemntum; // 0x39
        public float momemtumDampenRate; // 0x3C
        public 0x6B20BC28 attachmentFlags; // 0x40
        public float initialMappingOffset; // 0x44
        public int numMappingChangeSamples; // 0x48
        public float[] mappingChangeSamples; // 0x50
        public float prevMapping; // 0x58
        public float mappingChangeRate; // 0x5C
        public int sampleCount; // 0x60
        public Valve.VR.InteractionSystem.Interactable interactable; // 0x68

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CE3A30
        public void Start(){} // RVA: 0x7FFAC8CE3B50
        public void HandHoverUpdate(){} // RVA: 0x7FFAC8CE3E60
        public void HandAttachedUpdate(){} // RVA: 0x7FFAC8CE4060
        public void OnDetachedFromHand(){} // RVA: 0x7FFAC8CE4190
        public void CalculateMappingChangeRate(){} // RVA: 0x7FFAC8CE4190
        public void UpdateLinearMapping(){} // RVA: 0x7FFAC8CE4210
        public void CalculateLinearMapping(){} // RVA: 0x7FFAC8CE4520
        public void Update(){} // RVA: 0x7FFAC8CE4820
        public void .ctor(){} // RVA: 0x7FFAC8CE4B40
    }

    public class LinearMapping : MonoBehaviour
    {
        public float value; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Longbow : MonoBehaviour
    {
        public 0x6B20D540 currentHandGuess; // 0x20
        public float timeOfPossibleHandSwitch; // 0x24
        public float timeBeforeConfirmingHandSwitch; // 0x28
        public bool possibleHandSwitch; // 0x2C
        public UnityEngine.Transform pivotTransform; // 0x30
        public UnityEngine.Transform handleTransform; // 0x38
        public Valve.VR.InteractionSystem.Hand hand; // 0x40
        public Valve.VR.InteractionSystem.ArrowHand arrowHand; // 0x48
        public UnityEngine.Transform nockTransform; // 0x50
        public UnityEngine.Transform nockRestTransform; // 0x58
        public bool autoSpawnArrowHand; // 0x60
        public Valve.VR.InteractionSystem.ItemPackage arrowHandItemPackage; // 0x68
        public UnityEngine.GameObject arrowHandPrefab; // 0x70
        public bool nocked; // 0x78
        public bool pulled; // 0x79
        public float minPull;
        public float maxPull;
        public float nockDistanceTravelled; // 0x7C
        public float hapticDistanceThreshold; // 0x80
        public float lastTickDistance; // 0x84
        public float bowPullPulseStrengthLow;
        public float bowPullPulseStrengthHigh;
        public UnityEngine.Vector3 bowLeftVector; // 0x88
        public float arrowMinVelocity; // 0x94
        public float arrowMaxVelocity; // 0x98
        public float arrowVelocity; // 0x9C
        public float minStrainTickTime; // 0xA0
        public float maxStrainTickTime; // 0xA4
        public float nextStrainTick; // 0xA8
        public bool lerpBackToZeroRotation; // 0xAC
        public float lerpStartTime; // 0xB0
        public float lerpDuration; // 0xB4
        public UnityEngine.Quaternion lerpStartRotation; // 0xB8
        public float nockLerpStartTime; // 0xC8
        public UnityEngine.Quaternion nockLerpStartRotation; // 0xCC
        public float drawOffset; // 0xDC
        public Valve.VR.InteractionSystem.LinearMapping bowDrawLinearMapping; // 0xE0
        public UnityEngine.Vector3 lateUpdatePos; // 0xE8
        public UnityEngine.Quaternion lateUpdateRot; // 0xF4
        public Valve.VR.InteractionSystem.SoundBowClick drawSound; // 0x108
        public float drawTension; // 0x110
        public Valve.VR.InteractionSystem.SoundPlayOneshot arrowSlideSound; // 0x118
        public Valve.VR.InteractionSystem.SoundPlayOneshot releaseSound; // 0x120
        public Valve.VR.InteractionSystem.SoundPlayOneshot nockSound; // 0x128
        public Action newPosesAppliedAction; // 0x130

        // ── Methods ──
        public void OnAttachedToHand(){} // RVA: 0x7FFAC2F49200
        public void HandAttachedUpdate(){} // RVA: 0x7FFAC8D08120
        public void ArrowReleased(){} // RVA: 0x7FFAC8D091F0
        public void ResetDrawAnim(){} // RVA: 0x7FFAC8D09370
        public void GetArrowVelocity(){} // RVA: 0x7FFAC3142100
        public void StartRotationLerp(){} // RVA: 0x7FFAC8D09410
        public void StartNock(){} // RVA: 0x7FFAC8D094F0
        public void EvaluateHandedness(){} // RVA: 0x7FFAC8D09670
        public void DoHandednessCheck(){} // RVA: 0x7FFAC8D097C0
        public void ArrowInPosition(){} // RVA: 0x7FFAC8D098A0
        public void ReleaseNock(){} // RVA: 0x7FFAC8D09990
        public void ShutDown(){} // RVA: 0x7FFAC8D09A10
        public void OnHandFocusLost(){} // RVA: 0x7FFAC3697F10
        public void OnHandFocusAcquired(){} // RVA: 0x7FFAC8D09DE0
        public void OnDetachedFromHand(){} // RVA: 0x7FFAC8D09F00
        public void OnDestroy(){} // RVA: 0x7FFAC8D09FA0
        public void .ctor(){} // RVA: 0x7FFAC8D09FB0
    }

    public class ModalThrowable : Throwable
    {
        public UnityEngine.Transform gripOffset; // 0xC0
        public UnityEngine.Transform pinchOffset; // 0xC8

        // ── Methods ──
        public void HandHoverUpdate(){} // RVA: 0x7FFAC8CE4BA0
        public void HandAttachedUpdate(){} // RVA: 0x7FFAC8CE4C90
        public void .ctor(){} // RVA: 0x7FFAC8CE4F30
    }

    public class PlaySound : MonoBehaviour
    {
        public UnityEngine.AudioClip[] waveFile; // 0x20
        public bool stopOnPlay; // 0x28
        public bool disableOnEnd; // 0x29
        public bool looping; // 0x2A
        public bool stopOnEnd; // 0x2B
        public bool playOnAwakeWithDelay; // 0x2C
        public bool useRandomVolume; // 0x2D
        public float volMin; // 0x30
        public float volMax; // 0x34
        public bool useRandomPitch; // 0x38
        public float pitchMin; // 0x3C
        public float pitchMax; // 0x40
        public bool useRetriggerTime; // 0x44
        public float timeInitial; // 0x48
        public float timeMin; // 0x4C
        public float timeMax; // 0x50
        public bool useRandomSilence; // 0x54
        public float percentToNotPlay; // 0x58
        public float delayOffsetTime; // 0x5C
        public UnityEngine.AudioSource audioSource; // 0x60
        public UnityEngine.AudioClip clip; // 0x68

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CE7D00
        public void Play(){} // RVA: 0x7FFAC8CE7FE0
        public void PlayWithDelay(){} // RVA: 0x7FFAC8CE8190
        public void PlayOneShotSound(){} // RVA: 0x7FFAC8CE8210
        public void PlayLooping(){} // RVA: 0x7FFAC8CE83B0
        public void Disable(){} // RVA: 0x7FFAC3697F10
        public void Stop(){} // RVA: 0x7FFAC8CE85C0
        public void SetAudioSource(){} // RVA: 0x7FFAC8CE8620
        public void .ctor(){} // RVA: 0x7FFAC8CE88A0
    }

    public class Player : MonoBehaviour
    {
        public UnityEngine.Transform instance; // 0x20
        public UnityEngine.Transform[] handCount; // 0x28
        public Valve.VR.InteractionSystem.Hand[] leftHand; // 0x30
        public UnityEngine.Collider rightHand; // 0x38
        public UnityEngine.GameObject scale; // 0x40
        public UnityEngine.GameObject hmdTransform; // 0x48
        public UnityEngine.Transform eyeHeight; // 0x50
        public Valve.VR.SteamVR_Action_Boolean feetPositionGuess; // 0x58
        public bool bodyDirectionGuess; // 0x60
        public Valve.VR.InteractionSystem.Player _instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAC8CE5020
        public void get_handCount(){} // RVA: 0x7FFAC8CE51B0
        public void GetHand(){} // RVA: 0x7FFAC8CE52F0
        public void get_leftHand(){} // RVA: 0x7FFAC8CE5440
        public void get_rightHand(){} // RVA: 0x7FFAC8CE55B0
        public void get_scale(){} // RVA: 0x7FFAC8CE5720
        public void get_hmdTransform(){} // RVA: 0x7FFAC8CE57E0
        public void get_eyeHeight(){} // RVA: 0x7FFAC8CE5920
        public void get_feetPositionGuess(){} // RVA: 0x7FFAC8CE5BD0
        public void get_bodyDirectionGuess(){} // RVA: 0x7FFAC8CE5F30
        public void Awake(){} // RVA: 0x7FFAC8CE6170
        public void Start(){} // RVA: 0x7FFAC8CE6410
        public void Update(){} // RVA: 0x7FFAC8CE64B0
        public void OnDrawGizmos(){} // RVA: 0x7FFAC8CE6680
        public void Draw2DDebug(){} // RVA: 0x7FFAC8CE7240
        public void ActivateRig(){} // RVA: 0x7FFAC8CE7480
        public void PlayerShotSelf(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC8CE79D0
    }

    public class RenderModel : MonoBehaviour
    {
        public UnityEngine.GameObject GetSkeletonRangeOfMotion; // 0x20
        public UnityEngine.GameObject handInstance; // 0x28
        public UnityEngine.Renderer[] handRenderers; // 0x30
        public bool displayHandByDefault; // 0x38
        public Valve.VR.SteamVR_Behaviour_Skeleton handSkeleton; // 0x40
        public UnityEngine.Animator handAnimator; // 0x48
        public string animatorParameterStateName; // 0x50
        public int handAnimatorStateId; // 0x58
        public UnityEngine.GameObject controllerPrefab; // 0x60
        public UnityEngine.GameObject controllerInstance; // 0x68
        public UnityEngine.Renderer[] controllerRenderers; // 0x70
        public Valve.VR.SteamVR_RenderModel controllerRenderModel; // 0x78
        public bool displayControllerByDefault; // 0x80
        public UnityEngine.Material delayedSetMaterial; // 0x88
        public System.Action onControllerLoaded; // 0x90
        public Action renderModelLoadedAction; // 0x98
        public 0x6B209C88 inputSource; // 0xA0

        // ── Methods ──
        public void add_onControllerLoaded(){} // RVA: 0x7FFAC8CE8910
        public void remove_onControllerLoaded(){} // RVA: 0x7FFAC8CE8A00
        public void Awake(){} // RVA: 0x7FFAC8CE8AF0
        public void InitializeHand(){} // RVA: 0x7FFAC8CE8BF0
        public void InitializeController(){} // RVA: 0x7FFAC8CE95E0
        public void DestroyHand(){} // RVA: 0x7FFAC8CE9BE0
        public void OnSkeletonActiveChange(){} // RVA: 0x7FFAC8CE9F70
        public void OnEnable(){} // RVA: 0x7FFAC8CE9F90
        public void OnDisable(){} // RVA: 0x7FFAC8CE9FC0
        public void OnDestroy(){} // RVA: 0x7FFAC2FD5BC0
        public void GetSkeleton(){} // RVA: 0x7FFAC2F9E740
        public void SetInputSource(){} // RVA: 0x7FFAC8CE9FF0
        public void OnHandInitialized(){} // RVA: 0x7FFAC8CEA0E0
        public void MatchHandToTransform(){} // RVA: 0x7FFAC8CEA120
        public void SetHandPosition(){} // RVA: 0x7FFAC8CEA4E0
        public void SetHandRotation(){} // RVA: 0x7FFAC8CEA670
        public void GetHandPosition(){} // RVA: 0x7FFAC8CEA7F0
        public void GetHandRotation(){} // RVA: 0x7FFAC8CEA9E0
        public void OnRenderModelLoaded(){} // RVA: 0x7FFAC8CEABB0
        public void SetVisibility(){} // RVA: 0x7FFAC8CEAE50
        public void Show(){} // RVA: 0x7FFAC8CEAED0
        public void Hide(){} // RVA: 0x7FFAC8CEAF20
        public void SetMaterial(){} // RVA: 0x7FFAC8CEAF50
        public void SetControllerMaterial(){} // RVA: 0x7FFAC8CEB020
        public void SetHandMaterial(){} // RVA: 0x7FFAC8CEB160
        public void SetControllerVisibility(){} // RVA: 0x7FFAC8CEB220
        public void SetHandVisibility(){} // RVA: 0x7FFAC8CEB2F0
        public void IsHandVisibile(){} // RVA: 0x7FFAC8CEB3C0
        public void IsControllerVisibile(){} // RVA: 0x7FFAC8CEB490
        public void GetBone(){} // RVA: 0x7FFAC8CEB560
        public void GetBonePosition(){} // RVA: 0x7FFAC8CEB670
        public void GetControllerPosition(){} // RVA: 0x7FFAC8CEB7D0
        public void GetBoneRotation(){} // RVA: 0x7FFAC8CEBA50
        public void SetSkeletonRangeOfMotion(){} // RVA: 0x7FFAC8CEBCA0
        public void get_GetSkeletonRangeOfMotion(){} // RVA: 0x7FFAC8CEBEF0
        public void SetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFAC8CEBFE0
        public void ResetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFAC8CEC140
        public void SetAnimationState(){} // RVA: 0x7FFAC8CEC240
        public void StopAnimation(){} // RVA: 0x7FFAC8CEC370
        public void CheckAnimatorInit(){} // RVA: 0x7FFAC8CEC490
        public void .ctor(){} // RVA: 0x7FFAC8CEC880
    }

    public class SeeThru : MonoBehaviour
    {
        public UnityEngine.Material seeThruMaterial; // 0x20
        public UnityEngine.GameObject seeThru; // 0x28
        public Valve.VR.InteractionSystem.Interactable interactable; // 0x30
        public UnityEngine.Renderer sourceRenderer; // 0x38
        public UnityEngine.Renderer destRenderer; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CEC950
        public void OnEnable(){} // RVA: 0x7FFAC8CEDB50
        public void OnDisable(){} // RVA: 0x7FFAC8CEDDE0
        public void AttachedToHand(){} // RVA: 0x7FFAC8CEE070
        public void DetachedFromHand(){} // RVA: 0x7FFAC36F93F0
        public void Update(){} // RVA: 0x7FFAC8CEE0D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SleepOnAwake : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CEE540
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SnapTurn : MonoBehaviour
    {
        public float snapAngle; // 0x20
        public bool showTurnAnimation; // 0x24
        public UnityEngine.AudioSource snapTurnSource; // 0x28
        public UnityEngine.AudioClip rotateSound; // 0x30
        public UnityEngine.GameObject rotateRightFX; // 0x38
        public UnityEngine.GameObject rotateLeftFX; // 0x40
        public Valve.VR.SteamVR_Action_Boolean snapLeftAction; // 0x48
        public Valve.VR.SteamVR_Action_Boolean snapRightAction; // 0x50
        public bool fadeScreen; // 0x58
        public float fadeTime; // 0x5C
        public UnityEngine.Color screenFadeColor; // 0x60
        public float distanceFromFace; // 0x70
        public UnityEngine.Vector3 additionalOffset; // 0x74
        public float teleportLastActiveTime;
        public bool canRotate; // 0x80
        public float canTurnEverySeconds; // 0x84
        public UnityEngine.Coroutine rotateCoroutine; // 0x88

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D0A450
        public void AllOff(){} // RVA: 0x7FFAC8D0A460
        public void Update(){} // RVA: 0x7FFAC8D0A660
        public void RotatePlayer(){} // RVA: 0x7FFAC8D0AE00
        public void DoRotatePlayer(){} // RVA: 0x7FFAC8D0AF50
        public void ShowRotateFX(){} // RVA: 0x7FFAC8D0B010
        public void UpdateOrientation(){} // RVA: 0x7FFAC8D0B180
        public void .ctor(){} // RVA: 0x7FFAC8D0B8F0
    }

    public class SoundBowClick : MonoBehaviour
    {
        public UnityEngine.AudioClip bowClick; // 0x20
        public UnityEngine.AnimationCurve pitchTensionCurve; // 0x28
        public float minPitch; // 0x30
        public float maxPitch; // 0x34
        public UnityEngine.AudioSource thisAudioSource; // 0x38

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8D0A2C0
        public void PlayBowTensionClicks(){} // RVA: 0x7FFAC8D0A350
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SoundDeparent : MonoBehaviour
    {
        public bool destroyAfterPlayOnce; // 0x20
        public UnityEngine.AudioSource thisAudioSource; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CEE670
        public void Start(){} // RVA: 0x7FFAC8CEE700
        public void .ctor(){} // RVA: 0x7FFAC2F7B060
    }

    public class SoundPlayOneshot : MonoBehaviour
    {
        public UnityEngine.AudioClip[] waveFiles; // 0x20
        public UnityEngine.AudioSource thisAudioSource; // 0x28
        public float volMin; // 0x30
        public float volMax; // 0x34
        public float pitchMin; // 0x38
        public float pitchMax; // 0x3C
        public bool playOnAwake; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CEE910
        public void Play(){} // RVA: 0x7FFAC8CEE9B0
        public void Pause(){} // RVA: 0x7FFAC8CEEBB0
        public void UnPause(){} // RVA: 0x7FFAC8CEECD0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SpawnAndAttachAfterControllerIsTracking : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.Hand hand; // 0x20
        public UnityEngine.GameObject itemPrefab; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8CEEDF0
        public void Update(){} // RVA: 0x7FFAC8CEEE80
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SpawnAndAttachToHand : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.Hand hand; // 0x20
        public UnityEngine.GameObject prefab; // 0x28

        // ── Methods ──
        public void SpawnAndAttach(){} // RVA: 0x7FFAC8CEF160
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Teleport : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Boolean instance; // 0x20
        public UnityEngine.LayerMask traceLayerMask; // 0x28
        public UnityEngine.LayerMask floorFixupTraceLayerMask; // 0x2C
        public float floorFixupMaximumTraceDistance; // 0x30
        public UnityEngine.Material areaVisibleMaterial; // 0x38
        public UnityEngine.Material areaLockedMaterial; // 0x40
        public UnityEngine.Material areaHighlightedMaterial; // 0x48
        public UnityEngine.Material pointVisibleMaterial; // 0x50
        public UnityEngine.Material pointLockedMaterial; // 0x58
        public UnityEngine.Material pointHighlightedMaterial; // 0x60
        public UnityEngine.Transform destinationReticleTransform; // 0x68
        public UnityEngine.Transform invalidReticleTransform; // 0x70
        public UnityEngine.GameObject playAreaPreviewCorner; // 0x78
        public UnityEngine.GameObject playAreaPreviewSide; // 0x80
        public UnityEngine.Color pointerValidColor; // 0x88
        public UnityEngine.Color pointerInvalidColor; // 0x98
        public UnityEngine.Color pointerLockedColor; // 0xA8
        public bool showPlayAreaMarker; // 0xB8
        public float teleportFadeTime; // 0xBC
        public float meshFadeTime; // 0xC0
        public float arcDistance; // 0xC4
        public UnityEngine.Transform onActivateObjectTransform; // 0xC8
        public UnityEngine.Transform onDeactivateObjectTransform; // 0xD0
        public float activateObjectTime; // 0xD8
        public float deactivateObjectTime; // 0xDC
        public UnityEngine.AudioSource pointerAudioSource; // 0xE0
        public UnityEngine.AudioSource loopingAudioSource; // 0xE8
        public UnityEngine.AudioSource headAudioSource; // 0xF0
        public UnityEngine.AudioSource reticleAudioSource; // 0xF8
        public UnityEngine.AudioClip teleportSound; // 0x100
        public UnityEngine.AudioClip pointerStartSound; // 0x108
        public UnityEngine.AudioClip pointerLoopSound; // 0x110
        public UnityEngine.AudioClip pointerStopSound; // 0x118
        public UnityEngine.AudioClip goodHighlightSound; // 0x120
        public UnityEngine.AudioClip badHighlightSound; // 0x128
        public bool debugFloor; // 0x130
        public bool showOffsetReticle; // 0x131
        public UnityEngine.Transform offsetReticleTransform; // 0x138
        public UnityEngine.MeshRenderer floorDebugSphere; // 0x140
        public UnityEngine.LineRenderer floorDebugLine; // 0x148
        public UnityEngine.LineRenderer pointerLineRenderer; // 0x150
        public UnityEngine.GameObject teleportPointerObject; // 0x158
        public UnityEngine.Transform pointerStartTransform; // 0x160
        public Valve.VR.InteractionSystem.Hand pointerHand; // 0x168
        public Valve.VR.InteractionSystem.Player player; // 0x170
        public Valve.VR.InteractionSystem.TeleportArc teleportArc; // 0x178
        public bool visible; // 0x180
        public Valve.VR.InteractionSystem.TeleportMarkerBase[] teleportMarkers; // 0x188
        public Valve.VR.InteractionSystem.TeleportMarkerBase pointedAtTeleportMarker; // 0x190
        public Valve.VR.InteractionSystem.TeleportMarkerBase teleportingToMarker; // 0x198
        public UnityEngine.Vector3 pointedAtPosition; // 0x1A0
        public UnityEngine.Vector3 prevPointedAtPosition; // 0x1AC
        public bool teleporting; // 0x1B8
        public float currentFadeTime; // 0x1BC
        public float meshAlphaPercent; // 0x1C0
        public float pointerShowStartTime; // 0x1C4
        public float pointerHideStartTime; // 0x1C8
        public bool meshFading; // 0x1CC
        public float fullTintAlpha; // 0x1D0
        public float invalidReticleMinScale; // 0x1D4
        public float invalidReticleMaxScale; // 0x1D8
        public float invalidReticleMinScaleDistance; // 0x1DC
        public float invalidReticleMaxScaleDistance; // 0x1E0
        public UnityEngine.Vector3 invalidReticleScale; // 0x1E4
        public UnityEngine.Quaternion invalidReticleTargetRotation; // 0x1F0
        public UnityEngine.Transform playAreaPreviewTransform; // 0x200
        public UnityEngine.Transform[] playAreaPreviewCorners; // 0x208
        public UnityEngine.Transform[] playAreaPreviewSides; // 0x210
        public float loopingAudioMaxVolume; // 0x218
        public UnityEngine.Coroutine hintCoroutine; // 0x220
        public bool originalHoverLockState; // 0x228
        public Valve.VR.InteractionSystem.Interactable originalHoveringInteractable; // 0x230
        public Valve.VR.InteractionSystem.AllowTeleportWhileAttachedToHand allowTeleportWhileAttached; // 0x238
        public UnityEngine.Vector3 startingFeetOffset; // 0x240
        public bool movedFeetFarEnough; // 0x24C
        public Action chaperoneInfoInitializedAction; // 0x250
        public Event`1<float> ChangeScene;
        public Event`1<Valve.VR.InteractionSystem.TeleportMarkerBase> Player; // 0x8
        public Event`1<Valve.VR.InteractionSystem.TeleportMarkerBase> PlayerPre; // 0x10
        public Valve.VR.InteractionSystem.Teleport _instance; // 0x18

        // ── Methods ──
        public void ChangeSceneAction(){} // RVA: 0x7FFAC8D0CEF0
        public void PlayerAction(){} // RVA: 0x7FFAC8D0CFA0
        public void PlayerPreAction(){} // RVA: 0x7FFAC8D0D060
        public void get_instance(){} // RVA: 0x7FFAC8D0D120
        public void Awake(){} // RVA: 0x7FFAC8D0D2F0
        public void Start(){} // RVA: 0x7FFAC8D0D910
        public void OnEnable(){} // RVA: 0x7FFAC8D0DD30
        public void OnDisable(){} // RVA: 0x7FFAC8D0DD70
        public void CheckForSpawnPoint(){} // RVA: 0x7FFAC8D0DDB0
        public void HideTeleportPointer(){} // RVA: 0x7FFAC8D0DF50
        public void Update(){} // RVA: 0x7FFAC8D0E030
        public void UpdatePointer(){} // RVA: 0x7FFAC8D0EA40
        public void FixedUpdate(){} // RVA: 0x7FFAC8D106A0
        public void OnChaperoneInfoInitialized(){} // RVA: 0x7FFAC8D10FB0
        public void HidePointer(){} // RVA: 0x7FFAC8D12770
        public void ShowPointer(){} // RVA: 0x7FFAC8D13110
        public void UpdateTeleportColors(){} // RVA: 0x7FFAC8D142C0
        public void PlayAudioClip(){} // RVA: 0x7FFAC8D143E0
        public void PlayPointerHaptic(){} // RVA: 0x7FFAC8D14490
        public void TryTeleportPlayer(){} // RVA: 0x7FFAC8D14650
        public void InitiateTeleportFade(){} // RVA: 0x7FFAC8D14780
        public void TeleportPlayer(){} // RVA: 0x7FFAC8D14BD0
        public void HighlightSelected(){} // RVA: 0x7FFAC8D15970
        public void ShowTeleportHint(){} // RVA: 0x7FFAC8D15F20
        public void CancelTeleportHint(){} // RVA: 0x7FFAC8D16040
        public void TeleportHintCoroutine(){} // RVA: 0x7FFAC8D161A0
        public void IsEligibleForTeleport(){} // RVA: 0x7FFAC8D16240
        public void ShouldOverrideHoverLock(){} // RVA: 0x7FFAC8D16670
        public void WasTeleportButtonReleased(){} // RVA: 0x7FFAC8D16770
        public void IsTeleportButtonDown(){} // RVA: 0x7FFAC8D168E0
        public void WasTeleportButtonPressed(){} // RVA: 0x7FFAC8D16A50
        public void GetPointerStartTransform(){} // RVA: 0x7FFAC8D16BC0
        public void .ctor(){} // RVA: 0x7FFAC8D16D20
        public void .cctor(){} // RVA: 0x7FFAC8D16F60
    }

    public class TeleportArc : MonoBehaviour
    {
        public int segmentCount; // 0x20
        public float thickness; // 0x24
        public float arcDuration; // 0x28
        public float segmentBreak; // 0x2C
        public float arcSpeed; // 0x30
        public UnityEngine.Material material; // 0x38
        public int traceLayerMask; // 0x40
        public UnityEngine.LineRenderer[] lineRenderers; // 0x48
        public float arcTimeOffset; // 0x50
        public float prevThickness; // 0x54
        public int prevSegmentCount; // 0x58
        public bool showArc; // 0x5C
        public UnityEngine.Vector3 startPos; // 0x60
        public UnityEngine.Vector3 projectileVelocity; // 0x6C
        public bool useGravity; // 0x78
        public UnityEngine.Transform arcObjectsTransfrom; // 0x80
        public bool arcInvalid; // 0x88
        public float scale; // 0x8C

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D17510
        public void Update(){} // RVA: 0x7FFAC8D17570
        public void CreateLineRendererObjects(){} // RVA: 0x7FFAC8D17680
        public void SetArcData(){} // RVA: 0x7FFAC8D17F80
        public void Show(){} // RVA: 0x7FFAC8D18020
        public void Hide(){} // RVA: 0x7FFAC8D18040
        public void DrawArc(){} // RVA: 0x7FFAC8D18080
        public void DrawArcSegment(){} // RVA: 0x7FFAC8D18460
        public void SetColor(){} // RVA: 0x7FFAC8D18650
        public void FindProjectileCollision(){} // RVA: 0x7FFAC8D187A0
        public void GetArcPositionAtTime(){} // RVA: 0x7FFAC8D18AF0
        public void HideLineSegments(){} // RVA: 0x7FFAC8D18CC0
        public void .ctor(){} // RVA: 0x7FFAC8D18D80
    }

    public class TeleportArea : TeleportMarkerBase
    {
        public UnityEngine.Bounds meshBounds; // 0x28
        public UnityEngine.MeshRenderer areaMesh; // 0x40
        public int tintColorId; // 0x48
        public UnityEngine.Color visibleTintColor; // 0x4C
        public UnityEngine.Color highlightedTintColor; // 0x5C
        public UnityEngine.Color lockedTintColor; // 0x6C
        public bool highlighted; // 0x7C

        // ── Methods ──
        public void get_meshBounds(){} // RVA: 0x7FFAC4B71360
        public void set_meshBounds(){} // RVA: 0x7FFAC4B71340
        public void Awake(){} // RVA: 0x7FFAC8D18E00
        public void Start(){} // RVA: 0x7FFAC8D18F00
        public void ShouldActivate(){} // RVA: 0x7FFAC3006850
        public void ShouldMovePlayer(){} // RVA: 0x7FFAC3006850
        public void Highlight(){} // RVA: 0x7FFAC8D190D0
        public void SetAlpha(){} // RVA: 0x7FFAC8D191A0
        public void UpdateVisuals(){} // RVA: 0x7FFAC8D192D0
        public void UpdateVisualsInEditor(){} // RVA: 0x7FFAC8D193F0
        public void CalculateBounds(){} // RVA: 0x7FFAC8D195E0
        public void GetTintColor(){} // RVA: 0x7FFAC8D19820
        public void .ctor(){} // RVA: 0x7FFAC8D19850
    }

    public class TeleportMarkerBase : MonoBehaviour
    {
        public bool showReticle; // 0x20
        public bool markerActive; // 0x21

        // ── Methods ──
        public void get_showReticle(){} // RVA: 0x7FFAC3006850
        public void SetLocked(){} // RVA: 0x7FFAC8D198B0
        public void TeleportPlayer(){} // RVA: 0x7FFAC2F21310
        public void UpdateVisuals(){} // RVA: 0x7FFAC2C70980
        public void Highlight(){} // RVA: 0x7FFAC2C71060
        public void SetAlpha(){}
        public void ShouldActivate(){} // RVA: 0x7FFAC2C59F60
        public void ShouldMovePlayer(){} // RVA: 0x7FFAC2C59D00
        public void .ctor(){} // RVA: 0x7FFAC8D198D0
    }

    public class TeleportPoint : TeleportMarkerBase
    {
        public 0x6B20DA68 showReticle; // 0x28
        public string title; // 0x30
        public string switchToScene; // 0x38
        public UnityEngine.Color titleVisibleColor; // 0x40
        public UnityEngine.Color titleHighlightedColor; // 0x50
        public UnityEngine.Color titleLockedColor; // 0x60
        public bool playerSpawnPoint; // 0x70
        public bool gotReleventComponents; // 0x71
        public UnityEngine.MeshRenderer markerMesh; // 0x78
        public UnityEngine.MeshRenderer switchSceneIcon; // 0x80
        public UnityEngine.MeshRenderer moveLocationIcon; // 0x88
        public UnityEngine.MeshRenderer lockedIcon; // 0x90
        public UnityEngine.MeshRenderer pointIcon; // 0x98
        public UnityEngine.Transform lookAtJointTransform; // 0xA0
        public UnityEngine.Animation animation; // 0xA8
        public UnityEngine.UI.Text titleText; // 0xB0
        public Valve.VR.InteractionSystem.Player player; // 0xB8
        public UnityEngine.Vector3 lookAtPosition; // 0xC0
        public int tintColorID; // 0xCC
        public UnityEngine.Color tintColor; // 0xD0
        public UnityEngine.Color titleColor; // 0xE0
        public float fullTitleAlpha; // 0xF0
        public string switchSceneAnimation;
        public string moveLocationAnimation;
        public string lockedAnimation;

        // ── Methods ──
        public void get_showReticle(){} // RVA: 0x7FFAC2F21320
        public void Awake(){} // RVA: 0x7FFAC8D19920
        public void Start(){} // RVA: 0x7FFAC8D19C40
        public void Update(){} // RVA: 0x7FFAC8D19CB0
        public void ShouldActivate(){} // RVA: 0x7FFAC8D19F00
        public void ShouldMovePlayer(){} // RVA: 0x7FFAC3006850
        public void Highlight(){} // RVA: 0x7FFAC8D1A090
        public void UpdateVisuals(){} // RVA: 0x7FFAC8D1A370
        public void SetAlpha(){} // RVA: 0x7FFAC8D1A5B0
        public void SetMeshMaterials(){} // RVA: 0x7FFAC8D1A9F0
        public void TeleportToScene(){} // RVA: 0x7FFAC8D1ABC0
        public void GetRelevantComponents(){} // RVA: 0x7FFAC8D1ACB0
        public void ReleaseRelevantComponents(){} // RVA: 0x7FFAC8D1B5F0
        public void UpdateVisualsInEditor(){} // RVA: 0x7FFAC8D1B800
        public void .ctor(){} // RVA: 0x7FFAC8D1BCD0
    }

    public class TeleportURPHelper : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Throwable : MonoBehaviour
    {
        public 0x6B20BC28 attachmentFlags; // 0x20
        public UnityEngine.Transform attachmentOffset; // 0x28
        public float catchingSpeedThreshold; // 0x30
        public 0x6B20CB48 releaseVelocityStyle; // 0x34
        public float releaseVelocityTimeOffset; // 0x38
        public float scaleReleaseVelocity; // 0x3C
        public float scaleReleaseVelocityThreshold; // 0x40
        public UnityEngine.AnimationCurve scaleReleaseVelocityCurve; // 0x48
        public bool restoreOriginalParent; // 0x50
        public Valve.VR.InteractionSystem.VelocityEstimator velocityEstimator; // 0x58
        public bool attached; // 0x60
        public float attachTime; // 0x64
        public UnityEngine.Vector3 attachPosition; // 0x68
        public UnityEngine.Quaternion attachRotation; // 0x74
        public UnityEngine.Transform attachEaseInTransform; // 0x88
        public UnityEngine.Events.UnityEvent onPickUp; // 0x90
        public UnityEngine.Events.UnityEvent onDetachFromHand; // 0x98
        public Valve.VR.InteractionSystem.HandEvent onHeldUpdate; // 0xA0
        public 0x6B29FF58 hadInterpolation; // 0xA8
        public UnityEngine.Rigidbody rigidbody; // 0xB0
        public Valve.VR.InteractionSystem.Interactable interactable; // 0xB8

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CEF320
        public void OnHandHoverBegin(){} // RVA: 0x7FFAC8CEF5B0
        public void OnHandHoverEnd(){} // RVA: 0x7FFAC8CEF780
        public void HandHoverUpdate(){} // RVA: 0x7FFAC8CEF7B0
        public void OnAttachedToHand(){} // RVA: 0x7FFAC8CEF870
        public void OnDetachedFromHand(){} // RVA: 0x7FFAC8CEFC40
        public void GetReleaseVelocities(){} // RVA: 0x7FFAC8CEFE20
        public void HandAttachedUpdate(){} // RVA: 0x7FFAC8CF0630
        public void LateDetach(){} // RVA: 0x7FFAC8CF0740
        public void OnHandFocusAcquired(){} // RVA: 0x7FFAC8CF0840
        public void OnHandFocusLost(){} // RVA: 0x7FFAC8CF09C0
        public void .ctor(){} // RVA: 0x7FFAC8CE4F30
    }

    public class UIElement : MonoBehaviour
    {
        public UnityEventHand onHandClick; // 0x20
        public Valve.VR.InteractionSystem.Hand currentHand; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8CF0CB0
        public void OnHandHoverBegin(){} // RVA: 0x7FFAC8CF0E00
        public void OnHandHoverEnd(){} // RVA: 0x7FFAC8CF10A0
        public void HandHoverUpdate(){} // RVA: 0x7FFAC8CF1360
        public void OnButtonClick(){} // RVA: 0x7FFAC8CF1580
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Unparent : MonoBehaviour
    {
        public UnityEngine.Transform oldParent; // 0x20

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8CF15D0
        public void Update(){} // RVA: 0x7FFAC8CF1880
        public void GetOldParent(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Util : Object
    {
        public float FeetToMeters;
        public float FeetToCentimeters;
        public float InchesToMeters;
        public float InchesToCentimeters;
        public float MetersToFeet;
        public float MetersToInches;
        public float CentimetersToFeet;
        public float CentimetersToInches;
        public float KilometersToMiles;
        public float MilesToKilometers;

        // ── Methods ──
        public void RemapNumber(){} // RVA: 0x7FFAC8CF19B0
        public void RemapNumberClamped(){} // RVA: 0x7FFAC8CF19D0
        public void Approach(){} // RVA: 0x7FFAC8CF1A40
        public void BezierInterpolate3(){} // RVA: 0x7FFAC8CF1A70
        public void BezierInterpolate4(){} // RVA: 0x7FFAC8CF1C00
        public void Vector3FromString(){} // RVA: 0x7FFAC8CF1EB0
        public void Vector2FromString(){} // RVA: 0x7FFAC8CF1FD0
        public void Normalize(){} // RVA: 0x7FFAC8CF20C0
        public void Vector2AsVector3(){} // RVA: 0x7FFAC2F893F0
        public void Vector3AsVector2(){} // RVA: 0x7FFAC2F893D0
        public void AngleOf(){} // RVA: 0x7FFAC8CF20D0
        public void YawOf(){} // RVA: 0x7FFAC8CF2130
        public void Swap(){} // RVA: 0x7FFAC2C70C80
        public void Shuffle(){} // RVA: 0x7FFAC2C70A10 | overloaded x2
        public void RandomWithLookback(){} // RVA: 0x7FFAC8CF2180
        public void FindChild(){} // RVA: 0x7FFAC8CF2360
        public void IsNullOrEmpty(){} // RVA: 0x7FFAC2C59DE0
        public void IsValidIndex(){} // RVA: 0x7FFAC2C5BDB0 | overloaded x2
        public void FindOrAdd(){} // RVA: 0x7FFAC2E8DC40
        public void FindAndRemove(){} // RVA: 0x7FFAC2C58FF0
        public void FindOrAddComponent(){} // RVA: 0x7FFAC2E8DC40
        public void FastRemove(){} // RVA: 0x7FFAC2C76370
        public void ReplaceGameObject(){} // RVA: 0x7FFAC2E8DC40
        public void SwitchLayerRecursively(){} // RVA: 0x7FFAC8CF2610
        public void DrawCross(){} // RVA: 0x7FFAC8CF2840
        public void ResetTransform(){} // RVA: 0x7FFAC8CF2E90
        public void ClosestPointOnLine(){} // RVA: 0x7FFAC8CF3030
        public void AfterTimer(){} // RVA: 0x7FFAC8CF32F0
        public void SendPhysicsMessage(){} // RVA: 0x7FFAC8CF36C0 | overloaded x2
        public void IgnoreCollisions(){} // RVA: 0x7FFAC8CF39B0
        public void WrapCoroutine(){} // RVA: 0x7FFAC8CF3B50
        public void ColorWithAlpha(){} // RVA: 0x7FFAC36788D0
        public void Quit(){} // RVA: 0x7FFAC8CF3C50
        public void FloatToDecimal(){} // RVA: 0x7FFAC8CF3C80
        public void Median(){} // RVA: 0x7FFAC2E8DC40
        public void ForEach(){} // RVA: 0x7FFAC2C70C80
        public void FixupNewlines(){} // RVA: 0x7FFAC8CF3DA0
        public void PathLength(){} // RVA: 0x7FFAC8CF3E60
        public void HasCommandLineArgument(){} // RVA: 0x7FFAC8CF4040
        public void GetCommandLineArgValue(){} // RVA: 0x7FFAC8CF41C0 | overloaded x2
        public void SetActive(){} // RVA: 0x7FFAC8CF42A0
        public void CombinePaths(){} // RVA: 0x7FFAC8CF43B0
    }

    public class VelocityEstimator : MonoBehaviour
    {
        public int velocityAverageFrames; // 0x20
        public int angularVelocityAverageFrames; // 0x24
        public bool estimateOnAwake; // 0x28
        public UnityEngine.Coroutine routine; // 0x30
        public int sampleCount; // 0x38
        public UnityEngine.Vector3[] velocitySamples; // 0x40
        public UnityEngine.Vector3[] angularVelocitySamples; // 0x48

        // ── Methods ──
        public void BeginEstimatingVelocity(){} // RVA: 0x7FFAC8CF48D0
        public void FinishEstimatingVelocity(){} // RVA: 0x7FFAC8CF49F0
        public void GetVelocityEstimate(){} // RVA: 0x7FFAC8CF4A70
        public void GetAngularVelocityEstimate(){} // RVA: 0x7FFAC8CF4BA0
        public void GetAccelerationEstimate(){} // RVA: 0x7FFAC8CF4CD0
        public void Awake(){} // RVA: 0x7FFAC8CF4EB0
        public void EstimateVelocityCoroutine(){} // RVA: 0x7FFAC8CF4FD0
        public void .ctor(){} // RVA: 0x7FFAC8CF5070
    }

}