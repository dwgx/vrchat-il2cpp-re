// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.OSCQuery.Android
// Classes: 2
// Methods: 26

namespace VRC.OSCQuery.Android
{
    public class AndroidDiscovery : Object
    {
        public object _multicastLockStatus; // 0x33C45540
        public object activityContext; // 0x33C45540
        public object MulticastLockStatusChanged; // 0x33C45540
        public object multicastPermission; // 0x33C45540
        public object _profilesToAdvertise; // 0x33C45540

        // ── Original Methods ──
        public void getMulticastLock(){} // RVA: 0x7ffaa8b5fd60
        public void get_MulticastLockStatus(){} // RVA: 0x7ffaa8b603b0
        public void set_MulticastLockStatus(){} // RVA: 0x7ffaa8b603c0
        public void add_MulticastLockStatusChanged(){} // RVA: 0x7ffaa8b60410
        public void remove_MulticastLockStatusChanged(){} // RVA: 0x7ffaa8b60510
        public void OnMulticastLockStatusChanged(){} // RVA: 0x7ffaa8b60610
        public void acquireMultiCastPeriodically(){} // RVA: 0x7ffaa8b607f0
        public void ProcessErrors(){} // RVA: 0x7ffaa8b60940
        public void .ctor(){} // RVA: 0x7ffaa8b609e0
        public void StartService(){} // RVA: 0x7ffaa8b61560
        public void OnServiceProfileFoundFromJava(){} // RVA: 0x7ffaa8b61a90
        public void OnDestroy(){} // RVA: 0x7ffaa8b61de0
        public void Dispose(){} // RVA: 0x7ffaa8b61df0
        public void RefreshServices(){} // RVA: 0x7ffaa8932310
        public void Advertise(){} // RVA: 0x7ffaa8b61fd0
        public void Unadvertise(){} // RVA: 0x7ffaa8932310
        public void add_OnOscServiceAdded(){} // RVA: 0x7ffaa8b621a0
        public void remove_OnOscServiceAdded(){} // RVA: 0x7ffaa8b622a0
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7ffaa8b623a0
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7ffaa8b624a0
        public void <ProcessErrors>b__18_0(){} // RVA: 0x7ffaa8b625a0
        // ── Binary Analysis Named ──
        public void GetOSCQueryServices(){} // RVA: 0x7ffaa89d0370
        public void GetOSCServices(){} // RVA: 0x7ffaa89add50
    }

    public class JavaBridge : AndroidJavaProxy
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8b62d70
        public void OnJavaServiceInfo(){} // RVA: 0x7ffaa8b62de0
        // ── Binary Analysis Named ──
        public void GetServiceTypeFromJavaString(){} // RVA: 0x7ffaa8b63140
    }

}