// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.PlatformSupport.TcpClient.General
// Classes: 1
// Methods: 44

namespace ThirdParty.BestHTTP.BestHTTP.PlatformSupport.TcpClient.General
{
    public class TcpClient : Object
    {
        public System.Net.Sockets.NetworkStream Active; // 0x10
        public bool Client; // 0x18
        public System.Net.Sockets.Socket Available; // 0x20
        public bool Connected; // 0x28
        public 0x6B0A9188 ExclusiveAddressUse; // 0x2C
        public int LingerState; // 0x30
        public int NoDelay; // 0x34
        public int ReceiveBufferSize; // 0x38
        public int ReceiveTimeout; // 0x3C
        public System.Net.Sockets.LingerOption SendBufferSize; // 0x40
        public bool SendTimeout; // 0x48
        public System.TimeSpan ConnectTimeout; // 0x50

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBE047B0
        public void .ctor(){} // RVA: 0x7FFACBE04BB0 | overloaded x4
        public void get_Active(){} // RVA: 0x7FFAC2F3C4E0
        public void set_Active(){} // RVA: 0x7FFAC2F3C4F0
        public void get_Client(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Client(){} // RVA: 0x7FFACBE04C70
        public void get_Available(){} // RVA: 0x7FFACBE04D20
        public void get_Connected(){} // RVA: 0x7FFACBE04D40
        public void IsConnected(){} // RVA: 0x7FFACBE04D60
        public void get_ExclusiveAddressUse(){} // RVA: 0x7FFACBE04DC0
        public void set_ExclusiveAddressUse(){} // RVA: 0x7FFACBE04E40
        public void SetTcpClient(){} // RVA: 0x7FFACBE04C70
        public void get_LingerState(){} // RVA: 0x7FFACBE04E60
        public void set_LingerState(){} // RVA: 0x7FFACBE04F10
        public void get_NoDelay(){} // RVA: 0x7FFACBE04FB0
        public void set_NoDelay(){} // RVA: 0x7FFACBE05040
        public void get_ReceiveBufferSize(){} // RVA: 0x7FFACBE05090
        public void set_ReceiveBufferSize(){} // RVA: 0x7FFACBE05120
        public void get_ReceiveTimeout(){} // RVA: 0x7FFACBE05170
        public void set_ReceiveTimeout(){} // RVA: 0x7FFACBE05200
        public void get_SendBufferSize(){} // RVA: 0x7FFACBE05250
        public void set_SendBufferSize(){} // RVA: 0x7FFACBE052E0
        public void get_SendTimeout(){} // RVA: 0x7FFACBE05330
        public void set_SendTimeout(){} // RVA: 0x7FFACBE053C0
        public void get_ConnectTimeout(){} // RVA: 0x7FFAC2FC20E0
        public void set_ConnectTimeout(){} // RVA: 0x7FFAC42499F0
        public void Close(){} // RVA: 0x7FFACBE05410
        public void Connect(){} // RVA: 0x7FFACBE05D70 | overloaded x4
        public void SetOptions(){} // RVA: 0x7FFACBE057F0
        public void EndConnect(){} // RVA: 0x7FFACBE06130
        public void BeginConnect(){} // RVA: 0x7FFACBE061B0 | overloaded x3
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFACBE061E0
        public void Dispose(){} // RVA: 0x7FFACBE06250
        public void Finalize(){} // RVA: 0x7FFAC8243E40
        public void GetStream(){} // RVA: 0x7FFACBE06320
        public void CheckDisposed(){} // RVA: 0x7FFACBE06450
    }

}