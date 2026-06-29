// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security
// Classes: 11
// Methods: 79

namespace ThirdParty.DotNet.System.Security
{
    public class CodeAccessPermission : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Demand(){} // RVA: 0x66DBEB0
        public void Equals(){} // RVA: 0x66DBEE0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void IsSubsetOf(){} // RVA: 0x87D350
        public void ToString(){} // RVA: 0x66DC020
        public void ToXml(){} // RVA: 0x87C0A0
        public void Element(){} // RVA: 0x66DC060
        public void CheckPermissionState(){} // RVA: 0x66DC1F0
        public void ThrowInvalidPermission(){} // RVA: 0x66DC2B0
        public void System.Security.IPermission.Demand(){} // RVA: 0xB43310
    }

    public class IPermission
    {
        // ── Methods ──
        public void Demand(){} // RVA: 0x894290
        public void IsSubsetOf(){} // RVA: 0x87D350
    }

    public class ISecurityEncodable
    {
        // ── Methods ──
        public void ToXml(){} // RVA: 0x87C0A0
    }

    public class NamedPermissionSet : PermissionSet
    {
        public object name;
        public object description;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66DC510
        public void get_Name(){} // RVA: 0xD33E60
        public void set_Name(){} // RVA: 0x66DC670
        public void ToXml(){} // RVA: 0x66DC780
        public void Equals(){} // RVA: 0x66DC830
        public void GetHashCode(){} // RVA: 0x66DC8E0
    }

    public class PermissionSet : Object
    {
        public object psUnrestricted;
        public object state;
        public object list;
        public object _declsec;
        public object _ignored;
        public object action;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66DCA30
        public void CopyTo(){} // RVA: 0x66DCA80
        public void Demand(){} // RVA: 0x66DCC10
        public void CasOnlyDemand(){} // RVA: 0x66DCE80
        public void GetEnumerator(){} // RVA: 0x66DCF30
        public void IsEmpty(){} // RVA: 0x66DCF60
        public void IsUnrestricted(){} // RVA: 0x4A73C40
        public void ToString(){} // RVA: 0x66DD170
        public void ToXml(){} // RVA: 0x66DD1B0
        public void get_Count(){} // RVA: 0x66DD600
        public void get_IsSynchronized(){} // RVA: 0x5C6C5A0
        public void get_SyncRoot(){} // RVA: 0x2303260
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0xB43310
        public void Equals(){} // RVA: 0x66DD630
        public void GetHashCode(){} // RVA: 0x66DD800
        public void .cctor(){} // RVA: 0x66DD850
    }

    public class SecureString : Object
    {
        public object length;
        public object disposed;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66DDB90
        public void get_Length(){} // RVA: 0x66DDD00
        public void Dispose(){} // RVA: 0x66DDD70
        public void Encrypt(){} // RVA: 0x18F3EB0
        public void Decrypt(){} // RVA: 0x18F3EB0
        public void Alloc(){} // RVA: 0x66DDE10
        public void GetBuffer(){} // RVA: 0x66DDFD0
    }

    public class SecurityDocument : Object
    {
        public object m_data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66DB1C0
        public void GuaranteeSize(){} // RVA: 0x66DB260
        public void AddString(){} // RVA: 0x66DB360
        public void AppendString(){} // RVA: 0x66DB4A0
        public void EncodedStringSize(){} // RVA: 0x66DB540
        public void GetString(){} // RVA: 0x66DB560
        public void AddToken(){} // RVA: 0x66DBA20
        public void GetRootElement(){} // RVA: 0x66DBA80
        public void GetElement(){} // RVA: 0x66DBAB0
        public void InternalGetElement(){} // RVA: 0x66DBAD0
    }

    public class SecurityElement : Object
    {
        public object text;
        public object tag;
        public object attributes;
        public object children;
        public object invalid_tag_chars;
        public object invalid_text_chars;
        public object invalid_attr_name_chars;
        public object invalid_attr_value_chars;
        public object invalid_chars;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66DE090
        public void get_Children(){} // RVA: 0xB70160
        public void get_Tag(){} // RVA: 0xB465B0
        public void set_Text(){} // RVA: 0x66DE280
        public void AddAttribute(){} // RVA: 0x66DE420
        public void AddChild(){} // RVA: 0x66DE620
        public void Escape(){} // RVA: 0x66DE750
        public void Unescape(){} // RVA: 0x66DE9D0
        public void IsValidAttributeName(){} // RVA: 0x66DEBF0
        public void IsValidAttributeValue(){} // RVA: 0x66DEC80
        public void IsValidTag(){} // RVA: 0x66DED10
        public void IsValidText(){} // RVA: 0x66DEDA0
        public void SearchForChildByTag(){} // RVA: 0x66DEE30
        public void SearchForTextOfTag(){} // RVA: 0x66DEFC0
        public void ToString(){} // RVA: 0x66DF170
        public void ToXml(){} // RVA: 0x66DF210
        public void GetAttribute(){} // RVA: 0x66DF830
        public void set_m_strText(){} // RVA: 0xB44D60
        public void SearchForTextOfLocalName(){} // RVA: 0x66DFA30
        public void .cctor(){} // RVA: 0x66DFD00
    }

    public class SecurityException : SystemException
    {
        public object permissionState;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66E0610
        public void GetObjectData(){} // RVA: 0x66E0630
        public void ToString(){} // RVA: 0x66E08A0
    }

    public class SecurityManager : Object
    {
        // ── Methods ──
        public void get_SecurityEnabled(){} // RVA: 0xB43320
        public void EnsureElevatedPermissions(){} // RVA: 0xB43310
    }

    public class XmlSyntaxException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

}