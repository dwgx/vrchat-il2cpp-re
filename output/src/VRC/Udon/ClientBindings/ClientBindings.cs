// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.ClientBindings
// Classes: 3
// Methods: 26

namespace VRC.Udon.ClientBindings
{
    public class UdonClientInterface : Object
    {
        public object _udonVMFactory;
        public object _udonVMTimeSource;
        public object filter;
        public object wrapperFactory;
        public object _debugLogging;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8331F60
        public void get_DebugLogging(){} // RVA: 0xB68DF0
        public void set_DebugLogging(){} // RVA: 0xB68E00
        public void ConstructUdonVM(){} // RVA: 0x8332320
        public void ApplyFilter(){} // RVA: 0x894320
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x83323D0
        public void get_LightReservedLayerMask(){} // RVA: 0x8332430
        public void set_LightReservedLayerMask(){} // RVA: 0x8332480
        public void GetWrapper(){} // RVA: 0x83324E0
    }

    public class UdonEventScheduler : Object
    {
        public object _nextEventId;
        public object _timeSource;
        public object OnEventScheduled;
        public object _timeEventQueues;
        public object _frameEventQueues;

        // ── Methods ──
        public void add_OnEventScheduled(){} // RVA: 0x8332530
        public void remove_OnEventScheduled(){} // RVA: 0x8332640
        public void .ctor(){} // RVA: 0x8332750
        public void ScheduleDelayedSecondsEvent(){} // RVA: 0x8333060
        public void ScheduleDelayedFramesEvent(){} // RVA: 0x8333250
        public void HasAnyPendingScheduledEvents(){} // RVA: 0x8333400
        public void RunScheduledEvents(){} // RVA: 0x8333510
        public void ClearScheduledEvents(){} // RVA: 0x8333890
        public void ProcessTimeEvents(){} // RVA: 0x8333D10
        public void ProcessFrameEvents(){} // RVA: 0x8333ED0
        public void CreateScheduledTimeEvent(){} // RVA: 0x8334090
        public void CreateScheduledFrameEvent(){} // RVA: 0x83341D0
    }

    public class UdonVMTimeSource : Object
    {
        public object INTERVAL_MS;
        public object _timer;
        public object _currentTime;

        // ── Methods ──
        public void get_CurrentTime(){} // RVA: 0xB465B0
        public void set_CurrentTime(){} // RVA: 0x15428E0
        public void .ctor(){} // RVA: 0x84EC950
        public void Dispose(){} // RVA: 0x84ECC80
        public void <.ctor>b__6_0(){} // RVA: 0x84ECCA0
    }

}