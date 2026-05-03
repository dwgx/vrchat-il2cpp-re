// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering
// Classes: 40
// Methods: 388

namespace ThirdParty.Unity.UnityEngine.Rendering
{
    public class AsyncGPUReadback : Object
    {
        // ── Methods ──
        public void ValidateFormat(){} // RVA: 0x7FFE87C8F5C0
        public void WaitAllRequests(){} // RVA: 0x7FFE87C8F750
        public void Request(){} // RVA: 0x7FFE87C8FDE0 | overloaded x6
        public void Request_Internal_Texture_1(){} // RVA: 0x7FFE87C8FF50
        public void Request_Internal_Texture_2(){} // RVA: 0x7FFE87C8FFE0
        public void Request_Internal_Texture_3(){} // RVA: 0x7FFE87C90070
        public void Request_Internal_Texture_4(){} // RVA: 0x7FFE87C90140
        public void Request_Internal_Texture_1_Injected(){} // RVA: 0x7FFE87C90220
        public void Request_Internal_Texture_2_Injected(){} // RVA: 0x7FFE87C902A0
        public void Request_Internal_Texture_3_Injected(){} // RVA: 0x7FFE87C90320
        public void Request_Internal_Texture_4_Injected(){} // RVA: 0x7FFE87C903A0
    }

    public class AsyncGPUReadbackRequest : ValueType
    {
        public UIntPtr m_Ptr; // 0x10
        public int m_Version; // 0x18
        public object field_2; // 0xB648
        public object field_3; // 0xB6A0
        public object field_4; // 0xB6F8
        public object field_5; // 0xB750
        public object field_6; // 0xB7A8

        // ── Methods ──
        public void GetData(){} // RVA: 0x7FFE810A1420
        public void get_done(){} // RVA: 0x7FFE87C8F2D0
        public void get_hasError(){} // RVA: 0x7FFE87C8F320
        public void get_layerCount(){} // RVA: 0x7FFE87C8F370
        public void get_layerDataSize(){} // RVA: 0x7FFE87C8F3C0
        public void get_width(){} // RVA: 0x7FFE87C8F410
        public void get_height(){} // RVA: 0x7FFE87C8F460
        public void get_depth(){} // RVA: 0x7FFE87C8F4B0
        public void IsDone(){} // RVA: 0x7FFE87C8F2D0
        public void HasError(){} // RVA: 0x7FFE87C8F320
        public void GetLayerCount(){} // RVA: 0x7FFE87C8F370
        public void GetLayerDataSize(){} // RVA: 0x7FFE87C8F3C0
        public void GetWidth(){} // RVA: 0x7FFE87C8F410
        public void GetHeight(){} // RVA: 0x7FFE87C8F460
        public void GetDepth(){} // RVA: 0x7FFE87C8F4B0
        public void SetScriptingCallback(){} // RVA: 0x7FFE87C8F500
        public void GetDataRaw(){} // RVA: 0x7FFE87C8F560
        public void IsDone_Injected(){} // RVA: 0x7FFE87C8F2D0
        public void HasError_Injected(){} // RVA: 0x7FFE87C8F320
        public void GetLayerCount_Injected(){} // RVA: 0x7FFE87C8F370
        public void GetLayerDataSize_Injected(){} // RVA: 0x7FFE87C8F3C0
        public void GetWidth_Injected(){} // RVA: 0x7FFE87C8F410
        public void GetHeight_Injected(){} // RVA: 0x7FFE87C8F460
        public void GetDepth_Injected(){} // RVA: 0x7FFE87C8F4B0
        public void SetScriptingCallback_Injected(){} // RVA: 0x7FFE87C8F500
        public void GetDataRaw_Injected(){} // RVA: 0x7FFE87C8F560
    }

    public class AsyncRequestNativeArrayData : ValueType
    {
    }

    public class BatchCullingContext : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C986C0
    }

    public class BatchCullingOutput : ValueType
    {
    }

    public class BatchCullingOutputDrawCommands : ValueType
    {
    }

    public class BatchDrawCommand : ValueType
    {
    }

    public class BatchDrawRange : ValueType
    {
    }

    public class BatchFilterSettings : ValueType
    {
    }

    public class BatchID : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFE8733C3B0
        public void Equals(){} // RVA: 0x7FFE87BFD7C0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87C98420
    }

    public class BatchMaterialID : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFE8733C3B0
        public void Equals(){} // RVA: 0x7FFE87BFD7C0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87C98500
    }

    public class BatchMeshID : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFE8733C3B0
        public void Equals(){} // RVA: 0x7FFE87BFD7C0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87C985E0
    }

    public class BatchPackedCullingViewID : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFE87C98620
        public void Equals(){} // RVA: 0x7FFE87C98630 | overloaded x2
    }

    public class BatchRendererCullingOutput : ValueType
    {
    }

    public class BatchRendererGroup : Object
    {
        // ── Methods ──
        public void InvokeOnPerformCulling(){} // RVA: 0x7FFE87C98770
    }

    public class CameraEventUtils : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE87C90430
    }

    public class CameraProperties : ValueType
    {
        // ── Methods ──
        public void GetShadowCullingPlane(){} // RVA: 0x7FFE87C98E60
        public void GetCameraCullingPlane(){} // RVA: 0x7FFE87C98F70
        public void Equals(){} // RVA: 0x7FFE87C9A930 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87C9AA70
    }

    public class CommandBuffer : Object
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void WaitAllAsyncReadbackRequests(){} // RVA: 0x7FFE87C91840
        public void RequestAsyncReadback(){} // RVA: 0x7FFE87C91A40 | overloaded x3
        public void Internal_RequestAsyncReadback_4(){} // RVA: 0x7FFE87C91B20
        public void Internal_RequestAsyncReadback_5(){} // RVA: 0x7FFE87C91BB0
        public void Internal_RequestAsyncReadback_6(){} // RVA: 0x7FFE87C91C40
        public void Internal_SetSinglePassStereo(){} // RVA: 0x7FFE87C91CD0
        public void InitBuffer(){} // RVA: 0x7FFE87C91D30
        public void ReleaseBuffer(){} // RVA: 0x7FFE87C91D80
        public void SetComputeFloatParam(){} // RVA: 0x7FFE87C94730 | overloaded x2
        public void SetComputeIntParam(){} // RVA: 0x7FFE87C947F0 | overloaded x2
        public void SetComputeVectorParam(){} // RVA: 0x7FFE87C948B0 | overloaded x2
        public void Internal_SetComputeFloats(){} // RVA: 0x7FFE87C91F50
        public void Internal_SetComputeTextureParam(){} // RVA: 0x7FFE87C91FD0
        public void Internal_SetComputeBufferParam(){} // RVA: 0x7FFE87C92060
        public void Internal_DispatchCompute(){} // RVA: 0x7FFE87C920F0
        public void set_name(){} // RVA: 0x7FFE87C92180
        public void Clear(){} // RVA: 0x7FFE87C921E0
        public void Internal_DrawMesh(){} // RVA: 0x7FFE87C92230
        public void Internal_DrawRenderer(){} // RVA: 0x7FFE87C922D0
        public void Internal_DrawMeshInstancedIndirectGraphicsBuffer(){} // RVA: 0x7FFE87C92360
        public void SetViewport(){} // RVA: 0x7FFE87C923F0
        public void CopyTexture_Internal(){} // RVA: 0x7FFE87C92450
        public void Blit_Texture(){} // RVA: 0x7FFE87C924E0
        public void Blit_Identifier(){} // RVA: 0x7FFE87C925A0
        public void GetTemporaryRT(){} // RVA: 0x7FFE87C92DC0 | overloaded x11
        public void GetTemporaryRTWithDescriptor(){} // RVA: 0x7FFE87C92CA0
        public void ReleaseTemporaryRT(){} // RVA: 0x7FFE87C92E50
        public void ClearRenderTarget(){} // RVA: 0x7FFE87C92F40 | overloaded x2
        public void SetGlobalFloat(){} // RVA: 0x7FFE87C93040
        public void SetGlobalInteger(){} // RVA: 0x7FFE87C930B0
        public void SetGlobalVector(){} // RVA: 0x7FFE87C93120
        public void SetGlobalColor(){} // RVA: 0x7FFE87C93190
        public void EnableShaderKeyword(){} // RVA: 0x7FFE87C93200
        public void DisableShaderKeyword(){} // RVA: 0x7FFE87C93260
        public void SetViewProjectionMatrices(){} // RVA: 0x7FFE87C932C0
        public void SetExecutionFlags(){} // RVA: 0x7FFE87C93330
        public void ValidateAgainstExecutionFlags(){} // RVA: 0x7FFE87C93390
        public void SetGlobalTexture_Impl(){} // RVA: 0x7FFE87C93400
        public void SetGlobalGraphicsBufferInternal(){} // RVA: 0x7FFE87C93480
        public void BeginSample(){} // RVA: 0x7FFE87C934F0
        public void EndSample(){} // RVA: 0x7FFE87C93550
        public void IssuePluginEventAndDataInternal(){} // RVA: 0x7FFE87C935B0
        public void SetRenderTarget(){} // RVA: 0x7FFE87C940B0 | overloaded x7
        public void SetRenderTargetSingle_Internal(){} // RVA: 0x7FFE87C94340
        public void SetRenderTargetColorDepth_Internal(){} // RVA: 0x7FFE87C943E0
        public void SetRenderTargetMulti_Internal(){} // RVA: 0x7FFE87C94490
        public void Finalize(){} // RVA: 0x7FFE87C94540
        public void Dispose(){} // RVA: 0x7FFE87C94670 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE87C946D0
        public void Release(){} // RVA: 0x7FFE87C94720
        public void SetComputeFloatParams(){} // RVA: 0x7FFE87C94980
        public void SetComputeTextureParam(){} // RVA: 0x7FFE87C94B20 | overloaded x2
        public void SetComputeBufferParam(){} // RVA: 0x7FFE87C94C00
        public void DispatchCompute(){} // RVA: 0x7FFE87C920F0
        public void DrawMesh(){} // RVA: 0x7FFE87C95150 | overloaded x2
        public void DrawRenderer(){} // RVA: 0x7FFE87C95560 | overloaded x3
        public void DrawMeshInstancedIndirect(){} // RVA: 0x7FFE87C95A00 | overloaded x2
        public void CopyTexture(){} // RVA: 0x7FFE87C95B10 | overloaded x2
        public void Blit(){} // RVA: 0x7FFE87C95F70 | overloaded x4
        public void SetGlobalTexture(){} // RVA: 0x7FFE87C961A0 | overloaded x3
        public void SetGlobalBuffer(){} // RVA: 0x7FFE87C93480
        public void SetSinglePassStereo(){} // RVA: 0x7FFE87C91CD0
        public void IssuePluginEventAndData(){} // RVA: 0x7FFE87C961C0
        public void SetComputeVectorParam_Injected(){} // RVA: 0x7FFE87C962E0
        public void Internal_DrawMesh_Injected(){} // RVA: 0x7FFE87C96360
        public void SetViewport_Injected(){} // RVA: 0x7FFE87C963F0
        public void Blit_Texture_Injected(){} // RVA: 0x7FFE87C96450
        public void Blit_Identifier_Injected(){} // RVA: 0x7FFE87C964E0
        public void GetTemporaryRTWithDescriptor_Injected(){} // RVA: 0x7FFE87C96570
        public void ClearRenderTarget_Injected(){} // RVA: 0x7FFE87C965F0
        public void SetGlobalVector_Injected(){} // RVA: 0x7FFE87C96670
        public void SetGlobalColor_Injected(){} // RVA: 0x7FFE87C966E0
        public void SetViewProjectionMatrices_Injected(){} // RVA: 0x7FFE87C96750
        public void SetRenderTargetSingle_Internal_Injected(){} // RVA: 0x7FFE87C967C0
        public void SetRenderTargetColorDepth_Internal_Injected(){} // RVA: 0x7FFE87C96850
        public void SetRenderTargetMulti_Internal_Injected(){} // RVA: 0x7FFE87C968E0
    }

    public class CoreCameraValues : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE87C98D80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87C98E40
    }

    public class CullingSplit : ValueType
    {
    }

    public class GraphicsSettings : Object
    {
        // ── Methods ──
        public void get_lightsUseLinearIntensity(){} // RVA: 0x7FFE87C91400
        public void get_defaultRenderingLayerMask(){} // RVA: 0x7FFE87C91450
        public void get_INTERNAL_currentRenderPipeline(){} // RVA: 0x7FFE87C914A0
        public void get_currentRenderPipeline(){} // RVA: 0x7FFE87C914F0
        public void get_INTERNAL_defaultRenderPipeline(){} // RVA: 0x7FFE87C915B0
        public void get_defaultRenderPipeline(){} // RVA: 0x7FFE87C91600
        public void GetShaderMode(){} // RVA: 0x7FFE87C916C0
    }

    public class LODParameters : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE87C9C090 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87C9C140
    }

    public class LocalKeyword : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE86A5E330
        public void Equals(){} // RVA: 0x7FFE87C9F4A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87C9F4F0
    }

    public class LocalKeywordSpace : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE84D2A4E0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87C9F580
        public void GetHashCode(){} // RVA: 0x7FFE8733C3B0
    }

    public class ObjectIdRequest : Object
    {
        public UnityEngine.RenderTexture _destination; // 0x10

        // ── Methods ──
        public void get_destination(){} // RVA: 0x7FFE81116380
    }

    public class OnDemandRendering : Object
    {
        public int m_RenderFrameInterval;

        // ── Methods ──
        public void get_renderFrameInterval(){} // RVA: 0x7FFE87C91710
        public void GetRenderFrameInterval(){} // RVA: 0x7FFE87C91770
        public void .cctor(){} // RVA: 0x7FFE87C91800
    }

    public class ReflectionProbeBlendInfo : ValueType
    {
    }

    public class RenderPipeline : Object
    {
        public bool _disposed; // 0x10

        // ── Methods ──
        public void Render(){} // RVA: 0x7FFE87C9C200 | overloaded x2
        public void ProcessRenderRequests(){} // RVA: 0x7FFE810A1420
        public void IsRenderRequestSupported(){} // RVA: 0x7FFE810A1420
        public void InternalRender(){} // RVA: 0x7FFE87C9C280
        public void InternalProcessRenderRequests(){} // RVA: 0x7FFE810A1420
        public void get_disposed(){} // RVA: 0x7FFE811C55E0
        public void set_disposed(){} // RVA: 0x7FFE811C55F0
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
    }

    public class RenderPipelineAsset : ScriptableObject
    {
        // ── Methods ──
        public void InternalCreatePipeline(){} // RVA: 0x7FFE87C9C380
        public void get_renderingLayerMaskNames(){} // RVA: 0x7FFE813240E0
        public void get_prefixedRenderingLayerMaskNames(){} // RVA: 0x7FFE813240E0
        public void get_defaultMaterial(){} // RVA: 0x7FFE813240E0
        public void get_autodeskInteractiveShader(){} // RVA: 0x7FFE813240E0
        public void get_autodeskInteractiveTransparentShader(){} // RVA: 0x7FFE813240E0
        public void get_autodeskInteractiveMaskedShader(){} // RVA: 0x7FFE813240E0
        public void get_terrainDetailLitShader(){} // RVA: 0x7FFE813240E0
        public void get_terrainDetailGrassShader(){} // RVA: 0x7FFE813240E0
        public void get_terrainDetailGrassBillboardShader(){} // RVA: 0x7FFE813240E0
        public void get_defaultParticleMaterial(){} // RVA: 0x7FFE813240E0
        public void get_defaultLineMaterial(){} // RVA: 0x7FFE813240E0
        public void get_defaultTerrainMaterial(){} // RVA: 0x7FFE813240E0
        public void get_defaultUIMaterial(){} // RVA: 0x7FFE813240E0
        public void get_defaultUIOverdrawMaterial(){} // RVA: 0x7FFE813240E0
        public void get_defaultUIETC1SupportedMaterial(){} // RVA: 0x7FFE813240E0
        public void get_default2DMaterial(){} // RVA: 0x7FFE813240E0
        public void get_default2DMaskMaterial(){} // RVA: 0x7FFE813240E0
        public void get_defaultShader(){} // RVA: 0x7FFE813240E0
        public void get_defaultSpeedTree7Shader(){} // RVA: 0x7FFE813240E0
        public void get_defaultSpeedTree8Shader(){} // RVA: 0x7FFE813240E0
        public void get_renderPipelineShaderTag(){} // RVA: 0x7FFE87C9C560
        public void CreatePipeline(){} // RVA: 0x7FFE80E2E2E0
        public void OnValidate(){} // RVA: 0x7FFE87C9C5A0
        public void OnDisable(){} // RVA: 0x7FFE87C9C710
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class RenderPipelineManager : Object
    {
        public UnityEngine.Rendering.RenderPipelineAsset s_CurrentPipelineAsset;

        // ── Methods ──
        public void get_currentPipeline(){} // RVA: 0x7FFE87C9C760
        public void set_currentPipeline(){} // RVA: 0x7FFE87C9C7C0
        public void add_beginCameraRendering(){} // RVA: 0x7FFE87C9C950
        public void remove_beginCameraRendering(){} // RVA: 0x7FFE87C9CAB0
        public void add_endCameraRendering(){} // RVA: 0x7FFE87C9CC10
        public void remove_endCameraRendering(){} // RVA: 0x7FFE87C9CD70
        public void OnActiveRenderPipelineTypeChanged(){} // RVA: 0x7FFE87C9CED0
        public void OnActiveRenderPipelineAssetChanged(){} // RVA: 0x7FFE87C9CF40
        public void HandleRenderPipelineChange(){} // RVA: 0x7FFE87C9D050
        public void CleanupRenderPipeline(){} // RVA: 0x7FFE87C9D130
        public void GetCurrentPipelineAssetType(){} // RVA: 0x7FFE87C9D410
        public void DoRenderLoop_Internal(){} // RVA: 0x7FFE87C9D470
        public void PrepareRenderPipeline(){} // RVA: 0x7FFE87C9D910
        public void IsPipelineRequireCreation(){} // RVA: 0x7FFE87C9DBD0
        public void .cctor(){} // RVA: 0x7FFE87C9DD30
    }

    public class RenderTargetIdentifier : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C90D80 | overloaded x5
        public void op_Implicit(){} // RVA: 0x7FFE87C90EB0 | overloaded x4
        public void ToString(){} // RVA: 0x7FFE87C90F10
        public void GetHashCode(){} // RVA: 0x7FFE87C91250
        public void Equals(){} // RVA: 0x7FFE87C912F0 | overloaded x2
    }

    public class ScriptableCullingParameters : ValueType
    {
        public int m_IsOrthographic; // 0x10

        // ── Methods ──
        public void get_cullingPlaneCount(){} // RVA: 0x7FFE87C9B2D0
        public void GetLayerCullingDistance(){} // RVA: 0x7FFE87C9B2E0
        public void GetCullingPlane(){} // RVA: 0x7FFE87C9B3E0
        public void Equals(){} // RVA: 0x7FFE87C9BC30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87C9BD00
        public void .cctor(){} // RVA: 0x7FFE87C9BF60
    }

    public class ScriptableRenderContext : ValueType
    {
        // ── Methods ──
        public void GetCameras_Internal(){} // RVA: 0x7FFE87C9DF00
        public void .ctor(){} // RVA: 0x7FFE82889220
        public void GetCameras(){} // RVA: 0x7FFE87C9DFB0
        public void Equals(){} // RVA: 0x7FFE87C9E170 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8733C3B0
        public void .cctor(){} // RVA: 0x7FFE87C9E210
        public void GetCameras_Internal_Injected(){} // RVA: 0x7FFE87C9E2B0
    }

    public class ShaderTagId : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C9E320
        public void Equals(){} // RVA: 0x7FFE87BFD7C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87C9E400
    }

    public class SortingGroup : Behaviour
    {
        // ── Methods ──
        public void get_invalidSortingGroupID(){} // RVA: 0x7FFE87C9F590
        public void UpdateAllSortingGroups(){} // RVA: 0x7FFE87C9F5E0
        public void GetSortingGroupByIndex(){} // RVA: 0x7FFE87C9F630
        public void get_sortingLayerName(){} // RVA: 0x7FFE87C9F680
        public void set_sortingLayerName(){} // RVA: 0x7FFE87C9F6D0
        public void get_sortingLayerID(){} // RVA: 0x7FFE87C9F730
        public void set_sortingLayerID(){} // RVA: 0x7FFE87C9F780
        public void get_sortingOrder(){} // RVA: 0x7FFE87C9F7E0
        public void set_sortingOrder(){} // RVA: 0x7FFE87C9F830
        public void get_sortAtRoot(){} // RVA: 0x7FFE87C9F890
        public void set_sortAtRoot(){} // RVA: 0x7FFE87C9F8E0
        public void get_sortingGroupID(){} // RVA: 0x7FFE87C9F940
        public void get_sortingGroupOrder(){} // RVA: 0x7FFE87C9F990
        public void get_index(){} // RVA: 0x7FFE87C9F9E0
        public void get_sortingKey(){} // RVA: 0x7FFE87C9FA30
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SphericalHarmonicsL2 : ValueType
    {
        public float shr0; // 0x10

        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFE87C96970
        public void SetZero(){} // RVA: 0x7FFE87C96970
        public void AddAmbientLight(){} // RVA: 0x7FFE87C969C0
        public void AddDirectionalLight(){} // RVA: 0x7FFE87C96A20
        public void AddDirectionalLightInternal(){} // RVA: 0x7FFE87C96AE0
        public void Evaluate(){} // RVA: 0x7FFE87C96B50
        public void EvaluateInternal(){} // RVA: 0x7FFE87C96CC0
        public void get_Item(){} // RVA: 0x7FFE87C96D30
        public void set_Item(){} // RVA: 0x7FFE87C96F30
        public void GetHashCode(){} // RVA: 0x7FFE87C97130
        public void Equals(){} // RVA: 0x7FFE87C975C0 | overloaded x2
        public void op_Multiply(){} // RVA: 0x7FFE87C97980 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFE87C97C90
        public void op_Equality(){} // RVA: 0x7FFE87C97FD0
        public void op_Inequality(){} // RVA: 0x7FFE87C981F0
        public void SetZero_Injected(){} // RVA: 0x7FFE87C96970
        public void AddAmbientLight_Injected(){} // RVA: 0x7FFE87C982B0
        public void AddDirectionalLightInternal_Injected(){} // RVA: 0x7FFE87C98310
    }

    public class StencilState : ValueType
    {
        public byte m_Enabled; // 0x10
        public byte m_ReadMask; // 0x11
        public byte m_WriteMask; // 0x12
        public byte m_Padding; // 0x13
        public byte m_CompareFunctionFront; // 0x14
        public byte m_PassOperationFront; // 0x15
        public byte m_FailOperationFront; // 0x16
        public byte m_ZFailOperationFront; // 0x17
        public byte m_CompareFunctionBack; // 0x18
        public byte m_PassOperationBack; // 0x19
        public byte m_FailOperationBack; // 0x1A

        // ── Methods ──
        public void set_enabled(){} // RVA: 0x7FFE87C9E410
        public void set_readMask(){} // RVA: 0x7FFE81E63F10
        public void set_writeMask(){} // RVA: 0x7FFE81E63F60
        public void set_compareFunctionFront(){} // RVA: 0x7FFE81E63F40
        public void set_passOperationFront(){} // RVA: 0x7FFE81E63F70
        public void set_failOperationFront(){} // RVA: 0x7FFE81E63EE0
        public void set_zFailOperationFront(){} // RVA: 0x7FFE87C9E470
        public void set_compareFunctionBack(){} // RVA: 0x7FFE828B30B0
        public void set_passOperationBack(){} // RVA: 0x7FFE828B30C0
        public void set_failOperationBack(){} // RVA: 0x7FFE87C9E480
        public void set_zFailOperationBack(){} // RVA: 0x7FFE87C9E490
        public void Equals(){} // RVA: 0x7FFE87C9E510 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87C9E670
    }

    public class SubMeshDescriptor : ValueType
    {
        public UnityEngine.Bounds _bounds; // 0x10
        public 0x66575624 _topology; // 0x28
        public int _indexStart; // 0x2C
        public int _indexCount; // 0x30
        public int _baseVertex; // 0x34
        public int _firstVertex; // 0x38
        public int _vertexCount; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C90440
        public void get_bounds(){} // RVA: 0x7FFE82CD7E40
        public void set_bounds(){} // RVA: 0x7FFE82E16150
        public void get_topology(){} // RVA: 0x7FFE813DB630
        public void set_topology(){} // RVA: 0x7FFE8144DF00
        public void get_indexStart(){} // RVA: 0x7FFE82707EE0
        public void set_indexStart(){} // RVA: 0x7FFE82717690
        public void get_indexCount(){} // RVA: 0x7FFE8151D690
        public void set_indexCount(){} // RVA: 0x7FFE8170B670
        public void get_baseVertex(){} // RVA: 0x7FFE81A56130
        public void set_baseVertex(){} // RVA: 0x7FFE82447980
        public void get_firstVertex(){} // RVA: 0x7FFE81549710
        public void set_firstVertex(){} // RVA: 0x7FFE817E4800
        public void get_vertexCount(){} // RVA: 0x7FFE81F84A50
        public void set_vertexCount(){} // RVA: 0x7FFE82883A50
        public void ToString(){} // RVA: 0x7FFE87C90480
    }

    public class SupportedRenderingFeatures : Object
    {
        public UnityEngine.Rendering.SupportedRenderingFeatures s_Active;
        public 0x6658185C _reflectionProbeModes; // 0x10
        public 0x665818B4 _defaultMixedLightingModes; // 0x14
        public 0x665818B4 _mixedLightingModes; // 0x18
        public 0x66575414 _lightmapBakeTypes; // 0x1C
        public J _lightmapsModes; // 0x20
        public bool _enlightenLightmapper; // 0x24
        public bool _enlighten; // 0x25
        public bool _lightProbeProxyVolumes; // 0x26
        public bool _motionVectors; // 0x27
        public bool _receiveShadows; // 0x28

        // ── Methods ──
        public void get_active(){} // RVA: 0x7FFE87C9E700
        public void set_active(){} // RVA: 0x7FFE87C9E820
        public void get_defaultMixedLightingModes(){} // RVA: 0x7FFE8164B230
        public void get_mixedLightingModes(){} // RVA: 0x7FFE813DB630
        public void get_lightmapBakeTypes(){} // RVA: 0x7FFE82707EE0
        public void get_lightmapsModes(){} // RVA: 0x7FFE8151D690
        public void get_enlightenLightmapper(){} // RVA: 0x7FFE811167C0
        public void get_enlighten(){} // RVA: 0x7FFE812EAC90
        public void get_rendersUIOverlay(){} // RVA: 0x7FFE811DA230
        public void get_autoAmbientProbeBaking(){} // RVA: 0x7FFE8130AD10
        public void get_autoDefaultReflectionProbeBaking(){} // RVA: 0x7FFE812CF770
        public void get_overridesLightProbeSystem(){} // RVA: 0x7FFE82230840
        public void FallbackMixedLightingModeByRef(){} // RVA: 0x7FFE87C9E8D0
        public void IsMixedLightingModeSupported(){} // RVA: 0x7FFE87C9EB00
        public void IsMixedLightingModeSupportedByRef(){} // RVA: 0x7FFE87C9EC70
        public void IsLightmapBakeTypeSupported(){} // RVA: 0x7FFE87C9EDD0
        public void IsLightmapBakeTypeSupportedByRef(){} // RVA: 0x7FFE87C9EF00
        public void IsLightmapsModeSupportedByRef(){} // RVA: 0x7FFE87C9F000
        public void IsLightmapperSupportedByRef(){} // RVA: 0x7FFE87C9F070
        public void IsUIOverlayRenderedBySRP(){} // RVA: 0x7FFE87C9F0F0
        public void IsAutoAmbientProbeBakingSupported(){} // RVA: 0x7FFE87C9F150
        public void IsAutoDefaultReflectionProbeBakingSupported(){} // RVA: 0x7FFE87C9F1B0
        public void OverridesLightProbeSystem(){} // RVA: 0x7FFE87C9F210
        public void FallbackLightmapperByRef(){} // RVA: 0x7FFE82C67CB0
        public void .ctor(){} // RVA: 0x7FFE87C9F270
        public void .cctor(){} // RVA: 0x7FFE87C9F340
    }

    public class VertexAttributeDescriptor : ValueType
    {
        public 0x6657FCDC _attribute; // 0x10
        public 0x6657FC84 _format; // 0x14
        public int _dimension; // 0x18
        public int _stream; // 0x1C

        // ── Methods ──
        public void get_attribute(){} // RVA: 0x7FFE826F4220
        public void set_attribute(){} // RVA: 0x7FFE815BF990
        public void get_format(){} // RVA: 0x7FFE826F42A0
        public void set_format(){} // RVA: 0x7FFE826F4290
        public void get_dimension(){} // RVA: 0x7FFE82C33000
        public void set_dimension(){} // RVA: 0x7FFE82C33010
        public void get_stream(){} // RVA: 0x7FFE82C33020
        public void set_stream(){} // RVA: 0x7FFE82C33030
        public void .ctor(){} // RVA: 0x7FFE866C8F80
        public void ToString(){} // RVA: 0x7FFE87C907F0
        public void GetHashCode(){} // RVA: 0x7FFE87C90A50
        public void Equals(){} // RVA: 0x7FFE87C0FF20 | overloaded x2
    }

}