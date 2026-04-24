// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Controls
// Classes: 16
// Methods: 145

namespace ThirdParty.Unity.UnityEngine.InputSystem.Controls
{
    public class AnyKeyControl : ButtonControl
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaef7cbd0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaaef7cc40
    }

    public class AxisControl : InputControl`1
    {
        public object clampMax; // 0x334A42A0
        public object normalize; // 0x334A42A0
        public object normalizeZero; // 0x334A42A0

        // ── Original Methods ──
        public void Preprocess(){} // RVA: 0x7ffaaef7cd60
        public void Unpreprocess(){} // RVA: 0x7ffaaef7ce50
        public void .ctor(){} // RVA: 0x7ffaaef7cee0
        public void FinishSetup(){} // RVA: 0x7ffaaef7cfa0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaaef7d090
        public void WriteValueIntoState(){} // RVA: 0x7ffaaef7d160
        public void CompareValue(){} // RVA: 0x7ffaaef7d2c0
        public void EvaluateMagnitude(){} // RVA: 0x7ffaaef7d530
        public void EvaluateMagnitude(){} // RVA: 0x7ffaaef7d530
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7ffaaef7d610
    }

    public class ButtonControl : AxisControl
    {
        public object m_UpdateCountLastReleased; // 0x334A4030
        public object pressPoint; // 0x334A4030
        public object kMinButtonPressPoint; // 0x334A4030
        public object needsToCheckFramePress; // 0x170005A6
        public object pressPointOrDefault; // 0x170005A7
        public object isPressed; // 0x170005A8

        // ── Original Methods ──
        public void get_needsToCheckFramePress(){} // RVA: 0x7ffaae628960
        public void set_needsToCheckFramePress(){} // RVA: 0x7ffaaef7d7b0
        public void get_pressPointOrDefault(){} // RVA: 0x7ffaaef7d7c0
        public void .ctor(){} // RVA: 0x7ffaaef7d820
        public void IsValueConsideredPressed(){} // RVA: 0x7ffaaef7d910
        public void get_isPressed(){} // RVA: 0x7ffaaef7d990
        public void get_wasPressedThisFrame(){} // RVA: 0x7ffaaef7db00
        public void get_wasReleasedThisFrame(){} // RVA: 0x7ffaaef7dc30
        public void UpdateWasPressed(){} // RVA: 0x7ffaaef7dd60
        // ── Binary Analysis Named ──
        public void BeginTestingForFramePresses(){} // RVA: 0x7ffaaef7d9f0
    }

    public class DeltaControl : Vector2Control
    {
        public object _left; // 0x335D96C0, was: <left>k__BackingField

        // ── Original Methods ──
        public void get_up(){} // RVA: 0x7ffaa8b68c40
        public void set_up(){} // RVA: 0x7ffaa8b6fd10
        public void get_down(){} // RVA: 0x7ffaa8f78450
        public void set_down(){} // RVA: 0x7ffaa93ff110
        public void get_left(){} // RVA: 0x7ffaa8f7aa40
        public void set_left(){} // RVA: 0x7ffaa93f4640
        public void get_right(){} // RVA: 0x7ffaa8f76810
        public void set_right(){} // RVA: 0x7ffaa9101830
        public void FinishSetup(){} // RVA: 0x7ffaaef7de00
        public void .ctor(){} // RVA: 0x7ffaaef7e050
    }

    public class DiscreteButtonControl : ButtonControl
    {
        public object wrapAtValue; // 0x3348FB70

        // ── Original Methods ──
        public void FinishSetup(){} // RVA: 0x7ffaaef7e060
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaaef7e180
        public void WriteValueIntoState(){} // RVA: 0x7ffaaef7e260
        public void .ctor(){} // RVA: 0x7ffaaef7e3c0
    }

    public class DoubleControl : InputControl`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaef7e3d0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaaef7e490
        public void WriteValueIntoState(){} // RVA: 0x7ffaaef7e4f0
    }

    public class DpadControl : Vector2Control
    {
        public object _left; // 0x33A37170, was: <left>k__BackingField

        // ── Original Methods ──
        public void get_up(){} // RVA: 0x7ffaa8b68c40
        public void set_up(){} // RVA: 0x7ffaa8b6fd10
        public void get_down(){} // RVA: 0x7ffaa8f78450
        public void set_down(){} // RVA: 0x7ffaa93ff110
        public void get_left(){} // RVA: 0x7ffaa8f7aa40
        public void set_left(){} // RVA: 0x7ffaa93f4640
        public void get_right(){} // RVA: 0x7ffaa8f76810
        public void set_right(){} // RVA: 0x7ffaa9101830
        public void .ctor(){} // RVA: 0x7ffaaef7e560
        public void FinishSetup(){} // RVA: 0x7ffaaef7e5d0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaaef7e820
        public void WriteValueIntoState(){} // RVA: 0x7ffaaef7eaf0
        public void MakeDpadVector(){} // RVA: 0x7ffaaef7ed40
        public void MakeDpadVector(){} // RVA: 0x7ffaaef7ed40
    }

    public class IntegerControl : InputControl`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaef7ef90
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaaef7f050
        public void WriteValueIntoState(){} // RVA: 0x7ffaaef7f0f0
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7ffaaef7f190
    }

    public class KeyControl : ButtonControl
    {
        // ── Original Methods ──
        public void get_keyCode(){} // RVA: 0x7ffaa9ad6700
        public void set_keyCode(){} // RVA: 0x7ffaa9abb370
        public void get_scanCode(){} // RVA: 0x7ffaaef7f280
        public void RefreshConfiguration(){} // RVA: 0x7ffaaef7f2d0
        public void .ctor(){} // RVA: 0x7ffaaef7e3c0
    }

    public class QuaternionControl : InputControl`1
    {
        public object _z; // 0x3363A410, was: <z>k__BackingField

        // ── Original Methods ──
        public void get_x(){} // RVA: 0x7ffaa8b68c40
        public void set_x(){} // RVA: 0x7ffaa8b6fd10
        public void get_y(){} // RVA: 0x7ffaa8f78450
        public void set_y(){} // RVA: 0x7ffaa93ff110
        public void get_z(){} // RVA: 0x7ffaa8f7aa40
        public void set_z(){} // RVA: 0x7ffaa93f4640
        public void get_w(){} // RVA: 0x7ffaa8f76810
        public void set_w(){} // RVA: 0x7ffaa9101830
        public void .ctor(){} // RVA: 0x7ffaaef7f540
        public void FinishSetup(){} // RVA: 0x7ffaaef7f600
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaaef7f870
        public void WriteValueIntoState(){} // RVA: 0x7ffaaef7f9d0
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7ffaaef7fb10
    }

    public class StickControl : Vector2Control
    {
        public object _left; // 0x338D5400, was: <left>k__BackingField

        // ── Original Methods ──
        public void get_up(){} // RVA: 0x7ffaa8b68c40
        public void set_up(){} // RVA: 0x7ffaa8b6fd10
        public void get_down(){} // RVA: 0x7ffaa8f78450
        public void set_down(){} // RVA: 0x7ffaa93ff110
        public void get_left(){} // RVA: 0x7ffaa8f7aa40
        public void set_left(){} // RVA: 0x7ffaa93f4640
        public void get_right(){} // RVA: 0x7ffaa8f76810
        public void set_right(){} // RVA: 0x7ffaa9101830
        public void FinishSetup(){} // RVA: 0x7ffaaef7fdd0
        public void .ctor(){} // RVA: 0x7ffaaef7e050
    }

    public class TouchControl : InputControl`1
    {
        public object _touchId; // 0x33875F60, was: <touchId>k__BackingField
        public object _pressure; // 0x33875F60, was: <pressure>k__BackingField
        public object _indirectTouch; // 0x33875F60, was: <indirectTouch>k__BackingField
        public object _startTime; // 0x33875F60, was: <startTime>k__BackingField

        // ── Original Methods ──
        public void get_press(){} // RVA: 0x7ffaa8d916d0
        public void set_press(){} // RVA: 0x7ffaa93f45e0
        public void get_displayIndex(){} // RVA: 0x7ffaa8d92160
        public void set_displayIndex(){} // RVA: 0x7ffaa93d3040
        public void get_touchId(){} // RVA: 0x7ffaa8f74160
        public void set_touchId(){} // RVA: 0x7ffaa8f2e920
        public void get_position(){} // RVA: 0x7ffaa8f6f0b0
        public void set_position(){} // RVA: 0x7ffaa8f2e8c0
        public void get_delta(){} // RVA: 0x7ffaa8f77bc0
        public void set_delta(){} // RVA: 0x7ffaa93f5420
        public void get_pressure(){} // RVA: 0x7ffaa8f75d50
        public void set_pressure(){} // RVA: 0x7ffaa94036f0
        public void get_radius(){} // RVA: 0x7ffaa8f74750
        public void set_radius(){} // RVA: 0x7ffaa93e77a0
        public void get_phase(){} // RVA: 0x7ffaa8f6f0e0
        public void set_phase(){} // RVA: 0x7ffaa93ff2c0
        public void get_indirectTouch(){} // RVA: 0x7ffaa8f6f0f0
        public void set_indirectTouch(){} // RVA: 0x7ffaa93d9af0
        public void get_tap(){} // RVA: 0x7ffaa8f78130
        public void set_tap(){} // RVA: 0x7ffaa93e4fb0
        public void get_tapCount(){} // RVA: 0x7ffaa8f73670
        public void set_tapCount(){} // RVA: 0x7ffaa93e9360
        public void get_startTime(){} // RVA: 0x7ffaa93d5320
        public void set_startTime(){} // RVA: 0x7ffaa93e3d80
        public void get_startPosition(){} // RVA: 0x7ffaa93d4100
        public void set_startPosition(){} // RVA: 0x7ffaa93e7fd0
        public void get_isInProgress(){} // RVA: 0x7ffaaef80020
        public void .ctor(){} // RVA: 0x7ffaaef80090
        public void FinishSetup(){} // RVA: 0x7ffaaef80140
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaaef808b0
        public void WriteValueIntoState(){} // RVA: 0x7ffaaef80940
    }

    public class TouchPhaseControl : InputControl`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaef809d0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaaef80a90
        public void WriteValueIntoState(){} // RVA: 0x7ffaaef80b00
    }

    public class TouchPressControl : ButtonControl
    {
        // ── Original Methods ──
        public void FinishSetup(){} // RVA: 0x7ffaaef80b70
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaaef80c90
        public void WriteValueIntoState(){} // RVA: 0x7ffaaef80d20
        public void .ctor(){} // RVA: 0x7ffaaef7e3c0
    }

    public class Vector2Control : InputControl`1
    {
        // ── Original Methods ──
        public void get_x(){} // RVA: 0x7ffaa8f76f40
        public void set_x(){} // RVA: 0x7ffaa93fc460
        public void get_y(){} // RVA: 0x7ffaa8de7450
        public void set_y(){} // RVA: 0x7ffaa8de5d60
        public void .ctor(){} // RVA: 0x7ffaaef80d60
        public void FinishSetup(){} // RVA: 0x7ffaaef80e20
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaaef80f90
        public void WriteValueIntoState(){} // RVA: 0x7ffaaef81070
        public void EvaluateMagnitude(){} // RVA: 0x7ffaaef81160
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7ffaaef812d0
    }

    public class Vector3Control : InputControl`1
    {
        public object _z; // 0x33955F80, was: <z>k__BackingField
        public object x; // 0x170005CE

        // ── Original Methods ──
        public void get_x(){} // RVA: 0x7ffaa8de7450
        public void set_x(){} // RVA: 0x7ffaa8de5d60
        public void get_y(){} // RVA: 0x7ffaa8b68c40
        public void set_y(){} // RVA: 0x7ffaa8b6fd10
        public void get_z(){} // RVA: 0x7ffaa8f78450
        public void set_z(){} // RVA: 0x7ffaa93ff110
        public void .ctor(){} // RVA: 0x7ffaaef81450
        public void FinishSetup(){} // RVA: 0x7ffaaef81510
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaaef81700
        public void WriteValueIntoState(){} // RVA: 0x7ffaaef81820
        public void EvaluateMagnitude(){} // RVA: 0x7ffaaef81940
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7ffaaef81ac0
    }

}