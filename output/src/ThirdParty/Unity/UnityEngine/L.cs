// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 16
// Methods: 278

namespace ThirdParty.Unity.UnityEngine
{
    public class LOD
    {
    }

    public class LODGroup
    {
        public object center;
        public object size;

        // ── Methods ──
        public void get_localReferencePoint(){} // RVA: 0x70F4770
        public void set_localReferencePoint(){} // RVA: 0x70F47E0
        public void get_size(){} // RVA: 0x70F4840
        public void set_size(){} // RVA: 0x70F4890
        public void get_lodCount(){} // RVA: 0x70F48F0
        public void get_lastLODBillboard(){} // RVA: 0x70F4940
        public void set_lastLODBillboard(){} // RVA: 0x70F4990
        public void get_fadeMode(){} // RVA: 0x70F49F0
        public void set_fadeMode(){} // RVA: 0x70F4A40
        public void get_animateCrossFading(){} // RVA: 0x70F4AA0
        public void set_animateCrossFading(){} // RVA: 0x70F4AF0
        public void get_enabled(){} // RVA: 0x70F4B50
        public void set_enabled(){} // RVA: 0x70F4BA0
        public void RecalculateBounds(){} // RVA: 0x70F4C00
        public void GetLODs(){} // RVA: 0x70F4C50
        public void SetLODS(){} // RVA: 0x70F4CA0
        public void SetLODs(){} // RVA: 0x70F4CA0
        public void ForceLOD(){} // RVA: 0x70F4D00
        public void get_crossFadeAnimationDuration(){} // RVA: 0x70F4D60
        public void set_crossFadeAnimationDuration(){} // RVA: 0x70F4DB0
        public void get_worldReferencePoint(){} // RVA: 0x70F4E10
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_localReferencePoint_Injected(){} // RVA: 0x70F4E80
        public void set_localReferencePoint_Injected(){} // RVA: 0x70F4EE0
        public void get_worldReferencePoint_Injected(){} // RVA: 0x70F4F40
    }

    public class LayerMask
    {
        public int m_Mask; // 0x10

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x275CDE0 | overloaded x2
        public void get_value(){} // RVA: 0x67FD0D0
        public void set_value(){} // RVA: 0x833580
        public void LayerToName(){} // RVA: 0x7129920
        public void NameToLayer(){} // RVA: 0x7129970
        public void GetMask(){} // RVA: 0x71299C0
    }

    public class LazyLoadReference`1
    {
    }

    public class LensFlare
    {
        public object type;
        public object shape;
        public object spotAngle;
        public object innerSpotAngle;

        // ── Methods ──
        public void get_brightness(){} // RVA: 0x70F06C0
        public void set_brightness(){} // RVA: 0x70F0710
        public void get_fadeSpeed(){} // RVA: 0x70F0770
        public void set_fadeSpeed(){} // RVA: 0x70F07C0
        public void get_color(){} // RVA: 0x70F0820
        public void set_color(){} // RVA: 0x70F0890
        public void get_flare(){} // RVA: 0x70F08F0
        public void set_flare(){} // RVA: 0x70F0940
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_color_Injected(){} // RVA: 0x70F09A0
        public void set_color_Injected(){} // RVA: 0x70F0A00
    }

    public class Light
    {
        public int probePositions; // 0x18

        // ── Methods ──
        public void get_type(){} // RVA: 0x70F0FE0
        public void set_type(){} // RVA: 0x70F1030
        public void get_shape(){} // RVA: 0x70F1090
        public void set_shape(){} // RVA: 0x70F10E0
        public void get_spotAngle(){} // RVA: 0x70F1140
        public void set_spotAngle(){} // RVA: 0x70F1190
        public void get_innerSpotAngle(){} // RVA: 0x70F11F0
        public void set_innerSpotAngle(){} // RVA: 0x70F1240
        public void get_color(){} // RVA: 0x70F12A0
        public void set_color(){} // RVA: 0x70F1310
        public void get_colorTemperature(){} // RVA: 0x70F1370
        public void set_colorTemperature(){} // RVA: 0x70F13C0
        public void get_useColorTemperature(){} // RVA: 0x70F1420
        public void set_useColorTemperature(){} // RVA: 0x70F1470
        public void get_intensity(){} // RVA: 0x70F14D0
        public void set_intensity(){} // RVA: 0x70F1520
        public void get_bounceIntensity(){} // RVA: 0x70F1580
        public void set_bounceIntensity(){} // RVA: 0x70F15D0
        public void get_useBoundingSphereOverride(){} // RVA: 0x70F1630
        public void set_useBoundingSphereOverride(){} // RVA: 0x70F1680
        public void get_boundingSphereOverride(){} // RVA: 0x70F16E0
        public void set_boundingSphereOverride(){} // RVA: 0x70F1750
        public void get_useViewFrustumForShadowCasterCull(){} // RVA: 0x70F17B0
        public void set_useViewFrustumForShadowCasterCull(){} // RVA: 0x70F1800
        public void get_shadowCustomResolution(){} // RVA: 0x70F1860
        public void set_shadowCustomResolution(){} // RVA: 0x70F18B0
        public void get_shadowBias(){} // RVA: 0x70F1910
        public void set_shadowBias(){} // RVA: 0x70F1960
        public void get_shadowNormalBias(){} // RVA: 0x70F19C0
        public void set_shadowNormalBias(){} // RVA: 0x70F1A10
        public void get_shadowNearPlane(){} // RVA: 0x70F1A70
        public void set_shadowNearPlane(){} // RVA: 0x70F1AC0
        public void get_useShadowMatrixOverride(){} // RVA: 0x70F1B20
        public void set_useShadowMatrixOverride(){} // RVA: 0x70F1B70
        public void get_shadowMatrixOverride(){} // RVA: 0x70F1BD0
        public void set_shadowMatrixOverride(){} // RVA: 0x70F1C50
        public void get_range(){} // RVA: 0x70F1CB0
        public void set_range(){} // RVA: 0x70F1D00
        public void get_flare(){} // RVA: 0x70F1D60
        public void set_flare(){} // RVA: 0x70F1DB0
        public void get_bakingOutput(){} // RVA: 0x70F1E10
        public void set_bakingOutput(){} // RVA: 0x70F1E80
        public void get_cullingMask(){} // RVA: 0x70F1EE0
        public void set_cullingMask(){} // RVA: 0x70F1F30
        public void get_renderingLayerMask(){} // RVA: 0x70F1F90
        public void set_renderingLayerMask(){} // RVA: 0x70F1FE0
        public void get_lightShadowCasterMode(){} // RVA: 0x70F2040
        public void set_lightShadowCasterMode(){} // RVA: 0x70F2090
        public void Reset(){} // RVA: 0x70F20F0
        public void get_shadows(){} // RVA: 0x70F2140
        public void set_shadows(){} // RVA: 0x70F2190
        public void get_shadowStrength(){} // RVA: 0x70F21F0
        public void set_shadowStrength(){} // RVA: 0x70F2240
        public void get_shadowResolution(){} // RVA: 0x70F22A0
        public void set_shadowResolution(){} // RVA: 0x70F22F0
        public void get_shadowSoftness(){} // RVA: 0x70F2350
        public void set_shadowSoftness(){} // RVA: 0x2DD310
        public void get_shadowSoftnessFade(){} // RVA: 0x70F2360
        public void set_shadowSoftnessFade(){} // RVA: 0x2DD310
        public void get_layerShadowCullDistances(){} // RVA: 0x70F2370
        public void set_layerShadowCullDistances(){} // RVA: 0x70F23C0
        public void get_cookieSize(){} // RVA: 0x70F2420
        public void set_cookieSize(){} // RVA: 0x70F2470
        public void get_cookie(){} // RVA: 0x70F24D0
        public void set_cookie(){} // RVA: 0x70F2520
        public void get_renderMode(){} // RVA: 0x70F2580
        public void set_renderMode(){} // RVA: 0x70F25D0
        public void get_bakedIndex(){} // RVA: 0x3D92310
        public void set_bakedIndex(){} // RVA: 0x6374E0
        public void AddCommandBuffer(){} // RVA: 0x70F26B0 | overloaded x2
        public void AddCommandBufferAsync(){} // RVA: 0x70F27C0 | overloaded x2
        public void RemoveCommandBuffer(){} // RVA: 0x70F2840
        public void RemoveCommandBuffers(){} // RVA: 0x70F28B0
        public void RemoveAllCommandBuffers(){} // RVA: 0x70F2910
        public void GetCommandBuffers(){} // RVA: 0x70F2960
        public void get_commandBufferCount(){} // RVA: 0x70F29C0
        public void get_pixelLightCount(){} // RVA: 0x70DA370
        public void set_pixelLightCount(){} // RVA: 0x70DA3C0
        public void GetLights(){} // RVA: 0x70F2A10
        public void get_shadowConstantBias(){} // RVA: 0x70F2A70
        public void set_shadowConstantBias(){} // RVA: 0x2DD310
        public void get_shadowObjectSizeBias(){} // RVA: 0x70F2A70
        public void set_shadowObjectSizeBias(){} // RVA: 0x2DD310
        public void get_attenuate(){} // RVA: 0x20D68C0
        public void set_attenuate(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_color_Injected(){} // RVA: 0x70F2A80
        public void set_color_Injected(){} // RVA: 0x70F2AE0
        public void get_boundingSphereOverride_Injected(){} // RVA: 0x70F2B40
        public void set_boundingSphereOverride_Injected(){} // RVA: 0x70F2BA0
        public void get_shadowMatrixOverride_Injected(){} // RVA: 0x70F2C00
        public void set_shadowMatrixOverride_Injected(){} // RVA: 0x70F2C60
        public void get_bakingOutput_Injected(){} // RVA: 0x70F2CC0
        public void set_bakingOutput_Injected(){} // RVA: 0x70F2D20
    }

    public class LightBakingOutput
    {
    }

    public class LightProbeGroup
    {
        public object isFeatureSupported;

        // ── Methods ──
        public void get_probePositions(){} // RVA: 0x3E0F620
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class LightProbeProxyVolume
    {
        public object destination;
        public object stoppingDistance;
        public object velocity;
        public object nextPosition;
        public object steeringTarget;
        public object desiredVelocity;
        public object remainingDistance;
        public object baseOffset;
        public object isOnOffMeshLink;
        public object currentOffMeshLinkData;
        public object nextOffMeshLinkData;
        public object autoTraverseOffMeshLink;
        public object autoBraking;
        public object autoRepath;

        // ── Methods ──
        public void get_isFeatureSupported(){} // RVA: 0x70F2F90
        public void get_boundsGlobal(){} // RVA: 0x70F2FE0
        public void get_sizeCustom(){} // RVA: 0x70F3050
        public void set_sizeCustom(){} // RVA: 0x70F30C0
        public void get_originCustom(){} // RVA: 0x70F3120
        public void set_originCustom(){} // RVA: 0x70F3190
        public void get_probeDensity(){} // RVA: 0x70F31F0
        public void set_probeDensity(){} // RVA: 0x70F3240
        public void get_gridResolutionX(){} // RVA: 0x70F32A0
        public void set_gridResolutionX(){} // RVA: 0x70F32F0
        public void get_gridResolutionY(){} // RVA: 0x70F3350
        public void set_gridResolutionY(){} // RVA: 0x70F33A0
        public void get_gridResolutionZ(){} // RVA: 0x70F3400
        public void set_gridResolutionZ(){} // RVA: 0x70F3450
        public void get_boundingBoxMode(){} // RVA: 0x70F34B0
        public void set_boundingBoxMode(){} // RVA: 0x70F3500
        public void get_resolutionMode(){} // RVA: 0x70F3560
        public void set_resolutionMode(){} // RVA: 0x70F35B0
        public void get_probePositionMode(){} // RVA: 0x70F3610
        public void set_probePositionMode(){} // RVA: 0x70F3660
        public void get_refreshMode(){} // RVA: 0x70F36C0
        public void set_refreshMode(){} // RVA: 0x70F3710
        public void get_qualityMode(){} // RVA: 0x70F3770
        public void set_qualityMode(){} // RVA: 0x70F37C0
        public void get_dataFormat(){} // RVA: 0x70F3820
        public void set_dataFormat(){} // RVA: 0x70F3870
        public void Update(){} // RVA: 0x70F38D0
        public void SetDirtyFlag(){} // RVA: 0x70F3930
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_boundsGlobal_Injected(){} // RVA: 0x70F3990
        public void get_sizeCustom_Injected(){} // RVA: 0x70F39F0
        public void set_sizeCustom_Injected(){} // RVA: 0x70F3A50
        public void get_originCustom_Injected(){} // RVA: 0x70F3AB0
        public void set_originCustom_Injected(){} // RVA: 0x70F3B10
    }

    public class LightProbes
    {
        // ── Methods ──
        public void Internal_CallLightProbesUpdatedFunction(){} // RVA: 0x70D9400
        public void Internal_CallTetrahedralizationCompletedFunction(){} // RVA: 0x70D9460
        public void Internal_CallNeedsRetetrahedralizationFunction(){} // RVA: 0x70D94C0
        public void CalculateInterpolatedLightAndOcclusionProbes(){} // RVA: 0x70D9520
        public void CalculateInterpolatedLightAndOcclusionProbes_Internal(){} // RVA: 0x70D9720
    }

    public class LightingSettings
    {
        // ── Methods ──
        public void LightingSettingsDontStripMe(){} // RVA: 0x2DD310
    }

    public class LightmapData
    {
        public UnityEngine.Texture2D m_Light; // 0x10
        public UnityEngine.Texture2D m_Dir; // 0x18
        public UnityEngine.Texture2D m_ShadowMask; // 0x20

        // ── Methods ──
        public void get_lightmapColor(){} // RVA: 0x33B6D40
        public void set_lightmapColor(){} // RVA: 0x2DEE30
        public void get_lightmapDir(){} // RVA: 0x2F0F420
        public void set_lightmapDir(){} // RVA: 0x343E80
        public void get_shadowMask(){} // RVA: 0x6A24380
        public void set_shadowMask(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LightmapSettings
    {
        public object fog;
        public object fogStartDistance;

        // ── Methods ──
        public void get_lightmaps(){} // RVA: 0x70D9310
        public void set_lightmaps(){} // RVA: 0x70D9360
        public void set_lightmapsMode(){} // RVA: 0x70D93B0
    }

    public class LineRenderer
    {
        public object frontSortingLayerID;
        public object frontSortingOrder;
        public object backSortingLayerID;
        public object backSortingOrder;
        public object alphaCutoff;
        public object sprite;
        public object isCustomRangeActive;
        public object spriteSortPoint;
        public object `;
        public object Dispose;

        // ── Methods ──
        public void SetWidth(){} // RVA: 0x70DC860
        public void SetColors(){} // RVA: 0x70DC910
        public void SetVertexCount(){} // RVA: 0x70DC9D0
        public void get_numPositions(){} // RVA: 0x70DCA30
        public void set_numPositions(){} // RVA: 0x70DC9D0
        public void get_startWidth(){} // RVA: 0x70DCA80
        public void set_startWidth(){} // RVA: 0x70DCAD0
        public void get_endWidth(){} // RVA: 0x70DCB30
        public void set_endWidth(){} // RVA: 0x70DCB80
        public void get_widthMultiplier(){} // RVA: 0x70DCBE0
        public void set_widthMultiplier(){} // RVA: 0x70DCC30
        public void get_numCornerVertices(){} // RVA: 0x70DCC90
        public void set_numCornerVertices(){} // RVA: 0x70DCCE0
        public void get_numCapVertices(){} // RVA: 0x70DCD40
        public void set_numCapVertices(){} // RVA: 0x70DCD90
        public void get_useWorldSpace(){} // RVA: 0x70DCDF0
        public void set_useWorldSpace(){} // RVA: 0x70DCE40
        public void get_loop(){} // RVA: 0x70DCEA0
        public void set_loop(){} // RVA: 0x70DCEF0
        public void get_startColor(){} // RVA: 0x70DCF50
        public void set_startColor(){} // RVA: 0x70DCFC0
        public void get_endColor(){} // RVA: 0x70DD020
        public void set_endColor(){} // RVA: 0x70DD090
        public void get_positionCount(){} // RVA: 0x70DCA30
        public void set_positionCount(){} // RVA: 0x70DC9D0
        public void SetPosition(){} // RVA: 0x70DD0F0
        public void GetPosition(){} // RVA: 0x70DD160
        public void get_textureScale(){} // RVA: 0x70DD1E0
        public void set_textureScale(){} // RVA: 0x70DD240
        public void get_shadowBias(){} // RVA: 0x70DD2A0
        public void set_shadowBias(){} // RVA: 0x70DD2F0
        public void get_generateLightingData(){} // RVA: 0x70DD350
        public void set_generateLightingData(){} // RVA: 0x70DD3A0
        public void get_textureMode(){} // RVA: 0x70DD400
        public void set_textureMode(){} // RVA: 0x70DD450
        public void get_alignment(){} // RVA: 0x70DD4B0
        public void set_alignment(){} // RVA: 0x70DD500
        public void get_maskInteraction(){} // RVA: 0x70DD560
        public void set_maskInteraction(){} // RVA: 0x70DD5B0
        public void Simplify(){} // RVA: 0x70DD610
        public void BakeMesh(){} // RVA: 0x70DD700 | overloaded x2
        public void get_widthCurve(){} // RVA: 0x70DD780
        public void set_widthCurve(){} // RVA: 0x70DD7D0
        public void get_colorGradient(){} // RVA: 0x70DD830
        public void set_colorGradient(){} // RVA: 0x70DD880
        public void GetWidthCurveCopy(){} // RVA: 0x70DD780
        public void SetWidthCurve(){} // RVA: 0x70DD7D0
        public void GetColorGradientCopy(){} // RVA: 0x70DD830
        public void SetColorGradient(){} // RVA: 0x70DD880
        public void GetPositions(){} // RVA: 0x70DDAA0 | overloaded x3
        public void SetPositions(){} // RVA: 0x70DD9F0 | overloaded x3
        public void SetPositionsWithNativeContainer(){} // RVA: 0x70DDB00
        public void GetPositionsWithNativeContainer(){} // RVA: 0x70DDB70
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_startColor_Injected(){} // RVA: 0x70DDBE0
        public void set_startColor_Injected(){} // RVA: 0x70DDC40
        public void get_endColor_Injected(){} // RVA: 0x70DDCA0
        public void set_endColor_Injected(){} // RVA: 0x70DDD00
        public void SetPosition_Injected(){} // RVA: 0x70DDD60
        public void GetPosition_Injected(){} // RVA: 0x70DDDD0
        public void get_textureScale_Injected(){} // RVA: 0x70DDE40
        public void set_textureScale_Injected(){} // RVA: 0x70DDEA0
    }

    public class Logger
    {
        public UnityEngine.ILogHandler <logHandler>k__BackingField; // 0x10
        public bool <logEnabled>k__BackingField; // 0x18
        public 0x65895580 <filterLogType>k__BackingField; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x710F110
        public void get_logHandler(){} // RVA: 0x2F8380
        public void set_logHandler(){} // RVA: 0x2DEE30
        public void get_logEnabled(){} // RVA: 0x2F84E0
        public void set_logEnabled(){} // RVA: 0x2F84F0
        public void get_filterLogType(){} // RVA: 0x197C3B0
        public void set_filterLogType(){} // RVA: 0x1989FD0
        public void IsLogTypeAllowed(){} // RVA: 0x710F180
        public void GetString(){} // RVA: 0x710F1A0
        public void Log(){} // RVA: 0x710F670 | overloaded x4
        public void LogWarning(){} // RVA: 0x710F7E0
        public void LogError(){} // RVA: 0x710F950
        public void LogException(){} // RVA: 0x710FB30 | overloaded x2
        public void LogFormat(){} // RVA: 0x710FC40 | overloaded x2
    }

    public class LowerResBlitTexture
    {
        // ── Methods ──
        public void LowerResBlitTextureDontStripMe(){} // RVA: 0x2DD310
    }

}