// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 12
// Methods: 75

namespace ThirdParty.DotNet.System.Net
{
    public class IAuthenticationModule
    {
        // ── Methods ──
        public void Authenticate(){} // RVA: 0x1EE30
        public void PreAuthenticate(){} // RVA: 0x1E6A0
        public void get_AuthenticationType(){} // RVA: 0xCD60
    }

    public class ICertificatePolicy
    {
        // ── Methods ──
        public void CheckValidationResult(){}
    }

    public class ICloseEx
    {
        // ── Methods ──
        public void CloseEx(){} // RVA: 0x24FA0
    }

    public class ICredentialPolicy
    {
    }

    public class ICredentials
    {
        // ── Methods ──
        public void GetCredential(){} // RVA: 0x1E6A0
    }

    public class IPAddress
    {
        public System.Net.IPAddress Any;
        public System.Net.IPAddress Loopback; // 0x8
        public System.Net.IPAddress Broadcast; // 0x10
        public System.Net.IPAddress None; // 0x18
        public long LoopbackMask;
        public System.Net.IPAddress IPv6Any; // 0x20
        public System.Net.IPAddress IPv6Loopback; // 0x28
        public System.Net.IPAddress IPv6None; // 0x30

        // ── Methods ──
        public void get_IsIPv4(){} // RVA: 0x2ED2970
        public void get_IsIPv6(){} // RVA: 0x1D3B060
        public void get_PrivateAddress(){} // RVA: 0x32A5C0
        public void set_PrivateAddress(){} // RVA: 0x6CCCFD0
        public void get_PrivateScopeId(){} // RVA: 0x32A5C0
        public void set_PrivateScopeId(){} // RVA: 0x6CCCFD0
        public void .ctor(){} // RVA: 0x6CCD630 | overloaded x7
        public void TryParse(){} // RVA: 0x6CCD810
        public void Parse(){} // RVA: 0x6CCD950
        public void TryWriteBytes(){} // RVA: 0x6CCDA00
        public void WriteIPv6Bytes(){} // RVA: 0x6CCDB00
        public void WriteIPv4Bytes(){} // RVA: 0x6CCDBA0
        public void GetAddressBytes(){} // RVA: 0x6CCDBF0
        public void get_AddressFamily(){} // RVA: 0x6CCDD60
        public void get_ScopeId(){} // RVA: 0x6CCDD80
        public void ToString(){} // RVA: 0x6CCDDE0
        public void HostToNetworkOrder(){} // RVA: 0x6CCDEE0 | overloaded x2
        public void NetworkToHostOrder(){} // RVA: 0x6CCDF50 | overloaded x2
        public void IsLoopback(){} // RVA: 0x6CCDFA0
        public void get_IsIPv6LinkLocal(){} // RVA: 0x6CCE080
        public void get_Address(){} // RVA: 0x6CCE0C0
        public void Equals(){} // RVA: 0x6CCE270 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6CCE280
        public void MapToIPv6(){} // RVA: 0x6CCE660
        public void ThrowAddressNullException(){} // RVA: 0x6CCE800
        public void .cctor(){} // RVA: 0x6CCE850
    }

    public class IPAddressParser
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x6CCEF50
        public void IPv4AddressToString(){} // RVA: 0x6CCF4A0 | overloaded x2
        public void IPv4AddressToStringHelper(){} // RVA: 0x6CCF510
        public void IPv6AddressToString(){} // RVA: 0x6CCF720
        public void IPv6AddressToStringHelper(){} // RVA: 0x6CCF780
        public void FormatIPv4AddressNumber(){} // RVA: 0x6CCFB80
        public void Ipv4StringToAddress(){} // RVA: 0x6CCFC30
        public void Ipv6StringToAddress(){} // RVA: 0x6CCFD00
        public void AppendSections(){} // RVA: 0x6CCFE40
        public void AppendHex(){} // RVA: 0x6CD0010
        public void ExtractIPv4Address(){} // RVA: 0x6CD00D0
        public void Reverse(){} // RVA: 0x5E0FC80
    }

    public class IPEndPoint
    {
        public int MinPort;
        public int MaxPort;
        public System.Net.IPAddress _address; // 0x10

        // ── Methods ──
        public void get_AddressFamily(){} // RVA: 0x6CD0120
        public void .ctor(){} // RVA: 0x6CD0150
        public void get_Address(){} // RVA: 0x2F8380
        public void get_Port(){} // RVA: 0x5BED50
        public void ToString(){} // RVA: 0x6CD0260
        public void Serialize(){} // RVA: 0x6CD03F0
        public void Create(){} // RVA: 0x6CD0490
        public void Equals(){} // RVA: 0x6CD0790
        public void GetHashCode(){} // RVA: 0x6CD0860
        public void .cctor(){} // RVA: 0x6CD08A0
    }

    public class IPHostEntry
    {
        public string hostName; // 0x10
        public string[] aliases; // 0x18
        public System.Net.IPAddress[] addressList; // 0x20

        // ── Methods ──
        public void get_HostName(){} // RVA: 0x2F8380
        public void set_HostName(){} // RVA: 0x2DEE30
        public void set_Aliases(){} // RVA: 0x343E80
        public void get_AddressList(){} // RVA: 0x30B0C0
        public void set_AddressList(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x14EC4C0
    }

    public class IWebProxy
    {
        // ── Methods ──
        public void GetProxy(){} // RVA: 0xCE10
        public void IsBypassed(){} // RVA: 0xDE40
        public void get_Credentials(){} // RVA: 0xCD60
    }

    public class IWebRequestCreate
    {
        // ── Methods ──
        public void Create(){} // RVA: 0xCE10
    }

    public class InternalException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C62AC0
    }

}