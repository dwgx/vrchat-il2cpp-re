// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.Core
// Classes: 2
// Methods: 10

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.Core
{
    public class BaseVisionTaskApi : Object
    {
        public Mediapipe.Tasks.Core.TaskRunner runningMode; // 0x10
        public 0x6B215EC0 <runningMode>k__BackingField; // 0x18
        public bool _isClosed; // 0x1C

        // ── Methods ──
        public void get_runningMode(){} // RVA: 0x7FFAC3157800
        public void .ctor(){} // RVA: 0x7FFAC82EF3B0
        public void ProcessImageData(){} // RVA: 0x7FFAC82EF690
        public void ProcessVideoData(){} // RVA: 0x7FFAC82EF750
        public void SendLiveStreamData(){} // RVA: 0x7FFAC82EF810
        public void ResetNormalizedRect(){} // RVA: 0x7FFAC82EF9F0
        public void ConfigureNormalizedRect(){} // RVA: 0x7FFAC82EFA30
        public void Close(){} // RVA: 0x7FFAC82EFE00
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC82EFF30
    }

    public class ImageProcessingOptions : ValueType
    {
        public System.Nullable`1<Mediapipe.Tasks.Components.Containers.RectF> regionOfInterest; // 0x10
        public int rotationDegrees; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC82F0150
    }

}