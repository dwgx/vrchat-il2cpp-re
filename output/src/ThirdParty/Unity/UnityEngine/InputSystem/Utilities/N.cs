// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Utilities
// Classes: 3
// Methods: 37

namespace ThirdParty.Unity.UnityEngine.InputSystem.Utilities
{
    public class NameAndParameters
    {
        public string _name; // 0x10
        public UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.NamedValue> _shortCodeBtn; // 0x18

        // ── Methods ──
        public void get_name(){} // RVA: 0x1AD4690
        public void set_name(){} // RVA: 0x100A2F0
        public void get_parameters(){} // RVA: 0x1F6F090
        public void set_parameters(){} // RVA: 0x1F6F0A0
        public void ToString(){} // RVA: 0x6DD1DE0
        public void ParseMultiple(){} // RVA: 0x6DD2470 | overloaded x2
        public void ParseName(){} // RVA: 0x6DD2700
        public void Parse(){} // RVA: 0x6DD2790
        public void ParseNameAndParameters(){} // RVA: 0x6DD2820
    }

    public class NamedValue
    {
        public string Separator;
        public string <name>k__BackingField; // 0x10
        public UnityEngine.InputSystem.Utilities.PrimitiveValue <value>k__BackingField; // 0x18

        // ── Methods ──
        public void get_name(){} // RVA: 0x1AD4690
        public void set_name(){} // RVA: 0x100A2F0
        public void get_value(){} // RVA: 0x1F6F090
        public void set_value(){} // RVA: 0x1F74E00
        public void get_type(){} // RVA: 0x1EA9890
        public void ConvertTo(){} // RVA: 0x6DD2E30
        public void From(){} // RVA: 0x283FA0
        public void ToString(){} // RVA: 0x6DD2EC0
        public void Equals(){} // RVA: 0x6DD30D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6DD3170
        public void op_Equality(){} // RVA: 0x6DD3200
        public void op_Inequality(){} // RVA: 0x6DD3230
        public void ParseMultiple(){} // RVA: 0x6DD3260
        public void Parse(){} // RVA: 0x6DD3490
        public void ParseParameter(){} // RVA: 0x6DD34D0
        public void ApplyToObject(){} // RVA: 0x6DD3830
        public void ApplyAllToObject(){} // RVA: 0x283FA0
    }

    public class NumberHelpers
    {
        // ── Methods ──
        public void AlignToMultipleOf(){} // RVA: 0x6DD3B60 | overloaded x3
        public void Approximately(){} // RVA: 0x6DD3B80
        public void IntToNormalizedFloat(){} // RVA: 0x6DD3C50
        public void NormalizedFloatToInt(){} // RVA: 0x6DD3CA0
        public void UIntToNormalizedFloat(){} // RVA: 0x6DD3CF0
        public void NormalizedFloatToUInt(){} // RVA: 0x6DD3D40
        public void RemapUIntBitsToNormalizeFloatToUIntBits(){} // RVA: 0x6DD3DB0
    }

}