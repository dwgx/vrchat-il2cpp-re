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
        public void EnsureRegistered(){} // RVA: 0x7FFAFC517FF0
        public void OnApplicationQuitting(){} // RVA: 0x7FFAFC518400
        public void RunFlushLoop(){} // RVA: 0x7FFAFC518670
    }

    public class TextureDirectCopy
    {
        public object PreprocessOrder;

        // ── Methods ──
        public void VRCTexCopy_Initialize(){} // RVA: 0x7FFAFC518BE0
        public void VRCTexCopy_Shutdown(){} // RVA: 0x7FFAFC518C60
        public void VRCTexCopy_CreateTexture(){} // RVA: 0x7FFAFC518CD0
        public void VRCTexCopy_GetTexturePtr(){} // RVA: 0x7FFAFC518DF0
        public void VRCTexCopy_GetRenderEventFunc(){} // RVA: 0x7FFAFC518ED0
        public void VRCTexCopy_DestroyTexture(){} // RVA: 0x7FFAFC518F40
        public void VRCTexCopy_GetLastError(){} // RVA: 0x7FFAFC518FC0
        public void VRCTexCopy_GetActiveTextureCount(){} // RVA: 0x7FFAFC519030
        public void get_IsAvailable(){} // RVA: 0x7FFAFC5190A0
        public void IsFormatSupported(){} // RVA: 0x7FFAFC519100
        public void EnsureInitialized(){} // RVA: 0x7FFAFC519210
        public void Shutdown(){} // RVA: 0x7FFAFC5195B0
        public void CreateCompressedTexture(){} // RVA: 0x7FFAFC519760
        public void ReleaseHandles(){} // RVA: 0x7FFAFC51A040
        public void ReleasePendingHandles(){} // RVA: 0x7FFAFC51A260
        public void DestroyNativeTextureImmediate(){} // RVA: 0x7FFAFC51A2C0
        public void QueueNativeTextureDestruction(){} // RVA: 0x7FFAFC51A3E0
        public void ProcessPendingDestructions(){} // RVA: 0x7FFAFC51A5A0
        public void ProcessPendingDestructionsImmediate(){} // RVA: 0x7FFAFC51A5F0
        public void ReleaseDestructionEventHandles(){} // RVA: 0x7FFAFC51A670
        public void get_PendingDestructionCount(){} // RVA: 0x7FFAFC51A8E0
        public void get_ActiveNativeTextureCount(){} // RVA: 0x7FFAFC51A930
        public void .cctor(){} // RVA: 0x7FFAFC51AA50
    }

}