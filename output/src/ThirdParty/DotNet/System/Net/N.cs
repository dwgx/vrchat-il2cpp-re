// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 6
// Methods: 81

namespace ThirdParty.DotNet.System.Net
{
    public class NclUtilities : Object
    {
        public System.Net.IPAddress[] _LocalAddresses;
        public object _LocalAddressesLock; // 0x8

        // ── Methods ──
        public void IsFatal(){} // RVA: 0x7FFE8765E550
        public void IsAddressLocal(){} // RVA: 0x7FFE8765E610
        public void GetLocalHost(){} // RVA: 0x7FFE8765E6A0
        public void get_LocalAddresses(){} // RVA: 0x7FFE8765E6C0
        public void get_LocalAddressesLock(){} // RVA: 0x7FFE8765EDB0
    }

    public class NetEventSource : EventSource
    {
        public System.Net.NetEventSource Log;

        // ── Methods ──
        public void Enter(){} // RVA: 0x7FFE8780BE00 | overloaded x4
        public void Exit(){} // RVA: 0x7FFE8780C120 | overloaded x3
        public void Info(){} // RVA: 0x7FFE8780C440 | overloaded x3
        public void Error(){} // RVA: 0x7FFE8780C4D0
        public void ErrorMessage(){} // RVA: 0x7FFE8780C610
        public void Fail(){} // RVA: 0x7FFE8780C6A0
        public void CriticalFailure(){} // RVA: 0x7FFE8780C7E0
        public void Associate(){} // RVA: 0x7FFE8780C9A0 | overloaded x2
        public void get_IsEnabled(){} // RVA: 0x7FFE8780CA40
        public void IdOf(){} // RVA: 0x7FFE8780CAA0
        public void GetHashCode(){} // RVA: 0x7FFE8780CC10
        public void Format(){} // RVA: 0x7FFE8780D060 | overloaded x2
        public void WriteEvent(){} // RVA: 0x7FFE8780D500
        public void .ctor(){} // RVA: 0x7FFE8694F610
        public void .cctor(){} // RVA: 0x7FFE8780D540
    }

    public class NetRes : Object
    {
        // ── Methods ──
        public void GetWebStatusString(){} // RVA: 0x7FFE8766D110 | overloaded x2
        public void GetWebStatusCodeString(){} // RVA: 0x7FFE8766D160
    }

    public class NetworkCredential : Object
    {
        public string m_domain; // 0x10
        public string m_userName; // 0x18
        public System.Security.SecureString m_password; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876600F0 | overloaded x2
        public void get_UserName(){} // RVA: 0x7FFE810FE7C0
        public void set_UserName(){} // RVA: 0x7FFE87660340
        public void get_Password(){} // RVA: 0x7FFE87660460
        public void set_Password(){} // RVA: 0x7FFE87660470
        public void get_Domain(){} // RVA: 0x7FFE81116380
        public void set_Domain(){} // RVA: 0x7FFE876604E0
        public void InternalGetUserName(){} // RVA: 0x7FFE810FE7C0
        public void InternalGetPassword(){} // RVA: 0x7FFE87660460
        public void InternalGetDomain(){} // RVA: 0x7FFE81116380
        public void GetCredential(){} // RVA: 0x7FFE827C4A80
    }

    public class NetworkStreamWrapper : Stream
    {
        public System.Net.Sockets.TcpClient _client; // 0x28
        public System.Net.Sockets.NetworkStream _networkStream; // 0x30
        public object field_2; // 0x432
        public object field_3; // 0x433
        public object field_4; // 0x434
        public object field_5; // 0x435
        public object field_6; // 0x436
        public object field_7; // 0x437
        public object field_8; // 0x438
        public object field_9; // 0x439
        public object field_10; // 0x43A
        public object field_11; // 0x43B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8765B150
        public void get_UsingSecureStream(){} // RVA: 0x7FFE8765B270
        public void get_ServerAddress(){} // RVA: 0x7FFE8765B300
        public void get_Socket(){} // RVA: 0x7FFE84D05590
        public void get_NetworkStream(){} // RVA: 0x7FFE8144E200
        public void set_NetworkStream(){} // RVA: 0x7FFE81129890
        public void get_CanRead(){} // RVA: 0x7FFE8697C2B0
        public void get_CanSeek(){} // RVA: 0x7FFE86862880
        public void get_CanWrite(){} // RVA: 0x7FFE8765B390
        public void get_CanTimeout(){} // RVA: 0x7FFE8765B3C0
        public void get_ReadTimeout(){} // RVA: 0x7FFE8765B3F0
        public void set_ReadTimeout(){} // RVA: 0x7FFE86862970
        public void get_WriteTimeout(){} // RVA: 0x7FFE8765B420
        public void set_WriteTimeout(){} // RVA: 0x7FFE86862AD0
        public void get_Length(){} // RVA: 0x7FFE8697C370
        public void get_Position(){} // RVA: 0x7FFE8697C280
        public void set_Position(){} // RVA: 0x7FFE86862910
        public void Seek(){} // RVA: 0x7FFE8765B450
        public void Read(){} // RVA: 0x7FFE8765B480
        public void Write(){} // RVA: 0x7FFE8765B4B0
        public void Dispose(){} // RVA: 0x7FFE8765B4E0
        public void CloseSocket(){} // RVA: 0x7FFE8765B580
        public void Close(){} // RVA: 0x7FFE8765B5D0
        public void BeginRead(){} // RVA: 0x7FFE8765B620
        public void EndRead(){} // RVA: 0x7FFE86862B90
        public void ReadAsync(){} // RVA: 0x7FFE8765B660
        public void BeginWrite(){} // RVA: 0x7FFE8765B690
        public void EndWrite(){} // RVA: 0x7FFE8765B6D0
        public void WriteAsync(){} // RVA: 0x7FFE8765B700
        public void Flush(){} // RVA: 0x7FFE8697C430
        public void FlushAsync(){} // RVA: 0x7FFE86862D20
        public void SetLength(){} // RVA: 0x7FFE8765B730
        public void SetSocketTimeoutOption(){} // RVA: 0x7FFE8765B760
    }

    public class NtlmClient : Object
    {
        public System.Net.IAuthenticationModule authObject; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876AD060
        public void Authenticate(){} // RVA: 0x7FFE876AD0F0
        public void PreAuthenticate(){} // RVA: 0x7FFE813240E0
        public void get_AuthenticationType(){} // RVA: 0x7FFE876AD170
    }

}