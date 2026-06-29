// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.Core
// Classes: 2
// Methods: 10

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.Core
{
    public class BaseVisionTaskApi : Object
    {
        public object _taskRunner;
        public object _runningMode;
        public object _isClosed;

        // ── Methods ──
        public void get_runningMode(){} // RVA: 0xE62D00
        public void .ctor(){} // RVA: 0x65D2240
        public void ProcessImageData(){} // RVA: 0x65D2520
        public void ProcessVideoData(){} // RVA: 0x65D25E0
        public void SendLiveStreamData(){} // RVA: 0x65D26A0
        public void ResetNormalizedRect(){} // RVA: 0x65D2880
        public void ConfigureNormalizedRect(){} // RVA: 0x65D28C0
        public void Close(){} // RVA: 0x65D2C90
        public void System.IDisposable.Dispose(){} // RVA: 0x65D2DC0
    }

    public class ImageProcessingOptions : ValueType
    {
        public object regionOfInterest;
        public object rotationDegrees;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8A6880
    }

}