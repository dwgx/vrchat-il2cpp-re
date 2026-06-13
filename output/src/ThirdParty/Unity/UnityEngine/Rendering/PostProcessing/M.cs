// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 8
// Methods: 46

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class MaxAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x407330
    }

    public class MeshUtilities
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6F46E30
        public void GetColliderMesh(){} // RVA: 0x6F47210
        public void GetPrimitive(){} // RVA: 0x6F47400
        public void GetBuiltinMesh(){} // RVA: 0x6F47630
    }

    public class MinAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x407330
    }

    public class MinMaxAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x10A1C60
    }

    public class Monitor
    {
        public UnityEngine.RenderTexture <output>k__BackingField; // 0x10

        // ── Methods ──
        public void get_output(){} // RVA: 0x2F8380
        public void set_output(){} // RVA: 0x2DEE30
        public void IsRequestedAndSupported(){} // RVA: 0x6F2E370
        public void ShaderResourcesAvailable(){} // RVA: 0xDE40
        public void NeedsHalfRes(){} // RVA: 0x2DD320
        public void CheckOutput(){} // RVA: 0x6F2E460
        public void OnEnable(){} // RVA: 0x2DD310
        public void OnDisable(){} // RVA: 0x6F2E7D0
        public void Render(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class MotionBlur
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x6F1E2E0
        public void .ctor(){} // RVA: 0x6F1E3E0
    }

    public class MotionBlurRenderer
    {
        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0x66CCC0
        public void CreateTemporaryRT(){} // RVA: 0x6F1E570
        public void Render(){} // RVA: 0x6F1E660
        public void .ctor(){} // RVA: 0x6F1F690
    }

    public class MultiScaleVO
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F1F6D0
        public void GetCameraFlags(){} // RVA: 0x3CFAF0
        public void SetResources(){} // RVA: 0x3A5510
        public void Alloc(){} // RVA: 0x6F1FF80
        public void AllocArray(){} // RVA: 0x6F20180
        public void Release(){} // RVA: 0x6F25550 | overloaded x2
        public void CalculateZBufferParams(){} // RVA: 0x6F203F0
        public void CalculateTanHalfFovHeight(){} // RVA: 0x6F20550
        public void GetSize(){} // RVA: 0x6F205E0
        public void GetSizeArray(){} // RVA: 0x6F20640
        public void GenerateAOMap(){} // RVA: 0x6F206A0
        public void PushAllocCommands(){} // RVA: 0x6F21410
        public void PushDownsampleCommands(){} // RVA: 0x6F21BD0
        public void PushRenderCommands(){} // RVA: 0x6F229C0
        public void PushUpsampleCommands(){} // RVA: 0x6F23520
        public void PushReleaseCommands(){} // RVA: 0x6F23C60
        public void PreparePropertySheet(){} // RVA: 0x6F24230
        public void CheckAOTexture(){} // RVA: 0x6F24470
        public void PushDebug(){} // RVA: 0x6F24900
        public void RenderAfterOpaque(){} // RVA: 0x6F249D0
        public void RenderAmbientOnly(){} // RVA: 0x6F25030
        public void CompositeAmbientOnly(){} // RVA: 0x6F25270
    }

}