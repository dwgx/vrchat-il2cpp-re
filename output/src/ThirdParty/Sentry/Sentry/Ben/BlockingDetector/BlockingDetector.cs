// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Ben.BlockingDetector
// Classes: 9
// Methods: 35

namespace ThirdParty.Sentry.Sentry.Ben.BlockingDetector
{
    public class BlockingMonitor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void ShouldSkipFrame(){} // RVA: 0x7AE2383D0
        public void BlockingStart(){} // RVA: 0x7AE238480
        public void BlockingEnd(){} // RVA: 0x7AE2389D0
    }

    public class DetectBlockingSynchronizationContext : SynchronizationContext
    {
        // ── Methods ──
        public void Suppress(){} // RVA: 0x7AE238A80
        public void Restore(){} // RVA: 0x7AE238A90
        public void .ctor(){} // RVA: 0x7AE238B00
        public void Wait(){} // RVA: 0x7AE238BE0
        public void WaitInternal(){} // RVA: 0x7AE238D10
    }

    public class IBlockingMonitor
    {
        // ── Methods ──
        public void BlockingStart(){} // RVA: 0x7A7E189D0
        public void BlockingEnd(){} // RVA: 0x7A7E18770
    }

    public class IRecursionTracker
    {
        // ── Methods ──
        public void Recurse(){} // RVA: 0x7A7E18770
        public void Backtrack(){} // RVA: 0x7A7E18770
        public void IsFirstRecursion(){} // RVA: 0x7A7E01900
    }

    public class ITaskBlockingListenerState
    {
        // ── Methods ──
        public void Suppress(){} // RVA: 0x7A7E18770
        public void IsSuppressed(){} // RVA: 0x7A7E01900
        public void Restore(){} // RVA: 0x7A7E18770
    }

    public class OnStartedRecordingVideoCallback : Object
    {
        // ── Methods ──
        public void Recurse(){} // RVA: 0x7AE238E30
        public void Backtrack(){} // RVA: 0x7AE238F00
        public void IsRecursive(){} // RVA: 0x7AE238FA0
        public void IsFirstRecursion(){} // RVA: 0x7AE239020
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class OnStoppedRecordingVideoCallback : Object
    {
        // ── Methods ──
        public void Suppress(){} // RVA: 0x7AE2390A0
        public void IsSuppressed(){} // RVA: 0x7AE239170
        public void Restore(){} // RVA: 0x7AE2391F0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SuppressBlockingDetection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE239450
        public void Dispose(){} // RVA: 0x7AE239580
    }

    public class TaskBlockingListener : EventListener
    {
        // ── Methods ──
        public void get_LazyDefaultState(){} // RVA: 0x7AE2395F0
        public void get_DefaultState(){} // RVA: 0x7AE239670
        public void .ctor(){} // RVA: 0x7AE239860
        public void OnEventSourceCreated(){} // RVA: 0x7AE239970
        public void OnEventWritten(){} // RVA: 0x7AE2399F0
        public void DoHandleEvent(){} // RVA: 0x7AE239A90
        public void .cctor(){} // RVA: 0x7AE239C40
    }

}