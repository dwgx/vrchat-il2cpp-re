// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Claims
// Classes: 3
// Methods: 38

namespace ThirdParty.DotNet.System.Security.Claims
{
    public class Claim : Object
    {
        public object m_issuer;
        public object m_originalIssuer;
        public object m_type;
        public object m_value;
        public object m_valueType;
        public object m_userSerializationData;
        public object m_properties;
        public object m_propertyLock;
        public object m_subject;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6733300
        public void OnDeserializedMethod(){} // RVA: 0x67339E0
        public void get_Properties(){} // RVA: 0x6733A70
        public void get_Subject(){} // RVA: 0xBE58B0
        public void set_Subject(){} // RVA: 0xCA4DF0
        public void get_Type(){} // RVA: 0xB700F0
        public void get_Value(){} // RVA: 0xB70160
        public void Clone(){} // RVA: 0x6733C30
        public void ToString(){} // RVA: 0x6733CA0
    }

    public class ClaimsIdentity : Object
    {
        public object m_userSerializationData;
        public object m_instanceClaims;
        public object m_externalClaims;
        public object m_nameType;
        public object m_roleType;
        public object m_version;
        public object m_actor;
        public object m_authenticationType;
        public object m_bootstrapContext;
        public object m_label;
        public object m_serializedNameType;
        public object m_serializedRoleType;
        public object m_serializedClaims;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6734E90
        public void get_AuthenticationType(){} // RVA: 0xBBF8F0
        public void get_Actor(){} // RVA: 0xBC1B30
        public void set_Actor(){} // RVA: 0x67351D0
        public void get_Claims(){} // RVA: 0x672BC40
        public void get_Name(){} // RVA: 0x67352D0
        public void get_NameClaimType(){} // RVA: 0xB70160
        public void Clone(){} // RVA: 0x6735300
        public void AddClaim(){} // RVA: 0x6735620
        public void SafeAddClaims(){} // RVA: 0x6735700
        public void SafeAddClaim(){} // RVA: 0x6735950
        public void FindFirst(){} // RVA: 0x67359E0
        public void OnSerializingMethod(){} // RVA: 0x6735C60
        public void OnDeserializedMethod(){} // RVA: 0x6735DB0
        public void OnDeserializingMethod(){} // RVA: 0x6735F70
        public void GetObjectData(){} // RVA: 0x6736100
        public void DeserializeClaims(){} // RVA: 0x67371C0
        public void SerializeClaims(){} // RVA: 0x67375E0
        public void IsCircular(){} // RVA: 0x67377A0
        public void Deserialize(){} // RVA: 0x67377F0
    }

    public class ClaimsPrincipal : Object
    {
        public object m_version;
        public object m_serializedClaimsIdentities;
        public object m_identities;
        public object s_identitySelector;
        public object s_principalSelector;

        // ── Methods ──
        public void SelectPrimaryIdentity(){} // RVA: 0x6738860
        public void get_ClaimsPrincipalSelector(){} // RVA: 0x6738AF0
        public void .ctor(){} // RVA: 0x6738C90
        public void OnSerializingMethod(){} // RVA: 0x6738E50
        public void OnDeserializedMethod(){} // RVA: 0x6738EF0
        public void Deserialize(){} // RVA: 0x6738FA0
        public void DeserializeIdentities(){} // RVA: 0x67391E0
        public void SerializeIdentities(){} // RVA: 0x6739860
        public void .cctor(){} // RVA: 0x673A060
    }

}