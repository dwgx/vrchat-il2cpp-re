// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 14
// Methods: 89

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class DateTimeFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x849B4C0
        public void Write(){} // RVA: 0x849B8B0
        public void .ctor(){} // RVA: 0x849B940
    }

    public class DateTimeOffsetFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x849B9A0
        public void Write(){} // RVA: 0x849BAD0
        public void .ctor(){} // RVA: 0x849BC00
    }

    public class DebugContext : Object
    {
        // ── Methods ──
        public void get_Logger(){} // RVA: 0x84AD7C0
        public void set_Logger(){} // RVA: 0x84AD130
        public void get_LoggingPolicy(){} // RVA: 0x84AD980
        public void set_LoggingPolicy(){} // RVA: 0x84AD990
        public void get_ErrorHandlingPolicy(){} // RVA: 0x699D350
        public void set_ErrorHandlingPolicy(){} // RVA: 0x699D360
        public void LogWarning(){} // RVA: 0x84AD9A0
        public void LogError(){} // RVA: 0x84ADAA0
        public void LogException(){} // RVA: 0x84ADBA0
        public void ResetToDefault(){} // RVA: 0x84ADD80
        public void .ctor(){} // RVA: 0x84ADEE0
    }

    public class DecimalSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84B57C0
        public void WriteValue(){} // RVA: 0x84B5BE0
        public void .ctor(){} // RVA: 0x84B5CC0
    }

    public class DefaultLoggers : Object
    {
        // ── Methods ──
        public void get_DefaultLogger(){} // RVA: 0x849D7D0
        public void get_UnityLogger(){} // RVA: 0x849D820
        public void .cctor(){} // RVA: 0x849DC90
    }

    public class DefaultSerializationBinder : TwoWaySerializationBinder
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x849DD40
        public void RegisterAllQueuedAssembliesRepeating(){} // RVA: 0x849E980
        public void RegisterQueuedAssemblies(){} // RVA: 0x849EA00
        public void RegisterQueuedAssemblyLoadEvents(){} // RVA: 0x849ECC0
        public void RegisterAssembly(){} // RVA: 0x849EFB0
        public void BindToName(){} // RVA: 0x849F520
        public void ContainsType(){} // RVA: 0x849FE00
        public void BindToType(){} // RVA: 0x849FFD0
        public void ParseTypeName(){} // RVA: 0x84A0370
        public void ParseName(){} // RVA: 0x84A0B10
        public void ParseGenericAndOrArrayType(){} // RVA: 0x84A0E50
        public void TryParseGenericAndOrArrayTypeName(){} // RVA: 0x84A1570
        public void Peek(){} // RVA: 0x84A1A20
        public void ReadGenericArg(){} // RVA: 0x84A1A70
        public void .ctor(){} // RVA: 0x84A1B80
    }

    public class DelegateFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x84954F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DelegateFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void GetUninitializedObject(){} // RVA: 0xA94080
    }

    public class DerivedDictionaryFormatter`3 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
        public void .ctor(){} // RVA: 0x894290
        public void GetUninitializedObject(){} // RVA: 0xA94080
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
    }

    public class DeserializationContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x84A1F70
        public void get_Binder(){} // RVA: 0x84A21F0
        public void set_Binder(){} // RVA: 0xD09D70
        public void get_StringReferenceResolver(){} // RVA: 0xBC1B30
        public void set_StringReferenceResolver(){} // RVA: 0xB6A8C0
        public void get_GuidReferenceResolver(){} // RVA: 0xBBF8F0
        public void set_GuidReferenceResolver(){} // RVA: 0xBBF900
        public void get_IndexReferenceResolver(){} // RVA: 0xBE58B0
        public void set_IndexReferenceResolver(){} // RVA: 0xCA4DF0
        public void get_StreamingContext(){} // RVA: 0x16CD810
        public void get_FormatterConverter(){} // RVA: 0xD33E60
        public void get_Config(){} // RVA: 0x84A22B0
        public void set_Config(){} // RVA: 0xB44D60
        public void RegisterInternalReference(){} // RVA: 0x84A2360
        public void GetInternalReference(){} // RVA: 0x84A23F0
        public void GetExternalObject(){} // RVA: 0x84A28D0
        public void Reset(){} // RVA: 0x84A2AD0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x84A2C80
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0xB43310
    }

    public class DictionaryFormatter`2 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
        public void .ctor(){} // RVA: 0x894290
        public void GetUninitializedObject(){} // RVA: 0x87C0A0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
    }

    public class DictionaryKeyUtility : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x84C24B0
        public void LogInvalidKeyPathProvider(){} // RVA: 0x84C4250
        public void GetPersistentPathKeyTypes(){} // RVA: 0x84C4400
        public void KeyTypeSupportsPersistentPaths(){} // RVA: 0x84C4450
        public void PrivateIsSupportedDictionaryKeyType(){} // RVA: 0x84C46B0
        public void GetDictionaryKeyString(){} // RVA: 0x84C47D0
        public void GetDictionaryKeyValue(){} // RVA: 0x84C5C70
        public void FromTo(){} // RVA: 0x84C68E0
    }

    public class DoubleLookupDictionaryFormatter`3 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
        public void .ctor(){} // RVA: 0x894290
        public void GetUninitializedObject(){} // RVA: 0x87C0A0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
    }

    public class DoubleSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84B5D30
        public void WriteValue(){} // RVA: 0x84B69D0
        public void .ctor(){} // RVA: 0x84B6A40
    }

}