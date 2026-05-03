// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Configuration
// Classes: 35
// Methods: 303

namespace ThirdParty.DotNet.System.Net.Configuration
{
    public class AuthenticationModuleElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87711700 | overloaded x2
        public void get_Properties(){} // RVA: 0x7FFE87711730
        public void get_Type(){} // RVA: 0x7FFE87711760
        public void set_Type(){} // RVA: 0x7FFE87711790
    }

    public class AuthenticationModuleElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877117C0
        public void get_Item(){} // RVA: 0x7FFE87711850 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFE87711880 | overloaded x2
        public void Add(){} // RVA: 0x7FFE877118B0
        public void Clear(){} // RVA: 0x7FFE877118E0
        public void CreateNewElement(){} // RVA: 0x7FFE87711910
        public void GetElementKey(){} // RVA: 0x7FFE87711940
        public void IndexOf(){} // RVA: 0x7FFE87711970
        public void Remove(){} // RVA: 0x7FFE877119D0 | overloaded x2
        public void RemoveAt(){} // RVA: 0x7FFE87711A00
    }

    public class AuthenticationModulesSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87711A30
        public void get_AuthenticationModules(){} // RVA: 0x7FFE87711A60
        public void get_Properties(){} // RVA: 0x7FFE87711A90
        public void InitializeDefault(){} // RVA: 0x7FFE87711AC0
        public void PostDeserialize(){} // RVA: 0x7FFE87711AF0
    }

    public class BypassElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87711B50 | overloaded x2
        public void get_Address(){} // RVA: 0x7FFE87711B80
        public void set_Address(){} // RVA: 0x7FFE87711BB0
        public void get_Properties(){} // RVA: 0x7FFE87711BE0
    }

    public class BypassElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87711C10
        public void get_Item(){} // RVA: 0x7FFE87711CA0 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFE87711CD0 | overloaded x2
        public void get_ThrowOnDuplicate(){} // RVA: 0x7FFE87711D00
        public void Add(){} // RVA: 0x7FFE87711D30
        public void Clear(){} // RVA: 0x7FFE87711D60
        public void CreateNewElement(){} // RVA: 0x7FFE87711D90
        public void GetElementKey(){} // RVA: 0x7FFE87711DC0
        public void IndexOf(){} // RVA: 0x7FFE87711DF0
        public void Remove(){} // RVA: 0x7FFE87711E50 | overloaded x2
        public void RemoveAt(){} // RVA: 0x7FFE87711E80
    }

    public class ConnectionManagementElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87711EE0 | overloaded x2
        public void get_Address(){} // RVA: 0x7FFE87711F10
        public void set_Address(){} // RVA: 0x7FFE87711F40
        public void get_MaxConnection(){} // RVA: 0x7FFE87711F70
        public void set_MaxConnection(){} // RVA: 0x7FFE87711FA0
        public void get_Properties(){} // RVA: 0x7FFE87711FD0
    }

    public class ConnectionManagementElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87712000
        public void get_Item(){} // RVA: 0x7FFE87712090 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFE877120C0 | overloaded x2
        public void Add(){} // RVA: 0x7FFE877120F0
        public void Clear(){} // RVA: 0x7FFE87712120
        public void CreateNewElement(){} // RVA: 0x7FFE87712150
        public void GetElementKey(){} // RVA: 0x7FFE87712180
        public void IndexOf(){} // RVA: 0x7FFE877121B0
        public void Remove(){} // RVA: 0x7FFE87712210 | overloaded x2
        public void RemoveAt(){} // RVA: 0x7FFE87712240
    }

    public class ConnectionManagementSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87712270
        public void get_ConnectionManagement(){} // RVA: 0x7FFE877122A0
        public void get_Properties(){} // RVA: 0x7FFE877122D0
    }

    public class DefaultProxySection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87712300
        public void get_BypassList(){} // RVA: 0x7FFE87712330
        public void get_Enabled(){} // RVA: 0x7FFE87712360
        public void set_Enabled(){} // RVA: 0x7FFE87712390
        public void get_Module(){} // RVA: 0x7FFE877123C0
        public void get_Properties(){} // RVA: 0x7FFE877123F0
        public void get_Proxy(){} // RVA: 0x7FFE87712420
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFE87712450
        public void set_UseDefaultCredentials(){} // RVA: 0x7FFE87712480
        public void PostDeserialize(){} // RVA: 0x7FFE877124B0
        public void Reset(){} // RVA: 0x7FFE877124E0
    }

    public class DefaultProxySectionInternal : Object
    {
        public System.Net.IWebProxy webProxy; // 0x10
        public object classSyncObject;

        // ── Methods ──
        public void GetDefaultProxy_UsingOldMonoCode(){} // RVA: 0x7FFE87682E60
        public void GetSystemWebProxy(){} // RVA: 0x7FFE87682E60
        public void get_ClassSyncObject(){} // RVA: 0x7FFE876D5320
        public void GetSection(){} // RVA: 0x7FFE876D53F0
        public void get_WebProxy(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class FtpCachePolicyElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87712810
        public void get_PolicyLevel(){} // RVA: 0x7FFE87712840
        public void set_PolicyLevel(){} // RVA: 0x7FFE87712870
        public void get_Properties(){} // RVA: 0x7FFE877128A0
        public void DeserializeElement(){} // RVA: 0x7FFE877128D0
        public void Reset(){} // RVA: 0x7FFE87712900
    }

    public class HttpCachePolicyElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87712930
        public void get_MaximumAge(){} // RVA: 0x7FFE87712960
        public void set_MaximumAge(){} // RVA: 0x7FFE87712990
        public void get_MaximumStale(){} // RVA: 0x7FFE877129C0
        public void set_MaximumStale(){} // RVA: 0x7FFE877129F0
        public void get_MinimumFresh(){} // RVA: 0x7FFE87712A20
        public void set_MinimumFresh(){} // RVA: 0x7FFE87712A50
        public void get_PolicyLevel(){} // RVA: 0x7FFE87712A80
        public void set_PolicyLevel(){} // RVA: 0x7FFE87712AB0
        public void get_Properties(){} // RVA: 0x7FFE87712AE0
        public void DeserializeElement(){} // RVA: 0x7FFE87712B10
        public void Reset(){} // RVA: 0x7FFE87712B40
    }

    public class HttpListenerElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87712B70
        public void get_Properties(){} // RVA: 0x7FFE87712BA0
        public void get_Timeouts(){} // RVA: 0x7FFE87712BD0
        public void get_UnescapeRequestUrl(){} // RVA: 0x7FFE87712C00
    }

    public class HttpListenerTimeoutsElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87712C30
        public void get_DrainEntityBody(){} // RVA: 0x7FFE87712C60
        public void get_EntityBody(){} // RVA: 0x7FFE87712C90
        public void get_HeaderWait(){} // RVA: 0x7FFE87712CC0
        public void get_IdleConnection(){} // RVA: 0x7FFE87712CF0
        public void get_MinSendBytesPerSecond(){} // RVA: 0x7FFE87712D20
        public void get_Properties(){} // RVA: 0x7FFE87712D50
        public void get_RequestQueue(){} // RVA: 0x7FFE87712D80
    }

    public class HttpWebRequestElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87712DB0
        public void get_MaximumErrorResponseLength(){} // RVA: 0x7FFE87712DE0
        public void set_MaximumErrorResponseLength(){} // RVA: 0x7FFE87712E10
        public void get_MaximumResponseHeadersLength(){} // RVA: 0x7FFE87712E40
        public void set_MaximumResponseHeadersLength(){} // RVA: 0x7FFE87712E70
        public void get_MaximumUnauthorizedUploadLength(){} // RVA: 0x7FFE87712EA0
        public void set_MaximumUnauthorizedUploadLength(){} // RVA: 0x7FFE87712ED0
        public void get_Properties(){} // RVA: 0x7FFE87712F00
        public void get_UseUnsafeHeaderParsing(){} // RVA: 0x7FFE87712F30
        public void set_UseUnsafeHeaderParsing(){} // RVA: 0x7FFE87712F60
        public void PostDeserialize(){} // RVA: 0x7FFE87712F90
    }

    public class Ipv6Element : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87712FC0
        public void get_Enabled(){} // RVA: 0x7FFE87712FF0
        public void set_Enabled(){} // RVA: 0x7FFE87713020
        public void get_Properties(){} // RVA: 0x7FFE87713050
    }

    public class MailSettingsSectionGroup : ConfigurationSectionGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87713080
        public void get_Smtp(){} // RVA: 0x7FFE877130B0
    }

    public class ModuleElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87712510
        public void get_Properties(){} // RVA: 0x7FFE87712540
        public void get_Type(){} // RVA: 0x7FFE87712570
        public void set_Type(){} // RVA: 0x7FFE877125A0
    }

    public class NetSectionGroup : ConfigurationSectionGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87713710
        public void get_AuthenticationModules(){} // RVA: 0x7FFE87713740
        public void get_ConnectionManagement(){} // RVA: 0x7FFE87713770
        public void get_DefaultProxy(){} // RVA: 0x7FFE877137A0
        public void get_MailSettings(){} // RVA: 0x7FFE877137D0
        public void get_RequestCaching(){} // RVA: 0x7FFE87713800
        public void get_Settings(){} // RVA: 0x7FFE87713830
        public void get_WebRequestModules(){} // RVA: 0x7FFE87713860
        public void GetSectionGroup(){} // RVA: 0x7FFE87713890
    }

    public class PerformanceCountersElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87713D70
        public void get_Enabled(){} // RVA: 0x7FFE87713DA0
        public void set_Enabled(){} // RVA: 0x7FFE87713DD0
        public void get_Properties(){} // RVA: 0x7FFE87713E00
    }

    public class ProxyElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877125D0
        public void get_AutoDetect(){} // RVA: 0x7FFE87712600
        public void set_AutoDetect(){} // RVA: 0x7FFE87712630
        public void get_BypassOnLocal(){} // RVA: 0x7FFE87712660
        public void set_BypassOnLocal(){} // RVA: 0x7FFE87712690
        public void get_Properties(){} // RVA: 0x7FFE877126C0
        public void get_ProxyAddress(){} // RVA: 0x7FFE877126F0
        public void set_ProxyAddress(){} // RVA: 0x7FFE87712720
        public void get_ScriptLocation(){} // RVA: 0x7FFE87712750
        public void set_ScriptLocation(){} // RVA: 0x7FFE87712780
        public void get_UseSystemDefault(){} // RVA: 0x7FFE877127B0
        public void set_UseSystemDefault(){} // RVA: 0x7FFE877127E0
    }

    public class RequestCachingSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877138C0
        public void get_DefaultFtpCachePolicy(){} // RVA: 0x7FFE877138F0
        public void get_DefaultHttpCachePolicy(){} // RVA: 0x7FFE87713920
        public void get_DefaultPolicyLevel(){} // RVA: 0x7FFE87713950
        public void set_DefaultPolicyLevel(){} // RVA: 0x7FFE87713980
        public void get_DisableAllCaching(){} // RVA: 0x7FFE877139B0
        public void set_DisableAllCaching(){} // RVA: 0x7FFE877139E0
        public void get_IsPrivateCache(){} // RVA: 0x7FFE87713A10
        public void set_IsPrivateCache(){} // RVA: 0x7FFE87713A40
        public void get_Properties(){} // RVA: 0x7FFE87713A70
        public void get_UnspecifiedMaximumAge(){} // RVA: 0x7FFE87713AA0
        public void set_UnspecifiedMaximumAge(){} // RVA: 0x7FFE87713AD0
        public void DeserializeElement(){} // RVA: 0x7FFE87713B00
        public void PostDeserialize(){} // RVA: 0x7FFE87713B30
    }

    public class ServicePointManagerElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87713E30
        public void get_CheckCertificateName(){} // RVA: 0x7FFE87713E60
        public void set_CheckCertificateName(){} // RVA: 0x7FFE87713E90
        public void get_CheckCertificateRevocationList(){} // RVA: 0x7FFE87713EC0
        public void set_CheckCertificateRevocationList(){} // RVA: 0x7FFE87713EF0
        public void get_DnsRefreshTimeout(){} // RVA: 0x7FFE87713F20
        public void set_DnsRefreshTimeout(){} // RVA: 0x7FFE87713F50
        public void get_EnableDnsRoundRobin(){} // RVA: 0x7FFE87713F80
        public void set_EnableDnsRoundRobin(){} // RVA: 0x7FFE87713FB0
        public void get_EncryptionPolicy(){} // RVA: 0x7FFE87713FE0
        public void set_EncryptionPolicy(){} // RVA: 0x7FFE87714010
        public void get_Expect100Continue(){} // RVA: 0x7FFE87714040
        public void set_Expect100Continue(){} // RVA: 0x7FFE87714070
        public void get_Properties(){} // RVA: 0x7FFE877140A0
        public void get_UseNagleAlgorithm(){} // RVA: 0x7FFE877140D0
        public void set_UseNagleAlgorithm(){} // RVA: 0x7FFE87714100
        public void PostDeserialize(){} // RVA: 0x7FFE87714130
    }

    public class SettingsSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87713B60
        public void get_HttpListener(){} // RVA: 0x7FFE87713B90
        public void get_HttpWebRequest(){} // RVA: 0x7FFE87713BC0
        public void get_Ipv6(){} // RVA: 0x7FFE87713BF0
        public void get_PerformanceCounters(){} // RVA: 0x7FFE87713C20
        public void get_Properties(){} // RVA: 0x7FFE87713C50
        public void get_ServicePointManager(){} // RVA: 0x7FFE87713C80
        public void get_Socket(){} // RVA: 0x7FFE87713CB0
        public void get_WebProxyScript(){} // RVA: 0x7FFE87713CE0
        public void get_WebUtility(){} // RVA: 0x7FFE87713D10
        public void get_WindowsAuthentication(){} // RVA: 0x7FFE87713D40
    }

    public class SettingsSectionInternal : Object
    {
        public System.Net.Configuration.SettingsSectionInternal instance;
        public bool HttpListenerUnescapeRequestUrl; // 0x10
        public 0x66539714 IPProtectionLevel; // 0x14
        public bool _useNagleAlgorithm; // 0x18
        public bool _expect100Continue; // 0x19
        public bool _checkCertificateName; // 0x1A
        public int _dnsRefreshTimeout; // 0x1C
        public bool _enableDnsRoundRobin; // 0x20
        public bool _checkCertificateRevocationList; // 0x21

        // ── Methods ──
        public void get_Section(){} // RVA: 0x7FFE876D56D0
        public void get_UseNagleAlgorithm(){} // RVA: 0x7FFE811164E0
        public void set_UseNagleAlgorithm(){} // RVA: 0x7FFE811164F0
        public void get_Expect100Continue(){} // RVA: 0x7FFE814B3730
        public void set_Expect100Continue(){} // RVA: 0x7FFE81CD0510
        public void get_CheckCertificateName(){} // RVA: 0x7FFE82930110
        public void set_CheckCertificateName(){} // RVA: 0x7FFE8292DD10
        public void get_DnsRefreshTimeout(){} // RVA: 0x7FFE82707EE0
        public void set_DnsRefreshTimeout(){} // RVA: 0x7FFE82717690
        public void get_EnableDnsRoundRobin(){} // RVA: 0x7FFE811E99D0
        public void set_EnableDnsRoundRobin(){} // RVA: 0x7FFE811E99E0
        public void get_CheckCertificateRevocationList(){} // RVA: 0x7FFE814B5BF0
        public void set_CheckCertificateRevocationList(){} // RVA: 0x7FFE818933B0
        public void get_EncryptionPolicy(){} // RVA: 0x7FFE81A56130
        public void set_EncryptionPolicy(){} // RVA: 0x7FFE82447980
        public void get_Ipv6Enabled(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE876D5730
        public void .cctor(){} // RVA: 0x7FFE876D5740
    }

    public class SmtpNetworkElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877132C0
        public void get_ClientDomain(){} // RVA: 0x7FFE877132F0
        public void set_ClientDomain(){} // RVA: 0x7FFE87713320
        public void get_DefaultCredentials(){} // RVA: 0x7FFE87713350
        public void set_DefaultCredentials(){} // RVA: 0x7FFE87713380
        public void get_EnableSsl(){} // RVA: 0x7FFE877133B0
        public void set_EnableSsl(){} // RVA: 0x7FFE877133E0
        public void get_Host(){} // RVA: 0x7FFE87713410
        public void set_Host(){} // RVA: 0x7FFE87713440
        public void get_Password(){} // RVA: 0x7FFE87713470
        public void set_Password(){} // RVA: 0x7FFE877134A0
        public void get_Port(){} // RVA: 0x7FFE877134D0
        public void set_Port(){} // RVA: 0x7FFE87713500
        public void get_Properties(){} // RVA: 0x7FFE87713530
        public void get_TargetName(){} // RVA: 0x7FFE87713560
        public void set_TargetName(){} // RVA: 0x7FFE87713590
        public void get_UserName(){} // RVA: 0x7FFE877135C0
        public void set_UserName(){} // RVA: 0x7FFE877135F0
        public void PostDeserialize(){} // RVA: 0x7FFE87713620
    }

    public class SmtpSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877130E0
        public void get_DeliveryFormat(){} // RVA: 0x7FFE87713110
        public void set_DeliveryFormat(){} // RVA: 0x7FFE87713140
        public void get_DeliveryMethod(){} // RVA: 0x7FFE87713170
        public void set_DeliveryMethod(){} // RVA: 0x7FFE877131A0
        public void get_From(){} // RVA: 0x7FFE877131D0
        public void set_From(){} // RVA: 0x7FFE87713200
        public void get_Network(){} // RVA: 0x7FFE87713230
        public void get_Properties(){} // RVA: 0x7FFE87713260
        public void get_SpecifiedPickupDirectory(){} // RVA: 0x7FFE87713290
    }

    public class SmtpSpecifiedPickupDirectoryElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87713650
        public void get_PickupDirectoryLocation(){} // RVA: 0x7FFE87713680
        public void set_PickupDirectoryLocation(){} // RVA: 0x7FFE877136B0
        public void get_Properties(){} // RVA: 0x7FFE877136E0
    }

    public class SocketElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87714160
        public void get_AlwaysUseCompletionPortsForAccept(){} // RVA: 0x7FFE87714190
        public void set_AlwaysUseCompletionPortsForAccept(){} // RVA: 0x7FFE877141C0
        public void get_AlwaysUseCompletionPortsForConnect(){} // RVA: 0x7FFE877141F0
        public void set_AlwaysUseCompletionPortsForConnect(){} // RVA: 0x7FFE87714220
        public void get_IPProtectionLevel(){} // RVA: 0x7FFE87714250
        public void set_IPProtectionLevel(){} // RVA: 0x7FFE87714280
        public void get_Properties(){} // RVA: 0x7FFE877142B0
        public void PostDeserialize(){} // RVA: 0x7FFE877142E0
    }

    public class WebProxyScriptElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87714310
        public void get_AutoConfigUrlRetryInterval(){} // RVA: 0x7FFE87714340
        public void set_AutoConfigUrlRetryInterval(){} // RVA: 0x7FFE87714370
        public void get_DownloadTimeout(){} // RVA: 0x7FFE877143A0
        public void set_DownloadTimeout(){} // RVA: 0x7FFE877143D0
        public void get_Properties(){} // RVA: 0x7FFE87714400
        public void PostDeserialize(){} // RVA: 0x7FFE87714430
    }

    public class WebRequestModuleElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87714A00 | overloaded x3
        public void get_Prefix(){} // RVA: 0x7FFE87714A30
        public void set_Prefix(){} // RVA: 0x7FFE87714A60
        public void get_Properties(){} // RVA: 0x7FFE87714A90
        public void get_Type(){} // RVA: 0x7FFE87714AC0
        public void set_Type(){} // RVA: 0x7FFE87714AF0
    }

    public class WebRequestModuleElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87714730
        public void get_Item(){} // RVA: 0x7FFE877147C0 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFE877147F0 | overloaded x2
        public void Add(){} // RVA: 0x7FFE87714820
        public void Clear(){} // RVA: 0x7FFE87714850
        public void CreateNewElement(){} // RVA: 0x7FFE87714880
        public void GetElementKey(){} // RVA: 0x7FFE877148B0
        public void IndexOf(){} // RVA: 0x7FFE877148E0
        public void Remove(){} // RVA: 0x7FFE87714940 | overloaded x2
        public void RemoveAt(){} // RVA: 0x7FFE87714970
    }

    public class WebRequestModulesSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87714640
        public void get_Properties(){} // RVA: 0x7FFE87714670
        public void get_WebRequestModules(){} // RVA: 0x7FFE877146A0
        public void InitializeDefault(){} // RVA: 0x7FFE877146D0
        public void PostDeserialize(){} // RVA: 0x7FFE87714700
    }

    public class WebUtilityElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87714460
        public void get_Properties(){} // RVA: 0x7FFE87714490
        public void get_UnicodeDecodingConformance(){} // RVA: 0x7FFE877144C0
        public void set_UnicodeDecodingConformance(){} // RVA: 0x7FFE877144F0
        public void get_UnicodeEncodingConformance(){} // RVA: 0x7FFE87714520
        public void set_UnicodeEncodingConformance(){} // RVA: 0x7FFE87714550
    }

    public class WindowsAuthenticationElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87714580
        public void get_DefaultCredentialsHandleCacheSize(){} // RVA: 0x7FFE877145B0
        public void set_DefaultCredentialsHandleCacheSize(){} // RVA: 0x7FFE877145E0
        public void get_Properties(){} // RVA: 0x7FFE87714610
    }

}