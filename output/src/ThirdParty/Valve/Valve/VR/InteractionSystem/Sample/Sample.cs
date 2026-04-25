// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR.InteractionSystem.Sample
// Classes: 25
// Methods: 109

namespace ThirdParty.Valve.Valve.VR.InteractionSystem.Sample
{
    public class AmbientSound : MonoBehaviour
    {
        public UnityEngine.AudioSource s; // 0x20
        public float fadeintime; // 0x28
        public float t; // 0x2C
        public bool fadeblack; // 0x30
        public float vol; // 0x34

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D1BD80
        public void Update(){} // RVA: 0x7FFAC8D1C090
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class BuggyBuddy : MonoBehaviour
    {
        public UnityEngine.Transform turret; // 0x20
        public float turretRot; // 0x28
        public float maxAngle; // 0x2C
        public float maxTurnTorque; // 0x30
        public float maxTorque; // 0x34
        public float brakeTorque; // 0x38
        public UnityEngine.GameObject[] wheelRenders; // 0x40
        public float criticalSpeed; // 0x48
        public int stepsBelow; // 0x4C
        public int stepsAbove; // 0x50
        public UnityEngine.WheelCollider[] m_Wheels; // 0x58
        public UnityEngine.AudioSource au_motor; // 0x60
        public float mvol; // 0x68
        public UnityEngine.AudioSource au_skid; // 0x70
        public float svol; // 0x78
        public Valve.VR.InteractionSystem.Sample.WheelDust skidsample; // 0x80
        public float skidSpeed; // 0x88
        public UnityEngine.Vector3 localGravity; // 0x8C
        public UnityEngine.Rigidbody body; // 0x98
        public float rapidfireTime; // 0xA0
        public float shootTimer; // 0xA4
        public UnityEngine.Vector2 steer; // 0xA8
        public float throttle; // 0xB0
        public float handBrake; // 0xB4
        public UnityEngine.Transform controllerReference; // 0xB8
        public float speed; // 0xC0
        public UnityEngine.Transform centerOfMass; // 0xC8

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D1C140
        public void Update(){} // RVA: 0x7FFAC8D1C4F0
        public void FixedUpdate(){} // RVA: 0x7FFAC8D1D140
        public void FindAngle(){} // RVA: 0x7FFAC8D1D1D0
        public void .ctor(){} // RVA: 0x7FFAC8D1D3A0
    }

    public class BuggyController : MonoBehaviour
    {
        public UnityEngine.Transform modelJoystick; // 0x20
        public float joystickRot; // 0x28
        public UnityEngine.Transform modelTrigger; // 0x30
        public float triggerRot; // 0x38
        public Valve.VR.InteractionSystem.Sample.BuggyBuddy buggy; // 0x40
        public UnityEngine.Transform buttonBrake; // 0x48
        public UnityEngine.Transform buttonReset; // 0x50
        public UnityEngine.Canvas ui_Canvas; // 0x58
        public UnityEngine.UI.Image ui_rpm; // 0x60
        public UnityEngine.UI.Image ui_speed; // 0x68
        public UnityEngine.RectTransform ui_steer; // 0x70
        public float ui_steerangle; // 0x78
        public UnityEngine.Vector2 ui_fillAngles; // 0x7C
        public UnityEngine.Transform resetToPoint; // 0x88
        public Valve.VR.SteamVR_Action_Vector2 actionSteering; // 0x90
        public Valve.VR.SteamVR_Action_Single actionThrottle; // 0x98
        public Valve.VR.SteamVR_Action_Boolean actionBrake; // 0xA0
        public Valve.VR.SteamVR_Action_Boolean actionReset; // 0xA8
        public float usteer; // 0xB0
        public Valve.VR.InteractionSystem.Interactable interactable; // 0xB8
        public UnityEngine.Quaternion trigSRot; // 0xC0
        public UnityEngine.Quaternion joySRot; // 0xD0
        public UnityEngine.Coroutine resettingRoutine; // 0xE0
        public UnityEngine.Vector3 initialScale; // 0xE8
        public float buzztimer; // 0xF4

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D1D420
        public void Update(){} // RVA: 0x7FFAC8D1D7B0
        public void DoReset(){} // RVA: 0x7FFAC8D1E310
        public void DoBuzz(){} // RVA: 0x7FFAC8D1E3B0
        public void .ctor(){} // RVA: 0x7FFAC8D1E450
    }

    public class ButtonEffect : MonoBehaviour
    {
        // ── Methods ──
        public void OnButtonDown(){} // RVA: 0x7FFAC8D25490
        public void OnButtonUp(){} // RVA: 0x7FFAC8D25510
        public void ColorSelf(){} // RVA: 0x7FFAC8D25540
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class ButtonExample : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.HoverButton hoverButton; // 0x20
        public UnityEngine.GameObject prefab; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D25660
        public void OnButtonDown(){} // RVA: 0x7FFAC8D25720
        public void DoPlant(){} // RVA: 0x7FFAC8D257D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class ControllerHintsExample : MonoBehaviour
    {
        public UnityEngine.Coroutine buttonHintCoroutine; // 0x20
        public UnityEngine.Coroutine textHintCoroutine; // 0x28

        // ── Methods ──
        public void ShowButtonHints(){} // RVA: 0x7FFAC8D264B0
        public void ShowTextHints(){} // RVA: 0x7FFAC8D265E0
        public void DisableHints(){} // RVA: 0x7FFAC8D26710
        public void TestButtonHints(){} // RVA: 0x7FFAC8D26850
        public void TestTextHints(){} // RVA: 0x7FFAC8D268F0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class CustomSkeletonHelper : MonoBehaviour
    {
        public Retargetable wrist; // 0x20
        public Finger[] fingers; // 0x28
        public Thumb[] thumbs; // 0x30

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFAC8D27210
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class FloppyHand : MonoBehaviour
    {
        public float fingerFlexAngle; // 0x20
        public Valve.VR.SteamVR_Action_Single squeezyAction; // 0x28
        public 0x6B209C88 inputSource; // 0x30
        public Finger[] fingers; // 0x38
        public UnityEngine.Vector3 constforce; // 0x40

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D27A70
        public void Update(){} // RVA: 0x7FFAC8D27BD0
        public void .ctor(){} // RVA: 0x7FFAC8D27F10
    }

    public class FlowerPlanted : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D299A0
        public void Plant(){} // RVA: 0x7FFAC8D299A0
        public void DoPlant(){} // RVA: 0x7FFAC8D29A50
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Grenade : MonoBehaviour
    {
        public UnityEngine.GameObject explodePartPrefab; // 0x20
        public int explodeCount; // 0x28
        public float minMagnitudeToExplode; // 0x2C
        public Valve.VR.InteractionSystem.Interactable interactable; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D216B0
        public void OnCollisionEnter(){} // RVA: 0x7FFAC8D21740
        public void .ctor(){} // RVA: 0x7FFAC8D21E20
    }

    public class InteractableExample : MonoBehaviour
    {
        public UnityEngine.TextMesh generalText; // 0x20
        public UnityEngine.TextMesh hoveringText; // 0x28
        public UnityEngine.Vector3 oldPosition; // 0x30
        public UnityEngine.Quaternion oldRotation; // 0x3C
        public float attachTime; // 0x4C
        public 0x6B20BC28 attachmentFlags; // 0x50
        public Valve.VR.InteractionSystem.Interactable interactable; // 0x58
        public bool lastHovering; // 0x60

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8D2A900
        public void OnHandHoverBegin(){} // RVA: 0x7FFAC8D2ABB0
        public void OnHandHoverEnd(){} // RVA: 0x7FFAC8D2AC70
        public void HandHoverUpdate(){} // RVA: 0x7FFAC8D2AD10
        public void OnAttachedToHand(){} // RVA: 0x7FFAC8D2B220
        public void OnDetachedFromHand(){} // RVA: 0x7FFAC8D2B360
        public void HandAttachedUpdate(){} // RVA: 0x7FFAC8D2B450
        public void Update(){} // RVA: 0x7FFAC8D2B5D0
        public void OnHandFocusAcquired(){} // RVA: 0x7FFAC2F21310
        public void OnHandFocusLost(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC8D2B720
    }

    public class JoeJeff : MonoBehaviour
    {
        public float animationSpeed; // 0x20
        public float jumpVelocity; // 0x24
        public float m_MovingTurnSpeed; // 0x28
        public float m_StationaryTurnSpeed; // 0x2C
        public float airControl; // 0x30
        public float frictionTime; // 0x34
        public float footHeight; // 0x38
        public float footRadius; // 0x3C
        public UnityEngine.RaycastHit footHit; // 0x40
        public bool isGrounded; // 0x6C
        public float turnAmount; // 0x70
        public float forwardAmount; // 0x74
        public float groundedTime; // 0x78
        public UnityEngine.Animator animator; // 0x80
        public UnityEngine.Vector3 input; // 0x88
        public bool held; // 0x94
        public UnityEngine.Rigidbody rigidbody; // 0x98
        public Valve.VR.InteractionSystem.Interactable interactable; // 0xA0
        public Valve.VR.InteractionSystem.FireSource fire; // 0xA8
        public float jumpTimer; // 0xB0

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D21E80
        public void Update(){} // RVA: 0x7FFAC8D22070
        public void FixRotation(){} // RVA: 0x7FFAC8D22240
        public void OnAnimatorMove(){} // RVA: 0x7FFAC8D225D0
        public void Move(){} // RVA: 0x7FFAC8D22A60
        public void UpdateAnimator(){} // RVA: 0x7FFAC8D22D20
        public void ApplyExtraTurnRotation(){} // RVA: 0x7FFAC8D23070
        public void CheckGrounded(){} // RVA: 0x7FFAC8D231B0
        public void FixedUpdate(){} // RVA: 0x7FFAC8D23640
        public void HandleGroundedMovement(){} // RVA: 0x7FFAC8D23930
        public void Jump(){} // RVA: 0x7FFAC8D23950
        public void .ctor(){} // RVA: 0x7FFAC8D23C00
    }

    public class JoeJeffController : MonoBehaviour
    {
        public UnityEngine.Transform Joystick; // 0x20
        public float joyMove; // 0x28
        public Valve.VR.SteamVR_Action_Vector2 moveAction; // 0x30
        public Valve.VR.SteamVR_Action_Boolean jumpAction; // 0x38
        public Valve.VR.InteractionSystem.Sample.JoeJeff character; // 0x40
        public UnityEngine.Renderer jumpHighlight; // 0x48
        public UnityEngine.Vector3 movement; // 0x50
        public bool jump; // 0x5C
        public float glow; // 0x60
        public 0x6B209C88 hand; // 0x64
        public Valve.VR.InteractionSystem.Interactable interactable; // 0x68

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D23C70
        public void Update(){} // RVA: 0x7FFAC8D23D00
        public void .ctor(){} // RVA: 0x7FFAC8D244B0
    }

    public class JoeJeffGestures : MonoBehaviour
    {
        public float openFingerAmount;
        public float closedFingerAmount;
        public float closedThumbAmount;
        public Valve.VR.InteractionSystem.Sample.JoeJeff joeJeff; // 0x20
        public bool lastPeaceSignState; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8D24680
        public void Update(){} // RVA: 0x7FFAC8D24710
        public void PeaceSignRecognized(){} // RVA: 0x7FFAC8D24CC0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class LockToPoint : MonoBehaviour
    {
        public UnityEngine.Transform snapTo; // 0x20
        public UnityEngine.Rigidbody body; // 0x28
        public float snapTime; // 0x30
        public float dropTimer; // 0x34
        public Valve.VR.InteractionSystem.Interactable interactable; // 0x38

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D1F3E0
        public void FixedUpdate(){} // RVA: 0x7FFAC8D1F500
        public void .ctor(){} // RVA: 0x7FFAC8D20170
    }

    public class Planting : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Boolean plantAction; // 0x20
        public Valve.VR.InteractionSystem.Hand hand; // 0x28
        public UnityEngine.GameObject prefabToPlant; // 0x30

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC8D2B770
        public void OnDisable(){} // RVA: 0x7FFAC8D2BA30
        public void OnPlantActionChange(){} // RVA: 0x7FFAC8D2BBC0
        public void Plant(){} // RVA: 0x7FFAC8D2BC70
        public void DoPlant(){} // RVA: 0x7FFAC8D2BD20
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class ProceduralHats : MonoBehaviour
    {
        public UnityEngine.GameObject[] hats; // 0x20
        public float hatSwitchTime; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D24D00
        public void OnEnable(){} // RVA: 0x7FFAC8D24D10
        public void HatSwitcher(){} // RVA: 0x7FFAC8D24DC0
        public void ChooseHat(){} // RVA: 0x7FFAC8D24E60
        public void SwitchToHat(){} // RVA: 0x7FFAC8D24EE0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class RenderModelChangerUI : UIElement
    {
        public UnityEngine.GameObject leftPrefab; // 0x30
        public UnityEngine.GameObject rightPrefab; // 0x38
        public Valve.VR.InteractionSystem.Sample.SkeletonUIOptions ui; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8D2CBC0
        public void OnButtonClick(){} // RVA: 0x7FFAC8D2CDA0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SkeletonUIOptions : MonoBehaviour
    {
        // ── Methods ──
        public void AnimateHandWithController(){} // RVA: 0x7FFAC8D2D020
        public void AnimateHandWithoutController(){} // RVA: 0x7FFAC8D2D190
        public void ShowController(){} // RVA: 0x7FFAC8D2D300
        public void SetRenderModel(){} // RVA: 0x7FFAC8D2D450
        public void HideController(){} // RVA: 0x7FFAC8D2D5E0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SquishyToy : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.Interactable interactable; // 0x20
        public UnityEngine.SkinnedMeshRenderer renderer; // 0x28
        public bool affectMaterial; // 0x30
        public Valve.VR.SteamVR_Action_Single gripSqueeze; // 0x38
        public Valve.VR.SteamVR_Action_Single pinchSqueeze; // 0x40
        public UnityEngine.Rigidbody rigidbody; // 0x48

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D2E9E0
        public void Update(){} // RVA: 0x7FFAC8D2ED30
        public void .ctor(){} // RVA: 0x7FFAC8D2F360
    }

    public class TargetHitEffect : MonoBehaviour
    {
        public UnityEngine.Collider targetCollider; // 0x20
        public UnityEngine.GameObject spawnObjectOnCollision; // 0x28
        public bool colorSpawnedObject; // 0x30
        public bool destroyOnTargetCollision; // 0x31

        // ── Methods ──
        public void OnCollisionEnter(){} // RVA: 0x7FFAC8D2D730
        public void .ctor(){} // RVA: 0x7FFAC8D2E100
    }

    public class TargetMeasurement : MonoBehaviour
    {
        public UnityEngine.GameObject visualWrapper; // 0x20
        public UnityEngine.Transform measurementTape; // 0x28
        public UnityEngine.Transform endPoint; // 0x30
        public UnityEngine.UI.Text measurementTextM; // 0x38
        public UnityEngine.UI.Text measurementTextFT; // 0x40
        public float maxDistanceToDraw; // 0x48
        public bool drawTape; // 0x4C
        public float lastDistance; // 0x50

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFAC8D2E150
        public void .ctor(){} // RVA: 0x7FFAC8D2E990
    }

    public class WheelDust : MonoBehaviour
    {
        public UnityEngine.WheelCollider col; // 0x20
        public UnityEngine.ParticleSystem p; // 0x28
        public float EmissionMul; // 0x30
        public float velocityMul; // 0x34
        public float maxEmission; // 0x38
        public float minSlip; // 0x3C
        public float amt; // 0x40
        public UnityEngine.Vector3 slip; // 0x44
        public float emitTimer; // 0x50

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8D20D20
        public void Update(){} // RVA: 0x7FFAC8D20E60
        public void emitter(){} // RVA: 0x7FFAC8D210E0
        public void DoEmit(){} // RVA: 0x7FFAC8D21180
        public void .ctor(){} // RVA: 0x7FFAC8D21500
    }

    public class trackCam : MonoBehaviour
    {
        public float speed; // 0x20
        public bool negative; // 0x24

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFAC8D201C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class trackObj : MonoBehaviour
    {
        public UnityEngine.Transform target; // 0x20
        public float speed; // 0x28
        public bool negative; // 0x2C

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFAC8D207D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

}