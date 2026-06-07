// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 4
// Methods: 74

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class BaseProcessor
    {
        public object Count;
        public object Item;
        public object IsEmpty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AD1D30 | overloaded x2
        public void get_NameTable(){} // RVA: 0x2F8380
        public void get_SchemaNames(){} // RVA: 0x6AD1F50
        public void get_EventHandler(){} // RVA: 0x30B0C0
        public void get_CompilationSettings(){} // RVA: 0x30B130
        public void get_HasErrors(){} // RVA: 0x5C53AF0
        public void AddToTable(){} // RVA: 0x6AD2010
        public void IsValidAttributeGroupRedefine(){} // RVA: 0x6AD2690
        public void IsValidGroupRedefine(){} // RVA: 0x6AD27F0
        public void IsValidTypeRedefine(){} // RVA: 0x6AD2920
        public void SendValidationEvent(){} // RVA: 0x6AD3360 | overloaded x9
        public void SendValidationEventNoThrow(){} // RVA: 0x6AD3430
    }

    public class BaseValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AD3820 | overloaded x2
        public void get_Reader(){} // RVA: 0x37E0E0
        public void get_SchemaCollection(){} // RVA: 0x2F8380
        public void get_NameTable(){} // RVA: 0x30B0C0
        public void get_SchemaNames(){} // RVA: 0x6AD3AC0
        public void get_PositionInfo(){} // RVA: 0x6374D0
        public void get_XmlResolver(){} // RVA: 0x4976A0
        public void set_XmlResolver(){} // RVA: 0x49B830
        public void get_BaseUri(){} // RVA: 0x35A740
        public void set_BaseUri(){} // RVA: 0x305200
        public void get_EventHandler(){} // RVA: 0x6AD3CF0
        public void get_SchemaInfo(){} // RVA: 0x358730
        public void set_DtdInfo(){} // RVA: 0x6AD3D80
        public void get_PreserveWhitespace(){} // RVA: 0x2DD320
        public void Validate(){} // RVA: 0x2DD310
        public void CompleteValidation(){} // RVA: 0x2DD310
        public void FindId(){} // RVA: 0x519240
        public void ValidateText(){} // RVA: 0x6AD3EC0
        public void ValidateWhitespace(){} // RVA: 0x6AD41B0
        public void SaveTextValue(){} // RVA: 0x6AD4350
        public void SendValidationEvent(){} // RVA: 0x6AD49C0 | overloaded x7
        public void ProcessEntity(){} // RVA: 0x6AD4C60 | overloaded x2
        public void CreateInstance(){} // RVA: 0x6AD4E40
    }

    public class BinaryFacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x692E7D0 | overloaded x2
        public void MatchEnumeration(){} // RVA: 0x692EA90 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class BitSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AD5210 | overloaded x2
        public void get_Count(){} // RVA: 0x32A5C0
        public void get_Item(){} // RVA: 0x6AD52B0
        public void Clear(){} // RVA: 0x6AD5300
        public void Set(){} // RVA: 0x6AD5350
        public void Get(){} // RVA: 0x6AD52B0
        public void NextSet(){} // RVA: 0x6AD53C0
        public void And(){} // RVA: 0x6AD5450
        public void Or(){} // RVA: 0x6AD5520
        public void GetHashCode(){} // RVA: 0x6AD55C0
        public void Equals(){} // RVA: 0x6AD5600
        public void Clone(){} // RVA: 0x6AD5780
        public void get_IsEmpty(){} // RVA: 0x6AD58B0
        public void Intersects(){} // RVA: 0x6AD5900
        public void Subscript(){} // RVA: 0x6AD59D0
        public void EnsureLength(){} // RVA: 0x6AD59E0
    }

}