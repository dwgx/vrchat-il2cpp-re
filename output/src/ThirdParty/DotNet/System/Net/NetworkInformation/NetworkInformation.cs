// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.NetworkInformation
// Classes: 42
// Methods: 129

namespace ThirdParty.DotNet.System.Net.NetworkInformation
{
    public class AlignmentUnion
    {
    }

    public class INetworkChange
    {
        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x24B10
        public void remove_NetworkAddressChanged(){} // RVA: 0x24B10
        public void get_HasRegisteredEvents(){} // RVA: 0xDBE0
    }

    public class IPAddressInformation
    {
        // ── Methods ──
        public void get_Address(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IPGlobalProperties
    {
        // ── Methods ──
        public void GetIPGlobalProperties(){} // RVA: 0x6B8F310
        public void InternalGetIPGlobalProperties(){} // RVA: 0x6B8F310
        public void get_DomainName(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IPGlobalPropertiesFactoryPal
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x6B8F310
    }

    public class IPInterfaceProperties
    {
        // ── Methods ──
        public void get_UnicastAddresses(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IPv4InterfaceStatistics
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LinuxNetworkChange
    {
        public object _lock; // 0x10

        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x6B91C20
        public void remove_NetworkAddressChanged(){} // RVA: 0x6B91D20
        public void get_HasRegisteredEvents(){} // RVA: 0x6B91D30
        public void Dispose(){} // RVA: 0x2DD310
        public void EnsureSocket(){} // RVA: 0x6B91D50
        public void MaybeCloseSocket(){} // RVA: 0x6B91F00
        public void GetAvailability(){} // RVA: 0x6B91F70
        public void OnAvailabilityChanged(){} // RVA: 0x6B92050
        public void OnAddressChanged(){} // RVA: 0x6B921C0
        public void OnEventDue(){} // RVA: 0x6B92240
        public void QueueEvent(){} // RVA: 0x6B92510
        public void OnDataAvailable(){} // RVA: 0x6B92830
        public void Register(){} // RVA: 0x6B91C20
        public void Unregister(){} // RVA: 0x6B92910
        public void CreateNLSocket(){} // RVA: 0x6B92B80
        public void ReadEvents(){} // RVA: 0x6B92B90
        public void CloseNLSocket(){} // RVA: 0x6B92BA0
        public void .ctor(){} // RVA: 0x6B92BB0
    }

    public class MacNetworkChange
    {
        public UIntPtr handle; // 0x10
        public UIntPtr runLoopMode; // 0x18

        // ── Methods ──
        public void dlopen(){} // RVA: 0x6B90750
        public void dlsym(){} // RVA: 0x6B90800
        public void dlclose(){} // RVA: 0x6B908C0
        public void CFRelease(){} // RVA: 0x6B90940
        public void CFRunLoopGetMain(){} // RVA: 0x6B909C0
        public void SCNetworkReachabilityCreateWithAddress(){} // RVA: 0x6B90A30
        public void SCNetworkReachabilityGetFlags(){} // RVA: 0x6B90AC0
        public void SCNetworkReachabilitySetCallback(){} // RVA: 0x6B90B50
        public void SCNetworkReachabilityScheduleWithRunLoop(){} // RVA: 0x6B90C00
        public void SCNetworkReachabilityUnscheduleFromRunLoop(){} // RVA: 0x6B90CA0
        public void add_networkAddressChanged(){} // RVA: 0x6B90D40
        public void remove_networkAddressChanged(){} // RVA: 0x6B90E30
        public void add_NetworkAddressChanged(){} // RVA: 0x6B90F20
        public void remove_NetworkAddressChanged(){} // RVA: 0x6B90E30
        public void get_IsAvailable(){} // RVA: 0x6B91070
        public void get_HasRegisteredEvents(){} // RVA: 0x6B91090
        public void .ctor(){} // RVA: 0x6B910B0
        public void LoadRunLoopMode(){} // RVA: 0x6B914F0
        public void Dispose(){} // RVA: 0x6B91790
        public void HandleCallback(){} // RVA: 0x6B91A60
    }

    public class NetworkAddressChangedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33076C0
        public void Invoke(){} // RVA: 0x439370
    }

    public class NetworkAvailabilityChangedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class NetworkAvailabilityEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B8F390
    }

    public class NetworkChange
    {
        public System.Net.NetworkInformation.INetworkChange networkChange;

        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x6B8FF50
        public void remove_NetworkAddressChanged(){} // RVA: 0x6B90170
        public void MaybeCreate(){} // RVA: 0x6B904A0
        public void get_IsWindows(){} // RVA: 0x5E67A40
        public void MaybeDispose(){} // RVA: 0x6B90640
    }

    public class NetworkInformationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B1C9D0 | overloaded x3
        public void get_ErrorCode(){} // RVA: 0x6AFD40
    }

    public class NetworkInterface
    {
        // ── Methods ──
        public void GetAllNetworkInterfaces(){} // RVA: 0x6B8F4B0
        public void get_Id(){} // RVA: 0x6B8F500
        public void GetIPProperties(){} // RVA: 0x6B8F540
        public void get_OperationalStatus(){} // RVA: 0x6B8F580
        public void GetPhysicalAddress(){} // RVA: 0x6B8F5C0
        public void get_NetworkInterfaceType(){} // RVA: 0x6B8F600
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NetworkInterfaceFactory
    {
        // ── Methods ──
        public void GetAllNetworkInterfaces(){} // RVA: 0xCD60
        public void Create(){} // RVA: 0x6B92E60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NetworkInterfaceFactoryPal
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x6B92E60
    }

    public class PhysicalAddress
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D487F0
        public void GetHashCode(){} // RVA: 0x6B8F640
        public void Equals(){} // RVA: 0x6B8F750
        public void ToString(){} // RVA: 0x6B8F850
        public void .cctor(){} // RVA: 0x6B8F9B0
    }

    public class Ping
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6B92F60
        public void .ctor(){} // RVA: 0x6B93350
        public void capget(){} // RVA: 0x6B93490
        public void CheckLinuxCapabilities(){} // RVA: 0x6B93520
        public void System.IDisposable.Dispose(){} // RVA: 0x2DD310
    }

    public class SystemNetworkInterface
    {
        // ── Methods ──
        public void GetNetworkInterfaces(){} // RVA: 0x6B92C40
        public void .cctor(){} // RVA: 0x6B92CD0
    }

    public class UnicastIPAddressInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UnicastIPAddressInformationCollection
    {
        public System.Collections.ObjectModel.Collection`1<System.Net.NetworkInformation.UnicastIPAddressInformation> addresses; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B8FAE0
        public void CopyTo(){} // RVA: 0x6B8FBA0
        public void get_Count(){} // RVA: 0x6B8FC40
        public void get_IsReadOnly(){} // RVA: 0x3C2850
        public void Add(){} // RVA: 0x6B8FCC0
        public void InternalAdd(){} // RVA: 0x6B8FD20
        public void Contains(){} // RVA: 0x6B8FD80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x1854290
        public void GetEnumerator(){} // RVA: 0x6B8FE10
        public void Remove(){} // RVA: 0x6B8FE90
        public void Clear(){} // RVA: 0x6B8FEF0
    }

    public class UnixIPGlobalPropertiesFactoryPal
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x519240
    }

    public class UnixNetworkInterfaceFactoryPal
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x519240
    }

    public class Win32IPGlobalProperties
    {
        // ── Methods ──
        public void get_DomainName(){} // RVA: 0x6B93670
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Win32IPGlobalPropertiesFactoryPal
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x6B93690
    }

    public class Win32IPInterfaceProperties2
    {
        public System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES addr; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B936D0
        public void get_UnicastAddresses(){} // RVA: 0x6B93900
        public void Win32FromUnicast(){} // RVA: 0x6B93940
    }

    public class Win32IPv4InterfaceStatistics
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B93BA0
    }

    public class Win32LengthFlagsUnion
    {
    }

    public class Win32NetworkInterface
    {
        public System.Net.NetworkInformation.Win32_FIXED_INFO fixedInfo;

        // ── Methods ──
        public void GetNetworkParams(){} // RVA: 0x6B951A0
        public void MultiByteToWideChar(){} // RVA: 0x6B95240
        public void get_FixedInfo(){} // RVA: 0x6B95310
        public void <get_FixedInfo>g__GetStringFromMultiByte|5_0(){} // RVA: 0x6B95980
    }

    public class Win32NetworkInterface2
    {
        public System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES addr; // 0x10
        public System.Net.NetworkInformation.Win32_MIB_IFROW mib4; // 0x118
        public System.Net.NetworkInformation.Win32_MIB_IFROW mib6; // 0x188

        // ── Methods ──
        public void GetIfEntry(){} // RVA: 0x6B946E0
        public void .ctor(){} // RVA: 0x6B94860
        public void GetIPProperties(){} // RVA: 0xD9E9A0
        public void GetPhysicalAddress(){} // RVA: 0x6B94FE0
        public void get_Id(){} // RVA: 0x30B0C0
        public void get_NetworkInterfaceType(){} // RVA: 0x1929080
        public void get_OperationalStatus(){} // RVA: 0x1AE3800
    }

    public class Win32NetworkInterfaceAPI
    {
        // ── Methods ──
        public void GetAdaptersAddresses(){} // RVA: 0x6B93CF0 | overloaded x2
        public void GetAllNetworkInterfaces(){} // RVA: 0x6B94460
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Win32NetworkInterfaceFactoryPal
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x6B950E0
    }

    public class Win32UnicastIPAddressInformation
    {
        public System.Net.NetworkInformation.Win32_IP_ADAPTER_UNICAST_ADDRESS info; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B95CE0
        public void get_Address(){} // RVA: 0x6B95F00
        public void PrefixLengthToSubnetMask(){} // RVA: 0x6B95F10
    }

    public class Win32_FIXED_INFO
    {
    }

    public class Win32_FIXED_INFO_Marshal
    {
    }

    public class Win32_IP_ADAPTER_ADDRESSES
    {
    }

    public class Win32_IP_ADAPTER_UNICAST_ADDRESS
    {
    }

    public class Win32_IP_ADDR_STRING
    {
    }

    public class Win32_MIB_IFROW
    {
    }

    public class Win32_SOCKADDR
    {
    }

    public class Win32_SOCKET_ADDRESS
    {
        // ── Methods ──
        public void GetIPAddress(){} // RVA: 0x6B95A80
    }

}