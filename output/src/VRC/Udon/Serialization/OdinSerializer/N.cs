// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 2
// Methods: 10

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class NodeInfo : ValueType
    {
        public object Empty;
        public object Name;
        public object Id;
        public object Type;
        public object IsArray;
        public object IsEmpty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9DC150
        public void op_Equality(){} // RVA: 0x84A6880
        public void op_Inequality(){} // RVA: 0x84A6930
        public void Equals(){} // RVA: 0x9DC160
        public void GetHashCode(){} // RVA: 0x9DC170
        public void .cctor(){} // RVA: 0x84A6CB0
    }

    public class NullableFormatter`1 : BaseFormatter`1
    {
        public object TSerializer;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
        public void .ctor(){} // RVA: 0x894290
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
    }

}