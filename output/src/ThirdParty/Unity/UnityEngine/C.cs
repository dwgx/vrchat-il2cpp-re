// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 55
// Methods: 1270

namespace ThirdParty.Unity.UnityEngine
{
    public class Cache : ValueType
    {
        public int m_Handle; // 0x10
        public object _handle; // 0x93
        public object _valid; // 0xF28
        public object _path;
        public object ÎÎÎÌÏÍÌÎÏÏÌÏÍÍÍÏÍÎÏÏÍÌÏ; // 0x12F0

        // ── Methods ──
        public void get_handle(){} // RVA: 0x7FFE8733C3B0
        public void GetHashCode(){} // RVA: 0x7FFE8733C3B0
        public void Equals(){} // RVA: 0x7FFE87BFD7C0 | overloaded x2
        public void get_valid(){} // RVA: 0x7FFE87BFD7D0
        public void Cache_IsValid(){} // RVA: 0x7FFE87BFD820
        public void get_path(){} // RVA: 0x7FFE87BFD870
        public void Cache_GetPath(){} // RVA: 0x7FFE87BFD8C0
        public void set_maximumAvailableStorageSpace(){} // RVA: 0x7FFE87BFD910
        public void Cache_SetMaximumDiskSpaceAvailable(){} // RVA: 0x7FFE87BFD970
        public void get_spaceOccupied(){} // RVA: 0x7FFE87BFD9D0
        public void Cache_GetCachingDiskSpaceUsed(){} // RVA: 0x7FFE87BFDA20
    }

    public class CachedAssetBundle : ValueType
    {
        public string m_Name; // 0x10
        public UnityEngine.Hash128 m_Hash; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8445A610
        public void get_name(){} // RVA: 0x7FFE8348B260
        public void get_hash(){} // RVA: 0x7FFE87BFD730
    }

    public class Caching : Object
    {
        // ── Methods ──
        public void ClearCache(){} // RVA: 0x7FFE87BFDAC0 | overloaded x2
        public void ClearCache_Int(){} // RVA: 0x7FFE87BFDAC0
        public void ClearAllCachedVersions(){} // RVA: 0x7FFE87BFDB10
        public void ClearCachedVersions(){} // RVA: 0x7FFE87BFDBD0
        public void IsVersionCached(){} // RVA: 0x7FFE87BFDD30 | overloaded x2
        public void MarkAsUsed(){} // RVA: 0x7FFE87BFDE90 | overloaded x2
        public void AddCache(){} // RVA: 0x7FFE87BFE220 | overloaded x2
        public void GetCacheByPath(){} // RVA: 0x7FFE87BFE290
        public void get_currentCacheForWriting(){} // RVA: 0x7FFE87BFE2F0
        public void set_currentCacheForWriting(){} // RVA: 0x7FFE87BFE350
        public void ClearCachedVersions_Injected(){} // RVA: 0x7FFE87BFE3A0
        public void IsVersionCached_Injected(){} // RVA: 0x7FFE87BFE410
        public void MarkAsUsed_Injected(){} // RVA: 0x7FFE87BFE480
        public void AddCache_Injected(){} // RVA: 0x7FFE87BFE4F0
        public void GetCacheByPath_Injected(){} // RVA: 0x7FFE87BFE560
        public void get_currentCacheForWriting_Injected(){} // RVA: 0x7FFE87BFE5C0
        public void set_currentCacheForWriting_Injected(){} // RVA: 0x7FFE87BFE610
    }

    public class Camera : Behaviour
    {
        public float kMinAperture;
        public float kMaxAperture;
        public int kMinBladeCount;
        public int kMaxBladeCount;
        public CameraCallback onPreCull;
        public CameraCallback onPreRender; // 0x8
        public CameraCallback onPostRender; // 0x10
        public object field_7; // 0xE200
        public object field_8; // 0x52
        public object field_9; // 0x53
        public object field_10; // 0x54
        public object field_11; // 0x55
        public object field_12; // 0x56
        public object field_13; // 0x57
        public object field_14; // 0x58
        public object field_15; // 0x59
        public object field_16; // 0x5A
        public object field_17; // 0x5B
        public object field_18; // 0x5C
        public object field_19; // 0x5D
        public object field_20; // 0x5E
        public object field_21; // 0x5F
        public object field_22; // 0x60
        public object field_23; // 0x61
        public object field_24; // 0x62
        public object field_25; // 0x63
        public object field_26; // 0x64
        public object field_27; // 0x65
        public object field_28; // 0x66
        public object field_29; // 0x67
        public object field_30; // 0x68
        public object field_31; // 0x69
        public object field_32; // 0x6A
        public object field_33; // 0x6B
        public object field_34; // 0x6C
        public object field_35; // 0x6D
        public object field_36; // 0x6E
        public object field_37; // 0x6F
        public object field_38; // 0x70
        public object field_39; // 0x71
        public object field_40; // 0x72
        public object field_41; // 0x73
        public object field_42; // 0x74
        public object field_43; // 0x75
        public object field_44; // 0x76
        public object field_45; // 0x77
        public object field_46; // 0x78
        public object field_47; // 0x79
        public object field_48; // 0x7A
        public object field_49; // 0x7B
        public object field_50; // 0x7C
        public object field_51; // 0x7D
        public object field_52; // 0x7E
        public object field_53; // 0x7F
        public object field_54; // 0x80
        public object field_55; // 0x81
        public object field_56; // 0x82
        public object field_57; // 0x83
        public object field_58; // 0x84
        public object field_59; // 0x85
        public object field_60; // 0x86
        public object field_61; // 0x87
        public object field_62; // 0x88
        public object field_63; // 0x89
        public object field_64; // 0x8A
        public object field_65; // 0x8B
        public object field_66; // 0x8C
        public object field_67; // 0x8D
        public object field_68; // 0x8E
        public object field_69; // 0x8F
        public object field_70; // 0x90
        public object field_71; // 0x91
        public object field_72; // 0x92
        public object field_73; // 0x93

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_nearClipPlane(){} // RVA: 0x7FFE87BFE660
        public void set_nearClipPlane(){} // RVA: 0x7FFE87BFE6B0
        public void get_farClipPlane(){} // RVA: 0x7FFE87BFE710
        public void set_farClipPlane(){} // RVA: 0x7FFE87BFE760
        public void get_fieldOfView(){} // RVA: 0x7FFE87BFE7C0
        public void set_fieldOfView(){} // RVA: 0x7FFE87BFE810
        public void get_renderingPath(){} // RVA: 0x7FFE87BFE870
        public void set_renderingPath(){} // RVA: 0x7FFE87BFE8C0
        public void get_actualRenderingPath(){} // RVA: 0x7FFE87BFE920
        public void Reset(){} // RVA: 0x7FFE87BFE970
        public void get_allowHDR(){} // RVA: 0x7FFE87BFE9C0
        public void set_allowHDR(){} // RVA: 0x7FFE87BFEA10
        public void get_allowMSAA(){} // RVA: 0x7FFE87BFEA70
        public void set_allowMSAA(){} // RVA: 0x7FFE87BFEAC0
        public void get_allowDynamicResolution(){} // RVA: 0x7FFE87BFEB20
        public void set_allowDynamicResolution(){} // RVA: 0x7FFE87BFEB70
        public void get_forceIntoRenderTexture(){} // RVA: 0x7FFE87BFEBD0
        public void set_forceIntoRenderTexture(){} // RVA: 0x7FFE87BFEC20
        public void get_orthographicSize(){} // RVA: 0x7FFE87BFEC80
        public void set_orthographicSize(){} // RVA: 0x7FFE87BFECD0
        public void get_orthographic(){} // RVA: 0x7FFE87BFED30
        public void set_orthographic(){} // RVA: 0x7FFE87BFED80
        public void get_opaqueSortMode(){} // RVA: 0x7FFE87BFEDE0
        public void set_opaqueSortMode(){} // RVA: 0x7FFE87BFEE30
        public void get_transparencySortMode(){} // RVA: 0x7FFE87BFEE90
        public void set_transparencySortMode(){} // RVA: 0x7FFE87BFEEE0
        public void get_transparencySortAxis(){} // RVA: 0x7FFE87BFEF40
        public void set_transparencySortAxis(){} // RVA: 0x7FFE87BFEFB0
        public void ResetTransparencySortSettings(){} // RVA: 0x7FFE87BFF010
        public void get_depth(){} // RVA: 0x7FFE87BFF060
        public void set_depth(){} // RVA: 0x7FFE87BFF0B0
        public void get_aspect(){} // RVA: 0x7FFE87BFF110
        public void set_aspect(){} // RVA: 0x7FFE87BFF160
        public void ResetAspect(){} // RVA: 0x7FFE87BFF1C0
        public void get_velocity(){} // RVA: 0x7FFE87BFF210
        public void get_cullingMask(){} // RVA: 0x7FFE87BFF280
        public void set_cullingMask(){} // RVA: 0x7FFE87BFF2D0
        public void get_eventMask(){} // RVA: 0x7FFE87BFF330
        public void set_eventMask(){} // RVA: 0x7FFE87BFF380
        public void get_layerCullSpherical(){} // RVA: 0x7FFE87BFF3E0
        public void set_layerCullSpherical(){} // RVA: 0x7FFE87BFF430
        public void get_cameraType(){} // RVA: 0x7FFE87BFF490
        public void set_cameraType(){} // RVA: 0x7FFE87BFF4E0
        public void get_skyboxMaterial(){} // RVA: 0x7FFE87BFF540
        public void get_overrideSceneCullingMask(){} // RVA: 0x7FFE87BFF590
        public void set_overrideSceneCullingMask(){} // RVA: 0x7FFE87BFF5E0
        public void get_sceneCullingMask(){} // RVA: 0x7FFE87BFF640
        public void GetLayerCullDistances(){} // RVA: 0x7FFE87BFF690
        public void SetLayerCullDistances(){} // RVA: 0x7FFE87BFF6E0
        public void get_layerCullDistances(){} // RVA: 0x7FFE87BFF690
        public void set_layerCullDistances(){} // RVA: 0x7FFE87BFF740
        public void get_PreviewCullingLayer(){} // RVA: 0x7FFE87BFF800
        public void get_useOcclusionCulling(){} // RVA: 0x7FFE87BFF810
        public void set_useOcclusionCulling(){} // RVA: 0x7FFE87BFF860
        public void get_cullingMatrix(){} // RVA: 0x7FFE87BFF8C0
        public void set_cullingMatrix(){} // RVA: 0x7FFE87BFF940
        public void ResetCullingMatrix(){} // RVA: 0x7FFE87BFF9A0
        public void get_backgroundColor(){} // RVA: 0x7FFE87BFF9F0
        public void set_backgroundColor(){} // RVA: 0x7FFE87BFFA60
        public void get_clearFlags(){} // RVA: 0x7FFE87BFFAC0
        public void set_clearFlags(){} // RVA: 0x7FFE87BFFB10
        public void get_depthTextureMode(){} // RVA: 0x7FFE87BFFB70
        public void set_depthTextureMode(){} // RVA: 0x7FFE87BFFBC0
        public void get_clearStencilAfterLightingPass(){} // RVA: 0x7FFE87BFFC20
        public void set_clearStencilAfterLightingPass(){} // RVA: 0x7FFE87BFFC70
        public void SetReplacementShader(){} // RVA: 0x7FFE87BFFCD0
        public void ResetReplacementShader(){} // RVA: 0x7FFE87BFFD40
        public void get_projectionMatrixMode(){} // RVA: 0x7FFE87BFFD90
        public void get_usePhysicalProperties(){} // RVA: 0x7FFE87BFFDE0
        public void set_usePhysicalProperties(){} // RVA: 0x7FFE87BFFE30
        public void get_iso(){} // RVA: 0x7FFE87BFFE90
        public void set_iso(){} // RVA: 0x7FFE87BFFEE0
        public void get_shutterSpeed(){} // RVA: 0x7FFE87BFFF40
        public void set_shutterSpeed(){} // RVA: 0x7FFE87BFFF90
        public void get_aperture(){} // RVA: 0x7FFE87BFFFF0
        public void set_aperture(){} // RVA: 0x7FFE87C00040
        public void get_focusDistance(){} // RVA: 0x7FFE87C000A0
        public void set_focusDistance(){} // RVA: 0x7FFE87C000F0
        public void get_focalLength(){} // RVA: 0x7FFE87C00150
        public void set_focalLength(){} // RVA: 0x7FFE87C001A0
        public void get_bladeCount(){} // RVA: 0x7FFE87C00200
        public void set_bladeCount(){} // RVA: 0x7FFE87C00250
        public void get_curvature(){} // RVA: 0x7FFE87C002B0
        public void set_curvature(){} // RVA: 0x7FFE87C00310
        public void get_barrelClipping(){} // RVA: 0x7FFE87C00370
        public void set_barrelClipping(){} // RVA: 0x7FFE87C003C0
        public void get_anamorphism(){} // RVA: 0x7FFE87C00420
        public void set_anamorphism(){} // RVA: 0x7FFE87C00470
        public void get_sensorSize(){} // RVA: 0x7FFE87C004D0
        public void set_sensorSize(){} // RVA: 0x7FFE87C00530
        public void get_lensShift(){} // RVA: 0x7FFE87C00590
        public void set_lensShift(){} // RVA: 0x7FFE87C005F0
        public void get_gateFit(){} // RVA: 0x7FFE87C00650
        public void set_gateFit(){} // RVA: 0x7FFE87C006A0
        public void GetGateFittedFieldOfView(){} // RVA: 0x7FFE87C00700
        public void GetGateFittedLensShift(){} // RVA: 0x7FFE87C00750
        public void GetLocalSpaceAim(){} // RVA: 0x7FFE87C007B0
        public void get_rect(){} // RVA: 0x7FFE87C00820
        public void set_rect(){} // RVA: 0x7FFE87C00890
        public void get_pixelRect(){} // RVA: 0x7FFE87C008F0
        public void set_pixelRect(){} // RVA: 0x7FFE87C00960
        public void get_pixelWidth(){} // RVA: 0x7FFE87C009C0
        public void get_pixelHeight(){} // RVA: 0x7FFE87C00A10
        public void get_scaledPixelWidth(){} // RVA: 0x7FFE87C00A60
        public void get_scaledPixelHeight(){} // RVA: 0x7FFE87C00AB0
        public void get_targetTexture(){} // RVA: 0x7FFE87C00B00
        public void set_targetTexture(){} // RVA: 0x7FFE87C00B50
        public void get_activeTexture(){} // RVA: 0x7FFE87C00BB0
        public void get_targetDisplay(){} // RVA: 0x7FFE87C00C00
        public void set_targetDisplay(){} // RVA: 0x7FFE87C00C50
        public void SetTargetBuffersImpl(){} // RVA: 0x7FFE87C00CB0
        public void SetTargetBuffers(){} // RVA: 0x7FFE87C00E00 | overloaded x2
        public void SetTargetBuffersMRTImpl(){} // RVA: 0x7FFE87C00D90
        public void GetCameraBufferWarnings(){} // RVA: 0x7FFE87C00E70
        public void get_cameraToWorldMatrix(){} // RVA: 0x7FFE87C00EC0
        public void get_worldToCameraMatrix(){} // RVA: 0x7FFE87C00F40
        public void set_worldToCameraMatrix(){} // RVA: 0x7FFE87C00FC0
        public void get_projectionMatrix(){} // RVA: 0x7FFE87C01020
        public void set_projectionMatrix(){} // RVA: 0x7FFE87C010A0
        public void get_nonJitteredProjectionMatrix(){} // RVA: 0x7FFE87C01100
        public void set_nonJitteredProjectionMatrix(){} // RVA: 0x7FFE87C01180
        public void get_useJitteredProjectionMatrixForTransparentRendering(){} // RVA: 0x7FFE87C011E0
        public void set_useJitteredProjectionMatrixForTransparentRendering(){} // RVA: 0x7FFE87C01230
        public void get_previousViewProjectionMatrix(){} // RVA: 0x7FFE87C01290
        public void ResetWorldToCameraMatrix(){} // RVA: 0x7FFE87C01310
        public void ResetProjectionMatrix(){} // RVA: 0x7FFE87C01360
        public void CalculateObliqueMatrix(){} // RVA: 0x7FFE87C013B0
        public void WorldToScreenPoint(){} // RVA: 0x7FFE87C01680 | overloaded x2
        public void WorldToViewportPoint(){} // RVA: 0x7FFE87C01730 | overloaded x2
        public void ViewportToWorldPoint(){} // RVA: 0x7FFE87C017E0 | overloaded x2
        public void ScreenToWorldPoint(){} // RVA: 0x7FFE87C01890 | overloaded x2
        public void ScreenToViewportPoint(){} // RVA: 0x7FFE87C01940
        public void ViewportToScreenPoint(){} // RVA: 0x7FFE87C019C0
        public void GetFrustumPlaneSizeAt(){} // RVA: 0x7FFE87C01A40
        public void ViewportPointToRay(){} // RVA: 0x7FFE87C01C10 | overloaded x3
        public void ScreenPointToRay(){} // RVA: 0x7FFE87C01E30 | overloaded x3
        public void CalculateFrustumCornersInternal(){} // RVA: 0x7FFE87C01EF0
        public void CalculateFrustumCorners(){} // RVA: 0x7FFE87C01F80
        public void CalculateProjectionMatrixFromPhysicalPropertiesInternal(){} // RVA: 0x7FFE87C020D0
        public void CalculateProjectionMatrixFromPhysicalProperties(){} // RVA: 0x7FFE87C02180
        public void FocalLengthToFieldOfView(){} // RVA: 0x7FFE87C02230
        public void FieldOfViewToFocalLength(){} // RVA: 0x7FFE87C022A0
        public void HorizontalToVerticalFieldOfView(){} // RVA: 0x7FFE87C02310
        public void VerticalToHorizontalFieldOfView(){} // RVA: 0x7FFE87C02380
        public void get_main(){} // RVA: 0x7FFE81899A90
        public void get_current(){} // RVA: 0x7FFE87C023F0
        public void get_scene(){} // RVA: 0x7FFE87C02440
        public void set_scene(){} // RVA: 0x7FFE87C024A0
        public void get_stereoEnabled(){} // RVA: 0x7FFE87C02500
        public void get_stereoSeparation(){} // RVA: 0x7FFE87C02550
        public void set_stereoSeparation(){} // RVA: 0x7FFE87C025A0
        public void get_stereoConvergence(){} // RVA: 0x7FFE87C02600
        public void set_stereoConvergence(){} // RVA: 0x7FFE87C02650
        public void get_areVRStereoViewMatricesWithinSingleCullTolerance(){} // RVA: 0x7FFE87C026B0
        public void get_stereoTargetEye(){} // RVA: 0x7FFE87C02700
        public void set_stereoTargetEye(){} // RVA: 0x7FFE87C02750
        public void get_stereoActiveEye(){} // RVA: 0x7FFE87C027B0
        public void GetStereoNonJitteredProjectionMatrix(){} // RVA: 0x7FFE87C02800
        public void GetStereoViewMatrix(){} // RVA: 0x7FFE87C02890
        public void CopyStereoDeviceProjectionMatrixToNonJittered(){} // RVA: 0x7FFE87C02920
        public void GetStereoProjectionMatrix(){} // RVA: 0x7FFE87C02980
        public void SetStereoProjectionMatrix(){} // RVA: 0x7FFE87C02A10
        public void ResetStereoProjectionMatrices(){} // RVA: 0x7FFE87C02A80
        public void SetStereoViewMatrix(){} // RVA: 0x7FFE87C02AD0
        public void ResetStereoViewMatrices(){} // RVA: 0x7FFE87C02B40
        public void GetAllCamerasCount(){} // RVA: 0x7FFE87C02B90
        public void GetAllCamerasImpl(){} // RVA: 0x7FFE87C02BE0
        public void get_allCamerasCount(){} // RVA: 0x7FFE87C02B90
        public void get_allCameras(){} // RVA: 0x7FFE87C02C30
        public void GetAllCameras(){} // RVA: 0x7FFE87C02D00
        public void RenderToCubemapImpl(){} // RVA: 0x7FFE87C02E20
        public void RenderToCubemap(){} // RVA: 0x7FFE87C02F60 | overloaded x5
        public void GetFilterMode(){} // RVA: 0x7FFE87C02F10
        public void get_sceneViewFilterMode(){} // RVA: 0x7FFE87C02F10
        public void RenderToCubemapEyeImpl(){} // RVA: 0x7FFE87C02F60
        public void Render(){} // RVA: 0x7FFE87C02FE0
        public void RenderWithShader(){} // RVA: 0x7FFE87C03030
        public void RenderDontRestore(){} // RVA: 0x7FFE87C030A0
        public void SubmitRenderRequests(){} // RVA: 0x7FFE87C030F0
        public void SubmitRenderRequest(){} // RVA: 0x7FFE810A1420
        public void SubmitRenderRequestsInternal(){} // RVA: 0x7FFE87C032A0
        public void SubmitBuiltInObjectIDRenderRequest(){} // RVA: 0x7FFE87C03300
        public void SetupCurrent(){} // RVA: 0x7FFE87C03390
        public void CopyFrom(){} // RVA: 0x7FFE87C033E0
        public void get_commandBufferCount(){} // RVA: 0x7FFE87C03440
        public void RemoveCommandBuffers(){} // RVA: 0x7FFE87C03490
        public void RemoveAllCommandBuffers(){} // RVA: 0x7FFE87C034F0
        public void AddCommandBufferImpl(){} // RVA: 0x7FFE87C03540
        public void AddCommandBufferAsyncImpl(){} // RVA: 0x7FFE87C035B0
        public void RemoveCommandBufferImpl(){} // RVA: 0x7FFE87C03630
        public void AddCommandBuffer(){} // RVA: 0x7FFE87C036A0
        public void AddCommandBufferAsync(){} // RVA: 0x7FFE87C03800
        public void RemoveCommandBuffer(){} // RVA: 0x7FFE87C03970
        public void GetCommandBuffers(){} // RVA: 0x7FFE87C03AD0
        public void FireOnPreCull(){} // RVA: 0x7FFE87C03B30
        public void FireOnPreRender(){} // RVA: 0x7FFE87C03B90
        public void FireOnPostRender(){} // RVA: 0x7FFE87C03BF0
        public void OnlyUsedForTesting1(){} // RVA: 0x7FFE810FB310
        public void OnlyUsedForTesting2(){} // RVA: 0x7FFE810FB310
        public void TryGetCullingParameters(){} // RVA: 0x7FFE87C03C80 | overloaded x2
        public void GetCullingParameters_Internal(){} // RVA: 0x7FFE87C03CA0
        public void get_transparencySortAxis_Injected(){} // RVA: 0x7FFE87C03D20
        public void set_transparencySortAxis_Injected(){} // RVA: 0x7FFE87C03D80
        public void get_velocity_Injected(){} // RVA: 0x7FFE87C03DE0
        public void get_cullingMatrix_Injected(){} // RVA: 0x7FFE87C03E40
        public void set_cullingMatrix_Injected(){} // RVA: 0x7FFE87C03EA0
        public void get_backgroundColor_Injected(){} // RVA: 0x7FFE87C03F00
        public void set_backgroundColor_Injected(){} // RVA: 0x7FFE87C03F60
        public void get_curvature_Injected(){} // RVA: 0x7FFE87C03FC0
        public void set_curvature_Injected(){} // RVA: 0x7FFE87C04020
        public void get_sensorSize_Injected(){} // RVA: 0x7FFE87C04080
        public void set_sensorSize_Injected(){} // RVA: 0x7FFE87C040E0
        public void get_lensShift_Injected(){} // RVA: 0x7FFE87C04140
        public void set_lensShift_Injected(){} // RVA: 0x7FFE87C041A0
        public void GetGateFittedLensShift_Injected(){} // RVA: 0x7FFE87C04200
        public void GetLocalSpaceAim_Injected(){} // RVA: 0x7FFE87C04260
        public void get_rect_Injected(){} // RVA: 0x7FFE87C042C0
        public void set_rect_Injected(){} // RVA: 0x7FFE87C04320
        public void get_pixelRect_Injected(){} // RVA: 0x7FFE87C04380
        public void set_pixelRect_Injected(){} // RVA: 0x7FFE87C043E0
        public void SetTargetBuffersImpl_Injected(){} // RVA: 0x7FFE87C04440
        public void SetTargetBuffersMRTImpl_Injected(){} // RVA: 0x7FFE87C044B0
        public void get_cameraToWorldMatrix_Injected(){} // RVA: 0x7FFE87C04520
        public void get_worldToCameraMatrix_Injected(){} // RVA: 0x7FFE87C04580
        public void set_worldToCameraMatrix_Injected(){} // RVA: 0x7FFE87C045E0
        public void get_projectionMatrix_Injected(){} // RVA: 0x7FFE87C04640
        public void set_projectionMatrix_Injected(){} // RVA: 0x7FFE87C046A0
        public void get_nonJitteredProjectionMatrix_Injected(){} // RVA: 0x7FFE87C04700
        public void set_nonJitteredProjectionMatrix_Injected(){} // RVA: 0x7FFE87C04760
        public void get_previousViewProjectionMatrix_Injected(){} // RVA: 0x7FFE87C047C0
        public void CalculateObliqueMatrix_Injected(){} // RVA: 0x7FFE87C04820
        public void WorldToScreenPoint_Injected(){} // RVA: 0x7FFE87C04890
        public void WorldToViewportPoint_Injected(){} // RVA: 0x7FFE87C04910
        public void ViewportToWorldPoint_Injected(){} // RVA: 0x7FFE87C04990
        public void ScreenToWorldPoint_Injected(){} // RVA: 0x7FFE87C04A10
        public void ScreenToViewportPoint_Injected(){} // RVA: 0x7FFE87C04A90
        public void ViewportToScreenPoint_Injected(){} // RVA: 0x7FFE87C04B00
        public void GetFrustumPlaneSizeAt_Injected(){} // RVA: 0x7FFE87C04B70
        public void ViewportPointToRay_Injected(){} // RVA: 0x7FFE87C04BE0
        public void ScreenPointToRay_Injected(){} // RVA: 0x7FFE87C04C60
        public void CalculateFrustumCornersInternal_Injected(){} // RVA: 0x7FFE87C04CE0
        public void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(){} // RVA: 0x7FFE87C04D70
        public void get_scene_Injected(){} // RVA: 0x7FFE87C04E00
        public void set_scene_Injected(){} // RVA: 0x7FFE87C04E60
        public void GetStereoNonJitteredProjectionMatrix_Injected(){} // RVA: 0x7FFE87C04EC0
        public void GetStereoViewMatrix_Injected(){} // RVA: 0x7FFE87C04F30
        public void GetStereoProjectionMatrix_Injected(){} // RVA: 0x7FFE87C04FA0
        public void SetStereoProjectionMatrix_Injected(){} // RVA: 0x7FFE87C05010
        public void SetStereoViewMatrix_Injected(){} // RVA: 0x7FFE87C05080
    }

    public class CameraRaycastHelper : Object
    {
        // ── Methods ──
        public void RaycastTry(){} // RVA: 0x7FFE87CE83F0
        public void RaycastTry2D(){} // RVA: 0x7FFE87CE8470
        public void RaycastTry_Injected(){} // RVA: 0x7FFE87CE84F0
        public void RaycastTry2D_Injected(){} // RVA: 0x7FFE87CE8570
    }

    public class Canvas : Behaviour
    {
        public WillRenderCanvases preWillRenderCanvases;
        public WillRenderCanvases willRenderCanvases; // 0x8
        public System.Action`1<int> _externBeginRenderOverlays; // 0x10
        public System.Action`2<int,int> _externRenderOverlaysBefore; // 0x18
        public System.Action`1<int> _externEndRenderOverlays; // 0x20
        public object remove_willRenderCanvases; // 0x3480
        public object field_6; // 0x3638
        public object field_7; // 0x37F0
        public object field_8; // 0x39A8
        public object field_9; // 0x3B60
        public object field_10; // 0x3D18
        public object field_11; // 0x3ED0
        public object field_12; // 0x4088
        public object field_13; // 0x4240
        public object field_14; // 0x43F8
        public object field_15; // 0x45B0
        public object field_16; // 0x4768
        public object field_17; // 0xFF40
        public object field_18; // 0xB960
        public object field_19; // 0xFFFF
        public object field_20; // 0xB5C0
        public object field_21; // 0x53
        public object field_22; // 0xEF77
        public void field_23;
        public object field_24; // 0xB720
        public object remove_willRenderCanvases; // 0xA8E0

        // ── Methods ──
        public void add_preWillRenderCanvases(){} // RVA: 0x7FFE87FDFF40
        public void remove_preWillRenderCanvases(){} // RVA: 0x7FFE87FE0050
        public void add_willRenderCanvases(){} // RVA: 0x7FFE87FE0160
        public void remove_willRenderCanvases(){} // RVA: 0x7FFE87FE0270
        public void get_renderMode(){} // RVA: 0x7FFE87FE0380
        public void set_renderMode(){} // RVA: 0x7FFE87FE03D0
        public void get_isRootCanvas(){} // RVA: 0x7FFE87FE0430
        public void get_pixelRect(){} // RVA: 0x7FFE87FE0480
        public void get_scaleFactor(){} // RVA: 0x7FFE87FE04F0
        public void set_scaleFactor(){} // RVA: 0x7FFE87FE0540
        public void get_referencePixelsPerUnit(){} // RVA: 0x7FFE87FE05A0
        public void set_referencePixelsPerUnit(){} // RVA: 0x7FFE87FE05F0
        public void get_overridePixelPerfect(){} // RVA: 0x7FFE87FE0650
        public void set_overridePixelPerfect(){} // RVA: 0x7FFE87FE06A0
        public void get_vertexColorAlwaysGammaSpace(){} // RVA: 0x7FFE87FE0700
        public void set_vertexColorAlwaysGammaSpace(){} // RVA: 0x7FFE87FE0750
        public void get_pixelPerfect(){} // RVA: 0x7FFE87FE07B0
        public void set_pixelPerfect(){} // RVA: 0x7FFE87FE0800
        public void get_planeDistance(){} // RVA: 0x7FFE87FE0860
        public void set_planeDistance(){} // RVA: 0x7FFE87FE08B0
        public void get_renderOrder(){} // RVA: 0x7FFE87FE0910
        public void get_overrideSorting(){} // RVA: 0x7FFE87FE0960
        public void set_overrideSorting(){} // RVA: 0x7FFE87FE09B0
        public void get_sortingOrder(){} // RVA: 0x7FFE87FE0A10
        public void set_sortingOrder(){} // RVA: 0x7FFE87FE0A60
        public void get_targetDisplay(){} // RVA: 0x7FFE87FE0AC0
        public void set_targetDisplay(){} // RVA: 0x7FFE87FE0B10
        public void get_sortingLayerID(){} // RVA: 0x7FFE87FE0B70
        public void set_sortingLayerID(){} // RVA: 0x7FFE87FE0BC0
        public void get_cachedSortingLayerValue(){} // RVA: 0x7FFE87FE0C20
        public void get_additionalShaderChannels(){} // RVA: 0x7FFE87FE0C70
        public void set_additionalShaderChannels(){} // RVA: 0x7FFE87FE0CC0
        public void get_sortingLayerName(){} // RVA: 0x7FFE87FE0D20
        public void set_sortingLayerName(){} // RVA: 0x7FFE87FE0D70
        public void get_rootCanvas(){} // RVA: 0x7FFE87FE0DD0
        public void get_renderingDisplaySize(){} // RVA: 0x7FFE87FE0E20
        public void get_updateRectTransformForStandalone(){} // RVA: 0x7FFE87FE0E80
        public void set_updateRectTransformForStandalone(){} // RVA: 0x7FFE87FE0ED0
        public void get_externBeginRenderOverlays(){} // RVA: 0x7FFE87FE0F30
        public void set_externBeginRenderOverlays(){} // RVA: 0x7FFE87FE0F70
        public void get_externRenderOverlaysBefore(){} // RVA: 0x7FFE87FE1010
        public void set_externRenderOverlaysBefore(){} // RVA: 0x7FFE87FE1050
        public void get_externEndRenderOverlays(){} // RVA: 0x7FFE87FE10F0
        public void set_externEndRenderOverlays(){} // RVA: 0x7FFE87FE1130
        public void SetExternalCanvasEnabled(){} // RVA: 0x7FFE87FE11D0
        public void get_worldCamera(){} // RVA: 0x7FFE87FE1220
        public void set_worldCamera(){} // RVA: 0x7FFE87FE1270
        public void get_normalizedSortingGridSize(){} // RVA: 0x7FFE87FE12D0
        public void set_normalizedSortingGridSize(){} // RVA: 0x7FFE87FE1320
        public void get_sortingGridNormalizedSize(){} // RVA: 0x7FFE87FE1380
        public void set_sortingGridNormalizedSize(){} // RVA: 0x7FFE87FE13D0
        public void GetDefaultCanvasTextMaterial(){} // RVA: 0x7FFE87FE1430
        public void GetDefaultCanvasMaterial(){} // RVA: 0x7FFE87FE1480
        public void GetETC1SupportedCanvasMaterial(){} // RVA: 0x7FFE87FE14D0
        public void UpdateCanvasRectTransform(){} // RVA: 0x7FFE87FE1520
        public void ForceUpdateCanvases(){} // RVA: 0x7FFE87FE1580
        public void SendPreWillRenderCanvases(){} // RVA: 0x7FFE87FE1620
        public void SendWillRenderCanvases(){} // RVA: 0x7FFE87FE1680
        public void BeginRenderExtraOverlays(){} // RVA: 0x7FFE87FE16E0
        public void RenderExtraOverlaysBefore(){} // RVA: 0x7FFE87FE1740
        public void EndRenderExtraOverlays(){} // RVA: 0x7FFE87FE17B0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_pixelRect_Injected(){} // RVA: 0x7FFE87FE1810
        public void get_renderingDisplaySize_Injected(){} // RVA: 0x7FFE87FE1870
    }

    public class CanvasGroup : Behaviour
    {
        // ── Methods ──
        public void get_alpha(){} // RVA: 0x7FFE87FDBB90
        public void set_alpha(){} // RVA: 0x7FFE87FDBBE0
        public void get_interactable(){} // RVA: 0x7FFE87FDBC40
        public void set_interactable(){} // RVA: 0x7FFE87FDBC90
        public void get_blocksRaycasts(){} // RVA: 0x7FFE87FDBCF0
        public void set_blocksRaycasts(){} // RVA: 0x7FFE87FDBD40
        public void get_ignoreParentGroups(){} // RVA: 0x7FFE87FDBDA0
        public void set_ignoreParentGroups(){} // RVA: 0x7FFE87FDBDF0
        public void IsRaycastLocationValid(){} // RVA: 0x7FFE87FDBCF0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class CanvasRenderer : Component
    {
        public bool _isMask; // 0x18
        public object field_1; // 0x9A30
        public object field_2; // 0x9BE8
        public object field_3; // 0x9DA0
        public object field_4; // 0x9F58
        public object field_5; // 0xA110
        public object field_6; // 0xA2C8
        public object field_7; // 0xA480
        public object field_8; // 0xA638
        public object field_9; // 0xA7F0
        public object field_10; // 0xA9A8

        // ── Methods ──
        public void get_hasPopInstruction(){} // RVA: 0x7FFE87FDBE50
        public void set_hasPopInstruction(){} // RVA: 0x7FFE87FDBEA0
        public void get_materialCount(){} // RVA: 0x7FFE87FDBF00
        public void set_materialCount(){} // RVA: 0x7FFE87FDBF50
        public void get_popMaterialCount(){} // RVA: 0x7FFE87FDBFB0
        public void set_popMaterialCount(){} // RVA: 0x7FFE87FDC000
        public void get_absoluteDepth(){} // RVA: 0x7FFE87FDC060
        public void get_hasMoved(){} // RVA: 0x7FFE87FDC0B0
        public void get_cullTransparentMesh(){} // RVA: 0x7FFE87FDC100
        public void set_cullTransparentMesh(){} // RVA: 0x7FFE87FDC150
        public void get_hasRectClipping(){} // RVA: 0x7FFE87FDC1B0
        public void get_relativeDepth(){} // RVA: 0x7FFE87FDC200
        public void get_cull(){} // RVA: 0x7FFE87FDC250
        public void set_cull(){} // RVA: 0x7FFE87FDC2A0
        public void get_isMask(){} // RVA: 0x7FFE811164E0
        public void set_isMask(){} // RVA: 0x7FFE811164F0
        public void SetColor(){} // RVA: 0x7FFE87FDC300
        public void GetColor(){} // RVA: 0x7FFE87FDC360
        public void EnableRectClipping(){} // RVA: 0x7FFE87FDC3D0
        public void get_clippingSoftness(){} // RVA: 0x7FFE87FDC430
        public void set_clippingSoftness(){} // RVA: 0x7FFE87FDC490
        public void DisableRectClipping(){} // RVA: 0x7FFE87FDC4F0
        public void SetMaterial(){} // RVA: 0x7FFE87FDCA40 | overloaded x2
        public void GetMaterial(){} // RVA: 0x7FFE87FDCBD0 | overloaded x2
        public void SetPopMaterial(){} // RVA: 0x7FFE87FDC610
        public void GetPopMaterial(){} // RVA: 0x7FFE87FDC680
        public void SetTexture(){} // RVA: 0x7FFE87FDC6E0
        public void SetAlphaTexture(){} // RVA: 0x7FFE87FDC740
        public void SetMesh(){} // RVA: 0x7FFE87FDC7A0
        public void GetMesh(){} // RVA: 0x7FFE87FDC800
        public void Clear(){} // RVA: 0x7FFE87FDC850
        public void GetAlpha(){} // RVA: 0x7FFE87FDC8A0
        public void SetAlpha(){} // RVA: 0x7FFE87FDC910
        public void GetInheritedAlpha(){} // RVA: 0x7FFE87FDC9F0
        public void SplitUIVertexStreams(){} // RVA: 0x7FFE87FDCD40 | overloaded x2
        public void CreateUIVertexStream(){} // RVA: 0x7FFE87FDCF90 | overloaded x2
        public void AddUIVertexStream(){} // RVA: 0x7FFE87FDD150 | overloaded x2
        public void SetVertices(){} // RVA: 0x7FFE87FDD320 | overloaded x2
        public void SplitIndicesStreamsInternal(){} // RVA: 0x7FFE87FDDD10
        public void SplitUIVertexStreamsInternal(){} // RVA: 0x7FFE87FDD150
        public void CreateUIVertexStreamInternal(){} // RVA: 0x7FFE87FDCF90
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void SetColor_Injected(){} // RVA: 0x7FFE87FDDD70
        public void GetColor_Injected(){} // RVA: 0x7FFE87FDDDD0
        public void EnableRectClipping_Injected(){} // RVA: 0x7FFE87FDDE30
        public void get_clippingSoftness_Injected(){} // RVA: 0x7FFE87FDDE90
        public void set_clippingSoftness_Injected(){} // RVA: 0x7FFE87FDDEF0
    }

    public class CapsuleCollider : Collider
    {
        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFE87D424C0
        public void set_center(){} // RVA: 0x7FFE87D42530
        public void get_radius(){} // RVA: 0x7FFE87D42590
        public void set_radius(){} // RVA: 0x7FFE87D425E0
        public void get_height(){} // RVA: 0x7FFE87D42640
        public void set_height(){} // RVA: 0x7FFE87D42690
        public void get_direction(){} // RVA: 0x7FFE87D426F0
        public void set_direction(){} // RVA: 0x7FFE87D42740
        public void GetGlobalExtents(){} // RVA: 0x7FFE87D427A0
        public void CalculateTransform(){} // RVA: 0x7FFE87D42800
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_center_Injected(){} // RVA: 0x7FFE87D42880
        public void set_center_Injected(){} // RVA: 0x7FFE87D428E0
        public void GetGlobalExtents_Injected(){} // RVA: 0x7FFE87D42940
        public void CalculateTransform_Injected(){} // RVA: 0x7FFE87D429A0
    }

    public class CapsuleCollider2D : Collider2D
    {
        // ── Methods ──
        public void get_size(){} // RVA: 0x7FFE87D29390
        public void set_size(){} // RVA: 0x7FFE87D293F0
        public void get_direction(){} // RVA: 0x7FFE87D29450
        public void set_direction(){} // RVA: 0x7FFE87D294A0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_size_Injected(){} // RVA: 0x7FFE87D29500
        public void set_size_Injected(){} // RVA: 0x7FFE87D29560
    }

    public class CastHelper`1 : ValueType
    {
    }

    public class CharacterController : Collider
    {
        // ── Methods ──
        public void SimpleMove(){} // RVA: 0x7FFE87D418B0
        public void Move(){} // RVA: 0x7FFE87D41910
        public void get_velocity(){} // RVA: 0x7FFE87D41970
        public void get_isGrounded(){} // RVA: 0x7FFE87D419E0
        public void get_collisionFlags(){} // RVA: 0x7FFE87D41A30
        public void get_radius(){} // RVA: 0x7FFE87D41A80
        public void set_radius(){} // RVA: 0x7FFE87D41AD0
        public void get_height(){} // RVA: 0x7FFE87D41B30
        public void set_height(){} // RVA: 0x7FFE87D41B80
        public void get_center(){} // RVA: 0x7FFE87D41BE0
        public void set_center(){} // RVA: 0x7FFE87D41C50
        public void get_slopeLimit(){} // RVA: 0x7FFE87D41CB0
        public void set_slopeLimit(){} // RVA: 0x7FFE87D41D00
        public void get_stepOffset(){} // RVA: 0x7FFE87D41D60
        public void set_stepOffset(){} // RVA: 0x7FFE87D41DB0
        public void get_skinWidth(){} // RVA: 0x7FFE87D41E10
        public void set_skinWidth(){} // RVA: 0x7FFE87D41E60
        public void get_minMoveDistance(){} // RVA: 0x7FFE87D41EC0
        public void set_minMoveDistance(){} // RVA: 0x7FFE87D41F10
        public void get_detectCollisions(){} // RVA: 0x7FFE87D41F70
        public void set_detectCollisions(){} // RVA: 0x7FFE87D41FC0
        public void get_enableOverlapRecovery(){} // RVA: 0x7FFE87D42020
        public void set_enableOverlapRecovery(){} // RVA: 0x7FFE87D42070
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void SimpleMove_Injected(){} // RVA: 0x7FFE87D420D0
        public void Move_Injected(){} // RVA: 0x7FFE87D42130
        public void get_velocity_Injected(){} // RVA: 0x7FFE87D42190
        public void get_center_Injected(){} // RVA: 0x7FFE87D421F0
        public void set_center_Injected(){} // RVA: 0x7FFE87D42250
    }

    public class CharacterJoint : Joint
    {
        public UnityEngine.Quaternion targetRotation; // 0x18
        public UnityEngine.Vector3 targetAngularVelocity; // 0x28
        public UnityEngine.JointDrive rotationDrive; // 0x34
        public object field_3; // 0xAE
        public object field_4; // 0xAF
        public object field_5; // 0xB0
        public object field_6; // 0xB1
        public object field_7; // 0xB2
        public object field_8; // 0xB3
        public object field_9; // 0xB4

        // ── Methods ──
        public void get_swingAxis(){} // RVA: 0x7FFE87D45080
        public void set_swingAxis(){} // RVA: 0x7FFE87D450F0
        public void get_twistLimitSpring(){} // RVA: 0x7FFE87D45150
        public void set_twistLimitSpring(){} // RVA: 0x7FFE87D451B0
        public void get_swingLimitSpring(){} // RVA: 0x7FFE87D45210
        public void set_swingLimitSpring(){} // RVA: 0x7FFE87D45270
        public void get_lowTwistLimit(){} // RVA: 0x7FFE87D452D0
        public void set_lowTwistLimit(){} // RVA: 0x7FFE87D45340
        public void get_highTwistLimit(){} // RVA: 0x7FFE87D453A0
        public void set_highTwistLimit(){} // RVA: 0x7FFE87D45410
        public void get_swing1Limit(){} // RVA: 0x7FFE87D45470
        public void set_swing1Limit(){} // RVA: 0x7FFE87D454E0
        public void get_swing2Limit(){} // RVA: 0x7FFE87D45540
        public void set_swing2Limit(){} // RVA: 0x7FFE87D455B0
        public void get_enableProjection(){} // RVA: 0x7FFE87D45610
        public void set_enableProjection(){} // RVA: 0x7FFE87D45660
        public void get_projectionDistance(){} // RVA: 0x7FFE87D456C0
        public void set_projectionDistance(){} // RVA: 0x7FFE87D45710
        public void get_projectionAngle(){} // RVA: 0x7FFE87D45770
        public void set_projectionAngle(){} // RVA: 0x7FFE87D457C0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_swingAxis_Injected(){} // RVA: 0x7FFE87D45820
        public void set_swingAxis_Injected(){} // RVA: 0x7FFE87D45880
        public void get_twistLimitSpring_Injected(){} // RVA: 0x7FFE87D458E0
        public void set_twistLimitSpring_Injected(){} // RVA: 0x7FFE87D45940
        public void get_swingLimitSpring_Injected(){} // RVA: 0x7FFE87D459A0
        public void set_swingLimitSpring_Injected(){} // RVA: 0x7FFE87D45A00
        public void get_lowTwistLimit_Injected(){} // RVA: 0x7FFE87D45A60
        public void set_lowTwistLimit_Injected(){} // RVA: 0x7FFE87D45AC0
        public void get_highTwistLimit_Injected(){} // RVA: 0x7FFE87D45B20
        public void set_highTwistLimit_Injected(){} // RVA: 0x7FFE87D45B80
        public void get_swing1Limit_Injected(){} // RVA: 0x7FFE87D45BE0
        public void set_swing1Limit_Injected(){} // RVA: 0x7FFE87D45C40
        public void get_swing2Limit_Injected(){} // RVA: 0x7FFE87D45CA0
        public void set_swing2Limit_Injected(){} // RVA: 0x7FFE87D45D00
    }

    public class CircleCollider2D : Collider2D
    {
        // ── Methods ──
        public void get_radius(){} // RVA: 0x7FFE87D292E0
        public void set_radius(){} // RVA: 0x7FFE87D29330
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class ClassLibraryInitializer : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE87C50A50
        public void InitStdErrWithHandle(){} // RVA: 0x7FFE87C63470
        public void InitAssemblyRedirections(){} // RVA: 0x7FFE87C63790
    }

    public class Cloth : Component
    {
        public float _useContinuousCollision; // 0x18
        public bool _selfCollision; // 0x1C
        public object field_2; // 0x8CD
        public object field_3; // 0x8CE
        public object field_4; // 0x8CF
        public object field_5; // 0x8D0
        public object field_6; // 0x8D1
        public object field_7; // 0x8D2
        public object field_8; // 0x8D3
        public object field_9; // 0x8D4
        public object field_10; // 0x8D5
        public object field_11; // 0x5590
        public object field_12; // 0xDE20
        public UnityEngine.Cloth field_13; // 0x6180
        public object field_14; // 0x8848
        public 0x7FFE83112540 field_15; // 0x6340
        public object field_16; // 0x6798
        public ?<...> field_17; // 0x5258
        public ?<...> field_18; // 0x9410
        public ?[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] field_19; // 0x6F48
        public object field_20; // 0x72F0
        public object field_21; // 0x9B58
        public object field_22;
        public object field_23; // 0x700
        public object field_24;
        public object field_25; // 0x5448
        public object field_26; // 0x356A

        // ── Methods ──
        public void get_vertices(){} // RVA: 0x7FFE87BF52D0
        public void get_normals(){} // RVA: 0x7FFE87BF5320
        public void get_coefficients(){} // RVA: 0x7FFE87BF5370
        public void set_coefficients(){} // RVA: 0x7FFE87BF53C0
        public void get_capsuleColliders(){} // RVA: 0x7FFE87BF5420
        public void set_capsuleColliders(){} // RVA: 0x7FFE87BF5470
        public void get_sphereColliders(){} // RVA: 0x7FFE87BF54D0
        public void set_sphereColliders(){} // RVA: 0x7FFE87BF5520
        public void get_sleepThreshold(){} // RVA: 0x7FFE87BF5580
        public void set_sleepThreshold(){} // RVA: 0x7FFE87BF55D0
        public void get_bendingStiffness(){} // RVA: 0x7FFE87BF5630
        public void set_bendingStiffness(){} // RVA: 0x7FFE87BF5680
        public void get_stretchingStiffness(){} // RVA: 0x7FFE87BF56E0
        public void set_stretchingStiffness(){} // RVA: 0x7FFE87BF5730
        public void get_damping(){} // RVA: 0x7FFE87BF5790
        public void set_damping(){} // RVA: 0x7FFE87BF57E0
        public void get_externalAcceleration(){} // RVA: 0x7FFE87BF5840
        public void set_externalAcceleration(){} // RVA: 0x7FFE87BF58B0
        public void get_randomAcceleration(){} // RVA: 0x7FFE87BF5910
        public void set_randomAcceleration(){} // RVA: 0x7FFE87BF5980
        public void get_useGravity(){} // RVA: 0x7FFE87BF59E0
        public void set_useGravity(){} // RVA: 0x7FFE87BF5A30
        public void get_enabled(){} // RVA: 0x7FFE87BF5A90
        public void set_enabled(){} // RVA: 0x7FFE87BF5AE0
        public void get_friction(){} // RVA: 0x7FFE87BF5B40
        public void set_friction(){} // RVA: 0x7FFE87BF5B90
        public void get_collisionMassScale(){} // RVA: 0x7FFE87BF5BF0
        public void set_collisionMassScale(){} // RVA: 0x7FFE87BF5C40
        public void get_enableContinuousCollision(){} // RVA: 0x7FFE87BF5CA0
        public void set_enableContinuousCollision(){} // RVA: 0x7FFE87BF5CF0
        public void get_useVirtualParticles(){} // RVA: 0x7FFE87BF5D50
        public void set_useVirtualParticles(){} // RVA: 0x7FFE87BF5DA0
        public void get_worldVelocityScale(){} // RVA: 0x7FFE87BF5E00
        public void set_worldVelocityScale(){} // RVA: 0x7FFE87BF5E50
        public void get_worldAccelerationScale(){} // RVA: 0x7FFE87BF5EB0
        public void set_worldAccelerationScale(){} // RVA: 0x7FFE87BF5F00
        public void get_clothSolverFrequency(){} // RVA: 0x7FFE87BF5F60
        public void set_clothSolverFrequency(){} // RVA: 0x7FFE87BF5FB0
        public void get_solverFrequency(){} // RVA: 0x7FFE87BF6010
        public void set_solverFrequency(){} // RVA: 0x7FFE87BF6070
        public void get_useTethers(){} // RVA: 0x7FFE87BF60F0
        public void set_useTethers(){} // RVA: 0x7FFE87BF6140
        public void get_stiffnessFrequency(){} // RVA: 0x7FFE87BF61A0
        public void set_stiffnessFrequency(){} // RVA: 0x7FFE87BF61F0
        public void get_selfCollisionDistance(){} // RVA: 0x7FFE87BF6250
        public void set_selfCollisionDistance(){} // RVA: 0x7FFE87BF62A0
        public void get_selfCollisionStiffness(){} // RVA: 0x7FFE87BF6300
        public void set_selfCollisionStiffness(){} // RVA: 0x7FFE87BF6350
        public void ClearTransformMotion(){} // RVA: 0x7FFE87BF63B0
        public void GetSelfAndInterCollisionIndices(){} // RVA: 0x7FFE87BF6400
        public void SetSelfAndInterCollisionIndices(){} // RVA: 0x7FFE87BF6460
        public void GetVirtualParticleIndices(){} // RVA: 0x7FFE87BF64C0
        public void SetVirtualParticleIndices(){} // RVA: 0x7FFE87BF6520
        public void GetVirtualParticleWeights(){} // RVA: 0x7FFE87BF6580
        public void SetVirtualParticleWeights(){} // RVA: 0x7FFE87BF65E0
        public void get_useContinuousCollision(){} // RVA: 0x7FFE810FFCF0
        public void set_useContinuousCollision(){} // RVA: 0x7FFE811164D0
        public void get_selfCollision(){} // RVA: 0x7FFE81116390
        public void SetEnabledFading(){} // RVA: 0x7FFE87BF66B0 | overloaded x2
        public void Raycast(){} // RVA: 0x7FFE87BF6720
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_externalAcceleration_Injected(){} // RVA: 0x7FFE87BF67C0
        public void set_externalAcceleration_Injected(){} // RVA: 0x7FFE87BF6820
        public void get_randomAcceleration_Injected(){} // RVA: 0x7FFE87BF6880
        public void set_randomAcceleration_Injected(){} // RVA: 0x7FFE87BF68E0
        public void Raycast_Injected(){} // RVA: 0x7FFE87BF6940
    }

    public class ClothSkinningCoefficient : ValueType
    {
    }

    public class ClothSphereColliderPair : ValueType
    {
        public UnityEngine.SphereCollider _first; // 0x10
        public UnityEngine.SphereCollider _second; // 0x18

        // ── Methods ──
        public void get_first(){} // RVA: 0x7FFE8284EF60
        public void get_second(){} // RVA: 0x7FFE826F4210
    }

    public class Collider : Component
    {
        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFE87D409C0
        public void set_enabled(){} // RVA: 0x7FFE87D40A10
        public void get_attachedRigidbody(){} // RVA: 0x7FFE87D40A70
        public void get_attachedArticulationBody(){} // RVA: 0x7FFE87D40AC0
        public void get_isTrigger(){} // RVA: 0x7FFE87D40B10
        public void set_isTrigger(){} // RVA: 0x7FFE87D40B60
        public void get_contactOffset(){} // RVA: 0x7FFE87D40BC0
        public void set_contactOffset(){} // RVA: 0x7FFE87D40C10
        public void ClosestPoint(){} // RVA: 0x7FFE87D40C70
        public void get_bounds(){} // RVA: 0x7FFE87D40CF0
        public void get_hasModifiableContacts(){} // RVA: 0x7FFE87D40D60
        public void set_hasModifiableContacts(){} // RVA: 0x7FFE87D40DB0
        public void get_providesContacts(){} // RVA: 0x7FFE87D40E10
        public void set_providesContacts(){} // RVA: 0x7FFE87D40E60
        public void get_layerOverridePriority(){} // RVA: 0x7FFE87D40EC0
        public void set_layerOverridePriority(){} // RVA: 0x7FFE87D40F10
        public void get_excludeLayers(){} // RVA: 0x7FFE87D40F70
        public void set_excludeLayers(){} // RVA: 0x7FFE87D40FD0
        public void get_includeLayers(){} // RVA: 0x7FFE87D41030
        public void set_includeLayers(){} // RVA: 0x7FFE87D41090
        public void get_sharedMaterial(){} // RVA: 0x7FFE87D410F0
        public void set_sharedMaterial(){} // RVA: 0x7FFE87D41140
        public void get_material(){} // RVA: 0x7FFE87D411A0
        public void set_material(){} // RVA: 0x7FFE87D411F0
        public void Raycast(){} // RVA: 0x7FFE87D412F0 | overloaded x2
        public void Internal_ClosestPointOnBounds(){} // RVA: 0x7FFE87D413E0
        public void ClosestPointOnBounds(){} // RVA: 0x7FFE87D41460
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void ClosestPoint_Injected(){} // RVA: 0x7FFE87D41550
        public void get_bounds_Injected(){} // RVA: 0x7FFE87D415C0
        public void get_excludeLayers_Injected(){} // RVA: 0x7FFE87D41620
        public void set_excludeLayers_Injected(){} // RVA: 0x7FFE87D41680
        public void get_includeLayers_Injected(){} // RVA: 0x7FFE87D416E0
        public void set_includeLayers_Injected(){} // RVA: 0x7FFE87D41740
        public void Raycast_Injected(){} // RVA: 0x7FFE87D417A0
        public void Internal_ClosestPointOnBounds_Injected(){} // RVA: 0x7FFE87D41830
    }

    public class Collider2D : Behaviour
    {
        // ── Methods ──
        public void get_density(){} // RVA: 0x7FFE87D25F70
        public void set_density(){} // RVA: 0x7FFE87D25FC0
        public void get_isTrigger(){} // RVA: 0x7FFE87D26020
        public void set_isTrigger(){} // RVA: 0x7FFE87D26070
        public void get_usedByEffector(){} // RVA: 0x7FFE87D260D0
        public void set_usedByEffector(){} // RVA: 0x7FFE87D26120
        public void get_usedByComposite(){} // RVA: 0x7FFE87D26180
        public void set_usedByComposite(){} // RVA: 0x7FFE87D261D0
        public void get_composite(){} // RVA: 0x7FFE87D26230
        public void get_offset(){} // RVA: 0x7FFE87D26280
        public void set_offset(){} // RVA: 0x7FFE87D262E0
        public void get_attachedRigidbody(){} // RVA: 0x7FFE87D26340
        public void get_shapeCount(){} // RVA: 0x7FFE87D26390
        public void CreateMesh(){} // RVA: 0x7FFE87D263E0
        public void GetShapeHash(){} // RVA: 0x7FFE87D26460
        public void GetShapes(){} // RVA: 0x7FFE87D26540 | overloaded x2
        public void GetShapes_Internal(){} // RVA: 0x7FFE87D266E0
        public void get_bounds(){} // RVA: 0x7FFE87D26760
        public void get_errorState(){} // RVA: 0x7FFE87D267D0
        public void get_sharedMaterial(){} // RVA: 0x7FFE87D26820
        public void set_sharedMaterial(){} // RVA: 0x7FFE87D26870
        public void get_layerOverridePriority(){} // RVA: 0x7FFE87D268D0
        public void set_layerOverridePriority(){} // RVA: 0x7FFE87D26920
        public void get_excludeLayers(){} // RVA: 0x7FFE87D26980
        public void set_excludeLayers(){} // RVA: 0x7FFE87D269E0
        public void get_includeLayers(){} // RVA: 0x7FFE87D26A40
        public void set_includeLayers(){} // RVA: 0x7FFE87D26AA0
        public void get_forceSendLayers(){} // RVA: 0x7FFE87D26B00
        public void set_forceSendLayers(){} // RVA: 0x7FFE87D26B60
        public void get_forceReceiveLayers(){} // RVA: 0x7FFE87D26BC0
        public void set_forceReceiveLayers(){} // RVA: 0x7FFE87D26C20
        public void get_contactCaptureLayers(){} // RVA: 0x7FFE87D26C80
        public void set_contactCaptureLayers(){} // RVA: 0x7FFE87D26CE0
        public void get_callbackLayers(){} // RVA: 0x7FFE87D26D40
        public void set_callbackLayers(){} // RVA: 0x7FFE87D26DA0
        public void get_friction(){} // RVA: 0x7FFE87D26E00
        public void get_bounciness(){} // RVA: 0x7FFE87D26E50
        public void IsTouching(){} // RVA: 0x7FFE87D26FF0 | overloaded x3
        public void IsTouching_OtherColliderWithFilter(){} // RVA: 0x7FFE87D26F80
        public void IsTouching_AnyColliderWithFilter(){} // RVA: 0x7FFE87D27060
        public void IsTouchingLayers(){} // RVA: 0x7FFE87D27120 | overloaded x2
        public void OverlapPoint(){} // RVA: 0x7FFE87D27180
        public void Distance(){} // RVA: 0x7FFE87D271E0
        public void OverlapCollider(){} // RVA: 0x7FFE87D0D790 | overloaded x2
        public void GetContacts(){} // RVA: 0x7FFE87D27720 | overloaded x8
        public void Cast(){} // RVA: 0x7FFE87D28070 | overloaded x7
        public void CastArray_Internal(){} // RVA: 0x7FFE87D27FD0
        public void CastList_Internal(){} // RVA: 0x7FFE87D28120
        public void Raycast(){} // RVA: 0x7FFE87D28830 | overloaded x8
        public void RaycastArray_Internal(){} // RVA: 0x7FFE87D287A0
        public void RaycastList_Internal(){} // RVA: 0x7FFE87D288D0
        public void ClosestPoint(){} // RVA: 0x7FFE87D28960
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_offset_Injected(){} // RVA: 0x7FFE87D289D0
        public void set_offset_Injected(){} // RVA: 0x7FFE87D28A30
        public void get_bounds_Injected(){} // RVA: 0x7FFE87D28A90
        public void get_excludeLayers_Injected(){} // RVA: 0x7FFE87D28AF0
        public void set_excludeLayers_Injected(){} // RVA: 0x7FFE87D28B50
        public void get_includeLayers_Injected(){} // RVA: 0x7FFE87D28BB0
        public void set_includeLayers_Injected(){} // RVA: 0x7FFE87D28C10
        public void get_forceSendLayers_Injected(){} // RVA: 0x7FFE87D28C70
        public void set_forceSendLayers_Injected(){} // RVA: 0x7FFE87D28CD0
        public void get_forceReceiveLayers_Injected(){} // RVA: 0x7FFE87D28D30
        public void set_forceReceiveLayers_Injected(){} // RVA: 0x7FFE87D28D90
        public void get_contactCaptureLayers_Injected(){} // RVA: 0x7FFE87D28DF0
        public void set_contactCaptureLayers_Injected(){} // RVA: 0x7FFE87D28E50
        public void get_callbackLayers_Injected(){} // RVA: 0x7FFE87D28EB0
        public void set_callbackLayers_Injected(){} // RVA: 0x7FFE87D28F10
        public void IsTouching_OtherColliderWithFilter_Injected(){} // RVA: 0x7FFE87D28F70
        public void IsTouching_AnyColliderWithFilter_Injected(){} // RVA: 0x7FFE87D28FE0
        public void OverlapPoint_Injected(){} // RVA: 0x7FFE87D29040
        public void CastArray_Internal_Injected(){} // RVA: 0x7FFE87D290A0
        public void CastList_Internal_Injected(){} // RVA: 0x7FFE87D29130
        public void RaycastArray_Internal_Injected(){} // RVA: 0x7FFE87D291C0
        public void RaycastList_Internal_Injected(){} // RVA: 0x7FFE87D29250
    }

    public class ColliderDistance2D : ValueType
    {
        public UnityEngine.Vector2 m_PointA; // 0x10
        public UnityEngine.Vector2 m_PointB; // 0x18
        public UnityEngine.Vector2 m_Normal; // 0x20
        public float m_Distance; // 0x28
        public int m_IsValid; // 0x2C
        public object field_5; // 0x13

        // ── Methods ──
        public void get_pointA(){} // RVA: 0x7FFE8348B260
        public void set_pointA(){} // RVA: 0x7FFE82889220
        public void get_pointB(){} // RVA: 0x7FFE87C0ED70
        public void set_pointB(){} // RVA: 0x7FFE82C72B10
        public void get_normal(){} // RVA: 0x7FFE87D201A0
        public void get_distance(){} // RVA: 0x7FFE87BBA360
        public void set_distance(){} // RVA: 0x7FFE811164D0
        public void get_isOverlapped(){} // RVA: 0x7FFE87D201C0
        public void get_isValid(){} // RVA: 0x7FFE87BBAB90
        public void set_isValid(){} // RVA: 0x7FFE87BBABA0
    }

    public class Collision : Object
    {
        public UnityEngine.ContactPairHeader m_Header; // 0x10
        public UnityEngine.ContactPair m_Pair; // 0x38
        public bool m_Flipped; // 0x60
        public UnityEngine.ContactPoint[] m_LegacyContacts; // 0x68
        public int m_BodyID; // 0x10
        public int m_OtherBodyID; // 0x14
        public UIntPtr m_StartPtr; // 0x18
        public uint m_NbPairs; // 0x20
        public 0x6669AA54 m_Flags; // 0x24
        public UnityEngine.Vector3 m_RelativeVelocity; // 0x28
        public object field_10; // 0x20

        // ── Methods ──
        public void get_impulse(){} // RVA: 0x7FFE81161FA0
        public void get_relativeVelocity(){} // RVA: 0x7FFE87D2FEF0
        public void get_rigidbody(){} // RVA: 0x7FFE87D2FF50
        public void get_articulationBody(){} // RVA: 0x7FFE87D2FFF0
        public void get_body(){} // RVA: 0x7FFE87D30090
        public void get_collider(){} // RVA: 0x7FFE87D300C0
        public void get_transform(){} // RVA: 0x7FFE87D300F0
        public void get_gameObject(){} // RVA: 0x7FFE87D30270
        public void set_Flipped(){} // RVA: 0x7FFE81124030
        public void get_contactCount(){} // RVA: 0x7FFE87D30410
        public void get_contacts(){} // RVA: 0x7FFE87D30420
        public void .ctor(){} // RVA: 0x7FFE87D305A0 | overloaded x2
        public void Reuse(){} // RVA: 0x7FFE87D30700
        public void GetContact(){} // RVA: 0x7FFE87D30790
        public void GetContacts(){} // RVA: 0x7FFE87D30AF0 | overloaded x2
    }

    public class Collision2D : Object
    {
        public int m_Collider; // 0x10
        public int m_OtherCollider; // 0x14
        public int m_Rigidbody; // 0x18
        public int m_OtherRigidbody; // 0x1C
        public UnityEngine.Vector2 m_RelativeVelocity; // 0x20
        public int m_Enabled; // 0x28
        public int m_ContactCount; // 0x2C
        public UnityEngine.ContactPoint2D[] m_ReusedContacts; // 0x30
        public UnityEngine.ContactPoint2D[] m_LegacyContacts; // 0x38
        public object field_9; // 0x43B8

        // ── Methods ──
        public void GetContacts_Internal(){} // RVA: 0x7FFE87D20830
        public void get_collider(){} // RVA: 0x7FFE87D20850
        public void get_otherCollider(){} // RVA: 0x7FFE87D20940
        public void get_rigidbody(){} // RVA: 0x7FFE87D20A30
        public void get_otherRigidbody(){} // RVA: 0x7FFE87D20AF0
        public void get_transform(){} // RVA: 0x7FFE87D20BB0
        public void get_gameObject(){} // RVA: 0x7FFE87D20D30
        public void get_relativeVelocity(){} // RVA: 0x7FFE87D20EB0
        public void get_enabled(){} // RVA: 0x7FFE87D20ED0
        public void get_contacts(){} // RVA: 0x7FFE87D20EE0
        public void get_contactCount(){} // RVA: 0x7FFE87BBD3B0
        public void GetContact(){} // RVA: 0x7FFE87D210A0
        public void GetContacts(){} // RVA: 0x7FFE87D21330 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Color : ValueType
    {
        public float r; // 0x10
        public float g; // 0x14
        public float b; // 0x18
        public float a; // 0x1C
        public object .ctor; // 0x938
        public object field_5; // 0xAF0
        public object field_6; // 0xCA8
        public object field_7; // 0xE60
        public object field_8; // 0x1018
        public object field_9; // 0x11D0
        public object field_10; // 0x60A0
        public void field_11;
        public object field_12; // 0x89D0
        public object .ctor; // 0xB40
        public object field_14; // 0x1B30
        public void field_15; // 0x1288

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C50D10 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE87C50D50 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE8340D5F0
        public void Equals(){} // RVA: 0x7FFE82AE64D0 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFE87C51040
        public void op_Subtraction(){} // RVA: 0x7FFE87C510A0
        public void op_Multiply(){} // RVA: 0x7FFE87C511B0 | overloaded x3
        public void op_Division(){} // RVA: 0x7FFE87C51200
        public void op_Equality(){} // RVA: 0x7FFE87C51220
        public void op_Inequality(){} // RVA: 0x7FFE87C51290
        public void Lerp(){} // RVA: 0x7FFE81147EC0
        public void LerpUnclamped(){} // RVA: 0x7FFE87C51300
        public void RGBMultiplied(){} // RVA: 0x7FFE87C51380
        public void get_red(){} // RVA: 0x7FFE81148260
        public void get_green(){} // RVA: 0x7FFE8111F5D0
        public void get_blue(){} // RVA: 0x7FFE8165CF80
        public void get_white(){} // RVA: 0x7FFE811711E0
        public void get_black(){} // RVA: 0x7FFE8111F950
        public void get_yellow(){} // RVA: 0x7FFE8111F590
        public void get_cyan(){} // RVA: 0x7FFE87C513D0
        public void get_magenta(){} // RVA: 0x7FFE812A0A40
        public void get_gray(){} // RVA: 0x7FFE8111FA50
        public void get_grey(){} // RVA: 0x7FFE8111FA50
        public void get_clear(){} // RVA: 0x7FFE815CF4B0
        public void get_grayscale(){} // RVA: 0x7FFE87C513E0
        public void get_linear(){} // RVA: 0x7FFE870CE850
        public void get_gamma(){} // RVA: 0x7FFE87C51420
        public void get_maxColorComponent(){} // RVA: 0x7FFE87C51570
        public void op_Implicit(){} // RVA: 0x7FFE87C51590 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFE86CAFEE0
        public void set_Item(){} // RVA: 0x7FFE87C515B0
        public void RGBToHSV(){} // RVA: 0x7FFE87C51680
        public void RGBToHSVHelper(){} // RVA: 0x7FFE87C51720
        public void HSVToRGB(){} // RVA: 0x7FFE87C51800 | overloaded x2
    }

    public class Color32 : ValueType
    {
        public int rgba; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE813DB7A0
        public void op_Implicit(){} // RVA: 0x7FFE87C51BF0 | overloaded x2
        public void Lerp(){} // RVA: 0x7FFE87C51C70
        public void LerpUnclamped(){} // RVA: 0x7FFE81BDC8F0
        public void get_Item(){} // RVA: 0x7FFE87C51D80
        public void set_Item(){} // RVA: 0x7FFE87C51E50
        public void ToString(){} // RVA: 0x7FFE87C51F40 | overloaded x3
    }

    public class ColorUsageAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C60560 | overloaded x2
    }

    public class ColorUtility : Object
    {
        // ── Methods ──
        public void DoTryParseHtmlColor(){} // RVA: 0x7FFE87C52180
        public void TryParseHtmlString(){} // RVA: 0x7FFE87C521E0
        public void ToHtmlStringRGB(){} // RVA: 0x7FFE87C522D0
        public void ToHtmlStringRGBA(){} // RVA: 0x7FFE87C524F0
    }

    public class CombineInstance : ValueType
    {
        public int m_MeshInstanceID; // 0x10
        public int m_SubMeshIndex; // 0x14
        public UnityEngine.Matrix4x4 m_Transform; // 0x18
        public UnityEngine.Vector4 m_LightmapScaleOffset; // 0x58
        public UnityEngine.Vector4 m_RealtimeLightmapScaleOffset; // 0x68

        // ── Methods ──
        public void get_mesh(){} // RVA: 0x7FFE87C3FFE0
        public void set_mesh(){} // RVA: 0x7FFE87C40030
        public void get_subMeshIndex(){} // RVA: 0x7FFE84D2D330
        public void set_subMeshIndex(){} // RVA: 0x7FFE826F4290
        public void get_transform(){} // RVA: 0x7FFE87C40120
        public void set_transform(){} // RVA: 0x7FFE87C40150
        public void get_lightmapScaleOffset(){} // RVA: 0x7FFE87C40170
        public void set_lightmapScaleOffset(){} // RVA: 0x7FFE81C1C640
        public void get_realtimeLightmapScaleOffset(){} // RVA: 0x7FFE87C40180
        public void set_realtimeLightmapScaleOffset(){} // RVA: 0x7FFE87C40190
    }

    public class Component : Object
    {
        // ── Methods ──
        public void get_transform(){} // RVA: 0x7FFE816315C0
        public void get_gameObject(){} // RVA: 0x7FFE81631490
        public void GetComponent(){} // RVA: 0x7FFE87C647A0 | overloaded x3
        public void GetComponentFastPath(){} // RVA: 0x7FFE87C64550
        public void TryGetComponent(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void GetComponentInChildren(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void GetComponentsInChildren(){} // RVA: 0x7FFE80E460A0 | overloaded x6
        public void GetComponentInParent(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void GetComponentsInParent(){} // RVA: 0x7FFE80E2E2E0 | overloaded x5
        public void GetComponents(){} // RVA: 0x7FFE80E2E2E0 | overloaded x4
        public void GetComponentsForListInternal(){} // RVA: 0x7FFE87C64C10
        public void get_tag(){} // RVA: 0x7FFE87C64C90
        public void set_tag(){} // RVA: 0x7FFE87C64D30
        public void GetComponentIndex(){} // RVA: 0x7FFE81463BC0
        public void CompareTag(){} // RVA: 0x7FFE87C64DE0
        public void SendMessageUpwards(){} // RVA: 0x7FFE87C64F10 | overloaded x2
        public void SendMessage(){} // RVA: 0x7FFE87C65050 | overloaded x4
        public void BroadcastMessage(){} // RVA: 0x7FFE87C65130 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class CompositeCollider2D : Collider2D
    {
        // ── Methods ──
        public void get_geometryType(){} // RVA: 0x7FFE87D2AA30
        public void set_geometryType(){} // RVA: 0x7FFE87D2AA80
        public void get_generationType(){} // RVA: 0x7FFE87D2AAE0
        public void set_generationType(){} // RVA: 0x7FFE87D2AB30
        public void get_useDelaunayMesh(){} // RVA: 0x7FFE87D2AB90
        public void set_useDelaunayMesh(){} // RVA: 0x7FFE87D2ABE0
        public void get_vertexDistance(){} // RVA: 0x7FFE87D2AC40
        public void set_vertexDistance(){} // RVA: 0x7FFE87D2AC90
        public void get_edgeRadius(){} // RVA: 0x7FFE87D2ACF0
        public void set_edgeRadius(){} // RVA: 0x7FFE87D2AD40
        public void get_offsetDistance(){} // RVA: 0x7FFE87D2ADA0
        public void set_offsetDistance(){} // RVA: 0x7FFE87D2ADF0
        public void GenerateGeometry(){} // RVA: 0x7FFE87D2AE50
        public void GetPathPointCount(){} // RVA: 0x7FFE87D2AEA0
        public void GetPathPointCount_Internal(){} // RVA: 0x7FFE87D2B010
        public void get_pathCount(){} // RVA: 0x7FFE87D2B070
        public void get_pointCount(){} // RVA: 0x7FFE87D2B0C0
        public void GetPath(){} // RVA: 0x7FFE87D2B350 | overloaded x2
        public void GetPathArray_Internal(){} // RVA: 0x7FFE87D2B2E0
        public void GetPathList_Internal(){} // RVA: 0x7FFE87D2B520
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class ComputeBuffer : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public object field_1; // 0x3478
        public object field_2; // 0x3630

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFE87C71860
        public void Dispose(){} // RVA: 0x7FFE87C719D0 | overloaded x2
        public void InitBuffer(){} // RVA: 0x7FFE87C71AB0
        public void DestroyBuffer(){} // RVA: 0x7FFE87C71B30
        public void .ctor(){} // RVA: 0x7FFE87C71BE0 | overloaded x3
        public void Release(){} // RVA: 0x7FFE87C71900
        public void IsValidBuffer(){} // RVA: 0x7FFE87C71E30
        public void IsValid(){} // RVA: 0x7FFE87C71E80
        public void get_count(){} // RVA: 0x7FFE87C71EF0
        public void get_stride(){} // RVA: 0x7FFE87C71F40
        public void SetData(){} // RVA: 0x7FFE87C72130 | overloaded x2
        public void InternalSetData(){} // RVA: 0x7FFE87C723D0
        public void GetData(){} // RVA: 0x7FFE87C72460
        public void InternalGetData(){} // RVA: 0x7FFE87C72630
        public void set_name(){} // RVA: 0x7FFE87C726C0
        public void SetName(){} // RVA: 0x7FFE87C726C0
        public void SetCounterValue(){} // RVA: 0x7FFE87C72720
        public void CopyCount(){} // RVA: 0x7FFE87C72780
    }

    public class ComputeShader : Object
    {
        // ── Methods ──
        public void FindKernel(){} // RVA: 0x7FFE87C727F0
        public void SetFloat(){} // RVA: 0x7FFE87C72850
        public void SetInt(){} // RVA: 0x7FFE87C728C0
        public void SetVector(){} // RVA: 0x7FFE87C72930
        public void SetMatrix(){} // RVA: 0x7FFE87C729A0
        public void SetVectorArray(){} // RVA: 0x7FFE87C72A10
        public void SetTexture(){} // RVA: 0x7FFE87C72D00 | overloaded x2
        public void Internal_SetBuffer(){} // RVA: 0x7FFE87C72B00
        public void SetBuffer(){} // RVA: 0x7FFE87C72B00
        public void GetKernelThreadGroupSizes(){} // RVA: 0x7FFE87C72B80
        public void Dispatch(){} // RVA: 0x7FFE87C72C00
        public void SetBool(){} // RVA: 0x7FFE87C72C80
        public void SetVector_Injected(){} // RVA: 0x7FFE87C72D90
        public void SetMatrix_Injected(){} // RVA: 0x7FFE87C72E00
    }

    public class ConfigurableJoint : Joint
    {
        // ── Methods ──
        public void get_secondaryAxis(){} // RVA: 0x7FFE87D45D60
        public void set_secondaryAxis(){} // RVA: 0x7FFE87D45DD0
        public void get_xMotion(){} // RVA: 0x7FFE87D45E30
        public void set_xMotion(){} // RVA: 0x7FFE87D45E80
        public void get_yMotion(){} // RVA: 0x7FFE87D45EE0
        public void set_yMotion(){} // RVA: 0x7FFE87D45F30
        public void get_zMotion(){} // RVA: 0x7FFE87D45F90
        public void set_zMotion(){} // RVA: 0x7FFE87D45FE0
        public void get_angularXMotion(){} // RVA: 0x7FFE87D46040
        public void set_angularXMotion(){} // RVA: 0x7FFE87D46090
        public void get_angularYMotion(){} // RVA: 0x7FFE87D460F0
        public void set_angularYMotion(){} // RVA: 0x7FFE87D46140
        public void get_angularZMotion(){} // RVA: 0x7FFE87D461A0
        public void set_angularZMotion(){} // RVA: 0x7FFE87D461F0
        public void get_linearLimitSpring(){} // RVA: 0x7FFE87D46250
        public void set_linearLimitSpring(){} // RVA: 0x7FFE87D462B0
        public void get_angularXLimitSpring(){} // RVA: 0x7FFE87D46310
        public void set_angularXLimitSpring(){} // RVA: 0x7FFE87D46370
        public void get_angularYZLimitSpring(){} // RVA: 0x7FFE87D463D0
        public void set_angularYZLimitSpring(){} // RVA: 0x7FFE87D46430
        public void get_linearLimit(){} // RVA: 0x7FFE87D46490
        public void set_linearLimit(){} // RVA: 0x7FFE87D46500
        public void get_lowAngularXLimit(){} // RVA: 0x7FFE87D46560
        public void set_lowAngularXLimit(){} // RVA: 0x7FFE87D465D0
        public void get_highAngularXLimit(){} // RVA: 0x7FFE87D46630
        public void set_highAngularXLimit(){} // RVA: 0x7FFE87D466A0
        public void get_angularYLimit(){} // RVA: 0x7FFE87D46700
        public void set_angularYLimit(){} // RVA: 0x7FFE87D46770
        public void get_angularZLimit(){} // RVA: 0x7FFE87D467D0
        public void set_angularZLimit(){} // RVA: 0x7FFE87D46840
        public void get_targetPosition(){} // RVA: 0x7FFE87D468A0
        public void set_targetPosition(){} // RVA: 0x7FFE87D46910
        public void get_targetVelocity(){} // RVA: 0x7FFE87D46970
        public void set_targetVelocity(){} // RVA: 0x7FFE87D469E0
        public void get_xDrive(){} // RVA: 0x7FFE87D46A40
        public void set_xDrive(){} // RVA: 0x7FFE87D46AB0
        public void get_yDrive(){} // RVA: 0x7FFE87D46B10
        public void set_yDrive(){} // RVA: 0x7FFE87D46B80
        public void get_zDrive(){} // RVA: 0x7FFE87D46BE0
        public void set_zDrive(){} // RVA: 0x7FFE87D46C50
        public void get_targetRotation(){} // RVA: 0x7FFE87D46CB0
        public void set_targetRotation(){} // RVA: 0x7FFE87D46D20
        public void get_targetAngularVelocity(){} // RVA: 0x7FFE87D46D80
        public void set_targetAngularVelocity(){} // RVA: 0x7FFE87D46DF0
        public void get_rotationDriveMode(){} // RVA: 0x7FFE87D46E50
        public void set_rotationDriveMode(){} // RVA: 0x7FFE87D46EA0
        public void get_angularXDrive(){} // RVA: 0x7FFE87D46F00
        public void set_angularXDrive(){} // RVA: 0x7FFE87D46F70
        public void get_angularYZDrive(){} // RVA: 0x7FFE87D46FD0
        public void set_angularYZDrive(){} // RVA: 0x7FFE87D47040
        public void get_slerpDrive(){} // RVA: 0x7FFE87D470A0
        public void set_slerpDrive(){} // RVA: 0x7FFE87D47110
        public void get_projectionMode(){} // RVA: 0x7FFE87D47170
        public void set_projectionMode(){} // RVA: 0x7FFE87D471C0
        public void get_projectionDistance(){} // RVA: 0x7FFE87D47220
        public void set_projectionDistance(){} // RVA: 0x7FFE87D47270
        public void get_projectionAngle(){} // RVA: 0x7FFE87D472D0
        public void set_projectionAngle(){} // RVA: 0x7FFE87D47320
        public void get_configuredInWorldSpace(){} // RVA: 0x7FFE87D47380
        public void set_configuredInWorldSpace(){} // RVA: 0x7FFE87D473D0
        public void get_swapBodies(){} // RVA: 0x7FFE87D47430
        public void set_swapBodies(){} // RVA: 0x7FFE87D47480
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_secondaryAxis_Injected(){} // RVA: 0x7FFE87D474E0
        public void set_secondaryAxis_Injected(){} // RVA: 0x7FFE87D47540
        public void get_linearLimitSpring_Injected(){} // RVA: 0x7FFE87D475A0
        public void set_linearLimitSpring_Injected(){} // RVA: 0x7FFE87D47600
        public void get_angularXLimitSpring_Injected(){} // RVA: 0x7FFE87D47660
        public void set_angularXLimitSpring_Injected(){} // RVA: 0x7FFE87D476C0
        public void get_angularYZLimitSpring_Injected(){} // RVA: 0x7FFE87D47720
        public void set_angularYZLimitSpring_Injected(){} // RVA: 0x7FFE87D47780
        public void get_linearLimit_Injected(){} // RVA: 0x7FFE87D477E0
        public void set_linearLimit_Injected(){} // RVA: 0x7FFE87D47840
        public void get_lowAngularXLimit_Injected(){} // RVA: 0x7FFE87D478A0
        public void set_lowAngularXLimit_Injected(){} // RVA: 0x7FFE87D47900
        public void get_highAngularXLimit_Injected(){} // RVA: 0x7FFE87D47960
        public void set_highAngularXLimit_Injected(){} // RVA: 0x7FFE87D479C0
        public void get_angularYLimit_Injected(){} // RVA: 0x7FFE87D47A20
        public void set_angularYLimit_Injected(){} // RVA: 0x7FFE87D47A80
        public void get_angularZLimit_Injected(){} // RVA: 0x7FFE87D47AE0
        public void set_angularZLimit_Injected(){} // RVA: 0x7FFE87D47B40
        public void get_targetPosition_Injected(){} // RVA: 0x7FFE87D47BA0
        public void set_targetPosition_Injected(){} // RVA: 0x7FFE87D47C00
        public void get_targetVelocity_Injected(){} // RVA: 0x7FFE87D47C60
        public void set_targetVelocity_Injected(){} // RVA: 0x7FFE87D47CC0
        public void get_xDrive_Injected(){} // RVA: 0x7FFE87D47D20
        public void set_xDrive_Injected(){} // RVA: 0x7FFE87D47D80
        public void get_yDrive_Injected(){} // RVA: 0x7FFE87D47DE0
        public void set_yDrive_Injected(){} // RVA: 0x7FFE87D47E40
        public void get_zDrive_Injected(){} // RVA: 0x7FFE87D47EA0
        public void set_zDrive_Injected(){} // RVA: 0x7FFE87D47F00
        public void get_targetRotation_Injected(){} // RVA: 0x7FFE87D47F60
        public void set_targetRotation_Injected(){} // RVA: 0x7FFE87D47FC0
        public void get_targetAngularVelocity_Injected(){} // RVA: 0x7FFE87D48020
        public void set_targetAngularVelocity_Injected(){} // RVA: 0x7FFE87D48080
        public void get_angularXDrive_Injected(){} // RVA: 0x7FFE87D480E0
        public void set_angularXDrive_Injected(){} // RVA: 0x7FFE87D48140
        public void get_angularYZDrive_Injected(){} // RVA: 0x7FFE87D481A0
        public void set_angularYZDrive_Injected(){} // RVA: 0x7FFE87D48200
        public void get_slerpDrive_Injected(){} // RVA: 0x7FFE87D48260
        public void set_slerpDrive_Injected(){} // RVA: 0x7FFE87D482C0
    }

    public class ConstantForce : Behaviour
    {
        // ── Methods ──
        public void get_force(){} // RVA: 0x7FFE87D430A0
        public void set_force(){} // RVA: 0x7FFE87D43110
        public void get_relativeForce(){} // RVA: 0x7FFE87D43170
        public void set_relativeForce(){} // RVA: 0x7FFE87D431E0
        public void get_torque(){} // RVA: 0x7FFE87D43240
        public void set_torque(){} // RVA: 0x7FFE87D432B0
        public void get_relativeTorque(){} // RVA: 0x7FFE87D43310
        public void set_relativeTorque(){} // RVA: 0x7FFE87D43380
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_force_Injected(){} // RVA: 0x7FFE87D433E0
        public void set_force_Injected(){} // RVA: 0x7FFE87D43440
        public void get_relativeForce_Injected(){} // RVA: 0x7FFE87D434A0
        public void set_relativeForce_Injected(){} // RVA: 0x7FFE87D43500
        public void get_torque_Injected(){} // RVA: 0x7FFE87D43560
        public void set_torque_Injected(){} // RVA: 0x7FFE87D435C0
        public void get_relativeTorque_Injected(){} // RVA: 0x7FFE87D43620
        public void set_relativeTorque_Injected(){} // RVA: 0x7FFE87D43680
    }

    public class ConstantForce2D : PhysicsUpdateBehaviour2D
    {
        // ── Methods ──
        public void get_force(){} // RVA: 0x7FFE87D2F740
        public void set_force(){} // RVA: 0x7FFE87D2F7A0
        public void get_relativeForce(){} // RVA: 0x7FFE87D2F800
        public void set_relativeForce(){} // RVA: 0x7FFE87D2F860
        public void get_torque(){} // RVA: 0x7FFE87D2F8C0
        public void set_torque(){} // RVA: 0x7FFE87D2F910
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_force_Injected(){} // RVA: 0x7FFE87D2F970
        public void set_force_Injected(){} // RVA: 0x7FFE87D2F9D0
        public void get_relativeForce_Injected(){} // RVA: 0x7FFE87D2FA30
        public void set_relativeForce_Injected(){} // RVA: 0x7FFE87D2FA90
    }

    public class ContactFilter2D : ValueType
    {
        public bool useTriggers; // 0x10

        // ── Methods ──
        public void NoFilter(){} // RVA: 0x7FFE87D201D0
        public void CheckConsistency(){} // RVA: 0x7FFE87D20220
        public void ClearLayerMask(){} // RVA: 0x7FFE87D20270
        public void SetLayerMask(){} // RVA: 0x7FFE87D20280
        public void ClearDepth(){} // RVA: 0x7FFE87D20290
        public void SetDepth(){} // RVA: 0x7FFE87D202A0
        public void ClearNormalAngle(){} // RVA: 0x7FFE87D20300
        public void SetNormalAngle(){} // RVA: 0x7FFE87D20310
        public void get_isFiltering(){} // RVA: 0x7FFE87D20370
        public void IsFilteringTrigger(){} // RVA: 0x7FFE87D203A0
        public void IsFilteringLayerMask(){} // RVA: 0x7FFE87D20420
        public void IsFilteringDepth(){} // RVA: 0x7FFE87D204B0
        public void IsFilteringNormalAngle(){} // RVA: 0x7FFE87D20630 | overloaded x2
        public void IsFilteringNormalAngleUsingAngle(){} // RVA: 0x7FFE87D20630
        public void CreateLegacyFilter(){} // RVA: 0x7FFE87D20690
        public void CheckConsistency_Injected(){} // RVA: 0x7FFE87D20220
        public void IsFilteringNormalAngle_Injected(){} // RVA: 0x7FFE87D207D0
        public void IsFilteringNormalAngleUsingAngle_Injected(){} // RVA: 0x7FFE87D20630
    }

    public class ContactPair : ValueType
    {
        public int m_ColliderID; // 0x10
        public int m_OtherColliderID; // 0x14
        public UIntPtr m_StartPtr; // 0x18
        public uint m_NbPoints; // 0x20
        public 0x6669AAAC m_Flags; // 0x24
        public 0x6669AB04 m_Events; // 0x26
        public UnityEngine.Vector3 m_ImpulseSum; // 0x28
        public object field_7; // 0xAD28
        public object field_8; // 0xAEE0

        // ── Methods ──
        public void get_ColliderInstanceID(){} // RVA: 0x7FFE826F4220
        public void get_OtherColliderInstanceID(){} // RVA: 0x7FFE826F42A0
        public void get_Collider(){} // RVA: 0x7FFE87D4B750
        public void get_OtherCollider(){} // RVA: 0x7FFE87D4B7F0
        public void get_ImpulseSum(){} // RVA: 0x7FFE850BAE00
        public void get_IsCollisionEnter(){} // RVA: 0x7FFE87D4B890
        public void get_IsCollisionExit(){} // RVA: 0x7FFE87D4B8A0
        public void get_IsCollisionStay(){} // RVA: 0x7FFE87D4B8B0
        public void get_HasRemovedCollider(){} // RVA: 0x7FFE87D4B6A0
        public void ExtractContacts(){} // RVA: 0x7FFE87D4B8C0
        public void ExtractContactsArray(){} // RVA: 0x7FFE87D4B930
        public void GetContactPoint_Internal(){} // RVA: 0x7FFE87D4B9A0
        public void ExtractContacts_Injected(){} // RVA: 0x7FFE87D4B8C0
        public void ExtractContactsArray_Injected(){} // RVA: 0x7FFE87D4B930
    }

    public class ContactPairHeader : ValueType
    {
        public int m_BodyID; // 0x10
        public int m_OtherBodyID; // 0x14
        public UIntPtr m_StartPtr; // 0x18

        // ── Methods ──
        public void get_Body(){} // RVA: 0x7FFE87D4B580
        public void get_OtherBody(){} // RVA: 0x7FFE87D4B610
        public void get_HasRemovedBody(){} // RVA: 0x7FFE87D4B6A0
        public void GetContactPair(){} // RVA: 0x7FFE87D4B6C0
        public void GetContactPair_Internal(){} // RVA: 0x7FFE87D4B6D0
    }

    public class ContactPairPoint : ValueType
    {
    }

    public class ContactPoint : ValueType
    {
        public UnityEngine.Vector3 m_Point; // 0x10
        public UnityEngine.Vector3 m_Normal; // 0x1C
        public UnityEngine.Vector3 m_Impulse; // 0x28
        public int m_ThisColliderInstanceID; // 0x34
        public int m_OtherColliderInstanceID; // 0x38
        public float m_Separation; // 0x3C

        // ── Methods ──
        public void get_point(){} // RVA: 0x7FFE87BBA310
        public void get_normal(){} // RVA: 0x7FFE87BBA330
        public void get_impulse(){} // RVA: 0x7FFE87BD9260
        public void get_thisCollider(){} // RVA: 0x7FFE87D48320
        public void get_otherCollider(){} // RVA: 0x7FFE87D483B0
        public void get_separation(){} // RVA: 0x7FFE87CE83B0
        public void .ctor(){} // RVA: 0x7FFE87D48440
    }

    public class ContactPoint2D : ValueType
    {
        public UnityEngine.Vector2 m_Point; // 0x10
        public UnityEngine.Vector2 m_Normal; // 0x18
        public UnityEngine.Vector2 m_RelativeVelocity; // 0x20
        public float m_Separation; // 0x28
        public float m_NormalImpulse; // 0x2C
        public float m_TangentImpulse; // 0x30
        public int m_Collider; // 0x34
        public int m_OtherCollider; // 0x38
        public int m_Rigidbody; // 0x3C
        public int m_OtherRigidbody; // 0x40
        public int m_Enabled; // 0x44

        // ── Methods ──
        public void get_point(){} // RVA: 0x7FFE8348B260
        public void get_normal(){} // RVA: 0x7FFE87C0ED70
        public void get_separation(){} // RVA: 0x7FFE87BBA360
        public void get_normalImpulse(){} // RVA: 0x7FFE87BBD370
        public void get_tangentImpulse(){} // RVA: 0x7FFE87BBABB0
        public void get_relativeVelocity(){} // RVA: 0x7FFE87D201A0
        public void get_collider(){} // RVA: 0x7FFE87D214D0
        public void get_otherCollider(){} // RVA: 0x7FFE87D215C0
        public void get_rigidbody(){} // RVA: 0x7FFE87D216B0
        public void get_otherRigidbody(){} // RVA: 0x7FFE87D21770
        public void get_enabled(){} // RVA: 0x7FFE87D21830
    }

    public class ContextMenu : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C62F10 | overloaded x3
    }

    public class ContextMenuItemAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
    }

    public class ControllerColliderHit : Object
    {
        public UnityEngine.CharacterController m_Controller; // 0x10
        public UnityEngine.Collider m_Collider; // 0x18
        public UnityEngine.Vector3 m_Point; // 0x20
        public UnityEngine.Vector3 m_Normal; // 0x2C
        public UnityEngine.Vector3 m_MoveDirection; // 0x38
        public float m_MoveLength; // 0x44
        public int m_Push; // 0x48
        public object field_7; // 0xF2C8
        public object field_8; // 0x2BE0

        // ── Methods ──
        public void get_controller(){} // RVA: 0x7FFE84022BE0
        public void get_collider(){} // RVA: 0x7FFE83BBC680
        public void get_rigidbody(){} // RVA: 0x7FFE87D2FD60
        public void get_gameObject(){} // RVA: 0x7FFE87D2FDC0
        public void get_transform(){} // RVA: 0x7FFE87D2FE20
        public void get_point(){} // RVA: 0x7FFE87D2FE80
        public void get_normal(){} // RVA: 0x7FFE87D2FEA0
        public void get_moveDirection(){} // RVA: 0x7FFE87D2FEC0
        public void get_moveLength(){} // RVA: 0x7FFE87D2FEE0
    }

    public class Coroutine : YieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Finalize(){} // RVA: 0x7FFE87C65150
        public void ReleaseCoroutine(){} // RVA: 0x7FFE87C651D0
    }

    public class CreateAssetMenuAttribute : Attribute
    {
        public string _menuName; // 0x10
        public string _fileName; // 0x18
        public int _order; // 0x20

        // ── Methods ──
        public void set_menuName(){} // RVA: 0x7FFE810FCE30
        public void set_fileName(){} // RVA: 0x7FFE81161E80
        public void set_order(){} // RVA: 0x7FFE8170B670
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Cubemap : Texture
    {
        // ── Methods ──
        public void get_format(){} // RVA: 0x7FFE87C44B20
        public void Internal_CreateImpl(){} // RVA: 0x7FFE87C44B70
        public void Internal_Create(){} // RVA: 0x7FFE87C44BF0
        public void ApplyImpl(){} // RVA: 0x7FFE87C44CE0
        public void get_isReadable(){} // RVA: 0x7FFE87C44D60
        public void SetPixelImpl(){} // RVA: 0x7FFE87C44DB0
        public void GetPixelImpl(){} // RVA: 0x7FFE87C44E50
        public void SmoothEdges(){} // RVA: 0x7FFE87C44F50 | overloaded x2
        public void GetPixels(){} // RVA: 0x7FFE87C45020 | overloaded x2
        public void SetPixels(){} // RVA: 0x7FFE87C45190 | overloaded x2
        public void SetPixelDataImplArray(){} // RVA: 0x7FFE87C45100
        public void get_streamingMipmaps(){} // RVA: 0x7FFE87C451B0
        public void get_streamingMipmapsPriority(){} // RVA: 0x7FFE87C45200
        public void get_requestedMipmapLevel(){} // RVA: 0x7FFE87C45250
        public void set_requestedMipmapLevel(){} // RVA: 0x7FFE87C452A0
        public void get_desiredMipmapLevel(){} // RVA: 0x7FFE87C45300
        public void get_loadingMipmapLevel(){} // RVA: 0x7FFE87C45350
        public void get_loadedMipmapLevel(){} // RVA: 0x7FFE87C453A0
        public void ClearRequestedMipmapLevel(){} // RVA: 0x7FFE87C453F0
        public void ValidateFormat(){} // RVA: 0x7FFE87C45560 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE87C45FA0 | overloaded x9
        public void CreateExternalTexture(){} // RVA: 0x7FFE87C45FD0
        public void SetPixelData(){}
        public void SetPixel(){} // RVA: 0x7FFE87C46140 | overloaded x2
        public void GetPixel(){} // RVA: 0x7FFE87C46260 | overloaded x2
        public void Apply(){} // RVA: 0x7FFE87C46430 | overloaded x3
        public void ValidateIsNotCrunched(){} // RVA: 0x7FFE87C46440
        public void SetPixelImpl_Injected(){} // RVA: 0x7FFE87C464A0
        public void GetPixelImpl_Injected(){} // RVA: 0x7FFE87C46520
    }

    public class CubemapArray : Texture
    {
        // ── Methods ──
        public void get_isReadable(){} // RVA: 0x7FFE87C48F00
        public void Internal_CreateImpl(){} // RVA: 0x7FFE87C48F50
        public void Internal_Create(){} // RVA: 0x7FFE87C48FD0
        public void .ctor(){} // RVA: 0x7FFE87C497B0 | overloaded x9
        public void ValidateIsNotCrunched(){} // RVA: 0x7FFE87C49870
    }

    public class CullingGroup : Object
    {
        // ── Methods ──
        public void SendEvents(){} // RVA: 0x7FFE87C050F0
    }

    public class CullingGroupEvent : ValueType
    {
    }

    public class Cursor : Object
    {
        // ── Methods ──
        public void SetCursor(){} // RVA: 0x7FFE87C4FBB0
        public void get_visible(){} // RVA: 0x7FFE87C4FC20
        public void set_visible(){} // RVA: 0x7FFE87C4FC70
        public void get_lockState(){} // RVA: 0x7FFE87C4FCC0
        public void set_lockState(){} // RVA: 0x7FFE87C4FD10
        public void SetCursor_Injected(){} // RVA: 0x7FFE87C4FD60
    }

    public class CustomRenderTexture : RenderTexture
    {
        // ── Methods ──
        public void Internal_CreateCustomRenderTexture(){} // RVA: 0x7FFE87C4D8E0
        public void TriggerUpdate(){} // RVA: 0x7FFE87C4D930
        public void Update(){} // RVA: 0x7FFE87C4DA40 | overloaded x2
        public void TriggerInitialization(){} // RVA: 0x7FFE87C4DA50
        public void Initialize(){} // RVA: 0x7FFE87C4DAA0
        public void ClearUpdateZones(){} // RVA: 0x7FFE87C4DB40
        public void get_material(){} // RVA: 0x7FFE87C4DB90
        public void set_material(){} // RVA: 0x7FFE87C4DBE0
        public void get_initializationMaterial(){} // RVA: 0x7FFE87C4DC40
        public void set_initializationMaterial(){} // RVA: 0x7FFE87C4DC90
        public void get_initializationTexture(){} // RVA: 0x7FFE87C4DCF0
        public void set_initializationTexture(){} // RVA: 0x7FFE87C4DD40
        public void GetUpdateZonesInternal(){} // RVA: 0x7FFE87C4DDA0
        public void GetUpdateZones(){} // RVA: 0x7FFE87C4DDA0
        public void SetUpdateZonesInternal(){} // RVA: 0x7FFE87C4DE00
        public void GetDoubleBufferRenderTexture(){} // RVA: 0x7FFE87C4DE60
        public void EnsureDoubleBufferConsistency(){} // RVA: 0x7FFE87C4DEB0
        public void SetUpdateZones(){} // RVA: 0x7FFE87C4DF00
        public void get_initializationSource(){} // RVA: 0x7FFE87C4DFB0
        public void set_initializationSource(){} // RVA: 0x7FFE87C4E000
        public void get_initializationColor(){} // RVA: 0x7FFE87C4E060
        public void set_initializationColor(){} // RVA: 0x7FFE87C4E0D0
        public void get_updateMode(){} // RVA: 0x7FFE87C4E130
        public void set_updateMode(){} // RVA: 0x7FFE87C4E180
        public void get_initializationMode(){} // RVA: 0x7FFE87C4E1E0
        public void set_initializationMode(){} // RVA: 0x7FFE87C4E230
        public void get_updateZoneSpace(){} // RVA: 0x7FFE87C4E290
        public void set_updateZoneSpace(){} // RVA: 0x7FFE87C4E2E0
        public void get_shaderPass(){} // RVA: 0x7FFE87C4E340
        public void set_shaderPass(){} // RVA: 0x7FFE87C4E390
        public void get_cubemapFaceMask(){} // RVA: 0x7FFE87C4E3F0
        public void set_cubemapFaceMask(){} // RVA: 0x7FFE87C4E440
        public void get_doubleBuffered(){} // RVA: 0x7FFE87C4E4A0
        public void set_doubleBuffered(){} // RVA: 0x7FFE87C4E4F0
        public void get_wrapUpdateZones(){} // RVA: 0x7FFE87C4E550
        public void set_wrapUpdateZones(){} // RVA: 0x7FFE87C4E5A0
        public void get_updatePeriod(){} // RVA: 0x7FFE87C4E600
        public void set_updatePeriod(){} // RVA: 0x7FFE87C4E650
        public void .ctor(){} // RVA: 0x7FFE87C4E8C0 | overloaded x5
        public void get_initializationColor_Injected(){} // RVA: 0x7FFE87C4EB00
        public void set_initializationColor_Injected(){} // RVA: 0x7FFE87C4EB60
    }

    public class CustomRenderTextureManager : Object
    {
        // ── Methods ──
        public void InvokeOnTextureLoaded_Internal(){} // RVA: 0x7FFE87C13770
        public void InvokeOnTextureUnloaded_Internal(){} // RVA: 0x7FFE87C137D0
        public void InvokeTriggerUpdate(){} // RVA: 0x7FFE87C13830
        public void InvokeTriggerInitialize(){} // RVA: 0x7FFE87C138A0
    }

    public class CustomRenderTextureUpdateZone : ValueType
    {
    }

    public class CustomYieldInstruction : Object
    {
        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x7FFE80E2F150
        public void get_Current(){} // RVA: 0x7FFE84A912C0
        public void MoveNext(){} // RVA: 0x7FFE82A336A0
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}