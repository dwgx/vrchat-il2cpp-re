// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 23
// Methods: 178

namespace ThirdParty.DotNet.System
{
    public class IAsyncDisposable
    {
        // ── Methods ──
        public void DisposeAsync(){}
    }

    public class IAsyncResult
    {
        public <>c<T> IsCompleted;
        public object AsyncWaitHandle;
        public object AsyncState;
        public object CompletedSynchronously;

        // ── Methods ──
        public void get_IsCompleted(){} // RVA: 0x7FFD4E079D00
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFD4E078E90
        public void get_AsyncState(){} // RVA: 0x7FFD4E078E90
        public void get_CompletedSynchronously(){} // RVA: 0x7FFD4E079D00
    }

    public class ICloneable
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7FFD4E078E90
    }

    public class IComparable
    {
        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFD4E07E6B0
    }

    public class IComparable`1
    {
        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFD4E07E6B0
    }

    public class IConvertible
    {
        // ── Methods ──
        public void GetTypeCode(){} // RVA: 0x7FFD4E079960
        public void ToBoolean(){} // RVA: 0x7FFD4E079F60
        public void ToChar(){} // RVA: 0x7FFD4E07F5D0
        public void ToSByte(){} // RVA: 0x7FFD4E079F60
        public void ToByte(){} // RVA: 0x7FFD4E079F60
        public void ToInt16(){} // RVA: 0x7FFD4E07F5D0
        public void ToUInt16(){} // RVA: 0x7FFD4E07F5D0
        public void ToInt32(){} // RVA: 0x7FFD4E07E6B0
        public void ToUInt32(){} // RVA: 0x7FFD4E07E6B0
        public void ToInt64(){} // RVA: 0x7FFD4E078F40
        public void ToUInt64(){} // RVA: 0x7FFD4E078F40
        public void ToSingle(){} // RVA: 0x7FFD4E08DF90
        public void ToDouble(){} // RVA: 0x7FFD4E07EF00
        public void ToDecimal(){}
        public void ToDateTime(){}
        public void ToString(){} // RVA: 0x7FFD4E078F40
        public void ToType(){} // RVA: 0x7FFD4E08A6F0
    }

    public class ICustomFormatter
    {
        // ── Methods ──
        public void Format(){} // RVA: 0x7FFD4E08AE80
    }

    public class IDisposable
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class IEquatable`1
    {
        // ── Methods ──
        public void Equals(){}
    }

    public class IFormatProvider
    {
        // ── Methods ──
        public void GetFormat(){} // RVA: 0x7FFD4E078F40
    }

    public class IFormattable
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD4E08A6F0
    }

    public class IObservable`1
    {
        // ── Methods ──
        public void Subscribe(){} // RVA: 0x7FFD4E078F40
    }

    public class IObserver`1
    {
        // ── Methods ──
        public void OnNext(){} // RVA: 0x7FFD4E2ADC40
        public void OnError(){} // RVA: 0x7FFD4E090A40
        public void OnCompleted(){} // RVA: 0x7FFD4E090980
    }

    public class IProgress`1
    {
        // ── Methods ──
        public void Report(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IServiceProvider
    {
        // ── Methods ──
        public void GetService(){} // RVA: 0x7FFD4E078F40
    }

    public class ISpanFormattable
    {
        // ── Methods ──
        public void TryFormat(){}
    }

    public class ITupleInternal
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD4E078F40
    }

    public class IValueTupleInternal
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFD4E07E6B0
        public void ToStringEnd(){} // RVA: 0x7FFD4E078E90
    }

    public class Index : ValueType
    {
        public int Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E78D8B0 | overloaded x2
        public void FromStart(){} // RVA: 0x7FFD53A4EB70
        public void get_Value(){} // RVA: 0x7FFD53A4EB90
        public void get_IsFromEnd(){} // RVA: 0x7FFD53A4EBA0
        public void GetOffset(){} // RVA: 0x7FFD53A4EBB0
        public void Equals(){} // RVA: 0x7FFD50017E90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
        public void op_Implicit(){} // RVA: 0x7FFD53A4EB70
        public void ToString(){} // RVA: 0x7FFD53A4EC50
        public void ToStringFromEnd(){} // RVA: 0x7FFD53A4ED00
    }

    public class Int16 : ValueType
    {
        public short m_value; // 0x10
        public short MaxValue;
        public short MinValue;

        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFD53A4F060 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD5392EF20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53A4F100
        public void ToString(){} // RVA: 0x7FFD53A4F270 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFD53A4F3F0
        public void Parse(){} // RVA: 0x7FFD53A4F7A0 | overloaded x5
        public void TryParse(){} // RVA: 0x7FFD53A4FB00 | overloaded x3
        public void GetTypeCode(){} // RVA: 0x7FFD4EACE2C0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFD53A4FBD0
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFD53A4FC20
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFD53A4FCB0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFD53A4FD50
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFD4FEE85D0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFD53A4FDE0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFD53A4FE70
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFD53A4FEC0
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFD53A4FF50
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFD53A4FFA0
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFD53A50030
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFD53A50080
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFD53A500D0
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFD53A501A0
        public void System.IConvertible.ToType(){} // RVA: 0x7FFD53A50230
    }

    public class Int32 : ValueType
    {
        public int m_value; // 0x10
        public int MaxValue;
        public int MinValue;

        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFD500178F0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD50017E90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
        public void ToString(){} // RVA: 0x7FFD53A50650 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFD53A50720
        public void Parse(){} // RVA: 0x7FFD53A50B10 | overloaded x5
        public void TryParse(){} // RVA: 0x7FFD53A50D80 | overloaded x3
        public void GetTypeCode(){} // RVA: 0x7FFD4F6044C0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFD53A50E30
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFD53A50E80
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFD53A50F10
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFD53A50FA0
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFD53A51030
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFD53A510C0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFD4F840210
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFD53A51150
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFD53A511E0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFD53A51230
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFD53A512C0
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFD53A51310
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFD53A51360
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFD53A51420
        public void System.IConvertible.ToType(){} // RVA: 0x7FFD53A514B0
    }

    public class Int64 : ValueType
    {
        public long m_value; // 0x10
        public long MaxValue;
        public long MinValue;

        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFD53A51640 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD512A61F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53A516F0
        public void ToString(){} // RVA: 0x7FFD53A51910 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFD53A519E0
        public void Parse(){} // RVA: 0x7FFD53A51CF0 | overloaded x4
        public void TryParse(){} // RVA: 0x7FFD53A51EB0 | overloaded x2
        public void GetTypeCode(){} // RVA: 0x7FFD53A51FB0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFD53A51FC0
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFD53A52010
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFD53A520A0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFD53A52130
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFD53A521C0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFD53A52250
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFD53A522E0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFD53A52380
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFD4EEF9F60
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFD53A52410
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFD53A524A0
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFD53A524F0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFD53A52540
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFD53A52610
        public void System.IConvertible.ToType(){} // RVA: 0x7FFD53A526A0
    }

    public class IntPtr : ValueType
    {
        public void* Size; // 0x10
        public UIntPtr Zero;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53ABD520 | overloaded x4
        public void get_Size(){} // RVA: 0x7FFD4F2F8E80
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD53ABD580
        public void Equals(){} // RVA: 0x7FFD53ABD620
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
        public void ToInt32(){} // RVA: 0x7FFD4F840210
        public void ToInt64(){} // RVA: 0x7FFD505F9A30
        public void ToPointer(){} // RVA: 0x7FFD4EEF9F60
        public void ToString(){} // RVA: 0x7FFD53ABD740 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD5072B460
        public void op_Inequality(){} // RVA: 0x7FFD53A70B50
        public void op_Explicit(){} // RVA: 0x7FFD4F9181E0 | overloaded x6
        public void Add(){} // RVA: 0x7FFD5072B340
        public void op_Addition(){} // RVA: 0x7FFD5072B340
        public void op_Subtraction(){} // RVA: 0x7FFD53ABD810
        public void IsNull(){} // RVA: 0x7FFD4FC6C2F0
        public void System.IEquatable<System.IntPtr>.Equals(){} // RVA: 0x7FFD512A61F0
    }

}