// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Principal
// Classes: 11
// Methods: 89

namespace ThirdParty.DotNet.System.Security.Principal
{
    public class GenericIdentity : ClaimsIdentity
    {
        public string Claims; // 0x78
        public string Name; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC844A6A0 | overloaded x3
        public void Clone(){} // RVA: 0x7FFAC844A790
        public void get_Claims(){} // RVA: 0x7FFAC844A8B0
        public void get_Name(){} // RVA: 0x7FFAC30E5600
        public void get_AuthenticationType(){} // RVA: 0x7FFAC32EF410
        public void AddNameClaim(){} // RVA: 0x7FFAC844A960
    }

    public class GenericPrincipal : ClaimsPrincipal
    {
        public System.Security.Principal.IIdentity m_identity; // 0x28
        public string[] m_roles; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC844AAE0
    }

    public class IIdentity
    {
        public object Name;
        public object AuthenticationType;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_AuthenticationType(){} // RVA: 0x7FFAC2C58E90
    }

    public class IPrincipal
    {
    }

    public class IdentityNotMappedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F75D0 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFAC2F21310
    }

    public class IdentityReference : Object
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Value(){} // RVA: 0x7FFAC2C58E90
        public void Equals(){} // RVA: 0x7FFAC2C59F60
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void Translate(){} // RVA: 0x7FFAC2C58F40
        public void op_Equality(){} // RVA: 0x7FFAC844AE80
        public void op_Inequality(){} // RVA: 0x7FFAC844AF40
    }

    public class NTAccount : IdentityReference
    {
        public string Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC844B000
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void Equals(){} // RVA: 0x7FFAC844B120
        public void GetHashCode(){} // RVA: 0x7FFAC844B1F0
        public void ToString(){} // RVA: 0x7FFAC2FD5BC0
        public void Translate(){} // RVA: 0x7FFAC844B230
        public void op_Equality(){} // RVA: 0x7FFAC844AE80
    }

    public class SecurityIdentifier : IdentityReference
    {
        public byte[] BinaryLength; // 0x10
        public int Value;
        public int MinBinaryLength; // 0x4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC844B670 | overloaded x2
        public void CreateFromBinaryForm(){} // RVA: 0x7FFAC844B8E0
        public void get_BinaryLength(){} // RVA: 0x7FFAC3510620
        public void get_Value(){} // RVA: 0x7FFAC844BA70
        public void GetSidAuthority(){} // RVA: 0x7FFAC844BDA0
        public void GetSidSubAuthorityCount(){} // RVA: 0x7FFAC844BE50
        public void GetSidSubAuthority(){} // RVA: 0x7FFAC844BE80
        public void CompareTo(){} // RVA: 0x7FFAC844BF00
        public void Equals(){} // RVA: 0x7FFAC844C1D0 | overloaded x2
        public void GetBinaryForm(){} // RVA: 0x7FFAC844C2A0
        public void GetHashCode(){} // RVA: 0x7FFAC844B1F0
        public void ToString(){} // RVA: 0x7FFAC2FD5BC0
        public void Translate(){} // RVA: 0x7FFAC844C390
        public void op_Equality(){} // RVA: 0x7FFAC844AE80
        public void op_Inequality(){} // RVA: 0x7FFAC844AF40
        public void ParseSddlForm(){} // RVA: 0x7FFAC844C780
        public void TryParseAuthority(){} // RVA: 0x7FFAC844CFA0
        public void TryParseSubAuthority(){} // RVA: 0x7FFAC844D0B0
        public void .cctor(){} // RVA: 0x7FFAC844D1C0
    }

    public class WellKnownAccount : Object
    {
        public 0x6B0CE330 WellKnownValue; // 0x10
        public bool IsAbsolute; // 0x14
        public string Sid; // 0x18
        public string Rid; // 0x20
        public string Name; // 0x28
        public string SddlForm; // 0x30
        public System.Security.Principal.WellKnownAccount[] accounts;

        // ── Methods ──
        public void set_WellKnownValue(){} // RVA: 0x7FFAC2F240C0
        public void get_IsAbsolute(){} // RVA: 0x7FFAC3070BD0
        public void set_IsAbsolute(){} // RVA: 0x7FFAC3070BE0
        public void get_Sid(){} // RVA: 0x7FFAC2F247C0
        public void set_Sid(){} // RVA: 0x7FFAC2F87E80
        public void set_Rid(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Name(){} // RVA: 0x7FFAC2F4F130
        public void set_Name(){} // RVA: 0x7FFAC2F22E90
        public void get_SddlForm(){} // RVA: 0x7FFAC31D95E0
        public void set_SddlForm(){} // RVA: 0x7FFAC2F4F890
        public void LookupBySid(){} // RVA: 0x7FFAC844D220
        public void LookupByName(){} // RVA: 0x7FFAC844D320
        public void LookupBySddlForm(){} // RVA: 0x7FFAC844D420
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC844D520
    }

    public class WindowsIdentity : ClaimsIdentity
    {
        public UIntPtr AuthenticationType; // 0x78
        public string Name; // 0x80
        public 0x6B0CE388 Owner; // 0x88
        public bool _authenticated; // 0x8C
        public string _name; // 0x90
        public System.Runtime.Serialization.SerializationInfo _info; // 0x98
        public UIntPtr invalidWindows;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8450930 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFAC8450970
        public void GetCurrent(){} // RVA: 0x7FFAC8450980
        public void Impersonate(){} // RVA: 0x7FFAC8450AE0
        public void get_AuthenticationType(){} // RVA: 0x7FFAC32EF410
        public void get_Name(){} // RVA: 0x7FFAC8450B30
        public void get_Owner(){} // RVA: 0x7FFAC8450BE0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAC8450C20
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC84510F0
        public void CloneAsBase(){} // RVA: 0x7FFAC8451970
        public void GetTokenInternal(){} // RVA: 0x7FFAC30E5600
        public void SetToken(){} // RVA: 0x7FFAC8451980
        public void GetCurrentToken(){} // RVA: 0x7FFAC34F9180
        public void GetTokenName(){} // RVA: 0x7FFAC8451AD0
        public void .cctor(){} // RVA: 0x7FFAC8451AE0
    }

    public class WindowsImpersonationContext : Object
    {
        public UIntPtr _token; // 0x10
        public bool undo; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8451B20
        public void Dispose(){} // RVA: 0x7FFAC8451B30
        public void Undo(){} // RVA: 0x7FFAC8451B50
        public void CloseToken(){} // RVA: 0x7FFAC8451B80
        public void DuplicateToken(){} // RVA: 0x7FFAC8451B90
        public void SetCurrentToken(){} // RVA: 0x7FFAC8451BA0
        public void RevertToSelf(){} // RVA: 0x7FFAC8451BB0
    }

}