// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Principal
// Classes: 10
// Methods: 82

namespace ThirdParty.DotNet.System.Security.Principal
{
    public class GenericIdentity : ClaimsIdentity
    {
        public object m_name;
        public object m_type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x672BA30
        public void Clone(){} // RVA: 0x672BB20
        public void get_Claims(){} // RVA: 0x672BC40
        public void get_Name(){} // RVA: 0xCD3320
        public void get_AuthenticationType(){} // RVA: 0xCD48B0
        public void AddNameClaim(){} // RVA: 0x672BCF0
    }

    public class GenericPrincipal : ClaimsPrincipal
    {
        public object m_identity;
        public object m_roles;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x672BE70
    }

    public class IIdentity
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x87C0A0
        public void get_AuthenticationType(){} // RVA: 0x87C0A0
    }

    public class IdentityNotMappedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022D0
        public void GetObjectData(){} // RVA: 0xB43310
    }

    public class IdentityReference : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Value(){} // RVA: 0x87C0A0
        public void Equals(){} // RVA: 0x87D350
        public void GetHashCode(){} // RVA: 0x87C130
        public void ToString(){} // RVA: 0x87C0A0
        public void Translate(){} // RVA: 0x87C540
        public void op_Equality(){} // RVA: 0x672C220
        public void op_Inequality(){} // RVA: 0x672C2E0
    }

    public class NTAccount : IdentityReference
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x672C3A0
        public void get_Value(){} // RVA: 0xB5DBF0
        public void Equals(){} // RVA: 0x672C4C0
        public void GetHashCode(){} // RVA: 0x672C590
        public void ToString(){} // RVA: 0xBFA210
        public void Translate(){} // RVA: 0x672C5D0
        public void op_Equality(){} // RVA: 0x672C220
    }

    public class SecurityIdentifier : IdentityReference
    {
        public object buffer;
        public object MaxBinaryLength;
        public object MinBinaryLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x672CA10
        public void CreateFromBinaryForm(){} // RVA: 0x672CC80
        public void get_BinaryLength(){} // RVA: 0x17F0080
        public void get_Value(){} // RVA: 0x672CE10
        public void GetSidAuthority(){} // RVA: 0x672D150
        public void GetSidSubAuthorityCount(){} // RVA: 0x672D200
        public void GetSidSubAuthority(){} // RVA: 0x672D230
        public void CompareTo(){} // RVA: 0x672D2C0
        public void Equals(){} // RVA: 0x672D590
        public void GetBinaryForm(){} // RVA: 0x672D660
        public void GetHashCode(){} // RVA: 0x672C590
        public void ToString(){} // RVA: 0xBFA210
        public void Translate(){} // RVA: 0x672D750
        public void op_Equality(){} // RVA: 0x672C220
        public void op_Inequality(){} // RVA: 0x672C2E0
        public void ParseSddlForm(){} // RVA: 0x672DB40
        public void TryParseAuthority(){} // RVA: 0x672E380
        public void TryParseSubAuthority(){} // RVA: 0x672E490
        public void .cctor(){} // RVA: 0x672E5A0
    }

    public class WellKnownAccount : Object
    {
        public object _wellKnownValue;
        public object _isAbsolute;
        public object _sid;
        public object _rid;
        public object _name;
        public object _sddlForm;
        public object accounts;

        // ── Methods ──
        public void set_WellKnownValue(){} // RVA: 0xB460A0
        public void get_IsAbsolute(){} // RVA: 0xC9C250
        public void set_IsAbsolute(){} // RVA: 0xC9C260
        public void get_Sid(){} // RVA: 0xB465B0
        public void set_Sid(){} // RVA: 0xBA9BA0
        public void set_Rid(){} // RVA: 0xB70100
        public void get_Name(){} // RVA: 0xB70160
        public void set_Name(){} // RVA: 0xB44DC0
        public void get_SddlForm(){} // RVA: 0xD33E60
        public void set_SddlForm(){} // RVA: 0xB708C0
        public void LookupBySid(){} // RVA: 0x672E600
        public void LookupByName(){} // RVA: 0x672E700
        public void LookupBySddlForm(){} // RVA: 0x672E800
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x672E900
    }

    public class WindowsIdentity : ClaimsIdentity
    {
        public object _token;
        public object _type;
        public object _account;
        public object _authenticated;
        public object _name;
        public object _info;
        public object invalidWindows;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6731D30
        public void Dispose(){} // RVA: 0x6731D70
        public void GetCurrent(){} // RVA: 0x6731D80
        public void Impersonate(){} // RVA: 0x6731EE0
        public void get_AuthenticationType(){} // RVA: 0xCD48B0
        public void get_Name(){} // RVA: 0x6731F30
        public void get_Owner(){} // RVA: 0x6731FE0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x6732020
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x67324D0
        public void CloneAsBase(){} // RVA: 0x6732D20
        public void GetTokenInternal(){} // RVA: 0xCD3320
        public void SetToken(){} // RVA: 0x6732D30
        public void GetCurrentToken(){} // RVA: 0xDAC980
        public void GetTokenName(){} // RVA: 0x6732E80
        public void .cctor(){} // RVA: 0x6732E90
    }

    public class WindowsImpersonationContext : Object
    {
        public object _token;
        public object undo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6732ED0
        public void Dispose(){} // RVA: 0x6732EE0
        public void Undo(){} // RVA: 0x6732F00
        public void CloseToken(){} // RVA: 0x6732F30
        public void DuplicateToken(){} // RVA: 0x6732F40
        public void SetCurrentToken(){} // RVA: 0x6732F50
        public void RevertToSelf(){} // RVA: 0x6732F60
    }

}