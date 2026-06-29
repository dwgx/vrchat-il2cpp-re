// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 34

namespace ThirdParty.DotNet.System.Net
{
    public class EndPoint : Object
    {
        // ── Methods ──
        public void get_AddressFamily(){} // RVA: 0x7580B20
        public void Serialize(){} // RVA: 0x7580B50
        public void Create(){} // RVA: 0x7580B80
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EndPointListener : Object
    {
        public object listener;
        public object endpoint;
        public object sock;
        public object prefixes;
        public object unhandled;
        public object all;
        public object cert;
        public object secure;
        public object unregistered;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75AF970
        public void get_Listener(){} // RVA: 0xB5DBF0
        public void Accept(){} // RVA: 0x75AFE00
        public void ProcessAccept(){} // RVA: 0x75AFEF0
        public void OnAccept(){} // RVA: 0x75B01C0
        public void RemoveConnection(){} // RVA: 0x75B01D0
        public void BindContext(){} // RVA: 0x75B0320
        public void UnbindContext(){} // RVA: 0x75B0430
        public void SearchListener(){} // RVA: 0x75B0460
        public void MatchFromList(){} // RVA: 0x75B0AA0
        public void AddSpecial(){} // RVA: 0x75B0D80
        public void RemoveSpecial(){} // RVA: 0x75B1010
        public void CheckIfRemove(){} // RVA: 0x75B1150
        public void Close(){} // RVA: 0x75B1220
        public void AddPrefix(){} // RVA: 0x75B1590
        public void RemovePrefix(){} // RVA: 0x75B1B70
    }

    public class EndPointManager : Object
    {
        public object ip_to_endpoints;

        // ── Methods ──
        public void AddListener(){} // RVA: 0x75B1FD0
        public void AddPrefix(){} // RVA: 0x75B24F0
        public void AddPrefixInternal(){} // RVA: 0x75B2670
        public void GetEPListener(){} // RVA: 0x75B2A40
        public void RemoveEndPoint(){} // RVA: 0x75B2EC0
        public void RemoveListener(){} // RVA: 0x75B3190
        public void RemovePrefix(){} // RVA: 0x75B34B0
        public void RemovePrefixInternal(){} // RVA: 0x75B3630
        public void .cctor(){} // RVA: 0x75B3960
    }

    public class ExceptionHelper : Object
    {
        // ── Methods ──
        public void get_MethodNotImplementedException(){} // RVA: 0x7584430
        public void get_PropertyNotImplementedException(){} // RVA: 0x75844B0
        public void get_TimeoutException(){} // RVA: 0x7584530
        public void get_PropertyNotSupportedException(){} // RVA: 0x75845B0
        public void get_RequestAbortedException(){} // RVA: 0x7584630
    }

}