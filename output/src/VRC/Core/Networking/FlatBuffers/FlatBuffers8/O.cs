// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 3
// Methods: 31

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class ObjectPool : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0xA8

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsObjectPool(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void VerifyObjectPool(){} // RVA: 0x7FFE88120A90
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Data(){} // RVA: 0x7FFE8811E240
        public void get_DataLength(){} // RVA: 0x7FFE8811E2C0
        public void GetDataBytes(){} // RVA: 0x7FFE88120B80
        public void GetDataArray(){} // RVA: 0x7FFE88120BF0
        public void CreateObjectPool(){} // RVA: 0x7FFE88120C40
        public void StartObjectPool(){} // RVA: 0x7FFE8811DF00
        public void AddData(){} // RVA: 0x7FFE8811DF20
        public void CreateDataVector(){} // RVA: 0x7FFE8811E4B0
        public void CreateDataVectorBlock(){} // RVA: 0x7FFE88120E50 | overloaded x3
        public void StartDataVector(){} // RVA: 0x7FFE8811E750
        public void EndObjectPool(){} // RVA: 0x7FFE88120EE0
        public void FinishObjectPoolBuffer(){} // RVA: 0x7FFE8811F580
        public void FinishSizePrefixedObjectPoolBuffer(){} // RVA: 0x7FFE8811F5E0
        public void UnPack(){} // RVA: 0x7FFE88120F70
        public void UnPackTo(){} // RVA: 0x7FFE88121020
        public void Pack(){} // RVA: 0x7FFE88121230
    }

    public class ObjectPoolT : Object
    {
        public System.Collections.Generic.List`1<byte> _data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE81116380
        public void set_Data(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
        public void DeserializeFromBinary(){} // RVA: 0x7FFE88121360
        public void SerializeToBinary(){} // RVA: 0x7FFE88121410
    }

    public class ObjectPoolVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8811EB50
    }

}