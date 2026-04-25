// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 2
// Methods: 9

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class QuaternionFormatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<float> FloatSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFACA01A870
        public void Write(){} // RVA: 0x7FFACA01A9A0
        public void .ctor(){} // RVA: 0x7FFACA01AB00
        public void .cctor(){} // RVA: 0x7FFACA01AB60
    }

    public class QueueFormatter`2 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> TSerializer;
        public bool IsPlainQueue;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2E8DC40
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
    }

}