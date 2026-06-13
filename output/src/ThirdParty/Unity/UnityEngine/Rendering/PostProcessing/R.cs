// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 1
// Methods: 61

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class RuntimeUtilities
    {
        public UnityEngine.Texture2D m_WhiteTexture;
        public UnityEngine.Texture3D m_WhiteTexture3D; // 0x8
        public UnityEngine.Texture2D m_BlackTexture; // 0x10
        public UnityEngine.Texture3D m_BlackTexture3D; // 0x18
        public UnityEngine.Texture2D m_TransparentTexture; // 0x20
        public UnityEngine.Texture3D m_TransparentTexture3D; // 0x28
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.Texture2D> m_LutStrips; // 0x30
        public UnityEngine.Rendering.PostProcessing.PostProcessResources s_Resources; // 0x38
        public UnityEngine.Mesh s_FullscreenTriangle; // 0x40
        public UnityEngine.Material s_CopyStdMaterial; // 0x48
        public UnityEngine.Material s_CopyStdFromDoubleWideMaterial; // 0x50
        public UnityEngine.Material s_CopyMaterial; // 0x58
        public UnityEngine.Material s_CopyFromTexArrayMaterial; // 0x60
        public UnityEngine.Rendering.PostProcessing.PropertySheet s_CopySheet; // 0x68
        public UnityEngine.Rendering.PostProcessing.PropertySheet s_CopyFromTexArraySheet; // 0x70
        public System.Collections.Generic.IEnumerable`1<System.Type> m_AssemblyTypes; // 0x78

        // ── Methods ──
        public void get_whiteTexture(){} // RVA: 0x6F48330
        public void get_whiteTexture3D(){} // RVA: 0x6F485E0
        public void get_blackTexture(){} // RVA: 0x6F488B0
        public void get_blackTexture3D(){} // RVA: 0x6F48B70
        public void get_transparentTexture(){} // RVA: 0x6F48E40
        public void get_transparentTexture3D(){} // RVA: 0x6F49100
        public void GetLutStrip(){} // RVA: 0x6F493D0
        public void get_fullscreenTriangle(){} // RVA: 0x6F49850
        public void get_copyStdMaterial(){} // RVA: 0x6F49D60
        public void get_copyStdFromDoubleWideMaterial(){} // RVA: 0x6F49FF0
        public void get_copyMaterial(){} // RVA: 0x6F4A280
        public void get_copyFromTexArrayMaterial(){} // RVA: 0x6F4A510
        public void get_copySheet(){} // RVA: 0x6F4A7A0
        public void get_copyFromTexArraySheet(){} // RVA: 0x6F4A8F0
        public void isValidResources(){} // RVA: 0x6F4AA40
        public void UpdateResources(){} // RVA: 0x6F4AB40
        public void SetRenderTargetWithLoadStoreAction(){} // RVA: 0x6F4B0D0 | overloaded x3
        public void BlitFullscreenTriangle(){} // RVA: 0x6F4CAD0 | overloaded x5
        public void BlitFullscreenTriangleFromDoubleWide(){} // RVA: 0x6F4BB40
        public void BlitFullscreenTriangleToDoubleWide(){} // RVA: 0x6F4BD10
        public void BlitFullscreenTriangleFromTexArray(){} // RVA: 0x6F4BF90
        public void BlitFullscreenTriangleToTexArray(){} // RVA: 0x6F4C370
        public void BuiltinBlit(){} // RVA: 0x6F4CFB0 | overloaded x2
        public void CopyTexture(){} // RVA: 0x6F4D150
        public void get_scriptableRenderPipelineActive(){} // RVA: 0x6F4D3B0
        public void get_supportsDeferredShading(){} // RVA: 0x6F4D480
        public void get_supportsDepthNormals(){} // RVA: 0x6F4D520
        public void get_isSinglePassStereoEnabled(){} // RVA: 0x6F4D5C0
        public void get_isVREnabled(){} // RVA: 0x6F4D660
        public void get_isAndroidOpenGL(){} // RVA: 0x6F4D6B0
        public void get_isWebNonWebGPU(){} // RVA: 0x6F4D780
        public void get_defaultHDRRenderTextureFormat(){} // RVA: 0x1730F70
        public void isFloatingPointFormat(){} // RVA: 0x6F4D810
        public void hasAlpha(){} // RVA: 0x6F4D830
        public void Destroy(){} // RVA: 0x6F4D8D0
        public void get_isLinearColorSpace(){} // RVA: 0x6F4D9C0
        public void IsResolvedDepthAvailable(){} // RVA: 0x6F4DA10
        public void DestroyProfile(){} // RVA: 0x6F4DAF0
        public void DestroyVolume(){} // RVA: 0x6F4DCC0
        public void IsPostProcessingActive(){} // RVA: 0x6F4DDE0
        public void IsTemporalAntialiasingActive(){} // RVA: 0x6F4DEF0
        public void IsDynamicResolutionEnabled(){} // RVA: 0x6F4E050
        public void GetAllSceneObjects(){} // RVA: 0xC960
        public void CreateIfNull(){} // RVA: 0x24AE0
        public void Exp2(){} // RVA: 0x6F4E260
        public void GetJitteredPerspectiveProjectionMatrix(){} // RVA: 0x6F4E270
        public void GetJitteredOrthographicProjectionMatrix(){} // RVA: 0x6F4E590
        public void GenerateJitteredProjectionMatrixFromOriginal(){} // RVA: 0x6F4E8E0
        public void GetAllAssemblyTypes(){} // RVA: 0x6F4EAC0
        public void GetAllTypesDerivedFrom(){} // RVA: 0xC960
        public void GetAttribute(){} // RVA: 0x283FA0
        public void GetMemberAttributes(){} // RVA: 0xCE50
        public void GetFieldPath(){} // RVA: 0xCE50
        public void .cctor(){} // RVA: 0x6F4ED80
    }

}