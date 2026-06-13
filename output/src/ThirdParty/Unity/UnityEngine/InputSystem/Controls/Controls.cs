// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Controls
// Classes: 16
// Methods: 145

namespace ThirdParty.Unity.UnityEngine.InputSystem.Controls
{
    public class AnyKeyControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DC24A0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x6DC2510
    }

    public class AxisControl
    {
        // ── Methods ──
        public void Preprocess(){} // RVA: 0x6DC2630
        public void Unpreprocess(){} // RVA: 0x6DC2720
        public void .ctor(){} // RVA: 0x6DC27B0
        public void FinishSetup(){} // RVA: 0x6DC2870
        public void ReadUnprocessedValueFromState(){} // RVA: 0x6DC2960
        public void WriteValueIntoState(){} // RVA: 0x6DC2A30
        public void CompareValue(){} // RVA: 0x6DC2B90
        public void EvaluateMagnitude(){} // RVA: 0x6DC2E00 | overloaded x2
        public void CalculateOptimizedControlDataType(){} // RVA: 0x6DC2EE0
    }

    public class ButtonControl
    {
        public bool m_NeedsToCheckFramePress; // 0x130
        public uint m_UpdateCountLastPressed; // 0x134
        public uint m_UpdateCountLastReleased; // 0x138
        public bool m_LastUpdateWasPress; // 0x13C
        public bool <needsToCheckFramePress>k__BackingField; // 0x13D

        // ── Methods ──
        public void get_needsToCheckFramePress(){} // RVA: 0x646FC70
        public void set_needsToCheckFramePress(){} // RVA: 0x6DC3080
        public void get_pressPointOrDefault(){} // RVA: 0x6DC3090
        public void .ctor(){} // RVA: 0x6DC30F0
        public void IsValueConsideredPressed(){} // RVA: 0x6DC31E0
        public void get_isPressed(){} // RVA: 0x6DC3260
        public void BeginTestingForFramePresses(){} // RVA: 0x6DC32C0
        public void get_wasPressedThisFrame(){} // RVA: 0x6DC33D0
        public void get_wasReleasedThisFrame(){} // RVA: 0x6DC3500
        public void UpdateWasPressed(){} // RVA: 0x6DC3630
    }

    public class DeltaControl
    {
        public UnityEngine.InputSystem.Controls.AxisControl <up>k__BackingField; // 0x120
        public UnityEngine.InputSystem.Controls.AxisControl <down>k__BackingField; // 0x128
        public UnityEngine.InputSystem.Controls.AxisControl <left>k__BackingField; // 0x130
        public UnityEngine.InputSystem.Controls.AxisControl <right>k__BackingField; // 0x138

        // ── Methods ──
        public void get_up(){} // RVA: 0x59E660
        public void set_up(){} // RVA: 0x59F420
        public void get_down(){} // RVA: 0xA8EE80
        public void set_down(){} // RVA: 0xD182E0
        public void get_left(){} // RVA: 0xA8E870
        public void set_left(){} // RVA: 0xDA3F70
        public void get_right(){} // RVA: 0xA933D0
        public void set_right(){} // RVA: 0xA96DC0
        public void FinishSetup(){} // RVA: 0x6DC36D0
        public void .ctor(){} // RVA: 0x6DC3920
    }

    public class DiscreteButtonControl
    {
        // ── Methods ──
        public void FinishSetup(){} // RVA: 0x6DC3930
        public void ReadUnprocessedValueFromState(){} // RVA: 0x6DC3A50
        public void WriteValueIntoState(){} // RVA: 0x6DC3B30
        public void .ctor(){} // RVA: 0x6DC3C90
    }

    public class DoubleControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DC3CA0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x6DC3D60
        public void WriteValueIntoState(){} // RVA: 0x6DC3DC0
    }

    public class DpadControl
    {
        public UnityEngine.InputSystem.Controls.ButtonControl <up>k__BackingField; // 0x120
        public UnityEngine.InputSystem.Controls.ButtonControl <down>k__BackingField; // 0x128
        public UnityEngine.InputSystem.Controls.ButtonControl <left>k__BackingField; // 0x130
        public UnityEngine.InputSystem.Controls.ButtonControl <right>k__BackingField; // 0x138

        // ── Methods ──
        public void get_up(){} // RVA: 0x59E660
        public void set_up(){} // RVA: 0x59F420
        public void get_down(){} // RVA: 0xA8EE80
        public void set_down(){} // RVA: 0xD182E0
        public void get_left(){} // RVA: 0xA8E870
        public void set_left(){} // RVA: 0xDA3F70
        public void get_right(){} // RVA: 0xA933D0
        public void set_right(){} // RVA: 0xA96DC0
        public void .ctor(){} // RVA: 0x6DC3E30
        public void FinishSetup(){} // RVA: 0x6DC3EA0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x6DC40F0
        public void WriteValueIntoState(){} // RVA: 0x6DC43C0
        public void MakeDpadVector(){} // RVA: 0x6DC4610 | overloaded x2
    }

    public class IntegerControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DC4860
        public void ReadUnprocessedValueFromState(){} // RVA: 0x6DC4920
        public void WriteValueIntoState(){} // RVA: 0x6DC49C0
        public void CalculateOptimizedControlDataType(){} // RVA: 0x6DC4A60
    }

    public class KeyControl
    {
        public 0x65868BE0 <keyCode>k__BackingField; // 0x148
        public int m_ScanCode; // 0x14C

        // ── Methods ──
        public void get_keyCode(){} // RVA: 0x15FA5E0
        public void set_keyCode(){} // RVA: 0x15DF3A0
        public void get_scanCode(){} // RVA: 0x6DC4B50
        public void RefreshConfiguration(){} // RVA: 0x6DC4BA0
        public void .ctor(){} // RVA: 0x6DC3C90
    }

    public class QuaternionControl
    {
        public UnityEngine.InputSystem.Controls.AxisControl <x>k__BackingField; // 0x120
        public UnityEngine.InputSystem.Controls.AxisControl <y>k__BackingField; // 0x128
        public UnityEngine.InputSystem.Controls.AxisControl <z>k__BackingField; // 0x130
        public UnityEngine.InputSystem.Controls.AxisControl <w>k__BackingField; // 0x138

        // ── Methods ──
        public void get_x(){} // RVA: 0x59E660
        public void set_x(){} // RVA: 0x59F420
        public void get_y(){} // RVA: 0xA8EE80
        public void set_y(){} // RVA: 0xD182E0
        public void get_z(){} // RVA: 0xA8E870
        public void set_z(){} // RVA: 0xDA3F70
        public void get_w(){} // RVA: 0xA933D0
        public void set_w(){} // RVA: 0xA96DC0
        public void .ctor(){} // RVA: 0x6DC4E10
        public void FinishSetup(){} // RVA: 0x6DC4ED0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x6DC5140
        public void WriteValueIntoState(){} // RVA: 0x6DC52A0
        public void CalculateOptimizedControlDataType(){} // RVA: 0x6DC53E0
    }

    public class StickControl
    {
        public UnityEngine.InputSystem.Controls.ButtonControl <up>k__BackingField; // 0x120
        public UnityEngine.InputSystem.Controls.ButtonControl <down>k__BackingField; // 0x128
        public UnityEngine.InputSystem.Controls.ButtonControl <left>k__BackingField; // 0x130
        public UnityEngine.InputSystem.Controls.ButtonControl <right>k__BackingField; // 0x138

        // ── Methods ──
        public void get_up(){} // RVA: 0x59E660
        public void set_up(){} // RVA: 0x59F420
        public void get_down(){} // RVA: 0xA8EE80
        public void set_down(){} // RVA: 0xD182E0
        public void get_left(){} // RVA: 0xA8E870
        public void set_left(){} // RVA: 0xDA3F70
        public void get_right(){} // RVA: 0xA933D0
        public void set_right(){} // RVA: 0xA96DC0
        public void FinishSetup(){} // RVA: 0x6DC56A0
        public void .ctor(){} // RVA: 0x6DC3920
    }

    public class TouchControl
    {
        public UnityEngine.InputSystem.Controls.TouchPressControl <press>k__BackingField; // 0x170
        public UnityEngine.InputSystem.Controls.IntegerControl <displayIndex>k__BackingField; // 0x178
        public UnityEngine.InputSystem.Controls.IntegerControl <touchId>k__BackingField; // 0x180
        public UnityEngine.InputSystem.Controls.Vector2Control <position>k__BackingField; // 0x188
        public UnityEngine.InputSystem.Controls.DeltaControl <delta>k__BackingField; // 0x190
        public UnityEngine.InputSystem.Controls.AxisControl <pressure>k__BackingField; // 0x198
        public UnityEngine.InputSystem.Controls.Vector2Control <radius>k__BackingField; // 0x1A0
        public UnityEngine.InputSystem.Controls.TouchPhaseControl <phase>k__BackingField; // 0x1A8
        public UnityEngine.InputSystem.Controls.ButtonControl <indirectTouch>k__BackingField; // 0x1B0
        public UnityEngine.InputSystem.Controls.ButtonControl <tap>k__BackingField; // 0x1B8
        public UnityEngine.InputSystem.Controls.IntegerControl <tapCount>k__BackingField; // 0x1C0
        public UnityEngine.InputSystem.Controls.DoubleControl <startTime>k__BackingField; // 0x1C8
        public UnityEngine.InputSystem.Controls.Vector2Control <startPosition>k__BackingField; // 0x1D0

        // ── Methods ──
        public void get_press(){} // RVA: 0x830040
        public void set_press(){} // RVA: 0xD8E320
        public void get_displayIndex(){} // RVA: 0x82F060
        public void set_displayIndex(){} // RVA: 0xD870D0
        public void get_touchId(){} // RVA: 0xDA5BB0
        public void set_touchId(){} // RVA: 0xD87C10
        public void get_position(){} // RVA: 0xD83B50
        public void set_position(){} // RVA: 0xD9F550
        public void get_delta(){} // RVA: 0xA90180
        public void set_delta(){} // RVA: 0xD96D90
        public void get_pressure(){} // RVA: 0xA974D0
        public void set_pressure(){} // RVA: 0xD9C360
        public void get_radius(){} // RVA: 0xDB1150
        public void set_radius(){} // RVA: 0xD95560
        public void get_phase(){} // RVA: 0xA94F10
        public void set_phase(){} // RVA: 0xDA25E0
        public void get_indirectTouch(){} // RVA: 0xDA5040
        public void set_indirectTouch(){} // RVA: 0xD8AAB0
        public void get_tap(){} // RVA: 0xDB2150
        public void set_tap(){} // RVA: 0xD94B20
        public void get_tapCount(){} // RVA: 0xA57F60
        public void set_tapCount(){} // RVA: 0xD94790
        public void get_startTime(){} // RVA: 0xDA62D0
        public void set_startTime(){} // RVA: 0xD94E00
        public void get_startPosition(){} // RVA: 0xDB3D70
        public void set_startPosition(){} // RVA: 0xD86540
        public void get_isInProgress(){} // RVA: 0x6DC58F0
        public void .ctor(){} // RVA: 0x6DC5960
        public void FinishSetup(){} // RVA: 0x6DC5A10
        public void ReadUnprocessedValueFromState(){} // RVA: 0x6DC6180
        public void WriteValueIntoState(){} // RVA: 0x6DC6210
    }

    public class TouchPhaseControl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DC62A0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x6DC6360
        public void WriteValueIntoState(){} // RVA: 0x6DC63D0
    }

    public class TouchPressControl
    {
        // ── Methods ──
        public void FinishSetup(){} // RVA: 0x6DC6440
        public void ReadUnprocessedValueFromState(){} // RVA: 0x6DC6560
        public void WriteValueIntoState(){} // RVA: 0x6DC65F0
        public void .ctor(){} // RVA: 0x6DC3C90
    }

    public class Vector2Control
    {
        public UnityEngine.InputSystem.Controls.AxisControl <x>k__BackingField; // 0x110
        public UnityEngine.InputSystem.Controls.AxisControl <y>k__BackingField; // 0x118

        // ── Methods ──
        public void get_x(){} // RVA: 0x507710
        public void set_x(){} // RVA: 0x509930
        public void get_y(){} // RVA: 0x507D10
        public void set_y(){} // RVA: 0x50A8C0
        public void .ctor(){} // RVA: 0x6DC6630
        public void FinishSetup(){} // RVA: 0x6DC66F0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x6DC6860
        public void WriteValueIntoState(){} // RVA: 0x6DC6940
        public void EvaluateMagnitude(){} // RVA: 0x6DC6A30
        public void CalculateOptimizedControlDataType(){} // RVA: 0x6DC6BA0
    }

    public class Vector3Control
    {
        public UnityEngine.InputSystem.Controls.AxisControl <x>k__BackingField; // 0x118
        public UnityEngine.InputSystem.Controls.AxisControl <y>k__BackingField; // 0x120
        public UnityEngine.InputSystem.Controls.AxisControl <z>k__BackingField; // 0x128

        // ── Methods ──
        public void get_x(){} // RVA: 0x507D10
        public void set_x(){} // RVA: 0x50A8C0
        public void get_y(){} // RVA: 0x59E660
        public void set_y(){} // RVA: 0x59F420
        public void get_z(){} // RVA: 0xA8EE80
        public void set_z(){} // RVA: 0xD182E0
        public void .ctor(){} // RVA: 0x6DC6D20
        public void FinishSetup(){} // RVA: 0x6DC6DE0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x6DC6FD0
        public void WriteValueIntoState(){} // RVA: 0x6DC70F0
        public void EvaluateMagnitude(){} // RVA: 0x6DC7210
        public void CalculateOptimizedControlDataType(){} // RVA: 0x6DC7390
    }

}