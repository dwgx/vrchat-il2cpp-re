// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Cookies
// Classes: 3
// Methods: 65

namespace ThirdParty.BestHTTP.BestHTTP.Cookies
{
    public class Cookie : Object
    {
        public object Version;
        public object _name;
        public object _value;
        public object _date;
        public object _lastAccess;
        public object _expires;
        public object _maxAge;
        public object _isSession;
        public object _domain;
        public object _path;
        public object _isSecure;
        public object _isHttpOnly;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void get_Value(){} // RVA: 0xB465B0
        public void set_Value(){} // RVA: 0xBA9BA0
        public void get_Date(){} // RVA: 0xB700F0
        public void set_Date(){} // RVA: 0x13B3F80
        public void get_LastAccess(){} // RVA: 0xB70160
        public void set_LastAccess(){} // RVA: 0x116B360
        public void get_Expires(){} // RVA: 0xD33E60
        public void set_Expires(){} // RVA: 0x27FA7C0
        public void get_MaxAge(){} // RVA: 0xD05CA0
        public void set_MaxAge(){} // RVA: 0xE9F6B0
        public void get_IsSession(){} // RVA: 0xC02470
        public void set_IsSession(){} // RVA: 0xC02480
        public void get_Domain(){} // RVA: 0xBBF8F0
        public void set_Domain(){} // RVA: 0xBBF900
        public void get_Path(){} // RVA: 0xBE58B0
        public void set_Path(){} // RVA: 0xCA4DF0
        public void get_IsSecure(){} // RVA: 0xE3F480
        public void set_IsSecure(){} // RVA: 0x1546550
        public void get_IsHttpOnly(){} // RVA: 0x5C8BB10
        public void set_IsHttpOnly(){} // RVA: 0x6A92EB0
        public void .ctor(){} // RVA: 0xA4D1E20
        public void WillExpireInTheFuture(){} // RVA: 0xA4D1E80
        public void GuessSize(){} // RVA: 0xA4D1FC0
        public void Parse(){} // RVA: 0xA4D2020
        public void SaveTo(){} // RVA: 0xA4D2900
        public void LoadFrom(){} // RVA: 0xA4D2B30
        public void ToString(){} // RVA: 0xA4D2E60
        public void Equals(){} // RVA: 0xA4D2F20
        public void GetHashCode(){} // RVA: 0x273F540
        public void ReadValue(){} // RVA: 0xA4D3100
        public void ParseCookieHeader(){} // RVA: 0xA4D3190
        public void CompareTo(){} // RVA: 0xA4D3500
    }

    public class CookieJar : Object
    {
        public object Version;
        public object AccessThreshold;
        public object Cookies;
        public object _cookieFolder;
        public object _libraryPath;
        public object rwLock;
        public object _isSavingSupported;
        public object IsSupportCheckDone;
        public object Loaded;

        // ── Methods ──
        public void get_IsSavingSupported(){} // RVA: 0xA4D3670
        public void get_CookieFolder(){} // RVA: 0xA4D3920
        public void set_CookieFolder(){} // RVA: 0xA4D3980
        public void get_LibraryPath(){} // RVA: 0xA4D3A40
        public void set_LibraryPath(){} // RVA: 0xA4D3AA0
        public void SetupFolder(){} // RVA: 0xA4D3B60
        public void Set(){} // RVA: 0xA4D5B20
        public void Maintain(){} // RVA: 0xA4D43C0
        public void Persist(){} // RVA: 0xA4D49A0
        public void Load(){} // RVA: 0xA4D50F0
        public void Get(){} // RVA: 0xA4D57D0
        public void GetAll(){} // RVA: 0xA4D5D50
        public void Clear(){} // RVA: 0xA4D6190
        public void Remove(){} // RVA: 0xA4D6410
        public void Find(){} // RVA: 0xA4D6760
        public void .cctor(){} // RVA: 0xA4D68B0
    }

    public class Cookie[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}