// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering
// Classes: 40
// Methods: 386

namespace ThirdParty.Unity.UnityEngine.Rendering
{
    public class AsyncGPUReadback : Object
    {
        // ── Methods ──
        public void ValidateFormat(){} // RVA: 0x7FFAC98E6E90
        public void WaitAllRequests(){} // RVA: 0x7FFAC98E7020
        public void Request(){} // RVA: 0x7FFAC98E76B0 | overloaded x6
        public void Request_Internal_Texture_1(){} // RVA: 0x7FFAC98E7820
        public void Request_Internal_Texture_2(){} // RVA: 0x7FFAC98E78B0
        public void Request_Internal_Texture_3(){} // RVA: 0x7FFAC98E7940
        public void Request_Internal_Texture_4(){} // RVA: 0x7FFAC98E7A10
        public void Request_Internal_Texture_1_Injected(){} // RVA: 0x7FFAC98E7AF0
        public void Request_Internal_Texture_2_Injected(){} // RVA: 0x7FFAC98E7B70
        public void Request_Internal_Texture_3_Injected(){} // RVA: 0x7FFAC98E7BF0
        public void Request_Internal_Texture_4_Injected(){} // RVA: 0x7FFAC98E7C70
    }

    public class AsyncGPUReadbackRequest : ValueType
    {
        public UIntPtr done; // 0x10
        public int hasError; // 0x18

        // ── Methods ──
        public void GetData(){} // RVA: 0x7FFAC2E8DC40
        public void get_done(){} // RVA: 0x7FFAC98E6BA0
        public void get_hasError(){} // RVA: 0x7FFAC98E6BF0
        public void get_layerCount(){} // RVA: 0x7FFAC98E6C40
        public void get_layerDataSize(){} // RVA: 0x7FFAC98E6C90
        public void get_width(){} // RVA: 0x7FFAC98E6CE0
        public void get_height(){} // RVA: 0x7FFAC98E6D30
        public void get_depth(){} // RVA: 0x7FFAC98E6D80
        public void IsDone(){} // RVA: 0x7FFAC98E6BA0
        public void HasError(){} // RVA: 0x7FFAC98E6BF0
        public void GetLayerCount(){} // RVA: 0x7FFAC98E6C40
        public void GetLayerDataSize(){} // RVA: 0x7FFAC98E6C90
        public void GetWidth(){} // RVA: 0x7FFAC98E6CE0
        public void GetHeight(){} // RVA: 0x7FFAC98E6D30
        public void GetDepth(){} // RVA: 0x7FFAC98E6D80
        public void SetScriptingCallback(){} // RVA: 0x7FFAC98E6DD0
        public void GetDataRaw(){} // RVA: 0x7FFAC98E6E30
        public void IsDone_Injected(){} // RVA: 0x7FFAC98E6BA0
        public void HasError_Injected(){} // RVA: 0x7FFAC98E6BF0
        public void GetLayerCount_Injected(){} // RVA: 0x7FFAC98E6C40
        public void GetLayerDataSize_Injected(){} // RVA: 0x7FFAC98E6C90
        public void GetWidth_Injected(){} // RVA: 0x7FFAC98E6CE0
        public void GetHeight_Injected(){} // RVA: 0x7FFAC98E6D30
        public void GetDepth_Injected(){} // RVA: 0x7FFAC98E6D80
        public void SetScriptingCallback_Injected(){} // RVA: 0x7FFAC98E6DD0
        public void GetDataRaw_Injected(){} // RVA: 0x7FFAC98E6E30
    }

    public class AsyncRequestNativeArrayData : ValueType
    {
        public void* nativeArrayBuffer; // 0x10
        public long lengthInBytes; // 0x18
    }

    public class BatchCullingContext : ValueType
    {
        public Unity.Collections.NativeArray`1<UnityEngine.Plane> cullingPlanes; // 0x10
        public Unity.Collections.NativeArray`1<UnityEngine.Rendering.CullingSplit> cullingSplits; // 0x20
        public UnityEngine.Rendering.LODParameters lodParameters; // 0x30
        public UnityEngine.Matrix4x4 localToWorldMatrix; // 0x4C
        public 0x6B187548 viewType; // 0x8C
        public 0x6B1875A0 projectionType; // 0x90
        public 0x6B1874F0 cullingFlags; // 0x94
        public UnityEngine.Rendering.BatchPackedCullingViewID viewID; // 0x98
        public uint cullingLayerMask; // 0xA0
        public ulong sceneCullingMask; // 0xA8
        public byte isOrthographic; // 0xB0
        public int receiverPlaneOffset; // 0xB4
        public int receiverPlaneCount; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98EFE20
    }

    public class BatchCullingOutput : ValueType
    {
        public Unity.Collections.NativeArray`1<UnityEngine.Rendering.BatchCullingOutputDrawCommands> drawCommands; // 0x10
    }

    public class BatchCullingOutputDrawCommands : ValueType
    {
        public UnityEngine.Rendering.BatchDrawCommand* drawCommands; // 0x10
        public int* visibleInstances; // 0x18
        public UnityEngine.Rendering.BatchDrawRange* drawRanges; // 0x20
        public float* instanceSortingPositions; // 0x28
        public int* drawCommandPickingInstanceIDs; // 0x30
        public int drawCommandCount; // 0x38
        public int visibleInstanceCount; // 0x3C
        public int drawRangeCount; // 0x40
        public int instanceSortingPositionFloatCount; // 0x44
    }

    public class BatchDrawCommand : ValueType
    {
        public uint visibleOffset; // 0x10
        public uint visibleCount; // 0x14
        public UnityEngine.Rendering.BatchID batchID; // 0x18
        public UnityEngine.Rendering.BatchMaterialID materialID; // 0x1C
        public UnityEngine.Rendering.BatchMeshID meshID; // 0x20
        public ushort submeshIndex; // 0x24
        public ushort splitVisibilityMask; // 0x26
        public 0x6B187498 flags; // 0x28
        public int sortingPosition; // 0x2C
    }

    public class BatchDrawRange : ValueType
    {
        public uint drawCommandsBegin; // 0x10
        public uint drawCommandsCount; // 0x14
        public UnityEngine.Rendering.BatchFilterSettings filterSettings; // 0x18
    }

    public class BatchFilterSettings : ValueType
    {
        public uint renderingLayerMask; // 0x10
        public byte layer; // 0x14
        public byte m_motionMode; // 0x15
        public byte m_shadowMode; // 0x16
        public byte m_receiveShadows; // 0x17
        public byte m_staticShadowCaster; // 0x18
        public byte m_allDepthSorted; // 0x19
    }

    public class BatchID : ValueType
    {
        public UnityEngine.Rendering.BatchID Null;
        public uint value; // 0x10

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAC8F93F90
        public void Equals(){} // RVA: 0x7FFAC9855270 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC98EFB80
    }

    public class BatchMaterialID : ValueType
    {
        public UnityEngine.Rendering.BatchMaterialID Null;
        public uint value; // 0x10

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAC8F93F90
        public void Equals(){} // RVA: 0x7FFAC9855270 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC98EFC60
    }

    public class BatchMeshID : ValueType
    {
        public UnityEngine.Rendering.BatchMeshID Null;
        public uint value; // 0x10

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAC8F93F90
        public void Equals(){} // RVA: 0x7FFAC9855270 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC98EFD40
    }

    public class BatchPackedCullingViewID : ValueType
    {
        public ulong handle; // 0x10

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAC98EFD80
        public void Equals(){} // RVA: 0x7FFAC98EFD90 | overloaded x2
    }

    public class BatchRendererCullingOutput : ValueType
    {
        public Unity.Jobs.JobHandle cullingJobsFence; // 0x10
        public UnityEngine.Matrix4x4 localToWorldMatrix; // 0x20
        public UnityEngine.Plane* cullingPlanes; // 0x60
        public int cullingPlaneCount; // 0x68
        public int receiverPlaneOffset; // 0x6C
        public int receiverPlaneCount; // 0x70
        public UnityEngine.Rendering.CullingSplit* cullingSplits; // 0x78
        public int cullingSplitCount; // 0x80
        public 0x6B187548 viewType; // 0x84
        public 0x6B1875A0 projectionType; // 0x88
        public 0x6B1874F0 cullingFlags; // 0x8C
        public ulong viewID; // 0x90
        public uint cullingLayerMask; // 0x98
        public ulong sceneCullingMask; // 0xA0
        public UnityEngine.Rendering.BatchCullingOutputDrawCommands* drawCommands; // 0xA8
    }

    public class BatchRendererGroup : Object
    {
        public UIntPtr m_GroupHandle; // 0x10
        public OnPerformCulling m_PerformCulling; // 0x18

        // ── Methods ──
        public void InvokeOnPerformCulling(){} // RVA: 0x7FFAC98EFED0
    }

    public class CameraEventUtils : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAC98E7D00
    }

    public class CameraProperties : ValueType
    {
        public UnityEngine.Rect screenRect; // 0x10
        public UnityEngine.Vector3 viewDir; // 0x20
        public float projectionNear; // 0x2C
        public float projectionFar; // 0x30
        public float cameraNear; // 0x34
        public float cameraFar; // 0x38
        public float cameraAspect; // 0x3C
        public UnityEngine.Matrix4x4 cameraToWorld; // 0x40
        public UnityEngine.Matrix4x4 actualWorldToClip; // 0x80
        public UnityEngine.Matrix4x4 cameraClipToWorld; // 0xC0
        public UnityEngine.Matrix4x4 cameraWorldToClip; // 0x100
        public UnityEngine.Matrix4x4 implicitProjection; // 0x140
        public UnityEngine.Matrix4x4 stereoWorldToClipLeft; // 0x180
        public UnityEngine.Matrix4x4 stereoWorldToClipRight; // 0x1C0
        public UnityEngine.Matrix4x4 worldToCamera; // 0x200
        public UnityEngine.Vector3 up; // 0x240
        public UnityEngine.Vector3 right; // 0x24C
        public UnityEngine.Vector3 transformDirection; // 0x258
        public UnityEngine.Vector3 cameraEuler; // 0x264
        public UnityEngine.Vector3 velocity; // 0x270
        public float farPlaneWorldSpaceLength; // 0x27C
        public uint rendererCount; // 0x280
        public <m_ShadowCullPlanes>e__FixedBuffer m_ShadowCullPlanes; // 0x284
        public <m_CameraCullPlanes>e__FixedBuffer m_CameraCullPlanes; // 0x2E4
        public float baseFarDistance; // 0x344
        public UnityEngine.Vector3 shadowCullCenter; // 0x348
        public <layerCullDistances>e__FixedBuffer layerCullDistances; // 0x354
        public int layerCullSpherical; // 0x3D4
        public UnityEngine.Rendering.CoreCameraValues coreCameraValues; // 0x3D8
        public uint cameraType; // 0x3E4
        public int projectionIsOblique; // 0x3E8
        public int isImplicitProjectionMatrix; // 0x3EC

        // ── Methods ──
        public void GetShadowCullingPlane(){} // RVA: 0x7FFAC98F05C0
        public void GetCameraCullingPlane(){} // RVA: 0x7FFAC98F06D0
        public void Equals(){} // RVA: 0x7FFAC98F2090 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC98F21D0
    }

    public class CommandBuffer : Object
    {
        public UIntPtr name; // 0x10

        // ── Methods ──
        public void WaitAllAsyncReadbackRequests(){} // RVA: 0x7FFAC98E9110
        public void RequestAsyncReadback(){} // RVA: 0x7FFAC98E9230 | overloaded x2
        public void Internal_RequestAsyncReadback_4(){} // RVA: 0x7FFAC98E9310
        public void Internal_RequestAsyncReadback_5(){} // RVA: 0x7FFAC98E93A0
        public void Internal_SetSinglePassStereo(){} // RVA: 0x7FFAC98E9430
        public void InitBuffer(){} // RVA: 0x7FFAC98E9490
        public void ReleaseBuffer(){} // RVA: 0x7FFAC98E94E0
        public void SetComputeFloatParam(){} // RVA: 0x7FFAC98EBE90 | overloaded x2
        public void SetComputeIntParam(){} // RVA: 0x7FFAC98EBF50 | overloaded x2
        public void SetComputeVectorParam(){} // RVA: 0x7FFAC98EC010 | overloaded x2
        public void Internal_SetComputeFloats(){} // RVA: 0x7FFAC98E96B0
        public void Internal_SetComputeTextureParam(){} // RVA: 0x7FFAC98E9730
        public void Internal_SetComputeBufferParam(){} // RVA: 0x7FFAC98E97C0
        public void Internal_DispatchCompute(){} // RVA: 0x7FFAC98E9850
        public void set_name(){} // RVA: 0x7FFAC98E98E0
        public void Clear(){} // RVA: 0x7FFAC98E9940
        public void Internal_DrawMesh(){} // RVA: 0x7FFAC98E9990
        public void Internal_DrawRenderer(){} // RVA: 0x7FFAC98E9A30
        public void Internal_DrawMeshInstancedIndirectGraphicsBuffer(){} // RVA: 0x7FFAC98E9AC0
        public void SetViewport(){} // RVA: 0x7FFAC98E9B50
        public void CopyTexture_Internal(){} // RVA: 0x7FFAC98E9BB0
        public void Blit_Texture(){} // RVA: 0x7FFAC98E9C40
        public void Blit_Identifier(){} // RVA: 0x7FFAC98E9D00
        public void GetTemporaryRT(){} // RVA: 0x7FFAC98EA520 | overloaded x11
        public void GetTemporaryRTWithDescriptor(){} // RVA: 0x7FFAC98EA400
        public void ReleaseTemporaryRT(){} // RVA: 0x7FFAC98EA5B0
        public void ClearRenderTarget(){} // RVA: 0x7FFAC98EA6A0 | overloaded x2
        public void SetGlobalFloat(){} // RVA: 0x7FFAC98EA7A0
        public void SetGlobalInteger(){} // RVA: 0x7FFAC98EA810
        public void SetGlobalVector(){} // RVA: 0x7FFAC98EA880
        public void SetGlobalColor(){} // RVA: 0x7FFAC98EA8F0
        public void EnableShaderKeyword(){} // RVA: 0x7FFAC98EA960
        public void DisableShaderKeyword(){} // RVA: 0x7FFAC98EA9C0
        public void SetViewProjectionMatrices(){} // RVA: 0x7FFAC98EAA20
        public void SetExecutionFlags(){} // RVA: 0x7FFAC98EAA90
        public void ValidateAgainstExecutionFlags(){} // RVA: 0x7FFAC98EAAF0
        public void SetGlobalTexture_Impl(){} // RVA: 0x7FFAC98EAB60
        public void SetGlobalGraphicsBufferInternal(){} // RVA: 0x7FFAC98EABE0
        public void BeginSample(){} // RVA: 0x7FFAC98EAC50
        public void EndSample(){} // RVA: 0x7FFAC98EACB0
        public void IssuePluginEventAndDataInternal(){} // RVA: 0x7FFAC98EAD10
        public void SetRenderTarget(){} // RVA: 0x7FFAC98EB810 | overloaded x7
        public void SetRenderTargetSingle_Internal(){} // RVA: 0x7FFAC98EBAA0
        public void SetRenderTargetColorDepth_Internal(){} // RVA: 0x7FFAC98EBB40
        public void SetRenderTargetMulti_Internal(){} // RVA: 0x7FFAC98EBBF0
        public void Finalize(){} // RVA: 0x7FFAC98EBCA0
        public void Dispose(){} // RVA: 0x7FFAC98EBDD0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC98EBE30
        public void Release(){} // RVA: 0x7FFAC98EBE80
        public void SetComputeFloatParams(){} // RVA: 0x7FFAC98EC0E0
        public void SetComputeTextureParam(){} // RVA: 0x7FFAC98EC280 | overloaded x2
        public void SetComputeBufferParam(){} // RVA: 0x7FFAC98EC360
        public void DispatchCompute(){} // RVA: 0x7FFAC98E9850
        public void DrawMesh(){} // RVA: 0x7FFAC98EC8B0 | overloaded x2
        public void DrawRenderer(){} // RVA: 0x7FFAC98ECCC0 | overloaded x3
        public void DrawMeshInstancedIndirect(){} // RVA: 0x7FFAC98ED160 | overloaded x2
        public void CopyTexture(){} // RVA: 0x7FFAC98ED270 | overloaded x2
        public void Blit(){} // RVA: 0x7FFAC98ED6D0 | overloaded x4
        public void SetGlobalTexture(){} // RVA: 0x7FFAC98ED900 | overloaded x3
        public void SetGlobalBuffer(){} // RVA: 0x7FFAC98EABE0
        public void SetSinglePassStereo(){} // RVA: 0x7FFAC98E9430
        public void IssuePluginEventAndData(){} // RVA: 0x7FFAC98ED920
        public void SetComputeVectorParam_Injected(){} // RVA: 0x7FFAC98EDA40
        public void Internal_DrawMesh_Injected(){} // RVA: 0x7FFAC98EDAC0
        public void SetViewport_Injected(){} // RVA: 0x7FFAC98EDB50
        public void Blit_Texture_Injected(){} // RVA: 0x7FFAC98EDBB0
        public void Blit_Identifier_Injected(){} // RVA: 0x7FFAC98EDC40
        public void GetTemporaryRTWithDescriptor_Injected(){} // RVA: 0x7FFAC98EDCD0
        public void ClearRenderTarget_Injected(){} // RVA: 0x7FFAC98EDD50
        public void SetGlobalVector_Injected(){} // RVA: 0x7FFAC98EDDD0
        public void SetGlobalColor_Injected(){} // RVA: 0x7FFAC98EDE40
        public void SetViewProjectionMatrices_Injected(){} // RVA: 0x7FFAC98EDEB0
        public void SetRenderTargetSingle_Internal_Injected(){} // RVA: 0x7FFAC98EDF20
        public void SetRenderTargetColorDepth_Internal_Injected(){} // RVA: 0x7FFAC98EDFB0
        public void SetRenderTargetMulti_Internal_Injected(){} // RVA: 0x7FFAC98EE040
    }

    public class CoreCameraValues : ValueType
    {
        public int filterMode; // 0x10
        public uint cullingMask; // 0x14
        public int instanceID; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC98F04E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC98F05A0
    }

    public class CullingSplit : ValueType
    {
        public UnityEngine.Vector3 sphereCenter; // 0x10
        public float sphereRadius; // 0x1C
        public int cullingPlaneOffset; // 0x20
        public int cullingPlaneCount; // 0x24
        public float cascadeBlendCullingFactor; // 0x28
        public float nearPlane; // 0x2C
        public UnityEngine.Matrix4x4 cullingMatrix; // 0x30
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
        public void get_lightsUseLinearIntensity(){} // RVA: 0x7FFAC98E8CD0
        public void get_defaultRenderingLayerMask(){} // RVA: 0x7FFAC98E8D20
        public void get_INTERNAL_currentRenderPipeline(){} // RVA: 0x7FFAC98E8D70
        public void get_currentRenderPipeline(){} // RVA: 0x7FFAC98E8DC0
        public void get_INTERNAL_defaultRenderPipeline(){} // RVA: 0x7FFAC98E8E80
        public void get_defaultRenderPipeline(){} // RVA: 0x7FFAC98E8ED0
        public void GetShaderMode(){} // RVA: 0x7FFAC98E8F90
    }

    public class LODParameters : ValueType
    {
        public int m_IsOrthographic; // 0x10
        public UnityEngine.Vector3 m_CameraPosition; // 0x14
        public float m_FieldOfView; // 0x20
        public float m_OrthoSize; // 0x24
        public int m_CameraPixelHeight; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC98F37F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC98F38A0
    }

    public class LocalKeyword : ValueType
    {
        public UnityEngine.Rendering.LocalKeywordSpace m_SpaceInfo; // 0x10
        public string m_Name; // 0x18
        public uint m_Index; // 0x20

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC86B4B80
        public void Equals(){} // RVA: 0x7FFAC98F6C00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC98F6C50
    }

    public class LocalKeywordSpace : ValueType
    {
        public UIntPtr m_KeywordSpace; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC69C9070 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC98F6CE0
        public void GetHashCode(){} // RVA: 0x7FFAC8F93F90
    }

    public class ObjectIdRequest : Object
    {
        public UnityEngine.RenderTexture destination; // 0x10

        // ── Methods ──
        public void get_destination(){} // RVA: 0x7FFAC2F3C380
    }

    public class OnDemandRendering : Object
    {
        public int renderFrameInterval;

        // ── Methods ──
        public void get_renderFrameInterval(){} // RVA: 0x7FFAC98E8FE0
        public void GetRenderFrameInterval(){} // RVA: 0x7FFAC98E9040
        public void .cctor(){} // RVA: 0x7FFAC98E90D0
    }

    public class ReflectionProbeBlendInfo : ValueType
    {
        public UnityEngine.ReflectionProbe probe; // 0x10
        public float weight; // 0x18
    }

    public class RenderPipeline : Object
    {
        public bool disposed; // 0x10

        // ── Methods ──
        public void Render(){} // RVA: 0x7FFAC98F3960 | overloaded x2
        public void ProcessRenderRequests(){} // RVA: 0x7FFAC2E8DC40
        public void IsRenderRequestSupported(){} // RVA: 0x7FFAC2E8DC40
        public void InternalRender(){} // RVA: 0x7FFAC98F39E0
        public void InternalProcessRenderRequests(){} // RVA: 0x7FFAC2E8DC40
        public void get_disposed(){} // RVA: 0x7FFAC2FEB5E0
        public void set_disposed(){} // RVA: 0x7FFAC2FEB5F0
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
    }

    public class RenderPipelineAsset : ScriptableObject
    {
        public object renderingLayerMaskNames;
        public object prefixedRenderingLayerMaskNames;
        public object defaultMaterial;
        public object autodeskInteractiveShader;
        public object autodeskInteractiveTransparentShader;
        public object autodeskInteractiveMaskedShader;
        public object terrainDetailLitShader;
        public object terrainDetailGrassShader;
        public object terrainDetailGrassBillboardShader;
        public object defaultParticleMaterial;
        public object defaultLineMaterial;
        public object defaultTerrainMaterial;
        public object defaultUIMaterial;
        public object defaultUIOverdrawMaterial;
        public object defaultUIETC1SupportedMaterial;
        public object default2DMaterial;
        public object default2DMaskMaterial;
        public object defaultShader;
        public object defaultSpeedTree7Shader;
        public object defaultSpeedTree8Shader;
        public object renderPipelineShaderTag;

        // ── Methods ──
        public void InternalCreatePipeline(){} // RVA: 0x7FFAC98F3AE0
        public void get_renderingLayerMaskNames(){} // RVA: 0x7FFAC34F9180
        public void get_prefixedRenderingLayerMaskNames(){} // RVA: 0x7FFAC34F9180
        public void get_defaultMaterial(){} // RVA: 0x7FFAC34F9180
        public void get_autodeskInteractiveShader(){} // RVA: 0x7FFAC34F9180
        public void get_autodeskInteractiveTransparentShader(){} // RVA: 0x7FFAC34F9180
        public void get_autodeskInteractiveMaskedShader(){} // RVA: 0x7FFAC34F9180
        public void get_terrainDetailLitShader(){} // RVA: 0x7FFAC34F9180
        public void get_terrainDetailGrassShader(){} // RVA: 0x7FFAC34F9180
        public void get_terrainDetailGrassBillboardShader(){} // RVA: 0x7FFAC34F9180
        public void get_defaultParticleMaterial(){} // RVA: 0x7FFAC34F9180
        public void get_defaultLineMaterial(){} // RVA: 0x7FFAC34F9180
        public void get_defaultTerrainMaterial(){} // RVA: 0x7FFAC34F9180
        public void get_defaultUIMaterial(){} // RVA: 0x7FFAC34F9180
        public void get_defaultUIOverdrawMaterial(){} // RVA: 0x7FFAC34F9180
        public void get_defaultUIETC1SupportedMaterial(){} // RVA: 0x7FFAC34F9180
        public void get_default2DMaterial(){} // RVA: 0x7FFAC34F9180
        public void get_default2DMaskMaterial(){} // RVA: 0x7FFAC34F9180
        public void get_defaultShader(){} // RVA: 0x7FFAC34F9180
        public void get_defaultSpeedTree7Shader(){} // RVA: 0x7FFAC34F9180
        public void get_defaultSpeedTree8Shader(){} // RVA: 0x7FFAC34F9180
        public void get_renderPipelineShaderTag(){} // RVA: 0x7FFAC98F3CC0
        public void CreatePipeline(){} // RVA: 0x7FFAC2C58E90
        public void OnValidate(){} // RVA: 0x7FFAC98F3D00
        public void OnDisable(){} // RVA: 0x7FFAC98F3E70
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class RenderPipelineManager : Object
    {
        public UnityEngine.Rendering.RenderPipelineAsset currentPipeline;
        public System.Collections.Generic.List`1<UnityEngine.Camera> s_Cameras; // 0x8
        public string s_CurrentPipelineType; // 0x10
        public UnityEngine.Rendering.RenderPipeline s_CurrentPipeline; // 0x18
        public System.Action`2<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> beginCameraRendering; // 0x20
        public System.Action`2<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Camera> endCameraRendering; // 0x28
        public System.Action activeRenderPipelineTypeChanged; // 0x30
        public System.Action`2<UnityEngine.Rendering.RenderPipelineAsset,UnityEngine.Rendering.RenderPipelineAsset> activeRenderPipelineAssetChanged; // 0x38
        public System.Action activeRenderPipelineCreated; // 0x40
        public System.Action activeRenderPipelineDisposed; // 0x48

        // ── Methods ──
        public void get_currentPipeline(){} // RVA: 0x7FFAC98F3EC0
        public void set_currentPipeline(){} // RVA: 0x7FFAC98F3F20
        public void add_beginCameraRendering(){} // RVA: 0x7FFAC98F40B0
        public void remove_beginCameraRendering(){} // RVA: 0x7FFAC98F4210
        public void add_endCameraRendering(){} // RVA: 0x7FFAC98F4370
        public void remove_endCameraRendering(){} // RVA: 0x7FFAC98F44D0
        public void OnActiveRenderPipelineTypeChanged(){} // RVA: 0x7FFAC98F4630
        public void OnActiveRenderPipelineAssetChanged(){} // RVA: 0x7FFAC98F46A0
        public void HandleRenderPipelineChange(){} // RVA: 0x7FFAC98F47B0
        public void CleanupRenderPipeline(){} // RVA: 0x7FFAC98F4890
        public void GetCurrentPipelineAssetType(){} // RVA: 0x7FFAC98F4B70
        public void DoRenderLoop_Internal(){} // RVA: 0x7FFAC98F4BD0
        public void PrepareRenderPipeline(){} // RVA: 0x7FFAC98F5070
        public void IsPipelineRequireCreation(){} // RVA: 0x7FFAC98F5330
        public void .cctor(){} // RVA: 0x7FFAC98F5490
    }

    public class RenderTargetIdentifier : ValueType
    {
        public int AllDepthSlices;
        public 0x6B1868E8 m_Type; // 0x10
        public int m_NameID; // 0x14
        public int m_InstanceID; // 0x18
        public UIntPtr m_BufferPointer; // 0x20
        public int m_MipLevel; // 0x28
        public 0x6B17C128 m_CubeFace; // 0x2C
        public int m_DepthSlice; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98E8650 | overloaded x5
        public void op_Implicit(){} // RVA: 0x7FFAC98E8780 | overloaded x4
        public void ToString(){} // RVA: 0x7FFAC98E87E0
        public void GetHashCode(){} // RVA: 0x7FFAC98E8B20
        public void Equals(){} // RVA: 0x7FFAC98E8BC0 | overloaded x2
    }

    public class ScriptableCullingParameters : ValueType
    {
        public int cullingPlaneCount; // 0x10
        public UnityEngine.Rendering.LODParameters m_LODParameters; // 0x14
        public int maximumCullingPlaneCount;
        public <m_CullingPlanes>e__FixedBuffer m_CullingPlanes; // 0x30
        public int m_CullingPlaneCount; // 0xD0
        public uint m_CullingMask; // 0xD4
        public ulong m_SceneMask; // 0xD8
        public ulong m_ViewID; // 0xE0
        public int layerCount; // 0x4
        public <m_LayerFarCullDistances>e__FixedBuffer m_LayerFarCullDistances; // 0xE8
        public int m_LayerCull; // 0x168
        public UnityEngine.Matrix4x4 m_CullingMatrix; // 0x16C
        public UnityEngine.Vector3 m_Origin; // 0x1AC
        public float m_ShadowDistance; // 0x1B8
        public float m_ShadowNearPlaneOffset; // 0x1BC
        public 0x6B187B78 m_CullingOptions; // 0x1C0
        public 0x6B187D88 m_ReflectionProbeSortingCriteria; // 0x1C4
        public UnityEngine.Rendering.CameraProperties m_CameraProperties; // 0x1C8
        public float m_AccurateOcclusionThreshold; // 0x5A8
        public int m_MaximumPortalCullingJobs; // 0x5AC
        public UnityEngine.Matrix4x4 m_StereoViewMatrix; // 0x5B0
        public UnityEngine.Matrix4x4 m_StereoProjectionMatrix; // 0x5F0
        public float m_StereoSeparationDistance; // 0x630
        public int m_maximumVisibleLights; // 0x634
        public bool m_ConservativeEnclosingSphere; // 0x638
        public int m_NumIterationsEnclosingSphere; // 0x63C

        // ── Methods ──
        public void get_cullingPlaneCount(){} // RVA: 0x7FFAC98F2A30
        public void GetLayerCullingDistance(){} // RVA: 0x7FFAC98F2A40
        public void GetCullingPlane(){} // RVA: 0x7FFAC98F2B40
        public void Equals(){} // RVA: 0x7FFAC98F3390 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC98F3460
        public void .cctor(){} // RVA: 0x7FFAC98F36C0
    }

    public class ScriptableRenderContext : ValueType
    {
        public UnityEngine.Rendering.ShaderTagId kRenderTypeTag;
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void GetCameras_Internal(){} // RVA: 0x7FFAC98F5660
        public void .ctor(){} // RVA: 0x7FFAC45BB120
        public void GetCameras(){} // RVA: 0x7FFAC98F5710
        public void Equals(){} // RVA: 0x7FFAC98F58D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8F93F90
        public void .cctor(){} // RVA: 0x7FFAC98F5970
        public void GetCameras_Internal_Injected(){} // RVA: 0x7FFAC98F5A10
    }

    public class ShaderTagId : ValueType
    {
        public int m_Id; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98F5A80
        public void Equals(){} // RVA: 0x7FFAC9855270 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC98F5B60
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
        public void get_invalidSortingGroupID(){} // RVA: 0x7FFAC98F6CF0
        public void UpdateAllSortingGroups(){} // RVA: 0x7FFAC98F6D40
        public void GetSortingGroupByIndex(){} // RVA: 0x7FFAC98F6D90
        public void get_sortingLayerName(){} // RVA: 0x7FFAC98F6DE0
        public void set_sortingLayerName(){} // RVA: 0x7FFAC98F6E30
        public void get_sortingLayerID(){} // RVA: 0x7FFAC98F6E90
        public void set_sortingLayerID(){} // RVA: 0x7FFAC98F6EE0
        public void get_sortingOrder(){} // RVA: 0x7FFAC98F6F40
        public void set_sortingOrder(){} // RVA: 0x7FFAC98F6F90
        public void get_sortAtRoot(){} // RVA: 0x7FFAC98F6FF0
        public void set_sortAtRoot(){} // RVA: 0x7FFAC98F7040
        public void get_sortingGroupID(){} // RVA: 0x7FFAC98F70A0
        public void get_sortingGroupOrder(){} // RVA: 0x7FFAC98F70F0
        public void get_index(){} // RVA: 0x7FFAC98F7140
        public void get_sortingKey(){} // RVA: 0x7FFAC98F7190
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SphericalHarmonicsL2 : ValueType
    {
        public float Item; // 0x10
        public float shr1; // 0x14
        public float shr2; // 0x18
        public float shr3; // 0x1C
        public float shr4; // 0x20
        public float shr5; // 0x24
        public float shr6; // 0x28
        public float shr7; // 0x2C
        public float shr8; // 0x30
        public float shg0; // 0x34
        public float shg1; // 0x38
        public float shg2; // 0x3C
        public float shg3; // 0x40
        public float shg4; // 0x44
        public float shg5; // 0x48
        public float shg6; // 0x4C
        public float shg7; // 0x50
        public float shg8; // 0x54
        public float shb0; // 0x58
        public float shb1; // 0x5C
        public float shb2; // 0x60
        public float shb3; // 0x64
        public float shb4; // 0x68
        public float shb5; // 0x6C
        public float shb6; // 0x70
        public float shb7; // 0x74
        public float shb8; // 0x78

        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFAC98EE0D0
        public void SetZero(){} // RVA: 0x7FFAC98EE0D0
        public void AddAmbientLight(){} // RVA: 0x7FFAC98EE120
        public void AddDirectionalLight(){} // RVA: 0x7FFAC98EE180
        public void AddDirectionalLightInternal(){} // RVA: 0x7FFAC98EE240
        public void Evaluate(){} // RVA: 0x7FFAC98EE2B0
        public void EvaluateInternal(){} // RVA: 0x7FFAC98EE420
        public void get_Item(){} // RVA: 0x7FFAC98EE490
        public void set_Item(){} // RVA: 0x7FFAC98EE690
        public void GetHashCode(){} // RVA: 0x7FFAC98EE890
        public void Equals(){} // RVA: 0x7FFAC98EED20 | overloaded x2
        public void op_Multiply(){} // RVA: 0x7FFAC98EF0E0 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFAC98EF3F0
        public void op_Equality(){} // RVA: 0x7FFAC98EF730
        public void op_Inequality(){} // RVA: 0x7FFAC98EF950
        public void SetZero_Injected(){} // RVA: 0x7FFAC98EE0D0
        public void AddAmbientLight_Injected(){} // RVA: 0x7FFAC98EFA10
        public void AddDirectionalLightInternal_Injected(){} // RVA: 0x7FFAC98EFA70
    }

    public class StencilState : ValueType
    {
        public byte enabled; // 0x10
        public byte readMask; // 0x11
        public byte writeMask; // 0x12
        public byte compareFunctionFront; // 0x13
        public byte passOperationFront; // 0x14
        public byte failOperationFront; // 0x15
        public byte zFailOperationFront; // 0x16
        public byte compareFunctionBack; // 0x17
        public byte passOperationBack; // 0x18
        public byte failOperationBack; // 0x19
        public byte zFailOperationBack; // 0x1A
        public byte m_ZFailOperationBack; // 0x1B

        // ── Methods ──
        public void set_enabled(){} // RVA: 0x7FFAC98F5B70
        public void set_readMask(){} // RVA: 0x7FFAC3B9B9B0
        public void set_writeMask(){} // RVA: 0x7FFAC3B9B990
        public void set_compareFunctionFront(){} // RVA: 0x7FFAC3B9B960
        public void set_passOperationFront(){} // RVA: 0x7FFAC3B9B950
        public void set_failOperationFront(){} // RVA: 0x7FFAC3B9B9C0
        public void set_zFailOperationFront(){} // RVA: 0x7FFAC98F5BD0
        public void set_compareFunctionBack(){} // RVA: 0x7FFAC3AD0200
        public void set_passOperationBack(){} // RVA: 0x7FFAC3AD01F0
        public void set_failOperationBack(){} // RVA: 0x7FFAC98F5BE0
        public void set_zFailOperationBack(){} // RVA: 0x7FFAC98F5BF0
        public void Equals(){} // RVA: 0x7FFAC98F5C70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC98F5DD0
    }

    public class SubMeshDescriptor : ValueType
    {
        public UnityEngine.Bounds bounds; // 0x10
        public 0x6B17BDB8 topology; // 0x28
        public int indexStart; // 0x2C
        public int indexCount; // 0x30
        public int baseVertex; // 0x34
        public int firstVertex; // 0x38
        public int vertexCount; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98E7D10
        public void get_bounds(){} // RVA: 0x7FFAC4A6D1E0
        public void set_bounds(){} // RVA: 0x7FFAC4BAD070
        public void get_topology(){} // RVA: 0x7FFAC3157800
        public void set_topology(){} // RVA: 0x7FFAC392CD10
        public void get_indexStart(){} // RVA: 0x7FFAC44357F0
        public void set_indexStart(){} // RVA: 0x7FFAC44474D0
        public void get_indexCount(){} // RVA: 0x7FFAC30DBBE0
        public void set_indexCount(){} // RVA: 0x7FFAC35DB7A0
        public void get_baseVertex(){} // RVA: 0x7FFAC3921980
        public void set_baseVertex(){} // RVA: 0x7FFAC41674D0
        public void get_firstVertex(){} // RVA: 0x7FFAC32EC4C0
        public void set_firstVertex(){} // RVA: 0x7FFAC369A6E0
        public void get_vertexCount(){} // RVA: 0x7FFAC3C891D0
        public void set_vertexCount(){} // RVA: 0x7FFAC45B6490
        public void ToString(){} // RVA: 0x7FFAC98E7D50
    }

    public class SupportedRenderingFeatures : Object
    {
        public UnityEngine.Rendering.SupportedRenderingFeatures active;
        public 0x6B187FF0 defaultMixedLightingModes; // 0x10
        public 0x6B188048 mixedLightingModes; // 0x14
        public 0x6B188048 lightmapBakeTypes; // 0x18
        public 0x6B17BBA8 lightmapsModes; // 0x1C
        public 0x6B17C338 enlightenLightmapper; // 0x20
        public bool enlighten; // 0x24
        public bool rendersUIOverlay; // 0x25
        public bool autoAmbientProbeBaking; // 0x26
        public bool autoDefaultReflectionProbeBaking; // 0x27
        public bool overridesLightProbeSystem; // 0x28
        public bool <reflectionProbes>k__BackingField; // 0x29
        public bool <reflectionProbesBlendDistance>k__BackingField; // 0x2A
        public bool <rendererPriority>k__BackingField; // 0x2B
        public bool <rendersUIOverlay>k__BackingField; // 0x2C
        public bool <overridesEnvironmentLighting>k__BackingField; // 0x2D
        public bool <overridesFog>k__BackingField; // 0x2E
        public bool <overridesRealtimeReflectionProbes>k__BackingField; // 0x2F
        public bool <overridesOtherLightingSettings>k__BackingField; // 0x30
        public bool <editableMaterialRenderQueue>k__BackingField; // 0x31
        public bool <overridesLODBias>k__BackingField; // 0x32
        public bool <overridesMaximumLODLevel>k__BackingField; // 0x33
        public bool <overridesEnableLODCrossFade>k__BackingField; // 0x34
        public bool <rendererProbes>k__BackingField; // 0x35
        public bool <particleSystemInstancing>k__BackingField; // 0x36
        public bool <autoAmbientProbeBaking>k__BackingField; // 0x37
        public bool <autoDefaultReflectionProbeBaking>k__BackingField; // 0x38
        public bool <overridesShadowmask>k__BackingField; // 0x39
        public bool <overridesLightProbeSystem>k__BackingField; // 0x3A
        public bool <supportsHDR>k__BackingField; // 0x3B
        public string <overridesLightProbeSystemWarningMessage>k__BackingField; // 0x40

        // ── Methods ──
        public void get_active(){} // RVA: 0x7FFAC98F5E60
        public void set_active(){} // RVA: 0x7FFAC98F5F80
        public void get_defaultMixedLightingModes(){} // RVA: 0x7FFAC33D5A20
        public void get_mixedLightingModes(){} // RVA: 0x7FFAC3157800
        public void get_lightmapBakeTypes(){} // RVA: 0x7FFAC44357F0
        public void get_lightmapsModes(){} // RVA: 0x7FFAC30DBBE0
        public void get_enlightenLightmapper(){} // RVA: 0x7FFAC2F3C7C0
        public void get_enlighten(){} // RVA: 0x7FFAC3FA0EA0
        public void get_rendersUIOverlay(){} // RVA: 0x7FFAC3000230
        public void get_autoAmbientProbeBaking(){} // RVA: 0x7FFAC4738E80
        public void get_autoDefaultReflectionProbeBaking(){} // RVA: 0x7FFAC31D95D0
        public void get_overridesLightProbeSystem(){} // RVA: 0x7FFAC3F7B7C0
        public void FallbackMixedLightingModeByRef(){} // RVA: 0x7FFAC98F6030
        public void IsMixedLightingModeSupported(){} // RVA: 0x7FFAC98F6260
        public void IsMixedLightingModeSupportedByRef(){} // RVA: 0x7FFAC98F63D0
        public void IsLightmapBakeTypeSupported(){} // RVA: 0x7FFAC98F6530
        public void IsLightmapBakeTypeSupportedByRef(){} // RVA: 0x7FFAC98F6660
        public void IsLightmapsModeSupportedByRef(){} // RVA: 0x7FFAC98F6760
        public void IsLightmapperSupportedByRef(){} // RVA: 0x7FFAC98F67D0
        public void IsUIOverlayRenderedBySRP(){} // RVA: 0x7FFAC98F6850
        public void IsAutoAmbientProbeBakingSupported(){} // RVA: 0x7FFAC98F68B0
        public void IsAutoDefaultReflectionProbeBakingSupported(){} // RVA: 0x7FFAC98F6910
        public void OverridesLightProbeSystem(){} // RVA: 0x7FFAC98F6970
        public void FallbackLightmapperByRef(){} // RVA: 0x7FFAC49FC570
        public void .ctor(){} // RVA: 0x7FFAC98F69D0
        public void .cctor(){} // RVA: 0x7FFAC98F6AA0
    }

    public class VertexAttributeDescriptor : ValueType
    {
        public 0x6B186470 attribute; // 0x10
        public 0x6B186418 format; // 0x14
        public int dimension; // 0x18
        public int stream; // 0x1C

        // ── Methods ──
        public void get_attribute(){} // RVA: 0x7FFAC4420210
        public void set_attribute(){} // RVA: 0x7FFAC336D8B0
        public void get_format(){} // RVA: 0x7FFAC44202A0
        public void set_format(){} // RVA: 0x7FFAC4420230
        public void get_dimension(){} // RVA: 0x7FFAC49C7500
        public void set_dimension(){} // RVA: 0x7FFAC49C7510
        public void get_stream(){} // RVA: 0x7FFAC49C7520
        public void set_stream(){} // RVA: 0x7FFAC49C7530
        public void .ctor(){} // RVA: 0x7FFAC831F680
        public void ToString(){} // RVA: 0x7FFAC98E80C0
        public void GetHashCode(){} // RVA: 0x7FFAC98E8320
        public void Equals(){} // RVA: 0x7FFAC98679D0 | overloaded x2
    }

}