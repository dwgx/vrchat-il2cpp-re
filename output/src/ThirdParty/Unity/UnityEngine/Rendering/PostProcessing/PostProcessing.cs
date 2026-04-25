// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 88
// Methods: 552

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class AmbientOcclusion : PostProcessEffectSettings
    {
        public UnityEngine.Rendering.PostProcessing.AmbientOcclusionModeParameter mode; // 0x30
        public UnityEngine.Rendering.PostProcessing.FloatParameter intensity; // 0x38
        public UnityEngine.Rendering.PostProcessing.ColorParameter color; // 0x40
        public UnityEngine.Rendering.PostProcessing.BoolParameter ambientOnly; // 0x48
        public UnityEngine.Rendering.PostProcessing.FloatParameter noiseFilterTolerance; // 0x50
        public UnityEngine.Rendering.PostProcessing.FloatParameter blurTolerance; // 0x58
        public UnityEngine.Rendering.PostProcessing.FloatParameter upsampleTolerance; // 0x60
        public UnityEngine.Rendering.PostProcessing.FloatParameter thicknessModifier; // 0x68
        public UnityEngine.Rendering.PostProcessing.FloatParameter zBias; // 0x70
        public UnityEngine.Rendering.PostProcessing.FloatParameter directLightingStrength; // 0x78
        public UnityEngine.Rendering.PostProcessing.FloatParameter radius; // 0x80
        public UnityEngine.Rendering.PostProcessing.AmbientOcclusionQualityParameter quality; // 0x88

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFAC96A6320
        public void .ctor(){} // RVA: 0x7FFAC96A66D0
    }

    public class AmbientOcclusionModeParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96A6280
    }

    public class AmbientOcclusionQualityParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96A62D0
    }

    public class AmbientOcclusionRenderer : PostProcessEffectRenderer`1
    {
        public UnityEngine.Rendering.PostProcessing.IAmbientOcclusionMethod[] m_Methods; // 0x20

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC96A6DF0
        public void IsAmbientOnly(){} // RVA: 0x7FFAC96A6FB0
        public void Get(){} // RVA: 0x7FFAC96A70C0
        public void GetCameraFlags(){} // RVA: 0x7FFAC96A7130
        public void Release(){} // RVA: 0x7FFAC96A71D0
        public void GetScalableAO(){} // RVA: 0x7FFAC96A72E0
        public void GetMultiScaleVO(){} // RVA: 0x7FFAC96A7350
        public void Render(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC96A73C0
    }

    public class AutoExposure : PostProcessEffectSettings
    {
        public UnityEngine.Rendering.PostProcessing.Vector2Parameter filtering; // 0x30
        public UnityEngine.Rendering.PostProcessing.FloatParameter minLuminance; // 0x38
        public UnityEngine.Rendering.PostProcessing.FloatParameter maxLuminance; // 0x40
        public UnityEngine.Rendering.PostProcessing.FloatParameter keyValue; // 0x48
        public UnityEngine.Rendering.PostProcessing.EyeAdaptationParameter eyeAdaptation; // 0x50
        public UnityEngine.Rendering.PostProcessing.FloatParameter speedUp; // 0x58
        public UnityEngine.Rendering.PostProcessing.FloatParameter speedDown; // 0x60

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFAC96A7450
        public void .ctor(){} // RVA: 0x7FFAC96A7610
    }

    public class AutoExposureRenderer : PostProcessEffectRenderer`1
    {
        public int k_NumEyes;
        public int k_NumAutoExposureTextures;
        public UnityEngine.RenderTexture[][] m_AutoExposurePool; // 0x20
        public int[] m_AutoExposurePingPong; // 0x28
        public UnityEngine.RenderTexture m_CurrentAutoExposure; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96A7A90
        public void CheckTexture(){} // RVA: 0x7FFAC96A7CD0
        public void Render(){} // RVA: 0x7FFAC96A7FE0
        public void Release(){} // RVA: 0x7FFAC96A8DA0
    }

    public class Bloom : PostProcessEffectSettings
    {
        public UnityEngine.Rendering.PostProcessing.FloatParameter intensity; // 0x30
        public UnityEngine.Rendering.PostProcessing.FloatParameter threshold; // 0x38
        public UnityEngine.Rendering.PostProcessing.FloatParameter softKnee; // 0x40
        public UnityEngine.Rendering.PostProcessing.FloatParameter clamp; // 0x48
        public UnityEngine.Rendering.PostProcessing.FloatParameter diffusion; // 0x50
        public UnityEngine.Rendering.PostProcessing.FloatParameter anamorphicRatio; // 0x58
        public UnityEngine.Rendering.PostProcessing.ColorParameter color; // 0x60
        public UnityEngine.Rendering.PostProcessing.BoolParameter fastMode; // 0x68
        public UnityEngine.Rendering.PostProcessing.TextureParameter dirtTexture; // 0x70
        public UnityEngine.Rendering.PostProcessing.FloatParameter dirtIntensity; // 0x78

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFAC96A8E70
        public void .ctor(){} // RVA: 0x7FFAC96A8EB0
    }

    public class BloomRenderer : PostProcessEffectRenderer`1
    {
        public Level[] m_Pyramid; // 0x20
        public int k_MaxPyramidSize;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC96A94E0
        public void Render(){} // RVA: 0x7FFAC96A97A0
        public void .ctor(){} // RVA: 0x7FFAC96AACD0
    }

    public class BoolParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96C8A60
    }

    public class ChromaticAberration : PostProcessEffectSettings
    {
        public UnityEngine.Rendering.PostProcessing.TextureParameter spectralLut; // 0x30
        public UnityEngine.Rendering.PostProcessing.FloatParameter intensity; // 0x38
        public UnityEngine.Rendering.PostProcessing.BoolParameter fastMode; // 0x40

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFAC96AAD10
        public void .ctor(){} // RVA: 0x7FFAC96AAD50
    }

    public class ChromaticAberrationRenderer : PostProcessEffectRenderer`1
    {
        public UnityEngine.Texture2D m_InternalSpectralLut; // 0x20

        // ── Methods ──
        public void Render(){} // RVA: 0x7FFAC96AAFC0
        public void Release(){} // RVA: 0x7FFAC96AB560
        public void .ctor(){} // RVA: 0x7FFAC96AB610
    }

    public class ColorGrading : PostProcessEffectSettings
    {
        public UnityEngine.Rendering.PostProcessing.GradingModeParameter gradingMode; // 0x30
        public UnityEngine.Rendering.PostProcessing.TextureParameter externalLut; // 0x38
        public UnityEngine.Rendering.PostProcessing.TonemapperParameter tonemapper; // 0x40
        public UnityEngine.Rendering.PostProcessing.FloatParameter toneCurveToeStrength; // 0x48
        public UnityEngine.Rendering.PostProcessing.FloatParameter toneCurveToeLength; // 0x50
        public UnityEngine.Rendering.PostProcessing.FloatParameter toneCurveShoulderStrength; // 0x58
        public UnityEngine.Rendering.PostProcessing.FloatParameter toneCurveShoulderLength; // 0x60
        public UnityEngine.Rendering.PostProcessing.FloatParameter toneCurveShoulderAngle; // 0x68
        public UnityEngine.Rendering.PostProcessing.FloatParameter toneCurveGamma; // 0x70
        public UnityEngine.Rendering.PostProcessing.TextureParameter ldrLut; // 0x78
        public UnityEngine.Rendering.PostProcessing.FloatParameter ldrLutContribution; // 0x80
        public UnityEngine.Rendering.PostProcessing.FloatParameter temperature; // 0x88
        public UnityEngine.Rendering.PostProcessing.FloatParameter tint; // 0x90
        public UnityEngine.Rendering.PostProcessing.ColorParameter colorFilter; // 0x98
        public UnityEngine.Rendering.PostProcessing.FloatParameter hueShift; // 0xA0
        public UnityEngine.Rendering.PostProcessing.FloatParameter saturation; // 0xA8
        public UnityEngine.Rendering.PostProcessing.FloatParameter brightness; // 0xB0
        public UnityEngine.Rendering.PostProcessing.FloatParameter postExposure; // 0xB8
        public UnityEngine.Rendering.PostProcessing.FloatParameter contrast; // 0xC0
        public UnityEngine.Rendering.PostProcessing.FloatParameter mixerRedOutRedIn; // 0xC8
        public UnityEngine.Rendering.PostProcessing.FloatParameter mixerRedOutGreenIn; // 0xD0
        public UnityEngine.Rendering.PostProcessing.FloatParameter mixerRedOutBlueIn; // 0xD8
        public UnityEngine.Rendering.PostProcessing.FloatParameter mixerGreenOutRedIn; // 0xE0
        public UnityEngine.Rendering.PostProcessing.FloatParameter mixerGreenOutGreenIn; // 0xE8
        public UnityEngine.Rendering.PostProcessing.FloatParameter mixerGreenOutBlueIn; // 0xF0
        public UnityEngine.Rendering.PostProcessing.FloatParameter mixerBlueOutRedIn; // 0xF8
        public UnityEngine.Rendering.PostProcessing.FloatParameter mixerBlueOutGreenIn; // 0x100
        public UnityEngine.Rendering.PostProcessing.FloatParameter mixerBlueOutBlueIn; // 0x108
        public UnityEngine.Rendering.PostProcessing.Vector4Parameter lift; // 0x110
        public UnityEngine.Rendering.PostProcessing.Vector4Parameter gamma; // 0x118
        public UnityEngine.Rendering.PostProcessing.Vector4Parameter gain; // 0x120
        public UnityEngine.Rendering.PostProcessing.SplineParameter masterCurve; // 0x128
        public UnityEngine.Rendering.PostProcessing.SplineParameter redCurve; // 0x130
        public UnityEngine.Rendering.PostProcessing.SplineParameter greenCurve; // 0x138
        public UnityEngine.Rendering.PostProcessing.SplineParameter blueCurve; // 0x140
        public UnityEngine.Rendering.PostProcessing.SplineParameter hueVsHueCurve; // 0x148
        public UnityEngine.Rendering.PostProcessing.SplineParameter hueVsSatCurve; // 0x150
        public UnityEngine.Rendering.PostProcessing.SplineParameter satVsSatCurve; // 0x158
        public UnityEngine.Rendering.PostProcessing.SplineParameter lumVsSatCurve; // 0x160

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFAC96AB6F0
        public void .ctor(){} // RVA: 0x7FFAC96AB7B0
    }

    public class ColorGradingRenderer : PostProcessEffectRenderer`1
    {
        public UnityEngine.Texture2D m_GradingCurves; // 0x20
        public UnityEngine.Color[] m_Pixels; // 0x28
        public UnityEngine.RenderTexture m_InternalLdrLut; // 0x30
        public UnityEngine.RenderTexture m_InternalLogLut; // 0x38
        public int k_Lut2DSize;
        public int k_Lut3DSize;
        public UnityEngine.Rendering.PostProcessing.HableCurve m_HableCurve; // 0x40

        // ── Methods ──
        public void Render(){} // RVA: 0x7FFAC96ACFA0
        public void RenderExternalPipeline3D(){} // RVA: 0x7FFAC96AD1D0
        public void RenderHDRPipeline3D(){} // RVA: 0x7FFAC96AD570
        public void RenderHDRPipeline2D(){} // RVA: 0x7FFAC96AE8F0
        public void RenderLDRPipeline2D(){} // RVA: 0x7FFAC96B01E0
        public void CheckInternalLogLut(){} // RVA: 0x7FFAC96B15E0
        public void CheckInternalStripLut(){} // RVA: 0x7FFAC96B1AE0
        public void GetCurveTexture(){} // RVA: 0x7FFAC96B1F30
        public void IsRenderTextureFormatSupportedForLinearFiltering(){} // RVA: 0x7FFAC96B25D0
        public void GetLutFormat(){} // RVA: 0x7FFAC96B26E0
        public void GetCurveFormat(){} // RVA: 0x7FFAC96B2730
        public void Release(){} // RVA: 0x7FFAC96B2760
        public void .ctor(){} // RVA: 0x7FFAC96B28D0
    }

    public class ColorParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x7FFAC96C8AB0
        public void op_Implicit(){} // RVA: 0x7FFAC96C8B20
        public void .ctor(){} // RVA: 0x7FFAC96C8B70
    }

    public class ColorUtilities : Object
    {
        public float logC_cut;
        public float logC_a;
        public float logC_b;
        public float logC_c;
        public float logC_d;
        public float logC_e;
        public float logC_f;

        // ── Methods ──
        public void StandardIlluminantY(){} // RVA: 0x7FFAC96DDC90
        public void CIExyToLMS(){} // RVA: 0x7FFAC96DDCC0
        public void ComputeColorBalance(){} // RVA: 0x7FFAC96DDD50
        public void ColorToLift(){} // RVA: 0x7FFAC96DDE70
        public void ColorToInverseGamma(){} // RVA: 0x7FFAC96DDEE0
        public void ColorToGain(){} // RVA: 0x7FFAC96DDF90
        public void LogCToLinear(){} // RVA: 0x7FFAC96DE000
        public void LinearToLogC(){} // RVA: 0x7FFAC96DE060
        public void ToHex(){} // RVA: 0x7FFAC96DE0B0
        public void ToRGBA(){} // RVA: 0x7FFAC96DE130
    }

    public class DepthOfField : PostProcessEffectSettings
    {
        public UnityEngine.Rendering.PostProcessing.FloatParameter focusDistance; // 0x30
        public UnityEngine.Rendering.PostProcessing.FloatParameter aperture; // 0x38
        public UnityEngine.Rendering.PostProcessing.FloatParameter focalLength; // 0x40
        public UnityEngine.Rendering.PostProcessing.KernelSizeParameter kernelSize; // 0x48

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFAC96B2A60
        public void .ctor(){} // RVA: 0x7FFAC96B2AD0
    }

    public class DepthOfFieldRenderer : PostProcessEffectRenderer`1
    {
        public int k_NumEyes;
        public int k_NumCoCHistoryTextures;
        public UnityEngine.RenderTexture[][] m_CoCHistoryTextures; // 0x20
        public int[] m_HistoryPingPong; // 0x28
        public float k_FilmHeight;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96B2D80
        public void GetCameraFlags(){} // RVA: 0x7FFAC3013AF0
        public void SelectFormat(){} // RVA: 0x7FFAC96B2FC0
        public void CalculateMaxCoCRadius(){} // RVA: 0x7FFAC96B3060
        public void CheckHistory(){} // RVA: 0x7FFAC96B30F0
        public void Render(){} // RVA: 0x7FFAC96B34D0
        public void Release(){} // RVA: 0x7FFAC96B4830
    }

    public class DisplayNameAttribute : Attribute
    {
        public string displayName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class Dithering : Object
    {
        public int m_NoiseTextureIndex; // 0x10
        public System.Random m_Random; // 0x18

        // ── Methods ──
        public void Render(){} // RVA: 0x7FFAC96B4920
        public void .ctor(){} // RVA: 0x7FFAC96B4BF0
    }

    public class EyeAdaptationParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96A7400
    }

    public class FastApproximateAntialiasing : Object
    {
        public bool fastMode; // 0x10
        public bool keepAlpha; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FloatParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x7FFAC96C8970
        public void .ctor(){} // RVA: 0x7FFAC96C8990
    }

    public class Fog : Object
    {
        public bool enabled; // 0x10
        public bool excludeSkybox; // 0x11

        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x7FFAC3013AF0
        public void IsEnabledAndSupported(){} // RVA: 0x7FFAC96B4CA0
        public void Render(){} // RVA: 0x7FFAC96B4E10
        public void .ctor(){} // RVA: 0x7FFAC37C9980
    }

    public class GradingModeParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96AB650
    }

    public class Grain : PostProcessEffectSettings
    {
        public UnityEngine.Rendering.PostProcessing.BoolParameter colored; // 0x30
        public UnityEngine.Rendering.PostProcessing.FloatParameter intensity; // 0x38
        public UnityEngine.Rendering.PostProcessing.FloatParameter size; // 0x40
        public UnityEngine.Rendering.PostProcessing.FloatParameter lumContrib; // 0x48

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFAC96AAD10
        public void .ctor(){} // RVA: 0x7FFAC96B53D0
    }

    public class GrainRenderer : PostProcessEffectRenderer`1
    {
        public UnityEngine.RenderTexture m_GrainLookupRT; // 0x20
        public int k_SampleCount;
        public int m_SampleIndex; // 0x28

        // ── Methods ──
        public void Render(){} // RVA: 0x7FFAC96B5680
        public void GetLookupFormat(){} // RVA: 0x7FFAC96B6240
        public void Release(){} // RVA: 0x7FFAC96B62A0
        public void .ctor(){} // RVA: 0x7FFAC96B6350
    }

    public class HableCurve : Object
    {
        public float whitePoint; // 0x10
        public float inverseWhitePoint; // 0x14
        public float x0; // 0x18
        public float x1; // 0x1C
        public Segment[] m_Segments; // 0x20
        public Uniforms uniforms; // 0x28

        // ── Methods ──
        public void get_whitePoint(){} // RVA: 0x7FFAC304B320
        public void set_whitePoint(){} // RVA: 0x7FFAC304B330
        public void get_inverseWhitePoint(){} // RVA: 0x7FFAC304B340
        public void set_inverseWhitePoint(){} // RVA: 0x7FFAC304B350
        public void get_x0(){} // RVA: 0x7FFAC2F25CF0
        public void set_x0(){} // RVA: 0x7FFAC2F3C4D0
        public void get_x1(){} // RVA: 0x7FFAC2FEE570
        public void set_x1(){} // RVA: 0x7FFAC2FEE580
        public void .ctor(){} // RVA: 0x7FFAC96DE1B0
        public void Eval(){} // RVA: 0x7FFAC96DE400
        public void Init(){} // RVA: 0x7FFAC96DE4A0
        public void InitSegments(){} // RVA: 0x7FFAC96DE6E0
        public void SolveAB(){} // RVA: 0x7FFAC96DEC20
        public void AsSlopeIntercept(){} // RVA: 0x7FFAC96DEC90
        public void EvalDerivativeLinearGamma(){} // RVA: 0x7FFAC96DECF0
    }

    public class HaltonSeq : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC96DEFE0
    }

    public class HistogramMonitor : Monitor
    {
        public int width; // 0x20
        public int height; // 0x24
        public 0x6B271A90 channel; // 0x28
        public UnityEngine.ComputeBuffer m_Data; // 0x30
        public int k_NumBins;
        public int k_ThreadGroupSizeX;
        public int k_ThreadGroupSizeY;

        // ── Methods ──
        public void OnDisable(){} // RVA: 0x7FFAC96C5820
        public void NeedsHalfRes(){} // RVA: 0x7FFAC3006850
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFAC96C58E0
        public void Render(){} // RVA: 0x7FFAC96C59E0
        public void .ctor(){} // RVA: 0x7FFAC96C6290
    }

    public class IAmbientOcclusionMethod
    {
        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x7FFAC2C59960
        public void RenderAfterOpaque(){} // RVA: 0x7FFAC2C70A40
        public void RenderAmbientOnly(){} // RVA: 0x7FFAC2C70A40
        public void CompositeAmbientOnly(){} // RVA: 0x7FFAC2C70A40
        public void Release(){} // RVA: 0x7FFAC2C70980
    }

    public class IntParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x7FFAC96C89E0
        public void .ctor(){} // RVA: 0x7FFAC96C8A10
    }

    public class KernelSizeParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96B2A10
    }

    public class LensDistortion : PostProcessEffectSettings
    {
        public UnityEngine.Rendering.PostProcessing.FloatParameter intensity; // 0x30
        public UnityEngine.Rendering.PostProcessing.FloatParameter intensityX; // 0x38
        public UnityEngine.Rendering.PostProcessing.FloatParameter intensityY; // 0x40
        public UnityEngine.Rendering.PostProcessing.FloatParameter centerX; // 0x48
        public UnityEngine.Rendering.PostProcessing.FloatParameter centerY; // 0x50
        public UnityEngine.Rendering.PostProcessing.FloatParameter scale; // 0x58

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFAC96B6390
        public void .ctor(){} // RVA: 0x7FFAC96B6450
    }

    public class LensDistortionRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x7FFAC96B6810
        public void .ctor(){} // RVA: 0x7FFAC96B6BC0
    }

    public class LightMeterMonitor : Monitor
    {
        public int width; // 0x20
        public int height; // 0x24
        public bool showCurves; // 0x28

        // ── Methods ──
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFAC96C62B0
        public void Render(){} // RVA: 0x7FFAC96C6420
        public void .ctor(){} // RVA: 0x7FFAC96C6C70
    }

    public class LogHistogram : Object
    {
        public int data;
        public int rangeMax;
        public int k_Bins;
        public UnityEngine.ComputeBuffer <data>k__BackingField; // 0x10

        // ── Methods ──
        public void get_data(){} // RVA: 0x7FFAC2F3C380
        public void set_data(){} // RVA: 0x7FFAC2F22E30
        public void Generate(){} // RVA: 0x7FFAC96DF040
        public void GetHistogramScaleOffsetRes(){} // RVA: 0x7FFAC96DF680
        public void Release(){} // RVA: 0x7FFAC96DF6D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MaxAttribute : Attribute
    {
        public float max; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC304B330
    }

    public class MeshUtilities : Object
    {
        public System.Collections.Generic.Dictionary`2<0x6B1794D0,UnityEngine.Mesh> s_Primitives;
        public System.Collections.Generic.Dictionary`2<System.Type,0x6B1794D0> s_ColliderPrimitives; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC96DF750
        public void GetColliderMesh(){} // RVA: 0x7FFAC96DFB30
        public void GetPrimitive(){} // RVA: 0x7FFAC96DFD20
        public void GetBuiltinMesh(){} // RVA: 0x7FFAC96DFF50
    }

    public class MinAttribute : Attribute
    {
        public float min; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC304B330
    }

    public class MinMaxAttribute : Attribute
    {
        public float min; // 0x10
        public float max; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3B2F3C0
    }

    public class Monitor : Object
    {
        public UnityEngine.RenderTexture output; // 0x10
        public bool requested; // 0x18

        // ── Methods ──
        public void get_output(){} // RVA: 0x7FFAC2F3C380
        public void set_output(){} // RVA: 0x7FFAC2F22E30
        public void IsRequestedAndSupported(){} // RVA: 0x7FFAC96C6C90
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFAC2C59F60
        public void NeedsHalfRes(){} // RVA: 0x7FFAC2F21320
        public void CheckOutput(){} // RVA: 0x7FFAC96C6D80
        public void OnEnable(){} // RVA: 0x7FFAC2F21310
        public void OnDisable(){} // RVA: 0x7FFAC96C70F0
        public void Render(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MotionBlur : PostProcessEffectSettings
    {
        public UnityEngine.Rendering.PostProcessing.FloatParameter shutterAngle; // 0x30
        public UnityEngine.Rendering.PostProcessing.IntParameter sampleCount; // 0x38

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFAC96B6C00
        public void .ctor(){} // RVA: 0x7FFAC96B6D00
    }

    public class MotionBlurRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x7FFAC31E48B0
        public void CreateTemporaryRT(){} // RVA: 0x7FFAC96B6E90
        public void Render(){} // RVA: 0x7FFAC96B6F80
        public void .ctor(){} // RVA: 0x7FFAC96B7FB0
    }

    public class MultiScaleVO : Object
    {
        public float[] m_SampleThickness; // 0x10
        public float[] m_InvThicknessTable; // 0x18
        public float[] m_SampleWeightTable; // 0x20
        public int[] m_Widths; // 0x28
        public int[] m_Heights; // 0x30
        public int[] m_ScaledWidths; // 0x38
        public int[] m_ScaledHeights; // 0x40
        public UnityEngine.Rendering.PostProcessing.AmbientOcclusion m_Settings; // 0x48
        public UnityEngine.Rendering.PostProcessing.PropertySheet m_PropertySheet; // 0x50
        public UnityEngine.Rendering.PostProcessing.PostProcessResources m_Resources; // 0x58
        public UnityEngine.RenderTexture m_AmbientOnlyAO; // 0x60
        public 0x6B17C180 m_R8Format; // 0x68
        public 0x6B17C180 m_R16Format; // 0x6C
        public bool float4Texture; // 0x70
        public UnityEngine.Rendering.RenderTargetIdentifier[] m_MRT; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96B7FF0
        public void GetCameraFlags(){} // RVA: 0x7FFAC3013AF0
        public void SetResources(){} // RVA: 0x7FFAC2FE9510
        public void Alloc(){} // RVA: 0x7FFAC96B88A0
        public void AllocArray(){} // RVA: 0x7FFAC96B8AA0
        public void Release(){} // RVA: 0x7FFAC96BDE70 | overloaded x2
        public void CalculateZBufferParams(){} // RVA: 0x7FFAC96B8D10
        public void CalculateTanHalfFovHeight(){} // RVA: 0x7FFAC96B8E70
        public void GetSize(){} // RVA: 0x7FFAC96B8F00
        public void GetSizeArray(){} // RVA: 0x7FFAC96B8F60
        public void GenerateAOMap(){} // RVA: 0x7FFAC96B8FC0
        public void PushAllocCommands(){} // RVA: 0x7FFAC96B9D30
        public void PushDownsampleCommands(){} // RVA: 0x7FFAC96BA4F0
        public void PushRenderCommands(){} // RVA: 0x7FFAC96BB2E0
        public void PushUpsampleCommands(){} // RVA: 0x7FFAC96BBE40
        public void PushReleaseCommands(){} // RVA: 0x7FFAC96BC580
        public void PreparePropertySheet(){} // RVA: 0x7FFAC96BCB50
        public void CheckAOTexture(){} // RVA: 0x7FFAC96BCD90
        public void PushDebug(){} // RVA: 0x7FFAC96BD220
        public void RenderAfterOpaque(){} // RVA: 0x7FFAC96BD2F0
        public void RenderAmbientOnly(){} // RVA: 0x7FFAC96BD950
        public void CompositeAmbientOnly(){} // RVA: 0x7FFAC96BDB90
    }

    public class ParameterOverride : Object
    {
        public bool overrideState; // 0x10

        // ── Methods ──
        public void Interp(){}
        public void GetHash(){} // RVA: 0x7FFAC2C59960
        public void GetValue(){} // RVA: 0x7FFAC2E8DC40
        public void OnEnable(){} // RVA: 0x7FFAC2F21310
        public void OnDisable(){} // RVA: 0x7FFAC2F21310
        public void SetValue(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ParameterOverride`1 : ParameterOverride
    {
        public T value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void Interp(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Override(){} // RVA: 0x7FFAC2E8DC40
        public void SetValue(){} // RVA: 0x7FFAC2C70A40
        public void GetHash(){} // RVA: 0x7FFAC2C59960
        public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40
    }

    public class PostProcessAttribute : Attribute
    {
        public System.Type renderer; // 0x10
        public 0x6B272488 eventType; // 0x18
        public string menuItem; // 0x20
        public bool allowInSceneView; // 0x28
        public bool builtinEffect; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96A61C0 | overloaded x2
    }

    public class PostProcessBundle : Object
    {
        public UnityEngine.Rendering.PostProcessing.PostProcessAttribute attribute; // 0x10
        public UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings settings; // 0x18
        public UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer renderer; // 0x20

        // ── Methods ──
        public void get_attribute(){} // RVA: 0x7FFAC2F3C380
        public void set_attribute(){} // RVA: 0x7FFAC2F22E30
        public void get_settings(){} // RVA: 0x7FFAC2F247C0
        public void set_settings(){} // RVA: 0x7FFAC2F87E80
        public void get_renderer(){} // RVA: 0x7FFAC96C9DA0
        public void .ctor(){} // RVA: 0x7FFAC96C9F10
        public void Release(){} // RVA: 0x7FFAC96CA040
        public void ResetHistory(){} // RVA: 0x7FFAC96CA0B0
        public void CastSettings(){} // RVA: 0x7FFAC2E8DC40
        public void CastRenderer(){} // RVA: 0x7FFAC2E8DC40
    }

    public class PostProcessDebug : MonoBehaviour
    {
        public UnityEngine.Rendering.PostProcessing.PostProcessLayer postProcessLayer; // 0x20
        public UnityEngine.Rendering.PostProcessing.PostProcessLayer m_PreviousPostProcessLayer; // 0x28
        public bool lightMeter; // 0x30
        public bool histogram; // 0x31
        public bool waveform; // 0x32
        public bool vectorscope; // 0x33
        public 0x6B2721C8 debugOverlay; // 0x34
        public UnityEngine.Camera m_CurrentCamera; // 0x38
        public UnityEngine.Rendering.CommandBuffer m_CmdAfterEverything; // 0x40

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC96CA0D0
        public void OnDisable(){} // RVA: 0x7FFAC96CA210
        public void Update(){} // RVA: 0x7FFAC96CA3B0
        public void Reset(){} // RVA: 0x7FFAC96CA3C0
        public void UpdateStates(){} // RVA: 0x7FFAC96CA450
        public void OnPostRender(){} // RVA: 0x7FFAC96CA9C0
        public void OnGUI(){} // RVA: 0x7FFAC96CAD50
        public void DrawMonitor(){} // RVA: 0x7FFAC96CAF70
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class PostProcessDebugLayer : Object
    {
        public UnityEngine.Rendering.PostProcessing.LightMeterMonitor debugOverlayTarget; // 0x10
        public UnityEngine.Rendering.PostProcessing.HistogramMonitor debugOverlayActive; // 0x18
        public UnityEngine.Rendering.PostProcessing.WaveformMonitor debugOverlay; // 0x20
        public UnityEngine.Rendering.PostProcessing.VectorscopeMonitor vectorscope; // 0x28
        public System.Collections.Generic.Dictionary`2<0x6B271B98,UnityEngine.Rendering.PostProcessing.Monitor> m_Monitors; // 0x30
        public int frameWidth; // 0x38
        public int frameHeight; // 0x3C
        public UnityEngine.RenderTexture <debugOverlayTarget>k__BackingField; // 0x40
        public bool <debugOverlayActive>k__BackingField; // 0x48
        public 0x6B2721C8 <debugOverlay>k__BackingField; // 0x4C
        public OverlaySettings overlaySettings; // 0x50

        // ── Methods ──
        public void get_debugOverlayTarget(){} // RVA: 0x7FFAC2F9E740
        public void set_debugOverlayTarget(){} // RVA: 0x7FFAC2F49200
        public void get_debugOverlayActive(){} // RVA: 0x7FFAC2FD8D30
        public void set_debugOverlayActive(){} // RVA: 0x7FFAC2FD8D40
        public void get_debugOverlay(){} // RVA: 0x7FFAC3F2D3C0
        public void set_debugOverlay(){} // RVA: 0x7FFAC489E500
        public void OnEnable(){} // RVA: 0x7FFAC96CB160
        public void OnDisable(){} // RVA: 0x7FFAC96CB540
        public void DestroyDebugOverlayTarget(){} // RVA: 0x7FFAC96CB6E0
        public void RequestMonitorPass(){} // RVA: 0x7FFAC96CB790
        public void RequestDebugOverlay(){} // RVA: 0x7FFAC489E500
        public void SetFrameSize(){} // RVA: 0x7FFAC96CB800
        public void PushDebugOverlay(){} // RVA: 0x7FFAC96CB810
        public void GetCameraFlags(){} // RVA: 0x7FFAC96CBD40
        public void RenderMonitors(){} // RVA: 0x7FFAC96CBD70
        public void RenderSpecialOverlays(){} // RVA: 0x7FFAC96CC3D0
        public void EndFrame(){} // RVA: 0x7FFAC96CC920
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PostProcessEffectRenderer : Object
    {
        public bool m_ResetHistory; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2F21310
        public void GetCameraFlags(){} // RVA: 0x7FFAC34F9180
        public void ResetHistory(){} // RVA: 0x7FFAC322C870
        public void Release(){} // RVA: 0x7FFAC3EEA090
        public void Render(){} // RVA: 0x7FFAC2C70A40
        public void SetSettings(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC322C870
    }

    public class PostProcessEffectRendererExtensions : Object
    {
        // ── Methods ──
        public void RenderOrLog(){} // RVA: 0x7FFAC96E0070
    }

    public class PostProcessEffectRenderer`1 : PostProcessEffectRenderer
    {
        public T settings;

        // ── Methods ──
        public void get_settings(){} // RVA: 0x7FFAC2E8DC40
        public void set_settings(){} // RVA: 0x7FFAC2E8DC40
        public void SetSettings(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class PostProcessEffectSettings : ScriptableObject
    {
        public bool active; // 0x18
        public UnityEngine.Rendering.PostProcessing.BoolParameter enabled; // 0x20
        public System.Collections.ObjectModel.ReadOnlyCollection`1<UnityEngine.Rendering.PostProcessing.ParameterOverride> parameters; // 0x28

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC96CCAE0
        public void OnDisable(){} // RVA: 0x7FFAC96CD180
        public void SetAllOverridesTo(){} // RVA: 0x7FFAC96CD380
        public void IsEnabledAndSupported(){} // RVA: 0x7FFAC96CD5A0
        public void GetHash(){} // RVA: 0x7FFAC96CD5C0
        public void .ctor(){} // RVA: 0x7FFAC96CD7E0
        public void <OnEnable>b__3_2(){} // RVA: 0x7FFAC96CD8B0
    }

    public class PostProcessEventComparer : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC5D9E3D0
        public void GetHashCode(){} // RVA: 0x7FFAC5DEA830
    }

    public class PostProcessLayer : MonoBehaviour
    {
        public UnityEngine.Transform sortedBundles; // 0x20
        public UnityEngine.LayerMask cameraDepthFlags; // 0x28
        public bool haveBundlesBeenInited; // 0x2C
        public bool finalBlitToCameraTarget; // 0x2D
        public 0x6B272538 antialiasingMode; // 0x30
        public UnityEngine.Rendering.PostProcessing.TemporalAntialiasing temporalAntialiasing; // 0x38
        public UnityEngine.Rendering.PostProcessing.SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing; // 0x40
        public UnityEngine.Rendering.PostProcessing.FastApproximateAntialiasing fastApproximateAntialiasing; // 0x48
        public UnityEngine.Rendering.PostProcessing.Fog fog; // 0x50
        public UnityEngine.Rendering.PostProcessing.Dithering dithering; // 0x58
        public UnityEngine.Rendering.PostProcessing.PostProcessDebugLayer debugLayer; // 0x60
        public UnityEngine.Rendering.PostProcessing.PostProcessResources m_Resources; // 0x68
        public UnityEngine.Rendering.PostProcessing.PostProcessResources m_OldResources; // 0x70
        public bool m_ShowToolkit; // 0x78
        public bool m_ShowCustomSorter; // 0x79
        public bool breakBeforeColorGrading; // 0x7A
        public System.Collections.Generic.List`1<SerializedBundleRef> m_BeforeTransparentBundles; // 0x80
        public System.Collections.Generic.List`1<SerializedBundleRef> m_BeforeStackBundles; // 0x88
        public System.Collections.Generic.List`1<SerializedBundleRef> m_AfterStackBundles; // 0x90
        public System.Collections.Generic.Dictionary`2<0x6B272488,System.Collections.Generic.List`1<SerializedBundleRef>> <sortedBundles>k__BackingField; // 0x98
        public 0x6B17BD08 <cameraDepthFlags>k__BackingField; // 0xA0
        public bool <haveBundlesBeenInited>k__BackingField; // 0xA4
        public System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Rendering.PostProcessing.PostProcessBundle> m_Bundles; // 0xA8
        public UnityEngine.Rendering.PostProcessing.PropertySheetFactory m_PropertySheetFactory; // 0xB0
        public UnityEngine.Rendering.CommandBuffer m_LegacyCmdBufferBeforeReflections; // 0xB8
        public UnityEngine.Rendering.CommandBuffer m_LegacyCmdBufferBeforeLighting; // 0xC0
        public UnityEngine.Rendering.CommandBuffer m_LegacyCmdBufferOpaque; // 0xC8
        public UnityEngine.Rendering.CommandBuffer m_LegacyCmdBuffer; // 0xD0
        public UnityEngine.Camera m_Camera; // 0xD8
        public UnityEngine.Rendering.PostProcessing.PostProcessRenderContext m_CurrentContext; // 0xE0
        public UnityEngine.Rendering.PostProcessing.LogHistogram m_LogHistogram; // 0xE8
        public bool m_SettingsUpdateNeeded; // 0xF0
        public bool m_IsRenderingInSceneView; // 0xF1
        public UnityEngine.Rendering.PostProcessing.TargetPool m_TargetPool; // 0xF8
        public bool m_NaNKilled; // 0x100
        public System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer> m_ActiveEffects; // 0x108
        public System.Collections.Generic.List`1<UnityEngine.Rendering.RenderTargetIdentifier> m_Targets; // 0x110

        // ── Methods ──
        public void get_sortedBundles(){} // RVA: 0x7FFAC354DFB0
        public void set_sortedBundles(){} // RVA: 0x7FFAC354E3C0
        public void get_cameraDepthFlags(){} // RVA: 0x7FFAC489E510
        public void set_cameraDepthFlags(){} // RVA: 0x7FFAC489E550
        public void get_haveBundlesBeenInited(){} // RVA: 0x7FFAC3145120
        public void set_haveBundlesBeenInited(){} // RVA: 0x7FFAC313EEF0
        public void OnEnable(){} // RVA: 0x7FFAC96CDB20
        public void InitLegacy(){} // RVA: 0x7FFAC96CDEA0
        public void DynamicResolutionAllowsFinalBlitToCameraTarget(){} // RVA: 0x7FFAC96CE4B0
        public void OnRenderImage(){} // RVA: 0x7FFAC96CE5B0
        public void Init(){} // RVA: 0x7FFAC96CE670
        public void InitBundles(){} // RVA: 0x7FFAC96CE870
        public void UpdateBundleSortList(){} // RVA: 0x7FFAC96CEFC0
        public void OnDisable(){} // RVA: 0x7FFAC96CF8C0
        public void Reset(){} // RVA: 0x7FFAC96CFEF0
        public void OnPreCull(){} // RVA: 0x7FFAC96CFF90
        public void OnPreRender(){} // RVA: 0x7FFAC96D0C10
        public void RequiresInitialBlit(){} // RVA: 0x7FFAC3006850
        public void UpdateSrcDstForOpaqueOnly(){} // RVA: 0x7FFAC96D0CD0
        public void BuildCommandBuffers(){} // RVA: 0x7FFAC96D0F00
        public void OnPostRender(){} // RVA: 0x7FFAC96D2340
        public void GetBundle(){} // RVA: 0x7FFAC96D25C0 | overloaded x2
        public void GetSettings(){} // RVA: 0x7FFAC2E8DC40
        public void BakeMSVOMap(){} // RVA: 0x7FFAC96D2620
        public void OverrideSettings(){} // RVA: 0x7FFAC96D2820
        public void SetLegacyCameraFlags(){} // RVA: 0x7FFAC96D2AB0
        public void ResetHistory(){} // RVA: 0x7FFAC96D2E50
        public void HasOpaqueOnlyEffects(){} // RVA: 0x7FFAC96D3000
        public void HasActiveEffects(){} // RVA: 0x7FFAC96D3010
        public void SetupContext(){} // RVA: 0x7FFAC96D3250
        public void UpdateVolumeSystem(){} // RVA: 0x7FFAC96D3820
        public void RenderOpaqueOnly(){} // RVA: 0x7FFAC96D39F0
        public void Render(){} // RVA: 0x7FFAC96D3AF0
        public void RenderInjectionPoint(){} // RVA: 0x7FFAC96D4850
        public void RenderList(){} // RVA: 0x7FFAC96D4AF0
        public void ApplyFlip(){} // RVA: 0x7FFAC96D5340
        public void ApplyDefaultFlip(){} // RVA: 0x7FFAC96D5450
        public void RenderBuiltins(){} // RVA: 0x7FFAC96D55A0
        public void RenderFinalPass(){} // RVA: 0x7FFAC96D6290
        public void RenderEffect(){}
        public void ShouldGenerateLogHistogram(){} // RVA: 0x7FFAC96D6E60
        public void .ctor(){} // RVA: 0x7FFAC96D6F10
    }

    public class PostProcessManager : Object
    {
        public UnityEngine.Rendering.PostProcessing.PostProcessManager instance;
        public int k_MaxLayerCount;
        public System.Collections.Generic.Dictionary`2<int,System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessVolume>> m_SortedVolumes; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessVolume> m_Volumes; // 0x18
        public System.Collections.Generic.Dictionary`2<int,bool> m_SortNeeded; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings> m_BaseSettings; // 0x28
        public System.Collections.Generic.List`1<UnityEngine.Collider> m_TempColliders; // 0x30
        public System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Rendering.PostProcessing.PostProcessAttribute> settingsTypes; // 0x38

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAC96D73F0
        public void .ctor(){} // RVA: 0x7FFAC96D74D0
        public void CleanBaseTypes(){} // RVA: 0x7FFAC96D78F0
        public void ReloadBaseTypes(){} // RVA: 0x7FFAC96D7AD0
        public void GetActiveVolumes(){} // RVA: 0x7FFAC96D8110
        public void GetHighestPriorityVolume(){} // RVA: 0x7FFAC96D8A10 | overloaded x2
        public void QuickVolume(){} // RVA: 0x7FFAC96D8BF0
        public void SetLayerDirty(){} // RVA: 0x7FFAC96D8E60
        public void UpdateVolumeLayer(){} // RVA: 0x7FFAC96D9030
        public void Register(){} // RVA: 0x7FFAC96D9280 | overloaded x2
        public void Unregister(){} // RVA: 0x7FFAC96D9550 | overloaded x2
        public void ReplaceData(){} // RVA: 0x7FFAC96D9630
        public void UpdateSettings(){} // RVA: 0x7FFAC96D9920
        public void GrabVolumes(){} // RVA: 0x7FFAC96DA1C0
        public void SortByPriority(){} // RVA: 0x7FFAC96DA710
        public void IsVolumeRenderedByCamera(){} // RVA: 0x7FFAC3006850
    }

    public class PostProcessProfile : ScriptableObject
    {
        public System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings> settings; // 0x18
        public bool isDirty; // 0x20

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC96DAA00
        public void AddSettings(){} // RVA: 0x7FFAC96DAD70 | overloaded x3
        public void RemoveSettings(){} // RVA: 0x7FFAC96DAE40 | overloaded x2
        public void HasSettings(){} // RVA: 0x7FFAC96DAFD0 | overloaded x2
        public void GetSetting(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetSettings(){} // RVA: 0x7FFAC2C59F60
        public void .ctor(){} // RVA: 0x7FFAC96DB170
    }

    public class PostProcessRenderContext : Object
    {
        public UnityEngine.Camera camera; // 0x10
        public UnityEngine.Rendering.CommandBuffer command; // 0x18
        public UnityEngine.Rendering.RenderTargetIdentifier source; // 0x20
        public UnityEngine.Rendering.RenderTargetIdentifier destination; // 0x48
        public 0x6B17C180 sourceFormat; // 0x70
        public bool flip; // 0x74
        public UnityEngine.Rendering.PostProcessing.PostProcessResources resources; // 0x78
        public UnityEngine.Rendering.PostProcessing.PropertySheetFactory propertySheets; // 0x80
        public System.Collections.Generic.Dictionary`2<string,object> userData; // 0x88
        public UnityEngine.Rendering.PostProcessing.PostProcessDebugLayer debugLayer; // 0x90
        public int width; // 0x98
        public int height; // 0x9C
        public bool stereoActive; // 0xA0
        public int xrActiveEye; // 0xA4
        public int numberOfEyes; // 0xA8
        public 0x6B272958 stereoRenderingMode; // 0xAC
        public int screenWidth; // 0xB0
        public int screenHeight; // 0xB4
        public bool isSceneView; // 0xB8
        public 0x6B272538 antialiasing; // 0xBC
        public UnityEngine.Rendering.PostProcessing.TemporalAntialiasing temporalAntialiasing; // 0xC0
        public UnityEngine.Rendering.PostProcessing.PropertySheet uberSheet; // 0xC8
        public UnityEngine.Texture autoExposureTexture; // 0xD0
        public UnityEngine.Rendering.PostProcessing.LogHistogram logHistogram; // 0xD8
        public UnityEngine.Texture logLut; // 0xE0
        public UnityEngine.Rendering.PostProcessing.AutoExposure autoExposure; // 0xE8
        public int bloomBufferNameID; // 0xF0
        public bool physicalCamera; // 0xF4
        public UnityEngine.RenderTextureDescriptor m_sourceDescriptor; // 0xF8

        // ── Methods ──
        public void get_camera(){} // RVA: 0x7FFAC2F3C380
        public void set_camera(){} // RVA: 0x7FFAC96DB3B0
        public void get_command(){} // RVA: 0x7FFAC2F247C0
        public void set_command(){} // RVA: 0x7FFAC2F87E80
        public void get_source(){} // RVA: 0x7FFAC34EA3D0
        public void set_source(){} // RVA: 0x7FFAC96DB780
        public void get_destination(){} // RVA: 0x7FFAC34EA260
        public void set_destination(){} // RVA: 0x7FFAC96DB7A0
        public void get_sourceFormat(){} // RVA: 0x7FFAC3B99E80
        public void set_sourceFormat(){} // RVA: 0x7FFAC30B6520
        public void get_flip(){} // RVA: 0x7FFAC3BCD8B0
        public void set_flip(){} // RVA: 0x7FFAC81C5400
        public void get_resources(){} // RVA: 0x7FFAC30E5600
        public void set_resources(){} // RVA: 0x7FFAC30E06F0
        public void get_propertySheets(){} // RVA: 0x7FFAC32EF410
        public void set_propertySheets(){} // RVA: 0x7FFAC34D4AA0
        public void get_userData(){} // RVA: 0x7FFAC2F60010
        public void set_userData(){} // RVA: 0x7FFAC354E300
        public void get_debugLayer(){} // RVA: 0x7FFAC32EF640
        public void set_debugLayer(){} // RVA: 0x7FFAC354E360
        public void get_width(){} // RVA: 0x7FFAC489E530
        public void set_width(){} // RVA: 0x7FFAC489E540
        public void get_height(){} // RVA: 0x7FFAC489E520
        public void set_height(){} // RVA: 0x7FFAC489EAA0
        public void get_stereoActive(){} // RVA: 0x7FFAC45C9D50
        public void set_stereoActive(){} // RVA: 0x7FFAC37B1910
        public void get_xrActiveEye(){} // RVA: 0x7FFAC6539470
        public void set_xrActiveEye(){} // RVA: 0x7FFAC6539480
        public void get_numberOfEyes(){} // RVA: 0x7FFAC39055C0
        public void set_numberOfEyes(){} // RVA: 0x7FFAC38FD010
        public void get_stereoRenderingMode(){} // RVA: 0x7FFAC6539490
        public void set_stereoRenderingMode(){} // RVA: 0x7FFAC65394A0
        public void get_screenWidth(){} // RVA: 0x7FFAC4BF81F0
        public void set_screenWidth(){} // RVA: 0x7FFAC87B5A90
        public void get_screenHeight(){} // RVA: 0x7FFAC6715300
        public void set_screenHeight(){} // RVA: 0x7FFAC6715310
        public void get_isSceneView(){} // RVA: 0x7FFAC41F1470
        public void set_isSceneView(){} // RVA: 0x7FFAC41EEB20
        public void get_antialiasing(){} // RVA: 0x7FFAC37AB780
        public void set_antialiasing(){} // RVA: 0x7FFAC96DB7C0
        public void get_temporalAntialiasing(){} // RVA: 0x7FFAC2F8C120
        public void set_temporalAntialiasing(){} // RVA: 0x7FFAC2F8C130
        public void Reset(){} // RVA: 0x7FFAC96DB7D0
        public void IsTemporalAntialiasingActive(){} // RVA: 0x7FFAC96DBDB0
        public void IsDebugOverlayEnabled(){} // RVA: 0x7FFAC96DBDF0
        public void PushDebugOverlay(){} // RVA: 0x7FFAC96DBE20
        public void GetDescriptor(){} // RVA: 0x7FFAC96DBE80
        public void GetScreenSpaceTemporaryRT(){} // RVA: 0x7FFAC96DC150 | overloaded x2
        public void UpdateSinglePassStereoState(){} // RVA: 0x7FFAC96DC1E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PostProcessResources : ScriptableObject
    {
        public UnityEngine.Texture2D[] blueNoise64; // 0x18
        public UnityEngine.Texture2D[] blueNoise256; // 0x20
        public SMAALuts smaaLuts; // 0x28
        public Shaders shaders; // 0x30
        public ComputeShaders computeShaders; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class PostProcessVolume : MonoBehaviour
    {
        public UnityEngine.Rendering.PostProcessing.PostProcessProfile profile; // 0x20
        public bool profileRef; // 0x28
        public float previousLayer; // 0x2C
        public float weight; // 0x30
        public float priority; // 0x34
        public int m_PreviousLayer; // 0x38
        public float m_PreviousPriority; // 0x3C
        public System.Collections.Generic.List`1<UnityEngine.Collider> m_TempColliders; // 0x40
        public UnityEngine.Rendering.PostProcessing.PostProcessProfile m_InternalProfile; // 0x48

        // ── Methods ──
        public void get_profile(){} // RVA: 0x7FFAC96DC480
        public void set_profile(){} // RVA: 0x7FFAC2F9C740
        public void get_profileRef(){} // RVA: 0x7FFAC96DC870
        public void HasInstantiatedProfile(){} // RVA: 0x7FFAC96DC950
        public void get_previousLayer(){} // RVA: 0x7FFAC358A870
        public void OnEnable(){} // RVA: 0x7FFAC96DCA20
        public void OnDisable(){} // RVA: 0x7FFAC96DCC50
        public void Update(){} // RVA: 0x7FFAC96DCD40
        public void OnDrawGizmos(){} // RVA: 0x7FFAC96DCE80
        public void .ctor(){} // RVA: 0x7FFAC96DDC40
    }

    public class PropertySheet : Object
    {
        public UnityEngine.MaterialPropertyBlock properties; // 0x10
        public UnityEngine.Material material; // 0x18

        // ── Methods ──
        public void get_properties(){} // RVA: 0x7FFAC2F3C380
        public void set_properties(){} // RVA: 0x7FFAC2F22E30
        public void get_material(){} // RVA: 0x7FFAC2F247C0
        public void set_material(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC96E00E0
        public void ClearKeywords(){} // RVA: 0x7FFAC96E0220
        public void EnableKeyword(){} // RVA: 0x7FFAC96E0280
        public void DisableKeyword(){} // RVA: 0x7FFAC96E02F0
        public void Release(){} // RVA: 0x7FFAC96E0360
    }

    public class PropertySheetFactory : Object
    {
        public System.Collections.Generic.Dictionary`2<UnityEngine.Shader,UnityEngine.Rendering.PostProcessing.PropertySheet> m_Sheets; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96E0410
        public void Get(){} // RVA: 0x7FFAC96E0620 | overloaded x2
        public void Release(){} // RVA: 0x7FFAC96E0940
    }

    public class RuntimeUtilities : Object
    {
        public UnityEngine.Texture2D whiteTexture;
        public UnityEngine.Texture3D whiteTexture3D; // 0x8
        public UnityEngine.Texture2D blackTexture; // 0x10
        public UnityEngine.Texture3D blackTexture3D; // 0x18
        public UnityEngine.Texture2D transparentTexture; // 0x20
        public UnityEngine.Texture3D transparentTexture3D; // 0x28
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.Texture2D> fullscreenTriangle; // 0x30
        public UnityEngine.Rendering.PostProcessing.PostProcessResources copyStdMaterial; // 0x38
        public UnityEngine.Mesh copyStdFromDoubleWideMaterial; // 0x40
        public UnityEngine.Material copyMaterial; // 0x48
        public UnityEngine.Material copyFromTexArrayMaterial; // 0x50
        public UnityEngine.Material copySheet; // 0x58
        public UnityEngine.Material copyFromTexArraySheet; // 0x60
        public UnityEngine.Rendering.PostProcessing.PropertySheet scriptableRenderPipelineActive; // 0x68
        public UnityEngine.Rendering.PostProcessing.PropertySheet supportsDeferredShading; // 0x70
        public System.Collections.Generic.IEnumerable`1<System.Type> supportsDepthNormals; // 0x78

        // ── Methods ──
        public void get_whiteTexture(){} // RVA: 0x7FFAC96E0C50
        public void get_whiteTexture3D(){} // RVA: 0x7FFAC96E0F00
        public void get_blackTexture(){} // RVA: 0x7FFAC96E11D0
        public void get_blackTexture3D(){} // RVA: 0x7FFAC96E1490
        public void get_transparentTexture(){} // RVA: 0x7FFAC96E1760
        public void get_transparentTexture3D(){} // RVA: 0x7FFAC96E1A20
        public void GetLutStrip(){} // RVA: 0x7FFAC96E1CF0
        public void get_fullscreenTriangle(){} // RVA: 0x7FFAC96E2170
        public void get_copyStdMaterial(){} // RVA: 0x7FFAC96E2680
        public void get_copyStdFromDoubleWideMaterial(){} // RVA: 0x7FFAC96E2910
        public void get_copyMaterial(){} // RVA: 0x7FFAC96E2BA0
        public void get_copyFromTexArrayMaterial(){} // RVA: 0x7FFAC96E2E30
        public void get_copySheet(){} // RVA: 0x7FFAC96E30C0
        public void get_copyFromTexArraySheet(){} // RVA: 0x7FFAC96E3210
        public void isValidResources(){} // RVA: 0x7FFAC96E3360
        public void UpdateResources(){} // RVA: 0x7FFAC96E3460
        public void SetRenderTargetWithLoadStoreAction(){} // RVA: 0x7FFAC96E39F0 | overloaded x3
        public void BlitFullscreenTriangle(){} // RVA: 0x7FFAC96E53F0 | overloaded x5
        public void BlitFullscreenTriangleFromDoubleWide(){} // RVA: 0x7FFAC96E4460
        public void BlitFullscreenTriangleToDoubleWide(){} // RVA: 0x7FFAC96E4630
        public void BlitFullscreenTriangleFromTexArray(){} // RVA: 0x7FFAC96E48B0
        public void BlitFullscreenTriangleToTexArray(){} // RVA: 0x7FFAC96E4C90
        public void BuiltinBlit(){} // RVA: 0x7FFAC96E58D0 | overloaded x2
        public void CopyTexture(){} // RVA: 0x7FFAC96E5A70
        public void get_scriptableRenderPipelineActive(){} // RVA: 0x7FFAC96E5CD0
        public void get_supportsDeferredShading(){} // RVA: 0x7FFAC96E5DA0
        public void get_supportsDepthNormals(){} // RVA: 0x7FFAC96E5E40
        public void get_isSinglePassStereoEnabled(){} // RVA: 0x7FFAC96E5EE0
        public void get_isVREnabled(){} // RVA: 0x7FFAC96E5F80
        public void get_isAndroidOpenGL(){} // RVA: 0x7FFAC96E5FD0
        public void get_isWebNonWebGPU(){} // RVA: 0x7FFAC96E60A0
        public void get_defaultHDRRenderTextureFormat(){} // RVA: 0x7FFAC41E44C0
        public void isFloatingPointFormat(){} // RVA: 0x7FFAC96E6130
        public void hasAlpha(){} // RVA: 0x7FFAC96E6150
        public void Destroy(){} // RVA: 0x7FFAC96E61F0
        public void get_isLinearColorSpace(){} // RVA: 0x7FFAC96E62E0
        public void IsResolvedDepthAvailable(){} // RVA: 0x7FFAC96E6330
        public void DestroyProfile(){} // RVA: 0x7FFAC96E6410
        public void DestroyVolume(){} // RVA: 0x7FFAC96E65E0
        public void IsPostProcessingActive(){} // RVA: 0x7FFAC96E6700
        public void IsTemporalAntialiasingActive(){} // RVA: 0x7FFAC96E6810
        public void IsDynamicResolutionEnabled(){} // RVA: 0x7FFAC96E6970
        public void GetAllSceneObjects(){} // RVA: 0x7FFAC2C58A90
        public void CreateIfNull(){} // RVA: 0x7FFAC2C70A10
        public void Exp2(){} // RVA: 0x7FFAC96E6B80
        public void GetJitteredPerspectiveProjectionMatrix(){} // RVA: 0x7FFAC96E6B90
        public void GetJitteredOrthographicProjectionMatrix(){} // RVA: 0x7FFAC96E6EB0
        public void GenerateJitteredProjectionMatrixFromOriginal(){} // RVA: 0x7FFAC96E7200
        public void GetAllAssemblyTypes(){} // RVA: 0x7FFAC96E73E0
        public void GetAllTypesDerivedFrom(){} // RVA: 0x7FFAC2C58A90
        public void GetAttribute(){} // RVA: 0x7FFAC2E8DC40
        public void GetMemberAttributes(){} // RVA: 0x7FFAC2C58F80
        public void GetFieldPath(){} // RVA: 0x7FFAC2C58F80
        public void .cctor(){} // RVA: 0x7FFAC96E76A0
    }

    public class ScalableAO : Object
    {
        public UnityEngine.RenderTexture m_Result; // 0x10
        public UnityEngine.Rendering.PostProcessing.PropertySheet m_PropertySheet; // 0x18
        public UnityEngine.Rendering.PostProcessing.AmbientOcclusion m_Settings; // 0x20
        public UnityEngine.Rendering.RenderTargetIdentifier[] m_MRT; // 0x28
        public int[] m_SampleCount; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96BDF20
        public void GetCameraFlags(){} // RVA: 0x7FFAC366FE20
        public void DoLazyInitialization(){} // RVA: 0x7FFAC96BE170
        public void Render(){} // RVA: 0x7FFAC96BE7D0
        public void RenderAfterOpaque(){} // RVA: 0x7FFAC96BF540
        public void RenderAmbientOnly(){} // RVA: 0x7FFAC96BF830
        public void CompositeAmbientOnly(){} // RVA: 0x7FFAC96BF950
        public void Release(){} // RVA: 0x7FFAC96BFC30
    }

    public class ScreenSpaceReflectionPresetParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96BFCE0
    }

    public class ScreenSpaceReflectionResolutionParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96BFD30
    }

    public class ScreenSpaceReflections : PostProcessEffectSettings
    {
        public UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionPresetParameter preset; // 0x30
        public UnityEngine.Rendering.PostProcessing.IntParameter maximumIterationCount; // 0x38
        public UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionResolutionParameter resolution; // 0x40
        public UnityEngine.Rendering.PostProcessing.FloatParameter thickness; // 0x48
        public UnityEngine.Rendering.PostProcessing.FloatParameter maximumMarchDistance; // 0x50
        public UnityEngine.Rendering.PostProcessing.FloatParameter distanceFade; // 0x58
        public UnityEngine.Rendering.PostProcessing.FloatParameter vignette; // 0x60

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFAC96BFD80
        public void .ctor(){} // RVA: 0x7FFAC96BFF70
    }

    public class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer`1
    {
        public UnityEngine.RenderTexture m_Resolve; // 0x20
        public UnityEngine.RenderTexture m_History; // 0x28
        public int[] m_MipIDs; // 0x30
        public QualityPreset[] m_Presets; // 0x38

        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x7FFAC31E48B0
        public void CheckRT(){} // RVA: 0x7FFAC96C03F0
        public void Render(){} // RVA: 0x7FFAC96C08B0
        public void Release(){} // RVA: 0x7FFAC96C2190
        public void .ctor(){} // RVA: 0x7FFAC96C22B0
    }

    public class ShaderIDs : Object
    {
        public int MainTex;
        public int Jitter; // 0x4
        public int Sharpness; // 0x8
        public int FinalBlendParameters; // 0xC
        public int HistoryTex; // 0x10
        public int SMAA_Flip; // 0x14
        public int SMAA_Flop; // 0x18
        public int AOParams; // 0x1C
        public int AOColor; // 0x20
        public int OcclusionTexture1; // 0x24
        public int OcclusionTexture2; // 0x28
        public int SAOcclusionTexture; // 0x2C
        public int MSVOcclusionTexture; // 0x30
        public int DepthCopy; // 0x34
        public int LinearDepth; // 0x38
        public int LowDepth1; // 0x3C
        public int LowDepth2; // 0x40
        public int LowDepth3; // 0x44
        public int LowDepth4; // 0x48
        public int TiledDepth1; // 0x4C
        public int TiledDepth2; // 0x50
        public int TiledDepth3; // 0x54
        public int TiledDepth4; // 0x58
        public int Occlusion1; // 0x5C
        public int Occlusion2; // 0x60
        public int Occlusion3; // 0x64
        public int Occlusion4; // 0x68
        public int Combined1; // 0x6C
        public int Combined2; // 0x70
        public int Combined3; // 0x74
        public int SSRResolveTemp; // 0x78
        public int Noise; // 0x7C
        public int Test; // 0x80
        public int Resolve; // 0x84
        public int History; // 0x88
        public int ViewMatrix; // 0x8C
        public int InverseViewMatrix; // 0x90
        public int ScreenSpaceProjectionMatrix; // 0x94
        public int Params2; // 0x98
        public int FogColor; // 0x9C
        public int FogParams; // 0xA0
        public int VelocityScale; // 0xA4
        public int MaxBlurRadius; // 0xA8
        public int RcpMaxBlurRadius; // 0xAC
        public int VelocityTex; // 0xB0
        public int Tile2RT; // 0xB4
        public int Tile4RT; // 0xB8
        public int Tile8RT; // 0xBC
        public int TileMaxOffs; // 0xC0
        public int TileMaxLoop; // 0xC4
        public int TileVRT; // 0xC8
        public int NeighborMaxTex; // 0xCC
        public int LoopCount; // 0xD0
        public int DepthOfFieldTemp; // 0xD4
        public int DepthOfFieldTex; // 0xD8
        public int Distance; // 0xDC
        public int LensCoeff; // 0xE0
        public int MaxCoC; // 0xE4
        public int RcpMaxCoC; // 0xE8
        public int RcpAspect; // 0xEC
        public int CoCTex; // 0xF0
        public int TaaParams; // 0xF4
        public int AutoExposureTex; // 0xF8
        public int HistogramBuffer; // 0xFC
        public int Params; // 0x100
        public int ScaleOffsetRes; // 0x104
        public int BloomTex; // 0x108
        public int SampleScale; // 0x10C
        public int Threshold; // 0x110
        public int ColorIntensity; // 0x114
        public int Bloom_DirtTex; // 0x118
        public int Bloom_Settings; // 0x11C
        public int Bloom_Color; // 0x120
        public int Bloom_DirtTileOffset; // 0x124
        public int ChromaticAberration_Amount; // 0x128
        public int ChromaticAberration_SpectralLut; // 0x12C
        public int Distortion_CenterScale; // 0x130
        public int Distortion_Amount; // 0x134
        public int Lut2D; // 0x138
        public int Lut3D; // 0x13C
        public int Lut3D_Params; // 0x140
        public int Lut2D_Params; // 0x144
        public int UserLut2D_Params; // 0x148
        public int PostExposure; // 0x14C
        public int ColorBalance; // 0x150
        public int ColorFilter; // 0x154
        public int HueSatCon; // 0x158
        public int Brightness; // 0x15C
        public int ChannelMixerRed; // 0x160
        public int ChannelMixerGreen; // 0x164
        public int ChannelMixerBlue; // 0x168
        public int Lift; // 0x16C
        public int InvGamma; // 0x170
        public int Gain; // 0x174
        public int Curves; // 0x178
        public int CustomToneCurve; // 0x17C
        public int ToeSegmentA; // 0x180
        public int ToeSegmentB; // 0x184
        public int MidSegmentA; // 0x188
        public int MidSegmentB; // 0x18C
        public int ShoSegmentA; // 0x190
        public int ShoSegmentB; // 0x194
        public int Vignette_Color; // 0x198
        public int Vignette_Center; // 0x19C
        public int Vignette_Settings; // 0x1A0
        public int Vignette_Mask; // 0x1A4
        public int Vignette_Opacity; // 0x1A8
        public int Vignette_Mode; // 0x1AC
        public int Grain_Params1; // 0x1B0
        public int Grain_Params2; // 0x1B4
        public int GrainTex; // 0x1B8
        public int Phase; // 0x1BC
        public int GrainNoiseParameters; // 0x1C0
        public int LumaInAlpha; // 0x1C4
        public int DitheringTex; // 0x1C8
        public int Dithering_Coords; // 0x1CC
        public int From; // 0x1D0
        public int To; // 0x1D4
        public int Interp; // 0x1D8
        public int TargetColor; // 0x1DC
        public int HalfResFinalCopy; // 0x1E0
        public int WaveformSource; // 0x1E4
        public int WaveformBuffer; // 0x1E8
        public int VectorscopeBuffer; // 0x1EC
        public int RenderViewportScaleFactor; // 0x1F0
        public int UVTransform; // 0x1F4
        public int DepthSlice; // 0x1F8
        public int UVScaleOffset; // 0x1FC
        public int PosScaleOffset; // 0x200

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC96E78A0
    }

    public class Spline : Object
    {
        public int k_Precision;
        public float k_Step;
        public UnityEngine.AnimationCurve curve; // 0x10
        public bool m_Loop; // 0x18
        public float m_ZeroValue; // 0x1C
        public float m_Range; // 0x20
        public UnityEngine.AnimationCurve m_InternalLoopingCurve; // 0x28
        public int frameCount; // 0x30
        public float[] cachedData; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96EB0E0
        public void Cache(){} // RVA: 0x7FFAC96EB210
        public void Evaluate(){} // RVA: 0x7FFAC96EB5F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC96EB6B0
    }

    public class SplineParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC96C8EB0
        public void SetValue(){} // RVA: 0x7FFAC96C8ED0
        public void Interp(){} // RVA: 0x7FFAC96C8FE0
        public void .ctor(){} // RVA: 0x7FFAC96C91B0
    }

    public class SubpixelMorphologicalAntialiasing : Object
    {
        public 0x6B2717D0 quality; // 0x10

        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7FFAC96C2640
        public void Render(){} // RVA: 0x7FFAC96C2690
        public void .ctor(){} // RVA: 0x7FFAC96C2E70
    }

    public class TargetPool : Object
    {
        public System.Collections.Generic.List`1<int> m_Pool; // 0x10
        public int m_Current; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96EB6E0
        public void Get(){} // RVA: 0x7FFAC96EB7D0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAC36970B0
    }

    public class TemporalAntialiasing : Object
    {
        public float jitter; // 0x10
        public float sampleIndex; // 0x14
        public float stationaryBlending; // 0x18
        public float motionBlending; // 0x1C
        public System.Func`3<UnityEngine.Camera,UnityEngine.Vector2,UnityEngine.Matrix4x4> jitteredMatrixFunc; // 0x20
        public UnityEngine.Vector2 <jitter>k__BackingField; // 0x28
        public UnityEngine.Rendering.RenderTargetIdentifier[] m_Mrt; // 0x30
        public bool m_ResetHistory; // 0x38
        public int k_SampleCount;
        public int <sampleIndex>k__BackingField; // 0x3C
        public int k_NumEyes;
        public int k_NumHistoryTextures;
        public UnityEngine.RenderTexture[][] m_HistoryTextures; // 0x40
        public int[] m_HistoryPingPong; // 0x48

        // ── Methods ──
        public void get_jitter(){} // RVA: 0x7FFAC43A2620
        public void set_jitter(){} // RVA: 0x7FFAC33D3BF0
        public void get_sampleIndex(){} // RVA: 0x7FFAC33BD4A0
        public void set_sampleIndex(){} // RVA: 0x7FFAC47E2CD0
        public void IsSupported(){} // RVA: 0x7FFAC96C2E80
        public void GetCameraFlags(){} // RVA: 0x7FFAC31E48B0
        public void ResetHistory(){} // RVA: 0x7FFAC3C4CFE0
        public void GenerateRandomOffset(){} // RVA: 0x7FFAC96C2F60
        public void GetJitteredProjectionMatrix(){} // RVA: 0x7FFAC96C3040
        public void ConfigureJitteredProjectionMatrix(){} // RVA: 0x7FFAC96C3310
        public void ConfigureStereoJitteredProjectionMatrices(){} // RVA: 0x7FFAC96C34F0
        public void GenerateHistoryName(){} // RVA: 0x7FFAC96C3980
        public void CheckHistory(){} // RVA: 0x7FFAC96C3AF0
        public void Render(){} // RVA: 0x7FFAC96C4190
        public void Release(){} // RVA: 0x7FFAC96C4820
        public void .ctor(){} // RVA: 0x7FFAC96C4980
    }

    public class TextureFormatUtilities : Object
    {
        public System.Collections.Generic.Dictionary`2<int,0x6B17C180> s_FormatAliasMap;
        public System.Collections.Generic.Dictionary`2<int,bool> s_SupportedRenderTextureFormats; // 0x8
        public System.Collections.Generic.Dictionary`2<int,bool> s_SupportedTextureFormats; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC96EBA10
        public void IsObsolete(){} // RVA: 0x7FFAC96ECBD0
        public void GetUncompressedRenderTextureFormat(){} // RVA: 0x7FFAC96ECD60
        public void IsSupported(){} // RVA: 0x7FFAC96ED080 | overloaded x2
    }

    public class TextureLerper : Object
    {
        public UnityEngine.Rendering.PostProcessing.TextureLerper instance;
        public UnityEngine.Rendering.CommandBuffer m_Command; // 0x10
        public UnityEngine.Rendering.PostProcessing.PropertySheetFactory m_PropertySheets; // 0x18
        public UnityEngine.Rendering.PostProcessing.PostProcessResources m_Resources; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.RenderTexture> m_Recycled; // 0x28
        public System.Collections.Generic.List`1<UnityEngine.RenderTexture> m_Actives; // 0x30

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAC96ED150
        public void .ctor(){} // RVA: 0x7FFAC96ED350
        public void BeginFrame(){} // RVA: 0x7FFAC96ED490
        public void EndFrame(){} // RVA: 0x7FFAC96ED5D0
        public void Get(){} // RVA: 0x7FFAC96ED840
        public void Lerp(){} // RVA: 0x7FFAC96EE550 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC96EED90
    }

    public class TextureParameter : ParameterOverride`1
    {
        public 0x6B272068 defaultState; // 0x20

        // ── Methods ──
        public void Interp(){} // RVA: 0x7FFAC96C9240
        public void .ctor(){} // RVA: 0x7FFAC96C9D10
    }

    public class TonemapperParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96AB6A0
    }

    public class TrackballAttribute : Attribute
    {
        public 0x6B2704E8 mode; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class Vector2Parameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x7FFAC96C8BB0
        public void op_Implicit(){} // RVA: 0x7FFAC96C8C30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC96C8C80
    }

    public class Vector3Parameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x7FFAC96C8CD0
        public void op_Implicit(){} // RVA: 0x7FFAC96C8D50 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC96C8DB0
    }

    public class Vector4Parameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x7FFAC96C8AB0
        public void op_Implicit(){} // RVA: 0x7FFAC96C8E30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC96C8E70
    }

    public class VectorscopeMonitor : Monitor
    {
        public int size; // 0x20
        public float exposure; // 0x24
        public UnityEngine.ComputeBuffer m_Data; // 0x28
        public int k_ThreadGroupSizeX;
        public int k_ThreadGroupSizeY;

        // ── Methods ──
        public void OnDisable(){} // RVA: 0x7FFAC96C7150
        public void NeedsHalfRes(){} // RVA: 0x7FFAC3006850
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFAC96C7210
        public void Render(){} // RVA: 0x7FFAC96C7310
        public void .ctor(){} // RVA: 0x7FFAC96C7CF0
    }

    public class Vignette : PostProcessEffectSettings
    {
        public UnityEngine.Rendering.PostProcessing.VignetteModeParameter mode; // 0x30
        public UnityEngine.Rendering.PostProcessing.ColorParameter color; // 0x38
        public UnityEngine.Rendering.PostProcessing.Vector2Parameter center; // 0x40
        public UnityEngine.Rendering.PostProcessing.FloatParameter intensity; // 0x48
        public UnityEngine.Rendering.PostProcessing.FloatParameter smoothness; // 0x50
        public UnityEngine.Rendering.PostProcessing.FloatParameter roundness; // 0x58
        public UnityEngine.Rendering.PostProcessing.BoolParameter rounded; // 0x60
        public UnityEngine.Rendering.PostProcessing.TextureParameter mask; // 0x68
        public UnityEngine.Rendering.PostProcessing.FloatParameter opacity; // 0x70

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFAC96C4B80
        public void .ctor(){} // RVA: 0x7FFAC96C4CE0
    }

    public class VignetteModeParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96C4B30
    }

    public class VignetteRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x7FFAC96C52E0
        public void .ctor(){} // RVA: 0x7FFAC96C57E0
    }

    public class WaveformMonitor : Monitor
    {
        public float exposure; // 0x20
        public int height; // 0x24
        public UnityEngine.ComputeBuffer m_Data; // 0x28
        public int k_ThreadGroupSize;
        public int k_ThreadGroupSizeX;
        public int k_ThreadGroupSizeY;

        // ── Methods ──
        public void OnDisable(){} // RVA: 0x7FFAC96C7150
        public void NeedsHalfRes(){} // RVA: 0x7FFAC3006850
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFAC96C7D00
        public void Render(){} // RVA: 0x7FFAC96C7E00
        public void .ctor(){} // RVA: 0x7FFAC96C8960
    }

}