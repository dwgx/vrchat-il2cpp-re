// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 4
// Methods: 74

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class BaseProcessor : Object
    {
        public System.Xml.XmlNameTable NameTable; // 0x10
        public System.Xml.Schema.SchemaNames SchemaNames; // 0x18
        public System.Xml.Schema.ValidationEventHandler EventHandler; // 0x20
        public System.Xml.Schema.XmlSchemaCompilationSettings CompilationSettings; // 0x28
        public int HasErrors; // 0x30
        public string NsXml; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92688B0 | overloaded x2
        public void get_NameTable(){} // RVA: 0x7FFAC2F3C380
        public void get_SchemaNames(){} // RVA: 0x7FFAC9268AD0
        public void get_EventHandler(){} // RVA: 0x7FFAC2F4F0C0
        public void get_CompilationSettings(){} // RVA: 0x7FFAC2F4F130
        public void get_HasErrors(){} // RVA: 0x7FFAC83EB050
        public void AddToTable(){} // RVA: 0x7FFAC9268B90
        public void IsValidAttributeGroupRedefine(){} // RVA: 0x7FFAC9269210
        public void IsValidGroupRedefine(){} // RVA: 0x7FFAC9269370
        public void IsValidTypeRedefine(){} // RVA: 0x7FFAC92694A0
        public void SendValidationEvent(){} // RVA: 0x7FFAC9269EE0 | overloaded x9
        public void SendValidationEventNoThrow(){} // RVA: 0x7FFAC9269FB0
    }

    public class BaseValidator : Object
    {
        public System.Xml.Schema.XmlSchemaCollection Reader; // 0x10
        public System.Xml.IValidationEventHandling SchemaCollection; // 0x18
        public System.Xml.XmlNameTable NameTable; // 0x20
        public System.Xml.Schema.SchemaNames SchemaNames; // 0x28
        public System.Xml.PositionInfo PositionInfo; // 0x30
        public System.Xml.XmlResolver XmlResolver; // 0x38
        public System.Uri BaseUri; // 0x40
        public System.Xml.Schema.SchemaInfo EventHandler; // 0x48
        public System.Xml.XmlValidatingReaderImpl SchemaInfo; // 0x50
        public System.Xml.XmlQualifiedName DtdInfo; // 0x58
        public System.Xml.Schema.ValidationState PreserveWhitespace; // 0x60
        public System.Text.StringBuilder textValue; // 0x68
        public string textString; // 0x70
        public bool hasSibling; // 0x78
        public bool checkDatatype; // 0x79

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC926A3A0 | overloaded x2
        public void get_Reader(){} // RVA: 0x7FFAC2FC20E0
        public void get_SchemaCollection(){} // RVA: 0x7FFAC2F3C380
        public void get_NameTable(){} // RVA: 0x7FFAC2F4F0C0
        public void get_SchemaNames(){} // RVA: 0x7FFAC926A640
        public void get_PositionInfo(){} // RVA: 0x7FFAC31D95E0
        public void get_XmlResolver(){} // RVA: 0x7FFAC31D0140
        public void set_XmlResolver(){} // RVA: 0x7FFAC31D0C20
        public void get_BaseUri(){} // RVA: 0x7FFAC2F9E740
        public void set_BaseUri(){} // RVA: 0x7FFAC2F49200
        public void get_EventHandler(){} // RVA: 0x7FFAC926A870
        public void get_SchemaInfo(){} // RVA: 0x7FFAC2F9C730
        public void set_DtdInfo(){} // RVA: 0x7FFAC926A900
        public void get_PreserveWhitespace(){} // RVA: 0x7FFAC2F21320
        public void Validate(){} // RVA: 0x7FFAC2F21310
        public void CompleteValidation(){} // RVA: 0x7FFAC2F21310
        public void FindId(){} // RVA: 0x7FFAC34F9180
        public void ValidateText(){} // RVA: 0x7FFAC926AA40
        public void ValidateWhitespace(){} // RVA: 0x7FFAC926AD30
        public void SaveTextValue(){} // RVA: 0x7FFAC926AED0
        public void SendValidationEvent(){} // RVA: 0x7FFAC926B540 | overloaded x7
        public void ProcessEntity(){} // RVA: 0x7FFAC926B7E0 | overloaded x2
        public void CreateInstance(){} // RVA: 0x7FFAC926B9C0
    }

    public class BinaryFacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x7FFAC90C52F0 | overloaded x2
        public void MatchEnumeration(){} // RVA: 0x7FFAC90C55B0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BitSet : Object
    {
        public int Count; // 0x10
        public uint[] Item; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC926BD90 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Item(){} // RVA: 0x7FFAC926BE30
        public void Clear(){} // RVA: 0x7FFAC926BE80
        public void Set(){} // RVA: 0x7FFAC926BED0
        public void Get(){} // RVA: 0x7FFAC926BE30
        public void NextSet(){} // RVA: 0x7FFAC926BF40
        public void And(){} // RVA: 0x7FFAC926BFD0
        public void Or(){} // RVA: 0x7FFAC926C0A0
        public void GetHashCode(){} // RVA: 0x7FFAC926C140
        public void Equals(){} // RVA: 0x7FFAC926C180
        public void Clone(){} // RVA: 0x7FFAC926C300
        public void get_IsEmpty(){} // RVA: 0x7FFAC926C430
        public void Intersects(){} // RVA: 0x7FFAC926C480
        public void Subscript(){} // RVA: 0x7FFAC926C550
        public void EnsureLength(){} // RVA: 0x7FFAC926C560
    }

}