// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Image
// Classes: 4
// Methods: 33

namespace VRC.SDK3.Image
{
    public class IVRCImageDownload
    {
        public object State;
        public object Error;
        public object ErrorMessage;
        public object Result;
        public object SizeInMemoryBytes;
        public object Progress;
        public object Url;
        public object Material;
        public object UdonBehaviour;
        public object TextureInfo;

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFAC2C59960
        public void get_Error(){} // RVA: 0x7FFAC2C59960
        public void get_ErrorMessage(){} // RVA: 0x7FFAC2C58E90
        public void get_Result(){} // RVA: 0x7FFAC2C58E90
        public void get_SizeInMemoryBytes(){} // RVA: 0x7FFAC2C59960
        public void get_Progress(){} // RVA: 0x7FFAC2C6D880
        public void get_Url(){} // RVA: 0x7FFAC2C58E90
        public void get_Material(){} // RVA: 0x7FFAC2C58E90
        public void get_UdonBehaviour(){} // RVA: 0x7FFAC2C58E90
        public void get_TextureInfo(){} // RVA: 0x7FFAC2C58E90
        public void StartDownload(){} // RVA: 0x7FFAC2C70980
        public void CancelDownload(){} // RVA: 0x7FFAC2C70980
    }

    public class ImageDownloader : Object
    {
        public VRC.SDK3.Image.ImageDownloader Instance;
        public int MAX_CACHED_IMAGES;
        public int MIN_CACHED_IMAGES;
        public System.Collections.Generic.List`1<string> cachedImageQueue; // 0x10
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.Texture2D> _downloadedImages; // 0x18
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<System.Action`1<UnityEngine.Texture2D>>> _downloadingImages; // 0x20

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFACC045F50
        public void TrimCache(){} // RVA: 0x7FFACC046030
        public void DownloadImage(){} // RVA: 0x7FFACC046060
        public void TrimCacheInternal(){} // RVA: 0x7FFACC0460E0
        public void DownloadImageInternal(){} // RVA: 0x7FFACC046320
        public void CacheTexture(){} // RVA: 0x7FFACC046A40
        public void DownloadFallbackOrUseErrorImage(){} // RVA: 0x7FFACC046C40
        public void .ctor(){} // RVA: 0x7FFACC046D80
    }

    public class TextureInfo : Object
    {
        public 0x6B17BFC8 WrapModeU; // 0x10
        public 0x6B17BFC8 WrapModeV; // 0x14
        public 0x6B17BFC8 WrapModeW; // 0x18
        public 0x6B17BF70 FilterMode; // 0x1C
        public int AnisoLevel; // 0x20
        public string MaterialProperty; // 0x28
        public bool GenerateMipMaps; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC002780
    }

    public class VRCImageDownloader : Object
    {
        public bool StartDownload; // 0x10
        public System.Collections.Generic.List`1<VRC.SDK3.Image.IVRCImageDownload> HasAnyQueuedDownloads; // 0x18
        public System.Collections.Generic.List`1<VRC.SDK3.Image.IVRCImageDownload> _imageDownloadQueue;
        public System.Func`5<VRC.SDKBase.VRCUrl,UnityEngine.Material,VRC.Udon.Common.Interfaces.IUdonEventReceiver,VRC.SDK3.Image.TextureInfo,VRC.SDK3.Image.IVRCImageDownload> <StartDownload>k__BackingField; // 0x8
        public System.Func`1<bool> CanBypassDelay; // 0x10

        // ── Methods ──
        public void get_StartDownload(){} // RVA: 0x7FFACC002820
        public void set_StartDownload(){} // RVA: 0x7FFACC002880
        public void DownloadImage(){} // RVA: 0x7FFACC002940
        public void Dispose(){} // RVA: 0x7FFACC002AE0
        public void Finalize(){} // RVA: 0x7FFACC002B40
        public void DisposeInternal(){} // RVA: 0x7FFACC002B90
        public void AddImageDownloadToQueue(){} // RVA: 0x7FFACC002E70
        public void RemoveImageDownloadFromQueue(){} // RVA: 0x7FFACC002F40
        public void ClearQueue(){} // RVA: 0x7FFACC002FD0
        public void get_HasAnyQueuedDownloads(){} // RVA: 0x7FFACC003300
        public void .ctor(){} // RVA: 0x7FFACC003380
        public void .cctor(){} // RVA: 0x7FFACC003440
    }

}