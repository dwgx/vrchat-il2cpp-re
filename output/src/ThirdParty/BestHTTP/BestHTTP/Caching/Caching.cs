// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Caching
// Classes: 4
// Methods: 82

namespace ThirdParty.BestHTTP.BestHTTP.Caching
{
    public class HTTPCacheFileInfo
    {
        public System.Uri <Uri>k__BackingField; // 0x10
        public System.DateTime <LastAccess>k__BackingField; // 0x18
        public int <BodyLength>k__BackingField; // 0x20
        public string <ETag>k__BackingField; // 0x28
        public string <LastModified>k__BackingField; // 0x30
        public System.DateTime <Expires>k__BackingField; // 0x38
        public long <Age>k__BackingField; // 0x40
        public long <MaxAge>k__BackingField; // 0x48
        public System.DateTime <Date>k__BackingField; // 0x50
        public bool <MustRevalidate>k__BackingField; // 0x58
        public System.DateTime <Received>k__BackingField; // 0x60
        public string <ConstructedPath>k__BackingField; // 0x68
        public ulong <MappedNameIDX>k__BackingField; // 0x70

        // ── Methods ──
        public void get_Uri(){} // RVA: 0x2F8380
        public void set_Uri(){} // RVA: 0x2DEE30
        public void get_LastAccess(){} // RVA: 0x2E07C0
        public void set_LastAccess(){} // RVA: 0xC5BE60
        public void get_BodyLength(){} // RVA: 0x760030
        public void set_BodyLength(){} // RVA: 0x99E0D0
        public void get_ETag(){} // RVA: 0x30B130
        public void set_ETag(){} // RVA: 0x2DEE90
        public void get_LastModified(){} // RVA: 0x6374D0
        public void set_LastModified(){} // RVA: 0x30B890
        public void get_Expires(){} // RVA: 0x4976A0
        public void set_Expires(){} // RVA: 0xF501D0
        public void get_Age(){} // RVA: 0x35A740
        public void set_Age(){} // RVA: 0x36B37A0
        public void get_MaxAge(){} // RVA: 0x358730
        public void set_MaxAge(){} // RVA: 0x179D760
        public void get_Date(){} // RVA: 0x37E0E0
        public void set_Date(){} // RVA: 0x4C4D50
        public void get_MustRevalidate(){} // RVA: 0x59FF30
        public void set_MustRevalidate(){} // RVA: 0xC5F680
        public void get_Received(){} // RVA: 0x37B370
        public void set_Received(){} // RVA: 0x5AC6B90
        public void get_ConstructedPath(){} // RVA: 0x358D50
        public void set_ConstructedPath(){} // RVA: 0x358D60
        public void get_MappedNameIDX(){} // RVA: 0x3A5590
        public void set_MappedNameIDX(){} // RVA: 0x1F0AB80
        public void .ctor(){} // RVA: 0x9831000 | overloaded x3
        public void SaveTo(){} // RVA: 0x98312E0
        public void GetPath(){} // RVA: 0x98314B0
        public void IsExists(){} // RVA: 0x9831680
        public void Delete(){} // RVA: 0x9831760
        public void Reset(){} // RVA: 0x9831880
        public void AlreadyStored(){} // RVA: 0x9831AE0
        public void SetUpCachingValues(){} // RVA: 0x9831DA0
        public void WillExpireInTheFuture(){} // RVA: 0x98322B0
        public void SetUpRevalidationHeaders(){} // RVA: 0x9832440
        public void GetBodyStream(){} // RVA: 0x9832500
        public void ReadResponseTo(){} // RVA: 0x9832640
        public void Store(){} // RVA: 0x98328A0
        public void GetSaveStream(){} // RVA: 0x9832FA0
        public void CompareTo(){} // RVA: 0x98336F0
    }

    public class HTTPCacheMaintananceParams
    {
        public System.TimeSpan <DeleteOlder>k__BackingField; // 0x10
        public ulong <MaxCacheSize>k__BackingField; // 0x18

        // ── Methods ──
        public void get_DeleteOlder(){} // RVA: 0x2F8380
        public void set_DeleteOlder(){} // RVA: 0x1967700
        public void get_MaxCacheSize(){} // RVA: 0x2E07C0
        public void set_MaxCacheSize(){} // RVA: 0xC5BE60
        public void .ctor(){} // RVA: 0x5C397B0
    }

    public class HTTPCacheService
    {
        public int LibraryVersion;
        public bool isSupported;
        public bool IsSupportCheckDone; // 0x1
        public System.Collections.Generic.Dictionary`2<System.Uri,BestHTTP.Caching.HTTPCacheFileInfo> library; // 0x8

        // ── Methods ──
        public void get_IsSupported(){} // RVA: 0x98339D0
        public void get_CacheFolder(){} // RVA: 0x9833C80
        public void set_CacheFolder(){} // RVA: 0x9833CE0
        public void get_LibraryPath(){} // RVA: 0x9833DA0
        public void set_LibraryPath(){} // RVA: 0x9833E00
        public void get_IsDoingMaintainence(){} // RVA: 0x9833EC0
        public void .cctor(){} // RVA: 0x9833F60
        public void CheckSetup(){} // RVA: 0x9834140
        public void SetupCacheFolder(){} // RVA: 0x98341B0
        public void GetNameIdx(){} // RVA: 0x9834710
        public void HasEntity(){} // RVA: 0x9834830
        public void DeleteEntity(){} // RVA: 0x9834A20
        public void DeleteEntityImpl(){} // RVA: 0x9834BD0
        public void IsCachedEntityExpiresInTheFuture(){} // RVA: 0x9834E40
        public void SetHeaders(){} // RVA: 0x98351A0
        public void GetEntity(){} // RVA: 0x9835460
        public void GetFullResponse(){} // RVA: 0x98355E0
        public void IsCacheble(){} // RVA: 0x9835800
        public void Store(){} // RVA: 0x9835C20
        public void PrepareStreamed(){} // RVA: 0x98360D0
        public void BeginClear(){} // RVA: 0x9836400
        public void ClearImpl(){} // RVA: 0x9836600
        public void BeginMaintainence(){} // RVA: 0x98368E0
        public void MaintananceImpl(){} // RVA: 0x9836BA0
        public void GetCacheEntityCount(){} // RVA: 0x9837530
        public void GetCacheSize(){} // RVA: 0x9837690
        public void GetCacheSizeImpl(){} // RVA: 0x98377D0
        public void LoadLibrary(){} // RVA: 0x98379B0
        public void SaveLibrary(){} // RVA: 0x98380D0
        public void SetBodyLength(){} // RVA: 0x98386F0
        public void DeleteUnusedFiles(){} // RVA: 0x9838B00
    }

    public class UriComparer
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x98337A0
        public void GetHashCode(){} // RVA: 0x9833980
        public void .ctor(){} // RVA: 0x2DD310
    }

}