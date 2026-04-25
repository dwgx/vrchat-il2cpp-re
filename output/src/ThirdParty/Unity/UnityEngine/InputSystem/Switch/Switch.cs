// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Switch
// Classes: 2
// Methods: 14

namespace ThirdParty.Unity.UnityEngine.InputSystem.Switch
{
    public class SwitchProControllerHID : Gamepad
    {
        public UnityEngine.InputSystem.Controls.ButtonControl captureButton; // 0x210
        public UnityEngine.InputSystem.Controls.ButtonControl homeButton; // 0x218
        public 0x6B14B270[] s_HandshakeSequence;
        public int m_HandshakeStepIndex; // 0x220
        public double m_HandshakeTimer; // 0x228
        public byte JitterMaskLow;
        public byte JitterMaskHigh;

        // ── Methods ──
        public void get_captureButton(){} // RVA: 0x7FFAC354BCB0
        public void set_captureButton(){} // RVA: 0x7FFAC3543140
        public void get_homeButton(){} // RVA: 0x7FFAC3541470
        public void set_homeButton(){} // RVA: 0x7FFAC3542420
        public void OnAdded(){} // RVA: 0x7FFAC9657030
        public void HandshakeRestart(){} // RVA: 0x7FFAC9657250
        public void HandshakeTick(){} // RVA: 0x7FFAC96572D0
        public void OnNextUpdate(){} // RVA: 0x7FFAC96575D0
        public void OnStateEvent(){} // RVA: 0x7FFAC96575E0
        public void GetStateOffsetForEvent(){} // RVA: 0x7FFAC2F21320
        public void PreProcessEvent(){} // RVA: 0x7FFAC9657770
        public void .ctor(){} // RVA: 0x7FFAC9516440
        public void .cctor(){} // RVA: 0x7FFAC9657920
    }

    public class SwitchSupportHID : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC9658370
    }

}