// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.DualShock
// Classes: 6
// Methods: 77

namespace ThirdParty.Unity.UnityEngine.InputSystem.DualShock
{
    public class DualSenseGamepadHID : DualShockGamepad
    {
        public object _playStationButton; // 0x34C9C2E0, was: <playStationButton>k__BackingF
        public object m_LightBarColor; // 0x34C9C2E0
        public object JitterMaskHigh; // 0x34C9C2E0

        // ── Original Methods ──
        public void get_leftTriggerButton(){} // RVA: 0x7ffaa93d97a0
        public void set_leftTriggerButton(){} // RVA: 0x7ffaa93d2f80
        public void get_rightTriggerButton(){} // RVA: 0x7ffaa93f1b80
        public void set_rightTriggerButton(){} // RVA: 0x7ffaa93fa2a0
        public void get_playStationButton(){} // RVA: 0x7ffaa93d5d60
        public void set_playStationButton(){} // RVA: 0x7ffaa93f1c40
        public void FinishSetup(){} // RVA: 0x7ffaaf091fa0
        public void PauseHaptics(){} // RVA: 0x7ffaaf092170
        public void ResetHaptics(){} // RVA: 0x7ffaaf092220
        public void ResumeHaptics(){} // RVA: 0x7ffaaf0922b0
        public void MergeForward(){} // RVA: 0x7ffaaf092830
        public void MergeForward(){} // RVA: 0x7ffaaf092830
        public void MergeForward(){} // RVA: 0x7ffaaf092830
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x7ffaaf092870
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x7ffaaf092a20
        public void OnNextUpdate(){} // RVA: 0x7ffaa8932310
        public void OnStateEvent(){} // RVA: 0x7ffaaf092cd0
        public void .ctor(){} // RVA: 0x7ffaaef38410
        // ── Binary Analysis Named ──
        public void SetLightBarColor(){} // RVA: 0x7ffaaf092330
        public void SetMotorSpeeds(){} // RVA: 0x7ffaaf0923d0
        public void SetMotorSpeedsAndLightBarColor(){} // RVA: 0x7ffaaf0924a0
        public void GetStateOffsetForEvent(){} // RVA: 0x7ffaa8932320
    }

    public class DualShock3GamepadHID : DualShockGamepad
    {
        public object _playStationButton; // 0x34C9D170, was: <playStationButton>k__BackingF
        public object leftTriggerButton; // 0x17000424

        // ── Original Methods ──
        public void get_leftTriggerButton(){} // RVA: 0x7ffaa93d97a0
        public void set_leftTriggerButton(){} // RVA: 0x7ffaa93d2f80
        public void get_rightTriggerButton(){} // RVA: 0x7ffaa93f1b80
        public void set_rightTriggerButton(){} // RVA: 0x7ffaa93fa2a0
        public void get_playStationButton(){} // RVA: 0x7ffaa93d5d60
        public void set_playStationButton(){} // RVA: 0x7ffaa93f1c40
        public void FinishSetup(){} // RVA: 0x7ffaaf093ff0
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class DualShock4GamepadHID : DualShockGamepad
    {
        public object _playStationButton; // 0x34C9CC70, was: <playStationButton>k__BackingF
        public object m_LightBarColor; // 0x34C9CC70

        // ── Original Methods ──
        public void get_leftTriggerButton(){} // RVA: 0x7ffaa93d97a0
        public void set_leftTriggerButton(){} // RVA: 0x7ffaa93d2f80
        public void get_rightTriggerButton(){} // RVA: 0x7ffaa93f1b80
        public void set_rightTriggerButton(){} // RVA: 0x7ffaa93fa2a0
        public void get_playStationButton(){} // RVA: 0x7ffaa93d5d60
        public void set_playStationButton(){} // RVA: 0x7ffaa93f1c40
        public void FinishSetup(){} // RVA: 0x7ffaaf092fe0
        public void PauseHaptics(){} // RVA: 0x7ffaaf0931b0
        public void ResetHaptics(){} // RVA: 0x7ffaaf0932f0
        public void ResumeHaptics(){} // RVA: 0x7ffaaf093450
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x7ffaaf093c20
        public void OnNextUpdate(){} // RVA: 0x7ffaa8932310
        public void OnStateEvent(){} // RVA: 0x7ffaaf093de0
        public void .ctor(){} // RVA: 0x7ffaaef38410
        // ── Binary Analysis Named ──
        public void SetLightBarColor(){} // RVA: 0x7ffaaf0936a0
        public void SetMotorSpeeds(){} // RVA: 0x7ffaaf093840
        public void SetMotorSpeedsAndLightBarColor(){} // RVA: 0x7ffaaf0939e0
        public void GetStateOffsetForEvent(){} // RVA: 0x7ffaa8932320
    }

    public class DualShockGamepad : Gamepad
    {
        public object _shareButton; // 0x33C050D0, was: <shareButton>k__BackingField
        public object _l2; // 0x33C050D0, was: <L2>k__BackingField
        public object _r3; // 0x33C050D0, was: <R3>k__BackingField
        public object vendorId; // 0x34C27E40
        public object usagePage; // 0x34C27E40

        // ── Original Methods ──
        public void get_touchpadButton(){} // RVA: 0x7ffaa8f6dbe0
        public void set_touchpadButton(){} // RVA: 0x7ffaa8f6f550
        public void get_optionsButton(){} // RVA: 0x7ffaa8f70430
        public void set_optionsButton(){} // RVA: 0x7ffaa8f7aac0
        public void get_shareButton(){} // RVA: 0x7ffaa8f74760
        public void set_shareButton(){} // RVA: 0x7ffaa8f6e0b0
        public void get_L1(){} // RVA: 0x7ffaa8f75b00
        public void set_L1(){} // RVA: 0x7ffaa93e8560
        public void get_R1(){} // RVA: 0x7ffaa8f76170
        public void set_R1(){} // RVA: 0x7ffaa93d3600
        public void get_L2(){} // RVA: 0x7ffaa8f6ff20
        public void set_L2(){} // RVA: 0x7ffaa93d64a0
        public void get_R2(){} // RVA: 0x7ffaa93e4de0
        public void set_R2(){} // RVA: 0x7ffaa93d5a40
        public void get_L3(){} // RVA: 0x7ffaa93e4a80
        public void set_L3(){} // RVA: 0x7ffaa93fd280
        public void get_R3(){} // RVA: 0x7ffaa93e7730
        public void set_R3(){} // RVA: 0x7ffaa93ea060
        public void get_current(){} // RVA: 0x7ffaaf091770
        public void set_current(){} // RVA: 0x7ffaaf0917b0
        public void get_hidDescriptor(){} // RVA: 0x7ffaaf091850
        public void set_hidDescriptor(){} // RVA: 0x7ffaaf091880
        public void MakeCurrent(){} // RVA: 0x7ffaaf091900
        public void OnRemoved(){} // RVA: 0x7ffaaf091920
        public void FinishSetup(){} // RVA: 0x7ffaaf091ae0
        public void .ctor(){} // RVA: 0x7ffaaef38410
        // ── Binary Analysis Named ──
        public void SetLightBarColor(){} // RVA: 0x7ffaa8932310
    }

    public class DualShockSupport : Object
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaaf0941c0
    }

    public class IDualShockHaptics
    {
        // ── Binary Analysis Named ──
        public void SetLightBarColor(){} // RVA: 0x7ffaa8660d80
    }

}