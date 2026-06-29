// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Image
// Classes: 5
// Methods: 53

namespace VRC.SDK3.Image
{
    public class IVRCImageDownload
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x87C130
        public void get_Error(){} // RVA: 0x87C130
        public void get_ErrorMessage(){} // RVA: 0x87C0A0
        public void get_Result(){} // RVA: 0x87C0A0
        public void get_SizeInMemoryBytes(){} // RVA: 0x87C130
        public void get_Progress(){} // RVA: 0x890F90
        public void get_Url(){} // RVA: 0x87C0A0
        public void get_Material(){} // RVA: 0x87C0A0
        public void get_UdonBehaviour(){} // RVA: 0x87C0A0
        public void get_TextureInfo(){} // RVA: 0x87C0A0
        public void StartDownload(){} // RVA: 0x894290
        public void CancelDownload(){} // RVA: 0x894290
    }

    public class IVRCImageDownload[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ImageDownloader : Object
    {
        public object _instance;
        public object MAX_CACHED_IMAGES;
        public object MIN_CACHED_IMAGES;
        public object cachedImageQueue;
        public object _downloadedImages;
        public object _downloadingImages;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0xA70D700
        public void TrimCache(){} // RVA: 0xA70D7E0
        public void DownloadImage(){} // RVA: 0xA70D810
        public void TrimCacheInternal(){} // RVA: 0xA70D890
        public void DownloadImageInternal(){} // RVA: 0xA70DA90
        public void CacheTexture(){} // RVA: 0xA70E190
        public void DownloadFallbackOrUseErrorImage(){} // RVA: 0xA70E390
        public void .ctor(){} // RVA: 0xA70E4F0
    }

    public class TextureInfo : Object
    {
        public object WrapModeU;
        public object WrapModeV;
        public object WrapModeW;
        public object FilterMode;
        public object AnisoLevel;
        public object MaterialProperty;
        public object GenerateMipMaps;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6B5D50
    }

    public class VRCImageDownloader : Object
    {
        public object _disposed;
        public object _finalized;
        public object _imageDownloads;
        public object _imageDownloadQueue;
        public object _startDownload;
        public object _imageUploader;
        public object CanBypassDelay;
        public object SLICE_SIZE_BYTES;

        // ── Methods ──
        public void get_StartDownload(){} // RVA: 0xA6B5DF0
        public void set_StartDownload(){} // RVA: 0xA6B5E50
        public void get_ImageUploader(){} // RVA: 0xA6B5F10
        public void set_ImageUploader(){} // RVA: 0xA6B5F70
        public void DownloadImage(){} // RVA: 0xA6B6030
        public void Dispose(){} // RVA: 0xA6B61D0
        public void Finalize(){} // RVA: 0xA6B63B0
        public void DisposeInternal(){} // RVA: 0xA6B6400
        public void AddImageDownloadToQueue(){} // RVA: 0xA6B6590
        public void RemoveImageDownloadFromQueue(){} // RVA: 0xA6B6660
        public void ClearQueue(){} // RVA: 0xA6B66F0
        public void get_HasAnyQueuedDownloads(){} // RVA: 0xA6B6A20
        public void UploadMipMapSliced(){} // RVA: 0xA6B6AA0
        public void UploadAllMipMapsCPU(){} // RVA: 0xA6B6D10
        public void GetBytesPerPixel(){} // RVA: 0xA6B6F30
        public void .ctor(){} // RVA: 0xA6B70F0
        public void .cctor(){} // RVA: 0xA6B71B0
    }

}