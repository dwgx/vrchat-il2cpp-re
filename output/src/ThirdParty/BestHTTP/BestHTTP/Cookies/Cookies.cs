// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Cookies
// Classes: 2
// Methods: 60

namespace ThirdParty.BestHTTP.BestHTTP.Cookies
{
    public class Cookie : Object
    {
        public int Name;
        public string Value; // 0x10
        public string Date; // 0x18
        public System.DateTime LastAccess; // 0x20
        public System.DateTime Expires; // 0x28
        public System.DateTime MaxAge; // 0x30
        public long IsSession; // 0x38
        public bool Domain; // 0x40
        public string Path; // 0x48
        public string IsSecure; // 0x50
        public bool IsHttpOnly; // 0x58
        public bool <IsHttpOnly>k__BackingField; // 0x59

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void get_Date(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Date(){} // RVA: 0x7FFAC370BEE0
        public void get_LastAccess(){} // RVA: 0x7FFAC2F4F130
        public void set_LastAccess(){} // RVA: 0x7FFAC33D3BF0
        public void get_Expires(){} // RVA: 0x7FFAC31D95E0
        public void set_Expires(){} // RVA: 0x7FFAC4A98000
        public void get_MaxAge(){} // RVA: 0x7FFAC31D0140
        public void set_MaxAge(){} // RVA: 0x7FFAC35233F0
        public void get_IsSession(){} // RVA: 0x7FFAC2FDCC00
        public void set_IsSession(){} // RVA: 0x7FFAC2FDCC10
        public void get_Domain(){} // RVA: 0x7FFAC2F9C730
        public void set_Domain(){} // RVA: 0x7FFAC2F9C740
        public void get_Path(){} // RVA: 0x7FFAC2FC20E0
        public void set_Path(){} // RVA: 0x7FFAC30794D0
        public void get_IsSecure(){} // RVA: 0x7FFAC313F600
        public void set_IsSecure(){} // RVA: 0x7FFAC3892770
        public void get_IsHttpOnly(){} // RVA: 0x7FFAC778CF40
        public void set_IsHttpOnly(){} // RVA: 0x7FFAC87B5A20
        public void .ctor(){} // RVA: 0x7FFACBE34E50 | overloaded x6
        public void WillExpireInTheFuture(){} // RVA: 0x7FFACBE34EB0
        public void GuessSize(){} // RVA: 0x7FFACBE34FF0
        public void Parse(){} // RVA: 0x7FFACBE35060
        public void SaveTo(){} // RVA: 0x7FFACBE35970
        public void LoadFrom(){} // RVA: 0x7FFACBE35BC0
        public void ToString(){} // RVA: 0x7FFACBE35EF0
        public void Equals(){} // RVA: 0x7FFACBE35FB0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC49DB960
        public void ReadValue(){} // RVA: 0x7FFACBE36190
        public void ParseCookieHeader(){} // RVA: 0x7FFACBE36230
        public void CompareTo(){} // RVA: 0x7FFACBE36500
    }

    public class CookieJar : Object
    {
        public int IsSavingSupported;
        public System.TimeSpan CookieFolder;
        public System.Collections.Generic.List`1<BestHTTP.Cookies.Cookie> LibraryPath; // 0x8
        public string <CookieFolder>k__BackingField; // 0x10
        public string <LibraryPath>k__BackingField; // 0x18
        public System.Threading.ReaderWriterLockSlim rwLock; // 0x20
        public bool _isSavingSupported; // 0x28
        public bool IsSupportCheckDone; // 0x29
        public bool Loaded; // 0x2A

        // ── Methods ──
        public void get_IsSavingSupported(){} // RVA: 0x7FFACBE36670
        public void get_CookieFolder(){} // RVA: 0x7FFACBE36920
        public void set_CookieFolder(){} // RVA: 0x7FFACBE36980
        public void get_LibraryPath(){} // RVA: 0x7FFACBE36A40
        public void set_LibraryPath(){} // RVA: 0x7FFACBE36AA0
        public void SetupFolder(){} // RVA: 0x7FFACBE36B60
        public void Set(){} // RVA: 0x7FFACBE38B00 | overloaded x3
        public void Maintain(){} // RVA: 0x7FFACBE373A0
        public void Persist(){} // RVA: 0x7FFACBE37980
        public void Load(){} // RVA: 0x7FFACBE380D0
        public void Get(){} // RVA: 0x7FFACBE387B0
        public void GetAll(){} // RVA: 0x7FFACBE38D30
        public void Clear(){} // RVA: 0x7FFACBE39170 | overloaded x3
        public void Remove(){} // RVA: 0x7FFACBE393F0
        public void Find(){} // RVA: 0x7FFACBE39740
        public void .cctor(){} // RVA: 0x7FFACBE39880
    }

}