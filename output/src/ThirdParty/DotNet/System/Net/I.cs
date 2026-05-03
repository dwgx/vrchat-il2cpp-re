// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 12
// Methods: 75

namespace ThirdParty.DotNet.System.Net
{
    public class IAuthenticationModule
    {
        // ── Methods ──
        public void Authenticate(){} // RVA: 0x7FFE80E403A0
        public void PreAuthenticate(){} // RVA: 0x7FFE80E3FC10
        public void get_AuthenticationType(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ICertificatePolicy
    {
        // ── Methods ──
        public void CheckValidationResult(){}
    }

    public class ICloseEx
    {
        // ── Methods ──
        public void CloseEx(){} // RVA: 0x7FFE80E46530
    }

    public class ICredentialPolicy
    {
    }

    public class ICredentials
    {
        // ── Methods ──
        public void GetCredential(){} // RVA: 0x7FFE80E3FC10
    }

    public class IPAddress : Object
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
        public void get_IsIPv4(){} // RVA: 0x7FFE83BA1AA0
        public void get_IsIPv6(){} // RVA: 0x7FFE82AC8EE0
        public void get_PrivateAddress(){} // RVA: 0x7FFE811485C0
        public void set_PrivateAddress(){} // RVA: 0x7FFE8780DE70
        public void get_PrivateScopeId(){} // RVA: 0x7FFE811485C0
        public void set_PrivateScopeId(){} // RVA: 0x7FFE8780DE70
        public void .ctor(){} // RVA: 0x7FFE8780E4D0 | overloaded x7
        public void TryParse(){} // RVA: 0x7FFE8780E6B0
        public void Parse(){} // RVA: 0x7FFE8780E7F0
        public void TryWriteBytes(){} // RVA: 0x7FFE8780E8A0
        public void WriteIPv6Bytes(){} // RVA: 0x7FFE8780E9A0
        public void WriteIPv4Bytes(){} // RVA: 0x7FFE8780EA40
        public void GetAddressBytes(){} // RVA: 0x7FFE8780EA90
        public void get_AddressFamily(){} // RVA: 0x7FFE8780EC00
        public void get_ScopeId(){} // RVA: 0x7FFE8780EC20
        public void ToString(){} // RVA: 0x7FFE8780EC80
        public void HostToNetworkOrder(){} // RVA: 0x7FFE8780ED80 | overloaded x2
        public void NetworkToHostOrder(){} // RVA: 0x7FFE8780EDF0 | overloaded x2
        public void IsLoopback(){} // RVA: 0x7FFE8780EE40
        public void get_IsIPv6LinkLocal(){} // RVA: 0x7FFE8780EF20
        public void get_Address(){} // RVA: 0x7FFE8780EF60
        public void Equals(){} // RVA: 0x7FFE8780F110 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8780F120
        public void MapToIPv6(){} // RVA: 0x7FFE8780F500
        public void ThrowAddressNullException(){} // RVA: 0x7FFE8780F6A0
        public void .cctor(){} // RVA: 0x7FFE8780F6F0
    }

    public class IPAddressParser : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFE8780FDF0
        public void IPv4AddressToString(){} // RVA: 0x7FFE87810340 | overloaded x2
        public void IPv4AddressToStringHelper(){} // RVA: 0x7FFE878103B0
        public void IPv6AddressToString(){} // RVA: 0x7FFE878105C0
        public void IPv6AddressToStringHelper(){} // RVA: 0x7FFE87810620
        public void FormatIPv4AddressNumber(){} // RVA: 0x7FFE87810A20
        public void Ipv4StringToAddress(){} // RVA: 0x7FFE87810AD0
        public void Ipv6StringToAddress(){} // RVA: 0x7FFE87810BA0
        public void AppendSections(){} // RVA: 0x7FFE87810CE0
        public void AppendHex(){} // RVA: 0x7FFE87810EB0
        public void ExtractIPv4Address(){} // RVA: 0x7FFE87810F70
        public void Reverse(){} // RVA: 0x7FFE86950AC0
    }

    public class IPEndPoint : EndPoint
    {
        public int MinPort;
        public int MaxPort;
        public System.Net.IPAddress _address; // 0x10

        // ── Methods ──
        public void get_AddressFamily(){} // RVA: 0x7FFE87810FC0
        public void .ctor(){} // RVA: 0x7FFE87810FF0
        public void get_Address(){} // RVA: 0x7FFE81116380
        public void get_Port(){} // RVA: 0x7FFE813DB630
        public void ToString(){} // RVA: 0x7FFE87811100
        public void Serialize(){} // RVA: 0x7FFE87811290
        public void Create(){} // RVA: 0x7FFE87811330
        public void Equals(){} // RVA: 0x7FFE87811630
        public void GetHashCode(){} // RVA: 0x7FFE87811700
        public void .cctor(){} // RVA: 0x7FFE87811740
    }

    public class IPHostEntry : Object
    {
        public string hostName; // 0x10
        public string[] aliases; // 0x18
        public System.Net.IPAddress[] addressList; // 0x20

        // ── Methods ──
        public void get_HostName(){} // RVA: 0x7FFE81116380
        public void set_HostName(){} // RVA: 0x7FFE810FCE30
        public void set_Aliases(){} // RVA: 0x7FFE81161E80
        public void get_AddressList(){} // RVA: 0x7FFE811290C0
        public void set_AddressList(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE8225D1D0
    }

    public class IWebProxy
    {
        // ── Methods ──
        public void GetProxy(){} // RVA: 0x7FFE80E2E390
        public void IsBypassed(){} // RVA: 0x7FFE80E2F3B0
        public void get_Credentials(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IWebRequestCreate
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE80E2E390
    }

    public class InternalException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867A3960
    }

}