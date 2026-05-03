// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Multicast
// Classes: 9
// Methods: 112

namespace ThirdParty.Other.MeaMod.DNS.Multicast
{
    public class MessageEventArgs : EventArgs
    {
        public MeaMod.DNS.Model.Message _message; // 0x10
        public System.Net.IPEndPoint _remoteEndPoint; // 0x18
        public object field_2; // 0x11

        // ── Methods ──
        public void get_Message(){} // RVA: 0x7FFE81116380
        public void set_Message(){} // RVA: 0x7FFE810FCE30
        public void get_RemoteEndPoint(){} // RVA: 0x7FFE810FE7C0
        public void set_RemoteEndPoint(){} // RVA: 0x7FFE81161E80
        public void get_IsLegacyUnicast(){} // RVA: 0x7FFE865EBD60
        public void .ctor(){} // RVA: 0x7FFE865EBDD0
    }

    public class MulticastClient : Object
    {
        // ── Methods ──
        public void add_MessageReceived(){} // RVA: 0x7FFE865EBE20
        public void remove_MessageReceived(){} // RVA: 0x7FFE865EBF20
        public void .ctor(){} // RVA: 0x7FFE865EC020
        public void SendAsync(){} // RVA: 0x7FFE865ECE40
        public void Listen(){} // RVA: 0x7FFE865ED050
        public void GetNetworkInterfaceLocalAddresses(){} // RVA: 0x7FFE865ED210
        public void Dispose(){} // RVA: 0x7FFE865ED7D0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE865ED780
        public void .cctor(){} // RVA: 0x7FFE865ED840
    }

    public class MulticastService : Object
    {
        public int packetOverhead;
        public int maxDatagramSize;
        public System.TimeSpan maxLegacyUnicastTTL;
        public System.Collections.Generic.List`1<System.Net.NetworkInformation.NetworkInterface> knownNics; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE865EF000
        public void add_QueryReceived(){} // RVA: 0x7FFE865EF1A0
        public void remove_QueryReceived(){} // RVA: 0x7FFE865EF2A0
        public void add_AnswerReceived(){} // RVA: 0x7FFE865EF3A0
        public void remove_AnswerReceived(){} // RVA: 0x7FFE865EF4A0
        public void add_MalformedMessage(){} // RVA: 0x7FFE865EF5A0
        public void remove_MalformedMessage(){} // RVA: 0x7FFE865EF6A0
        public void add_NetworkInterfaceDiscovered(){} // RVA: 0x7FFE865EF7A0
        public void remove_NetworkInterfaceDiscovered(){} // RVA: 0x7FFE865EF8A0
        public void .ctor(){} // RVA: 0x7FFE865EF9A0
        public void get_UseIpv4(){} // RVA: 0x7FFE81177320
        public void set_UseIpv4(){} // RVA: 0x7FFE81177330
        public void get_UseIpv6(){} // RVA: 0x7FFE865EFE00
        public void set_UseIpv6(){} // RVA: 0x7FFE865EFE10
        public void get_IgnoreDuplicateMessages(){} // RVA: 0x7FFE865EFE20
        public void set_IgnoreDuplicateMessages(){} // RVA: 0x7FFE865EFE30
        public void get_NetworkInterfaceDiscoveryInterval(){} // RVA: 0x7FFE81463AE0
        public void set_NetworkInterfaceDiscoveryInterval(){} // RVA: 0x7FFE865EFE40
        public void GetNetworkInterfaces(){} // RVA: 0x7FFE865EFE50
        public void GetIPAddresses(){} // RVA: 0x7FFE865F0320
        public void GetLinkLocalAddresses(){} // RVA: 0x7FFE865F0610
        public void Start(){} // RVA: 0x7FFE865F07B0
        public void Stop(){} // RVA: 0x7FFE865F0820
        public void OnNetworkAddressChanged(){} // RVA: 0x7FFE865F09A0
        public void FindNetworkInterfaces(){} // RVA: 0x7FFE865F09B0
        public void ResolveAsync(){} // RVA: 0x7FFE865F1630
        public void SendQuery(){} // RVA: 0x7FFE865F1D00 | overloaded x2
        public void SendUnicastQuery(){} // RVA: 0x7FFE865F1B60
        public void SendAnswer(){} // RVA: 0x7FFE865F1DE0 | overloaded x2
        public void Send(){} // RVA: 0x7FFE865F24E0
        public void OnDnsMessage(){} // RVA: 0x7FFE865F2700
        public void Dispose(){} // RVA: 0x7FFE865F29F0 | overloaded x2
        public void <FindNetworkInterfaces>b__47_2(){} // RVA: 0x7FFE865F2A10
    }

    public class NetworkInterfaceEventArgs : EventArgs
    {
        public System.Collections.Generic.IEnumerable`1<System.Net.NetworkInformation.NetworkInterface> _networkInterfaces; // 0x10

        // ── Methods ──
        public void get_NetworkInterfaces(){} // RVA: 0x7FFE81116380
        public void set_NetworkInterfaces(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE865F3440
    }

    public class RecentMessages : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,System.DateTime> Messages; // 0x10

        // ── Methods ──
        public void get_Interval(){} // RVA: 0x7FFE810FE7C0
        public void set_Interval(){} // RVA: 0x7FFE819EA910
        public void TryAdd(){} // RVA: 0x7FFE865F3490
        public void Prune(){} // RVA: 0x7FFE865F3550
        public void GetId(){} // RVA: 0x7FFE865F3940
        public void .ctor(){} // RVA: 0x7FFE865F3C00
    }

    public class ServiceDiscovery : Object
    {
        public MeaMod.DNS.Model.DomainName LocalDomain;
        public MeaMod.DNS.Model.DomainName SubName; // 0x8
        public MeaMod.DNS.Model.DomainName ServiceName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865F3ED0 | overloaded x2
        public void get_Mdns(){} // RVA: 0x7FFE811290C0
        public void set_Mdns(){} // RVA: 0x7FFE811290D0
        public void get_AnswersContainsAdditionalRecords(){} // RVA: 0x7FFE815F1380
        public void set_AnswersContainsAdditionalRecords(){} // RVA: 0x7FFE81C15740
        public void get_NameServer(){} // RVA: 0x7FFE8144E200
        public void add_ServiceDiscovered(){} // RVA: 0x7FFE865F42B0
        public void remove_ServiceDiscovered(){} // RVA: 0x7FFE865F43B0
        public void add_ServiceInstanceDiscovered(){} // RVA: 0x7FFE865F44B0
        public void remove_ServiceInstanceDiscovered(){} // RVA: 0x7FFE865F45B0
        public void add_ServiceInstanceShutdown(){} // RVA: 0x7FFE865F46B0
        public void remove_ServiceInstanceShutdown(){} // RVA: 0x7FFE865F47B0
        public void QueryAllServices(){} // RVA: 0x7FFE865F48B0
        public void QueryUnicastAllServices(){} // RVA: 0x7FFE865F4940
        public void QueryServiceInstances(){} // RVA: 0x7FFE865F4B40 | overloaded x2
        public void QueryUnicastServiceInstances(){} // RVA: 0x7FFE865F4D80
        public void Advertise(){} // RVA: 0x7FFE865F4EF0
        public void Announce(){} // RVA: 0x7FFE865F5850
        public void Unadvertise(){} // RVA: 0x7FFE865F60B0 | overloaded x2
        public void OnAnswer(){} // RVA: 0x7FFE865F61C0
        public void OnQuery(){} // RVA: 0x7FFE865F6710
        public void Dispose(){} // RVA: 0x7FFE81148FC0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE865F6EB0
        public void <Unadvertise>b__35_0(){} // RVA: 0x7FFE865F70E0
    }

    public class ServiceInstanceDiscoveryEventArgs : MessageEventArgs
    {
        public MeaMod.DNS.Model.DomainName _serviceInstanceName; // 0x20

        // ── Methods ──
        public void get_ServiceInstanceName(){} // RVA: 0x7FFE811290C0
        public void set_ServiceInstanceName(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE865EBDD0
    }

    public class ServiceInstanceShutdownEventArgs : MessageEventArgs
    {
        public MeaMod.DNS.Model.DomainName _serviceInstanceName; // 0x20

        // ── Methods ──
        public void get_ServiceInstanceName(){} // RVA: 0x7FFE811290C0
        public void set_ServiceInstanceName(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE865EBDD0
    }

    public class ServiceProfile : Object
    {
        public MeaMod.DNS.Model.DomainName _domain; // 0x10
        public MeaMod.DNS.Model.DomainName _serviceName; // 0x18
        public MeaMod.DNS.Model.DomainName _instanceName; // 0x20
        public MeaMod.DNS.Model.DomainName _hostName; // 0x28
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.ResourceRecord> _resources; // 0x30
        public System.Collections.Generic.List`1<string> _subtypes; // 0x38
        public object field_6; // 0x1F
        public object field_7; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE865F7700 | overloaded x2
        public void get_Domain(){} // RVA: 0x7FFE81116380
        public void get_ServiceName(){} // RVA: 0x7FFE810FE7C0
        public void set_ServiceName(){} // RVA: 0x7FFE81161E80
        public void get_InstanceName(){} // RVA: 0x7FFE811290C0
        public void set_InstanceName(){} // RVA: 0x7FFE811290D0
        public void get_QualifiedServiceName(){} // RVA: 0x7FFE865F82D0
        public void get_HostName(){} // RVA: 0x7FFE81129130
        public void set_HostName(){} // RVA: 0x7FFE810FCE90
        public void get_FullyQualifiedName(){} // RVA: 0x7FFE865F83E0
        public void get_Resources(){} // RVA: 0x7FFE8144E200
        public void set_Resources(){} // RVA: 0x7FFE81129890
        public void get_Subtypes(){} // RVA: 0x7FFE8143BA80
        public void set_Subtypes(){} // RVA: 0x7FFE81437330
        public void AddProperty(){} // RVA: 0x7FFE865F8540
    }

}