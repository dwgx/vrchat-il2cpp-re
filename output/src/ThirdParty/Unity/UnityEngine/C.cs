// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 100
// Methods: 454

namespace ThirdParty.Unity.UnityEngine
{
    public class Cache
    {
        public int m_Handle; // 0x10

        // ── Methods ──
        public void get_handle(){} // RVA: 0x67FD0D0
        public void GetHashCode(){} // RVA: 0x67FD0D0
        public void Equals(){} // RVA: 0x70BC7E0 | overloaded x2
        public void get_valid(){} // RVA: 0x70BC7F0
        public void Cache_IsValid(){} // RVA: 0x70BC840
        public void get_path(){} // RVA: 0x70BC890
        public void Cache_GetPath(){} // RVA: 0x70BC8E0
        public void set_maximumAvailableStorageSpace(){} // RVA: 0x70BC930
        public void Cache_SetMaximumDiskSpaceAvailable(){} // RVA: 0x70BC990
        public void get_spaceOccupied(){} // RVA: 0x70BC9F0
        public void Cache_GetCachingDiskSpaceUsed(){} // RVA: 0x70BCA40
    }

    public class CachedAssetBundle
    {
        public string m_Name; // 0x10
        public UnityEngine.Hash128 m_Hash; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x37C9BD0
        public void get_name(){} // RVA: 0x2738C50
        public void get_hash(){} // RVA: 0x70BC750
    }

    public class Caching
    {
        // ── Methods ──
        public void ClearCache(){} // RVA: 0x70BCAE0 | overloaded x2
        public void ClearCache_Int(){} // RVA: 0x70BCAE0
        public void ClearOtherCachedVersions(){} // RVA: 0x70BCB30
        public void ClearAllCachedVersions(){} // RVA: 0x70BCBF0
        public void ClearCachedVersions(){} // RVA: 0x70BCCB0
        public void IsVersionCached(){} // RVA: 0x70BCE10 | overloaded x2
        public void MarkAsUsed(){} // RVA: 0x70BCF70 | overloaded x2
        public void AddCache(){} // RVA: 0x70BD300 | overloaded x2
        public void GetCacheByPath(){} // RVA: 0x70BD370
        public void get_currentCacheForWriting(){} // RVA: 0x70BD3D0
        public void set_currentCacheForWriting(){} // RVA: 0x70BD430
        public void ClearCachedVersions_Injected(){} // RVA: 0x70BD480
        public void IsVersionCached_Injected(){} // RVA: 0x70BD4F0
        public void MarkAsUsed_Injected(){} // RVA: 0x70BD560
        public void AddCache_Injected(){} // RVA: 0x70BD5D0
        public void GetCacheByPath_Injected(){} // RVA: 0x70BD640
        public void get_currentCacheForWriting_Injected(){} // RVA: 0x70BD6A0
        public void set_currentCacheForWriting_Injected(){} // RVA: 0x70BD6F0
    }

    public class Camera
    {
        public float kMinAperture;
        public float kMaxAperture;
        public int kMinBladeCount;
        public int kMaxBladeCount;
        public CameraCallback onPreCull;
        public CameraCallback onPreRender; // 0x8
        public CameraCallback onPostRender; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_nearClipPlane(){} // RVA: 0x70BD740
        public void set_nearClipPlane(){} // RVA: 0x70BD790
        public void get_farClipPlane(){} // RVA: 0x70BD7F0
        public void set_farClipPlane(){} // RVA: 0x70BD840
        public void get_fieldOfView(){} // RVA: 0x70BD8A0
        public void set_fieldOfView(){} // RVA: 0x70BD8F0
        public void get_renderingPath(){} // RVA: 0x70BD950
        public void set_renderingPath(){} // RVA: 0x70BD9A0
        public void get_actualRenderingPath(){} // RVA: 0x70BDA00
        public void Reset(){} // RVA: 0x70BDA50
        public void get_allowHDR(){} // RVA: 0x70BDAA0
        public void set_allowHDR(){} // RVA: 0x70BDAF0
        public void get_allowMSAA(){} // RVA: 0x70BDB50
        public void set_allowMSAA(){} // RVA: 0x70BDBA0
        public void get_allowDynamicResolution(){} // RVA: 0x70BDC00
        public void set_allowDynamicResolution(){} // RVA: 0x70BDC50
        public void get_forceIntoRenderTexture(){} // RVA: 0x70BDCB0
        public void set_forceIntoRenderTexture(){} // RVA: 0x70BDD00
        public void get_orthographicSize(){} // RVA: 0x70BDD60
        public void set_orthographicSize(){} // RVA: 0x70BDDB0
        public void get_orthographic(){} // RVA: 0x70BDE10
        public void set_orthographic(){} // RVA: 0x70BDE60
        public void get_opaqueSortMode(){} // RVA: 0x70BDEC0
        public void set_opaqueSortMode(){} // RVA: 0x70BDF10
        public void get_transparencySortMode(){} // RVA: 0x70BDF70
        public void set_transparencySortMode(){} // RVA: 0x70BDFC0
        public void get_transparencySortAxis(){} // RVA: 0x70BE020
        public void set_transparencySortAxis(){} // RVA: 0x70BE090
        public void ResetTransparencySortSettings(){} // RVA: 0x70BE0F0
        public void get_depth(){} // RVA: 0x70BE140
        public void set_depth(){} // RVA: 0x70BE190
        public void get_aspect(){} // RVA: 0x70BE1F0
        public void set_aspect(){} // RVA: 0x70BE240
        public void ResetAspect(){} // RVA: 0x70BE2A0
        public void get_velocity(){} // RVA: 0x70BE2F0
        public void get_cullingMask(){} // RVA: 0x70BE360
        public void set_cullingMask(){} // RVA: 0x70BE3B0
        public void get_eventMask(){} // RVA: 0x70BE410
        public void set_eventMask(){} // RVA: 0x70BE460
        public void get_layerCullSpherical(){} // RVA: 0x70BE4C0
        public void set_layerCullSpherical(){} // RVA: 0x70BE510
        public void get_cameraType(){} // RVA: 0x70BE570
        public void set_cameraType(){} // RVA: 0x70BE5C0
        public void get_skyboxMaterial(){} // RVA: 0x70BE620
        public void get_overrideSceneCullingMask(){} // RVA: 0x70BE670
        public void set_overrideSceneCullingMask(){} // RVA: 0x70BE6C0
        public void get_sceneCullingMask(){} // RVA: 0x70BE720
        public void GetLayerCullDistances(){} // RVA: 0x70BE770
        public void SetLayerCullDistances(){} // RVA: 0x70BE7C0
        public void get_layerCullDistances(){} // RVA: 0x70BE770
        public void set_layerCullDistances(){} // RVA: 0x70BE820
        public void get_PreviewCullingLayer(){} // RVA: 0x70BE8E0
        public void get_useOcclusionCulling(){} // RVA: 0x70BE8F0
        public void set_useOcclusionCulling(){} // RVA: 0x70BE940
        public void get_cullingMatrix(){} // RVA: 0x70BE9A0
        public void set_cullingMatrix(){} // RVA: 0x70BEA20
        public void ResetCullingMatrix(){} // RVA: 0x70BEA80
        public void get_backgroundColor(){} // RVA: 0x70BEAD0
        public void set_backgroundColor(){} // RVA: 0x70BEB40
        public void get_clearFlags(){} // RVA: 0x70BEBA0
        public void set_clearFlags(){} // RVA: 0x70BEBF0
        public void get_depthTextureMode(){} // RVA: 0x70BEC50
        public void set_depthTextureMode(){} // RVA: 0x70BECA0
        public void get_clearStencilAfterLightingPass(){} // RVA: 0x70BED00
        public void set_clearStencilAfterLightingPass(){} // RVA: 0x70BED50
        public void SetReplacementShader(){} // RVA: 0x70BEDB0
        public void ResetReplacementShader(){} // RVA: 0x70BEE20
        public void get_projectionMatrixMode(){} // RVA: 0x70BEE70
        public void get_usePhysicalProperties(){} // RVA: 0x70BEEC0
        public void set_usePhysicalProperties(){} // RVA: 0x70BEF10
        public void get_iso(){} // RVA: 0x70BEF70
        public void set_iso(){} // RVA: 0x70BEFC0
        public void get_shutterSpeed(){} // RVA: 0x70BF020
        public void set_shutterSpeed(){} // RVA: 0x70BF070
        public void get_aperture(){} // RVA: 0x70BF0D0
        public void set_aperture(){} // RVA: 0x70BF120
        public void get_focusDistance(){} // RVA: 0x70BF180
        public void set_focusDistance(){} // RVA: 0x70BF1D0
        public void get_focalLength(){} // RVA: 0x70BF230
        public void set_focalLength(){} // RVA: 0x70BF280
        public void get_bladeCount(){} // RVA: 0x70BF2E0
        public void set_bladeCount(){} // RVA: 0x70BF330
        public void get_curvature(){} // RVA: 0x70BF390
        public void set_curvature(){} // RVA: 0x70BF3F0
        public void get_barrelClipping(){} // RVA: 0x70BF450
        public void set_barrelClipping(){} // RVA: 0x70BF4A0
        public void get_anamorphism(){} // RVA: 0x70BF500
        public void set_anamorphism(){} // RVA: 0x70BF550
        public void get_sensorSize(){} // RVA: 0x70BF5B0
        public void set_sensorSize(){} // RVA: 0x70BF610
        public void get_lensShift(){} // RVA: 0x70BF670
        public void set_lensShift(){} // RVA: 0x70BF6D0
        public void get_gateFit(){} // RVA: 0x70BF730
        public void set_gateFit(){} // RVA: 0x70BF780
        public void GetGateFittedFieldOfView(){} // RVA: 0x70BF7E0
        public void GetGateFittedLensShift(){} // RVA: 0x70BF830
        public void GetLocalSpaceAim(){} // RVA: 0x70BF890
        public void get_rect(){} // RVA: 0x70BF900
        public void set_rect(){} // RVA: 0x70BF970
        public void get_pixelRect(){} // RVA: 0x70BF9D0
        public void set_pixelRect(){} // RVA: 0x70BFA40
        public void get_pixelWidth(){} // RVA: 0x70BFAA0
        public void get_pixelHeight(){} // RVA: 0x70BFAF0
        public void get_scaledPixelWidth(){} // RVA: 0x70BFB40
        public void get_scaledPixelHeight(){} // RVA: 0x70BFB90
        public void get_targetTexture(){} // RVA: 0x70BFBE0
        public void set_targetTexture(){} // RVA: 0x70BFC30
        public void get_activeTexture(){} // RVA: 0x70BFC90
        public void get_targetDisplay(){} // RVA: 0x70BFCE0
        public void set_targetDisplay(){} // RVA: 0x70BFD30
        public void SetTargetBuffersImpl(){} // RVA: 0x70BFD90
        public void SetTargetBuffers(){} // RVA: 0x70BFEE0 | overloaded x2
        public void SetTargetBuffersMRTImpl(){} // RVA: 0x70BFE70
        public void GetCameraBufferWarnings(){} // RVA: 0x70BFF50
        public void get_cameraToWorldMatrix(){} // RVA: 0x70BFFA0
        public void get_worldToCameraMatrix(){} // RVA: 0x70C0020
        public void set_worldToCameraMatrix(){} // RVA: 0x70C00A0
        public void get_projectionMatrix(){} // RVA: 0x70C0100
        public void set_projectionMatrix(){} // RVA: 0x70C0180
        public void get_nonJitteredProjectionMatrix(){} // RVA: 0x70C01E0
        public void set_nonJitteredProjectionMatrix(){} // RVA: 0x70C0260
        public void get_useJitteredProjectionMatrixForTransparentRendering(){} // RVA: 0x70C02C0
        public void set_useJitteredProjectionMatrixForTransparentRendering(){} // RVA: 0x70C0310
        public void get_previousViewProjectionMatrix(){} // RVA: 0x70C0370
        public void ResetWorldToCameraMatrix(){} // RVA: 0x70C03F0
        public void ResetProjectionMatrix(){} // RVA: 0x70C0440
        public void CalculateObliqueMatrix(){} // RVA: 0x70C0490
        public void WorldToScreenPoint(){} // RVA: 0x70C0760 | overloaded x2
        public void WorldToViewportPoint(){} // RVA: 0x70C0810 | overloaded x2
        public void ViewportToWorldPoint(){} // RVA: 0x70C08C0 | overloaded x2
        public void ScreenToWorldPoint(){} // RVA: 0x70C0970 | overloaded x2
        public void ScreenToViewportPoint(){} // RVA: 0x70C0A20
        public void ViewportToScreenPoint(){} // RVA: 0x70C0AA0
        public void GetFrustumPlaneSizeAt(){} // RVA: 0x70C0B20
        public void ViewportPointToRay(){} // RVA: 0x70C0CF0 | overloaded x3
        public void ScreenPointToRay(){} // RVA: 0x70C0F10 | overloaded x3
        public void CalculateFrustumCornersInternal(){} // RVA: 0x70C0FD0
        public void CalculateFrustumCorners(){} // RVA: 0x70C1060
        public void CalculateProjectionMatrixFromPhysicalPropertiesInternal(){} // RVA: 0x70C11B0
        public void CalculateProjectionMatrixFromPhysicalProperties(){} // RVA: 0x70C1260
        public void FocalLengthToFieldOfView(){} // RVA: 0x70C1310
        public void FieldOfViewToFocalLength(){} // RVA: 0x70C1380
        public void HorizontalToVerticalFieldOfView(){} // RVA: 0x70C13F0
        public void VerticalToHorizontalFieldOfView(){} // RVA: 0x70C1460
        public void get_main(){} // RVA: 0xB2CC50
        public void get_current(){} // RVA: 0x70C14D0
        public void get_scene(){} // RVA: 0x70C1520
        public void set_scene(){} // RVA: 0x70C1580
        public void get_stereoEnabled(){} // RVA: 0x70C15E0
        public void get_stereoSeparation(){} // RVA: 0x70C1630
        public void set_stereoSeparation(){} // RVA: 0x70C1680
        public void get_stereoConvergence(){} // RVA: 0x70C16E0
        public void set_stereoConvergence(){} // RVA: 0x70C1730
        public void get_areVRStereoViewMatricesWithinSingleCullTolerance(){} // RVA: 0x70C1790
        public void get_stereoTargetEye(){} // RVA: 0x70C17E0
        public void set_stereoTargetEye(){} // RVA: 0x70C1830
        public void get_stereoActiveEye(){} // RVA: 0x70C1890
        public void GetStereoNonJitteredProjectionMatrix(){} // RVA: 0x70C18E0
        public void GetStereoViewMatrix(){} // RVA: 0x70C1970
        public void CopyStereoDeviceProjectionMatrixToNonJittered(){} // RVA: 0x70C1A00
        public void GetStereoProjectionMatrix(){} // RVA: 0x70C1A60
        public void SetStereoProjectionMatrix(){} // RVA: 0x70C1AF0
        public void ResetStereoProjectionMatrices(){} // RVA: 0x70C1B60
        public void SetStereoViewMatrix(){} // RVA: 0x70C1BB0
        public void ResetStereoViewMatrices(){} // RVA: 0x70C1C20
        public void GetAllCamerasCount(){} // RVA: 0x70C1C70
        public void GetAllCamerasImpl(){} // RVA: 0x70C1CC0
        public void get_allCamerasCount(){} // RVA: 0x70C1C70
        public void get_allCameras(){} // RVA: 0x70C1D10
        public void GetAllCameras(){} // RVA: 0x70C1DE0
        public void RenderToCubemapImpl(){} // RVA: 0x70C1F00
        public void RenderToCubemap(){} // RVA: 0x70C2040 | overloaded x5
        public void GetFilterMode(){} // RVA: 0x70C1FF0
        public void get_sceneViewFilterMode(){} // RVA: 0x70C1FF0
        public void RenderToCubemapEyeImpl(){} // RVA: 0x70C2040
        public void Render(){} // RVA: 0x70C20C0
        public void RenderWithShader(){} // RVA: 0x70C2110
        public void RenderDontRestore(){} // RVA: 0x70C2180
        public void SubmitRenderRequests(){} // RVA: 0x70C21D0
        public void SubmitRenderRequest(){} // RVA: 0x283FA0
        public void SubmitRenderRequestsInternal(){} // RVA: 0x70C2380
        public void SubmitBuiltInObjectIDRenderRequest(){} // RVA: 0x70C23E0
        public void SetupCurrent(){} // RVA: 0x70C2470
        public void CopyFrom(){} // RVA: 0x70C24C0
        public void get_commandBufferCount(){} // RVA: 0x70C2520
        public void RemoveCommandBuffers(){} // RVA: 0x70C2570
        public void RemoveAllCommandBuffers(){} // RVA: 0x70C25D0
        public void AddCommandBufferImpl(){} // RVA: 0x70C2620
        public void AddCommandBufferAsyncImpl(){} // RVA: 0x70C2690
        public void RemoveCommandBufferImpl(){} // RVA: 0x70C2710
        public void AddCommandBuffer(){} // RVA: 0x70C2780
        public void AddCommandBufferAsync(){} // RVA: 0x70C28E0
        public void RemoveCommandBuffer(){} // RVA: 0x70C2A50
        public void GetCommandBuffers(){} // RVA: 0x70C2BB0
        public void FireOnPreCull(){} // RVA: 0x70C2C10
        public void FireOnPreRender(){} // RVA: 0x70C2C70
        public void FireOnPostRender(){} // RVA: 0x70C2CD0
        public void OnlyUsedForTesting1(){} // RVA: 0x2DD310
        public void OnlyUsedForTesting2(){} // RVA: 0x2DD310
        public void TryGetCullingParameters(){} // RVA: 0x70C2D60 | overloaded x2
        public void GetCullingParameters_Internal(){} // RVA: 0x70C2D80
        public void get_transparencySortAxis_Injected(){} // RVA: 0x70C2E00
        public void set_transparencySortAxis_Injected(){} // RVA: 0x70C2E60
        public void get_velocity_Injected(){} // RVA: 0x70C2EC0
        public void get_cullingMatrix_Injected(){} // RVA: 0x70C2F20
        public void set_cullingMatrix_Injected(){} // RVA: 0x70C2F80
        public void get_backgroundColor_Injected(){} // RVA: 0x70C2FE0
        public void set_backgroundColor_Injected(){} // RVA: 0x70C3040
        public void get_curvature_Injected(){} // RVA: 0x70C30A0
        public void set_curvature_Injected(){} // RVA: 0x70C3100
        public void get_sensorSize_Injected(){} // RVA: 0x70C3160
        public void set_sensorSize_Injected(){} // RVA: 0x70C31C0
        public void get_lensShift_Injected(){} // RVA: 0x70C3220
        public void set_lensShift_Injected(){} // RVA: 0x70C3280
        public void GetGateFittedLensShift_Injected(){} // RVA: 0x70C32E0
        public void GetLocalSpaceAim_Injected(){} // RVA: 0x70C3340
        public void get_rect_Injected(){} // RVA: 0x70C33A0
        public void set_rect_Injected(){} // RVA: 0x70C3400
        public void get_pixelRect_Injected(){} // RVA: 0x70C3460
        public void set_pixelRect_Injected(){} // RVA: 0x70C34C0
        public void SetTargetBuffersImpl_Injected(){} // RVA: 0x70C3520
        public void SetTargetBuffersMRTImpl_Injected(){} // RVA: 0x70C3590
        public void get_cameraToWorldMatrix_Injected(){} // RVA: 0x70C3600
        public void get_worldToCameraMatrix_Injected(){} // RVA: 0x70C3660
        public void set_worldToCameraMatrix_Injected(){} // RVA: 0x70C36C0
        public void get_projectionMatrix_Injected(){} // RVA: 0x70C3720
        public void set_projectionMatrix_Injected(){} // RVA: 0x70C3780
        public void get_nonJitteredProjectionMatrix_Injected(){} // RVA: 0x70C37E0
        public void set_nonJitteredProjectionMatrix_Injected(){} // RVA: 0x70C3840
        public void get_previousViewProjectionMatrix_Injected(){} // RVA: 0x70C38A0
        public void CalculateObliqueMatrix_Injected(){} // RVA: 0x70C3900
        public void WorldToScreenPoint_Injected(){} // RVA: 0x70C3970
        public void WorldToViewportPoint_Injected(){} // RVA: 0x70C39F0
        public void ViewportToWorldPoint_Injected(){} // RVA: 0x70C3A70
        public void ScreenToWorldPoint_Injected(){} // RVA: 0x70C3AF0
        public void ScreenToViewportPoint_Injected(){} // RVA: 0x70C3B70
        public void ViewportToScreenPoint_Injected(){} // RVA: 0x70C3BE0
        public void GetFrustumPlaneSizeAt_Injected(){} // RVA: 0x70C3C50
        public void ViewportPointToRay_Injected(){} // RVA: 0x70C3CC0
        public void ScreenPointToRay_Injected(){} // RVA: 0x70C3D40
        public void CalculateFrustumCornersInternal_Injected(){} // RVA: 0x70C3DC0
        public void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(){} // RVA: 0x70C3E50
        public void get_scene_Injected(){} // RVA: 0x70C3EE0
        public void set_scene_Injected(){} // RVA: 0x70C3F40
        public void GetStereoNonJitteredProjectionMatrix_Injected(){} // RVA: 0x70C3FA0
        public void GetStereoViewMatrix_Injected(){} // RVA: 0x70C4010
        public void GetStereoProjectionMatrix_Injected(){} // RVA: 0x70C4080
        public void SetStereoProjectionMatrix_Injected(){} // RVA: 0x70C40F0
        public void SetStereoViewMatrix_Injected(){} // RVA: 0x70C4160
    }

    public class CameraRaycastHelper
    {
        // ── Methods ──
        public void RaycastTry(){} // RVA: 0x71A8250
        public void RaycastTry2D(){} // RVA: 0x71A82D0
        public void RaycastTry_Injected(){} // RVA: 0x71A8350
        public void RaycastTry2D_Injected(){} // RVA: 0x71A83D0
    }

    public class Canvas
    {
        public WillRenderCanvases preWillRenderCanvases;
        public WillRenderCanvases willRenderCanvases; // 0x8
        public System.Action`1<int> <externBeginRenderOverlays>k__BackingField; // 0x10
        public System.Action`2<int,int> <externRenderOverlaysBefore>k__BackingField; // 0x18
        public System.Action`1<int> <externEndRenderOverlays>k__BackingField; // 0x20

        // ── Methods ──
        public void add_preWillRenderCanvases(){} // RVA: 0x749FDA0
        public void remove_preWillRenderCanvases(){} // RVA: 0x749FEB0
        public void add_willRenderCanvases(){} // RVA: 0x749FFC0
        public void remove_willRenderCanvases(){} // RVA: 0x74A00D0
        public void get_renderMode(){} // RVA: 0x74A01E0
        public void set_renderMode(){} // RVA: 0x74A0230
        public void get_isRootCanvas(){} // RVA: 0x74A0290
        public void get_pixelRect(){} // RVA: 0x74A02E0
        public void get_scaleFactor(){} // RVA: 0x74A0350
        public void set_scaleFactor(){} // RVA: 0x74A03A0
        public void get_referencePixelsPerUnit(){} // RVA: 0x74A0400
        public void set_referencePixelsPerUnit(){} // RVA: 0x74A0450
        public void get_overridePixelPerfect(){} // RVA: 0x74A04B0
        public void set_overridePixelPerfect(){} // RVA: 0x74A0500
        public void get_vertexColorAlwaysGammaSpace(){} // RVA: 0x74A0560
        public void set_vertexColorAlwaysGammaSpace(){} // RVA: 0x74A05B0
        public void get_pixelPerfect(){} // RVA: 0x74A0610
        public void set_pixelPerfect(){} // RVA: 0x74A0660
        public void get_planeDistance(){} // RVA: 0x74A06C0
        public void set_planeDistance(){} // RVA: 0x74A0710
        public void get_renderOrder(){} // RVA: 0x74A0770
        public void get_overrideSorting(){} // RVA: 0x74A07C0
        public void set_overrideSorting(){} // RVA: 0x74A0810
        public void get_sortingOrder(){} // RVA: 0x74A0870
        public void set_sortingOrder(){} // RVA: 0x74A08C0
        public void get_targetDisplay(){} // RVA: 0x74A0920
        public void set_targetDisplay(){} // RVA: 0x74A0970
        public void get_sortingLayerID(){} // RVA: 0x74A09D0
        public void set_sortingLayerID(){} // RVA: 0x74A0A20
        public void get_cachedSortingLayerValue(){} // RVA: 0x74A0A80
        public void get_additionalShaderChannels(){} // RVA: 0x74A0AD0
        public void set_additionalShaderChannels(){} // RVA: 0x74A0B20
        public void get_sortingLayerName(){} // RVA: 0x74A0B80
        public void set_sortingLayerName(){} // RVA: 0x74A0BD0
        public void get_rootCanvas(){} // RVA: 0x74A0C30
        public void get_renderingDisplaySize(){} // RVA: 0x74A0C80
        public void get_updateRectTransformForStandalone(){} // RVA: 0x74A0CE0
        public void set_updateRectTransformForStandalone(){} // RVA: 0x74A0D30
        public void get_externBeginRenderOverlays(){} // RVA: 0x74A0D90
        public void set_externBeginRenderOverlays(){} // RVA: 0x74A0DD0
        public void get_externRenderOverlaysBefore(){} // RVA: 0x74A0E70
        public void set_externRenderOverlaysBefore(){} // RVA: 0x74A0EB0
        public void get_externEndRenderOverlays(){} // RVA: 0x74A0F50
        public void set_externEndRenderOverlays(){} // RVA: 0x74A0F90
        public void SetExternalCanvasEnabled(){} // RVA: 0x74A1030
        public void get_worldCamera(){} // RVA: 0x74A1080
        public void set_worldCamera(){} // RVA: 0x74A10D0
        public void get_normalizedSortingGridSize(){} // RVA: 0x74A1130
        public void set_normalizedSortingGridSize(){} // RVA: 0x74A1180
        public void get_sortingGridNormalizedSize(){} // RVA: 0x74A11E0
        public void set_sortingGridNormalizedSize(){} // RVA: 0x74A1230
        public void GetDefaultCanvasTextMaterial(){} // RVA: 0x74A1290
        public void GetDefaultCanvasMaterial(){} // RVA: 0x74A12E0
        public void GetETC1SupportedCanvasMaterial(){} // RVA: 0x74A1330
        public void UpdateCanvasRectTransform(){} // RVA: 0x74A1380
        public void ForceUpdateCanvases(){} // RVA: 0x74A13E0
        public void SendPreWillRenderCanvases(){} // RVA: 0x74A1480
        public void SendWillRenderCanvases(){} // RVA: 0x74A14E0
        public void BeginRenderExtraOverlays(){} // RVA: 0x74A1540
        public void RenderExtraOverlaysBefore(){} // RVA: 0x74A15A0
        public void EndRenderExtraOverlays(){} // RVA: 0x74A1610
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_pixelRect_Injected(){} // RVA: 0x74A1670
        public void get_renderingDisplaySize_Injected(){} // RVA: 0x74A16D0
    }

    public class CanvasGroup
    {
        // ── Methods ──
        public void get_alpha(){} // RVA: 0x749B9F0
        public void set_alpha(){} // RVA: 0x749BA40
        public void get_interactable(){} // RVA: 0x749BAA0
        public void set_interactable(){} // RVA: 0x749BAF0
        public void get_blocksRaycasts(){} // RVA: 0x749BB50
        public void set_blocksRaycasts(){} // RVA: 0x749BBA0
        public void get_ignoreParentGroups(){} // RVA: 0x749BC00
        public void set_ignoreParentGroups(){} // RVA: 0x749BC50
        public void IsRaycastLocationValid(){} // RVA: 0x749BB50
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class CanvasRenderer
    {
        public bool velocity; // 0x18

        // ── Methods ──
        public void get_hasPopInstruction(){} // RVA: 0x749BCB0
        public void set_hasPopInstruction(){} // RVA: 0x749BD00
        public void get_materialCount(){} // RVA: 0x749BD60
        public void set_materialCount(){} // RVA: 0x749BDB0
        public void get_popMaterialCount(){} // RVA: 0x749BE10
        public void set_popMaterialCount(){} // RVA: 0x749BE60
        public void get_absoluteDepth(){} // RVA: 0x749BEC0
        public void get_hasMoved(){} // RVA: 0x749BF10
        public void get_cullTransparentMesh(){} // RVA: 0x749BF60
        public void set_cullTransparentMesh(){} // RVA: 0x749BFB0
        public void get_hasRectClipping(){} // RVA: 0x749C010
        public void get_relativeDepth(){} // RVA: 0x749C060
        public void get_cull(){} // RVA: 0x749C0B0
        public void set_cull(){} // RVA: 0x749C100
        public void get_isMask(){} // RVA: 0x2F84E0
        public void set_isMask(){} // RVA: 0x2F84F0
        public void SetColor(){} // RVA: 0x749C160
        public void GetColor(){} // RVA: 0x749C1C0
        public void EnableRectClipping(){} // RVA: 0x749C230
        public void get_clippingSoftness(){} // RVA: 0x749C290
        public void set_clippingSoftness(){} // RVA: 0x749C2F0
        public void DisableRectClipping(){} // RVA: 0x749C350
        public void SetMaterial(){} // RVA: 0x749C8A0 | overloaded x2
        public void GetMaterial(){} // RVA: 0x749CA30 | overloaded x2
        public void SetPopMaterial(){} // RVA: 0x749C470
        public void GetPopMaterial(){} // RVA: 0x749C4E0
        public void SetTexture(){} // RVA: 0x749C540
        public void SetAlphaTexture(){} // RVA: 0x749C5A0
        public void SetMesh(){} // RVA: 0x749C600
        public void GetMesh(){} // RVA: 0x749C660
        public void Clear(){} // RVA: 0x749C6B0
        public void GetAlpha(){} // RVA: 0x749C700
        public void SetAlpha(){} // RVA: 0x749C770
        public void GetInheritedAlpha(){} // RVA: 0x749C850
        public void SplitUIVertexStreams(){} // RVA: 0x749CBA0 | overloaded x2
        public void CreateUIVertexStream(){} // RVA: 0x749CDF0 | overloaded x2
        public void AddUIVertexStream(){} // RVA: 0x749CFB0 | overloaded x2
        public void SetVertices(){} // RVA: 0x749D180 | overloaded x2
        public void SplitIndicesStreamsInternal(){} // RVA: 0x749DB70
        public void SplitUIVertexStreamsInternal(){} // RVA: 0x749CFB0
        public void CreateUIVertexStreamInternal(){} // RVA: 0x749CDF0
        public void .ctor(){} // RVA: 0x2DDD50
        public void SetColor_Injected(){} // RVA: 0x749DBD0
        public void GetColor_Injected(){} // RVA: 0x749DC30
        public void EnableRectClipping_Injected(){} // RVA: 0x749DC90
        public void get_clippingSoftness_Injected(){} // RVA: 0x749DCF0
        public void set_clippingSoftness_Injected(){} // RVA: 0x749DD50
    }

    public class CapsuleCollider
    {
        // ── Methods ──
        public void get_center(){} // RVA: 0x7202320
        public void set_center(){} // RVA: 0x7202390
        public void get_radius(){} // RVA: 0x72023F0
        public void set_radius(){} // RVA: 0x7202440
        public void get_height(){} // RVA: 0x72024A0
        public void set_height(){} // RVA: 0x72024F0
        public void get_direction(){} // RVA: 0x7202550
        public void set_direction(){} // RVA: 0x72025A0
        public void GetGlobalExtents(){} // RVA: 0x7202600
        public void CalculateTransform(){} // RVA: 0x7202660
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_center_Injected(){} // RVA: 0x72026E0
        public void set_center_Injected(){} // RVA: 0x7202740
        public void GetGlobalExtents_Injected(){} // RVA: 0x72027A0
        public void CalculateTransform_Injected(){} // RVA: 0x7202800
    }

    public class CapsuleCollider2D
    {
        public object radius;

        // ── Methods ──
        public void get_size(){} // RVA: 0x71E91F0
        public void set_size(){} // RVA: 0x71E9250
        public void get_direction(){} // RVA: 0x71E92B0
        public void set_direction(){} // RVA: 0x71E9300
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_size_Injected(){} // RVA: 0x71E9360
        public void set_size_Injected(){} // RVA: 0x71E93C0
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

    public class CastHelper`1
    {
    }

}