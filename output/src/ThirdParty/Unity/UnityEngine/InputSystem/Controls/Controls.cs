// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Controls
// Classes: 19
// Methods: 188

namespace ThirdParty.Unity.UnityEngine.InputSystem.Controls
{
    public class AnyKeyControl : ButtonControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x78207F0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7820860
    }

    public class AxisControl : InputControl`1
    {
        // ── Methods ──
        public void Preprocess(){} // RVA: 0x7820980
        public void Unpreprocess(){} // RVA: 0x7820A70
        public void .ctor(){} // RVA: 0x7820B00
        public void FinishSetup(){} // RVA: 0x7820BC0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7820CB0
        public void WriteValueIntoState(){} // RVA: 0x7820D80
        public void CompareValue(){} // RVA: 0x7820EE0
        public void EvaluateMagnitude(){} // RVA: 0x7821150
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7821230
    }

    public class ButtonControl : AxisControl
    {
        // ── Methods ──
        public void get_needsToCheckFramePress(){} // RVA: 0x6EDDEC0
        public void set_needsToCheckFramePress(){} // RVA: 0x78213D0
        public void get_pressPointOrDefault(){} // RVA: 0x78213E0
        public void .ctor(){} // RVA: 0x7821440
        public void IsValueConsideredPressed(){} // RVA: 0x7821530
        public void get_isPressed(){} // RVA: 0x78215B0
        public void BeginTestingForFramePresses(){} // RVA: 0x7821610
        public void get_wasPressedThisFrame(){} // RVA: 0x7821720
        public void get_wasReleasedThisFrame(){} // RVA: 0x7821850
        public void UpdateWasPressed(){} // RVA: 0x7821980
    }

    public class ButtonControl[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class DeltaControl : Vector2Control
    {
        // ── Methods ──
        public void get_up(){} // RVA: 0x114AC20
        public void set_up(){} // RVA: 0x1149C90
        public void get_down(){} // RVA: 0xE3C930
        public void set_down(){} // RVA: 0xE3D020
        public void get_left(){} // RVA: 0x135EDB0
        public void set_left(){} // RVA: 0x1658000
        public void get_right(){} // RVA: 0x135A170
        public void set_right(){} // RVA: 0x1365A40
        public void FinishSetup(){} // RVA: 0x7821A10
        public void .ctor(){} // RVA: 0x7821C60
    }

    public class DiscreteButtonControl : ButtonControl
    {
        // ── Methods ──
        public void FinishSetup(){} // RVA: 0x7821C70
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7821D90
        public void WriteValueIntoState(){} // RVA: 0x7821E70
        public void .ctor(){} // RVA: 0x7821FD0
    }

    public class DoubleControl : InputControl`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7821FE0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x78220A0
        public void WriteValueIntoState(){} // RVA: 0x7822100
    }

    public class DpadControl : Vector2Control
    {
        // ── Methods ──
        public void get_up(){} // RVA: 0x114AC20
        public void set_up(){} // RVA: 0x1149C90
        public void get_down(){} // RVA: 0xE3C930
        public void set_down(){} // RVA: 0xE3D020
        public void get_left(){} // RVA: 0x135EDB0
        public void set_left(){} // RVA: 0x1658000
        public void get_right(){} // RVA: 0x135A170
        public void set_right(){} // RVA: 0x1365A40
        public void .ctor(){} // RVA: 0x7822170
        public void FinishSetup(){} // RVA: 0x78221E0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7822430
        public void WriteValueIntoState(){} // RVA: 0x7822710
        public void MakeDpadVector(){} // RVA: 0x7822960
    }

    public class IntegerControl : InputControl`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7822B70
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7822C30
        public void WriteValueIntoState(){} // RVA: 0x7822CD0
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7822D70
    }

    public class KeyControl : ButtonControl
    {
        // ── Methods ──
        public void get_keyCode(){} // RVA: 0x1EB2410
        public void set_keyCode(){} // RVA: 0x1EABA10
        public void get_scanCode(){} // RVA: 0x7822E60
        public void RefreshConfiguration(){} // RVA: 0x7822EB0
        public void .ctor(){} // RVA: 0x7821FD0
    }

    public class KeyControl[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class QuaternionControl : InputControl`1
    {
        // ── Methods ──
        public void get_x(){} // RVA: 0x114AC20
        public void set_x(){} // RVA: 0x1149C90
        public void get_y(){} // RVA: 0xE3C930
        public void set_y(){} // RVA: 0xE3D020
        public void get_z(){} // RVA: 0x135EDB0
        public void set_z(){} // RVA: 0x1658000
        public void get_w(){} // RVA: 0x135A170
        public void set_w(){} // RVA: 0x1365A40
        public void .ctor(){} // RVA: 0x7823120
        public void FinishSetup(){} // RVA: 0x78231E0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7823450
        public void WriteValueIntoState(){} // RVA: 0x78235B0
        public void CalculateOptimizedControlDataType(){} // RVA: 0x78236F0
    }

    public class StickControl : Vector2Control
    {
        // ── Methods ──
        public void get_up(){} // RVA: 0x114AC20
        public void set_up(){} // RVA: 0x1149C90
        public void get_down(){} // RVA: 0xE3C930
        public void set_down(){} // RVA: 0xE3D020
        public void get_left(){} // RVA: 0x135EDB0
        public void set_left(){} // RVA: 0x1658000
        public void get_right(){} // RVA: 0x135A170
        public void set_right(){} // RVA: 0x1365A40
        public void FinishSetup(){} // RVA: 0x78239B0
        public void .ctor(){} // RVA: 0x7821C60
    }

    public class TouchControl : InputControl`1
    {
        // ── Methods ──
        public void get_press(){} // RVA: 0x10F9C30
        public void set_press(){} // RVA: 0x1659C50
        public void get_displayIndex(){} // RVA: 0x10F9390
        public void set_displayIndex(){} // RVA: 0x165AF80
        public void get_touchId(){} // RVA: 0x165EBC0
        public void set_touchId(){} // RVA: 0x1651590
        public void get_position(){} // RVA: 0x1667D40
        public void set_position(){} // RVA: 0x1669D30
        public void get_delta(){} // RVA: 0x13659D0
        public void set_delta(){} // RVA: 0x166D270
        public void get_pressure(){} // RVA: 0x135C160
        public void set_pressure(){} // RVA: 0x16614A0
        public void get_radius(){} // RVA: 0x1664460
        public void set_radius(){} // RVA: 0x16679E0
        public void get_phase(){} // RVA: 0x135A180
        public void set_phase(){} // RVA: 0x164D690
        public void get_indirectTouch(){} // RVA: 0x165E8F0
        public void set_indirectTouch(){} // RVA: 0x165C4D0
        public void get_tap(){} // RVA: 0x1659CB0
        public void set_tap(){} // RVA: 0x163A980
        public void get_tapCount(){} // RVA: 0x1344890
        public void set_tapCount(){} // RVA: 0x1662780
        public void get_startTime(){} // RVA: 0x1655DD0
        public void set_startTime(){} // RVA: 0x16694D0
        public void get_startPosition(){} // RVA: 0x1654670
        public void set_startPosition(){} // RVA: 0x16612E0
        public void get_isInProgress(){} // RVA: 0x7823C00
        public void .ctor(){} // RVA: 0x7823C70
        public void FinishSetup(){} // RVA: 0x7823D20
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7824490
        public void WriteValueIntoState(){} // RVA: 0x7824520
    }

    public class TouchControl[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TouchPhaseControl : InputControl`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x78245B0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7824670
        public void WriteValueIntoState(){} // RVA: 0x78246E0
    }

    public class TouchPressControl : ButtonControl
    {
        // ── Methods ──
        public void FinishSetup(){} // RVA: 0x7824750
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7824870
        public void WriteValueIntoState(){} // RVA: 0x7824900
        public void .ctor(){} // RVA: 0x7821FD0
    }

    public class Vector2Control : InputControl`1
    {
        // ── Methods ──
        public void get_x(){} // RVA: 0xD9E3D0
        public void set_x(){} // RVA: 0xD9D290
        public void get_y(){} // RVA: 0xDA0520
        public void set_y(){} // RVA: 0xD9D570
        public void .ctor(){} // RVA: 0x7824940
        public void FinishSetup(){} // RVA: 0x7824A00
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7824B70
        public void WriteValueIntoState(){} // RVA: 0x7824C50
        public void EvaluateMagnitude(){} // RVA: 0x7824D40
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7824EB0
    }

    public class Vector3Control : InputControl`1
    {
        // ── Methods ──
        public void get_x(){} // RVA: 0xDA0520
        public void set_x(){} // RVA: 0xD9D570
        public void get_y(){} // RVA: 0x114AC20
        public void set_y(){} // RVA: 0x1149C90
        public void get_z(){} // RVA: 0xE3C930
        public void set_z(){} // RVA: 0xE3D020
        public void .ctor(){} // RVA: 0x7825030
        public void FinishSetup(){} // RVA: 0x78250F0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x78252E0
        public void WriteValueIntoState(){} // RVA: 0x7825400
        public void EvaluateMagnitude(){} // RVA: 0x7825520
        public void CalculateOptimizedControlDataType(){} // RVA: 0x78256A0
    }

}