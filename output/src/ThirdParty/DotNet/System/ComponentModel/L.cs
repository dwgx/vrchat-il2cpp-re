// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 14
// Methods: 93

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class LicFileLicenseProvider : LicenseProvider
    {
        // ── Methods ──
        public void IsKeyValid(){} // RVA: 0x7AEA55B00
        public void GetKey(){} // RVA: 0x7AEA55B50
        public void GetLicense(){} // RVA: 0x7AEA55C70
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class License : Object
    {
        // ── Methods ──
        public void get_LicenseKey(){} // RVA: 0x7A7E00680
        public void Dispose(){} // RVA: 0x7A7E18770
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LicenseContext : Object
    {
        // ── Methods ──
        public void get_UsageMode(){} // RVA: 0x7A82D1450
        public void GetSavedLicenseKey(){} // RVA: 0x7A82D1450
        public void GetService(){} // RVA: 0x7A82D1450
        public void SetSavedLicenseKey(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LicenseException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA77560
        public void get_LicensedType(){} // RVA: 0x7A8555100
        public void GetObjectData(){} // RVA: 0x7AEA77890
    }

    public class LicenseManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_CurrentContext(){} // RVA: 0x7AEA56190
        public void set_CurrentContext(){} // RVA: 0x7AEA56410
        public void get_UsageMode(){} // RVA: 0x7AEA56650
        public void CacheProvider(){} // RVA: 0x7AEA56710
        public void CreateWithContext(){} // RVA: 0x7AEA56AA0
        public void GetCachedNoLicenseProvider(){} // RVA: 0x7AEA56E50
        public void GetCachedProvider(){} // RVA: 0x7AEA56F10
        public void GetCachedProviderInstance(){} // RVA: 0x7AEA56FE0
        public void IsLicensed(){} // RVA: 0x7AEA570B0
        public void IsValid(){} // RVA: 0x7AEA57290
        public void LockContext(){} // RVA: 0x7AEA57310
        public void UnlockContext(){} // RVA: 0x7AEA57550
        public void ValidateInternal(){} // RVA: 0x7AEA57790
        public void ValidateInternalRecursive(){} // RVA: 0x7AEA57840
        public void Validate(){} // RVA: 0x7AEA58050
        public void .cctor(){} // RVA: 0x7AEA58170
    }

    public class LicenseProvider : Object
    {
        // ── Methods ──
        public void GetLicense(){} // RVA: 0x7A7E12BD0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LicenseProviderAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_LicenseProvider(){} // RVA: 0x7AEA582B0
        public void get_TypeId(){} // RVA: 0x7AEA583B0
        public void Equals(){} // RVA: 0x7AEA58480
        public void GetHashCode(){} // RVA: 0x7AEA3A270
        public void .cctor(){} // RVA: 0x7AEA585A0
    }

    public class ListBindableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA586A0
        public void get_ListBindable(){} // RVA: 0x7A82FBFB0
        public void Equals(){} // RVA: 0x7AEA586C0
        public void GetHashCode(){} // RVA: 0x7AEA3A270
        public void IsDefaultAttribute(){} // RVA: 0x7AEA58740
        public void .cctor(){} // RVA: 0x7AEA587C0
    }

    public class ListChangedEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA58B60
        public void get_ListChangedType(){} // RVA: 0x7A8124910
        public void get_NewIndex(){} // RVA: 0x7A8668BC0
        public void get_OldIndex(){} // RVA: 0x7A83782A0
        public void get_PropertyDescriptor(){} // RVA: 0x7A81052C0
    }

    public class ListChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
        public void BeginInvoke(){} // RVA: 0x7A98B8490
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

    public class ListSortDescription : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9B6A000
        public void get_PropertyDescriptor(){} // RVA: 0x7A80F2570
        public void set_PropertyDescriptor(){} // RVA: 0x7A80D8E20
        public void get_SortDirection(){} // RVA: 0x7A83782A0
        public void set_SortDirection(){} // RVA: 0x7A84385B0
    }

    public class ListSortDescriptionCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA58C80
        public void get_Item(){} // RVA: 0x7AEA58D90
        public void set_Item(){} // RVA: 0x7AEA58E30
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7A81BD750
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.IList.get_Item(){} // RVA: 0x7AEA58D90
        public void System.Collections.IList.set_Item(){} // RVA: 0x7AEA58E80
        public void System.Collections.IList.Add(){} // RVA: 0x7AEA58ED0
        public void System.Collections.IList.Clear(){} // RVA: 0x7AEA58F20
        public void Contains(){} // RVA: 0x7AEA58F70
        public void IndexOf(){} // RVA: 0x7AEA58FD0
        public void System.Collections.IList.Insert(){} // RVA: 0x7AEA59030
        public void System.Collections.IList.Remove(){} // RVA: 0x7AEA59080
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7AEA590D0
        public void get_Count(){} // RVA: 0x7ADBEAB80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A81BD750
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7A97F8BA0
        public void CopyTo(){} // RVA: 0x7ADBEAE60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AD9BABB0
    }

    public class LocalizableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81A2210
        public void get_IsLocalizable(){} // RVA: 0x7A81A2200
        public void Equals(){} // RVA: 0x7AEA3E780
        public void GetHashCode(){} // RVA: 0x7AEA3A270
        public void IsDefaultAttribute(){} // RVA: 0x7AEA3E840
        public void .cctor(){} // RVA: 0x7AEA3E8B0
    }

    public class LookupBindingPropertiesAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A811FE30
        public void get_DataSource(){} // RVA: 0x7A80F2570
        public void get_DisplayMember(){} // RVA: 0x7A80DA7B0
        public void get_ValueMember(){} // RVA: 0x7A81052C0
        public void get_LookupMember(){} // RVA: 0x7A8105330
        public void Equals(){} // RVA: 0x7AEA59270
        public void GetHashCode(){} // RVA: 0x7AEA3A270
        public void .cctor(){} // RVA: 0x7AEA59400
    }

}