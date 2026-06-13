// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Composites
// Classes: 7
// Methods: 37

namespace ThirdParty.Unity.UnityEngine.InputSystem.Composites
{
    public class AxisComposite
    {
        public int negative; // 0x10

        // ── Methods ──
        public void get_midPoint(){} // RVA: 0x6DDB950
        public void ReadValue(){} // RVA: 0x6DDB970
        public void EvaluateMagnitude(){} // RVA: 0x6DDBAA0
        public void .ctor(){} // RVA: 0x6DDBB30
    }

    public class ButtonWithOneModifier
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x6DDBB90
        public void ModifierIsPressed(){} // RVA: 0x6DDBC40
        public void EvaluateMagnitude(){} // RVA: 0x61D5F50
        public void FinishSetup(){} // RVA: 0x6DDBCB0
        public void .ctor(){} // RVA: 0x6DDBD30
    }

    public class ButtonWithTwoModifiers
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x6DDBD60
        public void ModifiersArePressed(){} // RVA: 0x6DDBE50
        public void EvaluateMagnitude(){} // RVA: 0x61D5F50
        public void FinishSetup(){} // RVA: 0x6DDBF10
        public void .ctor(){} // RVA: 0x6DDBF90
    }

    public class OneModifierComposite
    {
        public int modifier; // 0x10
        public int binding; // 0x14

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x30B130
        public void get_valueSizeInBytes(){} // RVA: 0x760030
        public void EvaluateMagnitude(){} // RVA: 0x6DDBFC0
        public void ReadValue(){} // RVA: 0x6DDC010
        public void ModifierIsPressed(){} // RVA: 0x6DDC080
        public void FinishSetup(){} // RVA: 0x6DDC0F0
        public void ReadValueAsObject(){} // RVA: 0x6DDC1B0
        public void DetermineValueTypeAndSize(){} // RVA: 0x6DDC200
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TwoModifiersComposite
    {
        public int modifier1; // 0x10
        public int modifier2; // 0x14

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x30B130
        public void get_valueSizeInBytes(){} // RVA: 0xCEF5B0
        public void EvaluateMagnitude(){} // RVA: 0x6DDC5D0
        public void ReadValue(){} // RVA: 0x6DDC620
        public void ModifiersArePressed(){} // RVA: 0x6DDC690
        public void FinishSetup(){} // RVA: 0x6DDC750
        public void ReadValueAsObject(){} // RVA: 0x6DDC810
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Vector2Composite
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x6DDC870
        public void EvaluateMagnitude(){} // RVA: 0x6DDC9F0
        public void .ctor(){} // RVA: 0x6DDCA20
    }

    public class Vector3Composite
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x6DDCA60
        public void EvaluateMagnitude(){} // RVA: 0x6DDCD20
        public void .ctor(){} // RVA: 0x6DDCD70
    }

}