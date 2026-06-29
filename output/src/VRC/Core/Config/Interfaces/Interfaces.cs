// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Config.Interfaces
// Classes: 2
// Methods: 14

namespace VRC.Core.Config.Interfaces
{
    public class IReadOnlyConfig
    {
        // ── Methods ──
        public void TryGet(){} // RVA: 0x87D3C0
        public void Init(){} // RVA: 0x89AA50
        public void HasKey(){} // RVA: 0x87D350
        public void GetObject(){} // RVA: 0x87C540
        public void GetString(){} // RVA: 0x87C5F0
        public void GetInt(){} // RVA: 0x885970
        public void GetBool(){} // RVA: 0x87F360
        public void GetFloat(){} // RVA: 0x891D10
        public void GetList(){} // RVA: 0x87C540
        public void GetDictionary(){} // RVA: 0x87C540
        public void GetListOfDictionaries(){} // RVA: 0x87C540
        public void IsInitialized(){} // RVA: 0x87D280
        public void GetObjectAtPath(){} // RVA: 0x87C540
    }

    public class IReadWriteConfig
    {
        // ── Methods ──
        public void SetValue(){} // RVA: 0x8943B0
    }

}