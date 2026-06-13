// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Experimental.Rendering
// Classes: 5
// Methods: 48

namespace ThirdParty.Unity.UnityEngine.Experimental.Rendering
{
    public class BuiltinRuntimeReflectionSystem
    {
        // ── Methods ──
        public void TickRealtimeProbes(){} // RVA: 0x7168010
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void BuiltinUpdate(){} // RVA: 0x7168010
        public void Internal_BuiltinRuntimeReflectionSystem_New(){} // RVA: 0x7168060
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class GraphicsFormatUtility
    {
        // ── Methods ──
        public void GetFormat(){} // RVA: 0x71683E0
        public void GetGraphicsFormat(){} // RVA: 0x7168710 | overloaded x3
        public void GetGraphicsFormat_Native_TextureFormat(){} // RVA: 0x71684D0
        public void GetTextureFormat(){} // RVA: 0x7168530
        public void GetTextureFormat_Native_GraphicsFormat(){} // RVA: 0x71685C0
        public void GetGraphicsFormat_Native_RenderTextureFormat(){} // RVA: 0x71686B0
        public void GetDepthStencilFormatFromBitsLegacy_Native(){} // RVA: 0x71687D0
        public void GetDepthStencilFormat(){} // RVA: 0x7168900 | overloaded x2
        public void GetDepthBits(){} // RVA: 0x71688B0
        public void IsSRGBFormat(){} // RVA: 0x7168BE0
        public void GetSRGBFormat(){} // RVA: 0x7168C30
        public void GetLinearFormat(){} // RVA: 0x7168C80
        public void GetRenderTextureFormat(){} // RVA: 0x7168CD0
        public void IsCompressedFormat_Native_TextureFormat(){} // RVA: 0x7168D20
        public void IsCompressedFormat(){} // RVA: 0x7168D70
        public void CanDecompressFormat(){} // RVA: 0x7168E60 | overloaded x2
        public void HasAlphaChannel(){} // RVA: 0x7168F90 | overloaded x2
        public void HasAlphaChannel_Native_TextureFormat(){} // RVA: 0x7168F40
        public void IsDepthStencilFormat(){} // RVA: 0x7169020
        public void IsPVRTCFormat(){} // RVA: 0x7169070
        public void IsCrunchFormat(){} // RVA: 0x71690C0
        public void GetBlockSize(){} // RVA: 0x7169160 | overloaded x2
        public void GetBlockWidth(){} // RVA: 0x7169250 | overloaded x2
        public void GetBlockHeight(){} // RVA: 0x7169340 | overloaded x2
        public void .cctor(){} // RVA: 0x71693E0
    }

    public class IScriptableRuntimeReflectionSystem
    {
        // ── Methods ──
        public void TickRealtimeProbes(){} // RVA: 0xDBE0
    }

    public class ScriptableRuntimeReflectionSystemSettings
    {
        public UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper implementation;

        // ── Methods ──
        public void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(){} // RVA: 0x71680A0
        public void get_Internal_ScriptableRuntimeReflectionSystemSettings_instance(){} // RVA: 0x7168210
        public void ScriptingDirtyReflectionSystemInstance(){} // RVA: 0x7168270
        public void .cctor(){} // RVA: 0x71682C0
    }

    public class ScriptableRuntimeReflectionSystemWrapper
    {
        public UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem <implementation>k__BackingField; // 0x10

        // ── Methods ──
        public void get_implementation(){} // RVA: 0x2F8380
        public void set_implementation(){} // RVA: 0x2DEE30
        public void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(){} // RVA: 0x7168370
        public void .ctor(){} // RVA: 0x2DD310
    }

}