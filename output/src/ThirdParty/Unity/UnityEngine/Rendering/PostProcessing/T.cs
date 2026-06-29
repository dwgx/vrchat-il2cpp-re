// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 7
// Methods: 34

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class TargetPool : Object
    {
        public object m_Pool;
        public object m_Current;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x799D450
        public void Get(){} // RVA: 0x799D540
        public void Reset(){} // RVA: 0x1320080
    }

    public class TemporalAntialiasing : Object
    {
        public object jitterSpread;
        public object sharpness;
        public object stationaryBlending;
        public object motionBlending;
        public object jitteredMatrixFunc;
        public object _jitter;
        public object m_Mrt;
        public object m_ResetHistory;
        public object k_SampleCount;
        public object _sampleIndex;
        public object k_NumEyes;
        public object k_NumHistoryTextures;
        public object m_HistoryTextures;
        public object m_HistoryPingPong;

        // ── Methods ──
        public void get_jitter(){} // RVA: 0x21B8D30
        public void set_jitter(){} // RVA: 0x116B360
        public void get_sampleIndex(){} // RVA: 0x114DAD0
        public void set_sampleIndex(){} // RVA: 0x25671C0
        public void IsSupported(){} // RVA: 0x7976CD0
        public void GetCameraFlags(){} // RVA: 0xEF4110
        public void ResetHistory(){} // RVA: 0x1A9DEA0
        public void GenerateRandomOffset(){} // RVA: 0x7976D60
        public void GetJitteredProjectionMatrix(){} // RVA: 0x7976E40
        public void ConfigureJitteredProjectionMatrix(){} // RVA: 0x7977130
        public void ConfigureStereoJitteredProjectionMatrices(){} // RVA: 0x7977390
        public void GenerateHistoryName(){} // RVA: 0x7977910
        public void CheckHistory(){} // RVA: 0x7977A80
        public void Render(){} // RVA: 0x79780F0
        public void Release(){} // RVA: 0x7978730
        public void .ctor(){} // RVA: 0x79788A0
    }

    public class TextureFormatUtilities : Object
    {
        public object s_FormatAliasMap;
        public object s_SupportedRenderTextureFormats;
        public object s_SupportedTextureFormats;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x799D740
        public void IsObsolete(){} // RVA: 0x799E840
        public void GetUncompressedRenderTextureFormat(){} // RVA: 0x799E9A0
        public void IsSupported(){} // RVA: 0x799ECA0
    }

    public class TextureLerper : Object
    {
        public object m_Instance;
        public object m_Command;
        public object m_PropertySheets;
        public object m_Resources;
        public object m_Recycled;
        public object m_Actives;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x799ED70
        public void .ctor(){} // RVA: 0x799EF70
        public void BeginFrame(){} // RVA: 0x799F0B0
        public void EndFrame(){} // RVA: 0x799F1F0
        public void Get(){} // RVA: 0x799F460
        public void Lerp(){} // RVA: 0x79A03E0
        public void Clear(){} // RVA: 0x79A0E00
    }

    public class TextureParameter : ParameterOverride`1
    {
        public object defaultState;

        // ── Methods ──
        public void Interp(){} // RVA: 0x797D220
        public void .ctor(){} // RVA: 0x797DCF0
    }

    public class TonemapperParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x795E780
    }

    public class TrackballAttribute : Attribute
    {
        public object mode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
    }

}