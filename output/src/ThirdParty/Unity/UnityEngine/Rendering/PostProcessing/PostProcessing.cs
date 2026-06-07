// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 88
// Methods: 552

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class AmbientOcclusion
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x6F0DA00
        public void .ctor(){} // RVA: 0x6F0DDB0
    }

    public class AmbientOcclusionModeParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0D960
    }

    public class AmbientOcclusionQualityParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0D9B0
    }

    public class AmbientOcclusionRenderer
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x6F0E4D0
        public void IsAmbientOnly(){} // RVA: 0x6F0E690
        public void Get(){} // RVA: 0x6F0E7A0
        public void GetCameraFlags(){} // RVA: 0x6F0E810
        public void Release(){} // RVA: 0x6F0E8B0
        public void GetScalableAO(){} // RVA: 0x6F0E9C0
        public void GetMultiScaleVO(){} // RVA: 0x6F0EA30
        public void Render(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x6F0EAA0
    }

    public class AutoExposure
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x6F0EB30
        public void .ctor(){} // RVA: 0x6F0ECF0
    }

    public class AutoExposureRenderer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0F170
        public void CheckTexture(){} // RVA: 0x6F0F3B0
        public void Render(){} // RVA: 0x6F0F6C0
        public void Release(){} // RVA: 0x6F10480
    }

    public class Bloom
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x6F10550
        public void .ctor(){} // RVA: 0x6F10590
    }

    public class BloomRenderer
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x6F10BC0
        public void Render(){} // RVA: 0x6F10E80
        public void .ctor(){} // RVA: 0x6F123B0
    }

    public class BoolParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F30140
    }

    public class ChromaticAberration
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x6F123F0
        public void .ctor(){} // RVA: 0x6F12430
    }

    public class ChromaticAberrationRenderer
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x6F126A0
        public void Release(){} // RVA: 0x6F12C40
        public void .ctor(){} // RVA: 0x6F12CF0
    }

    public class ColorGrading
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x6F12DD0
        public void .ctor(){} // RVA: 0x6F12E90
    }

    public class ColorGradingRenderer
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x6F14680
        public void RenderExternalPipeline3D(){} // RVA: 0x6F148B0
        public void RenderHDRPipeline3D(){} // RVA: 0x6F14C50
        public void RenderHDRPipeline2D(){} // RVA: 0x6F15FD0
        public void RenderLDRPipeline2D(){} // RVA: 0x6F178C0
        public void CheckInternalLogLut(){} // RVA: 0x6F18CC0
        public void CheckInternalStripLut(){} // RVA: 0x6F191C0
        public void GetCurveTexture(){} // RVA: 0x6F19610
        public void IsRenderTextureFormatSupportedForLinearFiltering(){} // RVA: 0x6F19CB0
        public void GetLutFormat(){} // RVA: 0x6F19DC0
        public void GetCurveFormat(){} // RVA: 0x6F19E10
        public void Release(){} // RVA: 0x6F19E40
        public void .ctor(){} // RVA: 0x6F19FB0
    }

    public class ColorParameter
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x6F30190
        public void op_Implicit(){} // RVA: 0x6F30200
        public void .ctor(){} // RVA: 0x6F30250
    }

    public class ColorUtilities
    {
        // ── Methods ──
        public void StandardIlluminantY(){} // RVA: 0x6F45370
        public void CIExyToLMS(){} // RVA: 0x6F453A0
        public void ComputeColorBalance(){} // RVA: 0x6F45430
        public void ColorToLift(){} // RVA: 0x6F45550
        public void ColorToInverseGamma(){} // RVA: 0x6F455C0
        public void ColorToGain(){} // RVA: 0x6F45670
        public void LogCToLinear(){} // RVA: 0x6F456E0
        public void LinearToLogC(){} // RVA: 0x6F45740
        public void ToHex(){} // RVA: 0x6F45790
        public void ToRGBA(){} // RVA: 0x6F45810
    }

    public class DepthOfField
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x6F1A140
        public void .ctor(){} // RVA: 0x6F1A1B0
    }

    public class DepthOfFieldRenderer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F1A460
        public void GetCameraFlags(){} // RVA: 0x3CFAF0
        public void SelectFormat(){} // RVA: 0x6F1A6A0
        public void CalculateMaxCoCRadius(){} // RVA: 0x6F1A740
        public void CheckHistory(){} // RVA: 0x6F1A7D0
        public void Render(){} // RVA: 0x6F1ABB0
        public void Release(){} // RVA: 0x6F1BF10
    }

    public class DisplayNameAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class Dithering
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x6F1C000
        public void .ctor(){} // RVA: 0x6F1C2D0
    }

    public class EyeAdaptationParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0EAE0
    }

    public class FastApproximateAntialiasing
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class FloatParameter
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x6F30050
        public void .ctor(){} // RVA: 0x6F30070
    }

    public class Fog
    {
        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x3CFAF0
        public void IsEnabledAndSupported(){} // RVA: 0x6F1C380
        public void Render(){} // RVA: 0x6F1C4F0
        public void .ctor(){} // RVA: 0x570B20
    }

    public class GradingModeParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F12D30
    }

    public class Grain
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x6F123F0
        public void .ctor(){} // RVA: 0x6F1CAB0
    }

    public class GrainRenderer
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x6F1CD60
        public void GetLookupFormat(){} // RVA: 0x6F1D920
        public void Release(){} // RVA: 0x6F1D980
        public void .ctor(){} // RVA: 0x6F1DA30
    }

    public class HableCurve
    {
        // ── Methods ──
        public void get_whitePoint(){} // RVA: 0x407320
        public void set_whitePoint(){} // RVA: 0x407330
        public void get_inverseWhitePoint(){} // RVA: 0x407340
        public void set_inverseWhitePoint(){} // RVA: 0x407350
        public void get_x0(){} // RVA: 0x2E1CF0
        public void set_x0(){} // RVA: 0x2F84D0
        public void get_x1(){} // RVA: 0x3AA570
        public void set_x1(){} // RVA: 0x3AA580
        public void .ctor(){} // RVA: 0x6F45890
        public void Eval(){} // RVA: 0x6F45AE0
        public void Init(){} // RVA: 0x6F45B80
        public void InitSegments(){} // RVA: 0x6F45DC0
        public void SolveAB(){} // RVA: 0x6F46300
        public void AsSlopeIntercept(){} // RVA: 0x6F46370
        public void EvalDerivativeLinearGamma(){} // RVA: 0x6F463D0
    }

    public class HaltonSeq
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x6F466C0
    }

    public class HistogramMonitor
    {
        // ── Methods ──
        public void OnDisable(){} // RVA: 0x6F2CF00
        public void NeedsHalfRes(){} // RVA: 0x3C2850
        public void ShaderResourcesAvailable(){} // RVA: 0x6F2CFC0
        public void Render(){} // RVA: 0x6F2D0C0
        public void .ctor(){} // RVA: 0x6F2D970
    }

    public class IAmbientOcclusionMethod
    {
        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0xD840
        public void RenderAfterOpaque(){} // RVA: 0x24B10
        public void RenderAmbientOnly(){} // RVA: 0x24B10
        public void CompositeAmbientOnly(){} // RVA: 0x24B10
        public void Release(){} // RVA: 0x24A50
    }

    public class IntParameter
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x6F300C0
        public void .ctor(){} // RVA: 0x6F300F0
    }

    public class KernelSizeParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F1A0F0
    }

    public class LensDistortion
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x6F1DA70
        public void .ctor(){} // RVA: 0x6F1DB30
    }

    public class LensDistortionRenderer
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x6F1DEF0
        public void .ctor(){} // RVA: 0x6F1E2A0
    }

    public class LightMeterMonitor
    {
        // ── Methods ──
        public void ShaderResourcesAvailable(){} // RVA: 0x6F2D990
        public void Render(){} // RVA: 0x6F2DB00
        public void .ctor(){} // RVA: 0x6F2E350
    }

    public class LogHistogram
    {
        // ── Methods ──
        public void get_data(){} // RVA: 0x2F8380
        public void set_data(){} // RVA: 0x2DEE30
        public void Generate(){} // RVA: 0x6F46720
        public void GetHistogramScaleOffsetRes(){} // RVA: 0x6F46D60
        public void Release(){} // RVA: 0x6F46DB0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class MaxAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x407330
    }

    public class MeshUtilities
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6F46E30
        public void GetColliderMesh(){} // RVA: 0x6F47210
        public void GetPrimitive(){} // RVA: 0x6F47400
        public void GetBuiltinMesh(){} // RVA: 0x6F47630
    }

    public class MinAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x407330
    }

    public class MinMaxAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x10A1C60
    }

    public class Monitor
    {
        // ── Methods ──
        public void get_output(){} // RVA: 0x2F8380
        public void set_output(){} // RVA: 0x2DEE30
        public void IsRequestedAndSupported(){} // RVA: 0x6F2E370
        public void ShaderResourcesAvailable(){} // RVA: 0xDE40
        public void NeedsHalfRes(){} // RVA: 0x2DD320
        public void CheckOutput(){} // RVA: 0x6F2E460
        public void OnEnable(){} // RVA: 0x2DD310
        public void OnDisable(){} // RVA: 0x6F2E7D0
        public void Render(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class MotionBlur
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x6F1E2E0
        public void .ctor(){} // RVA: 0x6F1E3E0
    }

    public class MotionBlurRenderer
    {
        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x66CCC0
        public void CreateTemporaryRT(){} // RVA: 0x6F1E570
        public void Render(){} // RVA: 0x6F1E660
        public void .ctor(){} // RVA: 0x6F1F690
    }

    public class MultiScaleVO
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F1F6D0
        public void GetCameraFlags(){} // RVA: 0x3CFAF0
        public void SetResources(){} // RVA: 0x3A5510
        public void Alloc(){} // RVA: 0x6F1FF80
        public void AllocArray(){} // RVA: 0x6F20180
        public void Release(){} // RVA: 0x6F25550 | overloaded x2
        public void CalculateZBufferParams(){} // RVA: 0x6F203F0
        public void CalculateTanHalfFovHeight(){} // RVA: 0x6F20550
        public void GetSize(){} // RVA: 0x6F205E0
        public void GetSizeArray(){} // RVA: 0x6F20640
        public void GenerateAOMap(){} // RVA: 0x6F206A0
        public void PushAllocCommands(){} // RVA: 0x6F21410
        public void PushDownsampleCommands(){} // RVA: 0x6F21BD0
        public void PushRenderCommands(){} // RVA: 0x6F229C0
        public void PushUpsampleCommands(){} // RVA: 0x6F23520
        public void PushReleaseCommands(){} // RVA: 0x6F23C60
        public void PreparePropertySheet(){} // RVA: 0x6F24230
        public void CheckAOTexture(){} // RVA: 0x6F24470
        public void PushDebug(){} // RVA: 0x6F24900
        public void RenderAfterOpaque(){} // RVA: 0x6F249D0
        public void RenderAmbientOnly(){} // RVA: 0x6F25030
        public void CompositeAmbientOnly(){} // RVA: 0x6F25270
    }

    public class ParameterOverride
    {
        // ── Methods ──
        public void Interp(){}
        public void GetHash(){} // RVA: 0xD840
        public void GetValue(){} // RVA: 0x283FA0
        public void OnEnable(){} // RVA: 0x2DD310
        public void OnDisable(){} // RVA: 0x2DD310
        public void SetValue(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ParameterOverride`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x3
        public void Interp(){} // RVA: 0x283FA0 | overloaded x2
        public void Override(){} // RVA: 0x283FA0
        public void SetValue(){} // RVA: 0x24B10
        public void GetHash(){} // RVA: 0xD840
        public void op_Implicit(){} // RVA: 0x283FA0
    }

    public class PostProcessAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0D8A0 | overloaded x2
    }

    public class PostProcessBundle
    {
        public object sortedBundles;
        public object cameraDepthFlags;
        public object haveBundlesBeenInited;

        // ── Methods ──
        public void get_attribute(){} // RVA: 0x2F8380
        public void set_attribute(){} // RVA: 0x2DEE30
        public void get_settings(){} // RVA: 0x2E07C0
        public void set_settings(){} // RVA: 0x343E80
        public void get_renderer(){} // RVA: 0x6F31480
        public void .ctor(){} // RVA: 0x6F315F0
        public void Release(){} // RVA: 0x6F31720
        public void ResetHistory(){} // RVA: 0x6F31790
        public void CastSettings(){} // RVA: 0x283FA0
        public void CastRenderer(){} // RVA: 0x283FA0
    }

    public class PostProcessDebug
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x6F317B0
        public void OnDisable(){} // RVA: 0x6F318F0
        public void Update(){} // RVA: 0x6F31A90
        public void Reset(){} // RVA: 0x6F31AA0
        public void UpdateStates(){} // RVA: 0x6F31B30
        public void OnPostRender(){} // RVA: 0x6F320A0
        public void OnGUI(){} // RVA: 0x6F32430
        public void DrawMonitor(){} // RVA: 0x6F32650
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class PostProcessDebugLayer
    {
        // ── Methods ──
        public void get_debugOverlayTarget(){} // RVA: 0x35A740
        public void set_debugOverlayTarget(){} // RVA: 0x305200
        public void get_debugOverlayActive(){} // RVA: 0x394D30
        public void set_debugOverlayActive(){} // RVA: 0x394D40
        public void get_debugOverlay(){} // RVA: 0x1479960
        public void set_debugOverlay(){} // RVA: 0x1D75D90
        public void OnEnable(){} // RVA: 0x6F32840
        public void OnDisable(){} // RVA: 0x6F32C20
        public void DestroyDebugOverlayTarget(){} // RVA: 0x6F32DC0
        public void RequestMonitorPass(){} // RVA: 0x6F32E70
        public void RequestDebugOverlay(){} // RVA: 0x1D75D90
        public void SetFrameSize(){} // RVA: 0x6F32EE0
        public void PushDebugOverlay(){} // RVA: 0x6F32EF0
        public void GetCameraFlags(){} // RVA: 0x6F33420
        public void RenderMonitors(){} // RVA: 0x6F33450
        public void RenderSpecialOverlays(){} // RVA: 0x6F33AB0
        public void EndFrame(){} // RVA: 0x6F34000
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PostProcessEffectRenderer
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x2DD310
        public void GetCameraFlags(){} // RVA: 0x519240
        public void ResetHistory(){} // RVA: 0x6BD7E0
        public void Release(){} // RVA: 0x671BFB0
        public void Render(){} // RVA: 0x24B10
        public void SetSettings(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x6BD7E0
    }

    public class PostProcessEffectRendererExtensions
    {
        // ── Methods ──
        public void RenderOrLog(){} // RVA: 0x6F47750
    }

    public class PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void get_settings(){} // RVA: 0x283FA0
        public void set_settings(){} // RVA: 0x283FA0
        public void SetSettings(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x24A50
    }

    public class PostProcessEffectSettings
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x6F341C0
        public void OnDisable(){} // RVA: 0x6F34860
        public void SetAllOverridesTo(){} // RVA: 0x6F34A60
        public void IsEnabledAndSupported(){} // RVA: 0x6F34C80
        public void GetHash(){} // RVA: 0x6F34CA0
        public void .ctor(){} // RVA: 0x6F34EC0
        public void <OnEnable>b__3_2(){} // RVA: 0x6F34F90
    }

    public class PostProcessEventComparer
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x3471600
        public void GetHashCode(){} // RVA: 0x3B45020
    }

    public class PostProcessLayer
    {
        // ── Methods ──
        public void get_sortedBundles(){} // RVA: 0xA1C8C0
        public void set_sortedBundles(){} // RVA: 0x9AA650
        public void get_cameraDepthFlags(){} // RVA: 0x1D76590
        public void set_cameraDepthFlags(){} // RVA: 0x1D76550
        public void get_haveBundlesBeenInited(){} // RVA: 0x59FF40
        public void set_haveBundlesBeenInited(){} // RVA: 0x5A6940
        public void OnEnable(){} // RVA: 0x6F35200
        public void InitLegacy(){} // RVA: 0x6F35580
        public void DynamicResolutionAllowsFinalBlitToCameraTarget(){} // RVA: 0x6F35B90
        public void OnRenderImage(){} // RVA: 0x6F35C90
        public void Init(){} // RVA: 0x6F35D50
        public void InitBundles(){} // RVA: 0x6F35F50
        public void UpdateBundleSortList(){} // RVA: 0x6F366A0
        public void OnDisable(){} // RVA: 0x6F36FA0
        public void Reset(){} // RVA: 0x6F375D0
        public void OnPreCull(){} // RVA: 0x6F37670
        public void OnPreRender(){} // RVA: 0x6F382F0
        public void RequiresInitialBlit(){} // RVA: 0x3C2850
        public void UpdateSrcDstForOpaqueOnly(){} // RVA: 0x6F383B0
        public void BuildCommandBuffers(){} // RVA: 0x6F385E0
        public void OnPostRender(){} // RVA: 0x6F39A20
        public void GetBundle(){} // RVA: 0x6F39CA0 | overloaded x2
        public void GetSettings(){} // RVA: 0x283FA0
        public void BakeMSVOMap(){} // RVA: 0x6F39D00
        public void OverrideSettings(){} // RVA: 0x6F39F00
        public void SetLegacyCameraFlags(){} // RVA: 0x6F3A190
        public void ResetHistory(){} // RVA: 0x6F3A530
        public void HasOpaqueOnlyEffects(){} // RVA: 0x6F3A6E0
        public void HasActiveEffects(){} // RVA: 0x6F3A6F0
        public void SetupContext(){} // RVA: 0x6F3A930
        public void UpdateVolumeSystem(){} // RVA: 0x6F3AF00
        public void RenderOpaqueOnly(){} // RVA: 0x6F3B0D0
        public void Render(){} // RVA: 0x6F3B1D0
        public void RenderInjectionPoint(){} // RVA: 0x6F3BF30
        public void RenderList(){} // RVA: 0x6F3C1D0
        public void ApplyFlip(){} // RVA: 0x6F3CA20
        public void ApplyDefaultFlip(){} // RVA: 0x6F3CB30
        public void RenderBuiltins(){} // RVA: 0x6F3CC80
        public void RenderFinalPass(){} // RVA: 0x6F3D970
        public void RenderEffect(){}
        public void ShouldGenerateLogHistogram(){} // RVA: 0x6F3E540
        public void .ctor(){} // RVA: 0x6F3E5F0
    }

    public class PostProcessManager
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x6F3EAD0
        public void .ctor(){} // RVA: 0x6F3EBB0
        public void CleanBaseTypes(){} // RVA: 0x6F3EFD0
        public void ReloadBaseTypes(){} // RVA: 0x6F3F1B0
        public void GetActiveVolumes(){} // RVA: 0x6F3F7F0
        public void GetHighestPriorityVolume(){} // RVA: 0x6F400F0 | overloaded x2
        public void QuickVolume(){} // RVA: 0x6F402D0
        public void SetLayerDirty(){} // RVA: 0x6F40540
        public void UpdateVolumeLayer(){} // RVA: 0x6F40710
        public void Register(){} // RVA: 0x6F40960 | overloaded x2
        public void Unregister(){} // RVA: 0x6F40C30 | overloaded x2
        public void ReplaceData(){} // RVA: 0x6F40D10
        public void UpdateSettings(){} // RVA: 0x6F41000
        public void GrabVolumes(){} // RVA: 0x6F418A0
        public void SortByPriority(){} // RVA: 0x6F41DF0
        public void IsVolumeRenderedByCamera(){} // RVA: 0x3C2850
    }

    public class PostProcessProfile
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x6F420E0
        public void AddSettings(){} // RVA: 0x6F42450 | overloaded x3
        public void RemoveSettings(){} // RVA: 0x6F42520 | overloaded x2
        public void HasSettings(){} // RVA: 0x6F426B0 | overloaded x2
        public void GetSetting(){} // RVA: 0x283FA0
        public void TryGetSettings(){} // RVA: 0xDE40
        public void .ctor(){} // RVA: 0x6F42850
    }

    public class PostProcessRenderContext
    {
        // ── Methods ──
        public void get_camera(){} // RVA: 0x2F8380
        public void set_camera(){} // RVA: 0x6F42A90
        public void get_command(){} // RVA: 0x2E07C0
        public void set_command(){} // RVA: 0x343E80
        public void get_source(){} // RVA: 0xC42990
        public void set_source(){} // RVA: 0x6F42E60
        public void get_destination(){} // RVA: 0xF17750
        public void set_destination(){} // RVA: 0x6F42E80
        public void get_sourceFormat(){} // RVA: 0x10E5CF0
        public void set_sourceFormat(){} // RVA: 0x475080
        public void get_flip(){} // RVA: 0x1120170
        public void set_flip(){} // RVA: 0x5A2DFE0
        public void get_resources(){} // RVA: 0x4C7C50
        public void set_resources(){} // RVA: 0x4C34F0
        public void get_propertySheets(){} // RVA: 0x462D00
        public void set_propertySheets(){} // RVA: 0x464450
        public void get_userData(){} // RVA: 0x31C010
        public void set_userData(){} // RVA: 0x463060
        public void get_debugLayer(){} // RVA: 0x796DE0
        public void set_debugLayer(){} // RVA: 0xB54600
        public void get_width(){} // RVA: 0x1D76570
        public void set_width(){} // RVA: 0x1D76000
        public void get_height(){} // RVA: 0x1D76560
        public void set_height(){} // RVA: 0x1D76580
        public void get_stereoActive(){} // RVA: 0x1B6CD50
        public void set_stereoActive(){} // RVA: 0xB70090
        public void get_xrActiveEye(){} // RVA: 0x3C49C00
        public void set_xrActiveEye(){} // RVA: 0x3C49C10
        public void get_numberOfEyes(){} // RVA: 0xCC3CB0
        public void set_numberOfEyes(){} // RVA: 0xCC9310
        public void get_stereoRenderingMode(){} // RVA: 0x3C49C20
        public void set_stereoRenderingMode(){} // RVA: 0x3C49C30
        public void get_screenWidth(){} // RVA: 0x20D67F0
        public void set_screenWidth(){} // RVA: 0x601E410
        public void get_screenHeight(){} // RVA: 0x3DF1350
        public void set_screenHeight(){} // RVA: 0x3DF1360
        public void get_isSceneView(){} // RVA: 0x173F990
        public void set_isSceneView(){} // RVA: 0x173EC00
        public void get_antialiasing(){} // RVA: 0xB68000
        public void set_antialiasing(){} // RVA: 0x6F42EA0
        public void get_temporalAntialiasing(){} // RVA: 0x348120
        public void set_temporalAntialiasing(){} // RVA: 0x348130
        public void Reset(){} // RVA: 0x6F42EB0
        public void IsTemporalAntialiasingActive(){} // RVA: 0x6F43490
        public void IsDebugOverlayEnabled(){} // RVA: 0x6F434D0
        public void PushDebugOverlay(){} // RVA: 0x6F43500
        public void GetDescriptor(){} // RVA: 0x6F43560
        public void GetScreenSpaceTemporaryRT(){} // RVA: 0x6F43830 | overloaded x2
        public void UpdateSinglePassStereoState(){} // RVA: 0x6F438C0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PostProcessResources
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class PostProcessVolume
    {
        // ── Methods ──
        public void get_profile(){} // RVA: 0x6F43B60
        public void set_profile(){} // RVA: 0x358740
        public void get_profileRef(){} // RVA: 0x6F43F50
        public void HasInstantiatedProfile(){} // RVA: 0x6F44030
        public void get_previousLayer(){} // RVA: 0xFDC9F0
        public void OnEnable(){} // RVA: 0x6F44100
        public void OnDisable(){} // RVA: 0x6F44330
        public void Update(){} // RVA: 0x6F44420
        public void OnDrawGizmos(){} // RVA: 0x6F44560
        public void .ctor(){} // RVA: 0x6F45320
    }

    public class PropertySheet
    {
        // ── Methods ──
        public void get_properties(){} // RVA: 0x2F8380
        public void set_properties(){} // RVA: 0x2DEE30
        public void get_material(){} // RVA: 0x2E07C0
        public void set_material(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x6F477C0
        public void ClearKeywords(){} // RVA: 0x6F47900
        public void EnableKeyword(){} // RVA: 0x6F47960
        public void DisableKeyword(){} // RVA: 0x6F479D0
        public void Release(){} // RVA: 0x6F47A40
    }

    public class PropertySheetFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F47AF0
        public void Get(){} // RVA: 0x6F47D00 | overloaded x2
        public void Release(){} // RVA: 0x6F48020
    }

    public class RuntimeUtilities
    {
        // ── Methods ──
        public void get_whiteTexture(){} // RVA: 0x6F48330
        public void get_whiteTexture3D(){} // RVA: 0x6F485E0
        public void get_blackTexture(){} // RVA: 0x6F488B0
        public void get_blackTexture3D(){} // RVA: 0x6F48B70
        public void get_transparentTexture(){} // RVA: 0x6F48E40
        public void get_transparentTexture3D(){} // RVA: 0x6F49100
        public void GetLutStrip(){} // RVA: 0x6F493D0
        public void get_fullscreenTriangle(){} // RVA: 0x6F49850
        public void get_copyStdMaterial(){} // RVA: 0x6F49D60
        public void get_copyStdFromDoubleWideMaterial(){} // RVA: 0x6F49FF0
        public void get_copyMaterial(){} // RVA: 0x6F4A280
        public void get_copyFromTexArrayMaterial(){} // RVA: 0x6F4A510
        public void get_copySheet(){} // RVA: 0x6F4A7A0
        public void get_copyFromTexArraySheet(){} // RVA: 0x6F4A8F0
        public void isValidResources(){} // RVA: 0x6F4AA40
        public void UpdateResources(){} // RVA: 0x6F4AB40
        public void SetRenderTargetWithLoadStoreAction(){} // RVA: 0x6F4B0D0 | overloaded x3
        public void BlitFullscreenTriangle(){} // RVA: 0x6F4CAD0 | overloaded x5
        public void BlitFullscreenTriangleFromDoubleWide(){} // RVA: 0x6F4BB40
        public void BlitFullscreenTriangleToDoubleWide(){} // RVA: 0x6F4BD10
        public void BlitFullscreenTriangleFromTexArray(){} // RVA: 0x6F4BF90
        public void BlitFullscreenTriangleToTexArray(){} // RVA: 0x6F4C370
        public void BuiltinBlit(){} // RVA: 0x6F4CFB0 | overloaded x2
        public void CopyTexture(){} // RVA: 0x6F4D150
        public void get_scriptableRenderPipelineActive(){} // RVA: 0x6F4D3B0
        public void get_supportsDeferredShading(){} // RVA: 0x6F4D480
        public void get_supportsDepthNormals(){} // RVA: 0x6F4D520
        public void get_isSinglePassStereoEnabled(){} // RVA: 0x6F4D5C0
        public void get_isVREnabled(){} // RVA: 0x6F4D660
        public void get_isAndroidOpenGL(){} // RVA: 0x6F4D6B0
        public void get_isWebNonWebGPU(){} // RVA: 0x6F4D780
        public void get_defaultHDRRenderTextureFormat(){} // RVA: 0x1730F70
        public void isFloatingPointFormat(){} // RVA: 0x6F4D810
        public void hasAlpha(){} // RVA: 0x6F4D830
        public void Destroy(){} // RVA: 0x6F4D8D0
        public void get_isLinearColorSpace(){} // RVA: 0x6F4D9C0
        public void IsResolvedDepthAvailable(){} // RVA: 0x6F4DA10
        public void DestroyProfile(){} // RVA: 0x6F4DAF0
        public void DestroyVolume(){} // RVA: 0x6F4DCC0
        public void IsPostProcessingActive(){} // RVA: 0x6F4DDE0
        public void IsTemporalAntialiasingActive(){} // RVA: 0x6F4DEF0
        public void IsDynamicResolutionEnabled(){} // RVA: 0x6F4E050
        public void GetAllSceneObjects(){} // RVA: 0xC960
        public void CreateIfNull(){} // RVA: 0x24AE0
        public void Exp2(){} // RVA: 0x6F4E260
        public void GetJitteredPerspectiveProjectionMatrix(){} // RVA: 0x6F4E270
        public void GetJitteredOrthographicProjectionMatrix(){} // RVA: 0x6F4E590
        public void GenerateJitteredProjectionMatrixFromOriginal(){} // RVA: 0x6F4E8E0
        public void GetAllAssemblyTypes(){} // RVA: 0x6F4EAC0
        public void GetAllTypesDerivedFrom(){} // RVA: 0xC960
        public void GetAttribute(){} // RVA: 0x283FA0
        public void GetMemberAttributes(){} // RVA: 0xCE50
        public void GetFieldPath(){} // RVA: 0xCE50
        public void .cctor(){} // RVA: 0x6F4ED80
    }

    public class ScalableAO
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F25600
        public void GetCameraFlags(){} // RVA: 0xA308B0
        public void DoLazyInitialization(){} // RVA: 0x6F25850
        public void Render(){} // RVA: 0x6F25EB0
        public void RenderAfterOpaque(){} // RVA: 0x6F26C20
        public void RenderAmbientOnly(){} // RVA: 0x6F26F10
        public void CompositeAmbientOnly(){} // RVA: 0x6F27030
        public void Release(){} // RVA: 0x6F27310
    }

    public class ScreenSpaceReflectionPresetParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F273C0
    }

    public class ScreenSpaceReflectionResolutionParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F27410
    }

    public class ScreenSpaceReflections
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x6F27460
        public void .ctor(){} // RVA: 0x6F27650
    }

    public class ScreenSpaceReflectionsRenderer
    {
        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x66CCC0
        public void CheckRT(){} // RVA: 0x6F27AD0
        public void Render(){} // RVA: 0x6F27F90
        public void Release(){} // RVA: 0x6F29870
        public void .ctor(){} // RVA: 0x6F29990
    }

    public class ShaderIDs
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6F4EF80
    }

    public class Spline
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F527C0
        public void Cache(){} // RVA: 0x6F528F0
        public void Evaluate(){} // RVA: 0x6F52CD0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6F52D90
    }

    public class SplineParameter
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x6F30590
        public void SetValue(){} // RVA: 0x6F305B0
        public void Interp(){} // RVA: 0x6F306C0
        public void .ctor(){} // RVA: 0x6F30890
    }

    public class SubpixelMorphologicalAntialiasing
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x6F29D20
        public void Render(){} // RVA: 0x6F29D70
        public void .ctor(){} // RVA: 0x6F2A550
    }

    public class TargetPool
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F52DC0
        public void Get(){} // RVA: 0x6F52EB0 | overloaded x2
        public void Reset(){} // RVA: 0xA52E70
    }

    public class TemporalAntialiasing
    {
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

    public class Vector2Parameter
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x6F30290
        public void op_Implicit(){} // RVA: 0x6F30310 | overloaded x2
        public void .ctor(){} // RVA: 0x6F30360
    }

    public class Vector3Parameter
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x6F303B0
        public void op_Implicit(){} // RVA: 0x6F30430 | overloaded x2
        public void .ctor(){} // RVA: 0x6F30490
    }

    public class Vector4Parameter
    {
        // ── Methods ──
        public void Interp(){} // RVA: 0x6F30190
        public void op_Implicit(){} // RVA: 0x6F30510 | overloaded x2
        public void .ctor(){} // RVA: 0x6F30550
    }

    public class VectorscopeMonitor
    {
        // ── Methods ──
        public void OnDisable(){} // RVA: 0x6F2E830
        public void NeedsHalfRes(){} // RVA: 0x3C2850
        public void ShaderResourcesAvailable(){} // RVA: 0x6F2E8F0
        public void Render(){} // RVA: 0x6F2E9F0
        public void .ctor(){} // RVA: 0x6F2F3D0
    }

    public class Vignette
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x6F2C260
        public void .ctor(){} // RVA: 0x6F2C3C0
    }

    public class VignetteModeParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F2C210
    }

    public class VignetteRenderer
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x6F2C9C0
        public void .ctor(){} // RVA: 0x6F2CEC0
    }

    public class WaveformMonitor
    {
        // ── Methods ──
        public void OnDisable(){} // RVA: 0x6F2E830
        public void NeedsHalfRes(){} // RVA: 0x3C2850
        public void ShaderResourcesAvailable(){} // RVA: 0x6F2F3E0
        public void Render(){} // RVA: 0x6F2F4E0
        public void .ctor(){} // RVA: 0x6F30040
    }

}