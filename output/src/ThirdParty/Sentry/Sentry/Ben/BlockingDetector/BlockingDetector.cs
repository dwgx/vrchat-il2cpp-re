// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Ben.BlockingDetector
// Classes: 9
// Methods: 39

namespace ThirdParty.Sentry.Sentry.Ben.BlockingDetector
{
    public class BlockingMonitor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3BCE00 | overloaded x2
        public void ShouldSkipFrame(){} // RVA: 0x644A450
        public void BlockingStart(){} // RVA: 0x644A500
        public void BlockingEnd(){} // RVA: 0x644AA50
    }

    public class DetectBlockingSynchronizationContext
    {
        // ── Methods ──
        public void Suppress(){} // RVA: 0x644AB00
        public void Restore(){} // RVA: 0x644AB10
        public void .ctor(){} // RVA: 0x644AB80 | overloaded x2
        public void Wait(){} // RVA: 0x644AC60
        public void WaitInternal(){} // RVA: 0x644AD90
    }

    public class IBlockingMonitor
    {
        // ── Methods ──
        public void BlockingStart(){} // RVA: 0x24FA0
        public void BlockingEnd(){} // RVA: 0x24A50
    }

    public class IRecursionTracker
    {
        // ── Methods ──
        public void Recurse(){} // RVA: 0x24A50
        public void Backtrack(){} // RVA: 0x24A50
        public void IsFirstRecursion(){} // RVA: 0xDBE0
    }

    public class ITaskBlockingListenerState
    {
        // ── Methods ──
        public void Suppress(){} // RVA: 0x24A50
        public void IsSuppressed(){} // RVA: 0xDBE0
        public void Restore(){} // RVA: 0x24A50
    }

    public class OnStartedRecordingVideoCallback
    {
        // ── Methods ──
        public void Recurse(){} // RVA: 0x644AEB0
        public void Backtrack(){} // RVA: 0x644AF80
        public void IsRecursive(){} // RVA: 0x644B020
        public void IsFirstRecursion(){} // RVA: 0x644B0A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class OnStoppedRecordingVideoCallback
    {
        // ── Methods ──
        public void Suppress(){} // RVA: 0x644B120
        public void IsSuppressed(){} // RVA: 0x644B1F0
        public void Restore(){} // RVA: 0x644B270
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SuppressBlockingDetection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x644B4D0 | overloaded x2
        public void Dispose(){} // RVA: 0x644B600
    }

    public class TaskBlockingListener
    {
        // ── Methods ──
        public void get_LazyDefaultState(){} // RVA: 0x644B670
        public void get_DefaultState(){} // RVA: 0x644B6F0
        public void .ctor(){} // RVA: 0x644B8E0 | overloaded x2
        public void OnEventSourceCreated(){} // RVA: 0x644B9F0
        public void OnEventWritten(){} // RVA: 0x644BA70
        public void DoHandleEvent(){} // RVA: 0x644BB10
        public void .cctor(){} // RVA: 0x644BCC0
    }

}