// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Controls
// Classes: 16
// Methods: 145

namespace ThirdParty.Unity.UnityEngine.InputSystem.Controls
{
    public class AnyKeyControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF98724A0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAF9872510
    }

    public class AxisControl
    {
        // ── Methods ──
        public void Preprocess(){} // RVA: 0x7FFAF9872630
        public void Unpreprocess(){} // RVA: 0x7FFAF9872720
        public void .ctor(){} // RVA: 0x7FFAF98727B0
        public void FinishSetup(){} // RVA: 0x7FFAF9872870
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAF9872960
        public void WriteValueIntoState(){} // RVA: 0x7FFAF9872A30
        public void CompareValue(){} // RVA: 0x7FFAF9872B90
        public void EvaluateMagnitude(){} // RVA: 0x7FFAF9872E00 | overloaded x2
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFAF9872EE0
    }

    public class ButtonControl
    {
        // ── Methods ──
        public void get_needsToCheckFramePress(){} // RVA: 0x7FFAF8F1FC70
        public void set_needsToCheckFramePress(){} // RVA: 0x7FFAF9873080
        public void get_pressPointOrDefault(){} // RVA: 0x7FFAF9873090
        public void .ctor(){} // RVA: 0x7FFAF98730F0
        public void IsValueConsideredPressed(){} // RVA: 0x7FFAF98731E0
        public void get_isPressed(){} // RVA: 0x7FFAF9873260
        public void BeginTestingForFramePresses(){} // RVA: 0x7FFAF98732C0
        public void get_wasPressedThisFrame(){} // RVA: 0x7FFAF98733D0
        public void get_wasReleasedThisFrame(){} // RVA: 0x7FFAF9873500
        public void UpdateWasPressed(){} // RVA: 0x7FFAF9873630
    }

    public class DeltaControl
    {
        // ── Methods ──
        public void get_up(){} // RVA: 0x7FFAF304E660
        public void set_up(){} // RVA: 0x7FFAF304F420
        public void get_down(){} // RVA: 0x7FFAF353EE80
        public void set_down(){} // RVA: 0x7FFAF37C82E0
        public void get_left(){} // RVA: 0x7FFAF353E870
        public void set_left(){} // RVA: 0x7FFAF3853F70
        public void get_right(){} // RVA: 0x7FFAF35433D0
        public void set_right(){} // RVA: 0x7FFAF3546DC0
        public void FinishSetup(){} // RVA: 0x7FFAF98736D0
        public void .ctor(){} // RVA: 0x7FFAF9873920
    }

    public class DiscreteButtonControl
    {
        // ── Methods ──
        public void FinishSetup(){} // RVA: 0x7FFAF9873930
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAF9873A50
        public void WriteValueIntoState(){} // RVA: 0x7FFAF9873B30
        public void .ctor(){} // RVA: 0x7FFAF9873C90
    }

    public class DoubleControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9873CA0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAF9873D60
        public void WriteValueIntoState(){} // RVA: 0x7FFAF9873DC0
    }

    public class DpadControl
    {
        // ── Methods ──
        public void get_up(){} // RVA: 0x7FFAF304E660
        public void set_up(){} // RVA: 0x7FFAF304F420
        public void get_down(){} // RVA: 0x7FFAF353EE80
        public void set_down(){} // RVA: 0x7FFAF37C82E0
        public void get_left(){} // RVA: 0x7FFAF353E870
        public void set_left(){} // RVA: 0x7FFAF3853F70
        public void get_right(){} // RVA: 0x7FFAF35433D0
        public void set_right(){} // RVA: 0x7FFAF3546DC0
        public void .ctor(){} // RVA: 0x7FFAF9873E30
        public void FinishSetup(){} // RVA: 0x7FFAF9873EA0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAF98740F0
        public void WriteValueIntoState(){} // RVA: 0x7FFAF98743C0
        public void MakeDpadVector(){} // RVA: 0x7FFAF9874610 | overloaded x2
    }

    public class IntegerControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9874860
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAF9874920
        public void WriteValueIntoState(){} // RVA: 0x7FFAF98749C0
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFAF9874A60
    }

    public class KeyControl
    {
        // ── Methods ──
        public void get_keyCode(){} // RVA: 0x7FFAF40AA5E0
        public void set_keyCode(){} // RVA: 0x7FFAF408F3A0
        public void get_scanCode(){} // RVA: 0x7FFAF9874B50
        public void RefreshConfiguration(){} // RVA: 0x7FFAF9874BA0
        public void .ctor(){} // RVA: 0x7FFAF9873C90
    }

    public class QuaternionControl
    {
        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFAF304E660
        public void set_x(){} // RVA: 0x7FFAF304F420
        public void get_y(){} // RVA: 0x7FFAF353EE80
        public void set_y(){} // RVA: 0x7FFAF37C82E0
        public void get_z(){} // RVA: 0x7FFAF353E870
        public void set_z(){} // RVA: 0x7FFAF3853F70
        public void get_w(){} // RVA: 0x7FFAF35433D0
        public void set_w(){} // RVA: 0x7FFAF3546DC0
        public void .ctor(){} // RVA: 0x7FFAF9874E10
        public void FinishSetup(){} // RVA: 0x7FFAF9874ED0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAF9875140
        public void WriteValueIntoState(){} // RVA: 0x7FFAF98752A0
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFAF98753E0
    }

    public class StickControl
    {
        // ── Methods ──
        public void get_up(){} // RVA: 0x7FFAF304E660
        public void set_up(){} // RVA: 0x7FFAF304F420
        public void get_down(){} // RVA: 0x7FFAF353EE80
        public void set_down(){} // RVA: 0x7FFAF37C82E0
        public void get_left(){} // RVA: 0x7FFAF353E870
        public void set_left(){} // RVA: 0x7FFAF3853F70
        public void get_right(){} // RVA: 0x7FFAF35433D0
        public void set_right(){} // RVA: 0x7FFAF3546DC0
        public void FinishSetup(){} // RVA: 0x7FFAF98756A0
        public void .ctor(){} // RVA: 0x7FFAF9873920
    }

    public class TouchControl
    {
        // ── Methods ──
        public void get_press(){} // RVA: 0x7FFAF32E0040
        public void set_press(){} // RVA: 0x7FFAF383E320
        public void get_displayIndex(){} // RVA: 0x7FFAF32DF060
        public void set_displayIndex(){} // RVA: 0x7FFAF38370D0
        public void get_touchId(){} // RVA: 0x7FFAF3855BB0
        public void set_touchId(){} // RVA: 0x7FFAF3837C10
        public void get_position(){} // RVA: 0x7FFAF3833B50
        public void set_position(){} // RVA: 0x7FFAF384F550
        public void get_delta(){} // RVA: 0x7FFAF3540180
        public void set_delta(){} // RVA: 0x7FFAF3846D90
        public void get_pressure(){} // RVA: 0x7FFAF35474D0
        public void set_pressure(){} // RVA: 0x7FFAF384C360
        public void get_radius(){} // RVA: 0x7FFAF3861150
        public void set_radius(){} // RVA: 0x7FFAF3845560
        public void get_phase(){} // RVA: 0x7FFAF3544F10
        public void set_phase(){} // RVA: 0x7FFAF38525E0
        public void get_indirectTouch(){} // RVA: 0x7FFAF3855040
        public void set_indirectTouch(){} // RVA: 0x7FFAF383AAB0
        public void get_tap(){} // RVA: 0x7FFAF3862150
        public void set_tap(){} // RVA: 0x7FFAF3844B20
        public void get_tapCount(){} // RVA: 0x7FFAF3507F60
        public void set_tapCount(){} // RVA: 0x7FFAF3844790
        public void get_startTime(){} // RVA: 0x7FFAF38562D0
        public void set_startTime(){} // RVA: 0x7FFAF3844E00
        public void get_startPosition(){} // RVA: 0x7FFAF3863D70
        public void set_startPosition(){} // RVA: 0x7FFAF3836540
        public void get_isInProgress(){} // RVA: 0x7FFAF98758F0
        public void .ctor(){} // RVA: 0x7FFAF9875960
        public void FinishSetup(){} // RVA: 0x7FFAF9875A10
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAF9876180
        public void WriteValueIntoState(){} // RVA: 0x7FFAF9876210
    }

    public class TouchPhaseControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF98762A0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAF9876360
        public void WriteValueIntoState(){} // RVA: 0x7FFAF98763D0
    }

    public class TouchPressControl
    {
        // ── Methods ──
        public void FinishSetup(){} // RVA: 0x7FFAF9876440
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAF9876560
        public void WriteValueIntoState(){} // RVA: 0x7FFAF98765F0
        public void .ctor(){} // RVA: 0x7FFAF9873C90
    }

    public class Vector2Control
    {
        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFAF2FB7710
        public void set_x(){} // RVA: 0x7FFAF2FB9930
        public void get_y(){} // RVA: 0x7FFAF2FB7D10
        public void set_y(){} // RVA: 0x7FFAF2FBA8C0
        public void .ctor(){} // RVA: 0x7FFAF9876630
        public void FinishSetup(){} // RVA: 0x7FFAF98766F0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAF9876860
        public void WriteValueIntoState(){} // RVA: 0x7FFAF9876940
        public void EvaluateMagnitude(){} // RVA: 0x7FFAF9876A30
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFAF9876BA0
    }

    public class Vector3Control
    {
        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFAF2FB7D10
        public void set_x(){} // RVA: 0x7FFAF2FBA8C0
        public void get_y(){} // RVA: 0x7FFAF304E660
        public void set_y(){} // RVA: 0x7FFAF304F420
        public void get_z(){} // RVA: 0x7FFAF353EE80
        public void set_z(){} // RVA: 0x7FFAF37C82E0
        public void .ctor(){} // RVA: 0x7FFAF9876D20
        public void FinishSetup(){} // RVA: 0x7FFAF9876DE0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAF9876FD0
        public void WriteValueIntoState(){} // RVA: 0x7FFAF98770F0
        public void EvaluateMagnitude(){} // RVA: 0x7FFAF9877210
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFAF9877390
    }

}