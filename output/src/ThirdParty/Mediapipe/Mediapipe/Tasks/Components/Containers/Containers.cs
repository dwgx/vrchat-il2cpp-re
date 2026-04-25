// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Components.Containers
// Classes: 15
// Methods: 53

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Components.Containers
{
    public class Category : ValueType
    {
        public int index; // 0x10
        public float score; // 0x14
        public string categoryName; // 0x18
        public string displayName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC831B880 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC831B8E0
    }

    public class ClassificationResult : ValueType
    {
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Components.Containers.Classifications> classifications; // 0x10
        public System.Nullable`1<long> timestampMs; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC60F5420
        public void Copy(){} // RVA: 0x7FFAC831C160
        public void ToString(){} // RVA: 0x7FFAC831C540
    }

    public class Classifications : ValueType
    {
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Components.Containers.Category> categories; // 0x10
        public int headIndex; // 0x18
        public string headName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC68C66B0
        public void Copy(){} // RVA: 0x7FFAC831BB00
        public void ToString(){} // RVA: 0x7FFAC831C010
    }

    public class Detection : ValueType
    {
        public int _DefaultCategoryIndex;
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Components.Containers.Category> categories; // 0x10
        public Mediapipe.Tasks.Components.Containers.Rect boundingBox; // 0x18
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Components.Containers.NormalizedKeypoint> keypoints; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC831C740
        public void Copy(){} // RVA: 0x7FFAC831C810
        public void ToString(){} // RVA: 0x7FFAC831D040
    }

    public class DetectionResult : ValueType
    {
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Components.Containers.Detection> detections; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void Alloc(){} // RVA: 0x7FFAC831D150
        public void Copy(){} // RVA: 0x7FFAC831D220
        public void ToString(){} // RVA: 0x7FFAC831D580
    }

    public class Landmark : ValueType
    {
        public float _LandmarkTolerance;
        public float x; // 0x10
        public float y; // 0x14
        public float z; // 0x18
        public System.Nullable`1<float> visibility; // 0x1C
        public System.Nullable`1<float> presence; // 0x24
        public string name; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC831DA20 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC831DB80
        public void System.IEquatable<Mediapipe.Tasks.Components.Containers.Landmark>.Equals(){} // RVA: 0x7FFAC831DC30
        public void GetHashCode(){} // RVA: 0x7FFAC831DC90
        public void ToString(){} // RVA: 0x7FFAC831DD00
    }

    public class Landmarks : ValueType
    {
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Components.Containers.Landmark> landmarks; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void Copy(){} // RVA: 0x7FFAC831E520
        public void ToString(){} // RVA: 0x7FFAC831E880
    }

    public class NativeLandmarksArrayExtension : Object
    {
        // ── Methods ──
        public void FillWith(){} // RVA: 0x7FFAC831EF10 | overloaded x2
    }

    public class NormalizedKeypoint : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
        public string label; // 0x18
        public System.Nullable`1<float> score; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC831D670 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC831D770
    }

    public class NormalizedLandmark : ValueType
    {
        public float _LandmarkTolerance;
        public float x; // 0x10
        public float y; // 0x14
        public float z; // 0x18
        public System.Nullable`1<float> visibility; // 0x1C
        public System.Nullable`1<float> presence; // 0x24
        public string name; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC831DFD0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC831E130
        public void System.IEquatable<Mediapipe.Tasks.Components.Containers.NormalizedLandmark>.Equals(){} // RVA: 0x7FFAC831DC30
        public void GetHashCode(){} // RVA: 0x7FFAC831E1E0
        public void ToString(){} // RVA: 0x7FFAC831E250
    }

    public class NormalizedLandmarks : ValueType
    {
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Components.Containers.NormalizedLandmark> landmarks; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void Copy(){} // RVA: 0x7FFAC831E900
        public void ToString(){} // RVA: 0x7FFAC831EC60
    }

    public class PacketExtension : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC831F560 | overloaded x4
    }

    public class Rect : ValueType
    {
        public int left; // 0x10
        public int top; // 0x14
        public int right; // 0x18
        public int bottom; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC831F6A0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC831F6C0
    }

    public class RectF : ValueType
    {
        public float left; // 0x10
        public float top; // 0x14
        public float right; // 0x18
        public float bottom; // 0x1C

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC831F900
        public void System.IEquatable<Mediapipe.Tasks.Components.Containers.RectF>.Equals(){} // RVA: 0x7FFAC831F9A0
        public void GetHashCode(){} // RVA: 0x7FFAC831FA00
        public void ToString(){} // RVA: 0x7FFAC831FAE0
    }

    public class Util : Object
    {
        // ── Methods ──
        public void Format(){} // RVA: 0x7FFAC2C58F80 | overloaded x3
    }

}