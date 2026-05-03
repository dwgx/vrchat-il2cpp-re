// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngineInternal.Input
// Classes: 4
// Methods: 17

namespace ThirdParty.Unity.UnityEngineInternal.Input
{
    public class NativeInputEvent : ValueType
    {
    }

    public class NativeInputEventBuffer : ValueType
    {
    }

    public class NativeInputSystem : Object
    {
        public UnityEngineInternal.Input.NativeUpdateCallback onUpdate;
        public System.Action`1<0x666DC1BC> onBeforeUpdate; // 0x8
        public System.Func`2<0x666DC1BC,bool> onShouldRunUpdate; // 0x10
        public System.Action`2<int,string> s_OnDeviceDiscoveredCallback; // 0x18

        // ── Methods ──
        public void get_onDeviceDiscovered(){} // RVA: 0x7FFE87CEB510
        public void set_onDeviceDiscovered(){} // RVA: 0x7FFE87CEB570
        public void .cctor(){} // RVA: 0x7FFE87CEB680
        public void NotifyBeforeUpdate(){} // RVA: 0x7FFE87CEB6D0
        public void NotifyUpdate(){} // RVA: 0x7FFE87CEB750
        public void NotifyDeviceDiscovered(){} // RVA: 0x7FFE87CEB7F0
        public void ShouldRunUpdate(){} // RVA: 0x7FFE87CEB870
        public void set_hasDeviceDiscoveredCallback(){} // RVA: 0x7FFE87CEB900
        public void get_currentTime(){} // RVA: 0x7FFE87CEB950
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7FFE87CEB9A0
        public void AllocateDeviceId(){} // RVA: 0x7FFE87CEB9F0
        public void QueueInputEvent(){} // RVA: 0x7FFE87CEBA40
        public void IOCTL(){} // RVA: 0x7FFE87CEBA90
        public void SetPollingFrequency(){} // RVA: 0x7FFE87CEBB10
        public void Update(){} // RVA: 0x7FFE87CEBB70
    }

    public class NativeUpdateCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE812572A0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

}