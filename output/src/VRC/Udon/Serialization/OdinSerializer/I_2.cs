// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 8
// Methods: 21

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class ISelfFormatter
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2AD4B10
        public void Deserialize(){} // RVA: 0x7FFAF2AD4B10
    }

    public class ISerializableFormatterLocator
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFAFA30CFF0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ISerializationPolicy
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0x7FFAF2ABCD60
        public void get_AllowNonSerializableTypes(){} // RVA: 0x7FFAF2ABDBE0
        public void ShouldSerializeMember(){} // RVA: 0x7FFAF2ABDE40
    }

    public class ISupportsPrefabSerialization
    {
        // ── Methods ──
        public void get_SerializationData(){}
        public void set_SerializationData(){} // RVA: 0x7FFAF2D33FA0
    }

    public class Int16Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAFA32B330
        public void WriteValue(){} // RVA: 0x7FFAFA32C000
        public void .ctor(){} // RVA: 0x7FFAFA32C070
    }

    public class Int32Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAFA32C0E0
        public void WriteValue(){} // RVA: 0x7FFAFA32CDB0
        public void .ctor(){} // RVA: 0x7FFAFA32CE20
    }

    public class Int64Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAFA32CE90
        public void WriteValue(){} // RVA: 0x7FFAFA32DB50
        public void .ctor(){} // RVA: 0x7FFAFA32DBC0
    }

    public class IntPtrSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAFA32DC30
        public void WriteValue(){} // RVA: 0x7FFAFA32E8F0
        public void .ctor(){} // RVA: 0x7FFAFA32E960
    }

}