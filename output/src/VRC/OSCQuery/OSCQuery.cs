// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.OSCQuery
// Classes: 11
// Methods: 118

namespace VRC.OSCQuery
{
    public class Attributes : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Type,string> _oscTypeLookup;
        public string CONTENTS;
        public string HOST_INFO;
        public string FULL_PATH;
        public string TYPE;
        public string ACCESS;
        public string CLIPMODE;
        public string CRITICAL;
        public string DESCRIPTION;
        public string EXTENDED_TYPE;
        public string HTML;
        public string OVERLOADS;
        public string RANGE;
        public string TAGS;
        public string UNIT;
        public string VALUE;
        public string SERVICE_OSCJSON_TCP;
        public string SERVICE_OSC_UDP;
        public string EXPLORER; // 0x8

        // ── Methods ──
        public void OSCTypeFor(){} // RVA: 0x7FFAC9D1E0A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9D1E220
    }

    public class Extensions : Object
    {
        public System.Net.Http.HttpClient _client;
        public System.Net.IPEndPoint DefaultLoopbackEndpoint; // 0x8

        // ── Methods ──
        public void SkipLast(){} // RVA: 0x7FFAC2C68090
        public void GetAvailableTcpPort(){} // RVA: 0x7FFAC9D1EAA0
        public void GetAvailableUdpPort(){} // RVA: 0x7FFAC9D1EC50
        public void GetOSCTree(){} // RVA: 0x7FFAC9D1EE00
        public void GetHostInfo(){} // RVA: 0x7FFAC9D1EFA0
        public void ServeStaticFile(){} // RVA: 0x7FFAC9D1F140
        public void .cctor(){} // RVA: 0x7FFAC9D1F3C0
    }

    public class HostInfo : Object
    {
        public string name; // 0x10
        public System.Collections.Generic.Dictionary`2<string,bool> extensions; // 0x18
        public string oscIP; // 0x20
        public int oscPort; // 0x28
        public string oscTransport; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D20AE0
        public void ToString(){} // RVA: 0x7FFAC9D20D90
    }

    public class IDiscovery
    {
        // ── Methods ──
        public void RefreshServices(){} // RVA: 0x7FFAC2C70980
        public void add_OnOscServiceAdded(){} // RVA: 0x7FFAC2C70A40
        public void remove_OnOscServiceAdded(){} // RVA: 0x7FFAC2C70A40
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7FFAC2C70A40
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7FFAC2C70A40
        public void GetOSCQueryServices(){} // RVA: 0x7FFAC2C58E90
        public void GetOSCServices(){} // RVA: 0x7FFAC2C58E90
        public void Advertise(){} // RVA: 0x7FFAC2C70A40
        public void Unadvertise(){} // RVA: 0x7FFAC2C70A40
    }

    public class MeaModDiscovery : Object
    {
        public MeaMod.DNS.Multicast.ServiceDiscovery _discovery; // 0x10
        public MeaMod.DNS.Multicast.MulticastService _mdns; // 0x18
        public Microsoft.Extensions.Logging.ILogger`1<VRC.OSCQuery.OSCQueryService> Logger;
        public System.Collections.Generic.HashSet`1<VRC.OSCQuery.OSCQueryServiceProfile> _oscQueryServices; // 0x20
        public System.Collections.Generic.HashSet`1<VRC.OSCQuery.OSCQueryServiceProfile> _oscServices; // 0x28
        public System.Action`1<VRC.OSCQuery.OSCQueryServiceProfile> OnOscServiceAdded; // 0x30
        public System.Action`1<VRC.OSCQuery.OSCQueryServiceProfile> OnOscQueryServiceAdded; // 0x38
        public System.Collections.Generic.Dictionary`2<VRC.OSCQuery.OSCQueryServiceProfile,MeaMod.DNS.Multicast.ServiceProfile> _profiles; // 0x40

        // ── Methods ──
        public void GetOSCQueryServices(){} // RVA: 0x7FFAC2F4F0C0
        public void GetOSCServices(){} // RVA: 0x7FFAC2F4F130
        public void Dispose(){} // RVA: 0x7FFAC9D29D20
        public void .ctor(){} // RVA: 0x7FFAC9D29D70
        public void RefreshServices(){} // RVA: 0x7FFAC9D2A2E0
        public void add_OnOscServiceAdded(){} // RVA: 0x7FFAC9D2A460
        public void remove_OnOscServiceAdded(){} // RVA: 0x7FFAC9D2A560
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7FFAC9D2A660
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7FFAC9D2A760
        public void Advertise(){} // RVA: 0x7FFAC9D2A860
        public void Unadvertise(){} // RVA: 0x7FFAC9D2ABF0
        public void OnRemoteServiceInfo(){} // RVA: 0x7FFAC9D2AE60
        public void AddMatchedService(){} // RVA: 0x7FFAC9D2B4F0
        public void <.ctor>b__8_0(){} // RVA: 0x7FFAC9D2A2E0
    }

    public class OSCQueryHttpServer : Object
    {
        public System.Net.HttpListener PathToResources; // 0x10
        public bool _shouldProcessHttp; // 0x18
        public System.Collections.Generic.List`1<System.Func`3<System.Net.HttpListenerContext,System.Action,System.Threading.Tasks.Task>> _preMiddleware; // 0x20
        public System.Collections.Generic.List`1<System.Func`3<System.Net.HttpListenerContext,System.Action,System.Threading.Tasks.Task>> _middleware; // 0x28
        public System.Collections.Generic.List`1<System.Func`3<System.Net.HttpListenerContext,System.Action,System.Threading.Tasks.Task>> _postMiddleware; // 0x30
        public Microsoft.Extensions.Logging.ILogger`1<VRC.OSCQuery.OSCQueryService> Logger; // 0x38
        public VRC.OSCQuery.OSCQueryService _oscQuery; // 0x40
        public string _pathToResources;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D20DE0
        public void AddMiddleware(){} // RVA: 0x7FFAC9D214A0
        public void HttpListenerLoop(){} // RVA: 0x7FFAC9D21500
        public void HostInfoMiddleware(){} // RVA: 0x7FFAC9D21790
        public void get_PathToResources(){} // RVA: 0x7FFAC9D21A10
        public void ExplorerMiddleware(){} // RVA: 0x7FFAC9D21C60
        public void FaviconMiddleware(){} // RVA: 0x7FFAC9D21ED0
        public void RootNodeMiddleware(){} // RVA: 0x7FFAC9D22140
        public void Dispose(){} // RVA: 0x7FFAC9D22350
    }

    public class OSCQueryNode : Object
    {
        public string ParentPath; // 0x10
        public string Name; // 0x18
        public 0x6B2C9930 Access; // 0x20
        public System.Collections.Generic.Dictionary`2<string,VRC.OSCQuery.OSCQueryNode> Contents; // 0x28
        public string OscType; // 0x30
        public object[] Value; // 0x38
        public Newtonsoft.Json.JsonSerializerSettings WriteSettings;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F87E80 | overloaded x2
        public void get_ParentPath(){} // RVA: 0x7FFAC9D266B0
        public void get_Name(){} // RVA: 0x7FFAC9D26770
        public void ToString(){} // RVA: 0x7FFAC9D267C0
        public void AddConverter(){} // RVA: 0x7FFAC9D268F0
        public void .cctor(){} // RVA: 0x7FFAC9D26A00
    }

    public class OSCQueryRootNode : OSCQueryNode
    {
        public System.Collections.Generic.Dictionary`2<string,VRC.OSCQuery.OSCQueryNode> _pathLookup; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D25870
        public void GetNodeWithPath(){} // RVA: 0x7FFAC9D259C0
        public void AddNode(){} // RVA: 0x7FFAC9D25A50
        public void RemoveNode(){} // RVA: 0x7FFAC9D25EC0
        public void RebuildLookup(){} // RVA: 0x7FFAC9D260A0
        public void AddContents(){} // RVA: 0x7FFAC9D261C0
        public void FromString(){} // RVA: 0x7FFAC9D26550
    }

    public class OSCQueryService : Object
    {
        public int TcpPort; // 0x10
        public System.Net.IPAddress OscPort; // 0x18
        public System.Net.IPAddress ServerName; // 0x20
        public Microsoft.Extensions.Logging.ILogger`1<VRC.OSCQuery.OSCQueryService> HostIP;
        public System.Net.IPAddress OscIP; // 0x28
        public int Logger;
        public int LocalIp;
        public string Discovery;
        public string HostInfo; // 0x8
        public string RootNode; // 0x10
        public System.Collections.Generic.HashSet`1<string> MatchedNames; // 0x18
        public VRC.OSCQuery.IDiscovery _discovery; // 0x30
        public System.Action`1<VRC.OSCQuery.OSCQueryServiceProfile> OnOscServiceAdded; // 0x38
        public System.Action`1<VRC.OSCQuery.OSCQueryServiceProfile> OnOscQueryServiceAdded; // 0x40
        public VRC.OSCQuery.OSCQueryHttpServer _http; // 0x48
        public VRC.OSCQuery.HostInfo _hostInfo; // 0x50
        public VRC.OSCQuery.OSCQueryRootNode _rootNode; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D28980 | overloaded x2
        public void get_TcpPort(){} // RVA: 0x7FFAC2F6E5C0
        public void set_TcpPort(){} // RVA: 0x7FFAC2F240C0
        public void get_OscPort(){} // RVA: 0x7FFAC9D26C30
        public void set_OscPort(){} // RVA: 0x7FFAC9D26C50
        public void get_ServerName(){} // RVA: 0x7FFAC9D26C80
        public void set_ServerName(){} // RVA: 0x7FFAC9D26CA0
        public void get_HostIP(){} // RVA: 0x7FFAC2F247C0
        public void set_HostIP(){} // RVA: 0x7FFAC2F87E80
        public void get_OscIP(){} // RVA: 0x7FFAC2F4F0C0
        public void set_OscIP(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Logger(){} // RVA: 0x7FFAC9D26D10
        public void set_Logger(){} // RVA: 0x7FFAC9D26D70
        public void AddMiddleware(){} // RVA: 0x7FFAC9D26E20
        public void SetDiscovery(){} // RVA: 0x7FFAC9D26E80
        public void get_LocalIp(){} // RVA: 0x7FFAC9D26FC0
        public void get_Discovery(){} // RVA: 0x7FFAC9D271C0
        public void add_OnOscServiceAdded(){} // RVA: 0x7FFAC9D27320
        public void remove_OnOscServiceAdded(){} // RVA: 0x7FFAC9D27420
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7FFAC9D27520
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7FFAC9D27620
        public void GetOSCQueryServices(){} // RVA: 0x7FFAC9D27720
        public void GetOSCServices(){} // RVA: 0x7FFAC9D27780
        public void get_HostInfo(){} // RVA: 0x7FFAC9D277E0
        public void get_RootNode(){} // RVA: 0x7FFAC9D279E0
        public void StartHttpServer(){} // RVA: 0x7FFAC9D27A10
        public void AdvertiseOSCQueryService(){} // RVA: 0x7FFAC9D27B40
        public void AdvertiseOSCService(){} // RVA: 0x7FFAC9D27C40
        public void RefreshServices(){} // RVA: 0x7FFAC9D27D40
        public void SetValue(){} // RVA: 0x7FFAC9D27F50 | overloaded x2
        public void AddEndpoint(){} // RVA: 0x7FFAC9D280E0 | overloaded x2
        public void RemoveEndpoint(){} // RVA: 0x7FFAC9D28440
        public void BuildRootNode(){} // RVA: 0x7FFAC9D28590
        public void Dispose(){} // RVA: 0x7FFAC9D28840
        public void Finalize(){} // RVA: 0x7FFAC9D28940
        public void Initialize(){} // RVA: 0x7FFAC9D28D30
        public void StartOSCQueryService(){} // RVA: 0x7FFAC9D28E20
        public void .cctor(){} // RVA: 0x7FFAC9D28F50
        public void <SetDiscovery>b__24_0(){} // RVA: 0x7FFAC7870F30
        public void <SetDiscovery>b__24_1(){} // RVA: 0x7FFAC9A85940
    }

    public class OSCQueryServiceBuilder : Object
    {
        public VRC.OSCQuery.OSCQueryService _service; // 0x10
        public bool _customStartup; // 0x18

        // ── Methods ──
        public void Build(){} // RVA: 0x7FFAC9D29260
        public void WithDefaults(){} // RVA: 0x7FFAC9D29340
        public void WithTcpPort(){} // RVA: 0x7FFAC9D29420
        public void WithUdpPort(){} // RVA: 0x7FFAC9D29450
        public void WithHostIP(){} // RVA: 0x7FFAC9D29490
        public void WithOscIP(){} // RVA: 0x7FFAC9D29620
        public void StartHttpServer(){} // RVA: 0x7FFAC9D29690
        public void WithServiceName(){} // RVA: 0x7FFAC9D296C0
        public void WithLogger(){} // RVA: 0x7FFAC9D296F0
        public void WithMiddleware(){} // RVA: 0x7FFAC9D29750
        public void WithDiscovery(){} // RVA: 0x7FFAC9D297D0
        public void AddListenerForServiceType(){} // RVA: 0x7FFAC9D29800
        public void AdvertiseOSC(){} // RVA: 0x7FFAC9D29950
        public void AdvertiseOSCQuery(){} // RVA: 0x7FFAC9D299D0
        public void .ctor(){} // RVA: 0x7FFAC9D29A30
    }

    public class OSCQueryServiceProfile : Object
    {
        public int port; // 0x10
        public string name; // 0x18
        public System.Net.IPAddress address; // 0x20
        public 0x6B2CA170 serviceType; // 0x28

        // ── Methods ──
        public void GetServiceTypeString(){} // RVA: 0x7FFAC9D29BE0
        public void .ctor(){} // RVA: 0x7FFAC9D29C60
    }

}