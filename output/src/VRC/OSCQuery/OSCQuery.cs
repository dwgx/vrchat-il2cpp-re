// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.OSCQuery
// Classes: 11
// Methods: 113

namespace VRC.OSCQuery
{
    public class Attributes : Object
    {
        // ── Methods ──
        public void OSCTypeFor(){} // RVA: 0x7AF364F90
        public void .cctor(){} // RVA: 0x7AF365110
    }

    public class Extensions : Object
    {
        // ── Methods ──
        public void SkipLast(){} // RVA: 0x7A7E0FCC0
        public void GetAvailableTcpPort(){} // RVA: 0x7AF365990
        public void GetAvailableUdpPort(){} // RVA: 0x7AF365B40
        public void GetOSCTree(){} // RVA: 0x7AF365CF0
        public void GetHostInfo(){} // RVA: 0x7AF365E90
        public void ServeStaticFile(){} // RVA: 0x7AF366030
        public void .cctor(){} // RVA: 0x7AF3662B0
    }

    public class HostInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF3679E0
        public void ToString(){} // RVA: 0x7AF367C90
    }

    public class IDiscovery
    {
        // ── Methods ──
        public void RefreshServices(){} // RVA: 0x7A7E18770
        public void add_OnOscServiceAdded(){} // RVA: 0x7A7E18800
        public void remove_OnOscServiceAdded(){} // RVA: 0x7A7E18800
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7A7E18800
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7A7E18800
        public void GetOSCQueryServices(){} // RVA: 0x7A7E00680
        public void GetOSCServices(){} // RVA: 0x7A7E00680
        public void Advertise(){} // RVA: 0x7A7E18800
        public void Unadvertise(){} // RVA: 0x7A7E18800
    }

    public class MeaModDiscovery : Object
    {
        // ── Methods ──
        public void GetOSCQueryServices(){} // RVA: 0x7A81052C0
        public void GetOSCServices(){} // RVA: 0x7A8105330
        public void Dispose(){} // RVA: 0x7AF370BC0
        public void .ctor(){} // RVA: 0x7AF370C10
        public void RefreshServices(){} // RVA: 0x7AF371180
        public void add_OnOscServiceAdded(){} // RVA: 0x7AF371300
        public void remove_OnOscServiceAdded(){} // RVA: 0x7AF371410
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7AF371520
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7AF371630
        public void Advertise(){} // RVA: 0x7AF371740
        public void Unadvertise(){} // RVA: 0x7AF371AD0
        public void OnRemoteServiceInfo(){} // RVA: 0x7AF371D40
        public void AddMatchedService(){} // RVA: 0x7AF3723D0
        public void <.ctor>b__8_0(){} // RVA: 0x7AF371180
    }

    public class OSCQueryHttpServer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF367CE0
        public void AddMiddleware(){} // RVA: 0x7AF3682A0
        public void HttpListenerLoop(){} // RVA: 0x7AF368300
        public void HostInfoMiddleware(){} // RVA: 0x7AF368590
        public void get_PathToResources(){} // RVA: 0x7AF368810
        public void ExplorerMiddleware(){} // RVA: 0x7AF368A60
        public void FaviconMiddleware(){} // RVA: 0x7AF368CD0
        public void RootNodeMiddleware(){} // RVA: 0x7AF368F40
        public void Dispose(){} // RVA: 0x7AF369150
    }

    public class OSCQueryNode : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A813E420
        public void get_ParentPath(){} // RVA: 0x7AF36D4E0
        public void get_Name(){} // RVA: 0x7AF36D5A0
        public void ToString(){} // RVA: 0x7AF36D5F0
        public void AddConverter(){} // RVA: 0x7AF36D720
        public void .cctor(){} // RVA: 0x7AF36D830
    }

    public class OSCQueryRootNode : OSCQueryNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF36C6A0
        public void GetNodeWithPath(){} // RVA: 0x7AF36C7F0
        public void AddNode(){} // RVA: 0x7AF36C880
        public void RemoveNode(){} // RVA: 0x7AF36CCF0
        public void RebuildLookup(){} // RVA: 0x7AF36CED0
        public void AddContents(){} // RVA: 0x7AF36CFF0
        public void FromString(){} // RVA: 0x7AF36D380
    }

    public class OSCQueryService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF36F820
        public void get_TcpPort(){} // RVA: 0x7A8124910
        public void set_TcpPort(){} // RVA: 0x7A80DA0C0
        public void get_OscPort(){} // RVA: 0x7AF36DA60
        public void set_OscPort(){} // RVA: 0x7AF36DA80
        public void get_ServerName(){} // RVA: 0x7AF36DAB0
        public void set_ServerName(){} // RVA: 0x7AF36DAD0
        public void get_HostIP(){} // RVA: 0x7A80DA7B0
        public void set_HostIP(){} // RVA: 0x7A813E420
        public void get_OscIP(){} // RVA: 0x7A81052C0
        public void set_OscIP(){} // RVA: 0x7A81052D0
        public void get_Logger(){} // RVA: 0x7AF36DB40
        public void set_Logger(){} // RVA: 0x7AF36DBA0
        public void AddMiddleware(){} // RVA: 0x7AF36DC50
        public void SetDiscovery(){} // RVA: 0x7AF36DCB0
        public void get_LocalIp(){} // RVA: 0x7AF36DDF0
        public void get_Discovery(){} // RVA: 0x7AF36DFF0
        public void add_OnOscServiceAdded(){} // RVA: 0x7AF36E150
        public void remove_OnOscServiceAdded(){} // RVA: 0x7AF36E260
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7AF36E370
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7AF36E480
        public void GetOSCQueryServices(){} // RVA: 0x7AF36E590
        public void GetOSCServices(){} // RVA: 0x7AF36E5F0
        public void get_HostInfo(){} // RVA: 0x7AF36E650
        public void get_RootNode(){} // RVA: 0x7AF36E850
        public void StartHttpServer(){} // RVA: 0x7AF36E880
        public void AdvertiseOSCQueryService(){} // RVA: 0x7AF36E9B0
        public void AdvertiseOSCService(){} // RVA: 0x7AF36EAB0
        public void RefreshServices(){} // RVA: 0x7AF36EBB0
        public void SetValue(){} // RVA: 0x7AF36EDD0
        public void AddEndpoint(){} // RVA: 0x7A7E03A70
        public void RemoveEndpoint(){} // RVA: 0x7AF36F2E0
        public void BuildRootNode(){} // RVA: 0x7AF36F430
        public void Dispose(){} // RVA: 0x7AF36F6E0
        public void Finalize(){} // RVA: 0x7AF36F7E0
        public void Initialize(){} // RVA: 0x7AF36FBD0
        public void StartOSCQueryService(){} // RVA: 0x7AF36FCC0
        public void .cctor(){} // RVA: 0x7AF36FDF0
        public void <SetDiscovery>b__24_0(){} // RVA: 0x7ACDEF340
        public void <SetDiscovery>b__24_1(){} // RVA: 0x7AF0CE230
    }

    public class OSCQueryServiceBuilder : Object
    {
        // ── Methods ──
        public void Build(){} // RVA: 0x7AF370100
        public void WithDefaults(){} // RVA: 0x7AF3701E0
        public void WithTcpPort(){} // RVA: 0x7AF3702C0
        public void WithUdpPort(){} // RVA: 0x7AF3702F0
        public void WithHostIP(){} // RVA: 0x7AF370330
        public void WithOscIP(){} // RVA: 0x7AF3704C0
        public void StartHttpServer(){} // RVA: 0x7AF370530
        public void WithServiceName(){} // RVA: 0x7AF370560
        public void WithLogger(){} // RVA: 0x7AF370590
        public void WithMiddleware(){} // RVA: 0x7AF3705F0
        public void WithDiscovery(){} // RVA: 0x7AF370670
        public void AddListenerForServiceType(){} // RVA: 0x7AF3706A0
        public void AdvertiseOSC(){} // RVA: 0x7AF3707F0
        public void AdvertiseOSCQuery(){} // RVA: 0x7AF370870
        public void .ctor(){} // RVA: 0x7AF3708D0
    }

    public class OSCQueryServiceProfile : Object
    {
        // ── Methods ──
        public void GetServiceTypeString(){} // RVA: 0x7AF370A80
        public void .ctor(){} // RVA: 0x7AF370B00
    }

}