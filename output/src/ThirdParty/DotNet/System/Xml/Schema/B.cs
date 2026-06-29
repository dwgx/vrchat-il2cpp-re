// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 4
// Methods: 54

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class BaseProcessor : Object
    {
        public object nameTable;
        public object schemaNames;
        public object eventHandler;
        public object compilationSettings;
        public object errorCount;
        public object NsXml;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7536190
        public void get_NameTable(){} // RVA: 0xB5DBF0
        public void get_SchemaNames(){} // RVA: 0x75363B0
        public void get_EventHandler(){} // RVA: 0xB700F0
        public void get_CompilationSettings(){} // RVA: 0xB70160
        public void get_HasErrors(){} // RVA: 0x66CBBF0
        public void AddToTable(){} // RVA: 0x7536470
        public void IsValidAttributeGroupRedefine(){} // RVA: 0x7536AF0
        public void IsValidGroupRedefine(){} // RVA: 0x7536C50
        public void IsValidTypeRedefine(){} // RVA: 0x7536D80
        public void SendValidationEvent(){} // RVA: 0x75377C0
        public void SendValidationEventNoThrow(){} // RVA: 0x7537890
    }

    public class BaseValidator : Object
    {
        public object schemaCollection;
        public object eventHandling;
        public object nameTable;
        public object schemaNames;
        public object positionInfo;
        public object xmlResolver;
        public object baseUri;
        public object schemaInfo;
        public object reader;
        public object elementName;
        public object context;
        public object textValue;
        public object textString;
        public object hasSibling;
        public object checkDatatype;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7537C80
        public void get_Reader(){} // RVA: 0xBE58B0
        public void get_SchemaCollection(){} // RVA: 0xB5DBF0
        public void get_NameTable(){} // RVA: 0xB700F0
        public void get_SchemaNames(){} // RVA: 0x7537F20
        public void get_PositionInfo(){} // RVA: 0xD33E60
        public void get_XmlResolver(){} // RVA: 0xD05CA0
        public void set_XmlResolver(){} // RVA: 0xD09D70
        public void get_BaseUri(){} // RVA: 0xBC1B30
        public void set_BaseUri(){} // RVA: 0xB6A8C0
        public void get_EventHandler(){} // RVA: 0x7538150
        public void get_SchemaInfo(){} // RVA: 0xBBF8F0
        public void set_DtdInfo(){} // RVA: 0x75381E0
        public void get_PreserveWhitespace(){} // RVA: 0xB43320
        public void Validate(){} // RVA: 0xB43310
        public void CompleteValidation(){} // RVA: 0xB43310
        public void FindId(){} // RVA: 0xDAC980
        public void ValidateText(){} // RVA: 0x75382F0
        public void ValidateWhitespace(){} // RVA: 0x75385D0
        public void SaveTextValue(){} // RVA: 0x7538760
        public void SendValidationEvent(){} // RVA: 0x7538D90
        public void ProcessEntity(){} // RVA: 0x7539030
        public void CreateInstance(){} // RVA: 0x7539210
    }

    public class BinaryFacetsChecker : FacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x73935D0
        public void MatchEnumeration(){} // RVA: 0x7393880
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BitSet : Object
    {
        public object count;
        public object bits;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75395E0
        public void get_Count(){} // RVA: 0xB8F8F0
        public void get_Item(){} // RVA: 0x7539680
        public void Clear(){} // RVA: 0x75396D0
        public void Set(){} // RVA: 0x7539730
        public void Get(){} // RVA: 0x7539680
        public void NextSet(){} // RVA: 0x75397A0
        public void And(){} // RVA: 0x7539840
        public void Or(){} // RVA: 0x7539920
        public void GetHashCode(){} // RVA: 0x75399C0
        public void Equals(){} // RVA: 0x7539A00
        public void Clone(){} // RVA: 0x7539B90
        public void get_IsEmpty(){} // RVA: 0x7539CC0
        public void Intersects(){} // RVA: 0x7539D20
        public void Subscript(){} // RVA: 0x7539E00
        public void EnsureLength(){} // RVA: 0x7539E10
    }

}