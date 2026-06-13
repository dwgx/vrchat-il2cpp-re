// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngineInternal.Input
// Classes: 4
// Methods: 17

namespace ThirdParty.Unity.UnityEngineInternal.Input
{
    public class NativeInputEvent
    {
    }

    public class NativeInputEventBuffer
    {
    }

    public class NativeInputSystem
    {
        public UnityEngineInternal.Input.NativeUpdateCallback onUpdate;
        public System.Action`1<0x65A04AF0> onBeforeUpdate; // 0x8
        public System.Func`2<0x65A04AF0,bool> onShouldRunUpdate; // 0x10
        public System.Action`2<int,string> s_OnDeviceDiscoveredCallback; // 0x18

        // ── Methods ──
        public void get_onDeviceDiscovered(){} // RVA: 0x71AB370
        public void set_onDeviceDiscovered(){} // RVA: 0x71AB3D0
        public void .cctor(){} // RVA: 0x71AB4E0
        public void NotifyBeforeUpdate(){} // RVA: 0x71AB530
        public void NotifyUpdate(){} // RVA: 0x71AB5B0
        public void NotifyDeviceDiscovered(){} // RVA: 0x71AB650
        public void ShouldRunUpdate(){} // RVA: 0x71AB6D0
        public void set_hasDeviceDiscoveredCallback(){} // RVA: 0x71AB760
        public void get_currentTime(){} // RVA: 0x71AB7B0
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x71AB800
        public void AllocateDeviceId(){} // RVA: 0x71AB850
        public void QueueInputEvent(){} // RVA: 0x71AB8A0
        public void IOCTL(){} // RVA: 0x71AB8F0
        public void SetPollingFrequency(){} // RVA: 0x71AB970
        public void Update(){} // RVA: 0x71AB9D0
    }

    public class NativeUpdateCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4392A0
        public void Invoke(){} // RVA: 0x439370
    }

}