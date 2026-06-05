// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.UIR.Implementation
// Classes: 3
// Methods: 89

namespace ThirdParty.Unity.UnityEngine.UIElements.UIR.Implementation
{
    public class CommandGenerator
    {
        // ── Methods ──
        public void GetVerticesTransformInfo(){} // RVA: 0x7FFAF9E07E80
        public void ComputeTransformMatrix(){} // RVA: 0x7FFAF9E08080
        public void IsParentOrAncestorOf(){} // RVA: 0x7FFAF9E081F0
        public void PaintElement(){} // RVA: 0x7FFAF9E08240
        public void InvokeGenerateVisualContent(){} // RVA: 0x7FFAF9E09C30
        public void CreateBlitShader(){} // RVA: 0x7FFAF9E09D30
        public void GetBlitMaterial(){} // RVA: 0x7FFAF9E0A100
        public void ClosePaintElement(){} // RVA: 0x7FFAF9E0A5A0
        public void UpdateOrAllocate(){} // RVA: 0x7FFAF9E0A820
        public void UpdateOpacityId(){} // RVA: 0x7FFAF9E0AA20
        public void DoUpdateOpacityId(){} // RVA: 0x7FFAF9E0AAF0
        public void NudgeVerticesToNewSpace(){} // RVA: 0x7FFAF9E0ACB0
        public void PrepareNudgeVertices(){} // RVA: 0x7FFAF9E0B2F0
        public void InjectMeshDrawCommand(){} // RVA: 0x7FFAF9E0B420
        public void InjectClosingMeshDrawCommand(){} // RVA: 0x7FFAF9E0B6B0
        public void FindCommandInsertionPoint(){} // RVA: 0x7FFAF9E0B940
        public void FindClosingCommandInsertionPoint(){} // RVA: 0x7FFAF9E0BDD0
        public void InjectCommandInBetween(){} // RVA: 0x7FFAF9E0C290
        public void InjectClosingCommandInBetween(){} // RVA: 0x7FFAF9E0C610
        public void ResetCommands(){} // RVA: 0x7FFAF9E0C9C0
        public void .cctor(){} // RVA: 0x7FFAF9E0D020
    }

    public class RenderEvents
    {
        // ── Methods ──
        public void ProcessOnClippingChanged(){} // RVA: 0x7FFAF9E0D570
        public void ProcessOnOpacityChanged(){} // RVA: 0x7FFAF9E0D690
        public void ProcessOnColorChanged(){} // RVA: 0x7FFAF9E0D790
        public void ProcessOnTransformOrSizeChanged(){} // RVA: 0x7FFAF9E0D820
        public void ProcessOnVisualsChanged(){} // RVA: 0x7FFAF9E0D900
        public void GetTransformIDTransformInfo(){} // RVA: 0x7FFAF9E0DA50
        public void GetClipRectIDClipInfo(){} // RVA: 0x7FFAF9E0DC30
        public void DepthFirstOnChildAdded(){} // RVA: 0x7FFAF9E0DED0
        public void DepthFirstOnChildRemoving(){} // RVA: 0x7FFAF9E0EAC0
        public void DepthFirstOnClippingChanged(){} // RVA: 0x7FFAF9E0F830
        public void DepthFirstOnOpacityChanged(){} // RVA: 0x7FFAF9E0FF00
        public void OnColorChanged(){} // RVA: 0x7FFAF9E10440
        public void DepthFirstOnTransformOrSizeChanged(){} // RVA: 0x7FFAF9E106F0
        public void DepthFirstOnVisualsChanged(){} // RVA: 0x7FFAF9E10E40
        public void UpdateTextCoreSettings(){} // RVA: 0x7FFAF9E11420
        public void IsElementHierarchyHidden(){} // RVA: 0x7FFAF9E119F0
        public void GetLastDeepestChild(){} // RVA: 0x7FFAF9E11A50
        public void DetermineSelfClipMethod(){} // RVA: 0x7FFAF9E11B90
        public void UpdateLocalFlipsWinding(){} // RVA: 0x7FFAF9E11D60
        public void UpdateWorldFlipsWinding(){} // RVA: 0x7FFAF9E11E50
        public void UpdateZeroScaling(){} // RVA: 0x7FFAF9E11EA0
        public void NeedsTransformID(){} // RVA: 0x7FFAF9E11FA0
        public void NeedsColorID(){} // RVA: 0x7FFAF9E11FD0
        public void NeedsTextCoreSettings(){} // RVA: 0x7FFAF9E11FF0
        public void InitColorIDs(){} // RVA: 0x7FFAF9E120D0
        public void SetColorValues(){} // RVA: 0x7FFAF9E12590
        public void .cctor(){} // RVA: 0x7FFAF9E12A00
    }

    public class UIRStylePainter
    {
        // ── Methods ──
        public void GetPooledMeshWriteData(){} // RVA: 0x7FFAF9E12A40
        public void AllocRawVertsIndices(){} // RVA: 0x7FFAF9E12B30
        public void AllocThroughDrawMesh(){} // RVA: 0x7FFAF9E12C20
        public void .ctor(){} // RVA: 0x7FFAF9E12C50
        public void get_meshGenerationContext(){} // RVA: 0x7FFAF35402E0
        public void get_currentElement(){} // RVA: 0x7FFAF2FB7710
        public void set_currentElement(){} // RVA: 0x7FFAF2FB9930
        public void get_entries(){} // RVA: 0x7FFAF59BF420
        public void get_closingInfo(){} // RVA: 0x7FFAF9E13350
        public void get_totalVertices(){} // RVA: 0x7FFAF3E7BAD0
        public void set_totalVertices(){} // RVA: 0x7FFAF3E87860
        public void get_totalIndices(){} // RVA: 0x7FFAF9E13390
        public void set_totalIndices(){} // RVA: 0x7FFAF9E133A0
        public void Begin(){} // RVA: 0x7FFAF9E133B0
        public void LandClipUnregisterMeshDrawCommand(){} // RVA: 0x7FFAF9E13BF0
        public void LandClipRegisterMesh(){} // RVA: 0x7FFAF9E13CC0
        public void DrawMesh(){} // RVA: 0x7FFAF9E13D70
        public void TryAtlasTexture(){} // RVA: 0x7FFAF9E14370
        public void BuildEntryFromNativeMesh(){} // RVA: 0x7FFAF9E145C0
        public void BuildGradientEntryFromNativeMesh(){} // RVA: 0x7FFAF9E14B10
        public void BuildRawEntryFromNativeMesh(){} // RVA: 0x7FFAF9E14F40
        public void DrawText(){} // RVA: 0x7FFAF9E151B0
        public void DrawTextInfo(){} // RVA: 0x7FFAF9E15280
        public void DrawRectangle(){} // RVA: 0x7FFAF9E159F0
        public void DrawBorder(){} // RVA: 0x7FFAF9E16480
        public void DrawImmediate(){} // RVA: 0x7FFAF9E165D0
        public void get_visualElement(){} // RVA: 0x7FFAF9E16850
        public void DrawVisualElementBackground(){} // RVA: 0x7FFAF9E16860
        public void DrawRectangleRepeat(){} // RVA: 0x7FFAF9E181E0
        public void StampRectangleWithSubRect(){} // RVA: 0x7FFAF9E1A450
        public void DrawVisualElementBorder(){} // RVA: 0x7FFAF9E1A8D0
        public void ApplyVisualElementClipping(){} // RVA: 0x7FFAF9E1B0A0
        public void AdjustSpriteWinding(){} // RVA: 0x7FFAF9E1B390
        public void DrawSprite(){} // RVA: 0x7FFAF9E1B760
        public void ApplyInset(){} // RVA: 0x7FFAF9E1C2D0
        public void DrawVectorImage(){} // RVA: 0x7FFAF9E1C600
        public void MakeVectorGraphics(){} // RVA: 0x7FFAF9E1CD70
        public void Reset(){} // RVA: 0x7FFAF9E1DA80
        public void ValidateMeshWriteData(){} // RVA: 0x7FFAF9E1DB80
        public void GenerateStencilClipEntryForRoundedRectBackground(){} // RVA: 0x7FFAF9E1DF90
        public void GenerateStencilClipEntryForSVGBackground(){} // RVA: 0x7FFAF9E1E890
    }

}