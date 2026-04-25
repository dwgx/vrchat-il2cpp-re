// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 6
// Methods: 22

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class RectFormatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<float> FloatSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFACA01AC40
        public void Write(){} // RVA: 0x7FFACA01AD70
        public void .ctor(){} // RVA: 0x7FFACA01AED0
        public void .cctor(){} // RVA: 0x7FFACA01AF30
    }

    public class ReflectionFormatter`1 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy OverridePolicy; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC68A0650 | overloaded x2
        public void get_OverridePolicy(){} // RVA: 0x7FFAC2F3C380
        public void set_OverridePolicy(){} // RVA: 0x7FFAC2F22E30
        public void DeserializeImplementation(){} // RVA: 0x7FFAC68A06E0
        public void SerializeImplementation(){} // RVA: 0x7FFAC68A1070
    }

    public class ReflectionOrEmittedBaseFormatter`1 : ReflectionFormatter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class RegisterDictionaryKeyPathProviderAttribute : Attribute
    {
        public System.Type ProviderType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class RegisterFormatterAttribute : Attribute
    {
        public System.Type FormatterType; // 0x10
        public int Priority; // 0x18

        // ── Methods ──
        public void get_FormatterType(){} // RVA: 0x7FFAC2F3C380
        public void set_FormatterType(){} // RVA: 0x7FFAC2F22E30
        public void get_Priority(){} // RVA: 0x7FFAC3157800
        public void set_Priority(){} // RVA: 0x7FFAC392CD10
        public void .ctor(){} // RVA: 0x7FFAC488C310
    }

    public class RegisterFormatterLocatorAttribute : Attribute
    {
        public System.Type FormatterLocatorType; // 0x10
        public int Priority; // 0x18

        // ── Methods ──
        public void get_FormatterLocatorType(){} // RVA: 0x7FFAC2F3C380
        public void set_FormatterLocatorType(){} // RVA: 0x7FFAC2F22E30
        public void get_Priority(){} // RVA: 0x7FFAC3157800
        public void set_Priority(){} // RVA: 0x7FFAC392CD10
        public void .ctor(){} // RVA: 0x7FFAC488C310
    }

}