// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 59
// Methods: 461

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class AmbientOcclusion : PostProcessEffectSettings
    {
        public 0x665D0648 mode; // 0x30
        public 0x665D1DA8 intensity; // 0x38
        public 0x665D1EB0 color; // 0x40
        public 0x665D1E58 ambientOnly; // 0x48
        public 0x665D1DA8 noiseFilterTolerance; // 0x50
        public 0x665D1DA8 blurTolerance; // 0x58
        public 0x665D1DA8 upsampleTolerance; // 0x60
        public 0x665D1DA8 thicknessModifier; // 0x68
        public 0x665D1DA8 zBias; // 0x70
        public 0x665D1DA8 directLightingStrength; // 0x78
        public 0x665D1DA8 radius; // 0x80
        public 0x665D06A0 quality; // 0x88

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AC6320
        public void .ctor(){} // RVA: 0x7FFD54AC66D0
    }

    public class AutoExposure : PostProcessEffectSettings
    {
        public 0x665D1F08 filtering; // 0x30
        public 0x665D1DA8 minLuminance; // 0x38
        public 0x665D1DA8 maxLuminance; // 0x40
        public 0x665D1DA8 keyValue; // 0x48
        public 0x665D0858 eyeAdaptation; // 0x50
        public 0x665D1DA8 speedUp; // 0x58
        public 0x665D1DA8 speedDown; // 0x60

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AC7450
        public void .ctor(){} // RVA: 0x7FFD54AC7610
    }

    public class Bloom : PostProcessEffectSettings
    {
        public 0x665D1DA8 intensity; // 0x30
        public 0x665D1DA8 threshold; // 0x38
        public 0x665D1DA8 softKnee; // 0x40
        public 0x665D1DA8 clamp; // 0x48
        public 0x665D1DA8 diffusion; // 0x50
        public 0x665D1DA8 anamorphicRatio; // 0x58
        public 0x665D1EB0 color; // 0x60
        public 0x665D1E58 fastMode; // 0x68
        public 0x665D20C0 dirtTexture; // 0x70
        public 0x665D1DA8 dirtIntensity; // 0x78

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AC8E70
        public void .ctor(){} // RVA: 0x7FFD54AC8EB0
    }

    public class ChromaticAberration : PostProcessEffectSettings
    {
        public 0x665D20C0 spectralLut; // 0x30
        public 0x665D1DA8 intensity; // 0x38
        public 0x665D1E58 fastMode; // 0x40

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54ACAD10
        public void .ctor(){} // RVA: 0x7FFD54ACAD50
    }

    public class ColorGrading : PostProcessEffectSettings
    {
        public 0x665D0C20 gradingMode; // 0x30
        public 0x665D20C0 externalLut; // 0x38
        public 0x665D0C78 tonemapper; // 0x40
        public 0x665D1DA8 toneCurveToeStrength; // 0x48
        public 0x665D1DA8 toneCurveToeLength; // 0x50
        public 0x665D1DA8 toneCurveShoulderStrength; // 0x58
        public 0x665D1DA8 toneCurveShoulderLength; // 0x60
        public 0x665D1DA8 toneCurveShoulderAngle; // 0x68
        public 0x665D1DA8 toneCurveGamma; // 0x70
        public 0x665D20C0 ldrLut; // 0x78
        public 0x665D1DA8 ldrLutContribution; // 0x80
        public 0x665D1DA8 temperature; // 0x88
        public 0x665D1DA8 tint; // 0x90
        public 0x665D1EB0 colorFilter; // 0x98
        public 0x665D1DA8 hueShift; // 0xA0
        public 0x665D1DA8 saturation; // 0xA8
        public 0x665D1DA8 brightness; // 0xB0
        public 0x665D1DA8 postExposure; // 0xB8
        public 0x665D1DA8 contrast; // 0xC0
        public 0x665D1DA8 mixerRedOutRedIn; // 0xC8
        public 0x665D1DA8 mixerRedOutGreenIn; // 0xD0
        public 0x665D1DA8 mixerRedOutBlueIn; // 0xD8
        public 0x665D1DA8 mixerGreenOutRedIn; // 0xE0
        public 0x665D1DA8 mixerGreenOutGreenIn; // 0xE8
        public 0x665D1DA8 mixerGreenOutBlueIn; // 0xF0
        public 0x665D1DA8 mixerBlueOutRedIn; // 0xF8
        public 0x665D1DA8 mixerBlueOutGreenIn; // 0x100
        public 0x665D1DA8 mixerBlueOutBlueIn; // 0x108
        public 0x665D1FB8 lift; // 0x110
        public 0x665D1FB8 gamma; // 0x118
        public 0x665D1FB8 gain; // 0x120
        public 0x665D2010 masterCurve; // 0x128
        public 0x665D2010 redCurve; // 0x130
        public 0x665D2010 greenCurve; // 0x138
        public 0x665D2010 blueCurve; // 0x140
        public 0x665D2010 hueVsHueCurve; // 0x148
        public 0x665D2010 hueVsSatCurve; // 0x150
        public 0x665D2010 satVsSatCurve; // 0x158
        public 0x665D2010 lumVsSatCurve; // 0x160

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54ACB6F0
        public void .ctor(){} // RVA: 0x7FFD54ACB7B0
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
        public void StandardIlluminantY(){} // RVA: 0x7FFD54AFDC90
        public void CIExyToLMS(){} // RVA: 0x7FFD54AFDCC0
        public void ComputeColorBalance(){} // RVA: 0x7FFD54AFDD50
        public void ColorToLift(){} // RVA: 0x7FFD54AFDE70
        public void ColorToInverseGamma(){} // RVA: 0x7FFD54AFDEE0
        public void ColorToGain(){} // RVA: 0x7FFD54AFDF90
        public void LogCToLinear(){} // RVA: 0x7FFD54AFE000
        public void LinearToLogC(){} // RVA: 0x7FFD54AFE060
        public void ToHex(){} // RVA: 0x7FFD54AFE0B0
        public void ToRGBA(){} // RVA: 0x7FFD54AFE130
    }

    public class DepthOfField : PostProcessEffectSettings
    {
        public 0x665D1DA8 focusDistance; // 0x30
        public 0x665D1DA8 aperture; // 0x38
        public 0x665D1DA8 focalLength; // 0x40
        public 0x665D0E30 kernelSize; // 0x48

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AD2A60
        public void .ctor(){} // RVA: 0x7FFD54AD2AD0
    }

    public class DisplayNameAttribute : Attribute
    {
        public string displayName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class Dithering : Object
    {
        public int m_NoiseTextureIndex; // 0x10
        public System.Random m_Random; // 0x18

        // ── Methods ──
        public void Render(){} // RVA: 0x7FFD54AD4920
        public void .ctor(){} // RVA: 0x7FFD54AD4BF0
    }

    public class FastApproximateAntialiasing : Object
    {
        public bool fastMode; // 0x10
        public bool keepAlpha; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Fog : Object
    {
        public bool enabled; // 0x10
        public bool excludeSkybox; // 0x11

        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x7FFD4E433AF0
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AD4CA0
        public void Render(){} // RVA: 0x7FFD54AD4E10
        public void .ctor(){} // RVA: 0x7FFD4EBE9980
    }

    public class Grain : PostProcessEffectSettings
    {
        public 0x665D1E58 colored; // 0x30
        public 0x665D1DA8 intensity; // 0x38
        public 0x665D1DA8 size; // 0x40
        public 0x665D1DA8 lumContrib; // 0x48

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54ACAD10
        public void .ctor(){} // RVA: 0x7FFD54AD53D0
    }

    public class HableCurve : Object
    {
        public float whitePoint; // 0x10
        public float inverseWhitePoint; // 0x14
        public float x0; // 0x18
        public float x1; // 0x1C
        public 0x665D2C18[] m_Segments; // 0x20
        public 0x665D2CC8 uniforms; // 0x28

        // ── Methods ──
        public void get_whitePoint(){} // RVA: 0x7FFD4E46B320
        public void set_whitePoint(){} // RVA: 0x7FFD4E46B330
        public void get_inverseWhitePoint(){} // RVA: 0x7FFD4E46B340
        public void set_inverseWhitePoint(){} // RVA: 0x7FFD4E46B350
        public void get_x0(){} // RVA: 0x7FFD4E345CF0
        public void set_x0(){} // RVA: 0x7FFD4E35C4D0
        public void get_x1(){} // RVA: 0x7FFD4E40E570
        public void set_x1(){} // RVA: 0x7FFD4E40E580
        public void .ctor(){} // RVA: 0x7FFD54AFE1B0
        public void Eval(){} // RVA: 0x7FFD54AFE400
        public void Init(){} // RVA: 0x7FFD54AFE4A0
        public void InitSegments(){} // RVA: 0x7FFD54AFE6E0
        public void SolveAB(){} // RVA: 0x7FFD54AFEC20
        public void AsSlopeIntercept(){} // RVA: 0x7FFD54AFEC90
        public void EvalDerivativeLinearGamma(){} // RVA: 0x7FFD54AFECF0
    }

    public class HaltonSeq : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFD54AFEFE0
    }

    public class HistogramMonitor : Monitor
    {
        public int width; // 0x20
        public int height; // 0x24
        public 0x665D1A90 channel; // 0x28
        public UnityEngine.ComputeBuffer m_Data; // 0x30
        public int k_NumBins;
        public int k_ThreadGroupSizeX;
        public int k_ThreadGroupSizeY;

        // ── Methods ──
        public void OnDisable(){} // RVA: 0x7FFD54AE5820
        public void NeedsHalfRes(){} // RVA: 0x7FFD4E426850
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFD54AE58E0
        public void Render(){} // RVA: 0x7FFD54AE59E0
        public void .ctor(){} // RVA: 0x7FFD54AE6290
    }

    public class IAmbientOcclusionMethod
    {
        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x7FFD4E079960
        public void RenderAfterOpaque(){} // RVA: 0x7FFD4E090A40
        public void RenderAmbientOnly(){} // RVA: 0x7FFD4E090A40
        public void CompositeAmbientOnly(){} // RVA: 0x7FFD4E090A40
        public void Release(){} // RVA: 0x7FFD4E090980
    }

    public class LensDistortion : PostProcessEffectSettings
    {
        public 0x665D1DA8 intensity; // 0x30
        public 0x665D1DA8 intensityX; // 0x38
        public 0x665D1DA8 intensityY; // 0x40
        public 0x665D1DA8 centerX; // 0x48
        public 0x665D1DA8 centerY; // 0x50
        public 0x665D1DA8 scale; // 0x58

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AD6390
        public void .ctor(){} // RVA: 0x7FFD54AD6450
    }

    public class LightMeterMonitor : Monitor
    {
        public int width; // 0x20
        public int height; // 0x24
        public bool showCurves; // 0x28

        // ── Methods ──
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFD54AE62B0
        public void Render(){} // RVA: 0x7FFD54AE6420
        public void .ctor(){} // RVA: 0x7FFD54AE6C70
    }

    public class LogHistogram : Object
    {
        public int data;
        public int rangeMax;
        public int k_Bins;
        public UnityEngine.ComputeBuffer <data>k__BackingField; // 0x10

        // ── Methods ──
        public void get_data(){} // RVA: 0x7FFD4E35C380
        public void set_data(){} // RVA: 0x7FFD4E342E30
        public void Generate(){} // RVA: 0x7FFD54AFF040
        public void GetHistogramScaleOffsetRes(){} // RVA: 0x7FFD54AFF680
        public void Release(){} // RVA: 0x7FFD54AFF6D0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class MaxAttribute : Attribute
    {
        public float max; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E46B330
    }

    public class MeshUtilities : Object
    {
        public System.Collections.Generic.Dictionary`2<0x664D94D0,UnityEngine.Mesh> s_Primitives;
        public System.Collections.Generic.Dictionary`2<System.Type,0x664D94D0> s_ColliderPrimitives; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54AFF750
        public void GetColliderMesh(){} // RVA: 0x7FFD54AFFB30
        public void GetPrimitive(){} // RVA: 0x7FFD54AFFD20
        public void GetBuiltinMesh(){} // RVA: 0x7FFD54AFFF50
    }

    public class MinAttribute : Attribute
    {
        public float min; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E46B330
    }

    public class MinMaxAttribute : Attribute
    {
        public float min; // 0x10
        public float max; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4EF4F3C0
    }

    public class Monitor : Object
    {
        public UnityEngine.RenderTexture output; // 0x10
        public bool requested; // 0x18

        // ── Methods ──
        public void get_output(){} // RVA: 0x7FFD4E35C380
        public void set_output(){} // RVA: 0x7FFD4E342E30
        public void IsRequestedAndSupported(){} // RVA: 0x7FFD54AE6C90
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFD4E079F60
        public void NeedsHalfRes(){} // RVA: 0x7FFD4E341320
        public void CheckOutput(){} // RVA: 0x7FFD54AE6D80
        public void OnEnable(){} // RVA: 0x7FFD4E341310
        public void OnDisable(){} // RVA: 0x7FFD54AE70F0
        public void Render(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class MotionBlur : PostProcessEffectSettings
    {
        public 0x665D1DA8 shutterAngle; // 0x30
        public 0x665D1E00 sampleCount; // 0x38

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AD6C00
        public void .ctor(){} // RVA: 0x7FFD54AD6D00
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
        public 0x664DC180 m_R8Format; // 0x68
        public 0x664DC180 m_R16Format; // 0x6C
        public bool float4Texture; // 0x70
        public 0x664E6AF8[] m_MRT; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54AD7FF0
        public void GetCameraFlags(){} // RVA: 0x7FFD4E433AF0
        public void SetResources(){} // RVA: 0x7FFD4E409510
        public void Alloc(){} // RVA: 0x7FFD54AD88A0
        public void AllocArray(){} // RVA: 0x7FFD54AD8AA0
        public void Release(){} // RVA: 0x7FFD54ADDE70 | overloaded x2
        public void CalculateZBufferParams(){} // RVA: 0x7FFD54AD8D10
        public void CalculateTanHalfFovHeight(){} // RVA: 0x7FFD54AD8E70
        public void GetSize(){} // RVA: 0x7FFD54AD8F00
        public void GetSizeArray(){} // RVA: 0x7FFD54AD8F60
        public void GenerateAOMap(){} // RVA: 0x7FFD54AD8FC0
        public void PushAllocCommands(){} // RVA: 0x7FFD54AD9D30
        public void PushDownsampleCommands(){} // RVA: 0x7FFD54ADA4F0
        public void PushRenderCommands(){} // RVA: 0x7FFD54ADB2E0
        public void PushUpsampleCommands(){} // RVA: 0x7FFD54ADBE40
        public void PushReleaseCommands(){} // RVA: 0x7FFD54ADC580
        public void PreparePropertySheet(){} // RVA: 0x7FFD54ADCB50
        public void CheckAOTexture(){} // RVA: 0x7FFD54ADCD90
        public void PushDebug(){} // RVA: 0x7FFD54ADD220
        public void RenderAfterOpaque(){} // RVA: 0x7FFD54ADD2F0
        public void RenderAmbientOnly(){} // RVA: 0x7FFD54ADD950
        public void CompositeAmbientOnly(){} // RVA: 0x7FFD54ADDB90
    }

    public class ParameterOverride : Object
    {
        public bool overrideState; // 0x10

        // ── Methods ──
        public void Interp(){}
        public void GetHash(){} // RVA: 0x7FFD4E079960
        public void GetValue(){} // RVA: 0x7FFD4E2ADC40
        public void OnEnable(){} // RVA: 0x7FFD4E341310
        public void OnDisable(){} // RVA: 0x7FFD4E341310
        public void SetValue(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ParameterOverride`1 : ParameterOverride
    {
        public T value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void Interp(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Override(){} // RVA: 0x7FFD4E2ADC40
        public void SetValue(){} // RVA: 0x7FFD4E090A40
        public void GetHash(){} // RVA: 0x7FFD4E079960
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40
    }

    public class PostProcessAttribute : Attribute
    {
        public System.Type renderer; // 0x10
        public 0x665D2488 eventType; // 0x18
        public string menuItem; // 0x20
        public bool allowInSceneView; // 0x28
        public bool builtinEffect; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54AC61C0 | overloaded x2
    }

    public class PostProcessBundle : Object
    {
        public UnityEngine.Rendering.PostProcessing.PostProcessAttribute attribute; // 0x10
        public UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings settings; // 0x18
        public UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer renderer; // 0x20

        // ── Methods ──
        public void get_attribute(){} // RVA: 0x7FFD4E35C380
        public void set_attribute(){} // RVA: 0x7FFD4E342E30
        public void get_settings(){} // RVA: 0x7FFD4E3447C0
        public void set_settings(){} // RVA: 0x7FFD4E3A7E80
        public void get_renderer(){} // RVA: 0x7FFD54AE9DA0
        public void .ctor(){} // RVA: 0x7FFD54AE9F10
        public void Release(){} // RVA: 0x7FFD54AEA040
        public void ResetHistory(){} // RVA: 0x7FFD54AEA0B0
        public void CastSettings(){} // RVA: 0x7FFD4E2ADC40
        public void CastRenderer(){} // RVA: 0x7FFD4E2ADC40
    }

    public class PostProcessDebug : MonoBehaviour
    {
        public UnityEngine.Rendering.PostProcessing.PostProcessLayer postProcessLayer; // 0x20
        public UnityEngine.Rendering.PostProcessing.PostProcessLayer m_PreviousPostProcessLayer; // 0x28
        public bool lightMeter; // 0x30
        public bool histogram; // 0x31
        public bool waveform; // 0x32
        public bool vectorscope; // 0x33
        public 0x665D21C8 debugOverlay; // 0x34
        public UnityEngine.Camera m_CurrentCamera; // 0x38
        public UnityEngine.Rendering.CommandBuffer m_CmdAfterEverything; // 0x40

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD54AEA0D0
        public void OnDisable(){} // RVA: 0x7FFD54AEA210
        public void Update(){} // RVA: 0x7FFD54AEA3B0
        public void Reset(){} // RVA: 0x7FFD54AEA3C0
        public void UpdateStates(){} // RVA: 0x7FFD54AEA450
        public void OnPostRender(){} // RVA: 0x7FFD54AEA9C0
        public void OnGUI(){} // RVA: 0x7FFD54AEAD50
        public void DrawMonitor(){} // RVA: 0x7FFD54AEAF70
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class PostProcessDebugLayer : Object
    {
        public UnityEngine.Rendering.PostProcessing.LightMeterMonitor debugOverlayTarget; // 0x10
        public UnityEngine.Rendering.PostProcessing.HistogramMonitor debugOverlayActive; // 0x18
        public UnityEngine.Rendering.PostProcessing.WaveformMonitor debugOverlay; // 0x20
        public UnityEngine.Rendering.PostProcessing.VectorscopeMonitor vectorscope; // 0x28
        public System.Collections.Generic.Dictionary`2<0x665D1B98,UnityEngine.Rendering.PostProcessing.Monitor> m_Monitors; // 0x30
        public int frameWidth; // 0x38
        public int frameHeight; // 0x3C
        public UnityEngine.RenderTexture <debugOverlayTarget>k__BackingField; // 0x40
        public bool <debugOverlayActive>k__BackingField; // 0x48
        public 0x665D21C8 <debugOverlay>k__BackingField; // 0x4C
        public 0x665D2278 overlaySettings; // 0x50

        // ── Methods ──
        public void get_debugOverlayTarget(){} // RVA: 0x7FFD4E3BE740
        public void set_debugOverlayTarget(){} // RVA: 0x7FFD4E369200
        public void get_debugOverlayActive(){} // RVA: 0x7FFD4E3F8D30
        public void set_debugOverlayActive(){} // RVA: 0x7FFD4E3F8D40
        public void get_debugOverlay(){} // RVA: 0x7FFD4F34D3C0
        public void set_debugOverlay(){} // RVA: 0x7FFD4FCBE500
        public void OnEnable(){} // RVA: 0x7FFD54AEB160
        public void OnDisable(){} // RVA: 0x7FFD54AEB540
        public void DestroyDebugOverlayTarget(){} // RVA: 0x7FFD54AEB6E0
        public void RequestMonitorPass(){} // RVA: 0x7FFD54AEB790
        public void RequestDebugOverlay(){} // RVA: 0x7FFD4FCBE500
        public void SetFrameSize(){} // RVA: 0x7FFD54AEB800
        public void PushDebugOverlay(){} // RVA: 0x7FFD54AEB810
        public void GetCameraFlags(){} // RVA: 0x7FFD54AEBD40
        public void RenderMonitors(){} // RVA: 0x7FFD54AEBD70
        public void RenderSpecialOverlays(){} // RVA: 0x7FFD54AEC3D0
        public void EndFrame(){} // RVA: 0x7FFD54AEC920
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class PostProcessEffectRenderer : Object
    {
        public bool m_ResetHistory; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFD4E341310
        public void GetCameraFlags(){} // RVA: 0x7FFD4E919180
        public void ResetHistory(){} // RVA: 0x7FFD4E64C870
        public void Release(){} // RVA: 0x7FFD4F30A090
        public void Render(){} // RVA: 0x7FFD4E090A40
        public void SetSettings(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E64C870
    }

    public class PostProcessEffectRendererExtensions : Object
    {
        // ── Methods ──
        public void RenderOrLog(){} // RVA: 0x7FFD54B00070
    }

    public class PostProcessEffectRenderer`1 : PostProcessEffectRenderer
    {
        public T settings;

        // ── Methods ──
        public void get_settings(){} // RVA: 0x7FFD4E2ADC40
        public void set_settings(){} // RVA: 0x7FFD4E2ADC40
        public void SetSettings(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class PostProcessEffectSettings : ScriptableObject
    {
        public bool active; // 0x18
        public 0x665D1E58 enabled; // 0x20
        public System.Collections.ObjectModel.ReadOnlyCollection`1<UnityEngine.Rendering.PostProcessing.ParameterOverride> parameters; // 0x28

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD54AECAE0
        public void OnDisable(){} // RVA: 0x7FFD54AED180
        public void SetAllOverridesTo(){} // RVA: 0x7FFD54AED380
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AED5A0
        public void GetHash(){} // RVA: 0x7FFD54AED5C0
        public void .ctor(){} // RVA: 0x7FFD54AED7E0
        public void <OnEnable>b__3_2(){} // RVA: 0x7FFD54AED8B0
    }

    public class PostProcessEventComparer : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD511BE3D0
        public void GetHashCode(){} // RVA: 0x7FFD5120A830
    }

    public class PostProcessLayer : MonoBehaviour
    {
        public UnityEngine.Transform sortedBundles; // 0x20
        public UnityEngine.LayerMask cameraDepthFlags; // 0x28
        public bool haveBundlesBeenInited; // 0x2C
        public bool finalBlitToCameraTarget; // 0x2D
        public 0x665D2538 antialiasingMode; // 0x30
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
        public System.Collections.Generic.List`1<0x665D2590> m_BeforeTransparentBundles; // 0x80
        public System.Collections.Generic.List`1<0x665D2590> m_BeforeStackBundles; // 0x88
        public System.Collections.Generic.List`1<0x665D2590> m_AfterStackBundles; // 0x90
        public System.Collections.Generic.Dictionary`2<0x665D2488,System.Collections.Generic.List`1<0x665D2590>> <sortedBundles>k__BackingField; // 0x98
        public 0x664DBD08 <cameraDepthFlags>k__BackingField; // 0xA0
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
        public System.Collections.Generic.List`1<0x664E6AF8> m_Targets; // 0x110

        // ── Methods ──
        public void get_sortedBundles(){} // RVA: 0x7FFD4E96DFB0
        public void set_sortedBundles(){} // RVA: 0x7FFD4E96E3C0
        public void get_cameraDepthFlags(){} // RVA: 0x7FFD4FCBE510
        public void set_cameraDepthFlags(){} // RVA: 0x7FFD4FCBE550
        public void get_haveBundlesBeenInited(){} // RVA: 0x7FFD4E565120
        public void set_haveBundlesBeenInited(){} // RVA: 0x7FFD4E55EEF0
        public void OnEnable(){} // RVA: 0x7FFD54AEDB20
        public void InitLegacy(){} // RVA: 0x7FFD54AEDEA0
        public void DynamicResolutionAllowsFinalBlitToCameraTarget(){} // RVA: 0x7FFD54AEE4B0
        public void OnRenderImage(){} // RVA: 0x7FFD54AEE5B0
        public void Init(){} // RVA: 0x7FFD54AEE670
        public void InitBundles(){} // RVA: 0x7FFD54AEE870
        public void UpdateBundleSortList(){} // RVA: 0x7FFD54AEEFC0
        public void OnDisable(){} // RVA: 0x7FFD54AEF8C0
        public void Reset(){} // RVA: 0x7FFD54AEFEF0
        public void OnPreCull(){} // RVA: 0x7FFD54AEFF90
        public void OnPreRender(){} // RVA: 0x7FFD54AF0C10
        public void RequiresInitialBlit(){} // RVA: 0x7FFD4E426850
        public void UpdateSrcDstForOpaqueOnly(){} // RVA: 0x7FFD54AF0CD0
        public void BuildCommandBuffers(){} // RVA: 0x7FFD54AF0F00
        public void OnPostRender(){} // RVA: 0x7FFD54AF2340
        public void GetBundle(){} // RVA: 0x7FFD54AF25C0 | overloaded x2
        public void GetSettings(){} // RVA: 0x7FFD4E2ADC40
        public void BakeMSVOMap(){} // RVA: 0x7FFD54AF2620
        public void OverrideSettings(){} // RVA: 0x7FFD54AF2820
        public void SetLegacyCameraFlags(){} // RVA: 0x7FFD54AF2AB0
        public void ResetHistory(){} // RVA: 0x7FFD54AF2E50
        public void HasOpaqueOnlyEffects(){} // RVA: 0x7FFD54AF3000
        public void HasActiveEffects(){} // RVA: 0x7FFD54AF3010
        public void SetupContext(){} // RVA: 0x7FFD54AF3250
        public void UpdateVolumeSystem(){} // RVA: 0x7FFD54AF3820
        public void RenderOpaqueOnly(){} // RVA: 0x7FFD54AF39F0
        public void Render(){} // RVA: 0x7FFD54AF3AF0
        public void RenderInjectionPoint(){} // RVA: 0x7FFD54AF4850
        public void RenderList(){} // RVA: 0x7FFD54AF4AF0
        public void ApplyFlip(){} // RVA: 0x7FFD54AF5340
        public void ApplyDefaultFlip(){} // RVA: 0x7FFD54AF5450
        public void RenderBuiltins(){} // RVA: 0x7FFD54AF55A0
        public void RenderFinalPass(){} // RVA: 0x7FFD54AF6290
        public void RenderEffect(){}
        public void ShouldGenerateLogHistogram(){} // RVA: 0x7FFD54AF6E60
        public void .ctor(){} // RVA: 0x7FFD54AF6F10
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
        public void get_instance(){} // RVA: 0x7FFD54AF73F0
        public void .ctor(){} // RVA: 0x7FFD54AF74D0
        public void CleanBaseTypes(){} // RVA: 0x7FFD54AF78F0
        public void ReloadBaseTypes(){} // RVA: 0x7FFD54AF7AD0
        public void GetActiveVolumes(){} // RVA: 0x7FFD54AF8110
        public void GetHighestPriorityVolume(){} // RVA: 0x7FFD54AF8A10 | overloaded x2
        public void QuickVolume(){} // RVA: 0x7FFD54AF8BF0
        public void SetLayerDirty(){} // RVA: 0x7FFD54AF8E60
        public void UpdateVolumeLayer(){} // RVA: 0x7FFD54AF9030
        public void Register(){} // RVA: 0x7FFD54AF9280 | overloaded x2
        public void Unregister(){} // RVA: 0x7FFD54AF9550 | overloaded x2
        public void ReplaceData(){} // RVA: 0x7FFD54AF9630
        public void UpdateSettings(){} // RVA: 0x7FFD54AF9920
        public void GrabVolumes(){} // RVA: 0x7FFD54AFA1C0
        public void SortByPriority(){} // RVA: 0x7FFD54AFA710
        public void IsVolumeRenderedByCamera(){} // RVA: 0x7FFD4E426850
    }

    public class PostProcessProfile : ScriptableObject
    {
        public System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings> settings; // 0x18
        public bool isDirty; // 0x20

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD54AFAA00
        public void AddSettings(){} // RVA: 0x7FFD54AFAD70 | overloaded x3
        public void RemoveSettings(){} // RVA: 0x7FFD54AFAE40 | overloaded x2
        public void HasSettings(){} // RVA: 0x7FFD54AFAFD0 | overloaded x2
        public void GetSetting(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetSettings(){} // RVA: 0x7FFD4E079F60
        public void .ctor(){} // RVA: 0x7FFD54AFB170
    }

    public class PostProcessRenderContext : Object
    {
        public UnityEngine.Camera camera; // 0x10
        public UnityEngine.Rendering.CommandBuffer command; // 0x18
        public 0x664E6AF8 source; // 0x20
        public 0x664E6AF8 destination; // 0x48
        public 0x664DC180 sourceFormat; // 0x70
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
        public 0x665D2958 stereoRenderingMode; // 0xAC
        public int screenWidth; // 0xB0
        public int screenHeight; // 0xB4
        public bool isSceneView; // 0xB8
        public 0x665D2538 antialiasing; // 0xBC
        public UnityEngine.Rendering.PostProcessing.TemporalAntialiasing temporalAntialiasing; // 0xC0
        public UnityEngine.Rendering.PostProcessing.PropertySheet uberSheet; // 0xC8
        public UnityEngine.Texture autoExposureTexture; // 0xD0
        public UnityEngine.Rendering.PostProcessing.LogHistogram logHistogram; // 0xD8
        public UnityEngine.Texture logLut; // 0xE0
        public UnityEngine.Rendering.PostProcessing.AutoExposure autoExposure; // 0xE8
        public int bloomBufferNameID; // 0xF0
        public bool physicalCamera; // 0xF4
        public 0x664DCFF0 m_sourceDescriptor; // 0xF8

        // ── Methods ──
        public void get_camera(){} // RVA: 0x7FFD4E35C380
        public void set_camera(){} // RVA: 0x7FFD54AFB3B0
        public void get_command(){} // RVA: 0x7FFD4E3447C0
        public void set_command(){} // RVA: 0x7FFD4E3A7E80
        public void get_source(){} // RVA: 0x7FFD4E90A3D0
        public void set_source(){} // RVA: 0x7FFD54AFB780
        public void get_destination(){} // RVA: 0x7FFD4E90A260
        public void set_destination(){} // RVA: 0x7FFD54AFB7A0
        public void get_sourceFormat(){} // RVA: 0x7FFD4EFB9E80
        public void set_sourceFormat(){} // RVA: 0x7FFD4E4D6520
        public void get_flip(){} // RVA: 0x7FFD4EFED8B0
        public void set_flip(){} // RVA: 0x7FFD535E5400
        public void get_resources(){} // RVA: 0x7FFD4E505600
        public void set_resources(){} // RVA: 0x7FFD4E5006F0
        public void get_propertySheets(){} // RVA: 0x7FFD4E70F410
        public void set_propertySheets(){} // RVA: 0x7FFD4E8F4AA0
        public void get_userData(){} // RVA: 0x7FFD4E380010
        public void set_userData(){} // RVA: 0x7FFD4E96E300
        public void get_debugLayer(){} // RVA: 0x7FFD4E70F640
        public void set_debugLayer(){} // RVA: 0x7FFD4E96E360
        public void get_width(){} // RVA: 0x7FFD4FCBE530
        public void set_width(){} // RVA: 0x7FFD4FCBE540
        public void get_height(){} // RVA: 0x7FFD4FCBE520
        public void set_height(){} // RVA: 0x7FFD4FCBEAA0
        public void get_stereoActive(){} // RVA: 0x7FFD4F9E9D50
        public void set_stereoActive(){} // RVA: 0x7FFD4EBD1910
        public void get_xrActiveEye(){} // RVA: 0x7FFD51959470
        public void set_xrActiveEye(){} // RVA: 0x7FFD51959480
        public void get_numberOfEyes(){} // RVA: 0x7FFD4ED255C0
        public void set_numberOfEyes(){} // RVA: 0x7FFD4ED1D010
        public void get_stereoRenderingMode(){} // RVA: 0x7FFD51959490
        public void set_stereoRenderingMode(){} // RVA: 0x7FFD519594A0
        public void get_screenWidth(){} // RVA: 0x7FFD500181F0
        public void set_screenWidth(){} // RVA: 0x7FFD53BD5A90
        public void get_screenHeight(){} // RVA: 0x7FFD51B35300
        public void set_screenHeight(){} // RVA: 0x7FFD51B35310
        public void get_isSceneView(){} // RVA: 0x7FFD4F611470
        public void set_isSceneView(){} // RVA: 0x7FFD4F60EB20
        public void get_antialiasing(){} // RVA: 0x7FFD4EBCB780
        public void set_antialiasing(){} // RVA: 0x7FFD54AFB7C0
        public void get_temporalAntialiasing(){} // RVA: 0x7FFD4E3AC120
        public void set_temporalAntialiasing(){} // RVA: 0x7FFD4E3AC130
        public void Reset(){} // RVA: 0x7FFD54AFB7D0
        public void IsTemporalAntialiasingActive(){} // RVA: 0x7FFD54AFBDB0
        public void IsDebugOverlayEnabled(){} // RVA: 0x7FFD54AFBDF0
        public void PushDebugOverlay(){} // RVA: 0x7FFD54AFBE20
        public void GetDescriptor(){} // RVA: 0x7FFD54AFBE80
        public void GetScreenSpaceTemporaryRT(){} // RVA: 0x7FFD54AFC150 | overloaded x2
        public void UpdateSinglePassStereoState(){} // RVA: 0x7FFD54AFC1E0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class PostProcessResources : ScriptableObject
    {
        public UnityEngine.Texture2D[] blueNoise64; // 0x18
        public UnityEngine.Texture2D[] blueNoise256; // 0x20
        public 0x665D2AB8 smaaLuts; // 0x28
        public 0x665D2A08 shaders; // 0x30
        public 0x665D2A60 computeShaders; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
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
        public void get_profile(){} // RVA: 0x7FFD54AFC480
        public void set_profile(){} // RVA: 0x7FFD4E3BC740
        public void get_profileRef(){} // RVA: 0x7FFD54AFC870
        public void HasInstantiatedProfile(){} // RVA: 0x7FFD54AFC950
        public void get_previousLayer(){} // RVA: 0x7FFD4E9AA870
        public void OnEnable(){} // RVA: 0x7FFD54AFCA20
        public void OnDisable(){} // RVA: 0x7FFD54AFCC50
        public void Update(){} // RVA: 0x7FFD54AFCD40
        public void OnDrawGizmos(){} // RVA: 0x7FFD54AFCE80
        public void .ctor(){} // RVA: 0x7FFD54AFDC40
    }

    public class PropertySheet : Object
    {
        public UnityEngine.MaterialPropertyBlock properties; // 0x10
        public UnityEngine.Material material; // 0x18

        // ── Methods ──
        public void get_properties(){} // RVA: 0x7FFD4E35C380
        public void set_properties(){} // RVA: 0x7FFD4E342E30
        public void get_material(){} // RVA: 0x7FFD4E3447C0
        public void set_material(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD54B000E0
        public void ClearKeywords(){} // RVA: 0x7FFD54B00220
        public void EnableKeyword(){} // RVA: 0x7FFD54B00280
        public void DisableKeyword(){} // RVA: 0x7FFD54B002F0
        public void Release(){} // RVA: 0x7FFD54B00360
    }

    public class PropertySheetFactory : Object
    {
        public System.Collections.Generic.Dictionary`2<UnityEngine.Shader,UnityEngine.Rendering.PostProcessing.PropertySheet> m_Sheets; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54B00410
        public void Get(){} // RVA: 0x7FFD54B00620 | overloaded x2
        public void Release(){} // RVA: 0x7FFD54B00940
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
        public void get_whiteTexture(){} // RVA: 0x7FFD54B00C50
        public void get_whiteTexture3D(){} // RVA: 0x7FFD54B00F00
        public void get_blackTexture(){} // RVA: 0x7FFD54B011D0
        public void get_blackTexture3D(){} // RVA: 0x7FFD54B01490
        public void get_transparentTexture(){} // RVA: 0x7FFD54B01760
        public void get_transparentTexture3D(){} // RVA: 0x7FFD54B01A20
        public void GetLutStrip(){} // RVA: 0x7FFD54B01CF0
        public void get_fullscreenTriangle(){} // RVA: 0x7FFD54B02170
        public void get_copyStdMaterial(){} // RVA: 0x7FFD54B02680
        public void get_copyStdFromDoubleWideMaterial(){} // RVA: 0x7FFD54B02910
        public void get_copyMaterial(){} // RVA: 0x7FFD54B02BA0
        public void get_copyFromTexArrayMaterial(){} // RVA: 0x7FFD54B02E30
        public void get_copySheet(){} // RVA: 0x7FFD54B030C0
        public void get_copyFromTexArraySheet(){} // RVA: 0x7FFD54B03210
        public void isValidResources(){} // RVA: 0x7FFD54B03360
        public void UpdateResources(){} // RVA: 0x7FFD54B03460
        public void SetRenderTargetWithLoadStoreAction(){} // RVA: 0x7FFD54B039F0 | overloaded x3
        public void BlitFullscreenTriangle(){} // RVA: 0x7FFD54B053F0 | overloaded x5
        public void BlitFullscreenTriangleFromDoubleWide(){} // RVA: 0x7FFD54B04460
        public void BlitFullscreenTriangleToDoubleWide(){} // RVA: 0x7FFD54B04630
        public void BlitFullscreenTriangleFromTexArray(){} // RVA: 0x7FFD54B048B0
        public void BlitFullscreenTriangleToTexArray(){} // RVA: 0x7FFD54B04C90
        public void BuiltinBlit(){} // RVA: 0x7FFD54B058D0 | overloaded x2
        public void CopyTexture(){} // RVA: 0x7FFD54B05A70
        public void get_scriptableRenderPipelineActive(){} // RVA: 0x7FFD54B05CD0
        public void get_supportsDeferredShading(){} // RVA: 0x7FFD54B05DA0
        public void get_supportsDepthNormals(){} // RVA: 0x7FFD54B05E40
        public void get_isSinglePassStereoEnabled(){} // RVA: 0x7FFD54B05EE0
        public void get_isVREnabled(){} // RVA: 0x7FFD54B05F80
        public void get_isAndroidOpenGL(){} // RVA: 0x7FFD54B05FD0
        public void get_isWebNonWebGPU(){} // RVA: 0x7FFD54B060A0
        public void get_defaultHDRRenderTextureFormat(){} // RVA: 0x7FFD4F6044C0
        public void isFloatingPointFormat(){} // RVA: 0x7FFD54B06130
        public void hasAlpha(){} // RVA: 0x7FFD54B06150
        public void Destroy(){} // RVA: 0x7FFD54B061F0
        public void get_isLinearColorSpace(){} // RVA: 0x7FFD54B062E0
        public void IsResolvedDepthAvailable(){} // RVA: 0x7FFD54B06330
        public void DestroyProfile(){} // RVA: 0x7FFD54B06410
        public void DestroyVolume(){} // RVA: 0x7FFD54B065E0
        public void IsPostProcessingActive(){} // RVA: 0x7FFD54B06700
        public void IsTemporalAntialiasingActive(){} // RVA: 0x7FFD54B06810
        public void IsDynamicResolutionEnabled(){} // RVA: 0x7FFD54B06970
        public void GetAllSceneObjects(){} // RVA: 0x7FFD4E078A90
        public void CreateIfNull(){} // RVA: 0x7FFD4E090A10
        public void Exp2(){} // RVA: 0x7FFD54B06B80
        public void GetJitteredPerspectiveProjectionMatrix(){} // RVA: 0x7FFD54B06B90
        public void GetJitteredOrthographicProjectionMatrix(){} // RVA: 0x7FFD54B06EB0
        public void GenerateJitteredProjectionMatrixFromOriginal(){} // RVA: 0x7FFD54B07200
        public void GetAllAssemblyTypes(){} // RVA: 0x7FFD54B073E0
        public void GetAllTypesDerivedFrom(){} // RVA: 0x7FFD4E078A90
        public void GetAttribute(){} // RVA: 0x7FFD4E2ADC40
        public void GetMemberAttributes(){} // RVA: 0x7FFD4E078F80
        public void GetFieldPath(){} // RVA: 0x7FFD4E078F80
        public void .cctor(){} // RVA: 0x7FFD54B076A0
    }

    public class ScalableAO : Object
    {
        public UnityEngine.RenderTexture m_Result; // 0x10
        public UnityEngine.Rendering.PostProcessing.PropertySheet m_PropertySheet; // 0x18
        public UnityEngine.Rendering.PostProcessing.AmbientOcclusion m_Settings; // 0x20
        public 0x664E6AF8[] m_MRT; // 0x28
        public int[] m_SampleCount; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54ADDF20
        public void GetCameraFlags(){} // RVA: 0x7FFD4EA8FE20
        public void DoLazyInitialization(){} // RVA: 0x7FFD54ADE170
        public void Render(){} // RVA: 0x7FFD54ADE7D0
        public void RenderAfterOpaque(){} // RVA: 0x7FFD54ADF540
        public void RenderAmbientOnly(){} // RVA: 0x7FFD54ADF830
        public void CompositeAmbientOnly(){} // RVA: 0x7FFD54ADF950
        public void Release(){} // RVA: 0x7FFD54ADFC30
    }

    public class ScreenSpaceReflections : PostProcessEffectSettings
    {
        public 0x665D1568 preset; // 0x30
        public 0x665D1E00 maximumIterationCount; // 0x38
        public 0x665D15C0 resolution; // 0x40
        public 0x665D1DA8 thickness; // 0x48
        public 0x665D1DA8 maximumMarchDistance; // 0x50
        public 0x665D1DA8 distanceFade; // 0x58
        public 0x665D1DA8 vignette; // 0x60

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54ADFD80
        public void .ctor(){} // RVA: 0x7FFD54ADFF70
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
        public void .cctor(){} // RVA: 0x7FFD54B078A0
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
        public void .ctor(){} // RVA: 0x7FFD54B0B0E0
        public void Cache(){} // RVA: 0x7FFD54B0B210
        public void Evaluate(){} // RVA: 0x7FFD54B0B5F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54B0B6B0
    }

    public class SubpixelMorphologicalAntialiasing : Object
    {
        public 0x665D17D0 quality; // 0x10

        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7FFD54AE2640
        public void Render(){} // RVA: 0x7FFD54AE2690
        public void .ctor(){} // RVA: 0x7FFD54AE2E70
    }

    public class TargetPool : Object
    {
        public System.Collections.Generic.List`1<int> m_Pool; // 0x10
        public int m_Current; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54B0B6E0
        public void Get(){} // RVA: 0x7FFD54B0B7D0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFD4EAB70B0
    }

    public class TemporalAntialiasing : Object
    {
        public float jitter; // 0x10
        public float sampleIndex; // 0x14
        public float stationaryBlending; // 0x18
        public float motionBlending; // 0x1C
        public System.Func`3<UnityEngine.Camera,UnityEngine.Vector2,UnityEngine.Matrix4x4> jitteredMatrixFunc; // 0x20
        public UnityEngine.Vector2 <jitter>k__BackingField; // 0x28
        public 0x664E6AF8[] m_Mrt; // 0x30
        public bool m_ResetHistory; // 0x38
        public int k_SampleCount;
        public int <sampleIndex>k__BackingField; // 0x3C
        public int k_NumEyes;
        public int k_NumHistoryTextures;
        public UnityEngine.RenderTexture[][] m_HistoryTextures; // 0x40
        public int[] m_HistoryPingPong; // 0x48

        // ── Methods ──
        public void get_jitter(){} // RVA: 0x7FFD4F7C2620
        public void set_jitter(){} // RVA: 0x7FFD4E7F3BF0
        public void get_sampleIndex(){} // RVA: 0x7FFD4E7DD4A0
        public void set_sampleIndex(){} // RVA: 0x7FFD4FC02CD0
        public void IsSupported(){} // RVA: 0x7FFD54AE2E80
        public void GetCameraFlags(){} // RVA: 0x7FFD4E6048B0
        public void ResetHistory(){} // RVA: 0x7FFD4F06CFE0
        public void GenerateRandomOffset(){} // RVA: 0x7FFD54AE2F60
        public void GetJitteredProjectionMatrix(){} // RVA: 0x7FFD54AE3040
        public void ConfigureJitteredProjectionMatrix(){} // RVA: 0x7FFD54AE3310
        public void ConfigureStereoJitteredProjectionMatrices(){} // RVA: 0x7FFD54AE34F0
        public void GenerateHistoryName(){} // RVA: 0x7FFD54AE3980
        public void CheckHistory(){} // RVA: 0x7FFD54AE3AF0
        public void Render(){} // RVA: 0x7FFD54AE4190
        public void Release(){} // RVA: 0x7FFD54AE4820
        public void .ctor(){} // RVA: 0x7FFD54AE4980
    }

    public class TextureFormatUtilities : Object
    {
        public System.Collections.Generic.Dictionary`2<int,0x664DC180> s_FormatAliasMap;
        public System.Collections.Generic.Dictionary`2<int,bool> s_SupportedRenderTextureFormats; // 0x8
        public System.Collections.Generic.Dictionary`2<int,bool> s_SupportedTextureFormats; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54B0BA10
        public void IsObsolete(){} // RVA: 0x7FFD54B0CBD0
        public void GetUncompressedRenderTextureFormat(){} // RVA: 0x7FFD54B0CD60
        public void IsSupported(){} // RVA: 0x7FFD54B0D080 | overloaded x2
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
        public void get_instance(){} // RVA: 0x7FFD54B0D150
        public void .ctor(){} // RVA: 0x7FFD54B0D350
        public void BeginFrame(){} // RVA: 0x7FFD54B0D490
        public void EndFrame(){} // RVA: 0x7FFD54B0D5D0
        public void Get(){} // RVA: 0x7FFD54B0D840
        public void Lerp(){} // RVA: 0x7FFD54B0E550 | overloaded x2
        public void Clear(){} // RVA: 0x7FFD54B0ED90
    }

    public class TrackballAttribute : Attribute
    {
        public 0x665D04E8 mode; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3440C0
    }

    public class VectorscopeMonitor : Monitor
    {
        public int size; // 0x20
        public float exposure; // 0x24
        public UnityEngine.ComputeBuffer m_Data; // 0x28
        public int k_ThreadGroupSizeX;
        public int k_ThreadGroupSizeY;

        // ── Methods ──
        public void OnDisable(){} // RVA: 0x7FFD54AE7150
        public void NeedsHalfRes(){} // RVA: 0x7FFD4E426850
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFD54AE7210
        public void Render(){} // RVA: 0x7FFD54AE7310
        public void .ctor(){} // RVA: 0x7FFD54AE7CF0
    }

    public class Vignette : PostProcessEffectSettings
    {
        public 0x665D1988 mode; // 0x30
        public 0x665D1EB0 color; // 0x38
        public 0x665D1F08 center; // 0x40
        public 0x665D1DA8 intensity; // 0x48
        public 0x665D1DA8 smoothness; // 0x50
        public 0x665D1DA8 roundness; // 0x58
        public 0x665D1E58 rounded; // 0x60
        public 0x665D20C0 mask; // 0x68
        public 0x665D1DA8 opacity; // 0x70

        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AE4B80
        public void .ctor(){} // RVA: 0x7FFD54AE4CE0
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
        public void OnDisable(){} // RVA: 0x7FFD54AE7150
        public void NeedsHalfRes(){} // RVA: 0x7FFD4E426850
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFD54AE7D00
        public void Render(){} // RVA: 0x7FFD54AE7E00
        public void .ctor(){} // RVA: 0x7FFD54AE8960
    }

}