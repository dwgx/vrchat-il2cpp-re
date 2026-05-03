// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 3
// Methods: 24

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class WarningException : SystemException
    {
        public string _helpUrl; // 0x90
        public string _helpTopic; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877BF690 | overloaded x6
        public void get_HelpUrl(){} // RVA: 0x7FFE8154EB60
        public void get_HelpTopic(){} // RVA: 0x7FFE817AE360
        public void GetObjectData(){} // RVA: 0x7FFE877BF9C0
    }

    public class WeakHashtable : Hashtable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877F1C80
        public void Clear(){} // RVA: 0x7FFE877F1CF0
        public void Remove(){} // RVA: 0x7FFE877F1D00
        public void SetWeak(){} // RVA: 0x7FFE877F1D10
        public void ScavengeKeys(){} // RVA: 0x7FFE877F1DE0
        public void .cctor(){} // RVA: 0x7FFE877F2270
    }

    public class Win32Exception : ExternalException
    {
        public int nativeErrorCode; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8765BC90 | overloaded x6
        public void get_NativeErrorCode(){} // RVA: 0x7FFE814AA220
        public void GetObjectData(){} // RVA: 0x7FFE877F07F0
        public void GetErrorMessage(){} // RVA: 0x7FFE877F08C0
    }

}