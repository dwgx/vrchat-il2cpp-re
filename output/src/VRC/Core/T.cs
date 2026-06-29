// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 2
// Methods: 25

namespace VRC.Core
{
    public class TextureDestructionFlusher : Object
    {
        public object KEEP_FRAMES;
        public object _registered;
        public object _cts;
        public object _destructionCmd;
        public object _pinned;

        // ── Methods ──
        public void EnqueueHandle(){} // RVA: 0xA7161B0
        public void EnsureRegistered(){} // RVA: 0xA716260
        public void OnApplicationQuitting(){} // RVA: 0xA7166A0
        public void FreeAllPinned(){} // RVA: 0xA716970
        public void RunFlushLoop(){} // RVA: 0xA716C40
        public void .cctor(){} // RVA: 0xA716D70
    }

    public class TextureDirectCopy : Object
    {
        public object NATIVE_LIB;
        public object _initialized;
        public object _available;
        public object _renderEventCallback;
        public object _textureHandles;
        public object _destructionQueue;

        // ── Methods ──
        public void VRCTexCopy_Initialize(){} // RVA: 0xA717950
        public void VRCTexCopy_Shutdown(){} // RVA: 0xA7179D0
        public void VRCTexCopy_CreateTexture(){} // RVA: 0xA717A40
        public void VRCTexCopy_GetTexturePtr(){} // RVA: 0xA717B60
        public void VRCTexCopy_GetRenderEventFunc(){} // RVA: 0xA717C40
        public void VRCTexCopy_DestroyTexture(){} // RVA: 0xA717CB0
        public void VRCTexCopy_GetLastError(){} // RVA: 0xA717D30
        public void VRCTexCopy_GetActiveTextureCount(){} // RVA: 0xA717DA0
        public void get_IsAvailable(){} // RVA: 0xA717E10
        public void IsFormatSupported(){} // RVA: 0xA717E70
        public void EnsureInitialized(){} // RVA: 0xA717F90
        public void Shutdown(){} // RVA: 0xA718330
        public void CreateCompressedTexture(){} // RVA: 0xA718710
        public void EnqueueHandleForDestruction(){} // RVA: 0xA719270
        public void ProcessPendingDestructions(){} // RVA: 0xA719300
        public void ProcessPendingDestructionsImmediate(){} // RVA: 0xA719670
        public void get_PendingDestructionCount(){} // RVA: 0xA719860
        public void get_ActiveNativeTextureCount(){} // RVA: 0xA7198E0
        public void .cctor(){} // RVA: 0xA719A10
    }

}