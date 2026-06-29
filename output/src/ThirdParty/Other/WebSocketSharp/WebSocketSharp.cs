// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.WebSocketSharp
// Classes: 14
// Methods: 236

namespace ThirdParty.Other.WebSocketSharp
{
    public class CloseEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B190AA50
        public void get_PayloadData(){} // RVA: 0x7B190AB10
        public void get_Code(){} // RVA: 0x7B190ADA0
        public void get_Reason(){} // RVA: 0x7B190ADB0
        public void set_WasClean(){} // RVA: 0x7A81A2210
    }

    public class ErrorEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B190AE00
        public void get_Exception(){} // RVA: 0x7AB1AC740
        public void get_Message(){} // RVA: 0x7AACE3A80
    }

    public class Ext : Object
    {
        // ── Methods ──
        public void compress(){} // RVA: 0x7B1904CC0
        public void decompress(){} // RVA: 0x7B1905120
        public void decompressToArray(){} // RVA: 0x7B19053B0
        public void Append(){} // RVA: 0x7B19054F0
        public void CheckIfAvailable(){} // RVA: 0x7B1905650
        public void CheckIfValidProtocols(){} // RVA: 0x7B1905740
        public void CheckWaitTime(){} // RVA: 0x7B1905920
        public void Compress(){} // RVA: 0x7B1905A60
        public void Contains(){} // RVA: 0x7AA49EA70
        public void ContainsTwice(){} // RVA: 0x7B1905AD0
        public void CopyTo(){} // RVA: 0x7B1905CB0
        public void Decompress(){} // RVA: 0x7B1905D80
        public void DecompressToArray(){} // RVA: 0x7B1905DF0
        public void EqualsWith(){} // RVA: 0x7B1905E80
        public void GetAbsolutePath(){} // RVA: 0x7B1905EC0
        public void GetMessage(){} // RVA: 0x7B1906010
        public void GetValue(){} // RVA: 0x7B1906230
        public void InternalToByteArray(){} // RVA: 0x7B1906500
        public void IsCompressionExtension(){} // RVA: 0x7B1906600
        public void IsControl(){} // RVA: 0x7B19066B0
        public void IsData(){} // RVA: 0x7B19066C0
        public void IsReserved(){} // RVA: 0x7B19066E0
        public void IsSupported(){} // RVA: 0x7B1906710
        public void IsText(){} // RVA: 0x7B19068C0
        public void IsToken(){} // RVA: 0x7B1906B10
        public void ReadBytes(){} // RVA: 0x7B1906E20
        public void ReadBytesAsync(){} // RVA: 0x7B19073B0
        public void Reverse(){} // RVA: 0x7AA49EF80
        public void SplitHeaderValue(){} // RVA: 0x7B1907770
        public void ToByteArray(){} // RVA: 0x7B19078A0
        public void ToExtensionString(){} // RVA: 0x7B1907AF0
        public void ToUInt16(){} // RVA: 0x7B1907CD0
        public void ToUInt64(){} // RVA: 0x7B1907D80
        public void TryCreateWebSocketUri(){} // RVA: 0x7B1907E30
        public void Unquote(){} // RVA: 0x7B1908450
        public void UTF8Decode(){} // RVA: 0x7B1908550
        public void UTF8Encode(){} // RVA: 0x7B19085A0
        public void WriteBytes(){} // RVA: 0x7B19085E0
        public void Emit(){} // RVA: 0x7AA49EF30
        public void GetCookies(){} // RVA: 0x7B1908A80
        public void IsEnclosedIn(){} // RVA: 0x7B1908BD0
        public void IsHostOrder(){} // RVA: 0x7AEEFE7F0
        public void IsNullOrEmpty(){} // RVA: 0x7B1908C20
        public void IsPredefinedScheme(){} // RVA: 0x7B1908C40
        public void MaybeUri(){} // RVA: 0x7B1908F90
        public void SubArray(){} // RVA: 0x7AA49F300
        public void Times(){} // RVA: 0x7B1909030
        public void ToHostOrder(){} // RVA: 0x7B1909080
        public void ToString(){} // RVA: 0x7AA49F3F0
        public void ToUri(){} // RVA: 0x7B1909220
        public void UrlDecode(){} // RVA: 0x7B1909340
        public void <CheckIfValidProtocols>b__0(){} // RVA: 0x7B1909400
        public void .cctor(){} // RVA: 0x7B1909470
    }

    public class HttpBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADABAF10
        public void get_EntityBody(){} // RVA: 0x7B192A770
        public void get_Headers(){} // RVA: 0x7AB1AC740
        public void get_ProtocolVersion(){} // RVA: 0x7AACE3A80
        public void readEntityBody(){} // RVA: 0x7B192A8A0
        public void readHeaders(){} // RVA: 0x7B192AAC0
        public void Read(){} // RVA: 0x7AA4B77E0
        public void ToByteArray(){} // RVA: 0x7B192AEF0
    }

    public class HttpRequest : HttpBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B192B140
        public void CreateConnectRequest(){} // RVA: 0x7B192B310
        public void CreateWebSocketRequest(){} // RVA: 0x7B192B4A0
        public void GetResponse(){} // RVA: 0x7B192B700
        public void SetCookies(){} // RVA: 0x7B192B830
        public void ToString(){} // RVA: 0x7B192BCE0
    }

    public class HttpResponse : HttpBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B192B050
        public void get_Cookies(){} // RVA: 0x7B192C0B0
        public void get_HasConnectionClose(){} // RVA: 0x7B192C200
        public void get_IsProxyAuthenticationRequired(){} // RVA: 0x7B192C290
        public void get_IsRedirect(){} // RVA: 0x7B192C310
        public void get_IsUnauthorized(){} // RVA: 0x7B192C3E0
        public void get_IsWebSocketResponse(){} // RVA: 0x7B192C460
        public void get_StatusCode(){} // RVA: 0x7AEF244A0
        public void Parse(){} // RVA: 0x7B192C690
        public void ToString(){} // RVA: 0x7B192CAC0
    }

    public class LogData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1922650
        public void get_Level(){} // RVA: 0x7AC1CB330
        public void get_Message(){} // RVA: 0x7AEF244A0
        public void ToString(){} // RVA: 0x7B1922790
    }

    public class Logger : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1922F10
        public void set_Output(){} // RVA: 0x7B19230D0
        public void defaultOutput(){} // RVA: 0x7B1923270
        public void output(){} // RVA: 0x7B1923310
        public void writeToFile(){} // RVA: 0x7B19235C0
        public void Debug(){} // RVA: 0x7B19237A0
        public void Error(){} // RVA: 0x7B19237D0
        public void Fatal(){} // RVA: 0x7B1923800
        public void Info(){} // RVA: 0x7B1923810
        public void Trace(){} // RVA: 0x7B1923840
        public void Warn(){} // RVA: 0x7B1923870
    }

    public class MessageEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B190A3B0
        public void get_Data(){} // RVA: 0x7B190A500
        public void get_IsPing(){} // RVA: 0x7B190A5F0
        public void get_RawData(){} // RVA: 0x7AE8145B0
    }

    public class MessageEventArgs[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class PayloadData : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B1921530
        public void .ctor(){} // RVA: 0x7AE9D14E0
        public void get_IncludesReservedCloseStatusCode(){} // RVA: 0x7B19217D0
        public void get_ApplicationData(){} // RVA: 0x7B1921930
        public void get_Length(){} // RVA: 0x7AE8145B0
        public void Mask(){} // RVA: 0x7B1921A80
        public void GetEnumerator(){} // RVA: 0x7B1921B20
        public void ToArray(){} // RVA: 0x7AB1AC740
        public void ToString(){} // RVA: 0x7B1921BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7B1921B20
    }

    public class WebSocket : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B190AF10
        public void .ctor(){} // RVA: 0x7B190B0D0
        public void get_HasMessage(){} // RVA: 0x7B190B930
        public void set_Compression(){} // RVA: 0x7B190BA30
        public void get_IsSecure(){} // RVA: 0x7B190BCC0
        public void get_Log(){} // RVA: 0x7B190BCD0
        public void get_SslConfiguration(){} // RVA: 0x7B190BCE0
        public void set_WaitTime(){} // RVA: 0x7B190BE80
        public void add_OnClose(){} // RVA: 0x7B190C220
        public void remove_OnClose(){} // RVA: 0x7B190C340
        public void add_OnError(){} // RVA: 0x7B190C460
        public void remove_OnError(){} // RVA: 0x7B190C580
        public void add_OnMessage(){} // RVA: 0x7B190C6A0
        public void remove_OnMessage(){} // RVA: 0x7B190C7C0
        public void add_OnOpen(){} // RVA: 0x7B190C8E0
        public void remove_OnOpen(){} // RVA: 0x7B190C9E0
        public void checkHandshakeResponse(){} // RVA: 0x7B190CAE0
        public void checkIfAvailable(){} // RVA: 0x7B190D2B0
        public void checkReceivedFrame(){} // RVA: 0x7B190D470
        public void close(){} // RVA: 0x7B190D720
        public void closeAsync(){} // RVA: 0x7B190DC50
        public void closeHandshake(){} // RVA: 0x7B190DE50
        public void connect(){} // RVA: 0x7B190E020
        public void createExtensions(){} // RVA: 0x7B190E420
        public void createHandshakeRequest(){} // RVA: 0x7B190E600
        public void doHandshake(){} // RVA: 0x7B190EA00
        public void enqueueToMessageEventQueue(){} // RVA: 0x7B190EDA0
        public void error(){} // RVA: 0x7B190EEA0
        public void fatal(){} // RVA: 0x7B190F170
        public void init(){} // RVA: 0x7B190F2C0
        public void message(){} // RVA: 0x7B190F570
        public void messagec(){} // RVA: 0x7B190F750
        public void open(){} // RVA: 0x7B190FA40
        public void processCloseFrame(){} // RVA: 0x7B190FDB0
        public void processCookies(){} // RVA: 0x7B190FE60
        public void processDataFrame(){} // RVA: 0x7B190FED0
        public void processFragmentFrame(){} // RVA: 0x7B1910020
        public void processPingFrame(){} // RVA: 0x7B19103E0
        public void processPongFrame(){} // RVA: 0x7B1910530
        public void processReceivedFrame(){} // RVA: 0x7B19105F0
        public void processSecWebSocketExtensionsServerHeader(){} // RVA: 0x7B1910B10
        public void processUnsupportedFrame(){} // RVA: 0x7B1910B70
        public void releaseClientResources(){} // RVA: 0x7B1910C70
        public void releaseCommonResources(){} // RVA: 0x7B1910DD0
        public void releaseResources(){} // RVA: 0x7B1910F70
        public void releaseServerResources(){} // RVA: 0x7B1911230
        public void send(){} // RVA: 0x7B1911C30
        public void sendBytes(){} // RVA: 0x7B1911F10
        public void sendHandshakeRequest(){} // RVA: 0x7B1911FD0
        public void sendHttpRequest(){} // RVA: 0x7B19127A0
        public void sendProxyConnectRequest(){} // RVA: 0x7B19129E0
        public void setClientStream(){} // RVA: 0x7B1912FD0
        public void startReceiving(){} // RVA: 0x7B1913760
        public void validateSecWebSocketAcceptHeader(){} // RVA: 0x7B1913A80
        public void validateSecWebSocketExtensionsServerHeader(){} // RVA: 0x7B1913B30
        public void validateSecWebSocketProtocolServerHeader(){} // RVA: 0x7B1914040
        public void validateSecWebSocketVersionServerHeader(){} // RVA: 0x7B19141E0
        public void CheckSendParameter(){} // RVA: 0x7B1914260
        public void CreateBase64Key(){} // RVA: 0x7B19142A0
        public void CreateResponseKey(){} // RVA: 0x7B1914430
        public void Close(){} // RVA: 0x7B1914730
        public void CloseAsync(){} // RVA: 0x7B1914900
        public void Connect(){} // RVA: 0x7B1914AD0
        public void ConnectAsync(){} // RVA: 0x7B1914CA0
        public void Send(){} // RVA: 0x7B1914FC0
        public void SetCookie(){} // RVA: 0x7B19151C0
        public void SetProxy(){} // RVA: 0x7B1915860
        public void System.IDisposable.Dispose(){} // RVA: 0x7B1916350
        public void <open>b__f(){} // RVA: 0x7B1916400
    }

    public class WebSocketException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1922400
        public void get_Code(){} // RVA: 0x7B1922640
    }

    public class WebSocketFrame : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B1923B60
        public void .ctor(){} // RVA: 0x7B1923E00
        public void get_ExtendedPayloadLengthCount(){} // RVA: 0x7B1924360
        public void get_FullPayloadLength(){} // RVA: 0x7B1924380
        public void get_IsClose(){} // RVA: 0x7B1924490
        public void get_IsCompressed(){} // RVA: 0x7B19244A0
        public void get_IsContinuation(){} // RVA: 0x7B19244B0
        public void get_IsData(){} // RVA: 0x7B19244C0
        public void get_IsFinal(){} // RVA: 0x7B19244E0
        public void get_IsFragment(){} // RVA: 0x7B19244F0
        public void get_IsMasked(){} // RVA: 0x7B1924510
        public void get_IsPing(){} // RVA: 0x7B1924520
        public void get_IsPong(){} // RVA: 0x7B1924530
        public void get_IsText(){} // RVA: 0x7B1924540
        public void get_Length(){} // RVA: 0x7B1924550
        public void get_Opcode(){} // RVA: 0x7AF1DA8D0
        public void get_PayloadData(){} // RVA: 0x7AEF24D90
        public void get_Rsv2(){} // RVA: 0x7B1924590
        public void get_Rsv3(){} // RVA: 0x7B19245A0
        public void createMaskingKey(){} // RVA: 0x7B19245B0
        public void dump(){} // RVA: 0x7B1924650
        public void print(){} // RVA: 0x7B1924F40
        public void processHeader(){} // RVA: 0x7B1925580
        public void readExtendedPayloadLengthAsync(){} // RVA: 0x7B19259F0
        public void readHeaderAsync(){} // RVA: 0x7B1925C80
        public void readMaskingKeyAsync(){} // RVA: 0x7B1925DD0
        public void readPayloadDataAsync(){} // RVA: 0x7B1926050
        public void CreateCloseFrame(){} // RVA: 0x7B1926390
        public void CreatePingFrame(){} // RVA: 0x7B1926410
        public void ReadFrameAsync(){} // RVA: 0x7B19264D0
        public void Unmask(){} // RVA: 0x7B19267D0
        public void GetEnumerator(){} // RVA: 0x7B1926940
        public void PrintToString(){} // RVA: 0x7B19269E0
        public void ToArray(){} // RVA: 0x7B1926A70
        public void ToString(){} // RVA: 0x7B1926DD0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7B1926940
    }

}