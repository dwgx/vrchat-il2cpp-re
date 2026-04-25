// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Composites
// Classes: 7
// Methods: 37

namespace ThirdParty.Unity.UnityEngine.InputSystem.Composites
{
    public class AxisComposite : InputBindingComposite`1
    {
        public int midPoint; // 0x10
        public int positive; // 0x14
        public float minValue; // 0x18
        public float maxValue; // 0x1C
        public 0x6B152178 whichSideWins; // 0x20

        // ── Methods ──
        public void get_midPoint(){} // RVA: 0x7FFAC95740A0
        public void ReadValue(){} // RVA: 0x7FFAC95740C0
        public void EvaluateMagnitude(){} // RVA: 0x7FFAC95741F0
        public void .ctor(){} // RVA: 0x7FFAC9574280
    }

    public class ButtonWithOneModifier : InputBindingComposite`1
    {
        public int modifier; // 0x10
        public int button; // 0x14
        public bool overrideModifiersNeedToBePressedFirst; // 0x18
        public 0x6B152228 modifiersOrder; // 0x1C

        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAC95742E0
        public void ModifierIsPressed(){} // RVA: 0x7FFAC9574390
        public void EvaluateMagnitude(){} // RVA: 0x7FFAC896D690
        public void FinishSetup(){} // RVA: 0x7FFAC9574400
        public void .ctor(){} // RVA: 0x7FFAC9574480
    }

    public class ButtonWithTwoModifiers : InputBindingComposite`1
    {
        public int modifier1; // 0x10
        public int modifier2; // 0x14
        public int button; // 0x18
        public bool overrideModifiersNeedToBePressedFirst; // 0x1C
        public 0x6B1522D8 modifiersOrder; // 0x20

        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAC95744B0
        public void ModifiersArePressed(){} // RVA: 0x7FFAC95745A0
        public void EvaluateMagnitude(){} // RVA: 0x7FFAC896D690
        public void FinishSetup(){} // RVA: 0x7FFAC9574660
        public void .ctor(){} // RVA: 0x7FFAC95746E0
    }

    public class OneModifierComposite : InputBindingComposite
    {
        public int valueType; // 0x10
        public int valueSizeInBytes; // 0x14
        public bool overrideModifiersNeedToBePressedFirst; // 0x18
        public 0x6B152388 modifiersOrder; // 0x1C
        public int m_ValueSizeInBytes; // 0x20
        public System.Type m_ValueType; // 0x28
        public bool m_BindingIsButton; // 0x30

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFAC2F4F130
        public void get_valueSizeInBytes(){} // RVA: 0x7FFAC30DBBE0
        public void EvaluateMagnitude(){} // RVA: 0x7FFAC9574710
        public void ReadValue(){} // RVA: 0x7FFAC9574760
        public void ModifierIsPressed(){} // RVA: 0x7FFAC95747D0
        public void FinishSetup(){} // RVA: 0x7FFAC9574840
        public void ReadValueAsObject(){} // RVA: 0x7FFAC9574900
        public void DetermineValueTypeAndSize(){} // RVA: 0x7FFAC9574950
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TwoModifiersComposite : InputBindingComposite
    {
        public int valueType; // 0x10
        public int valueSizeInBytes; // 0x14
        public int binding; // 0x18
        public bool overrideModifiersNeedToBePressedFirst; // 0x1C
        public 0x6B152438 modifiersOrder; // 0x20
        public int m_ValueSizeInBytes; // 0x24
        public System.Type m_ValueType; // 0x28
        public bool m_BindingIsButton; // 0x30

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFAC2F4F130
        public void get_valueSizeInBytes(){} // RVA: 0x7FFAC3921980
        public void EvaluateMagnitude(){} // RVA: 0x7FFAC9574D20
        public void ReadValue(){} // RVA: 0x7FFAC9574D70
        public void ModifiersArePressed(){} // RVA: 0x7FFAC9574DE0
        public void FinishSetup(){} // RVA: 0x7FFAC9574EA0
        public void ReadValueAsObject(){} // RVA: 0x7FFAC9574F60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Vector2Composite : InputBindingComposite`1
    {
        public int up; // 0x10
        public int down; // 0x14
        public int left; // 0x18
        public int right; // 0x1C
        public bool normalize; // 0x20
        public 0x6B1524E8 mode; // 0x24

        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAC9574FC0
        public void EvaluateMagnitude(){} // RVA: 0x7FFAC9575140
        public void .ctor(){} // RVA: 0x7FFAC9575170
    }

    public class Vector3Composite : InputBindingComposite`1
    {
        public int up; // 0x10
        public int down; // 0x14
        public int left; // 0x18
        public int right; // 0x1C
        public int forward; // 0x20
        public int backward; // 0x24
        public 0x6B152598 mode; // 0x28

        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAC95751B0
        public void EvaluateMagnitude(){} // RVA: 0x7FFAC9575470
        public void .ctor(){} // RVA: 0x7FFAC95754C0
    }

}