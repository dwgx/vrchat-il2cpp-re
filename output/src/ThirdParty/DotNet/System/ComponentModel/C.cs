// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 18
// Methods: 110

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class CancelEventArgs : EventArgs
    {
        public object _cancel;

        // ── Methods ──
        public void get_Cancel(){} // RVA: 0xC120A0
        public void set_Cancel(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0x76DE390
    }

    public class CancelEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DB94B0
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x23E7ED0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class CategoryAttribute : Attribute
    {
        public object appearance;
        public object asynchronous;
        public object behavior;
        public object data;
        public object design;
        public object action;
        public object format;
        public object layout;
        public object mouse;
        public object key;
        public object focus;
        public object windowStyle;
        public object dragDrop;
        public object defAttr;
        public object localized;
        public object categoryValue;

        // ── Methods ──
        public void get_Action(){} // RVA: 0x76DE890
        public void get_Appearance(){} // RVA: 0x76DE9F0
        public void get_Asynchronous(){} // RVA: 0x76DEB50
        public void get_Behavior(){} // RVA: 0x76DECB0
        public void get_Data(){} // RVA: 0x76DEE10
        public void get_Default(){} // RVA: 0x76DEF70
        public void get_Design(){} // RVA: 0x76DF0F0
        public void get_DragDrop(){} // RVA: 0x76DF250
        public void get_Focus(){} // RVA: 0x76DF3B0
        public void get_Format(){} // RVA: 0x76DF510
        public void get_Key(){} // RVA: 0x76DF670
        public void get_Layout(){} // RVA: 0x76DF7D0
        public void get_Mouse(){} // RVA: 0x76DF930
        public void get_WindowStyle(){} // RVA: 0x76DFA90
        public void .ctor(){} // RVA: 0x484EBC0
        public void get_Category(){} // RVA: 0x76DFC80
        public void Equals(){} // RVA: 0x76DFD20
        public void GetHashCode(){} // RVA: 0x76DFE40
        public void GetLocalizedString(){} // RVA: 0x76DFE80
        public void IsDefaultAttribute(){} // RVA: 0x76E0220
    }

    public class CharConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x76B2D50
        public void ConvertTo(){} // RVA: 0x76B4120
        public void ConvertFrom(){} // RVA: 0x76B4240
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CollectionChangeEventArgs : EventArgs
    {
        public object _action;
        public object _element;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76B4440
        public void get_Action(){} // RVA: 0xB8F8F0
        public void get_Element(){} // RVA: 0xB465B0
    }

    public class CollectionChangeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x23E7ED0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class CollectionConverter : TypeConverter
    {
        // ── Methods ──
        public void ConvertTo(){} // RVA: 0x76E0400
        public void GetProperties(){} // RVA: 0xDAC980
        public void GetPropertiesSupported(){} // RVA: 0xB43320
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CompModSwitches : Object
    {
        public object commonDesignerServices;
        public object eventLog;

        // ── Methods ──
        public void get_CommonDesignerServices(){} // RVA: 0x76E0570
        public void get_EventLog(){} // RVA: 0x76E06A0
    }

    public class ComplexBindingPropertiesAttribute : Attribute
    {
        public object _dataSource;
        public object _dataMember;
        public object Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_DataSource(){} // RVA: 0xB5DBF0
        public void get_DataMember(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0x76B4500
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void .cctor(){} // RVA: 0x76B4600
    }

    public class Component : MarshalByRefObject
    {
        public object EventDisposed;
        public object site;
        public object events;

        // ── Methods ──
        public void Finalize(){} // RVA: 0x76E07D0
        public void get_CanRaiseEvents(){} // RVA: 0xC2E4C0
        public void get_CanRaiseEventsInternal(){} // RVA: 0x1D7BA30
        public void add_Disposed(){} // RVA: 0x76E0820
        public void remove_Disposed(){} // RVA: 0x76E08B0
        public void get_Events(){} // RVA: 0x76E0940
        public void get_Site(){} // RVA: 0xB465B0
        public void set_Site(){} // RVA: 0xBA9BA0
        public void Dispose(){} // RVA: 0x76E0AB0
        public void get_Container(){} // RVA: 0x76E0D40
        public void GetService(){} // RVA: 0x76E0DA0
        public void get_DesignMode(){} // RVA: 0x76E0E10
        public void ToString(){} // RVA: 0x76E0E70
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x76E0F70
    }

    public class ComponentCollection : ReadOnlyCollectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76AE060
        public void get_Item(){} // RVA: 0x76AE3B0
        public void CopyTo(){} // RVA: 0x6877AD0
    }

    public class ComponentConverter : ReferenceConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76E1020
        public void GetProperties(){} // RVA: 0x76E10C0
        public void GetPropertiesSupported(){} // RVA: 0xC2E4C0
    }

    public class ComponentEditor : Object
    {
        // ── Methods ──
        public void EditComponent(){} // RVA: 0x87D3C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ComponentResourceManager : ResourceManager
    {
        public object _resourceSets;
        public object _neutralResourcesCulture;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76B46F0
        public void get_NeutralResourcesCulture(){} // RVA: 0x76B4750
        public void ApplyResources(){} // RVA: 0x76B4860
        public void FillResources(){} // RVA: 0x76B5580
    }

    public class Container : Object
    {
        public object sites;
        public object siteCount;
        public object components;
        public object filter;
        public object checkedFilter;
        public object syncObj;

        // ── Methods ──
        public void Finalize(){} // RVA: 0x66EF570
        public void Add(){} // RVA: 0x76E1120
        public void CreateSite(){} // RVA: 0x76E1580
        public void Dispose(){} // RVA: 0x76E16D0
        public void GetService(){} // RVA: 0x76E1B60
        public void get_Components(){} // RVA: 0x76E1C10
        public void Remove(){} // RVA: 0x76E2180
        public void RemoveWithoutUnsiting(){} // RVA: 0x76E2450
        public void ValidateName(){} // RVA: 0x76E2460
        public void .ctor(){} // RVA: 0x76E2850
    }

    public class ContainerFilterService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void FilterComponents(){} // RVA: 0x1CB3B00
    }

    public class CultureInfoConverter : TypeConverter
    {
        public object _values;
        public object DefaultInvariantCultureString;

        // ── Methods ──
        public void get_DefaultCultureString(){} // RVA: 0x76B5B00
        public void GetCultureName(){} // RVA: 0x22481B0
        public void CanConvertFrom(){} // RVA: 0x76B5B40
        public void CanConvertTo(){} // RVA: 0x76B5C40
        public void ConvertFrom(){} // RVA: 0x76B5D40
        public void ConvertTo(){} // RVA: 0x76B6740
        public void GetStandardValues(){} // RVA: 0x76B6CA0
        public void GetStandardValuesExclusive(){} // RVA: 0xB43320
        public void GetStandardValuesSupported(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CustomTypeDescriptor : Object
    {
        public object _parent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetAttributes(){} // RVA: 0x76BD410
        public void GetClassName(){} // RVA: 0x76BD4A0
        public void GetComponentName(){} // RVA: 0x76BD500
        public void GetConverter(){} // RVA: 0x76BD560
        public void GetDefaultEvent(){} // RVA: 0x76BD5D0
        public void GetDefaultProperty(){} // RVA: 0x76BD620
        public void GetEditor(){} // RVA: 0x76BD670
        public void GetEvents(){} // RVA: 0x76BD770
        public void GetProperties(){} // RVA: 0x76BD8A0
        public void GetPropertyOwner(){} // RVA: 0x76BD940
    }

}