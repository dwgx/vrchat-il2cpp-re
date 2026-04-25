// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.UIR
// Classes: 50
// Methods: 381

namespace ThirdParty.Unity.UnityEngine.UIElements.UIR
{
    public class Alloc : ValueType
    {
        public uint start; // 0x10
        public uint size; // 0x14
        public object handle; // 0x18
        public bool shortLived; // 0x20
    }

    public class Allocator2D : Object
    {
        public UnityEngine.Vector2Int m_MinSize; // 0x10
        public UnityEngine.Vector2Int m_MaxSize; // 0x18
        public UnityEngine.Vector2Int m_MaxAllocSize; // 0x20
        public int m_RowHeightBias; // 0x28
        public Row[] m_Rows; // 0x30
        public System.Collections.Generic.List`1<Area> m_Areas; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9ACBE80
        public void TryAllocate(){} // RVA: 0x7FFAC9ACC3E0
        public void Free(){} // RVA: 0x7FFAC9ACC960
        public void BuildAreas(){} // RVA: 0x7FFAC9ACCC20
        public void ComputeMaxAllocSize(){} // RVA: 0x7FFAC9ACCDC0
        public void BuildRowArray(){} // RVA: 0x7FFAC9ACCEF0
    }

    public class BMPAlloc : ValueType
    {
        public UnityEngine.UIElements.UIR.BMPAlloc Invalid;
        public int page; // 0x10
        public ushort pageLine; // 0x14
        public byte bitIndex; // 0x16
        public 0x6B129198 ownedState; // 0x17

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC9AEBB00
        public void IsValid(){} // RVA: 0x7FFAC9AEBB20
        public void ToString(){} // RVA: 0x7FFAC9AEBB30
        public void .cctor(){} // RVA: 0x7FFAC9AEBC60
    }

    public class BaseShaderInfoStorage : Object
    {
        public int texture;
        public Unity.Profiling.ProfilerMarker disposed; // 0x8
        public Unity.Profiling.ProfilerMarker s_MarkerGetTextureData; // 0x10
        public Unity.Profiling.ProfilerMarker s_MarkerUpdateTexture; // 0x18
        public bool <disposed>k__BackingField; // 0x10

        // ── Methods ──
        public void get_texture(){} // RVA: 0x7FFAC2C58E90
        public void AllocateRect(){}
        public void SetTexel(){}
        public void UpdateTexture(){} // RVA: 0x7FFAC2C70980
        public void get_disposed(){} // RVA: 0x7FFAC2FEB5E0
        public void set_disposed(){} // RVA: 0x7FFAC2FEB5F0
        public void Dispose(){} // RVA: 0x7FFAC8438240 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9AE68A0
    }

    public class BasicNodePool`1 : LinkedPool`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAC2C70A10
        public void Create(){} // RVA: 0x7FFAC2C58A90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class BasicNode`1 : LinkedPoolItem`1
    {
        public UnityEngine.UIElements.UIR.BasicNode`1<T> next;
        public T data;

        // ── Methods ──
        public void AppendTo(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class BestFitAllocator : Object
    {
        public uint totalSize; // 0x10
        public Block highWatermark; // 0x18
        public Block m_FirstAvailableBlock; // 0x20
        public BlockPool m_BlockPool; // 0x28
        public uint m_HighWatermark; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9AD6880
        public void get_totalSize(){} // RVA: 0x7FFAC2F6E5C0
        public void get_highWatermark(){} // RVA: 0x7FFAC9AD6AE0
        public void Allocate(){} // RVA: 0x7FFAC9AD6AF0
        public void Free(){} // RVA: 0x7FFAC9AD6E90
        public void CoalesceBlockWithPrevious(){} // RVA: 0x7FFAC9AD7310
        public void BestFitFindAvailableBlock(){} // RVA: 0x7FFAC9AD7570
        public void SplitBlock(){} // RVA: 0x7FFAC9AD75B0
    }

    public class BitmapAllocator32 : ValueType
    {
        public int entryWidth; // 0x10
        public System.Collections.Generic.List`1<Page> entryHeight; // 0x18
        public System.Collections.Generic.List`1<uint> m_AllocMap; // 0x20
        public int m_EntryWidth; // 0x28
        public int m_EntryHeight; // 0x2C

        // ── Methods ──
        public void Construct(){} // RVA: 0x7FFAC9AEBCC0
        public void ForceFirstAlloc(){} // RVA: 0x7FFAC9AEBEE0
        public void Allocate(){} // RVA: 0x7FFAC9AEC0A0
        public void Free(){} // RVA: 0x7FFAC9AEC550
        public void get_entryWidth(){} // RVA: 0x7FFAC669DCA0
        public void get_entryHeight(){} // RVA: 0x7FFAC5CC4740
        public void GetAllocPageAtlasLocation(){} // RVA: 0x7FFAC9AEC6D0
        public void CountTrailingZeroes(){} // RVA: 0x7FFAC9AEC770
    }

    public class ChainBuilderStats : ValueType
    {
        public uint elementsAdded; // 0x10
        public uint elementsRemoved; // 0x14
        public uint recursiveClipUpdates; // 0x18
        public uint recursiveClipUpdatesExpanded; // 0x1C
        public uint nonRecursiveClipUpdates; // 0x20
        public uint recursiveTransformUpdates; // 0x24
        public uint recursiveTransformUpdatesExpanded; // 0x28
        public uint recursiveOpacityUpdates; // 0x2C
        public uint recursiveOpacityUpdatesExpanded; // 0x30
        public uint opacityIdUpdates; // 0x34
        public uint colorUpdates; // 0x38
        public uint colorUpdatesExpanded; // 0x3C
        public uint recursiveVisualUpdates; // 0x40
        public uint recursiveVisualUpdatesExpanded; // 0x44
        public uint nonRecursiveVisualUpdates; // 0x48
        public uint dirtyProcessed; // 0x4C
        public uint nudgeTransformed; // 0x50
        public uint boneTransformed; // 0x54
        public uint skipTransformed; // 0x58
        public uint visualUpdateTransformed; // 0x5C
        public uint updatedMeshAllocations; // 0x60
        public uint newMeshAllocations; // 0x64
        public uint groupTransformElementsChanged; // 0x68
        public uint immedateRenderersActive; // 0x6C
    }

    public class ConvertMeshJobData : ValueType
    {
        public UIntPtr vertSrc; // 0x10
        public UIntPtr vertDst; // 0x18
        public int vertCount; // 0x20
        public UnityEngine.Matrix4x4 transform; // 0x24
        public int transformUVs; // 0x64
        public UnityEngine.Color32 xformClipPages; // 0x68
        public UnityEngine.Color32 ids; // 0x6C
        public UnityEngine.Color32 addFlags; // 0x70
        public UnityEngine.Color32 opacityPage; // 0x74
        public UnityEngine.Color32 textCoreSettingsPage; // 0x78
        public int isText; // 0x7C
        public float textureId; // 0x80
        public UIntPtr indexSrc; // 0x88
        public UIntPtr indexDst; // 0x90
        public int indexCount; // 0x98
        public int indexOffset; // 0x9C
        public int flipIndices; // 0xA0
    }

    public class CopyClosingMeshJobData : ValueType
    {
        public UIntPtr vertSrc; // 0x10
        public UIntPtr vertDst; // 0x18
        public int vertCount; // 0x20
        public UIntPtr indexSrc; // 0x28
        public UIntPtr indexDst; // 0x30
        public int indexCount; // 0x38
        public int indexOffset; // 0x3C
    }

    public class DetachedAllocator : Object
    {
        public UnityEngine.UIElements.UIR.TempAllocator`1<UnityEngine.UIElements.Vertex> m_VertsPool; // 0x10
        public UnityEngine.UIElements.UIR.TempAllocator`1<ushort> m_IndexPool; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.UIElements.MeshWriteData> m_MeshWriteDataPool; // 0x20
        public int m_MeshWriteDataCount; // 0x28
        public bool m_Disposed; // 0x2C

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC9ACD570 | overloaded x2
    }

    public class DrawBufferRange : ValueType
    {
        public int firstIndex; // 0x10
        public int indexCount; // 0x14
        public int minIndexVal; // 0x18
        public int vertsReferenced; // 0x1C
    }

    public class DrawParams : Object
    {
        public UnityEngine.Rect k_UnlimitedRect;
        public UnityEngine.Rect k_FullNormalizedRect; // 0x10
        public System.Collections.Generic.Stack`1<UnityEngine.Matrix4x4> view; // 0x10
        public System.Collections.Generic.Stack`1<UnityEngine.Rect> scissor; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.RenderTexture> renderTexture; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.Material> defaultMaterial; // 0x28

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAC9AD88E0
        public void .ctor(){} // RVA: 0x7FFAC9AD8B10
        public void .cctor(){} // RVA: 0x7FFAC9AD8F60
    }

    public class GPUBufferAllocator : Object
    {
        public UnityEngine.UIElements.UIR.BestFitAllocator isEmpty; // 0x10
        public UnityEngine.UIElements.UIR.BestFitAllocator m_High; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9AD7AD0
        public void Allocate(){} // RVA: 0x7FFAC9AD7C10
        public void Free(){} // RVA: 0x7FFAC9AD7E20
        public void get_isEmpty(){} // RVA: 0x7FFAC9AD7EA0
        public void HighLowCollide(){} // RVA: 0x7FFAC9AD7EE0
    }

    public class GfxUpdateBufferRange : ValueType
    {
        public uint offsetFromWriteStart; // 0x10
        public uint size; // 0x14
        public object source; // 0x18
    }

    public class GradientRemap : LinkedPoolItem`1
    {
        public int origIndex; // 0x18
        public int destIndex; // 0x1C
        public UnityEngine.RectInt location; // 0x20
        public UnityEngine.UIElements.UIR.GradientRemap next; // 0x30
        public UnityEngine.UIElements.TextureId atlas; // 0x38

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAC9AEAA50
        public void .ctor(){} // RVA: 0x7FFAC9AEAAC0
    }

    public class GradientRemapPool : LinkedPool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9AEA650
    }

    public class GradientSettingsAtlas : Object
    {
        public Unity.Profiling.ProfilerMarker length;
        public Unity.Profiling.ProfilerMarker disposed; // 0x8
        public int atlas; // 0x10
        public int MustCommit; // 0x14
        public UnityEngine.UIElements.UIR.BestFitAllocator m_Allocator; // 0x18
        public UnityEngine.Texture2D m_Atlas; // 0x20
        public RawTexture m_RawAtlas; // 0x28
        public int s_TextureCounter; // 0x10
        public bool <disposed>k__BackingField; // 0x38
        public bool <MustCommit>k__BackingField; // 0x39

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFAC9851CE0
        public void get_disposed(){} // RVA: 0x7FFAC31D95D0
        public void set_disposed(){} // RVA: 0x7FFAC31D95C0
        public void Dispose(){} // RVA: 0x7FFAC9ADAD60 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC9ADADD0
        public void Reset(){} // RVA: 0x7FFAC9ADAEF0
        public void get_atlas(){} // RVA: 0x7FFAC91BAEE0
        public void Add(){} // RVA: 0x7FFAC9ADB000
        public void Write(){} // RVA: 0x7FFAC9ADB0F0
        public void get_MustCommit(){} // RVA: 0x7FFAC33BCE50
        public void set_MustCommit(){} // RVA: 0x7FFAC33BD1D0
        public void Commit(){} // RVA: 0x7FFAC9ADB630
        public void PrepareAtlas(){} // RVA: 0x7FFAC9ADB6A0
        public void .cctor(){} // RVA: 0x7FFAC9ADB9D0
    }

    public class JobManager : Object
    {
        public UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.NudgeJobData> disposed; // 0x10
        public UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.ConvertMeshJobData> m_ConvertMeshJobs; // 0x18
        public UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.CopyClosingMeshJobData> m_CopyClosingMeshJobs; // 0x20
        public UnityEngine.UIElements.UIR.JobMerger m_JobMerger; // 0x28
        public bool <disposed>k__BackingField; // 0x30

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC9ADBF30 | overloaded x3
        public void CompleteNudgeJobs(){} // RVA: 0x7FFAC9ADC0F0
        public void CompleteConvertMeshJobs(){} // RVA: 0x7FFAC9ADC480
        public void CompleteClosingMeshJobs(){} // RVA: 0x7FFAC9ADC810
        public void get_disposed(){} // RVA: 0x7FFAC2F47450
        public void set_disposed(){} // RVA: 0x7FFAC2F47460
        public void Dispose(){} // RVA: 0x7FFAC9ADCD30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC9ADCE80
    }

    public class JobMerger : Object
    {
        public Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle> disposed; // 0x10
        public int m_JobCount; // 0x20
        public bool <disposed>k__BackingField; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9ADD210
        public void Add(){} // RVA: 0x7FFAC9ADD2D0
        public void MergeAndReset(){} // RVA: 0x7FFAC9ADD3D0
        public void get_disposed(){} // RVA: 0x7FFAC2F3C7C0
        public void set_disposed(){} // RVA: 0x7FFAC4422FB0
        public void Dispose(){} // RVA: 0x7FFAC9ADD5B0 | overloaded x2
    }

    public class JobProcessor : Object
    {
        // ── Methods ──
        public void ScheduleNudgeJobs(){} // RVA: 0x7FFAC9ACBBB0
        public void ScheduleConvertMeshJobs(){} // RVA: 0x7FFAC9ACBC30
        public void ScheduleCopyClosingMeshJobs(){} // RVA: 0x7FFAC9ACBCB0
        public void ScheduleNudgeJobs_Injected(){} // RVA: 0x7FFAC9ACBD30
        public void ScheduleConvertMeshJobs_Injected(){} // RVA: 0x7FFAC9ACBDA0
        public void ScheduleCopyClosingMeshJobs_Injected(){} // RVA: 0x7FFAC9ACBE10
    }

    public class LinkedPoolItem`1 : Object
    {
        public T poolNext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class LinkedPool`1 : Object
    {
        public System.Func`1<T> Count;
        public System.Action`1<T> m_ResetAction;
        public int m_Limit;
        public T m_PoolFirst;
        public int <Count>k__BackingField;

        // ── Methods ──
        public void .ctor(){}
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void set_Count(){} // RVA: 0x7FFAC2C70ED0
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Get(){} // RVA: 0x7FFAC2E8DC40
        public void Return(){} // RVA: 0x7FFAC2E8DC40
    }

    public class MeshBuilder : Object
    {
        public Unity.Profiling.ProfilerMarker s_VectorGraphics9Slice;
        public Unity.Profiling.ProfilerMarker s_VectorGraphicsSplitTriangle; // 0x8
        public Unity.Profiling.ProfilerMarker s_VectorGraphicsScaleTriangle; // 0x10
        public Unity.Profiling.ProfilerMarker s_VectorGraphicsStretch; // 0x18
        public int s_MaxTextMeshVertices; // 0x20

        // ── Methods ──
        public void ConvertTextVertexToUIRVertex(){} // RVA: 0x7FFAC9ADD610
        public void LimitTextVertices(){} // RVA: 0x7FFAC9ADD7E0
        public void MakeText(){} // RVA: 0x7FFAC9ADD960
        public void .cctor(){} // RVA: 0x7FFAC9ADE220
    }

    public class MeshHandle : LinkedPoolItem`1
    {
        public UnityEngine.UIElements.UIR.Alloc allocVerts; // 0x18
        public UnityEngine.UIElements.UIR.Alloc allocIndices; // 0x30
        public uint triangleCount; // 0x48
        public UnityEngine.UIElements.UIR.Page allocPage; // 0x50
        public uint allocTime; // 0x58
        public uint updateAllocID; // 0x5C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9ACD5F0
    }

    public class NativePagedList`1 : Object
    {
        public int disposed;
        public System.Collections.Generic.List`1<Unity.Collections.NativeArray`1<T>> m_Pages;
        public Unity.Collections.NativeArray`1<T> m_CurrentPage;
        public int m_CurrentPageCount;
        public System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<T>> m_Enumerator;
        public bool <disposed>k__BackingField;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0
        public void Add(){} // RVA: 0x7FFAC2C70A40
        public void GetPages(){} // RVA: 0x7FFAC2C58E90
        public void Reset(){} // RVA: 0x7FFAC2C70980
        public void get_disposed(){} // RVA: 0x7FFAC2C59D00
        public void set_disposed(){} // RVA: 0x7FFAC2C71060
        public void Dispose(){} // RVA: 0x7FFAC2C71060 | overloaded x2
    }

    public class NudgeJobData : ValueType
    {
        public UIntPtr src; // 0x10
        public UIntPtr dst; // 0x18
        public int count; // 0x20
        public UIntPtr closingSrc; // 0x28
        public UIntPtr closingDst; // 0x30
        public int closingCount; // 0x38
        public UnityEngine.Matrix4x4 transform; // 0x3C
        public int vertsBeforeUVDisplacement; // 0x7C
        public int vertsAfterUVDisplacement; // 0x80
    }

    public class OpacityIdAccelerator : Object
    {
        public Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle> disposed; // 0x10
        public int m_NextJobIndex; // 0x20
        public bool <disposed>k__BackingField; // 0x24

        // ── Methods ──
        public void CreateJob(){} // RVA: 0x7FFAC9ADE480
        public void CompleteJobs(){} // RVA: 0x7FFAC9ADE770
        public void get_disposed(){} // RVA: 0x7FFAC2F3C7C0
        public void set_disposed(){} // RVA: 0x7FFAC4422FB0
        public void Dispose(){} // RVA: 0x7FFAC9ADE9C0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC9ADEA20
    }

    public class Page : Object
    {
        public bool disposed; // 0x10
        public DataSet`1<UnityEngine.UIElements.Vertex> isEmpty; // 0x18
        public DataSet`1<ushort> indices; // 0x20
        public UnityEngine.UIElements.UIR.Page next; // 0x28
        public int framesEmpty; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9AD8300
        public void get_disposed(){} // RVA: 0x7FFAC2FEB5E0
        public void set_disposed(){} // RVA: 0x7FFAC2FEB5F0
        public void Dispose(){} // RVA: 0x7FFAC9AD8560 | overloaded x2
        public void get_isEmpty(){} // RVA: 0x7FFAC9AD8860
    }

    public class RenderChain : Object
    {
        public UnityEngine.UIElements.UIR.RenderChainCommand opacityIdAccelerator; // 0x10
        public DepthOrderedDirtyTracking disposed; // 0x18
        public UnityEngine.UIElements.UIR.LinkedPool`1<UnityEngine.UIElements.UIR.RenderChainCommand> panel; // 0x40
        public UnityEngine.UIElements.UIR.BasicNodePool`1<UnityEngine.UIElements.UIR.TextureEntry> device; // 0x48
        public System.Collections.Generic.List`1<RenderNodeData> atlas; // 0x50
        public UnityEngine.Shader vectorImageManager; // 0x58
        public UnityEngine.Shader vertsPool; // 0x60
        public UnityEngine.Material indicesPool; // 0x68
        public UnityEngine.Material jobManager; // 0x70
        public bool painter; // 0x78
        public int drawStats; // 0x7C
        public int drawInCameras; // 0x80
        public int defaultShader; // 0x84
        public UnityEngine.UIElements.UIR.ChainBuilderStats defaultWorldSpaceShader; // 0x88
        public uint m_StatsElementsAdded; // 0xE8
        public uint m_StatsElementsRemoved; // 0xEC
        public UnityEngine.UIElements.TextureRegistry m_TextureRegistry; // 0xF0
        public UnityEngine.UIElements.UIR.OpacityIdAccelerator <opacityIdAccelerator>k__BackingField; // 0xF8
        public Unity.Profiling.ProfilerMarker s_MarkerProcess;
        public Unity.Profiling.ProfilerMarker s_MarkerClipProcessing; // 0x8
        public Unity.Profiling.ProfilerMarker s_MarkerOpacityProcessing; // 0x10
        public Unity.Profiling.ProfilerMarker s_MarkerColorsProcessing; // 0x18
        public Unity.Profiling.ProfilerMarker s_MarkerTransformProcessing; // 0x20
        public Unity.Profiling.ProfilerMarker s_MarkerVisualsProcessing; // 0x28
        public Unity.Profiling.ProfilerMarker s_MarkerTextRegen; // 0x30
        public bool <disposed>k__BackingField; // 0x100
        public System.Action OnPreRender; // 0x38
        public UnityEngine.UIElements.BaseVisualElementPanel <panel>k__BackingField; // 0x108
        public UnityEngine.UIElements.UIR.UIRenderDevice <device>k__BackingField; // 0x110
        public UnityEngine.UIElements.AtlasBase <atlas>k__BackingField; // 0x118
        public UnityEngine.UIElements.UIR.VectorImageManager <vectorImageManager>k__BackingField; // 0x120
        public UnityEngine.UIElements.UIR.TempAllocator`1<UnityEngine.UIElements.Vertex> <vertsPool>k__BackingField; // 0x128
        public UnityEngine.UIElements.UIR.TempAllocator`1<ushort> <indicesPool>k__BackingField; // 0x130
        public UnityEngine.UIElements.UIR.JobManager <jobManager>k__BackingField; // 0x138
        public UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator shaderInfoAllocator; // 0x140
        public UnityEngine.UIElements.UIR.Implementation.UIRStylePainter <painter>k__BackingField; // 0x210
        public bool <drawStats>k__BackingField; // 0x218
        public bool <drawInCameras>k__BackingField; // 0x219

        // ── Methods ──
        public void get_opacityIdAccelerator(){} // RVA: 0x7FFAC3331F50
        public void set_opacityIdAccelerator(){} // RVA: 0x7FFAC34A4860
        public void .cctor(){} // RVA: 0x7FFAC9ADEC20
        public void .ctor(){} // RVA: 0x7FFAC9ADF350
        public void Constructor(){} // RVA: 0x7FFAC9ADFA00
        public void Destructor(){} // RVA: 0x7FFAC9AE0510
        public void get_disposed(){} // RVA: 0x7FFAC3C8B9C0
        public void set_disposed(){} // RVA: 0x7FFAC3C8DFF0
        public void Dispose(){} // RVA: 0x7FFAC9AE0DF0 | overloaded x2
        public void ProcessChanges(){} // RVA: 0x7FFAC9AE0E20
        public void Render(){} // RVA: 0x7FFAC9AE16E0
        public void UIEOnChildAdded(){} // RVA: 0x7FFAC9AE1CB0
        public void UIEOnChildrenReordered(){} // RVA: 0x7FFAC9AE2010
        public void UIEOnChildRemoving(){} // RVA: 0x7FFAC9AE23F0
        public void UIEOnRenderHintsChanged(){} // RVA: 0x7FFAC9AE2500
        public void UIEOnClippingChanged(){} // RVA: 0x7FFAC9AE25D0
        public void UIEOnOpacityChanged(){} // RVA: 0x7FFAC9AE2670
        public void UIEOnColorChanged(){} // RVA: 0x7FFAC9AE2710
        public void UIEOnTransformOrSizeChanged(){} // RVA: 0x7FFAC9AE27B0
        public void UIEOnVisualsChanged(){} // RVA: 0x7FFAC9AE2850
        public void UIEOnOpacityIdChanged(){} // RVA: 0x7FFAC9AE28F0
        public void get_panel(){} // RVA: 0x7FFAC36D1F40
        public void set_panel(){} // RVA: 0x7FFAC3929BF0
        public void get_device(){} // RVA: 0x7FFAC354B170
        public void set_device(){} // RVA: 0x7FFAC39B3E10
        public void get_atlas(){} // RVA: 0x7FFAC33BC6D0
        public void set_atlas(){} // RVA: 0x7FFAC33B8580
        public void get_vectorImageManager(){} // RVA: 0x7FFAC313CBB0
        public void set_vectorImageManager(){} // RVA: 0x7FFAC3143400
        public void get_vertsPool(){} // RVA: 0x7FFAC35466F0
        public void set_vertsPool(){} // RVA: 0x7FFAC39C51C0
        public void get_indicesPool(){} // RVA: 0x7FFAC3544340
        public void set_indicesPool(){} // RVA: 0x7FFAC39A79B0
        public void get_jobManager(){} // RVA: 0x7FFAC35422C0
        public void set_jobManager(){} // RVA: 0x7FFAC36D84B0
        public void get_painter(){} // RVA: 0x7FFAC354BCB0
        public void set_painter(){} // RVA: 0x7FFAC3543140
        public void get_drawStats(){} // RVA: 0x7FFAC9AE2990
        public void set_drawStats(){} // RVA: 0x7FFAC90C45C0
        public void get_drawInCameras(){} // RVA: 0x7FFAC9AE29A0
        public void set_drawInCameras(){} // RVA: 0x7FFAC9AE29B0
        public void set_defaultShader(){} // RVA: 0x7FFAC9AE29C0
        public void set_defaultWorldSpaceShader(){} // RVA: 0x7FFAC9AE2BD0
        public void GetStandardMaterial(){} // RVA: 0x7FFAC9AE2DE0
        public void GetStandardWorldSpaceMaterial(){} // RVA: 0x7FFAC9AE3070
        public void EnsureFitsDepth(){} // RVA: 0x7FFAC9AE3300
        public void ChildWillBeRemoved(){} // RVA: 0x7FFAC9AE3310
        public void AllocCommand(){} // RVA: 0x7FFAC9AE33D0
        public void FreeCommand(){} // RVA: 0x7FFAC9AE3430
        public void OnRenderCommandAdded(){} // RVA: 0x7FFAC9AE3550
        public void OnRenderCommandsRemoved(){} // RVA: 0x7FFAC9AE3690
        public void AccessRenderNodeData(){} // RVA: 0x7FFAC9AE3700
        public void OnRenderNodeExecute(){} // RVA: 0x7FFAC9AE3890
        public void OnRegisterIntermediateRenderers(){} // RVA: 0x7FFAC9AE3AD0
        public void OnRegisterIntermediateRendererMat(){} // RVA: 0x7FFAC9AE4470
        public void RepaintTexturedElements(){} // RVA: 0x7FFAC9AE49D0
        public void AppendTexture(){} // RVA: 0x7FFAC9AE4B20
        public void ResetTextures(){} // RVA: 0x7FFAC9AE4CF0
        public void DrawStats(){} // RVA: 0x7FFAC9AE4E70
        public void GetFirstElementInPanel(){} // RVA: 0x7FFAC9AE5940
    }

    public class RenderChainCommand : LinkedPoolItem`1
    {
        public UnityEngine.UIElements.VisualElement owner; // 0x18
        public UnityEngine.UIElements.UIR.RenderChainCommand prev; // 0x20
        public UnityEngine.UIElements.UIR.RenderChainCommand next; // 0x28
        public bool closing; // 0x30
        public 0x6B128010 type; // 0x34
        public UnityEngine.UIElements.UIR.State state; // 0x38
        public UnityEngine.UIElements.UIR.MeshHandle mesh; // 0x50
        public int indexOffset; // 0x58
        public int indexCount; // 0x5C
        public System.Action callback; // 0x60
        public int k_ID_MainTex;
        public Unity.Profiling.ProfilerMarker s_ImmediateOverheadMarker; // 0x8

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAC9AD8FC0
        public void ExecuteNonDrawMesh(){} // RVA: 0x7FFAC9AD9170
        public void Blit(){} // RVA: 0x7FFAC9ADA4A0
        public void CombineScissorRects(){} // RVA: 0x7FFAC9ADA8F0
        public void RectPointsToPixelsAndFlipYAxis(){} // RVA: 0x7FFAC9ADAA60
        public void .ctor(){} // RVA: 0x7FFAC9ADABB0
        public void .cctor(){} // RVA: 0x7FFAC9ADABE0
    }

    public class RenderChainVEData : ValueType
    {
        public UnityEngine.UIElements.VisualElement lastClosingOrLastCommand; // 0x10
        public UnityEngine.UIElements.VisualElement isIgnoringDynamicColorHint; // 0x18
        public UnityEngine.UIElements.VisualElement groupTransformAncestor; // 0x20
        public UnityEngine.UIElements.VisualElement boneTransformAncestor; // 0x28
        public UnityEngine.UIElements.VisualElement prevDirty; // 0x30
        public UnityEngine.UIElements.VisualElement nextDirty; // 0x38
        public 0x6B1289B0 flags; // 0x40
        public int hierarchyDepth; // 0x44
        public 0x6B128900 dirtiedValues; // 0x48
        public uint dirtyID; // 0x4C
        public UnityEngine.UIElements.UIR.RenderChainCommand firstCommand; // 0x50
        public UnityEngine.UIElements.UIR.RenderChainCommand lastCommand; // 0x58
        public UnityEngine.UIElements.UIR.RenderChainCommand firstClosingCommand; // 0x60
        public UnityEngine.UIElements.UIR.RenderChainCommand lastClosingCommand; // 0x68
        public bool isInChain; // 0x70
        public bool isHierarchyHidden; // 0x71
        public bool localFlipsWinding; // 0x72
        public bool localTransformScaleZero; // 0x73
        public bool worldFlipsWinding; // 0x74
        public bool worldTransformScaleZero; // 0x75
        public 0x6B1293A8 clipMethod; // 0x78
        public int childrenStencilRef; // 0x7C
        public int childrenMaskDepth; // 0x80
        public bool disableNudging; // 0x84
        public UnityEngine.UIElements.UIR.MeshHandle data; // 0x88
        public UnityEngine.UIElements.UIR.MeshHandle closingData; // 0x90
        public UnityEngine.Matrix4x4 verticesSpace; // 0x98
        public int displacementUVStart; // 0xD8
        public int displacementUVEnd; // 0xDC
        public UnityEngine.UIElements.UIR.BMPAlloc transformID; // 0xE0
        public UnityEngine.UIElements.UIR.BMPAlloc clipRectID; // 0xE8
        public UnityEngine.UIElements.UIR.BMPAlloc opacityID; // 0xF0
        public UnityEngine.UIElements.UIR.BMPAlloc textCoreSettingsID; // 0xF8
        public UnityEngine.UIElements.UIR.BMPAlloc colorID; // 0x100
        public UnityEngine.UIElements.UIR.BMPAlloc backgroundColorID; // 0x108
        public UnityEngine.UIElements.UIR.BMPAlloc borderLeftColorID; // 0x110
        public UnityEngine.UIElements.UIR.BMPAlloc borderTopColorID; // 0x118
        public UnityEngine.UIElements.UIR.BMPAlloc borderRightColorID; // 0x120
        public UnityEngine.UIElements.UIR.BMPAlloc borderBottomColorID; // 0x128
        public UnityEngine.UIElements.UIR.BMPAlloc tintColorID; // 0x130
        public float compositeOpacity; // 0x138
        public UnityEngine.Color backgroundColor; // 0x13C
        public UnityEngine.UIElements.UIR.BasicNode`1<UnityEngine.UIElements.UIR.TextureEntry> textures; // 0x150

        // ── Methods ──
        public void get_lastClosingOrLastCommand(){} // RVA: 0x7FFAC9AE6750
        public void AllocatesID(){} // RVA: 0x7FFAC9AE6760
        public void InheritsID(){} // RVA: 0x7FFAC9AE67C0
        public void get_isIgnoringDynamicColorHint(){} // RVA: 0x7FFAC9AE6820
    }

    public class ShaderInfoStorageRGBA32 : ShaderInfoStorage`1
    {
        public System.Func`2<UnityEngine.Color,UnityEngine.Color32> s_Convert;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9AE6A40
        public void .cctor(){} // RVA: 0x7FFAC9AE6AF0
    }

    public class ShaderInfoStorageRGBAFloat : ShaderInfoStorage`1
    {
        public System.Func`2<UnityEngine.Color,UnityEngine.Color> s_Convert;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9AE6D80
        public void .cctor(){} // RVA: 0x7FFAC9AE6E30
    }

    public class ShaderInfoStorage`1 : BaseShaderInfoStorage
    {
        public int texture;
        public int m_MaxSize;
        public 0x6B17C078 m_Format;
        public System.Func`2<UnityEngine.Color,T> m_Convert;
        public UnityEngine.UIElements.UIRAtlasAllocator m_Allocator;
        public UnityEngine.Texture2D m_Texture;
        public Unity.Collections.NativeArray`1<T> m_Texels;

        // ── Methods ──
        public void .ctor(){}
        public void Dispose(){} // RVA: 0x7FFAC2C71060
        public void get_texture(){} // RVA: 0x7FFAC2C58E90
        public void AllocateRect(){}
        public void SetTexel(){}
        public void UpdateTexture(){} // RVA: 0x7FFAC2C70980
        public void CreateOrExpandTexture(){} // RVA: 0x7FFAC2C70980
        public void CpuBlit(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Shaders : Object
    {
        public string k_AtlasBlit;
        public string k_Editor; // 0x8
        public string k_Runtime; // 0x10
        public string k_RuntimeWorld; // 0x18
        public string k_GraphView; // 0x20
        public string k_ColorConversionBlit; // 0x28

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9AE70A0
    }

    public class State : ValueType
    {
        public UnityEngine.Material material; // 0x10
        public UnityEngine.UIElements.TextureId texture; // 0x18
        public int stencilRef; // 0x1C
        public float sdfScale; // 0x20
    }

    public class TempAllocator`1 : Object
    {
        public int disposed;
        public int m_ExcessMaxCapacity;
        public Page<T> m_Pool;
        public System.Collections.Generic.List`1<Page<T>> m_Excess;
        public int m_NextExcessSize;
        public bool <disposed>k__BackingField;

        // ── Methods ──
        public void .ctor(){}
        public void get_disposed(){} // RVA: 0x7FFAC2C59D00
        public void set_disposed(){} // RVA: 0x7FFAC2C71060
        public void Dispose(){} // RVA: 0x7FFAC2C71060 | overloaded x2
        public void Alloc(){} // RVA: 0x7FFAC2E8DC40
        public void Reset(){} // RVA: 0x7FFAC2C70980
        public void ReleaseExcess(){} // RVA: 0x7FFAC2C70980
    }

    public class TextCoreSettings : ValueType
    {
        public UnityEngine.Color faceColor; // 0x10
        public UnityEngine.Color outlineColor; // 0x20
        public float outlineWidth; // 0x30
        public UnityEngine.Color underlayColor; // 0x34
        public UnityEngine.Vector2 underlayOffset; // 0x44
        public float underlaySoftness; // 0x4C

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC9AE77F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9AE7990
    }

    public class TextureBlitter : Object
    {
        public int[] disposed;
        public Unity.Profiling.ProfilerMarker s_CommitSampler; // 0x8
        public BlitInfo[] m_SingleBlit; // 0x10
        public UnityEngine.Material m_BlitMaterial; // 0x18
        public UnityEngine.MaterialPropertyBlock m_Properties; // 0x20
        public UnityEngine.RectInt m_Viewport; // 0x28
        public UnityEngine.RenderTexture m_PrevRT; // 0x38
        public System.Collections.Generic.List`1<BlitInfo> m_PendingBlits; // 0x40
        public bool <disposed>k__BackingField; // 0x48

        // ── Methods ──
        public void get_disposed(){} // RVA: 0x7FFAC2FD8D30
        public void set_disposed(){} // RVA: 0x7FFAC2FD8D40
        public void Dispose(){} // RVA: 0x7FFAC9AE7AD0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9AE7B90
        public void .ctor(){} // RVA: 0x7FFAC9AE7E10
        public void QueueBlit(){} // RVA: 0x7FFAC9AE7F60
        public void BlitOneNow(){} // RVA: 0x7FFAC9AE80C0
        public void Commit(){} // RVA: 0x7FFAC9AE8270
        public void BeginBlit(){} // RVA: 0x7FFAC9AE8370
        public void DoBlit(){} // RVA: 0x7FFAC9AE8890
        public void EndBlit(){} // RVA: 0x7FFAC9AE9340
    }

    public class TextureEntry : ValueType
    {
        public UnityEngine.Texture source; // 0x10
        public UnityEngine.UIElements.TextureId actual; // 0x18
        public bool replaced; // 0x1C
    }

    public class TextureSlotManager : Object
    {
        public int FreeSlots;
        public int k_SlotSize; // 0x4
        public int[] slotIds; // 0x8
        public int textureTableId; // 0x10
        public UnityEngine.UIElements.TextureId[] m_Textures; // 0x10
        public int[] m_Tickets; // 0x18
        public int m_CurrentTicket; // 0x20
        public int m_FirstUsedTicket; // 0x24
        public UnityEngine.Vector4[] m_GpuTextures; // 0x28
        public int <FreeSlots>k__BackingField; // 0x30
        public UnityEngine.UIElements.TextureRegistry textureRegistry; // 0x38

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9AE9420
        public void .ctor(){} // RVA: 0x7FFAC9AE96F0
        public void Reset(){} // RVA: 0x7FFAC9AE99A0
        public void StartNewBatch(){} // RVA: 0x7FFAC9AE9AF0
        public void IndexOf(){} // RVA: 0x7FFAC9AE9B60
        public void MarkUsed(){} // RVA: 0x7FFAC9AD8090
        public void get_FreeSlots(){} // RVA: 0x7FFAC2F7CCD0
        public void set_FreeSlots(){} // RVA: 0x7FFAC2F7CCE0
        public void FindOldestSlot(){} // RVA: 0x7FFAC9AE9C30
        public void Bind(){} // RVA: 0x7FFAC9AE9D00
        public void SetGpuData(){} // RVA: 0x7FFAC9AE9FF0
    }

    public class Transform3x4 : ValueType
    {
        public UnityEngine.Vector4 v0; // 0x10
        public UnityEngine.Vector4 v1; // 0x20
        public UnityEngine.Vector4 v2; // 0x30
    }

    public class UIRVEShaderInfoAllocator : ValueType
    {
        public UnityEngine.UIElements.UIR.BaseShaderInfoStorage pageWidth; // 0x10
        public UnityEngine.UIElements.UIR.BitmapAllocator32 pageHeight; // 0x18
        public UnityEngine.UIElements.UIR.BitmapAllocator32 transformConstants; // 0x38
        public UnityEngine.UIElements.UIR.BitmapAllocator32 clipRectConstants; // 0x58
        public UnityEngine.UIElements.UIR.BitmapAllocator32 atlas; // 0x78
        public UnityEngine.UIElements.UIR.BitmapAllocator32 m_TextSettingsAllocator; // 0x98
        public bool m_StorageReallyCreated; // 0xB8
        public bool m_VertexTexturingEnabled; // 0xB9
        public Unity.Collections.NativeArray`1<UnityEngine.UIElements.UIR.Transform3x4> m_Transforms; // 0xC0
        public Unity.Collections.NativeArray`1<UnityEngine.Vector4> m_ClipRects; // 0xD0
        public UnityEngine.Vector2Int identityTransformTexel;
        public UnityEngine.Vector2Int infiniteClipRectTexel; // 0x8
        public UnityEngine.Vector2Int fullOpacityTexel; // 0x10
        public UnityEngine.Vector2Int clearColorTexel; // 0x18
        public UnityEngine.Vector2Int defaultTextCoreSettingsTexel; // 0x20
        public UnityEngine.Matrix4x4 identityTransformValue; // 0x28
        public UnityEngine.Vector4 identityTransformRow0Value; // 0x68
        public UnityEngine.Vector4 identityTransformRow1Value; // 0x78
        public UnityEngine.Vector4 identityTransformRow2Value; // 0x88
        public UnityEngine.Vector4 infiniteClipRectValue; // 0x98
        public UnityEngine.Vector4 fullOpacityValue; // 0xA8
        public UnityEngine.Vector4 clearColorValue; // 0xB8
        public UnityEngine.UIElements.UIR.TextCoreSettings defaultTextCoreSettingsValue; // 0xC8
        public UnityEngine.UIElements.UIR.BMPAlloc identityTransform; // 0x108
        public UnityEngine.UIElements.UIR.BMPAlloc infiniteClipRect; // 0x110
        public UnityEngine.UIElements.UIR.BMPAlloc fullOpacity; // 0x118
        public UnityEngine.UIElements.UIR.BMPAlloc clearColor; // 0x120
        public UnityEngine.UIElements.UIR.BMPAlloc defaultTextCoreSettings; // 0x128

        // ── Methods ──
        public void get_pageWidth(){} // RVA: 0x7FFAC9AEC800
        public void get_pageHeight(){} // RVA: 0x7FFAC9AEC810
        public void AllocToTexelCoord(){} // RVA: 0x7FFAC9AEC820
        public void AllocToConstantBufferIndex(){} // RVA: 0x7FFAC9AEC8D0
        public void AtlasRectMatchesPage(){} // RVA: 0x7FFAC9AEC930
        public void get_transformConstants(){} // RVA: 0x7FFAC9AECA60
        public void get_clipRectConstants(){} // RVA: 0x7FFAC9AECB40
        public void get_atlas(){} // RVA: 0x7FFAC9AECC20
        public void Construct(){} // RVA: 0x7FFAC9AECCC0
        public void ReallyCreateStorage(){} // RVA: 0x7FFAC9AED170
        public void Dispose(){} // RVA: 0x7FFAC9AED980
        public void IssuePendingStorageChanges(){} // RVA: 0x7FFAC9AEDAE0
        public void AllocTransform(){} // RVA: 0x7FFAC9AEDB00
        public void AllocClipRect(){} // RVA: 0x7FFAC9AEDC50
        public void AllocOpacity(){} // RVA: 0x7FFAC9AEDDA0
        public void AllocColor(){} // RVA: 0x7FFAC9AEDE10
        public void AllocTextCoreSettings(){} // RVA: 0x7FFAC9AEDE80
        public void SetTransformValue(){} // RVA: 0x7FFAC9AEDEF0
        public void SetClipRectValue(){} // RVA: 0x7FFAC9AEE2C0
        public void SetOpacityValue(){} // RVA: 0x7FFAC9AEE480
        public void SetColorValue(){} // RVA: 0x7FFAC9AEE5C0
        public void SetTextCoreSettingValue(){} // RVA: 0x7FFAC9AEE740
        public void FreeTransform(){} // RVA: 0x7FFAC9AEEAD0
        public void FreeClipRect(){} // RVA: 0x7FFAC9AEEB70
        public void FreeOpacity(){} // RVA: 0x7FFAC9AEEC10
        public void FreeColor(){} // RVA: 0x7FFAC9AEECB0
        public void FreeTextCoreSettings(){} // RVA: 0x7FFAC9AEED50
        public void TransformAllocToVertexData(){} // RVA: 0x7FFAC9AEEE00
        public void ClipRectAllocToVertexData(){} // RVA: 0x7FFAC9AEEF50
        public void OpacityAllocToVertexData(){} // RVA: 0x7FFAC9AEF0A0
        public void ColorAllocToVertexData(){} // RVA: 0x7FFAC9AEF1E0
        public void TextCoreSettingsToVertexData(){} // RVA: 0x7FFAC9AEF320
        public void .cctor(){} // RVA: 0x7FFAC9AEF460
    }

    public class UIRenderDevice : Object
    {
        public bool maxVerticesPerPage; // 0x10
        public UIntPtr breakBatches; // 0x18
        public UIntPtr defaultShaderInfoTexFloat; // 0x20
        public UnityEngine.UIElements.UIR.Page defaultShaderInfoTexARGB8; // 0x28
        public uint vertexTexturingIsAvailable; // 0x30
        public uint shaderModelIs35; // 0x34
        public float fullyCreated; // 0x38
        public System.Collections.Generic.List`1<System.Collections.Generic.List`1<AllocToFree>> disposed; // 0x40
        public System.Collections.Generic.List`1<System.Collections.Generic.List`1<AllocToUpdate>> m_Updates; // 0x48
        public uint[] m_Fences; // 0x50
        public UnityEngine.MaterialPropertyBlock m_StandardMatProps; // 0x58
        public uint m_FrameIndex; // 0x60
        public uint m_NextUpdateID; // 0x64
        public DrawStatistics m_DrawStats; // 0x68
        public UnityEngine.UIElements.UIR.LinkedPool`1<UnityEngine.UIElements.UIR.MeshHandle> m_MeshHandles; // 0x90
        public UnityEngine.UIElements.UIR.DrawParams m_DrawParams; // 0x98
        public UnityEngine.UIElements.UIR.TextureSlotManager m_TextureSlotManager; // 0xA0
        public System.Collections.Generic.LinkedList`1<DeviceToFree> m_DeviceFreeQueue;
        public int m_ActiveDeviceCount; // 0x8
        public bool m_SubscribedToNotifications; // 0xC
        public bool m_SynchronousFree; // 0xD
        public int s_GradientSettingsTexID; // 0x10
        public int s_ShaderInfoTexID; // 0x14
        public int s_TransformsPropID; // 0x18
        public int s_ClipRectsPropID; // 0x1C
        public Unity.Profiling.ProfilerMarker s_MarkerAllocate; // 0x20
        public Unity.Profiling.ProfilerMarker s_MarkerFree; // 0x28
        public Unity.Profiling.ProfilerMarker s_MarkerAdvanceFrame; // 0x30
        public Unity.Profiling.ProfilerMarker s_MarkerFence; // 0x38
        public Unity.Profiling.ProfilerMarker s_MarkerBeforeDraw; // 0x40
        public System.Nullable`1<bool> s_VertexTexturingIsAvailable; // 0x48
        public System.Nullable`1<bool> s_ShaderModelIs35; // 0x4A
        public uint <maxVerticesPerPage>k__BackingField; // 0xA8
        public bool <breakBatches>k__BackingField; // 0xAC
        public UnityEngine.Texture2D s_DefaultShaderInfoTexFloat; // 0x50
        public UnityEngine.Texture2D s_DefaultShaderInfoTexARGB8; // 0x58
        public bool <disposed>k__BackingField; // 0xAD

        // ── Methods ──
        public void get_maxVerticesPerPage(){} // RVA: 0x7FFAC39055C0
        public void get_breakBatches(){} // RVA: 0x7FFAC9ACD620
        public void set_breakBatches(){} // RVA: 0x7FFAC9ACD630
        public void .cctor(){} // RVA: 0x7FFAC9ACD640
        public void .ctor(){} // RVA: 0x7FFAC9ACDE50 | overloaded x2
        public void get_defaultShaderInfoTexFloat(){} // RVA: 0x7FFAC9ACE940
        public void get_defaultShaderInfoTexARGB8(){} // RVA: 0x7FFAC9ACF080
        public void get_vertexTexturingIsAvailable(){} // RVA: 0x7FFAC9ACF5C0
        public void get_shaderModelIs35(){} // RVA: 0x7FFAC9ACF890
        public void InitVertexDeclaration(){} // RVA: 0x7FFAC9ACFB60
        public void CompleteCreation(){} // RVA: 0x7FFAC9ACFD10
        public void get_fullyCreated(){} // RVA: 0x7FFAC9ACFFA0
        public void get_disposed(){} // RVA: 0x7FFAC9ACFFB0
        public void set_disposed(){} // RVA: 0x7FFAC9ACFFC0
        public void Dispose(){} // RVA: 0x7FFAC9AD0040 | overloaded x2
        public void Allocate(){} // RVA: 0x7FFAC9AD0DD0 | overloaded x2
        public void Update(){} // RVA: 0x7FFAC9AD05A0 | overloaded x2
        public void UpdateCopyBackIndices(){} // RVA: 0x7FFAC9AD0950
        public void ActiveUpdatesForMeshHandle(){} // RVA: 0x7FFAC9AD0B00
        public void TryAllocFromPage(){} // RVA: 0x7FFAC9AD0BA0
        public void UpdateAfterGPUUsedData(){} // RVA: 0x7FFAC9AD1810
        public void Free(){} // RVA: 0x7FFAC9AD2310
        public void OnFrameRenderingBegin(){} // RVA: 0x7FFAC9AD2EE0
        public void PtrToSlice(){} // RVA: 0x7FFAC2E8DC40
        public void ApplyDrawCommandState(){} // RVA: 0x7FFAC9AD2F90
        public void ApplyBatchState(){} // RVA: 0x7FFAC9AD31A0
        public void EvaluateChain(){} // RVA: 0x7FFAC9AD33C0
        public void UpdateFenceValue(){} // RVA: 0x7FFAC9AD44E0
        public void KickRanges(){} // RVA: 0x7FFAC9AD45D0
        public void DrawRanges(){} // RVA: 0x7FFAC2E8DC40
        public void WaitOnCpuFence(){} // RVA: 0x7FFAC9AD48A0
        public void AdvanceFrame(){} // RVA: 0x7FFAC9AD4990
        public void PruneUnusedPages(){} // RVA: 0x7FFAC9AD58B0
        public void PrepareForGfxDeviceRecreate(){} // RVA: 0x7FFAC9AD5B30
        public void WrapUpGfxDeviceRecreate(){} // RVA: 0x7FFAC9AD5E90
        public void FlushAllPendingDeviceDisposes(){} // RVA: 0x7FFAC9AD5EF0
        public void GatherDrawStatistics(){} // RVA: 0x7FFAC9AD5FA0
        public void ProcessDeviceFreeQueue(){} // RVA: 0x7FFAC9AD5FC0
        public void OnEngineUpdateGlobal(){} // RVA: 0x7FFAC9AD65D0
        public void OnFlushPendingResources(){} // RVA: 0x7FFAC9AD6620
    }

    public class Utility : Object
    {
        public System.Action`1<bool> GraphicsResourcesRecreate;
        public System.Action EngineUpdate; // 0x8
        public System.Action FlushPendingResources; // 0x10
        public System.Action`1<UnityEngine.Camera> RegisterIntermediateRenderers; // 0x18
        public System.Action`1<UIntPtr> RenderNodeAdd; // 0x20
        public System.Action`1<UIntPtr> RenderNodeExecute; // 0x28
        public System.Action`1<UIntPtr> RenderNodeCleanup; // 0x30
        public Unity.Profiling.ProfilerMarker s_MarkerRaiseEngineUpdate; // 0x38

        // ── Methods ──
        public void SetVectorArray(){} // RVA: 0x7FFAC9ACB0D0 | overloaded x2
        public void add_GraphicsResourcesRecreate(){} // RVA: 0x7FFAC9AC9E70
        public void remove_GraphicsResourcesRecreate(){} // RVA: 0x7FFAC9AC9FD0
        public void add_EngineUpdate(){} // RVA: 0x7FFAC9ACA130
        public void remove_EngineUpdate(){} // RVA: 0x7FFAC9ACA280
        public void add_FlushPendingResources(){} // RVA: 0x7FFAC9ACA3D0
        public void remove_FlushPendingResources(){} // RVA: 0x7FFAC9ACA520
        public void add_RegisterIntermediateRenderers(){} // RVA: 0x7FFAC9ACA670
        public void remove_RegisterIntermediateRenderers(){} // RVA: 0x7FFAC9ACA7D0
        public void add_RenderNodeExecute(){} // RVA: 0x7FFAC9ACA930
        public void remove_RenderNodeExecute(){} // RVA: 0x7FFAC9ACAA90
        public void RaiseGraphicsResourcesRecreate(){} // RVA: 0x7FFAC9ACABF0
        public void RaiseEngineUpdate(){} // RVA: 0x7FFAC9ACAC70
        public void RaiseFlushPendingResources(){} // RVA: 0x7FFAC9ACAD10
        public void RaiseRegisterIntermediateRenderers(){} // RVA: 0x7FFAC9ACAD80
        public void RaiseRenderNodeAdd(){} // RVA: 0x7FFAC9ACAE00
        public void RaiseRenderNodeExecute(){} // RVA: 0x7FFAC9ACAE80
        public void RaiseRenderNodeCleanup(){} // RVA: 0x7FFAC9ACAF00
        public void AllocateBuffer(){} // RVA: 0x7FFAC9ACAF80
        public void FreeBuffer(){} // RVA: 0x7FFAC9ACAFF0
        public void UpdateBufferRanges(){} // RVA: 0x7FFAC9ACB040
        public void GetVertexDeclaration(){} // RVA: 0x7FFAC9ACB150
        public void RegisterIntermediateRenderer(){} // RVA: 0x7FFAC9ACB1A0
        public void DrawRanges(){} // RVA: 0x7FFAC9ACB2C0
        public void SetPropertyBlock(){} // RVA: 0x7FFAC9ACB350
        public void SetScissorRect(){} // RVA: 0x7FFAC9ACB3A0
        public void DisableScissor(){} // RVA: 0x7FFAC9ACB430
        public void CreateStencilState(){} // RVA: 0x7FFAC9ACB480
        public void SetStencilState(){} // RVA: 0x7FFAC9ACB510
        public void HasMappedBufferRange(){} // RVA: 0x7FFAC9ACB570
        public void InsertCPUFence(){} // RVA: 0x7FFAC9ACB5C0
        public void CPUFencePassed(){} // RVA: 0x7FFAC9ACB610
        public void WaitForCPUFencePassed(){} // RVA: 0x7FFAC9ACB660
        public void SyncRenderThread(){} // RVA: 0x7FFAC9ACB6B0
        public void GetActiveViewport(){} // RVA: 0x7FFAC9ACB700
        public void ProfileDrawChainBegin(){} // RVA: 0x7FFAC9ACB790
        public void ProfileDrawChainEnd(){} // RVA: 0x7FFAC9ACB7E0
        public void NotifyOfUIREvents(){} // RVA: 0x7FFAC9ACB830
        public void GetUnityProjectionMatrix(){} // RVA: 0x7FFAC9ACB880
        public void .cctor(){} // RVA: 0x7FFAC9ACB920
        public void RegisterIntermediateRenderer_Injected(){} // RVA: 0x7FFAC9ACB9D0
        public void SetScissorRect_Injected(){} // RVA: 0x7FFAC9ACBA70
        public void CreateStencilState_Injected(){} // RVA: 0x7FFAC9ACBAC0
        public void GetActiveViewport_Injected(){} // RVA: 0x7FFAC9ACBB10
        public void GetUnityProjectionMatrix_Injected(){} // RVA: 0x7FFAC9ACBB60
    }

    public class VectorImageManager : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.VectorImageManager> atlas;
        public Unity.Profiling.ProfilerMarker disposed; // 0x8
        public Unity.Profiling.ProfilerMarker s_MarkerUnregister; // 0x10
        public UnityEngine.UIElements.AtlasBase m_Atlas; // 0x10
        public System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.VectorImage,UnityEngine.UIElements.UIR.VectorImageRenderInfo> m_Registered; // 0x18
        public UnityEngine.UIElements.UIR.VectorImageRenderInfoPool m_RenderInfoPool; // 0x20
        public UnityEngine.UIElements.UIR.GradientRemapPool m_GradientRemapPool; // 0x28
        public UnityEngine.UIElements.UIR.GradientSettingsAtlas m_GradientSettingsAtlas; // 0x30
        public bool m_LoggedExhaustedSettingsAtlas; // 0x38
        public bool <disposed>k__BackingField; // 0x39

        // ── Methods ──
        public void get_atlas(){} // RVA: 0x7FFAC9AEAAF0
        public void .ctor(){} // RVA: 0x7FFAC9AEAB10
        public void get_disposed(){} // RVA: 0x7FFAC33BCE50
        public void set_disposed(){} // RVA: 0x7FFAC33BD1D0
        public void Dispose(){} // RVA: 0x7FFAC9AEB050 | overloaded x2
        public void Commit(){} // RVA: 0x7FFAC9AEB1E0
        public void AddUser(){} // RVA: 0x7FFAC9AEB270
        public void Register(){} // RVA: 0x7FFAC9AEB3E0
        public void .cctor(){} // RVA: 0x7FFAC9AEB8C0
    }

    public class VectorImageRenderInfo : LinkedPoolItem`1
    {
        public int useCount; // 0x18
        public UnityEngine.UIElements.UIR.GradientRemap firstGradientRemap; // 0x20
        public UnityEngine.UIElements.UIR.Alloc gradientSettingsAlloc; // 0x28

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAC9AEA5C0
        public void .ctor(){} // RVA: 0x7FFAC9AEA620
    }

    public class VectorImageRenderInfoPool : LinkedPool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9AEA1C0
    }

}