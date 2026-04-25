// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Win32
// Classes: 5
// Methods: 50

namespace ThirdParty.DotNet.Microsoft.Win32
{
    public class NativeMethods : Object
    {
        // ── Methods ──
        public void DuplicateHandle(){} // RVA: 0x7FFAC937FF10
        public void GetCurrentProcess(){} // RVA: 0x7FFAC93800D0
        public void GetExitCodeProcess(){} // RVA: 0x7FFAC9380270 | overloaded x2
        public void TerminateProcess(){} // RVA: 0x7FFAC9380440 | overloaded x2
        public void GetProcessTimes(){} // RVA: 0x7FFAC9380520 | overloaded x2
        public void GetCurrentProcessId(){} // RVA: 0x7FFAC9380620
        public void CloseProcess(){} // RVA: 0x7FFAC9380630
    }

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
        public void .cctor(){} // RVA: 0x7FFAC83B5A30
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
        public 0x6B0BCC68 _state; // 0x2C
        public 0x6B0BCD18 _checkMode; // 0x30
        public 0x6B0BCDC8 _regView; // 0x34

        // ── Methods ──
        public void ClosePerfDataKey(){} // RVA: 0x7FFAC83B5E00
        public void OpenBaseKeyCore(){} // RVA: 0x7FFAC83B5E60
        public void InternalOpenSubKeyCore(){} // RVA: 0x7FFAC83B5FF0
        public void InternalSubKeyCountCore(){} // RVA: 0x7FFAC83B63C0
        public void InternalGetSubKeyNamesCore(){} // RVA: 0x7FFAC83B6510
        public void InternalValueCountCore(){} // RVA: 0x7FFAC83B68B0
        public void GetValueNamesCore(){} // RVA: 0x7FFAC83B6A00
        public void InternalGetValueCore(){} // RVA: 0x7FFAC83B6F50
        public void Win32Error(){} // RVA: 0x7FFAC83B7FC0
        public void GetRegistryKeyAccess(){} // RVA: 0x7FFAC83B8160
        public void .ctor(){} // RVA: 0x7FFAC83B8180
        public void Dispose(){} // RVA: 0x7FFAC83B8320
        public void OpenBaseKey(){} // RVA: 0x7FFAC83B84A0
        public void OpenSubKey(){} // RVA: 0x7FFAC83B8680 | overloaded x2
        public void InternalSubKeyCount(){} // RVA: 0x7FFAC83B8760
        public void GetSubKeyNames(){} // RVA: 0x7FFAC83B8920
        public void InternalGetSubKeyNames(){} // RVA: 0x7FFAC83B8930
        public void InternalValueCount(){} // RVA: 0x7FFAC83B8B80
        public void GetValueNames(){} // RVA: 0x7FFAC83B8D40
        public void GetValue(){} // RVA: 0x7FFAC83B9010 | overloaded x2
        public void InternalGetValue(){} // RVA: 0x7FFAC83B90E0
        public void ToString(){} // RVA: 0x7FFAC83B9180
        public void FixupName(){} // RVA: 0x7FFAC83B91E0
        public void FixupPath(){} // RVA: 0x7FFAC83B9410
        public void EnsureNotDisposed(){} // RVA: 0x7FFAC83B9540
        public void GetSubKeyPermissionCheck(){} // RVA: 0x7FFAC83B95A0
        public void ValidateKeyName(){} // RVA: 0x7FFAC83B95C0
        public void ValidateKeyView(){} // RVA: 0x7FFAC83B9A30
        public void IsSystemKey(){} // RVA: 0x7FFAC83B9AA0
        public void IsPerfDataKey(){} // RVA: 0x7FFAC83B9AB0
        public void .cctor(){} // RVA: 0x7FFAC83B9AC0
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentException(){} // RVA: 0x7FFAC83B9D30
        public void ThrowArgumentNullException(){} // RVA: 0x7FFAC83B9D90
        public void ThrowSecurityException(){} // RVA: 0x7FFAC83B9DE0
        public void ThrowObjectDisposedException(){} // RVA: 0x7FFAC83B9E30
    }

    public class Win32Native : Object
    {
        // ── Methods ──
        public void GetMessage(){} // RVA: 0x7FFAC83B9E90
        public void MakeHRFromErrorCode(){} // RVA: 0x7FFAC83B9EE0
    }

}