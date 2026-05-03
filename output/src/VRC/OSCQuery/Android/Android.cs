// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.OSCQuery.Android
// Classes: 2
// Methods: 26

namespace VRC.OSCQuery.Android
{
    public class AndroidDiscovery : Object
    {
        public float multicastDelay; // 0x10

        // ── Methods ──
        public void getMulticastLock(){} // RVA: 0x7FFE8139A5F0
        public void get_MulticastLockStatus(){} // RVA: 0x7FFE8139AC40
        public void set_MulticastLockStatus(){} // RVA: 0x7FFE8139AC50
        public void add_MulticastLockStatusChanged(){} // RVA: 0x7FFE8139ACA0
        public void remove_MulticastLockStatusChanged(){} // RVA: 0x7FFE8139ADA0
        public void OnMulticastLockStatusChanged(){} // RVA: 0x7FFE8139AEA0
        public void acquireMultiCastPeriodically(){} // RVA: 0x7FFE8139B080
        public void ProcessErrors(){} // RVA: 0x7FFE8139B1D0
        public void .ctor(){} // RVA: 0x7FFE8139B270
        public void StartService(){} // RVA: 0x7FFE8139BDF0
        public void OnServiceProfileFoundFromJava(){} // RVA: 0x7FFE8139C320
        public void OnDestroy(){} // RVA: 0x7FFE8139C670
        public void GetOSCQueryServices(){} // RVA: 0x7FFE81199370
        public void GetOSCServices(){} // RVA: 0x7FFE81176D50
        public void Dispose(){} // RVA: 0x7FFE8139C680
        public void RefreshServices(){} // RVA: 0x7FFE810FB310
        public void Advertise(){} // RVA: 0x7FFE8139C860
        public void Unadvertise(){} // RVA: 0x7FFE810FB310
        public void add_OnOscServiceAdded(){} // RVA: 0x7FFE8139CA30
        public void remove_OnOscServiceAdded(){} // RVA: 0x7FFE8139CB30
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7FFE8139CC30
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7FFE8139CD30
        public void <ProcessErrors>b__18_0(){} // RVA: 0x7FFE8139CE30
    }

    public class JavaBridge : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8139D600
        public void OnJavaServiceInfo(){} // RVA: 0x7FFE8139D670
        public void GetServiceTypeFromJavaString(){} // RVA: 0x7FFE8139D9D0
    }

}