// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Experimental.Rendering
// Classes: 5
// Methods: 46

namespace ThirdParty.Unity.UnityEngine.Experimental.Rendering
{
    public class BuiltinRuntimeReflectionSystem : Object
    {
        // ── Methods ──
        public void TickRealtimeProbes(){} // RVA: 0x7FFAC98FF9F0
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void BuiltinUpdate(){} // RVA: 0x7FFAC98FF9F0
        public void Internal_BuiltinRuntimeReflectionSystem_New(){} // RVA: 0x7FFAC98FFA40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class GraphicsFormatUtility : Object
    {
        public 0x6B189648[] tableNoStencil;
        public 0x6B189648[] tableStencil; // 0x8

        // ── Methods ──
        public void GetFormat(){} // RVA: 0x7FFAC98FFDC0
        public void GetGraphicsFormat(){} // RVA: 0x7FFAC99000F0 | overloaded x3
        public void GetGraphicsFormat_Native_TextureFormat(){} // RVA: 0x7FFAC98FFEB0
        public void GetTextureFormat(){} // RVA: 0x7FFAC98FFF10
        public void GetTextureFormat_Native_GraphicsFormat(){} // RVA: 0x7FFAC98FFFA0
        public void GetGraphicsFormat_Native_RenderTextureFormat(){} // RVA: 0x7FFAC9900090
        public void GetDepthStencilFormatFromBitsLegacy_Native(){} // RVA: 0x7FFAC99001B0
        public void GetDepthStencilFormat(){} // RVA: 0x7FFAC99002E0 | overloaded x2
        public void GetDepthBits(){} // RVA: 0x7FFAC9900290
        public void IsSRGBFormat(){} // RVA: 0x7FFAC99005C0
        public void GetSRGBFormat(){} // RVA: 0x7FFAC9900610
        public void GetLinearFormat(){} // RVA: 0x7FFAC9900660
        public void GetRenderTextureFormat(){} // RVA: 0x7FFAC99006B0
        public void IsCompressedFormat_Native_TextureFormat(){} // RVA: 0x7FFAC9900700
        public void IsCompressedFormat(){} // RVA: 0x7FFAC9900750
        public void CanDecompressFormat(){} // RVA: 0x7FFAC9900840 | overloaded x2
        public void HasAlphaChannel(){} // RVA: 0x7FFAC99008D0
        public void IsDepthStencilFormat(){} // RVA: 0x7FFAC9900920
        public void IsPVRTCFormat(){} // RVA: 0x7FFAC9900970
        public void IsCrunchFormat(){} // RVA: 0x7FFAC99009C0
        public void GetBlockSize(){} // RVA: 0x7FFAC9900A60 | overloaded x2
        public void GetBlockWidth(){} // RVA: 0x7FFAC9900B50 | overloaded x2
        public void GetBlockHeight(){} // RVA: 0x7FFAC9900C40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9900CE0
    }

    public class IScriptableRuntimeReflectionSystem
    {
        // ── Methods ──
        public void TickRealtimeProbes(){} // RVA: 0x7FFAC2C59D00
    }

    public class ScriptableRuntimeReflectionSystemSettings : Object
    {
        public UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_system;

        // ── Methods ──
        public void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(){} // RVA: 0x7FFAC98FFA80
        public void get_Internal_ScriptableRuntimeReflectionSystemSettings_instance(){} // RVA: 0x7FFAC98FFBF0
        public void ScriptingDirtyReflectionSystemInstance(){} // RVA: 0x7FFAC98FFC50
        public void .cctor(){} // RVA: 0x7FFAC98FFCA0
    }

    public class ScriptableRuntimeReflectionSystemWrapper : Object
    {
        public UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem implementation; // 0x10

        // ── Methods ──
        public void get_implementation(){} // RVA: 0x7FFAC2F3C380
        public void set_implementation(){} // RVA: 0x7FFAC2F22E30
        public void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(){} // RVA: 0x7FFAC98FFD50
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}