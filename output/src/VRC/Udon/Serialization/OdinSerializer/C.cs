// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 12
// Methods: 46

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class CachedMemoryStream
    {
        // ── Methods ──
        public void get_MemoryStream(){} // RVA: 0x785FE10
        public void .ctor(){} // RVA: 0x785FF30
        public void OnFreed(){} // RVA: 0x7860020
        public void OnClaimed(){} // RVA: 0x7860140
        public void Claim(){} // RVA: 0x7860280 | overloaded x2
        public void .cctor(){} // RVA: 0x7860370
    }

    public class CharSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x78782C0
        public void WriteValue(){} // RVA: 0x7878F90
        public void .ctor(){} // RVA: 0x7879060
    }

    public class Color32Formatter
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x788DC10
        public void Write(){} // RVA: 0x788DD30
        public void .ctor(){} // RVA: 0x788DE90
        public void .cctor(){} // RVA: 0x788DEF0
    }

    public class ColorBlockFormatterLocator
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x788DFD0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ColorBlockFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x2DC60
        public void Write(){} // RVA: 0x2DC60
        public void .ctor(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class ColorFormatter
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x788E290
        public void Write(){} // RVA: 0x788E3C0
        public void .ctor(){} // RVA: 0x788E520
        public void .cctor(){} // RVA: 0x788E580
    }

    public class ComplexTypeSerializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x283FA0
        public void GetBaseFormatter(){} // RVA: 0xCE50
        public void WriteValue(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class CoroutineFormatter
    {
        // ── Methods ──
        public void get_SerializedType(){} // RVA: 0x788E660
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x519240
        public void Deserialize(){} // RVA: 0x519240
        public void Serialize(){} // RVA: 0x2DD310 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CustomFormatterAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0 | overloaded x2
    }

    public class CustomGenericFormatterAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x78603D0
    }

    public class CustomLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7860560
        public void LogWarning(){} // RVA: 0x288D780
        public void LogError(){} // RVA: 0x9A9580
        public void LogException(){} // RVA: 0x3BF7390
    }

    public class CustomSerializationPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7860690
        public void get_ID(){} // RVA: 0x2F8380
        public void get_AllowNonSerializableTypes(){} // RVA: 0x2F84E0
        public void ShouldSerializeMember(){} // RVA: 0x3BF7390
    }

}