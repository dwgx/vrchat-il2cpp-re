// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 12
// Methods: 80

namespace ThirdParty.DotNet.System.Net
{
    public class IAuthenticationModule
    {
        // ── Methods ──
        public void Authenticate(){} // RVA: 0x882090
        public void PreAuthenticate(){} // RVA: 0x87C5F0
        public void get_AuthenticationType(){} // RVA: 0x87C0A0
    }

    public class ICertificatePolicy
    {
        // ── Methods ──
        public void CheckValidationResult(){} // RVA: 0x880BD0
    }

    public class ICloseEx
    {
        // ── Methods ──
        public void CloseEx(){} // RVA: 0x8944F0
    }

    public class ICredentials
    {
        // ── Methods ──
        public void GetCredential(){} // RVA: 0x87C5F0
    }

    public class IPAddress : Object
    {
        public object Any;
        public object Loopback;
        public object Broadcast;
        public object None;
        public object LoopbackMask;
        public object IPv6Any;
        public object IPv6Loopback;
        public object IPv6None;
        public object _addressOrScopeId;
        public object _numbers;
        public object _toString;
        public object _hashCode;
        public object NumberOfLabels;

        // ── Methods ──
        public void get_IsIPv4(){} // RVA: 0x3911580
        public void get_IsIPv6(){} // RVA: 0x25E9250
        public void get_PrivateAddress(){} // RVA: 0xB8F8F0
        public void set_PrivateAddress(){} // RVA: 0x772B8E0
        public void get_PrivateScopeId(){} // RVA: 0xB8F8F0
        public void set_PrivateScopeId(){} // RVA: 0x772B8E0
        public void .ctor(){} // RVA: 0x772BF50
        public void TryParse(){} // RVA: 0x772C140
        public void Parse(){} // RVA: 0x772C280
        public void TryWriteBytes(){} // RVA: 0x772C330
        public void WriteIPv6Bytes(){} // RVA: 0x772C430
        public void WriteIPv4Bytes(){} // RVA: 0x772C4E0
        public void GetAddressBytes(){} // RVA: 0x772C530
        public void get_AddressFamily(){} // RVA: 0x772C6A0
        public void get_ScopeId(){} // RVA: 0x772C6C0
        public void ToString(){} // RVA: 0x772C720
        public void HostToNetworkOrder(){} // RVA: 0x772C820
        public void NetworkToHostOrder(){} // RVA: 0x772C890
        public void IsLoopback(){} // RVA: 0x772C8E0
        public void get_IsIPv6LinkLocal(){} // RVA: 0x772C9C0
        public void get_Address(){} // RVA: 0x772CA00
        public void Equals(){} // RVA: 0x772CBB0
        public void GetHashCode(){} // RVA: 0x772CBC0
        public void MapToIPv6(){} // RVA: 0x772CFA0
        public void ThrowAddressNullException(){} // RVA: 0x772D140
        public void .cctor(){} // RVA: 0x772D190
    }

    public class IPAddressParser : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x772D890
        public void IPv4AddressToString(){} // RVA: 0x772DDA0
        public void IPv4AddressToStringHelper(){} // RVA: 0x772DE10
        public void IPv6AddressToString(){} // RVA: 0x772E030
        public void IPv6AddressToStringHelper(){} // RVA: 0x772E090
        public void FormatIPv4AddressNumber(){} // RVA: 0x772E510
        public void Ipv4StringToAddress(){} // RVA: 0x772E5D0
        public void Ipv6StringToAddress(){} // RVA: 0x772E6A0
        public void AppendSections(){} // RVA: 0x772E7E0
        public void AppendHex(){} // RVA: 0x772E9F0
        public void ExtractIPv4Address(){} // RVA: 0x772EA90
        public void Reverse(){} // RVA: 0x6889510
    }

    public class IPAddress[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IPEndPoint : EndPoint
    {
        public object MinPort;
        public object MaxPort;
        public object _address;
        public object _port;
        public object AnyPort;
        public object Any;
        public object IPv6Any;

        // ── Methods ──
        public void get_AddressFamily(){} // RVA: 0x772EAE0
        public void .ctor(){} // RVA: 0x772EB10
        public void get_Address(){} // RVA: 0xB5DBF0
        public void get_Port(){} // RVA: 0xE62D00
        public void ToString(){} // RVA: 0x772EC20
        public void Serialize(){} // RVA: 0x772EDB0
        public void Create(){} // RVA: 0x772EE50
        public void Equals(){} // RVA: 0x772F140
        public void GetHashCode(){} // RVA: 0x772F1F0
        public void .cctor(){} // RVA: 0x772F230
    }

    public class IPHostEntry : Object
    {
        public object hostName;
        public object aliases;
        public object addressList;
        public object isTrustedHost;

        // ── Methods ──
        public void get_HostName(){} // RVA: 0xB5DBF0
        public void set_HostName(){} // RVA: 0xB44D60
        public void set_Aliases(){} // RVA: 0xBA9BA0
        public void get_AddressList(){} // RVA: 0xB700F0
        public void set_AddressList(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0x1D9AAA0
    }

    public class IWebProxy
    {
        // ── Methods ──
        public void GetProxy(){} // RVA: 0x87C540
        public void IsBypassed(){} // RVA: 0x87D350
        public void get_Credentials(){} // RVA: 0x87C0A0
    }

    public class IWebRequestCreate
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x87C540
    }

    public class InternalException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66DB1B0
    }

}