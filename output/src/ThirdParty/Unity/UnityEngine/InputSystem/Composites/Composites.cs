// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Composites
// Classes: 7
// Methods: 37

namespace ThirdParty.Unity.UnityEngine.InputSystem.Composites
{
    public class AxisComposite : InputBindingComposite`1
    {
        public int negative; // 0x10

        // ── Methods ──
        public void get_midPoint(){} // RVA: 0x7FFE8791C7E0
        public void ReadValue(){} // RVA: 0x7FFE8791C800
        public void EvaluateMagnitude(){} // RVA: 0x7FFE8791C930
        public void .ctor(){} // RVA: 0x7FFE8791C9C0
    }

    public class ButtonWithOneModifier : InputBindingComposite`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE8791CA20
        public void ModifierIsPressed(){} // RVA: 0x7FFE8791CAD0
        public void EvaluateMagnitude(){} // RVA: 0x7FFE86D16D20
        public void FinishSetup(){} // RVA: 0x7FFE8791CB40
        public void .ctor(){} // RVA: 0x7FFE8791CBC0
    }

    public class ButtonWithTwoModifiers : InputBindingComposite`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE8791CBF0
        public void ModifiersArePressed(){} // RVA: 0x7FFE8791CCE0
        public void EvaluateMagnitude(){} // RVA: 0x7FFE86D16D20
        public void FinishSetup(){} // RVA: 0x7FFE8791CDA0
        public void .ctor(){} // RVA: 0x7FFE8791CE20
    }

    public class OneModifierComposite : InputBindingComposite
    {
        public int modifier; // 0x10
        public int binding; // 0x14

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFE81129130
        public void get_valueSizeInBytes(){} // RVA: 0x7FFE8151D690
        public void EvaluateMagnitude(){} // RVA: 0x7FFE8791CE50
        public void ReadValue(){} // RVA: 0x7FFE8791CEA0
        public void ModifierIsPressed(){} // RVA: 0x7FFE8791CF10
        public void FinishSetup(){} // RVA: 0x7FFE8791CF80
        public void ReadValueAsObject(){} // RVA: 0x7FFE8791D040
        public void DetermineValueTypeAndSize(){} // RVA: 0x7FFE8791D090
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TwoModifiersComposite : InputBindingComposite
    {
        public int modifier1; // 0x10
        public int modifier2; // 0x14

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFE81129130
        public void get_valueSizeInBytes(){} // RVA: 0x7FFE81A56130
        public void EvaluateMagnitude(){} // RVA: 0x7FFE8791D460
        public void ReadValue(){} // RVA: 0x7FFE8791D4B0
        public void ModifiersArePressed(){} // RVA: 0x7FFE8791D520
        public void FinishSetup(){} // RVA: 0x7FFE8791D5E0
        public void ReadValueAsObject(){} // RVA: 0x7FFE8791D6A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Vector2Composite : InputBindingComposite`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE8791D700
        public void EvaluateMagnitude(){} // RVA: 0x7FFE8791D880
        public void .ctor(){} // RVA: 0x7FFE8791D8B0
    }

    public class Vector3Composite : InputBindingComposite`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE8791D8F0
        public void EvaluateMagnitude(){} // RVA: 0x7FFE8791DBB0
        public void .ctor(){} // RVA: 0x7FFE8791DC00
    }

}