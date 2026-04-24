// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 12
// Methods: 46

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class CachedMemoryStream : Object
    {
        public object memoryStream; // 0x33C45EA0
        public object MemoryStream; // 0x17000031

        // ── Original Methods ──
        public void get_MemoryStream(){} // RVA: 0x7ffaafa0c9e0
        public void .ctor(){} // RVA: 0x7ffaafa0cb00
        public void OnFreed(){} // RVA: 0x7ffaafa0cbf0
        public void OnClaimed(){} // RVA: 0x7ffaafa0cd10
        public void Claim(){} // RVA: 0x7ffaafa0ce50
        public void Claim(){} // RVA: 0x7ffaafa0ce50
        public void .cctor(){} // RVA: 0x7ffaafa0cf40
    }

    public class CharSerializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa24e90
        public void WriteValue(){} // RVA: 0x7ffaafa25b60
        public void .ctor(){} // RVA: 0x7ffaafa25c30
    }

    public class Color32Formatter : MinimalBaseFormatter`1
    {
        // ── Original Methods ──
        public void Read(){} // RVA: 0x7ffaafa3a7e0
        public void Write(){} // RVA: 0x7ffaafa3a900
        public void .ctor(){} // RVA: 0x7ffaafa3aa60
        public void .cctor(){} // RVA: 0x7ffaafa3aac0
    }

    public class ColorBlockFormatterLocator : Object
    {
        // ── Original Methods ──
        public void TryGetFormatter(){} // RVA: 0x7ffaafa3aba0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ColorBlockFormatter`1 : MinimalBaseFormatter`1
    {
        public object normalColor; // 0x30E05640
        public object disabledColor; // 0x30E05640

        // ── Original Methods ──
        public void Read(){} // RVA: 0x7ffaa8669e70
        public void Write(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

    public class ColorFormatter : MinimalBaseFormatter`1
    {
        // ── Original Methods ──
        public void Read(){} // RVA: 0x7ffaafa3ae60
        public void Write(){} // RVA: 0x7ffaafa3af90
        public void .ctor(){} // RVA: 0x7ffaafa3b0f0
        public void .cctor(){} // RVA: 0x7ffaafa3b150
    }

    public class ComplexTypeSerializer`1 : Serializer`1
    {
        public object ComplexTypeIsNullable; // 0x30E1C1D0
        public object AllowDeserializeInvalidDataForT; // 0x30E1C1D0
        public object UnityPolicy; // 0x30E1C1D0
        public object UnityPolicyFormatter; // 0x30E1C1D0

        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaa887e5c0
        public void WriteValue(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetBaseFormatter(){} // RVA: 0x7ffaa86492c0
    }

    public class CoroutineFormatter : Object
    {
        // ── Original Methods ──
        public void get_SerializedType(){} // RVA: 0x7ffaafa3b230
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaa8f22da0
        public void Deserialize(){} // RVA: 0x7ffaa8f22da0
        public void Serialize(){} // RVA: 0x7ffaa8932310
        public void Serialize(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class CustomFormatterAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89350c0
        public void .ctor(){} // RVA: 0x7ffaa89350c0
    }

    public class CustomGenericFormatterAttribute : CustomFormatterAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaafa0cfa0
    }

    public class CustomLogger : Object
    {
        public object logExceptionDelegate; // 0x3397E0D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaafa0d130
        public void LogWarning(){} // RVA: 0x7ffaad11e050
        public void LogError(){} // RVA: 0x7ffaa8fb4260
        public void LogException(){} // RVA: 0x7ffaabf08370
    }

    public class CustomSerializationPolicy : Object
    {
        public object shouldSerializeFunc; // 0x339759E0
        public object ID; // 0x17000032

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaafa0d260
        public void get_ID(){} // RVA: 0x7ffaa894d380
        public void get_AllowNonSerializableTypes(){} // RVA: 0x7ffaa894d4e0
        public void ShouldSerializeMember(){} // RVA: 0x7ffaabf08370
    }

}