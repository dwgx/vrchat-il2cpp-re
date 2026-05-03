// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 8
// Methods: 125

namespace ThirdParty.DotNet.System
{
    public class BRECORD : ValueType
    {
    }

    public class BadImageFormatException : SystemException
    {
        public string _fileName; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868B4AC0 | overloaded x5
        public void GetObjectData(){} // RVA: 0x7FFE868B4C60
        public void get_Message(){} // RVA: 0x7FFE868B4F70
        public void SetMessageField(){} // RVA: 0x7FFE868B5090
        public void ToString(){} // RVA: 0x7FFE868B51B0
    }

    public class BitConverter : Object
    {
        // ── Methods ──
        public void GetBytes(){} // RVA: 0x7FFE868B57A0 | overloaded x10
        public void TryWriteBytes(){} // RVA: 0x7FFE868B5660
        public void ToChar(){} // RVA: 0x7FFE827B1E80
        public void ToInt16(){} // RVA: 0x7FFE827B1E80
        public void ToInt32(){} // RVA: 0x7FFE868B5870 | overloaded x2
        public void ToInt64(){} // RVA: 0x7FFE868B58D0
        public void ToUInt16(){} // RVA: 0x7FFE827B1E80
        public void ToUInt32(){} // RVA: 0x7FFE868B5810
        public void ToUInt64(){} // RVA: 0x7FFE868B58D0
        public void ToSingle(){} // RVA: 0x7FFE868B5930
        public void ToDouble(){} // RVA: 0x7FFE868B5990
        public void ToString(){} // RVA: 0x7FFE868B5FA0 | overloaded x2
        public void ToBoolean(){} // RVA: 0x7FFE868B5FD0
        public void DoubleToInt64Bits(){} // RVA: 0x7FFE868B6030
        public void Int64BitsToDouble(){} // RVA: 0x7FFE868B6040
        public void SingleToInt32Bits(){} // RVA: 0x7FFE868B6050
        public void Int32BitsToSingle(){} // RVA: 0x7FFE868B6060
        public void .cctor(){} // RVA: 0x7FFE868B6070
    }

    public class Boolean : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFE868B6390
        public void ToString(){} // RVA: 0x7FFE868B6400 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE868B6520 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFE868B6620 | overloaded x2
        public void Parse(){} // RVA: 0x7FFE868B67C0 | overloaded x2
        public void TryParse(){} // RVA: 0x7FFE868B6940 | overloaded x2
        public void TrimWhiteSpaceAndNull(){} // RVA: 0x7FFE868B6CF0
        public void GetTypeCode(){} // RVA: 0x7FFE817BF630
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFE868B6E90
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFE868B6EA0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFE868B6F30
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFE868B6F80
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFE868B6FD0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFE868B7020
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFE868B7070
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFE868B70C0
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFE868B7110
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFE868B7160
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFE868B71B0
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFE868B7210
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFE868B7270
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFE868B7330
        public void System.IConvertible.ToType(){} // RVA: 0x7FFE868B73C0
        public void .cctor(){} // RVA: 0x7FFE868B7460
    }

    public class Buffer : Object
    {
        // ── Methods ──
        public void InternalBlockCopy(){} // RVA: 0x7FFE86A17170
        public void IndexOfByte(){} // RVA: 0x7FFE86A17230
        public void _ByteLength(){} // RVA: 0x7FFE86A172E0
        public void ZeroMemory(){} // RVA: 0x7FFE86A172F0
        public void Memcpy(){} // RVA: 0x7FFE86A17BF0 | overloaded x2
        public void InternalMemcpy(){} // RVA: 0x7FFE86A17360
        public void ByteLength(){} // RVA: 0x7FFE86A17370
        public void GetByte(){} // RVA: 0x7FFE86A17420
        public void SetByte(){} // RVA: 0x7FFE86A17530
        public void BlockCopy(){} // RVA: 0x7FFE86A17650
        public void MemoryCopy(){} // RVA: 0x7FFE86A17900
        public void memcpy4(){} // RVA: 0x7FFE86A17A20
        public void memcpy2(){} // RVA: 0x7FFE86A17AC0
        public void memcpy1(){} // RVA: 0x7FFE86A17B40
        public void Memmove(){} // RVA: 0x7FFE80E479C0 | overloaded x2
    }

    public class ByReference`1 : ValueType
    {
        public UIntPtr _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_Value(){} // RVA: 0x7FFE80E2E2E0
    }

    public class Byte : ValueType
    {
        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFE868B7660 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE868B6520 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE82BC9920
        public void Parse(){} // RVA: 0x7FFE868B7970 | overloaded x5
        public void TryParse(){} // RVA: 0x7FFE868B7C00 | overloaded x3
        public void ToString(){} // RVA: 0x7FFE868B7ED0 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFE868B7FA0
        public void GetTypeCode(){} // RVA: 0x7FFE81815210
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFE868B8050
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFE868B80A0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFE868B80F0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFE82BC9920
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFE868B8180
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFE868B81D0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFE868B8220
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFE868B8270
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFE868B82C0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFE868B8310
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFE868B8360
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFE868B83B0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFE868B8400
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFE868B84B0
        public void System.IConvertible.ToType(){} // RVA: 0x7FFE868B8540
    }

    public class ByteMatcher : Object
    {
        // ── Methods ──
        public void AddMapping(){} // RVA: 0x7FFE86A54D70
        public void Sort(){} // RVA: 0x7FFE810FB310
        public void StartsWith(){} // RVA: 0x7FFE86A54EB0
        public void Match(){} // RVA: 0x7FFE86A54F30
        public void .ctor(){} // RVA: 0x7FFE86A55240
    }

}