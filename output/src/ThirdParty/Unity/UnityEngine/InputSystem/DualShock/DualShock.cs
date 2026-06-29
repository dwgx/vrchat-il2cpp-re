// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.DualShock
// Classes: 6
// Methods: 75

namespace ThirdParty.Unity.UnityEngine.InputSystem.DualShock
{
    public class DualSenseGamepadHID : DualShockGamepad
    {
        public object _leftTriggerButton;
        public object _rightTriggerButton;
        public object _playStationButton;
        public object m_LowFrequencyMotorSpeed;
        public object m_HighFrequenceyMotorSpeed;
        public object m_LightBarColor;
        public object outputSequenceId;
        public object JitterMaskLow;
        public object JitterMaskHigh;

        // ── Methods ──
        public void get_leftTriggerButton(){} // RVA: 0x164ECD0
        public void set_leftTriggerButton(){} // RVA: 0x165A680
        public void get_rightTriggerButton(){} // RVA: 0x165EF80
        public void set_rightTriggerButton(){} // RVA: 0x165BB40
        public void get_playStationButton(){} // RVA: 0x165D6B0
        public void set_playStationButton(){} // RVA: 0x165A0C0
        public void FinishSetup(){} // RVA: 0x7923D40
        public void PauseHaptics(){} // RVA: 0x7923F10
        public void ResetHaptics(){} // RVA: 0x7923FC0
        public void ResumeHaptics(){} // RVA: 0x7924050
        public void SetLightBarColor(){} // RVA: 0x79240D0
        public void SetMotorSpeeds(){} // RVA: 0x7924170
        public void SetMotorSpeedsAndLightBarColor(){} // RVA: 0x7924240
        public void MergeForward(){} // RVA: 0x79245D0
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x7924610
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x79247B0
        public void OnNextUpdate(){} // RVA: 0xB43310
        public void OnStateEvent(){} // RVA: 0x7924A60
        public void GetStateOffsetForEvent(){} // RVA: 0xB43320
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class DualShock3GamepadHID : DualShockGamepad
    {
        public object _leftTriggerButton;
        public object _rightTriggerButton;
        public object _playStationButton;

        // ── Methods ──
        public void get_leftTriggerButton(){} // RVA: 0x164ECD0
        public void set_leftTriggerButton(){} // RVA: 0x165A680
        public void get_rightTriggerButton(){} // RVA: 0x165EF80
        public void set_rightTriggerButton(){} // RVA: 0x165BB40
        public void get_playStationButton(){} // RVA: 0x165D6B0
        public void set_playStationButton(){} // RVA: 0x165A0C0
        public void FinishSetup(){} // RVA: 0x7925D80
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class DualShock4GamepadHID : DualShockGamepad
    {
        public object _leftTriggerButton;
        public object _rightTriggerButton;
        public object _playStationButton;
        public object m_LowFrequencyMotorSpeed;
        public object m_HighFrequenceyMotorSpeed;
        public object m_LightBarColor;
        public object JitterMaskLow;
        public object JitterMaskHigh;

        // ── Methods ──
        public void get_leftTriggerButton(){} // RVA: 0x164ECD0
        public void set_leftTriggerButton(){} // RVA: 0x165A680
        public void get_rightTriggerButton(){} // RVA: 0x165EF80
        public void set_rightTriggerButton(){} // RVA: 0x165BB40
        public void get_playStationButton(){} // RVA: 0x165D6B0
        public void set_playStationButton(){} // RVA: 0x165A0C0
        public void FinishSetup(){} // RVA: 0x7924D70
        public void PauseHaptics(){} // RVA: 0x7924F40
        public void ResetHaptics(){} // RVA: 0x7925080
        public void ResumeHaptics(){} // RVA: 0x79251E0
        public void SetLightBarColor(){} // RVA: 0x7925430
        public void SetMotorSpeeds(){} // RVA: 0x79255D0
        public void SetMotorSpeedsAndLightBarColor(){} // RVA: 0x7925770
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x79259B0
        public void OnNextUpdate(){} // RVA: 0xB43310
        public void OnStateEvent(){} // RVA: 0x7925B70
        public void GetStateOffsetForEvent(){} // RVA: 0xB43320
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class DualShockGamepad : Gamepad
    {
        public object _touchpadButton;
        public object _optionsButton;
        public object _shareButton;
        public object _l1;
        public object _r1;
        public object _l2;
        public object _r2;
        public object _l3;
        public object _r3;
        public object _current;
        public object _hidDescriptor;

        // ── Methods ──
        public void get_touchpadButton(){} // RVA: 0x1640C90
        public void set_touchpadButton(){} // RVA: 0x1668690
        public void get_optionsButton(){} // RVA: 0x165F950
        public void set_optionsButton(){} // RVA: 0x164BF20
        public void get_shareButton(){} // RVA: 0x1667A40
        public void set_shareButton(){} // RVA: 0x163A9E0
        public void get_L1(){} // RVA: 0x165A670
        public void set_L1(){} // RVA: 0x1661A80
        public void get_R1(){} // RVA: 0x163BF50
        public void set_R1(){} // RVA: 0x164C6E0
        public void get_L2(){} // RVA: 0x163F650
        public void set_L2(){} // RVA: 0x1656720
        public void get_R2(){} // RVA: 0x164AA90
        public void set_R2(){} // RVA: 0x164B2D0
        public void get_L3(){} // RVA: 0x165DF30
        public void set_L3(){} // RVA: 0x164E760
        public void get_R3(){} // RVA: 0x16565B0
        public void set_R3(){} // RVA: 0x166D140
        public void get_current(){} // RVA: 0x7923510
        public void set_current(){} // RVA: 0x7923550
        public void get_hidDescriptor(){} // RVA: 0x79235F0
        public void set_hidDescriptor(){} // RVA: 0x7923620
        public void MakeCurrent(){} // RVA: 0x79236A0
        public void OnRemoved(){} // RVA: 0x79236C0
        public void FinishSetup(){} // RVA: 0x7923880
        public void SetLightBarColor(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class DualShockSupport : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7925F50
    }

    public class IDualShockHaptics
    {
        // ── Methods ──
        public void SetLightBarColor(){} // RVA: 0x894320
    }

}