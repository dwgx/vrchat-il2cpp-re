// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 23
// Methods: 145

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class DataErrorsChangedEventArgs : EventArgs
    {
        public object _propertyName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76DE3F0
        public void get_PropertyName(){} // RVA: 0xB5DBF0
    }

    public class DataObjectAttribute : Attribute
    {
        public object DataObject;
        public object NonDataObject;
        public object Default;
        public object _isDataObject;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
        public void get_IsDataObject(){} // RVA: 0xC120A0
        public void Equals(){} // RVA: 0x76BD9A0
        public void GetHashCode(){} // RVA: 0x76ADE20
        public void IsDefaultAttribute(){} // RVA: 0x76BDA20
        public void .cctor(){} // RVA: 0x76BDA90
    }

    public class DataObjectFieldAttribute : Attribute
    {
        public object _isIdentity;
        public object _isNullable;
        public object _length;
        public object _primaryKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76BDC90
        public void get_IsIdentity(){} // RVA: 0xC120A0
        public void get_IsNullable(){} // RVA: 0xDD5C50
        public void get_Length(){} // RVA: 0x116A650
        public void get_PrimaryKey(){} // RVA: 0xB5DD50
        public void Equals(){} // RVA: 0x76BDCB0
        public void GetHashCode(){} // RVA: 0x76ABD60
    }

    public class DataObjectMethodAttribute : Attribute
    {
        public object _isDefault;
        public object _methodType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76BDD60
        public void get_IsDefault(){} // RVA: 0xC120A0
        public void get_MethodType(){} // RVA: 0x116A650
        public void Equals(){} // RVA: 0x76BDD70
        public void GetHashCode(){} // RVA: 0x76BDE00
        public void Match(){} // RVA: 0x76BDE40
    }

    public class DateTimeConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x76B2D50
        public void CanConvertTo(){} // RVA: 0x76BDEC0
        public void ConvertFrom(){} // RVA: 0x76BDFC0
        public void ConvertTo(){} // RVA: 0x76BE290
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DateTimeOffsetConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x76B5B40
        public void CanConvertTo(){} // RVA: 0x76E2A90
        public void ConvertFrom(){} // RVA: 0x76E2B90
        public void ConvertTo(){} // RVA: 0x76E2F90
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DecimalConverter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_AllowHex(){} // RVA: 0xB43320
        public void get_TargetType(){} // RVA: 0x76BE820
        public void CanConvertTo(){} // RVA: 0x76BE8A0
        public void ConvertTo(){} // RVA: 0x76BE980
        public void FromString(){} // RVA: 0x76BEEB0
        public void ToString(){} // RVA: 0x76BEF40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DefaultBindingPropertyAttribute : Attribute
    {
        public object _name;
        public object Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Name(){} // RVA: 0xB5DBF0
        public void Equals(){} // RVA: 0x76BF0A0
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void .cctor(){} // RVA: 0x76BF150
    }

    public class DefaultEventAttribute : Attribute
    {
        public object _name;
        public object Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Name(){} // RVA: 0xB5DBF0
        public void Equals(){} // RVA: 0x76BF1F0
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void .cctor(){} // RVA: 0x76BF2A0
    }

    public class DefaultPropertyAttribute : Attribute
    {
        public object _name;
        public object Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Name(){} // RVA: 0xB5DBF0
        public void Equals(){} // RVA: 0x76BF3A0
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void .cctor(){} // RVA: 0x76BF450
    }

    public class DefaultValueAttribute : Attribute
    {
        public object _value;
        public object s_convertFromInvariantString;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76ABBA0
        public void get_Value(){} // RVA: 0xB5DBF0
        public void Equals(){} // RVA: 0x76ABC20
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void SetValue(){} // RVA: 0xB44D60
        public void <.ctor>g__TryConvertFromInvariantString|2_0(){} // RVA: 0x76ABD70
    }

    public class DefaultValueAttribute[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class DelegatingTypeDescriptionProvider : TypeDescriptionProvider
    {
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB70100
        public void get_Provider(){} // RVA: 0x76BF550
        public void CreateInstance(){} // RVA: 0x76BF5E0
        public void GetCache(){} // RVA: 0x76BF640
        public void GetFullComponentName(){} // RVA: 0x76BF680
        public void GetExtendedTypeDescriptor(){} // RVA: 0x76BF6C0
        public void GetExtenderProviders(){} // RVA: 0x76BF700
        public void GetReflectionType(){} // RVA: 0x76BF740
        public void GetRuntimeType(){} // RVA: 0x76BF790
        public void GetTypeDescriptor(){} // RVA: 0x76BF7D0
        public void IsSupportedType(){} // RVA: 0x76BF820
    }

    public class DescriptionAttribute : Attribute
    {
        public object Default;
        public object _descriptionValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Description(){} // RVA: 0xB5DBF0
        public void get_DescriptionValue(){} // RVA: 0xB5DBF0
        public void set_DescriptionValue(){} // RVA: 0xB44D60
        public void Equals(){} // RVA: 0x76AE450
        public void GetHashCode(){} // RVA: 0x76AE540
        public void IsDefaultAttribute(){} // RVA: 0x76AE580
        public void .cctor(){} // RVA: 0x76AE5F0
    }

    public class DesignOnlyAttribute : Attribute
    {
        public object _isDesignOnly;
        public object Yes;
        public object No;
        public object Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
        public void get_IsDesignOnly(){} // RVA: 0xC120A0
        public void Equals(){} // RVA: 0x76AE6F0
        public void GetHashCode(){} // RVA: 0x76ADE20
        public void IsDefaultAttribute(){} // RVA: 0x76AE7B0
        public void .cctor(){} // RVA: 0x76AE820
    }

    public class DesignTimeVisibleAttribute : Attribute
    {
        public object _visible;
        public object Yes;
        public object No;
        public object Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Visible(){} // RVA: 0xC120A0
        public void Equals(){} // RVA: 0x76C1880
        public void GetHashCode(){} // RVA: 0x76C1900
        public void IsDefaultAttribute(){} // RVA: 0x76C19B0
        public void .cctor(){} // RVA: 0x76C1A20
    }

    public class DesignerAttribute : Attribute
    {
        public object designerTypeName;
        public object designerBaseTypeName;
        public object typeId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76E4770
        public void get_DesignerBaseTypeName(){} // RVA: 0xB465B0
        public void get_DesignerTypeName(){} // RVA: 0xB5DBF0
        public void get_TypeId(){} // RVA: 0x76E4880
        public void Equals(){} // RVA: 0x76E4970
        public void GetHashCode(){} // RVA: 0x76D7A10
    }

    public class DesignerCategoryAttribute : Attribute
    {
        public object Component;
        public object Default;
        public object Form;
        public object Generic;
        public object _category;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Category(){} // RVA: 0xB5DBF0
        public void Equals(){} // RVA: 0x76AE9C0
        public void GetHashCode(){} // RVA: 0x1269730
        public void IsDefaultAttribute(){} // RVA: 0x76AEA70
        public void get_TypeId(){} // RVA: 0x76AEB20
        public void .cctor(){} // RVA: 0x76AEB70
    }

    public class DesignerSerializationVisibilityAttribute : Attribute
    {
        public object Content;
        public object Hidden;
        public object Visible;
        public object Default;
        public object _visibility;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_Visibility(){} // RVA: 0xB8F8F0
        public void Equals(){} // RVA: 0x76AEF20
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void IsDefaultAttribute(){} // RVA: 0x76AEFF0
        public void .cctor(){} // RVA: 0x76AF060
    }

    public class DisplayNameAttribute : Attribute
    {
        public object Default;
        public object _displayNameValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_DisplayName(){} // RVA: 0xB5DBF0
        public void get_DisplayNameValue(){} // RVA: 0xB5DBF0
        public void set_DisplayNameValue(){} // RVA: 0xB44D60
        public void Equals(){} // RVA: 0x76AF280
        public void GetHashCode(){} // RVA: 0x76AE540
        public void IsDefaultAttribute(){} // RVA: 0x76AF370
        public void .cctor(){} // RVA: 0x76AF3E0
    }

    public class DoWorkEventArgs : CancelEventArgs
    {
        public object result;
        public object argument;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76E4A90
        public void get_Argument(){} // RVA: 0xB700F0
        public void get_Result(){} // RVA: 0xB465B0
        public void set_Result(){} // RVA: 0xBA9BA0
    }

    public class DoWorkEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x23E7ED0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class DoubleConverter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_AllowHex(){} // RVA: 0xB43320
        public void get_TargetType(){} // RVA: 0x76C1BC0
        public void FromString(){} // RVA: 0x76C1D10
        public void ToString(){} // RVA: 0x76C1D40
        public void .ctor(){} // RVA: 0xB43310
    }

}