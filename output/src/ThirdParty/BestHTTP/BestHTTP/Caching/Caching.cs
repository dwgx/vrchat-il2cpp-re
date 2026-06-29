// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Caching
// Classes: 4
// Methods: 80

namespace ThirdParty.BestHTTP.BestHTTP.Caching
{
    public class HTTPCacheFileInfo : Object
    {
        // ── Methods ──
        public void get_Uri(){} // RVA: 0x7A80F2570
        public void set_Uri(){} // RVA: 0x7A80D8E20
        public void get_LastAccess(){} // RVA: 0x7A80DA7B0
        public void set_LastAccess(){} // RVA: 0x7A8A224D0
        public void get_BodyLength(){} // RVA: 0x7A851DB90
        public void set_BodyLength(){} // RVA: 0x7A8738180
        public void get_ETag(){} // RVA: 0x7A8105330
        public void set_ETag(){} // RVA: 0x7A80D8E80
        public void get_LastModified(){} // RVA: 0x7A83F69F0
        public void set_LastModified(){} // RVA: 0x7A8105A90
        public void get_Expires(){} // RVA: 0x7A8292C30
        public void set_Expires(){} // RVA: 0x7A82C26E0
        public void get_Age(){} // RVA: 0x7A8154D80
        public void set_Age(){} // RVA: 0x7A82C0820
        public void get_MaxAge(){} // RVA: 0x7A8152D80
        public void set_MaxAge(){} // RVA: 0x7A9558880
        public void get_Date(){} // RVA: 0x7A8178B90
        public void set_Date(){} // RVA: 0x7A82C1E60
        public void get_MustRevalidate(){} // RVA: 0x7A8359360
        public void set_MustRevalidate(){} // RVA: 0x7A8A21900
        public void get_Received(){} // RVA: 0x7A8175DF0
        public void set_Received(){} // RVA: 0x7AD8B41D0
        public void get_ConstructedPath(){} // RVA: 0x7A8153390
        public void set_ConstructedPath(){} // RVA: 0x7A81533A0
        public void get_MappedNameIDX(){} // RVA: 0x7A81A00E0
        public void set_MappedNameIDX(){} // RVA: 0x7A9D11610
        public void .ctor(){} // RVA: 0x7B166B9C0
        public void SaveTo(){} // RVA: 0x7B166BCA0
        public void GetPath(){} // RVA: 0x7B166BE70
        public void IsExists(){} // RVA: 0x7B166C040
        public void Delete(){} // RVA: 0x7B166C120
        public void Reset(){} // RVA: 0x7B166C240
        public void AlreadyStored(){} // RVA: 0x7B166C4A0
        public void SetUpCachingValues(){} // RVA: 0x7B166C770
        public void WillExpireInTheFuture(){} // RVA: 0x7B166CC80
        public void SetUpRevalidationHeaders(){} // RVA: 0x7B166CE10
        public void GetBodyStream(){} // RVA: 0x7B166CED0
        public void ReadResponseTo(){} // RVA: 0x7B166D010
        public void Store(){} // RVA: 0x7B166D290
        public void GetSaveStream(){} // RVA: 0x7B166D990
        public void CompareTo(){} // RVA: 0x7B166E0F0
    }

    public class HTTPCacheMaintananceParams : Object
    {
        // ── Methods ──
        public void get_DeleteOlder(){} // RVA: 0x7A80F2570
        public void set_DeleteOlder(){} // RVA: 0x7A97242F0
        public void get_MaxCacheSize(){} // RVA: 0x7A80DA7B0
        public void set_MaxCacheSize(){} // RVA: 0x7A8A224D0
        public void .ctor(){} // RVA: 0x7ADA277F0
    }

    public class HTTPCacheService : Object
    {
        // ── Methods ──
        public void get_IsSupported(){} // RVA: 0x7B166E3D0
        public void get_CacheFolder(){} // RVA: 0x7B166E680
        public void set_CacheFolder(){} // RVA: 0x7B166E6E0
        public void get_LibraryPath(){} // RVA: 0x7B166E7A0
        public void set_LibraryPath(){} // RVA: 0x7B166E800
        public void get_IsDoingMaintainence(){} // RVA: 0x7B166E8C0
        public void .cctor(){} // RVA: 0x7B166E960
        public void CheckSetup(){} // RVA: 0x7B166EB40
        public void SetupCacheFolder(){} // RVA: 0x7B166EBB0
        public void GetNameIdx(){} // RVA: 0x7B166F110
        public void HasEntity(){} // RVA: 0x7B166F230
        public void DeleteEntity(){} // RVA: 0x7B166F420
        public void DeleteEntityImpl(){} // RVA: 0x7B166F5D0
        public void IsCachedEntityExpiresInTheFuture(){} // RVA: 0x7B166F840
        public void SetHeaders(){} // RVA: 0x7B166FBB0
        public void GetEntity(){} // RVA: 0x7B166FE80
        public void GetFullResponse(){} // RVA: 0x7B1670010
        public void IsCacheble(){} // RVA: 0x7B1670230
        public void Store(){} // RVA: 0x7B1670650
        public void PrepareStreamed(){} // RVA: 0x7B1670B10
        public void BeginClear(){} // RVA: 0x7B1670E40
        public void ClearImpl(){} // RVA: 0x7B1671040
        public void BeginMaintainence(){} // RVA: 0x7B1671320
        public void MaintananceImpl(){} // RVA: 0x7B16715E0
        public void GetCacheEntityCount(){} // RVA: 0x7B1671F80
        public void GetCacheSize(){} // RVA: 0x7B16720E0
        public void GetCacheSizeImpl(){} // RVA: 0x7B1672220
        public void LoadLibrary(){} // RVA: 0x7B1672410
        public void SaveLibrary(){} // RVA: 0x7B1672B30
        public void SetBodyLength(){} // RVA: 0x7B1673150
        public void DeleteUnusedFiles(){} // RVA: 0x7B1673560
    }

    public class UriComparer : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7B166E1A0
        public void GetHashCode(){} // RVA: 0x7B166E380
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}