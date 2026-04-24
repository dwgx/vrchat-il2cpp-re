// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 2
// Methods: 11

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class NodeInfo : ValueType
    {
        public arker Empty;
        public string Name; // 0x10
        public int Id; // 0x18
        public object Type; // 0x20
        public bool IsArray; // 0x28
        public bool IsEmpty; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55413F00 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD55413FD0
        public void op_Inequality(){} // RVA: 0x7FFD554140A0
        public void Equals(){} // RVA: 0x7FFD554141A0
        public void GetHashCode(){} // RVA: 0x7FFD55414350
        public void .cctor(){} // RVA: 0x7FFD55414460
    }

    public class NullableFormatter`1 : BaseFormatter`1
    {
        public tSupportedException_ConstructorMaxOf64Parameters<T1717697152> TSerializer;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void DeserializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void SerializeImplementation(){} // RVA: 0x7FFD4E099B30
    }

}