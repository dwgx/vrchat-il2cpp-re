// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Multicast
// Classes: 9
// Methods: 112

namespace ThirdParty.Other.MeaMod.DNS.Multicast
{
    public class MessageEventArgs
    {
        // ── Methods ──
        public void get_Message(){} // RVA: 0x7FFAF2DA8380
        public void set_Message(){} // RVA: 0x7FFAF2D8EE30
        public void get_RemoteEndPoint(){} // RVA: 0x7FFAF2D907C0
        public void set_RemoteEndPoint(){} // RVA: 0x7FFAF2DF3E80
        public void get_IsLegacyUnicast(){} // RVA: 0x7FFAF855AF30
        public void .ctor(){} // RVA: 0x7FFAF855AFA0
    }

    public class MulticastClient
    {
        // ── Methods ──
        public void add_MessageReceived(){} // RVA: 0x7FFAF855AFF0
        public void remove_MessageReceived(){} // RVA: 0x7FFAF855B0F0
        public void .ctor(){} // RVA: 0x7FFAF855B1F0
        public void SendAsync(){} // RVA: 0x7FFAF855C010
        public void Listen(){} // RVA: 0x7FFAF855C220
        public void GetNetworkInterfaceLocalAddresses(){} // RVA: 0x7FFAF855C3E0
        public void Dispose(){} // RVA: 0x7FFAF855C9A0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF855C950
        public void .cctor(){} // RVA: 0x7FFAF855CA10
    }

    public class MulticastService
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF855E1D0
        public void add_QueryReceived(){} // RVA: 0x7FFAF855E370
        public void remove_QueryReceived(){} // RVA: 0x7FFAF855E470
        public void add_AnswerReceived(){} // RVA: 0x7FFAF855E570
        public void remove_AnswerReceived(){} // RVA: 0x7FFAF855E670
        public void add_MalformedMessage(){} // RVA: 0x7FFAF855E770
        public void remove_MalformedMessage(){} // RVA: 0x7FFAF855E870
        public void add_NetworkInterfaceDiscovered(){} // RVA: 0x7FFAF855E970
        public void remove_NetworkInterfaceDiscovered(){} // RVA: 0x7FFAF855EA70
        public void .ctor(){} // RVA: 0x7FFAF855EB70
        public void get_UseIpv4(){} // RVA: 0x7FFAF2E09320
        public void set_UseIpv4(){} // RVA: 0x7FFAF2E09330
        public void get_UseIpv6(){} // RVA: 0x7FFAF855EFD0
        public void set_UseIpv6(){} // RVA: 0x7FFAF855EFE0
        public void get_IgnoreDuplicateMessages(){} // RVA: 0x7FFAF855EFF0
        public void set_IgnoreDuplicateMessages(){} // RVA: 0x7FFAF855F000
        public void get_NetworkInterfaceDiscoveryInterval(){} // RVA: 0x7FFAF2F77C50
        public void set_NetworkInterfaceDiscoveryInterval(){} // RVA: 0x7FFAF855F010
        public void GetNetworkInterfaces(){} // RVA: 0x7FFAF855F020
        public void GetIPAddresses(){} // RVA: 0x7FFAF855F4F0
        public void GetLinkLocalAddresses(){} // RVA: 0x7FFAF855F7E0
        public void Start(){} // RVA: 0x7FFAF855F980
        public void Stop(){} // RVA: 0x7FFAF855F9F0
        public void OnNetworkAddressChanged(){} // RVA: 0x7FFAF855FB70
        public void FindNetworkInterfaces(){} // RVA: 0x7FFAF855FB80
        public void ResolveAsync(){} // RVA: 0x7FFAF8560800
        public void SendQuery(){} // RVA: 0x7FFAF8560ED0 | overloaded x2
        public void SendUnicastQuery(){} // RVA: 0x7FFAF8560D30
        public void SendAnswer(){} // RVA: 0x7FFAF8560FB0 | overloaded x2
        public void Send(){} // RVA: 0x7FFAF85616B0
        public void OnDnsMessage(){} // RVA: 0x7FFAF85618D0
        public void Dispose(){} // RVA: 0x7FFAF8561BC0 | overloaded x2
        public void <FindNetworkInterfaces>b__47_2(){} // RVA: 0x7FFAF8561BE0
    }

    public class NetworkInterfaceEventArgs
    {
        // ── Methods ──
        public void get_NetworkInterfaces(){} // RVA: 0x7FFAF2DA8380
        public void set_NetworkInterfaces(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF8562610
    }

    public class RecentMessages
    {
        // ── Methods ──
        public void get_Interval(){} // RVA: 0x7FFAF2D907C0
        public void set_Interval(){} // RVA: 0x7FFAF370BE60
        public void TryAdd(){} // RVA: 0x7FFAF8562660
        public void Prune(){} // RVA: 0x7FFAF8562720
        public void GetId(){} // RVA: 0x7FFAF8562B10
        public void .ctor(){} // RVA: 0x7FFAF8562DD0
    }

    public class ServiceDiscovery
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF85630A0 | overloaded x2
        public void get_Mdns(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Mdns(){} // RVA: 0x7FFAF2DBB0D0
        public void get_AnswersContainsAdditionalRecords(){} // RVA: 0x7FFAF3198A80
        public void set_AnswersContainsAdditionalRecords(){} // RVA: 0x7FFAF3198B80
        public void get_NameServer(){} // RVA: 0x7FFAF30E74D0
        public void add_ServiceDiscovered(){} // RVA: 0x7FFAF8563480
        public void remove_ServiceDiscovered(){} // RVA: 0x7FFAF8563580
        public void add_ServiceInstanceDiscovered(){} // RVA: 0x7FFAF8563680
        public void remove_ServiceInstanceDiscovered(){} // RVA: 0x7FFAF8563780
        public void add_ServiceInstanceShutdown(){} // RVA: 0x7FFAF8563880
        public void remove_ServiceInstanceShutdown(){} // RVA: 0x7FFAF8563980
        public void QueryAllServices(){} // RVA: 0x7FFAF8563A80
        public void QueryUnicastAllServices(){} // RVA: 0x7FFAF8563B10
        public void QueryServiceInstances(){} // RVA: 0x7FFAF8563D10 | overloaded x2
        public void QueryUnicastServiceInstances(){} // RVA: 0x7FFAF8563F50
        public void Advertise(){} // RVA: 0x7FFAF85640C0
        public void Announce(){} // RVA: 0x7FFAF8564A20
        public void Unadvertise(){} // RVA: 0x7FFAF8565280 | overloaded x2
        public void OnAnswer(){} // RVA: 0x7FFAF8565390
        public void OnQuery(){} // RVA: 0x7FFAF85658E0
        public void Dispose(){} // RVA: 0x7FFAF2DDAFC0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF8566080
        public void <Unadvertise>b__35_0(){} // RVA: 0x7FFAF85662B0
    }

    public class ServiceInstanceDiscoveryEventArgs
    {
        public object ServiceInstanceName;

        // ── Methods ──
        public void get_ServiceInstanceName(){} // RVA: 0x7FFAF2DBB0C0
        public void set_ServiceInstanceName(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAF855AFA0
    }

    public class ServiceInstanceShutdownEventArgs
    {
        public object Domain;

        // ── Methods ──
        public void get_ServiceInstanceName(){} // RVA: 0x7FFAF2DBB0C0
        public void set_ServiceInstanceName(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAF855AFA0
    }

    public class ServiceProfile
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF85668D0 | overloaded x2
        public void get_Domain(){} // RVA: 0x7FFAF2DA8380
        public void get_ServiceName(){} // RVA: 0x7FFAF2D907C0
        public void set_ServiceName(){} // RVA: 0x7FFAF2DF3E80
        public void get_InstanceName(){} // RVA: 0x7FFAF2DBB0C0
        public void set_InstanceName(){} // RVA: 0x7FFAF2DBB0D0
        public void get_QualifiedServiceName(){} // RVA: 0x7FFAF85674A0
        public void get_HostName(){} // RVA: 0x7FFAF2DBB130
        public void set_HostName(){} // RVA: 0x7FFAF2D8EE90
        public void get_FullyQualifiedName(){} // RVA: 0x7FFAF85675B0
        public void get_Resources(){} // RVA: 0x7FFAF30E74D0
        public void set_Resources(){} // RVA: 0x7FFAF2DBB890
        public void get_Subtypes(){} // RVA: 0x7FFAF2F476A0
        public void set_Subtypes(){} // RVA: 0x7FFAF2F4B830
        public void AddProperty(){} // RVA: 0x7FFAF8567710
    }

}