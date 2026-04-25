// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 39
// Methods: 239

namespace ThirdParty.DotNet.System
{
    public class IAsyncDisposable
    {
        // ── Methods ──
        public void DisposeAsync(){}
    }

    public class IAsyncResult
    {
        public object IsCompleted;
        public object AsyncWaitHandle;
        public object AsyncState;
        public object CompletedSynchronously;

        // ── Methods ──
        public void get_IsCompleted(){} // RVA: 0x7FFAC2C59D00
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFAC2C58E90
        public void get_AsyncState(){} // RVA: 0x7FFAC2C58E90
        public void get_CompletedSynchronously(){} // RVA: 0x7FFAC2C59D00
    }

    public class ICloneable
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7FFAC2C58E90
    }

    public class IComparable
    {
        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFAC2C5E6B0
    }

    public class IComparable`1
    {
        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFAC2C5E6B0
    }

    public class IConsoleDriver
    {
        // ── Methods ──
        public void ReadKey(){}
    }

    public class IConvertible
    {
        // ── Methods ──
        public void GetTypeCode(){} // RVA: 0x7FFAC2C59960
        public void ToBoolean(){} // RVA: 0x7FFAC2C59F60
        public void ToChar(){} // RVA: 0x7FFAC2C5F5D0
        public void ToSByte(){} // RVA: 0x7FFAC2C59F60
        public void ToByte(){} // RVA: 0x7FFAC2C59F60
        public void ToInt16(){} // RVA: 0x7FFAC2C5F5D0
        public void ToUInt16(){} // RVA: 0x7FFAC2C5F5D0
        public void ToInt32(){} // RVA: 0x7FFAC2C5E6B0
        public void ToUInt32(){} // RVA: 0x7FFAC2C5E6B0
        public void ToInt64(){} // RVA: 0x7FFAC2C58F40
        public void ToUInt64(){} // RVA: 0x7FFAC2C58F40
        public void ToSingle(){} // RVA: 0x7FFAC2C6DF90
        public void ToDouble(){} // RVA: 0x7FFAC2C5EF00
        public void ToDecimal(){}
        public void ToDateTime(){}
        public void ToString(){} // RVA: 0x7FFAC2C58F40
        public void ToType(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class ICustomFormatter
    {
        // ── Methods ──
        public void Format(){} // RVA: 0x7FFAC2C6AE80
    }

    public class IDisposable
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class IEquatable`1
    {
        // ── Methods ──
        public void Equals(){}
    }

    public class IFormatProvider
    {
        // ── Methods ──
        public void GetFormat(){} // RVA: 0x7FFAC2C58F40
    }

    public class IFormattable
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class IOAsyncCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FA1190
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class IOAsyncResult : Object
    {
        public System.AsyncCallback AsyncCallback; // 0x10
        public object AsyncState; // 0x18
        public System.Threading.ManualResetEvent AsyncWaitHandle; // 0x20
        public bool CompletedSynchronously; // 0x28
        public bool IsCompleted; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void Init(){} // RVA: 0x7FFAC9392D00
        public void get_AsyncCallback(){} // RVA: 0x7FFAC2F3C380
        public void get_AsyncState(){} // RVA: 0x7FFAC2F247C0
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFAC9392DD0
        public void get_CompletedSynchronously(){} // RVA: 0x7FFAC30F6BA0
        public void set_CompletedSynchronously(){} // RVA: 0x7FFAC3C24F40
        public void get_IsCompleted(){} // RVA: 0x7FFAC386C550
        public void set_IsCompleted(){} // RVA: 0x7FFAC9392FF0
        public void CompleteDisposed(){} // RVA: 0x7FFAC2C70980
    }

    public class IOSelector : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC9393170
    }

    public class IOSelectorJob : Object
    {
        public 0x6B12F700 operation; // 0x10
        public System.IOAsyncCallback callback; // 0x18
        public System.IOAsyncResult state; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5808D30
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFAC9393140
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7FFAC2F21310
        public void MarkDisposed(){} // RVA: 0x7FFAC3760180
    }

    public class IObservable`1
    {
        // ── Methods ──
        public void Subscribe(){} // RVA: 0x7FFAC2C58F40
    }

    public class IObserver`1
    {
        // ── Methods ──
        public void OnNext(){} // RVA: 0x7FFAC2E8DC40
        public void OnError(){} // RVA: 0x7FFAC2C70A40
        public void OnCompleted(){} // RVA: 0x7FFAC2C70980
    }

    public class IProgress`1
    {
        // ── Methods ──
        public void Report(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IPv4AddressHelper : Object
    {
        // ── Methods ──
        public void ParseHostNumber(){} // RVA: 0x7FFAC9386170
        public void IsValid(){} // RVA: 0x7FFAC9386240
        public void ParseCanonical(){} // RVA: 0x7FFAC93863D0
        public void IsValidCanonical(){} // RVA: 0x7FFAC9386460
        public void ParseNonCanonical(){} // RVA: 0x7FFAC93865A0
        public void ParseCanonicalName(){} // RVA: 0x7FFAC9386840
        public void Parse(){} // RVA: 0x7FFAC9386BA0
    }

    public class IPv6AddressHelper : Object
    {
        // ── Methods ──
        public void FindCompressionRange(){} // RVA: 0x7FFAC9386C10
        public void ShouldHaveIpv4Embedded(){} // RVA: 0x7FFAC9386CF0
        public void IsValidStrict(){} // RVA: 0x7FFAC9386DD0
        public void Parse(){} // RVA: 0x7FFAC93871F0
        public void ParseCanonicalName(){} // RVA: 0x7FFAC9387650
        public void IsLoopback(){} // RVA: 0x7FFAC9387ED0
        public void InternalIsValid(){} // RVA: 0x7FFAC9387FA0
        public void IsValid(){} // RVA: 0x7FFAC9388290
    }

    public class IServiceProvider
    {
        // ── Methods ──
        public void GetService(){} // RVA: 0x7FFAC2C58F40
    }

    public class ISpanFormattable
    {
        // ── Methods ──
        public void TryFormat(){}
    }

    public class ITupleInternal
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC2C58F40
    }

    public class IValueTupleInternal
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAC2C5E6B0
        public void ToStringEnd(){} // RVA: 0x7FFAC2C58E90
    }

    public class Index : ValueType
    {
        public int Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC336D8B0 | overloaded x2
        public void FromStart(){} // RVA: 0x7FFAC862EB70
        public void get_Value(){} // RVA: 0x7FFAC862EB90
        public void get_IsFromEnd(){} // RVA: 0x7FFAC862EBA0
        public void GetOffset(){} // RVA: 0x7FFAC862EBB0
        public void Equals(){} // RVA: 0x7FFAC4BF7E90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void op_Implicit(){} // RVA: 0x7FFAC862EB70
        public void ToString(){} // RVA: 0x7FFAC862EC50
        public void ToStringFromEnd(){} // RVA: 0x7FFAC862ED00
    }

    public class IndexOutOfRangeException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class InputRecord : ValueType
    {
        public short EventType; // 0x10
        public bool KeyDown; // 0x12
        public short RepeatCount; // 0x14
        public short VirtualKeyCode; // 0x16
        public short VirtualScanCode; // 0x18
        public char Character; // 0x1A
        public int ControlKeyState; // 0x1C
        public int pad1; // 0x20
        public bool pad2; // 0x24
    }

    public class InsufficientExecutionStackException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x2
    }

    public class Int16 : ValueType
    {
        public short m_value; // 0x10
        public short MaxValue;
        public short MinValue;

        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFAC862F060 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC850EF20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC862F100
        public void ToString(){} // RVA: 0x7FFAC862F270 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFAC862F3F0
        public void Parse(){} // RVA: 0x7FFAC862F7A0 | overloaded x5
        public void TryParse(){} // RVA: 0x7FFAC862FB00 | overloaded x3
        public void GetTypeCode(){} // RVA: 0x7FFAC36AE2C0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFAC862FBD0
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFAC862FC20
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFAC862FCB0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFAC862FD50
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFAC4AC85D0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFAC862FDE0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFAC862FE70
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFAC862FEC0
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFAC862FF50
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFAC862FFA0
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFAC8630030
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFAC8630080
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFAC86300D0
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFAC86301A0
        public void System.IConvertible.ToType(){} // RVA: 0x7FFAC8630230
    }

    public class Int32 : ValueType
    {
        public int m_value; // 0x10
        public int MaxValue;
        public int MinValue;

        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFAC4BF78F0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC4BF7E90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void ToString(){} // RVA: 0x7FFAC8630650 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFAC8630720
        public void Parse(){} // RVA: 0x7FFAC8630B10 | overloaded x5
        public void TryParse(){} // RVA: 0x7FFAC8630D80 | overloaded x3
        public void GetTypeCode(){} // RVA: 0x7FFAC41E44C0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFAC8630E30
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFAC8630E80
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFAC8630F10
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFAC8630FA0
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFAC8631030
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFAC86310C0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFAC4420210
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFAC8631150
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFAC86311E0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFAC8631230
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFAC86312C0
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFAC8631310
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFAC8631360
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFAC8631420
        public void System.IConvertible.ToType(){} // RVA: 0x7FFAC86314B0
    }

    public class Int64 : ValueType
    {
        public long m_value; // 0x10
        public long MaxValue;
        public long MinValue;

        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFAC8631640 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC5E861F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC86316F0
        public void ToString(){} // RVA: 0x7FFAC8631910 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFAC86319E0
        public void Parse(){} // RVA: 0x7FFAC8631CF0 | overloaded x4
        public void TryParse(){} // RVA: 0x7FFAC8631EB0 | overloaded x2
        public void GetTypeCode(){} // RVA: 0x7FFAC8631FB0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFAC8631FC0
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFAC8632010
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFAC86320A0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFAC8632130
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFAC86321C0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFAC8632250
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFAC86322E0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFAC8632380
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFAC3AD9F60
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFAC8632410
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFAC86324A0
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFAC86324F0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFAC8632540
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFAC8632610
        public void System.IConvertible.ToType(){} // RVA: 0x7FFAC86326A0
    }

    public class IntPtr : ValueType
    {
        public void* Size; // 0x10
        public UIntPtr Zero;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC869D520 | overloaded x4
        public void get_Size(){} // RVA: 0x7FFAC3ED8E80
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC869D580
        public void Equals(){} // RVA: 0x7FFAC869D620
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void ToInt32(){} // RVA: 0x7FFAC4420210
        public void ToInt64(){} // RVA: 0x7FFAC51D9A30
        public void ToPointer(){} // RVA: 0x7FFAC3AD9F60
        public void ToString(){} // RVA: 0x7FFAC869D740 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC530B460
        public void op_Inequality(){} // RVA: 0x7FFAC8650B50
        public void op_Explicit(){} // RVA: 0x7FFAC44F81E0 | overloaded x6
        public void Add(){} // RVA: 0x7FFAC530B340
        public void op_Addition(){} // RVA: 0x7FFAC530B340
        public void op_Subtraction(){} // RVA: 0x7FFAC869D810
        public void IsNull(){} // RVA: 0x7FFAC484C2F0
        public void System.IEquatable<System.IntPtr>.Equals(){} // RVA: 0x7FFAC5E861F0
    }

    public class InvalidCastException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x4
    }

    public class InvalidOperationException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x4
    }

    public class InvalidProgramException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class InvalidTimeZoneException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86329F0 | overloaded x4
    }

    public class InvariantComparer : Object
    {
        public System.Globalization.CompareInfo m_compareInfo; // 0x10
        public System.InvariantComparer Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC938B7B0
        public void Compare(){} // RVA: 0x7FFAC938B8B0
        public void .cctor(){} // RVA: 0x7FFAC938B9B0
    }

    public class IriHelper : Object
    {
        // ── Methods ──
        public void CheckIriUnicodeRange(){} // RVA: 0x7FFAC938BBB0 | overloaded x2
        public void CheckIsReserved(){} // RVA: 0x7FFAC938C7B0
        public void EscapeUnescapeIri(){} // RVA: 0x7FFAC938C8E0
    }

}