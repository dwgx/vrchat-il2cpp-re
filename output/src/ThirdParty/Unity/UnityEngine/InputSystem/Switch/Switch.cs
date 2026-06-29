// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Switch
// Classes: 2
// Methods: 14

namespace ThirdParty.Unity.UnityEngine.InputSystem.Switch
{
    public class SwitchProControllerHID : Gamepad
    {
        public object _captureButton;
        public object _homeButton;
        public object s_HandshakeSequence;
        public object m_HandshakeStepIndex;
        public object m_HandshakeTimer;
        public object JitterMaskLow;
        public object JitterMaskHigh;

        // ── Methods ──
        public void get_captureButton(){} // RVA: 0x1640C90
        public void set_captureButton(){} // RVA: 0x1668690
        public void get_homeButton(){} // RVA: 0x165F950
        public void set_homeButton(){} // RVA: 0x164BF20
        public void OnAdded(){} // RVA: 0x790B0B0
        public void HandshakeRestart(){} // RVA: 0x790B2D0
        public void HandshakeTick(){} // RVA: 0x790B350
        public void OnNextUpdate(){} // RVA: 0x790B670
        public void OnStateEvent(){} // RVA: 0x790B680
        public void GetStateOffsetForEvent(){} // RVA: 0xB43320
        public void PreProcessEvent(){} // RVA: 0x790B810
        public void .ctor(){} // RVA: 0x77D4F00
        public void .cctor(){} // RVA: 0x790B9C0
    }

    public class SwitchSupportHID : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x790C410
    }

}