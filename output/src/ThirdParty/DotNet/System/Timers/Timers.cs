// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Timers
// Classes: 4
// Methods: 22

namespace ThirdParty.DotNet.System.Timers
{
    public class ElapsedEventArgs : EventArgs
    {
        public System.DateTime time; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8773D240
        public void get_SignalTime(){} // RVA: 0x7FFE81116380
    }

    public class ElapsedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class Timer : Component
    {
        public double interval; // 0x28
        public bool enabled; // 0x30
        public bool initializing; // 0x31
        public bool delayedEnable; // 0x32

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8773C2E0 | overloaded x2
        public void set_AutoReset(){} // RVA: 0x7FFE8773C500
        public void set_Enabled(){} // RVA: 0x7FFE8773C590
        public void CalculateRoundedInterval(){} // RVA: 0x7FFE8773C7D0
        public void UpdateTimer(){} // RVA: 0x7FFE8773C9C0
        public void add_Elapsed(){} // RVA: 0x7FFE8773CA10
        public void remove_Elapsed(){} // RVA: 0x7FFE8773CB00
        public void set_Site(){} // RVA: 0x7FFE8773CBF0
        public void get_Site(){} // RVA: 0x7FFE810FE7C0
        public void get_SynchronizingObject(){} // RVA: 0x7FFE8773CC90
        public void BeginInit(){} // RVA: 0x7FFE8773CE50
        public void Close(){} // RVA: 0x7FFE8773CE70
        public void Dispose(){} // RVA: 0x7FFE8773CF20
        public void EndInit(){} // RVA: 0x7FFE8773CF60
        public void MyTimerCallback(){} // RVA: 0x7FFE8773CF70
    }

    public class TimersDescriptionAttribute : DescriptionAttribute
    {
        public bool replaced; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8773D1A0
        public void get_Description(){} // RVA: 0x7FFE8773BA60
    }

}