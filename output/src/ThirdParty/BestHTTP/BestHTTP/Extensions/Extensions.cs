// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Extensions
// Classes: 17
// Methods: 162

namespace ThirdParty.BestHTTP.BestHTTP.Extensions
{
    public class BufferDesc : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A277030
        public void .cctor(){} // RVA: 0x7FFE8A2770E0
    }

    public class BufferPoolMemoryStream : Stream
    {
        public bool canWrite; // 0x28
        public bool allowGetBuffer; // 0x29
        public int capacity; // 0x2C
        public int length; // 0x30
        public byte[] internalBuffer; // 0x38
        public int initialIndex; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A270C70 | overloaded x7
        public void InternalConstructor(){} // RVA: 0x7FFE8A270D10
        public void CheckIfClosedThrowDisposed(){} // RVA: 0x7FFE8A270E80
        public void get_CanRead(){} // RVA: 0x7FFE8A270EF0
        public void get_CanSeek(){} // RVA: 0x7FFE8A270EF0
        public void get_CanWrite(){} // RVA: 0x7FFE8A270F00
        public void get_Capacity(){} // RVA: 0x7FFE8A270F10
        public void set_Capacity(){} // RVA: 0x7FFE8A270F80
        public void get_Length(){} // RVA: 0x7FFE8A2711C0
        public void get_Position(){} // RVA: 0x7FFE8A271230
        public void set_Position(){} // RVA: 0x7FFE8A2712A0
        public void Dispose(){} // RVA: 0x7FFE8A2713E0
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void GetBuffer(){} // RVA: 0x7FFE8A2714A0
        public void Read(){} // RVA: 0x7FFE8A271500
        public void ReadByte(){} // RVA: 0x7FFE8A2716E0
        public void Seek(){} // RVA: 0x7FFE8A271780
        public void CalculateNewCapacity(){} // RVA: 0x7FFE8A271990
        public void Expand(){} // RVA: 0x7FFE8A271A40
        public void SetLength(){} // RVA: 0x7FFE8A271B40
        public void ToArray(){} // RVA: 0x7FFE8A271DB0 | overloaded x2
        public void Write(){} // RVA: 0x7FFE8A271E80
        public void WriteByte(){} // RVA: 0x7FFE8A2720B0
        public void WriteTo(){} // RVA: 0x7FFE8A2721C0
    }

    public class BufferStore : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A276F90 | overloaded x2
    }

    public class CircularBuffer`1 : Object
    {
        public int _capacity;
        public int _count;
        public T[] buffer;

        // ── Methods ──
        public void get_Capacity(){} // RVA: 0x7FFE80E2EDB0
        public void set_Capacity(){} // RVA: 0x7FFE80E46530
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void set_Count(){} // RVA: 0x7FFE80E46530
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ExceptionHelper : Object
    {
        // ── Methods ──
        public void ServerClosedTCPStream(){} // RVA: 0x7FFE8A274910
    }

    public class Extensions : Object
    {
        // ── Methods ──
        public void AsciiToString(){} // RVA: 0x7FFE8A2722A0
        public void GetASCIIBytes(){} // RVA: 0x7FFE8A272370
        public void SendAsASCII(){} // RVA: 0x7FFE8A272450
        public void WriteLine(){} // RVA: 0x7FFE8A274570 | overloaded x5
        public void GetRequestPathAndQueryURL(){} // RVA: 0x7FFE8A2728D0
        public void FindOption(){} // RVA: 0x7FFE8A272940
        public void WriteArray(){} // RVA: 0x7FFE8A272B10
        public void IsHostIsAnIPAddress(){} // RVA: 0x7FFE8A272B50
        public void IsIpV4AddressValid(){} // RVA: 0x7FFE8A272D20
        public void IsIpV6AddressValid(){} // RVA: 0x7FFE8A272E50
        public void ToInt32(){} // RVA: 0x7FFE8A272F70
        public void ToInt64(){} // RVA: 0x7FFE8A272FA0
        public void ToDateTime(){} // RVA: 0x7FFE8A272FD0
        public void ToStrOrEmpty(){} // RVA: 0x7FFE8A273060
        public void ToBinaryStr(){} // RVA: 0x7FFE8A2730B0
        public void CalculateMD5Hash(){} // RVA: 0x7FFE8A2731E0 | overloaded x2
        public void Read(){} // RVA: 0x7FFE8A273690 | overloaded x2
        public void ReadPossibleQuotedText(){} // RVA: 0x7FFE8A2737C0
        public void SkipWhiteSpace(){} // RVA: 0x7FFE8A273A80
        public void TrimAndLower(){} // RVA: 0x7FFE8A273B30
        public void Peek(){} // RVA: 0x7FFE8A273CB0
        public void ParseOptionalHeader(){} // RVA: 0x7FFE8A273D40
        public void ParseQualityParams(){} // RVA: 0x7FFE8A273FC0
        public void ReadBuffer(){} // RVA: 0x7FFE8A274300 | overloaded x2
        public void WriteString(){} // RVA: 0x7FFE8A2743A0
        public void .cctor(){} // RVA: 0x7FFE8A274740
    }

    public class HeaderParser : KeyValuePairList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A274980
        public void Parse(){} // RVA: 0x7FFE8A2749F0
    }

    public class HeaderValue : Object
    {
        public string _key; // 0x10
        public string _value; // 0x18
        public System.Collections.Generic.List`1<BestHTTP.Extensions.HeaderValue> _options; // 0x20
        public object field_3; // 0x9BA

        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFE81116380
        public void set_Key(){} // RVA: 0x7FFE810FCE30
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void get_Options(){} // RVA: 0x7FFE811290C0
        public void set_Options(){} // RVA: 0x7FFE811290D0
        public void get_HasValue(){} // RVA: 0x7FFE838846A0
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void Parse(){} // RVA: 0x7FFE8A274BF0
        public void TryGetOption(){} // RVA: 0x7FFE8A274C10
        public void ParseImplementation(){} // RVA: 0x7FFE8A274E20
        public void ToString(){} // RVA: 0x7FFE8A2753B0
    }

    public class HeartbeatManager : Object
    {
        // ── Methods ──
        public void Subscribe(){} // RVA: 0x7FFE8A2755D0
        public void Unsubscribe(){} // RVA: 0x7FFE8A275770
        public void Update(){} // RVA: 0x7FFE8A275860
        public void .ctor(){} // RVA: 0x7FFE8A275B70
    }

    public class IHeartbeat
    {
        // ── Methods ──
        public void OnHeartbeatUpdate(){} // RVA: 0x7FFE80E46250
    }

    public class KeyValuePairList : Object
    {
        public System.Collections.Generic.List`1<BestHTTP.Extensions.HeaderValue> _values; // 0x10

        // ── Methods ──
        public void get_Values(){} // RVA: 0x7FFE81116380
        public void set_Values(){} // RVA: 0x7FFE810FCE30
        public void TryGet(){} // RVA: 0x7FFE8A275D40
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PooledBuffer : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE8A276E20
    }

    public class ReadOnlyBufferedStream : Stream
    {
        public System.IO.Stream stream; // 0x28
        public int READBUFFER;
        public byte[] buf; // 0x30
        public int available; // 0x38
        public int pos; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A276000 | overloaded x2
        public void Read(){} // RVA: 0x7FFE8A276140
        public void ReadByte(){} // RVA: 0x7FFE8A2762E0
        public void Dispose(){} // RVA: 0x7FFE8A2763B0
        public void get_CanRead(){} // RVA: 0x7FFE811E0850
        public void get_CanSeek(){} // RVA: 0x7FFE8A276470
        public void get_CanWrite(){} // RVA: 0x7FFE8A2764B0
        public void get_Length(){} // RVA: 0x7FFE8A2764F0
        public void get_Position(){} // RVA: 0x7FFE8A276530
        public void set_Position(){} // RVA: 0x7FFE8A276570
        public void Flush(){} // RVA: 0x7FFE8A2765B0
        public void Seek(){} // RVA: 0x7FFE8A2765F0
        public void SetLength(){} // RVA: 0x7FFE8A276630
        public void Write(){} // RVA: 0x7FFE8A276670
    }

    public class StreamList : Stream
    {
        public System.IO.Stream[] Streams; // 0x28
        public int CurrentIdx; // 0x30
        public object field_2; // 0x9C4
        public object field_3; // 0x9C5
        public object field_4; // 0x9C6

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2766B0
        public void get_CanRead(){} // RVA: 0x7FFE8A276760
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE8A2767C0
        public void Flush(){} // RVA: 0x7FFE8A276820
        public void get_Length(){} // RVA: 0x7FFE8A2768A0
        public void Read(){} // RVA: 0x7FFE8A276950
        public void Write(){} // RVA: 0x7FFE8A276AC0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE8A276B80
        public void get_Position(){} // RVA: 0x7FFE8A276CD0
        public void set_Position(){} // RVA: 0x7FFE8A276D20
        public void Seek(){} // RVA: 0x7FFE8A276D70
        public void SetLength(){} // RVA: 0x7FFE8A276DD0
    }

    public class VariableSizedBufferPool : Object
    {
        public byte[] NoData;

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFE8A277190
        public void set_IsEnabled(){} // RVA: 0x7FFE8A2771F0
        public void .cctor(){} // RVA: 0x7FFE8A277290
        public void Get(){} // RVA: 0x7FFE8A277770
        public void Release(){} // RVA: 0x7FFE8A277B00 | overloaded x2
        public void Resize(){} // RVA: 0x7FFE8A277D70
        public void GetStatistics(){} // RVA: 0x7FFE8A277F20
        public void Clear(){} // RVA: 0x7FFE8A2785B0
        public void Maintain(){} // RVA: 0x7FFE8A278710
        public void IsPowerOfTwo(){} // RVA: 0x7FFE8A278BE0
        public void NextPowerOf2(){} // RVA: 0x7FFE8A278BF0
        public void FindFreeBuffer(){} // RVA: 0x7FFE8A278C10
        public void AddFreeBuffer(){} // RVA: 0x7FFE8A278FF0
    }

    public class WWWAuthenticateHeaderParser : KeyValuePairList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2797D0
        public void ParseQuotedHeader(){} // RVA: 0x7FFE8A279840
    }

    public class WriteOnlyBufferedStream : Stream
    {
        public int _position; // 0x28
        public byte[] buffer; // 0x30
        public System.IO.Stream stream; // 0x38
        public object field_3; // 0x9CA
        public object field_4; // 0x9CB

        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7FFE810FB320
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE811E0850
        public void get_Length(){} // RVA: 0x7FFE8A2793D0
        public void get_Position(){} // RVA: 0x7FFE8A2793F0
        public void set_Position(){} // RVA: 0x7FFE8A279400
        public void .ctor(){} // RVA: 0x7FFE8A279450
        public void Flush(){} // RVA: 0x7FFE8A279590
        public void Write(){} // RVA: 0x7FFE8A279600
        public void Read(){} // RVA: 0x7FFE813240E0
        public void Seek(){} // RVA: 0x7FFE813240E0
        public void SetLength(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE8A279710
    }

}