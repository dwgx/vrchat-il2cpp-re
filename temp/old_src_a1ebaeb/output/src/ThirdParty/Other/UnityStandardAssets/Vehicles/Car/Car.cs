// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Vehicles.Car
// Classes: 10
// Methods: 68

namespace ThirdParty.Other.UnityStandardAssets.Vehicles.Car
{
    public class BrakeLight : MonoBehaviour
    {
        public object m_CarDriveType; // 0x3363AB20

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8951310
        public void Update(){} // RVA: 0x7ffaa89513a0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class CarAIControl : MonoBehaviour
    {
        public object m_CautiousMaxDistance; // 0x337E7800
        public object m_AccelSensitivity; // 0x337E7800
        public object m_LateralWanderSpeed; // 0x337E7800
        public object m_BrakeCondition; // 0x337E7800
        public object m_StopWhenTargetReached; // 0x337E7800
        public object m_CarController; // 0x337E7800
        public object m_AvoidPathOffset; // 0x337E7800
        public object `Ǐf; // 0x66DE1A7C

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa8951420
        public void FixedUpdate(){} // RVA: 0x7ffaa8951590
        public void OnCollisionStay(){} // RVA: 0x7ffaa8951f70
        public void .ctor(){} // RVA: 0x7ffaa89525b0
        // ── Binary Analysis Named ──
        public void SetTarget(){} // RVA: 0x7ffaa8952550
    }

    public class CarAudio : MonoBehaviour
    {
        public object lowDecelClip; // 0x334E8B90
        public object pitchMultiplier; // 0x334E8B90
        public object highPitchMultiplier; // 0x334E8B90
        public object useDoppler; // 0x334E8B90
        public object m_HighAccel; // 0x334E8B90
        public object m_CarController; // 0x334E8B90
        public object 8؏f; // 0x67396348

        // ── Original Methods ──
        public void StartSound(){} // RVA: 0x7ffaa8952650
        public void StopSound(){} // RVA: 0x7ffaa8952890
        public void Update(){} // RVA: 0x7ffaa89529e0
        public void ULerp(){} // RVA: 0x7ffaa8953420
        public void .ctor(){} // RVA: 0x7ffaa8953440
        // ── Binary Analysis Named ──
        public void SetUpEngineAudioSource(){} // RVA: 0x7ffaa8953080
    }

    public class CarController : MonoBehaviour
    {
        public object m_WheelMeshes; // 0x3363AB20
        public object m_MaximumSteerAngle; // 0x3363AB20
        public object m_FullTorqueOverAllWheels; // 0x3363AB20
        public object m_Downforce; // 0x3363AB20
        public object NoOfGears; // 0x3363AB20
        public object m_BrakeTorque; // 0x3363AB20
        public object m_Pos; // 0x3363AB20
        public object m_GearFactor; // 0x3363AB20
        public object m_Rigidbody; // 0x3363AB20
        public object _brakeInput; // 0x3363AB20, was: <BrakeInput>k__BackingField
        public object RearWheelDrive; // 0x844202E0

        // ── Original Methods ──
        public void get_Skidding(){} // RVA: 0x7ffaa89534c0
        public void set_Skidding(){} // RVA: 0x7ffaa89534d0
        public void get_BrakeInput(){} // RVA: 0x7ffaa89534e0
        public void set_BrakeInput(){} // RVA: 0x7ffaa89534f0
        public void get_CurrentSteerAngle(){} // RVA: 0x7ffaa8953500
        public void get_CurrentSpeed(){} // RVA: 0x7ffaa8953510
        public void get_MaxSpeed(){} // RVA: 0x7ffaa8953680
        public void get_Revs(){} // RVA: 0x7ffaa8953690
        public void set_Revs(){} // RVA: 0x7ffaa89536a0
        public void get_AccelInput(){} // RVA: 0x7ffaa89536b0
        public void set_AccelInput(){} // RVA: 0x7ffaa89536c0
        public void Start(){} // RVA: 0x7ffaa89536d0
        public void GearChanging(){} // RVA: 0x7ffaa8953a00
        public void CurveFactor(){} // RVA: 0x7ffaa8953b20
        public void ULerp(){} // RVA: 0x7ffaa8953420
        public void CalculateGearFactor(){} // RVA: 0x7ffaa8953b40
        public void CalculateRevs(){} // RVA: 0x7ffaa8953cd0
        public void Move(){} // RVA: 0x7ffaa8953dc0
        public void CapSpeed(){} // RVA: 0x7ffaa8954500
        public void ApplyDrive(){} // RVA: 0x7ffaa89548a0
        public void SteerHelper(){} // RVA: 0x7ffaa8954c20
        public void AddDownForce(){} // RVA: 0x7ffaa8955230
        public void TractionControl(){} // RVA: 0x7ffaa89556c0
        public void AdjustTorque(){} // RVA: 0x7ffaa8955a10
        public void AnySkidSoundPlaying(){} // RVA: 0x7ffaa8955a80
        public void .ctor(){} // RVA: 0x7ffaa8955ad0
        public void .cctor(){} // RVA: 0x7ffaa8955cb0
        // ── Binary Analysis Named ──
        public void CheckForWheelSpin(){} // RVA: 0x7ffaa89554e0
    }

    public class CarSelfRighting : MonoBehaviour
    {
        public object m_LastOkTime; // 0x339B63C0
        public object carController; // 0x33685700

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa89570f0
        public void Update(){} // RVA: 0x7ffaa8957180
        public void RightCar(){} // RVA: 0x7ffaa8957330
        public void .ctor(){} // RVA: 0x7ffaa8957680
    }

    public class CarUserControl : MonoBehaviour
    {
        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa89576e0
        public void FixedUpdate(){} // RVA: 0x7ffaa8957770
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class Mudguard : MonoBehaviour
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8957920
        public void Update(){} // RVA: 0x7ffaa89579e0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SkidTrail : MonoBehaviour
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8957ca0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class Suspension : MonoBehaviour
    {
        public object m_Origin; // 0x339BC330

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8958020
        public void Update(){} // RVA: 0x7ffaa89581b0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class WheelEffects : MonoBehaviour
    {
        public object skidParticles; // 0x33ACF020
        public object m_AudioSource; // 0x33ACF020
        public object Instantiate; // 0x33ACF020
        public object skidding; // 0x17000032
        public object PlayingAudio; // 0x17000033

        // ── Original Methods ──
        public void get_skidding(){} // RVA: 0x7ffaa8958450
        public void set_skidding(){} // RVA: 0x7ffaa8958460
        public void get_PlayingAudio(){} // RVA: 0x7ffaa8958470
        public void set_PlayingAudio(){} // RVA: 0x7ffaa8958480
        public void Start(){} // RVA: 0x7ffaa8958490
        public void EmitTyreSmoke(){} // RVA: 0x7ffaa8958b00
        public void PlayAudio(){} // RVA: 0x7ffaa8958f00
        public void StopAudio(){} // RVA: 0x7ffaa8959140
        public void StartSkidTrail(){} // RVA: 0x7ffaa8959380
        public void EndSkidTrail(){} // RVA: 0x7ffaa8959420
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

}