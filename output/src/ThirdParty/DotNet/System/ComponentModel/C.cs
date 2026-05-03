// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 18
// Methods: 125

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class CancelEventArgs : EventArgs
    {
        public bool _cancel; // 0x10

        // ── Methods ──
        public void get_Cancel(){} // RVA: 0x7FFE811C55E0
        public void set_Cancel(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE877BFE70 | overloaded x2
    }

    public class CancelEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83F84C40
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE82886970
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class CategoryAttribute : Attribute
    {
        public System.ComponentModel.CategoryAttribute appearance;
        public System.ComponentModel.CategoryAttribute asynchronous; // 0x8
        public System.ComponentModel.CategoryAttribute behavior; // 0x10
        public System.ComponentModel.CategoryAttribute data; // 0x18
        public System.ComponentModel.CategoryAttribute design; // 0x20
        public System.ComponentModel.CategoryAttribute action; // 0x28
        public System.ComponentModel.CategoryAttribute format; // 0x30
        public System.ComponentModel.CategoryAttribute layout; // 0x38
        public System.ComponentModel.CategoryAttribute mouse; // 0x40
        public System.ComponentModel.CategoryAttribute key; // 0x48
        public System.ComponentModel.CategoryAttribute focus; // 0x50
        public System.ComponentModel.CategoryAttribute windowStyle; // 0x58
        public System.ComponentModel.CategoryAttribute dragDrop; // 0x60
        public System.ComponentModel.CategoryAttribute defAttr; // 0x68
        public bool localized; // 0x10

        // ── Methods ──
        public void get_Action(){} // RVA: 0x7FFE877C0370
        public void get_Appearance(){} // RVA: 0x7FFE877C04D0
        public void get_Asynchronous(){} // RVA: 0x7FFE877C0630
        public void get_Behavior(){} // RVA: 0x7FFE877C0790
        public void get_Data(){} // RVA: 0x7FFE877C08F0
        public void get_Default(){} // RVA: 0x7FFE877C0A50
        public void get_Design(){} // RVA: 0x7FFE877C0BD0
        public void get_DragDrop(){} // RVA: 0x7FFE877C0D30
        public void get_Focus(){} // RVA: 0x7FFE877C0E90
        public void get_Format(){} // RVA: 0x7FFE877C0FF0
        public void get_Key(){} // RVA: 0x7FFE877C1150
        public void get_Layout(){} // RVA: 0x7FFE877C12B0
        public void get_Mouse(){} // RVA: 0x7FFE877C1410
        public void get_WindowStyle(){} // RVA: 0x7FFE877C1570
        public void .ctor(){} // RVA: 0x7FFE84A50F50 | overloaded x2
        public void get_Category(){} // RVA: 0x7FFE877C1760
        public void Equals(){} // RVA: 0x7FFE877C1800
        public void GetHashCode(){} // RVA: 0x7FFE877C1920
        public void GetLocalizedString(){} // RVA: 0x7FFE877C1960
        public void IsDefaultAttribute(){} // RVA: 0x7FFE877C1D00
    }

    public class CharConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7FFE87794CF0
        public void ConvertTo(){} // RVA: 0x7FFE87794DE0
        public void ConvertFrom(){} // RVA: 0x7FFE87794F50
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CollectionChangeEventArgs : EventArgs
    {
        public 0x6652C354 _action; // 0x10
        public object _element; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87795180
        public void get_Action(){} // RVA: 0x7FFE811485C0
        public void get_Element(){} // RVA: 0x7FFE810FE7C0
    }

    public class CollectionChangeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE82886970
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class CollectionConverter : TypeConverter
    {
        // ── Methods ──
        public void ConvertTo(){} // RVA: 0x7FFE877C1EE0
        public void GetProperties(){} // RVA: 0x7FFE813240E0
        public void GetPropertiesSupported(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CompModSwitches : Object
    {
        public System.Diagnostics.BooleanSwitch commonDesignerServices;
        public System.Diagnostics.TraceSwitch eventLog; // 0x8

        // ── Methods ──
        public void get_CommonDesignerServices(){} // RVA: 0x7FFE877C2040
        public void get_EventLog(){} // RVA: 0x7FFE877C2170
    }

    public class ComplexBindingPropertiesAttribute : Attribute
    {
        public string _dataSource; // 0x10
        public string _dataMember; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x3
        public void get_DataSource(){} // RVA: 0x7FFE81116380
        public void get_DataMember(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE87795240
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void .cctor(){} // RVA: 0x7FFE87795340
    }

    public class Component : MarshalByRefObject
    {
        public object EventDisposed;
        public System.ComponentModel.ISite site; // 0x18
        public System.ComponentModel.EventHandlerList events; // 0x20
        public object Disposed; // 0xD
        public TM CanRaiseEvents;
        public string CanRaiseEvents;

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFE877C22A0
        public void get_CanRaiseEvents(){} // RVA: 0x7FFE811E0850
        public void get_CanRaiseEventsInternal(){} // RVA: 0x7FFE870EE950
        public void add_Disposed(){} // RVA: 0x7FFE877C22F0
        public void remove_Disposed(){} // RVA: 0x7FFE877C2380
        public void get_Events(){} // RVA: 0x7FFE877C2410
        public void get_Site(){} // RVA: 0x7FFE810FE7C0
        public void set_Site(){} // RVA: 0x7FFE81161E80
        public void Dispose(){} // RVA: 0x7FFE877C2580 | overloaded x2
        public void get_Container(){} // RVA: 0x7FFE877C2840
        public void GetService(){} // RVA: 0x7FFE877C28A0
        public void get_DesignMode(){} // RVA: 0x7FFE877C2910
        public void ToString(){} // RVA: 0x7FFE877C2970
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE877C2A70
    }

    public class ComponentCollection : ReadOnlyCollectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8778E220
        public void get_Item(){} // RVA: 0x7FFE8778E570 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFE8693ECC0
    }

    public class ComponentConverter : ReferenceConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877C2B20
        public void GetProperties(){} // RVA: 0x7FFE877C2BC0
        public void GetPropertiesSupported(){} // RVA: 0x7FFE811E0850
    }

    public class ComponentEditor : Object
    {
        // ── Methods ──
        public void EditComponent(){} // RVA: 0x7FFE80E32650 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ComponentResourceManager : ResourceManager
    {
        public System.Collections.Hashtable _resourceSets; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87795430 | overloaded x2
        public void get_NeutralResourcesCulture(){} // RVA: 0x7FFE87795490
        public void ApplyResources(){} // RVA: 0x7FFE877955A0 | overloaded x2
        public void FillResources(){} // RVA: 0x7FFE877962B0
    }

    public class Container : Object
    {
        public System.ComponentModel.ISite[] sites; // 0x10

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFE867B7E80
        public void Add(){} // RVA: 0x7FFE877C2C20 | overloaded x2
        public void CreateSite(){} // RVA: 0x7FFE877C30B0
        public void Dispose(){} // RVA: 0x7FFE877C3200 | overloaded x2
        public void GetService(){} // RVA: 0x7FFE877C36D0
        public void get_Components(){} // RVA: 0x7FFE877C37B0
        public void Remove(){} // RVA: 0x7FFE877C3DB0 | overloaded x2
        public void RemoveWithoutUnsiting(){} // RVA: 0x7FFE877C40C0
        public void ValidateName(){} // RVA: 0x7FFE877C40D0
        public void .ctor(){} // RVA: 0x7FFE877C44B0
    }

    public class ContainerFilterService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void FilterComponents(){} // RVA: 0x7FFE82153650
    }

    public class CultureInfoConverter : TypeConverter
    {
        public StandardValuesCollection _values; // 0x10

        // ── Methods ──
        public void get_DefaultCultureString(){} // RVA: 0x7FFE87796860
        public void GetCultureName(){} // RVA: 0x7FFE8270BA30
        public void CanConvertFrom(){} // RVA: 0x7FFE877968A0
        public void CanConvertTo(){} // RVA: 0x7FFE87796990
        public void ConvertFrom(){} // RVA: 0x7FFE87796A80
        public void ConvertTo(){} // RVA: 0x7FFE877974B0
        public void GetStandardValues(){} // RVA: 0x7FFE877979D0
        public void GetStandardValuesExclusive(){} // RVA: 0x7FFE810FB320
        public void GetStandardValuesSupported(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CustomTypeDescriptor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void GetAttributes(){} // RVA: 0x7FFE8779E140
        public void GetClassName(){} // RVA: 0x7FFE8779E1D0
        public void GetComponentName(){} // RVA: 0x7FFE8779E230
        public void GetConverter(){} // RVA: 0x7FFE8779E290
        public void GetDefaultEvent(){} // RVA: 0x7FFE8779E300
        public void GetDefaultProperty(){} // RVA: 0x7FFE8779E350
        public void GetEditor(){} // RVA: 0x7FFE8779E3A0
        public void GetEvents(){} // RVA: 0x7FFE8779E4A0 | overloaded x2
        public void GetProperties(){} // RVA: 0x7FFE8779E5D0 | overloaded x2
        public void GetPropertyOwner(){} // RVA: 0x7FFE8779E670
    }

}