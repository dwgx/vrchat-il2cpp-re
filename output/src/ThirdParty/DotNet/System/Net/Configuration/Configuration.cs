// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Configuration
// Classes: 35
// Methods: 286

namespace ThirdParty.DotNet.System.Net.Configuration
{
    public class AuthenticationModuleElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BF750
        public void get_Properties(){} // RVA: 0x7AE9BF780
        public void get_Type(){} // RVA: 0x7AE9BF7B0
        public void set_Type(){} // RVA: 0x7AE9BF7E0
    }

    public class AuthenticationModuleElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BF810
        public void get_Item(){} // RVA: 0x7AE9BF8A0
        public void set_Item(){} // RVA: 0x7AE9BF8D0
        public void Add(){} // RVA: 0x7AE9BF900
        public void Clear(){} // RVA: 0x7AE9BF930
        public void CreateNewElement(){} // RVA: 0x7AE9BF960
        public void GetElementKey(){} // RVA: 0x7AE9BF990
        public void IndexOf(){} // RVA: 0x7AE9BF9C0
        public void Remove(){} // RVA: 0x7AE9BFA20
        public void RemoveAt(){} // RVA: 0x7AE9BFA50
    }

    public class AuthenticationModulesSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BFA80
        public void get_AuthenticationModules(){} // RVA: 0x7AE9BFAB0
        public void get_Properties(){} // RVA: 0x7AE9BFAE0
        public void InitializeDefault(){} // RVA: 0x7AE9BFB10
        public void PostDeserialize(){} // RVA: 0x7AE9BFB40
    }

    public class BypassElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BFBA0
        public void get_Address(){} // RVA: 0x7AE9BFBD0
        public void set_Address(){} // RVA: 0x7AE9BFC00
        public void get_Properties(){} // RVA: 0x7AE9BFC30
    }

    public class BypassElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BFC60
        public void get_Item(){} // RVA: 0x7AE9BFCF0
        public void set_Item(){} // RVA: 0x7AE9BFD20
        public void get_ThrowOnDuplicate(){} // RVA: 0x7AE9BFD50
        public void Add(){} // RVA: 0x7AE9BFD80
        public void Clear(){} // RVA: 0x7AE9BFDB0
        public void CreateNewElement(){} // RVA: 0x7AE9BFDE0
        public void GetElementKey(){} // RVA: 0x7AE9BFE10
        public void IndexOf(){} // RVA: 0x7AE9BFE40
        public void Remove(){} // RVA: 0x7AE9BFEA0
        public void RemoveAt(){} // RVA: 0x7AE9BFED0
    }

    public class ConnectionManagementElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BFF30
        public void get_Address(){} // RVA: 0x7AE9BFF60
        public void set_Address(){} // RVA: 0x7AE9BFF90
        public void get_MaxConnection(){} // RVA: 0x7AE9BFFC0
        public void set_MaxConnection(){} // RVA: 0x7AE9BFFF0
        public void get_Properties(){} // RVA: 0x7AE9C0020
    }

    public class ConnectionManagementElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C0050
        public void get_Item(){} // RVA: 0x7AE9C00E0
        public void set_Item(){} // RVA: 0x7AE9C0110
        public void Add(){} // RVA: 0x7AE9C0140
        public void Clear(){} // RVA: 0x7AE9C0170
        public void CreateNewElement(){} // RVA: 0x7AE9C01A0
        public void GetElementKey(){} // RVA: 0x7AE9C01D0
        public void IndexOf(){} // RVA: 0x7AE9C0200
        public void Remove(){} // RVA: 0x7AE9C0260
        public void RemoveAt(){} // RVA: 0x7AE9C0290
    }

    public class ConnectionManagementSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C02C0
        public void get_ConnectionManagement(){} // RVA: 0x7AE9C02F0
        public void get_Properties(){} // RVA: 0x7AE9C0320
    }

    public class DefaultProxySection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C0350
        public void get_BypassList(){} // RVA: 0x7AE9C0380
        public void get_Enabled(){} // RVA: 0x7AE9C03B0
        public void set_Enabled(){} // RVA: 0x7AE9C03E0
        public void get_Module(){} // RVA: 0x7AE9C0410
        public void get_Properties(){} // RVA: 0x7AE9C0440
        public void get_Proxy(){} // RVA: 0x7AE9C0470
        public void get_UseDefaultCredentials(){} // RVA: 0x7AE9C04A0
        public void set_UseDefaultCredentials(){} // RVA: 0x7AE9C04D0
        public void PostDeserialize(){} // RVA: 0x7AE9C0500
        public void Reset(){} // RVA: 0x7AE9C0530
    }

    public class DefaultProxySectionInternal : Object
    {
        // ── Methods ──
        public void GetDefaultProxy_UsingOldMonoCode(){} // RVA: 0x7AE933DC0
        public void GetSystemWebProxy(){} // RVA: 0x7AE933DC0
        public void get_ClassSyncObject(){} // RVA: 0x7AE985190
        public void GetSection(){} // RVA: 0x7AE985260
        public void get_WebProxy(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class FtpCachePolicyElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C0860
        public void get_PolicyLevel(){} // RVA: 0x7AE9C0890
        public void set_PolicyLevel(){} // RVA: 0x7AE9C08C0
        public void get_Properties(){} // RVA: 0x7AE9C08F0
        public void DeserializeElement(){} // RVA: 0x7AE9C0920
        public void Reset(){} // RVA: 0x7AE9C0950
    }

    public class HttpCachePolicyElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C0980
        public void get_MaximumAge(){} // RVA: 0x7AE9C09B0
        public void set_MaximumAge(){} // RVA: 0x7AE9C09E0
        public void get_MaximumStale(){} // RVA: 0x7AE9C0A10
        public void set_MaximumStale(){} // RVA: 0x7AE9C0A40
        public void get_MinimumFresh(){} // RVA: 0x7AE9C0A70
        public void set_MinimumFresh(){} // RVA: 0x7AE9C0AA0
        public void get_PolicyLevel(){} // RVA: 0x7AE9C0AD0
        public void set_PolicyLevel(){} // RVA: 0x7AE9C0B00
        public void get_Properties(){} // RVA: 0x7AE9C0B30
        public void DeserializeElement(){} // RVA: 0x7AE9C0B60
        public void Reset(){} // RVA: 0x7AE9C0B90
    }

    public class HttpListenerElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C0BC0
        public void get_Properties(){} // RVA: 0x7AE9C0BF0
        public void get_Timeouts(){} // RVA: 0x7AE9C0C20
        public void get_UnescapeRequestUrl(){} // RVA: 0x7AE9C0C50
    }

    public class HttpListenerTimeoutsElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C0C80
        public void get_DrainEntityBody(){} // RVA: 0x7AE9C0CB0
        public void get_EntityBody(){} // RVA: 0x7AE9C0CE0
        public void get_HeaderWait(){} // RVA: 0x7AE9C0D10
        public void get_IdleConnection(){} // RVA: 0x7AE9C0D40
        public void get_MinSendBytesPerSecond(){} // RVA: 0x7AE9C0D70
        public void get_Properties(){} // RVA: 0x7AE9C0DA0
        public void get_RequestQueue(){} // RVA: 0x7AE9C0DD0
    }

    public class HttpWebRequestElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C0E00
        public void get_MaximumErrorResponseLength(){} // RVA: 0x7AE9C0E30
        public void set_MaximumErrorResponseLength(){} // RVA: 0x7AE9C0E60
        public void get_MaximumResponseHeadersLength(){} // RVA: 0x7AE9C0E90
        public void set_MaximumResponseHeadersLength(){} // RVA: 0x7AE9C0EC0
        public void get_MaximumUnauthorizedUploadLength(){} // RVA: 0x7AE9C0EF0
        public void set_MaximumUnauthorizedUploadLength(){} // RVA: 0x7AE9C0F20
        public void get_Properties(){} // RVA: 0x7AE9C0F50
        public void get_UseUnsafeHeaderParsing(){} // RVA: 0x7AE9C0F80
        public void set_UseUnsafeHeaderParsing(){} // RVA: 0x7AE9C0FB0
        public void PostDeserialize(){} // RVA: 0x7AE9C0FE0
    }

    public class Ipv6Element : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C1010
        public void get_Enabled(){} // RVA: 0x7AE9C1040
        public void set_Enabled(){} // RVA: 0x7AE9C1070
        public void get_Properties(){} // RVA: 0x7AE9C10A0
    }

    public class MailSettingsSectionGroup : ConfigurationSectionGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C10D0
        public void get_Smtp(){} // RVA: 0x7AE9C1100
    }

    public class ModuleElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C0560
        public void get_Properties(){} // RVA: 0x7AE9C0590
        public void get_Type(){} // RVA: 0x7AE9C05C0
        public void set_Type(){} // RVA: 0x7AE9C05F0
    }

    public class NetSectionGroup : ConfigurationSectionGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C1760
        public void get_AuthenticationModules(){} // RVA: 0x7AE9C1790
        public void get_ConnectionManagement(){} // RVA: 0x7AE9C17C0
        public void get_DefaultProxy(){} // RVA: 0x7AE9C17F0
        public void get_MailSettings(){} // RVA: 0x7AE9C1820
        public void get_RequestCaching(){} // RVA: 0x7AE9C1850
        public void get_Settings(){} // RVA: 0x7AE9C1880
        public void get_WebRequestModules(){} // RVA: 0x7AE9C18B0
        public void GetSectionGroup(){} // RVA: 0x7AE9C18E0
    }

    public class PerformanceCountersElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C1DC0
        public void get_Enabled(){} // RVA: 0x7AE9C1DF0
        public void set_Enabled(){} // RVA: 0x7AE9C1E20
        public void get_Properties(){} // RVA: 0x7AE9C1E50
    }

    public class ProxyElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C0620
        public void get_AutoDetect(){} // RVA: 0x7AE9C0650
        public void set_AutoDetect(){} // RVA: 0x7AE9C0680
        public void get_BypassOnLocal(){} // RVA: 0x7AE9C06B0
        public void set_BypassOnLocal(){} // RVA: 0x7AE9C06E0
        public void get_Properties(){} // RVA: 0x7AE9C0710
        public void get_ProxyAddress(){} // RVA: 0x7AE9C0740
        public void set_ProxyAddress(){} // RVA: 0x7AE9C0770
        public void get_ScriptLocation(){} // RVA: 0x7AE9C07A0
        public void set_ScriptLocation(){} // RVA: 0x7AE9C07D0
        public void get_UseSystemDefault(){} // RVA: 0x7AE9C0800
        public void set_UseSystemDefault(){} // RVA: 0x7AE9C0830
    }

    public class RequestCachingSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C1910
        public void get_DefaultFtpCachePolicy(){} // RVA: 0x7AE9C1940
        public void get_DefaultHttpCachePolicy(){} // RVA: 0x7AE9C1970
        public void get_DefaultPolicyLevel(){} // RVA: 0x7AE9C19A0
        public void set_DefaultPolicyLevel(){} // RVA: 0x7AE9C19D0
        public void get_DisableAllCaching(){} // RVA: 0x7AE9C1A00
        public void set_DisableAllCaching(){} // RVA: 0x7AE9C1A30
        public void get_IsPrivateCache(){} // RVA: 0x7AE9C1A60
        public void set_IsPrivateCache(){} // RVA: 0x7AE9C1A90
        public void get_Properties(){} // RVA: 0x7AE9C1AC0
        public void get_UnspecifiedMaximumAge(){} // RVA: 0x7AE9C1AF0
        public void set_UnspecifiedMaximumAge(){} // RVA: 0x7AE9C1B20
        public void DeserializeElement(){} // RVA: 0x7AE9C1B50
        public void PostDeserialize(){} // RVA: 0x7AE9C1B80
    }

    public class ServicePointManagerElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C1E80
        public void get_CheckCertificateName(){} // RVA: 0x7AE9C1EB0
        public void set_CheckCertificateName(){} // RVA: 0x7AE9C1EE0
        public void get_CheckCertificateRevocationList(){} // RVA: 0x7AE9C1F10
        public void set_CheckCertificateRevocationList(){} // RVA: 0x7AE9C1F40
        public void get_DnsRefreshTimeout(){} // RVA: 0x7AE9C1F70
        public void set_DnsRefreshTimeout(){} // RVA: 0x7AE9C1FA0
        public void get_EnableDnsRoundRobin(){} // RVA: 0x7AE9C1FD0
        public void set_EnableDnsRoundRobin(){} // RVA: 0x7AE9C2000
        public void get_EncryptionPolicy(){} // RVA: 0x7AE9C2030
        public void set_EncryptionPolicy(){} // RVA: 0x7AE9C2060
        public void get_Expect100Continue(){} // RVA: 0x7AE9C2090
        public void set_Expect100Continue(){} // RVA: 0x7AE9C20C0
        public void get_Properties(){} // RVA: 0x7AE9C20F0
        public void get_UseNagleAlgorithm(){} // RVA: 0x7AE9C2120
        public void set_UseNagleAlgorithm(){} // RVA: 0x7AE9C2150
        public void PostDeserialize(){} // RVA: 0x7AE9C2180
    }

    public class SettingsSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C1BB0
        public void get_HttpListener(){} // RVA: 0x7AE9C1BE0
        public void get_HttpWebRequest(){} // RVA: 0x7AE9C1C10
        public void get_Ipv6(){} // RVA: 0x7AE9C1C40
        public void get_PerformanceCounters(){} // RVA: 0x7AE9C1C70
        public void get_Properties(){} // RVA: 0x7AE9C1CA0
        public void get_ServicePointManager(){} // RVA: 0x7AE9C1CD0
        public void get_Socket(){} // RVA: 0x7AE9C1D00
        public void get_WebProxyScript(){} // RVA: 0x7AE9C1D30
        public void get_WebUtility(){} // RVA: 0x7AE9C1D60
        public void get_WindowsAuthentication(){} // RVA: 0x7AE9C1D90
    }

    public class SettingsSectionInternal : Object
    {
        // ── Methods ──
        public void get_Section(){} // RVA: 0x7AE985510
        public void get_UseNagleAlgorithm(){} // RVA: 0x7A80F26D0
        public void set_UseNagleAlgorithm(){} // RVA: 0x7A80F26E0
        public void get_Expect100Continue(){} // RVA: 0x7A8475E20
        public void set_Expect100Continue(){} // RVA: 0x7A8D0E640
        public void get_CheckCertificateName(){} // RVA: 0x7A9956320
        public void set_CheckCertificateName(){} // RVA: 0x7A99561F0
        public void get_DnsRefreshTimeout(){} // RVA: 0x7A9739200
        public void set_DnsRefreshTimeout(){} // RVA: 0x7A9746990
        public void get_EnableDnsRoundRobin(){} // RVA: 0x7A81C68D0
        public void set_EnableDnsRoundRobin(){} // RVA: 0x7A81C68E0
        public void get_CheckCertificateRevocationList(){} // RVA: 0x7A8477E00
        public void set_CheckCertificateRevocationList(){} // RVA: 0x7A88C2D40
        public void get_EncryptionPolicy(){} // RVA: 0x7A8AB15F0
        public void set_EncryptionPolicy(){} // RVA: 0x7A94794D0
        public void get_Ipv6Enabled(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7AE985570
        public void .cctor(){} // RVA: 0x7AE985580
    }

    public class SmtpNetworkElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C1310
        public void get_ClientDomain(){} // RVA: 0x7AE9C1340
        public void set_ClientDomain(){} // RVA: 0x7AE9C1370
        public void get_DefaultCredentials(){} // RVA: 0x7AE9C13A0
        public void set_DefaultCredentials(){} // RVA: 0x7AE9C13D0
        public void get_EnableSsl(){} // RVA: 0x7AE9C1400
        public void set_EnableSsl(){} // RVA: 0x7AE9C1430
        public void get_Host(){} // RVA: 0x7AE9C1460
        public void set_Host(){} // RVA: 0x7AE9C1490
        public void get_Password(){} // RVA: 0x7AE9C14C0
        public void set_Password(){} // RVA: 0x7AE9C14F0
        public void get_Port(){} // RVA: 0x7AE9C1520
        public void set_Port(){} // RVA: 0x7AE9C1550
        public void get_Properties(){} // RVA: 0x7AE9C1580
        public void get_TargetName(){} // RVA: 0x7AE9C15B0
        public void set_TargetName(){} // RVA: 0x7AE9C15E0
        public void get_UserName(){} // RVA: 0x7AE9C1610
        public void set_UserName(){} // RVA: 0x7AE9C1640
        public void PostDeserialize(){} // RVA: 0x7AE9C1670
    }

    public class SmtpSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C1130
        public void get_DeliveryFormat(){} // RVA: 0x7AE9C1160
        public void set_DeliveryFormat(){} // RVA: 0x7AE9C1190
        public void get_DeliveryMethod(){} // RVA: 0x7AE9C11C0
        public void set_DeliveryMethod(){} // RVA: 0x7AE9C11F0
        public void get_From(){} // RVA: 0x7AE9C1220
        public void set_From(){} // RVA: 0x7AE9C1250
        public void get_Network(){} // RVA: 0x7AE9C1280
        public void get_Properties(){} // RVA: 0x7AE9C12B0
        public void get_SpecifiedPickupDirectory(){} // RVA: 0x7AE9C12E0
    }

    public class SmtpSpecifiedPickupDirectoryElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C16A0
        public void get_PickupDirectoryLocation(){} // RVA: 0x7AE9C16D0
        public void set_PickupDirectoryLocation(){} // RVA: 0x7AE9C1700
        public void get_Properties(){} // RVA: 0x7AE9C1730
    }

    public class SocketElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C21B0
        public void get_AlwaysUseCompletionPortsForAccept(){} // RVA: 0x7AE9C21E0
        public void set_AlwaysUseCompletionPortsForAccept(){} // RVA: 0x7AE9C2210
        public void get_AlwaysUseCompletionPortsForConnect(){} // RVA: 0x7AE9C2240
        public void set_AlwaysUseCompletionPortsForConnect(){} // RVA: 0x7AE9C2270
        public void get_IPProtectionLevel(){} // RVA: 0x7AE9C22A0
        public void set_IPProtectionLevel(){} // RVA: 0x7AE9C22D0
        public void get_Properties(){} // RVA: 0x7AE9C2300
        public void PostDeserialize(){} // RVA: 0x7AE9C2330
    }

    public class WebProxyScriptElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C2360
        public void get_AutoConfigUrlRetryInterval(){} // RVA: 0x7AE9C2390
        public void set_AutoConfigUrlRetryInterval(){} // RVA: 0x7AE9C23C0
        public void get_DownloadTimeout(){} // RVA: 0x7AE9C23F0
        public void set_DownloadTimeout(){} // RVA: 0x7AE9C2420
        public void get_Properties(){} // RVA: 0x7AE9C2450
        public void PostDeserialize(){} // RVA: 0x7AE9C2480
    }

    public class WebRequestModuleElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C2A50
        public void get_Prefix(){} // RVA: 0x7AE9C2A80
        public void set_Prefix(){} // RVA: 0x7AE9C2AB0
        public void get_Properties(){} // RVA: 0x7AE9C2AE0
        public void get_Type(){} // RVA: 0x7AE9C2B10
        public void set_Type(){} // RVA: 0x7AE9C2B40
    }

    public class WebRequestModuleElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C2780
        public void get_Item(){} // RVA: 0x7AE9C2810
        public void set_Item(){} // RVA: 0x7AE9C2840
        public void Add(){} // RVA: 0x7AE9C2870
        public void Clear(){} // RVA: 0x7AE9C28A0
        public void CreateNewElement(){} // RVA: 0x7AE9C28D0
        public void GetElementKey(){} // RVA: 0x7AE9C2900
        public void IndexOf(){} // RVA: 0x7AE9C2930
        public void Remove(){} // RVA: 0x7AE9C2990
        public void RemoveAt(){} // RVA: 0x7AE9C29C0
    }

    public class WebRequestModulesSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C2690
        public void get_Properties(){} // RVA: 0x7AE9C26C0
        public void get_WebRequestModules(){} // RVA: 0x7AE9C26F0
        public void InitializeDefault(){} // RVA: 0x7AE9C2720
        public void PostDeserialize(){} // RVA: 0x7AE9C2750
    }

    public class WebUtilityElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C24B0
        public void get_Properties(){} // RVA: 0x7AE9C24E0
        public void get_UnicodeDecodingConformance(){} // RVA: 0x7AE9C2510
        public void set_UnicodeDecodingConformance(){} // RVA: 0x7AE9C2540
        public void get_UnicodeEncodingConformance(){} // RVA: 0x7AE9C2570
        public void set_UnicodeEncodingConformance(){} // RVA: 0x7AE9C25A0
    }

    public class WindowsAuthenticationElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C25D0
        public void get_DefaultCredentialsHandleCacheSize(){} // RVA: 0x7AE9C2600
        public void set_DefaultCredentialsHandleCacheSize(){} // RVA: 0x7AE9C2630
        public void get_Properties(){} // RVA: 0x7AE9C2660
    }

}