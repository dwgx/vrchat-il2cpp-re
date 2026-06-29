// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net.NetworkInformation
// Classes: 33
// Methods: 126

namespace ThirdParty.DotNet.System.Net.NetworkInformation
{
    public class INetworkChange
    {
        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x7A7E18800
        public void remove_NetworkAddressChanged(){} // RVA: 0x7A7E18800
        public void get_HasRegisteredEvents(){} // RVA: 0x7A7E01900
    }

    public class IPAddressInformation : Object
    {
        // ── Methods ──
        public void get_Address(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class IPGlobalProperties : Object
    {
        // ── Methods ──
        public void GetIPGlobalProperties(){} // RVA: 0x7AE97E4F0
        public void InternalGetIPGlobalProperties(){} // RVA: 0x7AE97E4F0
        public void get_DomainName(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class IPGlobalPropertiesFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AE97E4F0
    }

    public class IPInterfaceProperties : Object
    {
        // ── Methods ──
        public void get_UnicastAddresses(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class IPv4InterfaceStatistics : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LinuxNetworkChange : Object
    {
        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x7AE980DD0
        public void remove_NetworkAddressChanged(){} // RVA: 0x7AE980EC0
        public void get_HasRegisteredEvents(){} // RVA: 0x7AE980ED0
        public void Dispose(){} // RVA: 0x7A80D7310
        public void EnsureSocket(){} // RVA: 0x7AE980EF0
        public void MaybeCloseSocket(){} // RVA: 0x7AE981070
        public void GetAvailability(){} // RVA: 0x7AE9810E0
        public void OnAvailabilityChanged(){} // RVA: 0x7AE9811C0
        public void OnAddressChanged(){} // RVA: 0x7AE981350
        public void OnEventDue(){} // RVA: 0x7AE9813D0
        public void QueueEvent(){} // RVA: 0x7AE981660
        public void OnDataAvailable(){} // RVA: 0x7AE981930
        public void Register(){} // RVA: 0x7AE980DD0
        public void Unregister(){} // RVA: 0x7AE981A10
        public void CreateNLSocket(){} // RVA: 0x7AE981C50
        public void ReadEvents(){} // RVA: 0x7AE981C60
        public void CloseNLSocket(){} // RVA: 0x7AE981C70
        public void .ctor(){} // RVA: 0x7AE981C80
    }

    public class MacNetworkChange : Object
    {
        // ── Methods ──
        public void dlopen(){} // RVA: 0x7AE97F920
        public void dlsym(){} // RVA: 0x7AE97F9D0
        public void dlclose(){} // RVA: 0x7AE97FA90
        public void CFRelease(){} // RVA: 0x7AE97FB10
        public void CFRunLoopGetMain(){} // RVA: 0x7AE97FB90
        public void SCNetworkReachabilityCreateWithAddress(){} // RVA: 0x7AE97FC00
        public void SCNetworkReachabilityGetFlags(){} // RVA: 0x7AE97FC90
        public void SCNetworkReachabilitySetCallback(){} // RVA: 0x7AE97FD20
        public void SCNetworkReachabilityScheduleWithRunLoop(){} // RVA: 0x7AE97FDD0
        public void SCNetworkReachabilityUnscheduleFromRunLoop(){} // RVA: 0x7AE97FE70
        public void add_networkAddressChanged(){} // RVA: 0x7AE97FF10
        public void remove_networkAddressChanged(){} // RVA: 0x7AE980000
        public void add_NetworkAddressChanged(){} // RVA: 0x7AE9800F0
        public void remove_NetworkAddressChanged(){} // RVA: 0x7AE980000
        public void get_IsAvailable(){} // RVA: 0x7AE980250
        public void get_HasRegisteredEvents(){} // RVA: 0x7AE980270
        public void .ctor(){} // RVA: 0x7AE980290
        public void LoadRunLoopMode(){} // RVA: 0x7AE9806D0
        public void Dispose(){} // RVA: 0x7AE980980
        public void HandleCallback(){} // RVA: 0x7AE980C10
    }

    public class NetworkAddressChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB0FF420
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class NetworkAvailabilityChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
    }

    public class NetworkAvailabilityEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE97E570
    }

    public class NetworkChange : Object
    {
        // ── Methods ──
        public void add_NetworkAddressChanged(){} // RVA: 0x7AE97F150
        public void remove_NetworkAddressChanged(){} // RVA: 0x7AE97F350
        public void MaybeCreate(){} // RVA: 0x7AE97F660
        public void get_IsWindows(){} // RVA: 0x7ADC565D0
        public void MaybeDispose(){} // RVA: 0x7AE97F810
    }

    public class NetworkInformationException : Win32Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE90D430
        public void get_ErrorCode(){} // RVA: 0x7A846C760
    }

    public class NetworkInterface : Object
    {
        // ── Methods ──
        public void GetAllNetworkInterfaces(){} // RVA: 0x7AE97E690
        public void get_Id(){} // RVA: 0x7AE97E6E0
        public void GetIPProperties(){} // RVA: 0x7AE97E720
        public void get_OperationalStatus(){} // RVA: 0x7AE97E760
        public void GetPhysicalAddress(){} // RVA: 0x7AE97E7A0
        public void get_NetworkInterfaceType(){} // RVA: 0x7AE97E7E0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class NetworkInterfaceFactory : Object
    {
        // ── Methods ──
        public void GetAllNetworkInterfaces(){} // RVA: 0x7A7E00680
        public void Create(){} // RVA: 0x7AE981F30
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class NetworkInterfaceFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AE981F30
    }

    public class PhysicalAddress : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADB36A70
        public void GetHashCode(){} // RVA: 0x7AE97E820
        public void Equals(){} // RVA: 0x7AE97E950
        public void ToString(){} // RVA: 0x7AE97EA50
        public void .cctor(){} // RVA: 0x7AE97EBB0
    }

    public class Ping : Component
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE982030
        public void .ctor(){} // RVA: 0x7AE982420
        public void capget(){} // RVA: 0x7AE982560
        public void CheckLinuxCapabilities(){} // RVA: 0x7AE9825F0
        public void System.IDisposable.Dispose(){} // RVA: 0x7A80D7310
    }

    public class SystemNetworkInterface : Object
    {
        // ── Methods ──
        public void GetNetworkInterfaces(){} // RVA: 0x7AE981D10
        public void .cctor(){} // RVA: 0x7AE981DA0
    }

    public class UnicastIPAddressInformation : IPAddressInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class UnicastIPAddressInformationCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE97ECE0
        public void CopyTo(){} // RVA: 0x7AE97EDA0
        public void get_Count(){} // RVA: 0x7AE97EE40
        public void get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void Add(){} // RVA: 0x7AE97EEC0
        public void InternalAdd(){} // RVA: 0x7AE97EF20
        public void Contains(){} // RVA: 0x7AE97EF80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A95E9DD0
        public void GetEnumerator(){} // RVA: 0x7AE97F010
        public void Remove(){} // RVA: 0x7AE97F090
        public void Clear(){} // RVA: 0x7AE97F0F0
    }

    public class UnixIPGlobalPropertiesFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7A82D1450
    }

    public class UnixNetworkInterfaceFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7A82D1450
    }

    public class Win32IPGlobalProperties : IPGlobalProperties
    {
        // ── Methods ──
        public void get_DomainName(){} // RVA: 0x7AE982740
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Win32IPGlobalPropertiesFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AE982760
    }

    public class Win32IPInterfaceProperties2 : IPInterfaceProperties
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9827A0
        public void get_UnicastAddresses(){} // RVA: 0x7AE9829D0
        public void Win32FromUnicast(){} // RVA: 0x7AE982A10
    }

    public class Win32IPv4InterfaceStatistics : IPv4InterfaceStatistics
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE982C70
    }

    public class Win32NetworkInterface : Object
    {
        // ── Methods ──
        public void GetNetworkParams(){} // RVA: 0x7AE984290
        public void MultiByteToWideChar(){} // RVA: 0x7AE984330
        public void get_FixedInfo(){} // RVA: 0x7AE984400
        public void <get_FixedInfo>g__GetStringFromMultiByte|5_0(){} // RVA: 0x7AE984A90
    }

    public class Win32NetworkInterface2 : NetworkInterface
    {
        // ── Methods ──
        public void GetIfEntry(){} // RVA: 0x7AE9837D0
        public void .ctor(){} // RVA: 0x7AE983950
        public void GetIPProperties(){} // RVA: 0x7A8B62DA0
        public void GetPhysicalAddress(){} // RVA: 0x7AE9840D0
        public void get_Id(){} // RVA: 0x7A81052C0
        public void get_NetworkInterfaceType(){} // RVA: 0x7A96E4F70
        public void get_OperationalStatus(){} // RVA: 0x7A989D5C0
    }

    public class Win32NetworkInterfaceAPI : NetworkInterfaceFactory
    {
        // ── Methods ──
        public void GetAdaptersAddresses(){} // RVA: 0x7AE982DC0
        public void GetAllNetworkInterfaces(){} // RVA: 0x7AE983530
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Win32NetworkInterfaceFactoryPal : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AE9841D0
    }

    public class Win32UnicastIPAddressInformation : UnicastIPAddressInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE984E00
        public void get_Address(){} // RVA: 0x7AE985020
        public void PrefixLengthToSubnetMask(){} // RVA: 0x7AE985030
    }

    public class Win32_SOCKET_ADDRESS : ValueType
    {
        // ── Methods ──
        public void GetIPAddress(){} // RVA: 0x7A7E9B4B0
    }

}