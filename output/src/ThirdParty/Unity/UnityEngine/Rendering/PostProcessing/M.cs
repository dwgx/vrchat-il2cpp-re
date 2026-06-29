// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
// Classes: 8
// Methods: 45

namespace ThirdParty.Unity.UnityEngine.Rendering.PostProcessing
{
    public class MaxAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xC763F0
    }

    public class MeshUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7993450
        public void GetColliderMesh(){} // RVA: 0x79937C0
        public void GetPrimitive(){} // RVA: 0x7993AD0
        public void GetBuiltinMesh(){} // RVA: 0x7993C80
    }

    public class MinAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xC763F0
    }

    public class MinMaxAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1976A80
    }

    public class Monitor : Object
    {
        // ── Methods ──
        public void get_output(){} // RVA: 0xB5DBF0
        public void set_output(){} // RVA: 0xB44D60
        public void IsRequestedAndSupported(){} // RVA: 0x797AC20
        public void ShaderResourcesAvailable(){} // RVA: 0x87D350
        public void NeedsHalfRes(){} // RVA: 0xB43320
        public void CheckOutput(){} // RVA: 0x797AD10
        public void OnEnable(){} // RVA: 0xB43310
        public void OnDisable(){} // RVA: 0x797AF60
        public void Render(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MotionBlur : PostProcessEffectSettings
    {
        // ── Methods ──
        public void IsEnabledAndSupported(){} // RVA: 0x7969FA0
        public void .ctor(){} // RVA: 0x796A0A0
    }

    public class MotionBlurRenderer : PostProcessEffectRenderer`1
    {
        // ── Methods ──
        public void GetCameraFlags(){} // RVA: 0xEF4110
        public void CreateTemporaryRT(){} // RVA: 0x796A230
        public void Render(){} // RVA: 0x796A340
        public void .ctor(){} // RVA: 0x796B530
    }

    public class MultiScaleVO : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x796B570
        public void GetCameraFlags(){} // RVA: 0xC3CCE0
        public void SetResources(){} // RVA: 0xC0FFD0
        public void Alloc(){} // RVA: 0x796BE40
        public void AllocArray(){} // RVA: 0x796C070
        public void Release(){} // RVA: 0x7971FA0
        public void CalculateZBufferParams(){} // RVA: 0x796C320
        public void CalculateTanHalfFovHeight(){} // RVA: 0x796C4E0
        public void GetSize(){} // RVA: 0x796C5B0
        public void GetSizeArray(){} // RVA: 0x796C610
        public void GenerateAOMap(){} // RVA: 0x796C670
        public void PushAllocCommands(){} // RVA: 0x796D1E0
        public void PushDownsampleCommands(){} // RVA: 0x796D9A0
        public void PushRenderCommands(){} // RVA: 0x796EEA0
        public void PushUpsampleCommands(){} // RVA: 0x796FB70
        public void PushReleaseCommands(){} // RVA: 0x79707F0
        public void PreparePropertySheet(){} // RVA: 0x7970EB0
        public void CheckAOTexture(){} // RVA: 0x79710C0
        public void PushDebug(){} // RVA: 0x79713B0
        public void RenderAfterOpaque(){} // RVA: 0x7971480
        public void RenderAmbientOnly(){} // RVA: 0x7971B60
        public void CompositeAmbientOnly(){} // RVA: 0x7971D20
    }

}