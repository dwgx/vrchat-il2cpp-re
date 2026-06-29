// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 5
// Methods: 35

namespace ThirdParty.Valve.Valve.VR
{
    public class VRActiveActionSet_t[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E320
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4160
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E345E0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class VRBoneTransform_t[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E320
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4160
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E345E0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class VRControllerState_t_Packed : ValueType
    {
        public object unPacketNum;
        public object ulButtonPressed;
        public object ulButtonTouched;
        public object rAxis0;
        public object rAxis1;
        public object rAxis2;
        public object rAxis3;
        public object rAxis4;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8E3760
        public void Unpack(){} // RVA: 0x8E3800
    }

    public class VREvent_Keyboard_t : ValueType
    {
        public object cNewInput0;
        public object cNewInput1;
        public object cNewInput2;
        public object cNewInput3;
        public object cNewInput4;
        public object cNewInput5;
        public object cNewInput6;
        public object cNewInput7;
        public object uUserValue;
        public object overlayHandle;

        // ── Methods ──
        public void get_cNewInput(){} // RVA: 0x9572A0
    }

    public class VREvent_t_Packed : ValueType
    {
        public object eventType;
        public object trackedDeviceIndex;
        public object eventAgeSeconds;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9573B0
        public void Unpack(){} // RVA: 0x9573F0
    }

}