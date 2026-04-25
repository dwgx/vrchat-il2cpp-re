// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Claims
// Classes: 3
// Methods: 46

namespace ThirdParty.DotNet.System.Security.Claims
{
    public class Claim : Object
    {
        public string Properties; // 0x10
        public string Subject; // 0x18
        public string Type; // 0x20
        public string Value; // 0x28
        public string m_valueType; // 0x30
        public byte[] m_userSerializationData; // 0x38
        public System.Collections.Generic.Dictionary`2<string,string> m_properties; // 0x40
        public object m_propertyLock; // 0x48
        public System.Security.Claims.ClaimsIdentity m_subject; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8451F50 | overloaded x3
        public void OnDeserializedMethod(){} // RVA: 0x7FFAC8452620
        public void get_Properties(){} // RVA: 0x7FFAC84526B0
        public void get_Subject(){} // RVA: 0x7FFAC2FC20E0
        public void set_Subject(){} // RVA: 0x7FFAC30794D0
        public void get_Type(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Value(){} // RVA: 0x7FFAC2F4F130
        public void Clone(){} // RVA: 0x7FFAC84528A0
        public void ToString(){} // RVA: 0x7FFAC8452910
    }

    public class ClaimsIdentity : Object
    {
        public byte[] AuthenticationType; // 0x10
        public System.Collections.Generic.List`1<System.Security.Claims.Claim> Actor; // 0x18
        public System.Collections.ObjectModel.Collection`1<System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim>> Claims; // 0x20
        public string Name; // 0x28
        public string NameClaimType; // 0x30
        public string m_version; // 0x38
        public System.Security.Claims.ClaimsIdentity m_actor; // 0x40
        public string m_authenticationType; // 0x48
        public object m_bootstrapContext; // 0x50
        public string m_label; // 0x58
        public string m_serializedNameType; // 0x60
        public string m_serializedRoleType; // 0x68
        public string m_serializedClaims; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8453B00 | overloaded x6
        public void get_AuthenticationType(){} // RVA: 0x7FFAC2F9C730
        public void get_Actor(){} // RVA: 0x7FFAC2F9E740
        public void set_Actor(){} // RVA: 0x7FFAC8453E30
        public void get_Claims(){} // RVA: 0x7FFAC844A8B0
        public void get_Name(){} // RVA: 0x7FFAC8453F30
        public void get_NameClaimType(){} // RVA: 0x7FFAC2F4F130
        public void Clone(){} // RVA: 0x7FFAC8453F60
        public void AddClaim(){} // RVA: 0x7FFAC8454280
        public void SafeAddClaims(){} // RVA: 0x7FFAC8454360
        public void SafeAddClaim(){} // RVA: 0x7FFAC84545A0
        public void FindFirst(){} // RVA: 0x7FFAC8454630
        public void OnSerializingMethod(){} // RVA: 0x7FFAC84548B0
        public void OnDeserializedMethod(){} // RVA: 0x7FFAC8454A00
        public void OnDeserializingMethod(){} // RVA: 0x7FFAC8454BC0
        public void GetObjectData(){} // RVA: 0x7FFAC8454D50
        public void DeserializeClaims(){} // RVA: 0x7FFAC8455210
        public void SerializeClaims(){} // RVA: 0x7FFAC8455630
        public void IsCircular(){} // RVA: 0x7FFAC84557F0
        public void Deserialize(){} // RVA: 0x7FFAC8455840
    }

    public class ClaimsPrincipal : Object
    {
        public string ClaimsPrincipalSelector; // 0x10
        public string m_serializedClaimsIdentities; // 0x18
        public System.Collections.Generic.List`1<System.Security.Claims.ClaimsIdentity> m_identities; // 0x20
        public System.Func`2<System.Collections.Generic.IEnumerable`1<System.Security.Claims.ClaimsIdentity>,System.Security.Claims.ClaimsIdentity> s_identitySelector;
        public System.Func`1<System.Security.Claims.ClaimsPrincipal> s_principalSelector; // 0x8

        // ── Methods ──
        public void SelectPrimaryIdentity(){} // RVA: 0x7FFAC84568A0
        public void get_ClaimsPrincipalSelector(){} // RVA: 0x7FFAC8456B20
        public void .ctor(){} // RVA: 0x7FFAC8456CC0 | overloaded x2
        public void OnSerializingMethod(){} // RVA: 0x7FFAC8456E70
        public void OnDeserializedMethod(){} // RVA: 0x7FFAC8456F10
        public void Deserialize(){} // RVA: 0x7FFAC8456FC0
        public void DeserializeIdentities(){} // RVA: 0x7FFAC84571B0
        public void SerializeIdentities(){} // RVA: 0x7FFAC8457820
        public void .cctor(){} // RVA: 0x7FFAC8458050
    }

}