// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 45
// Methods: 1212

namespace ThirdParty.Unity.UnityEngine
{
    public class Cache : ValueType
    {
        public int handle; // 0x10

        // ── Methods ──
        public void get_handle(){} // RVA: 0x7FFD543B3F90
        public void GetHashCode(){} // RVA: 0x7FFD543B3F90
        public void Equals(){} // RVA: 0x7FFD54C75270 | overloaded x2
        public void get_valid(){} // RVA: 0x7FFD54C75280
        public void Cache_IsValid(){} // RVA: 0x7FFD54C752D0
        public void get_path(){} // RVA: 0x7FFD54C75320
        public void Cache_GetPath(){} // RVA: 0x7FFD54C75370
        public void set_maximumAvailableStorageSpace(){} // RVA: 0x7FFD54C753C0
        public void Cache_SetMaximumDiskSpaceAvailable(){} // RVA: 0x7FFD54C75420
        public void get_spaceOccupied(){} // RVA: 0x7FFD54C75480
        public void Cache_GetCachingDiskSpaceUsed(){} // RVA: 0x7FFD54C754D0
    }

    public class CachedAssetBundle : ValueType
    {
        public string name; // 0x10
        public rQueue hash; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD51515420
        public void get_name(){} // RVA: 0x7FFD505F9A30
        public void get_hash(){} // RVA: 0x7FFD54C751E0
    }

    public class Camera : Behaviour
    {
        public float nearClipPlane;
        public float farClipPlane;
        public int fieldOfView;
        public int renderingPath;
        public object actualRenderingPath;
        public object allowHDR; // 0x8
        public object allowMSAA; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_nearClipPlane(){} // RVA: 0x7FFD54C76110
        public void set_nearClipPlane(){} // RVA: 0x7FFD54C76160
        public void get_farClipPlane(){} // RVA: 0x7FFD54C761C0
        public void set_farClipPlane(){} // RVA: 0x7FFD54C76210
        public void get_fieldOfView(){} // RVA: 0x7FFD54C76270
        public void set_fieldOfView(){} // RVA: 0x7FFD54C762C0
        public void get_renderingPath(){} // RVA: 0x7FFD54C76320
        public void set_renderingPath(){} // RVA: 0x7FFD54C76370
        public void get_actualRenderingPath(){} // RVA: 0x7FFD54C763D0
        public void Reset(){} // RVA: 0x7FFD54C76420
        public void get_allowHDR(){} // RVA: 0x7FFD54C76470
        public void set_allowHDR(){} // RVA: 0x7FFD54C764C0
        public void get_allowMSAA(){} // RVA: 0x7FFD54C76520
        public void set_allowMSAA(){} // RVA: 0x7FFD54C76570
        public void get_allowDynamicResolution(){} // RVA: 0x7FFD54C765D0
        public void set_allowDynamicResolution(){} // RVA: 0x7FFD54C76620
        public void get_forceIntoRenderTexture(){} // RVA: 0x7FFD54C76680
        public void set_forceIntoRenderTexture(){} // RVA: 0x7FFD54C766D0
        public void get_orthographicSize(){} // RVA: 0x7FFD54C76730
        public void set_orthographicSize(){} // RVA: 0x7FFD54C76780
        public void get_orthographic(){} // RVA: 0x7FFD54C767E0
        public void set_orthographic(){} // RVA: 0x7FFD54C76830
        public void get_opaqueSortMode(){} // RVA: 0x7FFD54C76890
        public void set_opaqueSortMode(){} // RVA: 0x7FFD54C768E0
        public void get_transparencySortMode(){} // RVA: 0x7FFD54C76940
        public void set_transparencySortMode(){} // RVA: 0x7FFD54C76990
        public void get_transparencySortAxis(){} // RVA: 0x7FFD54C769F0
        public void set_transparencySortAxis(){} // RVA: 0x7FFD54C76A60
        public void ResetTransparencySortSettings(){} // RVA: 0x7FFD54C76AC0
        public void get_depth(){} // RVA: 0x7FFD54C76B10
        public void set_depth(){} // RVA: 0x7FFD54C76B60
        public void get_aspect(){} // RVA: 0x7FFD54C76BC0
        public void set_aspect(){} // RVA: 0x7FFD54C76C10
        public void ResetAspect(){} // RVA: 0x7FFD54C76C70
        public void get_velocity(){} // RVA: 0x7FFD54C76CC0
        public void get_cullingMask(){} // RVA: 0x7FFD54C76D30
        public void set_cullingMask(){} // RVA: 0x7FFD54C76D80
        public void get_eventMask(){} // RVA: 0x7FFD54C76DE0
        public void set_eventMask(){} // RVA: 0x7FFD54C76E30
        public void get_layerCullSpherical(){} // RVA: 0x7FFD54C76E90
        public void set_layerCullSpherical(){} // RVA: 0x7FFD54C76EE0
        public void get_cameraType(){} // RVA: 0x7FFD54C76F40
        public void set_cameraType(){} // RVA: 0x7FFD54C76F90
        public void get_skyboxMaterial(){} // RVA: 0x7FFD54C76FF0
        public void get_overrideSceneCullingMask(){} // RVA: 0x7FFD54C77040
        public void set_overrideSceneCullingMask(){} // RVA: 0x7FFD54C77090
        public void get_sceneCullingMask(){} // RVA: 0x7FFD54C770F0
        public void GetLayerCullDistances(){} // RVA: 0x7FFD54C77140
        public void SetLayerCullDistances(){} // RVA: 0x7FFD54C77190
        public void get_layerCullDistances(){} // RVA: 0x7FFD54C77140
        public void set_layerCullDistances(){} // RVA: 0x7FFD54C771F0
        public void get_PreviewCullingLayer(){} // RVA: 0x7FFD54C772B0
        public void get_useOcclusionCulling(){} // RVA: 0x7FFD54C772C0
        public void set_useOcclusionCulling(){} // RVA: 0x7FFD54C77310
        public void get_cullingMatrix(){} // RVA: 0x7FFD54C77370
        public void set_cullingMatrix(){} // RVA: 0x7FFD54C773F0
        public void ResetCullingMatrix(){} // RVA: 0x7FFD54C77450
        public void get_backgroundColor(){} // RVA: 0x7FFD54C774A0
        public void set_backgroundColor(){} // RVA: 0x7FFD54C77510
        public void get_clearFlags(){} // RVA: 0x7FFD54C77570
        public void set_clearFlags(){} // RVA: 0x7FFD54C775C0
        public void get_depthTextureMode(){} // RVA: 0x7FFD54C77620
        public void set_depthTextureMode(){} // RVA: 0x7FFD54C77670
        public void get_clearStencilAfterLightingPass(){} // RVA: 0x7FFD54C776D0
        public void set_clearStencilAfterLightingPass(){} // RVA: 0x7FFD54C77720
        public void SetReplacementShader(){} // RVA: 0x7FFD54C77780
        public void ResetReplacementShader(){} // RVA: 0x7FFD54C777F0
        public void get_projectionMatrixMode(){} // RVA: 0x7FFD54C77840
        public void get_usePhysicalProperties(){} // RVA: 0x7FFD54C77890
        public void set_usePhysicalProperties(){} // RVA: 0x7FFD54C778E0
        public void get_iso(){} // RVA: 0x7FFD54C77940
        public void set_iso(){} // RVA: 0x7FFD54C77990
        public void get_shutterSpeed(){} // RVA: 0x7FFD54C779F0
        public void set_shutterSpeed(){} // RVA: 0x7FFD54C77A40
        public void get_aperture(){} // RVA: 0x7FFD54C77AA0
        public void set_aperture(){} // RVA: 0x7FFD54C77AF0
        public void get_focusDistance(){} // RVA: 0x7FFD54C77B50
        public void set_focusDistance(){} // RVA: 0x7FFD54C77BA0
        public void get_focalLength(){} // RVA: 0x7FFD54C77C00
        public void set_focalLength(){} // RVA: 0x7FFD54C77C50
        public void get_bladeCount(){} // RVA: 0x7FFD54C77CB0
        public void set_bladeCount(){} // RVA: 0x7FFD54C77D00
        public void get_curvature(){} // RVA: 0x7FFD54C77D60
        public void set_curvature(){} // RVA: 0x7FFD54C77DC0
        public void get_barrelClipping(){} // RVA: 0x7FFD54C77E20
        public void set_barrelClipping(){} // RVA: 0x7FFD54C77E70
        public void get_anamorphism(){} // RVA: 0x7FFD54C77ED0
        public void set_anamorphism(){} // RVA: 0x7FFD54C77F20
        public void get_sensorSize(){} // RVA: 0x7FFD54C77F80
        public void set_sensorSize(){} // RVA: 0x7FFD54C77FE0
        public void get_lensShift(){} // RVA: 0x7FFD54C78040
        public void set_lensShift(){} // RVA: 0x7FFD54C780A0
        public void get_gateFit(){} // RVA: 0x7FFD54C78100
        public void set_gateFit(){} // RVA: 0x7FFD54C78150
        public void GetGateFittedFieldOfView(){} // RVA: 0x7FFD54C781B0
        public void GetGateFittedLensShift(){} // RVA: 0x7FFD54C78200
        public void GetLocalSpaceAim(){} // RVA: 0x7FFD54C78260
        public void get_rect(){} // RVA: 0x7FFD54C782D0
        public void set_rect(){} // RVA: 0x7FFD54C78340
        public void get_pixelRect(){} // RVA: 0x7FFD54C783A0
        public void set_pixelRect(){} // RVA: 0x7FFD54C78410
        public void get_pixelWidth(){} // RVA: 0x7FFD54C78470
        public void get_pixelHeight(){} // RVA: 0x7FFD54C784C0
        public void get_scaledPixelWidth(){} // RVA: 0x7FFD54C78510
        public void get_scaledPixelHeight(){} // RVA: 0x7FFD54C78560
        public void get_targetTexture(){} // RVA: 0x7FFD54C785B0
        public void set_targetTexture(){} // RVA: 0x7FFD54C78600
        public void get_activeTexture(){} // RVA: 0x7FFD54C78660
        public void get_targetDisplay(){} // RVA: 0x7FFD54C786B0
        public void set_targetDisplay(){} // RVA: 0x7FFD54C78700
        public void SetTargetBuffersImpl(){} // RVA: 0x7FFD54C78760
        public void SetTargetBuffers(){} // RVA: 0x7FFD54C788B0 | overloaded x2
        public void SetTargetBuffersMRTImpl(){} // RVA: 0x7FFD54C78840
        public void GetCameraBufferWarnings(){} // RVA: 0x7FFD54C78920
        public void get_cameraToWorldMatrix(){} // RVA: 0x7FFD54C78970
        public void get_worldToCameraMatrix(){} // RVA: 0x7FFD54C789F0
        public void set_worldToCameraMatrix(){} // RVA: 0x7FFD54C78A70
        public void get_projectionMatrix(){} // RVA: 0x7FFD54C78AD0
        public void set_projectionMatrix(){} // RVA: 0x7FFD54C78B50
        public void get_nonJitteredProjectionMatrix(){} // RVA: 0x7FFD54C78BB0
        public void set_nonJitteredProjectionMatrix(){} // RVA: 0x7FFD54C78C30
        public void get_useJitteredProjectionMatrixForTransparentRendering(){} // RVA: 0x7FFD54C78C90
        public void set_useJitteredProjectionMatrixForTransparentRendering(){} // RVA: 0x7FFD54C78CE0
        public void get_previousViewProjectionMatrix(){} // RVA: 0x7FFD54C78D40
        public void ResetWorldToCameraMatrix(){} // RVA: 0x7FFD54C78DC0
        public void ResetProjectionMatrix(){} // RVA: 0x7FFD54C78E10
        public void CalculateObliqueMatrix(){} // RVA: 0x7FFD54C78E60
        public void WorldToScreenPoint(){} // RVA: 0x7FFD54C79130 | overloaded x2
        public void WorldToViewportPoint(){} // RVA: 0x7FFD54C791E0 | overloaded x2
        public void ViewportToWorldPoint(){} // RVA: 0x7FFD54C79290 | overloaded x2
        public void ScreenToWorldPoint(){} // RVA: 0x7FFD54C79340 | overloaded x2
        public void ScreenToViewportPoint(){} // RVA: 0x7FFD54C793F0
        public void ViewportToScreenPoint(){} // RVA: 0x7FFD54C79470
        public void GetFrustumPlaneSizeAt(){} // RVA: 0x7FFD54C794F0
        public void ViewportPointToRay(){} // RVA: 0x7FFD54C796C0 | overloaded x3
        public void ScreenPointToRay(){} // RVA: 0x7FFD54C798E0 | overloaded x3
        public void CalculateFrustumCornersInternal(){} // RVA: 0x7FFD54C799A0
        public void CalculateFrustumCorners(){} // RVA: 0x7FFD54C79A30
        public void CalculateProjectionMatrixFromPhysicalPropertiesInternal(){} // RVA: 0x7FFD54C79B80
        public void CalculateProjectionMatrixFromPhysicalProperties(){} // RVA: 0x7FFD54C79C30
        public void FocalLengthToFieldOfView(){} // RVA: 0x7FFD54C79CE0
        public void FieldOfViewToFocalLength(){} // RVA: 0x7FFD54C79D50
        public void HorizontalToVerticalFieldOfView(){} // RVA: 0x7FFD54C79DC0
        public void VerticalToHorizontalFieldOfView(){} // RVA: 0x7FFD54C79E30
        public void get_main(){} // RVA: 0x7FFD4EB90BA0
        public void get_current(){} // RVA: 0x7FFD54C79EA0
        public void get_scene(){} // RVA: 0x7FFD54C79EF0
        public void set_scene(){} // RVA: 0x7FFD54C79F50
        public void get_stereoEnabled(){} // RVA: 0x7FFD54C79FB0
        public void get_stereoSeparation(){} // RVA: 0x7FFD54C7A000
        public void set_stereoSeparation(){} // RVA: 0x7FFD54C7A050
        public void get_stereoConvergence(){} // RVA: 0x7FFD54C7A0B0
        public void set_stereoConvergence(){} // RVA: 0x7FFD54C7A100
        public void get_areVRStereoViewMatricesWithinSingleCullTolerance(){} // RVA: 0x7FFD54C7A160
        public void get_stereoTargetEye(){} // RVA: 0x7FFD54C7A1B0
        public void set_stereoTargetEye(){} // RVA: 0x7FFD54C7A200
        public void get_stereoActiveEye(){} // RVA: 0x7FFD54C7A260
        public void GetStereoNonJitteredProjectionMatrix(){} // RVA: 0x7FFD54C7A2B0
        public void GetStereoViewMatrix(){} // RVA: 0x7FFD54C7A340
        public void CopyStereoDeviceProjectionMatrixToNonJittered(){} // RVA: 0x7FFD54C7A3D0
        public void GetStereoProjectionMatrix(){} // RVA: 0x7FFD54C7A430
        public void SetStereoProjectionMatrix(){} // RVA: 0x7FFD54C7A4C0
        public void ResetStereoProjectionMatrices(){} // RVA: 0x7FFD54C7A530
        public void SetStereoViewMatrix(){} // RVA: 0x7FFD54C7A580
        public void ResetStereoViewMatrices(){} // RVA: 0x7FFD54C7A5F0
        public void GetAllCamerasCount(){} // RVA: 0x7FFD54C7A640
        public void GetAllCamerasImpl(){} // RVA: 0x7FFD54C7A690
        public void get_allCamerasCount(){} // RVA: 0x7FFD54C7A640
        public void get_allCameras(){} // RVA: 0x7FFD54C7A6E0
        public void GetAllCameras(){} // RVA: 0x7FFD54C7A7B0
        public void RenderToCubemapImpl(){} // RVA: 0x7FFD54C7A8D0
        public void RenderToCubemap(){} // RVA: 0x7FFD54C7AA10 | overloaded x5
        public void GetFilterMode(){} // RVA: 0x7FFD54C7A9C0
        public void get_sceneViewFilterMode(){} // RVA: 0x7FFD54C7A9C0
        public void RenderToCubemapEyeImpl(){} // RVA: 0x7FFD54C7AA10
        public void Render(){} // RVA: 0x7FFD54C7AA90
        public void RenderWithShader(){} // RVA: 0x7FFD54C7AAE0
        public void RenderDontRestore(){} // RVA: 0x7FFD54C7AB50
        public void SubmitRenderRequests(){} // RVA: 0x7FFD54C7ABA0
        public void SubmitRenderRequest(){} // RVA: 0x7FFD4E2ADC40
        public void SubmitRenderRequestsInternal(){} // RVA: 0x7FFD54C7AD50
        public void SubmitBuiltInObjectIDRenderRequest(){} // RVA: 0x7FFD54C7ADB0
        public void SetupCurrent(){} // RVA: 0x7FFD54C7AE40
        public void CopyFrom(){} // RVA: 0x7FFD54C7AE90
        public void get_commandBufferCount(){} // RVA: 0x7FFD54C7AEF0
        public void RemoveCommandBuffers(){} // RVA: 0x7FFD54C7AF40
        public void RemoveAllCommandBuffers(){} // RVA: 0x7FFD54C7AFA0
        public void AddCommandBufferImpl(){} // RVA: 0x7FFD54C7AFF0
        public void AddCommandBufferAsyncImpl(){} // RVA: 0x7FFD54C7B060
        public void RemoveCommandBufferImpl(){} // RVA: 0x7FFD54C7B0E0
        public void AddCommandBuffer(){} // RVA: 0x7FFD54C7B150
        public void AddCommandBufferAsync(){} // RVA: 0x7FFD54C7B2B0
        public void RemoveCommandBuffer(){} // RVA: 0x7FFD54C7B420
        public void GetCommandBuffers(){} // RVA: 0x7FFD54C7B580
        public void FireOnPreCull(){} // RVA: 0x7FFD54C7B5E0
        public void FireOnPreRender(){} // RVA: 0x7FFD54C7B640
        public void FireOnPostRender(){} // RVA: 0x7FFD54C7B6A0
        public void OnlyUsedForTesting1(){} // RVA: 0x7FFD4E341310
        public void OnlyUsedForTesting2(){} // RVA: 0x7FFD4E341310
        public void TryGetCullingParameters(){} // RVA: 0x7FFD54C7B730 | overloaded x2
        public void GetCullingParameters_Internal(){} // RVA: 0x7FFD54C7B750
        public void get_transparencySortAxis_Injected(){} // RVA: 0x7FFD54C7B7D0
        public void set_transparencySortAxis_Injected(){} // RVA: 0x7FFD54C7B830
        public void get_velocity_Injected(){} // RVA: 0x7FFD54C7B890
        public void get_cullingMatrix_Injected(){} // RVA: 0x7FFD54C7B8F0
        public void set_cullingMatrix_Injected(){} // RVA: 0x7FFD54C7B950
        public void get_backgroundColor_Injected(){} // RVA: 0x7FFD54C7B9B0
        public void set_backgroundColor_Injected(){} // RVA: 0x7FFD54C7BA10
        public void get_curvature_Injected(){} // RVA: 0x7FFD54C7BA70
        public void set_curvature_Injected(){} // RVA: 0x7FFD54C7BAD0
        public void get_sensorSize_Injected(){} // RVA: 0x7FFD54C7BB30
        public void set_sensorSize_Injected(){} // RVA: 0x7FFD54C7BB90
        public void get_lensShift_Injected(){} // RVA: 0x7FFD54C7BBF0
        public void set_lensShift_Injected(){} // RVA: 0x7FFD54C7BC50
        public void GetGateFittedLensShift_Injected(){} // RVA: 0x7FFD54C7BCB0
        public void GetLocalSpaceAim_Injected(){} // RVA: 0x7FFD54C7BD10
        public void get_rect_Injected(){} // RVA: 0x7FFD54C7BD70
        public void set_rect_Injected(){} // RVA: 0x7FFD54C7BDD0
        public void get_pixelRect_Injected(){} // RVA: 0x7FFD54C7BE30
        public void set_pixelRect_Injected(){} // RVA: 0x7FFD54C7BE90
        public void SetTargetBuffersImpl_Injected(){} // RVA: 0x7FFD54C7BEF0
        public void SetTargetBuffersMRTImpl_Injected(){} // RVA: 0x7FFD54C7BF60
        public void get_cameraToWorldMatrix_Injected(){} // RVA: 0x7FFD54C7BFD0
        public void get_worldToCameraMatrix_Injected(){} // RVA: 0x7FFD54C7C030
        public void set_worldToCameraMatrix_Injected(){} // RVA: 0x7FFD54C7C090
        public void get_projectionMatrix_Injected(){} // RVA: 0x7FFD54C7C0F0
        public void set_projectionMatrix_Injected(){} // RVA: 0x7FFD54C7C150
        public void get_nonJitteredProjectionMatrix_Injected(){} // RVA: 0x7FFD54C7C1B0
        public void set_nonJitteredProjectionMatrix_Injected(){} // RVA: 0x7FFD54C7C210
        public void get_previousViewProjectionMatrix_Injected(){} // RVA: 0x7FFD54C7C270
        public void CalculateObliqueMatrix_Injected(){} // RVA: 0x7FFD54C7C2D0
        public void WorldToScreenPoint_Injected(){} // RVA: 0x7FFD54C7C340
        public void WorldToViewportPoint_Injected(){} // RVA: 0x7FFD54C7C3C0
        public void ViewportToWorldPoint_Injected(){} // RVA: 0x7FFD54C7C440
        public void ScreenToWorldPoint_Injected(){} // RVA: 0x7FFD54C7C4C0
        public void ScreenToViewportPoint_Injected(){} // RVA: 0x7FFD54C7C540
        public void ViewportToScreenPoint_Injected(){} // RVA: 0x7FFD54C7C5B0
        public void GetFrustumPlaneSizeAt_Injected(){} // RVA: 0x7FFD54C7C620
        public void ViewportPointToRay_Injected(){} // RVA: 0x7FFD54C7C690
        public void ScreenPointToRay_Injected(){} // RVA: 0x7FFD54C7C710
        public void CalculateFrustumCornersInternal_Injected(){} // RVA: 0x7FFD54C7C790
        public void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(){} // RVA: 0x7FFD54C7C820
        public void get_scene_Injected(){} // RVA: 0x7FFD54C7C8B0
        public void set_scene_Injected(){} // RVA: 0x7FFD54C7C910
        public void GetStereoNonJitteredProjectionMatrix_Injected(){} // RVA: 0x7FFD54C7C970
        public void GetStereoViewMatrix_Injected(){} // RVA: 0x7FFD54C7C9E0
        public void GetStereoProjectionMatrix_Injected(){} // RVA: 0x7FFD54C7CA50
        public void SetStereoProjectionMatrix_Injected(){} // RVA: 0x7FFD54C7CAC0
        public void SetStereoViewMatrix_Injected(){} // RVA: 0x7FFD54C7CB30
    }

    public class Canvas : Behaviour
    {
        public e.TextCoreFontEngineModule renderMode;
        public e.TextCoreFontEngineModule isRootCanvas; // 0x8
        public ileFullDirectoryInformation<int> pixelRect; // 0x10
        public rectoryInformation<int,int> scaleFactor; // 0x18
        public ileFullDirectoryInformation<int> referencePixelsPerUnit; // 0x20

        // ── Methods ──
        public void add_preWillRenderCanvases(){} // RVA: 0x7FFD550576F0
        public void remove_preWillRenderCanvases(){} // RVA: 0x7FFD55057800
        public void add_willRenderCanvases(){} // RVA: 0x7FFD55057910
        public void remove_willRenderCanvases(){} // RVA: 0x7FFD55057A20
        public void get_renderMode(){} // RVA: 0x7FFD55057B30
        public void set_renderMode(){} // RVA: 0x7FFD55057B80
        public void get_isRootCanvas(){} // RVA: 0x7FFD55057BE0
        public void get_pixelRect(){} // RVA: 0x7FFD55057C30
        public void get_scaleFactor(){} // RVA: 0x7FFD55057CA0
        public void set_scaleFactor(){} // RVA: 0x7FFD55057CF0
        public void get_referencePixelsPerUnit(){} // RVA: 0x7FFD55057D50
        public void set_referencePixelsPerUnit(){} // RVA: 0x7FFD55057DA0
        public void get_overridePixelPerfect(){} // RVA: 0x7FFD55057E00
        public void set_overridePixelPerfect(){} // RVA: 0x7FFD55057E50
        public void get_vertexColorAlwaysGammaSpace(){} // RVA: 0x7FFD55057EB0
        public void set_vertexColorAlwaysGammaSpace(){} // RVA: 0x7FFD55057F00
        public void get_pixelPerfect(){} // RVA: 0x7FFD55057F60
        public void set_pixelPerfect(){} // RVA: 0x7FFD55057FB0
        public void get_planeDistance(){} // RVA: 0x7FFD55058010
        public void set_planeDistance(){} // RVA: 0x7FFD55058060
        public void get_renderOrder(){} // RVA: 0x7FFD550580C0
        public void get_overrideSorting(){} // RVA: 0x7FFD55058110
        public void set_overrideSorting(){} // RVA: 0x7FFD55058160
        public void get_sortingOrder(){} // RVA: 0x7FFD550581C0
        public void set_sortingOrder(){} // RVA: 0x7FFD55058210
        public void get_targetDisplay(){} // RVA: 0x7FFD55058270
        public void set_targetDisplay(){} // RVA: 0x7FFD550582C0
        public void get_sortingLayerID(){} // RVA: 0x7FFD55058320
        public void set_sortingLayerID(){} // RVA: 0x7FFD55058370
        public void get_cachedSortingLayerValue(){} // RVA: 0x7FFD550583D0
        public void get_additionalShaderChannels(){} // RVA: 0x7FFD55058420
        public void set_additionalShaderChannels(){} // RVA: 0x7FFD55058470
        public void get_sortingLayerName(){} // RVA: 0x7FFD550584D0
        public void set_sortingLayerName(){} // RVA: 0x7FFD55058520
        public void get_rootCanvas(){} // RVA: 0x7FFD55058580
        public void get_renderingDisplaySize(){} // RVA: 0x7FFD550585D0
        public void get_updateRectTransformForStandalone(){} // RVA: 0x7FFD55058630
        public void set_updateRectTransformForStandalone(){} // RVA: 0x7FFD55058680
        public void get_externBeginRenderOverlays(){} // RVA: 0x7FFD550586E0
        public void set_externBeginRenderOverlays(){} // RVA: 0x7FFD55058720
        public void get_externRenderOverlaysBefore(){} // RVA: 0x7FFD550587C0
        public void set_externRenderOverlaysBefore(){} // RVA: 0x7FFD55058800
        public void get_externEndRenderOverlays(){} // RVA: 0x7FFD550588A0
        public void set_externEndRenderOverlays(){} // RVA: 0x7FFD550588E0
        public void SetExternalCanvasEnabled(){} // RVA: 0x7FFD55058980
        public void get_worldCamera(){} // RVA: 0x7FFD550589D0
        public void set_worldCamera(){} // RVA: 0x7FFD55058A20
        public void get_normalizedSortingGridSize(){} // RVA: 0x7FFD55058A80
        public void set_normalizedSortingGridSize(){} // RVA: 0x7FFD55058AD0
        public void get_sortingGridNormalizedSize(){} // RVA: 0x7FFD55058B30
        public void set_sortingGridNormalizedSize(){} // RVA: 0x7FFD55058B80
        public void GetDefaultCanvasTextMaterial(){} // RVA: 0x7FFD55058BE0
        public void GetDefaultCanvasMaterial(){} // RVA: 0x7FFD55058C30
        public void GetETC1SupportedCanvasMaterial(){} // RVA: 0x7FFD55058C80
        public void UpdateCanvasRectTransform(){} // RVA: 0x7FFD55058CD0
        public void ForceUpdateCanvases(){} // RVA: 0x7FFD55058D30
        public void SendPreWillRenderCanvases(){} // RVA: 0x7FFD55058DD0
        public void SendWillRenderCanvases(){} // RVA: 0x7FFD55058E30
        public void BeginRenderExtraOverlays(){} // RVA: 0x7FFD55058E90
        public void RenderExtraOverlaysBefore(){} // RVA: 0x7FFD55058EF0
        public void EndRenderExtraOverlays(){} // RVA: 0x7FFD55058F60
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_pixelRect_Injected(){} // RVA: 0x7FFD55058FC0
        public void get_renderingDisplaySize_Injected(){} // RVA: 0x7FFD55059020
    }

    public class CanvasGroup : Behaviour
    {
        public object alpha;
        public object interactable;
        public object blocksRaycasts;
        public object ignoreParentGroups;

        // ── Methods ──
        public void get_alpha(){} // RVA: 0x7FFD55053340
        public void set_alpha(){} // RVA: 0x7FFD55053390
        public void get_interactable(){} // RVA: 0x7FFD550533F0
        public void set_interactable(){} // RVA: 0x7FFD55053440
        public void get_blocksRaycasts(){} // RVA: 0x7FFD550534A0
        public void set_blocksRaycasts(){} // RVA: 0x7FFD550534F0
        public void get_ignoreParentGroups(){} // RVA: 0x7FFD55053550
        public void set_ignoreParentGroups(){} // RVA: 0x7FFD550535A0
        public void IsRaycastLocationValid(){} // RVA: 0x7FFD550534A0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class CanvasRenderer : Component
    {
        public bool hasPopInstruction; // 0x18

        // ── Methods ──
        public void get_hasPopInstruction(){} // RVA: 0x7FFD55053600
        public void set_hasPopInstruction(){} // RVA: 0x7FFD55053650
        public void get_materialCount(){} // RVA: 0x7FFD550536B0
        public void set_materialCount(){} // RVA: 0x7FFD55053700
        public void get_popMaterialCount(){} // RVA: 0x7FFD55053760
        public void set_popMaterialCount(){} // RVA: 0x7FFD550537B0
        public void get_absoluteDepth(){} // RVA: 0x7FFD55053810
        public void get_hasMoved(){} // RVA: 0x7FFD55053860
        public void get_cullTransparentMesh(){} // RVA: 0x7FFD550538B0
        public void set_cullTransparentMesh(){} // RVA: 0x7FFD55053900
        public void get_hasRectClipping(){} // RVA: 0x7FFD55053960
        public void get_relativeDepth(){} // RVA: 0x7FFD550539B0
        public void get_cull(){} // RVA: 0x7FFD55053A00
        public void set_cull(){} // RVA: 0x7FFD55053A50
        public void get_isMask(){} // RVA: 0x7FFD4E35C4E0
        public void set_isMask(){} // RVA: 0x7FFD4E35C4F0
        public void SetColor(){} // RVA: 0x7FFD55053AB0
        public void GetColor(){} // RVA: 0x7FFD55053B10
        public void EnableRectClipping(){} // RVA: 0x7FFD55053B80
        public void get_clippingSoftness(){} // RVA: 0x7FFD55053BE0
        public void set_clippingSoftness(){} // RVA: 0x7FFD55053C40
        public void DisableRectClipping(){} // RVA: 0x7FFD55053CA0
        public void SetMaterial(){} // RVA: 0x7FFD550541F0 | overloaded x2
        public void GetMaterial(){} // RVA: 0x7FFD55054380 | overloaded x2
        public void SetPopMaterial(){} // RVA: 0x7FFD55053DC0
        public void GetPopMaterial(){} // RVA: 0x7FFD55053E30
        public void SetTexture(){} // RVA: 0x7FFD55053E90
        public void SetAlphaTexture(){} // RVA: 0x7FFD55053EF0
        public void SetMesh(){} // RVA: 0x7FFD55053F50
        public void GetMesh(){} // RVA: 0x7FFD55053FB0
        public void Clear(){} // RVA: 0x7FFD55054000
        public void GetAlpha(){} // RVA: 0x7FFD55054050
        public void SetAlpha(){} // RVA: 0x7FFD550540C0
        public void GetInheritedAlpha(){} // RVA: 0x7FFD550541A0
        public void SplitUIVertexStreams(){} // RVA: 0x7FFD550544F0 | overloaded x2
        public void CreateUIVertexStream(){} // RVA: 0x7FFD55054740 | overloaded x2
        public void AddUIVertexStream(){} // RVA: 0x7FFD55054900 | overloaded x2
        public void SetVertices(){} // RVA: 0x7FFD55054AD0 | overloaded x2
        public void SplitIndicesStreamsInternal(){} // RVA: 0x7FFD550554C0
        public void SplitUIVertexStreamsInternal(){} // RVA: 0x7FFD55054900
        public void CreateUIVertexStreamInternal(){} // RVA: 0x7FFD55054740
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void SetColor_Injected(){} // RVA: 0x7FFD55055520
        public void GetColor_Injected(){} // RVA: 0x7FFD55055580
        public void EnableRectClipping_Injected(){} // RVA: 0x7FFD550555E0
        public void get_clippingSoftness_Injected(){} // RVA: 0x7FFD55055640
        public void set_clippingSoftness_Injected(){} // RVA: 0x7FFD550556A0
    }

    public class CapsuleCollider : Collider
    {
        public object center;
        public object radius;
        public object height;
        public object direction;

        // ── Methods ──
        public void get_center(){} // RVA: 0x7FFD54DB9C20
        public void set_center(){} // RVA: 0x7FFD54DB9C90
        public void get_radius(){} // RVA: 0x7FFD54DB9CF0
        public void set_radius(){} // RVA: 0x7FFD54DB9D40
        public void get_height(){} // RVA: 0x7FFD54DB9DA0
        public void set_height(){} // RVA: 0x7FFD54DB9DF0
        public void get_direction(){} // RVA: 0x7FFD54DB9E50
        public void set_direction(){} // RVA: 0x7FFD54DB9EA0
        public void GetGlobalExtents(){} // RVA: 0x7FFD54DB9F00
        public void CalculateTransform(){} // RVA: 0x7FFD54DB9F60
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_center_Injected(){} // RVA: 0x7FFD54DB9FE0
        public void set_center_Injected(){} // RVA: 0x7FFD54DBA040
        public void GetGlobalExtents_Injected(){} // RVA: 0x7FFD54DBA0A0
        public void CalculateTransform_Injected(){} // RVA: 0x7FFD54DBA100
    }

    public class CapsuleCollider2D : Collider2D
    {
        public object size;
        public object direction;

        // ── Methods ──
        public void get_size(){} // RVA: 0x7FFD54DA0AF0
        public void set_size(){} // RVA: 0x7FFD54DA0B50
        public void get_direction(){} // RVA: 0x7FFD54DA0BB0
        public void set_direction(){} // RVA: 0x7FFD54DA0C00
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_size_Injected(){} // RVA: 0x7FFD54DA0C60
        public void set_size_Injected(){} // RVA: 0x7FFD54DA0CC0
    }

    public class CastHelper`1 : ValueType
    {
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
        public void SimpleMove(){} // RVA: 0x7FFD54DB9010
        public void Move(){} // RVA: 0x7FFD54DB9070
        public void get_velocity(){} // RVA: 0x7FFD54DB90D0
        public void get_isGrounded(){} // RVA: 0x7FFD54DB9140
        public void get_collisionFlags(){} // RVA: 0x7FFD54DB9190
        public void get_radius(){} // RVA: 0x7FFD54DB91E0
        public void set_radius(){} // RVA: 0x7FFD54DB9230
        public void get_height(){} // RVA: 0x7FFD54DB9290
        public void set_height(){} // RVA: 0x7FFD54DB92E0
        public void get_center(){} // RVA: 0x7FFD54DB9340
        public void set_center(){} // RVA: 0x7FFD54DB93B0
        public void get_slopeLimit(){} // RVA: 0x7FFD54DB9410
        public void set_slopeLimit(){} // RVA: 0x7FFD54DB9460
        public void get_stepOffset(){} // RVA: 0x7FFD54DB94C0
        public void set_stepOffset(){} // RVA: 0x7FFD54DB9510
        public void get_skinWidth(){} // RVA: 0x7FFD54DB9570
        public void set_skinWidth(){} // RVA: 0x7FFD54DB95C0
        public void get_minMoveDistance(){} // RVA: 0x7FFD54DB9620
        public void set_minMoveDistance(){} // RVA: 0x7FFD54DB9670
        public void get_detectCollisions(){} // RVA: 0x7FFD54DB96D0
        public void set_detectCollisions(){} // RVA: 0x7FFD54DB9720
        public void get_enableOverlapRecovery(){} // RVA: 0x7FFD54DB9780
        public void set_enableOverlapRecovery(){} // RVA: 0x7FFD54DB97D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void SimpleMove_Injected(){} // RVA: 0x7FFD54DB9830
        public void Move_Injected(){} // RVA: 0x7FFD54DB9890
        public void get_velocity_Injected(){} // RVA: 0x7FFD54DB98F0
        public void get_center_Injected(){} // RVA: 0x7FFD54DB9950
        public void set_center_Injected(){} // RVA: 0x7FFD54DB99B0
    }

    public class CharacterJoint : Joint
    {
        public R_12x12 swingAxis; // 0x18
        public amut twistLimitSpring; // 0x28
        public odyPositionInternal_Injected swingLimitSpring; // 0x34

        // ── Methods ──
        public void get_swingAxis(){} // RVA: 0x7FFD54DBC7E0
        public void set_swingAxis(){} // RVA: 0x7FFD54DBC850
        public void get_twistLimitSpring(){} // RVA: 0x7FFD54DBC8B0
        public void set_twistLimitSpring(){} // RVA: 0x7FFD54DBC910
        public void get_swingLimitSpring(){} // RVA: 0x7FFD54DBC970
        public void set_swingLimitSpring(){} // RVA: 0x7FFD54DBC9D0
        public void get_lowTwistLimit(){} // RVA: 0x7FFD54DBCA30
        public void set_lowTwistLimit(){} // RVA: 0x7FFD54DBCAA0
        public void get_highTwistLimit(){} // RVA: 0x7FFD54DBCB00
        public void set_highTwistLimit(){} // RVA: 0x7FFD54DBCB70
        public void get_swing1Limit(){} // RVA: 0x7FFD54DBCBD0
        public void set_swing1Limit(){} // RVA: 0x7FFD54DBCC40
        public void get_swing2Limit(){} // RVA: 0x7FFD54DBCCA0
        public void set_swing2Limit(){} // RVA: 0x7FFD54DBCD10
        public void get_enableProjection(){} // RVA: 0x7FFD54DBCD70
        public void set_enableProjection(){} // RVA: 0x7FFD54DBCDC0
        public void get_projectionDistance(){} // RVA: 0x7FFD54DBCE20
        public void set_projectionDistance(){} // RVA: 0x7FFD54DBCE70
        public void get_projectionAngle(){} // RVA: 0x7FFD54DBCED0
        public void set_projectionAngle(){} // RVA: 0x7FFD54DBCF20
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_swingAxis_Injected(){} // RVA: 0x7FFD54DBCF80
        public void set_swingAxis_Injected(){} // RVA: 0x7FFD54DBCFE0
        public void get_twistLimitSpring_Injected(){} // RVA: 0x7FFD54DBD040
        public void set_twistLimitSpring_Injected(){} // RVA: 0x7FFD54DBD0A0
        public void get_swingLimitSpring_Injected(){} // RVA: 0x7FFD54DBD100
        public void set_swingLimitSpring_Injected(){} // RVA: 0x7FFD54DBD160
        public void get_lowTwistLimit_Injected(){} // RVA: 0x7FFD54DBD1C0
        public void set_lowTwistLimit_Injected(){} // RVA: 0x7FFD54DBD220
        public void get_highTwistLimit_Injected(){} // RVA: 0x7FFD54DBD280
        public void set_highTwistLimit_Injected(){} // RVA: 0x7FFD54DBD2E0
        public void get_swing1Limit_Injected(){} // RVA: 0x7FFD54DBD340
        public void set_swing1Limit_Injected(){} // RVA: 0x7FFD54DBD3A0
        public void get_swing2Limit_Injected(){} // RVA: 0x7FFD54DBD400
        public void set_swing2Limit_Injected(){} // RVA: 0x7FFD54DBD460
    }

    public class CircleCollider2D : Collider2D
    {
        public object radius;

        // ── Methods ──
        public void get_radius(){} // RVA: 0x7FFD54DA0A40
        public void set_radius(){} // RVA: 0x7FFD54DA0A90
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class ClassLibraryInitializer : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFD54CC8150
        public void InitStdErrWithHandle(){} // RVA: 0x7FFD54CDAD40
        public void InitAssemblyRedirections(){} // RVA: 0x7FFD54CDB060
    }

    public class Cloth : Component
    {
        public float vertices; // 0x18
        public bool normals; // 0x1C

        // ── Methods ──
        public void get_vertices(){} // RVA: 0x7FFD54C6CD30
        public void get_normals(){} // RVA: 0x7FFD54C6CD80
        public void get_coefficients(){} // RVA: 0x7FFD54C6CDD0
        public void set_coefficients(){} // RVA: 0x7FFD54C6CE20
        public void get_capsuleColliders(){} // RVA: 0x7FFD54C6CE80
        public void set_capsuleColliders(){} // RVA: 0x7FFD54C6CED0
        public void get_sphereColliders(){} // RVA: 0x7FFD54C6CF30
        public void set_sphereColliders(){} // RVA: 0x7FFD54C6CF80
        public void get_sleepThreshold(){} // RVA: 0x7FFD54C6CFE0
        public void set_sleepThreshold(){} // RVA: 0x7FFD54C6D030
        public void get_bendingStiffness(){} // RVA: 0x7FFD54C6D090
        public void set_bendingStiffness(){} // RVA: 0x7FFD54C6D0E0
        public void get_stretchingStiffness(){} // RVA: 0x7FFD54C6D140
        public void set_stretchingStiffness(){} // RVA: 0x7FFD54C6D190
        public void get_damping(){} // RVA: 0x7FFD54C6D1F0
        public void set_damping(){} // RVA: 0x7FFD54C6D240
        public void get_externalAcceleration(){} // RVA: 0x7FFD54C6D2A0
        public void set_externalAcceleration(){} // RVA: 0x7FFD54C6D310
        public void get_randomAcceleration(){} // RVA: 0x7FFD54C6D370
        public void set_randomAcceleration(){} // RVA: 0x7FFD54C6D3E0
        public void get_useGravity(){} // RVA: 0x7FFD54C6D440
        public void set_useGravity(){} // RVA: 0x7FFD54C6D490
        public void get_enabled(){} // RVA: 0x7FFD54C6D4F0
        public void set_enabled(){} // RVA: 0x7FFD54C6D540
        public void get_friction(){} // RVA: 0x7FFD54C6D5A0
        public void set_friction(){} // RVA: 0x7FFD54C6D5F0
        public void get_collisionMassScale(){} // RVA: 0x7FFD54C6D650
        public void set_collisionMassScale(){} // RVA: 0x7FFD54C6D6A0
        public void get_enableContinuousCollision(){} // RVA: 0x7FFD54C6D700
        public void set_enableContinuousCollision(){} // RVA: 0x7FFD54C6D750
        public void get_useVirtualParticles(){} // RVA: 0x7FFD54C6D7B0
        public void set_useVirtualParticles(){} // RVA: 0x7FFD54C6D800
        public void get_worldVelocityScale(){} // RVA: 0x7FFD54C6D860
        public void set_worldVelocityScale(){} // RVA: 0x7FFD54C6D8B0
        public void get_worldAccelerationScale(){} // RVA: 0x7FFD54C6D910
        public void set_worldAccelerationScale(){} // RVA: 0x7FFD54C6D960
        public void get_clothSolverFrequency(){} // RVA: 0x7FFD54C6D9C0
        public void set_clothSolverFrequency(){} // RVA: 0x7FFD54C6DA10
        public void get_solverFrequency(){} // RVA: 0x7FFD54C6DA70
        public void set_solverFrequency(){} // RVA: 0x7FFD54C6DAD0
        public void get_useTethers(){} // RVA: 0x7FFD54C6DB50
        public void set_useTethers(){} // RVA: 0x7FFD54C6DBA0
        public void get_stiffnessFrequency(){} // RVA: 0x7FFD54C6DC00
        public void set_stiffnessFrequency(){} // RVA: 0x7FFD54C6DC50
        public void get_selfCollisionDistance(){} // RVA: 0x7FFD54C6DCB0
        public void set_selfCollisionDistance(){} // RVA: 0x7FFD54C6DD00
        public void get_selfCollisionStiffness(){} // RVA: 0x7FFD54C6DD60
        public void set_selfCollisionStiffness(){} // RVA: 0x7FFD54C6DDB0
        public void ClearTransformMotion(){} // RVA: 0x7FFD54C6DE10
        public void GetSelfAndInterCollisionIndices(){} // RVA: 0x7FFD54C6DE60
        public void SetSelfAndInterCollisionIndices(){} // RVA: 0x7FFD54C6DEC0
        public void GetVirtualParticleIndices(){} // RVA: 0x7FFD54C6DF20
        public void SetVirtualParticleIndices(){} // RVA: 0x7FFD54C6DF80
        public void GetVirtualParticleWeights(){} // RVA: 0x7FFD54C6DFE0
        public void SetVirtualParticleWeights(){} // RVA: 0x7FFD54C6E040
        public void get_useContinuousCollision(){} // RVA: 0x7FFD4E345CF0
        public void set_useContinuousCollision(){} // RVA: 0x7FFD4E35C4D0
        public void get_selfCollision(){} // RVA: 0x7FFD4E35C390
        public void SetEnabledFading(){} // RVA: 0x7FFD54C6E110 | overloaded x2
        public void Raycast(){} // RVA: 0x7FFD54C6E180
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_externalAcceleration_Injected(){} // RVA: 0x7FFD54C6E220
        public void set_externalAcceleration_Injected(){} // RVA: 0x7FFD54C6E280
        public void get_randomAcceleration_Injected(){} // RVA: 0x7FFD54C6E2E0
        public void set_randomAcceleration_Injected(){} // RVA: 0x7FFD54C6E340
        public void Raycast_Injected(){} // RVA: 0x7FFD54C6E3A0
    }

    public class ClothSkinningCoefficient : ValueType
    {
        public float maxDistance; // 0x10
        public float collisionSphereDistance; // 0x14
    }

    public class ClothSphereColliderPair : ValueType
    {
        public cted first; // 0x10
        public cted second; // 0x18

        // ── Methods ──
        public void get_first(){} // RVA: 0x7FFD4EEF9F60
        public void get_second(){} // RVA: 0x7FFD4F840220
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
        public void get_enabled(){} // RVA: 0x7FFD54DB8120
        public void set_enabled(){} // RVA: 0x7FFD54DB8170
        public void get_attachedRigidbody(){} // RVA: 0x7FFD54DB81D0
        public void get_attachedArticulationBody(){} // RVA: 0x7FFD54DB8220
        public void get_isTrigger(){} // RVA: 0x7FFD54DB8270
        public void set_isTrigger(){} // RVA: 0x7FFD54DB82C0
        public void get_contactOffset(){} // RVA: 0x7FFD54DB8320
        public void set_contactOffset(){} // RVA: 0x7FFD54DB8370
        public void ClosestPoint(){} // RVA: 0x7FFD54DB83D0
        public void get_bounds(){} // RVA: 0x7FFD54DB8450
        public void get_hasModifiableContacts(){} // RVA: 0x7FFD54DB84C0
        public void set_hasModifiableContacts(){} // RVA: 0x7FFD54DB8510
        public void get_providesContacts(){} // RVA: 0x7FFD54DB8570
        public void set_providesContacts(){} // RVA: 0x7FFD54DB85C0
        public void get_layerOverridePriority(){} // RVA: 0x7FFD54DB8620
        public void set_layerOverridePriority(){} // RVA: 0x7FFD54DB8670
        public void get_excludeLayers(){} // RVA: 0x7FFD54DB86D0
        public void set_excludeLayers(){} // RVA: 0x7FFD54DB8730
        public void get_includeLayers(){} // RVA: 0x7FFD54DB8790
        public void set_includeLayers(){} // RVA: 0x7FFD54DB87F0
        public void get_sharedMaterial(){} // RVA: 0x7FFD54DB8850
        public void set_sharedMaterial(){} // RVA: 0x7FFD54DB88A0
        public void get_material(){} // RVA: 0x7FFD54DB8900
        public void set_material(){} // RVA: 0x7FFD54DB8950
        public void Raycast(){} // RVA: 0x7FFD54DB8A50 | overloaded x2
        public void Internal_ClosestPointOnBounds(){} // RVA: 0x7FFD54DB8B40
        public void ClosestPointOnBounds(){} // RVA: 0x7FFD54DB8BC0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void ClosestPoint_Injected(){} // RVA: 0x7FFD54DB8CB0
        public void get_bounds_Injected(){} // RVA: 0x7FFD54DB8D20
        public void get_excludeLayers_Injected(){} // RVA: 0x7FFD54DB8D80
        public void set_excludeLayers_Injected(){} // RVA: 0x7FFD54DB8DE0
        public void get_includeLayers_Injected(){} // RVA: 0x7FFD54DB8E40
        public void set_includeLayers_Injected(){} // RVA: 0x7FFD54DB8EA0
        public void Raycast_Injected(){} // RVA: 0x7FFD54DB8F00
        public void Internal_ClosestPointOnBounds_Injected(){} // RVA: 0x7FFD54DB8F90
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
        public void get_density(){} // RVA: 0x7FFD54D9D6D0
        public void set_density(){} // RVA: 0x7FFD54D9D720
        public void get_isTrigger(){} // RVA: 0x7FFD54D9D780
        public void set_isTrigger(){} // RVA: 0x7FFD54D9D7D0
        public void get_usedByEffector(){} // RVA: 0x7FFD54D9D830
        public void set_usedByEffector(){} // RVA: 0x7FFD54D9D880
        public void get_usedByComposite(){} // RVA: 0x7FFD54D9D8E0
        public void set_usedByComposite(){} // RVA: 0x7FFD54D9D930
        public void get_composite(){} // RVA: 0x7FFD54D9D990
        public void get_offset(){} // RVA: 0x7FFD54D9D9E0
        public void set_offset(){} // RVA: 0x7FFD54D9DA40
        public void get_attachedRigidbody(){} // RVA: 0x7FFD54D9DAA0
        public void get_shapeCount(){} // RVA: 0x7FFD54D9DAF0
        public void CreateMesh(){} // RVA: 0x7FFD54D9DB40
        public void GetShapeHash(){} // RVA: 0x7FFD54D9DBC0
        public void GetShapes(){} // RVA: 0x7FFD54D9DCA0 | overloaded x2
        public void GetShapes_Internal(){} // RVA: 0x7FFD54D9DE40
        public void get_bounds(){} // RVA: 0x7FFD54D9DEC0
        public void get_errorState(){} // RVA: 0x7FFD54D9DF30
        public void get_sharedMaterial(){} // RVA: 0x7FFD54D9DF80
        public void set_sharedMaterial(){} // RVA: 0x7FFD54D9DFD0
        public void get_layerOverridePriority(){} // RVA: 0x7FFD54D9E030
        public void set_layerOverridePriority(){} // RVA: 0x7FFD54D9E080
        public void get_excludeLayers(){} // RVA: 0x7FFD54D9E0E0
        public void set_excludeLayers(){} // RVA: 0x7FFD54D9E140
        public void get_includeLayers(){} // RVA: 0x7FFD54D9E1A0
        public void set_includeLayers(){} // RVA: 0x7FFD54D9E200
        public void get_forceSendLayers(){} // RVA: 0x7FFD54D9E260
        public void set_forceSendLayers(){} // RVA: 0x7FFD54D9E2C0
        public void get_forceReceiveLayers(){} // RVA: 0x7FFD54D9E320
        public void set_forceReceiveLayers(){} // RVA: 0x7FFD54D9E380
        public void get_contactCaptureLayers(){} // RVA: 0x7FFD54D9E3E0
        public void set_contactCaptureLayers(){} // RVA: 0x7FFD54D9E440
        public void get_callbackLayers(){} // RVA: 0x7FFD54D9E4A0
        public void set_callbackLayers(){} // RVA: 0x7FFD54D9E500
        public void get_friction(){} // RVA: 0x7FFD54D9E560
        public void get_bounciness(){} // RVA: 0x7FFD54D9E5B0
        public void IsTouching(){} // RVA: 0x7FFD54D9E750 | overloaded x3
        public void IsTouching_OtherColliderWithFilter(){} // RVA: 0x7FFD54D9E6E0
        public void IsTouching_AnyColliderWithFilter(){} // RVA: 0x7FFD54D9E7C0
        public void IsTouchingLayers(){} // RVA: 0x7FFD54D9E880 | overloaded x2
        public void OverlapPoint(){} // RVA: 0x7FFD54D9E8E0
        public void Distance(){} // RVA: 0x7FFD54D9E940
        public void OverlapCollider(){} // RVA: 0x7FFD54D84EF0 | overloaded x2
        public void GetContacts(){} // RVA: 0x7FFD54D9EE80 | overloaded x8
        public void Cast(){} // RVA: 0x7FFD54D9F7D0 | overloaded x7
        public void CastArray_Internal(){} // RVA: 0x7FFD54D9F730
        public void CastList_Internal(){} // RVA: 0x7FFD54D9F880
        public void Raycast(){} // RVA: 0x7FFD54D9FF90 | overloaded x8
        public void RaycastArray_Internal(){} // RVA: 0x7FFD54D9FF00
        public void RaycastList_Internal(){} // RVA: 0x7FFD54DA0030
        public void ClosestPoint(){} // RVA: 0x7FFD54DA00C0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_offset_Injected(){} // RVA: 0x7FFD54DA0130
        public void set_offset_Injected(){} // RVA: 0x7FFD54DA0190
        public void get_bounds_Injected(){} // RVA: 0x7FFD54DA01F0
        public void get_excludeLayers_Injected(){} // RVA: 0x7FFD54DA0250
        public void set_excludeLayers_Injected(){} // RVA: 0x7FFD54DA02B0
        public void get_includeLayers_Injected(){} // RVA: 0x7FFD54DA0310
        public void set_includeLayers_Injected(){} // RVA: 0x7FFD54DA0370
        public void get_forceSendLayers_Injected(){} // RVA: 0x7FFD54DA03D0
        public void set_forceSendLayers_Injected(){} // RVA: 0x7FFD54DA0430
        public void get_forceReceiveLayers_Injected(){} // RVA: 0x7FFD54DA0490
        public void set_forceReceiveLayers_Injected(){} // RVA: 0x7FFD54DA04F0
        public void get_contactCaptureLayers_Injected(){} // RVA: 0x7FFD54DA0550
        public void set_contactCaptureLayers_Injected(){} // RVA: 0x7FFD54DA05B0
        public void get_callbackLayers_Injected(){} // RVA: 0x7FFD54DA0610
        public void set_callbackLayers_Injected(){} // RVA: 0x7FFD54DA0670
        public void IsTouching_OtherColliderWithFilter_Injected(){} // RVA: 0x7FFD54DA06D0
        public void IsTouching_AnyColliderWithFilter_Injected(){} // RVA: 0x7FFD54DA0740
        public void OverlapPoint_Injected(){} // RVA: 0x7FFD54DA07A0
        public void CastArray_Internal_Injected(){} // RVA: 0x7FFD54DA0800
        public void CastList_Internal_Injected(){} // RVA: 0x7FFD54DA0890
        public void RaycastArray_Internal_Injected(){} // RVA: 0x7FFD54DA0920
        public void RaycastList_Internal_Injected(){} // RVA: 0x7FFD54DA09B0
    }

    public class Collision : Object
    {
        public ANGUAGES_FILE_NAME impulse; // 0x10
        public kingField relativeVelocity; // 0x38
        public bool rigidbody; // 0x60
        public RotationOffset[] articulationBody; // 0x68

        // ── Methods ──
        public void get_impulse(){} // RVA: 0x7FFD4E3A7FA0
        public void get_relativeVelocity(){} // RVA: 0x7FFD54DA7650
        public void get_rigidbody(){} // RVA: 0x7FFD54DA76B0
        public void get_articulationBody(){} // RVA: 0x7FFD54DA7750
        public void get_body(){} // RVA: 0x7FFD54DA77F0
        public void get_collider(){} // RVA: 0x7FFD54DA7820
        public void get_transform(){} // RVA: 0x7FFD54DA7850
        public void get_gameObject(){} // RVA: 0x7FFD54DA79D0
        public void set_Flipped(){} // RVA: 0x7FFD4E36A030
        public void get_contactCount(){} // RVA: 0x7FFD54DA7B70
        public void get_contacts(){} // RVA: 0x7FFD54DA7B80
        public void .ctor(){} // RVA: 0x7FFD54DA7D00 | overloaded x2
        public void Reuse(){} // RVA: 0x7FFD54DA7E60
        public void GetContact(){} // RVA: 0x7FFD54DA7EF0
        public void GetContacts(){} // RVA: 0x7FFD54DA8250 | overloaded x2
    }

    public class Collision2D : Object
    {
        public int collider; // 0x10
        public int otherCollider; // 0x14
        public int rigidbody; // 0x18
        public int otherRigidbody; // 0x1C
        public tionX transform; // 0x20
        public int gameObject; // 0x28
        public int relativeVelocity; // 0x2C
        public ceSettings[] enabled; // 0x30
        public ceSettings[] contacts; // 0x38

        // ── Methods ──
        public void GetContacts_Internal(){} // RVA: 0x7FFD54D97F90
        public void get_collider(){} // RVA: 0x7FFD54D97FB0
        public void get_otherCollider(){} // RVA: 0x7FFD54D980A0
        public void get_rigidbody(){} // RVA: 0x7FFD54D98190
        public void get_otherRigidbody(){} // RVA: 0x7FFD54D98250
        public void get_transform(){} // RVA: 0x7FFD54D98310
        public void get_gameObject(){} // RVA: 0x7FFD54D98490
        public void get_relativeVelocity(){} // RVA: 0x7FFD54D98610
        public void get_enabled(){} // RVA: 0x7FFD54D98630
        public void get_contacts(){} // RVA: 0x7FFD54D98640
        public void get_contactCount(){} // RVA: 0x7FFD54C34E40
        public void GetContact(){} // RVA: 0x7FFD54D98800
        public void GetContacts(){} // RVA: 0x7FFD54D98A90 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Color : ValueType
    {
        public float red; // 0x10
        public float green; // 0x14
        public float blue; // 0x18
        public float white; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54CC8410 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD54CC8450 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFD5057C940
        public void Equals(){} // RVA: 0x7FFD4FC9E150 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFD54CC8740
        public void op_Subtraction(){} // RVA: 0x7FFD54CC87A0
        public void op_Multiply(){} // RVA: 0x7FFD54CC88B0 | overloaded x3
        public void op_Division(){} // RVA: 0x7FFD54CC8900
        public void op_Equality(){} // RVA: 0x7FFD54CC8920
        public void op_Inequality(){} // RVA: 0x7FFD54CC8990
        public void Lerp(){} // RVA: 0x7FFD4E38DEC0
        public void LerpUnclamped(){} // RVA: 0x7FFD54CC8A00
        public void RGBMultiplied(){} // RVA: 0x7FFD54CC8A80
        public void get_red(){} // RVA: 0x7FFD4E38E260
        public void get_green(){} // RVA: 0x7FFD4E3655D0
        public void get_blue(){} // RVA: 0x7FFD4E81B2C0
        public void get_white(){} // RVA: 0x7FFD4E3B71E0
        public void get_black(){} // RVA: 0x7FFD4E365950
        public void get_yellow(){} // RVA: 0x7FFD4E365590
        public void get_cyan(){} // RVA: 0x7FFD54CC8AD0
        public void get_magenta(){} // RVA: 0x7FFD4E4E6D20
        public void get_gray(){} // RVA: 0x7FFD4E365A50
        public void get_grey(){} // RVA: 0x7FFD4E365A50
        public void get_clear(){} // RVA: 0x7FFD4E792CF0
        public void get_grayscale(){} // RVA: 0x7FFD54CC8AE0
        public void get_linear(){} // RVA: 0x7FFD54146360
        public void get_gamma(){} // RVA: 0x7FFD54CC8B20
        public void get_maxColorComponent(){} // RVA: 0x7FFD54CC8C70
        public void op_Implicit(){} // RVA: 0x7FFD54CC8C90 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFD53D267F0
        public void set_Item(){} // RVA: 0x7FFD54CC8CB0
        public void RGBToHSV(){} // RVA: 0x7FFD54CC8D80
        public void RGBToHSVHelper(){} // RVA: 0x7FFD54CC8E20
        public void HSVToRGB(){} // RVA: 0x7FFD54CC8F00 | overloaded x2
    }

    public class Color32 : ValueType
    {
        public int Item; // 0x10
        public byte r; // 0x10
        public byte g; // 0x11
        public byte b; // 0x12
        public byte a; // 0x13

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E535270
        public void op_Implicit(){} // RVA: 0x7FFD54CC92F0 | overloaded x2
        public void Lerp(){} // RVA: 0x7FFD54CC9370
        public void LerpUnclamped(){} // RVA: 0x7FFD4EE8B490
        public void get_Item(){} // RVA: 0x7FFD54CC9480
        public void set_Item(){} // RVA: 0x7FFD54CC9550
        public void ToString(){} // RVA: 0x7FFD54CC9640 | overloaded x3
    }

    public class Component : Object
    {
        public object transform;
        public object gameObject;
        public object tag;

        // ── Methods ──
        public void get_transform(){} // RVA: 0x7FFD4E7DCDF0
        public void get_gameObject(){} // RVA: 0x7FFD4E7DD180
        public void GetComponent(){} // RVA: 0x7FFD54CDC070 | overloaded x3
        public void GetComponentFastPath(){} // RVA: 0x7FFD54CDBE20
        public void TryGetComponent(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void GetComponentInChildren(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void GetComponentsInChildren(){} // RVA: 0x7FFD4E090A40 | overloaded x6
        public void GetComponentInParent(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void GetComponentsInParent(){} // RVA: 0x7FFD4E078E90 | overloaded x5
        public void GetComponents(){} // RVA: 0x7FFD4E078E90 | overloaded x4
        public void GetComponentsForListInternal(){} // RVA: 0x7FFD54CDC4E0
        public void get_tag(){} // RVA: 0x7FFD54CDC560
        public void set_tag(){} // RVA: 0x7FFD54CDC600
        public void GetComponentIndex(){} // RVA: 0x7FFD4E5F8770
        public void CompareTag(){} // RVA: 0x7FFD54CDC6B0
        public void SendMessageUpwards(){} // RVA: 0x7FFD54CDC7E0 | overloaded x2
        public void SendMessage(){} // RVA: 0x7FFD54CDC920 | overloaded x4
        public void BroadcastMessage(){} // RVA: 0x7FFD54CDCA00 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFD4E341D50
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
        public void get_geometryType(){} // RVA: 0x7FFD54DA2190
        public void set_geometryType(){} // RVA: 0x7FFD54DA21E0
        public void get_generationType(){} // RVA: 0x7FFD54DA2240
        public void set_generationType(){} // RVA: 0x7FFD54DA2290
        public void get_useDelaunayMesh(){} // RVA: 0x7FFD54DA22F0
        public void set_useDelaunayMesh(){} // RVA: 0x7FFD54DA2340
        public void get_vertexDistance(){} // RVA: 0x7FFD54DA23A0
        public void set_vertexDistance(){} // RVA: 0x7FFD54DA23F0
        public void get_edgeRadius(){} // RVA: 0x7FFD54DA2450
        public void set_edgeRadius(){} // RVA: 0x7FFD54DA24A0
        public void get_offsetDistance(){} // RVA: 0x7FFD54DA2500
        public void set_offsetDistance(){} // RVA: 0x7FFD54DA2550
        public void GenerateGeometry(){} // RVA: 0x7FFD54DA25B0
        public void GetPathPointCount(){} // RVA: 0x7FFD54DA2600
        public void GetPathPointCount_Internal(){} // RVA: 0x7FFD54DA2770
        public void get_pathCount(){} // RVA: 0x7FFD54DA27D0
        public void get_pointCount(){} // RVA: 0x7FFD54DA2820
        public void GetPath(){} // RVA: 0x7FFD54DA2AB0 | overloaded x2
        public void GetPathArray_Internal(){} // RVA: 0x7FFD54DA2A40
        public void GetPathList_Internal(){} // RVA: 0x7FFD54DA2C80
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class ComputeBuffer : Object
    {
        public UIntPtr count; // 0x10

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFD54CE9130
        public void Dispose(){} // RVA: 0x7FFD54CE92A0 | overloaded x2
        public void InitBuffer(){} // RVA: 0x7FFD54CE9380
        public void DestroyBuffer(){} // RVA: 0x7FFD54CE9400
        public void .ctor(){} // RVA: 0x7FFD54CE94B0 | overloaded x3
        public void Release(){} // RVA: 0x7FFD54CE91D0
        public void IsValidBuffer(){} // RVA: 0x7FFD54CE9700
        public void IsValid(){} // RVA: 0x7FFD54CE9750
        public void get_count(){} // RVA: 0x7FFD54CE97C0
        public void get_stride(){} // RVA: 0x7FFD54CE9810
        public void SetData(){} // RVA: 0x7FFD54CE9A00 | overloaded x2
        public void InternalSetData(){} // RVA: 0x7FFD54CE9CA0
        public void GetData(){} // RVA: 0x7FFD54CE9D30
        public void InternalGetData(){} // RVA: 0x7FFD54CE9F00
        public void set_name(){} // RVA: 0x7FFD54CE9F90
        public void SetName(){} // RVA: 0x7FFD54CE9F90
        public void SetCounterValue(){} // RVA: 0x7FFD54CE9FF0
        public void CopyCount(){} // RVA: 0x7FFD54CEA050
    }

    public class ComputeShader : Object
    {
        // ── Methods ──
        public void FindKernel(){} // RVA: 0x7FFD54CEA0C0
        public void SetFloat(){} // RVA: 0x7FFD54CEA120
        public void SetInt(){} // RVA: 0x7FFD54CEA190
        public void SetVector(){} // RVA: 0x7FFD54CEA200
        public void SetMatrix(){} // RVA: 0x7FFD54CEA270
        public void SetVectorArray(){} // RVA: 0x7FFD54CEA2E0
        public void SetTexture(){} // RVA: 0x7FFD54CEA5D0 | overloaded x2
        public void Internal_SetBuffer(){} // RVA: 0x7FFD54CEA3D0
        public void SetBuffer(){} // RVA: 0x7FFD54CEA3D0
        public void GetKernelThreadGroupSizes(){} // RVA: 0x7FFD54CEA450
        public void Dispatch(){} // RVA: 0x7FFD54CEA4D0
        public void SetBool(){} // RVA: 0x7FFD54CEA550
        public void SetVector_Injected(){} // RVA: 0x7FFD54CEA660
        public void SetMatrix_Injected(){} // RVA: 0x7FFD54CEA6D0
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
        public void get_secondaryAxis(){} // RVA: 0x7FFD54DBD4C0
        public void set_secondaryAxis(){} // RVA: 0x7FFD54DBD530
        public void get_xMotion(){} // RVA: 0x7FFD54DBD590
        public void set_xMotion(){} // RVA: 0x7FFD54DBD5E0
        public void get_yMotion(){} // RVA: 0x7FFD54DBD640
        public void set_yMotion(){} // RVA: 0x7FFD54DBD690
        public void get_zMotion(){} // RVA: 0x7FFD54DBD6F0
        public void set_zMotion(){} // RVA: 0x7FFD54DBD740
        public void get_angularXMotion(){} // RVA: 0x7FFD54DBD7A0
        public void set_angularXMotion(){} // RVA: 0x7FFD54DBD7F0
        public void get_angularYMotion(){} // RVA: 0x7FFD54DBD850
        public void set_angularYMotion(){} // RVA: 0x7FFD54DBD8A0
        public void get_angularZMotion(){} // RVA: 0x7FFD54DBD900
        public void set_angularZMotion(){} // RVA: 0x7FFD54DBD950
        public void get_linearLimitSpring(){} // RVA: 0x7FFD54DBD9B0
        public void set_linearLimitSpring(){} // RVA: 0x7FFD54DBDA10
        public void get_angularXLimitSpring(){} // RVA: 0x7FFD54DBDA70
        public void set_angularXLimitSpring(){} // RVA: 0x7FFD54DBDAD0
        public void get_angularYZLimitSpring(){} // RVA: 0x7FFD54DBDB30
        public void set_angularYZLimitSpring(){} // RVA: 0x7FFD54DBDB90
        public void get_linearLimit(){} // RVA: 0x7FFD54DBDBF0
        public void set_linearLimit(){} // RVA: 0x7FFD54DBDC60
        public void get_lowAngularXLimit(){} // RVA: 0x7FFD54DBDCC0
        public void set_lowAngularXLimit(){} // RVA: 0x7FFD54DBDD30
        public void get_highAngularXLimit(){} // RVA: 0x7FFD54DBDD90
        public void set_highAngularXLimit(){} // RVA: 0x7FFD54DBDE00
        public void get_angularYLimit(){} // RVA: 0x7FFD54DBDE60
        public void set_angularYLimit(){} // RVA: 0x7FFD54DBDED0
        public void get_angularZLimit(){} // RVA: 0x7FFD54DBDF30
        public void set_angularZLimit(){} // RVA: 0x7FFD54DBDFA0
        public void get_targetPosition(){} // RVA: 0x7FFD54DBE000
        public void set_targetPosition(){} // RVA: 0x7FFD54DBE070
        public void get_targetVelocity(){} // RVA: 0x7FFD54DBE0D0
        public void set_targetVelocity(){} // RVA: 0x7FFD54DBE140
        public void get_xDrive(){} // RVA: 0x7FFD54DBE1A0
        public void set_xDrive(){} // RVA: 0x7FFD54DBE210
        public void get_yDrive(){} // RVA: 0x7FFD54DBE270
        public void set_yDrive(){} // RVA: 0x7FFD54DBE2E0
        public void get_zDrive(){} // RVA: 0x7FFD54DBE340
        public void set_zDrive(){} // RVA: 0x7FFD54DBE3B0
        public void get_targetRotation(){} // RVA: 0x7FFD54DBE410
        public void set_targetRotation(){} // RVA: 0x7FFD54DBE480
        public void get_targetAngularVelocity(){} // RVA: 0x7FFD54DBE4E0
        public void set_targetAngularVelocity(){} // RVA: 0x7FFD54DBE550
        public void get_rotationDriveMode(){} // RVA: 0x7FFD54DBE5B0
        public void set_rotationDriveMode(){} // RVA: 0x7FFD54DBE600
        public void get_angularXDrive(){} // RVA: 0x7FFD54DBE660
        public void set_angularXDrive(){} // RVA: 0x7FFD54DBE6D0
        public void get_angularYZDrive(){} // RVA: 0x7FFD54DBE730
        public void set_angularYZDrive(){} // RVA: 0x7FFD54DBE7A0
        public void get_slerpDrive(){} // RVA: 0x7FFD54DBE800
        public void set_slerpDrive(){} // RVA: 0x7FFD54DBE870
        public void get_projectionMode(){} // RVA: 0x7FFD54DBE8D0
        public void set_projectionMode(){} // RVA: 0x7FFD54DBE920
        public void get_projectionDistance(){} // RVA: 0x7FFD54DBE980
        public void set_projectionDistance(){} // RVA: 0x7FFD54DBE9D0
        public void get_projectionAngle(){} // RVA: 0x7FFD54DBEA30
        public void set_projectionAngle(){} // RVA: 0x7FFD54DBEA80
        public void get_configuredInWorldSpace(){} // RVA: 0x7FFD54DBEAE0
        public void set_configuredInWorldSpace(){} // RVA: 0x7FFD54DBEB30
        public void get_swapBodies(){} // RVA: 0x7FFD54DBEB90
        public void set_swapBodies(){} // RVA: 0x7FFD54DBEBE0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_secondaryAxis_Injected(){} // RVA: 0x7FFD54DBEC40
        public void set_secondaryAxis_Injected(){} // RVA: 0x7FFD54DBECA0
        public void get_linearLimitSpring_Injected(){} // RVA: 0x7FFD54DBED00
        public void set_linearLimitSpring_Injected(){} // RVA: 0x7FFD54DBED60
        public void get_angularXLimitSpring_Injected(){} // RVA: 0x7FFD54DBEDC0
        public void set_angularXLimitSpring_Injected(){} // RVA: 0x7FFD54DBEE20
        public void get_angularYZLimitSpring_Injected(){} // RVA: 0x7FFD54DBEE80
        public void set_angularYZLimitSpring_Injected(){} // RVA: 0x7FFD54DBEEE0
        public void get_linearLimit_Injected(){} // RVA: 0x7FFD54DBEF40
        public void set_linearLimit_Injected(){} // RVA: 0x7FFD54DBEFA0
        public void get_lowAngularXLimit_Injected(){} // RVA: 0x7FFD54DBF000
        public void set_lowAngularXLimit_Injected(){} // RVA: 0x7FFD54DBF060
        public void get_highAngularXLimit_Injected(){} // RVA: 0x7FFD54DBF0C0
        public void set_highAngularXLimit_Injected(){} // RVA: 0x7FFD54DBF120
        public void get_angularYLimit_Injected(){} // RVA: 0x7FFD54DBF180
        public void set_angularYLimit_Injected(){} // RVA: 0x7FFD54DBF1E0
        public void get_angularZLimit_Injected(){} // RVA: 0x7FFD54DBF240
        public void set_angularZLimit_Injected(){} // RVA: 0x7FFD54DBF2A0
        public void get_targetPosition_Injected(){} // RVA: 0x7FFD54DBF300
        public void set_targetPosition_Injected(){} // RVA: 0x7FFD54DBF360
        public void get_targetVelocity_Injected(){} // RVA: 0x7FFD54DBF3C0
        public void set_targetVelocity_Injected(){} // RVA: 0x7FFD54DBF420
        public void get_xDrive_Injected(){} // RVA: 0x7FFD54DBF480
        public void set_xDrive_Injected(){} // RVA: 0x7FFD54DBF4E0
        public void get_yDrive_Injected(){} // RVA: 0x7FFD54DBF540
        public void set_yDrive_Injected(){} // RVA: 0x7FFD54DBF5A0
        public void get_zDrive_Injected(){} // RVA: 0x7FFD54DBF600
        public void set_zDrive_Injected(){} // RVA: 0x7FFD54DBF660
        public void get_targetRotation_Injected(){} // RVA: 0x7FFD54DBF6C0
        public void set_targetRotation_Injected(){} // RVA: 0x7FFD54DBF720
        public void get_targetAngularVelocity_Injected(){} // RVA: 0x7FFD54DBF780
        public void set_targetAngularVelocity_Injected(){} // RVA: 0x7FFD54DBF7E0
        public void get_angularXDrive_Injected(){} // RVA: 0x7FFD54DBF840
        public void set_angularXDrive_Injected(){} // RVA: 0x7FFD54DBF8A0
        public void get_angularYZDrive_Injected(){} // RVA: 0x7FFD54DBF900
        public void set_angularYZDrive_Injected(){} // RVA: 0x7FFD54DBF960
        public void get_slerpDrive_Injected(){} // RVA: 0x7FFD54DBF9C0
        public void set_slerpDrive_Injected(){} // RVA: 0x7FFD54DBFA20
    }

    public class ConstantForce : Behaviour
    {
        public object force;
        public object relativeForce;
        public object torque;
        public object relativeTorque;

        // ── Methods ──
        public void get_force(){} // RVA: 0x7FFD54DBA800
        public void set_force(){} // RVA: 0x7FFD54DBA870
        public void get_relativeForce(){} // RVA: 0x7FFD54DBA8D0
        public void set_relativeForce(){} // RVA: 0x7FFD54DBA940
        public void get_torque(){} // RVA: 0x7FFD54DBA9A0
        public void set_torque(){} // RVA: 0x7FFD54DBAA10
        public void get_relativeTorque(){} // RVA: 0x7FFD54DBAA70
        public void set_relativeTorque(){} // RVA: 0x7FFD54DBAAE0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_force_Injected(){} // RVA: 0x7FFD54DBAB40
        public void set_force_Injected(){} // RVA: 0x7FFD54DBABA0
        public void get_relativeForce_Injected(){} // RVA: 0x7FFD54DBAC00
        public void set_relativeForce_Injected(){} // RVA: 0x7FFD54DBAC60
        public void get_torque_Injected(){} // RVA: 0x7FFD54DBACC0
        public void set_torque_Injected(){} // RVA: 0x7FFD54DBAD20
        public void get_relativeTorque_Injected(){} // RVA: 0x7FFD54DBAD80
        public void set_relativeTorque_Injected(){} // RVA: 0x7FFD54DBADE0
    }

    public class ConstantForce2D : PhysicsUpdateBehaviour2D
    {
        public object force;
        public object relativeForce;
        public object torque;

        // ── Methods ──
        public void get_force(){} // RVA: 0x7FFD54DA6EA0
        public void set_force(){} // RVA: 0x7FFD54DA6F00
        public void get_relativeForce(){} // RVA: 0x7FFD54DA6F60
        public void set_relativeForce(){} // RVA: 0x7FFD54DA6FC0
        public void get_torque(){} // RVA: 0x7FFD54DA7020
        public void set_torque(){} // RVA: 0x7FFD54DA7070
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_force_Injected(){} // RVA: 0x7FFD54DA70D0
        public void set_force_Injected(){} // RVA: 0x7FFD54DA7130
        public void get_relativeForce_Injected(){} // RVA: 0x7FFD54DA7190
        public void set_relativeForce_Injected(){} // RVA: 0x7FFD54DA71F0
    }

    public class ContactFilter2D : ValueType
    {
        public bool isFiltering; // 0x10
        public bool useLayerMask; // 0x11
        public bool useDepth; // 0x12
        public bool useOutsideDepth; // 0x13
        public bool useNormalAngle; // 0x14
        public bool useOutsideNormalAngle; // 0x15
        public object layerMask; // 0x18
        public float minDepth; // 0x1C
        public float maxDepth; // 0x20
        public float minNormalAngle; // 0x24
        public float maxNormalAngle; // 0x28

        // ── Methods ──
        public void NoFilter(){} // RVA: 0x7FFD54D97930
        public void CheckConsistency(){} // RVA: 0x7FFD54D97980
        public void ClearLayerMask(){} // RVA: 0x7FFD54D979D0
        public void SetLayerMask(){} // RVA: 0x7FFD54D979E0
        public void ClearDepth(){} // RVA: 0x7FFD54D979F0
        public void SetDepth(){} // RVA: 0x7FFD54D97A00
        public void ClearNormalAngle(){} // RVA: 0x7FFD54D97A60
        public void SetNormalAngle(){} // RVA: 0x7FFD54D97A70
        public void get_isFiltering(){} // RVA: 0x7FFD54D97AD0
        public void IsFilteringTrigger(){} // RVA: 0x7FFD54D97B00
        public void IsFilteringLayerMask(){} // RVA: 0x7FFD54D97B80
        public void IsFilteringDepth(){} // RVA: 0x7FFD54D97C10
        public void IsFilteringNormalAngle(){} // RVA: 0x7FFD54D97D90 | overloaded x2
        public void IsFilteringNormalAngleUsingAngle(){} // RVA: 0x7FFD54D97D90
        public void CreateLegacyFilter(){} // RVA: 0x7FFD54D97DF0
        public void CheckConsistency_Injected(){} // RVA: 0x7FFD54D97980
        public void IsFilteringNormalAngle_Injected(){} // RVA: 0x7FFD54D97F30
        public void IsFilteringNormalAngleUsingAngle_Injected(){} // RVA: 0x7FFD54D97D90
    }

    public class ContactPair : ValueType
    {
        public int ColliderInstanceID; // 0x10
        public int OtherColliderInstanceID; // 0x14
        public UIntPtr Collider; // 0x18
        public uint OtherCollider; // 0x20
        public LanguageDictionary ImpulseSum; // 0x24
        public t IsCollisionEnter; // 0x26
        public amut IsCollisionExit; // 0x28

        // ── Methods ──
        public void get_ColliderInstanceID(){} // RVA: 0x7FFD4F840210
        public void get_OtherColliderInstanceID(){} // RVA: 0x7FFD4F8402A0
        public void get_Collider(){} // RVA: 0x7FFD54DC2EB0
        public void get_OtherCollider(){} // RVA: 0x7FFD54DC2F50
        public void get_ImpulseSum(){} // RVA: 0x7FFD521548B0
        public void get_IsCollisionEnter(){} // RVA: 0x7FFD54DC2FF0
        public void get_IsCollisionExit(){} // RVA: 0x7FFD54DC3000
        public void get_IsCollisionStay(){} // RVA: 0x7FFD54DC3010
        public void get_HasRemovedCollider(){} // RVA: 0x7FFD54DC2E00
        public void ExtractContacts(){} // RVA: 0x7FFD54DC3020
        public void ExtractContactsArray(){} // RVA: 0x7FFD54DC3090
        public void GetContactPoint_Internal(){} // RVA: 0x7FFD54DC3100
        public void ExtractContacts_Injected(){} // RVA: 0x7FFD54DC3020
        public void ExtractContactsArray_Injected(){} // RVA: 0x7FFD54DC3090
    }

    public class ContactPairHeader : ValueType
    {
        public object Body;
        public object OtherBody;
        public object HasRemovedBody;

        // ── Methods ──
        public void get_Body(){} // RVA: 0x7FFD54DC2CE0
        public void get_OtherBody(){} // RVA: 0x7FFD54DC2D70
        public void get_HasRemovedBody(){} // RVA: 0x7FFD54DC2E00
        public void GetContactPair(){} // RVA: 0x7FFD54DC2E20
        public void GetContactPair_Internal(){} // RVA: 0x7FFD54DC2E30
    }

    public class ContactPoint : ValueType
    {
        public amut point; // 0x10
        public amut normal; // 0x1C
        public amut impulse; // 0x28
        public int thisCollider; // 0x34
        public int otherCollider; // 0x38
        public float separation; // 0x3C

        // ── Methods ──
        public void get_point(){} // RVA: 0x7FFD54C31DA0
        public void get_normal(){} // RVA: 0x7FFD54C31DC0
        public void get_impulse(){} // RVA: 0x7FFD54C50D10
        public void get_thisCollider(){} // RVA: 0x7FFD54DBFA80
        public void get_otherCollider(){} // RVA: 0x7FFD54DBFB10
        public void get_separation(){} // RVA: 0x7FFD54D5FB10
        public void .ctor(){} // RVA: 0x7FFD54DBFBA0
    }

    public class ContactPoint2D : ValueType
    {
        public tionX point; // 0x10
        public tionX normal; // 0x18
        public tionX separation; // 0x20
        public float normalImpulse; // 0x28
        public float tangentImpulse; // 0x2C
        public float relativeVelocity; // 0x30
        public int collider; // 0x34
        public int otherCollider; // 0x38
        public int rigidbody; // 0x3C
        public int otherRigidbody; // 0x40
        public int enabled; // 0x44

        // ── Methods ──
        public void get_point(){} // RVA: 0x7FFD505F9A30
        public void get_normal(){} // RVA: 0x7FFD54C86820
        public void get_separation(){} // RVA: 0x7FFD54C31DF0
        public void get_normalImpulse(){} // RVA: 0x7FFD54C34E00
        public void get_tangentImpulse(){} // RVA: 0x7FFD54C32640
        public void get_relativeVelocity(){} // RVA: 0x7FFD54D97900
        public void get_collider(){} // RVA: 0x7FFD54D98C30
        public void get_otherCollider(){} // RVA: 0x7FFD54D98D20
        public void get_rigidbody(){} // RVA: 0x7FFD54D98E10
        public void get_otherRigidbody(){} // RVA: 0x7FFD54D98ED0
        public void get_enabled(){} // RVA: 0x7FFD54D98F90
    }

    public class ContextMenu : Attribute
    {
        public string menuItem; // 0x10
        public bool validate; // 0x18
        public int priority; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54CDA7E0 | overloaded x3
    }

    public class ControllerColliderHit : Object
    {
        public ProcessAnimationJobStruct`1 controller; // 0x10
        public riteCharacterUnicode collider; // 0x18
        public amut rigidbody; // 0x20
        public amut gameObject; // 0x2C
        public amut transform; // 0x38
        public float point; // 0x44
        public int normal; // 0x48

        // ── Methods ──
        public void get_controller(){} // RVA: 0x7FFD510E4750
        public void get_collider(){} // RVA: 0x7FFD50CC1130
        public void get_rigidbody(){} // RVA: 0x7FFD54DA74C0
        public void get_gameObject(){} // RVA: 0x7FFD54DA7520
        public void get_transform(){} // RVA: 0x7FFD54DA7580
        public void get_point(){} // RVA: 0x7FFD54DA75E0
        public void get_normal(){} // RVA: 0x7FFD54DA7600
        public void get_moveDirection(){} // RVA: 0x7FFD54DA7620
        public void get_moveLength(){} // RVA: 0x7FFD54DA7640
    }

    public class Coroutine : YieldInstruction
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Finalize(){} // RVA: 0x7FFD54CDCA20
        public void ReleaseCoroutine(){} // RVA: 0x7FFD54CDCAA0
    }

    public class CreateAssetMenuAttribute : Attribute
    {
        public string menuName; // 0x10
        public string fileName; // 0x18
        public int order; // 0x20

        // ── Methods ──
        public void set_menuName(){} // RVA: 0x7FFD4E342E30
        public void set_fileName(){} // RVA: 0x7FFD4E3A7E80
        public void set_order(){} // RVA: 0x7FFD4E9FB7A0
        public void .ctor(){} // RVA: 0x7FFD4E341310
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
        public void get_format(){} // RVA: 0x7FFD54CBC220
        public void Internal_CreateImpl(){} // RVA: 0x7FFD54CBC270
        public void Internal_Create(){} // RVA: 0x7FFD54CBC2F0
        public void ApplyImpl(){} // RVA: 0x7FFD54CBC3E0
        public void get_isReadable(){} // RVA: 0x7FFD54CBC460
        public void SetPixelImpl(){} // RVA: 0x7FFD54CBC4B0
        public void GetPixelImpl(){} // RVA: 0x7FFD54CBC550
        public void SmoothEdges(){} // RVA: 0x7FFD54CBC650 | overloaded x2
        public void GetPixels(){} // RVA: 0x7FFD54CBC720 | overloaded x2
        public void SetPixels(){} // RVA: 0x7FFD54CBC890 | overloaded x2
        public void SetPixelDataImplArray(){} // RVA: 0x7FFD54CBC800
        public void get_streamingMipmaps(){} // RVA: 0x7FFD54CBC8B0
        public void get_streamingMipmapsPriority(){} // RVA: 0x7FFD54CBC900
        public void get_requestedMipmapLevel(){} // RVA: 0x7FFD54CBC950
        public void set_requestedMipmapLevel(){} // RVA: 0x7FFD54CBC9A0
        public void get_desiredMipmapLevel(){} // RVA: 0x7FFD54CBCA00
        public void get_loadingMipmapLevel(){} // RVA: 0x7FFD54CBCA50
        public void get_loadedMipmapLevel(){} // RVA: 0x7FFD54CBCAA0
        public void ClearRequestedMipmapLevel(){} // RVA: 0x7FFD54CBCAF0
        public void ValidateFormat(){} // RVA: 0x7FFD54CBCC60 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD54CBD6A0 | overloaded x9
        public void CreateExternalTexture(){} // RVA: 0x7FFD54CBD6D0
        public void SetPixelData(){}
        public void SetPixel(){} // RVA: 0x7FFD54CBD840 | overloaded x2
        public void GetPixel(){} // RVA: 0x7FFD54CBD960 | overloaded x2
        public void Apply(){} // RVA: 0x7FFD54CBDB30 | overloaded x3
        public void ValidateIsNotCrunched(){} // RVA: 0x7FFD54CBDB40
        public void SetPixelImpl_Injected(){} // RVA: 0x7FFD54CBDBA0
        public void GetPixelImpl_Injected(){} // RVA: 0x7FFD54CBDC20
    }

    public class CubemapArray : Texture
    {
        public object isReadable;

        // ── Methods ──
        public void get_isReadable(){} // RVA: 0x7FFD54CC0600
        public void Internal_CreateImpl(){} // RVA: 0x7FFD54CC0650
        public void Internal_Create(){} // RVA: 0x7FFD54CC06D0
        public void .ctor(){} // RVA: 0x7FFD54CC0EB0 | overloaded x9
        public void ValidateIsNotCrunched(){} // RVA: 0x7FFD54CC0F70
    }

    public class CullingGroup : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public ityEngine.UIElements.IStyle.get_textShadow m_OnStateChanged; // 0x18

        // ── Methods ──
        public void SendEvents(){} // RVA: 0x7FFD54C7CBA0
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
        public void Internal_CreateCustomRenderTexture(){} // RVA: 0x7FFD54CC4FE0
        public void TriggerUpdate(){} // RVA: 0x7FFD54CC5030
        public void Update(){} // RVA: 0x7FFD54CC5140 | overloaded x2
        public void TriggerInitialization(){} // RVA: 0x7FFD54CC5150
        public void Initialize(){} // RVA: 0x7FFD54CC51A0
        public void ClearUpdateZones(){} // RVA: 0x7FFD54CC5240
        public void get_material(){} // RVA: 0x7FFD54CC5290
        public void set_material(){} // RVA: 0x7FFD54CC52E0
        public void get_initializationMaterial(){} // RVA: 0x7FFD54CC5340
        public void set_initializationMaterial(){} // RVA: 0x7FFD54CC5390
        public void get_initializationTexture(){} // RVA: 0x7FFD54CC53F0
        public void set_initializationTexture(){} // RVA: 0x7FFD54CC5440
        public void GetUpdateZonesInternal(){} // RVA: 0x7FFD54CC54A0
        public void GetUpdateZones(){} // RVA: 0x7FFD54CC54A0
        public void SetUpdateZonesInternal(){} // RVA: 0x7FFD54CC5500
        public void GetDoubleBufferRenderTexture(){} // RVA: 0x7FFD54CC5560
        public void EnsureDoubleBufferConsistency(){} // RVA: 0x7FFD54CC55B0
        public void SetUpdateZones(){} // RVA: 0x7FFD54CC5600
        public void get_initializationSource(){} // RVA: 0x7FFD54CC56B0
        public void set_initializationSource(){} // RVA: 0x7FFD54CC5700
        public void get_initializationColor(){} // RVA: 0x7FFD54CC5760
        public void set_initializationColor(){} // RVA: 0x7FFD54CC57D0
        public void get_updateMode(){} // RVA: 0x7FFD54CC5830
        public void set_updateMode(){} // RVA: 0x7FFD54CC5880
        public void get_initializationMode(){} // RVA: 0x7FFD54CC58E0
        public void set_initializationMode(){} // RVA: 0x7FFD54CC5930
        public void get_updateZoneSpace(){} // RVA: 0x7FFD54CC5990
        public void set_updateZoneSpace(){} // RVA: 0x7FFD54CC59E0
        public void get_shaderPass(){} // RVA: 0x7FFD54CC5A40
        public void set_shaderPass(){} // RVA: 0x7FFD54CC5A90
        public void get_cubemapFaceMask(){} // RVA: 0x7FFD54CC5AF0
        public void set_cubemapFaceMask(){} // RVA: 0x7FFD54CC5B40
        public void get_doubleBuffered(){} // RVA: 0x7FFD54CC5BA0
        public void set_doubleBuffered(){} // RVA: 0x7FFD54CC5BF0
        public void get_wrapUpdateZones(){} // RVA: 0x7FFD54CC5C50
        public void set_wrapUpdateZones(){} // RVA: 0x7FFD54CC5CA0
        public void get_updatePeriod(){} // RVA: 0x7FFD54CC5D00
        public void set_updatePeriod(){} // RVA: 0x7FFD54CC5D50
        public void .ctor(){} // RVA: 0x7FFD54CC5FC0 | overloaded x5
        public void get_initializationColor_Injected(){} // RVA: 0x7FFD54CC6200
        public void set_initializationColor_Injected(){} // RVA: 0x7FFD54CC6260
    }

    public class CustomRenderTextureManager : Object
    {
        public ileFullDirectoryInformation<nIntensity> textureLoaded;
        public ileFullDirectoryInformation<nIntensity> textureUnloaded; // 0x8
        public rectoryInformation<nIntensity,int> updateTriggered; // 0x10
        public ileFullDirectoryInformation<nIntensity> initializeTriggered; // 0x18

        // ── Methods ──
        public void InvokeOnTextureLoaded_Internal(){} // RVA: 0x7FFD54C8B220
        public void InvokeOnTextureUnloaded_Internal(){} // RVA: 0x7FFD54C8B280
        public void InvokeTriggerUpdate(){} // RVA: 0x7FFD54C8B2E0
        public void InvokeTriggerInitialize(){} // RVA: 0x7FFD54C8B350
    }

    public class CustomRenderTextureUpdateZone : ValueType
    {
        public amut updateZoneCenter; // 0x10
        public amut updateZoneSize; // 0x1C
        public float rotation; // 0x28
        public int passIndex; // 0x2C
        public bool needSwap; // 0x30
    }

    public class CustomYieldInstruction : Object
    {
        public object keepWaiting;
        public object Current;

        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x7FFD4E079D00
        public void get_Current(){} // RVA: 0x7FFD51B532B0
        public void MoveNext(){} // RVA: 0x7FFD4FBEB300
        public void Reset(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}