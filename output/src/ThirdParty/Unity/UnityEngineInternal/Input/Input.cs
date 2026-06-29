// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngineInternal.Input
// Classes: 3
// Methods: 35

namespace ThirdParty.Unity.UnityEngineInternal.Input
{
    public class NativeInputSystem : Object
    {
        // ── Methods ──
        public void get_onDeviceDiscovered(){} // RVA: 0x7CAD0D0
        public void set_onDeviceDiscovered(){} // RVA: 0x7CAD130
        public void .cctor(){} // RVA: 0x7CAD240
        public void NotifyBeforeUpdate(){} // RVA: 0x7CAD290
        public void NotifyUpdate(){} // RVA: 0x7CAD310
        public void NotifyDeviceDiscovered(){} // RVA: 0x7CAD3B0
        public void ShouldRunUpdate(){} // RVA: 0x7CAD430
        public void set_hasDeviceDiscoveredCallback(){} // RVA: 0x7CAD4C0
        public void get_currentTime(){} // RVA: 0x7CAD510
        public void get_currentTimeOffsetToRealtimeSinceStartup(){} // RVA: 0x7CAD560
        public void AllocateDeviceId(){} // RVA: 0x7CAD5B0
        public void QueueInputEvent(){} // RVA: 0x7CAD600
        public void IOCTL(){} // RVA: 0x7CAD650
        public void SetPollingFrequency(){} // RVA: 0x7CAD6D0
        public void Update(){} // RVA: 0x7CAD730
        public void get_normalizeScrollWheelDelta(){} // RVA: 0x7CAD780
        public void set_normalizeScrollWheelDelta(){} // RVA: 0x7CAD7D0
        public void GetScrollWheelDeltaPerTick(){} // RVA: 0x7CAD820
    }

    public class NativeInputSystem[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class NativeUpdateCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xCA8B20
        public void Invoke(){} // RVA: 0xCA8BF0
    }

}