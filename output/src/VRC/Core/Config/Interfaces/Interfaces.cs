// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Config.Interfaces
// Classes: 2
// Methods: 14

namespace VRC.Core.Config.Interfaces
{
    public class IReadOnlyConfig
    {
        // ── Methods ──
        public void Init(){}
        public void HasKey(){} // RVA: 0x7FFE80E2F3B0
        public void GetObject(){} // RVA: 0x7FFE80E2E390
        public void GetString(){} // RVA: 0x7FFE80E3FC10
        public void GetInt(){}
        public void GetBool(){}
        public void GetFloat(){}
        public void GetList(){} // RVA: 0x7FFE80E2E390
        public void GetDictionary(){} // RVA: 0x7FFE80E2E390
        public void GetListOfDictionaries(){} // RVA: 0x7FFE80E2E390
        public void IsInitialized(){} // RVA: 0x7FFE80E2F150
        public void GetObjectAtPath(){} // RVA: 0x7FFE80E2E390
        public void TryGet(){} // RVA: 0x7FFE80E32650
    }

    public class IReadWriteConfig
    {
        // ── Methods ──
        public void SetValue(){} // RVA: 0x7FFE80E4F230
    }

}