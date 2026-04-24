// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.OSCQuery
// Classes: 7
// Methods: 78

namespace VRC.OSCQuery
{
    public class Attributes : Object
    {
        public object HOST_INFO; // 0x31642400
        public object ACCESS; // 0x31642400
        public object DESCRIPTION; // 0x31642400
        public object OVERLOADS; // 0x31642400
        public object UNIT; // 0x31642400
        public object SERVICE_OSC_UDP; // 0x31642400
        public object SetStateMachine; // 0xB3F6FFF0

        // ── Original Methods ──
        public void OSCTypeFor(){} // RVA: 0x7ffaaf740010
        public void OSCTypeFor(){} // RVA: 0x7ffaaf740010
        public void .cctor(){} // RVA: 0x7ffaaf740190
    }

    public class Extensions : Object
    {
        // ── Original Methods ──
        public void SkipLast(){} // RVA: 0x7ffaa86583d0
        public void ServeStaticFile(){} // RVA: 0x7ffaaf7410b0
        public void .cctor(){} // RVA: 0x7ffaaf741330
        // ── Binary Analysis Named ──
        public void GetAvailableTcpPort(){} // RVA: 0x7ffaaf740a10
        public void GetAvailableUdpPort(){} // RVA: 0x7ffaaf740bc0
        public void GetOSCTree(){} // RVA: 0x7ffaaf740d70
        public void GetHostInfo(){} // RVA: 0x7ffaaf740f10
    }

    public class HostInfo : Object
    {
        public object oscIP; // 0x3429E850
        public object _hostInfo; // 0x319BF490, was: ÌÎÌÏÍÎÎÍÎÏÎÍÍÎÏÏÌÍÍÌÌÎÏ

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf742a50
        public void ToString(){} // RVA: 0x7ffaaf742d00
    }

    public class IDiscovery
    {
        // ── Original Methods ──
        public void RefreshServices(){} // RVA: 0x7ffaa8660cc0
        public void add_OnOscServiceAdded(){} // RVA: 0x7ffaa8660d80
        public void remove_OnOscServiceAdded(){} // RVA: 0x7ffaa8660d80
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7ffaa8660d80
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7ffaa8660d80
        public void Advertise(){} // RVA: 0x7ffaa8660d80
        public void Unadvertise(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void GetOSCQueryServices(){} // RVA: 0x7ffaa86491d0
        public void GetOSCServices(){} // RVA: 0x7ffaa86491d0
    }

    public class OSCQueryNode : Object
    {
        public object Access; // 0x3429E6D0
        public object Value; // 0x3429E6D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaa8998e80
        public void get_ParentPath(){} // RVA: 0x7ffaaf748620
        public void get_Name(){} // RVA: 0x7ffaaf7486e0
        public void ToString(){} // RVA: 0x7ffaaf748730
        public void AddConverter(){} // RVA: 0x7ffaaf748860
        public void .cctor(){} // RVA: 0x7ffaaf748970
    }

    public class OSCQueryRootNode : OSCQueryNode
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf7477e0
        public void AddNode(){} // RVA: 0x7ffaaf7479c0
        public void RemoveNode(){} // RVA: 0x7ffaaf747e30
        public void RebuildLookup(){} // RVA: 0x7ffaaf748010
        public void AddContents(){} // RVA: 0x7ffaaf748130
        public void FromString(){} // RVA: 0x7ffaaf7484c0
        // ── Binary Analysis Named ──
        public void GetNodeWithPath(){} // RVA: 0x7ffaaf747930
    }

    public class OSCQueryService : Object
    {
        public object _oscIP; // 0x318336C0, was: <OscIP>k__BackingField
        public object DefaultPortHttp; // 0x318336C0
        public object _localOscUdpServiceName; // 0x318336C0
        public object _discovery; // 0x318336C0
        public object _http; // 0x318336C0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf74a8f0
        public void get_TcpPort(){} // RVA: 0x7ffaa897f5c0
        public void set_TcpPort(){} // RVA: 0x7ffaa89350c0
        public void get_OscPort(){} // RVA: 0x7ffaaf748ba0
        public void set_OscPort(){} // RVA: 0x7ffaaf748bc0
        public void get_ServerName(){} // RVA: 0x7ffaaf748bf0
        public void set_ServerName(){} // RVA: 0x7ffaaf748c10
        public void get_HostIP(){} // RVA: 0x7ffaa89357c0
        public void set_HostIP(){} // RVA: 0x7ffaa8998e80
        public void get_OscIP(){} // RVA: 0x7ffaa89600c0
        public void set_OscIP(){} // RVA: 0x7ffaa89600d0
        public void get_Logger(){} // RVA: 0x7ffaaf748c80
        public void set_Logger(){} // RVA: 0x7ffaaf748ce0
        public void AddMiddleware(){} // RVA: 0x7ffaaf748d90
        public void get_LocalIp(){} // RVA: 0x7ffaaf748f30
        public void get_Discovery(){} // RVA: 0x7ffaaf749130
        public void add_OnOscServiceAdded(){} // RVA: 0x7ffaaf749290
        public void remove_OnOscServiceAdded(){} // RVA: 0x7ffaaf749390
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7ffaaf749490
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7ffaaf749590
        public void get_HostInfo(){} // RVA: 0x7ffaaf749750
        public void get_RootNode(){} // RVA: 0x7ffaaf749950
        public void StartHttpServer(){} // RVA: 0x7ffaaf749980
        public void AdvertiseOSCQueryService(){} // RVA: 0x7ffaaf749ab0
        public void AdvertiseOSCService(){} // RVA: 0x7ffaaf749bb0
        public void RefreshServices(){} // RVA: 0x7ffaaf749cb0
        public void AddEndpoint(){} // RVA: 0x7ffaaf74a050
        public void AddEndpoint(){} // RVA: 0x7ffaaf74a050
        public void RemoveEndpoint(){} // RVA: 0x7ffaaf74a3b0
        public void BuildRootNode(){} // RVA: 0x7ffaaf74a500
        public void Dispose(){} // RVA: 0x7ffaaf74a7b0
        public void Finalize(){} // RVA: 0x7ffaaf74a8b0
        public void .ctor(){} // RVA: 0x7ffaaf74a8f0
        public void Initialize(){} // RVA: 0x7ffaaf74aca0
        public void StartOSCQueryService(){} // RVA: 0x7ffaaf74ad90
        public void .cctor(){} // RVA: 0x7ffaaf74aec0
        public void <SetDiscovery>b__24_0(){} // RVA: 0x7ffaad0b8810
        public void <SetDiscovery>b__24_1(){} // RVA: 0x7ffaaf4a78a0
        // ── Binary Analysis Named ──
        public void SetDiscovery(){} // RVA: 0x7ffaaf748df0
        public void GetOSCQueryServices(){} // RVA: 0x7ffaaf749690
        public void GetOSCServices(){} // RVA: 0x7ffaaf7496f0
        public void SetValue(){} // RVA: 0x7ffaaf749ec0
        public void SetValue(){} // RVA: 0x7ffaaf749ec0
    }

}