// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Vehicles.Car
// Classes: 11
// Methods: 83

namespace ThirdParty.Other.UnityStandardAssets.Vehicles.Car
{
    public class BrakeLight : MonoBehaviour
    {
        public object car;
        public object m_Renderer;

        // ── Methods ──
        public void Start(){} // RVA: 0xB61B20
        public void Update(){} // RVA: 0xB61BB0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class CarAIControl : MonoBehaviour
    {
        public object m_CautiousSpeedFactor;
        public object m_CautiousMaxAngle;
        public object m_CautiousMaxDistance;
        public object m_CautiousAngularVelocityFactor;
        public object m_SteerSensitivity;
        public object m_AccelSensitivity;
        public object m_BrakeSensitivity;
        public object m_LateralWanderDistance;
        public object m_LateralWanderSpeed;
        public object m_AccelWanderAmount;
        public object m_AccelWanderSpeed;
        public object m_BrakeCondition;
        public object m_Driving;
        public object m_Target;
        public object m_StopWhenTargetReached;
        public object m_ReachTargetThreshold;
        public object m_RandomPerlin;
        public object m_CarController;
        public object m_AvoidOtherCarTime;
        public object m_AvoidOtherCarSlowdown;
        public object m_AvoidPathOffset;
        public object m_Rigidbody;

        // ── Methods ──
        public void Awake(){} // RVA: 0xB61BF0
        public void FixedUpdate(){} // RVA: 0xB61D60
        public void OnCollisionStay(){} // RVA: 0xB62690
        public void SetTarget(){} // RVA: 0xB62C30
        public void .ctor(){} // RVA: 0xB62C90
    }

    public class CarAudio : MonoBehaviour
    {
        public object engineSoundStyle;
        public object lowAccelClip;
        public object lowDecelClip;
        public object highAccelClip;
        public object highDecelClip;
        public object pitchMultiplier;
        public object lowPitchMin;
        public object lowPitchMax;
        public object highPitchMultiplier;
        public object maxRolloffDistance;
        public object dopplerLevel;
        public object useDoppler;
        public object m_LowAccel;
        public object m_LowDecel;
        public object m_HighAccel;
        public object m_HighDecel;
        public object m_StartedSound;
        public object m_CarController;

        // ── Methods ──
        public void StartSound(){} // RVA: 0xB62D30
        public void StopSound(){} // RVA: 0xB62F70
        public void Update(){} // RVA: 0xB630C0
        public void SetUpEngineAudioSource(){} // RVA: 0xB636F0
        public void ULerp(){} // RVA: 0xB638D0
        public void .ctor(){} // RVA: 0xB638F0
    }

    public class CarController : MonoBehaviour
    {
        public object m_CarDriveType;
        public object m_WheelColliders;
        public object m_WheelMeshes;
        public object m_WheelEffects;
        public object m_CentreOfMassOffset;
        public object m_MaximumSteerAngle;
        public object m_SteerHelper;
        public object m_TractionControl;
        public object m_FullTorqueOverAllWheels;
        public object m_ReverseTorque;
        public object m_MaxHandbrakeTorque;
        public object m_Downforce;
        public object m_SpeedType;
        public object m_Topspeed;
        public object NoOfGears;
        public object m_RevRangeBoundary;
        public object m_SlipLimit;
        public object m_BrakeTorque;
        public object m_WheelMeshLocalRotations;
        public object m_Prevpos;
        public object m_Pos;
        public object m_SteerAngle;
        public object m_GearNum;
        public object m_GearFactor;
        public object m_OldRotation;
        public object m_CurrentTorque;
        public object m_Rigidbody;
        public object k_ReversingThreshold;
        public object _skidding;
        public object _brakeInput;
        public object _revs;
        public object _accelInput;

        // ── Methods ──
        public void get_Skidding(){} // RVA: 0xB63970
        public void set_Skidding(){} // RVA: 0xB63980
        public void get_BrakeInput(){} // RVA: 0xB63990
        public void set_BrakeInput(){} // RVA: 0xB639A0
        public void get_CurrentSteerAngle(){} // RVA: 0xB639B0
        public void get_CurrentSpeed(){} // RVA: 0xB639C0
        public void get_MaxSpeed(){} // RVA: 0xB63B70
        public void get_Revs(){} // RVA: 0xB63B80
        public void set_Revs(){} // RVA: 0xB63B90
        public void get_AccelInput(){} // RVA: 0xB63BA0
        public void set_AccelInput(){} // RVA: 0xB63BB0
        public void Start(){} // RVA: 0xB63BC0
        public void GearChanging(){} // RVA: 0xB64050
        public void CurveFactor(){} // RVA: 0xB64170
        public void ULerp(){} // RVA: 0xB638D0
        public void CalculateGearFactor(){} // RVA: 0xB64190
        public void CalculateRevs(){} // RVA: 0xB64320
        public void Move(){} // RVA: 0xB64410
        public void CapSpeed(){} // RVA: 0xB64DA0
        public void ApplyDrive(){} // RVA: 0xB65280
        public void SteerHelper(){} // RVA: 0xB65610
        public void AddDownForce(){} // RVA: 0xB65B20
        public void CheckForWheelSpin(){} // RVA: 0xB65D90
        public void TractionControl(){} // RVA: 0xB65FA0
        public void AdjustTorque(){} // RVA: 0xB66430
        public void AnySkidSoundPlaying(){} // RVA: 0xB664A0
        public void .ctor(){} // RVA: 0xB66500
        public void .cctor(){} // RVA: 0xB666E0
    }

    public class CarSelfRighting : MonoBehaviour
    {
        public object m_WaitTime;
        public object m_VelocityThreshold;
        public object m_LastOkTime;
        public object m_Rigidbody;

        // ── Methods ──
        public void Start(){} // RVA: 0xB67B50
        public void Update(){} // RVA: 0xB67BE0
        public void RightCar(){} // RVA: 0xB67D90
        public void .ctor(){} // RVA: 0xB680E0
    }

    public class CarUserControl : MonoBehaviour
    {
        public object m_Car;

        // ── Methods ──
        public void Awake(){} // RVA: 0xB68140
        public void FixedUpdate(){} // RVA: 0xB681D0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class Mudguard : MonoBehaviour
    {
        public object carController;
        public object m_OriginalRotation;

        // ── Methods ──
        public void Start(){} // RVA: 0xB68380
        public void Update(){} // RVA: 0xB68450
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SkidTrail : MonoBehaviour
    {
        public object m_PersistTime;

        // ── Methods ──
        public void Start(){} // RVA: 0xB686F0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class Suspension : MonoBehaviour
    {
        public object wheel;
        public object m_TargetOriginalPosition;
        public object m_Origin;

        // ── Methods ──
        public void Start(){} // RVA: 0xB689B0
        public void Update(){} // RVA: 0xB68B50
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class WheelEffects : MonoBehaviour
    {
        public object SkidTrailPrefab;
        public object skidTrailsDetachedParent;
        public object skidParticles;
        public object _skidding;
        public object _playingAudio;
        public object m_AudioSource;
        public object m_SkidTrail;
        public object m_WheelCollider;
        public object Instantiate;

        // ── Methods ──
        public void get_skidding(){} // RVA: 0xB68DF0
        public void set_skidding(){} // RVA: 0xB68E00
        public void get_PlayingAudio(){} // RVA: 0xB68E10
        public void set_PlayingAudio(){} // RVA: 0xB68E20
        public void Start(){} // RVA: 0xB68E30
        public void EmitTyreSmoke(){} // RVA: 0xB693A0
        public void PlayAudio(){} // RVA: 0xB69710
        public void StopAudio(){} // RVA: 0xB69910
        public void StartSkidTrail(){} // RVA: 0xB69B10
        public void EndSkidTrail(){} // RVA: 0xB69BB0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class WheelEffects[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}