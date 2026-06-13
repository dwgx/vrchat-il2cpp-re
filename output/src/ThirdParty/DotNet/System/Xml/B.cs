// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 10
// Methods: 74

namespace ThirdParty.DotNet.System.Xml
{
    public class Base64Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68E8C60
        public void WriteChars(){}
        public void Encode(){} // RVA: 0x68E8CF0
        public void Flush(){} // RVA: 0x68E9110
    }

    public class BinHexDecoder
    {
        public byte[] buffer; // 0x10

        // ── Methods ──
        public void get_IsFull(){} // RVA: 0x1A3DB40
        public void Decode(){} // RVA: 0x68E96F0 | overloaded x3
    }

    public class BinHexEncoder
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x68E9C90 | overloaded x3
    }

    public class BinXmlDateTime
    {
        // ── Methods ──
        public void Write2Dig(){} // RVA: 0x5E7FD50
        public void Write4DigNeg(){} // RVA: 0x68EAE50
        public void Write3Dec(){} // RVA: 0x68EAF00
        public void WriteDate(){} // RVA: 0x68EB0F0
        public void WriteTime(){} // RVA: 0x68EB2D0
        public void WriteTimeFullPrecision(){} // RVA: 0x68EB440
        public void WriteTimeZone(){} // RVA: 0x68EB860 | overloaded x2
        public void BreakDownXsdDateTime(){} // RVA: 0x68EB9A0
        public void BreakDownXsdDate(){} // RVA: 0x68EBBC0
        public void BreakDownXsdTime(){} // RVA: 0x68EBD70
        public void XsdDateTimeToString(){} // RVA: 0x68EBEC0
        public void XsdDateToString(){} // RVA: 0x68EC2B0
        public void XsdTimeToString(){} // RVA: 0x68EC630
        public void SqlDateTimeToString(){} // RVA: 0x68EC8C0
        public void SqlDateTimeToDateTime(){} // RVA: 0x68ECAD0
        public void SqlSmallDateTimeToString(){} // RVA: 0x68ECC20
        public void SqlSmallDateTimeToDateTime(){} // RVA: 0x68ECDD0
        public void XsdKatmaiDateToDateTime(){} // RVA: 0x68ECE50
        public void XsdKatmaiDateTimeToDateTime(){} // RVA: 0x68ECF70
        public void XsdKatmaiTimeToDateTime(){} // RVA: 0x68ED0B0
        public void XsdKatmaiDateOffsetToDateTimeOffset(){} // RVA: 0x68ED110
        public void XsdKatmaiDateTimeOffsetToDateTimeOffset(){} // RVA: 0x68ED190
        public void XsdKatmaiTimeOffsetToDateTimeOffset(){} // RVA: 0x68ED2C0
        public void XsdKatmaiDateToString(){} // RVA: 0x68ED340
        public void XsdKatmaiDateTimeToString(){} // RVA: 0x68ED650
        public void XsdKatmaiTimeToString(){} // RVA: 0x68EDA60
        public void XsdKatmaiDateOffsetToString(){} // RVA: 0x68EDD50
        public void XsdKatmaiDateTimeOffsetToString(){} // RVA: 0x68EDF60
        public void XsdKatmaiTimeOffsetToString(){} // RVA: 0x68EE200
        public void GetKatmaiDateTicks(){} // RVA: 0x68EE430
        public void GetKatmaiTimeTicks(){} // RVA: 0x68EE4A0
        public void GetKatmaiTimeZoneTicks(){} // RVA: 0x68EE6F0
        public void GetFractions(){} // RVA: 0x68EE990 | overloaded x2
        public void .cctor(){} // RVA: 0x68EEB20
    }

    public class BinXmlSqlDecimal
    {
        public byte m_bLen; // 0x10

        // ── Methods ──
        public void get_IsPositive(){} // RVA: 0x68E9DD0
        public void .ctor(){} // RVA: 0x68E9DE0
        public void UIntFromByteArray(){} // RVA: 0x5CC6160
        public void MpDiv1(){} // RVA: 0x68EA170
        public void MpNormalize(){} // RVA: 0x6781730
        public void ChFromDigit(){} // RVA: 0x6783040
        public void ToDecimal(){} // RVA: 0x68EA270
        public void TrimTrailingZeros(){} // RVA: 0x68EA380
        public void ToString(){} // RVA: 0x68EA5E0
        public void .cctor(){} // RVA: 0x68EA970
    }

    public class BinXmlSqlMoney
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1B12320 | overloaded x2
        public void ToDecimal(){} // RVA: 0x68EAC20
        public void ToString(){} // RVA: 0x68EAC60
    }

    public class BinaryCompatibility
    {
        // ── Methods ──
        public void get_TargetsAtLeast_Desktop_V4_5_2(){} // RVA: 0x3C2850
    }

    public class BitStack
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x19295C0
        public void PushBit(){} // RVA: 0x68FD890
        public void PopBit(){} // RVA: 0x68FD8D0
        public void PeekBit(){} // RVA: 0x68FD930
        public void PushCurr(){} // RVA: 0x68FD940
        public void PopCurr(){} // RVA: 0x68FDBF0
    }

    public class Bits
    {
        // ── Methods ──
        public void Count(){} // RVA: 0x68FDC30
        public void LeastPosition(){} // RVA: 0x68FDCE0
        public void .cctor(){} // RVA: 0x68FDDF0
    }

    public class ByteStack
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68FDE90
        public void Push(){} // RVA: 0x68FDF30
        public void Pop(){} // RVA: 0x68FE040
    }

}