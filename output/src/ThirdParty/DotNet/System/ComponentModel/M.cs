// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 5
// Methods: 162

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class MarshalByValueComponent : Object
    {
        public object Events;
        public System.ComponentModel.ISite Site; // 0x10
        public System.ComponentModel.EventHandlerList Container; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Finalize(){} // RVA: 0x7FFAC840E570
        public void add_Disposed(){} // RVA: 0x7FFAC9402B40
        public void remove_Disposed(){} // RVA: 0x7FFAC9402BD0
        public void get_Events(){} // RVA: 0x7FFAC9402C60
        public void get_Site(){} // RVA: 0x7FFAC2F3C380
        public void set_Site(){} // RVA: 0x7FFAC2F22E30
        public void Dispose(){} // RVA: 0x7FFAC9402D70 | overloaded x2
        public void get_Container(){} // RVA: 0x7FFAC9403030
        public void GetService(){} // RVA: 0x7FFAC9403090
        public void get_DesignMode(){} // RVA: 0x7FFAC9403100
        public void ToString(){} // RVA: 0x7FFAC9403160
        public void .cctor(){} // RVA: 0x7FFAC9403260
    }

    public class MaskedTextProvider : Object
    {
        public char AllowPromptAsInput;
        public char AssignedEditPositionCount;
        public char AvailableEditPositionCount;
        public bool Culture;
        public int DefaultPasswordChar;
        public byte EditPositionCount;
        public byte EditPositions;
        public byte IncludeLiterals;
        public bool IncludePrompt;
        public bool AsciiOnly;
        public int IsPassword;
        public int InvalidIndex; // 0x4
        public int LastAssignedPosition; // 0x8
        public int Length; // 0xC
        public int Mask; // 0x10
        public int MaskCompleted; // 0x14
        public int MaskFull; // 0x18
        public System.Type PasswordChar; // 0x20
        public System.Collections.Specialized.BitVector32 PromptChar; // 0x10
        public System.Text.StringBuilder ResetOnPrompt; // 0x18
        public int ResetOnSpace; // 0x20
        public int SkipLiterals; // 0x24
        public int Item; // 0x28
        public char _passwordChar; // 0x2C
        public char _promptChar; // 0x2E
        public System.Collections.Generic.List`1<CharDescriptor> _stringDescriptor; // 0x30
        public int <AssignedEditPositionCount>k__BackingField; // 0x38
        public System.Globalization.CultureInfo <Culture>k__BackingField; // 0x40
        public string <Mask>k__BackingField; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9403430 | overloaded x7
        public void Initialize(){} // RVA: 0x7FFAC9403890
        public void get_AllowPromptAsInput(){} // RVA: 0x7FFAC9403E60
        public void get_AssignedEditPositionCount(){} // RVA: 0x7FFAC358A870
        public void set_AssignedEditPositionCount(){} // RVA: 0x7FFAC3588350
        public void get_AvailableEditPositionCount(){} // RVA: 0x7FFAC9403ED0
        public void Clone(){} // RVA: 0x7FFAC9403EE0
        public void get_Culture(){} // RVA: 0x7FFAC2F9E740
        public void get_DefaultPasswordChar(){} // RVA: 0x7FFAC928C7B0
        public void get_EditPositionCount(){} // RVA: 0x7FFAC94048F0
        public void get_EditPositions(){} // RVA: 0x7FFAC9404900
        public void get_IncludeLiterals(){} // RVA: 0x7FFAC9404B30
        public void set_IncludeLiterals(){} // RVA: 0x7FFAC9404BA0
        public void get_IncludePrompt(){} // RVA: 0x7FFAC9404C30
        public void set_IncludePrompt(){} // RVA: 0x7FFAC9404CA0
        public void get_AsciiOnly(){} // RVA: 0x7FFAC9404D30
        public void get_IsPassword(){} // RVA: 0x7FFAC9404DA0
        public void set_IsPassword(){} // RVA: 0x7FFAC9404DB0
        public void get_InvalidIndex(){} // RVA: 0x7FFAC32BD0E0
        public void get_LastAssignedPosition(){} // RVA: 0x7FFAC9404E30
        public void get_Length(){} // RVA: 0x7FFAC9404E80
        public void get_Mask(){} // RVA: 0x7FFAC2F9C730
        public void get_MaskCompleted(){} // RVA: 0x7FFAC9404EA0
        public void get_MaskFull(){} // RVA: 0x7FFAC9404EB0
        public void get_PasswordChar(){} // RVA: 0x7FFAC8B52B50
        public void set_PasswordChar(){} // RVA: 0x7FFAC9404EC0
        public void get_PromptChar(){} // RVA: 0x7FFAC9405000
        public void set_PromptChar(){} // RVA: 0x7FFAC9405010
        public void get_ResetOnPrompt(){} // RVA: 0x7FFAC94051E0
        public void set_ResetOnPrompt(){} // RVA: 0x7FFAC9405250
        public void get_ResetOnSpace(){} // RVA: 0x7FFAC94052E0
        public void set_ResetOnSpace(){} // RVA: 0x7FFAC9405350
        public void get_SkipLiterals(){} // RVA: 0x7FFAC94053E0
        public void set_SkipLiterals(){} // RVA: 0x7FFAC9405450
        public void get_Item(){} // RVA: 0x7FFAC94054E0
        public void Add(){} // RVA: 0x7FFAC9405910 | overloaded x4
        public void Clear(){} // RVA: 0x7FFAC9405A30 | overloaded x2
        public void FindAssignedEditPositionFrom(){} // RVA: 0x7FFAC9405B60
        public void FindAssignedEditPositionInRange(){} // RVA: 0x7FFAC9405BC0
        public void FindEditPositionFrom(){} // RVA: 0x7FFAC9405D00
        public void FindEditPositionInRange(){} // RVA: 0x7FFAC9405D70 | overloaded x2
        public void FindNonEditPositionFrom(){} // RVA: 0x7FFAC9405EC0
        public void FindNonEditPositionInRange(){} // RVA: 0x7FFAC9405F10
        public void FindPositionInRange(){} // RVA: 0x7FFAC9405F30
        public void FindUnassignedEditPositionFrom(){} // RVA: 0x7FFAC9406010
        public void FindUnassignedEditPositionInRange(){} // RVA: 0x7FFAC9406060
        public void GetOperationResultFromHint(){} // RVA: 0x7FFAC9406170
        public void InsertAt(){} // RVA: 0x7FFAC9406480 | overloaded x4
        public void InsertAtInt(){} // RVA: 0x7FFAC9406540
        public void IsAscii(){} // RVA: 0x7FFAC9406960
        public void IsAciiAlphanumeric(){} // RVA: 0x7FFAC9406980
        public void IsAlphanumeric(){} // RVA: 0x7FFAC94069B0
        public void IsAsciiLetter(){} // RVA: 0x7FFAC85BFDC0
        public void IsAvailablePosition(){} // RVA: 0x7FFAC9406A30
        public void IsEditPosition(){} // RVA: 0x7FFAC9406BF0 | overloaded x2
        public void IsLiteralPosition(){} // RVA: 0x7FFAC9406C20
        public void IsPrintableChar(){} // RVA: 0x7FFAC9406C50
        public void IsValidInputChar(){} // RVA: 0x7FFAC9406D00
        public void IsValidMaskChar(){} // RVA: 0x7FFAC9406D50
        public void IsValidPasswordChar(){} // RVA: 0x7FFAC9406DA0
        public void Remove(){} // RVA: 0x7FFAC9406E70 | overloaded x2
        public void RemoveAt(){} // RVA: 0x7FFAC9406FD0 | overloaded x3
        public void RemoveAtInt(){} // RVA: 0x7FFAC9407050
        public void Replace(){} // RVA: 0x7FFAC9407970 | overloaded x6
        public void ResetChar(){} // RVA: 0x7FFAC9407D00
        public void ResetString(){} // RVA: 0x7FFAC9407DC0
        public void Set(){} // RVA: 0x7FFAC9408090 | overloaded x2
        public void SetChar(){} // RVA: 0x7FFAC9408270 | overloaded x2
        public void SetString(){} // RVA: 0x7FFAC9408460
        public void TestChar(){} // RVA: 0x7FFAC94085C0
        public void TestEscapeChar(){} // RVA: 0x7FFAC9408BA0 | overloaded x2
        public void TestSetChar(){} // RVA: 0x7FFAC9408C80
        public void TestSetString(){} // RVA: 0x7FFAC9408CF0
        public void TestString(){} // RVA: 0x7FFAC9408D60
        public void ToDisplayString(){} // RVA: 0x7FFAC9408ED0
        public void ToString(){} // RVA: 0x7FFAC94092F0 | overloaded x7
        public void VerifyChar(){} // RVA: 0x7FFAC9409690
        public void VerifyEscapeChar(){} // RVA: 0x7FFAC94096E0
        public void VerifyString(){} // RVA: 0x7FFAC9409760 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC94097A0
    }

    public class MemberDescriptor : Object
    {
        public string AttributeArray; // 0x10
        public string Attributes; // 0x18
        public int Category; // 0x20
        public System.ComponentModel.AttributeCollection Description; // 0x28
        public System.Attribute[] IsBrowsable; // 0x30
        public System.Attribute[] Name; // 0x38
        public bool NameHashCode; // 0x40
        public bool DesignTimeOnly; // 0x41
        public int DisplayName; // 0x44
        public string category; // 0x48
        public string description; // 0x50
        public object lockCookie; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9420D40 | overloaded x4
        public void get_AttributeArray(){} // RVA: 0x7FFAC9421300
        public void set_AttributeArray(){} // RVA: 0x7FFAC9421330
        public void get_Attributes(){} // RVA: 0x7FFAC9421570
        public void get_Category(){} // RVA: 0x7FFAC9421730
        public void get_Description(){} // RVA: 0x7FFAC94218A0
        public void get_IsBrowsable(){} // RVA: 0x7FFAC9421A20
        public void get_Name(){} // RVA: 0x7FFAC9421B70
        public void get_NameHashCode(){} // RVA: 0x7FFAC30DBBE0
        public void get_DesignTimeOnly(){} // RVA: 0x7FFAC9421BC0
        public void get_DisplayName(){} // RVA: 0x7FFAC9421D20
        public void CheckAttributesValid(){} // RVA: 0x7FFAC9421ED0
        public void CreateAttributeCollection(){} // RVA: 0x7FFAC9421F90
        public void Equals(){} // RVA: 0x7FFAC9422010
        public void FillAttributes(){} // RVA: 0x7FFAC9422320
        public void FilterAttributesIfNeeded(){} // RVA: 0x7FFAC9422460
        public void FindMethod(){} // RVA: 0x7FFAC9422AC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC30DBBE0
        public void GetInvocationTarget(){} // RVA: 0x7FFAC9422B70
        public void GetSite(){} // RVA: 0x7FFAC9422C90
        public void GetInvokee(){} // RVA: 0x7FFAC9422D50
    }

    public class MergablePropertyAttribute : Attribute
    {
        public System.ComponentModel.MergablePropertyAttribute AllowMerge;
        public System.ComponentModel.MergablePropertyAttribute No; // 0x8
        public System.ComponentModel.MergablePropertyAttribute Default; // 0x10
        public bool <AllowMerge>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
        public void get_AllowMerge(){} // RVA: 0x7FFAC2FEB5E0
        public void Equals(){} // RVA: 0x7FFAC93E7FC0
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93E8080
        public void .cctor(){} // RVA: 0x7FFAC93E80F0
    }

    public class MultilineStringConverter : TypeConverter
    {
        // ── Methods ──
        public void ConvertTo(){} // RVA: 0x7FFAC9409CD0
        public void GetProperties(){} // RVA: 0x7FFAC34F9180
        public void GetPropertiesSupported(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}