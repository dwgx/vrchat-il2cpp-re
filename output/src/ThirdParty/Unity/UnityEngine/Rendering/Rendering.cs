// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering
// Classes: 41
// Methods: 406

namespace ThirdParty.Unity.UnityEngine.Rendering
{
    public class AsyncGPUReadback
    {
        // ── Methods ──
        public void ValidateFormat(){} // RVA: 0x714E950
        public void WaitAllRequests(){} // RVA: 0x714EAE0
        public void Request(){} // RVA: 0x714F170 | overloaded x6
        public void Request_Internal_Texture_1(){} // RVA: 0x714F2E0
        public void Request_Internal_Texture_2(){} // RVA: 0x714F370
        public void Request_Internal_Texture_3(){} // RVA: 0x714F400
        public void Request_Internal_Texture_4(){} // RVA: 0x714F4D0
        public void Request_Internal_Texture_1_Injected(){} // RVA: 0x714F5B0
        public void Request_Internal_Texture_2_Injected(){} // RVA: 0x714F630
        public void Request_Internal_Texture_3_Injected(){} // RVA: 0x714F6B0
        public void Request_Internal_Texture_4_Injected(){} // RVA: 0x714F730
    }

    public class AsyncGPUReadbackRequest
    {
        // ── Methods ──
        public void GetData(){} // RVA: 0x283FA0
        public void get_done(){} // RVA: 0x714E660
        public void get_hasError(){} // RVA: 0x714E6B0
        public void get_layerCount(){} // RVA: 0x714E700
        public void get_layerDataSize(){} // RVA: 0x714E750
        public void get_width(){} // RVA: 0x714E7A0
        public void get_height(){} // RVA: 0x714E7F0
        public void get_depth(){} // RVA: 0x714E840
        public void IsDone(){} // RVA: 0x714E660
        public void HasError(){} // RVA: 0x714E6B0
        public void GetLayerCount(){} // RVA: 0x714E700
        public void GetLayerDataSize(){} // RVA: 0x714E750
        public void GetWidth(){} // RVA: 0x714E7A0
        public void GetHeight(){} // RVA: 0x714E7F0
        public void GetDepth(){} // RVA: 0x714E840
        public void SetScriptingCallback(){} // RVA: 0x714E890
        public void GetDataRaw(){} // RVA: 0x714E8F0
        public void IsDone_Injected(){} // RVA: 0x714E660
        public void HasError_Injected(){} // RVA: 0x714E6B0
        public void GetLayerCount_Injected(){} // RVA: 0x714E700
        public void GetLayerDataSize_Injected(){} // RVA: 0x714E750
        public void GetWidth_Injected(){} // RVA: 0x714E7A0
        public void GetHeight_Injected(){} // RVA: 0x714E7F0
        public void GetDepth_Injected(){} // RVA: 0x714E840
        public void SetScriptingCallback_Injected(){} // RVA: 0x714E890
        public void GetDataRaw_Injected(){} // RVA: 0x714E8F0
    }

    public class AsyncRequestNativeArrayData
    {
    }

    public class BatchCullingContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7158440
    }

    public class BatchCullingOutput
    {
    }

    public class BatchCullingOutputDrawCommands
    {
    }

    public class BatchDrawCommand
    {
    }

    public class BatchDrawRange
    {
    }

    public class BatchFilterSettings
    {
    }

    public class BatchID
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x67FD0D0
        public void Equals(){} // RVA: 0x70BC7E0 | overloaded x2
        public void .cctor(){} // RVA: 0x71581A0
    }

    public class BatchMaterialID
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x67FD0D0
        public void Equals(){} // RVA: 0x70BC7E0 | overloaded x2
        public void .cctor(){} // RVA: 0x7158280
    }

    public class BatchMeshID
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x67FD0D0
        public void Equals(){} // RVA: 0x70BC7E0 | overloaded x2
        public void .cctor(){} // RVA: 0x7158360
    }

    public class BatchPackedCullingViewID
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x71583A0
        public void Equals(){} // RVA: 0x71583B0 | overloaded x2
    }

    public class BatchRendererCullingOutput
    {
    }

    public class BatchRendererGroup
    {
        // ── Methods ──
        public void InvokeOnPerformCulling(){} // RVA: 0x71584F0
    }

    public class CameraEventUtils
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x714F7C0
    }

    public class CameraProperties
    {
        // ── Methods ──
        public void GetShadowCullingPlane(){} // RVA: 0x7158BE0
        public void GetCameraCullingPlane(){} // RVA: 0x7158CF0
        public void Equals(){} // RVA: 0x715A6B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x715A7F0
    }

    public class CommandBuffer
    {
        // ── Methods ──
        public void WaitAllAsyncReadbackRequests(){} // RVA: 0x7150E70
        public void RequestAsyncReadback(){} // RVA: 0x71511F0 | overloaded x5
        public void Internal_RequestAsyncReadback_1(){} // RVA: 0x71512D0
        public void Internal_RequestAsyncReadback_4(){} // RVA: 0x7151350
        public void Internal_RequestAsyncReadback_5(){} // RVA: 0x71513E0
        public void Internal_RequestAsyncReadback_6(){} // RVA: 0x7151470
        public void Internal_RequestAsyncReadback_8(){} // RVA: 0x7151500
        public void Internal_SetSinglePassStereo(){} // RVA: 0x7151580
        public void InitBuffer(){} // RVA: 0x71515E0
        public void WaitOnGPUFence_Internal(){} // RVA: 0x7151630
        public void ReleaseBuffer(){} // RVA: 0x71516A0
        public void SetComputeFloatParam(){} // RVA: 0x7154470 | overloaded x2
        public void SetComputeIntParam(){} // RVA: 0x7154530 | overloaded x2
        public void SetComputeVectorParam(){} // RVA: 0x71545C0 | overloaded x2
        public void Internal_SetComputeFloats(){} // RVA: 0x7151870
        public void Internal_SetComputeTextureParam(){} // RVA: 0x71518F0
        public void Internal_SetComputeBufferParam(){} // RVA: 0x7151980
        public void Internal_SetComputeGraphicsBufferParam(){} // RVA: 0x7151A10
        public void Internal_DispatchCompute(){} // RVA: 0x7151AA0
        public void set_name(){} // RVA: 0x7151B30
        public void Clear(){} // RVA: 0x7151B90
        public void Internal_DrawMesh(){} // RVA: 0x7151BE0
        public void Internal_DrawRenderer(){} // RVA: 0x7151C80
        public void Internal_DrawMeshInstancedIndirectGraphicsBuffer(){} // RVA: 0x7151D10
        public void SetViewport(){} // RVA: 0x7151DA0
        public void CopyTexture_Internal(){} // RVA: 0x7151E00
        public void Blit_Texture(){} // RVA: 0x7151E90
        public void Blit_Identifier(){} // RVA: 0x7151F50
        public void GetTemporaryRT(){} // RVA: 0x7152770 | overloaded x11
        public void GetTemporaryRTWithDescriptor(){} // RVA: 0x7152650
        public void ReleaseTemporaryRT(){} // RVA: 0x7152800
        public void ClearRenderTarget(){} // RVA: 0x71528F0 | overloaded x2
        public void SetGlobalFloat(){} // RVA: 0x71529F0
        public void SetGlobalInteger(){} // RVA: 0x7152A60
        public void SetGlobalVector(){} // RVA: 0x7152AD0
        public void SetGlobalColor(){} // RVA: 0x7152B40
        public void EnableShaderKeyword(){} // RVA: 0x7152BB0
        public void DisableShaderKeyword(){} // RVA: 0x7152C10
        public void SetViewProjectionMatrices(){} // RVA: 0x7152C70
        public void SetExecutionFlags(){} // RVA: 0x7152CE0
        public void ValidateAgainstExecutionFlags(){} // RVA: 0x7152D40
        public void SetGlobalTexture_Impl(){} // RVA: 0x7152DB0
        public void SetGlobalGraphicsBufferInternal(){} // RVA: 0x7152E30
        public void BeginSample(){} // RVA: 0x7152EA0
        public void EndSample(){} // RVA: 0x7152F00
        public void IssuePluginEventAndDataInternal(){} // RVA: 0x7152F60
        public void SetRenderTarget(){} // RVA: 0x7153A60 | overloaded x7
        public void SetRenderTargetSingle_Internal(){} // RVA: 0x7153CF0
        public void SetRenderTargetColorDepth_Internal(){} // RVA: 0x7153D90
        public void SetRenderTargetMulti_Internal(){} // RVA: 0x7153E40
        public void Finalize(){} // RVA: 0x7153EF0
        public void Dispose(){} // RVA: 0x7154020 | overloaded x2
        public void .ctor(){} // RVA: 0x7154080
        public void Release(){} // RVA: 0x71540D0
        public void WaitOnAsyncGraphicsFence(){} // RVA: 0x7154390 | overloaded x3
        public void SetComputeFloatParams(){} // RVA: 0x7154690
        public void SetComputeTextureParam(){} // RVA: 0x71548D0 | overloaded x3
        public void SetComputeBufferParam(){} // RVA: 0x7151A10 | overloaded x3
        public void DispatchCompute(){} // RVA: 0x7151AA0
        public void DrawMesh(){} // RVA: 0x7154ED0 | overloaded x2
        public void DrawRenderer(){} // RVA: 0x71552E0 | overloaded x3
        public void DrawMeshInstancedIndirect(){} // RVA: 0x7155780 | overloaded x2
        public void CopyTexture(){} // RVA: 0x7155890 | overloaded x2
        public void Blit(){} // RVA: 0x7155CF0 | overloaded x4
        public void SetGlobalTexture(){} // RVA: 0x7155F20 | overloaded x3
        public void SetGlobalBuffer(){} // RVA: 0x7152E30
        public void SetSinglePassStereo(){} // RVA: 0x7151580
        public void IssuePluginEventAndData(){} // RVA: 0x7155F40
        public void SetComputeVectorParam_Injected(){} // RVA: 0x7156060
        public void Internal_DrawMesh_Injected(){} // RVA: 0x71560E0
        public void SetViewport_Injected(){} // RVA: 0x7156170
        public void Blit_Texture_Injected(){} // RVA: 0x71561D0
        public void Blit_Identifier_Injected(){} // RVA: 0x7156260
        public void GetTemporaryRTWithDescriptor_Injected(){} // RVA: 0x71562F0
        public void ClearRenderTarget_Injected(){} // RVA: 0x7156370
        public void SetGlobalVector_Injected(){} // RVA: 0x71563F0
        public void SetGlobalColor_Injected(){} // RVA: 0x7156460
        public void SetViewProjectionMatrices_Injected(){} // RVA: 0x71564D0
        public void SetRenderTargetSingle_Internal_Injected(){} // RVA: 0x7156540
        public void SetRenderTargetColorDepth_Internal_Injected(){} // RVA: 0x71565D0
        public void SetRenderTargetMulti_Internal_Injected(){} // RVA: 0x7156660
    }

    public class CoreCameraValues
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7158B00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7158BC0
    }

    public class CullingSplit
    {
    }

    public class GraphicsFence
    {
        // ── Methods ──
        public void TranslateSynchronizationStageToFlags(){} // RVA: 0x7150790
        public void InitPostAllocation(){} // RVA: 0x71507A0
        public void IsFencePending(){} // RVA: 0x71508A0
        public void Validate(){} // RVA: 0x7150920
        public void GetPlatformNotSupportedVersion(){} // RVA: 0x71509D0
        public void GetVersionNumber(){} // RVA: 0x71509E0
    }

    public class GraphicsSettings
    {
        public object lightmaps;
        public object lightmapsMode;

        // ── Methods ──
        public void get_lightsUseLinearIntensity(){} // RVA: 0x7150A30
        public void get_defaultRenderingLayerMask(){} // RVA: 0x7150A80
        public void get_INTERNAL_currentRenderPipeline(){} // RVA: 0x7150AD0
        public void get_currentRenderPipeline(){} // RVA: 0x7150B20
        public void get_INTERNAL_defaultRenderPipeline(){} // RVA: 0x7150BE0
        public void get_defaultRenderPipeline(){} // RVA: 0x7150C30
        public void GetShaderMode(){} // RVA: 0x7150CF0
    }

    public class LODParameters
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x715BE10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x715BEC0
    }

    public class LocalKeyword
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x5F1D510
        public void Equals(){} // RVA: 0x715F220 | overloaded x2
        public void GetHashCode(){} // RVA: 0x715F270
    }

    public class LocalKeywordSpace
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x40B42E0 | overloaded x2
        public void op_Equality(){} // RVA: 0x715F300
        public void GetHashCode(){} // RVA: 0x67FD0D0
    }

    public class ObjectIdRequest
    {
        public object renderingLayerMaskNames;

        // ── Methods ──
        public void get_destination(){} // RVA: 0x2F8380
    }

    public class OnDemandRendering
    {
        // ── Methods ──
        public void get_renderFrameInterval(){} // RVA: 0x7150D40
        public void GetRenderFrameInterval(){} // RVA: 0x7150DA0
        public void .cctor(){} // RVA: 0x7150E30
    }

    public class ReflectionProbeBlendInfo
    {
    }

    public class RenderPipeline
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x715BF80 | overloaded x2
        public void ProcessRenderRequests(){} // RVA: 0x283FA0
        public void IsRenderRequestSupported(){} // RVA: 0x283FA0
        public void InternalRender(){} // RVA: 0x715C000
        public void InternalProcessRenderRequests(){} // RVA: 0x283FA0
        public void get_disposed(){} // RVA: 0x3A75E0
        public void set_disposed(){} // RVA: 0x3A75F0
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
    }

    public class RenderPipelineAsset
    {
        // ── Methods ──
        public void InternalCreatePipeline(){} // RVA: 0x715C100
        public void get_renderingLayerMaskNames(){} // RVA: 0x519240
        public void get_prefixedRenderingLayerMaskNames(){} // RVA: 0x519240
        public void get_defaultMaterial(){} // RVA: 0x519240
        public void get_autodeskInteractiveShader(){} // RVA: 0x519240
        public void get_autodeskInteractiveTransparentShader(){} // RVA: 0x519240
        public void get_autodeskInteractiveMaskedShader(){} // RVA: 0x519240
        public void get_terrainDetailLitShader(){} // RVA: 0x519240
        public void get_terrainDetailGrassShader(){} // RVA: 0x519240
        public void get_terrainDetailGrassBillboardShader(){} // RVA: 0x519240
        public void get_defaultParticleMaterial(){} // RVA: 0x519240
        public void get_defaultLineMaterial(){} // RVA: 0x519240
        public void get_defaultTerrainMaterial(){} // RVA: 0x519240
        public void get_defaultUIMaterial(){} // RVA: 0x519240
        public void get_defaultUIOverdrawMaterial(){} // RVA: 0x519240
        public void get_defaultUIETC1SupportedMaterial(){} // RVA: 0x519240
        public void get_default2DMaterial(){} // RVA: 0x519240
        public void get_default2DMaskMaterial(){} // RVA: 0x519240
        public void get_defaultShader(){} // RVA: 0x519240
        public void get_defaultSpeedTree7Shader(){} // RVA: 0x519240
        public void get_defaultSpeedTree8Shader(){} // RVA: 0x519240
        public void get_renderPipelineShaderTag(){} // RVA: 0x715C2E0
        public void CreatePipeline(){} // RVA: 0xCD60
        public void OnValidate(){} // RVA: 0x715C320
        public void OnDisable(){} // RVA: 0x715C490
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class RenderPipelineManager
    {
        public object cullingPlaneCount;

        // ── Methods ──
        public void get_currentPipeline(){} // RVA: 0x715C4E0
        public void set_currentPipeline(){} // RVA: 0x715C540
        public void add_beginCameraRendering(){} // RVA: 0x715C6D0
        public void remove_beginCameraRendering(){} // RVA: 0x715C830
        public void add_endCameraRendering(){} // RVA: 0x715C990
        public void remove_endCameraRendering(){} // RVA: 0x715CAF0
        public void OnActiveRenderPipelineTypeChanged(){} // RVA: 0x715CC50
        public void OnActiveRenderPipelineAssetChanged(){} // RVA: 0x715CCC0
        public void HandleRenderPipelineChange(){} // RVA: 0x715CDD0
        public void CleanupRenderPipeline(){} // RVA: 0x715CEB0
        public void GetCurrentPipelineAssetType(){} // RVA: 0x715D190
        public void DoRenderLoop_Internal(){} // RVA: 0x715D1F0
        public void PrepareRenderPipeline(){} // RVA: 0x715D690
        public void IsPipelineRequireCreation(){} // RVA: 0x715D950
        public void .cctor(){} // RVA: 0x715DAB0
    }

    public class RenderTargetIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7150110 | overloaded x5
        public void op_Implicit(){} // RVA: 0x7150240 | overloaded x4
        public void ToString(){} // RVA: 0x71502A0
        public void GetHashCode(){} // RVA: 0x71505E0
        public void Equals(){} // RVA: 0x7150680 | overloaded x2
    }

    public class ScriptableCullingParameters
    {
        // ── Methods ──
        public void get_cullingPlaneCount(){} // RVA: 0x715B050
        public void GetLayerCullingDistance(){} // RVA: 0x715B060
        public void GetCullingPlane(){} // RVA: 0x715B160
        public void Equals(){} // RVA: 0x715B9B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x715BA80
        public void .cctor(){} // RVA: 0x715BCE0
    }

    public class ScriptableRenderContext
    {
        // ── Methods ──
        public void GetCameras_Internal(){} // RVA: 0x715DC80
        public void .ctor(){} // RVA: 0x1B12320
        public void GetCameras(){} // RVA: 0x715DD30
        public void Equals(){} // RVA: 0x715DEF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x67FD0D0
        public void .cctor(){} // RVA: 0x715DF90
        public void GetCameras_Internal_Injected(){} // RVA: 0x715E030
    }

    public class ShaderTagId
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x715E0A0
        public void Equals(){} // RVA: 0x70BC7E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x715E180
    }

    public class SortingGroup
    {
        public object mode;
        public object radius;
        public object windMain;
        public object windTurbulence;
        public object windPulseMagnitude;
        public object windPulseFrequency;
        public object _invalidSortingGroupID;

        // ── Methods ──
        public void get_invalidSortingGroupID(){} // RVA: 0x715F310
        public void UpdateAllSortingGroups(){} // RVA: 0x715F360
        public void GetSortingGroupByIndex(){} // RVA: 0x715F3B0
        public void get_sortingLayerName(){} // RVA: 0x715F400
        public void set_sortingLayerName(){} // RVA: 0x715F450
        public void get_sortingLayerID(){} // RVA: 0x715F4B0
        public void set_sortingLayerID(){} // RVA: 0x715F500
        public void get_sortingOrder(){} // RVA: 0x715F560
        public void set_sortingOrder(){} // RVA: 0x715F5B0
        public void get_sortAtRoot(){} // RVA: 0x715F610
        public void set_sortAtRoot(){} // RVA: 0x715F660
        public void get_sortingGroupID(){} // RVA: 0x715F6C0
        public void get_sortingGroupOrder(){} // RVA: 0x715F710
        public void get_index(){} // RVA: 0x715F760
        public void get_sortingKey(){} // RVA: 0x715F7B0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SphericalHarmonicsL2
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x71566F0
        public void SetZero(){} // RVA: 0x71566F0
        public void AddAmbientLight(){} // RVA: 0x7156740
        public void AddDirectionalLight(){} // RVA: 0x71567A0
        public void AddDirectionalLightInternal(){} // RVA: 0x7156860
        public void Evaluate(){} // RVA: 0x71568D0
        public void EvaluateInternal(){} // RVA: 0x7156A40
        public void get_Item(){} // RVA: 0x7156AB0
        public void set_Item(){} // RVA: 0x7156CB0
        public void GetHashCode(){} // RVA: 0x7156EB0
        public void Equals(){} // RVA: 0x7157340 | overloaded x2
        public void op_Multiply(){} // RVA: 0x7157700 | overloaded x2
        public void op_Addition(){} // RVA: 0x7157A10
        public void op_Equality(){} // RVA: 0x7157D50
        public void op_Inequality(){} // RVA: 0x7157F70
        public void SetZero_Injected(){} // RVA: 0x71566F0
        public void AddAmbientLight_Injected(){} // RVA: 0x7158030
        public void AddDirectionalLightInternal_Injected(){} // RVA: 0x7158090
    }

    public class StencilState
    {
        // ── Methods ──
        public void set_enabled(){} // RVA: 0x715E190
        public void set_readMask(){} // RVA: 0x10EEB00
        public void set_writeMask(){} // RVA: 0x10EEB20
        public void set_compareFunctionFront(){} // RVA: 0x10EEB40
        public void set_passOperationFront(){} // RVA: 0x10EEBB0
        public void set_failOperationFront(){} // RVA: 0x10EEB70
        public void set_zFailOperationFront(){} // RVA: 0x715E1F0
        public void set_compareFunctionBack(){} // RVA: 0x1B06D50
        public void set_passOperationBack(){} // RVA: 0x1B06C90
        public void set_failOperationBack(){} // RVA: 0x715E200
        public void set_zFailOperationBack(){} // RVA: 0x715E210
        public void Equals(){} // RVA: 0x715E290 | overloaded x2
        public void GetHashCode(){} // RVA: 0x715E3F0
    }

    public class SubMeshDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x714F7D0
        public void get_bounds(){} // RVA: 0x1F4D780
        public void set_bounds(){} // RVA: 0x2086530
        public void get_topology(){} // RVA: 0x5BED50
        public void set_topology(){} // RVA: 0x6374E0
        public void get_indexStart(){} // RVA: 0x197C3B0
        public void set_indexStart(){} // RVA: 0x1989FD0
        public void get_indexCount(){} // RVA: 0x760030
        public void set_indexCount(){} // RVA: 0x99E0D0
        public void get_baseVertex(){} // RVA: 0xCEF5B0
        public void set_baseVertex(){} // RVA: 0x16E1F00
        public void get_firstVertex(){} // RVA: 0x791DC0
        public void set_firstVertex(){} // RVA: 0xA53440
        public void get_vertexCount(){} // RVA: 0x1209F00
        public void set_vertexCount(){} // RVA: 0x1AFCF60
        public void ToString(){} // RVA: 0x714F810
    }

    public class SupportedRenderingFeatures
    {
        public object attribute;
        public object format;
        public object dimension;
        public object stream;

        // ── Methods ──
        public void get_active(){} // RVA: 0x715E480
        public void set_active(){} // RVA: 0x715E5A0
        public void get_defaultMixedLightingModes(){} // RVA: 0x8ABED0
        public void get_mixedLightingModes(){} // RVA: 0x5BED50
        public void get_lightmapBakeTypes(){} // RVA: 0x197C3B0
        public void get_lightmapsModes(){} // RVA: 0x760030
        public void get_enlightenLightmapper(){} // RVA: 0x2F87C0
        public void get_enlighten(){} // RVA: 0x4D7B80
        public void get_rendersUIOverlay(){} // RVA: 0x3BC230
        public void get_autoAmbientProbeBaking(){} // RVA: 0x4FDE80
        public void get_autoDefaultReflectionProbeBaking(){} // RVA: 0x4A6500
        public void get_overridesLightProbeSystem(){} // RVA: 0x14CEB40
        public void FallbackMixedLightingModeByRef(){} // RVA: 0x715E650
        public void IsMixedLightingModeSupported(){} // RVA: 0x715E880
        public void IsMixedLightingModeSupportedByRef(){} // RVA: 0x715E9F0
        public void IsLightmapBakeTypeSupported(){} // RVA: 0x715EB50
        public void IsLightmapBakeTypeSupportedByRef(){} // RVA: 0x715EC80
        public void IsLightmapsModeSupportedByRef(){} // RVA: 0x715ED80
        public void IsLightmapperSupportedByRef(){} // RVA: 0x715EDF0
        public void IsUIOverlayRenderedBySRP(){} // RVA: 0x715EE70
        public void IsAutoAmbientProbeBakingSupported(){} // RVA: 0x715EED0
        public void IsAutoDefaultReflectionProbeBakingSupported(){} // RVA: 0x715EF30
        public void OverridesLightProbeSystem(){} // RVA: 0x715EF90
        public void FallbackLightmapperByRef(){} // RVA: 0x1EDD870
        public void .ctor(){} // RVA: 0x715EFF0
        public void .cctor(){} // RVA: 0x715F0C0
    }

    public class VertexAttributeDescriptor
    {
        // ── Methods ──
        public void get_attribute(){} // RVA: 0x19689B0
        public void set_attribute(){} // RVA: 0x833580
        public void get_format(){} // RVA: 0x19689E0
        public void set_format(){} // RVA: 0x19689D0
        public void get_dimension(){} // RVA: 0x1EA9890
        public void set_dimension(){} // RVA: 0x1EA98A0
        public void get_stream(){} // RVA: 0x1EA98B0
        public void set_stream(){} // RVA: 0x1EA98C0
        public void .ctor(){} // RVA: 0x5B88150
        public void ToString(){} // RVA: 0x714FB80
        public void GetHashCode(){} // RVA: 0x714FDE0
        public void Equals(){} // RVA: 0x70CF000 | overloaded x2
    }

}