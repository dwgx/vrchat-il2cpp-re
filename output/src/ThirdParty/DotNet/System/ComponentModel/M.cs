// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 5
// Methods: 124

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class MarshalByValueComponent : Object
    {
        public object s_eventDisposed;
        public object _site;
        public object _events;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Finalize(){} // RVA: 0x66EF570
        public void add_Disposed(){} // RVA: 0x76C9ED0
        public void remove_Disposed(){} // RVA: 0x76C9F60
        public void get_Events(){} // RVA: 0x76C9FF0
        public void get_Site(){} // RVA: 0xB5DBF0
        public void set_Site(){} // RVA: 0xB44D60
        public void Dispose(){} // RVA: 0x76CA100
        public void get_Container(){} // RVA: 0x76CA390
        public void GetService(){} // RVA: 0x76CA3F0
        public void get_DesignMode(){} // RVA: 0x76CA460
        public void ToString(){} // RVA: 0x76CA4C0
        public void .cctor(){} // RVA: 0x76CA5C0
    }

    public class MaskedTextProvider : Object
    {
        public object SPACE_CHAR;
        public object DEFAULT_PROMPT_CHAR;
        public object NULL_PASSWORD_CHAR;
        public object DEFAULT_ALLOW_PROMPT;
        public object INVALID_INDEX;
        public object EDIT_ANY;
        public object EDIT_UNASSIGNED;
        public object EDIT_ASSIGNED;
        public object FORWARD;
        public object BACKWARD;
        public object s_ASCII_ONLY;
        public object s_ALLOW_PROMPT_AS_INPUT;
        public object s_INCLUDE_PROMPT;
        public object s_INCLUDE_LITERALS;
        public object s_RESET_ON_PROMPT;
        public object s_RESET_ON_LITERALS;
        public object s_SKIP_SPACE;
        public object s_maskTextProviderType;
        public object _flagState;
        public object _testString;
        public object _requiredCharCount;
        public object _requiredEditChars;
        public object _optionalEditChars;
        public object _passwordChar;
        public object _promptChar;
        public object _stringDescriptor;
        public object _assignedEditPositionCount;
        public object _culture;
        public object _mask;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76CA790
        public void Initialize(){} // RVA: 0x76CAC00
        public void get_AllowPromptAsInput(){} // RVA: 0x76CB180
        public void get_AssignedEditPositionCount(){} // RVA: 0x18A0130
        public void set_AssignedEditPositionCount(){} // RVA: 0x189D3F0
        public void get_AvailableEditPositionCount(){} // RVA: 0x76CB1F0
        public void Clone(){} // RVA: 0x76CB200
        public void get_Culture(){} // RVA: 0xBC1B30
        public void get_DefaultPasswordChar(){} // RVA: 0x7559C10
        public void get_EditPositionCount(){} // RVA: 0x76CBBE0
        public void get_EditPositions(){} // RVA: 0x76CBBF0
        public void get_IncludeLiterals(){} // RVA: 0x76CBE30
        public void set_IncludeLiterals(){} // RVA: 0x76CBEA0
        public void get_IncludePrompt(){} // RVA: 0x76CBF30
        public void set_IncludePrompt(){} // RVA: 0x76CBFA0
        public void get_AsciiOnly(){} // RVA: 0x76CC030
        public void get_IsPassword(){} // RVA: 0x76CC0A0
        public void set_IsPassword(){} // RVA: 0x76CC0B0
        public void get_InvalidIndex(){} // RVA: 0xFE6B70
        public void get_LastAssignedPosition(){} // RVA: 0x76CC130
        public void get_Length(){} // RVA: 0x76CC180
        public void get_Mask(){} // RVA: 0xBBF8F0
        public void get_MaskCompleted(){} // RVA: 0x76CC1A0
        public void get_MaskFull(){} // RVA: 0x76CC1B0
        public void get_PasswordChar(){} // RVA: 0x6E29C50
        public void set_PasswordChar(){} // RVA: 0x76CC1C0
        public void get_PromptChar(){} // RVA: 0x76CC300
        public void set_PromptChar(){} // RVA: 0x76CC310
        public void get_ResetOnPrompt(){} // RVA: 0x76CC4E0
        public void set_ResetOnPrompt(){} // RVA: 0x76CC550
        public void get_ResetOnSpace(){} // RVA: 0x76CC5E0
        public void set_ResetOnSpace(){} // RVA: 0x76CC650
        public void get_SkipLiterals(){} // RVA: 0x76CC6E0
        public void set_SkipLiterals(){} // RVA: 0x76CC750
        public void get_Item(){} // RVA: 0x76CC7E0
        public void Add(){} // RVA: 0x76CCBA0
        public void Clear(){} // RVA: 0x76CCCC0
        public void FindAssignedEditPositionFrom(){} // RVA: 0x76CCDF0
        public void FindAssignedEditPositionInRange(){} // RVA: 0x76CCE50
        public void FindEditPositionFrom(){} // RVA: 0x76CCF90
        public void FindEditPositionInRange(){} // RVA: 0x76CD000
        public void FindNonEditPositionFrom(){} // RVA: 0x76CD150
        public void FindNonEditPositionInRange(){} // RVA: 0x76CD1A0
        public void FindPositionInRange(){} // RVA: 0x76CD1C0
        public void FindUnassignedEditPositionFrom(){} // RVA: 0x76CD290
        public void FindUnassignedEditPositionInRange(){} // RVA: 0x76CD2E0
        public void GetOperationResultFromHint(){} // RVA: 0x76CD400
        public void InsertAt(){} // RVA: 0x76CD730
        public void InsertAtInt(){} // RVA: 0x76CD7F0
        public void IsAscii(){} // RVA: 0x76CDEA0
        public void IsAciiAlphanumeric(){} // RVA: 0x76CDEC0
        public void IsAlphanumeric(){} // RVA: 0x76CDEF0
        public void IsAsciiLetter(){} // RVA: 0x68A1F50
        public void IsAvailablePosition(){} // RVA: 0x76CDF90
        public void IsEditPosition(){} // RVA: 0x76CE150
        public void IsLiteralPosition(){} // RVA: 0x76CE180
        public void IsPrintableChar(){} // RVA: 0x76CE1B0
        public void IsValidInputChar(){} // RVA: 0x76CE240
        public void IsValidMaskChar(){} // RVA: 0x76CE290
        public void IsValidPasswordChar(){} // RVA: 0x76CE2E0
        public void Remove(){} // RVA: 0x76CE3B0
        public void RemoveAt(){} // RVA: 0x76CE510
        public void RemoveAtInt(){} // RVA: 0x76CE590
        public void Replace(){} // RVA: 0x76CF0E0
        public void ResetChar(){} // RVA: 0x76CF630
        public void ResetString(){} // RVA: 0x76CF6F0
        public void Set(){} // RVA: 0x76CF9C0
        public void SetChar(){} // RVA: 0x76CFBA0
        public void SetString(){} // RVA: 0x76CFD80
        public void TestChar(){} // RVA: 0x76CFEE0
        public void TestEscapeChar(){} // RVA: 0x76D04B0
        public void TestSetChar(){} // RVA: 0x76D0590
        public void TestSetString(){} // RVA: 0x76D0600
        public void TestString(){} // RVA: 0x76D0670
        public void ToDisplayString(){} // RVA: 0x76D07E0
        public void ToString(){} // RVA: 0x76D0C10
        public void VerifyChar(){} // RVA: 0x76D0FC0
        public void VerifyEscapeChar(){} // RVA: 0x76D1010
        public void VerifyString(){} // RVA: 0x76D1090
        public void .cctor(){} // RVA: 0x76D10D0
    }

    public class MemberDescriptor : Object
    {
        public object name;
        public object displayName;
        public object nameHash;
        public object attributeCollection;
        public object attributes;
        public object originalAttributes;
        public object attributesFiltered;
        public object attributesFilled;
        public object metadataVersion;
        public object category;
        public object description;
        public object lockCookie;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76E7A70
        public void get_AttributeArray(){} // RVA: 0x76E8040
        public void set_AttributeArray(){} // RVA: 0x76E8070
        public void get_Attributes(){} // RVA: 0x76E8280
        public void get_Category(){} // RVA: 0x76E8420
        public void get_Description(){} // RVA: 0x76E85B0
        public void get_IsBrowsable(){} // RVA: 0x76E8740
        public void get_Name(){} // RVA: 0x76E8850
        public void get_NameHashCode(){} // RVA: 0xFEAE90
        public void get_DesignTimeOnly(){} // RVA: 0x76E88A0
        public void get_DisplayName(){} // RVA: 0x76E89D0
        public void CheckAttributesValid(){} // RVA: 0x76E8B30
        public void CreateAttributeCollection(){} // RVA: 0x76E8BF0
        public void Equals(){} // RVA: 0x76E8C70
        public void FillAttributes(){} // RVA: 0x76E8F80
        public void FilterAttributesIfNeeded(){} // RVA: 0x76E90B0
        public void FindMethod(){} // RVA: 0x76E96C0
        public void GetHashCode(){} // RVA: 0xFEAE90
        public void GetInvocationTarget(){} // RVA: 0x76E9780
        public void GetSite(){} // RVA: 0x76E9890
        public void GetInvokee(){} // RVA: 0x76E9950
    }

    public class MergablePropertyAttribute : Attribute
    {
        public object Yes;
        public object No;
        public object Default;
        public object _allowMerge;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
        public void get_AllowMerge(){} // RVA: 0xC120A0
        public void Equals(){} // RVA: 0x76B02A0
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void IsDefaultAttribute(){} // RVA: 0x76B0360
        public void .cctor(){} // RVA: 0x76B03D0
    }

    public class MultilineStringConverter : TypeConverter
    {
        // ── Methods ──
        public void ConvertTo(){} // RVA: 0x76D15A0
        public void GetProperties(){} // RVA: 0xDAC980
        public void GetPropertiesSupported(){} // RVA: 0xB43320
        public void .ctor(){} // RVA: 0xB43310
    }

}