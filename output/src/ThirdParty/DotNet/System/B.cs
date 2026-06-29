// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 41
// Methods: 168

namespace ThirdParty.DotNet.System
{
    public class BadImageFormatException : SystemException
    {
        public object _fileName;
        public object _fusionLog;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67ED140
        public void GetObjectData(){} // RVA: 0x67ED2E0
        public void get_Message(){} // RVA: 0x67ED590
        public void SetMessageField(){} // RVA: 0x67ED6B0
        public void ToString(){} // RVA: 0x67ED7D0
    }

    public class BitConverter : Object
    {
        public object IsLittleEndian;

        // ── Methods ──
        public void GetBytes(){} // RVA: 0x67EDDC0
        public void TryWriteBytes(){} // RVA: 0x67EDC80
        public void ToChar(){} // RVA: 0x22F0340
        public void ToInt16(){} // RVA: 0x22F0340
        public void ToInt32(){} // RVA: 0x67EDE90
        public void ToInt64(){} // RVA: 0x67EDEF0
        public void ToUInt16(){} // RVA: 0x22F0340
        public void ToUInt32(){} // RVA: 0x67EDE30
        public void ToUInt64(){} // RVA: 0x67EDEF0
        public void ToSingle(){} // RVA: 0x67EDF50
        public void ToDouble(){} // RVA: 0x67EDFB0
        public void ToString(){} // RVA: 0x67EE590
        public void ToBoolean(){} // RVA: 0x67EE5C0
        public void DoubleToInt64Bits(){} // RVA: 0x67EE620
        public void Int64BitsToDouble(){} // RVA: 0x67EE630
        public void SingleToInt32Bits(){} // RVA: 0x67EE640
        public void Int32BitsToSingle(){} // RVA: 0x67EE650
        public void .cctor(){} // RVA: 0x67EE660
    }

    public class Boolean : ValueType
    {
        public object m_value;
        public object TrueString;
        public object FalseString;

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x8B08A0
        public void ToString(){} // RVA: 0x8B0910
        public void Equals(){} // RVA: 0x8B0980
        public void CompareTo(){} // RVA: 0x8B09A0
        public void Parse(){} // RVA: 0x67EECF0
        public void TryParse(){} // RVA: 0x67EEE30
        public void TrimWhiteSpaceAndNull(){} // RVA: 0x67EF1D0
        public void GetTypeCode(){} // RVA: 0x4238F0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x8B09C0
        public void System.IConvertible.ToChar(){} // RVA: 0x8B09D0
        public void System.IConvertible.ToSByte(){} // RVA: 0x8B09E0
        public void System.IConvertible.ToByte(){} // RVA: 0x8B0A30
        public void System.IConvertible.ToInt16(){} // RVA: 0x8B0A80
        public void System.IConvertible.ToUInt16(){} // RVA: 0x8B0AD0
        public void System.IConvertible.ToInt32(){} // RVA: 0x8B0B20
        public void System.IConvertible.ToUInt32(){} // RVA: 0x8B0B70
        public void System.IConvertible.ToInt64(){} // RVA: 0x8B0BC0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x8B0C10
        public void System.IConvertible.ToSingle(){} // RVA: 0x8B0C60
        public void System.IConvertible.ToDouble(){} // RVA: 0x8B0CC0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x8B0D20
        public void System.IConvertible.ToDateTime(){} // RVA: 0x8B0DE0
        public void System.IConvertible.ToType(){} // RVA: 0x8B0DF0
        public void .cctor(){} // RVA: 0x67EF920
    }

    public class Boolean[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAB820
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A700
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC7990
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E56EF0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A700
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Buffer : Object
    {
        // ── Methods ──
        public void InternalBlockCopy(){} // RVA: 0x694E9D0
        public void IndexOfByte(){} // RVA: 0x694EA90
        public void _ByteLength(){} // RVA: 0x694EB40
        public void ZeroMemory(){} // RVA: 0x694EB50
        public void Memcpy(){} // RVA: 0x694F450
        public void InternalMemcpy(){} // RVA: 0x694EBC0
        public void ByteLength(){} // RVA: 0x694EBD0
        public void GetByte(){} // RVA: 0x694EC80
        public void SetByte(){} // RVA: 0x694ED90
        public void BlockCopy(){} // RVA: 0x694EEB0
        public void MemoryCopy(){} // RVA: 0x694F160
        public void memcpy4(){} // RVA: 0x694F280
        public void memcpy2(){} // RVA: 0x694F320
        public void memcpy1(){} // RVA: 0x694F3A0
        public void Memmove(){} // RVA: 0x3017210
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void get_Value(){} // RVA: 0x87C0A0
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class ByReference`1 : ValueType
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3F2CC40
    }

    public class Byte : ValueType
    {
        public object m_value;

        // ── Methods ──
        public void CompareTo(){} // RVA: 0x8B0E90
        public void Equals(){} // RVA: 0x8B0980
        public void GetHashCode(){} // RVA: 0x90520
        public void Parse(){} // RVA: 0x67EFDD0
        public void TryParse(){} // RVA: 0x67F0060
        public void ToString(){} // RVA: 0x8B0F30
        public void TryFormat(){} // RVA: 0x8B0F40
        public void GetTypeCode(){} // RVA: 0x423C90
        public void System.IConvertible.ToBoolean(){} // RVA: 0x8B0FF0
        public void System.IConvertible.ToChar(){} // RVA: 0x8B1040
        public void System.IConvertible.ToSByte(){} // RVA: 0x8B1090
        public void System.IConvertible.ToByte(){} // RVA: 0x90520
        public void System.IConvertible.ToInt16(){} // RVA: 0x8B1120
        public void System.IConvertible.ToUInt16(){} // RVA: 0x8B1170
        public void System.IConvertible.ToInt32(){} // RVA: 0x8B11C0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x8B1210
        public void System.IConvertible.ToInt64(){} // RVA: 0x8B1260
        public void System.IConvertible.ToUInt64(){} // RVA: 0x8B12B0
        public void System.IConvertible.ToSingle(){} // RVA: 0x8B1300
        public void System.IConvertible.ToDouble(){} // RVA: 0x8B1350
        public void System.IConvertible.ToDecimal(){} // RVA: 0x8B13B0
        public void System.IConvertible.ToDateTime(){} // RVA: 0x8B1460
        public void System.IConvertible.ToType(){} // RVA: 0x8B1470
    }

    public class ByteMatcher : Object
    {
        public object map;
        public object starts;

        // ── Methods ──
        public void AddMapping(){} // RVA: 0x698B9D0
        public void Sort(){} // RVA: 0xB43310
        public void StartsWith(){} // RVA: 0x698BAE0
        public void Match(){} // RVA: 0x698BB30
        public void .ctor(){} // RVA: 0x698BE30
    }

    public class Byte[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EABD20
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A700
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC7990
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E57290
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A700
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Byte[][] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}