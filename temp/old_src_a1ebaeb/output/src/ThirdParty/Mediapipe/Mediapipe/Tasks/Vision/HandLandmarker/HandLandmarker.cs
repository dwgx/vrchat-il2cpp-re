// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
// Classes: 3
// Methods: 23

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
{
    public class HandLandmarker : BaseVisionTaskApi
    {
        public object _IMAGE_TAG; // 0x33CEE700
        public object _HANDEDNESS_STREAM_NAME; // 0x33CEE700
        public object _HAND_LANDMARKS_TAG; // 0x33CEE700
        public object _TASK_GRAPH_NAME; // 0x33CEE700
        public object _normalizedRect; // 0x33CEE700
        public object f_3CD; // 0x334E89A0, was: ÍÌÌÎÎÎÍÎÎÍÍÏÏÏÎÎÎÍÌÎÍÍÌ
        public object _delegateInput; // 0x3399F880
        public object _minHandDetectionConfidenceInput; // 0x3399F880

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd19680
        public void CreateFromOptions(){} // RVA: 0x7ffaadd197b0
        public void TryDetect(){} // RVA: 0x7ffaadd1a260
        public void DetectInternal(){} // RVA: 0x7ffaadd1a480
        public void TryDetectForVideo(){} // RVA: 0x7ffaadd1a5e0
        public void DetectForVideoInternal(){} // RVA: 0x7ffaadd1a810
        public void DetectAsync(){} // RVA: 0x7ffaadd1a990
        public void BuildPacketsCallback(){} // RVA: 0x7ffaadd1ab10
        public void TryBuildHandLandmarkerResult(){} // RVA: 0x7ffaadd1acc0
    }

    public class HandLandmarkerOptions : Object
    {
        public object _numHands; // 0x336588D0, was: <numHands>k__BackingField
        public object _minTrackingConfidence; // 0x336588D0, was: <minTrackingConfidence>k__Back

        // ── Original Methods ──
        public void get_baseOptions(){} // RVA: 0x7ffaa894d380
        public void get_runningMode(){} // RVA: 0x7ffaa8b945a0
        public void get_numHands(){} // RVA: 0x7ffaa9e5ac10
        public void get_minHandDetectionConfidence(){} // RVA: 0x7ffaa895b080
        public void get_minHandPresenceConfidence(){} // RVA: 0x7ffaa8a9ff50
        public void get_minTrackingConfidence(){} // RVA: 0x7ffaa8a11210
        public void get_resultCallback(){} // RVA: 0x7ffaa8bfcc80
        public void .ctor(){} // RVA: 0x7ffaadd1b2e0
        public void ToProto(){} // RVA: 0x7ffaadd1b3e0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7ffaadd1b600
    }

    public class HandLandmarkerResult : ValueType
    {
        public object handWorldLandmarks; // 0x33436920
        public object System.Collections.Generic.IEnumerator<System.Object>.Current; // 0x170007A4

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9e95260
        public void Alloc(){} // RVA: 0x7ffaadd1b6f0
        public void CloneTo(){} // RVA: 0x7ffaadd1b830
        public void ToString(){} // RVA: 0x7ffaadd1bbe0
    }

}