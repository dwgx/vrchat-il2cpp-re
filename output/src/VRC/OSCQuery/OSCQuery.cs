// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.OSCQuery
// Classes: 7
// Methods: 78

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
        public void OSCTypeFor(){} // RVA: 0x7FFD5513E0A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD5513E220
    }

    public class Extensions : Object
    {
        public 0x66602840 _client;
        public 0x66499F70 DefaultLoopbackEndpoint; // 0x8

        // ── Methods ──
        public void SkipLast(){} // RVA: 0x7FFD4E088090
        public void GetAvailableTcpPort(){} // RVA: 0x7FFD5513EAA0
        public void GetAvailableUdpPort(){} // RVA: 0x7FFD5513EC50
        public void GetOSCTree(){} // RVA: 0x7FFD5513EE00
        public void GetHostInfo(){} // RVA: 0x7FFD5513EFA0
        public void ServeStaticFile(){} // RVA: 0x7FFD5513F140
        public void .cctor(){} // RVA: 0x7FFD5513F3C0
    }

    public class HostInfo : Object
    {
        public string name; // 0x10
        public System.Collections.Generic.Dictionary`2<string,bool> extensions; // 0x18
        public string oscIP; // 0x20
        public int oscPort; // 0x28
        public string oscTransport; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55140AE0
        public void ToString(){} // RVA: 0x7FFD55140D90
    }

    public class IDiscovery
    {
        // ── Methods ──
        public void RefreshServices(){} // RVA: 0x7FFD4E090980
        public void add_OnOscServiceAdded(){} // RVA: 0x7FFD4E090A40
        public void remove_OnOscServiceAdded(){} // RVA: 0x7FFD4E090A40
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7FFD4E090A40
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7FFD4E090A40
        public void GetOSCQueryServices(){} // RVA: 0x7FFD4E078E90
        public void GetOSCServices(){} // RVA: 0x7FFD4E078E90
        public void Advertise(){} // RVA: 0x7FFD4E090A40
        public void Unadvertise(){} // RVA: 0x7FFD4E090A40
    }

    public class OSCQueryNode : Object
    {
        public string ParentPath; // 0x10
        public string Name; // 0x18
        public 0x66629930 Access; // 0x20
        public System.Collections.Generic.Dictionary`2<string,VRC.OSCQuery.OSCQueryNode> Contents; // 0x28
        public string OscType; // 0x30
        public object[] Value; // 0x38
        public Newtonsoft.Json.JsonSerializerSettings WriteSettings;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3A7E80 | overloaded x2
        public void get_ParentPath(){} // RVA: 0x7FFD551466B0
        public void get_Name(){} // RVA: 0x7FFD55146770
        public void ToString(){} // RVA: 0x7FFD551467C0
        public void AddConverter(){} // RVA: 0x7FFD551468F0
        public void .cctor(){} // RVA: 0x7FFD55146A00
    }

    public class OSCQueryRootNode : OSCQueryNode
    {
        public System.Collections.Generic.Dictionary`2<string,VRC.OSCQuery.OSCQueryNode> _pathLookup; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55145870
        public void GetNodeWithPath(){} // RVA: 0x7FFD551459C0
        public void AddNode(){} // RVA: 0x7FFD55145A50
        public void RemoveNode(){} // RVA: 0x7FFD55145EC0
        public void RebuildLookup(){} // RVA: 0x7FFD551460A0
        public void AddContents(){} // RVA: 0x7FFD551461C0
        public void FromString(){} // RVA: 0x7FFD55146550
    }

    public class OSCQueryService : Object
    {
        public int TcpPort; // 0x10
        public 0x66499EC0 OscPort; // 0x18
        public 0x66499EC0 ServerName; // 0x20
        public Microsoft.Extensions.Logging.ILogger`1<VRC.OSCQuery.OSCQueryService> HostIP;
        public 0x66499EC0 OscIP; // 0x28
        public int Logger;
        public int LocalIp;
        public string Discovery;
        public string HostInfo; // 0x8
        public string RootNode; // 0x10
        public System.Collections.Generic.HashSet`1<string> MatchedNames; // 0x18
        public VRC.OSCQuery.IDiscovery _discovery; // 0x30
        public System.Action`1<ÎÏÌÍÎÏÌÍÎÍÎÏÎ.ÌÌÍÏÎÎÌÏÌÎ> OnOscServiceAdded; // 0x38
        public System.Action`1<ÎÏÌÍÎÏÌÍÎÍÎÏÎ.ÌÌÍÏÎÎÌÏÌÎ> OnOscQueryServiceAdded; // 0x40
        public ÎÏÌÍÎÏÌÍÎÍÎÏÎ.ÍÍÏÌÌÎÌÍÍÍÍ _http; // 0x48
        public VRC.OSCQuery.HostInfo _hostInfo; // 0x50
        public VRC.OSCQuery.OSCQueryRootNode _rootNode; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55148980 | overloaded x2
        public void get_TcpPort(){} // RVA: 0x7FFD4E38E5C0
        public void set_TcpPort(){} // RVA: 0x7FFD4E3440C0
        public void get_OscPort(){} // RVA: 0x7FFD55146C30
        public void set_OscPort(){} // RVA: 0x7FFD55146C50
        public void get_ServerName(){} // RVA: 0x7FFD55146C80
        public void set_ServerName(){} // RVA: 0x7FFD55146CA0
        public void get_HostIP(){} // RVA: 0x7FFD4E3447C0
        public void set_HostIP(){} // RVA: 0x7FFD4E3A7E80
        public void get_OscIP(){} // RVA: 0x7FFD4E36F0C0
        public void set_OscIP(){} // RVA: 0x7FFD4E36F0D0
        public void get_Logger(){} // RVA: 0x7FFD55146D10
        public void set_Logger(){} // RVA: 0x7FFD55146D70
        public void AddMiddleware(){} // RVA: 0x7FFD55146E20
        public void SetDiscovery(){} // RVA: 0x7FFD55146E80
        public void get_LocalIp(){} // RVA: 0x7FFD55146FC0
        public void get_Discovery(){} // RVA: 0x7FFD551471C0
        public void add_OnOscServiceAdded(){} // RVA: 0x7FFD55147320
        public void remove_OnOscServiceAdded(){} // RVA: 0x7FFD55147420
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7FFD55147520
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7FFD55147620
        public void GetOSCQueryServices(){} // RVA: 0x7FFD55147720
        public void GetOSCServices(){} // RVA: 0x7FFD55147780
        public void get_HostInfo(){} // RVA: 0x7FFD551477E0
        public void get_RootNode(){} // RVA: 0x7FFD551479E0
        public void StartHttpServer(){} // RVA: 0x7FFD55147A10
        public void AdvertiseOSCQueryService(){} // RVA: 0x7FFD55147B40
        public void AdvertiseOSCService(){} // RVA: 0x7FFD55147C40
        public void RefreshServices(){} // RVA: 0x7FFD55147D40
        public void SetValue(){} // RVA: 0x7FFD55147F50 | overloaded x2
        public void AddEndpoint(){} // RVA: 0x7FFD551480E0 | overloaded x2
        public void RemoveEndpoint(){} // RVA: 0x7FFD55148440
        public void BuildRootNode(){} // RVA: 0x7FFD55148590
        public void Dispose(){} // RVA: 0x7FFD55148840
        public void Finalize(){} // RVA: 0x7FFD55148940
        public void Initialize(){} // RVA: 0x7FFD55148D30
        public void StartOSCQueryService(){} // RVA: 0x7FFD55148E20
        public void .cctor(){} // RVA: 0x7FFD55148F50
        public void <SetDiscovery>b__24_0(){} // RVA: 0x7FFD52C90F30
        public void <SetDiscovery>b__24_1(){} // RVA: 0x7FFD54EA5940
    }

}