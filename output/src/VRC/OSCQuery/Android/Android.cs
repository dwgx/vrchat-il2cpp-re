// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.OSCQuery.Android
// Classes: 2
// Methods: 26

namespace VRC.OSCQuery.Android
{
    public class AndroidDiscovery : Object
    {
        public float MulticastLockStatus; // 0x10
        public bool stopAcquiringLock; // 0x14
        public bool _multicastLockStatus; // 0x15
        public object multicastLock; // 0x18
        public object discoveryJava; // 0x20
        public object activityContext; // 0x28
        public ÍÎÏÌÎÍÍÌÎÎÎÌÏÍÎÌÌÏÍÌÌ.? javaBridge; // 0x30
        public bool advertisingReady; // 0x38
        public ileFullDirectoryInformation<bool> MulticastLockStatusChanged; // 0x40
        public URA.ge<string> errors; // 0x48
        public URA.onsDepth<string> _requiredPermissions; // 0x50
        public string multicastPermission; // 0x58
        public URA.onsDepth<gate.4> _oscQueryServices; // 0x60
        public URA.onsDepth<gate.4> _oscServices; // 0x68
        public URA.ge<gate.4> _profilesToAdvertise; // 0x70
        public ileFullDirectoryInformation<gate.4> OnOscServiceAdded; // 0x78
        public ileFullDirectoryInformation<gate.4> OnOscQueryServiceAdded; // 0x80

        // ── Methods ──
        public void getMulticastLock(){} // RVA: 0x7FFD4E554A40
        public void get_MulticastLockStatus(){} // RVA: 0x7FFD4E555090
        public void set_MulticastLockStatus(){} // RVA: 0x7FFD4E5550A0
        public void add_MulticastLockStatusChanged(){} // RVA: 0x7FFD4E5550F0
        public void remove_MulticastLockStatusChanged(){} // RVA: 0x7FFD4E5551F0
        public void OnMulticastLockStatusChanged(){} // RVA: 0x7FFD4E5552F0
        public void acquireMultiCastPeriodically(){} // RVA: 0x7FFD4E5554D0
        public void ProcessErrors(){} // RVA: 0x7FFD4E555620
        public void .ctor(){} // RVA: 0x7FFD4E5556C0
        public void StartService(){} // RVA: 0x7FFD4E556240
        public void OnServiceProfileFoundFromJava(){} // RVA: 0x7FFD4E556770
        public void OnDestroy(){} // RVA: 0x7FFD4E556AC0
        public void GetOSCQueryServices(){} // RVA: 0x7FFD4E3DF370
        public void GetOSCServices(){} // RVA: 0x7FFD4E3BCD50
        public void Dispose(){} // RVA: 0x7FFD4E556AD0
        public void RefreshServices(){} // RVA: 0x7FFD4E341310
        public void Advertise(){} // RVA: 0x7FFD4E556CB0
        public void Unadvertise(){} // RVA: 0x7FFD4E341310
        public void add_OnOscServiceAdded(){} // RVA: 0x7FFD4E556E80
        public void remove_OnOscServiceAdded(){} // RVA: 0x7FFD4E556F80
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7FFD4E557080
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7FFD4E557180
        public void <ProcessErrors>b__18_0(){} // RVA: 0x7FFD4E557280
    }

    public class JavaBridge : AndroidJavaProxy
    {
        public ileFullDirectoryInformation<gate.4> OnServiceProfileFound; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E557A50
        public void OnJavaServiceInfo(){} // RVA: 0x7FFD4E557AC0
        public void GetServiceTypeFromJavaString(){} // RVA: 0x7FFD4E557E20
    }

}