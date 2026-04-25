// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.ClientBindings.Interfaces
// Classes: 2
// Methods: 5

namespace VRC.Udon.ClientBindings.Interfaces
{
    public class IUdonClientInterface
    {
        public object DebugLogging;

        // ── Methods ──
        public void get_DebugLogging(){} // RVA: 0x7FFAC2C59D00
        public void set_DebugLogging(){} // RVA: 0x7FFAC2C71060
    }

    public class IUdonEventSchedulerTimeSource
    {
        public object CurrentTime;
        public object CurrentFrame;
        public object MinimumDelay;

        // ── Methods ──
        public void get_CurrentTime(){} // RVA: 0x7FFAC2C5EB60
        public void get_CurrentFrame(){} // RVA: 0x7FFAC2C58E90
        public void get_MinimumDelay(){} // RVA: 0x7FFAC2C6D880
    }

}