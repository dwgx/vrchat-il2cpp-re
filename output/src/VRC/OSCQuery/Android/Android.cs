// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.OSCQuery.Android
// Classes: 2
// Methods: 26

namespace VRC.OSCQuery.Android
{
    public class AndroidDiscovery : Object
    {
        public object multicastDelay;
        public object stopAcquiringLock;
        public object _multicastLockStatus;
        public object multicastLock;
        public object discoveryJava;
        public object activityContext;
        public object javaBridge;
        public object advertisingReady;
        public object MulticastLockStatusChanged;
        public object errors;
        public object _requiredPermissions;
        public object multicastPermission;
        public object _oscQueryServices;
        public object _oscServices;
        public object _profilesToAdvertise;
        public object OnOscServiceAdded;
        public object OnOscQueryServiceAdded;

        // ── Methods ──
        public void getMulticastLock(){} // RVA: 0xE2EFA0
        public void get_MulticastLockStatus(){} // RVA: 0xE2F5E0
        public void set_MulticastLockStatus(){} // RVA: 0xE2F5F0
        public void add_MulticastLockStatusChanged(){} // RVA: 0xE2F640
        public void remove_MulticastLockStatusChanged(){} // RVA: 0xE2F750
        public void OnMulticastLockStatusChanged(){} // RVA: 0xE2F860
        public void acquireMultiCastPeriodically(){} // RVA: 0xE2FA40
        public void ProcessErrors(){} // RVA: 0xE2FB90
        public void .ctor(){} // RVA: 0xE2FC30
        public void StartService(){} // RVA: 0xE307B0
        public void OnServiceProfileFoundFromJava(){} // RVA: 0xE30CE0
        public void OnDestroy(){} // RVA: 0xE31040
        public void GetOSCQueryServices(){} // RVA: 0xBE2C60
        public void GetOSCServices(){} // RVA: 0xBBFF90
        public void Dispose(){} // RVA: 0xE31050
        public void RefreshServices(){} // RVA: 0xB43310
        public void Advertise(){} // RVA: 0xE31230
        public void Unadvertise(){} // RVA: 0xB43310
        public void add_OnOscServiceAdded(){} // RVA: 0xE313F0
        public void remove_OnOscServiceAdded(){} // RVA: 0xE31500
        public void add_OnOscQueryServiceAdded(){} // RVA: 0xE31610
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0xE31730
        public void <ProcessErrors>b__18_0(){} // RVA: 0xE31850
    }

    public class JavaBridge : AndroidJavaProxy
    {
        public object OnServiceProfileFound;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xE32050
        public void OnJavaServiceInfo(){} // RVA: 0xE320C0
        public void GetServiceTypeFromJavaString(){} // RVA: 0xE32420
    }

}