// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Controls
// Classes: 16
// Methods: 145

namespace ThirdParty.Unity.UnityEngine.InputSystem.Controls
{
    public class AnyKeyControl : ButtonControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC955AC00
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC955AC70
    }

    public class AxisControl : InputControl`1
    {
        public 0x6B150390 clamp; // 0x108
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
        public void Preprocess(){} // RVA: 0x7FFAC955AD90
        public void Unpreprocess(){} // RVA: 0x7FFAC955AE80
        public void .ctor(){} // RVA: 0x7FFAC955AF10
        public void FinishSetup(){} // RVA: 0x7FFAC955AFD0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC955B0C0
        public void WriteValueIntoState(){} // RVA: 0x7FFAC955B190
        public void CompareValue(){} // RVA: 0x7FFAC955B2F0
        public void EvaluateMagnitude(){} // RVA: 0x7FFAC955B560 | overloaded x2
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFAC955B640
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
        public void get_needsToCheckFramePress(){} // RVA: 0x7FFAC8C06730
        public void set_needsToCheckFramePress(){} // RVA: 0x7FFAC955B7E0
        public void get_pressPointOrDefault(){} // RVA: 0x7FFAC955B7F0
        public void .ctor(){} // RVA: 0x7FFAC955B850
        public void IsValueConsideredPressed(){} // RVA: 0x7FFAC955B940
        public void get_isPressed(){} // RVA: 0x7FFAC955B9C0
        public void BeginTestingForFramePresses(){} // RVA: 0x7FFAC955BA20
        public void get_wasPressedThisFrame(){} // RVA: 0x7FFAC955BB30
        public void get_wasReleasedThisFrame(){} // RVA: 0x7FFAC955BC60
        public void UpdateWasPressed(){} // RVA: 0x7FFAC955BD90
    }

    public class DeltaControl : Vector2Control
    {
        public UnityEngine.InputSystem.Controls.AxisControl up; // 0x120
        public UnityEngine.InputSystem.Controls.AxisControl down; // 0x128
        public UnityEngine.InputSystem.Controls.AxisControl left; // 0x130
        public UnityEngine.InputSystem.Controls.AxisControl right; // 0x138

        // ── Methods ──
        public void get_up(){} // RVA: 0x7FFAC313CBB0
        public void set_up(){} // RVA: 0x7FFAC3143400
        public void get_down(){} // RVA: 0x7FFAC35466F0
        public void set_down(){} // RVA: 0x7FFAC39C51C0
        public void get_left(){} // RVA: 0x7FFAC3544340
        public void set_left(){} // RVA: 0x7FFAC39A79B0
        public void get_right(){} // RVA: 0x7FFAC35422C0
        public void set_right(){} // RVA: 0x7FFAC36D84B0
        public void FinishSetup(){} // RVA: 0x7FFAC955BE30
        public void .ctor(){} // RVA: 0x7FFAC955C080
    }

    public class DiscreteButtonControl : ButtonControl
    {
        public int minValue; // 0x148
        public int maxValue; // 0x14C
        public int wrapAtValue; // 0x150
        public int nullValue; // 0x154
        public 0x6B1504F0 writeMode; // 0x158

        // ── Methods ──
        public void FinishSetup(){} // RVA: 0x7FFAC955C090
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC955C1B0
        public void WriteValueIntoState(){} // RVA: 0x7FFAC955C290
        public void .ctor(){} // RVA: 0x7FFAC955C3F0
    }

    public class DoubleControl : InputControl`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC955C400
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC955C4C0
        public void WriteValueIntoState(){} // RVA: 0x7FFAC955C520
    }

    public class DpadControl : Vector2Control
    {
        public UnityEngine.InputSystem.Controls.ButtonControl up; // 0x120
        public UnityEngine.InputSystem.Controls.ButtonControl down; // 0x128
        public UnityEngine.InputSystem.Controls.ButtonControl left; // 0x130
        public UnityEngine.InputSystem.Controls.ButtonControl right; // 0x138

        // ── Methods ──
        public void get_up(){} // RVA: 0x7FFAC313CBB0
        public void set_up(){} // RVA: 0x7FFAC3143400
        public void get_down(){} // RVA: 0x7FFAC35466F0
        public void set_down(){} // RVA: 0x7FFAC39C51C0
        public void get_left(){} // RVA: 0x7FFAC3544340
        public void set_left(){} // RVA: 0x7FFAC39A79B0
        public void get_right(){} // RVA: 0x7FFAC35422C0
        public void set_right(){} // RVA: 0x7FFAC36D84B0
        public void .ctor(){} // RVA: 0x7FFAC955C590
        public void FinishSetup(){} // RVA: 0x7FFAC955C600
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC955C850
        public void WriteValueIntoState(){} // RVA: 0x7FFAC955CB20
        public void MakeDpadVector(){} // RVA: 0x7FFAC955CD70 | overloaded x2
    }

    public class IntegerControl : InputControl`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC955CFC0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC955D080
        public void WriteValueIntoState(){} // RVA: 0x7FFAC955D120
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFAC955D1C0
    }

    public class KeyControl : ButtonControl
    {
        public 0x6B147B70 keyCode; // 0x148
        public int scanCode; // 0x14C

        // ── Methods ──
        public void get_keyCode(){} // RVA: 0x7FFAC4090620
        public void set_keyCode(){} // RVA: 0x7FFAC409EA20
        public void get_scanCode(){} // RVA: 0x7FFAC955D2B0
        public void RefreshConfiguration(){} // RVA: 0x7FFAC955D300
        public void .ctor(){} // RVA: 0x7FFAC955C3F0
    }

    public class QuaternionControl : InputControl`1
    {
        public UnityEngine.InputSystem.Controls.AxisControl x; // 0x120
        public UnityEngine.InputSystem.Controls.AxisControl y; // 0x128
        public UnityEngine.InputSystem.Controls.AxisControl z; // 0x130
        public UnityEngine.InputSystem.Controls.AxisControl w; // 0x138

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFAC313CBB0
        public void set_x(){} // RVA: 0x7FFAC3143400
        public void get_y(){} // RVA: 0x7FFAC35466F0
        public void set_y(){} // RVA: 0x7FFAC39C51C0
        public void get_z(){} // RVA: 0x7FFAC3544340
        public void set_z(){} // RVA: 0x7FFAC39A79B0
        public void get_w(){} // RVA: 0x7FFAC35422C0
        public void set_w(){} // RVA: 0x7FFAC36D84B0
        public void .ctor(){} // RVA: 0x7FFAC955D570
        public void FinishSetup(){} // RVA: 0x7FFAC955D630
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC955D8A0
        public void WriteValueIntoState(){} // RVA: 0x7FFAC955DA00
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFAC955DB40
    }

    public class StickControl : Vector2Control
    {
        public UnityEngine.InputSystem.Controls.ButtonControl up; // 0x120
        public UnityEngine.InputSystem.Controls.ButtonControl down; // 0x128
        public UnityEngine.InputSystem.Controls.ButtonControl left; // 0x130
        public UnityEngine.InputSystem.Controls.ButtonControl right; // 0x138

        // ── Methods ──
        public void get_up(){} // RVA: 0x7FFAC313CBB0
        public void set_up(){} // RVA: 0x7FFAC3143400
        public void get_down(){} // RVA: 0x7FFAC35466F0
        public void set_down(){} // RVA: 0x7FFAC39C51C0
        public void get_left(){} // RVA: 0x7FFAC3544340
        public void set_left(){} // RVA: 0x7FFAC39A79B0
        public void get_right(){} // RVA: 0x7FFAC35422C0
        public void set_right(){} // RVA: 0x7FFAC36D84B0
        public void FinishSetup(){} // RVA: 0x7FFAC955DE00
        public void .ctor(){} // RVA: 0x7FFAC955C080
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
        public void get_press(){} // RVA: 0x7FFAC336D850
        public void set_press(){} // RVA: 0x7FFAC39B5DB0
        public void get_displayIndex(){} // RVA: 0x7FFAC336D860
        public void set_displayIndex(){} // RVA: 0x7FFAC39CA130
        public void get_touchId(){} // RVA: 0x7FFAC354B1B0
        public void set_touchId(){} // RVA: 0x7FFAC3503070
        public void get_position(){} // RVA: 0x7FFAC35410C0
        public void set_position(){} // RVA: 0x7FFAC3503010
        public void get_delta(){} // RVA: 0x7FFAC3540F60
        public void set_delta(){} // RVA: 0x7FFAC39AB1D0
        public void get_pressure(){} // RVA: 0x7FFAC3541C80
        public void set_pressure(){} // RVA: 0x7FFAC39C8ED0
        public void get_radius(){} // RVA: 0x7FFAC354E2E0
        public void set_radius(){} // RVA: 0x7FFAC39A8AF0
        public void get_phase(){} // RVA: 0x7FFAC3548F80
        public void set_phase(){} // RVA: 0x7FFAC39B4D10
        public void get_indirectTouch(){} // RVA: 0x7FFAC3549F30
        public void set_indirectTouch(){} // RVA: 0x7FFAC39A7790
        public void get_tap(){} // RVA: 0x7FFAC3544330
        public void set_tap(){} // RVA: 0x7FFAC39AC050
        public void get_tapCount(){} // RVA: 0x7FFAC35422B0
        public void set_tapCount(){} // RVA: 0x7FFAC39AD110
        public void get_startTime(){} // RVA: 0x7FFAC39CCB10
        public void set_startTime(){} // RVA: 0x7FFAC39CF3F0
        public void get_startPosition(){} // RVA: 0x7FFAC39C1920
        public void set_startPosition(){} // RVA: 0x7FFAC39A8050
        public void get_isInProgress(){} // RVA: 0x7FFAC955E050
        public void .ctor(){} // RVA: 0x7FFAC955E0C0
        public void FinishSetup(){} // RVA: 0x7FFAC955E170
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC955E8E0
        public void WriteValueIntoState(){} // RVA: 0x7FFAC955E970
    }

    public class TouchPhaseControl : InputControl`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC955EA00
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC955EAC0
        public void WriteValueIntoState(){} // RVA: 0x7FFAC955EB30
    }

    public class TouchPressControl : ButtonControl
    {
        // ── Methods ──
        public void FinishSetup(){} // RVA: 0x7FFAC955EBA0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC955ECC0
        public void WriteValueIntoState(){} // RVA: 0x7FFAC955ED50
        public void .ctor(){} // RVA: 0x7FFAC955C3F0
    }

    public class Vector2Control : InputControl`1
    {
        public UnityEngine.InputSystem.Controls.AxisControl x; // 0x110
        public UnityEngine.InputSystem.Controls.AxisControl y; // 0x118

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFAC354B170
        public void set_x(){} // RVA: 0x7FFAC39B3E10
        public void get_y(){} // RVA: 0x7FFAC33BC6D0
        public void set_y(){} // RVA: 0x7FFAC33B8580
        public void .ctor(){} // RVA: 0x7FFAC955ED90
        public void FinishSetup(){} // RVA: 0x7FFAC955EE50
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC955EFC0
        public void WriteValueIntoState(){} // RVA: 0x7FFAC955F0A0
        public void EvaluateMagnitude(){} // RVA: 0x7FFAC955F190
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFAC955F300
    }

    public class Vector3Control : InputControl`1
    {
        public UnityEngine.InputSystem.Controls.AxisControl x; // 0x118
        public UnityEngine.InputSystem.Controls.AxisControl y; // 0x120
        public UnityEngine.InputSystem.Controls.AxisControl z; // 0x128

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFAC33BC6D0
        public void set_x(){} // RVA: 0x7FFAC33B8580
        public void get_y(){} // RVA: 0x7FFAC313CBB0
        public void set_y(){} // RVA: 0x7FFAC3143400
        public void get_z(){} // RVA: 0x7FFAC35466F0
        public void set_z(){} // RVA: 0x7FFAC39C51C0
        public void .ctor(){} // RVA: 0x7FFAC955F480
        public void FinishSetup(){} // RVA: 0x7FFAC955F540
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC955F730
        public void WriteValueIntoState(){} // RVA: 0x7FFAC955F850
        public void EvaluateMagnitude(){} // RVA: 0x7FFAC955F970
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFAC955FAF0
    }

}