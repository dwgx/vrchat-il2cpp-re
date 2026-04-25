// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
// Classes: 3
// Methods: 23

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
{
    public class HandLandmarker : BaseVisionTaskApi
    {
        public string _IMAGE_IN_STREAM_NAME;
        public string _IMAGE_OUT_STREAM_NAME;
        public string _IMAGE_TAG;
        public string _NORM_RECT_STREAM_NAME;
        public string _NORM_RECT_TAG;
        public string _HANDEDNESS_STREAM_NAME;
        public string _HANDEDNESS_TAG;
        public string _HAND_LANDMARKS_STREAM_NAME;
        public string _HAND_LANDMARKS_TAG;
        public string _HAND_WORLD_LANDMARKS_STREAM_NAME;
        public string _HAND_WORLD_LANDMARKS_TAG;
        public string _TASK_GRAPH_NAME;
        public int _MICRO_SECONDS_PER_MILLISECOND;
        public PacketsCallback _packetCallback; // 0x20
        public Mediapipe.NormalizedRect _normalizedRect; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC82F84D0
        public void CreateFromOptions(){} // RVA: 0x7FFAC82F8600
        public void TryDetect(){} // RVA: 0x7FFAC82F90B0
        public void DetectInternal(){} // RVA: 0x7FFAC82F92D0
        public void TryDetectForVideo(){} // RVA: 0x7FFAC82F9430
        public void DetectForVideoInternal(){} // RVA: 0x7FFAC82F9660
        public void DetectAsync(){} // RVA: 0x7FFAC82F97E0
        public void BuildPacketsCallback(){} // RVA: 0x7FFAC82F9960
        public void TryBuildHandLandmarkerResult(){} // RVA: 0x7FFAC82F9B10
    }

    public class HandLandmarkerOptions : Object
    {
        public Mediapipe.Tasks.Core.BaseOptions baseOptions; // 0x10
        public 0x6B215EC0 runningMode; // 0x18
        public int numHands; // 0x1C
        public float minHandDetectionConfidence; // 0x20
        public float minHandPresenceConfidence; // 0x24
        public float minTrackingConfidence; // 0x28
        public ResultCallback resultCallback; // 0x30

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFAC2F3C380
        public void get_runningMode(){} // RVA: 0x7FFAC3157800
        public void get_numHands(){} // RVA: 0x7FFAC44357F0
        public void get_minHandDetectionConfidence(){} // RVA: 0x7FFAC2F4A080
        public void get_minHandPresenceConfidence(){} // RVA: 0x7FFAC308EF50
        public void get_minTrackingConfidence(){} // RVA: 0x7FFAC3000210
        public void get_resultCallback(){} // RVA: 0x7FFAC31D95E0
        public void .ctor(){} // RVA: 0x7FFAC82FA130
        public void ToProto(){} // RVA: 0x7FFAC82FA230
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFAC82FA450
    }

    public class HandLandmarkerResult : ValueType
    {
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Components.Containers.Classifications> handedness; // 0x10
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Components.Containers.NormalizedLandmarks> handLandmarks; // 0x18
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Components.Containers.Landmarks> handWorldLandmarks; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC446FCC0
        public void Alloc(){} // RVA: 0x7FFAC82FA540
        public void CloneTo(){} // RVA: 0x7FFAC82FA680
        public void ToString(){} // RVA: 0x7FFAC82FAA30
    }

}