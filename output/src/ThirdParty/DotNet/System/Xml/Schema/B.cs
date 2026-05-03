// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 4
// Methods: 74

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class BaseProcessor : Object
    {
        public System.Xml.XmlNameTable nameTable; // 0x10
        public System.Xml.Schema.SchemaNames schemaNames; // 0x18
        public System.Xml.Schema.ValidationEventHandler eventHandler; // 0x20
        public System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings; // 0x28
        public int errorCount; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87611020 | overloaded x2
        public void get_NameTable(){} // RVA: 0x7FFE81116380
        public void get_SchemaNames(){} // RVA: 0x7FFE87611240
        public void get_EventHandler(){} // RVA: 0x7FFE811290C0
        public void get_CompilationSettings(){} // RVA: 0x7FFE81129130
        public void get_HasErrors(){} // RVA: 0x7FFE86794950
        public void AddToTable(){} // RVA: 0x7FFE87611300
        public void IsValidAttributeGroupRedefine(){} // RVA: 0x7FFE87611980
        public void IsValidGroupRedefine(){} // RVA: 0x7FFE87611AE0
        public void IsValidTypeRedefine(){} // RVA: 0x7FFE87611C10
        public void SendValidationEvent(){} // RVA: 0x7FFE87612650 | overloaded x9
        public void SendValidationEventNoThrow(){} // RVA: 0x7FFE87612720
    }

    public class BaseValidator : Object
    {
        public System.Xml.Schema.XmlSchemaCollection schemaCollection; // 0x10
        public System.Xml.IValidationEventHandling eventHandling; // 0x18
        public System.Xml.XmlNameTable nameTable; // 0x20
        public System.Xml.Schema.SchemaNames schemaNames; // 0x28
        public System.Xml.PositionInfo positionInfo; // 0x30
        public System.Xml.XmlResolver xmlResolver; // 0x38
        public System.Uri baseUri; // 0x40
        public System.Xml.Schema.SchemaInfo schemaInfo; // 0x48
        public System.Xml.XmlValidatingReaderImpl reader; // 0x50
        public System.Xml.XmlQualifiedName elementName; // 0x58
        public System.Xml.Schema.ValidationState context; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87612B10 | overloaded x2
        public void get_Reader(){} // RVA: 0x7FFE8119C0E0
        public void get_SchemaCollection(){} // RVA: 0x7FFE81116380
        public void get_NameTable(){} // RVA: 0x7FFE811290C0
        public void get_SchemaNames(){} // RVA: 0x7FFE87612DB0
        public void get_PositionInfo(){} // RVA: 0x7FFE8144E200
        public void get_XmlResolver(){} // RVA: 0x7FFE8143BA80
        public void set_XmlResolver(){} // RVA: 0x7FFE81437330
        public void get_BaseUri(){} // RVA: 0x7FFE81178740
        public void set_BaseUri(){} // RVA: 0x7FFE81123200
        public void get_EventHandler(){} // RVA: 0x7FFE87612FE0
        public void get_SchemaInfo(){} // RVA: 0x7FFE81176730
        public void set_DtdInfo(){} // RVA: 0x7FFE87613070
        public void get_PreserveWhitespace(){} // RVA: 0x7FFE810FB320
        public void Validate(){} // RVA: 0x7FFE810FB310
        public void CompleteValidation(){} // RVA: 0x7FFE810FB310
        public void FindId(){} // RVA: 0x7FFE813240E0
        public void ValidateText(){} // RVA: 0x7FFE876131B0
        public void ValidateWhitespace(){} // RVA: 0x7FFE876134A0
        public void SaveTextValue(){} // RVA: 0x7FFE87613640
        public void SendValidationEvent(){} // RVA: 0x7FFE87613CB0 | overloaded x7
        public void ProcessEntity(){} // RVA: 0x7FFE87613F50 | overloaded x2
        public void CreateInstance(){} // RVA: 0x7FFE87614130
    }

    public class BinaryFacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x7FFE8746DAA0 | overloaded x2
        public void MatchEnumeration(){} // RVA: 0x7FFE8746DD60 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BitSet : Object
    {
        public int count; // 0x10
        public uint[] bits; // 0x18
        public object field_2; // 0x3CD

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87614500 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE811485C0
        public void get_Item(){} // RVA: 0x7FFE876145A0
        public void Clear(){} // RVA: 0x7FFE876145F0
        public void Set(){} // RVA: 0x7FFE87614640
        public void Get(){} // RVA: 0x7FFE876145A0
        public void NextSet(){} // RVA: 0x7FFE876146B0
        public void And(){} // RVA: 0x7FFE87614740
        public void Or(){} // RVA: 0x7FFE87614810
        public void GetHashCode(){} // RVA: 0x7FFE876148B0
        public void Equals(){} // RVA: 0x7FFE876148F0
        public void Clone(){} // RVA: 0x7FFE87614A70
        public void get_IsEmpty(){} // RVA: 0x7FFE87614BA0
        public void Intersects(){} // RVA: 0x7FFE87614BF0
        public void Subscript(){} // RVA: 0x7FFE87614CC0
        public void EnsureLength(){} // RVA: 0x7FFE87614CD0
    }

}