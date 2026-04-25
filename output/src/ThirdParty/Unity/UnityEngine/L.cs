// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 15
// Methods: 268

namespace ThirdParty.Unity.UnityEngine
{
    public class LOD : ValueType
    {
        public float screenRelativeTransitionHeight; // 0x10
        public float fadeTransitionWidth; // 0x14
        public UnityEngine.Renderer[] renderers; // 0x18
    }

    public class LODGroup : Component
    {
        public object localReferencePoint;
        public object size;
        public object lodCount;
        public object lastLODBillboard;
        public object fadeMode;
        public object animateCrossFading;
        public object enabled;
        public object crossFadeAnimationDuration;
        public object worldReferencePoint;

        // ── Methods ──
        public void get_localReferencePoint(){} // RVA: 0x7FFAC988CAC0
        public void set_localReferencePoint(){} // RVA: 0x7FFAC988CB30
        public void get_size(){} // RVA: 0x7FFAC988CB90
        public void set_size(){} // RVA: 0x7FFAC988CBE0
        public void get_lodCount(){} // RVA: 0x7FFAC988CC40
        public void get_lastLODBillboard(){} // RVA: 0x7FFAC988CC90
        public void set_lastLODBillboard(){} // RVA: 0x7FFAC988CCE0
        public void get_fadeMode(){} // RVA: 0x7FFAC988CD40
        public void set_fadeMode(){} // RVA: 0x7FFAC988CD90
        public void get_animateCrossFading(){} // RVA: 0x7FFAC988CDF0
        public void set_animateCrossFading(){} // RVA: 0x7FFAC988CE40
        public void get_enabled(){} // RVA: 0x7FFAC988CEA0
        public void set_enabled(){} // RVA: 0x7FFAC988CEF0
        public void RecalculateBounds(){} // RVA: 0x7FFAC988CF50
        public void GetLODs(){} // RVA: 0x7FFAC988CFA0
        public void SetLODS(){} // RVA: 0x7FFAC988CFF0
        public void SetLODs(){} // RVA: 0x7FFAC988CFF0
        public void ForceLOD(){} // RVA: 0x7FFAC988D050
        public void get_crossFadeAnimationDuration(){} // RVA: 0x7FFAC988D0B0
        public void set_crossFadeAnimationDuration(){} // RVA: 0x7FFAC988D100
        public void get_worldReferencePoint(){} // RVA: 0x7FFAC988D160
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_localReferencePoint_Injected(){} // RVA: 0x7FFAC988D1D0
        public void set_localReferencePoint_Injected(){} // RVA: 0x7FFAC988D230
        public void get_worldReferencePoint_Injected(){} // RVA: 0x7FFAC988D290
    }

    public class LayerMask : ValueType
    {
        public int value; // 0x10

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFAC51FC020 | overloaded x2
        public void get_value(){} // RVA: 0x7FFAC8F93F90
        public void set_value(){} // RVA: 0x7FFAC336D8B0
        public void LayerToName(){} // RVA: 0x7FFAC98C1EB0
        public void NameToLayer(){} // RVA: 0x7FFAC98C1F00
        public void GetMask(){} // RVA: 0x7FFAC98C1F50
    }

    public class LazyLoadReference`1 : ValueType
    {
        public int m_InstanceID;
    }

    public class LensFlare : Behaviour
    {
        public object brightness;
        public object fadeSpeed;
        public object color;
        public object flare;

        // ── Methods ──
        public void get_brightness(){} // RVA: 0x7FFAC9888A10
        public void set_brightness(){} // RVA: 0x7FFAC9888A60
        public void get_fadeSpeed(){} // RVA: 0x7FFAC9888AC0
        public void set_fadeSpeed(){} // RVA: 0x7FFAC9888B10
        public void get_color(){} // RVA: 0x7FFAC9888B70
        public void set_color(){} // RVA: 0x7FFAC9888BE0
        public void get_flare(){} // RVA: 0x7FFAC9888C40
        public void set_flare(){} // RVA: 0x7FFAC9888C90
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_color_Injected(){} // RVA: 0x7FFAC9888CF0
        public void set_color_Injected(){} // RVA: 0x7FFAC9888D50
    }

    public class Light : Behaviour
    {
        public int type; // 0x18

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFAC9889330
        public void set_type(){} // RVA: 0x7FFAC9889380
        public void get_shape(){} // RVA: 0x7FFAC98893E0
        public void set_shape(){} // RVA: 0x7FFAC9889430
        public void get_spotAngle(){} // RVA: 0x7FFAC9889490
        public void set_spotAngle(){} // RVA: 0x7FFAC98894E0
        public void get_innerSpotAngle(){} // RVA: 0x7FFAC9889540
        public void set_innerSpotAngle(){} // RVA: 0x7FFAC9889590
        public void get_color(){} // RVA: 0x7FFAC98895F0
        public void set_color(){} // RVA: 0x7FFAC9889660
        public void get_colorTemperature(){} // RVA: 0x7FFAC98896C0
        public void set_colorTemperature(){} // RVA: 0x7FFAC9889710
        public void get_useColorTemperature(){} // RVA: 0x7FFAC9889770
        public void set_useColorTemperature(){} // RVA: 0x7FFAC98897C0
        public void get_intensity(){} // RVA: 0x7FFAC9889820
        public void set_intensity(){} // RVA: 0x7FFAC9889870
        public void get_bounceIntensity(){} // RVA: 0x7FFAC98898D0
        public void set_bounceIntensity(){} // RVA: 0x7FFAC9889920
        public void get_useBoundingSphereOverride(){} // RVA: 0x7FFAC9889980
        public void set_useBoundingSphereOverride(){} // RVA: 0x7FFAC98899D0
        public void get_boundingSphereOverride(){} // RVA: 0x7FFAC9889A30
        public void set_boundingSphereOverride(){} // RVA: 0x7FFAC9889AA0
        public void get_useViewFrustumForShadowCasterCull(){} // RVA: 0x7FFAC9889B00
        public void set_useViewFrustumForShadowCasterCull(){} // RVA: 0x7FFAC9889B50
        public void get_shadowCustomResolution(){} // RVA: 0x7FFAC9889BB0
        public void set_shadowCustomResolution(){} // RVA: 0x7FFAC9889C00
        public void get_shadowBias(){} // RVA: 0x7FFAC9889C60
        public void set_shadowBias(){} // RVA: 0x7FFAC9889CB0
        public void get_shadowNormalBias(){} // RVA: 0x7FFAC9889D10
        public void set_shadowNormalBias(){} // RVA: 0x7FFAC9889D60
        public void get_shadowNearPlane(){} // RVA: 0x7FFAC9889DC0
        public void set_shadowNearPlane(){} // RVA: 0x7FFAC9889E10
        public void get_useShadowMatrixOverride(){} // RVA: 0x7FFAC9889E70
        public void set_useShadowMatrixOverride(){} // RVA: 0x7FFAC9889EC0
        public void get_shadowMatrixOverride(){} // RVA: 0x7FFAC9889F20
        public void set_shadowMatrixOverride(){} // RVA: 0x7FFAC9889FA0
        public void get_range(){} // RVA: 0x7FFAC988A000
        public void set_range(){} // RVA: 0x7FFAC988A050
        public void get_flare(){} // RVA: 0x7FFAC988A0B0
        public void set_flare(){} // RVA: 0x7FFAC988A100
        public void get_bakingOutput(){} // RVA: 0x7FFAC988A160
        public void set_bakingOutput(){} // RVA: 0x7FFAC988A1D0
        public void get_cullingMask(){} // RVA: 0x7FFAC988A230
        public void set_cullingMask(){} // RVA: 0x7FFAC988A280
        public void get_renderingLayerMask(){} // RVA: 0x7FFAC988A2E0
        public void set_renderingLayerMask(){} // RVA: 0x7FFAC988A330
        public void get_lightShadowCasterMode(){} // RVA: 0x7FFAC988A390
        public void set_lightShadowCasterMode(){} // RVA: 0x7FFAC988A3E0
        public void Reset(){} // RVA: 0x7FFAC988A440
        public void get_shadows(){} // RVA: 0x7FFAC988A490
        public void set_shadows(){} // RVA: 0x7FFAC988A4E0
        public void get_shadowStrength(){} // RVA: 0x7FFAC988A540
        public void set_shadowStrength(){} // RVA: 0x7FFAC988A590
        public void get_shadowResolution(){} // RVA: 0x7FFAC988A5F0
        public void set_shadowResolution(){} // RVA: 0x7FFAC988A640
        public void get_shadowSoftness(){} // RVA: 0x7FFAC988A6A0
        public void set_shadowSoftness(){} // RVA: 0x7FFAC2F21310
        public void get_shadowSoftnessFade(){} // RVA: 0x7FFAC988A6B0
        public void set_shadowSoftnessFade(){} // RVA: 0x7FFAC2F21310
        public void get_layerShadowCullDistances(){} // RVA: 0x7FFAC988A6C0
        public void set_layerShadowCullDistances(){} // RVA: 0x7FFAC988A710
        public void get_cookieSize(){} // RVA: 0x7FFAC988A770
        public void set_cookieSize(){} // RVA: 0x7FFAC988A7C0
        public void get_cookie(){} // RVA: 0x7FFAC988A820
        public void set_cookie(){} // RVA: 0x7FFAC988A870
        public void get_renderMode(){} // RVA: 0x7FFAC988A8D0
        public void set_renderMode(){} // RVA: 0x7FFAC988A920
        public void get_bakedIndex(){} // RVA: 0x7FFAC669DCA0
        public void set_bakedIndex(){} // RVA: 0x7FFAC392CD10
        public void AddCommandBuffer(){} // RVA: 0x7FFAC988AA00 | overloaded x2
        public void AddCommandBufferAsync(){} // RVA: 0x7FFAC988AB10 | overloaded x2
        public void RemoveCommandBuffer(){} // RVA: 0x7FFAC988AB90
        public void RemoveCommandBuffers(){} // RVA: 0x7FFAC988AC00
        public void RemoveAllCommandBuffers(){} // RVA: 0x7FFAC988AC60
        public void GetCommandBuffers(){} // RVA: 0x7FFAC988ACB0
        public void get_commandBufferCount(){} // RVA: 0x7FFAC988AD10
        public void get_pixelLightCount(){} // RVA: 0x7FFAC98729C0
        public void set_pixelLightCount(){} // RVA: 0x7FFAC9872A10
        public void GetLights(){} // RVA: 0x7FFAC988AD60
        public void get_shadowConstantBias(){} // RVA: 0x7FFAC988ADC0
        public void set_shadowConstantBias(){} // RVA: 0x7FFAC2F21310
        public void get_shadowObjectSizeBias(){} // RVA: 0x7FFAC988ADC0
        public void set_shadowObjectSizeBias(){} // RVA: 0x7FFAC2F21310
        public void get_attenuate(){} // RVA: 0x7FFAC4BF82C0
        public void set_attenuate(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_color_Injected(){} // RVA: 0x7FFAC988ADD0
        public void set_color_Injected(){} // RVA: 0x7FFAC988AE30
        public void get_boundingSphereOverride_Injected(){} // RVA: 0x7FFAC988AE90
        public void set_boundingSphereOverride_Injected(){} // RVA: 0x7FFAC988AEF0
        public void get_shadowMatrixOverride_Injected(){} // RVA: 0x7FFAC988AF50
        public void set_shadowMatrixOverride_Injected(){} // RVA: 0x7FFAC988AFB0
        public void get_bakingOutput_Injected(){} // RVA: 0x7FFAC988B010
        public void set_bakingOutput_Injected(){} // RVA: 0x7FFAC988B070
    }

    public class LightBakingOutput : ValueType
    {
        public int probeOcclusionLightIndex; // 0x10
        public int occlusionMaskChannel; // 0x14
        public 0x6B17BBA8 lightmapBakeType; // 0x18
        public 0x6B17BC00 mixedLightingMode; // 0x1C
        public bool isBaked; // 0x20
    }

    public class LightProbeGroup : Behaviour
    {
        public object probePositions;

        // ── Methods ──
        public void get_probePositions(){} // RVA: 0x7FFAC67332B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class LightProbeProxyVolume : Behaviour
    {
        public object isFeatureSupported;
        public object boundsGlobal;
        public object sizeCustom;
        public object originCustom;
        public object probeDensity;
        public object gridResolutionX;
        public object gridResolutionY;
        public object gridResolutionZ;
        public object boundingBoxMode;
        public object resolutionMode;
        public object probePositionMode;
        public object refreshMode;
        public object qualityMode;
        public object dataFormat;

        // ── Methods ──
        public void get_isFeatureSupported(){} // RVA: 0x7FFAC988B2E0
        public void get_boundsGlobal(){} // RVA: 0x7FFAC988B330
        public void get_sizeCustom(){} // RVA: 0x7FFAC988B3A0
        public void set_sizeCustom(){} // RVA: 0x7FFAC988B410
        public void get_originCustom(){} // RVA: 0x7FFAC988B470
        public void set_originCustom(){} // RVA: 0x7FFAC988B4E0
        public void get_probeDensity(){} // RVA: 0x7FFAC988B540
        public void set_probeDensity(){} // RVA: 0x7FFAC988B590
        public void get_gridResolutionX(){} // RVA: 0x7FFAC988B5F0
        public void set_gridResolutionX(){} // RVA: 0x7FFAC988B640
        public void get_gridResolutionY(){} // RVA: 0x7FFAC988B6A0
        public void set_gridResolutionY(){} // RVA: 0x7FFAC988B6F0
        public void get_gridResolutionZ(){} // RVA: 0x7FFAC988B750
        public void set_gridResolutionZ(){} // RVA: 0x7FFAC988B7A0
        public void get_boundingBoxMode(){} // RVA: 0x7FFAC988B800
        public void set_boundingBoxMode(){} // RVA: 0x7FFAC988B850
        public void get_resolutionMode(){} // RVA: 0x7FFAC988B8B0
        public void set_resolutionMode(){} // RVA: 0x7FFAC988B900
        public void get_probePositionMode(){} // RVA: 0x7FFAC988B960
        public void set_probePositionMode(){} // RVA: 0x7FFAC988B9B0
        public void get_refreshMode(){} // RVA: 0x7FFAC988BA10
        public void set_refreshMode(){} // RVA: 0x7FFAC988BA60
        public void get_qualityMode(){} // RVA: 0x7FFAC988BAC0
        public void set_qualityMode(){} // RVA: 0x7FFAC988BB10
        public void get_dataFormat(){} // RVA: 0x7FFAC988BB70
        public void set_dataFormat(){} // RVA: 0x7FFAC988BBC0
        public void Update(){} // RVA: 0x7FFAC988BC20
        public void SetDirtyFlag(){} // RVA: 0x7FFAC988BC80
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_boundsGlobal_Injected(){} // RVA: 0x7FFAC988BCE0
        public void get_sizeCustom_Injected(){} // RVA: 0x7FFAC988BD40
        public void set_sizeCustom_Injected(){} // RVA: 0x7FFAC988BDA0
        public void get_originCustom_Injected(){} // RVA: 0x7FFAC988BE00
        public void set_originCustom_Injected(){} // RVA: 0x7FFAC988BE60
    }

    public class LightProbes : Object
    {
        public System.Action lightProbesUpdated;
        public System.Action tetrahedralizationCompleted; // 0x8
        public System.Action needsRetetrahedralization; // 0x10

        // ── Methods ──
        public void Internal_CallLightProbesUpdatedFunction(){} // RVA: 0x7FFAC9871A50
        public void Internal_CallTetrahedralizationCompletedFunction(){} // RVA: 0x7FFAC9871AB0
        public void Internal_CallNeedsRetetrahedralizationFunction(){} // RVA: 0x7FFAC9871B10
        public void CalculateInterpolatedLightAndOcclusionProbes(){} // RVA: 0x7FFAC9871B70
        public void CalculateInterpolatedLightAndOcclusionProbes_Internal(){} // RVA: 0x7FFAC9871D70
    }

    public class LightingSettings : Object
    {
        // ── Methods ──
        public void LightingSettingsDontStripMe(){} // RVA: 0x7FFAC2F21310
    }

    public class LightmapSettings : Object
    {
    }

    public class LineRenderer : Renderer
    {
        public object numPositions;
        public object startWidth;
        public object endWidth;
        public object widthMultiplier;
        public object numCornerVertices;
        public object numCapVertices;
        public object useWorldSpace;
        public object loop;
        public object startColor;
        public object endColor;
        public object positionCount;
        public object textureScale;
        public object shadowBias;
        public object generateLightingData;
        public object textureMode;
        public object alignment;
        public object maskInteraction;
        public object widthCurve;
        public object colorGradient;

        // ── Methods ──
        public void SetWidth(){} // RVA: 0x7FFAC9874EB0
        public void SetColors(){} // RVA: 0x7FFAC9874F60
        public void SetVertexCount(){} // RVA: 0x7FFAC9875020
        public void get_numPositions(){} // RVA: 0x7FFAC9875080
        public void set_numPositions(){} // RVA: 0x7FFAC9875020
        public void get_startWidth(){} // RVA: 0x7FFAC98750D0
        public void set_startWidth(){} // RVA: 0x7FFAC9875120
        public void get_endWidth(){} // RVA: 0x7FFAC9875180
        public void set_endWidth(){} // RVA: 0x7FFAC98751D0
        public void get_widthMultiplier(){} // RVA: 0x7FFAC9875230
        public void set_widthMultiplier(){} // RVA: 0x7FFAC9875280
        public void get_numCornerVertices(){} // RVA: 0x7FFAC98752E0
        public void set_numCornerVertices(){} // RVA: 0x7FFAC9875330
        public void get_numCapVertices(){} // RVA: 0x7FFAC9875390
        public void set_numCapVertices(){} // RVA: 0x7FFAC98753E0
        public void get_useWorldSpace(){} // RVA: 0x7FFAC9875440
        public void set_useWorldSpace(){} // RVA: 0x7FFAC9875490
        public void get_loop(){} // RVA: 0x7FFAC98754F0
        public void set_loop(){} // RVA: 0x7FFAC9875540
        public void get_startColor(){} // RVA: 0x7FFAC98755A0
        public void set_startColor(){} // RVA: 0x7FFAC9875610
        public void get_endColor(){} // RVA: 0x7FFAC9875670
        public void set_endColor(){} // RVA: 0x7FFAC98756E0
        public void get_positionCount(){} // RVA: 0x7FFAC9875080
        public void set_positionCount(){} // RVA: 0x7FFAC9875020
        public void SetPosition(){} // RVA: 0x7FFAC9875740
        public void GetPosition(){} // RVA: 0x7FFAC98757B0
        public void get_textureScale(){} // RVA: 0x7FFAC9875830
        public void set_textureScale(){} // RVA: 0x7FFAC9875890
        public void get_shadowBias(){} // RVA: 0x7FFAC98758F0
        public void set_shadowBias(){} // RVA: 0x7FFAC9875940
        public void get_generateLightingData(){} // RVA: 0x7FFAC98759A0
        public void set_generateLightingData(){} // RVA: 0x7FFAC98759F0
        public void get_textureMode(){} // RVA: 0x7FFAC9875A50
        public void set_textureMode(){} // RVA: 0x7FFAC9875AA0
        public void get_alignment(){} // RVA: 0x7FFAC9875B00
        public void set_alignment(){} // RVA: 0x7FFAC9875B50
        public void get_maskInteraction(){} // RVA: 0x7FFAC9875BB0
        public void set_maskInteraction(){} // RVA: 0x7FFAC9875C00
        public void Simplify(){} // RVA: 0x7FFAC9875C60
        public void BakeMesh(){} // RVA: 0x7FFAC9875D50 | overloaded x2
        public void get_widthCurve(){} // RVA: 0x7FFAC9875DD0
        public void set_widthCurve(){} // RVA: 0x7FFAC9875E20
        public void get_colorGradient(){} // RVA: 0x7FFAC9875E80
        public void set_colorGradient(){} // RVA: 0x7FFAC9875ED0
        public void GetWidthCurveCopy(){} // RVA: 0x7FFAC9875DD0
        public void SetWidthCurve(){} // RVA: 0x7FFAC9875E20
        public void GetColorGradientCopy(){} // RVA: 0x7FFAC9875E80
        public void SetColorGradient(){} // RVA: 0x7FFAC9875ED0
        public void GetPositions(){} // RVA: 0x7FFAC98760F0 | overloaded x3
        public void SetPositions(){} // RVA: 0x7FFAC9876040 | overloaded x3
        public void SetPositionsWithNativeContainer(){} // RVA: 0x7FFAC9876150
        public void GetPositionsWithNativeContainer(){} // RVA: 0x7FFAC98761C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_startColor_Injected(){} // RVA: 0x7FFAC9876230
        public void set_startColor_Injected(){} // RVA: 0x7FFAC9876290
        public void get_endColor_Injected(){} // RVA: 0x7FFAC98762F0
        public void set_endColor_Injected(){} // RVA: 0x7FFAC9876350
        public void SetPosition_Injected(){} // RVA: 0x7FFAC98763B0
        public void GetPosition_Injected(){} // RVA: 0x7FFAC9876420
        public void get_textureScale_Injected(){} // RVA: 0x7FFAC9876490
        public void set_textureScale_Injected(){} // RVA: 0x7FFAC98764F0
    }

    public class Logger : Object
    {
        public UnityEngine.ILogHandler logHandler; // 0x10
        public bool logEnabled; // 0x18
        public 0x6B179630 filterLogType; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98A74D0
        public void get_logHandler(){} // RVA: 0x7FFAC2F3C380
        public void set_logHandler(){} // RVA: 0x7FFAC2F22E30
        public void get_logEnabled(){} // RVA: 0x7FFAC2F3C4E0
        public void set_logEnabled(){} // RVA: 0x7FFAC2F3C4F0
        public void get_filterLogType(){} // RVA: 0x7FFAC44357F0
        public void set_filterLogType(){} // RVA: 0x7FFAC44474D0
        public void IsLogTypeAllowed(){} // RVA: 0x7FFAC98A7540
        public void GetString(){} // RVA: 0x7FFAC98A7560
        public void Log(){} // RVA: 0x7FFAC98A7A30 | overloaded x4
        public void LogWarning(){} // RVA: 0x7FFAC98A7BA0
        public void LogError(){} // RVA: 0x7FFAC98A7D10
        public void LogException(){} // RVA: 0x7FFAC98A7EF0 | overloaded x2
        public void LogFormat(){} // RVA: 0x7FFAC98A8000 | overloaded x2
    }

    public class LowerResBlitTexture : Object
    {
        // ── Methods ──
        public void LowerResBlitTextureDontStripMe(){} // RVA: 0x7FFAC2F21310
    }

}