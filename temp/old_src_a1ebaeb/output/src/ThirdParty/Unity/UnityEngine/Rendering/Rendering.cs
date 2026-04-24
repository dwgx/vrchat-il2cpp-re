// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering
// Classes: 27
// Methods: 295

namespace ThirdParty.Unity.UnityEngine.Rendering
{
    public class AsyncGPUReadbackRequest : ValueType
    {
        // ── Original Methods ──
        public void get_done(){} // RVA: 0x7ffaaf308b00
        public void get_hasError(){} // RVA: 0x7ffaaf308b50
        public void get_layerCount(){} // RVA: 0x7ffaaf308ba0
        public void get_layerDataSize(){} // RVA: 0x7ffaaf308bf0
        public void get_width(){} // RVA: 0x7ffaaf308c40
        public void get_height(){} // RVA: 0x7ffaaf308c90
        public void get_depth(){} // RVA: 0x7ffaaf308ce0
        public void IsDone(){} // RVA: 0x7ffaaf308b00
        public void HasError(){} // RVA: 0x7ffaaf308b50
        public void IsDone_Injected(){} // RVA: 0x7ffaaf308b00
        public void HasError_Injected(){} // RVA: 0x7ffaaf308b50
        // ── Binary Analysis Named ──
        public void GetData(){} // RVA: 0x7ffaa887e5c0
        public void GetLayerCount(){} // RVA: 0x7ffaaf308ba0
        public void GetLayerDataSize(){} // RVA: 0x7ffaaf308bf0
        public void GetWidth(){} // RVA: 0x7ffaaf308c40
        public void GetHeight(){} // RVA: 0x7ffaaf308c90
        public void GetDepth(){} // RVA: 0x7ffaaf308ce0
        public void SetScriptingCallback(){} // RVA: 0x7ffaaf308d30
        public void GetDataRaw(){} // RVA: 0x7ffaaf308d90
        public void GetLayerCount_Injected(){} // RVA: 0x7ffaaf308ba0
        public void GetLayerDataSize_Injected(){} // RVA: 0x7ffaaf308bf0
        public void GetWidth_Injected(){} // RVA: 0x7ffaaf308c40
        public void GetHeight_Injected(){} // RVA: 0x7ffaaf308c90
        public void GetDepth_Injected(){} // RVA: 0x7ffaaf308ce0
        public void SetScriptingCallback_Injected(){} // RVA: 0x7ffaaf308d30
        public void GetDataRaw_Injected(){} // RVA: 0x7ffaaf308d90
    }

    public class AsyncRequestNativeArrayData : ValueType
    {
    }

    public class BatchCullingContext : ValueType
    {
        public object lodParameters; // 0x32CDA940
        public object projectionType; // 0x32CDA940
        public object cullingLayerMask; // 0x32CDA940
        public object receiverPlaneOffset; // 0x32CDA940

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf311d80
    }

    public class BatchID : ValueType
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaaf2771d0
        public void Equals(){} // RVA: 0x7ffaaf2771d0
        public void .cctor(){} // RVA: 0x7ffaaf311ae0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaae9b5f60
    }

    public class BatchMaterialID : ValueType
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaaf2771d0
        public void Equals(){} // RVA: 0x7ffaaf2771d0
        public void .cctor(){} // RVA: 0x7ffaaf311bc0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaae9b5f60
    }

    public class BatchMeshID : ValueType
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaaf2771d0
        public void Equals(){} // RVA: 0x7ffaaf2771d0
        public void .cctor(){} // RVA: 0x7ffaaf311ca0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaae9b5f60
    }

    public class BatchPackedCullingViewID : ValueType
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaaf311cf0
        public void Equals(){} // RVA: 0x7ffaaf311cf0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf311ce0
    }

    public class BatchRendererCullingOutput : ValueType
    {
        public object cullingPlanes; // 0x32CDAF70
        public object receiverPlaneCount; // 0x32CDAF70
        public object viewType; // 0x32CDAF70
        public object viewID; // 0x32CDAF70
        public object drawCommands; // 0x32CDAF70
    }

    public class BatchRendererGroup : Object
    {
        // ── Original Methods ──
        public void InvokeOnPerformCulling(){} // RVA: 0x7ffaaf311e30
    }

    public class CameraProperties : ValueType
    {
        public object projectionNear; // 0x32CDB270
        public object cameraFar; // 0x32CDB270
        public object actualWorldToClip; // 0x32CDB270
        public object implicitProjection; // 0x32CDB270
        public object worldToCamera; // 0x32CDB270
        public object transformDirection; // 0x32CDB270
        public object farPlaneWorldSpaceLength; // 0x32CDB270
        public object m_CameraCullPlanes; // 0x32CDB270
        public object layerCullDistances; // 0x32CDB270
        public object cameraType; // 0x32CDB270
        public object FixedElementField; // 0x331112A0
        public object filterMode; // 0x32CDB590

        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaaf313ff0
        public void Equals(){} // RVA: 0x7ffaaf313ff0
        // ── Binary Analysis Named ──
        public void GetShadowCullingPlane(){} // RVA: 0x7ffaaf312520
        public void GetCameraCullingPlane(){} // RVA: 0x7ffaaf312630
        public void GetHashCode(){} // RVA: 0x7ffaaf314130
    }

    public class CommandBuffer : Object
    {
        // ── Original Methods ──
        public void WaitAllAsyncReadbackRequests(){} // RVA: 0x7ffaaf30b070
        public void RequestAsyncReadback(){} // RVA: 0x7ffaaf30b190
        public void RequestAsyncReadback(){} // RVA: 0x7ffaaf30b190
        public void Internal_RequestAsyncReadback_4(){} // RVA: 0x7ffaaf30b270
        public void Internal_RequestAsyncReadback_5(){} // RVA: 0x7ffaaf30b300
        public void Internal_SetSinglePassStereo(){} // RVA: 0x7ffaaf30b390
        public void InitBuffer(){} // RVA: 0x7ffaaf30b3f0
        public void ReleaseBuffer(){} // RVA: 0x7ffaaf30b440
        public void Internal_SetComputeFloats(){} // RVA: 0x7ffaaf30b610
        public void Internal_SetComputeTextureParam(){} // RVA: 0x7ffaaf30b690
        public void Internal_SetComputeBufferParam(){} // RVA: 0x7ffaaf30b720
        public void Internal_DispatchCompute(){} // RVA: 0x7ffaaf30b7b0
        public void set_name(){} // RVA: 0x7ffaaf30b840
        public void Clear(){} // RVA: 0x7ffaaf30b8a0
        public void Internal_DrawMesh(){} // RVA: 0x7ffaaf30b8f0
        public void Internal_DrawRenderer(){} // RVA: 0x7ffaaf30b990
        public void Internal_DrawMeshInstancedIndirectGraphicsBuffer(){} // RVA: 0x7ffaaf30ba20
        public void CopyTexture_Internal(){} // RVA: 0x7ffaaf30bb10
        public void Blit_Texture(){} // RVA: 0x7ffaaf30bba0
        public void Blit_Identifier(){} // RVA: 0x7ffaaf30bc60
        public void ReleaseTemporaryRT(){} // RVA: 0x7ffaaf30c510
        public void ClearRenderTarget(){} // RVA: 0x7ffaaf30c600
        public void ClearRenderTarget(){} // RVA: 0x7ffaaf30c600
        public void EnableShaderKeyword(){} // RVA: 0x7ffaaf30c8c0
        public void DisableShaderKeyword(){} // RVA: 0x7ffaaf30c920
        public void ValidateAgainstExecutionFlags(){} // RVA: 0x7ffaaf30ca50
        public void EndSample(){} // RVA: 0x7ffaaf30cc10
        public void IssuePluginEventAndDataInternal(){} // RVA: 0x7ffaaf30cc70
        public void Finalize(){} // RVA: 0x7ffaaf30dc00
        public void Dispose(){} // RVA: 0x7ffaaf30dd30
        public void Dispose(){} // RVA: 0x7ffaaf30dd30
        public void .ctor(){} // RVA: 0x7ffaaf30dd90
        public void Release(){} // RVA: 0x7ffaaf30dde0
        public void DispatchCompute(){} // RVA: 0x7ffaaf30b7b0
        public void DrawMesh(){} // RVA: 0x7ffaaf30e810
        public void DrawMesh(){} // RVA: 0x7ffaaf30e810
        public void DrawRenderer(){} // RVA: 0x7ffaaf30ec20
        public void DrawRenderer(){} // RVA: 0x7ffaaf30ec20
        public void DrawRenderer(){} // RVA: 0x7ffaaf30ec20
        public void DrawMeshInstancedIndirect(){} // RVA: 0x7ffaaf30f0c0
        public void DrawMeshInstancedIndirect(){} // RVA: 0x7ffaaf30f0c0
        public void CopyTexture(){} // RVA: 0x7ffaaf30f1d0
        public void CopyTexture(){} // RVA: 0x7ffaaf30f1d0
        public void Blit(){} // RVA: 0x7ffaaf30f630
        public void Blit(){} // RVA: 0x7ffaaf30f630
        public void Blit(){} // RVA: 0x7ffaaf30f630
        public void Blit(){} // RVA: 0x7ffaaf30f630
        public void IssuePluginEventAndData(){} // RVA: 0x7ffaaf30f880
        public void Internal_DrawMesh_Injected(){} // RVA: 0x7ffaaf30fa20
        public void Blit_Texture_Injected(){} // RVA: 0x7ffaaf30fb10
        public void Blit_Identifier_Injected(){} // RVA: 0x7ffaaf30fba0
        public void ClearRenderTarget_Injected(){} // RVA: 0x7ffaaf30fcb0
        // ── Binary Analysis Named ──
        public void SetComputeFloatParam(){} // RVA: 0x7ffaaf30ddf0
        public void SetComputeIntParam(){} // RVA: 0x7ffaaf30deb0
        public void SetComputeVectorParam(){} // RVA: 0x7ffaaf30df70
        public void SetViewport(){} // RVA: 0x7ffaaf30bab0
        public void GetTemporaryRT(){} // RVA: 0x7ffaaf30c480
        public void GetTemporaryRT(){} // RVA: 0x7ffaaf30c480
        public void GetTemporaryRT(){} // RVA: 0x7ffaaf30c480
        public void GetTemporaryRT(){} // RVA: 0x7ffaaf30c480
        public void GetTemporaryRT(){} // RVA: 0x7ffaaf30c480
        public void GetTemporaryRT(){} // RVA: 0x7ffaaf30c480
        public void GetTemporaryRT(){} // RVA: 0x7ffaaf30c480
        public void GetTemporaryRT(){} // RVA: 0x7ffaaf30c480
        public void GetTemporaryRT(){} // RVA: 0x7ffaaf30c480
        public void GetTemporaryRTWithDescriptor(){} // RVA: 0x7ffaaf30c360
        public void GetTemporaryRT(){} // RVA: 0x7ffaaf30c480
        public void GetTemporaryRT(){} // RVA: 0x7ffaaf30c480
        public void SetGlobalFloat(){} // RVA: 0x7ffaaf30c700
        public void SetGlobalInteger(){} // RVA: 0x7ffaaf30c770
        public void SetGlobalVector(){} // RVA: 0x7ffaaf30c7e0
        public void SetGlobalColor(){} // RVA: 0x7ffaaf30c850
        public void SetViewProjectionMatrices(){} // RVA: 0x7ffaaf30c980
        public void SetExecutionFlags(){} // RVA: 0x7ffaaf30c9f0
        public void SetGlobalTexture_Impl(){} // RVA: 0x7ffaaf30cac0
        public void SetGlobalGraphicsBufferInternal(){} // RVA: 0x7ffaaf30cb40
        public void BeginSample(){} // RVA: 0x7ffaaf30cbb0
        public void SetRenderTarget(){} // RVA: 0x7ffaaf30d770
        public void SetRenderTarget(){} // RVA: 0x7ffaaf30d770
        public void SetRenderTarget(){} // RVA: 0x7ffaaf30d770
        public void SetRenderTarget(){} // RVA: 0x7ffaaf30d770
        public void SetRenderTarget(){} // RVA: 0x7ffaaf30d770
        public void SetRenderTarget(){} // RVA: 0x7ffaaf30d770
        public void SetRenderTarget(){} // RVA: 0x7ffaaf30d770
        public void SetRenderTargetSingle_Internal(){} // RVA: 0x7ffaaf30da00
        public void SetRenderTargetColorDepth_Internal(){} // RVA: 0x7ffaaf30daa0
        public void SetRenderTargetMulti_Internal(){} // RVA: 0x7ffaaf30db50
        public void SetComputeFloatParam(){} // RVA: 0x7ffaaf30ddf0
        public void SetComputeIntParam(){} // RVA: 0x7ffaaf30deb0
        public void SetComputeVectorParam(){} // RVA: 0x7ffaaf30df70
        public void SetComputeFloatParams(){} // RVA: 0x7ffaaf30e040
        public void SetComputeTextureParam(){} // RVA: 0x7ffaaf30e1e0
        public void SetComputeTextureParam(){} // RVA: 0x7ffaaf30e1e0
        public void SetComputeBufferParam(){} // RVA: 0x7ffaaf30e2c0
        public void SetGlobalTexture(){} // RVA: 0x7ffaaf30f860
        public void SetGlobalTexture(){} // RVA: 0x7ffaaf30f860
        public void SetGlobalTexture(){} // RVA: 0x7ffaaf30f860
        public void SetGlobalBuffer(){} // RVA: 0x7ffaaf30cb40
        public void SetSinglePassStereo(){} // RVA: 0x7ffaaf30b390
        public void SetComputeVectorParam_Injected(){} // RVA: 0x7ffaaf30f9a0
        public void SetViewport_Injected(){} // RVA: 0x7ffaaf30fab0
        public void GetTemporaryRTWithDescriptor_Injected(){} // RVA: 0x7ffaaf30fc30
        public void SetGlobalVector_Injected(){} // RVA: 0x7ffaaf30fd30
        public void SetGlobalColor_Injected(){} // RVA: 0x7ffaaf30fda0
        public void SetViewProjectionMatrices_Injected(){} // RVA: 0x7ffaaf30fe10
        public void SetRenderTargetSingle_Internal_Injected(){} // RVA: 0x7ffaaf30fe80
        public void SetRenderTargetColorDepth_Internal_Injected(){} // RVA: 0x7ffaaf30ff10
        public void SetRenderTargetMulti_Internal_Injected(){} // RVA: 0x7ffaaf30ffa0
    }

    public class CoreCameraValues : ValueType
    {
        public object instanceID; // 0x32CDB590
        public object System; // 0xB40D2C70

        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaaf312440
        public void Equals(){} // RVA: 0x7ffaaf312440
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf312500
    }

    public class CullingSplit : ValueType
    {
        public object cullingPlaneOffset; // 0x32CDB720
        public object nearPlane; // 0x32CDB720
        public object `Ǐf; // 0xAAD10AA0
    }

    public class GraphicsSettings : Object
    {
        // ── Original Methods ──
        public void get_lightsUseLinearIntensity(){} // RVA: 0x7ffaaf30ac30
        public void get_defaultRenderingLayerMask(){} // RVA: 0x7ffaaf30ac80
        public void get_INTERNAL_currentRenderPipeline(){} // RVA: 0x7ffaaf30acd0
        public void get_currentRenderPipeline(){} // RVA: 0x7ffaaf30ad20
        public void get_INTERNAL_defaultRenderPipeline(){} // RVA: 0x7ffaaf30ade0
        public void get_defaultRenderPipeline(){} // RVA: 0x7ffaaf30ae30
        // ── Binary Analysis Named ──
        public void GetShaderMode(){} // RVA: 0x7ffaaf30aef0
    }

    public class LODParameters : ValueType
    {
        public object m_FieldOfView; // 0x331103A0
        public object handle; // 0x33110D40
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaaf315750
        public void Equals(){} // RVA: 0x7ffaaf315750
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf315800
    }

    public class LocalKeyword : ValueType
    {
        public object m_Index; // 0x32CDBB50

        // ── Original Methods ──
        public void ToString(){} // RVA: 0x7ffaae0d5d90
        public void Equals(){} // RVA: 0x7ffaaf318b60
        public void Equals(){} // RVA: 0x7ffaaf318b60
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf318bb0
    }

    public class LocalKeywordSpace : ValueType
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaac3d9550
        public void Equals(){} // RVA: 0x7ffaac3d9550
        public void op_Equality(){} // RVA: 0x7ffaaf318c40
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaae9b5f60
    }

    public class OnDemandRendering : Object
    {
        // ── Original Methods ──
        public void get_renderFrameInterval(){} // RVA: 0x7ffaaf30af40
        public void .cctor(){} // RVA: 0x7ffaaf30b030
        // ── Binary Analysis Named ──
        public void GetRenderFrameInterval(){} // RVA: 0x7ffaaf30afa0
    }

    public class ReflectionProbeBlendInfo : ValueType
    {
    }

    public class RenderPipeline : Object
    {
        // ── Original Methods ──
        public void Render(){} // RVA: 0x7ffaaf3158c0
        public void ProcessRenderRequests(){} // RVA: 0x7ffaa887e5c0
        public void IsRenderRequestSupported(){} // RVA: 0x7ffaa887e5c0
        public void Render(){} // RVA: 0x7ffaaf3158c0
        public void InternalRender(){} // RVA: 0x7ffaaf315940
        public void InternalProcessRenderRequests(){} // RVA: 0x7ffaa887e5c0
        public void get_disposed(){} // RVA: 0x7ffaa89fc5e0
        public void set_disposed(){} // RVA: 0x7ffaa89fc5f0
        public void Dispose(){} // RVA: 0x7ffaa8932310
        public void Dispose(){} // RVA: 0x7ffaa8932310
    }

    public class RenderPipelineManager : Object
    {
        public object s_CurrentPipelineType; // 0x32CE01B0
        public object endCameraRendering; // 0x32CE01B0
        public object activeRenderPipelineCreated; // 0x32CE01B0

        // ── Original Methods ──
        public void get_currentPipeline(){} // RVA: 0x7ffaaf315e20
        public void set_currentPipeline(){} // RVA: 0x7ffaaf315e80
        public void add_beginCameraRendering(){} // RVA: 0x7ffaaf316010
        public void remove_beginCameraRendering(){} // RVA: 0x7ffaaf316170
        public void add_endCameraRendering(){} // RVA: 0x7ffaaf3162d0
        public void remove_endCameraRendering(){} // RVA: 0x7ffaaf316430
        public void OnActiveRenderPipelineTypeChanged(){} // RVA: 0x7ffaaf316590
        public void OnActiveRenderPipelineAssetChanged(){} // RVA: 0x7ffaaf316600
        public void HandleRenderPipelineChange(){} // RVA: 0x7ffaaf316710
        public void CleanupRenderPipeline(){} // RVA: 0x7ffaaf3167f0
        public void PrepareRenderPipeline(){} // RVA: 0x7ffaaf316fd0
        public void IsPipelineRequireCreation(){} // RVA: 0x7ffaaf317290
        public void .cctor(){} // RVA: 0x7ffaaf3173f0
        // ── Binary Analysis Named ──
        public void GetCurrentPipelineAssetType(){} // RVA: 0x7ffaaf316ad0
        public void DoRenderLoop_Internal(){} // RVA: 0x7ffaaf316b30
    }

    public class ScriptableCullingParameters : ValueType
    {
        public object maximumCullingPlaneCount; // 0x32CE0330
        public object m_CullingMask; // 0x32CE0330
        public object layerCount; // 0x32CE0330
        public object m_CullingMatrix; // 0x32CE0330
        public object m_ShadowNearPlaneOffset; // 0x32CE0330
        public object m_CameraProperties; // 0x32CE0330
        public object m_StereoViewMatrix; // 0x32CE0330
        public object m_maximumVisibleLights; // 0x32CE0330
        public object FixedElementField; // 0x33111A60
        public object IEquatable`1; // 0xB40D0AB0

        // ── Original Methods ──
        public void get_cullingPlaneCount(){} // RVA: 0x7ffaaf314990
        public void Equals(){} // RVA: 0x7ffaaf3152f0
        public void Equals(){} // RVA: 0x7ffaaf3152f0
        public void .cctor(){} // RVA: 0x7ffaaf315620
        // ── Binary Analysis Named ──
        public void GetLayerCullingDistance(){} // RVA: 0x7ffaaf3149a0
        public void GetCullingPlane(){} // RVA: 0x7ffaaf314aa0
        public void GetHashCode(){} // RVA: 0x7ffaaf3153c0
    }

    public class ScriptableRenderContext : ValueType
    {
        public object m_Id; // 0x84017B10

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9fe08a0
        public void Equals(){} // RVA: 0x7ffaaf317830
        public void Equals(){} // RVA: 0x7ffaaf317830
        public void .cctor(){} // RVA: 0x7ffaaf3178d0
        // ── Binary Analysis Named ──
        public void GetCameras_Internal(){} // RVA: 0x7ffaaf3175c0
        public void GetCameras(){} // RVA: 0x7ffaaf317670
        public void GetHashCode(){} // RVA: 0x7ffaae9b5f60
        public void GetCameras_Internal_Injected(){} // RVA: 0x7ffaaf317970
    }

    public class SortingGroup : Behaviour
    {
        // ── Original Methods ──
        public void get_invalidSortingGroupID(){} // RVA: 0x7ffaaf318c50
        public void UpdateAllSortingGroups(){} // RVA: 0x7ffaaf318ca0
        public void get_sortingLayerName(){} // RVA: 0x7ffaaf318d40
        public void set_sortingLayerName(){} // RVA: 0x7ffaaf318d90
        public void get_sortingLayerID(){} // RVA: 0x7ffaaf318df0
        public void set_sortingLayerID(){} // RVA: 0x7ffaaf318e40
        public void get_sortingOrder(){} // RVA: 0x7ffaaf318ea0
        public void set_sortingOrder(){} // RVA: 0x7ffaaf318ef0
        public void get_sortAtRoot(){} // RVA: 0x7ffaaf318f50
        public void set_sortAtRoot(){} // RVA: 0x7ffaaf318fa0
        public void get_sortingGroupID(){} // RVA: 0x7ffaaf319000
        public void get_sortingGroupOrder(){} // RVA: 0x7ffaaf319050
        public void get_index(){} // RVA: 0x7ffaaf3190a0
        public void get_sortingKey(){} // RVA: 0x7ffaaf3190f0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetSortingGroupByIndex(){} // RVA: 0x7ffaaf318cf0
    }

    public class SphericalHarmonicsL2 : ValueType
    {
        public object shr2; // 0x32CE04C0
        public object shr5; // 0x32CE04C0
        public object shr8; // 0x32CE04C0
        public object shg2; // 0x32CE04C0
        public object shg5; // 0x32CE04C0
        public object shg8; // 0x32CE04C0
        public object shb2; // 0x32CE04C0
        public object shb5; // 0x32CE04C0
        public object shb8; // 0x32CE04C0
        public object System; // 0xB40D01B0
        public object 0; // 0x33143590

        // ── Original Methods ──
        public void Clear(){} // RVA: 0x7ffaaf310030
        public void AddAmbientLight(){} // RVA: 0x7ffaaf310080
        public void AddDirectionalLight(){} // RVA: 0x7ffaaf3100e0
        public void AddDirectionalLightInternal(){} // RVA: 0x7ffaaf3101a0
        public void Evaluate(){} // RVA: 0x7ffaaf310210
        public void EvaluateInternal(){} // RVA: 0x7ffaaf310380
        public void get_Item(){} // RVA: 0x7ffaaf3103f0
        public void set_Item(){} // RVA: 0x7ffaaf3105f0
        public void Equals(){} // RVA: 0x7ffaaf310c80
        public void Equals(){} // RVA: 0x7ffaaf310c80
        public void op_Multiply(){} // RVA: 0x7ffaaf311040
        public void op_Multiply(){} // RVA: 0x7ffaaf311040
        public void op_Addition(){} // RVA: 0x7ffaaf311350
        public void op_Equality(){} // RVA: 0x7ffaaf311690
        public void op_Inequality(){} // RVA: 0x7ffaaf3118b0
        public void AddAmbientLight_Injected(){} // RVA: 0x7ffaaf311970
        public void AddDirectionalLightInternal_Injected(){} // RVA: 0x7ffaaf3119d0
        // ── Binary Analysis Named ──
        public void SetZero(){} // RVA: 0x7ffaaf310030
        public void GetHashCode(){} // RVA: 0x7ffaaf3107f0
        public void SetZero_Injected(){} // RVA: 0x7ffaaf310030
    }

    public class SupportedRenderingFeatures : Object
    {
        public object _defaultMixedLightingModes; // 0x32CE0650, was: <defaultMixedLightingModes>k__
        public object _lightmapsModes; // 0x32CE0650, was: <lightmapsModes>k__BackingFiel
        public object _lightProbeProxyVolumes; // 0x32CE0650, was: <lightProbeProxyVolumes>k__Bac
        public object _reflectionProbes; // 0x32CE0650, was: <reflectionProbes>k__BackingFi
        public object _rendersUIOverlay; // 0x32CE0650, was: <rendersUIOverlay>k__BackingFi
        public object _overridesRealtimeReflectionProbes; // 0x32CE0650, was: <overridesRealtimeReflectionPr
        public object _overridesLODBias; // 0x32CE0650, was: <overridesLODBias>k__BackingFi
        public object _rendererProbes; // 0x32CE0650, was: <rendererProbes>k__BackingFiel
        public object _autoDefaultReflectionProbeBaking; // 0x32CE0650, was: <autoDefaultReflectionProbeBak
        public object _supportsHDR; // 0x32CE0650, was: <supportsHDR>k__BackingField
        public object active; // 0x1700044A
        public object defaultMixedLightingModes; // 0x1700044B
        public object mixedLightingModes; // 0x1700044C
        public object lightmapBakeTypes; // 0x1700044D
        public object lightmapsModes; // 0x1700044E
        public object enlightenLightmapper; // 0x1700044F
        public object enlighten; // 0x17000450
        public object rendersUIOverlay; // 0x17000451
        public object autoAmbientProbeBaking; // 0x17000452
        public object autoDefaultReflectionProbeBaking; // 0x17000453

        // ── Original Methods ──
        public void get_active(){} // RVA: 0x7ffaaf317dc0
        public void set_active(){} // RVA: 0x7ffaaf317ee0
        public void get_defaultMixedLightingModes(){} // RVA: 0x7ffaa8e046c0
        public void get_mixedLightingModes(){} // RVA: 0x7ffaa8b945a0
        public void get_lightmapBakeTypes(){} // RVA: 0x7ffaa9e5ac10
        public void get_lightmapsModes(){} // RVA: 0x7ffaa8aeced0
        public void get_enlightenLightmapper(){} // RVA: 0x7ffaa894d7c0
        public void get_enlighten(){} // RVA: 0x7ffaa99cb670
        public void get_rendersUIOverlay(){} // RVA: 0x7ffaa8a11230
        public void get_autoAmbientProbeBaking(){} // RVA: 0x7ffaaa150730
        public void get_autoDefaultReflectionProbeBaking(){} // RVA: 0x7ffaa8bfcc70
        public void get_overridesLightProbeSystem(){} // RVA: 0x7ffaa99a3bf0
        public void FallbackMixedLightingModeByRef(){} // RVA: 0x7ffaaf317f90
        public void IsMixedLightingModeSupported(){} // RVA: 0x7ffaaf3181c0
        public void IsMixedLightingModeSupportedByRef(){} // RVA: 0x7ffaaf318330
        public void IsLightmapBakeTypeSupported(){} // RVA: 0x7ffaaf318490
        public void IsLightmapBakeTypeSupportedByRef(){} // RVA: 0x7ffaaf3185c0
        public void IsLightmapsModeSupportedByRef(){} // RVA: 0x7ffaaf3186c0
        public void IsLightmapperSupportedByRef(){} // RVA: 0x7ffaaf318730
        public void IsUIOverlayRenderedBySRP(){} // RVA: 0x7ffaaf3187b0
        public void IsAutoAmbientProbeBakingSupported(){} // RVA: 0x7ffaaf318810
        public void IsAutoDefaultReflectionProbeBakingSupported(){} // RVA: 0x7ffaaf318870
        public void OverridesLightProbeSystem(){} // RVA: 0x7ffaaf3188d0
        public void FallbackLightmapperByRef(){} // RVA: 0x7ffaaa4039c0
        public void .ctor(){} // RVA: 0x7ffaaf318930
        public void .cctor(){} // RVA: 0x7ffaaf318a00
    }

    public class VertexAttributeDescriptor : ValueType
    {
        public object _dimension; // 0x32CE07D0, was: <dimension>k__BackingField

        // ── Original Methods ──
        public void get_attribute(){} // RVA: 0x7ffaa9e47550
        public void set_attribute(){} // RVA: 0x7ffaa8d92880
        public void get_format(){} // RVA: 0x7ffaa9e47530
        public void set_format(){} // RVA: 0x7ffaa9e475c0
        public void get_dimension(){} // RVA: 0x7ffaaa3cef80
        public void set_dimension(){} // RVA: 0x7ffaaa3cef90
        public void get_stream(){} // RVA: 0x7ffaaa3cefa0
        public void set_stream(){} // RVA: 0x7ffaaa3cefb0
        public void .ctor(){} // RVA: 0x7ffaadd40830
        public void ToString(){} // RVA: 0x7ffaaf30a020
        public void Equals(){} // RVA: 0x7ffaaf289930
        public void Equals(){} // RVA: 0x7ffaaf289930
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf30a280
    }

}