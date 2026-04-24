// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Principal
// Classes: 2
// Methods: 19

namespace ThirdParty.DotNet.System.Security.Principal
{
    public class IIdentity
    {
        // ── Original Methods ──
        public void get_Name(){} // RVA: 0x7ffaa86491d0
        public void get_AuthenticationType(){} // RVA: 0x7ffaa86491d0
    }

    public class WindowsIdentity : ClaimsIdentity
    {
        public object _account; // 0x35DB3470
        public object _info; // 0x35DB3470

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaade71ae0
        public void .ctor(){} // RVA: 0x7ffaade71ae0
        public void .ctor(){} // RVA: 0x7ffaade71ae0
        public void Dispose(){} // RVA: 0x7ffaade71b20
        public void Impersonate(){} // RVA: 0x7ffaade71c90
        public void get_AuthenticationType(){} // RVA: 0x7ffaa8d1a3b0
        public void get_Name(){} // RVA: 0x7ffaade71ce0
        public void get_Owner(){} // RVA: 0x7ffaade71d90
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7ffaade71dd0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7ffaade722a0
        public void CloneAsBase(){} // RVA: 0x7ffaade72b20
        public void .cctor(){} // RVA: 0x7ffaade72c90
        // ── Binary Analysis Named ──
        public void GetCurrent(){} // RVA: 0x7ffaade71b30
        public void GetTokenInternal(){} // RVA: 0x7ffaa8af68f0
        public void SetToken(){} // RVA: 0x7ffaade72b30
        public void GetCurrentToken(){} // RVA: 0x7ffaa8f22da0
        public void GetTokenName(){} // RVA: 0x7ffaade72c80
    }

}