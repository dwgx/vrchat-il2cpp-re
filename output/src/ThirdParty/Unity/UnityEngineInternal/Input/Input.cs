// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngineInternal.Input
// Classes: 4
// Methods: 17

namespace ThirdParty.Unity.UnityEngineInternal.Input
{
    public class NativeInputEvent : ValueType
    {
        public int structSize;
        public 0x6B2E0B68 type; // 0x10
        public ushort sizeInBytes; // 0x14
        public ushort deviceId; // 0x16
        public double time; // 0x18
        public int eventId; // 0x20
    }

    public class NativeInputEventBuffer : ValueType
    {
        public void* eventBuffer; // 0x10
        public int eventCount; // 0x18
        public int sizeInBytes; // 0x1C
        public int capacityInBytes; // 0x20
    }

    public class NativeInputSystem : Object
    {
        public UnityEngineInternal.Input.NativeUpdateCallback onDeviceDiscovered;
        public System.Action`1<0x6B2E0C70> hasDeviceDiscoveredCallback; // 0x8
        public System.Func`2<0x6B2E0C70,bool> currentTime; // 0x10
        public System.Action`2<int,string> currentTimeOffsetToRealtimeSinceStartup; // 0x18

        // ── Methods ──
        public void get_onDeviceDiscovered(){} // RVA: 0x7FFAC9942C70
        public void set_onDeviceDiscovered(){} // RVA: 0x7FFAC9942CD0
        public void .cctor(){} // RVA: 0x7FFAC9942DE0
        public void NotifyBeforeUpdate(){} // RVA: 0x7FFAC9942E30
        public void NotifyUpdate(){} // RVA: 0x7FFAC9942EB0
        public void NotifyDeviceDiscovered(){} // RVA: 0x7FFAC9942F50
        public void ShouldRunUpdate(){} // RVA: 0x7FFAC9942FD0
        public void set_hasDeviceDiscoveredCallback(){} // RVA: 0x7FFAC9943060
        public void get_currentTime(){} // RVA: 0x7FFAC99430B0
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7FFAC9943100
        public void AllocateDeviceId(){} // RVA: 0x7FFAC9943150
        public void QueueInputEvent(){} // RVA: 0x7FFAC99431A0
        public void IOCTL(){} // RVA: 0x7FFAC99431F0
        public void SetPollingFrequency(){} // RVA: 0x7FFAC9943270
        public void Update(){} // RVA: 0x7FFAC99432D0
    }

    public class NativeUpdateCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC307D2A0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

}