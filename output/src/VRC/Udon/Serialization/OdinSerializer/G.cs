// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 8
// Methods: 34

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class GenericCollectionFormatter : Object
    {
        // ── Methods ──
        public void CanFormat(){} // RVA: 0x849BCC0
    }

    public class GenericCollectionFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x8499F50
        public void .ctor(){} // RVA: 0xB43310
    }

    public class GenericCollectionFormatter`2 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
        public void .ctor(){} // RVA: 0x894290
        public void GetUninitializedObject(){} // RVA: 0xA94080
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
    }

    public class GlobalSerializationConfig : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x84729F0
        public void get_Logger(){} // RVA: 0x8472A50
        public void get_EditorSerializationFormat(){} // RVA: 0xC50A80
        public void get_BuildSerializationFormat(){} // RVA: 0xDAC980
        public void get_LoggingPolicy(){} // RVA: 0xDAC980
        public void get_ErrorHandlingPolicy(){} // RVA: 0xDAC980
        public void LoadInstanceIfAssetExists(){} // RVA: 0xB43310
        public void get_HasInstanceLoaded(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x8472AA0
    }

    public class GradientAlphaKeyFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x84C9AA0
        public void Write(){} // RVA: 0x84C9B60
        public void .ctor(){} // RVA: 0x84C9C40
        public void .cctor(){} // RVA: 0x84C9CA0
    }

    public class GradientColorKeyFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x84C9D80
        public void Write(){} // RVA: 0x84C9E50
        public void .ctor(){} // RVA: 0x84C9F50
        public void .cctor(){} // RVA: 0x84C9FB0
    }

    public class GradientFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x84CA120
        public void Read(){} // RVA: 0x84CA1B0
        public void Write(){} // RVA: 0x84CA4D0
        public void .ctor(){} // RVA: 0x84CA720
        public void .cctor(){} // RVA: 0x84CA780
    }

    public class GuidSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84B6AB0
        public void WriteValue(){} // RVA: 0x84B76D0
        public void .ctor(){} // RVA: 0x84B7750
    }

}