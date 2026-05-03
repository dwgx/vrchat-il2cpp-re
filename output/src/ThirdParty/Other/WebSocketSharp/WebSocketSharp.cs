// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.WebSocketSharp
// Classes: 13
// Methods: 235

namespace ThirdParty.Other.WebSocketSharp
{
    public class CloseEventArgs : EventArgs
    {
        public bool _clean; // 0x10
        public ushort _code; // 0x12

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A50AEC0 | overloaded x6
        public void get_PayloadData(){} // RVA: 0x7FFE8A50AF80
        public void set_WasClean(){} // RVA: 0x7FFE811C55F0
    }

    public class ErrorEventArgs : EventArgs
    {
        public System.Exception _exception; // 0x10
        public string _message; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A50B210
        public void get_Exception(){} // RVA: 0x7FFE84022BE0
        public void get_Message(){} // RVA: 0x7FFE83BBC680
    }

    public class Ext : Object
    {
        // ── Methods ──
        public void decompress(){} // RVA: 0x7FFE8A505700 | overloaded x2
        public void decompressToArray(){} // RVA: 0x7FFE8A5059A0
        public void Append(){} // RVA: 0x7FFE8A505AE0
        public void CheckIfValidProtocols(){} // RVA: 0x7FFE8A505C40
        public void CheckWaitTime(){} // RVA: 0x7FFE8A505E20
        public void Contains(){} // RVA: 0x7FFE8A508D20 | overloaded x4
        public void ContainsTwice(){} // RVA: 0x7FFE8A505F60
        public void CopyTo(){} // RVA: 0x7FFE8A506140
        public void Decompress(){} // RVA: 0x7FFE8A506210
        public void DecompressToArray(){} // RVA: 0x7FFE8A506280
        public void EqualsWith(){} // RVA: 0x7FFE8A506310
        public void GetAbsolutePath(){} // RVA: 0x7FFE8A506350
        public void GetMessage(){} // RVA: 0x7FFE8A506490
        public void GetValue(){} // RVA: 0x7FFE8A5066B0 | overloaded x2
        public void InternalToByteArray(){} // RVA: 0x7FFE8A506980 | overloaded x2
        public void IsCompressionExtension(){} // RVA: 0x7FFE8A506A80
        public void IsControl(){} // RVA: 0x7FFE8A506B30
        public void IsData(){} // RVA: 0x7FFE8A506B40 | overloaded x2
        public void IsReserved(){} // RVA: 0x7FFE8A506B60 | overloaded x2
        public void IsSupported(){} // RVA: 0x7FFE8A506B90
        public void IsText(){} // RVA: 0x7FFE8A506D40
        public void IsToken(){} // RVA: 0x7FFE8A506FA0
        public void ReadBytes(){} // RVA: 0x7FFE8A5072B0 | overloaded x2
        public void ReadBytesAsync(){} // RVA: 0x7FFE8A507840 | overloaded x2
        public void Reverse(){} // RVA: 0x7FFE80E2E3D0
        public void SplitHeaderValue(){} // RVA: 0x7FFE8A507C00
        public void ToByteArray(){} // RVA: 0x7FFE8A507D30
        public void ToExtensionString(){} // RVA: 0x7FFE8A507F90
        public void ToUInt16(){} // RVA: 0x7FFE8A508170
        public void ToUInt64(){} // RVA: 0x7FFE8A508220
        public void TryCreateWebSocketUri(){} // RVA: 0x7FFE8A5082D0
        public void Unquote(){} // RVA: 0x7FFE8A508900
        public void UTF8Decode(){} // RVA: 0x7FFE8A508A00
        public void UTF8Encode(){} // RVA: 0x7FFE8A508A40
        public void WriteBytes(){} // RVA: 0x7FFE8A508A80
        public void Emit(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetCookies(){} // RVA: 0x7FFE8A508F20
        public void IsEnclosedIn(){} // RVA: 0x7FFE8A509070
        public void IsHostOrder(){} // RVA: 0x7FFE87C606C0
        public void IsNullOrEmpty(){} // RVA: 0x7FFE8A5090C0
        public void IsPredefinedScheme(){} // RVA: 0x7FFE8A5090E0
        public void MaybeUri(){} // RVA: 0x7FFE8A509430
        public void SubArray(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Times(){} // RVA: 0x7FFE8A5094D0
        public void ToHostOrder(){} // RVA: 0x7FFE8A509520
        public void ToString(){} // RVA: 0x7FFE80E2E440
        public void ToUri(){} // RVA: 0x7FFE8A5096B0
        public void UrlDecode(){} // RVA: 0x7FFE8A5097D0
        public void <CheckIfValidProtocols>b__0(){} // RVA: 0x7FFE8A509890
        public void .cctor(){} // RVA: 0x7FFE8A509900
    }

    public class HttpBase : Object
    {
        public System.Collections.Specialized.NameValueCollection _headers; // 0x10
        public System.Version _version; // 0x18
        public byte[] EntityBodyData; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8680DC00
        public void get_EntityBody(){} // RVA: 0x7FFE8A528240
        public void get_Headers(){} // RVA: 0x7FFE84022BE0
        public void get_ProtocolVersion(){} // RVA: 0x7FFE83BBC680
        public void readEntityBody(){} // RVA: 0x7FFE8A528370
        public void readHeaders(){} // RVA: 0x7FFE8A528590
        public void Read(){} // RVA: 0x7FFE810A1420
        public void ToByteArray(){} // RVA: 0x7FFE8A5289C0
    }

    public class HttpRequest : HttpBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A528C10 | overloaded x2
        public void CreateConnectRequest(){} // RVA: 0x7FFE8A528DC0
        public void CreateWebSocketRequest(){} // RVA: 0x7FFE8A528F50
        public void GetResponse(){} // RVA: 0x7FFE8A5291C0
        public void SetCookies(){} // RVA: 0x7FFE8A5292F0
        public void ToString(){} // RVA: 0x7FFE8A5297B0
    }

    public class HttpResponse : HttpBase
    {
        public string _code; // 0x28
        public string _reason; // 0x30
        public object field_2; // 0x47
        public object field_3; // 0x48
        public object field_4; // 0x49
        public object field_5; // 0x4A
        public object field_6; // 0x4B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A528B20
        public void get_Cookies(){} // RVA: 0x7FFE8A529B70
        public void get_HasConnectionClose(){} // RVA: 0x7FFE8A529CC0
        public void get_IsProxyAuthenticationRequired(){} // RVA: 0x7FFE8A529D50
        public void get_IsRedirect(){} // RVA: 0x7FFE8A529DD0
        public void get_IsUnauthorized(){} // RVA: 0x7FFE8A529EA0
        public void get_IsWebSocketResponse(){} // RVA: 0x7FFE8A529F20
        public void get_StatusCode(){} // RVA: 0x7FFE87C86200
        public void Parse(){} // RVA: 0x7FFE8A52A150
        public void ToString(){} // RVA: 0x7FFE8A52A570
    }

    public class LogData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A5207C0
        public void ToString(){} // RVA: 0x7FFE8A520900
    }

    public class Logger : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A520EF0 | overloaded x2
        public void defaultOutput(){} // RVA: 0x7FFE8A5210B0
        public void output(){} // RVA: 0x7FFE8A521150
        public void writeToFile(){} // RVA: 0x7FFE8A521400
        public void Debug(){} // RVA: 0x7FFE8A521600
        public void Error(){} // RVA: 0x7FFE8A521630
        public void Fatal(){} // RVA: 0x7FFE8A521660
        public void Info(){} // RVA: 0x7FFE8A521670
        public void Trace(){} // RVA: 0x7FFE8A5216A0
        public void Warn(){} // RVA: 0x7FFE8A5216D0
    }

    public class MessageEventArgs : EventArgs
    {
        public string _data; // 0x10
        public bool _dataSet; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A50A820 | overloaded x2
        public void get_Data(){} // RVA: 0x7FFE8A50A970
        public void get_IsPing(){} // RVA: 0x7FFE8A50AA60
    }

    public class PayloadData : Object
    {
        public byte[] _data; // 0x10
        public long _extDataLength; // 0x18
        public long _length; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A51F690
        public void .ctor(){} // RVA: 0x7FFE87723400 | overloaded x3
        public void get_IncludesReservedCloseStatusCode(){} // RVA: 0x7FFE8A51F930
        public void get_ApplicationData(){} // RVA: 0x7FFE8A51FA90
        public void get_Length(){} // RVA: 0x7FFE87563690
        public void Mask(){} // RVA: 0x7FFE8A51FBE0
        public void GetEnumerator(){} // RVA: 0x7FFE8A51FC80
        public void ToArray(){} // RVA: 0x7FFE84022BE0
        public void ToString(){} // RVA: 0x7FFE8A51FD20
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8A51FC80
    }

    public class WebSocket : Object
    {
        public WebSocketSharp.Net.AuthenticationChallenge _authChallenge; // 0x10
        public string _base64Key; // 0x18
        public bool _client; // 0x20
        public System.Action _closeContext; // 0x28

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A50B320
        public void .ctor(){} // RVA: 0x7FFE8A50B4E0
        public void get_HasMessage(){} // RVA: 0x7FFE8A50BA30
        public void set_Compression(){} // RVA: 0x7FFE8A50BB30
        public void get_SslConfiguration(){} // RVA: 0x7FFE8A50BDD0
        public void set_WaitTime(){} // RVA: 0x7FFE8A50BF70
        public void add_OnClose(){} // RVA: 0x7FFE8A50C300
        public void remove_OnClose(){} // RVA: 0x7FFE8A50C400
        public void add_OnError(){} // RVA: 0x7FFE8A50C500
        public void remove_OnError(){} // RVA: 0x7FFE8A50C600
        public void add_OnMessage(){} // RVA: 0x7FFE8A50C700
        public void remove_OnMessage(){} // RVA: 0x7FFE8A50C800
        public void add_OnOpen(){} // RVA: 0x7FFE8A50C900
        public void remove_OnOpen(){} // RVA: 0x7FFE8A50C9F0
        public void checkHandshakeResponse(){} // RVA: 0x7FFE8A50CAE0
        public void checkIfAvailable(){} // RVA: 0x7FFE8A50D2C0 | overloaded x2
        public void checkReceivedFrame(){} // RVA: 0x7FFE8A50D480
        public void close(){} // RVA: 0x7FFE8A50D740
        public void closeHandshake(){} // RVA: 0x7FFE8A50DC70
        public void connect(){} // RVA: 0x7FFE8A50DE40
        public void createExtensions(){} // RVA: 0x7FFE8A50E240
        public void createHandshakeRequest(){} // RVA: 0x7FFE8A50E410
        public void doHandshake(){} // RVA: 0x7FFE8A50E810
        public void enqueueToMessageEventQueue(){} // RVA: 0x7FFE8A50EBB0
        public void error(){} // RVA: 0x7FFE8A50ECB0
        public void fatal(){} // RVA: 0x7FFE8A50EF80 | overloaded x2
        public void init(){} // RVA: 0x7FFE8A50F0D0
        public void message(){} // RVA: 0x7FFE8A50F380
        public void messagec(){} // RVA: 0x7FFE8A50F560
        public void open(){} // RVA: 0x7FFE8A50F850
        public void processCloseFrame(){} // RVA: 0x7FFE8A50FBB0
        public void processCookies(){} // RVA: 0x7FFE8A50FC60
        public void processDataFrame(){} // RVA: 0x7FFE8A50FCD0
        public void processFragmentFrame(){} // RVA: 0x7FFE8A50FE20
        public void processPingFrame(){} // RVA: 0x7FFE8A5101F0
        public void processPongFrame(){} // RVA: 0x7FFE8A510340
        public void processReceivedFrame(){} // RVA: 0x7FFE8A510400
        public void processSecWebSocketExtensionsServerHeader(){} // RVA: 0x7FFE8A510920
        public void processUnsupportedFrame(){} // RVA: 0x7FFE8A510980
        public void releaseClientResources(){} // RVA: 0x7FFE8A510A80
        public void releaseCommonResources(){} // RVA: 0x7FFE8A510BE0
        public void releaseResources(){} // RVA: 0x7FFE8A510D80
        public void releaseServerResources(){} // RVA: 0x7FFE8A511040
        public void send(){} // RVA: 0x7FFE8A511170
        public void sendBytes(){} // RVA: 0x7FFE8A511300
        public void sendHandshakeRequest(){} // RVA: 0x7FFE8A5113C0
        public void sendHttpRequest(){} // RVA: 0x7FFE8A511BA0
        public void sendProxyConnectRequest(){} // RVA: 0x7FFE8A511DE0
        public void setClientStream(){} // RVA: 0x7FFE8A5123D0
        public void startReceiving(){} // RVA: 0x7FFE8A512B60
        public void validateSecWebSocketAcceptHeader(){} // RVA: 0x7FFE8A512E80
        public void validateSecWebSocketExtensionsServerHeader(){} // RVA: 0x7FFE8A512F30
        public void validateSecWebSocketProtocolServerHeader(){} // RVA: 0x7FFE8A513470
        public void validateSecWebSocketVersionServerHeader(){} // RVA: 0x7FFE8A513610
        public void CreateBase64Key(){} // RVA: 0x7FFE8A513690
        public void CreateResponseKey(){} // RVA: 0x7FFE8A513820
        public void Close(){} // RVA: 0x7FFE8A513B20
        public void Connect(){} // RVA: 0x7FFE8A513DD0
        public void SetCookie(){} // RVA: 0x7FFE8A513F80
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE8A514600
        public void <open>b__f(){} // RVA: 0x7FFE8A5146B0
    }

    public class WebSocketException : Exception
    {
        public 0x66698D1C _code; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A520570 | overloaded x6
        public void get_Code(){} // RVA: 0x7FFE8A5207B0
    }

    public class WebSocketFrame : Object
    {
        public byte[] _extPayloadLength; // 0x10
        public 0x66698D74 _fin; // 0x18
        public 0x66698DCC _mask; // 0x19
        public byte[] _maskingKey; // 0x20
        public 0x66698E24 _opcode; // 0x28
        public WebSocketSharp.PayloadData _payloadData; // 0x30
        public byte _payloadLength; // 0x38
        public 0x66698F2C _rsv1; // 0x39
        public 0x66698F2C _rsv2; // 0x3A
        public 0x66698F2C _rsv3; // 0x3B
        public byte[] EmptyPingBytes;
        public object field_11; // 0x2F
        public object field_12; // 0x30
        public object field_13; // 0x31
        public object field_14; // 0x32
        public object field_15; // 0x33
        public object field_16; // 0x34

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A5217A0
        public void .ctor(){} // RVA: 0x7FFE8A521920 | overloaded x3
        public void get_ExtendedPayloadLengthCount(){} // RVA: 0x7FFE8A521E80
        public void get_FullPayloadLength(){} // RVA: 0x7FFE8A521EA0
        public void get_IsClose(){} // RVA: 0x7FFE8A521FB0
        public void get_IsCompressed(){} // RVA: 0x7FFE8A521FC0
        public void get_IsContinuation(){} // RVA: 0x7FFE8A521FD0
        public void get_IsData(){} // RVA: 0x7FFE8A521FE0
        public void get_IsFinal(){} // RVA: 0x7FFE8A522000
        public void get_IsFragment(){} // RVA: 0x7FFE8A522010
        public void get_IsMasked(){} // RVA: 0x7FFE8A522030
        public void get_IsPing(){} // RVA: 0x7FFE8A522040
        public void get_IsPong(){} // RVA: 0x7FFE8A522050
        public void get_IsText(){} // RVA: 0x7FFE8A522060
        public void get_Length(){} // RVA: 0x7FFE8A522070
        public void get_Opcode(){} // RVA: 0x7FFE87F3B8D0
        public void get_PayloadData(){} // RVA: 0x7FFE87C86B00
        public void get_Rsv2(){} // RVA: 0x7FFE8A5220B0
        public void get_Rsv3(){} // RVA: 0x7FFE8A5220C0
        public void createMaskingKey(){} // RVA: 0x7FFE8A5220D0
        public void dump(){} // RVA: 0x7FFE8A522170
        public void print(){} // RVA: 0x7FFE8A522A70
        public void processHeader(){} // RVA: 0x7FFE8A5230B0
        public void readExtendedPayloadLengthAsync(){} // RVA: 0x7FFE8A523500
        public void readHeaderAsync(){} // RVA: 0x7FFE8A523790
        public void readMaskingKeyAsync(){} // RVA: 0x7FFE8A5238E0
        public void readPayloadDataAsync(){} // RVA: 0x7FFE8A523B60
        public void CreateCloseFrame(){} // RVA: 0x7FFE8A523EA0
        public void CreatePingFrame(){} // RVA: 0x7FFE8A523F20
        public void ReadFrameAsync(){} // RVA: 0x7FFE8A523FE0
        public void Unmask(){} // RVA: 0x7FFE8A5242E0
        public void GetEnumerator(){} // RVA: 0x7FFE8A524450
        public void PrintToString(){} // RVA: 0x7FFE8A5244F0
        public void ToArray(){} // RVA: 0x7FFE8A524580
        public void ToString(){} // RVA: 0x7FFE8A5248E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8A524450
    }

}