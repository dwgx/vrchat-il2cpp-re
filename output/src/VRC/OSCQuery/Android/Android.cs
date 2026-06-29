// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.OSCQuery.Android
// Classes: 2
// Methods: 27

namespace VRC.OSCQuery.Android
{
    public class AndroidDiscovery : Object
    {
        // ── Methods ──
        public void getMulticastLock(){} // RVA: 0x7A8351FA0
        public void get_MulticastLockStatus(){} // RVA: 0x7A83525F0
        public void set_MulticastLockStatus(){} // RVA: 0x7A8352600
        public void add_MulticastLockStatusChanged(){} // RVA: 0x7A8352650
        public void remove_MulticastLockStatusChanged(){} // RVA: 0x7A8352760
        public void OnMulticastLockStatusChanged(){} // RVA: 0x7A8352870
        public void acquireMultiCastPeriodically(){} // RVA: 0x7A8352A50
        public void ProcessErrors(){} // RVA: 0x7A8352BA0
        public void .ctor(){} // RVA: 0x7A8352C40
        public void StartService(){} // RVA: 0x7A83537C0
        public void OnServiceProfileFoundFromJava(){} // RVA: 0x7A8353CF0
        public void OnDestroy(){} // RVA: 0x7A8354050
        public void GetOSCQueryServices(){} // RVA: 0x7A8175DF0
        public void GetOSCServices(){} // RVA: 0x7A8153390
        public void Dispose(){} // RVA: 0x7A8354060
        public void RefreshServices(){} // RVA: 0x7A80D7310
        public void Advertise(){} // RVA: 0x7A8354240
        public void Unadvertise(){} // RVA: 0x7A80D7310
        public void add_OnOscServiceAdded(){} // RVA: 0x7A8354410
        public void remove_OnOscServiceAdded(){} // RVA: 0x7A8354520
        public void add_OnOscQueryServiceAdded(){} // RVA: 0x7A8354630
        public void remove_OnOscQueryServiceAdded(){} // RVA: 0x7A8354750
        public void <ProcessErrors>b__18_0(){} // RVA: 0x7A8354870
    }

    public class JavaBridge : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8355060
        public void OnJavaServiceInfo(){} // RVA: 0x7A83550D0
        public void GetServiceTypeFromJavaString(){} // RVA: 0x7A8355430
        public void OnServiceProfileFound(){} // RVA: 0x7B41AC7D8
    }

}