// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Timers
// Classes: 4
// Methods: 21

namespace ThirdParty.DotNet.System.Timers
{
    public class ElapsedEventArgs : EventArgs
    {
        public object time;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x765D4A0
        public void get_SignalTime(){} // RVA: 0xB5DBF0
    }

    public class ElapsedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class Timer : Component
    {
        public object interval;
        public object enabled;
        public object initializing;
        public object delayedEnable;
        public object onIntervalElapsed;
        public object autoReset;
        public object synchronizingObject;
        public object disposed;
        public object timer;
        public object callback;
        public object cookie;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x765C4F0
        public void set_AutoReset(){} // RVA: 0x765C710
        public void set_Enabled(){} // RVA: 0x765C7A0
        public void CalculateRoundedInterval(){} // RVA: 0x765CA30
        public void UpdateTimer(){} // RVA: 0x765CC10
        public void add_Elapsed(){} // RVA: 0x765CC60
        public void remove_Elapsed(){} // RVA: 0x765CD50
        public void set_Site(){} // RVA: 0x765CE40
        public void get_Site(){} // RVA: 0xB465B0
        public void get_SynchronizingObject(){} // RVA: 0x765CEE0
        public void BeginInit(){} // RVA: 0x765D0B0
        public void Close(){} // RVA: 0x765D0D0
        public void Dispose(){} // RVA: 0x765D180
        public void EndInit(){} // RVA: 0x765D1C0
        public void MyTimerCallback(){} // RVA: 0x765D1D0
    }

    public class TimersDescriptionAttribute : DescriptionAttribute
    {
        public object replaced;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x765D400
        public void get_Description(){} // RVA: 0x765BBE0
    }

}