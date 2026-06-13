// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.PlatformSupport.TcpClient.General
// Classes: 1
// Methods: 44

namespace ThirdParty.BestHTTP.BestHTTP.PlatformSupport.TcpClient.General
{
    public class TcpClient
    {
        public System.Net.Sockets.NetworkStream stream; // 0x10
        public bool active; // 0x18
        public System.Net.Sockets.Socket client; // 0x20
        public bool disposed; // 0x28
        public 0x657C2F28 values; // 0x2C
        public int recv_timeout; // 0x30
        public int send_timeout; // 0x34
        public int recv_buffer_size; // 0x38
        public int send_buffer_size; // 0x3C
        public System.Net.Sockets.LingerOption linger_state; // 0x40
        public bool no_delay; // 0x48
        public System.TimeSpan <ConnectTimeout>k__BackingField; // 0x50

        // ── Methods ──
        public void Init(){} // RVA: 0x97FB9D0
        public void .ctor(){} // RVA: 0x97FBDD0 | overloaded x4
        public void get_Active(){} // RVA: 0x2F84E0
        public void set_Active(){} // RVA: 0x2F84F0
        public void get_Client(){} // RVA: 0x30B0C0
        public void set_Client(){} // RVA: 0x97FBE90
        public void get_Available(){} // RVA: 0x97FBF40
        public void get_Connected(){} // RVA: 0x97FBF60
        public void IsConnected(){} // RVA: 0x97FBF80
        public void get_ExclusiveAddressUse(){} // RVA: 0x97FBFE0
        public void set_ExclusiveAddressUse(){} // RVA: 0x97FC060
        public void SetTcpClient(){} // RVA: 0x97FBE90
        public void get_LingerState(){} // RVA: 0x97FC080
        public void set_LingerState(){} // RVA: 0x97FC130
        public void get_NoDelay(){} // RVA: 0x97FC1D0
        public void set_NoDelay(){} // RVA: 0x97FC260
        public void get_ReceiveBufferSize(){} // RVA: 0x97FC2B0
        public void set_ReceiveBufferSize(){} // RVA: 0x97FC340
        public void get_ReceiveTimeout(){} // RVA: 0x97FC390
        public void set_ReceiveTimeout(){} // RVA: 0x97FC420
        public void get_SendBufferSize(){} // RVA: 0x97FC470
        public void set_SendBufferSize(){} // RVA: 0x97FC500
        public void get_SendTimeout(){} // RVA: 0x97FC550
        public void set_SendTimeout(){} // RVA: 0x97FC5E0
        public void get_ConnectTimeout(){} // RVA: 0x37E0E0
        public void set_ConnectTimeout(){} // RVA: 0x4C4D50
        public void Close(){} // RVA: 0x97FC630
        public void Connect(){} // RVA: 0x97FCF90 | overloaded x4
        public void SetOptions(){} // RVA: 0x97FCA10
        public void EndConnect(){} // RVA: 0x97FD350
        public void BeginConnect(){} // RVA: 0x97FD3D0 | overloaded x3
        public void System.IDisposable.Dispose(){} // RVA: 0x97FD400
        public void Dispose(){} // RVA: 0x97FD470
        public void Finalize(){} // RVA: 0x5AAC950
        public void GetStream(){} // RVA: 0x97FD540
        public void CheckDisposed(){} // RVA: 0x97FD670
    }

}