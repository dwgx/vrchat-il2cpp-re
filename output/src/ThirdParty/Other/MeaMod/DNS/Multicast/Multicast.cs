// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Multicast
// Classes: 9
// Methods: 112

namespace ThirdParty.Other.MeaMod.DNS.Multicast
{
    public class MessageEventArgs : EventArgs
    {
        public MeaMod.DNS.Model.Message Message; // 0x10
        public System.Net.IPEndPoint RemoteEndPoint; // 0x18

        // ── Methods ──
        public void get_Message(){} // RVA: 0x7FFAC2F3C380
        public void set_Message(){} // RVA: 0x7FFAC2F22E30
        public void get_RemoteEndPoint(){} // RVA: 0x7FFAC2F247C0
        public void set_RemoteEndPoint(){} // RVA: 0x7FFAC2F87E80
        public void get_IsLegacyUnicast(){} // RVA: 0x7FFAC8242420
        public void .ctor(){} // RVA: 0x7FFAC8242490
    }

    public class MulticastClient : Object
    {
        public int MulticastPort;
        public System.Net.IPAddress MulticastAddressIp4; // 0x8
        public System.Net.IPAddress MulticastAddressIp6; // 0x10
        public System.Net.IPEndPoint MdnsEndpointIp6; // 0x18
        public System.Net.IPEndPoint MdnsEndpointIp4; // 0x20
        public System.Collections.Generic.List`1<System.Net.Sockets.UdpClient> receivers; // 0x10
        public System.Collections.Concurrent.ConcurrentDictionary`2<System.Net.IPAddress,System.Net.Sockets.UdpClient> senders; // 0x18
        public System.EventHandler`1<System.Net.Sockets.UdpReceiveResult> MessageReceived; // 0x20
        public bool disposedValue; // 0x28

        // ── Methods ──
        public void add_MessageReceived(){} // RVA: 0x7FFAC82424E0
        public void remove_MessageReceived(){} // RVA: 0x7FFAC82425E0
        public void .ctor(){} // RVA: 0x7FFAC82426E0
        public void SendAsync(){} // RVA: 0x7FFAC8243500
        public void Listen(){} // RVA: 0x7FFAC8243710
        public void GetNetworkInterfaceLocalAddresses(){} // RVA: 0x7FFAC82438D0
        public void Dispose(){} // RVA: 0x7FFAC8243E90 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8243E40
        public void .cctor(){} // RVA: 0x7FFAC8243F00
    }

    public class MulticastService : Object
    {
        public int UseIpv4;
        public int UseIpv6;
        public System.TimeSpan IgnoreDuplicateMessages;
        public System.Collections.Generic.List`1<System.Net.NetworkInformation.NetworkInterface> NetworkInterfaceDiscoveryInterval; // 0x10
        public int maxPacketSize; // 0x18
        public MeaMod.DNS.Multicast.RecentMessages sentMessages; // 0x20
        public MeaMod.DNS.Multicast.RecentMessages receivedMessages; // 0x28
        public MeaMod.DNS.Multicast.MulticastClient client; // 0x30
        public System.Net.Sockets.UdpClient unicastClientIp4; // 0x38
        public System.Net.Sockets.UdpClient unicastClientIp6; // 0x40
        public System.Func`2<System.Collections.Generic.IEnumerable`1<System.Net.NetworkInformation.NetworkInterface>,System.Collections.Generic.IEnumerable`1<System.Net.NetworkInformation.NetworkInterface>> networkInterfacesFilter; // 0x48
        public System.EventHandler`1<MeaMod.DNS.Multicast.MessageEventArgs> QueryReceived; // 0x50
        public System.EventHandler`1<MeaMod.DNS.Multicast.MessageEventArgs> AnswerReceived; // 0x58
        public System.EventHandler`1<byte[]> MalformedMessage; // 0x60
        public System.EventHandler`1<MeaMod.DNS.Multicast.NetworkInterfaceEventArgs> NetworkInterfaceDiscovered; // 0x68
        public bool <UseIpv4>k__BackingField; // 0x70
        public bool <UseIpv6>k__BackingField; // 0x71
        public bool <IgnoreDuplicateMessages>k__BackingField; // 0x72
        public System.TimeSpan <NetworkInterfaceDiscoveryInterval>k__BackingField; // 0x78

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC82456C0
        public void add_QueryReceived(){} // RVA: 0x7FFAC8245860
        public void remove_QueryReceived(){} // RVA: 0x7FFAC8245960
        public void add_AnswerReceived(){} // RVA: 0x7FFAC8245A60
        public void remove_AnswerReceived(){} // RVA: 0x7FFAC8245B60
        public void add_MalformedMessage(){} // RVA: 0x7FFAC8245C60
        public void remove_MalformedMessage(){} // RVA: 0x7FFAC8245D60
        public void add_NetworkInterfaceDiscovered(){} // RVA: 0x7FFAC8245E60
        public void remove_NetworkInterfaceDiscovered(){} // RVA: 0x7FFAC8245F60
        public void .ctor(){} // RVA: 0x7FFAC8246060
        public void get_UseIpv4(){} // RVA: 0x7FFAC2F9D320
        public void set_UseIpv4(){} // RVA: 0x7FFAC2F9D330
        public void get_UseIpv6(){} // RVA: 0x7FFAC82464C0
        public void set_UseIpv6(){} // RVA: 0x7FFAC82464D0
        public void get_IgnoreDuplicateMessages(){} // RVA: 0x7FFAC82464E0
        public void set_IgnoreDuplicateMessages(){} // RVA: 0x7FFAC82464F0
        public void get_NetworkInterfaceDiscoveryInterval(){} // RVA: 0x7FFAC30E5600
        public void set_NetworkInterfaceDiscoveryInterval(){} // RVA: 0x7FFAC8246500
        public void GetNetworkInterfaces(){} // RVA: 0x7FFAC8246510
        public void GetIPAddresses(){} // RVA: 0x7FFAC82469E0
        public void GetLinkLocalAddresses(){} // RVA: 0x7FFAC8246CD0
        public void Start(){} // RVA: 0x7FFAC8246E70
        public void Stop(){} // RVA: 0x7FFAC8246EE0
        public void OnNetworkAddressChanged(){} // RVA: 0x7FFAC8247060
        public void FindNetworkInterfaces(){} // RVA: 0x7FFAC8247070
        public void ResolveAsync(){} // RVA: 0x7FFAC8247CF0
        public void SendQuery(){} // RVA: 0x7FFAC82483C0 | overloaded x2
        public void SendUnicastQuery(){} // RVA: 0x7FFAC8248220
        public void SendAnswer(){} // RVA: 0x7FFAC82484A0 | overloaded x2
        public void Send(){} // RVA: 0x7FFAC8248BA0
        public void OnDnsMessage(){} // RVA: 0x7FFAC8248DC0
        public void Dispose(){} // RVA: 0x7FFAC82490B0 | overloaded x2
        public void <FindNetworkInterfaces>b__47_2(){} // RVA: 0x7FFAC82490D0
    }

    public class NetworkInterfaceEventArgs : EventArgs
    {
        public System.Collections.Generic.IEnumerable`1<System.Net.NetworkInformation.NetworkInterface> NetworkInterfaces; // 0x10

        // ── Methods ──
        public void get_NetworkInterfaces(){} // RVA: 0x7FFAC2F3C380
        public void set_NetworkInterfaces(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC8249B00
    }

    public class RecentMessages : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,System.DateTime> Interval; // 0x10
        public System.TimeSpan <Interval>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Interval(){} // RVA: 0x7FFAC2F247C0
        public void set_Interval(){} // RVA: 0x7FFAC38920D0
        public void TryAdd(){} // RVA: 0x7FFAC8249B50
        public void Prune(){} // RVA: 0x7FFAC8249C10
        public void GetId(){} // RVA: 0x7FFAC824A000
        public void .ctor(){} // RVA: 0x7FFAC824A2C0
    }

    public class ServiceDiscovery : Object
    {
        public MeaMod.DNS.Model.DomainName Mdns;
        public MeaMod.DNS.Model.DomainName AnswersContainsAdditionalRecords; // 0x8
        public MeaMod.DNS.Model.DomainName NameServer; // 0x10
        public bool ownsMdns; // 0x10
        public System.Collections.Generic.List`1<MeaMod.DNS.Multicast.ServiceProfile> profiles; // 0x18
        public MeaMod.DNS.Multicast.MulticastService <Mdns>k__BackingField; // 0x20
        public bool <AnswersContainsAdditionalRecords>k__BackingField; // 0x28
        public MeaMod.DNS.Server.NameServer <NameServer>k__BackingField; // 0x30
        public System.EventHandler`1<MeaMod.DNS.Model.DomainName> ServiceDiscovered; // 0x38
        public System.EventHandler`1<MeaMod.DNS.Multicast.ServiceInstanceDiscoveryEventArgs> ServiceInstanceDiscovered; // 0x40
        public System.EventHandler`1<MeaMod.DNS.Multicast.ServiceInstanceShutdownEventArgs> ServiceInstanceShutdown; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC824A590 | overloaded x2
        public void get_Mdns(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Mdns(){} // RVA: 0x7FFAC2F4F0D0
        public void get_AnswersContainsAdditionalRecords(){} // RVA: 0x7FFAC30F6BA0
        public void set_AnswersContainsAdditionalRecords(){} // RVA: 0x7FFAC3C24F40
        public void get_NameServer(){} // RVA: 0x7FFAC31D95E0
        public void add_ServiceDiscovered(){} // RVA: 0x7FFAC824A970
        public void remove_ServiceDiscovered(){} // RVA: 0x7FFAC824AA70
        public void add_ServiceInstanceDiscovered(){} // RVA: 0x7FFAC824AB70
        public void remove_ServiceInstanceDiscovered(){} // RVA: 0x7FFAC824AC70
        public void add_ServiceInstanceShutdown(){} // RVA: 0x7FFAC824AD70
        public void remove_ServiceInstanceShutdown(){} // RVA: 0x7FFAC824AE70
        public void QueryAllServices(){} // RVA: 0x7FFAC824AF70
        public void QueryUnicastAllServices(){} // RVA: 0x7FFAC824B000
        public void QueryServiceInstances(){} // RVA: 0x7FFAC824B200 | overloaded x2
        public void QueryUnicastServiceInstances(){} // RVA: 0x7FFAC824B440
        public void Advertise(){} // RVA: 0x7FFAC824B5B0
        public void Announce(){} // RVA: 0x7FFAC824BF10
        public void Unadvertise(){} // RVA: 0x7FFAC824C770 | overloaded x2
        public void OnAnswer(){} // RVA: 0x7FFAC824C880
        public void OnQuery(){} // RVA: 0x7FFAC824CDD0
        public void Dispose(){} // RVA: 0x7FFAC2F6EFC0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC824D570
        public void <Unadvertise>b__35_0(){} // RVA: 0x7FFAC824D7A0
    }

    public class ServiceInstanceDiscoveryEventArgs : MessageEventArgs
    {
        public MeaMod.DNS.Model.DomainName ServiceInstanceName; // 0x20

        // ── Methods ──
        public void get_ServiceInstanceName(){} // RVA: 0x7FFAC2F4F0C0
        public void set_ServiceInstanceName(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC8242490
    }

    public class ServiceInstanceShutdownEventArgs : MessageEventArgs
    {
        public MeaMod.DNS.Model.DomainName ServiceInstanceName; // 0x20

        // ── Methods ──
        public void get_ServiceInstanceName(){} // RVA: 0x7FFAC2F4F0C0
        public void set_ServiceInstanceName(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC8242490
    }

    public class ServiceProfile : Object
    {
        public MeaMod.DNS.Model.DomainName Domain; // 0x10
        public MeaMod.DNS.Model.DomainName ServiceName; // 0x18
        public MeaMod.DNS.Model.DomainName InstanceName; // 0x20
        public MeaMod.DNS.Model.DomainName QualifiedServiceName; // 0x28
        public System.Collections.Generic.List`1<MeaMod.DNS.Model.ResourceRecord> HostName; // 0x30
        public System.Collections.Generic.List`1<string> FullyQualifiedName; // 0x38

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC824DDC0 | overloaded x2
        public void get_Domain(){} // RVA: 0x7FFAC2F3C380
        public void get_ServiceName(){} // RVA: 0x7FFAC2F247C0
        public void set_ServiceName(){} // RVA: 0x7FFAC2F87E80
        public void get_InstanceName(){} // RVA: 0x7FFAC2F4F0C0
        public void set_InstanceName(){} // RVA: 0x7FFAC2F4F0D0
        public void get_QualifiedServiceName(){} // RVA: 0x7FFAC824E990
        public void get_HostName(){} // RVA: 0x7FFAC2F4F130
        public void set_HostName(){} // RVA: 0x7FFAC2F22E90
        public void get_FullyQualifiedName(){} // RVA: 0x7FFAC824EAA0
        public void get_Resources(){} // RVA: 0x7FFAC31D95E0
        public void set_Resources(){} // RVA: 0x7FFAC2F4F890
        public void get_Subtypes(){} // RVA: 0x7FFAC31D0140
        public void set_Subtypes(){} // RVA: 0x7FFAC31D0C20
        public void AddProperty(){} // RVA: 0x7FFAC824EC00
    }

}