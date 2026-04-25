// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.Configuration
// Classes: 35
// Methods: 303

namespace ThirdParty.DotNet.System.Net.Configuration
{
    public class AuthenticationModuleElement : ConfigurationElement
    {
        public object Properties;
        public object Type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9368FD0 | overloaded x2
        public void get_Properties(){} // RVA: 0x7FFAC9369000
        public void get_Type(){} // RVA: 0x7FFAC9369030
        public void set_Type(){} // RVA: 0x7FFAC9369060
    }

    public class AuthenticationModuleElementCollection : ConfigurationElementCollection
    {
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9369090
        public void get_Item(){} // RVA: 0x7FFAC9369120 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFAC9369150 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC9369180
        public void Clear(){} // RVA: 0x7FFAC93691B0
        public void CreateNewElement(){} // RVA: 0x7FFAC93691E0
        public void GetElementKey(){} // RVA: 0x7FFAC9369210
        public void IndexOf(){} // RVA: 0x7FFAC9369240
        public void Remove(){} // RVA: 0x7FFAC93692A0 | overloaded x2
        public void RemoveAt(){} // RVA: 0x7FFAC93692D0
    }

    public class AuthenticationModulesSection : ConfigurationSection
    {
        public object AuthenticationModules;
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9369300
        public void get_AuthenticationModules(){} // RVA: 0x7FFAC9369330
        public void get_Properties(){} // RVA: 0x7FFAC9369360
        public void InitializeDefault(){} // RVA: 0x7FFAC9369390
        public void PostDeserialize(){} // RVA: 0x7FFAC93693C0
    }

    public class BypassElement : ConfigurationElement
    {
        public object Address;
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9369420 | overloaded x2
        public void get_Address(){} // RVA: 0x7FFAC9369450
        public void set_Address(){} // RVA: 0x7FFAC9369480
        public void get_Properties(){} // RVA: 0x7FFAC93694B0
    }

    public class BypassElementCollection : ConfigurationElementCollection
    {
        public object Item;
        public object ThrowOnDuplicate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93694E0
        public void get_Item(){} // RVA: 0x7FFAC9369570 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFAC93695A0 | overloaded x2
        public void get_ThrowOnDuplicate(){} // RVA: 0x7FFAC93695D0
        public void Add(){} // RVA: 0x7FFAC9369600
        public void Clear(){} // RVA: 0x7FFAC9369630
        public void CreateNewElement(){} // RVA: 0x7FFAC9369660
        public void GetElementKey(){} // RVA: 0x7FFAC9369690
        public void IndexOf(){} // RVA: 0x7FFAC93696C0
        public void Remove(){} // RVA: 0x7FFAC9369720 | overloaded x2
        public void RemoveAt(){} // RVA: 0x7FFAC9369750
    }

    public class ConnectionManagementElement : ConfigurationElement
    {
        public object Address;
        public object MaxConnection;
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93697B0 | overloaded x2
        public void get_Address(){} // RVA: 0x7FFAC93697E0
        public void set_Address(){} // RVA: 0x7FFAC9369810
        public void get_MaxConnection(){} // RVA: 0x7FFAC9369840
        public void set_MaxConnection(){} // RVA: 0x7FFAC9369870
        public void get_Properties(){} // RVA: 0x7FFAC93698A0
    }

    public class ConnectionManagementElementCollection : ConfigurationElementCollection
    {
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93698D0
        public void get_Item(){} // RVA: 0x7FFAC9369960 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFAC9369990 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC93699C0
        public void Clear(){} // RVA: 0x7FFAC93699F0
        public void CreateNewElement(){} // RVA: 0x7FFAC9369A20
        public void GetElementKey(){} // RVA: 0x7FFAC9369A50
        public void IndexOf(){} // RVA: 0x7FFAC9369A80
        public void Remove(){} // RVA: 0x7FFAC9369AE0 | overloaded x2
        public void RemoveAt(){} // RVA: 0x7FFAC9369B10
    }

    public class ConnectionManagementSection : ConfigurationSection
    {
        public object ConnectionManagement;
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9369B40
        public void get_ConnectionManagement(){} // RVA: 0x7FFAC9369B70
        public void get_Properties(){} // RVA: 0x7FFAC9369BA0
    }

    public class DefaultProxySection : ConfigurationSection
    {
        public object BypassList;
        public object Enabled;
        public object Module;
        public object Properties;
        public object Proxy;
        public object UseDefaultCredentials;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9369BD0
        public void get_BypassList(){} // RVA: 0x7FFAC9369C00
        public void get_Enabled(){} // RVA: 0x7FFAC9369C30
        public void set_Enabled(){} // RVA: 0x7FFAC9369C60
        public void get_Module(){} // RVA: 0x7FFAC9369C90
        public void get_Properties(){} // RVA: 0x7FFAC9369CC0
        public void get_Proxy(){} // RVA: 0x7FFAC9369CF0
        public void get_UseDefaultCredentials(){} // RVA: 0x7FFAC9369D20
        public void set_UseDefaultCredentials(){} // RVA: 0x7FFAC9369D50
        public void PostDeserialize(){} // RVA: 0x7FFAC9369D80
        public void Reset(){} // RVA: 0x7FFAC9369DB0
    }

    public class DefaultProxySectionInternal : Object
    {
        public System.Net.IWebProxy ClassSyncObject; // 0x10
        public object WebProxy;

        // ── Methods ──
        public void GetDefaultProxy_UsingOldMonoCode(){} // RVA: 0x7FFAC92DA730
        public void GetSystemWebProxy(){} // RVA: 0x7FFAC92DA730
        public void get_ClassSyncObject(){} // RVA: 0x7FFAC932CBF0
        public void GetSection(){} // RVA: 0x7FFAC932CCC0
        public void get_WebProxy(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FtpCachePolicyElement : ConfigurationElement
    {
        public object PolicyLevel;
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936A0E0
        public void get_PolicyLevel(){} // RVA: 0x7FFAC936A110
        public void set_PolicyLevel(){} // RVA: 0x7FFAC936A140
        public void get_Properties(){} // RVA: 0x7FFAC936A170
        public void DeserializeElement(){} // RVA: 0x7FFAC936A1A0
        public void Reset(){} // RVA: 0x7FFAC936A1D0
    }

    public class HttpCachePolicyElement : ConfigurationElement
    {
        public object MaximumAge;
        public object MaximumStale;
        public object MinimumFresh;
        public object PolicyLevel;
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936A200
        public void get_MaximumAge(){} // RVA: 0x7FFAC936A230
        public void set_MaximumAge(){} // RVA: 0x7FFAC936A260
        public void get_MaximumStale(){} // RVA: 0x7FFAC936A290
        public void set_MaximumStale(){} // RVA: 0x7FFAC936A2C0
        public void get_MinimumFresh(){} // RVA: 0x7FFAC936A2F0
        public void set_MinimumFresh(){} // RVA: 0x7FFAC936A320
        public void get_PolicyLevel(){} // RVA: 0x7FFAC936A350
        public void set_PolicyLevel(){} // RVA: 0x7FFAC936A380
        public void get_Properties(){} // RVA: 0x7FFAC936A3B0
        public void DeserializeElement(){} // RVA: 0x7FFAC936A3E0
        public void Reset(){} // RVA: 0x7FFAC936A410
    }

    public class HttpListenerElement : ConfigurationElement
    {
        public object Properties;
        public object Timeouts;
        public object UnescapeRequestUrl;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936A440
        public void get_Properties(){} // RVA: 0x7FFAC936A470
        public void get_Timeouts(){} // RVA: 0x7FFAC936A4A0
        public void get_UnescapeRequestUrl(){} // RVA: 0x7FFAC936A4D0
    }

    public class HttpListenerTimeoutsElement : ConfigurationElement
    {
        public object DrainEntityBody;
        public object EntityBody;
        public object HeaderWait;
        public object IdleConnection;
        public object MinSendBytesPerSecond;
        public object Properties;
        public object RequestQueue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936A500
        public void get_DrainEntityBody(){} // RVA: 0x7FFAC936A530
        public void get_EntityBody(){} // RVA: 0x7FFAC936A560
        public void get_HeaderWait(){} // RVA: 0x7FFAC936A590
        public void get_IdleConnection(){} // RVA: 0x7FFAC936A5C0
        public void get_MinSendBytesPerSecond(){} // RVA: 0x7FFAC936A5F0
        public void get_Properties(){} // RVA: 0x7FFAC936A620
        public void get_RequestQueue(){} // RVA: 0x7FFAC936A650
    }

    public class HttpWebRequestElement : ConfigurationElement
    {
        public object MaximumErrorResponseLength;
        public object MaximumResponseHeadersLength;
        public object MaximumUnauthorizedUploadLength;
        public object Properties;
        public object UseUnsafeHeaderParsing;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936A680
        public void get_MaximumErrorResponseLength(){} // RVA: 0x7FFAC936A6B0
        public void set_MaximumErrorResponseLength(){} // RVA: 0x7FFAC936A6E0
        public void get_MaximumResponseHeadersLength(){} // RVA: 0x7FFAC936A710
        public void set_MaximumResponseHeadersLength(){} // RVA: 0x7FFAC936A740
        public void get_MaximumUnauthorizedUploadLength(){} // RVA: 0x7FFAC936A770
        public void set_MaximumUnauthorizedUploadLength(){} // RVA: 0x7FFAC936A7A0
        public void get_Properties(){} // RVA: 0x7FFAC936A7D0
        public void get_UseUnsafeHeaderParsing(){} // RVA: 0x7FFAC936A800
        public void set_UseUnsafeHeaderParsing(){} // RVA: 0x7FFAC936A830
        public void PostDeserialize(){} // RVA: 0x7FFAC936A860
    }

    public class Ipv6Element : ConfigurationElement
    {
        public object Enabled;
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936A890
        public void get_Enabled(){} // RVA: 0x7FFAC936A8C0
        public void set_Enabled(){} // RVA: 0x7FFAC936A8F0
        public void get_Properties(){} // RVA: 0x7FFAC936A920
    }

    public class MailSettingsSectionGroup : ConfigurationSectionGroup
    {
        public object Smtp;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936A950
        public void get_Smtp(){} // RVA: 0x7FFAC936A980
    }

    public class ModuleElement : ConfigurationElement
    {
        public object Properties;
        public object Type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9369DE0
        public void get_Properties(){} // RVA: 0x7FFAC9369E10
        public void get_Type(){} // RVA: 0x7FFAC9369E40
        public void set_Type(){} // RVA: 0x7FFAC9369E70
    }

    public class NetSectionGroup : ConfigurationSectionGroup
    {
        public object AuthenticationModules;
        public object ConnectionManagement;
        public object DefaultProxy;
        public object MailSettings;
        public object RequestCaching;
        public object Settings;
        public object WebRequestModules;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936AFE0
        public void get_AuthenticationModules(){} // RVA: 0x7FFAC936B010
        public void get_ConnectionManagement(){} // RVA: 0x7FFAC936B040
        public void get_DefaultProxy(){} // RVA: 0x7FFAC936B070
        public void get_MailSettings(){} // RVA: 0x7FFAC936B0A0
        public void get_RequestCaching(){} // RVA: 0x7FFAC936B0D0
        public void get_Settings(){} // RVA: 0x7FFAC936B100
        public void get_WebRequestModules(){} // RVA: 0x7FFAC936B130
        public void GetSectionGroup(){} // RVA: 0x7FFAC936B160
    }

    public class PerformanceCountersElement : ConfigurationElement
    {
        public object Enabled;
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936B640
        public void get_Enabled(){} // RVA: 0x7FFAC936B670
        public void set_Enabled(){} // RVA: 0x7FFAC936B6A0
        public void get_Properties(){} // RVA: 0x7FFAC936B6D0
    }

    public class ProxyElement : ConfigurationElement
    {
        public object AutoDetect;
        public object BypassOnLocal;
        public object Properties;
        public object ProxyAddress;
        public object ScriptLocation;
        public object UseSystemDefault;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9369EA0
        public void get_AutoDetect(){} // RVA: 0x7FFAC9369ED0
        public void set_AutoDetect(){} // RVA: 0x7FFAC9369F00
        public void get_BypassOnLocal(){} // RVA: 0x7FFAC9369F30
        public void set_BypassOnLocal(){} // RVA: 0x7FFAC9369F60
        public void get_Properties(){} // RVA: 0x7FFAC9369F90
        public void get_ProxyAddress(){} // RVA: 0x7FFAC9369FC0
        public void set_ProxyAddress(){} // RVA: 0x7FFAC9369FF0
        public void get_ScriptLocation(){} // RVA: 0x7FFAC936A020
        public void set_ScriptLocation(){} // RVA: 0x7FFAC936A050
        public void get_UseSystemDefault(){} // RVA: 0x7FFAC936A080
        public void set_UseSystemDefault(){} // RVA: 0x7FFAC936A0B0
    }

    public class RequestCachingSection : ConfigurationSection
    {
        public object DefaultFtpCachePolicy;
        public object DefaultHttpCachePolicy;
        public object DefaultPolicyLevel;
        public object DisableAllCaching;
        public object IsPrivateCache;
        public object Properties;
        public object UnspecifiedMaximumAge;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936B190
        public void get_DefaultFtpCachePolicy(){} // RVA: 0x7FFAC936B1C0
        public void get_DefaultHttpCachePolicy(){} // RVA: 0x7FFAC936B1F0
        public void get_DefaultPolicyLevel(){} // RVA: 0x7FFAC936B220
        public void set_DefaultPolicyLevel(){} // RVA: 0x7FFAC936B250
        public void get_DisableAllCaching(){} // RVA: 0x7FFAC936B280
        public void set_DisableAllCaching(){} // RVA: 0x7FFAC936B2B0
        public void get_IsPrivateCache(){} // RVA: 0x7FFAC936B2E0
        public void set_IsPrivateCache(){} // RVA: 0x7FFAC936B310
        public void get_Properties(){} // RVA: 0x7FFAC936B340
        public void get_UnspecifiedMaximumAge(){} // RVA: 0x7FFAC936B370
        public void set_UnspecifiedMaximumAge(){} // RVA: 0x7FFAC936B3A0
        public void DeserializeElement(){} // RVA: 0x7FFAC936B3D0
        public void PostDeserialize(){} // RVA: 0x7FFAC936B400
    }

    public class ServicePointManagerElement : ConfigurationElement
    {
        public object CheckCertificateName;
        public object CheckCertificateRevocationList;
        public object DnsRefreshTimeout;
        public object EnableDnsRoundRobin;
        public object EncryptionPolicy;
        public object Expect100Continue;
        public object Properties;
        public object UseNagleAlgorithm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936B700
        public void get_CheckCertificateName(){} // RVA: 0x7FFAC936B730
        public void set_CheckCertificateName(){} // RVA: 0x7FFAC936B760
        public void get_CheckCertificateRevocationList(){} // RVA: 0x7FFAC936B790
        public void set_CheckCertificateRevocationList(){} // RVA: 0x7FFAC936B7C0
        public void get_DnsRefreshTimeout(){} // RVA: 0x7FFAC936B7F0
        public void set_DnsRefreshTimeout(){} // RVA: 0x7FFAC936B820
        public void get_EnableDnsRoundRobin(){} // RVA: 0x7FFAC936B850
        public void set_EnableDnsRoundRobin(){} // RVA: 0x7FFAC936B880
        public void get_EncryptionPolicy(){} // RVA: 0x7FFAC936B8B0
        public void set_EncryptionPolicy(){} // RVA: 0x7FFAC936B8E0
        public void get_Expect100Continue(){} // RVA: 0x7FFAC936B910
        public void set_Expect100Continue(){} // RVA: 0x7FFAC936B940
        public void get_Properties(){} // RVA: 0x7FFAC936B970
        public void get_UseNagleAlgorithm(){} // RVA: 0x7FFAC936B9A0
        public void set_UseNagleAlgorithm(){} // RVA: 0x7FFAC936B9D0
        public void PostDeserialize(){} // RVA: 0x7FFAC936BA00
    }

    public class SettingsSection : ConfigurationSection
    {
        public object HttpListener;
        public object HttpWebRequest;
        public object Ipv6;
        public object PerformanceCounters;
        public object Properties;
        public object ServicePointManager;
        public object Socket;
        public object WebProxyScript;
        public object WebUtility;
        public object WindowsAuthentication;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936B430
        public void get_HttpListener(){} // RVA: 0x7FFAC936B460
        public void get_HttpWebRequest(){} // RVA: 0x7FFAC936B490
        public void get_Ipv6(){} // RVA: 0x7FFAC936B4C0
        public void get_PerformanceCounters(){} // RVA: 0x7FFAC936B4F0
        public void get_Properties(){} // RVA: 0x7FFAC936B520
        public void get_ServicePointManager(){} // RVA: 0x7FFAC936B550
        public void get_Socket(){} // RVA: 0x7FFAC936B580
        public void get_WebProxyScript(){} // RVA: 0x7FFAC936B5B0
        public void get_WebUtility(){} // RVA: 0x7FFAC936B5E0
        public void get_WindowsAuthentication(){} // RVA: 0x7FFAC936B610
    }

    public class SettingsSectionInternal : Object
    {
        public System.Net.Configuration.SettingsSectionInternal Section;
        public bool UseNagleAlgorithm; // 0x10
        public 0x6B1407F0 Expect100Continue; // 0x14
        public bool CheckCertificateName; // 0x18
        public bool DnsRefreshTimeout; // 0x19
        public bool EnableDnsRoundRobin; // 0x1A
        public int CheckCertificateRevocationList; // 0x1C
        public bool EncryptionPolicy; // 0x20
        public bool Ipv6Enabled; // 0x21
        public 0x6B1423C8 <EncryptionPolicy>k__BackingField; // 0x24

        // ── Methods ──
        public void get_Section(){} // RVA: 0x7FFAC932CFA0
        public void get_UseNagleAlgorithm(){} // RVA: 0x7FFAC2F3C4E0
        public void set_UseNagleAlgorithm(){} // RVA: 0x7FFAC2F3C4F0
        public void get_Expect100Continue(){} // RVA: 0x7FFAC3228D50
        public void set_Expect100Continue(){} // RVA: 0x7FFAC3515120
        public void get_CheckCertificateName(){} // RVA: 0x7FFAC45FA190
        public void set_CheckCertificateName(){} // RVA: 0x7FFAC45F9AE0
        public void get_DnsRefreshTimeout(){} // RVA: 0x7FFAC44357F0
        public void set_DnsRefreshTimeout(){} // RVA: 0x7FFAC44474D0
        public void get_EnableDnsRoundRobin(){} // RVA: 0x7FFAC300F9D0
        public void set_EnableDnsRoundRobin(){} // RVA: 0x7FFAC300F9E0
        public void get_CheckCertificateRevocationList(){} // RVA: 0x7FFAC322AD20
        public void set_CheckCertificateRevocationList(){} // RVA: 0x7FFAC376A610
        public void get_EncryptionPolicy(){} // RVA: 0x7FFAC3921980
        public void set_EncryptionPolicy(){} // RVA: 0x7FFAC41674D0
        public void get_Ipv6Enabled(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC932D000
        public void .cctor(){} // RVA: 0x7FFAC932D010
    }

    public class SmtpNetworkElement : ConfigurationElement
    {
        public object ClientDomain;
        public object DefaultCredentials;
        public object EnableSsl;
        public object Host;
        public object Password;
        public object Port;
        public object Properties;
        public object TargetName;
        public object UserName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936AB90
        public void get_ClientDomain(){} // RVA: 0x7FFAC936ABC0
        public void set_ClientDomain(){} // RVA: 0x7FFAC936ABF0
        public void get_DefaultCredentials(){} // RVA: 0x7FFAC936AC20
        public void set_DefaultCredentials(){} // RVA: 0x7FFAC936AC50
        public void get_EnableSsl(){} // RVA: 0x7FFAC936AC80
        public void set_EnableSsl(){} // RVA: 0x7FFAC936ACB0
        public void get_Host(){} // RVA: 0x7FFAC936ACE0
        public void set_Host(){} // RVA: 0x7FFAC936AD10
        public void get_Password(){} // RVA: 0x7FFAC936AD40
        public void set_Password(){} // RVA: 0x7FFAC936AD70
        public void get_Port(){} // RVA: 0x7FFAC936ADA0
        public void set_Port(){} // RVA: 0x7FFAC936ADD0
        public void get_Properties(){} // RVA: 0x7FFAC936AE00
        public void get_TargetName(){} // RVA: 0x7FFAC936AE30
        public void set_TargetName(){} // RVA: 0x7FFAC936AE60
        public void get_UserName(){} // RVA: 0x7FFAC936AE90
        public void set_UserName(){} // RVA: 0x7FFAC936AEC0
        public void PostDeserialize(){} // RVA: 0x7FFAC936AEF0
    }

    public class SmtpSection : ConfigurationSection
    {
        public object DeliveryFormat;
        public object DeliveryMethod;
        public object From;
        public object Network;
        public object Properties;
        public object SpecifiedPickupDirectory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936A9B0
        public void get_DeliveryFormat(){} // RVA: 0x7FFAC936A9E0
        public void set_DeliveryFormat(){} // RVA: 0x7FFAC936AA10
        public void get_DeliveryMethod(){} // RVA: 0x7FFAC936AA40
        public void set_DeliveryMethod(){} // RVA: 0x7FFAC936AA70
        public void get_From(){} // RVA: 0x7FFAC936AAA0
        public void set_From(){} // RVA: 0x7FFAC936AAD0
        public void get_Network(){} // RVA: 0x7FFAC936AB00
        public void get_Properties(){} // RVA: 0x7FFAC936AB30
        public void get_SpecifiedPickupDirectory(){} // RVA: 0x7FFAC936AB60
    }

    public class SmtpSpecifiedPickupDirectoryElement : ConfigurationElement
    {
        public object PickupDirectoryLocation;
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936AF20
        public void get_PickupDirectoryLocation(){} // RVA: 0x7FFAC936AF50
        public void set_PickupDirectoryLocation(){} // RVA: 0x7FFAC936AF80
        public void get_Properties(){} // RVA: 0x7FFAC936AFB0
    }

    public class SocketElement : ConfigurationElement
    {
        public object AlwaysUseCompletionPortsForAccept;
        public object AlwaysUseCompletionPortsForConnect;
        public object IPProtectionLevel;
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936BA30
        public void get_AlwaysUseCompletionPortsForAccept(){} // RVA: 0x7FFAC936BA60
        public void set_AlwaysUseCompletionPortsForAccept(){} // RVA: 0x7FFAC936BA90
        public void get_AlwaysUseCompletionPortsForConnect(){} // RVA: 0x7FFAC936BAC0
        public void set_AlwaysUseCompletionPortsForConnect(){} // RVA: 0x7FFAC936BAF0
        public void get_IPProtectionLevel(){} // RVA: 0x7FFAC936BB20
        public void set_IPProtectionLevel(){} // RVA: 0x7FFAC936BB50
        public void get_Properties(){} // RVA: 0x7FFAC936BB80
        public void PostDeserialize(){} // RVA: 0x7FFAC936BBB0
    }

    public class WebProxyScriptElement : ConfigurationElement
    {
        public object AutoConfigUrlRetryInterval;
        public object DownloadTimeout;
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936BBE0
        public void get_AutoConfigUrlRetryInterval(){} // RVA: 0x7FFAC936BC10
        public void set_AutoConfigUrlRetryInterval(){} // RVA: 0x7FFAC936BC40
        public void get_DownloadTimeout(){} // RVA: 0x7FFAC936BC70
        public void set_DownloadTimeout(){} // RVA: 0x7FFAC936BCA0
        public void get_Properties(){} // RVA: 0x7FFAC936BCD0
        public void PostDeserialize(){} // RVA: 0x7FFAC936BD00
    }

    public class WebRequestModuleElement : ConfigurationElement
    {
        public object Prefix;
        public object Properties;
        public object Type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936C2D0 | overloaded x3
        public void get_Prefix(){} // RVA: 0x7FFAC936C300
        public void set_Prefix(){} // RVA: 0x7FFAC936C330
        public void get_Properties(){} // RVA: 0x7FFAC936C360
        public void get_Type(){} // RVA: 0x7FFAC936C390
        public void set_Type(){} // RVA: 0x7FFAC936C3C0
    }

    public class WebRequestModuleElementCollection : ConfigurationElementCollection
    {
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936C000
        public void get_Item(){} // RVA: 0x7FFAC936C090 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFAC936C0C0 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC936C0F0
        public void Clear(){} // RVA: 0x7FFAC936C120
        public void CreateNewElement(){} // RVA: 0x7FFAC936C150
        public void GetElementKey(){} // RVA: 0x7FFAC936C180
        public void IndexOf(){} // RVA: 0x7FFAC936C1B0
        public void Remove(){} // RVA: 0x7FFAC936C210 | overloaded x2
        public void RemoveAt(){} // RVA: 0x7FFAC936C240
    }

    public class WebRequestModulesSection : ConfigurationSection
    {
        public object Properties;
        public object WebRequestModules;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936BF10
        public void get_Properties(){} // RVA: 0x7FFAC936BF40
        public void get_WebRequestModules(){} // RVA: 0x7FFAC936BF70
        public void InitializeDefault(){} // RVA: 0x7FFAC936BFA0
        public void PostDeserialize(){} // RVA: 0x7FFAC936BFD0
    }

    public class WebUtilityElement : ConfigurationElement
    {
        public object Properties;
        public object UnicodeDecodingConformance;
        public object UnicodeEncodingConformance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936BD30
        public void get_Properties(){} // RVA: 0x7FFAC936BD60
        public void get_UnicodeDecodingConformance(){} // RVA: 0x7FFAC936BD90
        public void set_UnicodeDecodingConformance(){} // RVA: 0x7FFAC936BDC0
        public void get_UnicodeEncodingConformance(){} // RVA: 0x7FFAC936BDF0
        public void set_UnicodeEncodingConformance(){} // RVA: 0x7FFAC936BE20
    }

    public class WindowsAuthenticationElement : ConfigurationElement
    {
        public object DefaultCredentialsHandleCacheSize;
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936BE50
        public void get_DefaultCredentialsHandleCacheSize(){} // RVA: 0x7FFAC936BE80
        public void set_DefaultCredentialsHandleCacheSize(){} // RVA: 0x7FFAC936BEB0
        public void get_Properties(){} // RVA: 0x7FFAC936BEE0
    }

}