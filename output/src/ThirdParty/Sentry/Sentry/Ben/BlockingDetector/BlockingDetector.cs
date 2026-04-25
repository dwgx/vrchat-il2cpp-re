// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Ben.BlockingDetector
// Classes: 9
// Methods: 39

namespace ThirdParty.Sentry.Sentry.Ben.BlockingDetector
{
    public class BlockingMonitor : Object
    {
        public System.Func`1<Sentry.IHub> _getHub; // 0x10
        public Sentry.SentryOptions _options; // 0x18
        public Sentry.Ben.BlockingDetector.IRecursionTracker _recursionTracker; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00 | overloaded x2
        public void ShouldSkipFrame(){} // RVA: 0x7FFAC8BE17D0
        public void BlockingStart(){} // RVA: 0x7FFAC8BE1880
        public void BlockingEnd(){} // RVA: 0x7FFAC8BE1DD0
    }

    public class DetectBlockingSynchronizationContext : SynchronizationContext
    {
        public Sentry.Ben.BlockingDetector.IBlockingMonitor _monitor; // 0x18
        public System.Threading.SynchronizationContext _syncCtx; // 0x20
        public int _isSuppressed; // 0x28

        // ── Methods ──
        public void Suppress(){} // RVA: 0x7FFAC8BE1E80
        public void Restore(){} // RVA: 0x7FFAC8BE1E90
        public void .ctor(){} // RVA: 0x7FFAC8BE1F00 | overloaded x2
        public void Wait(){} // RVA: 0x7FFAC8BE1FE0
        public void WaitInternal(){} // RVA: 0x7FFAC8BE2110
    }

    public class IBlockingMonitor
    {
        // ── Methods ──
        public void BlockingStart(){} // RVA: 0x7FFAC2C70ED0
        public void BlockingEnd(){} // RVA: 0x7FFAC2C70980
    }

    public class IRecursionTracker
    {
        // ── Methods ──
        public void Recurse(){} // RVA: 0x7FFAC2C70980
        public void Backtrack(){} // RVA: 0x7FFAC2C70980
        public void IsFirstRecursion(){} // RVA: 0x7FFAC2C59D00
    }

    public class ITaskBlockingListenerState
    {
        // ── Methods ──
        public void Suppress(){} // RVA: 0x7FFAC2C70980
        public void IsSuppressed(){} // RVA: 0x7FFAC2C59D00
        public void Restore(){} // RVA: 0x7FFAC2C70980
    }

    public class StaticRecursionTracker : Object
    {
        public int RecursionCount; // 0xFFFF

        // ── Methods ──
        public void Recurse(){} // RVA: 0x7FFAC8BE2230
        public void Backtrack(){} // RVA: 0x7FFAC8BE2300
        public void IsRecursive(){} // RVA: 0x7FFAC8BE23A0
        public void IsFirstRecursion(){} // RVA: 0x7FFAC8BE2420
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StaticTaskBlockingListenerState : Object
    {
        public int SuppressionCount; // 0xFFFF

        // ── Methods ──
        public void Suppress(){} // RVA: 0x7FFAC8BE24A0
        public void IsSuppressed(){} // RVA: 0x7FFAC8BE2570
        public void Restore(){} // RVA: 0x7FFAC8BE25F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SuppressBlockingDetection : Object
    {
        public Sentry.Ben.BlockingDetector.ITaskBlockingListenerState _listener; // 0x10
        public Sentry.Ben.BlockingDetector.DetectBlockingSynchronizationContext _context; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BE2850 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC8BE2980
    }

    public class TaskBlockingListener : EventListener
    {
        public System.Guid LazyDefaultState;
        public Sentry.Ben.BlockingDetector.IBlockingMonitor DefaultState; // 0x10
        public Sentry.Ben.BlockingDetector.ITaskBlockingListenerState _state; // 0x18

        // ── Methods ──
        public void get_LazyDefaultState(){} // RVA: 0x7FFAC8BE29F0
        public void get_DefaultState(){} // RVA: 0x7FFAC8BE2A70
        public void .ctor(){} // RVA: 0x7FFAC8BE2C60 | overloaded x2
        public void OnEventSourceCreated(){} // RVA: 0x7FFAC8BE2D70
        public void OnEventWritten(){} // RVA: 0x7FFAC8BE2DF0
        public void DoHandleEvent(){} // RVA: 0x7FFAC8BE2E90
        public void .cctor(){} // RVA: 0x7FFAC8BE3040
    }

}