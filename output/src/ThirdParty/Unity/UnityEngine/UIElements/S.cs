// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 100
// Methods: 689

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Scale : ValueType
    {
        public object m_Scale;
        public object m_IsNone;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x997190
        public void Initial(){} // RVA: 0x7ED7EA0
        public void None(){} // RVA: 0x7ED7F10
        public void get_value(){} // RVA: 0x45A5B0
        public void set_value(){} // RVA: 0x45A580
        public void op_Equality(){} // RVA: 0x7ED7FA0
        public void op_Inequality(){} // RVA: 0x7ED8000
        public void Equals(){} // RVA: 0x997200
        public void GetHashCode(){} // RVA: 0x997210
        public void ToString(){} // RVA: 0x9649A0
    }

    public class Scroller : VisualElement
    {
        public object valueProperty;
        public object lowValueProperty;
        public object highValueProperty;
        public object directionProperty;
        public object valueChanged;
        public object _slider;
        public object _lowButton;
        public object _highButton;
        public object ussClassName;
        public object horizontalVariantUssClassName;
        public object verticalVariantUssClassName;
        public object sliderUssClassName;
        public object lowButtonUssClassName;
        public object highButtonUssClassName;

        // ── Methods ──
        public void add_valueChanged(){} // RVA: 0x80156B0
        public void remove_valueChanged(){} // RVA: 0x80157D0
        public void get_slider(){} // RVA: 0x166C430
        public void get_lowButton(){} // RVA: 0x16686F0
        public void get_highButton(){} // RVA: 0x1653580
        public void get_value(){} // RVA: 0x80158F0
        public void set_value(){} // RVA: 0x8015920
        public void get_lowValue(){} // RVA: 0x8015A20
        public void set_lowValue(){} // RVA: 0x8015A70
        public void get_highValue(){} // RVA: 0x8015B70
        public void set_highValue(){} // RVA: 0x8015BC0
        public void get_direction(){} // RVA: 0x8015CC0
        public void set_direction(){} // RVA: 0x8015D30
        public void .ctor(){} // RVA: 0x8015F80
        public void Adjust(){} // RVA: 0x8016530
        public void OnSliderValueChange(){} // RVA: 0x80165B0
        public void ScrollPageUp(){} // RVA: 0x8016830
        public void ScrollPageDown(){} // RVA: 0x8016920
        public void .cctor(){} // RVA: 0x8016A10
    }

    public class SerializedVirtualizationData : Object
    {
        public object scrollOffset;
        public object firstVisibleIndex;
        public object contentPadding;
        public object contentHeight;
        public object anchoredItemIndex;
        public object anchorOffset;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Slider : BaseSlider`1
    {
        public object ussClassName;
        public object labelUssClassName;
        public object inputUssClassName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x80231A0
        public void ApplyInputDeviceDelta(){} // RVA: 0x8023310
        public void SliderLerpUnclamped(){} // RVA: 0x80234E0
        public void SliderNormalizeValue(){} // RVA: 0x80236C0
        public void SliderRange(){} // RVA: 0x8023780
        public void ParseStringToValue(){} // RVA: 0x8023820
        public void ComputeValueFromKey(){} // RVA: 0x80238F0
        public void .cctor(){} // RVA: 0x8023B30
    }

    public class SortColumnDescription : Object
    {
        public object columnNameProperty;
        public object columnIndexProperty;
        public object directionProperty;
        public object m_ColumnIndex;
        public object m_ColumnName;
        public object m_SortDirection;
        public object propertyChanged;
        public object _column;
        public object changed;

        // ── Methods ──
        public void add_propertyChanged(){} // RVA: 0x800CD30
        public void remove_propertyChanged(){} // RVA: 0x800CE40
        public void get_columnName(){} // RVA: 0xB465B0
        public void set_columnName(){} // RVA: 0x800CF50
        public void get_columnIndex(){} // RVA: 0xB8F8F0
        public void set_columnIndex(){} // RVA: 0x800D070
        public void get_column(){} // RVA: 0xD33E60
        public void set_column(){} // RVA: 0xB708C0
        public void get_direction(){} // RVA: 0xFEAE90
        public void set_direction(){} // RVA: 0x800D110
        public void add_changed(){} // RVA: 0x800D1B0
        public void remove_changed(){} // RVA: 0x800D2C0
        public void .ctor(){} // RVA: 0x800D410
        public void NotifyPropertyChanged(){} // RVA: 0x800D450
        public void .cctor(){} // RVA: 0x800D540
    }

    public class SortColumnDescriptions : Object
    {
        public object m_Descriptions;
        public object changed;

        // ── Methods ──
        public void add_changed(){} // RVA: 0x800D940
        public void remove_changed(){} // RVA: 0x800DA30
        public void GetEnumerator(){} // RVA: 0x800DB20
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x800DB20
        public void Add(){} // RVA: 0x800DB70
        public void Clear(){} // RVA: 0x800DBE0
        public void Contains(){} // RVA: 0x800DD70
        public void CopyTo(){} // RVA: 0x800DDD0
        public void Remove(){} // RVA: 0x800DEB0
        public void OnDescriptionChanged(){} // RVA: 0xF158E0
        public void get_Count(){} // RVA: 0x800E0E0
        public void get_IsReadOnly(){} // RVA: 0x800E130
        public void Insert(){} // RVA: 0x800E180
        public void .ctor(){} // RVA: 0x800E4A0
    }

    public class StyleBackground : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x997330
        public void set_value(){} // RVA: 0x997360
        public void get_keyword(){} // RVA: 0x53FD80
        public void set_keyword(){} // RVA: 0x93190
        public void .ctor(){} // RVA: 0x997500
        public void op_Equality(){} // RVA: 0x7ED8840
        public void op_Implicit(){} // RVA: 0x7ED88F0
        public void Equals(){} // RVA: 0x9975A0
        public void GetHashCode(){} // RVA: 0x9975B0
        public void ToString(){} // RVA: 0x9975E0
    }

    public class StyleBackgroundPosition : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x997660
        public void set_value(){} // RVA: 0x9976A0
        public void get_keyword(){} // RVA: 0x448F30
        public void set_keyword(){} // RVA: 0x92DF0
        public void .ctor(){} // RVA: 0x9976E0
        public void op_Equality(){} // RVA: 0x7ED8C30
        public void op_Implicit(){} // RVA: 0x7ED8CC0
        public void Equals(){} // RVA: 0x997780
        public void GetHashCode(){} // RVA: 0x997790
        public void ToString(){} // RVA: 0x9977D0
    }

    public class StyleBackgroundRepeat : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x997840
        public void set_value(){} // RVA: 0x997850
        public void get_keyword(){} // RVA: 0x438050
        public void set_keyword(){} // RVA: 0x92DD0
        public void .ctor(){} // RVA: 0x997880
        public void op_Equality(){} // RVA: 0x7ED8F50
        public void op_Implicit(){} // RVA: 0x7ED8F80
        public void Equals(){} // RVA: 0x997900
        public void GetHashCode(){} // RVA: 0x997910
        public void ToString(){} // RVA: 0x997930
    }

    public class StyleBackgroundSize : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x9979B0
        public void set_value(){} // RVA: 0x9979E0
        public void get_keyword(){} // RVA: 0x26A910
        public void set_keyword(){} // RVA: 0xAFF60
        public void .ctor(){} // RVA: 0x8A6880
        public void op_Equality(){} // RVA: 0x7ED91E0
        public void op_Implicit(){} // RVA: 0x7ED92D0
        public void Equals(){} // RVA: 0x997A40
        public void GetHashCode(){} // RVA: 0x997A50
        public void ToString(){} // RVA: 0x997A60
    }

    public class StyleColor : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x997AE0
        public void set_value(){} // RVA: 0x997B00
        public void get_keyword(){} // RVA: 0x95F850
        public void set_keyword(){} // RVA: 0x8C7F0
        public void .ctor(){} // RVA: 0x35DEF0
        public void op_Equality(){} // RVA: 0x7ED95B0
        public void op_Implicit(){} // RVA: 0x7ED9640
        public void Equals(){} // RVA: 0x997BA0
        public void GetHashCode(){} // RVA: 0x997BB0
        public void ToString(){} // RVA: 0x997BD0
    }

    public class StyleCursor : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x997D00
        public void set_value(){} // RVA: 0x997D50
        public void get_keyword(){} // RVA: 0x53FA00
        public void set_keyword(){} // RVA: 0x9E810
        public void .ctor(){} // RVA: 0x997DD0
        public void op_Equality(){} // RVA: 0x7ED9A10
        public void op_Implicit(){} // RVA: 0x7ED9B10
        public void Equals(){} // RVA: 0x997E60
        public void GetHashCode(){} // RVA: 0x997E70
        public void ToString(){} // RVA: 0x997EA0
    }

    public class StyleDataRef`1 : ValueType
    {
        public object m_Ref;

        // ── Methods ──
        public void Acquire(){} // RVA: 0xA94080
        public void Release(){} // RVA: 0x894290
        public void CopyFrom(){} // RVA: 0xA94080
        public void Read(){} // RVA: 0x87C0A0
        public void Write(){} // RVA: 0x87C0A0
        public void Create(){} // RVA: 0xA94080
        public void GetHashCode(){} // RVA: 0x87C130
        public void op_Equality(){} // RVA: 0xA94080
        public void Equals(){} // RVA: 0x87D350
        public void ReferenceEquals(){} // RVA: 0xA94080
    }

    public class StyleDataRef`1 : ValueType
    {
        public object m_Ref;

        // ── Methods ──
        public void Acquire(){} // RVA: 0x4A7FA0
        public void Release(){} // RVA: 0x4A7FE0
        public void CopyFrom(){} // RVA: 0x4A7FF0
        public void Read(){} // RVA: 0x4A8000
        public void Write(){} // RVA: 0x4A8020
        public void Create(){} // RVA: 0x4B985C0
        public void GetHashCode(){} // RVA: 0x4A8030
        public void op_Equality(){} // RVA: 0x4B986F0
        public void Equals(){} // RVA: 0x4A8090
        public void ReferenceEquals(){} // RVA: 0x4A81A0
    }

    public class StyleDataRef`1 : ValueType
    {
        public object m_Ref;

        // ── Methods ──
        public void Acquire(){} // RVA: 0x4A7FA0
        public void Release(){} // RVA: 0x4A7FE0
        public void CopyFrom(){} // RVA: 0x4A81B0
        public void Read(){} // RVA: 0x4A8000
        public void Write(){} // RVA: 0x4A81C0
        public void Create(){} // RVA: 0x4B985C0
        public void GetHashCode(){} // RVA: 0x4A81D0
        public void op_Equality(){} // RVA: 0x4B98EC0
        public void Equals(){} // RVA: 0x4A8230
        public void ReferenceEquals(){} // RVA: 0x4A81A0
    }

    public class StyleDataRef`1 : ValueType
    {
        public object m_Ref;

        // ── Methods ──
        public void Acquire(){} // RVA: 0x4A7FA0
        public void Release(){} // RVA: 0x4A7FE0
        public void CopyFrom(){} // RVA: 0x4A8340
        public void Read(){} // RVA: 0x4A8000
        public void Write(){} // RVA: 0x4A8350
        public void Create(){} // RVA: 0x4B985C0
        public void GetHashCode(){} // RVA: 0x4A8360
        public void op_Equality(){} // RVA: 0x4B99530
        public void Equals(){} // RVA: 0x4A83C0
        public void ReferenceEquals(){} // RVA: 0x4A81A0
    }

    public class StyleDataRef`1 : ValueType
    {
        public object m_Ref;

        // ── Methods ──
        public void Acquire(){} // RVA: 0x4A7FA0
        public void Release(){} // RVA: 0x4A7FE0
        public void CopyFrom(){} // RVA: 0x4A84D0
        public void Read(){} // RVA: 0x4A8000
        public void Write(){} // RVA: 0x4A84E0
        public void Create(){} // RVA: 0x4B985C0
        public void GetHashCode(){} // RVA: 0x4A84F0
        public void op_Equality(){} // RVA: 0x4B99B90
        public void Equals(){} // RVA: 0x4A8550
        public void ReferenceEquals(){} // RVA: 0x4A81A0
    }

    public class StyleDataRef`1 : ValueType
    {
        public object m_Ref;

        // ── Methods ──
        public void Acquire(){} // RVA: 0x4A7FA0
        public void Release(){} // RVA: 0x4A7FE0
        public void CopyFrom(){} // RVA: 0x4A8660
        public void Read(){} // RVA: 0x4A8000
        public void Write(){} // RVA: 0x4A8670
        public void Create(){} // RVA: 0x4B985C0
        public void GetHashCode(){} // RVA: 0x4A8680
        public void op_Equality(){} // RVA: 0x4B9A160
        public void Equals(){} // RVA: 0x4A86E0
        public void ReferenceEquals(){} // RVA: 0x4A81A0
    }

    public class StyleDataRef`1 : ValueType
    {
        public object m_Ref;

        // ── Methods ──
        public void Acquire(){} // RVA: 0x4A7FA0
        public void Release(){} // RVA: 0x4A7FE0
        public void CopyFrom(){} // RVA: 0x4A87F0
        public void Read(){} // RVA: 0x4A8000
        public void Write(){} // RVA: 0x4A8800
        public void Create(){} // RVA: 0x4B985C0
        public void GetHashCode(){} // RVA: 0x4A8810
        public void op_Equality(){} // RVA: 0x4B9A840
        public void Equals(){} // RVA: 0x4A8870
        public void ReferenceEquals(){} // RVA: 0x4A81A0
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0xA94080
        public void set_value(){} // RVA: 0xA94080
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
        public void .ctor(){} // RVA: 0xA94080
        public void op_Equality(){} // RVA: 0xA94080
        public void op_Inequality(){} // RVA: 0xA94080
        public void op_Implicit(){} // RVA: 0xA94080
        public void Equals(){} // RVA: 0x87D350
        public void GetHashCode(){} // RVA: 0x87C130
        public void ToString(){} // RVA: 0x87C0A0
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleEnum`1 : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x4B9B900
        public void op_Inequality(){} // RVA: 0x4B9B950
        public void op_Implicit(){} // RVA: 0x4B9BA30
        public void Equals(){} // RVA: 0x4A8E10
        public void GetHashCode(){} // RVA: 0x4A8E20
        public void ToString(){} // RVA: 0x4A8E70
    }

    public class StyleFloat : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x997F20
        public void set_value(){} // RVA: 0x997F30
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x22C190
        public void op_Equality(){} // RVA: 0x7ED9E20
        public void op_Implicit(){} // RVA: 0x7ED9E70
        public void Equals(){} // RVA: 0x997F80
        public void GetHashCode(){} // RVA: 0x996F20
        public void ToString(){} // RVA: 0x997F90
    }

    public class StyleFont : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x997840
        public void set_value(){} // RVA: 0x853B0
        public void get_keyword(){} // RVA: 0x438050
        public void set_keyword(){} // RVA: 0x92DD0
        public void .ctor(){} // RVA: 0x707CB0
        public void op_Equality(){} // RVA: 0x7EDA040
        public void op_Implicit(){} // RVA: 0x7EDA210
        public void Equals(){} // RVA: 0x998140
        public void GetHashCode(){} // RVA: 0x998150
        public void ToString(){} // RVA: 0x998160
    }

    public class StyleFontDefinition : ValueType
    {
        public object m_Keyword;
        public object m_Value;

        // ── Methods ──
        public void get_value(){} // RVA: 0x998290
        public void set_value(){} // RVA: 0x9982B0
        public void get_keyword(){} // RVA: 0x454FE0
        public void set_keyword(){} // RVA: 0x29580
        public void .ctor(){} // RVA: 0x998430
        public void op_Implicit(){} // RVA: 0x7EDAA90
        public void Equals(){} // RVA: 0x9984E0
        public void GetHashCode(){} // RVA: 0x9984F0
    }

    public class StyleInt : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A8D40
        public void set_value(){} // RVA: 0x4A8D50
        public void get_keyword(){} // RVA: 0x4A8D60
        public void set_keyword(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x4A8DF0
        public void op_Equality(){} // RVA: 0x7EDAC50
        public void op_Implicit(){} // RVA: 0x7ED9E50
        public void Equals(){} // RVA: 0x998550
        public void GetHashCode(){} // RVA: 0x998560
        public void ToString(){} // RVA: 0x998570
    }

    public class StyleLength : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x9985E0
        public void set_value(){} // RVA: 0x998600
        public void get_keyword(){} // RVA: 0x438050
        public void set_keyword(){} // RVA: 0x998640
        public void .ctor(){} // RVA: 0x998720
        public void op_Equality(){} // RVA: 0x7EDAF30
        public void op_Implicit(){} // RVA: 0x7EDB000
        public void Equals(){} // RVA: 0x9987D0
        public void GetHashCode(){} // RVA: 0x9987E0
        public void ToString(){} // RVA: 0x998810
    }

    public class StyleList`1 : ValueType
    {
        public object m_Keyword;
        public object m_Value;

        // ── Methods ──
        public void get_value(){} // RVA: 0x87C0A0
        public void set_value(){} // RVA: 0x894320
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
        public void .ctor(){} // RVA: 0x899290
        public void op_Equality(){} // RVA: 0xA94080
        public void op_Implicit(){} // RVA: 0xA94080
        public void Equals(){} // RVA: 0x87D350
        public void GetHashCode(){} // RVA: 0x87C130
        public void ToString(){} // RVA: 0x87C0A0
    }

    public class StyleList`1 : ValueType
    {
        public object m_Keyword;
        public object m_Value;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A9070
        public void set_value(){} // RVA: 0x4A9080
        public void get_keyword(){} // RVA: 0x454FE0
        public void set_keyword(){} // RVA: 0x29580
        public void .ctor(){} // RVA: 0x475740
        public void op_Equality(){} // RVA: 0x4B9DCD0
        public void op_Implicit(){} // RVA: 0x4B9D2B0
        public void Equals(){} // RVA: 0x4A91C0
        public void GetHashCode(){} // RVA: 0x4A91D0
        public void ToString(){} // RVA: 0x4A90E0
    }

    public class StyleList`1 : ValueType
    {
        public object m_Keyword;
        public object m_Value;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A9070
        public void set_value(){} // RVA: 0x4A9080
        public void get_keyword(){} // RVA: 0x454FE0
        public void set_keyword(){} // RVA: 0x29580
        public void .ctor(){} // RVA: 0x475740
        public void op_Equality(){} // RVA: 0x4B9D7F0
        public void op_Implicit(){} // RVA: 0x4B9D2B0
        public void Equals(){} // RVA: 0x4A9180
        public void GetHashCode(){} // RVA: 0x4A9190
        public void ToString(){} // RVA: 0x4A90E0
    }

    public class StyleList`1 : ValueType
    {
        public object m_Keyword;
        public object m_Value;

        // ── Methods ──
        public void get_value(){} // RVA: 0x4A9070
        public void set_value(){} // RVA: 0x4A9080
        public void get_keyword(){} // RVA: 0x454FE0
        public void set_keyword(){} // RVA: 0x29580
        public void .ctor(){} // RVA: 0x475740
        public void op_Equality(){} // RVA: 0x4B9D1F0
        public void op_Implicit(){} // RVA: 0x4B9D2B0
        public void Equals(){} // RVA: 0x4A90C0
        public void GetHashCode(){} // RVA: 0x4A90D0
        public void ToString(){} // RVA: 0x4A90E0
    }

    public class StylePropertyName : ValueType
    {
        public object _id;
        public object _name;

        // ── Methods ──
        public void get_id(){} // RVA: 0x77E60
        public void get_name(){} // RVA: 0x77ED0
        public void StylePropertyIdFromString(){} // RVA: 0x7EE5BE0
        public void .ctor(){} // RVA: 0x999C00
        public void op_Equality(){} // RVA: 0x7B1F6D0
        public void op_Inequality(){} // RVA: 0x7EE5FC0
        public void op_Implicit(){} // RVA: 0x7EE5FD0
        public void GetHashCode(){} // RVA: 0x454FE0
        public void Equals(){} // RVA: 0x95B3B0
        public void ToString(){} // RVA: 0x8C0C50
    }

    public class StyleRotate : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x998910
        public void set_value(){} // RVA: 0x998940
        public void get_keyword(){} // RVA: 0x53FA00
        public void set_keyword(){} // RVA: 0x9E810
        public void .ctor(){} // RVA: 0x998990
        public void op_Equality(){} // RVA: 0x7EDB390
        public void op_Implicit(){} // RVA: 0x7EDB450
        public void Equals(){} // RVA: 0x998A40
        public void GetHashCode(){} // RVA: 0x998A50
        public void ToString(){} // RVA: 0x998A80
    }

    public class StyleScale : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x998B60
        public void set_value(){} // RVA: 0x997B00
        public void get_keyword(){} // RVA: 0x95F850
        public void set_keyword(){} // RVA: 0x8C7F0
        public void .ctor(){} // RVA: 0x35DEF0
        public void op_Equality(){} // RVA: 0x7EDB820
        public void op_Implicit(){} // RVA: 0x7ED9640
        public void Equals(){} // RVA: 0x998C00
        public void GetHashCode(){} // RVA: 0x998C10
        public void ToString(){} // RVA: 0x998C20
    }

    public class StyleSheet : ScriptableObject
    {
        public object m_ImportedWithErrors;
        public object m_ImportedWithWarnings;
        public object m_Rules;
        public object m_ComplexSelectors;
        public object floats;
        public object dimensions;
        public object colors;
        public object strings;
        public object assets;
        public object imports;
        public object m_FlattenedImportedStyleSheets;
        public object m_ContentHash;
        public object scalableImages;
        public object tables;
        public object nonEmptyTablesMask;
        public object firstRootSelector;
        public object firstWildCardSelector;
        public object m_IsDefaultStyleSheet;
        public object kCustomPropertyMarker;

        // ── Methods ──
        public void get_importedWithErrors(){} // RVA: 0x7B049C0
        public void set_importedWithErrors(){} // RVA: 0xB5DD60
        public void get_importedWithWarnings(){} // RVA: 0x7EE82D0
        public void set_importedWithWarnings(){} // RVA: 0x17F4D80
        public void get_rules(){} // RVA: 0x7489A40
        public void set_rules(){} // RVA: 0x7EE82E0
        public void get_complexSelectors(){} // RVA: 0x7C246A0
        public void set_complexSelectors(){} // RVA: 0x7EE8340
        public void get_flattenedRecursiveImports(){} // RVA: 0x7C7E220
        public void get_contentHash(){} // RVA: 0x7EE83A0
        public void set_contentHash(){} // RVA: 0x25406E0
        public void get_isDefaultStyleSheet(){} // RVA: 0x7EE83B0
        public void set_isDefaultStyleSheet(){} // RVA: 0x7EE83C0
        public void TryCheckAccess(){} // RVA: 0xA94080
        public void CheckAccess(){} // RVA: 0xA94080
        public void OnEnable(){} // RVA: 0x7EE8530
        public void FlattenImportedStyleSheetsRecursive(){} // RVA: 0x7EE8610
        public void SetupReferences(){} // RVA: 0x7EE87A0
        public void ReadKeyword(){} // RVA: 0x7EE9070
        public void ReadFloat(){} // RVA: 0x7EE9080
        public void TryReadFloat(){} // RVA: 0x7EE9130
        public void ReadDimension(){} // RVA: 0x7EE9210
        public void TryReadDimension(){} // RVA: 0x7EE92C0
        public void ReadColor(){} // RVA: 0x7EE93B0
        public void TryReadColor(){} // RVA: 0x7EE9440
        public void ReadString(){} // RVA: 0x7EE94B0
        public void TryReadString(){} // RVA: 0x7EE9510
        public void ReadEnum(){} // RVA: 0x7EE9580
        public void TryReadEnum(){} // RVA: 0x7EE95E0
        public void ReadVariable(){} // RVA: 0x7EE9650
        public void TryReadVariable(){} // RVA: 0x7EE96B0
        public void ReadResourcePath(){} // RVA: 0x7EE9720
        public void TryReadResourcePath(){} // RVA: 0x7EE9780
        public void ReadAssetReference(){} // RVA: 0x7EE97F0
        public void ReadMissingAssetReferenceUrl(){} // RVA: 0x7EE9850
        public void TryReadAssetReference(){} // RVA: 0x7EE98B0
        public void ReadFunction(){} // RVA: 0x7EE9070
        public void ReadFunctionName(){} // RVA: 0x7EE9920
        public void ReadScalableImage(){} // RVA: 0x7EE9B90
        public void CustomStartsWith(){} // RVA: 0x7EE9C20
        public void .ctor(){} // RVA: 0xDD1AC0
        public void .cctor(){} // RVA: 0x7EE9D00
    }

    public class StyleTextShadow : ValueType
    {
        public object m_Keyword;
        public object m_Value;

        // ── Methods ──
        public void get_value(){} // RVA: 0x998E90
        public void set_value(){} // RVA: 0x998EE0
        public void get_keyword(){} // RVA: 0x454FE0
        public void set_keyword(){} // RVA: 0x29580
        public void .ctor(){} // RVA: 0x998F30
        public void op_Equality(){} // RVA: 0x7EDBEF0
        public void op_Implicit(){} // RVA: 0x7EDBFF0
        public void Equals(){} // RVA: 0x998F90
        public void GetHashCode(){} // RVA: 0x998FA0
        public void ToString(){} // RVA: 0x998FB0
    }

    public class StyleTransformOrigin : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x999030
        public void set_value(){} // RVA: 0x9979E0
        public void get_keyword(){} // RVA: 0x26A910
        public void set_keyword(){} // RVA: 0xAFF60
        public void .ctor(){} // RVA: 0x8A6880
        public void op_Equality(){} // RVA: 0x7EDC350
        public void op_Implicit(){} // RVA: 0x7EDC440
        public void Equals(){} // RVA: 0x999090
        public void GetHashCode(){} // RVA: 0x9990A0
        public void ToString(){} // RVA: 0x9990D0
    }

    public class StyleTranslate : ValueType
    {
        public object m_Value;
        public object m_Keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x998D10
        public void set_value(){} // RVA: 0x998940
        public void get_keyword(){} // RVA: 0x53FA00
        public void set_keyword(){} // RVA: 0x9E810
        public void .ctor(){} // RVA: 0x998990
        public void op_Equality(){} // RVA: 0x7EDBB70
        public void op_Implicit(){} // RVA: 0x7EDB450
        public void Equals(){} // RVA: 0x998DD0
        public void GetHashCode(){} // RVA: 0x998DE0
        public void ToString(){} // RVA: 0x998E10
    }

    public class StyleValueCollection : Object
    {
        public object m_Values;

        // ── Methods ──
        public void GetStyleLength(){} // RVA: 0x7ED5960
        public void GetStyleFloat(){} // RVA: 0x7ED5A10
        public void GetStyleInt(){} // RVA: 0x7ED5A80
        public void GetStyleColor(){} // RVA: 0x7ED5B00
        public void GetStyleBackground(){} // RVA: 0x7ED5B70
        public void GetStyleBackgroundPosition(){} // RVA: 0x7ED5FD0
        public void GetStyleBackgroundRepeat(){} // RVA: 0x7ED6050
        public void GetStyleFont(){} // RVA: 0x7ED60E0
        public void GetStyleFontDefinition(){} // RVA: 0x7ED6280
        public void TryGetStyleValue(){} // RVA: 0x7ED63F0
        public void SetStyleValue(){} // RVA: 0x7ED65A0
        public void .ctor(){} // RVA: 0x7ED67B0
    }

    public class StyleValueExtensions : Object
    {
        // ── Methods ──
        public void DebugString(){} // RVA: 0x29D76B0
        public void ToLayoutValue(){} // RVA: 0x7EDC6A0
        public void ToLength(){} // RVA: 0x7EDCCC0
        public void ToRotate(){} // RVA: 0x7EDC930
        public void ToScale(){} // RVA: 0x7EDCA50
        public void ToTranslate(){} // RVA: 0x7EDCBB0
        public void CopyFrom(){} // RVA: 0x8945C0
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9F780
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EDE0
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA3140
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA1930
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA0120
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA1E00
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA3FB0
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA2C70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9FC50
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA3AE0
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA1460
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA05F0
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA27A0
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9F2B0
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA0AC0
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA3610
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA4480
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA22D0
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4BA0F90
    }

    public class StyleValuePropertyBag`2 : ContainerPropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B9EA70
    }

}