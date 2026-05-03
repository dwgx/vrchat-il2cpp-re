// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 6
// Methods: 22

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class RectFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE883CD750
        public void Write(){} // RVA: 0x7FFE883CD880
        public void .ctor(){} // RVA: 0x7FFE883CD9E0
        public void .cctor(){} // RVA: 0x7FFE883CDA40
    }

    public class ReflectionFormatter`1 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy _overridePolicy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void get_OverridePolicy(){} // RVA: 0x7FFE80E2E2E0
        public void set_OverridePolicy(){} // RVA: 0x7FFE80E460A0
        public void DeserializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void SerializeImplementation(){} // RVA: 0x7FFE80E4F230
    }

    public class ReflectionOrEmittedBaseFormatter`1 : ReflectionFormatter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class RegisterDictionaryKeyPathProviderAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class RegisterFormatterAttribute : Attribute
    {
        public System.Type _formatterType; // 0x10
        public int _priority; // 0x18

        // ── Methods ──
        public void get_FormatterType(){} // RVA: 0x7FFE81116380
        public void set_FormatterType(){} // RVA: 0x7FFE810FCE30
        public void get_Priority(){} // RVA: 0x7FFE813DB630
        public void set_Priority(){} // RVA: 0x7FFE8144DF00
        public void .ctor(){} // RVA: 0x7FFE82AF3A20
    }

    public class RegisterFormatterLocatorAttribute : Attribute
    {
        public System.Type _formatterLocatorType; // 0x10
        public int _priority; // 0x18

        // ── Methods ──
        public void get_FormatterLocatorType(){} // RVA: 0x7FFE81116380
        public void set_FormatterLocatorType(){} // RVA: 0x7FFE810FCE30
        public void get_Priority(){} // RVA: 0x7FFE813DB630
        public void set_Priority(){} // RVA: 0x7FFE8144DF00
        public void .ctor(){} // RVA: 0x7FFE82AF3A20
    }

}