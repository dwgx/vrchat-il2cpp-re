// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.ClientBindings
// Classes: 3
// Methods: 28

namespace VRC.Udon.ClientBindings
{
    public class UdonClientInterface : Object
    {
        public VRC.Udon.Common.Interfaces.IUdonVMFactory DebugLogging; // 0x10
        public VRC.Udon.ClientBindings.UdonVMTimeSource LightReservedLayerMask; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> filter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonWrapperFactory wrapperFactory; // 0x28
        public bool <DebugLogging>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5529D250 | overloaded x2
        public void get_DebugLogging(){} // RVA: 0x7FFD4E367450
        public void set_DebugLogging(){} // RVA: 0x7FFD4E367460
        public void ConstructUdonVM(){} // RVA: 0x7FFD5529D600
        public void ApplyFilter(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFD5529D6B0
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFD5529D710
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFD5529D760
        public void GetWrapper(){} // RVA: 0x7FFD5529D7C0
    }

    public class UdonEventScheduler : Object
    {
        public long _nextEventId; // 0x10
        public 0x66643710 _timeSource; // 0x18
        public System.Action`1<ÌÏÌÍÏ> OnEventScheduled; // 0x20
        public System.Collections.Generic.Dictionary`2<ÌÏÌÍÏ,System.Collections.Generic.SortedSet`1<ScheduledTimeEvent>> _timeEventQueues; // 0x28
        public System.Collections.Generic.Dictionary`2<ÌÏÌÍÏ,System.Collections.Generic.SortedSet`1<ScheduledFrameEvent>> _frameEventQueues; // 0x30

        // ── Methods ──
        public void add_OnEventScheduled(){} // RVA: 0x7FFD5529D810
        public void remove_OnEventScheduled(){} // RVA: 0x7FFD5529D910
        public void .ctor(){} // RVA: 0x7FFD5529DA10
        public void ScheduleDelayedSecondsEvent(){} // RVA: 0x7FFD5529E320
        public void ScheduleDelayedFramesEvent(){} // RVA: 0x7FFD5529E510
        public void HasAnyPendingScheduledEvents(){} // RVA: 0x7FFD5529E6C0
        public void RunScheduledEvents(){} // RVA: 0x7FFD5529E7D0
        public void ClearScheduledEvents(){} // RVA: 0x7FFD5529EB50
        public void ProcessTimeEvents(){} // RVA: 0x7FFD5529EFB0
        public void ProcessFrameEvents(){} // RVA: 0x7FFD5529F170
        public void CreateScheduledTimeEvent(){} // RVA: 0x7FFD5529F330
        public void CreateScheduledFrameEvent(){} // RVA: 0x7FFD5529F470
    }

    public class UdonVMTimeSource : Object
    {
        public long CurrentTime;
        public System.Timers.Timer _timer; // 0x10
        public long <CurrentTime>k__BackingField; // 0x18

        // ── Methods ──
        public void get_CurrentTime(){} // RVA: 0x7FFD4E3447C0
        public void set_CurrentTime(){} // RVA: 0x7FFD4ECB20D0
        public void .ctor(){} // RVA: 0x7FFD5545C6C0
        public void Dispose(){} // RVA: 0x7FFD5545C9F0
        public void <.ctor>b__6_0(){} // RVA: 0x7FFD5545CA10
    }

}