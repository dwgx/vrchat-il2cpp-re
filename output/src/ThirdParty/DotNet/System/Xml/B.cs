// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 10
// Methods: 67

namespace ThirdParty.DotNet.System.Xml
{
    public class Base64Encoder : Object
    {
        public object leftOverBytes;
        public object leftOverBytesCount;
        public object charsLine;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x734D660
        public void WriteChars(){} // RVA: 0x89B9B0
        public void Encode(){} // RVA: 0x734D6F0
        public void Flush(){} // RVA: 0x734DB30
    }

    public class BinHexDecoder : IncrementalReadDecoder
    {
        public object buffer;
        public object curIndex;
        public object endIndex;
        public object hasHalfByteCached;
        public object cachedHalfByte;

        // ── Methods ──
        public void get_IsFull(){} // RVA: 0x2301D80
        public void Decode(){} // RVA: 0x734E110
    }

    public class BinHexEncoder : Object
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x734E6B0
    }

    public class BinXmlDateTime : Object
    {
        public object KatmaiTimeScaleMultiplicator;
        public object SQLTicksPerMillisecond;
        public object SQLTicksPerSecond;
        public object SQLTicksPerMinute;
        public object SQLTicksPerHour;
        public object SQLTicksPerDay;

        // ── Methods ──
        public void Write2Dig(){} // RVA: 0x68F8FE0
        public void Write4DigNeg(){} // RVA: 0x734F920
        public void Write3Dec(){} // RVA: 0x734F9D0
        public void WriteDate(){} // RVA: 0x734FBD0
        public void WriteTime(){} // RVA: 0x734FDB0
        public void WriteTimeFullPrecision(){} // RVA: 0x734FF20
        public void WriteTimeZone(){} // RVA: 0x7350340
        public void BreakDownXsdDateTime(){} // RVA: 0x7350480
        public void BreakDownXsdDate(){} // RVA: 0x73506B0
        public void BreakDownXsdTime(){} // RVA: 0x7350860
        public void XsdDateTimeToString(){} // RVA: 0x73509B0
        public void XsdDateToString(){} // RVA: 0x7350DB0
        public void XsdTimeToString(){} // RVA: 0x7351150
        public void SqlDateTimeToString(){} // RVA: 0x73513F0
        public void SqlDateTimeToDateTime(){} // RVA: 0x7351600
        public void SqlSmallDateTimeToString(){} // RVA: 0x7351750
        public void SqlSmallDateTimeToDateTime(){} // RVA: 0x7351900
        public void XsdKatmaiDateToDateTime(){} // RVA: 0x7351980
        public void XsdKatmaiDateTimeToDateTime(){} // RVA: 0x7351AA0
        public void XsdKatmaiTimeToDateTime(){} // RVA: 0x7351BE0
        public void XsdKatmaiDateOffsetToDateTimeOffset(){} // RVA: 0x7351C40
        public void XsdKatmaiDateTimeOffsetToDateTimeOffset(){} // RVA: 0x7351CC0
        public void XsdKatmaiTimeOffsetToDateTimeOffset(){} // RVA: 0x7351DF0
        public void XsdKatmaiDateToString(){} // RVA: 0x7351E70
        public void XsdKatmaiDateTimeToString(){} // RVA: 0x7352190
        public void XsdKatmaiTimeToString(){} // RVA: 0x73525B0
        public void XsdKatmaiDateOffsetToString(){} // RVA: 0x73528B0
        public void XsdKatmaiDateTimeOffsetToString(){} // RVA: 0x7352AC0
        public void XsdKatmaiTimeOffsetToString(){} // RVA: 0x7352D60
        public void GetKatmaiDateTicks(){} // RVA: 0x7352FA0
        public void GetKatmaiTimeTicks(){} // RVA: 0x7353010
        public void GetKatmaiTimeZoneTicks(){} // RVA: 0x7353260
        public void GetFractions(){} // RVA: 0x7353500
        public void .cctor(){} // RVA: 0x7353690
    }

    public class BinXmlSqlDecimal : ValueType
    {
        public object m_bLen;
        public object m_bPrec;
        public object m_bScale;
        public object m_bSign;
        public object m_data1;
        public object m_data2;
        public object m_data3;
        public object m_data4;
        public object NUMERIC_MAX_PRECISION;
        public object MaxPrecision;
        public object MaxScale;
        public object x_cNumeMax;
        public object x_lInt32Base;
        public object x_ulInt32Base;
        public object x_ulInt32BaseForMod;
        public object x_llMax;
        public object DUINT_BASE;
        public object DUINT_BASE2;
        public object DUINT_BASE3;
        public object x_rgulShiftBase;
        public object rgCLenFromPrec;

        // ── Methods ──
        public void get_IsPositive(){} // RVA: 0x912F40
        public void .ctor(){} // RVA: 0x912F50
        public void UIntFromByteArray(){} // RVA: 0x673F770
        public void MpDiv1(){} // RVA: 0x734EBC0
        public void MpNormalize(){} // RVA: 0x71E8190
        public void ChFromDigit(){} // RVA: 0x71E9B10
        public void ToDecimal(){} // RVA: 0x912F60
        public void TrimTrailingZeros(){} // RVA: 0x912F90
        public void ToString(){} // RVA: 0x912FA0
        public void .cctor(){} // RVA: 0x734F440
    }

    public class BinXmlSqlMoney : ValueType
    {
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x93050
        public void ToDecimal(){} // RVA: 0x912FB0
        public void ToString(){} // RVA: 0x913000
    }

    public class BinaryCompatibility : Object
    {
        // ── Methods ──
        public void get_TargetsAtLeast_Desktop_V4_5_2(){} // RVA: 0xC2E4C0
    }

    public class BitStack : Object
    {
        public object bitStack;
        public object stackPos;
        public object curr;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x21EAED0
        public void PushBit(){} // RVA: 0x73621F0
        public void PopBit(){} // RVA: 0x7362230
        public void PeekBit(){} // RVA: 0x7362290
        public void PushCurr(){} // RVA: 0x73622A0
        public void PopCurr(){} // RVA: 0x7362550
    }

    public class Bits : Object
    {
        public object MASK_0101010101010101;
        public object MASK_0011001100110011;
        public object MASK_0000111100001111;
        public object MASK_0000000011111111;
        public object MASK_1111111111111111;

        // ── Methods ──
        public void Count(){} // RVA: 0x7362590
        public void LeastPosition(){} // RVA: 0x7362640
        public void .cctor(){} // RVA: 0x7362750
    }

    public class ByteStack : Object
    {
        public object stack;
        public object growthRate;
        public object top;
        public object size;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x73627F0
        public void Push(){} // RVA: 0x7362890
        public void Pop(){} // RVA: 0x73629A0
    }

}