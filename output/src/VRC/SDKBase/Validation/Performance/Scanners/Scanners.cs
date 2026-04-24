// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation.Performance.Scanners
// Classes: 1
// Methods: 7

namespace VRC.SDKBase.Validation.Performance.Scanners
{
    public class AbstractPerformanceScanner : Object
    {
        public int MAXIMUM_COMPONENT_SCANS_PER_FRAME;
        public int _componentScansThisFrame;
        public int _componentScansFrameNumber; // 0x4
        public System.Collections.Generic.Stack`1<System.Collections.IEnumerator> _coroutines; // 0x10
        public bool _limitComponentScansPerFrame; // 0x18

        // ── Methods ──
        public void RunPerformanceScanEnumerator(){} // RVA: 0x7FFD4E08AE80
        public void RunPerformanceScan(){} // RVA: 0x7FFD574B1360
        public void ScanAvatarForComponentsOfType(){} // RVA: 0x7FFD4E08A6F0 | overloaded x2
        public void HandleComponentScansPerFrameLimit(){} // RVA: 0x7FFD574B17D0
        public void EnabledOnPlatform(){} // RVA: 0x7FFD4E426850
        public void .ctor(){} // RVA: 0x7FFD574B1870
    }

}