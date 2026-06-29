// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Principal
// Classes: 10
// Methods: 82

namespace ThirdParty.DotNet.System.Security.Principal
{
    public class GenericIdentity : ClaimsIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAA1120
        public void Clone(){} // RVA: 0x7ADAA1210
        public void get_Claims(){} // RVA: 0x7ADAA1330
        public void get_Name(){} // RVA: 0x7A82C2060
        public void get_AuthenticationType(){} // RVA: 0x7A825E100
        public void AddNameClaim(){} // RVA: 0x7ADAA13E0
    }

    public class GenericPrincipal : ClaimsPrincipal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAA1560
    }

    public class IIdentity
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A7E00680
        public void get_AuthenticationType(){} // RVA: 0x7A7E00680
    }

    public class IdentityNotMappedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F78E0
        public void GetObjectData(){} // RVA: 0x7A80D7310
    }

    public class IdentityReference : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Value(){} // RVA: 0x7A7E00680
        public void Equals(){} // RVA: 0x7A7E019D0
        public void GetHashCode(){} // RVA: 0x7A7E00710
        public void ToString(){} // RVA: 0x7A7E00680
        public void Translate(){} // RVA: 0x7A7E00B20
        public void op_Equality(){} // RVA: 0x7ADAA1910
        public void op_Inequality(){} // RVA: 0x7ADAA19D0
    }

    public class NTAccount : IdentityReference
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAA1A90
        public void get_Value(){} // RVA: 0x7A80F2570
        public void Equals(){} // RVA: 0x7ADAA1BB0
        public void GetHashCode(){} // RVA: 0x7ADAA1C80
        public void ToString(){} // RVA: 0x7A818C700
        public void Translate(){} // RVA: 0x7ADAA1CC0
        public void op_Equality(){} // RVA: 0x7ADAA1910
    }

    public class SecurityIdentifier : IdentityReference
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAA2100
        public void CreateFromBinaryForm(){} // RVA: 0x7ADAA2370
        public void get_BinaryLength(){} // RVA: 0x7A8D0A110
        public void get_Value(){} // RVA: 0x7ADAA2500
        public void GetSidAuthority(){} // RVA: 0x7ADAA2860
        public void GetSidSubAuthorityCount(){} // RVA: 0x7ADAA2910
        public void GetSidSubAuthority(){} // RVA: 0x7ADAA2940
        public void CompareTo(){} // RVA: 0x7ADAA29D0
        public void Equals(){} // RVA: 0x7ADAA2CA0
        public void GetBinaryForm(){} // RVA: 0x7ADAA2D70
        public void GetHashCode(){} // RVA: 0x7ADAA1C80
        public void ToString(){} // RVA: 0x7A818C700
        public void Translate(){} // RVA: 0x7ADAA2E60
        public void op_Equality(){} // RVA: 0x7ADAA1910
        public void op_Inequality(){} // RVA: 0x7ADAA19D0
        public void ParseSddlForm(){} // RVA: 0x7ADAA3250
        public void TryParseAuthority(){} // RVA: 0x7ADAA3A90
        public void TryParseSubAuthority(){} // RVA: 0x7ADAA3BA0
        public void .cctor(){} // RVA: 0x7ADAA3CB0
    }

    public class WellKnownAccount : Object
    {
        // ── Methods ──
        public void set_WellKnownValue(){} // RVA: 0x7A80DA0C0
        public void get_IsAbsolute(){} // RVA: 0x7A8227C00
        public void set_IsAbsolute(){} // RVA: 0x7A8227C10
        public void get_Sid(){} // RVA: 0x7A80DA7B0
        public void set_Sid(){} // RVA: 0x7A813E420
        public void set_Rid(){} // RVA: 0x7A81052D0
        public void get_Name(){} // RVA: 0x7A8105330
        public void set_Name(){} // RVA: 0x7A80D8E80
        public void get_SddlForm(){} // RVA: 0x7A83F69F0
        public void set_SddlForm(){} // RVA: 0x7A8105A90
        public void LookupBySid(){} // RVA: 0x7ADAA3D10
        public void LookupByName(){} // RVA: 0x7ADAA3E10
        public void LookupBySddlForm(){} // RVA: 0x7ADAA3F10
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7ADAA4010
    }

    public class WindowsIdentity : ClaimsIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAA7440
        public void Dispose(){} // RVA: 0x7ADAA7480
        public void GetCurrent(){} // RVA: 0x7ADAA7490
        public void Impersonate(){} // RVA: 0x7ADAA75F0
        public void get_AuthenticationType(){} // RVA: 0x7A825E100
        public void get_Name(){} // RVA: 0x7ADAA7640
        public void get_Owner(){} // RVA: 0x7ADAA76F0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7ADAA7730
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7ADAA7C00
        public void CloneAsBase(){} // RVA: 0x7ADAA8480
        public void GetTokenInternal(){} // RVA: 0x7A82C2060
        public void SetToken(){} // RVA: 0x7ADAA8490
        public void GetCurrentToken(){} // RVA: 0x7A82D1450
        public void GetTokenName(){} // RVA: 0x7ADAA85E0
        public void .cctor(){} // RVA: 0x7ADAA85F0
    }

    public class WindowsImpersonationContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAA8630
        public void Dispose(){} // RVA: 0x7ADAA8640
        public void Undo(){} // RVA: 0x7ADAA8660
        public void CloseToken(){} // RVA: 0x7ADAA8690
        public void DuplicateToken(){} // RVA: 0x7ADAA86A0
        public void SetCurrentToken(){} // RVA: 0x7ADAA86B0
        public void RevertToSelf(){} // RVA: 0x7ADAA86C0
    }

}