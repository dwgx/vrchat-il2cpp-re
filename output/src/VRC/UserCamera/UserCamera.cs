// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UserCamera
// Classes: 3
// Methods: 10

namespace VRC.UserCamera
{
    public class CameraPin : ScriptableObject
    {
        public amut Position; // 0x18
        public R_12x12 Rotation; // 0x24
        public object Space; // 0x34
        public int Filter; // 0x38
        public int DofMode; // 0x3C
        public tionX DofUV; // 0x40
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
        public sHeld.entPlayer Orientation; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E7796A0
    }

    public class CameraPreset : ScriptableObject
    {
        public ÏÍÎÏÍÌÎÎÏÏÍÌÏÍÎÏÏÍÎÎÍÎ properties; // 0x18
        public float nearClipPlane; // 0x1C
        public float farClipPlane; // 0x20
        public object backgroundColor; // 0x24
        public object renderingPath; // 0x34
        public MaxRect clearFlags; // 0x38
        public object cullingMask; // 0x3C
        public int fieldOfView; // 0x40
        public bool allowHDR; // 0x44
        public ojectionMatrix_Injected replacementShader; // 0x48
        public string replacementShaderTag; // 0x50
        public atrix_Injected filterMaterial; // 0x58
        public BuffersImpl postEffects; // 0x60
        public bool disablePostEffects; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E779750
    }

    public class VRCOscDollyPointMessage : ValueType
    {
        public bool IsLocal; // 0x10
        public ÍÍÎÎÎÌÏÌÌÎÌÏÎÌÏÎ Position; // 0x18
        public ÍÍÎÎÎÌÏÌÌÎÌÏÎÌÏÎ Rotation; // 0x20
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
        public void Equals(){} // RVA: 0x7FFD4E77A9C0
        public void InternalEquals(){} // RVA: 0x7FFD4E77AD00
        public void DefaultEquals(){} // RVA: 0x7FFD4E77B040
        public void GetHashCode(){} // RVA: 0x7FFD4E77B380
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E77B6C0
        public void ToString(){} // RVA: 0x7FFD4E77BA00
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4E77BD40
        public void ToString_B9B0B22EE707(){} // RVA: 0x7FFD4E77C080
    }

}