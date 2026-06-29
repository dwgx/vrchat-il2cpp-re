// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Win32
// Classes: 5
// Methods: 45

namespace ThirdParty.DotNet.Microsoft.Win32
{
    public class NativeMethods : Object
    {
        // ── Methods ──
        public void DuplicateHandle(){} // RVA: 0x7AE9D6740
        public void GetCurrentProcess(){} // RVA: 0x7AE9D6900
        public void GetExitCodeProcess(){} // RVA: 0x7AE9D6AC0
        public void TerminateProcess(){} // RVA: 0x7AE9D6CA0
        public void GetProcessTimes(){} // RVA: 0x7AE9D6D80
        public void GetCurrentProcessId(){} // RVA: 0x7AE9D6E80
        public void CloseProcess(){} // RVA: 0x7AE9D6E90
    }

    public class Registry : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADA0C320
    }

    public class RegistryKey : MarshalByRefObject
    {
        // ── Methods ──
        public void ClosePerfDataKey(){} // RVA: 0x7ADA0C6F0
        public void OpenBaseKeyCore(){} // RVA: 0x7ADA0C750
        public void InternalOpenSubKeyCore(){} // RVA: 0x7ADA0C8E0
        public void InternalSubKeyCountCore(){} // RVA: 0x7ADA0CCB0
        public void InternalGetSubKeyNamesCore(){} // RVA: 0x7ADA0CE00
        public void InternalValueCountCore(){} // RVA: 0x7ADA0D1B0
        public void GetValueNamesCore(){} // RVA: 0x7ADA0D300
        public void InternalGetValueCore(){} // RVA: 0x7ADA0D860
        public void Win32Error(){} // RVA: 0x7ADA0E920
        public void GetRegistryKeyAccess(){} // RVA: 0x7ADA0EAC0
        public void .ctor(){} // RVA: 0x7ADA0EAE0
        public void Dispose(){} // RVA: 0x7ADA0ECA0
        public void OpenBaseKey(){} // RVA: 0x7ADA0EE20
        public void OpenSubKey(){} // RVA: 0x7ADA0F000
        public void InternalSubKeyCount(){} // RVA: 0x7ADA0F0E0
        public void GetSubKeyNames(){} // RVA: 0x7ADA0F2A0
        public void InternalGetSubKeyNames(){} // RVA: 0x7ADA0F2B0
        public void InternalValueCount(){} // RVA: 0x7ADA0F500
        public void GetValueNames(){} // RVA: 0x7ADA0F6C0
        public void GetValue(){} // RVA: 0x7ADA0F990
        public void InternalGetValue(){} // RVA: 0x7ADA0FA60
        public void ToString(){} // RVA: 0x7ADA0FB00
        public void FixupName(){} // RVA: 0x7ADA0FB60
        public void FixupPath(){} // RVA: 0x7ADA0FD90
        public void EnsureNotDisposed(){} // RVA: 0x7ADA0FEC0
        public void GetSubKeyPermissionCheck(){} // RVA: 0x7ADA0FF20
        public void ValidateKeyName(){} // RVA: 0x7ADA0FF40
        public void ValidateKeyView(){} // RVA: 0x7ADA103B0
        public void IsSystemKey(){} // RVA: 0x7ADA10420
        public void IsPerfDataKey(){} // RVA: 0x7ADA10430
        public void .cctor(){} // RVA: 0x7ADA10440
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentException(){} // RVA: 0x7ADA106B0
        public void ThrowArgumentNullException(){} // RVA: 0x7ADA10710
        public void ThrowSecurityException(){} // RVA: 0x7ADA10760
        public void ThrowObjectDisposedException(){} // RVA: 0x7ADA107B0
    }

    public class Win32Native : Object
    {
        // ── Methods ──
        public void GetMessage(){} // RVA: 0x7ADA10810
        public void MakeHRFromErrorCode(){} // RVA: 0x7ADA10860
    }

}