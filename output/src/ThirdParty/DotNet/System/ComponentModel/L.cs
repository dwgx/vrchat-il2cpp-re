// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 14
// Methods: 108

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class LicFileLicenseProvider : LicenseProvider
    {
        // ── Methods ──
        public void IsKeyValid(){} // RVA: 0x7FFAC93FEFA0
        public void GetKey(){} // RVA: 0x7FFAC93FEFF0
        public void GetLicense(){} // RVA: 0x7FFAC93FF110
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class License : Object
    {
        public object LicenseKey;

        // ── Methods ──
        public void get_LicenseKey(){} // RVA: 0x7FFAC2C58E90
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class LicenseContext : Object
    {
        public object UsageMode;

        // ── Methods ──
        public void get_UsageMode(){} // RVA: 0x7FFAC34F9180
        public void GetSavedLicenseKey(){} // RVA: 0x7FFAC34F9180
        public void GetService(){} // RVA: 0x7FFAC34F9180
        public void SetSavedLicenseKey(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class LicenseException : SystemException
    {
        public System.Type LicensedType; // 0x90
        public object instance; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94203E0 | overloaded x5
        public void get_LicensedType(){} // RVA: 0x7FFAC32EF640
        public void GetObjectData(){} // RVA: 0x7FFAC9420710
    }

    public class LicenseManager : Object
    {
        public object CurrentContext;
        public System.ComponentModel.LicenseContext UsageMode; // 0x8
        public object s_contextLockHolder; // 0x10
        public System.Collections.Hashtable s_providers; // 0x18
        public System.Collections.Hashtable s_providerInstances; // 0x20
        public object s_internalSyncObject; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_CurrentContext(){} // RVA: 0x7FFAC93FF630
        public void set_CurrentContext(){} // RVA: 0x7FFAC93FF8E0
        public void get_UsageMode(){} // RVA: 0x7FFAC93FFB50
        public void CacheProvider(){} // RVA: 0x7FFAC93FFC10
        public void CreateWithContext(){} // RVA: 0x7FFAC93FFFA0 | overloaded x2
        public void GetCachedNoLicenseProvider(){} // RVA: 0x7FFAC9400370
        public void GetCachedProvider(){} // RVA: 0x7FFAC9400430
        public void GetCachedProviderInstance(){} // RVA: 0x7FFAC9400500
        public void IsLicensed(){} // RVA: 0x7FFAC94005D0
        public void IsValid(){} // RVA: 0x7FFAC94007B0 | overloaded x2
        public void LockContext(){} // RVA: 0x7FFAC9400830
        public void UnlockContext(){} // RVA: 0x7FFAC9400A90
        public void ValidateInternal(){} // RVA: 0x7FFAC9400D00
        public void ValidateInternalRecursive(){} // RVA: 0x7FFAC9400DB0
        public void Validate(){} // RVA: 0x7FFAC94015C0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC94016E0
    }

    public class LicenseProvider : Object
    {
        // ── Methods ──
        public void GetLicense(){}
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class LicenseProviderAttribute : Attribute
    {
        public System.ComponentModel.LicenseProviderAttribute LicenseProvider;
        public System.Type TypeId; // 0x10
        public string _licenseProviderName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_LicenseProvider(){} // RVA: 0x7FFAC9401820
        public void get_TypeId(){} // RVA: 0x7FFAC9401920
        public void Equals(){} // RVA: 0x7FFAC94019F0
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void .cctor(){} // RVA: 0x7FFAC9401B10
    }

    public class ListBindableAttribute : Attribute
    {
        public System.ComponentModel.ListBindableAttribute ListBindable;
        public System.ComponentModel.ListBindableAttribute No; // 0x8
        public System.ComponentModel.ListBindableAttribute Default; // 0x10
        public bool _isDefault; // 0x10
        public bool <ListBindable>k__BackingField; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9401C10 | overloaded x2
        public void get_ListBindable(){} // RVA: 0x7FFAC3771DA0
        public void Equals(){} // RVA: 0x7FFAC9401C30
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC9401CB0
        public void .cctor(){} // RVA: 0x7FFAC9401D30
    }

    public class ListChangedEventArgs : EventArgs
    {
        public 0x6B134BE8 ListChangedType; // 0x10
        public int NewIndex; // 0x14
        public int OldIndex; // 0x18
        public System.ComponentModel.PropertyDescriptor PropertyDescriptor; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94020D0 | overloaded x4
        public void get_ListChangedType(){} // RVA: 0x7FFAC2F6E5C0
        public void get_NewIndex(){} // RVA: 0x7FFAC33D5A20
        public void get_OldIndex(){} // RVA: 0x7FFAC3157800
        public void get_PropertyDescriptor(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class ListChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class ListSortDescription : Object
    {
        public System.ComponentModel.PropertyDescriptor PropertyDescriptor; // 0x10
        public 0x6B134CF0 SortDirection; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC488C310
        public void get_PropertyDescriptor(){} // RVA: 0x7FFAC2F3C380
        public void set_PropertyDescriptor(){} // RVA: 0x7FFAC2F22E30
        public void get_SortDirection(){} // RVA: 0x7FFAC3157800
        public void set_SortDirection(){} // RVA: 0x7FFAC392CD10
    }

    public class ListSortDescriptionCollection : Object
    {
        public System.Collections.ArrayList Item; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94021F0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAC94022F0
        public void set_Item(){} // RVA: 0x7FFAC9402390
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC3006850
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC94022F0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC94023E0
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC9402430
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFAC9402480
        public void Contains(){} // RVA: 0x7FFAC94024D0
        public void IndexOf(){} // RVA: 0x7FFAC9402530
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC9402590
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC94025E0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFAC9402630
        public void get_Count(){} // RVA: 0x7FFAC8593680
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC3006850
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
        public void CopyTo(){} // RVA: 0x7FFAC8593960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8364560
    }

    public class LocalizableAttribute : Attribute
    {
        public bool IsLocalizable; // 0x10
        public System.ComponentModel.LocalizableAttribute Yes;
        public System.ComponentModel.LocalizableAttribute No; // 0x8
        public System.ComponentModel.LocalizableAttribute Default; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
        public void get_IsLocalizable(){} // RVA: 0x7FFAC2FEB5E0
        public void Equals(){} // RVA: 0x7FFAC93E7CF0
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93E7DB0
        public void .cctor(){} // RVA: 0x7FFAC93E7E20
    }

    public class LookupBindingPropertiesAttribute : Attribute
    {
        public string DataSource; // 0x10
        public string DisplayMember; // 0x18
        public string ValueMember; // 0x20
        public string LookupMember; // 0x28
        public System.ComponentModel.LookupBindingPropertiesAttribute Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F69A50 | overloaded x2
        public void get_DataSource(){} // RVA: 0x7FFAC2F3C380
        public void get_DisplayMember(){} // RVA: 0x7FFAC2F247C0
        public void get_ValueMember(){} // RVA: 0x7FFAC2F4F0C0
        public void get_LookupMember(){} // RVA: 0x7FFAC2F4F130
        public void Equals(){} // RVA: 0x7FFAC94027D0
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void .cctor(){} // RVA: 0x7FFAC9402960
    }

}