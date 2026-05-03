// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Ben.BlockingDetector
// Classes: 9
// Methods: 39

namespace ThirdParty.Sentry.Sentry.Ben.BlockingDetector
{
    public class BlockingMonitor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00 | overloaded x2
        public void ShouldSkipFrame(){} // RVA: 0x7FFE86F8AE30
        public void BlockingStart(){} // RVA: 0x7FFE86F8AEE0
        public void BlockingEnd(){} // RVA: 0x7FFE86F8B430
    }

    public class DetectBlockingSynchronizationContext : SynchronizationContext
    {
        // ── Methods ──
        public void Suppress(){} // RVA: 0x7FFE86F8B4E0
        public void Restore(){} // RVA: 0x7FFE86F8B4F0
        public void .ctor(){} // RVA: 0x7FFE86F8B560 | overloaded x2
        public void Wait(){} // RVA: 0x7FFE86F8B640
        public void WaitInternal(){} // RVA: 0x7FFE86F8B770
    }

    public class IBlockingMonitor
    {
        // ── Methods ──
        public void BlockingStart(){} // RVA: 0x7FFE80E46530
        public void BlockingEnd(){} // RVA: 0x7FFE80E45FE0
    }

    public class IRecursionTracker
    {
        // ── Methods ──
        public void Recurse(){} // RVA: 0x7FFE80E45FE0
        public void Backtrack(){} // RVA: 0x7FFE80E45FE0
        public void IsFirstRecursion(){} // RVA: 0x7FFE80E2F150
    }

    public class ITaskBlockingListenerState
    {
        // ── Methods ──
        public void Suppress(){} // RVA: 0x7FFE80E45FE0
        public void IsSuppressed(){} // RVA: 0x7FFE80E2F150
        public void Restore(){} // RVA: 0x7FFE80E45FE0
    }

    public class StaticRecursionTracker : Object
    {
        // ── Methods ──
        public void Recurse(){} // RVA: 0x7FFE86F8B890
        public void Backtrack(){} // RVA: 0x7FFE86F8B960
        public void IsRecursive(){} // RVA: 0x7FFE86F8BA00
        public void IsFirstRecursion(){} // RVA: 0x7FFE86F8BA80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class StaticTaskBlockingListenerState : Object
    {
        // ── Methods ──
        public void Suppress(){} // RVA: 0x7FFE86F8BB00
        public void IsSuppressed(){} // RVA: 0x7FFE86F8BBD0
        public void Restore(){} // RVA: 0x7FFE86F8BC50
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SuppressBlockingDetection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F8BEB0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE86F8BFE0
    }

    public class TaskBlockingListener : EventListener
    {
        public System.Guid s_tplGuid;
        public Sentry.Ben.BlockingDetector.IBlockingMonitor _monitor; // 0x10

        // ── Methods ──
        public void get_LazyDefaultState(){} // RVA: 0x7FFE86F8C050
        public void get_DefaultState(){} // RVA: 0x7FFE86F8C0D0
        public void .ctor(){} // RVA: 0x7FFE86F8C2C0 | overloaded x2
        public void OnEventSourceCreated(){} // RVA: 0x7FFE86F8C3D0
        public void OnEventWritten(){} // RVA: 0x7FFE86F8C450
        public void DoHandleEvent(){} // RVA: 0x7FFE86F8C4F0
        public void .cctor(){} // RVA: 0x7FFE86F8C6A0
    }

}