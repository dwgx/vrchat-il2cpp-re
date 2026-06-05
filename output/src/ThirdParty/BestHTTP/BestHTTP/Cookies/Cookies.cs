// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Cookies
// Classes: 2
// Methods: 60

namespace ThirdParty.BestHTTP.BestHTTP.Cookies
{
    public class Cookie
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void set_Name(){} // RVA: 0x7FFAF2D8EE30
        public void get_Value(){} // RVA: 0x7FFAF2D907C0
        public void set_Value(){} // RVA: 0x7FFAF2DF3E80
        public void get_Date(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Date(){} // RVA: 0x7FFAF35983A0
        public void get_LastAccess(){} // RVA: 0x7FFAF2DBB130
        public void set_LastAccess(){} // RVA: 0x7FFAF335C650
        public void get_Expires(){} // RVA: 0x7FFAF30E74D0
        public void set_Expires(){} // RVA: 0x7FFAF4A24DF0
        public void get_MaxAge(){} // RVA: 0x7FFAF2F476A0
        public void set_MaxAge(){} // RVA: 0x7FFAF3A001D0
        public void get_IsSession(){} // RVA: 0x7FFAF2E48C00
        public void set_IsSession(){} // RVA: 0x7FFAF2E48C10
        public void get_Domain(){} // RVA: 0x7FFAF2E08730
        public void set_Domain(){} // RVA: 0x7FFAF2E08740
        public void get_Path(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Path(){} // RVA: 0x7FFAF2EE54D0
        public void get_IsSecure(){} // RVA: 0x7FFAF304FF30
        public void set_IsSecure(){} // RVA: 0x7FFAF370F680
        public void get_IsHttpOnly(){} // RVA: 0x7FFAF7A94B90
        public void set_IsHttpOnly(){} // RVA: 0x7FFAF8ACE3A0
        public void .ctor(){} // RVA: 0x7FFAFC2DC130 | overloaded x6
        public void WillExpireInTheFuture(){} // RVA: 0x7FFAFC2DC190
        public void GuessSize(){} // RVA: 0x7FFAFC2DC2D0
        public void Parse(){} // RVA: 0x7FFAFC2DC340
        public void SaveTo(){} // RVA: 0x7FFAFC2DCC50
        public void LoadFrom(){} // RVA: 0x7FFAFC2DCEA0
        public void ToString(){} // RVA: 0x7FFAFC2DD1D0
        public void Equals(){} // RVA: 0x7FFAFC2DD290 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF496C800
        public void ReadValue(){} // RVA: 0x7FFAFC2DD470
        public void ParseCookieHeader(){} // RVA: 0x7FFAFC2DD510
        public void CompareTo(){} // RVA: 0x7FFAFC2DD7E0
    }

    public class CookieJar
    {
        public object Uri;
        public object LastAccess;
        public object BodyLength;

        // ── Methods ──
        public void get_IsSavingSupported(){} // RVA: 0x7FFAFC2DD950
        public void get_CookieFolder(){} // RVA: 0x7FFAFC2DDC00
        public void set_CookieFolder(){} // RVA: 0x7FFAFC2DDC60
        public void get_LibraryPath(){} // RVA: 0x7FFAFC2DDD20
        public void set_LibraryPath(){} // RVA: 0x7FFAFC2DDD80
        public void SetupFolder(){} // RVA: 0x7FFAFC2DDE40
        public void Set(){} // RVA: 0x7FFAFC2DFDE0 | overloaded x3
        public void Maintain(){} // RVA: 0x7FFAFC2DE680
        public void Persist(){} // RVA: 0x7FFAFC2DEC60
        public void Load(){} // RVA: 0x7FFAFC2DF3B0
        public void Get(){} // RVA: 0x7FFAFC2DFA90
        public void GetAll(){} // RVA: 0x7FFAFC2E0010
        public void Clear(){} // RVA: 0x7FFAFC2E0450 | overloaded x3
        public void Remove(){} // RVA: 0x7FFAFC2E06D0
        public void Find(){} // RVA: 0x7FFAFC2E0A20
        public void .cctor(){} // RVA: 0x7FFAFC2E0B60
    }

}