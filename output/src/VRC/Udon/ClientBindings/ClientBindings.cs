// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.ClientBindings
// Classes: 3
// Methods: 26

namespace VRC.Udon.ClientBindings
{
    public class UdonClientInterface : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF4D2060
        public void get_DebugLogging(){} // RVA: 0x7A80FD690
        public void set_DebugLogging(){} // RVA: 0x7A80FD6A0
        public void ConstructUdonVM(){} // RVA: 0x7AF4D2420
        public void ApplyFilter(){} // RVA: 0x7A7E18800
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7AF4D24D0
        public void get_LightReservedLayerMask(){} // RVA: 0x7AF4D2530
        public void set_LightReservedLayerMask(){} // RVA: 0x7AF4D2580
        public void GetWrapper(){} // RVA: 0x7AF4D25E0
    }

    public class UdonEventScheduler : Object
    {
        // ── Methods ──
        public void add_OnEventScheduled(){} // RVA: 0x7AF4D2630
        public void remove_OnEventScheduled(){} // RVA: 0x7AF4D2740
        public void .ctor(){} // RVA: 0x7AF4D2850
        public void ScheduleDelayedSecondsEvent(){} // RVA: 0x7AF4D3160
        public void ScheduleDelayedFramesEvent(){} // RVA: 0x7AF4D3350
        public void HasAnyPendingScheduledEvents(){} // RVA: 0x7AF4D3500
        public void RunScheduledEvents(){} // RVA: 0x7AF4D3610
        public void ClearScheduledEvents(){} // RVA: 0x7AF4D3990
        public void ProcessTimeEvents(){} // RVA: 0x7AF4D3E10
        public void ProcessFrameEvents(){} // RVA: 0x7AF4D3FD0
        public void CreateScheduledTimeEvent(){} // RVA: 0x7AF4D4190
        public void CreateScheduledFrameEvent(){} // RVA: 0x7AF4D42D0
    }

    public class UdonVMTimeSource : Object
    {
        // ── Methods ──
        public void get_CurrentTime(){} // RVA: 0x7A80DA7B0
        public void set_CurrentTime(){} // RVA: 0x7A8A224D0
        public void .ctor(){} // RVA: 0x7AF691260
        public void Dispose(){} // RVA: 0x7AF691590
        public void <.ctor>b__6_0(){} // RVA: 0x7AF6915B0
    }

}