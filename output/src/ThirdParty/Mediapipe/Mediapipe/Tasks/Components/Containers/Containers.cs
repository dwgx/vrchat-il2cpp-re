// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Components.Containers
// Classes: 9
// Methods: 33

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Components.Containers
{
    public class Category : ValueType
    {
        public int index; // 0x10
        public float score; // 0x14
        public string categoryName; // 0x18
        public string displayName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5373B880 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD5373B8E0
    }

    public class ClassificationResult : ValueType
    {
        public System.Collections.Generic.List`1<0x66578178> classifications; // 0x10
        public System.Nullable`1<long> timestampMs; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD51515420
        public void Copy(){} // RVA: 0x7FFD5373C160
        public void ToString(){} // RVA: 0x7FFD5373C540
    }

    public class DetectionResult : ValueType
    {
        public System.Collections.Generic.List`1<0x66578228> detections; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4ECFFE40
        public void Alloc(){} // RVA: 0x7FFD5373D150
        public void Copy(){} // RVA: 0x7FFD5373D220
        public void ToString(){} // RVA: 0x7FFD5373D580
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
        public void .ctor(){} // RVA: 0x7FFD5373DA20 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD5373DB80
        public void System.IEquatable<Mediapipe.Tasks.Components.Containers.Landmark>.Equals(){} // RVA: 0x7FFD5373DC30
        public void GetHashCode(){} // RVA: 0x7FFD5373DC90
        public void ToString(){} // RVA: 0x7FFD5373DD00
    }

    public class NormalizedKeypoint : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
        public string label; // 0x18
        public System.Nullable`1<float> score; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5373D670 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD5373D770
    }

    public class PacketExtension : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFD5373F560 | overloaded x4
    }

    public class Rect : ValueType
    {
        public int left; // 0x10
        public int top; // 0x14
        public int right; // 0x18
        public int bottom; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5373F6A0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD5373F6C0
    }

    public class RectF : ValueType
    {
        public float left; // 0x10
        public float top; // 0x14
        public float right; // 0x18
        public float bottom; // 0x1C

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD5373F900
        public void System.IEquatable<Mediapipe.Tasks.Components.Containers.RectF>.Equals(){} // RVA: 0x7FFD5373F9A0
        public void GetHashCode(){} // RVA: 0x7FFD5373FA00
        public void ToString(){} // RVA: 0x7FFD5373FAE0
    }

    public class Util : Object
    {
        // ── Methods ──
        public void Format(){} // RVA: 0x7FFD4E078F80 | overloaded x3
    }

}