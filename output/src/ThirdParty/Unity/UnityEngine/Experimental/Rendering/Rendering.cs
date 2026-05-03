// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Experimental.Rendering
// Classes: 5
// Methods: 46

namespace ThirdParty.Unity.UnityEngine.Experimental.Rendering
{
    public class BuiltinRuntimeReflectionSystem : Object
    {
        // ── Methods ──
        public void TickRealtimeProbes(){} // RVA: 0x7FFE87CA8290
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void BuiltinUpdate(){} // RVA: 0x7FFE87CA8290
        public void Internal_BuiltinRuntimeReflectionSystem_New(){} // RVA: 0x7FFE87CA82E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class GraphicsFormatUtility : Object
    {
        // ── Methods ──
        public void GetFormat(){} // RVA: 0x7FFE87CA8660
        public void GetGraphicsFormat(){} // RVA: 0x7FFE87CA8990 | overloaded x3
        public void GetGraphicsFormat_Native_TextureFormat(){} // RVA: 0x7FFE87CA8750
        public void GetTextureFormat(){} // RVA: 0x7FFE87CA87B0
        public void GetTextureFormat_Native_GraphicsFormat(){} // RVA: 0x7FFE87CA8840
        public void GetGraphicsFormat_Native_RenderTextureFormat(){} // RVA: 0x7FFE87CA8930
        public void GetDepthStencilFormatFromBitsLegacy_Native(){} // RVA: 0x7FFE87CA8A50
        public void GetDepthStencilFormat(){} // RVA: 0x7FFE87CA8B80 | overloaded x2
        public void GetDepthBits(){} // RVA: 0x7FFE87CA8B30
        public void IsSRGBFormat(){} // RVA: 0x7FFE87CA8E60
        public void GetSRGBFormat(){} // RVA: 0x7FFE87CA8EB0
        public void GetLinearFormat(){} // RVA: 0x7FFE87CA8F00
        public void GetRenderTextureFormat(){} // RVA: 0x7FFE87CA8F50
        public void IsCompressedFormat_Native_TextureFormat(){} // RVA: 0x7FFE87CA8FA0
        public void IsCompressedFormat(){} // RVA: 0x7FFE87CA8FF0
        public void CanDecompressFormat(){} // RVA: 0x7FFE87CA90E0 | overloaded x2
        public void HasAlphaChannel(){} // RVA: 0x7FFE87CA9170
        public void IsDepthStencilFormat(){} // RVA: 0x7FFE87CA91C0
        public void IsPVRTCFormat(){} // RVA: 0x7FFE87CA9210
        public void IsCrunchFormat(){} // RVA: 0x7FFE87CA9260
        public void GetBlockSize(){} // RVA: 0x7FFE87CA9300 | overloaded x2
        public void GetBlockWidth(){} // RVA: 0x7FFE87CA93F0 | overloaded x2
        public void GetBlockHeight(){} // RVA: 0x7FFE87CA94E0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87CA9580
    }

    public class IScriptableRuntimeReflectionSystem
    {
        // ── Methods ──
        public void TickRealtimeProbes(){} // RVA: 0x7FFE80E2F150
    }

    public class ScriptableRuntimeReflectionSystemSettings : Object
    {
        public UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper s_Instance;
        public object field_1; // 0xDA20

        // ── Methods ──
        public void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(){} // RVA: 0x7FFE87CA8320
        public void get_Internal_ScriptableRuntimeReflectionSystemSettings_instance(){} // RVA: 0x7FFE87CA8490
        public void ScriptingDirtyReflectionSystemInstance(){} // RVA: 0x7FFE87CA84F0
        public void .cctor(){} // RVA: 0x7FFE87CA8540
    }

    public class ScriptableRuntimeReflectionSystemWrapper : Object
    {
        public UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem _implementation; // 0x10

        // ── Methods ──
        public void get_implementation(){} // RVA: 0x7FFE81116380
        public void set_implementation(){} // RVA: 0x7FFE810FCE30
        public void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(){} // RVA: 0x7FFE87CA85F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}