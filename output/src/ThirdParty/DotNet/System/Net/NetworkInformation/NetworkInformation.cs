// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.NetworkInformation
// Classes: 42
// Methods: 129

namespace ThirdParty.DotNet.System.Net.NetworkInformation
{
    public class AlignmentUnion : ValueType
    {
    }

    public class INetworkChange
    {
        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x7FFE80E460A0
        public void remove_NetworkAddressChanged(){} // RVA: 0x7FFE80E460A0
        public void get_HasRegisteredEvents(){} // RVA: 0x7FFE80E2F150
    }

    public class IPAddressInformation : Object
    {
        // ── Methods ──
        public void get_Address(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IPGlobalProperties : Object
    {
        // ── Methods ──
        public void GetIPGlobalProperties(){} // RVA: 0x7FFE876CE5C0
        public void InternalGetIPGlobalProperties(){} // RVA: 0x7FFE876CE5C0
        public void get_DomainName(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IPGlobalPropertiesFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE876CE5C0
    }

    public class IPInterfaceProperties : Object
    {
        // ── Methods ──
        public void get_UnicastAddresses(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IPv4InterfaceStatistics : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class LinuxNetworkChange : Object
    {
        public object _lock; // 0x10

        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x7FFE876D0ED0
        public void remove_NetworkAddressChanged(){} // RVA: 0x7FFE876D0FD0
        public void get_HasRegisteredEvents(){} // RVA: 0x7FFE876D0FE0
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void EnsureSocket(){} // RVA: 0x7FFE876D1000
        public void MaybeCloseSocket(){} // RVA: 0x7FFE876D11B0
        public void GetAvailability(){} // RVA: 0x7FFE876D1220
        public void OnAvailabilityChanged(){} // RVA: 0x7FFE876D1300
        public void OnAddressChanged(){} // RVA: 0x7FFE876D1470
        public void OnEventDue(){} // RVA: 0x7FFE876D14F0
        public void QueueEvent(){} // RVA: 0x7FFE876D17C0
        public void OnDataAvailable(){} // RVA: 0x7FFE876D1AE0
        public void Register(){} // RVA: 0x7FFE876D0ED0
        public void Unregister(){} // RVA: 0x7FFE876D1BC0
        public void CreateNLSocket(){} // RVA: 0x7FFE876D1E30
        public void ReadEvents(){} // RVA: 0x7FFE876D1E40
        public void CloseNLSocket(){} // RVA: 0x7FFE876D1E50
        public void .ctor(){} // RVA: 0x7FFE876D1E60
    }

    public class MacNetworkChange : Object
    {
        public UIntPtr handle; // 0x10
        public UIntPtr runLoopMode; // 0x18

        // ── Methods ──
        public void dlopen(){} // RVA: 0x7FFE876CFA00
        public void dlsym(){} // RVA: 0x7FFE876CFAB0
        public void dlclose(){} // RVA: 0x7FFE876CFB70
        public void CFRelease(){} // RVA: 0x7FFE876CFBF0
        public void CFRunLoopGetMain(){} // RVA: 0x7FFE876CFC70
        public void SCNetworkReachabilityCreateWithAddress(){} // RVA: 0x7FFE876CFCE0
        public void SCNetworkReachabilityGetFlags(){} // RVA: 0x7FFE876CFD70
        public void SCNetworkReachabilitySetCallback(){} // RVA: 0x7FFE876CFE00
        public void SCNetworkReachabilityScheduleWithRunLoop(){} // RVA: 0x7FFE876CFEB0
        public void SCNetworkReachabilityUnscheduleFromRunLoop(){} // RVA: 0x7FFE876CFF50
        public void add_networkAddressChanged(){} // RVA: 0x7FFE876CFFF0
        public void remove_networkAddressChanged(){} // RVA: 0x7FFE876D00E0
        public void add_NetworkAddressChanged(){} // RVA: 0x7FFE876D01D0
        public void remove_NetworkAddressChanged(){} // RVA: 0x7FFE876D00E0
        public void get_IsAvailable(){} // RVA: 0x7FFE876D0320
        public void get_HasRegisteredEvents(){} // RVA: 0x7FFE876D0340
        public void .ctor(){} // RVA: 0x7FFE876D0360
        public void LoadRunLoopMode(){} // RVA: 0x7FFE876D07A0
        public void Dispose(){} // RVA: 0x7FFE876D0A40
        public void HandleCallback(){} // RVA: 0x7FFE876D0D10
    }

    public class NetworkAddressChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83F84C40
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class NetworkAvailabilityChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class NetworkAvailabilityEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876CE640
    }

    public class NetworkChange : Object
    {
        public System.Net.NetworkInformation.INetworkChange networkChange;

        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x7FFE876CF200
        public void remove_NetworkAddressChanged(){} // RVA: 0x7FFE876CF420
        public void MaybeCreate(){} // RVA: 0x7FFE876CF750
        public void get_IsWindows(){} // RVA: 0x7FFE869A8880
        public void MaybeDispose(){} // RVA: 0x7FFE876CF8F0
    }

    public class NetworkInformationException : Win32Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8765BC90 | overloaded x3
        public void get_ErrorCode(){} // RVA: 0x7FFE814AA220
    }

    public class NetworkInterface : Object
    {
        // ── Methods ──
        public void GetAllNetworkInterfaces(){} // RVA: 0x7FFE876CE760
        public void get_Id(){} // RVA: 0x7FFE876CE7B0
        public void GetIPProperties(){} // RVA: 0x7FFE876CE7F0
        public void get_OperationalStatus(){} // RVA: 0x7FFE876CE830
        public void GetPhysicalAddress(){} // RVA: 0x7FFE876CE870
        public void get_NetworkInterfaceType(){} // RVA: 0x7FFE876CE8B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NetworkInterfaceFactory : Object
    {
        // ── Methods ──
        public void GetAllNetworkInterfaces(){} // RVA: 0x7FFE80E2E2E0
        public void Create(){} // RVA: 0x7FFE876D2110
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NetworkInterfaceFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE876D2110
    }

    public class PhysicalAddress : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868896F0
        public void GetHashCode(){} // RVA: 0x7FFE876CE8F0
        public void Equals(){} // RVA: 0x7FFE876CEA00
        public void ToString(){} // RVA: 0x7FFE876CEB00
        public void .cctor(){} // RVA: 0x7FFE876CEC60
    }

    public class Ping : Component
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE876D2210
        public void .ctor(){} // RVA: 0x7FFE876D2600
        public void capget(){} // RVA: 0x7FFE876D2740
        public void CheckLinuxCapabilities(){} // RVA: 0x7FFE876D27D0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE810FB310
    }

    public class SystemNetworkInterface : Object
    {
        // ── Methods ──
        public void GetNetworkInterfaces(){} // RVA: 0x7FFE876D1EF0
        public void .cctor(){} // RVA: 0x7FFE876D1F80
    }

    public class UnicastIPAddressInformation : IPAddressInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UnicastIPAddressInformationCollection : Object
    {
        public System.Collections.ObjectModel.Collection`1<System.Net.NetworkInformation.UnicastIPAddressInformation> addresses; // 0x10
        public object field_1; // 0x59C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876CED90
        public void CopyTo(){} // RVA: 0x7FFE876CEE50
        public void get_Count(){} // RVA: 0x7FFE876CEEF0
        public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void Add(){} // RVA: 0x7FFE876CEF70
        public void InternalAdd(){} // RVA: 0x7FFE876CEFD0
        public void Contains(){} // RVA: 0x7FFE876CF030
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8713AA70
        public void GetEnumerator(){} // RVA: 0x7FFE876CF0C0
        public void Remove(){} // RVA: 0x7FFE876CF140
        public void Clear(){} // RVA: 0x7FFE876CF1A0
    }

    public class UnixIPGlobalPropertiesFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE813240E0
    }

    public class UnixNetworkInterfaceFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE813240E0
    }

    public class Win32IPGlobalProperties : IPGlobalProperties
    {
        // ── Methods ──
        public void get_DomainName(){} // RVA: 0x7FFE876D2920
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Win32IPGlobalPropertiesFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE876D2940
    }

    public class Win32IPInterfaceProperties2 : IPInterfaceProperties
    {
        public System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES addr; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876D2980
        public void get_UnicastAddresses(){} // RVA: 0x7FFE876D2BB0
        public void Win32FromUnicast(){} // RVA: 0x7FFE876D2BF0
    }

    public class Win32IPv4InterfaceStatistics : IPv4InterfaceStatistics
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876D2E50
    }

    public class Win32LengthFlagsUnion : ValueType
    {
    }

    public class Win32NetworkInterface : Object
    {
        public System.Net.NetworkInformation.Win32_FIXED_INFO fixedInfo;

        // ── Methods ──
        public void GetNetworkParams(){} // RVA: 0x7FFE876D4450
        public void MultiByteToWideChar(){} // RVA: 0x7FFE876D44F0
        public void get_FixedInfo(){} // RVA: 0x7FFE876D45C0
        public void <get_FixedInfo>g__GetStringFromMultiByte|5_0(){} // RVA: 0x7FFE876D4C30
    }

    public class Win32NetworkInterface2 : NetworkInterface
    {
        public System.Net.NetworkInformation.Win32_IP_ADAPTER_ADDRESSES addr; // 0x10
        public System.Net.NetworkInformation.Win32_MIB_IFROW mib4; // 0x118
        public System.Net.NetworkInformation.Win32_MIB_IFROW mib6; // 0x188

        // ── Methods ──
        public void GetIfEntry(){} // RVA: 0x7FFE876D3990
        public void .ctor(){} // RVA: 0x7FFE876D3B10
        public void GetIPProperties(){} // RVA: 0x7FFE81B14500
        public void GetPhysicalAddress(){} // RVA: 0x7FFE876D4290
        public void get_Id(){} // RVA: 0x7FFE811290C0
        public void get_NetworkInterfaceType(){} // RVA: 0x7FFE826A9B90
        public void get_OperationalStatus(){} // RVA: 0x7FFE8286C0A0
    }

    public class Win32NetworkInterfaceAPI : NetworkInterfaceFactory
    {
        // ── Methods ──
        public void GetAdaptersAddresses(){} // RVA: 0x7FFE876D2FA0 | overloaded x2
        public void GetAllNetworkInterfaces(){} // RVA: 0x7FFE876D3710
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Win32NetworkInterfaceFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE876D4390
    }

    public class Win32UnicastIPAddressInformation : UnicastIPAddressInformation
    {
        public System.Net.NetworkInformation.Win32_IP_ADAPTER_UNICAST_ADDRESS info; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876D4F90
        public void get_Address(){} // RVA: 0x7FFE876D51B0
        public void PrefixLengthToSubnetMask(){} // RVA: 0x7FFE876D51C0
    }

    public class Win32_FIXED_INFO : ValueType
    {
    }

    public class Win32_FIXED_INFO_Marshal : ValueType
    {
    }

    public class Win32_IP_ADAPTER_ADDRESSES : ValueType
    {
    }

    public class Win32_IP_ADAPTER_UNICAST_ADDRESS : ValueType
    {
    }

    public class Win32_IP_ADDR_STRING : ValueType
    {
    }

    public class Win32_MIB_IFROW : ValueType
    {
    }

    public class Win32_SOCKADDR : ValueType
    {
    }

    public class Win32_SOCKET_ADDRESS : ValueType
    {
        // ── Methods ──
        public void GetIPAddress(){} // RVA: 0x7FFE876D4D30
    }

}