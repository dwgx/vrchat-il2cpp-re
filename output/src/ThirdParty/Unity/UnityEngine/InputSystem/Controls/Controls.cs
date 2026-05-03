// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Controls
// Classes: 16
// Methods: 145

namespace ThirdParty.Unity.UnityEngine.InputSystem.Controls
{
    public class AnyKeyControl : ButtonControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87903340
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE879033B0
    }

    public class AxisControl : InputControl`1
    {
        // ── Methods ──
        public void Preprocess(){} // RVA: 0x7FFE879034D0
        public void Unpreprocess(){} // RVA: 0x7FFE879035C0
        public void .ctor(){} // RVA: 0x7FFE87903650
        public void FinishSetup(){} // RVA: 0x7FFE87903710
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE87903800
        public void WriteValueIntoState(){} // RVA: 0x7FFE879038D0
        public void CompareValue(){} // RVA: 0x7FFE87903A30
        public void EvaluateMagnitude(){} // RVA: 0x7FFE87903CA0 | overloaded x2
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFE87903D80
    }

    public class ButtonControl : AxisControl
    {
        public bool m_NeedsToCheckFramePress; // 0x130
        public uint m_UpdateCountLastPressed; // 0x134
        public uint m_UpdateCountLastReleased; // 0x138
        public bool m_LastUpdateWasPress; // 0x13C
        public bool _needsToCheckFramePress; // 0x13D

        // ── Methods ──
        public void get_needsToCheckFramePress(){} // RVA: 0x7FFE86FAECF0
        public void set_needsToCheckFramePress(){} // RVA: 0x7FFE87903F20
        public void get_pressPointOrDefault(){} // RVA: 0x7FFE87903F30
        public void .ctor(){} // RVA: 0x7FFE87903F90
        public void IsValueConsideredPressed(){} // RVA: 0x7FFE87904080
        public void get_isPressed(){} // RVA: 0x7FFE87904100
        public void BeginTestingForFramePresses(){} // RVA: 0x7FFE87904160
        public void get_wasPressedThisFrame(){} // RVA: 0x7FFE87904270
        public void get_wasReleasedThisFrame(){} // RVA: 0x7FFE879043A0
        public void UpdateWasPressed(){} // RVA: 0x7FFE879044D0
    }

    public class DeltaControl : Vector2Control
    {
        public UnityEngine.InputSystem.Controls.AxisControl _up; // 0x120
        public UnityEngine.InputSystem.Controls.AxisControl _down; // 0x128
        public UnityEngine.InputSystem.Controls.AxisControl _left; // 0x130
        public UnityEngine.InputSystem.Controls.AxisControl _right; // 0x138

        // ── Methods ──
        public void get_up(){} // RVA: 0x7FFE813A1DA0
        public void set_up(){} // RVA: 0x7FFE813A0830
        public void get_down(){} // RVA: 0x7FFE8182B890
        public void set_down(){} // RVA: 0x7FFE81B31E10
        public void get_left(){} // RVA: 0x7FFE81823850
        public void set_left(){} // RVA: 0x7FFE81B31120
        public void get_right(){} // RVA: 0x7FFE8181EA70
        public void set_right(){} // RVA: 0x7FFE818254E0
        public void FinishSetup(){} // RVA: 0x7FFE87904570
        public void .ctor(){} // RVA: 0x7FFE879047C0
    }

    public class DiscreteButtonControl : ButtonControl
    {
        // ── Methods ──
        public void FinishSetup(){} // RVA: 0x7FFE879047D0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE879048F0
        public void WriteValueIntoState(){} // RVA: 0x7FFE879049D0
        public void .ctor(){} // RVA: 0x7FFE87904B30
    }

    public class DoubleControl : InputControl`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87904B40
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE87904C00
        public void WriteValueIntoState(){} // RVA: 0x7FFE87904C60
    }

    public class DpadControl : Vector2Control
    {
        public UnityEngine.InputSystem.Controls.ButtonControl _up; // 0x120
        public UnityEngine.InputSystem.Controls.ButtonControl _down; // 0x128
        public UnityEngine.InputSystem.Controls.ButtonControl _left; // 0x130
        public UnityEngine.InputSystem.Controls.ButtonControl _right; // 0x138

        // ── Methods ──
        public void get_up(){} // RVA: 0x7FFE813A1DA0
        public void set_up(){} // RVA: 0x7FFE813A0830
        public void get_down(){} // RVA: 0x7FFE8182B890
        public void set_down(){} // RVA: 0x7FFE81B31E10
        public void get_left(){} // RVA: 0x7FFE81823850
        public void set_left(){} // RVA: 0x7FFE81B31120
        public void get_right(){} // RVA: 0x7FFE8181EA70
        public void set_right(){} // RVA: 0x7FFE818254E0
        public void .ctor(){} // RVA: 0x7FFE87904CD0
        public void FinishSetup(){} // RVA: 0x7FFE87904D40
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE87904F90
        public void WriteValueIntoState(){} // RVA: 0x7FFE87905260
        public void MakeDpadVector(){} // RVA: 0x7FFE879054B0 | overloaded x2
    }

    public class IntegerControl : InputControl`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87905700
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE879057C0
        public void WriteValueIntoState(){} // RVA: 0x7FFE87905860
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFE87905900
    }

    public class KeyControl : ButtonControl
    {
        public ÌÌÍÌÍÎ _keyCode; // 0x148
        public int m_ScanCode; // 0x14C

        // ── Methods ──
        public void get_keyCode(){} // RVA: 0x7FFE823676C0
        public void set_keyCode(){} // RVA: 0x7FFE8234C440
        public void get_scanCode(){} // RVA: 0x7FFE879059F0
        public void RefreshConfiguration(){} // RVA: 0x7FFE87905A40
        public void .ctor(){} // RVA: 0x7FFE87904B30
    }

    public class QuaternionControl : InputControl`1
    {
        public UnityEngine.InputSystem.Controls.AxisControl _x; // 0x120
        public UnityEngine.InputSystem.Controls.AxisControl _y; // 0x128
        public UnityEngine.InputSystem.Controls.AxisControl _z; // 0x130
        public UnityEngine.InputSystem.Controls.AxisControl _w; // 0x138

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFE813A1DA0
        public void set_x(){} // RVA: 0x7FFE813A0830
        public void get_y(){} // RVA: 0x7FFE8182B890
        public void set_y(){} // RVA: 0x7FFE81B31E10
        public void get_z(){} // RVA: 0x7FFE81823850
        public void set_z(){} // RVA: 0x7FFE81B31120
        public void get_w(){} // RVA: 0x7FFE8181EA70
        public void set_w(){} // RVA: 0x7FFE818254E0
        public void .ctor(){} // RVA: 0x7FFE87905CB0
        public void FinishSetup(){} // RVA: 0x7FFE87905D70
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE87905FE0
        public void WriteValueIntoState(){} // RVA: 0x7FFE87906140
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFE87906280
    }

    public class StickControl : Vector2Control
    {
        public UnityEngine.InputSystem.Controls.ButtonControl _up; // 0x120
        public UnityEngine.InputSystem.Controls.ButtonControl _down; // 0x128
        public UnityEngine.InputSystem.Controls.ButtonControl _left; // 0x130
        public UnityEngine.InputSystem.Controls.ButtonControl _right; // 0x138

        // ── Methods ──
        public void get_up(){} // RVA: 0x7FFE813A1DA0
        public void set_up(){} // RVA: 0x7FFE813A0830
        public void get_down(){} // RVA: 0x7FFE8182B890
        public void set_down(){} // RVA: 0x7FFE81B31E10
        public void get_left(){} // RVA: 0x7FFE81823850
        public void set_left(){} // RVA: 0x7FFE81B31120
        public void get_right(){} // RVA: 0x7FFE8181EA70
        public void set_right(){} // RVA: 0x7FFE818254E0
        public void FinishSetup(){} // RVA: 0x7FFE87906540
        public void .ctor(){} // RVA: 0x7FFE879047C0
    }

    public class TouchControl : InputControl`1
    {
        public UnityEngine.InputSystem.Controls.TouchPressControl _press; // 0x170
        public UnityEngine.InputSystem.Controls.IntegerControl _displayIndex; // 0x178
        public UnityEngine.InputSystem.Controls.IntegerControl _touchId; // 0x180
        public UnityEngine.InputSystem.Controls.Vector2Control _position; // 0x188
        public UnityEngine.InputSystem.Controls.DeltaControl _delta; // 0x190
        public UnityEngine.InputSystem.Controls.AxisControl _pressure; // 0x198
        public UnityEngine.InputSystem.Controls.Vector2Control _radius; // 0x1A0
        public UnityEngine.InputSystem.Controls.TouchPhaseControl _phase; // 0x1A8
        public UnityEngine.InputSystem.Controls.ButtonControl _indirectTouch; // 0x1B0
        public UnityEngine.InputSystem.Controls.ButtonControl _tap; // 0x1B8
        public UnityEngine.InputSystem.Controls.IntegerControl _tapCount; // 0x1C0
        public UnityEngine.InputSystem.Controls.DoubleControl _startTime; // 0x1C8
        public UnityEngine.InputSystem.Controls.Vector2Control _startPosition; // 0x1D0
        public object field_13; // 0x5BE

        // ── Methods ──
        public void get_press(){} // RVA: 0x7FFE815BB6A0
        public void set_press(){} // RVA: 0x7FFE81B38790
        public void get_displayIndex(){} // RVA: 0x7FFE815BB1F0
        public void set_displayIndex(){} // RVA: 0x7FFE81B10700
        public void get_touchId(){} // RVA: 0x7FFE81B38340
        public void set_touchId(){} // RVA: 0x7FFE81B31180
        public void get_position(){} // RVA: 0x7FFE81B295E0
        public void set_position(){} // RVA: 0x7FFE81B2E3B0
        public void get_delta(){} // RVA: 0x7FFE81825EC0
        public void set_delta(){} // RVA: 0x7FFE81B2A360
        public void get_pressure(){} // RVA: 0x7FFE8181EA60
        public void set_pressure(){} // RVA: 0x7FFE81B33630
        public void get_radius(){} // RVA: 0x7FFE81B32390
        public void set_radius(){} // RVA: 0x7FFE81B21CA0
        public void get_phase(){} // RVA: 0x7FFE8182AF50
        public void set_phase(){} // RVA: 0x7FFE81B08F90
        public void get_indirectTouch(){} // RVA: 0x7FFE81B23A60
        public void set_indirectTouch(){} // RVA: 0x7FFE81B2ACE0
        public void get_tap(){} // RVA: 0x7FFE81B164E0
        public void set_tap(){} // RVA: 0x7FFE81B38D70
        public void get_tapCount(){} // RVA: 0x7FFE817EFE00
        public void set_tapCount(){} // RVA: 0x7FFE81B0C930
        public void get_startTime(){} // RVA: 0x7FFE81B16E90
        public void set_startTime(){} // RVA: 0x7FFE81B290E0
        public void get_startPosition(){} // RVA: 0x7FFE81B32320
        public void set_startPosition(){} // RVA: 0x7FFE81B31B60
        public void get_isInProgress(){} // RVA: 0x7FFE87906790
        public void .ctor(){} // RVA: 0x7FFE87906800
        public void FinishSetup(){} // RVA: 0x7FFE879068B0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE87907020
        public void WriteValueIntoState(){} // RVA: 0x7FFE879070B0
    }

    public class TouchPhaseControl : InputControl`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87907140
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE87907200
        public void WriteValueIntoState(){} // RVA: 0x7FFE87907270
    }

    public class TouchPressControl : ButtonControl
    {
        // ── Methods ──
        public void FinishSetup(){} // RVA: 0x7FFE879072E0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE87907400
        public void WriteValueIntoState(){} // RVA: 0x7FFE87907490
        public void .ctor(){} // RVA: 0x7FFE87904B30
    }

    public class Vector2Control : InputControl`1
    {
        public UnityEngine.InputSystem.Controls.AxisControl _x; // 0x110
        public UnityEngine.InputSystem.Controls.AxisControl _y; // 0x118

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFE81317980
        public void set_x(){} // RVA: 0x7FFE813159A0
        public void get_y(){} // RVA: 0x7FFE81318010
        public void set_y(){} // RVA: 0x7FFE81317920
        public void .ctor(){} // RVA: 0x7FFE879074D0
        public void FinishSetup(){} // RVA: 0x7FFE87907590
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE87907700
        public void WriteValueIntoState(){} // RVA: 0x7FFE879077E0
        public void EvaluateMagnitude(){} // RVA: 0x7FFE879078D0
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFE87907A40
    }

    public class Vector3Control : InputControl`1
    {
        public UnityEngine.InputSystem.Controls.AxisControl _x; // 0x118
        public UnityEngine.InputSystem.Controls.AxisControl _y; // 0x120
        public UnityEngine.InputSystem.Controls.AxisControl _z; // 0x128

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFE81318010
        public void set_x(){} // RVA: 0x7FFE81317920
        public void get_y(){} // RVA: 0x7FFE813A1DA0
        public void set_y(){} // RVA: 0x7FFE813A0830
        public void get_z(){} // RVA: 0x7FFE8182B890
        public void set_z(){} // RVA: 0x7FFE81B31E10
        public void .ctor(){} // RVA: 0x7FFE87907BC0
        public void FinishSetup(){} // RVA: 0x7FFE87907C80
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE87907E70
        public void WriteValueIntoState(){} // RVA: 0x7FFE87907F90
        public void EvaluateMagnitude(){} // RVA: 0x7FFE879080B0
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFE87908230
    }

}