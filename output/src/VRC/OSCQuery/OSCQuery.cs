// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.OSCQuery
// Classes: 11
// Methods: 118

namespace VRC.OSCQuery
{
    public class Attributes
    {
        // ── Methods ──
        public void OSCTypeFor(){} // RVA: 0x7586720 | overloaded x2
        public void .cctor(){} // RVA: 0x75868A0
    }

    public class Extensions
    {
        // ── Methods ──
        public void SkipLast(){} // RVA: 0x1BF70
        public void GetAvailableTcpPort(){} // RVA: 0x7587120
        public void GetAvailableUdpPort(){} // RVA: 0x75872D0
        public void GetOSCTree(){} // RVA: 0x7587480
        public void GetHostInfo(){} // RVA: 0x7587620
        public void ServeStaticFile(){} // RVA: 0x75877C0
        public void .cctor(){} // RVA: 0x7587A40
    }

    public class HostInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7589160
        public void ToString(){} // RVA: 0x7589410
    }

    public class IDiscovery
    {
        // ── Methods ──
        public void RefreshServices(){} // RVA: 0x24A50
        public void add_OnOscServiceAdded(){} // RVA: 0x24B10
        public void remove_OnOscServiceAdded(){} // RVA: 0x24B10
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x24B10
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x24B10
        public void GetOSCQueryServices(){} // RVA: 0xCD60
        public void GetOSCServices(){} // RVA: 0xCD60
        public void Advertise(){} // RVA: 0x24B10
        public void Unadvertise(){} // RVA: 0x24B10
    }

    public class MeaModDiscovery
    {
        // ── Methods ──
        public void GetOSCQueryServices(){} // RVA: 0x30B0C0
        public void GetOSCServices(){} // RVA: 0x30B130
        public void Dispose(){} // RVA: 0x75922A0
        public void .ctor(){} // RVA: 0x75922F0
        public void RefreshServices(){} // RVA: 0x7592860
        public void add_OnOscServiceAdded(){} // RVA: 0x75929E0
        public void remove_OnOscServiceAdded(){} // RVA: 0x7592AE0
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7592BE0
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7592CE0
        public void Advertise(){} // RVA: 0x7592DE0
        public void Unadvertise(){} // RVA: 0x7593170
        public void OnRemoteServiceInfo(){} // RVA: 0x75933E0
        public void AddMatchedService(){} // RVA: 0x7593A70
        public void <.ctor>b__8_0(){} // RVA: 0x7592860
    }

    public class OSCQueryHttpServer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7589460
        public void AddMiddleware(){} // RVA: 0x7589A20
        public void HttpListenerLoop(){} // RVA: 0x7589A80
        public void HostInfoMiddleware(){} // RVA: 0x7589D10
        public void get_PathToResources(){} // RVA: 0x7589F90
        public void ExplorerMiddleware(){} // RVA: 0x758A1E0
        public void FaviconMiddleware(){} // RVA: 0x758A450
        public void RootNodeMiddleware(){} // RVA: 0x758A6C0
        public void Dispose(){} // RVA: 0x758A8D0
    }

    public class OSCQueryNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x343E80 | overloaded x2
        public void get_ParentPath(){} // RVA: 0x758EC30
        public void get_Name(){} // RVA: 0x758ECF0
        public void ToString(){} // RVA: 0x758ED40
        public void AddConverter(){} // RVA: 0x758EE70
        public void .cctor(){} // RVA: 0x758EF80
    }

    public class OSCQueryRootNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x758DDF0
        public void GetNodeWithPath(){} // RVA: 0x758DF40
        public void AddNode(){} // RVA: 0x758DFD0
        public void RemoveNode(){} // RVA: 0x758E440
        public void RebuildLookup(){} // RVA: 0x758E620
        public void AddContents(){} // RVA: 0x758E740
        public void FromString(){} // RVA: 0x758EAD0
    }

    public class OSCQueryService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7590F00 | overloaded x2
        public void get_TcpPort(){} // RVA: 0x32A5C0
        public void set_TcpPort(){} // RVA: 0x2E00C0
        public void get_OscPort(){} // RVA: 0x758F1B0
        public void set_OscPort(){} // RVA: 0x758F1D0
        public void get_ServerName(){} // RVA: 0x758F200
        public void set_ServerName(){} // RVA: 0x758F220
        public void get_HostIP(){} // RVA: 0x2E07C0
        public void set_HostIP(){} // RVA: 0x343E80
        public void get_OscIP(){} // RVA: 0x30B0C0
        public void set_OscIP(){} // RVA: 0x30B0D0
        public void get_Logger(){} // RVA: 0x758F290
        public void set_Logger(){} // RVA: 0x758F2F0
        public void AddMiddleware(){} // RVA: 0x758F3A0
        public void SetDiscovery(){} // RVA: 0x758F400
        public void get_LocalIp(){} // RVA: 0x758F540
        public void get_Discovery(){} // RVA: 0x758F740
        public void add_OnOscServiceAdded(){} // RVA: 0x758F8A0
        public void remove_OnOscServiceAdded(){} // RVA: 0x758F9A0
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x758FAA0
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x758FBA0
        public void GetOSCQueryServices(){} // RVA: 0x758FCA0
        public void GetOSCServices(){} // RVA: 0x758FD00
        public void get_HostInfo(){} // RVA: 0x758FD60
        public void get_RootNode(){} // RVA: 0x758FF60
        public void StartHttpServer(){} // RVA: 0x758FF90
        public void AdvertiseOSCQueryService(){} // RVA: 0x75900C0
        public void AdvertiseOSCService(){} // RVA: 0x75901C0
        public void RefreshServices(){} // RVA: 0x75902C0
        public void SetValue(){} // RVA: 0x75904D0 | overloaded x2
        public void AddEndpoint(){} // RVA: 0x7590660 | overloaded x2
        public void RemoveEndpoint(){} // RVA: 0x75909C0
        public void BuildRootNode(){} // RVA: 0x7590B10
        public void Dispose(){} // RVA: 0x7590DC0
        public void Finalize(){} // RVA: 0x7590EC0
        public void Initialize(){} // RVA: 0x75912B0
        public void StartOSCQueryService(){} // RVA: 0x75913A0
        public void .cctor(){} // RVA: 0x75914D0
        public void <SetDiscovery>b__24_0(){} // RVA: 0x4EEA9A0
        public void <SetDiscovery>b__24_1(){} // RVA: 0x72EE060
    }

    public class OSCQueryServiceBuilder
    {
        // ── Methods ──
        public void Build(){} // RVA: 0x75917E0
        public void WithDefaults(){} // RVA: 0x75918C0
        public void WithTcpPort(){} // RVA: 0x75919A0
        public void WithUdpPort(){} // RVA: 0x75919D0
        public void WithHostIP(){} // RVA: 0x7591A10
        public void WithOscIP(){} // RVA: 0x7591BA0
        public void StartHttpServer(){} // RVA: 0x7591C10
        public void WithServiceName(){} // RVA: 0x7591C40
        public void WithLogger(){} // RVA: 0x7591C70
        public void WithMiddleware(){} // RVA: 0x7591CD0
        public void WithDiscovery(){} // RVA: 0x7591D50
        public void AddListenerForServiceType(){} // RVA: 0x7591D80
        public void AdvertiseOSC(){} // RVA: 0x7591ED0
        public void AdvertiseOSCQuery(){} // RVA: 0x7591F50
        public void .ctor(){} // RVA: 0x7591FB0
    }

    public class OSCQueryServiceProfile
    {
        // ── Methods ──
        public void GetServiceTypeString(){} // RVA: 0x7592160
        public void .ctor(){} // RVA: 0x75921E0
    }

}