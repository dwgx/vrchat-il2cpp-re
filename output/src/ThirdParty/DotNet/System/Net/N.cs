// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 6
// Methods: 81

namespace ThirdParty.DotNet.System.Net
{
    public class NclUtilities : Object
    {
        public System.Net.IPAddress[] LocalAddresses;
        public object LocalAddressesLock; // 0x8
        public string _LocalDomainName; // 0x10

        // ── Methods ──
        public void IsFatal(){} // RVA: 0x7FFAC92B5E10
        public void IsAddressLocal(){} // RVA: 0x7FFAC92B5ED0
        public void GetLocalHost(){} // RVA: 0x7FFAC92B5F60
        public void get_LocalAddresses(){} // RVA: 0x7FFAC92B5F80
        public void get_LocalAddressesLock(){} // RVA: 0x7FFAC92B6670
    }

    public class NetEventSource : EventSource
    {
        public System.Net.NetEventSource IsEnabled;

        // ── Methods ──
        public void Enter(){} // RVA: 0x7FFAC94636C0 | overloaded x4
        public void Exit(){} // RVA: 0x7FFAC94639E0 | overloaded x3
        public void Info(){} // RVA: 0x7FFAC9463D00 | overloaded x3
        public void Error(){} // RVA: 0x7FFAC9463D90
        public void ErrorMessage(){} // RVA: 0x7FFAC9463ED0
        public void Fail(){} // RVA: 0x7FFAC9463F60
        public void CriticalFailure(){} // RVA: 0x7FFAC94640A0
        public void Associate(){} // RVA: 0x7FFAC9464260 | overloaded x2
        public void get_IsEnabled(){} // RVA: 0x7FFAC9464300
        public void IdOf(){} // RVA: 0x7FFAC9464360
        public void GetHashCode(){} // RVA: 0x7FFAC94644D0
        public void Format(){} // RVA: 0x7FFAC9464920 | overloaded x2
        public void WriteEvent(){} // RVA: 0x7FFAC9464DC0
        public void .ctor(){} // RVA: 0x7FFAC85A5E30
        public void .cctor(){} // RVA: 0x7FFAC9464E00
    }

    public class NetRes : Object
    {
        // ── Methods ──
        public void GetWebStatusString(){} // RVA: 0x7FFAC92C49D0 | overloaded x2
        public void GetWebStatusCodeString(){} // RVA: 0x7FFAC92C4A20
    }

    public class NetworkCredential : Object
    {
        public string UserName; // 0x10
        public string Password; // 0x18
        public System.Security.SecureString Domain; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92B79B0 | overloaded x2
        public void get_UserName(){} // RVA: 0x7FFAC2F247C0
        public void set_UserName(){} // RVA: 0x7FFAC92B7C00
        public void get_Password(){} // RVA: 0x7FFAC92B7D20
        public void set_Password(){} // RVA: 0x7FFAC92B7D30
        public void get_Domain(){} // RVA: 0x7FFAC2F3C380
        public void set_Domain(){} // RVA: 0x7FFAC92B7DA0
        public void InternalGetUserName(){} // RVA: 0x7FFAC2F247C0
        public void InternalGetPassword(){} // RVA: 0x7FFAC92B7D20
        public void InternalGetDomain(){} // RVA: 0x7FFAC2F3C380
        public void GetCredential(){} // RVA: 0x7FFAC44F81E0
    }

    public class NetworkStreamWrapper : Stream
    {
        public System.Net.Sockets.TcpClient UsingSecureStream; // 0x28
        public System.Net.Sockets.NetworkStream ServerAddress; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92B2A10
        public void get_UsingSecureStream(){} // RVA: 0x7FFAC92B2B30
        public void get_ServerAddress(){} // RVA: 0x7FFAC92B2BC0
        public void get_Socket(){} // RVA: 0x7FFAC69A4060
        public void get_NetworkStream(){} // RVA: 0x7FFAC31D95E0
        public void set_NetworkStream(){} // RVA: 0x7FFAC2F4F890
        public void get_CanRead(){} // RVA: 0x7FFAC85D2AE0
        public void get_CanSeek(){} // RVA: 0x7FFAC84B9050
        public void get_CanWrite(){} // RVA: 0x7FFAC92B2C50
        public void get_CanTimeout(){} // RVA: 0x7FFAC92B2C80
        public void get_ReadTimeout(){} // RVA: 0x7FFAC92B2CB0
        public void set_ReadTimeout(){} // RVA: 0x7FFAC84B9140
        public void get_WriteTimeout(){} // RVA: 0x7FFAC92B2CE0
        public void set_WriteTimeout(){} // RVA: 0x7FFAC84B92A0
        public void get_Length(){} // RVA: 0x7FFAC85D2BA0
        public void get_Position(){} // RVA: 0x7FFAC85D2AB0
        public void set_Position(){} // RVA: 0x7FFAC84B90E0
        public void Seek(){} // RVA: 0x7FFAC92B2D10
        public void Read(){} // RVA: 0x7FFAC92B2D40
        public void Write(){} // RVA: 0x7FFAC92B2D70
        public void Dispose(){} // RVA: 0x7FFAC92B2DA0
        public void CloseSocket(){} // RVA: 0x7FFAC92B2E40
        public void Close(){} // RVA: 0x7FFAC92B2E90
        public void BeginRead(){} // RVA: 0x7FFAC92B2EE0
        public void EndRead(){} // RVA: 0x7FFAC84B9360
        public void ReadAsync(){} // RVA: 0x7FFAC92B2F20
        public void BeginWrite(){} // RVA: 0x7FFAC92B2F50
        public void EndWrite(){} // RVA: 0x7FFAC92B2F90
        public void WriteAsync(){} // RVA: 0x7FFAC92B2FC0
        public void Flush(){} // RVA: 0x7FFAC85D2C60
        public void FlushAsync(){} // RVA: 0x7FFAC84B94F0
        public void SetLength(){} // RVA: 0x7FFAC92B2FF0
        public void SetSocketTimeoutOption(){} // RVA: 0x7FFAC92B3020
    }

    public class NtlmClient : Object
    {
        public System.Net.IAuthenticationModule AuthenticationType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9304930
        public void Authenticate(){} // RVA: 0x7FFAC93049C0
        public void PreAuthenticate(){} // RVA: 0x7FFAC34F9180
        public void get_AuthenticationType(){} // RVA: 0x7FFAC9304A40
    }

}