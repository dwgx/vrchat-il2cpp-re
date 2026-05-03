// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.PlatformSupport.TcpClient.General
// Classes: 1
// Methods: 44

namespace ThirdParty.BestHTTP.BestHTTP.PlatformSupport.TcpClient.General
{
    public class TcpClient : Object
    {
        public System.Net.Sockets.NetworkStream stream; // 0x10
        public bool active; // 0x18
        public System.Net.Sockets.Socket client; // 0x20
        public bool disposed; // 0x28
        public 0x664A191C values; // 0x2C
        public int recv_timeout; // 0x30
        public int send_timeout; // 0x34
        public int recv_buffer_size; // 0x38
        public int send_buffer_size; // 0x3C
        public System.Net.Sockets.LingerOption linger_state; // 0x40
        public bool no_delay; // 0x48
        public System.TimeSpan _connectTimeout; // 0x50

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A25DDD0
        public void .ctor(){} // RVA: 0x7FFE8A25E1D0 | overloaded x4
        public void get_Active(){} // RVA: 0x7FFE811164E0
        public void set_Active(){} // RVA: 0x7FFE811164F0
        public void get_Client(){} // RVA: 0x7FFE811290C0
        public void set_Client(){} // RVA: 0x7FFE8A25E290
        public void get_Available(){} // RVA: 0x7FFE8A25E340
        public void get_Connected(){} // RVA: 0x7FFE8A25E360
        public void IsConnected(){} // RVA: 0x7FFE8A25E380
        public void get_ExclusiveAddressUse(){} // RVA: 0x7FFE8A25E3E0
        public void set_ExclusiveAddressUse(){} // RVA: 0x7FFE8A25E460
        public void SetTcpClient(){} // RVA: 0x7FFE8A25E290
        public void get_LingerState(){} // RVA: 0x7FFE8A25E480
        public void set_LingerState(){} // RVA: 0x7FFE8A25E530
        public void get_NoDelay(){} // RVA: 0x7FFE8A25E5D0
        public void set_NoDelay(){} // RVA: 0x7FFE8A25E660
        public void get_ReceiveBufferSize(){} // RVA: 0x7FFE8A25E6B0
        public void set_ReceiveBufferSize(){} // RVA: 0x7FFE8A25E740
        public void get_ReceiveTimeout(){} // RVA: 0x7FFE8A25E790
        public void set_ReceiveTimeout(){} // RVA: 0x7FFE8A25E820
        public void get_SendBufferSize(){} // RVA: 0x7FFE8A25E870
        public void set_SendBufferSize(){} // RVA: 0x7FFE8A25E900
        public void get_SendTimeout(){} // RVA: 0x7FFE8A25E950
        public void set_SendTimeout(){} // RVA: 0x7FFE8A25E9E0
        public void get_ConnectTimeout(){} // RVA: 0x7FFE8119C0E0
        public void set_ConnectTimeout(){} // RVA: 0x7FFE82506C00
        public void Close(){} // RVA: 0x7FFE8A25EA30
        public void Connect(){} // RVA: 0x7FFE8A25F390 | overloaded x4
        public void SetOptions(){} // RVA: 0x7FFE8A25EE10
        public void EndConnect(){} // RVA: 0x7FFE8A25F750
        public void BeginConnect(){} // RVA: 0x7FFE8A25F7D0 | overloaded x3
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE8A25F800
        public void Dispose(){} // RVA: 0x7FFE8A25F870
        public void Finalize(){} // RVA: 0x7FFE865ED780
        public void GetStream(){} // RVA: 0x7FFE8A25F940
        public void CheckDisposed(){} // RVA: 0x7FFE8A25FA70
    }

}