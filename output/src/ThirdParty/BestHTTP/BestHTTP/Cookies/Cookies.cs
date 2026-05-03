// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Cookies
// Classes: 2
// Methods: 60

namespace ThirdParty.BestHTTP.BestHTTP.Cookies
{
    public class Cookie : Object
    {
        public int Version;
        public string _name; // 0x10
        public string _value; // 0x18
        public System.DateTime _date; // 0x20
        public System.DateTime _lastAccess; // 0x28
        public System.DateTime _expires; // 0x30
        public long _maxAge; // 0x38
        public bool _isSession; // 0x40
        public string _domain; // 0x48
        public string _path; // 0x50
        public bool _isSecure; // 0x58

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void get_Date(){} // RVA: 0x7FFE811290C0
        public void set_Date(){} // RVA: 0x7FFE81859C50
        public void get_LastAccess(){} // RVA: 0x7FFE81129130
        public void set_LastAccess(){} // RVA: 0x7FFE8164D390
        public void get_Expires(){} // RVA: 0x7FFE8144E200
        public void set_Expires(){} // RVA: 0x7FFE82D00170
        public void get_MaxAge(){} // RVA: 0x7FFE8143BA80
        public void set_MaxAge(){} // RVA: 0x7FFE81CDDAA0
        public void get_IsSession(){} // RVA: 0x7FFE811B6C00
        public void set_IsSession(){} // RVA: 0x7FFE811B6C10
        public void get_Domain(){} // RVA: 0x7FFE81176730
        public void set_Domain(){} // RVA: 0x7FFE81176740
        public void get_Path(){} // RVA: 0x7FFE8119C0E0
        public void set_Path(){} // RVA: 0x7FFE812534D0
        public void get_IsSecure(){} // RVA: 0x7FFE813A1140
        public void set_IsSecure(){} // RVA: 0x7FFE819E83C0
        public void get_IsHttpOnly(){} // RVA: 0x7FFE85BA8C00
        public void set_IsHttpOnly(){} // RVA: 0x7FFE86B5F180
        public void .ctor(){} // RVA: 0x7FFE8A28E470 | overloaded x6
        public void WillExpireInTheFuture(){} // RVA: 0x7FFE8A28E4D0
        public void GuessSize(){} // RVA: 0x7FFE8A28E610
        public void Parse(){} // RVA: 0x7FFE8A28E680
        public void SaveTo(){} // RVA: 0x7FFE8A28EF90
        public void LoadFrom(){} // RVA: 0x7FFE8A28F1E0
        public void ToString(){} // RVA: 0x7FFE8A28F510
        public void Equals(){} // RVA: 0x7FFE8A28F5D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE82C46B00
        public void ReadValue(){} // RVA: 0x7FFE8A28F7B0
        public void ParseCookieHeader(){} // RVA: 0x7FFE8A28F850
        public void CompareTo(){} // RVA: 0x7FFE8A28FB20
    }

    public class CookieJar : Object
    {
        public int Version;
        public System.TimeSpan AccessThreshold;
        public System.Collections.Generic.List`1<BestHTTP.Cookies.Cookie> Cookies; // 0x8

        // ── Methods ──
        public void get_IsSavingSupported(){} // RVA: 0x7FFE8A28FC90
        public void get_CookieFolder(){} // RVA: 0x7FFE8A28FF40
        public void set_CookieFolder(){} // RVA: 0x7FFE8A28FFA0
        public void get_LibraryPath(){} // RVA: 0x7FFE8A290060
        public void set_LibraryPath(){} // RVA: 0x7FFE8A2900C0
        public void SetupFolder(){} // RVA: 0x7FFE8A290180
        public void Set(){} // RVA: 0x7FFE8A292120 | overloaded x3
        public void Maintain(){} // RVA: 0x7FFE8A2909C0
        public void Persist(){} // RVA: 0x7FFE8A290FA0
        public void Load(){} // RVA: 0x7FFE8A2916F0
        public void Get(){} // RVA: 0x7FFE8A291DD0
        public void GetAll(){} // RVA: 0x7FFE8A292350
        public void Clear(){} // RVA: 0x7FFE8A292790 | overloaded x3
        public void Remove(){} // RVA: 0x7FFE8A292A10
        public void Find(){} // RVA: 0x7FFE8A292D60
        public void .cctor(){} // RVA: 0x7FFE8A292EA0
    }

}