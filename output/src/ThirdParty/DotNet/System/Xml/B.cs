// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml
// Classes: 10
// Methods: 74

namespace ThirdParty.DotNet.System.Xml
{
    public class Base64Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9398C60
        public void WriteChars(){}
        public void Encode(){} // RVA: 0x7FFAF9398CF0
        public void Flush(){} // RVA: 0x7FFAF9399110
    }

    public class BinHexDecoder
    {
        // ── Methods ──
        public void get_IsFull(){} // RVA: 0x7FFAF44EDB40
        public void Decode(){} // RVA: 0x7FFAF93996F0 | overloaded x3
    }

    public class BinHexEncoder
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x7FFAF9399C90 | overloaded x3
    }

    public class BinXmlDateTime
    {
        // ── Methods ──
        public void Write2Dig(){} // RVA: 0x7FFAF892FD50
        public void Write4DigNeg(){} // RVA: 0x7FFAF939AE50
        public void Write3Dec(){} // RVA: 0x7FFAF939AF00
        public void WriteDate(){} // RVA: 0x7FFAF939B0F0
        public void WriteTime(){} // RVA: 0x7FFAF939B2D0
        public void WriteTimeFullPrecision(){} // RVA: 0x7FFAF939B440
        public void WriteTimeZone(){} // RVA: 0x7FFAF939B860 | overloaded x2
        public void BreakDownXsdDateTime(){} // RVA: 0x7FFAF939B9A0
        public void BreakDownXsdDate(){} // RVA: 0x7FFAF939BBC0
        public void BreakDownXsdTime(){} // RVA: 0x7FFAF939BD70
        public void XsdDateTimeToString(){} // RVA: 0x7FFAF939BEC0
        public void XsdDateToString(){} // RVA: 0x7FFAF939C2B0
        public void XsdTimeToString(){} // RVA: 0x7FFAF939C630
        public void SqlDateTimeToString(){} // RVA: 0x7FFAF939C8C0
        public void SqlDateTimeToDateTime(){} // RVA: 0x7FFAF939CAD0
        public void SqlSmallDateTimeToString(){} // RVA: 0x7FFAF939CC20
        public void SqlSmallDateTimeToDateTime(){} // RVA: 0x7FFAF939CDD0
        public void XsdKatmaiDateToDateTime(){} // RVA: 0x7FFAF939CE50
        public void XsdKatmaiDateTimeToDateTime(){} // RVA: 0x7FFAF939CF70
        public void XsdKatmaiTimeToDateTime(){} // RVA: 0x7FFAF939D0B0
        public void XsdKatmaiDateOffsetToDateTimeOffset(){} // RVA: 0x7FFAF939D110
        public void XsdKatmaiDateTimeOffsetToDateTimeOffset(){} // RVA: 0x7FFAF939D190
        public void XsdKatmaiTimeOffsetToDateTimeOffset(){} // RVA: 0x7FFAF939D2C0
        public void XsdKatmaiDateToString(){} // RVA: 0x7FFAF939D340
        public void XsdKatmaiDateTimeToString(){} // RVA: 0x7FFAF939D650
        public void XsdKatmaiTimeToString(){} // RVA: 0x7FFAF939DA60
        public void XsdKatmaiDateOffsetToString(){} // RVA: 0x7FFAF939DD50
        public void XsdKatmaiDateTimeOffsetToString(){} // RVA: 0x7FFAF939DF60
        public void XsdKatmaiTimeOffsetToString(){} // RVA: 0x7FFAF939E200
        public void GetKatmaiDateTicks(){} // RVA: 0x7FFAF939E430
        public void GetKatmaiTimeTicks(){} // RVA: 0x7FFAF939E4A0
        public void GetKatmaiTimeZoneTicks(){} // RVA: 0x7FFAF939E6F0
        public void GetFractions(){} // RVA: 0x7FFAF939E990 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF939EB20
    }

    public class BinXmlSqlDecimal
    {
        // ── Methods ──
        public void get_IsPositive(){} // RVA: 0x7FFAF9399DD0
        public void .ctor(){} // RVA: 0x7FFAF9399DE0
        public void UIntFromByteArray(){} // RVA: 0x7FFAF8776160
        public void MpDiv1(){} // RVA: 0x7FFAF939A170
        public void MpNormalize(){} // RVA: 0x7FFAF9231730
        public void ChFromDigit(){} // RVA: 0x7FFAF9233040
        public void ToDecimal(){} // RVA: 0x7FFAF939A270
        public void TrimTrailingZeros(){} // RVA: 0x7FFAF939A380
        public void ToString(){} // RVA: 0x7FFAF939A5E0
        public void .cctor(){} // RVA: 0x7FFAF939A970
    }

    public class BinXmlSqlMoney
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45C2320 | overloaded x2
        public void ToDecimal(){} // RVA: 0x7FFAF939AC20
        public void ToString(){} // RVA: 0x7FFAF939AC60
    }

    public class BinaryCompatibility
    {
        // ── Methods ──
        public void get_TargetsAtLeast_Desktop_V4_5_2(){} // RVA: 0x7FFAF2E72850
    }

    public class BitStack
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF43D95C0
        public void PushBit(){} // RVA: 0x7FFAF93AD890
        public void PopBit(){} // RVA: 0x7FFAF93AD8D0
        public void PeekBit(){} // RVA: 0x7FFAF93AD930
        public void PushCurr(){} // RVA: 0x7FFAF93AD940
        public void PopCurr(){} // RVA: 0x7FFAF93ADBF0
    }

    public class Bits
    {
        // ── Methods ──
        public void Count(){} // RVA: 0x7FFAF93ADC30
        public void LeastPosition(){} // RVA: 0x7FFAF93ADCE0
        public void .cctor(){} // RVA: 0x7FFAF93ADDF0
    }

    public class ByteStack
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF93ADE90
        public void Push(){} // RVA: 0x7FFAF93ADF30
        public void Pop(){} // RVA: 0x7FFAF93AE040
    }

}