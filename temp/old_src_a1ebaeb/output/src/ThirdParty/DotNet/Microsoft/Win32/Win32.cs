// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Win32
// Classes: 2
// Methods: 34

namespace ThirdParty.DotNet.Microsoft.Win32
{
    public class Registry : Object
    {
        public object ClassesRoot; // 0x34FC9190
        public object CurrentConfig; // 0x34FC9190

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaddd6be0
    }

    public class RegistryKey : MarshalByRefObject
    {
        public object HKEY_LOCAL_MACHINE; // 0x34FC9310
        public object HKEY_CURRENT_CONFIG; // 0x34FC9310
        public object _hkey; // 0x34FC9310
        public object _state; // 0x34FC9310

        // ── Original Methods ──
        public void ClosePerfDataKey(){} // RVA: 0x7ffaaddd6fb0
        public void OpenBaseKeyCore(){} // RVA: 0x7ffaaddd7010
        public void InternalOpenSubKeyCore(){} // RVA: 0x7ffaaddd71a0
        public void InternalSubKeyCountCore(){} // RVA: 0x7ffaaddd7570
        public void InternalGetSubKeyNamesCore(){} // RVA: 0x7ffaaddd76c0
        public void InternalValueCountCore(){} // RVA: 0x7ffaaddd7a60
        public void InternalGetValueCore(){} // RVA: 0x7ffaaddd8100
        public void Win32Error(){} // RVA: 0x7ffaaddd9170
        public void .ctor(){} // RVA: 0x7ffaaddd9330
        public void Dispose(){} // RVA: 0x7ffaaddd94d0
        public void OpenBaseKey(){} // RVA: 0x7ffaaddd9650
        public void OpenSubKey(){} // RVA: 0x7ffaaddd9830
        public void OpenSubKey(){} // RVA: 0x7ffaaddd9830
        public void InternalSubKeyCount(){} // RVA: 0x7ffaaddd9910
        public void InternalGetSubKeyNames(){} // RVA: 0x7ffaaddd9ae0
        public void InternalValueCount(){} // RVA: 0x7ffaaddd9d30
        public void InternalGetValue(){} // RVA: 0x7ffaaddda290
        public void ToString(){} // RVA: 0x7ffaaddda330
        public void FixupName(){} // RVA: 0x7ffaaddda390
        public void FixupPath(){} // RVA: 0x7ffaaddda5c0
        public void EnsureNotDisposed(){} // RVA: 0x7ffaaddda6f0
        public void ValidateKeyName(){} // RVA: 0x7ffaaddda770
        public void ValidateKeyView(){} // RVA: 0x7ffaadddabe0
        public void IsSystemKey(){} // RVA: 0x7ffaadddac50
        public void IsPerfDataKey(){} // RVA: 0x7ffaadddac60
        public void .cctor(){} // RVA: 0x7ffaadddac70
        // ── Binary Analysis Named ──
        public void GetValueNamesCore(){} // RVA: 0x7ffaaddd7bb0
        public void GetRegistryKeyAccess(){} // RVA: 0x7ffaaddd9310
        public void GetSubKeyNames(){} // RVA: 0x7ffaaddd9ad0
        public void GetValueNames(){} // RVA: 0x7ffaaddd9ef0
        public void GetValue(){} // RVA: 0x7ffaaddda1c0
        public void GetValue(){} // RVA: 0x7ffaaddda1c0
        public void GetSubKeyPermissionCheck(){} // RVA: 0x7ffaaddda750
    }

}