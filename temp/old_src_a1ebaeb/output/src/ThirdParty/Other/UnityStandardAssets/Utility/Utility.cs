// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Utility
// Classes: 19
// Methods: 82

namespace ThirdParty.Other.UnityStandardAssets.Utility
{
    public class ActivateTrigger : MonoBehaviour
    {
        public object source; // 0x33AE68B0
        public object Instantiate; // 0x33AE68B0

        // ── Original Methods ──
        public void OnTriggerEnter(){} // RVA: 0x7ffaa8933900
        public void .ctor(){} // RVA: 0x7ffaa8933910
        // ── Binary Analysis Named ──
        public void DoActivateTrigger(){} // RVA: 0x7ffaa8933080
    }

    public class AutoMobileShaderSwitch : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class CameraRefocus : Object
    {
        public object Parent; // 0x337BEC30

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933d70
        public void ChangeCamera(){} // RVA: 0x7ffaa8933e30
        public void ChangeParent(){} // RVA: 0x7ffaa8933e90
        // ── Binary Analysis Named ──
        public void GetFocusPoint(){} // RVA: 0x7ffaa8933ef0
        public void SetFocusPoint(){} // RVA: 0x7ffaa89341c0
    }

    public class CurveControlledBob : Object
    {
        public object Bobcurve; // 0x336A54A0
        public object m_CyclePositionY; // 0x336A54A0
        public object m_Time; // 0x336A54A0
        public object `;

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8934660
        // ── Binary Analysis Named ──
        public void Setup(){} // RVA: 0x7ffaa8934260
        public void DoHeadBob(){} // RVA: 0x7ffaa8934410
    }

    public class DragRigidbody : MonoBehaviour
    {
        public object k_Drag; // 0x3372CD50
        public object k_AttachToCenterOfMass; // 0x3372CD50

        // ── Original Methods ──
        public void Update(){} // RVA: 0x7ffaa8934870
        public void DragObject(){} // RVA: 0x7ffaa8934ec0
        public void FindCamera(){} // RVA: 0x7ffaa8934f80
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class DynamicShadowSettings : MonoBehaviour
    {
        public object minShadowDistance; // 0x338D5670
        public object maxShadowDistance; // 0x338D5670
        public object m_SmoothHeight; // 0x338D5670
        public object target; // 0x33502600
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8935810
        public void Update(){} // RVA: 0x7ffaa8935880
        public void .ctor(){} // RVA: 0x7ffaa8935e70
    }

    public class FOVKick : Object
    {
        public object FOVIncrease; // 0x337563D0
        public object IncreaseCurve; // 0x337563D0
        public object fpsMeasurePeriod; // 0x334EAF60

        // ── Original Methods ──
        public void ChangeCamera(){} // RVA: 0x7ffaa8933e30
        public void FOVKickUp(){} // RVA: 0x7ffaa89364e0
        public void FOVKickDown(){} // RVA: 0x7ffaa8936580
        public void .ctor(){} // RVA: 0x7ffaa8936620
        // ── Binary Analysis Named ──
        public void Setup(){} // RVA: 0x7ffaa8936170
        public void CheckStatus(){} // RVA: 0x7ffaa8936370
    }

    public class FPSCounter : MonoBehaviour
    {
        public object m_FpsNextPeriod; // 0x334EAF60
        public object m_Text; // 0x334EAF60

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8936ad0
        public void Update(){} // RVA: 0x7ffaa8936ba0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class FollowTarget : MonoBehaviour
    {
        // ── Original Methods ──
        public void LateUpdate(){} // RVA: 0x7ffaa8935ef0
        public void .ctor(){} // RVA: 0x7ffaa8936110
    }

    public class LerpControlledBob : Object
    {
        public object m_Offset; // 0x33AAEBB0

        // ── Original Methods ──
        public void Offset(){} // RVA: 0x7ffaa8936cf0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void DoBobCycle(){} // RVA: 0x7ffaa8936d00
    }

    public class ObjectResetter : MonoBehaviour
    {
        public object originalStructure; // 0x33787A70

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa89370a0
        public void DelayedReset(){} // RVA: 0x7ffaa8937380
        public void ResetCoroutine(){} // RVA: 0x7ffaa8937440
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class ParticleSystemDestroyer : MonoBehaviour
    {
        public object m_MaxLifetime; // 0x33523D60

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8937ad0
        public void Stop(){} // RVA: 0x7ffaa8937b70
        public void .ctor(){} // RVA: 0x7ffaa8937b80
    }

    public class PlatformSpecificContent : MonoBehaviour
    {
        public object m_MonoBehaviours; // 0x33A4EE80
        public object 8؏f; // 0x6739498B

        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaa8938370
        public void EnableContent(){} // RVA: 0x7ffaa8938390
        public void .ctor(){} // RVA: 0x7ffaa8938930
        // ── Binary Analysis Named ──
        public void CheckEnableContent(){} // RVA: 0x7ffaa8938370
    }

    public class SimpleMouseRotator : MonoBehaviour
    {
        public object dampingTime; // 0x33AEDF80
        public object relative; // 0x33AEDF80
        public object m_FollowVelocity; // 0x33AEDF80
        public object distance; // 0x33CC7D90
        public object heightDamping; // 0x33CC7D90

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8938a80
        public void Update(){} // RVA: 0x7ffaa8938b40
        public void .ctor(){} // RVA: 0x7ffaa8939390
    }

    public class SmoothFollow : MonoBehaviour
    {
        public object height; // 0x33CC7D90

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8932310
        public void LateUpdate(){} // RVA: 0x7ffaa8939400
        public void .ctor(){} // RVA: 0x7ffaa8939f30
    }

    public class TimedObjectActivator : MonoBehaviour
    {
        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa8939f90
        public void Activate(){} // RVA: 0x7ffaa893a0c0
        public void Deactivate(){} // RVA: 0x7ffaa893a160
        public void ReloadLevel(){} // RVA: 0x7ffaa893a200
        public void .ctor(){} // RVA: 0x7ffaa893a2a0
    }

    public class TimedObjectDestructor : MonoBehaviour
    {
        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa893a790
        public void DestroyNow(){} // RVA: 0x7ffaa893a7e0
        public void .ctor(){} // RVA: 0x7ffaa893a920
    }

    public class WaypointCircuit : MonoBehaviour
    {
        public object numPoints; // 0x3381F600
        public object editorVisualisationSubsteps; // 0x3381F600
        public object p1n; // 0x3381F600
        public object i; // 0x3381F600
        public object P2; // 0x3381F600
        public object SmoothAlongRoute; // 0x84419D60

        // ── Original Methods ──
        public void get_Length(){} // RVA: 0x7ffaa893a970
        public void set_Length(){} // RVA: 0x7ffaa893a980
        public void get_Waypoints(){} // RVA: 0x7ffaa893a990
        public void Awake(){} // RVA: 0x7ffaa893a9b0
        public void CatmullRom(){} // RVA: 0x7ffaa893af00
        public void CachePositionsAndDistances(){} // RVA: 0x7ffaa893b1c0
        public void OnDrawGizmos(){} // RVA: 0x7ffaa893b6d0
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaa893b6e0
        public void DrawGizmos(){} // RVA: 0x7ffaa893b6f0
        public void .ctor(){} // RVA: 0x7ffaa893bbf0
        // ── Binary Analysis Named ──
        public void GetRoutePoint(){} // RVA: 0x7ffaa893aa00
        public void GetRoutePosition(){} // RVA: 0x7ffaa893ab60
    }

    public class WaypointProgressTracker : MonoBehaviour
    {
        public object lookAheadForTargetFactor; // 0x33ACE720
        public object progressStyle; // 0x33ACE720
        public object _speedPoint; // 0x33ACE720, was: <speedPoint>k__BackingField
        public object progressDistance; // 0x33ACE720
        public object speed; // 0x33ACE720
        public object targetPoint; // 0x17000015
        public object speedPoint; // 0x17000016
        public object progressPoint; // 0x17000017
        public object 8؏f; // 0x67394DDD

        // ── Original Methods ──
        public void get_targetPoint(){} // RVA: 0x7ffaa893be10
        public void set_targetPoint(){} // RVA: 0x7ffaa893be30
        public void get_speedPoint(){} // RVA: 0x7ffaa893be50
        public void set_speedPoint(){} // RVA: 0x7ffaa893be70
        public void get_progressPoint(){} // RVA: 0x7ffaa893be90
        public void set_progressPoint(){} // RVA: 0x7ffaa893beb0
        public void Start(){} // RVA: 0x7ffaa893bed0
        public void Reset(){} // RVA: 0x7ffaa893c0c0
        public void Update(){} // RVA: 0x7ffaa893c310
        public void OnDrawGizmos(){} // RVA: 0x7ffaa893cf00
        public void .ctor(){} // RVA: 0x7ffaa893d3d0
    }

}