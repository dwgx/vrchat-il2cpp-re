// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.UIR
// Classes: 50
// Methods: 381

namespace ThirdParty.Unity.UnityEngine.UIElements.UIR
{
    public class Alloc : ValueType
    {
    }

    public class Allocator2D : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E74720
        public void TryAllocate(){} // RVA: 0x7FFE87E74C80
        public void Free(){} // RVA: 0x7FFE87E75200
        public void BuildAreas(){} // RVA: 0x7FFE87E754C0
        public void ComputeMaxAllocSize(){} // RVA: 0x7FFE87E75660
        public void BuildRowArray(){} // RVA: 0x7FFE87E75790
    }

    public class BMPAlloc : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE87E943A0
        public void IsValid(){} // RVA: 0x7FFE87E943C0
        public void ToString(){} // RVA: 0x7FFE87E943D0
        public void .cctor(){} // RVA: 0x7FFE87E94500
    }

    public class BaseShaderInfoStorage : Object
    {
        public int s_TextureCounter;
        public Unity.Profiling.ProfilerMarker s_MarkerCopyTexture; // 0x8

        // ── Methods ──
        public void get_texture(){} // RVA: 0x7FFE80E2E2E0
        public void AllocateRect(){}
        public void SetTexel(){}
        public void UpdateTexture(){} // RVA: 0x7FFE80E45FE0
        public void get_disposed(){} // RVA: 0x7FFE811C55E0
        public void set_disposed(){} // RVA: 0x7FFE811C55F0
        public void Dispose(){} // RVA: 0x7FFE867E1B50 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87E8F140
    }

    public class BasicNodePool`1 : LinkedPool`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE80E46070
        public void Create(){} // RVA: 0x7FFE80E2DEE0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class BasicNode`1 : LinkedPoolItem`1
    {
        // ── Methods ──
        public void AppendTo(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class BestFitAllocator : Object
    {
        public uint _totalSize; // 0x10
        public Block m_FirstBlock; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E7F120
        public void get_totalSize(){} // RVA: 0x7FFE811485C0
        public void get_highWatermark(){} // RVA: 0x7FFE87E7F380
        public void Allocate(){} // RVA: 0x7FFE87E7F390
        public void Free(){} // RVA: 0x7FFE87E7F730
        public void CoalesceBlockWithPrevious(){} // RVA: 0x7FFE87E7FBB0
        public void BestFitFindAvailableBlock(){} // RVA: 0x7FFE87E7FE10
        public void SplitBlock(){} // RVA: 0x7FFE87E7FE50
    }

    public class BitmapAllocator32 : ValueType
    {
        public int m_PageHeight; // 0x10
        public System.Collections.Generic.List`1<Page> m_Pages; // 0x18

        // ── Methods ──
        public void Construct(){} // RVA: 0x7FFE87E94560
        public void ForceFirstAlloc(){} // RVA: 0x7FFE87E94780
        public void Allocate(){} // RVA: 0x7FFE87E94940
        public void Free(){} // RVA: 0x7FFE87E94DF0
        public void get_entryWidth(){} // RVA: 0x7FFE84A02990
        public void get_entryHeight(){} // RVA: 0x7FFE84022BD0
        public void GetAllocPageAtlasLocation(){} // RVA: 0x7FFE87E94F70
        public void CountTrailingZeroes(){} // RVA: 0x7FFE87E95010
    }

    public class ChainBuilderStats : ValueType
    {
    }

    public class ConvertMeshJobData : ValueType
    {
    }

    public class CopyClosingMeshJobData : ValueType
    {
    }

    public class DetachedAllocator : Object
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE87E75E10 | overloaded x2
    }

    public class DrawBufferRange : ValueType
    {
    }

    public class DrawParams : Object
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE87E81180
        public void .ctor(){} // RVA: 0x7FFE87E813B0
        public void .cctor(){} // RVA: 0x7FFE87E81800
    }

    public class GPUBufferAllocator : Object
    {
        public UnityEngine.UIElements.UIR.BestFitAllocator m_Low; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E80370
        public void Allocate(){} // RVA: 0x7FFE87E804B0
        public void Free(){} // RVA: 0x7FFE87E806C0
        public void get_isEmpty(){} // RVA: 0x7FFE87E80740
        public void HighLowCollide(){} // RVA: 0x7FFE87E80780
    }

    public class GfxUpdateBufferRange : ValueType
    {
    }

    public class GradientRemap : LinkedPoolItem`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE87E932F0
        public void .ctor(){} // RVA: 0x7FFE87E93360
    }

    public class GradientRemapPool : LinkedPool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E92EF0
    }

    public class GradientSettingsAtlas : Object
    {
        public Unity.Profiling.ProfilerMarker s_MarkerWrite;
        public Unity.Profiling.ProfilerMarker s_MarkerCommit; // 0x8
        public int m_Length; // 0x10
        public int m_ElemWidth; // 0x14

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFE87BFA280
        public void get_disposed(){} // RVA: 0x7FFE812CF770
        public void set_disposed(){} // RVA: 0x7FFE812D0010
        public void Dispose(){} // RVA: 0x7FFE87E83600 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE87E83670
        public void Reset(){} // RVA: 0x7FFE87E83790
        public void get_atlas(){} // RVA: 0x7FFE87563690
        public void Add(){} // RVA: 0x7FFE87E838A0
        public void Write(){} // RVA: 0x7FFE87E83990
        public void get_MustCommit(){} // RVA: 0x7FFE812CF7D0
        public void set_MustCommit(){} // RVA: 0x7FFE812D0020
        public void Commit(){} // RVA: 0x7FFE87E83ED0
        public void PrepareAtlas(){} // RVA: 0x7FFE87E83F40
        public void .cctor(){} // RVA: 0x7FFE87E84270
    }

    public class JobManager : Object
    {
        public UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.NudgeJobData> m_NudgeJobs; // 0x10

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE87E847D0 | overloaded x3
        public void CompleteNudgeJobs(){} // RVA: 0x7FFE87E84990
        public void CompleteConvertMeshJobs(){} // RVA: 0x7FFE87E84D20
        public void CompleteClosingMeshJobs(){} // RVA: 0x7FFE87E850B0
        public void get_disposed(){} // RVA: 0x7FFE81121450
        public void set_disposed(){} // RVA: 0x7FFE81121460
        public void Dispose(){} // RVA: 0x7FFE87E855D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE87E85720
    }

    public class JobMerger : Object
    {
        public Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle> m_Jobs; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E85AB0
        public void Add(){} // RVA: 0x7FFE87E85B70
        public void MergeAndReset(){} // RVA: 0x7FFE87E85C70
        public void get_disposed(){} // RVA: 0x7FFE811167C0
        public void set_disposed(){} // RVA: 0x7FFE812EB1B0
        public void Dispose(){} // RVA: 0x7FFE87E85E50 | overloaded x2
    }

    public class JobProcessor : Object
    {
        // ── Methods ──
        public void ScheduleNudgeJobs(){} // RVA: 0x7FFE87E74450
        public void ScheduleConvertMeshJobs(){} // RVA: 0x7FFE87E744D0
        public void ScheduleCopyClosingMeshJobs(){} // RVA: 0x7FFE87E74550
        public void ScheduleNudgeJobs_Injected(){} // RVA: 0x7FFE87E745D0
        public void ScheduleConvertMeshJobs_Injected(){} // RVA: 0x7FFE87E74640
        public void ScheduleCopyClosingMeshJobs_Injected(){} // RVA: 0x7FFE87E746B0
    }

    public class LinkedPoolItem`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class LinkedPool`1 : Object
    {
        public System.Func`1<T> m_CreateFunc;

        // ── Methods ──
        public void .ctor(){}
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void set_Count(){} // RVA: 0x7FFE80E46530
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Get(){} // RVA: 0x7FFE810A1420
        public void Return(){} // RVA: 0x7FFE810A1420
    }

    public class MeshBuilder : Object
    {
        // ── Methods ──
        public void ConvertTextVertexToUIRVertex(){} // RVA: 0x7FFE87E85EB0
        public void LimitTextVertices(){} // RVA: 0x7FFE87E86080
        public void MakeText(){} // RVA: 0x7FFE87E86200
        public void .cctor(){} // RVA: 0x7FFE87E86AC0
    }

    public class MeshHandle : LinkedPoolItem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E75E90
    }

    public class NativePagedList`1 : Object
    {
        public int k_PoolCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void Add(){} // RVA: 0x7FFE80E460A0
        public void GetPages(){} // RVA: 0x7FFE80E2E2E0
        public void Reset(){} // RVA: 0x7FFE80E45FE0
        public void get_disposed(){} // RVA: 0x7FFE80E2F150
        public void set_disposed(){} // RVA: 0x7FFE80E466C0
        public void Dispose(){} // RVA: 0x7FFE80E466C0 | overloaded x2
    }

    public class NudgeJobData : ValueType
    {
    }

    public class OpacityIdAccelerator : Object
    {
        public Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle> m_Jobs; // 0x10

        // ── Methods ──
        public void CreateJob(){} // RVA: 0x7FFE87E86D20
        public void CompleteJobs(){} // RVA: 0x7FFE87E87010
        public void get_disposed(){} // RVA: 0x7FFE811167C0
        public void set_disposed(){} // RVA: 0x7FFE812EB1B0
        public void Dispose(){} // RVA: 0x7FFE87E87260 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE87E872C0
    }

    public class Page : Object
    {
        public bool _disposed; // 0x10
        public DataSet`1<UnityEngine.UIElements.Vertex> vertices; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E80BA0
        public void get_disposed(){} // RVA: 0x7FFE811C55E0
        public void set_disposed(){} // RVA: 0x7FFE811C55F0
        public void Dispose(){} // RVA: 0x7FFE87E80E00 | overloaded x2
        public void get_isEmpty(){} // RVA: 0x7FFE87E81100
    }

    public class RenderChain : Object
    {
        public UnityEngine.UIElements.UIR.RenderChainCommand m_FirstCommand; // 0x10
        public DepthOrderedDirtyTracking m_DirtyTracker; // 0x18
        public UnityEngine.UIElements.UIR.LinkedPool`1<UnityEngine.UIElements.UIR.RenderChainCommand> m_CommandPool; // 0x40
        public UnityEngine.UIElements.UIR.BasicNodePool`1<UnityEngine.UIElements.UIR.TextureEntry> m_TexturePool; // 0x48
        public System.Collections.Generic.List`1<RenderNodeData> m_RenderNodesData; // 0x50
        public UnityEngine.Shader m_DefaultShader; // 0x58
        public UnityEngine.Shader m_DefaultWorldSpaceShader; // 0x60
        public UnityEngine.Material m_DefaultMat; // 0x68
        public UnityEngine.Material m_DefaultWorldSpaceMat; // 0x70
        public bool m_BlockDirtyRegistration; // 0x78
        public int m_StaticIndex; // 0x7C
        public int m_ActiveRenderNodes; // 0x80
        public int m_CustomMaterialCommands; // 0x84
        public UnityEngine.UIElements.UIR.ChainBuilderStats m_Stats; // 0x88

        // ── Methods ──
        public void get_opacityIdAccelerator(){} // RVA: 0x7FFE8158D5D0
        public void set_opacityIdAccelerator(){} // RVA: 0x7FFE81B0E4B0
        public void .cctor(){} // RVA: 0x7FFE87E874C0
        public void .ctor(){} // RVA: 0x7FFE87E87BF0
        public void Constructor(){} // RVA: 0x7FFE87E882A0
        public void Destructor(){} // RVA: 0x7FFE87E88DB0
        public void get_disposed(){} // RVA: 0x7FFE81F84400
        public void set_disposed(){} // RVA: 0x7FFE81F84A40
        public void Dispose(){} // RVA: 0x7FFE87E89690 | overloaded x2
        public void ProcessChanges(){} // RVA: 0x7FFE87E896C0
        public void Render(){} // RVA: 0x7FFE87E89F80
        public void UIEOnChildAdded(){} // RVA: 0x7FFE87E8A550
        public void UIEOnChildrenReordered(){} // RVA: 0x7FFE87E8A8B0
        public void UIEOnChildRemoving(){} // RVA: 0x7FFE87E8AC90
        public void UIEOnRenderHintsChanged(){} // RVA: 0x7FFE87E8ADA0
        public void UIEOnClippingChanged(){} // RVA: 0x7FFE87E8AE70
        public void UIEOnOpacityChanged(){} // RVA: 0x7FFE87E8AF10
        public void UIEOnColorChanged(){} // RVA: 0x7FFE87E8AFB0
        public void UIEOnTransformOrSizeChanged(){} // RVA: 0x7FFE87E8B050
        public void UIEOnVisualsChanged(){} // RVA: 0x7FFE87E8B0F0
        public void UIEOnOpacityIdChanged(){} // RVA: 0x7FFE87E8B190
        public void get_panel(){} // RVA: 0x7FFE8181E3D0
        public void set_panel(){} // RVA: 0x7FFE81A60200
        public void get_device(){} // RVA: 0x7FFE81317980
        public void set_device(){} // RVA: 0x7FFE813159A0
        public void get_atlas(){} // RVA: 0x7FFE81318010
        public void set_atlas(){} // RVA: 0x7FFE81317920
        public void get_vectorImageManager(){} // RVA: 0x7FFE813A1DA0
        public void set_vectorImageManager(){} // RVA: 0x7FFE813A0830
        public void get_vertsPool(){} // RVA: 0x7FFE8182B890
        public void set_vertsPool(){} // RVA: 0x7FFE81B31E10
        public void get_indicesPool(){} // RVA: 0x7FFE81823850
        public void set_indicesPool(){} // RVA: 0x7FFE81B31120
        public void get_jobManager(){} // RVA: 0x7FFE8181EA70
        public void set_jobManager(){} // RVA: 0x7FFE818254E0
        public void get_painter(){} // RVA: 0x7FFE81B0A180
        public void set_painter(){} // RVA: 0x7FFE81B13850
        public void get_drawStats(){} // RVA: 0x7FFE87E8B230
        public void set_drawStats(){} // RVA: 0x7FFE8746CD70
        public void get_drawInCameras(){} // RVA: 0x7FFE87E8B240
        public void set_drawInCameras(){} // RVA: 0x7FFE87E8B250
        public void set_defaultShader(){} // RVA: 0x7FFE87E8B260
        public void set_defaultWorldSpaceShader(){} // RVA: 0x7FFE87E8B470
        public void GetStandardMaterial(){} // RVA: 0x7FFE87E8B680
        public void GetStandardWorldSpaceMaterial(){} // RVA: 0x7FFE87E8B910
        public void EnsureFitsDepth(){} // RVA: 0x7FFE87E8BBA0
        public void ChildWillBeRemoved(){} // RVA: 0x7FFE87E8BBB0
        public void AllocCommand(){} // RVA: 0x7FFE87E8BC70
        public void FreeCommand(){} // RVA: 0x7FFE87E8BCD0
        public void OnRenderCommandAdded(){} // RVA: 0x7FFE87E8BDF0
        public void OnRenderCommandsRemoved(){} // RVA: 0x7FFE87E8BF30
        public void AccessRenderNodeData(){} // RVA: 0x7FFE87E8BFA0
        public void OnRenderNodeExecute(){} // RVA: 0x7FFE87E8C130
        public void OnRegisterIntermediateRenderers(){} // RVA: 0x7FFE87E8C370
        public void OnRegisterIntermediateRendererMat(){} // RVA: 0x7FFE87E8CD10
        public void RepaintTexturedElements(){} // RVA: 0x7FFE87E8D270
        public void AppendTexture(){} // RVA: 0x7FFE87E8D3C0
        public void ResetTextures(){} // RVA: 0x7FFE87E8D590
        public void DrawStats(){} // RVA: 0x7FFE87E8D710
        public void GetFirstElementInPanel(){} // RVA: 0x7FFE87E8E1E0
    }

    public class RenderChainCommand : LinkedPoolItem`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE87E81860
        public void ExecuteNonDrawMesh(){} // RVA: 0x7FFE87E81A10
        public void Blit(){} // RVA: 0x7FFE87E82D40
        public void CombineScissorRects(){} // RVA: 0x7FFE87E83190
        public void RectPointsToPixelsAndFlipYAxis(){} // RVA: 0x7FFE87E83300
        public void .ctor(){} // RVA: 0x7FFE87E83450
        public void .cctor(){} // RVA: 0x7FFE87E83480
    }

    public class RenderChainVEData : ValueType
    {
        public UnityEngine.UIElements.VisualElement prev; // 0x10
        public UnityEngine.UIElements.VisualElement next; // 0x18

        // ── Methods ──
        public void get_lastClosingOrLastCommand(){} // RVA: 0x7FFE87E8EFF0
        public void AllocatesID(){} // RVA: 0x7FFE87E8F000
        public void InheritsID(){} // RVA: 0x7FFE87E8F060
        public void get_isIgnoringDynamicColorHint(){} // RVA: 0x7FFE87E8F0C0
    }

    public class ShaderInfoStorageRGBA32 : ShaderInfoStorage`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E8F2E0
        public void .cctor(){} // RVA: 0x7FFE87E8F390
    }

    public class ShaderInfoStorageRGBAFloat : ShaderInfoStorage`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E8F620
        public void .cctor(){} // RVA: 0x7FFE87E8F6D0
    }

    public class ShaderInfoStorage`1 : BaseShaderInfoStorage
    {
        public int m_InitialSize;

        // ── Methods ──
        public void .ctor(){}
        public void Dispose(){} // RVA: 0x7FFE80E466C0
        public void get_texture(){} // RVA: 0x7FFE80E2E2E0
        public void AllocateRect(){}
        public void SetTexel(){}
        public void UpdateTexture(){} // RVA: 0x7FFE80E45FE0
        public void CreateOrExpandTexture(){} // RVA: 0x7FFE80E45FE0
        public void CpuBlit(){} // RVA: 0x7FFE810A1420
    }

    public class Shaders : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87E8F940
    }

    public class State : ValueType
    {
    }

    public class TempAllocator`1 : Object
    {
        public int m_ExcessMinCapacity;

        // ── Methods ──
        public void .ctor(){}
        public void get_disposed(){} // RVA: 0x7FFE80E2F150
        public void set_disposed(){} // RVA: 0x7FFE80E466C0
        public void Dispose(){} // RVA: 0x7FFE80E466C0 | overloaded x2
        public void Alloc(){} // RVA: 0x7FFE810A1420
        public void Reset(){} // RVA: 0x7FFE80E45FE0
        public void ReleaseExcess(){} // RVA: 0x7FFE80E45FE0
    }

    public class TextCoreSettings : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE87E90090 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87E90230
    }

    public class TextureBlitter : Object
    {
        public int[] k_TextureIds;

        // ── Methods ──
        public void get_disposed(){} // RVA: 0x7FFE811B2D30
        public void set_disposed(){} // RVA: 0x7FFE811B2D40
        public void Dispose(){} // RVA: 0x7FFE87E90370 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87E90430
        public void .ctor(){} // RVA: 0x7FFE87E906B0
        public void QueueBlit(){} // RVA: 0x7FFE87E90800
        public void BlitOneNow(){} // RVA: 0x7FFE87E90960
        public void Commit(){} // RVA: 0x7FFE87E90B10
        public void BeginBlit(){} // RVA: 0x7FFE87E90C10
        public void DoBlit(){} // RVA: 0x7FFE87E91130
        public void EndBlit(){} // RVA: 0x7FFE87E91BE0
    }

    public class TextureEntry : ValueType
    {
    }

    public class TextureSlotManager : Object
    {
        public int k_SlotCount;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87E91CC0
        public void .ctor(){} // RVA: 0x7FFE87E91F90
        public void Reset(){} // RVA: 0x7FFE87E92240
        public void StartNewBatch(){} // RVA: 0x7FFE87E92390
        public void IndexOf(){} // RVA: 0x7FFE87E92400
        public void MarkUsed(){} // RVA: 0x7FFE87E80930
        public void get_FreeSlots(){} // RVA: 0x7FFE81156CD0
        public void set_FreeSlots(){} // RVA: 0x7FFE81156CE0
        public void FindOldestSlot(){} // RVA: 0x7FFE87E924D0
        public void Bind(){} // RVA: 0x7FFE87E925A0
        public void SetGpuData(){} // RVA: 0x7FFE87E92890
    }

    public class Transform3x4 : ValueType
    {
    }

    public class UIRVEShaderInfoAllocator : ValueType
    {
        public UnityEngine.UIElements.UIR.BaseShaderInfoStorage m_Storage; // 0x10
        public UnityEngine.UIElements.UIR.BitmapAllocator32 m_TransformAllocator; // 0x18
        public UnityEngine.UIElements.UIR.BitmapAllocator32 m_ClipRectAllocator; // 0x38
        public UnityEngine.UIElements.UIR.BitmapAllocator32 m_OpacityAllocator; // 0x58
        public UnityEngine.UIElements.UIR.BitmapAllocator32 m_ColorAllocator; // 0x78

        // ── Methods ──
        public void get_pageWidth(){} // RVA: 0x7FFE87E950A0
        public void get_pageHeight(){} // RVA: 0x7FFE87E950B0
        public void AllocToTexelCoord(){} // RVA: 0x7FFE87E950C0
        public void AllocToConstantBufferIndex(){} // RVA: 0x7FFE87E95170
        public void AtlasRectMatchesPage(){} // RVA: 0x7FFE87E951D0
        public void get_transformConstants(){} // RVA: 0x7FFE87E95300
        public void get_clipRectConstants(){} // RVA: 0x7FFE87E953E0
        public void get_atlas(){} // RVA: 0x7FFE87E954C0
        public void Construct(){} // RVA: 0x7FFE87E95560
        public void ReallyCreateStorage(){} // RVA: 0x7FFE87E95A10
        public void Dispose(){} // RVA: 0x7FFE87E96220
        public void IssuePendingStorageChanges(){} // RVA: 0x7FFE87E96380
        public void AllocTransform(){} // RVA: 0x7FFE87E963A0
        public void AllocClipRect(){} // RVA: 0x7FFE87E964F0
        public void AllocOpacity(){} // RVA: 0x7FFE87E96640
        public void AllocColor(){} // RVA: 0x7FFE87E966B0
        public void AllocTextCoreSettings(){} // RVA: 0x7FFE87E96720
        public void SetTransformValue(){} // RVA: 0x7FFE87E96790
        public void SetClipRectValue(){} // RVA: 0x7FFE87E96B60
        public void SetOpacityValue(){} // RVA: 0x7FFE87E96D20
        public void SetColorValue(){} // RVA: 0x7FFE87E96E60
        public void SetTextCoreSettingValue(){} // RVA: 0x7FFE87E96FE0
        public void FreeTransform(){} // RVA: 0x7FFE87E97370
        public void FreeClipRect(){} // RVA: 0x7FFE87E97410
        public void FreeOpacity(){} // RVA: 0x7FFE87E974B0
        public void FreeColor(){} // RVA: 0x7FFE87E97550
        public void FreeTextCoreSettings(){} // RVA: 0x7FFE87E975F0
        public void TransformAllocToVertexData(){} // RVA: 0x7FFE87E976A0
        public void ClipRectAllocToVertexData(){} // RVA: 0x7FFE87E977F0
        public void OpacityAllocToVertexData(){} // RVA: 0x7FFE87E97940
        public void ColorAllocToVertexData(){} // RVA: 0x7FFE87E97A80
        public void TextCoreSettingsToVertexData(){} // RVA: 0x7FFE87E97BC0
        public void .cctor(){} // RVA: 0x7FFE87E97D00
    }

    public class UIRenderDevice : Object
    {
        public bool m_MockDevice; // 0x10
        public UIntPtr m_DefaultStencilState; // 0x18
        public UIntPtr m_VertexDecl; // 0x20
        public UnityEngine.UIElements.UIR.Page m_FirstPage; // 0x28
        public uint m_NextPageVertexCount; // 0x30
        public uint m_LargeMeshVertexCount; // 0x34
        public float m_IndexToVertexCountRatio; // 0x38
        public System.Collections.Generic.List`1<System.Collections.Generic.List`1<AllocToFree>> m_DeferredFrees; // 0x40

        // ── Methods ──
        public void get_maxVerticesPerPage(){} // RVA: 0x7FFE81A338E0
        public void get_breakBatches(){} // RVA: 0x7FFE87E75EC0
        public void set_breakBatches(){} // RVA: 0x7FFE87E75ED0
        public void .cctor(){} // RVA: 0x7FFE87E75EE0
        public void .ctor(){} // RVA: 0x7FFE87E766F0 | overloaded x2
        public void get_defaultShaderInfoTexFloat(){} // RVA: 0x7FFE87E771E0
        public void get_defaultShaderInfoTexARGB8(){} // RVA: 0x7FFE87E77920
        public void get_vertexTexturingIsAvailable(){} // RVA: 0x7FFE87E77E60
        public void get_shaderModelIs35(){} // RVA: 0x7FFE87E78130
        public void InitVertexDeclaration(){} // RVA: 0x7FFE87E78400
        public void CompleteCreation(){} // RVA: 0x7FFE87E785B0
        public void get_fullyCreated(){} // RVA: 0x7FFE87E78840
        public void get_disposed(){} // RVA: 0x7FFE87E78850
        public void set_disposed(){} // RVA: 0x7FFE87E78860
        public void Dispose(){} // RVA: 0x7FFE87E788E0 | overloaded x2
        public void Allocate(){} // RVA: 0x7FFE87E79670 | overloaded x2
        public void Update(){} // RVA: 0x7FFE87E78E40 | overloaded x2
        public void UpdateCopyBackIndices(){} // RVA: 0x7FFE87E791F0
        public void ActiveUpdatesForMeshHandle(){} // RVA: 0x7FFE87E793A0
        public void TryAllocFromPage(){} // RVA: 0x7FFE87E79440
        public void UpdateAfterGPUUsedData(){} // RVA: 0x7FFE87E7A0B0
        public void Free(){} // RVA: 0x7FFE87E7ABB0
        public void OnFrameRenderingBegin(){} // RVA: 0x7FFE87E7B780
        public void PtrToSlice(){} // RVA: 0x7FFE810A1420
        public void ApplyDrawCommandState(){} // RVA: 0x7FFE87E7B830
        public void ApplyBatchState(){} // RVA: 0x7FFE87E7BA40
        public void EvaluateChain(){} // RVA: 0x7FFE87E7BC60
        public void UpdateFenceValue(){} // RVA: 0x7FFE87E7CD80
        public void KickRanges(){} // RVA: 0x7FFE87E7CE70
        public void DrawRanges(){} // RVA: 0x7FFE810A1420
        public void WaitOnCpuFence(){} // RVA: 0x7FFE87E7D140
        public void AdvanceFrame(){} // RVA: 0x7FFE87E7D230
        public void PruneUnusedPages(){} // RVA: 0x7FFE87E7E150
        public void PrepareForGfxDeviceRecreate(){} // RVA: 0x7FFE87E7E3D0
        public void WrapUpGfxDeviceRecreate(){} // RVA: 0x7FFE87E7E730
        public void FlushAllPendingDeviceDisposes(){} // RVA: 0x7FFE87E7E790
        public void GatherDrawStatistics(){} // RVA: 0x7FFE87E7E840
        public void ProcessDeviceFreeQueue(){} // RVA: 0x7FFE87E7E860
        public void OnEngineUpdateGlobal(){} // RVA: 0x7FFE87E7EE70
        public void OnFlushPendingResources(){} // RVA: 0x7FFE87E7EEC0
    }

    public class Utility : Object
    {
        // ── Methods ──
        public void SetVectorArray(){} // RVA: 0x7FFE87E73970 | overloaded x2
        public void add_GraphicsResourcesRecreate(){} // RVA: 0x7FFE87E72710
        public void remove_GraphicsResourcesRecreate(){} // RVA: 0x7FFE87E72870
        public void add_EngineUpdate(){} // RVA: 0x7FFE87E729D0
        public void remove_EngineUpdate(){} // RVA: 0x7FFE87E72B20
        public void add_FlushPendingResources(){} // RVA: 0x7FFE87E72C70
        public void remove_FlushPendingResources(){} // RVA: 0x7FFE87E72DC0
        public void add_RegisterIntermediateRenderers(){} // RVA: 0x7FFE87E72F10
        public void remove_RegisterIntermediateRenderers(){} // RVA: 0x7FFE87E73070
        public void add_RenderNodeExecute(){} // RVA: 0x7FFE87E731D0
        public void remove_RenderNodeExecute(){} // RVA: 0x7FFE87E73330
        public void RaiseGraphicsResourcesRecreate(){} // RVA: 0x7FFE87E73490
        public void RaiseEngineUpdate(){} // RVA: 0x7FFE87E73510
        public void RaiseFlushPendingResources(){} // RVA: 0x7FFE87E735B0
        public void RaiseRegisterIntermediateRenderers(){} // RVA: 0x7FFE87E73620
        public void RaiseRenderNodeAdd(){} // RVA: 0x7FFE87E736A0
        public void RaiseRenderNodeExecute(){} // RVA: 0x7FFE87E73720
        public void RaiseRenderNodeCleanup(){} // RVA: 0x7FFE87E737A0
        public void AllocateBuffer(){} // RVA: 0x7FFE87E73820
        public void FreeBuffer(){} // RVA: 0x7FFE87E73890
        public void UpdateBufferRanges(){} // RVA: 0x7FFE87E738E0
        public void GetVertexDeclaration(){} // RVA: 0x7FFE87E739F0
        public void RegisterIntermediateRenderer(){} // RVA: 0x7FFE87E73A40
        public void DrawRanges(){} // RVA: 0x7FFE87E73B60
        public void SetPropertyBlock(){} // RVA: 0x7FFE87E73BF0
        public void SetScissorRect(){} // RVA: 0x7FFE87E73C40
        public void DisableScissor(){} // RVA: 0x7FFE87E73CD0
        public void CreateStencilState(){} // RVA: 0x7FFE87E73D20
        public void SetStencilState(){} // RVA: 0x7FFE87E73DB0
        public void HasMappedBufferRange(){} // RVA: 0x7FFE87E73E10
        public void InsertCPUFence(){} // RVA: 0x7FFE87E73E60
        public void CPUFencePassed(){} // RVA: 0x7FFE87E73EB0
        public void WaitForCPUFencePassed(){} // RVA: 0x7FFE87E73F00
        public void SyncRenderThread(){} // RVA: 0x7FFE87E73F50
        public void GetActiveViewport(){} // RVA: 0x7FFE87E73FA0
        public void ProfileDrawChainBegin(){} // RVA: 0x7FFE87E74030
        public void ProfileDrawChainEnd(){} // RVA: 0x7FFE87E74080
        public void NotifyOfUIREvents(){} // RVA: 0x7FFE87E740D0
        public void GetUnityProjectionMatrix(){} // RVA: 0x7FFE87E74120
        public void .cctor(){} // RVA: 0x7FFE87E741C0
        public void RegisterIntermediateRenderer_Injected(){} // RVA: 0x7FFE87E74270
        public void SetScissorRect_Injected(){} // RVA: 0x7FFE87E74310
        public void CreateStencilState_Injected(){} // RVA: 0x7FFE87E74360
        public void GetActiveViewport_Injected(){} // RVA: 0x7FFE87E743B0
        public void GetUnityProjectionMatrix_Injected(){} // RVA: 0x7FFE87E74400
    }

    public class VectorImageManager : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.VectorImageManager> instances;
        public Unity.Profiling.ProfilerMarker s_MarkerRegister; // 0x8

        // ── Methods ──
        public void get_atlas(){} // RVA: 0x7FFE87E93390
        public void .ctor(){} // RVA: 0x7FFE87E933B0
        public void get_disposed(){} // RVA: 0x7FFE812CF7D0
        public void set_disposed(){} // RVA: 0x7FFE812D0020
        public void Dispose(){} // RVA: 0x7FFE87E938F0 | overloaded x2
        public void Commit(){} // RVA: 0x7FFE87E93A80
        public void AddUser(){} // RVA: 0x7FFE87E93B10
        public void Register(){} // RVA: 0x7FFE87E93C80
        public void .cctor(){} // RVA: 0x7FFE87E94160
    }

    public class VectorImageRenderInfo : LinkedPoolItem`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE87E92E60
        public void .ctor(){} // RVA: 0x7FFE87E92EC0
    }

    public class VectorImageRenderInfoPool : LinkedPool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E92A60
    }

}