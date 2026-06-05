// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Principal
// Classes: 11
// Methods: 89

namespace ThirdParty.DotNet.System.Security.Principal
{
    public class GenericIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87630B0 | overloaded x3
        public void Clone(){} // RVA: 0x7FFAF87631A0
        public void get_Claims(){} // RVA: 0x7FFAF87632C0
        public void get_Name(){} // RVA: 0x7FFAF2F77C50
        public void get_AuthenticationType(){} // RVA: 0x7FFAF2F12D00
        public void AddNameClaim(){} // RVA: 0x7FFAF8763370
    }

    public class GenericPrincipal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87634F0
    }

    public class IIdentity
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2ABCD60
        public void get_AuthenticationType(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IPrincipal
    {
    }

    public class IdentityNotMappedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE240 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFAF2D8D310
    }

    public class IdentityReference
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Value(){} // RVA: 0x7FFAF2ABCD60
        public void Equals(){} // RVA: 0x7FFAF2ABDE40
        public void GetHashCode(){} // RVA: 0x7FFAF2ABD840
        public void ToString(){} // RVA: 0x7FFAF2ABCD60
        public void Translate(){} // RVA: 0x7FFAF2ABCE10
        public void op_Equality(){} // RVA: 0x7FFAF8763890
        public void op_Inequality(){} // RVA: 0x7FFAF8763950
    }

    public class NTAccount
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8763A10
        public void get_Value(){} // RVA: 0x7FFAF2DA8380
        public void Equals(){} // RVA: 0x7FFAF8763B30
        public void GetHashCode(){} // RVA: 0x7FFAF8763C00
        public void ToString(){} // RVA: 0x7FFAF2E41BC0
        public void Translate(){} // RVA: 0x7FFAF8763C40
        public void op_Equality(){} // RVA: 0x7FFAF8763890
    }

    public class SecurityIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8764080 | overloaded x2
        public void CreateFromBinaryForm(){} // RVA: 0x7FFAF87642F0
        public void get_BinaryLength(){} // RVA: 0x7FFAF39EF910
        public void get_Value(){} // RVA: 0x7FFAF8764480
        public void GetSidAuthority(){} // RVA: 0x7FFAF87647B0
        public void GetSidSubAuthorityCount(){} // RVA: 0x7FFAF8764860
        public void GetSidSubAuthority(){} // RVA: 0x7FFAF8764890
        public void CompareTo(){} // RVA: 0x7FFAF8764910
        public void Equals(){} // RVA: 0x7FFAF8764BE0 | overloaded x2
        public void GetBinaryForm(){} // RVA: 0x7FFAF8764CB0
        public void GetHashCode(){} // RVA: 0x7FFAF8763C00
        public void ToString(){} // RVA: 0x7FFAF2E41BC0
        public void Translate(){} // RVA: 0x7FFAF8764DA0
        public void op_Equality(){} // RVA: 0x7FFAF8763890
        public void op_Inequality(){} // RVA: 0x7FFAF8763950
        public void ParseSddlForm(){} // RVA: 0x7FFAF8765190
        public void TryParseAuthority(){} // RVA: 0x7FFAF87659B0
        public void TryParseSubAuthority(){} // RVA: 0x7FFAF8765AC0
        public void .cctor(){} // RVA: 0x7FFAF8765BD0
    }

    public class WellKnownAccount
    {
        // ── Methods ──
        public void set_WellKnownValue(){} // RVA: 0x7FFAF2D900C0
        public void get_IsAbsolute(){} // RVA: 0x7FFAF2EDCBD0
        public void set_IsAbsolute(){} // RVA: 0x7FFAF2EDCBE0
        public void get_Sid(){} // RVA: 0x7FFAF2D907C0
        public void set_Sid(){} // RVA: 0x7FFAF2DF3E80
        public void set_Rid(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Name(){} // RVA: 0x7FFAF2DBB130
        public void set_Name(){} // RVA: 0x7FFAF2D8EE90
        public void get_SddlForm(){} // RVA: 0x7FFAF30E74D0
        public void set_SddlForm(){} // RVA: 0x7FFAF2DBB890
        public void LookupBySid(){} // RVA: 0x7FFAF8765C30
        public void LookupByName(){} // RVA: 0x7FFAF8765D30
        public void LookupBySddlForm(){} // RVA: 0x7FFAF8765E30
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8765F30
    }

    public class WindowsIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8769340 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFAF8769380
        public void GetCurrent(){} // RVA: 0x7FFAF8769390
        public void Impersonate(){} // RVA: 0x7FFAF87694F0
        public void get_AuthenticationType(){} // RVA: 0x7FFAF2F12D00
        public void get_Name(){} // RVA: 0x7FFAF8769540
        public void get_Owner(){} // RVA: 0x7FFAF87695F0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAF8769630
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF8769B00
        public void CloneAsBase(){} // RVA: 0x7FFAF876A380
        public void GetTokenInternal(){} // RVA: 0x7FFAF2F77C50
        public void SetToken(){} // RVA: 0x7FFAF876A390
        public void GetCurrentToken(){} // RVA: 0x7FFAF2FC9240
        public void GetTokenName(){} // RVA: 0x7FFAF876A4E0
        public void .cctor(){} // RVA: 0x7FFAF876A4F0
    }

    public class WindowsImpersonationContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF876A530
        public void Dispose(){} // RVA: 0x7FFAF876A540
        public void Undo(){} // RVA: 0x7FFAF876A560
        public void CloseToken(){} // RVA: 0x7FFAF876A590
        public void DuplicateToken(){} // RVA: 0x7FFAF876A5A0
        public void SetCurrentToken(){} // RVA: 0x7FFAF876A5B0
        public void RevertToSelf(){} // RVA: 0x7FFAF876A5C0
    }

}