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
        public int texture;
        public object disposed; // 0x8
        public object s_MarkerGetTextureData; // 0x10
        public object s_MarkerUpdateTexture; // 0x18
        public bool <disposed>k__BackingField; // 0x10

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
        public rsor.pdateScrollOffset<T1717597232> next;
        public T1717597232 data;

        // ── Methods ──
        public void AppendTo(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class DrawBufferRange : ValueType
    {
        public int firstIndex; // 0x10
        public int indexCount; // 0x14
        public int minIndexVal; // 0x18
        public int vertsReferenced; // 0x1C
    }

    public class GfxUpdateBufferRange : ValueType
    {
        public uint offsetFromWriteStart; // 0x10
        public uint size; // 0x14
        public object source; // 0x18
    }

    public class LinkedPoolItem`1 : Object
    {
        public T1717597200 poolNext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class LinkedPool`1 : Object
    {
        public ormation<T1717597216> Count;
        public ileFullDirectoryInformation<T1717597216> m_ResetAction;
        public int m_Limit;
        public T1717597216 m_PoolFirst;
        public int <Count>k__BackingField;

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
        public int disposed;
        public URA.woDigitYearMax<ÍÎÏÎÎ.ÌÌ<T1717597264>> m_Pages;
        public ÍÎÏÎÎ.ÌÌ<T1717597264> m_CurrentPage;
        public int m_CurrentPageCount;
        public URA.woDigitYearMax<ÍÎÏÎÎ.ÎÎÌ<T1717597264>> m_Enumerator;
        public bool <disposed>k__BackingField;

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
        public bool disposed; // 0x10
        public xt<ÎÏÌÎÎÎÌÌÌ..UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse> isEmpty; // 0x18
        public xt<ushort> indices; // 0x20
        public rsor.lineIndex next; // 0x28
        public int framesEmpty; // 0x30

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
        public int texture;
        public int m_MaxSize;
        public x m_Format;
        public n<?,T1717597280> m_Convert;
        public ÎÏÌÎÎÎÌÌÌ._altKey m_Allocator;
        public ector m_Texture;
        public ÍÎÏÎÎ.ÌÌ<T1717597280> m_Texels;

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
        public int disposed;
        public int m_ExcessMaxCapacity;
        public lineIndex<T1717597312> m_Pool;
        public URA.woDigitYearMax<lineIndex<T1717597312>> m_Excess;
        public int m_NextExcessSize;
        public bool <disposed>k__BackingField;

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
        public bool maxVerticesPerPage; // 0x10
        public UIntPtr breakBatches; // 0x18
        public UIntPtr defaultShaderInfoTexFloat; // 0x20
        public rsor.lineIndex defaultShaderInfoTexARGB8; // 0x28
        public uint vertexTexturingIsAvailable; // 0x30
        public uint shaderModelIs35; // 0x34
        public float fullyCreated; // 0x38
        public URA.woDigitYearMax<URA.woDigitYearMax<.ITextSelection.get_selectAllOnFocus>> disposed; // 0x40
        public URA.woDigitYearMax<URA.woDigitYearMax<ction.get_tripleClickSelectsLine>> m_Updates; // 0x48
        public uint[] m_Fences; // 0x50
        public le m_StandardMatProps; // 0x58
        public uint m_FrameIndex; // 0x60
        public uint m_NextUpdateID; // 0x64
        public lection.get_selectAllOnMouseUp m_DrawStats; // 0x68
        public rsor.ments.ITextEdition.AcceptCharacter<rsor.t_maxLength> m_MeshHandles; // 0x90
        public rsor.veFocusToCompositeRoot>k__BackingField m_DrawParams; // 0x98
        public rsor.gleElementNameAndClassQuery m_TextureSlotManager; // 0xA0
        public URA.antCultureString<ion.get_selectAllOnFocus> m_DeviceFreeQueue;
        public int m_ActiveDeviceCount; // 0x8
        public bool m_SubscribedToNotifications; // 0xC
        public bool m_SynchronousFree; // 0xD
        public int s_GradientSettingsTexID; // 0x10
        public int s_ShaderInfoTexID; // 0x14
        public int s_TransformsPropID; // 0x18
        public int s_ClipRectsPropID; // 0x1C
        public object s_MarkerAllocate; // 0x20
        public object s_MarkerFree; // 0x28
        public object s_MarkerAdvanceFrame; // 0x30
        public object s_MarkerFence; // 0x38
        public object s_MarkerBeforeDraw; // 0x40
        public aphy<bool> s_VertexTexturingIsAvailable; // 0x48
        public aphy<bool> s_ShaderModelIs35; // 0x4A
        public uint <maxVerticesPerPage>k__BackingField; // 0xA8
        public bool <breakBatches>k__BackingField; // 0xAC
        public ector s_DefaultShaderInfoTexFloat; // 0x50
        public ector s_DefaultShaderInfoTexARGB8; // 0x58
        public bool <disposed>k__BackingField; // 0xAD

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
        public ileFullDirectoryInformation<bool> GraphicsResourcesRecreate;
        public ÎÌÍÏÏÌÍÏ EngineUpdate; // 0x8
        public ÎÌÍÏÏÌÍÏ FlushPendingResources; // 0x10
        public ileFullDirectoryInformation<ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ> RegisterIntermediateRenderers; // 0x18
        public ileFullDirectoryInformation<UIntPtr> RenderNodeAdd; // 0x20
        public ileFullDirectoryInformation<UIntPtr> RenderNodeExecute; // 0x28
        public ileFullDirectoryInformation<UIntPtr> RenderNodeCleanup; // 0x30
        public object s_MarkerRaiseEngineUpdate; // 0x38

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