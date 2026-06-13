// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 14
// Methods: 108

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class LicFileLicenseProvider
    {
        // ── Methods ──
        public void IsKeyValid(){} // RVA: 0x6C66820
        public void GetKey(){} // RVA: 0x6C66870
        public void GetLicense(){} // RVA: 0x6C66990
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class License
    {
        // ── Methods ──
        public void get_LicenseKey(){} // RVA: 0xCD60
        public void Dispose(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LicenseContext
    {
        // ── Methods ──
        public void get_UsageMode(){} // RVA: 0x519240
        public void GetSavedLicenseKey(){} // RVA: 0x519240
        public void GetService(){} // RVA: 0x519240
        public void SetSavedLicenseKey(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LicenseException
    {
        public System.Type type; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C87C60 | overloaded x5
        public void get_LicensedType(){} // RVA: 0x796DE0
        public void GetObjectData(){} // RVA: 0x6C87F90
    }

    public class LicenseManager
    {
        public object LicenseProvider;
        public System.ComponentModel.LicenseContext TypeId; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_CurrentContext(){} // RVA: 0x6C66EB0
        public void set_CurrentContext(){} // RVA: 0x6C67160
        public void get_UsageMode(){} // RVA: 0x6C673D0
        public void CacheProvider(){} // RVA: 0x6C67490
        public void CreateWithContext(){} // RVA: 0x6C67820 | overloaded x2
        public void GetCachedNoLicenseProvider(){} // RVA: 0x6C67BF0
        public void GetCachedProvider(){} // RVA: 0x6C67CB0
        public void GetCachedProviderInstance(){} // RVA: 0x6C67D80
        public void IsLicensed(){} // RVA: 0x6C67E50
        public void IsValid(){} // RVA: 0x6C68030 | overloaded x2
        public void LockContext(){} // RVA: 0x6C680B0
        public void UnlockContext(){} // RVA: 0x6C68310
        public void ValidateInternal(){} // RVA: 0x6C68580
        public void ValidateInternalRecursive(){} // RVA: 0x6C68630
        public void Validate(){} // RVA: 0x6C68E40 | overloaded x2
        public void .cctor(){} // RVA: 0x6C68F60
    }

    public class LicenseProvider
    {
        // ── Methods ──
        public void GetLicense(){}
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LicenseProviderAttribute
    {
        public System.ComponentModel.LicenseProviderAttribute Default;
        public System.Type _licenseProviderType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_LicenseProvider(){} // RVA: 0x6C690A0
        public void get_TypeId(){} // RVA: 0x6C691A0
        public void Equals(){} // RVA: 0x6C69270
        public void GetHashCode(){} // RVA: 0x6C4B080
        public void .cctor(){} // RVA: 0x6C69390
    }

    public class ListBindableAttribute
    {
        public System.ComponentModel.ListBindableAttribute Yes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C69490 | overloaded x2
        public void get_ListBindable(){} // RVA: 0x543460
        public void Equals(){} // RVA: 0x6C694B0
        public void GetHashCode(){} // RVA: 0x6C4B080
        public void IsDefaultAttribute(){} // RVA: 0x6C69530
        public void .cctor(){} // RVA: 0x6C695B0
    }

    public class ListChangedEventArgs
    {
        public 0x6584FB68 <ListChangedType>k__BackingField; // 0x10
        public int <NewIndex>k__BackingField; // 0x14
        public int <OldIndex>k__BackingField; // 0x18
        public System.ComponentModel.PropertyDescriptor <PropertyDescriptor>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C69950 | overloaded x4
        public void get_ListChangedType(){} // RVA: 0x32A5C0
        public void get_NewIndex(){} // RVA: 0x8ABED0
        public void get_OldIndex(){} // RVA: 0x5BED50
        public void get_PropertyDescriptor(){} // RVA: 0x30B0C0
    }

    public class ListChangedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
        public void BeginInvoke(){} // RVA: 0x1AFE3C0
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class ListSortDescription
    {
        public System.ComponentModel.PropertyDescriptor Item; // 0x10
        public 0x6584FC70 System.Collections.IList.IsFixedSize; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D66A50
        public void get_PropertyDescriptor(){} // RVA: 0x2F8380
        public void set_PropertyDescriptor(){} // RVA: 0x2DEE30
        public void get_SortDirection(){} // RVA: 0x5BED50
        public void set_SortDirection(){} // RVA: 0x6374E0
    }

    public class ListSortDescriptionCollection
    {
        public System.Collections.ArrayList _sorts; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C69A70 | overloaded x2
        public void get_Item(){} // RVA: 0x6C69B70
        public void set_Item(){} // RVA: 0x6C69C10
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x3C2850
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x3C2850
        public void System.Collections.IList.get_Item(){} // RVA: 0x6C69B70
        public void System.Collections.IList.set_Item(){} // RVA: 0x6C69C60
        public void System.Collections.IList.Add(){} // RVA: 0x6C69CB0
        public void System.Collections.IList.Clear(){} // RVA: 0x6C69D00
        public void Contains(){} // RVA: 0x6C69D50
        public void IndexOf(){} // RVA: 0x6C69DB0
        public void System.Collections.IList.Insert(){} // RVA: 0x6C69E10
        public void System.Collections.IList.Remove(){} // RVA: 0x6C69E60
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x6C69EB0
        public void get_Count(){} // RVA: 0x5DFC050
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x3C2850
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x1A3F520
        public void CopyTo(){} // RVA: 0x5DFC300
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5BCD010
    }

    public class LocalizableAttribute
    {
        public bool <IsLocalizable>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A75F0
        public void get_IsLocalizable(){} // RVA: 0x3A75E0
        public void Equals(){} // RVA: 0x6C4F570
        public void GetHashCode(){} // RVA: 0x6C4B080
        public void IsDefaultAttribute(){} // RVA: 0x6C4F630
        public void .cctor(){} // RVA: 0x6C4F6A0
    }

    public class LookupBindingPropertiesAttribute
    {
        public string <DataSource>k__BackingField; // 0x10
        public string <DisplayMember>k__BackingField; // 0x18
        public string <ValueMember>k__BackingField; // 0x20
        public string <LookupMember>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x325A50 | overloaded x2
        public void get_DataSource(){} // RVA: 0x2F8380
        public void get_DisplayMember(){} // RVA: 0x2E07C0
        public void get_ValueMember(){} // RVA: 0x30B0C0
        public void get_LookupMember(){} // RVA: 0x30B130
        public void Equals(){} // RVA: 0x6C6A050
        public void GetHashCode(){} // RVA: 0x6C4B080
        public void .cctor(){} // RVA: 0x6C6A1E0
    }

}