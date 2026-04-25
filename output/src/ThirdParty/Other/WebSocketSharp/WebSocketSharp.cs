// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.WebSocketSharp
// Classes: 13
// Methods: 235

namespace ThirdParty.Other.WebSocketSharp
{
    public class CloseEventArgs : EventArgs
    {
        public bool PayloadData; // 0x10
        public ushort WasClean; // 0x12
        public WebSocketSharp.PayloadData _payloadData; // 0x18
        public string _reason; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0A4EF0 | overloaded x6
        public void get_PayloadData(){} // RVA: 0x7FFACC0A4FB0
        public void set_WasClean(){} // RVA: 0x7FFAC2FEB5F0
    }

    public class ErrorEventArgs : EventArgs
    {
        public System.Exception Exception; // 0x10
        public string Message; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0A5240
        public void get_Exception(){} // RVA: 0x7FFAC5CC4750
        public void get_Message(){} // RVA: 0x7FFAC58A1130
    }

    public class Ext : Object
    {
        public byte[] _last;
        public int _retry; // 0x8
        public System.Func`2<string,bool> CS$<>9__CachedAnonymousMethodDelegate1; // 0x10

        // ── Methods ──
        public void decompress(){} // RVA: 0x7FFACC09F730 | overloaded x2
        public void decompressToArray(){} // RVA: 0x7FFACC09F9D0
        public void Append(){} // RVA: 0x7FFACC09FB10
        public void CheckIfValidProtocols(){} // RVA: 0x7FFACC09FC70
        public void CheckWaitTime(){} // RVA: 0x7FFACC09FE50
        public void Contains(){} // RVA: 0x7FFACC0A2D50 | overloaded x4
        public void ContainsTwice(){} // RVA: 0x7FFACC09FF90
        public void CopyTo(){} // RVA: 0x7FFACC0A0170
        public void Decompress(){} // RVA: 0x7FFACC0A0240
        public void DecompressToArray(){} // RVA: 0x7FFACC0A02B0
        public void EqualsWith(){} // RVA: 0x7FFACC0A0340
        public void GetAbsolutePath(){} // RVA: 0x7FFACC0A0380
        public void GetMessage(){} // RVA: 0x7FFACC0A04C0
        public void GetValue(){} // RVA: 0x7FFACC0A06E0 | overloaded x2
        public void InternalToByteArray(){} // RVA: 0x7FFACC0A09B0 | overloaded x2
        public void IsCompressionExtension(){} // RVA: 0x7FFACC0A0AB0
        public void IsControl(){} // RVA: 0x7FFACC0A0B60
        public void IsData(){} // RVA: 0x7FFACC0A0B70 | overloaded x2
        public void IsReserved(){} // RVA: 0x7FFACC0A0B90 | overloaded x2
        public void IsSupported(){} // RVA: 0x7FFACC0A0BC0
        public void IsText(){} // RVA: 0x7FFACC0A0D70
        public void IsToken(){} // RVA: 0x7FFACC0A0FD0
        public void ReadBytes(){} // RVA: 0x7FFACC0A12E0 | overloaded x2
        public void ReadBytesAsync(){} // RVA: 0x7FFACC0A1870 | overloaded x2
        public void Reverse(){} // RVA: 0x7FFAC2C58F80
        public void SplitHeaderValue(){} // RVA: 0x7FFACC0A1C30
        public void ToByteArray(){} // RVA: 0x7FFACC0A1D60
        public void ToExtensionString(){} // RVA: 0x7FFACC0A1FC0
        public void ToUInt16(){} // RVA: 0x7FFACC0A21A0
        public void ToUInt64(){} // RVA: 0x7FFACC0A2250
        public void TryCreateWebSocketUri(){} // RVA: 0x7FFACC0A2300
        public void Unquote(){} // RVA: 0x7FFACC0A2930
        public void UTF8Decode(){} // RVA: 0x7FFACC0A2A30
        public void UTF8Encode(){} // RVA: 0x7FFACC0A2A70
        public void WriteBytes(){} // RVA: 0x7FFACC0A2AB0
        public void Emit(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetCookies(){} // RVA: 0x7FFACC0A2F50
        public void IsEnclosedIn(){} // RVA: 0x7FFACC0A30A0
        public void IsHostOrder(){} // RVA: 0x7FFAC98B7F90
        public void IsNullOrEmpty(){} // RVA: 0x7FFACC0A30F0
        public void IsPredefinedScheme(){} // RVA: 0x7FFACC0A3110
        public void MaybeUri(){} // RVA: 0x7FFACC0A3460
        public void SubArray(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Times(){} // RVA: 0x7FFACC0A3500
        public void ToHostOrder(){} // RVA: 0x7FFACC0A3550
        public void ToString(){} // RVA: 0x7FFAC2C58FF0
        public void ToUri(){} // RVA: 0x7FFACC0A36E0
        public void UrlDecode(){} // RVA: 0x7FFACC0A3800
        public void <CheckIfValidProtocols>b__0(){} // RVA: 0x7FFACC0A38C0
        public void .cctor(){} // RVA: 0x7FFACC0A3930
    }

    public class HttpBase : Object
    {
        public System.Collections.Specialized.NameValueCollection EntityBody; // 0x10
        public System.Version Headers; // 0x18
        public byte[] ProtocolVersion; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84642F0
        public void get_EntityBody(){} // RVA: 0x7FFACC0C2270
        public void get_Headers(){} // RVA: 0x7FFAC5CC4750
        public void get_ProtocolVersion(){} // RVA: 0x7FFAC58A1130
        public void readEntityBody(){} // RVA: 0x7FFACC0C23A0
        public void readHeaders(){} // RVA: 0x7FFACC0C25C0
        public void Read(){} // RVA: 0x7FFAC2E8DC40
        public void ToByteArray(){} // RVA: 0x7FFACC0C29F0
    }

    public class HttpRequest : HttpBase
    {
        public string _method; // 0x28
        public string _uri; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0C2C40 | overloaded x2
        public void CreateConnectRequest(){} // RVA: 0x7FFACC0C2DF0
        public void CreateWebSocketRequest(){} // RVA: 0x7FFACC0C2F80
        public void GetResponse(){} // RVA: 0x7FFACC0C31F0
        public void SetCookies(){} // RVA: 0x7FFACC0C3320
        public void ToString(){} // RVA: 0x7FFACC0C37E0
    }

    public class HttpResponse : HttpBase
    {
        public string Cookies; // 0x28
        public string HasConnectionClose; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0C2B50
        public void get_Cookies(){} // RVA: 0x7FFACC0C3BA0
        public void get_HasConnectionClose(){} // RVA: 0x7FFACC0C3CF0
        public void get_IsProxyAuthenticationRequired(){} // RVA: 0x7FFACC0C3D80
        public void get_IsRedirect(){} // RVA: 0x7FFACC0C3E00
        public void get_IsUnauthorized(){} // RVA: 0x7FFACC0C3ED0
        public void get_IsWebSocketResponse(){} // RVA: 0x7FFACC0C3F50
        public void get_StatusCode(){} // RVA: 0x7FFAC98DDAD0
        public void Parse(){} // RVA: 0x7FFACC0C4180
        public void ToString(){} // RVA: 0x7FFACC0C45A0
    }

    public class LogData : Object
    {
        public System.Diagnostics.StackFrame _caller; // 0x10
        public System.DateTime _date; // 0x18
        public 0x6B29F3A8 _level; // 0x20
        public string _message; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0BA7F0
        public void ToString(){} // RVA: 0x7FFACC0BA930
    }

    public class Logger : Object
    {
        public string _file; // 0x10
        public 0x6B29F3A8 _level; // 0x18
        public System.Action`2<WebSocketSharp.LogData,string> _output; // 0x20
        public object _sync; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0BAF20 | overloaded x2
        public void defaultOutput(){} // RVA: 0x7FFACC0BB0E0
        public void output(){} // RVA: 0x7FFACC0BB180
        public void writeToFile(){} // RVA: 0x7FFACC0BB430
        public void Debug(){} // RVA: 0x7FFACC0BB630
        public void Error(){} // RVA: 0x7FFACC0BB660
        public void Fatal(){} // RVA: 0x7FFACC0BB690
        public void Info(){} // RVA: 0x7FFACC0BB6A0
        public void Trace(){} // RVA: 0x7FFACC0BB6D0
        public void Warn(){} // RVA: 0x7FFACC0BB700
    }

    public class MessageEventArgs : EventArgs
    {
        public string Data; // 0x10
        public bool IsPing; // 0x18
        public 0x6B29F038 _opcode; // 0x19
        public byte[] _rawData; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0A4850 | overloaded x2
        public void get_Data(){} // RVA: 0x7FFACC0A49A0
        public void get_IsPing(){} // RVA: 0x7FFACC0A4A90
    }

    public class PayloadData : Object
    {
        public byte[] IncludesReservedCloseStatusCode; // 0x10
        public long ApplicationData; // 0x18
        public long Length; // 0x20
        public WebSocketSharp.PayloadData Empty;
        public ulong MaxLength; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACC0B96C0
        public void .ctor(){} // RVA: 0x7FFAC937ACD0 | overloaded x3
        public void get_IncludesReservedCloseStatusCode(){} // RVA: 0x7FFACC0B9960
        public void get_ApplicationData(){} // RVA: 0x7FFACC0B9AC0
        public void get_Length(){} // RVA: 0x7FFAC91BAEE0
        public void Mask(){} // RVA: 0x7FFACC0B9C10
        public void GetEnumerator(){} // RVA: 0x7FFACC0B9CB0
        public void ToArray(){} // RVA: 0x7FFAC5CC4750
        public void ToString(){} // RVA: 0x7FFACC0B9D50
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFACC0B9CB0
    }

    public class WebSocket : Object
    {
        public WebSocketSharp.Net.AuthenticationChallenge HasMessage; // 0x10
        public string Compression; // 0x18
        public bool SslConfiguration; // 0x20
        public System.Action WaitTime; // 0x28
        public 0x6B29F2A0 _compression; // 0x30
        public WebSocketSharp.Net.WebSockets.WebSocketContext _context; // 0x38
        public WebSocketSharp.Net.CookieCollection _cookies; // 0x40
        public WebSocketSharp.Net.NetworkCredential _credentials; // 0x48
        public bool _emitOnPing; // 0x50
        public bool _enableRedirection; // 0x51
        public System.Threading.AutoResetEvent _exitReceiving; // 0x58
        public string _extensions; // 0x60
        public bool _extensionsRequested; // 0x68
        public object _forConn; // 0x70
        public object _forMessageEventQueue; // 0x78
        public object _forSend; // 0x80
        public System.IO.MemoryStream _fragmentsBuffer; // 0x88
        public bool _fragmentsCompressed; // 0x90
        public 0x6B29F038 _fragmentsOpcode; // 0x91
        public bool _inContinuation; // 0x92
        public bool _inMessage; // 0x93
        public WebSocketSharp.Logger _logger; // 0x98
        public System.Action`1<WebSocketSharp.MessageEventArgs> _message; // 0xA0
        public System.Collections.Generic.Queue`1<WebSocketSharp.MessageEventArgs> _messageEventQueue; // 0xA8
        public uint _nonceCount; // 0xB0
        public string _origin; // 0xB8
        public bool _preAuth; // 0xC0
        public string _protocol; // 0xC8
        public string[] _protocols; // 0xD0
        public bool _protocolsRequested; // 0xD8
        public WebSocketSharp.Net.NetworkCredential _proxyCredentials; // 0xE0
        public System.Uri _proxyUri; // 0xE8
        public 0x6B29F458 _readyState; // 0xF0
        public System.Threading.AutoResetEvent _receivePong; // 0xF8
        public bool _secure; // 0x100
        public WebSocketSharp.Net.ClientSslConfiguration _sslConfig; // 0x108
        public System.IO.Stream _stream; // 0x110
        public System.Net.Sockets.TcpClient _tcpClient; // 0x118
        public System.Uri _uri; // 0x120
        public System.TimeSpan _waitTime; // 0x128
        public byte[] EmptyBytes;
        public int FragmentLength; // 0x8
        public System.Security.Cryptography.RandomNumberGenerator RandomNumber; // 0x10
        public System.EventHandler`1<WebSocketSharp.CloseEventArgs> OnClose; // 0x130
        public System.EventHandler`1<WebSocketSharp.ErrorEventArgs> OnError; // 0x138
        public System.EventHandler`1<WebSocketSharp.MessageEventArgs> OnMessage; // 0x140
        public System.EventHandler OnOpen; // 0x148

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACC0A5350
        public void .ctor(){} // RVA: 0x7FFACC0A5510
        public void get_HasMessage(){} // RVA: 0x7FFACC0A5A60
        public void set_Compression(){} // RVA: 0x7FFACC0A5B60
        public void get_SslConfiguration(){} // RVA: 0x7FFACC0A5E00
        public void set_WaitTime(){} // RVA: 0x7FFACC0A5FA0
        public void add_OnClose(){} // RVA: 0x7FFACC0A6330
        public void remove_OnClose(){} // RVA: 0x7FFACC0A6430
        public void add_OnError(){} // RVA: 0x7FFACC0A6530
        public void remove_OnError(){} // RVA: 0x7FFACC0A6630
        public void add_OnMessage(){} // RVA: 0x7FFACC0A6730
        public void remove_OnMessage(){} // RVA: 0x7FFACC0A6830
        public void add_OnOpen(){} // RVA: 0x7FFACC0A6930
        public void remove_OnOpen(){} // RVA: 0x7FFACC0A6A20
        public void checkHandshakeResponse(){} // RVA: 0x7FFACC0A6B10
        public void checkIfAvailable(){} // RVA: 0x7FFACC0A72F0 | overloaded x2
        public void checkReceivedFrame(){} // RVA: 0x7FFACC0A74B0
        public void close(){} // RVA: 0x7FFACC0A7770
        public void closeHandshake(){} // RVA: 0x7FFACC0A7CA0
        public void connect(){} // RVA: 0x7FFACC0A7E70
        public void createExtensions(){} // RVA: 0x7FFACC0A8270
        public void createHandshakeRequest(){} // RVA: 0x7FFACC0A8440
        public void doHandshake(){} // RVA: 0x7FFACC0A8840
        public void enqueueToMessageEventQueue(){} // RVA: 0x7FFACC0A8BE0
        public void error(){} // RVA: 0x7FFACC0A8CE0
        public void fatal(){} // RVA: 0x7FFACC0A8FB0 | overloaded x2
        public void init(){} // RVA: 0x7FFACC0A9100
        public void message(){} // RVA: 0x7FFACC0A93B0
        public void messagec(){} // RVA: 0x7FFACC0A9590
        public void open(){} // RVA: 0x7FFACC0A9880
        public void processCloseFrame(){} // RVA: 0x7FFACC0A9BE0
        public void processCookies(){} // RVA: 0x7FFACC0A9C90
        public void processDataFrame(){} // RVA: 0x7FFACC0A9D00
        public void processFragmentFrame(){} // RVA: 0x7FFACC0A9E50
        public void processPingFrame(){} // RVA: 0x7FFACC0AA220
        public void processPongFrame(){} // RVA: 0x7FFACC0AA370
        public void processReceivedFrame(){} // RVA: 0x7FFACC0AA430
        public void processSecWebSocketExtensionsServerHeader(){} // RVA: 0x7FFACC0AA950
        public void processUnsupportedFrame(){} // RVA: 0x7FFACC0AA9B0
        public void releaseClientResources(){} // RVA: 0x7FFACC0AAAB0
        public void releaseCommonResources(){} // RVA: 0x7FFACC0AAC10
        public void releaseResources(){} // RVA: 0x7FFACC0AADB0
        public void releaseServerResources(){} // RVA: 0x7FFACC0AB070
        public void send(){} // RVA: 0x7FFACC0AB1A0
        public void sendBytes(){} // RVA: 0x7FFACC0AB330
        public void sendHandshakeRequest(){} // RVA: 0x7FFACC0AB3F0
        public void sendHttpRequest(){} // RVA: 0x7FFACC0ABBD0
        public void sendProxyConnectRequest(){} // RVA: 0x7FFACC0ABE10
        public void setClientStream(){} // RVA: 0x7FFACC0AC400
        public void startReceiving(){} // RVA: 0x7FFACC0ACB90
        public void validateSecWebSocketAcceptHeader(){} // RVA: 0x7FFACC0ACEB0
        public void validateSecWebSocketExtensionsServerHeader(){} // RVA: 0x7FFACC0ACF60
        public void validateSecWebSocketProtocolServerHeader(){} // RVA: 0x7FFACC0AD4A0
        public void validateSecWebSocketVersionServerHeader(){} // RVA: 0x7FFACC0AD640
        public void CreateBase64Key(){} // RVA: 0x7FFACC0AD6C0
        public void CreateResponseKey(){} // RVA: 0x7FFACC0AD850
        public void Close(){} // RVA: 0x7FFACC0ADB50
        public void Connect(){} // RVA: 0x7FFACC0ADE00
        public void SetCookie(){} // RVA: 0x7FFACC0ADFB0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFACC0AE630
        public void <open>b__f(){} // RVA: 0x7FFACC0AE6E0
    }

    public class WebSocketException : Exception
    {
        public 0x6B29EF30 Code; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0BA5A0 | overloaded x6
        public void get_Code(){} // RVA: 0x7FFACC0BA7E0
    }

    public class WebSocketFrame : Object
    {
        public byte[] ExtendedPayloadLengthCount; // 0x10
        public 0x6B29EF88 FullPayloadLength; // 0x18
        public 0x6B29EFE0 IsClose; // 0x19
        public byte[] IsCompressed; // 0x20
        public 0x6B29F038 IsContinuation; // 0x28
        public WebSocketSharp.PayloadData IsData; // 0x30
        public byte IsFinal; // 0x38
        public 0x6B29F140 IsFragment; // 0x39
        public 0x6B29F140 IsMasked; // 0x3A
        public 0x6B29F140 IsPing; // 0x3B
        public byte[] IsPong;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACC0BB7D0
        public void .ctor(){} // RVA: 0x7FFACC0BB950 | overloaded x3
        public void get_ExtendedPayloadLengthCount(){} // RVA: 0x7FFACC0BBEB0
        public void get_FullPayloadLength(){} // RVA: 0x7FFACC0BBED0
        public void get_IsClose(){} // RVA: 0x7FFACC0BBFE0
        public void get_IsCompressed(){} // RVA: 0x7FFACC0BBFF0
        public void get_IsContinuation(){} // RVA: 0x7FFACC0BC000
        public void get_IsData(){} // RVA: 0x7FFACC0BC010
        public void get_IsFinal(){} // RVA: 0x7FFACC0BC030
        public void get_IsFragment(){} // RVA: 0x7FFACC0BC040
        public void get_IsMasked(){} // RVA: 0x7FFACC0BC060
        public void get_IsPing(){} // RVA: 0x7FFACC0BC070
        public void get_IsPong(){} // RVA: 0x7FFACC0BC080
        public void get_IsText(){} // RVA: 0x7FFACC0BC090
        public void get_Length(){} // RVA: 0x7FFACC0BC0A0
        public void get_Opcode(){} // RVA: 0x7FFAC9B93020
        public void get_PayloadData(){} // RVA: 0x7FFAC98DE3D0
        public void get_Rsv2(){} // RVA: 0x7FFACC0BC0E0
        public void get_Rsv3(){} // RVA: 0x7FFACC0BC0F0
        public void createMaskingKey(){} // RVA: 0x7FFACC0BC100
        public void dump(){} // RVA: 0x7FFACC0BC1A0
        public void print(){} // RVA: 0x7FFACC0BCAA0
        public void processHeader(){} // RVA: 0x7FFACC0BD0E0
        public void readExtendedPayloadLengthAsync(){} // RVA: 0x7FFACC0BD530
        public void readHeaderAsync(){} // RVA: 0x7FFACC0BD7C0
        public void readMaskingKeyAsync(){} // RVA: 0x7FFACC0BD910
        public void readPayloadDataAsync(){} // RVA: 0x7FFACC0BDB90
        public void CreateCloseFrame(){} // RVA: 0x7FFACC0BDED0
        public void CreatePingFrame(){} // RVA: 0x7FFACC0BDF50
        public void ReadFrameAsync(){} // RVA: 0x7FFACC0BE010
        public void Unmask(){} // RVA: 0x7FFACC0BE310
        public void GetEnumerator(){} // RVA: 0x7FFACC0BE480
        public void PrintToString(){} // RVA: 0x7FFACC0BE520
        public void ToArray(){} // RVA: 0x7FFACC0BE5B0
        public void ToString(){} // RVA: 0x7FFACC0BE910
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFACC0BE480
    }

}