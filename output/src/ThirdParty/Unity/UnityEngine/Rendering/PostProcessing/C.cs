// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 6
// Methods: 33

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class ChromaticAberration : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x795DE40
        public void .ctor(){} // RVA: 0x795DE80
    }

    public class ChromaticAberrationRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x795E0F0
        public void Release(){} // RVA: 0x795E640
        public void .ctor(){} // RVA: 0x795E6F0
    }

    public class ColorGrading : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x795E7D0
        public void .ctor(){} // RVA: 0x795E890
    }

    public class ColorGradingRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x79600C0
        public void RenderExternalPipeline3D(){} // RVA: 0x79602F0
        public void RenderHDRPipeline3D(){} // RVA: 0x7960700
        public void RenderHDRPipeline2D(){} // RVA: 0x7962150
        public void RenderLDRPipeline2D(){} // RVA: 0x79639B0
        public void CheckInternalLogLut(){} // RVA: 0x7964D30
        public void CheckInternalStripLut(){} // RVA: 0x7965060
        public void GetCurveTexture(){} // RVA: 0x7965360
        public void IsRenderTextureFormatSupportedForLinearFiltering(){} // RVA: 0x7965930
        public void GetLutFormat(){} // RVA: 0x7965A40
        public void GetCurveFormat(){} // RVA: 0x7965A90
        public void Release(){} // RVA: 0x7965AC0
        public void .ctor(){} // RVA: 0x7965C30
    }

    public class ColorParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x797CAA0
        public void op_Implicit(){} // RVA: 0x797CB10
        public void .ctor(){} // RVA: 0x797CB60
    }

    public class ColorUtilities : Object
    {
        // ── Methods ──
        public void StandardIlluminantY(){} // RVA: 0x7991900
        public void CIExyToLMS(){} // RVA: 0x7991930
        public void ComputeColorBalance(){} // RVA: 0x79919C0
        public void ColorToLift(){} // RVA: 0x7991AE0
        public void ColorToInverseGamma(){} // RVA: 0x7991B50
        public void ColorToGain(){} // RVA: 0x7991C10
        public void LogCToLinear(){} // RVA: 0x7991C80
        public void LinearToLogC(){} // RVA: 0x7991CE0
        public void ToHex(){} // RVA: 0x7991D30
        public void ToRGBA(){} // RVA: 0x7991DB0
    }

}