// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Win32
// Classes: 5
// Methods: 50

namespace ThirdParty.DotNet.Microsoft.Win32
{
    public class NativeMethods : Object
    {
        // ── Methods ──
        public void DuplicateHandle(){} // RVA: 0x7FFE87728640
        public void GetCurrentProcess(){} // RVA: 0x7FFE87728800
        public void GetExitCodeProcess(){} // RVA: 0x7FFE877289A0 | overloaded x2
        public void TerminateProcess(){} // RVA: 0x7FFE87728B70 | overloaded x2
        public void GetProcessTimes(){} // RVA: 0x7FFE87728C50 | overloaded x2
        public void GetCurrentProcessId(){} // RVA: 0x7FFE87728D50
        public void CloseProcess(){} // RVA: 0x7FFE87728D60
    }

    public class Registry : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8675F330
    }

    public class RegistryKey : MarshalByRefObject
    {
        // ── Methods ──
        public void ClosePerfDataKey(){} // RVA: 0x7FFE8675F700
        public void OpenBaseKeyCore(){} // RVA: 0x7FFE8675F760
        public void InternalOpenSubKeyCore(){} // RVA: 0x7FFE8675F8F0
        public void InternalSubKeyCountCore(){} // RVA: 0x7FFE8675FCC0
        public void InternalGetSubKeyNamesCore(){} // RVA: 0x7FFE8675FE10
        public void InternalValueCountCore(){} // RVA: 0x7FFE867601B0
        public void GetValueNamesCore(){} // RVA: 0x7FFE86760300
        public void InternalGetValueCore(){} // RVA: 0x7FFE86760850
        public void Win32Error(){} // RVA: 0x7FFE867618C0
        public void GetRegistryKeyAccess(){} // RVA: 0x7FFE86761A60
        public void .ctor(){} // RVA: 0x7FFE86761A80
        public void Dispose(){} // RVA: 0x7FFE86761C20
        public void OpenBaseKey(){} // RVA: 0x7FFE86761DA0
        public void OpenSubKey(){} // RVA: 0x7FFE86761F80 | overloaded x2
        public void InternalSubKeyCount(){} // RVA: 0x7FFE86762060
        public void GetSubKeyNames(){} // RVA: 0x7FFE86762220
        public void InternalGetSubKeyNames(){} // RVA: 0x7FFE86762230
        public void InternalValueCount(){} // RVA: 0x7FFE86762480
        public void GetValueNames(){} // RVA: 0x7FFE86762640
        public void GetValue(){} // RVA: 0x7FFE86762910 | overloaded x2
        public void InternalGetValue(){} // RVA: 0x7FFE867629E0
        public void ToString(){} // RVA: 0x7FFE86762A80
        public void FixupName(){} // RVA: 0x7FFE86762AE0
        public void FixupPath(){} // RVA: 0x7FFE86762D10
        public void EnsureNotDisposed(){} // RVA: 0x7FFE86762E40
        public void GetSubKeyPermissionCheck(){} // RVA: 0x7FFE86762EA0
        public void ValidateKeyName(){} // RVA: 0x7FFE86762EC0
        public void ValidateKeyView(){} // RVA: 0x7FFE86763330
        public void IsSystemKey(){} // RVA: 0x7FFE867633A0
        public void IsPerfDataKey(){} // RVA: 0x7FFE867633B0
        public void .cctor(){} // RVA: 0x7FFE867633C0
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentException(){} // RVA: 0x7FFE86763630
        public void ThrowArgumentNullException(){} // RVA: 0x7FFE86763690
        public void ThrowSecurityException(){} // RVA: 0x7FFE867636E0
        public void ThrowObjectDisposedException(){} // RVA: 0x7FFE86763730
    }

    public class Win32Native : Object
    {
        // ── Methods ──
        public void GetMessage(){} // RVA: 0x7FFE86763790
        public void MakeHRFromErrorCode(){} // RVA: 0x7FFE867637E0
    }

}