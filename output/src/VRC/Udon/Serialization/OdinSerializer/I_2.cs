// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 8
// Methods: 21

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class ISelfFormatter
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x24B10
        public void Deserialize(){} // RVA: 0x24B10
    }

    public class ISerializableFormatterLocator
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x785CFF0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ISerializationPolicy
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0xCD60
        public void get_AllowNonSerializableTypes(){} // RVA: 0xDBE0
        public void ShouldSerializeMember(){} // RVA: 0xDE40
    }

    public class ISupportsPrefabSerialization
    {
        // ── Methods ──
        public void get_SerializationData(){}
        public void set_SerializationData(){} // RVA: 0x283FA0
    }

    public class Int16Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x787B330
        public void WriteValue(){} // RVA: 0x787C000
        public void .ctor(){} // RVA: 0x787C070
    }

    public class Int32Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x787C0E0
        public void WriteValue(){} // RVA: 0x787CDB0
        public void .ctor(){} // RVA: 0x787CE20
    }

    public class Int64Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x787CE90
        public void WriteValue(){} // RVA: 0x787DB50
        public void .ctor(){} // RVA: 0x787DBC0
    }

    public class IntPtrSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x787DC30
        public void WriteValue(){} // RVA: 0x787E8F0
        public void .ctor(){} // RVA: 0x787E960
    }

}