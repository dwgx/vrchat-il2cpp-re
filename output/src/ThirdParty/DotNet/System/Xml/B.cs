// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 10
// Methods: 74

namespace ThirdParty.DotNet.System.Xml
{
    public class Base64Encoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87427F30
        public void WriteChars(){}
        public void Encode(){} // RVA: 0x7FFE87427FC0
        public void Flush(){} // RVA: 0x7FFE874283E0
    }

    public class BinHexDecoder : IncrementalReadDecoder
    {
        public byte[] buffer; // 0x10

        // ── Methods ──
        public void get_IsFull(){} // RVA: 0x7FFE827C3B60
        public void Decode(){} // RVA: 0x7FFE874289C0 | overloaded x3
    }

    public class BinHexEncoder : Object
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x7FFE87428F60 | overloaded x3
    }

    public class BinXmlDateTime : Object
    {
        // ── Methods ──
        public void Write2Dig(){} // RVA: 0x7FFE869C0B90
        public void Write4DigNeg(){} // RVA: 0x7FFE8742A120
        public void Write3Dec(){} // RVA: 0x7FFE8742A1D0
        public void WriteDate(){} // RVA: 0x7FFE8742A3C0
        public void WriteTime(){} // RVA: 0x7FFE8742A5A0
        public void WriteTimeFullPrecision(){} // RVA: 0x7FFE8742A710
        public void WriteTimeZone(){} // RVA: 0x7FFE8742AB30 | overloaded x2
        public void BreakDownXsdDateTime(){} // RVA: 0x7FFE8742AC70
        public void BreakDownXsdDate(){} // RVA: 0x7FFE8742AE90
        public void BreakDownXsdTime(){} // RVA: 0x7FFE8742B040
        public void XsdDateTimeToString(){} // RVA: 0x7FFE8742B190
        public void XsdDateToString(){} // RVA: 0x7FFE8742B580
        public void XsdTimeToString(){} // RVA: 0x7FFE8742B900
        public void SqlDateTimeToString(){} // RVA: 0x7FFE8742BB90
        public void SqlDateTimeToDateTime(){} // RVA: 0x7FFE8742BDA0
        public void SqlSmallDateTimeToString(){} // RVA: 0x7FFE8742BEF0
        public void SqlSmallDateTimeToDateTime(){} // RVA: 0x7FFE8742C0A0
        public void XsdKatmaiDateToDateTime(){} // RVA: 0x7FFE8742C120
        public void XsdKatmaiDateTimeToDateTime(){} // RVA: 0x7FFE8742C240
        public void XsdKatmaiTimeToDateTime(){} // RVA: 0x7FFE8742C380
        public void XsdKatmaiDateOffsetToDateTimeOffset(){} // RVA: 0x7FFE8742C3E0
        public void XsdKatmaiDateTimeOffsetToDateTimeOffset(){} // RVA: 0x7FFE8742C460
        public void XsdKatmaiTimeOffsetToDateTimeOffset(){} // RVA: 0x7FFE8742C590
        public void XsdKatmaiDateToString(){} // RVA: 0x7FFE8742C610
        public void XsdKatmaiDateTimeToString(){} // RVA: 0x7FFE8742C920
        public void XsdKatmaiTimeToString(){} // RVA: 0x7FFE8742CD30
        public void XsdKatmaiDateOffsetToString(){} // RVA: 0x7FFE8742D020
        public void XsdKatmaiDateTimeOffsetToString(){} // RVA: 0x7FFE8742D230
        public void XsdKatmaiTimeOffsetToString(){} // RVA: 0x7FFE8742D4D0
        public void GetKatmaiDateTicks(){} // RVA: 0x7FFE8742D700
        public void GetKatmaiTimeTicks(){} // RVA: 0x7FFE8742D770
        public void GetKatmaiTimeZoneTicks(){} // RVA: 0x7FFE8742D9C0
        public void GetFractions(){} // RVA: 0x7FFE8742DC60 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8742DDF0
    }

    public class BinXmlSqlDecimal : ValueType
    {
        public byte m_bLen; // 0x10

        // ── Methods ──
        public void get_IsPositive(){} // RVA: 0x7FFE874290A0
        public void .ctor(){} // RVA: 0x7FFE874290B0
        public void UIntFromByteArray(){} // RVA: 0x7FFE86807060
        public void MpDiv1(){} // RVA: 0x7FFE87429440
        public void MpNormalize(){} // RVA: 0x7FFE872C0630
        public void ChFromDigit(){} // RVA: 0x7FFE872C1F40
        public void ToDecimal(){} // RVA: 0x7FFE87429540
        public void TrimTrailingZeros(){} // RVA: 0x7FFE87429650
        public void ToString(){} // RVA: 0x7FFE874298B0
        public void .cctor(){} // RVA: 0x7FFE87429C40
    }

    public class BinXmlSqlMoney : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82889220 | overloaded x2
        public void ToDecimal(){} // RVA: 0x7FFE87429EF0
        public void ToString(){} // RVA: 0x7FFE87429F30
    }

    public class BinaryCompatibility : Object
    {
        // ── Methods ──
        public void get_TargetsAtLeast_Desktop_V4_5_2(){} // RVA: 0x7FFE811E0850
    }

    public class BitStack : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE826ABFC0
        public void PushBit(){} // RVA: 0x7FFE8743CB60
        public void PopBit(){} // RVA: 0x7FFE8743CBA0
        public void PeekBit(){} // RVA: 0x7FFE8743CC00
        public void PushCurr(){} // RVA: 0x7FFE8743CC10
        public void PopCurr(){} // RVA: 0x7FFE8743CEC0
    }

    public class Bits : Object
    {
        // ── Methods ──
        public void Count(){} // RVA: 0x7FFE8743CF00
        public void LeastPosition(){} // RVA: 0x7FFE8743CFB0
        public void .cctor(){} // RVA: 0x7FFE8743D0C0
    }

    public class ByteStack : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8743D160
        public void Push(){} // RVA: 0x7FFE8743D200
        public void Pop(){} // RVA: 0x7FFE8743D310
    }

}