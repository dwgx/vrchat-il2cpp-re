// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 14
// Methods: 93

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class LicFileLicenseProvider : LicenseProvider
    {
        // ── Methods ──
        public void IsKeyValid(){} // RVA: 0x76C63B0
        public void GetKey(){} // RVA: 0x76C6400
        public void GetLicense(){} // RVA: 0x76C6520
        public void .ctor(){} // RVA: 0xB43310
    }

    public class License : Object
    {
        // ── Methods ──
        public void get_LicenseKey(){} // RVA: 0x87C0A0
        public void Dispose(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LicenseContext : Object
    {
        // ── Methods ──
        public void get_UsageMode(){} // RVA: 0xDAC980
        public void GetSavedLicenseKey(){} // RVA: 0xDAC980
        public void GetService(){} // RVA: 0xDAC980
        public void SetSavedLicenseKey(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LicenseException : SystemException
    {
        public object type;
        public object instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76E6DF0
        public void get_LicensedType(){} // RVA: 0x1069350
        public void GetObjectData(){} // RVA: 0x76E70B0
    }

    public class LicenseManager : Object
    {
        public object s_selfLock;
        public object s_context;
        public object s_contextLockHolder;
        public object s_providers;
        public object s_providerInstances;
        public object s_internalSyncObject;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_CurrentContext(){} // RVA: 0x76C6A30
        public void set_CurrentContext(){} // RVA: 0x76C6CB0
        public void get_UsageMode(){} // RVA: 0x76C6EF0
        public void CacheProvider(){} // RVA: 0x76C6FB0
        public void CreateWithContext(){} // RVA: 0x76C7340
        public void GetCachedNoLicenseProvider(){} // RVA: 0x76C76D0
        public void GetCachedProvider(){} // RVA: 0x76C7790
        public void GetCachedProviderInstance(){} // RVA: 0x76C7860
        public void IsLicensed(){} // RVA: 0x76C7930
        public void IsValid(){} // RVA: 0x76C7B10
        public void LockContext(){} // RVA: 0x76C7B90
        public void UnlockContext(){} // RVA: 0x76C7DD0
        public void ValidateInternal(){} // RVA: 0x76C8010
        public void ValidateInternalRecursive(){} // RVA: 0x76C80C0
        public void Validate(){} // RVA: 0x76C8990
        public void .cctor(){} // RVA: 0x76C8AB0
    }

    public class LicenseProvider : Object
    {
        // ── Methods ──
        public void GetLicense(){} // RVA: 0x88E660
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LicenseProviderAttribute : Attribute
    {
        public object Default;
        public object _licenseProviderType;
        public object _licenseProviderName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_LicenseProvider(){} // RVA: 0x76C8BF0
        public void get_TypeId(){} // RVA: 0x76C8CD0
        public void Equals(){} // RVA: 0x76C8D80
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void .cctor(){} // RVA: 0x76C8E90
    }

    public class ListBindableAttribute : Attribute
    {
        public object Yes;
        public object No;
        public object Default;
        public object _isDefault;
        public object _listBindable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76C8F90
        public void get_ListBindable(){} // RVA: 0xDD5C50
        public void Equals(){} // RVA: 0x76C8FB0
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void IsDefaultAttribute(){} // RVA: 0x76C9030
        public void .cctor(){} // RVA: 0x76C90B0
    }

    public class ListChangedEventArgs : EventArgs
    {
        public object _listChangedType;
        public object _newIndex;
        public object _oldIndex;
        public object _propertyDescriptor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76C9450
        public void get_ListChangedType(){} // RVA: 0xB8F8F0
        public void get_NewIndex(){} // RVA: 0x116A650
        public void get_OldIndex(){} // RVA: 0xE62D00
        public void get_PropertyDescriptor(){} // RVA: 0xB700F0
    }

    public class ListChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x23E7ED0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class ListSortDescription : Object
    {
        public object _propertyDescriptor;
        public object _sortDirection;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2615F10
        public void get_PropertyDescriptor(){} // RVA: 0xB5DBF0
        public void set_PropertyDescriptor(){} // RVA: 0xB44D60
        public void get_SortDirection(){} // RVA: 0xE62D00
        public void set_SortDirection(){} // RVA: 0x1033F40
    }

    public class ListSortDescriptionCollection : Object
    {
        public object _sorts;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76C9570
        public void get_Item(){} // RVA: 0x76C9680
        public void set_Item(){} // RVA: 0x76C9720
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xC2E4C0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.IList.get_Item(){} // RVA: 0x76C9680
        public void System.Collections.IList.set_Item(){} // RVA: 0x76C9770
        public void System.Collections.IList.Add(){} // RVA: 0x76C97C0
        public void System.Collections.IList.Clear(){} // RVA: 0x76C9810
        public void Contains(){} // RVA: 0x76C9860
        public void IndexOf(){} // RVA: 0x76C98C0
        public void System.Collections.IList.Insert(){} // RVA: 0x76C9920
        public void System.Collections.IList.Remove(){} // RVA: 0x76C9970
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x76C99C0
        public void get_Count(){} // RVA: 0x6875CA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xC2E4C0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2303260
        public void CopyTo(){} // RVA: 0x6875F50
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x66459E0
    }

    public class LocalizableAttribute : Attribute
    {
        public object _isLocalizable;
        public object Yes;
        public object No;
        public object Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
        public void get_IsLocalizable(){} // RVA: 0xC120A0
        public void Equals(){} // RVA: 0x76AFFD0
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void IsDefaultAttribute(){} // RVA: 0x76B0090
        public void .cctor(){} // RVA: 0x76B0100
    }

    public class LookupBindingPropertiesAttribute : Attribute
    {
        public object _dataSource;
        public object _displayMember;
        public object _valueMember;
        public object _lookupMember;
        public object Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB8AE10
        public void get_DataSource(){} // RVA: 0xB5DBF0
        public void get_DisplayMember(){} // RVA: 0xB465B0
        public void get_ValueMember(){} // RVA: 0xB700F0
        public void get_LookupMember(){} // RVA: 0xB70160
        public void Equals(){} // RVA: 0x76C9B60
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void .cctor(){} // RVA: 0x76C9CF0
    }

}