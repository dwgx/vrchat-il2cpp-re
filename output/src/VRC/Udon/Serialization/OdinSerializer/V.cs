// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 13
// Methods: 55

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class VRCUrlFormatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x18B01E0
    }

    public class ValueTupleFormatter`1 : BaseFormatter`1
    {
        public object T1Serializer;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
        public void .ctor(){} // RVA: 0x894290
        public void GetUninitializedObject(){} // RVA: 0xA94080
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
    }

    public class ValueTupleFormatter`2 : BaseFormatter`1
    {
        public object T1Serializer;
        public object T2Serializer;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
        public void .ctor(){} // RVA: 0x894290
        public void GetUninitializedObject(){} // RVA: 0xA94080
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
    }

    public class ValueTupleFormatter`3 : BaseFormatter`1
    {
        public object T1Serializer;
        public object T2Serializer;
        public object T3Serializer;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
        public void .ctor(){} // RVA: 0x894290
        public void GetUninitializedObject(){} // RVA: 0xA94080
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
    }

    public class Vector2DictionaryKeyPathProvider : BaseDictionaryKeyPathProvider`1
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x84C7580
        public void Compare(){} // RVA: 0x84C75C0
        public void GetKeyFromPathString(){} // RVA: 0x84C7690
        public void GetPathStringFromKey(){} // RVA: 0x84C7760
        public void .ctor(){} // RVA: 0x84C7980
    }

    public class Vector2Formatter : MinimalBaseFormatter`1
    {
        public object FloatSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x84CC080
        public void Write(){} // RVA: 0x84CC140
        public void .ctor(){} // RVA: 0x84CC220
        public void .cctor(){} // RVA: 0x84CC280
    }

    public class Vector2IntFormatter : MinimalBaseFormatter`1
    {
        public object Serializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x84CCA80
        public void Write(){} // RVA: 0x84CCB40
        public void .ctor(){} // RVA: 0x84CCC20
        public void .cctor(){} // RVA: 0x84CCC80
    }

    public class Vector3DictionaryKeyPathProvider : BaseDictionaryKeyPathProvider`1
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x84C79B0
        public void Compare(){} // RVA: 0x84C79F0
        public void GetKeyFromPathString(){} // RVA: 0x84C7B00
        public void GetPathStringFromKey(){} // RVA: 0x84C7C70
        public void .ctor(){} // RVA: 0x84C7F20
    }

    public class Vector3Formatter : MinimalBaseFormatter`1
    {
        public object FloatSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x84CC360
        public void Write(){} // RVA: 0x84CC450
        public void .ctor(){} // RVA: 0x84CC570
        public void .cctor(){} // RVA: 0x84CC5D0
    }

    public class Vector3IntFormatter : MinimalBaseFormatter`1
    {
        public object Serializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x84CCD60
        public void Write(){} // RVA: 0x84CCE50
        public void .ctor(){} // RVA: 0x84CCF70
        public void .cctor(){} // RVA: 0x84CCFD0
    }

    public class Vector4DictionaryKeyPathProvider : BaseDictionaryKeyPathProvider`1
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x84C7F50
        public void Compare(){} // RVA: 0x84C7F90
        public void GetKeyFromPathString(){} // RVA: 0x84C80C0
        public void GetPathStringFromKey(){} // RVA: 0x84C82A0
        public void .ctor(){} // RVA: 0x84C85E0
    }

    public class Vector4Formatter : MinimalBaseFormatter`1
    {
        public object FloatSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x84CC6B0
        public void Write(){} // RVA: 0x84CC7E0
        public void .ctor(){} // RVA: 0x84CC940
        public void .cctor(){} // RVA: 0x84CC9A0
    }

    public class VersionFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0xDAC980
        public void Read(){} // RVA: 0x849C4B0
        public void Write(){} // RVA: 0x849C870
        public void .ctor(){} // RVA: 0x849C960
    }

}