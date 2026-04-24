// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Vehicles.Car
// Classes: 10
// Methods: 68

namespace ThirdParty.Other.UnityStandardAssets.Vehicles.Car
{
    public class BrakeLight : MonoBehaviour
    {
        public Model_ControllerMode_State_t.? car; // 0x20
        public rical m_Renderer; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E360310
        public void Update(){} // RVA: 0x7FFD4E3603A0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class CarAIControl : MonoBehaviour
    {
        public float m_CautiousSpeedFactor; // 0x20
        public float m_CautiousMaxAngle; // 0x24
        public float m_CautiousMaxDistance; // 0x28
        public float m_CautiousAngularVelocityFactor; // 0x2C
        public float m_SteerSensitivity; // 0x30
        public float m_AccelSensitivity; // 0x34
        public float m_BrakeSensitivity; // 0x38
        public float m_LateralWanderDistance; // 0x3C
        public float m_LateralWanderSpeed; // 0x40
        public float m_AccelWanderAmount; // 0x44
        public float m_AccelWanderSpeed; // 0x48
        public enderModelComponentName4 m_BrakeCondition; // 0x4C
        public bool m_Driving; // 0x50
        public object m_Target; // 0x58
        public bool m_StopWhenTargetReached; // 0x60
        public float m_ReachTargetThreshold; // 0x64
        public float m_RandomPerlin; // 0x68
        public Model_ControllerMode_State_t.? m_CarController; // 0x70
        public float m_AvoidOtherCarTime; // 0x78
        public float m_AvoidOtherCarSlowdown; // 0x7C
        public float m_AvoidPathOffset; // 0x80
        public Touched m_Rigidbody; // 0x88

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E360420
        public void FixedUpdate(){} // RVA: 0x7FFD4E360590
        public void OnCollisionStay(){} // RVA: 0x7FFD4E360F70
        public void SetTarget(){} // RVA: 0x7FFD4E361550
        public void .ctor(){} // RVA: 0x7FFD4E3615B0
    }

    public class CarAudio : MonoBehaviour
    {
        public delComponentName16 engineSoundStyle; // 0x20
        public ies lowAccelClip; // 0x28
        public ies lowDecelClip; // 0x30
        public ies highAccelClip; // 0x38
        public ies highDecelClip; // 0x40
        public float pitchMultiplier; // 0x48
        public float lowPitchMin; // 0x4C
        public float lowPitchMax; // 0x50
        public float highPitchMultiplier; // 0x54
        public float maxRolloffDistance; // 0x58
        public float dopplerLevel; // 0x5C
        public bool useDoppler; // 0x60
        public t m_LowAccel; // 0x68
        public t m_LowDecel; // 0x70
        public t m_HighAccel; // 0x78
        public t m_HighDecel; // 0x80
        public bool m_StartedSound; // 0x88
        public Model_ControllerMode_State_t.? m_CarController; // 0x90

        // ── Methods ──
        public void StartSound(){} // RVA: 0x7FFD4E361650
        public void StopSound(){} // RVA: 0x7FFD4E361890
        public void Update(){} // RVA: 0x7FFD4E3619E0
        public void SetUpEngineAudioSource(){} // RVA: 0x7FFD4E362080
        public void ULerp(){} // RVA: 0x7FFD4E362420
        public void .ctor(){} // RVA: 0x7FFD4E362440
    }

    public class CarController : MonoBehaviour
    {
        public Model_ControllerMode_State_t.elComponentName17 Skidding; // 0x20
        public cessorType[] BrakeInput; // 0x28
        public BuffersImpl[] CurrentSteerAngle; // 0x30
        public Model_ControllerMode_State_t.tName58[] CurrentSpeed; // 0x38
        public amut MaxSpeed; // 0x40
        public float Revs; // 0x4C
        public float AccelInput; // 0x50
        public float m_TractionControl; // 0x54
        public float m_FullTorqueOverAllWheels; // 0x58
        public float m_ReverseTorque; // 0x5C
        public float m_MaxHandbrakeTorque; // 0x60
        public float m_Downforce; // 0x64
        public Model_ControllerMode_State_t.delComponentName19 m_SpeedType; // 0x68
        public float m_Topspeed; // 0x6C
        public int NoOfGears;
        public float m_RevRangeBoundary; // 0x70
        public float m_SlipLimit; // 0x74
        public float m_BrakeTorque; // 0x78
        public R_12x12[] m_WheelMeshLocalRotations; // 0x80
        public amut m_Prevpos; // 0x88
        public amut m_Pos; // 0x94
        public float m_SteerAngle; // 0xA0
        public int m_GearNum; // 0xA4
        public float m_GearFactor; // 0xA8
        public float m_OldRotation; // 0xAC
        public float m_CurrentTorque; // 0xB0
        public Touched m_Rigidbody; // 0xB8
        public float k_ReversingThreshold;
        public bool <Skidding>k__BackingField; // 0xC0
        public float <BrakeInput>k__BackingField; // 0xC4
        public float <Revs>k__BackingField; // 0xC8
        public float <AccelInput>k__BackingField; // 0xCC

        // ── Methods ──
        public void get_Skidding(){} // RVA: 0x7FFD4E3624C0
        public void set_Skidding(){} // RVA: 0x7FFD4E3624D0
        public void get_BrakeInput(){} // RVA: 0x7FFD4E3624E0
        public void set_BrakeInput(){} // RVA: 0x7FFD4E3624F0
        public void get_CurrentSteerAngle(){} // RVA: 0x7FFD4E362500
        public void get_CurrentSpeed(){} // RVA: 0x7FFD4E362510
        public void get_MaxSpeed(){} // RVA: 0x7FFD4E362680
        public void get_Revs(){} // RVA: 0x7FFD4E362690
        public void set_Revs(){} // RVA: 0x7FFD4E3626A0
        public void get_AccelInput(){} // RVA: 0x7FFD4E3626B0
        public void set_AccelInput(){} // RVA: 0x7FFD4E3626C0
        public void Start(){} // RVA: 0x7FFD4E3626D0
        public void GearChanging(){} // RVA: 0x7FFD4E362A00
        public void CurveFactor(){} // RVA: 0x7FFD4E362B20
        public void ULerp(){} // RVA: 0x7FFD4E362420
        public void CalculateGearFactor(){} // RVA: 0x7FFD4E362B40
        public void CalculateRevs(){} // RVA: 0x7FFD4E362CD0
        public void Move(){} // RVA: 0x7FFD4E362DC0
        public void CapSpeed(){} // RVA: 0x7FFD4E363500
        public void ApplyDrive(){} // RVA: 0x7FFD4E3638A0
        public void SteerHelper(){} // RVA: 0x7FFD4E363C20
        public void AddDownForce(){} // RVA: 0x7FFD4E364230
        public void CheckForWheelSpin(){} // RVA: 0x7FFD4E3644E0
        public void TractionControl(){} // RVA: 0x7FFD4E3646C0
        public void AdjustTorque(){} // RVA: 0x7FFD4E364A10
        public void AnySkidSoundPlaying(){} // RVA: 0x7FFD4E364A80
        public void .ctor(){} // RVA: 0x7FFD4E364AD0
        public void .cctor(){} // RVA: 0x7FFD4E364CB0
    }

    public class CarSelfRighting : MonoBehaviour
    {
        public float m_WaitTime; // 0x20
        public float m_VelocityThreshold; // 0x24
        public float m_LastOkTime; // 0x28
        public Touched m_Rigidbody; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E3660F0
        public void Update(){} // RVA: 0x7FFD4E366180
        public void RightCar(){} // RVA: 0x7FFD4E366330
        public void .ctor(){} // RVA: 0x7FFD4E366680
    }

    public class CarUserControl : MonoBehaviour
    {
        public Model_ControllerMode_State_t.? m_Car; // 0x20

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E3666E0
        public void FixedUpdate(){} // RVA: 0x7FFD4E366770
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Mudguard : MonoBehaviour
    {
        public Model_ControllerMode_State_t.? carController; // 0x20
        public R_12x12 m_OriginalRotation; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E366920
        public void Update(){} // RVA: 0x7FFD4E3669E0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SkidTrail : MonoBehaviour
    {
        public float m_PersistTime; // 0x20

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E366CA0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Suspension : MonoBehaviour
    {
        public BuffersImpl wheel; // 0x20
        public amut m_TargetOriginalPosition; // 0x28
        public amut m_Origin; // 0x34

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E367020
        public void Update(){} // RVA: 0x7FFD4E3671B0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class WheelEffects : MonoBehaviour
    {
        public object skidding; // 0x20
        public object PlayingAudio;
        public InDuration skidParticles; // 0x28
        public bool <skidding>k__BackingField; // 0x30
        public bool <PlayingAudio>k__BackingField; // 0x31
        public t m_AudioSource; // 0x38
        public object m_SkidTrail; // 0x40
        public cessorType m_WheelCollider; // 0x48
        public object Instantiate; // 0x8

        // ── Methods ──
        public void get_skidding(){} // RVA: 0x7FFD4E367450
        public void set_skidding(){} // RVA: 0x7FFD4E367460
        public void get_PlayingAudio(){} // RVA: 0x7FFD4E367470
        public void set_PlayingAudio(){} // RVA: 0x7FFD4E367480
        public void Start(){} // RVA: 0x7FFD4E367490
        public void EmitTyreSmoke(){} // RVA: 0x7FFD4E367B00
        public void PlayAudio(){} // RVA: 0x7FFD4E367F00
        public void StopAudio(){} // RVA: 0x7FFD4E368140
        public void StartSkidTrail(){} // RVA: 0x7FFD4E368380
        public void EndSkidTrail(){} // RVA: 0x7FFD4E368420
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}