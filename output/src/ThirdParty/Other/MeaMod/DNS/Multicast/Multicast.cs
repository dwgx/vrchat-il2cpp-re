// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Multicast
// Classes: 9
// Methods: 103

namespace ThirdParty.Other.MeaMod.DNS.Multicast
{
    public class MessageEventArgs : EventArgs
    {
        // ── Methods ──
        public void get_Message(){} // RVA: 0x7A80F2570
        public void set_Message(){} // RVA: 0x7A80D8E20
        public void get_RemoteEndPoint(){} // RVA: 0x7A80DA7B0
        public void set_RemoteEndPoint(){} // RVA: 0x7A813E420
        public void get_IsLegacyUnicast(){} // RVA: 0x7AD8983E0
        public void .ctor(){} // RVA: 0x7AD898450
    }

    public class MulticastClient : Object
    {
        // ── Methods ──
        public void add_MessageReceived(){} // RVA: 0x7AD8984A0
        public void remove_MessageReceived(){} // RVA: 0x7AD8985B0
        public void .ctor(){} // RVA: 0x7AD8986C0
        public void SendAsync(){} // RVA: 0x7AD8994F0
        public void Listen(){} // RVA: 0x7AD899700
        public void GetNetworkInterfaceLocalAddresses(){} // RVA: 0x7AD8998C0
        public void Dispose(){} // RVA: 0x7AD899E90
        public void Finalize(){} // RVA: 0x7AD899E40
        public void .cctor(){} // RVA: 0x7AD899F00
    }

    public class MulticastService : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD89B6C0
        public void add_QueryReceived(){} // RVA: 0x7AD89B860
        public void remove_QueryReceived(){} // RVA: 0x7AD89B970
        public void add_AnswerReceived(){} // RVA: 0x7AD89BA80
        public void remove_AnswerReceived(){} // RVA: 0x7AD89BB90
        public void add_MalformedMessage(){} // RVA: 0x7AD89BCA0
        public void remove_MalformedMessage(){} // RVA: 0x7AD89BDB0
        public void add_NetworkInterfaceDiscovered(){} // RVA: 0x7AD89BEC0
        public void remove_NetworkInterfaceDiscovered(){} // RVA: 0x7AD89BFD0
        public void .ctor(){} // RVA: 0x7AD89C0E0
        public void get_UseIpv4(){} // RVA: 0x7A8153980
        public void set_UseIpv4(){} // RVA: 0x7A8153990
        public void get_UseIpv6(){} // RVA: 0x7AD89C540
        public void set_UseIpv6(){} // RVA: 0x7AD89C550
        public void get_IgnoreDuplicateMessages(){} // RVA: 0x7AD89C560
        public void set_IgnoreDuplicateMessages(){} // RVA: 0x7AD89C570
        public void get_NetworkInterfaceDiscoveryInterval(){} // RVA: 0x7A82C2060
        public void set_NetworkInterfaceDiscoveryInterval(){} // RVA: 0x7AD89C580
        public void GetNetworkInterfaces(){} // RVA: 0x7AD89C590
        public void GetIPAddresses(){} // RVA: 0x7AD89CA60
        public void GetLinkLocalAddresses(){} // RVA: 0x7AD89CD50
        public void Start(){} // RVA: 0x7AD89CEF0
        public void Stop(){} // RVA: 0x7AD89CF60
        public void OnNetworkAddressChanged(){} // RVA: 0x7AD89D0E0
        public void FindNetworkInterfaces(){} // RVA: 0x7AD89D0F0
        public void ResolveAsync(){} // RVA: 0x7AD89DD60
        public void SendQuery(){} // RVA: 0x7AD89E440
        public void SendUnicastQuery(){} // RVA: 0x7AD89E2A0
        public void SendAnswer(){} // RVA: 0x7AD89E520
        public void Send(){} // RVA: 0x7AD89EBF0
        public void OnDnsMessage(){} // RVA: 0x7AD89EE20
        public void Dispose(){} // RVA: 0x7AD89F110
        public void <FindNetworkInterfaces>b__47_2(){} // RVA: 0x7AD89F130
    }

    public class NetworkInterfaceEventArgs : EventArgs
    {
        // ── Methods ──
        public void get_NetworkInterfaces(){} // RVA: 0x7A80F2570
        public void set_NetworkInterfaces(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AD89FB10
    }

    public class RecentMessages : Object
    {
        // ── Methods ──
        public void get_Interval(){} // RVA: 0x7A80DA7B0
        public void set_Interval(){} // RVA: 0x7A8A224D0
        public void TryAdd(){} // RVA: 0x7AD89FB60
        public void Prune(){} // RVA: 0x7AD89FC20
        public void GetId(){} // RVA: 0x7AD8A0010
        public void .ctor(){} // RVA: 0x7AD8A02E0
    }

    public class ServiceDiscovery : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8A05B0
        public void get_Mdns(){} // RVA: 0x7A81052C0
        public void set_Mdns(){} // RVA: 0x7A81052D0
        public void get_AnswersContainsAdditionalRecords(){} // RVA: 0x7A84A5BD0
        public void set_AnswersContainsAdditionalRecords(){} // RVA: 0x7A84A5CD0
        public void get_NameServer(){} // RVA: 0x7A83F69F0
        public void add_ServiceDiscovered(){} // RVA: 0x7AD8A0990
        public void remove_ServiceDiscovered(){} // RVA: 0x7AD8A0AA0
        public void add_ServiceInstanceDiscovered(){} // RVA: 0x7AD8A0BB0
        public void remove_ServiceInstanceDiscovered(){} // RVA: 0x7AD8A0CC0
        public void add_ServiceInstanceShutdown(){} // RVA: 0x7AD8A0DD0
        public void remove_ServiceInstanceShutdown(){} // RVA: 0x7AD8A0EE0
        public void QueryAllServices(){} // RVA: 0x7AD8A0FF0
        public void QueryUnicastAllServices(){} // RVA: 0x7AD8A1080
        public void QueryServiceInstances(){} // RVA: 0x7AD8A1280
        public void QueryUnicastServiceInstances(){} // RVA: 0x7AD8A14C0
        public void Advertise(){} // RVA: 0x7AD8A1630
        public void Announce(){} // RVA: 0x7AD8A1FC0
        public void Unadvertise(){} // RVA: 0x7AD8A2740
        public void OnAnswer(){} // RVA: 0x7AD8A27F0
        public void OnQuery(){} // RVA: 0x7AD8A2D40
        public void Dispose(){} // RVA: 0x7A8125330
        public void .cctor(){} // RVA: 0x7AD8A34E0
        public void <Unadvertise>b__35_0(){} // RVA: 0x7AD8A3710
    }

    public class ServiceInstanceDiscoveryEventArgs : MessageEventArgs
    {
        // ── Methods ──
        public void get_ServiceInstanceName(){} // RVA: 0x7A81052C0
        public void set_ServiceInstanceName(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7AD898450
    }

    public class ServiceInstanceShutdownEventArgs : MessageEventArgs
    {
        // ── Methods ──
        public void get_ServiceInstanceName(){} // RVA: 0x7A81052C0
        public void set_ServiceInstanceName(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7AD898450
    }

    public class ServiceProfile : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7AD8A3D30
        public void get_Domain(){} // RVA: 0x7A80F2570
        public void get_ServiceName(){} // RVA: 0x7A80DA7B0
        public void set_ServiceName(){} // RVA: 0x7A813E420
        public void get_InstanceName(){} // RVA: 0x7A81052C0
        public void set_InstanceName(){} // RVA: 0x7A81052D0
        public void get_QualifiedServiceName(){} // RVA: 0x7AD8A4920
        public void get_HostName(){} // RVA: 0x7A8105330
        public void set_HostName(){} // RVA: 0x7A80D8E80
        public void get_FullyQualifiedName(){} // RVA: 0x7AD8A4A30
        public void get_Resources(){} // RVA: 0x7A83F69F0
        public void set_Resources(){} // RVA: 0x7A8105A90
        public void get_Subtypes(){} // RVA: 0x7A8292C30
        public void set_Subtypes(){} // RVA: 0x7A8296DE0
        public void AddProperty(){} // RVA: 0x7AD8A4B90
    }

}