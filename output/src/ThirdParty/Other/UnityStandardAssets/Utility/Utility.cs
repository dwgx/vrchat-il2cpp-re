// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Utility
// Classes: 19
// Methods: 82

namespace ThirdParty.Other.UnityStandardAssets.Utility
{
    public class ActivateTrigger : MonoBehaviour
    {
        public object action;
        public object target;
        public object source;
        public object triggerCount;
        public object repeatTrigger;
        public object Instantiate;

        // ── Methods ──
        public void DoActivateTrigger(){} // RVA: 0xB440E0
        public void OnTriggerEnter(){} // RVA: 0xB44850
        public void .ctor(){} // RVA: 0xB44860
    }

    public class AutoMobileShaderSwitch : MonoBehaviour
    {
        public object m_ReplacementList;

        // ── Methods ──
        public void OnEnable(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class CameraRefocus : Object
    {
        public object Camera;
        public object Lookatpoint;
        public object Parent;
        public object m_OrigCameraPos;
        public object m_Refocus;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44CA0
        public void ChangeCamera(){} // RVA: 0xB44D60
        public void ChangeParent(){} // RVA: 0xB44DC0
        public void GetFocusPoint(){} // RVA: 0xB44E20
        public void SetFocusPoint(){} // RVA: 0xB450E0
    }

    public class CurveControlledBob : Object
    {
        public object HorizontalBobRange;
        public object VerticalBobRange;
        public object Bobcurve;
        public object VerticaltoHorizontalRatio;
        public object m_CyclePositionX;
        public object m_CyclePositionY;
        public object m_BobBaseInterval;
        public object m_OriginalCameraPosition;
        public object m_Time;

        // ── Methods ──
        public void Setup(){} // RVA: 0xB45140
        public void DoHeadBob(){} // RVA: 0xB45330
        public void .ctor(){} // RVA: 0xB455B0
    }

    public class DragRigidbody : MonoBehaviour
    {
        public object k_Spring;
        public object k_Damper;
        public object k_Drag;
        public object k_AngularDrag;
        public object k_Distance;
        public object k_AttachToCenterOfMass;
        public object m_SpringJoint;

        // ── Methods ──
        public void Update(){} // RVA: 0xB457A0
        public void DragObject(){} // RVA: 0xB45ED0
        public void FindCamera(){} // RVA: 0xB45F90
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class DynamicShadowSettings : MonoBehaviour
    {
        public object sunLight;
        public object minHeight;
        public object minShadowDistance;
        public object minShadowBias;
        public object maxHeight;
        public object maxShadowDistance;
        public object maxShadowBias;
        public object adaptTime;
        public object m_SmoothHeight;
        public object m_ChangeSpeed;
        public object m_OriginalStrength;

        // ── Methods ──
        public void Start(){} // RVA: 0xB46600
        public void Update(){} // RVA: 0xB466B0
        public void .ctor(){} // RVA: 0xB46BF0
    }

    public class FOVKick : Object
    {
        public object Camera;
        public object originalFov;
        public object FOVIncrease;
        public object TimeToIncrease;
        public object TimeToDecrease;
        public object IncreaseCurve;

        // ── Methods ──
        public void Setup(){} // RVA: 0xB46F30
        public void CheckStatus(){} // RVA: 0xB47180
        public void ChangeCamera(){} // RVA: 0xB44D60
        public void FOVKickUp(){} // RVA: 0xB472F0
        public void FOVKickDown(){} // RVA: 0xB47390
        public void .ctor(){} // RVA: 0xB47430
    }

    public class FPSCounter : MonoBehaviour
    {
        public object fpsMeasurePeriod;
        public object m_FpsAccumulator;
        public object m_FpsNextPeriod;
        public object m_CurrentFps;
        public object display;
        public object m_Text;

        // ── Methods ──
        public void Start(){} // RVA: 0xB47940
        public void Update(){} // RVA: 0xB47A10
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class FollowTarget : MonoBehaviour
    {
        public object target;
        public object offset;

        // ── Methods ──
        public void LateUpdate(){} // RVA: 0xB46C70
        public void .ctor(){} // RVA: 0xB46ED0
    }

    public class LerpControlledBob : Object
    {
        public object BobDuration;
        public object BobAmount;
        public object m_Offset;

        // ── Methods ──
        public void Offset(){} // RVA: 0xB47B50
        public void DoBobCycle(){} // RVA: 0xB47B60
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ObjectResetter : MonoBehaviour
    {
        public object originalPosition;
        public object originalRotation;
        public object originalStructure;
        public object Rigidbody;

        // ── Methods ──
        public void Start(){} // RVA: 0xB47F00
        public void DelayedReset(){} // RVA: 0xB481E0
        public void ResetCoroutine(){} // RVA: 0xB482A0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class ParticleSystemDestroyer : MonoBehaviour
    {
        public object minDuration;
        public object maxDuration;
        public object m_MaxLifetime;
        public object m_EarlyStop;

        // ── Methods ──
        public void Start(){} // RVA: 0xB48AB0
        public void Stop(){} // RVA: 0xB48B50
        public void .ctor(){} // RVA: 0xB48B60
    }

    public class PlatformSpecificContent : MonoBehaviour
    {
        public object m_BuildTargetGroup;
        public object m_Content;
        public object m_MonoBehaviours;
        public object m_ChildrenOfThisObject;

        // ── Methods ──
        public void OnEnable(){} // RVA: 0xB49390
        public void CheckEnableContent(){} // RVA: 0xB49390
        public void EnableContent(){} // RVA: 0xB493A0
        public void .ctor(){} // RVA: 0xB499C0
    }

    public class SimpleMouseRotator : MonoBehaviour
    {
        public object rotationRange;
        public object rotationSpeed;
        public object dampingTime;
        public object autoZeroVerticalOnMobile;
        public object autoZeroHorizontalOnMobile;
        public object relative;
        public object m_TargetAngles;
        public object m_FollowAngles;
        public object m_FollowVelocity;
        public object m_OriginalRotation;

        // ── Methods ──
        public void Start(){} // RVA: 0xB49B10
        public void Update(){} // RVA: 0xB49BE0
        public void .ctor(){} // RVA: 0xB4A410
    }

    public class SmoothFollow : MonoBehaviour
    {
        public object target;
        public object distance;
        public object height;
        public object rotationDamping;
        public object heightDamping;

        // ── Methods ──
        public void Start(){} // RVA: 0xB43310
        public void LateUpdate(){} // RVA: 0xB4A480
        public void .ctor(){} // RVA: 0xB4AEF0
    }

    public class TimedObjectActivator : MonoBehaviour
    {
        public object entries;

        // ── Methods ──
        public void Awake(){} // RVA: 0xB4AF50
        public void Activate(){} // RVA: 0xB4B090
        public void Deactivate(){} // RVA: 0xB4B130
        public void ReloadLevel(){} // RVA: 0xB4B1D0
        public void .ctor(){} // RVA: 0xB4B270
    }

    public class TimedObjectDestructor : MonoBehaviour
    {
        public object m_TimeOut;
        public object m_DetachChildren;

        // ── Methods ──
        public void Awake(){} // RVA: 0xB4B720
        public void DestroyNow(){} // RVA: 0xB4B770
        public void .ctor(){} // RVA: 0xB4B830
    }

    public class WaypointCircuit : MonoBehaviour
    {
        public object waypointList;
        public object smoothRoute;
        public object numPoints;
        public object points;
        public object distances;
        public object editorVisualisationSubsteps;
        public object _length;
        public object p0n;
        public object p1n;
        public object p2n;
        public object p3n;
        public object i;
        public object P0;
        public object P1;
        public object P2;
        public object P3;

        // ── Methods ──
        public void get_Length(){} // RVA: 0xB4B880
        public void set_Length(){} // RVA: 0xB4B890
        public void get_Waypoints(){} // RVA: 0xB4B8A0
        public void Awake(){} // RVA: 0xB4B8C0
        public void GetRoutePoint(){} // RVA: 0xB4B910
        public void GetRoutePosition(){} // RVA: 0xB4BA70
        public void CatmullRom(){} // RVA: 0xB4BE00
        public void CachePositionsAndDistances(){} // RVA: 0xB4C120
        public void OnDrawGizmos(){} // RVA: 0xB4C5C0
        public void OnDrawGizmosSelected(){} // RVA: 0xB4C5D0
        public void DrawGizmos(){} // RVA: 0xB4C5E0
        public void .ctor(){} // RVA: 0xB4CBA0
    }

    public class WaypointProgressTracker : MonoBehaviour
    {
        public object circuit;
        public object lookAheadForTargetOffset;
        public object lookAheadForTargetFactor;
        public object lookAheadForSpeedOffset;
        public object lookAheadForSpeedFactor;
        public object progressStyle;
        public object pointToPointThreshold;
        public object _targetPoint;
        public object _speedPoint;
        public object _progressPoint;
        public object target;
        public object progressDistance;
        public object progressNum;
        public object lastPosition;
        public object speed;

        // ── Methods ──
        public void get_targetPoint(){} // RVA: 0xB4CDC0
        public void set_targetPoint(){} // RVA: 0xB4CDE0
        public void get_speedPoint(){} // RVA: 0xB4CE00
        public void set_speedPoint(){} // RVA: 0xB4CE20
        public void get_progressPoint(){} // RVA: 0xB4CE40
        public void set_progressPoint(){} // RVA: 0xB4CE60
        public void Start(){} // RVA: 0xB4CE80
        public void Reset(){} // RVA: 0xB4D060
        public void Update(){} // RVA: 0xB4D3A0
        public void OnDrawGizmos(){} // RVA: 0xB4E130
        public void .ctor(){} // RVA: 0xB4E6B0
    }

}