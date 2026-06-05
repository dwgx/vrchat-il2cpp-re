// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.ClientBindings
// Classes: 3
// Methods: 28

namespace VRC.Udon.ClientBindings
{
    public class UdonClientInterface
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA1A3030 | overloaded x2
        public void get_DebugLogging(){} // RVA: 0x7FFAF2DB3450
        public void set_DebugLogging(){} // RVA: 0x7FFAF2DB3460
        public void ConstructUdonVM(){} // RVA: 0x7FFAFA1A33E0
        public void ApplyFilter(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFAFA1A3490
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFAFA1A34F0
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFAFA1A3540
        public void GetWrapper(){} // RVA: 0x7FFAFA1A35A0
    }

    public class UdonEventScheduler
    {
        // ── Methods ──
        public void add_OnEventScheduled(){} // RVA: 0x7FFAFA1A35F0
        public void remove_OnEventScheduled(){} // RVA: 0x7FFAFA1A36F0
        public void .ctor(){} // RVA: 0x7FFAFA1A37F0
        public void ScheduleDelayedSecondsEvent(){} // RVA: 0x7FFAFA1A4100
        public void ScheduleDelayedFramesEvent(){} // RVA: 0x7FFAFA1A42F0
        public void HasAnyPendingScheduledEvents(){} // RVA: 0x7FFAFA1A44A0
        public void RunScheduledEvents(){} // RVA: 0x7FFAFA1A45B0
        public void ClearScheduledEvents(){} // RVA: 0x7FFAFA1A4930
        public void ProcessTimeEvents(){} // RVA: 0x7FFAFA1A4D90
        public void ProcessFrameEvents(){} // RVA: 0x7FFAFA1A4F50
        public void CreateScheduledTimeEvent(){} // RVA: 0x7FFAFA1A5110
        public void CreateScheduledFrameEvent(){} // RVA: 0x7FFAFA1A5250
    }

    public class UdonVMTimeSource : get_CurrentTime
    {
        // ── Methods ──
        public void get_CurrentTime(){} // RVA: 0x7FFAF2D907C0
        public void set_CurrentTime(){} // RVA: 0x7FFAF370BE60
        public void .ctor(){} // RVA: 0x7FFAFA362490
        public void Dispose(){} // RVA: 0x7FFAFA3627C0
        public void <.ctor>b__6_0(){} // RVA: 0x7FFAFA3627E0
    }

}