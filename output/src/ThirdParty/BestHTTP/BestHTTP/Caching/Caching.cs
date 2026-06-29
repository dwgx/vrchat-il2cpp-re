// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Caching
// Classes: 4
// Methods: 80

namespace ThirdParty.BestHTTP.BestHTTP.Caching
{
    public class HTTPCacheFileInfo : Object
    {
        public object _uri;
        public object _lastAccess;
        public object _bodyLength;
        public object _eTag;
        public object _lastModified;
        public object _expires;
        public object _age;
        public object _maxAge;
        public object _date;
        public object _mustRevalidate;
        public object _received;
        public object _constructedPath;
        public object _mappedNameIDX;

        // ── Methods ──
        public void get_Uri(){} // RVA: 0xB5DBF0
        public void set_Uri(){} // RVA: 0xB44D60
        public void get_LastAccess(){} // RVA: 0xB465B0
        public void set_LastAccess(){} // RVA: 0x15428E0
        public void get_BodyLength(){} // RVA: 0xFEAE90
        public void set_BodyLength(){} // RVA: 0x1269760
        public void get_ETag(){} // RVA: 0xB70160
        public void set_ETag(){} // RVA: 0xB44DC0
        public void get_LastModified(){} // RVA: 0xD33E60
        public void set_LastModified(){} // RVA: 0xB708C0
        public void get_Expires(){} // RVA: 0xD05CA0
        public void set_Expires(){} // RVA: 0xE9F6B0
        public void get_Age(){} // RVA: 0xBC1B30
        public void set_Age(){} // RVA: 0xE9E8B0
        public void get_MaxAge(){} // RVA: 0xBBF8F0
        public void set_MaxAge(){} // RVA: 0x20633C0
        public void get_Date(){} // RVA: 0xBE58B0
        public void set_Date(){} // RVA: 0xE9E640
        public void get_MustRevalidate(){} // RVA: 0xE3F480
        public void set_MustRevalidate(){} // RVA: 0x1546550
        public void get_Received(){} // RVA: 0xBE2C60
        public void set_Received(){} // RVA: 0x6541540
        public void get_ConstructedPath(){} // RVA: 0xBBFF90
        public void set_ConstructedPath(){} // RVA: 0xBBFFA0
        public void get_MappedNameIDX(){} // RVA: 0xC10050
        public void set_MappedNameIDX(){} // RVA: 0x278E9C0
        public void .ctor(){} // RVA: 0xA4D6D60
        public void SaveTo(){} // RVA: 0xA4D7040
        public void GetPath(){} // RVA: 0xA4D7210
        public void IsExists(){} // RVA: 0xA4D73E0
        public void Delete(){} // RVA: 0xA4D74C0
        public void Reset(){} // RVA: 0xA4D75E0
        public void AlreadyStored(){} // RVA: 0xA4D7830
        public void SetUpCachingValues(){} // RVA: 0xA4D7AC0
        public void WillExpireInTheFuture(){} // RVA: 0xA4D7F90
        public void SetUpRevalidationHeaders(){} // RVA: 0xA4D8120
        public void GetBodyStream(){} // RVA: 0xA4D81E0
        public void ReadResponseTo(){} // RVA: 0xA4D8320
        public void Store(){} // RVA: 0xA4D85A0
        public void GetSaveStream(){} // RVA: 0xA4D8C90
        public void CompareTo(){} // RVA: 0xA4D93E0
    }

    public class HTTPCacheMaintananceParams : Object
    {
        public object _deleteOlder;
        public object _maxCacheSize;

        // ── Methods ──
        public void get_DeleteOlder(){} // RVA: 0xB5DBF0
        public void set_DeleteOlder(){} // RVA: 0x2230E30
        public void get_MaxCacheSize(){} // RVA: 0xB465B0
        public void set_MaxCacheSize(){} // RVA: 0x15428E0
        public void .ctor(){} // RVA: 0x66B1BD0
    }

    public class HTTPCacheService : Object
    {
        public object LibraryVersion;
        public object isSupported;
        public object IsSupportCheckDone;
        public object library;
        public object rwLock;
        public object UsedIndexes;
        public object _cacheFolder;
        public object _libraryPath;
        public object InClearThread;
        public object InMaintainenceThread;
        public object NextNameIDX;

        // ── Methods ──
        public void get_IsSupported(){} // RVA: 0xA4D96C0
        public void get_CacheFolder(){} // RVA: 0xA4D9970
        public void set_CacheFolder(){} // RVA: 0xA4D99D0
        public void get_LibraryPath(){} // RVA: 0xA4D9A90
        public void set_LibraryPath(){} // RVA: 0xA4D9AF0
        public void get_IsDoingMaintainence(){} // RVA: 0xA4D9BB0
        public void .cctor(){} // RVA: 0xA4D9C50
        public void CheckSetup(){} // RVA: 0xA4D9E30
        public void SetupCacheFolder(){} // RVA: 0xA4D9EA0
        public void GetNameIdx(){} // RVA: 0xA4DA400
        public void HasEntity(){} // RVA: 0xA4DA520
        public void DeleteEntity(){} // RVA: 0xA4DA710
        public void DeleteEntityImpl(){} // RVA: 0xA4DA8C0
        public void IsCachedEntityExpiresInTheFuture(){} // RVA: 0xA4DAB30
        public void SetHeaders(){} // RVA: 0xA4DAEA0
        public void GetEntity(){} // RVA: 0xA4DB170
        public void GetFullResponse(){} // RVA: 0xA4DB300
        public void IsCacheble(){} // RVA: 0xA4DB520
        public void Store(){} // RVA: 0xA4DB940
        public void PrepareStreamed(){} // RVA: 0xA4DBE00
        public void BeginClear(){} // RVA: 0xA4DC130
        public void ClearImpl(){} // RVA: 0xA4DC330
        public void BeginMaintainence(){} // RVA: 0xA4DC610
        public void MaintananceImpl(){} // RVA: 0xA4DC8D0
        public void GetCacheEntityCount(){} // RVA: 0xA4DD270
        public void GetCacheSize(){} // RVA: 0xA4DD3D0
        public void GetCacheSizeImpl(){} // RVA: 0xA4DD510
        public void LoadLibrary(){} // RVA: 0xA4DD700
        public void SaveLibrary(){} // RVA: 0xA4DDDC0
        public void SetBodyLength(){} // RVA: 0xA4DE3E0
        public void DeleteUnusedFiles(){} // RVA: 0xA4DE7F0
    }

    public class UriComparer : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0xA4D9490
        public void GetHashCode(){} // RVA: 0xA4D9670
        public void .ctor(){} // RVA: 0xB43310
    }

}