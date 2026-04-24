// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 12
// Methods: 46

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class CachedMemoryStream : Object
    {
        public object MemoryStream;

        // ── Methods ──
        public void get_MemoryStream(){} // RVA: 0x7FFD55409FC0
        public void .ctor(){} // RVA: 0x7FFD5540A0E0
        public void OnFreed(){} // RVA: 0x7FFD5540A1D0
        public void OnClaimed(){} // RVA: 0x7FFD5540A2F0
        public void Claim(){} // RVA: 0x7FFD5540A430 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD5540A520
    }

    public class CharSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD55422470
        public void WriteValue(){} // RVA: 0x7FFD55423140
        public void .ctor(){} // RVA: 0x7FFD55423210
    }

    public class Color32Formatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFD55437DC0
        public void Write(){} // RVA: 0x7FFD55437EE0
        public void .ctor(){} // RVA: 0x7FFD55438040
        public void .cctor(){} // RVA: 0x7FFD554380A0
    }

    public class ColorBlockFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFD55438180
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ColorBlockFormatter`1 : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFD4E099B30
        public void Write(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ColorFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFD55438440
        public void Write(){} // RVA: 0x7FFD55438570
        public void .ctor(){} // RVA: 0x7FFD554386D0
        public void .cctor(){} // RVA: 0x7FFD55438730
    }

    public class ComplexTypeSerializer`1 : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD4E2ADC40
        public void GetBaseFormatter(){} // RVA: 0x7FFD4E078F80
        public void WriteValue(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class CoroutineFormatter : Object
    {
        public object SerializedType;

        // ── Methods ──
        public void get_SerializedType(){} // RVA: 0x7FFD55438810
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFD4E919180
        public void Deserialize(){} // RVA: 0x7FFD4E919180
        public void Serialize(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class CustomFormatterAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3440C0 | overloaded x2
    }

    public class CustomGenericFormatterAttribute : CustomFormatterAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5540A580
    }

    public class CustomLogger : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5540A710
        public void LogWarning(){} // RVA: 0x7FFD52BB3490
        public void LogError(){} // RVA: 0x7FFD4E9A4BC0
        public void LogException(){} // RVA: 0x7FFD5191AEC0
    }

    public class CustomSerializationPolicy : Object
    {
        public object ID;
        public object AllowNonSerializableTypes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5540A840
        public void get_ID(){} // RVA: 0x7FFD4E35C380
        public void get_AllowNonSerializableTypes(){} // RVA: 0x7FFD4E35C4E0
        public void ShouldSerializeMember(){} // RVA: 0x7FFD5191AEC0
    }

}