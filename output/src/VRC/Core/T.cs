// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 3
// Methods: 26

namespace VRC.Core
{
    public class TextureCopyEventData
    {
    }

    public class TextureDestructionFlusher
    {
        // ── Methods ──
        public void EnsureRegistered(){} // RVA: 0x9A67FF0
        public void OnApplicationQuitting(){} // RVA: 0x9A68400
        public void RunFlushLoop(){} // RVA: 0x9A68670
    }

    public class TextureDirectCopy
    {
        public string PreprocessOrder;
        public bool _initialized;
        public bool _available; // 0x1

        // ── Methods ──
        public void VRCTexCopy_Initialize(){} // RVA: 0x9A68BE0
        public void VRCTexCopy_Shutdown(){} // RVA: 0x9A68C60
        public void VRCTexCopy_CreateTexture(){} // RVA: 0x9A68CD0
        public void VRCTexCopy_GetTexturePtr(){} // RVA: 0x9A68DF0
        public void VRCTexCopy_GetRenderEventFunc(){} // RVA: 0x9A68ED0
        public void VRCTexCopy_DestroyTexture(){} // RVA: 0x9A68F40
        public void VRCTexCopy_GetLastError(){} // RVA: 0x9A68FC0
        public void VRCTexCopy_GetActiveTextureCount(){} // RVA: 0x9A69030
        public void get_IsAvailable(){} // RVA: 0x9A690A0
        public void IsFormatSupported(){} // RVA: 0x9A69100
        public void EnsureInitialized(){} // RVA: 0x9A69210
        public void Shutdown(){} // RVA: 0x9A695B0
        public void CreateCompressedTexture(){} // RVA: 0x9A69760
        public void ReleaseHandles(){} // RVA: 0x9A6A040
        public void ReleasePendingHandles(){} // RVA: 0x9A6A260
        public void DestroyNativeTextureImmediate(){} // RVA: 0x9A6A2C0
        public void QueueNativeTextureDestruction(){} // RVA: 0x9A6A3E0
        public void ProcessPendingDestructions(){} // RVA: 0x9A6A5A0
        public void ProcessPendingDestructionsImmediate(){} // RVA: 0x9A6A5F0
        public void ReleaseDestructionEventHandles(){} // RVA: 0x9A6A670
        public void get_PendingDestructionCount(){} // RVA: 0x9A6A8E0
        public void get_ActiveNativeTextureCount(){} // RVA: 0x9A6A930
        public void .cctor(){} // RVA: 0x9A6AA50
    }

}