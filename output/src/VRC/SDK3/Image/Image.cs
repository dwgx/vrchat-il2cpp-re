// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Image
// Classes: 4
// Methods: 33

namespace VRC.SDK3.Image
{
    public class IVRCImageDownload
    {
        public object Request;

        // ── Methods ──
        public void get_State(){} // RVA: 0xD840
        public void get_Error(){} // RVA: 0xD840
        public void get_ErrorMessage(){} // RVA: 0xCD60
        public void get_Result(){} // RVA: 0xCD60
        public void get_SizeInMemoryBytes(){} // RVA: 0xD840
        public void get_Progress(){} // RVA: 0x21890
        public void get_Url(){} // RVA: 0xCD60
        public void get_Material(){} // RVA: 0xCD60
        public void get_UdonBehaviour(){} // RVA: 0xCD60
        public void get_TextureInfo(){} // RVA: 0xCD60
        public void StartDownload(){} // RVA: 0x24A50
        public void CancelDownload(){} // RVA: 0x24A50
    }

    public class ImageDownloader
    {
        public VRC.SDK3.Image.ImageDownloader _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x9A602A0
        public void TrimCache(){} // RVA: 0x9A60380
        public void DownloadImage(){} // RVA: 0x9A603B0
        public void TrimCacheInternal(){} // RVA: 0x9A60430
        public void DownloadImageInternal(){} // RVA: 0x9A60670
        public void CacheTexture(){} // RVA: 0x9A60D90
        public void DownloadFallbackOrUseErrorImage(){} // RVA: 0x9A60F90
        public void .ctor(){} // RVA: 0x9A610D0
    }

    public class TextureInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A0C600
    }

    public class VRCImageDownloader
    {
        public bool _disposed; // 0x10
        public System.Collections.Generic.List`1<VRC.SDK3.Image.IVRCImageDownload> _imageDownloads; // 0x18

        // ── Methods ──
        public void get_StartDownload(){} // RVA: 0x9A0C6A0
        public void set_StartDownload(){} // RVA: 0x9A0C700
        public void DownloadImage(){} // RVA: 0x9A0C7C0
        public void Dispose(){} // RVA: 0x9A0C960
        public void Finalize(){} // RVA: 0x9A0C9C0
        public void DisposeInternal(){} // RVA: 0x9A0CA10
        public void AddImageDownloadToQueue(){} // RVA: 0x9A0CCF0
        public void RemoveImageDownloadFromQueue(){} // RVA: 0x9A0CDC0
        public void ClearQueue(){} // RVA: 0x9A0CE50
        public void get_HasAnyQueuedDownloads(){} // RVA: 0x9A0D180
        public void .ctor(){} // RVA: 0x9A0D200
        public void .cctor(){} // RVA: 0x9A0D2C0
    }

}