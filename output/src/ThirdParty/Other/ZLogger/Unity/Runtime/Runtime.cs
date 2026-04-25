// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Unity.Runtime
// Classes: 1
// Methods: 5

namespace ThirdParty.Other.ZLogger.Unity.Runtime
{
    public class DiagnosticsHelper : Object
    {
        public System.Text.RegularExpressions.Regex typeBeautifyRegex;
        public System.Collections.Generic.Dictionary`2<System.Type,string> builtInTypeNames; // 0x8
        public string applicationDataPath; // 0x10
        public bool displayFilenames; // 0x18

        // ── Methods ──
        public void CleanupStackTrace(){} // RVA: 0x7FFD55281E20
        public void BeautifyType(){} // RVA: 0x7FFD55282590
        public void IgnoreLine(){} // RVA: 0x7FFD55282BE0
        public void AppendHyperLink(){} // RVA: 0x7FFD55282CA0
        public void .cctor(){} // RVA: 0x7FFD55283070
    }

}