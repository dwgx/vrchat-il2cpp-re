// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening.Plugins.Options
// Classes: 11
// Methods: 11

namespace ThirdParty.DOTween.DG.Tweening.Plugins.Options
{
    public class ColorOptions : ValueType
    {
        public bool alphaOnly; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4FDDD6A0
    }

    public class FloatOptions : ValueType
    {
        public bool snapping; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4FDDD6A0
    }

    public class IPlugOptions
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4E090980
    }

    public class NoOptions : ValueType
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4E341310
    }

    public class PathOptions : ValueType
    {
        public 0x665CC600 mode; // 0x10
        public 0x665CEBD0 orientType; // 0x14
        public 0x665CC130 lockPositionAxis; // 0x18
        public 0x665CC130 lockRotationAxis; // 0x1C
        public bool isClosedPath; // 0x20
        public UnityEngine.Vector3 lookAtPosition; // 0x24
        public UnityEngine.Transform lookAtTransform; // 0x30
        public float lookAhead; // 0x38
        public bool hasCustomForwardDirection; // 0x3C
        public UnityEngine.Quaternion forward; // 0x40
        public bool useLocalPosition; // 0x50
        public UnityEngine.Transform parent; // 0x58
        public bool isRigidbody; // 0x60
        public bool stableZRotation; // 0x61
        public UnityEngine.Quaternion startupRot; // 0x64
        public float startupZRot; // 0x74
        public bool addedExtraStartWp; // 0x78
        public bool addedExtraEndWp; // 0x79

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4FDDD4B0
    }

    public class QuaternionOptions : ValueType
    {
        public 0x665CC6B0 rotateMode; // 0x10
        public 0x665CC130 axisConstraint; // 0x14
        public UnityEngine.Vector3 up; // 0x18

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4FDDD640
    }

    public class RectOptions : ValueType
    {
        public bool snapping; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4FDDD6A0
    }

    public class StringOptions : ValueType
    {
        public bool richTextEnabled; // 0x10
        public 0x665CC708 scrambleMode; // 0x14
        public char[] scrambledChars; // 0x18
        public int startValueStrippedLength; // 0x20
        public int changeValueStrippedLength; // 0x24

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4FDDD710
    }

    public class UintOptions : ValueType
    {
        public bool isNegativeChangeValue; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4FDDD6A0
    }

    public class Vector3ArrayOptions : ValueType
    {
        public 0x665CC130 axisConstraint; // 0x10
        public bool snapping; // 0x14
        public float[] durations; // 0x18

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4FDDD6B0
    }

    public class VectorOptions : ValueType
    {
        public 0x665CC130 axisConstraint; // 0x10
        public bool snapping; // 0x14

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4FDDD780
    }

}