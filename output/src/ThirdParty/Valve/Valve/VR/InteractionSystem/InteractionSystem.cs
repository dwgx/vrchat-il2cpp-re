// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.InteractionSystem
// Classes: 73
// Methods: 662

namespace ThirdParty.Valve.Valve.VR.InteractionSystem
{
    public class AllowTeleportWhileAttachedToHand : MonoBehaviour
    {
        public bool teleportAllowed; // 0x20
        public bool overrideHoverLock; // 0x21

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD540B6450
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
        public void ApplyDamage(){} // RVA: 0x7FFD5411DD20
        public void FireExposure(){} // RVA: 0x7FFD5411DD20
        public void OnDamageTaken(){} // RVA: 0x7FFD5411DD30
        public void FallDown(){} // RVA: 0x7FFD5411DE10
        public void .ctor(){} // RVA: 0x7FFD5411DEB0
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
        public ÎÏÎÍÍÌÎÌÍÌÍÌÏÌÍ initialInterpolation; // 0xB4
        public ÎÍÏÎÌÏÍÎÏÎÎÎÏÏÌÌ initialCollisionDetection; // 0xB8
        public bool initialUseGravity; // 0xBC

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5411E2E0
        public void Start(){} // RVA: 0x7FFD5411E570
        public void FixedUpdate(){} // RVA: 0x7FFD5411E610
        public void StartRelease(){} // RVA: 0x7FFD5411E8F0
        public void ArrowReleased(){} // RVA: 0x7FFD5411ED80
        public void SetCollisionMode(){} // RVA: 0x7FFD5411F8D0
        public void OnCollisionEnter(){} // RVA: 0x7FFD5411FA10
        public void StickInTarget(){} // RVA: 0x7FFD54120970
        public void OnDestroy(){} // RVA: 0x7FFD54121BA0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
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
        public 0x6656BBD0 nockedWithType; // 0x5C
        public bool inNockRange; // 0x60
        public bool arrowLerpComplete; // 0x61
        public Valve.VR.InteractionSystem.SoundPlayOneshot arrowSpawnSound; // 0x68
        public Valve.VR.InteractionSystem.AllowTeleportWhileAttachedToHand allowTeleport; // 0x70
        public int maxArrowCount; // 0x78
        public System.Collections.Generic.List`1<UnityEngine.GameObject> arrowList; // 0x80

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD54121E50
        public void OnAttachedToHand(){} // RVA: 0x7FFD54121FB0
        public void InstantiateArrow(){} // RVA: 0x7FFD54122010
        public void HandAttachedUpdate(){} // RVA: 0x7FFD541223F0
        public void OnDetachedFromHand(){} // RVA: 0x7FFD541234A0
        public void FireArrow(){} // RVA: 0x7FFD54123540
        public void EnableArrowSpawn(){} // RVA: 0x7FFD4E4F2F70
        public void ArrowReleaseHaptics(){} // RVA: 0x7FFD54123FA0
        public void OnHandFocusLost(){} // RVA: 0x7FFD4EAB7F10
        public void OnHandFocusAcquired(){} // RVA: 0x7FFD4EF62350
        public void FindBow(){} // RVA: 0x7FFD54124040
        public void .ctor(){} // RVA: 0x7FFD541240E0
    }

    public class ArrowheadRotation : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD54124390
        public void .ctor(){} // RVA: 0x7FFD4E341D50
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
        public void Start(){} // RVA: 0x7FFD54124480
        public void Update(){} // RVA: 0x7FFD54124640
        public void SpawnParticles(){} // RVA: 0x7FFD54124750
        public void FixedUpdate(){} // RVA: 0x7FFD54124C00
        public void ApplyDamage(){} // RVA: 0x7FFD54124D90
        public void OnCollisionEnter(){} // RVA: 0x7FFD54124E40
        public void SetColor(){} // RVA: 0x7FFD54125490
        public void BalloonColorToRGB(){} // RVA: 0x7FFD54125570
        public void .ctor(){} // RVA: 0x7FFD54125780
    }

    public class BalloonColliders : MonoBehaviour
    {
        public UnityEngine.GameObject[] colliders; // 0x20
        public UnityEngine.Vector3[] colliderLocalPositions; // 0x28
        public UnityEngine.Quaternion[] colliderLocalRotations; // 0x30
        public UnityEngine.Rigidbody rb; // 0x38

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD541257E0
        public void OnEnable(){} // RVA: 0x7FFD54125D90
        public void OnDisable(){} // RVA: 0x7FFD541263E0
        public void OnDestroy(){} // RVA: 0x7FFD541265A0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class BalloonHapticBump : MonoBehaviour
    {
        public UnityEngine.GameObject physParent; // 0x20

        // ── Methods ──
        public void OnCollisionEnter(){} // RVA: 0x7FFD541266D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
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
        public 0x6656D2D8 color; // 0x68

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD54126910
        public void Update(){} // RVA: 0x7FFD54126A30
        public void SpawnBalloon(){} // RVA: 0x7FFD54126B90
        public void SpawnBalloonFromEvent(){} // RVA: 0x7FFD541274F0
        public void .ctor(){} // RVA: 0x7FFD54127500
    }

    public class BodyCollider : MonoBehaviour
    {
        public UnityEngine.Transform head; // 0x20
        public UnityEngine.CapsuleCollider capsuleCollider; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD540DB090
        public void FixedUpdate(){} // RVA: 0x7FFD540DB120
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class ChaperoneInfo : MonoBehaviour
    {
        public bool initialized; // 0x20
        public float playAreaSizeX; // 0x24
        public float playAreaSizeZ; // 0x28
        public bool roomscale; // 0x2C
        public 0x6656A6D8 instance;
        public Valve.VR.InteractionSystem.ChaperoneInfo _instance; // 0x8

        // ── Methods ──
        public void get_initialized(){} // RVA: 0x7FFD4E42F9D0
        public void set_initialized(){} // RVA: 0x7FFD4E42F9E0
        public void get_playAreaSizeX(){} // RVA: 0x7FFD4E4AEF50
        public void set_playAreaSizeX(){} // RVA: 0x7FFD4E4AEF60
        public void get_playAreaSizeZ(){} // RVA: 0x7FFD4E420210
        public void set_playAreaSizeZ(){} // RVA: 0x7FFD4E420220
        public void get_roomscale(){} // RVA: 0x7FFD4E420230
        public void set_roomscale(){} // RVA: 0x7FFD4E420240
        public void InitializedAction(){} // RVA: 0x7FFD5412C4F0
        public void get_instance(){} // RVA: 0x7FFD5412C590
        public void Start(){} // RVA: 0x7FFD5412C8E0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void .cctor(){} // RVA: 0x7FFD5412C980
    }

    public class CircularDrive : MonoBehaviour
    {
        public 0x6656B4F0 axisOfRotation; // 0x20
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
        public 0x6656BBD0 grabbedWithType; // 0x138

        // ── Methods ──
        public void Freeze(){} // RVA: 0x7FFD540DB450
        public void UnFreeze(){} // RVA: 0x7FFD540DB520
        public void Awake(){} // RVA: 0x7FFD540DB540
        public void Start(){} // RVA: 0x7FFD540DB5E0
        public void OnDisable(){} // RVA: 0x7FFD540DC200
        public void HapticPulses(){} // RVA: 0x7FFD540DC370
        public void OnHandHoverBegin(){} // RVA: 0x7FFD540DC430
        public void OnHandHoverEnd(){} // RVA: 0x7FFD540DC450
        public void HandHoverUpdate(){} // RVA: 0x7FFD540DC5D0
        public void ComputeToTransformProjected(){} // RVA: 0x7FFD540DC8A0
        public void DrawDebugPath(){} // RVA: 0x7FFD540DCD10
        public void UpdateLinearMapping(){} // RVA: 0x7FFD540DDC50
        public void UpdateGameObject(){} // RVA: 0x7FFD540DDCE0
        public void UpdateDebugText(){} // RVA: 0x7FFD540DDFA0
        public void UpdateAll(){} // RVA: 0x7FFD540DE1A0
        public void ComputeAngle(){} // RVA: 0x7FFD540DE240
        public void .ctor(){} // RVA: 0x7FFD540DE730
    }

    public class ComplexThrowable : MonoBehaviour
    {
        public float attachForce; // 0x20
        public float attachForceDamper; // 0x24
        public 0x6656B5F8 attachMode; // 0x28
        public 0x6656BC28 attachmentFlags; // 0x2C
        public System.Collections.Generic.List`1<Valve.VR.InteractionSystem.Hand> holdingHands; // 0x30
        public System.Collections.Generic.List`1<UnityEngine.Rigidbody> holdingBodies; // 0x38
        public System.Collections.Generic.List`1<UnityEngine.Vector3> holdingPoints; // 0x40
        public System.Collections.Generic.List`1<UnityEngine.Rigidbody> rigidBodies; // 0x48

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD540DEAD0
        public void Update(){} // RVA: 0x7FFD540DEB50
        public void OnHandHoverBegin(){} // RVA: 0x7FFD540DEC90
        public void OnHandHoverEnd(){} // RVA: 0x7FFD540DED70
        public void HandHoverUpdate(){} // RVA: 0x7FFD540DEE50
        public void PhysicsAttach(){} // RVA: 0x7FFD540DEEA0
        public void PhysicsDetach(){} // RVA: 0x7FFD540DF980
        public void FixedUpdate(){} // RVA: 0x7FFD540DFC90
        public void .ctor(){} // RVA: 0x7FFD540E0210
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
        public System.Collections.Generic.Dictionary`2<Valve.VR.ISteamVR_Action_In_Source,0x6656CF10> actionHintInfos; // 0x80
        public UnityEngine.Transform textHintParent; // 0x88
        public int colorID; // 0x90
        public bool <initialized>k__BackingField; // 0x94
        public UnityEngine.Vector3 centerPosition; // 0x98
        public Action renderModelLoadedAction; // 0xA8
        public 0x66569C88 inputSource; // 0xB0
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.Transform> componentTransformMap; // 0xB8

        // ── Methods ──
        public void get_usingMaterial(){} // RVA: 0x7FFD4E36F0C0
        public void get_initialized(){} // RVA: 0x7FFD53EE3770
        public void set_initialized(){} // RVA: 0x7FFD53EE3780
        public void Awake(){} // RVA: 0x7FFD54115A00
        public void Start(){} // RVA: 0x7FFD54115B50
        public void HintDebugLog(){} // RVA: 0x7FFD54115BC0
        public void OnEnable(){} // RVA: 0x7FFD54115C50
        public void OnDisable(){} // RVA: 0x7FFD54115C80
        public void OnParentHandInputFocusLost(){} // RVA: 0x7FFD54115CC0
        public void SetInputSource(){} // RVA: 0x7FFD54115CE0
        public void OnHandInitialized(){} // RVA: 0x7FFD54115DD0
        public void OnRenderModelLoaded(){} // RVA: 0x7FFD54116310
        public void DoInitialize(){} // RVA: 0x7FFD54116630
        public void CreateAndAddButtonInfo(){} // RVA: 0x7FFD54116730
        public void ComputeTextEndTransforms(){} // RVA: 0x7FFD541188D0
        public void ShowButtonHint(){} // RVA: 0x7FFD5411BD10 | overloaded x2
        public void HideAllButtonHints(){} // RVA: 0x7FFD5411BEF0 | overloaded x2
        public void HideButtonHint(){} // RVA: 0x7FFD5411BE00 | overloaded x2
        public void IsButtonHintActive(){} // RVA: 0x7FFD5411BFD0 | overloaded x2
        public void TestButtonHints(){} // RVA: 0x7FFD5411A390
        public void TestTextHints(){} // RVA: 0x7FFD5411A430
        public void Update(){} // RVA: 0x7FFD5411A4D0
        public void UpdateTextHint(){} // RVA: 0x7FFD5411AB80
        public void Clear(){} // RVA: 0x7FFD5411B270
        public void ShowText(){} // RVA: 0x7FFD5411B300
        public void HideText(){} // RVA: 0x7FFD5411B6C0
        public void HideAllText(){} // RVA: 0x7FFD5411B850
        public void GetActiveHintText(){} // RVA: 0x7FFD5411C680 | overloaded x2
        public void GetControllerButtonHints(){} // RVA: 0x7FFD5411BB80
        public void ShowTextHint(){} // RVA: 0x7FFD5411C0C0
        public void HideTextHint(){} // RVA: 0x7FFD5411C290
        public void HideAllTextHints(){} // RVA: 0x7FFD5411C5A0
        public void .ctor(){} // RVA: 0x7FFD5411C870
    }

    public class ControllerHoverHighlight : MonoBehaviour
    {
        public UnityEngine.Material highLightMaterial; // 0x20
        public bool fireHapticsOnHightlight; // 0x28
        public Valve.VR.InteractionSystem.Hand hand; // 0x30
        public Valve.VR.InteractionSystem.RenderModel renderModel; // 0x38
        public Action renderModelLoadedAction; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD540E04C0
        public void OnHandInitialized(){} // RVA: 0x7FFD540E0550
        public void RenderModel_onControllerLoaded(){} // RVA: 0x7FFD540E0CC0
        public void OnParentHandHoverBegin(){} // RVA: 0x7FFD540E0D00
        public void OnParentHandHoverEnd(){} // RVA: 0x7FFD540E0FB0
        public void OnParentHandInputFocusAcquired(){} // RVA: 0x7FFD540E0FC0
        public void OnParentHandInputFocusLost(){} // RVA: 0x7FFD540E0FB0
        public void ShowHighlight(){} // RVA: 0x7FFD540E1330
        public void HideHighlight(){} // RVA: 0x7FFD540E14A0
        public void .ctor(){} // RVA: 0x7FFD4E378BB0
    }

    public class CustomEvents : Object
    {
    }

    public class DebugUI : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.Player instance; // 0x20
        public Valve.VR.InteractionSystem.DebugUI _instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFD540E16C0
        public void Start(){} // RVA: 0x7FFD540E1850
        public void OnGUI(){} // RVA: 0x7FFD540E18C0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class DestroyOnDetachedFromHand : MonoBehaviour
    {
        // ── Methods ──
        public void OnDetachedFromHand(){} // RVA: 0x7FFD540E1970
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class DestroyOnParticleSystemDeath : MonoBehaviour
    {
        public UnityEngine.ParticleSystem particles; // 0x20

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD540E1A10
        public void CheckParticleSystem(){} // RVA: 0x7FFD540E1AD0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class DestroyOnTriggerEnter : MonoBehaviour
    {
        public string tagFilter; // 0x20
        public bool useTag; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD540E1BD0
        public void OnTriggerEnter(){} // RVA: 0x7FFD540E1BF0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class DistanceHaptics : MonoBehaviour
    {
        public UnityEngine.Transform firstTransform; // 0x20
        public UnityEngine.Transform secondTransform; // 0x28
        public UnityEngine.AnimationCurve distanceIntensityCurve; // 0x30
        public UnityEngine.AnimationCurve pulseIntervalCurve; // 0x38

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD540E1E90
        public void .ctor(){} // RVA: 0x7FFD540E1F30
    }

    public class DontDestroyOnLoad : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD540E2460
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class EnumFlags : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Equippable : MonoBehaviour
    {
        public UnityEngine.Transform[] attachedHandType; // 0x20
        public 0x6656BAC8 defaultHand; // 0x28
        public UnityEngine.Vector3 initialScale; // 0x2C
        public Valve.VR.InteractionSystem.Interactable interactable; // 0x38

        // ── Methods ──
        public void get_attachedHandType(){} // RVA: 0x7FFD540E24F0
        public void Start(){} // RVA: 0x7FFD540E2600
        public void Update(){} // RVA: 0x7FFD540E2750
        public void .ctor(){} // RVA: 0x7FFD540E2B10
    }

    public class ExplosionWobble : MonoBehaviour
    {
        // ── Methods ──
        public void ExplosionEvent(){} // RVA: 0x7FFD54127570
        public void .ctor(){} // RVA: 0x7FFD4E341D50
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
        public void OnEnable(){} // RVA: 0x7FFD540E2B60
        public void Update(){} // RVA: 0x7FFD540E2BC0
        public void OnGUI(){} // RVA: 0x7FFD540E3590
        public void .ctor(){} // RVA: 0x7FFD540E3610
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
        public void Start(){} // RVA: 0x7FFD541276E0
        public void Update(){} // RVA: 0x7FFD541276F0
        public void OnTriggerEnter(){} // RVA: 0x7FFD54127880
        public void FireExposure(){} // RVA: 0x7FFD54127930
        public void StartBurning(){} // RVA: 0x7FFD54127B80
        public void .ctor(){} // RVA: 0x7FFD4F44DD00
    }

    public class Hand : MonoBehaviour
    {
        public 0x6656BC28 AttachedObjects;
        public Valve.VR.InteractionSystem.Hand hoverLocked; // 0x20
        public 0x66569C88 isActive; // 0x28
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
        public 0x66567AD8 fingerJointHover; // 0x88
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
        public System.Collections.Generic.List`1<0x6656BC80> attachedObjects; // 0xD8
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
        public void get_AttachedObjects(){} // RVA: 0x7FFD540E3670
        public void get_hoverLocked(){} // RVA: 0x7FFD4E46CF80
        public void set_hoverLocked(){} // RVA: 0x7FFD4E46CF90
        public void get_isActive(){} // RVA: 0x7FFD540E3740
        public void get_isPoseValid(){} // RVA: 0x7FFD540E3900
        public void get_hoveringInteractable(){} // RVA: 0x7FFD4E3C2970
        public void set_hoveringInteractable(){} // RVA: 0x7FFD540E3950
        public void get_currentAttachedObject(){} // RVA: 0x7FFD540E3EF0
        public void get_currentAttachedObjectInfo(){} // RVA: 0x7FFD540E3FA0
        public void get_currentAttachedTeleportManager(){} // RVA: 0x7FFD540E41F0
        public void get_skeleton(){} // RVA: 0x7FFD540E4290
        public void ShowController(){} // RVA: 0x7FFD540E4380
        public void HideController(){} // RVA: 0x7FFD540E4530
        public void ShowSkeleton(){} // RVA: 0x7FFD540E46E0
        public void HideSkeleton(){} // RVA: 0x7FFD540E4890
        public void HasSkeleton(){} // RVA: 0x7FFD540E4A40
        public void Show(){} // RVA: 0x7FFD540E4BD0
        public void Hide(){} // RVA: 0x7FFD540E4BE0
        public void SetVisibility(){} // RVA: 0x7FFD540E4BF0
        public void SetSkeletonRangeOfMotion(){} // RVA: 0x7FFD540E4CF0
        public void SetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFD540E4DD0
        public void ResetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFD540E5000
        public void SetAnimationState(){} // RVA: 0x7FFD540E51C0
        public void StopAnimation(){} // RVA: 0x7FFD540E53C0
        public void AttachObject(){} // RVA: 0x7FFD540E55C0
        public void ObjectIsAttached(){} // RVA: 0x7FFD540E87B0
        public void ForceHoverUnlock(){} // RVA: 0x7FFD4E7B9400
        public void DetachObject(){} // RVA: 0x7FFD540E89A0
        public void GetTrackedObjectVelocity(){} // RVA: 0x7FFD540EA100
        public void GetTrackedObjectAngularVelocity(){} // RVA: 0x7FFD540EA540
        public void GetEstimatedPeakVelocities(){} // RVA: 0x7FFD540EA980
        public void CleanUpAttachedObjectStack(){} // RVA: 0x7FFD540EAAF0
        public void Awake(){} // RVA: 0x7FFD540EAC70
        public void OnDestroy(){} // RVA: 0x7FFD540EB4F0
        public void OnTransformUpdated(){} // RVA: 0x7FFD53F0C8C0
        public void Start(){} // RVA: 0x7FFD540EB6D0
        public void UpdateHovering(){} // RVA: 0x7FFD540EB770
        public void CheckHoveringForTransform(){} // RVA: 0x7FFD540EBD30
        public void UpdateNoSteamVRFallback(){} // RVA: 0x7FFD540EC990
        public void UpdateDebugText(){} // RVA: 0x7FFD540ED120
        public void OnEnable(){} // RVA: 0x7FFD540EDD20
        public void OnDisable(){} // RVA: 0x7FFD540EDEB0
        public void Update(){} // RVA: 0x7FFD540EDF30
        public void IsStillHovering(){} // RVA: 0x7FFD540EE120
        public void HandFollowUpdate(){} // RVA: 0x7FFD540EE260
        public void FixedUpdate(){} // RVA: 0x7FFD540EF970
        public void UpdateAttachedVelocity(){} // RVA: 0x7FFD540F02C0
        public void ResetAttachedTransform(){} // RVA: 0x7FFD540F0680
        public void TargetItemPosition(){} // RVA: 0x7FFD540F08F0
        public void TargetItemRotation(){} // RVA: 0x7FFD540F0D90
        public void GetUpdatedAttachedVelocities(){} // RVA: 0x7FFD540F1640
        public void OnInputFocus(){} // RVA: 0x7FFD540F1E10
        public void OnDrawGizmos(){} // RVA: 0x7FFD540F1FB0
        public void HandDebugLog(){} // RVA: 0x7FFD540F2690
        public void HoverLock(){} // RVA: 0x7FFD540F2750
        public void HoverUnlock(){} // RVA: 0x7FFD540F2800
        public void TriggerHapticPulse(){} // RVA: 0x7FFD540F29F0 | overloaded x2
        public void ShowGrabHint(){} // RVA: 0x7FFD540F2B40 | overloaded x2
        public void HideGrabHint(){} // RVA: 0x7FFD540F2B30
        public void GetGrabStarting(){} // RVA: 0x7FFD540F2B70
        public void GetGrabEnding(){} // RVA: 0x7FFD540F2F70
        public void IsGrabEnding(){} // RVA: 0x7FFD540F3240
        public void IsGrabbingWithType(){} // RVA: 0x7FFD540F34C0
        public void IsGrabbingWithOppositeType(){} // RVA: 0x7FFD540F3650
        public void GetBestGrabbingType(){} // RVA: 0x7FFD540F37F0 | overloaded x2
        public void InitController(){} // RVA: 0x7FFD540F39C0
        public void SetRenderModel(){} // RVA: 0x7FFD540F46A0
        public void SetHoverRenderModel(){} // RVA: 0x7FFD540F4810
        public void GetDeviceIndex(){} // RVA: 0x7FFD540F48C0
        public void .ctor(){} // RVA: 0x7FFD540F4910
    }

    public class HandCollider : MonoBehaviour
    {
        public UnityEngine.Rigidbody rigidbody; // 0x20
        public Valve.VR.InteractionSystem.HandPhysics hand; // 0x28
        public UnityEngine.LayerMask collisionMask; // 0x30
        public UnityEngine.Collider[] colliders; // 0x38
        public 0x6656BE90 fingerColliders; // 0x40
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
        public void Awake(){} // RVA: 0x7FFD540F55E0
        public void Start(){} // RVA: 0x7FFD540F56C0
        public void SetPhysicMaterial(){} // RVA: 0x7FFD540F5EF0
        public void SetCollisionDetectionEnabled(){} // RVA: 0x7FFD540F6050
        public void MoveTo(){} // RVA: 0x7FFD540F60C0
        public void TeleportTo(){} // RVA: 0x7FFD540F60E0
        public void Reset(){} // RVA: 0x7FFD540F6390
        public void SetCenterPoint(){} // RVA: 0x7FFD540F63D0
        public void ExecuteFixedUpdate(){} // RVA: 0x7FFD540F63E0
        public void GetTargetVelocities(){} // RVA: 0x7FFD540F68F0
        public void OnCollisionEnter(){} // RVA: 0x7FFD540F6E20
        public void .ctor(){} // RVA: 0x7FFD540F7150
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
        public void Start(){} // RVA: 0x7FFD540F74E0
        public void FixedUpdate(){} // RVA: 0x7FFD540F7BB0
        public void UpdateCenterPoint(){} // RVA: 0x7FFD540F7E30
        public void UpdatePositions(){} // RVA: 0x7FFD540F80F0
        public void UpdateFingertips(){} // RVA: 0x7FFD540F9220
        public void UpdateHand(){} // RVA: 0x7FFD540F96F0
        public void ProcessPos(){} // RVA: 0x7FFD540F9D00
        public void ProcessRot(){} // RVA: 0x7FFD540F9E80
        public void .ctor(){} // RVA: 0x7FFD540F9F40
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
        public void Awake(){} // RVA: 0x7FFD540FA0A0
        public void OnHandHoverBegin(){} // RVA: 0x7FFD4E369200
        public void OnHandHoverEnd(){} // RVA: 0x7FFD53616D10
        public void Update(){} // RVA: 0x7FFD540FA1E0
        public void Pulse(){} // RVA: 0x7FFD540FA360
        public void .ctor(){} // RVA: 0x7FFD540FA4A0
    }

    public class HideOnHandFocusLost : MonoBehaviour
    {
        // ── Methods ──
        public void OnHandFocusLost(){} // RVA: 0x7FFD4EAB7F10
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class HoverButton : MonoBehaviour
    {
        public UnityEngine.Transform movingPart; // 0x20
        public UnityEngine.Vector3 localMoveDistance; // 0x28
        public float engageAtPercent; // 0x34
        public float disengageAtPercent; // 0x38
        public 0x6656BE38 onButtonDown; // 0x40
        public 0x6656BE38 onButtonUp; // 0x48
        public 0x6656BE38 onButtonIsPressed; // 0x50
        public bool engaged; // 0x58
        public bool buttonDown; // 0x59
        public bool buttonUp; // 0x5A
        public UnityEngine.Vector3 startPosition; // 0x5C
        public UnityEngine.Vector3 endPosition; // 0x68
        public UnityEngine.Vector3 handEnteredPosition; // 0x74
        public bool hovering; // 0x80
        public Valve.VR.InteractionSystem.Hand lastHoveredHand; // 0x88

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD540FA500
        public void HandHoverUpdate(){} // RVA: 0x7FFD540FA7D0
        public void LateUpdate(){} // RVA: 0x7FFD540FAED0
        public void InvokeEvents(){} // RVA: 0x7FFD540FB000
        public void .ctor(){} // RVA: 0x7FFD540FB0E0
    }

    public class IgnoreHovering : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.Hand onlyIgnoreHand; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class IgnoreTeleportTrace : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class InputModule : BaseInputModule
    {
        public UnityEngine.GameObject instance; // 0x58
        public Valve.VR.InteractionSystem.InputModule _instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFD540FB150
        public void ShouldActivateModule(){} // RVA: 0x7FFD540FB2E0
        public void HoverBegin(){} // RVA: 0x7FFD540FB3C0
        public void HoverEnd(){} // RVA: 0x7FFD540FB4C0
        public void Submit(){} // RVA: 0x7FFD4E409510
        public void Process(){} // RVA: 0x7FFD540FB5E0
        public void .ctor(){} // RVA: 0x7FFD540FB7B0
    }

    public class Interactable : MonoBehaviour
    {
        public Valve.VR.SteamVR_ActionSet hoveringHand; // 0x20
        public bool isDestroying; // 0x28
        public bool isHovering; // 0x29
        public bool wasHovering; // 0x2A
        public int handAnimationOnPickup; // 0x2C
        public 0x66567A28 setRangeOfMotionOnPickup; // 0x30
        public 0x6656C150 onAttachedToHand; // 0x38
        public 0x6656C1A8 onDetachedFromHand; // 0x40
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
        public void add_onAttachedToHand(){} // RVA: 0x7FFD540FB7C0
        public void remove_onAttachedToHand(){} // RVA: 0x7FFD540FB8B0
        public void add_onDetachedFromHand(){} // RVA: 0x7FFD540FB9A0
        public void remove_onDetachedFromHand(){} // RVA: 0x7FFD540FBA90
        public void get_hoveringHand(){} // RVA: 0x7FFD540FBB80
        public void get_isDestroying(){} // RVA: 0x7FFD4F611470
        public void set_isDestroying(){} // RVA: 0x7FFD4F60EB20
        public void get_isHovering(){} // RVA: 0x7FFD5165E950
        public void set_isHovering(){} // RVA: 0x7FFD5165E960
        public void get_wasHovering(){} // RVA: 0x7FFD540FBC10
        public void set_wasHovering(){} // RVA: 0x7FFD540FBC20
        public void Awake(){} // RVA: 0x7FFD540FBC30
        public void Start(){} // RVA: 0x7FFD540FBCC0
        public void ShouldIgnoreHighlight(){} // RVA: 0x7FFD540FC0A0
        public void ShouldIgnore(){} // RVA: 0x7FFD540FC120
        public void CreateHighlightRenderers(){} // RVA: 0x7FFD540FC2B0
        public void UpdateHighlightRenderers(){} // RVA: 0x7FFD540FCC00
        public void OnHandHoverBegin(){} // RVA: 0x7FFD540FD8B0
        public void OnHandHoverEnd(){} // RVA: 0x7FFD540FD960
        public void Update(){} // RVA: 0x7FFD540FDAE0
        public void OnAttachedToHand(){} // RVA: 0x7FFD540FDC10
        public void OnDetachedFromHand(){} // RVA: 0x7FFD540FDFD0
        public void OnDestroy(){} // RVA: 0x7FFD540FE4F0
        public void OnDisable(){} // RVA: 0x7FFD540FE730
        public void .ctor(){} // RVA: 0x7FFD540FE8E0
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
        public void get_isThrowable(){} // RVA: 0x7FFD540FEB00
        public void Awake(){} // RVA: 0x7FFD540FEBD0
        public void OnAttachedToHand(){} // RVA: 0x7FFD540FEE00
        public void HandAttachedUpdate(){} // RVA: 0x7FFD540FEE80
        public void OnDetachedFromHand(){} // RVA: 0x7FFD540FEFE0
        public void GetColliders(){} // RVA: 0x7FFD4E3BE740
        public void IgnoreObject(){} // RVA: 0x7FFD540FF5B0
        public void SetIsSimulation(){} // RVA: 0x7FFD540FF6C0
        public void CreateSimulation(){} // RVA: 0x7FFD540FF6D0
        public void CreateMarker(){} // RVA: 0x7FFD540FFAC0 | overloaded x2
        public void ColorSelf(){} // RVA: 0x7FFD54100270
        public void ColorThing(){} // RVA: 0x7FFD54100340
        public void .ctor(){} // RVA: 0x7FFD54100410
    }

    public class InteractableHoverEvents : MonoBehaviour
    {
        public UnityEngine.Events.UnityEvent onHandHoverBegin; // 0x20
        public UnityEngine.Events.UnityEvent onHandHoverEnd; // 0x28
        public UnityEngine.Events.UnityEvent onAttachedToHand; // 0x30
        public UnityEngine.Events.UnityEvent onDetachedFromHand; // 0x38

        // ── Methods ──
        public void OnHandHoverBegin(){} // RVA: 0x7FFD54100460
        public void OnHandHoverEnd(){} // RVA: 0x7FFD54100480
        public void OnAttachedToHand(){} // RVA: 0x7FFD541004A0
        public void OnDetachedFromHand(){} // RVA: 0x7FFD541004C0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class ItemPackage : MonoBehaviour
    {
        public string name; // 0x20
        public 0x6656C308 packageType; // 0x28
        public UnityEngine.GameObject itemPrefab; // 0x30
        public UnityEngine.GameObject otherHandItemPrefab; // 0x38
        public UnityEngine.GameObject previewPrefab; // 0x40
        public UnityEngine.GameObject fadedPreviewPrefab; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class ItemPackageReference : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.ItemPackage itemPackage; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
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
        public 0x6656BC28 attachmentFlags; // 0x3C
        public bool takeBackItem; // 0x40
        public bool acceptDifferentItems; // 0x41
        public UnityEngine.GameObject spawnedItem; // 0x48
        public bool itemIsSpawned; // 0x50
        public UnityEngine.Events.UnityEvent pickupEvent; // 0x58
        public UnityEngine.Events.UnityEvent dropEvent; // 0x60
        public bool justPickedUpItem; // 0x68

        // ── Methods ──
        public void get_itemPackage(){} // RVA: 0x7FFD4E36F0C0
        public void set_itemPackage(){} // RVA: 0x7FFD541004E0
        public void CreatePreviewObject(){} // RVA: 0x7FFD541004F0
        public void Start(){} // RVA: 0x7FFD54100B00
        public void VerifyItemPackage(){} // RVA: 0x7FFD54100B00
        public void ItemPackageNotValid(){} // RVA: 0x7FFD54100C90
        public void ClearPreview(){} // RVA: 0x7FFD54100E00
        public void Update(){} // RVA: 0x7FFD54101150
        public void OnHandHoverBegin(){} // RVA: 0x7FFD54101250
        public void TakeBackItem(){} // RVA: 0x7FFD54101430
        public void GetAttachedItemPackage(){} // RVA: 0x7FFD54101490
        public void HandHoverUpdate(){} // RVA: 0x7FFD54101650
        public void OnHandHoverEnd(){} // RVA: 0x7FFD54101850
        public void RemoveMatchingItemsFromHandStack(){} // RVA: 0x7FFD541018A0
        public void RemoveMatchingItemTypesFromHand(){} // RVA: 0x7FFD54101CD0
        public void SpawnAndAttachObject(){} // RVA: 0x7FFD54101F40
        public void .ctor(){} // RVA: 0x7FFD54102570
    }

    public class LinearAnimation : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.LinearMapping linearMapping; // 0x20
        public UnityEngine.Animation animation; // 0x28
        public UnityEngine.AnimationState animState; // 0x30
        public float animLength; // 0x38
        public float lastValue; // 0x3C

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD541025C0
        public void Update(){} // RVA: 0x7FFD54102A70
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class LinearAnimator : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.LinearMapping linearMapping; // 0x20
        public UnityEngine.Animator animator; // 0x28
        public float currentLinearMapping; // 0x30
        public int framesUnchanged; // 0x34

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD54102AD0
        public void Update(){} // RVA: 0x7FFD54102D80
        public void .ctor(){} // RVA: 0x7FFD54102E60
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
        public void Awake(){} // RVA: 0x7FFD54102EB0
        public void Update(){} // RVA: 0x7FFD54103100
        public void Apply(){} // RVA: 0x7FFD54103220
        public void .ctor(){} // RVA: 0x7FFD4F6B40A0
    }

    public class LinearBlendshape : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.LinearMapping linearMapping; // 0x20
        public UnityEngine.SkinnedMeshRenderer skinnedMesh; // 0x28
        public float lastValue; // 0x30

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD54103330
        public void Update(){} // RVA: 0x7FFD54103580
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class LinearDisplacement : MonoBehaviour
    {
        public UnityEngine.Vector3 displacement; // 0x20
        public Valve.VR.InteractionSystem.LinearMapping linearMapping; // 0x30
        public UnityEngine.Vector3 initialPosition; // 0x38

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD54103660
        public void Update(){} // RVA: 0x7FFD54103850
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class LinearDrive : MonoBehaviour
    {
        public UnityEngine.Transform startPosition; // 0x20
        public UnityEngine.Transform endPosition; // 0x28
        public Valve.VR.InteractionSystem.LinearMapping linearMapping; // 0x30
        public bool repositionGameObject; // 0x38
        public bool maintainMomemntum; // 0x39
        public float momemtumDampenRate; // 0x3C
        public 0x6656BC28 attachmentFlags; // 0x40
        public float initialMappingOffset; // 0x44
        public int numMappingChangeSamples; // 0x48
        public float[] mappingChangeSamples; // 0x50
        public float prevMapping; // 0x58
        public float mappingChangeRate; // 0x5C
        public int sampleCount; // 0x60
        public Valve.VR.InteractionSystem.Interactable interactable; // 0x68

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD54103A30
        public void Start(){} // RVA: 0x7FFD54103B50
        public void HandHoverUpdate(){} // RVA: 0x7FFD54103E60
        public void HandAttachedUpdate(){} // RVA: 0x7FFD54104060
        public void OnDetachedFromHand(){} // RVA: 0x7FFD54104190
        public void CalculateMappingChangeRate(){} // RVA: 0x7FFD54104190
        public void UpdateLinearMapping(){} // RVA: 0x7FFD54104210
        public void CalculateLinearMapping(){} // RVA: 0x7FFD54104520
        public void Update(){} // RVA: 0x7FFD54104820
        public void .ctor(){} // RVA: 0x7FFD54104B40
    }

    public class LinearMapping : MonoBehaviour
    {
        public float value; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Longbow : MonoBehaviour
    {
        public 0x6656D540 currentHandGuess; // 0x20
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
        public void OnAttachedToHand(){} // RVA: 0x7FFD4E369200
        public void HandAttachedUpdate(){} // RVA: 0x7FFD54128120
        public void ArrowReleased(){} // RVA: 0x7FFD541291F0
        public void ResetDrawAnim(){} // RVA: 0x7FFD54129370
        public void GetArrowVelocity(){} // RVA: 0x7FFD4E562100
        public void StartRotationLerp(){} // RVA: 0x7FFD54129410
        public void StartNock(){} // RVA: 0x7FFD541294F0
        public void EvaluateHandedness(){} // RVA: 0x7FFD54129670
        public void DoHandednessCheck(){} // RVA: 0x7FFD541297C0
        public void ArrowInPosition(){} // RVA: 0x7FFD541298A0
        public void ReleaseNock(){} // RVA: 0x7FFD54129990
        public void ShutDown(){} // RVA: 0x7FFD54129A10
        public void OnHandFocusLost(){} // RVA: 0x7FFD4EAB7F10
        public void OnHandFocusAcquired(){} // RVA: 0x7FFD54129DE0
        public void OnDetachedFromHand(){} // RVA: 0x7FFD54129F00
        public void OnDestroy(){} // RVA: 0x7FFD54129FA0
        public void .ctor(){} // RVA: 0x7FFD54129FB0
    }

    public class ModalThrowable : Throwable
    {
        public UnityEngine.Transform gripOffset; // 0xC0
        public UnityEngine.Transform pinchOffset; // 0xC8

        // ── Methods ──
        public void HandHoverUpdate(){} // RVA: 0x7FFD54104BA0
        public void HandAttachedUpdate(){} // RVA: 0x7FFD54104C90
        public void .ctor(){} // RVA: 0x7FFD54104F30
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
        public void Awake(){} // RVA: 0x7FFD54107D00
        public void Play(){} // RVA: 0x7FFD54107FE0
        public void PlayWithDelay(){} // RVA: 0x7FFD54108190
        public void PlayOneShotSound(){} // RVA: 0x7FFD54108210
        public void PlayLooping(){} // RVA: 0x7FFD541083B0
        public void Disable(){} // RVA: 0x7FFD4EAB7F10
        public void Stop(){} // RVA: 0x7FFD541085C0
        public void SetAudioSource(){} // RVA: 0x7FFD54108620
        public void .ctor(){} // RVA: 0x7FFD541088A0
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
        public void get_instance(){} // RVA: 0x7FFD54105020
        public void get_handCount(){} // RVA: 0x7FFD541051B0
        public void GetHand(){} // RVA: 0x7FFD541052F0
        public void get_leftHand(){} // RVA: 0x7FFD54105440
        public void get_rightHand(){} // RVA: 0x7FFD541055B0
        public void get_scale(){} // RVA: 0x7FFD54105720
        public void get_hmdTransform(){} // RVA: 0x7FFD541057E0
        public void get_eyeHeight(){} // RVA: 0x7FFD54105920
        public void get_feetPositionGuess(){} // RVA: 0x7FFD54105BD0
        public void get_bodyDirectionGuess(){} // RVA: 0x7FFD54105F30
        public void Awake(){} // RVA: 0x7FFD54106170
        public void Start(){} // RVA: 0x7FFD54106410
        public void Update(){} // RVA: 0x7FFD541064B0
        public void OnDrawGizmos(){} // RVA: 0x7FFD54106680
        public void Draw2DDebug(){} // RVA: 0x7FFD54107240
        public void ActivateRig(){} // RVA: 0x7FFD54107480
        public void PlayerShotSelf(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD541079D0
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
        public 0x66569C88 inputSource; // 0xA0

        // ── Methods ──
        public void add_onControllerLoaded(){} // RVA: 0x7FFD54108910
        public void remove_onControllerLoaded(){} // RVA: 0x7FFD54108A00
        public void Awake(){} // RVA: 0x7FFD54108AF0
        public void InitializeHand(){} // RVA: 0x7FFD54108BF0
        public void InitializeController(){} // RVA: 0x7FFD541095E0
        public void DestroyHand(){} // RVA: 0x7FFD54109BE0
        public void OnSkeletonActiveChange(){} // RVA: 0x7FFD54109F70
        public void OnEnable(){} // RVA: 0x7FFD54109F90
        public void OnDisable(){} // RVA: 0x7FFD54109FC0
        public void OnDestroy(){} // RVA: 0x7FFD4E3F5BC0
        public void GetSkeleton(){} // RVA: 0x7FFD4E3BE740
        public void SetInputSource(){} // RVA: 0x7FFD54109FF0
        public void OnHandInitialized(){} // RVA: 0x7FFD5410A0E0
        public void MatchHandToTransform(){} // RVA: 0x7FFD5410A120
        public void SetHandPosition(){} // RVA: 0x7FFD5410A4E0
        public void SetHandRotation(){} // RVA: 0x7FFD5410A670
        public void GetHandPosition(){} // RVA: 0x7FFD5410A7F0
        public void GetHandRotation(){} // RVA: 0x7FFD5410A9E0
        public void OnRenderModelLoaded(){} // RVA: 0x7FFD5410ABB0
        public void SetVisibility(){} // RVA: 0x7FFD5410AE50
        public void Show(){} // RVA: 0x7FFD5410AED0
        public void Hide(){} // RVA: 0x7FFD5410AF20
        public void SetMaterial(){} // RVA: 0x7FFD5410AF50
        public void SetControllerMaterial(){} // RVA: 0x7FFD5410B020
        public void SetHandMaterial(){} // RVA: 0x7FFD5410B160
        public void SetControllerVisibility(){} // RVA: 0x7FFD5410B220
        public void SetHandVisibility(){} // RVA: 0x7FFD5410B2F0
        public void IsHandVisibile(){} // RVA: 0x7FFD5410B3C0
        public void IsControllerVisibile(){} // RVA: 0x7FFD5410B490
        public void GetBone(){} // RVA: 0x7FFD5410B560
        public void GetBonePosition(){} // RVA: 0x7FFD5410B670
        public void GetControllerPosition(){} // RVA: 0x7FFD5410B7D0
        public void GetBoneRotation(){} // RVA: 0x7FFD5410BA50
        public void SetSkeletonRangeOfMotion(){} // RVA: 0x7FFD5410BCA0
        public void get_GetSkeletonRangeOfMotion(){} // RVA: 0x7FFD5410BEF0
        public void SetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFD5410BFE0
        public void ResetTemporarySkeletonRangeOfMotion(){} // RVA: 0x7FFD5410C140
        public void SetAnimationState(){} // RVA: 0x7FFD5410C240
        public void StopAnimation(){} // RVA: 0x7FFD5410C370
        public void CheckAnimatorInit(){} // RVA: 0x7FFD5410C490
        public void .ctor(){} // RVA: 0x7FFD5410C880
    }

    public class SeeThru : MonoBehaviour
    {
        public UnityEngine.Material seeThruMaterial; // 0x20
        public UnityEngine.GameObject seeThru; // 0x28
        public Valve.VR.InteractionSystem.Interactable interactable; // 0x30
        public UnityEngine.Renderer sourceRenderer; // 0x38
        public UnityEngine.Renderer destRenderer; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5410C950
        public void OnEnable(){} // RVA: 0x7FFD5410DB50
        public void OnDisable(){} // RVA: 0x7FFD5410DDE0
        public void AttachedToHand(){} // RVA: 0x7FFD5410E070
        public void DetachedFromHand(){} // RVA: 0x7FFD4EB193F0
        public void Update(){} // RVA: 0x7FFD5410E0D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SleepOnAwake : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5410E540
        public void .ctor(){} // RVA: 0x7FFD4E341D50
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
        public void Start(){} // RVA: 0x7FFD5412A450
        public void AllOff(){} // RVA: 0x7FFD5412A460
        public void Update(){} // RVA: 0x7FFD5412A660
        public void RotatePlayer(){} // RVA: 0x7FFD5412AE00
        public void DoRotatePlayer(){} // RVA: 0x7FFD5412AF50
        public void ShowRotateFX(){} // RVA: 0x7FFD5412B010
        public void UpdateOrientation(){} // RVA: 0x7FFD5412B180
        public void .ctor(){} // RVA: 0x7FFD5412B8F0
    }

    public class SoundBowClick : MonoBehaviour
    {
        public UnityEngine.AudioClip bowClick; // 0x20
        public UnityEngine.AnimationCurve pitchTensionCurve; // 0x28
        public float minPitch; // 0x30
        public float maxPitch; // 0x34
        public UnityEngine.AudioSource thisAudioSource; // 0x38

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5412A2C0
        public void PlayBowTensionClicks(){} // RVA: 0x7FFD5412A350
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SoundDeparent : MonoBehaviour
    {
        public bool destroyAfterPlayOnce; // 0x20
        public UnityEngine.AudioSource thisAudioSource; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5410E670
        public void Start(){} // RVA: 0x7FFD5410E700
        public void .ctor(){} // RVA: 0x7FFD4E39B060
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
        public void Awake(){} // RVA: 0x7FFD5410E910
        public void Play(){} // RVA: 0x7FFD5410E9B0
        public void Pause(){} // RVA: 0x7FFD5410EBB0
        public void UnPause(){} // RVA: 0x7FFD5410ECD0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SpawnAndAttachAfterControllerIsTracking : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.Hand hand; // 0x20
        public UnityEngine.GameObject itemPrefab; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD5410EDF0
        public void Update(){} // RVA: 0x7FFD5410EE80
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SpawnAndAttachToHand : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.Hand hand; // 0x20
        public UnityEngine.GameObject prefab; // 0x28

        // ── Methods ──
        public void SpawnAndAttach(){} // RVA: 0x7FFD5410F160
        public void .ctor(){} // RVA: 0x7FFD4E341D50
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
        public void ChangeSceneAction(){} // RVA: 0x7FFD5412CEF0
        public void PlayerAction(){} // RVA: 0x7FFD5412CFA0
        public void PlayerPreAction(){} // RVA: 0x7FFD5412D060
        public void get_instance(){} // RVA: 0x7FFD5412D120
        public void Awake(){} // RVA: 0x7FFD5412D2F0
        public void Start(){} // RVA: 0x7FFD5412D910
        public void OnEnable(){} // RVA: 0x7FFD5412DD30
        public void OnDisable(){} // RVA: 0x7FFD5412DD70
        public void CheckForSpawnPoint(){} // RVA: 0x7FFD5412DDB0
        public void HideTeleportPointer(){} // RVA: 0x7FFD5412DF50
        public void Update(){} // RVA: 0x7FFD5412E030
        public void UpdatePointer(){} // RVA: 0x7FFD5412EA40
        public void FixedUpdate(){} // RVA: 0x7FFD541306A0
        public void OnChaperoneInfoInitialized(){} // RVA: 0x7FFD54130FB0
        public void HidePointer(){} // RVA: 0x7FFD54132770
        public void ShowPointer(){} // RVA: 0x7FFD54133110
        public void UpdateTeleportColors(){} // RVA: 0x7FFD541342C0
        public void PlayAudioClip(){} // RVA: 0x7FFD541343E0
        public void PlayPointerHaptic(){} // RVA: 0x7FFD54134490
        public void TryTeleportPlayer(){} // RVA: 0x7FFD54134650
        public void InitiateTeleportFade(){} // RVA: 0x7FFD54134780
        public void TeleportPlayer(){} // RVA: 0x7FFD54134BD0
        public void HighlightSelected(){} // RVA: 0x7FFD54135970
        public void ShowTeleportHint(){} // RVA: 0x7FFD54135F20
        public void CancelTeleportHint(){} // RVA: 0x7FFD54136040
        public void TeleportHintCoroutine(){} // RVA: 0x7FFD541361A0
        public void IsEligibleForTeleport(){} // RVA: 0x7FFD54136240
        public void ShouldOverrideHoverLock(){} // RVA: 0x7FFD54136670
        public void WasTeleportButtonReleased(){} // RVA: 0x7FFD54136770
        public void IsTeleportButtonDown(){} // RVA: 0x7FFD541368E0
        public void WasTeleportButtonPressed(){} // RVA: 0x7FFD54136A50
        public void GetPointerStartTransform(){} // RVA: 0x7FFD54136BC0
        public void .ctor(){} // RVA: 0x7FFD54136D20
        public void .cctor(){} // RVA: 0x7FFD54136F60
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
        public void Start(){} // RVA: 0x7FFD54137510
        public void Update(){} // RVA: 0x7FFD54137570
        public void CreateLineRendererObjects(){} // RVA: 0x7FFD54137680
        public void SetArcData(){} // RVA: 0x7FFD54137F80
        public void Show(){} // RVA: 0x7FFD54138020
        public void Hide(){} // RVA: 0x7FFD54138040
        public void DrawArc(){} // RVA: 0x7FFD54138080
        public void DrawArcSegment(){} // RVA: 0x7FFD54138460
        public void SetColor(){} // RVA: 0x7FFD54138650
        public void FindProjectileCollision(){} // RVA: 0x7FFD541387A0
        public void GetArcPositionAtTime(){} // RVA: 0x7FFD54138AF0
        public void HideLineSegments(){} // RVA: 0x7FFD54138CC0
        public void .ctor(){} // RVA: 0x7FFD54138D80
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
        public void get_meshBounds(){} // RVA: 0x7FFD4FF91360
        public void set_meshBounds(){} // RVA: 0x7FFD4FF91340
        public void Awake(){} // RVA: 0x7FFD54138E00
        public void Start(){} // RVA: 0x7FFD54138F00
        public void ShouldActivate(){} // RVA: 0x7FFD4E426850
        public void ShouldMovePlayer(){} // RVA: 0x7FFD4E426850
        public void Highlight(){} // RVA: 0x7FFD541390D0
        public void SetAlpha(){} // RVA: 0x7FFD541391A0
        public void UpdateVisuals(){} // RVA: 0x7FFD541392D0
        public void UpdateVisualsInEditor(){} // RVA: 0x7FFD541393F0
        public void CalculateBounds(){} // RVA: 0x7FFD541395E0
        public void GetTintColor(){} // RVA: 0x7FFD54139820
        public void .ctor(){} // RVA: 0x7FFD54139850
    }

    public class TeleportMarkerBase : MonoBehaviour
    {
        public bool showReticle; // 0x20
        public bool markerActive; // 0x21

        // ── Methods ──
        public void get_showReticle(){} // RVA: 0x7FFD4E426850
        public void SetLocked(){} // RVA: 0x7FFD541398B0
        public void TeleportPlayer(){} // RVA: 0x7FFD4E341310
        public void UpdateVisuals(){} // RVA: 0x7FFD4E090980
        public void Highlight(){} // RVA: 0x7FFD4E091060
        public void SetAlpha(){}
        public void ShouldActivate(){} // RVA: 0x7FFD4E079F60
        public void ShouldMovePlayer(){} // RVA: 0x7FFD4E079D00
        public void .ctor(){} // RVA: 0x7FFD541398D0
    }

    public class TeleportPoint : TeleportMarkerBase
    {
        public 0x6656DA68 showReticle; // 0x28
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
        public void get_showReticle(){} // RVA: 0x7FFD4E341320
        public void Awake(){} // RVA: 0x7FFD54139920
        public void Start(){} // RVA: 0x7FFD54139C40
        public void Update(){} // RVA: 0x7FFD54139CB0
        public void ShouldActivate(){} // RVA: 0x7FFD54139F00
        public void ShouldMovePlayer(){} // RVA: 0x7FFD4E426850
        public void Highlight(){} // RVA: 0x7FFD5413A090
        public void UpdateVisuals(){} // RVA: 0x7FFD5413A370
        public void SetAlpha(){} // RVA: 0x7FFD5413A5B0
        public void SetMeshMaterials(){} // RVA: 0x7FFD5413A9F0
        public void TeleportToScene(){} // RVA: 0x7FFD5413ABC0
        public void GetRelevantComponents(){} // RVA: 0x7FFD5413ACB0
        public void ReleaseRelevantComponents(){} // RVA: 0x7FFD5413B5F0
        public void UpdateVisualsInEditor(){} // RVA: 0x7FFD5413B800
        public void .ctor(){} // RVA: 0x7FFD5413BCD0
    }

    public class TeleportURPHelper : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Throwable : MonoBehaviour
    {
        public 0x6656BC28 attachmentFlags; // 0x20
        public UnityEngine.Transform attachmentOffset; // 0x28
        public float catchingSpeedThreshold; // 0x30
        public 0x6656CB48 releaseVelocityStyle; // 0x34
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
        public 0x6656BE38 onHeldUpdate; // 0xA0
        public ÎÏÎÍÍÌÎÌÍÌÍÌÏÌÍ hadInterpolation; // 0xA8
        public UnityEngine.Rigidbody rigidbody; // 0xB0
        public Valve.VR.InteractionSystem.Interactable interactable; // 0xB8

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5410F320
        public void OnHandHoverBegin(){} // RVA: 0x7FFD5410F5B0
        public void OnHandHoverEnd(){} // RVA: 0x7FFD5410F780
        public void HandHoverUpdate(){} // RVA: 0x7FFD5410F7B0
        public void OnAttachedToHand(){} // RVA: 0x7FFD5410F870
        public void OnDetachedFromHand(){} // RVA: 0x7FFD5410FC40
        public void GetReleaseVelocities(){} // RVA: 0x7FFD5410FE20
        public void HandAttachedUpdate(){} // RVA: 0x7FFD54110630
        public void LateDetach(){} // RVA: 0x7FFD54110740
        public void OnHandFocusAcquired(){} // RVA: 0x7FFD54110840
        public void OnHandFocusLost(){} // RVA: 0x7FFD541109C0
        public void .ctor(){} // RVA: 0x7FFD54104F30
    }

    public class UIElement : MonoBehaviour
    {
        public 0x6656B758 onHandClick; // 0x20
        public Valve.VR.InteractionSystem.Hand currentHand; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD54110CB0
        public void OnHandHoverBegin(){} // RVA: 0x7FFD54110E00
        public void OnHandHoverEnd(){} // RVA: 0x7FFD541110A0
        public void HandHoverUpdate(){} // RVA: 0x7FFD54111360
        public void OnButtonClick(){} // RVA: 0x7FFD54111580
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Unparent : MonoBehaviour
    {
        public UnityEngine.Transform oldParent; // 0x20

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD541115D0
        public void Update(){} // RVA: 0x7FFD54111880
        public void GetOldParent(){} // RVA: 0x7FFD4E36F0C0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
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
        public void RemapNumber(){} // RVA: 0x7FFD541119B0
        public void RemapNumberClamped(){} // RVA: 0x7FFD541119D0
        public void Approach(){} // RVA: 0x7FFD54111A40
        public void BezierInterpolate3(){} // RVA: 0x7FFD54111A70
        public void BezierInterpolate4(){} // RVA: 0x7FFD54111C00
        public void Vector3FromString(){} // RVA: 0x7FFD54111EB0
        public void Vector2FromString(){} // RVA: 0x7FFD54111FD0
        public void Normalize(){} // RVA: 0x7FFD541120C0
        public void Vector2AsVector3(){} // RVA: 0x7FFD4E3A93F0
        public void Vector3AsVector2(){} // RVA: 0x7FFD4E3A93D0
        public void AngleOf(){} // RVA: 0x7FFD541120D0
        public void YawOf(){} // RVA: 0x7FFD54112130
        public void Swap(){} // RVA: 0x7FFD4E090C80
        public void Shuffle(){} // RVA: 0x7FFD4E090A10 | overloaded x2
        public void RandomWithLookback(){} // RVA: 0x7FFD54112180
        public void FindChild(){} // RVA: 0x7FFD54112360
        public void IsNullOrEmpty(){} // RVA: 0x7FFD4E079DE0
        public void IsValidIndex(){} // RVA: 0x7FFD4E07BDB0 | overloaded x2
        public void FindOrAdd(){} // RVA: 0x7FFD4E2ADC40
        public void FindAndRemove(){} // RVA: 0x7FFD4E078FF0
        public void FindOrAddComponent(){} // RVA: 0x7FFD4E2ADC40
        public void FastRemove(){} // RVA: 0x7FFD4E096370
        public void ReplaceGameObject(){} // RVA: 0x7FFD4E2ADC40
        public void SwitchLayerRecursively(){} // RVA: 0x7FFD54112610
        public void DrawCross(){} // RVA: 0x7FFD54112840
        public void ResetTransform(){} // RVA: 0x7FFD54112E90
        public void ClosestPointOnLine(){} // RVA: 0x7FFD54113030
        public void AfterTimer(){} // RVA: 0x7FFD541132F0
        public void SendPhysicsMessage(){} // RVA: 0x7FFD541136C0 | overloaded x2
        public void IgnoreCollisions(){} // RVA: 0x7FFD541139B0
        public void WrapCoroutine(){} // RVA: 0x7FFD54113B50
        public void ColorWithAlpha(){} // RVA: 0x7FFD4EA988D0
        public void Quit(){} // RVA: 0x7FFD54113C50
        public void FloatToDecimal(){} // RVA: 0x7FFD54113C80
        public void Median(){} // RVA: 0x7FFD4E2ADC40
        public void ForEach(){} // RVA: 0x7FFD4E090C80
        public void FixupNewlines(){} // RVA: 0x7FFD54113DA0
        public void PathLength(){} // RVA: 0x7FFD54113E60
        public void HasCommandLineArgument(){} // RVA: 0x7FFD54114040
        public void GetCommandLineArgValue(){} // RVA: 0x7FFD541141C0 | overloaded x2
        public void SetActive(){} // RVA: 0x7FFD541142A0
        public void CombinePaths(){} // RVA: 0x7FFD541143B0
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
        public void BeginEstimatingVelocity(){} // RVA: 0x7FFD541148D0
        public void FinishEstimatingVelocity(){} // RVA: 0x7FFD541149F0
        public void GetVelocityEstimate(){} // RVA: 0x7FFD54114A70
        public void GetAngularVelocityEstimate(){} // RVA: 0x7FFD54114BA0
        public void GetAccelerationEstimate(){} // RVA: 0x7FFD54114CD0
        public void Awake(){} // RVA: 0x7FFD54114EB0
        public void EstimateVelocityCoroutine(){} // RVA: 0x7FFD54114FD0
        public void .ctor(){} // RVA: 0x7FFD54115070
    }

}