// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 12
// Methods: 75

namespace ThirdParty.DotNet.System.Net
{
    public class IAuthenticationModule
    {
        public object AuthenticationType;

        // ── Methods ──
        public void Authenticate(){} // RVA: 0x7FFAC2C6AE80
        public void PreAuthenticate(){} // RVA: 0x7FFAC2C6A6F0
        public void get_AuthenticationType(){} // RVA: 0x7FFAC2C58E90
    }

    public class ICertificatePolicy
    {
        // ── Methods ──
        public void CheckValidationResult(){}
    }

    public class ICloseEx
    {
        // ── Methods ──
        public void CloseEx(){} // RVA: 0x7FFAC2C70ED0
    }

    public class ICredentialPolicy
    {
    }

    public class ICredentials
    {
        // ── Methods ──
        public void GetCredential(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class IPAddress : Object
    {
        public System.Net.IPAddress IsIPv4;
        public System.Net.IPAddress IsIPv6; // 0x8
        public System.Net.IPAddress PrivateAddress; // 0x10
        public System.Net.IPAddress PrivateScopeId; // 0x18
        public long AddressFamily;
        public System.Net.IPAddress ScopeId; // 0x20
        public System.Net.IPAddress IsIPv6LinkLocal; // 0x28
        public System.Net.IPAddress Address; // 0x30
        public uint _addressOrScopeId; // 0x10
        public ushort[] _numbers; // 0x18
        public string _toString; // 0x20
        public int _hashCode; // 0x28
        public int NumberOfLabels;

        // ── Methods ──
        public void get_IsIPv4(){} // RVA: 0x7FFAC58650E0
        public void get_IsIPv6(){} // RVA: 0x7FFAC4860B40
        public void get_PrivateAddress(){} // RVA: 0x7FFAC2F6E5C0
        public void set_PrivateAddress(){} // RVA: 0x7FFAC9465730
        public void get_PrivateScopeId(){} // RVA: 0x7FFAC2F6E5C0
        public void set_PrivateScopeId(){} // RVA: 0x7FFAC9465730
        public void .ctor(){} // RVA: 0x7FFAC9465D90 | overloaded x7
        public void TryParse(){} // RVA: 0x7FFAC9465F70
        public void Parse(){} // RVA: 0x7FFAC94660B0
        public void TryWriteBytes(){} // RVA: 0x7FFAC9466160
        public void WriteIPv6Bytes(){} // RVA: 0x7FFAC9466260
        public void WriteIPv4Bytes(){} // RVA: 0x7FFAC9466300
        public void GetAddressBytes(){} // RVA: 0x7FFAC9466350
        public void get_AddressFamily(){} // RVA: 0x7FFAC94664C0
        public void get_ScopeId(){} // RVA: 0x7FFAC94664E0
        public void ToString(){} // RVA: 0x7FFAC9466540
        public void HostToNetworkOrder(){} // RVA: 0x7FFAC9466640 | overloaded x2
        public void NetworkToHostOrder(){} // RVA: 0x7FFAC94666B0 | overloaded x2
        public void IsLoopback(){} // RVA: 0x7FFAC9466700
        public void get_IsIPv6LinkLocal(){} // RVA: 0x7FFAC94667E0
        public void get_Address(){} // RVA: 0x7FFAC9466820
        public void Equals(){} // RVA: 0x7FFAC94669D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC94669E0
        public void MapToIPv6(){} // RVA: 0x7FFAC9466DC0
        public void ThrowAddressNullException(){} // RVA: 0x7FFAC9466F60
        public void .cctor(){} // RVA: 0x7FFAC9466FB0
    }

    public class IPAddressParser : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFAC94676B0
        public void IPv4AddressToString(){} // RVA: 0x7FFAC9467C00 | overloaded x2
        public void IPv4AddressToStringHelper(){} // RVA: 0x7FFAC9467C70
        public void IPv6AddressToString(){} // RVA: 0x7FFAC9467E80
        public void IPv6AddressToStringHelper(){} // RVA: 0x7FFAC9467EE0
        public void FormatIPv4AddressNumber(){} // RVA: 0x7FFAC94682E0
        public void Ipv4StringToAddress(){} // RVA: 0x7FFAC9468390
        public void Ipv6StringToAddress(){} // RVA: 0x7FFAC9468460
        public void AppendSections(){} // RVA: 0x7FFAC94685A0
        public void AppendHex(){} // RVA: 0x7FFAC9468770
        public void ExtractIPv4Address(){} // RVA: 0x7FFAC9468830
        public void Reverse(){} // RVA: 0x7FFAC85A72F0
    }

    public class IPEndPoint : EndPoint
    {
        public int AddressFamily;
        public int Address;
        public System.Net.IPAddress Port; // 0x10
        public int _port; // 0x18
        public int AnyPort;
        public System.Net.IPEndPoint Any;
        public System.Net.IPEndPoint IPv6Any; // 0x8

        // ── Methods ──
        public void get_AddressFamily(){} // RVA: 0x7FFAC9468880
        public void .ctor(){} // RVA: 0x7FFAC94688B0
        public void get_Address(){} // RVA: 0x7FFAC2F3C380
        public void get_Port(){} // RVA: 0x7FFAC3157800
        public void ToString(){} // RVA: 0x7FFAC94689C0
        public void Serialize(){} // RVA: 0x7FFAC9468B50
        public void Create(){} // RVA: 0x7FFAC9468BF0
        public void Equals(){} // RVA: 0x7FFAC9468EF0
        public void GetHashCode(){} // RVA: 0x7FFAC9468FC0
        public void .cctor(){} // RVA: 0x7FFAC9469000
    }

    public class IPHostEntry : Object
    {
        public string HostName; // 0x10
        public string[] Aliases; // 0x18
        public System.Net.IPAddress[] AddressList; // 0x20
        public bool isTrustedHost; // 0x28

        // ── Methods ──
        public void get_HostName(){} // RVA: 0x7FFAC2F3C380
        public void set_HostName(){} // RVA: 0x7FFAC2F22E30
        public void set_Aliases(){} // RVA: 0x7FFAC2F87E80
        public void get_AddressList(){} // RVA: 0x7FFAC2F4F0C0
        public void set_AddressList(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC40285C0
    }

    public class IWebProxy
    {
        public object Credentials;

        // ── Methods ──
        public void GetProxy(){} // RVA: 0x7FFAC2C58F40
        public void IsBypassed(){} // RVA: 0x7FFAC2C59F60
        public void get_Credentials(){} // RVA: 0x7FFAC2C58E90
    }

    public class IWebRequestCreate
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2C58F40
    }

    public class InternalException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83FA020
    }

}