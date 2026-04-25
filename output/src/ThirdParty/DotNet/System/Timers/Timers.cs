// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Timers
// Classes: 4
// Methods: 22

namespace ThirdParty.DotNet.System.Timers
{
    public class ElapsedEventArgs : EventArgs
    {
        public System.DateTime SignalTime; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9394B10
        public void get_SignalTime(){} // RVA: 0x7FFAC2F3C380
    }

    public class ElapsedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class Timer : Component
    {
        public double AutoReset; // 0x28
        public bool Enabled; // 0x30
        public bool Site; // 0x31
        public bool SynchronizingObject; // 0x32
        public System.Timers.ElapsedEventHandler onIntervalElapsed; // 0x38
        public bool autoReset; // 0x40
        public System.ComponentModel.ISynchronizeInvoke synchronizingObject; // 0x48
        public bool disposed; // 0x50
        public System.Threading.Timer timer; // 0x58
        public System.Threading.TimerCallback callback; // 0x60
        public object cookie; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9393BB0 | overloaded x2
        public void set_AutoReset(){} // RVA: 0x7FFAC9393DD0
        public void set_Enabled(){} // RVA: 0x7FFAC9393E60
        public void CalculateRoundedInterval(){} // RVA: 0x7FFAC93940A0
        public void UpdateTimer(){} // RVA: 0x7FFAC9394290
        public void add_Elapsed(){} // RVA: 0x7FFAC93942E0
        public void remove_Elapsed(){} // RVA: 0x7FFAC93943D0
        public void set_Site(){} // RVA: 0x7FFAC93944C0
        public void get_Site(){} // RVA: 0x7FFAC2F247C0
        public void get_SynchronizingObject(){} // RVA: 0x7FFAC9394560
        public void BeginInit(){} // RVA: 0x7FFAC9394720
        public void Close(){} // RVA: 0x7FFAC9394740
        public void Dispose(){} // RVA: 0x7FFAC93947F0
        public void EndInit(){} // RVA: 0x7FFAC9394830
        public void MyTimerCallback(){} // RVA: 0x7FFAC9394840
    }

    public class TimersDescriptionAttribute : DescriptionAttribute
    {
        public bool Description; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9394A70
        public void get_Description(){} // RVA: 0x7FFAC9393330
    }

}