// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Controls
// Classes: 19
// Methods: 198

namespace ThirdParty.Unity.UnityEngine.InputSystem.Controls
{
    public class AnyKeyControl : ButtonControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEBB0FB0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7AEBB1020
    }

    public class AxisControl : InputControl`1
    {
        // ── Methods ──
        public void Preprocess(){} // RVA: 0x7AEBB1140
        public void Unpreprocess(){} // RVA: 0x7AEBB1230
        public void .ctor(){} // RVA: 0x7AEBB12C0
        public void FinishSetup(){} // RVA: 0x7AEBB1380
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7AEBB1470
        public void WriteValueIntoState(){} // RVA: 0x7AEBB1540
        public void CompareValue(){} // RVA: 0x7AEBB16A0
        public void EvaluateMagnitude(){} // RVA: 0x7AEBB1910
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7AEBB19F0
        public void clamp(){} // RVA: 0x7B2C93070
    }

    public class ButtonControl : AxisControl
    {
        // ── Methods ──
        public void get_needsToCheckFramePress(){} // RVA: 0x7AE25CA60
        public void set_needsToCheckFramePress(){} // RVA: 0x7AEBB1B90
        public void get_pressPointOrDefault(){} // RVA: 0x7AEBB1BA0
        public void .ctor(){} // RVA: 0x7AEBB1C00
        public void IsValueConsideredPressed(){} // RVA: 0x7AEBB1CF0
        public void get_isPressed(){} // RVA: 0x7AEBB1D70
        public void BeginTestingForFramePresses(){} // RVA: 0x7AEBB1DD0
        public void get_wasPressedThisFrame(){} // RVA: 0x7AEBB1EE0
        public void get_wasReleasedThisFrame(){} // RVA: 0x7AEBB2010
        public void UpdateWasPressed(){} // RVA: 0x7AEBB2140
        // ── Unresolved (hash) ──
        public void m_NeedsToCheckFramePress(){} // RVA: 0x7B3FAD508
    }

    public class ButtonControl[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class DeltaControl : Vector2Control
    {
        // ── Methods ──
        public void get_up(){} // RVA: 0x7A8357A90
        public void set_up(){} // RVA: 0x7A8358860
        public void get_down(){} // RVA: 0x7A884CA70
        public void set_down(){} // RVA: 0x7A8ADA650
        public void get_left(){} // RVA: 0x7A884C460
        public void set_left(){} // RVA: 0x7A8B68960
        public void get_right(){} // RVA: 0x7A8850FF0
        public void set_right(){} // RVA: 0x7A8854900
        public void FinishSetup(){} // RVA: 0x7AEBB21D0
        public void .ctor(){} // RVA: 0x7AEBB2420
        public void <up>k__BackingField(){} // RVA: 0x7B4177E18
    }

    public class DiscreteButtonControl : ButtonControl
    {
        // ── Methods ──
        public void FinishSetup(){} // RVA: 0x7AEBB2430
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7AEBB2550
        public void WriteValueIntoState(){} // RVA: 0x7AEBB2630
        public void .ctor(){} // RVA: 0x7AEBB2790
        public void minValue(){} // RVA: 0x7B3FAD6B8
    }

    public class DoubleControl : InputControl`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEBB27A0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7AEBB2860
        public void WriteValueIntoState(){} // RVA: 0x7AEBB28C0
    }

    public class DpadControl : Vector2Control
    {
        // ── Methods ──
        public void get_up(){} // RVA: 0x7A8357A90
        public void set_up(){} // RVA: 0x7A8358860
        public void get_down(){} // RVA: 0x7A884CA70
        public void set_down(){} // RVA: 0x7A8ADA650
        public void get_left(){} // RVA: 0x7A884C460
        public void set_left(){} // RVA: 0x7A8B68960
        public void get_right(){} // RVA: 0x7A8850FF0
        public void set_right(){} // RVA: 0x7A8854900
        public void .ctor(){} // RVA: 0x7AEBB2930
        public void FinishSetup(){} // RVA: 0x7AEBB29A0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7AEBB2BF0
        public void WriteValueIntoState(){} // RVA: 0x7AEBB2ED0
        public void MakeDpadVector(){} // RVA: 0x7AEBB3120
        public void <up>k__BackingField(){} // RVA: 0x7B3FAD6B8
    }

    public class IntegerControl : InputControl`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEBB3370
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7AEBB3430
        public void WriteValueIntoState(){} // RVA: 0x7AEBB34D0
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7AEBB3570
    }

    public class KeyControl : ButtonControl
    {
        // ── Methods ──
        public void get_keyCode(){} // RVA: 0x7A93B3910
        public void set_keyCode(){} // RVA: 0x7A9398450
        public void get_scanCode(){} // RVA: 0x7AEBB3660
        public void RefreshConfiguration(){} // RVA: 0x7AEBB36B0
        public void .ctor(){} // RVA: 0x7AEBB2790
    }

    public class KeyControl[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class QuaternionControl : InputControl`1
    {
        // ── Methods ──
        public void get_x(){} // RVA: 0x7A8357A90
        public void set_x(){} // RVA: 0x7A8358860
        public void get_y(){} // RVA: 0x7A884CA70
        public void set_y(){} // RVA: 0x7A8ADA650
        public void get_z(){} // RVA: 0x7A884C460
        public void set_z(){} // RVA: 0x7A8B68960
        public void get_w(){} // RVA: 0x7A8850FF0
        public void set_w(){} // RVA: 0x7A8854900
        public void .ctor(){} // RVA: 0x7AEBB3920
        public void FinishSetup(){} // RVA: 0x7AEBB39E0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7AEBB3C50
        public void WriteValueIntoState(){} // RVA: 0x7AEBB3DB0
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7AEBB3EF0
        public void <x>k__BackingField(){} // RVA: 0x7B4204F58
    }

    public class StickControl : Vector2Control
    {
        // ── Methods ──
        public void get_up(){} // RVA: 0x7A8357A90
        public void set_up(){} // RVA: 0x7A8358860
        public void get_down(){} // RVA: 0x7A884CA70
        public void set_down(){} // RVA: 0x7A8ADA650
        public void get_left(){} // RVA: 0x7A884C460
        public void set_left(){} // RVA: 0x7A8B68960
        public void get_right(){} // RVA: 0x7A8850FF0
        public void set_right(){} // RVA: 0x7A8854900
        public void FinishSetup(){} // RVA: 0x7AEBB41B0
        public void .ctor(){} // RVA: 0x7AEBB2420
        public void <up>k__BackingField(){} // RVA: 0x7B4194D58
    }

    public class TouchControl : InputControl`1
    {
        // ── Methods ──
        public void get_press(){} // RVA: 0x7A85ECF50
        public void set_press(){} // RVA: 0x7A8B51A20
        public void get_displayIndex(){} // RVA: 0x7A85EBF70
        public void set_displayIndex(){} // RVA: 0x7A8B4A0C0
        public void get_touchId(){} // RVA: 0x7A8B6A790
        public void set_touchId(){} // RVA: 0x7A8B4AC60
        public void get_position(){} // RVA: 0x7A8B46B20
        public void set_position(){} // RVA: 0x7A8B639C0
        public void get_delta(){} // RVA: 0x7A884DD70
        public void set_delta(){} // RVA: 0x7A8B5ADA0
        public void get_pressure(){} // RVA: 0x7A8855020
        public void set_pressure(){} // RVA: 0x7A8B60460
        public void get_radius(){} // RVA: 0x7A8B76160
        public void set_radius(){} // RVA: 0x7A8B592F0
        public void get_phase(){} // RVA: 0x7A8852B30
        public void set_phase(){} // RVA: 0x7A8B66E80
        public void get_indirectTouch(){} // RVA: 0x7A8B69B70
        public void set_indirectTouch(){} // RVA: 0x7A8B4DC50
        public void get_tap(){} // RVA: 0x7A8B772D0
        public void set_tap(){} // RVA: 0x7A8B58850
        public void get_tapCount(){} // RVA: 0x7A8815B70
        public void set_tapCount(){} // RVA: 0x7A8B58420
        public void get_startTime(){} // RVA: 0x7A8B6AFA0
        public void set_startTime(){} // RVA: 0x7A8B58B30
        public void get_startPosition(){} // RVA: 0x7A8B79060
        public void set_startPosition(){} // RVA: 0x7A8B49820
        public void get_isInProgress(){} // RVA: 0x7AEBB4400
        public void .ctor(){} // RVA: 0x7AEBB4470
        public void FinishSetup(){} // RVA: 0x7AEBB4520
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7AEBB4C90
        public void WriteValueIntoState(){} // RVA: 0x7AEBB4D20
        public void <press>k__BackingField(){} // RVA: 0x7B4196CB8
    }

    public class TouchControl[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class TouchPhaseControl : InputControl`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEBB4DB0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7AEBB4E70
        public void WriteValueIntoState(){} // RVA: 0x7AEBB4EE0
    }

    public class TouchPressControl : ButtonControl
    {
        // ── Methods ──
        public void FinishSetup(){} // RVA: 0x7AEBB4F50
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7AEBB5070
        public void WriteValueIntoState(){} // RVA: 0x7AEBB5100
        public void .ctor(){} // RVA: 0x7AEBB2790
    }

    public class Vector2Control : InputControl`1
    {
        // ── Methods ──
        public void get_x(){} // RVA: 0x7A884F050
        public void set_x(){} // RVA: 0x7A8B5D8D0
        public void get_y(){} // RVA: 0x7A864CFF0
        public void set_y(){} // RVA: 0x7A864C880
        public void .ctor(){} // RVA: 0x7AEBB5140
        public void FinishSetup(){} // RVA: 0x7AEBB5200
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7AEBB5370
        public void WriteValueIntoState(){} // RVA: 0x7AEBB5450
        public void EvaluateMagnitude(){} // RVA: 0x7AEBB5540
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7AEBB56B0
        public void <x>k__BackingField(){} // RVA: 0x7B2C93070
    }

    public class Vector3Control : InputControl`1
    {
        // ── Methods ──
        public void get_x(){} // RVA: 0x7A864CFF0
        public void set_x(){} // RVA: 0x7A864C880
        public void get_y(){} // RVA: 0x7A8357A90
        public void set_y(){} // RVA: 0x7A8358860
        public void get_z(){} // RVA: 0x7A884CA70
        public void set_z(){} // RVA: 0x7A8ADA650
        public void .ctor(){} // RVA: 0x7AEBB5830
        public void FinishSetup(){} // RVA: 0x7AEBB58F0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7AEBB5AE0
        public void WriteValueIntoState(){} // RVA: 0x7AEBB5C00
        public void EvaluateMagnitude(){} // RVA: 0x7AEBB5D20
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7AEBB5EA0
        public void <x>k__BackingField(){} // RVA: 0x7B2C93070
    }

}