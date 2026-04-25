// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering
// Classes: 27
// Methods: 295

namespace ThirdParty.Unity.UnityEngine.Rendering
{
    public class AsyncGPUReadbackRequest : ValueType
    {
        public object done;
        public object hasError;
        public object layerCount;
        public object layerDataSize;
        public object width;
        public object height;
        public object depth;

        // ── Methods ──
        public void GetData(){} // RVA: 0x7FFD4E2ADC40
        public void get_done(){} // RVA: 0x7FFD54D06BA0
        public void get_hasError(){} // RVA: 0x7FFD54D06BF0
        public void get_layerCount(){} // RVA: 0x7FFD54D06C40
        public void get_layerDataSize(){} // RVA: 0x7FFD54D06C90
        public void get_width(){} // RVA: 0x7FFD54D06CE0
        public void get_height(){} // RVA: 0x7FFD54D06D30
        public void get_depth(){} // RVA: 0x7FFD54D06D80
        public void IsDone(){} // RVA: 0x7FFD54D06BA0
        public void HasError(){} // RVA: 0x7FFD54D06BF0
        public void GetLayerCount(){} // RVA: 0x7FFD54D06C40
        public void GetLayerDataSize(){} // RVA: 0x7FFD54D06C90
        public void GetWidth(){} // RVA: 0x7FFD54D06CE0
        public void GetHeight(){} // RVA: 0x7FFD54D06D30
        public void GetDepth(){} // RVA: 0x7FFD54D06D80
        public void SetScriptingCallback(){} // RVA: 0x7FFD54D06DD0
        public void GetDataRaw(){} // RVA: 0x7FFD54D06E30
        public void IsDone_Injected(){} // RVA: 0x7FFD54D06BA0
        public void HasError_Injected(){} // RVA: 0x7FFD54D06BF0
        public void GetLayerCount_Injected(){} // RVA: 0x7FFD54D06C40
        public void GetLayerDataSize_Injected(){} // RVA: 0x7FFD54D06C90
        public void GetWidth_Injected(){} // RVA: 0x7FFD54D06CE0
        public void GetHeight_Injected(){} // RVA: 0x7FFD54D06D30
        public void GetDepth_Injected(){} // RVA: 0x7FFD54D06D80
        public void SetScriptingCallback_Injected(){} // RVA: 0x7FFD54D06DD0
        public void GetDataRaw_Injected(){} // RVA: 0x7FFD54D06E30
    }

    public class AsyncRequestNativeArrayData : ValueType
    {
    }

    public class BatchCullingContext : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54D0FE20
    }

    public class BatchID : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFD543B3F90
        public void Equals(){} // RVA: 0x7FFD54C75270 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD54D0FB80
    }

    public class BatchMaterialID : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFD543B3F90
        public void Equals(){} // RVA: 0x7FFD54C75270 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD54D0FC60
    }

    public class BatchMeshID : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFD543B3F90
        public void Equals(){} // RVA: 0x7FFD54C75270 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD54D0FD40
    }

    public class BatchPackedCullingViewID : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFD54D0FD80
        public void Equals(){} // RVA: 0x7FFD54D0FD90 | overloaded x2
    }

    public class BatchRendererCullingOutput : ValueType
    {
    }

    public class BatchRendererGroup : Object
    {
        // ── Methods ──
        public void InvokeOnPerformCulling(){} // RVA: 0x7FFD54D0FED0
    }

    public class CameraProperties : ValueType
    {
        // ── Methods ──
        public void GetShadowCullingPlane(){} // RVA: 0x7FFD54D105C0
        public void GetCameraCullingPlane(){} // RVA: 0x7FFD54D106D0
        public void Equals(){} // RVA: 0x7FFD54D12090 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54D121D0
    }

    public class CommandBuffer : Object
    {
        public object name;

        // ── Methods ──
        public void WaitAllAsyncReadbackRequests(){} // RVA: 0x7FFD54D09110
        public void RequestAsyncReadback(){} // RVA: 0x7FFD54D09230 | overloaded x2
        public void Internal_RequestAsyncReadback_4(){} // RVA: 0x7FFD54D09310
        public void Internal_RequestAsyncReadback_5(){} // RVA: 0x7FFD54D093A0
        public void Internal_SetSinglePassStereo(){} // RVA: 0x7FFD54D09430
        public void InitBuffer(){} // RVA: 0x7FFD54D09490
        public void ReleaseBuffer(){} // RVA: 0x7FFD54D094E0
        public void SetComputeFloatParam(){} // RVA: 0x7FFD54D0BE90 | overloaded x2
        public void SetComputeIntParam(){} // RVA: 0x7FFD54D0BF50 | overloaded x2
        public void SetComputeVectorParam(){} // RVA: 0x7FFD54D0C010 | overloaded x2
        public void Internal_SetComputeFloats(){} // RVA: 0x7FFD54D096B0
        public void Internal_SetComputeTextureParam(){} // RVA: 0x7FFD54D09730
        public void Internal_SetComputeBufferParam(){} // RVA: 0x7FFD54D097C0
        public void Internal_DispatchCompute(){} // RVA: 0x7FFD54D09850
        public void set_name(){} // RVA: 0x7FFD54D098E0
        public void Clear(){} // RVA: 0x7FFD54D09940
        public void Internal_DrawMesh(){} // RVA: 0x7FFD54D09990
        public void Internal_DrawRenderer(){} // RVA: 0x7FFD54D09A30
        public void Internal_DrawMeshInstancedIndirectGraphicsBuffer(){} // RVA: 0x7FFD54D09AC0
        public void SetViewport(){} // RVA: 0x7FFD54D09B50
        public void CopyTexture_Internal(){} // RVA: 0x7FFD54D09BB0
        public void Blit_Texture(){} // RVA: 0x7FFD54D09C40
        public void Blit_Identifier(){} // RVA: 0x7FFD54D09D00
        public void GetTemporaryRT(){} // RVA: 0x7FFD54D0A520 | overloaded x11
        public void GetTemporaryRTWithDescriptor(){} // RVA: 0x7FFD54D0A400
        public void ReleaseTemporaryRT(){} // RVA: 0x7FFD54D0A5B0
        public void ClearRenderTarget(){} // RVA: 0x7FFD54D0A6A0 | overloaded x2
        public void SetGlobalFloat(){} // RVA: 0x7FFD54D0A7A0
        public void SetGlobalInteger(){} // RVA: 0x7FFD54D0A810
        public void SetGlobalVector(){} // RVA: 0x7FFD54D0A880
        public void SetGlobalColor(){} // RVA: 0x7FFD54D0A8F0
        public void EnableShaderKeyword(){} // RVA: 0x7FFD54D0A960
        public void DisableShaderKeyword(){} // RVA: 0x7FFD54D0A9C0
        public void SetViewProjectionMatrices(){} // RVA: 0x7FFD54D0AA20
        public void SetExecutionFlags(){} // RVA: 0x7FFD54D0AA90
        public void ValidateAgainstExecutionFlags(){} // RVA: 0x7FFD54D0AAF0
        public void SetGlobalTexture_Impl(){} // RVA: 0x7FFD54D0AB60
        public void SetGlobalGraphicsBufferInternal(){} // RVA: 0x7FFD54D0ABE0
        public void BeginSample(){} // RVA: 0x7FFD54D0AC50
        public void EndSample(){} // RVA: 0x7FFD54D0ACB0
        public void IssuePluginEventAndDataInternal(){} // RVA: 0x7FFD54D0AD10
        public void SetRenderTarget(){} // RVA: 0x7FFD54D0B810 | overloaded x7
        public void SetRenderTargetSingle_Internal(){} // RVA: 0x7FFD54D0BAA0
        public void SetRenderTargetColorDepth_Internal(){} // RVA: 0x7FFD54D0BB40
        public void SetRenderTargetMulti_Internal(){} // RVA: 0x7FFD54D0BBF0
        public void Finalize(){} // RVA: 0x7FFD54D0BCA0
        public void Dispose(){} // RVA: 0x7FFD54D0BDD0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD54D0BE30
        public void Release(){} // RVA: 0x7FFD54D0BE80
        public void SetComputeFloatParams(){} // RVA: 0x7FFD54D0C0E0
        public void SetComputeTextureParam(){} // RVA: 0x7FFD54D0C280 | overloaded x2
        public void SetComputeBufferParam(){} // RVA: 0x7FFD54D0C360
        public void DispatchCompute(){} // RVA: 0x7FFD54D09850
        public void DrawMesh(){} // RVA: 0x7FFD54D0C8B0 | overloaded x2
        public void DrawRenderer(){} // RVA: 0x7FFD54D0CCC0 | overloaded x3
        public void DrawMeshInstancedIndirect(){} // RVA: 0x7FFD54D0D160 | overloaded x2
        public void CopyTexture(){} // RVA: 0x7FFD54D0D270 | overloaded x2
        public void Blit(){} // RVA: 0x7FFD54D0D6D0 | overloaded x4
        public void SetGlobalTexture(){} // RVA: 0x7FFD54D0D900 | overloaded x3
        public void SetGlobalBuffer(){} // RVA: 0x7FFD54D0ABE0
        public void SetSinglePassStereo(){} // RVA: 0x7FFD54D09430
        public void IssuePluginEventAndData(){} // RVA: 0x7FFD54D0D920
        public void SetComputeVectorParam_Injected(){} // RVA: 0x7FFD54D0DA40
        public void Internal_DrawMesh_Injected(){} // RVA: 0x7FFD54D0DAC0
        public void SetViewport_Injected(){} // RVA: 0x7FFD54D0DB50
        public void Blit_Texture_Injected(){} // RVA: 0x7FFD54D0DBB0
        public void Blit_Identifier_Injected(){} // RVA: 0x7FFD54D0DC40
        public void GetTemporaryRTWithDescriptor_Injected(){} // RVA: 0x7FFD54D0DCD0
        public void ClearRenderTarget_Injected(){} // RVA: 0x7FFD54D0DD50
        public void SetGlobalVector_Injected(){} // RVA: 0x7FFD54D0DDD0
        public void SetGlobalColor_Injected(){} // RVA: 0x7FFD54D0DE40
        public void SetViewProjectionMatrices_Injected(){} // RVA: 0x7FFD54D0DEB0
        public void SetRenderTargetSingle_Internal_Injected(){} // RVA: 0x7FFD54D0DF20
        public void SetRenderTargetColorDepth_Internal_Injected(){} // RVA: 0x7FFD54D0DFB0
        public void SetRenderTargetMulti_Internal_Injected(){} // RVA: 0x7FFD54D0E040
    }

    public class CoreCameraValues : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD54D104E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54D105A0
    }

    public class CullingSplit : ValueType
    {
    }

    public class GraphicsSettings : Object
    {
        public object lightsUseLinearIntensity;
        public object defaultRenderingLayerMask;
        public object INTERNAL_currentRenderPipeline;
        public object currentRenderPipeline;
        public object INTERNAL_defaultRenderPipeline;
        public object defaultRenderPipeline;

        // ── Methods ──
        public void get_lightsUseLinearIntensity(){} // RVA: 0x7FFD54D08CD0
        public void get_defaultRenderingLayerMask(){} // RVA: 0x7FFD54D08D20
        public void get_INTERNAL_currentRenderPipeline(){} // RVA: 0x7FFD54D08D70
        public void get_currentRenderPipeline(){} // RVA: 0x7FFD54D08DC0
        public void get_INTERNAL_defaultRenderPipeline(){} // RVA: 0x7FFD54D08E80
        public void get_defaultRenderPipeline(){} // RVA: 0x7FFD54D08ED0
        public void GetShaderMode(){} // RVA: 0x7FFD54D08F90
    }

    public class LODParameters : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD54D137F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54D138A0
    }

    public class LocalKeyword : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD53AD4B80
        public void Equals(){} // RVA: 0x7FFD54D16C00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54D16C50
    }

    public class LocalKeywordSpace : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD51DE9070 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD54D16CE0
        public void GetHashCode(){} // RVA: 0x7FFD543B3F90
    }

    public class OnDemandRendering : Object
    {
        public object renderFrameInterval;

        // ── Methods ──
        public void get_renderFrameInterval(){} // RVA: 0x7FFD54D08FE0
        public void GetRenderFrameInterval(){} // RVA: 0x7FFD54D09040
        public void .cctor(){} // RVA: 0x7FFD54D090D0
    }

    public class ReflectionProbeBlendInfo : ValueType
    {
    }

    public class RenderPipeline : Object
    {
        public object disposed;

        // ── Methods ──
        public void Render(){} // RVA: 0x7FFD54D13960 | overloaded x2
        public void ProcessRenderRequests(){} // RVA: 0x7FFD4E2ADC40
        public void IsRenderRequestSupported(){} // RVA: 0x7FFD4E2ADC40
        public void InternalRender(){} // RVA: 0x7FFD54D139E0
        public void InternalProcessRenderRequests(){} // RVA: 0x7FFD4E2ADC40
        public void get_disposed(){} // RVA: 0x7FFD4E40B5E0
        public void set_disposed(){} // RVA: 0x7FFD4E40B5F0
        public void Dispose(){} // RVA: 0x7FFD4E341310 | overloaded x2
    }

    public class RenderPipelineManager : Object
    {
        public object currentPipeline;

        // ── Methods ──
        public void get_currentPipeline(){} // RVA: 0x7FFD54D13EC0
        public void set_currentPipeline(){} // RVA: 0x7FFD54D13F20
        public void add_beginCameraRendering(){} // RVA: 0x7FFD54D140B0
        public void remove_beginCameraRendering(){} // RVA: 0x7FFD54D14210
        public void add_endCameraRendering(){} // RVA: 0x7FFD54D14370
        public void remove_endCameraRendering(){} // RVA: 0x7FFD54D144D0
        public void OnActiveRenderPipelineTypeChanged(){} // RVA: 0x7FFD54D14630
        public void OnActiveRenderPipelineAssetChanged(){} // RVA: 0x7FFD54D146A0
        public void HandleRenderPipelineChange(){} // RVA: 0x7FFD54D147B0
        public void CleanupRenderPipeline(){} // RVA: 0x7FFD54D14890
        public void GetCurrentPipelineAssetType(){} // RVA: 0x7FFD54D14B70
        public void DoRenderLoop_Internal(){} // RVA: 0x7FFD54D14BD0
        public void PrepareRenderPipeline(){} // RVA: 0x7FFD54D15070
        public void IsPipelineRequireCreation(){} // RVA: 0x7FFD54D15330
        public void .cctor(){} // RVA: 0x7FFD54D15490
    }

    public class ScriptableCullingParameters : ValueType
    {
        public object cullingPlaneCount;

        // ── Methods ──
        public void get_cullingPlaneCount(){} // RVA: 0x7FFD54D12A30
        public void GetLayerCullingDistance(){} // RVA: 0x7FFD54D12A40
        public void GetCullingPlane(){} // RVA: 0x7FFD54D12B40
        public void Equals(){} // RVA: 0x7FFD54D13390 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54D13460
        public void .cctor(){} // RVA: 0x7FFD54D136C0
    }

    public class ScriptableRenderContext : ValueType
    {
        // ── Methods ──
        public void GetCameras_Internal(){} // RVA: 0x7FFD54D15660
        public void .ctor(){} // RVA: 0x7FFD4F9DB120
        public void GetCameras(){} // RVA: 0x7FFD54D15710
        public void Equals(){} // RVA: 0x7FFD54D158D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD543B3F90
        public void .cctor(){} // RVA: 0x7FFD54D15970
        public void GetCameras_Internal_Injected(){} // RVA: 0x7FFD54D15A10
    }

    public class SortingGroup : Behaviour
    {
        public object invalidSortingGroupID;
        public object sortingLayerName;
        public object sortingLayerID;
        public object sortingOrder;
        public object sortAtRoot;
        public object sortingGroupID;
        public object sortingGroupOrder;
        public object index;
        public object sortingKey;

        // ── Methods ──
        public void get_invalidSortingGroupID(){} // RVA: 0x7FFD54D16CF0
        public void UpdateAllSortingGroups(){} // RVA: 0x7FFD54D16D40
        public void GetSortingGroupByIndex(){} // RVA: 0x7FFD54D16D90
        public void get_sortingLayerName(){} // RVA: 0x7FFD54D16DE0
        public void set_sortingLayerName(){} // RVA: 0x7FFD54D16E30
        public void get_sortingLayerID(){} // RVA: 0x7FFD54D16E90
        public void set_sortingLayerID(){} // RVA: 0x7FFD54D16EE0
        public void get_sortingOrder(){} // RVA: 0x7FFD54D16F40
        public void set_sortingOrder(){} // RVA: 0x7FFD54D16F90
        public void get_sortAtRoot(){} // RVA: 0x7FFD54D16FF0
        public void set_sortAtRoot(){} // RVA: 0x7FFD54D17040
        public void get_sortingGroupID(){} // RVA: 0x7FFD54D170A0
        public void get_sortingGroupOrder(){} // RVA: 0x7FFD54D170F0
        public void get_index(){} // RVA: 0x7FFD54D17140
        public void get_sortingKey(){} // RVA: 0x7FFD54D17190
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SphericalHarmonicsL2 : ValueType
    {
        public object Item;

        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFD54D0E0D0
        public void SetZero(){} // RVA: 0x7FFD54D0E0D0
        public void AddAmbientLight(){} // RVA: 0x7FFD54D0E120
        public void AddDirectionalLight(){} // RVA: 0x7FFD54D0E180
        public void AddDirectionalLightInternal(){} // RVA: 0x7FFD54D0E240
        public void Evaluate(){} // RVA: 0x7FFD54D0E2B0
        public void EvaluateInternal(){} // RVA: 0x7FFD54D0E420
        public void get_Item(){} // RVA: 0x7FFD54D0E490
        public void set_Item(){} // RVA: 0x7FFD54D0E690
        public void GetHashCode(){} // RVA: 0x7FFD54D0E890
        public void Equals(){} // RVA: 0x7FFD54D0ED20 | overloaded x2
        public void op_Multiply(){} // RVA: 0x7FFD54D0F0E0 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFD54D0F3F0
        public void op_Equality(){} // RVA: 0x7FFD54D0F730
        public void op_Inequality(){} // RVA: 0x7FFD54D0F950
        public void SetZero_Injected(){} // RVA: 0x7FFD54D0E0D0
        public void AddAmbientLight_Injected(){} // RVA: 0x7FFD54D0FA10
        public void AddDirectionalLightInternal_Injected(){} // RVA: 0x7FFD54D0FA70
    }

    public class SupportedRenderingFeatures : Object
    {
        public object active;
        public object defaultMixedLightingModes;
        public object mixedLightingModes;
        public object lightmapBakeTypes;
        public object lightmapsModes;
        public object enlightenLightmapper;
        public object enlighten;
        public object rendersUIOverlay;
        public object autoAmbientProbeBaking;
        public object autoDefaultReflectionProbeBaking;
        public object overridesLightProbeSystem;

        // ── Methods ──
        public void get_active(){} // RVA: 0x7FFD54D15E60
        public void set_active(){} // RVA: 0x7FFD54D15F80
        public void get_defaultMixedLightingModes(){} // RVA: 0x7FFD4E7F5A20
        public void get_mixedLightingModes(){} // RVA: 0x7FFD4E577800
        public void get_lightmapBakeTypes(){} // RVA: 0x7FFD4F8557F0
        public void get_lightmapsModes(){} // RVA: 0x7FFD4E4FBBE0
        public void get_enlightenLightmapper(){} // RVA: 0x7FFD4E35C7C0
        public void get_enlighten(){} // RVA: 0x7FFD4F3C0EA0
        public void get_rendersUIOverlay(){} // RVA: 0x7FFD4E420230
        public void get_autoAmbientProbeBaking(){} // RVA: 0x7FFD4FB58E80
        public void get_autoDefaultReflectionProbeBaking(){} // RVA: 0x7FFD4E5F95D0
        public void get_overridesLightProbeSystem(){} // RVA: 0x7FFD4F39B7C0
        public void FallbackMixedLightingModeByRef(){} // RVA: 0x7FFD54D16030
        public void IsMixedLightingModeSupported(){} // RVA: 0x7FFD54D16260
        public void IsMixedLightingModeSupportedByRef(){} // RVA: 0x7FFD54D163D0
        public void IsLightmapBakeTypeSupported(){} // RVA: 0x7FFD54D16530
        public void IsLightmapBakeTypeSupportedByRef(){} // RVA: 0x7FFD54D16660
        public void IsLightmapsModeSupportedByRef(){} // RVA: 0x7FFD54D16760
        public void IsLightmapperSupportedByRef(){} // RVA: 0x7FFD54D167D0
        public void IsUIOverlayRenderedBySRP(){} // RVA: 0x7FFD54D16850
        public void IsAutoAmbientProbeBakingSupported(){} // RVA: 0x7FFD54D168B0
        public void IsAutoDefaultReflectionProbeBakingSupported(){} // RVA: 0x7FFD54D16910
        public void OverridesLightProbeSystem(){} // RVA: 0x7FFD54D16970
        public void FallbackLightmapperByRef(){} // RVA: 0x7FFD4FE1C570
        public void .ctor(){} // RVA: 0x7FFD54D169D0
        public void .cctor(){} // RVA: 0x7FFD54D16AA0
    }

    public class VertexAttributeDescriptor : ValueType
    {
        public object attribute;
        public object format;
        public object dimension;
        public object stream;

        // ── Methods ──
        public void get_attribute(){} // RVA: 0x7FFD4F840210
        public void set_attribute(){} // RVA: 0x7FFD4E78D8B0
        public void get_format(){} // RVA: 0x7FFD4F8402A0
        public void set_format(){} // RVA: 0x7FFD4F840230
        public void get_dimension(){} // RVA: 0x7FFD4FDE7500
        public void set_dimension(){} // RVA: 0x7FFD4FDE7510
        public void get_stream(){} // RVA: 0x7FFD4FDE7520
        public void set_stream(){} // RVA: 0x7FFD4FDE7530
        public void .ctor(){} // RVA: 0x7FFD5373F680
        public void ToString(){} // RVA: 0x7FFD54D080C0
        public void GetHashCode(){} // RVA: 0x7FFD54D08320
        public void Equals(){} // RVA: 0x7FFD54C879D0 | overloaded x2
    }

}