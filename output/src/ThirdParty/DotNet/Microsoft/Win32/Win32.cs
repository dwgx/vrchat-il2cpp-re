// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Win32
// Classes: 2
// Methods: 34

namespace ThirdParty.DotNet.Microsoft.Win32
{
    public class Registry : Object
    {
        public Microsoft.Win32.RegistryKey CurrentUser;
        public Microsoft.Win32.RegistryKey LocalMachine; // 0x8
        public Microsoft.Win32.RegistryKey ClassesRoot; // 0x10
        public Microsoft.Win32.RegistryKey Users; // 0x18
        public Microsoft.Win32.RegistryKey PerformanceData; // 0x20
        public Microsoft.Win32.RegistryKey CurrentConfig; // 0x28
        public Microsoft.Win32.RegistryKey DynData; // 0x30

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD537D5A30
    }

    public class RegistryKey : MarshalByRefObject
    {
        public UIntPtr HKEY_CLASSES_ROOT;
        public UIntPtr HKEY_CURRENT_USER; // 0x8
        public UIntPtr HKEY_LOCAL_MACHINE; // 0x10
        public UIntPtr HKEY_USERS; // 0x18
        public UIntPtr HKEY_PERFORMANCE_DATA; // 0x20
        public UIntPtr HKEY_CURRENT_CONFIG; // 0x28
        public UIntPtr HKEY_DYN_DATA; // 0x30
        public string[] s_hkeyNames; // 0x38
        public Microsoft.Win32.SafeHandles.SafeRegistryHandle _hkey; // 0x18
        public string _keyName; // 0x20
        public bool _remoteKey; // 0x28
        public 0x6641CC68 _state; // 0x2C
        public 0x6641CD18 _checkMode; // 0x30
        public 0x6641CDC8 _regView; // 0x34

        // ── Methods ──
        public void ClosePerfDataKey(){} // RVA: 0x7FFD537D5E00
        public void OpenBaseKeyCore(){} // RVA: 0x7FFD537D5E60
        public void InternalOpenSubKeyCore(){} // RVA: 0x7FFD537D5FF0
        public void InternalSubKeyCountCore(){} // RVA: 0x7FFD537D63C0
        public void InternalGetSubKeyNamesCore(){} // RVA: 0x7FFD537D6510
        public void InternalValueCountCore(){} // RVA: 0x7FFD537D68B0
        public void GetValueNamesCore(){} // RVA: 0x7FFD537D6A00
        public void InternalGetValueCore(){} // RVA: 0x7FFD537D6F50
        public void Win32Error(){} // RVA: 0x7FFD537D7FC0
        public void GetRegistryKeyAccess(){} // RVA: 0x7FFD537D8160
        public void .ctor(){} // RVA: 0x7FFD537D8180
        public void Dispose(){} // RVA: 0x7FFD537D8320
        public void OpenBaseKey(){} // RVA: 0x7FFD537D84A0
        public void OpenSubKey(){} // RVA: 0x7FFD537D8680 | overloaded x2
        public void InternalSubKeyCount(){} // RVA: 0x7FFD537D8760
        public void GetSubKeyNames(){} // RVA: 0x7FFD537D8920
        public void InternalGetSubKeyNames(){} // RVA: 0x7FFD537D8930
        public void InternalValueCount(){} // RVA: 0x7FFD537D8B80
        public void GetValueNames(){} // RVA: 0x7FFD537D8D40
        public void GetValue(){} // RVA: 0x7FFD537D9010 | overloaded x2
        public void InternalGetValue(){} // RVA: 0x7FFD537D90E0
        public void ToString(){} // RVA: 0x7FFD537D9180
        public void FixupName(){} // RVA: 0x7FFD537D91E0
        public void FixupPath(){} // RVA: 0x7FFD537D9410
        public void EnsureNotDisposed(){} // RVA: 0x7FFD537D9540
        public void GetSubKeyPermissionCheck(){} // RVA: 0x7FFD537D95A0
        public void ValidateKeyName(){} // RVA: 0x7FFD537D95C0
        public void ValidateKeyView(){} // RVA: 0x7FFD537D9A30
        public void IsSystemKey(){} // RVA: 0x7FFD537D9AA0
        public void IsPerfDataKey(){} // RVA: 0x7FFD537D9AB0
        public void .cctor(){} // RVA: 0x7FFD537D9AC0
    }

}