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
        public void add_NetworkAddressChanged(){} // RVA: 0x7FFAF2AD4B10
        public void remove_NetworkAddressChanged(){} // RVA: 0x7FFAF2AD4B10
        public void get_HasRegisteredEvents(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class IPAddressInformation
    {
        // ── Methods ──
        public void get_Address(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class IPGlobalProperties
    {
        // ── Methods ──
        public void GetIPGlobalProperties(){} // RVA: 0x7FFAF963F310
        public void InternalGetIPGlobalProperties(){} // RVA: 0x7FFAF963F310
        public void get_DomainName(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class IPGlobalPropertiesFactoryPal
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF963F310
    }

    public class IPInterfaceProperties
    {
        // ── Methods ──
        public void get_UnicastAddresses(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class IPv4InterfaceStatistics
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class LinuxNetworkChange
    {
        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x7FFAF9641C20
        public void remove_NetworkAddressChanged(){} // RVA: 0x7FFAF9641D20
        public void get_HasRegisteredEvents(){} // RVA: 0x7FFAF9641D30
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
        public void EnsureSocket(){} // RVA: 0x7FFAF9641D50
        public void MaybeCloseSocket(){} // RVA: 0x7FFAF9641F00
        public void GetAvailability(){} // RVA: 0x7FFAF9641F70
        public void OnAvailabilityChanged(){} // RVA: 0x7FFAF9642050
        public void OnAddressChanged(){} // RVA: 0x7FFAF96421C0
        public void OnEventDue(){} // RVA: 0x7FFAF9642240
        public void QueueEvent(){} // RVA: 0x7FFAF9642510
        public void OnDataAvailable(){} // RVA: 0x7FFAF9642830
        public void Register(){} // RVA: 0x7FFAF9641C20
        public void Unregister(){} // RVA: 0x7FFAF9642910
        public void CreateNLSocket(){} // RVA: 0x7FFAF9642B80
        public void ReadEvents(){} // RVA: 0x7FFAF9642B90
        public void CloseNLSocket(){} // RVA: 0x7FFAF9642BA0
        public void .ctor(){} // RVA: 0x7FFAF9642BB0
    }

    public class MacNetworkChange
    {
        // ── Methods ──
        public void dlopen(){} // RVA: 0x7FFAF9640750
        public void dlsym(){} // RVA: 0x7FFAF9640800
        public void dlclose(){} // RVA: 0x7FFAF96408C0
        public void CFRelease(){} // RVA: 0x7FFAF9640940
        public void CFRunLoopGetMain(){} // RVA: 0x7FFAF96409C0
        public void SCNetworkReachabilityCreateWithAddress(){} // RVA: 0x7FFAF9640A30
        public void SCNetworkReachabilityGetFlags(){} // RVA: 0x7FFAF9640AC0
        public void SCNetworkReachabilitySetCallback(){} // RVA: 0x7FFAF9640B50
        public void SCNetworkReachabilityScheduleWithRunLoop(){} // RVA: 0x7FFAF9640C00
        public void SCNetworkReachabilityUnscheduleFromRunLoop(){} // RVA: 0x7FFAF9640CA0
        public void add_networkAddressChanged(){} // RVA: 0x7FFAF9640D40
        public void remove_networkAddressChanged(){} // RVA: 0x7FFAF9640E30
        public void add_NetworkAddressChanged(){} // RVA: 0x7FFAF9640F20
        public void remove_NetworkAddressChanged(){} // RVA: 0x7FFAF9640E30
        public void get_IsAvailable(){} // RVA: 0x7FFAF9641070
        public void get_HasRegisteredEvents(){} // RVA: 0x7FFAF9641090
        public void .ctor(){} // RVA: 0x7FFAF96410B0
        public void LoadRunLoopMode(){} // RVA: 0x7FFAF96414F0
        public void Dispose(){} // RVA: 0x7FFAF9641790
        public void HandleCallback(){} // RVA: 0x7FFAF9641A60
    }

    public class NetworkAddressChangedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5DB76C0
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
    }

    public class NetworkAvailabilityChangedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45AE240
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
    }

    public class NetworkAvailabilityEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF963F390
    }

    public class NetworkChange
    {
        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x7FFAF963FF50
        public void remove_NetworkAddressChanged(){} // RVA: 0x7FFAF9640170
        public void MaybeCreate(){} // RVA: 0x7FFAF96404A0
        public void get_IsWindows(){} // RVA: 0x7FFAF8917A40
        public void MaybeDispose(){} // RVA: 0x7FFAF9640640
    }

    public class NetworkInformationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95CC9D0 | overloaded x3
        public void get_ErrorCode(){} // RVA: 0x7FFAF315FD40
    }

    public class NetworkInterface
    {
        // ── Methods ──
        public void GetAllNetworkInterfaces(){} // RVA: 0x7FFAF963F4B0
        public void get_Id(){} // RVA: 0x7FFAF963F500
        public void GetIPProperties(){} // RVA: 0x7FFAF963F540
        public void get_OperationalStatus(){} // RVA: 0x7FFAF963F580
        public void GetPhysicalAddress(){} // RVA: 0x7FFAF963F5C0
        public void get_NetworkInterfaceType(){} // RVA: 0x7FFAF963F600
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class NetworkInterfaceFactory
    {
        // ── Methods ──
        public void GetAllNetworkInterfaces(){} // RVA: 0x7FFAF2ABCD60
        public void Create(){} // RVA: 0x7FFAF9642E60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class NetworkInterfaceFactoryPal
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF9642E60
    }

    public class PhysicalAddress
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87F87F0
        public void GetHashCode(){} // RVA: 0x7FFAF963F640
        public void Equals(){} // RVA: 0x7FFAF963F750
        public void ToString(){} // RVA: 0x7FFAF963F850
        public void .cctor(){} // RVA: 0x7FFAF963F9B0
    }

    public class Ping
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF9642F60
        public void .ctor(){} // RVA: 0x7FFAF9643350
        public void capget(){} // RVA: 0x7FFAF9643490
        public void CheckLinuxCapabilities(){} // RVA: 0x7FFAF9643520
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAF2D8D310
    }

    public class SystemNetworkInterface
    {
        // ── Methods ──
        public void GetNetworkInterfaces(){} // RVA: 0x7FFAF9642C40
        public void .cctor(){} // RVA: 0x7FFAF9642CD0
    }

    public class UnicastIPAddressInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class UnicastIPAddressInformationCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF963FAE0
        public void CopyTo(){} // RVA: 0x7FFAF963FBA0
        public void get_Count(){} // RVA: 0x7FFAF963FC40
        public void get_IsReadOnly(){} // RVA: 0x7FFAF2E72850
        public void Add(){} // RVA: 0x7FFAF963FCC0
        public void InternalAdd(){} // RVA: 0x7FFAF963FD20
        public void Contains(){} // RVA: 0x7FFAF963FD80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF4304290
        public void GetEnumerator(){} // RVA: 0x7FFAF963FE10
        public void Remove(){} // RVA: 0x7FFAF963FE90
        public void Clear(){} // RVA: 0x7FFAF963FEF0
    }

    public class UnixIPGlobalPropertiesFactoryPal
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF2FC9240
    }

    public class UnixNetworkInterfaceFactoryPal
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF2FC9240
    }

    public class Win32IPGlobalProperties
    {
        // ── Methods ──
        public void get_DomainName(){} // RVA: 0x7FFAF9643670
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Win32IPGlobalPropertiesFactoryPal
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF9643690
    }

    public class Win32IPInterfaceProperties2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96436D0
        public void get_UnicastAddresses(){} // RVA: 0x7FFAF9643900
        public void Win32FromUnicast(){} // RVA: 0x7FFAF9643940
    }

    public class Win32IPv4InterfaceStatistics
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9643BA0
    }

    public class Win32LengthFlagsUnion
    {
    }

    public class Win32NetworkInterface
    {
        // ── Methods ──
        public void GetNetworkParams(){} // RVA: 0x7FFAF96451A0
        public void MultiByteToWideChar(){} // RVA: 0x7FFAF9645240
        public void get_FixedInfo(){} // RVA: 0x7FFAF9645310
        public void <get_FixedInfo>g__GetStringFromMultiByte|5_0(){} // RVA: 0x7FFAF9645980
    }

    public class Win32NetworkInterface2
    {
        // ── Methods ──
        public void GetIfEntry(){} // RVA: 0x7FFAF96446E0
        public void .ctor(){} // RVA: 0x7FFAF9644860
        public void GetIPProperties(){} // RVA: 0x7FFAF384E9A0
        public void GetPhysicalAddress(){} // RVA: 0x7FFAF9644FE0
        public void get_Id(){} // RVA: 0x7FFAF2DBB0C0
        public void get_NetworkInterfaceType(){} // RVA: 0x7FFAF43D9080
        public void get_OperationalStatus(){} // RVA: 0x7FFAF4593800
    }

    public class Win32NetworkInterfaceAPI
    {
        // ── Methods ──
        public void GetAdaptersAddresses(){} // RVA: 0x7FFAF9643CF0 | overloaded x2
        public void GetAllNetworkInterfaces(){} // RVA: 0x7FFAF9644460
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Win32NetworkInterfaceFactoryPal
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF96450E0
    }

    public class Win32UnicastIPAddressInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9645CE0
        public void get_Address(){} // RVA: 0x7FFAF9645F00
        public void PrefixLengthToSubnetMask(){} // RVA: 0x7FFAF9645F10
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
        public void GetIPAddress(){} // RVA: 0x7FFAF9645A80
    }

}