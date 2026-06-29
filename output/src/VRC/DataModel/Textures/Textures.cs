// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.DataModel.Textures
// Classes: 15
// Methods: 106

namespace VRC.DataModel.Textures
{
    public class Base64TextureLoader : Object
    {
        public object BASE_64_PNG_PREFIX;

        // ── Methods ──
        public void CanLoad(){} // RVA: 0x264F9D0
        public void LoadAsync(){} // RVA: 0x264FA20
        public void DecodeBase64Png(){} // RVA: 0x264FEF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseTextureResource : Object
    {
        public object _texture;
        public object _refCount;
        public object _textureId;

        // ── Methods ──
        public void get_Texture(){} // RVA: 0xB5DBF0
        public void get_RefCount(){} // RVA: 0xE62D00
        public void set_RefCount(){} // RVA: 0x1033F40
        public void get_TextureId(){} // RVA: 0x2418230
        public void .ctor(){} // RVA: 0x2666630
        public void AddRefCount(){} // RVA: 0x26666F0
        public void RemoveRefCount(){} // RVA: 0x2666700
        public void GetTextureHandle(){} // RVA: 0x2666710
        public void Unload(){} // RVA: 0x894290
    }

    public class ITextureDownloaderHandler
    {
        // ── Methods ──
        public void DownloadTexture(){} // RVA: 0x87C930
    }

    public class ITextureLoader
    {
        // ── Methods ──
        public void CanLoad(){} // RVA: 0x87D350
        public void LoadAsync(){} // RVA: 0x87BF80
    }

    public class ITextureLoader[] : Array
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

    public class ITextureManager
    {
        // ── Methods ──
        public void GetTexture(){} // RVA: 0x87C880
        public void ReturnTexture(){} // RVA: 0x894320
        public void AggressiveTrimMemoryCache(){} // RVA: 0x894290
        public void ClearDiskCache(){} // RVA: 0x87BEB0
        public void GetDiskCacheSize(){} // RVA: 0x87BEB0
    }

    public class ITextureResource
    {
        // ── Methods ──
        public void get_Texture(){} // RVA: 0x87C0A0
        public void get_RefCount(){} // RVA: 0x87C130
        public void get_TextureId(){} // RVA: 0x87BEB0
        public void Unload(){} // RVA: 0x894290
        public void AddRefCount(){} // RVA: 0x894290
        public void RemoveRefCount(){} // RVA: 0x894290
        public void GetTextureHandle(){} // RVA: 0x87BEB0
    }

    public class LocalTexturesLoader : Object
    {
        public object RESOURCES_PREFIX;

        // ── Methods ──
        public void CanLoad(){} // RVA: 0x26502A0
        public void LoadAsync(){} // RVA: 0x26502F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NativeTextureDownloader : Object
    {
        public object MAX_CONCURRENT_SMALL_IMAGE_GPU_UPLOADS;
        public object MAX_CONCURRENT_LARGE_IMAGE_GPU_UPLOADS;
        public object _smallImageUploadSemaphore;
        public object _largeImageUploadSemaphore;
        public object _uploader;

        // ── Methods ──
        public void DownloadTexture(){} // RVA: 0x2654A50
        public void LoadImageToTextureAsync(){} // RVA: 0x2654CF0
        public void LoadImageAsync(){} // RVA: 0x2654F80
        public void CreateWebRequest(){} // RVA: 0x2655170
        public void .ctor(){} // RVA: 0x2655240
        public void .cctor(){} // RVA: 0x26552E0
        public void <LoadImageToTextureAsync>g__DestroyTexture|6_0(){} // RVA: 0x2655450
    }

    public class TextureCache : Object
    {
        public object MAX_MEMORY_CACHED_SIZE;
        public object _textureResourceCache;
        public object _cachedImageQueue;
        public object _cachedImageRemoval;
        public object _inMemoryTotalSize;

        // ── Methods ──
        public void get_InMemoryTotalSize(){} // RVA: 0xB70160
        public void get_Count(){} // RVA: 0x265EF10
        public void TryBorrowTextureResource(){} // RVA: 0x265EF60
        public void ReturnTexture(){} // RVA: 0x265F420
        public void CacheTextureResource(){} // RVA: 0x265F5A0
        public void IsTextureCachedInMemory(){} // RVA: 0x265F7B0
        public void TrimMemoryCache(){} // RVA: 0x265F840
        public void CalculateTextureSize(){} // RVA: 0x26605E0
        public void ToString(){} // RVA: 0x2660BF0
        public void .ctor(){} // RVA: 0x26610F0
    }

    public class TextureDownloadDiskCache : Object
    {
        public object MAX_DISK_CACHED_SIZE;
        public object MAX_CONCURRENT_DISK_OPS;
        public object TRIM_DELAY_MS;
        public object _semaphore;
        public object _trimInProgress;

        // ── Methods ──
        public void TryGet(){} // RVA: 0x2650B90
        public void SaveInBackground(){} // RVA: 0x2650FE0
        public void SaveAsync(){} // RVA: 0x2651010
        public void Delete(){} // RVA: 0x2651220
        public void GetTotalSize(){} // RVA: 0x2651400
        public void Clear(){} // RVA: 0x26515B0
        public void RequestTrim(){} // RVA: 0x2651720
        public void TrimAsync(){} // RVA: 0x2651860
        public void GetFilePath(){} // RVA: 0x26519A0
        public void GetCacheDirectory(){} // RVA: 0x2651A50
        public void TryCreateCacheDirectory(){} // RVA: 0x2651BB0
        public void .ctor(){} // RVA: 0x2651D40
    }

    public class TextureHandle : ValueType
    {
        public object id;
        public object texture;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8E0E0
    }

    public class TextureLoadRequest : ValueType
    {
        public object _id;
        public object _size;
        public object _generateMipMaps;
        public object _skipCompression;
        public object _cancellationToken;

        // ── Methods ──
        public void get_Id(){} // RVA: 0x8E1D0
        public void get_Size(){} // RVA: 0x8E1F0
        public void get_GenerateMipMaps(){} // RVA: 0x8C610
        public void get_SkipCompression(){} // RVA: 0x8E200
        public void get_CancellationToken(){} // RVA: 0x8C630
        public void .ctor(){} // RVA: 0x8E210
    }

    public class TextureManager : MonoBehaviour
    {
        public object ErrorImagePath;
        public object _errorImage;
        public object _loaders;
        public object _webLoader;
        public object _cache;
        public object _inProgressLoads;
        public object _logger;

        // ── Methods ──
        public void get_Logger(){} // RVA: 0x2661800
        public void Awake(){} // RVA: 0x2661940
        public void GetTexture(){} // RVA: 0x2662040
        public void LoadAndCacheTexture(){} // RVA: 0x26622E0
        public void LoadWithCorrectLoader(){} // RVA: 0x2662530
        public void CacheResourceInMemory(){} // RVA: 0x2662770
        public void ReturnTexture(){} // RVA: 0x26629D0
        public void AggressiveTrimMemoryCache(){} // RVA: 0x2662B70
        public void GetDiskCacheSize(){} // RVA: 0x2662BA0
        public void ClearDiskCache(){} // RVA: 0x2662D70
        public void IsErrorTexture(){} // RVA: 0x2662EF0
        public void GetErrorTextureHandle(){} // RVA: 0x2663040
        public void .ctor(){} // RVA: 0x26630F0
    }

    public class WebTexturesLoader : Object
    {
        public object _textureDownloaderHandler;
        public object _uploader;
        public object MAX_CONCURRENT_DOWNLOADS;
        public object _semaphore;
        public object _diskCache;

        // ── Methods ──
        public void get_DiskCache(){} // RVA: 0xB70160
        public void CanLoad(){} // RVA: 0x265A2F0
        public void LoadAsync(){} // RVA: 0x265A3D0
        public void DecodeCompressedBytesAsync(){} // RVA: 0x265A5E0
        public void DestroyTexture(){} // RVA: 0x265A890
        public void DownloadTextureWithRawBytes(){} // RVA: 0x265A9E0
        public void BuildFinalImageURL(){} // RVA: 0x265AC70
        public void IsImageAPIUrl(){} // RVA: 0x265ACB0
        public void .ctor(){} // RVA: 0x265AD90
        public void <DecodeCompressedBytesAsync>g__LoadImageFromBytes|9_0(){} // RVA: 0x265B110
        public void <DecodeCompressedBytesAsync>g__CreateAndUploadTexture|9_1(){} // RVA: 0x265B2E0
    }

}