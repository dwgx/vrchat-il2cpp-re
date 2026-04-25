// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel.Design
// Classes: 12
// Methods: 26

namespace ThirdParty.DotNet.System.ComponentModel.Design
{
    public class CheckoutException : ExternalException
    {
        public System.ComponentModel.Design.CheckoutException Canceled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAC9449E70
    }

    public class DesignerOptionService : Object
    {
        // ── Methods ──
        public void PopulateOptionCollection(){} // RVA: 0x7FFAC2F21310
    }

    public class DesigntimeLicenseContextSerializer : Object
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7FFAC944AAA0
    }

    public class IComponentChangeService
    {
        // ── Methods ──
        public void OnComponentChanged(){} // RVA: 0x7FFAC2C7B8C0
        public void OnComponentChanging(){} // RVA: 0x7FFAC2C79B30
    }

    public class IDesigner
    {
    }

    public class IDesignerHost
    {
        public object RootComponent;

        // ── Methods ──
        public void get_RootComponent(){} // RVA: 0x7FFAC2C58E90
        public void GetDesigner(){} // RVA: 0x7FFAC2C58F40
    }

    public class IDictionaryService
    {
        // ── Methods ──
        public void GetValue(){} // RVA: 0x7FFAC2C58F40
        public void SetValue(){} // RVA: 0x7FFAC2C79B30
    }

    public class IExtenderListService
    {
        // ── Methods ──
        public void GetExtenderProviders(){} // RVA: 0x7FFAC2C58E90
    }

    public class IReferenceService
    {
        // ── Methods ──
        public void GetReference(){} // RVA: 0x7FFAC2C58F40
        public void GetName(){} // RVA: 0x7FFAC2C58F40
        public void GetReferences(){} // RVA: 0x7FFAC2C58F40
    }

    public class ITypeDescriptorFilterService
    {
        // ── Methods ──
        public void FilterAttributes(){} // RVA: 0x7FFAC2C5D200
        public void FilterEvents(){} // RVA: 0x7FFAC2C5D200
        public void FilterProperties(){} // RVA: 0x7FFAC2C5D200
    }

    public class ITypeResolutionService
    {
        // ── Methods ──
        public void GetType(){} // RVA: 0x7FFAC2C58F40
        public void GetPathOfAssembly(){} // RVA: 0x7FFAC2C58F40
    }

    public class RuntimeLicenseContext : LicenseContext
    {
        public System.Diagnostics.TraceSwitch s_runtimeLicenseContextSwitch;
        public System.Collections.Hashtable savedLicenseKeys; // 0x10

        // ── Methods ──
        public void GetLocalPath(){} // RVA: 0x7FFAC9449F40
        public void GetSavedLicenseKey(){} // RVA: 0x7FFAC944A030
        public void CaseInsensitiveManifestResourceStreamLookup(){} // RVA: 0x7FFAC944A760
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC944A9B0
    }

}