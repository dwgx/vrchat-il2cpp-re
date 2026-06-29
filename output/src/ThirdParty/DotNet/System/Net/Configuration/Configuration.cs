// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Configuration
// Classes: 35
// Methods: 286

namespace ThirdParty.DotNet.System.Net.Configuration
{
    public class AuthenticationModuleElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7631850
        public void get_Properties(){} // RVA: 0x7631880
        public void get_Type(){} // RVA: 0x76318B0
        public void set_Type(){} // RVA: 0x76318E0
    }

    public class AuthenticationModuleElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7631910
        public void get_Item(){} // RVA: 0x76319A0
        public void set_Item(){} // RVA: 0x76319D0
        public void Add(){} // RVA: 0x7631A00
        public void Clear(){} // RVA: 0x7631A30
        public void CreateNewElement(){} // RVA: 0x7631A60
        public void GetElementKey(){} // RVA: 0x7631A90
        public void IndexOf(){} // RVA: 0x7631AC0
        public void Remove(){} // RVA: 0x7631B20
        public void RemoveAt(){} // RVA: 0x7631B50
    }

    public class AuthenticationModulesSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7631B80
        public void get_AuthenticationModules(){} // RVA: 0x7631BB0
        public void get_Properties(){} // RVA: 0x7631BE0
        public void InitializeDefault(){} // RVA: 0x7631C10
        public void PostDeserialize(){} // RVA: 0x7631C40
    }

    public class BypassElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7631CA0
        public void get_Address(){} // RVA: 0x7631CD0
        public void set_Address(){} // RVA: 0x7631D00
        public void get_Properties(){} // RVA: 0x7631D30
    }

    public class BypassElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7631D60
        public void get_Item(){} // RVA: 0x7631DF0
        public void set_Item(){} // RVA: 0x7631E20
        public void get_ThrowOnDuplicate(){} // RVA: 0x7631E50
        public void Add(){} // RVA: 0x7631E80
        public void Clear(){} // RVA: 0x7631EB0
        public void CreateNewElement(){} // RVA: 0x7631EE0
        public void GetElementKey(){} // RVA: 0x7631F10
        public void IndexOf(){} // RVA: 0x7631F40
        public void Remove(){} // RVA: 0x7631FA0
        public void RemoveAt(){} // RVA: 0x7631FD0
    }

    public class ConnectionManagementElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7632030
        public void get_Address(){} // RVA: 0x7632060
        public void set_Address(){} // RVA: 0x7632090
        public void get_MaxConnection(){} // RVA: 0x76320C0
        public void set_MaxConnection(){} // RVA: 0x76320F0
        public void get_Properties(){} // RVA: 0x7632120
    }

    public class ConnectionManagementElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7632150
        public void get_Item(){} // RVA: 0x76321E0
        public void set_Item(){} // RVA: 0x7632210
        public void Add(){} // RVA: 0x7632240
        public void Clear(){} // RVA: 0x7632270
        public void CreateNewElement(){} // RVA: 0x76322A0
        public void GetElementKey(){} // RVA: 0x76322D0
        public void IndexOf(){} // RVA: 0x7632300
        public void Remove(){} // RVA: 0x7632360
        public void RemoveAt(){} // RVA: 0x7632390
    }

    public class ConnectionManagementSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76323C0
        public void get_ConnectionManagement(){} // RVA: 0x76323F0
        public void get_Properties(){} // RVA: 0x7632420
    }

    public class DefaultProxySection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7632450
        public void get_BypassList(){} // RVA: 0x7632480
        public void get_Enabled(){} // RVA: 0x76324B0
        public void set_Enabled(){} // RVA: 0x76324E0
        public void get_Module(){} // RVA: 0x7632510
        public void get_Properties(){} // RVA: 0x7632540
        public void get_Proxy(){} // RVA: 0x7632570
        public void get_UseDefaultCredentials(){} // RVA: 0x76325A0
        public void set_UseDefaultCredentials(){} // RVA: 0x76325D0
        public void PostDeserialize(){} // RVA: 0x7632600
        public void Reset(){} // RVA: 0x7632630
    }

    public class DefaultProxySectionInternal : Object
    {
        public object webProxy;
        public object classSyncObject;

        // ── Methods ──
        public void GetDefaultProxy_UsingOldMonoCode(){} // RVA: 0x75A6F00
        public void GetSystemWebProxy(){} // RVA: 0x75A6F00
        public void get_ClassSyncObject(){} // RVA: 0x75F7D30
        public void GetSection(){} // RVA: 0x75F7E00
        public void get_WebProxy(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class FtpCachePolicyElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7632960
        public void get_PolicyLevel(){} // RVA: 0x7632990
        public void set_PolicyLevel(){} // RVA: 0x76329C0
        public void get_Properties(){} // RVA: 0x76329F0
        public void DeserializeElement(){} // RVA: 0x7632A20
        public void Reset(){} // RVA: 0x7632A50
    }

    public class HttpCachePolicyElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7632A80
        public void get_MaximumAge(){} // RVA: 0x7632AB0
        public void set_MaximumAge(){} // RVA: 0x7632AE0
        public void get_MaximumStale(){} // RVA: 0x7632B10
        public void set_MaximumStale(){} // RVA: 0x7632B40
        public void get_MinimumFresh(){} // RVA: 0x7632B70
        public void set_MinimumFresh(){} // RVA: 0x7632BA0
        public void get_PolicyLevel(){} // RVA: 0x7632BD0
        public void set_PolicyLevel(){} // RVA: 0x7632C00
        public void get_Properties(){} // RVA: 0x7632C30
        public void DeserializeElement(){} // RVA: 0x7632C60
        public void Reset(){} // RVA: 0x7632C90
    }

    public class HttpListenerElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7632CC0
        public void get_Properties(){} // RVA: 0x7632CF0
        public void get_Timeouts(){} // RVA: 0x7632D20
        public void get_UnescapeRequestUrl(){} // RVA: 0x7632D50
    }

    public class HttpListenerTimeoutsElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7632D80
        public void get_DrainEntityBody(){} // RVA: 0x7632DB0
        public void get_EntityBody(){} // RVA: 0x7632DE0
        public void get_HeaderWait(){} // RVA: 0x7632E10
        public void get_IdleConnection(){} // RVA: 0x7632E40
        public void get_MinSendBytesPerSecond(){} // RVA: 0x7632E70
        public void get_Properties(){} // RVA: 0x7632EA0
        public void get_RequestQueue(){} // RVA: 0x7632ED0
    }

    public class HttpWebRequestElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7632F00
        public void get_MaximumErrorResponseLength(){} // RVA: 0x7632F30
        public void set_MaximumErrorResponseLength(){} // RVA: 0x7632F60
        public void get_MaximumResponseHeadersLength(){} // RVA: 0x7632F90
        public void set_MaximumResponseHeadersLength(){} // RVA: 0x7632FC0
        public void get_MaximumUnauthorizedUploadLength(){} // RVA: 0x7632FF0
        public void set_MaximumUnauthorizedUploadLength(){} // RVA: 0x7633020
        public void get_Properties(){} // RVA: 0x7633050
        public void get_UseUnsafeHeaderParsing(){} // RVA: 0x7633080
        public void set_UseUnsafeHeaderParsing(){} // RVA: 0x76330B0
        public void PostDeserialize(){} // RVA: 0x76330E0
    }

    public class Ipv6Element : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7633110
        public void get_Enabled(){} // RVA: 0x7633140
        public void set_Enabled(){} // RVA: 0x7633170
        public void get_Properties(){} // RVA: 0x76331A0
    }

    public class MailSettingsSectionGroup : ConfigurationSectionGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76331D0
        public void get_Smtp(){} // RVA: 0x7633200
    }

    public class ModuleElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7632660
        public void get_Properties(){} // RVA: 0x7632690
        public void get_Type(){} // RVA: 0x76326C0
        public void set_Type(){} // RVA: 0x76326F0
    }

    public class NetSectionGroup : ConfigurationSectionGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7633860
        public void get_AuthenticationModules(){} // RVA: 0x7633890
        public void get_ConnectionManagement(){} // RVA: 0x76338C0
        public void get_DefaultProxy(){} // RVA: 0x76338F0
        public void get_MailSettings(){} // RVA: 0x7633920
        public void get_RequestCaching(){} // RVA: 0x7633950
        public void get_Settings(){} // RVA: 0x7633980
        public void get_WebRequestModules(){} // RVA: 0x76339B0
        public void GetSectionGroup(){} // RVA: 0x76339E0
    }

    public class PerformanceCountersElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7633EC0
        public void get_Enabled(){} // RVA: 0x7633EF0
        public void set_Enabled(){} // RVA: 0x7633F20
        public void get_Properties(){} // RVA: 0x7633F50
    }

    public class ProxyElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7632720
        public void get_AutoDetect(){} // RVA: 0x7632750
        public void set_AutoDetect(){} // RVA: 0x7632780
        public void get_BypassOnLocal(){} // RVA: 0x76327B0
        public void set_BypassOnLocal(){} // RVA: 0x76327E0
        public void get_Properties(){} // RVA: 0x7632810
        public void get_ProxyAddress(){} // RVA: 0x7632840
        public void set_ProxyAddress(){} // RVA: 0x7632870
        public void get_ScriptLocation(){} // RVA: 0x76328A0
        public void set_ScriptLocation(){} // RVA: 0x76328D0
        public void get_UseSystemDefault(){} // RVA: 0x7632900
        public void set_UseSystemDefault(){} // RVA: 0x7632930
    }

    public class RequestCachingSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7633A10
        public void get_DefaultFtpCachePolicy(){} // RVA: 0x7633A40
        public void get_DefaultHttpCachePolicy(){} // RVA: 0x7633A70
        public void get_DefaultPolicyLevel(){} // RVA: 0x7633AA0
        public void set_DefaultPolicyLevel(){} // RVA: 0x7633AD0
        public void get_DisableAllCaching(){} // RVA: 0x7633B00
        public void set_DisableAllCaching(){} // RVA: 0x7633B30
        public void get_IsPrivateCache(){} // RVA: 0x7633B60
        public void set_IsPrivateCache(){} // RVA: 0x7633B90
        public void get_Properties(){} // RVA: 0x7633BC0
        public void get_UnspecifiedMaximumAge(){} // RVA: 0x7633BF0
        public void set_UnspecifiedMaximumAge(){} // RVA: 0x7633C20
        public void DeserializeElement(){} // RVA: 0x7633C50
        public void PostDeserialize(){} // RVA: 0x7633C80
    }

    public class ServicePointManagerElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7633F80
        public void get_CheckCertificateName(){} // RVA: 0x7633FB0
        public void set_CheckCertificateName(){} // RVA: 0x7633FE0
        public void get_CheckCertificateRevocationList(){} // RVA: 0x7634010
        public void set_CheckCertificateRevocationList(){} // RVA: 0x7634040
        public void get_DnsRefreshTimeout(){} // RVA: 0x7634070
        public void set_DnsRefreshTimeout(){} // RVA: 0x76340A0
        public void get_EnableDnsRoundRobin(){} // RVA: 0x76340D0
        public void set_EnableDnsRoundRobin(){} // RVA: 0x7634100
        public void get_EncryptionPolicy(){} // RVA: 0x7634130
        public void set_EncryptionPolicy(){} // RVA: 0x7634160
        public void get_Expect100Continue(){} // RVA: 0x7634190
        public void set_Expect100Continue(){} // RVA: 0x76341C0
        public void get_Properties(){} // RVA: 0x76341F0
        public void get_UseNagleAlgorithm(){} // RVA: 0x7634220
        public void set_UseNagleAlgorithm(){} // RVA: 0x7634250
        public void PostDeserialize(){} // RVA: 0x7634280
    }

    public class SettingsSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7633CB0
        public void get_HttpListener(){} // RVA: 0x7633CE0
        public void get_HttpWebRequest(){} // RVA: 0x7633D10
        public void get_Ipv6(){} // RVA: 0x7633D40
        public void get_PerformanceCounters(){} // RVA: 0x7633D70
        public void get_Properties(){} // RVA: 0x7633DA0
        public void get_ServicePointManager(){} // RVA: 0x7633DD0
        public void get_Socket(){} // RVA: 0x7633E00
        public void get_WebProxyScript(){} // RVA: 0x7633E30
        public void get_WebUtility(){} // RVA: 0x7633E60
        public void get_WindowsAuthentication(){} // RVA: 0x7633E90
    }

    public class SettingsSectionInternal : Object
    {
        public object instance;
        public object HttpListenerUnescapeRequestUrl;
        public object IPProtectionLevel;
        public object _useNagleAlgorithm;
        public object _expect100Continue;
        public object _checkCertificateName;
        public object _dnsRefreshTimeout;
        public object _enableDnsRoundRobin;
        public object _checkCertificateRevocationList;
        public object _encryptionPolicy;

        // ── Methods ──
        public void get_Section(){} // RVA: 0x75F80B0
        public void get_UseNagleAlgorithm(){} // RVA: 0xB5DD50
        public void set_UseNagleAlgorithm(){} // RVA: 0xB5DD60
        public void get_Expect100Continue(){} // RVA: 0xF43F30
        public void set_Expect100Continue(){} // RVA: 0x17F4D80
        public void get_CheckCertificateName(){} // RVA: 0x246FA20
        public void set_CheckCertificateName(){} // RVA: 0x246E8E0
        public void get_DnsRefreshTimeout(){} // RVA: 0x2244FB0
        public void set_DnsRefreshTimeout(){} // RVA: 0x22735B0
        public void get_EnableDnsRoundRobin(){} // RVA: 0xC38360
        public void set_EnableDnsRoundRobin(){} // RVA: 0xC38370
        public void get_CheckCertificateRevocationList(){} // RVA: 0xF45EE0
        public void set_CheckCertificateRevocationList(){} // RVA: 0x1AD91E0
        public void get_EncryptionPolicy(){} // RVA: 0x15AF000
        public void set_EncryptionPolicy(){} // RVA: 0x1FAA840
        public void get_Ipv6Enabled(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0x75F8110
        public void .cctor(){} // RVA: 0x75F8120
    }

    public class SmtpNetworkElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7633410
        public void get_ClientDomain(){} // RVA: 0x7633440
        public void set_ClientDomain(){} // RVA: 0x7633470
        public void get_DefaultCredentials(){} // RVA: 0x76334A0
        public void set_DefaultCredentials(){} // RVA: 0x76334D0
        public void get_EnableSsl(){} // RVA: 0x7633500
        public void set_EnableSsl(){} // RVA: 0x7633530
        public void get_Host(){} // RVA: 0x7633560
        public void set_Host(){} // RVA: 0x7633590
        public void get_Password(){} // RVA: 0x76335C0
        public void set_Password(){} // RVA: 0x76335F0
        public void get_Port(){} // RVA: 0x7633620
        public void set_Port(){} // RVA: 0x7633650
        public void get_Properties(){} // RVA: 0x7633680
        public void get_TargetName(){} // RVA: 0x76336B0
        public void set_TargetName(){} // RVA: 0x76336E0
        public void get_UserName(){} // RVA: 0x7633710
        public void set_UserName(){} // RVA: 0x7633740
        public void PostDeserialize(){} // RVA: 0x7633770
    }

    public class SmtpSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7633230
        public void get_DeliveryFormat(){} // RVA: 0x7633260
        public void set_DeliveryFormat(){} // RVA: 0x7633290
        public void get_DeliveryMethod(){} // RVA: 0x76332C0
        public void set_DeliveryMethod(){} // RVA: 0x76332F0
        public void get_From(){} // RVA: 0x7633320
        public void set_From(){} // RVA: 0x7633350
        public void get_Network(){} // RVA: 0x7633380
        public void get_Properties(){} // RVA: 0x76333B0
        public void get_SpecifiedPickupDirectory(){} // RVA: 0x76333E0
    }

    public class SmtpSpecifiedPickupDirectoryElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76337A0
        public void get_PickupDirectoryLocation(){} // RVA: 0x76337D0
        public void set_PickupDirectoryLocation(){} // RVA: 0x7633800
        public void get_Properties(){} // RVA: 0x7633830
    }

    public class SocketElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76342B0
        public void get_AlwaysUseCompletionPortsForAccept(){} // RVA: 0x76342E0
        public void set_AlwaysUseCompletionPortsForAccept(){} // RVA: 0x7634310
        public void get_AlwaysUseCompletionPortsForConnect(){} // RVA: 0x7634340
        public void set_AlwaysUseCompletionPortsForConnect(){} // RVA: 0x7634370
        public void get_IPProtectionLevel(){} // RVA: 0x76343A0
        public void set_IPProtectionLevel(){} // RVA: 0x76343D0
        public void get_Properties(){} // RVA: 0x7634400
        public void PostDeserialize(){} // RVA: 0x7634430
    }

    public class WebProxyScriptElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7634460
        public void get_AutoConfigUrlRetryInterval(){} // RVA: 0x7634490
        public void set_AutoConfigUrlRetryInterval(){} // RVA: 0x76344C0
        public void get_DownloadTimeout(){} // RVA: 0x76344F0
        public void set_DownloadTimeout(){} // RVA: 0x7634520
        public void get_Properties(){} // RVA: 0x7634550
        public void PostDeserialize(){} // RVA: 0x7634580
    }

    public class WebRequestModuleElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7634B50
        public void get_Prefix(){} // RVA: 0x7634B80
        public void set_Prefix(){} // RVA: 0x7634BB0
        public void get_Properties(){} // RVA: 0x7634BE0
        public void get_Type(){} // RVA: 0x7634C10
        public void set_Type(){} // RVA: 0x7634C40
    }

    public class WebRequestModuleElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7634880
        public void get_Item(){} // RVA: 0x7634910
        public void set_Item(){} // RVA: 0x7634940
        public void Add(){} // RVA: 0x7634970
        public void Clear(){} // RVA: 0x76349A0
        public void CreateNewElement(){} // RVA: 0x76349D0
        public void GetElementKey(){} // RVA: 0x7634A00
        public void IndexOf(){} // RVA: 0x7634A30
        public void Remove(){} // RVA: 0x7634A90
        public void RemoveAt(){} // RVA: 0x7634AC0
    }

    public class WebRequestModulesSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7634790
        public void get_Properties(){} // RVA: 0x76347C0
        public void get_WebRequestModules(){} // RVA: 0x76347F0
        public void InitializeDefault(){} // RVA: 0x7634820
        public void PostDeserialize(){} // RVA: 0x7634850
    }

    public class WebUtilityElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76345B0
        public void get_Properties(){} // RVA: 0x76345E0
        public void get_UnicodeDecodingConformance(){} // RVA: 0x7634610
        public void set_UnicodeDecodingConformance(){} // RVA: 0x7634640
        public void get_UnicodeEncodingConformance(){} // RVA: 0x7634670
        public void set_UnicodeEncodingConformance(){} // RVA: 0x76346A0
    }

    public class WindowsAuthenticationElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76346D0
        public void get_DefaultCredentialsHandleCacheSize(){} // RVA: 0x7634700
        public void set_DefaultCredentialsHandleCacheSize(){} // RVA: 0x7634730
        public void get_Properties(){} // RVA: 0x7634760
    }

}