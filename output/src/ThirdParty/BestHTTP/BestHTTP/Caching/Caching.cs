// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Caching
// Classes: 4
// Methods: 82

namespace ThirdParty.BestHTTP.BestHTTP.Caching
{
    public class HTTPCacheFileInfo
    {
        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7FFAF2DA8380
        public void set_Uri(){} // RVA: 0x7FFAF2D8EE30
        public void get_LastAccess(){} // RVA: 0x7FFAF2D907C0
        public void set_LastAccess(){} // RVA: 0x7FFAF370BE60
        public void get_BodyLength(){} // RVA: 0x7FFAF3210030
        public void set_BodyLength(){} // RVA: 0x7FFAF344E0D0
        public void get_ETag(){} // RVA: 0x7FFAF2DBB130
        public void set_ETag(){} // RVA: 0x7FFAF2D8EE90
        public void get_LastModified(){} // RVA: 0x7FFAF30E74D0
        public void set_LastModified(){} // RVA: 0x7FFAF2DBB890
        public void get_Expires(){} // RVA: 0x7FFAF2F476A0
        public void set_Expires(){} // RVA: 0x7FFAF3A001D0
        public void get_Age(){} // RVA: 0x7FFAF2E0A740
        public void set_Age(){} // RVA: 0x7FFAF61637A0
        public void get_MaxAge(){} // RVA: 0x7FFAF2E08730
        public void set_MaxAge(){} // RVA: 0x7FFAF424D760
        public void get_Date(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Date(){} // RVA: 0x7FFAF2F74D50
        public void get_MustRevalidate(){} // RVA: 0x7FFAF304FF30
        public void set_MustRevalidate(){} // RVA: 0x7FFAF370F680
        public void get_Received(){} // RVA: 0x7FFAF2E2B370
        public void set_Received(){} // RVA: 0x7FFAF8576B90
        public void get_ConstructedPath(){} // RVA: 0x7FFAF2E08D50
        public void set_ConstructedPath(){} // RVA: 0x7FFAF2E08D60
        public void get_MappedNameIDX(){} // RVA: 0x7FFAF2E55590
        public void set_MappedNameIDX(){} // RVA: 0x7FFAF49BAB80
        public void .ctor(){} // RVA: 0x7FFAFC2E1000 | overloaded x3
        public void SaveTo(){} // RVA: 0x7FFAFC2E12E0
        public void GetPath(){} // RVA: 0x7FFAFC2E14B0
        public void IsExists(){} // RVA: 0x7FFAFC2E1680
        public void Delete(){} // RVA: 0x7FFAFC2E1760
        public void Reset(){} // RVA: 0x7FFAFC2E1880
        public void AlreadyStored(){} // RVA: 0x7FFAFC2E1AE0
        public void SetUpCachingValues(){} // RVA: 0x7FFAFC2E1DA0
        public void WillExpireInTheFuture(){} // RVA: 0x7FFAFC2E22B0
        public void SetUpRevalidationHeaders(){} // RVA: 0x7FFAFC2E2440
        public void GetBodyStream(){} // RVA: 0x7FFAFC2E2500
        public void ReadResponseTo(){} // RVA: 0x7FFAFC2E2640
        public void Store(){} // RVA: 0x7FFAFC2E28A0
        public void GetSaveStream(){} // RVA: 0x7FFAFC2E2FA0
        public void CompareTo(){} // RVA: 0x7FFAFC2E36F0
    }

    public class HTTPCacheMaintananceParams
    {
        // ── Methods ──
        public void get_DeleteOlder(){} // RVA: 0x7FFAF2DA8380
        public void set_DeleteOlder(){} // RVA: 0x7FFAF4417700
        public void get_MaxCacheSize(){} // RVA: 0x7FFAF2D907C0
        public void set_MaxCacheSize(){} // RVA: 0x7FFAF370BE60
        public void .ctor(){} // RVA: 0x7FFAF86E97B0
    }

    public class HTTPCacheService
    {
        // ── Methods ──
        public void get_IsSupported(){} // RVA: 0x7FFAFC2E39D0
        public void get_CacheFolder(){} // RVA: 0x7FFAFC2E3C80
        public void set_CacheFolder(){} // RVA: 0x7FFAFC2E3CE0
        public void get_LibraryPath(){} // RVA: 0x7FFAFC2E3DA0
        public void set_LibraryPath(){} // RVA: 0x7FFAFC2E3E00
        public void get_IsDoingMaintainence(){} // RVA: 0x7FFAFC2E3EC0
        public void .cctor(){} // RVA: 0x7FFAFC2E3F60
        public void CheckSetup(){} // RVA: 0x7FFAFC2E4140
        public void SetupCacheFolder(){} // RVA: 0x7FFAFC2E41B0
        public void GetNameIdx(){} // RVA: 0x7FFAFC2E4710
        public void HasEntity(){} // RVA: 0x7FFAFC2E4830
        public void DeleteEntity(){} // RVA: 0x7FFAFC2E4A20
        public void DeleteEntityImpl(){} // RVA: 0x7FFAFC2E4BD0
        public void IsCachedEntityExpiresInTheFuture(){} // RVA: 0x7FFAFC2E4E40
        public void SetHeaders(){} // RVA: 0x7FFAFC2E51A0
        public void GetEntity(){} // RVA: 0x7FFAFC2E5460
        public void GetFullResponse(){} // RVA: 0x7FFAFC2E55E0
        public void IsCacheble(){} // RVA: 0x7FFAFC2E5800
        public void Store(){} // RVA: 0x7FFAFC2E5C20
        public void PrepareStreamed(){} // RVA: 0x7FFAFC2E60D0
        public void BeginClear(){} // RVA: 0x7FFAFC2E6400
        public void ClearImpl(){} // RVA: 0x7FFAFC2E6600
        public void BeginMaintainence(){} // RVA: 0x7FFAFC2E68E0
        public void MaintananceImpl(){} // RVA: 0x7FFAFC2E6BA0
        public void GetCacheEntityCount(){} // RVA: 0x7FFAFC2E7530
        public void GetCacheSize(){} // RVA: 0x7FFAFC2E7690
        public void GetCacheSizeImpl(){} // RVA: 0x7FFAFC2E77D0
        public void LoadLibrary(){} // RVA: 0x7FFAFC2E79B0
        public void SaveLibrary(){} // RVA: 0x7FFAFC2E80D0
        public void SetBodyLength(){} // RVA: 0x7FFAFC2E86F0
        public void DeleteUnusedFiles(){} // RVA: 0x7FFAFC2E8B00
    }

    public class UriComparer
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAFC2E37A0
        public void GetHashCode(){} // RVA: 0x7FFAFC2E3980
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}