// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Vehicles.Car
// Classes: 10
// Methods: 68

namespace ThirdParty.Other.UnityStandardAssets.Vehicles.Car
{
    public class BrakeLight : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E360310
        public void Update(){} // RVA: 0x7FFD4E3603A0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class CarAIControl : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E360420
        public void FixedUpdate(){} // RVA: 0x7FFD4E360590
        public void OnCollisionStay(){} // RVA: 0x7FFD4E360F70
        public void SetTarget(){} // RVA: 0x7FFD4E361550
        public void .ctor(){} // RVA: 0x7FFD4E3615B0
    }

    public class CarAudio : MonoBehaviour
    {
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
        public object Skidding;
        public object BrakeInput;
        public object CurrentSteerAngle;
        public object CurrentSpeed;
        public object MaxSpeed;
        public object Revs;
        public object AccelInput;

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
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E3660F0
        public void Update(){} // RVA: 0x7FFD4E366180
        public void RightCar(){} // RVA: 0x7FFD4E366330
        public void .ctor(){} // RVA: 0x7FFD4E366680
    }

    public class CarUserControl : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E3666E0
        public void FixedUpdate(){} // RVA: 0x7FFD4E366770
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Mudguard : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E366920
        public void Update(){} // RVA: 0x7FFD4E3669E0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SkidTrail : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E366CA0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class Suspension : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E367020
        public void Update(){} // RVA: 0x7FFD4E3671B0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class WheelEffects : MonoBehaviour
    {
        public object skidding;
        public object PlayingAudio;

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