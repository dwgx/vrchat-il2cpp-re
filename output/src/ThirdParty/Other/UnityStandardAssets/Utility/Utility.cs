// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Utility
// Classes: 19
// Methods: 82

namespace ThirdParty.Other.UnityStandardAssets.Utility
{
    public class ActivateTrigger : MonoBehaviour
    {
        public object action; // 0x20
        public object target; // 0x28
        public BuffersImpl source; // 0x30
        public int triggerCount; // 0x38
        public bool repeatTrigger; // 0x3C
        public object Instantiate;

        // ── Methods ──
        public void DoActivateTrigger(){} // RVA: 0x7FFD4E342080
        public void OnTriggerEnter(){} // RVA: 0x7FFD4E342900
        public void .ctor(){} // RVA: 0x7FFD4E342910
    }

    public class AutoMobileShaderSwitch : MonoBehaviour
    {
        public ayTransform_TrackedDeviceRelative m_ReplacementList; // 0x20

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class CameraRefocus : Object
    {
        public ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ Camera; // 0x10
        public amut Lookatpoint; // 0x18
        public object Parent; // 0x28
        public amut m_OrigCameraPos; // 0x30
        public bool m_Refocus; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342D70
        public void ChangeCamera(){} // RVA: 0x7FFD4E342E30
        public void ChangeParent(){} // RVA: 0x7FFD4E342E90
        public void GetFocusPoint(){} // RVA: 0x7FFD4E342EF0
        public void SetFocusPoint(){} // RVA: 0x7FFD4E3431C0
    }

    public class CurveControlledBob : Object
    {
        public float HorizontalBobRange; // 0x10
        public float VerticalBobRange; // 0x14
        public ÍÎÌÍÍÌÌÎÏÏ Bobcurve; // 0x18
        public float VerticaltoHorizontalRatio; // 0x20
        public float m_CyclePositionX; // 0x24
        public float m_CyclePositionY; // 0x28
        public float m_BobBaseInterval; // 0x2C
        public amut m_OriginalCameraPosition; // 0x30
        public float m_Time; // 0x3C

        // ── Methods ──
        public void Setup(){} // RVA: 0x7FFD4E343260
        public void DoHeadBob(){} // RVA: 0x7FFD4E343410
        public void .ctor(){} // RVA: 0x7FFD4E343660
    }

    public class DragRigidbody : MonoBehaviour
    {
        public float k_Spring;
        public float k_Damper;
        public float k_Drag;
        public float k_AngularDrag;
        public float k_Distance;
        public bool k_AttachToCenterOfMass;
        public ernalSetMuscle_Injected m_SpringJoint; // 0x20

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFD4E343870
        public void DragObject(){} // RVA: 0x7FFD4E343EC0
        public void FindCamera(){} // RVA: 0x7FFD4E343F80
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class DynamicShadowSettings : MonoBehaviour
    {
        public ReflectionCubemap sunLight; // 0x20
        public float minHeight; // 0x28
        public float minShadowDistance; // 0x2C
        public float minShadowBias; // 0x30
        public float maxHeight; // 0x34
        public float maxShadowDistance; // 0x38
        public float maxShadowBias; // 0x3C
        public float adaptTime; // 0x40
        public float m_SmoothHeight; // 0x44
        public float m_ChangeSpeed; // 0x48
        public float m_OriginalStrength; // 0x4C

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E344810
        public void Update(){} // RVA: 0x7FFD4E344880
        public void .ctor(){} // RVA: 0x7FFD4E344E70
    }

    public class FOVKick : Object
    {
        public ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ Camera; // 0x10
        public float originalFov; // 0x18
        public float FOVIncrease; // 0x1C
        public float TimeToIncrease; // 0x20
        public float TimeToDecrease; // 0x24
        public ÍÎÌÍÍÌÌÎÏÏ IncreaseCurve; // 0x28

        // ── Methods ──
        public void Setup(){} // RVA: 0x7FFD4E345170
        public void CheckStatus(){} // RVA: 0x7FFD4E345370
        public void ChangeCamera(){} // RVA: 0x7FFD4E342E30
        public void FOVKickUp(){} // RVA: 0x7FFD4E3454E0
        public void FOVKickDown(){} // RVA: 0x7FFD4E345580
        public void .ctor(){} // RVA: 0x7FFD4E345620
    }

    public class FPSCounter : MonoBehaviour
    {
        public float fpsMeasurePeriod;
        public int m_FpsAccumulator; // 0x20
        public float m_FpsNextPeriod; // 0x24
        public int m_CurrentFps; // 0x28
        public string display;
        public ePathName117.? m_Text; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E345AD0
        public void Update(){} // RVA: 0x7FFD4E345BA0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class FollowTarget : MonoBehaviour
    {
        public object target; // 0x20
        public amut offset; // 0x28

        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x7FFD4E344EF0
        public void .ctor(){} // RVA: 0x7FFD4E345110
    }

    public class LerpControlledBob : Object
    {
        public float BobDuration; // 0x10
        public float BobAmount; // 0x14
        public float m_Offset; // 0x18

        // ── Methods ──
        public void Offset(){} // RVA: 0x7FFD4E345CF0
        public void DoBobCycle(){} // RVA: 0x7FFD4E345D00
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ObjectResetter : MonoBehaviour
    {
        public amut originalPosition; // 0x20
        public R_12x12 originalRotation; // 0x2C
        public URA.woDigitYearMax<?> originalStructure; // 0x40
        public Touched Rigidbody; // 0x48

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E3460A0
        public void DelayedReset(){} // RVA: 0x7FFD4E346380
        public void ResetCoroutine(){} // RVA: 0x7FFD4E346440
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class ParticleSystemDestroyer : MonoBehaviour
    {
        public float minDuration; // 0x20
        public float maxDuration; // 0x24
        public float m_MaxLifetime; // 0x28
        public bool m_EarlyStop; // 0x2C

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E346AD0
        public void Stop(){} // RVA: 0x7FFD4E346B70
        public void .ctor(){} // RVA: 0x7FFD4E346B80
    }

    public class PlatformSpecificContent : MonoBehaviour
    {
        public EVRSkeletalTransformSpace m_BuildTargetGroup; // 0x20
        public BuffersImpl[] m_Content; // 0x28
        public glesLength[] m_MonoBehaviours; // 0x30
        public bool m_ChildrenOfThisObject; // 0x38

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD4E347370
        public void CheckEnableContent(){} // RVA: 0x7FFD4E347370
        public void EnableContent(){} // RVA: 0x7FFD4E347390
        public void .ctor(){} // RVA: 0x7FFD4E347930
    }

    public class SimpleMouseRotator : MonoBehaviour
    {
        public tionX rotationRange; // 0x20
        public float rotationSpeed; // 0x28
        public float dampingTime; // 0x2C
        public bool autoZeroVerticalOnMobile; // 0x30
        public bool autoZeroHorizontalOnMobile; // 0x31
        public bool relative; // 0x32
        public amut m_TargetAngles; // 0x34
        public amut m_FollowAngles; // 0x40
        public amut m_FollowVelocity; // 0x4C
        public R_12x12 m_OriginalRotation; // 0x58

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E347A80
        public void Update(){} // RVA: 0x7FFD4E347B40
        public void .ctor(){} // RVA: 0x7FFD4E348390
    }

    public class SmoothFollow : MonoBehaviour
    {
        public object target; // 0x20
        public float distance; // 0x28
        public float height; // 0x2C
        public float rotationDamping; // 0x30
        public float heightDamping; // 0x34

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E341310
        public void LateUpdate(){} // RVA: 0x7FFD4E348400
        public void .ctor(){} // RVA: 0x7FFD4E348F30
    }

    public class TimedObjectActivator : MonoBehaviour
    {
        public object entries; // 0x20

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E348F90
        public void Activate(){} // RVA: 0x7FFD4E3490C0
        public void Deactivate(){} // RVA: 0x7FFD4E349160
        public void ReloadLevel(){} // RVA: 0x7FFD4E349200
        public void .ctor(){} // RVA: 0x7FFD4E3492A0
    }

    public class TimedObjectDestructor : MonoBehaviour
    {
        public float m_TimeOut; // 0x20
        public bool m_DetachChildren; // 0x24

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E349790
        public void DestroyNow(){} // RVA: 0x7FFD4E3497E0
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class WaypointCircuit : MonoBehaviour
    {
        public mdMatrix44_t Length; // 0x20
        public bool Waypoints; // 0x28
        public int numPoints; // 0x2C
        public amut[] points; // 0x30
        public float[] distances; // 0x38
        public float editorVisualisationSubsteps; // 0x40
        public float <Length>k__BackingField; // 0x44
        public int p0n; // 0x48
        public int p1n; // 0x4C
        public int p2n; // 0x50
        public int p3n; // 0x54
        public float i; // 0x58
        public amut P0; // 0x5C
        public amut P1; // 0x68
        public amut P2; // 0x74
        public amut P3; // 0x80

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFD4E349970
        public void set_Length(){} // RVA: 0x7FFD4E349980
        public void get_Waypoints(){} // RVA: 0x7FFD4E349990
        public void Awake(){} // RVA: 0x7FFD4E3499B0
        public void GetRoutePoint(){} // RVA: 0x7FFD4E349A00
        public void GetRoutePosition(){} // RVA: 0x7FFD4E349B60
        public void CatmullRom(){} // RVA: 0x7FFD4E349F00
        public void CachePositionsAndDistances(){} // RVA: 0x7FFD4E34A1C0
        public void OnDrawGizmos(){} // RVA: 0x7FFD4E34A6D0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD4E34A6E0
        public void DrawGizmos(){} // RVA: 0x7FFD4E34A6F0
        public void .ctor(){} // RVA: 0x7FFD4E34ABF0
    }

    public class WaypointProgressTracker : MonoBehaviour
    {
        public ntimePerformsPostPresentHandoff.applicationLaunch targetPoint; // 0x20
        public float speedPoint; // 0x28
        public float progressPoint; // 0x2C
        public float lookAheadForSpeedOffset; // 0x30
        public float lookAheadForSpeedFactor; // 0x34
        public n progressStyle; // 0x38
        public float pointToPointThreshold; // 0x3C
        public HmdVector3_t <targetPoint>k__BackingField; // 0x40
        public HmdVector3_t <speedPoint>k__BackingField; // 0x58
        public HmdVector3_t <progressPoint>k__BackingField; // 0x70
        public object target; // 0x88
        public float progressDistance; // 0x90
        public int progressNum; // 0x94
        public amut lastPosition; // 0x98
        public float speed; // 0xA4

        // ── Methods ──
        public void get_targetPoint(){} // RVA: 0x7FFD4E34AE10
        public void set_targetPoint(){} // RVA: 0x7FFD4E34AE30
        public void get_speedPoint(){} // RVA: 0x7FFD4E34AE50
        public void set_speedPoint(){} // RVA: 0x7FFD4E34AE70
        public void get_progressPoint(){} // RVA: 0x7FFD4E34AE90
        public void set_progressPoint(){} // RVA: 0x7FFD4E34AEB0
        public void Start(){} // RVA: 0x7FFD4E34AED0
        public void Reset(){} // RVA: 0x7FFD4E34B0C0
        public void Update(){} // RVA: 0x7FFD4E34B310
        public void OnDrawGizmos(){} // RVA: 0x7FFD4E34BF00
        public void .ctor(){} // RVA: 0x7FFD4E34C3D0
    }

}