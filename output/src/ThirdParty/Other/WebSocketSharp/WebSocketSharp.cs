// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.WebSocketSharp
// Classes: 14
// Methods: 236

namespace ThirdParty.Other.WebSocketSharp
{
    public class CloseEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA778840
        public void get_PayloadData(){} // RVA: 0xA778900
        public void get_Code(){} // RVA: 0xA778B90
        public void get_Reason(){} // RVA: 0x67D9AE0
        public void set_WasClean(){} // RVA: 0xC120B0
    }

    public class ErrorEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA778BA0
        public void get_Exception(){} // RVA: 0x3E42230
        public void get_Message(){} // RVA: 0x3926770
    }

    public class Ext : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0xA776670
        public void SubArray(){} // RVA: 0xA94080
        public void Emit(){} // RVA: 0xA94080
        public void Reverse(){} // RVA: 0x87C5C0
        public void compress(){} // RVA: 0xA772C00
        public void decompress(){} // RVA: 0xA773060
        public void decompressToArray(){} // RVA: 0xA7732F0
        public void Append(){} // RVA: 0xA773430
        public void CheckIfAvailable(){} // RVA: 0xA773590
        public void CheckIfValidProtocols(){} // RVA: 0xA773680
        public void CheckWaitTime(){} // RVA: 0xA773860
        public void Compress(){} // RVA: 0xA7739A0
        public void ContainsTwice(){} // RVA: 0xA773A10
        public void CopyTo(){} // RVA: 0xA773BF0
        public void Decompress(){} // RVA: 0xA773CC0
        public void DecompressToArray(){} // RVA: 0xA773D30
        public void EqualsWith(){} // RVA: 0xA773DC0
        public void GetAbsolutePath(){} // RVA: 0xA773E00
        public void GetMessage(){} // RVA: 0xA773F50
        public void GetValue(){} // RVA: 0xA774160
        public void InternalToByteArray(){} // RVA: 0xA774420
        public void IsCompressionExtension(){} // RVA: 0xA774520
        public void IsControl(){} // RVA: 0xA7745D0
        public void IsData(){} // RVA: 0xA7745E0
        public void IsReserved(){} // RVA: 0xA774600
        public void IsSupported(){} // RVA: 0xA774630
        public void IsText(){} // RVA: 0xA774760
        public void IsToken(){} // RVA: 0xA7749B0
        public void ReadBytes(){} // RVA: 0xA774CC0
        public void ReadBytesAsync(){} // RVA: 0xA775250
        public void SplitHeaderValue(){} // RVA: 0xA775610
        public void ToByteArray(){} // RVA: 0xA775740
        public void ToExtensionString(){} // RVA: 0xA775990
        public void ToUInt16(){} // RVA: 0xA775B60
        public void ToUInt64(){} // RVA: 0xA775C10
        public void TryCreateWebSocketUri(){} // RVA: 0xA775CC0
        public void Unquote(){} // RVA: 0xA776260
        public void UTF8Decode(){} // RVA: 0xA776350
        public void UTF8Encode(){} // RVA: 0xA7763A0
        public void WriteBytes(){} // RVA: 0xA7763E0
        public void GetCookies(){} // RVA: 0xA776880
        public void IsEnclosedIn(){} // RVA: 0xA7769D0
        public void IsHostOrder(){} // RVA: 0x7BF2620
        public void IsNullOrEmpty(){} // RVA: 0xA776A20
        public void IsPredefinedScheme(){} // RVA: 0xA776A40
        public void MaybeUri(){} // RVA: 0xA776D90
        public void Times(){} // RVA: 0xA776E30
        public void ToHostOrder(){} // RVA: 0xA776E80
        public void ToString(){} // RVA: 0x30C9B70
        public void ToUri(){} // RVA: 0xA777020
        public void UrlDecode(){} // RVA: 0xA777140
        public void <CheckIfValidProtocols>b__0(){} // RVA: 0xA777200
        public void .cctor(){} // RVA: 0xA777270
    }

    public class HttpBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67462E0
        public void get_EntityBody(){} // RVA: 0xA798130
        public void get_Headers(){} // RVA: 0x3E42230
        public void get_ProtocolVersion(){} // RVA: 0x3926770
        public void readEntityBody(){} // RVA: 0xA798250
        public void readHeaders(){} // RVA: 0xA798470
        public void Read(){} // RVA: 0x30E3D00
        public void ToByteArray(){} // RVA: 0xA7988A0
    }

    public class HttpRequest : HttpBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA798AF0
        public void CreateConnectRequest(){} // RVA: 0xA798CC0
        public void CreateWebSocketRequest(){} // RVA: 0xA798E40
        public void GetResponse(){} // RVA: 0xA7990A0
        public void SetCookies(){} // RVA: 0xA7991D0
        public void ToString(){} // RVA: 0xA799680
    }

    public class HttpResponse : HttpBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA798A00
        public void get_Cookies(){} // RVA: 0xA799A50
        public void get_HasConnectionClose(){} // RVA: 0xA799BA0
        public void get_IsProxyAuthenticationRequired(){} // RVA: 0xA799C30
        public void get_IsRedirect(){} // RVA: 0xA799CB0
        public void get_IsUnauthorized(){} // RVA: 0xA799D80
        public void get_IsWebSocketResponse(){} // RVA: 0xA799E00
        public void get_StatusCode(){} // RVA: 0x7C246A0
        public void Parse(){} // RVA: 0xA79A030
        public void ToString(){} // RVA: 0xA79A460
    }

    public class LogData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA790290
        public void get_Level(){} // RVA: 0x4EDA0B0
        public void get_Message(){} // RVA: 0x7C246A0
        public void ToString(){} // RVA: 0xA7903C0
    }

    public class Logger : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA790B30
        public void set_Output(){} // RVA: 0xA790CF0
        public void defaultOutput(){} // RVA: 0xA790E90
        public void output(){} // RVA: 0xA790F30
        public void writeToFile(){} // RVA: 0xA7911E0
        public void Debug(){} // RVA: 0xA7913C0
        public void Error(){} // RVA: 0xA7913F0
        public void Fatal(){} // RVA: 0xA791420
        public void Info(){} // RVA: 0xA791430
        public void Trace(){} // RVA: 0xA791460
        public void Warn(){} // RVA: 0xA791490
    }

    public class MessageEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7781B0
        public void get_Data(){} // RVA: 0xA778300
        public void get_IsPing(){} // RVA: 0xA7783F0
        public void get_RawData(){} // RVA: 0x7489A40
    }

    public class MessageEventArgs[] : Array
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

    public class PayloadData : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0xA78F1D0
        public void .ctor(){} // RVA: 0x7643620
        public void get_IncludesReservedCloseStatusCode(){} // RVA: 0xA78F470
        public void get_ApplicationData(){} // RVA: 0xA78F5D0
        public void get_Length(){} // RVA: 0x7489A40
        public void Mask(){} // RVA: 0xA78F720
        public void GetEnumerator(){} // RVA: 0xA78F7C0
        public void ToArray(){} // RVA: 0x3E42230
        public void ToString(){} // RVA: 0xA78F860
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xA78F7C0
    }

    public class WebSocket : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0xA778CB0
        public void .ctor(){} // RVA: 0xA778E60
        public void get_HasMessage(){} // RVA: 0xA7796C0
        public void set_Compression(){} // RVA: 0xA7797C0
        public void get_IsSecure(){} // RVA: 0xA779A50
        public void get_Log(){} // RVA: 0xA779A60
        public void get_SslConfiguration(){} // RVA: 0xA779A70
        public void set_WaitTime(){} // RVA: 0xA779C10
        public void add_OnClose(){} // RVA: 0xA779FB0
        public void remove_OnClose(){} // RVA: 0xA77A0D0
        public void add_OnError(){} // RVA: 0xA77A1F0
        public void remove_OnError(){} // RVA: 0xA77A310
        public void add_OnMessage(){} // RVA: 0xA77A430
        public void remove_OnMessage(){} // RVA: 0xA77A550
        public void add_OnOpen(){} // RVA: 0xA77A670
        public void remove_OnOpen(){} // RVA: 0xA77A770
        public void checkHandshakeResponse(){} // RVA: 0xA77A870
        public void checkIfAvailable(){} // RVA: 0xA77B040
        public void checkReceivedFrame(){} // RVA: 0xA77B200
        public void close(){} // RVA: 0xA77B4B0
        public void closeAsync(){} // RVA: 0xA77B9E0
        public void closeHandshake(){} // RVA: 0xA77BBC0
        public void connect(){} // RVA: 0xA77BD80
        public void createExtensions(){} // RVA: 0xA77C180
        public void createHandshakeRequest(){} // RVA: 0xA77C360
        public void doHandshake(){} // RVA: 0xA77C760
        public void enqueueToMessageEventQueue(){} // RVA: 0xA77CB00
        public void error(){} // RVA: 0xA77CC00
        public void fatal(){} // RVA: 0xA77CED0
        public void init(){} // RVA: 0xA77D020
        public void message(){} // RVA: 0xA77D2D0
        public void messagec(){} // RVA: 0xA77D4B0
        public void open(){} // RVA: 0xA77D7A0
        public void processCloseFrame(){} // RVA: 0xA77DB10
        public void processCookies(){} // RVA: 0xA77DBC0
        public void processDataFrame(){} // RVA: 0xA77DC30
        public void processFragmentFrame(){} // RVA: 0xA77DD80
        public void processPingFrame(){} // RVA: 0xA77E140
        public void processPongFrame(){} // RVA: 0xA77E290
        public void processReceivedFrame(){} // RVA: 0xA77E350
        public void processSecWebSocketExtensionsServerHeader(){} // RVA: 0xA77E870
        public void processUnsupportedFrame(){} // RVA: 0xA77E8D0
        public void releaseClientResources(){} // RVA: 0xA77E9D0
        public void releaseCommonResources(){} // RVA: 0xA77EB30
        public void releaseResources(){} // RVA: 0xA77ECD0
        public void releaseServerResources(){} // RVA: 0xA77EF90
        public void send(){} // RVA: 0xA77F990
        public void sendBytes(){} // RVA: 0xA77FC70
        public void sendHandshakeRequest(){} // RVA: 0xA77FD30
        public void sendHttpRequest(){} // RVA: 0xA7804E0
        public void sendProxyConnectRequest(){} // RVA: 0xA780720
        public void setClientStream(){} // RVA: 0xA780D00
        public void startReceiving(){} // RVA: 0xA781490
        public void validateSecWebSocketAcceptHeader(){} // RVA: 0xA7817B0
        public void validateSecWebSocketExtensionsServerHeader(){} // RVA: 0xA781860
        public void validateSecWebSocketProtocolServerHeader(){} // RVA: 0xA781D70
        public void validateSecWebSocketVersionServerHeader(){} // RVA: 0xA781F10
        public void CheckSendParameter(){} // RVA: 0xA781F90
        public void CreateBase64Key(){} // RVA: 0xA781FD0
        public void CreateResponseKey(){} // RVA: 0xA782160
        public void Close(){} // RVA: 0xA782460
        public void CloseAsync(){} // RVA: 0xA782630
        public void Connect(){} // RVA: 0xA7829B0
        public void ConnectAsync(){} // RVA: 0xA782B80
        public void Send(){} // RVA: 0xA782EA0
        public void SetCookie(){} // RVA: 0xA7830A0
        public void SetProxy(){} // RVA: 0xA783740
        public void System.IDisposable.Dispose(){} // RVA: 0xA784220
        public void <open>b__f(){} // RVA: 0xA7842D0
    }

    public class WebSocketException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA790050
        public void get_Code(){} // RVA: 0xA790280
    }

    public class WebSocketFrame : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0xA791700
        public void .ctor(){} // RVA: 0xA7919A0
        public void get_ExtendedPayloadLengthCount(){} // RVA: 0xA791F00
        public void get_FullPayloadLength(){} // RVA: 0xA791F20
        public void get_IsClose(){} // RVA: 0xA792030
        public void get_IsCompressed(){} // RVA: 0xA792040
        public void get_IsContinuation(){} // RVA: 0xA792050
        public void get_IsData(){} // RVA: 0xA792060
        public void get_IsFinal(){} // RVA: 0xA792080
        public void get_IsFragment(){} // RVA: 0xA792090
        public void get_IsMasked(){} // RVA: 0xA7920B0
        public void get_IsPing(){} // RVA: 0xA7920C0
        public void get_IsPong(){} // RVA: 0xA7920D0
        public void get_IsText(){} // RVA: 0xA7920E0
        public void get_Length(){} // RVA: 0xA7920F0
        public void get_Opcode(){} // RVA: 0x806C1E0
        public void get_PayloadData(){} // RVA: 0x7C24F60
        public void get_Rsv2(){} // RVA: 0xA792130
        public void get_Rsv3(){} // RVA: 0xA792140
        public void createMaskingKey(){} // RVA: 0xA792150
        public void dump(){} // RVA: 0xA7921F0
        public void print(){} // RVA: 0xA792AC0
        public void processHeader(){} // RVA: 0xA7930D0
        public void readExtendedPayloadLengthAsync(){} // RVA: 0xA7934C0
        public void readHeaderAsync(){} // RVA: 0xA793750
        public void readMaskingKeyAsync(){} // RVA: 0xA7938A0
        public void readPayloadDataAsync(){} // RVA: 0xA793B20
        public void CreateCloseFrame(){} // RVA: 0xA793E60
        public void CreatePingFrame(){} // RVA: 0xA793EE0
        public void ReadFrameAsync(){} // RVA: 0xA793FA0
        public void Unmask(){} // RVA: 0xA7942A0
        public void GetEnumerator(){} // RVA: 0xA794410
        public void PrintToString(){} // RVA: 0xA7944B0
        public void ToArray(){} // RVA: 0xA794540
        public void ToString(){} // RVA: 0xA7948A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xA794410
    }

}