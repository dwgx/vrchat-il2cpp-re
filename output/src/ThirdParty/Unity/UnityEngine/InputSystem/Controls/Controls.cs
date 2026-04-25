// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Controls
// Classes: 16
// Methods: 145

namespace ThirdParty.Unity.UnityEngine.InputSystem.Controls
{
    public class AnyKeyControl : ButtonControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5497AC00
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD5497AC70
    }

    public class AxisControl : InputControl`1
    {
        // ── Methods ──
        public void Preprocess(){} // RVA: 0x7FFD5497AD90
        public void Unpreprocess(){} // RVA: 0x7FFD5497AE80
        public void .ctor(){} // RVA: 0x7FFD5497AF10
        public void FinishSetup(){} // RVA: 0x7FFD5497AFD0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD5497B0C0
        public void WriteValueIntoState(){} // RVA: 0x7FFD5497B190
        public void CompareValue(){} // RVA: 0x7FFD5497B2F0
        public void EvaluateMagnitude(){} // RVA: 0x7FFD5497B560 | overloaded x2
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFD5497B640
    }

    public class ButtonControl : AxisControl
    {
        public object needsToCheckFramePress;
        public object pressPointOrDefault;
        public object isPressed;
        public object wasPressedThisFrame;
        public object wasReleasedThisFrame;

        // ── Methods ──
        public void get_needsToCheckFramePress(){} // RVA: 0x7FFD54026730
        public void set_needsToCheckFramePress(){} // RVA: 0x7FFD5497B7E0
        public void get_pressPointOrDefault(){} // RVA: 0x7FFD5497B7F0
        public void .ctor(){} // RVA: 0x7FFD5497B850
        public void IsValueConsideredPressed(){} // RVA: 0x7FFD5497B940
        public void get_isPressed(){} // RVA: 0x7FFD5497B9C0
        public void BeginTestingForFramePresses(){} // RVA: 0x7FFD5497BA20
        public void get_wasPressedThisFrame(){} // RVA: 0x7FFD5497BB30
        public void get_wasReleasedThisFrame(){} // RVA: 0x7FFD5497BC60
        public void UpdateWasPressed(){} // RVA: 0x7FFD5497BD90
    }

    public class DeltaControl : Vector2Control
    {
        public object up;
        public object down;
        public object left;
        public object right;

        // ── Methods ──
        public void get_up(){} // RVA: 0x7FFD4E55CBB0
        public void set_up(){} // RVA: 0x7FFD4E563400
        public void get_down(){} // RVA: 0x7FFD4E9666F0
        public void set_down(){} // RVA: 0x7FFD4EDE51C0
        public void get_left(){} // RVA: 0x7FFD4E964340
        public void set_left(){} // RVA: 0x7FFD4EDC79B0
        public void get_right(){} // RVA: 0x7FFD4E9622C0
        public void set_right(){} // RVA: 0x7FFD4EAF84B0
        public void FinishSetup(){} // RVA: 0x7FFD5497BE30
        public void .ctor(){} // RVA: 0x7FFD5497C080
    }

    public class DiscreteButtonControl : ButtonControl
    {
        // ── Methods ──
        public void FinishSetup(){} // RVA: 0x7FFD5497C090
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD5497C1B0
        public void WriteValueIntoState(){} // RVA: 0x7FFD5497C290
        public void .ctor(){} // RVA: 0x7FFD5497C3F0
    }

    public class DoubleControl : InputControl`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5497C400
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD5497C4C0
        public void WriteValueIntoState(){} // RVA: 0x7FFD5497C520
    }

    public class DpadControl : Vector2Control
    {
        public object up;
        public object down;
        public object left;
        public object right;

        // ── Methods ──
        public void get_up(){} // RVA: 0x7FFD4E55CBB0
        public void set_up(){} // RVA: 0x7FFD4E563400
        public void get_down(){} // RVA: 0x7FFD4E9666F0
        public void set_down(){} // RVA: 0x7FFD4EDE51C0
        public void get_left(){} // RVA: 0x7FFD4E964340
        public void set_left(){} // RVA: 0x7FFD4EDC79B0
        public void get_right(){} // RVA: 0x7FFD4E9622C0
        public void set_right(){} // RVA: 0x7FFD4EAF84B0
        public void .ctor(){} // RVA: 0x7FFD5497C590
        public void FinishSetup(){} // RVA: 0x7FFD5497C600
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD5497C850
        public void WriteValueIntoState(){} // RVA: 0x7FFD5497CB20
        public void MakeDpadVector(){} // RVA: 0x7FFD5497CD70 | overloaded x2
    }

    public class IntegerControl : InputControl`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5497CFC0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD5497D080
        public void WriteValueIntoState(){} // RVA: 0x7FFD5497D120
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFD5497D1C0
    }

    public class KeyControl : ButtonControl
    {
        public object keyCode;
        public object scanCode;

        // ── Methods ──
        public void get_keyCode(){} // RVA: 0x7FFD4F4B0620
        public void set_keyCode(){} // RVA: 0x7FFD4F4BEA20
        public void get_scanCode(){} // RVA: 0x7FFD5497D2B0
        public void RefreshConfiguration(){} // RVA: 0x7FFD5497D300
        public void .ctor(){} // RVA: 0x7FFD5497C3F0
    }

    public class QuaternionControl : InputControl`1
    {
        public object x;
        public object y;
        public object z;
        public object w;

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFD4E55CBB0
        public void set_x(){} // RVA: 0x7FFD4E563400
        public void get_y(){} // RVA: 0x7FFD4E9666F0
        public void set_y(){} // RVA: 0x7FFD4EDE51C0
        public void get_z(){} // RVA: 0x7FFD4E964340
        public void set_z(){} // RVA: 0x7FFD4EDC79B0
        public void get_w(){} // RVA: 0x7FFD4E9622C0
        public void set_w(){} // RVA: 0x7FFD4EAF84B0
        public void .ctor(){} // RVA: 0x7FFD5497D570
        public void FinishSetup(){} // RVA: 0x7FFD5497D630
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD5497D8A0
        public void WriteValueIntoState(){} // RVA: 0x7FFD5497DA00
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFD5497DB40
    }

    public class StickControl : Vector2Control
    {
        public object up;
        public object down;
        public object left;
        public object right;

        // ── Methods ──
        public void get_up(){} // RVA: 0x7FFD4E55CBB0
        public void set_up(){} // RVA: 0x7FFD4E563400
        public void get_down(){} // RVA: 0x7FFD4E9666F0
        public void set_down(){} // RVA: 0x7FFD4EDE51C0
        public void get_left(){} // RVA: 0x7FFD4E964340
        public void set_left(){} // RVA: 0x7FFD4EDC79B0
        public void get_right(){} // RVA: 0x7FFD4E9622C0
        public void set_right(){} // RVA: 0x7FFD4EAF84B0
        public void FinishSetup(){} // RVA: 0x7FFD5497DE00
        public void .ctor(){} // RVA: 0x7FFD5497C080
    }

    public class TouchControl : InputControl`1
    {
        public object press;
        public object displayIndex;
        public object touchId;
        public object position;
        public object delta;
        public object pressure;
        public object radius;
        public object phase;
        public object indirectTouch;
        public object tap;
        public object tapCount;
        public object startTime;
        public object startPosition;
        public object isInProgress;

        // ── Methods ──
        public void get_press(){} // RVA: 0x7FFD4E78D850
        public void set_press(){} // RVA: 0x7FFD4EDD5DB0
        public void get_displayIndex(){} // RVA: 0x7FFD4E78D860
        public void set_displayIndex(){} // RVA: 0x7FFD4EDEA130
        public void get_touchId(){} // RVA: 0x7FFD4E96B1B0
        public void set_touchId(){} // RVA: 0x7FFD4E923070
        public void get_position(){} // RVA: 0x7FFD4E9610C0
        public void set_position(){} // RVA: 0x7FFD4E923010
        public void get_delta(){} // RVA: 0x7FFD4E960F60
        public void set_delta(){} // RVA: 0x7FFD4EDCB1D0
        public void get_pressure(){} // RVA: 0x7FFD4E961C80
        public void set_pressure(){} // RVA: 0x7FFD4EDE8ED0
        public void get_radius(){} // RVA: 0x7FFD4E96E2E0
        public void set_radius(){} // RVA: 0x7FFD4EDC8AF0
        public void get_phase(){} // RVA: 0x7FFD4E968F80
        public void set_phase(){} // RVA: 0x7FFD4EDD4D10
        public void get_indirectTouch(){} // RVA: 0x7FFD4E969F30
        public void set_indirectTouch(){} // RVA: 0x7FFD4EDC7790
        public void get_tap(){} // RVA: 0x7FFD4E964330
        public void set_tap(){} // RVA: 0x7FFD4EDCC050
        public void get_tapCount(){} // RVA: 0x7FFD4E9622B0
        public void set_tapCount(){} // RVA: 0x7FFD4EDCD110
        public void get_startTime(){} // RVA: 0x7FFD4EDECB10
        public void set_startTime(){} // RVA: 0x7FFD4EDEF3F0
        public void get_startPosition(){} // RVA: 0x7FFD4EDE1920
        public void set_startPosition(){} // RVA: 0x7FFD4EDC8050
        public void get_isInProgress(){} // RVA: 0x7FFD5497E050
        public void .ctor(){} // RVA: 0x7FFD5497E0C0
        public void FinishSetup(){} // RVA: 0x7FFD5497E170
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD5497E8E0
        public void WriteValueIntoState(){} // RVA: 0x7FFD5497E970
    }

    public class TouchPhaseControl : InputControl`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5497EA00
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD5497EAC0
        public void WriteValueIntoState(){} // RVA: 0x7FFD5497EB30
    }

    public class TouchPressControl : ButtonControl
    {
        // ── Methods ──
        public void FinishSetup(){} // RVA: 0x7FFD5497EBA0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD5497ECC0
        public void WriteValueIntoState(){} // RVA: 0x7FFD5497ED50
        public void .ctor(){} // RVA: 0x7FFD5497C3F0
    }

    public class Vector2Control : InputControl`1
    {
        public object x;
        public object y;

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFD4E96B170
        public void set_x(){} // RVA: 0x7FFD4EDD3E10
        public void get_y(){} // RVA: 0x7FFD4E7DC6D0
        public void set_y(){} // RVA: 0x7FFD4E7D8580
        public void .ctor(){} // RVA: 0x7FFD5497ED90
        public void FinishSetup(){} // RVA: 0x7FFD5497EE50
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD5497EFC0
        public void WriteValueIntoState(){} // RVA: 0x7FFD5497F0A0
        public void EvaluateMagnitude(){} // RVA: 0x7FFD5497F190
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFD5497F300
    }

    public class Vector3Control : InputControl`1
    {
        public object x;
        public object y;
        public object z;

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFD4E7DC6D0
        public void set_x(){} // RVA: 0x7FFD4E7D8580
        public void get_y(){} // RVA: 0x7FFD4E55CBB0
        public void set_y(){} // RVA: 0x7FFD4E563400
        public void get_z(){} // RVA: 0x7FFD4E9666F0
        public void set_z(){} // RVA: 0x7FFD4EDE51C0
        public void .ctor(){} // RVA: 0x7FFD5497F480
        public void FinishSetup(){} // RVA: 0x7FFD5497F540
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD5497F730
        public void WriteValueIntoState(){} // RVA: 0x7FFD5497F850
        public void EvaluateMagnitude(){} // RVA: 0x7FFD5497F970
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFD5497FAF0
    }

}