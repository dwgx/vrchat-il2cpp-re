// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 7
// Methods: 36

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class TargetPool : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AED311B0
        public void Get(){} // RVA: 0x7AED312A0
        public void Reset(){} // RVA: 0x7A8810990
    }

    public class TemporalAntialiasing : Object
    {
        // ── Methods ──
        public void get_jitter(){} // RVA: 0x7A96B3750
        public void set_jitter(){} // RVA: 0x7A8669350
        public void get_sampleIndex(){} // RVA: 0x7A864E8D0
        public void set_sampleIndex(){} // RVA: 0x7A9ABBD00
        public void IsSupported(){} // RVA: 0x7AED08B50
        public void GetCameraFlags(){} // RVA: 0x7A8401A30
        public void ResetHistory(){} // RVA: 0x7A8F567E0
        public void GenerateRandomOffset(){} // RVA: 0x7AED08C30
        public void GetJitteredProjectionMatrix(){} // RVA: 0x7AED08D10
        public void ConfigureJitteredProjectionMatrix(){} // RVA: 0x7AED08FD0
        public void ConfigureStereoJitteredProjectionMatrices(){} // RVA: 0x7AED091B0
        public void GenerateHistoryName(){} // RVA: 0x7AED09640
        public void CheckHistory(){} // RVA: 0x7AED097B0
        public void Render(){} // RVA: 0x7AED09E50
        public void Release(){} // RVA: 0x7AED0A4D0
        public void .ctor(){} // RVA: 0x7AED0A640
        public void jitterSpread(){} // RVA: 0x7B4192828
    }

    public class TextureFormatUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AED314E0
        public void IsObsolete(){} // RVA: 0x7AED32690
        public void GetUncompressedRenderTextureFormat(){} // RVA: 0x7AED32820
        public void IsSupported(){} // RVA: 0x7AED32B50
    }

    public class TextureLerper : Object
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x7AED32C20
        public void .ctor(){} // RVA: 0x7AED32E20
        public void BeginFrame(){} // RVA: 0x7AED32F60
        public void EndFrame(){} // RVA: 0x7AED330A0
        public void Get(){} // RVA: 0x7AED33310
        public void Lerp(){} // RVA: 0x7AED34050
        public void Clear(){} // RVA: 0x7AED34890
        // ── Unresolved (hash) ──
        public void m_Instance(){} // RVA: 0x7B3FA8F68
    }

    public class TextureParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x7AED0EE80
        public void .ctor(){} // RVA: 0x7AED0F950
    }

    public class TonemapperParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AECF13F0
    }

    public class TrackballAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
    }

}