// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Vehicles.Aeroplane
// Classes: 9
// Methods: 68

namespace ThirdParty.Other.UnityStandardAssets.Vehicles.Aeroplane
{
    public class AeroplaneAiControl : MonoBehaviour
    {
        public float m_RollSensitivity; // 0x20
        public float m_PitchSensitivity; // 0x24
        public float m_LateralWanderDistance; // 0x28
        public float m_LateralWanderSpeed; // 0x2C
        public float m_MaxClimbAngle; // 0x30
        public float m_MaxRollAngle; // 0x34
        public float m_SpeedEffect; // 0x38
        public float m_TakeoffHeight; // 0x3C
        public UnityEngine.Transform m_Target; // 0x40
        public UnityStandardAssets.Vehicles.Aeroplane.AeroplaneController m_AeroplaneController; // 0x48
        public float m_RandomPerlin; // 0x50
        public bool m_TakenOff; // 0x54

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC2F48C50
        public void Reset(){} // RVA: 0x7FFAC2F48D30
        public void FixedUpdate(){} // RVA: 0x7FFAC2F48D40
        public void SetTarget(){} // RVA: 0x7FFAC2F49200
        public void .ctor(){} // RVA: 0x7FFAC2F49260
    }

    public class AeroplaneAudio : MonoBehaviour
    {
        public UnityEngine.AudioClip m_EngineSound; // 0x20
        public float m_EngineMinThrottlePitch; // 0x28
        public float m_EngineMaxThrottlePitch; // 0x2C
        public float m_EngineFwdSpeedMultiplier; // 0x30
        public UnityEngine.AudioClip m_WindSound; // 0x38
        public float m_WindBasePitch; // 0x40
        public float m_WindSpeedPitchFactor; // 0x44
        public float m_WindMaxSpeedVolume; // 0x48
        public AdvancedSetttings m_AdvancedSetttings; // 0x50
        public UnityEngine.AudioSource m_EngineSoundSource; // 0x58
        public UnityEngine.AudioSource m_WindSoundSource; // 0x60
        public UnityStandardAssets.Vehicles.Aeroplane.AeroplaneController m_Plane; // 0x68
        public UnityEngine.Rigidbody m_Rigidbody; // 0x70

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC2F492E0
        public void Update(){} // RVA: 0x7FFAC2F49A80
        public void .ctor(){} // RVA: 0x7FFAC2F49E70
    }

    public class AeroplaneControlSurfaceAnimator : MonoBehaviour
    {
        public float m_Smoothing; // 0x20
        public ControlSurface[] m_ControlSurfaces; // 0x28
        public UnityStandardAssets.Vehicles.Aeroplane.AeroplaneController m_Plane; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F4C4F0
        public void Update(){} // RVA: 0x7FFAC2F4C650
        public void RotateSurface(){} // RVA: 0x7FFAC2F4C7D0
        public void .ctor(){} // RVA: 0x7FFAC2F4CAC0
    }

    public class AeroplaneController : MonoBehaviour
    {
        public float Altitude; // 0x20
        public float Throttle; // 0x24
        public float AirBrakes; // 0x28
        public float ForwardSpeed; // 0x2C
        public float EnginePower; // 0x30
        public float MaxEnginePower; // 0x34
        public float RollAngle; // 0x38
        public float PitchAngle; // 0x3C
        public float RollInput; // 0x40
        public float PitchInput; // 0x44
        public float YawInput; // 0x48
        public float ThrottleInput; // 0x4C
        public float m_ThrottleChangeSpeed; // 0x50
        public float m_DragIncreaseFactor; // 0x54
        public float <Altitude>k__BackingField; // 0x58
        public float <Throttle>k__BackingField; // 0x5C
        public bool <AirBrakes>k__BackingField; // 0x60
        public float <ForwardSpeed>k__BackingField; // 0x64
        public float <EnginePower>k__BackingField; // 0x68
        public float <RollAngle>k__BackingField; // 0x6C
        public float <PitchAngle>k__BackingField; // 0x70
        public float <RollInput>k__BackingField; // 0x74
        public float <PitchInput>k__BackingField; // 0x78
        public float <YawInput>k__BackingField; // 0x7C
        public float <ThrottleInput>k__BackingField; // 0x80
        public float m_OriginalDrag; // 0x84
        public float m_OriginalAngularDrag; // 0x88
        public float m_AeroFactor; // 0x8C
        public bool m_Immobilized; // 0x90
        public float m_BankedTurnAmount; // 0x94
        public UnityEngine.Rigidbody m_Rigidbody; // 0x98
        public UnityEngine.WheelCollider[] m_WheelColliders; // 0xA0

        // ── Methods ──
        public void get_Altitude(){} // RVA: 0x7FFAC2F49FE0
        public void set_Altitude(){} // RVA: 0x7FFAC2F49FF0
        public void get_Throttle(){} // RVA: 0x7FFAC2F4A000
        public void set_Throttle(){} // RVA: 0x7FFAC2F4A010
        public void get_AirBrakes(){} // RVA: 0x7FFAC2F4A020
        public void set_AirBrakes(){} // RVA: 0x7FFAC2F4A030
        public void get_ForwardSpeed(){} // RVA: 0x7FFAC2F4A040
        public void set_ForwardSpeed(){} // RVA: 0x7FFAC2F4A050
        public void get_EnginePower(){} // RVA: 0x7FFAC2F4A060
        public void set_EnginePower(){} // RVA: 0x7FFAC2F4A070
        public void get_MaxEnginePower(){} // RVA: 0x7FFAC2F4A080
        public void get_RollAngle(){} // RVA: 0x7FFAC2F42680
        public void set_RollAngle(){} // RVA: 0x7FFAC2F4A090
        public void get_PitchAngle(){} // RVA: 0x7FFAC2F4A0A0
        public void set_PitchAngle(){} // RVA: 0x7FFAC2F4A0B0
        public void get_RollInput(){} // RVA: 0x7FFAC2F4A0C0
        public void set_RollInput(){} // RVA: 0x7FFAC2F4A0D0
        public void get_PitchInput(){} // RVA: 0x7FFAC2F4A0E0
        public void set_PitchInput(){} // RVA: 0x7FFAC2F4A0F0
        public void get_YawInput(){} // RVA: 0x7FFAC2F4A100
        public void set_YawInput(){} // RVA: 0x7FFAC2F4A110
        public void get_ThrottleInput(){} // RVA: 0x7FFAC2F4A120
        public void set_ThrottleInput(){} // RVA: 0x7FFAC2F4A130
        public void Start(){} // RVA: 0x7FFAC2F4A140
        public void Move(){} // RVA: 0x7FFAC2F4A4A0
        public void ClampInputs(){} // RVA: 0x7FFAC2F4A930
        public void CalculateRollAndPitchAngles(){} // RVA: 0x7FFAC2F4A9D0
        public void AutoLevel(){} // RVA: 0x7FFAC2F4AD90
        public void CalculateForwardSpeed(){} // RVA: 0x7FFAC2F4AE10
        public void ControlThrottle(){} // RVA: 0x7FFAC2F4AF60
        public void CalculateDrag(){} // RVA: 0x7FFAC2F4B020
        public void CaluclateAerodynamicEffect(){} // RVA: 0x7FFAC2F4B1A0
        public void CalculateLinearForces(){} // RVA: 0x7FFAC2F4B820
        public void CalculateTorque(){} // RVA: 0x7FFAC2F4BBF0
        public void CalculateAltitude(){} // RVA: 0x7FFAC2F4BFC0
        public void Immobilize(){} // RVA: 0x7FFAC2F4C420
        public void Reset(){} // RVA: 0x7FFAC2F4C430
        public void .ctor(){} // RVA: 0x7FFAC2F4C440
    }

    public class AeroplanePropellerAnimator : MonoBehaviour
    {
        public UnityEngine.Transform m_PropellorModel; // 0x20
        public UnityEngine.Transform m_PropellorBlur; // 0x28
        public UnityEngine.Texture2D[] m_PropellorBlurTextures; // 0x30
        public float m_ThrottleBlurStart; // 0x38
        public float m_ThrottleBlurEnd; // 0x3C
        public float m_MaxRpm; // 0x40
        public UnityStandardAssets.Vehicles.Aeroplane.AeroplaneController m_Plane; // 0x48
        public int m_PropellorBlurState; // 0x50
        public float k_RpmToDps;
        public UnityEngine.Renderer m_PropellorModelRenderer; // 0x58
        public UnityEngine.Renderer m_PropellorBlurRenderer; // 0x60

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC2F4CB10
        public void Update(){} // RVA: 0x7FFAC2F4CCB0
        public void .ctor(){} // RVA: 0x7FFAC2F4CEF0
    }

    public class AeroplaneUserControl2Axis : MonoBehaviour
    {
        public float maxRollAngle; // 0x20
        public float maxPitchAngle; // 0x24
        public UnityStandardAssets.Vehicles.Aeroplane.AeroplaneController m_Aeroplane; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC2F4CF50
        public void FixedUpdate(){} // RVA: 0x7FFAC2F4CFE0
        public void AdjustInputForMobileControls(){} // RVA: 0x7FFAC2F4D170
        public void .ctor(){} // RVA: 0x7FFAC2F4D250
    }

    public class AeroplaneUserControl4Axis : MonoBehaviour
    {
        public float maxRollAngle; // 0x20
        public float maxPitchAngle; // 0x24
        public UnityStandardAssets.Vehicles.Aeroplane.AeroplaneController m_Aeroplane; // 0x28
        public float m_Throttle; // 0x30
        public bool m_AirBrakes; // 0x34
        public float m_Yaw; // 0x38

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC2F4D2B0
        public void FixedUpdate(){} // RVA: 0x7FFAC2F4D340
        public void AdjustInputForMobileControls(){} // RVA: 0x7FFAC2F4D580
        public void .ctor(){} // RVA: 0x7FFAC2F4D250
    }

    public class JetParticleEffect : MonoBehaviour
    {
        public UnityEngine.Color minColour; // 0x20
        public UnityStandardAssets.Vehicles.Aeroplane.AeroplaneController m_Jet; // 0x30
        public UnityEngine.ParticleSystem m_System; // 0x38
        public float m_OriginalStartSize; // 0x40
        public float m_OriginalLifetime; // 0x44
        public UnityEngine.Color m_OriginalStartColor; // 0x48

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F4D620
        public void Update(){} // RVA: 0x7FFAC2F4D990
        public void FindAeroplaneParent(){} // RVA: 0x7FFAC2F4DCE0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class LandingGear : MonoBehaviour
    {
        public float raiseAtAltitude; // 0x20
        public float lowerAtAltitude; // 0x24
        public 0x6B1BBCB8 m_State; // 0x28
        public UnityEngine.Animator m_Animator; // 0x30
        public UnityEngine.Rigidbody m_Rigidbody; // 0x38
        public UnityStandardAssets.Vehicles.Aeroplane.AeroplaneController m_Plane; // 0x40

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F4DF10
        public void Update(){} // RVA: 0x7FFAC2F4E0A0
        public void .ctor(){} // RVA: 0x7FFAC2F4E1B0
    }

}