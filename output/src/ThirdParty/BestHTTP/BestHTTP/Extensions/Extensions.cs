// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Extensions
// Classes: 19
// Methods: 173

namespace ThirdParty.BestHTTP.BestHTTP.Extensions
{
    public class BufferDesc : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA72980
        public void .cctor(){} // RVA: 0xA4BA5A0
    }

    public class BufferPoolMemoryStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4B4010
        public void InternalConstructor(){} // RVA: 0xA4B40B0
        public void CheckIfClosedThrowDisposed(){} // RVA: 0xA4B4220
        public void get_CanRead(){} // RVA: 0xA4B4290
        public void get_CanSeek(){} // RVA: 0xA4B4290
        public void get_CanWrite(){} // RVA: 0xA4B42A0
        public void get_Capacity(){} // RVA: 0xA4B42B0
        public void set_Capacity(){} // RVA: 0xA4B4320
        public void get_Length(){} // RVA: 0xA4B4560
        public void get_Position(){} // RVA: 0xA4B45D0
        public void set_Position(){} // RVA: 0xA4B4640
        public void Dispose(){} // RVA: 0xA4B4780
        public void Flush(){} // RVA: 0xB43310
        public void GetBuffer(){} // RVA: 0xA4B4840
        public void Read(){} // RVA: 0xA4B48A0
        public void ReadByte(){} // RVA: 0xA4B4A80
        public void Seek(){} // RVA: 0xA4B4B20
        public void CalculateNewCapacity(){} // RVA: 0xA4B4D30
        public void Expand(){} // RVA: 0xA4B4D90
        public void SetLength(){} // RVA: 0xA4B4E30
        public void ToArray(){} // RVA: 0xA4B50A0
        public void Write(){} // RVA: 0xA4B5170
        public void WriteByte(){} // RVA: 0xA4B53A0
        public void WriteTo(){} // RVA: 0xA4B54B0
    }

    public class BufferStore : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA728B0
    }

    public class BufferStore[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CircularBuffer`1 : Object
    {
        // ── Methods ──
        public void get_Capacity(){} // RVA: 0x87C130
        public void set_Capacity(){} // RVA: 0x8944F0
        public void get_Count(){} // RVA: 0x87C130
        public void set_Count(){} // RVA: 0x8944F0
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x8944F0
        public void Add(){} // RVA: 0xA94080
        public void Clear(){} // RVA: 0x894290
        public void ToString(){} // RVA: 0x87C0A0
    }

    public class ExceptionHelper : Object
    {
        // ── Methods ──
        public void ServerClosedTCPStream(){} // RVA: 0xA4B7DE0
    }

    public class Extensions : Object
    {
        // ── Methods ──
        public void AsciiToString(){} // RVA: 0xA4B5590
        public void GetASCIIBytes(){} // RVA: 0xA4B5670
        public void SendAsASCII(){} // RVA: 0xA4B5750
        public void WriteLine(){} // RVA: 0xA4B7A40
        public void GetRequestPathAndQueryURL(){} // RVA: 0xA4B5BD0
        public void FindOption(){} // RVA: 0xA4B5C40
        public void WriteArray(){} // RVA: 0xA4B5E10
        public void IsHostIsAnIPAddress(){} // RVA: 0xA4B5E50
        public void IsIpV4AddressValid(){} // RVA: 0xA4B6030
        public void IsIpV6AddressValid(){} // RVA: 0xA4B6160
        public void ToInt32(){} // RVA: 0xA4B6290
        public void ToInt64(){} // RVA: 0xA4B62C0
        public void ToDateTime(){} // RVA: 0xA4B62F0
        public void ToStrOrEmpty(){} // RVA: 0xA4B6380
        public void ToBinaryStr(){} // RVA: 0xA4B63A0
        public void CalculateMD5Hash(){} // RVA: 0xA4B64D0
        public void Read(){} // RVA: 0xA4B6970
        public void ReadPossibleQuotedText(){} // RVA: 0xA4B6A90
        public void SkipWhiteSpace(){} // RVA: 0xA4B6D30
        public void TrimAndLower(){} // RVA: 0xA4B6E50
        public void Peek(){} // RVA: 0xA4B7040
        public void ParseOptionalHeader(){} // RVA: 0xA4B70D0
        public void ParseQualityParams(){} // RVA: 0xA4B73E0
        public void ReadBuffer(){} // RVA: 0xA4B77D0
        public void WriteString(){} // RVA: 0xA4B7870
        public void .cctor(){} // RVA: 0xA4B7C10
    }

    public class HeaderParser : KeyValuePairList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4B7E50
        public void Parse(){} // RVA: 0xA4B7EC0
    }

    public class HeaderValue : Object
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0xB5DBF0
        public void set_Key(){} // RVA: 0xB44D60
        public void get_Value(){} // RVA: 0xB465B0
        public void set_Value(){} // RVA: 0xBA9BA0
        public void get_Options(){} // RVA: 0xB700F0
        public void set_Options(){} // RVA: 0xB70100
        public void get_HasValue(){} // RVA: 0x35BA440
        public void .ctor(){} // RVA: 0xB44D60
        public void Parse(){} // RVA: 0xA4B80C0
        public void TryGetOption(){} // RVA: 0xA4B80E0
        public void ParseImplementation(){} // RVA: 0xA4B8300
        public void ToString(){} // RVA: 0xA4B8880
    }

    public class HeaderValue[] : Array
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

    public class HeartbeatManager : Object
    {
        // ── Methods ──
        public void Subscribe(){} // RVA: 0xA4B8A50
        public void Unsubscribe(){} // RVA: 0xA4B8BF0
        public void Update(){} // RVA: 0xA4B8CE0
        public void .ctor(){} // RVA: 0xA4B8FF0
    }

    public class IHeartbeat
    {
        // ── Methods ──
        public void OnHeartbeatUpdate(){} // RVA: 0x8943F0
    }

    public class KeyValuePairList : Object
    {
        // ── Methods ──
        public void get_Values(){} // RVA: 0xB5DBF0
        public void set_Values(){} // RVA: 0xB44D60
        public void TryGet(){} // RVA: 0xA4B91C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PooledBuffer : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0xA72730
    }

    public class ReadOnlyBufferedStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4B94A0
        public void Read(){} // RVA: 0xA4B95E0
        public void ReadByte(){} // RVA: 0xA4B9780
        public void Dispose(){} // RVA: 0xA4B9850
        public void get_CanRead(){} // RVA: 0xC2E4C0
        public void get_CanSeek(){} // RVA: 0xA4B9910
        public void get_CanWrite(){} // RVA: 0xA4B9950
        public void get_Length(){} // RVA: 0xA4B9990
        public void get_Position(){} // RVA: 0xA4B99D0
        public void set_Position(){} // RVA: 0xA4B9A10
        public void Flush(){} // RVA: 0xA4B9A50
        public void Seek(){} // RVA: 0xA4B9A90
        public void SetLength(){} // RVA: 0xA4B9AD0
        public void Write(){} // RVA: 0xA4B9B10
    }

    public class StreamList : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4B9B50
        public void get_CanRead(){} // RVA: 0xA4B9C00
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0xA4B9C60
        public void Flush(){} // RVA: 0xA4B9CC0
        public void get_Length(){} // RVA: 0xA4B9D50
        public void Read(){} // RVA: 0xA4B9E00
        public void Write(){} // RVA: 0xA4B9F80
        public void Dispose(){} // RVA: 0xA4BA040
        public void get_Position(){} // RVA: 0xA4BA190
        public void set_Position(){} // RVA: 0xA4BA1E0
        public void Seek(){} // RVA: 0xA4BA230
        public void SetLength(){} // RVA: 0xA4BA290
    }

    public class VariableSizedBufferPool : Object
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0xA4BA6E0
        public void set_IsEnabled(){} // RVA: 0xA4BA740
        public void .cctor(){} // RVA: 0xA4BA7E0
        public void Get(){} // RVA: 0xA4BACD0
        public void Release(){} // RVA: 0xA4BB070
        public void Resize(){} // RVA: 0xA4BB2E0
        public void GetStatistics(){} // RVA: 0xA4BB490
        public void Clear(){} // RVA: 0xA4BBB00
        public void Maintain(){} // RVA: 0xA4BBC60
        public void IsPowerOfTwo(){} // RVA: 0xA4BC110
        public void NextPowerOf2(){} // RVA: 0xA4BC120
        public void FindFreeBuffer(){} // RVA: 0xA4BC140
        public void AddFreeBuffer(){} // RVA: 0xA4BC520
    }

    public class WWWAuthenticateHeaderParser : KeyValuePairList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4BCD10
        public void ParseQuotedHeader(){} // RVA: 0xA4BCD80
    }

    public class WriteOnlyBufferedStream : Stream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0xB43320
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0xC2E4C0
        public void get_Length(){} // RVA: 0xA4BC910
        public void get_Position(){} // RVA: 0xA4BC930
        public void set_Position(){} // RVA: 0xA4BC940
        public void .ctor(){} // RVA: 0xA4BC990
        public void Flush(){} // RVA: 0xA4BCAD0
        public void Write(){} // RVA: 0xA4BCB40
        public void Read(){} // RVA: 0xDAC980
        public void Seek(){} // RVA: 0xDAC980
        public void SetLength(){} // RVA: 0xB43310
        public void Dispose(){} // RVA: 0xA4BCC50
    }

}