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
        public 0x664B2178 whichSideWins; // 0x20

        // ── Methods ──
        public void get_midPoint(){} // RVA: 0x7FFD549940A0
        public void ReadValue(){} // RVA: 0x7FFD549940C0
        public void EvaluateMagnitude(){} // RVA: 0x7FFD549941F0
        public void .ctor(){} // RVA: 0x7FFD54994280
    }

    public class ButtonWithOneModifier : InputBindingComposite`1
    {
        public int modifier; // 0x10
        public int button; // 0x14
        public bool overrideModifiersNeedToBePressedFirst; // 0x18
        public 0x664B2228 modifiersOrder; // 0x1C

        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD549942E0
        public void ModifierIsPressed(){} // RVA: 0x7FFD54994390
        public void EvaluateMagnitude(){} // RVA: 0x7FFD53D8D690
        public void FinishSetup(){} // RVA: 0x7FFD54994400
        public void .ctor(){} // RVA: 0x7FFD54994480
    }

    public class ButtonWithTwoModifiers : InputBindingComposite`1
    {
        public int modifier1; // 0x10
        public int modifier2; // 0x14
        public int button; // 0x18
        public bool overrideModifiersNeedToBePressedFirst; // 0x1C
        public 0x664B22D8 modifiersOrder; // 0x20

        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD549944B0
        public void ModifiersArePressed(){} // RVA: 0x7FFD549945A0
        public void EvaluateMagnitude(){} // RVA: 0x7FFD53D8D690
        public void FinishSetup(){} // RVA: 0x7FFD54994660
        public void .ctor(){} // RVA: 0x7FFD549946E0
    }

    public class OneModifierComposite : InputBindingComposite
    {
        public int valueType; // 0x10
        public int valueSizeInBytes; // 0x14
        public bool overrideModifiersNeedToBePressedFirst; // 0x18
        public 0x664B2388 modifiersOrder; // 0x1C
        public int m_ValueSizeInBytes; // 0x20
        public System.Type m_ValueType; // 0x28
        public bool m_BindingIsButton; // 0x30

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFD4E36F130
        public void get_valueSizeInBytes(){} // RVA: 0x7FFD4E4FBBE0
        public void EvaluateMagnitude(){} // RVA: 0x7FFD54994710
        public void ReadValue(){} // RVA: 0x7FFD54994760
        public void ModifierIsPressed(){} // RVA: 0x7FFD549947D0
        public void FinishSetup(){} // RVA: 0x7FFD54994840
        public void ReadValueAsObject(){} // RVA: 0x7FFD54994900
        public void DetermineValueTypeAndSize(){} // RVA: 0x7FFD54994950
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TwoModifiersComposite : InputBindingComposite
    {
        public int valueType; // 0x10
        public int valueSizeInBytes; // 0x14
        public int binding; // 0x18
        public bool overrideModifiersNeedToBePressedFirst; // 0x1C
        public 0x664B2438 modifiersOrder; // 0x20
        public int m_ValueSizeInBytes; // 0x24
        public System.Type m_ValueType; // 0x28
        public bool m_BindingIsButton; // 0x30

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFD4E36F130
        public void get_valueSizeInBytes(){} // RVA: 0x7FFD4ED41980
        public void EvaluateMagnitude(){} // RVA: 0x7FFD54994D20
        public void ReadValue(){} // RVA: 0x7FFD54994D70
        public void ModifiersArePressed(){} // RVA: 0x7FFD54994DE0
        public void FinishSetup(){} // RVA: 0x7FFD54994EA0
        public void ReadValueAsObject(){} // RVA: 0x7FFD54994F60
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Vector2Composite : InputBindingComposite`1
    {
        public int up; // 0x10
        public int down; // 0x14
        public int left; // 0x18
        public int right; // 0x1C
        public bool normalize; // 0x20
        public 0x664B24E8 mode; // 0x24

        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD54994FC0
        public void EvaluateMagnitude(){} // RVA: 0x7FFD54995140
        public void .ctor(){} // RVA: 0x7FFD54995170
    }

    public class Vector3Composite : InputBindingComposite`1
    {
        public int up; // 0x10
        public int down; // 0x14
        public int left; // 0x18
        public int right; // 0x1C
        public int forward; // 0x20
        public int backward; // 0x24
        public 0x664B2598 mode; // 0x28

        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD549951B0
        public void EvaluateMagnitude(){} // RVA: 0x7FFD54995470
        public void .ctor(){} // RVA: 0x7FFD549954C0
    }

}