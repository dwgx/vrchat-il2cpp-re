// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 5
// Methods: 162

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class MarshalByValueComponent : Object
    {
        public object s_eventDisposed;
        public System.ComponentModel.ISite _site; // 0x10
        public System.ComponentModel.EventHandlerList _events; // 0x18
        public object field_3; // 0x9

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Finalize(){} // RVA: 0x7FFE867B7E80
        public void add_Disposed(){} // RVA: 0x7FFE877AB270
        public void remove_Disposed(){} // RVA: 0x7FFE877AB300
        public void get_Events(){} // RVA: 0x7FFE877AB390
        public void get_Site(){} // RVA: 0x7FFE81116380
        public void set_Site(){} // RVA: 0x7FFE810FCE30
        public void Dispose(){} // RVA: 0x7FFE877AB4A0 | overloaded x2
        public void get_Container(){} // RVA: 0x7FFE877AB760
        public void GetService(){} // RVA: 0x7FFE877AB7C0
        public void get_DesignMode(){} // RVA: 0x7FFE877AB830
        public void ToString(){} // RVA: 0x7FFE877AB890
        public void .cctor(){} // RVA: 0x7FFE877AB990
    }

    public class MaskedTextProvider : Object
    {
        public char SPACE_CHAR;
        public char DEFAULT_PROMPT_CHAR;
        public char NULL_PASSWORD_CHAR;
        public bool DEFAULT_ALLOW_PROMPT;
        public int INVALID_INDEX;
        public byte EDIT_ANY;
        public byte EDIT_UNASSIGNED;
        public byte EDIT_ASSIGNED;
        public bool FORWARD;
        public bool BACKWARD;
        public int s_ASCII_ONLY;
        public int s_ALLOW_PROMPT_AS_INPUT; // 0x4
        public int s_INCLUDE_PROMPT; // 0x8
        public int s_INCLUDE_LITERALS; // 0xC
        public int s_RESET_ON_PROMPT; // 0x10
        public int s_RESET_ON_LITERALS; // 0x14
        public int s_SKIP_SPACE; // 0x18
        public System.Type s_maskTextProviderType; // 0x20
        public System.Collections.Specialized.BitVector32 _flagState; // 0x10
        public System.Text.StringBuilder _testString; // 0x18
        public int _requiredCharCount; // 0x20
        public int _requiredEditChars; // 0x24
        public int _optionalEditChars; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877ABB60 | overloaded x7
        public void Initialize(){} // RVA: 0x7FFE877ABFC0
        public void get_AllowPromptAsInput(){} // RVA: 0x7FFE877AC590
        public void get_AssignedEditPositionCount(){} // RVA: 0x7FFE81D46090
        public void set_AssignedEditPositionCount(){} // RVA: 0x7FFE81D46A00
        public void get_AvailableEditPositionCount(){} // RVA: 0x7FFE877AC600
        public void Clone(){} // RVA: 0x7FFE877AC610
        public void get_Culture(){} // RVA: 0x7FFE81178740
        public void get_DefaultPasswordChar(){} // RVA: 0x7FFE87634F30
        public void get_EditPositionCount(){} // RVA: 0x7FFE877AD020
        public void get_EditPositions(){} // RVA: 0x7FFE877AD030
        public void get_IncludeLiterals(){} // RVA: 0x7FFE877AD260
        public void set_IncludeLiterals(){} // RVA: 0x7FFE877AD2D0
        public void get_IncludePrompt(){} // RVA: 0x7FFE877AD360
        public void set_IncludePrompt(){} // RVA: 0x7FFE877AD3D0
        public void get_AsciiOnly(){} // RVA: 0x7FFE877AD460
        public void get_IsPassword(){} // RVA: 0x7FFE877AD4D0
        public void set_IsPassword(){} // RVA: 0x7FFE877AD4E0
        public void get_InvalidIndex(){} // RVA: 0x7FFE81517DA0
        public void get_LastAssignedPosition(){} // RVA: 0x7FFE877AD560
        public void get_Length(){} // RVA: 0x7FFE877AD5B0
        public void get_Mask(){} // RVA: 0x7FFE81176730
        public void get_MaskCompleted(){} // RVA: 0x7FFE877AD5D0
        public void get_MaskFull(){} // RVA: 0x7FFE877AD5E0
        public void get_PasswordChar(){} // RVA: 0x7FFE86EFC1C0
        public void set_PasswordChar(){} // RVA: 0x7FFE877AD5F0
        public void get_PromptChar(){} // RVA: 0x7FFE877AD730
        public void set_PromptChar(){} // RVA: 0x7FFE877AD740
        public void get_ResetOnPrompt(){} // RVA: 0x7FFE877AD910
        public void set_ResetOnPrompt(){} // RVA: 0x7FFE877AD980
        public void get_ResetOnSpace(){} // RVA: 0x7FFE877ADA10
        public void set_ResetOnSpace(){} // RVA: 0x7FFE877ADA80
        public void get_SkipLiterals(){} // RVA: 0x7FFE877ADB10
        public void set_SkipLiterals(){} // RVA: 0x7FFE877ADB80
        public void get_Item(){} // RVA: 0x7FFE877ADC10
        public void Add(){} // RVA: 0x7FFE877AE040 | overloaded x4
        public void Clear(){} // RVA: 0x7FFE877AE160 | overloaded x2
        public void FindAssignedEditPositionFrom(){} // RVA: 0x7FFE877AE290
        public void FindAssignedEditPositionInRange(){} // RVA: 0x7FFE877AE2F0
        public void FindEditPositionFrom(){} // RVA: 0x7FFE877AE430
        public void FindEditPositionInRange(){} // RVA: 0x7FFE877AE4A0 | overloaded x2
        public void FindNonEditPositionFrom(){} // RVA: 0x7FFE877AE5F0
        public void FindNonEditPositionInRange(){} // RVA: 0x7FFE877AE640
        public void FindPositionInRange(){} // RVA: 0x7FFE877AE660
        public void FindUnassignedEditPositionFrom(){} // RVA: 0x7FFE877AE740
        public void FindUnassignedEditPositionInRange(){} // RVA: 0x7FFE877AE790
        public void GetOperationResultFromHint(){} // RVA: 0x7FFE877AE8A0
        public void InsertAt(){} // RVA: 0x7FFE877AEBB0 | overloaded x4
        public void InsertAtInt(){} // RVA: 0x7FFE877AEC70
        public void IsAscii(){} // RVA: 0x7FFE877AF090
        public void IsAciiAlphanumeric(){} // RVA: 0x7FFE877AF0B0
        public void IsAlphanumeric(){} // RVA: 0x7FFE877AF0E0
        public void IsAsciiLetter(){} // RVA: 0x7FFE86969590
        public void IsAvailablePosition(){} // RVA: 0x7FFE877AF160
        public void IsEditPosition(){} // RVA: 0x7FFE877AF320 | overloaded x2
        public void IsLiteralPosition(){} // RVA: 0x7FFE877AF350
        public void IsPrintableChar(){} // RVA: 0x7FFE877AF380
        public void IsValidInputChar(){} // RVA: 0x7FFE877AF430
        public void IsValidMaskChar(){} // RVA: 0x7FFE877AF480
        public void IsValidPasswordChar(){} // RVA: 0x7FFE877AF4D0
        public void Remove(){} // RVA: 0x7FFE877AF5A0 | overloaded x2
        public void RemoveAt(){} // RVA: 0x7FFE877AF700 | overloaded x3
        public void RemoveAtInt(){} // RVA: 0x7FFE877AF780
        public void Replace(){} // RVA: 0x7FFE877B00A0 | overloaded x6
        public void ResetChar(){} // RVA: 0x7FFE877B0430
        public void ResetString(){} // RVA: 0x7FFE877B04F0
        public void Set(){} // RVA: 0x7FFE877B07C0 | overloaded x2
        public void SetChar(){} // RVA: 0x7FFE877B09A0 | overloaded x2
        public void SetString(){} // RVA: 0x7FFE877B0B90
        public void TestChar(){} // RVA: 0x7FFE877B0CF0
        public void TestEscapeChar(){} // RVA: 0x7FFE877B12D0 | overloaded x2
        public void TestSetChar(){} // RVA: 0x7FFE877B13B0
        public void TestSetString(){} // RVA: 0x7FFE877B1420
        public void TestString(){} // RVA: 0x7FFE877B1490
        public void ToDisplayString(){} // RVA: 0x7FFE877B1600
        public void ToString(){} // RVA: 0x7FFE877B1A20 | overloaded x7
        public void VerifyChar(){} // RVA: 0x7FFE877B1DC0
        public void VerifyEscapeChar(){} // RVA: 0x7FFE877B1E10
        public void VerifyString(){} // RVA: 0x7FFE877B1E90 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE877B1ED0
    }

    public class MemberDescriptor : Object
    {
        public string name; // 0x10
        public string displayName; // 0x18
        public int nameHash; // 0x20
        public System.ComponentModel.AttributeCollection attributeCollection; // 0x28
        public System.Attribute[] attributes; // 0x30
        public System.Attribute[] originalAttributes; // 0x38
        public bool attributesFiltered; // 0x40
        public bool attributesFilled; // 0x41
        public int metadataVersion; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877C9470 | overloaded x4
        public void get_AttributeArray(){} // RVA: 0x7FFE877C9A30
        public void set_AttributeArray(){} // RVA: 0x7FFE877C9A60
        public void get_Attributes(){} // RVA: 0x7FFE877C9CA0
        public void get_Category(){} // RVA: 0x7FFE877C9E60
        public void get_Description(){} // RVA: 0x7FFE877C9FD0
        public void get_IsBrowsable(){} // RVA: 0x7FFE877CA150
        public void get_Name(){} // RVA: 0x7FFE877CA2A0
        public void get_NameHashCode(){} // RVA: 0x7FFE8151D690
        public void get_DesignTimeOnly(){} // RVA: 0x7FFE877CA2F0
        public void get_DisplayName(){} // RVA: 0x7FFE877CA450
        public void CheckAttributesValid(){} // RVA: 0x7FFE877CA600
        public void CreateAttributeCollection(){} // RVA: 0x7FFE877CA6C0
        public void Equals(){} // RVA: 0x7FFE877CA740
        public void FillAttributes(){} // RVA: 0x7FFE877CAA50
        public void FilterAttributesIfNeeded(){} // RVA: 0x7FFE877CAB90
        public void FindMethod(){} // RVA: 0x7FFE877CB1F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8151D690
        public void GetInvocationTarget(){} // RVA: 0x7FFE877CB2A0
        public void GetSite(){} // RVA: 0x7FFE877CB3C0
        public void GetInvokee(){} // RVA: 0x7FFE877CB480
    }

    public class MergablePropertyAttribute : Attribute
    {
        public System.ComponentModel.MergablePropertyAttribute Yes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
        public void get_AllowMerge(){} // RVA: 0x7FFE811C55E0
        public void Equals(){} // RVA: 0x7FFE877906F0
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void IsDefaultAttribute(){} // RVA: 0x7FFE877907B0
        public void .cctor(){} // RVA: 0x7FFE87790820
    }

    public class MultilineStringConverter : TypeConverter
    {
        // ── Methods ──
        public void ConvertTo(){} // RVA: 0x7FFE877B2400
        public void GetProperties(){} // RVA: 0x7FFE813240E0
        public void GetPropertiesSupported(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}