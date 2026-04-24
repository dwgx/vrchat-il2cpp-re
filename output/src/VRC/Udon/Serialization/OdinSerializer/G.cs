// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 8
// Methods: 34

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class GenericCollectionFormatter : Object
    {
        // ── Methods ──
        public void CanFormat(){} // RVA: 0x7FFD55408D80
    }

    public class GenericCollectionFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFD55406EA0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class GenericCollectionFormatter`2 : BaseFormatter`1
    {
        public tSupportedException_ConstructorMaxOf64Parameters<T1717696928> valueReaderWriter;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E2ADC40
        public void DeserializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void SerializeImplementation(){} // RVA: 0x7FFD4E099B30
    }

    public class GlobalSerializationConfig : Object
    {
        public ustment Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFD553DE850
        public void get_Logger(){} // RVA: 0x7FFD553DE8B0
        public void get_EditorSerializationFormat(){} // RVA: 0x7FFD4E446CB0
        public void get_BuildSerializationFormat(){} // RVA: 0x7FFD4E919180
        public void get_LoggingPolicy(){} // RVA: 0x7FFD4E919180
        public void get_ErrorHandlingPolicy(){} // RVA: 0x7FFD4E919180
        public void LoadInstanceIfAssetExists(){} // RVA: 0x7FFD4E341310
        public void get_HasInstanceLoaded(){} // RVA: 0x7FFD4E426850
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD553DE900
    }

    public class GradientAlphaKeyFormatter : MinimalBaseFormatter`1
    {
        public tSupportedException_ConstructorMaxOf64Parameters<float> FloatSerializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFD554388C0
        public void Write(){} // RVA: 0x7FFD55438980
        public void .ctor(){} // RVA: 0x7FFD55438A60
        public void .cctor(){} // RVA: 0x7FFD55438AC0
    }

    public class GradientColorKeyFormatter : MinimalBaseFormatter`1
    {
        public tSupportedException_ConstructorMaxOf64Parameters<?> ColorSerializer;
        public tSupportedException_ConstructorMaxOf64Parameters<float> FloatSerializer; // 0x8

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFD55438BA0
        public void Write(){} // RVA: 0x7FFD55438C70
        public void .ctor(){} // RVA: 0x7FFD55438D70
        public void .cctor(){} // RVA: 0x7FFD55438DD0
    }

    public class GradientFormatter : MinimalBaseFormatter`1
    {
        public tSupportedException_ConstructorMaxOf64Parameters<owMatrixOverride[]> AlphaKeysSerializer;
        public tSupportedException_ConstructorMaxOf64Parameters<NearPlane[]> ColorKeysSerializer; // 0x8
        public m.ber ModeProperty; // 0x10
        public tSupportedException_ConstructorMaxOf64Parameters<object> EnumSerializer; // 0x18

        // ── Methods ──
        public void GetUninitializedObject(){} // RVA: 0x7FFD55438F40
        public void Read(){} // RVA: 0x7FFD55438FC0
        public void Write(){} // RVA: 0x7FFD55439370
        public void .ctor(){} // RVA: 0x7FFD55439640
        public void .cctor(){} // RVA: 0x7FFD554396A0
    }

    public class GuidSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD554246A0
        public void WriteValue(){} // RVA: 0x7FFD55425390
        public void .ctor(){} // RVA: 0x7FFD55425470
    }

}