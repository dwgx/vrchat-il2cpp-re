// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 12
// Methods: 75

namespace ThirdParty.DotNet.System.Net
{
    public class IAuthenticationModule
    {
        // ── Methods ──
        public void Authenticate(){} // RVA: 0x7FFAF2ACEE30
        public void PreAuthenticate(){} // RVA: 0x7FFAF2ACE6A0
        public void get_AuthenticationType(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ICertificatePolicy
    {
        // ── Methods ──
        public void CheckValidationResult(){}
    }

    public class ICloseEx
    {
        // ── Methods ──
        public void CloseEx(){} // RVA: 0x7FFAF2AD4FA0
    }

    public class ICredentialPolicy
    {
    }

    public class ICredentials
    {
        // ── Methods ──
        public void GetCredential(){} // RVA: 0x7FFAF2ACE6A0
    }

    public class IPAddress
    {
        // ── Methods ──
        public void get_IsIPv4(){} // RVA: 0x7FFAF5982970
        public void get_IsIPv6(){} // RVA: 0x7FFAF47EB060
        public void get_PrivateAddress(){} // RVA: 0x7FFAF2DDA5C0
        public void set_PrivateAddress(){} // RVA: 0x7FFAF977CFD0
        public void get_PrivateScopeId(){} // RVA: 0x7FFAF2DDA5C0
        public void set_PrivateScopeId(){} // RVA: 0x7FFAF977CFD0
        public void .ctor(){} // RVA: 0x7FFAF977D630 | overloaded x7
        public void TryParse(){} // RVA: 0x7FFAF977D810
        public void Parse(){} // RVA: 0x7FFAF977D950
        public void TryWriteBytes(){} // RVA: 0x7FFAF977DA00
        public void WriteIPv6Bytes(){} // RVA: 0x7FFAF977DB00
        public void WriteIPv4Bytes(){} // RVA: 0x7FFAF977DBA0
        public void GetAddressBytes(){} // RVA: 0x7FFAF977DBF0
        public void get_AddressFamily(){} // RVA: 0x7FFAF977DD60
        public void get_ScopeId(){} // RVA: 0x7FFAF977DD80
        public void ToString(){} // RVA: 0x7FFAF977DDE0
        public void HostToNetworkOrder(){} // RVA: 0x7FFAF977DEE0 | overloaded x2
        public void NetworkToHostOrder(){} // RVA: 0x7FFAF977DF50 | overloaded x2
        public void IsLoopback(){} // RVA: 0x7FFAF977DFA0
        public void get_IsIPv6LinkLocal(){} // RVA: 0x7FFAF977E080
        public void get_Address(){} // RVA: 0x7FFAF977E0C0
        public void Equals(){} // RVA: 0x7FFAF977E270 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF977E280
        public void MapToIPv6(){} // RVA: 0x7FFAF977E660
        public void ThrowAddressNullException(){} // RVA: 0x7FFAF977E800
        public void .cctor(){} // RVA: 0x7FFAF977E850
    }

    public class IPAddressParser
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFAF977EF50
        public void IPv4AddressToString(){} // RVA: 0x7FFAF977F4A0 | overloaded x2
        public void IPv4AddressToStringHelper(){} // RVA: 0x7FFAF977F510
        public void IPv6AddressToString(){} // RVA: 0x7FFAF977F720
        public void IPv6AddressToStringHelper(){} // RVA: 0x7FFAF977F780
        public void FormatIPv4AddressNumber(){} // RVA: 0x7FFAF977FB80
        public void Ipv4StringToAddress(){} // RVA: 0x7FFAF977FC30
        public void Ipv6StringToAddress(){} // RVA: 0x7FFAF977FD00
        public void AppendSections(){} // RVA: 0x7FFAF977FE40
        public void AppendHex(){} // RVA: 0x7FFAF9780010
        public void ExtractIPv4Address(){} // RVA: 0x7FFAF97800D0
        public void Reverse(){} // RVA: 0x7FFAF88BFC80
    }

    public class IPEndPoint
    {
        // ── Methods ──
        public void get_AddressFamily(){} // RVA: 0x7FFAF9780120
        public void .ctor(){} // RVA: 0x7FFAF9780150
        public void get_Address(){} // RVA: 0x7FFAF2DA8380
        public void get_Port(){} // RVA: 0x7FFAF306ED50
        public void ToString(){} // RVA: 0x7FFAF9780260
        public void Serialize(){} // RVA: 0x7FFAF97803F0
        public void Create(){} // RVA: 0x7FFAF9780490
        public void Equals(){} // RVA: 0x7FFAF9780790
        public void GetHashCode(){} // RVA: 0x7FFAF9780860
        public void .cctor(){} // RVA: 0x7FFAF97808A0
    }

    public class IPHostEntry
    {
        // ── Methods ──
        public void get_HostName(){} // RVA: 0x7FFAF2DA8380
        public void set_HostName(){} // RVA: 0x7FFAF2D8EE30
        public void set_Aliases(){} // RVA: 0x7FFAF2DF3E80
        public void get_AddressList(){} // RVA: 0x7FFAF2DBB0C0
        public void set_AddressList(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAF3F9C4C0
    }

    public class IWebProxy
    {
        // ── Methods ──
        public void GetProxy(){} // RVA: 0x7FFAF2ABCE10
        public void IsBypassed(){} // RVA: 0x7FFAF2ABDE40
        public void get_Credentials(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IWebRequestCreate
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF2ABCE10
    }

    public class InternalException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8712AC0
    }

}