// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 3
// Methods: 28

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class ObjectPool : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsObjectPool(){} // RVA: 0x8217320
        public void VerifyObjectPool(){} // RVA: 0x821A160
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Data(){} // RVA: 0x9B5A40
        public void get_DataLength(){} // RVA: 0x9B5A50
        public void GetDataBytes(){} // RVA: 0x9B5F60
        public void GetDataArray(){} // RVA: 0x9B5FD0
        public void CreateObjectPool(){} // RVA: 0x821A310
        public void StartObjectPool(){} // RVA: 0x8217590
        public void AddData(){} // RVA: 0x82175B0
        public void CreateDataVector(){} // RVA: 0x8217B40
        public void CreateDataVectorBlock(){} // RVA: 0x821A520
        public void StartDataVector(){} // RVA: 0x8217DF0
        public void EndObjectPool(){} // RVA: 0x821A5B0
        public void FinishObjectPoolBuffer(){} // RVA: 0x8218C30
        public void FinishSizePrefixedObjectPoolBuffer(){} // RVA: 0x8218C90
        public void UnPack(){} // RVA: 0x9B6020
        public void UnPackTo(){} // RVA: 0x9B6030
        public void Pack(){} // RVA: 0x821A900
    }

    public class ObjectPoolT : Object
    {
        public object _data;

        // ── Methods ──
        public void get_Data(){} // RVA: 0xB5DBF0
        public void set_Data(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
        public void DeserializeFromBinary(){} // RVA: 0x821AA30
        public void SerializeToBinary(){} // RVA: 0x821AAE0
    }

    public class ObjectPoolVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82181F0
    }

}