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
        public void get_State(){} // RVA: 0x7FFAF2ABD840
        public void get_Error(){} // RVA: 0x7FFAF2ABD840
        public void get_ErrorMessage(){} // RVA: 0x7FFAF2ABCD60
        public void get_Result(){} // RVA: 0x7FFAF2ABCD60
        public void get_SizeInMemoryBytes(){} // RVA: 0x7FFAF2ABD840
        public void get_Progress(){} // RVA: 0x7FFAF2AD1890
        public void get_Url(){} // RVA: 0x7FFAF2ABCD60
        public void get_Material(){} // RVA: 0x7FFAF2ABCD60
        public void get_UdonBehaviour(){} // RVA: 0x7FFAF2ABCD60
        public void get_TextureInfo(){} // RVA: 0x7FFAF2ABCD60
        public void StartDownload(){} // RVA: 0x7FFAF2AD4A50
        public void CancelDownload(){} // RVA: 0x7FFAF2AD4A50
    }

    public class ImageDownloader
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAFC5102A0
        public void TrimCache(){} // RVA: 0x7FFAFC510380
        public void DownloadImage(){} // RVA: 0x7FFAFC5103B0
        public void TrimCacheInternal(){} // RVA: 0x7FFAFC510430
        public void DownloadImageInternal(){} // RVA: 0x7FFAFC510670
        public void CacheTexture(){} // RVA: 0x7FFAFC510D90
        public void DownloadFallbackOrUseErrorImage(){} // RVA: 0x7FFAFC510F90
        public void .ctor(){} // RVA: 0x7FFAFC5110D0
    }

    public class TextureInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC4BC600
    }

    public class VRCImageDownloader
    {
        // ── Methods ──
        public void get_StartDownload(){} // RVA: 0x7FFAFC4BC6A0
        public void set_StartDownload(){} // RVA: 0x7FFAFC4BC700
        public void DownloadImage(){} // RVA: 0x7FFAFC4BC7C0
        public void Dispose(){} // RVA: 0x7FFAFC4BC960
        public void Finalize(){} // RVA: 0x7FFAFC4BC9C0
        public void DisposeInternal(){} // RVA: 0x7FFAFC4BCA10
        public void AddImageDownloadToQueue(){} // RVA: 0x7FFAFC4BCCF0
        public void RemoveImageDownloadFromQueue(){} // RVA: 0x7FFAFC4BCDC0
        public void ClearQueue(){} // RVA: 0x7FFAFC4BCE50
        public void get_HasAnyQueuedDownloads(){} // RVA: 0x7FFAFC4BD180
        public void .ctor(){} // RVA: 0x7FFAFC4BD200
        public void .cctor(){} // RVA: 0x7FFAFC4BD2C0
    }

}