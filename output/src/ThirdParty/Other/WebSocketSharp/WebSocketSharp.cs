// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.WebSocketSharp
// Classes: 13
// Methods: 256

namespace ThirdParty.Other.WebSocketSharp
{
    public class CloseEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC5794B0 | overloaded x6
        public void get_PayloadData(){} // RVA: 0x7FFAFC579570
        public void get_Code(){} // RVA: 0x7FFAFC579800
        public void get_Reason(){} // RVA: 0x7FFAFC579810
        public void set_WasClean(){} // RVA: 0x7FFAF2E575F0
    }

    public class ErrorEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC579860
        public void get_Exception(){} // RVA: 0x7FFAF5E66D40
        public void get_Message(){} // RVA: 0x7FFAF59BF420
    }

    public class Ext
    {
        // ── Methods ──
        public void compress(){} // RVA: 0x7FFAFC573730
        public void decompress(){} // RVA: 0x7FFAFC573B90 | overloaded x2
        public void decompressToArray(){} // RVA: 0x7FFAFC573E30
        public void Append(){} // RVA: 0x7FFAFC573F70
        public void CheckIfAvailable(){} // RVA: 0x7FFAFC5740D0
        public void CheckIfValidProtocols(){} // RVA: 0x7FFAFC5741C0
        public void CheckWaitTime(){} // RVA: 0x7FFAFC5743A0
        public void Compress(){} // RVA: 0x7FFAFC5744E0
        public void Contains(){} // RVA: 0x7FFAFC577310 | overloaded x4
        public void ContainsTwice(){} // RVA: 0x7FFAFC574550
        public void CopyTo(){} // RVA: 0x7FFAFC574730
        public void Decompress(){} // RVA: 0x7FFAFC574800
        public void DecompressToArray(){} // RVA: 0x7FFAFC574870
        public void EqualsWith(){} // RVA: 0x7FFAFC574900
        public void GetAbsolutePath(){} // RVA: 0x7FFAFC574940
        public void GetMessage(){} // RVA: 0x7FFAFC574A80
        public void GetValue(){} // RVA: 0x7FFAFC574CA0 | overloaded x2
        public void InternalToByteArray(){} // RVA: 0x7FFAFC574F70 | overloaded x2
        public void IsCompressionExtension(){} // RVA: 0x7FFAFC575070
        public void IsControl(){} // RVA: 0x7FFAFC575120
        public void IsData(){} // RVA: 0x7FFAFC575130 | overloaded x2
        public void IsReserved(){} // RVA: 0x7FFAFC575150 | overloaded x2
        public void IsSupported(){} // RVA: 0x7FFAFC575180
        public void IsText(){} // RVA: 0x7FFAFC575330
        public void IsToken(){} // RVA: 0x7FFAFC575590
        public void ReadBytes(){} // RVA: 0x7FFAFC5758A0 | overloaded x2
        public void ReadBytesAsync(){} // RVA: 0x7FFAFC575E30 | overloaded x2
        public void Reverse(){} // RVA: 0x7FFAF2ABCE50
        public void SplitHeaderValue(){} // RVA: 0x7FFAFC5761F0
        public void ToByteArray(){} // RVA: 0x7FFAFC576320
        public void ToExtensionString(){} // RVA: 0x7FFAFC576580
        public void ToUInt16(){} // RVA: 0x7FFAFC576760
        public void ToUInt64(){} // RVA: 0x7FFAFC576810
        public void TryCreateWebSocketUri(){} // RVA: 0x7FFAFC5768C0
        public void Unquote(){} // RVA: 0x7FFAFC576EF0
        public void UTF8Decode(){} // RVA: 0x7FFAFC576FF0
        public void UTF8Encode(){} // RVA: 0x7FFAFC577030
        public void WriteBytes(){} // RVA: 0x7FFAFC577070
        public void Emit(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetCookies(){} // RVA: 0x7FFAFC577510
        public void IsEnclosedIn(){} // RVA: 0x7FFAFC577660
        public void IsHostOrder(){} // RVA: 0x7FFAF9BCFA00
        public void IsNullOrEmpty(){} // RVA: 0x7FFAFC5776B0
        public void IsPredefinedScheme(){} // RVA: 0x7FFAFC5776D0
        public void MaybeUri(){} // RVA: 0x7FFAFC577A20
        public void SubArray(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void Times(){} // RVA: 0x7FFAFC577AC0
        public void ToHostOrder(){} // RVA: 0x7FFAFC577B10
        public void ToString(){} // RVA: 0x7FFAF2ABCEC0
        public void ToUri(){} // RVA: 0x7FFAFC577CA0
        public void UrlDecode(){} // RVA: 0x7FFAFC577DC0
        public void <CheckIfValidProtocols>b__0(){} // RVA: 0x7FFAFC577E80
        public void .cctor(){} // RVA: 0x7FFAFC577EF0
    }

    public class HttpBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF877CD00
        public void get_EntityBody(){} // RVA: 0x7FFAFC598BB0
        public void get_Headers(){} // RVA: 0x7FFAF5E66D40
        public void get_ProtocolVersion(){} // RVA: 0x7FFAF59BF420
        public void readEntityBody(){} // RVA: 0x7FFAFC598CE0
        public void readHeaders(){} // RVA: 0x7FFAFC598F00
        public void Read(){} // RVA: 0x7FFAF2D33FA0
        public void ToByteArray(){} // RVA: 0x7FFAFC599330
    }

    public class HttpRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC599580 | overloaded x2
        public void CreateConnectRequest(){} // RVA: 0x7FFAFC599730
        public void CreateWebSocketRequest(){} // RVA: 0x7FFAFC5998C0
        public void GetResponse(){} // RVA: 0x7FFAFC599B30
        public void SetCookies(){} // RVA: 0x7FFAFC599C60
        public void ToString(){} // RVA: 0x7FFAFC59A120
    }

    public class HttpResponse
    {
        public object CertificateSelectionCallback;
        public object CertificateValidationCallback;
        public object CheckCertificateRevocation;
        public object EnabledSslProtocols;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC599490
        public void get_Cookies(){} // RVA: 0x7FFAFC59A4E0
        public void get_HasConnectionClose(){} // RVA: 0x7FFAFC59A630
        public void get_IsProxyAuthenticationRequired(){} // RVA: 0x7FFAFC59A6C0
        public void get_IsRedirect(){} // RVA: 0x7FFAFC59A740
        public void get_IsUnauthorized(){} // RVA: 0x7FFAFC59A810
        public void get_IsWebSocketResponse(){} // RVA: 0x7FFAFC59A890
        public void get_StatusCode(){} // RVA: 0x7FFAF9BF5590
        public void Parse(){} // RVA: 0x7FFAFC59AAC0
        public void ToString(){} // RVA: 0x7FFAFC59AEE0
    }

    public class LogData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC590C60
        public void get_Level(){} // RVA: 0x7FFAF6E8C7A0
        public void get_Message(){} // RVA: 0x7FFAF9BF5590
        public void ToString(){} // RVA: 0x7FFAFC590DA0
    }

    public class Logger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC591390 | overloaded x2
        public void set_Output(){} // RVA: 0x7FFAFC591550
        public void defaultOutput(){} // RVA: 0x7FFAFC5916F0
        public void output(){} // RVA: 0x7FFAFC591790
        public void writeToFile(){} // RVA: 0x7FFAFC591A40
        public void Debug(){} // RVA: 0x7FFAFC591C40
        public void Error(){} // RVA: 0x7FFAFC591C70
        public void Fatal(){} // RVA: 0x7FFAFC591CA0
        public void Info(){} // RVA: 0x7FFAFC591CB0
        public void Trace(){} // RVA: 0x7FFAFC591CE0
        public void Warn(){} // RVA: 0x7FFAFC591D10
    }

    public class MessageEventArgs
    {
        public object PayloadData;
        public object Code;
        public object Reason;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC578E10 | overloaded x2
        public void get_Data(){} // RVA: 0x7FFAFC578F60
        public void get_IsPing(){} // RVA: 0x7FFAFC579050
        public void get_RawData(){} // RVA: 0x7FFAF94D4380
    }

    public class PayloadData
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC58FB30
        public void .ctor(){} // RVA: 0x7FFAF9692550 | overloaded x3
        public void get_IncludesReservedCloseStatusCode(){} // RVA: 0x7FFAFC58FDD0
        public void get_ApplicationData(){} // RVA: 0x7FFAFC58FF30
        public void get_Length(){} // RVA: 0x7FFAF94D4380
        public void Mask(){} // RVA: 0x7FFAFC590080
        public void GetEnumerator(){} // RVA: 0x7FFAFC590120
        public void ToArray(){} // RVA: 0x7FFAF5E66D40
        public void ToString(){} // RVA: 0x7FFAFC5901C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAFC590120
    }

    public class WebSocket
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC579970
        public void .ctor(){} // RVA: 0x7FFAFC579B30
        public void get_HasMessage(){} // RVA: 0x7FFAFC57A080
        public void set_Compression(){} // RVA: 0x7FFAFC57A180
        public void get_IsSecure(){} // RVA: 0x7FFAFC57A420
        public void get_Log(){} // RVA: 0x7FFAFC57A430
        public void get_SslConfiguration(){} // RVA: 0x7FFAFC57A440
        public void set_WaitTime(){} // RVA: 0x7FFAFC57A5E0
        public void add_OnClose(){} // RVA: 0x7FFAFC57A970
        public void remove_OnClose(){} // RVA: 0x7FFAFC57AA70
        public void add_OnError(){} // RVA: 0x7FFAFC57AB70
        public void remove_OnError(){} // RVA: 0x7FFAFC57AC70
        public void add_OnMessage(){} // RVA: 0x7FFAFC57AD70
        public void remove_OnMessage(){} // RVA: 0x7FFAFC57AE70
        public void add_OnOpen(){} // RVA: 0x7FFAFC57AF70
        public void remove_OnOpen(){} // RVA: 0x7FFAFC57B060
        public void checkHandshakeResponse(){} // RVA: 0x7FFAFC57B150
        public void checkIfAvailable(){} // RVA: 0x7FFAFC57B930 | overloaded x2
        public void checkReceivedFrame(){} // RVA: 0x7FFAFC57BAF0
        public void close(){} // RVA: 0x7FFAFC57BDB0
        public void closeAsync(){} // RVA: 0x7FFAFC57C2E0
        public void closeHandshake(){} // RVA: 0x7FFAFC57C4E0
        public void connect(){} // RVA: 0x7FFAFC57C6B0
        public void createExtensions(){} // RVA: 0x7FFAFC57CAB0
        public void createHandshakeRequest(){} // RVA: 0x7FFAFC57CC80
        public void doHandshake(){} // RVA: 0x7FFAFC57D080
        public void enqueueToMessageEventQueue(){} // RVA: 0x7FFAFC57D420
        public void error(){} // RVA: 0x7FFAFC57D520
        public void fatal(){} // RVA: 0x7FFAFC57D7F0 | overloaded x2
        public void init(){} // RVA: 0x7FFAFC57D940
        public void message(){} // RVA: 0x7FFAFC57DBF0
        public void messagec(){} // RVA: 0x7FFAFC57DDD0
        public void open(){} // RVA: 0x7FFAFC57E0C0
        public void processCloseFrame(){} // RVA: 0x7FFAFC57E420
        public void processCookies(){} // RVA: 0x7FFAFC57E4D0
        public void processDataFrame(){} // RVA: 0x7FFAFC57E540
        public void processFragmentFrame(){} // RVA: 0x7FFAFC57E690
        public void processPingFrame(){} // RVA: 0x7FFAFC57EA60
        public void processPongFrame(){} // RVA: 0x7FFAFC57EBB0
        public void processReceivedFrame(){} // RVA: 0x7FFAFC57EC70
        public void processSecWebSocketExtensionsServerHeader(){} // RVA: 0x7FFAFC57F190
        public void processUnsupportedFrame(){} // RVA: 0x7FFAFC57F1F0
        public void releaseClientResources(){} // RVA: 0x7FFAFC57F2F0
        public void releaseCommonResources(){} // RVA: 0x7FFAFC57F450
        public void releaseResources(){} // RVA: 0x7FFAFC57F5F0
        public void releaseServerResources(){} // RVA: 0x7FFAFC57F8B0
        public void send(){} // RVA: 0x7FFAFC5802D0 | overloaded x4
        public void sendBytes(){} // RVA: 0x7FFAFC5805B0
        public void sendHandshakeRequest(){} // RVA: 0x7FFAFC580670
        public void sendHttpRequest(){} // RVA: 0x7FFAFC580E50
        public void sendProxyConnectRequest(){} // RVA: 0x7FFAFC581090
        public void setClientStream(){} // RVA: 0x7FFAFC581680
        public void startReceiving(){} // RVA: 0x7FFAFC581E10
        public void validateSecWebSocketAcceptHeader(){} // RVA: 0x7FFAFC582130
        public void validateSecWebSocketExtensionsServerHeader(){} // RVA: 0x7FFAFC5821E0
        public void validateSecWebSocketProtocolServerHeader(){} // RVA: 0x7FFAFC582720
        public void validateSecWebSocketVersionServerHeader(){} // RVA: 0x7FFAFC5828C0
        public void CheckSendParameter(){} // RVA: 0x7FFAFC582940
        public void CreateBase64Key(){} // RVA: 0x7FFAFC582980
        public void CreateResponseKey(){} // RVA: 0x7FFAFC582B10
        public void Close(){} // RVA: 0x7FFAFC582E10
        public void CloseAsync(){} // RVA: 0x7FFAFC582FD0
        public void Connect(){} // RVA: 0x7FFAFC583190
        public void ConnectAsync(){} // RVA: 0x7FFAFC583340
        public void Send(){} // RVA: 0x7FFAFC583690
        public void SetCookie(){} // RVA: 0x7FFAFC583890
        public void SetProxy(){} // RVA: 0x7FFAFC583F10
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAFC584A00
        public void <open>b__f(){} // RVA: 0x7FFAFC584AB0
    }

    public class WebSocketException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC590A10 | overloaded x6
        public void get_Code(){} // RVA: 0x7FFAFC590C50
    }

    public class WebSocketFrame
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC592000
        public void .ctor(){} // RVA: 0x7FFAFC592290 | overloaded x4
        public void get_ExtendedPayloadLengthCount(){} // RVA: 0x7FFAFC5927F0
        public void get_FullPayloadLength(){} // RVA: 0x7FFAFC592810
        public void get_IsClose(){} // RVA: 0x7FFAFC592920
        public void get_IsCompressed(){} // RVA: 0x7FFAFC592930
        public void get_IsContinuation(){} // RVA: 0x7FFAFC592940
        public void get_IsData(){} // RVA: 0x7FFAFC592950
        public void get_IsFinal(){} // RVA: 0x7FFAFC592970
        public void get_IsFragment(){} // RVA: 0x7FFAFC592980
        public void get_IsMasked(){} // RVA: 0x7FFAFC5929A0
        public void get_IsPing(){} // RVA: 0x7FFAFC5929B0
        public void get_IsPong(){} // RVA: 0x7FFAFC5929C0
        public void get_IsText(){} // RVA: 0x7FFAFC5929D0
        public void get_Length(){} // RVA: 0x7FFAFC5929E0
        public void get_Opcode(){} // RVA: 0x7FFAF9EAB730
        public void get_PayloadData(){} // RVA: 0x7FFAF9BF5E90
        public void get_Rsv2(){} // RVA: 0x7FFAFC592A20
        public void get_Rsv3(){} // RVA: 0x7FFAFC592A30
        public void createMaskingKey(){} // RVA: 0x7FFAFC592A40
        public void dump(){} // RVA: 0x7FFAFC592AE0
        public void print(){} // RVA: 0x7FFAFC5933E0
        public void processHeader(){} // RVA: 0x7FFAFC593A20
        public void readExtendedPayloadLengthAsync(){} // RVA: 0x7FFAFC593E70
        public void readHeaderAsync(){} // RVA: 0x7FFAFC594100
        public void readMaskingKeyAsync(){} // RVA: 0x7FFAFC594250
        public void readPayloadDataAsync(){} // RVA: 0x7FFAFC5944D0
        public void CreateCloseFrame(){} // RVA: 0x7FFAFC594810
        public void CreatePingFrame(){} // RVA: 0x7FFAFC594890
        public void ReadFrameAsync(){} // RVA: 0x7FFAFC594950
        public void Unmask(){} // RVA: 0x7FFAFC594C50
        public void GetEnumerator(){} // RVA: 0x7FFAFC594DC0
        public void PrintToString(){} // RVA: 0x7FFAFC594E60
        public void ToArray(){} // RVA: 0x7FFAFC594EF0
        public void ToString(){} // RVA: 0x7FFAFC595250
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAFC594DC0
    }

}