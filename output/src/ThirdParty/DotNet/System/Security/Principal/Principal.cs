// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Principal
// Classes: 2
// Methods: 19

namespace ThirdParty.DotNet.System.Security.Principal
{
    public class IIdentity
    {
        public object Name;
        public object AuthenticationType;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4E078E90
        public void get_AuthenticationType(){} // RVA: 0x7FFD4E078E90
    }

    public class WindowsIdentity : ClaimsIdentity
    {
        public UIntPtr AuthenticationType; // 0x78
        public string Name; // 0x80
        public 0x6642E388 Owner; // 0x88
        public bool _authenticated; // 0x8C
        public string _name; // 0x90
        public System.Runtime.Serialization.SerializationInfo _info; // 0x98
        public UIntPtr invalidWindows;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53870930 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFD53870970
        public void GetCurrent(){} // RVA: 0x7FFD53870980
        public void Impersonate(){} // RVA: 0x7FFD53870AE0
        public void get_AuthenticationType(){} // RVA: 0x7FFD4E70F410
        public void get_Name(){} // RVA: 0x7FFD53870B30
        public void get_Owner(){} // RVA: 0x7FFD53870BE0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFD53870C20
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD538710F0
        public void CloneAsBase(){} // RVA: 0x7FFD53871970
        public void GetTokenInternal(){} // RVA: 0x7FFD4E505600
        public void SetToken(){} // RVA: 0x7FFD53871980
        public void GetCurrentToken(){} // RVA: 0x7FFD4E919180
        public void GetTokenName(){} // RVA: 0x7FFD53871AD0
        public void .cctor(){} // RVA: 0x7FFD53871AE0
    }

}