// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 84
// Methods: 2131

namespace ThirdParty.Unity.UnityEngine
{
    public class Cache : ValueType
    {
        // ── Methods ──
        public void get_handle(){} // RVA: 0x454FE0
        public void GetHashCode(){} // RVA: 0x454FE0
        public void Equals(){} // RVA: 0x95FA90
        public void get_valid(){} // RVA: 0x95FAA0
        public void Cache_IsValid(){} // RVA: 0x7B56560
        public void get_path(){} // RVA: 0x95FAF0
        public void Cache_GetPath(){} // RVA: 0x7B565C0
        public void set_maximumAvailableStorageSpace(){} // RVA: 0x95FB00
        public void Cache_SetMaximumDiskSpaceAvailable(){} // RVA: 0x7B566F0
        public void get_spaceOccupied(){} // RVA: 0x95FB60
        public void Cache_GetCachingDiskSpaceUsed(){} // RVA: 0x7B567A0
        public void Cache_GetPath_Injected(){} // RVA: 0x7B567F0
    }

    public class CachedAssetBundle : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x31FB70
        public void get_name(){} // RVA: 0x44D9F0
        public void get_hash(){} // RVA: 0x95FA00
    }

    public class CachedAssetBundle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Caching : Object
    {
        // ── Methods ──
        public void ClearCache(){} // RVA: 0x7B568A0
        public void ClearCache_Int(){} // RVA: 0x7B568A0
        public void ClearOtherCachedVersions(){} // RVA: 0x7B568F0
        public void ClearAllCachedVersions(){} // RVA: 0x7B56970
        public void ClearCachedVersions(){} // RVA: 0x7B569F0
        public void IsVersionCached(){} // RVA: 0x7B56C10
        public void MarkAsUsed(){} // RVA: 0x7B56EC0
        public void AddCache(){} // RVA: 0x7B57320
        public void GetCacheByPath(){} // RVA: 0x7B574B0
        public void get_currentCacheForWriting(){} // RVA: 0x7B57630
        public void set_currentCacheForWriting(){} // RVA: 0x7B57690
        public void ClearCachedVersions_Injected(){} // RVA: 0x7B576E0
        public void IsVersionCached_Injected(){} // RVA: 0x7B57750
        public void MarkAsUsed_Injected(){} // RVA: 0x7B577C0
        public void AddCache_Injected(){} // RVA: 0x7B57830
        public void GetCacheByPath_Injected(){} // RVA: 0x7B578A0
        public void get_currentCacheForWriting_Injected(){} // RVA: 0x7B57900
        public void set_currentCacheForWriting_Injected(){} // RVA: 0x7B57950
    }

    public class Camera : Behaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
        public void get_nearClipPlane(){} // RVA: 0x7B57AB0
        public void set_nearClipPlane(){} // RVA: 0x7B57B50
        public void get_farClipPlane(){} // RVA: 0x7B57C00
        public void set_farClipPlane(){} // RVA: 0x7B57CA0
        public void get_fieldOfView(){} // RVA: 0x7B57D50
        public void set_fieldOfView(){} // RVA: 0x7B57DF0
        public void get_renderingPath(){} // RVA: 0x7B57EA0
        public void set_renderingPath(){} // RVA: 0x7B57F40
        public void get_actualRenderingPath(){} // RVA: 0x7B57FF0
        public void Reset(){} // RVA: 0x7B58090
        public void get_allowHDR(){} // RVA: 0x7B58130
        public void set_allowHDR(){} // RVA: 0x7B581D0
        public void get_allowMSAA(){} // RVA: 0x7B58280
        public void set_allowMSAA(){} // RVA: 0x7B58320
        public void get_allowDynamicResolution(){} // RVA: 0x7B583D0
        public void set_allowDynamicResolution(){} // RVA: 0x7B58470
        public void get_forceIntoRenderTexture(){} // RVA: 0x7B58520
        public void set_forceIntoRenderTexture(){} // RVA: 0x7B585C0
        public void get_orthographicSize(){} // RVA: 0x7B58670
        public void set_orthographicSize(){} // RVA: 0x7B58710
        public void get_orthographic(){} // RVA: 0x7B587C0
        public void set_orthographic(){} // RVA: 0x7B58860
        public void get_opaqueSortMode(){} // RVA: 0x7B58910
        public void set_opaqueSortMode(){} // RVA: 0x7B589B0
        public void get_transparencySortMode(){} // RVA: 0x7B58A60
        public void set_transparencySortMode(){} // RVA: 0x7B58B00
        public void get_transparencySortAxis(){} // RVA: 0x7B58BB0
        public void set_transparencySortAxis(){} // RVA: 0x7B58C70
        public void ResetTransparencySortSettings(){} // RVA: 0x7B58D20
        public void get_depth(){} // RVA: 0x7B58DC0
        public void set_depth(){} // RVA: 0x7B58E60
        public void get_aspect(){} // RVA: 0x7B58F10
        public void set_aspect(){} // RVA: 0x7B58FB0
        public void ResetAspect(){} // RVA: 0x7B59060
        public void get_velocity(){} // RVA: 0x7B59100
        public void get_cullingMask(){} // RVA: 0x7B591C0
        public void set_cullingMask(){} // RVA: 0x7B59260
        public void get_eventMask(){} // RVA: 0x7B59310
        public void set_eventMask(){} // RVA: 0x7B593B0
        public void get_layerCullSpherical(){} // RVA: 0x7B59460
        public void set_layerCullSpherical(){} // RVA: 0x7B59500
        public void get_layerCullSphericalInternal(){} // RVA: 0x7B59460
        public void set_layerCullSphericalInternal(){} // RVA: 0x7B596D0
        public void get_cameraType(){} // RVA: 0x7B59780
        public void set_cameraType(){} // RVA: 0x7B59820
        public void get_skyboxMaterial(){} // RVA: 0x7B598D0
        public void get_overrideSceneCullingMask(){} // RVA: 0x7B59990
        public void set_overrideSceneCullingMask(){} // RVA: 0x7B59A30
        public void get_sceneCullingMask(){} // RVA: 0x7B59AE0
        public void get_useInteractiveLightBakingData(){} // RVA: 0x7B59B80
        public void set_useInteractiveLightBakingData(){} // RVA: 0x7B59C20
        public void GetLayerCullDistances(){} // RVA: 0x7B59CD0
        public void SetLayerCullDistances(){} // RVA: 0x7B59E10
        public void get_layerCullDistances(){} // RVA: 0x7B59F40
        public void set_layerCullDistances(){} // RVA: 0x7B59F50
        public void get_PreviewCullingLayer(){} // RVA: 0x7B5A0C0
        public void get_useOcclusionCulling(){} // RVA: 0x7B5A0D0
        public void set_useOcclusionCulling(){} // RVA: 0x7B5A170
        public void get_cullingMatrix(){} // RVA: 0x7B5A220
        public void set_cullingMatrix(){} // RVA: 0x7B5A2E0
        public void ResetCullingMatrix(){} // RVA: 0x7B5A390
        public void get_backgroundColor(){} // RVA: 0x7B5A430
        public void set_backgroundColor(){} // RVA: 0x7B5A4F0
        public void get_clearFlags(){} // RVA: 0x7B5A5A0
        public void set_clearFlags(){} // RVA: 0x7B5A640
        public void get_depthTextureMode(){} // RVA: 0x7B5A6F0
        public void set_depthTextureMode(){} // RVA: 0x7B5A790
        public void get_clearStencilAfterLightingPass(){} // RVA: 0x7B5A840
        public void set_clearStencilAfterLightingPass(){} // RVA: 0x7B5A8E0
        public void SetReplacementShader(){} // RVA: 0x7B5A990
        public void ResetReplacementShader(){} // RVA: 0x7B5AB50
        public void get_projectionMatrixMode(){} // RVA: 0x7B5ABF0
        public void get_usePhysicalProperties(){} // RVA: 0x7B5AC90
        public void set_usePhysicalProperties(){} // RVA: 0x7B5AD30
        public void get_iso(){} // RVA: 0x7B5ADE0
        public void set_iso(){} // RVA: 0x7B5AE80
        public void get_shutterSpeed(){} // RVA: 0x7B5AF30
        public void set_shutterSpeed(){} // RVA: 0x7B5AFD0
        public void get_aperture(){} // RVA: 0x7B5B080
        public void set_aperture(){} // RVA: 0x7B5B120
        public void get_focusDistance(){} // RVA: 0x7B5B1D0
        public void set_focusDistance(){} // RVA: 0x7B5B270
        public void get_focalLength(){} // RVA: 0x7B5B320
        public void set_focalLength(){} // RVA: 0x7B5B3C0
        public void get_bladeCount(){} // RVA: 0x7B5B470
        public void set_bladeCount(){} // RVA: 0x7B5B510
        public void get_curvature(){} // RVA: 0x7B5B5C0
        public void set_curvature(){} // RVA: 0x7B5B670
        public void get_barrelClipping(){} // RVA: 0x7B5B720
        public void set_barrelClipping(){} // RVA: 0x7B5B7C0
        public void get_anamorphism(){} // RVA: 0x7B5B870
        public void set_anamorphism(){} // RVA: 0x7B5B910
        public void get_sensorSize(){} // RVA: 0x7B5B9C0
        public void set_sensorSize(){} // RVA: 0x7B5BA70
        public void get_lensShift(){} // RVA: 0x7B5BB20
        public void set_lensShift(){} // RVA: 0x7B5BBD0
        public void get_gateFit(){} // RVA: 0x7B5BC80
        public void set_gateFit(){} // RVA: 0x7B5BD20
        public void GetGateFittedFieldOfView(){} // RVA: 0x7B5BDD0
        public void GetGateFittedLensShift(){} // RVA: 0x7B5BE70
        public void GetLocalSpaceAim(){} // RVA: 0x7B5BF20
        public void get_rect(){} // RVA: 0x7B5BFE0
        public void set_rect(){} // RVA: 0x7B5C0A0
        public void get_pixelRect(){} // RVA: 0x7B5C150
        public void set_pixelRect(){} // RVA: 0x7B5C210
        public void get_pixelWidth(){} // RVA: 0x7B5C2C0
        public void get_pixelHeight(){} // RVA: 0x7B5C360
        public void get_scaledPixelWidth(){} // RVA: 0x7B5C400
        public void get_scaledPixelHeight(){} // RVA: 0x7B5C4A0
        public void get_targetTexture(){} // RVA: 0x7B5C540
        public void set_targetTexture(){} // RVA: 0x7B5C600
        public void get_activeTexture(){} // RVA: 0x7B5C6E0
        public void get_targetDisplay(){} // RVA: 0x7B5C7A0
        public void set_targetDisplay(){} // RVA: 0x7B5C840
        public void SetTargetBuffersImpl(){} // RVA: 0x7B5C8F0
        public void SetTargetBuffers(){} // RVA: 0x7B5CBA0
        public void SetTargetBuffersMRTImpl(){} // RVA: 0x7B5CA70
        public void GetCameraBufferWarnings(){} // RVA: 0x7B5CCD0
        public void get_cameraToWorldMatrix(){} // RVA: 0x7B5CD70
        public void get_worldToCameraMatrix(){} // RVA: 0x7B5CE30
        public void set_worldToCameraMatrix(){} // RVA: 0x7B5CEF0
        public void get_projectionMatrix(){} // RVA: 0x7B5CFA0
        public void set_projectionMatrix(){} // RVA: 0x7B5D060
        public void get_nonJitteredProjectionMatrix(){} // RVA: 0x7B5D110
        public void set_nonJitteredProjectionMatrix(){} // RVA: 0x7B5D1D0
        public void get_useJitteredProjectionMatrixForTransparentRendering(){} // RVA: 0x7B5D280
        public void set_useJitteredProjectionMatrixForTransparentRendering(){} // RVA: 0x7B5D320
        public void get_previousViewProjectionMatrix(){} // RVA: 0x7B5D3D0
        public void ResetWorldToCameraMatrix(){} // RVA: 0x7B5D490
        public void ResetProjectionMatrix(){} // RVA: 0x7B5D530
        public void CalculateObliqueMatrix(){} // RVA: 0x7B5D5D0
        public void WorldToScreenPoint(){} // RVA: 0x7B5DA20
        public void WorldToViewportPoint(){} // RVA: 0x7B5DB10
        public void ViewportToWorldPoint(){} // RVA: 0x7B5DC00
        public void ScreenToWorldPoint(){} // RVA: 0x7B5DCF0
        public void ScreenToViewportPoint(){} // RVA: 0x7B5DDE0
        public void ViewportToScreenPoint(){} // RVA: 0x7B5DEB0
        public void GetFrustumPlaneSizeAt(){} // RVA: 0x7B5DF80
        public void ViewportPointToRay(){} // RVA: 0x7B5E240
        public void ScreenPointToRay(){} // RVA: 0x7B5E550
        public void CalculateFrustumCornersInternal(){} // RVA: 0x7B5E660
        public void CalculateFrustumCorners(){} // RVA: 0x7B5E7F0
        public void CalculateProjectionMatrixFromPhysicalPropertiesInternal(){} // RVA: 0x7B5E8E0
        public void CalculateProjectionMatrixFromPhysicalProperties(){} // RVA: 0x7B5E990
        public void FocalLengthToFieldOfView(){} // RVA: 0x7B5EA40
        public void FieldOfViewToFocalLength(){} // RVA: 0x7B5EAB0
        public void HorizontalToVerticalFieldOfView(){} // RVA: 0x7B5EB20
        public void VerticalToHorizontalFieldOfView(){} // RVA: 0x7B5EB90
        public void get_main(){} // RVA: 0x7B5EC00
        public void get_current(){} // RVA: 0x7B5EC80
        public void get_currentInternal(){} // RVA: 0x7B5EC80
        public void get_scene(){} // RVA: 0x7B5ED00
        public void set_scene(){} // RVA: 0x7B5EDB0
        public void get_stereoEnabled(){} // RVA: 0x7B5EE60
        public void get_stereoSeparation(){} // RVA: 0x7B5EF00
        public void set_stereoSeparation(){} // RVA: 0x7B5EFA0
        public void get_stereoConvergence(){} // RVA: 0x7B5F050
        public void set_stereoConvergence(){} // RVA: 0x7B5F0F0
        public void get_areVRStereoViewMatricesWithinSingleCullTolerance(){} // RVA: 0x7B5F1A0
        public void get_stereoTargetEye(){} // RVA: 0x7B5F240
        public void set_stereoTargetEye(){} // RVA: 0x7B5F2E0
        public void get_stereoTargetEyeInternal(){} // RVA: 0x7B5F240
        public void set_stereoTargetEyeInternal(){} // RVA: 0x7B5F4B0
        public void get_stereoActiveEye(){} // RVA: 0x7B5F560
        public void GetStereoNonJitteredProjectionMatrix(){} // RVA: 0x7B5F600
        public void GetStereoViewMatrix(){} // RVA: 0x7B5F6D0
        public void CopyStereoDeviceProjectionMatrixToNonJittered(){} // RVA: 0x7B5F7A0
        public void GetStereoProjectionMatrix(){} // RVA: 0x7B5F850
        public void SetStereoProjectionMatrix(){} // RVA: 0x7B5F920
        public void ResetStereoProjectionMatrices(){} // RVA: 0x7B5F9E0
        public void SetStereoViewMatrix(){} // RVA: 0x7B5FA80
        public void ResetStereoViewMatrices(){} // RVA: 0x7B5FB40
        public void GetAllCamerasCount(){} // RVA: 0x7B5FBE0
        public void GetAllCamerasImpl(){} // RVA: 0x7B5FC30
        public void get_allCamerasCount(){} // RVA: 0x7B5FBE0
        public void get_allCameras(){} // RVA: 0x7B5FCC0
        public void GetAllCameras(){} // RVA: 0x7B5FDD0
        public void RenderToCubemapImpl(){} // RVA: 0x7B5FF20
        public void RenderToCubemap(){} // RVA: 0x7B60220
        public void GetFilterMode(){} // RVA: 0x7B60030
        public void get_sceneViewFilterMode(){} // RVA: 0x7B60030
        public void get_renderCloudsInSceneView(){} // RVA: 0x7B600D0
        public void set_renderCloudsInSceneView(){} // RVA: 0x7B60170
        public void RenderToCubemapEyeImpl(){} // RVA: 0x7B60220
        public void Render(){} // RVA: 0x7B60320
        public void RenderWithShader(){} // RVA: 0x7B603C0
        public void RenderDontRestore(){} // RVA: 0x7B60580
        public void SubmitRenderRequests(){} // RVA: 0x7B60620
        public void SubmitRenderRequest(){} // RVA: 0xA94080
        public void SubmitRenderRequestsInternal(){} // RVA: 0x7B60800
        public void SubmitBuiltInObjectIDRenderRequest(){} // RVA: 0x7B608B0
        public void SetupCurrent(){} // RVA: 0x7B609C0
        public void CopyFrom(){} // RVA: 0x7B60A50
        public void get_commandBufferCount(){} // RVA: 0x7B60B30
        public void RemoveCommandBuffersImpl(){} // RVA: 0x7B60BD0
        public void RemoveAllCommandBuffersImpl(){} // RVA: 0x7B60C80
        public void RemoveCommandBuffers(){} // RVA: 0x7B60D20
        public void RemoveAllCommandBuffers(){} // RVA: 0x7B60E90
        public void AddCommandBufferImpl(){} // RVA: 0x7B60FF0
        public void AddCommandBufferAsyncImpl(){} // RVA: 0x7B61100
        public void RemoveCommandBufferImpl(){} // RVA: 0x7B61220
        public void AddCommandBuffer(){} // RVA: 0x7B61330
        public void AddCommandBufferAsync(){} // RVA: 0x7B615A0
        public void RemoveCommandBuffer(){} // RVA: 0x7B61820
        public void GetCommandBuffers(){} // RVA: 0x7B61A90
        public void GetCommandBuffersImpl(){} // RVA: 0x7B61C00
        public void FireOnPreCull(){} // RVA: 0x7B61CB0
        public void FireOnPreRender(){} // RVA: 0x7B61D10
        public void FireOnPostRender(){} // RVA: 0x7B61D70
        public void BumpNonSerializedVersion(){} // RVA: 0x7B61DD0
        public void OnlyUsedForTesting1(){} // RVA: 0xB43310
        public void OnlyUsedForTesting2(){} // RVA: 0xB43310
        public void TryGetCullingParameters(){} // RVA: 0x7B61E20
        public void GetCullingParameters_Internal(){} // RVA: 0x7B61E40
        public void get_nearClipPlane_Injected(){} // RVA: 0x7B61F00
        public void set_nearClipPlane_Injected(){} // RVA: 0x7B61F50
        public void get_farClipPlane_Injected(){} // RVA: 0x7B61FB0
        public void set_farClipPlane_Injected(){} // RVA: 0x7B62000
        public void get_fieldOfView_Injected(){} // RVA: 0x7B62060
        public void set_fieldOfView_Injected(){} // RVA: 0x7B620B0
        public void get_renderingPath_Injected(){} // RVA: 0x7B62110
        public void set_renderingPath_Injected(){} // RVA: 0x7B62160
        public void get_actualRenderingPath_Injected(){} // RVA: 0x7B621C0
        public void Reset_Injected(){} // RVA: 0x7B62210
        public void get_allowHDR_Injected(){} // RVA: 0x7B62260
        public void set_allowHDR_Injected(){} // RVA: 0x7B622B0
        public void get_allowMSAA_Injected(){} // RVA: 0x7B62310
        public void set_allowMSAA_Injected(){} // RVA: 0x7B62360
        public void get_allowDynamicResolution_Injected(){} // RVA: 0x7B623C0
        public void set_allowDynamicResolution_Injected(){} // RVA: 0x7B62410
        public void get_forceIntoRenderTexture_Injected(){} // RVA: 0x7B62470
        public void set_forceIntoRenderTexture_Injected(){} // RVA: 0x7B624C0
        public void get_orthographicSize_Injected(){} // RVA: 0x7B62520
        public void set_orthographicSize_Injected(){} // RVA: 0x7B62570
        public void get_orthographic_Injected(){} // RVA: 0x7B625D0
        public void set_orthographic_Injected(){} // RVA: 0x7B62620
        public void get_opaqueSortMode_Injected(){} // RVA: 0x7B62680
        public void set_opaqueSortMode_Injected(){} // RVA: 0x7B626D0
        public void get_transparencySortMode_Injected(){} // RVA: 0x7B62730
        public void set_transparencySortMode_Injected(){} // RVA: 0x7B62780
        public void get_transparencySortAxis_Injected(){} // RVA: 0x7B627E0
        public void set_transparencySortAxis_Injected(){} // RVA: 0x7B62840
        public void ResetTransparencySortSettings_Injected(){} // RVA: 0x7B628A0
        public void get_depth_Injected(){} // RVA: 0x7B628F0
        public void set_depth_Injected(){} // RVA: 0x7B62940
        public void get_aspect_Injected(){} // RVA: 0x7B629A0
        public void set_aspect_Injected(){} // RVA: 0x7B629F0
        public void ResetAspect_Injected(){} // RVA: 0x7B62A50
        public void get_velocity_Injected(){} // RVA: 0x7B62AA0
        public void get_cullingMask_Injected(){} // RVA: 0x7B62B00
        public void set_cullingMask_Injected(){} // RVA: 0x7B62B50
        public void get_eventMask_Injected(){} // RVA: 0x7B62BB0
        public void set_eventMask_Injected(){} // RVA: 0x7B62C00
        public void get_layerCullSphericalInternal_Injected(){} // RVA: 0x7B62C60
        public void set_layerCullSphericalInternal_Injected(){} // RVA: 0x7B62CB0
        public void get_cameraType_Injected(){} // RVA: 0x7B62D10
        public void set_cameraType_Injected(){} // RVA: 0x7B62D60
        public void get_skyboxMaterial_Injected(){} // RVA: 0x7B62DC0
        public void get_overrideSceneCullingMask_Injected(){} // RVA: 0x7B62E10
        public void set_overrideSceneCullingMask_Injected(){} // RVA: 0x7B62E60
        public void get_sceneCullingMask_Injected(){} // RVA: 0x7B62EC0
        public void get_useInteractiveLightBakingData_Injected(){} // RVA: 0x7B62F10
        public void set_useInteractiveLightBakingData_Injected(){} // RVA: 0x7B62F60
        public void GetLayerCullDistances_Injected(){} // RVA: 0x7B62FC0
        public void SetLayerCullDistances_Injected(){} // RVA: 0x7B63020
        public void get_useOcclusionCulling_Injected(){} // RVA: 0x7B63080
        public void set_useOcclusionCulling_Injected(){} // RVA: 0x7B630D0
        public void get_cullingMatrix_Injected(){} // RVA: 0x7B63130
        public void set_cullingMatrix_Injected(){} // RVA: 0x7B63190
        public void ResetCullingMatrix_Injected(){} // RVA: 0x7B631F0
        public void get_backgroundColor_Injected(){} // RVA: 0x7B63240
        public void set_backgroundColor_Injected(){} // RVA: 0x7B632A0
        public void get_clearFlags_Injected(){} // RVA: 0x7B63300
        public void set_clearFlags_Injected(){} // RVA: 0x7B63350
        public void get_depthTextureMode_Injected(){} // RVA: 0x7B633B0
        public void set_depthTextureMode_Injected(){} // RVA: 0x7B63400
        public void get_clearStencilAfterLightingPass_Injected(){} // RVA: 0x7B63460
        public void set_clearStencilAfterLightingPass_Injected(){} // RVA: 0x7B634B0
        public void SetReplacementShader_Injected(){} // RVA: 0x7B63510
        public void ResetReplacementShader_Injected(){} // RVA: 0x7B63580
        public void get_projectionMatrixMode_Injected(){} // RVA: 0x7B635D0
        public void get_usePhysicalProperties_Injected(){} // RVA: 0x7B63620
        public void set_usePhysicalProperties_Injected(){} // RVA: 0x7B63670
        public void get_iso_Injected(){} // RVA: 0x7B636D0
        public void set_iso_Injected(){} // RVA: 0x7B63720
        public void get_shutterSpeed_Injected(){} // RVA: 0x7B63780
        public void set_shutterSpeed_Injected(){} // RVA: 0x7B637D0
        public void get_aperture_Injected(){} // RVA: 0x7B63830
        public void set_aperture_Injected(){} // RVA: 0x7B63880
        public void get_focusDistance_Injected(){} // RVA: 0x7B638E0
        public void set_focusDistance_Injected(){} // RVA: 0x7B63930
        public void get_focalLength_Injected(){} // RVA: 0x7B63990
        public void set_focalLength_Injected(){} // RVA: 0x7B639E0
        public void get_bladeCount_Injected(){} // RVA: 0x7B63A40
        public void set_bladeCount_Injected(){} // RVA: 0x7B63A90
        public void get_curvature_Injected(){} // RVA: 0x7B63AF0
        public void set_curvature_Injected(){} // RVA: 0x7B63B50
        public void get_barrelClipping_Injected(){} // RVA: 0x7B63BB0
        public void set_barrelClipping_Injected(){} // RVA: 0x7B63C00
        public void get_anamorphism_Injected(){} // RVA: 0x7B63C60
        public void set_anamorphism_Injected(){} // RVA: 0x7B63CB0
        public void get_sensorSize_Injected(){} // RVA: 0x7B63D10
        public void set_sensorSize_Injected(){} // RVA: 0x7B63D70
        public void get_lensShift_Injected(){} // RVA: 0x7B63DD0
        public void set_lensShift_Injected(){} // RVA: 0x7B63E30
        public void get_gateFit_Injected(){} // RVA: 0x7B63E90
        public void set_gateFit_Injected(){} // RVA: 0x7B63EE0
        public void GetGateFittedFieldOfView_Injected(){} // RVA: 0x7B63F40
        public void GetGateFittedLensShift_Injected(){} // RVA: 0x7B63F90
        public void GetLocalSpaceAim_Injected(){} // RVA: 0x7B63FF0
        public void get_rect_Injected(){} // RVA: 0x7B64050
        public void set_rect_Injected(){} // RVA: 0x7B640B0
        public void get_pixelRect_Injected(){} // RVA: 0x7B64110
        public void set_pixelRect_Injected(){} // RVA: 0x7B64170
        public void get_pixelWidth_Injected(){} // RVA: 0x7B641D0
        public void get_pixelHeight_Injected(){} // RVA: 0x7B64220
        public void get_scaledPixelWidth_Injected(){} // RVA: 0x7B64270
        public void get_scaledPixelHeight_Injected(){} // RVA: 0x7B642C0
        public void get_targetTexture_Injected(){} // RVA: 0x7B64310
        public void set_targetTexture_Injected(){} // RVA: 0x7B64360
        public void get_activeTexture_Injected(){} // RVA: 0x7B643C0
        public void get_targetDisplay_Injected(){} // RVA: 0x7B64410
        public void set_targetDisplay_Injected(){} // RVA: 0x7B64460
        public void SetTargetBuffersImpl_Injected(){} // RVA: 0x7B644C0
        public void SetTargetBuffersMRTImpl_Injected(){} // RVA: 0x7B64530
        public void GetCameraBufferWarnings_Injected(){} // RVA: 0x7B645A0
        public void get_cameraToWorldMatrix_Injected(){} // RVA: 0x7B645F0
        public void get_worldToCameraMatrix_Injected(){} // RVA: 0x7B64650
        public void set_worldToCameraMatrix_Injected(){} // RVA: 0x7B646B0
        public void get_projectionMatrix_Injected(){} // RVA: 0x7B64710
        public void set_projectionMatrix_Injected(){} // RVA: 0x7B64770
        public void get_nonJitteredProjectionMatrix_Injected(){} // RVA: 0x7B647D0
        public void set_nonJitteredProjectionMatrix_Injected(){} // RVA: 0x7B64830
        public void get_useJitteredProjectionMatrixForTransparentRendering_Injected(){} // RVA: 0x7B64890
        public void set_useJitteredProjectionMatrixForTransparentRendering_Injected(){} // RVA: 0x7B648E0
        public void get_previousViewProjectionMatrix_Injected(){} // RVA: 0x7B64940
        public void ResetWorldToCameraMatrix_Injected(){} // RVA: 0x7B649A0
        public void ResetProjectionMatrix_Injected(){} // RVA: 0x7B649F0
        public void CalculateObliqueMatrix_Injected(){} // RVA: 0x7B64A40
        public void WorldToScreenPoint_Injected(){} // RVA: 0x7B64AB0
        public void WorldToViewportPoint_Injected(){} // RVA: 0x7B64B30
        public void ViewportToWorldPoint_Injected(){} // RVA: 0x7B64BB0
        public void ScreenToWorldPoint_Injected(){} // RVA: 0x7B64C30
        public void ScreenToViewportPoint_Injected(){} // RVA: 0x7B64CB0
        public void ViewportToScreenPoint_Injected(){} // RVA: 0x7B64D20
        public void GetFrustumPlaneSizeAt_Injected(){} // RVA: 0x7B64D90
        public void ViewportPointToRay_Injected(){} // RVA: 0x7B64E00
        public void ScreenPointToRay_Injected(){} // RVA: 0x7B64E80
        public void CalculateFrustumCornersInternal_Injected(){} // RVA: 0x7B64F00
        public void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(){} // RVA: 0x7B64F90
        public void get_main_Injected(){} // RVA: 0x7B65020
        public void get_currentInternal_Injected(){} // RVA: 0x7B65070
        public void get_scene_Injected(){} // RVA: 0x7B650C0
        public void set_scene_Injected(){} // RVA: 0x7B65120
        public void get_stereoEnabled_Injected(){} // RVA: 0x7B65180
        public void get_stereoSeparation_Injected(){} // RVA: 0x7B651D0
        public void set_stereoSeparation_Injected(){} // RVA: 0x7B65220
        public void get_stereoConvergence_Injected(){} // RVA: 0x7B65280
        public void set_stereoConvergence_Injected(){} // RVA: 0x7B652D0
        public void get_areVRStereoViewMatricesWithinSingleCullTolerance_Injected(){} // RVA: 0x7B65330
        public void get_stereoTargetEyeInternal_Injected(){} // RVA: 0x7B65380
        public void set_stereoTargetEyeInternal_Injected(){} // RVA: 0x7B653D0
        public void get_stereoActiveEye_Injected(){} // RVA: 0x7B65430
        public void GetStereoNonJitteredProjectionMatrix_Injected(){} // RVA: 0x7B65480
        public void GetStereoViewMatrix_Injected(){} // RVA: 0x7B654F0
        public void CopyStereoDeviceProjectionMatrixToNonJittered_Injected(){} // RVA: 0x7B65560
        public void GetStereoProjectionMatrix_Injected(){} // RVA: 0x7B655C0
        public void SetStereoProjectionMatrix_Injected(){} // RVA: 0x7B65630
        public void ResetStereoProjectionMatrices_Injected(){} // RVA: 0x7B656A0
        public void SetStereoViewMatrix_Injected(){} // RVA: 0x7B656F0
        public void ResetStereoViewMatrices_Injected(){} // RVA: 0x7B65760
        public void GetAllCamerasImpl_Injected(){} // RVA: 0x7B657B0
        public void RenderToCubemapImpl_Injected(){} // RVA: 0x7B65800
        public void GetFilterMode_Injected(){} // RVA: 0x7B65870
        public void get_renderCloudsInSceneView_Injected(){} // RVA: 0x7B658C0
        public void set_renderCloudsInSceneView_Injected(){} // RVA: 0x7B65910
        public void RenderToCubemapEyeImpl_Injected(){} // RVA: 0x7B65970
        public void Render_Injected(){} // RVA: 0x7B659F0
        public void RenderWithShader_Injected(){} // RVA: 0x7B65A40
        public void RenderDontRestore_Injected(){} // RVA: 0x7B65AB0
        public void SubmitRenderRequestsInternal_Injected(){} // RVA: 0x7B65B00
        public void SubmitBuiltInObjectIDRenderRequest_Injected(){} // RVA: 0x7B65B60
        public void SetupCurrent_Injected(){} // RVA: 0x7B65BF0
        public void CopyFrom_Injected(){} // RVA: 0x7B65C40
        public void get_commandBufferCount_Injected(){} // RVA: 0x7B65CA0
        public void RemoveCommandBuffersImpl_Injected(){} // RVA: 0x7B65CF0
        public void RemoveAllCommandBuffersImpl_Injected(){} // RVA: 0x7B65D50
        public void AddCommandBufferImpl_Injected(){} // RVA: 0x7B65DA0
        public void AddCommandBufferAsyncImpl_Injected(){} // RVA: 0x7B65E10
        public void RemoveCommandBufferImpl_Injected(){} // RVA: 0x7B65E90
        public void GetCommandBuffersImpl_Injected(){} // RVA: 0x7B65F00
        public void GetCullingParameters_Internal_Injected(){} // RVA: 0x7B65F60
    }

    public class CameraRaycastHelper : Object
    {
        // ── Methods ──
        public void RaycastTry(){} // RVA: 0x7CA9160
        public void RaycastTry2D(){} // RVA: 0x7CA9240
        public void RaycastTry_Injected(){} // RVA: 0x7CA9320
        public void RaycastTry2D_Injected(){} // RVA: 0x7CA93A0
    }

    public class Camera[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Canvas : Behaviour
    {
        // ── Methods ──
        public void add_preWillRenderCanvases(){} // RVA: 0x80CB6B0
        public void remove_preWillRenderCanvases(){} // RVA: 0x80CB7C0
        public void add_willRenderCanvases(){} // RVA: 0x80CB8D0
        public void remove_willRenderCanvases(){} // RVA: 0x80CB9E0
        public void get_renderMode(){} // RVA: 0x80CBAF0
        public void set_renderMode(){} // RVA: 0x80CBB90
        public void get_isRootCanvas(){} // RVA: 0x80CBC40
        public void get_pixelRect(){} // RVA: 0x80CBCE0
        public void get_scaleFactor(){} // RVA: 0x80CBDA0
        public void set_scaleFactor(){} // RVA: 0x80CBE40
        public void get_referencePixelsPerUnit(){} // RVA: 0x80CBEF0
        public void set_referencePixelsPerUnit(){} // RVA: 0x80CBF90
        public void get_overridePixelPerfect(){} // RVA: 0x80CC040
        public void set_overridePixelPerfect(){} // RVA: 0x80CC0E0
        public void get_vertexColorAlwaysGammaSpace(){} // RVA: 0x80CC190
        public void set_vertexColorAlwaysGammaSpace(){} // RVA: 0x80CC230
        public void get_pixelPerfect(){} // RVA: 0x80CC2E0
        public void set_pixelPerfect(){} // RVA: 0x80CC380
        public void get_planeDistance(){} // RVA: 0x80CC430
        public void set_planeDistance(){} // RVA: 0x80CC4D0
        public void get_renderOrder(){} // RVA: 0x80CC580
        public void get_overrideSorting(){} // RVA: 0x80CC620
        public void set_overrideSorting(){} // RVA: 0x80CC6C0
        public void get_sortingOrder(){} // RVA: 0x80CC770
        public void set_sortingOrder(){} // RVA: 0x80CC810
        public void get_targetDisplay(){} // RVA: 0x80CC8C0
        public void set_targetDisplay(){} // RVA: 0x80CC960
        public void get_sortingLayerID(){} // RVA: 0x80CCA10
        public void set_sortingLayerID(){} // RVA: 0x80CCAB0
        public void get_cachedSortingLayerValue(){} // RVA: 0x80CCB60
        public void get_additionalShaderChannels(){} // RVA: 0x80CCC00
        public void set_additionalShaderChannels(){} // RVA: 0x80CCCA0
        public void get_sortingLayerName(){} // RVA: 0x80CCD50
        public void set_sortingLayerName(){} // RVA: 0x80CCE80
        public void get_rootCanvas(){} // RVA: 0x80CD010
        public void get_renderingDisplaySize(){} // RVA: 0x80CD0D0
        public void get_updateRectTransformForStandalone(){} // RVA: 0x80CD180
        public void set_updateRectTransformForStandalone(){} // RVA: 0x80CD220
        public void get_externBeginRenderOverlays(){} // RVA: 0x80CD2D0
        public void set_externBeginRenderOverlays(){} // RVA: 0x80CD310
        public void get_externRenderOverlaysBefore(){} // RVA: 0x80CD3B0
        public void set_externRenderOverlaysBefore(){} // RVA: 0x80CD3F0
        public void get_externEndRenderOverlays(){} // RVA: 0x80CD490
        public void set_externEndRenderOverlays(){} // RVA: 0x80CD4D0
        public void SetExternalCanvasEnabled(){} // RVA: 0x80CD570
        public void get_worldCamera(){} // RVA: 0x80CD5C0
        public void set_worldCamera(){} // RVA: 0x80CD680
        public void get_normalizedSortingGridSize(){} // RVA: 0x80CD760
        public void set_normalizedSortingGridSize(){} // RVA: 0x80CD800
        public void get_sortingGridNormalizedSize(){} // RVA: 0x80CD8B0
        public void set_sortingGridNormalizedSize(){} // RVA: 0x80CD950
        public void GetDefaultCanvasTextMaterial(){} // RVA: 0x80CDA00
        public void GetDefaultCanvasMaterial(){} // RVA: 0x80CDA80
        public void GetETC1SupportedCanvasMaterial(){} // RVA: 0x80CDB00
        public void UpdateCanvasRectTransform(){} // RVA: 0x80CDB80
        public void ForceUpdateCanvases(){} // RVA: 0x80CDC30
        public void SendPreWillRenderCanvases(){} // RVA: 0x80CDCD0
        public void SendWillRenderCanvases(){} // RVA: 0x80CDD30
        public void BeginRenderExtraOverlays(){} // RVA: 0x80CDD90
        public void RenderExtraOverlaysBefore(){} // RVA: 0x80CDDF0
        public void EndRenderExtraOverlays(){} // RVA: 0x80CDE60
        public void .ctor(){} // RVA: 0xB43D60
        public void get_renderMode_Injected(){} // RVA: 0x80CDEC0
        public void set_renderMode_Injected(){} // RVA: 0x80CDF10
        public void get_isRootCanvas_Injected(){} // RVA: 0x80CDF70
        public void get_pixelRect_Injected(){} // RVA: 0x80CDFC0
        public void get_scaleFactor_Injected(){} // RVA: 0x80CE020
        public void set_scaleFactor_Injected(){} // RVA: 0x80CE070
        public void get_referencePixelsPerUnit_Injected(){} // RVA: 0x80CE0D0
        public void set_referencePixelsPerUnit_Injected(){} // RVA: 0x80CE120
        public void get_overridePixelPerfect_Injected(){} // RVA: 0x80CE180
        public void set_overridePixelPerfect_Injected(){} // RVA: 0x80CE1D0
        public void get_vertexColorAlwaysGammaSpace_Injected(){} // RVA: 0x80CE230
        public void set_vertexColorAlwaysGammaSpace_Injected(){} // RVA: 0x80CE280
        public void get_pixelPerfect_Injected(){} // RVA: 0x80CE2E0
        public void set_pixelPerfect_Injected(){} // RVA: 0x80CE330
        public void get_planeDistance_Injected(){} // RVA: 0x80CE390
        public void set_planeDistance_Injected(){} // RVA: 0x80CE3E0
        public void get_renderOrder_Injected(){} // RVA: 0x80CE440
        public void get_overrideSorting_Injected(){} // RVA: 0x80CE490
        public void set_overrideSorting_Injected(){} // RVA: 0x80CE4E0
        public void get_sortingOrder_Injected(){} // RVA: 0x80CE540
        public void set_sortingOrder_Injected(){} // RVA: 0x80CE590
        public void get_targetDisplay_Injected(){} // RVA: 0x80CE5F0
        public void set_targetDisplay_Injected(){} // RVA: 0x80CE640
        public void get_sortingLayerID_Injected(){} // RVA: 0x80CE6A0
        public void set_sortingLayerID_Injected(){} // RVA: 0x80CE6F0
        public void get_cachedSortingLayerValue_Injected(){} // RVA: 0x80CE750
        public void get_additionalShaderChannels_Injected(){} // RVA: 0x80CE7A0
        public void set_additionalShaderChannels_Injected(){} // RVA: 0x80CE7F0
        public void get_sortingLayerName_Injected(){} // RVA: 0x80CE850
        public void set_sortingLayerName_Injected(){} // RVA: 0x80CE8B0
        public void get_rootCanvas_Injected(){} // RVA: 0x80CE910
        public void get_renderingDisplaySize_Injected(){} // RVA: 0x80CE960
        public void get_updateRectTransformForStandalone_Injected(){} // RVA: 0x80CE9C0
        public void set_updateRectTransformForStandalone_Injected(){} // RVA: 0x80CEA10
        public void get_worldCamera_Injected(){} // RVA: 0x80CEA70
        public void set_worldCamera_Injected(){} // RVA: 0x80CEAC0
        public void get_normalizedSortingGridSize_Injected(){} // RVA: 0x80CEB20
        public void set_normalizedSortingGridSize_Injected(){} // RVA: 0x80CEB70
        public void get_sortingGridNormalizedSize_Injected(){} // RVA: 0x80CEBD0
        public void set_sortingGridNormalizedSize_Injected(){} // RVA: 0x80CEC20
        public void GetDefaultCanvasTextMaterial_Injected(){} // RVA: 0x80CEC80
        public void GetDefaultCanvasMaterial_Injected(){} // RVA: 0x80CECD0
        public void GetETC1SupportedCanvasMaterial_Injected(){} // RVA: 0x80CED20
        public void UpdateCanvasRectTransform_Injected(){} // RVA: 0x80CED70
    }

    public class CanvasGroup : Behaviour
    {
        // ── Methods ──
        public void get_alpha(){} // RVA: 0x80C5250
        public void set_alpha(){} // RVA: 0x80C52F0
        public void get_interactable(){} // RVA: 0x80C53A0
        public void set_interactable(){} // RVA: 0x80C5440
        public void get_blocksRaycasts(){} // RVA: 0x80C54F0
        public void set_blocksRaycasts(){} // RVA: 0x80C5590
        public void get_ignoreParentGroups(){} // RVA: 0x80C5640
        public void set_ignoreParentGroups(){} // RVA: 0x80C56E0
        public void IsRaycastLocationValid(){} // RVA: 0x80C54F0
        public void .ctor(){} // RVA: 0xB43D60
        public void get_alpha_Injected(){} // RVA: 0x80C5790
        public void set_alpha_Injected(){} // RVA: 0x80C57E0
        public void get_interactable_Injected(){} // RVA: 0x80C5840
        public void set_interactable_Injected(){} // RVA: 0x80C5890
        public void get_blocksRaycasts_Injected(){} // RVA: 0x80C58F0
        public void set_blocksRaycasts_Injected(){} // RVA: 0x80C5940
        public void get_ignoreParentGroups_Injected(){} // RVA: 0x80C59A0
        public void set_ignoreParentGroups_Injected(){} // RVA: 0x80C59F0
    }

    public class CanvasGroup[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CanvasRenderer : Component
    {
        // ── Methods ──
        public void get_hasPopInstruction(){} // RVA: 0x80C5A50
        public void set_hasPopInstruction(){} // RVA: 0x80C5AF0
        public void get_materialCount(){} // RVA: 0x80C5BA0
        public void set_materialCount(){} // RVA: 0x80C5C40
        public void get_popMaterialCount(){} // RVA: 0x80C5CF0
        public void set_popMaterialCount(){} // RVA: 0x80C5D90
        public void get_absoluteDepth(){} // RVA: 0x80C5E40
        public void get_hasMoved(){} // RVA: 0x80C5EE0
        public void get_cullTransparentMesh(){} // RVA: 0x80C5F80
        public void set_cullTransparentMesh(){} // RVA: 0x80C6020
        public void get_hasRectClipping(){} // RVA: 0x80C60D0
        public void get_relativeDepth(){} // RVA: 0x80C6170
        public void get_cull(){} // RVA: 0x80C6210
        public void set_cull(){} // RVA: 0x80C62B0
        public void get_isMask(){} // RVA: 0xB5DD50
        public void set_isMask(){} // RVA: 0xB5DD60
        public void SetColor(){} // RVA: 0x80C6360
        public void GetColor(){} // RVA: 0x80C6410
        public void EnableRectClipping(){} // RVA: 0x80C64D0
        public void get_clippingSoftness(){} // RVA: 0x80C6580
        public void set_clippingSoftness(){} // RVA: 0x80C6630
        public void DisableRectClipping(){} // RVA: 0x80C66E0
        public void SetMaterial(){} // RVA: 0x80C71C0
        public void GetMaterial(){} // RVA: 0x80C72F0
        public void SetPopMaterial(){} // RVA: 0x80C6940
        public void GetPopMaterial(){} // RVA: 0x80C6A30
        public void SetTexture(){} // RVA: 0x80C6B00
        public void SetAlphaTexture(){} // RVA: 0x80C6BE0
        public void SetMesh(){} // RVA: 0x80C6CC0
        public void GetMesh(){} // RVA: 0x80C6DA0
        public void Clear(){} // RVA: 0x80C6E60
        public void GetAlpha(){} // RVA: 0x80C6F00
        public void SetAlpha(){} // RVA: 0x80C6FB0
        public void GetInheritedAlpha(){} // RVA: 0x80C7120
        public void SplitUIVertexStreams(){} // RVA: 0x80C7410
        public void CreateUIVertexStream(){} // RVA: 0x80C7660
        public void AddUIVertexStream(){} // RVA: 0x80C7820
        public void SetVertices(){} // RVA: 0x80C79F0
        public void SplitIndicesStreamsInternal(){} // RVA: 0x80C8440
        public void SplitUIVertexStreamsInternal(){} // RVA: 0x80C7820
        public void CreateUIVertexStreamInternal(){} // RVA: 0x80C7660
        public void .ctor(){} // RVA: 0xB43D60
        public void get_hasPopInstruction_Injected(){} // RVA: 0x80C84A0
        public void set_hasPopInstruction_Injected(){} // RVA: 0x80C84F0
        public void get_materialCount_Injected(){} // RVA: 0x80C8550
        public void set_materialCount_Injected(){} // RVA: 0x80C85A0
        public void get_popMaterialCount_Injected(){} // RVA: 0x80C8600
        public void set_popMaterialCount_Injected(){} // RVA: 0x80C8650
        public void get_absoluteDepth_Injected(){} // RVA: 0x80C86B0
        public void get_hasMoved_Injected(){} // RVA: 0x80C8700
        public void get_cullTransparentMesh_Injected(){} // RVA: 0x80C8750
        public void set_cullTransparentMesh_Injected(){} // RVA: 0x80C87A0
        public void get_hasRectClipping_Injected(){} // RVA: 0x80C8800
        public void get_relativeDepth_Injected(){} // RVA: 0x80C8850
        public void get_cull_Injected(){} // RVA: 0x80C88A0
        public void set_cull_Injected(){} // RVA: 0x80C88F0
        public void SetColor_Injected(){} // RVA: 0x80C8950
        public void GetColor_Injected(){} // RVA: 0x80C89B0
        public void EnableRectClipping_Injected(){} // RVA: 0x80C8A10
        public void get_clippingSoftness_Injected(){} // RVA: 0x80C8A70
        public void set_clippingSoftness_Injected(){} // RVA: 0x80C8AD0
        public void DisableRectClipping_Injected(){} // RVA: 0x80C8B30
        public void SetMaterial_Injected(){} // RVA: 0x80C8B80
        public void GetMaterial_Injected(){} // RVA: 0x80C8BF0
        public void SetPopMaterial_Injected(){} // RVA: 0x80C8C50
        public void GetPopMaterial_Injected(){} // RVA: 0x80C8CC0
        public void SetTexture_Injected(){} // RVA: 0x80C8D20
        public void SetAlphaTexture_Injected(){} // RVA: 0x80C8D80
        public void SetMesh_Injected(){} // RVA: 0x80C8DE0
        public void GetMesh_Injected(){} // RVA: 0x80C8E40
        public void Clear_Injected(){} // RVA: 0x80C8E90
        public void GetInheritedAlpha_Injected(){} // RVA: 0x80C8EE0
    }

    public class Canvas[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CapsuleCollider : Collider
    {
        // ── Methods ──
        public void get_center(){} // RVA: 0x7D182B0
        public void set_center(){} // RVA: 0x7D18370
        public void get_radius(){} // RVA: 0x7D18420
        public void set_radius(){} // RVA: 0x7D184C0
        public void get_height(){} // RVA: 0x7D18570
        public void set_height(){} // RVA: 0x7D18610
        public void get_direction(){} // RVA: 0x7D186C0
        public void set_direction(){} // RVA: 0x7D18760
        public void .ctor(){} // RVA: 0xB43D60
        public void get_center_Injected(){} // RVA: 0x7D18810
        public void set_center_Injected(){} // RVA: 0x7D18870
        public void get_radius_Injected(){} // RVA: 0x7D188D0
        public void set_radius_Injected(){} // RVA: 0x7D18920
        public void get_height_Injected(){} // RVA: 0x7D18980
        public void set_height_Injected(){} // RVA: 0x7D189D0
        public void get_direction_Injected(){} // RVA: 0x7D18A30
        public void set_direction_Injected(){} // RVA: 0x7D18A80
    }

    public class CapsuleCollider2D : Collider2D
    {
        // ── Methods ──
        public void get_size(){} // RVA: 0x7D064F0
        public void set_size(){} // RVA: 0x7D065A0
        public void get_direction(){} // RVA: 0x7D06650
        public void set_direction(){} // RVA: 0x7D066F0
        public void .ctor(){} // RVA: 0xB43D60
        public void get_size_Injected(){} // RVA: 0x7D067A0
        public void set_size_Injected(){} // RVA: 0x7D06800
        public void get_direction_Injected(){} // RVA: 0x7D06860
        public void set_direction_Injected(){} // RVA: 0x7D068B0
    }

    public class CharacterController : Collider
    {
        // ── Methods ──
        public void SimpleMove(){} // RVA: 0x7D18BB0
        public void Move(){} // RVA: 0x7D18C60
        public void get_velocity(){} // RVA: 0x7D18D10
        public void get_isGrounded(){} // RVA: 0x7D18DD0
        public void get_collisionFlags(){} // RVA: 0x7D18E70
        public void get_radius(){} // RVA: 0x7D18F10
        public void set_radius(){} // RVA: 0x7D18FB0
        public void get_height(){} // RVA: 0x7D19060
        public void set_height(){} // RVA: 0x7D19100
        public void get_center(){} // RVA: 0x7D191B0
        public void set_center(){} // RVA: 0x7D19270
        public void get_slopeLimit(){} // RVA: 0x7D19320
        public void set_slopeLimit(){} // RVA: 0x7D193C0
        public void get_stepOffset(){} // RVA: 0x7D19470
        public void set_stepOffset(){} // RVA: 0x7D19510
        public void get_skinWidth(){} // RVA: 0x7D195C0
        public void set_skinWidth(){} // RVA: 0x7D19660
        public void get_minMoveDistance(){} // RVA: 0x7D19710
        public void set_minMoveDistance(){} // RVA: 0x7D197B0
        public void get_detectCollisions(){} // RVA: 0x7D19860
        public void set_detectCollisions(){} // RVA: 0x7D19900
        public void get_enableOverlapRecovery(){} // RVA: 0x7D199B0
        public void set_enableOverlapRecovery(){} // RVA: 0x7D19A50
        public void get_isSupported(){} // RVA: 0x7D19B00
        public void .ctor(){} // RVA: 0xB43D60
        public void SimpleMove_Injected(){} // RVA: 0x7D19BA0
        public void Move_Injected(){} // RVA: 0x7D19C00
        public void get_velocity_Injected(){} // RVA: 0x7D19C60
        public void get_isGrounded_Injected(){} // RVA: 0x7D19CC0
        public void get_collisionFlags_Injected(){} // RVA: 0x7D19D10
        public void get_radius_Injected(){} // RVA: 0x7D19D60
        public void set_radius_Injected(){} // RVA: 0x7D19DB0
        public void get_height_Injected(){} // RVA: 0x7D19E10
        public void set_height_Injected(){} // RVA: 0x7D19E60
        public void get_center_Injected(){} // RVA: 0x7D19EC0
        public void set_center_Injected(){} // RVA: 0x7D19F20
        public void get_slopeLimit_Injected(){} // RVA: 0x7D19F80
        public void set_slopeLimit_Injected(){} // RVA: 0x7D19FD0
        public void get_stepOffset_Injected(){} // RVA: 0x7D1A030
        public void set_stepOffset_Injected(){} // RVA: 0x7D1A080
        public void get_skinWidth_Injected(){} // RVA: 0x7D1A0E0
        public void set_skinWidth_Injected(){} // RVA: 0x7D1A130
        public void get_minMoveDistance_Injected(){} // RVA: 0x7D1A190
        public void set_minMoveDistance_Injected(){} // RVA: 0x7D1A1E0
        public void get_detectCollisions_Injected(){} // RVA: 0x7D1A240
        public void set_detectCollisions_Injected(){} // RVA: 0x7D1A290
        public void get_enableOverlapRecovery_Injected(){} // RVA: 0x7D1A2F0
        public void set_enableOverlapRecovery_Injected(){} // RVA: 0x7D1A340
        public void get_isSupported_Injected(){} // RVA: 0x7D1A3A0
    }

    public class CharacterJoint : Joint
    {
        // ── Methods ──
        public void get_swingAxis(){} // RVA: 0x7D1A3F0
        public void set_swingAxis(){} // RVA: 0x7D1A4B0
        public void get_twistLimitSpring(){} // RVA: 0x7D1A560
        public void set_twistLimitSpring(){} // RVA: 0x7D1A610
        public void get_swingLimitSpring(){} // RVA: 0x7D1A6C0
        public void set_swingLimitSpring(){} // RVA: 0x7D1A770
        public void get_lowTwistLimit(){} // RVA: 0x7D1A820
        public void set_lowTwistLimit(){} // RVA: 0x7D1A8E0
        public void get_highTwistLimit(){} // RVA: 0x7D1A990
        public void set_highTwistLimit(){} // RVA: 0x7D1AA50
        public void get_swing1Limit(){} // RVA: 0x7D1AB00
        public void set_swing1Limit(){} // RVA: 0x7D1ABC0
        public void get_swing2Limit(){} // RVA: 0x7D1AC70
        public void set_swing2Limit(){} // RVA: 0x7D1AD30
        public void get_enableProjection(){} // RVA: 0x7D1ADE0
        public void set_enableProjection(){} // RVA: 0x7D1AE80
        public void get_projectionDistance(){} // RVA: 0x7D1AF30
        public void set_projectionDistance(){} // RVA: 0x7D1AFD0
        public void get_projectionAngle(){} // RVA: 0x7D1B080
        public void set_projectionAngle(){} // RVA: 0x7D1B120
        public void .ctor(){} // RVA: 0xB43D60
        public void get_swingAxis_Injected(){} // RVA: 0x7D1B1D0
        public void set_swingAxis_Injected(){} // RVA: 0x7D1B230
        public void get_twistLimitSpring_Injected(){} // RVA: 0x7D1B290
        public void set_twistLimitSpring_Injected(){} // RVA: 0x7D1B2F0
        public void get_swingLimitSpring_Injected(){} // RVA: 0x7D1B350
        public void set_swingLimitSpring_Injected(){} // RVA: 0x7D1B3B0
        public void get_lowTwistLimit_Injected(){} // RVA: 0x7D1B410
        public void set_lowTwistLimit_Injected(){} // RVA: 0x7D1B470
        public void get_highTwistLimit_Injected(){} // RVA: 0x7D1B4D0
        public void set_highTwistLimit_Injected(){} // RVA: 0x7D1B530
        public void get_swing1Limit_Injected(){} // RVA: 0x7D1B590
        public void set_swing1Limit_Injected(){} // RVA: 0x7D1B5F0
        public void get_swing2Limit_Injected(){} // RVA: 0x7D1B650
        public void set_swing2Limit_Injected(){} // RVA: 0x7D1B6B0
        public void get_enableProjection_Injected(){} // RVA: 0x7D1B710
        public void set_enableProjection_Injected(){} // RVA: 0x7D1B760
        public void get_projectionDistance_Injected(){} // RVA: 0x7D1B7C0
        public void set_projectionDistance_Injected(){} // RVA: 0x7D1B810
        public void get_projectionAngle_Injected(){} // RVA: 0x7D1B870
        public void set_projectionAngle_Injected(){} // RVA: 0x7D1B8C0
    }

    public class CircleCollider2D : Collider2D
    {
        // ── Methods ──
        public void get_radius(){} // RVA: 0x7D062F0
        public void set_radius(){} // RVA: 0x7D06390
        public void .ctor(){} // RVA: 0xB43D60
        public void get_radius_Injected(){} // RVA: 0x7D06440
        public void set_radius_Injected(){} // RVA: 0x7D06490
    }

    public class ClassLibraryInitializer : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7BF9E60
    }

    public class ClassLibraryInitializer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Cloth : Component
    {
        // ── Methods ──
        public void get_vertices(){} // RVA: 0x7B42F00
        public void get_normals(){} // RVA: 0x7B43040
        public void get_coefficients(){} // RVA: 0x7B43180
        public void set_coefficients(){} // RVA: 0x7B43400
        public void get_capsuleColliders(){} // RVA: 0x7B43520
        public void set_capsuleColliders(){} // RVA: 0x7B435C0
        public void get_sphereColliders(){} // RVA: 0x7B43670
        public void set_sphereColliders(){} // RVA: 0x7B43710
        public void get_sleepThreshold(){} // RVA: 0x7B437C0
        public void set_sleepThreshold(){} // RVA: 0x7B43860
        public void get_bendingStiffness(){} // RVA: 0x7B43910
        public void set_bendingStiffness(){} // RVA: 0x7B439B0
        public void get_stretchingStiffness(){} // RVA: 0x7B43A60
        public void set_stretchingStiffness(){} // RVA: 0x7B43B00
        public void get_damping(){} // RVA: 0x7B43BB0
        public void set_damping(){} // RVA: 0x7B43C50
        public void get_externalAcceleration(){} // RVA: 0x7B43D00
        public void set_externalAcceleration(){} // RVA: 0x7B43DC0
        public void get_randomAcceleration(){} // RVA: 0x7B43E70
        public void set_randomAcceleration(){} // RVA: 0x7B43F30
        public void get_useGravity(){} // RVA: 0x7B43FE0
        public void set_useGravity(){} // RVA: 0x7B44080
        public void get_enabled(){} // RVA: 0x7B44130
        public void set_enabled(){} // RVA: 0x7B441D0
        public void get_friction(){} // RVA: 0x7B44280
        public void set_friction(){} // RVA: 0x7B44320
        public void get_collisionMassScale(){} // RVA: 0x7B443D0
        public void set_collisionMassScale(){} // RVA: 0x7B44470
        public void get_enableContinuousCollision(){} // RVA: 0x7B44520
        public void set_enableContinuousCollision(){} // RVA: 0x7B445C0
        public void get_useVirtualParticles(){} // RVA: 0x7B44670
        public void set_useVirtualParticles(){} // RVA: 0x7B44710
        public void get_worldVelocityScale(){} // RVA: 0x7B447C0
        public void set_worldVelocityScale(){} // RVA: 0x7B44860
        public void get_worldAccelerationScale(){} // RVA: 0x7B44910
        public void set_worldAccelerationScale(){} // RVA: 0x7B449B0
        public void get_clothSolverFrequency(){} // RVA: 0x7B44A60
        public void set_clothSolverFrequency(){} // RVA: 0x7B44B00
        public void get_solverFrequency(){} // RVA: 0x7B44BB0
        public void set_solverFrequency(){} // RVA: 0x7B44C60
        public void get_useTethers(){} // RVA: 0x7B44C90
        public void set_useTethers(){} // RVA: 0x7B44D30
        public void get_stiffnessFrequency(){} // RVA: 0x7B44DE0
        public void set_stiffnessFrequency(){} // RVA: 0x7B44E80
        public void get_selfCollisionDistance(){} // RVA: 0x7B44F30
        public void set_selfCollisionDistance(){} // RVA: 0x7B44FD0
        public void get_selfCollisionStiffness(){} // RVA: 0x7B45080
        public void set_selfCollisionStiffness(){} // RVA: 0x7B45120
        public void ClearTransformMotion(){} // RVA: 0x7B451D0
        public void GetSelfAndInterCollisionIndices(){} // RVA: 0x7B45270
        public void SetSelfAndInterCollisionIndices(){} // RVA: 0x7B45480
        public void GetVirtualParticleIndices(){} // RVA: 0x7B45690
        public void SetVirtualParticleIndices(){} // RVA: 0x7B458A0
        public void GetVirtualParticleWeights(){} // RVA: 0x7B45AB0
        public void SetVirtualParticleWeights(){} // RVA: 0x7B45CC0
        public void get_useContinuousCollision(){} // RVA: 0xB47B50
        public void set_useContinuousCollision(){} // RVA: 0xB5DD40
        public void get_selfCollision(){} // RVA: 0xB5DC00
        public void SetEnabledFading(){} // RVA: 0x7B45F90
        public void Raycast(){} // RVA: 0x7B46050
        public void .ctor(){} // RVA: 0xB43D60
        public void get_vertices_Injected(){} // RVA: 0x7B46140
        public void get_normals_Injected(){} // RVA: 0x7B461A0
        public void get_coefficients_Injected(){} // RVA: 0x7B46200
        public void set_coefficients_Injected(){} // RVA: 0x7B46260
        public void get_capsuleColliders_Injected(){} // RVA: 0x7B462C0
        public void set_capsuleColliders_Injected(){} // RVA: 0x7B46310
        public void get_sphereColliders_Injected(){} // RVA: 0x7B46370
        public void set_sphereColliders_Injected(){} // RVA: 0x7B463C0
        public void get_sleepThreshold_Injected(){} // RVA: 0x7B46420
        public void set_sleepThreshold_Injected(){} // RVA: 0x7B46470
        public void get_bendingStiffness_Injected(){} // RVA: 0x7B464D0
        public void set_bendingStiffness_Injected(){} // RVA: 0x7B46520
        public void get_stretchingStiffness_Injected(){} // RVA: 0x7B46580
        public void set_stretchingStiffness_Injected(){} // RVA: 0x7B465D0
        public void get_damping_Injected(){} // RVA: 0x7B46630
        public void set_damping_Injected(){} // RVA: 0x7B46680
        public void get_externalAcceleration_Injected(){} // RVA: 0x7B466E0
        public void set_externalAcceleration_Injected(){} // RVA: 0x7B46740
        public void get_randomAcceleration_Injected(){} // RVA: 0x7B467A0
        public void set_randomAcceleration_Injected(){} // RVA: 0x7B46800
        public void get_useGravity_Injected(){} // RVA: 0x7B46860
        public void set_useGravity_Injected(){} // RVA: 0x7B468B0
        public void get_enabled_Injected(){} // RVA: 0x7B46910
        public void set_enabled_Injected(){} // RVA: 0x7B46960
        public void get_friction_Injected(){} // RVA: 0x7B469C0
        public void set_friction_Injected(){} // RVA: 0x7B46A10
        public void get_collisionMassScale_Injected(){} // RVA: 0x7B46A70
        public void set_collisionMassScale_Injected(){} // RVA: 0x7B46AC0
        public void get_enableContinuousCollision_Injected(){} // RVA: 0x7B46B20
        public void set_enableContinuousCollision_Injected(){} // RVA: 0x7B46B70
        public void get_useVirtualParticles_Injected(){} // RVA: 0x7B46BD0
        public void set_useVirtualParticles_Injected(){} // RVA: 0x7B46C20
        public void get_worldVelocityScale_Injected(){} // RVA: 0x7B46C80
        public void set_worldVelocityScale_Injected(){} // RVA: 0x7B46CD0
        public void get_worldAccelerationScale_Injected(){} // RVA: 0x7B46D30
        public void set_worldAccelerationScale_Injected(){} // RVA: 0x7B46D80
        public void get_clothSolverFrequency_Injected(){} // RVA: 0x7B46DE0
        public void set_clothSolverFrequency_Injected(){} // RVA: 0x7B46E30
        public void get_useTethers_Injected(){} // RVA: 0x7B46E90
        public void set_useTethers_Injected(){} // RVA: 0x7B46EE0
        public void get_stiffnessFrequency_Injected(){} // RVA: 0x7B46F40
        public void set_stiffnessFrequency_Injected(){} // RVA: 0x7B46F90
        public void get_selfCollisionDistance_Injected(){} // RVA: 0x7B46FF0
        public void set_selfCollisionDistance_Injected(){} // RVA: 0x7B47040
        public void get_selfCollisionStiffness_Injected(){} // RVA: 0x7B470A0
        public void set_selfCollisionStiffness_Injected(){} // RVA: 0x7B470F0
        public void ClearTransformMotion_Injected(){} // RVA: 0x7B47150
        public void GetSelfAndInterCollisionIndices_Injected(){} // RVA: 0x7B471A0
        public void SetSelfAndInterCollisionIndices_Injected(){} // RVA: 0x7B47200
        public void GetVirtualParticleIndices_Injected(){} // RVA: 0x7B47260
        public void SetVirtualParticleIndices_Injected(){} // RVA: 0x7B472C0
        public void GetVirtualParticleWeights_Injected(){} // RVA: 0x7B47320
        public void SetVirtualParticleWeights_Injected(){} // RVA: 0x7B47380
        public void SetEnabledFading_Injected(){} // RVA: 0x7B473E0
        public void Raycast_Injected(){} // RVA: 0x7B47450
    }

    public class ClothSkinningCoefficient[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAC7E0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7C490
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC7BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E57A40
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7C490
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ClothSphereColliderPair : ValueType
    {
        // ── Methods ──
        public void get_first(){} // RVA: 0x77900
        public void get_second(){} // RVA: 0x77ED0
    }

    public class ClothSphereColliderPair[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Cloth[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Collider : Component
    {
        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7D1B920
        public void set_enabled(){} // RVA: 0x7D1B9C0
        public void get_attachedRigidbody(){} // RVA: 0x7D1BA70
        public void get_attachedArticulationBody(){} // RVA: 0x7D1BB30
        public void get_isTrigger(){} // RVA: 0x7D1BBF0
        public void set_isTrigger(){} // RVA: 0x7D1BC90
        public void get_contactOffset(){} // RVA: 0x7D1BD40
        public void set_contactOffset(){} // RVA: 0x7D1BDE0
        public void ClosestPoint(){} // RVA: 0x7D1BE90
        public void get_bounds(){} // RVA: 0x7D1BF60
        public void get_hasModifiableContacts(){} // RVA: 0x7D1C020
        public void set_hasModifiableContacts(){} // RVA: 0x7D1C0C0
        public void get_providesContacts(){} // RVA: 0x7D1C170
        public void set_providesContacts(){} // RVA: 0x7D1C210
        public void get_layerOverridePriority(){} // RVA: 0x7D1C2C0
        public void set_layerOverridePriority(){} // RVA: 0x7D1C360
        public void get_excludeLayers(){} // RVA: 0x7D1C410
        public void set_excludeLayers(){} // RVA: 0x7D1C4C0
        public void get_includeLayers(){} // RVA: 0x7D1C570
        public void set_includeLayers(){} // RVA: 0x7D1C620
        public void get_GeometryHolder(){} // RVA: 0x7D1C6D0
        public void GetGeometry(){} // RVA: 0xA94080
        public void get_sharedMaterial(){} // RVA: 0x7D1C790
        public void set_sharedMaterial(){} // RVA: 0x7D1C850
        public void get_material(){} // RVA: 0x7D1C930
        public void set_material(){} // RVA: 0x7D1C9F0
        public void Raycast(){} // RVA: 0x7D1CBC0
        public void Internal_ClosestPointOnBounds(){} // RVA: 0x7D1CD00
        public void ClosestPointOnBounds(){} // RVA: 0x7D1CDD0
        public void .ctor(){} // RVA: 0xB43D60
        public void get_enabled_Injected(){} // RVA: 0x7D1CF00
        public void set_enabled_Injected(){} // RVA: 0x7D1CF50
        public void get_attachedRigidbody_Injected(){} // RVA: 0x7D1CFB0
        public void get_attachedArticulationBody_Injected(){} // RVA: 0x7D1D000
        public void get_isTrigger_Injected(){} // RVA: 0x7D1D050
        public void set_isTrigger_Injected(){} // RVA: 0x7D1D0A0
        public void get_contactOffset_Injected(){} // RVA: 0x7D1D100
        public void set_contactOffset_Injected(){} // RVA: 0x7D1D150
        public void ClosestPoint_Injected(){} // RVA: 0x7D1D1B0
        public void get_bounds_Injected(){} // RVA: 0x7D1D220
        public void get_hasModifiableContacts_Injected(){} // RVA: 0x7D1D280
        public void set_hasModifiableContacts_Injected(){} // RVA: 0x7D1D2D0
        public void get_providesContacts_Injected(){} // RVA: 0x7D1D330
        public void set_providesContacts_Injected(){} // RVA: 0x7D1D380
        public void get_layerOverridePriority_Injected(){} // RVA: 0x7D1D3E0
        public void set_layerOverridePriority_Injected(){} // RVA: 0x7D1D430
        public void get_excludeLayers_Injected(){} // RVA: 0x7D1D490
        public void set_excludeLayers_Injected(){} // RVA: 0x7D1D4F0
        public void get_includeLayers_Injected(){} // RVA: 0x7D1D550
        public void set_includeLayers_Injected(){} // RVA: 0x7D1D5B0
        public void get_GeometryHolder_Injected(){} // RVA: 0x7D1D610
        public void get_sharedMaterial_Injected(){} // RVA: 0x7D1D670
        public void set_sharedMaterial_Injected(){} // RVA: 0x7D1D6C0
        public void get_material_Injected(){} // RVA: 0x7D1D720
        public void set_material_Injected(){} // RVA: 0x7D1D770
        public void Raycast_Injected(){} // RVA: 0x7D1D7D0
        public void Internal_ClosestPointOnBounds_Injected(){} // RVA: 0x7D1D860
    }

    public class Collider2D : Behaviour
    {
        // ── Methods ──
        public void get_density(){} // RVA: 0x7CFFB50
        public void set_density(){} // RVA: 0x7CFFBF0
        public void get_isTrigger(){} // RVA: 0x7CFFCA0
        public void set_isTrigger(){} // RVA: 0x7CFFD40
        public void get_usedByEffector(){} // RVA: 0x7CFFDF0
        public void set_usedByEffector(){} // RVA: 0x7CFFE90
        public void get_compositeOperation(){} // RVA: 0x7CFFF40
        public void set_compositeOperation(){} // RVA: 0x7CFFFE0
        public void get_compositeOrder(){} // RVA: 0x7D00090
        public void set_compositeOrder(){} // RVA: 0x7D00130
        public void get_composite(){} // RVA: 0x7D001E0
        public void get_offset(){} // RVA: 0x7D002A0
        public void set_offset(){} // RVA: 0x7D00350
        public void get_attachedRigidbody(){} // RVA: 0x7D00400
        public void get_localToWorldMatrix(){} // RVA: 0x7D004C0
        public void get_shapeCount(){} // RVA: 0x7D00580
        public void CreateMesh(){} // RVA: 0x7D00640
        public void GetShapeHash(){} // RVA: 0x7D00730
        public void GetShapes(){} // RVA: 0x7D008A0
        public void GetShapes_Internal(){} // RVA: 0x7D00A60
        public void GetShapeBounds(){} // RVA: 0x7D00B30
        public void get_bounds(){} // RVA: 0x7D00ED0
        public void get_errorState(){} // RVA: 0x7D00F90
        public void get_compositeCapable(){} // RVA: 0x7D01030
        public void get_sharedMaterial(){} // RVA: 0x7D010D0
        public void set_sharedMaterial(){} // RVA: 0x7D01190
        public void get_layerOverridePriority(){} // RVA: 0x7D01270
        public void set_layerOverridePriority(){} // RVA: 0x7D01310
        public void get_excludeLayers(){} // RVA: 0x7D013C0
        public void set_excludeLayers(){} // RVA: 0x7D01470
        public void get_includeLayers(){} // RVA: 0x7D01520
        public void set_includeLayers(){} // RVA: 0x7D015D0
        public void get_forceSendLayers(){} // RVA: 0x7D01680
        public void set_forceSendLayers(){} // RVA: 0x7D01730
        public void get_forceReceiveLayers(){} // RVA: 0x7D017E0
        public void set_forceReceiveLayers(){} // RVA: 0x7D01890
        public void get_contactCaptureLayers(){} // RVA: 0x7D01940
        public void set_contactCaptureLayers(){} // RVA: 0x7D019F0
        public void get_callbackLayers(){} // RVA: 0x7D01AA0
        public void set_callbackLayers(){} // RVA: 0x7D01B50
        public void get_friction(){} // RVA: 0x7D01C00
        public void get_bounciness(){} // RVA: 0x7D01CA0
        public void get_frictionCombine(){} // RVA: 0x7D01D40
        public void get_bounceCombine(){} // RVA: 0x7D01DE0
        public void get_contactMask(){} // RVA: 0x7D01E80
        public void IsTouching(){} // RVA: 0x7D02260
        public void IsTouching_OtherColliderWithFilter(){} // RVA: 0x7D02150
        public void IsTouching_AnyColliderWithFilter(){} // RVA: 0x7D02320
        public void IsTouchingLayers(){} // RVA: 0x7D02470
        public void OverlapPoint(){} // RVA: 0x7D02520
        public void Overlap(){} // RVA: 0x7D02740
        public void Cast(){} // RVA: 0x7D02FB0
        public void CastArray_Internal(){} // RVA: 0x7D03180
        public void CastList_Internal(){} // RVA: 0x7D03300
        public void CastListFiltered_Internal(){} // RVA: 0x7D03560
        public void CastFrom_Internal(){} // RVA: 0x7D037D0
        public void CastFromFiltered_Internal(){} // RVA: 0x7D03A40
        public void Raycast(){} // RVA: 0x7D04230
        public void RaycastArray_Internal(){} // RVA: 0x7D040D0
        public void RaycastList_Internal(){} // RVA: 0x7D04280
        public void Distance(){} // RVA: 0x7D04550
        public void ClosestPoint(){} // RVA: 0x7D04630
        public void GetContacts(){} // RVA: 0x7D04C50
        public void .ctor(){} // RVA: 0xB43D60
        public void get_density_Injected(){} // RVA: 0x7D04CE0
        public void set_density_Injected(){} // RVA: 0x7D04D30
        public void get_isTrigger_Injected(){} // RVA: 0x7D04D90
        public void set_isTrigger_Injected(){} // RVA: 0x7D04DE0
        public void get_usedByEffector_Injected(){} // RVA: 0x7D04E40
        public void set_usedByEffector_Injected(){} // RVA: 0x7D04E90
        public void get_compositeOperation_Injected(){} // RVA: 0x7D04EF0
        public void set_compositeOperation_Injected(){} // RVA: 0x7D04F40
        public void get_compositeOrder_Injected(){} // RVA: 0x7D04FA0
        public void set_compositeOrder_Injected(){} // RVA: 0x7D04FF0
        public void get_composite_Injected(){} // RVA: 0x7D05050
        public void get_offset_Injected(){} // RVA: 0x7D050A0
        public void set_offset_Injected(){} // RVA: 0x7D05100
        public void get_attachedRigidbody_Injected(){} // RVA: 0x7D05160
        public void get_localToWorldMatrix_Injected(){} // RVA: 0x7D051B0
        public void get_shapeCount_Injected(){} // RVA: 0x7D05210
        public void CreateMesh_Injected(){} // RVA: 0x7D05260
        public void GetShapeHash_Injected(){} // RVA: 0x7D052F0
        public void GetShapes_Internal_Injected(){} // RVA: 0x7D05340
        public void GetShapeBounds_Injected(){} // RVA: 0x7D053C0
        public void get_bounds_Injected(){} // RVA: 0x7D05450
        public void get_errorState_Injected(){} // RVA: 0x7D054B0
        public void get_compositeCapable_Injected(){} // RVA: 0x7D05500
        public void get_sharedMaterial_Injected(){} // RVA: 0x7D05550
        public void set_sharedMaterial_Injected(){} // RVA: 0x7D055A0
        public void get_layerOverridePriority_Injected(){} // RVA: 0x7D05600
        public void set_layerOverridePriority_Injected(){} // RVA: 0x7D05650
        public void get_excludeLayers_Injected(){} // RVA: 0x7D056B0
        public void set_excludeLayers_Injected(){} // RVA: 0x7D05710
        public void get_includeLayers_Injected(){} // RVA: 0x7D05770
        public void set_includeLayers_Injected(){} // RVA: 0x7D057D0
        public void get_forceSendLayers_Injected(){} // RVA: 0x7D05830
        public void set_forceSendLayers_Injected(){} // RVA: 0x7D05890
        public void get_forceReceiveLayers_Injected(){} // RVA: 0x7D058F0
        public void set_forceReceiveLayers_Injected(){} // RVA: 0x7D05950
        public void get_contactCaptureLayers_Injected(){} // RVA: 0x7D059B0
        public void set_contactCaptureLayers_Injected(){} // RVA: 0x7D05A10
        public void get_callbackLayers_Injected(){} // RVA: 0x7D05A70
        public void set_callbackLayers_Injected(){} // RVA: 0x7D05AD0
        public void get_friction_Injected(){} // RVA: 0x7D05B30
        public void get_bounciness_Injected(){} // RVA: 0x7D05B80
        public void get_frictionCombine_Injected(){} // RVA: 0x7D05BD0
        public void get_bounceCombine_Injected(){} // RVA: 0x7D05C20
        public void get_contactMask_Injected(){} // RVA: 0x7D05C70
        public void IsTouching_Injected(){} // RVA: 0x7D05CD0
        public void IsTouching_OtherColliderWithFilter_Injected(){} // RVA: 0x7D05D30
        public void IsTouching_AnyColliderWithFilter_Injected(){} // RVA: 0x7D05DA0
        public void IsTouchingLayers_Injected(){} // RVA: 0x7D05E00
        public void OverlapPoint_Injected(){} // RVA: 0x7D05E60
        public void CastArray_Internal_Injected(){} // RVA: 0x7D05EC0
        public void CastList_Internal_Injected(){} // RVA: 0x7D05F60
        public void CastListFiltered_Internal_Injected(){} // RVA: 0x7D05FF0
        public void CastFrom_Internal_Injected(){} // RVA: 0x7D06090
        public void CastFromFiltered_Internal_Injected(){} // RVA: 0x7D06130
        public void RaycastArray_Internal_Injected(){} // RVA: 0x7D061D0
        public void RaycastList_Internal_Injected(){} // RVA: 0x7D06260
    }

    public class Collider2D[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ColliderDistance2D : ValueType
    {
        // ── Methods ──
        public void get_pointA(){} // RVA: 0x961A70
        public void set_pointA(){} // RVA: 0x93050
        public void get_pointB(){} // RVA: 0x961BE0
        public void set_pointB(){} // RVA: 0x990A0
        public void get_normal(){} // RVA: 0x984800
        public void get_distance(){} // RVA: 0x958980
        public void set_distance(){} // RVA: 0x9B0C0
        public void get_isOverlapped(){} // RVA: 0x984820
        public void get_isValid(){} // RVA: 0x984830
        public void set_isValid(){} // RVA: 0x9586B0
    }

    public class Collider[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Collision : Object
    {
        // ── Methods ──
        public void get_impulse(){} // RVA: 0xBA9CC0
        public void get_relativeVelocity(){} // RVA: 0x7D16E50
        public void get_rigidbody(){} // RVA: 0x7D16EB0
        public void get_articulationBody(){} // RVA: 0x7D16F30
        public void get_body(){} // RVA: 0x7D16FB0
        public void get_collider(){} // RVA: 0x7D17030
        public void get_transform(){} // RVA: 0x7D170B0
        public void get_gameObject(){} // RVA: 0x7D171B0
        public void set_Flipped(){} // RVA: 0xB6B1B0
        public void get_contactCount(){} // RVA: 0x7D172B0
        public void get_contacts(){} // RVA: 0x7D172C0
        public void .ctor(){} // RVA: 0x7D17440
        public void Reuse(){} // RVA: 0x7D17710
        public void GetContact(){} // RVA: 0x7D177A0
        public void GetContacts(){} // RVA: 0x7D17B00
    }

    public class Collision2D : Object
    {
        // ── Methods ──
        public void GetContacts_Internal(){} // RVA: 0x7CF4950
        public void get_collider(){} // RVA: 0x7CF4970
        public void get_otherCollider(){} // RVA: 0x7CF4A20
        public void get_rigidbody(){} // RVA: 0x7CF4AD0
        public void get_otherRigidbody(){} // RVA: 0x7CF4B50
        public void get_transform(){} // RVA: 0x7CF4BD0
        public void get_gameObject(){} // RVA: 0x7CF4CD0
        public void get_relativeVelocity(){} // RVA: 0x7CF4DD0
        public void get_enabled(){} // RVA: 0x7CF4DF0
        public void get_contacts(){} // RVA: 0x7CF4E00
        public void get_contactCount(){} // RVA: 0x7AE8120
        public void GetContact(){} // RVA: 0x7CF4FC0
        public void GetContacts(){} // RVA: 0x7CF5250
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Collision2D[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Color : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x963B60
        public void ToString(){} // RVA: 0x963BA0
        public void GetHashCode(){} // RVA: 0x963BB0
        public void Equals(){} // RVA: 0x963C50
        public void op_Addition(){} // RVA: 0x7BE0DF0
        public void op_Subtraction(){} // RVA: 0x7BE0E50
        public void op_Multiply(){} // RVA: 0x7BE0F60
        public void op_Division(){} // RVA: 0x7BE0FB0
        public void op_Equality(){} // RVA: 0x7BE0FD0
        public void op_Inequality(){} // RVA: 0x7BE1040
        public void Lerp(){} // RVA: 0xB8F300
        public void LerpUnclamped(){} // RVA: 0x7BE10B0
        public void RGBMultiplied(){} // RVA: 0x963C70
        public void get_red(){} // RVA: 0xB8F6D0
        public void get_green(){} // RVA: 0xB67000
        public void get_blue(){} // RVA: 0x118FDB0
        public void get_white(){} // RVA: 0xBB9DB0
        public void get_black(){} // RVA: 0xB67370
        public void get_yellow(){} // RVA: 0xB66FC0
        public void get_cyan(){} // RVA: 0x7BE1180
        public void get_magenta(){} // RVA: 0xCF1FF0
        public void get_gray(){} // RVA: 0xB67470
        public void get_grey(){} // RVA: 0xB67470
        public void get_clear(){} // RVA: 0x10F6190
        public void get_grayscale(){} // RVA: 0x963CC0
        public void get_linear(){} // RVA: 0x963D00
        public void get_gamma(){} // RVA: 0x963D30
        public void get_maxColorComponent(){} // RVA: 0x963D60
        public void op_Implicit(){} // RVA: 0x7BE1340
        public void get_Item(){} // RVA: 0x963D80
        public void set_Item(){} // RVA: 0x963D90
        public void RGBToHSV(){} // RVA: 0x7BE1430
        public void RGBToHSVHelper(){} // RVA: 0x7BE14C0
        public void HSVToRGB(){} // RVA: 0x7BE15A0
    }

    public class Color32 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x923EC0
        public void op_Implicit(){} // RVA: 0x7BE1990
        public void Lerp(){} // RVA: 0x7BE1A10
        public void LerpUnclamped(){} // RVA: 0x1735280
        public void get_Item(){} // RVA: 0x963DA0
        public void set_Item(){} // RVA: 0x963DB0
        public void GetHashCode(){} // RVA: 0x454FE0
        public void Equals(){} // RVA: 0x95FA90
        public void ToString(){} // RVA: 0x963E70
    }

    public class Color32[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EACBA0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC5B20
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E57CC0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ColorGamut[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ColorUsageAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7BF23F0
    }

    public class ColorUtility : Object
    {
        // ── Methods ──
        public void DoTryParseHtmlColor(){} // RVA: 0x7BE1FB0
        public void TryParseHtmlString(){} // RVA: 0x7BE2100
        public void ToHtmlStringRGB(){} // RVA: 0x7BE21A0
        public void ToHtmlStringRGBA(){} // RVA: 0x7BE23B0
        public void DoTryParseHtmlColor_Injected(){} // RVA: 0x7BE2640
    }

    public class Color[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAC9B0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E57BB0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CombineInstance : ValueType
    {
        // ── Methods ──
        public void get_mesh(){} // RVA: 0x9633A0
        public void set_mesh(){} // RVA: 0x9633B0
        public void get_subMeshIndex(){} // RVA: 0x4A8D60
        public void set_subMeshIndex(){} // RVA: 0x77EE0
        public void get_transform(){} // RVA: 0x9633C0
        public void set_transform(){} // RVA: 0x9633F0
        public void get_lightmapScaleOffset(){} // RVA: 0x963410
        public void set_lightmapScaleOffset(){} // RVA: 0x963420
        public void get_realtimeLightmapScaleOffset(){} // RVA: 0x963430
        public void set_realtimeLightmapScaleOffset(){} // RVA: 0x963440
    }

    public class CombineInstance[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E80140
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B270
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC53C0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E35E00
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B270
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Component : Object
    {
        // ── Methods ──
        public void get_transform(){} // RVA: 0x7BFA7C0
        public void get_gameObject(){} // RVA: 0x7BFA880
        public void GetComponent(){} // RVA: 0x30311D0
        public void GetComponentFastPath(){} // RVA: 0x7BFA970
        public void TryGetComponent(){} // RVA: 0x3032720
        public void GetComponentInChildren(){} // RVA: 0x30317C0
        public void GetComponentsInChildren(){} // RVA: 0x3032500
        public void GetComponentInParent(){} // RVA: 0x3031B20
        public void GetComponentsInParent(){} // RVA: 0x3032650
        public void GetComponents(){} // RVA: 0x3032280
        public void GetComponentsForListInternal(){} // RVA: 0x7BFAEC0
        public void get_tag(){} // RVA: 0x7BFAF90
        public void set_tag(){} // RVA: 0x7BFAFC0
        public void GetComponentIndex(){} // RVA: 0xEE9DA0
        public void CompareTag(){} // RVA: 0x7BFAFF0
        public void SendMessageUpwards(){} // RVA: 0x7BFB1C0
        public void SendMessage(){} // RVA: 0x7BFB3C0
        public void BroadcastMessage(){} // RVA: 0x7BFB5C0
        public void .ctor(){} // RVA: 0xB43D60
        public void get_transform_Injected(){} // RVA: 0x7BFB5E0
        public void get_gameObject_Injected(){} // RVA: 0x7BFB630
        public void GetComponentFastPath_Injected(){} // RVA: 0x7BFB680
        public void GetComponent_Injected(){} // RVA: 0x7BFB6F0
        public void GetComponentsForListInternal_Injected(){} // RVA: 0x7BFB750
        public void GetComponentIndex_Injected(){} // RVA: 0x7BFB7C0
        public void SendMessageUpwards_Injected(){} // RVA: 0x7BFB810
        public void SendMessage_Injected(){} // RVA: 0x7BFB890
        public void BroadcastMessage_Injected(){} // RVA: 0x7BFB910
    }

    public class Component[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CompositeCollider2D : Collider2D
    {
        // ── Methods ──
        public void get_geometryType(){} // RVA: 0x7D09C60
        public void set_geometryType(){} // RVA: 0x7D09D00
        public void get_generationType(){} // RVA: 0x7D09DB0
        public void set_generationType(){} // RVA: 0x7D09E50
        public void get_useDelaunayMesh(){} // RVA: 0x7D09F00
        public void set_useDelaunayMesh(){} // RVA: 0x7D09FA0
        public void get_vertexDistance(){} // RVA: 0x7D0A050
        public void set_vertexDistance(){} // RVA: 0x7D0A0F0
        public void get_edgeRadius(){} // RVA: 0x7D0A1A0
        public void set_edgeRadius(){} // RVA: 0x7D0A240
        public void get_offsetDistance(){} // RVA: 0x7D0A2F0
        public void set_offsetDistance(){} // RVA: 0x7D0A390
        public void GenerateGeometry(){} // RVA: 0x7D0A440
        public void GetCompositedColliders(){} // RVA: 0x7D0A4E0
        public void GetPathPointCount(){} // RVA: 0x7D0A5B0
        public void GetPathPointCount_Internal(){} // RVA: 0x7D0A780
        public void get_pathCount(){} // RVA: 0x7D0A830
        public void get_pointCount(){} // RVA: 0x7D0A8D0
        public void GetPath(){} // RVA: 0x7D0ACF0
        public void GetPathArray_Internal(){} // RVA: 0x7D0ABB0
        public void GetPathList_Internal(){} // RVA: 0x7D0AE40
        public void .ctor(){} // RVA: 0xB43D60
        public void get_geometryType_Injected(){} // RVA: 0x7D0B060
        public void set_geometryType_Injected(){} // RVA: 0x7D0B0B0
        public void get_generationType_Injected(){} // RVA: 0x7D0B110
        public void set_generationType_Injected(){} // RVA: 0x7D0B160
        public void get_useDelaunayMesh_Injected(){} // RVA: 0x7D0B1C0
        public void set_useDelaunayMesh_Injected(){} // RVA: 0x7D0B210
        public void get_vertexDistance_Injected(){} // RVA: 0x7D0B270
        public void set_vertexDistance_Injected(){} // RVA: 0x7D0B2C0
        public void get_edgeRadius_Injected(){} // RVA: 0x7D0B320
        public void set_edgeRadius_Injected(){} // RVA: 0x7D0B370
        public void get_offsetDistance_Injected(){} // RVA: 0x7D0B3D0
        public void set_offsetDistance_Injected(){} // RVA: 0x7D0B420
        public void GenerateGeometry_Injected(){} // RVA: 0x7D0B480
        public void GetCompositedColliders_Injected(){} // RVA: 0x7D0B4D0
        public void GetPathPointCount_Internal_Injected(){} // RVA: 0x7D0B530
        public void get_pathCount_Injected(){} // RVA: 0x7D0B590
        public void get_pointCount_Injected(){} // RVA: 0x7D0B5E0
        public void GetPathArray_Internal_Injected(){} // RVA: 0x7D0B630
        public void GetPathList_Internal_Injected(){} // RVA: 0x7D0B6A0
    }

    public class ComputeBuffer : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7C0D570
        public void Dispose(){} // RVA: 0x7C0D6F0
        public void InitBuffer(){} // RVA: 0x7C0D7E0
        public void DestroyBuffer(){} // RVA: 0x7C0D860
        public void .ctor(){} // RVA: 0x7C0D920
        public void Release(){} // RVA: 0x7C0DB60
        public void IsValidBuffer(){} // RVA: 0x7C0DB70
        public void IsValid(){} // RVA: 0x7C0DBD0
        public void get_count(){} // RVA: 0x7C0DC40
        public void get_stride(){} // RVA: 0x7C0DCB0
        public void SetData(){} // RVA: 0x7C0DF20
        public void InternalSetData(){} // RVA: 0x7C0E1B0
        public void GetData(){} // RVA: 0x7C0E250
        public void InternalGetData(){} // RVA: 0x7C0E450
        public void set_name(){} // RVA: 0x7C0E4F0
        public void SetName(){} // RVA: 0x7C0E500
        public void SetCounterValue(){} // RVA: 0x7C0E680
        public void CopyCount(){} // RVA: 0x7C0E700
        public void DestroyBuffer_Injected(){} // RVA: 0x7C0E780
        public void IsValidBuffer_Injected(){} // RVA: 0x7C0E7D0
        public void get_count_Injected(){} // RVA: 0x7C0E820
        public void get_stride_Injected(){} // RVA: 0x7C0E870
        public void InternalSetData_Injected(){} // RVA: 0x7C0E8C0
        public void InternalGetData_Injected(){} // RVA: 0x7C0E950
        public void SetName_Injected(){} // RVA: 0x7C0E9E0
        public void SetCounterValue_Injected(){} // RVA: 0x7C0EA40
        public void CopyCount_Injected(){} // RVA: 0x7C0EAA0
    }

    public class ComputeBuffer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ComputeShader : Object
    {
        // ── Methods ──
        public void FindKernel(){} // RVA: 0x7C0EB10
        public void SetFloat(){} // RVA: 0x7C0ECA0
        public void SetInt(){} // RVA: 0x7C0ED60
        public void SetVector(){} // RVA: 0x7C0EE20
        public void SetMatrix(){} // RVA: 0x7C0EEE0
        public void SetVectorArray(){} // RVA: 0x7C0EFA0
        public void SetTexture(){} // RVA: 0x7C0F530
        public void Internal_SetBuffer(){} // RVA: 0x7C0F200
        public void SetBuffer(){} // RVA: 0x7C0F200
        public void GetKernelThreadGroupSizes(){} // RVA: 0x7C0F320
        public void Dispatch(){} // RVA: 0x7C0F3F0
        public void .ctor(){} // RVA: 0x7C0F4C0
        public void SetBool(){} // RVA: 0x7C0F510
        public void FindKernel_Injected(){} // RVA: 0x7C0F660
        public void SetFloat_Injected(){} // RVA: 0x7C0F6C0
        public void SetInt_Injected(){} // RVA: 0x7C0F730
        public void SetVector_Injected(){} // RVA: 0x7C0F7A0
        public void SetMatrix_Injected(){} // RVA: 0x7C0F810
        public void SetVectorArray_Injected(){} // RVA: 0x7C0F880
        public void SetTexture_Injected(){} // RVA: 0x7C0F8F0
        public void Internal_SetBuffer_Injected(){} // RVA: 0x7C0F970
        public void GetKernelThreadGroupSizes_Injected(){} // RVA: 0x7C0F9F0
        public void Dispatch_Injected(){} // RVA: 0x7C0FA70
    }

    public class ComputeShader[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ConfigurableJoint : Joint
    {
        // ── Methods ──
        public void get_secondaryAxis(){} // RVA: 0x7D1D8E0
        public void set_secondaryAxis(){} // RVA: 0x7D1D9A0
        public void get_xMotion(){} // RVA: 0x7D1DA50
        public void set_xMotion(){} // RVA: 0x7D1DAF0
        public void get_yMotion(){} // RVA: 0x7D1DBA0
        public void set_yMotion(){} // RVA: 0x7D1DC40
        public void get_zMotion(){} // RVA: 0x7D1DCF0
        public void set_zMotion(){} // RVA: 0x7D1DD90
        public void get_angularXMotion(){} // RVA: 0x7D1DE40
        public void set_angularXMotion(){} // RVA: 0x7D1DEE0
        public void get_angularYMotion(){} // RVA: 0x7D1DF90
        public void set_angularYMotion(){} // RVA: 0x7D1E030
        public void get_angularZMotion(){} // RVA: 0x7D1E0E0
        public void set_angularZMotion(){} // RVA: 0x7D1E180
        public void get_linearLimitSpring(){} // RVA: 0x7D1E230
        public void set_linearLimitSpring(){} // RVA: 0x7D1E2E0
        public void get_angularXLimitSpring(){} // RVA: 0x7D1E390
        public void set_angularXLimitSpring(){} // RVA: 0x7D1E440
        public void get_angularYZLimitSpring(){} // RVA: 0x7D1E4F0
        public void set_angularYZLimitSpring(){} // RVA: 0x7D1E5A0
        public void get_linearLimit(){} // RVA: 0x7D1E650
        public void set_linearLimit(){} // RVA: 0x7D1E710
        public void get_lowAngularXLimit(){} // RVA: 0x7D1E7C0
        public void set_lowAngularXLimit(){} // RVA: 0x7D1E880
        public void get_highAngularXLimit(){} // RVA: 0x7D1E930
        public void set_highAngularXLimit(){} // RVA: 0x7D1E9F0
        public void get_angularYLimit(){} // RVA: 0x7D1EAA0
        public void set_angularYLimit(){} // RVA: 0x7D1EB60
        public void get_angularZLimit(){} // RVA: 0x7D1EC10
        public void set_angularZLimit(){} // RVA: 0x7D1ECD0
        public void get_targetPosition(){} // RVA: 0x7D1ED80
        public void set_targetPosition(){} // RVA: 0x7D1EE40
        public void get_targetVelocity(){} // RVA: 0x7D1EEF0
        public void set_targetVelocity(){} // RVA: 0x7D1EFB0
        public void get_xDrive(){} // RVA: 0x7D1F060
        public void set_xDrive(){} // RVA: 0x7D1F120
        public void get_yDrive(){} // RVA: 0x7D1F1D0
        public void set_yDrive(){} // RVA: 0x7D1F290
        public void get_zDrive(){} // RVA: 0x7D1F340
        public void set_zDrive(){} // RVA: 0x7D1F400
        public void get_targetRotation(){} // RVA: 0x7D1F4B0
        public void set_targetRotation(){} // RVA: 0x7D1F570
        public void get_targetAngularVelocity(){} // RVA: 0x7D1F620
        public void set_targetAngularVelocity(){} // RVA: 0x7D1F6E0
        public void get_rotationDriveMode(){} // RVA: 0x7D1F790
        public void set_rotationDriveMode(){} // RVA: 0x7D1F830
        public void get_angularXDrive(){} // RVA: 0x7D1F8E0
        public void set_angularXDrive(){} // RVA: 0x7D1F9A0
        public void get_angularYZDrive(){} // RVA: 0x7D1FA50
        public void set_angularYZDrive(){} // RVA: 0x7D1FB10
        public void get_slerpDrive(){} // RVA: 0x7D1FBC0
        public void set_slerpDrive(){} // RVA: 0x7D1FC80
        public void get_projectionMode(){} // RVA: 0x7D1FD30
        public void set_projectionMode(){} // RVA: 0x7D1FDD0
        public void get_projectionDistance(){} // RVA: 0x7D1FE80
        public void set_projectionDistance(){} // RVA: 0x7D1FF20
        public void get_projectionAngle(){} // RVA: 0x7D1FFD0
        public void set_projectionAngle(){} // RVA: 0x7D20070
        public void get_configuredInWorldSpace(){} // RVA: 0x7D20120
        public void set_configuredInWorldSpace(){} // RVA: 0x7D201C0
        public void get_swapBodies(){} // RVA: 0x7D20270
        public void set_swapBodies(){} // RVA: 0x7D20310
        public void .ctor(){} // RVA: 0xB43D60
        public void get_secondaryAxis_Injected(){} // RVA: 0x7D203C0
        public void set_secondaryAxis_Injected(){} // RVA: 0x7D20420
        public void get_xMotion_Injected(){} // RVA: 0x7D20480
        public void set_xMotion_Injected(){} // RVA: 0x7D204D0
        public void get_yMotion_Injected(){} // RVA: 0x7D20530
        public void set_yMotion_Injected(){} // RVA: 0x7D20580
        public void get_zMotion_Injected(){} // RVA: 0x7D205E0
        public void set_zMotion_Injected(){} // RVA: 0x7D20630
        public void get_angularXMotion_Injected(){} // RVA: 0x7D20690
        public void set_angularXMotion_Injected(){} // RVA: 0x7D206E0
        public void get_angularYMotion_Injected(){} // RVA: 0x7D20740
        public void set_angularYMotion_Injected(){} // RVA: 0x7D20790
        public void get_angularZMotion_Injected(){} // RVA: 0x7D207F0
        public void set_angularZMotion_Injected(){} // RVA: 0x7D20840
        public void get_linearLimitSpring_Injected(){} // RVA: 0x7D208A0
        public void set_linearLimitSpring_Injected(){} // RVA: 0x7D20900
        public void get_angularXLimitSpring_Injected(){} // RVA: 0x7D20960
        public void set_angularXLimitSpring_Injected(){} // RVA: 0x7D209C0
        public void get_angularYZLimitSpring_Injected(){} // RVA: 0x7D20A20
        public void set_angularYZLimitSpring_Injected(){} // RVA: 0x7D20A80
        public void get_linearLimit_Injected(){} // RVA: 0x7D20AE0
        public void set_linearLimit_Injected(){} // RVA: 0x7D20B40
        public void get_lowAngularXLimit_Injected(){} // RVA: 0x7D20BA0
        public void set_lowAngularXLimit_Injected(){} // RVA: 0x7D20C00
        public void get_highAngularXLimit_Injected(){} // RVA: 0x7D20C60
        public void set_highAngularXLimit_Injected(){} // RVA: 0x7D20CC0
        public void get_angularYLimit_Injected(){} // RVA: 0x7D20D20
        public void set_angularYLimit_Injected(){} // RVA: 0x7D20D80
        public void get_angularZLimit_Injected(){} // RVA: 0x7D20DE0
        public void set_angularZLimit_Injected(){} // RVA: 0x7D20E40
        public void get_targetPosition_Injected(){} // RVA: 0x7D20EA0
        public void set_targetPosition_Injected(){} // RVA: 0x7D20F00
        public void get_targetVelocity_Injected(){} // RVA: 0x7D20F60
        public void set_targetVelocity_Injected(){} // RVA: 0x7D20FC0
        public void get_xDrive_Injected(){} // RVA: 0x7D21020
        public void set_xDrive_Injected(){} // RVA: 0x7D21080
        public void get_yDrive_Injected(){} // RVA: 0x7D210E0
        public void set_yDrive_Injected(){} // RVA: 0x7D21140
        public void get_zDrive_Injected(){} // RVA: 0x7D211A0
        public void set_zDrive_Injected(){} // RVA: 0x7D21200
        public void get_targetRotation_Injected(){} // RVA: 0x7D21260
        public void set_targetRotation_Injected(){} // RVA: 0x7D212C0
        public void get_targetAngularVelocity_Injected(){} // RVA: 0x7D21320
        public void set_targetAngularVelocity_Injected(){} // RVA: 0x7D21380
        public void get_rotationDriveMode_Injected(){} // RVA: 0x7D213E0
        public void set_rotationDriveMode_Injected(){} // RVA: 0x7D21430
        public void get_angularXDrive_Injected(){} // RVA: 0x7D21490
        public void set_angularXDrive_Injected(){} // RVA: 0x7D214F0
        public void get_angularYZDrive_Injected(){} // RVA: 0x7D21550
        public void set_angularYZDrive_Injected(){} // RVA: 0x7D215B0
        public void get_slerpDrive_Injected(){} // RVA: 0x7D21610
        public void set_slerpDrive_Injected(){} // RVA: 0x7D21670
        public void get_projectionMode_Injected(){} // RVA: 0x7D216D0
        public void set_projectionMode_Injected(){} // RVA: 0x7D21720
        public void get_projectionDistance_Injected(){} // RVA: 0x7D21780
        public void set_projectionDistance_Injected(){} // RVA: 0x7D217D0
        public void get_projectionAngle_Injected(){} // RVA: 0x7D21830
        public void set_projectionAngle_Injected(){} // RVA: 0x7D21880
        public void get_configuredInWorldSpace_Injected(){} // RVA: 0x7D218E0
        public void set_configuredInWorldSpace_Injected(){} // RVA: 0x7D21930
        public void get_swapBodies_Injected(){} // RVA: 0x7D21990
        public void set_swapBodies_Injected(){} // RVA: 0x7D219E0
    }

    public class ConfigurableJoint[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ConstantForce : Behaviour
    {
        // ── Methods ──
        public void get_force(){} // RVA: 0x7D21A40
        public void set_force(){} // RVA: 0x7D21B00
        public void get_torque(){} // RVA: 0x7D21BB0
        public void set_torque(){} // RVA: 0x7D21C70
        public void get_relativeForce(){} // RVA: 0x7D21D20
        public void set_relativeForce(){} // RVA: 0x7D21DE0
        public void get_relativeTorque(){} // RVA: 0x7D21E90
        public void set_relativeTorque(){} // RVA: 0x7D21F50
        public void .ctor(){} // RVA: 0xB43D60
        public void get_force_Injected(){} // RVA: 0x7D22000
        public void set_force_Injected(){} // RVA: 0x7D22060
        public void get_torque_Injected(){} // RVA: 0x7D220C0
        public void set_torque_Injected(){} // RVA: 0x7D22120
        public void get_relativeForce_Injected(){} // RVA: 0x7D22180
        public void set_relativeForce_Injected(){} // RVA: 0x7D221E0
        public void get_relativeTorque_Injected(){} // RVA: 0x7D22240
        public void set_relativeTorque_Injected(){} // RVA: 0x7D222A0
    }

    public class ConstantForce2D : PhysicsUpdateBehaviour2D
    {
        // ── Methods ──
        public void get_force(){} // RVA: 0x7D15C90
        public void set_force(){} // RVA: 0x7D15D40
        public void get_relativeForce(){} // RVA: 0x7D15DF0
        public void set_relativeForce(){} // RVA: 0x7D15EA0
        public void get_torque(){} // RVA: 0x7D15F50
        public void set_torque(){} // RVA: 0x7D15FF0
        public void .ctor(){} // RVA: 0xB43D60
        public void get_force_Injected(){} // RVA: 0x7D160A0
        public void set_force_Injected(){} // RVA: 0x7D16100
        public void get_relativeForce_Injected(){} // RVA: 0x7D16160
        public void set_relativeForce_Injected(){} // RVA: 0x7D161C0
        public void get_torque_Injected(){} // RVA: 0x7D16220
        public void set_torque_Injected(){} // RVA: 0x7D16270
    }

    public class ContactFilter2D : ValueType
    {
        // ── Methods ──
        public void NoFilter(){} // RVA: 0x9848F0
        public void CheckConsistency(){} // RVA: 0x984940
        public void ClearLayerMask(){} // RVA: 0x984990
        public void SetLayerMask(){} // RVA: 0x9849A0
        public void ClearDepth(){} // RVA: 0x9849B0
        public void SetDepth(){} // RVA: 0x9849C0
        public void ClearNormalAngle(){} // RVA: 0x984A20
        public void SetNormalAngle(){} // RVA: 0x984A30
        public void get_isFiltering(){} // RVA: 0x984A90
        public void IsFilteringTrigger(){} // RVA: 0x984AC0
        public void IsFilteringLayerMask(){} // RVA: 0x984AF0
        public void IsFilteringDepth(){} // RVA: 0x984B30
        public void IsFilteringNormalAngle(){} // RVA: 0x984BA0
        public void IsFilteringNormalAngleUsingAngle(){} // RVA: 0x984BA0
        public void CreateLegacyFilter(){} // RVA: 0x7CF47A0
        public void IsFilteringNormalAngle_Injected(){} // RVA: 0x7CF48F0
    }

    public class ContactFilter2D[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7F0B0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7AD50
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC49A0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E350A0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7AD50
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ContactPair : ValueType
    {
        // ── Methods ──
        public void get_colliderInstanceID(){} // RVA: 0x77E60
        public void get_otherColliderInstanceID(){} // RVA: 0x77E50
        public void get_collider(){} // RVA: 0x985840
        public void get_otherCollider(){} // RVA: 0x9858A0
        public void get_impulseSum(){} // RVA: 0x9858B0
        public void get_isCollisionEnter(){} // RVA: 0x9858D0
        public void get_isCollisionExit(){} // RVA: 0x9858E0
        public void get_isCollisionStay(){} // RVA: 0x9858F0
        public void get_hasRemovedCollider(){} // RVA: 0x985800
        public void ExtractContacts(){} // RVA: 0x985900
        public void ExtractContactsArray(){} // RVA: 0x985910
        public void GetContactPoint(){} // RVA: 0x985920
        public void GetContactPoint_Internal(){} // RVA: 0x985930
    }

    public class ContactPairHeader : ValueType
    {
        // ── Methods ──
        public void get_body(){} // RVA: 0x985760
        public void get_otherBody(){} // RVA: 0x9857B0
        public void get_hasRemovedBody(){} // RVA: 0x985800
        public void GetContactPair(){} // RVA: 0x985820
        public void GetContactPair_Internal(){} // RVA: 0x985830
    }

    public class ContactPairHeader[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7EC40
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7ABD0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4700
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34D20
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7ABD0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ContactPairPoint : ValueType
    {
        // ── Methods ──
        public void get_position(){} // RVA: 0x45A5B0
        public void get_separation(){} // RVA: 0xD1B00
        public void get_normal(){} // RVA: 0x262C90
        public void get_impulse(){} // RVA: 0x985940
    }

    public class ContactPairPoint[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ContactPair[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ContactPoint : ValueType
    {
        // ── Methods ──
        public void get_point(){} // RVA: 0x45A590
        public void get_normal(){} // RVA: 0x959B90
        public void get_impulse(){} // RVA: 0x959BB0
        public void get_thisCollider(){} // RVA: 0x985550
        public void get_otherCollider(){} // RVA: 0x9855A0
        public void get_separation(){} // RVA: 0x971FA0
        public void .ctor(){} // RVA: 0x9855F0
    }

    public class ContactPoint2D : ValueType
    {
        // ── Methods ──
        public void get_point(){} // RVA: 0x961A70
        public void get_normal(){} // RVA: 0x961BE0
        public void get_separation(){} // RVA: 0x95A7F0
        public void get_normalImpulse(){} // RVA: 0x9589B0
        public void get_tangentImpulse(){} // RVA: 0x95A800
        public void get_relativeVelocity(){} // RVA: 0x984800
        public void get_friction(){} // RVA: 0x958980
        public void get_bounciness(){} // RVA: 0x958990
        public void get_collider(){} // RVA: 0x984F40
        public void get_otherCollider(){} // RVA: 0x984F50
        public void get_rigidbody(){} // RVA: 0x984F60
        public void get_otherRigidbody(){} // RVA: 0x984F70
        public void get_enabled(){} // RVA: 0x984F80
    }

    public class ContactPoint2D[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E84B40
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7BAA0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC6440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E39400
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7BAA0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ContextMenu : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7BF5AE0
    }

    public class ContextMenuItemAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7BF22C0
    }

    public class ContextMenu[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ControllerColliderHit : Object
    {
        // ── Methods ──
        public void get_controller(){} // RVA: 0x3E42230
        public void get_collider(){} // RVA: 0x3926770
        public void get_rigidbody(){} // RVA: 0x7D18AE0
        public void get_gameObject(){} // RVA: 0x7D18B00
        public void get_transform(){} // RVA: 0x7D18B20
        public void get_point(){} // RVA: 0x7D18B40
        public void get_normal(){} // RVA: 0x7D18B60
        public void get_moveDirection(){} // RVA: 0x7D18B80
        public void get_moveLength(){} // RVA: 0x7D18BA0
    }

    public class ControllerColliderHit[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Coroutine : YieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Finalize(){} // RVA: 0x7BFB990
        public void ReleaseCoroutine(){} // RVA: 0x7BFBA10
    }

    public class Coroutine[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CreateAssetMenuAttribute : Attribute
    {
        // ── Methods ──
        public void set_menuName(){} // RVA: 0xB44D60
        public void set_fileName(){} // RVA: 0xBA9BA0
        public void set_order(){} // RVA: 0x1269760
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Cubemap : Texture
    {
        // ── Methods ──
        public void get_format(){} // RVA: 0x7BCD5F0
        public void Internal_CreateImpl(){} // RVA: 0x7BCD690
        public void Internal_Create(){} // RVA: 0x7BCD710
        public void ApplyImpl(){} // RVA: 0x7BCD800
        public void get_isReadable(){} // RVA: 0x7BCD8C0
        public void SetPixelImpl(){} // RVA: 0x7BCD960
        public void GetPixelImpl(){} // RVA: 0x7BCDA50
        public void SmoothEdges(){} // RVA: 0x7BCDBF0
        public void GetPixels(){} // RVA: 0x7BCDD50
        public void SetPixels(){} // RVA: 0x7BCDF70
        public void SetPixelDataImplArray(){} // RVA: 0x7BCDEA0
        public void CopyPixels_Full(){} // RVA: 0x7BCDF90
        public void CopyPixels_Slice(){} // RVA: 0x7BCE070
        public void CopyPixels_Region(){} // RVA: 0x7BCE180
        public void get_streamingMipmaps(){} // RVA: 0x7BCE290
        public void get_streamingMipmapsPriority(){} // RVA: 0x7BCE330
        public void get_requestedMipmapLevel(){} // RVA: 0x7BCE3D0
        public void set_requestedMipmapLevel(){} // RVA: 0x7BCE470
        public void get_desiredMipmapLevel(){} // RVA: 0x7BCE520
        public void get_loadingMipmapLevel(){} // RVA: 0x7BCE5C0
        public void get_loadedMipmapLevel(){} // RVA: 0x7BCE660
        public void ClearRequestedMipmapLevel(){} // RVA: 0x7BCE700
        public void ValidateFormat(){} // RVA: 0x7BCE860
        public void .ctor(){} // RVA: 0x7BCF1F0
        public void CreateExternalTexture(){} // RVA: 0x7BCF220
        public void SetPixelData(){} // RVA: 0x89BA50
        public void SetPixel(){} // RVA: 0x7BCF390
        public void GetPixel(){} // RVA: 0x7BCF500
        public void Apply(){} // RVA: 0x7BCF750
        public void CopyPixels(){} // RVA: 0x7BCFA60
        public void ValidateIsNotCrunched(){} // RVA: 0x7BCFBF0
        public void get_format_Injected(){} // RVA: 0x7BCFC50
        public void ApplyImpl_Injected(){} // RVA: 0x7BCFCA0
        public void get_isReadable_Injected(){} // RVA: 0x7BCFD20
        public void SetPixelImpl_Injected(){} // RVA: 0x7BCFD70
        public void GetPixelImpl_Injected(){} // RVA: 0x7BCFDF0
        public void SmoothEdges_Injected(){} // RVA: 0x7BCFE70
        public void GetPixels_Injected(){} // RVA: 0x7BCFED0
        public void SetPixels_Injected(){} // RVA: 0x7BCFF40
        public void SetPixelDataImplArray_Injected(){} // RVA: 0x7BCFFC0
        public void CopyPixels_Full_Injected(){} // RVA: 0x7BD0050
        public void CopyPixels_Slice_Injected(){} // RVA: 0x7BD00B0
        public void CopyPixels_Region_Injected(){} // RVA: 0x7BD0140
        public void get_streamingMipmaps_Injected(){} // RVA: 0x7BD01D0
        public void get_streamingMipmapsPriority_Injected(){} // RVA: 0x7BD0220
        public void get_requestedMipmapLevel_Injected(){} // RVA: 0x7BD0270
        public void set_requestedMipmapLevel_Injected(){} // RVA: 0x7BD02C0
        public void get_desiredMipmapLevel_Injected(){} // RVA: 0x7BD0320
        public void get_loadingMipmapLevel_Injected(){} // RVA: 0x7BD0370
        public void get_loadedMipmapLevel_Injected(){} // RVA: 0x7BD03C0
        public void ClearRequestedMipmapLevel_Injected(){} // RVA: 0x7BD0410
    }

    public class CubemapArray : Texture
    {
        // ── Methods ──
        public void get_isReadable(){} // RVA: 0x7BD4650
        public void Internal_CreateImpl(){} // RVA: 0x7BD46F0
        public void Internal_Create(){} // RVA: 0x7BD4770
        public void .ctor(){} // RVA: 0x7BD4F50
        public void ValidateIsNotCrunched(){} // RVA: 0x7BD5010
        public void get_isReadable_Injected(){} // RVA: 0x7BD5070
    }

    public class CubemapArray[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Cubemap[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CullingGroup : Object
    {
        // ── Methods ──
        public void SendEvents(){} // RVA: 0x7B65FE0
    }

    public class CullingGroup[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Cursor : Object
    {
        // ── Methods ──
        public void SetCursor(){} // RVA: 0x7BDF7E0
        public void get_visible(){} // RVA: 0x7BDF890
        public void set_visible(){} // RVA: 0x7BDF8E0
        public void get_lockState(){} // RVA: 0x7BDF930
        public void set_lockState(){} // RVA: 0x7BDF980
        public void SetCursor_Injected(){} // RVA: 0x7BDF9D0
    }

    public class CustomRenderTexture : RenderTexture
    {
        // ── Methods ──
        public void Internal_CreateCustomRenderTexture(){} // RVA: 0x7BDBAC0
        public void TriggerUpdate(){} // RVA: 0x7BDBB10
        public void Update(){} // RVA: 0x7BDBCC0
        public void TriggerInitialization(){} // RVA: 0x7BDBCD0
        public void Initialize(){} // RVA: 0x7BDBD70
        public void ClearUpdateZones(){} // RVA: 0x7BDBE60
        public void get_material(){} // RVA: 0x7BDBF00
        public void set_material(){} // RVA: 0x7BDBFC0
        public void get_initializationMaterial(){} // RVA: 0x7BDC0A0
        public void set_initializationMaterial(){} // RVA: 0x7BDC160
        public void get_initializationTexture(){} // RVA: 0x7BDC240
        public void set_initializationTexture(){} // RVA: 0x7BDC300
        public void GetUpdateZonesInternal(){} // RVA: 0x7BDC3E0
        public void GetUpdateZones(){} // RVA: 0x7BDC3E0
        public void SetUpdateZonesInternal(){} // RVA: 0x7BDC4B0
        public void GetDoubleBufferRenderTexture(){} // RVA: 0x7BDC5D0
        public void EnsureDoubleBufferConsistency(){} // RVA: 0x7BDC690
        public void SetUpdateZones(){} // RVA: 0x7BDC730
        public void get_initializationSource(){} // RVA: 0x7BDC890
        public void set_initializationSource(){} // RVA: 0x7BDC930
        public void get_initializationColor(){} // RVA: 0x7BDC9E0
        public void set_initializationColor(){} // RVA: 0x7BDCAA0
        public void get_updateMode(){} // RVA: 0x7BDCB50
        public void set_updateMode(){} // RVA: 0x7BDCBF0
        public void get_initializationMode(){} // RVA: 0x7BDCCA0
        public void set_initializationMode(){} // RVA: 0x7BDCD40
        public void get_updateZoneSpace(){} // RVA: 0x7BDCDF0
        public void set_updateZoneSpace(){} // RVA: 0x7BDCE90
        public void get_shaderPass(){} // RVA: 0x7BDCF40
        public void set_shaderPass(){} // RVA: 0x7BDCFE0
        public void get_cubemapFaceMask(){} // RVA: 0x7BDD090
        public void set_cubemapFaceMask(){} // RVA: 0x7BDD130
        public void get_doubleBuffered(){} // RVA: 0x7BDD1E0
        public void set_doubleBuffered(){} // RVA: 0x7BDD280
        public void get_wrapUpdateZones(){} // RVA: 0x7BDD330
        public void set_wrapUpdateZones(){} // RVA: 0x7BDD3D0
        public void get_updatePeriod(){} // RVA: 0x7BDD480
        public void set_updatePeriod(){} // RVA: 0x7BDD520
        public void .ctor(){} // RVA: 0x7BDD9D0
        public void TriggerUpdate_Injected(){} // RVA: 0x7BDDBA0
        public void TriggerInitialization_Injected(){} // RVA: 0x7BDDC00
        public void ClearUpdateZones_Injected(){} // RVA: 0x7BDDC50
        public void get_material_Injected(){} // RVA: 0x7BDDCA0
        public void set_material_Injected(){} // RVA: 0x7BDDCF0
        public void get_initializationMaterial_Injected(){} // RVA: 0x7BDDD50
        public void set_initializationMaterial_Injected(){} // RVA: 0x7BDDDA0
        public void get_initializationTexture_Injected(){} // RVA: 0x7BDDE00
        public void set_initializationTexture_Injected(){} // RVA: 0x7BDDE50
        public void GetUpdateZonesInternal_Injected(){} // RVA: 0x7BDDEB0
        public void SetUpdateZonesInternal_Injected(){} // RVA: 0x7BDDF10
        public void GetDoubleBufferRenderTexture_Injected(){} // RVA: 0x7BDDF70
        public void EnsureDoubleBufferConsistency_Injected(){} // RVA: 0x7BDDFC0
        public void get_initializationSource_Injected(){} // RVA: 0x7BDE010
        public void set_initializationSource_Injected(){} // RVA: 0x7BDE060
        public void get_initializationColor_Injected(){} // RVA: 0x7BDE0C0
        public void set_initializationColor_Injected(){} // RVA: 0x7BDE120
        public void get_updateMode_Injected(){} // RVA: 0x7BDE180
        public void set_updateMode_Injected(){} // RVA: 0x7BDE1D0
        public void get_initializationMode_Injected(){} // RVA: 0x7BDE230
        public void set_initializationMode_Injected(){} // RVA: 0x7BDE280
        public void get_updateZoneSpace_Injected(){} // RVA: 0x7BDE2E0
        public void set_updateZoneSpace_Injected(){} // RVA: 0x7BDE330
        public void get_shaderPass_Injected(){} // RVA: 0x7BDE390
        public void set_shaderPass_Injected(){} // RVA: 0x7BDE3E0
        public void get_cubemapFaceMask_Injected(){} // RVA: 0x7BDE440
        public void set_cubemapFaceMask_Injected(){} // RVA: 0x7BDE490
        public void get_doubleBuffered_Injected(){} // RVA: 0x7BDE4F0
        public void set_doubleBuffered_Injected(){} // RVA: 0x7BDE540
        public void get_wrapUpdateZones_Injected(){} // RVA: 0x7BDE5A0
        public void set_wrapUpdateZones_Injected(){} // RVA: 0x7BDE5F0
        public void get_updatePeriod_Injected(){} // RVA: 0x7BDE650
        public void set_updatePeriod_Injected(){} // RVA: 0x7BDE6A0
    }

    public class CustomRenderTextureManager : Object
    {
        // ── Methods ──
        public void InvokeOnTextureLoaded_Internal(){} // RVA: 0x7B78DD0
        public void InvokeOnTextureUnloaded_Internal(){} // RVA: 0x7B78E30
        public void InvokeTriggerUpdate(){} // RVA: 0x7B78E90
        public void InvokeTriggerInitialize(){} // RVA: 0x7B78F00
    }

    public class CustomRenderTextureManager[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CustomRenderTextureUpdateZone[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7F2C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7AE10
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4AF0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E35240
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7AE10
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CustomRenderTexture[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CustomYieldInstruction : Object
    {
        // ── Methods ──
        public void get_keepWaiting(){} // RVA: 0x87D280
        public void get_Current(){} // RVA: 0x4005650
        public void MoveNext(){} // RVA: 0x254FA90
        public void Reset(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43310
    }

}