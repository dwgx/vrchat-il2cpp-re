// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Composites
// Classes: 7
// Methods: 37

namespace ThirdParty.Unity.UnityEngine.InputSystem.Composites
{
    public class AxisComposite : InputBindingComposite`1
    {
        // ── Methods ──
        public void get_midPoint(){} // RVA: 0x7839720
        public void ReadValue(){} // RVA: 0x7839740
        public void EvaluateMagnitude(){} // RVA: 0x7839870
        public void .ctor(){} // RVA: 0x7839910
    }

    public class ButtonWithOneModifier : InputBindingComposite`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7839970
        public void ModifierIsPressed(){} // RVA: 0x7839A20
        public void EvaluateMagnitude(){} // RVA: 0x6C48C50
        public void FinishSetup(){} // RVA: 0x7839A90
        public void .ctor(){} // RVA: 0x7839B10
    }

    public class ButtonWithTwoModifiers : InputBindingComposite`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7839B40
        public void ModifiersArePressed(){} // RVA: 0x7839C30
        public void EvaluateMagnitude(){} // RVA: 0x6C48C50
        public void FinishSetup(){} // RVA: 0x7839CF0
        public void .ctor(){} // RVA: 0x7839D70
    }

    public class OneModifierComposite : InputBindingComposite
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0xB70160
        public void get_valueSizeInBytes(){} // RVA: 0xFEAE90
        public void EvaluateMagnitude(){} // RVA: 0x7839DA0
        public void ReadValue(){} // RVA: 0x7839DF0
        public void ModifierIsPressed(){} // RVA: 0x7839E60
        public void FinishSetup(){} // RVA: 0x7839ED0
        public void ReadValueAsObject(){} // RVA: 0x7839F90
        public void DetermineValueTypeAndSize(){} // RVA: 0x7839FE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TwoModifiersComposite : InputBindingComposite
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0xB70160
        public void get_valueSizeInBytes(){} // RVA: 0x15AF000
        public void EvaluateMagnitude(){} // RVA: 0x783A3B0
        public void ReadValue(){} // RVA: 0x783A400
        public void ModifiersArePressed(){} // RVA: 0x783A470
        public void FinishSetup(){} // RVA: 0x783A530
        public void ReadValueAsObject(){} // RVA: 0x783A5F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Vector2Composite : InputBindingComposite`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x783A650
        public void EvaluateMagnitude(){} // RVA: 0x783A7D0
        public void .ctor(){} // RVA: 0x783A800
    }

    public class Vector3Composite : InputBindingComposite`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x783A840
        public void EvaluateMagnitude(){} // RVA: 0x783AB00
        public void .ctor(){} // RVA: 0x783AB50
    }

}