// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security
// Classes: 11
// Methods: 91

namespace ThirdParty.DotNet.System.Security
{
    public class CodeAccessPermission : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Demand(){} // RVA: 0x7FFAC83FAD00
        public void Equals(){} // RVA: 0x7FFAC83FAD30
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void IsSubsetOf(){} // RVA: 0x7FFAC2C59F60
        public void ToString(){} // RVA: 0x7FFAC83FAE80
        public void ToXml(){} // RVA: 0x7FFAC2C58E90
        public void Element(){} // RVA: 0x7FFAC83FAEC0
        public void CheckPermissionState(){} // RVA: 0x7FFAC83FB050
        public void ThrowInvalidPermission(){} // RVA: 0x7FFAC83FB110
        public void System.Security.IPermission.Demand(){} // RVA: 0x7FFAC2F21310
    }

    public class IPermission
    {
        // ── Methods ──
        public void Demand(){} // RVA: 0x7FFAC2C70980
        public void IsSubsetOf(){} // RVA: 0x7FFAC2C59F60
    }

    public class ISecurityEncodable
    {
        // ── Methods ──
        public void ToXml(){} // RVA: 0x7FFAC2C58E90
    }

    public class NamedPermissionSet : PermissionSet
    {
        public string Name; // 0x30
        public string description; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83FB390 | overloaded x3
        public void get_Name(){} // RVA: 0x7FFAC31D95E0
        public void set_Name(){} // RVA: 0x7FFAC83FB510
        public void ToXml(){} // RVA: 0x7FFAC83FB640
        public void Equals(){} // RVA: 0x7FFAC83FB6F0
        public void GetHashCode(){} // RVA: 0x7FFAC83FB7A0
    }

    public class PermissionSet : Object
    {
        public object[] Count;
        public 0x6B0CB6D8 IsSynchronized; // 0x10
        public System.Collections.ArrayList SyncRoot; // 0x18
        public bool _declsec; // 0x20
        public bool[] _ignored; // 0x28
        public object[] action; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83FB8F0 | overloaded x3
        public void CopyTo(){} // RVA: 0x7FFAC83FB940
        public void Demand(){} // RVA: 0x7FFAC83FBAD0
        public void CasOnlyDemand(){} // RVA: 0x7FFAC83FBD60
        public void GetEnumerator(){} // RVA: 0x7FFAC83FBE10
        public void IsEmpty(){} // RVA: 0x7FFAC83FBE40
        public void IsUnrestricted(){} // RVA: 0x7FFAC68D5740
        public void ToString(){} // RVA: 0x7FFAC83FC060
        public void ToXml(){} // RVA: 0x7FFAC83FC0A0
        public void get_Count(){} // RVA: 0x7FFAC83FC4F0
        public void get_IsSynchronized(){} // RVA: 0x7FFAC83FC520
        public void get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAC2F21310
        public void Equals(){} // RVA: 0x7FFAC83FC550
        public void GetHashCode(){} // RVA: 0x7FFAC83FC720
        public void .cctor(){} // RVA: 0x7FFAC83FC770
    }

    public class SecureString : Object
    {
        public int Length;
        public int MaxSize;
        public int length; // 0x10
        public bool disposed; // 0x14
        public bool read_only; // 0x15
        public byte[] data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83FCAB0 | overloaded x2
        public void get_Length(){} // RVA: 0x7FFAC83FCC20
        public void Dispose(){} // RVA: 0x7FFAC83FCC90
        public void Encrypt(){} // RVA: 0x7FFAC35D2DD0
        public void Decrypt(){} // RVA: 0x7FFAC35D2DD0
        public void Alloc(){} // RVA: 0x7FFAC83FCD30
        public void GetBuffer(){} // RVA: 0x7FFAC83FCEF0
    }

    public class SecurityDocument : Object
    {
        public byte[] m_data; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83FA030
        public void GuaranteeSize(){} // RVA: 0x7FFAC83FA0D0
        public void AddString(){} // RVA: 0x7FFAC83FA1D0
        public void AppendString(){} // RVA: 0x7FFAC83FA310
        public void EncodedStringSize(){} // RVA: 0x7FFAC83FA3B0
        public void GetString(){} // RVA: 0x7FFAC83FA3D0
        public void AddToken(){} // RVA: 0x7FFAC83FA880
        public void GetRootElement(){} // RVA: 0x7FFAC83FA8E0
        public void GetElement(){} // RVA: 0x7FFAC83FA910
        public void InternalGetElement(){} // RVA: 0x7FFAC83FA930
    }

    public class SecurityElement : Object
    {
        public string Children; // 0x10
        public string Tag; // 0x18
        public System.Collections.ArrayList Text; // 0x20
        public System.Collections.ArrayList m_strText; // 0x28
        public char[] invalid_tag_chars;
        public char[] invalid_text_chars; // 0x8
        public char[] invalid_attr_name_chars; // 0x10
        public char[] invalid_attr_value_chars; // 0x18
        public char[] invalid_chars; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83FCFB0 | overloaded x2
        public void get_Children(){} // RVA: 0x7FFAC2F4F130
        public void get_Tag(){} // RVA: 0x7FFAC2F247C0
        public void set_Text(){} // RVA: 0x7FFAC83FD1A0
        public void AddAttribute(){} // RVA: 0x7FFAC83FD340
        public void AddChild(){} // RVA: 0x7FFAC83FD540
        public void Escape(){} // RVA: 0x7FFAC83FD670
        public void Unescape(){} // RVA: 0x7FFAC83FD8F0
        public void IsValidAttributeName(){} // RVA: 0x7FFAC83FDB10
        public void IsValidAttributeValue(){} // RVA: 0x7FFAC83FDBA0
        public void IsValidTag(){} // RVA: 0x7FFAC83FDC30
        public void IsValidText(){} // RVA: 0x7FFAC83FDCC0
        public void SearchForChildByTag(){} // RVA: 0x7FFAC83FDD50
        public void SearchForTextOfTag(){} // RVA: 0x7FFAC83FDEE0
        public void ToString(){} // RVA: 0x7FFAC83FE090
        public void ToXml(){} // RVA: 0x7FFAC83FE120
        public void GetAttribute(){} // RVA: 0x7FFAC83FE760
        public void set_m_strText(){} // RVA: 0x7FFAC2F22E30
        public void SearchForTextOfLocalName(){} // RVA: 0x7FFAC83FE970
        public void .cctor(){} // RVA: 0x7FFAC83FEC40
    }

    public class SecurityException : SystemException
    {
        public string permissionState; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83FF570 | overloaded x4
        public void GetObjectData(){} // RVA: 0x7FFAC83FF590
        public void ToString(){} // RVA: 0x7FFAC83FF800
    }

    public class SecurityManager : Object
    {
        public object SecurityEnabled;

        // ── Methods ──
        public void get_SecurityEnabled(){} // RVA: 0x7FFAC2F21320
        public void EnsureElevatedPermissions(){} // RVA: 0x7FFAC2F21310
    }

    public class XmlSyntaxException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x4
    }

}