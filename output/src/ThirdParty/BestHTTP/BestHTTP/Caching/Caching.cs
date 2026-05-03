// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Caching
// Classes: 4
// Methods: 82

namespace ThirdParty.BestHTTP.BestHTTP.Caching
{
    public class HTTPCacheFileInfo : Object
    {
        public System.Uri _uri; // 0x10
        public System.DateTime _lastAccess; // 0x18
        public int _bodyLength; // 0x20
        public string _eTag; // 0x28
        public string _lastModified; // 0x30
        public System.DateTime _expires; // 0x38
        public long _age; // 0x40
        public long _maxAge; // 0x48
        public System.DateTime _date; // 0x50
        public bool _mustRevalidate; // 0x58
        public System.DateTime _received; // 0x60
        public string _constructedPath; // 0x68
        public ulong _mappedNameIDX; // 0x70

        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7FFE81116380
        public void set_Uri(){} // RVA: 0x7FFE810FCE30
        public void get_LastAccess(){} // RVA: 0x7FFE810FE7C0
        public void set_LastAccess(){} // RVA: 0x7FFE819EA910
        public void get_BodyLength(){} // RVA: 0x7FFE8151D690
        public void set_BodyLength(){} // RVA: 0x7FFE8170B670
        public void get_ETag(){} // RVA: 0x7FFE81129130
        public void set_ETag(){} // RVA: 0x7FFE810FCE90
        public void get_LastModified(){} // RVA: 0x7FFE8144E200
        public void set_LastModified(){} // RVA: 0x7FFE81129890
        public void get_Expires(){} // RVA: 0x7FFE8143BA80
        public void set_Expires(){} // RVA: 0x7FFE81CDDAA0
        public void get_Age(){} // RVA: 0x7FFE81178740
        public void set_Age(){} // RVA: 0x7FFE84337900
        public void get_MaxAge(){} // RVA: 0x7FFE81176730
        public void set_MaxAge(){} // RVA: 0x7FFE82502600
        public void get_Date(){} // RVA: 0x7FFE8119C0E0
        public void set_Date(){} // RVA: 0x7FFE82506C00
        public void get_MustRevalidate(){} // RVA: 0x7FFE813A1140
        public void set_MustRevalidate(){} // RVA: 0x7FFE819E83C0
        public void get_Received(){} // RVA: 0x7FFE81199370
        public void set_Received(){} // RVA: 0x7FFE866079C0
        public void get_ConstructedPath(){} // RVA: 0x7FFE81176D50
        public void set_ConstructedPath(){} // RVA: 0x7FFE81176D60
        public void get_MappedNameIDX(){} // RVA: 0x7FFE811C3590
        public void set_MappedNameIDX(){} // RVA: 0x7FFE82C95C70
        public void .ctor(){} // RVA: 0x7FFE8A293340 | overloaded x3
        public void SaveTo(){} // RVA: 0x7FFE8A293620
        public void GetPath(){} // RVA: 0x7FFE8A2937F0
        public void IsExists(){} // RVA: 0x7FFE8A2939C0
        public void Delete(){} // RVA: 0x7FFE8A293AA0
        public void Reset(){} // RVA: 0x7FFE8A293BC0
        public void AlreadyStored(){} // RVA: 0x7FFE8A293E20
        public void SetUpCachingValues(){} // RVA: 0x7FFE8A2940E0
        public void WillExpireInTheFuture(){} // RVA: 0x7FFE8A2945F0
        public void SetUpRevalidationHeaders(){} // RVA: 0x7FFE8A294780
        public void GetBodyStream(){} // RVA: 0x7FFE8A294840
        public void ReadResponseTo(){} // RVA: 0x7FFE8A294980
        public void Store(){} // RVA: 0x7FFE8A294BE0
        public void GetSaveStream(){} // RVA: 0x7FFE8A2952E0
        public void CompareTo(){} // RVA: 0x7FFE8A295A30
    }

    public class HTTPCacheMaintananceParams : Object
    {
        public System.TimeSpan _deleteOlder; // 0x10
        public ulong _maxCacheSize; // 0x18

        // ── Methods ──
        public void get_DeleteOlder(){} // RVA: 0x7FFE81116380
        public void set_DeleteOlder(){} // RVA: 0x7FFE826F2ED0
        public void get_MaxCacheSize(){} // RVA: 0x7FFE810FE7C0
        public void set_MaxCacheSize(){} // RVA: 0x7FFE819EA910
        public void .ctor(){} // RVA: 0x7FFE8677A600
    }

    public class HTTPCacheService : Object
    {
        public int LibraryVersion;
        public bool isSupported;
        public bool IsSupportCheckDone; // 0x1
        public System.Collections.Generic.Dictionary`2<System.Uri,BestHTTP.Caching.HTTPCacheFileInfo> library; // 0x8

        // ── Methods ──
        public void get_IsSupported(){} // RVA: 0x7FFE8A295D10
        public void get_CacheFolder(){} // RVA: 0x7FFE8A295FC0
        public void set_CacheFolder(){} // RVA: 0x7FFE8A296020
        public void get_LibraryPath(){} // RVA: 0x7FFE8A2960E0
        public void set_LibraryPath(){} // RVA: 0x7FFE8A296140
        public void get_IsDoingMaintainence(){} // RVA: 0x7FFE8A296200
        public void .cctor(){} // RVA: 0x7FFE8A2962A0
        public void CheckSetup(){} // RVA: 0x7FFE8A296480
        public void SetupCacheFolder(){} // RVA: 0x7FFE8A2964F0
        public void GetNameIdx(){} // RVA: 0x7FFE8A296A50
        public void HasEntity(){} // RVA: 0x7FFE8A296B70
        public void DeleteEntity(){} // RVA: 0x7FFE8A296D60
        public void DeleteEntityImpl(){} // RVA: 0x7FFE8A296F10
        public void IsCachedEntityExpiresInTheFuture(){} // RVA: 0x7FFE8A297180
        public void SetHeaders(){} // RVA: 0x7FFE8A2974E0
        public void GetEntity(){} // RVA: 0x7FFE8A2977A0
        public void GetFullResponse(){} // RVA: 0x7FFE8A297920
        public void IsCacheble(){} // RVA: 0x7FFE8A297B40
        public void Store(){} // RVA: 0x7FFE8A297F60
        public void PrepareStreamed(){} // RVA: 0x7FFE8A298410
        public void BeginClear(){} // RVA: 0x7FFE8A298740
        public void ClearImpl(){} // RVA: 0x7FFE8A298940
        public void BeginMaintainence(){} // RVA: 0x7FFE8A298C20
        public void MaintananceImpl(){} // RVA: 0x7FFE8A298EE0
        public void GetCacheEntityCount(){} // RVA: 0x7FFE8A299870
        public void GetCacheSize(){} // RVA: 0x7FFE8A2999D0
        public void GetCacheSizeImpl(){} // RVA: 0x7FFE8A299B10
        public void LoadLibrary(){} // RVA: 0x7FFE8A299CF0
        public void SaveLibrary(){} // RVA: 0x7FFE8A29A410
        public void SetBodyLength(){} // RVA: 0x7FFE8A29AA30
        public void DeleteUnusedFiles(){} // RVA: 0x7FFE8A29AE40
    }

    public class UriComparer : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE8A295AE0
        public void GetHashCode(){} // RVA: 0x7FFE8A295CC0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}