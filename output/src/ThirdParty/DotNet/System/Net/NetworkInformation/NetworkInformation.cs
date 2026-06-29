// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.NetworkInformation
// Classes: 36
// Methods: 171

namespace ThirdParty.DotNet.System.Net.NetworkInformation
{
    public class INetworkChange
    {
        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x894320
        public void remove_NetworkAddressChanged(){} // RVA: 0x894320
        public void get_HasRegisteredEvents(){} // RVA: 0x87D280
    }

    public class IPAddressInformation : Object
    {
        // ── Methods ──
        public void get_Address(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class IPGlobalProperties : Object
    {
        // ── Methods ──
        public void GetIPGlobalProperties(){} // RVA: 0x75F1210
        public void InternalGetIPGlobalProperties(){} // RVA: 0x75F1210
        public void get_DomainName(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class IPGlobalPropertiesFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x75F1210
    }

    public class IPInterfaceProperties : Object
    {
        // ── Methods ──
        public void get_UnicastAddresses(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class IPv4InterfaceStatistics : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LinuxNetworkChange : Object
    {
        public object _lock;
        public object nl_sock;
        public object nl_args;
        public object pending_events;
        public object timer;
        public object AddressChanged;
        public object AvailabilityChanged;

        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x75F3AA0
        public void remove_NetworkAddressChanged(){} // RVA: 0x75F3B90
        public void get_HasRegisteredEvents(){} // RVA: 0x75F3BA0
        public void Dispose(){} // RVA: 0xB43310
        public void EnsureSocket(){} // RVA: 0x75F3BC0
        public void MaybeCloseSocket(){} // RVA: 0x75F3D40
        public void GetAvailability(){} // RVA: 0x75F3DB0
        public void OnAvailabilityChanged(){} // RVA: 0x75F3E90
        public void OnAddressChanged(){} // RVA: 0x75F4020
        public void OnEventDue(){} // RVA: 0x75F40A0
        public void QueueEvent(){} // RVA: 0x75F4330
        public void OnDataAvailable(){} // RVA: 0x75F4600
        public void Register(){} // RVA: 0x75F3AA0
        public void Unregister(){} // RVA: 0x75F46E0
        public void CreateNLSocket(){} // RVA: 0x75F4920
        public void ReadEvents(){} // RVA: 0x75F4930
        public void CloseNLSocket(){} // RVA: 0x75F4940
        public void .ctor(){} // RVA: 0x75F4950
    }

    public class MacNetworkChange : Object
    {
        public object handle;
        public object runLoopMode;
        public object callback;
        public object scheduledWithRunLoop;
        public object flags;
        public object networkAddressChanged;
        public object networkAvailabilityChanged;

        // ── Methods ──
        public void dlopen(){} // RVA: 0x75F25E0
        public void dlsym(){} // RVA: 0x75F2690
        public void dlclose(){} // RVA: 0x75F2750
        public void CFRelease(){} // RVA: 0x75F27D0
        public void CFRunLoopGetMain(){} // RVA: 0x75F2850
        public void SCNetworkReachabilityCreateWithAddress(){} // RVA: 0x75F28C0
        public void SCNetworkReachabilityGetFlags(){} // RVA: 0x75F2950
        public void SCNetworkReachabilitySetCallback(){} // RVA: 0x75F29E0
        public void SCNetworkReachabilityScheduleWithRunLoop(){} // RVA: 0x75F2A90
        public void SCNetworkReachabilityUnscheduleFromRunLoop(){} // RVA: 0x75F2B30
        public void add_networkAddressChanged(){} // RVA: 0x75F2BD0
        public void remove_networkAddressChanged(){} // RVA: 0x75F2CC0
        public void add_NetworkAddressChanged(){} // RVA: 0x75F2DB0
        public void remove_NetworkAddressChanged(){} // RVA: 0x75F2CC0
        public void get_IsAvailable(){} // RVA: 0x75F2F10
        public void get_HasRegisteredEvents(){} // RVA: 0x75F2F30
        public void .ctor(){} // RVA: 0x75F2F50
        public void LoadRunLoopMode(){} // RVA: 0x75F3390
        public void Dispose(){} // RVA: 0x75F3640
        public void HandleCallback(){} // RVA: 0x75F38D0
    }

    public class NetworkAddressChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DB94B0
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class NetworkAvailabilityChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class NetworkAvailabilityEventArgs : EventArgs
    {
        public object isAvailable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75F1290
    }

    public class NetworkChange : Object
    {
        public object networkChange;

        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x75F1E70
        public void remove_NetworkAddressChanged(){} // RVA: 0x75F2040
        public void MaybeCreate(){} // RVA: 0x75F2320
        public void get_IsWindows(){} // RVA: 0x68E0EC0
        public void MaybeDispose(){} // RVA: 0x75F24D0
    }

    public class NetworkInformationException : Win32Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7580C70
        public void get_ErrorCode(){} // RVA: 0xF3A950
    }

    public class NetworkInterface : Object
    {
        // ── Methods ──
        public void GetAllNetworkInterfaces(){} // RVA: 0x75F13B0
        public void get_Id(){} // RVA: 0x75F1400
        public void GetIPProperties(){} // RVA: 0x75F1440
        public void get_OperationalStatus(){} // RVA: 0x75F1480
        public void GetPhysicalAddress(){} // RVA: 0x75F14C0
        public void get_NetworkInterfaceType(){} // RVA: 0x75F1500
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NetworkInterfaceFactory : Object
    {
        // ── Methods ──
        public void GetAllNetworkInterfaces(){} // RVA: 0x87C0A0
        public void Create(){} // RVA: 0x75F4C00
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NetworkInterfaceFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x75F4C00
    }

    public class NetworkInterface[] : Array
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

    public class PhysicalAddress : Object
    {
        public object address;
        public object changed;
        public object hash;
        public object None;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67C11E0
        public void GetHashCode(){} // RVA: 0x75F1540
        public void Equals(){} // RVA: 0x75F1670
        public void ToString(){} // RVA: 0x75F1770
        public void .cctor(){} // RVA: 0x75F18D0
    }

    public class Ping : Component
    {
        public object PingBinPaths;
        public object PingBinPath;
        public object canSendPrivileged;
        public object identifier;
        public object default_buffer;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x75F4D00
        public void .ctor(){} // RVA: 0x75F50F0
        public void capget(){} // RVA: 0x75F5220
        public void CheckLinuxCapabilities(){} // RVA: 0x75F52B0
        public void System.IDisposable.Dispose(){} // RVA: 0xB43310
    }

    public class SystemNetworkInterface : Object
    {
        public object nif;

        // ── Methods ──
        public void GetNetworkInterfaces(){} // RVA: 0x75F49E0
        public void .cctor(){} // RVA: 0x75F4A70
    }

    public class UnicastIPAddressInformation : IPAddressInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UnicastIPAddressInformationCollection : Object
    {
        public object addresses;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75F1A00
        public void CopyTo(){} // RVA: 0x75F1AC0
        public void get_Count(){} // RVA: 0x75F1B60
        public void get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void Add(){} // RVA: 0x75F1BE0
        public void InternalAdd(){} // RVA: 0x75F1C40
        public void Contains(){} // RVA: 0x75F1CA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x13C3640
        public void GetEnumerator(){} // RVA: 0x75F1D30
        public void Remove(){} // RVA: 0x75F1DB0
        public void Clear(){} // RVA: 0x75F1E10
    }

    public class UnicastIPAddressInformation[] : Array
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

    public class UnixIPGlobalPropertiesFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0xDAC980
    }

    public class UnixNetworkInterfaceFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0xDAC980
    }

    public class Win32IPGlobalProperties : IPGlobalProperties
    {
        // ── Methods ──
        public void get_DomainName(){} // RVA: 0x75F5400
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Win32IPGlobalPropertiesFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x75F5420
    }

    public class Win32IPInterfaceProperties2 : IPInterfaceProperties
    {
        public object addr;
        public object mib4;
        public object mib6;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75F5460
        public void get_UnicastAddresses(){} // RVA: 0x75F5690
        public void Win32FromUnicast(){} // RVA: 0x75F56D0
    }

    public class Win32IPv4InterfaceStatistics : IPv4InterfaceStatistics
    {
        public object info;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75F5900
    }

    public class Win32NetworkInterface : Object
    {
        public object fixedInfo;
        public object initialized;

        // ── Methods ──
        public void GetNetworkParams(){} // RVA: 0x75F6EB0
        public void MultiByteToWideChar(){} // RVA: 0x75F6F50
        public void get_FixedInfo(){} // RVA: 0x75F7020
        public void <get_FixedInfo>g__GetStringFromMultiByte|5_0(){} // RVA: 0x75F7680
    }

    public class Win32NetworkInterface2 : NetworkInterface
    {
        public object addr;
        public object mib4;
        public object mib6;
        public object ip4stats;
        public object ip_if_props;

        // ── Methods ──
        public void GetIfEntry(){} // RVA: 0x75F63F0
        public void .ctor(){} // RVA: 0x75F6570
        public void GetIPProperties(){} // RVA: 0x165F4F0
        public void GetPhysicalAddress(){} // RVA: 0x75F6CF0
        public void get_Id(){} // RVA: 0xB700F0
        public void get_NetworkInterfaceType(){} // RVA: 0x21EA4F0
        public void get_OperationalStatus(){} // RVA: 0x23ADD10
    }

    public class Win32NetworkInterfaceAPI : NetworkInterfaceFactory
    {
        // ── Methods ──
        public void GetAdaptersAddresses(){} // RVA: 0x75F5A50
        public void GetAllNetworkInterfaces(){} // RVA: 0x75F6150
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Win32NetworkInterfaceFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x75F6DF0
    }

    public class Win32UnicastIPAddressInformation : UnicastIPAddressInformation
    {
        public object info;
        public object ipv4Mask;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75F79A0
        public void get_Address(){} // RVA: 0x75F7BC0
        public void PrefixLengthToSubnetMask(){} // RVA: 0x75F7BD0
    }

    public class Win32_IP_ADAPTER_ADDRESSES[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EBEE70
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7CE80
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC9440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E76880
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7CE80
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Win32_SOCKET_ADDRESS : ValueType
    {
        public object Sockaddr;
        public object SockaddrLength;

        // ── Methods ──
        public void GetIPAddress(){} // RVA: 0x91B630
    }

}