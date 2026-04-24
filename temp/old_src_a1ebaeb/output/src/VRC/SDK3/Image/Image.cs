// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Image
// Classes: 2
// Methods: 24

namespace VRC.SDK3.Image
{
    public class IVRCImageDownload
    {
        // ── Original Methods ──
        public void get_State(){} // RVA: 0x7ffaa8649ca0
        public void get_Error(){} // RVA: 0x7ffaa8649ca0
        public void get_ErrorMessage(){} // RVA: 0x7ffaa86491d0
        public void get_Result(){} // RVA: 0x7ffaa86491d0
        public void get_SizeInMemoryBytes(){} // RVA: 0x7ffaa8649ca0
        public void get_Progress(){} // RVA: 0x7ffaa865dbc0
        public void get_Url(){} // RVA: 0x7ffaa86491d0
        public void get_Material(){} // RVA: 0x7ffaa86491d0
        public void get_UdonBehaviour(){} // RVA: 0x7ffaa86491d0
        public void get_TextureInfo(){} // RVA: 0x7ffaa86491d0
        public void StartDownload(){} // RVA: 0x7ffaa8660cc0
        public void CancelDownload(){} // RVA: 0x7ffaa8660cc0
    }

    public class VRCImageDownloader : Object
    {
        public object _imageDownloadQueue; // 0x3402DC00

        // ── Original Methods ──
        public void get_StartDownload(){} // RVA: 0x7ffab1a1e4f0
        public void set_StartDownload(){} // RVA: 0x7ffab1a1e550
        public void Dispose(){} // RVA: 0x7ffab1a1e7b0
        public void Finalize(){} // RVA: 0x7ffab1a1e810
        public void DisposeInternal(){} // RVA: 0x7ffab1a1e860
        public void AddImageDownloadToQueue(){} // RVA: 0x7ffab1a1eb40
        public void RemoveImageDownloadFromQueue(){} // RVA: 0x7ffab1a1ec10
        public void ClearQueue(){} // RVA: 0x7ffab1a1eca0
        public void get_HasAnyQueuedDownloads(){} // RVA: 0x7ffab1a1efd0
        public void .ctor(){} // RVA: 0x7ffab1a1f050
        public void .cctor(){} // RVA: 0x7ffab1a1f110
        // ── Binary Analysis Named ──
        public void DownloadImage(){} // RVA: 0x7ffab1a1e610
    }

}