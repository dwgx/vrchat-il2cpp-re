// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 2
// Methods: 26

namespace ThirdParty.DotNet.System.Data
{
    public class SimpleType : Object
    {
        public string BaseType; // 0x10
        public System.Data.SimpleType XmlBaseType; // 0x18
        public System.Xml.XmlQualifiedName Name; // 0x20
        public string Namespace; // 0x28
        public int Length; // 0x30
        public int MaxLength; // 0x34
        public int BaseSimpleType; // 0x38
        public string SimpleTypeQualifiedName; // 0x40
        public string _ns; // 0x48
        public string _maxExclusive; // 0x50
        public string _maxInclusive; // 0x58
        public string _minExclusive; // 0x60
        public string _minInclusive; // 0x68
        public string _enumeration; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8ECB140 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC8ECB690
        public void LoadTypeValues(){} // RVA: 0x7FFAC8ECB6D0
        public void IsPlainString(){} // RVA: 0x7FFAC8ECC0E0
        public void get_BaseType(){} // RVA: 0x7FFAC2F3C380
        public void get_XmlBaseType(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Name(){} // RVA: 0x7FFAC2F4F130
        public void get_Namespace(){} // RVA: 0x7FFAC2F9C730
        public void get_Length(){} // RVA: 0x7FFAC2F7CCD0
        public void get_MaxLength(){} // RVA: 0x7FFAC358A870
        public void set_MaxLength(){} // RVA: 0x7FFAC3588350
        public void get_BaseSimpleType(){} // RVA: 0x7FFAC2F247C0
        public void get_SimpleTypeQualifiedName(){} // RVA: 0x7FFAC8ECC2E0
        public void QualifiedName(){} // RVA: 0x7FFAC8ECC350
        public void ToNode(){} // RVA: 0x7FFAC8ECC3C0
        public void CreateEnumeratedType(){} // RVA: 0x7FFAC8ECC980
        public void CreateByteArrayType(){} // RVA: 0x7FFAC8ECCA50
        public void CreateLimitedStringType(){} // RVA: 0x7FFAC8ECCAC0
        public void CreateSimpleType(){} // RVA: 0x7FFAC8ECCB40
        public void HasConflictingDefinition(){} // RVA: 0x7FFAC8ECCC30
        public void CanHaveMaxLength(){} // RVA: 0x7FFAC8ECCDC0
        public void ConvertToAnnonymousSimpleType(){} // RVA: 0x7FFAC8ECCEF0
    }

    public class SyntaxErrorException : InvalidExpressionException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E62F40 | overloaded x3
    }

}