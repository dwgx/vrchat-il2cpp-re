// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 2
// Methods: 11

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class NodeInfo : ValueType
    {
        public VRC.Udon.Serialization.OdinSerializer.NodeInfo Empty;
        public string Name; // 0x10
        public int Id; // 0x18
        public System.Type Type; // 0x20
        public bool IsArray; // 0x28
        public bool IsEmpty; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9FF3F00 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC9FF3FD0
        public void op_Inequality(){} // RVA: 0x7FFAC9FF40A0
        public void Equals(){} // RVA: 0x7FFAC9FF41A0
        public void GetHashCode(){} // RVA: 0x7FFAC9FF4350
        public void .cctor(){} // RVA: 0x7FFAC9FF4460
    }

    public class NullableFormatter`1 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> TSerializer;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
    }

}