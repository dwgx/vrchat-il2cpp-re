// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 7
// Methods: 26

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class RectFormatter : MinimalBaseFormatter`1
    {
        public object FloatSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x84CBCB0
        public void Write(){} // RVA: 0x84CBDE0
        public void .ctor(){} // RVA: 0x84CBF40
        public void .cctor(){} // RVA: 0x84CBFA0
    }

    public class ReflectionFormatter`1 : BaseFormatter`1
    {
        public object _overridePolicy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void get_OverridePolicy(){} // RVA: 0x87C0A0
        public void set_OverridePolicy(){} // RVA: 0x894320
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
    }

    public class ReflectionFormatter`1 : BaseFormatter`1
    {
        public object _overridePolicy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4A3FDC0
        public void get_OverridePolicy(){} // RVA: 0xB5DBF0
        public void set_OverridePolicy(){} // RVA: 0xB44D60
        public void DeserializeImplementation(){} // RVA: 0x4A3FE50
        public void SerializeImplementation(){} // RVA: 0x4A407C0
    }

    public class ReflectionOrEmittedBaseFormatter`1 : ReflectionFormatter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
    }

    public class RegisterDictionaryKeyPathProviderAttribute : Attribute
    {
        public object ProviderType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class RegisterFormatterAttribute : Attribute
    {
        public object _formatterType;
        public object _priority;

        // ── Methods ──
        public void get_FormatterType(){} // RVA: 0xB5DBF0
        public void set_FormatterType(){} // RVA: 0xB44D60
        public void get_Priority(){} // RVA: 0xE62D00
        public void set_Priority(){} // RVA: 0x1033F40
        public void .ctor(){} // RVA: 0x2615F10
    }

    public class RegisterFormatterLocatorAttribute : Attribute
    {
        public object _formatterLocatorType;
        public object _priority;

        // ── Methods ──
        public void get_FormatterLocatorType(){} // RVA: 0xB5DBF0
        public void set_FormatterLocatorType(){} // RVA: 0xB44D60
        public void get_Priority(){} // RVA: 0xE62D00
        public void set_Priority(){} // RVA: 0x1033F40
        public void .ctor(){} // RVA: 0x2615F10
    }

}