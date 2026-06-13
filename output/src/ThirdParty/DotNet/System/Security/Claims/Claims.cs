// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Claims
// Classes: 3
// Methods: 46

namespace ThirdParty.DotNet.System.Security.Claims
{
    public class Claim
    {
        public string m_issuer; // 0x10
        public string m_originalIssuer; // 0x18
        public string m_type; // 0x20
        public string m_value; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CBA960 | overloaded x3
        public void OnDeserializedMethod(){} // RVA: 0x5CBB030
        public void get_Properties(){} // RVA: 0x5CBB0C0
        public void get_Subject(){} // RVA: 0x37E0E0
        public void set_Subject(){} // RVA: 0x4354D0
        public void get_Type(){} // RVA: 0x30B0C0
        public void get_Value(){} // RVA: 0x30B130
        public void Clone(){} // RVA: 0x5CBB2B0
        public void ToString(){} // RVA: 0x5CBB320
    }

    public class ClaimsIdentity
    {
        public byte[] m_userSerializationData; // 0x10
        public System.Collections.Generic.List`1<System.Security.Claims.Claim> m_instanceClaims; // 0x18
        public System.Collections.ObjectModel.Collection`1<System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim>> m_externalClaims; // 0x20
        public string m_nameType; // 0x28
        public string m_roleType; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CBC510 | overloaded x6
        public void get_AuthenticationType(){} // RVA: 0x358730
        public void get_Actor(){} // RVA: 0x35A740
        public void set_Actor(){} // RVA: 0x5CBC840
        public void get_Claims(){} // RVA: 0x5CB32C0
        public void get_Name(){} // RVA: 0x5CBC940
        public void get_NameClaimType(){} // RVA: 0x30B130
        public void Clone(){} // RVA: 0x5CBC970
        public void AddClaim(){} // RVA: 0x5CBCC90
        public void SafeAddClaims(){} // RVA: 0x5CBCD70
        public void SafeAddClaim(){} // RVA: 0x5CBCFB0
        public void FindFirst(){} // RVA: 0x5CBD040
        public void OnSerializingMethod(){} // RVA: 0x5CBD2C0
        public void OnDeserializedMethod(){} // RVA: 0x5CBD410
        public void OnDeserializingMethod(){} // RVA: 0x5CBD5D0
        public void GetObjectData(){} // RVA: 0x5CBD760
        public void DeserializeClaims(){} // RVA: 0x5CBDC20
        public void SerializeClaims(){} // RVA: 0x5CBE040
        public void IsCircular(){} // RVA: 0x5CBE200
        public void Deserialize(){} // RVA: 0x5CBE250
    }

    public class ClaimsPrincipal
    {
        public string m_version; // 0x10

        // ── Methods ──
        public void SelectPrimaryIdentity(){} // RVA: 0x5CBF2B0
        public void get_ClaimsPrincipalSelector(){} // RVA: 0x5CBF530
        public void .ctor(){} // RVA: 0x5CBF6D0 | overloaded x2
        public void OnSerializingMethod(){} // RVA: 0x5CBF880
        public void OnDeserializedMethod(){} // RVA: 0x5CBF920
        public void Deserialize(){} // RVA: 0x5CBF9D0
        public void DeserializeIdentities(){} // RVA: 0x5CBFBC0
        public void SerializeIdentities(){} // RVA: 0x5CC0230
        public void .cctor(){} // RVA: 0x5CC0A60
    }

}