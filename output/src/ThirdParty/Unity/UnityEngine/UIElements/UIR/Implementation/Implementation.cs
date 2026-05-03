// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.UIR.Implementation
// Classes: 3
// Methods: 89

namespace ThirdParty.Unity.UnityEngine.UIElements.UIR.Implementation
{
    public class CommandGenerator : Object
    {
        // ── Methods ──
        public void GetVerticesTransformInfo(){} // RVA: 0x7FFE87E98000
        public void ComputeTransformMatrix(){} // RVA: 0x7FFE87E98200
        public void IsParentOrAncestorOf(){} // RVA: 0x7FFE87E98370
        public void PaintElement(){} // RVA: 0x7FFE87E983C0
        public void InvokeGenerateVisualContent(){} // RVA: 0x7FFE87E99DB0
        public void CreateBlitShader(){} // RVA: 0x7FFE87E99EB0
        public void GetBlitMaterial(){} // RVA: 0x7FFE87E9A280
        public void ClosePaintElement(){} // RVA: 0x7FFE87E9A720
        public void UpdateOrAllocate(){} // RVA: 0x7FFE87E9A9A0
        public void UpdateOpacityId(){} // RVA: 0x7FFE87E9ABA0
        public void DoUpdateOpacityId(){} // RVA: 0x7FFE87E9AC70
        public void NudgeVerticesToNewSpace(){} // RVA: 0x7FFE87E9AE30
        public void PrepareNudgeVertices(){} // RVA: 0x7FFE87E9B470
        public void InjectMeshDrawCommand(){} // RVA: 0x7FFE87E9B5A0
        public void InjectClosingMeshDrawCommand(){} // RVA: 0x7FFE87E9B830
        public void FindCommandInsertionPoint(){} // RVA: 0x7FFE87E9BAC0
        public void FindClosingCommandInsertionPoint(){} // RVA: 0x7FFE87E9BF50
        public void InjectCommandInBetween(){} // RVA: 0x7FFE87E9C410
        public void InjectClosingCommandInBetween(){} // RVA: 0x7FFE87E9C790
        public void ResetCommands(){} // RVA: 0x7FFE87E9CB40
        public void .cctor(){} // RVA: 0x7FFE87E9D1A0
    }

    public class RenderEvents : Object
    {
        // ── Methods ──
        public void ProcessOnClippingChanged(){} // RVA: 0x7FFE87E9D6F0
        public void ProcessOnOpacityChanged(){} // RVA: 0x7FFE87E9D810
        public void ProcessOnColorChanged(){} // RVA: 0x7FFE87E9D910
        public void ProcessOnTransformOrSizeChanged(){} // RVA: 0x7FFE87E9D9A0
        public void ProcessOnVisualsChanged(){} // RVA: 0x7FFE87E9DA80
        public void GetTransformIDTransformInfo(){} // RVA: 0x7FFE87E9DBD0
        public void GetClipRectIDClipInfo(){} // RVA: 0x7FFE87E9DDB0
        public void DepthFirstOnChildAdded(){} // RVA: 0x7FFE87E9E050
        public void DepthFirstOnChildRemoving(){} // RVA: 0x7FFE87E9EC40
        public void DepthFirstOnClippingChanged(){} // RVA: 0x7FFE87E9F9B0
        public void DepthFirstOnOpacityChanged(){} // RVA: 0x7FFE87EA0080
        public void OnColorChanged(){} // RVA: 0x7FFE87EA05C0
        public void DepthFirstOnTransformOrSizeChanged(){} // RVA: 0x7FFE87EA0870
        public void DepthFirstOnVisualsChanged(){} // RVA: 0x7FFE87EA0FC0
        public void UpdateTextCoreSettings(){} // RVA: 0x7FFE87EA15A0
        public void IsElementHierarchyHidden(){} // RVA: 0x7FFE87EA1B70
        public void GetLastDeepestChild(){} // RVA: 0x7FFE87EA1BD0
        public void DetermineSelfClipMethod(){} // RVA: 0x7FFE87EA1D10
        public void UpdateLocalFlipsWinding(){} // RVA: 0x7FFE87EA1EE0
        public void UpdateWorldFlipsWinding(){} // RVA: 0x7FFE87EA1FD0
        public void UpdateZeroScaling(){} // RVA: 0x7FFE87EA2020
        public void NeedsTransformID(){} // RVA: 0x7FFE87EA2120
        public void NeedsColorID(){} // RVA: 0x7FFE87EA2150
        public void NeedsTextCoreSettings(){} // RVA: 0x7FFE87EA2170
        public void InitColorIDs(){} // RVA: 0x7FFE87EA2250
        public void SetColorValues(){} // RVA: 0x7FFE87EA2710
        public void .cctor(){} // RVA: 0x7FFE87EA2B80
    }

    public class UIRStylePainter : Object
    {
        public UnityEngine.UIElements.UIR.RenderChain m_Owner; // 0x10
        public System.Collections.Generic.List`1<Entry> m_Entries; // 0x18
        public UnityEngine.UIElements.AtlasBase m_Atlas; // 0x20
        public UnityEngine.UIElements.UIR.VectorImageManager m_VectorImageManager; // 0x28
        public Entry m_CurrentEntry; // 0x30
        public ClosingInfo m_ClosingInfo; // 0x80
        public int m_MaskDepth; // 0xB8

        // ── Methods ──
        public void GetPooledMeshWriteData(){} // RVA: 0x7FFE87EA2BC0
        public void AllocRawVertsIndices(){} // RVA: 0x7FFE87EA2CB0
        public void AllocThroughDrawMesh(){} // RVA: 0x7FFE87EA2DA0
        public void .ctor(){} // RVA: 0x7FFE87EA2DD0
        public void get_meshGenerationContext(){} // RVA: 0x7FFE8181E3D0
        public void get_currentElement(){} // RVA: 0x7FFE81317980
        public void set_currentElement(){} // RVA: 0x7FFE813159A0
        public void get_entries(){} // RVA: 0x7FFE83BBC680
        public void get_closingInfo(){} // RVA: 0x7FFE87EA34D0
        public void get_totalVertices(){} // RVA: 0x7FFE812BC010
        public void set_totalVertices(){} // RVA: 0x7FFE82BD1CF0
        public void get_totalIndices(){} // RVA: 0x7FFE87EA3510
        public void set_totalIndices(){} // RVA: 0x7FFE87EA3520
        public void Begin(){} // RVA: 0x7FFE87EA3530
        public void LandClipUnregisterMeshDrawCommand(){} // RVA: 0x7FFE87EA3D70
        public void LandClipRegisterMesh(){} // RVA: 0x7FFE87EA3E40
        public void DrawMesh(){} // RVA: 0x7FFE87EA3EF0
        public void TryAtlasTexture(){} // RVA: 0x7FFE87EA44F0
        public void BuildEntryFromNativeMesh(){} // RVA: 0x7FFE87EA4740
        public void BuildGradientEntryFromNativeMesh(){} // RVA: 0x7FFE87EA4C90
        public void BuildRawEntryFromNativeMesh(){} // RVA: 0x7FFE87EA50C0
        public void DrawText(){} // RVA: 0x7FFE87EA5330
        public void DrawTextInfo(){} // RVA: 0x7FFE87EA5400
        public void DrawRectangle(){} // RVA: 0x7FFE87EA5B70
        public void DrawBorder(){} // RVA: 0x7FFE87EA6600
        public void DrawImmediate(){} // RVA: 0x7FFE87EA6750
        public void get_visualElement(){} // RVA: 0x7FFE87EA69D0
        public void DrawVisualElementBackground(){} // RVA: 0x7FFE87EA69E0
        public void DrawRectangleRepeat(){} // RVA: 0x7FFE87EA8360
        public void StampRectangleWithSubRect(){} // RVA: 0x7FFE87EAA5D0
        public void DrawVisualElementBorder(){} // RVA: 0x7FFE87EAAA50
        public void ApplyVisualElementClipping(){} // RVA: 0x7FFE87EAB220
        public void AdjustSpriteWinding(){} // RVA: 0x7FFE87EAB510
        public void DrawSprite(){} // RVA: 0x7FFE87EAB8E0
        public void ApplyInset(){} // RVA: 0x7FFE87EAC450
        public void DrawVectorImage(){} // RVA: 0x7FFE87EAC780
        public void MakeVectorGraphics(){} // RVA: 0x7FFE87EACEF0
        public void Reset(){} // RVA: 0x7FFE87EADC00
        public void ValidateMeshWriteData(){} // RVA: 0x7FFE87EADD00
        public void GenerateStencilClipEntryForRoundedRectBackground(){} // RVA: 0x7FFE87EAE110
        public void GenerateStencilClipEntryForSVGBackground(){} // RVA: 0x7FFE87EAEA10
    }

}