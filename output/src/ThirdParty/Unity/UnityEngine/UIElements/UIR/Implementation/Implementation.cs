// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.UIR.Implementation
// Classes: 3
// Methods: 89

namespace ThirdParty.Unity.UnityEngine.UIElements.UIR.Implementation
{
    public class CommandGenerator
    {
        // ── Methods ──
        public void GetVerticesTransformInfo(){} // RVA: 0x7357E80
        public void ComputeTransformMatrix(){} // RVA: 0x7358080
        public void IsParentOrAncestorOf(){} // RVA: 0x73581F0
        public void PaintElement(){} // RVA: 0x7358240
        public void InvokeGenerateVisualContent(){} // RVA: 0x7359C30
        public void CreateBlitShader(){} // RVA: 0x7359D30
        public void GetBlitMaterial(){} // RVA: 0x735A100
        public void ClosePaintElement(){} // RVA: 0x735A5A0
        public void UpdateOrAllocate(){} // RVA: 0x735A820
        public void UpdateOpacityId(){} // RVA: 0x735AA20
        public void DoUpdateOpacityId(){} // RVA: 0x735AAF0
        public void NudgeVerticesToNewSpace(){} // RVA: 0x735ACB0
        public void PrepareNudgeVertices(){} // RVA: 0x735B2F0
        public void InjectMeshDrawCommand(){} // RVA: 0x735B420
        public void InjectClosingMeshDrawCommand(){} // RVA: 0x735B6B0
        public void FindCommandInsertionPoint(){} // RVA: 0x735B940
        public void FindClosingCommandInsertionPoint(){} // RVA: 0x735BDD0
        public void InjectCommandInBetween(){} // RVA: 0x735C290
        public void InjectClosingCommandInBetween(){} // RVA: 0x735C610
        public void ResetCommands(){} // RVA: 0x735C9C0
        public void .cctor(){} // RVA: 0x735D020
    }

    public class RenderEvents
    {
        // ── Methods ──
        public void ProcessOnClippingChanged(){} // RVA: 0x735D570
        public void ProcessOnOpacityChanged(){} // RVA: 0x735D690
        public void ProcessOnColorChanged(){} // RVA: 0x735D790
        public void ProcessOnTransformOrSizeChanged(){} // RVA: 0x735D820
        public void ProcessOnVisualsChanged(){} // RVA: 0x735D900
        public void GetTransformIDTransformInfo(){} // RVA: 0x735DA50
        public void GetClipRectIDClipInfo(){} // RVA: 0x735DC30
        public void DepthFirstOnChildAdded(){} // RVA: 0x735DED0
        public void DepthFirstOnChildRemoving(){} // RVA: 0x735EAC0
        public void DepthFirstOnClippingChanged(){} // RVA: 0x735F830
        public void DepthFirstOnOpacityChanged(){} // RVA: 0x735FF00
        public void OnColorChanged(){} // RVA: 0x7360440
        public void DepthFirstOnTransformOrSizeChanged(){} // RVA: 0x73606F0
        public void DepthFirstOnVisualsChanged(){} // RVA: 0x7360E40
        public void UpdateTextCoreSettings(){} // RVA: 0x7361420
        public void IsElementHierarchyHidden(){} // RVA: 0x73619F0
        public void GetLastDeepestChild(){} // RVA: 0x7361A50
        public void DetermineSelfClipMethod(){} // RVA: 0x7361B90
        public void UpdateLocalFlipsWinding(){} // RVA: 0x7361D60
        public void UpdateWorldFlipsWinding(){} // RVA: 0x7361E50
        public void UpdateZeroScaling(){} // RVA: 0x7361EA0
        public void NeedsTransformID(){} // RVA: 0x7361FA0
        public void NeedsColorID(){} // RVA: 0x7361FD0
        public void NeedsTextCoreSettings(){} // RVA: 0x7361FF0
        public void InitColorIDs(){} // RVA: 0x73620D0
        public void SetColorValues(){} // RVA: 0x7362590
        public void .cctor(){} // RVA: 0x7362A00
    }

    public class UIRStylePainter
    {
        public UnityEngine.UIElements.UIR.RenderChain m_Owner; // 0x10
        public System.Collections.Generic.List`1<Entry> m_Entries; // 0x18
        public UnityEngine.UIElements.AtlasBase m_Atlas; // 0x20
        public UnityEngine.UIElements.UIR.VectorImageManager m_VectorImageManager; // 0x28
        public Entry m_CurrentEntry; // 0x30
        public ClosingInfo m_ClosingInfo; // 0x80
        public int m_MaskDepth; // 0xB8

        // ── Methods ──
        public void GetPooledMeshWriteData(){} // RVA: 0x7362A40
        public void AllocRawVertsIndices(){} // RVA: 0x7362B30
        public void AllocThroughDrawMesh(){} // RVA: 0x7362C20
        public void .ctor(){} // RVA: 0x7362C50
        public void get_meshGenerationContext(){} // RVA: 0xA902E0
        public void get_currentElement(){} // RVA: 0x507710
        public void set_currentElement(){} // RVA: 0x509930
        public void get_entries(){} // RVA: 0x2F0F420
        public void get_closingInfo(){} // RVA: 0x7363350
        public void get_totalVertices(){} // RVA: 0x13CBAD0
        public void set_totalVertices(){} // RVA: 0x13D7860
        public void get_totalIndices(){} // RVA: 0x7363390
        public void set_totalIndices(){} // RVA: 0x73633A0
        public void Begin(){} // RVA: 0x73633B0
        public void LandClipUnregisterMeshDrawCommand(){} // RVA: 0x7363BF0
        public void LandClipRegisterMesh(){} // RVA: 0x7363CC0
        public void DrawMesh(){} // RVA: 0x7363D70
        public void TryAtlasTexture(){} // RVA: 0x7364370
        public void BuildEntryFromNativeMesh(){} // RVA: 0x73645C0
        public void BuildGradientEntryFromNativeMesh(){} // RVA: 0x7364B10
        public void BuildRawEntryFromNativeMesh(){} // RVA: 0x7364F40
        public void DrawText(){} // RVA: 0x73651B0
        public void DrawTextInfo(){} // RVA: 0x7365280
        public void DrawRectangle(){} // RVA: 0x73659F0
        public void DrawBorder(){} // RVA: 0x7366480
        public void DrawImmediate(){} // RVA: 0x73665D0
        public void get_visualElement(){} // RVA: 0x7366850
        public void DrawVisualElementBackground(){} // RVA: 0x7366860
        public void DrawRectangleRepeat(){} // RVA: 0x73681E0
        public void StampRectangleWithSubRect(){} // RVA: 0x736A450
        public void DrawVisualElementBorder(){} // RVA: 0x736A8D0
        public void ApplyVisualElementClipping(){} // RVA: 0x736B0A0
        public void AdjustSpriteWinding(){} // RVA: 0x736B390
        public void DrawSprite(){} // RVA: 0x736B760
        public void ApplyInset(){} // RVA: 0x736C2D0
        public void DrawVectorImage(){} // RVA: 0x736C600
        public void MakeVectorGraphics(){} // RVA: 0x736CD70
        public void Reset(){} // RVA: 0x736DA80
        public void ValidateMeshWriteData(){} // RVA: 0x736DB80
        public void GenerateStencilClipEntryForRoundedRectBackground(){} // RVA: 0x736DF90
        public void GenerateStencilClipEntryForSVGBackground(){} // RVA: 0x736E890
    }

}