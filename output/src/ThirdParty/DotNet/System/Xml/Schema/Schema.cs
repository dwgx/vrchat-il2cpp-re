// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 3
// Methods: 197

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class XmlBaseConverter : XmlValueConverter
    {
        public object SchemaType;
        public object TypeCode;
        public object XmlTypeName;
        public object DefaultClrType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5457E520 | overloaded x4
        public void ToBoolean(){} // RVA: 0x7FFD5457EAD0 | overloaded x6
        public void ToDateTime(){} // RVA: 0x7FFD5457F160 | overloaded x7
        public void ToDateTimeOffset(){} // RVA: 0x7FFD5457F420 | overloaded x3
        public void ToDecimal(){} // RVA: 0x7FFD5457F5E0 | overloaded x2
        public void ToDouble(){} // RVA: 0x7FFD5457FB90 | overloaded x6
        public void ToInt32(){} // RVA: 0x7FFD54580100 | overloaded x6
        public void ToInt64(){} // RVA: 0x7FFD54580670 | overloaded x6
        public void ToSingle(){} // RVA: 0x7FFD54580910 | overloaded x3
        public void ToString(){} // RVA: 0x7FFD54581230 | overloaded x10
        public void ChangeType(){} // RVA: 0x7FFD545815D0 | overloaded x8
        public void get_SchemaType(){} // RVA: 0x7FFD4E35C380
        public void get_TypeCode(){} // RVA: 0x7FFD4E577800
        public void get_XmlTypeName(){} // RVA: 0x7FFD54581600
        public void get_DefaultClrType(){} // RVA: 0x7FFD4E36F0C0
        public void IsDerivedFrom(){} // RVA: 0x7FFD54581710
        public void CreateInvalidClrMappingException(){} // RVA: 0x7FFD545817C0
        public void QNameToString(){} // RVA: 0x7FFD545837A0 | overloaded x2
        public void ChangeListType(){} // RVA: 0x7FFD54581C30
        public void StringToBase64Binary(){} // RVA: 0x7FFD54581C90
        public void StringToDate(){} // RVA: 0x7FFD54581DB0
        public void StringToDateTime(){} // RVA: 0x7FFD54581E30
        public void StringToDayTimeDuration(){} // RVA: 0x7FFD54581EB0
        public void StringToDuration(){} // RVA: 0x7FFD54581FB0
        public void StringToGDay(){} // RVA: 0x7FFD545820B0
        public void StringToGMonth(){} // RVA: 0x7FFD54582130
        public void StringToGMonthDay(){} // RVA: 0x7FFD545821B0
        public void StringToGYear(){} // RVA: 0x7FFD54582230
        public void StringToGYearMonth(){} // RVA: 0x7FFD545822B0
        public void StringToDateOffset(){} // RVA: 0x7FFD54582330
        public void StringToDateTimeOffset(){} // RVA: 0x7FFD545823D0
        public void StringToGDayOffset(){} // RVA: 0x7FFD54582470
        public void StringToGMonthOffset(){} // RVA: 0x7FFD54582510
        public void StringToGMonthDayOffset(){} // RVA: 0x7FFD545825B0
        public void StringToGYearOffset(){} // RVA: 0x7FFD54582650
        public void StringToGYearMonthOffset(){} // RVA: 0x7FFD545826F0
        public void StringToHexBinary(){} // RVA: 0x7FFD54582790
        public void StringToQName(){} // RVA: 0x7FFD545828C0
        public void StringToTime(){} // RVA: 0x7FFD54582BC0
        public void StringToTimeOffset(){} // RVA: 0x7FFD54582C40
        public void StringToYearMonthDuration(){} // RVA: 0x7FFD54582CE0
        public void AnyUriToString(){} // RVA: 0x7FFD54582DE0
        public void Base64BinaryToString(){} // RVA: 0x7FFD54582E50
        public void DateToString(){} // RVA: 0x7FFD54582F60
        public void DateTimeToString(){} // RVA: 0x7FFD54582FE0
        public void DayTimeDurationToString(){} // RVA: 0x7FFD54583060
        public void DurationToString(){} // RVA: 0x7FFD545830D0
        public void GDayToString(){} // RVA: 0x7FFD54583130
        public void GMonthToString(){} // RVA: 0x7FFD545831B0
        public void GMonthDayToString(){} // RVA: 0x7FFD54583230
        public void GYearToString(){} // RVA: 0x7FFD545832B0
        public void GYearMonthToString(){} // RVA: 0x7FFD54583330
        public void DateOffsetToString(){} // RVA: 0x7FFD545833B0
        public void DateTimeOffsetToString(){} // RVA: 0x7FFD54583440
        public void GDayOffsetToString(){} // RVA: 0x7FFD545834D0
        public void GMonthOffsetToString(){} // RVA: 0x7FFD54583560
        public void GMonthDayOffsetToString(){} // RVA: 0x7FFD545835F0
        public void GYearOffsetToString(){} // RVA: 0x7FFD54583680
        public void GYearMonthOffsetToString(){} // RVA: 0x7FFD54583710
        public void TimeToString(){} // RVA: 0x7FFD54583990
        public void TimeOffsetToString(){} // RVA: 0x7FFD54583A10
        public void YearMonthDurationToString(){} // RVA: 0x7FFD54583AA0
        public void DateTimeOffsetToDateTime(){} // RVA: 0x7FFD54583B10
        public void DecimalToInt32(){} // RVA: 0x7FFD54583B60
        public void DecimalToInt64(){} // RVA: 0x7FFD54583DE0
        public void DecimalToUInt64(){} // RVA: 0x7FFD54584070
        public void Int32ToByte(){} // RVA: 0x7FFD545842F0
        public void Int32ToInt16(){} // RVA: 0x7FFD545843F0
        public void Int32ToSByte(){} // RVA: 0x7FFD545844F0
        public void Int32ToUInt16(){} // RVA: 0x7FFD545845F0
        public void Int64ToInt32(){} // RVA: 0x7FFD545846F0
        public void Int64ToUInt32(){} // RVA: 0x7FFD545847F0
        public void UntypedAtomicToDateTime(){} // RVA: 0x7FFD545848F0
        public void UntypedAtomicToDateTimeOffset(){} // RVA: 0x7FFD54584970
        public void .cctor(){} // RVA: 0x7FFD54584A10
    }

    public class XmlListConverter : XmlBaseConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5459EB20 | overloaded x3
        public void Create(){} // RVA: 0x7FFD5459EB80
        public void ChangeType(){} // RVA: 0x7FFD5459ED60
        public void ChangeListType(){} // RVA: 0x7FFD5459EE90
        public void IsListType(){} // RVA: 0x7FFD5459FDC0
        public void ToArray(){} // RVA: 0x7FFD4E08A6F0
        public void ToList(){} // RVA: 0x7FFD5459FF50
        public void StringAsList(){} // RVA: 0x7FFD545A04E0
        public void ListAsString(){} // RVA: 0x7FFD545A0590
        public void CreateInvalidClrMappingException(){} // RVA: 0x7FFD545A0840
    }

    public class XmlValueConverter : Object
    {
        // ── Methods ──
        public void ToBoolean(){} // RVA: 0x7FFD4E079F60 | overloaded x6
        public void ToInt32(){} // RVA: 0x7FFD4E07E6B0 | overloaded x6
        public void ToInt64(){} // RVA: 0x7FFD4E078F40 | overloaded x6
        public void ToDecimal(){} // overloaded x2
        public void ToDouble(){} // RVA: 0x7FFD4E07EF00 | overloaded x6
        public void ToSingle(){} // RVA: 0x7FFD4E08DF90 | overloaded x3
        public void ToDateTime(){} // overloaded x7
        public void ToDateTimeOffset(){} // overloaded x3
        public void ToString(){} // RVA: 0x7FFD4E08A6F0 | overloaded x10
        public void ChangeType(){} // RVA: 0x7FFD4E08AE80 | overloaded x9
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}