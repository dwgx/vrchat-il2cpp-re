// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 6
// Methods: 33

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class ChromaticAberration : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7AECF0A60
        public void .ctor(){} // RVA: 0x7AECF0AA0
    }

    public class ChromaticAberrationRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x7AECF0D10
        public void Release(){} // RVA: 0x7AECF12B0
        public void .ctor(){} // RVA: 0x7AECF1360
    }

    public class ColorGrading : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7AECF1440
        public void .ctor(){} // RVA: 0x7AECF1500
    }

    public class ColorGradingRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x7AECF2D00
        public void RenderExternalPipeline3D(){} // RVA: 0x7AECF2F30
        public void RenderHDRPipeline3D(){} // RVA: 0x7AECF32B0
        public void RenderHDRPipeline2D(){} // RVA: 0x7AECF4610
        public void RenderLDRPipeline2D(){} // RVA: 0x7AECF5DD0
        public void CheckInternalLogLut(){} // RVA: 0x7AECF7160
        public void CheckInternalStripLut(){} // RVA: 0x7AECF7660
        public void GetCurveTexture(){} // RVA: 0x7AECF7AB0
        public void IsRenderTextureFormatSupportedForLinearFiltering(){} // RVA: 0x7AECF8160
        public void GetLutFormat(){} // RVA: 0x7AECF8270
        public void GetCurveFormat(){} // RVA: 0x7AECF82C0
        public void Release(){} // RVA: 0x7AECF82F0
        public void .ctor(){} // RVA: 0x7AECF8460
    }

    public class ColorParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x7AED0E700
        public void op_Implicit(){} // RVA: 0x7AED0E770
        public void .ctor(){} // RVA: 0x7AED0E7C0
    }

    public class ColorUtilities : Object
    {
        // ── Methods ──
        public void StandardIlluminantY(){} // RVA: 0x7AED23AB0
        public void CIExyToLMS(){} // RVA: 0x7AED23AE0
        public void ComputeColorBalance(){} // RVA: 0x7AED23B70
        public void ColorToLift(){} // RVA: 0x7AED23C90
        public void ColorToInverseGamma(){} // RVA: 0x7AED23D00
        public void ColorToGain(){} // RVA: 0x7AED23DC0
        public void LogCToLinear(){} // RVA: 0x7AED23E30
        public void LinearToLogC(){} // RVA: 0x7AED23E90
        public void ToHex(){} // RVA: 0x7AED23EE0
        public void ToRGBA(){} // RVA: 0x7AED23F60
    }

}