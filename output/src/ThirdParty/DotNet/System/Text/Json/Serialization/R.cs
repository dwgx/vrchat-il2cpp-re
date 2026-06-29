// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization
// Classes: 8
// Methods: 39

namespace ThirdParty.DotNet.System.Text.Json.Serialization
{
    public class ReadBufferState : ValueType
    {
        public object _buffer;
        public object _offset;
        public object _count;
        public object _maxCount;
        public object _isFirstBlock;
        public object _isFinalBlock;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x912800
        public void get_IsFinalBlock(){} // RVA: 0xEE1A0
        public void get_Bytes(){} // RVA: 0x912810
        public void ReadFromStreamAsync(){} // RVA: 0x912840
        public void ReadFromStream(){} // RVA: 0x9128A0
        public void AdvanceBuffer(){} // RVA: 0x912920
        public void ProcessReadBytes(){} // RVA: 0x912930
        public void Dispose(){} // RVA: 0x912940
    }

    public class ReferenceEqualsWrapper : ValueType
    {
        public object _object;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x47F10
        public void Equals(){} // RVA: 0x3189D0
        public void GetHashCode(){} // RVA: 0x8F25C0
    }

    public class ReferenceEqualsWrapper : ValueType
    {
        public object _object;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x47F10
        public void Equals(){} // RVA: 0x3189D0
        public void GetHashCode(){} // RVA: 0x8F25C0
    }

    public class ReferenceHandler : Object
    {
        public object HandlingStrategy;
        public object _preserve;
        public object _ignoreCycles;

        // ── Methods ──
        public void get_Preserve(){} // RVA: 0x6DC3560
        public void CreateResolver(){} // RVA: 0xBFA210
        public void .ctor(){} // RVA: 0x23E2740
        public void .cctor(){} // RVA: 0x6DC35C0
    }

    public class ReferenceHandler : Object
    {
        public object HandlingStrategy;
        public object _preserve;
        public object _ignoreCycles;

        // ── Methods ──
        public void get_Preserve(){} // RVA: 0x732D970
        public void get_IgnoreCycles(){} // RVA: 0x732D9D0
        public void CreateResolver(){} // RVA: 0xBFA210
        public void .ctor(){} // RVA: 0x23E2740
        public void .cctor(){} // RVA: 0x732DA30
    }

    public class ReferenceHandler`1 : ReferenceHandler
    {
        // ── Methods ──
        public void CreateResolver(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x894290
    }

    public class ReferenceResolver : Object
    {
        // ── Methods ──
        public void AddReference(){} // RVA: 0x8943B0
        public void GetReference(){} // RVA: 0x87C5F0
        public void ResolveReference(){} // RVA: 0x87C540
        public void PopReferenceForCycleDetection(){} // RVA: 0x6DC37A0
        public void PushReferenceForCycleDetection(){} // RVA: 0x6DC37E0
        public void ContainsReferenceForCycleDetection(){} // RVA: 0x6DC3820
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ReferenceResolver : Object
    {
        // ── Methods ──
        public void AddReference(){} // RVA: 0x8943B0
        public void GetReference(){} // RVA: 0x87C5F0
        public void ResolveReference(){} // RVA: 0x87C540
        public void PopReferenceForCycleDetection(){} // RVA: 0x732DC10
        public void PushReferenceForCycleDetection(){} // RVA: 0x732DC50
        public void ContainsReferenceForCycleDetection(){} // RVA: 0x732DC90
        public void .ctor(){} // RVA: 0xB43310
    }

}