// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 8
// Methods: 34

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class GenericCollectionFormatter : Object
    {
        // ── Methods ──
        public void CanFormat(){} // RVA: 0x7FFAC9FE8D80
    }

    public class GenericCollectionFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFAC9FE6EA0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class GenericCollectionFormatter`2 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> valueReaderWriter;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2E8DC40
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
    }

    public class GlobalSerializationConfig : Object
    {
        public VRC.Udon.Serialization.OdinSerializer.GlobalSerializationConfig Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC9FBE850
        public void get_Logger(){} // RVA: 0x7FFAC9FBE8B0
        public void get_EditorSerializationFormat(){} // RVA: 0x7FFAC3026CB0
        public void get_BuildSerializationFormat(){} // RVA: 0x7FFAC34F9180
        public void get_LoggingPolicy(){} // RVA: 0x7FFAC34F9180
        public void get_ErrorHandlingPolicy(){} // RVA: 0x7FFAC34F9180
        public void LoadInstanceIfAssetExists(){} // RVA: 0x7FFAC2F21310
        public void get_HasInstanceLoaded(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9FBE900
    }

    public class GradientAlphaKeyFormatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<float> FloatSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFACA0188C0
        public void Write(){} // RVA: 0x7FFACA018980
        public void .ctor(){} // RVA: 0x7FFACA018A60
        public void .cctor(){} // RVA: 0x7FFACA018AC0
    }

    public class GradientColorKeyFormatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<UnityEngine.Color> ColorSerializer;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<float> FloatSerializer; // 0x8

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFACA018BA0
        public void Write(){} // RVA: 0x7FFACA018C70
        public void .ctor(){} // RVA: 0x7FFACA018D70
        public void .cctor(){} // RVA: 0x7FFACA018DD0
    }

    public class GradientFormatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<UnityEngine.GradientAlphaKey[]> AlphaKeysSerializer;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<UnityEngine.GradientColorKey[]> ColorKeysSerializer; // 0x8
        public System.Reflection.PropertyInfo ModeProperty; // 0x10
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<object> EnumSerializer; // 0x18

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFACA018F40
        public void Read(){} // RVA: 0x7FFACA018FC0
        public void Write(){} // RVA: 0x7FFACA019370
        public void .ctor(){} // RVA: 0x7FFACA019640
        public void .cctor(){} // RVA: 0x7FFACA0196A0
    }

    public class GuidSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA0046A0
        public void WriteValue(){} // RVA: 0x7FFACA005390
        public void .ctor(){} // RVA: 0x7FFACA005470
    }

}