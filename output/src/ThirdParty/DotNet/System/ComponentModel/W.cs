// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 3
// Methods: 24

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class WarningException : SystemException
    {
        public string HelpUrl; // 0x90
        public string HelpTopic; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9416F60 | overloaded x6
        public void get_HelpUrl(){} // RVA: 0x7FFAC32EF640
        public void get_HelpTopic(){} // RVA: 0x7FFAC354DFB0
        public void GetObjectData(){} // RVA: 0x7FFAC9417290
    }

    public class WeakHashtable : Hashtable
    {
        public System.Collections.IEqualityComparer _comparer;
        public long _lastGlobalMem; // 0x50
        public int _lastHashCount; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9449530
        public void Clear(){} // RVA: 0x7FFAC94495A0
        public void Remove(){} // RVA: 0x7FFAC94495B0
        public void SetWeak(){} // RVA: 0x7FFAC94495C0
        public void ScavengeKeys(){} // RVA: 0x7FFAC9449690
        public void .cctor(){} // RVA: 0x7FFAC9449B20
    }

    public class Win32Exception : ExternalException
    {
        public int NativeErrorCode; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92B3550 | overloaded x6
        public void get_NativeErrorCode(){} // RVA: 0x7FFAC3220660
        public void GetObjectData(){} // RVA: 0x7FFAC94480A0
        public void GetErrorMessage(){} // RVA: 0x7FFAC9448170
    }

}