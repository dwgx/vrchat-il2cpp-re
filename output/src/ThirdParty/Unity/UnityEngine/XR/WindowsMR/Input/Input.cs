// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.XR.WindowsMR.Input
// Classes: 3
// Methods: 50

namespace ThirdParty.Unity.UnityEngine.XR.WindowsMR.Input
{
    public class HololensHand
    {
        public UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField; // 0x1B0
        public UnityEngine.InputSystem.Controls.ButtonControl <airTap>k__BackingField; // 0x1B8
        public UnityEngine.InputSystem.Controls.AxisControl <sourceLossRisk>k__BackingField; // 0x1C0
        public UnityEngine.InputSystem.Controls.Vector3Control <sourceLossMitigationDirection>k__BackingField; // 0x1C8

        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0xDA5040
        public void set_deviceVelocity(){} // RVA: 0xD8AAB0
        public void get_airTap(){} // RVA: 0xDB2150
        public void set_airTap(){} // RVA: 0xD94B20
        public void get_sourceLossRisk(){} // RVA: 0xA57F60
        public void set_sourceLossRisk(){} // RVA: 0xD94790
        public void get_sourceLossMitigationDirection(){} // RVA: 0xDA62D0
        public void set_sourceLossMitigationDirection(){} // RVA: 0xD94E00
        public void FinishSetup(){} // RVA: 0x6D81480
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class WMRHMD
    {
        public UnityEngine.InputSystem.Controls.ButtonControl <userPresence>k__BackingField; // 0x1E0

        // ── Methods ──
        public void get_userPresence(){} // RVA: 0x8CBA20
        public void set_userPresence(){} // RVA: 0xDB44F0
        public void FinishSetup(){} // RVA: 0x6D813C0
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class WMRSpatialController
    {
        public UnityEngine.InputSystem.Controls.Vector2Control <joystick>k__BackingField; // 0x1B0
        public UnityEngine.InputSystem.Controls.Vector2Control <touchpad>k__BackingField; // 0x1B8
        public UnityEngine.InputSystem.Controls.AxisControl <grip>k__BackingField; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl <gripPressed>k__BackingField; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl <menu>k__BackingField; // 0x1D0
        public UnityEngine.InputSystem.Controls.AxisControl <trigger>k__BackingField; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField; // 0x1E0
        public UnityEngine.InputSystem.Controls.ButtonControl <joystickClicked>k__BackingField; // 0x1E8
        public UnityEngine.InputSystem.Controls.ButtonControl <touchpadClicked>k__BackingField; // 0x1F0
        public UnityEngine.InputSystem.Controls.ButtonControl <touchpadTouched>k__BackingField; // 0x1F8
        public UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField; // 0x200
        public UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField; // 0x208
        public UnityEngine.InputSystem.Controls.AxisControl <batteryLevel>k__BackingField; // 0x210
        public UnityEngine.InputSystem.Controls.AxisControl <sourceLossRisk>k__BackingField; // 0x218
        public UnityEngine.InputSystem.Controls.Vector3Control <sourceLossMitigationDirection>k__BackingField; // 0x220
        public UnityEngine.InputSystem.Controls.Vector3Control <pointerPosition>k__BackingField; // 0x228
        public UnityEngine.InputSystem.Controls.QuaternionControl <pointerRotation>k__BackingField; // 0x230

        // ── Methods ──
        public void get_joystick(){} // RVA: 0xDA5040
        public void set_joystick(){} // RVA: 0xD8AAB0
        public void get_touchpad(){} // RVA: 0xDB2150
        public void set_touchpad(){} // RVA: 0xD94B20
        public void get_grip(){} // RVA: 0xA57F60
        public void set_grip(){} // RVA: 0xD94790
        public void get_gripPressed(){} // RVA: 0xDA62D0
        public void set_gripPressed(){} // RVA: 0xD94E00
        public void get_menu(){} // RVA: 0xDB3D70
        public void set_menu(){} // RVA: 0xD86540
        public void get_trigger(){} // RVA: 0xD9ABC0
        public void set_trigger(){} // RVA: 0xD9A380
        public void get_triggerPressed(){} // RVA: 0x8CBA20
        public void set_triggerPressed(){} // RVA: 0xDB44F0
        public void get_joystickClicked(){} // RVA: 0xDB4D60
        public void set_joystickClicked(){} // RVA: 0xD85A20
        public void get_touchpadClicked(){} // RVA: 0xD92860
        public void set_touchpadClicked(){} // RVA: 0xD87940
        public void get_touchpadTouched(){} // RVA: 0xD8D540
        public void set_touchpadTouched(){} // RVA: 0xD9D6A0
        public void get_deviceVelocity(){} // RVA: 0xD9E9A0
        public void set_deviceVelocity(){} // RVA: 0xD9F490
        public void get_deviceAngularVelocity(){} // RVA: 0xD971B0
        public void set_deviceAngularVelocity(){} // RVA: 0xD85210
        public void get_batteryLevel(){} // RVA: 0xD9F7C0
        public void set_batteryLevel(){} // RVA: 0xD9BA80
        public void get_sourceLossRisk(){} // RVA: 0xD88BD0
        public void set_sourceLossRisk(){} // RVA: 0xD9AC30
        public void get_sourceLossMitigationDirection(){} // RVA: 0xD915D0
        public void set_sourceLossMitigationDirection(){} // RVA: 0xD93180
        public void get_pointerPosition(){} // RVA: 0xD90650
        public void set_pointerPosition(){} // RVA: 0xD9F060
        public void get_pointerRotation(){} // RVA: 0xDA0BC0
        public void set_pointerRotation(){} // RVA: 0xD8A490
        public void FinishSetup(){} // RVA: 0x6D81700
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

}