// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 2
// Methods: 9

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class LayerMaskFormatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<int> IntSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFACA01A5F0
        public void Write(){} // RVA: 0x7FFACA01A680
        public void .ctor(){} // RVA: 0x7FFACA01A730
        public void .cctor(){} // RVA: 0x7FFACA01A790
    }

    public class ListFormatter`1 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> TSerializer;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2C58E90
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
    }

}