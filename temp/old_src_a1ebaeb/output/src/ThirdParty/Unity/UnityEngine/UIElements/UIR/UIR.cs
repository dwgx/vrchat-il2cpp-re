// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.UIR
// Classes: 17
// Methods: 157

namespace ThirdParty.Unity.UnityEngine.UIElements.UIR
{
    public class BMPAlloc : ValueType
    {
        public object pageLine; // 0x35BC2420
        public object inheritedData; // 0x35BC2DB0

        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaaf50da60
        public void IsValid(){} // RVA: 0x7ffaaf50da80
        public void ToString(){} // RVA: 0x7ffaaf50da90
        public void .cctor(){} // RVA: 0x7ffaaf50dbc0
    }

    public class BaseShaderInfoStorage : Object
    {
        public object s_MarkerGetTextureData; // 0x3138BD40

        // ── Original Methods ──
        public void get_texture(){} // RVA: 0x7ffaa86491d0
        public void AllocateRect(){}
        public void UpdateTexture(){} // RVA: 0x7ffaa8660cc0
        public void get_disposed(){} // RVA: 0x7ffaa89fc5e0
        public void set_disposed(){} // RVA: 0x7ffaa89fc5f0
        public void Dispose(){} // RVA: 0x7ffaade593f0
        public void Dispose(){} // RVA: 0x7ffaade593f0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf508800
        // ── Binary Analysis Named ──
        public void SetTexel(){}
    }

    public class BasicNodePool`1 : LinkedPool`1
    {
        // ── Original Methods ──
        public void Reset(){} // RVA: 0x7ffaa8660d50
        public void Create(){} // RVA: 0x7ffaa8648dd0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class BasicNode`1 : LinkedPoolItem`1
    {
        // ── Original Methods ──
        public void AppendTo(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class DrawBufferRange : ValueType
    {
        public object minIndexVal; // 0x319119C0
    }

    public class GfxUpdateBufferRange : ValueType
    {
        public object source; // 0x30FF42E0
        public object `Ǐf; // 0x31948F40
    }

    public class LinkedPoolItem`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class LinkedPoolItem`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class LinkedPool`1 : Object
    {
        public object m_Limit; // 0x30D1B710

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabb2b050
        public void get_Count(){} // RVA: 0x7ffaa898dcd0
        public void set_Count(){} // RVA: 0x7ffaa898dce0
        public void Clear(){} // RVA: 0x7ffaabb2b190
        public void Return(){} // RVA: 0x7ffaabb2b250
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaabb2b1a0
    }

    public class LinkedPool`1 : Object
    {
        public object m_Limit; // 0x30DCE250

        // ── Original Methods ──
        public void .ctor(){}
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void set_Count(){} // RVA: 0x7ffaa8661210
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void Return(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa887e5c0
    }

    public class NativePagedList`1 : Object
    {
        public object m_CurrentPage; // 0x31260030
        public object _disposed; // 0x31260030, was: <disposed>k__BackingField
        public object disposed; // 0x170005D2

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void Add(){} // RVA: 0x7ffaa8660d80
        public void Reset(){} // RVA: 0x7ffaa8660cc0
        public void get_disposed(){} // RVA: 0x7ffaa864a040
        public void set_disposed(){} // RVA: 0x7ffaa86613a0
        public void Dispose(){} // RVA: 0x7ffaa86613a0
        public void Dispose(){} // RVA: 0x7ffaa86613a0
        // ── Binary Analysis Named ──
        public void GetPages(){} // RVA: 0x7ffaa86491d0
    }

    public class Page : Object
    {
        public object indices; // 0x30E663A0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf4fa260
        public void get_disposed(){} // RVA: 0x7ffaa89fc5e0
        public void set_disposed(){} // RVA: 0x7ffaa89fc5f0
        public void Dispose(){} // RVA: 0x7ffaaf4fa4c0
        public void Dispose(){} // RVA: 0x7ffaaf4fa4c0
        public void get_isEmpty(){} // RVA: 0x7ffaaf4fa7c0
    }

    public class RenderChainVEData : ValueType
    {
        public object groupTransformAncestor; // 0x35BC1A90
        public object nextDirty; // 0x35BC1A90
        public object dirtiedValues; // 0x35BC1A90
        public object lastCommand; // 0x35BC1A90
        public object isInChain; // 0x35BC1A90
        public object localTransformScaleZero; // 0x35BC1A90
        public object clipMethod; // 0x35BC1A90
        public object disableNudging; // 0x35BC1A90
        public object verticesSpace; // 0x35BC1A90
        public object transformID; // 0x35BC1A90
        public object textCoreSettingsID; // 0x35BC1A90
        public object borderLeftColorID; // 0x35BC1A90
        public object borderBottomColorID; // 0x35BC1A90
        public object backgroundColor; // 0x35BC1A90
        public object page; // 0x35BC2420
        public object ownedState; // 0x35BC2420
        public object rareData; // 0x35BC2DB0
        public object visualData; // 0x35BC2DB0
        public object matchingRulesHash; // 0x35BC2DB0

        // ── Original Methods ──
        public void get_lastClosingOrLastCommand(){} // RVA: 0x7ffaaf5086b0
        public void AllocatesID(){} // RVA: 0x7ffaaf5086c0
        public void InheritsID(){} // RVA: 0x7ffaaf508720
        public void get_isIgnoringDynamicColorHint(){} // RVA: 0x7ffaaf508780
    }

    public class ShaderInfoStorage`1 : BaseShaderInfoStorage
    {
        public object m_Format; // 0x3138BB60
        public object m_Texture; // 0x3138BB60
        public object .cctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void .ctor(){}
        public void Dispose(){} // RVA: 0x7ffaa86613a0
        public void get_texture(){} // RVA: 0x7ffaa86491d0
        public void AllocateRect(){}
        public void UpdateTexture(){} // RVA: 0x7ffaa8660cc0
        public void CreateOrExpandTexture(){} // RVA: 0x7ffaa8660cc0
        public void CpuBlit(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void SetTexel(){}
    }

    public class TempAllocator`1 : Object
    {
        public object m_Pool; // 0x313EA4F0
        public object _disposed; // 0x313EA4F0, was: <disposed>k__BackingField
        public object disposed; // 0x170005E7

        // ── Original Methods ──
        public void .ctor(){}
        public void get_disposed(){} // RVA: 0x7ffaa864a040
        public void set_disposed(){} // RVA: 0x7ffaa86613a0
        public void Dispose(){} // RVA: 0x7ffaa86613a0
        public void Dispose(){} // RVA: 0x7ffaa86613a0
        public void Alloc(){} // RVA: 0x7ffaa887e5c0
        public void Reset(){} // RVA: 0x7ffaa8660cc0
        public void ReleaseExcess(){} // RVA: 0x7ffaa8660cc0
    }

    public class UIRenderDevice : Object
    {
        public object m_VertexDecl; // 0x31911820
        public object m_LargeMeshVertexCount; // 0x31911820
        public object m_Updates; // 0x31911820
        public object m_FrameIndex; // 0x31911820
        public object m_MeshHandles; // 0x31911820
        public object m_DeviceFreeQueue; // 0x31911820
        public object m_SynchronousFree; // 0x31911820
        public object s_TransformsPropID; // 0x31911820
        public object s_MarkerFree; // 0x31911820
        public object s_MarkerBeforeDraw; // 0x31911820
        public object _maxVerticesPerPage; // 0x31911820, was: <maxVerticesPerPage>k__Backing
        public object s_DefaultShaderInfoTexARGB8; // 0x31911820
        public object value__; // 0x83AC0030

        // ── Original Methods ──
        public void get_maxVerticesPerPage(){} // RVA: 0x7ffaa9325970
        public void get_breakBatches(){} // RVA: 0x7ffaaf4ef580
        public void set_breakBatches(){} // RVA: 0x7ffaaf4ef590
        public void .cctor(){} // RVA: 0x7ffaaf4ef5a0
        public void .ctor(){} // RVA: 0x7ffaaf4efdb0
        public void .ctor(){} // RVA: 0x7ffaaf4efdb0
        public void get_defaultShaderInfoTexFloat(){} // RVA: 0x7ffaaf4f08a0
        public void get_defaultShaderInfoTexARGB8(){} // RVA: 0x7ffaaf4f0fe0
        public void get_vertexTexturingIsAvailable(){} // RVA: 0x7ffaaf4f1520
        public void get_shaderModelIs35(){} // RVA: 0x7ffaaf4f17f0
        public void InitVertexDeclaration(){} // RVA: 0x7ffaaf4f1ac0
        public void CompleteCreation(){} // RVA: 0x7ffaaf4f1c70
        public void get_fullyCreated(){} // RVA: 0x7ffaaf4f1f00
        public void get_disposed(){} // RVA: 0x7ffaaf4f1f10
        public void set_disposed(){} // RVA: 0x7ffaaf4f1f20
        public void Dispose(){} // RVA: 0x7ffaaf4f1fa0
        public void Dispose(){} // RVA: 0x7ffaaf4f1fa0
        public void Allocate(){} // RVA: 0x7ffaaf4f2d30
        public void Update(){} // RVA: 0x7ffaaf4f2500
        public void Update(){} // RVA: 0x7ffaaf4f2500
        public void UpdateCopyBackIndices(){} // RVA: 0x7ffaaf4f28b0
        public void ActiveUpdatesForMeshHandle(){} // RVA: 0x7ffaaf4f2a60
        public void TryAllocFromPage(){} // RVA: 0x7ffaaf4f2b00
        public void Allocate(){} // RVA: 0x7ffaaf4f2d30
        public void UpdateAfterGPUUsedData(){} // RVA: 0x7ffaaf4f3770
        public void Free(){} // RVA: 0x7ffaaf4f4270
        public void OnFrameRenderingBegin(){} // RVA: 0x7ffaaf4f4e40
        public void PtrToSlice(){} // RVA: 0x7ffaa887e5c0
        public void ApplyDrawCommandState(){} // RVA: 0x7ffaaf4f4ef0
        public void ApplyBatchState(){} // RVA: 0x7ffaaf4f5100
        public void EvaluateChain(){} // RVA: 0x7ffaaf4f5320
        public void UpdateFenceValue(){} // RVA: 0x7ffaaf4f6440
        public void KickRanges(){} // RVA: 0x7ffaaf4f6530
        public void DrawRanges(){} // RVA: 0x7ffaa887e5c0
        public void WaitOnCpuFence(){} // RVA: 0x7ffaaf4f6800
        public void AdvanceFrame(){} // RVA: 0x7ffaaf4f68f0
        public void PruneUnusedPages(){} // RVA: 0x7ffaaf4f7810
        public void PrepareForGfxDeviceRecreate(){} // RVA: 0x7ffaaf4f7a90
        public void WrapUpGfxDeviceRecreate(){} // RVA: 0x7ffaaf4f7df0
        public void FlushAllPendingDeviceDisposes(){} // RVA: 0x7ffaaf4f7e50
        public void GatherDrawStatistics(){} // RVA: 0x7ffaaf4f7f00
        public void ProcessDeviceFreeQueue(){} // RVA: 0x7ffaaf4f7f20
        public void OnEngineUpdateGlobal(){} // RVA: 0x7ffaaf4f8530
        public void OnFlushPendingResources(){} // RVA: 0x7ffaaf4f8580
    }

    public class Utility : Object
    {
        public object FlushPendingResources; // 0x30E667F0
        public object RenderNodeExecute; // 0x30E667F0
        public object m_Ptr; // 0x31739E70

        // ── Original Methods ──
        public void add_GraphicsResourcesRecreate(){} // RVA: 0x7ffaaf4ebdd0
        public void remove_GraphicsResourcesRecreate(){} // RVA: 0x7ffaaf4ebf30
        public void add_EngineUpdate(){} // RVA: 0x7ffaaf4ec090
        public void remove_EngineUpdate(){} // RVA: 0x7ffaaf4ec1e0
        public void add_FlushPendingResources(){} // RVA: 0x7ffaaf4ec330
        public void remove_FlushPendingResources(){} // RVA: 0x7ffaaf4ec480
        public void add_RegisterIntermediateRenderers(){} // RVA: 0x7ffaaf4ec5d0
        public void remove_RegisterIntermediateRenderers(){} // RVA: 0x7ffaaf4ec730
        public void add_RenderNodeExecute(){} // RVA: 0x7ffaaf4ec890
        public void remove_RenderNodeExecute(){} // RVA: 0x7ffaaf4ec9f0
        public void RaiseGraphicsResourcesRecreate(){} // RVA: 0x7ffaaf4ecb50
        public void RaiseEngineUpdate(){} // RVA: 0x7ffaaf4ecbd0
        public void RaiseFlushPendingResources(){} // RVA: 0x7ffaaf4ecc70
        public void RaiseRegisterIntermediateRenderers(){} // RVA: 0x7ffaaf4ecce0
        public void RaiseRenderNodeAdd(){} // RVA: 0x7ffaaf4ecd60
        public void RaiseRenderNodeExecute(){} // RVA: 0x7ffaaf4ecde0
        public void RaiseRenderNodeCleanup(){} // RVA: 0x7ffaaf4ece60
        public void AllocateBuffer(){} // RVA: 0x7ffaaf4ecee0
        public void FreeBuffer(){} // RVA: 0x7ffaaf4ecf50
        public void UpdateBufferRanges(){} // RVA: 0x7ffaaf4ecfa0
        public void RegisterIntermediateRenderer(){} // RVA: 0x7ffaaf4ed100
        public void DrawRanges(){} // RVA: 0x7ffaaf4ed220
        public void DisableScissor(){} // RVA: 0x7ffaaf4ed390
        public void CreateStencilState(){} // RVA: 0x7ffaaf4ed3e0
        public void HasMappedBufferRange(){} // RVA: 0x7ffaaf4ed4d0
        public void InsertCPUFence(){} // RVA: 0x7ffaaf4ed520
        public void CPUFencePassed(){} // RVA: 0x7ffaaf4ed570
        public void WaitForCPUFencePassed(){} // RVA: 0x7ffaaf4ed5c0
        public void SyncRenderThread(){} // RVA: 0x7ffaaf4ed610
        public void ProfileDrawChainBegin(){} // RVA: 0x7ffaaf4ed6f0
        public void ProfileDrawChainEnd(){} // RVA: 0x7ffaaf4ed740
        public void NotifyOfUIREvents(){} // RVA: 0x7ffaaf4ed790
        public void .cctor(){} // RVA: 0x7ffaaf4ed880
        public void RegisterIntermediateRenderer_Injected(){} // RVA: 0x7ffaaf4ed930
        public void CreateStencilState_Injected(){} // RVA: 0x7ffaaf4eda20
        // ── Binary Analysis Named ──
        public void SetVectorArray(){} // RVA: 0x7ffaaf4ed030
        public void SetVectorArray(){} // RVA: 0x7ffaaf4ed030
        public void GetVertexDeclaration(){} // RVA: 0x7ffaaf4ed0b0
        public void SetPropertyBlock(){} // RVA: 0x7ffaaf4ed2b0
        public void SetScissorRect(){} // RVA: 0x7ffaaf4ed300
        public void SetStencilState(){} // RVA: 0x7ffaaf4ed470
        public void GetActiveViewport(){} // RVA: 0x7ffaaf4ed660
        public void GetUnityProjectionMatrix(){} // RVA: 0x7ffaaf4ed7e0
        public void SetScissorRect_Injected(){} // RVA: 0x7ffaaf4ed9d0
        public void GetActiveViewport_Injected(){} // RVA: 0x7ffaaf4eda70
        public void GetUnityProjectionMatrix_Injected(){} // RVA: 0x7ffaaf4edac0
    }

}