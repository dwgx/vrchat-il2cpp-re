// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 3
// Methods: 25

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class MethodInfoFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void DeserializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void SerializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void GetUninitializedObject(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class MinimalBaseFormatter`1 : Object
    {
        public bool IsValueType;

        // ── Methods ──
        public void get_SerializedType(){} // RVA: 0x7FFE848B60E0
        public void Deserialize(){} // RVA: 0x7FFE81081080
        public void Serialize(){} // RVA: 0x7FFE848B63B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFE848B6400
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFE848B6600
        public void GetUninitializedObject(){} // RVA: 0x7FFE81081080
        public void Read(){} // RVA: 0x7FFE80E4F230
        public void Write(){} // RVA: 0x7FFE80E4F230
        public void RegisterReferenceID(){} // RVA: 0x7FFE848B6960
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE848B6B40
    }

    public class MultiDimensionalArrayFormatter`2 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE80E46010
        public void GetUninitializedObject(){} // RVA: 0x7FFE810A1420
        public void DeserializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void SerializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void IterateArrayWrite(){} // RVA: 0x7FFE80E4F230 | overloaded x2
        public void IterateArrayRead(){} // RVA: 0x7FFE80E4F230 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

}