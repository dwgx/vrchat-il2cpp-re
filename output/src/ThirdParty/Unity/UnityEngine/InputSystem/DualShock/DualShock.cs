// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.DualShock
// Classes: 6
// Methods: 77

namespace ThirdParty.Unity.UnityEngine.InputSystem.DualShock
{
    public class DualSenseGamepadHID : DualShockGamepad
    {
        public UnityEngine.InputSystem.Controls.ButtonControl _leftTriggerButton; // 0x288
        public UnityEngine.InputSystem.Controls.ButtonControl _rightTriggerButton; // 0x290
        public UnityEngine.InputSystem.Controls.ButtonControl _playStationButton; // 0x298

        // ── Methods ──
        public void get_leftTriggerButton(){} // RVA: 0x7FFE81B0F100
        public void set_leftTriggerButton(){} // RVA: 0x7FFE81B2B270
        public void get_rightTriggerButton(){} // RVA: 0x7FFE81B2FC70
        public void set_rightTriggerButton(){} // RVA: 0x7FFE81B15310
        public void get_playStationButton(){} // RVA: 0x7FFE81B2D410
        public void set_playStationButton(){} // RVA: 0x7FFE81B13B30
        public void FinishSetup(){} // RVA: 0x7FFE87A18720
        public void PauseHaptics(){} // RVA: 0x7FFE87A188F0
        public void ResetHaptics(){} // RVA: 0x7FFE87A189A0
        public void ResumeHaptics(){} // RVA: 0x7FFE87A18A30
        public void SetLightBarColor(){} // RVA: 0x7FFE87A18AB0
        public void SetMotorSpeeds(){} // RVA: 0x7FFE87A18B50
        public void SetMotorSpeedsAndLightBarColor(){} // RVA: 0x7FFE87A18C20
        public void MergeForward(){} // RVA: 0x7FFE87A18FB0 | overloaded x3
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x7FFE87A18FF0
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x7FFE87A191A0
        public void OnNextUpdate(){} // RVA: 0x7FFE810FB310
        public void OnStateEvent(){} // RVA: 0x7FFE87A19450
        public void GetStateOffsetForEvent(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class DualShock3GamepadHID : DualShockGamepad
    {
        public UnityEngine.InputSystem.Controls.ButtonControl _leftTriggerButton; // 0x288
        public UnityEngine.InputSystem.Controls.ButtonControl _rightTriggerButton; // 0x290
        public UnityEngine.InputSystem.Controls.ButtonControl _playStationButton; // 0x298

        // ── Methods ──
        public void get_leftTriggerButton(){} // RVA: 0x7FFE81B0F100
        public void set_leftTriggerButton(){} // RVA: 0x7FFE81B2B270
        public void get_rightTriggerButton(){} // RVA: 0x7FFE81B2FC70
        public void set_rightTriggerButton(){} // RVA: 0x7FFE81B15310
        public void get_playStationButton(){} // RVA: 0x7FFE81B2D410
        public void set_playStationButton(){} // RVA: 0x7FFE81B13B30
        public void FinishSetup(){} // RVA: 0x7FFE87A1A770
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class DualShock4GamepadHID : DualShockGamepad
    {
        public UnityEngine.InputSystem.Controls.ButtonControl _leftTriggerButton; // 0x288
        public UnityEngine.InputSystem.Controls.ButtonControl _rightTriggerButton; // 0x290
        public UnityEngine.InputSystem.Controls.ButtonControl _playStationButton; // 0x298

        // ── Methods ──
        public void get_leftTriggerButton(){} // RVA: 0x7FFE81B0F100
        public void set_leftTriggerButton(){} // RVA: 0x7FFE81B2B270
        public void get_rightTriggerButton(){} // RVA: 0x7FFE81B2FC70
        public void set_rightTriggerButton(){} // RVA: 0x7FFE81B15310
        public void get_playStationButton(){} // RVA: 0x7FFE81B2D410
        public void set_playStationButton(){} // RVA: 0x7FFE81B13B30
        public void FinishSetup(){} // RVA: 0x7FFE87A19760
        public void PauseHaptics(){} // RVA: 0x7FFE87A19930
        public void ResetHaptics(){} // RVA: 0x7FFE87A19A70
        public void ResumeHaptics(){} // RVA: 0x7FFE87A19BD0
        public void SetLightBarColor(){} // RVA: 0x7FFE87A19E20
        public void SetMotorSpeeds(){} // RVA: 0x7FFE87A19FC0
        public void SetMotorSpeedsAndLightBarColor(){} // RVA: 0x7FFE87A1A160
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x7FFE87A1A3A0
        public void OnNextUpdate(){} // RVA: 0x7FFE810FB310
        public void OnStateEvent(){} // RVA: 0x7FFE87A1A560
        public void GetStateOffsetForEvent(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class DualShockGamepad : Gamepad
    {
        public UnityEngine.InputSystem.Controls.ButtonControl _touchpadButton; // 0x210
        public UnityEngine.InputSystem.Controls.ButtonControl _optionsButton; // 0x218
        public UnityEngine.InputSystem.Controls.ButtonControl _shareButton; // 0x220
        public UnityEngine.InputSystem.Controls.ButtonControl _l1; // 0x228
        public UnityEngine.InputSystem.Controls.ButtonControl _r1; // 0x230
        public UnityEngine.InputSystem.Controls.ButtonControl _l2; // 0x238
        public UnityEngine.InputSystem.Controls.ButtonControl _r2; // 0x240
        public UnityEngine.InputSystem.Controls.ButtonControl _l3; // 0x248
        public UnityEngine.InputSystem.Controls.ButtonControl _r3; // 0x250
        public UnityEngine.InputSystem.DualShock.DualShockGamepad _current;
        public HIDDeviceDescriptor _hidDescriptor; // 0x258

        // ── Methods ──
        public void get_touchpadButton(){} // RVA: 0x7FFE81B0A180
        public void set_touchpadButton(){} // RVA: 0x7FFE81B13850
        public void get_optionsButton(){} // RVA: 0x7FFE81B296E0
        public void set_optionsButton(){} // RVA: 0x7FFE81B38350
        public void get_shareButton(){} // RVA: 0x7FFE81B310E0
        public void set_shareButton(){} // RVA: 0x7FFE81B21BD0
        public void get_L1(){} // RVA: 0x7FFE81B0D790
        public void set_L1(){} // RVA: 0x7FFE81B34BA0
        public void get_R1(){} // RVA: 0x7FFE81B23A70
        public void set_R1(){} // RVA: 0x7FFE81B39ED0
        public void get_L2(){} // RVA: 0x7FFE81B20B50
        public void set_L2(){} // RVA: 0x7FFE81B2F9F0
        public void get_R2(){} // RVA: 0x7FFE81B26960
        public void set_R2(){} // RVA: 0x7FFE81B2E9D0
        public void get_L3(){} // RVA: 0x7FFE81B0DEC0
        public void set_L3(){} // RVA: 0x7FFE81B27CF0
        public void get_R3(){} // RVA: 0x7FFE81B12420
        public void set_R3(){} // RVA: 0x7FFE81B34B40
        public void get_current(){} // RVA: 0x7FFE87A17EF0
        public void set_current(){} // RVA: 0x7FFE87A17F30
        public void get_hidDescriptor(){} // RVA: 0x7FFE87A17FD0
        public void set_hidDescriptor(){} // RVA: 0x7FFE87A18000
        public void MakeCurrent(){} // RVA: 0x7FFE87A18080
        public void OnRemoved(){} // RVA: 0x7FFE87A180A0
        public void FinishSetup(){} // RVA: 0x7FFE87A18260
        public void SetLightBarColor(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class DualShockSupport : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE87A1A940
    }

    public class IDualShockHaptics
    {
        // ── Methods ──
        public void SetLightBarColor(){} // RVA: 0x7FFE80E460A0
    }

}