// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Composites
// Classes: 7
// Methods: 42

namespace ThirdParty.Unity.UnityEngine.InputSystem.Composites
{
    public class AxisComposite : InputBindingComposite`1
    {
        // ── Methods ──
        public void get_midPoint(){} // RVA: 0x7AEBCA230
        public void ReadValue(){} // RVA: 0x7AEBCA250
        public void EvaluateMagnitude(){} // RVA: 0x7AEBCA380
        public void .ctor(){} // RVA: 0x7AEBCA420
        public void negative(){} // RVA: 0x7B3F8A6E8
    }

    public class ButtonWithOneModifier : InputBindingComposite`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AEBCA480
        public void ModifierIsPressed(){} // RVA: 0x7AEBCA530
        public void EvaluateMagnitude(){} // RVA: 0x7ADFC29B0
        public void FinishSetup(){} // RVA: 0x7AEBCA5A0
        public void .ctor(){} // RVA: 0x7AEBCA620
    }

    public class ButtonWithTwoModifiers : InputBindingComposite`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AEBCA650
        public void ModifiersArePressed(){} // RVA: 0x7AEBCA740
        public void EvaluateMagnitude(){} // RVA: 0x7ADFC29B0
        public void FinishSetup(){} // RVA: 0x7AEBCA800
        public void .ctor(){} // RVA: 0x7AEBCA880
        public void modifier1(){} // RVA: 0x7B3F8A6E8
    }

    public class OneModifierComposite : InputBindingComposite
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7A8105330
        public void get_valueSizeInBytes(){} // RVA: 0x7A851DB90
        public void EvaluateMagnitude(){} // RVA: 0x7AEBCA8B0
        public void ReadValue(){} // RVA: 0x7AEBCA900
        public void ModifierIsPressed(){} // RVA: 0x7AEBCA970
        public void FinishSetup(){} // RVA: 0x7AEBCA9E0
        public void ReadValueAsObject(){} // RVA: 0x7AEBCAAA0
        public void DetermineValueTypeAndSize(){} // RVA: 0x7AEBCAAF0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void modifier(){} // RVA: 0x7B3F8A3B8
    }

    public class TwoModifiersComposite : InputBindingComposite
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7A8105330
        public void get_valueSizeInBytes(){} // RVA: 0x7A8AB15F0
        public void EvaluateMagnitude(){} // RVA: 0x7AEBCAED0
        public void ReadValue(){} // RVA: 0x7AEBCAF20
        public void ModifiersArePressed(){} // RVA: 0x7AEBCAF90
        public void FinishSetup(){} // RVA: 0x7AEBCB050
        public void ReadValueAsObject(){} // RVA: 0x7AEBCB110
        public void .ctor(){} // RVA: 0x7A80D7310
        public void modifier1(){} // RVA: 0x7B3F8A6E8
    }

    public class Vector2Composite : InputBindingComposite`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AEBCB170
        public void EvaluateMagnitude(){} // RVA: 0x7AEBCB2F0
        public void .ctor(){} // RVA: 0x7AEBCB320
    }

    public class Vector3Composite : InputBindingComposite`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AEBCB360
        public void EvaluateMagnitude(){} // RVA: 0x7AEBCB620
        public void .ctor(){} // RVA: 0x7AEBCB670
        public void up(){} // RVA: 0x7B3F8A6E8
    }

}