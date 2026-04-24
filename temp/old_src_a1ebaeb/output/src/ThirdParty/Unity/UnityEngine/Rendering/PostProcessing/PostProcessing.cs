// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 59
// Methods: 461

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class AmbientOcclusion : PostProcessEffectSettings
    {
        public object color; // 0x33AAED30
        public object blurTolerance; // 0x33AAED30
        public object zBias; // 0x33AAED30
        public object quality; // 0x33AAED30
        public object P00; // 0x84EAF7E0

        // ── Original Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7ffaaf0c8300
        public void .ctor(){} // RVA: 0x7ffaaf0c86b0
    }

    public class AutoExposure : PostProcessEffectSettings
    {
        public object maxLuminance; // 0x33A541B0
        public object speedUp; // 0x33A541B0

        // ── Original Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7ffaaf0c9430
        public void .ctor(){} // RVA: 0x7ffaaf0c95f0
    }

    public class Bloom : PostProcessEffectSettings
    {
        public object softKnee; // 0x3368F8D0
        public object anamorphicRatio; // 0x3368F8D0
        public object dirtTexture; // 0x3368F8D0
        public object value__; // 0x84EB8030

        // ── Original Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7ffaaf0cae50
        public void .ctor(){} // RVA: 0x7ffaaf0cae90
    }

    public class ChromaticAberration : PostProcessEffectSettings
    {
        public object fastMode; // 0x33756550

        // ── Original Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7ffaaf0cccf0
        public void .ctor(){} // RVA: 0x7ffaaf0ccd30
    }

    public class ColorGrading : PostProcessEffectSettings
    {
        public object tonemapper; // 0x33A1F3A0
        public object toneCurveShoulderStrength; // 0x33A1F3A0
        public object toneCurveGamma; // 0x33A1F3A0
        public object temperature; // 0x33A1F3A0
        public object hueShift; // 0x33A1F3A0
        public object postExposure; // 0x33A1F3A0
        public object mixerRedOutGreenIn; // 0x33A1F3A0
        public object mixerGreenOutGreenIn; // 0x33A1F3A0
        public object mixerBlueOutGreenIn; // 0x33A1F3A0
        public object gamma; // 0x33A1F3A0
        public object redCurve; // 0x33A1F3A0
        public object hueVsHueCurve; // 0x33A1F3A0
        public object lumVsSatCurve; // 0x33A1F3A0
        public object LutGenLDRFromScratch; // 0x84EB8F60
        public object H֪f; // 0x84EABD20
        public object 0; // 0xA8C586C0
        public object P00; // 0x84EB2A60

        // ── Original Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7ffaaf0cd6d0
        public void .ctor(){} // RVA: 0x7ffaaf0cd790
    }

    public class ColorUtilities : Object
    {
        public object logC_b; // 0x33AB67D0
        public object logC_e; // 0x33AB67D0
        public object 8؏f; // 0x84EC81B0

        // ── Original Methods ──
        public void StandardIlluminantY(){} // RVA: 0x7ffaaf0ffc70
        public void CIExyToLMS(){} // RVA: 0x7ffaaf0ffca0
        public void ComputeColorBalance(){} // RVA: 0x7ffaaf0ffd30
        public void ColorToLift(){} // RVA: 0x7ffaaf0ffe50
        public void ColorToInverseGamma(){} // RVA: 0x7ffaaf0ffec0
        public void ColorToGain(){} // RVA: 0x7ffaaf0fff70
        public void LogCToLinear(){} // RVA: 0x7ffaaf0fffe0
        public void LinearToLogC(){} // RVA: 0x7ffaaf100040
        public void ToHex(){} // RVA: 0x7ffaaf100090
        public void ToRGBA(){} // RVA: 0x7ffaaf100110
    }

    public class DepthOfField : PostProcessEffectSettings
    {
        public object focalLength; // 0x3370E990

        // ── Original Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7ffaaf0d4a40
        public void .ctor(){} // RVA: 0x7ffaaf0d4ab0
    }

    public class DisplayNameAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
    }

    public class Dithering : Object
    {
        // ── Original Methods ──
        public void Render(){} // RVA: 0x7ffaaf0d6900
        public void .ctor(){} // RVA: 0x7ffaaf0d6bd0
    }

    public class FastApproximateAntialiasing : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class Fog : Object
    {
        public object colored; // 0x337DF420

        // ── Original Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7ffaaf0d6c80
        public void Render(){} // RVA: 0x7ffaaf0d6df0
        public void .ctor(){} // RVA: 0x7ffaa8b37c50
        // ── Binary Analysis Named ──
        public void GetCameraFlags(){} // RVA: 0x7ffaa8a24af0
    }

    public class Grain : PostProcessEffectSettings
    {
        public object size; // 0x337DF420

        // ── Original Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7ffaaf0cccf0
        public void .ctor(){} // RVA: 0x7ffaaf0d73b0
    }

    public class HableCurve : Object
    {
        public object _x0; // 0x3372F280, was: <x0>k__BackingField
        public object uniforms; // 0x3372F280
        public object whitePoint; // 0x17000027
        public object inverseWhitePoint; // 0x17000028

        // ── Original Methods ──
        public void get_whitePoint(){} // RVA: 0x7ffaa8a5c320
        public void set_whitePoint(){} // RVA: 0x7ffaa8a5c330
        public void get_inverseWhitePoint(){} // RVA: 0x7ffaa8a5c340
        public void set_inverseWhitePoint(){} // RVA: 0x7ffaa8a5c350
        public void get_x0(){} // RVA: 0x7ffaa8936cf0
        public void set_x0(){} // RVA: 0x7ffaa894d4d0
        public void get_x1(){} // RVA: 0x7ffaa89ff570
        public void set_x1(){} // RVA: 0x7ffaa89ff580
        public void .ctor(){} // RVA: 0x7ffaaf100190
        public void Eval(){} // RVA: 0x7ffaaf1003e0
        public void Init(){} // RVA: 0x7ffaaf100480
        public void InitSegments(){} // RVA: 0x7ffaaf1006c0
        public void SolveAB(){} // RVA: 0x7ffaaf100c00
        public void AsSlopeIntercept(){} // RVA: 0x7ffaaf100c70
        public void EvalDerivativeLinearGamma(){} // RVA: 0x7ffaaf100cd0
    }

    public class HaltonSeq : Object
    {
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaaf100fc0
    }

    public class HistogramMonitor : Monitor
    {
        public object channel; // 0x33B05920
        public object k_ThreadGroupSizeX; // 0x33B05920
        public object P00; // 0x84ED1868

        // ── Original Methods ──
        public void OnDisable(){} // RVA: 0x7ffaaf0e7800
        public void NeedsHalfRes(){} // RVA: 0x7ffaa8a17850
        public void ShaderResourcesAvailable(){} // RVA: 0x7ffaaf0e78c0
        public void Render(){} // RVA: 0x7ffaaf0e79c0
        public void .ctor(){} // RVA: 0x7ffaaf0e8270
    }

    public class IAmbientOcclusionMethod
    {
        // ── Original Methods ──
        public void RenderAfterOpaque(){} // RVA: 0x7ffaa8660d80
        public void RenderAmbientOnly(){} // RVA: 0x7ffaa8660d80
        public void CompositeAmbientOnly(){} // RVA: 0x7ffaa8660d80
        public void Release(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetCameraFlags(){} // RVA: 0x7ffaa8649ca0
    }

    public class LensDistortion : PostProcessEffectSettings
    {
        public object intensityY; // 0x3399DBB0
        public object scale; // 0x3399DBB0

        // ── Original Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7ffaaf0d8370
        public void .ctor(){} // RVA: 0x7ffaaf0d8430
    }

    public class LightMeterMonitor : Monitor
    {
        public object showCurves; // 0x3346E150

        // ── Original Methods ──
        public void ShaderResourcesAvailable(){} // RVA: 0x7ffaaf0e8290
        public void Render(){} // RVA: 0x7ffaaf0e8400
        public void .ctor(){} // RVA: 0x7ffaaf0e8c50
    }

    public class LogHistogram : Object
    {
        public object k_Bins; // 0x339F4030

        // ── Original Methods ──
        public void get_data(){} // RVA: 0x7ffaa894d380
        public void set_data(){} // RVA: 0x7ffaa8933e30
        public void Generate(){} // RVA: 0x7ffaaf101020
        public void Release(){} // RVA: 0x7ffaaf1016b0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetHistogramScaleOffsetRes(){} // RVA: 0x7ffaaf101660
    }

    public class MaxAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8a5c330
    }

    public class MeshUtilities : Object
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaf101730
        // ── Binary Analysis Named ──
        public void GetColliderMesh(){} // RVA: 0x7ffaaf101b10
        public void GetPrimitive(){} // RVA: 0x7ffaaf101d00
        public void GetBuiltinMesh(){} // RVA: 0x7ffaaf101f30
    }

    public class MinAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8a5c330
    }

    public class MinMaxAttribute : Attribute
    {
        public object renderer; // 0x33523430

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa95642b0
    }

    public class Monitor : Object
    {
        // ── Original Methods ──
        public void get_output(){} // RVA: 0x7ffaa894d380
        public void set_output(){} // RVA: 0x7ffaa8933e30
        public void IsRequestedAndSupported(){} // RVA: 0x7ffaaf0e8c70
        public void ShaderResourcesAvailable(){} // RVA: 0x7ffaa864a2a0
        public void NeedsHalfRes(){} // RVA: 0x7ffaa8932320
        public void OnEnable(){} // RVA: 0x7ffaa8932310
        public void OnDisable(){} // RVA: 0x7ffaaf0e90d0
        public void Render(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void CheckOutput(){} // RVA: 0x7ffaaf0e8d60
    }

    public class MotionBlur : PostProcessEffectSettings
    {
        // ── Original Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7ffaaf0d8be0
        public void .ctor(){} // RVA: 0x7ffaaf0d8ce0
    }

    public class MultiScaleVO : Object
    {
        public object m_SampleWeightTable; // 0x33CAAC20
        public object m_ScaledWidths; // 0x33CAAC20
        public object m_PropertySheet; // 0x33CAAC20
        public object m_R8Format; // 0x33CAAC20
        public object m_MRT; // 0x33CAAC20
        public object OcclusionEstimationDeferred; // 0x84EBAAC0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf0d9fd0
        public void Alloc(){} // RVA: 0x7ffaaf0da880
        public void AllocArray(){} // RVA: 0x7ffaaf0daa80
        public void Release(){} // RVA: 0x7ffaaf0dfe50
        public void CalculateZBufferParams(){} // RVA: 0x7ffaaf0dacf0
        public void CalculateTanHalfFovHeight(){} // RVA: 0x7ffaaf0dae50
        public void GenerateAOMap(){} // RVA: 0x7ffaaf0dafa0
        public void PushAllocCommands(){} // RVA: 0x7ffaaf0dbd10
        public void PushDownsampleCommands(){} // RVA: 0x7ffaaf0dc4d0
        public void PushRenderCommands(){} // RVA: 0x7ffaaf0dd2c0
        public void PushUpsampleCommands(){} // RVA: 0x7ffaaf0dde20
        public void PushReleaseCommands(){} // RVA: 0x7ffaaf0de560
        public void PreparePropertySheet(){} // RVA: 0x7ffaaf0deb30
        public void PushDebug(){} // RVA: 0x7ffaaf0df200
        public void RenderAfterOpaque(){} // RVA: 0x7ffaaf0df2d0
        public void RenderAmbientOnly(){} // RVA: 0x7ffaaf0df930
        public void CompositeAmbientOnly(){} // RVA: 0x7ffaaf0dfb70
        public void Release(){} // RVA: 0x7ffaaf0dfe50
        // ── Binary Analysis Named ──
        public void GetCameraFlags(){} // RVA: 0x7ffaa8a24af0
        public void SetResources(){} // RVA: 0x7ffaa89fa510
        public void GetSize(){} // RVA: 0x7ffaaf0daee0
        public void GetSizeArray(){} // RVA: 0x7ffaaf0daf40
        public void CheckAOTexture(){} // RVA: 0x7ffaaf0ded70
    }

    public class ParameterOverride : Object
    {
        // ── Original Methods ──
        public void Interp(){}
        public void OnEnable(){} // RVA: 0x7ffaa8932310
        public void OnDisable(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetHash(){} // RVA: 0x7ffaa8649ca0
        public void GetValue(){} // RVA: 0x7ffaa887e5c0
        public void SetValue(){} // RVA: 0x7ffaa8660d80
    }

    public class ParameterOverride`1 : ParameterOverride
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void Interp(){} // RVA: 0x7ffaa887e5c0
        public void Interp(){} // RVA: 0x7ffaa887e5c0
        public void Override(){} // RVA: 0x7ffaa887e5c0
        public void op_Implicit(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void SetValue(){} // RVA: 0x7ffaa8660d80
        public void GetHash(){} // RVA: 0x7ffaa8649ca0
    }

    public class PostProcessAttribute : Attribute
    {
        public object menuItem; // 0x33523430

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf0c81a0
        public void .ctor(){} // RVA: 0x7ffaaf0c81a0
    }

    public class PostProcessBundle : Object
    {
        public object m_Renderer; // 0x3185BAC0
        public object attribute; // 0x17000004

        // ── Original Methods ──
        public void get_attribute(){} // RVA: 0x7ffaa894d380
        public void set_attribute(){} // RVA: 0x7ffaa8933e30
        public void get_settings(){} // RVA: 0x7ffaa89357c0
        public void set_settings(){} // RVA: 0x7ffaa8998e80
        public void get_renderer(){} // RVA: 0x7ffaaf0ebd80
        public void .ctor(){} // RVA: 0x7ffaaf0ebef0
        public void Release(){} // RVA: 0x7ffaaf0ec020
        public void ResetHistory(){} // RVA: 0x7ffaaf0ec090
        public void CastSettings(){} // RVA: 0x7ffaa887e5c0
        public void CastRenderer(){} // RVA: 0x7ffaa887e5c0
    }

    public class PostProcessDebug : MonoBehaviour
    {
        public object lightMeter; // 0x33ACD910
        public object vectorscope; // 0x33ACD910
        public object m_CmdAfterEverything; // 0x33ACD910
        public object sortedBundles; // 0x1700000B
        public object cameraDepthFlags; // 0x1700000C
        public object haveBundlesBeenInited; // 0x1700000D

        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaaf0ec0b0
        public void OnDisable(){} // RVA: 0x7ffaaf0ec1f0
        public void Update(){} // RVA: 0x7ffaaf0ec390
        public void Reset(){} // RVA: 0x7ffaaf0ec3a0
        public void UpdateStates(){} // RVA: 0x7ffaaf0ec430
        public void OnPostRender(){} // RVA: 0x7ffaaf0ec9a0
        public void OnGUI(){} // RVA: 0x7ffaaf0ecd30
        public void DrawMonitor(){} // RVA: 0x7ffaaf0ecf50
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class PostProcessDebugLayer : Object
    {
        public object waveform; // 0x33466860
        public object frameWidth; // 0x33466860
        public object _debugOverlayActive; // 0x33466860, was: <debugOverlayActive>k__Backing

        // ── Original Methods ──
        public void get_debugOverlayTarget(){} // RVA: 0x7ffaa89af740
        public void set_debugOverlayTarget(){} // RVA: 0x7ffaa895a200
        public void get_debugOverlayActive(){} // RVA: 0x7ffaa89e9d30
        public void set_debugOverlayActive(){} // RVA: 0x7ffaa89e9d40
        public void get_debugOverlay(){} // RVA: 0x7ffaa99531a0
        public void set_debugOverlay(){} // RVA: 0x7ffaaa2a7b40
        public void OnEnable(){} // RVA: 0x7ffaaf0ed140
        public void OnDisable(){} // RVA: 0x7ffaaf0ed520
        public void DestroyDebugOverlayTarget(){} // RVA: 0x7ffaaf0ed6c0
        public void RequestMonitorPass(){} // RVA: 0x7ffaaf0ed770
        public void RequestDebugOverlay(){} // RVA: 0x7ffaaa2a7b40
        public void PushDebugOverlay(){} // RVA: 0x7ffaaf0ed7f0
        public void RenderMonitors(){} // RVA: 0x7ffaaf0edd50
        public void RenderSpecialOverlays(){} // RVA: 0x7ffaaf0ee3b0
        public void EndFrame(){} // RVA: 0x7ffaaf0ee900
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetFrameSize(){} // RVA: 0x7ffaaf0ed7e0
        public void GetCameraFlags(){} // RVA: 0x7ffaaf0edd20
    }

    public class PostProcessEffectRenderer : Object
    {
        // ── Original Methods ──
        public void Init(){} // RVA: 0x7ffaa8932310
        public void ResetHistory(){} // RVA: 0x7ffaa8c586c0
        public void Release(){} // RVA: 0x7ffaae8d4a00
        public void Render(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8c586c0
        // ── Binary Analysis Named ──
        public void GetCameraFlags(){} // RVA: 0x7ffaa8f22da0
        public void SetSettings(){} // RVA: 0x7ffaa8660d80
    }

    public class PostProcessEffectRendererExtensions : Object
    {
        // ── Original Methods ──
        public void RenderOrLog(){} // RVA: 0x7ffaaf102050
    }

    public class PostProcessEffectRenderer`1 : PostProcessEffectRenderer
    {
        // ── Original Methods ──
        public void get_settings(){} // RVA: 0x7ffaa887e5c0
        public void set_settings(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void SetSettings(){} // RVA: 0x7ffaa8660d80
    }

    public class PostProcessEffectSettings : ScriptableObject
    {
        public object parameters; // 0x33562E90
        public object Capacity; // 0x170008CD

        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaaf0eeac0
        public void OnDisable(){} // RVA: 0x7ffaaf0ef160
        public void IsEnabledAndSupported(){} // RVA: 0x7ffaaf0ef580
        public void .ctor(){} // RVA: 0x7ffaaf0ef7c0
        public void <OnEnable>b__3_2(){} // RVA: 0x7ffaaf0ef890
        // ── Binary Analysis Named ──
        public void SetAllOverridesTo(){} // RVA: 0x7ffaaf0ef360
        public void GetHash(){} // RVA: 0x7ffaaf0ef5a0
    }

    public class PostProcessEventComparer : ValueType
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaab7a6cd0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaab7ef490
    }

    public class PostProcessLayer : MonoBehaviour
    {
        public object stopNaNPropagation; // 0x3185BC40
        public object temporalAntialiasing; // 0x3185BC40
        public object fog; // 0x3185BC40
        public object m_Resources; // 0x3185BC40
        public object m_ShowCustomSorter; // 0x3185BC40
        public object m_BeforeStackBundles; // 0x3185BC40
        public object _cameraDepthFlags; // 0x3185BC40, was: <cameraDepthFlags>k__BackingFi
        public object m_PropertySheetFactory; // 0x3185BC40
        public object m_LegacyCmdBufferOpaque; // 0x3185BC40
        public object m_CurrentContext; // 0x3185BC40
        public object m_IsRenderingInSceneView; // 0x3185BC40
        public object m_ActiveEffects; // 0x3185BC40
        public object  y20; // 0x150000
        public object  y20; // 0x150000

        // ── Original Methods ──
        public void get_sortedBundles(){} // RVA: 0x7ffaa8f75d20
        public void set_sortedBundles(){} // RVA: 0x7ffaa8f7b0d0
        public void get_cameraDepthFlags(){} // RVA: 0x7ffaaa2a7de0
        public void set_cameraDepthFlags(){} // RVA: 0x7ffaaa2a7dd0
        public void get_haveBundlesBeenInited(){} // RVA: 0x7ffaa8b6f1e0
        public void set_haveBundlesBeenInited(){} // RVA: 0x7ffaa8b70a80
        public void OnEnable(){} // RVA: 0x7ffaaf0efb00
        public void InitLegacy(){} // RVA: 0x7ffaaf0efe80
        public void DynamicResolutionAllowsFinalBlitToCameraTarget(){} // RVA: 0x7ffaaf0f0490
        public void OnRenderImage(){} // RVA: 0x7ffaaf0f0590
        public void Init(){} // RVA: 0x7ffaaf0f0650
        public void InitBundles(){} // RVA: 0x7ffaaf0f0850
        public void UpdateBundleSortList(){} // RVA: 0x7ffaaf0f0fa0
        public void OnDisable(){} // RVA: 0x7ffaaf0f18a0
        public void Reset(){} // RVA: 0x7ffaaf0f1ed0
        public void OnPreCull(){} // RVA: 0x7ffaaf0f1f70
        public void OnPreRender(){} // RVA: 0x7ffaaf0f2bf0
        public void RequiresInitialBlit(){} // RVA: 0x7ffaa8a17850
        public void UpdateSrcDstForOpaqueOnly(){} // RVA: 0x7ffaaf0f2cb0
        public void BuildCommandBuffers(){} // RVA: 0x7ffaaf0f2ee0
        public void OnPostRender(){} // RVA: 0x7ffaaf0f4320
        public void BakeMSVOMap(){} // RVA: 0x7ffaaf0f4600
        public void OverrideSettings(){} // RVA: 0x7ffaaf0f4800
        public void ResetHistory(){} // RVA: 0x7ffaaf0f4e30
        public void HasOpaqueOnlyEffects(){} // RVA: 0x7ffaaf0f4fe0
        public void HasActiveEffects(){} // RVA: 0x7ffaaf0f4ff0
        public void UpdateVolumeSystem(){} // RVA: 0x7ffaaf0f5800
        public void RenderOpaqueOnly(){} // RVA: 0x7ffaaf0f59d0
        public void Render(){} // RVA: 0x7ffaaf0f5ad0
        public void RenderInjectionPoint(){} // RVA: 0x7ffaaf0f6830
        public void RenderList(){} // RVA: 0x7ffaaf0f6ad0
        public void ApplyFlip(){} // RVA: 0x7ffaaf0f7320
        public void ApplyDefaultFlip(){} // RVA: 0x7ffaaf0f7430
        public void RenderBuiltins(){} // RVA: 0x7ffaaf0f7580
        public void RenderFinalPass(){} // RVA: 0x7ffaaf0f8270
        public void RenderEffect(){}
        public void ShouldGenerateLogHistogram(){} // RVA: 0x7ffaaf0f8e40
        public void .ctor(){} // RVA: 0x7ffaaf0f8ef0
        // ── Binary Analysis Named ──
        public void GetBundle(){} // RVA: 0x7ffaaf0f45a0
        public void GetBundle(){} // RVA: 0x7ffaaf0f45a0
        public void GetSettings(){} // RVA: 0x7ffaa887e5c0
        public void SetLegacyCameraFlags(){} // RVA: 0x7ffaaf0f4a90
        public void SetupContext(){} // RVA: 0x7ffaaf0f5230
    }

    public class PostProcessManager : Object
    {
        public object m_SortedVolumes; // 0x333D3C10
        public object m_BaseSettings; // 0x333D3C10

        // ── Original Methods ──
        public void get_instance(){} // RVA: 0x7ffaaf0f93d0
        public void .ctor(){} // RVA: 0x7ffaaf0f94b0
        public void CleanBaseTypes(){} // RVA: 0x7ffaaf0f98d0
        public void ReloadBaseTypes(){} // RVA: 0x7ffaaf0f9ab0
        public void QuickVolume(){} // RVA: 0x7ffaaf0fabd0
        public void UpdateVolumeLayer(){} // RVA: 0x7ffaaf0fb010
        public void Register(){} // RVA: 0x7ffaaf0fb260
        public void Register(){} // RVA: 0x7ffaaf0fb260
        public void Unregister(){} // RVA: 0x7ffaaf0fb530
        public void Unregister(){} // RVA: 0x7ffaaf0fb530
        public void ReplaceData(){} // RVA: 0x7ffaaf0fb610
        public void UpdateSettings(){} // RVA: 0x7ffaaf0fb900
        public void GrabVolumes(){} // RVA: 0x7ffaaf0fc1a0
        public void SortByPriority(){} // RVA: 0x7ffaaf0fc6f0
        public void IsVolumeRenderedByCamera(){} // RVA: 0x7ffaa8a17850
        // ── Binary Analysis Named ──
        public void GetActiveVolumes(){} // RVA: 0x7ffaaf0fa0f0
        public void GetHighestPriorityVolume(){} // RVA: 0x7ffaaf0fa9f0
        public void GetHighestPriorityVolume(){} // RVA: 0x7ffaaf0fa9f0
        public void SetLayerDirty(){} // RVA: 0x7ffaaf0fae40
    }

    public class PostProcessProfile : ScriptableObject
    {
        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaaf0fc9e0
        public void AddSettings(){} // RVA: 0x7ffaaf0fcd50
        public void AddSettings(){} // RVA: 0x7ffaaf0fcd50
        public void AddSettings(){} // RVA: 0x7ffaaf0fcd50
        public void RemoveSettings(){} // RVA: 0x7ffaaf0fce20
        public void RemoveSettings(){} // RVA: 0x7ffaaf0fce20
        public void HasSettings(){} // RVA: 0x7ffaaf0fcfb0
        public void HasSettings(){} // RVA: 0x7ffaaf0fcfb0
        public void TryGetSettings(){} // RVA: 0x7ffaa864a2a0
        public void .ctor(){} // RVA: 0x7ffaaf0fd150
        // ── Binary Analysis Named ──
        public void GetSetting(){} // RVA: 0x7ffaa887e5c0
    }

    public class PostProcessRenderContext : Object
    {
        public object _source; // 0x33A6DF20, was: <source>k__BackingField
        public object _flip; // 0x33A6DF20, was: <flip>k__BackingField
        public object _userData; // 0x33A6DF20, was: <userData>k__BackingField
        public object _height; // 0x33A6DF20, was: <height>k__BackingField
        public object _numberOfEyes; // 0x33A6DF20, was: <numberOfEyes>k__BackingField
        public object _screenHeight; // 0x33A6DF20, was: <screenHeight>k__BackingField
        public object _temporalAntialiasing; // 0x33A6DF20, was: <temporalAntialiasing>k__Backi
        public object logHistogram; // 0x33A6DF20
        public object bloomBufferNameID; // 0x33A6DF20

        // ── Original Methods ──
        public void get_camera(){} // RVA: 0x7ffaa894d380
        public void set_camera(){} // RVA: 0x7ffaaf0fd390
        public void get_command(){} // RVA: 0x7ffaa89357c0
        public void set_command(){} // RVA: 0x7ffaa8998e80
        public void get_source(){} // RVA: 0x7ffaa8f14960
        public void set_source(){} // RVA: 0x7ffaaf0fd760
        public void get_destination(){} // RVA: 0x7ffaa8f14940
        public void set_destination(){} // RVA: 0x7ffaaf0fd780
        public void get_sourceFormat(){} // RVA: 0x7ffaa95c5a20
        public void set_sourceFormat(){} // RVA: 0x7ffaa8ac7670
        public void get_flip(){} // RVA: 0x7ffaa95facb0
        public void set_flip(){} // RVA: 0x7ffaadbe65b0
        public void get_resources(){} // RVA: 0x7ffaa8af68f0
        public void set_resources(){} // RVA: 0x7ffaa8af19e0
        public void get_propertySheets(){} // RVA: 0x7ffaa8d1a3b0
        public void set_propertySheets(){} // RVA: 0x7ffaa8efece0
        public void get_userData(){} // RVA: 0x7ffaa8971010
        public void set_userData(){} // RVA: 0x7ffaa8f7b010
        public void get_debugLayer(){} // RVA: 0x7ffaa8d1b980
        public void set_debugLayer(){} // RVA: 0x7ffaa8f7b070
        public void get_width(){} // RVA: 0x7ffaaa2a8330
        public void set_width(){} // RVA: 0x7ffaaa2a8340
        public void get_height(){} // RVA: 0x7ffaaa2a7db0
        public void set_height(){} // RVA: 0x7ffaaa2a7dc0
        public void get_stereoActive(){} // RVA: 0x7ffaa9feeae0
        public void set_stereoActive(){} // RVA: 0x7ffaa91d7fd0
        public void get_xrActiveEye(){} // RVA: 0x7ffaabf46920
        public void set_xrActiveEye(){} // RVA: 0x7ffaabf46930
        public void get_numberOfEyes(){} // RVA: 0x7ffaa9325970
        public void set_numberOfEyes(){} // RVA: 0x7ffaa932b8c0
        public void get_stereoRenderingMode(){} // RVA: 0x7ffaabf46940
        public void set_stereoRenderingMode(){} // RVA: 0x7ffaabf46950
        public void get_screenWidth(){} // RVA: 0x7ffaaa5f96a0
        public void set_screenWidth(){} // RVA: 0x7ffaae1d6ca0
        public void get_screenHeight(){} // RVA: 0x7ffaac120410
        public void set_screenHeight(){} // RVA: 0x7ffaac120420
        public void get_isSceneView(){} // RVA: 0x7ffaa9c12640
        public void set_isSceneView(){} // RVA: 0x7ffaa9c14170
        public void get_antialiasing(){} // RVA: 0x7ffaa91d1f30
        public void set_antialiasing(){} // RVA: 0x7ffaaf0fd7a0
        public void get_temporalAntialiasing(){} // RVA: 0x7ffaa899d120
        public void set_temporalAntialiasing(){} // RVA: 0x7ffaa899d130
        public void Reset(){} // RVA: 0x7ffaaf0fd7b0
        public void IsTemporalAntialiasingActive(){} // RVA: 0x7ffaaf0fdd90
        public void IsDebugOverlayEnabled(){} // RVA: 0x7ffaaf0fddd0
        public void PushDebugOverlay(){} // RVA: 0x7ffaaf0fde00
        public void UpdateSinglePassStereoState(){} // RVA: 0x7ffaaf0fe1c0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetDescriptor(){} // RVA: 0x7ffaaf0fde60
        public void GetScreenSpaceTemporaryRT(){} // RVA: 0x7ffaaf0fe130
        public void GetScreenSpaceTemporaryRT(){} // RVA: 0x7ffaaf0fe130
    }

    public class PostProcessResources : ScriptableObject
    {
        public object smaaLuts; // 0x33466470
        public object P00; // 0x84EF8048

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class PostProcessVolume : MonoBehaviour
    {
        public object blendDistance; // 0x3390FA20
        public object m_PreviousLayer; // 0x3390FA20
        public object m_InternalProfile; // 0x3390FA20

        // ── Original Methods ──
        public void get_profile(){} // RVA: 0x7ffaaf0fe460
        public void set_profile(){} // RVA: 0x7ffaa89ad740
        public void get_profileRef(){} // RVA: 0x7ffaaf0fe850
        public void HasInstantiatedProfile(){} // RVA: 0x7ffaaf0fe930
        public void get_previousLayer(){} // RVA: 0x7ffaa8fb82b0
        public void OnEnable(){} // RVA: 0x7ffaaf0fea00
        public void OnDisable(){} // RVA: 0x7ffaaf0fec30
        public void Update(){} // RVA: 0x7ffaaf0fed20
        public void OnDrawGizmos(){} // RVA: 0x7ffaaf0fee60
        public void .ctor(){} // RVA: 0x7ffaaf0ffc20
    }

    public class PropertySheet : Object
    {
        // ── Original Methods ──
        public void get_properties(){} // RVA: 0x7ffaa894d380
        public void set_properties(){} // RVA: 0x7ffaa8933e30
        public void get_material(){} // RVA: 0x7ffaa89357c0
        public void set_material(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaaf1020c0
        public void ClearKeywords(){} // RVA: 0x7ffaaf102200
        public void EnableKeyword(){} // RVA: 0x7ffaaf102260
        public void DisableKeyword(){} // RVA: 0x7ffaaf1022d0
        public void Release(){} // RVA: 0x7ffaaf102340
    }

    public class PropertySheetFactory : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf1023f0
        public void Release(){} // RVA: 0x7ffaaf102920
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaaf102600
        public void Get(){} // RVA: 0x7ffaaf102600
    }

    public class RuntimeUtilities : Object
    {
        public object m_BlackTexture; // 0x30BB1050
        public object m_TransparentTexture3D; // 0x30BB1050
        public object s_FullscreenTriangle; // 0x30BB1050
        public object s_CopyMaterial; // 0x30BB1050
        public object s_CopyFromTexArraySheet; // 0x30BB1050

        // ── Original Methods ──
        public void get_whiteTexture(){} // RVA: 0x7ffaaf102c30
        public void get_whiteTexture3D(){} // RVA: 0x7ffaaf102ee0
        public void get_blackTexture(){} // RVA: 0x7ffaaf1031b0
        public void get_blackTexture3D(){} // RVA: 0x7ffaaf103470
        public void get_transparentTexture(){} // RVA: 0x7ffaaf103740
        public void get_transparentTexture3D(){} // RVA: 0x7ffaaf103a00
        public void get_fullscreenTriangle(){} // RVA: 0x7ffaaf104150
        public void get_copyStdMaterial(){} // RVA: 0x7ffaaf104660
        public void get_copyStdFromDoubleWideMaterial(){} // RVA: 0x7ffaaf1048f0
        public void get_copyMaterial(){} // RVA: 0x7ffaaf104b80
        public void get_copyFromTexArrayMaterial(){} // RVA: 0x7ffaaf104e10
        public void get_copySheet(){} // RVA: 0x7ffaaf1050a0
        public void get_copyFromTexArraySheet(){} // RVA: 0x7ffaaf1051f0
        public void isValidResources(){} // RVA: 0x7ffaaf105340
        public void UpdateResources(){} // RVA: 0x7ffaaf105440
        public void BlitFullscreenTriangle(){} // RVA: 0x7ffaaf1073d0
        public void BlitFullscreenTriangle(){} // RVA: 0x7ffaaf1073d0
        public void BlitFullscreenTriangle(){} // RVA: 0x7ffaaf1073d0
        public void BlitFullscreenTriangleFromDoubleWide(){} // RVA: 0x7ffaaf106440
        public void BlitFullscreenTriangleToDoubleWide(){} // RVA: 0x7ffaaf106610
        public void BlitFullscreenTriangleFromTexArray(){} // RVA: 0x7ffaaf106890
        public void BlitFullscreenTriangleToTexArray(){} // RVA: 0x7ffaaf106c70
        public void BlitFullscreenTriangle(){} // RVA: 0x7ffaaf1073d0
        public void BlitFullscreenTriangle(){} // RVA: 0x7ffaaf1073d0
        public void BuiltinBlit(){} // RVA: 0x7ffaaf1078b0
        public void BuiltinBlit(){} // RVA: 0x7ffaaf1078b0
        public void CopyTexture(){} // RVA: 0x7ffaaf107a50
        public void get_scriptableRenderPipelineActive(){} // RVA: 0x7ffaaf107cb0
        public void get_supportsDeferredShading(){} // RVA: 0x7ffaaf107d80
        public void get_supportsDepthNormals(){} // RVA: 0x7ffaaf107e20
        public void get_isSinglePassStereoEnabled(){} // RVA: 0x7ffaaf107ec0
        public void get_isVREnabled(){} // RVA: 0x7ffaaf107f60
        public void get_isAndroidOpenGL(){} // RVA: 0x7ffaaf107fb0
        public void get_isWebNonWebGPU(){} // RVA: 0x7ffaaf108080
        public void get_defaultHDRRenderTextureFormat(){} // RVA: 0x7ffaa9c0a810
        public void isFloatingPointFormat(){} // RVA: 0x7ffaaf108110
        public void hasAlpha(){} // RVA: 0x7ffaaf108130
        public void Destroy(){} // RVA: 0x7ffaaf1081d0
        public void get_isLinearColorSpace(){} // RVA: 0x7ffaaf1082c0
        public void IsResolvedDepthAvailable(){} // RVA: 0x7ffaaf108310
        public void DestroyProfile(){} // RVA: 0x7ffaaf1083f0
        public void DestroyVolume(){} // RVA: 0x7ffaaf1085c0
        public void IsPostProcessingActive(){} // RVA: 0x7ffaaf1086e0
        public void IsTemporalAntialiasingActive(){} // RVA: 0x7ffaaf1087f0
        public void IsDynamicResolutionEnabled(){} // RVA: 0x7ffaaf108950
        public void CreateIfNull(){} // RVA: 0x7ffaa8660d50
        public void Exp2(){} // RVA: 0x7ffaaf108b60
        public void GenerateJitteredProjectionMatrixFromOriginal(){} // RVA: 0x7ffaaf1091e0
        public void .cctor(){} // RVA: 0x7ffaaf109680
        // ── Binary Analysis Named ──
        public void GetLutStrip(){} // RVA: 0x7ffaaf103cd0
        public void SetRenderTargetWithLoadStoreAction(){} // RVA: 0x7ffaaf1059d0
        public void SetRenderTargetWithLoadStoreAction(){} // RVA: 0x7ffaaf1059d0
        public void SetRenderTargetWithLoadStoreAction(){} // RVA: 0x7ffaaf1059d0
        public void GetAllSceneObjects(){} // RVA: 0x7ffaa8648dd0
        public void GetJitteredPerspectiveProjectionMatrix(){} // RVA: 0x7ffaaf108b70
        public void GetJitteredOrthographicProjectionMatrix(){} // RVA: 0x7ffaaf108e90
        public void GetAllAssemblyTypes(){} // RVA: 0x7ffaaf1093c0
        public void GetAllTypesDerivedFrom(){} // RVA: 0x7ffaa8648dd0
        public void GetAttribute(){} // RVA: 0x7ffaa887e5c0
        public void GetMemberAttributes(){} // RVA: 0x7ffaa86492c0
        public void GetFieldPath(){} // RVA: 0x7ffaa86492c0
    }

    public class ScalableAO : Object
    {
        public object m_Settings; // 0x33ACDF10

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf0dff00
        public void Render(){} // RVA: 0x7ffaaf0e07b0
        public void RenderAfterOpaque(){} // RVA: 0x7ffaaf0e1520
        public void RenderAmbientOnly(){} // RVA: 0x7ffaaf0e1810
        public void CompositeAmbientOnly(){} // RVA: 0x7ffaaf0e1930
        public void Release(){} // RVA: 0x7ffaaf0e1c10
        // ── Binary Analysis Named ──
        public void GetCameraFlags(){} // RVA: 0x7ffaa9099760
        public void DoLazyInitialization(){} // RVA: 0x7ffaaf0e0150
    }

    public class ScreenSpaceReflections : PostProcessEffectSettings
    {
        public object resolution; // 0x338770F0
        public object distanceFade; // 0x338770F0
        public object P00; // 0x84ECF398

        // ── Original Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7ffaaf0e1d60
        public void .ctor(){} // RVA: 0x7ffaaf0e1f50
    }

    public class ShaderIDs : Object
    {
        public object Sharpness; // 0x33C268E0
        public object SMAA_Flip; // 0x33C268E0
        public object AOColor; // 0x33C268E0
        public object SAOcclusionTexture; // 0x33C268E0
        public object LinearDepth; // 0x33C268E0
        public object LowDepth3; // 0x33C268E0
        public object TiledDepth2; // 0x33C268E0
        public object Occlusion1; // 0x33C268E0
        public object Occlusion4; // 0x33C268E0
        public object Combined3; // 0x33C268E0
        public object Test; // 0x33C268E0
        public object ViewMatrix; // 0x33C268E0
        public object Params2; // 0x33C268E0
        public object VelocityScale; // 0x33C268E0
        public object VelocityTex; // 0x33C268E0
        public object Tile8RT; // 0x33C268E0
        public object TileVRT; // 0x33C268E0
        public object DepthOfFieldTemp; // 0x33C268E0
        public object LensCoeff; // 0x33C268E0
        public object RcpAspect; // 0x33C268E0
        public object AutoExposureTex; // 0x33C268E0
        public object ScaleOffsetRes; // 0x33C268E0
        public object Threshold; // 0x33C268E0
        public object Bloom_Settings; // 0x33C268E0
        public object ChromaticAberration_Amount; // 0x33C268E0
        public object Distortion_Amount; // 0x33C268E0
        public object Lut3D_Params; // 0x33C268E0
        public object PostExposure; // 0x33C268E0
        public object HueSatCon; // 0x33C268E0
        public object ChannelMixerGreen; // 0x33C268E0
        public object InvGamma; // 0x33C268E0
        public object CustomToneCurve; // 0x33C268E0
        public object MidSegmentA; // 0x33C268E0
        public object ShoSegmentB; // 0x33C268E0
        public object Vignette_Settings; // 0x33C268E0
        public object Vignette_Mode; // 0x33C268E0
        public object GrainTex; // 0x33C268E0
        public object LumaInAlpha; // 0x33C268E0
        public object From; // 0x33C268E0
        public object TargetColor; // 0x33C268E0
        public object WaveformBuffer; // 0x33C268E0
        public object UVTransform; // 0x33C268E0
        public object PosScaleOffset; // 0x33C268E0
        public object P00; // 0x84F2D968
        public object GetHashCode; // 0xB41F4A50
        public object `Ǐf; // 0xB41EDE30
        public object .cctor; // 0xB3F6FFF0
        public object P00; // 0x84F2DB90
        public object s_FormatAliasMap; // 0x33CD1300
        public object `;
        public object EndFrame; // 0xB3F6FFF0
        public object P00; // 0x84F2DF50
        public object `Ǐf; // 0xB41F4A50

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaf109880
    }

    public class Spline : Object
    {
        public object curve; // 0x33ACFAA0
        public object m_Range; // 0x33ACFAA0
        public object cachedData; // 0x33ACFAA0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf10d0c0
        public void Cache(){} // RVA: 0x7ffaaf10d1f0
        public void Evaluate(){} // RVA: 0x7ffaaf10d5d0
        public void Evaluate(){} // RVA: 0x7ffaaf10d5d0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf10d690
    }

    public class SubpixelMorphologicalAntialiasing : Object
    {
        public object P00; // 0x84EC0030

        // ── Original Methods ──
        public void IsSupported(){} // RVA: 0x7ffaaf0e4620
        public void Render(){} // RVA: 0x7ffaaf0e4670
        public void .ctor(){} // RVA: 0x7ffaaf0e4e50
    }

    public class TargetPool : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf10d6c0
        public void Reset(){} // RVA: 0x7ffaa90bf2b0
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaaf10d7b0
        public void Get(){} // RVA: 0x7ffaaf10d7b0
    }

    public class TemporalAntialiasing : Object
    {
        public object stationaryBlending; // 0x33736060
        public object _jitter; // 0x33736060, was: <jitter>k__BackingField
        public object k_SampleCount; // 0x33736060
        public object k_NumHistoryTextures; // 0x33736060
        public object P00; // 0x400012C

        // ── Original Methods ──
        public void get_jitter(){} // RVA: 0x7ffaa9dcc710
        public void set_jitter(){} // RVA: 0x7ffaa8e049c0
        public void get_sampleIndex(){} // RVA: 0x7ffaa8de7460
        public void set_sampleIndex(){} // RVA: 0x7ffaaa1eabc0
        public void IsSupported(){} // RVA: 0x7ffaaf0e4e60
        public void ResetHistory(){} // RVA: 0x7ffaa967fb00
        public void GenerateRandomOffset(){} // RVA: 0x7ffaaf0e4f40
        public void ConfigureJitteredProjectionMatrix(){} // RVA: 0x7ffaaf0e52f0
        public void ConfigureStereoJitteredProjectionMatrices(){} // RVA: 0x7ffaaf0e54d0
        public void GenerateHistoryName(){} // RVA: 0x7ffaaf0e5960
        public void Render(){} // RVA: 0x7ffaaf0e6170
        public void Release(){} // RVA: 0x7ffaaf0e6800
        public void .ctor(){} // RVA: 0x7ffaaf0e6960
        // ── Binary Analysis Named ──
        public void GetCameraFlags(){} // RVA: 0x7ffaa8c02b10
        public void GetJitteredProjectionMatrix(){} // RVA: 0x7ffaaf0e5020
        public void CheckHistory(){} // RVA: 0x7ffaaf0e5ad0
    }

    public class TextureFormatUtilities : Object
    {
        public object s_SupportedTextureFormats; // 0x33CD1300

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaf10d9f0
        public void IsObsolete(){} // RVA: 0x7ffaaf10ebb0
        public void IsSupported(){} // RVA: 0x7ffaaf10f060
        public void IsSupported(){} // RVA: 0x7ffaaf10f060
        // ── Binary Analysis Named ──
        public void GetUncompressedRenderTextureFormat(){} // RVA: 0x7ffaaf10ed40
    }

    public class TextureLerper : Object
    {
        public object m_PropertySheets; // 0x33CD0B80
        public object m_Actives; // 0x33CD0B80
        public object instance; // 0x1700004D

        // ── Original Methods ──
        public void get_instance(){} // RVA: 0x7ffaaf10f130
        public void .ctor(){} // RVA: 0x7ffaaf10f330
        public void EndFrame(){} // RVA: 0x7ffaaf10f5b0
        public void Lerp(){} // RVA: 0x7ffaaf110530
        public void Lerp(){} // RVA: 0x7ffaaf110530
        public void Clear(){} // RVA: 0x7ffaaf110d70
        // ── Binary Analysis Named ──
        public void BeginFrame(){} // RVA: 0x7ffaaf10f470
        public void Get(){} // RVA: 0x7ffaaf10f820
    }

    public class TrackballAttribute : Attribute
    {
        public object P00; // 0x3024EA20

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89350c0
    }

    public class VectorscopeMonitor : Monitor
    {
        public object m_Data; // 0x335218B0
        public object OnDisable; // 0xB3F6FFF0

        // ── Original Methods ──
        public void OnDisable(){} // RVA: 0x7ffaaf0e9130
        public void NeedsHalfRes(){} // RVA: 0x7ffaa8a17850
        public void ShaderResourcesAvailable(){} // RVA: 0x7ffaaf0e91f0
        public void Render(){} // RVA: 0x7ffaaf0e92f0
        public void .ctor(){} // RVA: 0x7ffaaf0e9cd0
    }

    public class Vignette : PostProcessEffectSettings
    {
        public object center; // 0x33643A50
        public object roundness; // 0x33643A50
        public object opacity; // 0x33643A50

        // ── Original Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7ffaaf0e6b60
        public void .ctor(){} // RVA: 0x7ffaaf0e6cc0
    }

    public class WaveformMonitor : Monitor
    {
        public object m_Data; // 0x337DDE80
        public object k_ThreadGroupSizeY; // 0x337DDE80

        // ── Original Methods ──
        public void OnDisable(){} // RVA: 0x7ffaaf0e9130
        public void NeedsHalfRes(){} // RVA: 0x7ffaa8a17850
        public void ShaderResourcesAvailable(){} // RVA: 0x7ffaaf0e9ce0
        public void Render(){} // RVA: 0x7ffaaf0e9de0
        public void .ctor(){} // RVA: 0x7ffaaf0ea940
    }

}