// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 14
// Methods: 108

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class LicFileLicenseProvider
    {
        // ── Methods ──
        public void IsKeyValid(){} // RVA: 0x7FFAF9716820
        public void GetKey(){} // RVA: 0x7FFAF9716870
        public void GetLicense(){} // RVA: 0x7FFAF9716990
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class License
    {
        // ── Methods ──
        public void get_LicenseKey(){} // RVA: 0x7FFAF2ABCD60
        public void Dispose(){} // RVA: 0x7FFAF2AD4A50
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class LicenseContext
    {
        // ── Methods ──
        public void get_UsageMode(){} // RVA: 0x7FFAF2FC9240
        public void GetSavedLicenseKey(){} // RVA: 0x7FFAF2FC9240
        public void GetService(){} // RVA: 0x7FFAF2FC9240
        public void SetSavedLicenseKey(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class LicenseException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9737C60 | overloaded x5
        public void get_LicensedType(){} // RVA: 0x7FFAF3246DE0
        public void GetObjectData(){} // RVA: 0x7FFAF9737F90
    }

    public class LicenseManager
    {
        public object LicenseProvider;
        public object TypeId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_CurrentContext(){} // RVA: 0x7FFAF9716EB0
        public void set_CurrentContext(){} // RVA: 0x7FFAF9717160
        public void get_UsageMode(){} // RVA: 0x7FFAF97173D0
        public void CacheProvider(){} // RVA: 0x7FFAF9717490
        public void CreateWithContext(){} // RVA: 0x7FFAF9717820 | overloaded x2
        public void GetCachedNoLicenseProvider(){} // RVA: 0x7FFAF9717BF0
        public void GetCachedProvider(){} // RVA: 0x7FFAF9717CB0
        public void GetCachedProviderInstance(){} // RVA: 0x7FFAF9717D80
        public void IsLicensed(){} // RVA: 0x7FFAF9717E50
        public void IsValid(){} // RVA: 0x7FFAF9718030 | overloaded x2
        public void LockContext(){} // RVA: 0x7FFAF97180B0
        public void UnlockContext(){} // RVA: 0x7FFAF9718310
        public void ValidateInternal(){} // RVA: 0x7FFAF9718580
        public void ValidateInternalRecursive(){} // RVA: 0x7FFAF9718630
        public void Validate(){} // RVA: 0x7FFAF9718E40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF9718F60
    }

    public class LicenseProvider
    {
        // ── Methods ──
        public void GetLicense(){}
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class LicenseProviderAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x3
        public void get_LicenseProvider(){} // RVA: 0x7FFAF97190A0
        public void get_TypeId(){} // RVA: 0x7FFAF97191A0
        public void Equals(){} // RVA: 0x7FFAF9719270
        public void GetHashCode(){} // RVA: 0x7FFAF96FB080
        public void .cctor(){} // RVA: 0x7FFAF9719390
    }

    public class ListBindableAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9719490 | overloaded x2
        public void get_ListBindable(){} // RVA: 0x7FFAF2FF3460
        public void Equals(){} // RVA: 0x7FFAF97194B0
        public void GetHashCode(){} // RVA: 0x7FFAF96FB080
        public void IsDefaultAttribute(){} // RVA: 0x7FFAF9719530
        public void .cctor(){} // RVA: 0x7FFAF97195B0
    }

    public class ListChangedEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9719950 | overloaded x4
        public void get_ListChangedType(){} // RVA: 0x7FFAF2DDA5C0
        public void get_NewIndex(){} // RVA: 0x7FFAF335BED0
        public void get_OldIndex(){} // RVA: 0x7FFAF306ED50
        public void get_PropertyDescriptor(){} // RVA: 0x7FFAF2DBB0C0
    }

    public class ListChangedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45AE240
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
        public void BeginInvoke(){} // RVA: 0x7FFAF45AE3C0
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

    public class ListSortDescription
    {
        public object Item;
        public object System.Collections.IList.IsFixedSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4816A50
        public void get_PropertyDescriptor(){} // RVA: 0x7FFAF2DA8380
        public void set_PropertyDescriptor(){} // RVA: 0x7FFAF2D8EE30
        public void get_SortDirection(){} // RVA: 0x7FFAF306ED50
        public void set_SortDirection(){} // RVA: 0x7FFAF30E74E0
    }

    public class ListSortDescriptionCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9719A70 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAF9719B70
        public void set_Item(){} // RVA: 0x7FFAF9719C10
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAF2E72850
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAF2E72850
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAF9719B70
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAF9719C60
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAF9719CB0
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFAF9719D00
        public void Contains(){} // RVA: 0x7FFAF9719D50
        public void IndexOf(){} // RVA: 0x7FFAF9719DB0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAF9719E10
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAF9719E60
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAF9719EB0
        public void get_Count(){} // RVA: 0x7FFAF88AC050
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2E72850
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF44EF520
        public void CopyTo(){} // RVA: 0x7FFAF88AC300
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF867D010
    }

    public class LocalizableAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E575F0
        public void get_IsLocalizable(){} // RVA: 0x7FFAF2E575E0
        public void Equals(){} // RVA: 0x7FFAF96FF570
        public void GetHashCode(){} // RVA: 0x7FFAF96FB080
        public void IsDefaultAttribute(){} // RVA: 0x7FFAF96FF630
        public void .cctor(){} // RVA: 0x7FFAF96FF6A0
    }

    public class LookupBindingPropertiesAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DD5A50 | overloaded x2
        public void get_DataSource(){} // RVA: 0x7FFAF2DA8380
        public void get_DisplayMember(){} // RVA: 0x7FFAF2D907C0
        public void get_ValueMember(){} // RVA: 0x7FFAF2DBB0C0
        public void get_LookupMember(){} // RVA: 0x7FFAF2DBB130
        public void Equals(){} // RVA: 0x7FFAF971A050
        public void GetHashCode(){} // RVA: 0x7FFAF96FB080
        public void .cctor(){} // RVA: 0x7FFAF971A1E0
    }

}