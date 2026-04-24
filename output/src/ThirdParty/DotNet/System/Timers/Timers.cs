// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Timers
// Classes: 3
// Methods: 20

namespace ThirdParty.DotNet.System.Timers
{
    public class ElapsedEventArgs : EventArgs
    {
        public System.DateTime SignalTime; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD547B4B10
        public void get_SignalTime(){} // RVA: 0x7FFD4E35C380
    }

    public class ElapsedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F9D91D0
        public void Invoke(){} // RVA: 0x7FFD4E49D370
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
        public void .ctor(){} // RVA: 0x7FFD547B3BB0 | overloaded x2
        public void set_AutoReset(){} // RVA: 0x7FFD547B3DD0
        public void set_Enabled(){} // RVA: 0x7FFD547B3E60
        public void CalculateRoundedInterval(){} // RVA: 0x7FFD547B40A0
        public void UpdateTimer(){} // RVA: 0x7FFD547B4290
        public void add_Elapsed(){} // RVA: 0x7FFD547B42E0
        public void remove_Elapsed(){} // RVA: 0x7FFD547B43D0
        public void set_Site(){} // RVA: 0x7FFD547B44C0
        public void get_Site(){} // RVA: 0x7FFD4E3447C0
        public void get_SynchronizingObject(){} // RVA: 0x7FFD547B4560
        public void BeginInit(){} // RVA: 0x7FFD547B4720
        public void Close(){} // RVA: 0x7FFD547B4740
        public void Dispose(){} // RVA: 0x7FFD547B47F0
        public void EndInit(){} // RVA: 0x7FFD547B4830
        public void MyTimerCallback(){} // RVA: 0x7FFD547B4840
    }

}