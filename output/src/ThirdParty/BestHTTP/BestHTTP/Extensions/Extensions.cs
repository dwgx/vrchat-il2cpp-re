// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Extensions
// Classes: 17
// Methods: 162

namespace ThirdParty.BestHTTP.BestHTTP.Extensions
{
    public class BufferDesc
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9814CF0
        public void .cctor(){} // RVA: 0x9814DA0
    }

    public class BufferPoolMemoryStream
    {
        public bool canWrite; // 0x28
        public bool allowGetBuffer; // 0x29
        public int capacity; // 0x2C
        public int length; // 0x30
        public byte[] internalBuffer; // 0x38
        public int initialIndex; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x980E930 | overloaded x7
        public void InternalConstructor(){} // RVA: 0x980E9D0
        public void CheckIfClosedThrowDisposed(){} // RVA: 0x980EB40
        public void get_CanRead(){} // RVA: 0x980EBB0
        public void get_CanSeek(){} // RVA: 0x980EBB0
        public void get_CanWrite(){} // RVA: 0x980EBC0
        public void get_Capacity(){} // RVA: 0x980EBD0
        public void set_Capacity(){} // RVA: 0x980EC40
        public void get_Length(){} // RVA: 0x980EE80
        public void get_Position(){} // RVA: 0x980EEF0
        public void set_Position(){} // RVA: 0x980EF60
        public void Dispose(){} // RVA: 0x980F0A0
        public void Flush(){} // RVA: 0x2DD310
        public void GetBuffer(){} // RVA: 0x980F160
        public void Read(){} // RVA: 0x980F1C0
        public void ReadByte(){} // RVA: 0x980F3A0
        public void Seek(){} // RVA: 0x980F440
        public void CalculateNewCapacity(){} // RVA: 0x980F650
        public void Expand(){} // RVA: 0x980F700
        public void SetLength(){} // RVA: 0x980F800
        public void ToArray(){} // RVA: 0x980FA70 | overloaded x2
        public void Write(){} // RVA: 0x980FB40
        public void WriteByte(){} // RVA: 0x980FD70
        public void WriteTo(){} // RVA: 0x980FE80
    }

    public class BufferStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9814C50 | overloaded x2
    }

    public class CircularBuffer`1
    {
        public int <Capacity>k__BackingField;
        public int <Count>k__BackingField;
        public T[] buffer;

        // ── Methods ──
        public void get_Capacity(){} // RVA: 0xD840
        public void set_Capacity(){} // RVA: 0x24FA0
        public void get_Count(){} // RVA: 0xD840
        public void set_Count(){} // RVA: 0x24FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24FA0
        public void Add(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void ToString(){} // RVA: 0xCD60
    }

    public class ExceptionHelper
    {
        // ── Methods ──
        public void ServerClosedTCPStream(){} // RVA: 0x98125D0
    }

    public class Extensions
    {
        // ── Methods ──
        public void AsciiToString(){} // RVA: 0x980FF60
        public void GetASCIIBytes(){} // RVA: 0x9810030
        public void SendAsASCII(){} // RVA: 0x9810110
        public void WriteLine(){} // RVA: 0x9812230 | overloaded x5
        public void GetRequestPathAndQueryURL(){} // RVA: 0x9810590
        public void FindOption(){} // RVA: 0x9810600
        public void WriteArray(){} // RVA: 0x98107D0
        public void IsHostIsAnIPAddress(){} // RVA: 0x9810810
        public void IsIpV4AddressValid(){} // RVA: 0x98109E0
        public void IsIpV6AddressValid(){} // RVA: 0x9810B10
        public void ToInt32(){} // RVA: 0x9810C30
        public void ToInt64(){} // RVA: 0x9810C60
        public void ToDateTime(){} // RVA: 0x9810C90
        public void ToStrOrEmpty(){} // RVA: 0x9810D20
        public void ToBinaryStr(){} // RVA: 0x9810D70
        public void CalculateMD5Hash(){} // RVA: 0x9810EA0 | overloaded x2
        public void Read(){} // RVA: 0x9811350 | overloaded x2
        public void ReadPossibleQuotedText(){} // RVA: 0x9811480
        public void SkipWhiteSpace(){} // RVA: 0x9811740
        public void TrimAndLower(){} // RVA: 0x98117F0
        public void Peek(){} // RVA: 0x9811970
        public void ParseOptionalHeader(){} // RVA: 0x9811A00
        public void ParseQualityParams(){} // RVA: 0x9811C80
        public void ReadBuffer(){} // RVA: 0x9811FC0 | overloaded x2
        public void WriteString(){} // RVA: 0x9812060
        public void .cctor(){} // RVA: 0x9812400
    }

    public class HeaderParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9812640
        public void Parse(){} // RVA: 0x98126B0
    }

    public class HeaderValue
    {
        public string <Key>k__BackingField; // 0x10
        public string <Value>k__BackingField; // 0x18
        public System.Collections.Generic.List`1<BestHTTP.Extensions.HeaderValue> <Options>k__BackingField; // 0x20

        // ── Methods ──
        public void get_Key(){} // RVA: 0x2F8380
        public void set_Key(){} // RVA: 0x2DEE30
        public void get_Value(){} // RVA: 0x2E07C0
        public void set_Value(){} // RVA: 0x343E80
        public void get_Options(){} // RVA: 0x30B0C0
        public void set_Options(){} // RVA: 0x30B0D0
        public void get_HasValue(){} // RVA: 0x2BCCB30
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void Parse(){} // RVA: 0x98128B0
        public void TryGetOption(){} // RVA: 0x98128D0
        public void ParseImplementation(){} // RVA: 0x9812AE0
        public void ToString(){} // RVA: 0x9813070
    }

    public class HeartbeatManager
    {
        // ── Methods ──
        public void Subscribe(){} // RVA: 0x9813290
        public void Unsubscribe(){} // RVA: 0x9813430
        public void Update(){} // RVA: 0x9813520
        public void .ctor(){} // RVA: 0x9813830
    }

    public class IHeartbeat
    {
        // ── Methods ──
        public void OnHeartbeatUpdate(){} // RVA: 0x24CC0
    }

    public class KeyValuePairList
    {
        public System.Collections.Generic.List`1<BestHTTP.Extensions.HeaderValue> <Values>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Values(){} // RVA: 0x2F8380
        public void set_Values(){} // RVA: 0x2DEE30
        public void TryGet(){} // RVA: 0x9813A00
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PooledBuffer
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x9814AE0
    }

    public class ReadOnlyBufferedStream
    {
        public System.IO.Stream stream; // 0x28
        public int READBUFFER;
        public byte[] buf; // 0x30
        public int available; // 0x38
        public int pos; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9813CC0 | overloaded x2
        public void Read(){} // RVA: 0x9813E00
        public void ReadByte(){} // RVA: 0x9813FA0
        public void Dispose(){} // RVA: 0x9814070
        public void get_CanRead(){} // RVA: 0x3C2850
        public void get_CanSeek(){} // RVA: 0x9814130
        public void get_CanWrite(){} // RVA: 0x9814170
        public void get_Length(){} // RVA: 0x98141B0
        public void get_Position(){} // RVA: 0x98141F0
        public void set_Position(){} // RVA: 0x9814230
        public void Flush(){} // RVA: 0x9814270
        public void Seek(){} // RVA: 0x98142B0
        public void SetLength(){} // RVA: 0x98142F0
        public void Write(){} // RVA: 0x9814330
    }

    public class StreamList
    {
        public System.IO.Stream[] Streams; // 0x28
        public int CurrentIdx; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9814370
        public void get_CanRead(){} // RVA: 0x9814420
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x9814480
        public void Flush(){} // RVA: 0x98144E0
        public void get_Length(){} // RVA: 0x9814560
        public void Read(){} // RVA: 0x9814610
        public void Write(){} // RVA: 0x9814780 | overloaded x2
        public void Dispose(){} // RVA: 0x9814840
        public void get_Position(){} // RVA: 0x9814990
        public void set_Position(){} // RVA: 0x98149E0
        public void Seek(){} // RVA: 0x9814A30
        public void SetLength(){} // RVA: 0x9814A90
    }

    public class VariableSizedBufferPool
    {
        public byte[] CanRead;

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x9814E50
        public void set_IsEnabled(){} // RVA: 0x9814EB0
        public void .cctor(){} // RVA: 0x9814F50
        public void Get(){} // RVA: 0x9815430
        public void Release(){} // RVA: 0x98157C0 | overloaded x2
        public void Resize(){} // RVA: 0x9815A30
        public void GetStatistics(){} // RVA: 0x9815BE0
        public void Clear(){} // RVA: 0x9816270
        public void Maintain(){} // RVA: 0x98163D0
        public void IsPowerOfTwo(){} // RVA: 0x98168A0
        public void NextPowerOf2(){} // RVA: 0x98168B0
        public void FindFreeBuffer(){} // RVA: 0x98168D0
        public void AddFreeBuffer(){} // RVA: 0x9816CB0
    }

    public class WWWAuthenticateHeaderParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9817490
        public void ParseQuotedHeader(){} // RVA: 0x9817500
    }

    public class WriteOnlyBufferedStream
    {
        public int _position; // 0x28
        public byte[] buffer; // 0x30
        public System.IO.Stream stream; // 0x38

        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x2DD320
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x3C2850
        public void get_Length(){} // RVA: 0x9817090
        public void get_Position(){} // RVA: 0x98170B0
        public void set_Position(){} // RVA: 0x98170C0
        public void .ctor(){} // RVA: 0x9817110
        public void Flush(){} // RVA: 0x9817250
        public void Write(){} // RVA: 0x98172C0
        public void Read(){} // RVA: 0x519240
        public void Seek(){} // RVA: 0x519240
        public void SetLength(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x98173D0
    }

}