// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Vehicles.Car
// Classes: 10
// Methods: 68

namespace ThirdParty.Other.UnityStandardAssets.Vehicles.Car
{
    public class BrakeLight : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8111A310
        public void Update(){} // RVA: 0x7FFE8111A3A0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class CarAIControl : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8111A420
        public void FixedUpdate(){} // RVA: 0x7FFE8111A590
        public void OnCollisionStay(){} // RVA: 0x7FFE8111AF70
        public void SetTarget(){} // RVA: 0x7FFE8111B550
        public void .ctor(){} // RVA: 0x7FFE8111B5B0
    }

    public class CarAudio : MonoBehaviour
    {
        // ── Methods ──
        public void StartSound(){} // RVA: 0x7FFE8111B650
        public void StopSound(){} // RVA: 0x7FFE8111B890
        public void Update(){} // RVA: 0x7FFE8111B9E0
        public void SetUpEngineAudioSource(){} // RVA: 0x7FFE8111C080
        public void ULerp(){} // RVA: 0x7FFE8111C420
        public void .ctor(){} // RVA: 0x7FFE8111C440
    }

    public class CarController : MonoBehaviour
    {
        public 0x665B4D94 m_CarDriveType; // 0x20
        public UnityEngine.WheelCollider[] m_WheelColliders; // 0x28
        public UnityEngine.GameObject[] m_WheelMeshes; // 0x30
        public UnityStandardAssets.Vehicles.Car.WheelEffects[] m_WheelEffects; // 0x38
        public UnityEngine.Vector3 m_CentreOfMassOffset; // 0x40
        public float m_MaximumSteerAngle; // 0x4C
        public float m_SteerHelper; // 0x50

        // ── Methods ──
        public void get_Skidding(){} // RVA: 0x7FFE8111C4C0
        public void set_Skidding(){} // RVA: 0x7FFE8111C4D0
        public void get_BrakeInput(){} // RVA: 0x7FFE8111C4E0
        public void set_BrakeInput(){} // RVA: 0x7FFE8111C4F0
        public void get_CurrentSteerAngle(){} // RVA: 0x7FFE8111C500
        public void get_CurrentSpeed(){} // RVA: 0x7FFE8111C510
        public void get_MaxSpeed(){} // RVA: 0x7FFE8111C680
        public void get_Revs(){} // RVA: 0x7FFE8111C690
        public void set_Revs(){} // RVA: 0x7FFE8111C6A0
        public void get_AccelInput(){} // RVA: 0x7FFE8111C6B0
        public void set_AccelInput(){} // RVA: 0x7FFE8111C6C0
        public void Start(){} // RVA: 0x7FFE8111C6D0
        public void GearChanging(){} // RVA: 0x7FFE8111CA00
        public void CurveFactor(){} // RVA: 0x7FFE8111CB20
        public void ULerp(){} // RVA: 0x7FFE8111C420
        public void CalculateGearFactor(){} // RVA: 0x7FFE8111CB40
        public void CalculateRevs(){} // RVA: 0x7FFE8111CCD0
        public void Move(){} // RVA: 0x7FFE8111CDC0
        public void CapSpeed(){} // RVA: 0x7FFE8111D500
        public void ApplyDrive(){} // RVA: 0x7FFE8111D8A0
        public void SteerHelper(){} // RVA: 0x7FFE8111DC20
        public void AddDownForce(){} // RVA: 0x7FFE8111E230
        public void CheckForWheelSpin(){} // RVA: 0x7FFE8111E4E0
        public void TractionControl(){} // RVA: 0x7FFE8111E6C0
        public void AdjustTorque(){} // RVA: 0x7FFE8111EA10
        public void AnySkidSoundPlaying(){} // RVA: 0x7FFE8111EA80
        public void .ctor(){} // RVA: 0x7FFE8111EAD0
        public void .cctor(){} // RVA: 0x7FFE8111ECB0
    }

    public class CarSelfRighting : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE811200F0
        public void Update(){} // RVA: 0x7FFE81120180
        public void RightCar(){} // RVA: 0x7FFE81120330
        public void .ctor(){} // RVA: 0x7FFE81120680
    }

    public class CarUserControl : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE811206E0
        public void FixedUpdate(){} // RVA: 0x7FFE81120770
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Mudguard : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE81120920
        public void Update(){} // RVA: 0x7FFE811209E0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SkidTrail : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE81120CA0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class Suspension : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE81121020
        public void Update(){} // RVA: 0x7FFE811211B0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class WheelEffects : MonoBehaviour
    {
        public UnityEngine.Transform SkidTrailPrefab; // 0x20
        public UnityEngine.Transform skidTrailsDetachedParent;

        // ── Methods ──
        public void get_skidding(){} // RVA: 0x7FFE81121450
        public void set_skidding(){} // RVA: 0x7FFE81121460
        public void get_PlayingAudio(){} // RVA: 0x7FFE81121470
        public void set_PlayingAudio(){} // RVA: 0x7FFE81121480
        public void Start(){} // RVA: 0x7FFE81121490
        public void EmitTyreSmoke(){} // RVA: 0x7FFE81121B00
        public void PlayAudio(){} // RVA: 0x7FFE81121F00
        public void StopAudio(){} // RVA: 0x7FFE81122140
        public void StartSkidTrail(){} // RVA: 0x7FFE81122380
        public void EndSkidTrail(){} // RVA: 0x7FFE81122420
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

}