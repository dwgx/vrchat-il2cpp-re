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
        public void get_localReferencePoint(){} // RVA: 0x7FFAF9BA4770
        public void set_localReferencePoint(){} // RVA: 0x7FFAF9BA47E0
        public void get_size(){} // RVA: 0x7FFAF9BA4840
        public void set_size(){} // RVA: 0x7FFAF9BA4890
        public void get_lodCount(){} // RVA: 0x7FFAF9BA48F0
        public void get_lastLODBillboard(){} // RVA: 0x7FFAF9BA4940
        public void set_lastLODBillboard(){} // RVA: 0x7FFAF9BA4990
        public void get_fadeMode(){} // RVA: 0x7FFAF9BA49F0
        public void set_fadeMode(){} // RVA: 0x7FFAF9BA4A40
        public void get_animateCrossFading(){} // RVA: 0x7FFAF9BA4AA0
        public void set_animateCrossFading(){} // RVA: 0x7FFAF9BA4AF0
        public void get_enabled(){} // RVA: 0x7FFAF9BA4B50
        public void set_enabled(){} // RVA: 0x7FFAF9BA4BA0
        public void RecalculateBounds(){} // RVA: 0x7FFAF9BA4C00
        public void GetLODs(){} // RVA: 0x7FFAF9BA4C50
        public void SetLODS(){} // RVA: 0x7FFAF9BA4CA0
        public void SetLODs(){} // RVA: 0x7FFAF9BA4CA0
        public void ForceLOD(){} // RVA: 0x7FFAF9BA4D00
        public void get_crossFadeAnimationDuration(){} // RVA: 0x7FFAF9BA4D60
        public void set_crossFadeAnimationDuration(){} // RVA: 0x7FFAF9BA4DB0
        public void get_worldReferencePoint(){} // RVA: 0x7FFAF9BA4E10
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_localReferencePoint_Injected(){} // RVA: 0x7FFAF9BA4E80
        public void set_localReferencePoint_Injected(){} // RVA: 0x7FFAF9BA4EE0
        public void get_worldReferencePoint_Injected(){} // RVA: 0x7FFAF9BA4F40
    }

    public class LayerMask
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFAF520CDE0 | overloaded x2
        public void get_value(){} // RVA: 0x7FFAF92AD0D0
        public void set_value(){} // RVA: 0x7FFAF32E3580
        public void LayerToName(){} // RVA: 0x7FFAF9BD9920
        public void NameToLayer(){} // RVA: 0x7FFAF9BD9970
        public void GetMask(){} // RVA: 0x7FFAF9BD99C0
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
        public void get_brightness(){} // RVA: 0x7FFAF9BA06C0
        public void set_brightness(){} // RVA: 0x7FFAF9BA0710
        public void get_fadeSpeed(){} // RVA: 0x7FFAF9BA0770
        public void set_fadeSpeed(){} // RVA: 0x7FFAF9BA07C0
        public void get_color(){} // RVA: 0x7FFAF9BA0820
        public void set_color(){} // RVA: 0x7FFAF9BA0890
        public void get_flare(){} // RVA: 0x7FFAF9BA08F0
        public void set_flare(){} // RVA: 0x7FFAF9BA0940
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_color_Injected(){} // RVA: 0x7FFAF9BA09A0
        public void set_color_Injected(){} // RVA: 0x7FFAF9BA0A00
    }

    public class Light
    {
        public object probePositions;
        public object get_lastLODBillboard;
        public object get_enabled;

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFAF9BA0FE0
        public void set_type(){} // RVA: 0x7FFAF9BA1030
        public void get_shape(){} // RVA: 0x7FFAF9BA1090
        public void set_shape(){} // RVA: 0x7FFAF9BA10E0
        public void get_spotAngle(){} // RVA: 0x7FFAF9BA1140
        public void set_spotAngle(){} // RVA: 0x7FFAF9BA1190
        public void get_innerSpotAngle(){} // RVA: 0x7FFAF9BA11F0
        public void set_innerSpotAngle(){} // RVA: 0x7FFAF9BA1240
        public void get_color(){} // RVA: 0x7FFAF9BA12A0
        public void set_color(){} // RVA: 0x7FFAF9BA1310
        public void get_colorTemperature(){} // RVA: 0x7FFAF9BA1370
        public void set_colorTemperature(){} // RVA: 0x7FFAF9BA13C0
        public void get_useColorTemperature(){} // RVA: 0x7FFAF9BA1420
        public void set_useColorTemperature(){} // RVA: 0x7FFAF9BA1470
        public void get_intensity(){} // RVA: 0x7FFAF9BA14D0
        public void set_intensity(){} // RVA: 0x7FFAF9BA1520
        public void get_bounceIntensity(){} // RVA: 0x7FFAF9BA1580
        public void set_bounceIntensity(){} // RVA: 0x7FFAF9BA15D0
        public void get_useBoundingSphereOverride(){} // RVA: 0x7FFAF9BA1630
        public void set_useBoundingSphereOverride(){} // RVA: 0x7FFAF9BA1680
        public void get_boundingSphereOverride(){} // RVA: 0x7FFAF9BA16E0
        public void set_boundingSphereOverride(){} // RVA: 0x7FFAF9BA1750
        public void get_useViewFrustumForShadowCasterCull(){} // RVA: 0x7FFAF9BA17B0
        public void set_useViewFrustumForShadowCasterCull(){} // RVA: 0x7FFAF9BA1800
        public void get_shadowCustomResolution(){} // RVA: 0x7FFAF9BA1860
        public void set_shadowCustomResolution(){} // RVA: 0x7FFAF9BA18B0
        public void get_shadowBias(){} // RVA: 0x7FFAF9BA1910
        public void set_shadowBias(){} // RVA: 0x7FFAF9BA1960
        public void get_shadowNormalBias(){} // RVA: 0x7FFAF9BA19C0
        public void set_shadowNormalBias(){} // RVA: 0x7FFAF9BA1A10
        public void get_shadowNearPlane(){} // RVA: 0x7FFAF9BA1A70
        public void set_shadowNearPlane(){} // RVA: 0x7FFAF9BA1AC0
        public void get_useShadowMatrixOverride(){} // RVA: 0x7FFAF9BA1B20
        public void set_useShadowMatrixOverride(){} // RVA: 0x7FFAF9BA1B70
        public void get_shadowMatrixOverride(){} // RVA: 0x7FFAF9BA1BD0
        public void set_shadowMatrixOverride(){} // RVA: 0x7FFAF9BA1C50
        public void get_range(){} // RVA: 0x7FFAF9BA1CB0
        public void set_range(){} // RVA: 0x7FFAF9BA1D00
        public void get_flare(){} // RVA: 0x7FFAF9BA1D60
        public void set_flare(){} // RVA: 0x7FFAF9BA1DB0
        public void get_bakingOutput(){} // RVA: 0x7FFAF9BA1E10
        public void set_bakingOutput(){} // RVA: 0x7FFAF9BA1E80
        public void get_cullingMask(){} // RVA: 0x7FFAF9BA1EE0
        public void set_cullingMask(){} // RVA: 0x7FFAF9BA1F30
        public void get_renderingLayerMask(){} // RVA: 0x7FFAF9BA1F90
        public void set_renderingLayerMask(){} // RVA: 0x7FFAF9BA1FE0
        public void get_lightShadowCasterMode(){} // RVA: 0x7FFAF9BA2040
        public void set_lightShadowCasterMode(){} // RVA: 0x7FFAF9BA2090
        public void Reset(){} // RVA: 0x7FFAF9BA20F0
        public void get_shadows(){} // RVA: 0x7FFAF9BA2140
        public void set_shadows(){} // RVA: 0x7FFAF9BA2190
        public void get_shadowStrength(){} // RVA: 0x7FFAF9BA21F0
        public void set_shadowStrength(){} // RVA: 0x7FFAF9BA2240
        public void get_shadowResolution(){} // RVA: 0x7FFAF9BA22A0
        public void set_shadowResolution(){} // RVA: 0x7FFAF9BA22F0
        public void get_shadowSoftness(){} // RVA: 0x7FFAF9BA2350
        public void set_shadowSoftness(){} // RVA: 0x7FFAF2D8D310
        public void get_shadowSoftnessFade(){} // RVA: 0x7FFAF9BA2360
        public void set_shadowSoftnessFade(){} // RVA: 0x7FFAF2D8D310
        public void get_layerShadowCullDistances(){} // RVA: 0x7FFAF9BA2370
        public void set_layerShadowCullDistances(){} // RVA: 0x7FFAF9BA23C0
        public void get_cookieSize(){} // RVA: 0x7FFAF9BA2420
        public void set_cookieSize(){} // RVA: 0x7FFAF9BA2470
        public void get_cookie(){} // RVA: 0x7FFAF9BA24D0
        public void set_cookie(){} // RVA: 0x7FFAF9BA2520
        public void get_renderMode(){} // RVA: 0x7FFAF9BA2580
        public void set_renderMode(){} // RVA: 0x7FFAF9BA25D0
        public void get_bakedIndex(){} // RVA: 0x7FFAF6842310
        public void set_bakedIndex(){} // RVA: 0x7FFAF30E74E0
        public void AddCommandBuffer(){} // RVA: 0x7FFAF9BA26B0 | overloaded x2
        public void AddCommandBufferAsync(){} // RVA: 0x7FFAF9BA27C0 | overloaded x2
        public void RemoveCommandBuffer(){} // RVA: 0x7FFAF9BA2840
        public void RemoveCommandBuffers(){} // RVA: 0x7FFAF9BA28B0
        public void RemoveAllCommandBuffers(){} // RVA: 0x7FFAF9BA2910
        public void GetCommandBuffers(){} // RVA: 0x7FFAF9BA2960
        public void get_commandBufferCount(){} // RVA: 0x7FFAF9BA29C0
        public void get_pixelLightCount(){} // RVA: 0x7FFAF9B8A370
        public void set_pixelLightCount(){} // RVA: 0x7FFAF9B8A3C0
        public void GetLights(){} // RVA: 0x7FFAF9BA2A10
        public void get_shadowConstantBias(){} // RVA: 0x7FFAF9BA2A70
        public void set_shadowConstantBias(){} // RVA: 0x7FFAF2D8D310
        public void get_shadowObjectSizeBias(){} // RVA: 0x7FFAF9BA2A70
        public void set_shadowObjectSizeBias(){} // RVA: 0x7FFAF2D8D310
        public void get_attenuate(){} // RVA: 0x7FFAF4B868C0
        public void set_attenuate(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_color_Injected(){} // RVA: 0x7FFAF9BA2A80
        public void set_color_Injected(){} // RVA: 0x7FFAF9BA2AE0
        public void get_boundingSphereOverride_Injected(){} // RVA: 0x7FFAF9BA2B40
        public void set_boundingSphereOverride_Injected(){} // RVA: 0x7FFAF9BA2BA0
        public void get_shadowMatrixOverride_Injected(){} // RVA: 0x7FFAF9BA2C00
        public void set_shadowMatrixOverride_Injected(){} // RVA: 0x7FFAF9BA2C60
        public void get_bakingOutput_Injected(){} // RVA: 0x7FFAF9BA2CC0
        public void set_bakingOutput_Injected(){} // RVA: 0x7FFAF9BA2D20
    }

    public class LightBakingOutput
    {
    }

    public class LightProbeGroup
    {
        public object isFeatureSupported;

        // ── Methods ──
        public void get_probePositions(){} // RVA: 0x7FFAF68BF620
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
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
        public void get_isFeatureSupported(){} // RVA: 0x7FFAF9BA2F90
        public void get_boundsGlobal(){} // RVA: 0x7FFAF9BA2FE0
        public void get_sizeCustom(){} // RVA: 0x7FFAF9BA3050
        public void set_sizeCustom(){} // RVA: 0x7FFAF9BA30C0
        public void get_originCustom(){} // RVA: 0x7FFAF9BA3120
        public void set_originCustom(){} // RVA: 0x7FFAF9BA3190
        public void get_probeDensity(){} // RVA: 0x7FFAF9BA31F0
        public void set_probeDensity(){} // RVA: 0x7FFAF9BA3240
        public void get_gridResolutionX(){} // RVA: 0x7FFAF9BA32A0
        public void set_gridResolutionX(){} // RVA: 0x7FFAF9BA32F0
        public void get_gridResolutionY(){} // RVA: 0x7FFAF9BA3350
        public void set_gridResolutionY(){} // RVA: 0x7FFAF9BA33A0
        public void get_gridResolutionZ(){} // RVA: 0x7FFAF9BA3400
        public void set_gridResolutionZ(){} // RVA: 0x7FFAF9BA3450
        public void get_boundingBoxMode(){} // RVA: 0x7FFAF9BA34B0
        public void set_boundingBoxMode(){} // RVA: 0x7FFAF9BA3500
        public void get_resolutionMode(){} // RVA: 0x7FFAF9BA3560
        public void set_resolutionMode(){} // RVA: 0x7FFAF9BA35B0
        public void get_probePositionMode(){} // RVA: 0x7FFAF9BA3610
        public void set_probePositionMode(){} // RVA: 0x7FFAF9BA3660
        public void get_refreshMode(){} // RVA: 0x7FFAF9BA36C0
        public void set_refreshMode(){} // RVA: 0x7FFAF9BA3710
        public void get_qualityMode(){} // RVA: 0x7FFAF9BA3770
        public void set_qualityMode(){} // RVA: 0x7FFAF9BA37C0
        public void get_dataFormat(){} // RVA: 0x7FFAF9BA3820
        public void set_dataFormat(){} // RVA: 0x7FFAF9BA3870
        public void Update(){} // RVA: 0x7FFAF9BA38D0
        public void SetDirtyFlag(){} // RVA: 0x7FFAF9BA3930
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_boundsGlobal_Injected(){} // RVA: 0x7FFAF9BA3990
        public void get_sizeCustom_Injected(){} // RVA: 0x7FFAF9BA39F0
        public void set_sizeCustom_Injected(){} // RVA: 0x7FFAF9BA3A50
        public void get_originCustom_Injected(){} // RVA: 0x7FFAF9BA3AB0
        public void set_originCustom_Injected(){} // RVA: 0x7FFAF9BA3B10
    }

    public class LightProbes
    {
        // ── Methods ──
        public void Internal_CallLightProbesUpdatedFunction(){} // RVA: 0x7FFAF9B89400
        public void Internal_CallTetrahedralizationCompletedFunction(){} // RVA: 0x7FFAF9B89460
        public void Internal_CallNeedsRetetrahedralizationFunction(){} // RVA: 0x7FFAF9B894C0
        public void CalculateInterpolatedLightAndOcclusionProbes(){} // RVA: 0x7FFAF9B89520
        public void CalculateInterpolatedLightAndOcclusionProbes_Internal(){} // RVA: 0x7FFAF9B89720
    }

    public class LightingSettings
    {
        // ── Methods ──
        public void LightingSettingsDontStripMe(){} // RVA: 0x7FFAF2D8D310
    }

    public class LightmapData
    {
        // ── Methods ──
        public void get_lightmapColor(){} // RVA: 0x7FFAF5E66D40
        public void set_lightmapColor(){} // RVA: 0x7FFAF2D8EE30
        public void get_lightmapDir(){} // RVA: 0x7FFAF59BF420
        public void set_lightmapDir(){} // RVA: 0x7FFAF2DF3E80
        public void get_shadowMask(){} // RVA: 0x7FFAF94D4380
        public void set_shadowMask(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class LightmapSettings
    {
        public object fog;
        public object fogStartDistance;

        // ── Methods ──
        public void get_lightmaps(){} // RVA: 0x7FFAF9B89310
        public void set_lightmaps(){} // RVA: 0x7FFAF9B89360
        public void set_lightmapsMode(){} // RVA: 0x7FFAF9B893B0
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
        public void SetWidth(){} // RVA: 0x7FFAF9B8C860
        public void SetColors(){} // RVA: 0x7FFAF9B8C910
        public void SetVertexCount(){} // RVA: 0x7FFAF9B8C9D0
        public void get_numPositions(){} // RVA: 0x7FFAF9B8CA30
        public void set_numPositions(){} // RVA: 0x7FFAF9B8C9D0
        public void get_startWidth(){} // RVA: 0x7FFAF9B8CA80
        public void set_startWidth(){} // RVA: 0x7FFAF9B8CAD0
        public void get_endWidth(){} // RVA: 0x7FFAF9B8CB30
        public void set_endWidth(){} // RVA: 0x7FFAF9B8CB80
        public void get_widthMultiplier(){} // RVA: 0x7FFAF9B8CBE0
        public void set_widthMultiplier(){} // RVA: 0x7FFAF9B8CC30
        public void get_numCornerVertices(){} // RVA: 0x7FFAF9B8CC90
        public void set_numCornerVertices(){} // RVA: 0x7FFAF9B8CCE0
        public void get_numCapVertices(){} // RVA: 0x7FFAF9B8CD40
        public void set_numCapVertices(){} // RVA: 0x7FFAF9B8CD90
        public void get_useWorldSpace(){} // RVA: 0x7FFAF9B8CDF0
        public void set_useWorldSpace(){} // RVA: 0x7FFAF9B8CE40
        public void get_loop(){} // RVA: 0x7FFAF9B8CEA0
        public void set_loop(){} // RVA: 0x7FFAF9B8CEF0
        public void get_startColor(){} // RVA: 0x7FFAF9B8CF50
        public void set_startColor(){} // RVA: 0x7FFAF9B8CFC0
        public void get_endColor(){} // RVA: 0x7FFAF9B8D020
        public void set_endColor(){} // RVA: 0x7FFAF9B8D090
        public void get_positionCount(){} // RVA: 0x7FFAF9B8CA30
        public void set_positionCount(){} // RVA: 0x7FFAF9B8C9D0
        public void SetPosition(){} // RVA: 0x7FFAF9B8D0F0
        public void GetPosition(){} // RVA: 0x7FFAF9B8D160
        public void get_textureScale(){} // RVA: 0x7FFAF9B8D1E0
        public void set_textureScale(){} // RVA: 0x7FFAF9B8D240
        public void get_shadowBias(){} // RVA: 0x7FFAF9B8D2A0
        public void set_shadowBias(){} // RVA: 0x7FFAF9B8D2F0
        public void get_generateLightingData(){} // RVA: 0x7FFAF9B8D350
        public void set_generateLightingData(){} // RVA: 0x7FFAF9B8D3A0
        public void get_textureMode(){} // RVA: 0x7FFAF9B8D400
        public void set_textureMode(){} // RVA: 0x7FFAF9B8D450
        public void get_alignment(){} // RVA: 0x7FFAF9B8D4B0
        public void set_alignment(){} // RVA: 0x7FFAF9B8D500
        public void get_maskInteraction(){} // RVA: 0x7FFAF9B8D560
        public void set_maskInteraction(){} // RVA: 0x7FFAF9B8D5B0
        public void Simplify(){} // RVA: 0x7FFAF9B8D610
        public void BakeMesh(){} // RVA: 0x7FFAF9B8D700 | overloaded x2
        public void get_widthCurve(){} // RVA: 0x7FFAF9B8D780
        public void set_widthCurve(){} // RVA: 0x7FFAF9B8D7D0
        public void get_colorGradient(){} // RVA: 0x7FFAF9B8D830
        public void set_colorGradient(){} // RVA: 0x7FFAF9B8D880
        public void GetWidthCurveCopy(){} // RVA: 0x7FFAF9B8D780
        public void SetWidthCurve(){} // RVA: 0x7FFAF9B8D7D0
        public void GetColorGradientCopy(){} // RVA: 0x7FFAF9B8D830
        public void SetColorGradient(){} // RVA: 0x7FFAF9B8D880
        public void GetPositions(){} // RVA: 0x7FFAF9B8DAA0 | overloaded x3
        public void SetPositions(){} // RVA: 0x7FFAF9B8D9F0 | overloaded x3
        public void SetPositionsWithNativeContainer(){} // RVA: 0x7FFAF9B8DB00
        public void GetPositionsWithNativeContainer(){} // RVA: 0x7FFAF9B8DB70
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_startColor_Injected(){} // RVA: 0x7FFAF9B8DBE0
        public void set_startColor_Injected(){} // RVA: 0x7FFAF9B8DC40
        public void get_endColor_Injected(){} // RVA: 0x7FFAF9B8DCA0
        public void set_endColor_Injected(){} // RVA: 0x7FFAF9B8DD00
        public void SetPosition_Injected(){} // RVA: 0x7FFAF9B8DD60
        public void GetPosition_Injected(){} // RVA: 0x7FFAF9B8DDD0
        public void get_textureScale_Injected(){} // RVA: 0x7FFAF9B8DE40
        public void set_textureScale_Injected(){} // RVA: 0x7FFAF9B8DEA0
    }

    public class Logger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9BBF110
        public void get_logHandler(){} // RVA: 0x7FFAF2DA8380
        public void set_logHandler(){} // RVA: 0x7FFAF2D8EE30
        public void get_logEnabled(){} // RVA: 0x7FFAF2DA84E0
        public void set_logEnabled(){} // RVA: 0x7FFAF2DA84F0
        public void get_filterLogType(){} // RVA: 0x7FFAF442C3B0
        public void set_filterLogType(){} // RVA: 0x7FFAF4439FD0
        public void IsLogTypeAllowed(){} // RVA: 0x7FFAF9BBF180
        public void GetString(){} // RVA: 0x7FFAF9BBF1A0
        public void Log(){} // RVA: 0x7FFAF9BBF670 | overloaded x4
        public void LogWarning(){} // RVA: 0x7FFAF9BBF7E0
        public void LogError(){} // RVA: 0x7FFAF9BBF950
        public void LogException(){} // RVA: 0x7FFAF9BBFB30 | overloaded x2
        public void LogFormat(){} // RVA: 0x7FFAF9BBFC40 | overloaded x2
    }

    public class LowerResBlitTexture
    {
        // ── Methods ──
        public void LowerResBlitTextureDontStripMe(){} // RVA: 0x7FFAF2D8D310
    }

}