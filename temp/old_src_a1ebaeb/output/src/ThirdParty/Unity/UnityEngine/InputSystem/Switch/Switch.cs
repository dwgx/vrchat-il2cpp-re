// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Switch
// Classes: 2
// Methods: 14

namespace ThirdParty.Unity.UnityEngine.InputSystem.Switch
{
    public class SwitchProControllerHID : Gamepad
    {
        public object s_HandshakeSequence; // 0x33630A70
        public object JitterMaskLow; // 0x33630A70

        // ── Original Methods ──
        public void get_captureButton(){} // RVA: 0x7ffaa8f6dbe0
        public void set_captureButton(){} // RVA: 0x7ffaa8f6f550
        public void get_homeButton(){} // RVA: 0x7ffaa8f70430
        public void set_homeButton(){} // RVA: 0x7ffaa8f7aac0
        public void OnAdded(){} // RVA: 0x7ffaaf079010
        public void HandshakeRestart(){} // RVA: 0x7ffaaf079230
        public void HandshakeTick(){} // RVA: 0x7ffaaf0792b0
        public void OnNextUpdate(){} // RVA: 0x7ffaaf0795b0
        public void OnStateEvent(){} // RVA: 0x7ffaaf0795c0
        public void PreProcessEvent(){} // RVA: 0x7ffaaf079750
        public void .ctor(){} // RVA: 0x7ffaaef38410
        public void .cctor(){} // RVA: 0x7ffaaf079900
        // ── Binary Analysis Named ──
        public void GetStateOffsetForEvent(){} // RVA: 0x7ffaa8932320
    }

    public class SwitchSupportHID : Object
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaaf07a350
    }

}