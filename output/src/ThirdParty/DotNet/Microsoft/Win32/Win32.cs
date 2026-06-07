// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Win32
// Classes: 5
// Methods: 50

namespace ThirdParty.DotNet.Microsoft.Win32
{
    public class NativeMethods
    {
        // ── Methods ──
        public void DuplicateHandle(){} // RVA: 0x6BE7790
        public void GetCurrentProcess(){} // RVA: 0x6BE7950
        public void GetExitCodeProcess(){} // RVA: 0x6BE7AF0 | overloaded x2
        public void TerminateProcess(){} // RVA: 0x6BE7CC0 | overloaded x2
        public void GetProcessTimes(){} // RVA: 0x6BE7DA0 | overloaded x2
        public void GetCurrentProcessId(){} // RVA: 0x6BE7EA0
        public void CloseProcess(){} // RVA: 0x6BE7EB0
    }

    public class Registry
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5C1E4E0
    }

    public class RegistryKey
    {
        // ── Methods ──
        public void ClosePerfDataKey(){} // RVA: 0x5C1E8B0
        public void OpenBaseKeyCore(){} // RVA: 0x5C1E910
        public void InternalOpenSubKeyCore(){} // RVA: 0x5C1EAA0
        public void InternalSubKeyCountCore(){} // RVA: 0x5C1EE70
        public void InternalGetSubKeyNamesCore(){} // RVA: 0x5C1EFC0
        public void InternalValueCountCore(){} // RVA: 0x5C1F360
        public void GetValueNamesCore(){} // RVA: 0x5C1F4B0
        public void InternalGetValueCore(){} // RVA: 0x5C1FA00
        public void Win32Error(){} // RVA: 0x5C20A70
        public void GetRegistryKeyAccess(){} // RVA: 0x5C20C10
        public void .ctor(){} // RVA: 0x5C20C30
        public void Dispose(){} // RVA: 0x5C20DD0
        public void OpenBaseKey(){} // RVA: 0x5C20F50
        public void OpenSubKey(){} // RVA: 0x5C21130 | overloaded x2
        public void InternalSubKeyCount(){} // RVA: 0x5C21210
        public void GetSubKeyNames(){} // RVA: 0x5C213D0
        public void InternalGetSubKeyNames(){} // RVA: 0x5C213E0
        public void InternalValueCount(){} // RVA: 0x5C21630
        public void GetValueNames(){} // RVA: 0x5C217F0
        public void GetValue(){} // RVA: 0x5C21AC0 | overloaded x2
        public void InternalGetValue(){} // RVA: 0x5C21B90
        public void ToString(){} // RVA: 0x5C21C30
        public void FixupName(){} // RVA: 0x5C21C90
        public void FixupPath(){} // RVA: 0x5C21EC0
        public void EnsureNotDisposed(){} // RVA: 0x5C21FF0
        public void GetSubKeyPermissionCheck(){} // RVA: 0x5C22050
        public void ValidateKeyName(){} // RVA: 0x5C22070
        public void ValidateKeyView(){} // RVA: 0x5C224E0
        public void IsSystemKey(){} // RVA: 0x5C22550
        public void IsPerfDataKey(){} // RVA: 0x5C22560
        public void .cctor(){} // RVA: 0x5C22570
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowArgumentException(){} // RVA: 0x5C227E0
        public void ThrowArgumentNullException(){} // RVA: 0x5C22840
        public void ThrowSecurityException(){} // RVA: 0x5C22890
        public void ThrowObjectDisposedException(){} // RVA: 0x5C228E0
    }

    public class Win32Native
    {
        // ── Methods ──
        public void GetMessage(){} // RVA: 0x5C22940
        public void MakeHRFromErrorCode(){} // RVA: 0x5C22990
    }

}