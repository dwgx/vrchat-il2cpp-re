// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Vehicles.Aeroplane
// Classes: 9
// Methods: 68

namespace ThirdParty.Other.UnityStandardAssets.Vehicles.Aeroplane
{
    public class AeroplaneAiControl : MonoBehaviour
    {
        public object m_RollSensitivity;
        public object m_PitchSensitivity;
        public object m_LateralWanderDistance;
        public object m_LateralWanderSpeed;
        public object m_MaxClimbAngle;
        public object m_MaxRollAngle;
        public object m_SpeedEffect;
        public object m_TakeoffHeight;
        public object m_Target;
        public object m_AeroplaneController;
        public object m_RandomPerlin;
        public object m_TakenOff;

        // ── Methods ──
        public void Awake(){} // RVA: 0xB6A310
        public void Reset(){} // RVA: 0xB6A3F0
        public void FixedUpdate(){} // RVA: 0xB6A400
        public void SetTarget(){} // RVA: 0xB6A8C0
        public void .ctor(){} // RVA: 0xB6A920
    }

    public class AeroplaneAudio : MonoBehaviour
    {
        public object m_EngineSound;
        public object m_EngineMinThrottlePitch;
        public object m_EngineMaxThrottlePitch;
        public object m_EngineFwdSpeedMultiplier;
        public object m_WindSound;
        public object m_WindBasePitch;
        public object m_WindSpeedPitchFactor;
        public object m_WindMaxSpeedVolume;
        public object m_AdvancedSetttings;
        public object m_EngineSoundSource;
        public object m_WindSoundSource;
        public object m_Plane;
        public object m_Rigidbody;

        // ── Methods ──
        public void Awake(){} // RVA: 0xB6A9A0
        public void Update(){} // RVA: 0xB6AD50
        public void .ctor(){} // RVA: 0xB6AFF0
    }

    public class AeroplaneControlSurfaceAnimator : MonoBehaviour
    {
        public object m_Smoothing;
        public object m_ControlSurfaces;
        public object m_Plane;

        // ── Methods ──
        public void Start(){} // RVA: 0xB6D5C0
        public void Update(){} // RVA: 0xB6D760
        public void RotateSurface(){} // RVA: 0xB6D900
        public void .ctor(){} // RVA: 0xB6DC70
    }

    public class AeroplaneController : MonoBehaviour
    {
        public object m_MaxEnginePower;
        public object m_Lift;
        public object m_ZeroLiftSpeed;
        public object m_RollEffect;
        public object m_PitchEffect;
        public object m_YawEffect;
        public object m_BankedTurnEffect;
        public object m_AerodynamicEffect;
        public object m_AutoTurnPitch;
        public object m_AutoRollLevel;
        public object m_AutoPitchLevel;
        public object m_AirBrakesEffect;
        public object m_ThrottleChangeSpeed;
        public object m_DragIncreaseFactor;
        public object _altitude;
        public object _throttle;
        public object _airBrakes;
        public object _forwardSpeed;
        public object _enginePower;
        public object _rollAngle;
        public object _pitchAngle;
        public object _rollInput;
        public object _pitchInput;
        public object _yawInput;
        public object _throttleInput;
        public object m_OriginalDrag;
        public object m_OriginalAngularDrag;
        public object m_AeroFactor;
        public object m_Immobilized;
        public object m_BankedTurnAmount;
        public object m_Rigidbody;
        public object m_WheelColliders;

        // ── Methods ──
        public void get_Altitude(){} // RVA: 0xB6B160
        public void set_Altitude(){} // RVA: 0xB6B170
        public void get_Throttle(){} // RVA: 0xB6B180
        public void set_Throttle(){} // RVA: 0xB6B190
        public void get_AirBrakes(){} // RVA: 0xB6B1A0
        public void set_AirBrakes(){} // RVA: 0xB6B1B0
        public void get_ForwardSpeed(){} // RVA: 0xB6B1C0
        public void set_ForwardSpeed(){} // RVA: 0xB6B1D0
        public void get_EnginePower(){} // RVA: 0xB6B1E0
        public void set_EnginePower(){} // RVA: 0xB6B1F0
        public void get_MaxEnginePower(){} // RVA: 0xB6B200
        public void get_RollAngle(){} // RVA: 0xB63B70
        public void set_RollAngle(){} // RVA: 0xB6B210
        public void get_PitchAngle(){} // RVA: 0xB6B220
        public void set_PitchAngle(){} // RVA: 0xB6B230
        public void get_RollInput(){} // RVA: 0xB6B240
        public void set_RollInput(){} // RVA: 0xB6B250
        public void get_PitchInput(){} // RVA: 0xB6B260
        public void set_PitchInput(){} // RVA: 0xB6B270
        public void get_YawInput(){} // RVA: 0xB6B280
        public void set_YawInput(){} // RVA: 0xB6B290
        public void get_ThrottleInput(){} // RVA: 0xB6B2A0
        public void set_ThrottleInput(){} // RVA: 0xB6B2B0
        public void Start(){} // RVA: 0xB6B2C0
        public void Move(){} // RVA: 0xB6B610
        public void ClampInputs(){} // RVA: 0xB6BAA0
        public void CalculateRollAndPitchAngles(){} // RVA: 0xB6BB40
        public void AutoLevel(){} // RVA: 0xB6BE80
        public void CalculateForwardSpeed(){} // RVA: 0xB6BF00
        public void ControlThrottle(){} // RVA: 0xB6C090
        public void CalculateDrag(){} // RVA: 0xB6C150
        public void CaluclateAerodynamicEffect(){} // RVA: 0xB6C290
        public void CalculateLinearForces(){} // RVA: 0xB6C950
        public void CalculateTorque(){} // RVA: 0xB6CD40
        public void CalculateAltitude(){} // RVA: 0xB6D080
        public void Immobilize(){} // RVA: 0xB6D4F0
        public void Reset(){} // RVA: 0xB6D500
        public void .ctor(){} // RVA: 0xB6D510
    }

    public class AeroplanePropellerAnimator : MonoBehaviour
    {
        public object m_PropellorModel;
        public object m_PropellorBlur;
        public object m_PropellorBlurTextures;
        public object m_ThrottleBlurStart;
        public object m_ThrottleBlurEnd;
        public object m_MaxRpm;
        public object m_Plane;
        public object m_PropellorBlurState;
        public object k_RpmToDps;
        public object m_PropellorModelRenderer;
        public object m_PropellorBlurRenderer;

        // ── Methods ──
        public void Awake(){} // RVA: 0xB6DCC0
        public void Update(){} // RVA: 0xB6DE60
        public void .ctor(){} // RVA: 0xB6E040
    }

    public class AeroplaneUserControl2Axis : MonoBehaviour
    {
        public object maxRollAngle;
        public object maxPitchAngle;
        public object m_Aeroplane;

        // ── Methods ──
        public void Awake(){} // RVA: 0xB6E0A0
        public void FixedUpdate(){} // RVA: 0xB6E130
        public void AdjustInputForMobileControls(){} // RVA: 0xB6E2C0
        public void .ctor(){} // RVA: 0xB6E3A0
    }

    public class AeroplaneUserControl4Axis : MonoBehaviour
    {
        public object maxRollAngle;
        public object maxPitchAngle;
        public object m_Aeroplane;
        public object m_Throttle;
        public object m_AirBrakes;
        public object m_Yaw;

        // ── Methods ──
        public void Awake(){} // RVA: 0xB6E400
        public void FixedUpdate(){} // RVA: 0xB6E490
        public void AdjustInputForMobileControls(){} // RVA: 0xB6E6D0
        public void .ctor(){} // RVA: 0xB6E3A0
    }

    public class JetParticleEffect : MonoBehaviour
    {
        public object minColour;
        public object m_Jet;
        public object m_System;
        public object m_OriginalStartSize;
        public object m_OriginalLifetime;
        public object m_OriginalStartColor;

        // ── Methods ──
        public void Start(){} // RVA: 0xB6E770
        public void Update(){} // RVA: 0xB6EB00
        public void FindAeroplaneParent(){} // RVA: 0xB6EDA0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class LandingGear : MonoBehaviour
    {
        public object raiseAtAltitude;
        public object lowerAtAltitude;
        public object m_State;
        public object m_Animator;
        public object m_Rigidbody;
        public object m_Plane;

        // ── Methods ──
        public void Start(){} // RVA: 0xB6EF90
        public void Update(){} // RVA: 0xB6F120
        public void .ctor(){} // RVA: 0xB6F280
    }

}