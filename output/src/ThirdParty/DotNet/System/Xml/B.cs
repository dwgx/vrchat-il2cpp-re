// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 10
// Methods: 74

namespace ThirdParty.DotNet.System.Xml
{
    public class Base64Encoder : Object
    {
        public byte[] leftOverBytes; // 0x10
        public int leftOverBytesCount; // 0x18
        public char[] charsLine; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC907F780
        public void WriteChars(){}
        public void Encode(){} // RVA: 0x7FFAC907F810
        public void Flush(){} // RVA: 0x7FFAC907FC30
    }

    public class BinHexDecoder : IncrementalReadDecoder
    {
        public byte[] IsFull; // 0x10
        public int curIndex; // 0x18
        public int endIndex; // 0x1C
        public bool hasHalfByteCached; // 0x20
        public byte cachedHalfByte; // 0x21

        // ── Methods ──
        public void get_IsFull(){} // RVA: 0x7FFAC44F7260
        public void Decode(){} // RVA: 0x7FFAC9080210 | overloaded x3
    }

    public class BinHexEncoder : Object
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x7FFAC90807B0 | overloaded x3
    }

    public class BinXmlDateTime : Object
    {
        public int[] KatmaiTimeScaleMultiplicator;
        public double SQLTicksPerMillisecond; // 0x8
        public int SQLTicksPerSecond; // 0x10
        public int SQLTicksPerMinute; // 0x14
        public int SQLTicksPerHour; // 0x18
        public int SQLTicksPerDay; // 0x1C

        // ── Methods ──
        public void Write2Dig(){} // RVA: 0x7FFAC86173C0
        public void Write4DigNeg(){} // RVA: 0x7FFAC9081970
        public void Write3Dec(){} // RVA: 0x7FFAC9081A20
        public void WriteDate(){} // RVA: 0x7FFAC9081C10
        public void WriteTime(){} // RVA: 0x7FFAC9081DF0
        public void WriteTimeFullPrecision(){} // RVA: 0x7FFAC9081F60
        public void WriteTimeZone(){} // RVA: 0x7FFAC9082380 | overloaded x2
        public void BreakDownXsdDateTime(){} // RVA: 0x7FFAC90824C0
        public void BreakDownXsdDate(){} // RVA: 0x7FFAC90826E0
        public void BreakDownXsdTime(){} // RVA: 0x7FFAC9082890
        public void XsdDateTimeToString(){} // RVA: 0x7FFAC90829E0
        public void XsdDateToString(){} // RVA: 0x7FFAC9082DD0
        public void XsdTimeToString(){} // RVA: 0x7FFAC9083150
        public void SqlDateTimeToString(){} // RVA: 0x7FFAC90833E0
        public void SqlDateTimeToDateTime(){} // RVA: 0x7FFAC90835F0
        public void SqlSmallDateTimeToString(){} // RVA: 0x7FFAC9083740
        public void SqlSmallDateTimeToDateTime(){} // RVA: 0x7FFAC90838F0
        public void XsdKatmaiDateToDateTime(){} // RVA: 0x7FFAC9083970
        public void XsdKatmaiDateTimeToDateTime(){} // RVA: 0x7FFAC9083A90
        public void XsdKatmaiTimeToDateTime(){} // RVA: 0x7FFAC9083BD0
        public void XsdKatmaiDateOffsetToDateTimeOffset(){} // RVA: 0x7FFAC9083C30
        public void XsdKatmaiDateTimeOffsetToDateTimeOffset(){} // RVA: 0x7FFAC9083CB0
        public void XsdKatmaiTimeOffsetToDateTimeOffset(){} // RVA: 0x7FFAC9083DE0
        public void XsdKatmaiDateToString(){} // RVA: 0x7FFAC9083E60
        public void XsdKatmaiDateTimeToString(){} // RVA: 0x7FFAC9084170
        public void XsdKatmaiTimeToString(){} // RVA: 0x7FFAC9084580
        public void XsdKatmaiDateOffsetToString(){} // RVA: 0x7FFAC9084870
        public void XsdKatmaiDateTimeOffsetToString(){} // RVA: 0x7FFAC9084A80
        public void XsdKatmaiTimeOffsetToString(){} // RVA: 0x7FFAC9084D20
        public void GetKatmaiDateTicks(){} // RVA: 0x7FFAC9084F50
        public void GetKatmaiTimeTicks(){} // RVA: 0x7FFAC9084FC0
        public void GetKatmaiTimeZoneTicks(){} // RVA: 0x7FFAC9085210
        public void GetFractions(){} // RVA: 0x7FFAC90854B0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9085640
    }

    public class BinXmlSqlDecimal : ValueType
    {
        public byte IsPositive; // 0x10
        public byte m_bPrec; // 0x11
        public byte m_bScale; // 0x12
        public byte m_bSign; // 0x13
        public uint m_data1; // 0x14
        public uint m_data2; // 0x18
        public uint m_data3; // 0x1C
        public uint m_data4; // 0x20
        public byte NUMERIC_MAX_PRECISION;
        public byte MaxPrecision; // 0x1
        public byte MaxScale; // 0x2
        public int x_cNumeMax; // 0x4
        public long x_lInt32Base; // 0x8
        public ulong x_ulInt32Base; // 0x10
        public ulong x_ulInt32BaseForMod; // 0x18
        public ulong x_llMax; // 0x20
        public double DUINT_BASE; // 0x28
        public double DUINT_BASE2; // 0x30
        public double DUINT_BASE3; // 0x38
        public uint[] x_rgulShiftBase; // 0x40
        public byte[] rgCLenFromPrec; // 0x48

        // ── Methods ──
        public void get_IsPositive(){} // RVA: 0x7FFAC90808F0
        public void .ctor(){} // RVA: 0x7FFAC9080900
        public void UIntFromByteArray(){} // RVA: 0x7FFAC845D750
        public void MpDiv1(){} // RVA: 0x7FFAC9080C90
        public void MpNormalize(){} // RVA: 0x7FFAC8F181E0
        public void ChFromDigit(){} // RVA: 0x7FFAC8F19AF0
        public void ToDecimal(){} // RVA: 0x7FFAC9080D90
        public void TrimTrailingZeros(){} // RVA: 0x7FFAC9080EA0
        public void ToString(){} // RVA: 0x7FFAC9081100
        public void .cctor(){} // RVA: 0x7FFAC9081490
    }

    public class BinXmlSqlMoney : ValueType
    {
        public long data; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45BB120 | overloaded x2
        public void ToDecimal(){} // RVA: 0x7FFAC9081740
        public void ToString(){} // RVA: 0x7FFAC9081780
    }

    public class BinaryCompatibility : Object
    {
        public object TargetsAtLeast_Desktop_V4_5_2;

        // ── Methods ──
        public void get_TargetsAtLeast_Desktop_V4_5_2(){} // RVA: 0x7FFAC3006850
    }

    public class BitStack : Object
    {
        public uint[] bitStack; // 0x10
        public int stackPos; // 0x18
        public uint curr; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC43DADB0
        public void PushBit(){} // RVA: 0x7FFAC90943B0
        public void PopBit(){} // RVA: 0x7FFAC90943F0
        public void PeekBit(){} // RVA: 0x7FFAC9094450
        public void PushCurr(){} // RVA: 0x7FFAC9094460
        public void PopCurr(){} // RVA: 0x7FFAC9094710
    }

    public class Bits : Object
    {
        public uint MASK_0101010101010101;
        public uint MASK_0011001100110011; // 0x4
        public uint MASK_0000111100001111; // 0x8
        public uint MASK_0000000011111111; // 0xC
        public uint MASK_1111111111111111; // 0x10

        // ── Methods ──
        public void Count(){} // RVA: 0x7FFAC9094750
        public void LeastPosition(){} // RVA: 0x7FFAC9094800
        public void .cctor(){} // RVA: 0x7FFAC9094910
    }

    public class ByteStack : Object
    {
        public byte[] stack; // 0x10
        public int growthRate; // 0x18
        public int top; // 0x1C
        public int size; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90949B0
        public void Push(){} // RVA: 0x7FFAC9094A50
        public void Pop(){} // RVA: 0x7FFAC9094B60
    }

}