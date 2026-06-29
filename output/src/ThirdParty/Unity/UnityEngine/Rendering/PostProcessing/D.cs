// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 4
// Methods: 12

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class DepthOfField : PostProcessEffectSettings
    {
        public object focusDistance;
        public object aperture;
        public object focalLength;
        public object kernelSize;

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7965DC0
        public void .ctor(){} // RVA: 0x7965E30
    }

    public class DepthOfFieldRenderer : PostProcessEffectRenderer`1
    {
        public object k_NumEyes;
        public object k_NumCoCHistoryTextures;
        public object m_CoCHistoryTextures;
        public object m_HistoryPingPong;
        public object k_FilmHeight;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x79660E0
        public void GetCameraFlags(){} // RVA: 0xC3CCE0
        public void SelectFormat(){} // RVA: 0x7966360
        public void CalculateMaxCoCRadius(){} // RVA: 0x7966400
        public void CheckHistory(){} // RVA: 0x7966490
        public void Render(){} // RVA: 0x7966870
        public void Release(){} // RVA: 0x7967CB0
    }

    public class DisplayNameAttribute : Attribute
    {
        public object displayName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class Dithering : Object
    {
        public object m_NoiseTextureIndex;
        public object m_Random;

        // ── Methods ──
        public void Render(){} // RVA: 0x7967DC0
        public void .ctor(){} // RVA: 0x7968070
    }

}