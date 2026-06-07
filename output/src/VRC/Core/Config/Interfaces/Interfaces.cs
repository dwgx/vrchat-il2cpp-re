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
        public void HasKey(){} // RVA: 0xDE40
        public void GetObject(){} // RVA: 0xCE10
        public void GetString(){} // RVA: 0x1E6A0
        public void GetInt(){}
        public void GetBool(){}
        public void GetFloat(){}
        public void GetList(){} // RVA: 0xCE10
        public void GetDictionary(){} // RVA: 0xCE10
        public void GetListOfDictionaries(){} // RVA: 0xCE10
        public void IsInitialized(){} // RVA: 0xDBE0
        public void GetObjectAtPath(){} // RVA: 0xCE10
        public void TryGet(){} // RVA: 0x11120
    }

    public class IReadWriteConfig
    {
        // ── Methods ──
        public void SetValue(){} // RVA: 0x2DC60
    }

}