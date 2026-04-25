// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 59
// Methods: 461

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class AmbientOcclusion : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AC6320
        public void .ctor(){} // RVA: 0x7FFD54AC66D0
    }

    public class AutoExposure : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AC7450
        public void .ctor(){} // RVA: 0x7FFD54AC7610
    }

    public class Bloom : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AC8E70
        public void .ctor(){} // RVA: 0x7FFD54AC8EB0
    }

    public class ChromaticAberration : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54ACAD10
        public void .ctor(){} // RVA: 0x7FFD54ACAD50
    }

    public class ColorGrading : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54ACB6F0
        public void .ctor(){} // RVA: 0x7FFD54ACB7B0
    }

    public class ColorUtilities : Object
    {
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
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AD2A60
        public void .ctor(){} // RVA: 0x7FFD54AD2AD0
    }

    public class DisplayNameAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class Dithering : Object
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x7FFD54AD4920
        public void .ctor(){} // RVA: 0x7FFD54AD4BF0
    }

    public class FastApproximateAntialiasing : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Fog : Object
    {
        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x7FFD4E433AF0
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AD4CA0
        public void Render(){} // RVA: 0x7FFD54AD4E10
        public void .ctor(){} // RVA: 0x7FFD4EBE9980
    }

    public class Grain : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54ACAD10
        public void .ctor(){} // RVA: 0x7FFD54AD53D0
    }

    public class HableCurve : Object
    {
        public object whitePoint;
        public object inverseWhitePoint;
        public object x0;
        public object x1;

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
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AD6390
        public void .ctor(){} // RVA: 0x7FFD54AD6450
    }

    public class LightMeterMonitor : Monitor
    {
        // ── Methods ──
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFD54AE62B0
        public void Render(){} // RVA: 0x7FFD54AE6420
        public void .ctor(){} // RVA: 0x7FFD54AE6C70
    }

    public class LogHistogram : Object
    {
        public object data;

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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E46B330
    }

    public class MeshUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54AFF750
        public void GetColliderMesh(){} // RVA: 0x7FFD54AFFB30
        public void GetPrimitive(){} // RVA: 0x7FFD54AFFD20
        public void GetBuiltinMesh(){} // RVA: 0x7FFD54AFFF50
    }

    public class MinAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E46B330
    }

    public class MinMaxAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4EF4F3C0
    }

    public class Monitor : Object
    {
        public object output;

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
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AD6C00
        public void .ctor(){} // RVA: 0x7FFD54AD6D00
    }

    public class MultiScaleVO : Object
    {
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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54AC61C0 | overloaded x2
    }

    public class PostProcessBundle : Object
    {
        public object attribute;
        public object settings;
        public object renderer;

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
        public object debugOverlayTarget;
        public object debugOverlayActive;
        public object debugOverlay;

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
        public object settings;

        // ── Methods ──
        public void get_settings(){} // RVA: 0x7FFD4E2ADC40
        public void set_settings(){} // RVA: 0x7FFD4E2ADC40
        public void SetSettings(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class PostProcessEffectSettings : ScriptableObject
    {
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
        public object sortedBundles;
        public object cameraDepthFlags;
        public object haveBundlesBeenInited;

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
        public object instance;

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
        public object camera;
        public object command;
        public object source;
        public object destination;
        public object sourceFormat;
        public object flip;
        public object resources;
        public object propertySheets;
        public object userData;
        public object debugLayer;
        public object width;
        public object height;
        public object stereoActive;
        public object xrActiveEye;
        public object numberOfEyes;
        public object stereoRenderingMode;
        public object screenWidth;
        public object screenHeight;
        public object isSceneView;
        public object antialiasing;
        public object temporalAntialiasing;

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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class PostProcessVolume : MonoBehaviour
    {
        public object profile;
        public object profileRef;
        public object previousLayer;

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
        public object properties;
        public object material;

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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54B00410
        public void Get(){} // RVA: 0x7FFD54B00620 | overloaded x2
        public void Release(){} // RVA: 0x7FFD54B00940
    }

    public class RuntimeUtilities : Object
    {
        public object whiteTexture;
        public object whiteTexture3D;
        public object blackTexture;
        public object blackTexture3D;
        public object transparentTexture;
        public object transparentTexture3D;
        public object fullscreenTriangle;
        public object copyStdMaterial;
        public object copyStdFromDoubleWideMaterial;
        public object copyMaterial;
        public object copyFromTexArrayMaterial;
        public object copySheet;
        public object copyFromTexArraySheet;
        public object scriptableRenderPipelineActive;
        public object supportsDeferredShading;
        public object supportsDepthNormals;
        public object isSinglePassStereoEnabled;
        public object isVREnabled;
        public object isAndroidOpenGL;
        public object isWebNonWebGPU;
        public object defaultHDRRenderTextureFormat;
        public object isLinearColorSpace;

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
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54ADFD80
        public void .ctor(){} // RVA: 0x7FFD54ADFF70
    }

    public class ShaderIDs : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54B078A0
    }

    public class Spline : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54B0B0E0
        public void Cache(){} // RVA: 0x7FFD54B0B210
        public void Evaluate(){} // RVA: 0x7FFD54B0B5F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54B0B6B0
    }

    public class SubpixelMorphologicalAntialiasing : Object
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7FFD54AE2640
        public void Render(){} // RVA: 0x7FFD54AE2690
        public void .ctor(){} // RVA: 0x7FFD54AE2E70
    }

    public class TargetPool : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54B0B6E0
        public void Get(){} // RVA: 0x7FFD54B0B7D0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFD4EAB70B0
    }

    public class TemporalAntialiasing : Object
    {
        public object jitter;
        public object sampleIndex;

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
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54B0BA10
        public void IsObsolete(){} // RVA: 0x7FFD54B0CBD0
        public void GetUncompressedRenderTextureFormat(){} // RVA: 0x7FFD54B0CD60
        public void IsSupported(){} // RVA: 0x7FFD54B0D080 | overloaded x2
    }

    public class TextureLerper : Object
    {
        public object instance;

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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3440C0
    }

    public class VectorscopeMonitor : Monitor
    {
        // ── Methods ──
        public void OnDisable(){} // RVA: 0x7FFD54AE7150
        public void NeedsHalfRes(){} // RVA: 0x7FFD4E426850
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFD54AE7210
        public void Render(){} // RVA: 0x7FFD54AE7310
        public void .ctor(){} // RVA: 0x7FFD54AE7CF0
    }

    public class Vignette : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7FFD54AE4B80
        public void .ctor(){} // RVA: 0x7FFD54AE4CE0
    }

    public class WaveformMonitor : Monitor
    {
        // ── Methods ──
        public void OnDisable(){} // RVA: 0x7FFD54AE7150
        public void NeedsHalfRes(){} // RVA: 0x7FFD4E426850
        public void ShaderResourcesAvailable(){} // RVA: 0x7FFD54AE7D00
        public void Render(){} // RVA: 0x7FFD54AE7E00
        public void .ctor(){} // RVA: 0x7FFD54AE8960
    }

}