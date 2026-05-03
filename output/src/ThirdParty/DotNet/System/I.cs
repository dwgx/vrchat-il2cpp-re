// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 39
// Methods: 238

namespace ThirdParty.DotNet.System
{
    public class IAsyncDisposable
    {
        // ── Methods ──
        public void DisposeAsync(){}
    }

    public class IAsyncResult
    {
        // ── Methods ──
        public void get_IsCompleted(){} // RVA: 0x7FFE80E2F150
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFE80E2E2E0
        public void get_AsyncState(){} // RVA: 0x7FFE80E2E2E0
        public void get_CompletedSynchronously(){} // RVA: 0x7FFE80E2F150
    }

    public class ICloneable
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IComparable
    {
        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFE80E33B00
    }

    public class IComparable`1
    {
    }

    public class IConsoleDriver
    {
        // ── Methods ──
        public void ReadKey(){}
    }

    public class IConvertible
    {
        // ── Methods ──
        public void GetTypeCode(){} // RVA: 0x7FFE80E2EDB0
        public void ToBoolean(){} // RVA: 0x7FFE80E2F3B0
        public void ToChar(){} // RVA: 0x7FFE80E34A20
        public void ToSByte(){} // RVA: 0x7FFE80E2F3B0
        public void ToByte(){} // RVA: 0x7FFE80E2F3B0
        public void ToInt16(){} // RVA: 0x7FFE80E34A20
        public void ToUInt16(){} // RVA: 0x7FFE80E34A20
        public void ToInt32(){} // RVA: 0x7FFE80E33B00
        public void ToUInt32(){} // RVA: 0x7FFE80E33B00
        public void ToInt64(){} // RVA: 0x7FFE80E2E390
        public void ToUInt64(){} // RVA: 0x7FFE80E2E390
        public void ToSingle(){} // RVA: 0x7FFE80E43520
        public void ToDouble(){} // RVA: 0x7FFE80E34350
        public void ToDecimal(){}
        public void ToDateTime(){}
        public void ToString(){} // RVA: 0x7FFE80E2E390
        public void ToType(){} // RVA: 0x7FFE80E3FC10
    }

    public class ICustomFormatter
    {
        // ── Methods ──
        public void Format(){} // RVA: 0x7FFE80E403A0
    }

    public class IDisposable
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class IEquatable`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE80E2F3B0
    }

    public class IFormatProvider
    {
        // ── Methods ──
        public void GetFormat(){} // RVA: 0x7FFE80E2E390
    }

    public class IFormattable
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE80E3FC10
    }

    public class IOAsyncCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8117B190
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class IOAsyncResult : Object
    {
        public System.AsyncCallback async_callback; // 0x10
        public object async_state; // 0x18
        public System.Threading.ManualResetEvent wait_handle; // 0x20
        public bool completed_synchronously; // 0x28
        public bool completed; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void Init(){} // RVA: 0x7FFE8773B430
        public void get_AsyncCallback(){} // RVA: 0x7FFE81116380
        public void get_AsyncState(){} // RVA: 0x7FFE810FE7C0
        public void get_AsyncWaitHandle(){} // RVA: 0x7FFE8773B500
        public void get_CompletedSynchronously(){} // RVA: 0x7FFE815F1380
        public void set_CompletedSynchronously(){} // RVA: 0x7FFE81C15740
        public void get_IsCompleted(){} // RVA: 0x7FFE819C2EA0
        public void set_IsCompleted(){} // RVA: 0x7FFE8773B720
        public void CompleteDisposed(){} // RVA: 0x7FFE80E45FE0
    }

    public class IOSelector : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE8773B8A0
    }

    public class IOSelectorJob : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83B45810
        public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFE8773B870
        public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7FFE810FB310
        public void MarkDisposed(){} // RVA: 0x7FFE81889350
    }

    public class IObservable`1
    {
        // ── Methods ──
        public void Subscribe(){} // RVA: 0x7FFE80E2E390
    }

    public class IObserver`1
    {
        // ── Methods ──
        public void OnNext(){} // RVA: 0x7FFE810A1420
        public void OnError(){} // RVA: 0x7FFE80E460A0
        public void OnCompleted(){} // RVA: 0x7FFE80E45FE0
    }

    public class IProgress`1
    {
        // ── Methods ──
        public void Report(){} // RVA: 0x7FFE810A1420
    }

    public class IPv4AddressHelper : Object
    {
        // ── Methods ──
        public void ParseHostNumber(){} // RVA: 0x7FFE8772E8A0
        public void IsValid(){} // RVA: 0x7FFE8772E970
        public void ParseCanonical(){} // RVA: 0x7FFE8772EB00
        public void IsValidCanonical(){} // RVA: 0x7FFE8772EB90
        public void ParseNonCanonical(){} // RVA: 0x7FFE8772ECD0
        public void ParseCanonicalName(){} // RVA: 0x7FFE8772EF70
        public void Parse(){} // RVA: 0x7FFE8772F2D0
    }

    public class IPv6AddressHelper : Object
    {
        // ── Methods ──
        public void FindCompressionRange(){} // RVA: 0x7FFE8772F340
        public void ShouldHaveIpv4Embedded(){} // RVA: 0x7FFE8772F420
        public void IsValidStrict(){} // RVA: 0x7FFE8772F500
        public void Parse(){} // RVA: 0x7FFE8772F920
        public void ParseCanonicalName(){} // RVA: 0x7FFE8772FD80
        public void IsLoopback(){} // RVA: 0x7FFE87730600
        public void InternalIsValid(){} // RVA: 0x7FFE877306D0
        public void IsValid(){} // RVA: 0x7FFE877309C0
    }

    public class IServiceProvider
    {
        // ── Methods ──
        public void GetService(){} // RVA: 0x7FFE80E2E390
    }

    public class ISpanFormattable
    {
        // ── Methods ──
        public void TryFormat(){}
    }

    public class ITupleInternal
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE80E2E390
    }

    public class IValueTupleInternal
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFE80E33B00
        public void ToStringEnd(){} // RVA: 0x7FFE80E2E2E0
    }

    public class Index : ValueType
    {
        public int _value; // 0x10
        public object field_1; // 0x9A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE815BF990 | overloaded x2
        public void FromStart(){} // RVA: 0x7FFE869D8340
        public void get_Value(){} // RVA: 0x7FFE869D8360
        public void get_IsFromEnd(){} // RVA: 0x7FFE869D8370
        public void GetOffset(){} // RVA: 0x7FFE869D8380
        public void Equals(){} // RVA: 0x7FFE82E64890 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void op_Implicit(){} // RVA: 0x7FFE869D8340
        public void ToString(){} // RVA: 0x7FFE869D8420
        public void ToStringFromEnd(){} // RVA: 0x7FFE869D84D0
    }

    public class IndexOutOfRangeException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class InputRecord : ValueType
    {
    }

    public class InsufficientExecutionStackException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x2
    }

    public class Int16 : ValueType
    {
        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFE869D8830 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE868B8720 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE869D88D0
        public void ToString(){} // RVA: 0x7FFE869D8A40 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFE869D8BC0
        public void Parse(){} // RVA: 0x7FFE869D8F70 | overloaded x5
        public void TryParse(){} // RVA: 0x7FFE869D92D0 | overloaded x3
        public void GetTypeCode(){} // RVA: 0x7FFE817F39D0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFE869D93A0
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFE869D93F0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFE869D9480
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFE869D9520
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFE82D33010
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFE869D95B0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFE869D9640
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFE869D9690
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFE869D9720
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFE869D9770
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFE869D9800
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFE869D9850
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFE869D98A0
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFE869D9970
        public void System.IConvertible.ToType(){} // RVA: 0x7FFE869D9A00
    }

    public class Int32 : ValueType
    {
        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFE82E642F0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE82E64890 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void ToString(){} // RVA: 0x7FFE869D9E20 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFE869D9EF0
        public void Parse(){} // RVA: 0x7FFE869DA2E0 | overloaded x5
        public void TryParse(){} // RVA: 0x7FFE869DA550 | overloaded x3
        public void GetTypeCode(){} // RVA: 0x7FFE8249F650
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFE869DA600
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFE869DA650
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFE869DA6E0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFE869DA770
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFE869DA800
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFE869DA890
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFE826F4220
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFE869DA920
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFE869DA9B0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFE869DAA00
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFE869DAA90
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFE869DAAE0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFE869DAB30
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFE869DABF0
        public void System.IConvertible.ToType(){} // RVA: 0x7FFE869DAC80
    }

    public class Int64 : ValueType
    {
        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFE869DAE10 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE841BEBF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE869DAEC0
        public void ToString(){} // RVA: 0x7FFE869DB0E0 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFE869DB1B0
        public void Parse(){} // RVA: 0x7FFE869DB4C0 | overloaded x4
        public void TryParse(){} // RVA: 0x7FFE869DB680 | overloaded x2
        public void GetTypeCode(){} // RVA: 0x7FFE869DB780
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFE869DB790
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFE869DB7E0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFE869DB870
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFE869DB900
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFE869DB990
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFE869DBA20
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFE869DBAB0
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFE869DBB50
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFE8284EF60
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFE869DBBE0
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFE869DBC70
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFE869DBCC0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFE869DBD10
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFE869DBDE0
        public void System.IConvertible.ToType(){} // RVA: 0x7FFE869DBE70
    }

    public class IntPtr : ValueType
    {
        public void* m_value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A46D30 | overloaded x4
        public void get_Size(){} // RVA: 0x7FFE82199910
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE86A46D90
        public void Equals(){} // RVA: 0x7FFE86A46E30
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void ToInt32(){} // RVA: 0x7FFE826F4220
        public void ToInt64(){} // RVA: 0x7FFE8348B260
        public void ToPointer(){} // RVA: 0x7FFE8284EF60
        public void ToString(){} // RVA: 0x7FFE86A46F50 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE835C1CA0
        public void op_Inequality(){} // RVA: 0x7FFE869FA340
        public void op_Explicit(){} // RVA: 0x7FFE827C4A80 | overloaded x6
        public void Add(){} // RVA: 0x7FFE835C1B80
        public void op_Addition(){} // RVA: 0x7FFE835C1B80
        public void op_Subtraction(){} // RVA: 0x7FFE86A47020
        public void IsNull(){} // RVA: 0x7FFE82AB4690
        public void System.IEquatable<System.IntPtr>.Equals(){} // RVA: 0x7FFE841BEBF0
    }

    public class InvalidCastException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x4
    }

    public class InvalidOperationException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x4
    }

    public class InvalidProgramException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class InvalidTimeZoneException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869DC1C0 | overloaded x4
    }

    public class InvariantComparer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87733EE0
        public void Compare(){} // RVA: 0x7FFE87733FE0
        public void .cctor(){} // RVA: 0x7FFE877340E0
    }

    public class IriHelper : Object
    {
        // ── Methods ──
        public void CheckIriUnicodeRange(){} // RVA: 0x7FFE877342E0 | overloaded x2
        public void CheckIsReserved(){} // RVA: 0x7FFE87734EE0
        public void EscapeUnescapeIri(){} // RVA: 0x7FFE87735010
    }

}