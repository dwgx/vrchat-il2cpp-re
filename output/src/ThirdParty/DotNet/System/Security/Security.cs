// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security
// Classes: 11
// Methods: 79

namespace ThirdParty.DotNet.System.Security
{
    public class CodeAccessPermission : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Demand(){} // RVA: 0x7ADA51720
        public void Equals(){} // RVA: 0x7ADA51750
        public void GetHashCode(){} // RVA: 0x7ADA51890
        public void IsSubsetOf(){} // RVA: 0x7A7E019D0
        public void ToString(){} // RVA: 0x7ADA518A0
        public void ToXml(){} // RVA: 0x7A7E00680
        public void Element(){} // RVA: 0x7ADA518E0
        public void CheckPermissionState(){} // RVA: 0x7ADA51A70
        public void ThrowInvalidPermission(){} // RVA: 0x7ADA51B30
        public void System.Security.IPermission.Demand(){} // RVA: 0x7A80D7310
    }

    public class IPermission
    {
        // ── Methods ──
        public void Demand(){} // RVA: 0x7A7E18770
        public void IsSubsetOf(){} // RVA: 0x7A7E019D0
    }

    public class ISecurityEncodable
    {
        // ── Methods ──
        public void ToXml(){} // RVA: 0x7A7E00680
    }

    public class NamedPermissionSet : PermissionSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA51DB0
        public void get_Name(){} // RVA: 0x7A83F69F0
        public void set_Name(){} // RVA: 0x7ADA51F30
        public void ToXml(){} // RVA: 0x7ADA52060
        public void Equals(){} // RVA: 0x7ADA52110
        public void GetHashCode(){} // RVA: 0x7ADA521C0
    }

    public class PermissionSet : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA52310
        public void CopyTo(){} // RVA: 0x7ADA52360
        public void Demand(){} // RVA: 0x7ADA524F0
        public void CasOnlyDemand(){} // RVA: 0x7ADA527A0
        public void GetEnumerator(){} // RVA: 0x7ADA52850
        public void IsEmpty(){} // RVA: 0x7ADA52880
        public void IsUnrestricted(){} // RVA: 0x7ABDB40E0
        public void ToString(){} // RVA: 0x7ADA52A90
        public void ToXml(){} // RVA: 0x7ADA52AD0
        public void get_Count(){} // RVA: 0x7ADA52F20
        public void get_IsSynchronized(){} // RVA: 0x7ADA52F50
        public void get_SyncRoot(){} // RVA: 0x7A97F8BA0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7A80D7310
        public void Equals(){} // RVA: 0x7ADA52F80
        public void GetHashCode(){} // RVA: 0x7ADA53150
        public void .cctor(){} // RVA: 0x7ADA531A0
    }

    public class SecureString : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA534E0
        public void get_Length(){} // RVA: 0x7ADA53650
        public void Dispose(){} // RVA: 0x7ADA536C0
        public void Encrypt(){} // RVA: 0x7A8DD7270
        public void Decrypt(){} // RVA: 0x7A8DD7270
        public void Alloc(){} // RVA: 0x7ADA53760
        public void GetBuffer(){} // RVA: 0x7ADA53920
    }

    public class SecurityDocument : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA50A30
        public void GuaranteeSize(){} // RVA: 0x7ADA50AD0
        public void AddString(){} // RVA: 0x7ADA50BD0
        public void AppendString(){} // RVA: 0x7ADA50D10
        public void EncodedStringSize(){} // RVA: 0x7ADA50DB0
        public void GetString(){} // RVA: 0x7ADA50DD0
        public void AddToken(){} // RVA: 0x7ADA51290
        public void GetRootElement(){} // RVA: 0x7ADA512F0
        public void GetElement(){} // RVA: 0x7ADA51320
        public void InternalGetElement(){} // RVA: 0x7ADA51340
    }

    public class SecurityElement : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA539E0
        public void get_Children(){} // RVA: 0x7A8105330
        public void get_Tag(){} // RVA: 0x7A80DA7B0
        public void set_Text(){} // RVA: 0x7ADA53BD0
        public void AddAttribute(){} // RVA: 0x7ADA53D70
        public void AddChild(){} // RVA: 0x7ADA53F70
        public void Escape(){} // RVA: 0x7ADA540A0
        public void Unescape(){} // RVA: 0x7ADA54320
        public void IsValidAttributeName(){} // RVA: 0x7ADA54540
        public void IsValidAttributeValue(){} // RVA: 0x7ADA545D0
        public void IsValidTag(){} // RVA: 0x7ADA54660
        public void IsValidText(){} // RVA: 0x7ADA546F0
        public void SearchForChildByTag(){} // RVA: 0x7ADA54780
        public void SearchForTextOfTag(){} // RVA: 0x7ADA54910
        public void ToString(){} // RVA: 0x7ADA54AC0
        public void ToXml(){} // RVA: 0x7ADA54B60
        public void GetAttribute(){} // RVA: 0x7ADA55190
        public void set_m_strText(){} // RVA: 0x7A80D8E20
        public void SearchForTextOfLocalName(){} // RVA: 0x7ADA55390
        public void .cctor(){} // RVA: 0x7ADA55660
    }

    public class SecurityException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA55F90
        public void GetObjectData(){} // RVA: 0x7ADA55FB0
        public void ToString(){} // RVA: 0x7ADA56220
    }

    public class SecurityManager : Object
    {
        // ── Methods ──
        public void get_SecurityEnabled(){} // RVA: 0x7A80D7320
        public void EnsureElevatedPermissions(){} // RVA: 0x7A80D7310
    }

    public class XmlSyntaxException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

}