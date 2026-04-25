// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 55
// Methods: 1270

namespace ThirdParty.Unity.UnityEngine
{
    public class Cache : ValueType
    {
        public int handle; // 0x10

        // ── Methods ──
        public void get_handle(){} // RVA: 0x7FFAC8F93F90
        public void GetHashCode(){} // RVA: 0x7FFAC8F93F90
        public void Equals(){} // RVA: 0x7FFAC9855270 | overloaded x2
        public void get_valid(){} // RVA: 0x7FFAC9855280
        public void Cache_IsValid(){} // RVA: 0x7FFAC98552D0
        public void get_path(){} // RVA: 0x7FFAC9855320
        public void Cache_GetPath(){} // RVA: 0x7FFAC9855370
        public void set_maximumAvailableStorageSpace(){} // RVA: 0x7FFAC98553C0
        public void Cache_SetMaximumDiskSpaceAvailable(){} // RVA: 0x7FFAC9855420
        public void get_spaceOccupied(){} // RVA: 0x7FFAC9855480
        public void Cache_GetCachingDiskSpaceUsed(){} // RVA: 0x7FFAC98554D0
    }

    public class CachedAssetBundle : ValueType
    {
        public string name; // 0x10
        public UnityEngine.Hash128 hash; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC60F5420
        public void get_name(){} // RVA: 0x7FFAC51D9A30
        public void get_hash(){} // RVA: 0x7FFAC98551E0
    }

    public class Caching : Object
    {
        public object currentCacheForWriting;

        // ── Methods ──
        public void ClearCache(){} // RVA: 0x7FFAC9855570 | overloaded x2
        public void ClearCache_Int(){} // RVA: 0x7FFAC9855570
        public void ClearAllCachedVersions(){} // RVA: 0x7FFAC98555C0
        public void ClearCachedVersions(){} // RVA: 0x7FFAC9855680
        public void IsVersionCached(){} // RVA: 0x7FFAC98557E0 | overloaded x2
        public void MarkAsUsed(){} // RVA: 0x7FFAC9855940 | overloaded x2
        public void AddCache(){} // RVA: 0x7FFAC9855CD0 | overloaded x2
        public void GetCacheByPath(){} // RVA: 0x7FFAC9855D40
        public void get_currentCacheForWriting(){} // RVA: 0x7FFAC9855DA0
        public void set_currentCacheForWriting(){} // RVA: 0x7FFAC9855E00
        public void ClearCachedVersions_Injected(){} // RVA: 0x7FFAC9855E50
        public void IsVersionCached_Injected(){} // RVA: 0x7FFAC9855EC0
        public void MarkAsUsed_Injected(){} // RVA: 0x7FFAC9855F30
        public void AddCache_Injected(){} // RVA: 0x7FFAC9855FA0
        public void GetCacheByPath_Injected(){} // RVA: 0x7FFAC9856010
        public void get_currentCacheForWriting_Injected(){} // RVA: 0x7FFAC9856070
        public void set_currentCacheForWriting_Injected(){} // RVA: 0x7FFAC98560C0
    }

    public class Camera : Behaviour
    {
        public float nearClipPlane;
        public float farClipPlane;
        public int fieldOfView;
        public int renderingPath;
        public CameraCallback actualRenderingPath;
        public CameraCallback allowHDR; // 0x8
        public CameraCallback allowMSAA; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_nearClipPlane(){} // RVA: 0x7FFAC9856110
        public void set_nearClipPlane(){} // RVA: 0x7FFAC9856160
        public void get_farClipPlane(){} // RVA: 0x7FFAC98561C0
        public void set_farClipPlane(){} // RVA: 0x7FFAC9856210
        public void get_fieldOfView(){} // RVA: 0x7FFAC9856270
        public void set_fieldOfView(){} // RVA: 0x7FFAC98562C0
        public void get_renderingPath(){} // RVA: 0x7FFAC9856320
        public void set_renderingPath(){} // RVA: 0x7FFAC9856370
        public void get_actualRenderingPath(){} // RVA: 0x7FFAC98563D0
        public void Reset(){} // RVA: 0x7FFAC9856420
        public void get_allowHDR(){} // RVA: 0x7FFAC9856470
        public void set_allowHDR(){} // RVA: 0x7FFAC98564C0
        public void get_allowMSAA(){} // RVA: 0x7FFAC9856520
        public void set_allowMSAA(){} // RVA: 0x7FFAC9856570
        public void get_allowDynamicResolution(){} // RVA: 0x7FFAC98565D0
        public void set_allowDynamicResolution(){} // RVA: 0x7FFAC9856620
        public void get_forceIntoRenderTexture(){} // RVA: 0x7FFAC9856680
        public void set_forceIntoRenderTexture(){} // RVA: 0x7FFAC98566D0
        public void get_orthographicSize(){} // RVA: 0x7FFAC9856730
        public void set_orthographicSize(){} // RVA: 0x7FFAC9856780
        public void get_orthographic(){} // RVA: 0x7FFAC98567E0
        public void set_orthographic(){} // RVA: 0x7FFAC9856830
        public void get_opaqueSortMode(){} // RVA: 0x7FFAC9856890
        public void set_opaqueSortMode(){} // RVA: 0x7FFAC98568E0
        public void get_transparencySortMode(){} // RVA: 0x7FFAC9856940
        public void set_transparencySortMode(){} // RVA: 0x7FFAC9856990
        public void get_transparencySortAxis(){} // RVA: 0x7FFAC98569F0
        public void set_transparencySortAxis(){} // RVA: 0x7FFAC9856A60
        public void ResetTransparencySortSettings(){} // RVA: 0x7FFAC9856AC0
        public void get_depth(){} // RVA: 0x7FFAC9856B10
        public void set_depth(){} // RVA: 0x7FFAC9856B60
        public void get_aspect(){} // RVA: 0x7FFAC9856BC0
        public void set_aspect(){} // RVA: 0x7FFAC9856C10
        public void ResetAspect(){} // RVA: 0x7FFAC9856C70
        public void get_velocity(){} // RVA: 0x7FFAC9856CC0
        public void get_cullingMask(){} // RVA: 0x7FFAC9856D30
        public void set_cullingMask(){} // RVA: 0x7FFAC9856D80
        public void get_eventMask(){} // RVA: 0x7FFAC9856DE0
        public void set_eventMask(){} // RVA: 0x7FFAC9856E30
        public void get_layerCullSpherical(){} // RVA: 0x7FFAC9856E90
        public void set_layerCullSpherical(){} // RVA: 0x7FFAC9856EE0
        public void get_cameraType(){} // RVA: 0x7FFAC9856F40
        public void set_cameraType(){} // RVA: 0x7FFAC9856F90
        public void get_skyboxMaterial(){} // RVA: 0x7FFAC9856FF0
        public void get_overrideSceneCullingMask(){} // RVA: 0x7FFAC9857040
        public void set_overrideSceneCullingMask(){} // RVA: 0x7FFAC9857090
        public void get_sceneCullingMask(){} // RVA: 0x7FFAC98570F0
        public void GetLayerCullDistances(){} // RVA: 0x7FFAC9857140
        public void SetLayerCullDistances(){} // RVA: 0x7FFAC9857190
        public void get_layerCullDistances(){} // RVA: 0x7FFAC9857140
        public void set_layerCullDistances(){} // RVA: 0x7FFAC98571F0
        public void get_PreviewCullingLayer(){} // RVA: 0x7FFAC98572B0
        public void get_useOcclusionCulling(){} // RVA: 0x7FFAC98572C0
        public void set_useOcclusionCulling(){} // RVA: 0x7FFAC9857310
        public void get_cullingMatrix(){} // RVA: 0x7FFAC9857370
        public void set_cullingMatrix(){} // RVA: 0x7FFAC98573F0
        public void ResetCullingMatrix(){} // RVA: 0x7FFAC9857450
        public void get_backgroundColor(){} // RVA: 0x7FFAC98574A0
        public void set_backgroundColor(){} // RVA: 0x7FFAC9857510
        public void get_clearFlags(){} // RVA: 0x7FFAC9857570
        public void set_clearFlags(){} // RVA: 0x7FFAC98575C0
        public void get_depthTextureMode(){} // RVA: 0x7FFAC9857620
        public void set_depthTextureMode(){} // RVA: 0x7FFAC9857670
        public void get_clearStencilAfterLightingPass(){} // RVA: 0x7FFAC98576D0
        public void set_clearStencilAfterLightingPass(){} // RVA: 0x7FFAC9857720
        public void SetReplacementShader(){} // RVA: 0x7FFAC9857780
        public void ResetReplacementShader(){} // RVA: 0x7FFAC98577F0
        public void get_projectionMatrixMode(){} // RVA: 0x7FFAC9857840
        public void get_usePhysicalProperties(){} // RVA: 0x7FFAC9857890
        public void set_usePhysicalProperties(){} // RVA: 0x7FFAC98578E0
        public void get_iso(){} // RVA: 0x7FFAC9857940
        public void set_iso(){} // RVA: 0x7FFAC9857990
        public void get_shutterSpeed(){} // RVA: 0x7FFAC98579F0
        public void set_shutterSpeed(){} // RVA: 0x7FFAC9857A40
        public void get_aperture(){} // RVA: 0x7FFAC9857AA0
        public void set_aperture(){} // RVA: 0x7FFAC9857AF0
        public void get_focusDistance(){} // RVA: 0x7FFAC9857B50
        public void set_focusDistance(){} // RVA: 0x7FFAC9857BA0
        public void get_focalLength(){} // RVA: 0x7FFAC9857C00
        public void set_focalLength(){} // RVA: 0x7FFAC9857C50
        public void get_bladeCount(){} // RVA: 0x7FFAC9857CB0
        public void set_bladeCount(){} // RVA: 0x7FFAC9857D00
        public void get_curvature(){} // RVA: 0x7FFAC9857D60
        public void set_curvature(){} // RVA: 0x7FFAC9857DC0
        public void get_barrelClipping(){} // RVA: 0x7FFAC9857E20
        public void set_barrelClipping(){} // RVA: 0x7FFAC9857E70
        public void get_anamorphism(){} // RVA: 0x7FFAC9857ED0
        public void set_anamorphism(){} // RVA: 0x7FFAC9857F20
        public void get_sensorSize(){} // RVA: 0x7FFAC9857F80
        public void set_sensorSize(){} // RVA: 0x7FFAC9857FE0
        public void get_lensShift(){} // RVA: 0x7FFAC9858040
        public void set_lensShift(){} // RVA: 0x7FFAC98580A0
        public void get_gateFit(){} // RVA: 0x7FFAC9858100
        public void set_gateFit(){} // RVA: 0x7FFAC9858150
        public void GetGateFittedFieldOfView(){} // RVA: 0x7FFAC98581B0
        public void GetGateFittedLensShift(){} // RVA: 0x7FFAC9858200
        public void GetLocalSpaceAim(){} // RVA: 0x7FFAC9858260
        public void get_rect(){} // RVA: 0x7FFAC98582D0
        public void set_rect(){} // RVA: 0x7FFAC9858340
        public void get_pixelRect(){} // RVA: 0x7FFAC98583A0
        public void set_pixelRect(){} // RVA: 0x7FFAC9858410
        public void get_pixelWidth(){} // RVA: 0x7FFAC9858470
        public void get_pixelHeight(){} // RVA: 0x7FFAC98584C0
        public void get_scaledPixelWidth(){} // RVA: 0x7FFAC9858510
        public void get_scaledPixelHeight(){} // RVA: 0x7FFAC9858560
        public void get_targetTexture(){} // RVA: 0x7FFAC98585B0
        public void set_targetTexture(){} // RVA: 0x7FFAC9858600
        public void get_activeTexture(){} // RVA: 0x7FFAC9858660
        public void get_targetDisplay(){} // RVA: 0x7FFAC98586B0
        public void set_targetDisplay(){} // RVA: 0x7FFAC9858700
        public void SetTargetBuffersImpl(){} // RVA: 0x7FFAC9858760
        public void SetTargetBuffers(){} // RVA: 0x7FFAC98588B0 | overloaded x2
        public void SetTargetBuffersMRTImpl(){} // RVA: 0x7FFAC9858840
        public void GetCameraBufferWarnings(){} // RVA: 0x7FFAC9858920
        public void get_cameraToWorldMatrix(){} // RVA: 0x7FFAC9858970
        public void get_worldToCameraMatrix(){} // RVA: 0x7FFAC98589F0
        public void set_worldToCameraMatrix(){} // RVA: 0x7FFAC9858A70
        public void get_projectionMatrix(){} // RVA: 0x7FFAC9858AD0
        public void set_projectionMatrix(){} // RVA: 0x7FFAC9858B50
        public void get_nonJitteredProjectionMatrix(){} // RVA: 0x7FFAC9858BB0
        public void set_nonJitteredProjectionMatrix(){} // RVA: 0x7FFAC9858C30
        public void get_useJitteredProjectionMatrixForTransparentRendering(){} // RVA: 0x7FFAC9858C90
        public void set_useJitteredProjectionMatrixForTransparentRendering(){} // RVA: 0x7FFAC9858CE0
        public void get_previousViewProjectionMatrix(){} // RVA: 0x7FFAC9858D40
        public void ResetWorldToCameraMatrix(){} // RVA: 0x7FFAC9858DC0
        public void ResetProjectionMatrix(){} // RVA: 0x7FFAC9858E10
        public void CalculateObliqueMatrix(){} // RVA: 0x7FFAC9858E60
        public void WorldToScreenPoint(){} // RVA: 0x7FFAC9859130 | overloaded x2
        public void WorldToViewportPoint(){} // RVA: 0x7FFAC98591E0 | overloaded x2
        public void ViewportToWorldPoint(){} // RVA: 0x7FFAC9859290 | overloaded x2
        public void ScreenToWorldPoint(){} // RVA: 0x7FFAC9859340 | overloaded x2
        public void ScreenToViewportPoint(){} // RVA: 0x7FFAC98593F0
        public void ViewportToScreenPoint(){} // RVA: 0x7FFAC9859470
        public void GetFrustumPlaneSizeAt(){} // RVA: 0x7FFAC98594F0
        public void ViewportPointToRay(){} // RVA: 0x7FFAC98596C0 | overloaded x3
        public void ScreenPointToRay(){} // RVA: 0x7FFAC98598E0 | overloaded x3
        public void CalculateFrustumCornersInternal(){} // RVA: 0x7FFAC98599A0
        public void CalculateFrustumCorners(){} // RVA: 0x7FFAC9859A30
        public void CalculateProjectionMatrixFromPhysicalPropertiesInternal(){} // RVA: 0x7FFAC9859B80
        public void CalculateProjectionMatrixFromPhysicalProperties(){} // RVA: 0x7FFAC9859C30
        public void FocalLengthToFieldOfView(){} // RVA: 0x7FFAC9859CE0
        public void FieldOfViewToFocalLength(){} // RVA: 0x7FFAC9859D50
        public void HorizontalToVerticalFieldOfView(){} // RVA: 0x7FFAC9859DC0
        public void VerticalToHorizontalFieldOfView(){} // RVA: 0x7FFAC9859E30
        public void get_main(){} // RVA: 0x7FFAC3770BA0
        public void get_current(){} // RVA: 0x7FFAC9859EA0
        public void get_scene(){} // RVA: 0x7FFAC9859EF0
        public void set_scene(){} // RVA: 0x7FFAC9859F50
        public void get_stereoEnabled(){} // RVA: 0x7FFAC9859FB0
        public void get_stereoSeparation(){} // RVA: 0x7FFAC985A000
        public void set_stereoSeparation(){} // RVA: 0x7FFAC985A050
        public void get_stereoConvergence(){} // RVA: 0x7FFAC985A0B0
        public void set_stereoConvergence(){} // RVA: 0x7FFAC985A100
        public void get_areVRStereoViewMatricesWithinSingleCullTolerance(){} // RVA: 0x7FFAC985A160
        public void get_stereoTargetEye(){} // RVA: 0x7FFAC985A1B0
        public void set_stereoTargetEye(){} // RVA: 0x7FFAC985A200
        public void get_stereoActiveEye(){} // RVA: 0x7FFAC985A260
        public void GetStereoNonJitteredProjectionMatrix(){} // RVA: 0x7FFAC985A2B0
        public void GetStereoViewMatrix(){} // RVA: 0x7FFAC985A340
        public void CopyStereoDeviceProjectionMatrixToNonJittered(){} // RVA: 0x7FFAC985A3D0
        public void GetStereoProjectionMatrix(){} // RVA: 0x7FFAC985A430
        public void SetStereoProjectionMatrix(){} // RVA: 0x7FFAC985A4C0
        public void ResetStereoProjectionMatrices(){} // RVA: 0x7FFAC985A530
        public void SetStereoViewMatrix(){} // RVA: 0x7FFAC985A580
        public void ResetStereoViewMatrices(){} // RVA: 0x7FFAC985A5F0
        public void GetAllCamerasCount(){} // RVA: 0x7FFAC985A640
        public void GetAllCamerasImpl(){} // RVA: 0x7FFAC985A690
        public void get_allCamerasCount(){} // RVA: 0x7FFAC985A640
        public void get_allCameras(){} // RVA: 0x7FFAC985A6E0
        public void GetAllCameras(){} // RVA: 0x7FFAC985A7B0
        public void RenderToCubemapImpl(){} // RVA: 0x7FFAC985A8D0
        public void RenderToCubemap(){} // RVA: 0x7FFAC985AA10 | overloaded x5
        public void GetFilterMode(){} // RVA: 0x7FFAC985A9C0
        public void get_sceneViewFilterMode(){} // RVA: 0x7FFAC985A9C0
        public void RenderToCubemapEyeImpl(){} // RVA: 0x7FFAC985AA10
        public void Render(){} // RVA: 0x7FFAC985AA90
        public void RenderWithShader(){} // RVA: 0x7FFAC985AAE0
        public void RenderDontRestore(){} // RVA: 0x7FFAC985AB50
        public void SubmitRenderRequests(){} // RVA: 0x7FFAC985ABA0
        public void SubmitRenderRequest(){} // RVA: 0x7FFAC2E8DC40
        public void SubmitRenderRequestsInternal(){} // RVA: 0x7FFAC985AD50
        public void SubmitBuiltInObjectIDRenderRequest(){} // RVA: 0x7FFAC985ADB0
        public void SetupCurrent(){} // RVA: 0x7FFAC985AE40
        public void CopyFrom(){} // RVA: 0x7FFAC985AE90
        public void get_commandBufferCount(){} // RVA: 0x7FFAC985AEF0
        public void RemoveCommandBuffers(){} // RVA: 0x7FFAC985AF40
        public void RemoveAllCommandBuffers(){} // RVA: 0x7FFAC985AFA0
        public void AddCommandBufferImpl(){} // RVA: 0x7FFAC985AFF0
        public void AddCommandBufferAsyncImpl(){} // RVA: 0x7FFAC985B060
        public void RemoveCommandBufferImpl(){} // RVA: 0x7FFAC985B0E0
        public void AddCommandBuffer(){} // RVA: 0x7FFAC985B150
        public void AddCommandBufferAsync(){} // RVA: 0x7FFAC985B2B0
        public void RemoveCommandBuffer(){} // RVA: 0x7FFAC985B420
        public void GetCommandBuffers(){} // RVA: 0x7FFAC985B580
        public void FireOnPreCull(){} // RVA: 0x7FFAC985B5E0
        public void FireOnPreRender(){} // RVA: 0x7FFAC985B640
        public void FireOnPostRender(){} // RVA: 0x7FFAC985B6A0
        public void OnlyUsedForTesting1(){} // RVA: 0x7FFAC2F21310
        public void OnlyUsedForTesting2(){} // RVA: 0x7FFAC2F21310
        public void TryGetCullingParameters(){} // RVA: 0x7FFAC985B730 | overloaded x2
        public void GetCullingParameters_Internal(){} // RVA: 0x7FFAC985B750
        public void get_transparencySortAxis_Injected(){} // RVA: 0x7FFAC985B7D0
        public void set_transparencySortAxis_Injected(){} // RVA: 0x7FFAC985B830
        public void get_velocity_Injected(){} // RVA: 0x7FFAC985B890
        public void get_cullingMatrix_Injected(){} // RVA: 0x7FFAC985B8F0
        public void set_cullingMatrix_Injected(){} // RVA: 0x7FFAC985B950
        public void get_backgroundColor_Injected(){} // RVA: 0x7FFAC985B9B0
        public void set_backgroundColor_Injected(){} // RVA: 0x7FFAC985BA10
        public void get_curvature_Injected(){} // RVA: 0x7FFAC985BA70
        public void set_curvature_Injected(){} // RVA: 0x7FFAC985BAD0
        public void get_sensorSize_Injected(){} // RVA: 0x7FFAC985BB30
        public void set_sensorSize_Injected(){} // RVA: 0x7FFAC985BB90
        public void get_lensShift_Injected(){} // RVA: 0x7FFAC985BBF0
        public void set_lensShift_Injected(){} // RVA: 0x7FFAC985BC50
        public void GetGateFittedLensShift_Injected(){} // RVA: 0x7FFAC985BCB0
        public void GetLocalSpaceAim_Injected(){} // RVA: 0x7FFAC985BD10
        public void get_rect_Injected(){} // RVA: 0x7FFAC985BD70
        public void set_rect_Injected(){} // RVA: 0x7FFAC985BDD0
        public void get_pixelRect_Injected(){} // RVA: 0x7FFAC985BE30
        public void set_pixelRect_Injected(){} // RVA: 0x7FFAC985BE90
        public void SetTargetBuffersImpl_Injected(){} // RVA: 0x7FFAC985BEF0
        public void SetTargetBuffersMRTImpl_Injected(){} // RVA: 0x7FFAC985BF60
        public void get_cameraToWorldMatrix_Injected(){} // RVA: 0x7FFAC985BFD0
        public void get_worldToCameraMatrix_Injected(){} // RVA: 0x7FFAC985C030
        public void set_worldToCameraMatrix_Injected(){} // RVA: 0x7FFAC985C090
        public void get_projectionMatrix_Injected(){} // RVA: 0x7FFAC985C0F0
        public void set_projectionMatrix_Injected(){} // RVA: 0x7FFAC985C150
        public void get_nonJitteredProjectionMatrix_Injected(){} // RVA: 0x7FFAC985C1B0
        public void set_nonJitteredProjectionMatrix_Injected(){} // RVA: 0x7FFAC985C210
        public void get_previousViewProjectionMatrix_Injected(){} // RVA: 0x7FFAC985C270
        public void CalculateObliqueMatrix_Injected(){} // RVA: 0x7FFAC985C2D0
        public void WorldToScreenPoint_Injected(){} // RVA: 0x7FFAC985C340
        public void WorldToViewportPoint_Injected(){} // RVA: 0x7FFAC985C3C0
        public void ViewportToWorldPoint_Injected(){} // RVA: 0x7FFAC985C440
        public void ScreenToWorldPoint_Injected(){} // RVA: 0x7FFAC985C4C0
        public void ScreenToViewportPoint_Injected(){} // RVA: 0x7FFAC985C540
        public void ViewportToScreenPoint_Injected(){} // RVA: 0x7FFAC985C5B0
        public void GetFrustumPlaneSizeAt_Injected(){} // RVA: 0x7FFAC985C620
        public void ViewportPointToRay_Injected(){} // RVA: 0x7FFAC985C690
        public void ScreenPointToRay_Injected(){} // RVA: 0x7FFAC985C710
        public void CalculateFrustumCornersInternal_Injected(){} // RVA: 0x7FFAC985C790
        public void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(){} // RVA: 0x7FFAC985C820
        public void get_scene_Injected(){} // RVA: 0x7FFAC985C8B0
        public void set_scene_Injected(){} // RVA: 0x7FFAC985C910
        public void GetStereoNonJitteredProjectionMatrix_Injected(){} // RVA: 0x7FFAC985C970
        public void GetStereoViewMatrix_Injected(){} // RVA: 0x7FFAC985C9E0
        public void GetStereoProjectionMatrix_Injected(){} // RVA: 0x7FFAC985CA50
        public void SetStereoProjectionMatrix_Injected(){} // RVA: 0x7FFAC985CAC0
        public void SetStereoViewMatrix_Injected(){} // RVA: 0x7FFAC985CB30
    }

    public class CameraRaycastHelper : Object
    {
        // ── Methods ──
        public void RaycastTry(){} // RVA: 0x7FFAC993FB50
        public void RaycastTry2D(){} // RVA: 0x7FFAC993FBD0
        public void RaycastTry_Injected(){} // RVA: 0x7FFAC993FC50
        public void RaycastTry2D_Injected(){} // RVA: 0x7FFAC993FCD0
    }

    public class Canvas : Behaviour
    {
        public WillRenderCanvases renderMode;
        public WillRenderCanvases isRootCanvas; // 0x8
        public System.Action`1<int> pixelRect; // 0x10
        public System.Action`2<int,int> scaleFactor; // 0x18
        public System.Action`1<int> referencePixelsPerUnit; // 0x20

        // ── Methods ──
        public void add_preWillRenderCanvases(){} // RVA: 0x7FFAC9C376F0
        public void remove_preWillRenderCanvases(){} // RVA: 0x7FFAC9C37800
        public void add_willRenderCanvases(){} // RVA: 0x7FFAC9C37910
        public void remove_willRenderCanvases(){} // RVA: 0x7FFAC9C37A20
        public void get_renderMode(){} // RVA: 0x7FFAC9C37B30
        public void set_renderMode(){} // RVA: 0x7FFAC9C37B80
        public void get_isRootCanvas(){} // RVA: 0x7FFAC9C37BE0
        public void get_pixelRect(){} // RVA: 0x7FFAC9C37C30
        public void get_scaleFactor(){} // RVA: 0x7FFAC9C37CA0
        public void set_scaleFactor(){} // RVA: 0x7FFAC9C37CF0
        public void get_referencePixelsPerUnit(){} // RVA: 0x7FFAC9C37D50
        public void set_referencePixelsPerUnit(){} // RVA: 0x7FFAC9C37DA0
        public void get_overridePixelPerfect(){} // RVA: 0x7FFAC9C37E00
        public void set_overridePixelPerfect(){} // RVA: 0x7FFAC9C37E50
        public void get_vertexColorAlwaysGammaSpace(){} // RVA: 0x7FFAC9C37EB0
        public void set_vertexColorAlwaysGammaSpace(){} // RVA: 0x7FFAC9C37F00
        public void get_pixelPerfect(){} // RVA: 0x7FFAC9C37F60
        public void set_pixelPerfect(){} // RVA: 0x7FFAC9C37FB0
        public void get_planeDistance(){} // RVA: 0x7FFAC9C38010
        public void set_planeDistance(){} // RVA: 0x7FFAC9C38060
        public void get_renderOrder(){} // RVA: 0x7FFAC9C380C0
        public void get_overrideSorting(){} // RVA: 0x7FFAC9C38110
        public void set_overrideSorting(){} // RVA: 0x7FFAC9C38160
        public void get_sortingOrder(){} // RVA: 0x7FFAC9C381C0
        public void set_sortingOrder(){} // RVA: 0x7FFAC9C38210
        public void get_targetDisplay(){} // RVA: 0x7FFAC9C38270
        public void set_targetDisplay(){} // RVA: 0x7FFAC9C382C0
        public void get_sortingLayerID(){} // RVA: 0x7FFAC9C38320
        public void set_sortingLayerID(){} // RVA: 0x7FFAC9C38370
        public void get_cachedSortingLayerValue(){} // RVA: 0x7FFAC9C383D0
        public void get_additionalShaderChannels(){} // RVA: 0x7FFAC9C38420
        public void set_additionalShaderChannels(){} // RVA: 0x7FFAC9C38470
        public void get_sortingLayerName(){} // RVA: 0x7FFAC9C384D0
        public void set_sortingLayerName(){} // RVA: 0x7FFAC9C38520
        public void get_rootCanvas(){} // RVA: 0x7FFAC9C38580
        public void get_renderingDisplaySize(){} // RVA: 0x7FFAC9C385D0
        public void get_updateRectTransformForStandalone(){} // RVA: 0x7FFAC9C38630
        public void set_updateRectTransformForStandalone(){} // RVA: 0x7FFAC9C38680
        public void get_externBeginRenderOverlays(){} // RVA: 0x7FFAC9C386E0
        public void set_externBeginRenderOverlays(){} // RVA: 0x7FFAC9C38720
        public void get_externRenderOverlaysBefore(){} // RVA: 0x7FFAC9C387C0
        public void set_externRenderOverlaysBefore(){} // RVA: 0x7FFAC9C38800
        public void get_externEndRenderOverlays(){} // RVA: 0x7FFAC9C388A0
        public void set_externEndRenderOverlays(){} // RVA: 0x7FFAC9C388E0
        public void SetExternalCanvasEnabled(){} // RVA: 0x7FFAC9C38980
        public void get_worldCamera(){} // RVA: 0x7FFAC9C389D0
        public void set_worldCamera(){} // RVA: 0x7FFAC9C38A20
        public void get_normalizedSortingGridSize(){} // RVA: 0x7FFAC9C38A80
        public void set_normalizedSortingGridSize(){} // RVA: 0x7FFAC9C38AD0
        public void get_sortingGridNormalizedSize(){} // RVA: 0x7FFAC9C38B30
        public void set_sortingGridNormalizedSize(){} // RVA: 0x7FFAC9C38B80
        public void GetDefaultCanvasTextMaterial(){} // RVA: 0x7FFAC9C38BE0
        public void GetDefaultCanvasMaterial(){} // RVA: 0x7FFAC9C38C30
        public void GetETC1SupportedCanvasMaterial(){} // RVA: 0x7FFAC9C38C80
        public void UpdateCanvasRectTransform(){} // RVA: 0x7FFAC9C38CD0
        public void ForceUpdateCanvases(){} // RVA: 0x7FFAC9C38D30
        public void SendPreWillRenderCanvases(){} // RVA: 0x7FFAC9C38DD0
        public void SendWillRenderCanvases(){} // RVA: 0x7FFAC9C38E30
        public void BeginRenderExtraOverlays(){} // RVA: 0x7FFAC9C38E90
        public void RenderExtraOverlaysBefore(){} // RVA: 0x7FFAC9C38EF0
        public void EndRenderExtraOverlays(){} // RVA: 0x7FFAC9C38F60
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_pixelRect_Injected(){} // RVA: 0x7FFAC9C38FC0
        public void get_renderingDisplaySize_Injected(){} // RVA: 0x7FFAC9C39020
    }

    public class CanvasGroup : Behaviour
    {
        public object alpha;
        public object interactable;
        public object blocksRaycasts;
        public object ignoreParentGroups;

        // ── Methods ──
        public void get_alpha(){} // RVA: 0x7FFAC9C33340
        public void set_alpha(){} // RVA: 0x7FFAC9C33390
        public void get_interactable(){} // RVA: 0x7FFAC9C333F0
        public void set_interactable(){} // RVA: 0x7FFAC9C33440
        public void get_blocksRaycasts(){} // RVA: 0x7FFAC9C334A0
        public void set_blocksRaycasts(){} // RVA: 0x7FFAC9C334F0
        public void get_ignoreParentGroups(){} // RVA: 0x7FFAC9C33550
        public void set_ignoreParentGroups(){} // RVA: 0x7FFAC9C335A0
        public void IsRaycastLocationValid(){} // RVA: 0x7FFAC9C334A0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class CanvasRenderer : Component
    {
        public bool hasPopInstruction; // 0x18

        // ── Methods ──
        public void get_hasPopInstruction(){} // RVA: 0x7FFAC9C33600
        public void set_hasPopInstruction(){} // RVA: 0x7FFAC9C33650
        public void get_materialCount(){} // RVA: 0x7FFAC9C336B0
        public void set_materialCount(){} // RVA: 0x7FFAC9C33700
        public void get_popMaterialCount(){} // RVA: 0x7FFAC9C33760
        public void set_popMaterialCount(){} // RVA: 0x7FFAC9C337B0
        public void get_absoluteDepth(){} // RVA: 0x7FFAC9C33810
        public void get_hasMoved(){} // RVA: 0x7FFAC9C33860
        public void get_cullTransparentMesh(){} // RVA: 0x7FFAC9C338B0
        public void set_cullTransparentMesh(){} // RVA: 0x7FFAC9C33900
        public void get_hasRectClipping(){} // RVA: 0x7FFAC9C33960
        public void get_relativeDepth(){} // RVA: 0x7FFAC9C339B0
        public void get_cull(){} // RVA: 0x7FFAC9C33A00
        public void set_cull(){} // RVA: 0x7FFAC9C33A50
        public void get_isMask(){} // RVA: 0x7FFAC2F3C4E0
        public void set_isMask(){} // RVA: 0x7FFAC2F3C4F0
        public void SetColor(){} // RVA: 0x7FFAC9C33AB0
        public void GetColor(){} // RVA: 0x7FFAC9C33B10
        public void EnableRectClipping(){} // RVA: 0x7FFAC9C33B80
        public void get_clippingSoftness(){} // RVA: 0x7FFAC9C33BE0
        public void set_clippingSoftness(){} // RVA: 0x7FFAC9C33C40
        public void DisableRectClipping(){} // RVA: 0x7FFAC9C33CA0
        public void SetMaterial(){} // RVA: 0x7FFAC9C341F0 | overloaded x2
        public void GetMaterial(){} // RVA: 0x7FFAC9C34380 | overloaded x2
        public void SetPopMaterial(){} // RVA: 0x7FFAC9C33DC0
        public void GetPopMaterial(){} // RVA: 0x7FFAC9C33E30
        public void SetTexture(){} // RVA: 0x7FFAC9C33E90
        public void SetAlphaTexture(){} // RVA: 0x7FFAC9C33EF0
        public void SetMesh(){} // RVA: 0x7FFAC9C33F50
        public void GetMesh(){} // RVA: 0x7FFAC9C33FB0
        public void Clear(){} // RVA: 0x7FFAC9C34000
        public void GetAlpha(){} // RVA: 0x7FFAC9C34050
        public void SetAlpha(){} // RVA: 0x7FFAC9C340C0
        public void GetInheritedAlpha(){} // RVA: 0x7FFAC9C341A0
        public void SplitUIVertexStreams(){} // RVA: 0x7FFAC9C344F0 | overloaded x2
        public void CreateUIVertexStream(){} // RVA: 0x7FFAC9C34740 | overloaded x2
        public void AddUIVertexStream(){} // RVA: 0x7FFAC9C34900 | overloaded x2
        public void SetVertices(){} // RVA: 0x7FFAC9C34AD0 | overloaded x2
        public void SplitIndicesStreamsInternal(){} // RVA: 0x7FFAC9C354C0
        public void SplitUIVertexStreamsInternal(){} // RVA: 0x7FFAC9C34900
        public void CreateUIVertexStreamInternal(){} // RVA: 0x7FFAC9C34740
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void SetColor_Injected(){} // RVA: 0x7FFAC9C35520
        public void GetColor_Injected(){} // RVA: 0x7FFAC9C35580
        public void EnableRectClipping_Injected(){} // RVA: 0x7FFAC9C355E0
        public void get_clippingSoftness_Injected(){} // RVA: 0x7FFAC9C35640
        public void set_clippingSoftness_Injected(){} // RVA: 0x7FFAC9C356A0
    }

    public class CapsuleCollider : Collider
    {
        public object center;
        public object radius;
        public object height;
        public object direction;

        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFAC9999C20
        public void set_center(){} // RVA: 0x7FFAC9999C90
        public void get_radius(){} // RVA: 0x7FFAC9999CF0
        public void set_radius(){} // RVA: 0x7FFAC9999D40
        public void get_height(){} // RVA: 0x7FFAC9999DA0
        public void set_height(){} // RVA: 0x7FFAC9999DF0
        public void get_direction(){} // RVA: 0x7FFAC9999E50
        public void set_direction(){} // RVA: 0x7FFAC9999EA0
        public void GetGlobalExtents(){} // RVA: 0x7FFAC9999F00
        public void CalculateTransform(){} // RVA: 0x7FFAC9999F60
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_center_Injected(){} // RVA: 0x7FFAC9999FE0
        public void set_center_Injected(){} // RVA: 0x7FFAC999A040
        public void GetGlobalExtents_Injected(){} // RVA: 0x7FFAC999A0A0
        public void CalculateTransform_Injected(){} // RVA: 0x7FFAC999A100
    }

    public class CapsuleCollider2D : Collider2D
    {
        public object size;
        public object direction;

        // ── Methods ──
        public void get_size(){} // RVA: 0x7FFAC9980AF0
        public void set_size(){} // RVA: 0x7FFAC9980B50
        public void get_direction(){} // RVA: 0x7FFAC9980BB0
        public void set_direction(){} // RVA: 0x7FFAC9980C00
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_size_Injected(){} // RVA: 0x7FFAC9980C60
        public void set_size_Injected(){} // RVA: 0x7FFAC9980CC0
    }

    public class CastHelper`1 : ValueType
    {
        public T t;
        public UIntPtr onePointerFurtherThanT;
    }

    public class CharacterController : Collider
    {
        public object velocity;
        public object isGrounded;
        public object collisionFlags;
        public object radius;
        public object height;
        public object center;
        public object slopeLimit;
        public object stepOffset;
        public object skinWidth;
        public object minMoveDistance;
        public object detectCollisions;
        public object enableOverlapRecovery;

        // ── Methods ──
        public void SimpleMove(){} // RVA: 0x7FFAC9999010
        public void Move(){} // RVA: 0x7FFAC9999070
        public void get_velocity(){} // RVA: 0x7FFAC99990D0
        public void get_isGrounded(){} // RVA: 0x7FFAC9999140
        public void get_collisionFlags(){} // RVA: 0x7FFAC9999190
        public void get_radius(){} // RVA: 0x7FFAC99991E0
        public void set_radius(){} // RVA: 0x7FFAC9999230
        public void get_height(){} // RVA: 0x7FFAC9999290
        public void set_height(){} // RVA: 0x7FFAC99992E0
        public void get_center(){} // RVA: 0x7FFAC9999340
        public void set_center(){} // RVA: 0x7FFAC99993B0
        public void get_slopeLimit(){} // RVA: 0x7FFAC9999410
        public void set_slopeLimit(){} // RVA: 0x7FFAC9999460
        public void get_stepOffset(){} // RVA: 0x7FFAC99994C0
        public void set_stepOffset(){} // RVA: 0x7FFAC9999510
        public void get_skinWidth(){} // RVA: 0x7FFAC9999570
        public void set_skinWidth(){} // RVA: 0x7FFAC99995C0
        public void get_minMoveDistance(){} // RVA: 0x7FFAC9999620
        public void set_minMoveDistance(){} // RVA: 0x7FFAC9999670
        public void get_detectCollisions(){} // RVA: 0x7FFAC99996D0
        public void set_detectCollisions(){} // RVA: 0x7FFAC9999720
        public void get_enableOverlapRecovery(){} // RVA: 0x7FFAC9999780
        public void set_enableOverlapRecovery(){} // RVA: 0x7FFAC99997D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void SimpleMove_Injected(){} // RVA: 0x7FFAC9999830
        public void Move_Injected(){} // RVA: 0x7FFAC9999890
        public void get_velocity_Injected(){} // RVA: 0x7FFAC99998F0
        public void get_center_Injected(){} // RVA: 0x7FFAC9999950
        public void set_center_Injected(){} // RVA: 0x7FFAC99999B0
    }

    public class CharacterJoint : Joint
    {
        public UnityEngine.Quaternion swingAxis; // 0x18
        public UnityEngine.Vector3 twistLimitSpring; // 0x28
        public UnityEngine.JointDrive swingLimitSpring; // 0x34

        // ── Methods ──
        public void get_swingAxis(){} // RVA: 0x7FFAC999C7E0
        public void set_swingAxis(){} // RVA: 0x7FFAC999C850
        public void get_twistLimitSpring(){} // RVA: 0x7FFAC999C8B0
        public void set_twistLimitSpring(){} // RVA: 0x7FFAC999C910
        public void get_swingLimitSpring(){} // RVA: 0x7FFAC999C970
        public void set_swingLimitSpring(){} // RVA: 0x7FFAC999C9D0
        public void get_lowTwistLimit(){} // RVA: 0x7FFAC999CA30
        public void set_lowTwistLimit(){} // RVA: 0x7FFAC999CAA0
        public void get_highTwistLimit(){} // RVA: 0x7FFAC999CB00
        public void set_highTwistLimit(){} // RVA: 0x7FFAC999CB70
        public void get_swing1Limit(){} // RVA: 0x7FFAC999CBD0
        public void set_swing1Limit(){} // RVA: 0x7FFAC999CC40
        public void get_swing2Limit(){} // RVA: 0x7FFAC999CCA0
        public void set_swing2Limit(){} // RVA: 0x7FFAC999CD10
        public void get_enableProjection(){} // RVA: 0x7FFAC999CD70
        public void set_enableProjection(){} // RVA: 0x7FFAC999CDC0
        public void get_projectionDistance(){} // RVA: 0x7FFAC999CE20
        public void set_projectionDistance(){} // RVA: 0x7FFAC999CE70
        public void get_projectionAngle(){} // RVA: 0x7FFAC999CED0
        public void set_projectionAngle(){} // RVA: 0x7FFAC999CF20
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_swingAxis_Injected(){} // RVA: 0x7FFAC999CF80
        public void set_swingAxis_Injected(){} // RVA: 0x7FFAC999CFE0
        public void get_twistLimitSpring_Injected(){} // RVA: 0x7FFAC999D040
        public void set_twistLimitSpring_Injected(){} // RVA: 0x7FFAC999D0A0
        public void get_swingLimitSpring_Injected(){} // RVA: 0x7FFAC999D100
        public void set_swingLimitSpring_Injected(){} // RVA: 0x7FFAC999D160
        public void get_lowTwistLimit_Injected(){} // RVA: 0x7FFAC999D1C0
        public void set_lowTwistLimit_Injected(){} // RVA: 0x7FFAC999D220
        public void get_highTwistLimit_Injected(){} // RVA: 0x7FFAC999D280
        public void set_highTwistLimit_Injected(){} // RVA: 0x7FFAC999D2E0
        public void get_swing1Limit_Injected(){} // RVA: 0x7FFAC999D340
        public void set_swing1Limit_Injected(){} // RVA: 0x7FFAC999D3A0
        public void get_swing2Limit_Injected(){} // RVA: 0x7FFAC999D400
        public void set_swing2Limit_Injected(){} // RVA: 0x7FFAC999D460
    }

    public class CircleCollider2D : Collider2D
    {
        public object radius;

        // ── Methods ──
        public void get_radius(){} // RVA: 0x7FFAC9980A40
        public void set_radius(){} // RVA: 0x7FFAC9980A90
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class ClassLibraryInitializer : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC98A8150
        public void InitStdErrWithHandle(){} // RVA: 0x7FFAC98BAD40
        public void InitAssemblyRedirections(){} // RVA: 0x7FFAC98BB060
    }

    public class Cloth : Component
    {
        public float vertices; // 0x18
        public bool normals; // 0x1C

        // ── Methods ──
        public void get_vertices(){} // RVA: 0x7FFAC984CD30
        public void get_normals(){} // RVA: 0x7FFAC984CD80
        public void get_coefficients(){} // RVA: 0x7FFAC984CDD0
        public void set_coefficients(){} // RVA: 0x7FFAC984CE20
        public void get_capsuleColliders(){} // RVA: 0x7FFAC984CE80
        public void set_capsuleColliders(){} // RVA: 0x7FFAC984CED0
        public void get_sphereColliders(){} // RVA: 0x7FFAC984CF30
        public void set_sphereColliders(){} // RVA: 0x7FFAC984CF80
        public void get_sleepThreshold(){} // RVA: 0x7FFAC984CFE0
        public void set_sleepThreshold(){} // RVA: 0x7FFAC984D030
        public void get_bendingStiffness(){} // RVA: 0x7FFAC984D090
        public void set_bendingStiffness(){} // RVA: 0x7FFAC984D0E0
        public void get_stretchingStiffness(){} // RVA: 0x7FFAC984D140
        public void set_stretchingStiffness(){} // RVA: 0x7FFAC984D190
        public void get_damping(){} // RVA: 0x7FFAC984D1F0
        public void set_damping(){} // RVA: 0x7FFAC984D240
        public void get_externalAcceleration(){} // RVA: 0x7FFAC984D2A0
        public void set_externalAcceleration(){} // RVA: 0x7FFAC984D310
        public void get_randomAcceleration(){} // RVA: 0x7FFAC984D370
        public void set_randomAcceleration(){} // RVA: 0x7FFAC984D3E0
        public void get_useGravity(){} // RVA: 0x7FFAC984D440
        public void set_useGravity(){} // RVA: 0x7FFAC984D490
        public void get_enabled(){} // RVA: 0x7FFAC984D4F0
        public void set_enabled(){} // RVA: 0x7FFAC984D540
        public void get_friction(){} // RVA: 0x7FFAC984D5A0
        public void set_friction(){} // RVA: 0x7FFAC984D5F0
        public void get_collisionMassScale(){} // RVA: 0x7FFAC984D650
        public void set_collisionMassScale(){} // RVA: 0x7FFAC984D6A0
        public void get_enableContinuousCollision(){} // RVA: 0x7FFAC984D700
        public void set_enableContinuousCollision(){} // RVA: 0x7FFAC984D750
        public void get_useVirtualParticles(){} // RVA: 0x7FFAC984D7B0
        public void set_useVirtualParticles(){} // RVA: 0x7FFAC984D800
        public void get_worldVelocityScale(){} // RVA: 0x7FFAC984D860
        public void set_worldVelocityScale(){} // RVA: 0x7FFAC984D8B0
        public void get_worldAccelerationScale(){} // RVA: 0x7FFAC984D910
        public void set_worldAccelerationScale(){} // RVA: 0x7FFAC984D960
        public void get_clothSolverFrequency(){} // RVA: 0x7FFAC984D9C0
        public void set_clothSolverFrequency(){} // RVA: 0x7FFAC984DA10
        public void get_solverFrequency(){} // RVA: 0x7FFAC984DA70
        public void set_solverFrequency(){} // RVA: 0x7FFAC984DAD0
        public void get_useTethers(){} // RVA: 0x7FFAC984DB50
        public void set_useTethers(){} // RVA: 0x7FFAC984DBA0
        public void get_stiffnessFrequency(){} // RVA: 0x7FFAC984DC00
        public void set_stiffnessFrequency(){} // RVA: 0x7FFAC984DC50
        public void get_selfCollisionDistance(){} // RVA: 0x7FFAC984DCB0
        public void set_selfCollisionDistance(){} // RVA: 0x7FFAC984DD00
        public void get_selfCollisionStiffness(){} // RVA: 0x7FFAC984DD60
        public void set_selfCollisionStiffness(){} // RVA: 0x7FFAC984DDB0
        public void ClearTransformMotion(){} // RVA: 0x7FFAC984DE10
        public void GetSelfAndInterCollisionIndices(){} // RVA: 0x7FFAC984DE60
        public void SetSelfAndInterCollisionIndices(){} // RVA: 0x7FFAC984DEC0
        public void GetVirtualParticleIndices(){} // RVA: 0x7FFAC984DF20
        public void SetVirtualParticleIndices(){} // RVA: 0x7FFAC984DF80
        public void GetVirtualParticleWeights(){} // RVA: 0x7FFAC984DFE0
        public void SetVirtualParticleWeights(){} // RVA: 0x7FFAC984E040
        public void get_useContinuousCollision(){} // RVA: 0x7FFAC2F25CF0
        public void set_useContinuousCollision(){} // RVA: 0x7FFAC2F3C4D0
        public void get_selfCollision(){} // RVA: 0x7FFAC2F3C390
        public void SetEnabledFading(){} // RVA: 0x7FFAC984E110 | overloaded x2
        public void Raycast(){} // RVA: 0x7FFAC984E180
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_externalAcceleration_Injected(){} // RVA: 0x7FFAC984E220
        public void set_externalAcceleration_Injected(){} // RVA: 0x7FFAC984E280
        public void get_randomAcceleration_Injected(){} // RVA: 0x7FFAC984E2E0
        public void set_randomAcceleration_Injected(){} // RVA: 0x7FFAC984E340
        public void Raycast_Injected(){} // RVA: 0x7FFAC984E3A0
    }

    public class ClothSkinningCoefficient : ValueType
    {
        public float maxDistance; // 0x10
        public float collisionSphereDistance; // 0x14
    }

    public class ClothSphereColliderPair : ValueType
    {
        public UnityEngine.SphereCollider first; // 0x10
        public UnityEngine.SphereCollider second; // 0x18

        // ── Methods ──
        public void get_first(){} // RVA: 0x7FFAC3AD9F60
        public void get_second(){} // RVA: 0x7FFAC4420220
    }

    public class Collider : Component
    {
        public object enabled;
        public object attachedRigidbody;
        public object attachedArticulationBody;
        public object isTrigger;
        public object contactOffset;
        public object bounds;
        public object hasModifiableContacts;
        public object providesContacts;
        public object layerOverridePriority;
        public object excludeLayers;
        public object includeLayers;
        public object sharedMaterial;
        public object material;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFAC9998120
        public void set_enabled(){} // RVA: 0x7FFAC9998170
        public void get_attachedRigidbody(){} // RVA: 0x7FFAC99981D0
        public void get_attachedArticulationBody(){} // RVA: 0x7FFAC9998220
        public void get_isTrigger(){} // RVA: 0x7FFAC9998270
        public void set_isTrigger(){} // RVA: 0x7FFAC99982C0
        public void get_contactOffset(){} // RVA: 0x7FFAC9998320
        public void set_contactOffset(){} // RVA: 0x7FFAC9998370
        public void ClosestPoint(){} // RVA: 0x7FFAC99983D0
        public void get_bounds(){} // RVA: 0x7FFAC9998450
        public void get_hasModifiableContacts(){} // RVA: 0x7FFAC99984C0
        public void set_hasModifiableContacts(){} // RVA: 0x7FFAC9998510
        public void get_providesContacts(){} // RVA: 0x7FFAC9998570
        public void set_providesContacts(){} // RVA: 0x7FFAC99985C0
        public void get_layerOverridePriority(){} // RVA: 0x7FFAC9998620
        public void set_layerOverridePriority(){} // RVA: 0x7FFAC9998670
        public void get_excludeLayers(){} // RVA: 0x7FFAC99986D0
        public void set_excludeLayers(){} // RVA: 0x7FFAC9998730
        public void get_includeLayers(){} // RVA: 0x7FFAC9998790
        public void set_includeLayers(){} // RVA: 0x7FFAC99987F0
        public void get_sharedMaterial(){} // RVA: 0x7FFAC9998850
        public void set_sharedMaterial(){} // RVA: 0x7FFAC99988A0
        public void get_material(){} // RVA: 0x7FFAC9998900
        public void set_material(){} // RVA: 0x7FFAC9998950
        public void Raycast(){} // RVA: 0x7FFAC9998A50 | overloaded x2
        public void Internal_ClosestPointOnBounds(){} // RVA: 0x7FFAC9998B40
        public void ClosestPointOnBounds(){} // RVA: 0x7FFAC9998BC0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void ClosestPoint_Injected(){} // RVA: 0x7FFAC9998CB0
        public void get_bounds_Injected(){} // RVA: 0x7FFAC9998D20
        public void get_excludeLayers_Injected(){} // RVA: 0x7FFAC9998D80
        public void set_excludeLayers_Injected(){} // RVA: 0x7FFAC9998DE0
        public void get_includeLayers_Injected(){} // RVA: 0x7FFAC9998E40
        public void set_includeLayers_Injected(){} // RVA: 0x7FFAC9998EA0
        public void Raycast_Injected(){} // RVA: 0x7FFAC9998F00
        public void Internal_ClosestPointOnBounds_Injected(){} // RVA: 0x7FFAC9998F90
    }

    public class Collider2D : Behaviour
    {
        public object density;
        public object isTrigger;
        public object usedByEffector;
        public object usedByComposite;
        public object composite;
        public object offset;
        public object attachedRigidbody;
        public object shapeCount;
        public object bounds;
        public object errorState;
        public object sharedMaterial;
        public object layerOverridePriority;
        public object excludeLayers;
        public object includeLayers;
        public object forceSendLayers;
        public object forceReceiveLayers;
        public object contactCaptureLayers;
        public object callbackLayers;
        public object friction;
        public object bounciness;

        // ── Methods ──
        public void get_density(){} // RVA: 0x7FFAC997D6D0
        public void set_density(){} // RVA: 0x7FFAC997D720
        public void get_isTrigger(){} // RVA: 0x7FFAC997D780
        public void set_isTrigger(){} // RVA: 0x7FFAC997D7D0
        public void get_usedByEffector(){} // RVA: 0x7FFAC997D830
        public void set_usedByEffector(){} // RVA: 0x7FFAC997D880
        public void get_usedByComposite(){} // RVA: 0x7FFAC997D8E0
        public void set_usedByComposite(){} // RVA: 0x7FFAC997D930
        public void get_composite(){} // RVA: 0x7FFAC997D990
        public void get_offset(){} // RVA: 0x7FFAC997D9E0
        public void set_offset(){} // RVA: 0x7FFAC997DA40
        public void get_attachedRigidbody(){} // RVA: 0x7FFAC997DAA0
        public void get_shapeCount(){} // RVA: 0x7FFAC997DAF0
        public void CreateMesh(){} // RVA: 0x7FFAC997DB40
        public void GetShapeHash(){} // RVA: 0x7FFAC997DBC0
        public void GetShapes(){} // RVA: 0x7FFAC997DCA0 | overloaded x2
        public void GetShapes_Internal(){} // RVA: 0x7FFAC997DE40
        public void get_bounds(){} // RVA: 0x7FFAC997DEC0
        public void get_errorState(){} // RVA: 0x7FFAC997DF30
        public void get_sharedMaterial(){} // RVA: 0x7FFAC997DF80
        public void set_sharedMaterial(){} // RVA: 0x7FFAC997DFD0
        public void get_layerOverridePriority(){} // RVA: 0x7FFAC997E030
        public void set_layerOverridePriority(){} // RVA: 0x7FFAC997E080
        public void get_excludeLayers(){} // RVA: 0x7FFAC997E0E0
        public void set_excludeLayers(){} // RVA: 0x7FFAC997E140
        public void get_includeLayers(){} // RVA: 0x7FFAC997E1A0
        public void set_includeLayers(){} // RVA: 0x7FFAC997E200
        public void get_forceSendLayers(){} // RVA: 0x7FFAC997E260
        public void set_forceSendLayers(){} // RVA: 0x7FFAC997E2C0
        public void get_forceReceiveLayers(){} // RVA: 0x7FFAC997E320
        public void set_forceReceiveLayers(){} // RVA: 0x7FFAC997E380
        public void get_contactCaptureLayers(){} // RVA: 0x7FFAC997E3E0
        public void set_contactCaptureLayers(){} // RVA: 0x7FFAC997E440
        public void get_callbackLayers(){} // RVA: 0x7FFAC997E4A0
        public void set_callbackLayers(){} // RVA: 0x7FFAC997E500
        public void get_friction(){} // RVA: 0x7FFAC997E560
        public void get_bounciness(){} // RVA: 0x7FFAC997E5B0
        public void IsTouching(){} // RVA: 0x7FFAC997E750 | overloaded x3
        public void IsTouching_OtherColliderWithFilter(){} // RVA: 0x7FFAC997E6E0
        public void IsTouching_AnyColliderWithFilter(){} // RVA: 0x7FFAC997E7C0
        public void IsTouchingLayers(){} // RVA: 0x7FFAC997E880 | overloaded x2
        public void OverlapPoint(){} // RVA: 0x7FFAC997E8E0
        public void Distance(){} // RVA: 0x7FFAC997E940
        public void OverlapCollider(){} // RVA: 0x7FFAC9964EF0 | overloaded x2
        public void GetContacts(){} // RVA: 0x7FFAC997EE80 | overloaded x8
        public void Cast(){} // RVA: 0x7FFAC997F7D0 | overloaded x7
        public void CastArray_Internal(){} // RVA: 0x7FFAC997F730
        public void CastList_Internal(){} // RVA: 0x7FFAC997F880
        public void Raycast(){} // RVA: 0x7FFAC997FF90 | overloaded x8
        public void RaycastArray_Internal(){} // RVA: 0x7FFAC997FF00
        public void RaycastList_Internal(){} // RVA: 0x7FFAC9980030
        public void ClosestPoint(){} // RVA: 0x7FFAC99800C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_offset_Injected(){} // RVA: 0x7FFAC9980130
        public void set_offset_Injected(){} // RVA: 0x7FFAC9980190
        public void get_bounds_Injected(){} // RVA: 0x7FFAC99801F0
        public void get_excludeLayers_Injected(){} // RVA: 0x7FFAC9980250
        public void set_excludeLayers_Injected(){} // RVA: 0x7FFAC99802B0
        public void get_includeLayers_Injected(){} // RVA: 0x7FFAC9980310
        public void set_includeLayers_Injected(){} // RVA: 0x7FFAC9980370
        public void get_forceSendLayers_Injected(){} // RVA: 0x7FFAC99803D0
        public void set_forceSendLayers_Injected(){} // RVA: 0x7FFAC9980430
        public void get_forceReceiveLayers_Injected(){} // RVA: 0x7FFAC9980490
        public void set_forceReceiveLayers_Injected(){} // RVA: 0x7FFAC99804F0
        public void get_contactCaptureLayers_Injected(){} // RVA: 0x7FFAC9980550
        public void set_contactCaptureLayers_Injected(){} // RVA: 0x7FFAC99805B0
        public void get_callbackLayers_Injected(){} // RVA: 0x7FFAC9980610
        public void set_callbackLayers_Injected(){} // RVA: 0x7FFAC9980670
        public void IsTouching_OtherColliderWithFilter_Injected(){} // RVA: 0x7FFAC99806D0
        public void IsTouching_AnyColliderWithFilter_Injected(){} // RVA: 0x7FFAC9980740
        public void OverlapPoint_Injected(){} // RVA: 0x7FFAC99807A0
        public void CastArray_Internal_Injected(){} // RVA: 0x7FFAC9980800
        public void CastList_Internal_Injected(){} // RVA: 0x7FFAC9980890
        public void RaycastArray_Internal_Injected(){} // RVA: 0x7FFAC9980920
        public void RaycastList_Internal_Injected(){} // RVA: 0x7FFAC99809B0
    }

    public class ColliderDistance2D : ValueType
    {
        public UnityEngine.Vector2 pointA; // 0x10
        public UnityEngine.Vector2 pointB; // 0x18
        public UnityEngine.Vector2 normal; // 0x20
        public float distance; // 0x28
        public int isOverlapped; // 0x2C

        // ── Methods ──
        public void get_pointA(){} // RVA: 0x7FFAC51D9A30
        public void set_pointA(){} // RVA: 0x7FFAC45BB120
        public void get_pointB(){} // RVA: 0x7FFAC9866820
        public void set_pointB(){} // RVA: 0x7FFAC4A068C0
        public void get_normal(){} // RVA: 0x7FFAC9977900
        public void get_distance(){} // RVA: 0x7FFAC9811DF0
        public void set_distance(){} // RVA: 0x7FFAC2F3C4D0
        public void get_isOverlapped(){} // RVA: 0x7FFAC9977920
        public void get_isValid(){} // RVA: 0x7FFAC9812620
        public void set_isValid(){} // RVA: 0x7FFAC9812630
    }

    public class Collision : Object
    {
        public UnityEngine.ContactPairHeader impulse; // 0x10
        public UnityEngine.ContactPair relativeVelocity; // 0x38
        public bool rigidbody; // 0x60
        public UnityEngine.ContactPoint[] articulationBody; // 0x68

        // ── Methods ──
        public void get_impulse(){} // RVA: 0x7FFAC2F87FA0
        public void get_relativeVelocity(){} // RVA: 0x7FFAC9987650
        public void get_rigidbody(){} // RVA: 0x7FFAC99876B0
        public void get_articulationBody(){} // RVA: 0x7FFAC9987750
        public void get_body(){} // RVA: 0x7FFAC99877F0
        public void get_collider(){} // RVA: 0x7FFAC9987820
        public void get_transform(){} // RVA: 0x7FFAC9987850
        public void get_gameObject(){} // RVA: 0x7FFAC99879D0
        public void set_Flipped(){} // RVA: 0x7FFAC2F4A030
        public void get_contactCount(){} // RVA: 0x7FFAC9987B70
        public void get_contacts(){} // RVA: 0x7FFAC9987B80
        public void .ctor(){} // RVA: 0x7FFAC9987D00 | overloaded x2
        public void Reuse(){} // RVA: 0x7FFAC9987E60
        public void GetContact(){} // RVA: 0x7FFAC9987EF0
        public void GetContacts(){} // RVA: 0x7FFAC9988250 | overloaded x2
    }

    public class Collision2D : Object
    {
        public int collider; // 0x10
        public int otherCollider; // 0x14
        public int rigidbody; // 0x18
        public int otherRigidbody; // 0x1C
        public UnityEngine.Vector2 transform; // 0x20
        public int gameObject; // 0x28
        public int relativeVelocity; // 0x2C
        public UnityEngine.ContactPoint2D[] enabled; // 0x30
        public UnityEngine.ContactPoint2D[] contacts; // 0x38

        // ── Methods ──
        public void GetContacts_Internal(){} // RVA: 0x7FFAC9977F90
        public void get_collider(){} // RVA: 0x7FFAC9977FB0
        public void get_otherCollider(){} // RVA: 0x7FFAC99780A0
        public void get_rigidbody(){} // RVA: 0x7FFAC9978190
        public void get_otherRigidbody(){} // RVA: 0x7FFAC9978250
        public void get_transform(){} // RVA: 0x7FFAC9978310
        public void get_gameObject(){} // RVA: 0x7FFAC9978490
        public void get_relativeVelocity(){} // RVA: 0x7FFAC9978610
        public void get_enabled(){} // RVA: 0x7FFAC9978630
        public void get_contacts(){} // RVA: 0x7FFAC9978640
        public void get_contactCount(){} // RVA: 0x7FFAC9814E40
        public void GetContact(){} // RVA: 0x7FFAC9978800
        public void GetContacts(){} // RVA: 0x7FFAC9978A90 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Color : ValueType
    {
        public float red; // 0x10
        public float green; // 0x14
        public float blue; // 0x18
        public float white; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98A8410 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC98A8450 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFAC515C940
        public void Equals(){} // RVA: 0x7FFAC487E150 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFAC98A8740
        public void op_Subtraction(){} // RVA: 0x7FFAC98A87A0
        public void op_Multiply(){} // RVA: 0x7FFAC98A88B0 | overloaded x3
        public void op_Division(){} // RVA: 0x7FFAC98A8900
        public void op_Equality(){} // RVA: 0x7FFAC98A8920
        public void op_Inequality(){} // RVA: 0x7FFAC98A8990
        public void Lerp(){} // RVA: 0x7FFAC2F6DEC0
        public void LerpUnclamped(){} // RVA: 0x7FFAC98A8A00
        public void RGBMultiplied(){} // RVA: 0x7FFAC98A8A80
        public void get_red(){} // RVA: 0x7FFAC2F6E260
        public void get_green(){} // RVA: 0x7FFAC2F455D0
        public void get_blue(){} // RVA: 0x7FFAC33FB2C0
        public void get_white(){} // RVA: 0x7FFAC2F971E0
        public void get_black(){} // RVA: 0x7FFAC2F45950
        public void get_yellow(){} // RVA: 0x7FFAC2F45590
        public void get_cyan(){} // RVA: 0x7FFAC98A8AD0
        public void get_magenta(){} // RVA: 0x7FFAC30C6D20
        public void get_gray(){} // RVA: 0x7FFAC2F45A50
        public void get_grey(){} // RVA: 0x7FFAC2F45A50
        public void get_clear(){} // RVA: 0x7FFAC3372CF0
        public void get_grayscale(){} // RVA: 0x7FFAC98A8AE0
        public void get_linear(){} // RVA: 0x7FFAC8D26360
        public void get_gamma(){} // RVA: 0x7FFAC98A8B20
        public void get_maxColorComponent(){} // RVA: 0x7FFAC98A8C70
        public void op_Implicit(){} // RVA: 0x7FFAC98A8C90 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAC89067F0
        public void set_Item(){} // RVA: 0x7FFAC98A8CB0
        public void RGBToHSV(){} // RVA: 0x7FFAC98A8D80
        public void RGBToHSVHelper(){} // RVA: 0x7FFAC98A8E20
        public void HSVToRGB(){} // RVA: 0x7FFAC98A8F00 | overloaded x2
    }

    public class Color32 : ValueType
    {
        public int Item; // 0x10
        public byte r; // 0x10
        public byte g; // 0x11
        public byte b; // 0x12
        public byte a; // 0x13

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3115270
        public void op_Implicit(){} // RVA: 0x7FFAC98A92F0 | overloaded x2
        public void Lerp(){} // RVA: 0x7FFAC98A9370
        public void LerpUnclamped(){} // RVA: 0x7FFAC3A6B490
        public void get_Item(){} // RVA: 0x7FFAC98A9480
        public void set_Item(){} // RVA: 0x7FFAC98A9550
        public void ToString(){} // RVA: 0x7FFAC98A9640 | overloaded x3
    }

    public class ColorUsageAttribute : PropertyAttribute
    {
        public bool showAlpha; // 0x10
        public bool hdr; // 0x11
        public float minBrightness; // 0x14
        public float maxBrightness; // 0x18
        public float minExposureValue; // 0x1C
        public float maxExposureValue; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98B7E30 | overloaded x2
    }

    public class ColorUtility : Object
    {
        // ── Methods ──
        public void DoTryParseHtmlColor(){} // RVA: 0x7FFAC98A9880
        public void TryParseHtmlString(){} // RVA: 0x7FFAC98A98E0
        public void ToHtmlStringRGB(){} // RVA: 0x7FFAC98A99D0
        public void ToHtmlStringRGBA(){} // RVA: 0x7FFAC98A9BF0
    }

    public class CombineInstance : ValueType
    {
        public int mesh; // 0x10
        public int subMeshIndex; // 0x14
        public UnityEngine.Matrix4x4 transform; // 0x18
        public UnityEngine.Vector4 lightmapScaleOffset; // 0x58
        public UnityEngine.Vector4 realtimeLightmapScaleOffset; // 0x68

        // ── Methods ──
        public void get_mesh(){} // RVA: 0x7FFAC98976E0
        public void set_mesh(){} // RVA: 0x7FFAC9897730
        public void get_subMeshIndex(){} // RVA: 0x7FFAC69CBEA0
        public void set_subMeshIndex(){} // RVA: 0x7FFAC4420230
        public void get_transform(){} // RVA: 0x7FFAC9897820
        public void set_transform(){} // RVA: 0x7FFAC9897850
        public void get_lightmapScaleOffset(){} // RVA: 0x7FFAC9897870
        public void set_lightmapScaleOffset(){} // RVA: 0x7FFAC87B5A10
        public void get_realtimeLightmapScaleOffset(){} // RVA: 0x7FFAC9897880
        public void set_realtimeLightmapScaleOffset(){} // RVA: 0x7FFAC9897890
    }

    public class Component : Object
    {
        public object transform;
        public object gameObject;
        public object tag;

        // ── Methods ──
        public void get_transform(){} // RVA: 0x7FFAC33BCDF0
        public void get_gameObject(){} // RVA: 0x7FFAC33BD180
        public void GetComponent(){} // RVA: 0x7FFAC98BC070 | overloaded x3
        public void GetComponentFastPath(){} // RVA: 0x7FFAC98BBE20
        public void TryGetComponent(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void GetComponentInChildren(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void GetComponentsInChildren(){} // RVA: 0x7FFAC2C70A40 | overloaded x6
        public void GetComponentInParent(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void GetComponentsInParent(){} // RVA: 0x7FFAC2C58E90 | overloaded x5
        public void GetComponents(){} // RVA: 0x7FFAC2C58E90 | overloaded x4
        public void GetComponentsForListInternal(){} // RVA: 0x7FFAC98BC4E0
        public void get_tag(){} // RVA: 0x7FFAC98BC560
        public void set_tag(){} // RVA: 0x7FFAC98BC600
        public void GetComponentIndex(){} // RVA: 0x7FFAC31D8770
        public void CompareTag(){} // RVA: 0x7FFAC98BC6B0
        public void SendMessageUpwards(){} // RVA: 0x7FFAC98BC7E0 | overloaded x2
        public void SendMessage(){} // RVA: 0x7FFAC98BC920 | overloaded x4
        public void BroadcastMessage(){} // RVA: 0x7FFAC98BCA00 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class CompositeCollider2D : Collider2D
    {
        public object geometryType;
        public object generationType;
        public object useDelaunayMesh;
        public object vertexDistance;
        public object edgeRadius;
        public object offsetDistance;
        public object pathCount;
        public object pointCount;

        // ── Methods ──
        public void get_geometryType(){} // RVA: 0x7FFAC9982190
        public void set_geometryType(){} // RVA: 0x7FFAC99821E0
        public void get_generationType(){} // RVA: 0x7FFAC9982240
        public void set_generationType(){} // RVA: 0x7FFAC9982290
        public void get_useDelaunayMesh(){} // RVA: 0x7FFAC99822F0
        public void set_useDelaunayMesh(){} // RVA: 0x7FFAC9982340
        public void get_vertexDistance(){} // RVA: 0x7FFAC99823A0
        public void set_vertexDistance(){} // RVA: 0x7FFAC99823F0
        public void get_edgeRadius(){} // RVA: 0x7FFAC9982450
        public void set_edgeRadius(){} // RVA: 0x7FFAC99824A0
        public void get_offsetDistance(){} // RVA: 0x7FFAC9982500
        public void set_offsetDistance(){} // RVA: 0x7FFAC9982550
        public void GenerateGeometry(){} // RVA: 0x7FFAC99825B0
        public void GetPathPointCount(){} // RVA: 0x7FFAC9982600
        public void GetPathPointCount_Internal(){} // RVA: 0x7FFAC9982770
        public void get_pathCount(){} // RVA: 0x7FFAC99827D0
        public void get_pointCount(){} // RVA: 0x7FFAC9982820
        public void GetPath(){} // RVA: 0x7FFAC9982AB0 | overloaded x2
        public void GetPathArray_Internal(){} // RVA: 0x7FFAC9982A40
        public void GetPathList_Internal(){} // RVA: 0x7FFAC9982C80
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class ComputeBuffer : Object
    {
        public UIntPtr count; // 0x10

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFAC98C9130
        public void Dispose(){} // RVA: 0x7FFAC98C92A0 | overloaded x2
        public void InitBuffer(){} // RVA: 0x7FFAC98C9380
        public void DestroyBuffer(){} // RVA: 0x7FFAC98C9400
        public void .ctor(){} // RVA: 0x7FFAC98C94B0 | overloaded x3
        public void Release(){} // RVA: 0x7FFAC98C91D0
        public void IsValidBuffer(){} // RVA: 0x7FFAC98C9700
        public void IsValid(){} // RVA: 0x7FFAC98C9750
        public void get_count(){} // RVA: 0x7FFAC98C97C0
        public void get_stride(){} // RVA: 0x7FFAC98C9810
        public void SetData(){} // RVA: 0x7FFAC98C9A00 | overloaded x2
        public void InternalSetData(){} // RVA: 0x7FFAC98C9CA0
        public void GetData(){} // RVA: 0x7FFAC98C9D30
        public void InternalGetData(){} // RVA: 0x7FFAC98C9F00
        public void set_name(){} // RVA: 0x7FFAC98C9F90
        public void SetName(){} // RVA: 0x7FFAC98C9F90
        public void SetCounterValue(){} // RVA: 0x7FFAC98C9FF0
        public void CopyCount(){} // RVA: 0x7FFAC98CA050
    }

    public class ComputeShader : Object
    {
        // ── Methods ──
        public void FindKernel(){} // RVA: 0x7FFAC98CA0C0
        public void SetFloat(){} // RVA: 0x7FFAC98CA120
        public void SetInt(){} // RVA: 0x7FFAC98CA190
        public void SetVector(){} // RVA: 0x7FFAC98CA200
        public void SetMatrix(){} // RVA: 0x7FFAC98CA270
        public void SetVectorArray(){} // RVA: 0x7FFAC98CA2E0
        public void SetTexture(){} // RVA: 0x7FFAC98CA5D0 | overloaded x2
        public void Internal_SetBuffer(){} // RVA: 0x7FFAC98CA3D0
        public void SetBuffer(){} // RVA: 0x7FFAC98CA3D0
        public void GetKernelThreadGroupSizes(){} // RVA: 0x7FFAC98CA450
        public void Dispatch(){} // RVA: 0x7FFAC98CA4D0
        public void SetBool(){} // RVA: 0x7FFAC98CA550
        public void SetVector_Injected(){} // RVA: 0x7FFAC98CA660
        public void SetMatrix_Injected(){} // RVA: 0x7FFAC98CA6D0
    }

    public class ConfigurableJoint : Joint
    {
        public object secondaryAxis;
        public object xMotion;
        public object yMotion;
        public object zMotion;
        public object angularXMotion;
        public object angularYMotion;
        public object angularZMotion;
        public object linearLimitSpring;
        public object angularXLimitSpring;
        public object angularYZLimitSpring;
        public object linearLimit;
        public object lowAngularXLimit;
        public object highAngularXLimit;
        public object angularYLimit;
        public object angularZLimit;
        public object targetPosition;
        public object targetVelocity;
        public object xDrive;
        public object yDrive;
        public object zDrive;
        public object targetRotation;
        public object targetAngularVelocity;
        public object rotationDriveMode;
        public object angularXDrive;
        public object angularYZDrive;
        public object slerpDrive;
        public object projectionMode;
        public object projectionDistance;
        public object projectionAngle;
        public object configuredInWorldSpace;
        public object swapBodies;

        // ── Methods ──
        public void get_secondaryAxis(){} // RVA: 0x7FFAC999D4C0
        public void set_secondaryAxis(){} // RVA: 0x7FFAC999D530
        public void get_xMotion(){} // RVA: 0x7FFAC999D590
        public void set_xMotion(){} // RVA: 0x7FFAC999D5E0
        public void get_yMotion(){} // RVA: 0x7FFAC999D640
        public void set_yMotion(){} // RVA: 0x7FFAC999D690
        public void get_zMotion(){} // RVA: 0x7FFAC999D6F0
        public void set_zMotion(){} // RVA: 0x7FFAC999D740
        public void get_angularXMotion(){} // RVA: 0x7FFAC999D7A0
        public void set_angularXMotion(){} // RVA: 0x7FFAC999D7F0
        public void get_angularYMotion(){} // RVA: 0x7FFAC999D850
        public void set_angularYMotion(){} // RVA: 0x7FFAC999D8A0
        public void get_angularZMotion(){} // RVA: 0x7FFAC999D900
        public void set_angularZMotion(){} // RVA: 0x7FFAC999D950
        public void get_linearLimitSpring(){} // RVA: 0x7FFAC999D9B0
        public void set_linearLimitSpring(){} // RVA: 0x7FFAC999DA10
        public void get_angularXLimitSpring(){} // RVA: 0x7FFAC999DA70
        public void set_angularXLimitSpring(){} // RVA: 0x7FFAC999DAD0
        public void get_angularYZLimitSpring(){} // RVA: 0x7FFAC999DB30
        public void set_angularYZLimitSpring(){} // RVA: 0x7FFAC999DB90
        public void get_linearLimit(){} // RVA: 0x7FFAC999DBF0
        public void set_linearLimit(){} // RVA: 0x7FFAC999DC60
        public void get_lowAngularXLimit(){} // RVA: 0x7FFAC999DCC0
        public void set_lowAngularXLimit(){} // RVA: 0x7FFAC999DD30
        public void get_highAngularXLimit(){} // RVA: 0x7FFAC999DD90
        public void set_highAngularXLimit(){} // RVA: 0x7FFAC999DE00
        public void get_angularYLimit(){} // RVA: 0x7FFAC999DE60
        public void set_angularYLimit(){} // RVA: 0x7FFAC999DED0
        public void get_angularZLimit(){} // RVA: 0x7FFAC999DF30
        public void set_angularZLimit(){} // RVA: 0x7FFAC999DFA0
        public void get_targetPosition(){} // RVA: 0x7FFAC999E000
        public void set_targetPosition(){} // RVA: 0x7FFAC999E070
        public void get_targetVelocity(){} // RVA: 0x7FFAC999E0D0
        public void set_targetVelocity(){} // RVA: 0x7FFAC999E140
        public void get_xDrive(){} // RVA: 0x7FFAC999E1A0
        public void set_xDrive(){} // RVA: 0x7FFAC999E210
        public void get_yDrive(){} // RVA: 0x7FFAC999E270
        public void set_yDrive(){} // RVA: 0x7FFAC999E2E0
        public void get_zDrive(){} // RVA: 0x7FFAC999E340
        public void set_zDrive(){} // RVA: 0x7FFAC999E3B0
        public void get_targetRotation(){} // RVA: 0x7FFAC999E410
        public void set_targetRotation(){} // RVA: 0x7FFAC999E480
        public void get_targetAngularVelocity(){} // RVA: 0x7FFAC999E4E0
        public void set_targetAngularVelocity(){} // RVA: 0x7FFAC999E550
        public void get_rotationDriveMode(){} // RVA: 0x7FFAC999E5B0
        public void set_rotationDriveMode(){} // RVA: 0x7FFAC999E600
        public void get_angularXDrive(){} // RVA: 0x7FFAC999E660
        public void set_angularXDrive(){} // RVA: 0x7FFAC999E6D0
        public void get_angularYZDrive(){} // RVA: 0x7FFAC999E730
        public void set_angularYZDrive(){} // RVA: 0x7FFAC999E7A0
        public void get_slerpDrive(){} // RVA: 0x7FFAC999E800
        public void set_slerpDrive(){} // RVA: 0x7FFAC999E870
        public void get_projectionMode(){} // RVA: 0x7FFAC999E8D0
        public void set_projectionMode(){} // RVA: 0x7FFAC999E920
        public void get_projectionDistance(){} // RVA: 0x7FFAC999E980
        public void set_projectionDistance(){} // RVA: 0x7FFAC999E9D0
        public void get_projectionAngle(){} // RVA: 0x7FFAC999EA30
        public void set_projectionAngle(){} // RVA: 0x7FFAC999EA80
        public void get_configuredInWorldSpace(){} // RVA: 0x7FFAC999EAE0
        public void set_configuredInWorldSpace(){} // RVA: 0x7FFAC999EB30
        public void get_swapBodies(){} // RVA: 0x7FFAC999EB90
        public void set_swapBodies(){} // RVA: 0x7FFAC999EBE0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_secondaryAxis_Injected(){} // RVA: 0x7FFAC999EC40
        public void set_secondaryAxis_Injected(){} // RVA: 0x7FFAC999ECA0
        public void get_linearLimitSpring_Injected(){} // RVA: 0x7FFAC999ED00
        public void set_linearLimitSpring_Injected(){} // RVA: 0x7FFAC999ED60
        public void get_angularXLimitSpring_Injected(){} // RVA: 0x7FFAC999EDC0
        public void set_angularXLimitSpring_Injected(){} // RVA: 0x7FFAC999EE20
        public void get_angularYZLimitSpring_Injected(){} // RVA: 0x7FFAC999EE80
        public void set_angularYZLimitSpring_Injected(){} // RVA: 0x7FFAC999EEE0
        public void get_linearLimit_Injected(){} // RVA: 0x7FFAC999EF40
        public void set_linearLimit_Injected(){} // RVA: 0x7FFAC999EFA0
        public void get_lowAngularXLimit_Injected(){} // RVA: 0x7FFAC999F000
        public void set_lowAngularXLimit_Injected(){} // RVA: 0x7FFAC999F060
        public void get_highAngularXLimit_Injected(){} // RVA: 0x7FFAC999F0C0
        public void set_highAngularXLimit_Injected(){} // RVA: 0x7FFAC999F120
        public void get_angularYLimit_Injected(){} // RVA: 0x7FFAC999F180
        public void set_angularYLimit_Injected(){} // RVA: 0x7FFAC999F1E0
        public void get_angularZLimit_Injected(){} // RVA: 0x7FFAC999F240
        public void set_angularZLimit_Injected(){} // RVA: 0x7FFAC999F2A0
        public void get_targetPosition_Injected(){} // RVA: 0x7FFAC999F300
        public void set_targetPosition_Injected(){} // RVA: 0x7FFAC999F360
        public void get_targetVelocity_Injected(){} // RVA: 0x7FFAC999F3C0
        public void set_targetVelocity_Injected(){} // RVA: 0x7FFAC999F420
        public void get_xDrive_Injected(){} // RVA: 0x7FFAC999F480
        public void set_xDrive_Injected(){} // RVA: 0x7FFAC999F4E0
        public void get_yDrive_Injected(){} // RVA: 0x7FFAC999F540
        public void set_yDrive_Injected(){} // RVA: 0x7FFAC999F5A0
        public void get_zDrive_Injected(){} // RVA: 0x7FFAC999F600
        public void set_zDrive_Injected(){} // RVA: 0x7FFAC999F660
        public void get_targetRotation_Injected(){} // RVA: 0x7FFAC999F6C0
        public void set_targetRotation_Injected(){} // RVA: 0x7FFAC999F720
        public void get_targetAngularVelocity_Injected(){} // RVA: 0x7FFAC999F780
        public void set_targetAngularVelocity_Injected(){} // RVA: 0x7FFAC999F7E0
        public void get_angularXDrive_Injected(){} // RVA: 0x7FFAC999F840
        public void set_angularXDrive_Injected(){} // RVA: 0x7FFAC999F8A0
        public void get_angularYZDrive_Injected(){} // RVA: 0x7FFAC999F900
        public void set_angularYZDrive_Injected(){} // RVA: 0x7FFAC999F960
        public void get_slerpDrive_Injected(){} // RVA: 0x7FFAC999F9C0
        public void set_slerpDrive_Injected(){} // RVA: 0x7FFAC999FA20
    }

    public class ConstantForce : Behaviour
    {
        public object force;
        public object relativeForce;
        public object torque;
        public object relativeTorque;

        // ── Methods ──
        public void get_force(){} // RVA: 0x7FFAC999A800
        public void set_force(){} // RVA: 0x7FFAC999A870
        public void get_relativeForce(){} // RVA: 0x7FFAC999A8D0
        public void set_relativeForce(){} // RVA: 0x7FFAC999A940
        public void get_torque(){} // RVA: 0x7FFAC999A9A0
        public void set_torque(){} // RVA: 0x7FFAC999AA10
        public void get_relativeTorque(){} // RVA: 0x7FFAC999AA70
        public void set_relativeTorque(){} // RVA: 0x7FFAC999AAE0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_force_Injected(){} // RVA: 0x7FFAC999AB40
        public void set_force_Injected(){} // RVA: 0x7FFAC999ABA0
        public void get_relativeForce_Injected(){} // RVA: 0x7FFAC999AC00
        public void set_relativeForce_Injected(){} // RVA: 0x7FFAC999AC60
        public void get_torque_Injected(){} // RVA: 0x7FFAC999ACC0
        public void set_torque_Injected(){} // RVA: 0x7FFAC999AD20
        public void get_relativeTorque_Injected(){} // RVA: 0x7FFAC999AD80
        public void set_relativeTorque_Injected(){} // RVA: 0x7FFAC999ADE0
    }

    public class ConstantForce2D : PhysicsUpdateBehaviour2D
    {
        public object force;
        public object relativeForce;
        public object torque;

        // ── Methods ──
        public void get_force(){} // RVA: 0x7FFAC9986EA0
        public void set_force(){} // RVA: 0x7FFAC9986F00
        public void get_relativeForce(){} // RVA: 0x7FFAC9986F60
        public void set_relativeForce(){} // RVA: 0x7FFAC9986FC0
        public void get_torque(){} // RVA: 0x7FFAC9987020
        public void set_torque(){} // RVA: 0x7FFAC9987070
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_force_Injected(){} // RVA: 0x7FFAC99870D0
        public void set_force_Injected(){} // RVA: 0x7FFAC9987130
        public void get_relativeForce_Injected(){} // RVA: 0x7FFAC9987190
        public void set_relativeForce_Injected(){} // RVA: 0x7FFAC99871F0
    }

    public class ContactFilter2D : ValueType
    {
        public bool isFiltering; // 0x10
        public bool useLayerMask; // 0x11
        public bool useDepth; // 0x12
        public bool useOutsideDepth; // 0x13
        public bool useNormalAngle; // 0x14
        public bool useOutsideNormalAngle; // 0x15
        public UnityEngine.LayerMask layerMask; // 0x18
        public float minDepth; // 0x1C
        public float maxDepth; // 0x20
        public float minNormalAngle; // 0x24
        public float maxNormalAngle; // 0x28

        // ── Methods ──
        public void NoFilter(){} // RVA: 0x7FFAC9977930
        public void CheckConsistency(){} // RVA: 0x7FFAC9977980
        public void ClearLayerMask(){} // RVA: 0x7FFAC99779D0
        public void SetLayerMask(){} // RVA: 0x7FFAC99779E0
        public void ClearDepth(){} // RVA: 0x7FFAC99779F0
        public void SetDepth(){} // RVA: 0x7FFAC9977A00
        public void ClearNormalAngle(){} // RVA: 0x7FFAC9977A60
        public void SetNormalAngle(){} // RVA: 0x7FFAC9977A70
        public void get_isFiltering(){} // RVA: 0x7FFAC9977AD0
        public void IsFilteringTrigger(){} // RVA: 0x7FFAC9977B00
        public void IsFilteringLayerMask(){} // RVA: 0x7FFAC9977B80
        public void IsFilteringDepth(){} // RVA: 0x7FFAC9977C10
        public void IsFilteringNormalAngle(){} // RVA: 0x7FFAC9977D90 | overloaded x2
        public void IsFilteringNormalAngleUsingAngle(){} // RVA: 0x7FFAC9977D90
        public void CreateLegacyFilter(){} // RVA: 0x7FFAC9977DF0
        public void CheckConsistency_Injected(){} // RVA: 0x7FFAC9977980
        public void IsFilteringNormalAngle_Injected(){} // RVA: 0x7FFAC9977F30
        public void IsFilteringNormalAngleUsingAngle_Injected(){} // RVA: 0x7FFAC9977D90
    }

    public class ContactPair : ValueType
    {
        public int ColliderInstanceID; // 0x10
        public int OtherColliderInstanceID; // 0x14
        public UIntPtr Collider; // 0x18
        public uint OtherCollider; // 0x20
        public 0x6B2A0CC0 ImpulseSum; // 0x24
        public 0x6B2A0D18 IsCollisionEnter; // 0x26
        public UnityEngine.Vector3 IsCollisionExit; // 0x28

        // ── Methods ──
        public void get_ColliderInstanceID(){} // RVA: 0x7FFAC4420210
        public void get_OtherColliderInstanceID(){} // RVA: 0x7FFAC44202A0
        public void get_Collider(){} // RVA: 0x7FFAC99A2EB0
        public void get_OtherCollider(){} // RVA: 0x7FFAC99A2F50
        public void get_ImpulseSum(){} // RVA: 0x7FFAC6D348B0
        public void get_IsCollisionEnter(){} // RVA: 0x7FFAC99A2FF0
        public void get_IsCollisionExit(){} // RVA: 0x7FFAC99A3000
        public void get_IsCollisionStay(){} // RVA: 0x7FFAC99A3010
        public void get_HasRemovedCollider(){} // RVA: 0x7FFAC99A2E00
        public void ExtractContacts(){} // RVA: 0x7FFAC99A3020
        public void ExtractContactsArray(){} // RVA: 0x7FFAC99A3090
        public void GetContactPoint_Internal(){} // RVA: 0x7FFAC99A3100
        public void ExtractContacts_Injected(){} // RVA: 0x7FFAC99A3020
        public void ExtractContactsArray_Injected(){} // RVA: 0x7FFAC99A3090
    }

    public class ContactPairHeader : ValueType
    {
        public int Body; // 0x10
        public int OtherBody; // 0x14
        public UIntPtr HasRemovedBody; // 0x18
        public uint m_NbPairs; // 0x20
        public 0x6B2A0C68 m_Flags; // 0x24
        public UnityEngine.Vector3 m_RelativeVelocity; // 0x28

        // ── Methods ──
        public void get_Body(){} // RVA: 0x7FFAC99A2CE0
        public void get_OtherBody(){} // RVA: 0x7FFAC99A2D70
        public void get_HasRemovedBody(){} // RVA: 0x7FFAC99A2E00
        public void GetContactPair(){} // RVA: 0x7FFAC99A2E20
        public void GetContactPair_Internal(){} // RVA: 0x7FFAC99A2E30
    }

    public class ContactPairPoint : ValueType
    {
        public UnityEngine.Vector3 m_Position; // 0x10
        public float m_Separation; // 0x1C
        public UnityEngine.Vector3 m_Normal; // 0x20
        public uint m_InternalFaceIndex0; // 0x2C
        public UnityEngine.Vector3 m_Impulse; // 0x30
        public uint m_InternalFaceIndex1; // 0x3C
    }

    public class ContactPoint : ValueType
    {
        public UnityEngine.Vector3 point; // 0x10
        public UnityEngine.Vector3 normal; // 0x1C
        public UnityEngine.Vector3 impulse; // 0x28
        public int thisCollider; // 0x34
        public int otherCollider; // 0x38
        public float separation; // 0x3C

        // ── Methods ──
        public void get_point(){} // RVA: 0x7FFAC9811DA0
        public void get_normal(){} // RVA: 0x7FFAC9811DC0
        public void get_impulse(){} // RVA: 0x7FFAC9830D10
        public void get_thisCollider(){} // RVA: 0x7FFAC999FA80
        public void get_otherCollider(){} // RVA: 0x7FFAC999FB10
        public void get_separation(){} // RVA: 0x7FFAC993FB10
        public void .ctor(){} // RVA: 0x7FFAC999FBA0
    }

    public class ContactPoint2D : ValueType
    {
        public UnityEngine.Vector2 point; // 0x10
        public UnityEngine.Vector2 normal; // 0x18
        public UnityEngine.Vector2 separation; // 0x20
        public float normalImpulse; // 0x28
        public float tangentImpulse; // 0x2C
        public float relativeVelocity; // 0x30
        public int collider; // 0x34
        public int otherCollider; // 0x38
        public int rigidbody; // 0x3C
        public int otherRigidbody; // 0x40
        public int enabled; // 0x44

        // ── Methods ──
        public void get_point(){} // RVA: 0x7FFAC51D9A30
        public void get_normal(){} // RVA: 0x7FFAC9866820
        public void get_separation(){} // RVA: 0x7FFAC9811DF0
        public void get_normalImpulse(){} // RVA: 0x7FFAC9814E00
        public void get_tangentImpulse(){} // RVA: 0x7FFAC9812640
        public void get_relativeVelocity(){} // RVA: 0x7FFAC9977900
        public void get_collider(){} // RVA: 0x7FFAC9978C30
        public void get_otherCollider(){} // RVA: 0x7FFAC9978D20
        public void get_rigidbody(){} // RVA: 0x7FFAC9978E10
        public void get_otherRigidbody(){} // RVA: 0x7FFAC9978ED0
        public void get_enabled(){} // RVA: 0x7FFAC9978F90
    }

    public class ContextMenu : Attribute
    {
        public string menuItem; // 0x10
        public bool validate; // 0x18
        public int priority; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98BA7E0 | overloaded x3
    }

    public class ContextMenuItemAttribute : PropertyAttribute
    {
        public string name; // 0x10
        public string function; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
    }

    public class ControllerColliderHit : Object
    {
        public UnityEngine.CharacterController controller; // 0x10
        public UnityEngine.Collider collider; // 0x18
        public UnityEngine.Vector3 rigidbody; // 0x20
        public UnityEngine.Vector3 gameObject; // 0x2C
        public UnityEngine.Vector3 transform; // 0x38
        public float point; // 0x44
        public int normal; // 0x48

        // ── Methods ──
        public void get_controller(){} // RVA: 0x7FFAC5CC4750
        public void get_collider(){} // RVA: 0x7FFAC58A1130
        public void get_rigidbody(){} // RVA: 0x7FFAC99874C0
        public void get_gameObject(){} // RVA: 0x7FFAC9987520
        public void get_transform(){} // RVA: 0x7FFAC9987580
        public void get_point(){} // RVA: 0x7FFAC99875E0
        public void get_normal(){} // RVA: 0x7FFAC9987600
        public void get_moveDirection(){} // RVA: 0x7FFAC9987620
        public void get_moveLength(){} // RVA: 0x7FFAC9987640
    }

    public class Coroutine : YieldInstruction
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Finalize(){} // RVA: 0x7FFAC98BCA20
        public void ReleaseCoroutine(){} // RVA: 0x7FFAC98BCAA0
    }

    public class CreateAssetMenuAttribute : Attribute
    {
        public string menuName; // 0x10
        public string fileName; // 0x18
        public int order; // 0x20

        // ── Methods ──
        public void set_menuName(){} // RVA: 0x7FFAC2F22E30
        public void set_fileName(){} // RVA: 0x7FFAC2F87E80
        public void set_order(){} // RVA: 0x7FFAC35DB7A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Cubemap : Texture
    {
        public object format;
        public object isReadable;
        public object streamingMipmaps;
        public object streamingMipmapsPriority;
        public object requestedMipmapLevel;
        public object desiredMipmapLevel;
        public object loadingMipmapLevel;
        public object loadedMipmapLevel;

        // ── Methods ──
        public void get_format(){} // RVA: 0x7FFAC989C220
        public void Internal_CreateImpl(){} // RVA: 0x7FFAC989C270
        public void Internal_Create(){} // RVA: 0x7FFAC989C2F0
        public void ApplyImpl(){} // RVA: 0x7FFAC989C3E0
        public void get_isReadable(){} // RVA: 0x7FFAC989C460
        public void SetPixelImpl(){} // RVA: 0x7FFAC989C4B0
        public void GetPixelImpl(){} // RVA: 0x7FFAC989C550
        public void SmoothEdges(){} // RVA: 0x7FFAC989C650 | overloaded x2
        public void GetPixels(){} // RVA: 0x7FFAC989C720 | overloaded x2
        public void SetPixels(){} // RVA: 0x7FFAC989C890 | overloaded x2
        public void SetPixelDataImplArray(){} // RVA: 0x7FFAC989C800
        public void get_streamingMipmaps(){} // RVA: 0x7FFAC989C8B0
        public void get_streamingMipmapsPriority(){} // RVA: 0x7FFAC989C900
        public void get_requestedMipmapLevel(){} // RVA: 0x7FFAC989C950
        public void set_requestedMipmapLevel(){} // RVA: 0x7FFAC989C9A0
        public void get_desiredMipmapLevel(){} // RVA: 0x7FFAC989CA00
        public void get_loadingMipmapLevel(){} // RVA: 0x7FFAC989CA50
        public void get_loadedMipmapLevel(){} // RVA: 0x7FFAC989CAA0
        public void ClearRequestedMipmapLevel(){} // RVA: 0x7FFAC989CAF0
        public void ValidateFormat(){} // RVA: 0x7FFAC989CC60 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC989D6A0 | overloaded x9
        public void CreateExternalTexture(){} // RVA: 0x7FFAC989D6D0
        public void SetPixelData(){}
        public void SetPixel(){} // RVA: 0x7FFAC989D840 | overloaded x2
        public void GetPixel(){} // RVA: 0x7FFAC989D960 | overloaded x2
        public void Apply(){} // RVA: 0x7FFAC989DB30 | overloaded x3
        public void ValidateIsNotCrunched(){} // RVA: 0x7FFAC989DB40
        public void SetPixelImpl_Injected(){} // RVA: 0x7FFAC989DBA0
        public void GetPixelImpl_Injected(){} // RVA: 0x7FFAC989DC20
    }

    public class CubemapArray : Texture
    {
        public object isReadable;

        // ── Methods ──
        public void get_isReadable(){} // RVA: 0x7FFAC98A0600
        public void Internal_CreateImpl(){} // RVA: 0x7FFAC98A0650
        public void Internal_Create(){} // RVA: 0x7FFAC98A06D0
        public void .ctor(){} // RVA: 0x7FFAC98A0EB0 | overloaded x9
        public void ValidateIsNotCrunched(){} // RVA: 0x7FFAC98A0F70
    }

    public class CullingGroup : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public StateChanged m_OnStateChanged; // 0x18

        // ── Methods ──
        public void SendEvents(){} // RVA: 0x7FFAC985CBA0
    }

    public class CullingGroupEvent : ValueType
    {
        public int m_Index; // 0x10
        public byte m_PrevState; // 0x14
        public byte m_ThisState; // 0x15
    }

    public class Cursor : Object
    {
        public object visible;
        public object lockState;

        // ── Methods ──
        public void SetCursor(){} // RVA: 0x7FFAC98A72B0
        public void get_visible(){} // RVA: 0x7FFAC98A7320
        public void set_visible(){} // RVA: 0x7FFAC98A7370
        public void get_lockState(){} // RVA: 0x7FFAC98A73C0
        public void set_lockState(){} // RVA: 0x7FFAC98A7410
        public void SetCursor_Injected(){} // RVA: 0x7FFAC98A7460
    }

    public class CustomRenderTexture : RenderTexture
    {
        public object material;
        public object initializationMaterial;
        public object initializationTexture;
        public object initializationSource;
        public object initializationColor;
        public object updateMode;
        public object initializationMode;
        public object updateZoneSpace;
        public object shaderPass;
        public object cubemapFaceMask;
        public object doubleBuffered;
        public object wrapUpdateZones;
        public object updatePeriod;

        // ── Methods ──
        public void Internal_CreateCustomRenderTexture(){} // RVA: 0x7FFAC98A4FE0
        public void TriggerUpdate(){} // RVA: 0x7FFAC98A5030
        public void Update(){} // RVA: 0x7FFAC98A5140 | overloaded x2
        public void TriggerInitialization(){} // RVA: 0x7FFAC98A5150
        public void Initialize(){} // RVA: 0x7FFAC98A51A0
        public void ClearUpdateZones(){} // RVA: 0x7FFAC98A5240
        public void get_material(){} // RVA: 0x7FFAC98A5290
        public void set_material(){} // RVA: 0x7FFAC98A52E0
        public void get_initializationMaterial(){} // RVA: 0x7FFAC98A5340
        public void set_initializationMaterial(){} // RVA: 0x7FFAC98A5390
        public void get_initializationTexture(){} // RVA: 0x7FFAC98A53F0
        public void set_initializationTexture(){} // RVA: 0x7FFAC98A5440
        public void GetUpdateZonesInternal(){} // RVA: 0x7FFAC98A54A0
        public void GetUpdateZones(){} // RVA: 0x7FFAC98A54A0
        public void SetUpdateZonesInternal(){} // RVA: 0x7FFAC98A5500
        public void GetDoubleBufferRenderTexture(){} // RVA: 0x7FFAC98A5560
        public void EnsureDoubleBufferConsistency(){} // RVA: 0x7FFAC98A55B0
        public void SetUpdateZones(){} // RVA: 0x7FFAC98A5600
        public void get_initializationSource(){} // RVA: 0x7FFAC98A56B0
        public void set_initializationSource(){} // RVA: 0x7FFAC98A5700
        public void get_initializationColor(){} // RVA: 0x7FFAC98A5760
        public void set_initializationColor(){} // RVA: 0x7FFAC98A57D0
        public void get_updateMode(){} // RVA: 0x7FFAC98A5830
        public void set_updateMode(){} // RVA: 0x7FFAC98A5880
        public void get_initializationMode(){} // RVA: 0x7FFAC98A58E0
        public void set_initializationMode(){} // RVA: 0x7FFAC98A5930
        public void get_updateZoneSpace(){} // RVA: 0x7FFAC98A5990
        public void set_updateZoneSpace(){} // RVA: 0x7FFAC98A59E0
        public void get_shaderPass(){} // RVA: 0x7FFAC98A5A40
        public void set_shaderPass(){} // RVA: 0x7FFAC98A5A90
        public void get_cubemapFaceMask(){} // RVA: 0x7FFAC98A5AF0
        public void set_cubemapFaceMask(){} // RVA: 0x7FFAC98A5B40
        public void get_doubleBuffered(){} // RVA: 0x7FFAC98A5BA0
        public void set_doubleBuffered(){} // RVA: 0x7FFAC98A5BF0
        public void get_wrapUpdateZones(){} // RVA: 0x7FFAC98A5C50
        public void set_wrapUpdateZones(){} // RVA: 0x7FFAC98A5CA0
        public void get_updatePeriod(){} // RVA: 0x7FFAC98A5D00
        public void set_updatePeriod(){} // RVA: 0x7FFAC98A5D50
        public void .ctor(){} // RVA: 0x7FFAC98A5FC0 | overloaded x5
        public void get_initializationColor_Injected(){} // RVA: 0x7FFAC98A6200
        public void set_initializationColor_Injected(){} // RVA: 0x7FFAC98A6260
    }

    public class CustomRenderTextureManager : Object
    {
        public System.Action`1<UnityEngine.CustomRenderTexture> textureLoaded;
        public System.Action`1<UnityEngine.CustomRenderTexture> textureUnloaded; // 0x8
        public System.Action`2<UnityEngine.CustomRenderTexture,int> updateTriggered; // 0x10
        public System.Action`1<UnityEngine.CustomRenderTexture> initializeTriggered; // 0x18

        // ── Methods ──
        public void InvokeOnTextureLoaded_Internal(){} // RVA: 0x7FFAC986B220
        public void InvokeOnTextureUnloaded_Internal(){} // RVA: 0x7FFAC986B280
        public void InvokeTriggerUpdate(){} // RVA: 0x7FFAC986B2E0
        public void InvokeTriggerInitialize(){} // RVA: 0x7FFAC986B350
    }

    public class CustomRenderTextureUpdateZone : ValueType
    {
        public UnityEngine.Vector3 updateZoneCenter; // 0x10
        public UnityEngine.Vector3 updateZoneSize; // 0x1C
        public float rotation; // 0x28
        public int passIndex; // 0x2C
        public bool needSwap; // 0x30
    }

    public class CustomYieldInstruction : Object
    {
        public object keepWaiting;
        public object Current;

        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x7FFAC2C59D00
        public void get_Current(){} // RVA: 0x7FFAC67332B0
        public void MoveNext(){} // RVA: 0x7FFAC47CB300
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}