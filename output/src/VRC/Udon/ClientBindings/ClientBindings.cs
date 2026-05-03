// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.ClientBindings
// Classes: 3
// Methods: 28

namespace VRC.Udon.ClientBindings
{
    public class UdonClientInterface : Object
    {
        public VRC.Udon.Common.Interfaces.IUdonVMFactory _udonVMFactory; // 0x10
        public VRC.Udon.ClientBindings.UdonVMTimeSource _udonVMTimeSource; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8822FCE0 | overloaded x2
        public void get_DebugLogging(){} // RVA: 0x7FFE81121450
        public void set_DebugLogging(){} // RVA: 0x7FFE81121460
        public void ConstructUdonVM(){} // RVA: 0x7FFE88230090
        public void ApplyFilter(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFE88230140
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFE882301A0
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFE882301F0
        public void GetWrapper(){} // RVA: 0x7FFE88230250
    }

    public class UdonEventScheduler : Object
    {
        // ── Methods ──
        public void add_OnEventScheduled(){} // RVA: 0x7FFE882302A0
        public void remove_OnEventScheduled(){} // RVA: 0x7FFE882303A0
        public void .ctor(){} // RVA: 0x7FFE882304A0
        public void ScheduleDelayedSecondsEvent(){} // RVA: 0x7FFE88230DB0
        public void ScheduleDelayedFramesEvent(){} // RVA: 0x7FFE88230FA0
        public void HasAnyPendingScheduledEvents(){} // RVA: 0x7FFE88231150
        public void RunScheduledEvents(){} // RVA: 0x7FFE88231260
        public void ClearScheduledEvents(){} // RVA: 0x7FFE882315E0
        public void ProcessTimeEvents(){} // RVA: 0x7FFE88231A40
        public void ProcessFrameEvents(){} // RVA: 0x7FFE88231C00
        public void CreateScheduledTimeEvent(){} // RVA: 0x7FFE88231DC0
        public void CreateScheduledFrameEvent(){} // RVA: 0x7FFE88231F00
    }

    public class UdonVMTimeSource : Object
    {
        public long INTERVAL_MS;

        // ── Methods ──
        public void get_CurrentTime(){} // RVA: 0x7FFE810FE7C0
        public void set_CurrentTime(){} // RVA: 0x7FFE819EA910
        public void .ctor(){} // RVA: 0x7FFE883EF170
        public void Dispose(){} // RVA: 0x7FFE883EF4A0
        public void <.ctor>b__6_0(){} // RVA: 0x7FFE883EF4C0
    }

}