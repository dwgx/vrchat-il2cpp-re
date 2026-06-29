// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 8
// Methods: 47

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class MaxAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A82023D0
    }

    public class MeshUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AED25580
        public void GetColliderMesh(){} // RVA: 0x7AED25960
        public void GetPrimitive(){} // RVA: 0x7AED25B50
        public void GetBuiltinMesh(){} // RVA: 0x7AED25D80
    }

    public class MinAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A82023D0
    }

    public class MinMaxAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8E597B0
        public void min(){} // RVA: 0x7B3FAD6B8
    }

    public class Monitor : Object
    {
        // ── Methods ──
        public void get_output(){} // RVA: 0x7A80F2570
        public void set_output(){} // RVA: 0x7A80D8E20
        public void IsRequestedAndSupported(){} // RVA: 0x7AED0C8F0
        public void ShaderResourcesAvailable(){} // RVA: 0x7A7E019D0
        public void NeedsHalfRes(){} // RVA: 0x7A80D7320
        public void CheckOutput(){} // RVA: 0x7AED0C9E0
        public void OnEnable(){} // RVA: 0x7A80D7310
        public void OnDisable(){} // RVA: 0x7AED0CD50
        public void Render(){} // RVA: 0x7A7E18800
        public void .ctor(){} // RVA: 0x7A80D7310
        public void <output>k__BackingField(){} // RVA: 0x7B3FB4328
    }

    public class MotionBlur : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7AECFC800
        public void .ctor(){} // RVA: 0x7AECFC900
    }

    public class MotionBlurRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x7A8401A30
        public void CreateTemporaryRT(){} // RVA: 0x7AECFCA90
        public void Render(){} // RVA: 0x7AECFCB80
        public void .ctor(){} // RVA: 0x7AECFDBB0
    }

    public class MultiScaleVO : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AECFDBF0
        public void GetCameraFlags(){} // RVA: 0x7A81CA9D0
        public void SetResources(){} // RVA: 0x7A81A0060
        public void Alloc(){} // RVA: 0x7AECFE4C0
        public void AllocArray(){} // RVA: 0x7AECFE6C0
        public void Release(){} // RVA: 0x7AED03AC0
        public void CalculateZBufferParams(){} // RVA: 0x7AECFE930
        public void CalculateTanHalfFovHeight(){} // RVA: 0x7AECFEA90
        public void GetSize(){} // RVA: 0x7AECFEB20
        public void GetSizeArray(){} // RVA: 0x7AECFEB80
        public void GenerateAOMap(){} // RVA: 0x7AECFEBE0
        public void PushAllocCommands(){} // RVA: 0x7AECFF950
        public void PushDownsampleCommands(){} // RVA: 0x7AED00110
        public void PushRenderCommands(){} // RVA: 0x7AED00F00
        public void PushUpsampleCommands(){} // RVA: 0x7AED01AA0
        public void PushReleaseCommands(){} // RVA: 0x7AED021E0
        public void PreparePropertySheet(){} // RVA: 0x7AED027B0
        public void CheckAOTexture(){} // RVA: 0x7AED029F0
        public void PushDebug(){} // RVA: 0x7AED02E80
        public void RenderAfterOpaque(){} // RVA: 0x7AED02F50
        public void RenderAmbientOnly(){} // RVA: 0x7AED035A0
        public void CompositeAmbientOnly(){} // RVA: 0x7AED037E0
    }

}