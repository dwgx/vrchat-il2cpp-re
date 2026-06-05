// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Extensions
// Classes: 17
// Methods: 162

namespace ThirdParty.BestHTTP.BestHTTP.Extensions
{
    public class BufferDesc
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2C4CF0
        public void .cctor(){} // RVA: 0x7FFAFC2C4DA0
    }

    public class BufferPoolMemoryStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2BE930 | overloaded x7
        public void InternalConstructor(){} // RVA: 0x7FFAFC2BE9D0
        public void CheckIfClosedThrowDisposed(){} // RVA: 0x7FFAFC2BEB40
        public void get_CanRead(){} // RVA: 0x7FFAFC2BEBB0
        public void get_CanSeek(){} // RVA: 0x7FFAFC2BEBB0
        public void get_CanWrite(){} // RVA: 0x7FFAFC2BEBC0
        public void get_Capacity(){} // RVA: 0x7FFAFC2BEBD0
        public void set_Capacity(){} // RVA: 0x7FFAFC2BEC40
        public void get_Length(){} // RVA: 0x7FFAFC2BEE80
        public void get_Position(){} // RVA: 0x7FFAFC2BEEF0
        public void set_Position(){} // RVA: 0x7FFAFC2BEF60
        public void Dispose(){} // RVA: 0x7FFAFC2BF0A0
        public void Flush(){} // RVA: 0x7FFAF2D8D310
        public void GetBuffer(){} // RVA: 0x7FFAFC2BF160
        public void Read(){} // RVA: 0x7FFAFC2BF1C0
        public void ReadByte(){} // RVA: 0x7FFAFC2BF3A0
        public void Seek(){} // RVA: 0x7FFAFC2BF440
        public void CalculateNewCapacity(){} // RVA: 0x7FFAFC2BF650
        public void Expand(){} // RVA: 0x7FFAFC2BF700
        public void SetLength(){} // RVA: 0x7FFAFC2BF800
        public void ToArray(){} // RVA: 0x7FFAFC2BFA70 | overloaded x2
        public void Write(){} // RVA: 0x7FFAFC2BFB40
        public void WriteByte(){} // RVA: 0x7FFAFC2BFD70
        public void WriteTo(){} // RVA: 0x7FFAFC2BFE80
    }

    public class BufferStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2C4C50 | overloaded x2
    }

    public class CircularBuffer`1
    {
        // ── Methods ──
        public void get_Capacity(){} // RVA: 0x7FFAF2ABD840
        public void set_Capacity(){} // RVA: 0x7FFAF2AD4FA0
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void set_Count(){} // RVA: 0x7FFAF2AD4FA0
        public void get_Item(){} // RVA: 0x7FFAF2D33FA0
        public void set_Item(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2AD4FA0
        public void Add(){} // RVA: 0x7FFAF2D33FA0
        public void Clear(){} // RVA: 0x7FFAF2AD4A50
        public void ToString(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ExceptionHelper
    {
        // ── Methods ──
        public void ServerClosedTCPStream(){} // RVA: 0x7FFAFC2C25D0
    }

    public class Extensions
    {
        // ── Methods ──
        public void AsciiToString(){} // RVA: 0x7FFAFC2BFF60
        public void GetASCIIBytes(){} // RVA: 0x7FFAFC2C0030
        public void SendAsASCII(){} // RVA: 0x7FFAFC2C0110
        public void WriteLine(){} // RVA: 0x7FFAFC2C2230 | overloaded x5
        public void GetRequestPathAndQueryURL(){} // RVA: 0x7FFAFC2C0590
        public void FindOption(){} // RVA: 0x7FFAFC2C0600
        public void WriteArray(){} // RVA: 0x7FFAFC2C07D0
        public void IsHostIsAnIPAddress(){} // RVA: 0x7FFAFC2C0810
        public void IsIpV4AddressValid(){} // RVA: 0x7FFAFC2C09E0
        public void IsIpV6AddressValid(){} // RVA: 0x7FFAFC2C0B10
        public void ToInt32(){} // RVA: 0x7FFAFC2C0C30
        public void ToInt64(){} // RVA: 0x7FFAFC2C0C60
        public void ToDateTime(){} // RVA: 0x7FFAFC2C0C90
        public void ToStrOrEmpty(){} // RVA: 0x7FFAFC2C0D20
        public void ToBinaryStr(){} // RVA: 0x7FFAFC2C0D70
        public void CalculateMD5Hash(){} // RVA: 0x7FFAFC2C0EA0 | overloaded x2
        public void Read(){} // RVA: 0x7FFAFC2C1350 | overloaded x2
        public void ReadPossibleQuotedText(){} // RVA: 0x7FFAFC2C1480
        public void SkipWhiteSpace(){} // RVA: 0x7FFAFC2C1740
        public void TrimAndLower(){} // RVA: 0x7FFAFC2C17F0
        public void Peek(){} // RVA: 0x7FFAFC2C1970
        public void ParseOptionalHeader(){} // RVA: 0x7FFAFC2C1A00
        public void ParseQualityParams(){} // RVA: 0x7FFAFC2C1C80
        public void ReadBuffer(){} // RVA: 0x7FFAFC2C1FC0 | overloaded x2
        public void WriteString(){} // RVA: 0x7FFAFC2C2060
        public void .cctor(){} // RVA: 0x7FFAFC2C2400
    }

    public class HeaderParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2C2640
        public void Parse(){} // RVA: 0x7FFAFC2C26B0
    }

    public class HeaderValue
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFAF2DA8380
        public void set_Key(){} // RVA: 0x7FFAF2D8EE30
        public void get_Value(){} // RVA: 0x7FFAF2D907C0
        public void set_Value(){} // RVA: 0x7FFAF2DF3E80
        public void get_Options(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Options(){} // RVA: 0x7FFAF2DBB0D0
        public void get_HasValue(){} // RVA: 0x7FFAF567CB30
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void Parse(){} // RVA: 0x7FFAFC2C28B0
        public void TryGetOption(){} // RVA: 0x7FFAFC2C28D0
        public void ParseImplementation(){} // RVA: 0x7FFAFC2C2AE0
        public void ToString(){} // RVA: 0x7FFAFC2C3070
    }

    public class HeartbeatManager
    {
        // ── Methods ──
        public void Subscribe(){} // RVA: 0x7FFAFC2C3290
        public void Unsubscribe(){} // RVA: 0x7FFAFC2C3430
        public void Update(){} // RVA: 0x7FFAFC2C3520
        public void .ctor(){} // RVA: 0x7FFAFC2C3830
    }

    public class IHeartbeat
    {
        // ── Methods ──
        public void OnHeartbeatUpdate(){} // RVA: 0x7FFAF2AD4CC0
    }

    public class KeyValuePairList
    {
        // ── Methods ──
        public void get_Values(){} // RVA: 0x7FFAF2DA8380
        public void set_Values(){} // RVA: 0x7FFAF2D8EE30
        public void TryGet(){} // RVA: 0x7FFAFC2C3A00
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class PooledBuffer
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAFC2C4AE0
    }

    public class ReadOnlyBufferedStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2C3CC0 | overloaded x2
        public void Read(){} // RVA: 0x7FFAFC2C3E00
        public void ReadByte(){} // RVA: 0x7FFAFC2C3FA0
        public void Dispose(){} // RVA: 0x7FFAFC2C4070
        public void get_CanRead(){} // RVA: 0x7FFAF2E72850
        public void get_CanSeek(){} // RVA: 0x7FFAFC2C4130
        public void get_CanWrite(){} // RVA: 0x7FFAFC2C4170
        public void get_Length(){} // RVA: 0x7FFAFC2C41B0
        public void get_Position(){} // RVA: 0x7FFAFC2C41F0
        public void set_Position(){} // RVA: 0x7FFAFC2C4230
        public void Flush(){} // RVA: 0x7FFAFC2C4270
        public void Seek(){} // RVA: 0x7FFAFC2C42B0
        public void SetLength(){} // RVA: 0x7FFAFC2C42F0
        public void Write(){} // RVA: 0x7FFAFC2C4330
    }

    public class StreamList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2C4370
        public void get_CanRead(){} // RVA: 0x7FFAFC2C4420
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAFC2C4480
        public void Flush(){} // RVA: 0x7FFAFC2C44E0
        public void get_Length(){} // RVA: 0x7FFAFC2C4560
        public void Read(){} // RVA: 0x7FFAFC2C4610
        public void Write(){} // RVA: 0x7FFAFC2C4780 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAFC2C4840
        public void get_Position(){} // RVA: 0x7FFAFC2C4990
        public void set_Position(){} // RVA: 0x7FFAFC2C49E0
        public void Seek(){} // RVA: 0x7FFAFC2C4A30
        public void SetLength(){} // RVA: 0x7FFAFC2C4A90
    }

    public class VariableSizedBufferPool
    {
        public object CanRead;

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFAFC2C4E50
        public void set_IsEnabled(){} // RVA: 0x7FFAFC2C4EB0
        public void .cctor(){} // RVA: 0x7FFAFC2C4F50
        public void Get(){} // RVA: 0x7FFAFC2C5430
        public void Release(){} // RVA: 0x7FFAFC2C57C0 | overloaded x2
        public void Resize(){} // RVA: 0x7FFAFC2C5A30
        public void GetStatistics(){} // RVA: 0x7FFAFC2C5BE0
        public void Clear(){} // RVA: 0x7FFAFC2C6270
        public void Maintain(){} // RVA: 0x7FFAFC2C63D0
        public void IsPowerOfTwo(){} // RVA: 0x7FFAFC2C68A0
        public void NextPowerOf2(){} // RVA: 0x7FFAFC2C68B0
        public void FindFreeBuffer(){} // RVA: 0x7FFAFC2C68D0
        public void AddFreeBuffer(){} // RVA: 0x7FFAFC2C6CB0
    }

    public class WWWAuthenticateHeaderParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2C7490
        public void ParseQuotedHeader(){} // RVA: 0x7FFAFC2C7500
    }

    public class WriteOnlyBufferedStream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7FFAF2D8D320
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAF2E72850
        public void get_Length(){} // RVA: 0x7FFAFC2C7090
        public void get_Position(){} // RVA: 0x7FFAFC2C70B0
        public void set_Position(){} // RVA: 0x7FFAFC2C70C0
        public void .ctor(){} // RVA: 0x7FFAFC2C7110
        public void Flush(){} // RVA: 0x7FFAFC2C7250
        public void Write(){} // RVA: 0x7FFAFC2C72C0
        public void Read(){} // RVA: 0x7FFAF2FC9240
        public void Seek(){} // RVA: 0x7FFAF2FC9240
        public void SetLength(){} // RVA: 0x7FFAF2D8D310
        public void Dispose(){} // RVA: 0x7FFAFC2C73D0
    }

}