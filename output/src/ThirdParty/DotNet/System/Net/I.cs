// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 12
// Methods: 80

namespace ThirdParty.DotNet.System.Net
{
    public class IAuthenticationModule
    {
        // ── Methods ──
        public void Authenticate(){} // RVA: 0x7A7E06710
        public void PreAuthenticate(){} // RVA: 0x7A7E00BD0
        public void get_AuthenticationType(){} // RVA: 0x7A7E00680
    }

    public class ICertificatePolicy
    {
        // ── Methods ──
        public void CheckValidationResult(){} // RVA: 0x7A7E05250
    }

    public class ICloseEx
    {
        // ── Methods ──
        public void CloseEx(){} // RVA: 0x7A7E189D0
    }

    public class ICredentials
    {
        // ── Methods ──
        public void GetCredential(){} // RVA: 0x7A7E00BD0
    }

    public class IPAddress : Object
    {
        // ── Methods ──
        public void get_IsIPv4(){} // RVA: 0x7AACC9BD0
        public void get_IsIPv6(){} // RVA: 0x7A9B3D890
        public void get_PrivateAddress(){} // RVA: 0x7A8124910
        public void set_PrivateAddress(){} // RVA: 0x7AEABC140
        public void get_PrivateScopeId(){} // RVA: 0x7A8124910
        public void set_PrivateScopeId(){} // RVA: 0x7AEABC140
        public void .ctor(){} // RVA: 0x7AEABC7B0
        public void TryParse(){} // RVA: 0x7AEABC9A0
        public void Parse(){} // RVA: 0x7AEABCAE0
        public void TryWriteBytes(){} // RVA: 0x7AEABCB90
        public void WriteIPv6Bytes(){} // RVA: 0x7AEABCC90
        public void WriteIPv4Bytes(){} // RVA: 0x7AEABCD40
        public void GetAddressBytes(){} // RVA: 0x7AEABCD90
        public void get_AddressFamily(){} // RVA: 0x7AEABCF00
        public void get_ScopeId(){} // RVA: 0x7AEABCF20
        public void ToString(){} // RVA: 0x7AEABCF80
        public void HostToNetworkOrder(){} // RVA: 0x7AEABD080
        public void NetworkToHostOrder(){} // RVA: 0x7AEABD0F0
        public void IsLoopback(){} // RVA: 0x7AEABD140
        public void get_IsIPv6LinkLocal(){} // RVA: 0x7AEABD220
        public void get_Address(){} // RVA: 0x7AEABD260
        public void Equals(){} // RVA: 0x7AEABD410
        public void GetHashCode(){} // RVA: 0x7AEABD420
        public void MapToIPv6(){} // RVA: 0x7AEABD800
        public void ThrowAddressNullException(){} // RVA: 0x7AEABD9A0
        public void .cctor(){} // RVA: 0x7AEABD9F0
    }

    public class IPAddressParser : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7AEABE0F0
        public void IPv4AddressToString(){} // RVA: 0x7AEABE600
        public void IPv4AddressToStringHelper(){} // RVA: 0x7AEABE670
        public void IPv6AddressToString(){} // RVA: 0x7AEABE890
        public void IPv6AddressToStringHelper(){} // RVA: 0x7AEABE8F0
        public void FormatIPv4AddressNumber(){} // RVA: 0x7AEABED70
        public void Ipv4StringToAddress(){} // RVA: 0x7AEABEE30
        public void Ipv6StringToAddress(){} // RVA: 0x7AEABEF00
        public void AppendSections(){} // RVA: 0x7AEABF040
        public void AppendHex(){} // RVA: 0x7AEABF250
        public void ExtractIPv4Address(){} // RVA: 0x7AEABF2F0
        public void Reverse(){} // RVA: 0x7ADBFE2C0
    }

    public class IPAddress[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IPEndPoint : EndPoint
    {
        // ── Methods ──
        public void get_AddressFamily(){} // RVA: 0x7AEABF340
        public void .ctor(){} // RVA: 0x7AEABF370
        public void get_Address(){} // RVA: 0x7A80F2570
        public void get_Port(){} // RVA: 0x7A83782A0
        public void ToString(){} // RVA: 0x7AEABF480
        public void Serialize(){} // RVA: 0x7AEABF610
        public void Create(){} // RVA: 0x7AEABF6B0
        public void Equals(){} // RVA: 0x7AEABF9A0
        public void GetHashCode(){} // RVA: 0x7AEABFA50
        public void .cctor(){} // RVA: 0x7AEABFA90
    }

    public class IPHostEntry : Object
    {
        // ── Methods ──
        public void get_HostName(){} // RVA: 0x7A80F2570
        public void set_HostName(){} // RVA: 0x7A80D8E20
        public void set_Aliases(){} // RVA: 0x7A813E420
        public void get_AddressList(){} // RVA: 0x7A81052C0
        public void set_AddressList(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7A92FD360
    }

    public class IWebProxy
    {
        // ── Methods ──
        public void GetProxy(){} // RVA: 0x7A7E00B20
        public void IsBypassed(){} // RVA: 0x7A7E019D0
        public void get_Credentials(){} // RVA: 0x7A7E00680
    }

    public class IWebRequestCreate
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7A7E00B20
    }

    public class InternalException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA50A20
    }

}