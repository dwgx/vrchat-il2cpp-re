// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Multicast
// Classes: 9
// Methods: 112

namespace ThirdParty.Other.MeaMod.DNS.Multicast
{
    public class MessageEventArgs
    {
        // ── Methods ──
        public void get_Message(){} // RVA: 0x2F8380
        public void set_Message(){} // RVA: 0x2DEE30
        public void get_RemoteEndPoint(){} // RVA: 0x2E07C0
        public void set_RemoteEndPoint(){} // RVA: 0x343E80
        public void get_IsLegacyUnicast(){} // RVA: 0x5AAAF30
        public void .ctor(){} // RVA: 0x5AAAFA0
    }

    public class MulticastClient
    {
        // ── Methods ──
        public void add_MessageReceived(){} // RVA: 0x5AAAFF0
        public void remove_MessageReceived(){} // RVA: 0x5AAB0F0
        public void .ctor(){} // RVA: 0x5AAB1F0
        public void SendAsync(){} // RVA: 0x5AAC010
        public void Listen(){} // RVA: 0x5AAC220
        public void GetNetworkInterfaceLocalAddresses(){} // RVA: 0x5AAC3E0
        public void Dispose(){} // RVA: 0x5AAC9A0 | overloaded x2
        public void Finalize(){} // RVA: 0x5AAC950
        public void .cctor(){} // RVA: 0x5AACA10
    }

    public class MulticastService
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5AAE1D0
        public void add_QueryReceived(){} // RVA: 0x5AAE370
        public void remove_QueryReceived(){} // RVA: 0x5AAE470
        public void add_AnswerReceived(){} // RVA: 0x5AAE570
        public void remove_AnswerReceived(){} // RVA: 0x5AAE670
        public void add_MalformedMessage(){} // RVA: 0x5AAE770
        public void remove_MalformedMessage(){} // RVA: 0x5AAE870
        public void add_NetworkInterfaceDiscovered(){} // RVA: 0x5AAE970
        public void remove_NetworkInterfaceDiscovered(){} // RVA: 0x5AAEA70
        public void .ctor(){} // RVA: 0x5AAEB70
        public void get_UseIpv4(){} // RVA: 0x359320
        public void set_UseIpv4(){} // RVA: 0x359330
        public void get_UseIpv6(){} // RVA: 0x5AAEFD0
        public void set_UseIpv6(){} // RVA: 0x5AAEFE0
        public void get_IgnoreDuplicateMessages(){} // RVA: 0x5AAEFF0
        public void set_IgnoreDuplicateMessages(){} // RVA: 0x5AAF000
        public void get_NetworkInterfaceDiscoveryInterval(){} // RVA: 0x4C7C50
        public void set_NetworkInterfaceDiscoveryInterval(){} // RVA: 0x5AAF010
        public void GetNetworkInterfaces(){} // RVA: 0x5AAF020
        public void GetIPAddresses(){} // RVA: 0x5AAF4F0
        public void GetLinkLocalAddresses(){} // RVA: 0x5AAF7E0
        public void Start(){} // RVA: 0x5AAF980
        public void Stop(){} // RVA: 0x5AAF9F0
        public void OnNetworkAddressChanged(){} // RVA: 0x5AAFB70
        public void FindNetworkInterfaces(){} // RVA: 0x5AAFB80
        public void ResolveAsync(){} // RVA: 0x5AB0800
        public void SendQuery(){} // RVA: 0x5AB0ED0 | overloaded x2
        public void SendUnicastQuery(){} // RVA: 0x5AB0D30
        public void SendAnswer(){} // RVA: 0x5AB0FB0 | overloaded x2
        public void Send(){} // RVA: 0x5AB16B0
        public void OnDnsMessage(){} // RVA: 0x5AB18D0
        public void Dispose(){} // RVA: 0x5AB1BC0 | overloaded x2
        public void <FindNetworkInterfaces>b__47_2(){} // RVA: 0x5AB1BE0
    }

    public class NetworkInterfaceEventArgs
    {
        // ── Methods ──
        public void get_NetworkInterfaces(){} // RVA: 0x2F8380
        public void set_NetworkInterfaces(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x5AB2610
    }

    public class RecentMessages
    {
        // ── Methods ──
        public void get_Interval(){} // RVA: 0x2E07C0
        public void set_Interval(){} // RVA: 0xC5BE60
        public void TryAdd(){} // RVA: 0x5AB2660
        public void Prune(){} // RVA: 0x5AB2720
        public void GetId(){} // RVA: 0x5AB2B10
        public void .ctor(){} // RVA: 0x5AB2DD0
    }

    public class ServiceDiscovery
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AB30A0 | overloaded x2
        public void get_Mdns(){} // RVA: 0x30B0C0
        public void set_Mdns(){} // RVA: 0x30B0D0
        public void get_AnswersContainsAdditionalRecords(){} // RVA: 0x6E8A80
        public void set_AnswersContainsAdditionalRecords(){} // RVA: 0x6E8B80
        public void get_NameServer(){} // RVA: 0x6374D0
        public void add_ServiceDiscovered(){} // RVA: 0x5AB3480
        public void remove_ServiceDiscovered(){} // RVA: 0x5AB3580
        public void add_ServiceInstanceDiscovered(){} // RVA: 0x5AB3680
        public void remove_ServiceInstanceDiscovered(){} // RVA: 0x5AB3780
        public void add_ServiceInstanceShutdown(){} // RVA: 0x5AB3880
        public void remove_ServiceInstanceShutdown(){} // RVA: 0x5AB3980
        public void QueryAllServices(){} // RVA: 0x5AB3A80
        public void QueryUnicastAllServices(){} // RVA: 0x5AB3B10
        public void QueryServiceInstances(){} // RVA: 0x5AB3D10 | overloaded x2
        public void QueryUnicastServiceInstances(){} // RVA: 0x5AB3F50
        public void Advertise(){} // RVA: 0x5AB40C0
        public void Announce(){} // RVA: 0x5AB4A20
        public void Unadvertise(){} // RVA: 0x5AB5280 | overloaded x2
        public void OnAnswer(){} // RVA: 0x5AB5390
        public void OnQuery(){} // RVA: 0x5AB58E0
        public void Dispose(){} // RVA: 0x32AFC0 | overloaded x2
        public void .cctor(){} // RVA: 0x5AB6080
        public void <Unadvertise>b__35_0(){} // RVA: 0x5AB62B0
    }

    public class ServiceInstanceDiscoveryEventArgs
    {
        public object ServiceInstanceName;

        // ── Methods ──
        public void get_ServiceInstanceName(){} // RVA: 0x30B0C0
        public void set_ServiceInstanceName(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x5AAAFA0
    }

    public class ServiceInstanceShutdownEventArgs
    {
        public object Domain;

        // ── Methods ──
        public void get_ServiceInstanceName(){} // RVA: 0x30B0C0
        public void set_ServiceInstanceName(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x5AAAFA0
    }

    public class ServiceProfile
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x5AB68D0 | overloaded x2
        public void get_Domain(){} // RVA: 0x2F8380
        public void get_ServiceName(){} // RVA: 0x2E07C0
        public void set_ServiceName(){} // RVA: 0x343E80
        public void get_InstanceName(){} // RVA: 0x30B0C0
        public void set_InstanceName(){} // RVA: 0x30B0D0
        public void get_QualifiedServiceName(){} // RVA: 0x5AB74A0
        public void get_HostName(){} // RVA: 0x30B130
        public void set_HostName(){} // RVA: 0x2DEE90
        public void get_FullyQualifiedName(){} // RVA: 0x5AB75B0
        public void get_Resources(){} // RVA: 0x6374D0
        public void set_Resources(){} // RVA: 0x30B890
        public void get_Subtypes(){} // RVA: 0x4976A0
        public void set_Subtypes(){} // RVA: 0x49B830
        public void AddProperty(){} // RVA: 0x5AB7710
    }

}