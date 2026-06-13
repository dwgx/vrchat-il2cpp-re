// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.UIR
// Classes: 67
// Methods: 432

namespace ThirdParty.Unity.UnityEngine.UIElements.UIR
{
    public class Alloc
    {
    }

    public class Allocator2D
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x73345A0
        public void TryAllocate(){} // RVA: 0x7334B00
        public void Free(){} // RVA: 0x7335080
        public void BuildAreas(){} // RVA: 0x7335340
        public void ComputeMaxAllocSize(){} // RVA: 0x73354E0
        public void BuildRowArray(){} // RVA: 0x7335610
    }

    public class BMPAlloc
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7354220
        public void IsValid(){} // RVA: 0x7354240
        public void ToString(){} // RVA: 0x7354250
        public void .cctor(){} // RVA: 0x7354380
    }

    public class BaseShaderInfoStorage
    {
        public int s_TextureCounter;
        public Unity.Profiling.ProfilerMarker s_MarkerCopyTexture; // 0x8

        // ── Methods ──
        public void get_texture(){} // RVA: 0xCD60
        public void AllocateRect(){}
        public void SetTexel(){}
        public void UpdateTexture(){} // RVA: 0x24A50
        public void get_disposed(){} // RVA: 0x3A75E0
        public void set_disposed(){} // RVA: 0x3A75F0
        public void Dispose(){} // RVA: 0x5CA0CB0 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x734EFC0
    }

    public class BasicNodePool`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x24AE0
        public void Create(){} // RVA: 0xC960
        public void .ctor(){} // RVA: 0x24A50
    }

    public class BasicNode`1
    {
        // ── Methods ──
        public void AppendTo(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x24A50
    }

    public class BasicNode`1
    {
        // ── Methods ──
        public void AppendTo(){} // RVA: 0x571F940
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class BasicNode`1
    {
    }

    public class BestFitAllocator
    {
        public uint size; // 0x10
        public Block m_FirstBlock; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x733EFA0
        public void get_totalSize(){} // RVA: 0x32A5C0
        public void get_highWatermark(){} // RVA: 0x733F200
        public void Allocate(){} // RVA: 0x733F210
        public void Free(){} // RVA: 0x733F5B0
        public void CoalesceBlockWithPrevious(){} // RVA: 0x733FA30
        public void BestFitFindAvailableBlock(){} // RVA: 0x733FC90
        public void SplitBlock(){} // RVA: 0x733FCD0
    }

    public class BitmapAllocator32
    {
        public int pageWidth; // 0x10
        public System.Collections.Generic.List`1<Page> pageHeight; // 0x18

        // ── Methods ──
        public void Construct(){} // RVA: 0x73543E0
        public void ForceFirstAlloc(){} // RVA: 0x7354600
        public void Allocate(){} // RVA: 0x73547C0
        public void Free(){} // RVA: 0x7354C70
        public void get_entryWidth(){} // RVA: 0x3D92310
        public void get_entryHeight(){} // RVA: 0x33B6D30
        public void GetAllocPageAtlasLocation(){} // RVA: 0x7354DF0
        public void CountTrailingZeroes(){} // RVA: 0x7354E90
    }

    public class ChainBuilderStats
    {
    }

    public class ConvertMeshJobData
    {
    }

    public class CopyClosingMeshJobData
    {
    }

    public class DetachedAllocator
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7335C90 | overloaded x2
    }

    public class DrawBufferRange
    {
    }

    public class DrawParams
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7341000
        public void .ctor(){} // RVA: 0x7341230
        public void .cctor(){} // RVA: 0x7341680
    }

    public class GPUBufferAllocator
    {
        public UnityEngine.UIElements.UIR.BestFitAllocator m_Low; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73401F0
        public void Allocate(){} // RVA: 0x7340330
        public void Free(){} // RVA: 0x7340540
        public void get_isEmpty(){} // RVA: 0x73405C0
        public void HighLowCollide(){} // RVA: 0x7340600
    }

    public class GfxUpdateBufferRange
    {
    }

    public class GradientRemap
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7353170
        public void .ctor(){} // RVA: 0x73531E0
    }

    public class GradientRemapPool
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7352D70
    }

    public class GradientSettingsAtlas
    {
        public Unity.Profiling.ProfilerMarker s_MarkerWrite;
        public Unity.Profiling.ProfilerMarker s_MarkerCommit; // 0x8
        public int m_Length; // 0x10
        public int m_ElemWidth; // 0x14

        // ── Methods ──
        public void get_length(){} // RVA: 0x70B92A0
        public void get_disposed(){} // RVA: 0x4A6500
        public void set_disposed(){} // RVA: 0x4A78C0
        public void Dispose(){} // RVA: 0x7343480 | overloaded x2
        public void .ctor(){} // RVA: 0x73434F0
        public void Reset(){} // RVA: 0x7343610
        public void get_atlas(){} // RVA: 0x6A24380
        public void Add(){} // RVA: 0x7343720
        public void Write(){} // RVA: 0x7343810
        public void get_MustCommit(){} // RVA: 0x4A7410
        public void set_MustCommit(){} // RVA: 0x4A7670
        public void Commit(){} // RVA: 0x7343D50
        public void PrepareAtlas(){} // RVA: 0x7343DC0
        public void .cctor(){} // RVA: 0x73440F0
    }

    public class JobManager
    {
        public UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.NudgeJobData> m_NudgeJobs; // 0x10

        // ── Methods ──
        public void Add(){} // RVA: 0x7344650 | overloaded x3
        public void CompleteNudgeJobs(){} // RVA: 0x7344810
        public void CompleteConvertMeshJobs(){} // RVA: 0x7344BA0
        public void CompleteClosingMeshJobs(){} // RVA: 0x7344F30
        public void get_disposed(){} // RVA: 0x303450
        public void set_disposed(){} // RVA: 0x303460
        public void Dispose(){} // RVA: 0x7345450 | overloaded x2
        public void .ctor(){} // RVA: 0x73455A0
    }

    public class JobMerger
    {
        public Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle> m_Jobs; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7345930
        public void Add(){} // RVA: 0x73459F0
        public void MergeAndReset(){} // RVA: 0x7345AF0
        public void get_disposed(){} // RVA: 0x2F87C0
        public void set_disposed(){} // RVA: 0x4D7670
        public void Dispose(){} // RVA: 0x7345CD0 | overloaded x2
    }

    public class JobProcessor
    {
        // ── Methods ──
        public void ScheduleNudgeJobs(){} // RVA: 0x73342D0
        public void ScheduleConvertMeshJobs(){} // RVA: 0x7334350
        public void ScheduleCopyClosingMeshJobs(){} // RVA: 0x73343D0
        public void ScheduleNudgeJobs_Injected(){} // RVA: 0x7334450
        public void ScheduleConvertMeshJobs_Injected(){} // RVA: 0x73344C0
        public void ScheduleCopyClosingMeshJobs_Injected(){} // RVA: 0x7334530
    }

    public class LinkedPoolItem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
    }

    public class LinkedPoolItem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LinkedPoolItem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LinkedPoolItem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LinkedPoolItem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LinkedPoolItem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LinkedPoolItem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LinkedPoolItem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LinkedPoolItem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LinkedPoolItem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LinkedPool`1
    {
        public System.Func`1<T> m_CreateFunc;

        // ── Methods ──
        public void .ctor(){}
        public void get_Count(){} // RVA: 0xD840
        public void set_Count(){} // RVA: 0x24FA0
        public void Clear(){} // RVA: 0x24A50
        public void Get(){} // RVA: 0x283FA0
        public void Return(){} // RVA: 0x283FA0
    }

    public class LinkedPool`1
    {
        public System.Func`1<UnityEngine.UIElements.UIR.BasicNode`1<T>> m_CreateFunc; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x37EE520
        public void get_Count(){} // RVA: 0x338CD0
        public void set_Count(){} // RVA: 0x338CE0
        public void Clear(){} // RVA: 0x37EE660
        public void Get(){} // RVA: 0x37EE670
        public void Return(){} // RVA: 0x37EE720
    }

    public class LinkedPool`1
    {
        public System.Func`1<Block> m_CreateFunc; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x37EE520
        public void get_Count(){} // RVA: 0x338CD0
        public void set_Count(){} // RVA: 0x338CE0
        public void Clear(){} // RVA: 0x37EE660
        public void Get(){} // RVA: 0x37EE670
        public void Return(){} // RVA: 0x37EE720
    }

    public class LinkedPool`1
    {
        public System.Func`1<UnityEngine.UIElements.UIR.VectorImageRenderInfo> m_CreateFunc; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x37EE520
        public void get_Count(){} // RVA: 0x338CD0
        public void set_Count(){} // RVA: 0x338CE0
        public void Clear(){} // RVA: 0x37EE660
        public void Get(){} // RVA: 0x37EE670
        public void Return(){} // RVA: 0x37EE720
    }

    public class LinkedPool`1
    {
        public System.Func`1<UnityEngine.UIElements.UIR.GradientRemap> m_CreateFunc; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x37EE520
        public void get_Count(){} // RVA: 0x338CD0
        public void set_Count(){} // RVA: 0x338CE0
        public void Clear(){} // RVA: 0x37EE660
        public void Get(){} // RVA: 0x37EE670
        public void Return(){} // RVA: 0x37EE720
    }

    public class MeshBuilder
    {
        // ── Methods ──
        public void ConvertTextVertexToUIRVertex(){} // RVA: 0x7345D30
        public void LimitTextVertices(){} // RVA: 0x7345F00
        public void MakeText(){} // RVA: 0x7346080
        public void .cctor(){} // RVA: 0x7346940
    }

    public class MeshHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7335D10
    }

    public class NativePagedList`1
    {
        public int k_PoolCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0
        public void Add(){} // RVA: 0x24B10
        public void GetPages(){} // RVA: 0xCD60
        public void Reset(){} // RVA: 0x24A50
        public void get_disposed(){} // RVA: 0xDBE0
        public void set_disposed(){} // RVA: 0x25130
        public void Dispose(){} // RVA: 0x25130 | overloaded x2
    }

    public class NudgeJobData
    {
    }

    public class OpacityIdAccelerator
    {
        public Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle> m_Jobs; // 0x10

        // ── Methods ──
        public void CreateJob(){} // RVA: 0x7346BA0
        public void CompleteJobs(){} // RVA: 0x7346E90
        public void get_disposed(){} // RVA: 0x2F87C0
        public void set_disposed(){} // RVA: 0x4D7670
        public void Dispose(){} // RVA: 0x73470E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7347140
    }

    public class Page : .ctor
    {
        public bool <disposed>k__BackingField; // 0x10
        public DataSet`1<UnityEngine.UIElements.Vertex> vertices; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7340A20
        public void get_disposed(){} // RVA: 0x3A75E0
        public void set_disposed(){} // RVA: 0x3A75F0
        public void Dispose(){} // RVA: 0x7340C80 | overloaded x2
        public void get_isEmpty(){} // RVA: 0x7340F80
    }

    public class RenderChain
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
        public void get_opacityIdAccelerator(){} // RVA: 0x7F7DB0
        public void set_opacityIdAccelerator(){} // RVA: 0x63D280
        public void .cctor(){} // RVA: 0x7347340
        public void .ctor(){} // RVA: 0x7347A70
        public void Constructor(){} // RVA: 0x7348120
        public void Destructor(){} // RVA: 0x7348C30
        public void get_disposed(){} // RVA: 0x12108C0
        public void set_disposed(){} // RVA: 0x120E9D0
        public void Dispose(){} // RVA: 0x7349510 | overloaded x2
        public void ProcessChanges(){} // RVA: 0x7349540
        public void Render(){} // RVA: 0x7349E00
        public void UIEOnChildAdded(){} // RVA: 0x734A3D0
        public void UIEOnChildrenReordered(){} // RVA: 0x734A730
        public void UIEOnChildRemoving(){} // RVA: 0x734AB10
        public void UIEOnRenderHintsChanged(){} // RVA: 0x734AC20
        public void UIEOnClippingChanged(){} // RVA: 0x734ACF0
        public void UIEOnOpacityChanged(){} // RVA: 0x734AD90
        public void UIEOnColorChanged(){} // RVA: 0x734AE30
        public void UIEOnTransformOrSizeChanged(){} // RVA: 0x734AED0
        public void UIEOnVisualsChanged(){} // RVA: 0x734AF70
        public void UIEOnOpacityIdChanged(){} // RVA: 0x734B010
        public void get_panel(){} // RVA: 0xA902E0
        public void set_panel(){} // RVA: 0xCF4780
        public void get_device(){} // RVA: 0x507710
        public void set_device(){} // RVA: 0x509930
        public void get_atlas(){} // RVA: 0x507D10
        public void set_atlas(){} // RVA: 0x50A8C0
        public void get_vectorImageManager(){} // RVA: 0x59E660
        public void set_vectorImageManager(){} // RVA: 0x59F420
        public void get_vertsPool(){} // RVA: 0xA8EE80
        public void set_vertsPool(){} // RVA: 0xD182E0
        public void get_indicesPool(){} // RVA: 0xA8E870
        public void set_indicesPool(){} // RVA: 0xDA3F70
        public void get_jobManager(){} // RVA: 0xA933D0
        public void set_jobManager(){} // RVA: 0xA96DC0
        public void get_painter(){} // RVA: 0xD9F7C0
        public void set_painter(){} // RVA: 0xD9BA80
        public void get_drawStats(){} // RVA: 0x734B0B0
        public void set_drawStats(){} // RVA: 0x692DAA0
        public void get_drawInCameras(){} // RVA: 0x734B0C0
        public void set_drawInCameras(){} // RVA: 0x734B0D0
        public void set_defaultShader(){} // RVA: 0x734B0E0
        public void set_defaultWorldSpaceShader(){} // RVA: 0x734B2F0
        public void GetStandardMaterial(){} // RVA: 0x734B500
        public void GetStandardWorldSpaceMaterial(){} // RVA: 0x734B790
        public void EnsureFitsDepth(){} // RVA: 0x734BA20
        public void ChildWillBeRemoved(){} // RVA: 0x734BA30
        public void AllocCommand(){} // RVA: 0x734BAF0
        public void FreeCommand(){} // RVA: 0x734BB50
        public void OnRenderCommandAdded(){} // RVA: 0x734BC70
        public void OnRenderCommandsRemoved(){} // RVA: 0x734BDB0
        public void AccessRenderNodeData(){} // RVA: 0x734BE20
        public void OnRenderNodeExecute(){} // RVA: 0x734BFB0
        public void OnRegisterIntermediateRenderers(){} // RVA: 0x734C1F0
        public void OnRegisterIntermediateRendererMat(){} // RVA: 0x734CB90
        public void RepaintTexturedElements(){} // RVA: 0x734D0F0
        public void AppendTexture(){} // RVA: 0x734D240
        public void ResetTextures(){} // RVA: 0x734D410
        public void DrawStats(){} // RVA: 0x734D590
        public void GetFirstElementInPanel(){} // RVA: 0x734E060
    }

    public class RenderChainCommand
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x73416E0
        public void ExecuteNonDrawMesh(){} // RVA: 0x7341890
        public void Blit(){} // RVA: 0x7342BC0
        public void CombineScissorRects(){} // RVA: 0x7343010
        public void RectPointsToPixelsAndFlipYAxis(){} // RVA: 0x7343180
        public void .ctor(){} // RVA: 0x73432D0
        public void .cctor(){} // RVA: 0x7343300
    }

    public class RenderChainVEData
    {
        public UnityEngine.UIElements.VisualElement prev; // 0x10
        public UnityEngine.UIElements.VisualElement next; // 0x18

        // ── Methods ──
        public void get_lastClosingOrLastCommand(){} // RVA: 0x734EE70
        public void AllocatesID(){} // RVA: 0x734EE80
        public void InheritsID(){} // RVA: 0x734EEE0
        public void get_isIgnoringDynamicColorHint(){} // RVA: 0x734EF40
    }

    public class ShaderInfoStorageRGBA32
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x734F160
        public void .cctor(){} // RVA: 0x734F210
    }

    public class ShaderInfoStorageRGBAFloat
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x734F4A0
        public void .cctor(){} // RVA: 0x734F550
    }

    public class ShaderInfoStorage`1
    {
        public int m_InitialSize;

        // ── Methods ──
        public void .ctor(){}
        public void Dispose(){} // RVA: 0x25130
        public void get_texture(){} // RVA: 0xCD60
        public void AllocateRect(){}
        public void SetTexel(){}
        public void UpdateTexture(){} // RVA: 0x24A50
        public void CreateOrExpandTexture(){} // RVA: 0x24A50
        public void CpuBlit(){} // RVA: 0x283FA0
    }

    public class ShaderInfoStorage`1
    {
        public int UnityEngine.UIElementsModule; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x40181B0
        public void Dispose(){} // RVA: 0x40183B0
        public void get_texture(){} // RVA: 0x4976A0
        public void AllocateRect(){} // RVA: 0x4018510
        public void SetTexel(){} // RVA: 0x40186A0
        public void UpdateTexture(){} // RVA: 0x4018790
        public void CreateOrExpandTexture(){} // RVA: 0x40188B0
        public void CpuBlit(){} // RVA: 0x4018E40
    }

    public class ShaderInfoStorage`1
    {
        public int UnityEngine.UIElementsModule; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x40173F0
        public void Dispose(){} // RVA: 0x40175F0
        public void get_texture(){} // RVA: 0x4976A0
        public void AllocateRect(){} // RVA: 0x4017750
        public void SetTexel(){} // RVA: 0x40178E0
        public void UpdateTexture(){} // RVA: 0x40179E0
        public void CreateOrExpandTexture(){} // RVA: 0x4017B00
        public void CpuBlit(){} // RVA: 0x40180A0
    }

    public class Shaders
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x734F7C0
    }

    public class State
    {
    }

    public class TempAllocator`1
    {
        public int m_ExcessMinCapacity;

        // ── Methods ──
        public void .ctor(){}
        public void get_disposed(){} // RVA: 0xDBE0
        public void set_disposed(){} // RVA: 0x25130
        public void Dispose(){} // RVA: 0x25130 | overloaded x2
        public void Alloc(){} // RVA: 0x283FA0
        public void Reset(){} // RVA: 0x24A50
        public void ReleaseExcess(){} // RVA: 0x24A50
    }

    public class TextCoreSettings
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x734FF10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x73500B0
    }

    public class TextureBlitter
    {
        public int[] k_TextureIds;

        // ── Methods ──
        public void get_disposed(){} // RVA: 0x394D30
        public void set_disposed(){} // RVA: 0x394D40
        public void Dispose(){} // RVA: 0x73501F0 | overloaded x2
        public void .cctor(){} // RVA: 0x73502B0
        public void .ctor(){} // RVA: 0x7350530
        public void QueueBlit(){} // RVA: 0x7350680
        public void BlitOneNow(){} // RVA: 0x73507E0
        public void Commit(){} // RVA: 0x7350990
        public void BeginBlit(){} // RVA: 0x7350A90
        public void DoBlit(){} // RVA: 0x7350FB0
        public void EndBlit(){} // RVA: 0x7351A60
    }

    public class TextureEntry
    {
    }

    public class TextureSlotManager
    {
        public int k_SlotCount;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7351B40
        public void .ctor(){} // RVA: 0x7351E10
        public void Reset(){} // RVA: 0x73520C0
        public void StartNewBatch(){} // RVA: 0x7352210
        public void IndexOf(){} // RVA: 0x7352280
        public void MarkUsed(){} // RVA: 0x73407B0
        public void get_FreeSlots(){} // RVA: 0x338CD0
        public void set_FreeSlots(){} // RVA: 0x338CE0
        public void FindOldestSlot(){} // RVA: 0x7352350
        public void Bind(){} // RVA: 0x7352420
        public void SetGpuData(){} // RVA: 0x7352710
    }

    public class Transform3x4
    {
    }

    public class UIRVEShaderInfoAllocator
    {
        public UnityEngine.UIElements.UIR.BaseShaderInfoStorage m_Storage; // 0x10
        public UnityEngine.UIElements.UIR.BitmapAllocator32 m_TransformAllocator; // 0x18
        public UnityEngine.UIElements.UIR.BitmapAllocator32 m_ClipRectAllocator; // 0x38
        public UnityEngine.UIElements.UIR.BitmapAllocator32 m_OpacityAllocator; // 0x58
        public UnityEngine.UIElements.UIR.BitmapAllocator32 m_ColorAllocator; // 0x78

        // ── Methods ──
        public void get_pageWidth(){} // RVA: 0x7354F20
        public void get_pageHeight(){} // RVA: 0x7354F30
        public void AllocToTexelCoord(){} // RVA: 0x7354F40
        public void AllocToConstantBufferIndex(){} // RVA: 0x7354FF0
        public void AtlasRectMatchesPage(){} // RVA: 0x7355050
        public void get_transformConstants(){} // RVA: 0x7355180
        public void get_clipRectConstants(){} // RVA: 0x7355260
        public void get_atlas(){} // RVA: 0x7355340
        public void Construct(){} // RVA: 0x73553E0
        public void ReallyCreateStorage(){} // RVA: 0x7355890
        public void Dispose(){} // RVA: 0x73560A0
        public void IssuePendingStorageChanges(){} // RVA: 0x7356200
        public void AllocTransform(){} // RVA: 0x7356220
        public void AllocClipRect(){} // RVA: 0x7356370
        public void AllocOpacity(){} // RVA: 0x73564C0
        public void AllocColor(){} // RVA: 0x7356530
        public void AllocTextCoreSettings(){} // RVA: 0x73565A0
        public void SetTransformValue(){} // RVA: 0x7356610
        public void SetClipRectValue(){} // RVA: 0x73569E0
        public void SetOpacityValue(){} // RVA: 0x7356BA0
        public void SetColorValue(){} // RVA: 0x7356CE0
        public void SetTextCoreSettingValue(){} // RVA: 0x7356E60
        public void FreeTransform(){} // RVA: 0x73571F0
        public void FreeClipRect(){} // RVA: 0x7357290
        public void FreeOpacity(){} // RVA: 0x7357330
        public void FreeColor(){} // RVA: 0x73573D0
        public void FreeTextCoreSettings(){} // RVA: 0x7357470
        public void TransformAllocToVertexData(){} // RVA: 0x7357520
        public void ClipRectAllocToVertexData(){} // RVA: 0x7357670
        public void OpacityAllocToVertexData(){} // RVA: 0x73577C0
        public void ColorAllocToVertexData(){} // RVA: 0x7357900
        public void TextCoreSettingsToVertexData(){} // RVA: 0x7357A40
        public void .cctor(){} // RVA: 0x7357B80
    }

    public class UIRenderDevice
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
        public void get_maxVerticesPerPage(){} // RVA: 0xCC3CB0
        public void get_breakBatches(){} // RVA: 0x7335D40
        public void set_breakBatches(){} // RVA: 0x7335D50
        public void .cctor(){} // RVA: 0x7335D60
        public void .ctor(){} // RVA: 0x7336570 | overloaded x2
        public void get_defaultShaderInfoTexFloat(){} // RVA: 0x7337060
        public void get_defaultShaderInfoTexARGB8(){} // RVA: 0x73377A0
        public void get_vertexTexturingIsAvailable(){} // RVA: 0x7337CE0
        public void get_shaderModelIs35(){} // RVA: 0x7337FB0
        public void InitVertexDeclaration(){} // RVA: 0x7338280
        public void CompleteCreation(){} // RVA: 0x7338430
        public void get_fullyCreated(){} // RVA: 0x73386C0
        public void get_disposed(){} // RVA: 0x73386D0
        public void set_disposed(){} // RVA: 0x73386E0
        public void Dispose(){} // RVA: 0x7338760 | overloaded x2
        public void Allocate(){} // RVA: 0x73394F0 | overloaded x2
        public void Update(){} // RVA: 0x7338CC0 | overloaded x2
        public void UpdateCopyBackIndices(){} // RVA: 0x7339070
        public void ActiveUpdatesForMeshHandle(){} // RVA: 0x7339220
        public void TryAllocFromPage(){} // RVA: 0x73392C0
        public void UpdateAfterGPUUsedData(){} // RVA: 0x7339F30
        public void Free(){} // RVA: 0x733AA30
        public void OnFrameRenderingBegin(){} // RVA: 0x733B600
        public void PtrToSlice(){} // RVA: 0x283FA0
        public void ApplyDrawCommandState(){} // RVA: 0x733B6B0
        public void ApplyBatchState(){} // RVA: 0x733B8C0
        public void EvaluateChain(){} // RVA: 0x733BAE0
        public void UpdateFenceValue(){} // RVA: 0x733CC00
        public void KickRanges(){} // RVA: 0x733CCF0
        public void DrawRanges(){} // RVA: 0x283FA0
        public void WaitOnCpuFence(){} // RVA: 0x733CFC0
        public void AdvanceFrame(){} // RVA: 0x733D0B0
        public void PruneUnusedPages(){} // RVA: 0x733DFD0
        public void PrepareForGfxDeviceRecreate(){} // RVA: 0x733E250
        public void WrapUpGfxDeviceRecreate(){} // RVA: 0x733E5B0
        public void FlushAllPendingDeviceDisposes(){} // RVA: 0x733E610
        public void GatherDrawStatistics(){} // RVA: 0x733E6C0
        public void ProcessDeviceFreeQueue(){} // RVA: 0x733E6E0
        public void OnEngineUpdateGlobal(){} // RVA: 0x733ECF0
        public void OnFlushPendingResources(){} // RVA: 0x733ED40
    }

    public class Utility
    {
        // ── Methods ──
        public void SetVectorArray(){} // RVA: 0x73337F0 | overloaded x2
        public void add_GraphicsResourcesRecreate(){} // RVA: 0x7332590
        public void remove_GraphicsResourcesRecreate(){} // RVA: 0x73326F0
        public void add_EngineUpdate(){} // RVA: 0x7332850
        public void remove_EngineUpdate(){} // RVA: 0x73329A0
        public void add_FlushPendingResources(){} // RVA: 0x7332AF0
        public void remove_FlushPendingResources(){} // RVA: 0x7332C40
        public void add_RegisterIntermediateRenderers(){} // RVA: 0x7332D90
        public void remove_RegisterIntermediateRenderers(){} // RVA: 0x7332EF0
        public void add_RenderNodeExecute(){} // RVA: 0x7333050
        public void remove_RenderNodeExecute(){} // RVA: 0x73331B0
        public void RaiseGraphicsResourcesRecreate(){} // RVA: 0x7333310
        public void RaiseEngineUpdate(){} // RVA: 0x7333390
        public void RaiseFlushPendingResources(){} // RVA: 0x7333430
        public void RaiseRegisterIntermediateRenderers(){} // RVA: 0x73334A0
        public void RaiseRenderNodeAdd(){} // RVA: 0x7333520
        public void RaiseRenderNodeExecute(){} // RVA: 0x73335A0
        public void RaiseRenderNodeCleanup(){} // RVA: 0x7333620
        public void AllocateBuffer(){} // RVA: 0x73336A0
        public void FreeBuffer(){} // RVA: 0x7333710
        public void UpdateBufferRanges(){} // RVA: 0x7333760
        public void GetVertexDeclaration(){} // RVA: 0x7333870
        public void RegisterIntermediateRenderer(){} // RVA: 0x73338C0
        public void DrawRanges(){} // RVA: 0x73339E0
        public void SetPropertyBlock(){} // RVA: 0x7333A70
        public void SetScissorRect(){} // RVA: 0x7333AC0
        public void DisableScissor(){} // RVA: 0x7333B50
        public void CreateStencilState(){} // RVA: 0x7333BA0
        public void SetStencilState(){} // RVA: 0x7333C30
        public void HasMappedBufferRange(){} // RVA: 0x7333C90
        public void InsertCPUFence(){} // RVA: 0x7333CE0
        public void CPUFencePassed(){} // RVA: 0x7333D30
        public void WaitForCPUFencePassed(){} // RVA: 0x7333D80
        public void SyncRenderThread(){} // RVA: 0x7333DD0
        public void GetActiveViewport(){} // RVA: 0x7333E20
        public void ProfileDrawChainBegin(){} // RVA: 0x7333EB0
        public void ProfileDrawChainEnd(){} // RVA: 0x7333F00
        public void NotifyOfUIREvents(){} // RVA: 0x7333F50
        public void GetUnityProjectionMatrix(){} // RVA: 0x7333FA0
        public void .cctor(){} // RVA: 0x7334040
        public void RegisterIntermediateRenderer_Injected(){} // RVA: 0x73340F0
        public void SetScissorRect_Injected(){} // RVA: 0x7334190
        public void CreateStencilState_Injected(){} // RVA: 0x73341E0
        public void GetActiveViewport_Injected(){} // RVA: 0x7334230
        public void GetUnityProjectionMatrix_Injected(){} // RVA: 0x7334280
    }

    public class VectorImageManager
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.VectorImageManager> instances;
        public Unity.Profiling.ProfilerMarker s_MarkerRegister; // 0x8

        // ── Methods ──
        public void get_atlas(){} // RVA: 0x7353210
        public void .ctor(){} // RVA: 0x7353230
        public void get_disposed(){} // RVA: 0x4A7410
        public void set_disposed(){} // RVA: 0x4A7670
        public void Dispose(){} // RVA: 0x7353770 | overloaded x2
        public void Commit(){} // RVA: 0x7353900
        public void AddUser(){} // RVA: 0x7353990
        public void Register(){} // RVA: 0x7353B00
        public void .cctor(){} // RVA: 0x7353FE0
    }

    public class VectorImageRenderInfo
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7352CE0
        public void .ctor(){} // RVA: 0x7352D40
    }

    public class VectorImageRenderInfoPool
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x73528E0
    }

}