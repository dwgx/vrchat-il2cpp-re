// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Config.Interfaces
// Classes: 2
// Methods: 14

namespace VRC.Core.Config.Interfaces
{
    public class IReadOnlyConfig
    {
        // ── Original Methods ──
        public void Init(){}
        public void HasKey(){} // RVA: 0x7ffaa864a2a0
        public void IsInitialized(){} // RVA: 0x7ffaa864a040
        public void TryGet(){} // RVA: 0x7ffaa864d540
        // ── Binary Analysis Named ──
        public void GetObject(){} // RVA: 0x7ffaa8649280
        public void GetString(){} // RVA: 0x7ffaa865aa30
        public void GetInt(){}
        public void GetBool(){}
        public void GetFloat(){}
        public void GetList(){} // RVA: 0x7ffaa8649280
        public void GetDictionary(){} // RVA: 0x7ffaa8649280
        public void GetListOfDictionaries(){} // RVA: 0x7ffaa8649280
        public void GetObjectAtPath(){} // RVA: 0x7ffaa8649280
    }

    public class IReadWriteConfig
    {
        // ── Binary Analysis Named ──
        public void SetValue(){} // RVA: 0x7ffaa8669e70
    }

}