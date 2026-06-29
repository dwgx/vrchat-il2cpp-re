// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UserCamera
// Classes: 6
// Methods: 53

namespace VRC.UserCamera
{
    public class CameraPin : ScriptableObject
    {
        public object Position;
        public object Rotation;
        public object Space;
        public object Filter;
        public object DofMode;
        public object DofUV;
        public object FocalDistance;
        public object FocalLength;
        public object Aperture;
        public object LookAtMe;
        public object Smoothed;
        public object AutoLevelRoll;
        public object AutoLevelPitch;
        public object IsFlipped;
        public object ShowUIInCamera;
        public object ShowLocalPlayerInCamera;
        public object ShowRemotePlayerInCamera;
        public object ShowEnvironmentInCamera;
        public object ShowGreenscreen;
        public object Orientation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x10E5E70
    }

    public class CameraPin[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CameraPreset : ScriptableObject
    {
        public object properties;
        public object nearClipPlane;
        public object farClipPlane;
        public object backgroundColor;
        public object renderingPath;
        public object clearFlags;
        public object cullingMask;
        public object fieldOfView;
        public object allowHDR;
        public object replacementShader;
        public object replacementShaderTag;
        public object filterMaterial;
        public object postEffects;
        public object disablePostEffects;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x10E5F20
    }

    public class CameraPreset[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class VRCOscDollyPointMessage : ValueType
    {
        public object IsLocal;
        public object Position;
        public object Rotation;
        public object FocalDistance;
        public object Aperture;
        public object Hue;
        public object Saturation;
        public object Lightness;
        public object LookAtMeXOffset;
        public object LookAtMeYOffset;
        public object Zoom;
        public object Exposure;
        public object Speed;
        public object Duration;
        public object Index;
        public object PathIndex;

        // ── Methods ──
        public void Equals(){} // RVA: 0x10E73B0
        public void InternalEquals(){} // RVA: 0x10E7650
        public void DefaultEquals(){} // RVA: 0x10E78F0
        public void GetHashCode(){} // RVA: 0x10E7B90
        public void InternalGetHashCode(){} // RVA: 0x10E7E30
        public void GetHashCodeOfPtr(){} // RVA: 0x10E80D0
    }

    public class VRCOscDollyPointMessage[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7F4D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7AED0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4C30
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E353E0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7AED0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}