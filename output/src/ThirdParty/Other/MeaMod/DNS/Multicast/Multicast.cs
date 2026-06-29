// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Multicast
// Classes: 10
// Methods: 118

namespace ThirdParty.Other.MeaMod.DNS.Multicast
{
    public class MessageEventArgs : EventArgs
    {
        public object _message;
        public object _remoteEndPoint;

        // ── Methods ──
        public void get_Message(){} // RVA: 0xB5DBF0
        public void set_Message(){} // RVA: 0xB44D60
        public void get_RemoteEndPoint(){} // RVA: 0xB465B0
        public void set_RemoteEndPoint(){} // RVA: 0xBA9BA0
        public void get_IsLegacyUnicast(){} // RVA: 0x6525980
        public void .ctor(){} // RVA: 0x65259F0
    }

    public class MulticastClient : Object
    {
        public object MulticastPort;
        public object MulticastAddressIp4;
        public object MulticastAddressIp6;
        public object MdnsEndpointIp6;
        public object MdnsEndpointIp4;
        public object receivers;
        public object senders;
        public object MessageReceived;
        public object disposedValue;

        // ── Methods ──
        public void add_MessageReceived(){} // RVA: 0x6525A40
        public void remove_MessageReceived(){} // RVA: 0x6525B50
        public void .ctor(){} // RVA: 0x6525C60
        public void SendAsync(){} // RVA: 0x65269C0
        public void Listen(){} // RVA: 0x6526BD0
        public void GetNetworkInterfaceLocalAddresses(){} // RVA: 0x6526D90
        public void Dispose(){} // RVA: 0x6527360
        public void Finalize(){} // RVA: 0x6527310
        public void .cctor(){} // RVA: 0x65273D0
    }

    public class MulticastService : Object
    {
        public object packetOverhead;
        public object maxDatagramSize;
        public object maxLegacyUnicastTTL;
        public object knownNics;
        public object maxPacketSize;
        public object sentMessages;
        public object receivedMessages;
        public object client;
        public object unicastClientIp4;
        public object unicastClientIp6;
        public object networkInterfacesFilter;
        public object QueryReceived;
        public object AnswerReceived;
        public object MalformedMessage;
        public object NetworkInterfaceDiscovered;
        public object _useIpv4;
        public object _useIpv6;
        public object _ignoreDuplicateMessages;
        public object _networkInterfaceDiscoveryInterval;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6528B90
        public void add_QueryReceived(){} // RVA: 0x6528D30
        public void remove_QueryReceived(){} // RVA: 0x6528E40
        public void add_AnswerReceived(){} // RVA: 0x6528F50
        public void remove_AnswerReceived(){} // RVA: 0x6529060
        public void add_MalformedMessage(){} // RVA: 0x6529170
        public void remove_MalformedMessage(){} // RVA: 0x6529280
        public void add_NetworkInterfaceDiscovered(){} // RVA: 0x6529390
        public void remove_NetworkInterfaceDiscovered(){} // RVA: 0x65294A0
        public void .ctor(){} // RVA: 0x65295B0
        public void get_UseIpv4(){} // RVA: 0xBC03E0
        public void set_UseIpv4(){} // RVA: 0xBC03F0
        public void get_UseIpv6(){} // RVA: 0x6529A10
        public void set_UseIpv6(){} // RVA: 0x6529A20
        public void get_IgnoreDuplicateMessages(){} // RVA: 0x6529A30
        public void set_IgnoreDuplicateMessages(){} // RVA: 0x6529A40
        public void get_NetworkInterfaceDiscoveryInterval(){} // RVA: 0xCD3320
        public void set_NetworkInterfaceDiscoveryInterval(){} // RVA: 0x6529A50
        public void GetNetworkInterfaces(){} // RVA: 0x6529A60
        public void GetIPAddresses(){} // RVA: 0x6529F30
        public void GetLinkLocalAddresses(){} // RVA: 0x652A220
        public void Start(){} // RVA: 0x652A3C0
        public void Stop(){} // RVA: 0x652A430
        public void OnNetworkAddressChanged(){} // RVA: 0x652A5B0
        public void FindNetworkInterfaces(){} // RVA: 0x652A5C0
        public void ResolveAsync(){} // RVA: 0x652B230
        public void SendQuery(){} // RVA: 0x652B910
        public void SendUnicastQuery(){} // RVA: 0x652B770
        public void SendAnswer(){} // RVA: 0x652B9F0
        public void Send(){} // RVA: 0x652C0C0
        public void OnDnsMessage(){} // RVA: 0x652C2E0
        public void Dispose(){} // RVA: 0x652C5D0
        public void <FindNetworkInterfaces>b__47_2(){} // RVA: 0x652C5F0
    }

    public class NetworkInterfaceEventArgs : EventArgs
    {
        public object _networkInterfaces;

        // ── Methods ──
        public void get_NetworkInterfaces(){} // RVA: 0xB5DBF0
        public void set_NetworkInterfaces(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x652CFD0
    }

    public class RecentMessages : Object
    {
        public object Messages;
        public object _interval;

        // ── Methods ──
        public void get_Interval(){} // RVA: 0xB465B0
        public void set_Interval(){} // RVA: 0x15428E0
        public void TryAdd(){} // RVA: 0x652D020
        public void Prune(){} // RVA: 0x652D0E0
        public void GetId(){} // RVA: 0x652D4D0
        public void .ctor(){} // RVA: 0x652D7A0
    }

    public class ServiceDiscovery : Object
    {
        public object LocalDomain;
        public object SubName;
        public object ServiceName;
        public object ownsMdns;
        public object profiles;
        public object _mdns;
        public object _answersContainsAdditionalRecords;
        public object _nameServer;
        public object ServiceDiscovered;
        public object ServiceInstanceDiscovered;
        public object ServiceInstanceShutdown;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x652DA70
        public void get_Mdns(){} // RVA: 0xB700F0
        public void set_Mdns(){} // RVA: 0xB70100
        public void get_AnswersContainsAdditionalRecords(){} // RVA: 0xF73960
        public void set_AnswersContainsAdditionalRecords(){} // RVA: 0xF73A60
        public void get_NameServer(){} // RVA: 0xD33E60
        public void add_ServiceDiscovered(){} // RVA: 0x652DE50
        public void remove_ServiceDiscovered(){} // RVA: 0x652DF60
        public void add_ServiceInstanceDiscovered(){} // RVA: 0x652E070
        public void remove_ServiceInstanceDiscovered(){} // RVA: 0x652E180
        public void add_ServiceInstanceShutdown(){} // RVA: 0x652E290
        public void remove_ServiceInstanceShutdown(){} // RVA: 0x652E3A0
        public void QueryAllServices(){} // RVA: 0x652E4B0
        public void QueryUnicastAllServices(){} // RVA: 0x652E540
        public void QueryServiceInstances(){} // RVA: 0x652E740
        public void QueryUnicastServiceInstances(){} // RVA: 0x652E980
        public void Advertise(){} // RVA: 0x652EAF0
        public void Announce(){} // RVA: 0x652F480
        public void Unadvertise(){} // RVA: 0x652FC00
        public void OnAnswer(){} // RVA: 0x652FCB0
        public void OnQuery(){} // RVA: 0x6530200
        public void Dispose(){} // RVA: 0xB90310
        public void .cctor(){} // RVA: 0x65309A0
        public void <Unadvertise>b__35_0(){} // RVA: 0x6530BD0
    }

    public class ServiceInstanceDiscoveryEventArgs : MessageEventArgs
    {
        public object _serviceInstanceName;

        // ── Methods ──
        public void get_ServiceInstanceName(){} // RVA: 0xB700F0
        public void set_ServiceInstanceName(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0x65259F0
    }

    public class ServiceInstanceShutdownEventArgs : MessageEventArgs
    {
        public object _serviceInstanceName;

        // ── Methods ──
        public void get_ServiceInstanceName(){} // RVA: 0xB700F0
        public void set_ServiceInstanceName(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0x65259F0
    }

    public class ServiceProfile : Object
    {
        public object _domain;
        public object _serviceName;
        public object _instanceName;
        public object _hostName;
        public object _resources;
        public object _subtypes;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x65311F0
        public void get_Domain(){} // RVA: 0xB5DBF0
        public void get_ServiceName(){} // RVA: 0xB465B0
        public void set_ServiceName(){} // RVA: 0xBA9BA0
        public void get_InstanceName(){} // RVA: 0xB700F0
        public void set_InstanceName(){} // RVA: 0xB70100
        public void get_QualifiedServiceName(){} // RVA: 0x6531DE0
        public void get_HostName(){} // RVA: 0xB70160
        public void set_HostName(){} // RVA: 0xB44DC0
        public void get_FullyQualifiedName(){} // RVA: 0x6531EF0
        public void get_Resources(){} // RVA: 0xD33E60
        public void set_Resources(){} // RVA: 0xB708C0
        public void get_Subtypes(){} // RVA: 0xD05CA0
        public void set_Subtypes(){} // RVA: 0xD09D70
        public void AddProperty(){} // RVA: 0x6532050
    }

    public class ServiceProfile[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}