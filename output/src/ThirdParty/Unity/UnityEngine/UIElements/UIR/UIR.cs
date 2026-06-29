// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.UIR
// Classes: 76
// Methods: 618

namespace ThirdParty.Unity.UnityEngine.UIElements.UIR
{
    public class Allocator2D : Object
    {
        public object m_MinSize;
        public object m_MaxSize;
        public object m_MaxAllocSize;
        public object m_RowHeightBias;
        public object m_Rows;
        public object m_Areas;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F3B4B0
        public void TryAllocate(){} // RVA: 0x7F3BA10
        public void Free(){} // RVA: 0x7F3BF90
        public void BuildAreas(){} // RVA: 0x7F3C250
        public void ComputeMaxAllocSize(){} // RVA: 0x7F3C3F0
        public void BuildRowArray(){} // RVA: 0x7F3C520
    }

    public class BMPAlloc : ValueType
    {
        public object Invalid;
        public object page;
        public object pageLine;
        public object bitIndex;
        public object ownedState;

        // ── Methods ──
        public void Equals(){} // RVA: 0x99E4B0
        public void IsValid(){} // RVA: 0x99E4D0
        public void ToString(){} // RVA: 0x99E4E0
        public void .cctor(){} // RVA: 0x7F7AFF0
    }

    public class BaseElementBuilder : Object
    {
        // ── Methods ──
        public void RequiresStencilMask(){} // RVA: 0x87D350
        public void Build(){} // RVA: 0x7F40750
        public void DrawVisualElementBackground(){} // RVA: 0x894320
        public void DrawVisualElementBorder(){} // RVA: 0x894320
        public void DrawVisualElementStencilMask(){} // RVA: 0x894320
        public void ScheduleMeshGenerationJobs(){} // RVA: 0x894320
        public void PushVisualElementClipping(){} // RVA: 0x7F40DC0
        public void PopVisualElementClipping(){} // RVA: 0x7F40F10
        public void InvokeGenerateVisualContent(){} // RVA: 0x7F41000
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseShaderInfoStorage : Object
    {
        public object s_TextureCounter;
        public object s_MarkerCopyTexture;
        public object s_MarkerGetTextureData;
        public object s_MarkerUpdateTexture;
        public object _disposed;

        // ── Methods ──
        public void get_texture(){} // RVA: 0x87C0A0
        public void AllocateRect(){} // RVA: 0x87E6B0
        public void SetTexel(){} // RVA: 0x896030
        public void UpdateTexture(){} // RVA: 0x894290
        public void get_disposed(){} // RVA: 0xC120A0
        public void set_disposed(){} // RVA: 0xC120B0
        public void Dispose(){} // RVA: 0x6719860
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x7F750A0
    }

    public class BasicNodePool`1 : LinkedPool`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x894350
        public void Create(){} // RVA: 0x87C0D0
        public void .ctor(){} // RVA: 0x894290
    }

    public class BasicNode`1 : LinkedPoolItem`1
    {
        public object next;
        public object data;

        // ── Methods ──
        public void InsertFirst(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0x894290
    }

    public class BasicNode`1 : LinkedPoolItem`1
    {
        public object next;
        public object data;

        // ── Methods ──
        public void InsertFirst(){} // RVA: 0x624C760
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BestFitAllocator : Object
    {
        public object _totalSize;
        public object m_FirstBlock;
        public object m_FirstAvailableBlock;
        public object m_BlockPool;
        public object m_HighWatermark;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F4C520
        public void get_totalSize(){} // RVA: 0xB8F8F0
        public void get_highWatermark(){} // RVA: 0x7F4C7A0
        public void Allocate(){} // RVA: 0x7F4C7B0
        public void Free(){} // RVA: 0x7F4CB60
        public void CoalesceBlockWithPrevious(){} // RVA: 0x7F4CFE0
        public void BestFitFindAvailableBlock(){} // RVA: 0x7F4D240
        public void SplitBlock(){} // RVA: 0x7F4D280
    }

    public class BitmapAllocator32 : ValueType
    {
        public object m_PageHeight;
        public object m_Pages;
        public object m_AllocMap;
        public object m_EntryWidth;
        public object m_EntryHeight;

        // ── Methods ──
        public void Construct(){} // RVA: 0x99E6A0
        public void ForceFirstAlloc(){} // RVA: 0x99E6B0
        public void Allocate(){} // RVA: 0x99E6C0
        public void Free(){} // RVA: 0x99E6D0
        public void get_entryWidth(){} // RVA: 0x53FA00
        public void get_entryHeight(){} // RVA: 0x959740
        public void GetAllocPageAtlasLocation(){} // RVA: 0x99E6E0
        public void CountTrailingZeroes(){} // RVA: 0x7F7BB20
    }

    public class CommandList : Object
    {
        public object m_Owner;
        public object m_VertexDecl;
        public object m_StencilState;
        public object constantProps;
        public object batchProps;
        public object handle;
        public object m_Commands;
        public object m_GpuTextureData;
        public object m_DrawRanges;
        public object _disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F3CAF0
        public void Reset(){} // RVA: 0x7F3CFC0
        public void Execute(){} // RVA: 0x7F3D130
        public void SetTexture(){} // RVA: 0x7F3D5B0
        public void ApplyBatchProps(){} // RVA: 0x7F3D700
        public void DrawRanges(){} // RVA: 0x7F3D7E0
        public void get_disposed(){} // RVA: 0xE3F480
        public void set_disposed(){} // RVA: 0x1546550
        public void Dispose(){} // RVA: 0x7F3DC70
    }

    public class CommandManipulator : Object
    {
        // ── Methods ──
        public void IsParentOrAncestorOf(){} // RVA: 0x7F3DE10
        public void ReplaceCommands(){} // RVA: 0x7F3DE60
        public void FindHeadCommandInsertionPoint(){} // RVA: 0x7F3E380
        public void FindTailCommandInsertionPoint(){} // RVA: 0x7F3E7B0
        public void RemoveChain(){} // RVA: 0x7F3EBD0
        public void ResetCommands(){} // RVA: 0x7F3EE20
        public void InjectCommandInBetween(){} // RVA: 0x7F3F590
        public void DisableElementRendering(){} // RVA: 0x7F3F950
        public void RemoveSingleCommand(){} // RVA: 0x7F3FC10
    }

    public class DefaultElementBuilder : BaseElementBuilder
    {
        public object m_RenderChain;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void RequiresStencilMask(){} // RVA: 0x7F41110
        public void DrawVisualElementBackground(){} // RVA: 0x7F41260
        public void DrawVisualElementBorder(){} // RVA: 0x7F42C00
        public void DrawVisualElementStencilMask(){} // RVA: 0x7F432E0
        public void GenerateStencilClipEntryForRoundedRectBackground(){} // RVA: 0x7F43390
        public void ScheduleMeshGenerationJobs(){} // RVA: 0x7F43A90
    }

    public class DetachedAllocator : Object
    {
        public object m_VertsPool;
        public object m_IndexPool;
        public object m_MeshWriteDataPool;
        public object m_MeshWriteDataCount;
        public object m_Disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F40380
        public void Dispose(){} // RVA: 0x7F406D0
    }

    public class DrawParams : Object
    {
        public object k_UnlimitedRect;
        public object k_FullNormalizedRect;
        public object view;
        public object scissor;
        public object renderTexture;
        public object defaultMaterial;

        // ── Methods ──
        public void Reset(){} // RVA: 0x7F4E1C0
        public void .ctor(){} // RVA: 0x7F4E3F0
        public void .cctor(){} // RVA: 0x7F4E840
    }

    public class Entry : Object
    {
        public object type;
        public object flags;
        public object vertices;
        public object indices;
        public object texture;
        public object textScale;
        public object fontSharpness;
        public object gradientsOwner;
        public object material;
        public object immediateCallback;
        public object nextSibling;
        public object firstChild;
        public object lastChild;

        // ── Methods ──
        public void Reset(){} // RVA: 0x7F561D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EntryPool : Object
    {
        public object k_StackSize;
        public object m_ThreadEntries;
        public object m_SharedPool;
        public object k_CreateAction;
        public object k_ResetAction;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F50960
        public void Get(){} // RVA: 0x7F50CE0
        public void ReturnAll(){} // RVA: 0x7F50F10
        public void .cctor(){} // RVA: 0x7F51010
    }

    public class EntryPreProcessor : Object
    {
        public object m_ChildrenIndex;
        public object m_Allocs;
        public object m_HeadAllocs;
        public object m_TailAllocs;
        public object m_FlattenedEntries;
        public object m_Pending;
        public object m_Mask;
        public object m_IsPushingMask;

        // ── Methods ──
        public void get_childrenIndex(){} // RVA: 0xB8F8F0
        public void get_headAllocs(){} // RVA: 0xB700F0
        public void get_tailAllocs(){} // RVA: 0xB70160
        public void get_flattenedEntries(){} // RVA: 0xD33E60
        public void PreProcess(){} // RVA: 0x7F51300
        public void ClearReferences(){} // RVA: 0x7F517E0
        public void DoEvaluate(){} // RVA: 0x7F51850
        public void Add(){} // RVA: 0x7F51BF0
        public void Flush(){} // RVA: 0x7F51D20
        public void .ctor(){} // RVA: 0x7F51DD0
    }

    public class EntryProcessor : Object
    {
        public object m_PreProcessor;
        public object m_RenderChain;
        public object m_CurrentElement;
        public object m_MaskDepth;
        public object m_MaskDepthPopped;
        public object m_MaskDepthPushed;
        public object m_StencilRef;
        public object m_StencilRefPopped;
        public object m_StencilRefPushed;
        public object m_ClipRectId;
        public object m_ClipRectIdPopped;
        public object m_ClipRectIdPushed;
        public object m_IsDrawingMask;
        public object m_MaskMeshes;
        public object m_VertexDataComputed;
        public object m_Transform;
        public object m_TransformData;
        public object m_OpacityData;
        public object m_TextCoreSettingsPage;
        public object m_Mesh;
        public object m_Verts;
        public object m_Indices;
        public object m_IndexOffset;
        public object m_AllocVertexCount;
        public object m_AllocIndex;
        public object m_VertsFilled;
        public object m_IndicesFilled;
        public object m_RenderType;
        public object m_RemapUVs;
        public object m_AtlasRect;
        public object m_GradientSettingIndexOffset;
        public object m_IsTail;
        public object m_FirstCommand;
        public object m_LastCommand;
        public object _firstHeadCommand;
        public object _lastHeadCommand;
        public object _firstTailCommand;
        public object _lastTailCommand;
        public object s_blitMaterial_LinearToGamma;
        public object s_blitMaterial_GammaToLinear;
        public object s_blitMaterial_NoChange;
        public object s_blitShader;

        // ── Methods ──
        public void get_firstHeadCommand(){} // RVA: 0xE3C930
        public void set_firstHeadCommand(){} // RVA: 0xE3D020
        public void get_lastHeadCommand(){} // RVA: 0x135EDB0
        public void set_lastHeadCommand(){} // RVA: 0x1658000
        public void get_firstTailCommand(){} // RVA: 0x135A170
        public void set_firstTailCommand(){} // RVA: 0x1365A40
        public void get_lastTailCommand(){} // RVA: 0xBAE8F0
        public void set_lastTailCommand(){} // RVA: 0xBAE900
        public void Init(){} // RVA: 0x7F52200
        public void ClearReferences(){} // RVA: 0x7F52640
        public void ProcessHead(){} // RVA: 0x7F529C0
        public void ProcessTail(){} // RVA: 0x7F52BB0
        public void ProcessRange(){} // RVA: 0x7F52E40
        public void ProcessMeshEntry(){} // RVA: 0x7F539D0
        public void DrawReverseMask(){} // RVA: 0x7F545B0
        public void CreateMeshDrawCommand(){} // RVA: 0x7F549B0
        public void AppendCommand(){} // RVA: 0x7F54C00
        public void ProcessFirstAlloc(){} // RVA: 0x7F54E00
        public void ProcessNextAlloc(){} // RVA: 0x7F54FD0
        public void UpdateOrAllocate(){} // RVA: 0x7F55700
        public void CreateBlitShader(){} // RVA: 0x7F55900
        public void GetBlitMaterial(){} // RVA: 0x7F55C30
        public void .ctor(){} // RVA: 0x7F56010
    }

    public class EntryRecorder : Object
    {
        public object m_EntryPool;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F56410
        public void DrawMesh(){} // RVA: 0x7F564C0
        public void DrawRasterText(){} // RVA: 0x7F56590
        public void DrawSdfText(){} // RVA: 0x7F56670
        public void DrawGradients(){} // RVA: 0x7F56750
        public void DrawImmediate(){} // RVA: 0x7F56820
        public void DrawChildren(){} // RVA: 0x7F568D0
        public void BeginStencilMask(){} // RVA: 0x7F56910
        public void EndStencilMask(){} // RVA: 0x7F56950
        public void PopStencilMask(){} // RVA: 0x7F56990
        public void PushClippingRect(){} // RVA: 0x7F569D0
        public void PopClippingRect(){} // RVA: 0x7F56A10
        public void PushScissors(){} // RVA: 0x7F56A50
        public void PopScissors(){} // RVA: 0x7F56A90
        public void PushGroupMatrix(){} // RVA: 0x7F56AD0
        public void PopGroupMatrix(){} // RVA: 0x7F56B10
        public void PushRenderTexture(){} // RVA: 0x7F56B50
        public void BlitAndPopRenderTexture(){} // RVA: 0x7F56B90
        public void PushDefaultMaterial(){} // RVA: 0x7F56BD0
        public void PopDefaultMaterial(){} // RVA: 0x7F56C70
        public void CutRenderChain(){} // RVA: 0x7F56CB0
        public void InsertPlaceholder(){} // RVA: 0x7F56CF0
        public void AppendMeshEntry(){} // RVA: 0x7F56D40
        public void Append(){} // RVA: 0x7F56F50
    }

    public class ExtraRenderChainVEData : LinkedPoolItem`1
    {
        public object extraMesh;

        // ── Methods ──
        public void Reset(){} // RVA: 0x7F6FD90
        public void .ctor(){} // RVA: 0x7F6FDF0
    }

    public class GCHandlePool : Object
    {
        public object m_Handles;
        public object m_UsedHandlesCount;
        public object k_AllocBatchSize;
        public object _disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F3AB90
        public void Get(){} // RVA: 0x7F3AC70
        public void GetIntPtr(){} // RVA: 0x7F3AE50
        public void ReturnAll(){} // RVA: 0x7F3AE60
        public void get_disposed(){} // RVA: 0xC38360
        public void set_disposed(){} // RVA: 0xC38370
        public void Dispose(){} // RVA: 0x7F3B210
    }

    public class GPUBufferAllocator : Object
    {
        public object m_Low;
        public object m_High;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F4D7A0
        public void Allocate(){} // RVA: 0x7F4D8E0
        public void Free(){} // RVA: 0x7F4DAF0
        public void get_isEmpty(){} // RVA: 0x7F4DB70
        public void HighLowCollide(){} // RVA: 0x7F4DBB0
    }

    public class GradientRemap : LinkedPoolItem`1
    {
        public object origIndex;
        public object destIndex;
        public object location;
        public object next;
        public object atlas;

        // ── Methods ──
        public void Reset(){} // RVA: 0x7F79E70
        public void .ctor(){} // RVA: 0x7F79EE0
    }

    public class GradientRemapPool : LinkedPool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F79A50
    }

    public class GradientSettingsAtlas : Object
    {
        public object s_MarkerWrite;
        public object s_MarkerCommit;
        public object m_Length;
        public object m_ElemWidth;
        public object m_Allocator;
        public object m_Atlas;
        public object m_RawAtlas;
        public object s_TextureCounter;
        public object _disposed;
        public object _mustCommit;

        // ── Methods ──
        public void get_length(){} // RVA: 0x7B51740
        public void get_disposed(){} // RVA: 0xD16660
        public void set_disposed(){} // RVA: 0xD14C10
        public void Dispose(){} // RVA: 0x7F571B0
        public void .ctor(){} // RVA: 0x7F57220
        public void Reset(){} // RVA: 0x7F57340
        public void get_atlas(){} // RVA: 0x7489A40
        public void Add(){} // RVA: 0x7F57450
        public void Write(){} // RVA: 0x7F57540
        public void get_MustCommit(){} // RVA: 0xD15320
        public void set_MustCommit(){} // RVA: 0xD14740
        public void Commit(){} // RVA: 0x7F57AA0
        public void PrepareAtlas(){} // RVA: 0x7F57B10
        public void .cctor(){} // RVA: 0x7F57DD0
    }

    public class IMeshGenerator
    {
        // ── Methods ──
        public void set_currentElement(){} // RVA: 0x894320
        public void get_textJobSystem(){} // RVA: 0x87C0A0
        public void DrawText(){} // RVA: 0x899870
        public void DrawRectangle(){} // RVA: 0x894320
        public void DrawBorder(){} // RVA: 0x894320
        public void DrawRectangleRepeat(){} // RVA: 0x895520
        public void ScheduleJobs(){} // RVA: 0x894320
    }

    public class ImplicitPool`1 : Object
    {
        public object m_StartCapacity;
        public object m_MaxCapacity;
        public object m_CreateAction;
        public object m_ResetAction;
        public object m_List;
        public object m_UsedCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x89DE00
        public void Get(){} // RVA: 0xA94080
        public void ReturnAll(){} // RVA: 0x894290
    }

    public class ImplicitPool`1 : Object
    {
        public object m_StartCapacity;
        public object m_MaxCapacity;
        public object m_CreateAction;
        public object m_ResetAction;
        public object m_List;
        public object m_UsedCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3FFF920
        public void Get(){} // RVA: 0x3FFFB30
        public void ReturnAll(){} // RVA: 0x3FFFD20
    }

    public class JobManager : Object
    {
        public object m_NudgeJobs;
        public object m_ConvertMeshJobs;
        public object m_CopyMeshJobs;
        public object m_JobMerger;
        public object _disposed;

        // ── Methods ──
        public void Add(){} // RVA: 0x7F58090
        public void CompleteNudgeJobs(){} // RVA: 0x7F580F0
        public void CompleteConvertMeshJobs(){} // RVA: 0x7F584A0
        public void CompleteCopyMeshJobs(){} // RVA: 0x7F58850
        public void get_disposed(){} // RVA: 0xB68DF0
        public void set_disposed(){} // RVA: 0xB68E00
        public void Dispose(){} // RVA: 0x7F58C60
        public void .ctor(){} // RVA: 0x7F58E50
    }

    public class JobMerger : Object
    {
        public object m_Jobs;
        public object m_JobCount;
        public object _disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F59100
        public void Add(){} // RVA: 0x7F59220
        public void MergeAndReset(){} // RVA: 0x7F59320
        public void get_disposed(){} // RVA: 0xB5E030
        public void set_disposed(){} // RVA: 0xD72F80
        public void Dispose(){} // RVA: 0x7F59500
    }

    public class JobProcessor : Object
    {
        // ── Methods ──
        public void ScheduleNudgeJobs(){} // RVA: 0x7F3A8C0
        public void ScheduleConvertMeshJobs(){} // RVA: 0x7F3A940
        public void ScheduleCopyMeshJobs(){} // RVA: 0x7F3A9C0
        public void ScheduleNudgeJobs_Injected(){} // RVA: 0x7F3AA40
        public void ScheduleConvertMeshJobs_Injected(){} // RVA: 0x7F3AAB0
        public void ScheduleCopyMeshJobs_Injected(){} // RVA: 0x7F3AB20
    }

    public class LinkedPoolItem`1 : Object
    {
        public object poolNext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
    }

    public class LinkedPoolItem`1 : Object
    {
        public object poolNext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LinkedPoolItem`1 : Object
    {
        public object poolNext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LinkedPoolItem`1 : Object
    {
        public object poolNext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LinkedPoolItem`1 : Object
    {
        public object poolNext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LinkedPoolItem`1 : Object
    {
        public object poolNext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LinkedPoolItem`1 : Object
    {
        public object poolNext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LinkedPoolItem`1 : Object
    {
        public object poolNext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LinkedPoolItem`1 : Object
    {
        public object poolNext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LinkedPoolItem`1 : Object
    {
        public object poolNext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LinkedPoolItem`1 : Object
    {
        public object poolNext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LinkedPool`1 : Object
    {
        public object m_CreateFunc;
        public object m_ResetAction;
        public object m_Limit;
        public object m_PoolFirst;
        public object _count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x895FE0
        public void get_Count(){} // RVA: 0x87C130
        public void set_Count(){} // RVA: 0x8944F0
        public void Clear(){} // RVA: 0x894290
        public void Get(){} // RVA: 0xA94080
        public void Return(){} // RVA: 0xA94080
    }

    public class LinkedPool`1 : Object
    {
        public object m_CreateFunc;
        public object m_ResetAction;
        public object m_Limit;
        public object m_PoolFirst;
        public object _count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4288260
        public void get_Count(){} // RVA: 0xB9E080
        public void set_Count(){} // RVA: 0xB9E090
        public void Clear(){} // RVA: 0x4288390
        public void Get(){} // RVA: 0x42883A0
        public void Return(){} // RVA: 0x4288450
    }

    public class LinkedPool`1 : Object
    {
        public object m_CreateFunc;
        public object m_ResetAction;
        public object m_Limit;
        public object m_PoolFirst;
        public object _count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4288260
        public void get_Count(){} // RVA: 0xB9E080
        public void set_Count(){} // RVA: 0xB9E090
        public void Clear(){} // RVA: 0x4288390
        public void Get(){} // RVA: 0x42883A0
        public void Return(){} // RVA: 0x4288450
    }

    public class LinkedPool`1 : Object
    {
        public object m_CreateFunc;
        public object m_ResetAction;
        public object m_Limit;
        public object m_PoolFirst;
        public object _count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4288260
        public void get_Count(){} // RVA: 0xB9E080
        public void set_Count(){} // RVA: 0xB9E090
        public void Clear(){} // RVA: 0x4288390
        public void Get(){} // RVA: 0x42883A0
        public void Return(){} // RVA: 0x4288450
    }

    public class LinkedPool`1 : Object
    {
        public object m_CreateFunc;
        public object m_ResetAction;
        public object m_Limit;
        public object m_PoolFirst;
        public object _count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4288260
        public void get_Count(){} // RVA: 0xB9E080
        public void set_Count(){} // RVA: 0xB9E090
        public void Clear(){} // RVA: 0x4288390
        public void Get(){} // RVA: 0x42883A0
        public void Return(){} // RVA: 0x4288450
    }

    public class MeshGenerationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DB94B0
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class MeshGenerationDeferrer : Object
    {
        public object m_Fork;
        public object m_WorkThenFork;
        public object m_Work;
        public object m_JobDependentFork;
        public object m_JobDependentWorkThenFork;
        public object m_JobDependentWork;
        public object m_Dependencies;
        public object m_DependencyMerger;
        public object _disposed;

        // ── Methods ──
        public void AddMeshGenerationJob(){} // RVA: 0x7F59560
        public void AddMeshGenerationCallback(){} // RVA: 0x7F595D0
        public void ProcessDeferredWork(){} // RVA: 0x7F59820
        public void Invoke(){} // RVA: 0x7F59BE0
        public void get_disposed(){} // RVA: 0xC00EC0
        public void set_disposed(){} // RVA: 0xC00ED0
        public void Dispose(){} // RVA: 0x7F59E00
        public void .ctor(){} // RVA: 0x7F59E90
    }

    public class MeshGenerator : Object
    {
        public object k_MarkerDrawRectangle;
        public object k_MarkerDrawBorder;
        public object k_MarkerDrawVectorImage;
        public object k_MarkerDrawRectangleRepeat;
        public object m_MeshGenerationContext;
        public object m_RepeatRectUVList;
        public object m_BackgroundRepeatInstanceList;
        public object m_GCHandlePool;
        public object m_JobParameters;
        public object _currentElement;
        public object _textJobSystem;
        public object m_TextInfo;
        public object m_Settings;
        public object m_VerticesArray;
        public object m_IndicesArray;
        public object m_Atlases;
        public object m_SdfScales;
        public object m_RenderModes;
        public object m_OnMeshGenerationDelegate;
        public object m_TesselationJobParameters;
        public object _disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F5A2E0
        public void set_currentElement(){} // RVA: 0xB6A8C0
        public void get_textJobSystem(){} // RVA: 0xBBF8F0
        public void set_textJobSystem(){} // RVA: 0xBBF900
        public void ConvertBorderRadiusPercentToPoints(){} // RVA: 0x7F5AC20
        public void GetVisualElementRadii(){} // RVA: 0x7F5AC80
        public void AdjustBackgroundSizeForBorders(){} // RVA: 0x7F5AF70
        public void DrawText(){} // RVA: 0x7F5B570
        public void ConvertTextVertexToUIRVertex(){} // RVA: 0x7F5B8A0
        public void MakeText(){} // RVA: 0x7F5B990
        public void DrawRectangle(){} // RVA: 0x7F5BB70
        public void DrawBorder(){} // RVA: 0x7F5C990
        public void DrawRectangleRepeat(){} // RVA: 0x7F5CC70
        public void DoDrawRectangleRepeat(){} // RVA: 0x7F5CCA0
        public void StampRectangleWithSubRect(){} // RVA: 0x7F5EC50
        public void AdjustSpriteWinding(){} // RVA: 0x7F5F590
        public void ScheduleJobs(){} // RVA: 0x7F5F900
        public void OnMeshGeneration(){} // RVA: 0x7F5FEB0
        public void get_disposed(){} // RVA: 0x11319D0
        public void set_disposed(){} // RVA: 0x112ECB0
        public void Dispose(){} // RVA: 0x7F600A0
        public void .cctor(){} // RVA: 0x7F601F0
    }

    public class MeshHandle : LinkedPoolItem`1
    {
        public object allocVerts;
        public object allocIndices;
        public object triangleCount;
        public object allocPage;
        public object allocTime;
        public object updateAllocID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F43C70
    }

    public class MeshWriteDataPool : ImplicitPool`1
    {
        public object k_CreateAction;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F677C0
        public void .cctor(){} // RVA: 0x7F67850
    }

    public class NativeList`1 : Object
    {
        public object m_NativeArray;
        public object m_Count;
        public object _disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8944F0
        public void Expand(){} // RVA: 0x8944F0
        public void Add(){} // RVA: 0xA94080
        public void Clear(){} // RVA: 0x894290
        public void GetSlice(){} // RVA: 0xA94080
        public void get_Count(){} // RVA: 0x87C130
        public void get_disposed(){} // RVA: 0x87D280
        public void set_disposed(){} // RVA: 0x894750
        public void Dispose(){} // RVA: 0x894750
    }

    public class NativePagedList`1 : Object
    {
        public object k_PoolCapacity;
        public object m_Pages;
        public object m_LastPage;
        public object m_CountInLastPage;
        public object m_FirstPageAllocator;
        public object m_OtherPagesAllocator;
        public object m_Enumerator;
        public object _disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x896900
        public void Add(){} // RVA: 0xA94080
        public void GetPages(){} // RVA: 0x87C0A0
        public void GetCount(){} // RVA: 0x87C130
        public void Reset(){} // RVA: 0x894290
        public void get_disposed(){} // RVA: 0x87D280
        public void set_disposed(){} // RVA: 0x894750
        public void Dispose(){} // RVA: 0x894750
    }

    public class OpacityIdAccelerator : Object
    {
        public object m_Jobs;
        public object m_NextJobIndex;
        public object _disposed;

        // ── Methods ──
        public void CreateJob(){} // RVA: 0x7F67110
        public void CompleteJobs(){} // RVA: 0x7F67310
        public void get_disposed(){} // RVA: 0xB5E030
        public void set_disposed(){} // RVA: 0xD72F80
        public void Dispose(){} // RVA: 0x7F67560
        public void .ctor(){} // RVA: 0x7F675C0
    }

    public class Page : Object
    {
        public object _disposed;
        public object vertices;
        public object indices;
        public object next;
        public object framesEmpty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F4DBE0
        public void get_disposed(){} // RVA: 0xC120A0
        public void set_disposed(){} // RVA: 0xC120B0
        public void Dispose(){} // RVA: 0x7F4DE40
        public void get_isEmpty(){} // RVA: 0x7F4E140
    }

    public class RenderChain : Object
    {
        public object m_FirstCommand;
        public object m_DirtyTracker;
        public object m_VisualChangesProcessor;
        public object m_CommandPool;
        public object m_ExtraDataPool;
        public object m_MeshHandleNodePool;
        public object m_TexturePool;
        public object m_ExtraData;
        public object m_MeshGenerationDeferrer;
        public object m_DefaultMat;
        public object m_BlockDirtyRegistration;
        public object m_Stats;
        public object m_StatsElementsAdded;
        public object m_StatsElementsRemoved;
        public object m_TextureRegistry;
        public object _opacityIdAccelerator;
        public object s_SharedEntryPool;
        public object k_MarkerProcess;
        public object k_MarkerClipProcessing;
        public object k_MarkerOpacityProcessing;
        public object k_MarkerColorsProcessing;
        public object k_MarkerTransformProcessing;
        public object k_MarkerVisualsProcessing;
        public object k_MarkerSerialize;
        public object _disposed;
        public object _panel;
        public object _device;
        public object _atlas;
        public object _vectorImageManager;
        public object _tempMeshAllocator;
        public object _meshWriteDataPool;
        public object entryRecorder;
        public object _meshGenerationNodeManager;
        public object _jobManager;
        public object shaderInfoAllocator;
        public object _drawStats;
        public object _drawInCameras;
        public object _isFlat;
        public object _forceGammaRendering;

        // ── Methods ──
        public void get_opacityIdAccelerator(){} // RVA: 0xBAE5A0
        public void set_opacityIdAccelerator(){} // RVA: 0xBAE5B0
        public void .ctor(){} // RVA: 0x7F67BA0
        public void get_disposed(){} // RVA: 0x1AE5AD0
        public void set_disposed(){} // RVA: 0x1AE3600
        public void Dispose(){} // RVA: 0x7F69240
        public void get_statsByRef(){} // RVA: 0x7F69B20
        public void ProcessChanges(){} // RVA: 0x7F69B30
        public void SerializeCommandsForCameras(){} // RVA: 0x7F6A630
        public void Render(){} // RVA: 0x7F6AA90
        public void UIEOnChildAdded(){} // RVA: 0x7F6B0D0
        public void UIEOnChildrenReordered(){} // RVA: 0x7F6B440
        public void UIEOnChildRemoving(){} // RVA: 0x7F6B860
        public void UIEOnRenderHintsChanged(){} // RVA: 0x7F6B970
        public void UIEOnClippingChanged(){} // RVA: 0x7F6BA40
        public void UIEOnOpacityChanged(){} // RVA: 0x7F6BAE0
        public void UIEOnColorChanged(){} // RVA: 0x7F6BB80
        public void UIEOnTransformOrSizeChanged(){} // RVA: 0x7F6BC20
        public void UIEOnVisualsChanged(){} // RVA: 0x7F6BCD0
        public void UIEOnOpacityIdChanged(){} // RVA: 0x7F6BD70
        public void UIEOnDisableRenderingChanged(){} // RVA: 0x7F6BE10
        public void get_panel(){} // RVA: 0x10B4170
        public void set_panel(){} // RVA: 0x15B42C0
        public void get_device(){} // RVA: 0x10B9D50
        public void set_device(){} // RVA: 0x15B7570
        public void get_elementBuilder(){} // RVA: 0x11DD700
        public void get_atlas(){} // RVA: 0xD9E3D0
        public void set_atlas(){} // RVA: 0xD9D290
        public void get_vectorImageManager(){} // RVA: 0xDA0520
        public void set_vectorImageManager(){} // RVA: 0xD9D570
        public void get_tempMeshAllocator(){} // RVA: 0x114AC20
        public void set_tempMeshAllocator(){} // RVA: 0x1149C90
        public void get_meshWriteDataPool(){} // RVA: 0xE3C930
        public void get_entryPool(){} // RVA: 0x7F6BEA0
        public void get_meshGenerationDeferrer(){} // RVA: 0xC10050
        public void get_meshGenerationNodeManager(){} // RVA: 0x135A170
        public void set_meshGenerationNodeManager(){} // RVA: 0x1365A40
        public void get_jobManager(){} // RVA: 0xBAE8F0
        public void set_jobManager(){} // RVA: 0xBAE900
        public void get_drawStats(){} // RVA: 0x7F6BF00
        public void set_drawStats(){} // RVA: 0x7F6BF10
        public void get_drawInCameras(){} // RVA: 0x7F6BF20
        public void get_isFlat(){} // RVA: 0x7F6BF30
        public void get_forceGammaRendering(){} // RVA: 0x7F6BF40
        public void EnsureFitsDepth(){} // RVA: 0x7F6BF50
        public void ChildWillBeRemoved(){} // RVA: 0x7F6BF60
        public void AllocCommand(){} // RVA: 0x7F6C020
        public void FreeCommand(){} // RVA: 0x7F6C070
        public void OnRenderCommandAdded(){} // RVA: 0x7F6C0E0
        public void OnRenderCommandsRemoved(){} // RVA: 0x7F6C150
        public void RepaintTexturedElements(){} // RVA: 0x7F6C1C0
        public void GetOrAddExtraData(){} // RVA: 0x7F6C310
        public void FreeExtraData(){} // RVA: 0x7F6C410
        public void InsertExtraMesh(){} // RVA: 0x7F6C5E0
        public void FreeExtraMeshes(){} // RVA: 0x7F6C800
        public void InsertTexture(){} // RVA: 0x7F6CA20
        public void ResetTextures(){} // RVA: 0x7F6CC40
        public void DrawStats(){} // RVA: 0x7F6CDC0
        public void GetFirstElementInPanel(){} // RVA: 0x7F6D930
        public void .cctor(){} // RVA: 0x7F6D960
    }

    public class RenderChainCommand : LinkedPoolItem`1
    {
        public object owner;
        public object prev;
        public object next;
        public object isTail;
        public object type;
        public object state;
        public object mesh;
        public object indexOffset;
        public object indexCount;
        public object callback;
        public object k_ID_MainTex;
        public object s_ImmediateOverheadMarker;

        // ── Methods ──
        public void Reset(){} // RVA: 0x7F4E8A0
        public void ExecuteNonDrawMesh(){} // RVA: 0x7F4EA50
        public void Blit(){} // RVA: 0x7F4FC90
        public void PushScissor(){} // RVA: 0x7F50090
        public void PopScissor(){} // RVA: 0x7F502E0
        public void CombineScissorRects(){} // RVA: 0x7F505D0
        public void RectPointsToPixelsAndFlipYAxis(){} // RVA: 0x7F50740
        public void .ctor(){} // RVA: 0x7F50890
        public void .cctor(){} // RVA: 0x7F508C0
    }

    public class RenderChainVEData : ValueType
    {
        public object prev;
        public object next;
        public object groupTransformAncestor;
        public object boneTransformAncestor;
        public object prevDirty;
        public object nextDirty;
        public object flags;
        public object hierarchyDepth;
        public object dirtiedValues;
        public object dirtyID;
        public object firstHeadCommand;
        public object lastHeadCommand;
        public object firstTailCommand;
        public object lastTailCommand;
        public object localFlipsWinding;
        public object localTransformScaleZero;
        public object worldFlipsWinding;
        public object worldTransformScaleZero;
        public object clipMethod;
        public object childrenStencilRef;
        public object childrenMaskDepth;
        public object headMesh;
        public object tailMesh;
        public object verticesSpace;
        public object transformID;
        public object clipRectID;
        public object opacityID;
        public object textCoreSettingsID;
        public object colorID;
        public object backgroundColorID;
        public object borderLeftColorID;
        public object borderTopColorID;
        public object borderRightColorID;
        public object borderBottomColorID;
        public object tintColorID;
        public object compositeOpacity;
        public object backgroundAlpha;
        public object textures;
        public object pendingRepaint;
        public object pendingHierarchicalRepaint;

        // ── Methods ──
        public void get_lastTailOrHeadCommand(){} // RVA: 0x99E050
        public void AllocatesID(){} // RVA: 0x7F6FC90
        public void InheritsID(){} // RVA: 0x7F6FCF0
        public void get_isInChain(){} // RVA: 0x99E060
        public void get_isGroupTransform(){} // RVA: 0x99E070
        public void get_isIgnoringDynamicColorHint(){} // RVA: 0x99E080
        public void get_hasExtraData(){} // RVA: 0x99E090
        public void get_hasExtraMeshes(){} // RVA: 0x99E0A0
    }

    public class RenderEvents : Object
    {
        public object k_NudgeVerticesMarker;
        public object VisibilityTreshold;

        // ── Methods ──
        public void ProcessOnClippingChanged(){} // RVA: 0x7F6FE20
        public void ProcessOnOpacityChanged(){} // RVA: 0x7F6FF40
        public void ProcessOnColorChanged(){} // RVA: 0x7F70040
        public void ProcessOnTransformOrSizeChanged(){} // RVA: 0x7F700D0
        public void GetTransformIDTransformInfo(){} // RVA: 0x7F701B0
        public void GetClipRectIDClipInfo(){} // RVA: 0x7F70390
        public void DepthFirstOnChildAdded(){} // RVA: 0x7F70620
        public void DepthFirstOnChildRemoving(){} // RVA: 0x7F71210
        public void DepthFirstOnClippingChanged(){} // RVA: 0x7F72040
        public void DepthFirstOnOpacityChanged(){} // RVA: 0x7F727F0
        public void OnColorChanged(){} // RVA: 0x7F72D30
        public void DepthFirstOnTransformOrSizeChanged(){} // RVA: 0x7F72F20
        public void UpdateTextCoreSettings(){} // RVA: 0x7F735A0
        public void NudgeVerticesToNewSpace(){} // RVA: 0x7F73980
        public void PrepareNudgeVertices(){} // RVA: 0x7F740A0
        public void GetLastDeepestChild(){} // RVA: 0x7F741D0
        public void DetermineSelfClipMethod(){} // RVA: 0x7F74310
        public void UpdateLocalFlipsWinding(){} // RVA: 0x7F74430
        public void UpdateZeroScaling(){} // RVA: 0x7F74540
        public void NeedsTransformID(){} // RVA: 0x7F74650
        public void NeedsColorID(){} // RVA: 0x7F74680
        public void NeedsTextCoreSettings(){} // RVA: 0x7F746A0
        public void InitColorIDs(){} // RVA: 0x7F74790
        public void SetColorValues(){} // RVA: 0x7F74BD0
        public void .cctor(){} // RVA: 0x7F74FB0
    }

    public class ShaderInfoStorageRGBAFloat : ShaderInfoStorage`1
    {
        public object s_Convert;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F75190
        public void .cctor(){} // RVA: 0x7F75360
    }

    public class ShaderInfoStorage`1 : BaseShaderInfoStorage
    {
        public object m_InitialSize;
        public object m_MaxSize;
        public object m_Format;
        public object m_Convert;
        public object m_Allocator;
        public object m_Texture;
        public object m_Texels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x897700
        public void Dispose(){} // RVA: 0x894750
        public void get_texture(){} // RVA: 0x87C0A0
        public void AllocateRect(){} // RVA: 0x87E6B0
        public void SetTexel(){} // RVA: 0x896030
        public void UpdateTexture(){} // RVA: 0x894290
        public void CreateOrExpandTexture(){} // RVA: 0x894290
        public void CpuBlit(){} // RVA: 0xA94080
    }

    public class ShaderInfoStorage`1 : BaseShaderInfoStorage
    {
        public object m_InitialSize;
        public object m_MaxSize;
        public object m_Format;
        public object m_Convert;
        public object m_Allocator;
        public object m_Texture;
        public object m_Texels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4AC0150
        public void Dispose(){} // RVA: 0x4AC02D0
        public void get_texture(){} // RVA: 0xD05CA0
        public void AllocateRect(){} // RVA: 0x4AC0430
        public void SetTexel(){} // RVA: 0x4AC05D0
        public void UpdateTexture(){} // RVA: 0x4AC06D0
        public void CreateOrExpandTexture(){} // RVA: 0x4AC07F0
        public void CpuBlit(){} // RVA: 0x4AC0D70
    }

    public class Shaders : Object
    {
        public object k_AtlasBlit;
        public object k_Editor;
        public object k_Runtime;
        public object k_RuntimeWorld;
        public object k_ColorConversionBlit;
        public object k_ForceGammaKeyword;
        public object s_RuntimeMaterial;
        public object s_RuntimeWorldMaterial;
        public object s_EditorMaterial;
        public object s_RefCount;

        // ── Methods ──
        public void get_runtimeMaterial(){} // RVA: 0x7F755D0
        public void get_runtimeWorldMaterial(){} // RVA: 0x7F75630
        public void get_editorMaterial(){} // RVA: 0x7F75690
        public void GetOrCreateMaterial(){} // RVA: 0x7F756F0
        public void Acquire(){} // RVA: 0x7F75990
        public void Release(){} // RVA: 0x7F759F0
        public void .cctor(){} // RVA: 0x7F75CB0
    }

    public class TempAllocator`1 : Object
    {
        public object m_ExcessMinCapacity;
        public object m_ExcessMaxCapacity;
        public object m_Pool;
        public object m_Excess;
        public object m_NextExcessSize;
        public object _disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x896900
        public void get_disposed(){} // RVA: 0x87D280
        public void set_disposed(){} // RVA: 0x894750
        public void Dispose(){} // RVA: 0x894750
        public void Alloc(){} // RVA: 0xA94080
        public void DoAlloc(){} // RVA: 0xA94080
        public void Reset(){} // RVA: 0x894290
        public void ReleaseExcess(){} // RVA: 0x894290
    }

    public class TempMeshAllocatorImpl : Object
    {
        public object m_GCHandle;
        public object m_ThreadData;
        public object m_VertexPool;
        public object m_IndexPool;
        public object _disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F75FE0
        public void CreateNativeHandle(){} // RVA: 0x7F76420
        public void Allocate(){} // RVA: 0xA94080
        public void AllocateTempMesh(){} // RVA: 0x7F76430
        public void Clear(){} // RVA: 0x7F76710
        public void get_disposed(){} // RVA: 0xB68DF0
        public void set_disposed(){} // RVA: 0xB68E00
        public void Dispose(){} // RVA: 0x7F76A80
    }

    public class TextCoreSettings : ValueType
    {
        public object faceColor;
        public object outlineColor;
        public object outlineWidth;
        public object underlayColor;
        public object underlayOffset;
        public object underlaySoftness;

        // ── Methods ──
        public void Equals(){} // RVA: 0x99E2E0
        public void GetHashCode(){} // RVA: 0x99E320
    }

    public class TextureBlitter : Object
    {
        public object k_TextureIds;
        public object s_CommitSampler;
        public object m_SingleBlit;
        public object m_BlitMaterial;
        public object m_Properties;
        public object m_Viewport;
        public object m_PrevRT;
        public object m_PendingBlits;
        public object _disposed;

        // ── Methods ──
        public void get_disposed(){} // RVA: 0xBFDA40
        public void set_disposed(){} // RVA: 0xBFDA50
        public void Dispose(){} // RVA: 0x7F76EB0
        public void .cctor(){} // RVA: 0x7F76F70
        public void .ctor(){} // RVA: 0x7F77180
        public void QueueBlit(){} // RVA: 0x7F772D0
        public void BlitOneNow(){} // RVA: 0x7F77430
        public void Commit(){} // RVA: 0x7F775E0
        public void BeginBlit(){} // RVA: 0x7F776E0
        public void DoBlit(){} // RVA: 0x7F77B30
        public void EndBlit(){} // RVA: 0x7F78620
    }

    public class TextureSlotManager : Object
    {
        public object k_SlotCount;
        public object k_SlotSize;
        public object slotIds;
        public object textureTableId;
        public object m_Textures;
        public object m_Tickets;
        public object m_CurrentTicket;
        public object m_FirstUsedTicket;
        public object m_GpuTextures;
        public object _freeSlots;
        public object textureRegistry;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7F78700
        public void .ctor(){} // RVA: 0x7F78920
        public void Reset(){} // RVA: 0x7F78BD0
        public void StartNewBatch(){} // RVA: 0x7F78D40
        public void IndexOf(){} // RVA: 0x7F78DB0
        public void MarkUsed(){} // RVA: 0x7F4BCF0
        public void get_FreeSlots(){} // RVA: 0xB9E080
        public void set_FreeSlots(){} // RVA: 0xB9E090
        public void FindOldestSlot(){} // RVA: 0x7F78EA0
        public void Bind(){} // RVA: 0x7F78F70
        public void SetGpuData(){} // RVA: 0x7F793C0
    }

    public class UIRVEShaderInfoAllocator : Object
    {
        public object m_Storage;
        public object m_TransformAllocator;
        public object m_ClipRectAllocator;
        public object m_OpacityAllocator;
        public object m_ColorAllocator;
        public object m_TextSettingsAllocator;
        public object m_StorageReallyCreated;
        public object m_ColorSpace;
        public object identityTransformTexel;
        public object infiniteClipRectTexel;
        public object fullOpacityTexel;
        public object clearColorTexel;
        public object defaultTextCoreSettingsTexel;
        public object identityTransformValue;
        public object identityTransformRow0Value;
        public object identityTransformRow1Value;
        public object identityTransformRow2Value;
        public object infiniteClipRectValue;
        public object fullOpacityValue;
        public object clearColorValue;
        public object defaultTextCoreSettingsValue;
        public object identityTransform;
        public object infiniteClipRect;
        public object fullOpacity;
        public object clearColor;
        public object defaultTextCoreSettings;
        public object s_DefaultShaderInfoTextureRefCount;
        public object s_DefaultShaderInfoTexture;

        // ── Methods ──
        public void get_pageWidth(){} // RVA: 0x7F7BDB0
        public void get_pageHeight(){} // RVA: 0x7F7BDC0
        public void AcquireDefaultShaderInfoTexture(){} // RVA: 0x7F7BDD0
        public void ReleaseDefaultShaderInfoTexture(){} // RVA: 0x7F7C340
        public void AllocToTexelCoord(){} // RVA: 0x7F7C490
        public void AtlasRectMatchesPage(){} // RVA: 0x7F7C540
        public void get_atlas(){} // RVA: 0x7F7C670
        public void .ctor(){} // RVA: 0x7F7C700
        public void ReallyCreateStorage(){} // RVA: 0x7F7CA80
        public void Dispose(){} // RVA: 0x7F7D100
        public void IssuePendingStorageChanges(){} // RVA: 0x7F7D350
        public void AllocTransform(){} // RVA: 0x7F7D370
        public void AllocClipRect(){} // RVA: 0x7F7D3A0
        public void AllocOpacity(){} // RVA: 0x7F7D3D0
        public void AllocColor(){} // RVA: 0x7F7D400
        public void AllocTextCoreSettings(){} // RVA: 0x7F7D430
        public void SetTransformValue(){} // RVA: 0x7F7D470
        public void SetClipRectValue(){} // RVA: 0x7F7D6A0
        public void SetOpacityValue(){} // RVA: 0x7F7D7F0
        public void SetColorValue(){} // RVA: 0x7F7D930
        public void SetTextCoreSettingValue(){} // RVA: 0x7F7DAA0
        public void FreeTransform(){} // RVA: 0x7F7DDF0
        public void FreeClipRect(){} // RVA: 0x7F7DE90
        public void FreeOpacity(){} // RVA: 0x7F7DF30
        public void FreeColor(){} // RVA: 0x7F7DFD0
        public void FreeTextCoreSettings(){} // RVA: 0x7F7E070
        public void TransformAllocToVertexData(){} // RVA: 0x7F7E120
        public void ClipRectAllocToVertexData(){} // RVA: 0x7F7E260
        public void OpacityAllocToVertexData(){} // RVA: 0x7F7E3A0
        public void ColorAllocToVertexData(){} // RVA: 0x7F7E4E0
        public void TextCoreSettingsToVertexData(){} // RVA: 0x7F7E620
        public void .cctor(){} // RVA: 0x7F7E760
    }

    public class UIRenderDevice : Object
    {
        public object m_MockDevice;
        public object m_DefaultStencilState;
        public object m_VertexDecl;
        public object m_FirstPage;
        public object m_NextPageVertexCount;
        public object m_LargeMeshVertexCount;
        public object m_IndexToVertexCountRatio;
        public object m_DeferredFrees;
        public object m_Updates;
        public object m_CommandLists;
        public object m_Fences;
        public object m_ConstantProps;
        public object m_BatchProps;
        public object m_FrameIndex;
        public object m_NextUpdateID;
        public object m_DrawStats;
        public object m_MeshHandles;
        public object m_DrawParams;
        public object m_TextureSlotManager;
        public object m_DeviceFreeQueue;
        public object m_ActiveDeviceCount;
        public object m_SubscribedToNotifications;
        public object m_SynchronousFree;
        public object s_GradientSettingsTexID;
        public object s_ShaderInfoTexID;
        public object s_MarkerAllocate;
        public object s_MarkerFree;
        public object s_MarkerAdvanceFrame;
        public object s_MarkerFence;
        public object s_MarkerBeforeDraw;
        public object _breakBatches;
        public object _isFlat;
        public object _drawsInCameras;
        public object currentFrameCommandListCount;
        public object _disposed;

        // ── Methods ──
        public void get_maxVerticesPerPage(){} // RVA: 0x6824720
        public void get_breakBatches(){} // RVA: 0xB63970
        public void set_breakBatches(){} // RVA: 0xB63980
        public void get_isFlat(){} // RVA: 0x26449C0
        public void set_isFlat(){} // RVA: 0x2646670
        public void get_drawsInCameras(){} // RVA: 0x2646660
        public void set_drawsInCameras(){} // RVA: 0x2644F10
        public void get_frameIndex(){} // RVA: 0x19C6270
        public void get_commandLists(){} // RVA: 0xBE58B0
        public void get_currentFrameCommandLists(){} // RVA: 0x7F43CA0
        public void .cctor(){} // RVA: 0x7F43CF0
        public void .ctor(){} // RVA: 0x7F44280
        public void InitVertexDeclaration(){} // RVA: 0x7F44D70
        public void CompleteCreation(){} // RVA: 0x7F44FB0
        public void get_fullyCreated(){} // RVA: 0x7F45490
        public void get_disposed(){} // RVA: 0x1C11610
        public void set_disposed(){} // RVA: 0x1C10980
        public void Dispose(){} // RVA: 0x7F45510
        public void Allocate(){} // RVA: 0x7F46330
        public void Update(){} // RVA: 0x7F45B10
        public void UpdateCopyBackIndices(){} // RVA: 0x7F45EB0
        public void ActiveUpdatesForMeshHandle(){} // RVA: 0x7F46060
        public void TryAllocFromPage(){} // RVA: 0x7F46100
        public void UpdateAfterGPUUsedData(){} // RVA: 0x7F46DE0
        public void Free(){} // RVA: 0x7F47900
        public void OnFrameRenderingBegin(){} // RVA: 0x7F484E0
        public void PtrToSlice(){} // RVA: 0xA94080
        public void ApplyDrawCommandState(){} // RVA: 0x7F485B0
        public void ApplyBatchState(){} // RVA: 0x7F487C0
        public void EvaluateChain(){} // RVA: 0x7F48A80
        public void UpdateFenceValue(){} // RVA: 0x7F49DA0
        public void KickRanges(){} // RVA: 0x7F49E90
        public void DrawRanges(){} // RVA: 0x7F4A180
        public void WaitOnCpuFence(){} // RVA: 0x7F4A300
        public void AdvanceFrame(){} // RVA: 0x7F4A3F0
        public void PruneUnusedPages(){} // RVA: 0x7F4B330
        public void PrepareForGfxDeviceRecreate(){} // RVA: 0x7F4B5B0
        public void WrapUpGfxDeviceRecreate(){} // RVA: 0x7F4B610
        public void FlushAllPendingDeviceDisposes(){} // RVA: 0x7F4B670
        public void GatherDrawStatistics(){} // RVA: 0xC100C0
        public void ProcessDeviceFreeQueue(){} // RVA: 0x7F4B720
        public void OnEngineUpdateGlobal(){} // RVA: 0x7F4BAC0
        public void OnFlushPendingResources(){} // RVA: 0x7F4BB10
    }

    public class Utility : Object
    {
        public object GraphicsResourcesRecreate;
        public object EngineUpdate;
        public object FlushPendingResources;
        public object s_MarkerRaiseEngineUpdate;

        // ── Methods ──
        public void add_GraphicsResourcesRecreate(){} // RVA: 0x7F393F0
        public void remove_GraphicsResourcesRecreate(){} // RVA: 0x7F39550
        public void add_EngineUpdate(){} // RVA: 0x7F396B0
        public void remove_EngineUpdate(){} // RVA: 0x7F39800
        public void add_FlushPendingResources(){} // RVA: 0x7F39950
        public void remove_FlushPendingResources(){} // RVA: 0x7F39AA0
        public void RaiseGraphicsResourcesRecreate(){} // RVA: 0x7F39BF0
        public void RaiseEngineUpdate(){} // RVA: 0x7F39C70
        public void RaiseFlushPendingResources(){} // RVA: 0x7F39D10
        public void AllocateBuffer(){} // RVA: 0x7F39D80
        public void FreeBuffer(){} // RVA: 0x7F39DF0
        public void UpdateBufferRanges(){} // RVA: 0x7F39E40
        public void GetVertexDeclaration(){} // RVA: 0x7F39ED0
        public void DrawRanges(){} // RVA: 0x7F39FD0
        public void SetPropertyBlock(){} // RVA: 0x7F3A060
        public void SetScissorRect(){} // RVA: 0x7F3A0F0
        public void DisableScissor(){} // RVA: 0x7F3A180
        public void CreateStencilState(){} // RVA: 0x7F3A1D0
        public void SetStencilState(){} // RVA: 0x7F3A260
        public void HasMappedBufferRange(){} // RVA: 0x7F3A2C0
        public void InsertCPUFence(){} // RVA: 0x7F3A310
        public void CPUFencePassed(){} // RVA: 0x7F3A360
        public void WaitForCPUFencePassed(){} // RVA: 0x7F3A3B0
        public void SyncRenderThread(){} // RVA: 0x7F3A400
        public void GetActiveViewport(){} // RVA: 0x7F3A450
        public void ProfileDrawChainBegin(){} // RVA: 0x7F3A4E0
        public void ProfileDrawChainEnd(){} // RVA: 0x7F3A530
        public void NotifyOfUIREvents(){} // RVA: 0x7F3A580
        public void GetUnityProjectionMatrix(){} // RVA: 0x7F3A5D0
        public void .cctor(){} // RVA: 0x7F3A670
        public void GetVertexDeclaration_Injected(){} // RVA: 0x7F3A6E0
        public void SetPropertyBlock_Injected(){} // RVA: 0x7F3A730
        public void SetScissorRect_Injected(){} // RVA: 0x7F3A780
        public void CreateStencilState_Injected(){} // RVA: 0x7F3A7D0
        public void GetActiveViewport_Injected(){} // RVA: 0x7F3A820
        public void GetUnityProjectionMatrix_Injected(){} // RVA: 0x7F3A870
    }

    public class Utility[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class VectorImageManager : Object
    {
        public object instances;
        public object s_MarkerRegister;
        public object s_MarkerUnregister;
        public object m_Atlas;
        public object m_Registered;
        public object m_RenderInfoPool;
        public object m_GradientRemapPool;
        public object m_GradientSettingsAtlas;
        public object m_LoggedExhaustedSettingsAtlas;
        public object _disposed;

        // ── Methods ──
        public void get_atlas(){} // RVA: 0x7F79F10
        public void .ctor(){} // RVA: 0x7F79F30
        public void get_disposed(){} // RVA: 0xD15320
        public void set_disposed(){} // RVA: 0xD14740
        public void Dispose(){} // RVA: 0x7F7A470
        public void Commit(){} // RVA: 0x7F7A600
        public void AddUser(){} // RVA: 0x7F7A690
        public void Register(){} // RVA: 0x7F7A800
        public void .cctor(){} // RVA: 0x7F7ACF0
    }

    public class VectorImageRenderInfo : LinkedPoolItem`1
    {
        public object useCount;
        public object firstGradientRemap;
        public object gradientSettingsAlloc;

        // ── Methods ──
        public void Reset(){} // RVA: 0x7F799C0
        public void .ctor(){} // RVA: 0x7F79A20
    }

    public class VectorImageRenderInfoPool : LinkedPool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7F795A0
    }

}