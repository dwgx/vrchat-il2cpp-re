// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Win32
// Classes: 5
// Methods: 50

namespace ThirdParty.DotNet.Microsoft.Win32
{
    public class NativeMethods
    {
        // ── Methods ──
        public void DuplicateHandle(){} // RVA: 0x7FFAF9697790
        public void GetCurrentProcess(){} // RVA: 0x7FFAF9697950
        public void GetExitCodeProcess(){} // RVA: 0x7FFAF9697AF0 | overloaded x2
        public void TerminateProcess(){} // RVA: 0x7FFAF9697CC0 | overloaded x2
        public void GetProcessTimes(){} // RVA: 0x7FFAF9697DA0 | overloaded x2
        public void GetCurrentProcessId(){} // RVA: 0x7FFAF9697EA0
        public void CloseProcess(){} // RVA: 0x7FFAF9697EB0
    }

    public class Registry
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF86CE4E0
    }

    public class RegistryKey
    {
        // ── Methods ──
        public void ClosePerfDataKey(){} // RVA: 0x7FFAF86CE8B0
        public void OpenBaseKeyCore(){} // RVA: 0x7FFAF86CE910
        public void InternalOpenSubKeyCore(){} // RVA: 0x7FFAF86CEAA0
        public void InternalSubKeyCountCore(){} // RVA: 0x7FFAF86CEE70
        public void InternalGetSubKeyNamesCore(){} // RVA: 0x7FFAF86CEFC0
        public void InternalValueCountCore(){} // RVA: 0x7FFAF86CF360
        public void GetValueNamesCore(){} // RVA: 0x7FFAF86CF4B0
        public void InternalGetValueCore(){} // RVA: 0x7FFAF86CFA00
        public void Win32Error(){} // RVA: 0x7FFAF86D0A70
        public void GetRegistryKeyAccess(){} // RVA: 0x7FFAF86D0C10
        public void .ctor(){} // RVA: 0x7FFAF86D0C30
        public void Dispose(){} // RVA: 0x7FFAF86D0DD0
        public void OpenBaseKey(){} // RVA: 0x7FFAF86D0F50
        public void OpenSubKey(){} // RVA: 0x7FFAF86D1130 | overloaded x2
        public void InternalSubKeyCount(){} // RVA: 0x7FFAF86D1210
        public void GetSubKeyNames(){} // RVA: 0x7FFAF86D13D0
        public void InternalGetSubKeyNames(){} // RVA: 0x7FFAF86D13E0
        public void InternalValueCount(){} // RVA: 0x7FFAF86D1630
        public void GetValueNames(){} // RVA: 0x7FFAF86D17F0
        public void GetValue(){} // RVA: 0x7FFAF86D1AC0 | overloaded x2
        public void InternalGetValue(){} // RVA: 0x7FFAF86D1B90
        public void ToString(){} // RVA: 0x7FFAF86D1C30
        public void FixupName(){} // RVA: 0x7FFAF86D1C90
        public void FixupPath(){} // RVA: 0x7FFAF86D1EC0
        public void EnsureNotDisposed(){} // RVA: 0x7FFAF86D1FF0
        public void GetSubKeyPermissionCheck(){} // RVA: 0x7FFAF86D2050
        public void ValidateKeyName(){} // RVA: 0x7FFAF86D2070
        public void ValidateKeyView(){} // RVA: 0x7FFAF86D24E0
        public void IsSystemKey(){} // RVA: 0x7FFAF86D2550
        public void IsPerfDataKey(){} // RVA: 0x7FFAF86D2560
        public void .cctor(){} // RVA: 0x7FFAF86D2570
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowArgumentException(){} // RVA: 0x7FFAF86D27E0
        public void ThrowArgumentNullException(){} // RVA: 0x7FFAF86D2840
        public void ThrowSecurityException(){} // RVA: 0x7FFAF86D2890
        public void ThrowObjectDisposedException(){} // RVA: 0x7FFAF86D28E0
    }

    public class Win32Native
    {
        // ── Methods ──
        public void GetMessage(){} // RVA: 0x7FFAF86D2940
        public void MakeHRFromErrorCode(){} // RVA: 0x7FFAF86D2990
    }

}