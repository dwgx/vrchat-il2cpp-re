// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Claims
// Classes: 3
// Methods: 38

namespace ThirdParty.DotNet.System.Security.Claims
{
    public class Claim : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAA8A60
        public void OnDeserializedMethod(){} // RVA: 0x7ADAA9140
        public void get_Properties(){} // RVA: 0x7ADAA91D0
        public void get_Subject(){} // RVA: 0x7A8178B90
        public void set_Subject(){} // RVA: 0x7A8230620
        public void get_Type(){} // RVA: 0x7A81052C0
        public void get_Value(){} // RVA: 0x7A8105330
        public void Clone(){} // RVA: 0x7ADAA9390
        public void ToString(){} // RVA: 0x7ADAA9400
    }

    public class ClaimsIdentity : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADAAA5F0
        public void get_AuthenticationType(){} // RVA: 0x7A8152D80
        public void get_Actor(){} // RVA: 0x7A8154D80
        public void set_Actor(){} // RVA: 0x7ADAAA930
        public void get_Claims(){} // RVA: 0x7ADAA1330
        public void get_Name(){} // RVA: 0x7ADAAAA30
        public void get_NameClaimType(){} // RVA: 0x7A8105330
        public void Clone(){} // RVA: 0x7ADAAAA60
        public void AddClaim(){} // RVA: 0x7ADAAAD80
        public void SafeAddClaims(){} // RVA: 0x7ADAAAE60
        public void SafeAddClaim(){} // RVA: 0x7ADAAB0B0
        public void FindFirst(){} // RVA: 0x7ADAAB140
        public void OnSerializingMethod(){} // RVA: 0x7ADAAB3C0
        public void OnDeserializedMethod(){} // RVA: 0x7ADAAB510
        public void OnDeserializingMethod(){} // RVA: 0x7ADAAB6D0
        public void GetObjectData(){} // RVA: 0x7ADAAB860
        public void DeserializeClaims(){} // RVA: 0x7ADAABD30
        public void SerializeClaims(){} // RVA: 0x7ADAAC150
        public void IsCircular(){} // RVA: 0x7ADAAC310
        public void Deserialize(){} // RVA: 0x7ADAAC360
    }

    public class ClaimsPrincipal : Object
    {
        // ── Methods ──
        public void SelectPrimaryIdentity(){} // RVA: 0x7ADAAD3D0
        public void get_ClaimsPrincipalSelector(){} // RVA: 0x7ADAAD660
        public void .ctor(){} // RVA: 0x7ADAAD800
        public void OnSerializingMethod(){} // RVA: 0x7ADAAD9C0
        public void OnDeserializedMethod(){} // RVA: 0x7ADAADA60
        public void Deserialize(){} // RVA: 0x7ADAADB10
        public void DeserializeIdentities(){} // RVA: 0x7ADAADD50
        public void SerializeIdentities(){} // RVA: 0x7ADAAE3D0
        public void .cctor(){} // RVA: 0x7ADAAEC00
    }

}