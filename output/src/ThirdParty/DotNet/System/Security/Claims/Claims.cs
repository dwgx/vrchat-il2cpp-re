// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Claims
// Classes: 3
// Methods: 46

namespace ThirdParty.DotNet.System.Security.Claims
{
    public class Claim : Object
    {
        public string m_issuer; // 0x10
        public string m_originalIssuer; // 0x18
        public string m_type; // 0x20
        public string m_value; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867FB860 | overloaded x3
        public void OnDeserializedMethod(){} // RVA: 0x7FFE867FBF30
        public void get_Properties(){} // RVA: 0x7FFE867FBFC0
        public void get_Subject(){} // RVA: 0x7FFE8119C0E0
        public void set_Subject(){} // RVA: 0x7FFE812534D0
        public void get_Type(){} // RVA: 0x7FFE811290C0
        public void get_Value(){} // RVA: 0x7FFE81129130
        public void Clone(){} // RVA: 0x7FFE867FC1B0
        public void ToString(){} // RVA: 0x7FFE867FC220
    }

    public class ClaimsIdentity : Object
    {
        public byte[] m_userSerializationData; // 0x10
        public System.Collections.Generic.List`1<System.Security.Claims.Claim> m_instanceClaims; // 0x18
        public System.Collections.ObjectModel.Collection`1<System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim>> m_externalClaims; // 0x20
        public string m_nameType; // 0x28
        public string m_roleType; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867FD410 | overloaded x6
        public void get_AuthenticationType(){} // RVA: 0x7FFE81176730
        public void get_Actor(){} // RVA: 0x7FFE81178740
        public void set_Actor(){} // RVA: 0x7FFE867FD740
        public void get_Claims(){} // RVA: 0x7FFE867F41C0
        public void get_Name(){} // RVA: 0x7FFE867FD840
        public void get_NameClaimType(){} // RVA: 0x7FFE81129130
        public void Clone(){} // RVA: 0x7FFE867FD870
        public void AddClaim(){} // RVA: 0x7FFE867FDB90
        public void SafeAddClaims(){} // RVA: 0x7FFE867FDC70
        public void SafeAddClaim(){} // RVA: 0x7FFE867FDEB0
        public void FindFirst(){} // RVA: 0x7FFE867FDF40
        public void OnSerializingMethod(){} // RVA: 0x7FFE867FE1C0
        public void OnDeserializedMethod(){} // RVA: 0x7FFE867FE310
        public void OnDeserializingMethod(){} // RVA: 0x7FFE867FE4D0
        public void GetObjectData(){} // RVA: 0x7FFE867FE660
        public void DeserializeClaims(){} // RVA: 0x7FFE867FEB20
        public void SerializeClaims(){} // RVA: 0x7FFE867FEF40
        public void IsCircular(){} // RVA: 0x7FFE867FF100
        public void Deserialize(){} // RVA: 0x7FFE867FF150
    }

    public class ClaimsPrincipal : Object
    {
        public string m_version; // 0x10

        // ── Methods ──
        public void SelectPrimaryIdentity(){} // RVA: 0x7FFE868001B0
        public void get_ClaimsPrincipalSelector(){} // RVA: 0x7FFE86800430
        public void .ctor(){} // RVA: 0x7FFE868005D0 | overloaded x2
        public void OnSerializingMethod(){} // RVA: 0x7FFE86800780
        public void OnDeserializedMethod(){} // RVA: 0x7FFE86800820
        public void Deserialize(){} // RVA: 0x7FFE868008D0
        public void DeserializeIdentities(){} // RVA: 0x7FFE86800AC0
        public void SerializeIdentities(){} // RVA: 0x7FFE86801130
        public void .cctor(){} // RVA: 0x7FFE86801960
    }

}