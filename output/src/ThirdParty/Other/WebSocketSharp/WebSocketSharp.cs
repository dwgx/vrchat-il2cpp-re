// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.WebSocketSharp
// Classes: 13
// Methods: 256

namespace ThirdParty.Other.WebSocketSharp
{
    public class CloseEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9AC94B0 | overloaded x6
        public void get_PayloadData(){} // RVA: 0x9AC9570
        public void get_Code(){} // RVA: 0x9AC9800
        public void get_Reason(){} // RVA: 0x9AC9810
        public void set_WasClean(){} // RVA: 0x3A75F0
    }

    public class ErrorEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9AC9860
        public void get_Exception(){} // RVA: 0x33B6D40
        public void get_Message(){} // RVA: 0x2F0F420
    }

    public class Ext
    {
        // ── Methods ──
        public void compress(){} // RVA: 0x9AC3730
        public void decompress(){} // RVA: 0x9AC3B90 | overloaded x2
        public void decompressToArray(){} // RVA: 0x9AC3E30
        public void Append(){} // RVA: 0x9AC3F70
        public void CheckIfAvailable(){} // RVA: 0x9AC40D0
        public void CheckIfValidProtocols(){} // RVA: 0x9AC41C0
        public void CheckWaitTime(){} // RVA: 0x9AC43A0
        public void Compress(){} // RVA: 0x9AC44E0
        public void Contains(){} // RVA: 0x9AC7310 | overloaded x4
        public void ContainsTwice(){} // RVA: 0x9AC4550
        public void CopyTo(){} // RVA: 0x9AC4730
        public void Decompress(){} // RVA: 0x9AC4800
        public void DecompressToArray(){} // RVA: 0x9AC4870
        public void EqualsWith(){} // RVA: 0x9AC4900
        public void GetAbsolutePath(){} // RVA: 0x9AC4940
        public void GetMessage(){} // RVA: 0x9AC4A80
        public void GetValue(){} // RVA: 0x9AC4CA0 | overloaded x2
        public void InternalToByteArray(){} // RVA: 0x9AC4F70 | overloaded x2
        public void IsCompressionExtension(){} // RVA: 0x9AC5070
        public void IsControl(){} // RVA: 0x9AC5120
        public void IsData(){} // RVA: 0x9AC5130 | overloaded x2
        public void IsReserved(){} // RVA: 0x9AC5150 | overloaded x2
        public void IsSupported(){} // RVA: 0x9AC5180
        public void IsText(){} // RVA: 0x9AC5330
        public void IsToken(){} // RVA: 0x9AC5590
        public void ReadBytes(){} // RVA: 0x9AC58A0 | overloaded x2
        public void ReadBytesAsync(){} // RVA: 0x9AC5E30 | overloaded x2
        public void Reverse(){} // RVA: 0xCE50
        public void SplitHeaderValue(){} // RVA: 0x9AC61F0
        public void ToByteArray(){} // RVA: 0x9AC6320
        public void ToExtensionString(){} // RVA: 0x9AC6580
        public void ToUInt16(){} // RVA: 0x9AC6760
        public void ToUInt64(){} // RVA: 0x9AC6810
        public void TryCreateWebSocketUri(){} // RVA: 0x9AC68C0
        public void Unquote(){} // RVA: 0x9AC6EF0
        public void UTF8Decode(){} // RVA: 0x9AC6FF0
        public void UTF8Encode(){} // RVA: 0x9AC7030
        public void WriteBytes(){} // RVA: 0x9AC7070
        public void Emit(){} // RVA: 0x283FA0 | overloaded x2
        public void GetCookies(){} // RVA: 0x9AC7510
        public void IsEnclosedIn(){} // RVA: 0x9AC7660
        public void IsHostOrder(){} // RVA: 0x711FA00
        public void IsNullOrEmpty(){} // RVA: 0x9AC76B0
        public void IsPredefinedScheme(){} // RVA: 0x9AC76D0
        public void MaybeUri(){} // RVA: 0x9AC7A20
        public void SubArray(){} // RVA: 0x283FA0 | overloaded x2
        public void Times(){} // RVA: 0x9AC7AC0
        public void ToHostOrder(){} // RVA: 0x9AC7B10
        public void ToString(){} // RVA: 0xCEC0
        public void ToUri(){} // RVA: 0x9AC7CA0
        public void UrlDecode(){} // RVA: 0x9AC7DC0
        public void <CheckIfValidProtocols>b__0(){} // RVA: 0x9AC7E80
        public void .cctor(){} // RVA: 0x9AC7EF0
    }

    public class HttpBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CCCD00
        public void get_EntityBody(){} // RVA: 0x9AE8BB0
        public void get_Headers(){} // RVA: 0x33B6D40
        public void get_ProtocolVersion(){} // RVA: 0x2F0F420
        public void readEntityBody(){} // RVA: 0x9AE8CE0
        public void readHeaders(){} // RVA: 0x9AE8F00
        public void Read(){} // RVA: 0x283FA0
        public void ToByteArray(){} // RVA: 0x9AE9330
    }

    public class HttpRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9AE9580 | overloaded x2
        public void CreateConnectRequest(){} // RVA: 0x9AE9730
        public void CreateWebSocketRequest(){} // RVA: 0x9AE98C0
        public void GetResponse(){} // RVA: 0x9AE9B30
        public void SetCookies(){} // RVA: 0x9AE9C60
        public void ToString(){} // RVA: 0x9AEA120
    }

    public class HttpResponse
    {
        public object CertificateSelectionCallback;
        public object CertificateValidationCallback;
        public object CheckCertificateRevocation;
        public object EnabledSslProtocols;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9AE9490
        public void get_Cookies(){} // RVA: 0x9AEA4E0
        public void get_HasConnectionClose(){} // RVA: 0x9AEA630
        public void get_IsProxyAuthenticationRequired(){} // RVA: 0x9AEA6C0
        public void get_IsRedirect(){} // RVA: 0x9AEA740
        public void get_IsUnauthorized(){} // RVA: 0x9AEA810
        public void get_IsWebSocketResponse(){} // RVA: 0x9AEA890
        public void get_StatusCode(){} // RVA: 0x7145590
        public void Parse(){} // RVA: 0x9AEAAC0
        public void ToString(){} // RVA: 0x9AEAEE0
    }

    public class LogData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9AE0C60
        public void get_Level(){} // RVA: 0x43DC7A0
        public void get_Message(){} // RVA: 0x7145590
        public void ToString(){} // RVA: 0x9AE0DA0
    }

    public class Logger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9AE1390 | overloaded x2
        public void set_Output(){} // RVA: 0x9AE1550
        public void defaultOutput(){} // RVA: 0x9AE16F0
        public void output(){} // RVA: 0x9AE1790
        public void writeToFile(){} // RVA: 0x9AE1A40
        public void Debug(){} // RVA: 0x9AE1C40
        public void Error(){} // RVA: 0x9AE1C70
        public void Fatal(){} // RVA: 0x9AE1CA0
        public void Info(){} // RVA: 0x9AE1CB0
        public void Trace(){} // RVA: 0x9AE1CE0
        public void Warn(){} // RVA: 0x9AE1D10
    }

    public class MessageEventArgs
    {
        public object PayloadData;
        public object Code;
        public object Reason;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9AC8E10 | overloaded x2
        public void get_Data(){} // RVA: 0x9AC8F60
        public void get_IsPing(){} // RVA: 0x9AC9050
        public void get_RawData(){} // RVA: 0x6A24380
    }

    public class PayloadData
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x9ADFB30
        public void .ctor(){} // RVA: 0x6BE2550 | overloaded x3
        public void get_IncludesReservedCloseStatusCode(){} // RVA: 0x9ADFDD0
        public void get_ApplicationData(){} // RVA: 0x9ADFF30
        public void get_Length(){} // RVA: 0x6A24380
        public void Mask(){} // RVA: 0x9AE0080
        public void GetEnumerator(){} // RVA: 0x9AE0120
        public void ToArray(){} // RVA: 0x33B6D40
        public void ToString(){} // RVA: 0x9AE01C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x9AE0120
    }

    public class WebSocket
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x9AC9970
        public void .ctor(){} // RVA: 0x9AC9B30
        public void get_HasMessage(){} // RVA: 0x9ACA080
        public void set_Compression(){} // RVA: 0x9ACA180
        public void get_IsSecure(){} // RVA: 0x9ACA420
        public void get_Log(){} // RVA: 0x9ACA430
        public void get_SslConfiguration(){} // RVA: 0x9ACA440
        public void set_WaitTime(){} // RVA: 0x9ACA5E0
        public void add_OnClose(){} // RVA: 0x9ACA970
        public void remove_OnClose(){} // RVA: 0x9ACAA70
        public void add_OnError(){} // RVA: 0x9ACAB70
        public void remove_OnError(){} // RVA: 0x9ACAC70
        public void add_OnMessage(){} // RVA: 0x9ACAD70
        public void remove_OnMessage(){} // RVA: 0x9ACAE70
        public void add_OnOpen(){} // RVA: 0x9ACAF70
        public void remove_OnOpen(){} // RVA: 0x9ACB060
        public void checkHandshakeResponse(){} // RVA: 0x9ACB150
        public void checkIfAvailable(){} // RVA: 0x9ACB930 | overloaded x2
        public void checkReceivedFrame(){} // RVA: 0x9ACBAF0
        public void close(){} // RVA: 0x9ACBDB0
        public void closeAsync(){} // RVA: 0x9ACC2E0
        public void closeHandshake(){} // RVA: 0x9ACC4E0
        public void connect(){} // RVA: 0x9ACC6B0
        public void createExtensions(){} // RVA: 0x9ACCAB0
        public void createHandshakeRequest(){} // RVA: 0x9ACCC80
        public void doHandshake(){} // RVA: 0x9ACD080
        public void enqueueToMessageEventQueue(){} // RVA: 0x9ACD420
        public void error(){} // RVA: 0x9ACD520
        public void fatal(){} // RVA: 0x9ACD7F0 | overloaded x2
        public void init(){} // RVA: 0x9ACD940
        public void message(){} // RVA: 0x9ACDBF0
        public void messagec(){} // RVA: 0x9ACDDD0
        public void open(){} // RVA: 0x9ACE0C0
        public void processCloseFrame(){} // RVA: 0x9ACE420
        public void processCookies(){} // RVA: 0x9ACE4D0
        public void processDataFrame(){} // RVA: 0x9ACE540
        public void processFragmentFrame(){} // RVA: 0x9ACE690
        public void processPingFrame(){} // RVA: 0x9ACEA60
        public void processPongFrame(){} // RVA: 0x9ACEBB0
        public void processReceivedFrame(){} // RVA: 0x9ACEC70
        public void processSecWebSocketExtensionsServerHeader(){} // RVA: 0x9ACF190
        public void processUnsupportedFrame(){} // RVA: 0x9ACF1F0
        public void releaseClientResources(){} // RVA: 0x9ACF2F0
        public void releaseCommonResources(){} // RVA: 0x9ACF450
        public void releaseResources(){} // RVA: 0x9ACF5F0
        public void releaseServerResources(){} // RVA: 0x9ACF8B0
        public void send(){} // RVA: 0x9AD02D0 | overloaded x4
        public void sendBytes(){} // RVA: 0x9AD05B0
        public void sendHandshakeRequest(){} // RVA: 0x9AD0670
        public void sendHttpRequest(){} // RVA: 0x9AD0E50
        public void sendProxyConnectRequest(){} // RVA: 0x9AD1090
        public void setClientStream(){} // RVA: 0x9AD1680
        public void startReceiving(){} // RVA: 0x9AD1E10
        public void validateSecWebSocketAcceptHeader(){} // RVA: 0x9AD2130
        public void validateSecWebSocketExtensionsServerHeader(){} // RVA: 0x9AD21E0
        public void validateSecWebSocketProtocolServerHeader(){} // RVA: 0x9AD2720
        public void validateSecWebSocketVersionServerHeader(){} // RVA: 0x9AD28C0
        public void CheckSendParameter(){} // RVA: 0x9AD2940
        public void CreateBase64Key(){} // RVA: 0x9AD2980
        public void CreateResponseKey(){} // RVA: 0x9AD2B10
        public void Close(){} // RVA: 0x9AD2E10
        public void CloseAsync(){} // RVA: 0x9AD2FD0
        public void Connect(){} // RVA: 0x9AD3190
        public void ConnectAsync(){} // RVA: 0x9AD3340
        public void Send(){} // RVA: 0x9AD3690
        public void SetCookie(){} // RVA: 0x9AD3890
        public void SetProxy(){} // RVA: 0x9AD3F10
        public void System.IDisposable.Dispose(){} // RVA: 0x9AD4A00
        public void <open>b__f(){} // RVA: 0x9AD4AB0
    }

    public class WebSocketException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9AE0A10 | overloaded x6
        public void get_Code(){} // RVA: 0x9AE0C50
    }

    public class WebSocketFrame
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x9AE2000
        public void .ctor(){} // RVA: 0x9AE2290 | overloaded x4
        public void get_ExtendedPayloadLengthCount(){} // RVA: 0x9AE27F0
        public void get_FullPayloadLength(){} // RVA: 0x9AE2810
        public void get_IsClose(){} // RVA: 0x9AE2920
        public void get_IsCompressed(){} // RVA: 0x9AE2930
        public void get_IsContinuation(){} // RVA: 0x9AE2940
        public void get_IsData(){} // RVA: 0x9AE2950
        public void get_IsFinal(){} // RVA: 0x9AE2970
        public void get_IsFragment(){} // RVA: 0x9AE2980
        public void get_IsMasked(){} // RVA: 0x9AE29A0
        public void get_IsPing(){} // RVA: 0x9AE29B0
        public void get_IsPong(){} // RVA: 0x9AE29C0
        public void get_IsText(){} // RVA: 0x9AE29D0
        public void get_Length(){} // RVA: 0x9AE29E0
        public void get_Opcode(){} // RVA: 0x73FB730
        public void get_PayloadData(){} // RVA: 0x7145E90
        public void get_Rsv2(){} // RVA: 0x9AE2A20
        public void get_Rsv3(){} // RVA: 0x9AE2A30
        public void createMaskingKey(){} // RVA: 0x9AE2A40
        public void dump(){} // RVA: 0x9AE2AE0
        public void print(){} // RVA: 0x9AE33E0
        public void processHeader(){} // RVA: 0x9AE3A20
        public void readExtendedPayloadLengthAsync(){} // RVA: 0x9AE3E70
        public void readHeaderAsync(){} // RVA: 0x9AE4100
        public void readMaskingKeyAsync(){} // RVA: 0x9AE4250
        public void readPayloadDataAsync(){} // RVA: 0x9AE44D0
        public void CreateCloseFrame(){} // RVA: 0x9AE4810
        public void CreatePingFrame(){} // RVA: 0x9AE4890
        public void ReadFrameAsync(){} // RVA: 0x9AE4950
        public void Unmask(){} // RVA: 0x9AE4C50
        public void GetEnumerator(){} // RVA: 0x9AE4DC0
        public void PrintToString(){} // RVA: 0x9AE4E60
        public void ToArray(){} // RVA: 0x9AE4EF0
        public void ToString(){} // RVA: 0x9AE5250
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x9AE4DC0
    }

}