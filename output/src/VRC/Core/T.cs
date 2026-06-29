// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 2
// Methods: 25

namespace VRC.Core
{
    public class TextureDestructionFlusher : Object
    {
        // ── Methods ──
        public void EnqueueHandle(){} // RVA: 0x7B18A7EE0
        public void EnsureRegistered(){} // RVA: 0x7B18A7F90
        public void OnApplicationQuitting(){} // RVA: 0x7B18A83D0
        public void FreeAllPinned(){} // RVA: 0x7B18A86A0
        public void RunFlushLoop(){} // RVA: 0x7B18A8970
        public void .cctor(){} // RVA: 0x7B18A8AA0
    }

    public class TextureDirectCopy : Object
    {
        // ── Methods ──
        public void VRCTexCopy_Initialize(){} // RVA: 0x7B18A96A0
        public void VRCTexCopy_Shutdown(){} // RVA: 0x7B18A9720
        public void VRCTexCopy_CreateTexture(){} // RVA: 0x7B18A9790
        public void VRCTexCopy_GetTexturePtr(){} // RVA: 0x7B18A98B0
        public void VRCTexCopy_GetRenderEventFunc(){} // RVA: 0x7B18A9990
        public void VRCTexCopy_DestroyTexture(){} // RVA: 0x7B18A9A00
        public void VRCTexCopy_GetLastError(){} // RVA: 0x7B18A9A80
        public void VRCTexCopy_GetActiveTextureCount(){} // RVA: 0x7B18A9AF0
        public void get_IsAvailable(){} // RVA: 0x7B18A9B60
        public void IsFormatSupported(){} // RVA: 0x7B18A9BC0
        public void EnsureInitialized(){} // RVA: 0x7B18A9CE0
        public void Shutdown(){} // RVA: 0x7B18AA080
        public void CreateCompressedTexture(){} // RVA: 0x7B18AA460
        public void EnqueueHandleForDestruction(){} // RVA: 0x7B18AAD90
        public void ProcessPendingDestructions(){} // RVA: 0x7B18AAE20
        public void ProcessPendingDestructionsImmediate(){} // RVA: 0x7B18AB190
        public void get_PendingDestructionCount(){} // RVA: 0x7B18AB380
        public void get_ActiveNativeTextureCount(){} // RVA: 0x7B18AB400
        public void .cctor(){} // RVA: 0x7B18AB530
    }

}