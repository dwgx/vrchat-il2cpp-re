// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.UIR
// Classes: 57
// Methods: 427

namespace ThirdParty.Unity.UnityEngine.UIElements.UIR
{
    public class Allocator2D : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF1148C0
        public void TryAllocate(){} // RVA: 0x7AF114E20
        public void Free(){} // RVA: 0x7AF1153A0
        public void BuildAreas(){} // RVA: 0x7AF115660
        public void ComputeMaxAllocSize(){} // RVA: 0x7AF115800
        public void BuildRowArray(){} // RVA: 0x7AF115930
    }

    public class BMPAlloc : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7EFF4F0
        public void IsValid(){} // RVA: 0x7A7EFF510
        public void ToString(){} // RVA: 0x7A7EFF520
        public void .cctor(){} // RVA: 0x7AF134610
    }

    public class BaseShaderInfoStorage : Object
    {
        // ── Methods ──
        public void get_texture(){} // RVA: 0x7A7E00680
        public void AllocateRect(){} // RVA: 0x7A7E02D30
        public void SetTexel(){} // RVA: 0x7A7E1A4C0
        public void UpdateTexture(){} // RVA: 0x7A7E18770
        public void get_disposed(){} // RVA: 0x7A81A2200
        public void set_disposed(){} // RVA: 0x7A81A2210
        public void Dispose(){} // RVA: 0x7ADA8F0A0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AF12F1B0
    }

    public class BasicNodePool`1 : LinkedPool`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7A7E18830
        public void Create(){} // RVA: 0x7A7E006B0
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class BasicNode`1 : LinkedPoolItem`1
    {
        // ── Methods ──
        public void AppendTo(){} // RVA: 0x7A7E18800
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class BasicNode`1 : LinkedPoolItem`1
    {
        // ── Methods ──
        public void AppendTo(){} // RVA: 0x7AD4EF480
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BestFitAllocator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF11F320
        public void get_totalSize(){} // RVA: 0x7A8124910
        public void get_highWatermark(){} // RVA: 0x7AF11F5A0
        public void Allocate(){} // RVA: 0x7AF11F5B0
        public void Free(){} // RVA: 0x7AF11F960
        public void CoalesceBlockWithPrevious(){} // RVA: 0x7AF11FDE0
        public void BestFitFindAvailableBlock(){} // RVA: 0x7AF120040
        public void SplitBlock(){} // RVA: 0x7AF120080
    }

    public class BitmapAllocator32 : ValueType
    {
        // ── Methods ──
        public void Construct(){} // RVA: 0x7A7EFF680
        public void ForceFirstAlloc(){} // RVA: 0x7A7EFF690
        public void Allocate(){} // RVA: 0x7A7EFF6A0
        public void Free(){} // RVA: 0x7A7EFF6B0
        public void get_entryWidth(){} // RVA: 0x7A7AD1FC0
        public void get_entryHeight(){} // RVA: 0x7A7ED3A90
        public void GetAllocPageAtlasLocation(){} // RVA: 0x7A7EFF6C0
        public void CountTrailingZeroes(){} // RVA: 0x7AF135140
    }

    public class DetachedAllocator : Object
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7AF115FB0
    }

    public class DrawParams : Object
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7AF1213B0
        public void .ctor(){} // RVA: 0x7AF1215E0
        public void .cctor(){} // RVA: 0x7AF121A30
    }

    public class GPUBufferAllocator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF1205A0
        public void Allocate(){} // RVA: 0x7AF1206E0
        public void Free(){} // RVA: 0x7AF1208F0
        public void get_isEmpty(){} // RVA: 0x7AF120970
        public void HighLowCollide(){} // RVA: 0x7AF1209B0
    }

    public class GradientRemap : LinkedPoolItem`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7AF1333F0
        public void .ctor(){} // RVA: 0x7AF133460
    }

    public class GradientRemapPool : LinkedPool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF132FD0
    }

    public class GradientSettingsAtlas : Object
    {
        // ── Methods ──
        public void get_length(){} // RVA: 0x7AEE980C0
        public void get_disposed(){} // RVA: 0x7A82A20A0
        public void set_disposed(){} // RVA: 0x7A82A2C90
        public void Dispose(){} // RVA: 0x7AF123980
        public void .ctor(){} // RVA: 0x7AF1239F0
        public void Reset(){} // RVA: 0x7AF123B10
        public void get_atlas(){} // RVA: 0x7AE8145B0
        public void Add(){} // RVA: 0x7AF123C20
        public void Write(){} // RVA: 0x7AF123D10
        public void get_MustCommit(){} // RVA: 0x7A82A3DE0
        public void set_MustCommit(){} // RVA: 0x7A82A20B0
        public void Commit(){} // RVA: 0x7AF124270
        public void PrepareAtlas(){} // RVA: 0x7AF1242E0
        public void .cctor(){} // RVA: 0x7AF124610
    }

    public class JobManager : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AF124940
        public void CompleteNudgeJobs(){} // RVA: 0x7AF1249A0
        public void CompleteConvertMeshJobs(){} // RVA: 0x7AF124D50
        public void CompleteClosingMeshJobs(){} // RVA: 0x7AF125100
        public void get_disposed(){} // RVA: 0x7A80FD690
        public void set_disposed(){} // RVA: 0x7A80FD6A0
        public void Dispose(){} // RVA: 0x7AF125640
        public void .ctor(){} // RVA: 0x7AF125790
    }

    public class JobMerger : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF125B20
        public void Add(){} // RVA: 0x7AF125C40
        public void MergeAndReset(){} // RVA: 0x7AF125D40
        public void get_disposed(){} // RVA: 0x7A80F29B0
        public void set_disposed(){} // RVA: 0x7A9727920
        public void Dispose(){} // RVA: 0x7AF125F20
    }

    public class JobProcessor : Object
    {
        // ── Methods ──
        public void ScheduleNudgeJobs(){} // RVA: 0x7AF1145F0
        public void ScheduleConvertMeshJobs(){} // RVA: 0x7AF114670
        public void ScheduleCopyClosingMeshJobs(){} // RVA: 0x7AF1146F0
        public void ScheduleNudgeJobs_Injected(){} // RVA: 0x7AF114770
        public void ScheduleConvertMeshJobs_Injected(){} // RVA: 0x7AF1147E0
        public void ScheduleCopyClosingMeshJobs_Injected(){} // RVA: 0x7AF114850
    }

    public class LinkedPoolItem`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class LinkedPoolItem`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LinkedPoolItem`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LinkedPoolItem`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LinkedPoolItem`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LinkedPoolItem`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LinkedPoolItem`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LinkedPoolItem`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LinkedPoolItem`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LinkedPoolItem`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LinkedPool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1A470
        public void get_Count(){} // RVA: 0x7A7E00710
        public void set_Count(){} // RVA: 0x7A7E189D0
        public void Clear(){} // RVA: 0x7A7E18770
        public void Get(){} // RVA: 0x7A8051B10
        public void Return(){} // RVA: 0x7A8051B10
    }

    public class LinkedPool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB5DB070
        public void get_Count(){} // RVA: 0x7A8133100
        public void set_Count(){} // RVA: 0x7A8133110
        public void Clear(){} // RVA: 0x7AB5DB1B0
        public void Get(){} // RVA: 0x7AB5DB1C0
        public void Return(){} // RVA: 0x7AB5DB270
    }

    public class LinkedPool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB5DB070
        public void get_Count(){} // RVA: 0x7A8133100
        public void set_Count(){} // RVA: 0x7A8133110
        public void Clear(){} // RVA: 0x7AB5DB1B0
        public void Get(){} // RVA: 0x7AB5DB1C0
        public void Return(){} // RVA: 0x7AB5DB270
    }

    public class LinkedPool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB5DB070
        public void get_Count(){} // RVA: 0x7A8133100
        public void set_Count(){} // RVA: 0x7A8133110
        public void Clear(){} // RVA: 0x7AB5DB1B0
        public void Get(){} // RVA: 0x7AB5DB1C0
        public void Return(){} // RVA: 0x7AB5DB270
    }

    public class LinkedPool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB5DB070
        public void get_Count(){} // RVA: 0x7A8133100
        public void set_Count(){} // RVA: 0x7A8133110
        public void Clear(){} // RVA: 0x7AB5DB1B0
        public void Get(){} // RVA: 0x7AB5DB1C0
        public void Return(){} // RVA: 0x7AB5DB270
    }

    public class MeshBuilder : Object
    {
        // ── Methods ──
        public void ConvertTextVertexToUIRVertex(){} // RVA: 0x7AF125F80
        public void LimitTextVertices(){} // RVA: 0x7AF126150
        public void MakeText(){} // RVA: 0x7AF1262D0
        public void .cctor(){} // RVA: 0x7AF126B90
    }

    public class MeshHandle : LinkedPoolItem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF116030
    }

    public class NativePagedList`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E189D0
        public void Add(){} // RVA: 0x7A7E18800
        public void GetPages(){} // RVA: 0x7A7E00680
        public void Reset(){} // RVA: 0x7A7E18770
        public void get_disposed(){} // RVA: 0x7A7E01900
        public void set_disposed(){} // RVA: 0x7A7E18C30
        public void Dispose(){} // RVA: 0x7A7E18C30
    }

    public class OpacityIdAccelerator : Object
    {
        // ── Methods ──
        public void CreateJob(){} // RVA: 0x7AF126DF0
        public void CompleteJobs(){} // RVA: 0x7AF126FD0
        public void get_disposed(){} // RVA: 0x7A80F29B0
        public void set_disposed(){} // RVA: 0x7A9727920
        public void Dispose(){} // RVA: 0x7AF127220
        public void .ctor(){} // RVA: 0x7AF127280
    }

    public class Page : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF120DD0
        public void get_disposed(){} // RVA: 0x7A81A2200
        public void set_disposed(){} // RVA: 0x7A81A2210
        public void Dispose(){} // RVA: 0x7AF121030
        public void get_isEmpty(){} // RVA: 0x7AF121330
    }

    public class RenderChain : Object
    {
        // ── Methods ──
        public void get_opacityIdAccelerator(){} // RVA: 0x7A8592710
        public void set_opacityIdAccelerator(){} // RVA: 0x7A84442D0
        public void .cctor(){} // RVA: 0x7AF127480
        public void .ctor(){} // RVA: 0x7AF127BB0
        public void Constructor(){} // RVA: 0x7AF128260
        public void Destructor(){} // RVA: 0x7AF128D80
        public void get_disposed(){} // RVA: 0x7A8F95140
        public void set_disposed(){} // RVA: 0x7A8F94B50
        public void Dispose(){} // RVA: 0x7AF129660
        public void ProcessChanges(){} // RVA: 0x7AF129690
        public void Render(){} // RVA: 0x7AF129FB0
        public void UIEOnChildAdded(){} // RVA: 0x7AF12A560
        public void UIEOnChildrenReordered(){} // RVA: 0x7AF12A8C0
        public void UIEOnChildRemoving(){} // RVA: 0x7AF12ACD0
        public void UIEOnRenderHintsChanged(){} // RVA: 0x7AF12ADE0
        public void UIEOnClippingChanged(){} // RVA: 0x7AF12AEB0
        public void UIEOnOpacityChanged(){} // RVA: 0x7AF12AF50
        public void UIEOnColorChanged(){} // RVA: 0x7AF12AFF0
        public void UIEOnTransformOrSizeChanged(){} // RVA: 0x7AF12B090
        public void UIEOnVisualsChanged(){} // RVA: 0x7AF12B130
        public void UIEOnOpacityIdChanged(){} // RVA: 0x7AF12B1D0
        public void get_panel(){} // RVA: 0x7A884DED0
        public void set_panel(){} // RVA: 0x7A8AB6790
        public void get_device(){} // RVA: 0x7A884F050
        public void set_device(){} // RVA: 0x7A8B5D8D0
        public void get_atlas(){} // RVA: 0x7A864CFF0
        public void set_atlas(){} // RVA: 0x7A864C880
        public void get_vectorImageManager(){} // RVA: 0x7A8357A90
        public void set_vectorImageManager(){} // RVA: 0x7A8358860
        public void get_vertsPool(){} // RVA: 0x7A884CA70
        public void set_vertsPool(){} // RVA: 0x7A8ADA650
        public void get_indicesPool(){} // RVA: 0x7A884C460
        public void set_indicesPool(){} // RVA: 0x7A8B68960
        public void get_jobManager(){} // RVA: 0x7A8850FF0
        public void set_jobManager(){} // RVA: 0x7A8854900
        public void get_painter(){} // RVA: 0x7A8B63C30
        public void set_painter(){} // RVA: 0x7A8B5FB80
        public void get_drawStats(){} // RVA: 0x7AF12B270
        public void set_drawStats(){} // RVA: 0x7AE71D1C0
        public void get_drawInCameras(){} // RVA: 0x7AF12B280
        public void set_drawInCameras(){} // RVA: 0x7AF12B290
        public void set_defaultShader(){} // RVA: 0x7AF12B2A0
        public void set_defaultWorldSpaceShader(){} // RVA: 0x7AF12B4B0
        public void GetStandardMaterial(){} // RVA: 0x7AF12B6C0
        public void GetStandardWorldSpaceMaterial(){} // RVA: 0x7AF12B950
        public void EnsureFitsDepth(){} // RVA: 0x7AF12BBE0
        public void ChildWillBeRemoved(){} // RVA: 0x7AF12BBF0
        public void AllocCommand(){} // RVA: 0x7AF12BCB0
        public void FreeCommand(){} // RVA: 0x7AF12BD10
        public void OnRenderCommandAdded(){} // RVA: 0x7AF12BE30
        public void OnRenderCommandsRemoved(){} // RVA: 0x7AF12BF70
        public void AccessRenderNodeData(){} // RVA: 0x7AF12BFE0
        public void OnRenderNodeExecute(){} // RVA: 0x7AF12C170
        public void OnRegisterIntermediateRenderers(){} // RVA: 0x7AF12C3C0
        public void OnRegisterIntermediateRendererMat(){} // RVA: 0x7AF12CD50
        public void RepaintTexturedElements(){} // RVA: 0x7AF12D2D0
        public void AppendTexture(){} // RVA: 0x7AF12D420
        public void ResetTextures(){} // RVA: 0x7AF12D5E0
        public void DrawStats(){} // RVA: 0x7AF12D760
        public void GetFirstElementInPanel(){} // RVA: 0x7AF12E230
    }

    public class RenderChainCommand : LinkedPoolItem`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7AF121A90
        public void ExecuteNonDrawMesh(){} // RVA: 0x7AF121C40
        public void Blit(){} // RVA: 0x7AF1230C0
        public void CombineScissorRects(){} // RVA: 0x7AF123510
        public void RectPointsToPixelsAndFlipYAxis(){} // RVA: 0x7AF123680
        public void .ctor(){} // RVA: 0x7AF1237D0
        public void .cctor(){} // RVA: 0x7AF123800
    }

    public class RenderChainVEData : ValueType
    {
        // ── Methods ──
        public void get_lastClosingOrLastCommand(){} // RVA: 0x7A7EFF2D0
        public void AllocatesID(){} // RVA: 0x7AF12F070
        public void InheritsID(){} // RVA: 0x7AF12F0D0
        public void get_isIgnoringDynamicColorHint(){} // RVA: 0x7A7EFF2E0
    }

    public class ShaderInfoStorageRGBA32 : ShaderInfoStorage`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF12F350
        public void .cctor(){} // RVA: 0x7AF12F400
    }

    public class ShaderInfoStorageRGBAFloat : ShaderInfoStorage`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF12F690
        public void .cctor(){} // RVA: 0x7AF12F740
    }

    public class ShaderInfoStorage`1 : BaseShaderInfoStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1BAC0
        public void Dispose(){} // RVA: 0x7A7E18C30
        public void get_texture(){} // RVA: 0x7A7E00680
        public void AllocateRect(){} // RVA: 0x7A7E02D30
        public void SetTexel(){} // RVA: 0x7A7E1A4C0
        public void UpdateTexture(){} // RVA: 0x7A7E18770
        public void CreateOrExpandTexture(){} // RVA: 0x7A7E18770
        public void CpuBlit(){} // RVA: 0x7A8051B10
    }

    public class ShaderInfoStorage`1 : BaseShaderInfoStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABE0E620
        public void Dispose(){} // RVA: 0x7ABE0E820
        public void get_texture(){} // RVA: 0x7A8292C30
        public void AllocateRect(){} // RVA: 0x7ABE0E980
        public void SetTexel(){} // RVA: 0x7ABE0EB20
        public void UpdateTexture(){} // RVA: 0x7ABE0EC10
        public void CreateOrExpandTexture(){} // RVA: 0x7ABE0ED30
        public void CpuBlit(){} // RVA: 0x7ABE0F2C0
    }

    public class ShaderInfoStorage`1 : BaseShaderInfoStorage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABE0D850
        public void Dispose(){} // RVA: 0x7ABE0DA50
        public void get_texture(){} // RVA: 0x7A8292C30
        public void AllocateRect(){} // RVA: 0x7ABE0DBB0
        public void SetTexel(){} // RVA: 0x7ABE0DD50
        public void UpdateTexture(){} // RVA: 0x7ABE0DE50
        public void CreateOrExpandTexture(){} // RVA: 0x7ABE0DF70
        public void CpuBlit(){} // RVA: 0x7ABE0E510
    }

    public class Shaders : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF12F9B0
    }

    public class TempAllocator`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1AD90
        public void get_disposed(){} // RVA: 0x7A7E01900
        public void set_disposed(){} // RVA: 0x7A7E18C30
        public void Dispose(){} // RVA: 0x7A7E18C30
        public void Alloc(){} // RVA: 0x7A8051B10
        public void Reset(){} // RVA: 0x7A7E18770
        public void ReleaseExcess(){} // RVA: 0x7A7E18770
    }

    public class TextCoreSettings : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7EFF3C0
        public void GetHashCode(){} // RVA: 0x7A7EFF400
    }

    public class TextureBlitter : Object
    {
        // ── Methods ──
        public void get_disposed(){} // RVA: 0x7A818F850
        public void set_disposed(){} // RVA: 0x7A818F860
        public void Dispose(){} // RVA: 0x7AF1303E0
        public void .cctor(){} // RVA: 0x7AF1304A0
        public void .ctor(){} // RVA: 0x7AF130720
        public void QueueBlit(){} // RVA: 0x7AF130870
        public void BlitOneNow(){} // RVA: 0x7AF1309D0
        public void Commit(){} // RVA: 0x7AF130B80
        public void BeginBlit(){} // RVA: 0x7AF130C80
        public void DoBlit(){} // RVA: 0x7AF1311B0
        public void EndBlit(){} // RVA: 0x7AF131C60
    }

    public class TextureSlotManager : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF131D40
        public void .ctor(){} // RVA: 0x7AF132020
        public void Reset(){} // RVA: 0x7AF1322D0
        public void StartNewBatch(){} // RVA: 0x7AF132430
        public void IndexOf(){} // RVA: 0x7AF1324A0
        public void MarkUsed(){} // RVA: 0x7AF120B60
        public void get_FreeSlots(){} // RVA: 0x7A8133100
        public void set_FreeSlots(){} // RVA: 0x7A8133110
        public void FindOldestSlot(){} // RVA: 0x7AF132590
        public void Bind(){} // RVA: 0x7AF132660
        public void SetGpuData(){} // RVA: 0x7AF132950
    }

    public class UIRVEShaderInfoAllocator : ValueType
    {
        // ── Methods ──
        public void get_pageWidth(){} // RVA: 0x7AF1351C0
        public void get_pageHeight(){} // RVA: 0x7AF1351D0
        public void AllocToTexelCoord(){} // RVA: 0x7AF1351E0
        public void AllocToConstantBufferIndex(){} // RVA: 0x7AF135290
        public void AtlasRectMatchesPage(){} // RVA: 0x7AF1352F0
        public void get_transformConstants(){} // RVA: 0x7A7EFF6F0
        public void get_clipRectConstants(){} // RVA: 0x7A7EFF720
        public void get_atlas(){} // RVA: 0x7A7EFF750
        public void Construct(){} // RVA: 0x7A7EFF760
        public void ReallyCreateStorage(){} // RVA: 0x7A7EFF770
        public void Dispose(){} // RVA: 0x7A7EFF780
        public void IssuePendingStorageChanges(){} // RVA: 0x7A7EFF790
        public void AllocTransform(){} // RVA: 0x7A7EFF7B0
        public void AllocClipRect(){} // RVA: 0x7A7EFF7C0
        public void AllocOpacity(){} // RVA: 0x7A7EFF7D0
        public void AllocColor(){} // RVA: 0x7A7EFF7E0
        public void AllocTextCoreSettings(){} // RVA: 0x7A7EFF7F0
        public void SetTransformValue(){} // RVA: 0x7A7EFF860
        public void SetClipRectValue(){} // RVA: 0x7A7EFF8A0
        public void SetOpacityValue(){} // RVA: 0x7A7EFF8C0
        public void SetColorValue(){} // RVA: 0x7A7EFF8D0
        public void SetTextCoreSettingValue(){} // RVA: 0x7A7EFF900
        public void FreeTransform(){} // RVA: 0x7A7EFF950
        public void FreeClipRect(){} // RVA: 0x7A7EFF960
        public void FreeOpacity(){} // RVA: 0x7A7EFF970
        public void FreeColor(){} // RVA: 0x7A7EFF980
        public void FreeTextCoreSettings(){} // RVA: 0x7A7EFF990
        public void TransformAllocToVertexData(){} // RVA: 0x7A7EFF9A0
        public void ClipRectAllocToVertexData(){} // RVA: 0x7A7EFF9B0
        public void OpacityAllocToVertexData(){} // RVA: 0x7A7EFF9C0
        public void ColorAllocToVertexData(){} // RVA: 0x7A7EFF9D0
        public void TextCoreSettingsToVertexData(){} // RVA: 0x7A7EFF9E0
        public void .cctor(){} // RVA: 0x7AF137EC0
    }

    public class UIRenderDevice : Object
    {
        // ── Methods ──
        public void get_maxVerticesPerPage(){} // RVA: 0x7A8A69800
        public void get_breakBatches(){} // RVA: 0x7AF116060
        public void set_breakBatches(){} // RVA: 0x7AF116070
        public void .cctor(){} // RVA: 0x7AF116080
        public void .ctor(){} // RVA: 0x7AF116890
        public void get_defaultShaderInfoTexFloat(){} // RVA: 0x7AF117380
        public void get_defaultShaderInfoTexARGB8(){} // RVA: 0x7AF117AC0
        public void get_vertexTexturingIsAvailable(){} // RVA: 0x7AF118000
        public void get_shaderModelIs35(){} // RVA: 0x7AF1182D0
        public void InitVertexDeclaration(){} // RVA: 0x7AF1185A0
        public void CompleteCreation(){} // RVA: 0x7AF118750
        public void get_fullyCreated(){} // RVA: 0x7AF1189E0
        public void get_disposed(){} // RVA: 0x7AF1189F0
        public void set_disposed(){} // RVA: 0x7AF118A00
        public void Dispose(){} // RVA: 0x7AF118A80
        public void Allocate(){} // RVA: 0x7AF119820
        public void Update(){} // RVA: 0x7AF119000
        public void UpdateCopyBackIndices(){} // RVA: 0x7AF1193A0
        public void ActiveUpdatesForMeshHandle(){} // RVA: 0x7AF119550
        public void TryAllocFromPage(){} // RVA: 0x7AF1195F0
        public void UpdateAfterGPUUsedData(){} // RVA: 0x7AF11A260
        public void Free(){} // RVA: 0x7AF11AD80
        public void OnFrameRenderingBegin(){} // RVA: 0x7AF11B960
        public void PtrToSlice(){} // RVA: 0x7A8051B10
        public void ApplyDrawCommandState(){} // RVA: 0x7AF11BA10
        public void ApplyBatchState(){} // RVA: 0x7AF11BC20
        public void EvaluateChain(){} // RVA: 0x7AF11BE40
        public void UpdateFenceValue(){} // RVA: 0x7AF11CF60
        public void KickRanges(){} // RVA: 0x7AF11D050
        public void DrawRanges(){} // RVA: 0x7A8051B10
        public void WaitOnCpuFence(){} // RVA: 0x7AF11D320
        public void AdvanceFrame(){} // RVA: 0x7AF11D410
        public void PruneUnusedPages(){} // RVA: 0x7AF11E350
        public void PrepareForGfxDeviceRecreate(){} // RVA: 0x7AF11E5D0
        public void WrapUpGfxDeviceRecreate(){} // RVA: 0x7AF11E930
        public void FlushAllPendingDeviceDisposes(){} // RVA: 0x7AF11E990
        public void GatherDrawStatistics(){} // RVA: 0x7AF11EA40
        public void ProcessDeviceFreeQueue(){} // RVA: 0x7AF11EA60
        public void OnEngineUpdateGlobal(){} // RVA: 0x7AF11F070
        public void OnFlushPendingResources(){} // RVA: 0x7AF11F0C0
    }

    public class Utility : Object
    {
        // ── Methods ──
        public void SetVectorArray(){} // RVA: 0x7AF113B10
        public void add_GraphicsResourcesRecreate(){} // RVA: 0x7AF112870
        public void remove_GraphicsResourcesRecreate(){} // RVA: 0x7AF1129D0
        public void add_EngineUpdate(){} // RVA: 0x7AF112B30
        public void remove_EngineUpdate(){} // RVA: 0x7AF112C80
        public void add_FlushPendingResources(){} // RVA: 0x7AF112DD0
        public void remove_FlushPendingResources(){} // RVA: 0x7AF112F20
        public void add_RegisterIntermediateRenderers(){} // RVA: 0x7AF113070
        public void remove_RegisterIntermediateRenderers(){} // RVA: 0x7AF1131E0
        public void add_RenderNodeExecute(){} // RVA: 0x7AF113350
        public void remove_RenderNodeExecute(){} // RVA: 0x7AF1134C0
        public void RaiseGraphicsResourcesRecreate(){} // RVA: 0x7AF113630
        public void RaiseEngineUpdate(){} // RVA: 0x7AF1136B0
        public void RaiseFlushPendingResources(){} // RVA: 0x7AF113750
        public void RaiseRegisterIntermediateRenderers(){} // RVA: 0x7AF1137C0
        public void RaiseRenderNodeAdd(){} // RVA: 0x7AF113840
        public void RaiseRenderNodeExecute(){} // RVA: 0x7AF1138C0
        public void RaiseRenderNodeCleanup(){} // RVA: 0x7AF113940
        public void AllocateBuffer(){} // RVA: 0x7AF1139C0
        public void FreeBuffer(){} // RVA: 0x7AF113A30
        public void UpdateBufferRanges(){} // RVA: 0x7AF113A80
        public void GetVertexDeclaration(){} // RVA: 0x7AF113B90
        public void RegisterIntermediateRenderer(){} // RVA: 0x7AF113BE0
        public void DrawRanges(){} // RVA: 0x7AF113D00
        public void SetPropertyBlock(){} // RVA: 0x7AF113D90
        public void SetScissorRect(){} // RVA: 0x7AF113DE0
        public void DisableScissor(){} // RVA: 0x7AF113E70
        public void CreateStencilState(){} // RVA: 0x7AF113EC0
        public void SetStencilState(){} // RVA: 0x7AF113F50
        public void HasMappedBufferRange(){} // RVA: 0x7AF113FB0
        public void InsertCPUFence(){} // RVA: 0x7AF114000
        public void CPUFencePassed(){} // RVA: 0x7AF114050
        public void WaitForCPUFencePassed(){} // RVA: 0x7AF1140A0
        public void SyncRenderThread(){} // RVA: 0x7AF1140F0
        public void GetActiveViewport(){} // RVA: 0x7AF114140
        public void ProfileDrawChainBegin(){} // RVA: 0x7AF1141D0
        public void ProfileDrawChainEnd(){} // RVA: 0x7AF114220
        public void NotifyOfUIREvents(){} // RVA: 0x7AF114270
        public void GetUnityProjectionMatrix(){} // RVA: 0x7AF1142C0
        public void .cctor(){} // RVA: 0x7AF114360
        public void RegisterIntermediateRenderer_Injected(){} // RVA: 0x7AF114410
        public void SetScissorRect_Injected(){} // RVA: 0x7AF1144B0
        public void CreateStencilState_Injected(){} // RVA: 0x7AF114500
        public void GetActiveViewport_Injected(){} // RVA: 0x7AF114550
        public void GetUnityProjectionMatrix_Injected(){} // RVA: 0x7AF1145A0
    }

    public class Utility[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VectorImageManager : Object
    {
        // ── Methods ──
        public void get_atlas(){} // RVA: 0x7AF133490
        public void .ctor(){} // RVA: 0x7AF1334B0
        public void get_disposed(){} // RVA: 0x7A82A3DE0
        public void set_disposed(){} // RVA: 0x7A82A20B0
        public void Dispose(){} // RVA: 0x7AF1339F0
        public void Commit(){} // RVA: 0x7AF133B80
        public void AddUser(){} // RVA: 0x7AF133C10
        public void Register(){} // RVA: 0x7AF133D80
        public void .cctor(){} // RVA: 0x7AF134270
    }

    public class VectorImageRenderInfo : LinkedPoolItem`1
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7AF132F40
        public void .ctor(){} // RVA: 0x7AF132FA0
    }

    public class VectorImageRenderInfoPool : LinkedPool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF132B20
    }

}