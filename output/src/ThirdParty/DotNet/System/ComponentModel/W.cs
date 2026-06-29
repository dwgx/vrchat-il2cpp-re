// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 3
// Methods: 14

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class WarningException : SystemException
    {
        public object _helpUrl;
        public object _helpTopic;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76DDC10
        public void get_HelpUrl(){} // RVA: 0x1069350
        public void get_HelpTopic(){} // RVA: 0x106A7D0
        public void GetObjectData(){} // RVA: 0x76DDEF0
    }

    public class WeakHashtable : Hashtable
    {
        public object _comparer;
        public object _lastGlobalMem;
        public object _lastHashCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x770F900
        public void Clear(){} // RVA: 0x770F970
        public void Remove(){} // RVA: 0x770F980
        public void SetWeak(){} // RVA: 0x770F990
        public void ScavengeKeys(){} // RVA: 0x770FA60
        public void .cctor(){} // RVA: 0x770FED0
    }

    public class Win32Exception : ExternalException
    {
        public object nativeErrorCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7580C70
        public void get_NativeErrorCode(){} // RVA: 0xF3A950
        public void GetObjectData(){} // RVA: 0x770E480
        public void GetErrorMessage(){} // RVA: 0x770E550
    }

}