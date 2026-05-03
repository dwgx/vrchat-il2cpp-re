// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Image
// Classes: 4
// Methods: 33

namespace VRC.SDK3.Image
{
    public class IVRCImageDownload
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFE80E2EDB0
        public void get_Error(){} // RVA: 0x7FFE80E2EDB0
        public void get_ErrorMessage(){} // RVA: 0x7FFE80E2E2E0
        public void get_Result(){} // RVA: 0x7FFE80E2E2E0
        public void get_SizeInMemoryBytes(){} // RVA: 0x7FFE80E2EDB0
        public void get_Progress(){} // RVA: 0x7FFE80E42E10
        public void get_Url(){} // RVA: 0x7FFE80E2E2E0
        public void get_Material(){} // RVA: 0x7FFE80E2E2E0
        public void get_UdonBehaviour(){} // RVA: 0x7FFE80E2E2E0
        public void get_TextureInfo(){} // RVA: 0x7FFE80E2E2E0
        public void StartDownload(){} // RVA: 0x7FFE80E45FE0
        public void CancelDownload(){} // RVA: 0x7FFE80E45FE0
    }

    public class ImageDownloader : Object
    {
        public VRC.SDK3.Image.ImageDownloader _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE8A4ABA30
        public void TrimCache(){} // RVA: 0x7FFE8A4ABB10
        public void DownloadImage(){} // RVA: 0x7FFE8A4ABB40
        public void TrimCacheInternal(){} // RVA: 0x7FFE8A4ABBC0
        public void DownloadImageInternal(){} // RVA: 0x7FFE8A4ABE00
        public void CacheTexture(){} // RVA: 0x7FFE8A4AC520
        public void DownloadFallbackOrUseErrorImage(){} // RVA: 0x7FFE8A4AC720
        public void .ctor(){} // RVA: 0x7FFE8A4AC860
    }

    public class TextureInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A468030
    }

    public class VRCImageDownloader : Object
    {
        public bool _disposed; // 0x10
        public System.Collections.Generic.List`1<VRC.SDK3.Image.IVRCImageDownload> _imageDownloads; // 0x18

        // ── Methods ──
        public void get_StartDownload(){} // RVA: 0x7FFE8A4680D0
        public void set_StartDownload(){} // RVA: 0x7FFE8A468130
        public void DownloadImage(){} // RVA: 0x7FFE8A4681F0
        public void Dispose(){} // RVA: 0x7FFE8A468390
        public void Finalize(){} // RVA: 0x7FFE8A4683F0
        public void DisposeInternal(){} // RVA: 0x7FFE8A468440
        public void AddImageDownloadToQueue(){} // RVA: 0x7FFE8A468720
        public void RemoveImageDownloadFromQueue(){} // RVA: 0x7FFE8A4687F0
        public void ClearQueue(){} // RVA: 0x7FFE8A468880
        public void get_HasAnyQueuedDownloads(){} // RVA: 0x7FFE8A468BB0
        public void .ctor(){} // RVA: 0x7FFE8A468C30
        public void .cctor(){} // RVA: 0x7FFE8A468CF0
    }

}