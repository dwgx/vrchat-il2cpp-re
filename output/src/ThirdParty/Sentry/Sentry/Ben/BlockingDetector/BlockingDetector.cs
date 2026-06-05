// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Ben.BlockingDetector
// Classes: 9
// Methods: 39

namespace ThirdParty.Sentry.Sentry.Ben.BlockingDetector
{
    public class BlockingMonitor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E6CE00 | overloaded x2
        public void ShouldSkipFrame(){} // RVA: 0x7FFAF8EFA450
        public void BlockingStart(){} // RVA: 0x7FFAF8EFA500
        public void BlockingEnd(){} // RVA: 0x7FFAF8EFAA50
    }

    public class DetectBlockingSynchronizationContext
    {
        // ── Methods ──
        public void Suppress(){} // RVA: 0x7FFAF8EFAB00
        public void Restore(){} // RVA: 0x7FFAF8EFAB10
        public void .ctor(){} // RVA: 0x7FFAF8EFAB80 | overloaded x2
        public void Wait(){} // RVA: 0x7FFAF8EFAC60
        public void WaitInternal(){} // RVA: 0x7FFAF8EFAD90
    }

    public class IBlockingMonitor
    {
        // ── Methods ──
        public void BlockingStart(){} // RVA: 0x7FFAF2AD4FA0
        public void BlockingEnd(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IRecursionTracker
    {
        // ── Methods ──
        public void Recurse(){} // RVA: 0x7FFAF2AD4A50
        public void Backtrack(){} // RVA: 0x7FFAF2AD4A50
        public void IsFirstRecursion(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class ITaskBlockingListenerState
    {
        // ── Methods ──
        public void Suppress(){} // RVA: 0x7FFAF2AD4A50
        public void IsSuppressed(){} // RVA: 0x7FFAF2ABDBE0
        public void Restore(){} // RVA: 0x7FFAF2AD4A50
    }

    public class OnStartedRecordingVideoCallback
    {
        // ── Methods ──
        public void Recurse(){} // RVA: 0x7FFAF8EFAEB0
        public void Backtrack(){} // RVA: 0x7FFAF8EFAF80
        public void IsRecursive(){} // RVA: 0x7FFAF8EFB020
        public void IsFirstRecursion(){} // RVA: 0x7FFAF8EFB0A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class OnStoppedRecordingVideoCallback
    {
        // ── Methods ──
        public void Suppress(){} // RVA: 0x7FFAF8EFB120
        public void IsSuppressed(){} // RVA: 0x7FFAF8EFB1F0
        public void Restore(){} // RVA: 0x7FFAF8EFB270
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SuppressBlockingDetection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8EFB4D0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF8EFB600
    }

    public class TaskBlockingListener
    {
        // ── Methods ──
        public void get_LazyDefaultState(){} // RVA: 0x7FFAF8EFB670
        public void get_DefaultState(){} // RVA: 0x7FFAF8EFB6F0
        public void .ctor(){} // RVA: 0x7FFAF8EFB8E0 | overloaded x2
        public void OnEventSourceCreated(){} // RVA: 0x7FFAF8EFB9F0
        public void OnEventWritten(){} // RVA: 0x7FFAF8EFBA70
        public void DoHandleEvent(){} // RVA: 0x7FFAF8EFBB10
        public void .cctor(){} // RVA: 0x7FFAF8EFBCC0
    }

}