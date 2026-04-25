// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Vehicles.Car
// Classes: 10
// Methods: 68

namespace ThirdParty.Other.UnityStandardAssets.Vehicles.Car
{
    public class BrakeLight : MonoBehaviour
    {
        public UnityStandardAssets.Vehicles.Car.CarController car; // 0x20
        public UnityEngine.Renderer m_Renderer; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F40310
        public void Update(){} // RVA: 0x7FFAC2F403A0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
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
        public 0x6B1BB370 m_BrakeCondition; // 0x4C
        public bool m_Driving; // 0x50
        public UnityEngine.Transform m_Target; // 0x58
        public bool m_StopWhenTargetReached; // 0x60
        public float m_ReachTargetThreshold; // 0x64
        public float m_RandomPerlin; // 0x68
        public UnityStandardAssets.Vehicles.Car.CarController m_CarController; // 0x70
        public float m_AvoidOtherCarTime; // 0x78
        public float m_AvoidOtherCarSlowdown; // 0x7C
        public float m_AvoidPathOffset; // 0x80
        public UnityEngine.Rigidbody m_Rigidbody; // 0x88

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC2F40420
        public void FixedUpdate(){} // RVA: 0x7FFAC2F40590
        public void OnCollisionStay(){} // RVA: 0x7FFAC2F40F70
        public void SetTarget(){} // RVA: 0x7FFAC2F41550
        public void .ctor(){} // RVA: 0x7FFAC2F415B0
    }

    public class CarAudio : MonoBehaviour
    {
        public 0x6B1BB420 engineSoundStyle; // 0x20
        public UnityEngine.AudioClip lowAccelClip; // 0x28
        public UnityEngine.AudioClip lowDecelClip; // 0x30
        public UnityEngine.AudioClip highAccelClip; // 0x38
        public UnityEngine.AudioClip highDecelClip; // 0x40
        public float pitchMultiplier; // 0x48
        public float lowPitchMin; // 0x4C
        public float lowPitchMax; // 0x50
        public float highPitchMultiplier; // 0x54
        public float maxRolloffDistance; // 0x58
        public float dopplerLevel; // 0x5C
        public bool useDoppler; // 0x60
        public UnityEngine.AudioSource m_LowAccel; // 0x68
        public UnityEngine.AudioSource m_LowDecel; // 0x70
        public UnityEngine.AudioSource m_HighAccel; // 0x78
        public UnityEngine.AudioSource m_HighDecel; // 0x80
        public bool m_StartedSound; // 0x88
        public UnityStandardAssets.Vehicles.Car.CarController m_CarController; // 0x90

        // ── Methods ──
        public void StartSound(){} // RVA: 0x7FFAC2F41650
        public void StopSound(){} // RVA: 0x7FFAC2F41890
        public void Update(){} // RVA: 0x7FFAC2F419E0
        public void SetUpEngineAudioSource(){} // RVA: 0x7FFAC2F42080
        public void ULerp(){} // RVA: 0x7FFAC2F42420
        public void .ctor(){} // RVA: 0x7FFAC2F42440
    }

    public class CarController : MonoBehaviour
    {
        public 0x6B1BB4D0 Skidding; // 0x20
        public UnityEngine.WheelCollider[] BrakeInput; // 0x28
        public UnityEngine.GameObject[] CurrentSteerAngle; // 0x30
        public UnityStandardAssets.Vehicles.Car.WheelEffects[] CurrentSpeed; // 0x38
        public UnityEngine.Vector3 MaxSpeed; // 0x40
        public float Revs; // 0x4C
        public float AccelInput; // 0x50
        public float m_TractionControl; // 0x54
        public float m_FullTorqueOverAllWheels; // 0x58
        public float m_ReverseTorque; // 0x5C
        public float m_MaxHandbrakeTorque; // 0x60
        public float m_Downforce; // 0x64
        public 0x6B1BB528 m_SpeedType; // 0x68
        public float m_Topspeed; // 0x6C
        public int NoOfGears;
        public float m_RevRangeBoundary; // 0x70
        public float m_SlipLimit; // 0x74
        public float m_BrakeTorque; // 0x78
        public UnityEngine.Quaternion[] m_WheelMeshLocalRotations; // 0x80
        public UnityEngine.Vector3 m_Prevpos; // 0x88
        public UnityEngine.Vector3 m_Pos; // 0x94
        public float m_SteerAngle; // 0xA0
        public int m_GearNum; // 0xA4
        public float m_GearFactor; // 0xA8
        public float m_OldRotation; // 0xAC
        public float m_CurrentTorque; // 0xB0
        public UnityEngine.Rigidbody m_Rigidbody; // 0xB8
        public float k_ReversingThreshold;
        public bool <Skidding>k__BackingField; // 0xC0
        public float <BrakeInput>k__BackingField; // 0xC4
        public float <Revs>k__BackingField; // 0xC8
        public float <AccelInput>k__BackingField; // 0xCC

        // ── Methods ──
        public void get_Skidding(){} // RVA: 0x7FFAC2F424C0
        public void set_Skidding(){} // RVA: 0x7FFAC2F424D0
        public void get_BrakeInput(){} // RVA: 0x7FFAC2F424E0
        public void set_BrakeInput(){} // RVA: 0x7FFAC2F424F0
        public void get_CurrentSteerAngle(){} // RVA: 0x7FFAC2F42500
        public void get_CurrentSpeed(){} // RVA: 0x7FFAC2F42510
        public void get_MaxSpeed(){} // RVA: 0x7FFAC2F42680
        public void get_Revs(){} // RVA: 0x7FFAC2F42690
        public void set_Revs(){} // RVA: 0x7FFAC2F426A0
        public void get_AccelInput(){} // RVA: 0x7FFAC2F426B0
        public void set_AccelInput(){} // RVA: 0x7FFAC2F426C0
        public void Start(){} // RVA: 0x7FFAC2F426D0
        public void GearChanging(){} // RVA: 0x7FFAC2F42A00
        public void CurveFactor(){} // RVA: 0x7FFAC2F42B20
        public void ULerp(){} // RVA: 0x7FFAC2F42420
        public void CalculateGearFactor(){} // RVA: 0x7FFAC2F42B40
        public void CalculateRevs(){} // RVA: 0x7FFAC2F42CD0
        public void Move(){} // RVA: 0x7FFAC2F42DC0
        public void CapSpeed(){} // RVA: 0x7FFAC2F43500
        public void ApplyDrive(){} // RVA: 0x7FFAC2F438A0
        public void SteerHelper(){} // RVA: 0x7FFAC2F43C20
        public void AddDownForce(){} // RVA: 0x7FFAC2F44230
        public void CheckForWheelSpin(){} // RVA: 0x7FFAC2F444E0
        public void TractionControl(){} // RVA: 0x7FFAC2F446C0
        public void AdjustTorque(){} // RVA: 0x7FFAC2F44A10
        public void AnySkidSoundPlaying(){} // RVA: 0x7FFAC2F44A80
        public void .ctor(){} // RVA: 0x7FFAC2F44AD0
        public void .cctor(){} // RVA: 0x7FFAC2F44CB0
    }

    public class CarSelfRighting : MonoBehaviour
    {
        public float m_WaitTime; // 0x20
        public float m_VelocityThreshold; // 0x24
        public float m_LastOkTime; // 0x28
        public UnityEngine.Rigidbody m_Rigidbody; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F460F0
        public void Update(){} // RVA: 0x7FFAC2F46180
        public void RightCar(){} // RVA: 0x7FFAC2F46330
        public void .ctor(){} // RVA: 0x7FFAC2F46680
    }

    public class CarUserControl : MonoBehaviour
    {
        public UnityStandardAssets.Vehicles.Car.CarController m_Car; // 0x20

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC2F466E0
        public void FixedUpdate(){} // RVA: 0x7FFAC2F46770
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Mudguard : MonoBehaviour
    {
        public UnityStandardAssets.Vehicles.Car.CarController carController; // 0x20
        public UnityEngine.Quaternion m_OriginalRotation; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F46920
        public void Update(){} // RVA: 0x7FFAC2F469E0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SkidTrail : MonoBehaviour
    {
        public float m_PersistTime; // 0x20

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F46CA0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class Suspension : MonoBehaviour
    {
        public UnityEngine.GameObject wheel; // 0x20
        public UnityEngine.Vector3 m_TargetOriginalPosition; // 0x28
        public UnityEngine.Vector3 m_Origin; // 0x34

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2F47020
        public void Update(){} // RVA: 0x7FFAC2F471B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class WheelEffects : MonoBehaviour
    {
        public UnityEngine.Transform skidding; // 0x20
        public UnityEngine.Transform PlayingAudio;
        public UnityEngine.ParticleSystem skidParticles; // 0x28
        public bool <skidding>k__BackingField; // 0x30
        public bool <PlayingAudio>k__BackingField; // 0x31
        public UnityEngine.AudioSource m_AudioSource; // 0x38
        public UnityEngine.Transform m_SkidTrail; // 0x40
        public UnityEngine.WheelCollider m_WheelCollider; // 0x48
        public InstantiationDelegate Instantiate; // 0x8

        // ── Methods ──
        public void get_skidding(){} // RVA: 0x7FFAC2F47450
        public void set_skidding(){} // RVA: 0x7FFAC2F47460
        public void get_PlayingAudio(){} // RVA: 0x7FFAC2F47470
        public void set_PlayingAudio(){} // RVA: 0x7FFAC2F47480
        public void Start(){} // RVA: 0x7FFAC2F47490
        public void EmitTyreSmoke(){} // RVA: 0x7FFAC2F47B00
        public void PlayAudio(){} // RVA: 0x7FFAC2F47F00
        public void StopAudio(){} // RVA: 0x7FFAC2F48140
        public void StartSkidTrail(){} // RVA: 0x7FFAC2F48380
        public void EndSkidTrail(){} // RVA: 0x7FFAC2F48420
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

}