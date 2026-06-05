// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.OSCQuery
// Classes: 11
// Methods: 118

namespace VRC.OSCQuery
{
    public class Attributes
    {
        // ── Methods ──
        public void OSCTypeFor(){} // RVA: 0x7FFAFA036720 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAFA0368A0
    }

    public class Extensions
    {
        // ── Methods ──
        public void SkipLast(){} // RVA: 0x7FFAF2ACBF70
        public void GetAvailableTcpPort(){} // RVA: 0x7FFAFA037120
        public void GetAvailableUdpPort(){} // RVA: 0x7FFAFA0372D0
        public void GetOSCTree(){} // RVA: 0x7FFAFA037480
        public void GetHostInfo(){} // RVA: 0x7FFAFA037620
        public void ServeStaticFile(){} // RVA: 0x7FFAFA0377C0
        public void .cctor(){} // RVA: 0x7FFAFA037A40
    }

    public class HostInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA039160
        public void ToString(){} // RVA: 0x7FFAFA039410
    }

    public class IDiscovery
    {
        // ── Methods ──
        public void RefreshServices(){} // RVA: 0x7FFAF2AD4A50
        public void add_OnOscServiceAdded(){} // RVA: 0x7FFAF2AD4B10
        public void remove_OnOscServiceAdded(){} // RVA: 0x7FFAF2AD4B10
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7FFAF2AD4B10
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7FFAF2AD4B10
        public void GetOSCQueryServices(){} // RVA: 0x7FFAF2ABCD60
        public void GetOSCServices(){} // RVA: 0x7FFAF2ABCD60
        public void Advertise(){} // RVA: 0x7FFAF2AD4B10
        public void Unadvertise(){} // RVA: 0x7FFAF2AD4B10
    }

    public class MeaModDiscovery
    {
        // ── Methods ──
        public void GetOSCQueryServices(){} // RVA: 0x7FFAF2DBB0C0
        public void GetOSCServices(){} // RVA: 0x7FFAF2DBB130
        public void Dispose(){} // RVA: 0x7FFAFA0422A0
        public void .ctor(){} // RVA: 0x7FFAFA0422F0
        public void RefreshServices(){} // RVA: 0x7FFAFA042860
        public void add_OnOscServiceAdded(){} // RVA: 0x7FFAFA0429E0
        public void remove_OnOscServiceAdded(){} // RVA: 0x7FFAFA042AE0
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7FFAFA042BE0
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7FFAFA042CE0
        public void Advertise(){} // RVA: 0x7FFAFA042DE0
        public void Unadvertise(){} // RVA: 0x7FFAFA043170
        public void OnRemoteServiceInfo(){} // RVA: 0x7FFAFA0433E0
        public void AddMatchedService(){} // RVA: 0x7FFAFA043A70
        public void <.ctor>b__8_0(){} // RVA: 0x7FFAFA042860
    }

    public class OSCQueryHttpServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA039460
        public void AddMiddleware(){} // RVA: 0x7FFAFA039A20
        public void HttpListenerLoop(){} // RVA: 0x7FFAFA039A80
        public void HostInfoMiddleware(){} // RVA: 0x7FFAFA039D10
        public void get_PathToResources(){} // RVA: 0x7FFAFA039F90
        public void ExplorerMiddleware(){} // RVA: 0x7FFAFA03A1E0
        public void FaviconMiddleware(){} // RVA: 0x7FFAFA03A450
        public void RootNodeMiddleware(){} // RVA: 0x7FFAFA03A6C0
        public void Dispose(){} // RVA: 0x7FFAFA03A8D0
    }

    public class OSCQueryNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DF3E80 | overloaded x2
        public void get_ParentPath(){} // RVA: 0x7FFAFA03EC30
        public void get_Name(){} // RVA: 0x7FFAFA03ECF0
        public void ToString(){} // RVA: 0x7FFAFA03ED40
        public void AddConverter(){} // RVA: 0x7FFAFA03EE70
        public void .cctor(){} // RVA: 0x7FFAFA03EF80
    }

    public class OSCQueryRootNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA03DDF0
        public void GetNodeWithPath(){} // RVA: 0x7FFAFA03DF40
        public void AddNode(){} // RVA: 0x7FFAFA03DFD0
        public void RemoveNode(){} // RVA: 0x7FFAFA03E440
        public void RebuildLookup(){} // RVA: 0x7FFAFA03E620
        public void AddContents(){} // RVA: 0x7FFAFA03E740
        public void FromString(){} // RVA: 0x7FFAFA03EAD0
    }

    public class OSCQueryService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA040F00 | overloaded x2
        public void get_TcpPort(){} // RVA: 0x7FFAF2DDA5C0
        public void set_TcpPort(){} // RVA: 0x7FFAF2D900C0
        public void get_OscPort(){} // RVA: 0x7FFAFA03F1B0
        public void set_OscPort(){} // RVA: 0x7FFAFA03F1D0
        public void get_ServerName(){} // RVA: 0x7FFAFA03F200
        public void set_ServerName(){} // RVA: 0x7FFAFA03F220
        public void get_HostIP(){} // RVA: 0x7FFAF2D907C0
        public void set_HostIP(){} // RVA: 0x7FFAF2DF3E80
        public void get_OscIP(){} // RVA: 0x7FFAF2DBB0C0
        public void set_OscIP(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Logger(){} // RVA: 0x7FFAFA03F290
        public void set_Logger(){} // RVA: 0x7FFAFA03F2F0
        public void AddMiddleware(){} // RVA: 0x7FFAFA03F3A0
        public void SetDiscovery(){} // RVA: 0x7FFAFA03F400
        public void get_LocalIp(){} // RVA: 0x7FFAFA03F540
        public void get_Discovery(){} // RVA: 0x7FFAFA03F740
        public void add_OnOscServiceAdded(){} // RVA: 0x7FFAFA03F8A0
        public void remove_OnOscServiceAdded(){} // RVA: 0x7FFAFA03F9A0
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7FFAFA03FAA0
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7FFAFA03FBA0
        public void GetOSCQueryServices(){} // RVA: 0x7FFAFA03FCA0
        public void GetOSCServices(){} // RVA: 0x7FFAFA03FD00
        public void get_HostInfo(){} // RVA: 0x7FFAFA03FD60
        public void get_RootNode(){} // RVA: 0x7FFAFA03FF60
        public void StartHttpServer(){} // RVA: 0x7FFAFA03FF90
        public void AdvertiseOSCQueryService(){} // RVA: 0x7FFAFA0400C0
        public void AdvertiseOSCService(){} // RVA: 0x7FFAFA0401C0
        public void RefreshServices(){} // RVA: 0x7FFAFA0402C0
        public void SetValue(){} // RVA: 0x7FFAFA0404D0 | overloaded x2
        public void AddEndpoint(){} // RVA: 0x7FFAFA040660 | overloaded x2
        public void RemoveEndpoint(){} // RVA: 0x7FFAFA0409C0
        public void BuildRootNode(){} // RVA: 0x7FFAFA040B10
        public void Dispose(){} // RVA: 0x7FFAFA040DC0
        public void Finalize(){} // RVA: 0x7FFAFA040EC0
        public void Initialize(){} // RVA: 0x7FFAFA0412B0
        public void StartOSCQueryService(){} // RVA: 0x7FFAFA0413A0
        public void .cctor(){} // RVA: 0x7FFAFA0414D0
        public void <SetDiscovery>b__24_0(){} // RVA: 0x7FFAF799A9A0
        public void <SetDiscovery>b__24_1(){} // RVA: 0x7FFAF9D9E060
    }

    public class OSCQueryServiceBuilder
    {
        // ── Methods ──
        public void Build(){} // RVA: 0x7FFAFA0417E0
        public void WithDefaults(){} // RVA: 0x7FFAFA0418C0
        public void WithTcpPort(){} // RVA: 0x7FFAFA0419A0
        public void WithUdpPort(){} // RVA: 0x7FFAFA0419D0
        public void WithHostIP(){} // RVA: 0x7FFAFA041A10
        public void WithOscIP(){} // RVA: 0x7FFAFA041BA0
        public void StartHttpServer(){} // RVA: 0x7FFAFA041C10
        public void WithServiceName(){} // RVA: 0x7FFAFA041C40
        public void WithLogger(){} // RVA: 0x7FFAFA041C70
        public void WithMiddleware(){} // RVA: 0x7FFAFA041CD0
        public void WithDiscovery(){} // RVA: 0x7FFAFA041D50
        public void AddListenerForServiceType(){} // RVA: 0x7FFAFA041D80
        public void AdvertiseOSC(){} // RVA: 0x7FFAFA041ED0
        public void AdvertiseOSCQuery(){} // RVA: 0x7FFAFA041F50
        public void .ctor(){} // RVA: 0x7FFAFA041FB0
    }

    public class OSCQueryServiceProfile
    {
        // ── Methods ──
        public void GetServiceTypeString(){} // RVA: 0x7FFAFA042160
        public void .ctor(){} // RVA: 0x7FFAFA0421E0
    }

}