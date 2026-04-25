// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 3
// Methods: 25

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class MethodInfoFormatter`1 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<string> StringSerializer;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<System.Type> TypeSerializer;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<System.Type[]> TypeArraySerializer;

        // ── Methods ──
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class MinimalBaseFormatter`1 : Object
    {
        public bool SerializedType;

        // ── Methods ──
        public void get_SerializedType(){} // RVA: 0x7FFAC6533D60
        public void Deserialize(){} // RVA: 0x7FFAC2E5B230
        public void Serialize(){} // RVA: 0x7FFAC6534030
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAC6534080
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAC6534280
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2E5B230
        public void Read(){} // RVA: 0x7FFAC2C79B30
        public void Write(){} // RVA: 0x7FFAC2C79B30
        public void RegisterReferenceID(){} // RVA: 0x7FFAC65345E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC65347C0
    }

    public class MultiDimensionalArrayFormatter`2 : BaseFormatter`1
    {
        public string RANKS_NAME;
        public char RANKS_SEPARATOR;
        public int ArrayRank;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> ValueReaderWriter;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2E8DC40
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void IterateArrayWrite(){} // RVA: 0x7FFAC2C79B30 | overloaded x2
        public void IterateArrayRead(){} // RVA: 0x7FFAC2C79B30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

}