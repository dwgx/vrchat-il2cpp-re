// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 2
// Methods: 26

namespace ThirdParty.DotNet.System.Data
{
    public class SimpleType : Object
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
        public void .ctor(){} // RVA: 0x7FFE87273590 | overloaded x2
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE87273AE0
        public void LoadTypeValues(){} // RVA: 0x7FFE87273B20
        public void IsPlainString(){} // RVA: 0x7FFE87274530
        public void get_BaseType(){} // RVA: 0x7FFE81116380
        public void get_XmlBaseType(){} // RVA: 0x7FFE811290C0
        public void get_Name(){} // RVA: 0x7FFE81129130
        public void get_Namespace(){} // RVA: 0x7FFE81176730
        public void get_Length(){} // RVA: 0x7FFE81156CD0
        public void get_MaxLength(){} // RVA: 0x7FFE81D46090
        public void set_MaxLength(){} // RVA: 0x7FFE81D46A00
        public void get_BaseSimpleType(){} // RVA: 0x7FFE810FE7C0
        public void get_SimpleTypeQualifiedName(){} // RVA: 0x7FFE87274730
        public void QualifiedName(){} // RVA: 0x7FFE872747A0
        public void ToNode(){} // RVA: 0x7FFE87274810
        public void CreateEnumeratedType(){} // RVA: 0x7FFE87274DD0
        public void CreateByteArrayType(){} // RVA: 0x7FFE87274EA0
        public void CreateLimitedStringType(){} // RVA: 0x7FFE87274F10
        public void CreateSimpleType(){} // RVA: 0x7FFE87274F90
        public void HasConflictingDefinition(){} // RVA: 0x7FFE87275080
        public void CanHaveMaxLength(){} // RVA: 0x7FFE87275210
        public void ConvertToAnnonymousSimpleType(){} // RVA: 0x7FFE87275340
    }

    public class SyntaxErrorException : InvalidExpressionException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8720B370 | overloaded x3
    }

}