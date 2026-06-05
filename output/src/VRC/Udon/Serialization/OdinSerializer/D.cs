// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 14
// Methods: 94

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class DateTimeFormatter
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAFA30E2B0
        public void Write(){} // RVA: 0x7FFAFA30E720
        public void .ctor(){} // RVA: 0x7FFAFA30E7B0
    }

    public class DateTimeOffsetFormatter
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAFA30E810
        public void Write(){} // RVA: 0x7FFAFA30E9C0
        public void .ctor(){} // RVA: 0x7FFAFA30EAF0
    }

    public class DebugContext
    {
        // ── Methods ──
        public void get_Logger(){} // RVA: 0x7FFAFA320E40
        public void set_Logger(){} // RVA: 0x7FFAFA3206F0
        public void get_LoggingPolicy(){} // RVA: 0x7FFAFA321030
        public void set_LoggingPolicy(){} // RVA: 0x7FFAFA321040
        public void get_ErrorHandlingPolicy(){} // RVA: 0x7FFAF89D57D0
        public void set_ErrorHandlingPolicy(){} // RVA: 0x7FFAF89D57E0
        public void LogWarning(){} // RVA: 0x7FFAFA321050
        public void LogError(){} // RVA: 0x7FFAFA321150
        public void LogException(){} // RVA: 0x7FFAFA321250
        public void ResetToDefault(){} // RVA: 0x7FFAFA321430
        public void .ctor(){} // RVA: 0x7FFAFA3215D0
    }

    public class DecimalSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAFA3290D0
        public void WriteValue(){} // RVA: 0x7FFAFA3294F0
        public void .ctor(){} // RVA: 0x7FFAFA3295D0
    }

    public class DefaultLoggers
    {
        // ── Methods ──
        public void get_DefaultLogger(){} // RVA: 0x7FFAFA310800
        public void get_UnityLogger(){} // RVA: 0x7FFAFA310850
        public void .cctor(){} // RVA: 0x7FFAFA310D00
    }

    public class DefaultSerializationBinder
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFA310DB0
        public void RegisterAllQueuedAssembliesRepeating(){} // RVA: 0x7FFAFA311A80
        public void RegisterQueuedAssemblies(){} // RVA: 0x7FFAFA311B00
        public void RegisterQueuedAssemblyLoadEvents(){} // RVA: 0x7FFAFA311DE0
        public void RegisterAssembly(){} // RVA: 0x7FFAFA3120F0
        public void BindToName(){} // RVA: 0x7FFAFA312670
        public void ContainsType(){} // RVA: 0x7FFAFA312F90
        public void BindToType(){} // RVA: 0x7FFAFA3131A0
        public void ParseTypeName(){} // RVA: 0x7FFAFA313580
        public void ParseName(){} // RVA: 0x7FFAFA313DB0
        public void ParseGenericAndOrArrayType(){} // RVA: 0x7FFAFA3140E0
        public void TryParseGenericAndOrArrayTypeName(){} // RVA: 0x7FFAFA314810
        public void Peek(){} // RVA: 0x7FFAFA314CE0
        public void ReadGenericArg(){} // RVA: 0x7FFAFA314D30
        public void .ctor(){} // RVA: 0x7FFAFA314E40
    }

    public class DelegateFormatterLocator
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFAFA308250
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DelegateFormatter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D33FA0
    }

    public class DerivedDictionaryFormatter`3
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D33FA0
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
    }

    public class DeserializationContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA315260 | overloaded x4
        public void get_Binder(){} // RVA: 0x7FFAFA3154E0
        public void set_Binder(){} // RVA: 0x7FFAF2F4B830
        public void get_StringReferenceResolver(){} // RVA: 0x7FFAF2E0A740
        public void set_StringReferenceResolver(){} // RVA: 0x7FFAF2DB5200
        public void get_GuidReferenceResolver(){} // RVA: 0x7FFAF2E08730
        public void set_GuidReferenceResolver(){} // RVA: 0x7FFAF2E08740
        public void get_IndexReferenceResolver(){} // RVA: 0x7FFAF2E2E0E0
        public void set_IndexReferenceResolver(){} // RVA: 0x7FFAF2EE54D0
        public void get_StreamingContext(){} // RVA: 0x7FFAF49AB630
        public void get_FormatterConverter(){} // RVA: 0x7FFAF30E74D0
        public void get_Config(){} // RVA: 0x7FFAFA3155A0
        public void set_Config(){} // RVA: 0x7FFAF2D8EE30
        public void RegisterInternalReference(){} // RVA: 0x7FFAFA315650
        public void GetInternalReference(){} // RVA: 0x7FFAFA3156E0
        public void GetExternalObject(){} // RVA: 0x7FFAFA315BC0 | overloaded x3
        public void Reset(){} // RVA: 0x7FFAFA315DC0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7FFAFA315F70
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7FFAF2D8D310
    }

    public class DictionaryFormatter`2
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2ABCD60
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
    }

    public class DictionaryKeyUtility
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFA336B70
        public void LogInvalidKeyPathProvider(){} // RVA: 0x7FFAFA338BA0
        public void GetPersistentPathKeyTypes(){} // RVA: 0x7FFAFA338D50
        public void KeyTypeSupportsPersistentPaths(){} // RVA: 0x7FFAFA338DA0
        public void PrivateIsSupportedDictionaryKeyType(){} // RVA: 0x7FFAFA339000
        public void GetDictionaryKeyString(){} // RVA: 0x7FFAFA339120
        public void GetDictionaryKeyValue(){} // RVA: 0x7FFAFA33A7D0
        public void FromTo(){} // RVA: 0x7FFAFA33B510
    }

    public class DoubleLookupDictionaryFormatter`3
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2ABCD60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
    }

    public class DoubleSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAFA329640
        public void WriteValue(){} // RVA: 0x7FFAFA32A410
        public void .ctor(){} // RVA: 0x7FFAFA32A480
    }

}