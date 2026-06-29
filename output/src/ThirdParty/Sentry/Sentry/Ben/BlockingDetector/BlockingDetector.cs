// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Ben.BlockingDetector
// Classes: 9
// Methods: 35

namespace ThirdParty.Sentry.Sentry.Ben.BlockingDetector
{
    public class BlockingMonitor : Object
    {
        public object _getHub;
        public object _options;
        public object _recursionTracker;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
        public void ShouldSkipFrame(){} // RVA: 0x6EBAF00
        public void BlockingStart(){} // RVA: 0x6EBAFB0
        public void BlockingEnd(){} // RVA: 0x6EBB500
    }

    public class DetectBlockingSynchronizationContext : SynchronizationContext
    {
        public object _monitor;
        public object _syncCtx;
        public object _isSuppressed;

        // ── Methods ──
        public void Suppress(){} // RVA: 0x6EBB5B0
        public void Restore(){} // RVA: 0x6EBB5C0
        public void .ctor(){} // RVA: 0x6EBB630
        public void Wait(){} // RVA: 0x6EBB710
        public void WaitInternal(){} // RVA: 0x6EBB840
    }

    public class IBlockingMonitor
    {
        // ── Methods ──
        public void BlockingStart(){} // RVA: 0x8944F0
        public void BlockingEnd(){} // RVA: 0x894290
    }

    public class IRecursionTracker
    {
        // ── Methods ──
        public void Recurse(){} // RVA: 0x894290
        public void Backtrack(){} // RVA: 0x894290
        public void IsFirstRecursion(){} // RVA: 0x87D280
    }

    public class ITaskBlockingListenerState
    {
        // ── Methods ──
        public void Suppress(){} // RVA: 0x894290
        public void IsSuppressed(){} // RVA: 0x87D280
        public void Restore(){} // RVA: 0x894290
    }

    public class OnStartedRecordingVideoCallback : Object
    {
        public object RecursionCount;

        // ── Methods ──
        public void Recurse(){} // RVA: 0x6EBB960
        public void Backtrack(){} // RVA: 0x6EBBA30
        public void IsRecursive(){} // RVA: 0x6EBBAD0
        public void IsFirstRecursion(){} // RVA: 0x6EBBB50
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OnStoppedRecordingVideoCallback : Object
    {
        public object SuppressionCount;

        // ── Methods ──
        public void Suppress(){} // RVA: 0x6EBBBD0
        public void IsSuppressed(){} // RVA: 0x6EBBCA0
        public void Restore(){} // RVA: 0x6EBBD20
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SuppressBlockingDetection : Object
    {
        public object _listener;
        public object _context;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EBBF80
        public void Dispose(){} // RVA: 0x6EBC0B0
    }

    public class TaskBlockingListener : EventListener
    {
        public object s_tplGuid;
        public object _monitor;
        public object _state;

        // ── Methods ──
        public void get_LazyDefaultState(){} // RVA: 0x6EBC120
        public void get_DefaultState(){} // RVA: 0x6EBC1A0
        public void .ctor(){} // RVA: 0x6EBC390
        public void OnEventSourceCreated(){} // RVA: 0x6EBC4A0
        public void OnEventWritten(){} // RVA: 0x6EBC520
        public void DoHandleEvent(){} // RVA: 0x6EBC5C0
        public void .cctor(){} // RVA: 0x6EBC760
    }

}