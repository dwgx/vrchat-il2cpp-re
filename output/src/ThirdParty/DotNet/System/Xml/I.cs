// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 14
// Methods: 78

namespace ThirdParty.DotNet.System.Xml
{
    public class IDtdAttributeInfo
    {
        public object Prefix;
        public object LocalName;
        public object LineNumber;
        public object LinePosition;
        public object IsNonCDataType;
        public object IsDeclaredInExternal;
        public object IsXmlAttribute;

        // ── Methods ──
        public void get_Prefix(){} // RVA: 0x7FFAC2C58E90
        public void get_LocalName(){} // RVA: 0x7FFAC2C58E90
        public void get_LineNumber(){} // RVA: 0x7FFAC2C59960
        public void get_LinePosition(){} // RVA: 0x7FFAC2C59960
        public void get_IsNonCDataType(){} // RVA: 0x7FFAC2C59D00
        public void get_IsDeclaredInExternal(){} // RVA: 0x7FFAC2C59D00
        public void get_IsXmlAttribute(){} // RVA: 0x7FFAC2C59D00
    }

    public class IDtdAttributeListInfo
    {
        public object HasNonCDataAttributes;

        // ── Methods ──
        public void get_HasNonCDataAttributes(){} // RVA: 0x7FFAC2C59D00
        public void LookupAttribute(){} // RVA: 0x7FFAC2C6A6F0
        public void LookupDefaultAttributes(){} // RVA: 0x7FFAC2C58E90
    }

    public class IDtdDefaultAttributeInfo
    {
        public object DefaultValueExpanded;
        public object DefaultValueTyped;
        public object ValueLineNumber;
        public object ValueLinePosition;

        // ── Methods ──
        public void get_DefaultValueExpanded(){} // RVA: 0x7FFAC2C58E90
        public void get_DefaultValueTyped(){} // RVA: 0x7FFAC2C58E90
        public void get_ValueLineNumber(){} // RVA: 0x7FFAC2C59960
        public void get_ValueLinePosition(){} // RVA: 0x7FFAC2C59960
    }

    public class IDtdEntityInfo
    {
        public object Name;
        public object IsExternal;
        public object IsDeclaredInExternal;
        public object IsUnparsedEntity;
        public object IsParameterEntity;
        public object BaseUriString;
        public object DeclaredUriString;
        public object SystemId;
        public object PublicId;
        public object Text;
        public object LineNumber;
        public object LinePosition;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_IsExternal(){} // RVA: 0x7FFAC2C59D00
        public void get_IsDeclaredInExternal(){} // RVA: 0x7FFAC2C59D00
        public void get_IsUnparsedEntity(){} // RVA: 0x7FFAC2C59D00
        public void get_IsParameterEntity(){} // RVA: 0x7FFAC2C59D00
        public void get_BaseUriString(){} // RVA: 0x7FFAC2C58E90
        public void get_DeclaredUriString(){} // RVA: 0x7FFAC2C58E90
        public void get_SystemId(){} // RVA: 0x7FFAC2C58E90
        public void get_PublicId(){} // RVA: 0x7FFAC2C58E90
        public void get_Text(){} // RVA: 0x7FFAC2C58E90
        public void get_LineNumber(){} // RVA: 0x7FFAC2C59960
        public void get_LinePosition(){} // RVA: 0x7FFAC2C59960
    }

    public class IDtdInfo
    {
        public object Name;
        public object InternalDtdSubset;
        public object HasDefaultAttributes;
        public object HasNonCDataAttributes;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_InternalDtdSubset(){} // RVA: 0x7FFAC2C58E90
        public void get_HasDefaultAttributes(){} // RVA: 0x7FFAC2C59D00
        public void get_HasNonCDataAttributes(){} // RVA: 0x7FFAC2C59D00
        public void LookupAttributeList(){} // RVA: 0x7FFAC2C6A6F0
        public void LookupEntity(){} // RVA: 0x7FFAC2C58F40
    }

    public class IDtdParser
    {
        // ── Methods ──
        public void ParseInternalDtd(){} // RVA: 0x7FFAC2C696F0
        public void ParseFreeFloatingDtd(){} // RVA: 0x7FFAC2C6B450
    }

    public class IDtdParserAdapter
    {
        public object NameTable;
        public object NamespaceResolver;
        public object BaseUri;
        public object ParsingBuffer;
        public object ParsingBufferLength;
        public object CurrentPosition;
        public object LineNo;
        public object LineStartPosition;
        public object IsEof;
        public object EntityStackLength;
        public object IsEntityEolNormalized;

        // ── Methods ──
        public void get_NameTable(){} // RVA: 0x7FFAC2C58E90
        public void get_NamespaceResolver(){} // RVA: 0x7FFAC2C58E90
        public void get_BaseUri(){} // RVA: 0x7FFAC2C58E90
        public void get_ParsingBuffer(){} // RVA: 0x7FFAC2C58E90
        public void get_ParsingBufferLength(){} // RVA: 0x7FFAC2C59960
        public void get_CurrentPosition(){} // RVA: 0x7FFAC2C59960
        public void set_CurrentPosition(){} // RVA: 0x7FFAC2C70ED0
        public void get_LineNo(){} // RVA: 0x7FFAC2C59960
        public void get_LineStartPosition(){} // RVA: 0x7FFAC2C59960
        public void get_IsEof(){} // RVA: 0x7FFAC2C59D00
        public void get_EntityStackLength(){} // RVA: 0x7FFAC2C59960
        public void get_IsEntityEolNormalized(){} // RVA: 0x7FFAC2C59D00
        public void ReadData(){} // RVA: 0x7FFAC2C59960
        public void OnNewLine(){} // RVA: 0x7FFAC2C70ED0
        public void ParseNumericCharRef(){} // RVA: 0x7FFAC2C5E6B0
        public void ParseNamedCharRef(){}
        public void ParsePI(){} // RVA: 0x7FFAC2C70A40
        public void ParseComment(){} // RVA: 0x7FFAC2C70A40
        public void PushEntity(){} // RVA: 0x7FFAC2C5D200
        public void PopEntity(){} // RVA: 0x7FFAC2C5D200
        public void PushExternalSubset(){} // RVA: 0x7FFAC2C5D200
        public void PushInternalDtd(){} // RVA: 0x7FFAC2C79B30
        public void OnSystemId(){}
        public void OnPublicId(){}
        public void Throw(){} // RVA: 0x7FFAC2C70A40
    }

    public class IDtdParserAdapterV1
    {
        public object V1CompatibilityMode;
        public object Normalization;
        public object Namespaces;

        // ── Methods ──
        public void get_V1CompatibilityMode(){} // RVA: 0x7FFAC2C59D00
        public void get_Normalization(){} // RVA: 0x7FFAC2C59D00
        public void get_Namespaces(){} // RVA: 0x7FFAC2C59D00
    }

    public class IDtdParserAdapterWithValidation
    {
        public object DtdValidation;
        public object ValidationEventHandling;

        // ── Methods ──
        public void get_DtdValidation(){} // RVA: 0x7FFAC2C59D00
        public void get_ValidationEventHandling(){} // RVA: 0x7FFAC2C58E90
    }

    public class IValidationEventHandling
    {
        public object EventHandler;

        // ── Methods ──
        public void get_EventHandler(){} // RVA: 0x7FFAC2C58E90
        public void SendEvent(){} // RVA: 0x7FFAC2C77970
    }

    public class IXmlLineInfo
    {
        public object LineNumber;
        public object LinePosition;

        // ── Methods ──
        public void HasLineInfo(){} // RVA: 0x7FFAC2C59D00
        public void get_LineNumber(){} // RVA: 0x7FFAC2C59960
        public void get_LinePosition(){} // RVA: 0x7FFAC2C59960
    }

    public class IXmlNamespaceResolver
    {
        // ── Methods ──
        public void GetNamespacesInScope(){} // RVA: 0x7FFAC2C67DE0
        public void LookupNamespace(){} // RVA: 0x7FFAC2C58F40
        public void LookupPrefix(){} // RVA: 0x7FFAC2C58F40
    }

    public class IncrementalReadDecoder : Object
    {
        public object IsFull;

        // ── Methods ──
        public void get_IsFull(){} // RVA: 0x7FFAC2C59D00
        public void Decode(){}
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IncrementalReadDummyDecoder : IncrementalReadDecoder
    {
        public object IsFull;

        // ── Methods ──
        public void get_IsFull(){} // RVA: 0x7FFAC2F21320
        public void Decode(){} // RVA: 0x7FFAC91AA330
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}