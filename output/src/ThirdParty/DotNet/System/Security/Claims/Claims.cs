// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Claims
// Classes: 3
// Methods: 46

namespace ThirdParty.DotNet.System.Security.Claims
{
    public class Claim
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF876A960 | overloaded x3
        public void OnDeserializedMethod(){} // RVA: 0x7FFAF876B030
        public void get_Properties(){} // RVA: 0x7FFAF876B0C0
        public void get_Subject(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Subject(){} // RVA: 0x7FFAF2EE54D0
        public void get_Type(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Value(){} // RVA: 0x7FFAF2DBB130
        public void Clone(){} // RVA: 0x7FFAF876B2B0
        public void ToString(){} // RVA: 0x7FFAF876B320
    }

    public class ClaimsIdentity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF876C510 | overloaded x6
        public void get_AuthenticationType(){} // RVA: 0x7FFAF2E08730
        public void get_Actor(){} // RVA: 0x7FFAF2E0A740
        public void set_Actor(){} // RVA: 0x7FFAF876C840
        public void get_Claims(){} // RVA: 0x7FFAF87632C0
        public void get_Name(){} // RVA: 0x7FFAF876C940
        public void get_NameClaimType(){} // RVA: 0x7FFAF2DBB130
        public void Clone(){} // RVA: 0x7FFAF876C970
        public void AddClaim(){} // RVA: 0x7FFAF876CC90
        public void SafeAddClaims(){} // RVA: 0x7FFAF876CD70
        public void SafeAddClaim(){} // RVA: 0x7FFAF876CFB0
        public void FindFirst(){} // RVA: 0x7FFAF876D040
        public void OnSerializingMethod(){} // RVA: 0x7FFAF876D2C0
        public void OnDeserializedMethod(){} // RVA: 0x7FFAF876D410
        public void OnDeserializingMethod(){} // RVA: 0x7FFAF876D5D0
        public void GetObjectData(){} // RVA: 0x7FFAF876D760
        public void DeserializeClaims(){} // RVA: 0x7FFAF876DC20
        public void SerializeClaims(){} // RVA: 0x7FFAF876E040
        public void IsCircular(){} // RVA: 0x7FFAF876E200
        public void Deserialize(){} // RVA: 0x7FFAF876E250
    }

    public class ClaimsPrincipal
    {
        // ── Methods ──
        public void SelectPrimaryIdentity(){} // RVA: 0x7FFAF876F2B0
        public void get_ClaimsPrincipalSelector(){} // RVA: 0x7FFAF876F530
        public void .ctor(){} // RVA: 0x7FFAF876F6D0 | overloaded x2
        public void OnSerializingMethod(){} // RVA: 0x7FFAF876F880
        public void OnDeserializedMethod(){} // RVA: 0x7FFAF876F920
        public void Deserialize(){} // RVA: 0x7FFAF876F9D0
        public void DeserializeIdentities(){} // RVA: 0x7FFAF876FBC0
        public void SerializeIdentities(){} // RVA: 0x7FFAF8770230
        public void .cctor(){} // RVA: 0x7FFAF8770A60
    }

}