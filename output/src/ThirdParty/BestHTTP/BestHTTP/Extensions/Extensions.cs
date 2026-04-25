// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Extensions
// Classes: 17
// Methods: 162

namespace ThirdParty.BestHTTP.BestHTTP.Extensions
{
    public class BufferDesc : ValueType
    {
        public BestHTTP.Extensions.BufferDesc Empty;
        public byte[] buffer; // 0x10
        public System.DateTime released; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE1DA10
        public void .cctor(){} // RVA: 0x7FFACBE1DAC0
    }

    public class BufferPoolMemoryStream : Stream
    {
        public bool CanRead; // 0x28
        public bool CanSeek; // 0x29
        public int CanWrite; // 0x2C
        public int Capacity; // 0x30
        public byte[] Length; // 0x38
        public int Position; // 0x40
        public bool expandable; // 0x44
        public bool streamClosed; // 0x45
        public int position; // 0x48
        public int dirty_bytes; // 0x4C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE17650 | overloaded x7
        public void InternalConstructor(){} // RVA: 0x7FFACBE176F0
        public void CheckIfClosedThrowDisposed(){} // RVA: 0x7FFACBE17860
        public void get_CanRead(){} // RVA: 0x7FFACBE178D0
        public void get_CanSeek(){} // RVA: 0x7FFACBE178D0
        public void get_CanWrite(){} // RVA: 0x7FFACBE178E0
        public void get_Capacity(){} // RVA: 0x7FFACBE178F0
        public void set_Capacity(){} // RVA: 0x7FFACBE17960
        public void get_Length(){} // RVA: 0x7FFACBE17BA0
        public void get_Position(){} // RVA: 0x7FFACBE17C10
        public void set_Position(){} // RVA: 0x7FFACBE17C80
        public void Dispose(){} // RVA: 0x7FFACBE17DC0
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void GetBuffer(){} // RVA: 0x7FFACBE17E80
        public void Read(){} // RVA: 0x7FFACBE17EE0
        public void ReadByte(){} // RVA: 0x7FFACBE180C0
        public void Seek(){} // RVA: 0x7FFACBE18160
        public void CalculateNewCapacity(){} // RVA: 0x7FFACBE18370
        public void Expand(){} // RVA: 0x7FFACBE18420
        public void SetLength(){} // RVA: 0x7FFACBE18520
        public void ToArray(){} // RVA: 0x7FFACBE18790 | overloaded x2
        public void Write(){} // RVA: 0x7FFACBE18860
        public void WriteByte(){} // RVA: 0x7FFACBE18A90
        public void WriteTo(){} // RVA: 0x7FFACBE18BA0
    }

    public class BufferStore : ValueType
    {
        public long Size; // 0x10
        public System.Collections.Generic.List`1<BestHTTP.Extensions.BufferDesc> buffers; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE1D970 | overloaded x2
    }

    public class CircularBuffer`1 : Object
    {
        public int Capacity;
        public int Count;
        public T[] Item;
        public int startIdx;
        public int endIdx;

        // ── Methods ──
        public void get_Capacity(){} // RVA: 0x7FFAC2C59960
        public void set_Capacity(){} // RVA: 0x7FFAC2C70ED0
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void set_Count(){} // RVA: 0x7FFAC2C70ED0
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void ToString(){} // RVA: 0x7FFAC2C58E90
    }

    public class ExceptionHelper : Object
    {
        // ── Methods ──
        public void ServerClosedTCPStream(){} // RVA: 0x7FFACBE1B2F0
    }

    public class Extensions : Object
    {
        public System.Text.RegularExpressions.Regex validIpV4AddressRegex;

        // ── Methods ──
        public void AsciiToString(){} // RVA: 0x7FFACBE18C80
        public void GetASCIIBytes(){} // RVA: 0x7FFACBE18D50
        public void SendAsASCII(){} // RVA: 0x7FFACBE18E30
        public void WriteLine(){} // RVA: 0x7FFACBE1AF50 | overloaded x5
        public void GetRequestPathAndQueryURL(){} // RVA: 0x7FFACBE192B0
        public void FindOption(){} // RVA: 0x7FFACBE19320
        public void WriteArray(){} // RVA: 0x7FFACBE194F0
        public void IsHostIsAnIPAddress(){} // RVA: 0x7FFACBE19530
        public void IsIpV4AddressValid(){} // RVA: 0x7FFACBE19700
        public void IsIpV6AddressValid(){} // RVA: 0x7FFACBE19830
        public void ToInt32(){} // RVA: 0x7FFACBE19950
        public void ToInt64(){} // RVA: 0x7FFACBE19980
        public void ToDateTime(){} // RVA: 0x7FFACBE199B0
        public void ToStrOrEmpty(){} // RVA: 0x7FFACBE19A40
        public void ToBinaryStr(){} // RVA: 0x7FFACBE19A90
        public void CalculateMD5Hash(){} // RVA: 0x7FFACBE19BC0 | overloaded x2
        public void Read(){} // RVA: 0x7FFACBE1A070 | overloaded x2
        public void ReadPossibleQuotedText(){} // RVA: 0x7FFACBE1A1A0
        public void SkipWhiteSpace(){} // RVA: 0x7FFACBE1A460
        public void TrimAndLower(){} // RVA: 0x7FFACBE1A510
        public void Peek(){} // RVA: 0x7FFACBE1A690
        public void ParseOptionalHeader(){} // RVA: 0x7FFACBE1A720
        public void ParseQualityParams(){} // RVA: 0x7FFACBE1A9A0
        public void ReadBuffer(){} // RVA: 0x7FFACBE1ACE0 | overloaded x2
        public void WriteString(){} // RVA: 0x7FFACBE1AD80
        public void .cctor(){} // RVA: 0x7FFACBE1B120
    }

    public class HeaderParser : KeyValuePairList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE1B360
        public void Parse(){} // RVA: 0x7FFACBE1B3D0
    }

    public class HeaderValue : Object
    {
        public string Key; // 0x10
        public string Value; // 0x18
        public System.Collections.Generic.List`1<BestHTTP.Extensions.HeaderValue> Options; // 0x20

        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFAC2F3C380
        public void set_Key(){} // RVA: 0x7FFAC2F22E30
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void get_Options(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Options(){} // RVA: 0x7FFAC2F4F0D0
        public void get_HasValue(){} // RVA: 0x7FFAC557F540
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void Parse(){} // RVA: 0x7FFACBE1B5D0
        public void TryGetOption(){} // RVA: 0x7FFACBE1B5F0
        public void ParseImplementation(){} // RVA: 0x7FFACBE1B800
        public void ToString(){} // RVA: 0x7FFACBE1BD90
    }

    public class HeartbeatManager : Object
    {
        public System.Threading.ReaderWriterLockSlim rwLock; // 0x10
        public System.Collections.Generic.List`1<BestHTTP.Extensions.IHeartbeat> Heartbeats; // 0x18
        public BestHTTP.Extensions.IHeartbeat[] UpdateArray; // 0x20
        public System.DateTime LastUpdate; // 0x28

        // ── Methods ──
        public void Subscribe(){} // RVA: 0x7FFACBE1BFB0
        public void Unsubscribe(){} // RVA: 0x7FFACBE1C150
        public void Update(){} // RVA: 0x7FFACBE1C240
        public void .ctor(){} // RVA: 0x7FFACBE1C550
    }

    public class IHeartbeat
    {
        // ── Methods ──
        public void OnHeartbeatUpdate(){} // RVA: 0x7FFAC2C70BF0
    }

    public class KeyValuePairList : Object
    {
        public System.Collections.Generic.List`1<BestHTTP.Extensions.HeaderValue> Values; // 0x10

        // ── Methods ──
        public void get_Values(){} // RVA: 0x7FFAC2F3C380
        public void set_Values(){} // RVA: 0x7FFAC2F22E30
        public void TryGet(){} // RVA: 0x7FFACBE1C720
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PooledBuffer : ValueType
    {
        public byte[] Data; // 0x10
        public int Length; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFACBE1D800
    }

    public class ReadOnlyBufferedStream : Stream
    {
        public System.IO.Stream CanRead; // 0x28
        public int CanSeek;
        public byte[] CanWrite; // 0x30
        public int Length; // 0x38
        public int Position; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE1C9E0 | overloaded x2
        public void Read(){} // RVA: 0x7FFACBE1CB20
        public void ReadByte(){} // RVA: 0x7FFACBE1CCC0
        public void Dispose(){} // RVA: 0x7FFACBE1CD90
        public void get_CanRead(){} // RVA: 0x7FFAC3006850
        public void get_CanSeek(){} // RVA: 0x7FFACBE1CE50
        public void get_CanWrite(){} // RVA: 0x7FFACBE1CE90
        public void get_Length(){} // RVA: 0x7FFACBE1CED0
        public void get_Position(){} // RVA: 0x7FFACBE1CF10
        public void set_Position(){} // RVA: 0x7FFACBE1CF50
        public void Flush(){} // RVA: 0x7FFACBE1CF90
        public void Seek(){} // RVA: 0x7FFACBE1CFD0
        public void SetLength(){} // RVA: 0x7FFACBE1D010
        public void Write(){} // RVA: 0x7FFACBE1D050
    }

    public class StreamList : Stream
    {
        public System.IO.Stream[] CanRead; // 0x28
        public int CanSeek; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE1D090
        public void get_CanRead(){} // RVA: 0x7FFACBE1D140
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFACBE1D1A0
        public void Flush(){} // RVA: 0x7FFACBE1D200
        public void get_Length(){} // RVA: 0x7FFACBE1D280
        public void Read(){} // RVA: 0x7FFACBE1D330
        public void Write(){} // RVA: 0x7FFACBE1D4A0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFACBE1D560
        public void get_Position(){} // RVA: 0x7FFACBE1D6B0
        public void set_Position(){} // RVA: 0x7FFACBE1D700
        public void Seek(){} // RVA: 0x7FFACBE1D750
        public void SetLength(){} // RVA: 0x7FFACBE1D7B0
    }

    public class VariableSizedBufferPool : Object
    {
        public byte[] IsEnabled;
        public bool _isEnabled; // 0x8
        public System.TimeSpan RemoveOlderThan; // 0x10
        public System.TimeSpan RunMaintenanceEvery; // 0x18
        public long MinBufferSize; // 0x20
        public long MaxBufferSize; // 0x28
        public long MaxPoolSize; // 0x30
        public bool RemoveEmptyLists; // 0x38
        public bool IsDoubleReleaseCheckEnabled; // 0x39
        public System.Collections.Generic.List`1<BestHTTP.Extensions.BufferStore> FreeBuffers; // 0x40
        public System.DateTime lastMaintenance; // 0x48
        public long PoolSize; // 0x50
        public long GetBuffers; // 0x58
        public long ReleaseBuffers; // 0x60
        public System.Text.StringBuilder statiscticsBuilder; // 0x68
        public System.Threading.ReaderWriterLockSlim rwLock; // 0x70

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFACBE1DB70
        public void set_IsEnabled(){} // RVA: 0x7FFACBE1DBD0
        public void .cctor(){} // RVA: 0x7FFACBE1DC70
        public void Get(){} // RVA: 0x7FFACBE1E150
        public void Release(){} // RVA: 0x7FFACBE1E4E0 | overloaded x2
        public void Resize(){} // RVA: 0x7FFACBE1E750
        public void GetStatistics(){} // RVA: 0x7FFACBE1E900
        public void Clear(){} // RVA: 0x7FFACBE1EF90
        public void Maintain(){} // RVA: 0x7FFACBE1F0F0
        public void IsPowerOfTwo(){} // RVA: 0x7FFACBE1F5C0
        public void NextPowerOf2(){} // RVA: 0x7FFACBE1F5D0
        public void FindFreeBuffer(){} // RVA: 0x7FFACBE1F5F0
        public void AddFreeBuffer(){} // RVA: 0x7FFACBE1F9D0
    }

    public class WWWAuthenticateHeaderParser : KeyValuePairList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE201B0
        public void ParseQuotedHeader(){} // RVA: 0x7FFACBE20220
    }

    public class WriteOnlyBufferedStream : Stream
    {
        public int CanRead; // 0x28
        public byte[] CanSeek; // 0x30
        public System.IO.Stream CanWrite; // 0x38

        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7FFAC2F21320
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC3006850
        public void get_Length(){} // RVA: 0x7FFACBE1FDB0
        public void get_Position(){} // RVA: 0x7FFACBE1FDD0
        public void set_Position(){} // RVA: 0x7FFACBE1FDE0
        public void .ctor(){} // RVA: 0x7FFACBE1FE30
        public void Flush(){} // RVA: 0x7FFACBE1FF70
        public void Write(){} // RVA: 0x7FFACBE1FFE0
        public void Read(){} // RVA: 0x7FFAC34F9180
        public void Seek(){} // RVA: 0x7FFAC34F9180
        public void SetLength(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFACBE200F0
    }

}