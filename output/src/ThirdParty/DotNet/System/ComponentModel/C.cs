// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 18
// Methods: 125

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class CancelEventArgs
    {
        public bool IsChanged; // 0x10

        // ── Methods ──
        public void get_Cancel(){} // RVA: 0x3A75E0
        public void set_Cancel(){} // RVA: 0x3A75F0
        public void .ctor(){} // RVA: 0x6C7EFC0 | overloaded x2
    }

    public class CancelEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33076C0
        public void Invoke(){} // RVA: 0x439370
        public void BeginInvoke(){} // RVA: 0x1AFE3C0
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class CategoryAttribute
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
        public void get_Action(){} // RVA: 0x6C7F4C0
        public void get_Appearance(){} // RVA: 0x6C7F620
        public void get_Asynchronous(){} // RVA: 0x6C7F780
        public void get_Behavior(){} // RVA: 0x6C7F8E0
        public void get_Data(){} // RVA: 0x6C7FA40
        public void get_Default(){} // RVA: 0x6C7FBA0
        public void get_Design(){} // RVA: 0x6C7FD20
        public void get_DragDrop(){} // RVA: 0x6C7FE80
        public void get_Focus(){} // RVA: 0x6C7FFE0
        public void get_Format(){} // RVA: 0x6C80140
        public void get_Key(){} // RVA: 0x6C802A0
        public void get_Layout(){} // RVA: 0x6C80400
        public void get_Mouse(){} // RVA: 0x6C80560
        public void get_WindowStyle(){} // RVA: 0x6C806C0
        public void .ctor(){} // RVA: 0x3DE09E0 | overloaded x2
        public void get_Category(){} // RVA: 0x6C808B0
        public void Equals(){} // RVA: 0x6C80950
        public void GetHashCode(){} // RVA: 0x6C80A70
        public void GetLocalizedString(){} // RVA: 0x6C80AB0
        public void IsDefaultAttribute(){} // RVA: 0x6C80E50
    }

    public class CharConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x6C53E40
        public void ConvertTo(){} // RVA: 0x6C53F30
        public void ConvertFrom(){} // RVA: 0x6C540A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CollectionChangeEventArgs
    {
        public 0x6584E3B0 <Action>k__BackingField; // 0x10
        public object <Element>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C542D0
        public void get_Action(){} // RVA: 0x32A5C0
        public void get_Element(){} // RVA: 0x2E07C0
    }

    public class CollectionChangeEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
        public void BeginInvoke(){} // RVA: 0x1AFE3C0
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class CollectionConverter
    {
        // ── Methods ──
        public void ConvertTo(){} // RVA: 0x6C81030
        public void GetProperties(){} // RVA: 0x519240
        public void GetPropertiesSupported(){} // RVA: 0x2DD320
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CompModSwitches
    {
        public System.Diagnostics.BooleanSwitch commonDesignerServices;
        public System.Diagnostics.TraceSwitch eventLog; // 0x8

        // ── Methods ──
        public void get_CommonDesignerServices(){} // RVA: 0x6C81190
        public void get_EventLog(){} // RVA: 0x6C812C0
    }

    public class ComplexBindingPropertiesAttribute
    {
        public string <DataSource>k__BackingField; // 0x10
        public string <DataMember>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x3
        public void get_DataSource(){} // RVA: 0x2F8380
        public void get_DataMember(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x6C54390
        public void GetHashCode(){} // RVA: 0x6C4B080
        public void .cctor(){} // RVA: 0x6C54490
    }

    public class Component
    {
        public object EventDisposed;
        public System.ComponentModel.ISite site; // 0x18
        public System.ComponentModel.EventHandlerList events; // 0x20

        // ── Methods ──
        public void Finalize(){} // RVA: 0x6C813F0
        public void get_CanRaiseEvents(){} // RVA: 0x3C2850
        public void get_CanRaiseEventsInternal(){} // RVA: 0x65AFAC0
        public void add_Disposed(){} // RVA: 0x6C81440
        public void remove_Disposed(){} // RVA: 0x6C814D0
        public void get_Events(){} // RVA: 0x6C81560
        public void get_Site(){} // RVA: 0x2E07C0
        public void set_Site(){} // RVA: 0x343E80
        public void Dispose(){} // RVA: 0x6C816D0 | overloaded x2
        public void get_Container(){} // RVA: 0x6C81990
        public void GetService(){} // RVA: 0x6C819F0
        public void get_DesignMode(){} // RVA: 0x6C81A60
        public void ToString(){} // RVA: 0x6C81AC0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6C81BC0
    }

    public class ComponentCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C4D370
        public void get_Item(){} // RVA: 0x6C4D6C0 | overloaded x2
        public void CopyTo(){} // RVA: 0x5DFDE80
    }

    public class ComponentConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C81C70
        public void GetProperties(){} // RVA: 0x6C81D10
        public void GetPropertiesSupported(){} // RVA: 0x3C2850
    }

    public class ComponentEditor
    {
        // ── Methods ──
        public void EditComponent(){} // RVA: 0x11120 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ComponentResourceManager
    {
        public System.Collections.Hashtable _resourceSets; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C54580 | overloaded x2
        public void get_NeutralResourcesCulture(){} // RVA: 0x6C545E0
        public void ApplyResources(){} // RVA: 0x6C546F0 | overloaded x2
        public void FillResources(){} // RVA: 0x6C55400
    }

    public class Container
    {
        public System.ComponentModel.ISite[] sites; // 0x10

        // ── Methods ──
        public void Finalize(){} // RVA: 0x5C76FE0
        public void Add(){} // RVA: 0x6C81D70 | overloaded x2
        public void CreateSite(){} // RVA: 0x6C82200
        public void Dispose(){} // RVA: 0x6C82350 | overloaded x2
        public void GetService(){} // RVA: 0x6C82820
        public void get_Components(){} // RVA: 0x6C82900
        public void Remove(){} // RVA: 0x6C82F00 | overloaded x2
        public void RemoveWithoutUnsiting(){} // RVA: 0x6C83210
        public void ValidateName(){} // RVA: 0x6C83220
        public void .ctor(){} // RVA: 0x6C83600
    }

    public class ContainerFilterService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void FilterComponents(){} // RVA: 0x13DCE00
    }

    public class CultureInfoConverter
    {
        public StandardValuesCollection _values; // 0x10

        // ── Methods ──
        public void get_DefaultCultureString(){} // RVA: 0x6C559B0
        public void GetCultureName(){} // RVA: 0x197F500
        public void CanConvertFrom(){} // RVA: 0x6C559F0
        public void CanConvertTo(){} // RVA: 0x6C55AE0
        public void ConvertFrom(){} // RVA: 0x6C55BD0
        public void ConvertTo(){} // RVA: 0x6C56600
        public void GetStandardValues(){} // RVA: 0x6C56B20
        public void GetStandardValuesExclusive(){} // RVA: 0x2DD320
        public void GetStandardValuesSupported(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CustomTypeDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void GetAttributes(){} // RVA: 0x6C5D290
        public void GetClassName(){} // RVA: 0x6C5D320
        public void GetComponentName(){} // RVA: 0x6C5D380
        public void GetConverter(){} // RVA: 0x6C5D3E0
        public void GetDefaultEvent(){} // RVA: 0x6C5D450
        public void GetDefaultProperty(){} // RVA: 0x6C5D4A0
        public void GetEditor(){} // RVA: 0x6C5D4F0
        public void GetEvents(){} // RVA: 0x6C5D5F0 | overloaded x2
        public void GetProperties(){} // RVA: 0x6C5D720 | overloaded x2
        public void GetPropertyOwner(){} // RVA: 0x6C5D7C0
    }

}