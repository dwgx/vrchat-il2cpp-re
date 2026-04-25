// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 3
// Methods: 32

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class ObjectPool : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsObjectPool(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void VerifyObjectPool(){} // RVA: 0x7FFAC9D78580
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Data(){} // RVA: 0x7FFAC9D75C20
        public void get_DataLength(){} // RVA: 0x7FFAC9D75CA0
        public void GetDataBytes(){} // RVA: 0x7FFAC9D78670
        public void GetDataArray(){} // RVA: 0x7FFAC9D786E0
        public void MutateData(){} // RVA: 0x7FFAC9D75DD0
        public void CreateObjectPool(){} // RVA: 0x7FFAC9D78730
        public void StartObjectPool(){} // RVA: 0x7FFAC9D758E0
        public void AddData(){} // RVA: 0x7FFAC9D75900
        public void CreateDataVector(){} // RVA: 0x7FFAC9D75F20
        public void CreateDataVectorBlock(){} // RVA: 0x7FFAC9D78940 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFAC9D761C0
        public void EndObjectPool(){} // RVA: 0x7FFAC9D789D0
        public void FinishObjectPoolBuffer(){} // RVA: 0x7FFAC9D76FF0
        public void FinishSizePrefixedObjectPoolBuffer(){} // RVA: 0x7FFAC9D77050
        public void UnPack(){} // RVA: 0x7FFAC9D78A60
        public void UnPackTo(){} // RVA: 0x7FFAC9D78B10
        public void Pack(){} // RVA: 0x7FFAC9D78D20
    }

    public class ObjectPoolT : Object
    {
        public System.Collections.Generic.List`1<byte> Data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2F3C380
        public void set_Data(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9D78E50
        public void SerializeToBinary(){} // RVA: 0x7FFAC9D78F00
    }

    public class ObjectPoolVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D765C0
    }

}