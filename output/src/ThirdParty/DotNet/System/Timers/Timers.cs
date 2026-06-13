// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Timers
// Classes: 4
// Methods: 22

namespace ThirdParty.DotNet.System.Timers
{
    public class ElapsedEventArgs
    {
        public System.DateTime InvokeRequired; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BFC390
        public void get_SignalTime(){} // RVA: 0x2F8380
    }

    public class ElapsedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class Timer
    {
        public double interval; // 0x28
        public bool enabled; // 0x30
        public bool initializing; // 0x31
        public bool delayedEnable; // 0x32

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BFB430 | overloaded x2
        public void set_AutoReset(){} // RVA: 0x6BFB650
        public void set_Enabled(){} // RVA: 0x6BFB6E0
        public void CalculateRoundedInterval(){} // RVA: 0x6BFB920
        public void UpdateTimer(){} // RVA: 0x6BFBB10
        public void add_Elapsed(){} // RVA: 0x6BFBB60
        public void remove_Elapsed(){} // RVA: 0x6BFBC50
        public void set_Site(){} // RVA: 0x6BFBD40
        public void get_Site(){} // RVA: 0x2E07C0
        public void get_SynchronizingObject(){} // RVA: 0x6BFBDE0
        public void BeginInit(){} // RVA: 0x6BFBFA0
        public void Close(){} // RVA: 0x6BFBFC0
        public void Dispose(){} // RVA: 0x6BFC070
        public void EndInit(){} // RVA: 0x6BFC0B0
        public void MyTimerCallback(){} // RVA: 0x6BFC0C0
    }

    public class TimersDescriptionAttribute
    {
        public bool replaced; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BFC2F0
        public void get_Description(){} // RVA: 0x6BFABB0
    }

}