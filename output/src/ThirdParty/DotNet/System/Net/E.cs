// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 34

namespace ThirdParty.DotNet.System.Net
{
    public class EndPoint : Object
    {
        public object AddressFamily;

        // ── Methods ──
        public void get_AddressFamily(){} // RVA: 0x7FFAC92B3400
        public void Serialize(){} // RVA: 0x7FFAC92B3430
        public void Create(){} // RVA: 0x7FFAC92B3460
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EndPointListener : Object
    {
        public System.Net.HttpListener Listener; // 0x10
        public System.Net.IPEndPoint endpoint; // 0x18
        public System.Net.Sockets.Socket sock; // 0x20
        public System.Collections.Hashtable prefixes; // 0x28
        public System.Collections.ArrayList unhandled; // 0x30
        public System.Collections.ArrayList all; // 0x38
        public System.Security.Cryptography.X509Certificates.X509Certificate cert; // 0x40
        public bool secure; // 0x48
        public System.Collections.Generic.Dictionary`2<System.Net.HttpConnection,System.Net.HttpConnection> unregistered; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92E35F0
        public void get_Listener(){} // RVA: 0x7FFAC2F3C380
        public void Accept(){} // RVA: 0x7FFAC92E3A70
        public void ProcessAccept(){} // RVA: 0x7FFAC92E3B60
        public void OnAccept(){} // RVA: 0x7FFAC92E3E50
        public void RemoveConnection(){} // RVA: 0x7FFAC92E3E60
        public void BindContext(){} // RVA: 0x7FFAC92E3FE0
        public void UnbindContext(){} // RVA: 0x7FFAC92E40F0
        public void SearchListener(){} // RVA: 0x7FFAC92E4120
        public void MatchFromList(){} // RVA: 0x7FFAC92E47A0
        public void AddSpecial(){} // RVA: 0x7FFAC92E4AA0
        public void RemoveSpecial(){} // RVA: 0x7FFAC92E4D20
        public void CheckIfRemove(){} // RVA: 0x7FFAC92E4E60
        public void Close(){} // RVA: 0x7FFAC92E4F30
        public void AddPrefix(){} // RVA: 0x7FFAC92E52C0
        public void RemovePrefix(){} // RVA: 0x7FFAC92E58A0
    }

    public class EndPointManager : Object
    {
        public System.Collections.Hashtable ip_to_endpoints;

        // ── Methods ──
        public void AddListener(){} // RVA: 0x7FFAC92E5D00
        public void AddPrefix(){} // RVA: 0x7FFAC92E6250
        public void AddPrefixInternal(){} // RVA: 0x7FFAC92E6410
        public void GetEPListener(){} // RVA: 0x7FFAC92E67D0
        public void RemoveEndPoint(){} // RVA: 0x7FFAC92E6D60
        public void RemoveListener(){} // RVA: 0x7FFAC92E7080
        public void RemovePrefix(){} // RVA: 0x7FFAC92E73D0
        public void RemovePrefixInternal(){} // RVA: 0x7FFAC92E7590
        public void .cctor(){} // RVA: 0x7FFAC92E78C0
    }

    public class ExceptionHelper : Object
    {
        public object MethodNotImplementedException;
        public object PropertyNotImplementedException;
        public object TimeoutException;
        public object PropertyNotSupportedException;
        public object RequestAbortedException;

        // ── Methods ──
        public void get_MethodNotImplementedException(){} // RVA: 0x7FFAC92B69A0
        public void get_PropertyNotImplementedException(){} // RVA: 0x7FFAC92B6A20
        public void get_TimeoutException(){} // RVA: 0x7FFAC92B6AA0
        public void get_PropertyNotSupportedException(){} // RVA: 0x7FFAC92B6B20
        public void get_RequestAbortedException(){} // RVA: 0x7FFAC92B6BA0
    }

}