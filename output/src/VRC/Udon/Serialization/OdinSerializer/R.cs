// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 6
// Methods: 22

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class RectFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFD5543AC40
        public void Write(){} // RVA: 0x7FFD5543AD70
        public void .ctor(){} // RVA: 0x7FFD5543AED0
        public void .cctor(){} // RVA: 0x7FFD5543AF30
    }

    public class ReflectionFormatter`1 : BaseFormatter`1
    {
        public object OverridePolicy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD51CC0650 | overloaded x2
        public void get_OverridePolicy(){} // RVA: 0x7FFD4E35C380
        public void set_OverridePolicy(){} // RVA: 0x7FFD4E342E30
        public void DeserializeImplementation(){} // RVA: 0x7FFD51CC06E0
        public void SerializeImplementation(){} // RVA: 0x7FFD51CC1070
    }

    public class ReflectionOrEmittedBaseFormatter`1 : ReflectionFormatter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class RegisterDictionaryKeyPathProviderAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class RegisterFormatterAttribute : Attribute
    {
        public object FormatterType;
        public object Priority;

        // ── Methods ──
        public void get_FormatterType(){} // RVA: 0x7FFD4E35C380
        public void set_FormatterType(){} // RVA: 0x7FFD4E342E30
        public void get_Priority(){} // RVA: 0x7FFD4E577800
        public void set_Priority(){} // RVA: 0x7FFD4ED4CD10
        public void .ctor(){} // RVA: 0x7FFD4FCAC310
    }

    public class RegisterFormatterLocatorAttribute : Attribute
    {
        public object FormatterLocatorType;
        public object Priority;

        // ── Methods ──
        public void get_FormatterLocatorType(){} // RVA: 0x7FFD4E35C380
        public void set_FormatterLocatorType(){} // RVA: 0x7FFD4E342E30
        public void get_Priority(){} // RVA: 0x7FFD4E577800
        public void set_Priority(){} // RVA: 0x7FFD4ED4CD10
        public void .ctor(){} // RVA: 0x7FFD4FCAC310
    }

}