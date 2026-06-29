// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 2
// Methods: 23

namespace ThirdParty.DotNet.System.Data
{
    public class SimpleType : Object
    {
        public object _baseType;
        public object _baseSimpleType;
        public object _xmlBaseType;
        public object _name;
        public object _length;
        public object _minLength;
        public object _maxLength;
        public object _pattern;
        public object _ns;
        public object _maxExclusive;
        public object _maxInclusive;
        public object _minExclusive;
        public object _minInclusive;
        public object _enumeration;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x719BFE0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x719C520
        public void LoadTypeValues(){} // RVA: 0x719C560
        public void IsPlainString(){} // RVA: 0x719CF30
        public void get_BaseType(){} // RVA: 0xB5DBF0
        public void get_XmlBaseType(){} // RVA: 0xB700F0
        public void get_Name(){} // RVA: 0xB70160
        public void get_Namespace(){} // RVA: 0xBBF8F0
        public void get_Length(){} // RVA: 0xB9E080
        public void get_MaxLength(){} // RVA: 0x18A0130
        public void set_MaxLength(){} // RVA: 0x189D3F0
        public void get_BaseSimpleType(){} // RVA: 0xB465B0
        public void get_SimpleTypeQualifiedName(){} // RVA: 0x719D130
        public void QualifiedName(){} // RVA: 0x719D1A0
        public void ToNode(){} // RVA: 0x719D210
        public void CreateEnumeratedType(){} // RVA: 0x719D7D0
        public void CreateByteArrayType(){} // RVA: 0x719D8A0
        public void CreateLimitedStringType(){} // RVA: 0x719D910
        public void CreateSimpleType(){} // RVA: 0x719D990
        public void HasConflictingDefinition(){} // RVA: 0x719DA80
        public void CanHaveMaxLength(){} // RVA: 0x719DC00
        public void ConvertToAnnonymousSimpleType(){} // RVA: 0x719DD30
    }

    public class SyntaxErrorException : InvalidExpressionException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7135CB0
    }

}