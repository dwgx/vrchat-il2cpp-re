// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Win32
// Classes: 5
// Methods: 45

namespace ThirdParty.DotNet.Microsoft.Win32
{
    public class NativeMethods : Object
    {
        // ── Methods ──
        public void DuplicateHandle(){} // RVA: 0x7648880
        public void GetCurrentProcess(){} // RVA: 0x7648A40
        public void GetExitCodeProcess(){} // RVA: 0x7648C00
        public void TerminateProcess(){} // RVA: 0x7648DE0
        public void GetProcessTimes(){} // RVA: 0x7648EC0
        public void GetCurrentProcessId(){} // RVA: 0x7648FC0
        public void CloseProcess(){} // RVA: 0x7648FD0
    }

    public class Registry : Object
    {
        public object CurrentUser;
        public object LocalMachine;
        public object ClassesRoot;
        public object Users;
        public object PerformanceData;
        public object CurrentConfig;
        public object DynData;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6696E20
    }

    public class RegistryKey : MarshalByRefObject
    {
        public object HKEY_CLASSES_ROOT;
        public object HKEY_CURRENT_USER;
        public object HKEY_LOCAL_MACHINE;
        public object HKEY_USERS;
        public object HKEY_PERFORMANCE_DATA;
        public object HKEY_CURRENT_CONFIG;
        public object HKEY_DYN_DATA;
        public object s_hkeyNames;
        public object _hkey;
        public object _keyName;
        public object _remoteKey;
        public object _state;
        public object _checkMode;
        public object _regView;

        // ── Methods ──
        public void ClosePerfDataKey(){} // RVA: 0x66971F0
        public void OpenBaseKeyCore(){} // RVA: 0x6697250
        public void InternalOpenSubKeyCore(){} // RVA: 0x66973E0
        public void InternalSubKeyCountCore(){} // RVA: 0x66977B0
        public void InternalGetSubKeyNamesCore(){} // RVA: 0x6697900
        public void InternalValueCountCore(){} // RVA: 0x6697CB0
        public void GetValueNamesCore(){} // RVA: 0x6697E00
        public void InternalGetValueCore(){} // RVA: 0x6698360
        public void Win32Error(){} // RVA: 0x66993E0
        public void GetRegistryKeyAccess(){} // RVA: 0x6699580
        public void .ctor(){} // RVA: 0x66995A0
        public void Dispose(){} // RVA: 0x6699760
        public void OpenBaseKey(){} // RVA: 0x66998E0
        public void OpenSubKey(){} // RVA: 0x6699AC0
        public void InternalSubKeyCount(){} // RVA: 0x6699BA0
        public void GetSubKeyNames(){} // RVA: 0x6699D60
        public void InternalGetSubKeyNames(){} // RVA: 0x6699D70
        public void InternalValueCount(){} // RVA: 0x6699FC0
        public void GetValueNames(){} // RVA: 0x669A180
        public void GetValue(){} // RVA: 0x669A450
        public void InternalGetValue(){} // RVA: 0x669A510
        public void ToString(){} // RVA: 0x669A5B0
        public void FixupName(){} // RVA: 0x669A610
        public void FixupPath(){} // RVA: 0x669A840
        public void EnsureNotDisposed(){} // RVA: 0x669A970
        public void GetSubKeyPermissionCheck(){} // RVA: 0x669A9D0
        public void ValidateKeyName(){} // RVA: 0x669A9F0
        public void ValidateKeyView(){} // RVA: 0x669AE60
        public void IsSystemKey(){} // RVA: 0x669AED0
        public void IsPerfDataKey(){} // RVA: 0x669AEE0
        public void .cctor(){} // RVA: 0x669AEF0
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentException(){} // RVA: 0x669B160
        public void ThrowArgumentNullException(){} // RVA: 0x669B1C0
        public void ThrowSecurityException(){} // RVA: 0x669B210
        public void ThrowObjectDisposedException(){} // RVA: 0x669B260
    }

    public class Win32Native : Object
    {
        // ── Methods ──
        public void GetMessage(){} // RVA: 0x669B2C0
        public void MakeHRFromErrorCode(){} // RVA: 0x669B310
    }

}