// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Cookies
// Classes: 2
// Methods: 60

namespace ThirdParty.BestHTTP.BestHTTP.Cookies
{
    public class Cookie
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void set_Name(){} // RVA: 0x2DEE30
        public void get_Value(){} // RVA: 0x2E07C0
        public void set_Value(){} // RVA: 0x343E80
        public void get_Date(){} // RVA: 0x30B0C0
        public void set_Date(){} // RVA: 0xAE83A0
        public void get_LastAccess(){} // RVA: 0x30B130
        public void set_LastAccess(){} // RVA: 0x8AC650
        public void get_Expires(){} // RVA: 0x6374D0
        public void set_Expires(){} // RVA: 0x1F74DF0
        public void get_MaxAge(){} // RVA: 0x4976A0
        public void set_MaxAge(){} // RVA: 0xF501D0
        public void get_IsSession(){} // RVA: 0x398C00
        public void set_IsSession(){} // RVA: 0x398C10
        public void get_Domain(){} // RVA: 0x358730
        public void set_Domain(){} // RVA: 0x358740
        public void get_Path(){} // RVA: 0x37E0E0
        public void set_Path(){} // RVA: 0x4354D0
        public void get_IsSecure(){} // RVA: 0x59FF30
        public void set_IsSecure(){} // RVA: 0xC5F680
        public void get_IsHttpOnly(){} // RVA: 0x4FE4B90
        public void set_IsHttpOnly(){} // RVA: 0x601E3A0
        public void .ctor(){} // RVA: 0x982C130 | overloaded x6
        public void WillExpireInTheFuture(){} // RVA: 0x982C190
        public void GuessSize(){} // RVA: 0x982C2D0
        public void Parse(){} // RVA: 0x982C340
        public void SaveTo(){} // RVA: 0x982CC50
        public void LoadFrom(){} // RVA: 0x982CEA0
        public void ToString(){} // RVA: 0x982D1D0
        public void Equals(){} // RVA: 0x982D290 | overloaded x2
        public void GetHashCode(){} // RVA: 0x1EBC800
        public void ReadValue(){} // RVA: 0x982D470
        public void ParseCookieHeader(){} // RVA: 0x982D510
        public void CompareTo(){} // RVA: 0x982D7E0
    }

    public class CookieJar
    {
        public object Uri;
        public object LastAccess;
        public object BodyLength;

        // ── Methods ──
        public void get_IsSavingSupported(){} // RVA: 0x982D950
        public void get_CookieFolder(){} // RVA: 0x982DC00
        public void set_CookieFolder(){} // RVA: 0x982DC60
        public void get_LibraryPath(){} // RVA: 0x982DD20
        public void set_LibraryPath(){} // RVA: 0x982DD80
        public void SetupFolder(){} // RVA: 0x982DE40
        public void Set(){} // RVA: 0x982FDE0 | overloaded x3
        public void Maintain(){} // RVA: 0x982E680
        public void Persist(){} // RVA: 0x982EC60
        public void Load(){} // RVA: 0x982F3B0
        public void Get(){} // RVA: 0x982FA90
        public void GetAll(){} // RVA: 0x9830010
        public void Clear(){} // RVA: 0x9830450 | overloaded x3
        public void Remove(){} // RVA: 0x98306D0
        public void Find(){} // RVA: 0x9830A20
        public void .cctor(){} // RVA: 0x9830B60
    }

}