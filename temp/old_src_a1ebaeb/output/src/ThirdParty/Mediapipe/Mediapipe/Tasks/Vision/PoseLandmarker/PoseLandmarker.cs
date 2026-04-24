// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
// Classes: 3
// Methods: 24

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
{
    public class PoseLandmarker : BaseVisionTaskApi
    {
        public object _poseLandmarkerResultAnnotationController; // 0x3381EA60

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd11320
        public void CreateFromOptions(){} // RVA: 0x7ffaadd11450
        public void TryDetect(){} // RVA: 0x7ffaadd11f00
        public void DetectInternal(){} // RVA: 0x7ffaadd12120
        public void TryDetectForVideo(){} // RVA: 0x7ffaadd12280
        public void DetectForVideoInternal(){} // RVA: 0x7ffaadd124b0
        public void DetectAsync(){} // RVA: 0x7ffaadd12630
        public void BuildPacketsCallback(){} // RVA: 0x7ffaadd127b0
        public void TryBuildPoseLandmarkerResult(){} // RVA: 0x7ffaadd12960
    }

    public class PoseLandmarkerOptions : Object
    {
        public object _numPoses; // 0x33816580, was: <numPoses>k__BackingField
        public object _minTrackingConfidence; // 0x33816580, was: <minTrackingConfidence>k__Back

        // ── Original Methods ──
        public void get_baseOptions(){} // RVA: 0x7ffaa894d380
        public void get_runningMode(){} // RVA: 0x7ffaa8b945a0
        public void get_numPoses(){} // RVA: 0x7ffaa9e5ac10
        public void get_minPoseDetectionConfidence(){} // RVA: 0x7ffaa895b080
        public void get_minPosePresenceConfidence(){} // RVA: 0x7ffaa8a9ff50
        public void get_minTrackingConfidence(){} // RVA: 0x7ffaa8a11210
        public void get_outputSegmentationMasks(){} // RVA: 0x7ffaa8a11230
        public void get_resultCallback(){} // RVA: 0x7ffaa8bfcc80
        public void .ctor(){} // RVA: 0x7ffaadd12f90
        public void ToProto(){} // RVA: 0x7ffaadd130a0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7ffaadd132c0
    }

    public class PoseLandmarkerResult : ValueType
    {
        public object segmentationMasks; // 0x3366F0C0
        public object System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x1700079B

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9e95260
        public void Alloc(){} // RVA: 0x7ffaadd134c0
        public void CloneTo(){} // RVA: 0x7ffaadd13610
        public void ToString(){} // RVA: 0x7ffaadd13b90
    }

}