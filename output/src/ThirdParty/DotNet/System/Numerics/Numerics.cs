// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Numerics
// Classes: 3
// Methods: 6

namespace ThirdParty.DotNet.System.Numerics
{
    public class Register : ValueType
    {
        public byte byte_0; // 0x10
        public byte byte_1; // 0x11
        public byte byte_2; // 0x12
        public byte byte_3; // 0x13
        public byte byte_4; // 0x14
        public byte byte_5; // 0x15
        public byte byte_6; // 0x16
        public byte byte_7; // 0x17
        public byte byte_8; // 0x18
        public byte byte_9; // 0x19
        public byte byte_10; // 0x1A
        public byte byte_11; // 0x1B
        public byte byte_12; // 0x1C
        public byte byte_13; // 0x1D
        public byte byte_14; // 0x1E
        public byte byte_15; // 0x1F
        public sbyte sbyte_0; // 0x10
        public sbyte sbyte_1; // 0x11
        public sbyte sbyte_2; // 0x12
        public sbyte sbyte_3; // 0x13
        public sbyte sbyte_4; // 0x14
        public sbyte sbyte_5; // 0x15
        public sbyte sbyte_6; // 0x16
        public sbyte sbyte_7; // 0x17
        public sbyte sbyte_8; // 0x18
        public sbyte sbyte_9; // 0x19
        public sbyte sbyte_10; // 0x1A
        public sbyte sbyte_11; // 0x1B
        public sbyte sbyte_12; // 0x1C
        public sbyte sbyte_13; // 0x1D
        public sbyte sbyte_14; // 0x1E
        public sbyte sbyte_15; // 0x1F
        public ushort uint16_0; // 0x10
        public ushort uint16_1; // 0x12
        public ushort uint16_2; // 0x14
        public ushort uint16_3; // 0x16
        public ushort uint16_4; // 0x18
        public ushort uint16_5; // 0x1A
        public ushort uint16_6; // 0x1C
        public ushort uint16_7; // 0x1E
        public short int16_0; // 0x10
        public short int16_1; // 0x12
        public short int16_2; // 0x14
        public short int16_3; // 0x16
        public short int16_4; // 0x18
        public short int16_5; // 0x1A
        public short int16_6; // 0x1C
        public short int16_7; // 0x1E
        public uint uint32_0; // 0x10
        public uint uint32_1; // 0x14
        public uint uint32_2; // 0x18
        public uint uint32_3; // 0x1C
        public int int32_0; // 0x10
        public int int32_1; // 0x14
        public int int32_2; // 0x18
        public int int32_3; // 0x1C
        public ulong uint64_0; // 0x10
        public ulong uint64_1; // 0x18
        public long int64_0; // 0x10
        public long int64_1; // 0x18
        public float single_0; // 0x10
        public float single_1; // 0x14
        public float single_2; // 0x18
        public float single_3; // 0x1C
        public double double_0; // 0x10
        public double double_1; // 0x18
    }

    public class Vector : Object
    {
        public object IsHardwareAccelerated;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E2ADC40
        public void LessThan(){} // RVA: 0x7FFD4E2ADC40
        public void get_IsHardwareAccelerated(){} // RVA: 0x7FFD4E341320
        public void BitwiseOr(){} // RVA: 0x7FFD4E2ADC40
        public void AsVectorByte(){} // RVA: 0x7FFD4E2ADC40
        public void AsVectorUInt64(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Vector`1 : ValueType
    {
        public ackingField.Quantity register; // 0x10
        public int s_count;
        public ackingField.rTask<ushort> s_zero; // 0x4
        public ackingField.rTask<ushort> s_one; // 0x14
        public ackingField.rTask<ushort> s_allOnes; // 0x24
    }

}