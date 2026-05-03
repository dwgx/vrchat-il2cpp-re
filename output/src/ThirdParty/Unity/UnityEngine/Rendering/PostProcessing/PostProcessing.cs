// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 88
// Methods: 552

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class AmbientOcclusion : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFE87A4E890
        public void .ctor(){} // RVA: 0x7FFE87A4EC40
    }

    public class AmbientOcclusionModeParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A4E7F0
    }

    public class AmbientOcclusionQualityParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A4E840
    }

    public class AmbientOcclusionRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE87A4F360
        public void IsAmbientOnly(){} // RVA: 0x7FFE87A4F520
        public void Get(){} // RVA: 0x7FFE87A4F630
        public void GetCameraFlags(){} // RVA: 0x7FFE87A4F6A0
        public void Release(){} // RVA: 0x7FFE87A4F740
        public void GetScalableAO(){} // RVA: 0x7FFE87A4F850
        public void GetMultiScaleVO(){} // RVA: 0x7FFE87A4F8C0
        public void Render(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE87A4F930
    }

    public class AutoExposure : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFE87A4F9C0
        public void .ctor(){} // RVA: 0x7FFE87A4FB80
    }

    public class AutoExposureRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A50000
        public void CheckTexture(){} // RVA: 0x7FFE87A50240
        public void Render(){} // RVA: 0x7FFE87A50550
        public void Release(){} // RVA: 0x7FFE87A51310
    }

    public class Bloom : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFE87A513E0
        public void .ctor(){} // RVA: 0x7FFE87A51420
    }

    public class BloomRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE87A51A50
        public void Render(){} // RVA: 0x7FFE87A51D10
        public void .ctor(){} // RVA: 0x7FFE87A53240
    }

    public class BoolParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A70FD0
    }

    public class ChromaticAberration : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFE87A53280
        public void .ctor(){} // RVA: 0x7FFE87A532C0
    }

    public class ChromaticAberrationRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x7FFE87A53530
        public void Release(){} // RVA: 0x7FFE87A53AD0
        public void .ctor(){} // RVA: 0x7FFE87A53B80
    }

    public class ColorGrading : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFE87A53C60
        public void .ctor(){} // RVA: 0x7FFE87A53D20
    }

    public class ColorGradingRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x7FFE87A55510
        public void RenderExternalPipeline3D(){} // RVA: 0x7FFE87A55740
        public void RenderHDRPipeline3D(){} // RVA: 0x7FFE87A55AE0
        public void RenderHDRPipeline2D(){} // RVA: 0x7FFE87A56E60
        public void RenderLDRPipeline2D(){} // RVA: 0x7FFE87A58750
        public void CheckInternalLogLut(){} // RVA: 0x7FFE87A59B50
        public void CheckInternalStripLut(){} // RVA: 0x7FFE87A5A050
        public void GetCurveTexture(){} // RVA: 0x7FFE87A5A4A0
        public void IsRenderTextureFormatSupportedForLinearFiltering(){} // RVA: 0x7FFE87A5AB40
        public void GetLutFormat(){} // RVA: 0x7FFE87A5AC50
        public void GetCurveFormat(){} // RVA: 0x7FFE87A5ACA0
        public void Release(){} // RVA: 0x7FFE87A5ACD0
        public void .ctor(){} // RVA: 0x7FFE87A5AE40
    }

    public class ColorParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x7FFE87A71020
        public void op_Implicit(){} // RVA: 0x7FFE87A71090
        public void .ctor(){} // RVA: 0x7FFE87A710E0
    }

    public class ColorUtilities : Object
    {
        // ── Methods ──
        public void StandardIlluminantY(){} // RVA: 0x7FFE87A86200
        public void CIExyToLMS(){} // RVA: 0x7FFE87A86230
        public void ComputeColorBalance(){} // RVA: 0x7FFE87A862C0
        public void ColorToLift(){} // RVA: 0x7FFE87A863E0
        public void ColorToInverseGamma(){} // RVA: 0x7FFE87A86450
        public void ColorToGain(){} // RVA: 0x7FFE87A86500
        public void LogCToLinear(){} // RVA: 0x7FFE87A86570
        public void LinearToLogC(){} // RVA: 0x7FFE87A865D0
        public void ToHex(){} // RVA: 0x7FFE87A86620
        public void ToRGBA(){} // RVA: 0x7FFE87A866A0
    }

    public class DepthOfField : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFE87A5AFD0
        public void .ctor(){} // RVA: 0x7FFE87A5B040
    }

    public class DepthOfFieldRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A5B2F0
        public void GetCameraFlags(){} // RVA: 0x7FFE811EDAF0
        public void SelectFormat(){} // RVA: 0x7FFE87A5B530
        public void CalculateMaxCoCRadius(){} // RVA: 0x7FFE87A5B5D0
        public void CheckHistory(){} // RVA: 0x7FFE87A5B660
        public void Render(){} // RVA: 0x7FFE87A5BA40
        public void Release(){} // RVA: 0x7FFE87A5CDA0
    }

    public class DisplayNameAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class Dithering : Object
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x7FFE87A5CE90
        public void .ctor(){} // RVA: 0x7FFE87A5D160
    }

    public class EyeAdaptationParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A4F970
    }

    public class FastApproximateAntialiasing : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class FloatParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x7FFE87A70EE0
        public void .ctor(){} // RVA: 0x7FFE87A70F00
    }

    public class Fog : Object
    {
        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x7FFE811EDAF0
        public void IsEnabledAndSupported(){} // RVA: 0x7FFE87A5D210
        public void Render(){} // RVA: 0x7FFE87A5D380
        public void .ctor(){} // RVA: 0x7FFE813752B0
    }

    public class GradingModeParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A53BC0
    }

    public class Grain : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFE87A53280
        public void .ctor(){} // RVA: 0x7FFE87A5D940
    }

    public class GrainRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x7FFE87A5DBF0
        public void GetLookupFormat(){} // RVA: 0x7FFE87A5E7B0
        public void Release(){} // RVA: 0x7FFE87A5E810
        public void .ctor(){} // RVA: 0x7FFE87A5E8C0
    }

    public class HableCurve : Object
    {
        public float _whitePoint; // 0x10
        public float _inverseWhitePoint; // 0x14
        public float _x0; // 0x18
        public float _x1; // 0x1C

        // ── Methods ──
        public void get_whitePoint(){} // RVA: 0x7FFE81225320
        public void set_whitePoint(){} // RVA: 0x7FFE81225330
        public void get_inverseWhitePoint(){} // RVA: 0x7FFE81225340
        public void set_inverseWhitePoint(){} // RVA: 0x7FFE81225350
        public void get_x0(){} // RVA: 0x7FFE810FFCF0
        public void set_x0(){} // RVA: 0x7FFE811164D0
        public void get_x1(){} // RVA: 0x7FFE811C8570
        public void set_x1(){} // RVA: 0x7FFE811C8580
        public void .ctor(){} // RVA: 0x7FFE87A86720
        public void Eval(){} // RVA: 0x7FFE87A86970
        public void Init(){} // RVA: 0x7FFE87A86A10
        public void InitSegments(){} // RVA: 0x7FFE87A86C50
        public void SolveAB(){} // RVA: 0x7FFE87A87190
        public void AsSlopeIntercept(){} // RVA: 0x7FFE87A87200
        public void EvalDerivativeLinearGamma(){} // RVA: 0x7FFE87A87260
    }

    public class HaltonSeq : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE87A87550
    }

    public class HistogramMonitor : Monitor
    {
        // ── Methods ──
        public void OnDisable(){} // RVA: 0x7FFE87A6DD90
        public void NeedsHalfRes(){} // RVA: 0x7FFE811E0850
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFE87A6DE50
        public void Render(){} // RVA: 0x7FFE87A6DF50
        public void .ctor(){} // RVA: 0x7FFE87A6E800
    }

    public class IAmbientOcclusionMethod
    {
        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x7FFE80E2EDB0
        public void RenderAfterOpaque(){} // RVA: 0x7FFE80E460A0
        public void RenderAmbientOnly(){} // RVA: 0x7FFE80E460A0
        public void CompositeAmbientOnly(){} // RVA: 0x7FFE80E460A0
        public void Release(){} // RVA: 0x7FFE80E45FE0
    }

    public class IntParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x7FFE87A70F50
        public void .ctor(){} // RVA: 0x7FFE87A70F80
    }

    public class KernelSizeParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A5AF80
    }

    public class LensDistortion : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFE87A5E900
        public void .ctor(){} // RVA: 0x7FFE87A5E9C0
    }

    public class LensDistortionRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x7FFE87A5ED80
        public void .ctor(){} // RVA: 0x7FFE87A5F130
    }

    public class LightMeterMonitor : Monitor
    {
        // ── Methods ──
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFE87A6E820
        public void Render(){} // RVA: 0x7FFE87A6E990
        public void .ctor(){} // RVA: 0x7FFE87A6F1E0
    }

    public class LogHistogram : Object
    {
        public int rangeMin;

        // ── Methods ──
        public void get_data(){} // RVA: 0x7FFE81116380
        public void set_data(){} // RVA: 0x7FFE810FCE30
        public void Generate(){} // RVA: 0x7FFE87A875B0
        public void GetHistogramScaleOffsetRes(){} // RVA: 0x7FFE87A87BF0
        public void Release(){} // RVA: 0x7FFE87A87C40
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MaxAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81225330
    }

    public class MeshUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87A87CC0
        public void GetColliderMesh(){} // RVA: 0x7FFE87A880A0
        public void GetPrimitive(){} // RVA: 0x7FFE87A88290
        public void GetBuiltinMesh(){} // RVA: 0x7FFE87A884C0
    }

    public class MinAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81225330
    }

    public class MinMaxAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81E156F0
    }

    public class Monitor : Object
    {
        public UnityEngine.RenderTexture _output; // 0x10

        // ── Methods ──
        public void get_output(){} // RVA: 0x7FFE81116380
        public void set_output(){} // RVA: 0x7FFE810FCE30
        public void IsRequestedAndSupported(){} // RVA: 0x7FFE87A6F200
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFE80E2F3B0
        public void NeedsHalfRes(){} // RVA: 0x7FFE810FB320
        public void CheckOutput(){} // RVA: 0x7FFE87A6F2F0
        public void OnEnable(){} // RVA: 0x7FFE810FB310
        public void OnDisable(){} // RVA: 0x7FFE87A6F660
        public void Render(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MotionBlur : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFE87A5F170
        public void .ctor(){} // RVA: 0x7FFE87A5F270
    }

    public class MotionBlurRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x7FFE81474A10
        public void CreateTemporaryRT(){} // RVA: 0x7FFE87A5F400
        public void Render(){} // RVA: 0x7FFE87A5F4F0
        public void .ctor(){} // RVA: 0x7FFE87A60520
    }

    public class MultiScaleVO : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A60560
        public void GetCameraFlags(){} // RVA: 0x7FFE811EDAF0
        public void SetResources(){} // RVA: 0x7FFE811C3510
        public void Alloc(){} // RVA: 0x7FFE87A60E10
        public void AllocArray(){} // RVA: 0x7FFE87A61010
        public void Release(){} // RVA: 0x7FFE87A663E0 | overloaded x2
        public void CalculateZBufferParams(){} // RVA: 0x7FFE87A61280
        public void CalculateTanHalfFovHeight(){} // RVA: 0x7FFE87A613E0
        public void GetSize(){} // RVA: 0x7FFE87A61470
        public void GetSizeArray(){} // RVA: 0x7FFE87A614D0
        public void GenerateAOMap(){} // RVA: 0x7FFE87A61530
        public void PushAllocCommands(){} // RVA: 0x7FFE87A622A0
        public void PushDownsampleCommands(){} // RVA: 0x7FFE87A62A60
        public void PushRenderCommands(){} // RVA: 0x7FFE87A63850
        public void PushUpsampleCommands(){} // RVA: 0x7FFE87A643B0
        public void PushReleaseCommands(){} // RVA: 0x7FFE87A64AF0
        public void PreparePropertySheet(){} // RVA: 0x7FFE87A650C0
        public void CheckAOTexture(){} // RVA: 0x7FFE87A65300
        public void PushDebug(){} // RVA: 0x7FFE87A65790
        public void RenderAfterOpaque(){} // RVA: 0x7FFE87A65860
        public void RenderAmbientOnly(){} // RVA: 0x7FFE87A65EC0
        public void CompositeAmbientOnly(){} // RVA: 0x7FFE87A66100
    }

    public class ParameterOverride : Object
    {
        // ── Methods ──
        public void Interp(){}
        public void GetHash(){} // RVA: 0x7FFE80E2EDB0
        public void GetValue(){} // RVA: 0x7FFE810A1420
        public void OnEnable(){} // RVA: 0x7FFE810FB310
        public void OnDisable(){} // RVA: 0x7FFE810FB310
        public void SetValue(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ParameterOverride`1 : ParameterOverride
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void Interp(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Override(){} // RVA: 0x7FFE810A1420
        public void SetValue(){} // RVA: 0x7FFE80E460A0
        public void GetHash(){} // RVA: 0x7FFE80E2EDB0
        public void op_Implicit(){} // RVA: 0x7FFE810A1420
    }

    public class PostProcessAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A4E730 | overloaded x2
    }

    public class PostProcessBundle : Object
    {
        public UnityEngine.Rendering.PostProcessing.PostProcessAttribute _attribute; // 0x10
        public UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings _settings; // 0x18
        public UnityEngine.Rendering.PostProcessing.PostProcessEffectRenderer m_Renderer; // 0x20

        // ── Methods ──
        public void get_attribute(){} // RVA: 0x7FFE81116380
        public void set_attribute(){} // RVA: 0x7FFE810FCE30
        public void get_settings(){} // RVA: 0x7FFE810FE7C0
        public void set_settings(){} // RVA: 0x7FFE81161E80
        public void get_renderer(){} // RVA: 0x7FFE87A72310
        public void .ctor(){} // RVA: 0x7FFE87A72480
        public void Release(){} // RVA: 0x7FFE87A725B0
        public void ResetHistory(){} // RVA: 0x7FFE87A72620
        public void CastSettings(){} // RVA: 0x7FFE810A1420
        public void CastRenderer(){} // RVA: 0x7FFE810A1420
    }

    public class PostProcessDebug : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE87A72640
        public void OnDisable(){} // RVA: 0x7FFE87A72780
        public void Update(){} // RVA: 0x7FFE87A72920
        public void Reset(){} // RVA: 0x7FFE87A72930
        public void UpdateStates(){} // RVA: 0x7FFE87A729C0
        public void OnPostRender(){} // RVA: 0x7FFE87A72F30
        public void OnGUI(){} // RVA: 0x7FFE87A732C0
        public void DrawMonitor(){} // RVA: 0x7FFE87A734E0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class PostProcessDebugLayer : Object
    {
        public UnityEngine.Rendering.PostProcessing.LightMeterMonitor lightMeter; // 0x10
        public UnityEngine.Rendering.PostProcessing.HistogramMonitor histogram; // 0x18
        public UnityEngine.Rendering.PostProcessing.WaveformMonitor waveform; // 0x20

        // ── Methods ──
        public void get_debugOverlayTarget(){} // RVA: 0x7FFE81178740
        public void set_debugOverlayTarget(){} // RVA: 0x7FFE81123200
        public void get_debugOverlayActive(){} // RVA: 0x7FFE811B2D30
        public void set_debugOverlayActive(){} // RVA: 0x7FFE811B2D40
        public void get_debugOverlay(){} // RVA: 0x7FFE821E0A40
        public void set_debugOverlay(){} // RVA: 0x7FFE82B06A20
        public void OnEnable(){} // RVA: 0x7FFE87A736D0
        public void OnDisable(){} // RVA: 0x7FFE87A73AB0
        public void DestroyDebugOverlayTarget(){} // RVA: 0x7FFE87A73C50
        public void RequestMonitorPass(){} // RVA: 0x7FFE87A73D00
        public void RequestDebugOverlay(){} // RVA: 0x7FFE82B06A20
        public void SetFrameSize(){} // RVA: 0x7FFE87A73D70
        public void PushDebugOverlay(){} // RVA: 0x7FFE87A73D80
        public void GetCameraFlags(){} // RVA: 0x7FFE87A742B0
        public void RenderMonitors(){} // RVA: 0x7FFE87A742E0
        public void RenderSpecialOverlays(){} // RVA: 0x7FFE87A74940
        public void EndFrame(){} // RVA: 0x7FFE87A74E90
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PostProcessEffectRenderer : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE810FB310
        public void GetCameraFlags(){} // RVA: 0x7FFE813240E0
        public void ResetHistory(){} // RVA: 0x7FFE814B8390
        public void Release(){} // RVA: 0x7FFE8725AEB0
        public void Render(){} // RVA: 0x7FFE80E460A0
        public void SetSettings(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE814B8390
    }

    public class PostProcessEffectRendererExtensions : Object
    {
        // ── Methods ──
        public void RenderOrLog(){} // RVA: 0x7FFE87A885E0
    }

    public class PostProcessEffectRenderer`1 : PostProcessEffectRenderer
    {
        public T _settings;

        // ── Methods ──
        public void get_settings(){} // RVA: 0x7FFE810A1420
        public void set_settings(){} // RVA: 0x7FFE810A1420
        public void SetSettings(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class PostProcessEffectSettings : ScriptableObject
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE87A75050
        public void OnDisable(){} // RVA: 0x7FFE87A756F0
        public void SetAllOverridesTo(){} // RVA: 0x7FFE87A758F0
        public void IsEnabledAndSupported(){} // RVA: 0x7FFE87A75B10
        public void GetHash(){} // RVA: 0x7FFE87A75B30
        public void .ctor(){} // RVA: 0x7FFE87A75D50
        public void <OnEnable>b__3_2(){} // RVA: 0x7FFE87A75E20
    }

    public class PostProcessEventComparer : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE841063C0
        public void GetHashCode(){} // RVA: 0x7FFE8481AF30
    }

    public class PostProcessLayer : MonoBehaviour
    {
        public UnityEngine.Transform volumeTrigger; // 0x20
        public UnityEngine.LayerMask volumeLayer; // 0x28
        public bool stopNaNPropagation; // 0x2C

        // ── Methods ──
        public void get_sortedBundles(){} // RVA: 0x7FFE817AE360
        public void set_sortedBundles(){} // RVA: 0x7FFE8171B470
        public void get_cameraDepthFlags(){} // RVA: 0x7FFE82B06FB0
        public void set_cameraDepthFlags(){} // RVA: 0x7FFE82B06FC0
        public void get_haveBundlesBeenInited(){} // RVA: 0x7FFE813A1BB0
        public void set_haveBundlesBeenInited(){} // RVA: 0x7FFE813A4B20
        public void OnEnable(){} // RVA: 0x7FFE87A76090
        public void InitLegacy(){} // RVA: 0x7FFE87A76410
        public void DynamicResolutionAllowsFinalBlitToCameraTarget(){} // RVA: 0x7FFE87A76A20
        public void OnRenderImage(){} // RVA: 0x7FFE87A76B20
        public void Init(){} // RVA: 0x7FFE87A76BE0
        public void InitBundles(){} // RVA: 0x7FFE87A76DE0
        public void UpdateBundleSortList(){} // RVA: 0x7FFE87A77530
        public void OnDisable(){} // RVA: 0x7FFE87A77E30
        public void Reset(){} // RVA: 0x7FFE87A78460
        public void OnPreCull(){} // RVA: 0x7FFE87A78500
        public void OnPreRender(){} // RVA: 0x7FFE87A79180
        public void RequiresInitialBlit(){} // RVA: 0x7FFE811E0850
        public void UpdateSrcDstForOpaqueOnly(){} // RVA: 0x7FFE87A79240
        public void BuildCommandBuffers(){} // RVA: 0x7FFE87A79470
        public void OnPostRender(){} // RVA: 0x7FFE87A7A8B0
        public void GetBundle(){} // RVA: 0x7FFE87A7AB30 | overloaded x2
        public void GetSettings(){} // RVA: 0x7FFE810A1420
        public void BakeMSVOMap(){} // RVA: 0x7FFE87A7AB90
        public void OverrideSettings(){} // RVA: 0x7FFE87A7AD90
        public void SetLegacyCameraFlags(){} // RVA: 0x7FFE87A7B020
        public void ResetHistory(){} // RVA: 0x7FFE87A7B3C0
        public void HasOpaqueOnlyEffects(){} // RVA: 0x7FFE87A7B570
        public void HasActiveEffects(){} // RVA: 0x7FFE87A7B580
        public void SetupContext(){} // RVA: 0x7FFE87A7B7C0
        public void UpdateVolumeSystem(){} // RVA: 0x7FFE87A7BD90
        public void RenderOpaqueOnly(){} // RVA: 0x7FFE87A7BF60
        public void Render(){} // RVA: 0x7FFE87A7C060
        public void RenderInjectionPoint(){} // RVA: 0x7FFE87A7CDC0
        public void RenderList(){} // RVA: 0x7FFE87A7D060
        public void ApplyFlip(){} // RVA: 0x7FFE87A7D8B0
        public void ApplyDefaultFlip(){} // RVA: 0x7FFE87A7D9C0
        public void RenderBuiltins(){} // RVA: 0x7FFE87A7DB10
        public void RenderFinalPass(){} // RVA: 0x7FFE87A7E800
        public void RenderEffect(){}
        public void ShouldGenerateLogHistogram(){} // RVA: 0x7FFE87A7F3D0
        public void .ctor(){} // RVA: 0x7FFE87A7F480
    }

    public class PostProcessManager : Object
    {
        public UnityEngine.Rendering.PostProcessing.PostProcessManager s_Instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFE87A7F960
        public void .ctor(){} // RVA: 0x7FFE87A7FA40
        public void CleanBaseTypes(){} // RVA: 0x7FFE87A7FE60
        public void ReloadBaseTypes(){} // RVA: 0x7FFE87A80040
        public void GetActiveVolumes(){} // RVA: 0x7FFE87A80680
        public void GetHighestPriorityVolume(){} // RVA: 0x7FFE87A80F80 | overloaded x2
        public void QuickVolume(){} // RVA: 0x7FFE87A81160
        public void SetLayerDirty(){} // RVA: 0x7FFE87A813D0
        public void UpdateVolumeLayer(){} // RVA: 0x7FFE87A815A0
        public void Register(){} // RVA: 0x7FFE87A817F0 | overloaded x2
        public void Unregister(){} // RVA: 0x7FFE87A81AC0 | overloaded x2
        public void ReplaceData(){} // RVA: 0x7FFE87A81BA0
        public void UpdateSettings(){} // RVA: 0x7FFE87A81E90
        public void GrabVolumes(){} // RVA: 0x7FFE87A82730
        public void SortByPriority(){} // RVA: 0x7FFE87A82C80
        public void IsVolumeRenderedByCamera(){} // RVA: 0x7FFE811E0850
    }

    public class PostProcessProfile : ScriptableObject
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE87A82F70
        public void AddSettings(){} // RVA: 0x7FFE87A832E0 | overloaded x3
        public void RemoveSettings(){} // RVA: 0x7FFE87A833B0 | overloaded x2
        public void HasSettings(){} // RVA: 0x7FFE87A83540 | overloaded x2
        public void GetSetting(){} // RVA: 0x7FFE810A1420
        public void TryGetSettings(){} // RVA: 0x7FFE80E2F3B0
        public void .ctor(){} // RVA: 0x7FFE87A836E0
    }

    public class PostProcessRenderContext : Object
    {
        public UnityEngine.Camera m_Camera; // 0x10
        public UnityEngine.Rendering.CommandBuffer _command; // 0x18
        public UnityEngine.Rendering.RenderTargetIdentifier _source; // 0x20
        public UnityEngine.Rendering.RenderTargetIdentifier _destination; // 0x48
        public 0x665759EC _sourceFormat; // 0x70
        public bool _flip; // 0x74
        public UnityEngine.Rendering.PostProcessing.PostProcessResources _resources; // 0x78
        public UnityEngine.Rendering.PostProcessing.PropertySheetFactory _propertySheets; // 0x80
        public System.Collections.Generic.Dictionary`2<string,object> _userData; // 0x88
        public UnityEngine.Rendering.PostProcessing.PostProcessDebugLayer _debugLayer; // 0x90
        public int _width; // 0x98
        public int _height; // 0x9C
        public bool _stereoActive; // 0xA0
        public int _xrActiveEye; // 0xA4
        public int _numberOfEyes; // 0xA8
        public 0x6666C744 _stereoRenderingMode; // 0xAC
        public int _screenWidth; // 0xB0
        public int _screenHeight; // 0xB4
        public bool _isSceneView; // 0xB8
        public dFixup.Q% _antialiasing; // 0xBC
        public UnityEngine.Rendering.PostProcessing.TemporalAntialiasing _temporalAntialiasing; // 0xC0

        // ── Methods ──
        public void get_camera(){} // RVA: 0x7FFE81116380
        public void set_camera(){} // RVA: 0x7FFE87A83920
        public void get_command(){} // RVA: 0x7FFE810FE7C0
        public void set_command(){} // RVA: 0x7FFE81161E80
        public void get_source(){} // RVA: 0x7FFE819CF830
        public void set_source(){} // RVA: 0x7FFE87A83CF0
        public void get_destination(){} // RVA: 0x7FFE81CA3B70
        public void set_destination(){} // RVA: 0x7FFE87A83D10
        public void get_sourceFormat(){} // RVA: 0x7FFE81E60180
        public void set_sourceFormat(){} // RVA: 0x7FFE81293CF0
        public void get_flip(){} // RVA: 0x7FFE81E8DCD0
        public void set_flip(){} // RVA: 0x7FFE8656ED40
        public void get_resources(){} // RVA: 0x7FFE81463AE0
        public void set_resources(){} // RVA: 0x7FFE81464570
        public void get_propertySheets(){} // RVA: 0x7FFE81280C30
        public void set_propertySheets(){} // RVA: 0x7FFE81282380
        public void get_userData(){} // RVA: 0x7FFE8113A010
        public void set_userData(){} // RVA: 0x7FFE81280F90
        public void get_debugLayer(){} // RVA: 0x7FFE8154EB60
        public void set_debugLayer(){} // RVA: 0x7FFE818CE320
        public void get_width(){} // RVA: 0x7FFE82B06A40
        public void set_width(){} // RVA: 0x7FFE82B06FA0
        public void get_height(){} // RVA: 0x7FFE82B06F90
        public void set_height(){} // RVA: 0x7FFE82B06A30
        public void get_stereoActive(){} // RVA: 0x7FFE820E9360
        public void set_stereoActive(){} // RVA: 0x7FFE818DBD80
        public void get_xrActiveEye(){} // RVA: 0x7FFE848BEED0
        public void set_xrActiveEye(){} // RVA: 0x7FFE848BEEE0
        public void get_numberOfEyes(){} // RVA: 0x7FFE81A338E0
        public void set_numberOfEyes(){} // RVA: 0x7FFE81A34770
        public void get_stereoRenderingMode(){} // RVA: 0x7FFE848BEEF0
        public void set_stereoRenderingMode(){} // RVA: 0x7FFE848BEF00
        public void get_screenWidth(){} // RVA: 0x7FFE82E64BF0
        public void set_screenWidth(){} // RVA: 0x7FFE86B5F1F0
        public void get_screenHeight(){} // RVA: 0x7FFE84A61A20
        public void set_screenHeight(){} // RVA: 0x7FFE84A61A30
        public void get_isSceneView(){} // RVA: 0x7FFE824AEC00
        public void set_isSceneView(){} // RVA: 0x7FFE824AD2F0
        public void get_antialiasing(){} // RVA: 0x7FFE818D2E10
        public void set_antialiasing(){} // RVA: 0x7FFE87A83D30
        public void get_temporalAntialiasing(){} // RVA: 0x7FFE81166120
        public void set_temporalAntialiasing(){} // RVA: 0x7FFE81166130
        public void Reset(){} // RVA: 0x7FFE87A83D40
        public void IsTemporalAntialiasingActive(){} // RVA: 0x7FFE87A84320
        public void IsDebugOverlayEnabled(){} // RVA: 0x7FFE87A84360
        public void PushDebugOverlay(){} // RVA: 0x7FFE87A84390
        public void GetDescriptor(){} // RVA: 0x7FFE87A843F0
        public void GetScreenSpaceTemporaryRT(){} // RVA: 0x7FFE87A846C0 | overloaded x2
        public void UpdateSinglePassStereoState(){} // RVA: 0x7FFE87A84750
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PostProcessResources : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class PostProcessVolume : MonoBehaviour
    {
        public UnityEngine.Rendering.PostProcessing.PostProcessProfile sharedProfile; // 0x20
        public bool isGlobal; // 0x28
        public float blendDistance; // 0x2C

        // ── Methods ──
        public void get_profile(){} // RVA: 0x7FFE87A849F0
        public void set_profile(){} // RVA: 0x7FFE81176740
        public void get_profileRef(){} // RVA: 0x7FFE87A84DE0
        public void HasInstantiatedProfile(){} // RVA: 0x7FFE87A84EC0
        public void get_previousLayer(){} // RVA: 0x7FFE81D46090
        public void OnEnable(){} // RVA: 0x7FFE87A84F90
        public void OnDisable(){} // RVA: 0x7FFE87A851C0
        public void Update(){} // RVA: 0x7FFE87A852B0
        public void OnDrawGizmos(){} // RVA: 0x7FFE87A853F0
        public void .ctor(){} // RVA: 0x7FFE87A861B0
    }

    public class PropertySheet : Object
    {
        public UnityEngine.MaterialPropertyBlock _properties; // 0x10
        public UnityEngine.Material _material; // 0x18

        // ── Methods ──
        public void get_properties(){} // RVA: 0x7FFE81116380
        public void set_properties(){} // RVA: 0x7FFE810FCE30
        public void get_material(){} // RVA: 0x7FFE810FE7C0
        public void set_material(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE87A88650
        public void ClearKeywords(){} // RVA: 0x7FFE87A88790
        public void EnableKeyword(){} // RVA: 0x7FFE87A887F0
        public void DisableKeyword(){} // RVA: 0x7FFE87A88860
        public void Release(){} // RVA: 0x7FFE87A888D0
    }

    public class PropertySheetFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A88980
        public void Get(){} // RVA: 0x7FFE87A88B90 | overloaded x2
        public void Release(){} // RVA: 0x7FFE87A88EB0
    }

    public class RuntimeUtilities : Object
    {
        public UnityEngine.Texture2D m_WhiteTexture;
        public UnityEngine.Texture3D m_WhiteTexture3D; // 0x8
        public UnityEngine.Texture2D m_BlackTexture; // 0x10
        public UnityEngine.Texture3D m_BlackTexture3D; // 0x18
        public UnityEngine.Texture2D m_TransparentTexture; // 0x20
        public UnityEngine.Texture3D m_TransparentTexture3D; // 0x28
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.Texture2D> m_LutStrips; // 0x30
        public UnityEngine.Rendering.PostProcessing.PostProcessResources s_Resources; // 0x38
        public UnityEngine.Mesh s_FullscreenTriangle; // 0x40
        public UnityEngine.Material s_CopyStdMaterial; // 0x48
        public UnityEngine.Material s_CopyStdFromDoubleWideMaterial; // 0x50
        public UnityEngine.Material s_CopyMaterial; // 0x58
        public UnityEngine.Material s_CopyFromTexArrayMaterial; // 0x60
        public UnityEngine.Rendering.PostProcessing.PropertySheet s_CopySheet; // 0x68
        public UnityEngine.Rendering.PostProcessing.PropertySheet s_CopyFromTexArraySheet; // 0x70
        public System.Collections.Generic.IEnumerable`1<System.Type> m_AssemblyTypes; // 0x78
        public object field_16; // 0x35
        public object field_17; // 0x36
        public object field_18; // 0x37
        public object field_19; // 0x38
        public object field_20; // 0x39
        public object field_21; // 0x3A

        // ── Methods ──
        public void get_whiteTexture(){} // RVA: 0x7FFE87A891C0
        public void get_whiteTexture3D(){} // RVA: 0x7FFE87A89470
        public void get_blackTexture(){} // RVA: 0x7FFE87A89740
        public void get_blackTexture3D(){} // RVA: 0x7FFE87A89A00
        public void get_transparentTexture(){} // RVA: 0x7FFE87A89CD0
        public void get_transparentTexture3D(){} // RVA: 0x7FFE87A89F90
        public void GetLutStrip(){} // RVA: 0x7FFE87A8A260
        public void get_fullscreenTriangle(){} // RVA: 0x7FFE87A8A6E0
        public void get_copyStdMaterial(){} // RVA: 0x7FFE87A8ABF0
        public void get_copyStdFromDoubleWideMaterial(){} // RVA: 0x7FFE87A8AE80
        public void get_copyMaterial(){} // RVA: 0x7FFE87A8B110
        public void get_copyFromTexArrayMaterial(){} // RVA: 0x7FFE87A8B3A0
        public void get_copySheet(){} // RVA: 0x7FFE87A8B630
        public void get_copyFromTexArraySheet(){} // RVA: 0x7FFE87A8B780
        public void isValidResources(){} // RVA: 0x7FFE87A8B8D0
        public void UpdateResources(){} // RVA: 0x7FFE87A8B9D0
        public void SetRenderTargetWithLoadStoreAction(){} // RVA: 0x7FFE87A8BF60 | overloaded x3
        public void BlitFullscreenTriangle(){} // RVA: 0x7FFE87A8D960 | overloaded x5
        public void BlitFullscreenTriangleFromDoubleWide(){} // RVA: 0x7FFE87A8C9D0
        public void BlitFullscreenTriangleToDoubleWide(){} // RVA: 0x7FFE87A8CBA0
        public void BlitFullscreenTriangleFromTexArray(){} // RVA: 0x7FFE87A8CE20
        public void BlitFullscreenTriangleToTexArray(){} // RVA: 0x7FFE87A8D200
        public void BuiltinBlit(){} // RVA: 0x7FFE87A8DE40 | overloaded x2
        public void CopyTexture(){} // RVA: 0x7FFE87A8DFE0
        public void get_scriptableRenderPipelineActive(){} // RVA: 0x7FFE87A8E240
        public void get_supportsDeferredShading(){} // RVA: 0x7FFE87A8E310
        public void get_supportsDepthNormals(){} // RVA: 0x7FFE87A8E3B0
        public void get_isSinglePassStereoEnabled(){} // RVA: 0x7FFE87A8E450
        public void get_isVREnabled(){} // RVA: 0x7FFE87A8E4F0
        public void get_isAndroidOpenGL(){} // RVA: 0x7FFE87A8E540
        public void get_isWebNonWebGPU(){} // RVA: 0x7FFE87A8E610
        public void get_defaultHDRRenderTextureFormat(){} // RVA: 0x7FFE8249F650
        public void isFloatingPointFormat(){} // RVA: 0x7FFE87A8E6A0
        public void hasAlpha(){} // RVA: 0x7FFE87A8E6C0
        public void Destroy(){} // RVA: 0x7FFE87A8E760
        public void get_isLinearColorSpace(){} // RVA: 0x7FFE87A8E850
        public void IsResolvedDepthAvailable(){} // RVA: 0x7FFE87A8E8A0
        public void DestroyProfile(){} // RVA: 0x7FFE87A8E980
        public void DestroyVolume(){} // RVA: 0x7FFE87A8EB50
        public void IsPostProcessingActive(){} // RVA: 0x7FFE87A8EC70
        public void IsTemporalAntialiasingActive(){} // RVA: 0x7FFE87A8ED80
        public void IsDynamicResolutionEnabled(){} // RVA: 0x7FFE87A8EEE0
        public void GetAllSceneObjects(){} // RVA: 0x7FFE80E2DEE0
        public void CreateIfNull(){} // RVA: 0x7FFE80E46070
        public void Exp2(){} // RVA: 0x7FFE87A8F0F0
        public void GetJitteredPerspectiveProjectionMatrix(){} // RVA: 0x7FFE87A8F100
        public void GetJitteredOrthographicProjectionMatrix(){} // RVA: 0x7FFE87A8F420
        public void GenerateJitteredProjectionMatrixFromOriginal(){} // RVA: 0x7FFE87A8F770
        public void GetAllAssemblyTypes(){} // RVA: 0x7FFE87A8F950
        public void GetAllTypesDerivedFrom(){} // RVA: 0x7FFE80E2DEE0
        public void GetAttribute(){} // RVA: 0x7FFE810A1420
        public void GetMemberAttributes(){} // RVA: 0x7FFE80E2E3D0
        public void GetFieldPath(){} // RVA: 0x7FFE80E2E3D0
        public void .cctor(){} // RVA: 0x7FFE87A8FC10
    }

    public class ScalableAO : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A66490
        public void GetCameraFlags(){} // RVA: 0x7FFE817BF630
        public void DoLazyInitialization(){} // RVA: 0x7FFE87A666E0
        public void Render(){} // RVA: 0x7FFE87A66D40
        public void RenderAfterOpaque(){} // RVA: 0x7FFE87A67AB0
        public void RenderAmbientOnly(){} // RVA: 0x7FFE87A67DA0
        public void CompositeAmbientOnly(){} // RVA: 0x7FFE87A67EC0
        public void Release(){} // RVA: 0x7FFE87A681A0
    }

    public class ScreenSpaceReflectionPresetParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A68250
    }

    public class ScreenSpaceReflectionResolutionParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A682A0
    }

    public class ScreenSpaceReflections : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFE87A682F0
        public void .ctor(){} // RVA: 0x7FFE87A684E0
    }

    public class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x7FFE81474A10
        public void CheckRT(){} // RVA: 0x7FFE87A68960
        public void Render(){} // RVA: 0x7FFE87A68E20
        public void Release(){} // RVA: 0x7FFE87A6A700
        public void .ctor(){} // RVA: 0x7FFE87A6A820
    }

    public class ShaderIDs : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87A8FE10
    }

    public class Spline : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A93650
        public void Cache(){} // RVA: 0x7FFE87A93780
        public void Evaluate(){} // RVA: 0x7FFE87A93B60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87A93C20
    }

    public class SplineParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE87A71420
        public void SetValue(){} // RVA: 0x7FFE87A71440
        public void Interp(){} // RVA: 0x7FFE87A71550
        public void .ctor(){} // RVA: 0x7FFE87A71720
    }

    public class SubpixelMorphologicalAntialiasing : Object
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7FFE87A6ABB0
        public void Render(){} // RVA: 0x7FFE87A6AC00
        public void .ctor(){} // RVA: 0x7FFE87A6B3E0
    }

    public class TargetPool : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A93C50
        public void Get(){} // RVA: 0x7FFE87A93D40 | overloaded x2
        public void Reset(){} // RVA: 0x7FFE817E01F0
    }

    public class TemporalAntialiasing : Object
    {
        public float jitterSpread; // 0x10
        public float sharpness; // 0x14

        // ── Methods ──
        public void get_jitter(){} // RVA: 0x7FFE8267BED0
        public void set_jitter(){} // RVA: 0x7FFE8164D390
        public void get_sampleIndex(){} // RVA: 0x7FFE816311C0
        public void set_sampleIndex(){} // RVA: 0x7FFE82A4B070
        public void IsSupported(){} // RVA: 0x7FFE87A6B3F0
        public void GetCameraFlags(){} // RVA: 0x7FFE81474A10
        public void ResetHistory(){} // RVA: 0x7FFE81F0FA70
        public void GenerateRandomOffset(){} // RVA: 0x7FFE87A6B4D0
        public void GetJitteredProjectionMatrix(){} // RVA: 0x7FFE87A6B5B0
        public void ConfigureJitteredProjectionMatrix(){} // RVA: 0x7FFE87A6B880
        public void ConfigureStereoJitteredProjectionMatrices(){} // RVA: 0x7FFE87A6BA60
        public void GenerateHistoryName(){} // RVA: 0x7FFE87A6BEF0
        public void CheckHistory(){} // RVA: 0x7FFE87A6C060
        public void Render(){} // RVA: 0x7FFE87A6C700
        public void Release(){} // RVA: 0x7FFE87A6CD90
        public void .ctor(){} // RVA: 0x7FFE87A6CEF0
    }

    public class TextureFormatUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87A93F80
        public void IsObsolete(){} // RVA: 0x7FFE87A95140
        public void GetUncompressedRenderTextureFormat(){} // RVA: 0x7FFE87A952D0
        public void IsSupported(){} // RVA: 0x7FFE87A955F0 | overloaded x2
    }

    public class TextureLerper : Object
    {
        public UnityEngine.Rendering.PostProcessing.TextureLerper m_Instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFE87A956C0
        public void .ctor(){} // RVA: 0x7FFE87A958C0
        public void BeginFrame(){} // RVA: 0x7FFE87A95A00
        public void EndFrame(){} // RVA: 0x7FFE87A95B40
        public void Get(){} // RVA: 0x7FFE87A95DB0
        public void Lerp(){} // RVA: 0x7FFE87A96AC0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE87A97300
    }

    public class TextureParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x7FFE87A717B0
        public void .ctor(){} // RVA: 0x7FFE87A72280
    }

    public class TonemapperParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A53C10
    }

    public class TrackballAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class Vector2Parameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x7FFE87A71120
        public void op_Implicit(){} // RVA: 0x7FFE87A711A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE87A711F0
    }

    public class Vector3Parameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x7FFE87A71240
        public void op_Implicit(){} // RVA: 0x7FFE87A712C0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE87A71320
    }

    public class Vector4Parameter : ParameterOverride`1
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x7FFE87A71020
        public void op_Implicit(){} // RVA: 0x7FFE87A713A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE87A713E0
    }

    public class VectorscopeMonitor : Monitor
    {
        // ── Methods ──
        public void OnDisable(){} // RVA: 0x7FFE87A6F6C0
        public void NeedsHalfRes(){} // RVA: 0x7FFE811E0850
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFE87A6F780
        public void Render(){} // RVA: 0x7FFE87A6F880
        public void .ctor(){} // RVA: 0x7FFE87A70260
    }

    public class Vignette : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFE87A6D0F0
        public void .ctor(){} // RVA: 0x7FFE87A6D250
    }

    public class VignetteModeParameter : ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A6D0A0
    }

    public class VignetteRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x7FFE87A6D850
        public void .ctor(){} // RVA: 0x7FFE87A6DD50
    }

    public class WaveformMonitor : Monitor
    {
        // ── Methods ──
        public void OnDisable(){} // RVA: 0x7FFE87A6F6C0
        public void NeedsHalfRes(){} // RVA: 0x7FFE811E0850
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFE87A70270
        public void Render(){} // RVA: 0x7FFE87A70370
        public void .ctor(){} // RVA: 0x7FFE87A70ED0
    }

}