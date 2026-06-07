// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security
// Classes: 11
// Methods: 91

namespace ThirdParty.DotNet.System.Security
{
    public class CodeAccessPermission
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Demand(){} // RVA: 0x5C637A0
        public void Equals(){} // RVA: 0x5C637D0
        public void GetHashCode(){} // RVA: 0x5C63910
        public void IsSubsetOf(){} // RVA: 0xDE40
        public void ToString(){} // RVA: 0x5C63920
        public void ToXml(){} // RVA: 0xCD60
        public void Element(){} // RVA: 0x5C63960
        public void CheckPermissionState(){} // RVA: 0x5C63AF0
        public void ThrowInvalidPermission(){} // RVA: 0x5C63BB0
        public void System.Security.IPermission.Demand(){} // RVA: 0x2DD310
    }

    public class IPermission
    {
        // ── Methods ──
        public void Demand(){} // RVA: 0x24A50
        public void IsSubsetOf(){} // RVA: 0xDE40
    }

    public class ISecurityEncodable
    {
        // ── Methods ──
        public void ToXml(){} // RVA: 0xCD60
    }

    public class NamedPermissionSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C63E30 | overloaded x3
        public void get_Name(){} // RVA: 0x6374D0
        public void set_Name(){} // RVA: 0x5C63FB0
        public void ToXml(){} // RVA: 0x5C640E0
        public void Equals(){} // RVA: 0x5C64190
        public void GetHashCode(){} // RVA: 0x5C64240
    }

    public class PermissionSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C64390 | overloaded x3
        public void CopyTo(){} // RVA: 0x5C643E0
        public void Demand(){} // RVA: 0x5C64570
        public void CasOnlyDemand(){} // RVA: 0x5C64800
        public void GetEnumerator(){} // RVA: 0x5C648B0
        public void IsEmpty(){} // RVA: 0x5C648E0
        public void IsUnrestricted(){} // RVA: 0x3FC00F0
        public void ToString(){} // RVA: 0x5C64B00
        public void ToXml(){} // RVA: 0x5C64B40
        public void get_Count(){} // RVA: 0x5C64F90
        public void get_IsSynchronized(){} // RVA: 0x5040B10
        public void get_SyncRoot(){} // RVA: 0x1A3F520
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x2DD310
        public void Equals(){} // RVA: 0x5C64FC0
        public void GetHashCode(){} // RVA: 0x5C65190
        public void .cctor(){} // RVA: 0x5C651E0
    }

    public class SecureString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C65520 | overloaded x2
        public void get_Length(){} // RVA: 0x5C65690
        public void Dispose(){} // RVA: 0x5C65700
        public void Encrypt(){} // RVA: 0x1020CE0
        public void Decrypt(){} // RVA: 0x1020CE0
        public void Alloc(){} // RVA: 0x5C657A0
        public void GetBuffer(){} // RVA: 0x5C65960
    }

    public class SecurityDocument
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C62AD0
        public void GuaranteeSize(){} // RVA: 0x5C62B70
        public void AddString(){} // RVA: 0x5C62C70
        public void AppendString(){} // RVA: 0x5C62DB0
        public void EncodedStringSize(){} // RVA: 0x5C62E50
        public void GetString(){} // RVA: 0x5C62E70
        public void AddToken(){} // RVA: 0x5C63320
        public void GetRootElement(){} // RVA: 0x5C63380
        public void GetElement(){} // RVA: 0x5C633B0
        public void InternalGetElement(){} // RVA: 0x5C633D0
    }

    public class SecurityElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C65A20 | overloaded x2
        public void get_Children(){} // RVA: 0x30B130
        public void get_Tag(){} // RVA: 0x2E07C0
        public void set_Text(){} // RVA: 0x5C65C10
        public void AddAttribute(){} // RVA: 0x5C65DB0
        public void AddChild(){} // RVA: 0x5C65FB0
        public void Escape(){} // RVA: 0x5C660E0
        public void Unescape(){} // RVA: 0x5C66360
        public void IsValidAttributeName(){} // RVA: 0x5C66580
        public void IsValidAttributeValue(){} // RVA: 0x5C66610
        public void IsValidTag(){} // RVA: 0x5C666A0
        public void IsValidText(){} // RVA: 0x5C66730
        public void SearchForChildByTag(){} // RVA: 0x5C667C0
        public void SearchForTextOfTag(){} // RVA: 0x5C66950
        public void ToString(){} // RVA: 0x5C66B00
        public void ToXml(){} // RVA: 0x5C66B90
        public void GetAttribute(){} // RVA: 0x5C671D0
        public void set_m_strText(){} // RVA: 0x2DEE30
        public void SearchForTextOfLocalName(){} // RVA: 0x5C673E0
        public void .cctor(){} // RVA: 0x5C676B0
    }

    public class SecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C67FE0 | overloaded x4
        public void GetObjectData(){} // RVA: 0x5C68000
        public void ToString(){} // RVA: 0x5C68270
    }

    public class SecurityManager
    {
        // ── Methods ──
        public void get_SecurityEnabled(){} // RVA: 0x2DD320
        public void EnsureElevatedPermissions(){} // RVA: 0x2DD310
    }

    public class XmlSyntaxException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x4
    }

}