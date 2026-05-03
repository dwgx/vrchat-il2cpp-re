// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 4
// Methods: 34

namespace ThirdParty.DotNet.System.Net
{
    public class EndPoint : Object
    {
        // ── Methods ──
        public void get_AddressFamily(){} // RVA: 0x7FFE8765BB40
        public void Serialize(){} // RVA: 0x7FFE8765BB70
        public void Create(){} // RVA: 0x7FFE8765BBA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EndPointListener : Object
    {
        public System.Net.HttpListener listener; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8768BD20
        public void get_Listener(){} // RVA: 0x7FFE81116380
        public void Accept(){} // RVA: 0x7FFE8768C1A0
        public void ProcessAccept(){} // RVA: 0x7FFE8768C290
        public void OnAccept(){} // RVA: 0x7FFE8768C580
        public void RemoveConnection(){} // RVA: 0x7FFE8768C590
        public void BindContext(){} // RVA: 0x7FFE8768C710
        public void UnbindContext(){} // RVA: 0x7FFE8768C820
        public void SearchListener(){} // RVA: 0x7FFE8768C850
        public void MatchFromList(){} // RVA: 0x7FFE8768CED0
        public void AddSpecial(){} // RVA: 0x7FFE8768D1D0
        public void RemoveSpecial(){} // RVA: 0x7FFE8768D450
        public void CheckIfRemove(){} // RVA: 0x7FFE8768D590
        public void Close(){} // RVA: 0x7FFE8768D660
        public void AddPrefix(){} // RVA: 0x7FFE8768D9F0
        public void RemovePrefix(){} // RVA: 0x7FFE8768DFD0
    }

    public class EndPointManager : Object
    {
        // ── Methods ──
        public void AddListener(){} // RVA: 0x7FFE8768E430
        public void AddPrefix(){} // RVA: 0x7FFE8768E980
        public void AddPrefixInternal(){} // RVA: 0x7FFE8768EB40
        public void GetEPListener(){} // RVA: 0x7FFE8768EF00
        public void RemoveEndPoint(){} // RVA: 0x7FFE8768F490
        public void RemoveListener(){} // RVA: 0x7FFE8768F7B0
        public void RemovePrefix(){} // RVA: 0x7FFE8768FB00
        public void RemovePrefixInternal(){} // RVA: 0x7FFE8768FCC0
        public void .cctor(){} // RVA: 0x7FFE8768FFF0
    }

    public class ExceptionHelper : Object
    {
        // ── Methods ──
        public void get_MethodNotImplementedException(){} // RVA: 0x7FFE8765F0E0
        public void get_PropertyNotImplementedException(){} // RVA: 0x7FFE8765F160
        public void get_TimeoutException(){} // RVA: 0x7FFE8765F1E0
        public void get_PropertyNotSupportedException(){} // RVA: 0x7FFE8765F260
        public void get_RequestAbortedException(){} // RVA: 0x7FFE8765F2E0
    }

}