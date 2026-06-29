// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 6
// Methods: 70

namespace ThirdParty.DotNet.System.Net
{
    public class NclUtilities : Object
    {
        public object _LocalAddresses;
        public object _LocalAddressesLock;
        public object _LocalDomainName;

        // ── Methods ──
        public void IsFatal(){} // RVA: 0x7583670
        public void IsAddressLocal(){} // RVA: 0x7583730
        public void GetLocalHost(){} // RVA: 0x75837C0
        public void get_LocalAddresses(){} // RVA: 0x75838F0
        public void get_LocalAddressesLock(){} // RVA: 0x7584100
    }

    public class NetEventSource : EventSource
    {
        public object Log;

        // ── Methods ──
        public void Enter(){} // RVA: 0x7729870
        public void Exit(){} // RVA: 0x7729B90
        public void Info(){} // RVA: 0x7729EB0
        public void Error(){} // RVA: 0x7729F40
        public void ErrorMessage(){} // RVA: 0x772A080
        public void Fail(){} // RVA: 0x772A110
        public void CriticalFailure(){} // RVA: 0x772A250
        public void Associate(){} // RVA: 0x772A410
        public void get_IsEnabled(){} // RVA: 0x772A4B0
        public void IdOf(){} // RVA: 0x772A510
        public void GetHashCode(){} // RVA: 0x772A680
        public void Format(){} // RVA: 0x772AAA0
        public void WriteEvent(){} // RVA: 0x772AF60
        public void .ctor(){} // RVA: 0x6888090
        public void .cctor(){} // RVA: 0x772AFA0
    }

    public class NetRes : Object
    {
        // ── Methods ──
        public void GetWebStatusString(){} // RVA: 0x75921F0
        public void GetWebStatusCodeString(){} // RVA: 0x7592240
    }

    public class NetworkCredential : Object
    {
        public object m_domain;
        public object m_userName;
        public object m_password;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75853B0
        public void get_UserName(){} // RVA: 0xB465B0
        public void set_UserName(){} // RVA: 0x75855D0
        public void get_Password(){} // RVA: 0x75856B0
        public void set_Password(){} // RVA: 0x75856C0
        public void get_Domain(){} // RVA: 0xB5DBF0
        public void set_Domain(){} // RVA: 0x7585730
        public void InternalGetUserName(){} // RVA: 0xB465B0
        public void InternalGetPassword(){} // RVA: 0x75856B0
        public void InternalGetDomain(){} // RVA: 0xB5DBF0
        public void GetCredential(){} // RVA: 0x2303260
    }

    public class NetworkStreamWrapper : Stream
    {
        public object _client;
        public object _networkStream;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7580190
        public void get_UsingSecureStream(){} // RVA: 0x75802B0
        public void get_ServerAddress(){} // RVA: 0x7580330
        public void get_Socket(){} // RVA: 0x4B531E0
        public void get_NetworkStream(){} // RVA: 0xD33E60
        public void set_NetworkStream(){} // RVA: 0xB708C0
        public void get_CanRead(){} // RVA: 0x68B4D10
        public void get_CanSeek(){} // RVA: 0x679A330
        public void get_CanWrite(){} // RVA: 0x75803C0
        public void get_CanTimeout(){} // RVA: 0x75803F0
        public void get_ReadTimeout(){} // RVA: 0x7580420
        public void set_ReadTimeout(){} // RVA: 0x679A420
        public void get_WriteTimeout(){} // RVA: 0x7580450
        public void set_WriteTimeout(){} // RVA: 0x679A580
        public void get_Length(){} // RVA: 0x68B4DD0
        public void get_Position(){} // RVA: 0x68B4CE0
        public void set_Position(){} // RVA: 0x679A3C0
        public void Seek(){} // RVA: 0x7580480
        public void Read(){} // RVA: 0x75804B0
        public void Write(){} // RVA: 0x75804E0
        public void Dispose(){} // RVA: 0x7580510
        public void CloseSocket(){} // RVA: 0x75805B0
        public void Close(){} // RVA: 0x7580600
        public void BeginRead(){} // RVA: 0x7580650
        public void EndRead(){} // RVA: 0x679A640
        public void ReadAsync(){} // RVA: 0x7580690
        public void BeginWrite(){} // RVA: 0x75806C0
        public void EndWrite(){} // RVA: 0x7580700
        public void WriteAsync(){} // RVA: 0x7580730
        public void Flush(){} // RVA: 0x68B4E90
        public void FlushAsync(){} // RVA: 0x679A7D0
        public void SetLength(){} // RVA: 0x7580760
        public void SetSocketTimeoutOption(){} // RVA: 0x7580790
    }

    public class NtlmClient : Object
    {
        public object authObject;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75D0180
        public void Authenticate(){} // RVA: 0x75D0210
        public void PreAuthenticate(){} // RVA: 0xDAC980
        public void get_AuthenticationType(){} // RVA: 0x75D0290
    }

}