// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.UIR
// Classes: 15
// Methods: 150

namespace ThirdParty.Unity.UnityEngine.UIElements.UIR
{
    public class BMPAlloc : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD54F0BB00
        public void IsValid(){} // RVA: 0x7FFD54F0BB20
        public void ToString(){} // RVA: 0x7FFD54F0BB30
        public void .cctor(){} // RVA: 0x7FFD54F0BC60
    }

    public class BaseShaderInfoStorage : Object
    {
        public object texture;
        public object disposed;

        // ── Methods ──
        public void get_texture(){} // RVA: 0x7FFD4E078E90
        public void AllocateRect(){}
        public void SetTexel(){}
        public void UpdateTexture(){} // RVA: 0x7FFD4E090980
        public void get_disposed(){} // RVA: 0x7FFD4E40B5E0
        public void set_disposed(){} // RVA: 0x7FFD4E40B5F0
        public void Dispose(){} // RVA: 0x7FFD53858240 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54F068A0
    }

    public class BasicNodePool`1 : LinkedPool`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4E090A10
        public void Create(){} // RVA: 0x7FFD4E078A90
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class BasicNode`1 : LinkedPoolItem`1
    {
        // ── Methods ──
        public void AppendTo(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class DrawBufferRange : ValueType
    {
    }

    public class GfxUpdateBufferRange : ValueType
    {
    }

    public class LinkedPoolItem`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class LinkedPool`1 : Object
    {
        public object Count;

        // ── Methods ──
        public void .ctor(){}
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void set_Count(){} // RVA: 0x7FFD4E090ED0
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Get(){} // RVA: 0x7FFD4E2ADC40
        public void Return(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NativePagedList`1 : Object
    {
        public object disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090ED0
        public void Add(){} // RVA: 0x7FFD4E090A40
        public void GetPages(){} // RVA: 0x7FFD4E078E90
        public void Reset(){} // RVA: 0x7FFD4E090980
        public void get_disposed(){} // RVA: 0x7FFD4E079D00
        public void set_disposed(){} // RVA: 0x7FFD4E091060
        public void Dispose(){} // RVA: 0x7FFD4E091060 | overloaded x2
    }

    public class Page : Object
    {
        public object disposed;
        public object isEmpty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54EF8300
        public void get_disposed(){} // RVA: 0x7FFD4E40B5E0
        public void set_disposed(){} // RVA: 0x7FFD4E40B5F0
        public void Dispose(){} // RVA: 0x7FFD54EF8560 | overloaded x2
        public void get_isEmpty(){} // RVA: 0x7FFD54EF8860
    }

    public class RenderChainVEData : ValueType
    {
        public object lastClosingOrLastCommand;
        public object isIgnoringDynamicColorHint;

        // ── Methods ──
        public void get_lastClosingOrLastCommand(){} // RVA: 0x7FFD54F06750
        public void AllocatesID(){} // RVA: 0x7FFD54F06760
        public void InheritsID(){} // RVA: 0x7FFD54F067C0
        public void get_isIgnoringDynamicColorHint(){} // RVA: 0x7FFD54F06820
    }

    public class ShaderInfoStorage`1 : BaseShaderInfoStorage
    {
        public object texture;

        // ── Methods ──
        public void .ctor(){}
        public void Dispose(){} // RVA: 0x7FFD4E091060
        public void get_texture(){} // RVA: 0x7FFD4E078E90
        public void AllocateRect(){}
        public void SetTexel(){}
        public void UpdateTexture(){} // RVA: 0x7FFD4E090980
        public void CreateOrExpandTexture(){} // RVA: 0x7FFD4E090980
        public void CpuBlit(){} // RVA: 0x7FFD4E2ADC40
    }

    public class TempAllocator`1 : Object
    {
        public object disposed;

        // ── Methods ──
        public void .ctor(){}
        public void get_disposed(){} // RVA: 0x7FFD4E079D00
        public void set_disposed(){} // RVA: 0x7FFD4E091060
        public void Dispose(){} // RVA: 0x7FFD4E091060 | overloaded x2
        public void Alloc(){} // RVA: 0x7FFD4E2ADC40
        public void Reset(){} // RVA: 0x7FFD4E090980
        public void ReleaseExcess(){} // RVA: 0x7FFD4E090980
    }

    public class UIRenderDevice : Object
    {
        public object maxVerticesPerPage;
        public object breakBatches;
        public object defaultShaderInfoTexFloat;
        public object defaultShaderInfoTexARGB8;
        public object vertexTexturingIsAvailable;
        public object shaderModelIs35;
        public object fullyCreated;
        public object disposed;

        // ── Methods ──
        public void get_maxVerticesPerPage(){} // RVA: 0x7FFD4ED255C0
        public void get_breakBatches(){} // RVA: 0x7FFD54EED620
        public void set_breakBatches(){} // RVA: 0x7FFD54EED630
        public void .cctor(){} // RVA: 0x7FFD54EED640
        public void .ctor(){} // RVA: 0x7FFD54EEDE50 | overloaded x2
        public void get_defaultShaderInfoTexFloat(){} // RVA: 0x7FFD54EEE940
        public void get_defaultShaderInfoTexARGB8(){} // RVA: 0x7FFD54EEF080
        public void get_vertexTexturingIsAvailable(){} // RVA: 0x7FFD54EEF5C0
        public void get_shaderModelIs35(){} // RVA: 0x7FFD54EEF890
        public void InitVertexDeclaration(){} // RVA: 0x7FFD54EEFB60
        public void CompleteCreation(){} // RVA: 0x7FFD54EEFD10
        public void get_fullyCreated(){} // RVA: 0x7FFD54EEFFA0
        public void get_disposed(){} // RVA: 0x7FFD54EEFFB0
        public void set_disposed(){} // RVA: 0x7FFD54EEFFC0
        public void Dispose(){} // RVA: 0x7FFD54EF0040 | overloaded x2
        public void Allocate(){} // RVA: 0x7FFD54EF0DD0 | overloaded x2
        public void Update(){} // RVA: 0x7FFD54EF05A0 | overloaded x2
        public void UpdateCopyBackIndices(){} // RVA: 0x7FFD54EF0950
        public void ActiveUpdatesForMeshHandle(){} // RVA: 0x7FFD54EF0B00
        public void TryAllocFromPage(){} // RVA: 0x7FFD54EF0BA0
        public void UpdateAfterGPUUsedData(){} // RVA: 0x7FFD54EF1810
        public void Free(){} // RVA: 0x7FFD54EF2310
        public void OnFrameRenderingBegin(){} // RVA: 0x7FFD54EF2EE0
        public void PtrToSlice(){} // RVA: 0x7FFD4E2ADC40
        public void ApplyDrawCommandState(){} // RVA: 0x7FFD54EF2F90
        public void ApplyBatchState(){} // RVA: 0x7FFD54EF31A0
        public void EvaluateChain(){} // RVA: 0x7FFD54EF33C0
        public void UpdateFenceValue(){} // RVA: 0x7FFD54EF44E0
        public void KickRanges(){} // RVA: 0x7FFD54EF45D0
        public void DrawRanges(){} // RVA: 0x7FFD4E2ADC40
        public void WaitOnCpuFence(){} // RVA: 0x7FFD54EF48A0
        public void AdvanceFrame(){} // RVA: 0x7FFD54EF4990
        public void PruneUnusedPages(){} // RVA: 0x7FFD54EF58B0
        public void PrepareForGfxDeviceRecreate(){} // RVA: 0x7FFD54EF5B30
        public void WrapUpGfxDeviceRecreate(){} // RVA: 0x7FFD54EF5E90
        public void FlushAllPendingDeviceDisposes(){} // RVA: 0x7FFD54EF5EF0
        public void GatherDrawStatistics(){} // RVA: 0x7FFD54EF5FA0
        public void ProcessDeviceFreeQueue(){} // RVA: 0x7FFD54EF5FC0
        public void OnEngineUpdateGlobal(){} // RVA: 0x7FFD54EF65D0
        public void OnFlushPendingResources(){} // RVA: 0x7FFD54EF6620
    }

    public class Utility : Object
    {
        // ── Methods ──
        public void SetVectorArray(){} // RVA: 0x7FFD54EEB0D0 | overloaded x2
        public void add_GraphicsResourcesRecreate(){} // RVA: 0x7FFD54EE9E70
        public void remove_GraphicsResourcesRecreate(){} // RVA: 0x7FFD54EE9FD0
        public void add_EngineUpdate(){} // RVA: 0x7FFD54EEA130
        public void remove_EngineUpdate(){} // RVA: 0x7FFD54EEA280
        public void add_FlushPendingResources(){} // RVA: 0x7FFD54EEA3D0
        public void remove_FlushPendingResources(){} // RVA: 0x7FFD54EEA520
        public void add_RegisterIntermediateRenderers(){} // RVA: 0x7FFD54EEA670
        public void remove_RegisterIntermediateRenderers(){} // RVA: 0x7FFD54EEA7D0
        public void add_RenderNodeExecute(){} // RVA: 0x7FFD54EEA930
        public void remove_RenderNodeExecute(){} // RVA: 0x7FFD54EEAA90
        public void RaiseGraphicsResourcesRecreate(){} // RVA: 0x7FFD54EEABF0
        public void RaiseEngineUpdate(){} // RVA: 0x7FFD54EEAC70
        public void RaiseFlushPendingResources(){} // RVA: 0x7FFD54EEAD10
        public void RaiseRegisterIntermediateRenderers(){} // RVA: 0x7FFD54EEAD80
        public void RaiseRenderNodeAdd(){} // RVA: 0x7FFD54EEAE00
        public void RaiseRenderNodeExecute(){} // RVA: 0x7FFD54EEAE80
        public void RaiseRenderNodeCleanup(){} // RVA: 0x7FFD54EEAF00
        public void AllocateBuffer(){} // RVA: 0x7FFD54EEAF80
        public void FreeBuffer(){} // RVA: 0x7FFD54EEAFF0
        public void UpdateBufferRanges(){} // RVA: 0x7FFD54EEB040
        public void GetVertexDeclaration(){} // RVA: 0x7FFD54EEB150
        public void RegisterIntermediateRenderer(){} // RVA: 0x7FFD54EEB1A0
        public void DrawRanges(){} // RVA: 0x7FFD54EEB2C0
        public void SetPropertyBlock(){} // RVA: 0x7FFD54EEB350
        public void SetScissorRect(){} // RVA: 0x7FFD54EEB3A0
        public void DisableScissor(){} // RVA: 0x7FFD54EEB430
        public void CreateStencilState(){} // RVA: 0x7FFD54EEB480
        public void SetStencilState(){} // RVA: 0x7FFD54EEB510
        public void HasMappedBufferRange(){} // RVA: 0x7FFD54EEB570
        public void InsertCPUFence(){} // RVA: 0x7FFD54EEB5C0
        public void CPUFencePassed(){} // RVA: 0x7FFD54EEB610
        public void WaitForCPUFencePassed(){} // RVA: 0x7FFD54EEB660
        public void SyncRenderThread(){} // RVA: 0x7FFD54EEB6B0
        public void GetActiveViewport(){} // RVA: 0x7FFD54EEB700
        public void ProfileDrawChainBegin(){} // RVA: 0x7FFD54EEB790
        public void ProfileDrawChainEnd(){} // RVA: 0x7FFD54EEB7E0
        public void NotifyOfUIREvents(){} // RVA: 0x7FFD54EEB830
        public void GetUnityProjectionMatrix(){} // RVA: 0x7FFD54EEB880
        public void .cctor(){} // RVA: 0x7FFD54EEB920
        public void RegisterIntermediateRenderer_Injected(){} // RVA: 0x7FFD54EEB9D0
        public void SetScissorRect_Injected(){} // RVA: 0x7FFD54EEBA70
        public void CreateStencilState_Injected(){} // RVA: 0x7FFD54EEBAC0
        public void GetActiveViewport_Injected(){} // RVA: 0x7FFD54EEBB10
        public void GetUnityProjectionMatrix_Injected(){} // RVA: 0x7FFD54EEBB60
    }

}