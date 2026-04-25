// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UserCamera
// Classes: 3
// Methods: 10

namespace VRC.UserCamera
{
    public class CameraPin : ScriptableObject
    {
        public UnityEngine.Vector3 Position; // 0x18
        public UnityEngine.Quaternion Rotation; // 0x24
        public 0x6B02B7A0 Space; // 0x34
        public int Filter; // 0x38
        public int DofMode; // 0x3C
        public UnityEngine.Vector2 DofUV; // 0x40
        public float FocalDistance; // 0x48
        public float FocalLength; // 0x4C
        public float Aperture; // 0x50
        public bool LookAtMe; // 0x54
        public bool Smoothed; // 0x55
        public bool AutoLevelRoll; // 0x56
        public bool AutoLevelPitch; // 0x57
        public bool IsFlipped; // 0x58
        public bool ShowUIInCamera; // 0x59
        public bool ShowLocalPlayerInCamera; // 0x5A
        public bool ShowRemotePlayerInCamera; // 0x5B
        public bool ShowEnvironmentInCamera; // 0x5C
        public bool ShowGreenscreen; // 0x5D
        public 0x6B253CC0 Orientation; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC33596A0
    }

    public class CameraPreset : ScriptableObject
    {
        public 0x6B02A828 properties; // 0x18
        public float nearClipPlane; // 0x1C
        public float farClipPlane; // 0x20
        public UnityEngine.Color backgroundColor; // 0x24
        public 0x6B17B838 renderingPath; // 0x34
        public 0x6B17BCB0 clearFlags; // 0x38
        public UnityEngine.LayerMask cullingMask; // 0x3C
        public int fieldOfView; // 0x40
        public bool allowHDR; // 0x44
        public UnityEngine.Shader replacementShader; // 0x48
        public string replacementShaderTag; // 0x50
        public UnityEngine.Material filterMaterial; // 0x58
        public UnityEngine.GameObject postEffects; // 0x60
        public bool disablePostEffects; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3359750
    }

    public class VRCOscDollyPointMessage : ValueType
    {
        public bool IsLocal; // 0x10
        public SerializableVector3 Position; // 0x18
        public SerializableVector3 Rotation; // 0x20
        public float FocalDistance; // 0x28
        public float Aperture; // 0x2C
        public float Hue; // 0x30
        public float Saturation; // 0x34
        public float Lightness; // 0x38
        public float LookAtMeXOffset; // 0x3C
        public float LookAtMeYOffset; // 0x40
        public float Zoom; // 0x44
        public float Exposure; // 0x48
        public float Speed; // 0x4C
        public float Duration; // 0x50
        public int Index; // 0x54
        public int PathIndex; // 0x58

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC335A9C0
        public void InternalEquals(){} // RVA: 0x7FFAC335AD00
        public void DefaultEquals(){} // RVA: 0x7FFAC335B040
        public void GetHashCode(){} // RVA: 0x7FFAC335B380
        public void InternalGetHashCode(){} // RVA: 0x7FFAC335B6C0
        public void ToString(){} // RVA: 0x7FFAC335BA00
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC335BD40
        public void ToString_B9B0B22EE707(){} // RVA: 0x7FFAC335C080
    }

}