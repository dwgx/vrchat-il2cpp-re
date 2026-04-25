// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 22
// Methods: 160

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class DataErrorsChangedEventArgs : EventArgs
    {
        public string PropertyName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94177A0
        public void get_PropertyName(){} // RVA: 0x7FFAC2F3C380
    }

    public class DataObjectAttribute : Attribute
    {
        public System.ComponentModel.DataObjectAttribute IsDataObject;
        public System.ComponentModel.DataObjectAttribute NonDataObject; // 0x8
        public System.ComponentModel.DataObjectAttribute Default; // 0x10
        public bool <IsDataObject>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0 | overloaded x2
        public void get_IsDataObject(){} // RVA: 0x7FFAC2FEB5E0
        public void Equals(){} // RVA: 0x7FFAC93F5FA0
        public void GetHashCode(){} // RVA: 0x7FFAC93F6020
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93F6070
        public void .cctor(){} // RVA: 0x7FFAC93F60E0
    }

    public class DataObjectFieldAttribute : Attribute
    {
        public bool IsIdentity; // 0x10
        public bool IsNullable; // 0x11
        public int Length; // 0x14
        public bool PrimaryKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93F62E0 | overloaded x4
        public void get_IsIdentity(){} // RVA: 0x7FFAC2FEB5E0
        public void get_IsNullable(){} // RVA: 0x7FFAC3771DA0
        public void get_Length(){} // RVA: 0x7FFAC33D5A20
        public void get_PrimaryKey(){} // RVA: 0x7FFAC2F3C4E0
        public void Equals(){} // RVA: 0x7FFAC93F6300
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
    }

    public class DataObjectMethodAttribute : Attribute
    {
        public bool IsDefault; // 0x10
        public 0x6B1338A8 MethodType; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93F63B0 | overloaded x2
        public void get_IsDefault(){} // RVA: 0x7FFAC2FEB5E0
        public void get_MethodType(){} // RVA: 0x7FFAC33D5A20
        public void Equals(){} // RVA: 0x7FFAC93F63C0
        public void GetHashCode(){} // RVA: 0x7FFAC93F6450
        public void Match(){} // RVA: 0x7FFAC93F64B0
    }

    public class DateTimeConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7FFAC93F6530
        public void CanConvertTo(){} // RVA: 0x7FFAC93F6620
        public void ConvertFrom(){} // RVA: 0x7FFAC93F6710
        public void ConvertTo(){} // RVA: 0x7FFAC93F6A10
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DateTimeOffsetConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7FFAC941C000
        public void CanConvertTo(){} // RVA: 0x7FFAC941C0F0
        public void ConvertFrom(){} // RVA: 0x7FFAC941C1E0
        public void ConvertTo(){} // RVA: 0x7FFAC941C610
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DecimalConverter : BaseNumberConverter
    {
        public object AllowHex;
        public object TargetType;

        // ── Methods ──
        public void get_AllowHex(){} // RVA: 0x7FFAC2F21320
        public void get_TargetType(){} // RVA: 0x7FFAC93F6FB0
        public void CanConvertTo(){} // RVA: 0x7FFAC93F7060
        public void ConvertTo(){} // RVA: 0x7FFAC93F7180
        public void FromString(){} // RVA: 0x7FFAC93F76B0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC93F7740
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DefaultBindingPropertyAttribute : Attribute
    {
        public string Name; // 0x10
        public System.ComponentModel.DefaultBindingPropertyAttribute Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void Equals(){} // RVA: 0x7FFAC93F78A0
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void .cctor(){} // RVA: 0x7FFAC93F7950
    }

    public class DefaultEventAttribute : Attribute
    {
        public string Name; // 0x10
        public System.ComponentModel.DefaultEventAttribute Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void Equals(){} // RVA: 0x7FFAC93F79F0
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void .cctor(){} // RVA: 0x7FFAC93F7AA0
    }

    public class DefaultPropertyAttribute : Attribute
    {
        public string Name; // 0x10
        public System.ComponentModel.DefaultPropertyAttribute Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void Equals(){} // RVA: 0x7FFAC93F7BA0
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void .cctor(){} // RVA: 0x7FFAC93F7C50
    }

    public class DefaultValueAttribute : Attribute
    {
        public object Value; // 0x10
        public object s_convertFromInvariantString;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93E3600 | overloaded x15
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void Equals(){} // RVA: 0x7FFAC93E36A0
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void SetValue(){} // RVA: 0x7FFAC2F22E30
        public void <.ctor>g__TryConvertFromInvariantString|2_0(){} // RVA: 0x7FFAC93E3810
    }

    public class DelegatingTypeDescriptionProvider : TypeDescriptionProvider
    {
        public System.Type Provider; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Provider(){} // RVA: 0x7FFAC93F7D50
        public void CreateInstance(){} // RVA: 0x7FFAC93F7DE0
        public void GetCache(){} // RVA: 0x7FFAC93F7E40
        public void GetFullComponentName(){} // RVA: 0x7FFAC93F7E80
        public void GetExtendedTypeDescriptor(){} // RVA: 0x7FFAC93F7EC0
        public void GetExtenderProviders(){} // RVA: 0x7FFAC93F7F00
        public void GetReflectionType(){} // RVA: 0x7FFAC93F7F40
        public void GetRuntimeType(){} // RVA: 0x7FFAC93F7F90
        public void GetTypeDescriptor(){} // RVA: 0x7FFAC93F7FD0
        public void IsSupportedType(){} // RVA: 0x7FFAC93F8020
    }

    public class DescriptionAttribute : Attribute
    {
        public System.ComponentModel.DescriptionAttribute Description;
        public string DescriptionValue; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_Description(){} // RVA: 0x7FFAC2F3C380
        public void get_DescriptionValue(){} // RVA: 0x7FFAC2F3C380
        public void set_DescriptionValue(){} // RVA: 0x7FFAC2F22E30
        public void Equals(){} // RVA: 0x7FFAC93E5F70
        public void GetHashCode(){} // RVA: 0x7FFAC93E6070
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93E60B0
        public void .cctor(){} // RVA: 0x7FFAC93E6120
    }

    public class DesignOnlyAttribute : Attribute
    {
        public bool IsDesignOnly; // 0x10
        public System.ComponentModel.DesignOnlyAttribute Yes;
        public System.ComponentModel.DesignOnlyAttribute No; // 0x8
        public System.ComponentModel.DesignOnlyAttribute Default; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
        public void get_IsDesignOnly(){} // RVA: 0x7FFAC2FEB5E0
        public void Equals(){} // RVA: 0x7FFAC93E6250
        public void GetHashCode(){} // RVA: 0x7FFAC93E6310
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93E6360
        public void .cctor(){} // RVA: 0x7FFAC93E63D0
    }

    public class DesignTimeVisibleAttribute : Attribute
    {
        public bool Visible; // 0x10
        public System.ComponentModel.DesignTimeVisibleAttribute Yes;
        public System.ComponentModel.DesignTimeVisibleAttribute No; // 0x8
        public System.ComponentModel.DesignTimeVisibleAttribute Default; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void get_Visible(){} // RVA: 0x7FFAC2FEB5E0
        public void Equals(){} // RVA: 0x7FFAC93FA050
        public void GetHashCode(){} // RVA: 0x7FFAC93FA0D0
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93FA1C0
        public void .cctor(){} // RVA: 0x7FFAC93FA230
    }

    public class DesignerAttribute : Attribute
    {
        public string DesignerBaseTypeName; // 0x10
        public string DesignerTypeName; // 0x18
        public string TypeId; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC941DD30 | overloaded x5
        public void get_DesignerBaseTypeName(){} // RVA: 0x7FFAC2F247C0
        public void get_DesignerTypeName(){} // RVA: 0x7FFAC2F3C380
        public void get_TypeId(){} // RVA: 0x7FFAC941DE40
        public void Equals(){} // RVA: 0x7FFAC941DF30
        public void GetHashCode(){} // RVA: 0x7FFAC9410440
    }

    public class DesignerCategoryAttribute : Attribute
    {
        public System.ComponentModel.DesignerCategoryAttribute Category;
        public System.ComponentModel.DesignerCategoryAttribute TypeId; // 0x8
        public System.ComponentModel.DesignerCategoryAttribute Form; // 0x10
        public System.ComponentModel.DesignerCategoryAttribute Generic; // 0x18
        public string <Category>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_Category(){} // RVA: 0x7FFAC2F3C380
        public void Equals(){} // RVA: 0x7FFAC93E6600
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93E66B0
        public void get_TypeId(){} // RVA: 0x7FFAC93E6760
        public void .cctor(){} // RVA: 0x7FFAC93E67B0
    }

    public class DesignerSerializationVisibilityAttribute : Attribute
    {
        public System.ComponentModel.DesignerSerializationVisibilityAttribute Visibility;
        public System.ComponentModel.DesignerSerializationVisibilityAttribute Hidden; // 0x8
        public System.ComponentModel.DesignerSerializationVisibilityAttribute Visible; // 0x10
        public System.ComponentModel.DesignerSerializationVisibilityAttribute Default; // 0x18
        public 0x6B1328D8 <Visibility>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_Visibility(){} // RVA: 0x7FFAC2F6E5C0
        public void Equals(){} // RVA: 0x7FFAC93E6B90
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93E6C60
        public void .cctor(){} // RVA: 0x7FFAC93E6CD0
    }

    public class DisplayNameAttribute : Attribute
    {
        public System.ComponentModel.DisplayNameAttribute DisplayName;
        public string DisplayNameValue; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_DisplayName(){} // RVA: 0x7FFAC2F3C380
        public void get_DisplayNameValue(){} // RVA: 0x7FFAC2F3C380
        public void set_DisplayNameValue(){} // RVA: 0x7FFAC2F22E30
        public void Equals(){} // RVA: 0x7FFAC93E6F80
        public void GetHashCode(){} // RVA: 0x7FFAC93E6070
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93E7080
        public void .cctor(){} // RVA: 0x7FFAC93E70F0
    }

    public class DoWorkEventArgs : CancelEventArgs
    {
        public object Argument; // 0x18
        public object Result; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC941E050
        public void get_Argument(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Result(){} // RVA: 0x7FFAC2F247C0
        public void set_Result(){} // RVA: 0x7FFAC2F87E80
    }

    public class DoWorkEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class DoubleConverter : BaseNumberConverter
    {
        public object AllowHex;
        public object TargetType;

        // ── Methods ──
        public void get_AllowHex(){} // RVA: 0x7FFAC2F21320
        public void get_TargetType(){} // RVA: 0x7FFAC93FA3D0
        public void FromString(){} // RVA: 0x7FFAC93FA580 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC93FA5F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}