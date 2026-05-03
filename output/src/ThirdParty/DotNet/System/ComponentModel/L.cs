// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 14
// Methods: 108

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class LicFileLicenseProvider : LicenseProvider
    {
        // ── Methods ──
        public void IsKeyValid(){} // RVA: 0x7FFE877A76D0
        public void GetKey(){} // RVA: 0x7FFE877A7720
        public void GetLicense(){} // RVA: 0x7FFE877A7840
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class License : Object
    {
        // ── Methods ──
        public void get_LicenseKey(){} // RVA: 0x7FFE80E2E2E0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class LicenseContext : Object
    {
        // ── Methods ──
        public void get_UsageMode(){} // RVA: 0x7FFE813240E0
        public void GetSavedLicenseKey(){} // RVA: 0x7FFE813240E0
        public void GetService(){} // RVA: 0x7FFE813240E0
        public void SetSavedLicenseKey(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class LicenseException : SystemException
    {
        public System.Type type; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877C8B10 | overloaded x5
        public void get_LicensedType(){} // RVA: 0x7FFE8154EB60
        public void GetObjectData(){} // RVA: 0x7FFE877C8E40
    }

    public class LicenseManager : Object
    {
        public object s_selfLock;
        public System.ComponentModel.LicenseContext s_context; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_CurrentContext(){} // RVA: 0x7FFE877A7D60
        public void set_CurrentContext(){} // RVA: 0x7FFE877A8010
        public void get_UsageMode(){} // RVA: 0x7FFE877A8280
        public void CacheProvider(){} // RVA: 0x7FFE877A8340
        public void CreateWithContext(){} // RVA: 0x7FFE877A86D0 | overloaded x2
        public void GetCachedNoLicenseProvider(){} // RVA: 0x7FFE877A8AA0
        public void GetCachedProvider(){} // RVA: 0x7FFE877A8B60
        public void GetCachedProviderInstance(){} // RVA: 0x7FFE877A8C30
        public void IsLicensed(){} // RVA: 0x7FFE877A8D00
        public void IsValid(){} // RVA: 0x7FFE877A8EE0 | overloaded x2
        public void LockContext(){} // RVA: 0x7FFE877A8F60
        public void UnlockContext(){} // RVA: 0x7FFE877A91C0
        public void ValidateInternal(){} // RVA: 0x7FFE877A9430
        public void ValidateInternalRecursive(){} // RVA: 0x7FFE877A94E0
        public void Validate(){} // RVA: 0x7FFE877A9CF0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE877A9E10
    }

    public class LicenseProvider : Object
    {
        // ── Methods ──
        public void GetLicense(){}
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class LicenseProviderAttribute : Attribute
    {
        public System.ComponentModel.LicenseProviderAttribute Default;
        public System.Type _licenseProviderType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_LicenseProvider(){} // RVA: 0x7FFE877A9F50
        public void get_TypeId(){} // RVA: 0x7FFE877AA050
        public void Equals(){} // RVA: 0x7FFE877AA120
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void .cctor(){} // RVA: 0x7FFE877AA240
    }

    public class ListBindableAttribute : Attribute
    {
        public System.ComponentModel.ListBindableAttribute Yes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877AA340 | overloaded x2
        public void get_ListBindable(){} // RVA: 0x7FFE81346E30
        public void Equals(){} // RVA: 0x7FFE877AA360
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void IsDefaultAttribute(){} // RVA: 0x7FFE877AA3E0
        public void .cctor(){} // RVA: 0x7FFE877AA460
    }

    public class ListChangedEventArgs : EventArgs
    {
        public 0x6652DB0C _listChangedType; // 0x10
        public int _newIndex; // 0x14
        public int _oldIndex; // 0x18
        public System.ComponentModel.PropertyDescriptor _propertyDescriptor; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877AA800 | overloaded x4
        public void get_ListChangedType(){} // RVA: 0x7FFE811485C0
        public void get_NewIndex(){} // RVA: 0x7FFE8164B230
        public void get_OldIndex(){} // RVA: 0x7FFE813DB630
        public void get_PropertyDescriptor(){} // RVA: 0x7FFE811290C0
    }

    public class ListChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE82886970
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class ListSortDescription : Object
    {
        public System.ComponentModel.PropertyDescriptor _propertyDescriptor; // 0x10
        public 0x6652DC14 _sortDirection; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AF3A20
        public void get_PropertyDescriptor(){} // RVA: 0x7FFE81116380
        public void set_PropertyDescriptor(){} // RVA: 0x7FFE810FCE30
        public void get_SortDirection(){} // RVA: 0x7FFE813DB630
        public void set_SortDirection(){} // RVA: 0x7FFE8144DF00
    }

    public class ListSortDescriptionCollection : Object
    {
        public System.Collections.ArrayList _sorts; // 0x10
        public object field_1; // 0x255
        public object field_2; // 0x256
        public object field_3; // 0x257
        public object field_4; // 0x258
        public object field_5; // 0x259
        public object field_6; // 0x25A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877AA920 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFE877AAA20
        public void set_Item(){} // RVA: 0x7FFE877AAAC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE811E0850
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE877AAA20
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE877AAB10
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE877AAB60
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE877AABB0
        public void Contains(){} // RVA: 0x7FFE877AAC00
        public void IndexOf(){} // RVA: 0x7FFE877AAC60
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE877AACC0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE877AAD10
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE877AAD60
        public void get_Count(){} // RVA: 0x7FFE8154F670
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE811E0850
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE827C4A80
        public void CopyTo(){} // RVA: 0x7FFE8693D140
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8670DE60
    }

    public class LocalizableAttribute : Attribute
    {
        public bool _isLocalizable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
        public void get_IsLocalizable(){} // RVA: 0x7FFE811C55E0
        public void Equals(){} // RVA: 0x7FFE87790420
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void IsDefaultAttribute(){} // RVA: 0x7FFE877904E0
        public void .cctor(){} // RVA: 0x7FFE87790550
    }

    public class LookupBindingPropertiesAttribute : Attribute
    {
        public string _dataSource; // 0x10
        public string _displayMember; // 0x18
        public string _valueMember; // 0x20
        public string _lookupMember; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81143A50 | overloaded x2
        public void get_DataSource(){} // RVA: 0x7FFE81116380
        public void get_DisplayMember(){} // RVA: 0x7FFE810FE7C0
        public void get_ValueMember(){} // RVA: 0x7FFE811290C0
        public void get_LookupMember(){} // RVA: 0x7FFE81129130
        public void Equals(){} // RVA: 0x7FFE877AAF00
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void .cctor(){} // RVA: 0x7FFE877AB090
    }

}