// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.NetworkInformation
// Classes: 42
// Methods: 129

namespace ThirdParty.DotNet.System.Net.NetworkInformation
{
    public class AlignmentUnion : ValueType
    {
        public ulong Alignment; // 0x10
        public int Length; // 0x10
        public int IfIndex; // 0x14
    }

    public class INetworkChange
    {
        public object HasRegisteredEvents;

        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x7FFAC2C70A40
        public void remove_NetworkAddressChanged(){} // RVA: 0x7FFAC2C70A40
        public void get_HasRegisteredEvents(){} // RVA: 0x7FFAC2C59D00
    }

    public class IPAddressInformation : Object
    {
        public object Address;

        // ── Methods ──
        public void get_Address(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IPGlobalProperties : Object
    {
        public object DomainName;

        // ── Methods ──
        public void GetIPGlobalProperties(){} // RVA: 0x7FFAC9325E90
        public void InternalGetIPGlobalProperties(){} // RVA: 0x7FFAC9325E90
        public void get_DomainName(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IPGlobalPropertiesFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9325E90
    }

    public class IPInterfaceProperties : Object
    {
        public object UnicastAddresses;

        // ── Methods ──
        public void get_UnicastAddresses(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IPv4InterfaceStatistics : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class LinuxNetworkChange : Object
    {
        public object HasRegisteredEvents; // 0x10
        public System.Net.Sockets.Socket nl_sock; // 0x18
        public System.Net.Sockets.SocketAsyncEventArgs nl_args; // 0x20
        public 0x6B13F2A0 pending_events; // 0x28
        public System.Threading.Timer timer; // 0x30
        public System.Net.NetworkInformation.NetworkAddressChangedEventHandler AddressChanged; // 0x38
        public System.Net.NetworkInformation.NetworkAvailabilityChangedEventHandler AvailabilityChanged; // 0x40

        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x7FFAC93287A0
        public void remove_NetworkAddressChanged(){} // RVA: 0x7FFAC93288A0
        public void get_HasRegisteredEvents(){} // RVA: 0x7FFAC93288B0
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void EnsureSocket(){} // RVA: 0x7FFAC93288D0
        public void MaybeCloseSocket(){} // RVA: 0x7FFAC9328A80
        public void GetAvailability(){} // RVA: 0x7FFAC9328AF0
        public void OnAvailabilityChanged(){} // RVA: 0x7FFAC9328BD0
        public void OnAddressChanged(){} // RVA: 0x7FFAC9328D40
        public void OnEventDue(){} // RVA: 0x7FFAC9328DC0
        public void QueueEvent(){} // RVA: 0x7FFAC9329090
        public void OnDataAvailable(){} // RVA: 0x7FFAC93293B0
        public void Register(){} // RVA: 0x7FFAC93287A0
        public void Unregister(){} // RVA: 0x7FFAC9329490
        public void CreateNLSocket(){} // RVA: 0x7FFAC9329700
        public void ReadEvents(){} // RVA: 0x7FFAC9329710
        public void CloseNLSocket(){} // RVA: 0x7FFAC9329720
        public void .ctor(){} // RVA: 0x7FFAC9329730
    }

    public class MacNetworkChange : Object
    {
        public UIntPtr IsAvailable; // 0x10
        public UIntPtr HasRegisteredEvents; // 0x18
        public SCNetworkReachabilityCallback callback; // 0x20
        public bool scheduledWithRunLoop; // 0x28
        public 0x6B13F1F0 flags; // 0x2C
        public System.Net.NetworkInformation.NetworkAddressChangedEventHandler networkAddressChanged; // 0x30
        public System.Net.NetworkInformation.NetworkAvailabilityChangedEventHandler networkAvailabilityChanged; // 0x38

        // ── Methods ──
        public void dlopen(){} // RVA: 0x7FFAC93272D0
        public void dlsym(){} // RVA: 0x7FFAC9327380
        public void dlclose(){} // RVA: 0x7FFAC9327440
        public void CFRelease(){} // RVA: 0x7FFAC93274C0
        public void CFRunLoopGetMain(){} // RVA: 0x7FFAC9327540
        public void SCNetworkReachabilityCreateWithAddress(){} // RVA: 0x7FFAC93275B0
        public void SCNetworkReachabilityGetFlags(){} // RVA: 0x7FFAC9327640
        public void SCNetworkReachabilitySetCallback(){} // RVA: 0x7FFAC93276D0
        public void SCNetworkReachabilityScheduleWithRunLoop(){} // RVA: 0x7FFAC9327780
        public void SCNetworkReachabilityUnscheduleFromRunLoop(){} // RVA: 0x7FFAC9327820
        public void add_networkAddressChanged(){} // RVA: 0x7FFAC93278C0
        public void remove_networkAddressChanged(){} // RVA: 0x7FFAC93279B0
        public void add_NetworkAddressChanged(){} // RVA: 0x7FFAC9327AA0
        public void remove_NetworkAddressChanged(){} // RVA: 0x7FFAC93279B0
        public void get_IsAvailable(){} // RVA: 0x7FFAC9327BF0
        public void get_HasRegisteredEvents(){} // RVA: 0x7FFAC9327C10
        public void .ctor(){} // RVA: 0x7FFAC9327C30
        public void LoadRunLoopMode(){} // RVA: 0x7FFAC9328070
        public void Dispose(){} // RVA: 0x7FFAC9328310
        public void HandleCallback(){} // RVA: 0x7FFAC93285E0
    }

    public class NetworkAddressChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5C4D540
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class NetworkAvailabilityChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class NetworkAvailabilityEventArgs : EventArgs
    {
        public bool isAvailable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9325F10
    }

    public class NetworkChange : Object
    {
        public System.Net.NetworkInformation.INetworkChange IsWindows;

        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x7FFAC9326AD0
        public void remove_NetworkAddressChanged(){} // RVA: 0x7FFAC9326CF0
        public void MaybeCreate(){} // RVA: 0x7FFAC9327020
        public void get_IsWindows(){} // RVA: 0x7FFAC85FF0B0
        public void MaybeDispose(){} // RVA: 0x7FFAC93271C0
    }

    public class NetworkInformationException : Win32Exception
    {
        public object ErrorCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92B3550 | overloaded x3
        public void get_ErrorCode(){} // RVA: 0x7FFAC3220660
    }

    public class NetworkInterface : Object
    {
        public object Id;
        public object OperationalStatus;
        public object NetworkInterfaceType;

        // ── Methods ──
        public void GetAllNetworkInterfaces(){} // RVA: 0x7FFAC9326030
        public void get_Id(){} // RVA: 0x7FFAC9326080
        public void GetIPProperties(){} // RVA: 0x7FFAC93260C0
        public void get_OperationalStatus(){} // RVA: 0x7FFAC9326100
        public void GetPhysicalAddress(){} // RVA: 0x7FFAC9326140
        public void get_NetworkInterfaceType(){} // RVA: 0x7FFAC9326180
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NetworkInterfaceFactory : Object
    {
        // ── Methods ──
        public void GetAllNetworkInterfaces(){} // RVA: 0x7FFAC2C58E90
        public void Create(){} // RVA: 0x7FFAC93299E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NetworkInterfaceFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC93299E0
    }

    public class PhysicalAddress : Object
    {
        public byte[] address; // 0x10
        public bool changed; // 0x18
        public int hash; // 0x1C
        public System.Net.NetworkInformation.PhysicalAddress None;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84DFEC0
        public void GetHashCode(){} // RVA: 0x7FFAC93261C0
        public void Equals(){} // RVA: 0x7FFAC93262D0
        public void ToString(){} // RVA: 0x7FFAC93263D0
        public void .cctor(){} // RVA: 0x7FFAC9326530
    }

    public class Ping : Component
    {
        public string[] PingBinPaths;
        public string PingBinPath; // 0x8
        public bool canSendPrivileged; // 0x10
        public ushort identifier; // 0x28
        public byte[] default_buffer; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9329AE0
        public void .ctor(){} // RVA: 0x7FFAC9329ED0
        public void capget(){} // RVA: 0x7FFAC932A010
        public void CheckLinuxCapabilities(){} // RVA: 0x7FFAC932A0A0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
    }

    public class SystemNetworkInterface : Object
    {
        public System.Net.NetworkInformation.NetworkInterfaceFactory nif;

        // ── Methods ──
        public void GetNetworkInterfaces(){} // RVA: 0x7FFAC93297C0
        public void .cctor(){} // RVA: 0x7FFAC9329850
    }

    public class UnicastIPAddressInformation : IPAddressInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UnicastIPAddressInformationCollection : Object
    {
        public System.Collections.ObjectModel.Collection`1<System.Net.NetworkInformation.UnicastIPAddressInformation> Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9326660
        public void CopyTo(){} // RVA: 0x7FFAC9326720
        public void get_Count(){} // RVA: 0x7FFAC93267C0
        public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void Add(){} // RVA: 0x7FFAC9326840
        public void InternalAdd(){} // RVA: 0x7FFAC93268A0
        public void Contains(){} // RVA: 0x7FFAC9326900
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8D92640
        public void GetEnumerator(){} // RVA: 0x7FFAC9326990
        public void Remove(){} // RVA: 0x7FFAC9326A10
        public void Clear(){} // RVA: 0x7FFAC9326A70
    }

    public class UnixIPGlobalPropertiesFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC34F9180
    }

    public class UnixNetworkInterfaceFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC34F9180
    }

    public class Win32IPGlobalProperties : IPGlobalProperties
    {
        public object DomainName;

        // ── Methods ──
        public void get_DomainName(){} // RVA: 0x7FFAC932A1F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Win32IPGlobalPropertiesFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC932A210
    }

    public class Win32IPInterfaceProperties2 : IPInterfaceProperties
    {
        public System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES UnicastAddresses; // 0x10
        public System.Net.NetworkInformation.Win32_MIB_IFROW mib4; // 0x118
        public System.Net.NetworkInformation.Win32_MIB_IFROW mib6; // 0x188

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC932A250
        public void get_UnicastAddresses(){} // RVA: 0x7FFAC932A480
        public void Win32FromUnicast(){} // RVA: 0x7FFAC932A4C0
    }

    public class Win32IPv4InterfaceStatistics : IPv4InterfaceStatistics
    {
        public System.Net.NetworkInformation.Win32_MIB_IFROW info; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC932A720
    }

    public class Win32LengthFlagsUnion : ValueType
    {
        public uint Length; // 0x10
        public uint Flags; // 0x14
    }

    public class Win32NetworkInterface : Object
    {
        public System.Net.NetworkInformation.Win32_FIXED_INFO FixedInfo;
        public bool initialized; // 0x58

        // ── Methods ──
        public void GetNetworkParams(){} // RVA: 0x7FFAC932BD20
        public void MultiByteToWideChar(){} // RVA: 0x7FFAC932BDC0
        public void get_FixedInfo(){} // RVA: 0x7FFAC932BE90
        public void <get_FixedInfo>g__GetStringFromMultiByte|5_0(){} // RVA: 0x7FFAC932C500
    }

    public class Win32NetworkInterface2 : NetworkInterface
    {
        public System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES Id; // 0x10
        public System.Net.NetworkInformation.Win32_MIB_IFROW NetworkInterfaceType; // 0x118
        public System.Net.NetworkInformation.Win32_MIB_IFROW OperationalStatus; // 0x188
        public System.Net.NetworkInformation.Win32IPv4InterfaceStatistics ip4stats; // 0x1F8
        public System.Net.NetworkInformation.IPInterfaceProperties ip_if_props; // 0x200

        // ── Methods ──
        public void GetIfEntry(){} // RVA: 0x7FFAC932B260
        public void .ctor(){} // RVA: 0x7FFAC932B3E0
        public void GetIPProperties(){} // RVA: 0x7FFAC3544790
        public void GetPhysicalAddress(){} // RVA: 0x7FFAC932BB60
        public void get_Id(){} // RVA: 0x7FFAC2F4F0C0
        public void get_NetworkInterfaceType(){} // RVA: 0x7FFAC43D9E20
        public void get_OperationalStatus(){} // RVA: 0x7FFAC4596EF0
    }

    public class Win32NetworkInterfaceAPI : NetworkInterfaceFactory
    {
        // ── Methods ──
        public void GetAdaptersAddresses(){} // RVA: 0x7FFAC932A870 | overloaded x2
        public void GetAllNetworkInterfaces(){} // RVA: 0x7FFAC932AFE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Win32NetworkInterfaceFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC932BC60
    }

    public class Win32UnicastIPAddressInformation : UnicastIPAddressInformation
    {
        public System.Net.NetworkInformation.Win32_IP_ADAPTER_UNICAST_ADDRESS Address; // 0x10
        public System.Net.IPAddress ipv4Mask; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC932C860
        public void get_Address(){} // RVA: 0x7FFAC932CA80
        public void PrefixLengthToSubnetMask(){} // RVA: 0x7FFAC932CA90
    }

    public class Win32_FIXED_INFO : ValueType
    {
        public string HostName; // 0x10
        public string DomainName; // 0x18
        public UIntPtr CurrentDnsServer; // 0x20
        public System.Net.NetworkInformation.Win32_IP_ADDR_STRING DnsServerList; // 0x28
        public 0x6B13EF88 NodeType; // 0x48
        public string ScopeId; // 0x50
        public uint EnableRouting; // 0x58
        public uint EnableProxy; // 0x5C
        public uint EnableDns; // 0x60
    }

    public class Win32_FIXED_INFO_Marshal : ValueType
    {
        public <HostName>e__FixedBuffer HostName; // 0x10
        public <DomainName>e__FixedBuffer DomainName; // 0x94
        public UIntPtr CurrentDnsServer; // 0x118
        public System.Net.NetworkInformation.Win32_IP_ADDR_STRING DnsServerList; // 0x120
        public 0x6B13EF88 NodeType; // 0x140
        public <ScopeId>e__FixedBuffer ScopeId; // 0x144
        public uint EnableRouting; // 0x248
        public uint EnableProxy; // 0x24C
        public uint EnableDns; // 0x250
    }

    public class Win32_IP_ADAPTER_ADDRESSES : ValueType
    {
        public System.Net.NetworkInformation.AlignmentUnion Alignment; // 0x10
        public UIntPtr Next; // 0x18
        public string AdapterName; // 0x20
        public UIntPtr FirstUnicastAddress; // 0x28
        public UIntPtr FirstAnycastAddress; // 0x30
        public UIntPtr FirstMulticastAddress; // 0x38
        public UIntPtr FirstDnsServerAddress; // 0x40
        public string DnsSuffix; // 0x48
        public string Description; // 0x50
        public string FriendlyName; // 0x58
        public byte[] PhysicalAddress; // 0x60
        public uint PhysicalAddressLength; // 0x68
        public uint Flags; // 0x6C
        public uint Mtu; // 0x70
        public 0x6B13EF30 IfType; // 0x74
        public 0x6B13ED20 OperStatus; // 0x78
        public int Ipv6IfIndex; // 0x7C
        public uint[] ZoneIndices; // 0x80
        public UIntPtr FirstPrefix; // 0x88
        public ulong TransmitLinkSpeed; // 0x90
        public ulong ReceiveLinkSpeed; // 0x98
        public UIntPtr FirstWinsServerAddress; // 0xA0
        public UIntPtr FirstGatewayAddress; // 0xA8
        public uint Ipv4Metric; // 0xB0
        public uint Ipv6Metric; // 0xB4
        public ulong Luid; // 0xB8
        public System.Net.NetworkInformation.Win32_SOCKET_ADDRESS Dhcpv4Server; // 0xC0
        public uint CompartmentId; // 0xD0
        public ulong NetworkGuid; // 0xD8
        public int ConnectionType; // 0xE0
        public int TunnelType; // 0xE4
        public System.Net.NetworkInformation.Win32_SOCKET_ADDRESS Dhcpv6Server; // 0xE8
        public byte[] Dhcpv6ClientDuid; // 0xF8
        public ulong Dhcpv6ClientDuidLength; // 0x100
        public ulong Dhcpv6Iaid; // 0x108
        public UIntPtr FirstDnsSuffix; // 0x110
    }

    public class Win32_IP_ADAPTER_UNICAST_ADDRESS : ValueType
    {
        public System.Net.NetworkInformation.Win32LengthFlagsUnion LengthFlags; // 0x10
        public UIntPtr Next; // 0x18
        public System.Net.NetworkInformation.Win32_SOCKET_ADDRESS Address; // 0x20
        public 0x6B13EDD0 PrefixOrigin; // 0x30
        public 0x6B13EE28 SuffixOrigin; // 0x34
        public 0x6B13E958 DadState; // 0x38
        public uint ValidLifetime; // 0x3C
        public uint PreferredLifetime; // 0x40
        public uint LeaseLifetime; // 0x44
        public byte OnLinkPrefixLength; // 0x48
    }

    public class Win32_IP_ADDR_STRING : ValueType
    {
        public UIntPtr Next; // 0x10
        public string IpAddress; // 0x18
        public string IpMask; // 0x20
        public uint Context; // 0x28
    }

    public class Win32_MIB_IFROW : ValueType
    {
        public char[] Name; // 0x10
        public int Index; // 0x18
        public 0x6B13EF30 Type; // 0x1C
        public int Mtu; // 0x20
        public uint Speed; // 0x24
        public int PhysAddrLen; // 0x28
        public byte[] PhysAddr; // 0x30
        public uint AdminStatus; // 0x38
        public uint OperStatus; // 0x3C
        public uint LastChange; // 0x40
        public int InOctets; // 0x44
        public int InUcastPkts; // 0x48
        public int InNUcastPkts; // 0x4C
        public int InDiscards; // 0x50
        public int InErrors; // 0x54
        public int InUnknownProtos; // 0x58
        public int OutOctets; // 0x5C
        public int OutUcastPkts; // 0x60
        public int OutNUcastPkts; // 0x64
        public int OutDiscards; // 0x68
        public int OutErrors; // 0x6C
        public int OutQLen; // 0x70
        public int DescrLen; // 0x74
        public byte[] Descr; // 0x78
    }

    public class Win32_SOCKADDR : ValueType
    {
        public ushort AddressFamily; // 0x10
        public byte[] AddressData; // 0x18
    }

    public class Win32_SOCKET_ADDRESS : ValueType
    {
        public UIntPtr Sockaddr; // 0x10
        public int SockaddrLength; // 0x18

        // ── Methods ──
        public void GetIPAddress(){} // RVA: 0x7FFAC932C600
    }

}