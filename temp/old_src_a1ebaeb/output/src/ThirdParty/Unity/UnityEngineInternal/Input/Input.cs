// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngineInternal.Input
// Classes: 2
// Methods: 17

namespace ThirdParty.Unity.UnityEngineInternal.Input
{
    public class NativeInputSystem : Object
    {
        public object onShouldRunUpdate; // 0x32E70FB0

        // ── Original Methods ──
        public void get_onDeviceDiscovered(){} // RVA: 0x7ffaaf364bd0
        public void set_onDeviceDiscovered(){} // RVA: 0x7ffaaf364c30
        public void .cctor(){} // RVA: 0x7ffaaf364d40
        public void NotifyBeforeUpdate(){} // RVA: 0x7ffaaf364d90
        public void NotifyUpdate(){} // RVA: 0x7ffaaf364e10
        public void NotifyDeviceDiscovered(){} // RVA: 0x7ffaaf364eb0
        public void ShouldRunUpdate(){} // RVA: 0x7ffaaf364f30
        public void set_hasDeviceDiscoveredCallback(){} // RVA: 0x7ffaaf364fc0
        public void get_currentTime(){} // RVA: 0x7ffaaf365010
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7ffaaf365060
        public void AllocateDeviceId(){} // RVA: 0x7ffaaf3650b0
        public void QueueInputEvent(){} // RVA: 0x7ffaaf365100
        public void IOCTL(){} // RVA: 0x7ffaaf365150
        public void Update(){} // RVA: 0x7ffaaf365230
        // ── Binary Analysis Named ──
        public void SetPollingFrequency(){} // RVA: 0x7ffaaf3651d0
    }

    public class NativeUpdateCallback : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8a8e2a0
        public void Invoke(){} // RVA: 0x7ffaa8a8e370
    }

}