// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 2
// Methods: 9

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class QuaternionFormatter : MinimalBaseFormatter`1
    {
        public object FloatSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x84CB8E0
        public void Write(){} // RVA: 0x84CBA10
        public void .ctor(){} // RVA: 0x84CBB70
        public void .cctor(){} // RVA: 0x84CBBD0
    }

    public class QueueFormatter`2 : BaseFormatter`1
    {
        public object TSerializer;
        public object IsPlainQueue;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
        public void .ctor(){} // RVA: 0x894290
        public void GetUninitializedObject(){} // RVA: 0xA94080
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
    }

}