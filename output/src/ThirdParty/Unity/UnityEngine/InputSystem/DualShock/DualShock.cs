// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.DualShock
// Classes: 6
// Methods: 77

namespace ThirdParty.Unity.UnityEngine.InputSystem.DualShock
{
    public class DualSenseGamepadHID : DualShockGamepad
    {
        public _1.ceControlChangedValue leftTriggerButton; // 0x288
        public _1.ceControlChangedValue rightTriggerButton; // 0x290
        public _1.ceControlChangedValue playStationButton; // 0x298
        public aphy<float> m_LowFrequencyMotorSpeed; // 0x2A0
        public aphy<float> m_HighFrequenceyMotorSpeed; // 0x2A8
        public aphy<?> m_LightBarColor; // 0x2B0
        public byte outputSequenceId; // 0x2C4
        public byte JitterMaskLow;
        public byte JitterMaskHigh;

        // ── Methods ──
        public void get_leftTriggerButton(){} // RVA: 0x7FFD4EDD71D0
        public void set_leftTriggerButton(){} // RVA: 0x7FFD4EDD9FC0
        public void get_rightTriggerButton(){} // RVA: 0x7FFD4EDE6830
        public void set_rightTriggerButton(){} // RVA: 0x7FFD4EDEA880
        public void get_playStationButton(){} // RVA: 0x7FFD4EDCE8B0
        public void set_playStationButton(){} // RVA: 0x7FFD4EDD5850
        public void FinishSetup(){} // RVA: 0x7FFD54A8FFC0
        public void PauseHaptics(){} // RVA: 0x7FFD54A90190
        public void ResetHaptics(){} // RVA: 0x7FFD54A90240
        public void ResumeHaptics(){} // RVA: 0x7FFD54A902D0
        public void SetLightBarColor(){} // RVA: 0x7FFD54A90350
        public void SetMotorSpeeds(){} // RVA: 0x7FFD54A903F0
        public void SetMotorSpeedsAndLightBarColor(){} // RVA: 0x7FFD54A904C0
        public void MergeForward(){} // RVA: 0x7FFD54A90850 | overloaded x3
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x7FFD54A90890
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x7FFD54A90A40
        public void OnNextUpdate(){} // RVA: 0x7FFD4E341310
        public void OnStateEvent(){} // RVA: 0x7FFD54A90CF0
        public void GetStateOffsetForEvent(){} // RVA: 0x7FFD4E341320
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class DualShock3GamepadHID : DualShockGamepad
    {
        public _1.ceControlChangedValue leftTriggerButton; // 0x288
        public _1.ceControlChangedValue rightTriggerButton; // 0x290
        public _1.ceControlChangedValue playStationButton; // 0x298

        // ── Methods ──
        public void get_leftTriggerButton(){} // RVA: 0x7FFD4EDD71D0
        public void set_leftTriggerButton(){} // RVA: 0x7FFD4EDD9FC0
        public void get_rightTriggerButton(){} // RVA: 0x7FFD4EDE6830
        public void set_rightTriggerButton(){} // RVA: 0x7FFD4EDEA880
        public void get_playStationButton(){} // RVA: 0x7FFD4EDCE8B0
        public void set_playStationButton(){} // RVA: 0x7FFD4EDD5850
        public void FinishSetup(){} // RVA: 0x7FFD54A92010
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class DualShock4GamepadHID : DualShockGamepad
    {
        public _1.ceControlChangedValue leftTriggerButton; // 0x288
        public _1.ceControlChangedValue rightTriggerButton; // 0x290
        public _1.ceControlChangedValue playStationButton; // 0x298
        public aphy<float> m_LowFrequencyMotorSpeed; // 0x2A0
        public aphy<float> m_HighFrequenceyMotorSpeed; // 0x2A8
        public aphy<?> m_LightBarColor; // 0x2B0
        public byte JitterMaskLow;
        public byte JitterMaskHigh;

        // ── Methods ──
        public void get_leftTriggerButton(){} // RVA: 0x7FFD4EDD71D0
        public void set_leftTriggerButton(){} // RVA: 0x7FFD4EDD9FC0
        public void get_rightTriggerButton(){} // RVA: 0x7FFD4EDE6830
        public void set_rightTriggerButton(){} // RVA: 0x7FFD4EDEA880
        public void get_playStationButton(){} // RVA: 0x7FFD4EDCE8B0
        public void set_playStationButton(){} // RVA: 0x7FFD4EDD5850
        public void FinishSetup(){} // RVA: 0x7FFD54A91000
        public void PauseHaptics(){} // RVA: 0x7FFD54A911D0
        public void ResetHaptics(){} // RVA: 0x7FFD54A91310
        public void ResumeHaptics(){} // RVA: 0x7FFD54A91470
        public void SetLightBarColor(){} // RVA: 0x7FFD54A916C0
        public void SetMotorSpeeds(){} // RVA: 0x7FFD54A91860
        public void SetMotorSpeedsAndLightBarColor(){} // RVA: 0x7FFD54A91A00
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x7FFD54A91C40
        public void OnNextUpdate(){} // RVA: 0x7FFD4E341310
        public void OnStateEvent(){} // RVA: 0x7FFD54A91E00
        public void GetStateOffsetForEvent(){} // RVA: 0x7FFD4E341320
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class DualShockGamepad : Gamepad
    {
        public _1.ceControlChangedValue touchpadButton; // 0x210
        public _1.ceControlChangedValue optionsButton; // 0x218
        public _1.ceControlChangedValue shareButton; // 0x220
        public _1.ceControlChangedValue L1; // 0x228
        public _1.ceControlChangedValue R1; // 0x230
        public _1.ceControlChangedValue L2; // 0x238
        public _1.ceControlChangedValue R2; // 0x240
        public _1.ceControlChangedValue L3; // 0x248
        public _1.ceControlChangedValue R3; // 0x250
        public eOpenAmount>k__BackingField.ingField current;
        public ager hidDescriptor; // 0x258

        // ── Methods ──
        public void get_touchpadButton(){} // RVA: 0x7FFD4E96BCB0
        public void set_touchpadButton(){} // RVA: 0x7FFD4E963140
        public void get_optionsButton(){} // RVA: 0x7FFD4E961470
        public void set_optionsButton(){} // RVA: 0x7FFD4E962420
        public void get_shareButton(){} // RVA: 0x7FFD4E9693F0
        public void set_shareButton(){} // RVA: 0x7FFD4E96AC80
        public void get_L1(){} // RVA: 0x7FFD4E960FB0
        public void set_L1(){} // RVA: 0x7FFD4EDCE720
        public void get_R1(){} // RVA: 0x7FFD4E962820
        public void set_R1(){} // RVA: 0x7FFD4EDE7D40
        public void get_L2(){} // RVA: 0x7FFD4E9613D0
        public void set_L2(){} // RVA: 0x7FFD4EDCA7F0
        public void get_R2(){} // RVA: 0x7FFD4EDE9150
        public void set_R2(){} // RVA: 0x7FFD4EDD5A80
        public void get_L3(){} // RVA: 0x7FFD4EDC6830
        public void set_L3(){} // RVA: 0x7FFD4EDC8760
        public void get_R3(){} // RVA: 0x7FFD4EDE5D60
        public void set_R3(){} // RVA: 0x7FFD4EDD0650
        public void get_current(){} // RVA: 0x7FFD54A8F790
        public void set_current(){} // RVA: 0x7FFD54A8F7D0
        public void get_hidDescriptor(){} // RVA: 0x7FFD54A8F870
        public void set_hidDescriptor(){} // RVA: 0x7FFD54A8F8A0
        public void MakeCurrent(){} // RVA: 0x7FFD54A8F920
        public void OnRemoved(){} // RVA: 0x7FFD54A8F940
        public void FinishSetup(){} // RVA: 0x7FFD54A8FB00
        public void SetLightBarColor(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class DualShockSupport : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD54A921E0
    }

    public class IDualShockHaptics
    {
        // ── Methods ──
        public void SetLightBarColor(){} // RVA: 0x7FFD4E090A40
    }

}