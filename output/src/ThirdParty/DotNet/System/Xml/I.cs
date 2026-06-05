// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 14
// Methods: 78

namespace ThirdParty.DotNet.System.Xml
{
    public class IDtdAttributeInfo
    {
        // ── Methods ──
        public void get_Prefix(){} // RVA: 0x7FFAF2ABCD60
        public void get_LocalName(){} // RVA: 0x7FFAF2ABCD60
        public void get_LineNumber(){} // RVA: 0x7FFAF2ABD840
        public void get_LinePosition(){} // RVA: 0x7FFAF2ABD840
        public void get_IsNonCDataType(){} // RVA: 0x7FFAF2ABDBE0
        public void get_IsDeclaredInExternal(){} // RVA: 0x7FFAF2ABDBE0
        public void get_IsXmlAttribute(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class IDtdAttributeListInfo
    {
        // ── Methods ──
        public void get_HasNonCDataAttributes(){} // RVA: 0x7FFAF2ABDBE0
        public void LookupAttribute(){} // RVA: 0x7FFAF2ACE6A0
        public void LookupDefaultAttributes(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IDtdDefaultAttributeInfo
    {
        // ── Methods ──
        public void get_DefaultValueExpanded(){} // RVA: 0x7FFAF2ABCD60
        public void get_DefaultValueTyped(){} // RVA: 0x7FFAF2ABCD60
        public void get_ValueLineNumber(){} // RVA: 0x7FFAF2ABD840
        public void get_ValueLinePosition(){} // RVA: 0x7FFAF2ABD840
    }

    public class IDtdEntityInfo
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2ABCD60
        public void get_IsExternal(){} // RVA: 0x7FFAF2ABDBE0
        public void get_IsDeclaredInExternal(){} // RVA: 0x7FFAF2ABDBE0
        public void get_IsUnparsedEntity(){} // RVA: 0x7FFAF2ABDBE0
        public void get_IsParameterEntity(){} // RVA: 0x7FFAF2ABDBE0
        public void get_BaseUriString(){} // RVA: 0x7FFAF2ABCD60
        public void get_DeclaredUriString(){} // RVA: 0x7FFAF2ABCD60
        public void get_SystemId(){} // RVA: 0x7FFAF2ABCD60
        public void get_PublicId(){} // RVA: 0x7FFAF2ABCD60
        public void get_Text(){} // RVA: 0x7FFAF2ABCD60
        public void get_LineNumber(){} // RVA: 0x7FFAF2ABD840
        public void get_LinePosition(){} // RVA: 0x7FFAF2ABD840
    }

    public class IDtdInfo
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2ABCD60
        public void get_InternalDtdSubset(){} // RVA: 0x7FFAF2ABCD60
        public void get_HasDefaultAttributes(){} // RVA: 0x7FFAF2ABDBE0
        public void get_HasNonCDataAttributes(){} // RVA: 0x7FFAF2ABDBE0
        public void LookupAttributeList(){} // RVA: 0x7FFAF2ACE6A0
        public void LookupEntity(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IDtdParser
    {
        // ── Methods ──
        public void ParseInternalDtd(){} // RVA: 0x7FFAF2ACD640
        public void ParseFreeFloatingDtd(){} // RVA: 0x7FFAF2ACF400
    }

    public class IDtdParserAdapter
    {
        // ── Methods ──
        public void get_NameTable(){} // RVA: 0x7FFAF2ABCD60
        public void get_NamespaceResolver(){} // RVA: 0x7FFAF2ABCD60
        public void get_BaseUri(){} // RVA: 0x7FFAF2ABCD60
        public void get_ParsingBuffer(){} // RVA: 0x7FFAF2ABCD60
        public void get_ParsingBufferLength(){} // RVA: 0x7FFAF2ABD840
        public void get_CurrentPosition(){} // RVA: 0x7FFAF2ABD840
        public void set_CurrentPosition(){} // RVA: 0x7FFAF2AD4FA0
        public void get_LineNo(){} // RVA: 0x7FFAF2ABD840
        public void get_LineStartPosition(){} // RVA: 0x7FFAF2ABD840
        public void get_IsEof(){} // RVA: 0x7FFAF2ABDBE0
        public void get_EntityStackLength(){} // RVA: 0x7FFAF2ABD840
        public void get_IsEntityEolNormalized(){} // RVA: 0x7FFAF2ABDBE0
        public void ReadData(){} // RVA: 0x7FFAF2ABD840
        public void OnNewLine(){} // RVA: 0x7FFAF2AD4FA0
        public void ParseNumericCharRef(){} // RVA: 0x7FFAF2AC2590
        public void ParseNamedCharRef(){}
        public void ParsePI(){} // RVA: 0x7FFAF2AD4B10
        public void ParseComment(){} // RVA: 0x7FFAF2AD4B10
        public void PushEntity(){} // RVA: 0x7FFAF2AC1120
        public void PopEntity(){} // RVA: 0x7FFAF2AC1120
        public void PushExternalSubset(){} // RVA: 0x7FFAF2AC1120
        public void PushInternalDtd(){} // RVA: 0x7FFAF2ADDC60
        public void OnSystemId(){}
        public void OnPublicId(){}
        public void Throw(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IDtdParserAdapterV1
    {
        // ── Methods ──
        public void get_V1CompatibilityMode(){} // RVA: 0x7FFAF2ABDBE0
        public void get_Normalization(){} // RVA: 0x7FFAF2ABDBE0
        public void get_Namespaces(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class IDtdParserAdapterWithValidation : rJT
    {
        // ── Methods ──
        public void get_DtdValidation(){} // RVA: 0x7FFAF2ABDBE0
        public void get_ValidationEventHandling(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IValidationEventHandling
    {
        // ── Methods ──
        public void get_EventHandler(){} // RVA: 0x7FFAF2ABCD60
        public void SendEvent(){} // RVA: 0x7FFAF2ADBAA0
    }

    public class IXmlLineInfo
    {
        // ── Methods ──
        public void HasLineInfo(){} // RVA: 0x7FFAF2ABDBE0
        public void get_LineNumber(){} // RVA: 0x7FFAF2ABD840
        public void get_LinePosition(){} // RVA: 0x7FFAF2ABD840
    }

    public class IXmlNamespaceResolver
    {
        // ── Methods ──
        public void GetNamespacesInScope(){} // RVA: 0x7FFAF2ACBCC0
        public void LookupNamespace(){} // RVA: 0x7FFAF2ABCE10
        public void LookupPrefix(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IncrementalReadDecoder
    {
        // ── Methods ──
        public void get_IsFull(){} // RVA: 0x7FFAF2ABDBE0
        public void Decode(){}
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class IncrementalReadDummyDecoder
    {
        // ── Methods ──
        public void get_IsFull(){} // RVA: 0x7FFAF2D8D320
        public void Decode(){} // RVA: 0x7FFAF94C37E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}