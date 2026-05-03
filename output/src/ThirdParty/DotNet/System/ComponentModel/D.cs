// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 22
// Methods: 160

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class DataErrorsChangedEventArgs : EventArgs
    {
        public string _propertyName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877BFED0
        public void get_PropertyName(){} // RVA: 0x7FFE81116380
    }

    public class DataObjectAttribute : Attribute
    {
        public System.ComponentModel.DataObjectAttribute DataObject;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0 | overloaded x2
        public void get_IsDataObject(){} // RVA: 0x7FFE811C55E0
        public void Equals(){} // RVA: 0x7FFE8779E6D0
        public void GetHashCode(){} // RVA: 0x7FFE8779E750
        public void IsDefaultAttribute(){} // RVA: 0x7FFE8779E7A0
        public void .cctor(){} // RVA: 0x7FFE8779E810
    }

    public class DataObjectFieldAttribute : Attribute
    {
        public bool _isIdentity; // 0x10
        public bool _isNullable; // 0x11
        public int _length; // 0x14
        public bool _primaryKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8779EA10 | overloaded x4
        public void get_IsIdentity(){} // RVA: 0x7FFE811C55E0
        public void get_IsNullable(){} // RVA: 0x7FFE81346E30
        public void get_Length(){} // RVA: 0x7FFE8164B230
        public void get_PrimaryKey(){} // RVA: 0x7FFE811164E0
        public void Equals(){} // RVA: 0x7FFE8779EA30
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
    }

    public class DataObjectMethodAttribute : Attribute
    {
        public bool _isDefault; // 0x10
        public 0x6652C7CC _methodType; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8779EAE0 | overloaded x2
        public void get_IsDefault(){} // RVA: 0x7FFE811C55E0
        public void get_MethodType(){} // RVA: 0x7FFE8164B230
        public void Equals(){} // RVA: 0x7FFE8779EAF0
        public void GetHashCode(){} // RVA: 0x7FFE8779EB80
        public void Match(){} // RVA: 0x7FFE8779EBE0
    }

    public class DateTimeConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7FFE8779EC60
        public void CanConvertTo(){} // RVA: 0x7FFE8779ED50
        public void ConvertFrom(){} // RVA: 0x7FFE8779EE40
        public void ConvertTo(){} // RVA: 0x7FFE8779F140
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DateTimeOffsetConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7FFE877C4730
        public void CanConvertTo(){} // RVA: 0x7FFE877C4820
        public void ConvertFrom(){} // RVA: 0x7FFE877C4910
        public void ConvertTo(){} // RVA: 0x7FFE877C4D40
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DecimalConverter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_AllowHex(){} // RVA: 0x7FFE810FB320
        public void get_TargetType(){} // RVA: 0x7FFE8779F6E0
        public void CanConvertTo(){} // RVA: 0x7FFE8779F790
        public void ConvertTo(){} // RVA: 0x7FFE8779F8B0
        public void FromString(){} // RVA: 0x7FFE8779FDE0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE8779FE70
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DefaultBindingPropertyAttribute : Attribute
    {
        public string _name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void Equals(){} // RVA: 0x7FFE8779FFD0
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void .cctor(){} // RVA: 0x7FFE877A0080
    }

    public class DefaultEventAttribute : Attribute
    {
        public string _name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void Equals(){} // RVA: 0x7FFE877A0120
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void .cctor(){} // RVA: 0x7FFE877A01D0
    }

    public class DefaultPropertyAttribute : Attribute
    {
        public string _name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void Equals(){} // RVA: 0x7FFE877A02D0
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void .cctor(){} // RVA: 0x7FFE877A0380
    }

    public class DefaultValueAttribute : Attribute
    {
        public object _value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8778BD30 | overloaded x15
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void Equals(){} // RVA: 0x7FFE8778BDD0
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void SetValue(){} // RVA: 0x7FFE810FCE30
        public void <.ctor>g__TryConvertFromInvariantString|2_0(){} // RVA: 0x7FFE8778BF40
    }

    public class DelegatingTypeDescriptionProvider : TypeDescriptionProvider
    {
        public System.Type _type; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811290D0
        public void get_Provider(){} // RVA: 0x7FFE877A0480
        public void CreateInstance(){} // RVA: 0x7FFE877A0510
        public void GetCache(){} // RVA: 0x7FFE877A0570
        public void GetFullComponentName(){} // RVA: 0x7FFE877A05B0
        public void GetExtendedTypeDescriptor(){} // RVA: 0x7FFE877A05F0
        public void GetExtenderProviders(){} // RVA: 0x7FFE877A0630
        public void GetReflectionType(){} // RVA: 0x7FFE877A0670
        public void GetRuntimeType(){} // RVA: 0x7FFE877A06C0
        public void GetTypeDescriptor(){} // RVA: 0x7FFE877A0700
        public void IsSupportedType(){} // RVA: 0x7FFE877A0750
    }

    public class DescriptionAttribute : Attribute
    {
        public System.ComponentModel.DescriptionAttribute Default;
        public string _descriptionValue; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_Description(){} // RVA: 0x7FFE81116380
        public void get_DescriptionValue(){} // RVA: 0x7FFE81116380
        public void set_DescriptionValue(){} // RVA: 0x7FFE810FCE30
        public void Equals(){} // RVA: 0x7FFE8778E6A0
        public void GetHashCode(){} // RVA: 0x7FFE8778E7A0
        public void IsDefaultAttribute(){} // RVA: 0x7FFE8778E7E0
        public void .cctor(){} // RVA: 0x7FFE8778E850
    }

    public class DesignOnlyAttribute : Attribute
    {
        public bool _isDesignOnly; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
        public void get_IsDesignOnly(){} // RVA: 0x7FFE811C55E0
        public void Equals(){} // RVA: 0x7FFE8778E980
        public void GetHashCode(){} // RVA: 0x7FFE8778EA40
        public void IsDefaultAttribute(){} // RVA: 0x7FFE8778EA90
        public void .cctor(){} // RVA: 0x7FFE8778EB00
    }

    public class DesignTimeVisibleAttribute : Attribute
    {
        public bool _visible; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void get_Visible(){} // RVA: 0x7FFE811C55E0
        public void Equals(){} // RVA: 0x7FFE877A2780
        public void GetHashCode(){} // RVA: 0x7FFE877A2800
        public void IsDefaultAttribute(){} // RVA: 0x7FFE877A28F0
        public void .cctor(){} // RVA: 0x7FFE877A2960
    }

    public class DesignerAttribute : Attribute
    {
        public string designerTypeName; // 0x10
        public string designerBaseTypeName; // 0x18
        public string typeId; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877C6460 | overloaded x5
        public void get_DesignerBaseTypeName(){} // RVA: 0x7FFE810FE7C0
        public void get_DesignerTypeName(){} // RVA: 0x7FFE81116380
        public void get_TypeId(){} // RVA: 0x7FFE877C6570
        public void Equals(){} // RVA: 0x7FFE877C6660
        public void GetHashCode(){} // RVA: 0x7FFE877B8B70
    }

    public class DesignerCategoryAttribute : Attribute
    {
        public System.ComponentModel.DesignerCategoryAttribute Component;
        public System.ComponentModel.DesignerCategoryAttribute Default; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_Category(){} // RVA: 0x7FFE81116380
        public void Equals(){} // RVA: 0x7FFE8778ED30
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
        public void IsDefaultAttribute(){} // RVA: 0x7FFE8778EDE0
        public void get_TypeId(){} // RVA: 0x7FFE8778EE90
        public void .cctor(){} // RVA: 0x7FFE8778EEE0
    }

    public class DesignerSerializationVisibilityAttribute : Attribute
    {
        public System.ComponentModel.DesignerSerializationVisibilityAttribute Content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_Visibility(){} // RVA: 0x7FFE811485C0
        public void Equals(){} // RVA: 0x7FFE8778F2C0
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void IsDefaultAttribute(){} // RVA: 0x7FFE8778F390
        public void .cctor(){} // RVA: 0x7FFE8778F400
    }

    public class DisplayNameAttribute : Attribute
    {
        public System.ComponentModel.DisplayNameAttribute Default;
        public string _displayNameValue; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_DisplayName(){} // RVA: 0x7FFE81116380
        public void get_DisplayNameValue(){} // RVA: 0x7FFE81116380
        public void set_DisplayNameValue(){} // RVA: 0x7FFE810FCE30
        public void Equals(){} // RVA: 0x7FFE8778F6B0
        public void GetHashCode(){} // RVA: 0x7FFE8778E7A0
        public void IsDefaultAttribute(){} // RVA: 0x7FFE8778F7B0
        public void .cctor(){} // RVA: 0x7FFE8778F820
    }

    public class DoWorkEventArgs : CancelEventArgs
    {
        public object result; // 0x18
        public object argument; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877C6780
        public void get_Argument(){} // RVA: 0x7FFE811290C0
        public void get_Result(){} // RVA: 0x7FFE810FE7C0
        public void set_Result(){} // RVA: 0x7FFE81161E80
    }

    public class DoWorkEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE82886970
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class DoubleConverter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_AllowHex(){} // RVA: 0x7FFE810FB320
        public void get_TargetType(){} // RVA: 0x7FFE877A2B00
        public void FromString(){} // RVA: 0x7FFE877A2CB0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE877A2D20
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}