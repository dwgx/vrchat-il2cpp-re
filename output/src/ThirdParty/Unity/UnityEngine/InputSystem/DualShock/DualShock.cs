// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.DualShock
// Classes: 6
// Methods: 77

namespace ThirdParty.Unity.UnityEngine.InputSystem.DualShock
{
    public class DualSenseGamepadHID : DualShockGamepad
    {
        public UnityEngine.InputSystem.Controls.ButtonControl leftTriggerButton; // 0x288
        public UnityEngine.InputSystem.Controls.ButtonControl rightTriggerButton; // 0x290
        public UnityEngine.InputSystem.Controls.ButtonControl playStationButton; // 0x298
        public System.Nullable`1<float> m_LowFrequencyMotorSpeed; // 0x2A0
        public System.Nullable`1<float> m_HighFrequenceyMotorSpeed; // 0x2A8
        public System.Nullable`1<UnityEngine.Color> m_LightBarColor; // 0x2B0
        public byte outputSequenceId; // 0x2C4
        public byte JitterMaskLow;
        public byte JitterMaskHigh;

        // ── Methods ──
        public void get_leftTriggerButton(){} // RVA: 0x7FFAC39B71D0
        public void set_leftTriggerButton(){} // RVA: 0x7FFAC39B9FC0
        public void get_rightTriggerButton(){} // RVA: 0x7FFAC39C6830
        public void set_rightTriggerButton(){} // RVA: 0x7FFAC39CA880
        public void get_playStationButton(){} // RVA: 0x7FFAC39AE8B0
        public void set_playStationButton(){} // RVA: 0x7FFAC39B5850
        public void FinishSetup(){} // RVA: 0x7FFAC966FFC0
        public void PauseHaptics(){} // RVA: 0x7FFAC9670190
        public void ResetHaptics(){} // RVA: 0x7FFAC9670240
        public void ResumeHaptics(){} // RVA: 0x7FFAC96702D0
        public void SetLightBarColor(){} // RVA: 0x7FFAC9670350
        public void SetMotorSpeeds(){} // RVA: 0x7FFAC96703F0
        public void SetMotorSpeedsAndLightBarColor(){} // RVA: 0x7FFAC96704C0
        public void MergeForward(){} // RVA: 0x7FFAC9670850 | overloaded x3
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x7FFAC9670890
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x7FFAC9670A40
        public void OnNextUpdate(){} // RVA: 0x7FFAC2F21310
        public void OnStateEvent(){} // RVA: 0x7FFAC9670CF0
        public void GetStateOffsetForEvent(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class DualShock3GamepadHID : DualShockGamepad
    {
        public UnityEngine.InputSystem.Controls.ButtonControl leftTriggerButton; // 0x288
        public UnityEngine.InputSystem.Controls.ButtonControl rightTriggerButton; // 0x290
        public UnityEngine.InputSystem.Controls.ButtonControl playStationButton; // 0x298

        // ── Methods ──
        public void get_leftTriggerButton(){} // RVA: 0x7FFAC39B71D0
        public void set_leftTriggerButton(){} // RVA: 0x7FFAC39B9FC0
        public void get_rightTriggerButton(){} // RVA: 0x7FFAC39C6830
        public void set_rightTriggerButton(){} // RVA: 0x7FFAC39CA880
        public void get_playStationButton(){} // RVA: 0x7FFAC39AE8B0
        public void set_playStationButton(){} // RVA: 0x7FFAC39B5850
        public void FinishSetup(){} // RVA: 0x7FFAC9672010
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class DualShock4GamepadHID : DualShockGamepad
    {
        public UnityEngine.InputSystem.Controls.ButtonControl leftTriggerButton; // 0x288
        public UnityEngine.InputSystem.Controls.ButtonControl rightTriggerButton; // 0x290
        public UnityEngine.InputSystem.Controls.ButtonControl playStationButton; // 0x298
        public System.Nullable`1<float> m_LowFrequencyMotorSpeed; // 0x2A0
        public System.Nullable`1<float> m_HighFrequenceyMotorSpeed; // 0x2A8
        public System.Nullable`1<UnityEngine.Color> m_LightBarColor; // 0x2B0
        public byte JitterMaskLow;
        public byte JitterMaskHigh;

        // ── Methods ──
        public void get_leftTriggerButton(){} // RVA: 0x7FFAC39B71D0
        public void set_leftTriggerButton(){} // RVA: 0x7FFAC39B9FC0
        public void get_rightTriggerButton(){} // RVA: 0x7FFAC39C6830
        public void set_rightTriggerButton(){} // RVA: 0x7FFAC39CA880
        public void get_playStationButton(){} // RVA: 0x7FFAC39AE8B0
        public void set_playStationButton(){} // RVA: 0x7FFAC39B5850
        public void FinishSetup(){} // RVA: 0x7FFAC9671000
        public void PauseHaptics(){} // RVA: 0x7FFAC96711D0
        public void ResetHaptics(){} // RVA: 0x7FFAC9671310
        public void ResumeHaptics(){} // RVA: 0x7FFAC9671470
        public void SetLightBarColor(){} // RVA: 0x7FFAC96716C0
        public void SetMotorSpeeds(){} // RVA: 0x7FFAC9671860
        public void SetMotorSpeedsAndLightBarColor(){} // RVA: 0x7FFAC9671A00
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x7FFAC9671C40
        public void OnNextUpdate(){} // RVA: 0x7FFAC2F21310
        public void OnStateEvent(){} // RVA: 0x7FFAC9671E00
        public void GetStateOffsetForEvent(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class DualShockGamepad : Gamepad
    {
        public UnityEngine.InputSystem.Controls.ButtonControl touchpadButton; // 0x210
        public UnityEngine.InputSystem.Controls.ButtonControl optionsButton; // 0x218
        public UnityEngine.InputSystem.Controls.ButtonControl shareButton; // 0x220
        public UnityEngine.InputSystem.Controls.ButtonControl L1; // 0x228
        public UnityEngine.InputSystem.Controls.ButtonControl R1; // 0x230
        public UnityEngine.InputSystem.Controls.ButtonControl L2; // 0x238
        public UnityEngine.InputSystem.Controls.ButtonControl R2; // 0x240
        public UnityEngine.InputSystem.Controls.ButtonControl L3; // 0x248
        public UnityEngine.InputSystem.Controls.ButtonControl R3; // 0x250
        public UnityEngine.InputSystem.DualShock.DualShockGamepad current;
        public HIDDeviceDescriptor hidDescriptor; // 0x258

        // ── Methods ──
        public void get_touchpadButton(){} // RVA: 0x7FFAC354BCB0
        public void set_touchpadButton(){} // RVA: 0x7FFAC3543140
        public void get_optionsButton(){} // RVA: 0x7FFAC3541470
        public void set_optionsButton(){} // RVA: 0x7FFAC3542420
        public void get_shareButton(){} // RVA: 0x7FFAC35493F0
        public void set_shareButton(){} // RVA: 0x7FFAC354AC80
        public void get_L1(){} // RVA: 0x7FFAC3540FB0
        public void set_L1(){} // RVA: 0x7FFAC39AE720
        public void get_R1(){} // RVA: 0x7FFAC3542820
        public void set_R1(){} // RVA: 0x7FFAC39C7D40
        public void get_L2(){} // RVA: 0x7FFAC35413D0
        public void set_L2(){} // RVA: 0x7FFAC39AA7F0
        public void get_R2(){} // RVA: 0x7FFAC39C9150
        public void set_R2(){} // RVA: 0x7FFAC39B5A80
        public void get_L3(){} // RVA: 0x7FFAC39A6830
        public void set_L3(){} // RVA: 0x7FFAC39A8760
        public void get_R3(){} // RVA: 0x7FFAC39C5D60
        public void set_R3(){} // RVA: 0x7FFAC39B0650
        public void get_current(){} // RVA: 0x7FFAC966F790
        public void set_current(){} // RVA: 0x7FFAC966F7D0
        public void get_hidDescriptor(){} // RVA: 0x7FFAC966F870
        public void set_hidDescriptor(){} // RVA: 0x7FFAC966F8A0
        public void MakeCurrent(){} // RVA: 0x7FFAC966F920
        public void OnRemoved(){} // RVA: 0x7FFAC966F940
        public void FinishSetup(){} // RVA: 0x7FFAC966FB00
        public void SetLightBarColor(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class DualShockSupport : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC96721E0
    }

    public class IDualShockHaptics
    {
        // ── Methods ──
        public void SetLightBarColor(){} // RVA: 0x7FFAC2C70A40
    }

}