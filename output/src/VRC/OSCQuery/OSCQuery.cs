// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.OSCQuery
// Classes: 11
// Methods: 113

namespace VRC.OSCQuery
{
    public class Attributes : Object
    {
        public object _oscTypeLookup;
        public object CONTENTS;
        public object HOST_INFO;
        public object FULL_PATH;
        public object TYPE;
        public object ACCESS;
        public object CLIPMODE;
        public object CRITICAL;
        public object DESCRIPTION;
        public object EXTENDED_TYPE;
        public object HTML;
        public object OVERLOADS;
        public object RANGE;
        public object TAGS;
        public object UNIT;
        public object VALUE;
        public object SERVICE_OSCJSON_TCP;
        public object SERVICE_OSC_UDP;
        public object EXPLORER;

        // ── Methods ──
        public void OSCTypeFor(){} // RVA: 0x81BE070
        public void .cctor(){} // RVA: 0x81BE1E0
    }

    public class Extensions : Object
    {
        public object _client;
        public object DefaultLoopbackEndpoint;

        // ── Methods ──
        public void SkipLast(){} // RVA: 0x88B6E0
        public void GetAvailableTcpPort(){} // RVA: 0x81BE880
        public void GetAvailableUdpPort(){} // RVA: 0x81BEA30
        public void GetOSCTree(){} // RVA: 0x81BEBE0
        public void GetHostInfo(){} // RVA: 0x81BED80
        public void ServeStaticFile(){} // RVA: 0x81BEF20
        public void .cctor(){} // RVA: 0x81BF1A0
    }

    public class HostInfo : Object
    {
        public object name;
        public object extensions;
        public object oscIP;
        public object oscPort;
        public object oscTransport;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81C08B0
        public void ToString(){} // RVA: 0x81C0B60
    }

    public class IDiscovery
    {
        // ── Methods ──
        public void RefreshServices(){} // RVA: 0x894290
        public void add_OnOscServiceAdded(){} // RVA: 0x894320
        public void remove_OnOscServiceAdded(){} // RVA: 0x894320
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x894320
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x894320
        public void GetOSCQueryServices(){} // RVA: 0x87C0A0
        public void GetOSCServices(){} // RVA: 0x87C0A0
        public void Advertise(){} // RVA: 0x894320
        public void Unadvertise(){} // RVA: 0x894320
    }

    public class MeaModDiscovery : Object
    {
        public object _discovery;
        public object _mdns;
        public object Logger;
        public object _oscQueryServices;
        public object _oscServices;
        public object OnOscServiceAdded;
        public object OnOscQueryServiceAdded;
        public object _profiles;

        // ── Methods ──
        public void GetOSCQueryServices(){} // RVA: 0xB700F0
        public void GetOSCServices(){} // RVA: 0xB70160
        public void Dispose(){} // RVA: 0x81C9AD0
        public void .ctor(){} // RVA: 0x81C9B20
        public void RefreshServices(){} // RVA: 0x81CA090
        public void add_OnOscServiceAdded(){} // RVA: 0x81CA210
        public void remove_OnOscServiceAdded(){} // RVA: 0x81CA320
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x81CA430
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x81CA540
        public void Advertise(){} // RVA: 0x81CA650
        public void Unadvertise(){} // RVA: 0x81CA9D0
        public void OnRemoteServiceInfo(){} // RVA: 0x81CAC20
        public void AddMatchedService(){} // RVA: 0x81CB2B0
        public void <.ctor>b__8_0(){} // RVA: 0x81CA090
    }

    public class OSCQueryHttpServer : Object
    {
        public object _listener;
        public object _shouldProcessHttp;
        public object _preMiddleware;
        public object _middleware;
        public object _postMiddleware;
        public object Logger;
        public object _oscQuery;
        public object _pathToResources;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81C0BB0
        public void AddMiddleware(){} // RVA: 0x81C1160
        public void HttpListenerLoop(){} // RVA: 0x81C11C0
        public void HostInfoMiddleware(){} // RVA: 0x81C1450
        public void get_PathToResources(){} // RVA: 0x81C16D0
        public void ExplorerMiddleware(){} // RVA: 0x81C1970
        public void FaviconMiddleware(){} // RVA: 0x81C1BE0
        public void RootNodeMiddleware(){} // RVA: 0x81C1E50
        public void Dispose(){} // RVA: 0x81C2060
    }

    public class OSCQueryNode : Object
    {
        public object Description;
        public object FullPath;
        public object Access;
        public object Contents;
        public object OscType;
        public object Value;
        public object WriteSettings;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA9BA0
        public void get_ParentPath(){} // RVA: 0x81C63F0
        public void get_Name(){} // RVA: 0x81C64B0
        public void ToString(){} // RVA: 0x81C6500
        public void AddConverter(){} // RVA: 0x81C6630
        public void .cctor(){} // RVA: 0x81C6740
    }

    public class OSCQueryRootNode : OSCQueryNode
    {
        public object _pathLookup;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81C55B0
        public void GetNodeWithPath(){} // RVA: 0x81C5700
        public void AddNode(){} // RVA: 0x81C5790
        public void RemoveNode(){} // RVA: 0x81C5C00
        public void RebuildLookup(){} // RVA: 0x81C5DE0
        public void AddContents(){} // RVA: 0x81C5F00
        public void FromString(){} // RVA: 0x81C6290
    }

    public class OSCQueryService : Object
    {
        public object _tcpPort;
        public object _hostIP;
        public object _oscIP;
        public object _logger;
        public object _localIp;
        public object DefaultPortHttp;
        public object DefaultPortOsc;
        public object DefaultServerName;
        public object _localOscUdpServiceName;
        public object _localOscJsonServiceName;
        public object MatchedNames;
        public object _discovery;
        public object OnOscServiceAdded;
        public object OnOscQueryServiceAdded;
        public object _http;
        public object _hostInfo;
        public object _rootNode;

        // ── Methods ──
        public void AddEndpoint(){} // RVA: 0x880310
        public void .ctor(){} // RVA: 0x81C8730
        public void get_TcpPort(){} // RVA: 0xB8F8F0
        public void set_TcpPort(){} // RVA: 0xB460A0
        public void get_OscPort(){} // RVA: 0x81C6970
        public void set_OscPort(){} // RVA: 0x81C6990
        public void get_ServerName(){} // RVA: 0x81C69C0
        public void set_ServerName(){} // RVA: 0x81C69E0
        public void get_HostIP(){} // RVA: 0xB465B0
        public void set_HostIP(){} // RVA: 0xBA9BA0
        public void get_OscIP(){} // RVA: 0xB700F0
        public void set_OscIP(){} // RVA: 0xB70100
        public void get_Logger(){} // RVA: 0x81C6A50
        public void set_Logger(){} // RVA: 0x81C6AB0
        public void AddMiddleware(){} // RVA: 0x81C6B60
        public void SetDiscovery(){} // RVA: 0x81C6BC0
        public void get_LocalIp(){} // RVA: 0x81C6D00
        public void get_Discovery(){} // RVA: 0x81C6F00
        public void add_OnOscServiceAdded(){} // RVA: 0x81C7060
        public void remove_OnOscServiceAdded(){} // RVA: 0x81C7170
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x81C7280
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x81C7390
        public void GetOSCQueryServices(){} // RVA: 0x81C74A0
        public void GetOSCServices(){} // RVA: 0x81C7500
        public void get_HostInfo(){} // RVA: 0x81C7560
        public void get_RootNode(){} // RVA: 0x81C7760
        public void StartHttpServer(){} // RVA: 0x81C7790
        public void AdvertiseOSCQueryService(){} // RVA: 0x81C78C0
        public void AdvertiseOSCService(){} // RVA: 0x81C79C0
        public void RefreshServices(){} // RVA: 0x81C7AC0
        public void SetValue(){} // RVA: 0x81C7CE0
        public void RemoveEndpoint(){} // RVA: 0x81C81F0
        public void BuildRootNode(){} // RVA: 0x81C8340
        public void Dispose(){} // RVA: 0x81C85F0
        public void Finalize(){} // RVA: 0x81C86F0
        public void Initialize(){} // RVA: 0x81C8AE0
        public void StartOSCQueryService(){} // RVA: 0x81C8BD0
        public void .cctor(){} // RVA: 0x81C8D00
        public void <SetDiscovery>b__24_0(){} // RVA: 0x5A630D0
        public void <SetDiscovery>b__24_1(){} // RVA: 0x7E836F0
    }

    public class OSCQueryServiceBuilder : Object
    {
        public object _service;
        public object _customStartup;

        // ── Methods ──
        public void Build(){} // RVA: 0x81C9010
        public void WithDefaults(){} // RVA: 0x81C90F0
        public void WithTcpPort(){} // RVA: 0x81C91D0
        public void WithUdpPort(){} // RVA: 0x81C9200
        public void WithHostIP(){} // RVA: 0x81C9240
        public void WithOscIP(){} // RVA: 0x81C93D0
        public void StartHttpServer(){} // RVA: 0x81C9440
        public void WithServiceName(){} // RVA: 0x81C9470
        public void WithLogger(){} // RVA: 0x81C94A0
        public void WithMiddleware(){} // RVA: 0x81C9500
        public void WithDiscovery(){} // RVA: 0x81C9580
        public void AddListenerForServiceType(){} // RVA: 0x81C95B0
        public void AdvertiseOSC(){} // RVA: 0x81C9700
        public void AdvertiseOSCQuery(){} // RVA: 0x81C9780
        public void .ctor(){} // RVA: 0x81C97E0
    }

    public class OSCQueryServiceProfile : Object
    {
        public object port;
        public object name;
        public object address;
        public object serviceType;

        // ── Methods ──
        public void GetServiceTypeString(){} // RVA: 0x81C9990
        public void .ctor(){} // RVA: 0x81C9A10
    }

}