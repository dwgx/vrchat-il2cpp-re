// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 13
// Methods: 268

namespace ThirdParty.Unity.UnityEngine
{
    public class LOD : ValueType
    {
        public float screenRelativeTransitionHeight; // 0x10
        public float fadeTransitionWidth; // 0x14
        public rical[] renderers; // 0x18
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
        public void get_localReferencePoint(){} // RVA: 0x7FFD54CACAC0
        public void set_localReferencePoint(){} // RVA: 0x7FFD54CACB30
        public void get_size(){} // RVA: 0x7FFD54CACB90
        public void set_size(){} // RVA: 0x7FFD54CACBE0
        public void get_lodCount(){} // RVA: 0x7FFD54CACC40
        public void get_lastLODBillboard(){} // RVA: 0x7FFD54CACC90
        public void set_lastLODBillboard(){} // RVA: 0x7FFD54CACCE0
        public void get_fadeMode(){} // RVA: 0x7FFD54CACD40
        public void set_fadeMode(){} // RVA: 0x7FFD54CACD90
        public void get_animateCrossFading(){} // RVA: 0x7FFD54CACDF0
        public void set_animateCrossFading(){} // RVA: 0x7FFD54CACE40
        public void get_enabled(){} // RVA: 0x7FFD54CACEA0
        public void set_enabled(){} // RVA: 0x7FFD54CACEF0
        public void RecalculateBounds(){} // RVA: 0x7FFD54CACF50
        public void GetLODs(){} // RVA: 0x7FFD54CACFA0
        public void SetLODS(){} // RVA: 0x7FFD54CACFF0
        public void SetLODs(){} // RVA: 0x7FFD54CACFF0
        public void ForceLOD(){} // RVA: 0x7FFD54CAD050
        public void get_crossFadeAnimationDuration(){} // RVA: 0x7FFD54CAD0B0
        public void set_crossFadeAnimationDuration(){} // RVA: 0x7FFD54CAD100
        public void get_worldReferencePoint(){} // RVA: 0x7FFD54CAD160
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_localReferencePoint_Injected(){} // RVA: 0x7FFD54CAD1D0
        public void set_localReferencePoint_Injected(){} // RVA: 0x7FFD54CAD230
        public void get_worldReferencePoint_Injected(){} // RVA: 0x7FFD54CAD290
    }

    public class LayerMask : ValueType
    {
        public int value; // 0x10

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFD5061C020 | overloaded x2
        public void get_value(){} // RVA: 0x7FFD543B3F90
        public void set_value(){} // RVA: 0x7FFD4E78D8B0
        public void LayerToName(){} // RVA: 0x7FFD54CE1EB0
        public void NameToLayer(){} // RVA: 0x7FFD54CE1F00
        public void GetMask(){} // RVA: 0x7FFD54CE1F50
    }

    public class LensFlare : Behaviour
    {
        public object brightness;
        public object fadeSpeed;
        public object color;
        public object flare;

        // ── Methods ──
        public void get_brightness(){} // RVA: 0x7FFD54CA8A10
        public void set_brightness(){} // RVA: 0x7FFD54CA8A60
        public void get_fadeSpeed(){} // RVA: 0x7FFD54CA8AC0
        public void set_fadeSpeed(){} // RVA: 0x7FFD54CA8B10
        public void get_color(){} // RVA: 0x7FFD54CA8B70
        public void set_color(){} // RVA: 0x7FFD54CA8BE0
        public void get_flare(){} // RVA: 0x7FFD54CA8C40
        public void set_flare(){} // RVA: 0x7FFD54CA8C90
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_color_Injected(){} // RVA: 0x7FFD54CA8CF0
        public void set_color_Injected(){} // RVA: 0x7FFD54CA8D50
    }

    public class Light : Behaviour
    {
        public int type; // 0x18

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFD54CA9330
        public void set_type(){} // RVA: 0x7FFD54CA9380
        public void get_shape(){} // RVA: 0x7FFD54CA93E0
        public void set_shape(){} // RVA: 0x7FFD54CA9430
        public void get_spotAngle(){} // RVA: 0x7FFD54CA9490
        public void set_spotAngle(){} // RVA: 0x7FFD54CA94E0
        public void get_innerSpotAngle(){} // RVA: 0x7FFD54CA9540
        public void set_innerSpotAngle(){} // RVA: 0x7FFD54CA9590
        public void get_color(){} // RVA: 0x7FFD54CA95F0
        public void set_color(){} // RVA: 0x7FFD54CA9660
        public void get_colorTemperature(){} // RVA: 0x7FFD54CA96C0
        public void set_colorTemperature(){} // RVA: 0x7FFD54CA9710
        public void get_useColorTemperature(){} // RVA: 0x7FFD54CA9770
        public void set_useColorTemperature(){} // RVA: 0x7FFD54CA97C0
        public void get_intensity(){} // RVA: 0x7FFD54CA9820
        public void set_intensity(){} // RVA: 0x7FFD54CA9870
        public void get_bounceIntensity(){} // RVA: 0x7FFD54CA98D0
        public void set_bounceIntensity(){} // RVA: 0x7FFD54CA9920
        public void get_useBoundingSphereOverride(){} // RVA: 0x7FFD54CA9980
        public void set_useBoundingSphereOverride(){} // RVA: 0x7FFD54CA99D0
        public void get_boundingSphereOverride(){} // RVA: 0x7FFD54CA9A30
        public void set_boundingSphereOverride(){} // RVA: 0x7FFD54CA9AA0
        public void get_useViewFrustumForShadowCasterCull(){} // RVA: 0x7FFD54CA9B00
        public void set_useViewFrustumForShadowCasterCull(){} // RVA: 0x7FFD54CA9B50
        public void get_shadowCustomResolution(){} // RVA: 0x7FFD54CA9BB0
        public void set_shadowCustomResolution(){} // RVA: 0x7FFD54CA9C00
        public void get_shadowBias(){} // RVA: 0x7FFD54CA9C60
        public void set_shadowBias(){} // RVA: 0x7FFD54CA9CB0
        public void get_shadowNormalBias(){} // RVA: 0x7FFD54CA9D10
        public void set_shadowNormalBias(){} // RVA: 0x7FFD54CA9D60
        public void get_shadowNearPlane(){} // RVA: 0x7FFD54CA9DC0
        public void set_shadowNearPlane(){} // RVA: 0x7FFD54CA9E10
        public void get_useShadowMatrixOverride(){} // RVA: 0x7FFD54CA9E70
        public void set_useShadowMatrixOverride(){} // RVA: 0x7FFD54CA9EC0
        public void get_shadowMatrixOverride(){} // RVA: 0x7FFD54CA9F20
        public void set_shadowMatrixOverride(){} // RVA: 0x7FFD54CA9FA0
        public void get_range(){} // RVA: 0x7FFD54CAA000
        public void set_range(){} // RVA: 0x7FFD54CAA050
        public void get_flare(){} // RVA: 0x7FFD54CAA0B0
        public void set_flare(){} // RVA: 0x7FFD54CAA100
        public void get_bakingOutput(){} // RVA: 0x7FFD54CAA160
        public void set_bakingOutput(){} // RVA: 0x7FFD54CAA1D0
        public void get_cullingMask(){} // RVA: 0x7FFD54CAA230
        public void set_cullingMask(){} // RVA: 0x7FFD54CAA280
        public void get_renderingLayerMask(){} // RVA: 0x7FFD54CAA2E0
        public void set_renderingLayerMask(){} // RVA: 0x7FFD54CAA330
        public void get_lightShadowCasterMode(){} // RVA: 0x7FFD54CAA390
        public void set_lightShadowCasterMode(){} // RVA: 0x7FFD54CAA3E0
        public void Reset(){} // RVA: 0x7FFD54CAA440
        public void get_shadows(){} // RVA: 0x7FFD54CAA490
        public void set_shadows(){} // RVA: 0x7FFD54CAA4E0
        public void get_shadowStrength(){} // RVA: 0x7FFD54CAA540
        public void set_shadowStrength(){} // RVA: 0x7FFD54CAA590
        public void get_shadowResolution(){} // RVA: 0x7FFD54CAA5F0
        public void set_shadowResolution(){} // RVA: 0x7FFD54CAA640
        public void get_shadowSoftness(){} // RVA: 0x7FFD54CAA6A0
        public void set_shadowSoftness(){} // RVA: 0x7FFD4E341310
        public void get_shadowSoftnessFade(){} // RVA: 0x7FFD54CAA6B0
        public void set_shadowSoftnessFade(){} // RVA: 0x7FFD4E341310
        public void get_layerShadowCullDistances(){} // RVA: 0x7FFD54CAA6C0
        public void set_layerShadowCullDistances(){} // RVA: 0x7FFD54CAA710
        public void get_cookieSize(){} // RVA: 0x7FFD54CAA770
        public void set_cookieSize(){} // RVA: 0x7FFD54CAA7C0
        public void get_cookie(){} // RVA: 0x7FFD54CAA820
        public void set_cookie(){} // RVA: 0x7FFD54CAA870
        public void get_renderMode(){} // RVA: 0x7FFD54CAA8D0
        public void set_renderMode(){} // RVA: 0x7FFD54CAA920
        public void get_bakedIndex(){} // RVA: 0x7FFD51ABDCA0
        public void set_bakedIndex(){} // RVA: 0x7FFD4ED4CD10
        public void AddCommandBuffer(){} // RVA: 0x7FFD54CAAA00 | overloaded x2
        public void AddCommandBufferAsync(){} // RVA: 0x7FFD54CAAB10 | overloaded x2
        public void RemoveCommandBuffer(){} // RVA: 0x7FFD54CAAB90
        public void RemoveCommandBuffers(){} // RVA: 0x7FFD54CAAC00
        public void RemoveAllCommandBuffers(){} // RVA: 0x7FFD54CAAC60
        public void GetCommandBuffers(){} // RVA: 0x7FFD54CAACB0
        public void get_commandBufferCount(){} // RVA: 0x7FFD54CAAD10
        public void get_pixelLightCount(){} // RVA: 0x7FFD54C929C0
        public void set_pixelLightCount(){} // RVA: 0x7FFD54C92A10
        public void GetLights(){} // RVA: 0x7FFD54CAAD60
        public void get_shadowConstantBias(){} // RVA: 0x7FFD54CAADC0
        public void set_shadowConstantBias(){} // RVA: 0x7FFD4E341310
        public void get_shadowObjectSizeBias(){} // RVA: 0x7FFD54CAADC0
        public void set_shadowObjectSizeBias(){} // RVA: 0x7FFD4E341310
        public void get_attenuate(){} // RVA: 0x7FFD500182C0
        public void set_attenuate(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_color_Injected(){} // RVA: 0x7FFD54CAADD0
        public void set_color_Injected(){} // RVA: 0x7FFD54CAAE30
        public void get_boundingSphereOverride_Injected(){} // RVA: 0x7FFD54CAAE90
        public void set_boundingSphereOverride_Injected(){} // RVA: 0x7FFD54CAAEF0
        public void get_shadowMatrixOverride_Injected(){} // RVA: 0x7FFD54CAAF50
        public void set_shadowMatrixOverride_Injected(){} // RVA: 0x7FFD54CAAFB0
        public void get_bakingOutput_Injected(){} // RVA: 0x7FFD54CAB010
        public void set_bakingOutput_Injected(){} // RVA: 0x7FFD54CAB070
    }

    public class LightProbeGroup : Behaviour
    {
        public object probePositions;

        // ── Methods ──
        public void get_probePositions(){} // RVA: 0x7FFD51B532B0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
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
        public void get_isFeatureSupported(){} // RVA: 0x7FFD54CAB2E0
        public void get_boundsGlobal(){} // RVA: 0x7FFD54CAB330
        public void get_sizeCustom(){} // RVA: 0x7FFD54CAB3A0
        public void set_sizeCustom(){} // RVA: 0x7FFD54CAB410
        public void get_originCustom(){} // RVA: 0x7FFD54CAB470
        public void set_originCustom(){} // RVA: 0x7FFD54CAB4E0
        public void get_probeDensity(){} // RVA: 0x7FFD54CAB540
        public void set_probeDensity(){} // RVA: 0x7FFD54CAB590
        public void get_gridResolutionX(){} // RVA: 0x7FFD54CAB5F0
        public void set_gridResolutionX(){} // RVA: 0x7FFD54CAB640
        public void get_gridResolutionY(){} // RVA: 0x7FFD54CAB6A0
        public void set_gridResolutionY(){} // RVA: 0x7FFD54CAB6F0
        public void get_gridResolutionZ(){} // RVA: 0x7FFD54CAB750
        public void set_gridResolutionZ(){} // RVA: 0x7FFD54CAB7A0
        public void get_boundingBoxMode(){} // RVA: 0x7FFD54CAB800
        public void set_boundingBoxMode(){} // RVA: 0x7FFD54CAB850
        public void get_resolutionMode(){} // RVA: 0x7FFD54CAB8B0
        public void set_resolutionMode(){} // RVA: 0x7FFD54CAB900
        public void get_probePositionMode(){} // RVA: 0x7FFD54CAB960
        public void set_probePositionMode(){} // RVA: 0x7FFD54CAB9B0
        public void get_refreshMode(){} // RVA: 0x7FFD54CABA10
        public void set_refreshMode(){} // RVA: 0x7FFD54CABA60
        public void get_qualityMode(){} // RVA: 0x7FFD54CABAC0
        public void set_qualityMode(){} // RVA: 0x7FFD54CABB10
        public void get_dataFormat(){} // RVA: 0x7FFD54CABB70
        public void set_dataFormat(){} // RVA: 0x7FFD54CABBC0
        public void Update(){} // RVA: 0x7FFD54CABC20
        public void SetDirtyFlag(){} // RVA: 0x7FFD54CABC80
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_boundsGlobal_Injected(){} // RVA: 0x7FFD54CABCE0
        public void get_sizeCustom_Injected(){} // RVA: 0x7FFD54CABD40
        public void set_sizeCustom_Injected(){} // RVA: 0x7FFD54CABDA0
        public void get_originCustom_Injected(){} // RVA: 0x7FFD54CABE00
        public void set_originCustom_Injected(){} // RVA: 0x7FFD54CABE60
    }

    public class LightProbes : Object
    {
        public ÎÌÍÏÏÌÍÏ lightProbesUpdated;
        public ÎÌÍÏÏÌÍÏ tetrahedralizationCompleted; // 0x8
        public ÎÌÍÏÏÌÍÏ needsRetetrahedralization; // 0x10

        // ── Methods ──
        public void Internal_CallLightProbesUpdatedFunction(){} // RVA: 0x7FFD54C91A50
        public void Internal_CallTetrahedralizationCompletedFunction(){} // RVA: 0x7FFD54C91AB0
        public void Internal_CallNeedsRetetrahedralizationFunction(){} // RVA: 0x7FFD54C91B10
        public void CalculateInterpolatedLightAndOcclusionProbes(){} // RVA: 0x7FFD54C91B70
        public void CalculateInterpolatedLightAndOcclusionProbes_Internal(){} // RVA: 0x7FFD54C91D70
    }

    public class LightingSettings : Object
    {
        // ── Methods ──
        public void LightingSettingsDontStripMe(){} // RVA: 0x7FFD4E341310
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
        public void SetWidth(){} // RVA: 0x7FFD54C94EB0
        public void SetColors(){} // RVA: 0x7FFD54C94F60
        public void SetVertexCount(){} // RVA: 0x7FFD54C95020
        public void get_numPositions(){} // RVA: 0x7FFD54C95080
        public void set_numPositions(){} // RVA: 0x7FFD54C95020
        public void get_startWidth(){} // RVA: 0x7FFD54C950D0
        public void set_startWidth(){} // RVA: 0x7FFD54C95120
        public void get_endWidth(){} // RVA: 0x7FFD54C95180
        public void set_endWidth(){} // RVA: 0x7FFD54C951D0
        public void get_widthMultiplier(){} // RVA: 0x7FFD54C95230
        public void set_widthMultiplier(){} // RVA: 0x7FFD54C95280
        public void get_numCornerVertices(){} // RVA: 0x7FFD54C952E0
        public void set_numCornerVertices(){} // RVA: 0x7FFD54C95330
        public void get_numCapVertices(){} // RVA: 0x7FFD54C95390
        public void set_numCapVertices(){} // RVA: 0x7FFD54C953E0
        public void get_useWorldSpace(){} // RVA: 0x7FFD54C95440
        public void set_useWorldSpace(){} // RVA: 0x7FFD54C95490
        public void get_loop(){} // RVA: 0x7FFD54C954F0
        public void set_loop(){} // RVA: 0x7FFD54C95540
        public void get_startColor(){} // RVA: 0x7FFD54C955A0
        public void set_startColor(){} // RVA: 0x7FFD54C95610
        public void get_endColor(){} // RVA: 0x7FFD54C95670
        public void set_endColor(){} // RVA: 0x7FFD54C956E0
        public void get_positionCount(){} // RVA: 0x7FFD54C95080
        public void set_positionCount(){} // RVA: 0x7FFD54C95020
        public void SetPosition(){} // RVA: 0x7FFD54C95740
        public void GetPosition(){} // RVA: 0x7FFD54C957B0
        public void get_textureScale(){} // RVA: 0x7FFD54C95830
        public void set_textureScale(){} // RVA: 0x7FFD54C95890
        public void get_shadowBias(){} // RVA: 0x7FFD54C958F0
        public void set_shadowBias(){} // RVA: 0x7FFD54C95940
        public void get_generateLightingData(){} // RVA: 0x7FFD54C959A0
        public void set_generateLightingData(){} // RVA: 0x7FFD54C959F0
        public void get_textureMode(){} // RVA: 0x7FFD54C95A50
        public void set_textureMode(){} // RVA: 0x7FFD54C95AA0
        public void get_alignment(){} // RVA: 0x7FFD54C95B00
        public void set_alignment(){} // RVA: 0x7FFD54C95B50
        public void get_maskInteraction(){} // RVA: 0x7FFD54C95BB0
        public void set_maskInteraction(){} // RVA: 0x7FFD54C95C00
        public void Simplify(){} // RVA: 0x7FFD54C95C60
        public void BakeMesh(){} // RVA: 0x7FFD54C95D50 | overloaded x2
        public void get_widthCurve(){} // RVA: 0x7FFD54C95DD0
        public void set_widthCurve(){} // RVA: 0x7FFD54C95E20
        public void get_colorGradient(){} // RVA: 0x7FFD54C95E80
        public void set_colorGradient(){} // RVA: 0x7FFD54C95ED0
        public void GetWidthCurveCopy(){} // RVA: 0x7FFD54C95DD0
        public void SetWidthCurve(){} // RVA: 0x7FFD54C95E20
        public void GetColorGradientCopy(){} // RVA: 0x7FFD54C95E80
        public void SetColorGradient(){} // RVA: 0x7FFD54C95ED0
        public void GetPositions(){} // RVA: 0x7FFD54C960F0 | overloaded x3
        public void SetPositions(){} // RVA: 0x7FFD54C96040 | overloaded x3
        public void SetPositionsWithNativeContainer(){} // RVA: 0x7FFD54C96150
        public void GetPositionsWithNativeContainer(){} // RVA: 0x7FFD54C961C0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_startColor_Injected(){} // RVA: 0x7FFD54C96230
        public void set_startColor_Injected(){} // RVA: 0x7FFD54C96290
        public void get_endColor_Injected(){} // RVA: 0x7FFD54C962F0
        public void set_endColor_Injected(){} // RVA: 0x7FFD54C96350
        public void SetPosition_Injected(){} // RVA: 0x7FFD54C963B0
        public void GetPosition_Injected(){} // RVA: 0x7FFD54C96420
        public void get_textureScale_Injected(){} // RVA: 0x7FFD54C96490
        public void set_textureScale_Injected(){} // RVA: 0x7FFD54C964F0
    }

    public class Logger : Object
    {
        public ode logHandler; // 0x10
        public bool logEnabled; // 0x18
        public object filterLogType; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54CC74D0
        public void get_logHandler(){} // RVA: 0x7FFD4E35C380
        public void set_logHandler(){} // RVA: 0x7FFD4E342E30
        public void get_logEnabled(){} // RVA: 0x7FFD4E35C4E0
        public void set_logEnabled(){} // RVA: 0x7FFD4E35C4F0
        public void get_filterLogType(){} // RVA: 0x7FFD4F8557F0
        public void set_filterLogType(){} // RVA: 0x7FFD4F8674D0
        public void IsLogTypeAllowed(){} // RVA: 0x7FFD54CC7540
        public void GetString(){} // RVA: 0x7FFD54CC7560
        public void Log(){} // RVA: 0x7FFD54CC7A30 | overloaded x4
        public void LogWarning(){} // RVA: 0x7FFD54CC7BA0
        public void LogError(){} // RVA: 0x7FFD54CC7D10
        public void LogException(){} // RVA: 0x7FFD54CC7EF0 | overloaded x2
        public void LogFormat(){} // RVA: 0x7FFD54CC8000 | overloaded x2
    }

    public class LowerResBlitTexture : Object
    {
        // ── Methods ──
        public void LowerResBlitTextureDontStripMe(){} // RVA: 0x7FFD4E341310
    }

}