// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 13
// Methods: 268

namespace ThirdParty.Unity.UnityEngine
{
    public class LOD : ValueType
    {
        public object renderers; // 0x32CBA750
    }

    public class LODGroup : Component
    {
        // ── Original Methods ──
        public void get_localReferencePoint(){} // RVA: 0x7ffaaf2aea20
        public void set_localReferencePoint(){} // RVA: 0x7ffaaf2aea90
        public void get_size(){} // RVA: 0x7ffaaf2aeaf0
        public void set_size(){} // RVA: 0x7ffaaf2aeb40
        public void get_lodCount(){} // RVA: 0x7ffaaf2aeba0
        public void get_lastLODBillboard(){} // RVA: 0x7ffaaf2aebf0
        public void set_lastLODBillboard(){} // RVA: 0x7ffaaf2aec40
        public void get_fadeMode(){} // RVA: 0x7ffaaf2aeca0
        public void set_fadeMode(){} // RVA: 0x7ffaaf2aecf0
        public void get_animateCrossFading(){} // RVA: 0x7ffaaf2aed50
        public void set_animateCrossFading(){} // RVA: 0x7ffaaf2aeda0
        public void get_enabled(){} // RVA: 0x7ffaaf2aee00
        public void set_enabled(){} // RVA: 0x7ffaaf2aee50
        public void RecalculateBounds(){} // RVA: 0x7ffaaf2aeeb0
        public void ForceLOD(){} // RVA: 0x7ffaaf2aefb0
        public void get_crossFadeAnimationDuration(){} // RVA: 0x7ffaaf2af010
        public void set_crossFadeAnimationDuration(){} // RVA: 0x7ffaaf2af060
        public void get_worldReferencePoint(){} // RVA: 0x7ffaaf2af0c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_localReferencePoint_Injected(){} // RVA: 0x7ffaaf2af130
        public void set_localReferencePoint_Injected(){} // RVA: 0x7ffaaf2af190
        public void get_worldReferencePoint_Injected(){} // RVA: 0x7ffaaf2af1f0
        // ── Binary Analysis Named ──
        public void GetLODs(){} // RVA: 0x7ffaaf2aef00
        public void SetLODS(){} // RVA: 0x7ffaaf2aef50
        public void SetLODs(){} // RVA: 0x7ffaaf2aef50
    }

    public class LayerMask : ValueType
    {
        // ── Original Methods ──
        public void op_Implicit(){} // RVA: 0x7ffaaabfdf80
        public void op_Implicit(){} // RVA: 0x7ffaaabfdf80
        public void get_value(){} // RVA: 0x7ffaae9b5f60
        public void set_value(){} // RVA: 0x7ffaa8d92880
        public void LayerToName(){} // RVA: 0x7ffaaf2e3e10
        public void NameToLayer(){} // RVA: 0x7ffaaf2e3e60
        // ── Binary Analysis Named ──
        public void GetMask(){} // RVA: 0x7ffaaf2e3eb0
    }

    public class LensFlare : Behaviour
    {
        // ── Original Methods ──
        public void get_brightness(){} // RVA: 0x7ffaaf2aa970
        public void set_brightness(){} // RVA: 0x7ffaaf2aa9c0
        public void get_fadeSpeed(){} // RVA: 0x7ffaaf2aaa20
        public void set_fadeSpeed(){} // RVA: 0x7ffaaf2aaa70
        public void get_color(){} // RVA: 0x7ffaaf2aaad0
        public void set_color(){} // RVA: 0x7ffaaf2aab40
        public void get_flare(){} // RVA: 0x7ffaaf2aaba0
        public void set_flare(){} // RVA: 0x7ffaaf2aabf0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_color_Injected(){} // RVA: 0x7ffaaf2aac50
        public void set_color_Injected(){} // RVA: 0x7ffaaf2aacb0
    }

    public class Light : Behaviour
    {
        // ── Original Methods ──
        public void get_type(){} // RVA: 0x7ffaaf2ab290
        public void set_type(){} // RVA: 0x7ffaaf2ab2e0
        public void get_shape(){} // RVA: 0x7ffaaf2ab340
        public void set_shape(){} // RVA: 0x7ffaaf2ab390
        public void get_spotAngle(){} // RVA: 0x7ffaaf2ab3f0
        public void set_spotAngle(){} // RVA: 0x7ffaaf2ab440
        public void get_innerSpotAngle(){} // RVA: 0x7ffaaf2ab4a0
        public void set_innerSpotAngle(){} // RVA: 0x7ffaaf2ab4f0
        public void get_color(){} // RVA: 0x7ffaaf2ab550
        public void set_color(){} // RVA: 0x7ffaaf2ab5c0
        public void get_colorTemperature(){} // RVA: 0x7ffaaf2ab620
        public void set_colorTemperature(){} // RVA: 0x7ffaaf2ab670
        public void get_useColorTemperature(){} // RVA: 0x7ffaaf2ab6d0
        public void set_useColorTemperature(){} // RVA: 0x7ffaaf2ab720
        public void get_intensity(){} // RVA: 0x7ffaaf2ab780
        public void set_intensity(){} // RVA: 0x7ffaaf2ab7d0
        public void get_bounceIntensity(){} // RVA: 0x7ffaaf2ab830
        public void set_bounceIntensity(){} // RVA: 0x7ffaaf2ab880
        public void get_useBoundingSphereOverride(){} // RVA: 0x7ffaaf2ab8e0
        public void set_useBoundingSphereOverride(){} // RVA: 0x7ffaaf2ab930
        public void get_boundingSphereOverride(){} // RVA: 0x7ffaaf2ab990
        public void set_boundingSphereOverride(){} // RVA: 0x7ffaaf2aba00
        public void get_useViewFrustumForShadowCasterCull(){} // RVA: 0x7ffaaf2aba60
        public void set_useViewFrustumForShadowCasterCull(){} // RVA: 0x7ffaaf2abab0
        public void get_shadowCustomResolution(){} // RVA: 0x7ffaaf2abb10
        public void set_shadowCustomResolution(){} // RVA: 0x7ffaaf2abb60
        public void get_shadowBias(){} // RVA: 0x7ffaaf2abbc0
        public void set_shadowBias(){} // RVA: 0x7ffaaf2abc10
        public void get_shadowNormalBias(){} // RVA: 0x7ffaaf2abc70
        public void set_shadowNormalBias(){} // RVA: 0x7ffaaf2abcc0
        public void get_shadowNearPlane(){} // RVA: 0x7ffaaf2abd20
        public void set_shadowNearPlane(){} // RVA: 0x7ffaaf2abd70
        public void get_useShadowMatrixOverride(){} // RVA: 0x7ffaaf2abdd0
        public void set_useShadowMatrixOverride(){} // RVA: 0x7ffaaf2abe20
        public void get_shadowMatrixOverride(){} // RVA: 0x7ffaaf2abe80
        public void set_shadowMatrixOverride(){} // RVA: 0x7ffaaf2abf00
        public void get_range(){} // RVA: 0x7ffaaf2abf60
        public void set_range(){} // RVA: 0x7ffaaf2abfb0
        public void get_flare(){} // RVA: 0x7ffaaf2ac010
        public void set_flare(){} // RVA: 0x7ffaaf2ac060
        public void get_bakingOutput(){} // RVA: 0x7ffaaf2ac0c0
        public void set_bakingOutput(){} // RVA: 0x7ffaaf2ac130
        public void get_cullingMask(){} // RVA: 0x7ffaaf2ac190
        public void set_cullingMask(){} // RVA: 0x7ffaaf2ac1e0
        public void get_renderingLayerMask(){} // RVA: 0x7ffaaf2ac240
        public void set_renderingLayerMask(){} // RVA: 0x7ffaaf2ac290
        public void get_lightShadowCasterMode(){} // RVA: 0x7ffaaf2ac2f0
        public void set_lightShadowCasterMode(){} // RVA: 0x7ffaaf2ac340
        public void Reset(){} // RVA: 0x7ffaaf2ac3a0
        public void get_shadows(){} // RVA: 0x7ffaaf2ac3f0
        public void set_shadows(){} // RVA: 0x7ffaaf2ac440
        public void get_shadowStrength(){} // RVA: 0x7ffaaf2ac4a0
        public void set_shadowStrength(){} // RVA: 0x7ffaaf2ac4f0
        public void get_shadowResolution(){} // RVA: 0x7ffaaf2ac550
        public void set_shadowResolution(){} // RVA: 0x7ffaaf2ac5a0
        public void get_shadowSoftness(){} // RVA: 0x7ffaaf2ac600
        public void set_shadowSoftness(){} // RVA: 0x7ffaa8932310
        public void get_shadowSoftnessFade(){} // RVA: 0x7ffaaf2ac610
        public void set_shadowSoftnessFade(){} // RVA: 0x7ffaa8932310
        public void get_layerShadowCullDistances(){} // RVA: 0x7ffaaf2ac620
        public void set_layerShadowCullDistances(){} // RVA: 0x7ffaaf2ac670
        public void get_cookieSize(){} // RVA: 0x7ffaaf2ac6d0
        public void set_cookieSize(){} // RVA: 0x7ffaaf2ac720
        public void get_cookie(){} // RVA: 0x7ffaaf2ac780
        public void set_cookie(){} // RVA: 0x7ffaaf2ac7d0
        public void get_renderMode(){} // RVA: 0x7ffaaf2ac830
        public void set_renderMode(){} // RVA: 0x7ffaaf2ac880
        public void get_bakedIndex(){} // RVA: 0x7ffaac0adb00
        public void set_bakedIndex(){} // RVA: 0x7ffaa9357830
        public void AddCommandBuffer(){} // RVA: 0x7ffaaf2ac960
        public void AddCommandBuffer(){} // RVA: 0x7ffaaf2ac960
        public void AddCommandBufferAsync(){} // RVA: 0x7ffaaf2aca70
        public void AddCommandBufferAsync(){} // RVA: 0x7ffaaf2aca70
        public void RemoveCommandBuffer(){} // RVA: 0x7ffaaf2acaf0
        public void RemoveCommandBuffers(){} // RVA: 0x7ffaaf2acb60
        public void RemoveAllCommandBuffers(){} // RVA: 0x7ffaaf2acbc0
        public void get_commandBufferCount(){} // RVA: 0x7ffaaf2acc70
        public void get_pixelLightCount(){} // RVA: 0x7ffaaf294920
        public void set_pixelLightCount(){} // RVA: 0x7ffaaf294970
        public void get_shadowConstantBias(){} // RVA: 0x7ffaaf2acd20
        public void set_shadowConstantBias(){} // RVA: 0x7ffaa8932310
        public void get_shadowObjectSizeBias(){} // RVA: 0x7ffaaf2acd20
        public void set_shadowObjectSizeBias(){} // RVA: 0x7ffaa8932310
        public void get_attenuate(){} // RVA: 0x7ffaaa5f9770
        public void set_attenuate(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_color_Injected(){} // RVA: 0x7ffaaf2acd30
        public void set_color_Injected(){} // RVA: 0x7ffaaf2acd90
        public void get_boundingSphereOverride_Injected(){} // RVA: 0x7ffaaf2acdf0
        public void set_boundingSphereOverride_Injected(){} // RVA: 0x7ffaaf2ace50
        public void get_shadowMatrixOverride_Injected(){} // RVA: 0x7ffaaf2aceb0
        public void set_shadowMatrixOverride_Injected(){} // RVA: 0x7ffaaf2acf10
        public void get_bakingOutput_Injected(){} // RVA: 0x7ffaaf2acf70
        public void set_bakingOutput_Injected(){} // RVA: 0x7ffaaf2acfd0
        // ── Binary Analysis Named ──
        public void GetCommandBuffers(){} // RVA: 0x7ffaaf2acc10
        public void GetLights(){} // RVA: 0x7ffaaf2accc0
    }

    public class LightProbeGroup : Behaviour
    {
        // ── Original Methods ──
        public void get_probePositions(){} // RVA: 0x7ffaac13e3c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class LightProbeProxyVolume : Behaviour
    {
        // ── Original Methods ──
        public void get_isFeatureSupported(){} // RVA: 0x7ffaaf2ad240
        public void get_boundsGlobal(){} // RVA: 0x7ffaaf2ad290
        public void get_sizeCustom(){} // RVA: 0x7ffaaf2ad300
        public void set_sizeCustom(){} // RVA: 0x7ffaaf2ad370
        public void get_originCustom(){} // RVA: 0x7ffaaf2ad3d0
        public void set_originCustom(){} // RVA: 0x7ffaaf2ad440
        public void get_probeDensity(){} // RVA: 0x7ffaaf2ad4a0
        public void set_probeDensity(){} // RVA: 0x7ffaaf2ad4f0
        public void get_gridResolutionX(){} // RVA: 0x7ffaaf2ad550
        public void set_gridResolutionX(){} // RVA: 0x7ffaaf2ad5a0
        public void get_gridResolutionY(){} // RVA: 0x7ffaaf2ad600
        public void set_gridResolutionY(){} // RVA: 0x7ffaaf2ad650
        public void get_gridResolutionZ(){} // RVA: 0x7ffaaf2ad6b0
        public void set_gridResolutionZ(){} // RVA: 0x7ffaaf2ad700
        public void get_boundingBoxMode(){} // RVA: 0x7ffaaf2ad760
        public void set_boundingBoxMode(){} // RVA: 0x7ffaaf2ad7b0
        public void get_resolutionMode(){} // RVA: 0x7ffaaf2ad810
        public void set_resolutionMode(){} // RVA: 0x7ffaaf2ad860
        public void get_probePositionMode(){} // RVA: 0x7ffaaf2ad8c0
        public void set_probePositionMode(){} // RVA: 0x7ffaaf2ad910
        public void get_refreshMode(){} // RVA: 0x7ffaaf2ad970
        public void set_refreshMode(){} // RVA: 0x7ffaaf2ad9c0
        public void get_qualityMode(){} // RVA: 0x7ffaaf2ada20
        public void set_qualityMode(){} // RVA: 0x7ffaaf2ada70
        public void get_dataFormat(){} // RVA: 0x7ffaaf2adad0
        public void set_dataFormat(){} // RVA: 0x7ffaaf2adb20
        public void Update(){} // RVA: 0x7ffaaf2adb80
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_boundsGlobal_Injected(){} // RVA: 0x7ffaaf2adc40
        public void get_sizeCustom_Injected(){} // RVA: 0x7ffaaf2adca0
        public void set_sizeCustom_Injected(){} // RVA: 0x7ffaaf2add00
        public void get_originCustom_Injected(){} // RVA: 0x7ffaaf2add60
        public void set_originCustom_Injected(){} // RVA: 0x7ffaaf2addc0
        // ── Binary Analysis Named ──
        public void SetDirtyFlag(){} // RVA: 0x7ffaaf2adbe0
    }

    public class LightProbes : Object
    {
        public object needsRetetrahedralization; // 0x32CBA5D0

        // ── Original Methods ──
        public void Internal_CallLightProbesUpdatedFunction(){} // RVA: 0x7ffaaf2939b0
        public void Internal_CallTetrahedralizationCompletedFunction(){} // RVA: 0x7ffaaf293a10
        public void Internal_CallNeedsRetetrahedralizationFunction(){} // RVA: 0x7ffaaf293a70
        public void CalculateInterpolatedLightAndOcclusionProbes(){} // RVA: 0x7ffaaf293ad0
        public void CalculateInterpolatedLightAndOcclusionProbes_Internal(){} // RVA: 0x7ffaaf293cd0
    }

    public class LightingSettings : Object
    {
        // ── Original Methods ──
        public void LightingSettingsDontStripMe(){} // RVA: 0x7ffaa8932310
    }

    public class LightmapSettings : Object
    {
    }

    public class LineRenderer : Renderer
    {
        // ── Original Methods ──
        public void get_numPositions(){} // RVA: 0x7ffaaf296fe0
        public void set_numPositions(){} // RVA: 0x7ffaaf296f80
        public void get_startWidth(){} // RVA: 0x7ffaaf297030
        public void set_startWidth(){} // RVA: 0x7ffaaf297080
        public void get_endWidth(){} // RVA: 0x7ffaaf2970e0
        public void set_endWidth(){} // RVA: 0x7ffaaf297130
        public void get_widthMultiplier(){} // RVA: 0x7ffaaf297190
        public void set_widthMultiplier(){} // RVA: 0x7ffaaf2971e0
        public void get_numCornerVertices(){} // RVA: 0x7ffaaf297240
        public void set_numCornerVertices(){} // RVA: 0x7ffaaf297290
        public void get_numCapVertices(){} // RVA: 0x7ffaaf2972f0
        public void set_numCapVertices(){} // RVA: 0x7ffaaf297340
        public void get_useWorldSpace(){} // RVA: 0x7ffaaf2973a0
        public void set_useWorldSpace(){} // RVA: 0x7ffaaf2973f0
        public void get_loop(){} // RVA: 0x7ffaaf297450
        public void set_loop(){} // RVA: 0x7ffaaf2974a0
        public void get_startColor(){} // RVA: 0x7ffaaf297500
        public void set_startColor(){} // RVA: 0x7ffaaf297570
        public void get_endColor(){} // RVA: 0x7ffaaf2975d0
        public void set_endColor(){} // RVA: 0x7ffaaf297640
        public void get_positionCount(){} // RVA: 0x7ffaaf296fe0
        public void set_positionCount(){} // RVA: 0x7ffaaf296f80
        public void get_textureScale(){} // RVA: 0x7ffaaf297790
        public void set_textureScale(){} // RVA: 0x7ffaaf2977f0
        public void get_shadowBias(){} // RVA: 0x7ffaaf297850
        public void set_shadowBias(){} // RVA: 0x7ffaaf2978a0
        public void get_generateLightingData(){} // RVA: 0x7ffaaf297900
        public void set_generateLightingData(){} // RVA: 0x7ffaaf297950
        public void get_textureMode(){} // RVA: 0x7ffaaf2979b0
        public void set_textureMode(){} // RVA: 0x7ffaaf297a00
        public void get_alignment(){} // RVA: 0x7ffaaf297a60
        public void set_alignment(){} // RVA: 0x7ffaaf297ab0
        public void get_maskInteraction(){} // RVA: 0x7ffaaf297b10
        public void set_maskInteraction(){} // RVA: 0x7ffaaf297b60
        public void Simplify(){} // RVA: 0x7ffaaf297bc0
        public void BakeMesh(){} // RVA: 0x7ffaaf297cb0
        public void BakeMesh(){} // RVA: 0x7ffaaf297cb0
        public void get_widthCurve(){} // RVA: 0x7ffaaf297d30
        public void set_widthCurve(){} // RVA: 0x7ffaaf297d80
        public void get_colorGradient(){} // RVA: 0x7ffaaf297de0
        public void set_colorGradient(){} // RVA: 0x7ffaaf297e30
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_startColor_Injected(){} // RVA: 0x7ffaaf298190
        public void set_startColor_Injected(){} // RVA: 0x7ffaaf2981f0
        public void get_endColor_Injected(){} // RVA: 0x7ffaaf298250
        public void set_endColor_Injected(){} // RVA: 0x7ffaaf2982b0
        public void get_textureScale_Injected(){} // RVA: 0x7ffaaf2983f0
        public void set_textureScale_Injected(){} // RVA: 0x7ffaaf298450
        // ── Binary Analysis Named ──
        public void SetWidth(){} // RVA: 0x7ffaaf296e10
        public void SetColors(){} // RVA: 0x7ffaaf296ec0
        public void SetVertexCount(){} // RVA: 0x7ffaaf296f80
        public void SetPosition(){} // RVA: 0x7ffaaf2976a0
        public void GetPosition(){} // RVA: 0x7ffaaf297710
        public void GetWidthCurveCopy(){} // RVA: 0x7ffaaf297d30
        public void SetWidthCurve(){} // RVA: 0x7ffaaf297d80
        public void GetColorGradientCopy(){} // RVA: 0x7ffaaf297de0
        public void SetColorGradient(){} // RVA: 0x7ffaaf297e30
        public void GetPositions(){} // RVA: 0x7ffaaf298050
        public void SetPositions(){} // RVA: 0x7ffaaf297fa0
        public void SetPositions(){} // RVA: 0x7ffaaf297fa0
        public void SetPositions(){} // RVA: 0x7ffaaf297fa0
        public void GetPositions(){} // RVA: 0x7ffaaf298050
        public void GetPositions(){} // RVA: 0x7ffaaf298050
        public void SetPositionsWithNativeContainer(){} // RVA: 0x7ffaaf2980b0
        public void GetPositionsWithNativeContainer(){} // RVA: 0x7ffaaf298120
        public void SetPosition_Injected(){} // RVA: 0x7ffaaf298310
        public void GetPosition_Injected(){} // RVA: 0x7ffaaf298380
    }

    public class Logger : Object
    {
        public object _filterLogType; // 0x33B0C1D0, was: <filterLogType>k__BackingField
        public object logHandler; // 0x170002AF

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf2c9430
        public void get_logHandler(){} // RVA: 0x7ffaa894d380
        public void set_logHandler(){} // RVA: 0x7ffaa8933e30
        public void get_logEnabled(){} // RVA: 0x7ffaa894d4e0
        public void set_logEnabled(){} // RVA: 0x7ffaa894d4f0
        public void get_filterLogType(){} // RVA: 0x7ffaa9e5ac10
        public void set_filterLogType(){} // RVA: 0x7ffaa9e6a2e0
        public void IsLogTypeAllowed(){} // RVA: 0x7ffaaf2c94a0
        public void Log(){} // RVA: 0x7ffaaf2c9990
        public void Log(){} // RVA: 0x7ffaaf2c9990
        public void Log(){} // RVA: 0x7ffaaf2c9990
        public void Log(){} // RVA: 0x7ffaaf2c9990
        public void LogWarning(){} // RVA: 0x7ffaaf2c9b00
        public void LogError(){} // RVA: 0x7ffaaf2c9c70
        public void LogException(){} // RVA: 0x7ffaaf2c9e50
        public void LogException(){} // RVA: 0x7ffaaf2c9e50
        public void LogFormat(){} // RVA: 0x7ffaaf2c9f60
        public void LogFormat(){} // RVA: 0x7ffaaf2c9f60
        // ── Binary Analysis Named ──
        public void GetString(){} // RVA: 0x7ffaaf2c94c0
    }

    public class LowerResBlitTexture : Object
    {
        // ── Original Methods ──
        public void LowerResBlitTextureDontStripMe(){} // RVA: 0x7ffaa8932310
    }

}