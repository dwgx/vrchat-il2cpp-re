// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Vehicles.Aeroplane
// Classes: 9
// Methods: 68

namespace ThirdParty.Other.UnityStandardAssets.Vehicles.Aeroplane
{
    public class AeroplaneAiControl
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x304C50
        public void Reset(){} // RVA: 0x304D30
        public void FixedUpdate(){} // RVA: 0x304D40
        public void SetTarget(){} // RVA: 0x305200
        public void .ctor(){} // RVA: 0x305260
    }

    public class AeroplaneAudio
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x3052E0
        public void Update(){} // RVA: 0x305A80
        public void .ctor(){} // RVA: 0x305E70
    }

    public class AeroplaneControlSurfaceAnimator
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x3084F0
        public void Update(){} // RVA: 0x308650
        public void RotateSurface(){} // RVA: 0x3087D0
        public void .ctor(){} // RVA: 0x308AC0
    }

    public class AeroplaneController
    {
        public float m_MaxEnginePower; // 0x20
        public float m_Lift; // 0x24
        public float m_ZeroLiftSpeed; // 0x28
        public float m_RollEffect; // 0x2C
        public float m_PitchEffect; // 0x30
        public float m_YawEffect; // 0x34
        public float m_BankedTurnEffect; // 0x38
        public float m_AerodynamicEffect; // 0x3C
        public float m_AutoTurnPitch; // 0x40
        public float m_AutoRollLevel; // 0x44
        public float m_AutoPitchLevel; // 0x48
        public float m_AirBrakesEffect; // 0x4C

        // ── Methods ──
        public void get_Altitude(){} // RVA: 0x305FE0
        public void set_Altitude(){} // RVA: 0x305FF0
        public void get_Throttle(){} // RVA: 0x306000
        public void set_Throttle(){} // RVA: 0x306010
        public void get_AirBrakes(){} // RVA: 0x306020
        public void set_AirBrakes(){} // RVA: 0x306030
        public void get_ForwardSpeed(){} // RVA: 0x306040
        public void set_ForwardSpeed(){} // RVA: 0x306050
        public void get_EnginePower(){} // RVA: 0x306060
        public void set_EnginePower(){} // RVA: 0x306070
        public void get_MaxEnginePower(){} // RVA: 0x306080
        public void get_RollAngle(){} // RVA: 0x2FE680
        public void set_RollAngle(){} // RVA: 0x306090
        public void get_PitchAngle(){} // RVA: 0x3060A0
        public void set_PitchAngle(){} // RVA: 0x3060B0
        public void get_RollInput(){} // RVA: 0x3060C0
        public void set_RollInput(){} // RVA: 0x3060D0
        public void get_PitchInput(){} // RVA: 0x3060E0
        public void set_PitchInput(){} // RVA: 0x3060F0
        public void get_YawInput(){} // RVA: 0x306100
        public void set_YawInput(){} // RVA: 0x306110
        public void get_ThrottleInput(){} // RVA: 0x306120
        public void set_ThrottleInput(){} // RVA: 0x306130
        public void Start(){} // RVA: 0x306140
        public void Move(){} // RVA: 0x3064A0
        public void ClampInputs(){} // RVA: 0x306930
        public void CalculateRollAndPitchAngles(){} // RVA: 0x3069D0
        public void AutoLevel(){} // RVA: 0x306D90
        public void CalculateForwardSpeed(){} // RVA: 0x306E10
        public void ControlThrottle(){} // RVA: 0x306F60
        public void CalculateDrag(){} // RVA: 0x307020
        public void CaluclateAerodynamicEffect(){} // RVA: 0x3071A0
        public void CalculateLinearForces(){} // RVA: 0x307820
        public void CalculateTorque(){} // RVA: 0x307BF0
        public void CalculateAltitude(){} // RVA: 0x307FC0
        public void Immobilize(){} // RVA: 0x308420
        public void Reset(){} // RVA: 0x308430
        public void .ctor(){} // RVA: 0x308440
    }

    public class AeroplanePropellerAnimator
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x308B10
        public void Update(){} // RVA: 0x308CB0
        public void .ctor(){} // RVA: 0x308EF0
    }

    public class AeroplaneUserControl2Axis
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x308F50
        public void FixedUpdate(){} // RVA: 0x308FE0
        public void AdjustInputForMobileControls(){} // RVA: 0x309170
        public void .ctor(){} // RVA: 0x309250
    }

    public class AeroplaneUserControl4Axis
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x3092B0
        public void FixedUpdate(){} // RVA: 0x309340
        public void AdjustInputForMobileControls(){} // RVA: 0x309580
        public void .ctor(){} // RVA: 0x309250
    }

    public class JetParticleEffect
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x309620
        public void Update(){} // RVA: 0x309990
        public void FindAeroplaneParent(){} // RVA: 0x309CE0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class LandingGear
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x309F10
        public void Update(){} // RVA: 0x30A0A0
        public void .ctor(){} // RVA: 0x30A1B0
    }

}