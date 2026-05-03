// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 12
// Methods: 46

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class CachedMemoryStream : Object
    {
        public int InitialCapacity;

        // ── Methods ──
        public void get_MemoryStream(){} // RVA: 0x7FFE8839CAB0
        public void .ctor(){} // RVA: 0x7FFE8839CBD0
        public void OnFreed(){} // RVA: 0x7FFE8839CCC0
        public void OnClaimed(){} // RVA: 0x7FFE8839CDE0
        public void Claim(){} // RVA: 0x7FFE8839CF20 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8839D010
    }

    public class CharSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883B4F80
        public void WriteValue(){} // RVA: 0x7FFE883B5C50
        public void .ctor(){} // RVA: 0x7FFE883B5D20
    }

    public class Color32Formatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE883CA8D0
        public void Write(){} // RVA: 0x7FFE883CA9F0
        public void .ctor(){} // RVA: 0x7FFE883CAB50
        public void .cctor(){} // RVA: 0x7FFE883CABB0
    }

    public class ColorBlockFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFE883CAC90
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ColorBlockFormatter`1 : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE80E4F230
        public void Write(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ColorFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE883CAF50
        public void Write(){} // RVA: 0x7FFE883CB080
        public void .ctor(){} // RVA: 0x7FFE883CB1E0
        public void .cctor(){} // RVA: 0x7FFE883CB240
    }

    public class ComplexTypeSerializer`1 : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE810A1420
        public void GetBaseFormatter(){} // RVA: 0x7FFE80E2E3D0
        public void WriteValue(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class CoroutineFormatter : Object
    {
        // ── Methods ──
        public void get_SerializedType(){} // RVA: 0x7FFE883CB320
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFE813240E0
        public void Deserialize(){} // RVA: 0x7FFE813240E0
        public void Serialize(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CustomFormatterAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0 | overloaded x2
    }

    public class CustomGenericFormatterAttribute : CustomFormatterAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8839D070
    }

    public class CustomLogger : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8839D200
        public void LogWarning(){} // RVA: 0x7FFE85A7C5E0
        public void LogError(){} // RVA: 0x7FFE81717120
        public void LogException(){} // RVA: 0x7FFE8487FE20
    }

    public class CustomSerializationPolicy : Object
    {
        public string id; // 0x10
        public bool allowNonSerializableTypes; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8839D330
        public void get_ID(){} // RVA: 0x7FFE81116380
        public void get_AllowNonSerializableTypes(){} // RVA: 0x7FFE811164E0
        public void ShouldSerializeMember(){} // RVA: 0x7FFE8487FE20
    }

}