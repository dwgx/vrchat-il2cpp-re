// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngineInternal.Input
// Classes: 2
// Methods: 17

namespace ThirdParty.Unity.UnityEngineInternal.Input
{
    public class NativeInputSystem : Object
    {
        public UnityEngineInternal.Input.NativeUpdateCallback onDeviceDiscovered;
        public System.Action`1<ÏÎÌÌÍÏ> hasDeviceDiscoveredCallback; // 0x8
        public System.Func`2<ÏÎÌÌÍÏ,bool> currentTime; // 0x10
        public System.Action`2<int,string> currentTimeOffsetToRealtimeSinceStartup; // 0x18

        // ── Methods ──
        public void get_onDeviceDiscovered(){} // RVA: 0x7FFD54D62C70
        public void set_onDeviceDiscovered(){} // RVA: 0x7FFD54D62CD0
        public void .cctor(){} // RVA: 0x7FFD54D62DE0
        public void NotifyBeforeUpdate(){} // RVA: 0x7FFD54D62E30
        public void NotifyUpdate(){} // RVA: 0x7FFD54D62EB0
        public void NotifyDeviceDiscovered(){} // RVA: 0x7FFD54D62F50
        public void ShouldRunUpdate(){} // RVA: 0x7FFD54D62FD0
        public void set_hasDeviceDiscoveredCallback(){} // RVA: 0x7FFD54D63060
        public void get_currentTime(){} // RVA: 0x7FFD54D630B0
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7FFD54D63100
        public void AllocateDeviceId(){} // RVA: 0x7FFD54D63150
        public void QueueInputEvent(){} // RVA: 0x7FFD54D631A0
        public void IOCTL(){} // RVA: 0x7FFD54D631F0
        public void SetPollingFrequency(){} // RVA: 0x7FFD54D63270
        public void Update(){} // RVA: 0x7FFD54D632D0
    }

    public class NativeUpdateCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E49D2A0
        public void Invoke(){} // RVA: 0x7FFD4E49D370
    }

}