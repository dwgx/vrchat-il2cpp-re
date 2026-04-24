// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.Core
// Classes: 2
// Methods: 10

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.Core
{
    public class BaseVisionTaskApi : Object
    {
        public lIdFieldNumber.t_HasConfidence runningMode; // 0x10
        public e.ÍÍÏÏÎÎÍÍÍÏÎÏÍÎÍÏÌÏÌÏÌÍÌ <runningMode>k__BackingField; // 0x18
        public bool _isClosed; // 0x1C

        // ── Methods ──
        public void get_runningMode(){} // RVA: 0x7FFD4E577800
        public void .ctor(){} // RVA: 0x7FFD5370F3B0
        public void ProcessImageData(){} // RVA: 0x7FFD5370F690
        public void ProcessVideoData(){} // RVA: 0x7FFD5370F750
        public void SendLiveStreamData(){} // RVA: 0x7FFD5370F810
        public void ResetNormalizedRect(){} // RVA: 0x7FFD5370F9F0
        public void ConfigureNormalizedRect(){} // RVA: 0x7FFD5370FA30
        public void Close(){} // RVA: 0x7FFD5370FE00
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFD5370FF30
    }

    public class ImageProcessingOptions : ValueType
    {
        public aphy<gBox.ber> regionOfInterest; // 0x10
        public int rotationDegrees; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53710150
    }

}