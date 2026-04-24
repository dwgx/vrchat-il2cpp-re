// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.ClientBindings
// Classes: 3
// Methods: 28

namespace VRC.Udon.ClientBindings
{
    public class UdonClientInterface : Object
    {
        public object filter; // 0x31912850

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf89fc70
        public void .ctor(){} // RVA: 0x7ffaaf89fc70
        public void get_DebugLogging(){} // RVA: 0x7ffaa8958450
        public void set_DebugLogging(){} // RVA: 0x7ffaa8958460
        public void ConstructUdonVM(){} // RVA: 0x7ffaaf8a0020
        public void ApplyFilter(){} // RVA: 0x7ffaa8660d80
        public void ApplyFilter(){} // RVA: 0x7ffaa8660d80
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7ffaaf8a00d0
        public void get_LightReservedLayerMask(){} // RVA: 0x7ffaaf8a0130
        public void set_LightReservedLayerMask(){} // RVA: 0x7ffaaf8a0180
        // ── Binary Analysis Named ──
        public void GetWrapper(){} // RVA: 0x7ffaaf8a01e0
    }

    public class UdonEventScheduler : Object
    {
        public object OnEventScheduled; // 0x36121970

        // ── Original Methods ──
        public void add_OnEventScheduled(){} // RVA: 0x7ffaaf8a0230
        public void remove_OnEventScheduled(){} // RVA: 0x7ffaaf8a0330
        public void .ctor(){} // RVA: 0x7ffaaf8a0430
        public void ScheduleDelayedSecondsEvent(){} // RVA: 0x7ffaaf8a0d40
        public void ScheduleDelayedFramesEvent(){} // RVA: 0x7ffaaf8a0f30
        public void HasAnyPendingScheduledEvents(){} // RVA: 0x7ffaaf8a10e0
        public void RunScheduledEvents(){} // RVA: 0x7ffaaf8a11f0
        public void ClearScheduledEvents(){} // RVA: 0x7ffaaf8a1570
        public void ProcessTimeEvents(){} // RVA: 0x7ffaaf8a19d0
        public void ProcessFrameEvents(){} // RVA: 0x7ffaaf8a1b90
        public void CreateScheduledTimeEvent(){} // RVA: 0x7ffaaf8a1d50
        public void CreateScheduledFrameEvent(){} // RVA: 0x7ffaaf8a1e90
    }

    public class UdonVMTimeSource : Object
    {
        public object _currentTime; // 0x36122680, was: <CurrentTime>k__BackingField
        public object CurrentTime; // 0x17000001

        // ── Original Methods ──
        public void get_CurrentTime(){} // RVA: 0x7ffaa89357c0
        public void set_CurrentTime(){} // RVA: 0x7ffaa92bb750
        public void .ctor(){} // RVA: 0x7ffaafa5f0e0
        public void Dispose(){} // RVA: 0x7ffaafa5f410
        public void <.ctor>b__6_0(){} // RVA: 0x7ffaafa5f430
    }

}