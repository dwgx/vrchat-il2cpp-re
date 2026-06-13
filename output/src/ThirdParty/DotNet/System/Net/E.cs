// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 34

namespace ThirdParty.DotNet.System.Net
{
    public class EndPoint
    {
        // ── Methods ──
        public void get_AddressFamily(){} // RVA: 0x6B1C880
        public void Serialize(){} // RVA: 0x6B1C8B0
        public void Create(){} // RVA: 0x6B1C8E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class EndPointListener
    {
        public System.Net.HttpListener listener; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B4CA70
        public void get_Listener(){} // RVA: 0x2F8380
        public void Accept(){} // RVA: 0x6B4CEF0
        public void ProcessAccept(){} // RVA: 0x6B4CFE0
        public void OnAccept(){} // RVA: 0x6B4D2D0
        public void RemoveConnection(){} // RVA: 0x6B4D2E0
        public void BindContext(){} // RVA: 0x6B4D460
        public void UnbindContext(){} // RVA: 0x6B4D570
        public void SearchListener(){} // RVA: 0x6B4D5A0
        public void MatchFromList(){} // RVA: 0x6B4DC20
        public void AddSpecial(){} // RVA: 0x6B4DF20
        public void RemoveSpecial(){} // RVA: 0x6B4E1A0
        public void CheckIfRemove(){} // RVA: 0x6B4E2E0
        public void Close(){} // RVA: 0x6B4E3B0
        public void AddPrefix(){} // RVA: 0x6B4E740
        public void RemovePrefix(){} // RVA: 0x6B4ED20
    }

    public class EndPointManager
    {
        // ── Methods ──
        public void AddListener(){} // RVA: 0x6B4F180
        public void AddPrefix(){} // RVA: 0x6B4F6D0
        public void AddPrefixInternal(){} // RVA: 0x6B4F890
        public void GetEPListener(){} // RVA: 0x6B4FC50
        public void RemoveEndPoint(){} // RVA: 0x6B501E0
        public void RemoveListener(){} // RVA: 0x6B50500
        public void RemovePrefix(){} // RVA: 0x6B50850
        public void RemovePrefixInternal(){} // RVA: 0x6B50A10
        public void .cctor(){} // RVA: 0x6B50D40
    }

    public class ExceptionHelper
    {
        public object Creator;

        // ── Methods ──
        public void get_MethodNotImplementedException(){} // RVA: 0x6B1FE20
        public void get_PropertyNotImplementedException(){} // RVA: 0x6B1FEA0
        public void get_TimeoutException(){} // RVA: 0x6B1FF20
        public void get_PropertyNotSupportedException(){} // RVA: 0x6B1FFA0
        public void get_RequestAbortedException(){} // RVA: 0x6B20020
    }

}