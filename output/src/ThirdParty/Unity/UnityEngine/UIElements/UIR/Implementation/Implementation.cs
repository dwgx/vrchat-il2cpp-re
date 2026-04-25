// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.UIR.Implementation
// Classes: 3
// Methods: 89

namespace ThirdParty.Unity.UnityEngine.UIElements.UIR.Implementation
{
    public class CommandGenerator : Object
    {
        public Unity.Profiling.ProfilerMarker k_GenerateEntries;
        public Unity.Profiling.ProfilerMarker k_ConvertEntriesToCommandsMarker; // 0x8
        public Unity.Profiling.ProfilerMarker k_GenerateClosingCommandsMarker; // 0x10
        public Unity.Profiling.ProfilerMarker k_NudgeVerticesMarker; // 0x18
        public Unity.Profiling.ProfilerMarker k_UpdateOpacityIdMarker; // 0x20
        public Unity.Profiling.ProfilerMarker k_ComputeTransformMatrixMarker; // 0x28
        public UnityEngine.Material s_blitMaterial_LinearToGamma; // 0x30
        public UnityEngine.Material s_blitMaterial_GammaToLinear; // 0x38
        public UnityEngine.Material s_blitMaterial_NoChange; // 0x40
        public UnityEngine.Shader s_blitShader; // 0x48

        // ── Methods ──
        public void GetVerticesTransformInfo(){} // RVA: 0x7FFAC9AEF760
        public void ComputeTransformMatrix(){} // RVA: 0x7FFAC9AEF960
        public void IsParentOrAncestorOf(){} // RVA: 0x7FFAC9AEFAD0
        public void PaintElement(){} // RVA: 0x7FFAC9AEFB20
        public void InvokeGenerateVisualContent(){} // RVA: 0x7FFAC9AF1510
        public void CreateBlitShader(){} // RVA: 0x7FFAC9AF1610
        public void GetBlitMaterial(){} // RVA: 0x7FFAC9AF19E0
        public void ClosePaintElement(){} // RVA: 0x7FFAC9AF1E80
        public void UpdateOrAllocate(){} // RVA: 0x7FFAC9AF2100
        public void UpdateOpacityId(){} // RVA: 0x7FFAC9AF2300
        public void DoUpdateOpacityId(){} // RVA: 0x7FFAC9AF23D0
        public void NudgeVerticesToNewSpace(){} // RVA: 0x7FFAC9AF2590
        public void PrepareNudgeVertices(){} // RVA: 0x7FFAC9AF2BD0
        public void InjectMeshDrawCommand(){} // RVA: 0x7FFAC9AF2D00
        public void InjectClosingMeshDrawCommand(){} // RVA: 0x7FFAC9AF2F90
        public void FindCommandInsertionPoint(){} // RVA: 0x7FFAC9AF3220
        public void FindClosingCommandInsertionPoint(){} // RVA: 0x7FFAC9AF36B0
        public void InjectCommandInBetween(){} // RVA: 0x7FFAC9AF3B70
        public void InjectClosingCommandInBetween(){} // RVA: 0x7FFAC9AF3EF0
        public void ResetCommands(){} // RVA: 0x7FFAC9AF42A0
        public void .cctor(){} // RVA: 0x7FFAC9AF4900
    }

    public class RenderEvents : Object
    {
        public float VisibilityTreshold;

        // ── Methods ──
        public void ProcessOnClippingChanged(){} // RVA: 0x7FFAC9AF4E50
        public void ProcessOnOpacityChanged(){} // RVA: 0x7FFAC9AF4F70
        public void ProcessOnColorChanged(){} // RVA: 0x7FFAC9AF5070
        public void ProcessOnTransformOrSizeChanged(){} // RVA: 0x7FFAC9AF5100
        public void ProcessOnVisualsChanged(){} // RVA: 0x7FFAC9AF51E0
        public void GetTransformIDTransformInfo(){} // RVA: 0x7FFAC9AF5330
        public void GetClipRectIDClipInfo(){} // RVA: 0x7FFAC9AF5510
        public void DepthFirstOnChildAdded(){} // RVA: 0x7FFAC9AF57B0
        public void DepthFirstOnChildRemoving(){} // RVA: 0x7FFAC9AF63A0
        public void DepthFirstOnClippingChanged(){} // RVA: 0x7FFAC9AF7110
        public void DepthFirstOnOpacityChanged(){} // RVA: 0x7FFAC9AF77E0
        public void OnColorChanged(){} // RVA: 0x7FFAC9AF7D20
        public void DepthFirstOnTransformOrSizeChanged(){} // RVA: 0x7FFAC9AF7FD0
        public void DepthFirstOnVisualsChanged(){} // RVA: 0x7FFAC9AF8720
        public void UpdateTextCoreSettings(){} // RVA: 0x7FFAC9AF8D00
        public void IsElementHierarchyHidden(){} // RVA: 0x7FFAC9AF92D0
        public void GetLastDeepestChild(){} // RVA: 0x7FFAC9AF9330
        public void DetermineSelfClipMethod(){} // RVA: 0x7FFAC9AF9470
        public void UpdateLocalFlipsWinding(){} // RVA: 0x7FFAC9AF9640
        public void UpdateWorldFlipsWinding(){} // RVA: 0x7FFAC9AF9730
        public void UpdateZeroScaling(){} // RVA: 0x7FFAC9AF9780
        public void NeedsTransformID(){} // RVA: 0x7FFAC9AF9880
        public void NeedsColorID(){} // RVA: 0x7FFAC9AF98B0
        public void NeedsTextCoreSettings(){} // RVA: 0x7FFAC9AF98D0
        public void InitColorIDs(){} // RVA: 0x7FFAC9AF99B0
        public void SetColorValues(){} // RVA: 0x7FFAC9AF9E70
        public void .cctor(){} // RVA: 0x7FFAC9AFA2E0
    }

    public class UIRStylePainter : Object
    {
        public UnityEngine.UIElements.UIR.RenderChain meshGenerationContext; // 0x10
        public System.Collections.Generic.List`1<Entry> currentElement; // 0x18
        public UnityEngine.UIElements.AtlasBase entries; // 0x20
        public UnityEngine.UIElements.UIR.VectorImageManager closingInfo; // 0x28
        public Entry totalVertices; // 0x30
        public ClosingInfo totalIndices; // 0x80
        public int visualElement; // 0xB8
        public int m_StencilRef; // 0xBC
        public UnityEngine.UIElements.UIR.BMPAlloc m_ClipRectID; // 0xC0
        public int m_SVGBackgroundEntryIndex; // 0xC8
        public UnityEngine.UIElements.UIR.TempAllocator`1<UnityEngine.UIElements.Vertex> m_VertsPool; // 0xD0
        public UnityEngine.UIElements.UIR.TempAllocator`1<ushort> m_IndicesPool; // 0xD8
        public System.Collections.Generic.List`1<UnityEngine.UIElements.MeshWriteData> m_MeshWriteDataPool; // 0xE0
        public int m_NextMeshWriteDataPoolItem; // 0xE8
        public System.Collections.Generic.List`1<RepeatRectUV>[] m_RepeatRectUVList; // 0xF0
        public Allocator m_AllocRawVertsIndicesDelegate; // 0xF8
        public Allocator m_AllocThroughDrawMeshDelegate; // 0x100
        public UnityEngine.UIElements.MeshGenerationContext <meshGenerationContext>k__BackingField; // 0x108
        public UnityEngine.UIElements.VisualElement <currentElement>k__BackingField; // 0x110
        public int <totalVertices>k__BackingField; // 0x118
        public int <totalIndices>k__BackingField; // 0x11C
        public UnityEngine.TextCore.Text.TextInfo m_TextInfo; // 0x120

        // ── Methods ──
        public void GetPooledMeshWriteData(){} // RVA: 0x7FFAC9AFA320
        public void AllocRawVertsIndices(){} // RVA: 0x7FFAC9AFA410
        public void AllocThroughDrawMesh(){} // RVA: 0x7FFAC9AFA500
        public void .ctor(){} // RVA: 0x7FFAC9AFA530
        public void get_meshGenerationContext(){} // RVA: 0x7FFAC36D1F40
        public void get_currentElement(){} // RVA: 0x7FFAC354B170
        public void set_currentElement(){} // RVA: 0x7FFAC39B3E10
        public void get_entries(){} // RVA: 0x7FFAC58A1130
        public void get_closingInfo(){} // RVA: 0x7FFAC9AFAC30
        public void get_totalVertices(){} // RVA: 0x7FFAC49661E0
        public void set_totalVertices(){} // RVA: 0x7FFAC49661F0
        public void get_totalIndices(){} // RVA: 0x7FFAC9AFAC70
        public void set_totalIndices(){} // RVA: 0x7FFAC9AFAC80
        public void Begin(){} // RVA: 0x7FFAC9AFAC90
        public void LandClipUnregisterMeshDrawCommand(){} // RVA: 0x7FFAC9AFB4D0
        public void LandClipRegisterMesh(){} // RVA: 0x7FFAC9AFB5A0
        public void DrawMesh(){} // RVA: 0x7FFAC9AFB650
        public void TryAtlasTexture(){} // RVA: 0x7FFAC9AFBC50
        public void BuildEntryFromNativeMesh(){} // RVA: 0x7FFAC9AFBEA0
        public void BuildGradientEntryFromNativeMesh(){} // RVA: 0x7FFAC9AFC3F0
        public void BuildRawEntryFromNativeMesh(){} // RVA: 0x7FFAC9AFC820
        public void DrawText(){} // RVA: 0x7FFAC9AFCA90
        public void DrawTextInfo(){} // RVA: 0x7FFAC9AFCB60
        public void DrawRectangle(){} // RVA: 0x7FFAC9AFD2D0
        public void DrawBorder(){} // RVA: 0x7FFAC9AFDD60
        public void DrawImmediate(){} // RVA: 0x7FFAC9AFDEB0
        public void get_visualElement(){} // RVA: 0x7FFAC9AFE130
        public void DrawVisualElementBackground(){} // RVA: 0x7FFAC9AFE140
        public void DrawRectangleRepeat(){} // RVA: 0x7FFAC9AFFAC0
        public void StampRectangleWithSubRect(){} // RVA: 0x7FFAC9B01D30
        public void DrawVisualElementBorder(){} // RVA: 0x7FFAC9B021B0
        public void ApplyVisualElementClipping(){} // RVA: 0x7FFAC9B02980
        public void AdjustSpriteWinding(){} // RVA: 0x7FFAC9B02C70
        public void DrawSprite(){} // RVA: 0x7FFAC9B03040
        public void ApplyInset(){} // RVA: 0x7FFAC9B03BB0
        public void DrawVectorImage(){} // RVA: 0x7FFAC9B03EE0
        public void MakeVectorGraphics(){} // RVA: 0x7FFAC9B04650
        public void Reset(){} // RVA: 0x7FFAC9B05360
        public void ValidateMeshWriteData(){} // RVA: 0x7FFAC9B05460
        public void GenerateStencilClipEntryForRoundedRectBackground(){} // RVA: 0x7FFAC9B05870
        public void GenerateStencilClipEntryForSVGBackground(){} // RVA: 0x7FFAC9B06170
    }

}