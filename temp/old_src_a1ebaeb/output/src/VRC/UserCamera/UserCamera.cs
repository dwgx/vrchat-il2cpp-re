// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UserCamera
// Classes: 3
// Methods: 11

namespace VRC.UserCamera
{
    public class CameraPin : ScriptableObject
    {
        public object Space; // 0x33C46A30
        public object DofUV; // 0x33C46A30
        public object Aperture; // 0x33C46A30
        public object AutoLevelRoll; // 0x33C46A30
        public object ShowUIInCamera; // 0x33C46A30
        public object ShowEnvironmentInCamera; // 0x33C46A30
        public object properties; // 0x33C64CB0
        public object backgroundColor; // 0x33C64CB0
        public object cullingMask; // 0x33C64CB0
        public object replacementShader; // 0x33C64CB0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8d7f610
    }

    public class CameraPreset : ScriptableObject
    {
        public object farClipPlane; // 0x33C64CB0
        public object clearFlags; // 0x33C64CB0
        public object allowHDR; // 0x33C64CB0
        public object filterMaterial; // 0x33C64CB0
        public object Shown; // 0x3405D560

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8d7f6c0
    }

    public class VRCOscDollyPointMessage : ValueType
    {
        public object Rotation; // 0x3405D990
        public object Hue; // 0x3405D990
        public object LookAtMeXOffset; // 0x3405D990
        public object Exposure; // 0x3405D990
        public object Index; // 0x3405D990

        // ── Original Methods ──
        public void Computetransform(){} // RVA: 0x7ffaa8d80ec0
        public void ComputeeulerAngles(){} // RVA: 0x7ffaa8d81200
        public void DefaultEquals(){} // RVA: 0x7ffaa8d81540
        public void Equals(){} // RVA: 0x7ffaa8d81880
        public void InternalGetHashCode(){} // RVA: 0x7ffaa8d81bc0
        public void ToString(){} // RVA: 0x7ffaa8d82580
        public void ReadTransformProperties(){} // RVA: 0x7ffaa8d828c0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa8d81f00
        public void GetHashCodeOfPtr(){} // RVA: 0x7ffaa8d82240
    }

}