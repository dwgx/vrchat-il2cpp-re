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
        public void .ctor(){} // RVA: 0x7FFAF9581D30 | overloaded x2
        public void get_NameTable(){} // RVA: 0x7FFAF2DA8380
        public void get_SchemaNames(){} // RVA: 0x7FFAF9581F50
        public void get_EventHandler(){} // RVA: 0x7FFAF2DBB0C0
        public void get_CompilationSettings(){} // RVA: 0x7FFAF2DBB130
        public void get_HasErrors(){} // RVA: 0x7FFAF8703AF0
        public void AddToTable(){} // RVA: 0x7FFAF9582010
        public void IsValidAttributeGroupRedefine(){} // RVA: 0x7FFAF9582690
        public void IsValidGroupRedefine(){} // RVA: 0x7FFAF95827F0
        public void IsValidTypeRedefine(){} // RVA: 0x7FFAF9582920
        public void SendValidationEvent(){} // RVA: 0x7FFAF9583360 | overloaded x9
        public void SendValidationEventNoThrow(){} // RVA: 0x7FFAF9583430
    }

    public class BaseValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9583820 | overloaded x2
        public void get_Reader(){} // RVA: 0x7FFAF2E2E0E0
        public void get_SchemaCollection(){} // RVA: 0x7FFAF2DA8380
        public void get_NameTable(){} // RVA: 0x7FFAF2DBB0C0
        public void get_SchemaNames(){} // RVA: 0x7FFAF9583AC0
        public void get_PositionInfo(){} // RVA: 0x7FFAF30E74D0
        public void get_XmlResolver(){} // RVA: 0x7FFAF2F476A0
        public void set_XmlResolver(){} // RVA: 0x7FFAF2F4B830
        public void get_BaseUri(){} // RVA: 0x7FFAF2E0A740
        public void set_BaseUri(){} // RVA: 0x7FFAF2DB5200
        public void get_EventHandler(){} // RVA: 0x7FFAF9583CF0
        public void get_SchemaInfo(){} // RVA: 0x7FFAF2E08730
        public void set_DtdInfo(){} // RVA: 0x7FFAF9583D80
        public void get_PreserveWhitespace(){} // RVA: 0x7FFAF2D8D320
        public void Validate(){} // RVA: 0x7FFAF2D8D310
        public void CompleteValidation(){} // RVA: 0x7FFAF2D8D310
        public void FindId(){} // RVA: 0x7FFAF2FC9240
        public void ValidateText(){} // RVA: 0x7FFAF9583EC0
        public void ValidateWhitespace(){} // RVA: 0x7FFAF95841B0
        public void SaveTextValue(){} // RVA: 0x7FFAF9584350
        public void SendValidationEvent(){} // RVA: 0x7FFAF95849C0 | overloaded x7
        public void ProcessEntity(){} // RVA: 0x7FFAF9584C60 | overloaded x2
        public void CreateInstance(){} // RVA: 0x7FFAF9584E40
    }

    public class BinaryFacetsChecker
    {
        // ── Methods ──
        public void CheckValueFacets(){} // RVA: 0x7FFAF93DE7D0 | overloaded x2
        public void MatchEnumeration(){} // RVA: 0x7FFAF93DEA90 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BitSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9585210 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Item(){} // RVA: 0x7FFAF95852B0
        public void Clear(){} // RVA: 0x7FFAF9585300
        public void Set(){} // RVA: 0x7FFAF9585350
        public void Get(){} // RVA: 0x7FFAF95852B0
        public void NextSet(){} // RVA: 0x7FFAF95853C0
        public void And(){} // RVA: 0x7FFAF9585450
        public void Or(){} // RVA: 0x7FFAF9585520
        public void GetHashCode(){} // RVA: 0x7FFAF95855C0
        public void Equals(){} // RVA: 0x7FFAF9585600
        public void Clone(){} // RVA: 0x7FFAF9585780
        public void get_IsEmpty(){} // RVA: 0x7FFAF95858B0
        public void Intersects(){} // RVA: 0x7FFAF9585900
        public void Subscript(){} // RVA: 0x7FFAF95859D0
        public void EnsureLength(){} // RVA: 0x7FFAF95859E0
    }

}