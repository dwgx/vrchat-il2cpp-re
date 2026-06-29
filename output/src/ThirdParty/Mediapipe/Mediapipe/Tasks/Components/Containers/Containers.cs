// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Components.Containers
// Classes: 19
// Methods: 102

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Components.Containers
{
    public class Category : ValueType
    {
        public object index;
        public object score;
        public object categoryName;
        public object displayName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8A7470
        public void ToString(){} // RVA: 0x8A75B0
    }

    public class ClassificationResult : ValueType
    {
        public object classifications;
        public object timestampMs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x31FB70
        public void Copy(){} // RVA: 0x65FE970
        public void ToString(){} // RVA: 0x8A7760
    }

    public class Classifications : ValueType
    {
        public object categories;
        public object headIndex;
        public object headName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8A7680
        public void Copy(){} // RVA: 0x65FE320
        public void ToString(){} // RVA: 0x8A7690
    }

    public class Classifications[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DD60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3EE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34170
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Detection : ValueType
    {
        public object _DefaultCategoryIndex;
        public object categories;
        public object boundingBox;
        public object keypoints;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8A7830
        public void Copy(){} // RVA: 0x65FF050
        public void ToString(){} // RVA: 0x8A7860
    }

    public class DetectionResult : ValueType
    {
        public object detections;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x47F10
        public void Alloc(){} // RVA: 0x65FF990
        public void Copy(){} // RVA: 0x65FFA60
        public void ToString(){} // RVA: 0x8A7930
    }

    public class Detection[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E320
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4160
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E345E0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Landmark : ValueType
    {
        public object _LandmarkTolerance;
        public object x;
        public object y;
        public object z;
        public object visibility;
        public object presence;
        public object name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8A7C60
        public void Equals(){} // RVA: 0x8A7CA0
        public void System.IEquatable<Mediapipe.Tasks.Components.Containers.Landmark>.Equals(){} // RVA: 0x8A7CB0
        public void GetHashCode(){} // RVA: 0x8A7D10
        public void ToString(){} // RVA: 0x8A7D20
    }

    public class Landmarks : ValueType
    {
        public object landmarks;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x47F10
        public void Copy(){} // RVA: 0x6600D40
        public void ToString(){} // RVA: 0x8A7F20
    }

    public class Landmarks[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7D9E0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3CA0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E33ED0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class NativeLandmarksArrayExtension : Object
    {
        // ── Methods ──
        public void FillWith(){} // RVA: 0x6601740
    }

    public class NormalizedKeypoint : ValueType
    {
        public object x;
        public object y;
        public object label;
        public object score;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8A7AE0
        public void ToString(){} // RVA: 0x8A7B10
    }

    public class NormalizedLandmark : ValueType
    {
        public object _LandmarkTolerance;
        public object x;
        public object y;
        public object z;
        public object visibility;
        public object presence;
        public object name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8A7DF0
        public void Equals(){} // RVA: 0x8A7E30
        public void System.IEquatable<Mediapipe.Tasks.Components.Containers.NormalizedLandmark>.Equals(){} // RVA: 0x8A7CB0
        public void GetHashCode(){} // RVA: 0x8A7E40
        public void ToString(){} // RVA: 0x8A7E50
    }

    public class NormalizedLandmarks : ValueType
    {
        public object landmarks;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x47F10
        public void Copy(){} // RVA: 0x6601120
        public void ToString(){} // RVA: 0x8A7FF0
    }

    public class NormalizedLandmarks[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7D9E0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3CA0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E33ED0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class PacketExtension : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x6601D80
    }

    public class Rect : ValueType
    {
        public object left;
        public object top;
        public object right;
        public object bottom;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8A8020
        public void ToString(){} // RVA: 0x8A8050
    }

    public class RectF : ValueType
    {
        public object left;
        public object top;
        public object right;
        public object bottom;

        // ── Methods ──
        public void Equals(){} // RVA: 0x8A8060
        public void System.IEquatable<Mediapipe.Tasks.Components.Containers.RectF>.Equals(){} // RVA: 0x8A8070
        public void GetHashCode(){} // RVA: 0x8A80E0
        public void ToString(){} // RVA: 0x8A80F0
    }

    public class Util : Object
    {
        // ── Methods ──
        public void Format(){} // RVA: 0x87C5C0
    }

}