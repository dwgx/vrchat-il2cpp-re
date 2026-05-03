// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 14
// Methods: 94

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class DateTimeFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE8839AF70
        public void Write(){} // RVA: 0x7FFE8839B3E0
        public void .ctor(){} // RVA: 0x7FFE8839B470
    }

    public class DateTimeOffsetFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE8839B4D0
        public void Write(){} // RVA: 0x7FFE8839B680
        public void .ctor(){} // RVA: 0x7FFE8839B7B0
    }

    public class DebugContext : Object
    {
        public object LOCK; // 0x10
        public VRC.Udon.Serialization.OdinSerializer.ILogger logger; // 0x18
        public 0x6661DB6C loggingPolicy; // 0x20

        // ── Methods ──
        public void get_Logger(){} // RVA: 0x7FFE883ADB00
        public void set_Logger(){} // RVA: 0x7FFE883AD3B0
        public void get_LoggingPolicy(){} // RVA: 0x7FFE883ADCF0
        public void set_LoggingPolicy(){} // RVA: 0x7FFE883ADD00
        public void get_ErrorHandlingPolicy(){} // RVA: 0x7FFE86A665F0
        public void set_ErrorHandlingPolicy(){} // RVA: 0x7FFE86A66600
        public void LogWarning(){} // RVA: 0x7FFE883ADD10
        public void LogError(){} // RVA: 0x7FFE883ADE10
        public void LogException(){} // RVA: 0x7FFE883ADF10
        public void ResetToDefault(){} // RVA: 0x7FFE883AE0F0
        public void .ctor(){} // RVA: 0x7FFE883AE290
    }

    public class DecimalSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883B5D90
        public void WriteValue(){} // RVA: 0x7FFE883B61B0
        public void .ctor(){} // RVA: 0x7FFE883B6290
    }

    public class DefaultLoggers : Object
    {
        public object LOCK;
        public VRC.Udon.Serialization.OdinSerializer.ILogger unityLogger; // 0x8

        // ── Methods ──
        public void get_DefaultLogger(){} // RVA: 0x7FFE8839D4A0
        public void get_UnityLogger(){} // RVA: 0x7FFE8839D4F0
        public void .cctor(){} // RVA: 0x7FFE8839D9A0
    }

    public class DefaultSerializationBinder : TwoWaySerializationBinder
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8839DA50
        public void RegisterAllQueuedAssembliesRepeating(){} // RVA: 0x7FFE8839E720
        public void RegisterQueuedAssemblies(){} // RVA: 0x7FFE8839E7A0
        public void RegisterQueuedAssemblyLoadEvents(){} // RVA: 0x7FFE8839EA80
        public void RegisterAssembly(){} // RVA: 0x7FFE8839ED90
        public void BindToName(){} // RVA: 0x7FFE8839F330
        public void ContainsType(){} // RVA: 0x7FFE8839FC50
        public void BindToType(){} // RVA: 0x7FFE8839FE60
        public void ParseTypeName(){} // RVA: 0x7FFE883A0240
        public void ParseName(){} // RVA: 0x7FFE883A0A70
        public void ParseGenericAndOrArrayType(){} // RVA: 0x7FFE883A0DA0
        public void TryParseGenericAndOrArrayTypeName(){} // RVA: 0x7FFE883A14D0
        public void Peek(){} // RVA: 0x7FFE883A19A0
        public void ReadGenericArg(){} // RVA: 0x7FFE883A19F0
        public void .ctor(){} // RVA: 0x7FFE883A1B00
    }

    public class DelegateFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFE88394F10
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DelegateFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void DeserializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void SerializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void GetUninitializedObject(){} // RVA: 0x7FFE810A1420
    }

    public class DerivedDictionaryFormatter`3 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE80E46010
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void GetUninitializedObject(){} // RVA: 0x7FFE810A1420
        public void DeserializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void SerializeImplementation(){} // RVA: 0x7FFE80E4F230
    }

    public class DeserializationContext : Object
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationConfig config; // 0x10
        public System.Collections.Generic.Dictionary`2<int,object> internalIdReferenceMap; // 0x18
        public System.Runtime.Serialization.StreamingContext streamingContext; // 0x20
        public System.Runtime.Serialization.IFormatterConverter formatterConverter; // 0x30
        public VRC.Udon.Serialization.OdinSerializer.TwoWaySerializationBinder binder; // 0x38
        public VRC.Udon.Serialization.OdinSerializer.IExternalStringReferenceResolver _stringReferenceResolver; // 0x40
        public VRC.Udon.Serialization.OdinSerializer.IExternalGuidReferenceResolver _guidReferenceResolver; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE883A1F20 | overloaded x4
        public void get_Binder(){} // RVA: 0x7FFE883A21A0
        public void set_Binder(){} // RVA: 0x7FFE81437330
        public void get_StringReferenceResolver(){} // RVA: 0x7FFE81178740
        public void set_StringReferenceResolver(){} // RVA: 0x7FFE81123200
        public void get_GuidReferenceResolver(){} // RVA: 0x7FFE81176730
        public void set_GuidReferenceResolver(){} // RVA: 0x7FFE81176740
        public void get_IndexReferenceResolver(){} // RVA: 0x7FFE8119C0E0
        public void set_IndexReferenceResolver(){} // RVA: 0x7FFE812534D0
        public void get_StreamingContext(){} // RVA: 0x7FFE82C84C90
        public void get_FormatterConverter(){} // RVA: 0x7FFE8144E200
        public void get_Config(){} // RVA: 0x7FFE883A2260
        public void set_Config(){} // RVA: 0x7FFE810FCE30
        public void RegisterInternalReference(){} // RVA: 0x7FFE883A2310
        public void GetInternalReference(){} // RVA: 0x7FFE883A23A0
        public void GetExternalObject(){} // RVA: 0x7FFE883A2880 | overloaded x3
        public void Reset(){} // RVA: 0x7FFE883A2A80
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7FFE883A2C30
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7FFE810FB310
    }

    public class DictionaryFormatter`2 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE80E46010
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void GetUninitializedObject(){} // RVA: 0x7FFE80E2E2E0
        public void DeserializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void SerializeImplementation(){} // RVA: 0x7FFE80E4F230
    }

    public class DictionaryKeyUtility : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE883C3830
        public void LogInvalidKeyPathProvider(){} // RVA: 0x7FFE883C5860
        public void GetPersistentPathKeyTypes(){} // RVA: 0x7FFE883C5A10
        public void KeyTypeSupportsPersistentPaths(){} // RVA: 0x7FFE883C5A60
        public void PrivateIsSupportedDictionaryKeyType(){} // RVA: 0x7FFE883C5CC0
        public void GetDictionaryKeyString(){} // RVA: 0x7FFE883C5DE0
        public void GetDictionaryKeyValue(){} // RVA: 0x7FFE883C7490
        public void FromTo(){} // RVA: 0x7FFE883C81D0
    }

    public class DoubleLookupDictionaryFormatter`3 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE80E46010
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void GetUninitializedObject(){} // RVA: 0x7FFE80E2E2E0
        public void SerializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void DeserializeImplementation(){} // RVA: 0x7FFE80E4F230
    }

    public class DoubleSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883B6300
        public void WriteValue(){} // RVA: 0x7FFE883B70D0
        public void .ctor(){} // RVA: 0x7FFE883B7140
    }

}