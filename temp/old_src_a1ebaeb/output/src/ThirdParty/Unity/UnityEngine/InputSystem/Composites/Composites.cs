// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Composites
// Classes: 7
// Methods: 37

namespace ThirdParty.Unity.UnityEngine.InputSystem.Composites
{
    public class AxisComposite : InputBindingComposite`1
    {
        public object minValue; // 0x3376D7B0

        // ── Original Methods ──
        public void get_midPoint(){} // RVA: 0x7ffaaef96080
        public void ReadValue(){} // RVA: 0x7ffaaef960a0
        public void EvaluateMagnitude(){} // RVA: 0x7ffaaef961d0
        public void .ctor(){} // RVA: 0x7ffaaef96260
    }

    public class ButtonWithOneModifier : InputBindingComposite`1
    {
        public object overrideModifiersNeedToBePressedFirst; // 0x33456010

        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaaef962c0
        public void ModifierIsPressed(){} // RVA: 0x7ffaaef96370
        public void EvaluateMagnitude(){} // RVA: 0x7ffaae38e8a0
        public void FinishSetup(){} // RVA: 0x7ffaaef963e0
        public void .ctor(){} // RVA: 0x7ffaaef96460
    }

    public class ButtonWithTwoModifiers : InputBindingComposite`1
    {
        public object button; // 0x3376F380

        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaaef96490
        public void ModifiersArePressed(){} // RVA: 0x7ffaaef96580
        public void EvaluateMagnitude(){} // RVA: 0x7ffaae38e8a0
        public void FinishSetup(){} // RVA: 0x7ffaaef96640
        public void .ctor(){} // RVA: 0x7ffaaef966c0
    }

    public class OneModifierComposite : InputBindingComposite
    {
        public object overrideModifiersNeedToBePressedFirst; // 0x3348DA90
        public object m_ValueType; // 0x3348DA90

        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaa8960130
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaa8aeced0
        public void EvaluateMagnitude(){} // RVA: 0x7ffaaef966f0
        public void ReadValue(){} // RVA: 0x7ffaaef96740
        public void ModifierIsPressed(){} // RVA: 0x7ffaaef967b0
        public void FinishSetup(){} // RVA: 0x7ffaaef96820
        public void ReadValueAsObject(){} // RVA: 0x7ffaaef968e0
        public void DetermineValueTypeAndSize(){} // RVA: 0x7ffaaef96930
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class TwoModifiersComposite : InputBindingComposite
    {
        public object binding; // 0x33A8FC30
        public object m_ValueSizeInBytes; // 0x33A8FC30

        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaa8960130
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaa9349010
        public void EvaluateMagnitude(){} // RVA: 0x7ffaaef96d00
        public void ReadValue(){} // RVA: 0x7ffaaef96d50
        public void ModifiersArePressed(){} // RVA: 0x7ffaaef96dc0
        public void FinishSetup(){} // RVA: 0x7ffaaef96e80
        public void ReadValueAsObject(){} // RVA: 0x7ffaaef96f40
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class Vector2Composite : InputBindingComposite`1
    {
        public object left; // 0x336D46A0
        public object mode; // 0x336D46A0

        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaaef96fa0
        public void EvaluateMagnitude(){} // RVA: 0x7ffaaef97120
        public void .ctor(){} // RVA: 0x7ffaaef97150
    }

    public class Vector3Composite : InputBindingComposite`1
    {
        public object left; // 0x33B067E0
        public object backward; // 0x33B067E0

        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaaef97190
        public void EvaluateMagnitude(){} // RVA: 0x7ffaaef97450
        public void .ctor(){} // RVA: 0x7ffaaef974a0
    }

}