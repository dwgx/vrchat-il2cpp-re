// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 7
// Methods: 37

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class TargetPool
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F52DC0
        public void Get(){} // RVA: 0x6F52EB0 | overloaded x2
        public void Reset(){} // RVA: 0xA52E70
    }

    public class TemporalAntialiasing
    {
        public float jitterSpread; // 0x10
        public float sharpness; // 0x14

        // ── Methods ──
        public void get_jitter(){} // RVA: 0x18F7880
        public void set_jitter(){} // RVA: 0x8AC650
        public void get_sampleIndex(){} // RVA: 0x891AF0
        public void set_sampleIndex(){} // RVA: 0x1CB95F0
        public void IsSupported(){} // RVA: 0x6F2A560
        public void GetCameraFlags(){} // RVA: 0x66CCC0
        public void ResetHistory(){} // RVA: 0x1199240
        public void GenerateRandomOffset(){} // RVA: 0x6F2A640
        public void GetJitteredProjectionMatrix(){} // RVA: 0x6F2A720
        public void ConfigureJitteredProjectionMatrix(){} // RVA: 0x6F2A9F0
        public void ConfigureStereoJitteredProjectionMatrices(){} // RVA: 0x6F2ABD0
        public void GenerateHistoryName(){} // RVA: 0x6F2B060
        public void CheckHistory(){} // RVA: 0x6F2B1D0
        public void Render(){} // RVA: 0x6F2B870
        public void Release(){} // RVA: 0x6F2BF00
        public void .ctor(){} // RVA: 0x6F2C060
    }

    public class TextureFormatUtilities
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6F530F0
        public void IsObsolete(){} // RVA: 0x6F542B0
        public void GetUncompressedRenderTextureFormat(){} // RVA: 0x6F54440
        public void IsSupported(){} // RVA: 0x6F54760 | overloaded x2
    }

    public class TextureLerper
    {
        public UnityEngine.Rendering.PostProcessing.TextureLerper m_Instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x6F54830
        public void .ctor(){} // RVA: 0x6F54A30
        public void BeginFrame(){} // RVA: 0x6F54B70
        public void EndFrame(){} // RVA: 0x6F54CB0
        public void Get(){} // RVA: 0x6F54F20
        public void Lerp(){} // RVA: 0x6F55C30 | overloaded x2
        public void Clear(){} // RVA: 0x6F56470
    }

    public class TextureParameter
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x6F30920
        public void .ctor(){} // RVA: 0x6F313F0
    }

    public class TonemapperParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F12D80
    }

    public class TrackballAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
    }

}