// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel.Design
// Classes: 11
// Methods: 24

namespace ThirdParty.DotNet.System.ComponentModel.Design
{
    public class CheckoutException : ExternalException
    {
        public object Canceled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
        public void .cctor(){} // RVA: 0x7710220
    }

    public class DesignerOptionService : Object
    {
        // ── Methods ──
        public void PopulateOptionCollection(){} // RVA: 0xB43310
    }

    public class DesigntimeLicenseContextSerializer : Object
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7710E00
    }

    public class IComponentChangeService
    {
        // ── Methods ──
        public void OnComponentChanged(){} // RVA: 0x899870
        public void OnComponentChanging(){} // RVA: 0x8943B0
    }

    public class IDesignerHost
    {
        // ── Methods ──
        public void get_RootComponent(){} // RVA: 0x87C0A0
        public void GetDesigner(){} // RVA: 0x87C540
    }

    public class IDictionaryService
    {
        // ── Methods ──
        public void GetValue(){} // RVA: 0x87C540
        public void SetValue(){} // RVA: 0x8943B0
    }

    public class IExtenderListService
    {
        // ── Methods ──
        public void GetExtenderProviders(){} // RVA: 0x87C0A0
    }

    public class IReferenceService
    {
        // ── Methods ──
        public void GetReference(){} // RVA: 0x87C540
        public void GetName(){} // RVA: 0x87C540
        public void GetReferences(){} // RVA: 0x87C540
    }

    public class ITypeDescriptorFilterService
    {
        // ── Methods ──
        public void FilterAttributes(){} // RVA: 0x87D3C0
        public void FilterEvents(){} // RVA: 0x87D3C0
        public void FilterProperties(){} // RVA: 0x87D3C0
    }

    public class ITypeResolutionService
    {
        // ── Methods ──
        public void GetType(){} // RVA: 0x87C540
        public void GetPathOfAssembly(){} // RVA: 0x87C540
    }

    public class RuntimeLicenseContext : LicenseContext
    {
        public object s_runtimeLicenseContextSwitch;
        public object savedLicenseKeys;

        // ── Methods ──
        public void GetLocalPath(){} // RVA: 0x77102F0
        public void GetSavedLicenseKey(){} // RVA: 0x7710380
        public void CaseInsensitiveManifestResourceStreamLookup(){} // RVA: 0x7710AB0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x7710D10
    }

}