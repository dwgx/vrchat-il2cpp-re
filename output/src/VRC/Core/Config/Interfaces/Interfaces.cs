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
        public void HasKey(){} // RVA: 0x7FFAC2C59F60
        public void GetObject(){} // RVA: 0x7FFAC2C58F40
        public void GetString(){} // RVA: 0x7FFAC2C6A6F0
        public void GetInt(){}
        public void GetBool(){}
        public void GetFloat(){}
        public void GetList(){} // RVA: 0x7FFAC2C58F40
        public void GetDictionary(){} // RVA: 0x7FFAC2C58F40
        public void GetListOfDictionaries(){} // RVA: 0x7FFAC2C58F40
        public void IsInitialized(){} // RVA: 0x7FFAC2C59D00
        public void GetObjectAtPath(){} // RVA: 0x7FFAC2C58F40
        public void TryGet(){} // RVA: 0x7FFAC2C5D200
    }

    public class IReadWriteConfig
    {
        // ── Methods ──
        public void SetValue(){} // RVA: 0x7FFAC2C79B30
    }

}