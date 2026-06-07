// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.ClientBindings
// Classes: 3
// Methods: 28

namespace VRC.Udon.ClientBindings
{
    public class UdonClientInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76F3030 | overloaded x2
        public void get_DebugLogging(){} // RVA: 0x303450
        public void set_DebugLogging(){} // RVA: 0x303460
        public void ConstructUdonVM(){} // RVA: 0x76F33E0
        public void ApplyFilter(){} // RVA: 0x24B10 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x76F3490
        public void get_LightReservedLayerMask(){} // RVA: 0x76F34F0
        public void set_LightReservedLayerMask(){} // RVA: 0x76F3540
        public void GetWrapper(){} // RVA: 0x76F35A0
    }

    public class UdonEventScheduler
    {
        // ── Methods ──
        public void add_OnEventScheduled(){} // RVA: 0x76F35F0
        public void remove_OnEventScheduled(){} // RVA: 0x76F36F0
        public void .ctor(){} // RVA: 0x76F37F0
        public void ScheduleDelayedSecondsEvent(){} // RVA: 0x76F4100
        public void ScheduleDelayedFramesEvent(){} // RVA: 0x76F42F0
        public void HasAnyPendingScheduledEvents(){} // RVA: 0x76F44A0
        public void RunScheduledEvents(){} // RVA: 0x76F45B0
        public void ClearScheduledEvents(){} // RVA: 0x76F4930
        public void ProcessTimeEvents(){} // RVA: 0x76F4D90
        public void ProcessFrameEvents(){} // RVA: 0x76F4F50
        public void CreateScheduledTimeEvent(){} // RVA: 0x76F5110
        public void CreateScheduledFrameEvent(){} // RVA: 0x76F5250
    }

    public class UdonVMTimeSource : get_CurrentTime
    {
        // ── Methods ──
        public void get_CurrentTime(){} // RVA: 0x2E07C0
        public void set_CurrentTime(){} // RVA: 0xC5BE60
        public void .ctor(){} // RVA: 0x78B2490
        public void Dispose(){} // RVA: 0x78B27C0
        public void <.ctor>b__6_0(){} // RVA: 0x78B27E0
    }

}