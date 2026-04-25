// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Caching
// Classes: 4
// Methods: 82

namespace ThirdParty.BestHTTP.BestHTTP.Caching
{
    public class HTTPCacheFileInfo : Object
    {
        public System.Uri Uri; // 0x10
        public System.DateTime LastAccess; // 0x18
        public int BodyLength; // 0x20
        public string ETag; // 0x28
        public string LastModified; // 0x30
        public System.DateTime Expires; // 0x38
        public long Age; // 0x40
        public long MaxAge; // 0x48
        public System.DateTime Date; // 0x50
        public bool MustRevalidate; // 0x58
        public System.DateTime Received; // 0x60
        public string ConstructedPath; // 0x68
        public ulong MappedNameIDX; // 0x70

        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7FFAC2F3C380
        public void set_Uri(){} // RVA: 0x7FFAC2F22E30
        public void get_LastAccess(){} // RVA: 0x7FFAC2F247C0
        public void set_LastAccess(){} // RVA: 0x7FFAC38920D0
        public void get_BodyLength(){} // RVA: 0x7FFAC30DBBE0
        public void set_BodyLength(){} // RVA: 0x7FFAC35DB7A0
        public void get_ETag(){} // RVA: 0x7FFAC2F4F130
        public void set_ETag(){} // RVA: 0x7FFAC2F22E90
        public void get_LastModified(){} // RVA: 0x7FFAC31D95E0
        public void set_LastModified(){} // RVA: 0x7FFAC2F4F890
        public void get_Expires(){} // RVA: 0x7FFAC31D0140
        public void set_Expires(){} // RVA: 0x7FFAC35233F0
        public void get_Age(){} // RVA: 0x7FFAC2F9E740
        public void set_Age(){} // RVA: 0x7FFAC5FE03B0
        public void get_MaxAge(){} // RVA: 0x7FFAC2F9C730
        public void set_MaxAge(){} // RVA: 0x7FFAC4248FC0
        public void get_Date(){} // RVA: 0x7FFAC2FC20E0
        public void set_Date(){} // RVA: 0x7FFAC42499F0
        public void get_MustRevalidate(){} // RVA: 0x7FFAC313F600
        public void set_MustRevalidate(){} // RVA: 0x7FFAC3892770
        public void get_Received(){} // RVA: 0x7FFAC2FBF370
        public void set_Received(){} // RVA: 0x7FFAC825E080
        public void get_ConstructedPath(){} // RVA: 0x7FFAC2F9CD50
        public void set_ConstructedPath(){} // RVA: 0x7FFAC2F9CD60
        public void get_MappedNameIDX(){} // RVA: 0x7FFAC2FE9590
        public void set_MappedNameIDX(){} // RVA: 0x7FFAC4A2BA60
        public void .ctor(){} // RVA: 0x7FFACBE39D20 | overloaded x3
        public void SaveTo(){} // RVA: 0x7FFACBE3A000
        public void GetPath(){} // RVA: 0x7FFACBE3A1D0
        public void IsExists(){} // RVA: 0x7FFACBE3A3A0
        public void Delete(){} // RVA: 0x7FFACBE3A480
        public void Reset(){} // RVA: 0x7FFACBE3A5A0
        public void AlreadyStored(){} // RVA: 0x7FFACBE3A800
        public void SetUpCachingValues(){} // RVA: 0x7FFACBE3AAC0
        public void WillExpireInTheFuture(){} // RVA: 0x7FFACBE3AFD0
        public void SetUpRevalidationHeaders(){} // RVA: 0x7FFACBE3B160
        public void GetBodyStream(){} // RVA: 0x7FFACBE3B220
        public void ReadResponseTo(){} // RVA: 0x7FFACBE3B360
        public void Store(){} // RVA: 0x7FFACBE3B5C0
        public void GetSaveStream(){} // RVA: 0x7FFACBE3BCC0
        public void CompareTo(){} // RVA: 0x7FFACBE3C410
    }

    public class HTTPCacheMaintananceParams : Object
    {
        public System.TimeSpan DeleteOlder; // 0x10
        public ulong MaxCacheSize; // 0x18

        // ── Methods ──
        public void get_DeleteOlder(){} // RVA: 0x7FFAC2F3C380
        public void set_DeleteOlder(){} // RVA: 0x7FFAC441EFB0
        public void get_MaxCacheSize(){} // RVA: 0x7FFAC2F247C0
        public void set_MaxCacheSize(){} // RVA: 0x7FFAC38920D0
        public void .ctor(){} // RVA: 0x7FFAC83D0D00
    }

    public class HTTPCacheService : Object
    {
        public int IsSupported;
        public bool CacheFolder;
        public bool LibraryPath; // 0x1
        public System.Collections.Generic.Dictionary`2<System.Uri,BestHTTP.Caching.HTTPCacheFileInfo> IsDoingMaintainence; // 0x8
        public System.Threading.ReaderWriterLockSlim rwLock; // 0x10
        public System.Collections.Generic.Dictionary`2<ulong,BestHTTP.Caching.HTTPCacheFileInfo> UsedIndexes; // 0x18
        public string <CacheFolder>k__BackingField; // 0x20
        public string <LibraryPath>k__BackingField; // 0x28
        public bool InClearThread; // 0x30
        public bool InMaintainenceThread; // 0x31
        public ulong NextNameIDX; // 0x38

        // ── Methods ──
        public void get_IsSupported(){} // RVA: 0x7FFACBE3C6F0
        public void get_CacheFolder(){} // RVA: 0x7FFACBE3C9A0
        public void set_CacheFolder(){} // RVA: 0x7FFACBE3CA00
        public void get_LibraryPath(){} // RVA: 0x7FFACBE3CAC0
        public void set_LibraryPath(){} // RVA: 0x7FFACBE3CB20
        public void get_IsDoingMaintainence(){} // RVA: 0x7FFACBE3CBE0
        public void .cctor(){} // RVA: 0x7FFACBE3CC80
        public void CheckSetup(){} // RVA: 0x7FFACBE3CE60
        public void SetupCacheFolder(){} // RVA: 0x7FFACBE3CED0
        public void GetNameIdx(){} // RVA: 0x7FFACBE3D430
        public void HasEntity(){} // RVA: 0x7FFACBE3D550
        public void DeleteEntity(){} // RVA: 0x7FFACBE3D740
        public void DeleteEntityImpl(){} // RVA: 0x7FFACBE3D8F0
        public void IsCachedEntityExpiresInTheFuture(){} // RVA: 0x7FFACBE3DB60
        public void SetHeaders(){} // RVA: 0x7FFACBE3DEC0
        public void GetEntity(){} // RVA: 0x7FFACBE3E180
        public void GetFullResponse(){} // RVA: 0x7FFACBE3E300
        public void IsCacheble(){} // RVA: 0x7FFACBE3E520
        public void Store(){} // RVA: 0x7FFACBE3E940
        public void PrepareStreamed(){} // RVA: 0x7FFACBE3EDF0
        public void BeginClear(){} // RVA: 0x7FFACBE3F120
        public void ClearImpl(){} // RVA: 0x7FFACBE3F320
        public void BeginMaintainence(){} // RVA: 0x7FFACBE3F600
        public void MaintananceImpl(){} // RVA: 0x7FFACBE3F8C0
        public void GetCacheEntityCount(){} // RVA: 0x7FFACBE40250
        public void GetCacheSize(){} // RVA: 0x7FFACBE403B0
        public void GetCacheSizeImpl(){} // RVA: 0x7FFACBE404F0
        public void LoadLibrary(){} // RVA: 0x7FFACBE406D0
        public void SaveLibrary(){} // RVA: 0x7FFACBE40DF0
        public void SetBodyLength(){} // RVA: 0x7FFACBE41410
        public void DeleteUnusedFiles(){} // RVA: 0x7FFACBE41820
    }

    public class UriComparer : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFACBE3C4C0
        public void GetHashCode(){} // RVA: 0x7FFACBE3C6A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}