// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.DualShock
// Classes: 6
// Methods: 77

namespace ThirdParty.Unity.UnityEngine.InputSystem.DualShock
{
    public class DualSenseGamepadHID
    {
        public UnityEngine.InputSystem.Controls.ButtonControl <leftTriggerButton>k__BackingField; // 0x288
        public UnityEngine.InputSystem.Controls.ButtonControl <rightTriggerButton>k__BackingField; // 0x290
        public UnityEngine.InputSystem.Controls.ButtonControl <playStationButton>k__BackingField; // 0x298

        // ── Methods ──
        public void get_leftTriggerButton(){} // RVA: 0xD94490
        public void set_leftTriggerButton(){} // RVA: 0xD83C70
        public void get_rightTriggerButton(){} // RVA: 0xD9AA90
        public void set_rightTriggerButton(){} // RVA: 0xD89570
        public void get_playStationButton(){} // RVA: 0xDA0DF0
        public void set_playStationButton(){} // RVA: 0xD8E4E0
        public void FinishSetup(){} // RVA: 0x6ED7890
        public void PauseHaptics(){} // RVA: 0x6ED7A60
        public void ResetHaptics(){} // RVA: 0x6ED7B10
        public void ResumeHaptics(){} // RVA: 0x6ED7BA0
        public void SetLightBarColor(){} // RVA: 0x6ED7C20
        public void SetMotorSpeeds(){} // RVA: 0x6ED7CC0
        public void SetMotorSpeedsAndLightBarColor(){} // RVA: 0x6ED7D90
        public void MergeForward(){} // RVA: 0x6ED8120 | overloaded x3
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x6ED8160
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x6ED8310
        public void OnNextUpdate(){} // RVA: 0x2DD310
        public void OnStateEvent(){} // RVA: 0x6ED85C0
        public void GetStateOffsetForEvent(){} // RVA: 0x2DD320
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class DualShock3GamepadHID
    {
        public UnityEngine.InputSystem.Controls.ButtonControl <leftTriggerButton>k__BackingField; // 0x288
        public UnityEngine.InputSystem.Controls.ButtonControl <rightTriggerButton>k__BackingField; // 0x290
        public UnityEngine.InputSystem.Controls.ButtonControl <playStationButton>k__BackingField; // 0x298

        // ── Methods ──
        public void get_leftTriggerButton(){} // RVA: 0xD94490
        public void set_leftTriggerButton(){} // RVA: 0xD83C70
        public void get_rightTriggerButton(){} // RVA: 0xD9AA90
        public void set_rightTriggerButton(){} // RVA: 0xD89570
        public void get_playStationButton(){} // RVA: 0xDA0DF0
        public void set_playStationButton(){} // RVA: 0xD8E4E0
        public void FinishSetup(){} // RVA: 0x6ED98E0
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class DualShock4GamepadHID
    {
        public UnityEngine.InputSystem.Controls.ButtonControl <leftTriggerButton>k__BackingField; // 0x288
        public UnityEngine.InputSystem.Controls.ButtonControl <rightTriggerButton>k__BackingField; // 0x290
        public UnityEngine.InputSystem.Controls.ButtonControl <playStationButton>k__BackingField; // 0x298

        // ── Methods ──
        public void get_leftTriggerButton(){} // RVA: 0xD94490
        public void set_leftTriggerButton(){} // RVA: 0xD83C70
        public void get_rightTriggerButton(){} // RVA: 0xD9AA90
        public void set_rightTriggerButton(){} // RVA: 0xD89570
        public void get_playStationButton(){} // RVA: 0xDA0DF0
        public void set_playStationButton(){} // RVA: 0xD8E4E0
        public void FinishSetup(){} // RVA: 0x6ED88D0
        public void PauseHaptics(){} // RVA: 0x6ED8AA0
        public void ResetHaptics(){} // RVA: 0x6ED8BE0
        public void ResumeHaptics(){} // RVA: 0x6ED8D40
        public void SetLightBarColor(){} // RVA: 0x6ED8F90
        public void SetMotorSpeeds(){} // RVA: 0x6ED9130
        public void SetMotorSpeedsAndLightBarColor(){} // RVA: 0x6ED92D0
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x6ED9510
        public void OnNextUpdate(){} // RVA: 0x2DD310
        public void OnStateEvent(){} // RVA: 0x6ED96D0
        public void GetStateOffsetForEvent(){} // RVA: 0x2DD320
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class DualShockGamepad
    {
        public UnityEngine.InputSystem.Controls.ButtonControl <touchpadButton>k__BackingField; // 0x210
        public UnityEngine.InputSystem.Controls.ButtonControl <optionsButton>k__BackingField; // 0x218
        public UnityEngine.InputSystem.Controls.ButtonControl <shareButton>k__BackingField; // 0x220
        public UnityEngine.InputSystem.Controls.ButtonControl <L1>k__BackingField; // 0x228
        public UnityEngine.InputSystem.Controls.ButtonControl <R1>k__BackingField; // 0x230
        public UnityEngine.InputSystem.Controls.ButtonControl <L2>k__BackingField; // 0x238
        public UnityEngine.InputSystem.Controls.ButtonControl <R2>k__BackingField; // 0x240
        public UnityEngine.InputSystem.Controls.ButtonControl <L3>k__BackingField; // 0x248
        public UnityEngine.InputSystem.Controls.ButtonControl <R3>k__BackingField; // 0x250
        public UnityEngine.InputSystem.DualShock.DualShockGamepad <current>k__BackingField;
        public HIDDeviceDescriptor <hidDescriptor>k__BackingField; // 0x258

        // ── Methods ──
        public void get_touchpadButton(){} // RVA: 0xD9F7C0
        public void set_touchpadButton(){} // RVA: 0xD9BA80
        public void get_optionsButton(){} // RVA: 0xD88BD0
        public void set_optionsButton(){} // RVA: 0xD9AC30
        public void get_shareButton(){} // RVA: 0xD915D0
        public void set_shareButton(){} // RVA: 0xD93180
        public void get_L1(){} // RVA: 0xD90650
        public void set_L1(){} // RVA: 0xD9F060
        public void get_R1(){} // RVA: 0xDA0BC0
        public void set_R1(){} // RVA: 0xD8A490
        public void get_L2(){} // RVA: 0xD90BA0
        public void set_L2(){} // RVA: 0xD94430
        public void get_R2(){} // RVA: 0xD94B90
        public void set_R2(){} // RVA: 0xD9C4E0
        public void get_L3(){} // RVA: 0xD83050
        public void set_L3(){} // RVA: 0xD88A80
        public void get_R3(){} // RVA: 0xD90760
        public void set_R3(){} // RVA: 0xD8AD50
        public void get_current(){} // RVA: 0x6ED7060
        public void set_current(){} // RVA: 0x6ED70A0
        public void get_hidDescriptor(){} // RVA: 0x6ED7140
        public void set_hidDescriptor(){} // RVA: 0x6ED7170
        public void MakeCurrent(){} // RVA: 0x6ED71F0
        public void OnRemoved(){} // RVA: 0x6ED7210
        public void FinishSetup(){} // RVA: 0x6ED73D0
        public void SetLightBarColor(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class DualShockSupport
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x6ED9AB0
    }

    public class IDualShockHaptics
    {
        // ── Methods ──
        public void SetLightBarColor(){} // RVA: 0x24B10
    }

}