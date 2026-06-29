// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.UIR.Implementation
// Classes: 3
// Methods: 89

namespace ThirdParty.Unity.UnityEngine.UIElements.UIR.Implementation
{
    public class CommandGenerator : Object
    {
        // ── Methods ──
        public void GetVerticesTransformInfo(){} // RVA: 0x7AF1381C0
        public void ComputeTransformMatrix(){} // RVA: 0x7AF1383C0
        public void IsParentOrAncestorOf(){} // RVA: 0x7AF138550
        public void PaintElement(){} // RVA: 0x7AF1385A0
        public void InvokeGenerateVisualContent(){} // RVA: 0x7AF139FD0
        public void CreateBlitShader(){} // RVA: 0x7AF13A0D0
        public void GetBlitMaterial(){} // RVA: 0x7AF13A4B0
        public void ClosePaintElement(){} // RVA: 0x7AF13A950
        public void UpdateOrAllocate(){} // RVA: 0x7AF13AC00
        public void UpdateOpacityId(){} // RVA: 0x7AF13AE00
        public void DoUpdateOpacityId(){} // RVA: 0x7AF13AED0
        public void NudgeVerticesToNewSpace(){} // RVA: 0x7AF13B1F0
        public void PrepareNudgeVertices(){} // RVA: 0x7AF13B830
        public void InjectMeshDrawCommand(){} // RVA: 0x7AF13B960
        public void InjectClosingMeshDrawCommand(){} // RVA: 0x7AF13BC10
        public void FindCommandInsertionPoint(){} // RVA: 0x7AF13BEC0
        public void FindClosingCommandInsertionPoint(){} // RVA: 0x7AF13C350
        public void InjectCommandInBetween(){} // RVA: 0x7AF13C810
        public void InjectClosingCommandInBetween(){} // RVA: 0x7AF13CB90
        public void ResetCommands(){} // RVA: 0x7AF13CF40
        public void .cctor(){} // RVA: 0x7AF13D5A0
    }

    public class RenderEvents : Object
    {
        // ── Methods ──
        public void ProcessOnClippingChanged(){} // RVA: 0x7AF13DAF0
        public void ProcessOnOpacityChanged(){} // RVA: 0x7AF13DC10
        public void ProcessOnColorChanged(){} // RVA: 0x7AF13DD10
        public void ProcessOnTransformOrSizeChanged(){} // RVA: 0x7AF13DDA0
        public void ProcessOnVisualsChanged(){} // RVA: 0x7AF13DE80
        public void GetTransformIDTransformInfo(){} // RVA: 0x7AF13DFD0
        public void GetClipRectIDClipInfo(){} // RVA: 0x7AF13E1A0
        public void DepthFirstOnChildAdded(){} // RVA: 0x7AF13E430
        public void DepthFirstOnChildRemoving(){} // RVA: 0x7AF13F020
        public void DepthFirstOnClippingChanged(){} // RVA: 0x7AF13FD10
        public void DepthFirstOnOpacityChanged(){} // RVA: 0x7AF1403D0
        public void OnColorChanged(){} // RVA: 0x7AF140910
        public void DepthFirstOnTransformOrSizeChanged(){} // RVA: 0x7AF140BC0
        public void DepthFirstOnVisualsChanged(){} // RVA: 0x7AF1412F0
        public void UpdateTextCoreSettings(){} // RVA: 0x7AF141900
        public void IsElementHierarchyHidden(){} // RVA: 0x7AF141EC0
        public void GetLastDeepestChild(){} // RVA: 0x7AF141F20
        public void DetermineSelfClipMethod(){} // RVA: 0x7AF142060
        public void UpdateLocalFlipsWinding(){} // RVA: 0x7AF142230
        public void UpdateWorldFlipsWinding(){} // RVA: 0x7AF142320
        public void UpdateZeroScaling(){} // RVA: 0x7AF142370
        public void NeedsTransformID(){} // RVA: 0x7AF142480
        public void NeedsColorID(){} // RVA: 0x7AF1424B0
        public void NeedsTextCoreSettings(){} // RVA: 0x7AF1424D0
        public void InitColorIDs(){} // RVA: 0x7AF1425C0
        public void SetColorValues(){} // RVA: 0x7AF142A80
        public void .cctor(){} // RVA: 0x7AF142EE0
    }

    public class UIRStylePainter : Object
    {
        // ── Methods ──
        public void GetPooledMeshWriteData(){} // RVA: 0x7AF142F20
        public void AllocRawVertsIndices(){} // RVA: 0x7AF143010
        public void AllocThroughDrawMesh(){} // RVA: 0x7AF143100
        public void .ctor(){} // RVA: 0x7AF143130
        public void get_meshGenerationContext(){} // RVA: 0x7A884DED0
        public void get_currentElement(){} // RVA: 0x7A884F050
        public void set_currentElement(){} // RVA: 0x7A8B5D8D0
        public void get_entries(){} // RVA: 0x7AACE3A80
        public void get_closingInfo(){} // RVA: 0x7AF143840
        public void get_totalVertices(){} // RVA: 0x7A9183130
        public void set_totalVertices(){} // RVA: 0x7A918EF30
        public void get_totalIndices(){} // RVA: 0x7AF143880
        public void set_totalIndices(){} // RVA: 0x7AF143890
        public void Begin(){} // RVA: 0x7AF1438A0
        public void LandClipUnregisterMeshDrawCommand(){} // RVA: 0x7AF144100
        public void LandClipRegisterMesh(){} // RVA: 0x7AF1441D0
        public void DrawMesh(){} // RVA: 0x7AF144280
        public void TryAtlasTexture(){} // RVA: 0x7AF1448A0
        public void BuildEntryFromNativeMesh(){} // RVA: 0x7AF144AF0
        public void BuildGradientEntryFromNativeMesh(){} // RVA: 0x7AF145040
        public void BuildRawEntryFromNativeMesh(){} // RVA: 0x7AF145480
        public void DrawText(){} // RVA: 0x7AF1456F0
        public void DrawTextInfo(){} // RVA: 0x7AF1457C0
        public void DrawRectangle(){} // RVA: 0x7AF145F00
        public void DrawBorder(){} // RVA: 0x7AF146990
        public void DrawImmediate(){} // RVA: 0x7AF146AE0
        public void get_visualElement(){} // RVA: 0x7AF146D90
        public void DrawVisualElementBackground(){} // RVA: 0x7AF146DA0
        public void DrawRectangleRepeat(){} // RVA: 0x7AF148720
        public void StampRectangleWithSubRect(){} // RVA: 0x7AF14AA30
        public void DrawVisualElementBorder(){} // RVA: 0x7AF14AEB0
        public void ApplyVisualElementClipping(){} // RVA: 0x7AF14B6A0
        public void AdjustSpriteWinding(){} // RVA: 0x7AF14B9D0
        public void DrawSprite(){} // RVA: 0x7AF14BDF0
        public void ApplyInset(){} // RVA: 0x7AF14C9B0
        public void DrawVectorImage(){} // RVA: 0x7AF14CCE0
        public void MakeVectorGraphics(){} // RVA: 0x7AF14D440
        public void Reset(){} // RVA: 0x7AF14E130
        public void ValidateMeshWriteData(){} // RVA: 0x7AF14E230
        public void GenerateStencilClipEntryForRoundedRectBackground(){} // RVA: 0x7AF14E650
        public void GenerateStencilClipEntryForSVGBackground(){} // RVA: 0x7AF14EF50
    }

}