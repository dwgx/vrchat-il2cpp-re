// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security
// Classes: 11
// Methods: 91

namespace ThirdParty.DotNet.System.Security
{
    public class CodeAccessPermission : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Demand(){} // RVA: 0x7FFE867A4640
        public void Equals(){} // RVA: 0x7FFE867A4670
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void IsSubsetOf(){} // RVA: 0x7FFE80E2F3B0
        public void ToString(){} // RVA: 0x7FFE867A47C0
        public void ToXml(){} // RVA: 0x7FFE80E2E2E0
        public void Element(){} // RVA: 0x7FFE867A4800
        public void CheckPermissionState(){} // RVA: 0x7FFE867A4990
        public void ThrowInvalidPermission(){} // RVA: 0x7FFE867A4A50
        public void System.Security.IPermission.Demand(){} // RVA: 0x7FFE810FB310
    }

    public class IPermission
    {
        // ── Methods ──
        public void Demand(){} // RVA: 0x7FFE80E45FE0
        public void IsSubsetOf(){} // RVA: 0x7FFE80E2F3B0
    }

    public class ISecurityEncodable
    {
        // ── Methods ──
        public void ToXml(){} // RVA: 0x7FFE80E2E2E0
    }

    public class NamedPermissionSet : PermissionSet
    {
        public string name; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867A4CD0 | overloaded x3
        public void get_Name(){} // RVA: 0x7FFE8144E200
        public void set_Name(){} // RVA: 0x7FFE867A4E50
        public void ToXml(){} // RVA: 0x7FFE867A4F80
        public void Equals(){} // RVA: 0x7FFE867A5030
        public void GetHashCode(){} // RVA: 0x7FFE867A50E0
    }

    public class PermissionSet : Object
    {
        public object[] psUnrestricted;
        public 0x664C45FC state; // 0x10
        public System.Collections.ArrayList list; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867A5230 | overloaded x3
        public void CopyTo(){} // RVA: 0x7FFE867A5280
        public void Demand(){} // RVA: 0x7FFE867A5410
        public void CasOnlyDemand(){} // RVA: 0x7FFE867A56A0
        public void GetEnumerator(){} // RVA: 0x7FFE867A5750
        public void IsEmpty(){} // RVA: 0x7FFE867A5780
        public void IsUnrestricted(){} // RVA: 0x7FFE84C37D50
        public void ToString(){} // RVA: 0x7FFE867A59A0
        public void ToXml(){} // RVA: 0x7FFE867A59E0
        public void get_Count(){} // RVA: 0x7FFE85B0C750
        public void get_IsSynchronized(){} // RVA: 0x7FFE867A5E30
        public void get_SyncRoot(){} // RVA: 0x7FFE827C4A80
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFE810FB310
        public void Equals(){} // RVA: 0x7FFE867A5E60
        public void GetHashCode(){} // RVA: 0x7FFE867A6030
        public void .cctor(){} // RVA: 0x7FFE867A6080
    }

    public class SecureString : Object
    {
        public int BlockSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867A63C0 | overloaded x2
        public void get_Length(){} // RVA: 0x7FFE867A6530
        public void Dispose(){} // RVA: 0x7FFE867A65A0
        public void Encrypt(){} // RVA: 0x7FFE81D95990
        public void Decrypt(){} // RVA: 0x7FFE81D95990
        public void Alloc(){} // RVA: 0x7FFE867A6640
        public void GetBuffer(){} // RVA: 0x7FFE867A6800
    }

    public class SecurityDocument : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867A3970
        public void GuaranteeSize(){} // RVA: 0x7FFE867A3A10
        public void AddString(){} // RVA: 0x7FFE867A3B10
        public void AppendString(){} // RVA: 0x7FFE867A3C50
        public void EncodedStringSize(){} // RVA: 0x7FFE867A3CF0
        public void GetString(){} // RVA: 0x7FFE867A3D10
        public void AddToken(){} // RVA: 0x7FFE867A41C0
        public void GetRootElement(){} // RVA: 0x7FFE867A4220
        public void GetElement(){} // RVA: 0x7FFE867A4250
        public void InternalGetElement(){} // RVA: 0x7FFE867A4270
    }

    public class SecurityElement : Object
    {
        public string text; // 0x10
        public string tag; // 0x18
        public System.Collections.ArrayList attributes; // 0x20
        public System.Collections.ArrayList children; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867A68C0 | overloaded x2
        public void get_Children(){} // RVA: 0x7FFE81129130
        public void get_Tag(){} // RVA: 0x7FFE810FE7C0
        public void set_Text(){} // RVA: 0x7FFE867A6AB0
        public void AddAttribute(){} // RVA: 0x7FFE867A6C50
        public void AddChild(){} // RVA: 0x7FFE867A6E50
        public void Escape(){} // RVA: 0x7FFE867A6F80
        public void Unescape(){} // RVA: 0x7FFE867A7200
        public void IsValidAttributeName(){} // RVA: 0x7FFE867A7420
        public void IsValidAttributeValue(){} // RVA: 0x7FFE867A74B0
        public void IsValidTag(){} // RVA: 0x7FFE867A7540
        public void IsValidText(){} // RVA: 0x7FFE867A75D0
        public void SearchForChildByTag(){} // RVA: 0x7FFE867A7660
        public void SearchForTextOfTag(){} // RVA: 0x7FFE867A77F0
        public void ToString(){} // RVA: 0x7FFE867A79A0
        public void ToXml(){} // RVA: 0x7FFE867A7A30
        public void GetAttribute(){} // RVA: 0x7FFE867A8070
        public void set_m_strText(){} // RVA: 0x7FFE810FCE30
        public void SearchForTextOfLocalName(){} // RVA: 0x7FFE867A8280
        public void .cctor(){} // RVA: 0x7FFE867A8550
    }

    public class SecurityException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867A8E80 | overloaded x4
        public void GetObjectData(){} // RVA: 0x7FFE867A8EA0
        public void ToString(){} // RVA: 0x7FFE867A9110
    }

    public class SecurityManager : Object
    {
        // ── Methods ──
        public void get_SecurityEnabled(){} // RVA: 0x7FFE810FB320
        public void EnsureElevatedPermissions(){} // RVA: 0x7FFE810FB310
    }

    public class XmlSyntaxException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x4
    }

}