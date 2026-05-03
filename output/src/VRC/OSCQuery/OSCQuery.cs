// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.OSCQuery
// Classes: 11
// Methods: 118

namespace VRC.OSCQuery
{
    public class Attributes : Object
    {
        // ── Methods ──
        public void OSCTypeFor(){} // RVA: 0x7FFE880C68B0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE880C6A30
    }

    public class Extensions : Object
    {
        // ── Methods ──
        public void SkipLast(){} // RVA: 0x7FFE80E3D4E0
        public void GetAvailableTcpPort(){} // RVA: 0x7FFE880C72B0
        public void GetAvailableUdpPort(){} // RVA: 0x7FFE880C7460
        public void GetOSCTree(){} // RVA: 0x7FFE880C7610
        public void GetHostInfo(){} // RVA: 0x7FFE880C77B0
        public void ServeStaticFile(){} // RVA: 0x7FFE880C7950
        public void .cctor(){} // RVA: 0x7FFE880C7BD0
    }

    public class HostInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880C92F0
        public void ToString(){} // RVA: 0x7FFE880C95A0
    }

    public class IDiscovery
    {
        // ── Methods ──
        public void RefreshServices(){} // RVA: 0x7FFE80E45FE0
        public void add_OnOscServiceAdded(){} // RVA: 0x7FFE80E460A0
        public void remove_OnOscServiceAdded(){} // RVA: 0x7FFE80E460A0
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7FFE80E460A0
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7FFE80E460A0
        public void GetOSCQueryServices(){} // RVA: 0x7FFE80E2E2E0
        public void GetOSCServices(){} // RVA: 0x7FFE80E2E2E0
        public void Advertise(){} // RVA: 0x7FFE80E460A0
        public void Unadvertise(){} // RVA: 0x7FFE80E460A0
    }

    public class MeaModDiscovery : Object
    {
        // ── Methods ──
        public void GetOSCQueryServices(){} // RVA: 0x7FFE811290C0
        public void GetOSCServices(){} // RVA: 0x7FFE81129130
        public void Dispose(){} // RVA: 0x7FFE880D2530
        public void .ctor(){} // RVA: 0x7FFE880D2580
        public void RefreshServices(){} // RVA: 0x7FFE880D2AF0
        public void add_OnOscServiceAdded(){} // RVA: 0x7FFE880D2C70
        public void remove_OnOscServiceAdded(){} // RVA: 0x7FFE880D2D70
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7FFE880D2E70
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7FFE880D2F70
        public void Advertise(){} // RVA: 0x7FFE880D3070
        public void Unadvertise(){} // RVA: 0x7FFE880D3400
        public void OnRemoteServiceInfo(){} // RVA: 0x7FFE880D3670
        public void AddMatchedService(){} // RVA: 0x7FFE880D3D00
        public void <.ctor>b__8_0(){} // RVA: 0x7FFE880D2AF0
    }

    public class OSCQueryHttpServer : Object
    {
        public System.Net.HttpListener _listener; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880C95F0
        public void AddMiddleware(){} // RVA: 0x7FFE880C9CB0
        public void HttpListenerLoop(){} // RVA: 0x7FFE880C9D10
        public void HostInfoMiddleware(){} // RVA: 0x7FFE880C9FA0
        public void get_PathToResources(){} // RVA: 0x7FFE880CA220
        public void ExplorerMiddleware(){} // RVA: 0x7FFE880CA470
        public void FaviconMiddleware(){} // RVA: 0x7FFE880CA6E0
        public void RootNodeMiddleware(){} // RVA: 0x7FFE880CA950
        public void Dispose(){} // RVA: 0x7FFE880CAB60
    }

    public class OSCQueryNode : Object
    {
        public string Description; // 0x10
        public string FullPath; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81161E80 | overloaded x2
        public void get_ParentPath(){} // RVA: 0x7FFE880CEEC0
        public void get_Name(){} // RVA: 0x7FFE880CEF80
        public void ToString(){} // RVA: 0x7FFE880CEFD0
        public void AddConverter(){} // RVA: 0x7FFE880CF100
        public void .cctor(){} // RVA: 0x7FFE880CF210
    }

    public class OSCQueryRootNode : OSCQueryNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880CE080
        public void GetNodeWithPath(){} // RVA: 0x7FFE880CE1D0
        public void AddNode(){} // RVA: 0x7FFE880CE260
        public void RemoveNode(){} // RVA: 0x7FFE880CE6D0
        public void RebuildLookup(){} // RVA: 0x7FFE880CE8B0
        public void AddContents(){} // RVA: 0x7FFE880CE9D0
        public void FromString(){} // RVA: 0x7FFE880CED60
    }

    public class OSCQueryService : Object
    {
        public int _tcpPort; // 0x10
        public System.Net.IPAddress _hostIP; // 0x18
        public System.Net.IPAddress _oscIP; // 0x20
        public Microsoft.Extensions.Logging.ILogger`1<VRC.OSCQuery.OSCQueryService> _logger;
        public System.Net.IPAddress _localIp; // 0x28
        public int DefaultPortHttp;
        public int DefaultPortOsc;
        public string DefaultServerName;
        public string _localOscUdpServiceName; // 0x8
        public string _localOscJsonServiceName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880D1190 | overloaded x2
        public void get_TcpPort(){} // RVA: 0x7FFE811485C0
        public void set_TcpPort(){} // RVA: 0x7FFE810FE0C0
        public void get_OscPort(){} // RVA: 0x7FFE880CF440
        public void set_OscPort(){} // RVA: 0x7FFE880CF460
        public void get_ServerName(){} // RVA: 0x7FFE880CF490
        public void set_ServerName(){} // RVA: 0x7FFE880CF4B0
        public void get_HostIP(){} // RVA: 0x7FFE810FE7C0
        public void set_HostIP(){} // RVA: 0x7FFE81161E80
        public void get_OscIP(){} // RVA: 0x7FFE811290C0
        public void set_OscIP(){} // RVA: 0x7FFE811290D0
        public void get_Logger(){} // RVA: 0x7FFE880CF520
        public void set_Logger(){} // RVA: 0x7FFE880CF580
        public void AddMiddleware(){} // RVA: 0x7FFE880CF630
        public void SetDiscovery(){} // RVA: 0x7FFE880CF690
        public void get_LocalIp(){} // RVA: 0x7FFE880CF7D0
        public void get_Discovery(){} // RVA: 0x7FFE880CF9D0
        public void add_OnOscServiceAdded(){} // RVA: 0x7FFE880CFB30
        public void remove_OnOscServiceAdded(){} // RVA: 0x7FFE880CFC30
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7FFE880CFD30
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7FFE880CFE30
        public void GetOSCQueryServices(){} // RVA: 0x7FFE880CFF30
        public void GetOSCServices(){} // RVA: 0x7FFE880CFF90
        public void get_HostInfo(){} // RVA: 0x7FFE880CFFF0
        public void get_RootNode(){} // RVA: 0x7FFE880D01F0
        public void StartHttpServer(){} // RVA: 0x7FFE880D0220
        public void AdvertiseOSCQueryService(){} // RVA: 0x7FFE880D0350
        public void AdvertiseOSCService(){} // RVA: 0x7FFE880D0450
        public void RefreshServices(){} // RVA: 0x7FFE880D0550
        public void SetValue(){} // RVA: 0x7FFE880D0760 | overloaded x2
        public void AddEndpoint(){} // RVA: 0x7FFE880D08F0 | overloaded x2
        public void RemoveEndpoint(){} // RVA: 0x7FFE880D0C50
        public void BuildRootNode(){} // RVA: 0x7FFE880D0DA0
        public void Dispose(){} // RVA: 0x7FFE880D1050
        public void Finalize(){} // RVA: 0x7FFE880D1150
        public void Initialize(){} // RVA: 0x7FFE880D1540
        public void StartOSCQueryService(){} // RVA: 0x7FFE880D1630
        public void .cctor(){} // RVA: 0x7FFE880D1760
        public void <SetDiscovery>b__24_0(){} // RVA: 0x7FFE85C283E0
        public void <SetDiscovery>b__24_1(){} // RVA: 0x7FFE87E2E1E0
    }

    public class OSCQueryServiceBuilder : Object
    {
        // ── Methods ──
        public void Build(){} // RVA: 0x7FFE880D1A70
        public void WithDefaults(){} // RVA: 0x7FFE880D1B50
        public void WithTcpPort(){} // RVA: 0x7FFE880D1C30
        public void WithUdpPort(){} // RVA: 0x7FFE880D1C60
        public void WithHostIP(){} // RVA: 0x7FFE880D1CA0
        public void WithOscIP(){} // RVA: 0x7FFE880D1E30
        public void StartHttpServer(){} // RVA: 0x7FFE880D1EA0
        public void WithServiceName(){} // RVA: 0x7FFE880D1ED0
        public void WithLogger(){} // RVA: 0x7FFE880D1F00
        public void WithMiddleware(){} // RVA: 0x7FFE880D1F60
        public void WithDiscovery(){} // RVA: 0x7FFE880D1FE0
        public void AddListenerForServiceType(){} // RVA: 0x7FFE880D2010
        public void AdvertiseOSC(){} // RVA: 0x7FFE880D2160
        public void AdvertiseOSCQuery(){} // RVA: 0x7FFE880D21E0
        public void .ctor(){} // RVA: 0x7FFE880D2240
    }

    public class OSCQueryServiceProfile : Object
    {
        // ── Methods ──
        public void GetServiceTypeString(){} // RVA: 0x7FFE880D23F0
        public void .ctor(){} // RVA: 0x7FFE880D2470
    }

}