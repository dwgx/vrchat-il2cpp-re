// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Principal
// Classes: 11
// Methods: 89

namespace ThirdParty.DotNet.System.Security.Principal
{
    public class GenericIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CB30B0 | overloaded x3
        public void Clone(){} // RVA: 0x5CB31A0
        public void get_Claims(){} // RVA: 0x5CB32C0
        public void get_Name(){} // RVA: 0x4C7C50
        public void get_AuthenticationType(){} // RVA: 0x462D00
        public void AddNameClaim(){} // RVA: 0x5CB3370
    }

    public class GenericPrincipal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CB34F0
    }

    public class IIdentity
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0xCD60
        public void get_AuthenticationType(){} // RVA: 0xCD60
    }

    public class IPrincipal
    {
    }

    public class IdentityNotMappedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E240 | overloaded x2
        public void GetObjectData(){} // RVA: 0x2DD310
    }

    public class IdentityReference
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Value(){} // RVA: 0xCD60
        public void Equals(){} // RVA: 0xDE40
        public void GetHashCode(){} // RVA: 0xD840
        public void ToString(){} // RVA: 0xCD60
        public void Translate(){} // RVA: 0xCE10
        public void op_Equality(){} // RVA: 0x5CB3890
        public void op_Inequality(){} // RVA: 0x5CB3950
    }

    public class NTAccount
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CB3A10
        public void get_Value(){} // RVA: 0x2F8380
        public void Equals(){} // RVA: 0x5CB3B30
        public void GetHashCode(){} // RVA: 0x5CB3C00
        public void ToString(){} // RVA: 0x391BC0
        public void Translate(){} // RVA: 0x5CB3C40
        public void op_Equality(){} // RVA: 0x5CB3890
    }

    public class SecurityIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CB4080 | overloaded x2
        public void CreateFromBinaryForm(){} // RVA: 0x5CB42F0
        public void get_BinaryLength(){} // RVA: 0xF3F910
        public void get_Value(){} // RVA: 0x5CB4480
        public void GetSidAuthority(){} // RVA: 0x5CB47B0
        public void GetSidSubAuthorityCount(){} // RVA: 0x5CB4860
        public void GetSidSubAuthority(){} // RVA: 0x5CB4890
        public void CompareTo(){} // RVA: 0x5CB4910
        public void Equals(){} // RVA: 0x5CB4BE0 | overloaded x2
        public void GetBinaryForm(){} // RVA: 0x5CB4CB0
        public void GetHashCode(){} // RVA: 0x5CB3C00
        public void ToString(){} // RVA: 0x391BC0
        public void Translate(){} // RVA: 0x5CB4DA0
        public void op_Equality(){} // RVA: 0x5CB3890
        public void op_Inequality(){} // RVA: 0x5CB3950
        public void ParseSddlForm(){} // RVA: 0x5CB5190
        public void TryParseAuthority(){} // RVA: 0x5CB59B0
        public void TryParseSubAuthority(){} // RVA: 0x5CB5AC0
        public void .cctor(){} // RVA: 0x5CB5BD0
    }

    public class WellKnownAccount
    {
        // ── Methods ──
        public void set_WellKnownValue(){} // RVA: 0x2E00C0
        public void get_IsAbsolute(){} // RVA: 0x42CBD0
        public void set_IsAbsolute(){} // RVA: 0x42CBE0
        public void get_Sid(){} // RVA: 0x2E07C0
        public void set_Sid(){} // RVA: 0x343E80
        public void set_Rid(){} // RVA: 0x30B0D0
        public void get_Name(){} // RVA: 0x30B130
        public void set_Name(){} // RVA: 0x2DEE90
        public void get_SddlForm(){} // RVA: 0x6374D0
        public void set_SddlForm(){} // RVA: 0x30B890
        public void LookupBySid(){} // RVA: 0x5CB5C30
        public void LookupByName(){} // RVA: 0x5CB5D30
        public void LookupBySddlForm(){} // RVA: 0x5CB5E30
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5CB5F30
    }

    public class WindowsIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CB9340 | overloaded x3
        public void Dispose(){} // RVA: 0x5CB9380
        public void GetCurrent(){} // RVA: 0x5CB9390
        public void Impersonate(){} // RVA: 0x5CB94F0
        public void get_AuthenticationType(){} // RVA: 0x462D00
        public void get_Name(){} // RVA: 0x5CB9540
        public void get_Owner(){} // RVA: 0x5CB95F0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x5CB9630
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x5CB9B00
        public void CloneAsBase(){} // RVA: 0x5CBA380
        public void GetTokenInternal(){} // RVA: 0x4C7C50
        public void SetToken(){} // RVA: 0x5CBA390
        public void GetCurrentToken(){} // RVA: 0x519240
        public void GetTokenName(){} // RVA: 0x5CBA4E0
        public void .cctor(){} // RVA: 0x5CBA4F0
    }

    public class WindowsImpersonationContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CBA530
        public void Dispose(){} // RVA: 0x5CBA540
        public void Undo(){} // RVA: 0x5CBA560
        public void CloseToken(){} // RVA: 0x5CBA590
        public void DuplicateToken(){} // RVA: 0x5CBA5A0
        public void SetCurrentToken(){} // RVA: 0x5CBA5B0
        public void RevertToSelf(){} // RVA: 0x5CBA5C0
    }

}