// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 6
// Methods: 81

namespace ThirdParty.DotNet.System.Net
{
    public class NclUtilities
    {
        public System.Net.IPAddress[] _LocalAddresses;
        public object _LocalAddressesLock; // 0x8

        // ── Methods ──
        public void IsFatal(){} // RVA: 0x6B1F290
        public void IsAddressLocal(){} // RVA: 0x6B1F350
        public void GetLocalHost(){} // RVA: 0x6B1F3E0
        public void get_LocalAddresses(){} // RVA: 0x6B1F400
        public void get_LocalAddressesLock(){} // RVA: 0x6B1FAF0
    }

    public class NetEventSource
    {
        public System.Net.NetEventSource Log;

        // ── Methods ──
        public void Enter(){} // RVA: 0x6CCAF60 | overloaded x4
        public void Exit(){} // RVA: 0x6CCB280 | overloaded x3
        public void Info(){} // RVA: 0x6CCB5A0 | overloaded x3
        public void Error(){} // RVA: 0x6CCB630
        public void ErrorMessage(){} // RVA: 0x6CCB770
        public void Fail(){} // RVA: 0x6CCB800
        public void CriticalFailure(){} // RVA: 0x6CCB940
        public void Associate(){} // RVA: 0x6CCBB00 | overloaded x2
        public void get_IsEnabled(){} // RVA: 0x6CCBBA0
        public void IdOf(){} // RVA: 0x6CCBC00
        public void GetHashCode(){} // RVA: 0x6CCBD70
        public void Format(){} // RVA: 0x6CCC1C0 | overloaded x2
        public void WriteEvent(){} // RVA: 0x6CCC660
        public void .ctor(){} // RVA: 0x5E0E7D0
        public void .cctor(){} // RVA: 0x6CCC6A0
    }

    public class NetRes
    {
        // ── Methods ──
        public void GetWebStatusString(){} // RVA: 0x6B2DE50 | overloaded x2
        public void GetWebStatusCodeString(){} // RVA: 0x6B2DEA0
    }

    public class NetworkCredential
    {
        public string m_domain; // 0x10
        public string m_userName; // 0x18
        public System.Security.SecureString m_password; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B20E30 | overloaded x2
        public void get_UserName(){} // RVA: 0x2E07C0
        public void set_UserName(){} // RVA: 0x6B21080
        public void get_Password(){} // RVA: 0x6B211A0
        public void set_Password(){} // RVA: 0x6B211B0
        public void get_Domain(){} // RVA: 0x2F8380
        public void set_Domain(){} // RVA: 0x6B21220
        public void InternalGetUserName(){} // RVA: 0x2E07C0
        public void InternalGetPassword(){} // RVA: 0x6B211A0
        public void InternalGetDomain(){} // RVA: 0x2F8380
        public void GetCredential(){} // RVA: 0x1A3F520
    }

    public class NetworkStreamWrapper
    {
        public System.Net.Sockets.TcpClient _client; // 0x28
        public System.Net.Sockets.NetworkStream _networkStream; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B1BE90
        public void get_UsingSecureStream(){} // RVA: 0x6B1BFB0
        public void get_ServerAddress(){} // RVA: 0x6B1C040
        public void get_Socket(){} // RVA: 0x408F2D0
        public void get_NetworkStream(){} // RVA: 0x6374D0
        public void set_NetworkStream(){} // RVA: 0x30B890
        public void get_CanRead(){} // RVA: 0x5E3B470
        public void get_CanSeek(){} // RVA: 0x5D21980
        public void get_CanWrite(){} // RVA: 0x6B1C0D0
        public void get_CanTimeout(){} // RVA: 0x6B1C100
        public void get_ReadTimeout(){} // RVA: 0x6B1C130
        public void set_ReadTimeout(){} // RVA: 0x5D21A70
        public void get_WriteTimeout(){} // RVA: 0x6B1C160
        public void set_WriteTimeout(){} // RVA: 0x5D21BD0
        public void get_Length(){} // RVA: 0x5E3B530
        public void get_Position(){} // RVA: 0x5E3B440
        public void set_Position(){} // RVA: 0x5D21A10
        public void Seek(){} // RVA: 0x6B1C190
        public void Read(){} // RVA: 0x6B1C1C0
        public void Write(){} // RVA: 0x6B1C1F0
        public void Dispose(){} // RVA: 0x6B1C220
        public void CloseSocket(){} // RVA: 0x6B1C2C0
        public void Close(){} // RVA: 0x6B1C310
        public void BeginRead(){} // RVA: 0x6B1C360
        public void EndRead(){} // RVA: 0x5D21C90
        public void ReadAsync(){} // RVA: 0x6B1C3A0
        public void BeginWrite(){} // RVA: 0x6B1C3D0
        public void EndWrite(){} // RVA: 0x6B1C410
        public void WriteAsync(){} // RVA: 0x6B1C440
        public void Flush(){} // RVA: 0x5E3B5F0
        public void FlushAsync(){} // RVA: 0x5D21E20
        public void SetLength(){} // RVA: 0x6B1C470
        public void SetSocketTimeoutOption(){} // RVA: 0x6B1C4A0
    }

    public class NtlmClient
    {
        public System.Net.IAuthenticationModule authObject; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B6DDB0
        public void Authenticate(){} // RVA: 0x6B6DE40
        public void PreAuthenticate(){} // RVA: 0x519240
        public void get_AuthenticationType(){} // RVA: 0x6B6DEC0
    }

}