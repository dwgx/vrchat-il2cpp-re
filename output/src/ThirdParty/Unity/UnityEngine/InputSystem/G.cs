// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem
// Classes: 3
// Methods: 67

namespace ThirdParty.Unity.UnityEngine.InputSystem
{
    public class Gamepad : InputDevice
    {
        public object _buttonWest;
        public object _buttonNorth;
        public object _buttonSouth;
        public object _buttonEast;
        public object _leftStickButton;
        public object _rightStickButton;
        public object _startButton;
        public object _selectButton;
        public object _dpad;
        public object _leftShoulder;
        public object _rightShoulder;
        public object _leftStick;
        public object _rightStick;
        public object _leftTrigger;
        public object _rightTrigger;
        public object _current;
        public object m_Rumble;
        public object s_GamepadCount;
        public object s_Gamepads;

        // ── Methods ──
        public void get_buttonWest(){} // RVA: 0x13659D0
        public void set_buttonWest(){} // RVA: 0x166D270
        public void get_buttonNorth(){} // RVA: 0x135C160
        public void set_buttonNorth(){} // RVA: 0x16614A0
        public void get_buttonSouth(){} // RVA: 0x1664460
        public void set_buttonSouth(){} // RVA: 0x16679E0
        public void get_buttonEast(){} // RVA: 0x135A180
        public void set_buttonEast(){} // RVA: 0x164D690
        public void get_leftStickButton(){} // RVA: 0x165E8F0
        public void set_leftStickButton(){} // RVA: 0x165C4D0
        public void get_rightStickButton(){} // RVA: 0x1659CB0
        public void set_rightStickButton(){} // RVA: 0x163A980
        public void get_startButton(){} // RVA: 0x1344890
        public void set_startButton(){} // RVA: 0x1662780
        public void get_selectButton(){} // RVA: 0x1655DD0
        public void set_selectButton(){} // RVA: 0x16694D0
        public void get_dpad(){} // RVA: 0x1654670
        public void set_dpad(){} // RVA: 0x16612E0
        public void get_leftShoulder(){} // RVA: 0x165AD10
        public void set_leftShoulder(){} // RVA: 0x1667130
        public void get_rightShoulder(){} // RVA: 0x1184410
        public void set_rightShoulder(){} // RVA: 0x163ACA0
        public void get_leftStick(){} // RVA: 0x164FF50
        public void set_leftStick(){} // RVA: 0x16529A0
        public void get_rightStick(){} // RVA: 0x1659260
        public void set_rightStick(){} // RVA: 0x165DAA0
        public void get_leftTrigger(){} // RVA: 0x136ECA0
        public void set_leftTrigger(){} // RVA: 0x164C9D0
        public void get_rightTrigger(){} // RVA: 0x165F4F0
        public void set_rightTrigger(){} // RVA: 0x164A160
        public void get_aButton(){} // RVA: 0x1664460
        public void get_bButton(){} // RVA: 0x135A180
        public void get_xButton(){} // RVA: 0x13659D0
        public void get_yButton(){} // RVA: 0x135C160
        public void get_triangleButton(){} // RVA: 0x135C160
        public void get_squareButton(){} // RVA: 0x13659D0
        public void get_circleButton(){} // RVA: 0x135A180
        public void get_crossButton(){} // RVA: 0x1664460
        public void get_Item(){} // RVA: 0x7855140
        public void get_current(){} // RVA: 0x7855350
        public void set_current(){} // RVA: 0x7855390
        public void get_all(){} // RVA: 0x7855430
        public void FinishSetup(){} // RVA: 0x78554F0
        public void MakeCurrent(){} // RVA: 0x7855CF0
        public void OnAdded(){} // RVA: 0x7855D00
        public void OnRemoved(){} // RVA: 0x7855D80
        public void PauseHaptics(){} // RVA: 0x7855F10
        public void ResumeHaptics(){} // RVA: 0x7855F30
        public void ResetHaptics(){} // RVA: 0x7855FF0
        public void SetMotorSpeeds(){} // RVA: 0x78560A0
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class GravitySensor : Sensor
    {
        public object _gravity;
        public object _current;

        // ── Methods ──
        public void get_gravity(){} // RVA: 0x13659D0
        public void set_gravity(){} // RVA: 0x166D270
        public void get_current(){} // RVA: 0x78BAFB0
        public void set_current(){} // RVA: 0x78BAFF0
        public void FinishSetup(){} // RVA: 0x78BB090
        public void MakeCurrent(){} // RVA: 0x78BB140
        public void OnRemoved(){} // RVA: 0x78BB150
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class Gyroscope : Sensor
    {
        public object _angularVelocity;
        public object _current;

        // ── Methods ──
        public void get_angularVelocity(){} // RVA: 0x13659D0
        public void set_angularVelocity(){} // RVA: 0x166D270
        public void get_current(){} // RVA: 0x78BADC0
        public void set_current(){} // RVA: 0x78BAE00
        public void MakeCurrent(){} // RVA: 0x78BAEA0
        public void OnRemoved(){} // RVA: 0x78BAEB0
        public void FinishSetup(){} // RVA: 0x78BAF00
        public void .ctor(){} // RVA: 0x77D4F00
    }

}