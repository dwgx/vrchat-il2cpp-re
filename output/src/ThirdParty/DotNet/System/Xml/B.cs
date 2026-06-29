// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 10
// Methods: 67

namespace ThirdParty.DotNet.System.Xml
{
    public class Base64Encoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6D74F0
        public void WriteChars(){} // RVA: 0x7A7E1E220
        public void Encode(){} // RVA: 0x7AE6D7580
        public void Flush(){} // RVA: 0x7AE6D79C0
    }

    public class BinHexDecoder : IncrementalReadDecoder
    {
        // ── Methods ──
        public void get_IsFull(){} // RVA: 0x7A97F71E0
        public void Decode(){} // RVA: 0x7AE6D7FA0
    }

    public class BinHexEncoder : Object
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x7AE6D8540
    }

    public class BinXmlDateTime : Object
    {
        // ── Methods ──
        public void Write2Dig(){} // RVA: 0x7ADC6E7D0
        public void Write4DigNeg(){} // RVA: 0x7AE6D9730
        public void Write3Dec(){} // RVA: 0x7AE6D97E0
        public void WriteDate(){} // RVA: 0x7AE6D99E0
        public void WriteTime(){} // RVA: 0x7AE6D9BC0
        public void WriteTimeFullPrecision(){} // RVA: 0x7AE6D9D30
        public void WriteTimeZone(){} // RVA: 0x7AE6DA150
        public void BreakDownXsdDateTime(){} // RVA: 0x7AE6DA290
        public void BreakDownXsdDate(){} // RVA: 0x7AE6DA4C0
        public void BreakDownXsdTime(){} // RVA: 0x7AE6DA670
        public void XsdDateTimeToString(){} // RVA: 0x7AE6DA7C0
        public void XsdDateToString(){} // RVA: 0x7AE6DABC0
        public void XsdTimeToString(){} // RVA: 0x7AE6DAF60
        public void SqlDateTimeToString(){} // RVA: 0x7AE6DB200
        public void SqlDateTimeToDateTime(){} // RVA: 0x7AE6DB410
        public void SqlSmallDateTimeToString(){} // RVA: 0x7AE6DB560
        public void SqlSmallDateTimeToDateTime(){} // RVA: 0x7AE6DB710
        public void XsdKatmaiDateToDateTime(){} // RVA: 0x7AE6DB790
        public void XsdKatmaiDateTimeToDateTime(){} // RVA: 0x7AE6DB8B0
        public void XsdKatmaiTimeToDateTime(){} // RVA: 0x7AE6DB9F0
        public void XsdKatmaiDateOffsetToDateTimeOffset(){} // RVA: 0x7AE6DBA50
        public void XsdKatmaiDateTimeOffsetToDateTimeOffset(){} // RVA: 0x7AE6DBAD0
        public void XsdKatmaiTimeOffsetToDateTimeOffset(){} // RVA: 0x7AE6DBC00
        public void XsdKatmaiDateToString(){} // RVA: 0x7AE6DBC80
        public void XsdKatmaiDateTimeToString(){} // RVA: 0x7AE6DBFA0
        public void XsdKatmaiTimeToString(){} // RVA: 0x7AE6DC3C0
        public void XsdKatmaiDateOffsetToString(){} // RVA: 0x7AE6DC6C0
        public void XsdKatmaiDateTimeOffsetToString(){} // RVA: 0x7AE6DC8D0
        public void XsdKatmaiTimeOffsetToString(){} // RVA: 0x7AE6DCB70
        public void GetKatmaiDateTicks(){} // RVA: 0x7AE6DCDB0
        public void GetKatmaiTimeTicks(){} // RVA: 0x7AE6DCE20
        public void GetKatmaiTimeZoneTicks(){} // RVA: 0x7AE6DD070
        public void GetFractions(){} // RVA: 0x7AE6DD310
        public void .cctor(){} // RVA: 0x7AE6DD4A0
    }

    public class BinXmlSqlDecimal : ValueType
    {
        // ── Methods ──
        public void get_IsPositive(){} // RVA: 0x7A7E931B0
        public void .ctor(){} // RVA: 0x7A7E931C0
        public void UIntFromByteArray(){} // RVA: 0x7ADAB4360
        public void MpDiv1(){} // RVA: 0x7AE6D8A50
        public void MpNormalize(){} // RVA: 0x7AE56F8D0
        public void ChFromDigit(){} // RVA: 0x7AE571250
        public void ToDecimal(){} // RVA: 0x7A7E931D0
        public void TrimTrailingZeros(){} // RVA: 0x7A7E93200
        public void ToString(){} // RVA: 0x7A7E93210
        public void .cctor(){} // RVA: 0x7AE6D9250
    }

    public class BinXmlSqlMoney : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A767FEF0
        public void ToDecimal(){} // RVA: 0x7A7E93220
        public void ToString(){} // RVA: 0x7A7E93270
    }

    public class BinaryCompatibility : Object
    {
        // ── Methods ──
        public void get_TargetsAtLeast_Desktop_V4_5_2(){} // RVA: 0x7A81BD750
    }

    public class BitStack : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A96E54B0
        public void PushBit(){} // RVA: 0x7AE6EC370
        public void PopBit(){} // RVA: 0x7AE6EC3B0
        public void PeekBit(){} // RVA: 0x7AE6EC410
        public void PushCurr(){} // RVA: 0x7AE6EC420
        public void PopCurr(){} // RVA: 0x7AE6EC6D0
    }

    public class Bits : Object
    {
        // ── Methods ──
        public void Count(){} // RVA: 0x7AE6EC710
        public void LeastPosition(){} // RVA: 0x7AE6EC7C0
        public void .cctor(){} // RVA: 0x7AE6EC8D0
    }

    public class ByteStack : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6EC970
        public void Push(){} // RVA: 0x7AE6ECA10
        public void Pop(){} // RVA: 0x7AE6ECB20
    }

}