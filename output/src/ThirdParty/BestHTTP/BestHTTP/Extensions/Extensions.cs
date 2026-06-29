// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Extensions
// Classes: 18
// Methods: 158

namespace ThirdParty.BestHTTP.BestHTTP.Extensions
{
    public class BufferDesc : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7FC3F30
        public void .cctor(){} // RVA: 0x7B164F0D0
    }

    public class BufferPoolMemoryStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1648BD0
        public void InternalConstructor(){} // RVA: 0x7B1648C70
        public void CheckIfClosedThrowDisposed(){} // RVA: 0x7B1648DE0
        public void get_CanRead(){} // RVA: 0x7B1648E50
        public void get_CanSeek(){} // RVA: 0x7B1648E50
        public void get_CanWrite(){} // RVA: 0x7B1648E60
        public void get_Capacity(){} // RVA: 0x7B1648E70
        public void set_Capacity(){} // RVA: 0x7B1648EE0
        public void get_Length(){} // RVA: 0x7B1649120
        public void get_Position(){} // RVA: 0x7B1649190
        public void set_Position(){} // RVA: 0x7B1649200
        public void Dispose(){} // RVA: 0x7B1649340
        public void Flush(){} // RVA: 0x7A80D7310
        public void GetBuffer(){} // RVA: 0x7B1649400
        public void Read(){} // RVA: 0x7B1649460
        public void ReadByte(){} // RVA: 0x7B1649640
        public void Seek(){} // RVA: 0x7B16496E0
        public void CalculateNewCapacity(){} // RVA: 0x7B16498F0
        public void Expand(){} // RVA: 0x7B16499A0
        public void SetLength(){} // RVA: 0x7B1649AA0
        public void ToArray(){} // RVA: 0x7B1649D10
        public void Write(){} // RVA: 0x7B1649DE0
        public void WriteByte(){} // RVA: 0x7B164A010
        public void WriteTo(){} // RVA: 0x7B164A120
    }

    public class BufferStore : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7FC3F00
    }

    public class BufferStore[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class CircularBuffer`1 : Object
    {
        // ── Methods ──
        public void get_Capacity(){} // RVA: 0x7A7E00710
        public void set_Capacity(){} // RVA: 0x7A7E189D0
        public void get_Count(){} // RVA: 0x7A7E00710
        public void set_Count(){} // RVA: 0x7A7E189D0
        public void get_Item(){} // RVA: 0x7A8051B10
        public void set_Item(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A7E189D0
        public void Add(){} // RVA: 0x7A8051B10
        public void Clear(){} // RVA: 0x7A7E18770
        public void ToString(){} // RVA: 0x7A7E00680
    }

    public class ExceptionHelper : Object
    {
        // ── Methods ──
        public void ServerClosedTCPStream(){} // RVA: 0x7B164C8B0
    }

    public class Extensions : Object
    {
        // ── Methods ──
        public void AsciiToString(){} // RVA: 0x7B164A200
        public void GetASCIIBytes(){} // RVA: 0x7B164A2E0
        public void SendAsASCII(){} // RVA: 0x7B164A3C0
        public void WriteLine(){} // RVA: 0x7B164C510
        public void GetRequestPathAndQueryURL(){} // RVA: 0x7B164A840
        public void FindOption(){} // RVA: 0x7B164A8B0
        public void WriteArray(){} // RVA: 0x7B164AA80
        public void IsHostIsAnIPAddress(){} // RVA: 0x7B164AAC0
        public void IsIpV4AddressValid(){} // RVA: 0x7B164ACA0
        public void IsIpV6AddressValid(){} // RVA: 0x7B164ADD0
        public void ToInt32(){} // RVA: 0x7B164AF00
        public void ToInt64(){} // RVA: 0x7B164AF30
        public void ToDateTime(){} // RVA: 0x7B164AF60
        public void ToStrOrEmpty(){} // RVA: 0x7B164AFF0
        public void ToBinaryStr(){} // RVA: 0x7B164B040
        public void CalculateMD5Hash(){} // RVA: 0x7B164B170
        public void Read(){} // RVA: 0x7B164B610
        public void ReadPossibleQuotedText(){} // RVA: 0x7B164B740
        public void SkipWhiteSpace(){} // RVA: 0x7B164BA00
        public void TrimAndLower(){} // RVA: 0x7B164BAB0
        public void Peek(){} // RVA: 0x7B164BC50
        public void ParseOptionalHeader(){} // RVA: 0x7B164BCE0
        public void ParseQualityParams(){} // RVA: 0x7B164BF60
        public void ReadBuffer(){} // RVA: 0x7B164C2A0
        public void WriteString(){} // RVA: 0x7B164C340
        public void .cctor(){} // RVA: 0x7B164C6E0
    }

    public class HeaderParser : KeyValuePairList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B164C920
        public void Parse(){} // RVA: 0x7B164C990
    }

    public class HeaderValue : Object
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0x7A80F2570
        public void set_Key(){} // RVA: 0x7A80D8E20
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void set_Value(){} // RVA: 0x7A813E420
        public void get_Options(){} // RVA: 0x7A81052C0
        public void set_Options(){} // RVA: 0x7A81052D0
        public void get_HasValue(){} // RVA: 0x7AA9C0770
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Parse(){} // RVA: 0x7B164CB90
        public void TryGetOption(){} // RVA: 0x7B164CBB0
        public void ParseImplementation(){} // RVA: 0x7B164CDD0
        public void ToString(){} // RVA: 0x7B164D360
    }

    public class HeartbeatManager : Object
    {
        // ── Methods ──
        public void Subscribe(){} // RVA: 0x7B164D580
        public void Unsubscribe(){} // RVA: 0x7B164D720
        public void Update(){} // RVA: 0x7B164D810
        public void .ctor(){} // RVA: 0x7B164DB20
    }

    public class IHeartbeat
    {
        // ── Methods ──
        public void OnHeartbeatUpdate(){} // RVA: 0x7A7E188D0
    }

    public class KeyValuePairList : Object
    {
        // ── Methods ──
        public void get_Values(){} // RVA: 0x7A80F2570
        public void set_Values(){} // RVA: 0x7A80D8E20
        public void TryGet(){} // RVA: 0x7B164DCF0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class PooledBuffer : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7A7FC3E20
    }

    public class ReadOnlyBufferedStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B164DFD0
        public void Read(){} // RVA: 0x7B164E110
        public void ReadByte(){} // RVA: 0x7B164E2B0
        public void Dispose(){} // RVA: 0x7B164E380
        public void get_CanRead(){} // RVA: 0x7A81BD750
        public void get_CanSeek(){} // RVA: 0x7B164E440
        public void get_CanWrite(){} // RVA: 0x7B164E480
        public void get_Length(){} // RVA: 0x7B164E4C0
        public void get_Position(){} // RVA: 0x7B164E500
        public void set_Position(){} // RVA: 0x7B164E540
        public void Flush(){} // RVA: 0x7B164E580
        public void Seek(){} // RVA: 0x7B164E5C0
        public void SetLength(){} // RVA: 0x7B164E600
        public void Write(){} // RVA: 0x7B164E640
    }

    public class StreamList : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B164E680
        public void get_CanRead(){} // RVA: 0x7B164E730
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7B164E790
        public void Flush(){} // RVA: 0x7B164E7F0
        public void get_Length(){} // RVA: 0x7B164E880
        public void Read(){} // RVA: 0x7B164E930
        public void Write(){} // RVA: 0x7B164EAB0
        public void Dispose(){} // RVA: 0x7B164EB70
        public void get_Position(){} // RVA: 0x7B164ECC0
        public void set_Position(){} // RVA: 0x7B164ED10
        public void Seek(){} // RVA: 0x7B164ED60
        public void SetLength(){} // RVA: 0x7B164EDC0
    }

    public class VariableSizedBufferPool : Object
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7B164F210
        public void set_IsEnabled(){} // RVA: 0x7B164F270
        public void .cctor(){} // RVA: 0x7B164F310
        public void Get(){} // RVA: 0x7B164F800
        public void Release(){} // RVA: 0x7B164FBA0
        public void Resize(){} // RVA: 0x7B164FE10
        public void GetStatistics(){} // RVA: 0x7B164FFC0
        public void Clear(){} // RVA: 0x7B1650650
        public void Maintain(){} // RVA: 0x7B16507B0
        public void IsPowerOfTwo(){} // RVA: 0x7B1650C60
        public void NextPowerOf2(){} // RVA: 0x7B1650C70
        public void FindFreeBuffer(){} // RVA: 0x7B1650C90
        public void AddFreeBuffer(){} // RVA: 0x7B1651070
    }

    public class WWWAuthenticateHeaderParser : KeyValuePairList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1651860
        public void ParseQuotedHeader(){} // RVA: 0x7B16518D0
    }

    public class WriteOnlyBufferedStream : Stream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7A80D7320
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7A81BD750
        public void get_Length(){} // RVA: 0x7B1651460
        public void get_Position(){} // RVA: 0x7B1651480
        public void set_Position(){} // RVA: 0x7B1651490
        public void .ctor(){} // RVA: 0x7B16514E0
        public void Flush(){} // RVA: 0x7B1651620
        public void Write(){} // RVA: 0x7B1651690
        public void Read(){} // RVA: 0x7A82D1450
        public void Seek(){} // RVA: 0x7A82D1450
        public void SetLength(){} // RVA: 0x7A80D7310
        public void Dispose(){} // RVA: 0x7B16517A0
    }

}