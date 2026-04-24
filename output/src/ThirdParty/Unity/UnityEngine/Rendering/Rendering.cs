// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering
// Classes: 27
// Methods: 295

namespace ThirdParty.Unity.UnityEngine.Rendering
{
    public class AsyncGPUReadbackRequest : ValueType
    {
        public UIntPtr done; // 0x10
        public int hasError; // 0x18

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
        public IntPtr nativeArrayBuffer; // 0x10
        public long lengthInBytes; // 0x18
    }

    public class BatchCullingContext : ValueType
    {
        public ÍÎÏÎÎ.ÌÌ<?> cullingPlanes; // 0x10
        public ÍÎÏÎÎ.ÌÌ<ons.jected> cullingSplits; // 0x20
        public ons.ine.Sprites lodParameters; // 0x30
        public tSizeBias localToWorldMatrix; // 0x4C
        public ons.et_position_Injected viewType; // 0x8C
        public ons._Injected projectionType; // 0x90
        public ons.nstrainProportionsScale cullingFlags; // 0x94
        public ons._Injected viewID; // 0x98
        public uint cullingLayerMask; // 0xA0
        public ulong sceneCullingMask; // 0xA8
        public byte isOrthographic; // 0xB0
        public int receiverPlaneOffset; // 0xB4
        public int receiverPlaneCount; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54D0FE20
    }

    public class BatchID : ValueType
    {
        public ons.onUniformScaleTransform Null;
        public uint value; // 0x10

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFD543B3F90
        public void Equals(){} // RVA: 0x7FFD54C75270 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD54D0FB80
    }

    public class BatchMaterialID : ValueType
    {
        public ons.mScaleTransform Null;
        public uint value; // 0x10

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFD543B3F90
        public void Equals(){} // RVA: 0x7FFD54C75270 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD54D0FC60
    }

    public class BatchMeshID : ValueType
    {
        public ons.get_constrainProportionsScale Null;
        public uint value; // 0x10

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFD543B3F90
        public void Equals(){} // RVA: 0x7FFD54C75270 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD54D0FD40
    }

    public class BatchPackedCullingViewID : ValueType
    {
        public ulong handle; // 0x10

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFD54D0FD80
        public void Equals(){} // RVA: 0x7FFD54D0FD90 | overloaded x2
    }

    public class BatchRendererCullingOutput : ValueType
    {
        public ÍÏÌÏÌÏÌÏÍÎÌÎÌÏÏÏÎ.ÎÎ cullingJobsFence; // 0x10
        public tSizeBias localToWorldMatrix; // 0x20
        public IntPtr cullingPlanes; // 0x60
        public int cullingPlaneCount; // 0x68
        public int receiverPlaneOffset; // 0x6C
        public int receiverPlaneCount; // 0x70
        public IntPtr cullingSplits; // 0x78
        public int cullingSplitCount; // 0x80
        public ons.et_position_Injected viewType; // 0x84
        public ons._Injected projectionType; // 0x88
        public ons.nstrainProportionsScale cullingFlags; // 0x8C
        public ulong viewID; // 0x90
        public uint cullingLayerMask; // 0x98
        public ulong sceneCullingMask; // 0xA0
        public IntPtr drawCommands; // 0xA8
    }

    public class BatchRendererGroup : Object
    {
        public UIntPtr m_GroupHandle; // 0x10
        public tCurrentMeshData m_PerformCulling; // 0x18

        // ── Methods ──
        public void InvokeOnPerformCulling(){} // RVA: 0x7FFD54D0FED0
    }

    public class CameraProperties : ValueType
    {
        public dRecorder screenRect; // 0x10
        public amut viewDir; // 0x20
        public float projectionNear; // 0x2C
        public float projectionFar; // 0x30
        public float cameraNear; // 0x34
        public float cameraFar; // 0x38
        public float cameraAspect; // 0x3C
        public tSizeBias cameraToWorld; // 0x40
        public tSizeBias actualWorldToClip; // 0x80
        public tSizeBias cameraClipToWorld; // 0xC0
        public tSizeBias cameraWorldToClip; // 0x100
        public tSizeBias implicitProjection; // 0x140
        public tSizeBias stereoWorldToClipLeft; // 0x180
        public tSizeBias stereoWorldToClipRight; // 0x1C0
        public tSizeBias worldToCamera; // 0x200
        public amut up; // 0x240
        public amut right; // 0x24C
        public amut transformDirection; // 0x258
        public amut cameraEuler; // 0x264
        public amut velocity; // 0x270
        public float farPlaneWorldSpaceLength; // 0x27C
        public uint rendererCount; // 0x280
        public daryTextures m_ShadowCullPlanes; // 0x284
        public r m_CameraCullPlanes; // 0x2E4
        public float baseFarDistance; // 0x344
        public amut shadowCullCenter; // 0x348
        public ndaryTexture layerCullDistances; // 0x354
        public int layerCullSpherical; // 0x3D4
        public ons.xtureProperties coreCameraValues; // 0x3D8
        public uint cameraType; // 0x3E4
        public int projectionIsOblique; // 0x3E8
        public int isImplicitProjectionMatrix; // 0x3EC

        // ── Methods ──
        public void GetShadowCullingPlane(){} // RVA: 0x7FFD54D105C0
        public void GetCameraCullingPlane(){} // RVA: 0x7FFD54D106D0
        public void Equals(){} // RVA: 0x7FFD54D12090 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54D121D0
    }

    public class CommandBuffer : Object
    {
        public UIntPtr name; // 0x10

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
        public int filterMode; // 0x10
        public uint cullingMask; // 0x14
        public int instanceID; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD54D104E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54D105A0
    }

    public class CullingSplit : ValueType
    {
        public amut sphereCenter; // 0x10
        public float sphereRadius; // 0x1C
        public int cullingPlaneOffset; // 0x20
        public int cullingPlaneCount; // 0x24
        public float cascadeBlendCullingFactor; // 0x28
        public float nearPlane; // 0x2C
        public tSizeBias cullingMatrix; // 0x30
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
        public int m_IsOrthographic; // 0x10
        public amut m_CameraPosition; // 0x14
        public float m_FieldOfView; // 0x20
        public float m_OrthoSize; // 0x24
        public int m_CameraPixelHeight; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD54D137F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54D138A0
    }

    public class LocalKeyword : ValueType
    {
        public ons.nt`1 m_SpaceInfo; // 0x10
        public string m_Name; // 0x18
        public uint m_Index; // 0x20

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD53AD4B80
        public void Equals(){} // RVA: 0x7FFD54D16C00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54D16C50
    }

    public class LocalKeywordSpace : ValueType
    {
        public UIntPtr m_KeywordSpace; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD51DE9070 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD54D16CE0
        public void GetHashCode(){} // RVA: 0x7FFD543B3F90
    }

    public class OnDemandRendering : Object
    {
        public int renderFrameInterval;

        // ── Methods ──
        public void get_renderFrameInterval(){} // RVA: 0x7FFD54D08FE0
        public void GetRenderFrameInterval(){} // RVA: 0x7FFD54D09040
        public void .cctor(){} // RVA: 0x7FFD54D090D0
    }

    public class ReflectionProbeBlendInfo : ValueType
    {
        public ÍÌÍÏÏÍÎÌÍÌÌÏÍÎÏÏ probe; // 0x10
        public float weight; // 0x18
    }

    public class RenderPipeline : Object
    {
        public bool disposed; // 0x10

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
        public ons.sedSizeLong currentPipeline;
        public URA.woDigitYearMax<ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ> s_Cameras; // 0x8
        public string s_CurrentPipelineType; // 0x10
        public ons.Requested s_CurrentPipeline; // 0x18
        public rectoryInformation<ons.raseRecognizedEventArgs,ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ> beginCameraRendering; // 0x20
        public rectoryInformation<ons.raseRecognizedEventArgs,ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ> endCameraRendering; // 0x28
        public ÎÌÍÏÏÌÍÏ activeRenderPipelineTypeChanged; // 0x30
        public rectoryInformation<ons.sedSizeLong,ons.sedSizeLong> activeRenderPipelineAssetChanged; // 0x38
        public ÎÌÍÏÏÌÍÏ activeRenderPipelineCreated; // 0x40
        public ÎÌÍÏÏÌÍÏ activeRenderPipelineDisposed; // 0x48

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
        public int cullingPlaneCount; // 0x10
        public ons.ine.Sprites m_LODParameters; // 0x14
        public int maximumCullingPlaneCount;
        public FromAttributeDataForType m_CullingPlanes; // 0x30
        public int m_CullingPlaneCount; // 0xD0
        public uint m_CullingMask; // 0xD4
        public ulong m_SceneMask; // 0xD8
        public ulong m_ViewID; // 0xE0
        public int layerCount; // 0x4
        public leteTypeRedirection m_LayerFarCullDistances; // 0xE8
        public int m_LayerCull; // 0x168
        public tSizeBias m_CullingMatrix; // 0x16C
        public amut m_Origin; // 0x1AC
        public float m_ShadowDistance; // 0x1B8
        public float m_ShadowNearPlaneOffset; // 0x1BC
        public ons.spriteAtlasTextureScale m_CullingOptions; // 0x1C0
        public ons.? m_ReflectionProbeSortingCriteria; // 0x1C4
        public ons.etSpriteBounds m_CameraProperties; // 0x1C8
        public float m_AccurateOcclusionThreshold; // 0x5A8
        public int m_MaximumPortalCullingJobs; // 0x5AC
        public tSizeBias m_StereoViewMatrix; // 0x5B0
        public tSizeBias m_StereoProjectionMatrix; // 0x5F0
        public float m_StereoSeparationDistance; // 0x630
        public int m_maximumVisibleLights; // 0x634
        public bool m_ConservativeEnclosingSphere; // 0x638
        public int m_NumIterationsEnclosingSphere; // 0x63C

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
        public ons.CaptureResult kRenderTypeTag;
        public UIntPtr m_Ptr; // 0x10

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
        public ons.? active;
        public allsDirty defaultMixedLightingModes; // 0x10
        public object mixedLightingModes; // 0x14
        public object lightmapBakeTypes; // 0x18
        public al lightmapsModes; // 0x1C
        public idth enlightenLightmapper; // 0x20
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
        public ons.GroupSize attribute; // 0x10
        public ons.xTextureSize format; // 0x14
        public int dimension; // 0x18
        public int stream; // 0x1C

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