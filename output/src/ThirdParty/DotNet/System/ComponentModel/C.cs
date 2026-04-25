// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 18
// Methods: 125

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class CancelEventArgs : EventArgs
    {
        public bool Cancel; // 0x10

        // ── Methods ──
        public void get_Cancel(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Cancel(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC9417740 | overloaded x2
    }

    public class CancelEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5C4D540
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class CategoryAttribute : Attribute
    {
        public System.ComponentModel.CategoryAttribute Action;
        public System.ComponentModel.CategoryAttribute Appearance; // 0x8
        public System.ComponentModel.CategoryAttribute Asynchronous; // 0x10
        public System.ComponentModel.CategoryAttribute Behavior; // 0x18
        public System.ComponentModel.CategoryAttribute Data; // 0x20
        public System.ComponentModel.CategoryAttribute Default; // 0x28
        public System.ComponentModel.CategoryAttribute Design; // 0x30
        public System.ComponentModel.CategoryAttribute DragDrop; // 0x38
        public System.ComponentModel.CategoryAttribute Focus; // 0x40
        public System.ComponentModel.CategoryAttribute Format; // 0x48
        public System.ComponentModel.CategoryAttribute Key; // 0x50
        public System.ComponentModel.CategoryAttribute Layout; // 0x58
        public System.ComponentModel.CategoryAttribute Mouse; // 0x60
        public System.ComponentModel.CategoryAttribute WindowStyle; // 0x68
        public bool Category; // 0x10
        public string categoryValue; // 0x18

        // ── Methods ──
        public void get_Action(){} // RVA: 0x7FFAC9417C40
        public void get_Appearance(){} // RVA: 0x7FFAC9417DA0
        public void get_Asynchronous(){} // RVA: 0x7FFAC9417F00
        public void get_Behavior(){} // RVA: 0x7FFAC9418060
        public void get_Data(){} // RVA: 0x7FFAC94181C0
        public void get_Default(){} // RVA: 0x7FFAC9418320
        public void get_Design(){} // RVA: 0x7FFAC94184A0
        public void get_DragDrop(){} // RVA: 0x7FFAC9418600
        public void get_Focus(){} // RVA: 0x7FFAC9418760
        public void get_Format(){} // RVA: 0x7FFAC94188C0
        public void get_Key(){} // RVA: 0x7FFAC9418A20
        public void get_Layout(){} // RVA: 0x7FFAC9418B80
        public void get_Mouse(){} // RVA: 0x7FFAC9418CE0
        public void get_WindowStyle(){} // RVA: 0x7FFAC9418E40
        public void .ctor(){} // RVA: 0x7FFAC416C160 | overloaded x2
        public void get_Category(){} // RVA: 0x7FFAC9419030
        public void Equals(){} // RVA: 0x7FFAC94190D0
        public void GetHashCode(){} // RVA: 0x7FFAC94191F0
        public void GetLocalizedString(){} // RVA: 0x7FFAC9419230
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC94195D0
    }

    public class CharConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7FFAC93EC5C0
        public void ConvertTo(){} // RVA: 0x7FFAC93EC6B0
        public void ConvertFrom(){} // RVA: 0x7FFAC93EC820
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CollectionChangeEventArgs : EventArgs
    {
        public 0x6B133430 Action; // 0x10
        public object Element; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93ECA50
        public void get_Action(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Element(){} // RVA: 0x7FFAC2F247C0
    }

    public class CollectionChangeEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class CollectionConverter : TypeConverter
    {
        // ── Methods ──
        public void ConvertTo(){} // RVA: 0x7FFAC94197B0
        public void GetProperties(){} // RVA: 0x7FFAC34F9180
        public void GetPropertiesSupported(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CompModSwitches : Object
    {
        public System.Diagnostics.BooleanSwitch CommonDesignerServices;
        public System.Diagnostics.TraceSwitch EventLog; // 0x8

        // ── Methods ──
        public void get_CommonDesignerServices(){} // RVA: 0x7FFAC9419910
        public void get_EventLog(){} // RVA: 0x7FFAC9419A40
    }

    public class ComplexBindingPropertiesAttribute : Attribute
    {
        public string DataSource; // 0x10
        public string DataMember; // 0x18
        public System.ComponentModel.ComplexBindingPropertiesAttribute Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x3
        public void get_DataSource(){} // RVA: 0x7FFAC2F3C380
        public void get_DataMember(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC93ECB10
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void .cctor(){} // RVA: 0x7FFAC93ECC10
    }

    public class Component : MarshalByRefObject
    {
        public object CanRaiseEvents;
        public System.ComponentModel.ISite CanRaiseEventsInternal; // 0x18
        public System.ComponentModel.EventHandlerList Events; // 0x20

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFAC9419B70
        public void get_CanRaiseEvents(){} // RVA: 0x7FFAC3006850
        public void get_CanRaiseEventsInternal(){} // RVA: 0x7FFAC8D46490
        public void add_Disposed(){} // RVA: 0x7FFAC9419BC0
        public void remove_Disposed(){} // RVA: 0x7FFAC9419C50
        public void get_Events(){} // RVA: 0x7FFAC9419CE0
        public void get_Site(){} // RVA: 0x7FFAC2F247C0
        public void set_Site(){} // RVA: 0x7FFAC2F87E80
        public void Dispose(){} // RVA: 0x7FFAC9419E50 | overloaded x2
        public void get_Container(){} // RVA: 0x7FFAC941A110
        public void GetService(){} // RVA: 0x7FFAC941A170
        public void get_DesignMode(){} // RVA: 0x7FFAC941A1E0
        public void ToString(){} // RVA: 0x7FFAC941A240
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC941A340
    }

    public class ComponentCollection : ReadOnlyCollectionBase
    {
        public object Item;
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93E5AF0
        public void get_Item(){} // RVA: 0x7FFAC93E5E40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAC85954E0
    }

    public class ComponentConverter : ReferenceConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC941A3F0
        public void GetProperties(){} // RVA: 0x7FFAC941A490
        public void GetPropertiesSupported(){} // RVA: 0x7FFAC3006850
    }

    public class ComponentEditor : Object
    {
        // ── Methods ──
        public void EditComponent(){} // RVA: 0x7FFAC2C5D200 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ComponentResourceManager : ResourceManager
    {
        public System.Collections.Hashtable NeutralResourcesCulture; // 0x88
        public System.Globalization.CultureInfo _neutralResourcesCulture; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93ECD00 | overloaded x2
        public void get_NeutralResourcesCulture(){} // RVA: 0x7FFAC93ECD60
        public void ApplyResources(){} // RVA: 0x7FFAC93ECE70 | overloaded x2
        public void FillResources(){} // RVA: 0x7FFAC93EDB80
    }

    public class Container : Object
    {
        public System.ComponentModel.ISite[] Components; // 0x10
        public int siteCount; // 0x18
        public System.ComponentModel.ComponentCollection components; // 0x20
        public System.ComponentModel.ContainerFilterService filter; // 0x28
        public bool checkedFilter; // 0x30
        public object syncObj; // 0x38

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFAC840E570
        public void Add(){} // RVA: 0x7FFAC941A4F0 | overloaded x2
        public void CreateSite(){} // RVA: 0x7FFAC941A980
        public void Dispose(){} // RVA: 0x7FFAC941AAD0 | overloaded x2
        public void GetService(){} // RVA: 0x7FFAC941AFA0
        public void get_Components(){} // RVA: 0x7FFAC941B080
        public void Remove(){} // RVA: 0x7FFAC941B680 | overloaded x2
        public void RemoveWithoutUnsiting(){} // RVA: 0x7FFAC941B990
        public void ValidateName(){} // RVA: 0x7FFAC941B9A0
        public void .ctor(){} // RVA: 0x7FFAC941BD80
    }

    public class ContainerFilterService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void FilterComponents(){} // RVA: 0x7FFAC3E92FB0
    }

    public class CultureInfoConverter : TypeConverter
    {
        public StandardValuesCollection DefaultCultureString; // 0x10
        public string DefaultInvariantCultureString;

        // ── Methods ──
        public void get_DefaultCultureString(){} // RVA: 0x7FFAC93EE130
        public void GetCultureName(){} // RVA: 0x7FFAC4439290
        public void CanConvertFrom(){} // RVA: 0x7FFAC93EE170
        public void CanConvertTo(){} // RVA: 0x7FFAC93EE260
        public void ConvertFrom(){} // RVA: 0x7FFAC93EE350
        public void ConvertTo(){} // RVA: 0x7FFAC93EED80
        public void GetStandardValues(){} // RVA: 0x7FFAC93EF2A0
        public void GetStandardValuesExclusive(){} // RVA: 0x7FFAC2F21320
        public void GetStandardValuesSupported(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CustomTypeDescriptor : Object
    {
        public System.ComponentModel.ICustomTypeDescriptor _parent; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void GetAttributes(){} // RVA: 0x7FFAC93F5A10
        public void GetClassName(){} // RVA: 0x7FFAC93F5AA0
        public void GetComponentName(){} // RVA: 0x7FFAC93F5B00
        public void GetConverter(){} // RVA: 0x7FFAC93F5B60
        public void GetDefaultEvent(){} // RVA: 0x7FFAC93F5BD0
        public void GetDefaultProperty(){} // RVA: 0x7FFAC93F5C20
        public void GetEditor(){} // RVA: 0x7FFAC93F5C70
        public void GetEvents(){} // RVA: 0x7FFAC93F5D70 | overloaded x2
        public void GetProperties(){} // RVA: 0x7FFAC93F5EA0 | overloaded x2
        public void GetPropertyOwner(){} // RVA: 0x7FFAC93F5F40
    }

}