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
        public 0x664B0390 clamp; // 0x108
        public float clampMin; // 0x10C
        public float clampMax; // 0x110
        public float clampConstant; // 0x114
        public bool invert; // 0x118
        public bool normalize; // 0x119
        public float normalizeMin; // 0x11C
        public float normalizeMax; // 0x120
        public float normalizeZero; // 0x124
        public bool scale; // 0x128
        public float scaleFactor; // 0x12C

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
        public bool needsToCheckFramePress; // 0x130
        public uint pressPointOrDefault; // 0x134
        public uint isPressed; // 0x138
        public bool wasPressedThisFrame; // 0x13C
        public bool wasReleasedThisFrame; // 0x13D
        public float pressPoint; // 0x140
        public float s_GlobalDefaultButtonPressPoint;
        public float s_GlobalDefaultButtonReleaseThreshold; // 0x4
        public float kMinButtonPressPoint;

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
        public UnityEngine.InputSystem.Controls.AxisControl up; // 0x120
        public UnityEngine.InputSystem.Controls.AxisControl down; // 0x128
        public UnityEngine.InputSystem.Controls.AxisControl left; // 0x130
        public UnityEngine.InputSystem.Controls.AxisControl right; // 0x138

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
        public int minValue; // 0x148
        public int maxValue; // 0x14C
        public int wrapAtValue; // 0x150
        public int nullValue; // 0x154
        public 0x664B04F0 writeMode; // 0x158

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
        public UnityEngine.InputSystem.Controls.ButtonControl up; // 0x120
        public UnityEngine.InputSystem.Controls.ButtonControl down; // 0x128
        public UnityEngine.InputSystem.Controls.ButtonControl left; // 0x130
        public UnityEngine.InputSystem.Controls.ButtonControl right; // 0x138

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
        public 0x664A7B70 keyCode; // 0x148
        public int scanCode; // 0x14C

        // ── Methods ──
        public void get_keyCode(){} // RVA: 0x7FFD4F4B0620
        public void set_keyCode(){} // RVA: 0x7FFD4F4BEA20
        public void get_scanCode(){} // RVA: 0x7FFD5497D2B0
        public void RefreshConfiguration(){} // RVA: 0x7FFD5497D300
        public void .ctor(){} // RVA: 0x7FFD5497C3F0
    }

    public class QuaternionControl : InputControl`1
    {
        public UnityEngine.InputSystem.Controls.AxisControl x; // 0x120
        public UnityEngine.InputSystem.Controls.AxisControl y; // 0x128
        public UnityEngine.InputSystem.Controls.AxisControl z; // 0x130
        public UnityEngine.InputSystem.Controls.AxisControl w; // 0x138

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
        public UnityEngine.InputSystem.Controls.ButtonControl up; // 0x120
        public UnityEngine.InputSystem.Controls.ButtonControl down; // 0x128
        public UnityEngine.InputSystem.Controls.ButtonControl left; // 0x130
        public UnityEngine.InputSystem.Controls.ButtonControl right; // 0x138

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
        public UnityEngine.InputSystem.Controls.TouchPressControl press; // 0x170
        public UnityEngine.InputSystem.Controls.IntegerControl displayIndex; // 0x178
        public UnityEngine.InputSystem.Controls.IntegerControl touchId; // 0x180
        public UnityEngine.InputSystem.Controls.Vector2Control position; // 0x188
        public UnityEngine.InputSystem.Controls.DeltaControl delta; // 0x190
        public UnityEngine.InputSystem.Controls.AxisControl pressure; // 0x198
        public UnityEngine.InputSystem.Controls.Vector2Control radius; // 0x1A0
        public UnityEngine.InputSystem.Controls.TouchPhaseControl phase; // 0x1A8
        public UnityEngine.InputSystem.Controls.ButtonControl indirectTouch; // 0x1B0
        public UnityEngine.InputSystem.Controls.ButtonControl tap; // 0x1B8
        public UnityEngine.InputSystem.Controls.IntegerControl tapCount; // 0x1C0
        public UnityEngine.InputSystem.Controls.DoubleControl startTime; // 0x1C8
        public UnityEngine.InputSystem.Controls.Vector2Control startPosition; // 0x1D0

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
        public UnityEngine.InputSystem.Controls.AxisControl x; // 0x110
        public UnityEngine.InputSystem.Controls.AxisControl y; // 0x118

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
        public UnityEngine.InputSystem.Controls.AxisControl x; // 0x118
        public UnityEngine.InputSystem.Controls.AxisControl y; // 0x120
        public UnityEngine.InputSystem.Controls.AxisControl z; // 0x128

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