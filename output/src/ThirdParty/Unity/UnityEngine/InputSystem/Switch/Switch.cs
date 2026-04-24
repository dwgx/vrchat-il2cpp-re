// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Switch
// Classes: 2
// Methods: 14

namespace ThirdParty.Unity.UnityEngine.InputSystem.Switch
{
    public class SwitchProControllerHID : Gamepad
    {
        public _1.ceControlChangedValue captureButton; // 0x210
        public _1.ceControlChangedValue homeButton; // 0x218
        public everAutoSwitchControlSchemes[] s_HandshakeSequence;
        public int m_HandshakeStepIndex; // 0x220
        public double m_HandshakeTimer; // 0x228
        public byte JitterMaskLow;
        public byte JitterMaskHigh;

        // ── Methods ──
        public void get_captureButton(){} // RVA: 0x7FFD4E96BCB0
        public void set_captureButton(){} // RVA: 0x7FFD4E963140
        public void get_homeButton(){} // RVA: 0x7FFD4E961470
        public void set_homeButton(){} // RVA: 0x7FFD4E962420
        public void OnAdded(){} // RVA: 0x7FFD54A77030
        public void HandshakeRestart(){} // RVA: 0x7FFD54A77250
        public void HandshakeTick(){} // RVA: 0x7FFD54A772D0
        public void OnNextUpdate(){} // RVA: 0x7FFD54A775D0
        public void OnStateEvent(){} // RVA: 0x7FFD54A775E0
        public void GetStateOffsetForEvent(){} // RVA: 0x7FFD4E341320
        public void PreProcessEvent(){} // RVA: 0x7FFD54A77770
        public void .ctor(){} // RVA: 0x7FFD54936440
        public void .cctor(){} // RVA: 0x7FFD54A77920
    }

    public class SwitchSupportHID : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD54A78370
    }

}