// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization
// Classes: 8
// Methods: 43

namespace ThirdParty.DotNet.System.Text.Json.Serialization
{
    public class ReadBufferState
    {
        public byte[] _buffer; // 0x10
        public byte _offset; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x68C7780
        public void get_IsFinalBlock(){} // RVA: 0x5992B0
        public void get_Bytes(){} // RVA: 0x68C7900
        public void ReadFromStreamAsync(){} // RVA: 0x68C7A00
        public void ReadFromStream(){} // RVA: 0x68C7CC0
        public void AdvanceBuffer(){} // RVA: 0x68C7D40
        public void ProcessReadBytes(){} // RVA: 0x68C7F90
        public void Dispose(){} // RVA: 0x68C81B0
    }

    public class ReferenceEqualsWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x100A2F0
        public void Equals(){} // RVA: 0x3554450 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6353CA0
    }

    public class ReferenceEqualsWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x100A2F0
        public void Equals(){} // RVA: 0x3554450 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6353CA0
    }

    public class ReferenceHandler
    {
        public 0x658F41C8 HandlingStrategy; // 0x10
        public System.Text.Json.Serialization.ReferenceHandler <Preserve>k__BackingField;

        // ── Methods ──
        public void get_Preserve(){} // RVA: 0x68C8790
        public void get_IgnoreCycles(){} // RVA: 0x68C87F0
        public void CreateResolver(){} // RVA: 0x391BC0 | overloaded x2
        public void .ctor(){} // RVA: 0x1AF9470
        public void .cctor(){} // RVA: 0x68C8850
    }

    public class ReferenceHandler
    {
        public 0x6593B398 HandlingStrategy; // 0x10

        // ── Methods ──
        public void get_Preserve(){} // RVA: 0x6356030
        public void CreateResolver(){} // RVA: 0x391BC0 | overloaded x2
        public void .ctor(){} // RVA: 0x1AF9470
        public void .cctor(){} // RVA: 0x6356090
    }

    public class ReferenceHandler`1
    {
        // ── Methods ──
        public void CreateResolver(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x24A50
    }

    public class ReferenceResolver
    {
        // ── Methods ──
        public void AddReference(){} // RVA: 0x2DC60
        public void GetReference(){} // RVA: 0x1E6A0
        public void ResolveReference(){} // RVA: 0xCE10
        public void PopReferenceForCycleDetection(){} // RVA: 0x6356270
        public void PushReferenceForCycleDetection(){} // RVA: 0x63562B0
        public void ContainsReferenceForCycleDetection(){} // RVA: 0x63562F0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ReferenceResolver
    {
        // ── Methods ──
        public void AddReference(){} // RVA: 0x2DC60
        public void GetReference(){} // RVA: 0x1E6A0
        public void ResolveReference(){} // RVA: 0xCE10
        public void PopReferenceForCycleDetection(){} // RVA: 0x68C8A30
        public void PushReferenceForCycleDetection(){} // RVA: 0x68C8A70
        public void ContainsReferenceForCycleDetection(){} // RVA: 0x68C8AB0
        public void .ctor(){} // RVA: 0x2DD310
    }

}