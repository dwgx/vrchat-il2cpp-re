// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Timers
// Classes: 3
// Methods: 20

namespace ThirdParty.DotNet.System.Timers
{
    public class ElapsedEventArgs : EventArgs
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedb6ae0
        public void get_SignalTime(){} // RVA: 0x7ffaa894d380
    }

    public class ElapsedEventHandler : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9fdcf70
        public void Invoke(){} // RVA: 0x7ffaa8a8e370
    }

    public class Timer : Component
    {
        public object initializing; // 0x366FB260
        public object autoReset; // 0x366FB260
        public object timer; // 0x366FB260

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaedb5b80
        public void .ctor(){} // RVA: 0x7ffaaedb5b80
        public void set_AutoReset(){} // RVA: 0x7ffaaedb5da0
        public void set_Enabled(){} // RVA: 0x7ffaaedb5e30
        public void CalculateRoundedInterval(){} // RVA: 0x7ffaaedb6070
        public void UpdateTimer(){} // RVA: 0x7ffaaedb6260
        public void add_Elapsed(){} // RVA: 0x7ffaaedb62b0
        public void remove_Elapsed(){} // RVA: 0x7ffaaedb63a0
        public void set_Site(){} // RVA: 0x7ffaaedb6490
        public void get_Site(){} // RVA: 0x7ffaa89357c0
        public void get_SynchronizingObject(){} // RVA: 0x7ffaaedb6530
        public void Close(){} // RVA: 0x7ffaaedb6710
        public void Dispose(){} // RVA: 0x7ffaaedb67c0
        public void EndInit(){} // RVA: 0x7ffaaedb6800
        public void MyTimerCallback(){} // RVA: 0x7ffaaedb6810
        // ── Binary Analysis Named ──
        public void BeginInit(){} // RVA: 0x7ffaaedb66f0
    }

}