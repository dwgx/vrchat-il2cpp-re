// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security
// Classes: 11
// Methods: 91

namespace ThirdParty.DotNet.System.Security
{
    public class CodeAccessPermission
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Demand(){} // RVA: 0x7FFAF87137A0
        public void Equals(){} // RVA: 0x7FFAF87137D0
        public void GetHashCode(){} // RVA: 0x7FFAF8713910
        public void IsSubsetOf(){} // RVA: 0x7FFAF2ABDE40
        public void ToString(){} // RVA: 0x7FFAF8713920
        public void ToXml(){} // RVA: 0x7FFAF2ABCD60
        public void Element(){} // RVA: 0x7FFAF8713960
        public void CheckPermissionState(){} // RVA: 0x7FFAF8713AF0
        public void ThrowInvalidPermission(){} // RVA: 0x7FFAF8713BB0
        public void System.Security.IPermission.Demand(){} // RVA: 0x7FFAF2D8D310
    }

    public class IPermission
    {
        // ── Methods ──
        public void Demand(){} // RVA: 0x7FFAF2AD4A50
        public void IsSubsetOf(){} // RVA: 0x7FFAF2ABDE40
    }

    public class ISecurityEncodable
    {
        // ── Methods ──
        public void ToXml(){} // RVA: 0x7FFAF2ABCD60
    }

    public class NamedPermissionSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8713E30 | overloaded x3
        public void get_Name(){} // RVA: 0x7FFAF30E74D0
        public void set_Name(){} // RVA: 0x7FFAF8713FB0
        public void ToXml(){} // RVA: 0x7FFAF87140E0
        public void Equals(){} // RVA: 0x7FFAF8714190
        public void GetHashCode(){} // RVA: 0x7FFAF8714240
    }

    public class PermissionSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8714390 | overloaded x3
        public void CopyTo(){} // RVA: 0x7FFAF87143E0
        public void Demand(){} // RVA: 0x7FFAF8714570
        public void CasOnlyDemand(){} // RVA: 0x7FFAF8714800
        public void GetEnumerator(){} // RVA: 0x7FFAF87148B0
        public void IsEmpty(){} // RVA: 0x7FFAF87148E0
        public void IsUnrestricted(){} // RVA: 0x7FFAF6A700F0
        public void ToString(){} // RVA: 0x7FFAF8714B00
        public void ToXml(){} // RVA: 0x7FFAF8714B40
        public void get_Count(){} // RVA: 0x7FFAF8714F90
        public void get_IsSynchronized(){} // RVA: 0x7FFAF7AF0B10
        public void get_SyncRoot(){} // RVA: 0x7FFAF44EF520
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAF2D8D310
        public void Equals(){} // RVA: 0x7FFAF8714FC0
        public void GetHashCode(){} // RVA: 0x7FFAF8715190
        public void .cctor(){} // RVA: 0x7FFAF87151E0
    }

    public class SecureString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8715520 | overloaded x2
        public void get_Length(){} // RVA: 0x7FFAF8715690
        public void Dispose(){} // RVA: 0x7FFAF8715700
        public void Encrypt(){} // RVA: 0x7FFAF3AD0CE0
        public void Decrypt(){} // RVA: 0x7FFAF3AD0CE0
        public void Alloc(){} // RVA: 0x7FFAF87157A0
        public void GetBuffer(){} // RVA: 0x7FFAF8715960
    }

    public class SecurityDocument
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8712AD0
        public void GuaranteeSize(){} // RVA: 0x7FFAF8712B70
        public void AddString(){} // RVA: 0x7FFAF8712C70
        public void AppendString(){} // RVA: 0x7FFAF8712DB0
        public void EncodedStringSize(){} // RVA: 0x7FFAF8712E50
        public void GetString(){} // RVA: 0x7FFAF8712E70
        public void AddToken(){} // RVA: 0x7FFAF8713320
        public void GetRootElement(){} // RVA: 0x7FFAF8713380
        public void GetElement(){} // RVA: 0x7FFAF87133B0
        public void InternalGetElement(){} // RVA: 0x7FFAF87133D0
    }

    public class SecurityElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8715A20 | overloaded x2
        public void get_Children(){} // RVA: 0x7FFAF2DBB130
        public void get_Tag(){} // RVA: 0x7FFAF2D907C0
        public void set_Text(){} // RVA: 0x7FFAF8715C10
        public void AddAttribute(){} // RVA: 0x7FFAF8715DB0
        public void AddChild(){} // RVA: 0x7FFAF8715FB0
        public void Escape(){} // RVA: 0x7FFAF87160E0
        public void Unescape(){} // RVA: 0x7FFAF8716360
        public void IsValidAttributeName(){} // RVA: 0x7FFAF8716580
        public void IsValidAttributeValue(){} // RVA: 0x7FFAF8716610
        public void IsValidTag(){} // RVA: 0x7FFAF87166A0
        public void IsValidText(){} // RVA: 0x7FFAF8716730
        public void SearchForChildByTag(){} // RVA: 0x7FFAF87167C0
        public void SearchForTextOfTag(){} // RVA: 0x7FFAF8716950
        public void ToString(){} // RVA: 0x7FFAF8716B00
        public void ToXml(){} // RVA: 0x7FFAF8716B90
        public void GetAttribute(){} // RVA: 0x7FFAF87171D0
        public void set_m_strText(){} // RVA: 0x7FFAF2D8EE30
        public void SearchForTextOfLocalName(){} // RVA: 0x7FFAF87173E0
        public void .cctor(){} // RVA: 0x7FFAF87176B0
    }

    public class SecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8717FE0 | overloaded x4
        public void GetObjectData(){} // RVA: 0x7FFAF8718000
        public void ToString(){} // RVA: 0x7FFAF8718270
    }

    public class SecurityManager
    {
        // ── Methods ──
        public void get_SecurityEnabled(){} // RVA: 0x7FFAF2D8D320
        public void EnsureElevatedPermissions(){} // RVA: 0x7FFAF2D8D310
    }

    public class XmlSyntaxException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x4
    }

}