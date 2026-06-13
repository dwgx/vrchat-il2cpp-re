// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 2
// Methods: 26

namespace ThirdParty.DotNet.System.Data
{
    public class SimpleType
    {
        public string _baseType; // 0x10
        public System.Data.SimpleType _baseSimpleType; // 0x18
        public System.Xml.XmlQualifiedName _xmlBaseType; // 0x20
        public string _name; // 0x28
        public int _length; // 0x30
        public int _minLength; // 0x34
        public int _maxLength; // 0x38
        public string _pattern; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6734690 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6734BE0
        public void LoadTypeValues(){} // RVA: 0x6734C20
        public void IsPlainString(){} // RVA: 0x6735630
        public void get_BaseType(){} // RVA: 0x2F8380
        public void get_XmlBaseType(){} // RVA: 0x30B0C0
        public void get_Name(){} // RVA: 0x30B130
        public void get_Namespace(){} // RVA: 0x358730
        public void get_Length(){} // RVA: 0x338CD0
        public void get_MaxLength(){} // RVA: 0xFDC9F0
        public void set_MaxLength(){} // RVA: 0xFDD6E0
        public void get_BaseSimpleType(){} // RVA: 0x2E07C0
        public void get_SimpleTypeQualifiedName(){} // RVA: 0x6735830
        public void QualifiedName(){} // RVA: 0x67358A0
        public void ToNode(){} // RVA: 0x6735910
        public void CreateEnumeratedType(){} // RVA: 0x6735ED0
        public void CreateByteArrayType(){} // RVA: 0x6735FA0
        public void CreateLimitedStringType(){} // RVA: 0x6736010
        public void CreateSimpleType(){} // RVA: 0x6736090
        public void HasConflictingDefinition(){} // RVA: 0x6736180
        public void CanHaveMaxLength(){} // RVA: 0x6736310
        public void ConvertToAnnonymousSimpleType(){} // RVA: 0x6736440
    }

    public class SyntaxErrorException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66CC480 | overloaded x3
    }

}