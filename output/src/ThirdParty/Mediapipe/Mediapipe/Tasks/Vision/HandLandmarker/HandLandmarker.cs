// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
// Classes: 3
// Methods: 23

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
{
    public class HandLandmarker : BaseVisionTaskApi
    {
        public object _IMAGE_IN_STREAM_NAME;
        public object _IMAGE_OUT_STREAM_NAME;
        public object _IMAGE_TAG;
        public object _NORM_RECT_STREAM_NAME;
        public object _NORM_RECT_TAG;
        public object _HANDEDNESS_STREAM_NAME;
        public object _HANDEDNESS_TAG;
        public object _HAND_LANDMARKS_STREAM_NAME;
        public object _HAND_LANDMARKS_TAG;
        public object _HAND_WORLD_LANDMARKS_STREAM_NAME;
        public object _HAND_WORLD_LANDMARKS_TAG;
        public object _TASK_GRAPH_NAME;
        public object _MICRO_SECONDS_PER_MILLISECOND;
        public object _packetCallback;
        public object _normalizedRect;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65DB0D0
        public void CreateFromOptions(){} // RVA: 0x65DB210
        public void TryDetect(){} // RVA: 0x65DBC00
        public void DetectInternal(){} // RVA: 0x65DBE30
        public void TryDetectForVideo(){} // RVA: 0x65DBF90
        public void DetectForVideoInternal(){} // RVA: 0x65DC1D0
        public void DetectAsync(){} // RVA: 0x65DC350
        public void BuildPacketsCallback(){} // RVA: 0x65DC4D0
        public void TryBuildHandLandmarkerResult(){} // RVA: 0x65DC680
    }

    public class HandLandmarkerOptions : Object
    {
        public object _baseOptions;
        public object _runningMode;
        public object _numHands;
        public object _minHandDetectionConfidence;
        public object _minHandPresenceConfidence;
        public object _minTrackingConfidence;
        public object _resultCallback;

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0xB5DBF0
        public void get_runningMode(){} // RVA: 0xE62D00
        public void get_numHands(){} // RVA: 0x2244FB0
        public void get_minHandDetectionConfidence(){} // RVA: 0xB6B200
        public void get_minHandPresenceConfidence(){} // RVA: 0xCBAD90
        public void get_minTrackingConfidence(){} // RVA: 0xC27360
        public void get_resultCallback(){} // RVA: 0xD33E60
        public void .ctor(){} // RVA: 0x65DCCB0
        public void ToProto(){} // RVA: 0x65DCDB0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x65DCFD0
    }

    public class HandLandmarkerResult : ValueType
    {
        public object handedness;
        public object handLandmarks;
        public object handWorldLandmarks;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x79C50
        public void Alloc(){} // RVA: 0x65DD0C0
        public void CloneTo(){} // RVA: 0x8A6CA0
        public void ToString(){} // RVA: 0x8A6CB0
    }

}