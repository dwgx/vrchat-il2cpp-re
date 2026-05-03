// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Principal
// Classes: 11
// Methods: 89

namespace ThirdParty.DotNet.System.Security.Principal
{
    public class GenericIdentity : ClaimsIdentity
    {
        public string m_name; // 0x78
        public string m_type; // 0x80
        public object field_2; // 0x36C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867F3FB0 | overloaded x3
        public void Clone(){} // RVA: 0x7FFE867F40A0
        public void get_Claims(){} // RVA: 0x7FFE867F41C0
        public void get_Name(){} // RVA: 0x7FFE81463AE0
        public void get_AuthenticationType(){} // RVA: 0x7FFE81280C30
        public void AddNameClaim(){} // RVA: 0x7FFE867F4270
    }

    public class GenericPrincipal : ClaimsPrincipal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867F43F0
    }

    public class IIdentity
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_AuthenticationType(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IPrincipal
    {
    }

    public class IdentityNotMappedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3C70 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFE810FB310
    }

    public class IdentityReference : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Value(){} // RVA: 0x7FFE80E2E2E0
        public void Equals(){} // RVA: 0x7FFE80E2F3B0
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void Translate(){} // RVA: 0x7FFE80E2E390
        public void op_Equality(){} // RVA: 0x7FFE867F4790
        public void op_Inequality(){} // RVA: 0x7FFE867F4850
    }

    public class NTAccount : IdentityReference
    {
        public string _value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867F4910
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void Equals(){} // RVA: 0x7FFE867F4A30
        public void GetHashCode(){} // RVA: 0x7FFE867F4B00
        public void ToString(){} // RVA: 0x7FFE811AFBC0
        public void Translate(){} // RVA: 0x7FFE867F4B40
        public void op_Equality(){} // RVA: 0x7FFE867F4790
    }

    public class SecurityIdentifier : IdentityReference
    {
        public byte[] buffer; // 0x10
        public int MaxBinaryLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867F4F80 | overloaded x2
        public void CreateFromBinaryForm(){} // RVA: 0x7FFE867F51F0
        public void get_BinaryLength(){} // RVA: 0x7FFE81CCB610
        public void get_Value(){} // RVA: 0x7FFE867F5380
        public void GetSidAuthority(){} // RVA: 0x7FFE867F56B0
        public void GetSidSubAuthorityCount(){} // RVA: 0x7FFE867F5760
        public void GetSidSubAuthority(){} // RVA: 0x7FFE867F5790
        public void CompareTo(){} // RVA: 0x7FFE867F5810
        public void Equals(){} // RVA: 0x7FFE867F5AE0 | overloaded x2
        public void GetBinaryForm(){} // RVA: 0x7FFE867F5BB0
        public void GetHashCode(){} // RVA: 0x7FFE867F4B00
        public void ToString(){} // RVA: 0x7FFE811AFBC0
        public void Translate(){} // RVA: 0x7FFE867F5CA0
        public void op_Equality(){} // RVA: 0x7FFE867F4790
        public void op_Inequality(){} // RVA: 0x7FFE867F4850
        public void ParseSddlForm(){} // RVA: 0x7FFE867F6090
        public void TryParseAuthority(){} // RVA: 0x7FFE867F68B0
        public void TryParseSubAuthority(){} // RVA: 0x7FFE867F69C0
        public void .cctor(){} // RVA: 0x7FFE867F6AD0
    }

    public class WellKnownAccount : Object
    {
        public 0x664C7254 _wellKnownValue; // 0x10
        public bool _isAbsolute; // 0x14
        public string _sid; // 0x18
        public string _rid; // 0x20
        public string _name; // 0x28
        public string _sddlForm; // 0x30

        // ── Methods ──
        public void set_WellKnownValue(){} // RVA: 0x7FFE810FE0C0
        public void get_IsAbsolute(){} // RVA: 0x7FFE8124ABD0
        public void set_IsAbsolute(){} // RVA: 0x7FFE8124ABE0
        public void get_Sid(){} // RVA: 0x7FFE810FE7C0
        public void set_Sid(){} // RVA: 0x7FFE81161E80
        public void set_Rid(){} // RVA: 0x7FFE811290D0
        public void get_Name(){} // RVA: 0x7FFE81129130
        public void set_Name(){} // RVA: 0x7FFE810FCE90
        public void get_SddlForm(){} // RVA: 0x7FFE8144E200
        public void set_SddlForm(){} // RVA: 0x7FFE81129890
        public void LookupBySid(){} // RVA: 0x7FFE867F6B30
        public void LookupByName(){} // RVA: 0x7FFE867F6C30
        public void LookupBySddlForm(){} // RVA: 0x7FFE867F6D30
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE867F6E30
    }

    public class WindowsIdentity : ClaimsIdentity
    {
        public UIntPtr _token; // 0x78
        public string _type; // 0x80
        public 0x664C72AC _account; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867FA240 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFE867FA280
        public void GetCurrent(){} // RVA: 0x7FFE867FA290
        public void Impersonate(){} // RVA: 0x7FFE867FA3F0
        public void get_AuthenticationType(){} // RVA: 0x7FFE81280C30
        public void get_Name(){} // RVA: 0x7FFE867FA440
        public void get_Owner(){} // RVA: 0x7FFE867FA4F0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFE867FA530
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE867FAA00
        public void CloneAsBase(){} // RVA: 0x7FFE867FB280
        public void GetTokenInternal(){} // RVA: 0x7FFE81463AE0
        public void SetToken(){} // RVA: 0x7FFE867FB290
        public void GetCurrentToken(){} // RVA: 0x7FFE813240E0
        public void GetTokenName(){} // RVA: 0x7FFE867FB3E0
        public void .cctor(){} // RVA: 0x7FFE867FB3F0
    }

    public class WindowsImpersonationContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867FB430
        public void Dispose(){} // RVA: 0x7FFE867FB440
        public void Undo(){} // RVA: 0x7FFE867FB460
        public void CloseToken(){} // RVA: 0x7FFE867FB490
        public void DuplicateToken(){} // RVA: 0x7FFE867FB4A0
        public void SetCurrentToken(){} // RVA: 0x7FFE867FB4B0
        public void RevertToSelf(){} // RVA: 0x7FFE867FB4C0
    }

}